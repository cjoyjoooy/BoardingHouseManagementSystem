<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tenantPayForm
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        Label18 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtFname = New Guna.UI2.WinForms.Guna2TextBox()
        btnCancel = New Guna.UI2.WinForms.Guna2Button()
        btnAddTenant = New Guna.UI2.WinForms.Guna2Button()
        Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Label13 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Guna2DateTimePicker1)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(btnCancel)
        Panel1.Controls.Add(btnAddTenant)
        Panel1.Controls.Add(txtFname)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label18)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(384, 380)
        Panel1.TabIndex = 0
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label18.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label18.Location = New Point(20, 85)
        Label18.Name = "Label18"
        Label18.Size = New Size(122, 23)
        Label18.TabIndex = 53
        Label18.Text = "First Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label1.Location = New Point(20, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 23)
        Label1.TabIndex = 56
        Label1.Text = "Tenant ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label2.Location = New Point(158, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 26)
        Label2.TabIndex = 57
        Label2.Text = "Tenant123"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label3.Location = New Point(158, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 26)
        Label3.TabIndex = 58
        Label3.Text = "Lex Lao"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label4.Location = New Point(20, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 23)
        Label4.TabIndex = 59
        Label4.Text = "Amount"
        ' 
        ' txtFname
        ' 
        txtFname.BorderColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        txtFname.BorderRadius = 10
        txtFname.CustomizableEdges = CustomizableEdges7
        txtFname.DefaultText = ""
        txtFname.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtFname.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtFname.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtFname.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtFname.FocusedState.BorderColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        txtFname.FocusedState.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        txtFname.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtFname.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        txtFname.HoverState.BorderColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        txtFname.Location = New Point(20, 156)
        txtFname.Margin = New Padding(4, 4, 4, 4)
        txtFname.Name = "txtFname"
        txtFname.PasswordChar = ChrW(0)
        txtFname.PlaceholderText = ""
        txtFname.SelectedText = ""
        txtFname.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtFname.Size = New Size(330, 34)
        txtFname.TabIndex = 60
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.White
        btnCancel.BorderColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        btnCancel.BorderRadius = 10
        btnCancel.BorderThickness = 2
        btnCancel.CustomizableEdges = CustomizableEdges3
        btnCancel.DisabledState.BorderColor = Color.DarkGray
        btnCancel.DisabledState.CustomBorderColor = Color.DarkGray
        btnCancel.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCancel.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCancel.FillColor = Color.White
        btnCancel.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancel.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        btnCancel.Location = New Point(20, 309)
        btnCancel.Name = "btnCancel"
        btnCancel.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnCancel.Size = New Size(152, 36)
        btnCancel.TabIndex = 62
        btnCancel.Text = "Cancel"
        ' 
        ' btnAddTenant
        ' 
        btnAddTenant.BackColor = Color.White
        btnAddTenant.BorderColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        btnAddTenant.BorderRadius = 10
        btnAddTenant.BorderThickness = 2
        btnAddTenant.CustomizableEdges = CustomizableEdges5
        btnAddTenant.DisabledState.BorderColor = Color.DarkGray
        btnAddTenant.DisabledState.CustomBorderColor = Color.DarkGray
        btnAddTenant.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAddTenant.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAddTenant.FillColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        btnAddTenant.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddTenant.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        btnAddTenant.Location = New Point(198, 309)
        btnAddTenant.Name = "btnAddTenant"
        btnAddTenant.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnAddTenant.Size = New Size(152, 36)
        btnAddTenant.TabIndex = 61
        btnAddTenant.Text = "Pay"
        ' 
        ' Guna2DateTimePicker1
        ' 
        Guna2DateTimePicker1.BackColor = Color.White
        Guna2DateTimePicker1.BorderRadius = 10
        Guna2DateTimePicker1.Checked = True
        Guna2DateTimePicker1.CustomizableEdges = CustomizableEdges1
        Guna2DateTimePicker1.FillColor = Color.White
        Guna2DateTimePicker1.FocusedColor = Color.White
        Guna2DateTimePicker1.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2DateTimePicker1.Format = DateTimePickerFormat.Short
        Guna2DateTimePicker1.HoverState.BorderColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        Guna2DateTimePicker1.Location = New Point(20, 238)
        Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2DateTimePicker1.Size = New Size(330, 39)
        Guna2DateTimePicker1.TabIndex = 67
        Guna2DateTimePicker1.Value = New Date(2023, 9, 12, 15, 5, 18, 211)
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label13.Location = New Point(20, 212)
        Label13.Name = "Label13"
        Label13.Size = New Size(104, 23)
        Label13.TabIndex = 66
        Label13.Text = "Date Paid"
        ' 
        ' tenantPayForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(384, 380)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "tenantPayForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "tenantPayForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddTenant As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label13 As Label
End Class
