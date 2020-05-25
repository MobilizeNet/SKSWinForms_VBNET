<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmLogin
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmLogin
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmLogin)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmLogin
		Dim theInstance As New frmLogin()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "txtUserName", "cmdCancel", "txtPassword", "cmdOK", "_lblLabels_0", "_lblLabels_1", "lblLabels"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents txtUserName As System.Windows.Forms.TextBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents txtPassword As System.Windows.Forms.TextBox
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Private WithEvents _lblLabels_0 As System.Windows.Forms.Label
	Private WithEvents _lblLabels_1 As System.Windows.Forms.Label
	Public lblLabels(1) As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
		Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
		Me.txtUserName = New System.Windows.Forms.TextBox()
		Me.cmdCancel = New System.Windows.Forms.Button()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.cmdOK = New System.Windows.Forms.Button()
		Me._lblLabels_0 = New System.Windows.Forms.Label()
		Me._lblLabels_1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		' 
		'txtUserName
		' 
		Me.txtUserName.AcceptsReturn = True
		Me.txtUserName.AllowDrop = True
		Me.txtUserName.BackColor = System.Drawing.SystemColors.Window
		Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtUserName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtUserName.Location = New System.Drawing.Point(118, 25)
		Me.txtUserName.MaxLength = 0
		Me.txtUserName.Name = "txtUserName"
		Me.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtUserName.Size = New System.Drawing.Size(155, 23)
		Me.txtUserName.TabIndex = 1
		' 
		'cmdCancel
		' 
		Me.cmdCancel.AllowDrop = True
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Location = New System.Drawing.Point(196, 100)
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.Size = New System.Drawing.Size(76, 26)
		Me.cmdCancel.TabIndex = 5
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdCancel.UseVisualStyleBackColor = False
		' 
		'txtPassword
		' 
		Me.txtPassword.AcceptsReturn = True
		Me.txtPassword.AllowDrop = True
		Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
		Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable
		Me.txtPassword.Location = New System.Drawing.Point(118, 51)
		Me.txtPassword.MaxLength = 0
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
		Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPassword.Size = New System.Drawing.Size(155, 23)
		Me.txtPassword.TabIndex = 3
		' 
		'cmdOK
		' 
		Me.cmdOK.AllowDrop = True
		Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOK.Location = New System.Drawing.Point(89, 100)
		Me.cmdOK.Name = "cmdOK"
		Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOK.Size = New System.Drawing.Size(76, 26)
		Me.cmdOK.TabIndex = 4
		Me.cmdOK.Text = "OK"
		Me.cmdOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdOK.UseVisualStyleBackColor = False
		' 
		'_lblLabels_0
		' 
		Me._lblLabels_0.AllowDrop = True
		Me._lblLabels_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblLabels_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLabels_0.Location = New System.Drawing.Point(39, 26)
		Me._lblLabels_0.Name = "_lblLabels_0"
		Me._lblLabels_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_0.Size = New System.Drawing.Size(72, 18)
		Me._lblLabels_0.TabIndex = 0
		Me._lblLabels_0.Text = "&User Name:"
		' 
		'_lblLabels_1
		' 
		Me._lblLabels_1.AllowDrop = True
		Me._lblLabels_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblLabels_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLabels_1.Location = New System.Drawing.Point(39, 52)
		Me._lblLabels_1.Name = "_lblLabels_1"
		Me._lblLabels_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_1.Size = New System.Drawing.Size(72, 18)
		Me._lblLabels_1.TabIndex = 2
		Me._lblLabels_1.Text = "&Password:"
		' 
		'frmLogin
		' 
		Me.AcceptButton = Me.cmdOK
		Me.AllowDrop = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6, 13)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.CancelButton = Me.cmdCancel
		Me.ClientSize = New System.Drawing.Size(289, 137)
		Me.Controls.Add(Me.txtUserName)
		Me.Controls.Add(Me.cmdCancel)
		Me.Controls.Add(Me.txtPassword)
		Me.Controls.Add(Me.cmdOK)
		Me.Controls.Add(Me._lblLabels_0)
		Me.Controls.Add(Me._lblLabels_1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("frmLogin.Icon"), System.Drawing.Icon)
		Me.Location = New System.Drawing.Point(189, 232)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmLogin"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Login"
		Me.ResumeLayout(False)
	End Sub
	Sub ReLoadForm(ByVal addEvents As Boolean)
		InitializelblLabels()
		If addEvents Then
			AddHandler MyBase.Closed, AddressOf Me.Form_Closed
			AddHandler Me.Activated, AddressOf Me.frmLogin_Activated
		End If
	End Sub
	Sub InitializelblLabels()
		ReDim lblLabels(1)
		Me.lblLabels(0) = _lblLabels_0
		Me.lblLabels(1) = _lblLabels_1
	End Sub
#End Region
End Class