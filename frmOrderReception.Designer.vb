<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderReception
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmOrderReception
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmOrderReception
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmOrderReception)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmOrderReception
		Dim theInstance As New frmOrderReception()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "txtNotes", "txtSubTotal", "txtTotal", "txtTotalTax", "txtFreightCharge", "txtSalesTax", "txtEntry", "fgProducts", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdSave", "cmdClose", "cmdAddProducts", "txtProviderName", "txtContactLastName", "txtContactName", "cmdProviders", "lvProviders_ColumnHeader_1_", "lvProviders_ColumnHeader_2_", "lvProviders_ColumnHeader_3_", "lvProviders_ColumnHeader_4_", "lvProviders_ColumnHeader_5_", "lvProviders_ColumnHeader_6_", "lvProviders_ColumnHeader_7_", "lvProviders", "Label3", "Label4", "Label2", "Frame1", "txtProviderContact", "txtProviderCompany", "Label5", "Label1", "Frame2", "Label7", "Label12", "Label11", "Label10", "Label9", "Label8", "Label6", "listViewHelper1"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents txtNotes As System.Windows.Forms.TextBox
	Public WithEvents txtSubTotal As System.Windows.Forms.TextBox
	Public WithEvents txtTotal As System.Windows.Forms.TextBox
	Public WithEvents txtTotalTax As System.Windows.Forms.TextBox
	Public WithEvents txtFreightCharge As System.Windows.Forms.TextBox
	Public WithEvents txtSalesTax As System.Windows.Forms.TextBox
	Public WithEvents txtEntry As System.Windows.Forms.TextBox
	Public WithEvents fgProducts As UpgradeHelpers.DataGridViewFlex
	Public WithEvents sbStatusBar_Panels_Panel1 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents sbStatusBar As System.Windows.Forms.StatusStrip
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents cmdAddProducts As System.Windows.Forms.Button
	Public WithEvents txtProviderName As System.Windows.Forms.TextBox
	Public WithEvents txtContactLastName As System.Windows.Forms.TextBox
	Public WithEvents txtContactName As System.Windows.Forms.TextBox
	Public WithEvents cmdProviders As System.Windows.Forms.Button
	Public WithEvents lvProviders_ColumnHeader_1_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProviders_ColumnHeader_2_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProviders_ColumnHeader_3_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProviders_ColumnHeader_4_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProviders_ColumnHeader_5_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProviders_ColumnHeader_6_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProviders_ColumnHeader_7_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProviders As System.Windows.Forms.ListView
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents txtProviderContact As System.Windows.Forms.TextBox
	Public WithEvents txtProviderCompany As System.Windows.Forms.TextBox
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public listViewHelper1 As UpgradeHelpers.Gui.ListViewHelper
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmOrderReception))
		Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
		Me.txtNotes = New System.Windows.Forms.TextBox()
		Me.txtSubTotal = New System.Windows.Forms.TextBox()
		Me.txtTotal = New System.Windows.Forms.TextBox()
		Me.txtTotalTax = New System.Windows.Forms.TextBox()
		Me.txtFreightCharge = New System.Windows.Forms.TextBox()
		Me.txtSalesTax = New System.Windows.Forms.TextBox()
		Me.txtEntry = New System.Windows.Forms.TextBox()
		Me.fgProducts = New UpgradeHelpers.DataGridViewFlex(Me.components)
		Me.sbStatusBar = New System.Windows.Forms.StatusStrip()
		Me.sbStatusBar_Panels_Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.cmdSave = New System.Windows.Forms.Button()
		Me.cmdClose = New System.Windows.Forms.Button()
		Me.cmdAddProducts = New System.Windows.Forms.Button()
		Me.Frame1 = New System.Windows.Forms.GroupBox()
		Me.txtProviderName = New System.Windows.Forms.TextBox()
		Me.txtContactLastName = New System.Windows.Forms.TextBox()
		Me.txtContactName = New System.Windows.Forms.TextBox()
		Me.cmdProviders = New System.Windows.Forms.Button()
		Me.lvProviders = New System.Windows.Forms.ListView()
		Me.lvProviders_ColumnHeader_1_ = New System.Windows.Forms.ColumnHeader()
		Me.lvProviders_ColumnHeader_2_ = New System.Windows.Forms.ColumnHeader()
		Me.lvProviders_ColumnHeader_3_ = New System.Windows.Forms.ColumnHeader()
		Me.lvProviders_ColumnHeader_4_ = New System.Windows.Forms.ColumnHeader()
		Me.lvProviders_ColumnHeader_5_ = New System.Windows.Forms.ColumnHeader()
		Me.lvProviders_ColumnHeader_6_ = New System.Windows.Forms.ColumnHeader()
		Me.lvProviders_ColumnHeader_7_ = New System.Windows.Forms.ColumnHeader()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Frame2 = New System.Windows.Forms.GroupBox()
		Me.txtProviderContact = New System.Windows.Forms.TextBox()
		Me.txtProviderCompany = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.sbStatusBar.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.lvProviders.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.SuspendLayout()
		Me.listViewHelper1 = New UpgradeHelpers.Gui.ListViewHelper(Me.components)
		Me.listViewHelper1.BeginInit()
		' 
		'txtNotes
		' 
		Me.txtNotes.AcceptsReturn = True
		Me.txtNotes.AllowDrop = True
		Me.txtNotes.BackColor = System.Drawing.SystemColors.Window
		Me.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNotes.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNotes.Location = New System.Drawing.Point(56, 240)
		Me.txtNotes.MaxLength = 0
		Me.txtNotes.Multiline = True
		Me.txtNotes.Name = "txtNotes"
		Me.txtNotes.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNotes.Size = New System.Drawing.Size(425, 44)
		Me.txtNotes.TabIndex = 4
		' 
		'txtSubTotal
		' 
		Me.txtSubTotal.AcceptsReturn = True
		Me.txtSubTotal.AllowDrop = True
		Me.txtSubTotal.BackColor = System.Drawing.SystemColors.Menu
		Me.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSubTotal.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSubTotal.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSubTotal.Location = New System.Drawing.Point(352, 536)
		Me.txtSubTotal.MaxLength = 0
		Me.txtSubTotal.Name = "txtSubTotal"
		Me.txtSubTotal.ReadOnly = True
		Me.txtSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSubTotal.Size = New System.Drawing.Size(145, 20)
		Me.txtSubTotal.TabIndex = 31
		Me.txtSubTotal.TabStop = False
		Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		' 
		'txtTotal
		' 
		Me.txtTotal.AcceptsReturn = True
		Me.txtTotal.AllowDrop = True
		Me.txtTotal.BackColor = System.Drawing.SystemColors.Menu
		Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTotal.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTotal.Location = New System.Drawing.Point(88, 560)
		Me.txtTotal.MaxLength = 0
		Me.txtTotal.Name = "txtTotal"
		Me.txtTotal.ReadOnly = True
		Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTotal.Size = New System.Drawing.Size(145, 20)
		Me.txtTotal.TabIndex = 29
		Me.txtTotal.TabStop = False
		Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		' 
		'txtTotalTax
		' 
		Me.txtTotalTax.AcceptsReturn = True
		Me.txtTotalTax.AllowDrop = True
		Me.txtTotalTax.BackColor = System.Drawing.SystemColors.Menu
		Me.txtTotalTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTotalTax.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTotalTax.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTotalTax.Location = New System.Drawing.Point(352, 512)
		Me.txtTotalTax.MaxLength = 0
		Me.txtTotalTax.Name = "txtTotalTax"
		Me.txtTotalTax.ReadOnly = True
		Me.txtTotalTax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTotalTax.Size = New System.Drawing.Size(145, 20)
		Me.txtTotalTax.TabIndex = 27
		Me.txtTotalTax.TabStop = False
		Me.txtTotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		' 
		'txtFreightCharge
		' 
		Me.txtFreightCharge.AcceptsReturn = True
		Me.txtFreightCharge.AllowDrop = True
		Me.txtFreightCharge.BackColor = System.Drawing.SystemColors.Window
		Me.txtFreightCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtFreightCharge.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtFreightCharge.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtFreightCharge.Location = New System.Drawing.Point(88, 536)
		Me.txtFreightCharge.MaxLength = 0
		Me.txtFreightCharge.Name = "txtFreightCharge"
		Me.txtFreightCharge.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtFreightCharge.Size = New System.Drawing.Size(145, 20)
		Me.txtFreightCharge.TabIndex = 7
		Me.txtFreightCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		' 
		'txtSalesTax
		' 
		Me.txtSalesTax.AcceptsReturn = True
		Me.txtSalesTax.AllowDrop = True
		Me.txtSalesTax.BackColor = System.Drawing.SystemColors.Window
		Me.txtSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSalesTax.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSalesTax.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSalesTax.Location = New System.Drawing.Point(88, 512)
		Me.txtSalesTax.MaxLength = 0
		Me.txtSalesTax.Name = "txtSalesTax"
		Me.txtSalesTax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSalesTax.Size = New System.Drawing.Size(145, 20)
		Me.txtSalesTax.TabIndex = 6
		Me.txtSalesTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		' 
		'txtEntry
		' 
		Me.txtEntry.AcceptsReturn = True
		Me.txtEntry.AllowDrop = True
		Me.txtEntry.BackColor = System.Drawing.SystemColors.Window
		Me.txtEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtEntry.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtEntry.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtEntry.Location = New System.Drawing.Point(88, 488)
		Me.txtEntry.MaxLength = 0
		Me.txtEntry.Name = "txtEntry"
		Me.txtEntry.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtEntry.Size = New System.Drawing.Size(145, 19)
		Me.txtEntry.TabIndex = 24
		Me.txtEntry.Visible = False
		' 
		'fgProducts
		' 
		Me.fgProducts.AllowDrop = True
		Me.fgProducts.AllowUserToAddRows = False
		Me.fgProducts.AllowUserToDeleteRows = False
		Me.fgProducts.AllowUserToResizeColumns = False
		Me.fgProducts.AllowUserToResizeRows = False
		Me.fgProducts.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.fgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.fgProducts.ColumnsCount = 0
		Me.fgProducts.FixedColumns = 0
		Me.fgProducts.FixedRows = 0
		Me.fgProducts.Location = New System.Drawing.Point(8, 288)
		Me.fgProducts.Name = "fgProducts"
		Me.fgProducts.ReadOnly = True
		Me.fgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
		Me.fgProducts.ShowCellToolTips = False
		Me.fgProducts.Size = New System.Drawing.Size(505, 177)
		Me.fgProducts.StandardTab = True
		Me.fgProducts.TabIndex = 5
		' 
		'sbStatusBar
		' 
		Me.sbStatusBar.AllowDrop = True
		Me.sbStatusBar.BackColor = System.Drawing.SystemColors.Control
		Me.sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.sbStatusBar.Location = New System.Drawing.Point(0, 623)
		Me.sbStatusBar.Name = "sbStatusBar"
		Me.sbStatusBar.ShowItemToolTips = True
		Me.sbStatusBar.Size = New System.Drawing.Size(521, 25)
		Me.sbStatusBar.TabIndex = 23
		Me.sbStatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbStatusBar_Panels_Panel1})
		' 
		'sbStatusBar_Panels_Panel1
		' 
		Me.sbStatusBar_Panels_Panel1.BorderSides = CType(System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom, System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.sbStatusBar_Panels_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.sbStatusBar_Panels_Panel1.DoubleClickEnabled = True
		Me.sbStatusBar_Panels_Panel1.Margin = New System.Windows.Forms.Padding(0)
		Me.sbStatusBar_Panels_Panel1.Size = New System.Drawing.Size(521, 25)
		Me.sbStatusBar_Panels_Panel1.Spring = True
		Me.sbStatusBar_Panels_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.sbStatusBar_Panels_Panel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		' 
		'cmdSave
		' 
		Me.cmdSave.AllowDrop = True
		Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSave.Location = New System.Drawing.Point(320, 584)
		Me.cmdSave.Name = "cmdSave"
		Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSave.Size = New System.Drawing.Size(89, 25)
		Me.cmdSave.TabIndex = 8
		Me.cmdSave.Text = "&Save"
		Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdSave.UseVisualStyleBackColor = False
		' 
		'cmdClose
		' 
		Me.cmdClose.AllowDrop = True
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Location = New System.Drawing.Point(424, 584)
		Me.cmdClose.Name = "cmdClose"
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.Size = New System.Drawing.Size(89, 25)
		Me.cmdClose.TabIndex = 9
		Me.cmdClose.Text = "&Close"
		Me.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdClose.UseVisualStyleBackColor = False
		' 
		'cmdAddProducts
		' 
		Me.cmdAddProducts.AllowDrop = True
		Me.cmdAddProducts.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAddProducts.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAddProducts.Location = New System.Drawing.Point(488, 264)
		Me.cmdAddProducts.Name = "cmdAddProducts"
		Me.cmdAddProducts.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAddProducts.Size = New System.Drawing.Size(25, 21)
		Me.cmdAddProducts.TabIndex = 21
		Me.cmdAddProducts.TabStop = False
		Me.cmdAddProducts.Text = "..."
		Me.cmdAddProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdAddProducts.UseVisualStyleBackColor = False
		' 
		'Frame1
		' 
		Me.Frame1.AllowDrop = True
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Controls.Add(Me.txtProviderName)
		Me.Frame1.Controls.Add(Me.txtContactLastName)
		Me.Frame1.Controls.Add(Me.txtContactName)
		Me.Frame1.Controls.Add(Me.cmdProviders)
		Me.Frame1.Controls.Add(Me.lvProviders)
		Me.Frame1.Controls.Add(Me.Label3)
		Me.Frame1.Controls.Add(Me.Label4)
		Me.Frame1.Controls.Add(Me.Label2)
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.Location = New System.Drawing.Point(8, 8)
		Me.Frame1.Name = "Frame1"
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Size = New System.Drawing.Size(505, 169)
		Me.Frame1.TabIndex = 12
		Me.Frame1.Text = "Search supplier"
		Me.Frame1.Visible = True
		' 
		'txtProviderName
		' 
		Me.txtProviderName.AcceptsReturn = True
		Me.txtProviderName.AllowDrop = True
		Me.txtProviderName.BackColor = System.Drawing.SystemColors.Window
		Me.txtProviderName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtProviderName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtProviderName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtProviderName.Location = New System.Drawing.Point(88, 16)
		Me.txtProviderName.MaxLength = 0
		Me.txtProviderName.Name = "txtProviderName"
		Me.txtProviderName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtProviderName.Size = New System.Drawing.Size(145, 20)
		Me.txtProviderName.TabIndex = 0
		' 
		'txtContactLastName
		' 
		Me.txtContactLastName.AcceptsReturn = True
		Me.txtContactLastName.AllowDrop = True
		Me.txtContactLastName.BackColor = System.Drawing.SystemColors.Window
		Me.txtContactLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtContactLastName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtContactLastName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtContactLastName.Location = New System.Drawing.Point(336, 48)
		Me.txtContactLastName.MaxLength = 0
		Me.txtContactLastName.Name = "txtContactLastName"
		Me.txtContactLastName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtContactLastName.Size = New System.Drawing.Size(145, 20)
		Me.txtContactLastName.TabIndex = 2
		' 
		'txtContactName
		' 
		Me.txtContactName.AcceptsReturn = True
		Me.txtContactName.AllowDrop = True
		Me.txtContactName.BackColor = System.Drawing.SystemColors.Window
		Me.txtContactName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtContactName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtContactName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtContactName.Location = New System.Drawing.Point(88, 48)
		Me.txtContactName.MaxLength = 0
		Me.txtContactName.Name = "txtContactName"
		Me.txtContactName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtContactName.Size = New System.Drawing.Size(145, 20)
		Me.txtContactName.TabIndex = 1
		' 
		'cmdProviders
		' 
		Me.cmdProviders.AllowDrop = True
		Me.cmdProviders.BackColor = System.Drawing.SystemColors.Control
		Me.cmdProviders.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdProviders.Location = New System.Drawing.Point(456, 16)
		Me.cmdProviders.Name = "cmdProviders"
		Me.cmdProviders.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdProviders.Size = New System.Drawing.Size(25, 21)
		Me.cmdProviders.TabIndex = 13
		Me.cmdProviders.TabStop = False
		Me.cmdProviders.Text = "..."
		Me.cmdProviders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdProviders.UseVisualStyleBackColor = False
		' 
		'lvProviders
		' 
		Me.lvProviders.AllowDrop = True
		Me.lvProviders.BackColor = System.Drawing.SystemColors.Window
		Me.lvProviders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lvProviders.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lvProviders.FullRowSelect = True
		Me.lvProviders.GridLines = True
		Me.lvProviders.HideSelection = False
		Me.lvProviders.HotTracking = True
		Me.lvProviders.LabelEdit = False
		Me.lvProviders.Location = New System.Drawing.Point(8, 80)
		Me.lvProviders.MultiSelect = False
		Me.lvProviders.Name = "lvProviders"
		Me.lvProviders.Size = New System.Drawing.Size(489, 81)
		Me.lvProviders.TabIndex = 3
		Me.lvProviders.View = System.Windows.Forms.View.Details
		Me.lvProviders.Columns.Add(Me.lvProviders_ColumnHeader_1_)
		Me.lvProviders.Columns.Add(Me.lvProviders_ColumnHeader_2_)
		Me.lvProviders.Columns.Add(Me.lvProviders_ColumnHeader_3_)
		Me.lvProviders.Columns.Add(Me.lvProviders_ColumnHeader_4_)
		Me.lvProviders.Columns.Add(Me.lvProviders_ColumnHeader_5_)
		Me.lvProviders.Columns.Add(Me.lvProviders_ColumnHeader_6_)
		Me.lvProviders.Columns.Add(Me.lvProviders_ColumnHeader_7_)
		' 
		'lvProviders_ColumnHeader_1_
		' 
		Me.lvProviders_ColumnHeader_1_.Text = "Supplier ID"
		Me.lvProviders_ColumnHeader_1_.Width = 97
		' 
		'lvProviders_ColumnHeader_2_
		' 
		Me.lvProviders_ColumnHeader_2_.Text = "Supplier Name"
		Me.lvProviders_ColumnHeader_2_.Width = 97
		' 
		'lvProviders_ColumnHeader_3_
		' 
		Me.lvProviders_ColumnHeader_3_.Text = "Contact Name"
		Me.lvProviders_ColumnHeader_3_.Width = 97
		' 
		'lvProviders_ColumnHeader_4_
		' 
		Me.lvProviders_ColumnHeader_4_.Text = "Contact Last Name"
		Me.lvProviders_ColumnHeader_4_.Width = 97
		' 
		'lvProviders_ColumnHeader_5_
		' 
		Me.lvProviders_ColumnHeader_5_.Text = "City"
		Me.lvProviders_ColumnHeader_5_.Width = 97
		' 
		'lvProviders_ColumnHeader_6_
		' 
		Me.lvProviders_ColumnHeader_6_.Text = "State"
		Me.lvProviders_ColumnHeader_6_.Width = 97
		' 
		'lvProviders_ColumnHeader_7_
		' 
		Me.lvProviders_ColumnHeader_7_.Text = "Country"
		Me.lvProviders_ColumnHeader_7_.Width = 97
		' 
		'Label3
		' 
		Me.Label3.AllowDrop = True
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Location = New System.Drawing.Point(240, 48)
		Me.Label3.Name = "Label3"
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.Size = New System.Drawing.Size(97, 17)
		Me.Label3.TabIndex = 16
		Me.Label3.Text = "Last name"
		' 
		'Label4
		' 
		Me.Label4.AllowDrop = True
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Location = New System.Drawing.Point(8, 16)
		Me.Label4.Name = "Label4"
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.Size = New System.Drawing.Size(89, 17)
		Me.Label4.TabIndex = 15
		Me.Label4.Text = "Supplier"
		' 
		'Label2
		' 
		Me.Label2.AllowDrop = True
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Location = New System.Drawing.Point(8, 48)
		Me.Label2.Name = "Label2"
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.Size = New System.Drawing.Size(89, 17)
		Me.Label2.TabIndex = 14
		Me.Label2.Text = "First Name"
		' 
		'Frame2
		' 
		Me.Frame2.AllowDrop = True
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Controls.Add(Me.txtProviderContact)
		Me.Frame2.Controls.Add(Me.txtProviderCompany)
		Me.Frame2.Controls.Add(Me.Label5)
		Me.Frame2.Controls.Add(Me.Label1)
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.Location = New System.Drawing.Point(8, 184)
		Me.Frame2.Name = "Frame2"
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Size = New System.Drawing.Size(505, 49)
		Me.Frame2.TabIndex = 11
		Me.Frame2.Text = "Supplier"
		Me.Frame2.Visible = True
		' 
		'txtProviderContact
		' 
		Me.txtProviderContact.AcceptsReturn = True
		Me.txtProviderContact.AllowDrop = True
		Me.txtProviderContact.BackColor = System.Drawing.SystemColors.Menu
		Me.txtProviderContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtProviderContact.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtProviderContact.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtProviderContact.Location = New System.Drawing.Point(288, 16)
		Me.txtProviderContact.MaxLength = 0
		Me.txtProviderContact.Name = "txtProviderContact"
		Me.txtProviderContact.ReadOnly = True
		Me.txtProviderContact.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtProviderContact.Size = New System.Drawing.Size(209, 20)
		Me.txtProviderContact.TabIndex = 20
		Me.txtProviderContact.TabStop = False
		' 
		'txtProviderCompany
		' 
		Me.txtProviderCompany.AcceptsReturn = True
		Me.txtProviderCompany.AllowDrop = True
		Me.txtProviderCompany.BackColor = System.Drawing.SystemColors.Menu
		Me.txtProviderCompany.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtProviderCompany.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtProviderCompany.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtProviderCompany.Location = New System.Drawing.Point(72, 16)
		Me.txtProviderCompany.MaxLength = 0
		Me.txtProviderCompany.Name = "txtProviderCompany"
		Me.txtProviderCompany.ReadOnly = True
		Me.txtProviderCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtProviderCompany.Size = New System.Drawing.Size(145, 20)
		Me.txtProviderCompany.TabIndex = 19
		Me.txtProviderCompany.TabStop = False
		' 
		'Label5
		' 
		Me.Label5.AllowDrop = True
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Location = New System.Drawing.Point(8, 16)
		Me.Label5.Name = "Label5"
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.Size = New System.Drawing.Size(57, 17)
		Me.Label5.TabIndex = 18
		Me.Label5.Text = "Name:"
		' 
		'Label1
		' 
		Me.Label1.AllowDrop = True
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Location = New System.Drawing.Point(232, 16)
		Me.Label1.Name = "Label1"
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.Size = New System.Drawing.Size(57, 17)
		Me.Label1.TabIndex = 17
		Me.Label1.Text = "Contact:"
		' 
		'Label7
		' 
		Me.Label7.AllowDrop = True
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Location = New System.Drawing.Point(8, 488)
		Me.Label7.Name = "Label7"
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.Size = New System.Drawing.Size(81, 17)
		Me.Label7.TabIndex = 10
		Me.Label7.Text = "Quantity"
		' 
		'Label12
		' 
		Me.Label12.AllowDrop = True
		Me.Label12.BackColor = System.Drawing.SystemColors.Control
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label12.Location = New System.Drawing.Point(8, 536)
		Me.Label12.Name = "Label12"
		Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label12.Size = New System.Drawing.Size(89, 17)
		Me.Label12.TabIndex = 32
		Me.Label12.Text = "Freight"
		' 
		'Label11
		' 
		Me.Label11.AllowDrop = True
		Me.Label11.BackColor = System.Drawing.SystemColors.Control
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label11.Location = New System.Drawing.Point(8, 560)
		Me.Label11.Name = "Label11"
		Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label11.Size = New System.Drawing.Size(89, 17)
		Me.Label11.TabIndex = 30
		Me.Label11.Text = "Total"
		' 
		'Label10
		' 
		Me.Label10.AllowDrop = True
		Me.Label10.BackColor = System.Drawing.SystemColors.Control
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label10.Location = New System.Drawing.Point(272, 512)
		Me.Label10.Name = "Label10"
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.Size = New System.Drawing.Size(89, 17)
		Me.Label10.TabIndex = 28
		Me.Label10.Text = "Total Tax"
		' 
		'Label9
		' 
		Me.Label9.AllowDrop = True
		Me.Label9.BackColor = System.Drawing.SystemColors.Control
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Location = New System.Drawing.Point(272, 536)
		Me.Label9.Name = "Label9"
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.Size = New System.Drawing.Size(89, 17)
		Me.Label9.TabIndex = 26
		Me.Label9.Text = "Sub Total"
		' 
		'Label8
		' 
		Me.Label8.AllowDrop = True
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Location = New System.Drawing.Point(8, 512)
		Me.Label8.Name = "Label8"
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.Size = New System.Drawing.Size(89, 17)
		Me.Label8.TabIndex = 25
		Me.Label8.Text = "Sales Tax"
		' 
		'Label6
		' 
		Me.Label6.AllowDrop = True
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Location = New System.Drawing.Point(8, 248)
		Me.Label6.Name = "Label6"
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.Size = New System.Drawing.Size(33, 17)
		Me.Label6.TabIndex = 22
		Me.Label6.Text = "Notes:"
		' 
		'frmOrderReception
		' 
		Me.AllowDrop = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6, 13)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScroll = True
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(521, 648)
		Me.Controls.Add(Me.txtNotes)
		Me.Controls.Add(Me.txtSubTotal)
		Me.Controls.Add(Me.txtTotal)
		Me.Controls.Add(Me.txtTotalTax)
		Me.Controls.Add(Me.txtFreightCharge)
		Me.Controls.Add(Me.txtSalesTax)
		Me.Controls.Add(Me.txtEntry)
		Me.Controls.Add(Me.fgProducts)
		Me.Controls.Add(Me.sbStatusBar)
		Me.Controls.Add(Me.cmdSave)
		Me.Controls.Add(Me.cmdClose)
		Me.Controls.Add(Me.cmdAddProducts)
		Me.Controls.Add(Me.Frame1)
		Me.Controls.Add(Me.Frame2)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label6)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Location = New System.Drawing.Point(3, 25)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmOrderReception"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Add Stock Order"
		Me.listViewHelper1.SetItemClickMethod(Me.lvProviders, "lvProviders_ItemClick")
		Me.listViewHelper1.SetCorrectEventsBehavior(Me.lvProviders, True)
		Me.listViewHelper1.EndInit()
		Me.sbStatusBar.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.lvProviders.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.ResumeLayout(False)
	End Sub
	Sub ReLoadForm(ByVal addEvents As Boolean)
		Form_Load()
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
			AddHandler Me.Activated, AddressOf Me.frmOrderReception_Activated
		End If
	End Sub
#End Region
End Class