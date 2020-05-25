Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic
Imports System
Imports System.Media
Imports System.Windows.Forms
Imports UpgradeHelpers.DB.ADO
Imports UpgradeHelpers.Gui
Imports UpgradeHelpers.Helpers
Partial Friend Class frmOrderReception
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


	Private Sub frmOrderReception_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub
	Private currentProviderName As String = ""
	Private currentIdProvider As Integer
	Private currentContactName As String = ""
	Private editingData As Boolean

	Private currentSubTotal As Double
	Private currentTotal As Double
	Private currentTax As Double
	Private currentFreightCharge As Double
	Private currentTotalTax As Double

	Private Sub cmdAddProducts_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdAddProducts.Click
		frmAddProductTo.DefInstance.Id = currentIdProvider
		frmAddProductTo.DefInstance.ObjectReferred = "Provider " & txtProviderCompany.Text & "|" & txtProviderContact.Text
		frmAddProductTo.DefInstance.Table = "ProductsByProvider"
		frmAddProductTo.DefInstance.ColumnName = "ProviderId"
		frmAddProductTo.DefInstance.LoadData()
		frmAddProductTo.DefInstance.ShowDialog()
		If frmAddProductTo.DefInstance.SavedChanges Then
			LoadProductsById()
		End If
	End Sub

	'UPGRADE_NOTE: (7001) The following declaration (txtName_Change) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
	'Private Sub txtName_Change()
		'DoSearchProvider()
	'End Sub

	Private Sub DoSearchProvider(Optional ByVal Id As Integer = 0)
		Dim filter As String = ""
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not Id.Equals(0) Then
			filter = "ProviderID = " & Id
		End If
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not String.IsNullOrEmpty(txtProviderName.Text) Then
			'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
			If Not String.IsNullOrEmpty(filter) Then
				filter = filter & " AND "
			End If
			filter = "ProviderName LIKE '%" & txtProviderName.Text & "%'"
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
		ExecuteSql("Select ProviderID, ProviderName, ContactFirstName, ContactLastName, City, StateOrProvince, 'Country/Region' From Providers " & filter)
		lvProviders.Items.Clear()
		Dim x As ListViewItem
		If rs.RecordCount = 0 Then
			LogStatus("There are no records with the selected criteria", Me)
		Else
			While Not rs.EOF
				x = lvProviders.Items.Add(rs(0))
				For i = 1 To (rs.FieldsMetadata.Count - 1)
					'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
					If Not (rs.GetField(i) Is Nothing) Then
						ListViewHelper.GetListViewSubItem(x, i).Text = rs(i)
					End If
				Next i
				rs.MoveNext()
			End While
			If lvProviders.Items.Count = 1 Then
				lvProviders.Items(lvProviders.Items.Item(0).Index).Selected = True
			End If
		End If
	End Sub

	Private Sub cmdClose_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdClose.Click
		Me.Close()
	End Sub

	Private Sub cmdProviders_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdProviders.Click
		frmProviders.DefInstance.ShowDialog()
		txtProviderName.Text = ""
		txtContactLastName.Text = ""
		txtContactName.Text = ""
		DoSearchProvider(frmProviders.DefInstance.CurrentProviderID)
	End Sub

	Private Sub cmdSave_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdSave.Click
		Dim newOrderId As Integer

		Try
			ExecuteSql("Select * from OrderReceptions")
			rs.AddNew()
			rs("ProviderId") = currentIdProvider
			rs("ReceivedBy") = UserId
			rs("OrderDate") = DateTimeHelper.ToString(DateTime.Today)
			rs("Notes") = txtNotes.Text
			rs("FreightCharge") = currentFreightCharge
			rs("SalesTaxRate") = currentTax * 0.01
			rs("Status") = "RECEIVED"
			rs.Update()

			ExecuteSql("SELECT last_insert_rowid() ")
			newOrderId = rs(0)

			For i = 1 To fgProducts.RowsCount - 1
				If Convert.ToString(fgProducts(i, 0).Value) <> "0" Then
					ExecuteSql("Insert into OrderReceptionDetails (OrderID, ProductID, DateSold, Quantity, UnitPrice, SalePrice, SalesTax, LineTotal) Values (" & newOrderId & ", '" & Convert.ToString(fgProducts(i, 1).Value) & "', '" & DateTime.Today.ToString("MM/dd/yyyy") & "'," & Convert.ToString(fgProducts(i, 0).Value) & "," & Convert.ToString(fgProducts(i, 3).Value) & "," & Convert.ToString(fgProducts(i, 4).Value) & "," & CStr(currentTax * 0.01) & "," & Convert.ToString(fgProducts(i, 4).Value) & ")")

					'UnitsInTransit
					'ExecuteSql "Update Products Set UnitsOnOrder = UnitsOnOrder + " & fgProducts.TextMatrix(i, 0) & _
					'        '" Where ProductId = '" & fgProducts.TextMatrix(i, 1) & "'"

				End If
			Next i



			editingData = False
			If MessageBox.Show("Order reception added successfully" & Environment.NewLine & "Would you like to add a new order reception?", "New data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
				ClearFields()
			Else
				Me.Close()
			End If

		Catch excep As System.Exception
			MessageBox.Show("An error has occurred adding the data. Error: (" & Information.Err().Number & ") " & excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub MakeTextBoxVisible(ByVal txtBox As TextBox, ByVal grid As UpgradeHelpers.DataGridViewFlex)
		With grid
			txtBox.Text = Convert.ToString(grid(.CurrentRowIndex, .CurrentColumnIndex).Value)
			'txtBox.Move .CellLeft + .Left, .CellTop + .Top, .CellWidth, .CellHeight
			txtBox.Visible = True
			txtBox.Enabled = True
			'DoEvents
			txtBox.Focus()
			SelectAll(txtBox)
		End With
	End Sub

	Private Sub fgProducts_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles fgProducts.Click
		If fgProducts.CurrentColumnIndex <> 0 Then Exit Sub
		MakeTextBoxVisible(txtEntry, fgProducts)
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

	Private Sub txtEntry_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles txtEntry.KeyDown
		Dim KeyCode As Integer = eventArgs.KeyCode
		Dim Shift As Integer = eventArgs.KeyData / 65536
		Try
			EditKeyCode(fgProducts, txtEntry, KeyCode, Shift)
		Finally 
			eventArgs.Handled = KeyCode = 0
		End Try
	End Sub

	Private Sub EditKeyCode(ByVal grid As UpgradeHelpers.DataGridViewFlex, ByRef txtBox As TextBox, ByVal KeyCode As Integer, ByVal Shift As Integer)
		Select Case KeyCode
			Case 27 'ESC
				txtBox.Text = ""
				txtBox.Visible = False
				grid.Focus()
			Case 13 'Return
				grid.Focus()
			Case 37 'Left Arrow
				grid.Focus()
				Application.DoEvents()
				If grid.CurrentColumnIndex > grid.FixedColumns Then
					grid.CurrentColumnIndex -= 1
				End If
			Case 38 'Up Arrow
				grid.Focus()
				Application.DoEvents()
				If grid.CurrentRowIndex > grid.FixedRows Then
					grid.CurrentRowIndex -= 1
				End If
			Case 39 'Right Arrow
				grid.Focus()
				Application.DoEvents()
				If grid.CurrentColumnIndex < grid.ColumnsCount - 1 Then
					grid.CurrentColumnIndex += 1
				End If
			Case 40 'Down Arrow
				grid.Focus()
				Application.DoEvents()
				If grid.CurrentRowIndex < grid.RowsCount - 1 Then
					grid.CurrentRowIndex += 1
				End If
		End Select
	End Sub

	Private Sub txtEntry_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtEntry.Leave
		SaveEdits()
	End Sub


	Private Sub fgProducts_CellLeave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles fgProducts.CellLeave
		SaveEdits()
	End Sub

	Private Sub txtEntry_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles txtEntry.KeyPress
		Dim KeyAscii As Integer = Convert.ToInt32(eventArgs.KeyChar)
		Try
			Select Case KeyAscii
				'dot and Numbers
				Case 46, 48 To 57
					'Alphanumeric
					'Case 45, 46, 47, 48 To 59, 65 To 90, 97 To 122
				Case Else
					KeyAscii = 0
			End Select
		Finally 
			If KeyAscii = 0 Then
				eventArgs.Handled = True
			End If
			eventArgs.KeyChar = Convert.ToChar(KeyAscii)
		End Try
	End Sub

	Private Sub SaveEdits()
		If Not txtEntry.Visible Or Not ValidateTextBoxDouble(txtEntry, Me) Or Not ValidateTextDouble(Convert.ToString(fgProducts(fgProducts.CurrentRowIndex, 3).Value), Me) Or Not ValidateTextDouble(Convert.ToString(fgProducts(fgProducts.CurrentRowIndex, 4).Value), Me) Then Exit Sub
		Dim previousLinePrice As Double = DoubleValue(Convert.ToString(fgProducts(fgProducts.CurrentRowIndex, 4).Value))
		fgProducts(fgProducts.CurrentRowIndex, fgProducts.CurrentColumnIndex).Value = txtEntry.Text
		Dim lineQuantity As Double = DoubleValue(txtEntry.Text)
		Dim lineUnitPrice As Double = DoubleValue(Convert.ToString(fgProducts(fgProducts.CurrentRowIndex, 3).Value))
		previousLinePrice = DoubleValue(Convert.ToString(fgProducts(fgProducts.CurrentRowIndex, 4).Value))
		Dim linePrice As Double = lineQuantity * lineUnitPrice
		fgProducts(fgProducts.CurrentRowIndex, 4).Value = CStr(linePrice)
		ReCalculateTotals(previousLinePrice, linePrice)
		txtEntry.Visible = False
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

	Private Sub lvProviders_ItemClick(ByVal Item As ListViewItem)
		RetrieveDataProvider()
	End Sub

	Private Sub RetrieveDataProvider()
		If editingData Then
			If MessageBox.Show("Do you want to cancel previous edited data?", "Data edition", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> System.Windows.Forms.DialogResult.Yes Then
				Exit Sub
			End If
		End If

		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not (lvProviders.FocusedItem Is Nothing) Then
			With lvProviders.FocusedItem
				currentIdProvider = CInt(lvProviders.FocusedItem.Text)
				currentProviderName = ListViewHelper.GetListViewSubItem(lvProviders.FocusedItem, 1).Text
				currentContactName = ListViewHelper.GetListViewSubItem(lvProviders.FocusedItem, 2).Text & " " & ListViewHelper.GetListViewSubItem(lvProviders.FocusedItem, 3).Text
			End With
			txtProviderCompany.Text = currentProviderName
			txtProviderContact.Text = currentContactName
			editingData = False
		End If
		LoadProductsById()
		cmdSave.Enabled = True
		cmdAddProducts.Enabled = True

	End Sub

	Private Sub LoadProductsById()
		Dim Table As String = "ProductsByProvider"
		Dim ColumnName As String = "ProviderId"
		Dim Id As Integer = currentIdProvider

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
	Private Sub txtProviderName_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtProviderName.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		DoSearchProvider()
	End Sub

	Private Sub txtNotes_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtNotes.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		editingData = True
	End Sub

	Private Sub txtContactName_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtContactName.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		DoSearchProvider()
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

		txtProviderName.Text = ""
		txtContactLastName.Text = ""
		txtContactName.Text = ""
		txtProviderContact.Text = ""
		txtProviderCompany.Text = ""
		cmdSave.Enabled = False
		cmdAddProducts.Enabled = False
		txtNotes.Text = ""
		'txtProviderName.SetFocus
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

	Private Sub txtContactLastName_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtContactLastName.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		editingData = True
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