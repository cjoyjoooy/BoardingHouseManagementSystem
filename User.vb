Public Class User
    Private Sub btnAddUserForm_Click(sender As Object, e As EventArgs) Handles btnAddUserForm.Click
        userAddForm.Show()
    End Sub

    Private Sub btnUserBillForm_Click(sender As Object, e As EventArgs) Handles btnUserBillForm.Click
        userEditForm.Show()
    End Sub
End Class