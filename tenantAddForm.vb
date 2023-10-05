Public Class tenantAddForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddTenant_Click(sender As Object, e As EventArgs) Handles btnAddTenant.Click
        'Dim fname, lname, gender, address, contact, lease As String
        'Dim room As Integer

        'fname = txtFname.Text
        'lname = txtLname.Text
        'gender = cmbGender.SelectedItem
        'address = txtAddress.Text
        'contact = txtContact.Text
        'room = CInt(cmbRoom.SelectedValue)
        'lease = dtpLease.Value

        'add_Tenant(fname, lname, gender, address, contact, lease, "Active", room)
        'check_Occupant_Number(room)
        'If Rooms.addroompanel IsNot Nothing Then
        'Rooms.addroompanel.Controls.Clear()
        'display_Rooms()
        'Rooms.lblMonthlyRent.Text = "--"
        'Rooms.lblNumOccupants.Text = "--"
        'Rooms.lblStatus.Text = "--"
        'Rooms.lblRoomNumber.Text = "--"
        'End If
        'display_Tenant()


        Try
            Dim fname, lname, gender, address, contact, lease As String
            Dim room As Integer

            fname = txtFname.Text
            lname = txtLname.Text
            gender = cmbGender.SelectedItem
            address = txtAddress.Text
            contact = txtContact.Text

            ' Check if the lease date is selected and convert it to a string.
            If dtpLease.Value <> DateTimePicker.MinimumDateTime Then
                lease = dtpLease.Value.ToString("yyyy-MM-dd")
            Else
                MessageBox.Show("Lease date is not selected. Please select a lease date.")
                Return ' Exit the event handler.
            End If

            ' Check if the room selection is valid.
            If cmbRoom.SelectedIndex = -1 OrElse Not Integer.TryParse(cmbRoom.SelectedValue.ToString(), room) Then
                MessageBox.Show("Invalid or empty room selection. Please select a valid room.")
                Return ' Exit the event handler.
            End If

            ' Rest of your code here...
            If String.IsNullOrEmpty(fname) Then
                MessageBox.Show("Some fields are empty! Please try again")
                Return
            ElseIf String.IsNullOrEmpty(lname) Then
                MessageBox.Show("Some fields are empty! Please try again")
                Return
            ElseIf String.IsNullOrEmpty(gender) Then
                MessageBox.Show("Some fields are empty! Please try again")
                Return
            ElseIf String.IsNullOrEmpty(address) Then
                MessageBox.Show("Some fields are empty! Please try again")
                Return
            ElseIf String.IsNullOrEmpty(contact) Then
                MessageBox.Show("Some fields are empty! Please try again")
                Return
            ElseIf String.IsNullOrEmpty(lease) Then
                MessageBox.Show("Some fields are empty! Please try again")
                Return

            Else
                add_Tenant(fname, lname, gender, address, contact, lease, "Active", room)
                check_Occupant_Number(room)
                If Rooms.addroompanel IsNot Nothing Then
                    Rooms.addroompanel.Controls.Clear()
                    display_Rooms()
                    Rooms.lblMonthlyRent.Text = "--"
                    Rooms.lblNumOccupants.Text = "--"
                    Rooms.lblStatus.Text = "--"
                    Rooms.lblRoomNumber.Text = "--"
                End If
                display_Tenant()
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
        Me.Close()
    End Sub

End Class