Imports System.Data.SqlClient
Imports System.Data.Common

Public Class ManageEmployees
    Private Sub ManageEmployees_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MMMM d, yyyy"

        Try
            Dim connectionString As String = "Data Source=HP\SQLEXPRESS;Database=201File;Integrated Security=True"
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
            MessageBox.Show(Employee)
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
