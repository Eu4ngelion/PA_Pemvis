<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Menu
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
        components = New ComponentModel.Container()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        TextBox1 = New TextBox()
        Label8 = New Label()
        MenuStrip1 = New MenuStrip()
        MenuToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox3 = New TextBox()
        Label9 = New Label()
        ComboBox1 = New ComboBox()
        RadioButton1 = New RadioButton()
        CheckBox1 = New CheckBox()
        BindingSource1 = New BindingSource(components)
        GroupBox1 = New GroupBox()
        RadioButton2 = New RadioButton()
        GroupBox2 = New GroupBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox8 = New CheckBox()
        Button4 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(60, 366)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(935, 313)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(462, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 28)
        Label1.TabIndex = 1
        Label1.Text = "Menu Admin"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(60, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 2
        Label2.Text = "Id Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(60, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 20)
        Label3.TabIndex = 3
        Label3.Text = "Nama Buku"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(60, 120)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 20)
        Label4.TabIndex = 3
        Label4.Text = "Penulis"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(60, 156)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 20)
        Label5.TabIndex = 3
        Label5.Text = "Harga"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(742, 51)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 20)
        Label6.TabIndex = 3
        Label6.Text = "Deskripsi"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(310, 54)
        Label7.Name = "Label7"
        Label7.Size = New Size(38, 20)
        Label7.TabIndex = 3
        Label7.Text = "Stok"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(670, 332)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 4
        Button1.Text = "Tambah"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(785, 332)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 4
        Button2.Text = "Ubah"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(901, 332)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 4
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(133, 333)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(361, 27)
        TextBox1.TabIndex = 5
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(60, 336)
        Label8.Name = "Label8"
        Label8.Size = New Size(56, 20)
        Label8.TabIndex = 6
        Label8.Text = "Search:"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuToolStripMenuItem, LogoutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1062, 28)
        MenuStrip1.TabIndex = 7
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuToolStripMenuItem
        ' 
        MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        MenuToolStripMenuItem.Padding = New Padding(30, 0, 5, 0)
        MenuToolStripMenuItem.Size = New Size(126, 24)
        MenuToolStripMenuItem.Text = "Kelola Buku"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Padding = New Padding(5, 0, 100, 0)
        LogoutToolStripMenuItem.Size = New Size(165, 24)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(161, 120)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(333, 27)
        TextBox4.TabIndex = 8
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(161, 156)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(333, 27)
        TextBox5.TabIndex = 8
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(374, 50)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(120, 27)
        TextBox6.TabIndex = 8
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(595, 77)
        TextBox7.Multiline = True
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(400, 237)
        TextBox7.TabIndex = 9
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(161, 87)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(333, 27)
        TextBox3.TabIndex = 8
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(60, 208)
        Label9.Name = "Label9"
        Label9.Size = New Size(0, 20)
        Label9.TabIndex = 3
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(161, 48)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(97, 28)
        ComboBox1.TabIndex = 10
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(20, 26)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(58, 24)
        RadioButton1.TabIndex = 11
        RadioButton1.TabStop = True
        RadioButton1.Text = "Fiksi"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(6, 27)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(78, 24)
        CheckBox1.TabIndex = 12
        CheckBox1.Text = "Genre1"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(56, 192)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(180, 96)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jenis Buku"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(20, 56)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(92, 24)
        RadioButton2.TabIndex = 11
        RadioButton2.TabStop = True
        RadioButton2.Text = "Non-Fiksi"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(CheckBox6)
        GroupBox2.Controls.Add(CheckBox8)
        GroupBox2.Controls.Add(CheckBox5)
        GroupBox2.Controls.Add(CheckBox4)
        GroupBox2.Controls.Add(CheckBox3)
        GroupBox2.Controls.Add(CheckBox7)
        GroupBox2.Controls.Add(CheckBox2)
        GroupBox2.Controls.Add(CheckBox1)
        GroupBox2.Location = New Point(264, 192)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(307, 122)
        GroupBox2.TabIndex = 13
        GroupBox2.TabStop = False
        GroupBox2.Text = "Genre"
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(174, 27)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(78, 24)
        CheckBox2.TabIndex = 12
        CheckBox2.Text = "Genre7"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(90, 27)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(78, 24)
        CheckBox3.TabIndex = 12
        CheckBox3.Text = "Genre4"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(6, 57)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(78, 24)
        CheckBox4.TabIndex = 12
        CheckBox4.Text = "Genre2"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(90, 57)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(78, 24)
        CheckBox5.TabIndex = 12
        CheckBox5.Text = "Genre5"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(174, 57)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(78, 24)
        CheckBox6.TabIndex = 12
        CheckBox6.Text = "Genre8"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(6, 86)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(78, 24)
        CheckBox7.TabIndex = 12
        CheckBox7.Text = "Genre3"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(90, 86)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(78, 24)
        CheckBox8.TabIndex = 12
        CheckBox8.Text = "Genre6"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(502, 332)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 4
        Button4.Text = "Cari"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Admin_Menu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1062, 721)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Label8)
        Controls.Add(TextBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label9)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Admin_Menu"
        Text = "Haven Media"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Button4 As Button
End Class
