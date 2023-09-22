<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Earnings
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Earnings))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        txtSearchTransaction = New Guna.UI2.WinForms.Guna2TextBox()
        dgvEarnings = New Guna.UI2.WinForms.Guna2DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Label2 = New Label()
        Guna2Panel1.SuspendLayout()
        CType(dgvEarnings, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.FromArgb(CByte(232), CByte(232), CByte(231))
        Guna2Panel1.Controls.Add(txtSearchTransaction)
        Guna2Panel1.Controls.Add(dgvEarnings)
        Guna2Panel1.Controls.Add(Label2)
        Guna2Panel1.CustomizableEdges = CustomizableEdges3
        Guna2Panel1.Dock = DockStyle.Fill
        Guna2Panel1.FillColor = Color.FromArgb(CByte(232), CByte(232), CByte(231))
        Guna2Panel1.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Panel1.Size = New Size(833, 685)
        Guna2Panel1.TabIndex = 0
        ' 
        ' txtSearchTransaction
        ' 
        txtSearchTransaction.BorderRadius = 10
        txtSearchTransaction.CustomizableEdges = CustomizableEdges1
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
        txtSearchTransaction.Location = New Point(416, 0)
        txtSearchTransaction.Margin = New Padding(4, 3, 4, 3)
        txtSearchTransaction.Name = "txtSearchTransaction"
        txtSearchTransaction.PasswordChar = ChrW(0)
        txtSearchTransaction.PlaceholderText = ""
        txtSearchTransaction.SelectedText = ""
        txtSearchTransaction.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtSearchTransaction.Size = New Size(404, 35)
        txtSearchTransaction.TabIndex = 15
        ' 
        ' dgvEarnings
        ' 
        dgvEarnings.AllowUserToAddRows = False
        dgvEarnings.AllowUserToDeleteRows = False
        dgvEarnings.AllowUserToResizeColumns = False
        dgvEarnings.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(204), CByte(204), CByte(204))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        dgvEarnings.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        DataGridViewCellStyle2.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvEarnings.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvEarnings.ColumnHeadersHeight = 50
        dgvEarnings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvEarnings.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(204), CByte(204), CByte(204))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvEarnings.DefaultCellStyle = DataGridViewCellStyle3
        dgvEarnings.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvEarnings.Location = New Point(12, 40)
        dgvEarnings.Name = "dgvEarnings"
        dgvEarnings.ReadOnly = True
        dgvEarnings.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.White
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvEarnings.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvEarnings.RowHeadersVisible = False
        dgvEarnings.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        dgvEarnings.RowTemplate.Height = 34
        dgvEarnings.Size = New Size(809, 642)
        dgvEarnings.TabIndex = 13
        dgvEarnings.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvEarnings.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvEarnings.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvEarnings.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvEarnings.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvEarnings.ThemeStyle.BackColor = Color.White
        dgvEarnings.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvEarnings.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        dgvEarnings.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvEarnings.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvEarnings.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvEarnings.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvEarnings.ThemeStyle.HeaderStyle.Height = 50
        dgvEarnings.ThemeStyle.ReadOnly = True
        dgvEarnings.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvEarnings.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvEarnings.ThemeStyle.RowsStyle.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dgvEarnings.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvEarnings.ThemeStyle.RowsStyle.Height = 34
        dgvEarnings.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvEarnings.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Column1
        ' 
        Column1.FillWeight = 39.649662F
        Column1.HeaderText = "Earnings"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.FillWeight = 39.649662F
        Column2.HeaderText = "Profit"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.FillWeight = 39.649662F
        Column3.HeaderText = "Month"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label2.Location = New Point(3, 1)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 32)
        Label2.TabIndex = 11
        Label2.Text = "Earnings"
        ' 
        ' Earnings
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(833, 685)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Earnings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Earnings"
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        CType(dgvEarnings, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvEarnings As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents txtSearchTransaction As Guna.UI2.WinForms.Guna2TextBox
End Class
