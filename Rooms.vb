Imports Guna.UI2.WinForms
Public Class Rooms
    Private Sub Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_Rooms()
    End Sub

    Private Sub btnAddRoomForm_Click(sender As Object, e As EventArgs) Handles btnAddRoomForm.Click
        roomAddForm.Show()
    End Sub

    Private Sub btnEditRoomForm_Click(sender As Object, e As EventArgs) Handles btnEditRoomForm.Click
        Dim roomName As String
        roomName = lblRoomNumber.Text
        display_Room_info(roomName)
        roomEditForm.Show()
    End Sub


    Private Sub lblRoomNumber_TextChanged(sender As Object, e As EventArgs) Handles lblRoomNumber.TextChanged
        Dim roomName As String
        roomName = lblRoomNumber.Text
        If tenantList IsNot Nothing Then
            tenantList.Controls.Clear()
            _ContactLabelsAddedCount = 0
        End If
        display_Room_info(roomName)
        display_Room_Tenant(roomName)
    End Sub


End Class