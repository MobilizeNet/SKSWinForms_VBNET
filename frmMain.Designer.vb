<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmMain
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmMain
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmMain)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmMain
		Dim theInstance As New frmMain()
		theInstance.MDIForm_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "mnuCustomer", "mnuProviders", "mnuExit", "mnuFile", "mnuCreateOrderRequest", "mnuOrderRequestsApproval", "lExit2", "mnuCreateOrderReception", "mnuOrderReceptionsApproval", "mnuOrders", "mnuAddStockManually", "mnuAdjustStockManually", "mnuMainInventory", "mnuProducts", "mnuSecurity", "mnuAccounts", "mnuAbout", "mnuHelp", "MainMenu1", "sbStatusBar_Panels_Panel1", "sbStatusBar_Panels_Panel2", "sbStatusBar_Panels_Panel3", "sbStatusBar"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents mnuCustomer As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuProviders As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuCreateOrderRequest As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuOrderRequestsApproval As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents lExit2 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuCreateOrderReception As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuOrderReceptionsApproval As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuOrders As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuAddStockManually As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuAdjustStockManually As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuMainInventory As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuProducts As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuSecurity As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuAccounts As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public WithEvents sbStatusBar_Panels_Panel1 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents sbStatusBar_Panels_Panel2 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents sbStatusBar_Panels_Panel3 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents sbStatusBar As System.Windows.Forms.StatusStrip
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
		Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCustomer = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuProviders = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuOrders = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCreateOrderRequest = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuOrderRequestsApproval = New System.Windows.Forms.ToolStripMenuItem()
		Me.lExit2 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuCreateOrderReception = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuOrderReceptionsApproval = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuMainInventory = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuAddStockManually = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuAdjustStockManually = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuAccounts = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuProducts = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuSecurity = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
		Me.sbStatusBar = New System.Windows.Forms.StatusStrip()
		Me.sbStatusBar_Panels_Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.sbStatusBar_Panels_Panel2 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.sbStatusBar_Panels_Panel3 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.sbStatusBar.SuspendLayout()
		Me.SuspendLayout()
		' 
		'MainMenu1
		' 
		Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuOrders, Me.mnuMainInventory, Me.mnuAccounts, Me.mnuHelp})
		' 
		'mnuFile
		' 
		Me.mnuFile.Available = True
		Me.mnuFile.Checked = False
		Me.mnuFile.Enabled = True
		Me.mnuFile.MergeAction = System.Windows.Forms.MergeAction.Remove
		Me.mnuFile.Name = "mnuFile"
		Me.mnuFile.Text = "&File"
		Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCustomer, Me.mnuProviders, Me.mnuExit})
		' 
		'mnuCustomer
		' 
		Me.mnuCustomer.Available = True
		Me.mnuCustomer.Checked = False
		Me.mnuCustomer.Enabled = True
		Me.mnuCustomer.Name = "mnuCustomer"
		Me.mnuCustomer.Text = "&Manage Customers"
		' 
		'mnuProviders
		' 
		Me.mnuProviders.Available = True
		Me.mnuProviders.Checked = False
		Me.mnuProviders.Enabled = True
		Me.mnuProviders.Name = "mnuProviders"
		Me.mnuProviders.Text = "Manage Su&ppliers "
		' 
		'mnuExit
		' 
		Me.mnuExit.Available = True
		Me.mnuExit.Checked = False
		Me.mnuExit.Enabled = True
		Me.mnuExit.Name = "mnuExit"
		Me.mnuExit.Text = "&Exit"
		' 
		'mnuOrders
		' 
		Me.mnuOrders.Available = True
		Me.mnuOrders.Checked = False
		Me.mnuOrders.Enabled = True
		Me.mnuOrders.MergeAction = System.Windows.Forms.MergeAction.Remove
		Me.mnuOrders.Name = "mnuOrders"
		Me.mnuOrders.Text = "&Orders"
		Me.mnuOrders.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCreateOrderRequest, Me.mnuOrderRequestsApproval, Me.lExit2, Me.mnuCreateOrderReception, Me.mnuOrderReceptionsApproval})
		' 
		'mnuCreateOrderRequest
		' 
		Me.mnuCreateOrderRequest.Available = True
		Me.mnuCreateOrderRequest.Checked = False
		Me.mnuCreateOrderRequest.Enabled = True
		Me.mnuCreateOrderRequest.Name = "mnuCreateOrderRequest"
		Me.mnuCreateOrderRequest.Text = "Create Order"
		' 
		'mnuOrderRequestsApproval
		' 
		Me.mnuOrderRequestsApproval.Available = True
		Me.mnuOrderRequestsApproval.Checked = False
		Me.mnuOrderRequestsApproval.Enabled = True
		Me.mnuOrderRequestsApproval.Name = "mnuOrderRequestsApproval"
		Me.mnuOrderRequestsApproval.Text = "Create Invoice"
		' 
		'lExit2
		' 
		Me.lExit2.AllowDrop = True
		Me.lExit2.Available = True
		Me.lExit2.Enabled = True
		Me.lExit2.Name = "lExit2"
		' 
		'mnuCreateOrderReception
		' 
		Me.mnuCreateOrderReception.Available = True
		Me.mnuCreateOrderReception.Checked = False
		Me.mnuCreateOrderReception.Enabled = True
		Me.mnuCreateOrderReception.Name = "mnuCreateOrderReception"
		Me.mnuCreateOrderReception.Text = "Add Stock Order"
		' 
		'mnuOrderReceptionsApproval
		' 
		Me.mnuOrderReceptionsApproval.Available = True
		Me.mnuOrderReceptionsApproval.Checked = False
		Me.mnuOrderReceptionsApproval.Enabled = True
		Me.mnuOrderReceptionsApproval.Name = "mnuOrderReceptionsApproval"
		Me.mnuOrderReceptionsApproval.Text = "Add Stock to Inventory"
		' 
		'mnuMainInventory
		' 
		Me.mnuMainInventory.Available = True
		Me.mnuMainInventory.Checked = False
		Me.mnuMainInventory.Enabled = True
		Me.mnuMainInventory.MergeAction = System.Windows.Forms.MergeAction.Remove
		Me.mnuMainInventory.Name = "mnuMainInventory"
		Me.mnuMainInventory.Text = "&Inventory"
		Me.mnuMainInventory.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddStockManually, Me.mnuAdjustStockManually})
		' 
		'mnuAddStockManually
		' 
		Me.mnuAddStockManually.Available = True
		Me.mnuAddStockManually.Checked = False
		Me.mnuAddStockManually.Enabled = True
		Me.mnuAddStockManually.Name = "mnuAddStockManually"
		Me.mnuAddStockManually.Text = "Inventory Update"
		' 
		'mnuAdjustStockManually
		' 
		Me.mnuAdjustStockManually.Available = True
		Me.mnuAdjustStockManually.Checked = False
		Me.mnuAdjustStockManually.Enabled = True
		Me.mnuAdjustStockManually.Name = "mnuAdjustStockManually"
		Me.mnuAdjustStockManually.Text = "Inventory Adjust"
		' 
		'mnuAccounts
		' 
		Me.mnuAccounts.Available = True
		Me.mnuAccounts.Checked = False
		Me.mnuAccounts.Enabled = True
		Me.mnuAccounts.MergeAction = System.Windows.Forms.MergeAction.Remove
		Me.mnuAccounts.Name = "mnuAccounts"
		Me.mnuAccounts.Text = "&Maintenance"
		Me.mnuAccounts.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProducts, Me.mnuSecurity})
		' 
		'mnuProducts
		' 
		Me.mnuProducts.Available = True
		Me.mnuProducts.Checked = False
		Me.mnuProducts.Enabled = True
		Me.mnuProducts.Name = "mnuProducts"
		Me.mnuProducts.Text = "Manage Products"
		' 
		'mnuSecurity
		' 
		Me.mnuSecurity.Available = True
		Me.mnuSecurity.Checked = False
		Me.mnuSecurity.Enabled = True
		Me.mnuSecurity.Name = "mnuSecurity"
		Me.mnuSecurity.Text = "Manage Users"
		' 
		'mnuHelp
		' 
		Me.mnuHelp.Available = True
		Me.mnuHelp.Checked = False
		Me.mnuHelp.Enabled = True
		Me.mnuHelp.MergeAction = System.Windows.Forms.MergeAction.Remove
		Me.mnuHelp.Name = "mnuHelp"
		Me.mnuHelp.Text = "&Help"
		Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
		' 
		'mnuAbout
		' 
		Me.mnuAbout.Available = True
		Me.mnuAbout.Checked = False
		Me.mnuAbout.Enabled = True
		Me.mnuAbout.Name = "mnuAbout"
		Me.mnuAbout.Text = "&About"
		' 
		'sbStatusBar
		' 
		Me.sbStatusBar.AllowDrop = True
		Me.sbStatusBar.BackColor = System.Drawing.SystemColors.Control
		Me.sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.sbStatusBar.Location = New System.Drawing.Point(0, 683)
		Me.sbStatusBar.Name = "sbStatusBar"
		Me.sbStatusBar.ShowItemToolTips = True
		Me.sbStatusBar.Size = New System.Drawing.Size(1113, 25)
		Me.sbStatusBar.TabIndex = 0
		Me.sbStatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbStatusBar_Panels_Panel1})
		Me.sbStatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbStatusBar_Panels_Panel2})
		Me.sbStatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbStatusBar_Panels_Panel3})
		' 
		'sbStatusBar_Panels_Panel1
		' 
		Me.sbStatusBar_Panels_Panel1.BorderSides = CType(System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom, System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.sbStatusBar_Panels_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.sbStatusBar_Panels_Panel1.DoubleClickEnabled = True
		Me.sbStatusBar_Panels_Panel1.Margin = New System.Windows.Forms.Padding(0)
		Me.sbStatusBar_Panels_Panel1.Size = New System.Drawing.Size(901, 25)
		Me.sbStatusBar_Panels_Panel1.Spring = True
		Me.sbStatusBar_Panels_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.sbStatusBar_Panels_Panel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		' 
		'sbStatusBar_Panels_Panel2
		' 
		Me.sbStatusBar_Panels_Panel2.AutoSize = False
		Me.sbStatusBar_Panels_Panel2.BorderSides = CType(System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom, System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.sbStatusBar_Panels_Panel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.sbStatusBar_Panels_Panel2.DoubleClickEnabled = True
		Me.sbStatusBar_Panels_Panel2.Margin = New System.Windows.Forms.Padding(0)
		Me.sbStatusBar_Panels_Panel2.Size = New System.Drawing.Size(96, 25)
		Me.sbStatusBar_Panels_Panel2.Text = "1:25 PM"
		Me.sbStatusBar_Panels_Panel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.sbStatusBar_Panels_Panel2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		' 
		'sbStatusBar_Panels_Panel3
		' 
		Me.sbStatusBar_Panels_Panel3.AutoSize = False
		Me.sbStatusBar_Panels_Panel3.BorderSides = CType(System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom, System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.sbStatusBar_Panels_Panel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.sbStatusBar_Panels_Panel3.DoubleClickEnabled = True
		Me.sbStatusBar_Panels_Panel3.Margin = New System.Windows.Forms.Padding(0)
		Me.sbStatusBar_Panels_Panel3.Size = New System.Drawing.Size(96, 25)
		Me.sbStatusBar_Panels_Panel3.Text = "2/21/2018"
		Me.sbStatusBar_Panels_Panel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.sbStatusBar_Panels_Panel3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		' 
		'frmMain
		' 
		Me.AllowDrop = True
		Me.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.ClientSize = New System.Drawing.Size(1113, 708)
		Me.Controls.Add(Me.sbStatusBar)
		Me.Controls.Add(MainMenu1)
		Me.Enabled = True
		Me.IsMdiContainer = True
		Me.Location = New System.Drawing.Point(11, 54)
		Me.Name = "frmMain"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text = "Sales Agent"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.sbStatusBar.ResumeLayout(False)
		Me.ResumeLayout(False)
	End Sub
	Sub ReLoadForm(ByVal addEvents As Boolean)
		MDIForm_Load()
		If addEvents Then
			AddHandler Me.Activated, AddressOf Me.frmMain_Activated
		End If
	End Sub
#End Region
End Class