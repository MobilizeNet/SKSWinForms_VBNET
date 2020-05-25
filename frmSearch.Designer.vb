<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmSearch
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmSearch
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmSearch)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmSearch
		Dim theInstance As New frmSearch()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "cmdClose", "cmdSearch", "ctrlLiner1", "cboSrchBy", "txtSrchStr", "Label20", "Label19", "Image3", "Label1", "lblSrchBy"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents cmdSearch As System.Windows.Forms.Button
	Public WithEvents ctrlLiner1 As System.Windows.Forms.PictureBox
	Public WithEvents cboSrchBy As System.Windows.Forms.ComboBox
	Public WithEvents txtSrchStr As System.Windows.Forms.TextBox
	Public WithEvents Label20 As System.Windows.Forms.Label
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents Image3 As System.Windows.Forms.PictureBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents lblSrchBy As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
		Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
		Me.cmdClose = New System.Windows.Forms.Button()
		Me.cmdSearch = New System.Windows.Forms.Button()
		Me.ctrlLiner1 = New System.Windows.Forms.PictureBox()
		Me.cboSrchBy = New System.Windows.Forms.ComboBox()
		Me.txtSrchStr = New System.Windows.Forms.TextBox()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.Image3 = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblSrchBy = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		' 
		'cmdClose
		' 
		Me.cmdClose.AllowDrop = True
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Location = New System.Drawing.Point(272, 104)
		Me.cmdClose.Name = "cmdClose"
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.Size = New System.Drawing.Size(81, 25)
		Me.cmdClose.TabIndex = 8
		Me.cmdClose.Text = "&Close"
		Me.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdClose.UseVisualStyleBackColor = False
		' 
		'cmdSearch
		' 
		Me.cmdSearch.AllowDrop = True
		Me.cmdSearch.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSearch.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSearch.Location = New System.Drawing.Point(184, 104)
		Me.cmdSearch.Name = "cmdSearch"
		Me.cmdSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSearch.Size = New System.Drawing.Size(81, 25)
		Me.cmdSearch.TabIndex = 7
		Me.cmdSearch.Text = "&Search"
		Me.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdSearch.UseVisualStyleBackColor = False
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
		Me.ctrlLiner1.Size = New System.Drawing.Size(385, 2)
		Me.ctrlLiner1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.ctrlLiner1.TabIndex = 6
		Me.ctrlLiner1.TabStop = True
		Me.ctrlLiner1.Visible = True
		' 
		'cboSrchBy
		' 
		Me.cboSrchBy.AllowDrop = True
		Me.cboSrchBy.BackColor = System.Drawing.SystemColors.Window
		Me.cboSrchBy.CausesValidation = True
		Me.cboSrchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboSrchBy.Enabled = True
		Me.cboSrchBy.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboSrchBy.IntegralHeight = True
		Me.cboSrchBy.Location = New System.Drawing.Point(208, 144)
		Me.cboSrchBy.Name = "cboSrchBy"
		Me.cboSrchBy.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboSrchBy.Size = New System.Drawing.Size(145, 21)
		Me.cboSrchBy.Sorted = False
		Me.cboSrchBy.TabIndex = 3
		Me.cboSrchBy.TabStop = True
		Me.cboSrchBy.Visible = True
		' 
		'txtSrchStr
		' 
		Me.txtSrchStr.AcceptsReturn = True
		Me.txtSrchStr.AllowDrop = True
		Me.txtSrchStr.BackColor = System.Drawing.SystemColors.Window
		Me.txtSrchStr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSrchStr.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSrchStr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSrchStr.Location = New System.Drawing.Point(136, 72)
		Me.txtSrchStr.MaxLength = 0
		Me.txtSrchStr.Name = "txtSrchStr"
		Me.txtSrchStr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSrchStr.Size = New System.Drawing.Size(217, 19)
		Me.txtSrchStr.TabIndex = 0
		' 
		'Label20
		' 
		Me.Label20.AllowDrop = True
		Me.Label20.AutoSize = True
		Me.Label20.BackColor = System.Drawing.Color.Transparent
		Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label20.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
		Me.Label20.Location = New System.Drawing.Point(49, 32)
		Me.Label20.Name = "Label20"
		Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label20.Size = New System.Drawing.Size(119, 13)
		Me.Label20.TabIndex = 5
		Me.Label20.Text = "Search for a specific item"
		' 
		'Label19
		' 
		Me.Label19.AllowDrop = True
		Me.Label19.AutoSize = True
		Me.Label19.BackColor = System.Drawing.Color.Transparent
		Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.Label19.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
		Me.Label19.Location = New System.Drawing.Point(49, 8)
		Me.Label19.Name = "Label19"
		Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label19.Size = New System.Drawing.Size(50, 16)
		Me.Label19.TabIndex = 4
		Me.Label19.Text = "Search"
		Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'Image3
		' 
		Me.Image3.AllowDrop = True
		Me.Image3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image3.Enabled = True
		Me.Image3.Image = CType(resources.GetObject("Image3.Image"), System.Drawing.Image)
		Me.Image3.Location = New System.Drawing.Point(8, 8)
		Me.Image3.Name = "Image3"
		Me.Image3.Size = New System.Drawing.Size(16, 16)
		Me.Image3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Image3.Visible = True
		' 
		'Label1
		' 
		Me.Label1.AllowDrop = True
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
		Me.Label1.Location = New System.Drawing.Point(125, 144)
		Me.Label1.Name = "Label1"
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.Size = New System.Drawing.Size(62, 13)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Search by:"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'lblSrchBy
		' 
		Me.lblSrchBy.AllowDrop = True
		Me.lblSrchBy.AutoSize = True
		Me.lblSrchBy.BackColor = System.Drawing.SystemColors.Control
		Me.lblSrchBy.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSrchBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.lblSrchBy.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
		Me.lblSrchBy.Location = New System.Drawing.Point(7, 72)
		Me.lblSrchBy.Name = "lblSrchBy"
		Me.lblSrchBy.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSrchBy.Size = New System.Drawing.Size(116, 13)
		Me.lblSrchBy.TabIndex = 1
		Me.lblSrchBy.Text = "Field"
		Me.lblSrchBy.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'frmSearch
		' 
		Me.AllowDrop = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6, 13)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(378, 173)
		Me.Controls.Add(Me.cmdClose)
		Me.Controls.Add(Me.cmdSearch)
		Me.Controls.Add(Me.ctrlLiner1)
		Me.Controls.Add(Me.cboSrchBy)
		Me.Controls.Add(Me.txtSrchStr)
		Me.Controls.Add(Me.Label20)
		Me.Controls.Add(Me.Label19)
		Me.Controls.Add(Me.Image3)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.lblSrchBy)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = CType(resources.GetObject("frmSearch.Icon"), System.Drawing.Icon)
		Me.Location = New System.Drawing.Point(486, 322)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmSearch"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Search"
		Me.ResumeLayout(False)
	End Sub
	Sub ReLoadForm(ByVal addEvents As Boolean)
		If addEvents Then
			AddHandler MyBase.Closed, AddressOf Me.Form_Closed
			AddHandler Me.Activated, AddressOf Me.frmSearch_Activated
		End If
	End Sub
#End Region
End Class