<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(User))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        btnDeleteUser = New Guna.UI2.WinForms.Guna2Button()
        btnUserBillForm = New Guna.UI2.WinForms.Guna2Button()
        txtSearchTransaction = New Guna.UI2.WinForms.Guna2TextBox()
        dgvUser = New Guna.UI2.WinForms.Guna2DataGridView()
        btnAddUserForm = New Guna.UI2.WinForms.Guna2Button()
        Guna2Panel1.SuspendLayout()
        CType(dgvUser, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.FromArgb(CByte(232), CByte(232), CByte(231))
        Guna2Panel1.Controls.Add(btnDeleteUser)
        Guna2Panel1.Controls.Add(btnUserBillForm)
        Guna2Panel1.Controls.Add(txtSearchTransaction)
        Guna2Panel1.Controls.Add(dgvUser)
        Guna2Panel1.Controls.Add(btnAddUserForm)
        Guna2Panel1.CustomizableEdges = CustomizableEdges9
        Guna2Panel1.Dock = DockStyle.Fill
        Guna2Panel1.FillColor = Color.FromArgb(CByte(232), CByte(232), CByte(231))
        Guna2Panel1.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Panel1.Size = New Size(833, 685)
        Guna2Panel1.TabIndex = 0
        ' 
        ' btnDeleteUser
        ' 
        btnDeleteUser.BorderRadius = 10
        btnDeleteUser.CustomizableEdges = CustomizableEdges1
        btnDeleteUser.DisabledState.BorderColor = Color.DarkGray
        btnDeleteUser.DisabledState.CustomBorderColor = Color.DarkGray
        btnDeleteUser.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDeleteUser.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnDeleteUser.FillColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        btnDeleteUser.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnDeleteUser.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        btnDeleteUser.Image = CType(resources.GetObject("btnDeleteUser.Image"), Image)
        btnDeleteUser.Location = New Point(771, -1)
        btnDeleteUser.Name = "btnDeleteUser"
        btnDeleteUser.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnDeleteUser.Size = New Size(50, 40)
        btnDeleteUser.TabIndex = 50
        ' 
        ' btnUserBillForm
        ' 
        btnUserBillForm.BorderRadius = 10
        btnUserBillForm.CustomizableEdges = CustomizableEdges3
        btnUserBillForm.DisabledState.BorderColor = Color.DarkGray
        btnUserBillForm.DisabledState.CustomBorderColor = Color.DarkGray
        btnUserBillForm.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnUserBillForm.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnUserBillForm.FillColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        btnUserBillForm.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnUserBillForm.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        btnUserBillForm.Image = CType(resources.GetObject("btnUserBillForm.Image"), Image)
        btnUserBillForm.Location = New Point(714, -1)
        btnUserBillForm.Name = "btnUserBillForm"
        btnUserBillForm.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnUserBillForm.Size = New Size(50, 40)
        btnUserBillForm.TabIndex = 49
        ' 
        ' txtSearchTransaction
        ' 
        txtSearchTransaction.BorderRadius = 10
        txtSearchTransaction.CustomizableEdges = CustomizableEdges5
        txtSearchTransaction.DefaultText = ""
        txtSearchTransaction.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtSearchTransaction.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtSearchTransaction.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtSearchTransaction.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtSearchTransaction.FocusedState.BorderColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        txtSearchTransaction.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtSearchTransaction.HoverState.BorderColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        txtSearchTransaction.IconLeft = CType(resources.GetObject("txtSearchTransaction.IconLeft"), Image)
        txtSearchTransaction.IconLeftOffset = New Point(10, 0)
        txtSearchTransaction.Location = New Point(13, 2)
        txtSearchTransaction.Margin = New Padding(4, 3, 4, 3)
        txtSearchTransaction.Name = "txtSearchTransaction"
        txtSearchTransaction.PasswordChar = ChrW(0)
        txtSearchTransaction.PlaceholderText = ""
        txtSearchTransaction.SelectedText = ""
        txtSearchTransaction.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtSearchTransaction.Size = New Size(404, 35)
        txtSearchTransaction.TabIndex = 45
        ' 
        ' dgvUser
        ' 
        dgvUser.AllowUserToAddRows = False
        dgvUser.AllowUserToDeleteRows = False
        dgvUser.AllowUserToResizeColumns = False
        dgvUser.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(204), CByte(204), CByte(204))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        dgvUser.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        DataGridViewCellStyle2.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvUser.ColumnHeadersHeight = 50
        dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(204), CByte(204), CByte(204))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvUser.DefaultCellStyle = DataGridViewCellStyle3
        dgvUser.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvUser.Location = New Point(12, 43)
        dgvUser.Name = "dgvUser"
        dgvUser.ReadOnly = True
        dgvUser.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.White
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvUser.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvUser.RowHeadersVisible = False
        dgvUser.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        dgvUser.RowTemplate.Height = 34
        dgvUser.Size = New Size(809, 642)
        dgvUser.TabIndex = 44
        dgvUser.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvUser.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvUser.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvUser.ThemeStyle.BackColor = Color.White
        dgvUser.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvUser.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        dgvUser.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvUser.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvUser.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvUser.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvUser.ThemeStyle.HeaderStyle.Height = 50
        dgvUser.ThemeStyle.ReadOnly = True
        dgvUser.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvUser.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvUser.ThemeStyle.RowsStyle.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dgvUser.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvUser.ThemeStyle.RowsStyle.Height = 34
        dgvUser.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvUser.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' btnAddUserForm
        ' 
        btnAddUserForm.BorderRadius = 10
        btnAddUserForm.CustomizableEdges = CustomizableEdges7
        btnAddUserForm.DisabledState.BorderColor = Color.DarkGray
        btnAddUserForm.DisabledState.CustomBorderColor = Color.DarkGray
        btnAddUserForm.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAddUserForm.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAddUserForm.FillColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        btnAddUserForm.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddUserForm.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        btnAddUserForm.Image = CType(resources.GetObject("btnAddUserForm.Image"), Image)
        btnAddUserForm.Location = New Point(657, -1)
        btnAddUserForm.Name = "btnAddUserForm"
        btnAddUserForm.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnAddUserForm.Size = New Size(50, 40)
        btnAddUserForm.TabIndex = 43
        ' 
        ' User
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(833, 685)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "User"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User"
        Guna2Panel1.ResumeLayout(False)
        CType(dgvUser, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnAddUserForm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvUser As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtSearchTransaction As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnDeleteUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUserBillForm As Guna.UI2.WinForms.Guna2Button
End Class
