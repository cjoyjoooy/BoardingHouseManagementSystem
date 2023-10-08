<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tenantArchiveRestoreForm
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
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        lbltenantName = New Label()
        Label18 = New Label()
        btnCancel = New Guna.UI2.WinForms.Guna2Button()
        btnRestoreTenant = New Guna.UI2.WinForms.Guna2Button()
        cmbRestoreRoom = New Guna.UI2.WinForms.Guna2ComboBox()
        Label11 = New Label()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BorderColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Guna2Panel1.BorderThickness = 2
        Guna2Panel1.Controls.Add(lbltenantName)
        Guna2Panel1.Controls.Add(Label18)
        Guna2Panel1.Controls.Add(btnCancel)
        Guna2Panel1.Controls.Add(btnRestoreTenant)
        Guna2Panel1.Controls.Add(cmbRestoreRoom)
        Guna2Panel1.Controls.Add(Label11)
        Guna2Panel1.CustomizableEdges = CustomizableEdges15
        Guna2Panel1.Dock = DockStyle.Fill
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        Guna2Panel1.Size = New Size(419, 243)
        Guna2Panel1.TabIndex = 0
        ' 
        ' lbltenantName
        ' 
        lbltenantName.AutoSize = True
        lbltenantName.BackColor = Color.Transparent
        lbltenantName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbltenantName.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        lbltenantName.Location = New Point(176, 30)
        lbltenantName.Name = "lbltenantName"
        lbltenantName.Size = New Size(26, 25)
        lbltenantName.TabIndex = 70
        lbltenantName.Text = "--"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label18.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label18.Location = New Point(19, 30)
        Label18.Name = "Label18"
        Label18.Size = New Size(137, 25)
        Label18.TabIndex = 56
        Label18.Text = "Tenant Name:"
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.White
        btnCancel.BorderColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        btnCancel.BorderRadius = 10
        btnCancel.BorderThickness = 2
        btnCancel.CustomizableEdges = CustomizableEdges9
        btnCancel.DisabledState.BorderColor = Color.DarkGray
        btnCancel.DisabledState.CustomBorderColor = Color.DarkGray
        btnCancel.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCancel.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCancel.FillColor = Color.White
        btnCancel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancel.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        btnCancel.Location = New Point(77, 176)
        btnCancel.Name = "btnCancel"
        btnCancel.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnCancel.Size = New Size(152, 36)
        btnCancel.TabIndex = 54
        btnCancel.Text = "Cancel"
        ' 
        ' btnRestoreTenant
        ' 
        btnRestoreTenant.BackColor = Color.White
        btnRestoreTenant.BorderColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        btnRestoreTenant.BorderRadius = 10
        btnRestoreTenant.BorderThickness = 2
        btnRestoreTenant.CustomizableEdges = CustomizableEdges11
        btnRestoreTenant.DisabledState.BorderColor = Color.DarkGray
        btnRestoreTenant.DisabledState.CustomBorderColor = Color.DarkGray
        btnRestoreTenant.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnRestoreTenant.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnRestoreTenant.FillColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        btnRestoreTenant.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnRestoreTenant.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        btnRestoreTenant.Location = New Point(255, 176)
        btnRestoreTenant.Name = "btnRestoreTenant"
        btnRestoreTenant.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btnRestoreTenant.Size = New Size(152, 36)
        btnRestoreTenant.TabIndex = 55
        btnRestoreTenant.Text = "Restore"
        ' 
        ' cmbRestoreRoom
        ' 
        cmbRestoreRoom.BackColor = Color.Transparent
        cmbRestoreRoom.BorderColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        cmbRestoreRoom.BorderRadius = 10
        cmbRestoreRoom.CustomizableEdges = CustomizableEdges13
        cmbRestoreRoom.DrawMode = DrawMode.OwnerDrawFixed
        cmbRestoreRoom.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRestoreRoom.FocusedColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        cmbRestoreRoom.FocusedState.BorderColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        cmbRestoreRoom.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmbRestoreRoom.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        cmbRestoreRoom.HoverState.BorderColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        cmbRestoreRoom.ItemHeight = 30
        cmbRestoreRoom.Location = New Point(14, 113)
        cmbRestoreRoom.Name = "cmbRestoreRoom"
        cmbRestoreRoom.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        cmbRestoreRoom.Size = New Size(393, 36)
        cmbRestoreRoom.TabIndex = 52
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label11.Location = New Point(19, 87)
        Label11.Name = "Label11"
        Label11.Size = New Size(63, 25)
        Label11.TabIndex = 53
        Label11.Text = "Room"
        ' 
        ' tenantArchiveRestoreForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(419, 243)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "tenantArchiveRestoreForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "tenantArchiveRestoreForm"
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cmbRestoreRoom As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRestoreTenant As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label18 As Label
    Friend WithEvents lbltenantName As Label
End Class
