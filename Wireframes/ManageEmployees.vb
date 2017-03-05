Imports System.Data.SqlClient
Imports System.Data.Common

Public Class ManageEmployees
    Private Sub ManageEmployees_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MMMM d, yyyy"

        Dim connectionString As String = "Data Source=DESKTOP-2J5TEUE\SQLEXPRESS;Database=201File;Integrated Security=True"
        Dim sql As String = "SELECT last_name, first_name, middle_name FROM employee201files"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()

        connection.Open()
        dataadapter.Fill(ds, "employee201files")

        connection.Close()
        manageemployeesDGV.DataSource = ds
        manageemployeesDGV.DataMember = "employee201files"
        manageemployeesDGV.Columns("last_name").HeaderCell.Value = "Last name"
        manageemployeesDGV.Columns("first_name").HeaderCell.Value = "First name"
        manageemployeesDGV.Columns("middle_name").HeaderCell.Value = "Middle name"
        manageemployeesDGV.Columns("last_name").Width = 420
        manageemployeesDGV.Columns("first_name").Width = 200
        manageemployeesDGV.Columns("middle_name").Width = 140
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


End Class
