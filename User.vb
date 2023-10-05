﻿Imports System.Data.SQLite

Public Class User
    Private Sub btnAddUserForm_Click(sender As Object, e As EventArgs) Handles btnAddUserForm.Click
        userAddForm.Show()
    End Sub

    Private Sub btnUserBillForm_Click(sender As Object, e As EventArgs) Handles btnUserBillForm.Click
        Dim rowIndex As Integer
        rowIndex = dgvUser.CurrentRow.Index

        userEditForm.txtUserID.Text = dgvUser.Rows(rowIndex).Cells(0).Value.ToString
        userEditForm.txtName.Text = dgvUser.Rows(rowIndex).Cells(1).Value.ToString
        userEditForm.txtAddress.Text = dgvUser.Rows(rowIndex).Cells(2).Value.ToString
        userEditForm.txtContactNum.Text = dgvUser.Rows(rowIndex).Cells(3).Value.ToString
        userEditForm.txtUsername.Text = dgvUser.Rows(rowIndex).Cells(4).Value.ToString
        userEditForm.txtPassword.Text = dgvUser.Rows(rowIndex).Cells(5).Value.ToString

        userEditForm.Show()
    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_User()
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        Dim rowIndex As Integer
        Dim UserID As Integer
        rowIndex = dgvUser.CurrentRow.Index
        UserID = dgvUser.Rows(rowIndex).Cells(0).Value.ToString
        delete_User(UserID)
        display_User()
    End Sub

    Private Sub txtSearchUser_TextChanged(sender As Object, e As EventArgs) Handles txtSearchUser.TextChanged
        Dim search As String
        search = txtSearchUser.Text
        Search_Function(search, "UserID, Name, Address, ContactNum, Username", "User", "Name", Me.dgvUser)
    End Sub
End Class