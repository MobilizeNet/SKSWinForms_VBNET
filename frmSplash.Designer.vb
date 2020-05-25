<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmSplash
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmSplash
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmSplash)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmSplash
		Dim theInstance As New frmSplash()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "Timer1", "Image1"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
		Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me.Image1 = New System.Windows.Forms.PictureBox()
		Me.SuspendLayout()
		' 
		'Timer1
		' 
		Me.Timer1.Enabled = True
		Me.Timer1.Interval = 3000
		' 
		'Image1
		' 
		Me.Image1.AllowDrop = True
		Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image1.Enabled = True
		Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
		Me.Image1.Location = New System.Drawing.Point(0, 0)
		Me.Image1.Name = "Image1"
		Me.Image1.Size = New System.Drawing.Size(964, 642)
		Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.Image1.Visible = True
		' 
		'frmSplash
		' 
		Me.AllowDrop = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6, 13)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(943, 613)
		Me.Controls.Add(Me.Image1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.KeyPreview = True
		Me.Location = New System.Drawing.Point(17, 116)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmSplash"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.ResumeLayout(False)
	End Sub
	Sub ReLoadForm(ByVal addEvents As Boolean)
		If addEvents Then
			AddHandler MyBase.KeyPress, AddressOf Me.Form_KeyPress
			AddHandler MyBase.Closed, AddressOf Me.Form_Closed
			AddHandler Me.Activated, AddressOf Me.frmSplash_Activated
		End If
	End Sub
#End Region
End Class