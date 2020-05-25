Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic
Imports System
Imports System.Media
Imports System.Windows.Forms
Imports UpgradeHelpers.DB.ADO
Imports UpgradeHelpers.Gui
Imports UpgradeHelpers.Helpers
Partial Friend Class frmAdjustStockManual
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


	Private Sub frmAdjustStockManual_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub

	Private editingData As Boolean
	Private currentIdProduct As String = ""
	Private currentIdStock As Integer
	Private currentQuantityPerUnit As String = ""
	Private currentUnit As String = ""
	Private currentProductName As String = ""
	Private currentStockPrice As Double
	Private currentStock As Double
	Private changedStockPrice As Double
	Private changedStock As Double
	Private codeGeneratedChange As Boolean
	Private quantity As Double
	Private stockPrice, unitPrice As Double

	Private Sub cmdClose_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdClose.Click
		Me.Close()
	End Sub

	Private Sub cmdSave_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdSave.Click
		Dim newStockId, newManualLogId, newStockLogId As Integer
		editingData = False
		Try

			Dim deltaStockPrice, deltaStock As Double
			changedStockPrice = CDbl(txtValues(0).Text)
			changedStock = CDbl(txtValues(1).Text)

			deltaStockPrice = changedStockPrice - currentStockPrice
			deltaStock = changedStock - currentStock

			If deltaStockPrice = 0 And deltaStock = 0 Then
				LogStatus("There is no modification of the Stock, the data won't be saved", Me)
				Exit Sub
			End If
			' UPDATE
			ExecuteSql("Update Stocks Set StockPrice = " & changedStockPrice &  _
			           ", Stock = " & CStr(changedStock) & " Where StockId = " & CStr(currentIdStock))

			' NEW
			ExecuteSql("Select * from ManualStocks")
			rs.AddNew()
			rs("StockID") = currentIdStock
			rs("Quantity") = deltaStock
			rs("Price") = deltaStockPrice
			rs("User") = UserId
			rs("Date") = DateTimeHelper.ToString(DateTime.Today)
			rs("Action") = "MOD"
			rs.Update()
			ExecuteSql("SELECT last_insert_rowid()")
			newManualLogId = rs(0)

			'NEW
			ExecuteSql("Select * from StockLog")
			rs.AddNew()
			rs("User") = UserId
			rs("Date") = DateTimeHelper.ToString(DateTime.Today)
			rs("Quantity") = deltaStock
			rs("StockPrice") = deltaStockPrice
			rs("ProductID") = currentIdProduct
			rs("StockID") = currentIdStock
			rs("DocType") = "MANUAL"
			rs("DocID") = newManualLogId
			rs.Update()
			ExecuteSql("SELECT last_insert_rowid()")
			newStockLogId = rs(0)

			ExecuteSql("Update Products Set UnitsInStock = UnitsInStock + " & deltaStock &  _
			           " Where ProductId = '& currentIdProduct &'")

			If MessageBox.Show("Data modified successfully" & Environment.NewLine & "Would you like to modify another stock manually?", "Modify data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
				ClearFields()
			Else
				Me.Close()
			End If

		Catch excep As System.Exception
			MessageBox.Show("An error has occurred adding the data. Error: (" & Information.Err().Number & ") " & excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try

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

	Private Sub cmdProducts_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdProducts.Click
		frmProducts.DefInstance.ShowDialog()
		txtCode.Text = frmProducts.DefInstance.CurrentProductID
		txtName.Text = ""
		DoSearchProduct()
	End Sub

	Private Sub lvProducts_ItemClick(ByVal Item As ListViewItem)
		DoSearchStocks()
	End Sub

	Private Sub lvStocks_ItemClick(ByVal Item As ListViewItem)
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
			LogStatus("There are no records with the selected criteria")
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
			End If
		End If
	End Sub


	Private Sub DoSearchStocks()
		If lvProducts.FocusedItem Is Nothing Then
			Exit Sub
		End If
		If editingData Then
			If MessageBox.Show("Do you want to cancel previous edited data?", "Data edition", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> System.Windows.Forms.DialogResult.Yes Then
				Exit Sub
			End If
		End If
		Dim productId As String = lvProducts.FocusedItem.Text
		Dim productName_Renamed As String = ListViewHelper.GetListViewSubItem(lvProducts.FocusedItem, 1).Text
		currentIdProduct = lvProducts.FocusedItem.Text
		With lvProducts.FocusedItem
			'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
			If Not String.IsNullOrEmpty(ListViewHelper.GetListViewSubItem(lvProducts.FocusedItem, 5).Text) Then currentQuantityPerUnit = ListViewHelper.GetListViewSubItem(lvProducts.FocusedItem, 5).Text
			'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
			If Not String.IsNullOrEmpty(ListViewHelper.GetListViewSubItem(lvProducts.FocusedItem, 6).Text) Then currentUnit = ListViewHelper.GetListViewSubItem(lvProducts.FocusedItem, 6).Text
			currentProductName = ListViewHelper.GetListViewSubItem(lvProducts.FocusedItem, 1).Text
		End With
		txtProductName.Text = productName_Renamed
		txtUnit.Text = currentUnit
		txtQuantityPerUnit.Text = currentQuantityPerUnit

		ExecuteSql("Select StockID, Stock, InitialStock, UnitPrice, " &  _
		           "StockPrice, DateStarted, DateModified, User From Stocks " &  _
		           " Where ProductId = '" & productId & "'")
		lvStocks.Items.Clear()
		Dim x As ListViewItem
		If rs.RecordCount = 0 Then
			LogStatus("There are no stock records of the product " & productName_Renamed)
			RetrieveDataProduct()
		Else
			While Not rs.EOF
				x = lvStocks.Items.Add(rs(0))
				For i = 1 To (rs.FieldsMetadata.Count - 1)
					ListViewHelper.GetListViewSubItem(x, i).Text = rs(i)
				Next i
				rs.MoveNext()
			End While
			If lvStocks.Items.Count = 1 Then
				lvStocks.Items(lvStocks.Items.Item(0).Index).Selected = True
			End If
		End If
	End Sub

	Private Sub RetrieveDataProduct()
		If editingData Then
			If MessageBox.Show("Do you want to cancel previous edited data?", "Data edition", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> System.Windows.Forms.DialogResult.Yes Then
				Exit Sub
			End If
		End If

		Dim setEmpty As Boolean = True
		If Not (lvStocks.FocusedItem Is Nothing) Then
			'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
			If Not (lvStocks.FocusedItem Is Nothing) Then
				currentIdStock = CInt(lvStocks.FocusedItem.Text)
				With lvStocks.FocusedItem
					currentStock = CDbl(ListViewHelper.GetListViewSubItem(lvStocks.FocusedItem, 1).Text)
					currentStockPrice = CDbl(ListViewHelper.GetListViewSubItem(lvStocks.FocusedItem, 4).Text)
				End With
				codeGeneratedChange = True
				txtOriginalQuantity.Text = CStr(currentStock)
				txtOriginalPrice.Text = CStr(currentStockPrice)
				txtStockID.Text = CStr(currentIdStock)
				txtValues(0).Text = CStr(currentStockPrice)
				txtValues(1).Text = CStr(currentStock)
				lblNewQuantity.Text = StringsHelper.Format(currentStock * CDbl(currentQuantityPerUnit), "##,###.00") & currentUnit
				lblCurrentQuantity.Text = StringsHelper.Format(currentStock * CDbl(currentQuantityPerUnit), "##,###.00") & currentUnit
				codeGeneratedChange = False
				setEmpty = False
				txtValues(0).ReadOnly = False
				txtValues(1).ReadOnly = False
				txtValues(0).Focus()
			End If
		End If
		If setEmpty Then
			codeGeneratedChange = True
			txtOriginalQuantity.Text = ""
			txtOriginalPrice.Text = ""
			txtStockID.Text = ""
			txtValues(0).Text = ""
			txtValues(1).Text = ""
			lblNewQuantity.Text = ""
			lblCurrentQuantity.Text = ""
			codeGeneratedChange = False
		End If
		editingData = False

	End Sub

	Private Sub txtValues_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtValues_0.Enter, _txtValues_1.Enter
		Dim Index As Integer = Array.IndexOf(Me.txtValues, eventSender)
		SelectAll(txtValues(Index))
	End Sub

	Private Sub txtValues_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtValues_0.KeyPress, _txtValues_1.KeyPress
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

	Private Sub txtValues_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtValues_0.TextChanged, _txtValues_1.TextChanged
		Dim Index As Integer = Array.IndexOf(Me.txtValues, eventSender)
		If isInitializingComponent Then
			Exit Sub
		End If
		If Not codeGeneratedChange Then
			editingData = True
			codeGeneratedChange = True
			'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
			If Not String.IsNullOrEmpty(txtValues(0).Text) Then changedStockPrice = CDbl(txtValues(0).Text)
			'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
			If Not String.IsNullOrEmpty(txtValues(1).Text) Then changedStock = CDbl(txtValues(1).Text)
			Select Case Index
				Case 1
					If changedStock > currentStock Then
						changedStock = currentStock
						LogStatus("Cannot pass the original stock, to add more, add a new stock manually", Me)
						txtValues(1).Text = CStr(changedStock)
					End If
			End Select
			lblNewQuantity.Text = StringsHelper.Format(changedStock * CDbl(currentQuantityPerUnit), "##,###.00") & currentUnit
			lblCurrentQuantity.Text = StringsHelper.Format(currentStock * CDbl(currentQuantityPerUnit), "##,###.00") & currentUnit
			codeGeneratedChange = False
		End If
	End Sub

	Private Sub ClearFields()
		codeGeneratedChange = True
		txtValues(0).Text = ""
		txtValues(1).Text = ""
		txtValues(0).ReadOnly = True
		txtValues(1).ReadOnly = True
		txtCode.Text = ""
		txtName.Text = ""
		txtUnit.Text = ""
		txtStockID.Text = ""
		txtOriginalPrice.Text = ""
		txtOriginalQuantity.Text = ""
		txtProductName.Text = ""
		txtQuantityPerUnit.Text = ""
		lvProducts.Items.Clear()
		lvStocks.Items.Clear()
		lblCurrentQuantity.Text = ""
		lblNewQuantity.Text = ""
		txtCode.Focus()
		editingData = False
		codeGeneratedChange = False
		ClearLogStatus(Me)
	End Sub
	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class