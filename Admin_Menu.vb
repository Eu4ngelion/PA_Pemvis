Imports MySql.Data.MySqlClient

Public Class Admin_Menu
    'Variabel
    Dim defaultImage As Image

    'Fungsi Clear Tool
    Sub Clear()
        'combo id clear
        comboId.Text = ""
        txtStok.Clear()
        txtJudul.Clear()
        txtPenulis.Clear()
        txtHarga.Clear()
        txtDeskripsi.Clear()
        txtCari.Clear()
        dateTahunTerbit.MaxDate = DateTime.Now.AddHours(+1)
        dateTahunTerbit.Value = DateTime.Now

        radioFiksi.Checked = False
        radioNonFiksi.Checked = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        pictCover.Image = Nothing
    End Sub

    'Fungsi Show Datagrid
    Sub ShowDataBuku()
        Try
            koneksi()
            Dim query As String = "SELECT * FROM tbBuku"
            CMD = New MySqlCommand(query, CONN)
            DA = New MySqlDataAdapter(CMD)
            DS = New DataSet()
            DA.Fill(DS, "tbBuku")
            DataGridView1.DataSource = DS.Tables("tbBuku")
            DataGridView1.Refresh()

            'Update ComboBox
            comboId.Items.Clear()
            For Each row As DataRow In DS.Tables("tbBuku").Rows
                comboId.Items.Add(row("id").ToString())
            Next


        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If CONN IsNot Nothing AndAlso CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try

    End Sub

    'Fungsi Atur Tampilan Grid
    Sub AturGrid()
        With DataGridView1
            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "Judul Buku"
            .Columns(2).HeaderText = "Penulis"
            .Columns(3).HeaderText = "Tahun"
            .Columns(4).HeaderText = "Jenis"
            .Columns(5).HeaderText = "Genre"
            .Columns(6).HeaderText = "Harga"
            .Columns(7).HeaderText = "Stok"
            .Columns(8).Visible = False
            .Columns(9).Visible = False

            .Columns(0).Width = 30
            .Columns(1).Width = 120
            .Columns(2).Width = 80
            .Columns(3).Width = 60
            .Columns(4).Width = 50
            .Columns(5).Width = 70
            .Columns(6).Width = 70
            .Columns(7).Width = 70

            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        End With
    End Sub

    'Load Form
    Private Sub Admin_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Clear()
        ShowDataBuku()
        AturGrid()

        comboId.Focus()
    End Sub

    'Menu Back
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Landing.Show()
        Me.Close()
    End Sub


    'Fungsi Cek Data Inputan
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
            Return False

        ElseIf groupGenre.Controls.OfType(Of CheckBox)().All(Function(c) Not c.Checked) Then
            MsgBox("Genre Buku tidak boleh kosong", MsgBoxStyle.Critical, "Error")
            Return False

        ElseIf pictCover.Image Is Nothing Then
            MsgBox("Gambar Cover tidak boleh kosong", MsgBoxStyle.Critical, "Error")
            Return False
        Else
            Return True
        End If
    End Function

    'Fungsi Cek Duplikat Id
    Function isIdValid() As Boolean
        'ID Unik
        Dim query As String = "SELECT * FROM tbBuku WHERE id = @id"
        CMD = New MySqlCommand(query, CONN)
        CMD.Parameters.AddWithValue("@id", comboId.Text)
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet()
        DA.Fill(DS, "tbBuku")
        If DS.Tables("tbBuku").Rows.Count > 0 Then
            Return False
        End If
        Return True
    End Function


    'Pencarian
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Dim query = "SELECT * FROM tbBuku WHERE id LIKE @cari OR " &
            "judul LIKE @cari OR " &
            "penulis LIKE @cari OR " &
            "jenis LIKE @cari OR " &
            "genre LIKE @cari OR " &
            "harga LIKE @cari OR " &
            "stok LIKE @cari OR " &
            "tahun_terbit LIKE @cari"
        DA = New MySqlDataAdapter(query, CONN)
        DA.SelectCommand.Parameters.AddWithValue("@cari", "%" & txtCari.Text & "%")
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbBuku")
        DataGridView1.DataSource = DS.Tables("tbBuku")
        DataGridView1.Refresh()
    End Sub

    'Klik DataGridView
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            comboId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            txtJudul.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            txtPenulis.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
            dateTahunTerbit.Value = Date.ParseExact(DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString, "yyyy", Nothing)
            If DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString = "Fiksi" Then
                radioFiksi.Checked = True
            Else
                radioNonFiksi.Checked = True
            End If
            Dim genre = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString.Split(", ")
            For Each item In genre
                For Each checkBox In groupGenre.Controls.OfType(Of CheckBox)
                    If checkBox.Text = item Then
                        checkBox.Checked = True
                    End If
                Next
            Next
            txtHarga.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
            txtStok.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
            txtDeskripsi.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString

            Dim foto = CType(DataGridView1.Rows(e.RowIndex).Cells(9).Value, Byte())
            Dim ms As New IO.MemoryStream(foto)
            pictCover.Image = Image.FromStream(ms)
        End If
    End Sub

    'Tambah Buku
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            If isInputValid() Then
                Dim query = "INSERT INTO tbBuku (judul, penulis, harga, stok, tahun_terbit, jenis, genre, deskripsi, cover) " &
                      "VALUES (@judul, @penulis, @harga, @stok, @tahun_terbit, @jenis, @genre, @deskripsi, @cover)"
                CMD = New MySqlCommand(query, CONN)

                CMD.Parameters.AddWithValue("@judul", txtJudul.Text)
                CMD.Parameters.AddWithValue("@penulis", txtPenulis.Text)
                CMD.Parameters.AddWithValue("@harga", Convert.ToDouble(txtHarga.Text))
                CMD.Parameters.AddWithValue("@stok", Convert.ToInt16(txtStok.Text))
                CMD.Parameters.AddWithValue("@tahun_terbit", dateTahunTerbit.Value.ToString("yyyy"))
                CMD.Parameters.AddWithValue("@jenis", If(radioFiksi.Checked, "Fiksi", "Non-Fiksi"))
                CMD.Parameters.AddWithValue("@genre", String.Join(", ", groupGenre.Controls.OfType(Of CheckBox).Where(Function(c) c.Checked).Select(Function(c) c.Text)))
                CMD.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text)
                Dim foto() As Byte = Nothing
                Dim ms As New IO.MemoryStream
                pictCover.Image.Save(ms, pictCover.Image.RawFormat)
                foto = ms.ToArray
                CMD.Parameters.AddWithValue("@cover", foto)

                If CONN.State = ConnectionState.Closed Then
                    CONN.Open()
                End If

                CMD.ExecuteNonQuery()
                MsgBox("Data Buku Berhasil Ditambahkan", MsgBoxStyle.Information, "Success")
                Clear()
                ShowDataBuku()
            End If
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If CONN IsNot Nothing AndAlso CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub
    'Ubah buku
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If isInputValid() And Not isIdValid() Then
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
    Private Sub BtnHapus_Click_1(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Try
            If comboId.Text = "" Then
                MsgBox("Pilih ID Buku yang ingin dihapus", MsgBoxStyle.Critical, "Error")
                comboId.Focus()
                Return
            End If
            Dim query = "DELETE FROM tbBuku WHERE id = @id"
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
    'Input ComboBox
    Private Sub comboId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboId.KeyPress
        If e.KeyChar = Chr(13) Then
            txtStok.Focus()
        End If

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    'Leave ComboBox
    Private Sub comboId_Leave(sender As Object, e As EventArgs) Handles comboId.Leave
        If comboId.Text <> "" Then
            Dim query As String = "SELECT * FROM tbBuku WHERE id = @id"
            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@id", comboId.Text)
            DA = New MySqlDataAdapter(CMD)
            DS = New DataSet()
            DA.Fill(DS, "tbBuku")
            If DS.Tables("tbBuku").Rows.Count > 0 Then
                txtJudul.Text = DS.Tables("tbBuku").Rows(0).Item("judul").ToString()
                txtPenulis.Text = DS.Tables("tbBuku").Rows(0).Item("penulis").ToString()
                txtHarga.Text = DS.Tables("tbBuku").Rows(0).Item("harga").ToString()
                txtStok.Text = DS.Tables("tbBuku").Rows(0).Item("stok").ToString()
                dateTahunTerbit.Value = DateTime.ParseExact(DS.Tables("tbBuku").Rows(0).Item("tahun_terbit").ToString(), "yyyy", Nothing)
                If DS.Tables("tbBuku").Rows(0).Item("jenis").ToString() = "Fiksi" Then
                    radioFiksi.Checked = True
                Else
                    radioNonFiksi.Checked = True
                End If
                Dim genre As String() = DS.Tables("tbBuku").Rows(0).Item("genre").ToString().Split(", ")
                For Each item In genre
                    For Each checkBox In groupGenre.Controls.OfType(Of CheckBox)()
                        If checkBox.Text = item Then
                            checkBox.Checked = True
                        End If
                    Next
                Next
                txtDeskripsi.Text = DS.Tables("tbBuku").Rows(0).Item("deskripsi").ToString()
                Dim foto() As Byte = CType(DS.Tables("tbBuku").Rows(0).Item("cover"), Byte())
                Dim ms As New IO.MemoryStream(foto)
                pictCover.Image = Image.FromStream(ms)
            Else
                Clear()
                comboId.Focus()
            End If
        End If
    End Sub
    'Klik ComboBox
    Private Sub comboId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboId.SelectedIndexChanged
        Dim query As String = "SELECT * FROM tbBuku WHERE id = @id"
        CMD = New MySqlCommand(query, CONN)
        CMD.Parameters.AddWithValue("@id", comboId.Text)
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet()
        DA.Fill(DS, "tbBuku")
        If DS.Tables("tbBuku").Rows.Count > 0 Then
            txtJudul.Text = DS.Tables("tbBuku").Rows(0).Item("judul").ToString()
            txtPenulis.Text = DS.Tables("tbBuku").Rows(0).Item("penulis").ToString()
            txtHarga.Text = DS.Tables("tbBuku").Rows(0).Item("harga").ToString()
            txtStok.Text = DS.Tables("tbBuku").Rows(0).Item("stok").ToString()
            dateTahunTerbit.Value = DateTime.ParseExact(DS.Tables("tbBuku").Rows(0).Item("tahun_terbit").ToString(), "yyyy", Nothing)
            If DS.Tables("tbBuku").Rows(0).Item("jenis").ToString() = "Fiksi" Then
                radioFiksi.Checked = True
            Else
                radioNonFiksi.Checked = True
            End If
            Dim genre As String() = DS.Tables("tbBuku").Rows(0).Item("genre").ToString().Split(", ")
            For Each item In genre
                For Each checkBox In groupGenre.Controls.OfType(Of CheckBox)()
                    If checkBox.Text = item Then
                        checkBox.Checked = True
                    End If
                Next
            Next
            txtDeskripsi.Text = DS.Tables("tbBuku").Rows(0).Item("deskripsi").ToString()
            Dim foto() As Byte = CType(DS.Tables("tbBuku").Rows(0).Item("cover"), Byte())
            Dim ms As New IO.MemoryStream(foto)
            pictCover.Image = Image.FromStream(ms)
        End If
    End Sub

    'Input Stok
    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        If e.KeyChar = Chr(13) Then
            txtJudul.Focus()
        End If
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Input Judul
    Private Sub txtJudul_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJudul.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPenulis.Focus()
        End If
    End Sub

    'Input Penulis
    Private Sub txtPenulis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPenulis.KeyPress
        If e.KeyChar = Chr(13) Then
            dateTahunTerbit.Focus()
        End If
    End Sub

    'Input Tahun Terbit
    Private Sub dateTahunTerbit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dateTahunTerbit.KeyPress
        If e.KeyChar = Chr(13) Then
            txtHarga.Focus()
        End If
    End Sub

    'Input Harga
    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If e.KeyChar = Chr(13) Then
            'fokus ke jenis
            radioFiksi.Focus()
        End If
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        If e.KeyChar = "," AndAlso DirectCast(sender, TextBox).Text.Contains(",") Then
            e.Handled = True
        End If
    End Sub

    'Input Radio Fiksi
    Private Sub radioJenis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles radioFiksi.KeyPress, radioNonFiksi.KeyPress
        If e.KeyChar = Chr(13) Then
            CheckBox1.Focus()
        End If
    End Sub

    'Input CheckBox Genre
    Private Sub CheckBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CheckBox1.KeyPress, CheckBox2.KeyPress, CheckBox4.KeyPress, CheckBox5.KeyPress, CheckBox7.KeyPress, CheckBox8.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDeskripsi.Focus()
        End If
    End Sub

    'Input Deskripsi
    Private Sub txtDeskripsi_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            btnUpload.Focus()
        End If
    End Sub

    'Upload Gambar
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            pictCover.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
        btnTambah.Focus()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class