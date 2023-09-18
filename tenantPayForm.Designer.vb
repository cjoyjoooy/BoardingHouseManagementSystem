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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Label13 = New Label()
        btnCancel = New Guna.UI2.WinForms.Guna2Button()
        btnPay = New Guna.UI2.WinForms.Guna2Button()
        txtFname = New Guna.UI2.WinForms.Guna2TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label18 = New Label()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.White
        Guna2Panel1.BorderColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Guna2Panel1.BorderThickness = 2
        Guna2Panel1.Controls.Add(Guna2DateTimePicker1)
        Guna2Panel1.Controls.Add(Label13)
        Guna2Panel1.Controls.Add(btnCancel)
        Guna2Panel1.Controls.Add(btnPay)
        Guna2Panel1.Controls.Add(txtFname)
        Guna2Panel1.Controls.Add(Label4)
        Guna2Panel1.Controls.Add(Label3)
        Guna2Panel1.Controls.Add(Label2)
        Guna2Panel1.Controls.Add(Label1)
        Guna2Panel1.Controls.Add(Label18)
        Guna2Panel1.CustomizableEdges = CustomizableEdges9
        Guna2Panel1.Dock = DockStyle.Fill
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Panel1.Size = New Size(384, 380)
        Guna2Panel1.TabIndex = 0
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
        Guna2DateTimePicker1.Location = New Point(27, 243)
        Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2DateTimePicker1.Size = New Size(330, 39)
        Guna2DateTimePicker1.TabIndex = 77
        Guna2DateTimePicker1.Value = New Date(2023, 9, 12, 15, 5, 18, 211)
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label13.Location = New Point(27, 217)
        Label13.Name = "Label13"
        Label13.Size = New Size(104, 23)
        Label13.TabIndex = 76
        Label13.Text = "Date Paid"
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
        btnCancel.Location = New Point(27, 314)
        btnCancel.Name = "btnCancel"
        btnCancel.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnCancel.Size = New Size(152, 36)
        btnCancel.TabIndex = 75
        btnCancel.Text = "Cancel"
        ' 
        ' btnPay
        ' 
        btnPay.BackColor = Color.White
        btnPay.BorderColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        btnPay.BorderRadius = 10
        btnPay.BorderThickness = 2
        btnPay.CustomizableEdges = CustomizableEdges5
        btnPay.DisabledState.BorderColor = Color.DarkGray
        btnPay.DisabledState.CustomBorderColor = Color.DarkGray
        btnPay.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnPay.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnPay.FillColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        btnPay.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnPay.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        btnPay.Location = New Point(205, 314)
        btnPay.Name = "btnPay"
        btnPay.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnPay.Size = New Size(152, 36)
        btnPay.TabIndex = 74
        btnPay.Text = "Pay"
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
        txtFname.Location = New Point(27, 161)
        txtFname.Margin = New Padding(4, 4, 4, 4)
        txtFname.Name = "txtFname"
        txtFname.PasswordChar = ChrW(0)
        txtFname.PlaceholderText = ""
        txtFname.SelectedText = ""
        txtFname.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtFname.Size = New Size(330, 34)
        txtFname.TabIndex = 73
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label4.Location = New Point(27, 134)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 23)
        Label4.TabIndex = 72
        Label4.Text = "Amount"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label3.Location = New Point(165, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 26)
        Label3.TabIndex = 71
        Label3.Text = "Lex Lao"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label2.Location = New Point(165, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 26)
        Label2.TabIndex = 70
        Label2.Text = "Tenant123"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label1.Location = New Point(27, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 23)
        Label1.TabIndex = 69
        Label1.Text = "Tenant ID:"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label18.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label18.Location = New Point(27, 90)
        Label18.Name = "Label18"
        Label18.Size = New Size(122, 23)
        Label18.TabIndex = 68
        Label18.Text = "First Name:"
        ' 
        ' tenantPayForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(384, 380)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "tenantPayForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "tenantPayForm"
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtFname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label18 As Label
End Class
