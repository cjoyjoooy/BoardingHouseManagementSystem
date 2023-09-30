Public Class roomEditForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnEditRoom_Click(sender As Object, e As EventArgs) Handles btnEditRoom.Click
        Dim RoomName, MonthlyRent As String
        Dim NumberOfPerson As Integer

        RoomName = txtRoomName.Text
        MonthlyRent = txtMonthlyRent.Text
        NumberOfPerson = txtNumPerson.Text


        edit_Rooms(MonthlyRent, NumberOfPerson, RoomName)
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

        Me.Close()
    End Sub
End Class