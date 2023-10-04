Imports Guna.UI2.WinForms
Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Globalization
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel


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


    Public Sub add_Bill(ByVal ElectricityBill As Double, ByVal WaterBill As Double, ByVal MaintenanceBill As Double, ByVal MiscBill As Double, ByVal monthh As String)
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet

            sqliteDataAdapter = New SQLiteDataAdapter("INSERT INTO Bill VALUES('" & ElectricityBill & "','" & WaterBill & "', '" & MaintenanceBill & "', '" & MiscBill & "', '" & monthh & "')", sqliteConnection)
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
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT ElectricityBill, WaterBill, MaintenanceBill, MiscBill FROM Bill", sqliteConnection)
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
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT (SELECT COUNT(*) FROM Tenant WHERE RoomID = '" & roomid & "' AND Status = 'Active') AS 'Tenant Count', NumberOfPerson FROM Room WHERE RoomID = '" & roomid & "' ", sqliteConnection)
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

    Private Function GetExistingRoomID(ByVal TenandID As Integer) As Integer
        ' Implement a method to fetch the existing RoomID for the given TenandID
        ' This method should query the database and return the RoomID for the tenant.
        ' You may need to execute a SQL SELECT statement to retrieve this information.
        ' Return the RoomID as an Integer.
        ' If the tenant is not found or the RoomID cannot be determined, return an appropriate default value or handle the error as needed.
        Dim existingRoomID As Integer
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT RoomID FROM Tenant WHERE TenandId = " & TenandID & "", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Tenant")
            If dataSet.Tables("Tenant").Rows.Count > 0 Then
                ' Retrieve the RoomID from the result
                existingRoomID = Convert.ToInt32(dataSet.Tables("Tenant").Rows(0)("RoomID"))
            End If

            ' Return the result
            Return existingRoomID

        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try
    End Function

    Public Sub edit_Tenant(ByVal FirstName As String, ByVal LastName As String, ByVal Gender As String, ByVal Address As String, ByVal ContactNum As String, ByVal DateLeased As String, ByVal RoomID As Integer, ByVal TenandID As Integer)
        Try
            SQLite_Open_Connection()

            ' Check if the RoomID has changed
            Dim roomChanged As Boolean = (RoomID <> GetExistingRoomID(TenandID))

            If roomChanged Then
                ' Check if the new room is full
                Dim roomStatus As Boolean = isRoomFull(RoomID)

                If roomStatus Then
                    MessageBox.Show("Cannot Edit tenant. The room is already full.")
                    Exit Sub ' Exit the subroutine to prevent further processing
                End If
            End If

            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("UPDATE Tenant SET FirstName = '" & FirstName & "', LastName = '" & LastName & "', Gender = '" & Gender & "', Address = '" & Address & "', ContactNum = '" & ContactNum & "', DateLeased = '" & DateLeased & "', RoomID = '" & RoomID & "' WHERE TenandId = " & TenandID & "", sqliteConnection)

            ' Do not fill the DataSet; execute the update directly
            sqliteDataAdapter.Fill(dataSet, "Tenant")

        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try
    End Sub

    Public Sub restore_Tenant(ByVal status As String, ByVal TenandID As Integer)
        Try
            Dim rowIndex As Integer
            rowIndex = tenantArchive.dgvArchiveTenant.CurrentRow.Index
            Dim RoomId As Integer = tenantArchive.dgvArchiveTenant.Rows(rowIndex).Cells(8).Value.ToString
            Dim roomStatus As Boolean = isRoomFull(RoomId)
            SQLite_Open_Connection()
            If roomStatus Then
                MessageBox.Show("Cannot restore tenant. The room is already full.")
            Else
                dataSet = New DataSet
                sqliteDataAdapter = New SQLiteDataAdapter("UPDATE Tenant SET  Status = '" & status & "' WHERE TenandId = " & TenandID & "", sqliteConnection)
                sqliteDataAdapter.Fill(dataSet, "Tenant")
            End If
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

    Public Sub display_tenant_info()
        Dim name, fname, lname, gender, address, contact, status, room, dateleased, formattedDate As String
        Dim datevalue As DateTime
        Dim rowIndex As Integer
        Try
            rowIndex = Tenant.dgvTenant.CurrentRow.Index

            fname = Tenant.dgvTenant.Rows(rowIndex).Cells(1).Value.ToString
            lname = Tenant.dgvTenant.Rows(rowIndex).Cells(2).Value.ToString
            name = fname + " " + lname
            gender = Tenant.dgvTenant.Rows(rowIndex).Cells(3).Value.ToString
            address = Tenant.dgvTenant.Rows(rowIndex).Cells(4).Value.ToString
            contact = Tenant.dgvTenant.Rows(rowIndex).Cells(5).Value.ToString
            dateleased = Tenant.dgvTenant.Rows(rowIndex).Cells(6).Value.ToString
            status = Tenant.dgvTenant.Rows(rowIndex).Cells(7).Value.ToString
            room = Tenant.dgvTenant.Rows(rowIndex).Cells(8).Value.ToString

            If DateTime.TryParseExact(dateleased, "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, datevalue) Then
                formattedDate = datevalue.ToString("MM/dd/yyyy")
            ElseIf DateTime.TryParseExact(dateleased, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, datevalue) Then
                formattedDate = datevalue.ToString("MM/dd/yyyy")
            End If
            Tenant.lblTenantName.Text = name
            Tenant.lblTenantGender.Text = gender
            Tenant.lblTenantAddress.Text = address
            Tenant.lblTenantContact.Text = contact
            Tenant.lblTenantDateLeased.Text = formattedDate
            Tenant.lblTenantStatus.Text = status
            Tenant.lblTenantRoom.Text = room
        Catch ex As SQLiteException

        End Try

    End Sub

    Public Sub display_Tenant_Billing_info(ByVal TenantID As Integer)
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT t.DatePaid, r.MonthlyRent FROM 'Transaction' AS t INNER JOIN Tenant AS tn ON t.TenantID = tn.TenandID INNER JOIN Room AS r ON tn.RoomID = r.RoomID WHERE tn.TenandID = " & TenantID & " ORDER BY t.DatePaid DESC LIMIT 1;", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Transaction")

            ' Check if there are rows in the DataSet
            If dataSet.Tables("Transaction").Rows.Count > 0 Then
                ' Retrieve the values from the DataSet
                Dim row As DataRow = dataSet.Tables("Transaction").Rows(0)
                Dim lastPayment As Date = Convert.ToDateTime(row("DatePaid"))
                Dim monthlyRent As Decimal = Convert.ToDecimal(row("MonthlyRent"))

                ' Update the labels with the retrieved values
                Tenant.lblLastPayment.Text = lastPayment.ToString("MM/dd/yyyy")
                Tenant.lblAmountDue.Text = monthlyRent.ToString("0.00")


            Else
                ' Handle the case where no payment data was found
                Tenant.lblLastPayment.Text = "--"
                Tenant.lblAmountDue.Text = "--"
            End If
        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try
    End Sub

    Public Sub display_Transaction()
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT Tenant.FirstName || ' ' || Tenant.LastName AS 'Tenant Name', Transactions.DatePaid AS 'Date Paid', Transactions.AmountPaid AS 'Amount' FROM Tenant JOIN 'Transaction' AS Transactions ON Tenant.TenandID = Transactions.TenantID ORDER BY Transactions.DatePaid DESC;", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Transaction")
            Transaction.dgvTransaction.DataSource = dataSet.Tables("Transaction").DefaultView

        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try
    End Sub
    Public Sub display_Recent_Transaction()
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT Tenant.FirstName || ' ' || Tenant.LastName AS 'Tenant Name', Transactions.DatePaid AS 'Date Paid', Transactions.AmountPaid AS 'Amount' FROM Tenant JOIN 'Transaction' AS Transactions ON Tenant.TenandID = Transactions.TenantID ORDER BY Transactions.DatePaid DESC LIMIT 10", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Transaction")
            Dashboard.dgvRecentTransaction.DataSource = dataSet.Tables("Transaction").DefaultView

        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try
    End Sub

    Public Sub display_dashboard_Earnigns()
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT profit FROM ProfitSummary ORDER by month_year DESC LIMIT 1", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Transaction")

            If dataSet.Tables("Transaction").Rows.Count > 0 Then
                Dim row As DataRow = dataSet.Tables("Transaction").Rows(0)
                Dim profit As Double = Convert.ToDecimal(row("profit"))

                Dashboard.lblTotalEarnings.Text = profit.ToString()

            Else
                Dashboard.lblTotalEarnings.Text = "--"
            End If

        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try
    End Sub
    Public Sub display_dashboard_Tenants()
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT count(*) As 'NumberOfTenants'FROM Tenant WHERE Status = 'Active'", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Tenant")

            If dataSet.Tables("Tenant").Rows.Count > 0 Then
                Dim row As DataRow = dataSet.Tables("Tenant").Rows(0)
                Dim tenants As Double = Convert.ToDecimal(row("NumberOfTenants"))

                Dashboard.lblTotalTenants.Text = tenants.ToString()

            Else
                Dashboard.lblTotalTenants.Text = "--"
            End If

        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try
    End Sub
    Public Sub display_dashboard_Rooms()
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT count(*) As 'NumberOfRooms'FROM Room", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Tenant")

            If dataSet.Tables("Tenant").Rows.Count > 0 Then
                Dim row As DataRow = dataSet.Tables("Tenant").Rows(0)
                Dim rooms As Double = Convert.ToDecimal(row("NumberOfRooms"))

                Dashboard.lblTotalRooms.Text = rooms.ToString()

            Else
                Dashboard.lblTotalRooms.Text = "--"
            End If

        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try
    End Sub

    Public Sub profSummary()
        Try
            SQLite_Open_Connection()
            Dim profSummarysql As String = "REPLACE INTO ProfitSummary (
                                                month_year,          
                                                total_earnings,
                                                total_all_bills,
                                                profit
                                            )
                                            SELECT
                                                e.month_year,
                                                SUM(e.total_earnings) AS total_earnings,
                                                COALESCE(SUM(b.total_all_bills), 0) AS total_all_bills,
                                                SUM(e.total_earnings) - COALESCE(SUM(b.total_all_bills), 0) AS profit
                                            FROM TotalEarning e
                                            LEFT JOIN TotalBills b ON e.month_year = b.month_year
                                            GROUP BY e.month_year;"
            Using createTableCommand As New SQLiteCommand(profSummarysql, sqliteConnection)
                createTableCommand.ExecuteNonQuery()
            End Using

            'Insert the profit calculation results into the "ProfitSummary" table
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT * FROM ProfitSummary", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "ProfitSummary")
        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try

    End Sub
    Public Sub billSec()

        Try
            SQLite_Open_Connection()
            Dim totalBillingsql As String = "REPLACE INTO TotalBills (
                                                month_year,
                                                month_name,
                                                total_electricity_bill,
                                                total_water_bill,
                                                total_maintenance_bill,
                                                total_misc_bill,
                                                total_all_bills
                                            )
                                            SELECT strftime('%Y-%m', Month) AS month_year,
                                           CASE SUBSTR(strftime('%Y-%m-%d', Month), 6, 2)
                                               WHEN '01' THEN 'January'
                                               WHEN '02' THEN 'February'
                                               WHEN '03' THEN 'March'
                                               WHEN '04' THEN 'April'
                                               WHEN '05' THEN 'May'
                                               WHEN '06' THEN 'June'
                                               WHEN '07' THEN 'July'
                                               WHEN '08' THEN 'August'
                                               WHEN '09' THEN 'September'
                                               WHEN '10' THEN 'October'
                                               WHEN '11' THEN 'November'
                                               WHEN '12' THEN 'December'
                                               ELSE 'Invalid Month'
                                           END AS month_name,
                                           SUM(ElectricityBill) AS total_electricity_bill,
                                           SUM(WaterBill) AS total_water_bill,
                                           SUM(MaintenanceBill) AS total_maintenance_bill,
                                           SUM(MiscBill) AS total_misc_bill,
                                           SUM(ElectricityBill + WaterBill + MaintenanceBill + MiscBill) AS total_all_bills
                                    FROM Bill
                                    GROUP BY month_year, month_name
                                    ORDER BY month_year DESC;"
            Using createTableCommand As New SQLiteCommand(totalBillingsql, sqliteConnection)
                createTableCommand.ExecuteNonQuery()
            End Using

            ' Now, you can retrieve data from the "TotalBills" table if needed.
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT * FROM TotalBills", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "TotalBills")
        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try

    End Sub
    Public Sub earningsSec()
        Try
            SQLite_Open_Connection()
            Dim createTableSql As String = "REPLACE INTO TotalEarning (
                                                month_year,
                                                month_number,
                                                month_name,
                                                total_earnings
                                            )
                                        SELECT strftime('%Y-%m', DatePaid) AS month_year,
                                          SUBSTR(strftime('%Y-%m-%d', DatePaid), 6, 2) AS month_number,
                                          CASE SUBSTR(strftime('%Y-%m-%d', DatePaid), 6, 2)
                                              WHEN '01' THEN 'January'
                                              WHEN '02' THEN 'February'
                                              WHEN '03' THEN 'March'
                                              WHEN '04' THEN 'April'
                                              WHEN '05' THEN 'May'
                                              WHEN '06' THEN 'June'
                                              WHEN '07' THEN 'July'
                                              WHEN '08' THEN 'August'
                                              WHEN '09' THEN 'September'
                                              WHEN '10' THEN 'October'
                                              WHEN '11' THEN 'November'
                                              WHEN '12' THEN 'December'
                                              ELSE 'Invalid Month'
                                          END AS month_name,
                                          SUM(AmountPaid) AS total_earnings
                                   FROM ""Transaction""
                                   GROUP BY month_year, month_name
                                   ORDER BY month_year ASC;"
            Using createTableCommand As New SQLiteCommand(createTableSql, sqliteConnection)
                createTableCommand.ExecuteNonQuery()
            End Using

            ' Now, you can retrieve data from the "TotalEarning" table if needed.
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT * FROM TotalEarning", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "TotalEarning")
        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try


    End Sub
    Public Sub transactionPaid(ByVal amountPaid As Integer, ByVal tenantID As String, ByVal dateNow As String)


        'Try
        'SQLite_Open_Connection()
        'dataSet = New DataSet
        'sqliteDataAdapter = New SQLiteDataAdapter("INSERT INTO ""Transaction"" VALUES(null, '" & amountPaid & "', '" & dateNow & "' , '" & tenantID & "', (SELECT last_insert_rowid() FROM Earning) ')", sqliteConnection)
        'sqliteDataAdapter.Fill(dataSet, "Transaction")
        'Catch ex As Exception
        'MessageBox.Show("Error: " & ex.Message)
        'Finally

        'SQLite_Close_Connection()
        'End Try
        Try
            SQLite_Open_Connection()
            Dim sql As String = "INSERT INTO ""Transaction"" VALUES(null, @amountPaid, @dateNow, @tenantID)"
            sqliteDataAdapter = New SQLiteDataAdapter(sql, sqliteConnection)
            sqliteDataAdapter.SelectCommand.Parameters.AddWithValue("@amountPaid", amountPaid)
            sqliteDataAdapter.SelectCommand.Parameters.AddWithValue("@dateNow", dateNow)
            sqliteDataAdapter.SelectCommand.Parameters.AddWithValue("@tenantID", tenantID)
            dataSet = New DataSet
            sqliteDataAdapter.Fill(dataSet, "Transaction")
        Catch ex As SQLiteException
            ' Handle the exception here (e.g., log it, display an error message).
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

    Public Function isRoomFullEdit(ByVal roomName As String) As Boolean
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT (SELECT COUNT(*) FROM Tenant WHERE RoomID = (SELECT RoomID FROM Room WHERE RoomName Like '" & roomName & "') AND Status = 'Active') AS 'Tenant Count', NumberOfPerson FROM Room WHERE RoomID = (SELECT RoomID FROM Room WHERE RoomName Like '" & roomName & "')", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Room")
            If dataSet.Tables("Room").Rows.Count > 0 Then
                Dim row = dataSet.Tables("Room").Rows(0)
                Dim tenantCount As Integer = CInt(row("Tenant Count"))
                Dim numberOfPerson As Integer = Integer.Parse(roomEditForm.txtNumPerson.Text)
                Return numberOfPerson < tenantCount
            End If
        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLite_Close_Connection()
        End Try

        ' Return False in case of an error.
        Return False
    End Function

    Public Sub check_Occupant_Number_Edit(ByVal roomName As String)
        Dim status As String
        Try
            SQLite_Open_Connection()
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT RoomID, (SELECT COUNT(*) FROM Tenant WHERE RoomID = (SELECT RoomID FROM Room WHERE RoomName Like '" & roomName & "') AND Status = 'Active') AS 'Tenant Count', NumberOfPerson FROM Room WHERE RoomID = (SELECT RoomID FROM Room WHERE RoomName Like '" & roomName & "')", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "Room")
            If dataSet.Tables("Room").Rows.Count > 0 Then
                For Each row In dataSet.Tables("Room").Rows
                    Dim tenantCount As String = row("Tenant Count")
                    Dim numberOfPerson As String = row("NumberOfPerson")
                    Dim roomId As Integer = row("RoomID")
                    If tenantCount >= numberOfPerson Then
                        status = "Full/Occupied"
                        edit_Rooms_Status(status, roomId)
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



    Public Sub edit_Rooms(ByVal Name As String, ByVal MonthlyRent As Double, ByVal NumberOfPerson As Integer, ByVal RoomName As String)
        Try
            SQLite_Open_Connection()
            Dim roomStatus As Boolean = isRoomFullEdit(RoomName)

            If roomStatus Then
                MessageBox.Show("Cannot Edit Room. Number of current occupants is greater than the new set number.")
            Else

                dataSet = New DataSet

                sqliteDataAdapter = New SQLiteDataAdapter("UPDATE Room SET RoomName = '" & Name & "', MonthlyRent = '" & MonthlyRent & "', NumberOfPerson = '" & NumberOfPerson & "' WHERE RoomName = '" & RoomName & "'", sqliteConnection)

                sqliteDataAdapter.Fill(dataSet, "Room")

                MessageBox.Show("Edited.")
            End If

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
            sqliteDataAdapter = New SQLiteDataAdapter("SELECT (SELECT COUNT(*) FROM Tenant WHERE RoomID = '" & roomid & "' AND Status = 'Active') AS 'Tenant Count', NumberOfPerson FROM Room WHERE RoomID = '" & roomid & "' ", sqliteConnection)
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

                roomEditForm.lblRoomName.Text = dataSet.Tables(0).Rows(0).Item(1)
                roomEditForm.txtRoomName.Text = dataSet.Tables(0).Rows(0).Item(1)
                roomEditForm.txtMonthlyRent.Text = dataSet.Tables(0).Rows(0).Item(2)
                roomEditForm.txtNumPerson.Text = dataSet.Tables(0).Rows(0).Item(3)

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
