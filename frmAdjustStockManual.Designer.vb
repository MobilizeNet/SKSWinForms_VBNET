<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdjustStockManual
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmAdjustStockManual
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmAdjustStockManual
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmAdjustStockManual)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmAdjustStockManual
		Dim theInstance As New frmAdjustStockManual()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "sbStatusBar_Panels_Panel1", "sbStatusBar", "txtStockID", "txtOriginalPrice", "_txtValues_0", "txtQuantityPerUnit", "txtProductName", "txtUnit", "_txtValues_1", "txtOriginalQuantity", "lvStocks_ColumnHeader_1_", "lvStocks_ColumnHeader_2_", "lvStocks_ColumnHeader_3_", "lvStocks_ColumnHeader_4_", "lvStocks_ColumnHeader_5_", "lvStocks_ColumnHeader_6_", "lvStocks_ColumnHeader_7_", "lvStocks_ColumnHeader_8_", "lvStocks", "Frame3", "txtCode", "txtName", "cmdProducts", "Label5", "Label4", "Frame1", "cmdClose", "cmdSave", "lvProducts_ColumnHeader_1_", "lvProducts_ColumnHeader_2_", "lvProducts_ColumnHeader_3_", "lvProducts_ColumnHeader_4_", "lvProducts_ColumnHeader_5_", "lvProducts_ColumnHeader_6_", "lvProducts_ColumnHeader_7_", "lvProducts", "Label14", "lblNewQuantity", "Label12", "lblCurrentQuantity", "Label11", "Label10", "Label8", "Label9", "Label7", "Label6", "Label2", "Label1", "Label3", "txtValues", "listViewHelper1"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents sbStatusBar_Panels_Panel1 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents sbStatusBar As System.Windows.Forms.StatusStrip
	Public WithEvents txtStockID As System.Windows.Forms.TextBox
	Public WithEvents txtOriginalPrice As System.Windows.Forms.TextBox
	Private WithEvents _txtValues_0 As System.Windows.Forms.TextBox
	Public WithEvents txtQuantityPerUnit As System.Windows.Forms.TextBox
	Public WithEvents txtProductName As System.Windows.Forms.TextBox
	Public WithEvents txtUnit As System.Windows.Forms.TextBox
	Private WithEvents _txtValues_1 As System.Windows.Forms.TextBox
	Public WithEvents txtOriginalQuantity As System.Windows.Forms.TextBox
	Public WithEvents lvStocks_ColumnHeader_1_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvStocks_ColumnHeader_2_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvStocks_ColumnHeader_3_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvStocks_ColumnHeader_4_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvStocks_ColumnHeader_5_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvStocks_ColumnHeader_6_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvStocks_ColumnHeader_7_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvStocks_ColumnHeader_8_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvStocks As System.Windows.Forms.ListView
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents txtCode As System.Windows.Forms.TextBox
	Public WithEvents txtName As System.Windows.Forms.TextBox
	Public WithEvents cmdProducts As System.Windows.Forms.Button
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents lvProducts_ColumnHeader_1_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProducts_ColumnHeader_2_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProducts_ColumnHeader_3_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProducts_ColumnHeader_4_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProducts_ColumnHeader_5_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProducts_ColumnHeader_6_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProducts_ColumnHeader_7_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProducts As System.Windows.Forms.ListView
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents lblNewQuantity As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents lblCurrentQuantity As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public txtValues(1) As System.Windows.Forms.TextBox
	Public listViewHelper1 As UpgradeHelpers.Gui.ListViewHelper
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmAdjustStockManual))
		Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
		Me.sbStatusBar = New System.Windows.Forms.StatusStrip()
		Me.sbStatusBar_Panels_Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.txtStockID = New System.Windows.Forms.TextBox()
		Me.txtOriginalPrice = New System.Windows.Forms.TextBox()
		Me._txtValues_0 = New System.Windows.Forms.TextBox()
		Me.txtQuantityPerUnit = New System.Windows.Forms.TextBox()
		Me.txtProductName = New System.Windows.Forms.TextBox()
		Me.txtUnit = New System.Windows.Forms.TextBox()
		Me._txtValues_1 = New System.Windows.Forms.TextBox()
		Me.txtOriginalQuantity = New System.Windows.Forms.TextBox()
		Me.Frame3 = New System.Windows.Forms.GroupBox()
		Me.lvStocks = New System.Windows.Forms.ListView()
		Me.lvStocks_ColumnHeader_1_ = New System.Windows.Forms.ColumnHeader()
		Me.lvStocks_ColumnHeader_2_ = New System.Windows.Forms.ColumnHeader()
		Me.lvStocks_ColumnHeader_3_ = New System.Windows.Forms.ColumnHeader()
		Me.lvStocks_ColumnHeader_4_ = New System.Windows.Forms.ColumnHeader()
		Me.lvStocks_ColumnHeader_5_ = New System.Windows.Forms.ColumnHeader()
		Me.lvStocks_ColumnHeader_6_ = New System.Windows.Forms.ColumnHeader()
		Me.lvStocks_ColumnHeader_7_ = New System.Windows.Forms.ColumnHeader()
		Me.lvStocks_ColumnHeader_8_ = New System.Windows.Forms.ColumnHeader()
		Me.Frame1 = New System.Windows.Forms.GroupBox()
		Me.txtCode = New System.Windows.Forms.TextBox()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.cmdProducts = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.cmdClose = New System.Windows.Forms.Button()
		Me.cmdSave = New System.Windows.Forms.Button()
		Me.lvProducts = New System.Windows.Forms.ListView()
		Me.lvProducts_ColumnHeader_1_ = New System.Windows.Forms.ColumnHeader()
		Me.lvProducts_ColumnHeader_2_ = New System.Windows.Forms.ColumnHeader()
		Me.lvProducts_ColumnHeader_3_ = New System.Windows.Forms.ColumnHeader()
		Me.lvProducts_ColumnHeader_4_ = New System.Windows.Forms.ColumnHeader()
		Me.lvProducts_ColumnHeader_5_ = New System.Windows.Forms.ColumnHeader()
		Me.lvProducts_ColumnHeader_6_ = New System.Windows.Forms.ColumnHeader()
		Me.lvProducts_ColumnHeader_7_ = New System.Windows.Forms.ColumnHeader()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.lblNewQuantity = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.lblCurrentQuantity = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.sbStatusBar.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.lvStocks.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.lvProducts.SuspendLayout()
		Me.SuspendLayout()
		Me.listViewHelper1 = New UpgradeHelpers.Gui.ListViewHelper(Me.components)
		Me.listViewHelper1.BeginInit()
		' 
		'sbStatusBar
		' 
		Me.sbStatusBar.AllowDrop = True
		Me.sbStatusBar.BackColor = System.Drawing.SystemColors.Control
		Me.sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.sbStatusBar.Location = New System.Drawing.Point(0, 538)
		Me.sbStatusBar.Name = "sbStatusBar"
		Me.sbStatusBar.ShowItemToolTips = True
		Me.sbStatusBar.Size = New System.Drawing.Size(426, 25)
		Me.sbStatusBar.TabIndex = 28
		Me.sbStatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbStatusBar_Panels_Panel1})
		' 
		'sbStatusBar_Panels_Panel1
		' 
		Me.sbStatusBar_Panels_Panel1.BorderSides = CType(System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom, System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.sbStatusBar_Panels_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.sbStatusBar_Panels_Panel1.DoubleClickEnabled = True
		Me.sbStatusBar_Panels_Panel1.Margin = New System.Windows.Forms.Padding(0)
		Me.sbStatusBar_Panels_Panel1.Size = New System.Drawing.Size(425, 25)
		Me.sbStatusBar_Panels_Panel1.Spring = True
		Me.sbStatusBar_Panels_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.sbStatusBar_Panels_Panel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		' 
		'txtStockID
		' 
		Me.txtStockID.AcceptsReturn = True
		Me.txtStockID.AllowDrop = True
		Me.txtStockID.BackColor = System.Drawing.SystemColors.Menu
		Me.txtStockID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStockID.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStockID.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStockID.Location = New System.Drawing.Point(96, 374)
		Me.txtStockID.MaxLength = 0
		Me.txtStockID.Name = "txtStockID"
		Me.txtStockID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStockID.Size = New System.Drawing.Size(81, 20)
		Me.txtStockID.TabIndex = 26
		Me.txtStockID.TabStop = False
		' 
		'txtOriginalPrice
		' 
		Me.txtOriginalPrice.AcceptsReturn = True
		Me.txtOriginalPrice.AllowDrop = True
		Me.txtOriginalPrice.BackColor = System.Drawing.SystemColors.Menu
		Me.txtOriginalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtOriginalPrice.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtOriginalPrice.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtOriginalPrice.Location = New System.Drawing.Point(96, 403)
		Me.txtOriginalPrice.MaxLength = 0
		Me.txtOriginalPrice.Name = "txtOriginalPrice"
		Me.txtOriginalPrice.ReadOnly = True
		Me.txtOriginalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtOriginalPrice.Size = New System.Drawing.Size(81, 20)
		Me.txtOriginalPrice.TabIndex = 25
		Me.txtOriginalPrice.TabStop = False
		Me.txtOriginalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		' 
		'_txtValues_0
		' 
		Me._txtValues_0.AcceptsReturn = True
		Me._txtValues_0.AllowDrop = True
		Me._txtValues_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtValues_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtValues_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtValues_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtValues_0.Location = New System.Drawing.Point(328, 403)
		Me._txtValues_0.MaxLength = 0
		Me._txtValues_0.Name = "_txtValues_0"
		Me._txtValues_0.ReadOnly = True
		Me._txtValues_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtValues_0.Size = New System.Drawing.Size(81, 20)
		Me._txtValues_0.TabIndex = 4
		Me._txtValues_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		' 
		'txtQuantityPerUnit
		' 
		Me.txtQuantityPerUnit.AcceptsReturn = True
		Me.txtQuantityPerUnit.AllowDrop = True
		Me.txtQuantityPerUnit.BackColor = System.Drawing.SystemColors.Menu
		Me.txtQuantityPerUnit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtQuantityPerUnit.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtQuantityPerUnit.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtQuantityPerUnit.Location = New System.Drawing.Point(328, 374)
		Me.txtQuantityPerUnit.MaxLength = 0
		Me.txtQuantityPerUnit.Name = "txtQuantityPerUnit"
		Me.txtQuantityPerUnit.ReadOnly = True
		Me.txtQuantityPerUnit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtQuantityPerUnit.Size = New System.Drawing.Size(81, 20)
		Me.txtQuantityPerUnit.TabIndex = 21
		Me.txtQuantityPerUnit.TabStop = False
		Me.txtQuantityPerUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		' 
		'txtProductName
		' 
		Me.txtProductName.AcceptsReturn = True
		Me.txtProductName.AllowDrop = True
		Me.txtProductName.BackColor = System.Drawing.SystemColors.Menu
		Me.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtProductName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtProductName.Location = New System.Drawing.Point(96, 344)
		Me.txtProductName.MaxLength = 0
		Me.txtProductName.Name = "txtProductName"
		Me.txtProductName.ReadOnly = True
		Me.txtProductName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtProductName.Size = New System.Drawing.Size(145, 20)
		Me.txtProductName.TabIndex = 20
		Me.txtProductName.TabStop = False
		' 
		'txtUnit
		' 
		Me.txtUnit.AcceptsReturn = True
		Me.txtUnit.AllowDrop = True
		Me.txtUnit.BackColor = System.Drawing.SystemColors.Menu
		Me.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtUnit.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtUnit.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtUnit.Location = New System.Drawing.Point(328, 344)
		Me.txtUnit.MaxLength = 0
		Me.txtUnit.Name = "txtUnit"
		Me.txtUnit.ReadOnly = True
		Me.txtUnit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtUnit.Size = New System.Drawing.Size(81, 20)
		Me.txtUnit.TabIndex = 19
		Me.txtUnit.TabStop = False
		' 
		'_txtValues_1
		' 
		Me._txtValues_1.AcceptsReturn = True
		Me._txtValues_1.AllowDrop = True
		Me._txtValues_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtValues_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtValues_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtValues_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtValues_1.Location = New System.Drawing.Point(328, 432)
		Me._txtValues_1.MaxLength = 0
		Me._txtValues_1.Name = "_txtValues_1"
		Me._txtValues_1.ReadOnly = True
		Me._txtValues_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtValues_1.Size = New System.Drawing.Size(81, 20)
		Me._txtValues_1.TabIndex = 5
		Me._txtValues_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		' 
		'txtOriginalQuantity
		' 
		Me.txtOriginalQuantity.AcceptsReturn = True
		Me.txtOriginalQuantity.AllowDrop = True
		Me.txtOriginalQuantity.BackColor = System.Drawing.SystemColors.Menu
		Me.txtOriginalQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtOriginalQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtOriginalQuantity.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtOriginalQuantity.Location = New System.Drawing.Point(96, 432)
		Me.txtOriginalQuantity.MaxLength = 0
		Me.txtOriginalQuantity.Name = "txtOriginalQuantity"
		Me.txtOriginalQuantity.ReadOnly = True
		Me.txtOriginalQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtOriginalQuantity.Size = New System.Drawing.Size(81, 20)
		Me.txtOriginalQuantity.TabIndex = 14
		Me.txtOriginalQuantity.TabStop = False
		Me.txtOriginalQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		' 
		'Frame3
		' 
		Me.Frame3.AllowDrop = True
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Controls.Add(Me.lvStocks)
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.Location = New System.Drawing.Point(8, 200)
		Me.Frame3.Name = "Frame3"
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Size = New System.Drawing.Size(409, 137)
		Me.Frame3.TabIndex = 13
		Me.Frame3.Visible = True
		' 
		'lvStocks
		' 
		Me.lvStocks.AllowDrop = True
		Me.lvStocks.BackColor = System.Drawing.SystemColors.Window
		Me.lvStocks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lvStocks.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lvStocks.FullRowSelect = True
		Me.lvStocks.GridLines = True
		Me.lvStocks.HideSelection = False
		Me.lvStocks.HotTracking = True
		Me.lvStocks.LabelEdit = False
		Me.lvStocks.Location = New System.Drawing.Point(8, 16)
		Me.lvStocks.MultiSelect = False
		Me.lvStocks.Name = "lvStocks"
		Me.lvStocks.Size = New System.Drawing.Size(393, 113)
		Me.lvStocks.TabIndex = 3
		Me.lvStocks.View = System.Windows.Forms.View.Details
		Me.lvStocks.Columns.Add(Me.lvStocks_ColumnHeader_1_)
		Me.lvStocks.Columns.Add(Me.lvStocks_ColumnHeader_2_)
		Me.lvStocks.Columns.Add(Me.lvStocks_ColumnHeader_3_)
		Me.lvStocks.Columns.Add(Me.lvStocks_ColumnHeader_4_)
		Me.lvStocks.Columns.Add(Me.lvStocks_ColumnHeader_5_)
		Me.lvStocks.Columns.Add(Me.lvStocks_ColumnHeader_6_)
		Me.lvStocks.Columns.Add(Me.lvStocks_ColumnHeader_7_)
		Me.lvStocks.Columns.Add(Me.lvStocks_ColumnHeader_8_)
		' 
		'lvStocks_ColumnHeader_1_
		' 
		Me.lvStocks_ColumnHeader_1_.Text = "Stock ID"
		Me.lvStocks_ColumnHeader_1_.Width = 97
		' 
		'lvStocks_ColumnHeader_2_
		' 
		Me.lvStocks_ColumnHeader_2_.Text = "Current Stock"
		Me.lvStocks_ColumnHeader_2_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.lvStocks_ColumnHeader_2_.Width = 97
		' 
		'lvStocks_ColumnHeader_3_
		' 
		Me.lvStocks_ColumnHeader_3_.Text = "Initial Stock"
		Me.lvStocks_ColumnHeader_3_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.lvStocks_ColumnHeader_3_.Width = 97
		' 
		'lvStocks_ColumnHeader_4_
		' 
		Me.lvStocks_ColumnHeader_4_.Text = "Price"
		Me.lvStocks_ColumnHeader_4_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.lvStocks_ColumnHeader_4_.Width = 97
		' 
		'lvStocks_ColumnHeader_5_
		' 
		Me.lvStocks_ColumnHeader_5_.Text = "Stock Price"
		Me.lvStocks_ColumnHeader_5_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.lvStocks_ColumnHeader_5_.Width = 97
		' 
		'lvStocks_ColumnHeader_6_
		' 
		Me.lvStocks_ColumnHeader_6_.Text = "Created"
		Me.lvStocks_ColumnHeader_6_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.lvStocks_ColumnHeader_6_.Width = 97
		' 
		'lvStocks_ColumnHeader_7_
		' 
		Me.lvStocks_ColumnHeader_7_.Text = "Modified"
		Me.lvStocks_ColumnHeader_7_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.lvStocks_ColumnHeader_7_.Width = 97
		' 
		'lvStocks_ColumnHeader_8_
		' 
		Me.lvStocks_ColumnHeader_8_.Text = "User"
		Me.lvStocks_ColumnHeader_8_.Width = 97
		' 
		'Frame1
		' 
		Me.Frame1.AllowDrop = True
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Controls.Add(Me.txtCode)
		Me.Frame1.Controls.Add(Me.txtName)
		Me.Frame1.Controls.Add(Me.cmdProducts)
		Me.Frame1.Controls.Add(Me.Label5)
		Me.Frame1.Controls.Add(Me.Label4)
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.Location = New System.Drawing.Point(8, 32)
		Me.Frame1.Name = "Frame1"
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Size = New System.Drawing.Size(409, 65)
		Me.Frame1.TabIndex = 9
		Me.Frame1.Text = "Search product "
		Me.Frame1.Visible = True
		' 
		'txtCode
		' 
		Me.txtCode.AcceptsReturn = True
		Me.txtCode.AllowDrop = True
		Me.txtCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCode.Location = New System.Drawing.Point(112, 16)
		Me.txtCode.MaxLength = 0
		Me.txtCode.Name = "txtCode"
		Me.txtCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCode.Size = New System.Drawing.Size(97, 20)
		Me.txtCode.TabIndex = 0
		' 
		'txtName
		' 
		Me.txtName.AcceptsReturn = True
		Me.txtName.AllowDrop = True
		Me.txtName.BackColor = System.Drawing.SystemColors.Window
		Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtName.Location = New System.Drawing.Point(112, 40)
		Me.txtName.MaxLength = 0
		Me.txtName.Name = "txtName"
		Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtName.Size = New System.Drawing.Size(145, 20)
		Me.txtName.TabIndex = 1
		' 
		'cmdProducts
		' 
		Me.cmdProducts.AllowDrop = True
		Me.cmdProducts.BackColor = System.Drawing.SystemColors.Control
		Me.cmdProducts.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdProducts.Location = New System.Drawing.Point(360, 16)
		Me.cmdProducts.Name = "cmdProducts"
		Me.cmdProducts.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdProducts.Size = New System.Drawing.Size(25, 21)
		Me.cmdProducts.TabIndex = 10
		Me.cmdProducts.TabStop = False
		Me.cmdProducts.Text = "..."
		Me.cmdProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdProducts.UseVisualStyleBackColor = False
		' 
		'Label5
		' 
		Me.Label5.AllowDrop = True
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Location = New System.Drawing.Point(16, 16)
		Me.Label5.Name = "Label5"
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.Size = New System.Drawing.Size(89, 17)
		Me.Label5.TabIndex = 12
		Me.Label5.Text = "Code"
		' 
		'Label4
		' 
		Me.Label4.AllowDrop = True
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Location = New System.Drawing.Point(16, 40)
		Me.Label4.Name = "Label4"
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.Size = New System.Drawing.Size(89, 17)
		Me.Label4.TabIndex = 11
		Me.Label4.Text = "Name"
		' 
		'cmdClose
		' 
		Me.cmdClose.AllowDrop = True
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Location = New System.Drawing.Point(344, 504)
		Me.cmdClose.Name = "cmdClose"
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.Size = New System.Drawing.Size(73, 25)
		Me.cmdClose.TabIndex = 7
		Me.cmdClose.Text = "&Close"
		Me.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdClose.UseVisualStyleBackColor = False
		' 
		'cmdSave
		' 
		Me.cmdSave.AllowDrop = True
		Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSave.Location = New System.Drawing.Point(264, 504)
		Me.cmdSave.Name = "cmdSave"
		Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSave.Size = New System.Drawing.Size(73, 25)
		Me.cmdSave.TabIndex = 6
		Me.cmdSave.Text = "&Save"
		Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdSave.UseVisualStyleBackColor = False
		' 
		'lvProducts
		' 
		Me.lvProducts.AllowDrop = True
		Me.lvProducts.BackColor = System.Drawing.SystemColors.Window
		Me.lvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lvProducts.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lvProducts.FullRowSelect = True
		Me.lvProducts.GridLines = True
		Me.lvProducts.HideSelection = False
		Me.lvProducts.HotTracking = True
		Me.lvProducts.LabelEdit = False
		Me.lvProducts.Location = New System.Drawing.Point(8, 104)
		Me.lvProducts.MultiSelect = False
		Me.lvProducts.Name = "lvProducts"
		Me.lvProducts.Size = New System.Drawing.Size(409, 97)
		Me.lvProducts.TabIndex = 2
		Me.lvProducts.View = System.Windows.Forms.View.Details
		Me.lvProducts.Columns.Add(Me.lvProducts_ColumnHeader_1_)
		Me.lvProducts.Columns.Add(Me.lvProducts_ColumnHeader_2_)
		Me.lvProducts.Columns.Add(Me.lvProducts_ColumnHeader_3_)
		Me.lvProducts.Columns.Add(Me.lvProducts_ColumnHeader_4_)
		Me.lvProducts.Columns.Add(Me.lvProducts_ColumnHeader_5_)
		Me.lvProducts.Columns.Add(Me.lvProducts_ColumnHeader_6_)
		Me.lvProducts.Columns.Add(Me.lvProducts_ColumnHeader_7_)
		' 
		'lvProducts_ColumnHeader_1_
		' 
		Me.lvProducts_ColumnHeader_1_.Text = "Code"
		Me.lvProducts_ColumnHeader_1_.Width = 97
		' 
		'lvProducts_ColumnHeader_2_
		' 
		Me.lvProducts_ColumnHeader_2_.Text = "Name"
		Me.lvProducts_ColumnHeader_2_.Width = 97
		' 
		'lvProducts_ColumnHeader_3_
		' 
		Me.lvProducts_ColumnHeader_3_.Text = "Price"
		Me.lvProducts_ColumnHeader_3_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.lvProducts_ColumnHeader_3_.Width = 97
		' 
		'lvProducts_ColumnHeader_4_
		' 
		Me.lvProducts_ColumnHeader_4_.Text = "Existence"
		Me.lvProducts_ColumnHeader_4_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.lvProducts_ColumnHeader_4_.Width = 97
		' 
		'lvProducts_ColumnHeader_5_
		' 
		Me.lvProducts_ColumnHeader_5_.Text = "Ordered"
		Me.lvProducts_ColumnHeader_5_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.lvProducts_ColumnHeader_5_.Width = 97
		' 
		'lvProducts_ColumnHeader_6_
		' 
		Me.lvProducts_ColumnHeader_6_.Text = "Quantity per Unit"
		Me.lvProducts_ColumnHeader_6_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.lvProducts_ColumnHeader_6_.Width = 97
		' 
		'lvProducts_ColumnHeader_7_
		' 
		Me.lvProducts_ColumnHeader_7_.Text = "Unit"
		Me.lvProducts_ColumnHeader_7_.Width = 97
		' 
		'Label14
		' 
		Me.Label14.AllowDrop = True
		Me.Label14.BackColor = System.Drawing.SystemColors.Control
		Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label14.Location = New System.Drawing.Point(216, 472)
		Me.Label14.Name = "Label14"
		Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label14.Size = New System.Drawing.Size(89, 17)
		Me.Label14.TabIndex = 32
		Me.Label14.Text = "Adjusted quantity"
		' 
		'lblNewQuantity
		' 
		Me.lblNewQuantity.AllowDrop = True
		Me.lblNewQuantity.BackColor = System.Drawing.SystemColors.Control
		Me.lblNewQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNewQuantity.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNewQuantity.Location = New System.Drawing.Point(312, 472)
		Me.lblNewQuantity.Name = "lblNewQuantity"
		Me.lblNewQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNewQuantity.Size = New System.Drawing.Size(89, 17)
		Me.lblNewQuantity.TabIndex = 31
		' 
		'Label12
		' 
		Me.Label12.AllowDrop = True
		Me.Label12.BackColor = System.Drawing.SystemColors.Control
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label12.Location = New System.Drawing.Point(16, 472)
		Me.Label12.Name = "Label12"
		Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label12.Size = New System.Drawing.Size(89, 17)
		Me.Label12.TabIndex = 30
		Me.Label12.Text = "Stock quantity"
		' 
		'lblCurrentQuantity
		' 
		Me.lblCurrentQuantity.AllowDrop = True
		Me.lblCurrentQuantity.BackColor = System.Drawing.SystemColors.Control
		Me.lblCurrentQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCurrentQuantity.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCurrentQuantity.Location = New System.Drawing.Point(112, 472)
		Me.lblCurrentQuantity.Name = "lblCurrentQuantity"
		Me.lblCurrentQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCurrentQuantity.Size = New System.Drawing.Size(89, 17)
		Me.lblCurrentQuantity.TabIndex = 29
		' 
		'Label11
		' 
		Me.Label11.AllowDrop = True
		Me.Label11.BackColor = System.Drawing.SystemColors.Control
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label11.Location = New System.Drawing.Point(16, 376)
		Me.Label11.Name = "Label11"
		Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label11.Size = New System.Drawing.Size(65, 17)
		Me.Label11.TabIndex = 27
		Me.Label11.Text = "Stock ID:"
		' 
		'Label10
		' 
		Me.Label10.AllowDrop = True
		Me.Label10.BackColor = System.Drawing.SystemColors.Control
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label10.Location = New System.Drawing.Point(216, 376)
		Me.Label10.Name = "Label10"
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.Size = New System.Drawing.Size(73, 17)
		Me.Label10.TabIndex = 24
		Me.Label10.Text = "Quantity"
		' 
		'Label8
		' 
		Me.Label8.AllowDrop = True
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Location = New System.Drawing.Point(16, 344)
		Me.Label8.Name = "Label8"
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.Size = New System.Drawing.Size(89, 17)
		Me.Label8.TabIndex = 23
		Me.Label8.Text = "Product"
		' 
		'Label9
		' 
		Me.Label9.AllowDrop = True
		Me.Label9.BackColor = System.Drawing.SystemColors.Control
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Location = New System.Drawing.Point(272, 344)
		Me.Label9.Name = "Label9"
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.Size = New System.Drawing.Size(41, 17)
		Me.Label9.TabIndex = 22
		Me.Label9.Text = "Unit"
		' 
		'Label7
		' 
		Me.Label7.AllowDrop = True
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Location = New System.Drawing.Point(216, 435)
		Me.Label7.Name = "Label7"
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.Size = New System.Drawing.Size(89, 17)
		Me.Label7.TabIndex = 18
		Me.Label7.Text = "New Quantity"
		' 
		'Label6
		' 
		Me.Label6.AllowDrop = True
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Location = New System.Drawing.Point(216, 406)
		Me.Label6.Name = "Label6"
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.Size = New System.Drawing.Size(73, 17)
		Me.Label6.TabIndex = 17
		Me.Label6.Text = "New Price"
		' 
		'Label2
		' 
		Me.Label2.AllowDrop = True
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Location = New System.Drawing.Point(16, 435)
		Me.Label2.Name = "Label2"
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.Size = New System.Drawing.Size(81, 17)
		Me.Label2.TabIndex = 16
		Me.Label2.Text = "Quantity"
		' 
		'Label1
		' 
		Me.Label1.AllowDrop = True
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Location = New System.Drawing.Point(16, 406)
		Me.Label1.Name = "Label1"
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.Size = New System.Drawing.Size(73, 17)
		Me.Label1.TabIndex = 15
		Me.Label1.Text = "Old Price"
		' 
		'Label3
		' 
		Me.Label3.AllowDrop = True
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Location = New System.Drawing.Point(16, 8)
		Me.Label3.Name = "Label3"
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.Size = New System.Drawing.Size(121, 17)
		Me.Label3.TabIndex = 8
		Me.Label3.Text = "Select a product first"
		' 
		'frmAdjustStockManual
		' 
		Me.AllowDrop = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6, 13)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScroll = True
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(426, 563)
		Me.Controls.Add(Me.sbStatusBar)
		Me.Controls.Add(Me.txtStockID)
		Me.Controls.Add(Me.txtOriginalPrice)
		Me.Controls.Add(Me._txtValues_0)
		Me.Controls.Add(Me.txtQuantityPerUnit)
		Me.Controls.Add(Me.txtProductName)
		Me.Controls.Add(Me.txtUnit)
		Me.Controls.Add(Me._txtValues_1)
		Me.Controls.Add(Me.txtOriginalQuantity)
		Me.Controls.Add(Me.Frame3)
		Me.Controls.Add(Me.Frame1)
		Me.Controls.Add(Me.cmdClose)
		Me.Controls.Add(Me.cmdSave)
		Me.Controls.Add(Me.lvProducts)
		Me.Controls.Add(Me.Label14)
		Me.Controls.Add(Me.lblNewQuantity)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.lblCurrentQuantity)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Label3)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Location = New System.Drawing.Point(3, 25)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmAdjustStockManual"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Inventory Adjust"
		Me.listViewHelper1.SetItemClickMethod(Me.lvStocks, "lvStocks_ItemClick")
		Me.listViewHelper1.SetCorrectEventsBehavior(Me.lvStocks, True)
		Me.listViewHelper1.SetItemClickMethod(Me.lvProducts, "lvProducts_ItemClick")
		Me.listViewHelper1.SetCorrectEventsBehavior(Me.lvProducts, True)
		Me.listViewHelper1.EndInit()
		Me.sbStatusBar.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.lvStocks.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.lvProducts.ResumeLayout(False)
		Me.ResumeLayout(False)
	End Sub
	Sub ReLoadForm(ByVal addEvents As Boolean)
		InitializetxtValues()
		'This form is an MDI child.
		'This code simulates the VB6 
		' functionality of automatically
		' loading and showing an MDI
		' child's parent.
		Me.MdiParent = SKS.frmMain.DefInstance
		SKS.frmMain.DefInstance.Show()
		If addEvents Then
			AddHandler MyBase.FormClosing, AddressOf Me.Form_FormClosing
			AddHandler MyBase.Closed, AddressOf Me.Form_Closed
			AddHandler Me.Activated, AddressOf Me.frmAdjustStockManual_Activated
		End If
	End Sub
	Sub InitializetxtValues()
		ReDim txtValues(1)
		Me.txtValues(0) = _txtValues_0
		Me.txtValues(1) = _txtValues_1
	End Sub
#End Region
End Class