Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic
Imports System
Imports System.Media
Imports System.Windows.Forms
Imports UpgradeHelpers.DB.ADO
Imports UpgradeHelpers.Gui
Imports UpgradeHelpers.Helpers
Partial Friend Class frmOrderRequest
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


	Private Sub frmOrderRequest_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub
	Private currentCompanyName As String = ""
	Private currentIdCustomer As Integer
	Private currentContactName As String = ""
	Private editingData As Boolean

	Private currentSubTotal As Double
	Private currentTotal As Double
	Private currentTax As Double
	Private currentFreightCharge As Double
	Private currentTotalTax As Double
	Private editingQuantity As Boolean


	Private Sub cmdAddProducts_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdAddProducts.Click
		frmAddProductTo.DefInstance.Id = currentIdCustomer
		frmAddProductTo.DefInstance.ObjectReferred = "Customer " & txtCustomerCompany.Text & "|" & txtCustomerContact.Text
		frmAddProductTo.DefInstance.Table = "ProductsByCustomer"
		frmAddProductTo.DefInstance.ColumnName = "CustomerId"
		frmAddProductTo.DefInstance.LoadData()
		frmAddProductTo.DefInstance.ShowDialog()
		If frmAddProductTo.DefInstance.SavedChanges Then
			LoadProductsById()
		End If
	End Sub

	'UPGRADE_NOTE: (7001) The following declaration (txtName_Change) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
	'Private Sub txtName_Change()
		'DoSearchCustomer()
	'End Sub

	Private Sub DoSearchCustomer(Optional ByVal Id As String = "")
		Dim filter As String = ""
		'If Not IsEmpty(Id) Then
		If Id <> "" Then
			filter = "CustomerID = " & Id
		End If
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not String.IsNullOrEmpty(txtCompanyName.Text) Then
			'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
			If Not String.IsNullOrEmpty(filter) Then
				filter = filter & " AND "
			End If
			filter = "CompanyName LIKE '%" & txtCompanyName.Text & "%'"
		End If
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not String.IsNullOrEmpty(txtContactName.Text) Then
			'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
			If Not String.IsNullOrEmpty(filter) Then
				filter = filter & " AND "
			End If
			filter = filter & "ContactFirstName LIKE '%" & txtContactName.Text & "%'"
		End If
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not String.IsNullOrEmpty(txtContactLastName.Text) Then
			'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
			If Not String.IsNullOrEmpty(filter) Then
				filter = filter & " AND "
			End If
			filter = filter & "ContactLastName LIKE '%" & txtContactLastName.Text & "%'"
		End If

		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not String.IsNullOrEmpty(filter) Then
			filter = "Where " & filter
		End If
		ExecuteSql("Select CustomerID, CompanyName, ContactFirstName, ContactLastName, City, StateOrProvince, 'Country/Region' From Customers " & filter)
		lvCustomers.Items.Clear()
		Dim x As ListViewItem
		If rs.RecordCount = 0 Then
			LogStatus("There are no records with the selected criteria", Me)
		Else
			While Not rs.EOF
				x = lvCustomers.Items.Add(rs(0))
				For i = 1 To (rs.FieldsMetadata.Count - 1)
					'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
					If Not (rs.GetField(i) Is Nothing) Then
						ListViewHelper.GetListViewSubItem(x, i).Text = rs(i)
					End If
				Next i
				rs.MoveNext()
			End While
			If lvCustomers.Items.Count = 1 Then
				lvCustomers.Items(lvCustomers.Items.Item(0).Index).Selected = True
			End If
		End If
	End Sub

	Private Sub cmdClose_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdClose.Click
		Me.Close()
	End Sub

	Private Sub cmdCustomers_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdCustomers.Click
		'On Error Resume Next
		frmCustomers.DefInstance.ShowDialog()
		txtCompanyName.Text = ""
		txtContactLastName.Text = ""
		txtContactName.Text = ""
		DoSearchCustomer(frmCustomers.DefInstance.CurrentCustomerID)
		frmCustomers.DefInstance.Close()
	End Sub

	Private Sub cmdSave_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdSave.Click
		Dim newOrderId As Integer

		Try
			ExecuteSql("Select * from OrderRequests")
			rs.AddNew()
			rs("CustomerId") = currentIdCustomer
			rs("EmployeeId") = UserId
			Dim TempDate As Date
			rs("OrderDate") = IIf(DateTime.TryParse(DateTimeHelper.ToString(DateTime.Today), TempDate), TempDate.ToString("MM/dd/yyyy"), DateTimeHelper.ToString(DateTime.Today))
			'UPGRADE_WARNING: (1068) dtRequired.value of type Variant is being forced to String. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1068
			Dim TempDate2 As Date
			rs("RequiredByDate") = IIf(DateTime.TryParse(CStr(dtRequired.GetValue()), TempDate2), TempDate2.ToString("MM/dd/yyyy"), CStr(dtRequired.GetValue()))
			'UPGRADE_WARNING: (1068) dtPromised.value of type Variant is being forced to String. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1068
			Dim TempDate3 As Date
			rs("PromisedByDate") = IIf(DateTime.TryParse(CStr(dtPromised.GetValue()), TempDate3), TempDate3.ToString("MM/dd/yyyy"), CStr(dtPromised.GetValue()))
			rs("FreightCharge") = currentFreightCharge
			rs("SalesTaxRate") = currentTax * 0.01
			rs("Status") = "REQUESTED"
			rs.Update()

			ExecuteSql("SELECT last_insert_rowid() ")

			newOrderId = rs(0)


			For i = 1 To fgProducts.RowsCount - 1
				If Convert.ToString(fgProducts(i, 0).Value) <> "0" Then
					ExecuteSql("Insert into OrderRequestDetails (OrderID, ProductID, DateSold, Quantity, UnitPrice, SalePrice, LineTotal) Values (" & newOrderId & ", '" & Convert.ToString(fgProducts(i, 1).Value) & "', '" & DateTime.Today.ToString("MM/dd/yyyy") & "'," & Convert.ToString(fgProducts(i, 0).Value) & "," & Convert.ToString(fgProducts(i, 3).Value) & "," & Convert.ToString(fgProducts(i, 4).Value) & "," & Convert.ToString(fgProducts(i, 4).Value) & ")")

					ExecuteSql("Update Products Set UnitsOnOrder = UnitsOnOrder + " & Convert.ToString(fgProducts(i, 0).Value) &  _
					           " Where ProductId = '" & Convert.ToString(fgProducts(i, 1).Value) & "'")

				End If
			Next i

			editingData = False
			If MessageBox.Show("Order added successfully" & Environment.NewLine & "Would you like to add a new order?", "New data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
				ClearFields()
			Else
				Me.Close()
			End If

		Catch excep As System.Exception
			MessageBox.Show("An error has occurred adding the data. Error: (" & Information.Err().Number & ") " & excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub dtPromised_ValueChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles dtPromised.ValueChanged
		editingData = True
	End Sub

	Private Sub dtRequired_ValueChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles dtRequired.ValueChanged
		'If dtPromised.value < dtRequired.value Then
		'    dtPromised.value = dtRequired.value
		'End If
		editingData = True
	End Sub

	Private Sub MakeTextBoxVisible(ByVal txtBox As TextBox, ByVal grid As UpgradeHelpers.DataGridViewFlex)
		With grid
			If .CurrentRowIndex < 0 Or .CurrentColumnIndex < 0 Then Exit Sub
			txtBox.Text = Convert.ToString(grid(.CurrentRowIndex, .CurrentColumnIndex).Value)
			txtBox.Enabled = True

			txtBox.Focus()
			Application.DoEvents()
			editingQuantity = True
		End With
	End Sub

	Private Sub fgProducts_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles fgProducts.Click
		If fgProducts.CurrentColumnIndex <> 0 Then Exit Sub
		MakeTextBoxVisible(txtEntry, fgProducts)
		SelectAll(txtEntry)
	End Sub

	'UPGRADE_WARNING: (2050) MSFlexGridLib.MSFlexGrid Event fgProducts.EnterCell was not upgraded. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2050
	Private Sub fgProducts_EnterCell()
		SaveEdits()
	End Sub

	Private Sub fgProducts_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles fgProducts.KeyPress
		Dim KeyAscii As Integer = Convert.ToInt32(eventArgs.KeyChar)
		Try
			If fgProducts.CurrentColumnIndex <> 0 Then
				If KeyAscii = 0 Then
					eventArgs.Handled = True
				End If
				Exit Sub
			End If
			Select Case KeyAscii
				Case 46, 48 To 57
					'Case 45, 46, 47, 48 To 59, 65 To 90, 97 To 122
					MakeTextBoxVisible(txtEntry, fgProducts)
					txtEntry.Text = Strings.Chr(KeyAscii).ToString()
					txtEntry.SelectionStart = 1
			End Select
		Finally 
			If KeyAscii = 0 Then
				eventArgs.Handled = True
			End If
			eventArgs.KeyChar = Convert.ToChar(KeyAscii)
		End Try
	End Sub

	'UPGRADE_NOTE: (7001) The following declaration (EditKeyCode) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
	'Private Sub EditKeyCode(ByVal grid As UpgradeHelpers.DataGridViewFlex, ByRef txtBox As TextBox, ByVal KeyCode As Integer, ByVal Shift As Integer)
		'Select Case KeyCode
			'Case 27 'ESC
				'txtBox.Text = ""
				'txtBox.Visible = False
				'grid.Focus()
			'Case 13 'Return
				'grid.Focus()
			'Case 37 'Left Arrow
				'grid.Focus()
				'Application.DoEvents()
				'If grid.CurrentColumnIndex > grid.FixedColumns Then
					'grid.CurrentColumnIndex -= 1
				'End If
			'Case 38 'Up Arrow
				'grid.Focus()
				'Application.DoEvents()
				'If grid.CurrentRowIndex > grid.FixedRows Then
					'grid.CurrentRowIndex -= 1
				'End If
			'Case 39 'Right Arrow
				'grid.Focus()
				'Application.DoEvents()
				'If grid.CurrentColumnIndex < grid.ColumnsCount - 1 Then
					'grid.CurrentColumnIndex += 1
				'End If
			'Case 40 'Down Arrow
				'grid.Focus()
				'Application.DoEvents()
				'If grid.CurrentRowIndex < grid.RowsCount - 1 Then
					'grid.CurrentRowIndex += 1
				'End If
		'End Select
	'End Sub

	Private Sub txtEntry_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtEntry.Leave
		SaveEdits()
	End Sub


	Private Sub fgProducts_CellLeave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles fgProducts.CellLeave
		If editingQuantity Then
			SaveEdits()
		End If
	End Sub

	Private Sub SaveEdits()
		If Not editingQuantity Or Not ValidateTextBoxDouble(txtEntry, Me) Or Not ValidateTextDouble(Convert.ToString(fgProducts(fgProducts.CurrentRowIndex, 4).Value), Me) Then
			Exit Sub
		End If
		Dim previousLinePrice As Double = DoubleValue(Convert.ToString(fgProducts(fgProducts.CurrentRowIndex, 4).Value))
		fgProducts(fgProducts.CurrentRowIndex, fgProducts.CurrentColumnIndex).Value = txtEntry.Text
		Dim lineQuantity As Double = DoubleValue(txtEntry.Text)
		Dim lineUnitPrice As Double = DoubleValue(Convert.ToString(fgProducts(fgProducts.CurrentRowIndex, 3).Value))
		previousLinePrice = DoubleValue(Convert.ToString(fgProducts(fgProducts.CurrentRowIndex, 4).Value))
		Dim linePrice As Double = lineQuantity * lineUnitPrice
		fgProducts(fgProducts.CurrentRowIndex, 4).Value = CStr(linePrice)
		ReCalculateTotals(previousLinePrice, linePrice)
		editingQuantity = False
		txtEntry.Enabled = False
		txtEntry.Text = ""

		editingData = True
	End Sub

	Private Sub ReCalculateTotals(ByVal previous As Double, ByVal current As Double)
		currentSubTotal = currentSubTotal - previous + current
		currentTotalTax = currentSubTotal * currentTax * 0.01
		currentTotal = currentFreightCharge + currentSubTotal + currentTotalTax
		txtSubTotal.Text = StringsHelper.Format(currentSubTotal, "#,##0.00")
		txtTotalTax.Text = StringsHelper.Format(currentTotalTax, "#,##0.00")
		txtTotal.Text = StringsHelper.Format(currentTotal, "#,##0.00")
	End Sub

	Private Sub Form_FormClosing(ByVal eventSender As Object, ByVal eventArgs As FormClosingEventArgs) Handles MyBase.FormClosing
		Dim Cancel As Integer = IIf(eventArgs.Cancel, 1, 0)
		Dim UnloadMode As Integer = CInt(eventArgs.CloseReason)
		Try
			Dim res As DialogResult
			If editingData Then
				res = MessageBox.Show("Do you want to save the edited data?", "Save data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
				If res = System.Windows.Forms.DialogResult.Yes Then
					cmdSave_Click(cmdSave, New EventArgs())
				ElseIf res <> System.Windows.Forms.DialogResult.No Then 
					Cancel = True
				End If
			End If
		Finally 
			eventArgs.Cancel = Cancel <> 0
		End Try
	End Sub

	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
	Private Sub Form_Load()
		editingData = False
		ClearFields()
	End Sub

	Private Sub lvCustomers_ItemClick(ByVal Item As ListViewItem)
		RetrieveDataCustomer()
	End Sub

	Private Sub RetrieveDataCustomer()
		If editingData Then
			If MessageBox.Show("Do you want to cancel previous edited data?", "Data edition", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> System.Windows.Forms.DialogResult.Yes Then
				Exit Sub
			End If
		End If

		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not (lvCustomers.FocusedItem Is Nothing) Then
			With lvCustomers.FocusedItem
				currentIdCustomer = CInt(lvCustomers.FocusedItem.Text)
				currentCompanyName = ListViewHelper.GetListViewSubItem(lvCustomers.FocusedItem, 1).Text
				currentContactName = ListViewHelper.GetListViewSubItem(lvCustomers.FocusedItem, 2).Text & " " & ListViewHelper.GetListViewSubItem(lvCustomers.FocusedItem, 3).Text
			End With
			txtCustomerCompany.Text = currentCompanyName
			txtCustomerContact.Text = currentContactName
			editingData = False
		End If
		LoadProductsById()
		cmdSave.Enabled = True
		cmdAddProducts.Enabled = True
		dtRequired.Enabled = True
		dtPromised.Enabled = True

	End Sub

	Private Sub LoadProductsById()
		Dim Table As String = "ProductsByCustomer"
		Dim ColumnName As String = "CustomerId"
		Dim Id As Integer = currentIdCustomer

		ExecuteSql("Select p.ProductID, p.ProductName, p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.QuantityPerUnit, p.Unit from Products as p, " & Table & " as pb Where pb." & ColumnName & " = " & CStr(Id) & " And pb.ProductId = p.ProductId")

		'lvProducts.ListItems.Clear
		'If rs.RecordCount > 0 Then
		'    With rs
		'        While Not .EOF
		'            Set x = lvProducts.ListItems.Add(, , 0)
		'            For i = 1 To 5
		'                If Not IsEmpty(.Fields(i - 1)) Then
		'                    x.SubItems(i) = .Fields(i - 1)
		'                End If
		'            Next i
		'            x.SubItems(6) = .Fields(5) & .Fields(6)
		'            .MoveNext
		'        Wend
		'    End With
		'End If

		Dim lng As Integer
		Dim intLoopCount As Integer
		Const SCROOL_WIDTH As Integer = 320
		Dim i As Integer
		With fgProducts
			.ColumnsCount = 8
			.FixedColumns = 0
			.RowsCount = 0
			.AddItem("Quantity" & Constants.vbTab & "Code" & Constants.vbTab & "Product" & Constants.vbTab & "UnitPrice" & Constants.vbTab & "Price" & Constants.vbTab & "Existence" & Constants.vbTab & "Ordered" & Constants.vbTab & "Quantity per unit")
			.RowsCount = rs.RecordCount + 1
			If .RowsCount = 1 Then .FixedRows = 0 Else .FixedRows = 1
			i = 1
			While Not rs.EOF
				fgProducts(i, 0).Value = "0"
				For j As Integer = 1 To 6
					If j = 4 Then
						fgProducts(i, j).Value = "0"
					ElseIf j < 4 Then 
						fgProducts(i, j).Value = rs(j - 1)
					Else
						fgProducts(i, j).Value = rs(j - 2)
					End If
				Next j
				fgProducts(i, 7).Value = rs(5) & rs(6)
				rs.MoveNext()
				i += 1
			End While
		End With
	End Sub

	'UPGRADE_NOTE: (7001) The following declaration (lvProducts_ItemCheck) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
	'Private Sub lvProducts_ItemCheck(ByVal Item As ListViewItem)
		'If Item.Checked Then
			'Item.Text = "1"
		'Else
			'Item.Text = "0"
		'End If
	'End Sub

	Private isInitializingComponent As Boolean
	Private Sub txtCompanyName_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtCompanyName.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		DoSearchCustomer()
	End Sub

	Private Sub txtContactLastName_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtContactLastName.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		DoSearchCustomer()
	End Sub

	Private Sub txtContactName_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtContactName.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		DoSearchCustomer()
	End Sub

	Private Sub ClearFields()

		fgProducts.RowsCount = 0
		fgProducts.ColumnsCount = 0

		currentSubTotal = 0
		currentTotal = 0
		currentTax = 0
		currentTotalTax = 0
		currentFreightCharge = 0

		txtSubTotal.Text = ""
		txtTotal.Text = ""
		txtTotalTax.Text = ""
		txtSalesTax.Text = ""
		txtFreightCharge.Text = ""

		txtCompanyName.Text = ""
		txtContactLastName.Text = ""
		txtContactName.Text = ""
		txtCustomerContact.Text = ""
		txtCustomerCompany.Text = ""
		cmdSave.Enabled = False
		cmdAddProducts.Enabled = False
		dtRequired.Enabled = False
		dtPromised.Enabled = False
		'txtCompanyName.SetFocus
		'txtCompanyName.SetFocus
		ReCalculateTotals(0, 0)
		editingData = False
	End Sub

	Private Sub txtFreightCharge_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtFreightCharge.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		currentFreightCharge = DoubleValue(txtFreightCharge.Text)
		ReCalculateTotals(0, 0)
		editingData = True
	End Sub

	Private Sub txtFreightCharge_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles txtFreightCharge.KeyPress
		Dim KeyAscii As Integer = Convert.ToInt32(eventArgs.KeyChar)
		Try
			Select Case KeyAscii
				Case Keys.D0 To Keys.D9, Keys.Back, Keys.Clear, Keys.Delete, Keys.Left, Keys.Right, Keys.Up, Keys.Down, Keys.Tab
				Case Else
					KeyAscii = 0
					SystemSounds.Beep.Play()
			End Select
		Finally 
			If KeyAscii = 0 Then
				eventArgs.Handled = True
			End If
			eventArgs.KeyChar = Convert.ToChar(KeyAscii)
		End Try
	End Sub

	Private Sub txtSalesTax_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtSalesTax.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		currentTax = DoubleValue(txtSalesTax.Text)
		ReCalculateTotals(0, 0)
		editingData = True
	End Sub

	Private Sub txtSalesTax_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles txtSalesTax.KeyPress
		Dim KeyAscii As Integer = Convert.ToInt32(eventArgs.KeyChar)
		Try
			Select Case KeyAscii
				Case Keys.D0 To Keys.D9, Keys.Back, Keys.Clear, Keys.Delete, Keys.Left, Keys.Right, Keys.Up, Keys.Down, Keys.Tab
				Case Else
					KeyAscii = 0
					SystemSounds.Beep.Play()
			End Select
		Finally 
			If KeyAscii = 0 Then
				eventArgs.Handled = True
			End If
			eventArgs.KeyChar = Convert.ToChar(KeyAscii)
		End Try
	End Sub
	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class