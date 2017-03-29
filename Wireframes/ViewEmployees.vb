Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.IO
Public Class ViewEmployees
    Dim picaddress As String
    Private Sub ViewEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim dt As New DataTable()

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
                If Not IsDBNull(dt.Rows(0)("picture_address")) And Not dt.Rows(0)("picture_address").ToString = "" Then
                    picbox.BackgroundImage = Image.FromFile(dt.Rows(0)("picture_address").ToString)
                    picbox.BackgroundImageLayout = ImageLayout.Zoom
                    picaddress = dt.Rows(0)("picture_address").ToString
                End If
            End If

            Dim dt2 As New DataTable()
            Dim sqlCmd2 As New SqlCommand("SELECT * FROM children WHERE employee_ID = @eid", connection)
            Dim dataadapter2 As New SqlDataAdapter(sqlCmd2)

            sqlCmd2.Parameters.AddWithValue("@eid", Employee)
            dataadapter2.Fill(dt2)
            Dim child_num As Integer = dt2.Rows.Count
            If child_num > 0 Then
                If child_num > 3 Then
                    childrennamelabel4.Text = dt2.Rows(3)("child_name").ToString
                    childrenbdayLabel4.Text = dt2.Rows(3)("child_birthday").ToString
                End If
                If child_num > 2 Then
                    childrennamelabel3.Text = dt2.Rows(2)("child_name").ToString
                    childrenbdayLabel3.Text = dt2.Rows(2)("child_birthday").ToString
                End If
                If child_num > 1 Then
                    childrennamelabel2.Text = dt2.Rows(1)("child_name").ToString
                    childrenbdayLabel2.Text = dt2.Rows(1)("child_birthday").ToString
                End If
                childrennameLabel.Text = dt2.Rows(0)("child_name").ToString
                childrenbdayLabel.Text = dt2.Rows(0)("child_birthday").ToString
            End If

            Dim dt3 As New DataTable()
            Dim sqlCmd3 As New SqlCommand("SELECT * FROM beneficiaries WHERE employee_ID = @eid", connection)
            Dim dataadapter3 As New SqlDataAdapter(sqlCmd3)

            sqlCmd3.Parameters.AddWithValue("@eid", Employee)
            dataadapter3.Fill(dt3)
            Dim ben_num As Integer
            ben_num = dt3.Rows.Count
            If ben_num > 0 Then
                If ben_num > 3 Then
                    beneficiarynameLabelfour.Text = dt3.Rows(3)("ben_name").ToString
                    beneficiarybdayLabelfour.Text = dt3.Rows(3)("ben_birthday").ToString
                    beneficiaryrelationLabelfour.Text = dt3.Rows(3)("ben_relation").ToString
                End If
                If ben_num > 2 Then
                    beneficiarynameLabelthree.Text = dt3.Rows(2)("ben_name").ToString
                    beneficiarybdayLabelthree.Text = dt3.Rows(2)("ben_birthday").ToString
                    beneficiaryrelationLabelthree.Text = dt3.Rows(2)("ben_relation").ToString
                End If
                If ben_num > 1 Then
                    beneficiarynameLabeltwo.Text = dt3.Rows(1)("ben_name").ToString
                    beneficiarybdayLabeltwo.Text = dt3.Rows(1)("ben_birthday").ToString
                    beneficiaryrelationLabeltwo.Text = dt3.Rows(1)("ben_relation").ToString
                End If
                beneficiarynameLabelone.Text = dt3.Rows(0)("ben_name").ToString
                beneficiarybdayLabelone.Text = dt3.Rows(0)("ben_birthday").ToString
                beneficiaryrelationLabelone.Text = dt3.Rows(0)("ben_relation").ToString
            End If

            Dim ds4 As New DataSet()
            Dim sqlCmd4 As New SqlCommand("SELECT * FROM employee_ym_evals WHERE employee_ID = @eid AND status = 'monthly'", connection)
            Dim dataadapter4 As New SqlDataAdapter(sqlCmd4)
            sqlCmd4.Parameters.AddWithValue("@eid", Employee)
            dataadapter4.Fill(ds4, "employee_ym_evals")
            monthlyDatagrid.DataSource = ds4
            monthlyDatagrid.DataMember = "employee_ym_evals"
            monthlyDatagrid.Columns("date").HeaderCell.Value = "Month"
            monthlyDatagrid.Columns("score").HeaderCell.Value = "Score"
            monthlyDatagrid.Columns("remarks").HeaderCell.Value = "Remarks"
            monthlyDatagrid.Columns("employee_id").Visible = False
            monthlyDatagrid.Columns("eval_id").Visible = False
            monthlyDatagrid.Columns("status").Visible = False

            Dim ds5 As New DataSet()
            Dim sqlCmd5 As New SqlCommand("SELECT * FROM employee_ym_evals WHERE employee_ID = @eid AND status = 'yearly'", connection)
            Dim dataadapter5 As New SqlDataAdapter(sqlCmd5)
            sqlCmd5.Parameters.AddWithValue("@eid", Employee)
            dataadapter5.Fill(ds5, "employee_ym_evals")
            yearlyDatadrid.DataSource = ds5
            yearlyDatadrid.DataMember = "employee_ym_evals"
            yearlyDatadrid.Columns("date").HeaderCell.Value = "Month"
            yearlyDatadrid.Columns("score").HeaderCell.Value = "Score"
            yearlyDatadrid.Columns("remarks").HeaderCell.Value = "Remarks"
            yearlyDatadrid.Columns("employee_id").Visible = False
            yearlyDatadrid.Columns("eval_id").Visible = False
            yearlyDatadrid.Columns("status").Visible = False

            Dim ds6 As New DataSet()
            Dim imageList1 As New ImageList() With {.ImageSize = New Size(24, 24)}
            Dim a() As String
            documentsLV.View = View.Details
            documentsLV.FullRowSelect = True
            documentsLV.SmallImageList = imageList1

            documentsLV.Columns.Add("", 100, HorizontalAlignment.Left)
            documentsLV.Columns.Add("Full Name", 0, HorizontalAlignment.Left)
            documentsLV.Columns.Add("Document name", 500, HorizontalAlignment.Left)

            documentsLV.Columns(0).DisplayIndex = documentsLV.Columns.Count - 1

            Dim dt7 As New DataTable()
            Dim sqlCmd7 As New SqlCommand("SELECT * FROM documents WHERE employee_ID = @eid", connection)
            Dim dataadapter7 As New SqlDataAdapter(sqlCmd7)
            sqlCmd7.Parameters.AddWithValue("@eid", Employee)

            dataadapter7.Fill(dt7)

            If dt7.Rows.Count > 0 Then
                ReDim a(0 To dt7.Rows.Count - 1)
                For i = 0 To dt7.Rows.Count - 1
                    a(i) = dt7.Rows(i)("document_address").ToString
                Next
                imageList1.Images.Clear()
                For Each file In a

                    imageList1.Images.Add(Icon.ExtractAssociatedIcon(file).ToBitmap)
                    Dim lvi As New ListViewItem("", imageList1.Images.Count - 1)
                    lvi.SubItems.Add(file)
                    lvi.SubItems.Add(IO.Path.GetFileNameWithoutExtension(file))

                    documentsLV.Items.Add(lvi)


                Next

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

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        Dim NewForm As EditEmployee
        NewForm = New EditEmployee()
        NewForm.Show()
        NewForm = Nothing
        Me.Close()
    End Sub

    Private Sub adddocumentsButton_Click(sender As Object, e As EventArgs) Handles adddocumentsButton.Click

        Dim open As New OpenFileDialog()
        Dim sql As String = "INSERT INTO documents (employee_id, document_name, document_address) VALUES (@empid, @dname, @dadd)"

        open.InitialDirectory = "c:\"
        open.Filter = "All files (*.*)|*.*"
        open.FilterIndex = 1
        open.Multiselect = True
        open.RestoreDirectory = True

        If open.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                For Each file In open.FileNames

                    Using conn As New SqlConnection(connectionString)
                        Using cmd2 As New SqlCommand()
                            With cmd2
                                .Connection = conn
                                .CommandType = CommandType.Text
                                .CommandText = sql
                                .Parameters.AddWithValue("empid", Employee)
                                .Parameters.AddWithValue("dadd", file)
                                .Parameters.AddWithValue("dname", Path.GetFileNameWithoutExtension(file))
                            End With
                            Try
                                conn.Open()
                                cmd2.ExecuteNonQuery()
                                cmd2.Parameters.Clear()
                            Catch ex As Exception
                                MessageBox.Show(ex.Message.ToString(), "Error Message")
                            End Try
                        End Using
                    End Using

                Next

            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)


            End Try
        End If
    End Sub

    Private Sub documentsLV_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles documentsLV.MouseDoubleClick
        If documentsLV.SelectedItems.Count() = 1 Then
            Dim file As String
            file = documentsLV.SelectedItems.Item(0).SubItems(1).Text
            Dim p As New System.Diagnostics.Process
            Dim s As New System.Diagnostics.ProcessStartInfo(file)
            s.UseShellExecute = True
            p.StartInfo = s
            p.Start()
        Else
            MessageBox.Show("You need to select only one file.", "View Employee Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class
