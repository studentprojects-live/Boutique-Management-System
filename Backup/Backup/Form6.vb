Public Class Form6
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AxLaVolpeButton3 As AxTombolPun.AxLaVolpeButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents AxLaVolpeButton1 As AxTombolPun.AxLaVolpeButton
    Friend WithEvents AxLaVolpeButton2 As AxTombolPun.AxLaVolpeButton
    Friend WithEvents AxLaVolpeButton4 As AxTombolPun.AxLaVolpeButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form6))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AxLaVolpeButton3 = New AxTombolPun.AxLaVolpeButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.AxLaVolpeButton1 = New AxTombolPun.AxLaVolpeButton()
        Me.AxLaVolpeButton2 = New AxTombolPun.AxLaVolpeButton()
        Me.AxLaVolpeButton4 = New AxTombolPun.AxLaVolpeButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.AxLaVolpeButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxLaVolpeButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxLaVolpeButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxLaVolpeButton4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(201, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "PRINT REPORTS"
        '
        'AxLaVolpeButton3
        '
        Me.AxLaVolpeButton3.Enabled = True
        Me.AxLaVolpeButton3.Location = New System.Drawing.Point(152, 168)
        Me.AxLaVolpeButton3.Name = "AxLaVolpeButton3"
        Me.AxLaVolpeButton3.OcxState = CType(resources.GetObject("AxLaVolpeButton3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxLaVolpeButton3.Size = New System.Drawing.Size(240, 32)
        Me.AxLaVolpeButton3.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label6.Location = New System.Drawing.Point(0, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(552, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Copyrights 2004 - All Rights Reserved "
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel3.Location = New System.Drawing.Point(0, 296)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(552, 2)
        Me.Panel3.TabIndex = 20
        '
        'AxLaVolpeButton1
        '
        Me.AxLaVolpeButton1.Enabled = True
        Me.AxLaVolpeButton1.Location = New System.Drawing.Point(152, 128)
        Me.AxLaVolpeButton1.Name = "AxLaVolpeButton1"
        Me.AxLaVolpeButton1.OcxState = CType(resources.GetObject("AxLaVolpeButton1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxLaVolpeButton1.Size = New System.Drawing.Size(240, 32)
        Me.AxLaVolpeButton1.TabIndex = 1
        '
        'AxLaVolpeButton2
        '
        Me.AxLaVolpeButton2.Enabled = True
        Me.AxLaVolpeButton2.Location = New System.Drawing.Point(152, 208)
        Me.AxLaVolpeButton2.Name = "AxLaVolpeButton2"
        Me.AxLaVolpeButton2.OcxState = CType(resources.GetObject("AxLaVolpeButton2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxLaVolpeButton2.Size = New System.Drawing.Size(240, 32)
        Me.AxLaVolpeButton2.TabIndex = 3
        '
        'AxLaVolpeButton4
        '
        Me.AxLaVolpeButton4.Enabled = True
        Me.AxLaVolpeButton4.Location = New System.Drawing.Point(152, 248)
        Me.AxLaVolpeButton4.Name = "AxLaVolpeButton4"
        Me.AxLaVolpeButton4.OcxState = CType(resources.GetObject("AxLaVolpeButton4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxLaVolpeButton4.Size = New System.Drawing.Size(240, 32)
        Me.AxLaVolpeButton4.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel2.Location = New System.Drawing.Point(0, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(552, 2)
        Me.Panel2.TabIndex = 24
        '
        'Form6
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(546, 319)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Panel2, Me.AxLaVolpeButton4, Me.AxLaVolpeButton2, Me.AxLaVolpeButton1, Me.Panel3, Me.Label6, Me.AxLaVolpeButton3, Me.Label2, Me.Panel1, Me.Label1, Me.PictureBox2})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " BMS - View Reports"
        CType(Me.AxLaVolpeButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxLaVolpeButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxLaVolpeButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxLaVolpeButton4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form6_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Visible = False
        curr = New Form1()
        curr.Show()
    End Sub

    Private Sub AxLaVolpeButton3_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxLaVolpeButton3.ClickEvent
        Me.Visible = False
        curr = New Form7()
        curr.Show()
    End Sub

    Private Sub AxLaVolpeButton1_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxLaVolpeButton1.ClickEvent
        Me.Visible = False
        curr = New Form9()
        curr.Show()
    End Sub

    Private Sub AxLaVolpeButton2_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxLaVolpeButton2.ClickEvent
        Me.Visible = False
        curr = New Form10()
        curr.Show()
    End Sub

    Private Sub AxLaVolpeButton4_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxLaVolpeButton4.ClickEvent
        Me.Visible = False
        curr = New Form11()
        curr.Show()
    End Sub
End Class
