<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomers
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmCustomers
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmCustomers
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmCustomers)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmCustomers
		Dim theInstance As New frmCustomers()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "dcCustomers", "_txtField_4", "_txtField_0", "_txtField_6", "_txtField_7", "_txtField_2", "_txtField_1", "_txtField_3", "_txtField_5", "_txtField_11", "_txtField_13", "_txtField_12", "Label7", "Label3", "Label2", "Frame2", "_txtField_8", "_txtField_10", "_txtField_14", "_txtField_9", "Label15", "Label14", "Label13", "Label12", "Label11", "Label10", "Label9", "Label8", "Label6", "Label5", "Label4", "Label1", "Frame1", "ImageList1", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1_Buttons_Button5", "Toolbar1_Buttons_Button6", "Toolbar1", "txtField"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents dcCustomers As UpgradeHelpers.DB.ADO.ADODataControlHelper
	Private WithEvents _txtField_4 As System.Windows.Forms.TextBox
	Private WithEvents _txtField_0 As System.Windows.Forms.TextBox
	Private WithEvents _txtField_6 As System.Windows.Forms.TextBox
	Private WithEvents _txtField_7 As System.Windows.Forms.TextBox
	Private WithEvents _txtField_2 As System.Windows.Forms.TextBox
	Private WithEvents _txtField_1 As System.Windows.Forms.TextBox
	Private WithEvents _txtField_3 As System.Windows.Forms.TextBox
	Private WithEvents _txtField_5 As System.Windows.Forms.TextBox
	Private WithEvents _txtField_11 As System.Windows.Forms.TextBox
	Private WithEvents _txtField_13 As System.Windows.Forms.TextBox
	Private WithEvents _txtField_12 As System.Windows.Forms.TextBox
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Private WithEvents _txtField_8 As System.Windows.Forms.TextBox
	Private WithEvents _txtField_10 As System.Windows.Forms.TextBox
	Private WithEvents _txtField_14 As System.Windows.Forms.TextBox
	Private WithEvents _txtField_9 As System.Windows.Forms.TextBox
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents ImageList1 As System.Windows.Forms.ImageList
	Public WithEvents Toolbar1_Buttons_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button6 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public txtField(14) As System.Windows.Forms.TextBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmCustomers))
		Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
		Me.dcCustomers = New UpgradeHelpers.DB.ADO.ADODataControlHelper()
		Me.Frame1 = New System.Windows.Forms.GroupBox()
		Me._txtField_4 = New System.Windows.Forms.TextBox()
		Me._txtField_0 = New System.Windows.Forms.TextBox()
		Me._txtField_6 = New System.Windows.Forms.TextBox()
		Me._txtField_7 = New System.Windows.Forms.TextBox()
		Me._txtField_2 = New System.Windows.Forms.TextBox()
		Me._txtField_1 = New System.Windows.Forms.TextBox()
		Me._txtField_3 = New System.Windows.Forms.TextBox()
		Me._txtField_5 = New System.Windows.Forms.TextBox()
		Me.Frame2 = New System.Windows.Forms.GroupBox()
		Me._txtField_11 = New System.Windows.Forms.TextBox()
		Me._txtField_13 = New System.Windows.Forms.TextBox()
		Me._txtField_12 = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me._txtField_8 = New System.Windows.Forms.TextBox()
		Me._txtField_10 = New System.Windows.Forms.TextBox()
		Me._txtField_14 = New System.Windows.Forms.TextBox()
		Me._txtField_9 = New System.Windows.Forms.TextBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ImageList1 = New System.Windows.Forms.ImageList()
		Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
		Me.Toolbar1_Buttons_Button1 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Buttons_Button2 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Buttons_Button3 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Buttons_Button4 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Buttons_Button5 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Buttons_Button6 = New System.Windows.Forms.ToolStripButton()
		CType(Me.dcCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Frame1.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.Toolbar1.SuspendLayout()
		Me.SuspendLayout()
		' 
		'dcCustomers
		' 
		Me.dcCustomers.AllowDrop = True
		Me.dcCustomers.BackColor = System.Drawing.SystemColors.Window
		Me.dcCustomers.BOFAction = UpgradeHelpers.DB.BOFActionEnum.BOF
		Me.dcCustomers.ConnectionString = "Driver=SQLite3 ODBC Driver; Database=Orders.db;"
		Me.dcCustomers.CursorLocation = UpgradeHelpers.DB.ADO.CursorLocationEnum.adUseClient
		Me.dcCustomers.Enabled = True
		Me.dcCustomers.EOFAction = UpgradeHelpers.DB.EOFActionEnum.MoveLast
		Me.dcCustomers.FactoryName = "Access"
		Me.dcCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.dcCustomers.ForeColor = System.Drawing.SystemColors.WindowText
		Me.dcCustomers.Location = New System.Drawing.Point(8, 400)
		Me.dcCustomers.LockType = UpgradeHelpers.DB.LockTypeEnum.LockPessimistic
		Me.dcCustomers.Name = "dcCustomers"
		Me.dcCustomers.Password = ""
		Me.dcCustomers.QueryTimeout = 30
		Me.dcCustomers.QueryType = System.Data.CommandType.Text
		Me.dcCustomers.RecordSource = "Select * from Customers;"
		Me.dcCustomers.Text = "Customers"
		Me.dcCustomers.UserName = ""
		Me.dcCustomers.Width = 177
		' 
		'Frame1
		' 
		Me.Frame1.AllowDrop = True
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Controls.Add(Me._txtField_4)
		Me.Frame1.Controls.Add(Me._txtField_0)
		Me.Frame1.Controls.Add(Me._txtField_6)
		Me.Frame1.Controls.Add(Me._txtField_7)
		Me.Frame1.Controls.Add(Me._txtField_2)
		Me.Frame1.Controls.Add(Me._txtField_1)
		Me.Frame1.Controls.Add(Me._txtField_3)
		Me.Frame1.Controls.Add(Me._txtField_5)
		Me.Frame1.Controls.Add(Me.Frame2)
		Me.Frame1.Controls.Add(Me._txtField_8)
		Me.Frame1.Controls.Add(Me._txtField_10)
		Me.Frame1.Controls.Add(Me._txtField_14)
		Me.Frame1.Controls.Add(Me._txtField_9)
		Me.Frame1.Controls.Add(Me.Label15)
		Me.Frame1.Controls.Add(Me.Label14)
		Me.Frame1.Controls.Add(Me.Label13)
		Me.Frame1.Controls.Add(Me.Label12)
		Me.Frame1.Controls.Add(Me.Label11)
		Me.Frame1.Controls.Add(Me.Label10)
		Me.Frame1.Controls.Add(Me.Label9)
		Me.Frame1.Controls.Add(Me.Label8)
		Me.Frame1.Controls.Add(Me.Label6)
		Me.Frame1.Controls.Add(Me.Label5)
		Me.Frame1.Controls.Add(Me.Label4)
		Me.Frame1.Controls.Add(Me.Label1)
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.Location = New System.Drawing.Point(8, 48)
		Me.Frame1.Name = "Frame1"
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Size = New System.Drawing.Size(433, 345)
		Me.Frame1.TabIndex = 16
		Me.Frame1.Text = "Customer information"
		Me.Frame1.Visible = True
		' 
		'_txtField_4
		' 
		Me._txtField_4.AcceptsReturn = True
		Me._txtField_4.AllowDrop = True
		Me._txtField_4.BackColor = System.Drawing.SystemColors.Window
		Me._txtField_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtField_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtField_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtField_4.Location = New System.Drawing.Point(104, 148)
		Me._txtField_4.MaxLength = 0
		Me._txtField_4.Name = "_txtField_4"
		Me._txtField_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_4.Size = New System.Drawing.Size(105, 20)
		Me._txtField_4.TabIndex = 7
		' 
		'_txtField_0
		' 
		Me._txtField_0.AcceptsReturn = True
		Me._txtField_0.AllowDrop = True
		Me._txtField_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtField_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtField_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtField_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtField_0.Location = New System.Drawing.Point(104, 24)
		Me._txtField_0.MaxLength = 0
		Me._txtField_0.Name = "_txtField_0"
		Me._txtField_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_0.Size = New System.Drawing.Size(105, 20)
		Me._txtField_0.TabIndex = 0
		' 
		'_txtField_6
		' 
		Me._txtField_6.AcceptsReturn = True
		Me._txtField_6.AllowDrop = True
		Me._txtField_6.BackColor = System.Drawing.SystemColors.Window
		Me._txtField_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtField_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtField_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtField_6.Location = New System.Drawing.Point(104, 209)
		Me._txtField_6.MaxLength = 0
		Me._txtField_6.Name = "_txtField_6"
		Me._txtField_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_6.Size = New System.Drawing.Size(105, 20)
		Me._txtField_6.TabIndex = 9
		' 
		'_txtField_7
		' 
		Me._txtField_7.AcceptsReturn = True
		Me._txtField_7.AllowDrop = True
		Me._txtField_7.BackColor = System.Drawing.SystemColors.Window
		Me._txtField_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtField_7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtField_7.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtField_7.Location = New System.Drawing.Point(104, 240)
		Me._txtField_7.MaxLength = 0
		Me._txtField_7.Name = "_txtField_7"
		Me._txtField_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_7.Size = New System.Drawing.Size(105, 20)
		Me._txtField_7.TabIndex = 10
		' 
		'_txtField_2
		' 
		Me._txtField_2.AcceptsReturn = True
		Me._txtField_2.AllowDrop = True
		Me._txtField_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtField_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtField_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtField_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtField_2.Location = New System.Drawing.Point(104, 86)
		Me._txtField_2.MaxLength = 0
		Me._txtField_2.Name = "_txtField_2"
		Me._txtField_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_2.Size = New System.Drawing.Size(105, 20)
		Me._txtField_2.TabIndex = 2
		' 
		'_txtField_1
		' 
		Me._txtField_1.AcceptsReturn = True
		Me._txtField_1.AllowDrop = True
		Me._txtField_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtField_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtField_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtField_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtField_1.Location = New System.Drawing.Point(104, 55)
		Me._txtField_1.MaxLength = 0
		Me._txtField_1.Name = "_txtField_1"
		Me._txtField_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_1.Size = New System.Drawing.Size(105, 20)
		Me._txtField_1.TabIndex = 1
		' 
		'_txtField_3
		' 
		Me._txtField_3.AcceptsReturn = True
		Me._txtField_3.AllowDrop = True
		Me._txtField_3.BackColor = System.Drawing.SystemColors.Window
		Me._txtField_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtField_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtField_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtField_3.Location = New System.Drawing.Point(104, 117)
		Me._txtField_3.MaxLength = 0
		Me._txtField_3.Name = "_txtField_3"
		Me._txtField_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_3.Size = New System.Drawing.Size(313, 20)
		Me._txtField_3.TabIndex = 6
		' 
		'_txtField_5
		' 
		Me._txtField_5.AcceptsReturn = True
		Me._txtField_5.AllowDrop = True
		Me._txtField_5.BackColor = System.Drawing.SystemColors.Window
		Me._txtField_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtField_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtField_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtField_5.Location = New System.Drawing.Point(104, 178)
		Me._txtField_5.MaxLength = 0
		Me._txtField_5.Name = "_txtField_5"
		Me._txtField_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_5.Size = New System.Drawing.Size(105, 20)
		Me._txtField_5.TabIndex = 8
		' 
		'Frame2
		' 
		Me.Frame2.AllowDrop = True
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Controls.Add(Me._txtField_11)
		Me.Frame2.Controls.Add(Me._txtField_13)
		Me.Frame2.Controls.Add(Me._txtField_12)
		Me.Frame2.Controls.Add(Me.Label7)
		Me.Frame2.Controls.Add(Me.Label3)
		Me.Frame2.Controls.Add(Me.Label2)
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.Location = New System.Drawing.Point(224, 14)
		Me.Frame2.Name = "Frame2"
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Size = New System.Drawing.Size(194, 97)
		Me.Frame2.TabIndex = 28
		Me.Frame2.Text = "Contact"
		Me.Frame2.Visible = True
		' 
		'_txtField_11
		' 
		Me._txtField_11.AcceptsReturn = True
		Me._txtField_11.AllowDrop = True
		Me._txtField_11.BackColor = System.Drawing.SystemColors.Window
		Me._txtField_11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtField_11.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtField_11.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtField_11.Location = New System.Drawing.Point(64, 16)
		Me._txtField_11.MaxLength = 0
		Me._txtField_11.Name = "_txtField_11"
		Me._txtField_11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_11.Size = New System.Drawing.Size(121, 20)
		Me._txtField_11.TabIndex = 3
		' 
		'_txtField_13
		' 
		Me._txtField_13.AcceptsReturn = True
		Me._txtField_13.AllowDrop = True
		Me._txtField_13.BackColor = System.Drawing.SystemColors.Window
		Me._txtField_13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtField_13.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtField_13.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtField_13.Location = New System.Drawing.Point(64, 64)
		Me._txtField_13.MaxLength = 0
		Me._txtField_13.Name = "_txtField_13"
		Me._txtField_13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_13.Size = New System.Drawing.Size(121, 20)
		Me._txtField_13.TabIndex = 5
		' 
		'_txtField_12
		' 
		Me._txtField_12.AcceptsReturn = True
		Me._txtField_12.AllowDrop = True
		Me._txtField_12.BackColor = System.Drawing.SystemColors.Window
		Me._txtField_12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtField_12.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtField_12.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtField_12.Location = New System.Drawing.Point(64, 40)
		Me._txtField_12.MaxLength = 0
		Me._txtField_12.Name = "_txtField_12"
		Me._txtField_12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_12.Size = New System.Drawing.Size(121, 20)
		Me._txtField_12.TabIndex = 4
		' 
		'Label7
		' 
		Me.Label7.AllowDrop = True
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Location = New System.Drawing.Point(8, 16)
		Me.Label7.Name = "Label7"
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.Size = New System.Drawing.Size(49, 17)
		Me.Label7.TabIndex = 31
		Me.Label7.Text = "Title"
		' 
		'Label3
		' 
		Me.Label3.AllowDrop = True
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Location = New System.Drawing.Point(8, 69)
		Me.Label3.Name = "Label3"
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.Size = New System.Drawing.Size(57, 17)
		Me.Label3.TabIndex = 30
		Me.Label3.Text = "Last name"
		' 
		'Label2
		' 
		Me.Label2.AllowDrop = True
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Location = New System.Drawing.Point(8, 43)
		Me.Label2.Name = "Label2"
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.Size = New System.Drawing.Size(57, 17)
		Me.Label2.TabIndex = 29
		Me.Label2.Text = "First name"
		' 
		'_txtField_8
		' 
		Me._txtField_8.AcceptsReturn = True
		Me._txtField_8.AllowDrop = True
		Me._txtField_8.BackColor = System.Drawing.SystemColors.Window
		Me._txtField_8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtField_8.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtField_8.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtField_8.Location = New System.Drawing.Point(312, 179)
		Me._txtField_8.MaxLength = 0
		Me._txtField_8.Name = "_txtField_8"
		Me._txtField_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_8.Size = New System.Drawing.Size(105, 20)
		Me._txtField_8.TabIndex = 11
		' 
		'_txtField_10
		' 
		Me._txtField_10.AcceptsReturn = True
		Me._txtField_10.AllowDrop = True
		Me._txtField_10.BackColor = System.Drawing.SystemColors.Window
		Me._txtField_10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtField_10.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtField_10.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtField_10.Location = New System.Drawing.Point(312, 240)
		Me._txtField_10.MaxLength = 0
		Me._txtField_10.Name = "_txtField_10"
		Me._txtField_10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_10.Size = New System.Drawing.Size(105, 20)
		Me._txtField_10.TabIndex = 13
		' 
		'_txtField_14
		' 
		Me._txtField_14.AcceptsReturn = True
		Me._txtField_14.AllowDrop = True
		Me._txtField_14.BackColor = System.Drawing.SystemColors.Window
		Me._txtField_14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtField_14.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtField_14.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtField_14.Location = New System.Drawing.Point(16, 280)
		Me._txtField_14.MaxLength = 0
		Me._txtField_14.Multiline = True
		Me._txtField_14.Name = "_txtField_14"
		Me._txtField_14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_14.Size = New System.Drawing.Size(401, 52)
		Me._txtField_14.TabIndex = 14
		' 
		'_txtField_9
		' 
		Me._txtField_9.AcceptsReturn = True
		Me._txtField_9.AllowDrop = True
		Me._txtField_9.BackColor = System.Drawing.SystemColors.Window
		Me._txtField_9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtField_9.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtField_9.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtField_9.Location = New System.Drawing.Point(312, 209)
		Me._txtField_9.MaxLength = 0
		Me._txtField_9.Name = "_txtField_9"
		Me._txtField_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_9.Size = New System.Drawing.Size(105, 20)
		Me._txtField_9.TabIndex = 12
		' 
		'Label15
		' 
		Me.Label15.AllowDrop = True
		Me.Label15.BackColor = System.Drawing.SystemColors.Control
		Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label15.Location = New System.Drawing.Point(16, 148)
		Me.Label15.Name = "Label15"
		Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label15.Size = New System.Drawing.Size(89, 17)
		Me.Label15.TabIndex = 32
		Me.Label15.Text = "Zip"
		' 
		'Label14
		' 
		Me.Label14.AllowDrop = True
		Me.Label14.BackColor = System.Drawing.SystemColors.Control
		Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label14.Location = New System.Drawing.Point(16, 240)
		Me.Label14.Name = "Label14"
		Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label14.Size = New System.Drawing.Size(89, 17)
		Me.Label14.TabIndex = 27
		Me.Label14.Text = "Country"
		' 
		'Label13
		' 
		Me.Label13.AllowDrop = True
		Me.Label13.BackColor = System.Drawing.SystemColors.Control
		Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label13.Location = New System.Drawing.Point(16, 209)
		Me.Label13.Name = "Label13"
		Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label13.Size = New System.Drawing.Size(89, 17)
		Me.Label13.TabIndex = 26
		Me.Label13.Text = "State/Prov"
		' 
		'Label12
		' 
		Me.Label12.AllowDrop = True
		Me.Label12.BackColor = System.Drawing.SystemColors.Control
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label12.Location = New System.Drawing.Point(16, 264)
		Me.Label12.Name = "Label12"
		Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label12.Size = New System.Drawing.Size(89, 17)
		Me.Label12.TabIndex = 25
		Me.Label12.Text = "Notes:"
		' 
		'Label11
		' 
		Me.Label11.AllowDrop = True
		Me.Label11.BackColor = System.Drawing.SystemColors.Control
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label11.Location = New System.Drawing.Point(16, 86)
		Me.Label11.Name = "Label11"
		Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label11.Size = New System.Drawing.Size(89, 17)
		Me.Label11.TabIndex = 24
		Me.Label11.Text = "Email"
		' 
		'Label10
		' 
		Me.Label10.AllowDrop = True
		Me.Label10.BackColor = System.Drawing.SystemColors.Control
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label10.Location = New System.Drawing.Point(232, 240)
		Me.Label10.Name = "Label10"
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.Size = New System.Drawing.Size(89, 17)
		Me.Label10.TabIndex = 23
		Me.Label10.Text = "Fax"
		' 
		'Label9
		' 
		Me.Label9.AllowDrop = True
		Me.Label9.BackColor = System.Drawing.SystemColors.Control
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Location = New System.Drawing.Point(232, 209)
		Me.Label9.Name = "Label9"
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.Size = New System.Drawing.Size(89, 17)
		Me.Label9.TabIndex = 22
		Me.Label9.Text = "Ext"
		' 
		'Label8
		' 
		Me.Label8.AllowDrop = True
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Location = New System.Drawing.Point(232, 179)
		Me.Label8.Name = "Label8"
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.Size = New System.Drawing.Size(89, 17)
		Me.Label8.TabIndex = 21
		Me.Label8.Text = "Phone"
		' 
		'Label6
		' 
		Me.Label6.AllowDrop = True
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Location = New System.Drawing.Point(16, 178)
		Me.Label6.Name = "Label6"
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.Size = New System.Drawing.Size(89, 17)
		Me.Label6.TabIndex = 20
		Me.Label6.Text = "City"
		' 
		'Label5
		' 
		Me.Label5.AllowDrop = True
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Location = New System.Drawing.Point(16, 117)
		Me.Label5.Name = "Label5"
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.Size = New System.Drawing.Size(89, 17)
		Me.Label5.TabIndex = 19
		Me.Label5.Text = "Address"
		' 
		'Label4
		' 
		Me.Label4.AllowDrop = True
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Location = New System.Drawing.Point(16, 55)
		Me.Label4.Name = "Label4"
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.Size = New System.Drawing.Size(89, 17)
		Me.Label4.TabIndex = 18
		Me.Label4.Text = "Department"
		' 
		'Label1
		' 
		Me.Label1.AllowDrop = True
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Location = New System.Drawing.Point(16, 24)
		Me.Label1.Name = "Label1"
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.Size = New System.Drawing.Size(89, 17)
		Me.Label1.TabIndex = 17
		Me.Label1.Text = "Company"
		' 
		'ImageList1
		' 
		Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
		Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.ImageList1.TransparentColor = System.Drawing.Color.White
		Me.ImageList1.Images.SetKeyName(0, "")
		Me.ImageList1.Images.SetKeyName(1, "")
		Me.ImageList1.Images.SetKeyName(2, "")
		Me.ImageList1.Images.SetKeyName(3, "")
		Me.ImageList1.Images.SetKeyName(4, "")
		Me.ImageList1.Images.SetKeyName(5, "")
		' 
		'Toolbar1
		' 
		Me.Toolbar1.AllowDrop = True
		Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Toolbar1.ImageList = ImageList1
		Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
		Me.Toolbar1.Name = "Toolbar1"
		Me.Toolbar1.ShowItemToolTips = True
		Me.Toolbar1.Size = New System.Drawing.Size(454, 44)
		Me.Toolbar1.TabIndex = 15
		Me.Toolbar1.Items.Add(Me.Toolbar1_Buttons_Button1)
		Me.Toolbar1.Items.Add(Me.Toolbar1_Buttons_Button2)
		Me.Toolbar1.Items.Add(Me.Toolbar1_Buttons_Button3)
		Me.Toolbar1.Items.Add(Me.Toolbar1_Buttons_Button4)
		Me.Toolbar1.Items.Add(Me.Toolbar1_Buttons_Button5)
		Me.Toolbar1.Items.Add(Me.Toolbar1_Buttons_Button6)
		' 
		'Toolbar1_Buttons_Button1
		' 
		Me.Toolbar1_Buttons_Button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me.Toolbar1_Buttons_Button1.ImageIndex = 0
		Me.Toolbar1_Buttons_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Buttons_Button1.Size = New System.Drawing.Size(44, 39)
		Me.Toolbar1_Buttons_Button1.Text = "Add"
		Me.Toolbar1_Buttons_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Buttons_Button1.ToolTipText = "Create a new record"
		' 
		'Toolbar1_Buttons_Button2
		' 
		Me.Toolbar1_Buttons_Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me.Toolbar1_Buttons_Button2.ImageIndex = 1
		Me.Toolbar1_Buttons_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Buttons_Button2.Size = New System.Drawing.Size(44, 39)
		Me.Toolbar1_Buttons_Button2.Text = "Edit"
		Me.Toolbar1_Buttons_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Buttons_Button2.ToolTipText = "Edit this record"
		' 
		'Toolbar1_Buttons_Button3
		' 
		Me.Toolbar1_Buttons_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me.Toolbar1_Buttons_Button3.ImageIndex = 2
		Me.Toolbar1_Buttons_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Buttons_Button3.Size = New System.Drawing.Size(44, 39)
		Me.Toolbar1_Buttons_Button3.Text = "Save"
		Me.Toolbar1_Buttons_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Buttons_Button3.ToolTipText = "Save the current changes"
		' 
		'Toolbar1_Buttons_Button4
		' 
		Me.Toolbar1_Buttons_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me.Toolbar1_Buttons_Button4.ImageIndex = 3
		Me.Toolbar1_Buttons_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Buttons_Button4.Size = New System.Drawing.Size(44, 39)
		Me.Toolbar1_Buttons_Button4.Text = "Delete"
		Me.Toolbar1_Buttons_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Buttons_Button4.ToolTipText = "Delete the current record"
		' 
		'Toolbar1_Buttons_Button5
		' 
		Me.Toolbar1_Buttons_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me.Toolbar1_Buttons_Button5.ImageIndex = 4
		Me.Toolbar1_Buttons_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Buttons_Button5.Size = New System.Drawing.Size(44, 39)
		Me.Toolbar1_Buttons_Button5.Text = "Search"
		Me.Toolbar1_Buttons_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Buttons_Button5.ToolTipText = "Search for a record"
		' 
		'Toolbar1_Buttons_Button6
		' 
		Me.Toolbar1_Buttons_Button6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me.Toolbar1_Buttons_Button6.ImageIndex = 5
		Me.Toolbar1_Buttons_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Buttons_Button6.Size = New System.Drawing.Size(44, 39)
		Me.Toolbar1_Buttons_Button6.Text = "Cancel"
		Me.Toolbar1_Buttons_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Buttons_Button6.ToolTipText = "Cancel edited changes"
		' 
		'frmCustomers
		' 
		Me.AllowDrop = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6, 13)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(454, 443)
		Me.Controls.Add(Me.dcCustomers)
		Me.Controls.Add(Me.Frame1)
		Me.Controls.Add(Me.Toolbar1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Location = New System.Drawing.Point(8, 30)
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Name = "frmCustomers"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text = "Customers"
		CType(Me.dcCustomers, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.Toolbar1.ResumeLayout(False)
		Me.ResumeLayout(False)
	End Sub
	Sub ReLoadForm(ByVal addEvents As Boolean)
		InitializetxtField()
		Form_Load()
		VB6_AddADODataBinding()
		If addEvents Then
			AddHandler MyBase.Closed, AddressOf Me.Form_Closed
			AddHandler Me.Activated, AddressOf Me.frmCustomers_Activated
		End If
	End Sub
	Sub InitializetxtField()
		ReDim txtField(14)
		Me.txtField(4) = _txtField_4
		Me.txtField(0) = _txtField_0
		Me.txtField(6) = _txtField_6
		Me.txtField(7) = _txtField_7
		Me.txtField(2) = _txtField_2
		Me.txtField(1) = _txtField_1
		Me.txtField(3) = _txtField_3
		Me.txtField(5) = _txtField_5
		Me.txtField(11) = _txtField_11
		Me.txtField(13) = _txtField_13
		Me.txtField(12) = _txtField_12
		Me.txtField(8) = _txtField_8
		Me.txtField(10) = _txtField_10
		Me.txtField(14) = _txtField_14
		Me.txtField(9) = _txtField_9
	End Sub
#End Region
#Region "Upgrade Support"
	Public Sub VB6_AddADODataBinding()
		dcCustomers.Refresh()
		_txtField_9.DataBindings.Add("Text", dcCustomers, "Extension", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		_txtField_14.DataBindings.Add("Text", dcCustomers, "Notes", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		_txtField_10.DataBindings.Add("Text", dcCustomers, "FaxNumber", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		_txtField_8.DataBindings.Add("Text", dcCustomers, "PhoneNumber", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		_txtField_12.DataBindings.Add("Text", dcCustomers, "ContactFirstName", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		_txtField_13.DataBindings.Add("Text", dcCustomers, "ContactLastName", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		_txtField_11.DataBindings.Add("Text", dcCustomers, "ContactTitle", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		_txtField_5.DataBindings.Add("Text", dcCustomers, "City", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		_txtField_3.DataBindings.Add("Text", dcCustomers, "BillingAddress", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		_txtField_1.DataBindings.Add("Text", dcCustomers, "CompanyOrDepartment", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		_txtField_2.DataBindings.Add("Text", dcCustomers, "EmailAddress", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		_txtField_7.DataBindings.Add("Text", dcCustomers, "Country/Region", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		_txtField_6.DataBindings.Add("Text", dcCustomers, "StateOrProvince", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		_txtField_0.DataBindings.Add("Text", dcCustomers, "CompanyName", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		_txtField_4.DataBindings.Add("Text", dcCustomers, "PostalCode", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
	End Sub
#End Region
End Class