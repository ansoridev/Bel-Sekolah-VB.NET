<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetailJadwal
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.delbtn = New Guna.UI.WinForms.GunaButton()
        Me.editbtn = New Guna.UI.WinForms.GunaButton()
        Me.addbtn = New Guna.UI.WinForms.GunaButton()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.jadwalbeltxt = New Guna.UI.WinForms.GunaButton()
        Me.GunaShadowPanel2 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.volumebel = New System.Windows.Forms.Label()
        Me.lokasifilenya = New Guna.UI.WinForms.GunaTextBox()
        Me.volumenya = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.jamnya = New Guna.UI.WinForms.GunaTextBox()
        Me.haribel = New System.Windows.Forms.Label()
        Me.harinya = New Guna.UI.WinForms.GunaTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.namanya = New Guna.UI.WinForms.GunaTextBox()
        Me.cancelbtn = New Guna.UI.WinForms.GunaButton()
        Me.savebtn = New Guna.UI.WinForms.GunaButton()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.GunaShadowPanel2.SuspendLayout()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.delbtn)
        Me.GunaShadowPanel1.Controls.Add(Me.editbtn)
        Me.GunaShadowPanel1.Controls.Add(Me.addbtn)
        Me.GunaShadowPanel1.Controls.Add(Me.ListBox1)
        Me.GunaShadowPanel1.Controls.Add(Me.jadwalbeltxt)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(22, 12)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 15
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(260, 334)
        Me.GunaShadowPanel1.TabIndex = 18
        '
        'delbtn
        '
        Me.delbtn.AnimationHoverSpeed = 0.07!
        Me.delbtn.AnimationSpeed = 0.03!
        Me.delbtn.BackColor = System.Drawing.Color.Transparent
        Me.delbtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.delbtn.BorderColor = System.Drawing.Color.Black
        Me.delbtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.delbtn.FocusedColor = System.Drawing.Color.Empty
        Me.delbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.delbtn.ForeColor = System.Drawing.Color.White
        Me.delbtn.Image = Global.Bel_Sekolah.My.Resources.Resources.outline_delete_forever_white_18dp
        Me.delbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.delbtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.delbtn.Location = New System.Drawing.Point(20, 222)
        Me.delbtn.Name = "delbtn"
        Me.delbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.delbtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.delbtn.OnHoverForeColor = System.Drawing.Color.White
        Me.delbtn.OnHoverImage = Nothing
        Me.delbtn.OnPressedColor = System.Drawing.Color.Black
        Me.delbtn.Radius = 13
        Me.delbtn.Size = New System.Drawing.Size(73, 30)
        Me.delbtn.TabIndex = 16
        Me.delbtn.Text = "DEL"
        Me.delbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'editbtn
        '
        Me.editbtn.AnimationHoverSpeed = 0.07!
        Me.editbtn.AnimationSpeed = 0.03!
        Me.editbtn.BackColor = System.Drawing.Color.Transparent
        Me.editbtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.editbtn.BorderColor = System.Drawing.Color.Black
        Me.editbtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.editbtn.FocusedColor = System.Drawing.Color.Empty
        Me.editbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.editbtn.ForeColor = System.Drawing.Color.White
        Me.editbtn.Image = Global.Bel_Sekolah.My.Resources.Resources.outline_brush_white_18dp
        Me.editbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.editbtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.editbtn.Location = New System.Drawing.Point(20, 170)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.OnHoverBaseColor = System.Drawing.Color.Khaki
        Me.editbtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.editbtn.OnHoverForeColor = System.Drawing.Color.White
        Me.editbtn.OnHoverImage = Nothing
        Me.editbtn.OnPressedColor = System.Drawing.Color.Black
        Me.editbtn.Radius = 13
        Me.editbtn.Size = New System.Drawing.Size(73, 30)
        Me.editbtn.TabIndex = 15
        Me.editbtn.Text = "EDIT"
        Me.editbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'addbtn
        '
        Me.addbtn.AnimationHoverSpeed = 0.07!
        Me.addbtn.AnimationSpeed = 0.03!
        Me.addbtn.BackColor = System.Drawing.Color.Transparent
        Me.addbtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.addbtn.BorderColor = System.Drawing.Color.Black
        Me.addbtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.addbtn.FocusedColor = System.Drawing.Color.Empty
        Me.addbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.addbtn.ForeColor = System.Drawing.Color.White
        Me.addbtn.Image = Global.Bel_Sekolah.My.Resources.Resources.outline_control_point_white_18dp
        Me.addbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.addbtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.addbtn.Location = New System.Drawing.Point(20, 120)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.OnHoverBaseColor = System.Drawing.Color.DeepSkyBlue
        Me.addbtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.addbtn.OnHoverForeColor = System.Drawing.Color.White
        Me.addbtn.OnHoverImage = Nothing
        Me.addbtn.OnPressedColor = System.Drawing.Color.Black
        Me.addbtn.Radius = 13
        Me.addbtn.Size = New System.Drawing.Size(73, 30)
        Me.addbtn.TabIndex = 14
        Me.addbtn.Text = "ADD"
        Me.addbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Gadugi", 15.25!)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 24
        Me.ListBox1.Location = New System.Drawing.Point(105, 65)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(122, 244)
        Me.ListBox1.TabIndex = 1
        '
        'jadwalbeltxt
        '
        Me.jadwalbeltxt.AnimationHoverSpeed = 0.07!
        Me.jadwalbeltxt.AnimationSpeed = 0.03!
        Me.jadwalbeltxt.BackColor = System.Drawing.Color.Transparent
        Me.jadwalbeltxt.BaseColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.jadwalbeltxt.BorderColor = System.Drawing.Color.Black
        Me.jadwalbeltxt.DialogResult = System.Windows.Forms.DialogResult.None
        Me.jadwalbeltxt.FocusedColor = System.Drawing.Color.Empty
        Me.jadwalbeltxt.Font = New System.Drawing.Font("Gadugi", 11.0!)
        Me.jadwalbeltxt.ForeColor = System.Drawing.Color.White
        Me.jadwalbeltxt.Image = Global.Bel_Sekolah.My.Resources.Resources.outline_date_range_white_18dp
        Me.jadwalbeltxt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.jadwalbeltxt.ImageSize = New System.Drawing.Size(20, 20)
        Me.jadwalbeltxt.Location = New System.Drawing.Point(17, 16)
        Me.jadwalbeltxt.Name = "jadwalbeltxt"
        Me.jadwalbeltxt.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.jadwalbeltxt.OnHoverBorderColor = System.Drawing.Color.Black
        Me.jadwalbeltxt.OnHoverForeColor = System.Drawing.Color.White
        Me.jadwalbeltxt.OnHoverImage = Nothing
        Me.jadwalbeltxt.OnPressedColor = System.Drawing.Color.Black
        Me.jadwalbeltxt.Radius = 15
        Me.jadwalbeltxt.Size = New System.Drawing.Size(225, 33)
        Me.jadwalbeltxt.TabIndex = 0
        Me.jadwalbeltxt.Text = "Jadwal Bel Senin"
        Me.jadwalbeltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaShadowPanel2
        '
        Me.GunaShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel2.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel2.Controls.Add(Me.GunaDataGridView1)
        Me.GunaShadowPanel2.Location = New System.Drawing.Point(299, 12)
        Me.GunaShadowPanel2.Name = "GunaShadowPanel2"
        Me.GunaShadowPanel2.Radius = 15
        Me.GunaShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel2.Size = New System.Drawing.Size(552, 161)
        Me.GunaShadowPanel2.TabIndex = 19
        '
        'GunaDataGridView1
        '
        Me.GunaDataGridView1.AllowUserToAddRows = False
        Me.GunaDataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.GunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GunaDataGridView1.ColumnHeadersHeight = 21
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.GunaDataGridView1.EnableHeadersVisualStyles = False
        Me.GunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.Location = New System.Drawing.Point(27, 21)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.ReadOnly = True
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(498, 119)
        Me.GunaDataGridView1.TabIndex = 0
        Me.GunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Height = 21
        Me.GunaDataGridView1.ThemeStyle.ReadOnly = True
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaGroupBox1.Controls.Add(Me.Label5)
        Me.GunaGroupBox1.Controls.Add(Me.volumebel)
        Me.GunaGroupBox1.Controls.Add(Me.lokasifilenya)
        Me.GunaGroupBox1.Controls.Add(Me.volumenya)
        Me.GunaGroupBox1.Controls.Add(Me.Label3)
        Me.GunaGroupBox1.Controls.Add(Me.jamnya)
        Me.GunaGroupBox1.Controls.Add(Me.haribel)
        Me.GunaGroupBox1.Controls.Add(Me.harinya)
        Me.GunaGroupBox1.Controls.Add(Me.Label1)
        Me.GunaGroupBox1.Controls.Add(Me.namanya)
        Me.GunaGroupBox1.Controls.Add(Me.cancelbtn)
        Me.GunaGroupBox1.Controls.Add(Me.savebtn)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Gadugi", 10.25!)
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaGroupBox1.Location = New System.Drawing.Point(299, 182)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Radius = 15
        Me.GunaGroupBox1.Size = New System.Drawing.Size(552, 164)
        Me.GunaGroupBox1.TabIndex = 20
        Me.GunaGroupBox1.Text = "PENGATURAN DETAIL JADWAL"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(20, 6)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Gadugi", 10.25!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(53, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Lokasi File"
        '
        'volumebel
        '
        Me.volumebel.AutoSize = True
        Me.volumebel.BackColor = System.Drawing.Color.Transparent
        Me.volumebel.Font = New System.Drawing.Font("Gadugi", 10.25!)
        Me.volumebel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.volumebel.Location = New System.Drawing.Point(224, 92)
        Me.volumebel.Name = "volumebel"
        Me.volumebel.Size = New System.Drawing.Size(55, 17)
        Me.volumebel.TabIndex = 25
        Me.volumebel.Text = "Volume"
        '
        'lokasifilenya
        '
        Me.lokasifilenya.BackColor = System.Drawing.Color.Transparent
        Me.lokasifilenya.BaseColor = System.Drawing.Color.White
        Me.lokasifilenya.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.lokasifilenya.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lokasifilenya.FocusedBaseColor = System.Drawing.Color.White
        Me.lokasifilenya.FocusedBorderColor = System.Drawing.Color.Green
        Me.lokasifilenya.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.lokasifilenya.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lokasifilenya.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.lokasifilenya.Location = New System.Drawing.Point(151, 125)
        Me.lokasifilenya.Name = "lokasifilenya"
        Me.lokasifilenya.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lokasifilenya.Radius = 12
        Me.lokasifilenya.Size = New System.Drawing.Size(229, 26)
        Me.lokasifilenya.TabIndex = 24
        Me.lokasifilenya.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'volumenya
        '
        Me.volumenya.BackColor = System.Drawing.Color.Transparent
        Me.volumenya.BaseColor = System.Drawing.Color.White
        Me.volumenya.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.volumenya.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.volumenya.FocusedBaseColor = System.Drawing.Color.White
        Me.volumenya.FocusedBorderColor = System.Drawing.Color.Green
        Me.volumenya.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.volumenya.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.volumenya.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.volumenya.Location = New System.Drawing.Point(285, 88)
        Me.volumenya.Name = "volumenya"
        Me.volumenya.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.volumenya.Radius = 12
        Me.volumenya.Size = New System.Drawing.Size(136, 26)
        Me.volumenya.TabIndex = 24
        Me.volumenya.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 10.25!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(224, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Jam"
        '
        'jamnya
        '
        Me.jamnya.BackColor = System.Drawing.Color.Transparent
        Me.jamnya.BaseColor = System.Drawing.Color.White
        Me.jamnya.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.jamnya.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.jamnya.FocusedBaseColor = System.Drawing.Color.White
        Me.jamnya.FocusedBorderColor = System.Drawing.Color.Green
        Me.jamnya.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.jamnya.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.jamnya.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.jamnya.Location = New System.Drawing.Point(285, 52)
        Me.jamnya.Name = "jamnya"
        Me.jamnya.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.jamnya.Radius = 12
        Me.jamnya.Size = New System.Drawing.Size(136, 26)
        Me.jamnya.TabIndex = 22
        Me.jamnya.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'haribel
        '
        Me.haribel.AutoSize = True
        Me.haribel.BackColor = System.Drawing.Color.Transparent
        Me.haribel.Font = New System.Drawing.Font("Gadugi", 10.25!)
        Me.haribel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.haribel.Location = New System.Drawing.Point(13, 92)
        Me.haribel.Name = "haribel"
        Me.haribel.Size = New System.Drawing.Size(33, 17)
        Me.haribel.TabIndex = 21
        Me.haribel.Text = "Hari"
        '
        'harinya
        '
        Me.harinya.BackColor = System.Drawing.Color.Transparent
        Me.harinya.BaseColor = System.Drawing.Color.White
        Me.harinya.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.harinya.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.harinya.FocusedBaseColor = System.Drawing.Color.White
        Me.harinya.FocusedBorderColor = System.Drawing.Color.Green
        Me.harinya.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.harinya.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.harinya.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.harinya.Location = New System.Drawing.Point(63, 88)
        Me.harinya.Name = "harinya"
        Me.harinya.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.harinya.Radius = 12
        Me.harinya.Size = New System.Drawing.Size(136, 26)
        Me.harinya.TabIndex = 20
        Me.harinya.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 10.25!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Nama"
        '
        'namanya
        '
        Me.namanya.BackColor = System.Drawing.Color.Transparent
        Me.namanya.BaseColor = System.Drawing.Color.White
        Me.namanya.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.namanya.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.namanya.FocusedBaseColor = System.Drawing.Color.White
        Me.namanya.FocusedBorderColor = System.Drawing.Color.Green
        Me.namanya.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.namanya.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.namanya.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.namanya.Location = New System.Drawing.Point(63, 52)
        Me.namanya.Name = "namanya"
        Me.namanya.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.namanya.Radius = 12
        Me.namanya.Size = New System.Drawing.Size(136, 26)
        Me.namanya.TabIndex = 18
        Me.namanya.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cancelbtn
        '
        Me.cancelbtn.AnimationHoverSpeed = 0.07!
        Me.cancelbtn.AnimationSpeed = 0.03!
        Me.cancelbtn.BackColor = System.Drawing.Color.Transparent
        Me.cancelbtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.cancelbtn.BorderColor = System.Drawing.Color.Black
        Me.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cancelbtn.FocusedColor = System.Drawing.Color.Empty
        Me.cancelbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cancelbtn.ForeColor = System.Drawing.Color.White
        Me.cancelbtn.Image = Global.Bel_Sekolah.My.Resources.Resources.round_highlight_off_white_18dp
        Me.cancelbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cancelbtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.cancelbtn.Location = New System.Drawing.Point(439, 103)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cancelbtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cancelbtn.OnHoverForeColor = System.Drawing.Color.White
        Me.cancelbtn.OnHoverImage = Nothing
        Me.cancelbtn.OnPressedColor = System.Drawing.Color.Black
        Me.cancelbtn.Radius = 13
        Me.cancelbtn.Size = New System.Drawing.Size(97, 30)
        Me.cancelbtn.TabIndex = 17
        Me.cancelbtn.Text = "CANCEL"
        Me.cancelbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'savebtn
        '
        Me.savebtn.AnimationHoverSpeed = 0.07!
        Me.savebtn.AnimationSpeed = 0.03!
        Me.savebtn.BackColor = System.Drawing.Color.Transparent
        Me.savebtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.savebtn.BorderColor = System.Drawing.Color.Black
        Me.savebtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.savebtn.FocusedColor = System.Drawing.Color.Empty
        Me.savebtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.savebtn.ForeColor = System.Drawing.Color.White
        Me.savebtn.Image = Global.Bel_Sekolah.My.Resources.Resources.outline_control_point_white_18dp
        Me.savebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.savebtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.savebtn.Location = New System.Drawing.Point(439, 58)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.OnHoverBaseColor = System.Drawing.Color.DeepSkyBlue
        Me.savebtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.savebtn.OnHoverForeColor = System.Drawing.Color.White
        Me.savebtn.OnHoverImage = Nothing
        Me.savebtn.OnPressedColor = System.Drawing.Color.Black
        Me.savebtn.Radius = 13
        Me.savebtn.Size = New System.Drawing.Size(97, 30)
        Me.savebtn.TabIndex = 17
        Me.savebtn.Text = "SAVE"
        Me.savebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DetailJadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(874, 362)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.GunaShadowPanel2)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Name = "DetailJadwal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detail Jadwal"
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel2.ResumeLayout(False)
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents editbtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents addbtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents jadwalbeltxt As Guna.UI.WinForms.GunaButton
    Friend WithEvents delbtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaShadowPanel2 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents cancelbtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents savebtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label5 As Label
    Friend WithEvents volumebel As Label
    Friend WithEvents lokasifilenya As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents volumenya As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents jamnya As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents haribel As Label
    Friend WithEvents harinya As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents namanya As Guna.UI.WinForms.GunaTextBox
End Class
