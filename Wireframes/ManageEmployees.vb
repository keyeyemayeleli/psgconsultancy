﻿Imports System.Data.SqlClient
Imports System.Data.Common

Public Class ManageEmployees
    Private Sub ManageEmployees_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MMMM d, yyyy"

        Try

            Dim sql As String = "SELECT employee_id, last_name, first_name, middle_name FROM employee201files"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()

            connection.Open()
            dataadapter.Fill(ds, "employee201files")

            connection.Close()
            manageemployeesDGV.DataSource = ds
            manageemployeesDGV.DataMember = "employee201files"
            manageemployeesDGV.Columns("employee_id").HeaderCell.Value = "Employee ID"
            manageemployeesDGV.Columns("last_name").HeaderCell.Value = "Last name"
            manageemployeesDGV.Columns("first_name").HeaderCell.Value = "First name"
            manageemployeesDGV.Columns("middle_name").HeaderCell.Value = "Middle name"
            manageemployeesDGV.Columns("last_name").Width = 420
            manageemployeesDGV.Columns("first_name").Width = 200
            manageemployeesDGV.Columns("middle_name").Width = 140
        Catch ex As Exception
            MessageBox.Show("Error while connecting to server " & ex.Message)
        End Try

    End Sub

    Private Sub backButton_Click(sender As System.Object, e As System.EventArgs) Handles backButton.Click

        Close()
        Homepage.Show()

    End Sub

    Private Sub createButton_Click(sender As System.Object, e As System.EventArgs) Handles createButton.Click

        Dim NewForm As CreateEmployee201
        NewForm = New CreateEmployee201()
        NewForm.Show()
        NewForm = Nothing
        Me.Close()

    End Sub

    Private Sub viewEmployee_Click(sender As Object, e As EventArgs) Handles viewEmployee.Click
        If manageemployeesDGV.SelectedRows.Count() = 1 Then
            Employee = manageemployeesDGV.SelectedRows(0).Cells(0).Value.ToString

            Dim datenow As DateTime = DateTime.Now
            Dim datestr As String = datenow.ToString("yyyy-MM-dd HH:mm:ss")
            Dim sql5 As String = "INSERT INTO logs (time_stamp, activity_name, account_id) VALUES (@time, @actname, @accid)"
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand()
                    With cmd
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = sql5
                        .Parameters.AddWithValue("time", datestr)
                        .Parameters.AddWithValue("actname", "Viewed 201 file of " + manageemployeesDGV.SelectedRows(0).Cells(1).Value.ToString + ", " + manageemployeesDGV.SelectedRows(0).Cells(2).Value.ToString + " " + manageemployeesDGV.SelectedRows(0).Cells(3).Value.ToString)
                        .Parameters.AddWithValue("accid", UserID)
                    End With

                    Try
                        conn.Open()
                        cmd.ExecuteNonQuery()
                        cmd.Parameters.Clear()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message.ToString(), "Error Message")
                    End Try
                End Using
            End Using

            Dim NewForm As ViewEmployees
            NewForm = New ViewEmployees()
            NewForm.Show()
            NewForm = Nothing
            Me.Close()
        Else
            MessageBox.Show("You need to select one record.", "View Employee Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub searchButton_Click(sender As System.Object, e As System.EventArgs) Handles searchButton.Click



    End Sub
End Class
