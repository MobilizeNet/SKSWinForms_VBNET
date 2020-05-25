Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports UpgradeHelpers.DB.ADO
Imports UpgradeHelpers.Gui
Partial Friend Class frmRequestApproval
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
		isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		ReLoadForm(False)
	End Sub


	Private Sub frmRequestApproval_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub
	Private Id As String = ""


	Private Sub cmbStatus_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmbStatus.SelectedIndexChanged
		DoSearchRequest()
	End Sub

	Private Sub cmdApprove_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdApprove.Click
		LoadActionOrderRequest(1)
	End Sub

	Private Sub cmdCancel_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdCancel.Click
		LoadActionOrderRequest(2)
	End Sub

	Private Sub cmdInfo_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdInfo.Click
		LoadActionOrderRequest()
	End Sub

	Private Sub LoadActionOrderRequest(Optional ByVal Action As Integer = 0)
		Dim OrderId As Integer
		If fgOrders.CurrentRowIndex > 0 Then
			With frmActionOrderRequest.DefInstance
				OrderId = CInt(Convert.ToString(fgOrders(fgOrders.CurrentRowIndex, 1).Value))
				.OrderId = OrderId
				.Action = Action
				.LoadData()
				.Show()
			End With
		End If
	End Sub

	Private Sub dtFrom_ValueChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles dtFrom.ValueChanged
		chkFrom.CheckState = CheckState.Checked
		DoSearchRequest()
	End Sub

	Private Sub dtTo_ValueChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles dtTo.ValueChanged
		chkTo.CheckState = CheckState.Checked
		DoSearchRequest()
	End Sub


	Private Sub fgOrders_DoubleClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles fgOrders.DoubleClick
		cmdInfo_Click(cmdInfo, New EventArgs())
	End Sub

	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
	Private Sub Form_Load()
		InitGrid()
	End Sub

	Private isInitializingComponent As Boolean
	Private Sub txtOrderID_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtOrderID.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		DoSearchRequest()
	End Sub

	Private Sub txtProductID_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtProductID.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		DoSearchRequest()
	End Sub

	Private Sub txtCompanyName_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtCompanyName.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		DoSearchRequest()
	End Sub

	Private Sub txtContactLastName_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtContactLastName.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		DoSearchRequest()
	End Sub

	Private Sub txtContactName_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtContactName.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		DoSearchRequest()
	End Sub

	'UPGRADE_NOTE: (7001) The following declaration (txtName_Change) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
	'Private Sub txtName_Change()
		'DoSearchRequest()
	'End Sub

	Private Sub cmdClose_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdClose.Click
		Me.Close()
	End Sub

	Private Sub cmdCustomers_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdCustomers.Click
		frmCustomers.DefInstance.ShowDialog()
		txtCompanyName.Text = ""
		txtContactLastName.Text = ""
		txtContactName.Text = ""
		DoSearchRequest(CInt(frmCustomers.DefInstance.CurrentCustomerID))
		frmCustomers.DefInstance.Close()
	End Sub

	Private Sub DoSearchRequest(Optional ByVal Id As Integer = -1)
		Dim filter As String = ""
		If Id <> -1 Then
			filter = "o.CustomerID = " & Id
		End If
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not String.IsNullOrEmpty(txtCompanyName.Text) Then
			AppendAND(filter)
			filter = "c.CompanyName LIKE '%" & txtCompanyName.Text & "%'"
		End If
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not String.IsNullOrEmpty(txtContactName.Text) Then
			AppendAND(filter)
			filter = filter & "c.ContactFirstName LIKE '%" & txtContactName.Text & "%'"
		End If
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not String.IsNullOrEmpty(txtContactLastName.Text) Then
			AppendAND(filter)
			filter = filter & "c.ContactLastName LIKE '%" & txtContactLastName.Text & "%'"
		End If
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not String.IsNullOrEmpty(txtOrderID.Text) Then
			AppendAND(filter)
			filter = filter & "o.OrderID = " & txtOrderID.Text
		End If
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not String.IsNullOrEmpty(txtProductID.Text) Then
			AppendAND(filter)
			filter = filter & "d.ProductID LIKE '%" & txtProductID.Text & "%'"
		End If
		If chkFrom.CheckState = CheckState.Checked Then
			AppendAND(filter)
			'UPGRADE_WARNING: (1068) dtFrom.value of type Variant is being forced to Date. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1068
			filter = filter & "o.OrderDate >= '" & CDate(dtFrom.GetValue()).ToString("MM/dd/yyyy") & "'"
		End If
		If chkTo.CheckState = CheckState.Checked Then
			AppendAND(filter)
			'UPGRADE_WARNING: (1068) dtTo.value of type Variant is being forced to Date. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1068
			filter = filter & "o.OrderDate <= '" & CDate(dtTo.GetValue()).ToString("MM/dd/yyyy") & "'"
		End If
		If cmbStatus.SelectedIndex <> -1 And cmbStatus.Text <> "All" Then
			AppendAND(filter)
			filter = filter & "o.Status = UPPER('" & cmbStatus.Text & "')"
		End If

		Dim where As String = " Where o.OrderID = d.OrderID And c.CustomerID = o.CustomerID And u.Username = o.EmployeeId "
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not String.IsNullOrEmpty(filter) Then
			filter = where & " AND " & filter
		Else
			filter = where
		End If


		Dim sql As String = "Select o.OrderDate, o.OrderID, c.CompanyName, c.ContactFirstName + ' ' + c.ContactLastName as ContactName, u.Fullname as [Received by], Sum(d.LineTotal) as Price, o.Status " &  _
		                    "From OrderRequests as o, OrderRequestDetails as d, Customers as c, Users as u " &  _
		                    filter & " Group by o.orderDate, o.OrderID, c.CompanyName, c.ContactFirstName + ' ' + c.ContactLastName, u.Fullname, o.Status "
		ExecuteSql(sql)
		LogStatus("There are " & rs.RecordCount & " records with the selected criteria", Me)
		Dim i As Integer
		With fgOrders
			.RowsCount = rs.RecordCount + 1
			If .RowsCount = 1 Then .FixedRows = 0 Else .FixedRows = 1
			i = 1
			While Not rs.EOF
				For j As Integer = 0 To rs.FieldsMetadata.Count - 1
					If Not (rs.GetField(j) Is Nothing) Then
						fgOrders(i, j).Value = rs(j)
					End If
				Next j
				rs.MoveNext()
				i += 1
			End While
		End With
	End Sub

	Private Sub InitGrid()
		With fgOrders
			.RowsCount = 0
			.ColumnsCount = 7
			.FixedColumns = 0
			.AddItem("Date" & Constants.vbTab & "Order" & Constants.vbTab & "Customer" & Constants.vbTab & "Contact" & Constants.vbTab & "Received by" & Constants.vbTab & "Price" & Constants.vbTab & "Status")
			.RowsCount = 1
			.FixedRows = 0
			.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		End With
	End Sub

	''''''''''''''''''''''''''''''
	'''UNUSED CODE Start



	'UPGRADE_NOTE: (7001) The following declaration (MakeTextBoxVisible) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
	'Private Sub MakeTextBoxVisible(ByVal txtBox As TextBox, ByVal grid As UpgradeHelpers.DataGridViewFlex)
		'With grid
			'txtBox.Text = Convert.ToString(grid(.CurrentRowIndex, .CurrentColumnIndex).Value)
			'txtBox.SetBounds(.CellLeft / 15 + .Left, .CellTop / 15 + .Top, .CellWidth / 15, .CellHeight / 15)
			'txtBox.Visible = True
			'Application.DoEvents()
			'txtBox.Focus()
		'End With
	'End Sub
	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class