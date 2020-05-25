Option Strict Off
Option Explicit On
Imports System
Imports System.Windows.Forms
Module modMain

	Public CurrentUserAdmin As Boolean
	Public UserFullname As String = ""
	Public UserLevel As String = ""
	Public UserId As String = ""

	Public ConnectionString As String = ""

	Public DetectionType As Integer
	Public n As Double
	Public i As Integer
	Public s As String = ""
	Public d As Date
	Public msg As String = ""
	Public ImgName As String = "", ImgSrc As String = ""

	<STAThread> _
	 Public Sub Main()
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)
		ConnectionString = "DRIVER=SQLite3 ODBC Driver; Database=Orders.db; LongNames=0; Timeout=1000; NoTXN=0; SyncPragma=NORMAL; StepAPI=0;"

		OpenConnection()
		CurrentUserAdmin = True
		UserFullname = "Allan Cantillo"
		UserLevel = "Administrator"
		UserId = "acantillo"
		Application.Run(frmMain.DefInstance)
	End Sub

	Public Sub LogStatus(ByVal message As String, Optional ByVal frm As Form = Nothing)
		Dim sb As StatusStrip
		sb = Nothing
		CType(frmMain.DefInstance.sbStatusBar.Items.Item(0), ToolStripStatusLabel).Text = message
		If Not (frm Is Nothing) Then
			If frm Is frmAdjustStockManual.DefInstance Then
				sb = frmAdjustStockManual.DefInstance.sbStatusBar
			ElseIf frm Is frmActionOrderReception.DefInstance Then 
				sb = frmActionOrderReception.DefInstance.sbStatusBar
			ElseIf frm Is frmActionOrderRequest.DefInstance Then 
				sb = frmActionOrderRequest.DefInstance.sbStatusBar
			ElseIf frm Is frmAddStockManual.DefInstance Then 
				sb = frmAddStockManual.DefInstance.sbStatusBar
			ElseIf frm Is frmReceptionApproval.DefInstance Then 
				sb = frmReceptionApproval.DefInstance.sbStatusBar
			ElseIf frm Is frmOrderReception.DefInstance Then 
				sb = frmOrderReception.DefInstance.sbStatusBar
			ElseIf frm Is frmOrderRequest.DefInstance Then 
				sb = frmOrderRequest.DefInstance.sbStatusBar
			ElseIf frm Is frmRequestApproval.DefInstance Then 
				sb = frmRequestApproval.DefInstance.sbStatusBar
			End If
			If Not (sb Is Nothing) Then
				If Not (CType(sb.Items.Item(0), ToolStripStatusLabel) Is Nothing) Then
					CType(sb.Items.Item(0), ToolStripStatusLabel).Text = message
				End If
			End If
		End If
	End Sub

	Public Sub ClearLogStatus(Optional ByVal frm As Form = Nothing)
		LogStatus("", frm)
	End Sub
End Module