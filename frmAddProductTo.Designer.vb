<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddProductTo
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmAddProductTo
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmAddProductTo
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmAddProductTo)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmAddProductTo
		Dim theInstance As New frmAddProductTo()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "chkAll", "cmdRemove", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdClose", "cmdSave", "cmdProducts", "txtName", "txtCode", "lvProducts_ColumnHeader_1_", "lvProducts_ColumnHeader_2_", "lvProducts_ColumnHeader_3_", "lvProducts_ColumnHeader_4_", "lvProducts_ColumnHeader_5_", "lvProducts_ColumnHeader_6_", "lvProducts_ColumnHeader_7_", "lvProducts", "Label4", "Label5", "Frame1", "lvProductsBy_ColumnHeader_1_", "lvProductsBy_ColumnHeader_2_", "lvProductsBy_ColumnHeader_3_", "lvProductsBy_ColumnHeader_4_", "lvProductsBy", "lblProductsRelated", "listViewHelper1"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents chkAll As System.Windows.Forms.CheckBox
	Public WithEvents cmdRemove As System.Windows.Forms.Button
	Public WithEvents sbStatusBar_Panels_Panel1 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents sbStatusBar As System.Windows.Forms.StatusStrip
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents cmdProducts As System.Windows.Forms.Button
	Public WithEvents txtName As System.Windows.Forms.TextBox
	Public WithEvents txtCode As System.Windows.Forms.TextBox
	Public WithEvents lvProducts_ColumnHeader_1_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProducts_ColumnHeader_2_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProducts_ColumnHeader_3_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProducts_ColumnHeader_4_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProducts_ColumnHeader_5_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProducts_ColumnHeader_6_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProducts_ColumnHeader_7_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProducts As System.Windows.Forms.ListView
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents lvProductsBy_ColumnHeader_1_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProductsBy_ColumnHeader_2_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProductsBy_ColumnHeader_3_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProductsBy_ColumnHeader_4_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lvProductsBy As System.Windows.Forms.ListView
	Public WithEvents lblProductsRelated As System.Windows.Forms.Label
	Public listViewHelper1 As UpgradeHelpers.Gui.ListViewHelper
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmAddProductTo))
		Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
		Me.chkAll = New System.Windows.Forms.CheckBox()
		Me.cmdRemove = New System.Windows.Forms.Button()
		Me.sbStatusBar = New System.Windows.Forms.StatusStrip()
		Me.sbStatusBar_Panels_Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.cmdClose = New System.Windows.Forms.Button()
		Me.cmdSave = New System.Windows.Forms.Button()
		Me.Frame1 = New System.Windows.Forms.GroupBox()
		Me.cmdProducts = New System.Windows.Forms.Button()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.txtCode = New System.Windows.Forms.TextBox()
		Me.lvProducts = New System.Windows.Forms.ListView()
		Me.lvProducts_ColumnHeader_1_ = New System.Windows.Forms.ColumnHeader()
		Me.lvProducts_ColumnHeader_2_ = New System.Windows.Forms.ColumnHeader()
		Me.lvProducts_ColumnHeader_3_ = New System.Windows.Forms.ColumnHeader()
		Me.lvProducts_ColumnHeader_4_ = New System.Windows.Forms.ColumnHeader()
		Me.lvProducts_ColumnHeader_5_ = New System.Windows.Forms.ColumnHeader()
		Me.lvProducts_ColumnHeader_6_ = New System.Windows.Forms.ColumnHeader()
		Me.lvProducts_ColumnHeader_7_ = New System.Windows.Forms.ColumnHeader()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.lvProductsBy = New System.Windows.Forms.ListView()
		Me.lvProductsBy_ColumnHeader_1_ = New System.Windows.Forms.ColumnHeader()
		Me.lvProductsBy_ColumnHeader_2_ = New System.Windows.Forms.ColumnHeader()
		Me.lvProductsBy_ColumnHeader_3_ = New System.Windows.Forms.ColumnHeader()
		Me.lvProductsBy_ColumnHeader_4_ = New System.Windows.Forms.ColumnHeader()
		Me.lblProductsRelated = New System.Windows.Forms.Label()
		Me.sbStatusBar.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.lvProducts.SuspendLayout()
		Me.lvProductsBy.SuspendLayout()
		Me.SuspendLayout()
		Me.listViewHelper1 = New UpgradeHelpers.Gui.ListViewHelper(Me.components)
		Me.listViewHelper1.BeginInit()
		' 
		'chkAll
		' 
		Me.chkAll.AllowDrop = True
		Me.chkAll.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkAll.BackColor = System.Drawing.SystemColors.Control
		Me.chkAll.CausesValidation = True
		Me.chkAll.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkAll.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkAll.Enabled = True
		Me.chkAll.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkAll.Location = New System.Drawing.Point(112, 454)
		Me.chkAll.Name = "chkAll"
		Me.chkAll.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkAll.Size = New System.Drawing.Size(81, 17)
		Me.chkAll.TabIndex = 13
		Me.chkAll.TabStop = False
		Me.chkAll.Text = "Check All"
		Me.chkAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkAll.Visible = True
		' 
		'cmdRemove
		' 
		Me.cmdRemove.AllowDrop = True
		Me.cmdRemove.BackColor = System.Drawing.SystemColors.Control
		Me.cmdRemove.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdRemove.Location = New System.Drawing.Point(8, 448)
		Me.cmdRemove.Name = "cmdRemove"
		Me.cmdRemove.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdRemove.Size = New System.Drawing.Size(97, 25)
		Me.cmdRemove.TabIndex = 12
		Me.cmdRemove.TabStop = False
		Me.cmdRemove.Text = "&Remove "
		Me.cmdRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdRemove.UseVisualStyleBackColor = False
		' 
		'sbStatusBar
		' 
		Me.sbStatusBar.AllowDrop = True
		Me.sbStatusBar.BackColor = System.Drawing.SystemColors.Control
		Me.sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.sbStatusBar.Location = New System.Drawing.Point(0, 488)
		Me.sbStatusBar.Name = "sbStatusBar"
		Me.sbStatusBar.ShowItemToolTips = True
		Me.sbStatusBar.Size = New System.Drawing.Size(424, 23)
		Me.sbStatusBar.TabIndex = 11
		Me.sbStatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbStatusBar_Panels_Panel1})
		' 
		'sbStatusBar_Panels_Panel1
		' 
		Me.sbStatusBar_Panels_Panel1.BorderSides = CType(System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom, System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.sbStatusBar_Panels_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.sbStatusBar_Panels_Panel1.DoubleClickEnabled = True
		Me.sbStatusBar_Panels_Panel1.Margin = New System.Windows.Forms.Padding(0)
		Me.sbStatusBar_Panels_Panel1.Size = New System.Drawing.Size(423, 23)
		Me.sbStatusBar_Panels_Panel1.Spring = True
		Me.sbStatusBar_Panels_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.sbStatusBar_Panels_Panel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		' 
		'cmdClose
		' 
		Me.cmdClose.AllowDrop = True
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Location = New System.Drawing.Point(328, 448)
		Me.cmdClose.Name = "cmdClose"
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.Size = New System.Drawing.Size(89, 25)
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
		Me.cmdSave.Location = New System.Drawing.Point(224, 448)
		Me.cmdSave.Name = "cmdSave"
		Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSave.Size = New System.Drawing.Size(89, 25)
		Me.cmdSave.TabIndex = 6
		Me.cmdSave.Text = "&Save"
		Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdSave.UseVisualStyleBackColor = False
		' 
		'Frame1
		' 
		Me.Frame1.AllowDrop = True
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Controls.Add(Me.cmdProducts)
		Me.Frame1.Controls.Add(Me.txtName)
		Me.Frame1.Controls.Add(Me.txtCode)
		Me.Frame1.Controls.Add(Me.lvProducts)
		Me.Frame1.Controls.Add(Me.Label4)
		Me.Frame1.Controls.Add(Me.Label5)
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.Location = New System.Drawing.Point(8, 8)
		Me.Frame1.Name = "Frame1"
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Size = New System.Drawing.Size(409, 233)
		Me.Frame1.TabIndex = 4
		Me.Frame1.Text = "Search product "
		Me.Frame1.Visible = True
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
		Me.cmdProducts.TabIndex = 5
		Me.cmdProducts.TabStop = False
		Me.cmdProducts.Text = "..."
		Me.cmdProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdProducts.UseVisualStyleBackColor = False
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
		Me.lvProducts.Location = New System.Drawing.Point(8, 64)
		Me.lvProducts.MultiSelect = False
		Me.lvProducts.Name = "lvProducts"
		Me.lvProducts.Size = New System.Drawing.Size(393, 161)
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
		Me.lvProducts_ColumnHeader_6_.Text = "Qty per Unit"
		Me.lvProducts_ColumnHeader_6_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.lvProducts_ColumnHeader_6_.Width = 97
		' 
		'lvProducts_ColumnHeader_7_
		' 
		Me.lvProducts_ColumnHeader_7_.Text = "Unit"
		Me.lvProducts_ColumnHeader_7_.Width = 97
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
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "Name"
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
		Me.Label5.TabIndex = 8
		Me.Label5.Text = "Code"
		' 
		'lvProductsBy
		' 
		Me.lvProductsBy.AllowDrop = True
		Me.lvProductsBy.BackColor = System.Drawing.SystemColors.Window
		Me.lvProductsBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lvProductsBy.CheckBoxes = True
		Me.lvProductsBy.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lvProductsBy.FullRowSelect = True
		Me.lvProductsBy.GridLines = True
		Me.lvProductsBy.HideSelection = False
		Me.lvProductsBy.HotTracking = True
		Me.lvProductsBy.LabelEdit = False
		Me.lvProductsBy.Location = New System.Drawing.Point(8, 272)
		Me.lvProductsBy.MultiSelect = False
		Me.lvProductsBy.Name = "lvProductsBy"
		Me.lvProductsBy.Size = New System.Drawing.Size(409, 169)
		Me.lvProductsBy.TabIndex = 3
		Me.lvProductsBy.View = System.Windows.Forms.View.Details
		Me.lvProductsBy.Columns.Add(Me.lvProductsBy_ColumnHeader_1_)
		Me.lvProductsBy.Columns.Add(Me.lvProductsBy_ColumnHeader_2_)
		Me.lvProductsBy.Columns.Add(Me.lvProductsBy_ColumnHeader_3_)
		Me.lvProductsBy.Columns.Add(Me.lvProductsBy_ColumnHeader_4_)
		' 
		'lvProductsBy_ColumnHeader_1_
		' 
		Me.lvProductsBy_ColumnHeader_1_.Text = "Code"
		Me.lvProductsBy_ColumnHeader_1_.Width = 97
		' 
		'lvProductsBy_ColumnHeader_2_
		' 
		Me.lvProductsBy_ColumnHeader_2_.Text = "Name"
		Me.lvProductsBy_ColumnHeader_2_.Width = 97
		' 
		'lvProductsBy_ColumnHeader_3_
		' 
		Me.lvProductsBy_ColumnHeader_3_.Text = "Price"
		Me.lvProductsBy_ColumnHeader_3_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.lvProductsBy_ColumnHeader_3_.Width = 61
		' 
		'lvProductsBy_ColumnHeader_4_
		' 
		Me.lvProductsBy_ColumnHeader_4_.Text = "Quantity per Unit"
		Me.lvProductsBy_ColumnHeader_4_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.lvProductsBy_ColumnHeader_4_.Width = 94
		' 
		'lblProductsRelated
		' 
		Me.lblProductsRelated.AllowDrop = True
		Me.lblProductsRelated.BackColor = System.Drawing.SystemColors.Control
		Me.lblProductsRelated.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblProductsRelated.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblProductsRelated.Location = New System.Drawing.Point(8, 248)
		Me.lblProductsRelated.Name = "lblProductsRelated"
		Me.lblProductsRelated.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblProductsRelated.Size = New System.Drawing.Size(409, 17)
		Me.lblProductsRelated.TabIndex = 10
		Me.lblProductsRelated.Text = "Products"
		' 
		'frmAddProductTo
		' 
		Me.AllowDrop = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6, 13)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(424, 511)
		Me.Controls.Add(Me.chkAll)
		Me.Controls.Add(Me.cmdRemove)
		Me.Controls.Add(Me.sbStatusBar)
		Me.Controls.Add(Me.cmdClose)
		Me.Controls.Add(Me.cmdSave)
		Me.Controls.Add(Me.Frame1)
		Me.Controls.Add(Me.lvProductsBy)
		Me.Controls.Add(Me.lblProductsRelated)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Location = New System.Drawing.Point(3, 25)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmAddProductTo"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text = "Create New Product Item"
		Me.listViewHelper1.SetItemClickMethod(Me.lvProducts, "lvProducts_ItemClick")
		Me.listViewHelper1.SetCorrectEventsBehavior(Me.lvProducts, True)
		Me.listViewHelper1.EndInit()
		Me.sbStatusBar.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.lvProducts.ResumeLayout(False)
		Me.lvProductsBy.ResumeLayout(False)
		Me.ResumeLayout(False)
	End Sub
	Sub ReLoadForm(ByVal addEvents As Boolean)
		If addEvents Then
			AddHandler MyBase.FormClosing, AddressOf Me.Form_FormClosing
			AddHandler MyBase.Closed, AddressOf Me.Form_Closed
			AddHandler Me.Activated, AddressOf Me.frmAddProductTo_Activated
		End If
	End Sub
#End Region
End Class