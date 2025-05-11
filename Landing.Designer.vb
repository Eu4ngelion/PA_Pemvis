<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Landing
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
        landingBg = New PictureBox()
        pictAdmin = New PictureBox()
        panelLoginAdmin = New Panel()
        txtPasswordAdmin = New TextBox()
        txtUsernameAdmin = New TextBox()
        btnBackAdmin = New Button()
        btnLoginAdmin = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        pictMember = New PictureBox()
        panelLoginMember = New Panel()
        txtPasswordMember = New TextBox()
        txtUsernameMember = New TextBox()
        btnBackMember = New Button()
        btnRegistMember = New Button()
        btnLoginMember = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        CType(landingBg, ComponentModel.ISupportInitialize).BeginInit()
        CType(pictAdmin, ComponentModel.ISupportInitialize).BeginInit()
        panelLoginAdmin.SuspendLayout()
        CType(pictMember, ComponentModel.ISupportInitialize).BeginInit()
        panelLoginMember.SuspendLayout()
        SuspendLayout()
        ' 
        ' landingBg
        ' 
        landingBg.Image = My.Resources.Resources.Login_Bg1
        landingBg.Location = New Point(-2, -3)
        landingBg.Name = "landingBg"
        landingBg.Size = New Size(1060, 757)
        landingBg.SizeMode = PictureBoxSizeMode.Zoom
        landingBg.TabIndex = 1
        landingBg.TabStop = False
        ' 
        ' pictAdmin
        ' 
        pictAdmin.Image = My.Resources.Resources.icon_admin_light
        pictAdmin.Location = New Point(552, 403)
        pictAdmin.Name = "pictAdmin"
        pictAdmin.Size = New Size(98, 147)
        pictAdmin.SizeMode = PictureBoxSizeMode.Zoom
        pictAdmin.TabIndex = 3
        pictAdmin.TabStop = False
        ' 
        ' panelLoginAdmin
        ' 
        panelLoginAdmin.BackColor = Color.Transparent
        panelLoginAdmin.Controls.Add(txtPasswordAdmin)
        panelLoginAdmin.Controls.Add(txtUsernameAdmin)
        panelLoginAdmin.Controls.Add(btnBackAdmin)
        panelLoginAdmin.Controls.Add(btnLoginAdmin)
        panelLoginAdmin.Controls.Add(Label3)
        panelLoginAdmin.Controls.Add(Label2)
        panelLoginAdmin.Controls.Add(Label1)
        panelLoginAdmin.Location = New Point(280, 335)
        panelLoginAdmin.Name = "panelLoginAdmin"
        panelLoginAdmin.Size = New Size(493, 257)
        panelLoginAdmin.TabIndex = 4
        panelLoginAdmin.Visible = False
        ' 
        ' txtPasswordAdmin
        ' 
        txtPasswordAdmin.Location = New Point(125, 110)
        txtPasswordAdmin.Name = "txtPasswordAdmin"
        txtPasswordAdmin.Size = New Size(228, 27)
        txtPasswordAdmin.TabIndex = 2
        ' 
        ' txtUsernameAdmin
        ' 
        txtUsernameAdmin.Location = New Point(125, 63)
        txtUsernameAdmin.Name = "txtUsernameAdmin"
        txtUsernameAdmin.Size = New Size(228, 27)
        txtUsernameAdmin.TabIndex = 2
        ' 
        ' btnBackAdmin
        ' 
        btnBackAdmin.Location = New Point(243, 164)
        btnBackAdmin.Name = "btnBackAdmin"
        btnBackAdmin.Size = New Size(94, 29)
        btnBackAdmin.TabIndex = 1
        btnBackAdmin.Text = "Kembali"
        btnBackAdmin.UseVisualStyleBackColor = True
        ' 
        ' btnLoginAdmin
        ' 
        btnLoginAdmin.Location = New Point(133, 164)
        btnLoginAdmin.Name = "btnLoginAdmin"
        btnLoginAdmin.Size = New Size(94, 29)
        btnLoginAdmin.TabIndex = 1
        btnLoginAdmin.Text = "Masuk"
        btnLoginAdmin.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(44, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 0
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(44, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 0
        Label2.Text = "Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(190, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 20)
        Label1.TabIndex = 0
        Label1.Text = "Login Admin"
        ' 
        ' pictMember
        ' 
        pictMember.Image = My.Resources.Resources.icon_member_light
        pictMember.Location = New Point(405, 403)
        pictMember.Name = "pictMember"
        pictMember.Size = New Size(103, 147)
        pictMember.SizeMode = PictureBoxSizeMode.Zoom
        pictMember.TabIndex = 5
        pictMember.TabStop = False
        ' 
        ' panelLoginMember
        ' 
        panelLoginMember.Controls.Add(txtPasswordMember)
        panelLoginMember.Controls.Add(txtUsernameMember)
        panelLoginMember.Controls.Add(btnBackMember)
        panelLoginMember.Controls.Add(btnRegistMember)
        panelLoginMember.Controls.Add(btnLoginMember)
        panelLoginMember.Controls.Add(Label4)
        panelLoginMember.Controls.Add(Label5)
        panelLoginMember.Controls.Add(Label6)
        panelLoginMember.Location = New Point(278, 335)
        panelLoginMember.Name = "panelLoginMember"
        panelLoginMember.Size = New Size(496, 257)
        panelLoginMember.TabIndex = 5
        panelLoginMember.Visible = False
        ' 
        ' txtPasswordMember
        ' 
        txtPasswordMember.Location = New Point(144, 110)
        txtPasswordMember.Name = "txtPasswordMember"
        txtPasswordMember.Size = New Size(228, 27)
        txtPasswordMember.TabIndex = 2
        ' 
        ' txtUsernameMember
        ' 
        txtUsernameMember.Location = New Point(144, 63)
        txtUsernameMember.Name = "txtUsernameMember"
        txtUsernameMember.Size = New Size(228, 27)
        txtUsernameMember.TabIndex = 2
        ' 
        ' btnBackMember
        ' 
        btnBackMember.Location = New Point(200, 213)
        btnBackMember.Name = "btnBackMember"
        btnBackMember.Size = New Size(94, 29)
        btnBackMember.TabIndex = 1
        btnBackMember.Text = "Kembali"
        btnBackMember.UseVisualStyleBackColor = True
        ' 
        ' btnRegistMember
        ' 
        btnRegistMember.Location = New Point(266, 164)
        btnRegistMember.Name = "btnRegistMember"
        btnRegistMember.Size = New Size(94, 29)
        btnRegistMember.TabIndex = 1
        btnRegistMember.Text = "Daftar"
        btnRegistMember.UseVisualStyleBackColor = True
        ' 
        ' btnLoginMember
        ' 
        btnLoginMember.Location = New Point(147, 164)
        btnLoginMember.Name = "btnLoginMember"
        btnLoginMember.Size = New Size(94, 29)
        btnLoginMember.TabIndex = 1
        btnLoginMember.Text = "Masuk"
        btnLoginMember.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(63, 113)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 20)
        Label4.TabIndex = 0
        Label4.Text = "Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.White
        Label5.Location = New Point(63, 66)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 20)
        Label5.TabIndex = 0
        Label5.Text = "Username"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.White
        Label6.Location = New Point(229, 24)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 20)
        Label6.TabIndex = 0
        Label6.Text = "Member"
        ' 
        ' Landing
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(11), CByte(41), CByte(79))
        ClientSize = New Size(1058, 717)
        Controls.Add(panelLoginMember)
        Controls.Add(pictMember)
        Controls.Add(panelLoginAdmin)
        Controls.Add(pictAdmin)
        Controls.Add(landingBg)
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximumSize = New Size(1080, 768)
        MinimumSize = New Size(1080, 768)
        Name = "Landing"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Haven Media"
        CType(landingBg, ComponentModel.ISupportInitialize).EndInit()
        CType(pictAdmin, ComponentModel.ISupportInitialize).EndInit()
        panelLoginAdmin.ResumeLayout(False)
        panelLoginAdmin.PerformLayout()
        CType(pictMember, ComponentModel.ISupportInitialize).EndInit()
        panelLoginMember.ResumeLayout(False)
        panelLoginMember.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents landingBg As PictureBox
    Friend WithEvents pictAdmin As PictureBox
    Friend WithEvents panelLoginAdmin As Panel
    Friend WithEvents txtPasswordAdmin As TextBox
    Friend WithEvents txtUsernameAdmin As TextBox
    Friend WithEvents btnBackAdmin As Button
    Friend WithEvents btnLoginAdmin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pictMember As PictureBox
    Friend WithEvents panelLoginMember As Panel
    Friend WithEvents txtPasswordMember As TextBox
    Friend WithEvents txtUsernameMember As TextBox
    Friend WithEvents btnBackMember As Button
    Friend WithEvents btnRegistMember As Button
    Friend WithEvents btnLoginMember As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
