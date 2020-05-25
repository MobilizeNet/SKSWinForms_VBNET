Option Strict Off
Option Explicit On
Imports System
Imports System.Windows.Forms
Imports UpgradeHelpers.DB.ADO
Imports UpgradeHelpers.Helpers
Partial Friend Class frmLogin
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


	Private Sub frmLogin_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub

	Public LoginSucceeded As Boolean

	Private Sub cmdCancel_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdCancel.Click
		LoginSucceeded = False
		Me.Close()
	End Sub

	Private Sub cmdOk_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdOK.Click
		ExecuteSql("SELECT * FROM Users WHERE username = '" & txtUserName.Text & "' and password = '" & txtPassword.Text & "'")
		If rs.EOF Then
			MessageBox.Show("Invalid 'Username' or 'Password', please try again!", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			txtUserName.Focus()
			SelectAll(txtUserName)
			Exit Sub
		End If
		UserFullname = rs("Fullname")
		UserLevel = rs("Level")
		CurrentUserAdmin = (UserLevel = "Administrator")
		Me.Cursor = ReflectionHelper.CursorDefault
		LoginSucceeded = True
		LogStatus("User : " & UserFullname & " logged at " & DateTimeHelper.ToString(DateTime.Parse(DateTimeHelper.ToString(DateTime.Now))) & "," & DateTimeHelper.ToString(DateTime.Now))
		Me.Close()
	End Sub
	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class