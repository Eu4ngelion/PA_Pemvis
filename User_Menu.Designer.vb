<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        btnAdd = New Button()
        DataGridView1 = New DataGridView()
        labelJudul = New Label()
        txtSearch = New TextBox()
        txtJumlah = New TextBox()
        btnKurang = New Button()
        btnTambah = New Button()
        btnCetakStruk = New Button()
        listKeranjang = New ListBox()
        Label2 = New Label()
        PrintDialog1 = New PrintDialog()
        MenuStrip1 = New MenuStrip()
        menuBack = New ToolStripMenuItem()
        txtStok = New TextBox()
        txtHarga = New TextBox()
        txtPenulis = New TextBox()
        txtNamaBuku = New TextBox()
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
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(758, 384)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(128, 29)
        btnAdd.TabIndex = 0
        btnAdd.Text = "+ Keranjang"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(30, 340)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(652, 368)
        DataGridView1.TabIndex = 1
        ' 
        ' labelJudul
        ' 
        labelJudul.AutoSize = True
        labelJudul.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        labelJudul.Location = New Point(482, 9)
        labelJudul.Name = "labelJudul"
        labelJudul.Size = New Size(115, 23)
        labelJudul.TabIndex = 2
        labelJudul.Text = "Haven Media"
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.Cyan
        txtSearch.Location = New Point(91, 296)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(591, 27)
        txtSearch.TabIndex = 4
        txtSearch.Text = "txtSearch"
        ' 
        ' txtJumlah
        ' 
        txtJumlah.Location = New Point(825, 340)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(138, 27)
        txtJumlah.TabIndex = 6
        txtJumlah.Text = "txtJumlah"
        ' 
        ' btnKurang
        ' 
        btnKurang.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnKurang.Location = New Point(758, 338)
        btnKurang.Name = "btnKurang"
        btnKurang.Size = New Size(61, 31)
        btnKurang.TabIndex = 7
        btnKurang.Text = "-"
        btnKurang.UseVisualStyleBackColor = True
        ' 
        ' btnTambah
        ' 
        btnTambah.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnTambah.Location = New Point(969, 339)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(62, 29)
        btnTambah.TabIndex = 7
        btnTambah.Text = "+"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnCetakStruk
        ' 
        btnCetakStruk.Location = New Point(900, 384)
        btnCetakStruk.Name = "btnCetakStruk"
        btnCetakStruk.Size = New Size(131, 29)
        btnCetakStruk.TabIndex = 0
        btnCetakStruk.Text = "Cetak Struk"
        btnCetakStruk.UseVisualStyleBackColor = True
        ' 
        ' listKeranjang
        ' 
        listKeranjang.FormattingEnabled = True
        listKeranjang.Location = New Point(759, 424)
        listKeranjang.Name = "listKeranjang"
        listKeranjang.Size = New Size(272, 284)
        listKeranjang.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(856, 291)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 20)
        Label2.TabIndex = 10
        Label2.Text = "Keranjang"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' MenuStrip1
        ' 
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
        menuBack.Name = "menuBack"
        menuBack.Size = New Size(54, 24)
        menuBack.Text = "Back"
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(345, 48)
        txtStok.Name = "txtStok"
        txtStok.ReadOnly = True
        txtStok.Size = New Size(120, 27)
        txtStok.TabIndex = 17
        txtStok.Text = "txtStok"
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(132, 151)
        txtHarga.Name = "txtHarga"
        txtHarga.ReadOnly = True
        txtHarga.Size = New Size(333, 27)
        txtHarga.TabIndex = 18
        txtHarga.Text = "txtHarga"
        ' 
        ' txtPenulis
        ' 
        txtPenulis.Location = New Point(132, 118)
        txtPenulis.Name = "txtPenulis"
        txtPenulis.ReadOnly = True
        txtPenulis.Size = New Size(333, 27)
        txtPenulis.TabIndex = 19
        txtPenulis.Text = "txtPenulis"
        ' 
        ' txtNamaBuku
        ' 
        txtNamaBuku.BackColor = SystemColors.Control
        txtNamaBuku.Location = New Point(132, 85)
        txtNamaBuku.Name = "txtNamaBuku"
        txtNamaBuku.ReadOnly = True
        txtNamaBuku.Size = New Size(333, 27)
        txtNamaBuku.TabIndex = 20
        txtNamaBuku.Text = "txtNamaBuku"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(281, 52)
        Label7.Name = "Label7"
        Label7.Size = New Size(38, 20)
        Label7.TabIndex = 13
        Label7.Text = "Stok"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(31, 154)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 20)
        Label5.TabIndex = 14
        Label5.Text = "Harga"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 118)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 20)
        Label4.TabIndex = 15
        Label4.Text = "Penulis"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 20)
        Label3.TabIndex = 16
        Label3.Text = "Nama Buku"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 20)
        Label1.TabIndex = 12
        Label1.Text = "Id Buku"
        ' 
        ' txtIdBuku
        ' 
        txtIdBuku.BackColor = Color.Cyan
        txtIdBuku.Location = New Point(132, 45)
        txtIdBuku.Name = "txtIdBuku"
        txtIdBuku.Size = New Size(120, 27)
        txtIdBuku.TabIndex = 17
        txtIdBuku.Text = "txtIdBuku"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(31, 187)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 20)
        Label6.TabIndex = 14
        Label6.Text = "Jenis"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(31, 220)
        Label8.Name = "Label8"
        Label8.Size = New Size(48, 20)
        Label8.TabIndex = 14
        Label8.Text = "Genre"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(750, 52)
        Label9.Name = "Label9"
        Label9.Size = New Size(69, 20)
        Label9.TabIndex = 13
        Label9.Text = "Deskripsi"
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.Location = New Point(530, 82)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.ReadOnly = True
        txtDeskripsi.Size = New Size(501, 158)
        txtDeskripsi.TabIndex = 18
        txtDeskripsi.Text = "txtDeskripsi"
        ' 
        ' txtJenis
        ' 
        txtJenis.Location = New Point(132, 184)
        txtJenis.Name = "txtJenis"
        txtJenis.ReadOnly = True
        txtJenis.Size = New Size(333, 27)
        txtJenis.TabIndex = 18
        txtJenis.Text = "txtJenis"
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(132, 217)
        txtGenre.Name = "txtGenre"
        txtGenre.ReadOnly = True
        txtGenre.Size = New Size(333, 27)
        txtGenre.TabIndex = 18
        txtGenre.Text = "txtGenre"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(32, 299)
        Label10.Name = "Label10"
        Label10.Size = New Size(53, 20)
        Label10.TabIndex = 12
        Label10.Text = "Search"
        ' 
        ' User_Menu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1062, 721)
        Controls.Add(txtIdBuku)
        Controls.Add(txtStok)
        Controls.Add(txtDeskripsi)
        Controls.Add(txtGenre)
        Controls.Add(txtJenis)
        Controls.Add(txtHarga)
        Controls.Add(txtPenulis)
        Controls.Add(txtNamaBuku)
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
        Controls.Add(listKeranjang)
        Controls.Add(btnTambah)
        Controls.Add(btnKurang)
        Controls.Add(txtJumlah)
        Controls.Add(txtSearch)
        Controls.Add(labelJudul)
        Controls.Add(DataGridView1)
        Controls.Add(btnCetakStruk)
        Controls.Add(btnAdd)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "User_Menu"
        Text = "Nama Buku..."
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents labelJudul As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents btnKurang As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnCetakStruk As Button
    Friend WithEvents listKeranjang As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuBack As ToolStripMenuItem
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtPenulis As TextBox
    Friend WithEvents txtNamaBuku As TextBox
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
End Class
