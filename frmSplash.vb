Option Strict Off
Option Explicit On
Imports System
Imports System.Windows.Forms
Partial Friend Class frmSplash
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


	Private Sub frmSplash_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub


	Private Sub Form_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles MyBase.KeyPress
		Dim KeyAscii As Integer = Convert.ToInt32(eventArgs.KeyChar)
		Try
			Me.Close()
		Finally 
			If KeyAscii = 0 Then
				eventArgs.Handled = True
			End If
			eventArgs.KeyChar = Convert.ToChar(KeyAscii)
		End Try
	End Sub

	'UPGRADE_NOTE: (7001) The following declaration (Frame1_Click) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
	'Private Sub Frame1_Click()
		'Me.Close()
	'End Sub

	Private Sub Timer1_Tick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Timer1.Tick
		Me.Close()
	End Sub
	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class