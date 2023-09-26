<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bills
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Bills))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        btnDeleteBill = New Guna.UI2.WinForms.Guna2Button()
        btnEditBillForm = New Guna.UI2.WinForms.Guna2Button()
        dgvBill = New Guna.UI2.WinForms.Guna2DataGridView()
        txtSearchTransaction = New Guna.UI2.WinForms.Guna2TextBox()
        btnAddBillForm = New Guna.UI2.WinForms.Guna2Button()
        Guna2Panel1.SuspendLayout()
        CType(dgvBill, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.FromArgb(CByte(232), CByte(232), CByte(231))
        Guna2Panel1.Controls.Add(btnDeleteBill)
        Guna2Panel1.Controls.Add(btnEditBillForm)
        Guna2Panel1.Controls.Add(dgvBill)
        Guna2Panel1.Controls.Add(txtSearchTransaction)
        Guna2Panel1.Controls.Add(btnAddBillForm)
        Guna2Panel1.CustomizableEdges = CustomizableEdges9
        Guna2Panel1.Dock = DockStyle.Fill
        Guna2Panel1.FillColor = Color.FromArgb(CByte(232), CByte(232), CByte(231))
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Margin = New Padding(3, 2, 3, 2)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Panel1.Size = New Size(729, 514)
        Guna2Panel1.TabIndex = 0
        ' 
        ' btnDeleteBill
        ' 
        btnDeleteBill.BorderRadius = 10
        btnDeleteBill.CustomizableEdges = CustomizableEdges1
        btnDeleteBill.DisabledState.BorderColor = Color.DarkGray
        btnDeleteBill.DisabledState.CustomBorderColor = Color.DarkGray
        btnDeleteBill.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDeleteBill.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnDeleteBill.FillColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        btnDeleteBill.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnDeleteBill.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        btnDeleteBill.Image = CType(resources.GetObject("btnDeleteBill.Image"), Image)
        btnDeleteBill.Location = New Point(673, 1)
        btnDeleteBill.Margin = New Padding(3, 2, 3, 2)
        btnDeleteBill.Name = "btnDeleteBill"
        btnDeleteBill.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnDeleteBill.Size = New Size(44, 30)
        btnDeleteBill.TabIndex = 46
        ' 
        ' btnEditBillForm
        ' 
        btnEditBillForm.BorderRadius = 10
        btnEditBillForm.CustomizableEdges = CustomizableEdges3
        btnEditBillForm.DisabledState.BorderColor = Color.DarkGray
        btnEditBillForm.DisabledState.CustomBorderColor = Color.DarkGray
        btnEditBillForm.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEditBillForm.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnEditBillForm.FillColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        btnEditBillForm.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnEditBillForm.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        btnEditBillForm.Image = CType(resources.GetObject("btnEditBillForm.Image"), Image)
        btnEditBillForm.Location = New Point(617, 1)
        btnEditBillForm.Margin = New Padding(3, 2, 3, 2)
        btnEditBillForm.Name = "btnEditBillForm"
        btnEditBillForm.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnEditBillForm.Size = New Size(44, 30)
        btnEditBillForm.TabIndex = 45
        ' 
        ' dgvBill
        ' 
        dgvBill.AllowUserToAddRows = False
        dgvBill.AllowUserToDeleteRows = False
        dgvBill.AllowUserToResizeColumns = False
        dgvBill.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(204), CByte(204), CByte(204))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        dgvBill.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        DataGridViewCellStyle2.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvBill.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvBill.ColumnHeadersHeight = 50
        dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(204), CByte(204), CByte(204))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvBill.DefaultCellStyle = DataGridViewCellStyle3
        dgvBill.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvBill.Location = New Point(10, 34)
        dgvBill.Margin = New Padding(3, 2, 3, 2)
        dgvBill.Name = "dgvBill"
        dgvBill.ReadOnly = True
        dgvBill.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.White
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvBill.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvBill.RowHeadersVisible = False
        dgvBill.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        dgvBill.RowTemplate.Height = 34
        dgvBill.Size = New Size(708, 477)
        dgvBill.TabIndex = 44
        dgvBill.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvBill.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvBill.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvBill.ThemeStyle.BackColor = Color.White
        dgvBill.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvBill.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        dgvBill.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvBill.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvBill.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvBill.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvBill.ThemeStyle.HeaderStyle.Height = 50
        dgvBill.ThemeStyle.ReadOnly = True
        dgvBill.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvBill.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvBill.ThemeStyle.RowsStyle.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dgvBill.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvBill.ThemeStyle.RowsStyle.Height = 34
        dgvBill.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvBill.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
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
        txtSearchTransaction.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtSearchTransaction.HoverState.BorderColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        txtSearchTransaction.IconLeft = CType(resources.GetObject("txtSearchTransaction.IconLeft"), Image)
        txtSearchTransaction.IconLeftOffset = New Point(10, 0)
        txtSearchTransaction.Location = New Point(10, 2)
        txtSearchTransaction.Margin = New Padding(4, 2, 4, 2)
        txtSearchTransaction.Name = "txtSearchTransaction"
        txtSearchTransaction.PasswordChar = ChrW(0)
        txtSearchTransaction.PlaceholderText = ""
        txtSearchTransaction.SelectedText = ""
        txtSearchTransaction.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtSearchTransaction.Size = New Size(354, 26)
        txtSearchTransaction.TabIndex = 15
        ' 
        ' btnAddBillForm
        ' 
        btnAddBillForm.BorderRadius = 10
        btnAddBillForm.CustomizableEdges = CustomizableEdges7
        btnAddBillForm.DisabledState.BorderColor = Color.DarkGray
        btnAddBillForm.DisabledState.CustomBorderColor = Color.DarkGray
        btnAddBillForm.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAddBillForm.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAddBillForm.FillColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        btnAddBillForm.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddBillForm.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        btnAddBillForm.Image = CType(resources.GetObject("btnAddBillForm.Image"), Image)
        btnAddBillForm.Location = New Point(561, 1)
        btnAddBillForm.Margin = New Padding(3, 2, 3, 2)
        btnAddBillForm.Name = "btnAddBillForm"
        btnAddBillForm.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnAddBillForm.Size = New Size(44, 30)
        btnAddBillForm.TabIndex = 43
        ' 
        ' Bills
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(729, 514)
        Controls.Add(Guna2Panel1)
        ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Bills"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bills"
        Guna2Panel1.ResumeLayout(False)
        CType(dgvBill, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnAddBillForm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearchTransaction As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvBill As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnDeleteBill As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEditBillForm As Guna.UI2.WinForms.Guna2Button
End Class
