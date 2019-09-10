Imports System.Data.OleDb

Public Class Form4
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents AxLaVolpeButton1 As AxTombolPun.AxLaVolpeButton
    Friend WithEvents AxLaVolpeButton2 As AxTombolPun.AxLaVolpeButton
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents AxLaVolpeButton3 As AxTombolPun.AxLaVolpeButton
    Friend WithEvents AxLaVolpeButton4 As AxTombolPun.AxLaVolpeButton
    Friend WithEvents AxLaVolpeButton5 As AxTombolPun.AxLaVolpeButton
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents OleDbCommand2 As System.Data.OleDb.OleDbCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form4))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.AxLaVolpeButton2 = New AxTombolPun.AxLaVolpeButton()
        Me.AxLaVolpeButton1 = New AxTombolPun.AxLaVolpeButton()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.AxLaVolpeButton5 = New AxTombolPun.AxLaVolpeButton()
        Me.AxLaVolpeButton4 = New AxTombolPun.AxLaVolpeButton()
        Me.AxLaVolpeButton3 = New AxTombolPun.AxLaVolpeButton()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbCommand2 = New System.Data.OleDb.OleDbCommand()
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
        Me.PictureBox2.Size = New System.Drawing.Size(128, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(128, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 48)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Boutique Management System"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel1.Location = New System.Drawing.Point(0, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(552, 2)
        Me.Panel1.TabIndex = 13
        '
        'TabControl1
        '
        Me.TabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabPage1, Me.TabPage2})
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(8, 88)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(528, 312)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.AddRange(New System.Windows.Forms.Control() {Me.AxLaVolpeButton2, Me.AxLaVolpeButton1, Me.TextBox3, Me.Label5, Me.TextBox2, Me.Label4, Me.TextBox1, Me.Label3, Me.Panel2, Me.Label2})
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(520, 283)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Create New Customer"
        '
        'AxLaVolpeButton2
        '
        Me.AxLaVolpeButton2.ContainingControl = Me
        Me.AxLaVolpeButton2.Enabled = True
        Me.AxLaVolpeButton2.Location = New System.Drawing.Point(352, 192)
        Me.AxLaVolpeButton2.Name = "AxLaVolpeButton2"
        Me.AxLaVolpeButton2.OcxState = CType(resources.GetObject("AxLaVolpeButton2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxLaVolpeButton2.Size = New System.Drawing.Size(96, 24)
        Me.AxLaVolpeButton2.TabIndex = 9
        '
        'AxLaVolpeButton1
        '
        Me.AxLaVolpeButton1.ContainingControl = Me
        Me.AxLaVolpeButton1.Enabled = True
        Me.AxLaVolpeButton1.Location = New System.Drawing.Point(248, 192)
        Me.AxLaVolpeButton1.Name = "AxLaVolpeButton1"
        Me.AxLaVolpeButton1.OcxState = CType(resources.GetObject("AxLaVolpeButton1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxLaVolpeButton1.Size = New System.Drawing.Size(96, 24)
        Me.AxLaVolpeButton1.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox3.Location = New System.Drawing.Point(248, 152)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 22)
        Me.TextBox3.TabIndex = 7
        Me.TextBox3.Text = ""
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label5.Location = New System.Drawing.Point(104, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Customer Phone Nos.:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox2.Location = New System.Drawing.Point(248, 120)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 22)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = ""
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(120, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Customer Name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox1.Location = New System.Drawing.Point(248, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(104, 22)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = ""
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(96, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Customer Account No.:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel2.Location = New System.Drawing.Point(0, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(528, 2)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(144, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Create New Customer Account"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.AddRange(New System.Windows.Forms.Control() {Me.TextBox5, Me.AxLaVolpeButton5, Me.AxLaVolpeButton4, Me.AxLaVolpeButton3, Me.TextBox4, Me.Label9, Me.ComboBox1, Me.Label8, Me.Panel3, Me.Label7})
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(520, 283)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Settle Customer Dues"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox5.Location = New System.Drawing.Point(352, 88)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(144, 22)
        Me.TextBox5.TabIndex = 10
        Me.TextBox5.Text = ""
        '
        'AxLaVolpeButton5
        '
        Me.AxLaVolpeButton5.ContainingControl = Me
        Me.AxLaVolpeButton5.Enabled = True
        Me.AxLaVolpeButton5.Location = New System.Drawing.Point(352, 160)
        Me.AxLaVolpeButton5.Name = "AxLaVolpeButton5"
        Me.AxLaVolpeButton5.OcxState = CType(resources.GetObject("AxLaVolpeButton5.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxLaVolpeButton5.Size = New System.Drawing.Size(96, 24)
        Me.AxLaVolpeButton5.TabIndex = 9
        '
        'AxLaVolpeButton4
        '
        Me.AxLaVolpeButton4.ContainingControl = Me
        Me.AxLaVolpeButton4.Enabled = True
        Me.AxLaVolpeButton4.Location = New System.Drawing.Point(248, 160)
        Me.AxLaVolpeButton4.Name = "AxLaVolpeButton4"
        Me.AxLaVolpeButton4.OcxState = CType(resources.GetObject("AxLaVolpeButton4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxLaVolpeButton4.Size = New System.Drawing.Size(96, 24)
        Me.AxLaVolpeButton4.TabIndex = 8
        '
        'AxLaVolpeButton3
        '
        Me.AxLaVolpeButton3.ContainingControl = Me
        Me.AxLaVolpeButton3.Enabled = True
        Me.AxLaVolpeButton3.Location = New System.Drawing.Point(400, 120)
        Me.AxLaVolpeButton3.Name = "AxLaVolpeButton3"
        Me.AxLaVolpeButton3.OcxState = CType(resources.GetObject("AxLaVolpeButton3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxLaVolpeButton3.Size = New System.Drawing.Size(96, 24)
        Me.AxLaVolpeButton3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox4.Location = New System.Drawing.Point(248, 120)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(144, 22)
        Me.TextBox4.TabIndex = 6
        Me.TextBox4.Text = ""
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label9.Location = New System.Drawing.Point(104, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 24)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Customer Dues: (Rs.)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ComboBox1.Location = New System.Drawing.Point(248, 88)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(96, 24)
        Me.ComboBox1.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label8.Location = New System.Drawing.Point(136, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 24)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Select Customer:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel3.Location = New System.Drawing.Point(0, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(528, 2)
        Me.Panel3.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label7.Location = New System.Drawing.Point(176, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Settle Customer Dues"
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label6.Location = New System.Drawing.Point(0, 408)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(552, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Copyrights 2004 - All Rights Reserved "
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "customer", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("customerid", "customerid"), New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("Phones", "Phones"), New System.Data.Common.DataColumnMapping("Dues", "Dues")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM customer WHERE (customerid = ?) AND (Dues = ? OR ? IS NULL AND Dues I" & _
        "S NULL) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND (Phones = ? OR ? IS NUL" & _
        "L AND Phones IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_customerid", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "customerid", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Dues", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "Dues", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Dues1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "Dues", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phones", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phones", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phones1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phones", System.Data.DataRowVersion.Original, Nothing))
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
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO customer(customerid, Dues, Name, Phones) VALUES (?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("customerid", System.Data.OleDb.OleDbType.VarWChar, 50, "customerid"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Dues", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "Dues", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 100, "Name"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Phones", System.Data.OleDb.OleDbType.VarWChar, 0, "Phones"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT customerid, Dues, Name, Phones FROM customer"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE customer SET customerid = ?, Dues = ?, Name = ?, Phones = ? WHERE (custome" & _
        "rid = ?) AND (Dues = ? OR ? IS NULL AND Dues IS NULL) AND (Name = ? OR ? IS NULL" & _
        " AND Name IS NULL) AND (Phones = ? OR ? IS NULL AND Phones IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("customerid", System.Data.OleDb.OleDbType.VarWChar, 50, "customerid"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Dues", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "Dues", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 100, "Name"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Phones", System.Data.OleDb.OleDbType.VarWChar, 0, "Phones"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_customerid", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "customerid", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Dues", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "Dues", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Dues1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "Dues", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phones", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phones", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phones1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phones", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "SELECT customerid FROM customer"
        Me.OleDbCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbCommand2
        '
        Me.OleDbCommand2.CommandText = "SELECT customer.* FROM customer WHERE (customerid = ?)"
        Me.OleDbCommand2.Connection = Me.OleDbConnection1
        Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("customerid", System.Data.OleDb.OleDbType.VarWChar, 50, "customerid"))
        '
        'Form4
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(544, 421)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label6, Me.TabControl1, Me.Panel1, Me.Label1, Me.PictureBox2})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " BMS - Customers"
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


    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New DataSet()
        OleDbDataAdapter1.Fill(ds, "customer")
        Dim TheTable As DataTable = ds.Tables(0)
        Dim aRow As DataRow = TheTable.NewRow
        TextBox1.Text = TheTable.Rows.Count + 1

        OleDbConnection1.Open()
        Dim objReader As OleDbDataReader = OleDbCommand1.ExecuteReader
        Do While objReader.Read()
            ComboBox1.Items.Add(objReader("customerid"))
        Loop
        OleDbConnection1.Close()
    End Sub

    Private Sub AxLaVolpeButton2_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxLaVolpeButton2.ClickEvent
        Me.Visible = False
        curr = New Form1()
        curr.Show()
    End Sub

    Private Sub Form4_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Visible = False
        curr = New Form1()
        curr.Show()
    End Sub

    Private Sub AxLaVolpeButton1_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxLaVolpeButton1.ClickEvent
        If TextBox2.Text = "" Then
            MsgBox("Enter A Name Please!", vbCritical)
            TextBox2.Focus()
            Exit Sub
        End If

        If TextBox3.Text = "" Then
            MsgBox("Enter A Phone No Please!", vbCritical)
            TextBox3.Focus()
            Exit Sub
        End If

        OleDbConnection1.Open()
        OleDbDataAdapter1.InsertCommand.CommandText = _
                "INSERT INTO customer(customerid,Name,Phones) " & _
                "VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "', '" & TextBox3.Text & "')"
        OleDbDataAdapter1.InsertCommand.ExecuteNonQuery()
        MsgBox("Customer Account Created Successfully!", vbInformation)
        OleDbConnection1.Close()
        curr = New Form1()
        curr.Show()
        Me.Visible = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        On Error Resume Next
        OleDbCommand2.Parameters("customerid").Value = ComboBox1.SelectedItem
        OleDbConnection1.Open()
        Dim objReader As OleDbDataReader = OleDbCommand2.ExecuteReader
        objReader.Read()
        TextBox5.Text = objReader("Name")
        objReader.Close()
        OleDbConnection1.Close()
    End Sub

    Private Sub AxLaVolpeButton3_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxLaVolpeButton3.ClickEvent
        If ComboBox1.Text = "" Then
            MsgBox("Please Select A Customer!", vbCritical)
            ComboBox1.Focus()
            Exit Sub
        End If

        OleDbCommand2.Parameters("customerid").Value = ComboBox1.SelectedItem
        OleDbConnection1.Open()
        Dim objReader As OleDbDataReader = OleDbCommand2.ExecuteReader
        objReader.Read()
        TextBox4.Text = objReader("Dues")
        objReader.Close()
        OleDbConnection1.Close()
    End Sub

    Private Sub AxLaVolpeButton4_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxLaVolpeButton4.ClickEvent
        If ComboBox1.Text = "" Then
            MsgBox("Please Select A Customer!", vbCritical)
            ComboBox1.Focus()
            Exit Sub
        End If

        If TextBox4.Text = "" Then
            MsgBox("Please Enter Dues or Enter 0 in Dues", vbCritical)
            TextBox4.Focus()
            Exit Sub
        End If

        If Not IsNumeric(TextBox4.Text) Then
            MsgBox("Customer Dues Have to be Number Format!", vbCritical)
            TextBox4.Focus()
            Exit Sub
        End If

        OleDbConnection1.Open()
        OleDbDataAdapter1.UpdateCommand.CommandText = _
        "UPDATE customer SET Dues = '" & TextBox4.Text & "' WHERE customerid =  '" & ComboBox1.Text & "' AND Name= '" & TextBox5.Text & "'"
        OleDbDataAdapter1.UpdateCommand.ExecuteNonQuery()
        MsgBox("Customer Dues Saved Successfully!", vbInformation)
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

End Class
