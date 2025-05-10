Imports MySql.Data.MySqlClient

Public Class Landing

    Private Sub Landing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Pict Member,  Admin
    Private Sub pictMember_MouseHover(sender As Object, e As EventArgs) Handles pictMember.MouseHover
        pictMember.Image = My.Resources.icon_member_dark
    End Sub
    Private Sub pictMember_MouseLeave(sender As Object, e As EventArgs) Handles pictMember.MouseLeave
        pictMember.Image = My.Resources.icon_member_light
    End Sub

    Private Sub pictAdmin_MouseHover(sender As Object, e As EventArgs) Handles pictAdmin.MouseHover
        pictAdmin.Image = My.Resources.icon_admin_dark
    End Sub
    Private Sub pictAdmin_MouseLeave(sender As Object, e As EventArgs) Handles pictAdmin.MouseLeave
        pictAdmin.Image = My.Resources.icon_admin_light
    End Sub

    Private Sub pictBelanja_Click(sender As Object, e As EventArgs)
        User_Menu.Show()
        Close()
    End Sub
    Private Sub pictMember_Click(sender As Object, e As EventArgs) Handles pictMember.Click
        panelLoginMember.Visible = True
        pictMember.Visible = False
        pictAdmin.Visible = False
    End Sub

    Private Sub pictAdmin_Click(sender As Object, e As EventArgs) Handles pictAdmin.Click
        panelLoginAdmin.Visible = True
        pictAdmin.Visible = False
        pictMember.Visible = False
    End Sub

    'Panel Form Login Admin
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBackAdmin.Click
        panelLoginAdmin.Visible = False
        pictAdmin.Visible = True
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsernameAdmin.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If

        If e.KeyCode = Keys.Enter Then
            txtPasswordAdmin.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPasswordAdmin.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If

        If e.KeyCode = Keys.Enter Then
            btnLoginAdmin.Focus()
        End If
    End Sub

    'Auntentikasi Admin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLoginAdmin.Click
        If txtUsernameAdmin.Text = "" Or txtPasswordAdmin.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong", MsgBoxStyle.Critical, "Error")
            txtUsernameAdmin.Focus()
            Exit Sub
        Else
            koneksi()
            Dim query As String = "SELECT * FROM tbUser WHERE username = @username AND password = @password AND role = 'admin'"
            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@username", txtUsernameAdmin.Text)
            CMD.Parameters.AddWithValue("@password", txtPasswordAdmin.Text)
            DA = New MySqlDataAdapter(CMD)
            DS = New DataSet()
            DA.Fill(DS, "tbUser")
            If DS.Tables("tbUser").Rows.Count = 0 Then
                MsgBox("Username atau Password salah", MsgBoxStyle.Critical, "Error")
                txtUsernameAdmin.Focus()
                txtUsernameAdmin.Clear()
                txtPasswordAdmin.Clear()
            Else
                DA.Dispose()
                DS.Dispose()
                CMD.Dispose()
                CONN.Close()

                MsgBox("Login Berhasil", MsgBoxStyle.Information, "Success")
                loggged_username = txtUsernameAdmin.Text
                loggged_role = "admin"
                Admin_Menu.Show()
                Me.Close()
            End If
        End If
    End Sub

    'Panel Form Member
    Private Sub btnBackMember_Click(sender As Object, e As EventArgs) Handles btnBackMember.Click
        panelLoginMember.Visible = False
        pictMember.Visible = True
        pictAdmin.Visible = True
    End Sub

    Private Sub txtUsernameMember_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsernameMember.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
        If e.KeyCode = Keys.Enter Then
            txtPasswordMember.Focus()
        End If
    End Sub

    Private Sub txtPasswordMember_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPasswordMember.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
        If e.KeyCode = Keys.Enter Then
            btnLoginMember.Focus()
        End If
    End Sub

    'Login Member
    Private Sub btnLoginMember_Click(sender As Object, e As EventArgs) Handles btnLoginMember.Click
        If txtUsernameMember.Text = "" Or txtPasswordMember.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong", MsgBoxStyle.Critical, "Error")
            txtUsernameMember.Focus()
            Exit Sub
        Else
            koneksi()
            Dim query As String = "SELECT * FROM tbUser WHERE username = @username AND password = @password AND role = 'member'"
            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@username", txtUsernameMember.Text)
            CMD.Parameters.AddWithValue("@password", txtPasswordMember.Text)
            DA = New MySqlDataAdapter(CMD)
            DS = New DataSet()
            DA.Fill(DS, "tbUser")
            If DS.Tables("tbUser").Rows.Count = 0 Then
                MsgBox("Username atau Password salah", MsgBoxStyle.Critical, "Error")
                txtUsernameMember.Focus()
                txtUsernameMember.Clear()
                txtPasswordMember.Clear()
            Else
                DA.Dispose()
                DS.Dispose()
                CMD.Dispose()
                CONN.Close()

                MsgBox("Login Berhasil", MsgBoxStyle.Information, "Success")
                loggged_username = txtUsernameMember.Text
                loggged_role = "member"
                User_Menu.Show()
                Me.Close()
            End If
        End If
    End Sub

    'Regist Member
    Private Sub btnRegistMember_Click(sender As Object, e As EventArgs) Handles btnRegistMember.Click
        If txtUsernameMember.Text = "" Or txtPasswordMember.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong", MsgBoxStyle.Critical, "Error")
            txtUsernameMember.Focus()
            Exit Sub
        Else
            koneksi()
            Dim checkQuery As String = "SELECT * FROM tbUser WHERE username = @username"
            CMD = New MySqlCommand(checkQuery, CONN)
            CMD.Parameters.AddWithValue("@username", txtUsernameMember.Text)
            DA = New MySqlDataAdapter(CMD)
            DS = New DataSet()
            DA.Fill(DS, "tbUser")
            If DS.Tables("tbUser").Rows.Count > 0 Then
                MsgBox("Username sudah terdaftar, gunakan username lain", MsgBoxStyle.Critical, "Error")
                txtUsernameMember.Focus()
                txtUsernameMember.Clear()
                txtPasswordMember.Clear()
            Else
                Dim query As String = "INSERT INTO tbUser (username, password, role) VALUES (@username, @password, 'member')"
                CMD = New MySqlCommand(query, CONN)
                CMD.Parameters.AddWithValue("@username", txtUsernameMember.Text)
                CMD.Parameters.AddWithValue("@password", txtPasswordMember.Text)
                CMD.ExecuteNonQuery()
                MsgBox("Registrasi Berhasil", MsgBoxStyle.Information, "Success")
            End If
            DA.Dispose()
            DS.Dispose()
            CMD.Dispose()
            CONN.Close()
        End If
    End Sub
End Class