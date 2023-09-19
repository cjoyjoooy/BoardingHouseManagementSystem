Public Class tenantArchive
    Private Sub dgvArchiveTenant_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArchiveTenant.CellContentClick
        Dim colName As String = dgvArchiveTenant.Columns(e.ColumnIndex).Name

        'to restore data back to the tenant table
        If colName = "editColumn" Then
            'insert restore method here

            'delete row data
        ElseIf colName = "deleteColumn" Then
            delete_tenant()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        changePanel(Tenant)
    End Sub
End Class