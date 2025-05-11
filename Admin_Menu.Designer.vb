<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        btnTambah = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        txtCari = New TextBox()
        labelCari = New Label()
        MenuStrip1 = New MenuStrip()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        txtPenulis = New TextBox()
        txtHarga = New TextBox()
        txtStok = New TextBox()
        txtDeskripsi = New TextBox()
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
        CheckBox8 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox2 = New CheckBox()
        btnCari = New Button()
        Label8 = New Label()
        PictureBox1 = New PictureBox()
        btnUpload = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        groupJenis.SuspendLayout()
        groupGenre.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(27, 366)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1000, 313)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(462, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 28)
        Label1.TabIndex = 1
        Label1.Text = "Menu Admin"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 2
        Label2.Text = "Id Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(36, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 20)
        Label3.TabIndex = 3
        Label3.Text = "Judul"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(36, 120)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 20)
        Label4.TabIndex = 3
        Label4.Text = "Penulis"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(36, 156)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 20)
        Label5.TabIndex = 3
        Label5.Text = "Harga"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(590, 48)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 20)
        Label6.TabIndex = 3
        Label6.Text = "Deskripsi"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(286, 54)
        Label7.Name = "Label7"
        Label7.Size = New Size(38, 20)
        Label7.TabIndex = 3
        Label7.Text = "Stok"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(733, 332)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(833, 332)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(94, 29)
        btnUbah.TabIndex = 4
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(933, 332)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 4
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(27, 332)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(452, 27)
        txtCari.TabIndex = 5
        txtCari.Text = "txtCari"
        ' 
        ' labelCari
        ' 
        labelCari.AutoSize = True
        labelCari.Location = New Point(60, 336)
        labelCari.Name = "labelCari"
        labelCari.Size = New Size(0, 20)
        labelCari.TabIndex = 6
        ' 
        ' MenuStrip1
        ' 
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
        LogoutToolStripMenuItem.BackColor = Color.Red
        LogoutToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LogoutToolStripMenuItem.ForeColor = Color.White
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(73, 24)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' txtPenulis
        ' 
        txtPenulis.Location = New Point(137, 120)
        txtPenulis.Name = "txtPenulis"
        txtPenulis.Size = New Size(333, 27)
        txtPenulis.TabIndex = 8
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(137, 156)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(333, 27)
        txtHarga.TabIndex = 8
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(350, 50)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(120, 27)
        txtStok.TabIndex = 8
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.Location = New Point(492, 77)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.Size = New Size(272, 225)
        txtDeskripsi.TabIndex = 9
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(137, 87)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(333, 27)
        txtJudul.TabIndex = 8
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(36, 208)
        Label9.Name = "Label9"
        Label9.Size = New Size(0, 20)
        Label9.TabIndex = 3
        ' 
        ' comboId
        ' 
        comboId.FormattingEnabled = True
        comboId.Location = New Point(137, 48)
        comboId.Name = "comboId"
        comboId.Size = New Size(97, 28)
        comboId.TabIndex = 10
        ' 
        ' radioFiksi
        ' 
        radioFiksi.AutoSize = True
        radioFiksi.Location = New Point(20, 26)
        radioFiksi.Name = "radioFiksi"
        radioFiksi.Size = New Size(58, 24)
        radioFiksi.TabIndex = 11
        radioFiksi.TabStop = True
        radioFiksi.Text = "Fiksi"
        radioFiksi.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(6, 27)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(78, 24)
        CheckBox1.TabIndex = 12
        CheckBox1.Text = "Genre1"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' groupJenis
        ' 
        groupJenis.Controls.Add(radioNonFiksi)
        groupJenis.Controls.Add(radioFiksi)
        groupJenis.Location = New Point(32, 192)
        groupJenis.Name = "groupJenis"
        groupJenis.Size = New Size(147, 122)
        groupJenis.TabIndex = 13
        groupJenis.TabStop = False
        groupJenis.Text = "Jenis Buku"
        ' 
        ' radioNonFiksi
        ' 
        radioNonFiksi.AutoSize = True
        radioNonFiksi.Location = New Point(20, 56)
        radioNonFiksi.Name = "radioNonFiksi"
        radioNonFiksi.Size = New Size(92, 24)
        radioNonFiksi.TabIndex = 11
        radioNonFiksi.TabStop = True
        radioNonFiksi.Text = "Non-Fiksi"
        radioNonFiksi.UseVisualStyleBackColor = True
        ' 
        ' groupGenre
        ' 
        groupGenre.Controls.Add(CheckBox6)
        groupGenre.Controls.Add(CheckBox8)
        groupGenre.Controls.Add(CheckBox5)
        groupGenre.Controls.Add(CheckBox4)
        groupGenre.Controls.Add(CheckBox3)
        groupGenre.Controls.Add(CheckBox7)
        groupGenre.Controls.Add(CheckBox2)
        groupGenre.Controls.Add(CheckBox1)
        groupGenre.Location = New Point(203, 192)
        groupGenre.Name = "groupGenre"
        groupGenre.Size = New Size(260, 122)
        groupGenre.TabIndex = 13
        groupGenre.TabStop = False
        groupGenre.Text = "Genre"
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(174, 57)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(78, 24)
        CheckBox6.TabIndex = 12
        CheckBox6.Text = "Genre8"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(90, 86)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(78, 24)
        CheckBox8.TabIndex = 12
        CheckBox8.Text = "Genre6"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(90, 57)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(78, 24)
        CheckBox5.TabIndex = 12
        CheckBox5.Text = "Genre5"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(6, 57)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(78, 24)
        CheckBox4.TabIndex = 12
        CheckBox4.Text = "Genre2"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(90, 27)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(78, 24)
        CheckBox3.TabIndex = 12
        CheckBox3.Text = "Genre4"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(6, 86)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(78, 24)
        CheckBox7.TabIndex = 12
        CheckBox7.Text = "Genre3"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(174, 27)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(78, 24)
        CheckBox2.TabIndex = 12
        CheckBox2.Text = "Genre7"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' btnCari
        ' 
        btnCari.Location = New Point(492, 330)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(94, 29)
        btnCari.TabIndex = 4
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(886, 53)
        Label8.Name = "Label8"
        Label8.Size = New Size(47, 20)
        Label8.TabIndex = 3
        Label8.Text = "Cover"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(792, 78)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(217, 189)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' btnUpload
        ' 
        btnUpload.Location = New Point(792, 273)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(217, 29)
        btnUpload.TabIndex = 4
        btnUpload.Text = "Upload"
        btnUpload.UseVisualStyleBackColor = True
        ' 
        ' Admin_Menu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1062, 721)
        Controls.Add(PictureBox1)
        Controls.Add(groupGenre)
        Controls.Add(groupJenis)
        Controls.Add(comboId)
        Controls.Add(txtDeskripsi)
        Controls.Add(txtStok)
        Controls.Add(txtHarga)
        Controls.Add(txtPenulis)
        Controls.Add(txtJudul)
        Controls.Add(labelCari)
        Controls.Add(txtCari)
        Controls.Add(btnCari)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnUpload)
        Controls.Add(btnTambah)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label9)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Admin_Menu"
        Text = "Haven Media"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        groupJenis.ResumeLayout(False)
        groupJenis.PerformLayout()
        groupGenre.ResumeLayout(False)
        groupGenre.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents labelCari As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtPenulis As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents comboId As ComboBox
    Friend WithEvents radioFiksi As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents groupJenis As GroupBox
    Friend WithEvents radioNonFiksi As RadioButton
    Friend WithEvents groupGenre As GroupBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents btnCari As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnUpload As Button
End Class
