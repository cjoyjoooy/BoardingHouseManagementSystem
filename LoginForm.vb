Public Class LoginForm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username, password As String

        username = Usernametxt.Text
        password = Passwordtxt.Text

        If String.IsNullOrEmpty(username) Then
            MessageBox.Show("Some fields are empty! Please try again.")

        ElseIf String.IsNullOrEmpty(password) Then
            MessageBox.Show("Some fields are empty! Please try again.")

        Else
            Me.Hide()
            Home.Show()
        End If


    End Sub


End Class
