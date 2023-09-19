Public Class Tenant
    Private Sub dgvTenant_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTenant.CellContentClick
        Dim colName As String = dgvTenant.Columns(e.ColumnIndex).Name

        'show edit form
        If colName = "editColumn" Then
            tenantEditForm.Show()
            update_tenant()

            'delete row data
        ElseIf colName = "deleteColumn" Then
            delete_tenant()
        End If
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
End Class