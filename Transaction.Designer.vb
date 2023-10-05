<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaction
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Transaction))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        txtSearchTransaction = New Guna.UI2.WinForms.Guna2TextBox()
        dgvTransaction = New Guna.UI2.WinForms.Guna2DataGridView()
        Label2 = New Label()
        Guna2Panel1.SuspendLayout()
        CType(dgvTransaction, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.FromArgb(CByte(232), CByte(232), CByte(231))
        Guna2Panel1.Controls.Add(txtSearchTransaction)
        Guna2Panel1.Controls.Add(dgvTransaction)
        Guna2Panel1.Controls.Add(Label2)
        Guna2Panel1.CustomizableEdges = CustomizableEdges3
        Guna2Panel1.Dock = DockStyle.Fill
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
        txtSearchTransaction.Location = New Point(416, 1)
        txtSearchTransaction.Margin = New Padding(5, 3, 5, 3)
        txtSearchTransaction.Name = "txtSearchTransaction"
        txtSearchTransaction.PasswordChar = ChrW(0)
        txtSearchTransaction.PlaceholderText = "Enter tenant's name"
        txtSearchTransaction.SelectedText = ""
        txtSearchTransaction.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtSearchTransaction.Size = New Size(405, 35)
        txtSearchTransaction.TabIndex = 14
        ' 
        ' dgvTransaction
        ' 
        dgvTransaction.AllowUserToAddRows = False
        dgvTransaction.AllowUserToDeleteRows = False
        dgvTransaction.AllowUserToResizeColumns = False
        dgvTransaction.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(204), CByte(204), CByte(204))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        dgvTransaction.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        DataGridViewCellStyle2.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvTransaction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvTransaction.ColumnHeadersHeight = 50
        dgvTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(204), CByte(204), CByte(204))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvTransaction.DefaultCellStyle = DataGridViewCellStyle3
        dgvTransaction.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvTransaction.Location = New Point(11, 40)
        dgvTransaction.Name = "dgvTransaction"
        dgvTransaction.ReadOnly = True
        dgvTransaction.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.White
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvTransaction.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvTransaction.RowHeadersVisible = False
        dgvTransaction.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        dgvTransaction.RowTemplate.Height = 34
        dgvTransaction.Size = New Size(809, 645)
        dgvTransaction.TabIndex = 13
        dgvTransaction.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvTransaction.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvTransaction.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvTransaction.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvTransaction.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvTransaction.ThemeStyle.BackColor = Color.White
        dgvTransaction.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvTransaction.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        dgvTransaction.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvTransaction.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvTransaction.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvTransaction.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvTransaction.ThemeStyle.HeaderStyle.Height = 50
        dgvTransaction.ThemeStyle.ReadOnly = True
        dgvTransaction.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvTransaction.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvTransaction.ThemeStyle.RowsStyle.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dgvTransaction.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvTransaction.ThemeStyle.RowsStyle.Height = 34
        dgvTransaction.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvTransaction.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label2.Location = New Point(11, 1)
        Label2.Name = "Label2"
        Label2.Size = New Size(194, 32)
        Label2.TabIndex = 10
        Label2.Text = "Transactions"
        ' 
        ' Transaction
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(833, 685)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Transaction"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Transaction"
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        CType(dgvTransaction, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvTransaction As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtSearchTransaction As Guna.UI2.WinForms.Guna2TextBox
End Class
