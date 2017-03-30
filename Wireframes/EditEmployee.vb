Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.IO
Public Class EditEmployee
    Dim picaddress As String = ""
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
                If Not IsDBNull(dt.Rows(0)("birthday")) And Not dt.Rows(0)("birthday").ToString = "" Then
                    birthdayDate.Value = dt.Rows(0)("birthday")
                End If
                civilstatusCombobox.Text = dt.Rows(0)("civil_status").ToString
                presentaddressText.Text = dt.Rows(0)("present_address").ToString
                permanentaddressText.Text = dt.Rows(0)("permanent_address").ToString
                emailaddressText.Text = dt.Rows(0)("email").ToString
                contactnumberText.Text = dt.Rows(0)("contact_number").ToString
                telephonenumberText.Text = dt.Rows(0)("telephone_number").ToString
                fathersnameText.Text = dt.Rows(0)("fathers_name").ToString
                mothersnameText.Text = dt.Rows(0)("mothers_name").ToString
                spousenameText.Text = dt.Rows(0)("spouse_name").ToString
                If Not IsDBNull(dt.Rows(0)("spouse_birthday")) And Not dt.Rows(0)("spouse_birthday").ToString = "" Then
                    spousebdayDate.Value = dt.Rows(0)("spouse_birthday")
                End If
                If Not IsDBNull(dt.Rows(0)("date_hired")) And Not dt.Rows(0)("date_hired").ToString = "" Then
                    datehiredDate.Value = dt.Rows(0)("date_hired")
                End If
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
                    childnameTextfour.Text = dt2.Rows(3)("child_name").ToString
                    childbdayDatefour.Text = dt2.Rows(3)("child_birthday").ToString
                End If
                If child_num > 2 Then
                    childnameTextthree.Text = dt2.Rows(2)("child_name").ToString
                    childbdayDatethree.Text = dt2.Rows(2)("child_birthday").ToString
                End If
                If child_num > 1 Then
                    childnameTexttwo.Text = dt2.Rows(1)("child_name").ToString
                    childbdayDatetwo.Text = dt2.Rows(1)("child_birthday").ToString
                End If
                childnameTextone.Text = dt2.Rows(0)("child_name").ToString
                childbdayDateone.Text = dt2.Rows(0)("child_birthday").ToString
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
                    beneficiarynameTextfour.Text = dt3.Rows(3)("ben_name").ToString
                    beneficiarybdayDatefour.Text = dt3.Rows(3)("ben_birthday").ToString
                End If
                If ben_num > 2 Then
                    beneficiarynameTextthree.Text = dt3.Rows(2)("ben_name").ToString
                    beneficiarybdayDatethree.Text = dt3.Rows(2)("ben_birthday").ToString
                End If
                If ben_num > 1 Then
                    beneficiarynameTexttwo.Text = dt3.Rows(1)("ben_name").ToString
                    beneficiarybdayDatetwo.Text = dt3.Rows(1)("ben_birthday").ToString
                End If
                beneficiarynameTextone.Text = dt3.Rows(0)("ben_name").ToString
                beneficiarybdayDateone.Text = dt3.Rows(0)("ben_birthday").ToString
            End If





            documentsLV.Columns.Add("", 100, HorizontalAlignment.Left)
            documentsLV.Columns.Add("Full Name", 0, HorizontalAlignment.Left)
            documentsLV.Columns.Add("Document name", 500, HorizontalAlignment.Left)
            documentsLV.Columns.Add("Doc ID", 0, HorizontalAlignment.Left)

            documentsLV.Columns(0).DisplayIndex = documentsLV.Columns.Count - 1
            load_mevals(connection)
            load_yevals(connection)
            load_documents(connection)

            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Error while connecting to database" & ex.Message)
        End Try


        statusreasonText.Watermark = "Reason for " & statusCombobox.GetItemText(statusCombobox.SelectedItem) & ""
        statusdateLabel.Text = "" & statusCombobox.GetItemText(statusCombobox.SelectedItem) & " Date:"

        If Evaltype = "monthly" Then
            TabControl1.SelectTab(5)
            Evaltype = ""
        ElseIf Evaltype = "yearly" Then
            TabControl1.SelectTab(6)
            Evaltype = ""
        End If


    End Sub



    Private Sub statusCombobox_SelectedValueChanged(sender As Object, e As EventArgs) Handles statusCombobox.SelectedValueChanged
        statusreasonText.Watermark = "Reason for " & statusCombobox.GetItemText(statusCombobox.SelectedItem) & "  Status"
        statusdateLabel.Text = "" & statusCombobox.GetItemText(statusCombobox.SelectedItem) & " Date:"
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click

        If lastnameText.Text = "" Or givennameText.Text = "" Or middlenameText.Text = "" Or statusCombobox.Text = "Status" Or civilstatusCombobox.Text = "Civil Status" Then
            MessageBox.Show("Please input all relevant information", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try

                Dim sql As String = "UPDATE employee201files SET last_name= @lastname, first_name= @firstname, middle_name= @middlename, status= @status, tin_number=@tin, sss_number= @sss, philhealth_number = @philhealth, pagibig_number= @pagibig, RTN= @rtn, HDMF_MID_number= @grp, date_hired= @hiredate, company_group= @grp, department= @dept, position= @pos, rank= @rank, birthday= @bday, birth_place= @bplace, civil_status= @civil, present_address= @presentadd, permanent_address= @permanentadd, email= @emailadd, contact_number= @contactnum, telephone_number= @telnum, fathers_name= @father, mothers_name= @mother, spouse_name= @spouse, spouse_birthday= @spousebday, nextofkin_name= @nokname, nextofkin_birthday= @nokbday, status_reason= @statreason, statusreason_date= @statreasondate, picture_address= @pic WHERE employee_id = @eid "
                Dim sql2 As String = "INSERT INTO children (employee_id, child_name, child_birthday) VALUES (@empid, @cname, @cbday)"
                Dim sql3 As String = "INSERT INTO beneficiaries (employee_id, ben_name, ben_birthday, ben_relation) VALUES (@empid, @bname, @bbday, @brel)"
                Dim sql4 As String = "DELETE FROM children WHERE employee_id= @empid; DELETE FROM beneficiaries WHERE employee_id= @empid"
                Dim sql5 As String = "INSERT INTO logs (time_stamp, activity_name, account_id) VALUES (@time, @actname, @accid)"

                Using conn As New SqlConnection(connectionString)
                    Using cmd As New SqlCommand()
                        With cmd
                            .Connection = conn
                            .CommandType = CommandType.Text
                            .CommandText = sql
                            .Parameters.AddWithValue("employeeid", employeenumberText.Text)
                            .Parameters.AddWithValue("lastname", lastnameText.Text)
                            .Parameters.AddWithValue("firstname", givennameText.Text)
                            .Parameters.AddWithValue("middlename", middlenameText.Text)
                            .Parameters.AddWithValue("status", statusCombobox.Text)
                            .Parameters.AddWithValue("tin", tinnumberText.Text)
                            .Parameters.AddWithValue("sss", sssnumberText.Text)
                            .Parameters.AddWithValue("philhealth", philhealthnumberText.Text)
                            .Parameters.AddWithValue("pagibig", pagibignumberText.Text)
                            .Parameters.AddWithValue("rtn", rtnText.Text)
                            .Parameters.AddWithValue("hdmf", hdmfnumberText.Text)
                            '.Parameters.AddWithValue("hiredate", hireday)
                            .Parameters.AddWithValue("grp", groupText.Text)
                            .Parameters.AddWithValue("dept", departmentText.Text)
                            .Parameters.AddWithValue("pos", positionText.Text)
                            .Parameters.AddWithValue("rank", rankText.Text)
                            '.Parameters.AddWithValue("bday", bday)
                            .Parameters.AddWithValue("bplace", birthplaceText.Text)
                            .Parameters.AddWithValue("civil", civilstatusCombobox.Text)
                            .Parameters.AddWithValue("presentadd", presentaddressText.Text)
                            .Parameters.AddWithValue("permanentadd", permanentaddressText.Text)
                            .Parameters.AddWithValue("emailadd", emailaddressText.Text)
                            .Parameters.AddWithValue("contactnum", contactnumberText.Text)
                            .Parameters.AddWithValue("telnum", telephonenumberText.Text)
                            .Parameters.AddWithValue("father", fathersnameText.Text)
                            .Parameters.AddWithValue("mother", mothersnameText.Text)
                            .Parameters.AddWithValue("spouse", spousenameText.Text)
                            '.Parameters.AddWithValue("spousebday", spday)
                            .Parameters.AddWithValue("nokname", nextofkinnameText.Text)
                            .Parameters.AddWithValue("nokbday", nextofkinbdayDate.Text)
                            .Parameters.AddWithValue("statreason", statusreasonText.Text)
                            .Parameters.AddWithValue("statreasondate", statusdateDate.Text)
                            .Parameters.AddWithValue("eid", Employee)
                            .Parameters.AddWithValue("pic", picaddress)
                        End With

                        If datehiredcheck.Checked = True Then
                            cmd.Parameters.AddWithValue("hiredate", datehiredDate.Text)
                        Else
                            cmd.Parameters.AddWithValue("hiredate", DBNull.Value)
                        End If

                        If bdaycheck.Checked = True Then
                            cmd.Parameters.AddWithValue("bday", birthdayDate.Text)
                        Else
                            cmd.Parameters.AddWithValue("bday", DBNull.Value)
                        End If

                        If bdayspousecheck.Checked = True Then
                            cmd.Parameters.AddWithValue("spousebday", spousebdayDate.Text)
                        Else
                            cmd.Parameters.AddWithValue("spousebday", DBNull.Value)
                        End If

                        Try
                            conn.Open()
                            cmd.ExecuteNonQuery()
                            cmd.Parameters.Clear()




                            MessageBox.Show("Employee 201 file of " & givennameText.Text & " " & lastnameText.Text & " successfully updated!", "Edit 201 file", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Using cmd7 As New SqlCommand()
                                With cmd7
                                    .Connection = conn
                                    .CommandType = CommandType.Text
                                    .CommandText = sql4
                                    .Parameters.AddWithValue("empid", Employee)
                                End With
                                Try
                                    cmd7.ExecuteNonQuery()
                                    cmd7.Parameters.Clear()
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                                End Try
                            End Using


                            If childnameTextone.Text IsNot "" Then
                                Using cmd2 As New SqlCommand()
                                    With cmd2
                                        .Connection = conn
                                        .CommandType = CommandType.Text
                                        .CommandText = sql2
                                        .Parameters.AddWithValue("empid", employeenumberText.Text)
                                        .Parameters.AddWithValue("cname", childnameTextone.Text)
                                        .Parameters.AddWithValue("cbday", childbdayDateone.Text)
                                    End With
                                    Try
                                        cmd2.ExecuteNonQuery()
                                        cmd2.Parameters.Clear()
                                    Catch ex As Exception
                                        MessageBox.Show(ex.Message.ToString(), "Error Message")
                                    End Try
                                End Using
                            End If

                            If childnameTexttwo.Text IsNot "" Then
                                Using cmd3 As New SqlCommand()
                                    With cmd3
                                        .Connection = conn
                                        .CommandType = CommandType.Text
                                        .CommandText = sql2
                                        .Parameters.AddWithValue("empid", employeenumberText.Text)
                                        .Parameters.AddWithValue("cname", childnameTexttwo.Text)
                                        .Parameters.AddWithValue("cbday", childbdayDatetwo.Text)
                                    End With
                                    Try
                                        cmd3.ExecuteNonQuery()
                                        cmd3.Parameters.Clear()
                                    Catch ex As Exception
                                        MessageBox.Show(ex.Message.ToString(), "Error Message")
                                    End Try
                                End Using
                            End If

                            If childnameTextthree.Text IsNot "" Then
                                Using cmd4 As New SqlCommand()
                                    With cmd4
                                        .Connection = conn
                                        .CommandType = CommandType.Text
                                        .CommandText = sql2
                                        .Parameters.AddWithValue("empid", employeenumberText.Text)
                                        .Parameters.AddWithValue("cname", childnameTextthree.Text)
                                        .Parameters.AddWithValue("cbday", childbdayDatethree.Text)
                                    End With
                                    Try
                                        cmd4.ExecuteNonQuery()
                                        cmd4.Parameters.Clear()
                                    Catch ex As Exception
                                        MessageBox.Show(ex.Message.ToString(), "Error Message")
                                    End Try
                                End Using
                            End If

                            If childnameTextfour.Text IsNot "" Then
                                Using cmd5 As New SqlCommand()
                                    With cmd5
                                        .Connection = conn
                                        .CommandType = CommandType.Text
                                        .CommandText = sql2
                                        .Parameters.AddWithValue("empid", employeenumberText.Text)
                                        .Parameters.AddWithValue("cname", childnameTextfour.Text)
                                        .Parameters.AddWithValue("cbday", childbdayDatefour.Text)
                                    End With
                                    Try
                                        cmd5.ExecuteNonQuery()
                                        cmd5.Parameters.Clear()
                                    Catch ex As Exception
                                        MessageBox.Show(ex.Message.ToString(), "Error Message")
                                    End Try
                                End Using
                            End If

                            If beneficiarynameTextone.Text IsNot "" Then
                                Using cmd6 As New SqlCommand()
                                    With cmd6
                                        .Connection = conn
                                        .CommandType = CommandType.Text
                                        .CommandText = sql3
                                        .Parameters.AddWithValue("empid", employeenumberText.Text)
                                        .Parameters.AddWithValue("bname", beneficiarynameTextone.Text)
                                        .Parameters.AddWithValue("bbday", beneficiarybdayDateone.Text)
                                        .Parameters.AddWithValue("brel", beneficiaryrelationTextone.Text)
                                    End With
                                    Try
                                        cmd6.ExecuteNonQuery()
                                        cmd6.Parameters.Clear()
                                    Catch ex As Exception
                                        MessageBox.Show(ex.Message.ToString(), "Error Message")
                                    End Try
                                End Using
                            End If

                            If beneficiarynameTexttwo.Text IsNot "" Then
                                Using cmd7 As New SqlCommand()
                                    With cmd7
                                        .Connection = conn
                                        .CommandType = CommandType.Text
                                        .CommandText = sql3
                                        .Parameters.AddWithValue("empid", employeenumberText.Text)
                                        .Parameters.AddWithValue("bname", beneficiarynameTexttwo.Text)
                                        .Parameters.AddWithValue("bbday", beneficiarybdayDatetwo.Text)
                                        .Parameters.AddWithValue("brel", beneficiaryrelationTexttwo.Text)
                                    End With
                                    Try
                                        cmd7.ExecuteNonQuery()
                                        cmd7.Parameters.Clear()
                                    Catch ex As Exception
                                        MessageBox.Show(ex.Message.ToString(), "Error Message")
                                    End Try
                                End Using
                            End If

                            If beneficiarynameTextthree.Text IsNot "" Then
                                Using cmd6 As New SqlCommand()
                                    With cmd6
                                        .Connection = conn
                                        .CommandType = CommandType.Text
                                        .CommandText = sql3
                                        .Parameters.AddWithValue("empid", employeenumberText.Text)
                                        .Parameters.AddWithValue("bname", beneficiarynameTextthree.Text)
                                        .Parameters.AddWithValue("bbday", beneficiarybdayDatethree.Text)
                                        .Parameters.AddWithValue("brel", beneficiaryrelationTextthree.Text)
                                    End With
                                    Try
                                        cmd6.ExecuteNonQuery()
                                        cmd6.Parameters.Clear()
                                    Catch ex As Exception
                                        MessageBox.Show(ex.Message.ToString(), "Error Message")
                                    End Try
                                End Using
                            End If

                            If beneficiarynameTextfour.Text IsNot "" Then
                                Using cmd6 As New SqlCommand()
                                    With cmd6
                                        .Connection = conn
                                        .CommandType = CommandType.Text
                                        .CommandText = sql3
                                        .Parameters.AddWithValue("empid", employeenumberText.Text)
                                        .Parameters.AddWithValue("bname", beneficiarynameTextfour.Text)
                                        .Parameters.AddWithValue("bbday", beneficiarybdayDatefour.Text)
                                        .Parameters.AddWithValue("brel", beneficiaryrelationTextfour.Text)
                                    End With
                                    Try
                                        cmd6.ExecuteNonQuery()
                                        cmd6.Parameters.Clear()
                                    Catch ex As Exception
                                        MessageBox.Show(ex.Message.ToString(), "Error Message")
                                    End Try
                                End Using
                            End If

                            Dim datenow As DateTime = DateTime.Now
                            Dim datestr As String = datenow.ToString("yyyy-MM-dd HH:mm:ss")

                            Using cmd8 As New SqlCommand()
                                With cmd8
                                    .Connection = conn
                                    .CommandType = CommandType.Text
                                    .CommandText = sql5
                                    .Parameters.AddWithValue("time", datestr)
                                    .Parameters.AddWithValue("actname", "Edited 201 file of " + lastnameText.Text + ", " + givennameText.Text + " " + middlenameText.Text)
                                    .Parameters.AddWithValue("accid", UserID)
                                End With

                                Try
                                    cmd8.ExecuteNonQuery()
                                    cmd8.Parameters.Clear()
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                                End Try
                            End Using


                            Dim a As Control

                            For Each a In Me.Controls
                                If TypeOf a Is TextBox Then
                                    a.Text = Nothing
                                ElseIf TypeOf a Is ComboBox Then
                                    a.Text = Nothing
                                End If
                            Next
                            Me.Close()
                            ManageEmployees.Show()
                        Catch ex As SqlException
                            MessageBox.Show(ex.Message.ToString(), "Error Message")
                        End Try
                    End Using
                End Using
            Catch ex As Exception

            End Try

        End If



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
                MessageBox.Show("Documents added to 201 file of " & givennameText.Text & " " & lastnameText.Text & ".", "Add document file", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)


            End Try
        End If
    End Sub

    Private Sub changepicButton_Click(sender As Object, e As EventArgs) Handles changepicButton.Click
        Dim pic As New OpenFileDialog()
        pic.InitialDirectory = "c:\"
        pic.Filter = "Image files (*.jpg,*.jpeg,*.jpe,*.jfif,*.png)|*.jpg;*.jpeg;*.jpe;*.jfif;*.png"
        pic.FilterIndex = 1
        pic.Multiselect = False
        pic.RestoreDirectory = True

        If pic.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                If pic.FileName IsNot Nothing Then
                    picbox.BackgroundImage = Image.FromFile(pic.FileName)
                    picbox.BackgroundImageLayout = ImageLayout.Zoom
                    picaddress = pic.FileName
                End If
            Catch ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub addmevalsbutton_Click(sender As Object, e As EventArgs) Handles addmevalsbutton.Click
        Evaltype = "monthly"
        EvalNum = -1
        Dim NewForm As EvaluationsForm
        NewForm = New EvaluationsForm()
        NewForm.Show()
        NewForm = Nothing

    End Sub

    Private Sub editmevalsbutton_Click(sender As Object, e As EventArgs) Handles editmevalsbutton.Click
        If monthlyDatagrid.SelectedRows.Count() = 1 Then
            Evaltype = "monthly"
            EvalNum = monthlyDatagrid.SelectedRows(0).Cells(0).Value.ToString
            Dim NewForm As EvaluationsForm
            NewForm = New EvaluationsForm()
            NewForm.Show()
            NewForm = Nothing
        Else
            MessageBox.Show("You need to select one record.", "Edit Employee Evaluation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub deletemevalsbutton_Click(sender As Object, e As EventArgs) Handles deletemevalsbutton.Click
        If monthlyDatagrid.SelectedRows.Count() = 1 Then
            If MsgBox("Are you sure you want to delete record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim deletesql As String = "DELETE FROM employee_ym_evals WHERE eval_id= @evid"

                Using conn As New SqlConnection(connectionString)
                    Using dcmd As New SqlCommand()
                        With dcmd
                            .Connection = conn
                            .CommandType = CommandType.Text
                            .CommandText = deletesql
                            .Parameters.AddWithValue("evid", monthlyDatagrid.SelectedRows(0).Cells(0).Value.ToString)
                        End With
                        Try
                            conn.Open()
                            dcmd.ExecuteNonQuery()
                            dcmd.Parameters.Clear()
                            MessageBox.Show("Delete evaluation successful", "Delete monthly evaluation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Dim connection As New SqlConnection(connectionString)
                            load_mevals(connection)
                        Catch ex As Exception
                            MessageBox.Show(ex.Message.ToString(), "Error Message")
                        End Try
                    End Using
                End Using

            End If
        Else
            MessageBox.Show("You need to select one record.", "Delete Employee Evaluation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub addyevalsbutton_Click(sender As Object, e As EventArgs) Handles addyevalsbutton.Click
        Evaltype = "yearly"
        EvalNum = -1
        Dim NewForm As EvaluationsForm
        NewForm = New EvaluationsForm()
        NewForm.Show()
        NewForm = Nothing
    End Sub

    Private Sub edityevalsbutton_Click(sender As Object, e As EventArgs) Handles edityevalsbutton.Click
        If yearlyDatadrid.SelectedRows.Count() = 1 Then
            Evaltype = "yearly"
            EvalNum = monthlyDatagrid.SelectedRows(0).Cells(0).Value.ToString
            Dim NewForm As EvaluationsForm
            NewForm = New EvaluationsForm()
            NewForm.Show()
            NewForm = Nothing
        Else
            MessageBox.Show("You need to select one record.", "Edit Employee Evaluation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub deleteyevalsbutton_Click(sender As Object, e As EventArgs) Handles deleteyevalsbutton.Click
        If yearlyDatadrid.SelectedRows.Count() = 1 Then
            If MsgBox("Are you sure you want to delete record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim deletesql As String = "DELETE FROM employee_ym_evals WHERE eval_id= @evid"

                Using conn As New SqlConnection(connectionString)
                    Using dcmd As New SqlCommand()
                        With dcmd
                            .Connection = conn
                            .CommandType = CommandType.Text
                            .CommandText = deletesql
                            .Parameters.AddWithValue("evid", yearlyDatadrid.SelectedRows(0).Cells(0).Value.ToString)
                        End With
                        Try
                            conn.Open()
                            dcmd.ExecuteNonQuery()
                            dcmd.Parameters.Clear()
                            MessageBox.Show("Delete evaluation successful", "Delete yearly evaluation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Dim connection As New SqlConnection(connectionString)
                            load_yevals(connection)

                        Catch ex As Exception
                            MessageBox.Show(ex.Message.ToString(), "Error Message")
                        End Try
                    End Using
                End Using

            End If
        Else
            MessageBox.Show("You need to select one record.", "Delete Employee Evaluation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()
        ViewEmployees.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles datehiredcheck.CheckedChanged
        If datehiredcheck.Checked = True Then
            datehiredDate.Enabled = True
        Else
            datehiredDate.Enabled = False
        End If

    End Sub

    Private Sub bdaycheck_CheckedChanged(sender As Object, e As EventArgs) Handles bdaycheck.CheckedChanged
        If bdaycheck.Checked = True Then
            birthdayDate.Enabled = True
        Else
            birthdayDate.Enabled = False
        End If
    End Sub

    Private Sub bdayspousecheck_CheckedChanged(sender As Object, e As EventArgs) Handles bdayspousecheck.CheckedChanged
        If bdayspousecheck.Checked = True Then
            spousebdayDate.Enabled = True
        Else
            spousebdayDate.Enabled = False
        End If
    End Sub

    Private Sub deletedocbutton_Click(sender As Object, e As EventArgs) Handles deletedocbutton.Click
        If documentsLV.SelectedItems.Count = 1 Then
            If MsgBox("Are you sure you want to remove document?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim deletesql As String = "DELETE FROM documents WHERE document_id= @docid"

                Using conn As New SqlConnection(connectionString)
                    Using dcmd As New SqlCommand()
                        With dcmd
                            .Connection = conn
                            .CommandType = CommandType.Text
                            .CommandText = deletesql
                            .Parameters.AddWithValue("docid", documentsLV.SelectedItems(0).SubItems(3).Text)
                        End With
                        Try
                            conn.Open()
                            dcmd.ExecuteNonQuery()
                            dcmd.Parameters.Clear()
                            MessageBox.Show("Remove document successful", "Remove document", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Dim connection As New SqlConnection(connectionString)
                            load_documents(connection)
                        Catch ex As Exception
                            MessageBox.Show(ex.Message.ToString(), "Error Message")
                        End Try
                    End Using
                End Using

            End If
        Else
            MessageBox.Show("You need to select one record.", "Remove Employee Document Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Function load_documents(connection)

        documentsLV.Items.Clear()
        Dim imageList1 As New ImageList() With {.ImageSize = New Size(24, 24)}
        Dim a() As String
        Dim b() As Integer
        documentsLV.View = View.Details
        documentsLV.FullRowSelect = True
        documentsLV.SmallImageList = imageList1

        Dim dt7 As New DataTable()
        Dim sqlCmd7 As New SqlCommand("SELECT * FROM documents WHERE employee_ID = @eid", connection)
        Dim dataadapter7 As New SqlDataAdapter(sqlCmd7)
        sqlCmd7.Parameters.AddWithValue("@eid", Employee)

        dataadapter7.Fill(dt7)
        If dt7.Rows.Count > 0 Then
            ReDim a(0 To dt7.Rows.Count - 1)
            ReDim b(0 To dt7.Rows.Count - 1)
            For i = 0 To dt7.Rows.Count - 1
                a(i) = dt7.Rows(i)("document_address").ToString
                b(i) = dt7.Rows(i)("document_id").ToString
            Next
            imageList1.Images.Clear()
            For n As Integer = 0 To a.Count - 1
                imageList1.Images.Add(Icon.ExtractAssociatedIcon(a(n)).ToBitmap)
                Dim lvi As New ListViewItem("", imageList1.Images.Count - 1)
                lvi.SubItems.Add(a(n))
                lvi.SubItems.Add(IO.Path.GetFileNameWithoutExtension(a(n)))
                lvi.SubItems.Add(b(n))
                documentsLV.Items.Add(lvi)
            Next

        End If
    End Function

    Public Function load_yevals(connection)
        Dim ds5 As New DataSet()
        Dim sqlCmd5 As New SqlCommand("SELECT * FROM employee_ym_evals WHERE employee_ID = @eid AND status = 'yearly'", connection)
        Dim dataadapter5 As New SqlDataAdapter(sqlCmd5)
        sqlCmd5.Parameters.AddWithValue("@eid", Employee)
        dataadapter5.Fill(ds5, "employee_ym_evals")
        yearlyDatadrid.DataSource = ds5
        yearlyDatadrid.DataMember = "employee_ym_evals"
        yearlyDatadrid.Columns("date").HeaderCell.Value = "Month"
        yearlyDatadrid.Columns("fscore").HeaderCell.Value = "Final Score"
        yearlyDatadrid.Columns("prscore").HeaderCell.Value = "Performance Rating Score"
        yearlyDatadrid.Columns("acscore").HeaderCell.Value = "Admin Compliance Score"
        yearlyDatadrid.Columns("remarks").HeaderCell.Value = "Remarks"
        yearlyDatadrid.Columns("employee_id").Visible = False
        yearlyDatadrid.Columns("eval_id").Visible = False
        yearlyDatadrid.Columns("status").Visible = False
    End Function
    Public Function load_mevals(connection)
        Dim ds4 As New DataSet()
        Dim sqlCmd4 As New SqlCommand("SELECT * FROM employee_ym_evals WHERE employee_ID = @eid AND status = 'monthly'", connection)
        Dim dataadapter4 As New SqlDataAdapter(sqlCmd4)
        sqlCmd4.Parameters.AddWithValue("@eid", Employee)
        dataadapter4.Fill(ds4, "employee_ym_evals")
        monthlyDatagrid.DataSource = ds4
        monthlyDatagrid.DataMember = "employee_ym_evals"
        monthlyDatagrid.Columns("date").HeaderCell.Value = "Month"
        monthlyDatagrid.Columns("fscore").HeaderCell.Value = "Final Score"
        monthlyDatagrid.Columns("prscore").HeaderCell.Value = "Performance Rating Score"
        monthlyDatagrid.Columns("acscore").HeaderCell.Value = "Admin Compliance Score"
        monthlyDatagrid.Columns("remarks").HeaderCell.Value = "Remarks"
        monthlyDatagrid.Columns("employee_id").Visible = False
        monthlyDatagrid.Columns("eval_id").Visible = False
        monthlyDatagrid.Columns("status").Visible = False
    End Function


End Class

