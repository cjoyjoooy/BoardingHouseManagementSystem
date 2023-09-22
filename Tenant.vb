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


End Class