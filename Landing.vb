Imports MySql.Data.MySqlClient

Public Class Landing

    Private Sub Landing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Pict Belanja & Admin
    Private Sub pictBelanja_MouseHover(sender As Object, e As EventArgs) Handles pictBelanja.MouseHover
        pictBelanja.Image = My.Resources.icon_belanja_dark
    End Sub
    Private Sub pictBelanja_MouseLeave(sender As Object, e As EventArgs) Handles pictBelanja.MouseLeave
        pictBelanja.Image = My.Resources.icon_belanja_light
    End Sub

    Private Sub pictAdmin_MouseHover(sender As Object, e As EventArgs) Handles pictAdmin.MouseHover
        pictAdmin.Image = My.Resources.icon_admin_dark
    End Sub
    Private Sub pictAdmin_MouseLeave(sender As Object, e As EventArgs) Handles pictAdmin.MouseLeave
        pictAdmin.Image = My.Resources.icon_admin_light
    End Sub
    Private Sub pictBelanja_Click(sender As Object, e As EventArgs) Handles pictBelanja.Click
        User_Menu.Show()
        Me.Close()
    End Sub
    Private Sub pictAdmin_Click(sender As Object, e As EventArgs) Handles pictAdmin.Click
        panelLogin.Visible = True
        pictAdmin.Visible = False
        pictBelanja.Visible = False
    End Sub

    ' Form Login Admin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        panelLogin.Visible = False
        pictAdmin.Visible = True
        pictBelanja.Visible = True
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        'Suppress Key
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If

        'Enter
        If e.KeyCode = Keys.Enter Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        'Suppress Key
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
        'Enter
        If e.KeyCode = Keys.Enter Then
            btnLogin.Focus()
        End If
    End Sub

    ' Authorization (Finish Nanti)
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong", MsgBoxStyle.Critical, "Error")
            txtUsername.Focus()
            Exit Sub
        Else
            'Authorization from Database
            koneksi()
            Dim query As String = "SELECT * FROM tbAdmin WHERE username = @username AND password = @password"
            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@username", txtUsername.Text)
            CMD.Parameters.AddWithValue("@password", txtPassword.Text)
            DA = New MySqlDataAdapter(CMD)
            DS = New DataSet()
            DA.Fill(DS, "tbAdmin")
            If DS.Tables("tbAdmin").Rows.Count = 0 Then
                MsgBox("Username atau Password salah", MsgBoxStyle.Critical, "Error")
                txtUsername.Focus()
                txtUsername.Clear()
                txtPassword.Clear()
            Else
                DA.Dispose()
                DS.Dispose()
                CMD.Dispose()
                CONN.Close()

                MsgBox("Login Berhasil", MsgBoxStyle.Information, "Success")
                Admin_Menu.Show()
                Me.Close()
            End If
        End If
    End Sub
End Class