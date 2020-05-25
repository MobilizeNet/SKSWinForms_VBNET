Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports UpgradeHelpers.DB.ADO
Imports UpgradeHelpers.Helpers
Partial Friend Class frmActionOrderReception
	Inherits System.Windows.Forms.Form
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try
					'For the start-up form, the first instance created is the default instance.
					If Not (System.Reflection.Assembly.GetExecutingAssembly().EntryPoint Is Nothing) AndAlso System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.GetType() Then
						m_vb6FormDefInstance = Me
					End If

				Catch
				End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		ReLoadForm(False)
	End Sub


	Private Sub frmActionOrderReception_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub

	Private currentSubTotal As Double
	Private currentTotal As Double
	Private currentTax As Double
	Private currentFreightCharge As Double
	Private currentTotalTax As Double

	Public Action As Integer

	Public OrderId As Integer

	Private Sub cmdApprove_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdApprove.Click
		Try
			If txtStatus.Text.ToUpper() = "APPROVED" Then
				LogStatus("Order is already approved, not need to be approved again", Me)
				Exit Sub
			End If

			If txtStatus.Text.ToUpper() = "CANCELLED" Then
				LogStatus("Order was already approved by " & txtChangedBy.Text & " on " & txtChanged.Text & ", it cannot be cancelled", Me)
				Exit Sub
			End If

			' UPDATE
			ExecuteSql("Update OrderReceptions Set Status = 'APPROVED', ChangedBy = '" & UserId & "', ChangedDate = '" & DateTimeHelper.ToString(DateTime.Today) & "'" &  _
			           " Where OrderId = " & CStr(OrderId))

			ExecuteSql("Select ProductId, Quantity, UnitPrice, LineTotal " &  _
			           "From OrderReceptionDetails Where OrderID = " & CStr(OrderId))


			Dim newId As Integer
			While Not rs.EOF

				ExecuteSql2("Insert Into Stocks " &  _
				            "(ProductID, Stock, InitialStock, DateStarted, DateModified, User, UnitPrice, StockPrice) Values " &  _
				            "('" & rs("ProductId") & "'," & rs("Quantity") & "," & rs("Quantity") & ", '" & DateTimeHelper.ToString(DateTime.Today) & "', '" & DateTimeHelper.ToString(DateTime.Today) & "', '" & UserId & "', " & rs("UnitPrice") & "," & rs("LineTotal") & ")")

				ExecuteSql2("Select Max(StockID) as NewId From Stocks")
				newId = rs2("NewId")

				ExecuteSql2("Insert Into StockLog " &  _
				            "(Date, DocID, DocType, ProductID, Quantity, StockID, StockPrice, User) Values " &  _
				            "('" & DateTimeHelper.ToString(DateTime.Today) & "','" & rs("ProductId") & "','" & rs("ProductId") & "','" & rs("ProductId") & "','" & rs("ProductId") & "','" & rs("Quantity") & "','" & rs("ProductID") & "','" & UserId & "')")
				rs.MoveNext()
			End While

			ExecuteSql("Insert Into Stocks " &  _
			           "(ProductID, Stock, InitialStock, DateStarted, DateModified, User, UnitPrice, StockPrice) " &  _
			           "Select ProductId, Quantity, Quantity, '" & DateTimeHelper.ToString(DateTime.Today) & "', '" & DateTimeHelper.ToString(DateTime.Today) & "', '" & UserId & "', UnitPrice, LineTotal " &  _
			           "From OrderReceptionDetails " &  _
			           "Where OrderID = " & CStr(OrderId))

			ExecuteSql("Update Products Set UnitsInStock = UnitsInStock + " &  _
			           " (Select Sum(Quantity) From OrderReceptionDetails Where OrderID = " & CStr(OrderId) & " and ProductID = Products.ProductID) " &  _
			           " Where ProductId in (Select ProductID From OrderReceptionDetails Where OrderID = " & CStr(OrderId) & ")")

			LoadData()
			MessageBox.Show("The order was successfully approved", My.Application.Info.Title)
			Me.Close()

		Catch excep As System.Exception
			MessageBox.Show("An error has occurred adding the data. Error: (" & Information.Err().Number & ") " & excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try

	End Sub

	Private Sub cmdCancel_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdCancel.Click
		Try
			If txtStatus.Text.ToUpper() = "CANCELLED" Then
				LogStatus("Order was already cancelled, not need to be cancelled again", Me)
				Exit Sub
			End If
			If txtStatus.Text.ToUpper() = "APPROVED" Then
				LogStatus("Order was already cancelled by " & txtChangedBy.Text & " on " & txtChanged.Text & ", it cannot be approved", Me)
				Exit Sub
			End If

			If MessageBox.Show("Do you want to cancel the order reception?", "Confirm cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> System.Windows.Forms.DialogResult.Yes Then
				Exit Sub
			End If

			' UPDATE
			ExecuteSql("Update OrderReceptions Set Status = 'CANCELLED', ChangedBy = '" & UserId & "', ChangedDate = '" & DateTimeHelper.ToString(DateTime.Today) & "'" &  _
			           " Where OrderId = " & CStr(OrderId))

			LoadData()
			MessageBox.Show("The order was successfully cancelled", My.Application.Info.Title)
			Me.Close()

		Catch excep As System.Exception
			MessageBox.Show("An error has occurred adding the data. Error: (" & Information.Err().Number & ") " & excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try

	End Sub

	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
	Private Sub Form_Load()
		'LoadData
		If Action <> 0 Then

			Select Case (Action)
				Case 1
					cmdApprove_Click(cmdApprove, New EventArgs())
				Case 2
					cmdCancel_Click(cmdCancel, New EventArgs())
			End Select
		End If
	End Sub

	Public Sub LoadData()
		currentSubTotal = 0
		currentTotalTax = 0
		ExecuteSql("Select o.OrderDate, u.Fullname, o.Status, p.ProviderName, p.ContactFirstName + ' ' + p.ContactLastName as Contact, o.ChangedDate, o.ChangedBy, o.FreightCharge, o.SalesTaxRate, o.Notes " &  _
		           "From OrderReceptions as o, Users as u, Providers as p " &  _
		           "Where o.OrderID = " & CStr(OrderId) & " And u.Username = o.ReceivedBy And p.ProviderId = o.ProviderId")
		If rs.EOF Then
			LogStatus("The order with the ID '" & OrderId & "' does not exist", Me)
			Exit Sub
		End If
		txtOrderID.Text = CStr(OrderId)
		txtReceived.Text = rs("OrderDate")
		txtReceivedBy.Text = rs("Fullname")
		'UPGRADE_WARNING: (1049) Use of Null/IsNull() detected. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1049
		If Not System.DBNull.Value.Equals(rs("Notes")) Then txtNotes.Text = rs("Notes")
		txtFreightCharge.Text = rs("FreightCharge")
		currentFreightCharge = rs("FreightCharge")
		txtSalesTax.Text = rs("SalesTaxRate")
		currentTax = rs("SalesTaxRate")
		txtProviderCompany.Text = rs("ProviderName")
		txtProviderContact.Text = rs("Contact")
		txtStatus.Text = rs("Status")
		'UPGRADE_WARNING: (1049) Use of Null/IsNull() detected. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1049
		If Not System.DBNull.Value.Equals(rs("ChangedDate")) Then txtChanged.Text = rs("ChangedDate")
		'UPGRADE_WARNING: (1049) Use of Null/IsNull() detected. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1049
		If Not System.DBNull.Value.Equals(rs("ChangedBy")) Then txtChangedBy.Text = rs("ChangedBy")

		Dim isReceived As Boolean = txtStatus.Text = "RECEIVED"
		lblChanged.Visible = Not isReceived
		lblChangedBy.Visible = Not isReceived
		txtChanged.Visible = Not isReceived
		txtChangedBy.Visible = Not isReceived
		cmdApprove.Enabled = True ' Received
		cmdCancel.Enabled = True ' Received

		If txtStatus.Text = "APPROVED" Then
			lblChanged.Text = "Approved Date:"
			lblChangedBy.Text = "Approved By:"
		Else
			lblChanged.Text = "Cancelled Date:"
			lblChangedBy.Text = "Cancelled By:"
		End If
		LoadDetails()
		DisplayTotals()
	End Sub

	Private Sub DisplayTotals()
		currentTotal = currentFreightCharge + currentSubTotal + currentTotalTax
		txtSubTotal.Text = StringsHelper.Format(currentSubTotal, "#,##0.00")
		txtTotalTax.Text = StringsHelper.Format(currentTotalTax, "#,##0.00")
		txtTotal.Text = StringsHelper.Format(currentTotal, "#,##0.00")
	End Sub


	Private Sub AddToTotals(ByVal current As Double)
		currentSubTotal += current
		currentTotalTax = currentSubTotal * currentTax
		currentTotal = currentFreightCharge + currentSubTotal + currentTotalTax
		txtSubTotal.Text = StringsHelper.Format(currentSubTotal, "#,##0.00")
		txtTotalTax.Text = StringsHelper.Format(currentTotalTax, "#,##0.00")
		txtTotal.Text = StringsHelper.Format(currentTotal, "#,##0.00")
	End Sub

	Private Sub cmdClose_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdClose.Click
		Me.Close()
	End Sub

	Private Sub LoadDetails()

		ExecuteSql("Select d.Quantity, p.ProductID, p.ProductName, d.UnitPrice, d.SalePrice, p.UnitsInStock, p.UnitsOnOrder, p.QuantityPerUnit + p.Unit, d.LineTotal From Products as p, OrderReceptionDetails as d " &  _
		           "Where d.OrderID = " & CStr(OrderId) & " And d.ProductId = p.ProductId")

		Dim lng As Integer
		Dim intLoopCount, i As Integer
		With fgDetails
			.RowsCount = 0
			.ColumnsCount = 9
			.FixedColumns = 0
			.AddItem("Quantity" & Constants.vbTab & "Code" & Constants.vbTab & "Product" & Constants.vbTab & "UnitPrice" & Constants.vbTab & "Price" & Constants.vbTab & "Existence" & Constants.vbTab & "Ordered" & Constants.vbTab & "Quantity per unit" & Constants.vbTab & "Line Total")
			.RowsCount = rs.RecordCount + 1
			If .RowsCount = 1 Then .FixedRows = 0 Else .FixedRows = 1
			i = 1
			While Not rs.EOF
				For j As Integer = 1 To rs.FieldsMetadata.Count
					'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
					If Not (rs.GetField(i) Is Nothing) Then
						fgDetails(i, j - 1).Value = rs(j - 1)
					End If
				Next j
				AddToTotals(rs("LineTotal"))
				rs.MoveNext()
				i += 1
			End While
		End With

	End Sub
	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class