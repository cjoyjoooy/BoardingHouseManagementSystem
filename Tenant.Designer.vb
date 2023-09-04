<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tenant
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
        panelTenant = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Label2 = New Label()
        panelTenant.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelTenant
        ' 
        panelTenant.AutoSizeMode = AutoSizeMode.GrowAndShrink
        panelTenant.BorderRadius = 20
        panelTenant.Controls.Add(Guna2Panel4)
        panelTenant.Controls.Add(Guna2Panel2)
        panelTenant.Controls.Add(Guna2Panel3)
        panelTenant.Controls.Add(Label2)
        panelTenant.CustomizableEdges = CustomizableEdges7
        panelTenant.Dock = DockStyle.Fill
        panelTenant.FillColor = Color.FromArgb(CByte(232), CByte(232), CByte(231))
        panelTenant.Location = New Point(0, 0)
        panelTenant.Margin = New Padding(0)
        panelTenant.Name = "panelTenant"
        panelTenant.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        panelTenant.Size = New Size(735, 558)
        panelTenant.TabIndex = 0
        ' 
        ' Guna2Panel4
        ' 
        Guna2Panel4.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(248))
        Guna2Panel4.BorderRadius = 20
        Guna2Panel4.BorderThickness = 20
        Guna2Panel4.CustomizableEdges = CustomizableEdges1
        Guna2Panel4.FillColor = Color.White
        Guna2Panel4.Location = New Point(374, 306)
        Guna2Panel4.Name = "Guna2Panel4"
        Guna2Panel4.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel4.Size = New Size(302, 203)
        Guna2Panel4.TabIndex = 11
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(248))
        Guna2Panel2.BorderRadius = 20
        Guna2Panel2.BorderThickness = 20
        Guna2Panel2.CustomizableEdges = CustomizableEdges3
        Guna2Panel2.FillColor = Color.White
        Guna2Panel2.Location = New Point(17, 306)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Panel2.Size = New Size(331, 203)
        Guna2Panel2.TabIndex = 10
        ' 
        ' Guna2Panel3
        ' 
        Guna2Panel3.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(248))
        Guna2Panel3.BorderRadius = 20
        Guna2Panel3.BorderThickness = 20
        Guna2Panel3.CustomizableEdges = CustomizableEdges5
        Guna2Panel3.FillColor = Color.White
        Guna2Panel3.Location = New Point(17, 79)
        Guna2Panel3.Name = "Guna2Panel3"
        Guna2Panel3.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Panel3.Size = New Size(659, 203)
        Guna2Panel3.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label2.Location = New Point(17, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 52)
        Label2.TabIndex = 8
        Label2.Text = "Tenant"
        ' 
        ' Tenant
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(735, 558)
        Controls.Add(panelTenant)
        FormBorderStyle = FormBorderStyle.None
        Name = "Tenant"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.Manual
        Text = "Tenant"
        panelTenant.ResumeLayout(False)
        panelTenant.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelTenant As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
End Class
