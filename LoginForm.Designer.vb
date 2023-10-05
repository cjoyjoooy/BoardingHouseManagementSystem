<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges27 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges28 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges23 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges24 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges25 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges26 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Usernametxt = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        btnClose = New FontAwesome.Sharp.IconButton()
        Label2 = New Label()
        btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Label1 = New Label()
        Passwordtxt = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel1.SuspendLayout()
        Guna2Panel2.SuspendLayout()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Usernametxt
        ' 
        Usernametxt.BackColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        Usernametxt.BorderColor = Color.Transparent
        Usernametxt.BorderRadius = 10
        Usernametxt.CustomizableEdges = CustomizableEdges15
        Usernametxt.DefaultText = ""
        Usernametxt.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Usernametxt.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Usernametxt.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Usernametxt.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Usernametxt.FocusedState.BorderColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Usernametxt.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Usernametxt.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Usernametxt.HoverState.BorderColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Usernametxt.IconLeft = CType(resources.GetObject("Usernametxt.IconLeft"), Image)
        Usernametxt.IconLeftOffset = New Point(5, 0)
        Usernametxt.IconLeftSize = New Size(24, 24)
        Usernametxt.Location = New Point(437, 127)
        Usernametxt.Margin = New Padding(4, 3, 4, 3)
        Usernametxt.Name = "Usernametxt"
        Usernametxt.Padding = New Padding(44, 0, 9, 0)
        Usernametxt.PasswordChar = ChrW(0)
        Usernametxt.PlaceholderForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Usernametxt.PlaceholderText = "Username"
        Usernametxt.SelectedText = ""
        Usernametxt.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        Usernametxt.Size = New Size(248, 34)
        Usernametxt.TabIndex = 1
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.White
        Guna2Panel1.Controls.Add(btnClose)
        Guna2Panel1.Controls.Add(Label2)
        Guna2Panel1.Controls.Add(btnLogin)
        Guna2Panel1.Controls.Add(Label1)
        Guna2Panel1.Controls.Add(Passwordtxt)
        Guna2Panel1.Controls.Add(Usernametxt)
        Guna2Panel1.Controls.Add(Guna2Panel2)
        Guna2Panel1.Controls.Add(Guna2Panel3)
        Guna2Panel1.CustomizableEdges = CustomizableEdges27
        Guna2Panel1.Dock = DockStyle.Fill
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Margin = New Padding(3, 2, 3, 2)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges28
        Guna2Panel1.Size = New Size(717, 334)
        Guna2Panel1.TabIndex = 1
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Transparent
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark
        btnClose.IconColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnClose.IconSize = 32
        btnClose.Location = New Point(0, 1)
        btnClose.Margin = New Padding(3, 2, 3, 2)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(32, 24)
        btnClose.TabIndex = 11
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        Label2.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label2.Location = New Point(438, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 16)
        Label2.TabIndex = 12
        Label2.Text = "Log in to continue"' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        btnLogin.BorderRadius = 10
        btnLogin.CustomizableEdges = CustomizableEdges17
        btnLogin.DisabledState.BorderColor = Color.DarkGray
        btnLogin.DisabledState.CustomBorderColor = Color.DarkGray
        btnLogin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnLogin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnLogin.FillColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        btnLogin.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogin.ForeColor = Color.White
        btnLogin.HoverState.BorderColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        btnLogin.Location = New Point(437, 226)
        btnLogin.Margin = New Padding(3, 2, 3, 2)
        btnLogin.Name = "btnLogin"
        btnLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        btnLogin.Size = New Size(248, 34)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        Label1.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label1.Location = New Point(432, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 37)
        Label1.TabIndex = 9
        Label1.Text = "Welcome"' 
        ' Passwordtxt
        ' 
        Passwordtxt.BackColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        Passwordtxt.BorderColor = Color.Transparent
        Passwordtxt.BorderRadius = 10
        Passwordtxt.CustomizableEdges = CustomizableEdges19
        Passwordtxt.DefaultText = ""
        Passwordtxt.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Passwordtxt.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Passwordtxt.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Passwordtxt.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Passwordtxt.FocusedState.BorderColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        Passwordtxt.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Passwordtxt.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Passwordtxt.HoverState.BorderColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        Passwordtxt.IconLeft = CType(resources.GetObject("Passwordtxt.IconLeft"), Image)
        Passwordtxt.IconLeftOffset = New Point(5, 0)
        Passwordtxt.IconLeftSize = New Size(24, 24)
        Passwordtxt.Location = New Point(437, 171)
        Passwordtxt.Margin = New Padding(4, 3, 4, 3)
        Passwordtxt.Name = "Passwordtxt"
        Passwordtxt.Padding = New Padding(9, 0, 9, 0)
        Passwordtxt.PasswordChar = "●"c
        Passwordtxt.PlaceholderForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Passwordtxt.PlaceholderText = "Password"
        Passwordtxt.SelectedText = ""
        Passwordtxt.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        Passwordtxt.Size = New Size(248, 34)
        Passwordtxt.TabIndex = 2
        Passwordtxt.UseSystemPasswordChar = True
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BackColor = Color.White
        Guna2Panel2.Controls.Add(Guna2PictureBox1)
        Guna2Panel2.CustomizableEdges = CustomizableEdges23
        Guna2Panel2.Dock = DockStyle.Left
        Guna2Panel2.Location = New Point(0, 0)
        Guna2Panel2.Margin = New Padding(3, 2, 3, 2)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges24
        Guna2Panel2.Size = New Size(397, 334)
        Guna2Panel2.TabIndex = 0
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.BackColor = Color.Transparent
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges21
        Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), Image)
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(-3, 9)
        Guna2PictureBox1.Margin = New Padding(3, 2, 3, 2)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        Guna2PictureBox1.Size = New Size(400, 320)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Guna2PictureBox1.TabIndex = 0
        Guna2PictureBox1.TabStop = False
        Guna2PictureBox1.UseTransparentBackground = True
        ' 
        ' Guna2Panel3
        ' 
        Guna2Panel3.BackColor = Color.White
        Guna2Panel3.CustomizableEdges = CustomizableEdges25
        Guna2Panel3.Dock = DockStyle.Right
        Guna2Panel3.FillColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        Guna2Panel3.Location = New Point(396, 0)
        Guna2Panel3.Margin = New Padding(3, 2, 3, 2)
        Guna2Panel3.Name = "Guna2Panel3"
        Guna2Panel3.ShadowDecoration.CustomizableEdges = CustomizableEdges26
        Guna2Panel3.Size = New Size(321, 334)
        Guna2Panel3.TabIndex = 13
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(717, 334)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        Guna2Panel2.ResumeLayout(False)
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Usernametxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Passwordtxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
End Class
