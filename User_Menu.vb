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

    Sub Show_Data()
        Dim query As String = "SELECT * FROM tbBuku"
        CMD = New MySqlCommand(query, CONN)
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet()
        DA.Fill(DS, "tbBuku")
        DataGridView1.DataSource = DS.Tables("tbBuku")
    End Sub

    Sub Atur_Grid()
        With DataGridView1
            'only show 4 columns
            .Columns(0).HeaderText = "Id"
            .Columns(0).Width = 40
            .Columns(1).HeaderText = "Judul Buku"
            .Columns(1).Width = 140
            .Columns(2).HeaderText = "Penulis"
            .Columns(2).Width = 140
            .Columns(3).HeaderText = "Jenis Buku"
            .Columns(3).Width = 140
            .Columns(4).HeaderText = "Genre"
            .Columns(4).Width = 140
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
        End With
    End Sub

    Private Sub User_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Database
        ClearTxt()
        koneksi()
        Show_Data()
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

    'Klik DataGrid
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer = DataGridView1.CurrentRow.Index
        txtIdBuku.Text = DataGridView1.Item(0, i).Value.ToString()
        txtJudul.Text = DataGridView1.Item(1, i).Value.ToString()
        txtPenulis.Text = DataGridView1.Item(2, i).Value.ToString()
        txtStok.Text = DataGridView1.Item(3, i).Value.ToString()
        txtHarga.Text = DataGridView1.Item(4, i).Value.ToString()
        txtJenis.Text = DataGridView1.Item(5, i).Value.ToString()
        txtGenre.Text = DataGridView1.Item(6, i).Value.ToString()
        txtDeskripsi.Text = DataGridView1.Item(7, i).Value.ToString()
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

    'Input Jumlah Keranjang
    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        If e.KeyChar = Chr(13) Then
            txtJudul.Focus()
        End If

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
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
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub
End Class