Imports MySql.Data.MySqlClient
Public Class User_Menu

    'Fungsi Clear Tools
    Sub ClearTxt()
        txtIdBuku.Clear()
        txtJudul.Clear()
        txtStok.Clear()
        txtPenulis.Clear()
        txtHarga.Clear()
        txtJenis.Clear()
        txtGenre.Clear()
        txtDeskripsi.Clear()
        txtSearch.Clear()
        txtTahunTerbit.Clear()
        PictureBox1.Image = Nothing
    End Sub

    'Fungsi Show Datagrid Buku
    Sub Show_Data_Buku()
        Dim query As String = "SELECT * FROM tbBuku"
        CMD = New MySqlCommand(query, CONN)
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet()
        DA.Fill(DS, "tbBuku")
        DataGridView1.DataSource = DS.Tables("tbBuku")
        DataGridView1.Refresh()
    End Sub

    'Fungsi Show Datagrid Keranjang
    Sub Show_Data_Keranjang()
        Dim query As String = "SELECT k.id_buku, b.judul, k.jumlah, ROUND(b.harga * k.jumlah, 2) AS sub_total FROM tbKeranjang k INNER JOIN tbBuku b ON k.id_buku = b.id WHERE k.id_user = @id_user"
        CMD = New MySqlCommand(query, CONN)
        CMD.Parameters.AddWithValue("@id_user", logged_id)
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet()
        DA.Fill(DS, "tbKeranjang")
        DataGridView2.DataSource = DS.Tables("tbKeranjang")
        DataGridView2.Refresh()
    End Sub

    'Fungsi Atur Grid
    Sub Atur_Grid()
        ' id, judul, penulis, tahun terbit, jenis, genre, harga, stok, deskripsi, cover
        With DataGridView1
            .Columns(0).HeaderText = "Id"
            .Columns(0).Width = 50
            .Columns(1).HeaderText = "Judul Buku"
            .Columns(1).Width = 140
            .Columns(2).HeaderText = "Penulis"
            .Columns(2).Width = 140
            .Columns(3).HeaderText = "Tahun"
            .Columns(3).Width = 80
            .Columns(4).HeaderText = "Jenis"
            .Columns(4).Width = 100
            .Columns(5).HeaderText = "Genre"
            .Columns(5).Width = 140
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False

            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        End With

        With DataGridView2
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Judul Buku"
            .Columns(1).Width = 120
            .Columns(2).HeaderText = "Pcs"
            .Columns(2).Width = 60
            .Columns(3).HeaderText = "Sub Total"
            .Columns(3).Width = 120
        End With
    End Sub

    'Form Load
    Private Sub User_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        ClearTxt()
        Show_Data_Buku()
        Show_Data_Keranjang()
        Atur_Grid()

        'Welcove, username
        labelUsername.Text = "Welcome, " & logged_username
    End Sub

    ' Logout
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuBack.Click
        Landing.Show()
        Me.Close()
    End Sub

    'Penginputan Id Buku
    Private Sub txtIdBuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdBuku.KeyPress
        If e.KeyChar = Chr(13) Then
            txtJudul.Focus()
        End If

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtIdBuku_Leave(sender As Object, e As EventArgs) Handles txtIdBuku.Leave
        Dim query As String = "SELECT * FROM tbBuku WHERE id = @idBuku"
        CMD = New MySqlCommand(query, CONN)
        CMD.Parameters.AddWithValue("@idBuku", txtIdBuku.Text)
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet()
        DA.Fill(DS, "tbBuku")
        If DS.Tables("tbBuku").Rows.Count > 0 Then
            txtStok.Text = DS.Tables("tbBuku").Rows(0).Item("stok").ToString()
            txtJudul.Text = DS.Tables("tbBuku").Rows(0).Item("judul").ToString()
            txtPenulis.Text = DS.Tables("tbBuku").Rows(0).Item("penulis").ToString()
            txtHarga.Text = DS.Tables("tbBuku").Rows(0).Item("harga").ToString()
            txtJenis.Text = DS.Tables("tbBuku").Rows(0).Item("jenis").ToString()
            txtGenre.Text = DS.Tables("tbBuku").Rows(0).Item("genre").ToString()
            txtDeskripsi.Text = DS.Tables("tbBuku").Rows(0).Item("deskripsi").ToString()
            Dim foto() As Byte = DS.Tables("tbBuku").Rows(0).Item("cover")
            txtTahunTerbit.Text = DS.Tables("tbBuku").Rows(0).Item("tahun_terbit").ToString()
            Dim ms As New IO.MemoryStream(foto)
            PictureBox1.Image = Image.FromStream(ms)
        Else
            txtJudul.Clear()
            txtStok.Clear()
            txtPenulis.Clear()
            txtHarga.Clear()
            txtJenis.Clear()
            txtGenre.Clear()
            txtDeskripsi.Clear()
            txtTahunTerbit.Clear()
            PictureBox1.Image = Nothing
        End If
    End Sub

    'Pencarian Buku
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim query = "SELECT * FROM tbBuku WHERE id LIKE @cari OR " &
            "judul LIKE @cari OR " &
            "penulis LIKE @cari OR " &
            "jenis LIKE @cari OR " &
            "genre LIKE @cari"
        DA = New MySqlDataAdapter(query, CONN)
        DA.SelectCommand.Parameters.AddWithValue("@cari", "%" & txtSearch.Text & "%")
        DS = New DataSet()
        DS.Clear()
        DA.Fill(DS, "tbBuku")
        DataGridView1.DataSource = DS.Tables("tbBuku")
        DataGridView1.Refresh()
    End Sub

    'Klik DataGrid Buku
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            txtIdBuku.Text = DataGridView1.Item(0, e.RowIndex).Value.ToString()
            txtJudul.Text = DataGridView1.Item(1, e.RowIndex).Value.ToString()
            txtPenulis.Text = DataGridView1.Item(2, e.RowIndex).Value.ToString()
            txtTahunTerbit.Text = DataGridView1.Item(3, e.RowIndex).Value.ToString()
            txtJenis.Text = DataGridView1.Item(4, e.RowIndex).Value.ToString()
            txtGenre.Text = DataGridView1.Item(5, e.RowIndex).Value.ToString()
            txtHarga.Text = DataGridView1.Item(6, e.RowIndex).Value.ToString()
            txtStok.Text = DataGridView1.Item(7, e.RowIndex).Value.ToString()
            txtDeskripsi.Text = DataGridView1.Item(8, e.RowIndex).Value.ToString()
            Dim foto() As Byte = DataGridView1.Item(9, e.RowIndex).Value
            Dim ms As New IO.MemoryStream(foto)
            PictureBox1.Image = Image.FromStream(ms)

        End If
    End Sub

    'Klik DataGrid Keranjang
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If e.RowIndex >= 0 Then
            btnHapusKeranjang.Enabled = True
            btnHapusKeranjang.BackColor = Color.Crimson
            btnHapusKeranjang.ForeColor = Color.White
        Else
            btnHapusKeranjang.Enabled = False
            btnHapusKeranjang.BackColor = Color.Silver
            btnHapusKeranjang.ForeColor = Color.LightGray

        End If
    End Sub

    'Keranjang Trigger
    Private Sub txtJudul_TextChanged(sender As Object, e As EventArgs) Handles txtJudul.TextChanged
        If txtJudul.Text = "" Then
            txtJumlah.ReadOnly = True
            txtJumlah.BackColor = Color.Silver
            txtJumlah.ForeColor = Color.LightGray
            txtJumlah.Clear()
        End If
        If txtJudul.Text <> "" Then
            txtJumlah.ReadOnly = False
            txtJumlah.BackColor = Color.White
            txtJumlah.ForeColor = Color.Black
            txtJumlah.Text = 0
        End If
    End Sub

    'Jumlah Keranjang
    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        If e.KeyChar = Chr(13) Then
            txtJudul.Focus()
        End If

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtJumlah_ReadOnlyChanged(sender As Object, e As EventArgs) Handles txtJumlah.ReadOnlyChanged
        If txtJumlah.ReadOnly = True Then
            btnKurang.Enabled = False
            btnKurang.BackColor = Color.Silver
            btnKurang.ForeColor = Color.LightGray
            btnTambah.Enabled = False
            btnTambah.BackColor = Color.Silver
            btnTambah.ForeColor = Color.LightGray
            btnTambahKeranjang.Enabled = False
            btnTambahKeranjang.BackColor = Color.Silver
            btnTambahKeranjang.ForeColor = Color.LightGray
        Else
            btnKurang.Enabled = True
            btnKurang.BackColor = Color.White
            btnKurang.ForeColor = Color.Black
            btnTambah.Enabled = True
            btnTambah.BackColor = Color.White
            btnTambah.ForeColor = Color.Black
            btnTambahKeranjang.Enabled = True
            btnTambahKeranjang.BackColor = Color.MediumSeaGreen
            btnTambahKeranjang.ForeColor = Color.White
        End If

    End Sub

    'Tombol Kurang
    Private Sub btnKurang_Click(sender As Object, e As EventArgs) Handles btnKurang.Click
        If txtJumlah.Text > 0 Then
            txtJumlah.Text -= 1
        End If
    End Sub

    'Tombol Tambah
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtJumlah.Text < txtStok.Text Then
            txtJumlah.Text += 1
        Else
            MessageBox.Show("Stok Buku Tidak Cukup", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Tambah Keranjang
    Private Sub btnTambahKeranjang_Click(sender As Object, e As EventArgs) Handles btnTambahKeranjang.Click
        If txtJumlah.Text = 0 Then
            MessageBox.Show("Jumlah Buku Tidak Boleh Kosong", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtJumlah.Focus()
            Exit Sub
        End If

        'Validasi Stok Input
        If txtJumlah.Text > txtStok.Text Then
            MessageBox.Show("Stok Buku Tidak Cukup", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtJumlah.Focus()
            Exit Sub
        End If

        'Cek apakah buku sudah ada di keranjang
        Dim queryCheck As String = "SELECT jumlah FROM tbKeranjang WHERE id_user = @id_user AND id_buku = @id_buku"
        CMD = New MySqlCommand(queryCheck, CONN)
        CMD.Parameters.AddWithValue("@id_user", logged_id)
        CMD.Parameters.AddWithValue("@id_buku", txtIdBuku.Text)
        Dim kolomKeranjang As Object = CMD.ExecuteScalar()

        If kolomKeranjang IsNot Nothing Then
            'buku sudah ada di keranjang
            Dim jumlahBukuKeranjang As Integer = Convert.ToInt32(kolomKeranjang)
            Dim totalJumlahBuku As Integer = jumlahBukuKeranjang + Convert.ToInt32(txtJumlah.Text)
            If totalJumlahBuku > Convert.ToInt32(txtStok.Text) Then
                MessageBox.Show("Stok Buku Tidak Cukup", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtJumlah.Focus()
                Exit Sub
            End If

            Dim queryUpdate As String = "UPDATE tbKeranjang SET jumlah = jumlah + @jumlah WHERE id_user = @id_user AND id_buku = @id_buku"
            CMD = New MySqlCommand(queryUpdate, CONN)
            CMD.Parameters.AddWithValue("@id_user", logged_id)
            CMD.Parameters.AddWithValue("@id_buku", txtIdBuku.Text)
            CMD.Parameters.AddWithValue("@jumlah", txtJumlah.Text)
            CMD.ExecuteNonQuery()
        Else
            'buku belum ada di keranjang
            Dim queryInsert As String = "INSERT INTO tbKeranjang (id_user, id_buku, jumlah) VALUES (@id_user, @id_buku, @jumlah)"
            CMD = New MySqlCommand(queryInsert, CONN)
            CMD.Parameters.AddWithValue("@id_user", logged_id)
            CMD.Parameters.AddWithValue("@id_buku", txtIdBuku.Text)
            CMD.Parameters.AddWithValue("@jumlah", txtJumlah.Text)
            CMD.ExecuteNonQuery()
        End If

        Show_Data_Keranjang()
    End Sub

    'Hapus Keranjang yang dipilih pada DataGrid
    Private Sub btnHapusKeranjang_Click(sender As Object, e As EventArgs) Handles btnHapusKeranjang.Click
        Dim i = DataGridView2.CurrentRow.Index
        Dim id_buku = DataGridView2.Item(0, i).Value.ToString
        Dim query As String = "DELETE FROM tbKeranjang WHERE id_user = @id_user AND id_buku = @id_buku"
        CMD = New MySqlCommand(query, CONN)
        CMD.Parameters.AddWithValue("@id_user", logged_id)
        CMD.Parameters.AddWithValue("@id_buku", id_buku)
        CMD.ExecuteNonQuery()
        Show_Data_Keranjang()
    End Sub

    'Print Struk Pesan (WIP)
    Private Sub btnCetakStruk_Click(sender As Object, e As EventArgs) Handles btnCetakStruk.Click
        'Validasi Keranjang
        If DataGridView2.Rows.Count < 1 Then
            MessageBox.Show("Keranjang kosong, tidak ada data untuk dicetak.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Cek Stok buku
        Dim IsStokCukup As Boolean = True
        For Each row As DataGridViewRow In DataGridView2.Rows
            If Not row.IsNewRow Then
                Dim id_buku As String = row.Cells(0).Value.ToString()
                Dim jumlah As Integer = Convert.ToInt32(row.Cells(2).Value)
                Dim queryStok As String = "SELECT stok FROM tbBuku WHERE id = @id_buku"
                CMD = New MySqlCommand(queryStok, CONN)
                CMD.Parameters.AddWithValue("@id_buku", id_buku)
                Dim stok As Integer = Convert.ToInt32(CMD.ExecuteScalar())
                If stok < jumlah Then
                    IsStokCukup = False
                    MessageBox.Show("Stok buku tidak cukup untuk judul: " & row.Cells(1).Value.ToString(), "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
        Next

        'Konfirmasi Cetak
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin? Keranjang akan dikosongkan setelah struk dicetak.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Exit Sub
        End If

        'Array keranjang
        Dim arrKeranjang((DataGridView2.Rows.Count - 1), 3) As String
        Dim index As Integer = 0
        For Each row As DataGridViewRow In DataGridView2.Rows
            If Not row.IsNewRow Then
                arrKeranjang(index, 1) = row.Cells(1).Value.ToString() ' Judul Buku
                arrKeranjang(index, 2) = row.Cells(2).Value.ToString() ' Jumlah
                arrKeranjang(index, 3) = row.Cells(3).Value.ToString() ' Sub Total
                index += 1
            End If
        Next

        'Header Struk
        Dim strukContent As String =
                        "=====================================" & Environment.NewLine
        strukContent &= "            STRUK PESANAN           " & Environment.NewLine
        strukContent &= "=====================================" & Environment.NewLine & Environment.NewLine
        strukContent &= "Username: " & logged_username & Environment.NewLine
        strukContent &= "Tanggal: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm") & Environment.NewLine & Environment.NewLine


        'Detail Keranjang
        strukContent &= "-------------------------------------" & Environment.NewLine
        strukContent &= "Judul Buku       Qty     Subtotal" & Environment.NewLine
        strukContent &= "-------------------------------------" & Environment.NewLine & Environment.NewLine
        For Each row As DataGridViewRow In DataGridView2.Rows
            If Not row.IsNewRow Then
                Dim judul As String = row.Cells(1).Value.ToString().PadRight(15)
                Dim qty As String = row.Cells(2).Value.ToString().PadLeft(3)
                Dim subtotal As String = row.Cells(3).Value.ToString().PadLeft(14)
                strukContent &= $"{judul}{qty}{subtotal}" & Environment.NewLine
            End If
        Next

        'Total
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In DataGridView2.Rows
            If Not row.IsNewRow Then
                total += Convert.ToDecimal(row.Cells(3).Value)
            End If
        Next
        strukContent &= Environment.NewLine & "-------------------------------------" & Environment.NewLine
        strukContent &= "Total:".PadLeft(25) & total.ToString("C2").PadLeft(10) & Environment.NewLine & Environment.NewLine
        strukContent &= "=====================================" & Environment.NewLine
        strukContent &= "Terima Kasih atas Pesanan Anda!" & Environment.NewLine
        strukContent &= "=====================================" & Environment.NewLine

        'Print Dokumen
        PrintDocument1.DefaultPageSettings.Landscape = False
        PrintDocument1.DefaultPageSettings.PaperSize = New Printing.PaperSize("Struk", 350, 600)
        AddHandler PrintDocument1.PrintPage, Sub(s, ev)
                                                 ev.Graphics.DrawString(strukContent, New Font("Courier New", 10), Brushes.Black, 10, 10)
                                             End Sub
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

        'Update Stok Buku setelah cetak struk
        For Each row As DataGridViewRow In DataGridView2.Rows
            If Not row.IsNewRow Then
                Dim id_buku As String = row.Cells(0).Value.ToString()
                Dim jumlah As Integer = Convert.ToInt32(row.Cells(2).Value)
                Dim queryUpdateStok As String = "UPDATE tbBuku SET stok = stok - @jumlah WHERE id = @id_buku"
                CMD = New MySqlCommand(queryUpdateStok, CONN)
                CMD.Parameters.AddWithValue("@jumlah", jumlah)
                CMD.Parameters.AddWithValue("@id_buku", id_buku)
                CMD.ExecuteNonQuery()
            End If
        Next

        'Hapus Keranjang
        Dim queryDeleteKeranjang As String = "DELETE FROM tbKeranjang WHERE id_user = @id_user"
        CMD = New MySqlCommand(queryDeleteKeranjang, CONN)
        CMD.Parameters.AddWithValue("@id_user", logged_id)
        CMD.ExecuteNonQuery()
        Show_Data_Keranjang()
        MessageBox.Show("Struk pesanan berhasil dicetak, silahkan bawa ke kasir", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearTxt()
        Show_Data_Buku()
        Show_Data_Keranjang()
    End Sub


End Class