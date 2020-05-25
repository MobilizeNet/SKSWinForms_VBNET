<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmProducts
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmProducts
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmProducts)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmProducts
		Dim theInstance As New frmProducts()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "_txtField_6", "_txtField_0", "_txtField_5", "cmbCategory", "_txtField_4", "_txtField_3", "_txtField_2", "_txtField_1", "Check1", "txtCategory", "Label7", "Label3", "Label2", "Label1", "Label4", "Label5", "Label6", "Label11", "Label15", "Frame1", "dcProducts", "ImageList1", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1_Buttons_Button5", "Toolbar1_Buttons_Button6", "Toolbar1", "txtField"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Private WithEvents _txtField_6 As System.Windows.Forms.TextBox
	Private WithEvents _txtField_0 As System.Windows.Forms.TextBox
	Private WithEvents _txtField_5 As System.Windows.Forms.TextBox
	Public WithEvents cmbCategory As System.Windows.Forms.ComboBox
	Private WithEvents _txtField_4 As System.Windows.Forms.TextBox
	Private WithEvents _txtField_3 As System.Windows.Forms.TextBox
	Private WithEvents _txtField_2 As System.Windows.Forms.TextBox
	Private WithEvents _txtField_1 As System.Windows.Forms.TextBox
	Public WithEvents Check1 As System.Windows.Forms.CheckBox
	Public WithEvents txtCategory As System.Windows.Forms.TextBox
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents dcProducts As UpgradeHelpers.DB.ADO.ADODataControlHelper
	Public WithEvents ImageList1 As System.Windows.Forms.ImageList
	Public WithEvents Toolbar1_Buttons_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button6 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public txtField(6) As System.Windows.Forms.TextBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmProducts))
		Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
		Me.Frame1 = New System.Windows.Forms.GroupBox()
		Me._txtField_6 = New System.Windows.Forms.TextBox()
		Me._txtField_0 = New System.Windows.Forms.TextBox()
		Me._txtField_5 = New System.Windows.Forms.TextBox()
		Me.cmbCategory = New System.Windows.Forms.ComboBox()
		Me._txtField_4 = New System.Windows.Forms.TextBox()
		Me._txtField_3 = New System.Windows.Forms.TextBox()
		Me._txtField_2 = New System.Windows.Forms.TextBox()
		Me._txtField_1 = New System.Windows.Forms.TextBox()
		Me.Check1 = New System.Windows.Forms.CheckBox()
		Me.txtCategory = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.dcProducts = New UpgradeHelpers.DB.ADO.ADODataControlHelper()
		Me.ImageList1 = New System.Windows.Forms.ImageList()
		Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
		Me.Toolbar1_Buttons_Button1 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Buttons_Button2 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Buttons_Button3 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Buttons_Button4 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Buttons_Button5 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Buttons_Button6 = New System.Windows.Forms.ToolStripButton()
		CType(Me.dcProducts, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Frame1.SuspendLayout()
		Me.Toolbar1.SuspendLayout()
		Me.SuspendLayout()
		' 
		'Frame1
		' 
		Me.Frame1.AllowDrop = True
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Controls.Add(Me._txtField_6)
		Me.Frame1.Controls.Add(Me._txtField_0)
		Me.Frame1.Controls.Add(Me._txtField_5)
		Me.Frame1.Controls.Add(Me.cmbCategory)
		Me.Frame1.Controls.Add(Me._txtField_4)
		Me.Frame1.Controls.Add(Me._txtField_3)
		Me.Frame1.Controls.Add(Me._txtField_2)
		Me.Frame1.Controls.Add(Me._txtField_1)
		Me.Frame1.Controls.Add(Me.Check1)
		Me.Frame1.Controls.Add(Me.txtCategory)
		Me.Frame1.Controls.Add(Me.Label7)
		Me.Frame1.Controls.Add(Me.Label3)
		Me.Frame1.Controls.Add(Me.Label2)
		Me.Frame1.Controls.Add(Me.Label1)
		Me.Frame1.Controls.Add(Me.Label4)
		Me.Frame1.Controls.Add(Me.Label5)
		Me.Frame1.Controls.Add(Me.Label6)
		Me.Frame1.Controls.Add(Me.Label11)
		Me.Frame1.Controls.Add(Me.Label15)
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.Location = New System.Drawing.Point(8, 48)
		Me.Frame1.Name = "Frame1"
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Size = New System.Drawing.Size(433, 281)
		Me.Frame1.TabIndex = 9
		Me.Frame1.Text = "Product information"
		Me.Frame1.Visible = True
		' 
		'_txtField_6
		' 
		Me._txtField_6.AcceptsReturn = True
		Me._txtField_6.AllowDrop = True
		Me._txtField_6.BackColor = System.Drawing.SystemColors.Window
		Me._txtField_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtField_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtField_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtField_6.Location = New System.Drawing.Point(256, 240)
		Me._txtField_6.MaxLength = 0
		Me._txtField_6.Name = "_txtField_6"
		Me._txtField_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_6.Size = New System.Drawing.Size(105, 20)
		Me._txtField_6.TabIndex = 20
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
		Me._txtField_0.MaxLength = 20
		Me._txtField_0.Name = "_txtField_0"
		Me._txtField_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_0.Size = New System.Drawing.Size(113, 20)
		Me._txtField_0.TabIndex = 0
		' 
		'_txtField_5
		' 
		Me._txtField_5.AcceptsReturn = True
		Me._txtField_5.AllowDrop = True
		Me._txtField_5.BackColor = System.Drawing.SystemColors.Window
		Me._txtField_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtField_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtField_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtField_5.Location = New System.Drawing.Point(104, 240)
		Me._txtField_5.MaxLength = 0
		Me._txtField_5.Name = "_txtField_5"
		Me._txtField_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_5.Size = New System.Drawing.Size(105, 20)
		Me._txtField_5.TabIndex = 7
		' 
		'cmbCategory
		' 
		Me.cmbCategory.AllowDrop = True
		Me.cmbCategory.BackColor = System.Drawing.SystemColors.Window
		Me.cmbCategory.CausesValidation = True
		Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbCategory.Enabled = True
		Me.cmbCategory.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbCategory.IntegralHeight = True
		Me.cmbCategory.Location = New System.Drawing.Point(104, 117)
		Me.cmbCategory.Name = "cmbCategory"
		Me.cmbCategory.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbCategory.Size = New System.Drawing.Size(121, 21)
		Me.cmbCategory.Sorted = False
		Me.cmbCategory.TabIndex = 3
		Me.cmbCategory.TabStop = True
		Me.cmbCategory.Visible = True
		' 
		'_txtField_4
		' 
		Me._txtField_4.AcceptsReturn = True
		Me._txtField_4.AllowDrop = True
		Me._txtField_4.BackColor = System.Drawing.SystemColors.Window
		Me._txtField_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtField_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtField_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtField_4.Location = New System.Drawing.Point(104, 210)
		Me._txtField_4.MaxLength = 0
		Me._txtField_4.Name = "_txtField_4"
		Me._txtField_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_4.Size = New System.Drawing.Size(105, 20)
		Me._txtField_4.TabIndex = 6
		' 
		'_txtField_3
		' 
		Me._txtField_3.AcceptsReturn = True
		Me._txtField_3.AllowDrop = True
		Me._txtField_3.BackColor = System.Drawing.SystemColors.Window
		Me._txtField_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtField_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtField_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtField_3.Location = New System.Drawing.Point(104, 148)
		Me._txtField_3.MaxLength = 0
		Me._txtField_3.Name = "_txtField_3"
		Me._txtField_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_3.Size = New System.Drawing.Size(121, 20)
		Me._txtField_3.TabIndex = 4
		' 
		'_txtField_2
		' 
		Me._txtField_2.AcceptsReturn = True
		Me._txtField_2.AllowDrop = True
		Me._txtField_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtField_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtField_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtField_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtField_2.Location = New System.Drawing.Point(104, 88)
		Me._txtField_2.MaxLength = 255
		Me._txtField_2.Name = "_txtField_2"
		Me._txtField_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_2.Size = New System.Drawing.Size(305, 20)
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
		Me._txtField_1.Location = New System.Drawing.Point(104, 56)
		Me._txtField_1.MaxLength = 50
		Me._txtField_1.Name = "_txtField_1"
		Me._txtField_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtField_1.Size = New System.Drawing.Size(193, 20)
		Me._txtField_1.TabIndex = 1
		' 
		'Check1
		' 
		Me.Check1.AllowDrop = True
		Me.Check1.Appearance = System.Windows.Forms.Appearance.Normal
		Me.Check1.BackColor = System.Drawing.SystemColors.Control
		Me.Check1.CausesValidation = True
		Me.Check1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Check1.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.Check1.Enabled = True
		Me.Check1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Check1.Location = New System.Drawing.Point(104, 181)
		Me.Check1.Name = "Check1"
		Me.Check1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Check1.Size = New System.Drawing.Size(25, 17)
		Me.Check1.TabIndex = 5
		Me.Check1.TabStop = True
		Me.Check1.Text = ""
		Me.Check1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Check1.Visible = True
		' 
		'txtCategory
		' 
		Me.txtCategory.AcceptsReturn = True
		Me.txtCategory.AllowDrop = True
		Me.txtCategory.BackColor = System.Drawing.SystemColors.Window
		Me.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCategory.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCategory.Location = New System.Drawing.Point(200, 120)
		Me.txtCategory.MaxLength = 0
		Me.txtCategory.Name = "txtCategory"
		Me.txtCategory.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCategory.Size = New System.Drawing.Size(10, 13)
		Me.txtCategory.TabIndex = 16
		Me.txtCategory.TabStop = False
		' 
		'Label7
		' 
		Me.Label7.AllowDrop = True
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Location = New System.Drawing.Point(216, 244)
		Me.Label7.Name = "Label7"
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.Size = New System.Drawing.Size(57, 17)
		Me.Label7.TabIndex = 19
		Me.Label7.Text = "Unit"
		' 
		'Label3
		' 
		Me.Label3.AllowDrop = True
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Location = New System.Drawing.Point(16, 24)
		Me.Label3.Name = "Label3"
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.Size = New System.Drawing.Size(89, 17)
		Me.Label3.TabIndex = 18
		Me.Label3.Text = "Product "
		' 
		'Label2
		' 
		Me.Label2.AllowDrop = True
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Location = New System.Drawing.Point(16, 244)
		Me.Label2.Name = "Label2"
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.Size = New System.Drawing.Size(81, 17)
		Me.Label2.TabIndex = 17
		Me.Label2.Text = "Qty per unit"
		' 
		'Label1
		' 
		Me.Label1.AllowDrop = True
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Location = New System.Drawing.Point(16, 56)
		Me.Label1.Name = "Label1"
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.Size = New System.Drawing.Size(89, 17)
		Me.Label1.TabIndex = 15
		Me.Label1.Text = "Name"
		' 
		'Label4
		' 
		Me.Label4.AllowDrop = True
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Location = New System.Drawing.Point(16, 87)
		Me.Label4.Name = "Label4"
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.Size = New System.Drawing.Size(89, 17)
		Me.Label4.TabIndex = 14
		Me.Label4.Text = "Desc"
		' 
		'Label5
		' 
		Me.Label5.AllowDrop = True
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Location = New System.Drawing.Point(16, 148)
		Me.Label5.Name = "Label5"
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.Size = New System.Drawing.Size(89, 17)
		Me.Label5.TabIndex = 13
		Me.Label5.Text = "Serial number"
		' 
		'Label6
		' 
		Me.Label6.AllowDrop = True
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Location = New System.Drawing.Point(16, 210)
		Me.Label6.Name = "Label6"
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.Size = New System.Drawing.Size(81, 17)
		Me.Label6.TabIndex = 12
		Me.Label6.Text = "Unit price"
		' 
		'Label11
		' 
		Me.Label11.AllowDrop = True
		Me.Label11.BackColor = System.Drawing.SystemColors.Control
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label11.Location = New System.Drawing.Point(16, 118)
		Me.Label11.Name = "Label11"
		Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label11.Size = New System.Drawing.Size(89, 17)
		Me.Label11.TabIndex = 11
		Me.Label11.Text = "Category"
		' 
		'Label15
		' 
		Me.Label15.AllowDrop = True
		Me.Label15.BackColor = System.Drawing.SystemColors.Control
		Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label15.Location = New System.Drawing.Point(16, 179)
		Me.Label15.Name = "Label15"
		Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label15.Size = New System.Drawing.Size(89, 17)
		Me.Label15.TabIndex = 10
		Me.Label15.Text = "Discontinued"
		' 
		'dcProducts
		' 
		Me.dcProducts.AllowDrop = True
		Me.dcProducts.BackColor = System.Drawing.SystemColors.Window
		Me.dcProducts.BOFAction = UpgradeHelpers.DB.BOFActionEnum.MoveFirst
		Me.dcProducts.ConnectionString = "Driver=SQLite3 ODBC Driver; Database=Orders.db"
		Me.dcProducts.CursorLocation = UpgradeHelpers.DB.ADO.CursorLocationEnum.adUseClient
		Me.dcProducts.Enabled = True
		Me.dcProducts.EOFAction = UpgradeHelpers.DB.EOFActionEnum.MoveLast
		Me.dcProducts.FactoryName = "Access"
		Me.dcProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.dcProducts.ForeColor = System.Drawing.SystemColors.WindowText
		Me.dcProducts.Location = New System.Drawing.Point(8, 336)
		Me.dcProducts.LockType = UpgradeHelpers.DB.LockTypeEnum.LockOptimistic
		Me.dcProducts.Name = "dcProducts"
		Me.dcProducts.Password = ""
		Me.dcProducts.QueryTimeout = 30
		Me.dcProducts.QueryType = System.Data.CommandType.Text
		Me.dcProducts.RecordSource = "Select * from Products"
		Me.dcProducts.Text = "Products"
		Me.dcProducts.UserName = ""
		Me.dcProducts.Width = 177
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
		Me.Toolbar1.Size = New System.Drawing.Size(448, 44)
		Me.Toolbar1.TabIndex = 8
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
		'frmProducts
		' 
		Me.AllowDrop = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6, 13)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(448, 379)
		Me.Controls.Add(Me.Frame1)
		Me.Controls.Add(Me.dcProducts)
		Me.Controls.Add(Me.Toolbar1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Location = New System.Drawing.Point(3, 25)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmProducts"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = False
		Me.Text = "Products"
		CType(Me.dcProducts, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.Toolbar1.ResumeLayout(False)
		Me.ResumeLayout(False)
	End Sub
	Sub ReLoadForm(ByVal addEvents As Boolean)
		InitializetxtField()
		Form_Load()
		VB6_AddADODataBinding()
		If addEvents Then
			AddHandler MyBase.Closed, AddressOf Me.Form_Closed
			AddHandler Me.Activated, AddressOf Me.frmProducts_Activated
		End If
	End Sub
	Sub InitializetxtField()
		ReDim txtField(6)
		Me.txtField(6) = _txtField_6
		Me.txtField(0) = _txtField_0
		Me.txtField(5) = _txtField_5
		Me.txtField(4) = _txtField_4
		Me.txtField(3) = _txtField_3
		Me.txtField(2) = _txtField_2
		Me.txtField(1) = _txtField_1
	End Sub
#End Region
#Region "Upgrade Support"
	Public Sub VB6_AddADODataBinding()
		dcProducts.Refresh()
		txtCategory.DataBindings.Add("Text", dcProducts, "CategoryID", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		Check1.DataBindings.Add("Checked", dcProducts, "Discontinued", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		_txtField_1.DataBindings.Add("Text", dcProducts, "ProductName", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		_txtField_2.DataBindings.Add("Text", dcProducts, "ProductDescription", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		_txtField_3.DataBindings.Add("Text", dcProducts, "SerialNumber", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		_txtField_4.DataBindings.Add("Text", dcProducts, "UnitPrice", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		_txtField_5.DataBindings.Add("Text", dcProducts, "QuantityPerUnit", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		_txtField_0.DataBindings.Add("Text", dcProducts, "ProductID", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
		_txtField_6.DataBindings.Add("Text", dcProducts, "Unit", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
	End Sub
#End Region
End Class