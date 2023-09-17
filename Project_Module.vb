﻿Imports Guna.UI2.WinForms
Module Project_Module

    Private SelectedPanel As Guna2Panel = Nothing

    'This changes room panels background color when selected
    Public Sub room_click(sender As Object, e As EventArgs)
        If TypeOf sender Is Guna2Panel Then
            Dim clickedPanel As Guna2Panel = DirectCast(sender, Guna2Panel)
            HandlePanelClick(clickedPanel)
        ElseIf TypeOf sender Is Label Then
            Dim clickedLabel As Label = DirectCast(sender, Label)
            Dim clickedPanel As Guna2Panel = DirectCast(clickedLabel.Parent, Guna2Panel)
            HandlePanelClick(clickedPanel)
        End If
    End Sub

    Private Sub HandlePanelClick(clickedPanel As Guna2Panel)
        Dim panelName As String = clickedPanel.Name

        If SelectedPanel IsNot Nothing AndAlso Not Object.ReferenceEquals(SelectedPanel, clickedPanel) Then
            SelectedPanel.FillColor = CType(SelectedPanel.Tag, Color)
        End If

        If clickedPanel.FillColor = Color.White Then
            clickedPanel.FillColor = Color.FromArgb(254, 206, 47)
        ElseIf clickedPanel.FillColor = Color.FromArgb(154, 154, 154) Then
            clickedPanel.FillColor = Color.FromArgb(254, 206, 47)
        Else
            clickedPanel.FillColor = CType(clickedPanel.Tag, Color)
        End If

        'display the roomNumber and Status
        Rooms.lblRoomNumber.Text = panelName.Substring(7)
        'NOTE: remove Rooms.lblStatus.Text = panelName.Substring(7)
        Rooms.lblStatus.Text = panelName.Substring(7)

        SelectedPanel = clickedPanel
    End Sub



    'creates room panel with labels and assigned background color based on room status(vacant, occupied)
    Private _CurrentContactPanelName As String = Nothing
    Private _ContactPanelsAddedCount As Integer = 0
    Public Sub RoomPanels(ByVal name As String) 'NOTE: (ByVal id As Integer, Byval status As String)
        Dim roomPanel As Guna2Panel
        Dim roomName, roomNumber As Label

        roomPanel = New Guna2Panel()
        roomName = New Label()
        roomNumber = New Label()

        'room panel
        With roomPanel
            .Size = New Size(161, 110)
            .BorderRadius = 10
            .BackColor = Color.FromArgb(232, 232, 231)
            'NOTE: change name to id
            .Name = "pnlRoom" + (name).ToString

            'NOTE: change name to status
            If name = "Occupied" Then
                .Tag = Color.White
                .FillColor = Color.White
            ElseIf name = "Vacant" Then
                .Tag = Color.FromArgb(154, 154, 154)
                .FillColor = Color.FromArgb(154, 154, 154)
            End If
        End With

        'room label inside the room panel
        With roomName
            .Name = "RoomName"

            .BackColor = Color.Transparent
            .Location = New Point(44, 22)
            .Font = New Drawing.Font("Trebuchet MS", 12)

            .Text = "Room"
        End With
        With roomNumber
            .Name = "RoomNumber"

            .BackColor = Color.Transparent
            .Location = New Point(44, 53)
            .Font = New Drawing.Font("Trebuchet MS", 12)
            'NOTE: change name to roomname(database)
            .Text = (name).ToString
        End With

        Rooms.addroompanel.Controls.Add(roomPanel)
        roomPanel.Controls.Add(roomName)
        roomPanel.Controls.Add(roomNumber)

        _CurrentContactPanelName = roomPanel.Name
        _ContactPanelsAddedCount += 1
        AddHandler roomPanel.Click, AddressOf room_click
        AddHandler roomName.Click, AddressOf room_click
        AddHandler roomNumber.Click, AddressOf room_click

    End Sub

    'sidebar navigation panel change
    Public Sub changePanel(ByVal panels As Form)
        Home.panelHome.Controls.Clear()
        panels.TopLevel = False
        Home.panelHome.Controls.Add(panels)
        panels.Show()
    End Sub


    Public Sub add_tenant(ByVal fname As String, ByVal lname As String, ByVal gender As String, ByVal address As String, ByVal contact As String, ByVal room As String, ByVal lease As String, ByVal status As String)
        Tenant.dgvTenant.Rows.Add(fname, lname, gender, address, contact, room, lease, status)
        tenantAddForm.Close()
    End Sub

    Public Sub update_tenant()
        'tenant edit form
        Dim rowIndex As Integer
        rowIndex = Tenant.dgvTenant.CurrentRow.Index

        tenantEditForm.txtFname.Text = Tenant.dgvTenant.Rows(rowIndex).Cells(0).Value.ToString
        tenantEditForm.txtLname.Text = Tenant.dgvTenant.Rows(rowIndex).Cells(1).Value.ToString
        tenantEditForm.txtAddress.Text = Tenant.dgvTenant.Rows(rowIndex).Cells(3).Value.ToString
    End Sub

    Public Sub delete_tenant()
        Dim rowIndex As Integer
        rowIndex = Tenant.dgvTenant.CurrentRow.Index
        Tenant.dgvTenant.Rows.RemoveAt(rowIndex)
    End Sub


    'NOTE: Do not erase --------------------------------

    'Public Sub Room_iterate()
    '    Dim c As Control
    '    For Each c In Rooms.addroompanel.Controls
    '        If TypeOf (c) Is Panel Then
    '            CType(c, Panel).BackColor = Color.Red
    '        End If
    '    Next
    'End Sub

    '--------------------------------

End Module
