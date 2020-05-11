<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.label1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.onoffbtn = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton4 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPanel1.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 25.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(260, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 41)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "21.09.03"
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.onoffbtn)
        Me.GunaPanel1.Controls.Add(Me.GunaAdvenceButton4)
        Me.GunaPanel1.Controls.Add(Me.GunaAdvenceButton3)
        Me.GunaPanel1.Controls.Add(Me.GunaAdvenceButton2)
        Me.GunaPanel1.Controls.Add(Me.GunaPanel2)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(245, 460)
        Me.GunaPanel1.TabIndex = 3
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.White
        Me.GunaPanel2.Controls.Add(Me.Panel1)
        Me.GunaPanel2.Controls.Add(Me.Label3)
        Me.GunaPanel2.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(245, 105)
        Me.GunaPanel2.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(250, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(869, 359)
        Me.Panel1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 17.25!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(95, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 54)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sistem " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bel Otomatis"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Gadugi", 11.25!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(263, 54)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(104, 19)
        Me.GunaLabel1.TabIndex = 4
        Me.GunaLabel1.Text = "07 Maret 2020"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(245, 102)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(876, 359)
        Me.Panel2.TabIndex = 5
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Global.Bel_Sekolah.My.Resources.Resources.round_minimize_white_18dp
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(1021, 12)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.Khaki
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 20
        Me.GunaButton1.Size = New System.Drawing.Size(40, 42)
        Me.GunaButton1.TabIndex = 8
        '
        'label1
        '
        Me.label1.AnimationHoverSpeed = 0.07!
        Me.label1.AnimationSpeed = 0.03!
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.label1.BorderColor = System.Drawing.Color.Black
        Me.label1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.label1.FocusedColor = System.Drawing.Color.Empty
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Image = Global.Bel_Sekolah.My.Resources.Resources.round_highlight_off_white_18dp
        Me.label1.ImageSize = New System.Drawing.Size(20, 20)
        Me.label1.Location = New System.Drawing.Point(1067, 12)
        Me.label1.Name = "label1"
        Me.label1.OnHoverBaseColor = System.Drawing.Color.Maroon
        Me.label1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.label1.OnHoverForeColor = System.Drawing.Color.White
        Me.label1.OnHoverImage = Nothing
        Me.label1.OnPressedColor = System.Drawing.Color.Black
        Me.label1.Radius = 20
        Me.label1.Size = New System.Drawing.Size(40, 42)
        Me.label1.TabIndex = 6
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = Global.Bel_Sekolah.My.Resources.Resources.idout
        Me.GunaPictureBox2.Location = New System.Drawing.Point(375, -48)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(780, 247)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox2.TabIndex = 7
        Me.GunaPictureBox2.TabStop = False
        '
        'onoffbtn
        '
        Me.onoffbtn.AnimationHoverSpeed = 0.07!
        Me.onoffbtn.AnimationSpeed = 0.03!
        Me.onoffbtn.BackColor = System.Drawing.Color.Transparent
        Me.onoffbtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.onoffbtn.BorderColor = System.Drawing.Color.Black
        Me.onoffbtn.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.onoffbtn.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.onoffbtn.CheckedForeColor = System.Drawing.Color.White
        Me.onoffbtn.CheckedImage = Global.Bel_Sekolah.My.Resources.Resources.outline_notifications_active_white_18dp
        Me.onoffbtn.CheckedLineColor = System.Drawing.Color.DimGray
        Me.onoffbtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.onoffbtn.FocusedColor = System.Drawing.Color.Empty
        Me.onoffbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.onoffbtn.ForeColor = System.Drawing.Color.White
        Me.onoffbtn.Image = Global.Bel_Sekolah.My.Resources.Resources.outline_notifications_off_white_18dp
        Me.onoffbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.onoffbtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.onoffbtn.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.onoffbtn.Location = New System.Drawing.Point(78, 143)
        Me.onoffbtn.Name = "onoffbtn"
        Me.onoffbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.onoffbtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.onoffbtn.OnHoverForeColor = System.Drawing.Color.White
        Me.onoffbtn.OnHoverImage = Nothing
        Me.onoffbtn.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.onoffbtn.OnPressedColor = System.Drawing.Color.Black
        Me.onoffbtn.Radius = 15
        Me.onoffbtn.Size = New System.Drawing.Size(87, 30)
        Me.onoffbtn.TabIndex = 12
        Me.onoffbtn.Text = "OFF"
        Me.onoffbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceButton4
        '
        Me.GunaAdvenceButton4.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton4.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.GunaAdvenceButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.GunaAdvenceButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.Checked = True
        Me.GunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.GunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.CheckedImage = Global.Bel_Sekolah.My.Resources.Resources.outline_dashboard_white_18dp
        Me.GunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.GunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton4.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.Image = Global.Bel_Sekolah.My.Resources.Resources.outline_dashboard_white_18dp
        Me.GunaAdvenceButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton4.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.GunaAdvenceButton4.LineLeft = 10
        Me.GunaAdvenceButton4.Location = New System.Drawing.Point(0, 205)
        Me.GunaAdvenceButton4.Name = "GunaAdvenceButton4"
        Me.GunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.OnHoverImage = Nothing
        Me.GunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.Size = New System.Drawing.Size(246, 53)
        Me.GunaAdvenceButton4.TabIndex = 10
        Me.GunaAdvenceButton4.Text = "Halaman Utama"
        Me.GunaAdvenceButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceButton3
        '
        Me.GunaAdvenceButton3.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton3.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.GunaAdvenceButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.GunaAdvenceButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.GunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.CheckedImage = Global.Bel_Sekolah.My.Resources.Resources.outline_info_white_18dp
        Me.GunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.GunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton3.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.Image = Global.Bel_Sekolah.My.Resources.Resources.outline_info_white_18dp
        Me.GunaAdvenceButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.GunaAdvenceButton3.LineLeft = 10
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(0, 323)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(246, 53)
        Me.GunaAdvenceButton3.TabIndex = 9
        Me.GunaAdvenceButton3.TabStop = False
        Me.GunaAdvenceButton3.Text = "Tentang Aplikasi"
        Me.GunaAdvenceButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceButton2
        '
        Me.GunaAdvenceButton2.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton2.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.GunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.CheckedImage = Global.Bel_Sekolah.My.Resources.Resources.outline_vpn_key_white_18dp
        Me.GunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.GunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton2.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.Image = Global.Bel_Sekolah.My.Resources.Resources.outline_vpn_key_white_18dp
        Me.GunaAdvenceButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.GunaAdvenceButton2.LineLeft = 10
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(0, 264)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(245, 53)
        Me.GunaAdvenceButton2.TabIndex = 8
        Me.GunaAdvenceButton2.TabStop = False
        Me.GunaAdvenceButton2.Text = "Ubah Kata Sandi"
        Me.GunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.Bel_Sekolah.My.Resources.Resources.logo
        Me.GunaPictureBox1.Location = New System.Drawing.Point(12, 13)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(77, 81)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 5
        Me.GunaPictureBox1.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1119, 460)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GunaPictureBox2)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton4 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents onoffbtn As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents label1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel2 As Panel
End Class
