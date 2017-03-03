Imports System.Data
Imports System.Data.SqlClient




Public Class Login

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand



    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=DESKTOP-2J5TEUE\SQLEXPRESS;Initial Catalog=201File;Integrated Security=True"
        con.Open()

    End Sub


    Private Sub exitButton_Click(sender As System.Object, e As System.EventArgs) Handles exitButton.Click



    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs)

    End Sub

End Class

