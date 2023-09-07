Imports Guna.UI2.WinForms
Public Class Rooms
    Private Sub Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'NOTE: temporary representation of status in database
        Dim rooms() As String = {"Occupied", "Vacant", "Vacant", "Occupied"}

        'NOTE: Need to select id and status from database

        For Each room In rooms
            RoomPanels(room)
            'NOTE: RoomPanels(id,status)
        Next
    End Sub

End Class