Imports Guna.UI2.WinForms
Module Project_Module

    Private SelectedPanel As Panel = Nothing

    'This changes room panels background color when selected
    Public Sub room_click(sender As Object, e As EventArgs)

        Dim clickedPanel As Panel = CType(sender, Panel)
        Dim panelName As String = clickedPanel.Name

        If SelectedPanel IsNot Nothing AndAlso Not Object.ReferenceEquals(SelectedPanel, clickedPanel) Then
            SelectedPanel.BackColor = CType(SelectedPanel.Tag, Color)
        End If

        If clickedPanel.BackColor = Color.White Then
            clickedPanel.BackColor = Color.FromArgb(254, 206, 47)
        ElseIf clickedPanel.BackColor = Color.FromArgb(154, 154, 154) Then
            clickedPanel.BackColor = Color.FromArgb(254, 206, 47)
        Else
            clickedPanel.BackColor = CType(clickedPanel.Tag, Color)
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
        Dim roomPanel As Panel
        Dim roomName As Label

        roomPanel = New Panel()
        roomName = New Label()

        'room panel
        With roomPanel
            .Size = New Size(161, 110)
            'NOTE: change name to id
            .Name = "pnlRoom" + (name).ToString

            'NOTE: change name to status
            If name = "Occupied" Then
                .Tag = Color.White
                .BackColor = Color.White
            ElseIf name = "Vacant" Then
                .Tag = Color.FromArgb(154, 154, 154)
                .BackColor = Color.FromArgb(154, 154, 154)
            End If
        End With

        'room label inside the room panel
        With roomName
            .Name = "RoomNumber"
            .Size = New Size(168, 26)
            'NOTE: change name to id
            .Text = "Room" + " " + (name).ToString
        End With

        Rooms.addroompanel.Controls.Add(roomPanel)
        roomPanel.Controls.Add(roomName)

        _CurrentContactPanelName = roomPanel.Name
        _ContactPanelsAddedCount += 1
        AddHandler roomPanel.Click, AddressOf room_click

    End Sub

    'sidebar navigation panel change
    Public Sub changePanel(ByVal panels As Form)
        Home.panelHome.Controls.Clear()
        panels.TopLevel = False
        Home.panelHome.Controls.Add(panels)
        panels.Show()
    End Sub


    Public Sub add_tenant(ByVal fname As String, ByVal lname As String, ByVal gender As String, ByVal address As String, ByVal contact As String, ByVal room As String, ByVal lease As String, ByVal status As String)

        'tenant add form
        fname = tenantAddForm.txtFname.Text
        lname = tenantAddForm.txtLname.Text
        If tenantAddForm.rbdFemale.Checked = True Then
            gender = "Female"
        ElseIf tenantAddForm.Male.Checked = True Then
            gender = "Male"
        End If
        address = tenantAddForm.txtAddress.Text
        contact = tenantAddForm.txtContact.Text
        room = tenantAddForm.cmbRoom.SelectedItem
        status = tenantAddForm.cmbStatus.SelectedItem
        lease = tenantAddForm.dtpLease.Value

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
