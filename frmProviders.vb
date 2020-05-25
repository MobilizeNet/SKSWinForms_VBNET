Option Strict Off
Option Explicit On
Imports System
Imports System.Windows.Forms
Imports UpgradeHelpers.DB.ADO
Partial Friend Class frmProviders
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


	Private Sub frmProviders_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub
	Private NewMode As Boolean
	Private EditMode As Boolean
	Private CancellingMode As Boolean
	Public CurrentProviderID As Integer

	'Private Sub adcProviders_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
	'NewMode = False
	'EditMode = False
	'CancellingMode = False
	'End Sub

	'Private Sub dcProviders_WillMove(ByVal adReason As ADODB.EventReasonEnum, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
	'CancellingMode = True
	'End Sub


	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
	Private Sub Form_Load()
		dcProviders.ConnectionString = ConnectionString

		NewMode = False
		EditMode = False
		CancellingMode = False
	End Sub

	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
		CurrentProviderID = dcProviders.Recordset("ProviderId")
	End Sub

	Private Sub Toolbar1_ButtonClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Toolbar1_Buttons_Button1.Click, Toolbar1_Buttons_Button2.Click, Toolbar1_Buttons_Button3.Click, Toolbar1_Buttons_Button4.Click, Toolbar1_Buttons_Button5.Click, Toolbar1_Buttons_Button6.Click
		Dim Button As ToolStripItem = CType(eventSender, ToolStripItem)
		Dim x As Object
		'SKS Demo TODO: dcProviders.SetFocus()
		Select Case Button.Text
			Case "Add"
				'Add new record
				NewMode = True
				dcProviders.Recordset.AddNew()
			Case "Edit"
				'Edit mode
				EditMode = True
			Case "Save"
				Save()
			Case "Delete"
				'Delete record
				If MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
					dcProviders.Recordset.Delete()
					dcProviders.Recordset.Requery()
				End If
			Case "Search"
				'Search for records
				SearchShow("Providers", "ProviderName", "Provider")
			Case "Cancel"
				CancellingMode = True
				'Cancel edited changes
				EditMode = False
				NewMode = False
				dcProviders.Recordset.CancelUpdate()
				dcProviders.Recordset.Requery()
				CancellingMode = False
				Me.Close()
		End Select
	End Sub


	Private Sub Save()
		'Save data
		If TextBoxEmpty(txtField(0)) Then Exit Sub
		If TextBoxEmpty(txtField(1)) Then Exit Sub
		If TextBoxEmpty(txtField(2)) Then Exit Sub
		If TextBoxEmpty(txtField(4)) Then Exit Sub
		If TextBoxEmpty(txtField(5)) Then Exit Sub
		If TextBoxEmpty(txtField(6)) Then Exit Sub
		If TextBoxEmpty(txtField(7)) Then Exit Sub
		If TextBoxEmpty(txtField(7)) Then Exit Sub
		If TextBoxEmpty(txtField(10)) Then Exit Sub
		If TextBoxEmpty(txtField(11)) Then Exit Sub
		If TextBoxEmpty(txtField(12)) Then Exit Sub
		If TextBoxEmpty(txtField(14)) Then Exit Sub
		dcProviders.Recordset.Update()
		dcProviders.Recordset.Requery()
		EditMode = False
		NewMode = False
	End Sub

	Private isInitializingComponent As Boolean
	Private Sub txtField_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtField_1.TextChanged, _txtField_4.TextChanged, _txtField_0.TextChanged, _txtField_6.TextChanged, _txtField_7.TextChanged, _txtField_2.TextChanged, _txtField_5.TextChanged, _txtField_11.TextChanged, _txtField_13.TextChanged, _txtField_12.TextChanged, _txtField_8.TextChanged, _txtField_10.TextChanged, _txtField_14.TextChanged, _txtField_9.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		If Not CancellingMode Then
			EditMode = True
		End If
	End Sub

	'Used in search form
	'Public Sub SearchCriteria(field As String, value As String)
	'ExecuteSql "Select * from Providers where " & field & " LIKE '" & value & "%'"
	'If rs.RecordCount = 0 Then
	'    MsgBox "There are no records with the selected criteria", vbInformation, "Search"
	'Else
	'    LogStatus "There are " & rs.RecordCount & " that meet with the selected criteria"
	'    Set dcProviders.Recordset = rs
	'End If
	'End Sub
End Class