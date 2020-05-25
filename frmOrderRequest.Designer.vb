<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderRequest
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmOrderRequest
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmOrderRequest
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmOrderRequest)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmOrderRequest
		Dim theInstance As New frmOrderRequest()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "txtSubTotal", "txtTotal", "txtTotalTax", "txtFreightCharge", "txtSalesTax", "txtEntry", "fgProducts", "sbStatusBar_Panels_Panel1", "sbStatusBar", "dtRequired", "cmdSave", "cmdAddProducts", "cmdClose", "txtContactLastName", "txtContactName", "cmdCustomers", "txtCompanyName", "lvCustomers_ColumnHeader_1_", "lvCustomers_ColumnHeader_2_", "lvCustomers_ColumnHeader_3_", "lvCustomers_ColumnHeader_4_", "lvCustomers_ColumnHeader_5_", "lvCustomers_ColumnHeader_6_", "lvCustomers_ColumnHeader_7_", "lvCustomers", "Label3", "Label4", "Label2", "Frame1", "txtCustomerContact", "txtCustomerCompany", "Label5", "Label1", "Frame2", "dtPromised", "Label13", "Label12", "Label11", "Label10", "Label9", "Label8", "Label7", "Label6", "listViewHelper1"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents txtSubTotal As System.Windows.Forms.TextBox
	Public WithEvents txtTotal As System.Windows.Forms.TextBox
	Public WithEvents txtTotalTax As System.Windows.Forms.TextBox
	Public WithEvents txtFreightCharge As System.Windows.Forms.TextBox
	Public WithEvents txtSalesTax As System.Windows.Forms.TextBox
	Public WithEvents txtEntry As System.Windows.Forms.TextBox
	Public WithEvents fgProducts As UpgradeHelpers.DataGridViewFlex
	Public WithEvents sbStatusBar_Panels_Panel1 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents sbStatusBar As System.Windows.Forms.StatusStrip
	Public WithEvents dtRequired As System.Windows.Forms.DateTimePicker
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents cmdAddProducts As System.Windows.Forms.Button
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents txtContactLastName As System.Windows.Forms.TextBox
	Public WithEvents txtContactName As System.Windows.Forms.TextBox
	Public WithEvents cmdCustomers As System.Windows.Forms.Button
	Public WithEvents txtCompanyName As System.Windows.Forms.TextBox
	Public WithEvents lvCustomers_ColumnHeader_1_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvCustomers_ColumnHeader_2_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvCustomers_ColumnHeader_3_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvCustomers_ColumnHeader_4_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvCustomers_ColumnHeader_5_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvCustomers_ColumnHeader_6_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvCustomers_ColumnHeader_7_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvCustomers As System.Windows.Forms.ListView
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents txtCustomerContact As System.Windows.Forms.TextBox
	Public WithEvents txtCustomerCompany As System.Windows.Forms.TextBox
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents dtPromised As System.Windows.Forms.DateTimePicker
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public listViewHelper1 As UpgradeHelpers.Gui.ListViewHelper
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmOrderRequest))
		Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
		Me.txtSubTotal = New System.Windows.Forms.TextBox()
		Me.txtTotal = New System.Windows.Forms.TextBox()
		Me.txtTotalTax = New System.Windows.Forms.TextBox()
		Me.txtFreightCharge = New System.Windows.Forms.TextBox()
		Me.txtSalesTax = New System.Windows.Forms.TextBox()
		Me.txtEntry = New System.Windows.Forms.TextBox()
		Me.fgProducts = New UpgradeHelpers.DataGridViewFlex(Me.components)
		Me.sbStatusBar = New System.Windows.Forms.StatusStrip()
		Me.sbStatusBar_Panels_Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.dtRequired = New System.Windows.Forms.DateTimePicker()
		Me.cmdSave = New System.Windows.Forms.Button()
		Me.cmdAddProducts = New System.Windows.Forms.Button()
		Me.cmdClose = New System.Windows.Forms.Button()
		Me.Frame1 = New System.Windows.Forms.GroupBox()
		Me.txtContactLastName = New System.Windows.Forms.TextBox()
		Me.txtContactName = New System.Windows.Forms.TextBox()
		Me.cmdCustomers = New System.Windows.Forms.Button()
		Me.txtCompanyName = New System.Windows.Forms.TextBox()
		Me.lvCustomers = New System.Windows.Forms.ListView()
		Me.lvCustomers_ColumnHeader_1_ = New System.Windows.Forms.ColumnHeader()
		Me.lvCustomers_ColumnHeader_2_ = New System.Windows.Forms.ColumnHeader()
		Me.lvCustomers_ColumnHeader_3_ = New System.Windows.Forms.ColumnHeader()
		Me.lvCustomers_ColumnHeader_4_ = New System.Windows.Forms.ColumnHeader()
		Me.lvCustomers_ColumnHeader_5_ = New System.Windows.Forms.ColumnHeader()
		Me.lvCustomers_ColumnHeader_6_ = New System.Windows.Forms.ColumnHeader()
		Me.lvCustomers_ColumnHeader_7_ = New System.Windows.Forms.ColumnHeader()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Frame2 = New System.Windows.Forms.GroupBox()
		Me.txtCustomerContact = New System.Windows.Forms.TextBox()
		Me.txtCustomerCompany = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.dtPromised = New System.Windows.Forms.DateTimePicker()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.sbStatusBar.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.lvCustomers.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.SuspendLayout()
		Me.listViewHelper1 = New UpgradeHelpers.Gui.ListViewHelper(Me.components)
		Me.listViewHelper1.BeginInit()
		' 
		'txtSubTotal
		' 
		Me.txtSubTotal.AcceptsReturn = True
		Me.txtSubTotal.AllowDrop = True
		Me.txtSubTotal.BackColor = System.Drawing.SystemColors.Menu
		Me.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSubTotal.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSubTotal.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSubTotal.Location = New System.Drawing.Point(352, 616)
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
		Me.txtTotal.Location = New System.Drawing.Point(96, 616)
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
		Me.txtTotalTax.Location = New System.Drawing.Point(352, 592)
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
		Me.txtFreightCharge.Location = New System.Drawing.Point(96, 592)
		Me.txtFreightCharge.MaxLength = 0
		Me.txtFreightCharge.Name = "txtFreightCharge"
		Me.txtFreightCharge.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtFreightCharge.Size = New System.Drawing.Size(145, 20)
		Me.txtFreightCharge.TabIndex = 8
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
		Me.txtSalesTax.Location = New System.Drawing.Point(96, 568)
		Me.txtSalesTax.MaxLength = 0
		Me.txtSalesTax.Name = "txtSalesTax"
		Me.txtSalesTax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSalesTax.Size = New System.Drawing.Size(145, 20)
		Me.txtSalesTax.TabIndex = 7
		Me.txtSalesTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		' 
		'txtEntry
		' 
		Me.txtEntry.AcceptsReturn = True
		Me.txtEntry.AllowDrop = True
		Me.txtEntry.BackColor = System.Drawing.SystemColors.Window
		Me.txtEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtEntry.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtEntry.Enabled = False
		Me.txtEntry.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtEntry.Location = New System.Drawing.Point(96, 544)
		Me.txtEntry.MaxLength = 0
		Me.txtEntry.Name = "txtEntry"
		Me.txtEntry.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtEntry.Size = New System.Drawing.Size(145, 19)
		Me.txtEntry.TabIndex = 24
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
		Me.fgProducts.Location = New System.Drawing.Point(8, 360)
		Me.fgProducts.Name = "fgProducts"
		Me.fgProducts.ReadOnly = True
		Me.fgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
		Me.fgProducts.ShowCellToolTips = False
		Me.fgProducts.Size = New System.Drawing.Size(505, 177)
		Me.fgProducts.StandardTab = True
		Me.fgProducts.TabIndex = 6
		' 
		'sbStatusBar
		' 
		Me.sbStatusBar.AllowDrop = True
		Me.sbStatusBar.BackColor = System.Drawing.SystemColors.Control
		Me.sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.sbStatusBar.Location = New System.Drawing.Point(0, 678)
		Me.sbStatusBar.Name = "sbStatusBar"
		Me.sbStatusBar.ShowItemToolTips = True
		Me.sbStatusBar.Size = New System.Drawing.Size(523, 25)
		Me.sbStatusBar.TabIndex = 23
		Me.sbStatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbStatusBar_Panels_Panel1})
		' 
		'sbStatusBar_Panels_Panel1
		' 
		Me.sbStatusBar_Panels_Panel1.BorderSides = CType(System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom, System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.sbStatusBar_Panels_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.sbStatusBar_Panels_Panel1.DoubleClickEnabled = True
		Me.sbStatusBar_Panels_Panel1.Margin = New System.Windows.Forms.Padding(0)
		Me.sbStatusBar_Panels_Panel1.Size = New System.Drawing.Size(523, 25)
		Me.sbStatusBar_Panels_Panel1.Spring = True
		Me.sbStatusBar_Panels_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.sbStatusBar_Panels_Panel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		' 
		'dtRequired
		' 
		Me.dtRequired.AllowDrop = True
		Me.dtRequired.Checked = False
		Me.dtRequired.Format = System.Windows.Forms.DateTimePickerFormat.Short
		Me.dtRequired.Location = New System.Drawing.Point(120, 320)
		Me.dtRequired.Name = "dtRequired"
		Me.dtRequired.Size = New System.Drawing.Size(97, 20)
		Me.dtRequired.TabIndex = 4
		' 
		'cmdSave
		' 
		Me.cmdSave.AllowDrop = True
		Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSave.Location = New System.Drawing.Point(320, 648)
		Me.cmdSave.Name = "cmdSave"
		Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSave.Size = New System.Drawing.Size(89, 25)
		Me.cmdSave.TabIndex = 9
		Me.cmdSave.Text = "&Save"
		Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdSave.UseVisualStyleBackColor = False
		' 
		'cmdAddProducts
		' 
		Me.cmdAddProducts.AllowDrop = True
		Me.cmdAddProducts.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAddProducts.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAddProducts.Location = New System.Drawing.Point(488, 336)
		Me.cmdAddProducts.Name = "cmdAddProducts"
		Me.cmdAddProducts.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAddProducts.Size = New System.Drawing.Size(25, 21)
		Me.cmdAddProducts.TabIndex = 21
		Me.cmdAddProducts.TabStop = False
		Me.cmdAddProducts.Text = "..."
		Me.cmdAddProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdAddProducts.UseVisualStyleBackColor = False
		' 
		'cmdClose
		' 
		Me.cmdClose.AllowDrop = True
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Location = New System.Drawing.Point(416, 648)
		Me.cmdClose.Name = "cmdClose"
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.Size = New System.Drawing.Size(89, 25)
		Me.cmdClose.TabIndex = 10
		Me.cmdClose.Text = "&Close"
		Me.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdClose.UseVisualStyleBackColor = False
		' 
		'Frame1
		' 
		Me.Frame1.AllowDrop = True
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Controls.Add(Me.txtContactLastName)
		Me.Frame1.Controls.Add(Me.txtContactName)
		Me.Frame1.Controls.Add(Me.cmdCustomers)
		Me.Frame1.Controls.Add(Me.txtCompanyName)
		Me.Frame1.Controls.Add(Me.lvCustomers)
		Me.Frame1.Controls.Add(Me.Label3)
		Me.Frame1.Controls.Add(Me.Label4)
		Me.Frame1.Controls.Add(Me.Label2)
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.Location = New System.Drawing.Point(8, 8)
		Me.Frame1.Name = "Frame1"
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Size = New System.Drawing.Size(505, 249)
		Me.Frame1.TabIndex = 12
		Me.Frame1.Text = "Search customer"
		Me.Frame1.Visible = True
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
		'cmdCustomers
		' 
		Me.cmdCustomers.AllowDrop = True
		Me.cmdCustomers.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCustomers.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCustomers.Location = New System.Drawing.Point(456, 16)
		Me.cmdCustomers.Name = "cmdCustomers"
		Me.cmdCustomers.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCustomers.Size = New System.Drawing.Size(25, 21)
		Me.cmdCustomers.TabIndex = 13
		Me.cmdCustomers.TabStop = False
		Me.cmdCustomers.Text = "..."
		Me.cmdCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdCustomers.UseVisualStyleBackColor = False
		' 
		'txtCompanyName
		' 
		Me.txtCompanyName.AcceptsReturn = True
		Me.txtCompanyName.AllowDrop = True
		Me.txtCompanyName.BackColor = System.Drawing.SystemColors.Window
		Me.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCompanyName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCompanyName.Location = New System.Drawing.Point(88, 16)
		Me.txtCompanyName.MaxLength = 0
		Me.txtCompanyName.Name = "txtCompanyName"
		Me.txtCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCompanyName.Size = New System.Drawing.Size(145, 20)
		Me.txtCompanyName.TabIndex = 0
		' 
		'lvCustomers
		' 
		Me.lvCustomers.AllowDrop = True
		Me.lvCustomers.BackColor = System.Drawing.SystemColors.Window
		Me.lvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lvCustomers.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lvCustomers.FullRowSelect = True
		Me.lvCustomers.GridLines = True
		Me.lvCustomers.HideSelection = False
		Me.lvCustomers.HotTracking = True
		Me.lvCustomers.LabelEdit = False
		Me.lvCustomers.Location = New System.Drawing.Point(8, 80)
		Me.lvCustomers.MultiSelect = False
		Me.lvCustomers.Name = "lvCustomers"
		Me.lvCustomers.Size = New System.Drawing.Size(489, 161)
		Me.lvCustomers.TabIndex = 3
		Me.lvCustomers.View = System.Windows.Forms.View.Details
		Me.lvCustomers.Columns.Add(Me.lvCustomers_ColumnHeader_1_)
		Me.lvCustomers.Columns.Add(Me.lvCustomers_ColumnHeader_2_)
		Me.lvCustomers.Columns.Add(Me.lvCustomers_ColumnHeader_3_)
		Me.lvCustomers.Columns.Add(Me.lvCustomers_ColumnHeader_4_)
		Me.lvCustomers.Columns.Add(Me.lvCustomers_ColumnHeader_5_)
		Me.lvCustomers.Columns.Add(Me.lvCustomers_ColumnHeader_6_)
		Me.lvCustomers.Columns.Add(Me.lvCustomers_ColumnHeader_7_)
		' 
		'lvCustomers_ColumnHeader_1_
		' 
		Me.lvCustomers_ColumnHeader_1_.Text = "Customer ID"
		Me.lvCustomers_ColumnHeader_1_.Width = 97
		' 
		'lvCustomers_ColumnHeader_2_
		' 
		Me.lvCustomers_ColumnHeader_2_.Text = "Company Name"
		Me.lvCustomers_ColumnHeader_2_.Width = 97
		' 
		'lvCustomers_ColumnHeader_3_
		' 
		Me.lvCustomers_ColumnHeader_3_.Text = "Contact Name"
		Me.lvCustomers_ColumnHeader_3_.Width = 97
		' 
		'lvCustomers_ColumnHeader_4_
		' 
		Me.lvCustomers_ColumnHeader_4_.Text = "Contact Last Name"
		Me.lvCustomers_ColumnHeader_4_.Width = 97
		' 
		'lvCustomers_ColumnHeader_5_
		' 
		Me.lvCustomers_ColumnHeader_5_.Text = "City"
		Me.lvCustomers_ColumnHeader_5_.Width = 97
		' 
		'lvCustomers_ColumnHeader_6_
		' 
		Me.lvCustomers_ColumnHeader_6_.Text = "State"
		Me.lvCustomers_ColumnHeader_6_.Width = 97
		' 
		'lvCustomers_ColumnHeader_7_
		' 
		Me.lvCustomers_ColumnHeader_7_.Text = "Country"
		Me.lvCustomers_ColumnHeader_7_.Width = 97
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
		Me.Label3.Text = "Contact last name:"
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
		Me.Label4.Text = "Company name:"
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
		Me.Label2.Text = "Contact name:"
		' 
		'Frame2
		' 
		Me.Frame2.AllowDrop = True
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Controls.Add(Me.txtCustomerContact)
		Me.Frame2.Controls.Add(Me.txtCustomerCompany)
		Me.Frame2.Controls.Add(Me.Label5)
		Me.Frame2.Controls.Add(Me.Label1)
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.Location = New System.Drawing.Point(8, 256)
		Me.Frame2.Name = "Frame2"
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Size = New System.Drawing.Size(505, 49)
		Me.Frame2.TabIndex = 11
		Me.Frame2.Text = "Customer"
		Me.Frame2.Visible = True
		' 
		'txtCustomerContact
		' 
		Me.txtCustomerContact.AcceptsReturn = True
		Me.txtCustomerContact.AllowDrop = True
		Me.txtCustomerContact.BackColor = System.Drawing.SystemColors.Menu
		Me.txtCustomerContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCustomerContact.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCustomerContact.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCustomerContact.Location = New System.Drawing.Point(288, 16)
		Me.txtCustomerContact.MaxLength = 0
		Me.txtCustomerContact.Name = "txtCustomerContact"
		Me.txtCustomerContact.ReadOnly = True
		Me.txtCustomerContact.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCustomerContact.Size = New System.Drawing.Size(209, 20)
		Me.txtCustomerContact.TabIndex = 20
		Me.txtCustomerContact.TabStop = False
		' 
		'txtCustomerCompany
		' 
		Me.txtCustomerCompany.AcceptsReturn = True
		Me.txtCustomerCompany.AllowDrop = True
		Me.txtCustomerCompany.BackColor = System.Drawing.SystemColors.Menu
		Me.txtCustomerCompany.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCustomerCompany.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCustomerCompany.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCustomerCompany.Location = New System.Drawing.Point(72, 16)
		Me.txtCustomerCompany.MaxLength = 0
		Me.txtCustomerCompany.Name = "txtCustomerCompany"
		Me.txtCustomerCompany.ReadOnly = True
		Me.txtCustomerCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCustomerCompany.Size = New System.Drawing.Size(145, 20)
		Me.txtCustomerCompany.TabIndex = 19
		Me.txtCustomerCompany.TabStop = False
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
		Me.Label5.Text = "Company:"
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
		'dtPromised
		' 
		Me.dtPromised.AllowDrop = True
		Me.dtPromised.Checked = False
		Me.dtPromised.Format = System.Windows.Forms.DateTimePickerFormat.Short
		Me.dtPromised.Location = New System.Drawing.Point(352, 320)
		Me.dtPromised.Name = "dtPromised"
		Me.dtPromised.Size = New System.Drawing.Size(97, 20)
		Me.dtPromised.TabIndex = 5
		' 
		'Label13
		' 
		Me.Label13.AllowDrop = True
		Me.Label13.BackColor = System.Drawing.SystemColors.Control
		Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label13.Location = New System.Drawing.Point(8, 544)
		Me.Label13.Name = "Label13"
		Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label13.Size = New System.Drawing.Size(89, 17)
		Me.Label13.TabIndex = 33
		Me.Label13.Text = "Line quantity:"
		' 
		'Label12
		' 
		Me.Label12.AllowDrop = True
		Me.Label12.BackColor = System.Drawing.SystemColors.Control
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label12.Location = New System.Drawing.Point(8, 592)
		Me.Label12.Name = "Label12"
		Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label12.Size = New System.Drawing.Size(89, 17)
		Me.Label12.TabIndex = 32
		Me.Label12.Text = "Freight Charge:"
		' 
		'Label11
		' 
		Me.Label11.AllowDrop = True
		Me.Label11.BackColor = System.Drawing.SystemColors.Control
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label11.Location = New System.Drawing.Point(8, 616)
		Me.Label11.Name = "Label11"
		Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label11.Size = New System.Drawing.Size(89, 17)
		Me.Label11.TabIndex = 30
		Me.Label11.Text = "Total:"
		' 
		'Label10
		' 
		Me.Label10.AllowDrop = True
		Me.Label10.BackColor = System.Drawing.SystemColors.Control
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label10.Location = New System.Drawing.Point(272, 592)
		Me.Label10.Name = "Label10"
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.Size = New System.Drawing.Size(89, 17)
		Me.Label10.TabIndex = 28
		Me.Label10.Text = "Total Tax:"
		' 
		'Label9
		' 
		Me.Label9.AllowDrop = True
		Me.Label9.BackColor = System.Drawing.SystemColors.Control
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Location = New System.Drawing.Point(272, 616)
		Me.Label9.Name = "Label9"
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.Size = New System.Drawing.Size(89, 17)
		Me.Label9.TabIndex = 26
		Me.Label9.Text = "Sub Total:"
		' 
		'Label8
		' 
		Me.Label8.AllowDrop = True
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Location = New System.Drawing.Point(8, 568)
		Me.Label8.Name = "Label8"
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.Size = New System.Drawing.Size(89, 17)
		Me.Label8.TabIndex = 25
		Me.Label8.Text = "Sales Tax:"
		' 
		'Label7
		' 
		Me.Label7.AllowDrop = True
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Location = New System.Drawing.Point(256, 320)
		Me.Label7.Name = "Label7"
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.Size = New System.Drawing.Size(105, 17)
		Me.Label7.TabIndex = 22
		Me.Label7.Text = "Promised by date:"
		' 
		'Label6
		' 
		Me.Label6.AllowDrop = True
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Location = New System.Drawing.Point(8, 320)
		Me.Label6.Name = "Label6"
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.Size = New System.Drawing.Size(105, 17)
		Me.Label6.TabIndex = 34
		Me.Label6.Text = "Required by date:"
		' 
		'frmOrderRequest
		' 
		Me.AllowDrop = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6, 13)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScroll = True
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(523, 703)
		Me.Controls.Add(Me.txtSubTotal)
		Me.Controls.Add(Me.txtTotal)
		Me.Controls.Add(Me.txtTotalTax)
		Me.Controls.Add(Me.txtFreightCharge)
		Me.Controls.Add(Me.txtSalesTax)
		Me.Controls.Add(Me.txtEntry)
		Me.Controls.Add(Me.fgProducts)
		Me.Controls.Add(Me.sbStatusBar)
		Me.Controls.Add(Me.dtRequired)
		Me.Controls.Add(Me.cmdSave)
		Me.Controls.Add(Me.cmdAddProducts)
		Me.Controls.Add(Me.cmdClose)
		Me.Controls.Add(Me.Frame1)
		Me.Controls.Add(Me.Frame2)
		Me.Controls.Add(Me.dtPromised)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Location = New System.Drawing.Point(3, 25)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmOrderRequest"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Create Order"
		Me.listViewHelper1.SetItemClickMethod(Me.lvCustomers, "lvCustomers_ItemClick")
		Me.listViewHelper1.SetCorrectEventsBehavior(Me.lvCustomers, True)
		Me.listViewHelper1.EndInit()
		Me.sbStatusBar.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.lvCustomers.ResumeLayout(False)
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
			AddHandler Me.Activated, AddressOf Me.frmOrderRequest_Activated
		End If
	End Sub
#End Region
End Class