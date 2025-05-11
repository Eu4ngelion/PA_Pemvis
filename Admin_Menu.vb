Imports MySql.Data.MySqlClient

Public Class Admin_Menu
    Sub Clear()
        'combo id clear
        comboId.Text = ""
        txtStok.Clear()
        txtJudul.Clear()
        txtPenulis.Clear()
        txtHarga.Clear()
        txtDeskripsi.Clear()
        dateTahunTerbit.Value = DateTime.Now
        radioFiksi.Checked = False
        radioNonFiksi.Checked = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        pictCover.Image = My.Resources.no_image
    End Sub

    Sub ShowDataBuku()
        Try
            koneksi()
            Dim query As String = "SELECT * FROM tbBuku"
            CMD = New MySqlCommand(query, CONN)
            DA = New MySqlDataAdapter(CMD)
            DS = New DataSet()
            DA.Fill(DS, "tbBuku")
            DataGridView1.DataSource = DS.Tables("tbBuku")
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If CONN IsNot Nothing AndAlso CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try

    End Sub

    Sub AturGrid()
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "Judul"
        DataGridView1.Columns(2).HeaderText = "Penulis"
        DataGridView1.Columns(3).HeaderText = "Tahun Terbit"
        DataGridView1.Columns(4).HeaderText = "Jenis"
        DataGridView1.Columns(5).HeaderText = "Genre"
        DataGridView1.Columns(6).HeaderText = "Harga"
        DataGridView1.Columns(7).HeaderText = "Stok"
        DataGridView1.Columns(8).Visible = False
        DataGridView1.Columns(9).Visible = False

        DataGridView1.Columns(0).Width = 50
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).Width = 150
        DataGridView1.Columns(3).Width = 150
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 100
        DataGridView1.Columns(7).Width = 100
    End Sub


    Private Sub Admin_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Clear()
        ShowDataBuku()
        AturGrid()
    End Sub

    'Menu Back
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Landing.Show()
        Me.Close()
    End Sub

    'Input Gambar
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pictCover.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    'Check Data Inputan
    Function isInputValid() As Boolean
        If txtJudul.Text = "" Then
            MsgBox("Judul Buku tidak boleh kosong", MsgBoxStyle.Critical, "Error")
            txtJudul.Focus()
            Return False

        ElseIf txtPenulis.Text = "" Then
            MsgBox("Penulis Buku tidak boleh kosong", MsgBoxStyle.Critical, "Error")
            txtPenulis.Focus()
            Return False

        ElseIf txtHarga.Text = "" Then
            MsgBox("Harga Buku tidak boleh kosong", MsgBoxStyle.Critical, "Error")
            txtHarga.Focus()
            Return False

        ElseIf txtStok.Text = "" Then
            MsgBox("Stok Buku tidak boleh kosong", MsgBoxStyle.Critical, "Error")
            txtStok.Focus()
            Return False

        ElseIf groupJenis.Controls.OfType(Of RadioButton)().All(Function(r) Not r.Checked) Then
            MsgBox("Jenis Buku tidak boleh kosong", MsgBoxStyle.Critical, "Error")
            radioFiksi.Focus()
            Return False

        ElseIf groupGenre.Controls.OfType(Of CheckBox)().All(Function(c) Not c.Checked) Then
            MsgBox("Genre Buku tidak boleh kosong", MsgBoxStyle.Critical, "Error")
            CheckBox1.Focus()
            Return False

        End If
        Return True
    End Function

    Function isIdValid() As Boolean
        'ID Unik
        Dim query As String = "SELECT * FROM tbBuku WHERE id = @id"
        CMD = New MySqlCommand(query, CONN)
        CMD.Parameters.AddWithValue("@id", comboId.Text)
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet()
        DA.Fill(DS, "tbBuku")
        If DS.Tables("tbBuku").Rows.Count > 0 Then
            MsgBox("ID sudah ada di database", MsgBoxStyle.Critical, "Error")
            comboId.Focus()
            Return False
        End If
        Return True
    End Function

    'Tambah Buku
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            If isInputValid() Then
                Dim query As String = "INSERT INTO tbBuku (judul, penulis, harga, stok, tahun_terbit, jenis, genre, deskripsi, cover) " &
                      "VALUES (@judul, @penulis, @harga, @stok, @tahun_terbit, @jenis, @genre, @deskripsi, @cover)"
                CMD = New MySqlCommand(query, CONN)

                CMD.Parameters.AddWithValue("@judul", txtJudul.Text)
                CMD.Parameters.AddWithValue("@penulis", txtPenulis.Text)
                CMD.Parameters.AddWithValue("@harga", Convert.ToDouble(txtHarga.Text))
                CMD.Parameters.AddWithValue("@stok", Convert.ToInt16(txtStok.Text))
                CMD.Parameters.AddWithValue("@tahun_terbit", dateTahunTerbit.Value.ToString("yyyy"))
                CMD.Parameters.AddWithValue("@jenis", If(radioFiksi.Checked, "Fiksi", "Non-Fiksi"))
                CMD.Parameters.AddWithValue("@genre", String.Join(", ", groupGenre.Controls.OfType(Of CheckBox)().Where(Function(c) c.Checked).Select(Function(c) c.Text)))
                CMD.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text)
                Dim foto() As Byte = Nothing
                Dim ms As New IO.MemoryStream
                pictCover.Image.Save(ms, pictCover.Image.RawFormat)
                foto = ms.ToArray()
                CMD.Parameters.AddWithValue("@cover", foto)

                If CONN.State = ConnectionState.Closed Then
                    CONN.Open()
                End If

                CMD.ExecuteNonQuery()
                MsgBox("Data Buku Berhasil Ditambahkan", MsgBoxStyle.Information, "Success")
                Clear()
                ShowDataBuku()
            Else
                MsgBox("Input tidak valid. Mohon periksa kembali.", MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If CONN IsNot Nothing AndAlso CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub

    'ubah buku
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Try
            If isInputValid() And isIdValid() Then
                Dim query As String = "UPDATE tbBuku SET judul = @judul, penulis = @penulis, harga = @harga, stok = @stok, tahun_terbit = @tahun_terbit, " &
                    "jenis = @jenis, genre = @genre, deskripsi = @deskripsi, cover = @cover WHERE id = @id"
                CMD = New MySqlCommand(query, CONN)
                CMD.Parameters.AddWithValue("@id", comboId.Text)
                CMD.Parameters.AddWithValue("@judul", txtJudul.Text)
                CMD.Parameters.AddWithValue("@penulis", txtPenulis.Text)
                CMD.Parameters.AddWithValue("@harga", Convert.ToDouble(txtHarga.Text))
                CMD.Parameters.AddWithValue("@stok", Convert.ToInt16(txtStok.Text))
                CMD.Parameters.AddWithValue("@tahun_terbit", dateTahunTerbit.Value.ToString("yyyy"))
                CMD.Parameters.AddWithValue("@jenis", If(radioFiksi.Checked, "Fiksi", "Non-Fiksi"))
                CMD.Parameters.AddWithValue("@genre", String.Join(", ", groupGenre.Controls.OfType(Of CheckBox)().Where(Function(c) c.Checked).Select(Function(c) c.Text)))
                CMD.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text)
                Dim foto() As Byte = Nothing
                Dim ms As New IO.MemoryStream
                pictCover.Image.Save(ms, pictCover.Image.RawFormat)
                foto = ms.ToArray()
                CMD.Parameters.AddWithValue("@cover", foto)

                If CONN.State = ConnectionState.Closed Then
                    CONN.Open()
                End If

                CMD.ExecuteNonQuery()
                MsgBox("Data Buku Berhasil Diubah", MsgBoxStyle.Information, "Success")
                Clear()
                ShowDataBuku()
            Else
                MsgBox("Input tidak valid. Mohon periksa kembali.", MsgBoxStyle.Critical, "Error")
            End If

        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If CONN IsNot Nothing AndAlso CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub

    'Hapus Buku
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try
            If comboId.Text = "" Then
                MsgBox("Pilih ID Buku yang ingin dihapus", MsgBoxStyle.Critical, "Error")
                comboId.Focus()
                Return
            End If
            Dim query As String = "DELETE FROM tbBuku WHERE id = @id"
            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@id", comboId.Text)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
            CMD.ExecuteNonQuery()
            MsgBox("Data Buku Berhasil Dihapus", MsgBoxStyle.Information, "Success")
            Clear()
            ShowDataBuku()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If CONN IsNot Nothing AndAlso CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub
End Class