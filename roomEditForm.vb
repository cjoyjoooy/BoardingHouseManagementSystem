Public Class roomEditForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnEditRoom.Click
        Dim RoomName, MonthlyRent, Status As String
        Dim NumberOfPerson As Integer

        RoomName = txtRoomName.Text
        MonthlyRent = txtMonthlyRent.Text
        NumberOfPerson = txtNumPerson.Text
        Status = cmbRoomStatus.Text

        edit_Rooms(MonthlyRent, NumberOfPerson, Status, RoomName)
        Me.Close()
    End Sub
End Class