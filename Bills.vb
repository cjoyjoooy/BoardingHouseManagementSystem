Public Class Bills
    Private Sub dgvBill_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBill.CellContentClick
        Dim colName As String = dgvBill.Columns(e.ColumnIndex).Name
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
End Class