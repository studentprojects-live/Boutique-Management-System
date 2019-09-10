Imports System.Data.OleDb

Public Class Form3
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents AxLaVolpeButton1 As AxTombolPun.AxLaVolpeButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents AxLaVolpeButton2 As AxTombolPun.AxLaVolpeButton
    Friend WithEvents AxLaVolpeButton3 As AxTombolPun.AxLaVolpeButton
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents OleDbCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents OleDbCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbCommand5 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbCommand6 As System.Data.OleDb.OleDbCommand
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents AxLaVolpeButton4 As AxTombolPun.AxLaVolpeButton
    Friend WithEvents AxLaVolpeButton5 As AxTombolPun.AxLaVolpeButton
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents OleDbCommand7 As System.Data.OleDb.OleDbCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form3))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.AxLaVolpeButton3 = New AxTombolPun.AxLaVolpeButton()
        Me.AxLaVolpeButton2 = New AxTombolPun.AxLaVolpeButton()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.AxLaVolpeButton1 = New AxTombolPun.AxLaVolpeButton()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.AxLaVolpeButton5 = New AxTombolPun.AxLaVolpeButton()
        Me.AxLaVolpeButton4 = New AxTombolPun.AxLaVolpeButton()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.OleDbCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbCommand5 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbCommand6 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbCommand7 = New System.Data.OleDb.OleDbCommand()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.AxLaVolpeButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxLaVolpeButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxLaVolpeButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.AxLaVolpeButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxLaVolpeButton4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Location = New System.Drawing.Point(0, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 2)
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
        Me.TabPage1.Controls.AddRange(New System.Windows.Forms.Control() {Me.TextBox11, Me.AxLaVolpeButton3, Me.AxLaVolpeButton2, Me.TextBox9, Me.Label13, Me.TextBox8, Me.Label12, Me.DateTimePicker1, Me.Label11, Me.ComboBox2, Me.Label10, Me.AxLaVolpeButton1, Me.TextBox7, Me.Label9, Me.TextBox6, Me.Label8, Me.TextBox5, Me.Label7, Me.TextBox4, Me.Label5, Me.TextBox3, Me.Label4, Me.TextBox2, Me.TextBox1, Me.ComboBox1, Me.Label3, Me.Panel2, Me.Label2})
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(520, 275)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Clothes Selling"
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.White
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox11.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox11.Location = New System.Drawing.Point(416, 136)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(96, 22)
        Me.TextBox11.TabIndex = 29
        Me.TextBox11.Text = ""
        '
        'AxLaVolpeButton3
        '
        Me.AxLaVolpeButton3.ContainingControl = Me
        Me.AxLaVolpeButton3.Enabled = True
        Me.AxLaVolpeButton3.Location = New System.Drawing.Point(424, 232)
        Me.AxLaVolpeButton3.Name = "AxLaVolpeButton3"
        Me.AxLaVolpeButton3.OcxState = CType(resources.GetObject("AxLaVolpeButton3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxLaVolpeButton3.Size = New System.Drawing.Size(88, 24)
        Me.AxLaVolpeButton3.TabIndex = 28
        '
        'AxLaVolpeButton2
        '
        Me.AxLaVolpeButton2.ContainingControl = Me
        Me.AxLaVolpeButton2.Enabled = True
        Me.AxLaVolpeButton2.Location = New System.Drawing.Point(424, 200)
        Me.AxLaVolpeButton2.Name = "AxLaVolpeButton2"
        Me.AxLaVolpeButton2.OcxState = CType(resources.GetObject("AxLaVolpeButton2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxLaVolpeButton2.Size = New System.Drawing.Size(88, 24)
        Me.AxLaVolpeButton2.TabIndex = 27
        '
        'TextBox9
        '
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox9.Location = New System.Drawing.Point(320, 232)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(88, 22)
        Me.TextBox9.TabIndex = 26
        Me.TextBox9.Text = ""
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label13.Location = New System.Drawing.Point(224, 232)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 24)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Selling Price:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox8.Location = New System.Drawing.Point(320, 200)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(88, 22)
        Me.TextBox8.TabIndex = 24
        Me.TextBox8.Text = ""
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label12.Location = New System.Drawing.Point(216, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 16)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Quantity To Sell:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dddd dd MMMMM, yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(320, 168)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(192, 22)
        Me.DateTimePicker1.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label11.Location = New System.Drawing.Point(216, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 24)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Selling Date:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ComboBox2.Location = New System.Drawing.Point(320, 136)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(88, 24)
        Me.ComboBox2.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label10.Location = New System.Drawing.Point(208, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 24)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Select Customer:"
        '
        'AxLaVolpeButton1
        '
        Me.AxLaVolpeButton1.ContainingControl = Me
        Me.AxLaVolpeButton1.Enabled = True
        Me.AxLaVolpeButton1.Location = New System.Drawing.Point(360, 72)
        Me.AxLaVolpeButton1.Name = "AxLaVolpeButton1"
        Me.AxLaVolpeButton1.OcxState = CType(resources.GetObject("AxLaVolpeButton1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxLaVolpeButton1.Size = New System.Drawing.Size(152, 24)
        Me.AxLaVolpeButton1.TabIndex = 17
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox7.Location = New System.Drawing.Point(96, 200)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(112, 22)
        Me.TextBox7.TabIndex = 16
        Me.TextBox7.Text = ""
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label9.Location = New System.Drawing.Point(8, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 24)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Type:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox6.Location = New System.Drawing.Point(96, 168)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(104, 22)
        Me.TextBox6.TabIndex = 14
        Me.TextBox6.Text = ""
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label8.Location = New System.Drawing.Point(8, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 24)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Cost Price:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox5.Location = New System.Drawing.Point(96, 136)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(96, 22)
        Me.TextBox5.TabIndex = 12
        Me.TextBox5.Text = ""
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label7.Location = New System.Drawing.Point(8, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 24)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Available:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox4.Location = New System.Drawing.Point(96, 104)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(224, 22)
        Me.TextBox4.TabIndex = 10
        Me.TextBox4.Text = ""
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label5.Location = New System.Drawing.Point(8, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Description:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox3.Location = New System.Drawing.Point(96, 72)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(200, 22)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.Text = ""
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(8, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cloth Name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox2.Location = New System.Drawing.Point(360, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(152, 22)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox1.Location = New System.Drawing.Point(208, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(144, 22)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ComboBox1.Location = New System.Drawing.Point(96, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 24)
        Me.ComboBox1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(8, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Select Cloth:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel2.Location = New System.Drawing.Point(0, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(528, 2)
        Me.Panel2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(176, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Clothes Selling Entry"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.AddRange(New System.Windows.Forms.Control() {Me.TextBox13, Me.AxLaVolpeButton5, Me.AxLaVolpeButton4, Me.DateTimePicker2, Me.TextBox12, Me.Label17, Me.Label16, Me.ComboBox3, Me.Label15, Me.Panel3, Me.Label14})
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(520, 275)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Other Sellings And Income"
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.Color.White
        Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox13.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox13.Location = New System.Drawing.Point(336, 80)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.Size = New System.Drawing.Size(160, 22)
        Me.TextBox13.TabIndex = 11
        Me.TextBox13.Text = ""
        '
        'AxLaVolpeButton5
        '
        Me.AxLaVolpeButton5.ContainingControl = Me
        Me.AxLaVolpeButton5.Enabled = True
        Me.AxLaVolpeButton5.Location = New System.Drawing.Point(352, 176)
        Me.AxLaVolpeButton5.Name = "AxLaVolpeButton5"
        Me.AxLaVolpeButton5.OcxState = CType(resources.GetObject("AxLaVolpeButton5.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxLaVolpeButton5.Size = New System.Drawing.Size(111, 24)
        Me.AxLaVolpeButton5.TabIndex = 10
        '
        'AxLaVolpeButton4
        '
        Me.AxLaVolpeButton4.ContainingControl = Me
        Me.AxLaVolpeButton4.Enabled = True
        Me.AxLaVolpeButton4.Location = New System.Drawing.Point(232, 176)
        Me.AxLaVolpeButton4.Name = "AxLaVolpeButton4"
        Me.AxLaVolpeButton4.OcxState = CType(resources.GetObject("AxLaVolpeButton4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxLaVolpeButton4.Size = New System.Drawing.Size(111, 24)
        Me.AxLaVolpeButton4.TabIndex = 9
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dddd dd MMMMM, yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(232, 144)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(264, 22)
        Me.DateTimePicker2.TabIndex = 8
        '
        'TextBox12
        '
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox12.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox12.Location = New System.Drawing.Point(232, 112)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(216, 22)
        Me.TextBox12.TabIndex = 7
        Me.TextBox12.Text = ""
        '
        'Label17
        '
        Me.Label17.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label17.Location = New System.Drawing.Point(136, 152)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 16)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Enter Date:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label16.Location = New System.Drawing.Point(24, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(208, 24)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Amount Given By Customer: (Rs.)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ComboBox3.Location = New System.Drawing.Point(232, 80)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(96, 24)
        Me.ComboBox3.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label15.Location = New System.Drawing.Point(112, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 16)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Select Customer:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel3.Location = New System.Drawing.Point(8, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(520, 2)
        Me.Panel3.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label14.Location = New System.Drawing.Point(160, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(208, 24)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Other Sellings And Income"
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label6.Location = New System.Drawing.Point(0, 408)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(552, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Copyrights 2004 - All Rights Reserved "
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
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "SELECT serialno FROM clothes"
        Me.OleDbCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbCommand2
        '
        Me.OleDbCommand2.CommandText = "SELECT clothes.* FROM clothes WHERE (serialno = ?)"
        Me.OleDbCommand2.Connection = Me.OleDbConnection1
        Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("serialno", System.Data.OleDb.OleDbType.VarWChar, 50, "serialno"))
        '
        'TextBox10
        '
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.Location = New System.Drawing.Point(560, 128)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(80, 20)
        Me.TextBox10.TabIndex = 12
        Me.TextBox10.Text = ""
        Me.TextBox10.Visible = False
        '
        'OleDbCommand3
        '
        Me.OleDbCommand3.CommandText = "SELECT customerid FROM customer"
        Me.OleDbCommand3.Connection = Me.OleDbConnection1
        '
        'OleDbCommand4
        '
        Me.OleDbCommand4.CommandText = "SELECT customer.* FROM customer WHERE (customerid = ?)"
        Me.OleDbCommand4.Connection = Me.OleDbConnection1
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("customerid", System.Data.OleDb.OleDbType.VarWChar, 50, "customerid"))
        '
        'OleDbCommand5
        '
        Me.OleDbCommand5.Connection = Me.OleDbConnection1
        '
        'OleDbCommand6
        '
        Me.OleDbCommand6.Connection = Me.OleDbConnection1
        '
        'OleDbCommand7
        '
        Me.OleDbCommand7.Connection = Me.OleDbConnection1
        '
        'Form3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(546, 423)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TextBox10, Me.Label6, Me.TabControl1, Me.Panel1, Me.Label1, Me.PictureBox2})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " BMS - Clothes Selling"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.AxLaVolpeButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxLaVolpeButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxLaVolpeButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.AxLaVolpeButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxLaVolpeButton4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim detail_got As Boolean
    Dim testing As Integer

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        detail_got = False

        OleDbConnection1.Open()
        Dim objReader As OleDbDataReader = OleDbCommand1.ExecuteReader
        Do While objReader.Read()
            ComboBox1.Items.Add(objReader("serialno"))
        Loop
        OleDbConnection1.Close()

        OleDbConnection1.Open()
        Dim objReader2 As OleDbDataReader = OleDbCommand3.ExecuteReader
        Do While objReader2.Read()
            ComboBox2.Items.Add(objReader2("customerid"))
            ComboBox3.Items.Add(objReader2("customerid"))
        Loop
        OleDbConnection1.Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        On Error Resume Next
        OleDbCommand2.Parameters("serialno").Value = ComboBox1.SelectedItem
        OleDbConnection1.Open()
        Dim objReader As OleDbDataReader = OleDbCommand2.ExecuteReader
        objReader.Read()
        TextBox1.Text = objReader("Name")
        TextBox2.Text = objReader("Description")
        objReader.Close()
        OleDbConnection1.Close()
    End Sub

    Private Sub AxLaVolpeButton1_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxLaVolpeButton1.ClickEvent
        detail_got = True

        If (ComboBox1.Text = "") Then
            MsgBox("Please Select A Cloth from the Drop Down Box!", vbCritical)
            ComboBox1.Focus()
            Exit Sub
        End If

        OleDbCommand2.Parameters("serialno").Value = ComboBox1.SelectedItem
        OleDbConnection1.Open()
        Dim objReader As OleDbDataReader = OleDbCommand2.ExecuteReader
        objReader.Read()
        TextBox10.Text = objReader("serialno")
        TextBox3.Text = objReader("Name")
        TextBox4.Text = objReader("Description")
        TextBox5.Text = objReader("Qty")
        TextBox6.Text = objReader("costprice")
        TextBox7.Text = objReader("clothtype")
        objReader.Close()
        OleDbConnection1.Close()
    End Sub

    Private Sub AxLaVolpeButton2_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxLaVolpeButton2.ClickEvent
        Me.Visible = False
        curr = New Form1()
        curr.Show()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        On Error Resume Next
        OleDbCommand4.Parameters("customerid").Value = ComboBox2.SelectedItem
        OleDbConnection1.Open()
        Dim objReader As OleDbDataReader = OleDbCommand4.ExecuteReader
        objReader.Read()
        TextBox11.Text = objReader("Name")
        objReader.Close()
        OleDbConnection1.Close()
    End Sub

    Private Sub AxLaVolpeButton3_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxLaVolpeButton3.ClickEvent
        If ComboBox1.Text = "" Then
            MsgBox("Please Select A Cloth To Sell!", vbCritical)
            ComboBox1.Focus()
            Exit Sub
        End If

        If detail_got = False Then
            MsgBox("Please Click The Get Details Button!", vbCritical)
            Exit Sub
        End If

        If ComboBox2.Text = "" Then
            MsgBox("Please Select A Customer!", vbCritical)
            ComboBox2.Focus()
            Exit Sub
        End If

        If TextBox8.Text = "" Then
            MsgBox("Please Enter Quantity To Sell or Enter 0 in it!", vbCritical)
            TextBox8.Focus()
            Exit Sub
        End If

        If Not IsNumeric(TextBox8.Text) Then
            MsgBox("Quantity to Sell Has to be Number Format!", vbCritical)
            TextBox8.Focus()
            Exit Sub
        End If


        If Val(TextBox5.Text) < Val(TextBox8.Text) Then
            testing = MsgBox("You Are Selling more in Quantity than Available!" & vbCrLf & vbCrLf & "PLEASE NOTE THAT YOU ARE JUST SELLING MORE QUANTITY THAN AVAILABLE IN STOCK!" & vbCrLf & vbCrLf & "Do You Really Want To Sell More Than Available?", vbYesNo + vbCritical)
            If testing = vbYes Then
            Else
                TextBox8.Focus()
                Exit Sub
            End If
        End If


        If TextBox9.Text = "" Then
            MsgBox("Please Enter Selling Price!", vbCritical)
            TextBox9.Focus()
            Exit Sub
        End If

        If Val(TextBox9.Text) < Val(TextBox6.Text) Then
            testing = MsgBox("You Are Selling The Cloth at Lesser Price Than Its Cost, This is a LOSS!" & vbCrLf & vbCrLf & "Do You Want To Proceed?", vbYesNo + vbCritical)
            If testing = vbYes Then
            Else
                TextBox9.Focus()
                Exit Sub
            End If
        End If

        OleDbConnection1.Open()
        OleDbCommand5.CommandText = _
        "INSERT INTO selling (serialno,customerid,qty,amount,dated)" & _
        "VALUES ('" & ComboBox1.Text & "', '" & ComboBox2.Text & "', '" & TextBox8.Text & "','" & TextBox9.Text & "','" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "')"
        OleDbCommand5.ExecuteNonQuery()
        OleDbConnection1.Close()

        OleDbConnection1.Open()
        OleDbCommand6.CommandText = _
        "UPDATE clothes SET Qty= '" & CLng(CLng(TextBox5.Text) - CLng(TextBox8.Text)) & "' WHERE  serialno = '" & ComboBox1.Text & "'"
        OleDbCommand6.ExecuteNonQuery()
        OleDbConnection1.Close()

        MsgBox("Amount Given By Customer Saved Successfully!", vbInformation)


        If (CLng(TextBox5.Text) < CLng(TextBox8.Text)) Then
            MsgBox("PLEASE NOTE THAT YOU HAVE JUST SOLD MORE QUANTITY THAN AVAILABLE IN STOCK!")
        End If

        curr = New Form1()
        curr.Show()
        Me.Visible = False
    End Sub


    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        On Error Resume Next
        OleDbCommand4.Parameters("customerid").Value = ComboBox3.SelectedItem
        OleDbConnection1.Open()
        Dim objReader As OleDbDataReader = OleDbCommand4.ExecuteReader
        objReader.Read()
        TextBox13.Text = objReader("Name")
        objReader.Close()
        OleDbConnection1.Close()
    End Sub

    Private Sub AxLaVolpeButton4_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxLaVolpeButton4.ClickEvent
        If ComboBox3.Text = "" Then
            MsgBox("Please Select A Customer!", vbCritical)
            ComboBox3.Focus()
            Exit Sub
        End If

        If TextBox12.Text = "" Then
            MsgBox("Please Enter Amount or Enter 0 in it!", vbCritical)
            TextBox12.Focus()
            Exit Sub
        End If

        If Not IsNumeric(TextBox12.Text) Then
            MsgBox("Customer Amount Has to be Number Format!", vbCritical)
            TextBox12.Focus()
            Exit Sub
        End If


        OleDbConnection1.Open()
        OleDbCommand7.CommandText = _
        "INSERT INTO income (customerid,amount,dated)" & _
        "VALUES ('" & ComboBox3.Text & "', '" & TextBox12.Text & "', '" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "')"
        OleDbCommand7.ExecuteNonQuery()
        MsgBox("Amount Given By Customer Saved Successfully!", vbInformation)
        OleDbConnection1.Close()
        curr = New Form1()
        curr.Show()
        Me.Visible = False
    End Sub

    Private Sub AxLaVolpeButton5_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxLaVolpeButton5.ClickEvent
        curr = New Form1()
        curr.Show()
        Me.Visible = False
    End Sub

    Private Sub Form3_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Visible = False
        curr = New Form1()
        curr.Show()
    End Sub
End Class
