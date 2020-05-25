Option Strict Off
Option Explicit On
Imports System
Imports System.Windows.Forms
Imports UpgradeHelpers.DB.ADO
Imports UpgradeHelpers.Gui
Imports UpgradeHelpers.Helpers
Partial Friend Class frmProducts
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


	Private Sub frmProducts_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub
	Private NewMode As Boolean
	Private EditMode As Boolean
	Private CancellingMode As Boolean
	Public CurrentProductID As String = ""

	'SKS Demo TODO: Go the the designer and change the data binding of _txtField_4 like this:
	'_txtField_4.DataBindings.Add("Text", dcProducts, "UnitPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C2");


	Private Sub cmbCategory_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmbCategory.SelectedIndexChanged
		If cmbCategory.Items.Count = 0 Or cmbCategory.SelectedIndex = -1 Then
			Exit Sub
		End If
		txtCategory.Text = CStr(cmbCategory.GetItemData(cmbCategory.SelectedIndex))
	End Sub


	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
		CurrentProductID = dcProducts.Recordset("ProductId")
	End Sub

	Private isInitializingComponent As Boolean
	Private Sub txtCategory_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtCategory.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		If cmbCategory.Items.Count = 0 Then
			LoadCombo("Categories", cmbCategory, "CategoryName", "CategoryID")
		End If
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If String.IsNullOrEmpty(txtCategory.Text) Then
			cmbCategory.SelectedIndex = -1
			Exit Sub
		End If
		Dim Index As Integer = -1
		For i = 0 To cmbCategory.Items.Count
			If cmbCategory.GetItemData(i) = StringsHelper.ToDoubleSafe(txtCategory.Text) Then
				Index = i
				Exit For
			End If
		Next
		cmbCategory.SelectedIndex = i
	End Sub

	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
	Private Sub Form_Load()
		txtCategory.Height = 0
		txtCategory.Width = 0
		dcProducts.ConnectionString = ConnectionString
		NewMode = False
		EditMode = False
		CancellingMode = False
		If cmbCategory.Items.Count = 0 Then
			LoadCombo("Categories", cmbCategory, "CategoryName", "CategoryID")
		End If
	End Sub

	Private Sub Toolbar1_ButtonClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Toolbar1_Buttons_Button1.Click, Toolbar1_Buttons_Button2.Click, Toolbar1_Buttons_Button3.Click, Toolbar1_Buttons_Button4.Click, Toolbar1_Buttons_Button5.Click, Toolbar1_Buttons_Button6.Click
		Dim Button As ToolStripItem = CType(eventSender, ToolStripItem)
		Dim x As Object
		'SKS Demo TODO: dcProducts.SetFocus()
		Select Case Button.Text
			Case "Add"
				'Add new record
				NewMode = True
				dcProducts.Recordset.AddNew()
				dcProducts.Recordset("UnitsInStock") = 0
				dcProducts.Recordset("UnitsOnOrder") = 0
				dcProducts.Recordset("Discontinued") = 0
			Case "Edit"
				'Edit mode
				EditMode = True
				'dcProducts.Recordset.EditMode =
			Case "Save"
				'Save data
				dcProducts.Recordset.Update()
				dcProducts.Recordset.Requery() ' SQLite ODBC driver needs to requery the info
				EditMode = False
				NewMode = False
			Case "Delete"
				'Delete record
				If MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
					dcProducts.Recordset.Delete()
					dcProducts.Recordset.Requery()
				End If
			Case "Search"
				'Search for records
				SearchShow("Products", "ProductName", "product")
			Case "Cancel"
				CancellingMode = True
				'Cancel edited changes
				EditMode = False
				NewMode = False
				dcProducts.Recordset.CancelUpdate()
				dcProducts.Recordset.Requery()
				CancellingMode = False
				Me.Close()
		End Select
	End Sub

	'Private Sub txtField_KeyPress(Index As Integer, KeyAscii As Integer)
	'If Index = 0 Then
	'    KeyAscii = Asc(UCase(Chr(KeyAscii)))
	'ElseIf Index = 4 Or Index = 5 Then
	'    Select Case KeyAscii
	'        Case vbKey0 To vbKey9
	'        Case vbKeyBack, vbKeyClear, vbKeyDelete
	'        Case vbKeyLeft, vbKeyRight, vbKeyUp, vbKeyDown, vbKeyTab
	'        Case Else
	'            KeyAscii = 0
	'            Beep
	'    End Select
	'End If
	'End Sub
End Class