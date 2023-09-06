Imports Guna.UI2.WinForms

Module Project_Module
    Private SelectedPanel As Panel = Nothing
    Public Sub room_click(sender As Object, e As EventArgs)
        Dim clickedPanel As Panel = CType(sender, Panel)
        Dim panelName As String = clickedPanel.Name

        ' Toggle the background color of the clicked panel
        If clickedPanel.BackColor = Color.FromArgb(254, 206, 47) Then
            clickedPanel.BackColor = CType(clickedPanel.Tag, Color)
        Else
            clickedPanel.BackColor = Color.FromArgb(254, 206, 47)
        End If

        Rooms.lblRoomNumber.Text = "Room " & panelName.Substring(7)

        ' Update the SelectedPanel to the currently clicked panel
        SelectedPanel = clickedPanel
    End Sub

    'Public Sub Room_iterate()
    '    Dim c As Control
    '    For Each c In Rooms.addroompanel.Controls
    '        If TypeOf (c) Is Panel Then
    '            CType(c, Panel).BackColor = Color.Red
    '        End If
    '    Next
    'End Sub


    'Do not erase --------------------------------
    Private _CurrentContactPanelName As String = Nothing
    Private _ContactPanelsAddedCount As Integer = 0
    Public Sub RoomPanels(ByVal name As String)

        Dim roomPanel As Panel
        Dim roomName As Label

        roomPanel = New Panel()
        roomName = New Label()

        With roomPanel
            .Size = New Size(127, 106)
            .Name = "pnlRoom" + (name).ToString

            ' Set the original color based on the room status
            If name = "Occupied" Then
                .Tag = Color.White
                .BackColor = Color.White
            ElseIf name = "Vacant" Then
                .Tag = Color.Red
                .BackColor = Color.Red
            End If
        End With

        Rooms.addroompanel.Controls.Add(roomPanel)


        With roomName
            .Name = "RoomNumber"
            .Size = New Size(78, 23)
            .Text = "Room" + " " + name
        End With
        roomPanel.Controls.Add(roomName)

        _CurrentContactPanelName = roomPanel.Name
        _ContactPanelsAddedCount += 1
        AddHandler roomPanel.Click, AddressOf room_click




    End Sub


    Public Sub changePanel(ByVal panels As Form)
        Home.panelHome.Controls.Clear()
        panels.TopLevel = False
        Home.panelHome.Controls.Add(panels)
        panels.Show()
    End Sub
End Module
