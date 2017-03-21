Imports System.Data.SqlClient
Public Class EvaluationsForm
    Private Sub EvaluationsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable()

        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim sqlCmd As New SqlCommand("SELECT * FROM employee201files WHERE employee_id = @eid", connection)
        Dim dataadapter As New SqlDataAdapter(sqlCmd)

        sqlCmd.Parameters.AddWithValue("@eid", Employee)
        dataadapter.Fill(dt)
        If dt.Rows.Count > 0 Then
            employeenumberlabel.Text = dt.Rows(0)("employee_id").ToString
            employeenamelabel.Text = dt.Rows(0)("first_name").ToString + " " + dt.Rows(0)("middle_name").ToString + " " + dt.Rows(0)("last_name").ToString
            If EvalNum!= -1 Then

            End If
        End If

        evaluationtypelabel.Text = Evaltype

    End Sub

    Private Sub evalsavebutton_Click(sender As Object, e As EventArgs) Handles evalsavebutton.Click
        If EvalNum = -1 Then
            Dim sql As String = "INSERT INTO employee_ym_evals (employee_id, score, date, status, remarks) VALUES (@empid, @score, @date, @status, @remark)"

            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand()
                    With cmd
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = sql
                        .Parameters.AddWithValue("empid", Employee)
                        .Parameters.AddWithValue("status", evaluationtypelabel.Text)
                        .Parameters.AddWithValue("score", evalscoretext.Text)
                        .Parameters.AddWithValue("remark", evalremarkstext.Text)
                        .Parameters.AddWithValue("date", evaldateText.Text)
                    End With
                    Try
                        conn.Open()
                        cmd.ExecuteNonQuery()
                        cmd.Parameters.Clear()
                        Evaltype = ""
                        EvalNum = 0
                        MessageBox.Show("Evaluation successfully added", "Evaluations", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message.ToString(), "Error Message")
                    End Try
                End Using
            End Using

        ElseIf EvalNum > 0 Then
            Dim sql2 As String = "UPDATE employee_ym_evals SET score= @score, remarks= @remark, date= @date WHERE eval_id= @evid"

            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand()
                    With cmd
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = sql2
                        .Parameters.AddWithValue("evid", EvalNum)
                        .Parameters.AddWithValue("score", evalscoretext.Text)
                        .Parameters.AddWithValue("remark", evalremarkstext.Text)
                        .Parameters.AddWithValue("date", evaldateText.Text)
                    End With
                    Try
                        conn.Open()
                        cmd.ExecuteNonQuery()
                        cmd.Parameters.Clear()
                        Evaltype = ""
                        EvalNum = 0
                        MessageBox.Show("Evaluation successfully edited", "Evaluations", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message.ToString(), "Error Message")
                    End Try
                End Using
            End Using
        End If


    End Sub


End Class