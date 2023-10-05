Public Class userAddForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Try
            Dim Name, Address, ContactNum, Username, Password As String

            Name = txtName.Text
            Address = txtAddress.Text
            ContactNum = txtContactNum.Text
            Username = txtUsername.Text
            Password = txtPassword.Text

            If String.IsNullOrEmpty(Name) Then
                MessageBox.Show("Some fields are empty! Please try again.")
                Return
            ElseIf String.IsNullOrEmpty(Address) Then
                MessageBox.Show("Some fields are empty! Please try again.")
                Return
            ElseIf String.IsNullOrEmpty(ContactNum) Then
                MessageBox.Show("Some fields are empty! Please try again.")
                Return
            ElseIf String.IsNullOrEmpty(Username) Then
                MessageBox.Show("Some fields are empty! Please try again.")
                Return
            ElseIf String.IsNullOrEmpty(Password) Then
                MessageBox.Show("Some fields are empty! Please try again.")
                Return
            Else
                add_User(Name, Address, ContactNum, Username, Password)
                display_User()
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

        Me.Close()
    End Sub

End Class