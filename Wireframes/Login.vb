Imports System.Data
Imports System.Data.SqlClient




Public Class Login

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand



    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load




    End Sub


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
            con.ConnectionString = "Data Source=DESKTOP-2J5TEUE\SQLEXPRESS;Database=201File;Integrated Security=True"
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
                Homepage.Show()
                Me.Hide()
            End If

        Catch ex As Exception
            MessageBox.Show("Error while connecting to server" & ex.Message)

        Finally
            con.Close()
        End Try
    End Sub
End Class

