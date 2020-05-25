Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Specialized
Imports System.Windows.Forms
Imports UpgradeHelpers.DB.ADO
Imports UpgradeHelpers.Gui
Partial Friend Class frmAddProductTo
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


	Private Sub frmAddProductTo_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub

	Public Id As Integer
	Public ObjectReferred As String = ""
	Public Table As String = ""
	Public ColumnName As String = ""

	Public SavedChanges As Boolean
	Private productsStored As OrderedDictionary
	Private productsToDelete As OrderedDictionary
	Private productsToAdd As OrderedDictionary
	Private editingData As Boolean
	Private currentIdProduct As String = ""

	Private codeGeneratedChange As Boolean

	Private isInitializingComponent As Boolean
	Private Sub chkAll_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles chkAll.CheckStateChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		Dim check As Boolean = chkAll.CheckState = CheckState.Checked
		For i = 1 To lvProductsBy.Items.Count
			lvProductsBy.Items.Item(i - 1).Checked = check
		Next i
	End Sub

	Private Sub cmdClose_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdClose.Click
		Me.Close()
	End Sub

	Private Sub cmdProducts_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdProducts.Click
		frmProducts.DefInstance.ShowDialog()
		txtCode.Text = frmProducts.DefInstance.CurrentProductID
		txtName.Text = ""
		DoSearchProduct()
	End Sub

	Private Sub cmdRemove_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdRemove.Click
		Dim productIdToDelete As String = ""
		For i = lvProductsBy.Items.Count To 1 Step -1
			If lvProductsBy.Items.Item(i - 1).Checked Then
				productIdToDelete = lvProductsBy.Items.Item(i - 1).Text

				If Exists(productsStored, productIdToDelete) Then
					If Exists(productsToAdd, productIdToDelete) Then
						productsToDelete.Remove(productIdToDelete)
					Else
						AddToCollection(productsToDelete, productIdToDelete)
					End If
				Else
					If Exists(productsToAdd, currentIdProduct) Then
						productsToAdd.Remove(currentIdProduct)
					End If
				End If

				lvProductsBy.Items.RemoveAt(i - 1)
				editingData = True
			End If
		Next i
	End Sub

	Private Sub cmdSave_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdSave.Click

		If productsToAdd.Count = 0 And productsToDelete.Count = 0 Then
			editingData = True
			MessageBox.Show("No data to be saved", "No data modified", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Me.Close()
			Exit Sub
		End If
		SavedChanges = True
		Dim productCode As String = ""
		For	Each productCodeIterator As String In productsToAdd.Values
			productCode = productCodeIterator
			ExecuteSql("Insert into " & Table & "(" & ColumnName & ", ProductID) Values (" & CStr(Id) & ", '" & productCode & "')")
			productCode = CType(Nothing, String)
		Next productCodeIterator
		For	Each productCodeIterator2 As String In productsToDelete.Values
			productCode = productCodeIterator2
			ExecuteSql("Delete from " & Table & " Where " & ColumnName & " = " & CStr(Id) & " And ProductID = '" & productCode & "'")
			productCode = CType(Nothing, String)
		Next productCodeIterator2

		editingData = False
		MessageBox.Show("Data was succesfully saved", "New data", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Me.Close()
		Exit Sub

		MessageBox.Show("An error has occurred adding the data. Error: (" & Information.Err().Number & ") " & Information.Err().Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
	End Sub

	Public Sub LoadData()
		editingData = False
		editingData = False
		codeGeneratedChange = False
		Me.Text = "Add product(s) to " & ObjectReferred
		lblProductsRelated.Text = "Products related to " & ObjectReferred
		productsStored = New OrderedDictionary()
		productsToDelete = New OrderedDictionary()
		productsToAdd = New OrderedDictionary()
		LoadProductsById()
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

	Private Sub lvProducts_ItemClick(ByVal Item As ListViewItem)
		AddProductToSet()
	End Sub

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
			AddProductToSet()
		End If
	End Sub

	Private Sub txtName_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtName.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		DoSearchProduct()
	End Sub

	Private Sub LoadProductsById()
		Dim productCode As String = ""
		ExecuteSql("Select p.ProductID, p.ProductName, p.UnitPrice, p.QuantityPerUnit, p.Unit from Products as p, " & Table & " as pb Where pb." & ColumnName & " = " & CStr(Id) & " And pb.ProductId = p.ProductId")

		LogStatus("There are " & rs.RecordCount & " records with the selected criteria", Me)
		Dim x As ListViewItem
		If rs.RecordCount > 0 Then
			While Not rs.EOF
				'productCode = CStr(rs.Fields(0).value)
				productCode = rs(0)
				AddToCollection(productsStored, productCode)
				x = lvProductsBy.Items.Add(productCode)
				For i = 1 To 2
					'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
					If Not (rs.GetField(i) Is Nothing) Then
						ListViewHelper.GetListViewSubItem(x, i).Text = rs(i)
					End If
				Next i
				ListViewHelper.GetListViewSubItem(x, 3).Text = rs(3) & rs(4)
				rs.MoveNext()
			End While
		End If
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
		LogStatus("There are " & rs.RecordCount & " records with the selected criteria", Me)
		Dim x As ListViewItem
		If rs.RecordCount > 0 Then
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

	Private Sub AddProductToSet()

		Dim y As ListViewItem
		Dim i As Integer
		Dim found As Boolean
		Dim x As ListViewItem
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not (lvProducts.FocusedItem Is Nothing) Then
			y = lvProducts.FocusedItem
			currentIdProduct = lvProducts.FocusedItem.Text
			found = False
			For i = 1 To lvProductsBy.Items.Count
				If lvProductsBy.Items.Item(i - 1).Text = currentIdProduct Then
					lvProductsBy.Items(lvProductsBy.Items.Item(i - 1).Index).Selected = True
					found = True
					Exit For
				ElseIf lvProductsBy.Items.Item(i - 1).Text > currentIdProduct Then 
					Exit For
				End If
			Next i
			If Not found Then
				editingData = True
				If Not Exists(productsStored, currentIdProduct) Then
					If Exists(productsToDelete, currentIdProduct) Then
						productsToDelete.Remove(currentIdProduct)
					Else
						AddToCollection(productsToAdd, currentIdProduct)
					End If
				Else
					If Exists(productsToDelete, currentIdProduct) Then
						productsToDelete.Remove(currentIdProduct)
					End If
				End If
				x = lvProductsBy.Items.Insert(i - 1, currentIdProduct)
				ListViewHelper.GetListViewSubItem(x, 1).Text = ListViewHelper.GetListViewSubItem(y, 1).Text
				ListViewHelper.GetListViewSubItem(x, 2).Text = ListViewHelper.GetListViewSubItem(y, 2).Text
				ListViewHelper.GetListViewSubItem(x, 3).Text = ListViewHelper.GetListViewSubItem(y, 5).Text & ListViewHelper.GetListViewSubItem(y, 6).Text
			End If
		End If
	End Sub

	'UPGRADE_NOTE: (7001) The following declaration (ClearFields) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
	'Private Sub ClearFields()
		'codeGeneratedChange = True
		'txtCode.Text = ""
		'txtName.Text = ""
		'lvProducts.Items.Clear()
		'lvProductsBy.Items.Clear()
		'txtCode.Focus()
		'editingData = False
		'codeGeneratedChange = False
	'End Sub
	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class