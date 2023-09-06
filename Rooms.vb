Imports Guna.UI2.WinForms

Public Class Rooms


    Private Sub Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rooms() As String = {"Occupied", "Vacant", "Vacant", "Occupied"}

        For Each room In rooms
            RoomPanels(room)
        Next
    End Sub



End Class