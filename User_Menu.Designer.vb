﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_Menu))
        btnTambahKeranjang = New Button()
        DataGridView1 = New DataGridView()
        txtSearch = New TextBox()
        txtJumlah = New TextBox()
        btnKurang = New Button()
        btnTambah = New Button()
        btnCetakStruk = New Button()
        Label2 = New Label()
        MenuStrip1 = New MenuStrip()
        menuBack = New ToolStripMenuItem()
        txtStok = New TextBox()
        txtHarga = New TextBox()
        txtPenulis = New TextBox()
        txtJudul = New TextBox()
        Label7 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        txtIdBuku = New TextBox()
        Label6 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        txtDeskripsi = New TextBox()
        txtJenis = New TextBox()
        txtGenre = New TextBox()
        Label10 = New Label()
        DataGridView2 = New DataGridView()
        btnHapusKeranjang = New Button()
        PictureBox1 = New PictureBox()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        txtTahunTerbit = New TextBox()
        Label12 = New Label()
        labelUsername = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnTambahKeranjang
        ' 
        btnTambahKeranjang.BackColor = Color.Silver
        btnTambahKeranjang.Enabled = False
        btnTambahKeranjang.FlatStyle = FlatStyle.Popup
        btnTambahKeranjang.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnTambahKeranjang.ForeColor = Color.Black
        btnTambahKeranjang.Location = New Point(890, 342)
        btnTambahKeranjang.Name = "btnTambahKeranjang"
        btnTambahKeranjang.Size = New Size(141, 29)
        btnTambahKeranjang.TabIndex = 0
        btnTambahKeranjang.Text = "Tambah"
        btnTambahKeranjang.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(30, 378)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.ScrollBars = ScrollBars.Vertical
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.ShowEditingIcon = False
        DataGridView1.Size = New Size(652, 330)
        DataGridView1.TabIndex = 1
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = SystemColors.Control
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Location = New Point(85, 345)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(597, 27)
        txtSearch.TabIndex = 4
        ' 
        ' txtJumlah
        ' 
        txtJumlah.BackColor = Color.Silver
        txtJumlah.BorderStyle = BorderStyle.FixedSingle
        txtJumlah.ForeColor = Color.Black
        txtJumlah.Location = New Point(814, 304)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(138, 27)
        txtJumlah.TabIndex = 6
        txtJumlah.Text = "txtJumlah"
        ' 
        ' btnKurang
        ' 
        btnKurang.BackColor = Color.Silver
        btnKurang.FlatStyle = FlatStyle.Popup
        btnKurang.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnKurang.ForeColor = Color.Black
        btnKurang.Location = New Point(775, 304)
        btnKurang.Name = "btnKurang"
        btnKurang.Size = New Size(33, 28)
        btnKurang.TabIndex = 7
        btnKurang.Text = "-"
        btnKurang.UseVisualStyleBackColor = False
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.Silver
        btnTambah.FlatStyle = FlatStyle.Popup
        btnTambah.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnTambah.ForeColor = Color.Black
        btnTambah.Location = New Point(957, 304)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(28, 27)
        btnTambah.TabIndex = 7
        btnTambah.Text = "+"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnCetakStruk
        ' 
        btnCetakStruk.BackColor = SystemColors.ActiveCaption
        btnCetakStruk.FlatStyle = FlatStyle.Popup
        btnCetakStruk.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnCetakStruk.Location = New Point(732, 679)
        btnCetakStruk.Name = "btnCetakStruk"
        btnCetakStruk.Size = New Size(299, 29)
        btnCetakStruk.TabIndex = 0
        btnCetakStruk.Text = "Cetak Struk"
        btnCetakStruk.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(847, 279)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 20)
        Label2.TabIndex = 10
        Label2.Text = "Keranjang"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Transparent
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {menuBack})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1062, 28)
        MenuStrip1.TabIndex = 11
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' menuBack
        ' 
        menuBack.Alignment = ToolStripItemAlignment.Right
        menuBack.BackColor = Color.Red
        menuBack.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        menuBack.ForeColor = Color.White
        menuBack.Name = "menuBack"
        menuBack.Size = New Size(79, 24)
        menuBack.Text = "Log Out"
        ' 
        ' txtStok
        ' 
        txtStok.BackColor = Color.Silver
        txtStok.BorderStyle = BorderStyle.FixedSingle
        txtStok.Location = New Point(596, 84)
        txtStok.MaxLength = 10
        txtStok.Name = "txtStok"
        txtStok.ReadOnly = True
        txtStok.Size = New Size(86, 27)
        txtStok.TabIndex = 17
        txtStok.Text = "txtStok"
        ' 
        ' txtHarga
        ' 
        txtHarga.BackColor = Color.Silver
        txtHarga.BorderStyle = BorderStyle.FixedSingle
        txtHarga.Location = New Point(383, 223)
        txtHarga.Name = "txtHarga"
        txtHarga.ReadOnly = True
        txtHarga.Size = New Size(299, 27)
        txtHarga.TabIndex = 18
        txtHarga.Text = "txtHarga"
        ' 
        ' txtPenulis
        ' 
        txtPenulis.BackColor = Color.Silver
        txtPenulis.BorderStyle = BorderStyle.FixedSingle
        txtPenulis.Location = New Point(383, 153)
        txtPenulis.MaxLength = 50
        txtPenulis.Name = "txtPenulis"
        txtPenulis.ReadOnly = True
        txtPenulis.Size = New Size(299, 27)
        txtPenulis.TabIndex = 19
        txtPenulis.Text = "txtPenulis"
        ' 
        ' txtJudul
        ' 
        txtJudul.BackColor = Color.Silver
        txtJudul.BorderStyle = BorderStyle.FixedSingle
        txtJudul.Location = New Point(383, 118)
        txtJudul.MaxLength = 50
        txtJudul.Name = "txtJudul"
        txtJudul.ReadOnly = True
        txtJudul.Size = New Size(299, 27)
        txtJudul.TabIndex = 20
        txtJudul.Text = "txtJudul"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.Control
        Label7.Location = New Point(534, 87)
        Label7.Name = "Label7"
        Label7.Size = New Size(40, 20)
        Label7.TabIndex = 13
        Label7.Text = "Stok"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(284, 226)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 20)
        Label5.TabIndex = 14
        Label5.Text = "Harga"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(284, 156)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 20)
        Label4.TabIndex = 15
        Label4.Text = "Penulis"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(284, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 20)
        Label3.TabIndex = 16
        Label3.Text = "Judul "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(284, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 20)
        Label1.TabIndex = 12
        Label1.Text = "Id Buku"
        ' 
        ' txtIdBuku
        ' 
        txtIdBuku.BackColor = SystemColors.Control
        txtIdBuku.Location = New Point(383, 84)
        txtIdBuku.Name = "txtIdBuku"
        txtIdBuku.Size = New Size(120, 27)
        txtIdBuku.TabIndex = 17
        txtIdBuku.Text = "txtIdBuku"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(284, 262)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 20)
        Label6.TabIndex = 14
        Label6.Text = "Jenis"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(284, 296)
        Label8.Name = "Label8"
        Label8.Size = New Size(51, 20)
        Label8.TabIndex = 14
        Label8.Text = "Genre"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label9.ForeColor = SystemColors.Control
        Label9.Location = New Point(847, 83)
        Label9.Name = "Label9"
        Label9.Size = New Size(73, 20)
        Label9.TabIndex = 13
        Label9.Text = "Deskripsi"
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.BackColor = Color.Silver
        txtDeskripsi.BorderStyle = BorderStyle.FixedSingle
        txtDeskripsi.Location = New Point(732, 107)
        txtDeskripsi.MaxLength = 255
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.ReadOnly = True
        txtDeskripsi.Size = New Size(299, 158)
        txtDeskripsi.TabIndex = 18
        txtDeskripsi.Text = "txtDeskripsi"
        ' 
        ' txtJenis
        ' 
        txtJenis.BackColor = Color.Silver
        txtJenis.BorderStyle = BorderStyle.FixedSingle
        txtJenis.Location = New Point(383, 259)
        txtJenis.Name = "txtJenis"
        txtJenis.ReadOnly = True
        txtJenis.Size = New Size(299, 27)
        txtJenis.TabIndex = 18
        txtJenis.Text = "txtJenis"
        ' 
        ' txtGenre
        ' 
        txtGenre.BackColor = Color.Silver
        txtGenre.BorderStyle = BorderStyle.FixedSingle
        txtGenre.Location = New Point(383, 296)
        txtGenre.Name = "txtGenre"
        txtGenre.ReadOnly = True
        txtGenre.Size = New Size(299, 27)
        txtGenre.TabIndex = 18
        txtGenre.Text = "txtGenre"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label10.ForeColor = SystemColors.Control
        Label10.Location = New Point(33, 348)
        Label10.Name = "Label10"
        Label10.Size = New Size(36, 20)
        Label10.TabIndex = 12
        Label10.Text = "Cari"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.AllowUserToResizeColumns = False
        DataGridView2.AllowUserToResizeRows = False
        DataGridView2.BackgroundColor = SystemColors.Control
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(732, 378)
        DataGridView2.MultiSelect = False
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersVisible = False
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.ShowEditingIcon = False
        DataGridView2.Size = New Size(299, 295)
        DataGridView2.TabIndex = 21
        ' 
        ' btnHapusKeranjang
        ' 
        btnHapusKeranjang.BackColor = Color.Silver
        btnHapusKeranjang.Enabled = False
        btnHapusKeranjang.FlatStyle = FlatStyle.Popup
        btnHapusKeranjang.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnHapusKeranjang.ForeColor = Color.Black
        btnHapusKeranjang.Location = New Point(734, 342)
        btnHapusKeranjang.Name = "btnHapusKeranjang"
        btnHapusKeranjang.Size = New Size(150, 29)
        btnHapusKeranjang.TabIndex = 22
        btnHapusKeranjang.Text = "Hapus"
        btnHapusKeranjang.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Silver
        PictureBox1.Location = New Point(30, 73)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(231, 243)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        PrintDocument1.DocumentName = "Struk_Pesanan"
        ' 
        ' txtTahunTerbit
        ' 
        txtTahunTerbit.BackColor = Color.Silver
        txtTahunTerbit.BorderStyle = BorderStyle.FixedSingle
        txtTahunTerbit.Location = New Point(383, 187)
        txtTahunTerbit.Name = "txtTahunTerbit"
        txtTahunTerbit.ReadOnly = True
        txtTahunTerbit.Size = New Size(299, 27)
        txtTahunTerbit.TabIndex = 26
        txtTahunTerbit.Text = "txtTahunTerbit"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label12.ForeColor = SystemColors.Control
        Label12.Location = New Point(284, 190)
        Label12.Name = "Label12"
        Label12.Size = New Size(97, 20)
        Label12.TabIndex = 25
        Label12.Text = "Tahun Terbit"
        ' 
        ' labelUsername
        ' 
        labelUsername.AutoSize = True
        labelUsername.BackColor = Color.FromArgb(CByte(51), CByte(91), CByte(138))
        labelUsername.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        labelUsername.ForeColor = Color.White
        labelUsername.Location = New Point(30, 50)
        labelUsername.Name = "labelUsername"
        labelUsername.Size = New Size(82, 20)
        labelUsername.TabIndex = 27
        labelUsername.Text = "Welcome, "
        ' 
        ' User_Menu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Menu_User
        ClientSize = New Size(1062, 721)
        Controls.Add(labelUsername)
        Controls.Add(txtTahunTerbit)
        Controls.Add(Label12)
        Controls.Add(PictureBox1)
        Controls.Add(btnHapusKeranjang)
        Controls.Add(DataGridView2)
        Controls.Add(txtIdBuku)
        Controls.Add(txtStok)
        Controls.Add(txtDeskripsi)
        Controls.Add(txtGenre)
        Controls.Add(txtJenis)
        Controls.Add(txtHarga)
        Controls.Add(txtPenulis)
        Controls.Add(txtJudul)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label10)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(btnTambah)
        Controls.Add(btnKurang)
        Controls.Add(txtJumlah)
        Controls.Add(txtSearch)
        Controls.Add(DataGridView1)
        Controls.Add(btnCetakStruk)
        Controls.Add(btnTambahKeranjang)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        MaximumSize = New Size(1080, 768)
        MinimumSize = New Size(1080, 768)
        Name = "User_Menu"
        Text = "Haven Media (Member)"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTambahKeranjang As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents btnKurang As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnCetakStruk As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuBack As ToolStripMenuItem
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtPenulis As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdBuku As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents txtJenis As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnHapusKeranjang As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents txtTahunTerbit As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents labelUsername As Label
End Class
