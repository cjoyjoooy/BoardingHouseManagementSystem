﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tenantArchive
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(tenantArchive))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        btnBack = New Guna.UI2.WinForms.Guna2Button()
        txtTenantSearch = New Guna.UI2.WinForms.Guna2TextBox()
        dgvArchiveTenant = New Guna.UI2.WinForms.Guna2DataGridView()
        btnTenantRestore = New Guna.UI2.WinForms.Guna2Button()
        Guna2Panel1.SuspendLayout()
        CType(dgvArchiveTenant, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.Controls.Add(btnTenantRestore)
        Guna2Panel1.Controls.Add(btnBack)
        Guna2Panel1.Controls.Add(txtTenantSearch)
        Guna2Panel1.Controls.Add(dgvArchiveTenant)
        Guna2Panel1.CustomizableEdges = CustomizableEdges7
        Guna2Panel1.Dock = DockStyle.Fill
        Guna2Panel1.FillColor = Color.FromArgb(CByte(232), CByte(232), CByte(231))
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Panel1.Size = New Size(833, 685)
        Guna2Panel1.TabIndex = 0
        ' 
        ' btnBack
        ' 
        btnBack.BorderRadius = 10
        btnBack.CustomizableEdges = CustomizableEdges3
        btnBack.DisabledState.BorderColor = Color.DarkGray
        btnBack.DisabledState.CustomBorderColor = Color.DarkGray
        btnBack.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnBack.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnBack.FillColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        btnBack.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnBack.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        btnBack.Image = CType(resources.GetObject("btnBack.Image"), Image)
        btnBack.ImageSize = New Size(25, 30)
        btnBack.Location = New Point(690, 4)
        btnBack.Name = "btnBack"
        btnBack.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnBack.Size = New Size(130, 35)
        btnBack.TabIndex = 17
        btnBack.Text = "Back"
        ' 
        ' txtTenantSearch
        ' 
        txtTenantSearch.BorderRadius = 10
        txtTenantSearch.CustomizableEdges = CustomizableEdges5
        txtTenantSearch.DefaultText = ""
        txtTenantSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtTenantSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtTenantSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtTenantSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtTenantSearch.FocusedState.BorderColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        txtTenantSearch.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtTenantSearch.HoverState.BorderColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        txtTenantSearch.IconLeft = CType(resources.GetObject("txtTenantSearch.IconLeft"), Image)
        txtTenantSearch.IconLeftOffset = New Point(10, 0)
        txtTenantSearch.Location = New Point(11, 3)
        txtTenantSearch.Margin = New Padding(5, 3, 5, 3)
        txtTenantSearch.Name = "txtTenantSearch"
        txtTenantSearch.PasswordChar = ChrW(0)
        txtTenantSearch.PlaceholderText = ""
        txtTenantSearch.SelectedText = ""
        txtTenantSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtTenantSearch.Size = New Size(383, 35)
        txtTenantSearch.TabIndex = 14
        ' 
        ' dgvArchiveTenant
        ' 
        dgvArchiveTenant.AllowUserToAddRows = False
        dgvArchiveTenant.AllowUserToDeleteRows = False
        dgvArchiveTenant.AllowUserToResizeColumns = False
        dgvArchiveTenant.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(204), CByte(204), CByte(204))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        dgvArchiveTenant.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        DataGridViewCellStyle2.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvArchiveTenant.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvArchiveTenant.ColumnHeadersHeight = 50
        dgvArchiveTenant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(204), CByte(204), CByte(204))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvArchiveTenant.DefaultCellStyle = DataGridViewCellStyle3
        dgvArchiveTenant.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvArchiveTenant.Location = New Point(11, 45)
        dgvArchiveTenant.Name = "dgvArchiveTenant"
        dgvArchiveTenant.ReadOnly = True
        dgvArchiveTenant.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.White
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvArchiveTenant.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvArchiveTenant.RowHeadersVisible = False
        dgvArchiveTenant.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        dgvArchiveTenant.RowTemplate.Height = 34
        dgvArchiveTenant.Size = New Size(809, 627)
        dgvArchiveTenant.TabIndex = 13
        dgvArchiveTenant.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvArchiveTenant.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvArchiveTenant.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvArchiveTenant.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvArchiveTenant.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvArchiveTenant.ThemeStyle.BackColor = Color.White
        dgvArchiveTenant.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvArchiveTenant.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        dgvArchiveTenant.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvArchiveTenant.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvArchiveTenant.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvArchiveTenant.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvArchiveTenant.ThemeStyle.HeaderStyle.Height = 50
        dgvArchiveTenant.ThemeStyle.ReadOnly = True
        dgvArchiveTenant.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvArchiveTenant.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvArchiveTenant.ThemeStyle.RowsStyle.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dgvArchiveTenant.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvArchiveTenant.ThemeStyle.RowsStyle.Height = 34
        dgvArchiveTenant.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvArchiveTenant.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' btnTenantRestore
        ' 
        btnTenantRestore.BorderRadius = 10
        btnTenantRestore.CustomizableEdges = CustomizableEdges1
        btnTenantRestore.DisabledState.BorderColor = Color.DarkGray
        btnTenantRestore.DisabledState.CustomBorderColor = Color.DarkGray
        btnTenantRestore.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnTenantRestore.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnTenantRestore.FillColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        btnTenantRestore.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnTenantRestore.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        btnTenantRestore.Image = CType(resources.GetObject("btnTenantRestore.Image"), Image)
        btnTenantRestore.Location = New Point(634, 3)
        btnTenantRestore.Name = "btnTenantRestore"
        btnTenantRestore.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnTenantRestore.Size = New Size(50, 35)
        btnTenantRestore.TabIndex = 48
        ' 
        ' tenantArchive
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(833, 685)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "tenantArchive"
        StartPosition = FormStartPosition.CenterScreen
        Text = "tenantArchive"
        Guna2Panel1.ResumeLayout(False)
        CType(dgvArchiveTenant, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgvArchiveTenant As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtTenantSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTenantRestore As Guna.UI2.WinForms.Guna2Button
End Class
