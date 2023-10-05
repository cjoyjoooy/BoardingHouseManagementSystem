Public Class roomEditForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnEditRoom_Click(sender As Object, e As EventArgs) Handles btnEditRoom.Click

        Try
            Dim RoomName, MonthlyRent, Name As String
            Dim NumberOfPerson As Integer

            Name = lblRoomName.Text
            RoomName = txtRoomName.Text
            MonthlyRent = txtMonthlyRent.Text
            NumberOfPerson = txtNumPerson.Text



            If String.IsNullOrEmpty(Name) Then
                MessageBox.Show("Some fields are empty! Please try again")
                Return
            ElseIf String.IsNullOrEmpty(RoomName) Then
                MessageBox.Show("Some fields are empty! Please try again")
                Return
            ElseIf String.IsNullOrEmpty(MonthlyRent) Then
                MessageBox.Show("Some fields are empty! Please try again")
                Return
            Else
                edit_Rooms(RoomName, MonthlyRent, NumberOfPerson, Name)
                check_Occupant_Number_Edit(RoomName)
                If Rooms.addroompanel IsNot Nothing Then
                    Rooms.addroompanel.Controls.Clear()
                    display_Rooms()
                    display_Room_info(RoomName)
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