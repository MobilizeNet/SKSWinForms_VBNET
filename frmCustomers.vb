Option Strict Off
Option Explicit On
Imports System
Imports System.Windows.Forms
Imports UpgradeHelpers.DB.ADO
Partial Friend Class frmCustomers
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


	Private Sub frmCustomers_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub

	Private NewMode As Boolean
	Private EditMode As Boolean
	Private CancellingMode As Boolean
	Public CurrentCustomerID As String = ""



	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
		CurrentCustomerID = dcCustomers.Recordset("CustomerId")
	End Sub


	'Private Sub dcCustomers_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
	'NewMode = False
	'EditMode = False
	'CancellingMode = False
	'End Sub

	'Private Sub dcCustomers_WillMove(ByVal adReason As ADODB.EventReasonEnum, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
	'CancellingMode = True
	'End Sub

	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
	Private Sub Form_Load()
		InitForm()
	End Sub

	Public Sub InitForm()
		dcCustomers.ConnectionString = ConnectionString
		NewMode = False
		EditMode = False
		CancellingMode = False
	End Sub

	Private Sub Toolbar1_ButtonClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Toolbar1_Buttons_Button1.Click, Toolbar1_Buttons_Button2.Click, Toolbar1_Buttons_Button3.Click, Toolbar1_Buttons_Button4.Click, Toolbar1_Buttons_Button5.Click, Toolbar1_Buttons_Button6.Click
		Dim Button As ToolStripItem = CType(eventSender, ToolStripItem)
		Dim x As Object
		Dim newCustomerId As Integer
		Select Case Button.Text
			Case "Add"
				'Add new record
				NewMode = True
				dcCustomers.Recordset.AddNew()
			Case "Edit"
				'Edit mode
				EditMode = True
			Case "Save"
				'Save data
				dcCustomers.Recordset.Update()
				dcCustomers.Recordset.Requery() ' SQLite ODBC driver needs to requery the info
				EditMode = False
				NewMode = False
			Case "Delete"
				'Delete record
				If MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
					dcCustomers.Recordset.Delete()
					dcCustomers.Recordset.Requery()
				End If
			Case "Search"
				'Search for records
				SearchShow("Customers", "CompanyName", "customer")
			Case "Cancel"
				CancellingMode = True
				'Cancel edited changes
				EditMode = False
				NewMode = False
				dcCustomers.Recordset.CancelUpdate()
				dcCustomers.Recordset.Requery()
				CancellingMode = False
				Me.Close()
		End Select
	End Sub

	Private isInitializingComponent As Boolean
	Private Sub txtField_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtField_4.TextChanged, _txtField_0.TextChanged, _txtField_6.TextChanged, _txtField_7.TextChanged, _txtField_2.TextChanged, _txtField_1.TextChanged, _txtField_3.TextChanged, _txtField_5.TextChanged, _txtField_11.TextChanged, _txtField_13.TextChanged, _txtField_12.TextChanged, _txtField_8.TextChanged, _txtField_10.TextChanged, _txtField_14.TextChanged, _txtField_9.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		If Not CancellingMode Then
			EditMode = True
		End If
	End Sub

	'Used already in frmSearch
	Public Sub SearchCriteriaProducts(ByVal field As String, ByVal value As String)
		ExecuteSql("Select * from Customers where " & field & " LIKE '" & value & "%'")
		If rs.RecordCount = 0 Then
			MessageBox.Show("There are no records with the selected criteria", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			LogStatus("There are " & rs.RecordCount & " that meet with the selected criteria")
			dcCustomers.Recordset = rs
		End If
	End Sub
End Class