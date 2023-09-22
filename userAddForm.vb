Public Class userAddForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click

        Dim Name, Address, ContactNum, Username, Password As String

        Name = txtName.Text
        Address = txtName.Text
        ContactNum = txtContactNum.Text
        Username = txtUsername.Text
        Password = txtPassword.Text
        add_User(Name, Address, ContactNum, Username, Password)
        display_User()
        Me.Close()
    End Sub

End Class