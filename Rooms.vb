Imports Guna.UI2.WinForms
Public Class Rooms
    Private Sub Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'NOTE: temporary representation of status in database
        Dim rooms() As String = {"1", "2", "3", "4", "5", "6", "7"}


        'NOTE: Need to select id and status from database

        For Each room In rooms
            RoomPanels(room, "Vacant")
            'NOTE: RoomPanels(id,status)

        Next
    End Sub

    Private Sub btnAddRoomForm_Click(sender As Object, e As EventArgs) Handles btnAddRoomForm.Click
        roomAddForm.Show()
    End Sub

    Private Sub btnEditRoomForm_Click(sender As Object, e As EventArgs) Handles btnEditRoomForm.Click
        roomEditForm.Show()
    End Sub

    Private Sub btnDeleteRoom_Click(sender As Object, e As EventArgs) Handles btnDeleteRoom.Click

    End Sub

End Class