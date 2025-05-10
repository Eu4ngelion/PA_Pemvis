Imports MySql.Data.MySqlClient
Public Class User_Menu
    Sub ClearTxt()
        txtIdBuku.Clear()
        txtNamaBuku.Clear()
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

    Private Sub User_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Database
        ClearTxt()
        koneksi()
        Show_Data()

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuBack.Click
        Landing.Show()
        Me.Close()
    End Sub

    'Penginputan Id Buku
    Private Sub txtIdBuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdBuku.KeyPress
        If e.KeyChar = Chr(13) Then
            txtNamaBuku.Focus()
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
            txtNamaBuku.Text = DS.Tables("tbBuku").Rows(0).Item("nama").ToString()
            txtPenulis.Text = DS.Tables("tbBuku").Rows(0).Item("penulis").ToString()
            txtHarga.Text = DS.Tables("tbBuku").Rows(0).Item("harga").ToString()
            txtJenis.Text = DS.Tables("tbBuku").Rows(0).Item("jenis").ToString()
            txtGenre.Text = DS.Tables("tbBuku").Rows(0).Item("genre").ToString()
            txtDeskripsi.Text = DS.Tables("tbBuku").Rows(0).Item("deskripsi").ToString()
        Else
            MessageBox.Show("Data Buku dengan Id: " + txtIdBuku.Text + " tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtIdBuku.Focus()
            txtNamaBuku.Clear()
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
        Dim query = "SELECT * FROM tbBuku WHERE id LIKE @cari OR nama LIKE @cari OR penulis LIKE @cari OR harga LIKE @cari OR jenis LIKE @cari OR genre LIKE @cari"
        CMD = New MySqlCommand(query, CONN)
        CMD.Parameters.AddWithValue("@cari", "%" + txtSearch.Text + "%")
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet
        DA.Fill(DS, "tbBuku")
        If DS.Tables("tbBuku").Rows.Count > 0 Then
            DataGridView1.DataSource = DS.Tables("tbBuku")
        End If
    End Sub
End Class