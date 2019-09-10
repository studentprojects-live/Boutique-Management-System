Imports System.Data.OleDb

Public Class Form8
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AxLaVolpeButton1 As AxTombolPun.AxLaVolpeButton
    Friend WithEvents AxLaVolpeButton2 As AxTombolPun.AxLaVolpeButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form8))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AxLaVolpeButton2 = New AxTombolPun.AxLaVolpeButton()
        Me.AxLaVolpeButton1 = New AxTombolPun.AxLaVolpeButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxLaVolpeButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxLaVolpeButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox1.Location = New System.Drawing.Point(144, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 23)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox2.Location = New System.Drawing.Point(144, 72)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(192, 23)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = ""
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
        Me.OleDbCommand1.Connection = Me.OleDbConnection1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.AxLaVolpeButton2, Me.AxLaVolpeButton1, Me.Label2, Me.Label1, Me.TextBox1, Me.TextBox2})
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(96, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 152)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "System Login"
        '
        'AxLaVolpeButton2
        '
        Me.AxLaVolpeButton2.BackColor = System.Drawing.Color.White
        Me.AxLaVolpeButton2.ContainingControl = Me
        Me.AxLaVolpeButton2.Enabled = True
        Me.AxLaVolpeButton2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AxLaVolpeButton2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.AxLaVolpeButton2.Location = New System.Drawing.Point(248, 112)
        Me.AxLaVolpeButton2.Name = "AxLaVolpeButton2"
        Me.AxLaVolpeButton2.OcxState = CType(resources.GetObject("AxLaVolpeButton2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxLaVolpeButton2.Size = New System.Drawing.Size(88, 24)
        Me.AxLaVolpeButton2.TabIndex = 3
        '
        'AxLaVolpeButton1
        '
        Me.AxLaVolpeButton1.BackColor = System.Drawing.Color.White
        Me.AxLaVolpeButton1.ContainingControl = Me
        Me.AxLaVolpeButton1.Enabled = True
        Me.AxLaVolpeButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AxLaVolpeButton1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.AxLaVolpeButton1.Location = New System.Drawing.Point(144, 112)
        Me.AxLaVolpeButton1.Name = "AxLaVolpeButton1"
        Me.AxLaVolpeButton1.OcxState = CType(resources.GetObject("AxLaVolpeButton1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxLaVolpeButton1.Size = New System.Drawing.Size(96, 24)
        Me.AxLaVolpeButton1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(40, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(48, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login Id:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Bitmap)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(128, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(424, 48)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Boutique Management System"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel2.Location = New System.Drawing.Point(0, 296)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(552, 2)
        Me.Panel2.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label6.Location = New System.Drawing.Point(0, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(552, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Copyrights 2004 - All Rights Reserved "
        '
        'Form8
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(544, 319)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label6, Me.Panel2, Me.Label3, Me.PictureBox2, Me.GroupBox1})
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " BMS - System Login Screen"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.AxLaVolpeButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxLaVolpeButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub AxLaVolpeButton1_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxLaVolpeButton1.ClickEvent
        If TextBox1.Text = "" Then
            MsgBox("Enter A Login ID!", vbCritical)
            TextBox1.Focus()
            Exit Sub
        End If

        If TextBox2.Text = "" Then
            MsgBox("Enter A Password!", vbCritical)
            TextBox2.Focus()
            Exit Sub
        End If

        Try
            sel()
            OleDbConnection1.Open()
            Dim objReader As OleDbDataReader = OleDbCommand1.ExecuteReader
            objReader.Read()
            TextBox1.Text = objReader("userid")
            TextBox2.Text = objReader("pass")
            Me.Visible = False
            curr = New Form1()
            curr.Show()
            objReader.Close()
            OleDbConnection1.Close()
        Catch
            MsgBox("Wrong Login ID or Password! Try Again", vbCritical)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
            OleDbConnection1.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub sel()
        OleDbConnection1.Open()
        OleDbCommand1.CommandText = _
        "SELECT * from users where userid = '" & TextBox1.Text & "' and pass = '" & TextBox2.Text & "'"
        OleDbCommand1.ExecuteReader()
        OleDbConnection1.Close()
    End Sub

    Private Sub AxLaVolpeButton2_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxLaVolpeButton2.ClickEvent
        Application.Exit()
    End Sub

    Private Sub Form8_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Application.Exit()
    End Sub

End Class
