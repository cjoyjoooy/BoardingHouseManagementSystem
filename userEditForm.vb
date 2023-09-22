Public Class userEditForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
        Dim Name, Address, ContactNum, Username, Password As String
        Dim UserID As Integer

        Name = txtName.Text
        Address = txtAddress.Text
        ContactNum = txtContactNum.Text
        Username = txtUsername.Text
        Password = txtPassword.Text
        UserID = txtUserID.Text

        edit_User(Name, Address, ContactNum, Username, Password, UserID)
        display_User()
        Me.Close()
    End Sub
End Class