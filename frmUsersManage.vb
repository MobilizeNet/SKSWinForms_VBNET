Option Strict Off
Option Explicit On
Imports System
Imports System.Windows.Forms
Imports UpgradeHelpers.DB.ADO
Imports UpgradeHelpers.Gui
Partial Friend Class frmUsersManage
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


	Private Sub frmUsersManage_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub
	Dim CurrentEditedUser As String = ""

	Private Sub cmdClear_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdClear.Click
		txtUsername.Text = ""
		txtUsername.Focus()
		ClearFields()
	End Sub

	Private Sub cmdDelete_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdDelete.Click
		If NoRecords(lstAccounts, "Please add/select a user") Then Exit Sub
		If MessageBox.Show("Are you sure you want to delete the user '" & lstAccounts.FocusedItem.Text & "'?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = System.Windows.Forms.DialogResult.Yes Then
			ExecuteSql("Select * from Users")
			If rs.RecordCount = 1 Then
				MessageBox.Show("You cannot delete the last user", "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Exit Sub
			End If
			ExecuteSql("Delete From Users Where Username = '" & lstAccounts.FocusedItem.Text & "'")
			LoadUsers()
		End If
	End Sub

	Private Sub cmdEdit_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdEdit.Click
		If NoRecords(lstAccounts, "Please add/select a user") Then Exit Sub
		ExecuteSql("Select * from Users where Username = '" & lstAccounts.FocusedItem.Text & "'")
		txtUsername.Text = rs("UserName")
		If rs.EOF Then
			MessageBox.Show("This user does not exist", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
			txtUsername.Focus()
		Else
			txtUsername.Text = rs("UserName")
			CurrentEditedUser = txtUsername.Text
			txtPassword.Text = rs("Password")
			txtFullname.Text = rs("Fullname")
			cboLevel.Text = rs("Level")
			cmdSave.Text = "&Update"
		End If
	End Sub

	Private Sub cmdSave_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdSave.Click
		Dim SecId As String = ""
		If TextBoxEmpty(txtUsername) Then Exit Sub
		If TextBoxEmpty(txtPassword) Then Exit Sub
		If TextBoxEmpty(txtFullname) Then Exit Sub
		If ComboEmpty(cboLevel) Then Exit Sub

		ExecuteSql("Select * from Users where Username = '" & txtUsername.Text & "'")
		If cmdSave.Text <> "&Update" Then
			If Not rs.EOF Then
				MessageBox.Show("Add failed: Username already exists", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
				Exit Sub
			End If

			If cboLevel.Text <> "Administrator" Then
				ExecuteSql2("Select * from Users where level = 'Administrator'")
				If rs2.EOF Then
					MessageBox.Show("Update failed: No any Administrator found on accounts.  You are not allowed to change the level of this account", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
					Exit Sub
				End If
			End If
			If Not CurrentUserAdmin And cboLevel.Text = "Administrator" Then
				MessageBox.Show("You cannot add another level without being 'Administrator'", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
				cboLevel.Focus()
				Exit Sub
			End If
			rs.AddNew()
			msg = "Added new user " & txtUsername.Text
		ElseIf CurrentEditedUser <> txtUsername.Text Then 
			ExecuteSql2("Select * from Users where username = '" & txtUsername.Text & "'")
			If Not rs2.EOF Then
				MessageBox.Show("Username '" & txtUsername.Text & "' already exists.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
				txtUsername.Focus()
				SelectAll(txtUsername)
				Exit Sub
			End If
			msg = "Record for the user " & txtUsername.Text & " has been successfully updated"
		Else
			msg = "Record for the user " & txtUsername.Text & " has been successfully updated"
		End If
		rs("UserName") = txtUsername.Text
		rs("Password") = txtPassword.Text
		rs("Level") = cboLevel.Text
		rs("Fullname") = txtFullname.Text
		rs.Update()
		LogStatus(msg)
		ClearFields()
		LoadUsers()

		If CurrentUserAdmin Then
			Me.Close()
		End If
	End Sub

	Public Sub LoadUsers()
		ExecuteSql("Select * from Users")
		lstAccounts.Items.Clear()
		Dim x As ListViewItem
		While Not rs.EOF
			x = lstAccounts.Items.Add(rs("UserName"))
			ListViewHelper.GetListViewSubItem(x, 1).Text = rs("Fullname")
			ListViewHelper.GetListViewSubItem(x, 2).Text = rs("Level")
			rs.MoveNext()
		End While
	End Sub

	Public Sub LoadUsersAvoidingWith()
		ExecuteSql("Select * from Users")
		lstAccounts.Items.Clear()
		Dim x As ListViewItem
		While Not rs.EOF
			x = lstAccounts.Items.Add(rs("UserName"))
			ListViewHelper.GetListViewSubItem(x, 1).Text = rs("Fullname")
			ListViewHelper.GetListViewSubItem(x, 2).Text = rs("Level")
			rs.MoveNext()
		End While
	End Sub


	Public Sub ClearFields()
		txtUsername.Text = ""
		txtPassword.Text = ""
		txtFullname.Text = ""
		cboLevel.SelectedIndex = -1
		cmdSave.Text = "&Save"
	End Sub

	Private Sub cmdClose_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdClose.Click
		Me.Close()
	End Sub

	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
	Private Sub Form_Load()
		ExecuteSql("Select * from Levels")
		While Not rs.EOF
			cboLevel.AddItem(rs("Level"))
			rs.MoveNext()
		End While
		If CurrentUserAdmin Then
			cboLevel.Text = "Administrator"
		Else
			cboLevel.SelectedIndex = -1
		End If
		LoadUsers()
	End Sub

	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
		If CurrentUserAdmin Then
			ExecuteSql("Select * from Users")
			If rs.EOF Then
				MessageBox.Show("System has failed to initialized. Please contact your administrator" & Environment.NewLine & Environment.NewLine & "Status: analysing accounts configuration" & Environment.NewLine &  _
				                "Error: No users found", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
				Environment.Exit(0)
			End If
			'frmxSplash.tmrLoad.Enabled = True
		End If
		LogStatus("")
	End Sub

	Private Sub lstAccounts_DoubleClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles lstAccounts.DoubleClick
		cmdEdit_Click(cmdEdit, New EventArgs())
	End Sub

	Private Sub txtFullname_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtFullname.Enter
		SelectAll(txtFullname)
	End Sub

	Private Sub txtPassword_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtPassword.Enter
		SelectAll(txtPassword)
	End Sub

	Private Sub txtUsername_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtUsername.Enter
		SelectAll(txtUsername)
	End Sub
End Class