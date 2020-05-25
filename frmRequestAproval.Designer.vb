<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequestApproval
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmRequestApproval
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmRequestApproval
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmRequestApproval)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmRequestApproval
		Dim theInstance As New frmRequestApproval()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "cmdApprove", "cmdInfo", "fgOrders", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdCancel", "cmdClose", "cmbStatus", "chkTo", "chkFrom", "txtProductID", "txtOrderID", "txtContactLastName", "txtContactName", "cmdCustomers", "txtCompanyName", "dtFrom", "dtTo", "Label5", "Label8", "Label1", "Label6", "Label3", "Label4", "Label2", "Frame1", "listBoxComboBoxHelper1"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents cmdApprove As System.Windows.Forms.Button
	Public WithEvents cmdInfo As System.Windows.Forms.Button
	Public WithEvents fgOrders As UpgradeHelpers.DataGridViewFlex
	Public WithEvents sbStatusBar_Panels_Panel1 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents sbStatusBar As System.Windows.Forms.StatusStrip
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents cmbStatus As System.Windows.Forms.ComboBox
	Public WithEvents chkTo As System.Windows.Forms.CheckBox
	Public WithEvents chkFrom As System.Windows.Forms.CheckBox
	Public WithEvents txtProductID As System.Windows.Forms.TextBox
	Public WithEvents txtOrderID As System.Windows.Forms.TextBox
	Public WithEvents txtContactLastName As System.Windows.Forms.TextBox
	Public WithEvents txtContactName As System.Windows.Forms.TextBox
	Public WithEvents cmdCustomers As System.Windows.Forms.Button
	Public WithEvents txtCompanyName As System.Windows.Forms.TextBox
	Public WithEvents dtFrom As System.Windows.Forms.DateTimePicker
	Public WithEvents dtTo As System.Windows.Forms.DateTimePicker
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public listBoxComboBoxHelper1 As UpgradeHelpers.Gui.ListControlHelper
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmRequestApproval))
		Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
		Me.cmdApprove = New System.Windows.Forms.Button()
		Me.cmdInfo = New System.Windows.Forms.Button()
		Me.fgOrders = New UpgradeHelpers.DataGridViewFlex(Me.components)
		Me.sbStatusBar = New System.Windows.Forms.StatusStrip()
		Me.sbStatusBar_Panels_Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.cmdCancel = New System.Windows.Forms.Button()
		Me.cmdClose = New System.Windows.Forms.Button()
		Me.Frame1 = New System.Windows.Forms.GroupBox()
		Me.cmbStatus = New System.Windows.Forms.ComboBox()
		Me.chkTo = New System.Windows.Forms.CheckBox()
		Me.chkFrom = New System.Windows.Forms.CheckBox()
		Me.txtProductID = New System.Windows.Forms.TextBox()
		Me.txtOrderID = New System.Windows.Forms.TextBox()
		Me.txtContactLastName = New System.Windows.Forms.TextBox()
		Me.txtContactName = New System.Windows.Forms.TextBox()
		Me.cmdCustomers = New System.Windows.Forms.Button()
		Me.txtCompanyName = New System.Windows.Forms.TextBox()
		Me.dtFrom = New System.Windows.Forms.DateTimePicker()
		Me.dtTo = New System.Windows.Forms.DateTimePicker()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.sbStatusBar.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.listBoxComboBoxHelper1 = New UpgradeHelpers.Gui.ListControlHelper(Me.components)
		Me.listBoxComboBoxHelper1.BeginInit()
		' 
		'cmdApprove
		' 
		Me.cmdApprove.AllowDrop = True
		Me.cmdApprove.BackColor = System.Drawing.SystemColors.Control
		Me.cmdApprove.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdApprove.Location = New System.Drawing.Point(232, 440)
		Me.cmdApprove.Name = "cmdApprove"
		Me.cmdApprove.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdApprove.Size = New System.Drawing.Size(89, 25)
		Me.cmdApprove.TabIndex = 10
		Me.cmdApprove.Text = "&Create"
		Me.cmdApprove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdApprove.UseVisualStyleBackColor = False
		' 
		'cmdInfo
		' 
		Me.cmdInfo.AllowDrop = True
		Me.cmdInfo.BackColor = System.Drawing.SystemColors.Control
		Me.cmdInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdInfo.Location = New System.Drawing.Point(136, 440)
		Me.cmdInfo.Name = "cmdInfo"
		Me.cmdInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdInfo.Size = New System.Drawing.Size(89, 25)
		Me.cmdInfo.TabIndex = 9
		Me.cmdInfo.Text = "&Info"
		Me.cmdInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdInfo.UseVisualStyleBackColor = False
		' 
		'fgOrders
		' 
		Me.fgOrders.AllowBigSelection = False
		Me.fgOrders.AllowDrop = True
		Me.fgOrders.AllowUserToAddRows = False
		Me.fgOrders.AllowUserToDeleteRows = False
		Me.fgOrders.AllowUserToResizeColumns = False
		Me.fgOrders.AllowUserToResizeRows = False
		Me.fgOrders.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.fgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.fgOrders.ColumnsCount = 1
		Me.fgOrders.FixedColumns = 0
		Me.fgOrders.FixedRows = 0
		Me.fgOrders.Location = New System.Drawing.Point(8, 168)
		Me.fgOrders.Name = "fgOrders"
		Me.fgOrders.ReadOnly = True
		Me.fgOrders.RowsCount = 1
		Me.fgOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.fgOrders.ShowCellToolTips = False
		Me.fgOrders.Size = New System.Drawing.Size(505, 265)
		Me.fgOrders.StandardTab = True
		Me.fgOrders.TabIndex = 8
		' 
		'sbStatusBar
		' 
		Me.sbStatusBar.AllowDrop = True
		Me.sbStatusBar.BackColor = System.Drawing.SystemColors.Control
		Me.sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.sbStatusBar.Location = New System.Drawing.Point(0, 471)
		Me.sbStatusBar.Name = "sbStatusBar"
		Me.sbStatusBar.ShowItemToolTips = True
		Me.sbStatusBar.Size = New System.Drawing.Size(523, 25)
		Me.sbStatusBar.TabIndex = 18
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
		'cmdCancel
		' 
		Me.cmdCancel.AllowDrop = True
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Location = New System.Drawing.Point(328, 440)
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.Size = New System.Drawing.Size(89, 25)
		Me.cmdCancel.TabIndex = 11
		Me.cmdCancel.Text = "&Cancel"
		Me.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdCancel.UseVisualStyleBackColor = False
		' 
		'cmdClose
		' 
		Me.cmdClose.AllowDrop = True
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Location = New System.Drawing.Point(424, 440)
		Me.cmdClose.Name = "cmdClose"
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.Size = New System.Drawing.Size(89, 25)
		Me.cmdClose.TabIndex = 12
		Me.cmdClose.Text = "&Close"
		Me.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdClose.UseVisualStyleBackColor = False
		' 
		'Frame1
		' 
		Me.Frame1.AllowDrop = True
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Controls.Add(Me.cmbStatus)
		Me.Frame1.Controls.Add(Me.chkTo)
		Me.Frame1.Controls.Add(Me.chkFrom)
		Me.Frame1.Controls.Add(Me.txtProductID)
		Me.Frame1.Controls.Add(Me.txtOrderID)
		Me.Frame1.Controls.Add(Me.txtContactLastName)
		Me.Frame1.Controls.Add(Me.txtContactName)
		Me.Frame1.Controls.Add(Me.cmdCustomers)
		Me.Frame1.Controls.Add(Me.txtCompanyName)
		Me.Frame1.Controls.Add(Me.dtFrom)
		Me.Frame1.Controls.Add(Me.dtTo)
		Me.Frame1.Controls.Add(Me.Label5)
		Me.Frame1.Controls.Add(Me.Label8)
		Me.Frame1.Controls.Add(Me.Label1)
		Me.Frame1.Controls.Add(Me.Label6)
		Me.Frame1.Controls.Add(Me.Label3)
		Me.Frame1.Controls.Add(Me.Label4)
		Me.Frame1.Controls.Add(Me.Label2)
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.Location = New System.Drawing.Point(8, 8)
		Me.Frame1.Name = "Frame1"
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Size = New System.Drawing.Size(505, 153)
		Me.Frame1.TabIndex = 13
		Me.Frame1.Text = "Search customer"
		Me.Frame1.Visible = True
		' 
		'cmbStatus
		' 
		Me.cmbStatus.AllowDrop = True
		Me.cmbStatus.BackColor = System.Drawing.SystemColors.Window
		Me.cmbStatus.CausesValidation = True
		Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbStatus.Enabled = True
		Me.cmbStatus.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbStatus.IntegralHeight = True
		Me.cmbStatus.Location = New System.Drawing.Point(336, 16)
		Me.cmbStatus.Name = "cmbStatus"
		Me.cmbStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbStatus.Size = New System.Drawing.Size(145, 21)
		Me.cmbStatus.Sorted = False
		Me.cmbStatus.TabIndex = 1
		Me.cmbStatus.TabStop = True
		Me.cmbStatus.Visible = True
		Me.cmbStatus.Items.AddRange(New Object() {"All", "Requested", "Cancelled", "Approved"})
		' 
		'chkTo
		' 
		Me.chkTo.AllowDrop = True
		Me.chkTo.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkTo.BackColor = System.Drawing.SystemColors.Control
		Me.chkTo.CausesValidation = True
		Me.chkTo.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkTo.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkTo.Enabled = True
		Me.chkTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkTo.Location = New System.Drawing.Point(336, 80)
		Me.chkTo.Name = "chkTo"
		Me.chkTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkTo.Size = New System.Drawing.Size(41, 17)
		Me.chkTo.TabIndex = 23
		Me.chkTo.TabStop = False
		Me.chkTo.Text = "To:"
		Me.chkTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkTo.Visible = True
		' 
		'chkFrom
		' 
		Me.chkFrom.AllowDrop = True
		Me.chkFrom.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkFrom.BackColor = System.Drawing.SystemColors.Control
		Me.chkFrom.CausesValidation = True
		Me.chkFrom.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkFrom.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkFrom.Enabled = True
		Me.chkFrom.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkFrom.Location = New System.Drawing.Point(88, 80)
		Me.chkFrom.Name = "chkFrom"
		Me.chkFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkFrom.Size = New System.Drawing.Size(47, 17)
		Me.chkFrom.TabIndex = 22
		Me.chkFrom.TabStop = False
		Me.chkFrom.Text = "From:"
		Me.chkFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkFrom.Visible = True
		' 
		'txtProductID
		' 
		Me.txtProductID.AcceptsReturn = True
		Me.txtProductID.AllowDrop = True
		Me.txtProductID.BackColor = System.Drawing.SystemColors.Window
		Me.txtProductID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtProductID.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtProductID.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtProductID.Location = New System.Drawing.Point(336, 112)
		Me.txtProductID.MaxLength = 0
		Me.txtProductID.Name = "txtProductID"
		Me.txtProductID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtProductID.Size = New System.Drawing.Size(145, 20)
		Me.txtProductID.TabIndex = 7
		' 
		'txtOrderID
		' 
		Me.txtOrderID.AcceptsReturn = True
		Me.txtOrderID.AllowDrop = True
		Me.txtOrderID.BackColor = System.Drawing.SystemColors.Window
		Me.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtOrderID.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtOrderID.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtOrderID.Location = New System.Drawing.Point(88, 112)
		Me.txtOrderID.MaxLength = 0
		Me.txtOrderID.Name = "txtOrderID"
		Me.txtOrderID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtOrderID.Size = New System.Drawing.Size(145, 20)
		Me.txtOrderID.TabIndex = 6
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
		Me.txtContactLastName.TabIndex = 3
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
		Me.txtContactName.TabIndex = 2
		' 
		'cmdCustomers
		' 
		Me.cmdCustomers.AllowDrop = True
		Me.cmdCustomers.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCustomers.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCustomers.Location = New System.Drawing.Point(240, 16)
		Me.cmdCustomers.Name = "cmdCustomers"
		Me.cmdCustomers.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCustomers.Size = New System.Drawing.Size(25, 21)
		Me.cmdCustomers.TabIndex = 14
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
		'dtFrom
		' 
		Me.dtFrom.AllowDrop = True
		Me.dtFrom.Checked = False
		Me.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short
		Me.dtFrom.Location = New System.Drawing.Point(136, 80)
		Me.dtFrom.Name = "dtFrom"
		Me.dtFrom.Size = New System.Drawing.Size(97, 20)
		Me.dtFrom.TabIndex = 4
		' 
		'dtTo
		' 
		Me.dtTo.AllowDrop = True
		Me.dtTo.Checked = False
		Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short
		Me.dtTo.Location = New System.Drawing.Point(384, 80)
		Me.dtTo.Name = "dtTo"
		Me.dtTo.Size = New System.Drawing.Size(97, 20)
		Me.dtTo.TabIndex = 5
		' 
		'Label5
		' 
		Me.Label5.AllowDrop = True
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Location = New System.Drawing.Point(288, 16)
		Me.Label5.Name = "Label5"
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.Size = New System.Drawing.Size(41, 17)
		Me.Label5.TabIndex = 24
		Me.Label5.Text = "Status"
		' 
		'Label8
		' 
		Me.Label8.AllowDrop = True
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Location = New System.Drawing.Point(256, 112)
		Me.Label8.Name = "Label8"
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.Size = New System.Drawing.Size(73, 17)
		Me.Label8.TabIndex = 21
		Me.Label8.Text = "Product"
		' 
		'Label1
		' 
		Me.Label1.AllowDrop = True
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Location = New System.Drawing.Point(8, 112)
		Me.Label1.Name = "Label1"
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.Size = New System.Drawing.Size(89, 17)
		Me.Label1.TabIndex = 20
		Me.Label1.Text = "Order"
		' 
		'Label6
		' 
		Me.Label6.AllowDrop = True
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Location = New System.Drawing.Point(8, 80)
		Me.Label6.Name = "Label6"
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.Size = New System.Drawing.Size(65, 17)
		Me.Label6.TabIndex = 19
		Me.Label6.Text = "Date range:"
		' 
		'Label3
		' 
		Me.Label3.AllowDrop = True
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Location = New System.Drawing.Point(256, 48)
		Me.Label3.Name = "Label3"
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.Size = New System.Drawing.Size(65, 17)
		Me.Label3.TabIndex = 17
		Me.Label3.Text = "Last Name"
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
		Me.Label4.TabIndex = 16
		Me.Label4.Text = "Company"
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
		Me.Label2.TabIndex = 15
		Me.Label2.Text = "First Name"
		' 
		'frmRequestApproval
		' 
		Me.AllowDrop = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6, 13)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScroll = True
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(523, 496)
		Me.Controls.Add(Me.cmdApprove)
		Me.Controls.Add(Me.cmdInfo)
		Me.Controls.Add(Me.fgOrders)
		Me.Controls.Add(Me.sbStatusBar)
		Me.Controls.Add(Me.cmdCancel)
		Me.Controls.Add(Me.cmdClose)
		Me.Controls.Add(Me.Frame1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Location = New System.Drawing.Point(3, 25)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmRequestApproval"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Create Invoice"
		Me.listBoxComboBoxHelper1.SetItemData(Me.cmbStatus, New Integer() {0, 0, 0, 0})
		Me.listBoxComboBoxHelper1.EndInit()
		Me.sbStatusBar.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
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
			AddHandler MyBase.Closed, AddressOf Me.Form_Closed
			AddHandler Me.Activated, AddressOf Me.frmRequestApproval_Activated
		End If
	End Sub
#End Region
End Class