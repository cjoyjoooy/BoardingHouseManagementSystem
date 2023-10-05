Imports System.Windows.Controls

Public Class roomAddForm
    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()
    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click

        Try
            Dim RoomName, MonthlyRent As String
            Dim NumberOfPerson As Integer

            RoomName = txtRoomName.Text
            MonthlyRent = txtMonthlyRent.Text

            If String.IsNullOrEmpty(txtNumPerson.Text) OrElse Not Integer.TryParse(txtNumPerson.Text, NumberOfPerson) Then
                MessageBox.Show("Invalid or empty number of persons entered. Please enter a valid integer value.")
                Return
            End If

            If String.IsNullOrEmpty(RoomName) Then
                MessageBox.Show("Some fields are empty! Please try again")
                Return
            ElseIf String.IsNullOrEmpty(MonthlyRent) Then
                MessageBox.Show("Some fields are empty! Please try again")
                Return

            Else
                add_Rooms(RoomName, MonthlyRent, NumberOfPerson, "Vacant")
                If Rooms.addroompanel IsNot Nothing Then
                    Rooms.addroompanel.Controls.Clear()
                    display_Rooms()
                    Rooms.lblMonthlyRent.Text = "--"
                    Rooms.lblNumOccupants.Text = "--"
                    Rooms.lblStatus.Text = "--"
                    Rooms.lblRoomNumber.Text = "--"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try


        Me.Close()


    End Sub

End Class