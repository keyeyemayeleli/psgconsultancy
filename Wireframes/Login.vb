Imports System.Data
Imports System.Data.SqlClient

Public Class Login

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim cmd2 As New SqlCommand

    Private Sub exitButton_Click(sender As System.Object, e As System.EventArgs) Handles exitButton.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If


    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub loginButton_Click_1(sender As Object, e As EventArgs) Handles loginButton.Click

        Try
            Dim strResult As String
            con.ConnectionString = connectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM accounts WHERE username = @user  AND password = @pass "
            cmd.Parameters.Add(New SqlParameter("user", userText.Text))
            cmd.Parameters.Add(New SqlParameter("pass", passwordText.Text))

            Try
                strResult = cmd.ExecuteScalar
            Catch ex As Exception
                strResult = ""
            End Try

            If strResult = "" Then
                MessageBox.Show("Username and Password is not valid", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cmd.Parameters.Clear()
            Else
                MessageBox.Show("Logged in successfully as " & userText.Text & "", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                User = userText.Text
                cmd.Parameters.Clear()

                Dim strResult2 As String

                cmd2.Connection = con
                cmd2.CommandText = "SELECT account_id FROM accounts WHERE username = @user "
                cmd2.Parameters.Add(New SqlParameter("user", User))
                Try
                    strResult2 = cmd2.ExecuteScalar
                    UserID = strResult2
                Catch ex As Exception
                    strResult2 = ""
                End Try
                con.Close()
                cmd.Parameters.Clear()
                cmd2.Parameters.Clear()
                userText.Clear()
                passwordText.Clear()
                Homepage.Show()
                Me.Hide()
            End If

        Catch ex As Exception
            MessageBox.Show("Error while connecting to server " & ex.Message)

        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

