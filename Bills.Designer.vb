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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Bills))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Label2 = New Label()
        dgvBill = New Guna.UI2.WinForms.Guna2DataGridView()
        btnAddBillForm = New Guna.UI2.WinForms.Guna2Button()
        Guna2Panel1.SuspendLayout()
        CType(dgvBill, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.FromArgb(CByte(232), CByte(232), CByte(231))
        Guna2Panel1.Controls.Add(Label2)
        Guna2Panel1.Controls.Add(dgvBill)
        Guna2Panel1.Controls.Add(btnAddBillForm)
        Guna2Panel1.CustomizableEdges = CustomizableEdges3
        Guna2Panel1.Dock = DockStyle.Fill
        Guna2Panel1.FillColor = Color.FromArgb(CByte(232), CByte(232), CByte(231))
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Panel1.Size = New Size(833, 685)
        Guna2Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        Label2.Location = New Point(3, 1)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 32)
        Label2.TabIndex = 47
        Label2.Text = "Bills"
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
        dgvBill.Location = New Point(11, 45)
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
        dgvBill.Size = New Size(809, 636)
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
        ' btnAddBillForm
        ' 
        btnAddBillForm.BorderRadius = 10
        btnAddBillForm.CustomizableEdges = CustomizableEdges1
        btnAddBillForm.DisabledState.BorderColor = Color.DarkGray
        btnAddBillForm.DisabledState.CustomBorderColor = Color.DarkGray
        btnAddBillForm.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAddBillForm.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAddBillForm.FillColor = Color.FromArgb(CByte(254), CByte(206), CByte(47))
        btnAddBillForm.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddBillForm.ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        btnAddBillForm.Image = CType(resources.GetObject("btnAddBillForm.Image"), Image)
        btnAddBillForm.Location = New Point(770, 1)
        btnAddBillForm.Name = "btnAddBillForm"
        btnAddBillForm.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnAddBillForm.Size = New Size(50, 40)
        btnAddBillForm.TabIndex = 43
        ' 
        ' Bills
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(833, 685)
        Controls.Add(Guna2Panel1)
        ForeColor = Color.FromArgb(CByte(27), CByte(27), CByte(27))
        FormBorderStyle = FormBorderStyle.None
        Name = "Bills"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bills"
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        CType(dgvBill, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnAddBillForm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvBill As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label2 As Label
End Class
