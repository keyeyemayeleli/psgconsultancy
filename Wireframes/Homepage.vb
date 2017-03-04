﻿Imports System.Data.SqlClient
Imports System.Data.Common

Public Class Homepage



    Private Sub Homepage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        currentuser_label.Text = User

        Dim connectionString As String = "Data Source=DESKTOP-2J5TEUE\SQLEXPRESS;Database=201File;Integrated Security=True"
        Dim sql As String = "SELECT logs.time_stamp, logs.activity_name, accounts.username FROM logs JOIN accounts ON logs.account_id = accounts.account_id"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()

        connection.Open()
        dataadapter.Fill(ds, "logs")

        connection.Close()
        activityDGV.DataSource = ds
        activityDGV.DataMember = "logs"
        activityDGV.Columns("activity_name").HeaderCell.Value = "Activity"
        activityDGV.Columns("time_stamp").HeaderCell.Value = "Date"
        activityDGV.Columns("username").HeaderCell.Value = "User"
        activityDGV.Columns("activity_name").Width = 420
        activityDGV.Columns("username").Width = 200
        activityDGV.Columns("time_stamp").Width = 140

        Me.DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MMMM d, yyyy"

    End Sub

    Private Sub activityDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles activityDGV.CellContentClick

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click, currentuser_label.Click

    End Sub

    Private Sub manageButton_Click(sender As Object, e As EventArgs) Handles manageButton.Click
        ManageEmployees.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        ManageTerminatedEmployees.Show()
    End Sub

    Private Sub masterlistButton_Click(sender As Object, e As EventArgs) Handles masterlistButton.Click
        Me.Hide()
        Masterlist.Show()
    End Sub

    Private Sub accountingButton_Click(sender As Object, e As EventArgs) Handles accountingButton.Click
        Me.Hide()
        Accounting.Show()
    End Sub

    Private Sub customizableButton_Click(sender As Object, e As EventArgs) Handles customizableButton.Click
        Me.Hide()
        CustomizedReport.Show()
    End Sub

    Private Sub editpasswordButton_Click(sender As Object, e As EventArgs) Handles editpasswordButton.Click
        Me.Hide()
        EditPassword.Show()
    End Sub

    Private Sub logoutButton_Click(sender As Object, e As EventArgs) Handles logoutButton.Click
        If MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            User = ""
            Me.Hide()
            Login.Show()
        End If
    End Sub
End Class
