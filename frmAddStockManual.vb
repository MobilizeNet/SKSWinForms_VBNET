Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic
Imports System
Imports System.Media
Imports System.Windows.Forms
Imports UpgradeHelpers.DB.ADO
Imports UpgradeHelpers.Gui
Imports UpgradeHelpers.Helpers
Partial Friend Class frmAddStockManual
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


	Private Sub frmAddStockManual_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub

	Private editingData As Boolean
	Private currentIdProduct As String = ""
	Private currentQuantityPerUnit As String = ""
	Private currentUnit As String = ""
	Private currentProductName As String = ""
	Private currentPriceReference As Double
	Private codeGeneratedChange As Boolean
	Private quantity As Double
	Private stockPrice, unitPrice As Double

	Private Sub cmdClose_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdClose.Click
		Me.Close()
	End Sub

	Private Sub cmdProducts_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdProducts.Click
		frmProducts.DefInstance.ShowDialog()
		txtCode.Text = frmProducts.DefInstance.CurrentProductID
		txtName.Text = ""
		DoSearchProduct()
	End Sub

	Private Sub cmdSave_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdSave.Click
		Dim newStockId, newManualLogId, newStockLogId As Integer
		editingData = False
		Try
			ExecuteSql("Select * from Stocks")
			rs.AddNew()
			rs("ProductID") = currentIdProduct
			rs("Stock") = txtValues(0).Text
			rs("InitialStock") = txtValues(0).Text
			rs("DateStarted") = DateTimeHelper.ToString(DateTime.Today)
			rs("DateModified") = DateTimeHelper.ToString(DateTime.Today)
			rs("User") = UserId
			rs("UnitPrice") = txtValues(2).Text
			rs("StockPrice") = txtValues(1).Text
			rs.Update()
			ExecuteSql("SELECT last_insert_rowid()")
			newStockId = rs(0)

			ExecuteSql("Select * from ManualStocks")
			rs.AddNew()
			rs("StockID") = newStockId
			rs("Quantity") = txtValues(0).Text
			rs("Price") = txtValues(1).Text
			rs("User") = UserId
			rs("Date") = DateTimeHelper.ToString(DateTime.Today)
			rs("Action") = "ADD"
			rs.Update()
			ExecuteSql("SELECT last_insert_rowid()")
			newManualLogId = rs(0)

			ExecuteSql("Select * from StockLog")
			rs.AddNew()
			rs("User") = UserId
			rs("Date") = DateTimeHelper.ToString(DateTime.Today)
			rs("Quantity") = txtValues(0).Text
			rs("StockPrice") = txtValues(1).Text
			rs("ProductID") = currentIdProduct
			rs("StockID") = newStockId
			rs("DocType") = "MANUAL"
			rs("DocID") = newManualLogId
			rs.Update()
			ExecuteSql("SELECT last_insert_rowid()")
			newStockLogId = rs(0)

			ExecuteSql("Update Products Set UnitsInStock = UnitsInStock + " & txtValues(0).Text &  _
			           " Where ProductId = '& currentIdProduct &'")

			If MessageBox.Show("Data added successfully" & Environment.NewLine & "Would you like to add a new stock manually?", "New data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
				ClearFields()
			Else
				Me.Close()
			End If

		Catch excep As System.Exception
			MessageBox.Show("An error has occurred adding the data. Error: (" & Information.Err().Number & ") " & excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try

	End Sub

	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
	Private Sub Form_Load()
		editingData = False
		codeGeneratedChange = False
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

	Private Sub lvProducts_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles lvProducts.Click
		RetrieveDataProduct()
	End Sub

	Private Sub lvProducts_ItemClick(ByVal Item As ListViewItem)
		RetrieveDataProduct()
	End Sub

	Private isInitializingComponent As Boolean
	Private Sub txtCode_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtCode.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		DoSearchProduct()
	End Sub

	'Private Sub txtCode_KeyPress(KeyAscii As Integer)
	'KeyAscii = UpCase(KeyAscii)
	'End Sub

	Private Sub txtCode_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtCode.Leave
		If lvProducts.Items.Count = 1 Then
			RetrieveDataProduct()
		End If
	End Sub

	Private Sub txtName_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtName.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		DoSearchProduct()
	End Sub


	Private Sub DoSearchProduct()
		Dim filter As String = ""
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not String.IsNullOrEmpty(txtCode.Text) Then
			filter = "ProductId LIKE '%" & txtCode.Text & "%'"
		End If
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not String.IsNullOrEmpty(txtName.Text) Then
			'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
			If Not String.IsNullOrEmpty(filter) Then
				filter = filter & " AND "
			End If
			filter = filter & "ProductName LIKE '%" & txtName.Text & "%'"
		End If
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not String.IsNullOrEmpty(filter) Then
			filter = "Where " & filter
		End If
		ExecuteSql("Select ProductID, ProductName, UnitPrice, UnitsInStock, UnitsOnOrder, QuantityPerUnit, Unit from Products " & filter)
		lvProducts.Items.Clear()
		Dim x As ListViewItem
		If rs.RecordCount = 0 Then
			LogStatus("There are no records with the selected criteria", Me)
		Else
			While Not rs.EOF
				x = lvProducts.Items.Add(rs(0))
				For i = 1 To (rs.FieldsMetadata.Count - 1)
					'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
					If Not (rs.GetField(i) Is Nothing) Then
						ListViewHelper.GetListViewSubItem(x, i).Text = rs(i)
					End If
				Next i
				rs.MoveNext()
			End While
			If lvProducts.Items.Count = 1 Then
				lvProducts.Items(lvProducts.Items.Item(0).Index).Selected = True
				'RetrieveDataProduct
			End If
		End If
	End Sub

	Private Sub RetrieveDataProduct()
		If editingData Then
			If MessageBox.Show("Do you want to cancel previous edited data?", "Data edition", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> System.Windows.Forms.DialogResult.Yes Then
				Exit Sub
			End If
		End If

		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not (lvProducts.FocusedItem Is Nothing) Then
			With lvProducts.FocusedItem
				currentIdProduct = lvProducts.FocusedItem.Text
				'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
				If Not String.IsNullOrEmpty(ListViewHelper.GetListViewSubItem(lvProducts.FocusedItem, 5).Text) Then currentQuantityPerUnit = ListViewHelper.GetListViewSubItem(lvProducts.FocusedItem, 5).Text
				'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
				If Not String.IsNullOrEmpty(ListViewHelper.GetListViewSubItem(lvProducts.FocusedItem, 6).Text) Then currentUnit = ListViewHelper.GetListViewSubItem(lvProducts.FocusedItem, 6).Text
				currentProductName = ListViewHelper.GetListViewSubItem(lvProducts.FocusedItem, 1).Text
				currentPriceReference = CDbl(ListViewHelper.GetListViewSubItem(lvProducts.FocusedItem, 2).Text)
			End With
			txtProductName.Text = currentProductName
			txtQuantityPerUnit.Text = currentQuantityPerUnit
			txtUnit.Text = currentUnit
			txtValues(0).ReadOnly = False
			txtValues(1).ReadOnly = False
			txtValues(2).ReadOnly = False
			txtValues(0).Text = CStr(1)
			txtValues(1).Text = CStr(currentPriceReference)
			txtValues(2).Text = CStr(currentPriceReference)
			txtValues(0).Focus()
			SelectAll(txtValues(0))
			editingData = False
		End If
	End Sub


	Private Sub txtName_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtName.Leave
		If lvProducts.Items.Count = 1 Then
			RetrieveDataProduct()
		End If
	End Sub

	Private Sub txtValues_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtValues_2.TextChanged, _txtValues_1.TextChanged, _txtValues_0.TextChanged
		Dim Index As Integer = Array.IndexOf(Me.txtValues, eventSender)
		If isInitializingComponent Then
			Exit Sub
		End If
		If Not codeGeneratedChange Then
			editingData = True
			codeGeneratedChange = True
			'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
			If Not String.IsNullOrEmpty(txtValues(0).Text) Then quantity = CDbl(txtValues(0).Text)
			'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
			If Not String.IsNullOrEmpty(txtValues(1).Text) Then stockPrice = CDbl(txtValues(1).Text)
			'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
			If Not String.IsNullOrEmpty(txtValues(2).Text) Then unitPrice = CDbl(txtValues(2).Text)
			Select Case Index
				Case 0, 2
					txtValues(1).Text = CStr(unitPrice * quantity)
				Case 1
					txtValues(2).Text = CStr(stockPrice / quantity)
			End Select
			lblNewQuantity.Text = StringsHelper.Format(quantity * CDbl(currentQuantityPerUnit), "##,###.00") & currentUnit
			codeGeneratedChange = False
		End If
	End Sub

	Private Sub txtValues_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtValues_2.Enter, _txtValues_1.Enter, _txtValues_0.Enter
		Dim Index As Integer = Array.IndexOf(Me.txtValues, eventSender)
		SelectAll(txtValues(Index))
	End Sub

	Private Sub txtValues_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtValues_2.KeyPress, _txtValues_1.KeyPress, _txtValues_0.KeyPress
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

	Private Sub ClearFields()
		codeGeneratedChange = True
		txtValues(0).ReadOnly = True
		txtValues(1).ReadOnly = True
		txtValues(2).ReadOnly = True
		txtValues(0).Text = ""
		txtValues(1).Text = ""
		txtValues(2).Text = ""
		txtCode.Text = ""
		txtName.Text = ""
		txtUnit.Text = ""
		txtProductName.Text = ""
		txtQuantityPerUnit.Text = ""
		lvProducts.Items.Clear()
		txtCode.Focus()
		editingData = False
		codeGeneratedChange = False
		lblNewQuantity.Text = ""
		ClearLogStatus(Me)
	End Sub
	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class