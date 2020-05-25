<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsersManage
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmUsersManage
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmUsersManage
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmUsersManage)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmUsersManage
		Dim theInstance As New frmUsersManage()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "lstAccounts_ColumnHeader_1_", "lstAccounts_ColumnHeader_2_", "lstAccounts_ColumnHeader_3_", "lstAccounts", "cmdClear", "cmdSave", "ctrlLiner1", "txtFullname", "txtPassword", "txtUsername", "cboLevel", "_Label1_2", "_Label1_0", "_Label1_1", "_Label1_3", "lblId", "Frame1", "cmdClose", "cmdEdit", "cmdDelete", "_Label1_4", "Label19", "Label4", "Image1", "Label1", "listViewHelper1"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents lstAccounts_ColumnHeader_1_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lstAccounts_ColumnHeader_2_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lstAccounts_ColumnHeader_3_ As System.Windows.Forms.ColumnHeader
	Public WithEvents lstAccounts As System.Windows.Forms.ListView
	Public WithEvents cmdClear As System.Windows.Forms.Button
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents ctrlLiner1 As System.Windows.Forms.PictureBox
	Public WithEvents txtFullname As System.Windows.Forms.TextBox
	Public WithEvents txtPassword As System.Windows.Forms.TextBox
	Public WithEvents txtUsername As System.Windows.Forms.TextBox
	Public WithEvents cboLevel As System.Windows.Forms.ComboBox
	Private WithEvents _Label1_2 As System.Windows.Forms.Label
	Private WithEvents _Label1_0 As System.Windows.Forms.Label
	Private WithEvents _Label1_1 As System.Windows.Forms.Label
	Private WithEvents _Label1_3 As System.Windows.Forms.Label
	Public WithEvents lblId As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents cmdEdit As System.Windows.Forms.Button
	Public WithEvents cmdDelete As System.Windows.Forms.Button
	Private WithEvents _Label1_4 As System.Windows.Forms.Label
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	Public Label1(4) As System.Windows.Forms.Label
	Public listViewHelper1 As UpgradeHelpers.Gui.ListViewHelper
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmUsersManage))
		Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
		Me.lstAccounts = New System.Windows.Forms.ListView()
		Me.lstAccounts_ColumnHeader_1_ = New System.Windows.Forms.ColumnHeader()
		Me.lstAccounts_ColumnHeader_2_ = New System.Windows.Forms.ColumnHeader()
		Me.lstAccounts_ColumnHeader_3_ = New System.Windows.Forms.ColumnHeader()
		Me.cmdClear = New System.Windows.Forms.Button()
		Me.cmdSave = New System.Windows.Forms.Button()
		Me.ctrlLiner1 = New System.Windows.Forms.PictureBox()
		Me.Frame1 = New System.Windows.Forms.GroupBox()
		Me.txtFullname = New System.Windows.Forms.TextBox()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.txtUsername = New System.Windows.Forms.TextBox()
		Me.cboLevel = New System.Windows.Forms.ComboBox()
		Me._Label1_2 = New System.Windows.Forms.Label()
		Me._Label1_0 = New System.Windows.Forms.Label()
		Me._Label1_1 = New System.Windows.Forms.Label()
		Me._Label1_3 = New System.Windows.Forms.Label()
		Me.lblId = New System.Windows.Forms.Label()
		Me.cmdClose = New System.Windows.Forms.Button()
		Me.cmdEdit = New System.Windows.Forms.Button()
		Me.cmdDelete = New System.Windows.Forms.Button()
		Me._Label1_4 = New System.Windows.Forms.Label()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Image1 = New System.Windows.Forms.PictureBox()
		Me.lstAccounts.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.listViewHelper1 = New UpgradeHelpers.Gui.ListViewHelper(Me.components)
		Me.listViewHelper1.BeginInit()
		' 
		'lstAccounts
		' 
		Me.lstAccounts.AllowDrop = True
		Me.lstAccounts.BackColor = System.Drawing.SystemColors.Window
		Me.lstAccounts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstAccounts.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstAccounts.FullRowSelect = True
		Me.lstAccounts.HideSelection = True
		Me.lstAccounts.LabelEdit = True
		Me.lstAccounts.Location = New System.Drawing.Point(0, 264)
		Me.lstAccounts.MultiSelect = False
		Me.lstAccounts.Name = "lstAccounts"
		Me.lstAccounts.Size = New System.Drawing.Size(337, 113)
		Me.lstAccounts.TabIndex = 7
		Me.lstAccounts.View = System.Windows.Forms.View.Details
		Me.lstAccounts.Columns.Add(Me.lstAccounts_ColumnHeader_1_)
		Me.lstAccounts.Columns.Add(Me.lstAccounts_ColumnHeader_2_)
		Me.lstAccounts.Columns.Add(Me.lstAccounts_ColumnHeader_3_)
		' 
		'lstAccounts_ColumnHeader_1_
		' 
		Me.lstAccounts_ColumnHeader_1_.Text = "UserId"
		Me.lstAccounts_ColumnHeader_1_.Width = 97
		' 
		'lstAccounts_ColumnHeader_2_
		' 
		Me.lstAccounts_ColumnHeader_2_.Text = "Name"
		Me.lstAccounts_ColumnHeader_2_.Width = 97
		' 
		'lstAccounts_ColumnHeader_3_
		' 
		Me.lstAccounts_ColumnHeader_3_.Text = "Level"
		Me.lstAccounts_ColumnHeader_3_.Width = 97
		' 
		'cmdClear
		' 
		Me.cmdClear.AllowDrop = True
		Me.cmdClear.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClear.Location = New System.Drawing.Point(168, 232)
		Me.cmdClear.Name = "cmdClear"
		Me.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClear.Size = New System.Drawing.Size(81, 25)
		Me.cmdClear.TabIndex = 5
		Me.cmdClear.Text = "&New"
		Me.cmdClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdClear.UseVisualStyleBackColor = False
		' 
		'cmdSave
		' 
		Me.cmdSave.AllowDrop = True
		Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSave.Location = New System.Drawing.Point(80, 232)
		Me.cmdSave.Name = "cmdSave"
		Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSave.Size = New System.Drawing.Size(81, 25)
		Me.cmdSave.TabIndex = 4
		Me.cmdSave.Text = "&Save"
		Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdSave.UseVisualStyleBackColor = False
		' 
		'ctrlLiner1
		' 
		Me.ctrlLiner1.AllowDrop = True
		Me.ctrlLiner1.BackColor = System.Drawing.SystemColors.Control
		Me.ctrlLiner1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.ctrlLiner1.CausesValidation = True
		Me.ctrlLiner1.Dock = System.Windows.Forms.DockStyle.None
		Me.ctrlLiner1.Enabled = True
		Me.ctrlLiner1.Location = New System.Drawing.Point(0, 56)
		Me.ctrlLiner1.Name = "ctrlLiner1"
		Me.ctrlLiner1.Size = New System.Drawing.Size(313, 2)
		Me.ctrlLiner1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.ctrlLiner1.TabIndex = 15
		Me.ctrlLiner1.TabStop = True
		Me.ctrlLiner1.Visible = True
		' 
		'Frame1
		' 
		Me.Frame1.AllowDrop = True
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Controls.Add(Me.txtFullname)
		Me.Frame1.Controls.Add(Me.txtPassword)
		Me.Frame1.Controls.Add(Me.txtUsername)
		Me.Frame1.Controls.Add(Me.cboLevel)
		Me.Frame1.Controls.Add(Me._Label1_2)
		Me.Frame1.Controls.Add(Me._Label1_0)
		Me.Frame1.Controls.Add(Me._Label1_1)
		Me.Frame1.Controls.Add(Me._Label1_3)
		Me.Frame1.Controls.Add(Me.lblId)
		Me.Frame1.Enabled = True
		Me.Frame1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.Location = New System.Drawing.Point(8, 64)
		Me.Frame1.Name = "Frame1"
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Size = New System.Drawing.Size(329, 153)
		Me.Frame1.TabIndex = 10
		Me.Frame1.Text = "User information"
		Me.Frame1.Visible = True
		' 
		'txtFullname
		' 
		Me.txtFullname.AcceptsReturn = True
		Me.txtFullname.AllowDrop = True
		Me.txtFullname.BackColor = System.Drawing.SystemColors.Window
		Me.txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtFullname.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtFullname.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtFullname.ImeMode = System.Windows.Forms.ImeMode.Disable
		Me.txtFullname.Location = New System.Drawing.Point(120, 88)
		Me.txtFullname.MaxLength = 50
		Me.txtFullname.Name = "txtFullname"
		Me.txtFullname.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtFullname.Size = New System.Drawing.Size(193, 19)
		Me.txtFullname.TabIndex = 2
		' 
		'txtPassword
		' 
		Me.txtPassword.AcceptsReturn = True
		Me.txtPassword.AllowDrop = True
		Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
		Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPassword.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable
		Me.txtPassword.Location = New System.Drawing.Point(120, 56)
		Me.txtPassword.MaxLength = 50
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(108)
		Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPassword.Size = New System.Drawing.Size(193, 19)
		Me.txtPassword.TabIndex = 1
		' 
		'txtUsername
		' 
		Me.txtUsername.AcceptsReturn = True
		Me.txtUsername.AllowDrop = True
		Me.txtUsername.BackColor = System.Drawing.SystemColors.Window
		Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtUsername.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtUsername.Location = New System.Drawing.Point(120, 24)
		Me.txtUsername.MaxLength = 50
		Me.txtUsername.Name = "txtUsername"
		Me.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtUsername.Size = New System.Drawing.Size(193, 19)
		Me.txtUsername.TabIndex = 0
		' 
		'cboLevel
		' 
		Me.cboLevel.AllowDrop = True
		Me.cboLevel.BackColor = System.Drawing.SystemColors.Window
		Me.cboLevel.CausesValidation = True
		Me.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboLevel.Enabled = True
		Me.cboLevel.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboLevel.IntegralHeight = True
		Me.cboLevel.Location = New System.Drawing.Point(120, 120)
		Me.cboLevel.Name = "cboLevel"
		Me.cboLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboLevel.Size = New System.Drawing.Size(193, 21)
		Me.cboLevel.Sorted = False
		Me.cboLevel.TabIndex = 3
		Me.cboLevel.TabStop = True
		Me.cboLevel.Visible = True
		' 
		'_Label1_2
		' 
		Me._Label1_2.AllowDrop = True
		Me._Label1_2.AutoSize = True
		Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
		Me._Label1_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me._Label1_2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
		Me._Label1_2.Location = New System.Drawing.Point(16, 88)
		Me._Label1_2.Name = "_Label1_2"
		Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_2.Size = New System.Drawing.Size(68, 13)
		Me._Label1_2.TabIndex = 16
		Me._Label1_2.Text = "Full name: *"
		' 
		'_Label1_0
		' 
		Me._Label1_0.AllowDrop = True
		Me._Label1_0.AutoSize = True
		Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
		Me._Label1_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me._Label1_0.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
		Me._Label1_0.Location = New System.Drawing.Point(16, 32)
		Me._Label1_0.Name = "_Label1_0"
		Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_0.Size = New System.Drawing.Size(70, 13)
		Me._Label1_0.TabIndex = 14
		Me._Label1_0.Text = "Username: *"
		' 
		'_Label1_1
		' 
		Me._Label1_1.AllowDrop = True
		Me._Label1_1.AutoSize = True
		Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
		Me._Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me._Label1_1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
		Me._Label1_1.Location = New System.Drawing.Point(16, 56)
		Me._Label1_1.Name = "_Label1_1"
		Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_1.Size = New System.Drawing.Size(96, 13)
		Me._Label1_1.TabIndex = 13
		Me._Label1_1.Text = "New password: *"
		' 
		'_Label1_3
		' 
		Me._Label1_3.AllowDrop = True
		Me._Label1_3.AutoSize = True
		Me._Label1_3.BackColor = System.Drawing.SystemColors.Control
		Me._Label1_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me._Label1_3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
		Me._Label1_3.Location = New System.Drawing.Point(16, 120)
		Me._Label1_3.Name = "_Label1_3"
		Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_3.Size = New System.Drawing.Size(71, 13)
		Me._Label1_3.TabIndex = 12
		Me._Label1_3.Text = "User level: *"
		' 
		'lblId
		' 
		Me.lblId.AllowDrop = True
		Me.lblId.AutoSize = True
		Me.lblId.BackColor = System.Drawing.SystemColors.Control
		Me.lblId.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.lblId.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
		Me.lblId.Location = New System.Drawing.Point(128, 24)
		Me.lblId.Name = "lblId"
		Me.lblId.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblId.Size = New System.Drawing.Size(3, 13)
		Me.lblId.TabIndex = 11
		' 
		'cmdClose
		' 
		Me.cmdClose.AllowDrop = True
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Location = New System.Drawing.Point(256, 232)
		Me.cmdClose.Name = "cmdClose"
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.Size = New System.Drawing.Size(81, 25)
		Me.cmdClose.TabIndex = 6
		Me.cmdClose.Text = "&Close"
		Me.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdClose.UseVisualStyleBackColor = False
		' 
		'cmdEdit
		' 
		Me.cmdEdit.AllowDrop = True
		Me.cmdEdit.BackColor = System.Drawing.SystemColors.Control
		Me.cmdEdit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdEdit.Location = New System.Drawing.Point(168, 384)
		Me.cmdEdit.Name = "cmdEdit"
		Me.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdEdit.Size = New System.Drawing.Size(81, 25)
		Me.cmdEdit.TabIndex = 8
		Me.cmdEdit.Text = "&Edit"
		Me.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdEdit.UseVisualStyleBackColor = False
		' 
		'cmdDelete
		' 
		Me.cmdDelete.AllowDrop = True
		Me.cmdDelete.BackColor = System.Drawing.SystemColors.Control
		Me.cmdDelete.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdDelete.Location = New System.Drawing.Point(256, 384)
		Me.cmdDelete.Name = "cmdDelete"
		Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdDelete.Size = New System.Drawing.Size(81, 25)
		Me.cmdDelete.TabIndex = 9
		Me.cmdDelete.Text = "&Delete"
		Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdDelete.UseVisualStyleBackColor = False
		' 
		'_Label1_4
		' 
		Me._Label1_4.AllowDrop = True
		Me._Label1_4.AutoSize = True
		Me._Label1_4.BackColor = System.Drawing.SystemColors.Control
		Me._Label1_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me._Label1_4.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
		Me._Label1_4.Location = New System.Drawing.Point(8, 392)
		Me._Label1_4.Name = "_Label1_4"
		Me._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_4.Size = New System.Drawing.Size(95, 13)
		Me._Label1_4.TabIndex = 19
		Me._Label1_4.Text = "* Required fields"
		' 
		'Label19
		' 
		Me.Label19.AllowDrop = True
		Me.Label19.AutoSize = True
		Me.Label19.BackColor = System.Drawing.Color.Transparent
		Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.Label19.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
		Me.Label19.Location = New System.Drawing.Point(48, 8)
		Me.Label19.Name = "Label19"
		Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label19.Size = New System.Drawing.Size(34, 16)
		Me.Label19.TabIndex = 18
		Me.Label19.Text = "User"
		Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'Label4
		' 
		Me.Label4.AllowDrop = True
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
		Me.Label4.Location = New System.Drawing.Point(48, 32)
		Me.Label4.Name = "Label4"
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.Size = New System.Drawing.Size(176, 13)
		Me.Label4.TabIndex = 17
		Me.Label4.Text = "Set user information and access level"
		' 
		'Image1
		' 
		Me.Image1.AllowDrop = True
		Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image1.Cursor = New System.Windows.Forms.Cursor((New System.Drawing.Bitmap(CType(resources.GetObject("Image1.Cursor"), System.Drawing.Image))).GetHicon())
		Me.Image1.Enabled = True
		Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
		Me.Image1.Location = New System.Drawing.Point(8, 8)
		Me.Image1.Name = "Image1"
		Me.Image1.Size = New System.Drawing.Size(32, 32)
		Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.Image1.Visible = True
		' 
		'frmUsersManage
		' 
		Me.AllowDrop = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6, 13)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScroll = True
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(341, 414)
		Me.Controls.Add(Me.lstAccounts)
		Me.Controls.Add(Me.cmdClear)
		Me.Controls.Add(Me.cmdSave)
		Me.Controls.Add(Me.ctrlLiner1)
		Me.Controls.Add(Me.Frame1)
		Me.Controls.Add(Me.cmdClose)
		Me.Controls.Add(Me.cmdEdit)
		Me.Controls.Add(Me.cmdDelete)
		Me.Controls.Add(Me._Label1_4)
		Me.Controls.Add(Me.Label19)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Image1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("frmUsersManage.Icon"), System.Drawing.Icon)
		Me.Location = New System.Drawing.Point(327, 144)
		Me.MaximizeBox = False
		Me.MinimizeBox = True
		Me.Name = "frmUsersManage"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Users Management"
		Me.ToolTipMain.SetToolTip(Me.Image1, "View warnings")
		Me.listViewHelper1.SetCorrectEventsBehavior(Me.lstAccounts, True)
		Me.listViewHelper1.EndInit()
		Me.lstAccounts.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
	End Sub
	Sub ReLoadForm(ByVal addEvents As Boolean)
		InitializeLabel1()
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
			AddHandler Me.Activated, AddressOf Me.frmUsersManage_Activated
		End If
	End Sub
	Sub InitializeLabel1()
		ReDim Label1(4)
		Me.Label1(2) = _Label1_2
		Me.Label1(0) = _Label1_0
		Me.Label1(1) = _Label1_1
		Me.Label1(3) = _Label1_3
		Me.Label1(4) = _Label1_4
	End Sub
#End Region
End Class