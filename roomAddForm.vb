Public Class roomAddForm
    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()
    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click

        Dim RoomName, MonthlyRent As String
        Dim NumberOfPerson As Integer

        RoomName = txtRoomName.Text
        MonthlyRent = txtMonthlyRent.Text
        NumberOfPerson = txtNumPerson.Text
        add_Rooms(RoomName, MonthlyRent, NumberOfPerson, "Vacant")

        If Rooms.addroompanel IsNot Nothing Then
            Rooms.addroompanel.Controls.Clear()
            display_Rooms()
            Rooms.lblMonthlyRent.Text = "--"
            Rooms.lblNumOccupants.Text = "--"
            Rooms.lblStatus.Text = "--"
            Rooms.lblRoomNumber.Text = "--"
        End If

        Me.Close()


    End Sub

End Class