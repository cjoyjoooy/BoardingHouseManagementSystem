Public Class Bills

    Private Sub btnAddBillForm_Click(sender As Object, e As EventArgs) Handles btnAddBillForm.Click
        billAddForm.Show()
    End Sub

    Private Sub Bills_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_Bill()
    End Sub

    Private Sub btnEditBillForm_Click(sender As Object, e As EventArgs) Handles btnEditBillForm.Click
        Dim rowIndex As Integer
        rowIndex = dgvBill.CurrentRow.Index

        billEditForm.txtBillID.Text = dgvBill.Rows(rowIndex).Cells(0).Value.ToString
        billEditForm.txtElectricity.Text = dgvBill.Rows(rowIndex).Cells(1).Value.ToString
        billEditForm.txtWater.Text = dgvBill.Rows(rowIndex).Cells(2).Value.ToString
        billEditForm.txtMaintenance.Text = dgvBill.Rows(rowIndex).Cells(3).Value.ToString
        billEditForm.txtMisc.Text = dgvBill.Rows(rowIndex).Cells(4).Value.ToString
        billEditForm.Show()
    End Sub

End Class