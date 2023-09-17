Public Class roomAddForm
    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()
    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click

        Dim RoomName, MonthlyRent, Status As String
        Dim NumberOfPerson As Integer

        RoomName = txtRoomName.Text
        MonthlyRent = txtMonthlyRent.Text
        NumberOfPerson = txtNumPerson.Text
        Status = cmbRoomStatus.Text

        add_Rooms(RoomName, MonthlyRent, NumberOfPerson, Status)

        Me.Close()
    End Sub

End Class