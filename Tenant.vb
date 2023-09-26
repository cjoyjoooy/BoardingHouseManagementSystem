Public Class Tenant

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
        tenantEditForm.Show()
    End Sub
End Class