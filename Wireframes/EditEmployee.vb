Imports System.Data.SqlClient
Imports System.Data.Common
Public Class EditEmployee

    Private Sub EditEmployee_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.birthdayDate.Format = DateTimePickerFormat.Custom
        birthdayDate.CustomFormat = "MMMM d, yyyy"

        Me.spousebdayDate.Format = DateTimePickerFormat.Custom
        spousebdayDate.CustomFormat = "MMMM d, yyyy"

        Me.childbdayDateone.Format = DateTimePickerFormat.Custom
        childbdayDateone.CustomFormat = "MMMM d, yyyy"

        Me.childbdayDatetwo.Format = DateTimePickerFormat.Custom
        childbdayDatetwo.CustomFormat = "MMMM d, yyyy"

        Me.childbdayDatethree.Format = DateTimePickerFormat.Custom
        childbdayDatethree.CustomFormat = "MMMM d, yyyy"

        Me.childbdayDatefour.Format = DateTimePickerFormat.Custom
        childbdayDatefour.CustomFormat = "MMMM d, yyyy"

        Me.datehiredDate.Format = DateTimePickerFormat.Custom
        datehiredDate.CustomFormat = "MMMM d, yyyy"

        Me.beneficiarybdayDateone.Format = DateTimePickerFormat.Custom
        beneficiarybdayDateone.CustomFormat = "MMMM d, yyyy"

        Me.beneficiarybdayDatetwo.Format = DateTimePickerFormat.Custom
        beneficiarybdayDatetwo.CustomFormat = "MMMM d, yyyy"

        Me.beneficiarybdayDatethree.Format = DateTimePickerFormat.Custom
        beneficiarybdayDatethree.CustomFormat = "MMMM d, yyyy"

        Me.beneficiarybdayDatefour.Format = DateTimePickerFormat.Custom
        beneficiarybdayDatefour.CustomFormat = "MMMM d, yyyy"

        Me.nextofkinbdayDate.Format = DateTimePickerFormat.Custom
        nextofkinbdayDate.CustomFormat = "MMMM d, yyyy"

        Me.statusdateDate.Format = DateTimePickerFormat.Custom
        statusdateDate.CustomFormat = "MMMM d, yyyy"


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
                lastnameText.Text = dt.Rows(0)("last_name").ToString
                givennameText.Text = dt.Rows(0)("first_name").ToString
                middlenameText.Text = dt.Rows(0)("middle_name").ToString
                employeenumberText.Text = dt.Rows(0)("employee_id").ToString
                statusCombobox.Text = dt.Rows(0)("status").ToString
                birthplaceText.Text = dt.Rows(0)("birth_place").ToString
                birthdayDate.Value = dt.Rows(0)("birthday")
                civilstatusCombobox.Text = dt.Rows(0)("civil_status").ToString
                presentaddressText.Text = dt.Rows(0)("present_address").ToString
                permanentaddressText.Text = dt.Rows(0)("permanent_address").ToString
                emailaddressText.Text = dt.Rows(0)("email").ToString
                contactnumberText.Text = dt.Rows(0)("contact_number").ToString
                telephonenumberText.Text = dt.Rows(0)("telephone_number").ToString
                fathersnameText.Text = dt.Rows(0)("fathers_name").ToString
                mothersnameText.Text = dt.Rows(0)("mothers_name").ToString
                spousenameText.Text = dt.Rows(0)("spouse_name").ToString
                spousebdayDate.Value = dt.Rows(0)("spouse_birthday")
                datehiredDate.Value = dt.Rows(0)("date_hired")
                groupText.Text = dt.Rows(0)("company_group").ToString
                departmentText.Text = dt.Rows(0)("department").ToString
                positionText.Text = dt.Rows(0)("position").ToString
                rankText.Text = dt.Rows(0)("rank").ToString
                statusreasonText.Text = dt.Rows(0)("status_reason").ToString
                statusdateDate.Value = dt.Rows(0)("statusreason_date")
                tinnumberText.Text = dt.Rows(0)("tin_number").ToString
                sssnumberText.Text = dt.Rows(0)("sss_number").ToString
                philhealthnumberText.Text = dt.Rows(0)("philhealth_number").ToString
                pagibignumberText.Text = dt.Rows(0)("pagibig_number").ToString
                rtnText.Text = dt.Rows(0)("RTN").ToString
                hdmfnumberText.Text = dt.Rows(0)("HDMF_MID_number").ToString
            End If
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Error while connecting to database" & ex.Message)
        End Try


        statusreasonText.Watermark = "Reason for " & statusCombobox.GetItemText(statusCombobox.SelectedItem) & ""
        statusdateLabel.Text = "" & statusCombobox.GetItemText(statusCombobox.SelectedItem) & " Date:"

    End Sub



    Private Sub statusCombobox_SelectedValueChanged(sender As Object, e As EventArgs) Handles statusCombobox.SelectedValueChanged
        statusreasonText.Watermark = "Reason for " & statusCombobox.GetItemText(statusCombobox.SelectedItem) & "  Status"
        statusdateLabel.Text = "" & statusCombobox.GetItemText(statusCombobox.SelectedItem) & " Date:"
    End Sub
End Class
