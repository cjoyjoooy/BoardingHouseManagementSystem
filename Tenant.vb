Public Class Tenant
    Private Sub Tenant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_Tenant()
    End Sub
    Private Sub btnShowAddForm_Click(sender As Object, e As EventArgs) Handles btnShowAddForm.Click
        tenantAddForm.Show()
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        tenantPayForm.Show()
    End Sub

    Private Sub btnArchive_Click(sender As Object, e As EventArgs) Handles btnArchive.Click
        changePanel(tenantArchive)
    End Sub

    Private Sub btnTenantBillForm_Click(sender As Object, e As EventArgs) Handles btnShowTenantEditForm.Click
        Dim rowIndex As Integer
        rowIndex = dgvTenant.CurrentRow.Index

        tenantEditForm.txtTenandID.Text = dgvTenant.Rows(rowIndex).Cells(0).Value.ToString
        tenantEditForm.txtFname.Text = dgvTenant.Rows(rowIndex).Cells(1).Value.ToString
        tenantEditForm.txtLname.Text = dgvTenant.Rows(rowIndex).Cells(2).Value.ToString
        tenantEditForm.cmbGender.Text = dgvTenant.Rows(rowIndex).Cells(3).Value.ToString
        tenantEditForm.txtAddress.Text = dgvTenant.Rows(rowIndex).Cells(4).Value.ToString
        tenantEditForm.txtContact.Text = dgvTenant.Rows(rowIndex).Cells(5).Value.ToString
        tenantEditForm.dtpDate.Text = dgvTenant.Rows(rowIndex).Cells(6).Value.ToString
        tenantEditForm.cmbStatus.Text = dgvTenant.Rows(rowIndex).Cells(7).Value.ToString
        tenantEditForm.cmbRoom.Text = dgvTenant.Rows(rowIndex).Cells(8).Value.ToString
        tenantEditForm.Show()
    End Sub

    Private Sub btnDeleteTenant_Click(sender As Object, e As EventArgs) Handles btnDeleteTenant.Click
        Dim rowIndex As Integer
        Dim TenantID As Integer
        rowIndex = dgvTenant.CurrentRow.Index
        TenantID = dgvTenant.Rows(rowIndex).Cells(0).Value.ToString
        delete_Tenant(TenantID)
        display_Tenant()
    End Sub
End Class