Imports Guna.UI2.WinForms
Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Net


Module Project_Module

    Public sqliteConnection As New SQLiteConnection("Data Source = " & Application.StartupPath & "\LourdesBhausDatabase.db")

    Dim sqliteDataAdapter As SQLiteDataAdapter

    Dim dataSet As DataSet

    Public Sub SQLite_Open_Connection()

        Try

            If sqliteConnection.State = ConnectionState.Closed Then

                sqliteConnection.Open()


            End If

        Catch ex As SQLiteException

            MessageBox.Show("Error: " & ex.Message)

        End Try

    End Sub

    Public Sub SQLite_Close_Connection()

        Try

            If sqliteConnection.State = ConnectionState.Open Then

                sqliteConnection.Close()

            End If

        Catch ex As SQLiteException

            MessageBox.Show("Error: " & ex.Message)

        End Try

    End Sub


    Public Sub add_Bill(ByVal ElectricityBill As Double, ByVal WaterBill As Double, ByVal MaintenanceBill As Double, ByVal MiscBill As Double)
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet

            sqliteDataAdapter = New SQLiteDataAdapter("INSERT INTO Bill VALUES(null,'" & ElectricityBill & "','" & WaterBill & "', '" & MaintenanceBill & "', '" & MiscBill & "')", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Bill")
            MessageBox.Show("Added")
        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()

        End Try

    End Sub

    Public Sub edit_Bill(ByVal ElectricityBill As Double, ByVal WaterBill As Double, ByVal MaintenanceBill As Double, ByVal MiscBill As Double, ByVal BillID As Integer)

        Try
            SQLite_Open_Connection()
            dataSet = New DataSet

            sqliteDataAdapter = New SQLiteDataAdapter("UPDATE Bill SET ElectricityBill = " & ElectricityBill & ", WaterBill = " & WaterBill & ", MaintenanceBill = " & MaintenanceBill & ", MiscBill = " & MiscBill & " WHERE BillID = " & BillID & "", sqliteConnection)

            sqliteDataAdapter.Fill(dataSet, "Bill")

            MessageBox.Show("Edited.")

        Catch ex As SQLiteException

            MessageBox.Show("Error: " & ex.Message)

        Finally

            SQLite_Close_Connection()

        End Try
    End Sub

    Public Sub delete_Bill(ByVal BillID As Integer)
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("DELETE FROM Bill WHERE BillID = " & BillID & "", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Bill")
        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally

            SQLite_Close_Connection()
        End Try
    End Sub

    Public Sub display_Bill()
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT BillID, ElectricityBill, WaterBill, MaintenanceBill, MiscBill FROM Bill", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Bill")
            Bills.dgvBill.DataSource = dataSet.Tables("Bill").DefaultView

        Catch ex As SqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try
    End Sub

    Public Sub add_User(ByVal Name As String, ByVal Address As String, ByVal ContactNum As String, ByVal Username As String, ByVal Password As String)
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("INSERT INTO User VALUES(null, '" & Name & "', '" & Address & "', '" & ContactNum & "', '" & Username & "', '" & Password & "')", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "User")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try

    End Sub

    Public Sub edit_User(ByVal Name As String, ByVal Address As String, ByVal ContactNum As String, ByVal Username As String, ByVal Password As String, ByVal UserID As Integer)
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("UPDATE User SET Name = '" & Name & "', Address = '" & Address & "', ContactNum = '" & ContactNum & "', Username = '" & Username & "', Password = '" & Password & "' WHERE UserID = " & UserID & "", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "User")
        Catch ex As SqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try

    End Sub

    Public Sub delete_User(ByVal UserID As Integer)
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("DELETE FROM User WHERE UserID = " & UserID & "", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "User")
        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try

    End Sub

    Public Sub display_User()
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT UserID, Name, Address, ContactNum, Username, Password FROM User", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "User")
            User.dgvUser.DataSource = dataSet.Tables("User").DefaultView

        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try
    End Sub
    Public Function isRoomFull(ByVal roomid As Integer) As Boolean
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT COUNT(*) AS 'Tenant Count', Room.NumberOfPerson FROM Tenant INNER JOIN Room ON Room.RoomID = Tenant.RoomID WHERE Tenant.RoomID = '" & roomid & "' AND Tenant.Status = 'Active'", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Room")

            If dataSet.Tables("Room").Rows.Count > 0 Then
                Dim row = dataSet.Tables("Room").Rows(0)
                Dim tenantCount As Integer = CInt(row("Tenant Count"))
                Dim numberOfPerson As Integer = CInt(row("NumberOfPerson"))
                Return tenantCount >= numberOfPerson
            End If
        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try

        ' Return False in case of an error.
        Return False
    End Function

    Public Sub add_Tenant(ByVal FirstName As String, ByVal LastName As String, ByVal Gender As String, ByVal Address As String, ByVal ContactNum As String, ByVal DateLeased As String, ByVal Status As String, ByVal RoomID As Integer)
        Try
            SQLite_Open_Connection()
            Dim roomStatus As Boolean = isRoomFull(RoomID)

            If roomStatus Then
                MessageBox.Show("Cannot add tenant. The room is already full.")
            Else
                dataSet = New DataSet
                sqliteDataAdapter = New SQLiteDataAdapter("INSERT INTO Tenant VALUES(null, '" & FirstName & "', '" & LastName & "', '" & Gender & "', '" & Address & "', '" & ContactNum & "', '" & DateLeased & "', '" & Status & "', '" & RoomID & "')", sqliteConnection)
                sqliteDataAdapter.Fill(dataSet, "Tenant")
            End If
        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try
    End Sub

    Public Sub edit_Tenant(ByVal FirstName As String, ByVal LastName As String, ByVal Gender As String, ByVal Address As String, ByVal ContactNum As String, ByVal DateLeased As String, ByVal RoomID As Integer, ByVal TenandID As Integer)
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("UPDATE Tenant SET FirstName = '" & FirstName & "', LastName = '" & LastName & "', Gender = '" & Gender & "', Address = '" & Address & "', ContactNum = '" & ContactNum & "', DateLeased = '" & DateLeased & "', RoomID = '" & RoomID & "' WHERE TenandId = " & TenandID & "", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Tenant")
        Catch ex As SQLiteException
            MessageBox.Show("Error:   " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try

    End Sub

    Public Sub restore_Tenant(ByVal status As String, ByVal TenandID As Integer)
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("UPDATE Tenant SET  Status = '" & status & "' WHERE TenandId = " & TenandID & "", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Tenant")
        Catch ex As SQLiteException
            MessageBox.Show("Error:   " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try
    End Sub
    Public Sub delete_Tenant(ByVal TenantID As Integer)
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("UPDATE Tenant SET Status = 'Inactive' WHERE TenandID = " & TenantID & "", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Tenant")
        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try

    End Sub
    Public Sub display_Tenant()
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT * FROM Tenant WHERE Status = 'Active'", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Tenant")
            Tenant.dgvTenant.DataSource = dataSet.Tables("Tenant").DefaultView

        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try
    End Sub

    Public Sub display_TenantArchive()
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT * FROM Tenant WHERE Status = 'Inactive'", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Tenant")
            tenantArchive.dgvArchiveTenant.DataSource = dataSet.Tables("Tenant").DefaultView

        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try
    End Sub

    Public Sub add_TenantPay()

    End Sub

    Public Sub populate_cmbRoom()
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT RoomID, RoomName FROM Room", sqliteConnection)
            dataSet.Clear() ' Clear the DataSet to avoid duplicate data
            sqliteDataAdapter.Fill(dataSet, "Room")

            ' Bind the data to the ComboBox
            tenantAddForm.cmbRoom.DataSource = dataSet.Tables("Room")
            tenantAddForm.cmbRoom.DisplayMember = "RoomName"
            tenantAddForm.cmbRoom.ValueMember = "RoomID"
            tenantEditForm.cmbRoom.DataSource = dataSet.Tables("Room")
            tenantEditForm.cmbRoom.DisplayMember = "RoomName"
            tenantEditForm.cmbRoom.ValueMember = "RoomID"


        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try
    End Sub
    Public Sub add_Rooms(ByVal RoomName As String, ByVal MonthlyRent As Double, ByVal NumberOfPerson As Integer, ByVal Status As String)
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet

            sqliteDataAdapter = New SQLiteDataAdapter("INSERT INTO Room VALUES(null,'" & RoomName & "','" & MonthlyRent & "', '" & NumberOfPerson & "', '" & Status & "')", sqliteConnection)

            sqliteDataAdapter.Fill(dataSet, "Room")

            MessageBox.Show("Added.")

        Catch ex As SQLiteException

            MessageBox.Show("Error: " & ex.Message)

        Finally

            SQLite_Close_Connection()

        End Try

    End Sub

    Public Sub edit_Rooms(ByVal MonthlyRent As Double, ByVal NumberOfPerson As Integer, ByVal Status As String, ByVal RoomName As String)
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet

            sqliteDataAdapter = New SQLiteDataAdapter("UPDATE Room SET MonthlyRent = '" & MonthlyRent & "', NumberOfPerson = '" & NumberOfPerson & "', Status = '" & Status & "' WHERE RoomName = '" & RoomName & "'", sqliteConnection)

            sqliteDataAdapter.Fill(dataSet, "Room")

            MessageBox.Show("Edited.")

        Catch ex As SQLiteException

            MessageBox.Show("Error: " & ex.Message)

        Finally

            SQLite_Close_Connection()

        End Try
    End Sub
    Public Sub edit_Rooms_Status(ByVal status As String, ByVal RoomID As Integer)
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("UPDATE Room SET  Status = '" & status & "' WHERE RoomID = '" & RoomID & "'", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Room")

        Catch ex As SQLiteException

            MessageBox.Show("Error: " & ex.Message)

        Finally

            SQLite_Close_Connection()

        End Try
    End Sub
    Public Sub check_Occupant_Number(ByVal roomid As String)
        Dim status As String
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter(" Select COUNT(*) As 'Tenant Count', Room.NumberOfPerson From Tenant INNER Join Room ON Room.RoomID = Tenant.RoomID WHERE Tenant.RoomID ='" & roomid & "' AND Tenant.Status = 'Active'", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Room")
            If dataSet.Tables("Room").Rows.Count > 0 Then
                For Each row In dataSet.Tables("Room").Rows
                    Dim tenantCount As String = row("Tenant Count")
                    Dim numberOfPerson As String = row("NumberOfPerson")
                    If tenantCount >= numberOfPerson Then
                        status = "Full/Occupied"
                        edit_Rooms_Status(status, roomid)
                    Else
                        status = "Vacant"
                        edit_Rooms_Status(status, roomid)
                    End If
                Next
            End If

        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try
    End Sub




    Public Sub display_Rooms()
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT RoomName, Status FROM Room ", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Room")
            If dataSet.Tables("Room").Rows.Count > 0 Then
                For Each row In dataSet.Tables("Room").Rows
                    Dim roomName As String = row("RoomName").ToString()
                    Dim status As String = row("Status").ToString()
                    RoomPanels(roomName, status)

                Next
            End If

        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try
    End Sub

    Public Sub display_Room_info(ByVal roomName As String)
        Dim rowcount As Integer
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT * FROM Room WHERE RoomName Like '" & roomName & "' ", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Room")
            rowcount = dataSet.Tables(0).Rows.Count
            If dataSet.Tables("Room").Rows.Count > 0 Then
                Rooms.lblMonthlyRent.Text = dataSet.Tables(0).Rows(0).Item(2)
                Rooms.lblNumOccupants.Text = dataSet.Tables(0).Rows(0).Item(3)
                Rooms.lblStatus.Text = dataSet.Tables(0).Rows(0).Item(4)

                roomEditForm.txtRoomName.Text = dataSet.Tables(0).Rows(0).Item(1)
                roomEditForm.txtMonthlyRent.Text = dataSet.Tables(0).Rows(0).Item(2)
                roomEditForm.txtNumPerson.Text = dataSet.Tables(0).Rows(0).Item(3)
                roomEditForm.cmbRoomStatus.Text = dataSet.Tables(0).Rows(0).Item(4)
            End If


        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try
    End Sub

    Public Sub display_Room_Tenant(ByVal roomName As String)
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT FirstName || ' '|| LastName as 'Tenant Name' FROM Tenant WHERE RoomID = (SELECT RoomID FROM Room WHERE RoomName Like '" & roomName & "') AND Status = 'Active'", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Tenant")
            If dataSet.Tables("Tenant").Rows.Count > 0 Then
                For Each row In dataSet.Tables("Tenant").Rows
                    Dim tenantName As String = row("Tenant Name").ToString()
                    add_tenantName(tenantName)
                Next
            End If
        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try
    End Sub

    Private _CurrentContactLabelName As String = Nothing
    Public _ContactLabelsAddedCount As Integer = 0

    Public Sub add_tenantName(ByVal name As String)
        Dim tenantName As New Label()
        With tenantName
            .Name = (name).ToString
            .BackColor = Color.Transparent
            .Font = New Drawing.Font("Trebuchet MS", 12)
            .Text = (name).ToString
            .Size = New Size(160, 26)
            .Location = New Point(10, 10 + (_ContactLabelsAddedCount * 30)) ' Adjust the Y position for each label
        End With

        Rooms.tenantList.Controls.Add(tenantName)
        _ContactLabelsAddedCount += 1
    End Sub



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
        Rooms.lblRoomNumber.Text = panelName

        SelectedPanel = clickedPanel
    End Sub

    'creates room panel with labels and assigned background color based on room status(vacant, occupied)
    Private _CurrentContactPanelName As String = Nothing
    Private _ContactPanelsAddedCount As Integer = 0
    Public Sub RoomPanels(ByVal name As String, ByVal status As String)
        Dim roomPanel As Guna2Panel
        Dim roomNumber As Label

        roomPanel = New Guna2Panel()
        roomNumber = New Label()

        'room panel
        With roomPanel
            .Size = New Size(161, 110)
            .BorderRadius = 10
            .BackColor = Color.FromArgb(232, 232, 231)
            .Name = (name).ToString

            If status = "Full/Occupied" Then
                .Tag = Color.White
                .FillColor = Color.White
            ElseIf status = "Vacant" Then
                .Tag = Color.FromArgb(154, 154, 154)
                .FillColor = Color.FromArgb(154, 154, 154)
            End If
        End With

        'room label inside the room panel

        With roomNumber
            .Name = "RoomNumber"

            .BackColor = Color.Transparent
            .Location = New Point(44, 40)
            .Font = New Drawing.Font("Trebuchet MS", 12)
            'NOTE: change name to roomname(database)
            .Text = (name).ToString
        End With

        Rooms.addroompanel.Controls.Add(roomPanel)

        roomPanel.Controls.Add(roomNumber)

        _CurrentContactPanelName = roomPanel.Name
        _ContactPanelsAddedCount += 1
        AddHandler roomPanel.Click, AddressOf room_click

        AddHandler roomNumber.Click, AddressOf room_click

    End Sub

    'sidebar navigation panel change
    Public Sub changePanel(ByVal panels As Form)
        Home.panelHome.Controls.Clear()
        panels.TopLevel = False
        Home.panelHome.Controls.Add(panels)
        panels.Show()
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
    '--------------------------------

End Module
