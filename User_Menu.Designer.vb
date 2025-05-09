<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Menu
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
        btnAdd = New Button()
        DataGridView1 = New DataGridView()
        labelJudul = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        ListBox1 = New ListBox()
        Label3 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label5 = New Label()
        TextBox4 = New TextBox()
        Label2 = New Label()
        PrintDialog1 = New PrintDialog()
        MenuStrip1 = New MenuStrip()
        BackToolStripMenuItem = New ToolStripMenuItem()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(758, 121)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(133, 29)
        btnAdd.TabIndex = 0
        btnAdd.Text = "+ Keranjang"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(31, 198)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(652, 488)
        DataGridView1.TabIndex = 1
        ' 
        ' labelJudul
        ' 
        labelJudul.AutoSize = True
        labelJudul.Location = New Point(482, 9)
        labelJudul.Name = "labelJudul"
        labelJudul.Size = New Size(97, 20)
        labelJudul.TabIndex = 2
        labelJudul.Text = "Haven Media"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(90, 124)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(302, 27)
        TextBox1.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 127)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 5
        Label1.Text = "Search"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(539, 161)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(76, 27)
        TextBox2.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(472, 160)
        Button1.Name = "Button1"
        Button1.Size = New Size(61, 31)
        Button1.TabIndex = 7
        Button1.Text = "-"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(621, 159)
        Button2.Name = "Button2"
        Button2.Size = New Size(62, 29)
        Button2.TabIndex = 7
        Button2.Text = "+"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(897, 121)
        Button3.Name = "Button3"
        Button3.Size = New Size(133, 29)
        Button3.TabIndex = 0
        Button3.Text = "Checkout"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(758, 159)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(272, 524)
        ListBox1.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(550, 138)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 20)
        Label3.TabIndex = 5
        Label3.Text = "Jumlah"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 165)
        Label4.Name = "Label4"
        Label4.Size = New Size(22, 20)
        Label4.TabIndex = 9
        Label4.Text = "Id"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(59, 162)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(136, 27)
        TextBox3.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(201, 165)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 20)
        Label5.TabIndex = 9
        Label5.Text = "Nama"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(256, 161)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(136, 27)
        TextBox4.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(916, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 20)
        Label2.TabIndex = 10
        Label2.Text = "<Cetak Struk>"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {BackToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1062, 28)
        MenuStrip1.TabIndex = 11
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' BackToolStripMenuItem
        ' 
        BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        BackToolStripMenuItem.Size = New Size(54, 24)
        BackToolStripMenuItem.Text = "Back"
        ' 
        ' User_Menu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1062, 721)
        Controls.Add(Label2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(ListBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox1)
        Controls.Add(labelJudul)
        Controls.Add(DataGridView1)
        Controls.Add(Button3)
        Controls.Add(btnAdd)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "User_Menu"
        Text = "Haven Media"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents labelJudul As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
End Class
