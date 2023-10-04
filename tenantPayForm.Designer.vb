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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        btnCancel = New Guna.UI2.WinForms.Guna2Button()
        btnPay = New Guna.UI2.WinForms.Guna2Button()
        amoundPaidtxt = New Guna.UI2.WinForms.Guna2TextBox()
        Label4 = New Label()
        lblTenantName = New Label()
        lblTenantID = New Label()
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
        Guna2Panel1.Controls.Add(btnCancel)
        Guna2Panel1.Controls.Add(btnPay)
        Guna2Panel1.Controls.Add(amoundPaidtxt)
        Guna2Panel1.Controls.Add(Label4)
        Guna2Panel1.Controls.Add(lblTenantName)
        Guna2Panel1.Controls.Add(lblTenantID)
        Guna2Panel1.Controls.Add(Label1)
        Guna2Panel1.Controls.Add(Label18)
        Guna2Panel1.CustomizableEdges = CustomizableEdges7
        Guna2Panel1.Dock = DockStyle.Fill
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Margin = New Padding(3, 2, 3, 2)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Panel1.Size = New Size(336, 224)
        Guna2Panel1.TabIndex = 0
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.White
        btnCancel.BorderColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        btnCancel.BorderRadius = 10
        btnCancel.BorderThickness = 2
        btnCancel.CustomizableEdges = CustomizableEdges1
        btnCancel.DisabledState.BorderColor = Color.DarkGray
        btnCancel.DisabledState.CustomBorderColor = Color.DarkGray
        btnCancel.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCancel.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCancel.FillColor = Color.White
        btnCancel.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancel.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        btnCancel.Location = New Point(24, 172)
        btnCancel.Margin = New Padding(3, 2, 3, 2)
        btnCancel.Name = "btnCancel"
        btnCancel.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnCancel.Size = New Size(133, 27)
        btnCancel.TabIndex = 2
        btnCancel.Text = "Cancel"' 
        ' btnPay
        ' 
        btnPay.BackColor = Color.White
        btnPay.BorderColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        btnPay.BorderRadius = 10
        btnPay.BorderThickness = 2
        btnPay.CustomizableEdges = CustomizableEdges3
        btnPay.DisabledState.BorderColor = Color.DarkGray
        btnPay.DisabledState.CustomBorderColor = Color.DarkGray
        btnPay.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnPay.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnPay.FillColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        btnPay.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnPay.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        btnPay.Location = New Point(179, 172)
        btnPay.Margin = New Padding(3, 2, 3, 2)
        btnPay.Name = "btnPay"
        btnPay.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnPay.Size = New Size(133, 27)
        btnPay.TabIndex = 3
        btnPay.Text = "Pay"' 
        ' amoundPaidtxt
        ' 
        amoundPaidtxt.BorderColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        amoundPaidtxt.BorderRadius = 10
        amoundPaidtxt.CustomizableEdges = CustomizableEdges5
        amoundPaidtxt.DefaultText = ""
        amoundPaidtxt.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        amoundPaidtxt.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        amoundPaidtxt.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        amoundPaidtxt.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        amoundPaidtxt.FocusedState.BorderColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        amoundPaidtxt.FocusedState.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        amoundPaidtxt.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        amoundPaidtxt.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        amoundPaidtxt.HoverState.BorderColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        amoundPaidtxt.Location = New Point(24, 121)
        amoundPaidtxt.Margin = New Padding(4, 3, 4, 3)
        amoundPaidtxt.Name = "amoundPaidtxt"
        amoundPaidtxt.PasswordChar = ChrW(0)
        amoundPaidtxt.PlaceholderText = ""
        amoundPaidtxt.SelectedText = ""
        amoundPaidtxt.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        amoundPaidtxt.Size = New Size(289, 26)
        amoundPaidtxt.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label4.Location = New Point(24, 100)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 18)
        Label4.TabIndex = 72
        Label4.Text = "Amount"' 
        ' lblTenantName
        ' 
        lblTenantName.AutoSize = True
        lblTenantName.BackColor = Color.Transparent
        lblTenantName.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblTenantName.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        lblTenantName.Location = New Point(144, 67)
        lblTenantName.Name = "lblTenantName"
        lblTenantName.Size = New Size(65, 22)
        lblTenantName.TabIndex = 71
        lblTenantName.Text = "Lex Lao"' 
        ' lblTenantID
        ' 
        lblTenantID.AutoSize = True
        lblTenantID.BackColor = Color.Transparent
        lblTenantID.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblTenantID.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        lblTenantID.Location = New Point(144, 22)
        lblTenantID.Name = "lblTenantID"
        lblTenantID.Size = New Size(80, 22)
        lblTenantID.TabIndex = 70
        lblTenantID.Text = "Tenant123"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label1.Location = New Point(24, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 18)
        Label1.TabIndex = 69
        Label1.Text = "Tenant ID:"' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label18.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label18.Location = New Point(24, 68)
        Label18.Name = "Label18"
        Label18.Size = New Size(99, 18)
        Label18.TabIndex = 68
        Label18.Text = "First Name:"' 
        ' tenantPayForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(336, 224)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "tenantPayForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "tenantPayForm"
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents amoundPaidtxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTenantName As Label
    Friend WithEvents lblTenantID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label18 As Label
End Class
