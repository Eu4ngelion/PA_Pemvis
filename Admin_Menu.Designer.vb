<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_Menu
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
        components = New ComponentModel.Container()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        txtCari = New TextBox()
        MenuStrip1 = New MenuStrip()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        txtPenulis = New TextBox()
        txtStok = New TextBox()
        txtJudul = New TextBox()
        Label9 = New Label()
        comboId = New ComboBox()
        radioFiksi = New RadioButton()
        CheckBox1 = New CheckBox()
        BindingSource1 = New BindingSource(components)
        groupJenis = New GroupBox()
        radioNonFiksi = New RadioButton()
        groupGenre = New GroupBox()
        CheckBox6 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox7 = New CheckBox()
        txtHarga = New TextBox()
        Label10 = New Label()
        dateTahunTerbit = New DateTimePicker()
        pictCover = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        Panel1 = New Panel()
        Label17 = New Label()
        txtDeskripsi = New TextBox()
        btnTambah = New Button()
        Label11 = New Label()
        PanelMenuAdmin = New Panel()
        Label6 = New Label()
        btnEdit = New Button()
        BtnHapus = New Button()
        btnUpload = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        groupJenis.SuspendLayout()
        groupGenre.SuspendLayout()
        CType(pictCover, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        PanelMenuAdmin.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.BackgroundColor = SystemColors.ActiveCaption
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(497, 96)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.ScrollBars = ScrollBars.Vertical
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(551, 497)
        DataGridView1.TabIndex = 0
        DataGridView1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(13, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(213, 28)
        Label1.TabIndex = 1
        Label1.Text = "DASHBOARD ADMIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 2
        Label2.Text = "Id Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(29, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 20)
        Label3.TabIndex = 3
        Label3.Text = "Judul"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 130)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 20)
        Label4.TabIndex = 3
        Label4.Text = "Penulis"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(30, 165)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 20)
        Label5.TabIndex = 3
        Label5.Text = "Tahun Terbit"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(275, 62)
        Label7.Name = "Label7"
        Label7.Size = New Size(38, 20)
        Label7.TabIndex = 3
        Label7.Text = "Stok"
        ' 
        ' txtCari
        ' 
        txtCari.BorderStyle = BorderStyle.FixedSingle
        txtCari.Location = New Point(538, 58)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(510, 27)
        txtCari.TabIndex = 17
        txtCari.Text = "txtCari"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ActiveCaption
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {LogoutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1062, 28)
        MenuStrip1.TabIndex = 7
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right
        LogoutToolStripMenuItem.BackColor = Color.Crimson
        LogoutToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text
        LogoutToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LogoutToolStripMenuItem.ForeColor = Color.White
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(73, 24)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' txtPenulis
        ' 
        txtPenulis.BorderStyle = BorderStyle.FixedSingle
        txtPenulis.Location = New Point(126, 130)
        txtPenulis.MaxLength = 50
        txtPenulis.Name = "txtPenulis"
        txtPenulis.Size = New Size(333, 27)
        txtPenulis.TabIndex = 4
        ' 
        ' txtStok
        ' 
        txtStok.BorderStyle = BorderStyle.FixedSingle
        txtStok.Location = New Point(316, 58)
        txtStok.MaxLength = 10
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(143, 27)
        txtStok.TabIndex = 2
        ' 
        ' txtJudul
        ' 
        txtJudul.BorderStyle = BorderStyle.FixedSingle
        txtJudul.Location = New Point(126, 94)
        txtJudul.MaxLength = 50
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(333, 27)
        txtJudul.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(143, 194)
        Label9.Name = "Label9"
        Label9.Size = New Size(0, 20)
        Label9.TabIndex = 3
        ' 
        ' comboId
        ' 
        comboId.FormattingEnabled = True
        comboId.Location = New Point(126, 57)
        comboId.MaxLength = 10
        comboId.Name = "comboId"
        comboId.Size = New Size(140, 28)
        comboId.TabIndex = 0
        ' 
        ' radioFiksi
        ' 
        radioFiksi.AutoSize = True
        radioFiksi.Location = New Point(20, 26)
        radioFiksi.Name = "radioFiksi"
        radioFiksi.Size = New Size(58, 24)
        radioFiksi.TabIndex = 7
        radioFiksi.TabStop = True
        radioFiksi.Text = "Fiksi"
        radioFiksi.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(18, 27)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(78, 24)
        CheckBox1.TabIndex = 8
        CheckBox1.Text = "Genre1"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' groupJenis
        ' 
        groupJenis.Controls.Add(radioNonFiksi)
        groupJenis.Controls.Add(radioFiksi)
        groupJenis.FlatStyle = FlatStyle.Popup
        groupJenis.Location = New Point(24, 239)
        groupJenis.Name = "groupJenis"
        groupJenis.Size = New Size(193, 61)
        groupJenis.TabIndex = 6
        groupJenis.TabStop = False
        groupJenis.Text = "Jenis Buku"
        ' 
        ' radioNonFiksi
        ' 
        radioNonFiksi.AutoSize = True
        radioNonFiksi.Location = New Point(89, 26)
        radioNonFiksi.Name = "radioNonFiksi"
        radioNonFiksi.Size = New Size(92, 24)
        radioNonFiksi.TabIndex = 8
        radioNonFiksi.TabStop = True
        radioNonFiksi.Text = "Non-Fiksi"
        radioNonFiksi.UseVisualStyleBackColor = True
        ' 
        ' groupGenre
        ' 
        groupGenre.Controls.Add(CheckBox6)
        groupGenre.Controls.Add(CheckBox3)
        groupGenre.Controls.Add(CheckBox8)
        groupGenre.Controls.Add(CheckBox5)
        groupGenre.Controls.Add(CheckBox2)
        groupGenre.Controls.Add(CheckBox4)
        groupGenre.Controls.Add(CheckBox7)
        groupGenre.Controls.Add(CheckBox1)
        groupGenre.FlatStyle = FlatStyle.Popup
        groupGenre.Location = New Point(26, 312)
        groupGenre.Name = "groupGenre"
        groupGenre.Size = New Size(427, 91)
        groupGenre.TabIndex = 7
        groupGenre.TabStop = False
        groupGenre.Text = "Genre"
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(101, 55)
        CheckBox6.Margin = New Padding(2)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(78, 24)
        CheckBox6.TabIndex = 15
        CheckBox6.Text = "Genre6"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(184, 27)
        CheckBox3.Margin = New Padding(2)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(78, 24)
        CheckBox3.TabIndex = 14
        CheckBox3.Text = "Genre3"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(269, 55)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(78, 24)
        CheckBox8.TabIndex = 13
        CheckBox8.Text = "Genre8"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(18, 55)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(78, 24)
        CheckBox5.TabIndex = 11
        CheckBox5.Text = "Genre5"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(101, 27)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(78, 24)
        CheckBox2.TabIndex = 9
        CheckBox2.Text = "Genre2"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(268, 27)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(78, 24)
        CheckBox4.TabIndex = 10
        CheckBox4.Text = "Genre4"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(184, 55)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(78, 24)
        CheckBox7.TabIndex = 12
        CheckBox7.Text = "Genre7"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' txtHarga
        ' 
        txtHarga.BorderStyle = BorderStyle.FixedSingle
        txtHarga.Location = New Point(126, 200)
        txtHarga.MaxLength = 20
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(333, 27)
        txtHarga.TabIndex = 6
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(30, 200)
        Label10.Name = "Label10"
        Label10.Size = New Size(50, 20)
        Label10.TabIndex = 15
        Label10.Text = "Harga"
        ' 
        ' dateTahunTerbit
        ' 
        dateTahunTerbit.CustomFormat = "yyyy"
        dateTahunTerbit.Format = DateTimePickerFormat.Custom
        dateTahunTerbit.Location = New Point(126, 165)
        dateTahunTerbit.MaxDate = New Date(2099, 5, 11, 0, 0, 0, 0)
        dateTahunTerbit.Name = "dateTahunTerbit"
        dateTahunTerbit.Size = New Size(333, 27)
        dateTahunTerbit.TabIndex = 5
        dateTahunTerbit.Value = New Date(2025, 5, 11, 0, 0, 0, 0)
        ' 
        ' pictCover
        ' 
        pictCover.BackColor = Color.Silver
        pictCover.Location = New Point(29, 434)
        pictCover.Name = "pictCover"
        pictCover.Size = New Size(140, 163)
        pictCover.SizeMode = PictureBoxSizeMode.Zoom
        pictCover.TabIndex = 14
        pictCover.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-4, -20)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1075, 58)
        Panel1.TabIndex = 21
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(294, 413)
        Label17.Margin = New Padding(2, 0, 2, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(69, 20)
        Label17.TabIndex = 19
        Label17.Text = "Deskripsi"
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.BorderStyle = BorderStyle.FixedSingle
        txtDeskripsi.Location = New Point(195, 435)
        txtDeskripsi.Margin = New Padding(2)
        txtDeskripsi.MaxLength = 255
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.Size = New Size(264, 197)
        txtDeskripsi.TabIndex = 18
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.MediumSeaGreen
        btnTambah.FlatStyle = FlatStyle.Popup
        btnTambah.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(497, 598)
        btnTambah.Margin = New Padding(2)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(170, 40)
        btnTambah.TabIndex = 17
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(60, 413)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(83, 20)
        Label11.TabIndex = 16
        Label11.Text = "Cover Buku"
        ' 
        ' PanelMenuAdmin
        ' 
        PanelMenuAdmin.Controls.Add(Label6)
        PanelMenuAdmin.Controls.Add(Label17)
        PanelMenuAdmin.Controls.Add(Panel1)
        PanelMenuAdmin.Controls.Add(txtCari)
        PanelMenuAdmin.Controls.Add(comboId)
        PanelMenuAdmin.Controls.Add(txtDeskripsi)
        PanelMenuAdmin.Controls.Add(btnTambah)
        PanelMenuAdmin.Controls.Add(Label2)
        PanelMenuAdmin.Controls.Add(DataGridView1)
        PanelMenuAdmin.Controls.Add(dateTahunTerbit)
        PanelMenuAdmin.Controls.Add(txtHarga)
        PanelMenuAdmin.Controls.Add(Label10)
        PanelMenuAdmin.Controls.Add(Label3)
        PanelMenuAdmin.Controls.Add(groupGenre)
        PanelMenuAdmin.Controls.Add(btnEdit)
        PanelMenuAdmin.Controls.Add(Label7)
        PanelMenuAdmin.Controls.Add(BtnHapus)
        PanelMenuAdmin.Controls.Add(txtStok)
        PanelMenuAdmin.Controls.Add(btnUpload)
        PanelMenuAdmin.Controls.Add(txtJudul)
        PanelMenuAdmin.Controls.Add(Label5)
        PanelMenuAdmin.Controls.Add(groupJenis)
        PanelMenuAdmin.Controls.Add(Label11)
        PanelMenuAdmin.Controls.Add(Label4)
        PanelMenuAdmin.Controls.Add(txtPenulis)
        PanelMenuAdmin.Controls.Add(pictCover)
        PanelMenuAdmin.Location = New Point(0, 24)
        PanelMenuAdmin.Margin = New Padding(2)
        PanelMenuAdmin.Name = "PanelMenuAdmin"
        PanelMenuAdmin.Size = New Size(1071, 713)
        PanelMenuAdmin.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(497, 61)
        Label6.Name = "Label6"
        Label6.Size = New Size(35, 20)
        Label6.TabIndex = 52
        Label6.Text = "Cari"
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.SteelBlue
        btnEdit.FlatStyle = FlatStyle.Popup
        btnEdit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(692, 598)
        btnEdit.Margin = New Padding(2)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(170, 40)
        btnEdit.TabIndex = 51
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' BtnHapus
        ' 
        BtnHapus.BackColor = Color.Crimson
        BtnHapus.FlatStyle = FlatStyle.Popup
        BtnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnHapus.ForeColor = Color.White
        BtnHapus.Location = New Point(878, 598)
        BtnHapus.Margin = New Padding(2)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(170, 40)
        BtnHapus.TabIndex = 35
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnUpload
        ' 
        btnUpload.BackColor = Color.SteelBlue
        btnUpload.FlatStyle = FlatStyle.Popup
        btnUpload.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUpload.ForeColor = Color.White
        btnUpload.Location = New Point(29, 603)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(140, 29)
        btnUpload.TabIndex = 15
        btnUpload.Text = "Upload"
        btnUpload.UseVisualStyleBackColor = False
        ' 
        ' Admin_Menu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1062, 721)
        Controls.Add(Label9)
        Controls.Add(MenuStrip1)
        Controls.Add(PanelMenuAdmin)
        MainMenuStrip = MenuStrip1
        MaximumSize = New Size(1080, 768)
        MinimumSize = New Size(1080, 768)
        Name = "Admin_Menu"
        Text = "Haven Media (Admin)"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        groupJenis.ResumeLayout(False)
        groupJenis.PerformLayout()
        groupGenre.ResumeLayout(False)
        groupGenre.PerformLayout()
        CType(pictCover, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        PanelMenuAdmin.ResumeLayout(False)
        PanelMenuAdmin.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents labelCari As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtPenulis As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents comboId As ComboBox
    Friend WithEvents radioFiksi As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents groupJenis As GroupBox
    Friend WithEvents radioNonFiksi As RadioButton
    Friend WithEvents groupGenre As GroupBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dateTahunTerbit As DateTimePicker
    Friend WithEvents pictCover As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelMenuAdmin As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents Label6 As Label
End Class
