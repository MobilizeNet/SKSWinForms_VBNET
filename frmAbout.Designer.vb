<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmAbout
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmAbout
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmAbout)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmAbout
		Dim theInstance As New frmAbout()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "picIcon", "cmdOK", "_Line1_1", "lblDescription", "lblTitle", "_Line1_0", "lblVersion", "lblDisclaimer", "Line1"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents picIcon As System.Windows.Forms.PictureBox
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Private WithEvents _Line1_1 As System.Windows.Forms.Label
	Public WithEvents lblDescription As System.Windows.Forms.Label
	Public WithEvents lblTitle As System.Windows.Forms.Label
	Private WithEvents _Line1_0 As System.Windows.Forms.Label
	Public WithEvents lblVersion As System.Windows.Forms.Label
	Public WithEvents lblDisclaimer As System.Windows.Forms.Label
	Public Line1(1) As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
		Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
		Me.picIcon = New System.Windows.Forms.PictureBox()
		Me.cmdOK = New System.Windows.Forms.Button()
		Me._Line1_1 = New System.Windows.Forms.Label()
		Me.lblDescription = New System.Windows.Forms.Label()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me._Line1_0 = New System.Windows.Forms.Label()
		Me.lblVersion = New System.Windows.Forms.Label()
		Me.lblDisclaimer = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		' 
		'picIcon
		' 
		Me.picIcon.AllowDrop = True
		Me.picIcon.BackColor = System.Drawing.SystemColors.Control
		Me.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picIcon.CausesValidation = True
		Me.picIcon.Dock = System.Windows.Forms.DockStyle.None
		Me.picIcon.Enabled = True
		Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
		Me.picIcon.Location = New System.Drawing.Point(16, 16)
		Me.picIcon.Name = "picIcon"
		Me.picIcon.Size = New System.Drawing.Size(36, 36)
		Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picIcon.TabIndex = 1
		Me.picIcon.TabStop = True
		Me.picIcon.Visible = True
		' 
		'cmdOK
		' 
		Me.cmdOK.AllowDrop = True
		Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOK.Location = New System.Drawing.Point(272, 208)
		Me.cmdOK.Name = "cmdOK"
		Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOK.Size = New System.Drawing.Size(108, 23)
		Me.cmdOK.TabIndex = 0
		Me.cmdOK.Text = "OK"
		Me.cmdOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdOK.UseVisualStyleBackColor = False
		' 
		'_Line1_1
		' 
		Me._Line1_1.AllowDrop = True
		Me._Line1_1.BackColor = System.Drawing.Color.Gray
		Me._Line1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me._Line1_1.Enabled = False
		Me._Line1_1.Location = New System.Drawing.Point(5, 147)
		Me._Line1_1.Name = "_Line1_1"
		Me._Line1_1.Size = New System.Drawing.Size(294, 1)
		Me._Line1_1.Visible = True
		' 
		'lblDescription
		' 
		Me.lblDescription.AllowDrop = True
		Me.lblDescription.AutoSize = True
		Me.lblDescription.BackColor = System.Drawing.SystemColors.Control
		Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDescription.ForeColor = System.Drawing.Color.Black
		Me.lblDescription.Location = New System.Drawing.Point(164, 80)
		Me.lblDescription.Name = "lblDescription"
		Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDescription.Size = New System.Drawing.Size(199, 13)
		Me.lblDescription.TabIndex = 2
		Me.lblDescription.Text = "Order Processing Software by Mobilize.net"
		' 
		'lblTitle
		' 
		Me.lblTitle.AllowDrop = True
		Me.lblTitle.AutoSize = True
		Me.lblTitle.BackColor = System.Drawing.SystemColors.Control
		Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.lblTitle.ForeColor = System.Drawing.Color.Black
		Me.lblTitle.Location = New System.Drawing.Point(163, 24)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTitle.Size = New System.Drawing.Size(122, 13)
		Me.lblTitle.TabIndex = 4
		Me.lblTitle.Text = "Salmon King Seafood"
		' 
		'_Line1_0
		' 
		Me._Line1_0.AllowDrop = True
		Me._Line1_0.BackColor = System.Drawing.Color.White
		Me._Line1_0.Enabled = False
		Me._Line1_0.Location = New System.Drawing.Point(6, 148)
		Me._Line1_0.Name = "_Line1_0"
		Me._Line1_0.Size = New System.Drawing.Size(293, 1)
		Me._Line1_0.Visible = True
		' 
		'lblVersion
		' 
		Me.lblVersion.AllowDrop = True
		Me.lblVersion.AutoSize = True
		Me.lblVersion.BackColor = System.Drawing.SystemColors.Control
		Me.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVersion.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVersion.Location = New System.Drawing.Point(163, 56)
		Me.lblVersion.Name = "lblVersion"
		Me.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVersion.Size = New System.Drawing.Size(137, 13)
		Me.lblVersion.TabIndex = 5
		Me.lblVersion.Text = "Version: Mobilize - WebMAP "
		' 
		'lblDisclaimer
		' 
		Me.lblDisclaimer.AllowDrop = True
		Me.lblDisclaimer.AutoSize = True
		Me.lblDisclaimer.BackColor = System.Drawing.SystemColors.Control
		Me.lblDisclaimer.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDisclaimer.ForeColor = System.Drawing.Color.Black
		Me.lblDisclaimer.Location = New System.Drawing.Point(17, 175)
		Me.lblDisclaimer.Name = "lblDisclaimer"
		Me.lblDisclaimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDisclaimer.Size = New System.Drawing.Size(132, 13)
		Me.lblDisclaimer.TabIndex = 3
		Me.lblDisclaimer.Text = "Copyright 2018 Mobilize.Net"
		' 
		'frmAbout
		' 
		Me.AcceptButton = Me.cmdOK
		Me.AllowDrop = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6, 13)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.CancelButton = Me.cmdOK
		Me.ClientSize = New System.Drawing.Size(394, 237)
		Me.Controls.Add(Me.picIcon)
		Me.Controls.Add(Me.cmdOK)
		Me.Controls.Add(Me._Line1_1)
		Me.Controls.Add(Me.lblDescription)
		Me.Controls.Add(Me.lblTitle)
		Me.Controls.Add(Me._Line1_0)
		Me.Controls.Add(Me.lblVersion)
		Me.Controls.Add(Me.lblDisclaimer)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Location = New System.Drawing.Point(156, 129)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmAbout"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = False
		Me.Text = "About Salmon King Seafood"
		Me.ResumeLayout(False)
	End Sub
	Sub ReLoadForm(ByVal addEvents As Boolean)
		InitializeLine1()
		Form_Load()
		If addEvents Then
			AddHandler MyBase.Closed, AddressOf Me.Form_Closed
			AddHandler Me.Activated, AddressOf Me.frmAbout_Activated
		End If
	End Sub
	Sub InitializeLine1()
		ReDim Line1(1)
		Me.Line1(1) = _Line1_1
		Me.Line1(0) = _Line1_0
	End Sub
#End Region
End Class