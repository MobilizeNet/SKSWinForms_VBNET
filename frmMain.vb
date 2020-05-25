Option Strict Off
Option Explicit On
Imports System
Imports System.Windows.Forms
Partial Friend Class frmMain
	Inherits System.Windows.Forms.Form
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			m_vb6FormDefInstance = Me
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		ReLoadForm(False)
	End Sub


	Private Sub frmMain_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub

	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
	Private Sub MDIForm_Load()
		frmSplash.DefInstance.ShowDialog()
		frmOrderRequest.DefInstance.Show()


	End Sub

	Public Sub mnuAbout_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuAbout.Click
		frmAbout.DefInstance.Show()
	End Sub

	Public Sub mnuAddStockManually_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuAddStockManually.Click
		frmAddStockManual.DefInstance.Show()
	End Sub

	Public Sub mnuAdjustStockManually_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuAdjustStockManually.Click
		frmAdjustStockManual.DefInstance.Show()
	End Sub

	Public Sub mnuCreateOrderReception_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuCreateOrderReception.Click
		frmOrderReception.DefInstance.Show()
	End Sub

	Public Sub mnuCreateOrderRequest_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuCreateOrderRequest.Click
		frmOrderRequest.DefInstance.Show()
	End Sub

	Public Sub mnuCustomer_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuCustomer.Click
		frmCustomers.DefInstance.ShowDialog()
		frmCustomers.DefInstance.InitForm()
	End Sub

	Public Sub mnuExit_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuExit.Click
		Me.Close()
	End Sub

	Public Sub mnuOrderReceptionsApproval_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuOrderReceptionsApproval.Click
		frmReceptionApproval.DefInstance.Show()
	End Sub

	Public Sub mnuOrderRequestsApproval_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuOrderRequestsApproval.Click
		frmRequestApproval.DefInstance.Show()
	End Sub

	Public Sub mnuProducts_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuProducts.Click
		frmProducts.DefInstance.ShowDialog()
	End Sub

	Public Sub mnuProviders_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuProviders.Click
		frmProviders.DefInstance.ShowDialog()
	End Sub

	Public Sub mnuSecurity_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuSecurity.Click
		frmUsersManage.DefInstance.Show()
	End Sub
	'UPGRADE_NOTE: (7001) The following declaration (Form_Unload) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
	'Private Sub Form_Unload(ByVal Cancel As Integer)
	'End Sub
End Class