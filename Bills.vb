Public Class Bills

    Private Sub btnAddBillForm_Click(sender As Object, e As EventArgs) Handles btnAddBillForm.Click
        billAddForm.Show()
    End Sub

    Private Sub Bills_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_Bill()
    End Sub




    Private Sub dgvBill_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBill.CellContentClick

    End Sub
End Class