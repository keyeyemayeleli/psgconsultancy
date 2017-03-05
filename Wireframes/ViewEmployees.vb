Imports System.Data.SqlClient
Imports System.Data.Common
Public Class ViewEmployees
    Private Sub ViewEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim dt As New DataTable()
            Dim connectionString As String = "Data Source=DESKTOP-2J5TEUE\SQLEXPRESS;Database=201File;Integrated Security=True"
            Dim connection As New SqlConnection(connectionString)
            connection.Open()
            Dim sqlCmd As New SqlCommand("SELECT * FROM employee201files WHERE employee_ID = @eid", connection)
            Dim dataadapter As New SqlDataAdapter(sqlCmd)

            sqlCmd.Parameters.AddWithValue("@eid", Employee)
            dataadapter.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim lname As String = dt.Rows(0)("last_name").ToString
                Dim fname As String = dt.Rows(0)("first_name").ToString
                Dim mname As String = dt.Rows(0)("middle_name").ToString
                nameLabel.Text = lname + ", " & fname & " " & mname
                employeenumberLabel.Text = dt.Rows(0)("employee_id").ToString
                statusLabel.Text = dt.Rows(0)("status").ToString
                birthplaceLabel.Text = dt.Rows(0)("birth_place").ToString
                bdayLabel.Text = dt.Rows(0)("birthday").ToString
                civilstatusLabel.Text = dt.Rows(0)("civil_status").ToString
                presentaddressLabel.Text = dt.Rows(0)("present_address").ToString
                permanentaddressLabel.Text = dt.Rows(0)("permanent_address").ToString
                emailaddressLabel.Text = dt.Rows(0)("email").ToString
                contactnumberLabel.Text = dt.Rows(0)("contact_number").ToString
                telephonenumberLabel.Text = dt.Rows(0)("telephone_number").ToString
                fathernameLabel.Text = dt.Rows(0)("fathers_name").ToString
                mothernameLabel.Text = dt.Rows(0)("mothers_name").ToString
                spousenameLabel.Text = dt.Rows(0)("spouse_name").ToString
                spousebdayLabel.Text = dt.Rows(0)("spouse_birthday").ToString
                datehiredLabel.Text = dt.Rows(0)("date_hired").ToString
                groupLabel.Text = dt.Rows(0)("company_group").ToString
                departmentLabel.Text = dt.Rows(0)("department").ToString
                positionLabel.Text = dt.Rows(0)("position").ToString
                rankLabel.Text = dt.Rows(0)("rank").ToString
                statusreasonLabel.Text = dt.Rows(0)("status_reason").ToString
                statusdateLabel.Text = dt.Rows(0)("statusreason_date").ToString
                tinnumberLabel.Text = dt.Rows(0)("tin_number").ToString
                sssnumberLabel.Text = dt.Rows(0)("sss_number").ToString
                philhealthnumberLabel.Text = dt.Rows(0)("philhealth_number").ToString
                pagibignumberLabel.Text = dt.Rows(0)("pagibig_number").ToString
                rtnLabel.Text = dt.Rows(0)("RTN").ToString
                hdmfnumberLabel.Text = dt.Rows(0)("HDMF_MID_number").ToString
            End If
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Error while connecting to database" & ex.Message)
        End Try


    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Employee = Nothing
        Me.Close()
        ManageEmployees.Show()

    End Sub
End Class
