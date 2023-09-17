Public Class User
    Private Sub btnAddUserForm_Click(sender As Object, e As EventArgs) Handles btnAddUserForm.Click
        userAddForm.Show()
    End Sub

    Private Sub dgvUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellContentClick
        Dim colName As String = dgvUser.Columns(e.ColumnIndex).Name

        'show edit form
        If colName = "editColumn" Then
            userEditForm.Show()

            'delete row data
        ElseIf colName = "deleteColumn" Then
            'delete method
        End If
    End Sub
End Class