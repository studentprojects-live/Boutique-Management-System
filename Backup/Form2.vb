Imports System.Data.OleDb

Public Class Form2
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents AxLaVolpeButton1 As AxTombolPun.AxLaVolpeButton
    Friend WithEvents AxLaVolpeButton2 As AxTombolPun.AxLaVolpeButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents AxLaVolpeButton3 As AxTombolPun.AxLaVolpeButton
    Friend WithEvents AxLaVolpeButton4 As AxTombolPun.AxLaVolpeButton
    Friend WithEvents AxLaVolpeButton5 As AxTombolPun.AxLaVolpeButton
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form2))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AxLaVolpeButton2 = New AxTombolPun.AxLaVolpeButton()
        Me.AxLaVolpeButton1 = New AxTombolPun.AxLaVolpeButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.AxLaVolpeButton5 = New AxTombolPun.AxLaVolpeButton()
        Me.AxLaVolpeButton4 = New AxTombolPun.AxLaVolpeButton()
        Me.AxLaVolpeButton3 = New AxTombolPun.AxLaVolpeButton()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.AxLaVolpeButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxLaVolpeButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.AxLaVolpeButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxLaVolpeButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxLaVolpeButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Bitmap)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 88)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(128, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 48)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Boutique Management System"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel1.Location = New System.Drawing.Point(-16, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(552, 2)
        Me.Panel1.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabPage1, Me.TabPage2})
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(8, 96)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(528, 304)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.AddRange(New System.Windows.Forms.Control() {Me.ComboBox1, Me.AxLaVolpeButton2, Me.AxLaVolpeButton1, Me.Label8, Me.TextBox5, Me.Label7, Me.TextBox4, Me.Label6, Me.TextBox3, Me.Label5, Me.TextBox2, Me.Label4, Me.TextBox1, Me.Label3, Me.Label2, Me.Panel1})
        Me.TabPage1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(520, 275)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "New Clothes Entry"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ComboBox1.Items.AddRange(New Object() {"Stiched", "IsStiched"})
        Me.ComboBox1.Location = New System.Drawing.Point(248, 208)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(112, 24)
        Me.ComboBox1.TabIndex = 13
        '
        'AxLaVolpeButton2
        '
        Me.AxLaVolpeButton2.ContainingControl = Me
        Me.AxLaVolpeButton2.Enabled = True
        Me.AxLaVolpeButton2.Location = New System.Drawing.Point(336, 240)
        Me.AxLaVolpeButton2.Name = "AxLaVolpeButton2"
        Me.AxLaVolpeButton2.OcxState = CType(resources.GetObject("AxLaVolpeButton2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxLaVolpeButton2.Size = New System.Drawing.Size(80, 24)
        Me.AxLaVolpeButton2.TabIndex = 16
        '
        'AxLaVolpeButton1
        '
        Me.AxLaVolpeButton1.ContainingControl = Me
        Me.AxLaVolpeButton1.Enabled = True
        Me.AxLaVolpeButton1.Location = New System.Drawing.Point(248, 240)
        Me.AxLaVolpeButton1.Name = "AxLaVolpeButton1"
        Me.AxLaVolpeButton1.OcxState = CType(resources.GetObject("AxLaVolpeButton1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxLaVolpeButton1.Size = New System.Drawing.Size(80, 24)
        Me.AxLaVolpeButton1.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(128, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 24)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Cloth Type:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox5.Location = New System.Drawing.Point(248, 176)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(112, 22)
        Me.TextBox5.TabIndex = 11
        Me.TextBox5.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(128, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 24)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Cost Price: "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox4.Location = New System.Drawing.Point(248, 144)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(112, 22)
        Me.TextBox4.TabIndex = 9
        Me.TextBox4.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(128, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 24)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Quantity:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox3.Location = New System.Drawing.Point(248, 112)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(184, 22)
        Me.TextBox3.TabIndex = 7
        Me.TextBox3.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(128, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cloth Description:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox2.Location = New System.Drawing.Point(248, 80)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(184, 22)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(152, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cloth Name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox1.Location = New System.Drawing.Point(248, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(112, 22)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(136, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cloth Serial No.:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(184, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "New Clothes Entry"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.AddRange(New System.Windows.Forms.Control() {Me.Panel3, Me.TextBox12, Me.TextBox11, Me.AxLaVolpeButton5, Me.AxLaVolpeButton4, Me.AxLaVolpeButton3, Me.ComboBox5, Me.TextBox9, Me.TextBox8, Me.TextBox7, Me.TextBox6, Me.Label16, Me.Label15, Me.Label14, Me.Label13, Me.Label12, Me.ComboBox2, Me.Label11, Me.Label10})
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(520, 275)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Modify / Change Clothes Entry"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel3.Location = New System.Drawing.Point(-8, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(552, 2)
        Me.Panel3.TabIndex = 21
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.White
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox12.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox12.Location = New System.Drawing.Point(360, 40)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(152, 22)
        Me.TextBox12.TabIndex = 20
        Me.TextBox12.Text = ""
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.White
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox11.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox11.Location = New System.Drawing.Point(208, 40)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(144, 22)
        Me.TextBox11.TabIndex = 19
        Me.TextBox11.Text = ""
        '
        'AxLaVolpeButton5
        '
        Me.AxLaVolpeButton5.ContainingControl = Me
        Me.AxLaVolpeButton5.Enabled = True
        Me.AxLaVolpeButton5.Location = New System.Drawing.Point(336, 240)
        Me.AxLaVolpeButton5.Name = "AxLaVolpeButton5"
        Me.AxLaVolpeButton5.OcxState = CType(resources.GetObject("AxLaVolpeButton5.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxLaVolpeButton5.Size = New System.Drawing.Size(80, 24)
        Me.AxLaVolpeButton5.TabIndex = 18
        '
        'AxLaVolpeButton4
        '
        Me.AxLaVolpeButton4.ContainingControl = Me
        Me.AxLaVolpeButton4.Enabled = True
        Me.AxLaVolpeButton4.Location = New System.Drawing.Point(248, 240)
        Me.AxLaVolpeButton4.Name = "AxLaVolpeButton4"
        Me.AxLaVolpeButton4.OcxState = CType(resources.GetObject("AxLaVolpeButton4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxLaVolpeButton4.Size = New System.Drawing.Size(80, 24)
        Me.AxLaVolpeButton4.TabIndex = 17
        '
        'AxLaVolpeButton3
        '
        Me.AxLaVolpeButton3.ContainingControl = Me
        Me.AxLaVolpeButton3.Enabled = True
        Me.AxLaVolpeButton3.Location = New System.Drawing.Point(416, 80)
        Me.AxLaVolpeButton3.Name = "AxLaVolpeButton3"
        Me.AxLaVolpeButton3.OcxState = CType(resources.GetObject("AxLaVolpeButton3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxLaVolpeButton3.Size = New System.Drawing.Size(96, 24)
        Me.AxLaVolpeButton3.TabIndex = 16
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ComboBox5.Items.AddRange(New Object() {"Stiched", "IsStiched"})
        Me.ComboBox5.Location = New System.Drawing.Point(248, 208)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(112, 24)
        Me.ComboBox5.TabIndex = 15
        '
        'TextBox9
        '
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox9.Location = New System.Drawing.Point(248, 176)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(104, 22)
        Me.TextBox9.TabIndex = 14
        Me.TextBox9.Text = ""
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox8.Location = New System.Drawing.Point(248, 144)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(80, 22)
        Me.TextBox8.TabIndex = 13
        Me.TextBox8.Text = ""
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox7.Location = New System.Drawing.Point(248, 112)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(208, 22)
        Me.TextBox7.TabIndex = 12
        Me.TextBox7.Text = ""
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox6.Location = New System.Drawing.Point(248, 80)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(160, 22)
        Me.TextBox6.TabIndex = 11
        Me.TextBox6.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(112, 208)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 16)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Cloth Type:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(112, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 24)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Cost Price: (Rs.)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(120, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 24)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Quantity To Change:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(136, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 24)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Cloth Description:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(160, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 24)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Cloth Name:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ComboBox2.Location = New System.Drawing.Point(96, 40)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(104, 24)
        Me.ComboBox2.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 24)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Select Cloth:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(152, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(232, 24)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Modify / Change Clothes Entry"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel2.Location = New System.Drawing.Point(0, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(520, 2)
        Me.Panel2.TabIndex = 1
        '
        'TextBox10
        '
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.Location = New System.Drawing.Point(584, 192)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(88, 20)
        Me.TextBox10.TabIndex = 19
        Me.TextBox10.Text = ""
        Me.TextBox10.Visible = False
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label9.Location = New System.Drawing.Point(0, 408)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(552, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Copyrights 2004 - All Rights Reserved "
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "clothes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("costprice", "costprice"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("Qty", "Qty"), New System.Data.Common.DataColumnMapping("serialno", "serialno"), New System.Data.Common.DataColumnMapping("clothtype", "clothtype")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM clothes WHERE (serialno = ?) AND (Description = ? OR ? IS NULL AND De" & _
        "scription IS NULL) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND (clothtype =" & _
        " ? OR ? IS NULL AND clothtype IS NULL) AND (costprice = ? OR ? IS NULL AND costp" & _
        "rice IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_serialno", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "serialno", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_clothtype", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "clothtype", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_clothtype1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "clothtype", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_costprice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "costprice", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_costprice1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "costprice", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=D:\HendraV" & _
        "B6\VB.NET SQL\BMS\Data.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB" & _
        ":System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Je" & _
        "t OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial" & _
        " Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password" & _
        "="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet " & _
        "OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repai" & _
        "r=False;Jet OLEDB:SFP=False"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO clothes(costprice, Description, Name, Qty, serialno, clothtype) VALUE" & _
        "S (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("costprice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "costprice", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Qty", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "Qty", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("serialno", System.Data.OleDb.OleDbType.VarWChar, 50, "serialno"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("clothtype", System.Data.OleDb.OleDbType.VarWChar, 50, "clothtype"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT costprice, Description, Name, Qty, serialno, clothtype FROM clothes"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE clothes SET costprice = ?, Description = ?, Name = ?, Qty = ?, serialno = " & _
        "?, clothtype = ? WHERE (serialno = ?) AND (Description = ? OR ? IS NULL AND Desc" & _
        "ription IS NULL) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND (clothtype = ?" & _
        " OR ? IS NULL AND clothtype IS NULL) AND (costprice = ? OR ? IS NULL AND costpri" & _
        "ce IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("costprice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "costprice", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Qty", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "Qty", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("serialno", System.Data.OleDb.OleDbType.VarWChar, 50, "serialno"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("clothtype", System.Data.OleDb.OleDbType.VarWChar, 50, "clothtype"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_serialno", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "serialno", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_clothtype", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "clothtype", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_clothtype1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "clothtype", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_costprice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "costprice", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_costprice1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "costprice", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "SELECT serialno FROM clothes"
        Me.OleDbCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbCommand4
        '
        Me.OleDbCommand4.CommandText = "SELECT clothes.* FROM clothes WHERE (serialno = ?)"
        Me.OleDbCommand4.Connection = Me.OleDbConnection1
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("serialno", System.Data.OleDb.OleDbType.VarWChar, 50, "serialno"))
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel4.Location = New System.Drawing.Point(0, 88)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(552, 2)
        Me.Panel4.TabIndex = 20
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(546, 423)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Panel4, Me.Label9, Me.TabControl1, Me.Label1, Me.PictureBox2, Me.TextBox10})
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " BMS - Clothes"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.AxLaVolpeButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxLaVolpeButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.AxLaVolpeButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxLaVolpeButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxLaVolpeButton3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New DataSet()
        OleDbDataAdapter1.Fill(ds, "Clothes")
        Dim TheTable As DataTable = ds.Tables(0)
        Dim aRow As DataRow = TheTable.NewRow
        TextBox1.Text = TheTable.Rows.Count + 1

        OleDbConnection1.Open()
        Dim objReader As OleDbDataReader = OleDbCommand1.ExecuteReader
        Do While objReader.Read()
            ComboBox2.Items.Add(objReader("serialno"))
        Loop
        OleDbConnection1.Close()
    End Sub

    Private Sub AxLaVolpeButton1_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxLaVolpeButton1.ClickEvent
        If TextBox2.Text = "" Then
            MsgBox("Enter A Name Please!", vbCritical)
            TextBox2.Focus()
            Exit Sub
        End If

        If TextBox3.Text = "" Then
            MsgBox("Enter A Description Please!", vbCritical)
            TextBox3.Focus()
            Exit Sub
        End If

        If TextBox4.Text = "" Then
            MsgBox("Enter A Quantity Please!", vbCritical)
            TextBox4.Focus()
            Exit Sub
        End If

        If Not IsNumeric(TextBox4.Text) Then
            MsgBox("Quantity should be Numeric!", vbCritical)
            TextBox4.Focus()
            Exit Sub
        End If

        If TextBox5.Text = "" Then
            MsgBox("Enter A Cost Price Please!", vbCritical)
            TextBox5.Focus()
            Exit Sub
        End If

        If Not IsNumeric(TextBox5.Text) Then
            MsgBox("Cost Price should be Numeric!", vbCritical)
            TextBox5.Focus()
            Exit Sub
        End If


        If ComboBox1.Text = "" Then
            MsgBox("Select A Cloth Type Please!", vbCritical)
            ComboBox1.Focus()
            Exit Sub
        End If

        OleDbConnection1.Open()
        OleDbDataAdapter1.InsertCommand.CommandText = _
        "INSERT INTO clothes (serialno,Name,Description,Qty,costprice,clothtype) " & _
        "VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & ComboBox1.Text & "')"
        OleDbDataAdapter1.InsertCommand.ExecuteNonQuery()
        MsgBox("Cloth Entry Saved Successfully!", vbInformation)
        OleDbConnection1.Close()
        curr = New Form1()
        curr.Show()
        Me.Visible = False
    End Sub

    Private Sub AxLaVolpeButton2_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxLaVolpeButton2.ClickEvent
        Me.Visible = False
        curr = New Form1()
        curr.Show()
    End Sub

    Private Sub AxLaVolpeButton3_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxLaVolpeButton3.ClickEvent
        If (ComboBox2.Text = "") Then
            MsgBox("Please Select A Cloth from the Drop Down Box!", vbCritical)
            ComboBox2.Focus()
            Exit Sub
        End If

        OleDbCommand4.Parameters("serialno").Value = ComboBox2.SelectedItem
        OleDbConnection1.Open()
        Dim objReader As OleDbDataReader = OleDbCommand4.ExecuteReader
        objReader.Read()
        TextBox10.Text = objReader("serialno")
        TextBox6.Text = objReader("Name")
        TextBox7.Text = objReader("Description")
        TextBox8.Text = objReader("Qty")
        TextBox9.Text = objReader("costprice")
        ComboBox5.Text = objReader("clothtype")
        objReader.Close()
        OleDbConnection1.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        On Error Resume Next
        OleDbCommand4.Parameters("serialno").Value = ComboBox2.SelectedItem
        OleDbConnection1.Open()
        Dim objReader As OleDbDataReader = OleDbCommand4.ExecuteReader
        objReader.Read()
        TextBox11.Text = objReader("Name")
        TextBox12.Text = objReader("Description")
        objReader.Close()
        OleDbConnection1.Close()
    End Sub

    Private Sub AxLaVolpeButton4_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxLaVolpeButton4.ClickEvent
        If TextBox6.Text = "" Then
            MsgBox("Enter A Name Please!", vbCritical)
            TextBox6.Focus()
            Exit Sub
        End If

        If TextBox7.Text = "" Then
            MsgBox("Enter A Description Please!", vbCritical)
            TextBox7.Focus()
            Exit Sub
        End If

        If TextBox8.Text = "" Then
            MsgBox("Enter A Quantity Please!", vbCritical)
            TextBox8.Focus()
            Exit Sub
        End If

        If Not IsNumeric(TextBox8.Text) Then
            MsgBox("Quantity should be Numeric!", vbCritical)
            TextBox8.Focus()
            Exit Sub
        End If

        If TextBox9.Text = "" Then
            MsgBox("Enter A Cost Price Please!", vbCritical)
            TextBox9.Focus()
            Exit Sub
        End If

        If Not IsNumeric(TextBox9.Text) Then
            MsgBox("Cost Price should be Numeric!", vbCritical)
            TextBox9.Focus()
            Exit Sub
        End If

        OleDbConnection1.Open()
        OleDbDataAdapter1.UpdateCommand.CommandText = _
        "UPDATE clothes SET costprice = '" & TextBox9.Text & "', Description = '" & TextBox7.Text & "', Name = '" & TextBox6.Text & "', Qty = '" & TextBox8.Text & "', clothtype = '" & ComboBox5.Text & "' WHERE serialno =  '" & TextBox10.Text & "' "
        OleDbDataAdapter1.UpdateCommand.ExecuteNonQuery()
        MsgBox("Cloth Entry Saved Successfully!", vbInformation)
        OleDbConnection1.Close()
        curr = New Form1()
        curr.Show()
        Me.Visible = False
    End Sub

    Private Sub AxLaVolpeButton5_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxLaVolpeButton5.ClickEvent
        Me.Visible = False
        curr = New Form1()
        curr.Show()
    End Sub

    Private Sub Form2_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Visible = False
        curr = New Form1()
        curr.Show()
    End Sub
End Class
