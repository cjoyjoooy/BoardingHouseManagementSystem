Imports System.Windows.Controls

Public Class tenantEditForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnEditTenant_Click(sender As Object, e As EventArgs) Handles btnEditTenant.Click
        Try
            Dim FirstName, LastName, Gender, Address, ContactNum, DateLeased As String
            Dim RoomID, TenandID, checkroomId, rowIndex As Integer

            rowIndex = Tenant.dgvTenant.CurrentRow.Index


            FirstName = txtFname.Text
            LastName = txtLname.Text
            Gender = cmbGender.Text
            Address = txtAddress.Text
            ContactNum = txtContact.Text
            DateLeased = dtpDate.Value
            RoomID = Integer.Parse(cmbRoom.SelectedValue.ToString())
            TenandID = Integer.Parse(txtTenandID.Text)

            If String.IsNullOrEmpty(FirstName) Then
                MessageBox.Show("Some fields are empty! Please try again")
                Return
            ElseIf String.IsNullOrEmpty(LastName) Then
                MessageBox.Show("Some fields are empty! Please try again")
                Return
            ElseIf String.IsNullOrEmpty(Gender) Then
                MessageBox.Show("Some fields are empty! Please try again")
                Return
            ElseIf String.IsNullOrEmpty(Address) Then
                MessageBox.Show("Some fields are empty! Please try again")
                Return
            ElseIf String.IsNullOrEmpty(ContactNum) Then
                MessageBox.Show("Some fields are empty! Please try again")
                Return
            Else
                edit_Tenant(FirstName, LastName, Gender, Address, ContactNum, DateLeased, RoomID, TenandID)
                check_Occupant_Number(checkroomId)
                check_Occupant_Number(RoomID)
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