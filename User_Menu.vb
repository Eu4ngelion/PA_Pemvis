Imports MySql.Data.MySqlClient
Public Class User_Menu
    'Array Keranjang
    Dim keranjang(10) As String

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
    End Sub

    Sub Show_Data_Buku()
        Dim query As String = "SELECT * FROM tbBuku"
        CMD = New MySqlCommand(query, CONN)
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet()
        DA.Fill(DS, "tbBuku")
        DataGridView1.DataSource = DS.Tables("tbBuku")
        DataGridView1.Refresh()
    End Sub

    Sub Show_Data_Keranjang()
        Dim query As String = "SELECT k.id_buku, b.judul, k.jumlah, b.harga * k.jumlah AS sub_total FROM tbKeranjang k INNER JOIN tbBuku b ON k.id_buku = b.id WHERE k.id_user = @id_user"
        CMD = New MySqlCommand(query, CONN)
        CMD.Parameters.AddWithValue("@id_user", logged_id)
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet()
        DA.Fill(DS, "tbKeranjang")
        DataGridView2.DataSource = DS.Tables("tbKeranjang")
        DataGridView2.Refresh()
    End Sub



    Sub Atur_Grid()
        With DataGridView1
            .Columns(0).HeaderText = "Id"
            .Columns(0).Width = 50
            .Columns(1).HeaderText = "Judul Buku"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "Penulis"
            .Columns(2).Width = 150
            .Columns(3).HeaderText = "Jenis Buku"
            .Columns(3).Width = 150
            .Columns(4).HeaderText = "Genre"
            .Columns(4).Width = 150
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
        End With
        With DataGridView2
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Judul Buku"
            .Columns(1).Width = 120
            .Columns(2).HeaderText = "Jumlah"
            .Columns(2).Width = 60
            .Columns(3).HeaderText = "Sub Total"
            .Columns(3).Width = 120
        End With
    End Sub


    Private Sub User_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        ClearTxt()
        Show_Data_Buku()
        Show_Data_Keranjang()
        Atur_Grid()
    End Sub

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
        Else
            MessageBox.Show("Data Buku dengan Id: " + txtIdBuku.Text + " tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtIdBuku.Focus()
            txtJudul.Clear()
            txtStok.Clear()
            txtPenulis.Clear()
            txtHarga.Clear()
            txtJenis.Clear()
            txtGenre.Clear()
            txtDeskripsi.Clear()
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
        Dim i = DataGridView1.CurrentRow.Index
        txtIdBuku.Text = DataGridView1.Item(0, i).Value.ToString
        txtJudul.Text = DataGridView1.Item(1, i).Value.ToString
        txtPenulis.Text = DataGridView1.Item(2, i).Value.ToString
        txtGenre.Text = DataGridView1.Item(3, i).Value.ToString
        txtJenis.Text = DataGridView1.Item(4, i).Value.ToString
        txtHarga.Text = DataGridView1.Item(5, i).Value.ToString
        txtStok.Text = DataGridView1.Item(6, i).Value.ToString
        txtDeskripsi.Text = DataGridView1.Item(7, i).Value.ToString
    End Sub

    'Klik DataGrid Keranjang
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If e.RowIndex >= 0 Then
            btnHapusKeranjang.Enabled = True
        Else
            btnHapusKeranjang.Enabled = False
        End If
    End Sub

    'Keranjang Trigger
    Private Sub txtJudul_TextChanged(sender As Object, e As EventArgs) Handles txtJudul.TextChanged
        If txtJudul.Text = "" Then
            txtJumlah.ReadOnly = True
            txtJumlah.BackColor = Control.DefaultBackColor
            txtJumlah.Clear()
        End If
        If txtJudul.Text <> "" Then
            txtJumlah.ReadOnly = False
            txtJumlah.BackColor = Color.Cyan
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
            btnTambah.Enabled = False
            btnTambahKeranjang.Enabled = False
        Else
            btnKurang.Enabled = True
            btnTambah.Enabled = True
            btnTambahKeranjang.Enabled = True
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

        Dim queryCheck As String = "SELECT jumlah FROM tbKeranjang WHERE id_user = @id_user AND id_buku = @id_buku"
        CMD = New MySqlCommand(queryCheck, CONN)
        CMD.Parameters.AddWithValue("@id_user", logged_id)
        CMD.Parameters.AddWithValue("@id_buku", txtIdBuku.Text)
        Dim jumlahExisting As Object = CMD.ExecuteScalar()

        If jumlahExisting IsNot Nothing Then
            'buku sudah ada di keranjang
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




End Class