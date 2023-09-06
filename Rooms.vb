Imports Guna.UI2.WinForms

Public Class Rooms


    Private Sub Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Do not erase --------------------------------
        Dim rooms() As Integer = {1, 2, 3}
        For Each room In rooms
            RoomPanels(room)
        Next

    End Sub

End Class