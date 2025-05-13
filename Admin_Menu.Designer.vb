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
        Label6 = New Label()
        Label7 = New Label()
        btnUbah = New Button()
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
        btnUpload = New Button()
        pictCover = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        Panel1 = New Panel()
        TabControl1 = New TabControl()
        HapusBuku = New TabPage()
        BtnHapus = New Button()
        Button2 = New Button()
        Label8 = New Label()
        PictureBox1 = New PictureBox()
        Label12 = New Label()
        GroupBox1 = New GroupBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        TextBox1 = New TextBox()
        GroupBox2 = New GroupBox()
        CheckBox9 = New CheckBox()
        CheckBox10 = New CheckBox()
        CheckBox11 = New CheckBox()
        CheckBox12 = New CheckBox()
        CheckBox13 = New CheckBox()
        CheckBox14 = New CheckBox()
        CheckBox15 = New CheckBox()
        CheckBox16 = New CheckBox()
        TextBox2 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Label13 = New Label()
        Label14 = New Label()
        TextBox3 = New TextBox()
        Label15 = New Label()
        TextBox4 = New TextBox()
        Label16 = New Label()
        EditBuku = New TabPage()
        btnEdit = New Button()
        Button3 = New Button()
        Label18 = New Label()
        PictureBox2 = New PictureBox()
        Label19 = New Label()
        GroupBox3 = New GroupBox()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        TextBox5 = New TextBox()
        GroupBox4 = New GroupBox()
        CheckBox17 = New CheckBox()
        CheckBox18 = New CheckBox()
        CheckBox19 = New CheckBox()
        CheckBox20 = New CheckBox()
        CheckBox21 = New CheckBox()
        CheckBox22 = New CheckBox()
        CheckBox23 = New CheckBox()
        CheckBox24 = New CheckBox()
        TextBox6 = New TextBox()
        DateTimePicker2 = New DateTimePicker()
        Label20 = New Label()
        Label21 = New Label()
        TextBox7 = New TextBox()
        Label22 = New Label()
        TextBox8 = New TextBox()
        Label23 = New Label()
        TambahBuku = New TabPage()
        Label17 = New Label()
        txtDeskripsi = New TextBox()
        btnTambah = New Button()
        Label11 = New Label()
        PanelMenuAdmin = New Panel()
        Label24 = New Label()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        DataGridView2 = New DataGridView()
        Label25 = New Label()
        TextBox11 = New TextBox()
        TextBox12 = New TextBox()
        DataGridView3 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        groupJenis.SuspendLayout()
        groupGenre.SuspendLayout()
        CType(pictCover, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        HapusBuku.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        EditBuku.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        TambahBuku.SuspendLayout()
        PanelMenuAdmin.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(932, 82)
        DataGridView1.Margin = New Padding(5)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(736, 677)
        DataGridView1.TabIndex = 0
        DataGridView1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(21, 24)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(345, 45)
        Label1.TabIndex = 1
        Label1.Text = "DASHBOARD ADMIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(885, 298)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 32)
        Label2.TabIndex = 2
        Label2.Text = "Id Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(70, 40)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 32)
        Label3.TabIndex = 3
        Label3.Text = "Judul"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(72, 97)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 32)
        Label4.TabIndex = 3
        Label4.Text = "Penulis"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(72, 152)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(145, 32)
        Label5.TabIndex = 3
        Label5.Text = "Tahun Terbit"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(2390, 1087)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(110, 32)
        Label6.TabIndex = 3
        Label6.Text = "Deskripsi"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(81, 262)
        Label7.Margin = New Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 32)
        Label7.TabIndex = 3
        Label7.Text = "Stok"
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(2766, 914)
        btnUbah.Margin = New Padding(5)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(153, 46)
        btnUbah.TabIndex = 19
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(932, 33)
        txtCari.Margin = New Padding(5)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(546, 39)
        txtCari.TabIndex = 17
        txtCari.Text = "txtCari"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {LogoutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(10, 3, 0, 3)
        MenuStrip1.Size = New Size(1713, 42)
        MenuStrip1.TabIndex = 7
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right
        LogoutToolStripMenuItem.BackColor = Color.Red
        LogoutToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LogoutToolStripMenuItem.ForeColor = Color.White
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(115, 36)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' txtPenulis
        ' 
        txtPenulis.Location = New Point(227, 97)
        txtPenulis.Margin = New Padding(5)
        txtPenulis.MaxLength = 50
        txtPenulis.Name = "txtPenulis"
        txtPenulis.Size = New Size(539, 39)
        txtPenulis.TabIndex = 4
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(227, 262)
        txtStok.Margin = New Padding(5)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(539, 39)
        txtStok.TabIndex = 2
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(227, 37)
        txtJudul.Margin = New Padding(5)
        txtJudul.MaxLength = 50
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(539, 39)
        txtJudul.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(232, 310)
        Label9.Margin = New Padding(5, 0, 5, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(0, 32)
        Label9.TabIndex = 3
        ' 
        ' comboId
        ' 
        comboId.FormattingEnabled = True
        comboId.Location = New Point(395, 646)
        comboId.Margin = New Padding(5)
        comboId.Name = "comboId"
        comboId.Size = New Size(500, 40)
        comboId.TabIndex = 0
        ' 
        ' radioFiksi
        ' 
        radioFiksi.AutoSize = True
        radioFiksi.Location = New Point(32, 42)
        radioFiksi.Margin = New Padding(5)
        radioFiksi.Name = "radioFiksi"
        radioFiksi.Size = New Size(91, 36)
        radioFiksi.TabIndex = 7
        radioFiksi.TabStop = True
        radioFiksi.Text = "Fiksi"
        radioFiksi.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(10, 43)
        CheckBox1.Margin = New Padding(5)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(123, 36)
        CheckBox1.TabIndex = 8
        CheckBox1.Text = "Genre1"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' groupJenis
        ' 
        groupJenis.Controls.Add(radioNonFiksi)
        groupJenis.Controls.Add(radioFiksi)
        groupJenis.Location = New Point(74, 311)
        groupJenis.Margin = New Padding(5)
        groupJenis.Name = "groupJenis"
        groupJenis.Padding = New Padding(5)
        groupJenis.Size = New Size(313, 98)
        groupJenis.TabIndex = 6
        groupJenis.TabStop = False
        groupJenis.Text = "Jenis Buku"
        ' 
        ' radioNonFiksi
        ' 
        radioNonFiksi.AutoSize = True
        radioNonFiksi.Location = New Point(144, 42)
        radioNonFiksi.Margin = New Padding(5)
        radioNonFiksi.Name = "radioNonFiksi"
        radioNonFiksi.Size = New Size(147, 36)
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
        groupGenre.Location = New Point(74, 419)
        groupGenre.Margin = New Padding(5)
        groupGenre.Name = "groupGenre"
        groupGenre.Padding = New Padding(5)
        groupGenre.Size = New Size(704, 146)
        groupGenre.TabIndex = 7
        groupGenre.TabStop = False
        groupGenre.Text = "Genre"
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(10, 91)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(123, 36)
        CheckBox6.TabIndex = 15
        CheckBox6.Text = "Genre6"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(274, 47)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(123, 36)
        CheckBox3.TabIndex = 14
        CheckBox3.Text = "Genre3"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(274, 91)
        CheckBox8.Margin = New Padding(5)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(123, 36)
        CheckBox8.TabIndex = 13
        CheckBox8.Text = "Genre8"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(549, 47)
        CheckBox5.Margin = New Padding(5)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(123, 36)
        CheckBox5.TabIndex = 11
        CheckBox5.Text = "Genre5"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(143, 45)
        CheckBox2.Margin = New Padding(5)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(123, 36)
        CheckBox2.TabIndex = 9
        CheckBox2.Text = "Genre2"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(416, 47)
        CheckBox4.Margin = New Padding(5)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(123, 36)
        CheckBox4.TabIndex = 10
        CheckBox4.Text = "Genre4"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(141, 91)
        CheckBox7.Margin = New Padding(5)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(123, 36)
        CheckBox7.TabIndex = 12
        CheckBox7.Text = "Genre7"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(227, 202)
        txtHarga.Margin = New Padding(5)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(539, 39)
        txtHarga.TabIndex = 6
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(72, 202)
        Label10.Margin = New Padding(5, 0, 5, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(77, 32)
        Label10.TabIndex = 15
        Label10.Text = "Harga"
        ' 
        ' dateTahunTerbit
        ' 
        dateTahunTerbit.CustomFormat = "yyyy"
        dateTahunTerbit.Format = DateTimePickerFormat.Custom
        dateTahunTerbit.Location = New Point(227, 152)
        dateTahunTerbit.Margin = New Padding(5)
        dateTahunTerbit.MaxDate = New Date(2099, 5, 11, 0, 0, 0, 0)
        dateTahunTerbit.Name = "dateTahunTerbit"
        dateTahunTerbit.Size = New Size(539, 39)
        dateTahunTerbit.TabIndex = 5
        dateTahunTerbit.Value = New Date(2025, 5, 11, 0, 0, 0, 0)
        ' 
        ' btnUpload
        ' 
        btnUpload.Location = New Point(227, 846)
        btnUpload.Margin = New Padding(5)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(228, 46)
        btnUpload.TabIndex = 15
        btnUpload.Text = "Upload"
        btnUpload.UseVisualStyleBackColor = True
        ' 
        ' pictCover
        ' 
        pictCover.BackColor = Color.DimGray
        pictCover.Location = New Point(227, 575)
        pictCover.Margin = New Padding(5)
        pictCover.Name = "pictCover"
        pictCover.Size = New Size(228, 261)
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
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1726, 93)
        Panel1.TabIndex = 21
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(HapusBuku)
        TabControl1.Controls.Add(EditBuku)
        TabControl1.Controls.Add(TambahBuku)
        TabControl1.Location = New Point(21, 101)
        TabControl1.Name = "TabControl1"
        TabControl1.Padding = New Point(6, 6)
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1692, 967)
        TabControl1.TabIndex = 22
        ' 
        ' HapusBuku
        ' 
        HapusBuku.Controls.Add(Label25)
        HapusBuku.Controls.Add(TextBox11)
        HapusBuku.Controls.Add(TextBox12)
        HapusBuku.Controls.Add(DataGridView3)
        HapusBuku.Controls.Add(BtnHapus)
        HapusBuku.Controls.Add(Button2)
        HapusBuku.Controls.Add(Label8)
        HapusBuku.Controls.Add(PictureBox1)
        HapusBuku.Controls.Add(Label12)
        HapusBuku.Controls.Add(GroupBox1)
        HapusBuku.Controls.Add(TextBox1)
        HapusBuku.Controls.Add(GroupBox2)
        HapusBuku.Controls.Add(TextBox2)
        HapusBuku.Controls.Add(DateTimePicker1)
        HapusBuku.Controls.Add(Label13)
        HapusBuku.Controls.Add(Label14)
        HapusBuku.Controls.Add(TextBox3)
        HapusBuku.Controls.Add(Label15)
        HapusBuku.Controls.Add(TextBox4)
        HapusBuku.Controls.Add(Label16)
        HapusBuku.Location = New Point(8, 50)
        HapusBuku.Name = "HapusBuku"
        HapusBuku.Size = New Size(1676, 909)
        HapusBuku.TabIndex = 2
        HapusBuku.Text = "Hapus Buku"
        HapusBuku.UseVisualStyleBackColor = True
        ' 
        ' BtnHapus
        ' 
        BtnHapus.BackColor = Color.Firebrick
        BtnHapus.FlatStyle = FlatStyle.Popup
        BtnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnHapus.ForeColor = Color.White
        BtnHapus.Location = New Point(914, 829)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(186, 64)
        BtnHapus.TabIndex = 35
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(207, 838)
        Button2.Margin = New Padding(5)
        Button2.Name = "Button2"
        Button2.Size = New Size(228, 46)
        Button2.TabIndex = 30
        Button2.Text = "Upload"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(52, 635)
        Label8.Name = "Label8"
        Label8.Size = New Size(137, 32)
        Label8.TabIndex = 32
        Label8.Text = "Cover Buku"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.DimGray
        PictureBox1.Location = New Point(207, 567)
        PictureBox1.Margin = New Padding(5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(228, 261)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 29
        PictureBox1.TabStop = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(50, 32)
        Label12.Margin = New Padding(5, 0, 5, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(71, 32)
        Label12.TabIndex = 19
        Label12.Text = "Judul"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Location = New Point(54, 303)
        GroupBox1.Margin = New Padding(5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(5)
        GroupBox1.Size = New Size(313, 98)
        GroupBox1.TabIndex = 26
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jenis Buku"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(146, 44)
        RadioButton1.Margin = New Padding(5)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(147, 36)
        RadioButton1.TabIndex = 8
        RadioButton1.TabStop = True
        RadioButton1.Text = "Non-Fiksi"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(34, 44)
        RadioButton2.Margin = New Padding(5)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(91, 36)
        RadioButton2.TabIndex = 7
        RadioButton2.TabStop = True
        RadioButton2.Text = "Fiksi"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(207, 254)
        TextBox1.Margin = New Padding(5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(539, 39)
        TextBox1.TabIndex = 18
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(CheckBox9)
        GroupBox2.Controls.Add(CheckBox10)
        GroupBox2.Controls.Add(CheckBox11)
        GroupBox2.Controls.Add(CheckBox12)
        GroupBox2.Controls.Add(CheckBox13)
        GroupBox2.Controls.Add(CheckBox14)
        GroupBox2.Controls.Add(CheckBox15)
        GroupBox2.Controls.Add(CheckBox16)
        GroupBox2.Location = New Point(54, 411)
        GroupBox2.Margin = New Padding(5)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(5)
        GroupBox2.Size = New Size(704, 146)
        GroupBox2.TabIndex = 28
        GroupBox2.TabStop = False
        GroupBox2.Text = "Genre"
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Location = New Point(12, 93)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(123, 36)
        CheckBox9.TabIndex = 15
        CheckBox9.Text = "Genre6"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.Location = New Point(276, 49)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(123, 36)
        CheckBox10.TabIndex = 14
        CheckBox10.Text = "Genre3"
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' CheckBox11
        ' 
        CheckBox11.AutoSize = True
        CheckBox11.Location = New Point(276, 93)
        CheckBox11.Margin = New Padding(5)
        CheckBox11.Name = "CheckBox11"
        CheckBox11.Size = New Size(123, 36)
        CheckBox11.TabIndex = 13
        CheckBox11.Text = "Genre8"
        CheckBox11.UseVisualStyleBackColor = True
        ' 
        ' CheckBox12
        ' 
        CheckBox12.AutoSize = True
        CheckBox12.Location = New Point(551, 49)
        CheckBox12.Margin = New Padding(5)
        CheckBox12.Name = "CheckBox12"
        CheckBox12.Size = New Size(123, 36)
        CheckBox12.TabIndex = 11
        CheckBox12.Text = "Genre5"
        CheckBox12.UseVisualStyleBackColor = True
        ' 
        ' CheckBox13
        ' 
        CheckBox13.AutoSize = True
        CheckBox13.Location = New Point(145, 47)
        CheckBox13.Margin = New Padding(5)
        CheckBox13.Name = "CheckBox13"
        CheckBox13.Size = New Size(123, 36)
        CheckBox13.TabIndex = 9
        CheckBox13.Text = "Genre2"
        CheckBox13.UseVisualStyleBackColor = True
        ' 
        ' CheckBox14
        ' 
        CheckBox14.AutoSize = True
        CheckBox14.Location = New Point(418, 49)
        CheckBox14.Margin = New Padding(5)
        CheckBox14.Name = "CheckBox14"
        CheckBox14.Size = New Size(123, 36)
        CheckBox14.TabIndex = 10
        CheckBox14.Text = "Genre4"
        CheckBox14.UseVisualStyleBackColor = True
        ' 
        ' CheckBox15
        ' 
        CheckBox15.AutoSize = True
        CheckBox15.Location = New Point(143, 93)
        CheckBox15.Margin = New Padding(5)
        CheckBox15.Name = "CheckBox15"
        CheckBox15.Size = New Size(123, 36)
        CheckBox15.TabIndex = 12
        CheckBox15.Text = "Genre7"
        CheckBox15.UseVisualStyleBackColor = True
        ' 
        ' CheckBox16
        ' 
        CheckBox16.AutoSize = True
        CheckBox16.Location = New Point(12, 45)
        CheckBox16.Margin = New Padding(5)
        CheckBox16.Name = "CheckBox16"
        CheckBox16.Size = New Size(123, 36)
        CheckBox16.TabIndex = 8
        CheckBox16.Text = "Genre1"
        CheckBox16.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(207, 194)
        TextBox2.Margin = New Padding(5)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(539, 39)
        TextBox2.TabIndex = 27
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(207, 144)
        DateTimePicker1.Margin = New Padding(5)
        DateTimePicker1.MaxDate = New Date(2099, 5, 11, 0, 0, 0, 0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(539, 39)
        DateTimePicker1.TabIndex = 25
        DateTimePicker1.Value = New Date(2025, 5, 11, 0, 0, 0, 0)
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(52, 194)
        Label13.Margin = New Padding(5, 0, 5, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(77, 32)
        Label13.TabIndex = 31
        Label13.Text = "Harga"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(61, 254)
        Label14.Margin = New Padding(5, 0, 5, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(60, 32)
        Label14.TabIndex = 20
        Label14.Text = "Stok"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(207, 29)
        TextBox3.Margin = New Padding(5)
        TextBox3.MaxLength = 50
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(539, 39)
        TextBox3.TabIndex = 21
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(52, 89)
        Label15.Margin = New Padding(5, 0, 5, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(89, 32)
        Label15.TabIndex = 22
        Label15.Text = "Penulis"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(207, 89)
        TextBox4.Margin = New Padding(5)
        TextBox4.MaxLength = 50
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(539, 39)
        TextBox4.TabIndex = 24
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(52, 144)
        Label16.Margin = New Padding(5, 0, 5, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(145, 32)
        Label16.TabIndex = 23
        Label16.Text = "Tahun Terbit"
        ' 
        ' EditBuku
        ' 
        EditBuku.Controls.Add(Label24)
        EditBuku.Controls.Add(TextBox9)
        EditBuku.Controls.Add(TextBox10)
        EditBuku.Controls.Add(DataGridView2)
        EditBuku.Controls.Add(btnEdit)
        EditBuku.Controls.Add(Button3)
        EditBuku.Controls.Add(Label18)
        EditBuku.Controls.Add(PictureBox2)
        EditBuku.Controls.Add(Label19)
        EditBuku.Controls.Add(GroupBox3)
        EditBuku.Controls.Add(TextBox5)
        EditBuku.Controls.Add(GroupBox4)
        EditBuku.Controls.Add(TextBox6)
        EditBuku.Controls.Add(DateTimePicker2)
        EditBuku.Controls.Add(Label20)
        EditBuku.Controls.Add(Label21)
        EditBuku.Controls.Add(TextBox7)
        EditBuku.Controls.Add(Label22)
        EditBuku.Controls.Add(TextBox8)
        EditBuku.Controls.Add(Label23)
        EditBuku.Location = New Point(8, 50)
        EditBuku.Name = "EditBuku"
        EditBuku.Padding = New Padding(3)
        EditBuku.Size = New Size(1676, 909)
        EditBuku.TabIndex = 1
        EditBuku.Text = "Edit Buku"
        EditBuku.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.SteelBlue
        btnEdit.FlatStyle = FlatStyle.Popup
        btnEdit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(1417, 766)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(186, 64)
        btnEdit.TabIndex = 51
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(192, 831)
        Button3.Margin = New Padding(5)
        Button3.Name = "Button3"
        Button3.Size = New Size(228, 46)
        Button3.TabIndex = 48
        Button3.Text = "Upload"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(37, 628)
        Label18.Name = "Label18"
        Label18.Size = New Size(137, 32)
        Label18.TabIndex = 50
        Label18.Text = "Cover Buku"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.DimGray
        PictureBox2.Location = New Point(192, 560)
        PictureBox2.Margin = New Padding(5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(228, 261)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 47
        PictureBox2.TabStop = False
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(35, 25)
        Label19.Margin = New Padding(5, 0, 5, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(71, 32)
        Label19.TabIndex = 37
        Label19.Text = "Judul"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(RadioButton3)
        GroupBox3.Controls.Add(RadioButton4)
        GroupBox3.Location = New Point(39, 296)
        GroupBox3.Margin = New Padding(5)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(5)
        GroupBox3.Size = New Size(313, 98)
        GroupBox3.TabIndex = 44
        GroupBox3.TabStop = False
        GroupBox3.Text = "Jenis Buku"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(148, 46)
        RadioButton3.Margin = New Padding(5)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(147, 36)
        RadioButton3.TabIndex = 8
        RadioButton3.TabStop = True
        RadioButton3.Text = "Non-Fiksi"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(36, 46)
        RadioButton4.Margin = New Padding(5)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(91, 36)
        RadioButton4.TabIndex = 7
        RadioButton4.TabStop = True
        RadioButton4.Text = "Fiksi"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(192, 247)
        TextBox5.Margin = New Padding(5)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(539, 39)
        TextBox5.TabIndex = 36
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(CheckBox17)
        GroupBox4.Controls.Add(CheckBox18)
        GroupBox4.Controls.Add(CheckBox19)
        GroupBox4.Controls.Add(CheckBox20)
        GroupBox4.Controls.Add(CheckBox21)
        GroupBox4.Controls.Add(CheckBox22)
        GroupBox4.Controls.Add(CheckBox23)
        GroupBox4.Controls.Add(CheckBox24)
        GroupBox4.Location = New Point(39, 404)
        GroupBox4.Margin = New Padding(5)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(5)
        GroupBox4.Size = New Size(704, 146)
        GroupBox4.TabIndex = 46
        GroupBox4.TabStop = False
        GroupBox4.Text = "Genre"
        ' 
        ' CheckBox17
        ' 
        CheckBox17.AutoSize = True
        CheckBox17.Location = New Point(14, 95)
        CheckBox17.Name = "CheckBox17"
        CheckBox17.Size = New Size(123, 36)
        CheckBox17.TabIndex = 15
        CheckBox17.Text = "Genre6"
        CheckBox17.UseVisualStyleBackColor = True
        ' 
        ' CheckBox18
        ' 
        CheckBox18.AutoSize = True
        CheckBox18.Location = New Point(278, 51)
        CheckBox18.Name = "CheckBox18"
        CheckBox18.Size = New Size(123, 36)
        CheckBox18.TabIndex = 14
        CheckBox18.Text = "Genre3"
        CheckBox18.UseVisualStyleBackColor = True
        ' 
        ' CheckBox19
        ' 
        CheckBox19.AutoSize = True
        CheckBox19.Location = New Point(278, 95)
        CheckBox19.Margin = New Padding(5)
        CheckBox19.Name = "CheckBox19"
        CheckBox19.Size = New Size(123, 36)
        CheckBox19.TabIndex = 13
        CheckBox19.Text = "Genre8"
        CheckBox19.UseVisualStyleBackColor = True
        ' 
        ' CheckBox20
        ' 
        CheckBox20.AutoSize = True
        CheckBox20.Location = New Point(553, 51)
        CheckBox20.Margin = New Padding(5)
        CheckBox20.Name = "CheckBox20"
        CheckBox20.Size = New Size(123, 36)
        CheckBox20.TabIndex = 11
        CheckBox20.Text = "Genre5"
        CheckBox20.UseVisualStyleBackColor = True
        ' 
        ' CheckBox21
        ' 
        CheckBox21.AutoSize = True
        CheckBox21.Location = New Point(147, 49)
        CheckBox21.Margin = New Padding(5)
        CheckBox21.Name = "CheckBox21"
        CheckBox21.Size = New Size(123, 36)
        CheckBox21.TabIndex = 9
        CheckBox21.Text = "Genre2"
        CheckBox21.UseVisualStyleBackColor = True
        ' 
        ' CheckBox22
        ' 
        CheckBox22.AutoSize = True
        CheckBox22.Location = New Point(420, 51)
        CheckBox22.Margin = New Padding(5)
        CheckBox22.Name = "CheckBox22"
        CheckBox22.Size = New Size(123, 36)
        CheckBox22.TabIndex = 10
        CheckBox22.Text = "Genre4"
        CheckBox22.UseVisualStyleBackColor = True
        ' 
        ' CheckBox23
        ' 
        CheckBox23.AutoSize = True
        CheckBox23.Location = New Point(145, 95)
        CheckBox23.Margin = New Padding(5)
        CheckBox23.Name = "CheckBox23"
        CheckBox23.Size = New Size(123, 36)
        CheckBox23.TabIndex = 12
        CheckBox23.Text = "Genre7"
        CheckBox23.UseVisualStyleBackColor = True
        ' 
        ' CheckBox24
        ' 
        CheckBox24.AutoSize = True
        CheckBox24.Location = New Point(14, 47)
        CheckBox24.Margin = New Padding(5)
        CheckBox24.Name = "CheckBox24"
        CheckBox24.Size = New Size(123, 36)
        CheckBox24.TabIndex = 8
        CheckBox24.Text = "Genre1"
        CheckBox24.UseVisualStyleBackColor = True
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(192, 187)
        TextBox6.Margin = New Padding(5)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(539, 39)
        TextBox6.TabIndex = 45
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CustomFormat = "yyyy"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.Location = New Point(192, 137)
        DateTimePicker2.Margin = New Padding(5)
        DateTimePicker2.MaxDate = New Date(2099, 5, 11, 0, 0, 0, 0)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(539, 39)
        DateTimePicker2.TabIndex = 43
        DateTimePicker2.Value = New Date(2025, 5, 11, 0, 0, 0, 0)
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(37, 187)
        Label20.Margin = New Padding(5, 0, 5, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(77, 32)
        Label20.TabIndex = 49
        Label20.Text = "Harga"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(46, 247)
        Label21.Margin = New Padding(5, 0, 5, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(60, 32)
        Label21.TabIndex = 38
        Label21.Text = "Stok"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(192, 22)
        TextBox7.Margin = New Padding(5)
        TextBox7.MaxLength = 50
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(539, 39)
        TextBox7.TabIndex = 39
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(37, 82)
        Label22.Margin = New Padding(5, 0, 5, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(89, 32)
        Label22.TabIndex = 40
        Label22.Text = "Penulis"
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(192, 82)
        TextBox8.Margin = New Padding(5)
        TextBox8.MaxLength = 50
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(539, 39)
        TextBox8.TabIndex = 42
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(37, 137)
        Label23.Margin = New Padding(5, 0, 5, 0)
        Label23.Name = "Label23"
        Label23.Size = New Size(145, 32)
        Label23.TabIndex = 41
        Label23.Text = "Tahun Terbit"
        ' 
        ' TambahBuku
        ' 
        TambahBuku.Controls.Add(Label17)
        TambahBuku.Controls.Add(txtDeskripsi)
        TambahBuku.Controls.Add(txtCari)
        TambahBuku.Controls.Add(btnTambah)
        TambahBuku.Controls.Add(btnUpload)
        TambahBuku.Controls.Add(Label11)
        TambahBuku.Controls.Add(pictCover)
        TambahBuku.Controls.Add(Label3)
        TambahBuku.Controls.Add(groupJenis)
        TambahBuku.Controls.Add(txtStok)
        TambahBuku.Controls.Add(groupGenre)
        TambahBuku.Controls.Add(txtHarga)
        TambahBuku.Controls.Add(dateTahunTerbit)
        TambahBuku.Controls.Add(Label10)
        TambahBuku.Controls.Add(Label7)
        TambahBuku.Controls.Add(txtJudul)
        TambahBuku.Controls.Add(Label4)
        TambahBuku.Controls.Add(DataGridView1)
        TambahBuku.Controls.Add(txtPenulis)
        TambahBuku.Controls.Add(Label5)
        TambahBuku.Location = New Point(8, 50)
        TambahBuku.Name = "TambahBuku"
        TambahBuku.Padding = New Padding(3)
        TambahBuku.Size = New Size(1676, 909)
        TambahBuku.TabIndex = 0
        TambahBuku.Text = "Tambah Buku"
        TambahBuku.UseVisualStyleBackColor = True
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(612, 575)
        Label17.Name = "Label17"
        Label17.Size = New Size(110, 32)
        Label17.TabIndex = 19
        Label17.Text = "Deskripsi"
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.Location = New Point(503, 618)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.Size = New Size(354, 274)
        txtDeskripsi.TabIndex = 18
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.MediumSeaGreen
        btnTambah.FlatStyle = FlatStyle.Popup
        btnTambah.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(1482, 804)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(186, 64)
        btnTambah.TabIndex = 17
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(72, 643)
        Label11.Name = "Label11"
        Label11.Size = New Size(137, 32)
        Label11.TabIndex = 16
        Label11.Text = "Cover Buku"
        ' 
        ' PanelMenuAdmin
        ' 
        PanelMenuAdmin.Controls.Add(TabControl1)
        PanelMenuAdmin.Controls.Add(Panel1)
        PanelMenuAdmin.Controls.Add(comboId)
        PanelMenuAdmin.Controls.Add(Label2)
        PanelMenuAdmin.Location = New Point(0, 45)
        PanelMenuAdmin.Name = "PanelMenuAdmin"
        PanelMenuAdmin.Size = New Size(1713, 1071)
        PanelMenuAdmin.TabIndex = 24
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(556, 556)
        Label24.Name = "Label24"
        Label24.Size = New Size(110, 32)
        Label24.TabIndex = 55
        Label24.Text = "Deskripsi"
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(444, 603)
        TextBox9.Multiline = True
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(354, 274)
        TextBox9.TabIndex = 54
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(876, 14)
        TextBox10.Margin = New Padding(5)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(546, 39)
        TextBox10.TabIndex = 53
        TextBox10.Text = "TextBox10"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.AllowUserToResizeColumns = False
        DataGridView2.AllowUserToResizeRows = False
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(876, 63)
        DataGridView2.Margin = New Padding(5)
        DataGridView2.MultiSelect = False
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.Size = New Size(736, 677)
        DataGridView2.TabIndex = 52
        DataGridView2.TabStop = False
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(584, 572)
        Label25.Name = "Label25"
        Label25.Size = New Size(110, 32)
        Label25.TabIndex = 39
        Label25.Text = "Deskripsi"
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(472, 607)
        TextBox11.Multiline = True
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(354, 274)
        TextBox11.TabIndex = 38
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(904, 30)
        TextBox12.Margin = New Padding(5)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(546, 39)
        TextBox12.TabIndex = 37
        TextBox12.Text = "TextBox12"
        ' 
        ' DataGridView3
        ' 
        DataGridView3.AllowUserToAddRows = False
        DataGridView3.AllowUserToDeleteRows = False
        DataGridView3.AllowUserToResizeColumns = False
        DataGridView3.AllowUserToResizeRows = False
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Location = New Point(904, 79)
        DataGridView3.Margin = New Padding(5)
        DataGridView3.MultiSelect = False
        DataGridView3.Name = "DataGridView3"
        DataGridView3.ReadOnly = True
        DataGridView3.RowHeadersWidth = 51
        DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView3.Size = New Size(736, 677)
        DataGridView3.TabIndex = 36
        DataGridView3.TabStop = False
        ' 
        ' Admin_Menu
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1713, 1115)
        Controls.Add(Label6)
        Controls.Add(btnUbah)
        Controls.Add(Label9)
        Controls.Add(MenuStrip1)
        Controls.Add(PanelMenuAdmin)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(5)
        MaximumSize = New Size(1739, 1186)
        MinimumSize = New Size(1739, 1186)
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
        CType(pictCover, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabControl1.ResumeLayout(False)
        HapusBuku.ResumeLayout(False)
        HapusBuku.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        EditBuku.ResumeLayout(False)
        EditBuku.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        TambahBuku.ResumeLayout(False)
        TambahBuku.PerformLayout()
        PanelMenuAdmin.ResumeLayout(False)
        PanelMenuAdmin.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnUbah As Button
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
    Friend WithEvents btnUpload As Button
    Friend WithEvents pictCover As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TambahBuku As TabPage
    Friend WithEvents PanelMenuAdmin As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents HapusBuku As TabPage
    Friend WithEvents EditBuku As TabPage
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents CheckBox15 As CheckBox
    Friend WithEvents CheckBox16 As CheckBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CheckBox17 As CheckBox
    Friend WithEvents CheckBox18 As CheckBox
    Friend WithEvents CheckBox19 As CheckBox
    Friend WithEvents CheckBox20 As CheckBox
    Friend WithEvents CheckBox21 As CheckBox
    Friend WithEvents CheckBox22 As CheckBox
    Friend WithEvents CheckBox23 As CheckBox
    Friend WithEvents CheckBox24 As CheckBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Label24 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
End Class
