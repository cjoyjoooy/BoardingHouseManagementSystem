Imports System.Windows.Controls
Imports Guna.UI2.WinForms

Public Class Home
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        changePanel(Dashboard)
        display_Recent_Transaction()
        display_dashboard_Earnigns()
        display_dashboard_Tenants()
        display_dashboard_Rooms()
    End Sub

    Private Sub btnTenant_Click(sender As Object, e As EventArgs) Handles btnTenant.Click
        changePanel(Tenant)
    End Sub

    Private Sub btnRoom_Click(sender As Object, e As EventArgs) Handles btnRoom.Click
        changePanel(Rooms)
        If Rooms.addroompanel IsNot Nothing Then
            Rooms.addroompanel.Controls.Clear()
            display_Rooms()

            Rooms.lblMonthlyRent.Text = "--"
            Rooms.lblNumOccupants.Text = "--"
            Rooms.lblStatus.Text = "--"
            Rooms.lblRoomNumber.Text = "--"
        End If
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        changePanel(Dashboard)
    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        changePanel(Transaction)
        display_Transaction()
    End Sub

    Private Sub btnBill_Click(sender As Object, e As EventArgs) Handles btnBill.Click
        changePanel(Bills)
        display_Bill()
    End Sub

    Private Sub btnEarnings_Click(sender As Object, e As EventArgs) Handles btnEarnings.Click
        changePanel(Earnings)
        display_Earnings()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        changePanel(User)
        display_User()
    End Sub
End Class