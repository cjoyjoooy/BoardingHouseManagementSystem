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
    End Sub

    Private Sub btnTenant_Click(sender As Object, e As EventArgs) Handles btnTenant.Click
        changePanel(Tenant)
    End Sub

    Private Sub btnRoom_Click(sender As Object, e As EventArgs) Handles btnRoom.Click
        changePanel(Rooms)
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load
        changePanel(Dashboard)

    End Sub


End Class