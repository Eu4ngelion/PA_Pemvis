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
        pictBelanja = New PictureBox()
        pictAdmin = New PictureBox()
        panelLogin = New Panel()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        btnBack = New Button()
        btnLogin = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        CType(landingBg, ComponentModel.ISupportInitialize).BeginInit()
        CType(pictBelanja, ComponentModel.ISupportInitialize).BeginInit()
        CType(pictAdmin, ComponentModel.ISupportInitialize).BeginInit()
        panelLogin.SuspendLayout()
        SuspendLayout()
        ' 
        ' landingBg
        ' 
        landingBg.Image = My.Resources.Resources.Login_Bg1
        landingBg.Location = New Point(-2, -3)
        landingBg.Name = "landingBg"
        landingBg.Size = New Size(1060, 746)
        landingBg.SizeMode = PictureBoxSizeMode.Zoom
        landingBg.TabIndex = 1
        landingBg.TabStop = False
        ' 
        ' pictBelanja
        ' 
        pictBelanja.Image = My.Resources.Resources.icon_belanja_light
        pictBelanja.Location = New Point(406, 396)
        pictBelanja.Name = "pictBelanja"
        pictBelanja.Size = New Size(105, 154)
        pictBelanja.SizeMode = PictureBoxSizeMode.Zoom
        pictBelanja.TabIndex = 2
        pictBelanja.TabStop = False
        ' 
        ' pictAdmin
        ' 
        pictAdmin.Image = My.Resources.Resources.icon_admin_light
        pictAdmin.Location = New Point(566, 411)
        pictAdmin.Name = "pictAdmin"
        pictAdmin.Size = New Size(88, 139)
        pictAdmin.SizeMode = PictureBoxSizeMode.Zoom
        pictAdmin.TabIndex = 3
        pictAdmin.TabStop = False
        ' 
        ' panelLogin
        ' 
        panelLogin.Controls.Add(txtPassword)
        panelLogin.Controls.Add(txtUsername)
        panelLogin.Controls.Add(btnBack)
        panelLogin.Controls.Add(btnLogin)
        panelLogin.Controls.Add(Label3)
        panelLogin.Controls.Add(Label2)
        panelLogin.Controls.Add(Label1)
        panelLogin.Location = New Point(284, 318)
        panelLogin.Name = "panelLogin"
        panelLogin.Size = New Size(496, 257)
        panelLogin.TabIndex = 4
        panelLogin.Visible = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(161, 110)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(228, 27)
        txtPassword.TabIndex = 2
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(161, 63)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(228, 27)
        txtUsername.TabIndex = 2
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(243, 164)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 29)
        btnBack.TabIndex = 1
        btnBack.Text = "Kembali"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(133, 164)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 1
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(80, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 0
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(80, 66)
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
        ' Landing
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(11), CByte(41), CByte(79))
        ClientSize = New Size(1058, 717)
        Controls.Add(panelLogin)
        Controls.Add(pictAdmin)
        Controls.Add(pictBelanja)
        Controls.Add(landingBg)
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximumSize = New Size(1080, 768)
        MinimumSize = New Size(1080, 768)
        Name = "Landing"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Haven Media"
        CType(landingBg, ComponentModel.ISupportInitialize).EndInit()
        CType(pictBelanja, ComponentModel.ISupportInitialize).EndInit()
        CType(pictAdmin, ComponentModel.ISupportInitialize).EndInit()
        panelLogin.ResumeLayout(False)
        panelLogin.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents landingBg As PictureBox
    Friend WithEvents pictBelanja As PictureBox
    Friend WithEvents pictAdmin As PictureBox
    Friend WithEvents panelLogin As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
