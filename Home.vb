Imports System.Windows.Controls

Public Class Home

    Public Sub changePanel(ByVal panels As Form)
        panelHome.Controls.Clear()
        panels.TopLevel = False
        panelHome.Controls.Add(panels)
        panels.Show()
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        changePanel(Dashboard)
    End Sub

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
End Class