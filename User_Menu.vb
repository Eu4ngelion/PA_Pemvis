Imports MySql.Data.MySqlClient
Public Class User_Menu

    Private Sub User_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Database
        koneksi()
        Dim query As String = "SELECT * FROM tbBuku"
        CMD = New MySqlCommand(query, CONN)
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet()
        DA.Fill(DS, "tbBuku")
        DataGridView1.DataSource = DS.Tables("tbBuku")
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuBack.Click
        Landing.Show()
        Me.Close()
    End Sub
End Class