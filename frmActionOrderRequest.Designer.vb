<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActionOrderRequest
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmActionOrderRequest
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmActionOrderRequest
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmActionOrderRequest)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmActionOrderRequest
		Dim theInstance As New frmActionOrderRequest()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "txtPromisedBy", "txtRequiredBy", "txtReceivedBy", "cmdApprove", "txtStatus", "txtReceived", "txtChangedBy", "txtChanged", "txtOrderID", "txtNotes", "txtSubTotal", "txtTotal", "txtTotalTax", "txtFreightCharge", "txtSalesTax", "txtEntry", "fgDetails", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdCancel", "cmdClose", "txtCustomerContact", "txtCustomerCompany", "Label5", "Label1", "Frame2", "Label13", "Label2", "Label7", "Label3", "Label19", "lblChangedBy", "Label4", "lblChanged", "Label12", "Label11", "Label10", "Label9", "Label8", "Label6"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents txtPromisedBy As System.Windows.Forms.TextBox
	Public WithEvents txtRequiredBy As System.Windows.Forms.TextBox
	Public WithEvents txtReceivedBy As System.Windows.Forms.TextBox
	Public WithEvents cmdApprove As System.Windows.Forms.Button
	Public WithEvents txtStatus As System.Windows.Forms.TextBox
	Public WithEvents txtReceived As System.Windows.Forms.TextBox
	Public WithEvents txtChangedBy As System.Windows.Forms.TextBox
	Public WithEvents txtChanged As System.Windows.Forms.TextBox
	Public WithEvents txtOrderID As System.Windows.Forms.TextBox
	Public WithEvents txtNotes As System.Windows.Forms.TextBox
	Public WithEvents txtSubTotal As System.Windows.Forms.TextBox
	Public WithEvents txtTotal As System.Windows.Forms.TextBox
	Public WithEvents txtTotalTax As System.Windows.Forms.TextBox
	Public WithEvents txtFreightCharge As System.Windows.Forms.TextBox
	Public WithEvents txtSalesTax As System.Windows.Forms.TextBox
	Public WithEvents txtEntry As System.Windows.Forms.TextBox
	Public WithEvents fgDetails As UpgradeHelpers.DataGridViewFlex
	Public WithEvents sbStatusBar_Panels_Panel1 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents sbStatusBar As System.Windows.Forms.StatusStrip
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents txtCustomerContact As System.Windows.Forms.TextBox
	Public WithEvents txtCustomerCompany As System.Windows.Forms.TextBox
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents lblChangedBy As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents lblChanged As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmActionOrderRequest))
		Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
		Me.txtPromisedBy = New System.Windows.Forms.TextBox()
		Me.txtRequiredBy = New System.Windows.Forms.TextBox()
		Me.txtReceivedBy = New System.Windows.Forms.TextBox()
		Me.cmdApprove = New System.Windows.Forms.Button()
		Me.txtStatus = New System.Windows.Forms.TextBox()
		Me.txtReceived = New System.Windows.Forms.TextBox()
		Me.txtChangedBy = New System.Windows.Forms.TextBox()
		Me.txtChanged = New System.Windows.Forms.TextBox()
		Me.txtOrderID = New System.Windows.Forms.TextBox()
		Me.txtNotes = New System.Windows.Forms.TextBox()
		Me.txtSubTotal = New System.Windows.Forms.TextBox()
		Me.txtTotal = New System.Windows.Forms.TextBox()
		Me.txtTotalTax = New System.Windows.Forms.TextBox()
		Me.txtFreightCharge = New System.Windows.Forms.TextBox()
		Me.txtSalesTax = New System.Windows.Forms.TextBox()
		Me.txtEntry = New System.Windows.Forms.TextBox()
		Me.fgDetails = New UpgradeHelpers.DataGridViewFlex(Me.components)
		Me.sbStatusBar = New System.Windows.Forms.StatusStrip()
		Me.sbStatusBar_Panels_Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.cmdCancel = New System.Windows.Forms.Button()
		Me.cmdClose = New System.Windows.Forms.Button()
		Me.Frame2 = New System.Windows.Forms.GroupBox()
		Me.txtCustomerContact = New System.Windows.Forms.TextBox()
		Me.txtCustomerCompany = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.lblChangedBy = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.lblChanged = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.sbStatusBar.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.SuspendLayout()
		' 
		'txtPromisedBy
		' 
		Me.txtPromisedBy.AcceptsReturn = True
		Me.txtPromisedBy.AllowDrop = True
		Me.txtPromisedBy.BackColor = System.Drawing.SystemColors.Menu
		Me.txtPromisedBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPromisedBy.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPromisedBy.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPromisedBy.Location = New System.Drawing.Point(368, 200)
		Me.txtPromisedBy.MaxLength = 0
		Me.txtPromisedBy.Name = "txtPromisedBy"
		Me.txtPromisedBy.ReadOnly = True
		Me.txtPromisedBy.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPromisedBy.Size = New System.Drawing.Size(105, 20)
		Me.txtPromisedBy.TabIndex = 38
		Me.txtPromisedBy.TabStop = False
		' 
		'txtRequiredBy
		' 
		Me.txtRequiredBy.AcceptsReturn = True
		Me.txtRequiredBy.AllowDrop = True
		Me.txtRequiredBy.BackColor = System.Drawing.SystemColors.Menu
		Me.txtRequiredBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtRequiredBy.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRequiredBy.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRequiredBy.Location = New System.Drawing.Point(120, 200)
		Me.txtRequiredBy.MaxLength = 0
		Me.txtRequiredBy.Name = "txtRequiredBy"
		Me.txtRequiredBy.ReadOnly = True
		Me.txtRequiredBy.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRequiredBy.Size = New System.Drawing.Size(105, 20)
		Me.txtRequiredBy.TabIndex = 37
		Me.txtRequiredBy.TabStop = False
		' 
		'txtReceivedBy
		' 
		Me.txtReceivedBy.AcceptsReturn = True
		Me.txtReceivedBy.AllowDrop = True
		Me.txtReceivedBy.BackColor = System.Drawing.SystemColors.Menu
		Me.txtReceivedBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtReceivedBy.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtReceivedBy.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtReceivedBy.Location = New System.Drawing.Point(96, 64)
		Me.txtReceivedBy.MaxLength = 0
		Me.txtReceivedBy.Name = "txtReceivedBy"
		Me.txtReceivedBy.ReadOnly = True
		Me.txtReceivedBy.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtReceivedBy.Size = New System.Drawing.Size(105, 20)
		Me.txtReceivedBy.TabIndex = 33
		Me.txtReceivedBy.TabStop = False
		' 
		'cmdApprove
		' 
		Me.cmdApprove.AllowDrop = True
		Me.cmdApprove.BackColor = System.Drawing.SystemColors.Control
		Me.cmdApprove.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdApprove.Location = New System.Drawing.Point(232, 480)
		Me.cmdApprove.Name = "cmdApprove"
		Me.cmdApprove.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdApprove.Size = New System.Drawing.Size(89, 25)
		Me.cmdApprove.TabIndex = 0
		Me.cmdApprove.Text = "&Create"
		Me.cmdApprove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdApprove.UseVisualStyleBackColor = False
		' 
		'txtStatus
		' 
		Me.txtStatus.AcceptsReturn = True
		Me.txtStatus.AllowDrop = True
		Me.txtStatus.BackColor = System.Drawing.SystemColors.Menu
		Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStatus.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStatus.Location = New System.Drawing.Point(408, 8)
		Me.txtStatus.MaxLength = 0
		Me.txtStatus.Name = "txtStatus"
		Me.txtStatus.ReadOnly = True
		Me.txtStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStatus.Size = New System.Drawing.Size(105, 20)
		Me.txtStatus.TabIndex = 31
		Me.txtStatus.TabStop = False
		' 
		'txtReceived
		' 
		Me.txtReceived.AcceptsReturn = True
		Me.txtReceived.AllowDrop = True
		Me.txtReceived.BackColor = System.Drawing.SystemColors.Menu
		Me.txtReceived.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtReceived.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtReceived.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtReceived.Location = New System.Drawing.Point(96, 36)
		Me.txtReceived.MaxLength = 0
		Me.txtReceived.Name = "txtReceived"
		Me.txtReceived.ReadOnly = True
		Me.txtReceived.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtReceived.Size = New System.Drawing.Size(105, 20)
		Me.txtReceived.TabIndex = 29
		Me.txtReceived.TabStop = False
		' 
		'txtChangedBy
		' 
		Me.txtChangedBy.AcceptsReturn = True
		Me.txtChangedBy.AllowDrop = True
		Me.txtChangedBy.BackColor = System.Drawing.SystemColors.Menu
		Me.txtChangedBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtChangedBy.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtChangedBy.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtChangedBy.Location = New System.Drawing.Point(408, 64)
		Me.txtChangedBy.MaxLength = 0
		Me.txtChangedBy.Name = "txtChangedBy"
		Me.txtChangedBy.ReadOnly = True
		Me.txtChangedBy.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtChangedBy.Size = New System.Drawing.Size(105, 20)
		Me.txtChangedBy.TabIndex = 25
		Me.txtChangedBy.TabStop = False
		' 
		'txtChanged
		' 
		Me.txtChanged.AcceptsReturn = True
		Me.txtChanged.AllowDrop = True
		Me.txtChanged.BackColor = System.Drawing.SystemColors.Menu
		Me.txtChanged.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtChanged.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtChanged.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtChanged.Location = New System.Drawing.Point(408, 36)
		Me.txtChanged.MaxLength = 0
		Me.txtChanged.Name = "txtChanged"
		Me.txtChanged.ReadOnly = True
		Me.txtChanged.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtChanged.Size = New System.Drawing.Size(105, 20)
		Me.txtChanged.TabIndex = 24
		Me.txtChanged.TabStop = False
		' 
		'txtOrderID
		' 
		Me.txtOrderID.AcceptsReturn = True
		Me.txtOrderID.AllowDrop = True
		Me.txtOrderID.BackColor = System.Drawing.SystemColors.Menu
		Me.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtOrderID.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtOrderID.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtOrderID.Location = New System.Drawing.Point(96, 8)
		Me.txtOrderID.MaxLength = 0
		Me.txtOrderID.Name = "txtOrderID"
		Me.txtOrderID.ReadOnly = True
		Me.txtOrderID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtOrderID.Size = New System.Drawing.Size(105, 20)
		Me.txtOrderID.TabIndex = 23
		Me.txtOrderID.TabStop = False
		' 
		'txtNotes
		' 
		Me.txtNotes.AcceptsReturn = True
		Me.txtNotes.AllowDrop = True
		Me.txtNotes.BackColor = System.Drawing.SystemColors.Menu
		Me.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNotes.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNotes.Location = New System.Drawing.Point(56, 152)
		Me.txtNotes.MaxLength = 0
		Me.txtNotes.Multiline = True
		Me.txtNotes.Name = "txtNotes"
		Me.txtNotes.ReadOnly = True
		Me.txtNotes.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNotes.Size = New System.Drawing.Size(457, 44)
		Me.txtNotes.TabIndex = 3
		Me.txtNotes.TabStop = False
		' 
		'txtSubTotal
		' 
		Me.txtSubTotal.AcceptsReturn = True
		Me.txtSubTotal.AllowDrop = True
		Me.txtSubTotal.BackColor = System.Drawing.SystemColors.Menu
		Me.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSubTotal.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSubTotal.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSubTotal.Location = New System.Drawing.Point(368, 432)
		Me.txtSubTotal.MaxLength = 0
		Me.txtSubTotal.Name = "txtSubTotal"
		Me.txtSubTotal.ReadOnly = True
		Me.txtSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSubTotal.Size = New System.Drawing.Size(145, 20)
		Me.txtSubTotal.TabIndex = 21
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
		Me.txtTotal.Location = New System.Drawing.Point(88, 456)
		Me.txtTotal.MaxLength = 0
		Me.txtTotal.Name = "txtTotal"
		Me.txtTotal.ReadOnly = True
		Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTotal.Size = New System.Drawing.Size(145, 20)
		Me.txtTotal.TabIndex = 19
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
		Me.txtTotalTax.Location = New System.Drawing.Point(368, 408)
		Me.txtTotalTax.MaxLength = 0
		Me.txtTotalTax.Name = "txtTotalTax"
		Me.txtTotalTax.ReadOnly = True
		Me.txtTotalTax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTotalTax.Size = New System.Drawing.Size(145, 20)
		Me.txtTotalTax.TabIndex = 17
		Me.txtTotalTax.TabStop = False
		Me.txtTotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		' 
		'txtFreightCharge
		' 
		Me.txtFreightCharge.AcceptsReturn = True
		Me.txtFreightCharge.AllowDrop = True
		Me.txtFreightCharge.BackColor = System.Drawing.SystemColors.Menu
		Me.txtFreightCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtFreightCharge.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtFreightCharge.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtFreightCharge.Location = New System.Drawing.Point(88, 432)
		Me.txtFreightCharge.MaxLength = 0
		Me.txtFreightCharge.Name = "txtFreightCharge"
		Me.txtFreightCharge.ReadOnly = True
		Me.txtFreightCharge.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtFreightCharge.Size = New System.Drawing.Size(145, 20)
		Me.txtFreightCharge.TabIndex = 6
		Me.txtFreightCharge.TabStop = False
		Me.txtFreightCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		' 
		'txtSalesTax
		' 
		Me.txtSalesTax.AcceptsReturn = True
		Me.txtSalesTax.AllowDrop = True
		Me.txtSalesTax.BackColor = System.Drawing.SystemColors.Menu
		Me.txtSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSalesTax.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSalesTax.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSalesTax.Location = New System.Drawing.Point(88, 408)
		Me.txtSalesTax.MaxLength = 0
		Me.txtSalesTax.Name = "txtSalesTax"
		Me.txtSalesTax.ReadOnly = True
		Me.txtSalesTax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSalesTax.Size = New System.Drawing.Size(145, 20)
		Me.txtSalesTax.TabIndex = 5
		Me.txtSalesTax.TabStop = False
		Me.txtSalesTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		' 
		'txtEntry
		' 
		Me.txtEntry.AcceptsReturn = True
		Me.txtEntry.AllowDrop = True
		Me.txtEntry.BackColor = System.Drawing.SystemColors.Window
		Me.txtEntry.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtEntry.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtEntry.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtEntry.Location = New System.Drawing.Point(416, 336)
		Me.txtEntry.MaxLength = 0
		Me.txtEntry.Name = "txtEntry"
		Me.txtEntry.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtEntry.Size = New System.Drawing.Size(73, 19)
		Me.txtEntry.TabIndex = 14
		Me.txtEntry.Visible = False
		' 
		'fgDetails
		' 
		Me.fgDetails.AllowDrop = True
		Me.fgDetails.AllowUserToAddRows = False
		Me.fgDetails.AllowUserToDeleteRows = False
		Me.fgDetails.AllowUserToResizeColumns = False
		Me.fgDetails.AllowUserToResizeRows = False
		Me.fgDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.fgDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.fgDetails.ColumnsCount = 0
		Me.fgDetails.FixedColumns = 0
		Me.fgDetails.FixedRows = 0
		Me.fgDetails.Location = New System.Drawing.Point(8, 224)
		Me.fgDetails.Name = "fgDetails"
		Me.fgDetails.ReadOnly = True
		Me.fgDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
		Me.fgDetails.ShowCellToolTips = False
		Me.fgDetails.Size = New System.Drawing.Size(505, 177)
		Me.fgDetails.StandardTab = True
		Me.fgDetails.TabIndex = 4
		Me.fgDetails.TabStop = False
		' 
		'sbStatusBar
		' 
		Me.sbStatusBar.AllowDrop = True
		Me.sbStatusBar.BackColor = System.Drawing.SystemColors.Control
		Me.sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.sbStatusBar.Location = New System.Drawing.Point(0, 509)
		Me.sbStatusBar.Name = "sbStatusBar"
		Me.sbStatusBar.ShowItemToolTips = True
		Me.sbStatusBar.Size = New System.Drawing.Size(523, 25)
		Me.sbStatusBar.TabIndex = 13
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
		Me.cmdCancel.Location = New System.Drawing.Point(328, 480)
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.Size = New System.Drawing.Size(89, 25)
		Me.cmdCancel.TabIndex = 1
		Me.cmdCancel.Text = "&Cancel"
		Me.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdCancel.UseVisualStyleBackColor = False
		' 
		'cmdClose
		' 
		Me.cmdClose.AllowDrop = True
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Location = New System.Drawing.Point(424, 480)
		Me.cmdClose.Name = "cmdClose"
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.Size = New System.Drawing.Size(89, 25)
		Me.cmdClose.TabIndex = 2
		Me.cmdClose.Text = "&Close"
		Me.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdClose.UseVisualStyleBackColor = False
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
		Me.Frame2.Location = New System.Drawing.Point(8, 96)
		Me.Frame2.Name = "Frame2"
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Size = New System.Drawing.Size(505, 49)
		Me.Frame2.TabIndex = 7
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
		Me.txtCustomerContact.TabIndex = 11
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
		Me.txtCustomerCompany.TabIndex = 10
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
		Me.Label5.TabIndex = 9
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
		Me.Label1.TabIndex = 8
		Me.Label1.Text = "Contact:"
		' 
		'Label13
		' 
		Me.Label13.AllowDrop = True
		Me.Label13.BackColor = System.Drawing.SystemColors.Control
		Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label13.Location = New System.Drawing.Point(16, 200)
		Me.Label13.Name = "Label13"
		Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label13.Size = New System.Drawing.Size(105, 17)
		Me.Label13.TabIndex = 36
		Me.Label13.Text = "Required"
		' 
		'Label2
		' 
		Me.Label2.AllowDrop = True
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Location = New System.Drawing.Point(264, 200)
		Me.Label2.Name = "Label2"
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.Size = New System.Drawing.Size(105, 17)
		Me.Label2.TabIndex = 35
		Me.Label2.Text = "Promised"
		' 
		'Label7
		' 
		Me.Label7.AllowDrop = True
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Location = New System.Drawing.Point(8, 64)
		Me.Label7.Name = "Label7"
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.Size = New System.Drawing.Size(73, 17)
		Me.Label7.TabIndex = 34
		Me.Label7.Text = "By"
		' 
		'Label3
		' 
		Me.Label3.AllowDrop = True
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Location = New System.Drawing.Point(320, 8)
		Me.Label3.Name = "Label3"
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.Size = New System.Drawing.Size(49, 17)
		Me.Label3.TabIndex = 32
		Me.Label3.Text = "Status:"
		' 
		'Label19
		' 
		Me.Label19.AllowDrop = True
		Me.Label19.BackColor = System.Drawing.SystemColors.Control
		Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label19.Location = New System.Drawing.Point(8, 32)
		Me.Label19.Name = "Label19"
		Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label19.Size = New System.Drawing.Size(57, 17)
		Me.Label19.TabIndex = 30
		Me.Label19.Text = "Requested:"
		' 
		'lblChangedBy
		' 
		Me.lblChangedBy.AllowDrop = True
		Me.lblChangedBy.BackColor = System.Drawing.SystemColors.Control
		Me.lblChangedBy.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblChangedBy.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblChangedBy.Location = New System.Drawing.Point(320, 64)
		Me.lblChangedBy.Name = "lblChangedBy"
		Me.lblChangedBy.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblChangedBy.Size = New System.Drawing.Size(89, 17)
		Me.lblChangedBy.TabIndex = 28
		Me.lblChangedBy.Text = "By"
		' 
		'Label4
		' 
		Me.Label4.AllowDrop = True
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Location = New System.Drawing.Point(12, 8)
		Me.Label4.Name = "Label4"
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.Size = New System.Drawing.Size(49, 17)
		Me.Label4.TabIndex = 27
		Me.Label4.Text = "Order Id:"
		' 
		'lblChanged
		' 
		Me.lblChanged.AllowDrop = True
		Me.lblChanged.BackColor = System.Drawing.SystemColors.Control
		Me.lblChanged.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblChanged.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblChanged.Location = New System.Drawing.Point(320, 36)
		Me.lblChanged.Name = "lblChanged"
		Me.lblChanged.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblChanged.Size = New System.Drawing.Size(89, 17)
		Me.lblChanged.TabIndex = 26
		Me.lblChanged.Text = "Changed:"
		' 
		'Label12
		' 
		Me.Label12.AllowDrop = True
		Me.Label12.BackColor = System.Drawing.SystemColors.Control
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label12.Location = New System.Drawing.Point(8, 432)
		Me.Label12.Name = "Label12"
		Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label12.Size = New System.Drawing.Size(89, 17)
		Me.Label12.TabIndex = 22
		Me.Label12.Text = "Freight"
		' 
		'Label11
		' 
		Me.Label11.AllowDrop = True
		Me.Label11.BackColor = System.Drawing.SystemColors.Control
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label11.Location = New System.Drawing.Point(8, 456)
		Me.Label11.Name = "Label11"
		Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label11.Size = New System.Drawing.Size(89, 17)
		Me.Label11.TabIndex = 20
		Me.Label11.Text = "Total:"
		' 
		'Label10
		' 
		Me.Label10.AllowDrop = True
		Me.Label10.BackColor = System.Drawing.SystemColors.Control
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label10.Location = New System.Drawing.Point(288, 408)
		Me.Label10.Name = "Label10"
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.Size = New System.Drawing.Size(89, 17)
		Me.Label10.TabIndex = 18
		Me.Label10.Text = "Total Tax:"
		' 
		'Label9
		' 
		Me.Label9.AllowDrop = True
		Me.Label9.BackColor = System.Drawing.SystemColors.Control
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Location = New System.Drawing.Point(288, 432)
		Me.Label9.Name = "Label9"
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.Size = New System.Drawing.Size(89, 17)
		Me.Label9.TabIndex = 16
		Me.Label9.Text = "Sub Total:"
		' 
		'Label8
		' 
		Me.Label8.AllowDrop = True
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Location = New System.Drawing.Point(8, 408)
		Me.Label8.Name = "Label8"
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.Size = New System.Drawing.Size(89, 17)
		Me.Label8.TabIndex = 15
		Me.Label8.Text = "Sales Tax:"
		' 
		'Label6
		' 
		Me.Label6.AllowDrop = True
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Location = New System.Drawing.Point(8, 160)
		Me.Label6.Name = "Label6"
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.Size = New System.Drawing.Size(33, 17)
		Me.Label6.TabIndex = 12
		Me.Label6.Text = "Notes:"
		' 
		'frmActionOrderRequest
		' 
		Me.AllowDrop = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6, 13)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScroll = True
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(523, 534)
		Me.Controls.Add(Me.txtPromisedBy)
		Me.Controls.Add(Me.txtRequiredBy)
		Me.Controls.Add(Me.txtReceivedBy)
		Me.Controls.Add(Me.cmdApprove)
		Me.Controls.Add(Me.txtStatus)
		Me.Controls.Add(Me.txtReceived)
		Me.Controls.Add(Me.txtChangedBy)
		Me.Controls.Add(Me.txtChanged)
		Me.Controls.Add(Me.txtOrderID)
		Me.Controls.Add(Me.txtNotes)
		Me.Controls.Add(Me.txtSubTotal)
		Me.Controls.Add(Me.txtTotal)
		Me.Controls.Add(Me.txtTotalTax)
		Me.Controls.Add(Me.txtFreightCharge)
		Me.Controls.Add(Me.txtSalesTax)
		Me.Controls.Add(Me.txtEntry)
		Me.Controls.Add(Me.fgDetails)
		Me.Controls.Add(Me.sbStatusBar)
		Me.Controls.Add(Me.cmdCancel)
		Me.Controls.Add(Me.cmdClose)
		Me.Controls.Add(Me.Frame2)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label19)
		Me.Controls.Add(Me.lblChangedBy)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.lblChanged)
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
		Me.Name = "frmActionOrderRequest"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Create Invoice"
		Me.sbStatusBar.ResumeLayout(False)
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
			AddHandler MyBase.Closed, AddressOf Me.Form_Closed
			AddHandler Me.Activated, AddressOf Me.frmActionOrderRequest_Activated
		End If
	End Sub
#End Region
End Class