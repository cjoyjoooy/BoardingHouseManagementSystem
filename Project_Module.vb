Imports Guna.UI2.WinForms

Module Project_Module
    Public Sub Room_Click(sender As Object, e As EventArgs)
        If CType(sender, Guna2GradientPanel).FillColor = Color.White Then
            CType(sender, Guna2GradientPanel).FillColor = Color.Red
            CType(sender, Guna2GradientPanel).FillColor2 = Color.Red

        ElseIf CType(sender, Guna2GradientPanel).FillColor = Color.Red Then
            CType(sender, Guna2GradientPanel).FillColor = Color.White
            CType(sender, Guna2GradientPanel).FillColor2 = Color.White

        End If
    End Sub
    Public Sub Room_iterate()
        Dim c As Control

        For Each c In Rooms.Controls
            If TypeOf (c) Is Guna2GradientButton Then
                CType(c, Guna2GradientButton).FillColor = Color.Red
                CType(c, Guna2GradientButton).FillColor2 = Color.Red

            End If

        Next
    End Sub


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
            If name = "Occupied" Then
                .BackColor = Color.White
            ElseIf name = "Vacant" Then
                .BackColor = Color.Red
            End If
        End With
        Rooms.addroompanel.Controls.Add(roomPanel)


        With roomName
            .Size = New Size(78, 23)
            .Text = "Room" + " " + name
        End With
        roomPanel.Controls.Add(roomName)

        _CurrentContactPanelName = roomPanel.Name
        _ContactPanelsAddedCount += 1
    End Sub
    Public Sub changePanel(ByVal panels As Form)
        Home.panelHome.Controls.Clear()
        panels.TopLevel = False
        Home.panelHome.Controls.Add(panels)
        panels.Show()


    End Sub
End Module
