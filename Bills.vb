Public Class Bills
    Private Sub dgvBill_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBill.CellContentClick

        Dim colName As String = dgvBill.Columns(e.ColumnIndex).Name
        Dim rowIndex As Integer
        rowIndex = dgvBill.CurrentRow.Index

        billEditForm.txtBillID.Text = dgvBill.Rows(rowIndex).Cells(2).Value.ToString
        billEditForm.txtElectricity.Text = dgvBill.Rows(rowIndex).Cells(3).Value.ToString
        billEditForm.txtWater.Text = dgvBill.Rows(rowIndex).Cells(4).Value.ToString
        billEditForm.txtMaintenance.Text = dgvBill.Rows(rowIndex).Cells(5).Value.ToString
        billEditForm.txtMisc.Text = dgvBill.Rows(rowIndex).Cells(6).Value.ToString

        'show edit form
        If colName = "editColumn" Then
            billEditForm.Show()
            'edit method

            'delete row data
        ElseIf colName = "deleteColumn" Then

        End If
    End Sub

    Private Sub btnAddBillForm_Click(sender As Object, e As EventArgs) Handles btnAddBillForm.Click
        billAddForm.Show()
    End Sub

    Private Sub Bills_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_Bill()
    End Sub
End Class