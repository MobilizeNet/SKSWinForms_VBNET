Option Strict Off
Option Explicit On
Imports System
Imports System.Windows.Forms
Partial Friend Class frmAbout
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


	Private Sub frmAbout_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub

	' Reg Key Security Options...
	Const READ_CONTROL As Integer = &H20000
	Const KEY_QUERY_VALUE As Integer = &H1s
	Const KEY_SET_VALUE As Integer = &H2s
	Const KEY_CREATE_SUB_KEY As Integer = &H4s
	Const KEY_ENUMERATE_SUB_KEYS As Integer = &H8s
	Const KEY_NOTIFY As Integer = &H10s
	Const KEY_CREATE_LINK As Integer = &H20s
	Const KEY_ALL_ACCESS As Integer = KEY_QUERY_VALUE + KEY_SET_VALUE + KEY_CREATE_SUB_KEY + KEY_ENUMERATE_SUB_KEYS + KEY_NOTIFY + KEY_CREATE_LINK + READ_CONTROL

	' Reg Key ROOT Types...
	Const HKEY_LOCAL_MACHINE As Integer = &H80000002
	Const ERROR_SUCCESS As Integer = 0
	Const REG_SZ As Integer = 1 ' Unicode nul terminated string
	Const REG_DWORD As Integer = 4 ' 32-bit number


	Private Sub cmdOk_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdOK.Click
		Me.Close()
	End Sub

	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
	Private Sub Form_Load()
		Me.Text = "About " & My.Application.Info.Title
		'lblVersion.Caption = "Version " & App.Major & "." & App.Minor & "." & App.Revision
		lblTitle.Text = My.Application.Info.Title
	End Sub
	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class