Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop


Public Class Reports

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub Reports_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            Dim connectionString As String = "Data Source=HP\SQLEXPRESS;Database=201File;Integrated Security=True"
            Dim sql As String = "SELECT employee_id, last_name, first_name, middle_name, tin_number, sss_number, philhealth_number, pagibig_number, RTN, HDMF_MID_number, date_hired, company_group, department, position, rank, birthday, birth_place, civil_status, present_address, email, contact_number, telephone_number, fathers_name, mothers_name, spouse_name, spouse_birthday FROM employee201files"
            'Dim sql As String = "SELECT e.employee_id, e.last_name, e.first_name, e.middle_name, e.tin_number, e.sss_number, e.philhealth_number, e.pagibig_number, e.RTN, e.HDMF_MID_number, e.date_hired, e.group, e.department, e.position, e.rank, e.birthday, e.birth_place, e.civil_status, e.present_address, e.email, e.contact_number, e.telephone_number, e.fathers_name, e.mothers_name, e.spouse_name,e.spouse_birthday, c.child_name, c.child_birthday FROM employee201files e, children c WHERE e.employee_id = c.employee_id"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()

            connection.Open()
            dataadapter.Fill(ds, "employee201files")

            connection.Close()
            masterlistDGV.DataSource = ds
            masterlistDGV.DataMember = "employee201files"
            masterlistDGV.Columns("employee_id").HeaderCell.Value = "Employee ID"
            masterlistDGV.Columns("last_name").HeaderCell.Value = "Last Name"
            masterlistDGV.Columns("first_name").HeaderCell.Value = "First Name"
            masterlistDGV.Columns("middle_name").HeaderCell.Value = "Middle Name"
            masterlistDGV.Columns("tin_number").HeaderCell.Value = "TIN Number"
            masterlistDGV.Columns("sss_number").HeaderCell.Value = "SSS Number"
            masterlistDGV.Columns("philhealth_number").HeaderCell.Value = "Philhealth Number"
            masterlistDGV.Columns("pagibig_number").HeaderCell.Value = "Pag-Ibig Number"
            masterlistDGV.Columns("RTN").HeaderCell.Value = "RTN"
            masterlistDGV.Columns("HDMF_MID_number").HeaderCell.Value = "HDMF MID Number"
            masterlistDGV.Columns("date_hired").HeaderCell.Value = "Date Hired"
            masterlistDGV.Columns("company_group").HeaderCell.Value = "Group"
            masterlistDGV.Columns("department").HeaderCell.Value = "Department"
            masterlistDGV.Columns("position").HeaderCell.Value = "Position"
            masterlistDGV.Columns("rank").HeaderCell.Value = "Rank"
            masterlistDGV.Columns("birthday").HeaderCell.Value = "Birthday"
            masterlistDGV.Columns("birth_place").HeaderCell.Value = "Birthplace"
            masterlistDGV.Columns("civil_status").HeaderCell.Value = "Civil Status"
            masterlistDGV.Columns("present_address").HeaderCell.Value = "Present Address"
            masterlistDGV.Columns("email").HeaderCell.Value = "Email"
            masterlistDGV.Columns("contact_number").HeaderCell.Value = "Contact Number"
            masterlistDGV.Columns("telephone_number").HeaderCell.Value = "Telephone Number"
            masterlistDGV.Columns("fathers_name").HeaderCell.Value = "Father's Name"
            masterlistDGV.Columns("mothers_name").HeaderCell.Value = "Mother's Name"
            masterlistDGV.Columns("spouse_name").HeaderCell.Value = "Spouse's Name"
            masterlistDGV.Columns("spouse_birthday").HeaderCell.Value = "Spouse's Birthday"
            'masterlistDGV.Columns("child_name").HeaderCell.Value = "Child's Name"
            'masterlistDGV.Columns("child_birthday").HeaderCell.Value = "Child's Birthday"

            masterlistDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        Catch ex As Exception
            MessageBox.Show("Error while connecting to server " & ex.Message)
        End Try

        Try
            Dim connectionString As String = "Data Source=HP\SQLEXPRESS;Database=201File;Integrated Security=True"
            Dim sql As String = "SELECT employee_id, last_name, first_name, middle_name FROM employee201files"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()

            connection.Open()
            dataadapter.Fill(ds, "employee201files")

            connection.Close()
            accountingsearchDGV.DataSource = ds
            accountingsearchDGV.DataMember = "employee201files"
            accountingsearchDGV.Columns("employee_id").HeaderCell.Value = "Employee ID"
            accountingsearchDGV.Columns("last_name").HeaderCell.Value = "Last Name"
            accountingsearchDGV.Columns("first_name").HeaderCell.Value = "First Name"

            accountingsearchDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        Catch ex As Exception
            MessageBox.Show("Error while connecting to server " & ex.Message)
        End Try

    End Sub



#Region "Accounting Report Methods"
    Private Sub searchButton_Click(sender As System.Object, e As System.EventArgs) Handles searchButton.Click
        If searchText.Text = "" Then
            MessageBox.Show("Please input a name to search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim mreader As SqlDataReader

            Dim connectionString As String = "Data Source=HP\SQLEXPRESS;Database=201File;Integrated Security=True"
            Dim mcon As New SqlConnection(connectionString)

            Dim sql As String = "SELECT employee_id, last_name, first_name, middle_name FROM employee201files WHERE last_name LIKE @search OR first_name LIKE @search OR middle_name LIKE @search"

            Dim cmd As New SqlCommand(sql, mcon)
            cmd.Parameters.AddWithValue("@search", "%" + searchText.Text + "%")

            mcon.Open()
            mreader = cmd.ExecuteReader()

            Dim dt = New DataTable
            dt.Load(mreader)
            accountingsearchDGV.DataSource = dt
            accountingsearchDGV.Columns("employee_id").HeaderCell.Value = "Employee ID"
            accountingsearchDGV.Columns("last_name").HeaderCell.Value = "Last Name"
            accountingsearchDGV.Columns("first_name").HeaderCell.Value = "First Name"
            accountingsearchDGV.Columns("middle_name").HeaderCell.Value = "Middle Name"

            accountingsearchDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

            mcon.Close()

            If accountingsearchDGV.RowCount = 0 Then
                MessageBox.Show("No results match the query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub chooseButton_Click(sender As System.Object, e As System.EventArgs) Handles chooseButton.Click

        If accountingsearchDGV.RowCount = 0 Then
            MessageBox.Show("Please select an employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim mreader As SqlDataReader

            Dim connectionString As String = "Data Source=HP\SQLEXPRESS;Database=201File;Integrated Security=True"
            Dim mcon As New SqlConnection(connectionString)

            Dim sql As String = "SELECT last_name, first_name, middle_name, sss_number, philhealth_number, pagibig_number, tin_number, date_hired, birthday, employee_id FROM employee201files WHERE employee_id = @id"

            Dim cmd As New SqlCommand(sql, mcon)

            cmd.Parameters.AddWithValue("@id", accountingsearchDGV.Item(0, 0).Value.ToString())

            mcon.Open()
            mreader = cmd.ExecuteReader()

            Dim dt = New DataTable
            dt.Load(mreader)
            accountingDGV.DataSource = dt
            accountingDGV.Columns("last_name").HeaderCell.Value = "Last Name"
            accountingDGV.Columns("first_name").HeaderCell.Value = "First Name"
            accountingDGV.Columns("middle_name").HeaderCell.Value = "Middle Name"
            accountingDGV.Columns("sss_number").HeaderCell.Value = "SSS Number"
            accountingDGV.Columns("philhealth_number").HeaderCell.Value = "Philhealth Number"
            accountingDGV.Columns("pagibig_number").HeaderCell.Value = "Pag-Ibig Number"
            accountingDGV.Columns("tin_number").HeaderCell.Value = "TIN Number"
            accountingDGV.Columns("date_hired").HeaderCell.Value = "Date Hired"
            accountingDGV.Columns("birthday").HeaderCell.Value = "Birthday"
            accountingDGV.Columns("employee_id").HeaderCell.Value = "Employee ID"

            accountingDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        End If

    End Sub
#End Region



#Region "Customized Report Methods"
    Private Sub previewButton_Click(sender As System.Object, e As System.EventArgs) Handles previewButton.Click
        If dateCheck.Checked = False AndAlso positionCheck.Checked = False AndAlso departmentCheck.Checked = False AndAlso groupCheck.Checked = False AndAlso scoreCheck.Checked = False AndAlso rankCheck.Checked = False AndAlso statusCheck.Checked = False Then

            MessageBox.Show("Please select a filter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            'Position Only
            If positionCheck.Checked = True Then
                If positionText.Text = "" Then
                    MessageBox.Show("Please input a query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    Try
                        Dim mreader As SqlDataReader

                        Dim connectionString As String = "Data Source=HP\SQLEXPRESS;Database=201File;Integrated Security=True"
                        Dim mcon As New SqlConnection(connectionString)

                        Dim sql As String = "SELECT employee_id, last_name, first_name, middle_name, position FROM employee201files WHERE position = @position"

                        Dim cmd As New SqlCommand(sql, mcon)

                        cmd.Parameters.AddWithValue("@position", positionText.Text)

                        mcon.Open()
                        mreader = cmd.ExecuteReader()

                        Dim dt = New DataTable
                        dt.Load(mreader)
                        customizedDGV.DataSource = dt
                        customizedDGV.Columns("employee_id").HeaderCell.Value = "Employee ID"
                        customizedDGV.Columns("last_name").HeaderCell.Value = "Last Name"
                        customizedDGV.Columns("first_name").HeaderCell.Value = "First Name"
                        customizedDGV.Columns("middle_name").HeaderCell.Value = "Middle Name"
                        customizedDGV.Columns("position").HeaderCell.Value = "Position"

                        customizedDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

                        If customizedDGV.RowCount = 0 Then
                            MessageBox.Show("No results match the query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    Catch ex As Exception
                        MessageBox.Show("Error while connecting to server " & ex.Message)
                    End Try

                End If
                'Department Only
            ElseIf departmentCheck.Checked = True Then
                If departmentText.Text = "" Then
                    MessageBox.Show("Please input a query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Try
                        Dim mreader As SqlDataReader

                        Dim connectionString As String = "Data Source=HP\SQLEXPRESS;Database=201File;Integrated Security=True"
                        Dim mcon As New SqlConnection(connectionString)

                        Dim sql As String = "SELECT employee_id, last_name, first_name, middle_name, department FROM employee201files WHERE department = @department"

                        Dim cmd As New SqlCommand(sql, mcon)

                        cmd.Parameters.AddWithValue("@department", departmentText.Text)

                        mcon.Open()
                        mreader = cmd.ExecuteReader()

                        Dim dt = New DataTable
                        dt.Load(mreader)
                        customizedDGV.DataSource = dt
                        customizedDGV.Columns("employee_id").HeaderCell.Value = "Employee ID"
                        customizedDGV.Columns("last_name").HeaderCell.Value = "Last Name"
                        customizedDGV.Columns("first_name").HeaderCell.Value = "First Name"
                        customizedDGV.Columns("middle_name").HeaderCell.Value = "Middle Name"
                        customizedDGV.Columns("department").HeaderCell.Value = "Department"

                        customizedDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

                        If customizedDGV.RowCount = 0 Then
                            MessageBox.Show("No results match the query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error while connecting to server " & ex.Message)
                    End Try
                End If

                    'Group Only
            ElseIf groupCheck.Checked = True Then
                If groupText.Text = "" Then
                    MessageBox.Show("Please input a query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Try
                        Dim mreader As SqlDataReader

                        Dim connectionString As String = "Data Source=HP\SQLEXPRESS;Database=201File;Integrated Security=True"
                        Dim mcon As New SqlConnection(connectionString)

                        Dim sql As String = "SELECT employee_id, last_name, first_name, middle_name, company_group FROM employee201files WHERE company_group = @group"

                        Dim cmd As New SqlCommand(sql, mcon)

                        cmd.Parameters.AddWithValue("@group", groupText.Text)

                        mcon.Open()
                        mreader = cmd.ExecuteReader()

                        Dim dt = New DataTable
                        dt.Load(mreader)
                        customizedDGV.DataSource = dt
                        customizedDGV.Columns("employee_id").HeaderCell.Value = "Employee ID"
                        customizedDGV.Columns("last_name").HeaderCell.Value = "Last Name"
                        customizedDGV.Columns("first_name").HeaderCell.Value = "First Name"
                        customizedDGV.Columns("middle_name").HeaderCell.Value = "Middle Name"
                        customizedDGV.Columns("company_group").HeaderCell.Value = "Group"

                        customizedDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

                        If customizedDGV.RowCount = 0 Then
                            MessageBox.Show("No results match the query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error while connecting to server " & ex.Message)
                    End Try
                End If

                'Rank Only
            ElseIf rankCheck.Checked = True Then
                If rankText.Text = "" Then
                    MessageBox.Show("Please input a query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Try
                        Dim mreader As SqlDataReader

                        Dim connectionString As String = "Data Source=HP\SQLEXPRESS;Database=201File;Integrated Security=True"
                        Dim mcon As New SqlConnection(connectionString)

                        Dim sql As String = "SELECT employee_id, last_name, first_name, middle_name, rank FROM employee201files WHERE rank = @rank"

                        Dim cmd As New SqlCommand(sql, mcon)

                        cmd.Parameters.AddWithValue("@rank", rankText.Text)

                        mcon.Open()
                        mreader = cmd.ExecuteReader()

                        Dim dt = New DataTable
                        dt.Load(mreader)
                        customizedDGV.DataSource = dt
                        customizedDGV.Columns("employee_id").HeaderCell.Value = "Employee ID"
                        customizedDGV.Columns("last_name").HeaderCell.Value = "Last Name"
                        customizedDGV.Columns("first_name").HeaderCell.Value = "First Name"
                        customizedDGV.Columns("middle_name").HeaderCell.Value = "Middle Name"
                        customizedDGV.Columns("rank").HeaderCell.Value = "Rank"

                        customizedDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

                        If customizedDGV.RowCount = 0 Then
                            MessageBox.Show("No results match the query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error while connecting to server " & ex.Message)
                    End Try
                End If

                'Status Only
            ElseIf statusCheck.Checked = True Then
                If statusCombobox.Text = "" Then
                    MessageBox.Show("Please input a query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Try
                        Dim mreader As SqlDataReader

                        Dim connectionString As String = "Data Source=HP\SQLEXPRESS;Database=201File;Integrated Security=True"
                        Dim mcon As New SqlConnection(connectionString)

                        Dim sql As String = "SELECT employee_id, last_name, first_name, middle_name, status FROM employee201files WHERE status = @status"

                        Dim cmd As New SqlCommand(sql, mcon)

                        cmd.Parameters.AddWithValue("@status", statusCombobox.Text)

                        mcon.Open()
                        mreader = cmd.ExecuteReader()

                        Dim dt = New DataTable
                        dt.Load(mreader)
                        customizedDGV.DataSource = dt
                        customizedDGV.Columns("employee_id").HeaderCell.Value = "Employee ID"
                        customizedDGV.Columns("last_name").HeaderCell.Value = "Last Name"
                        customizedDGV.Columns("first_name").HeaderCell.Value = "First Name"
                        customizedDGV.Columns("middle_name").HeaderCell.Value = "Middle Name"
                        customizedDGV.Columns("status").HeaderCell.Value = "Status"

                        customizedDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

                        If customizedDGV.RowCount = 0 Then
                            MessageBox.Show("No results match the query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error while connecting to server " & ex.Message)
                    End Try
                End If

                'Date Hired Only
                ElseIf dateCheck.Checked = True Then

                    Try
                        Dim mreader As SqlDataReader

                        Dim connectionString As String = "Data Source=HP\SQLEXPRESS;Database=201File;Integrated Security=True"
                        Dim mcon As New SqlConnection(connectionString)

                        Dim sql As String = "SELECT employee_id, last_name, first_name, middle_name, date_hired FROM employee201files WHERE date_hired BETWEEN @fromdate and @todate"

                        Dim cmd As New SqlCommand(sql, mcon)

                        cmd.Parameters.AddWithValue("@fromdate", fromDate.Value.Date)
                        cmd.Parameters.AddWithValue("@todate", toDate.Value.Date)

                        mcon.Open()
                        mreader = cmd.ExecuteReader()

                        Dim dt = New DataTable
                        dt.Load(mreader)
                        customizedDGV.DataSource = dt
                        customizedDGV.Columns("employee_id").HeaderCell.Value = "Employee ID"
                        customizedDGV.Columns("last_name").HeaderCell.Value = "Last Name"
                        customizedDGV.Columns("first_name").HeaderCell.Value = "First Name"
                        customizedDGV.Columns("middle_name").HeaderCell.Value = "Middle Name"
                        customizedDGV.Columns("date_hired").HeaderCell.Value = "Date Hired"

                        customizedDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

                        If customizedDGV.RowCount = 0 Then
                            MessageBox.Show("No results match the query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error while connecting to server " & ex.Message)
                    End Try

                    'Average Evaluation Score Only 
                ElseIf scoreCheck.Checked = True Then

                If evalscoreText.Text = "" Then
                    MessageBox.Show("Please input a query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If

                End If

    End Sub
#End Region

#Region "Create Masterlist Excel"
    Private Sub createButton_Click(sender As System.Object, e As System.EventArgs) Handles createButton.Click

        If masterlistDGV.RowCount = 0 Then
            MessageBox.Show("No information to be added in the masterlist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim headers = (From header As DataGridViewColumn In masterlistDGV.Columns.Cast(Of DataGridViewColumn)() _
                   Select header.HeaderText).ToArray
            Dim rows = From row As DataGridViewRow In masterlistDGV.Rows.Cast(Of DataGridViewRow)() _
                       Where Not row.IsNewRow _
                       Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
            Using sw As New IO.StreamWriter("C:\Users\G\Desktop\Thesis Code\Masterlist.csv")
                sw.WriteLine(String.Join(",", headers))
                For Each r In rows
                    sw.WriteLine(String.Join(",", r))
                Next
            End Using
            Process.Start("Masterlist.csv")
        End If

    End Sub
#End Region

#Region "Close Buttons"
    Private Sub cancelButton2_Click(sender As System.Object, e As System.EventArgs) Handles cancelButton2.Click

        Close()
        Homepage.Show()

    End Sub

    Private Sub cancelButton1_Click(sender As System.Object, e As System.EventArgs) Handles cancelButton1.Click

        Close()
        Homepage.Show()

    End Sub

    Private Sub cancelButton4_Click(sender As System.Object, e As System.EventArgs) Handles cancelButton4.Click

        Close()
        Homepage.Show()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Close()
        Homepage.Show()

    End Sub
#End Region

#Region "Create Accounting Excel"
    Private Sub createaccountingButton_Click(sender As System.Object, e As System.EventArgs) Handles createaccountingButton.Click
        If accountingDGV.RowCount = 0 Then
            MessageBox.Show("No information in the accounting report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim headers = (From header As DataGridViewColumn In accountingDGV.Columns.Cast(Of DataGridViewColumn)() _
                   Select header.HeaderText).ToArray
            Dim rows = From row As DataGridViewRow In accountingDGV.Rows.Cast(Of DataGridViewRow)() _
                       Where Not row.IsNewRow _
                       Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
            Using sw As New IO.StreamWriter("C:\Users\G\Desktop\Thesis Code\Accounting Report.csv")
                sw.WriteLine(String.Join(",", headers))
                For Each r In rows
                    sw.WriteLine(String.Join(",", r))
                Next
            End Using
            Process.Start("C:\Users\G\Desktop\Thesis Code\Accounting Report.csv")
        End If
    End Sub
#End Region

#Region "Create Masterlist Excel"
    Private Sub createcustomizedButton_Click(sender As System.Object, e As System.EventArgs) Handles createcustomizedButton.Click
        If customizedDGV.RowCount = 0 Then
            MessageBox.Show("No information in the customized report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim headers = (From header As DataGridViewColumn In customizedDGV.Columns.Cast(Of DataGridViewColumn)() _
                   Select header.HeaderText).ToArray
            Dim rows = From row As DataGridViewRow In customizedDGV.Rows.Cast(Of DataGridViewRow)() _
                       Where Not row.IsNewRow _
                       Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
            Using sw As New IO.StreamWriter("C:\Users\G\Desktop\Thesis Code\Customized Report.csv")
                sw.WriteLine(String.Join(",", headers))
                For Each r In rows
                    sw.WriteLine(String.Join(",", r))
                Next
            End Using
            Process.Start("C:\Users\G\Desktop\Thesis Code\Customized Report.csv")
        End If
    End Sub
#End Region

#Region "DPR Report Methods"
    Private Sub dprpreviewButton_Click(sender As System.Object, e As System.EventArgs) Handles dprpreviewButton.Click
        If dprrankText.Text = "" AndAlso dprpositionText.Text = "" Then
            MessageBox.Show("Please input rank and position", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf dprrankText.Text = "" Then
            MessageBox.Show("Please input rank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf dprpositionText.Text = "" Then
            MessageBox.Show("Please input position", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim mreader As SqlDataReader

                Dim connectionString As String = "Data Source=HP\SQLEXPRESS;Database=201File;Integrated Security=True"
                Dim mcon As New SqlConnection(connectionString)

                Dim sql As String = "SELECT employee_id, last_name, first_name, middle_name, date_hired, position, rank FROM employee201files WHERE date_hired BETWEEN @fromdate and @todate AND position = @position AND rank = @rank"

                Dim cmd As New SqlCommand(sql, mcon)

                cmd.Parameters.AddWithValue("@fromdate", dprfromDate.Value.Date)
                cmd.Parameters.AddWithValue("@todate", dprtoDate.Value.Date)
                cmd.Parameters.AddWithValue("@position", dprpositionText.Text)
                cmd.Parameters.AddWithValue("@rank", dprrankText.Text)

                mcon.Open()
                mreader = cmd.ExecuteReader()

                Dim dt = New DataTable
                dt.Load(mreader)
                dprDGV.DataSource = dt
                dprDGV.Columns("employee_id").HeaderCell.Value = "Employee ID"
                dprDGV.Columns("last_name").HeaderCell.Value = "Last Name"
                dprDGV.Columns("first_name").HeaderCell.Value = "First Name"
                dprDGV.Columns("middle_name").HeaderCell.Value = "Middle Name"
                dprDGV.Columns("date_hired").HeaderCell.Value = "Date Hired"
                dprDGV.Columns("position").HeaderCell.Value = "Position"
                dprDGV.Columns("Rank").HeaderCell.Value = "Rank"

                customizedDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

                If dprDGV.RowCount = 0 Then
                    MessageBox.Show("No results match the queries", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Error while connecting to server " & ex.Message)
            End Try
        End If
    End Sub
#End Region

End Class
