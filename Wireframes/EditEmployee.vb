﻿Imports System.Data.SqlClient
Imports System.Data.Common
Public Class EditEmployee
    Dim picaddress As String
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
                If dt.Rows(0)("picture_address") IsNot Nothing Then
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

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Try

            Dim sql As String = "UPDATE employee201files SET last_name= @lastname, first_name= @firstname, middle_name= @middlename, status= @status, tin_number=@tin, sss_number= @sss, philhealth_number = @philhealth, pagibig_number= @pagibig, RTN= @rtn, HDMF_MID_number= @grp, date_hired= @hiredate, company_group= @grp, department= @dept, position= @pos, rank= @rank, birthday= @bday, birth_place= @bplace, civil_status= @civil, present_address= @presentadd, permanent_address= @permanentadd, email= @emailadd, contact_number= @contactnum, telephone_number= @telnum, fathers_name= @father, mothers_name= @mother, spouse_name= @spouse, spouse_birthday= @spousebday, nextofkin_name= @nokname, nextofkin_birthday= @nokbday, status_reason= @statreason, statusreason_date= @statreasondate, picture_address= @pic WHERE employee_id = @eid "
            Dim sql2 As String = "INSERT INTO children (employee_id, child_name, child_birthday) VALUES (@empid, @cname, @cbday)"
            Dim sql3 As String = "INSERT INTO beneficiaries (employee_id, ben_name, ben_birthday, ben_relation) VALUES (@empid, @bname, @bbday, @brel)"
            Dim sql4 As String = "DELETE FROM children WHERE employee_id= @empid; DELETE FROM beneficiaries WHERE employee_id= @empid"

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
                        .Parameters.AddWithValue("hiredate", datehiredDate.Text)
                        .Parameters.AddWithValue("grp", groupText.Text)
                        .Parameters.AddWithValue("dept", departmentText.Text)
                        .Parameters.AddWithValue("pos", positionText.Text)
                        .Parameters.AddWithValue("rank", rankText.Text)
                        .Parameters.AddWithValue("bday", birthdayDate.Text)
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
                        .Parameters.AddWithValue("spousebday", spousebdayDate.Text)
                        .Parameters.AddWithValue("nokname", nextofkinnameText.Text)
                        .Parameters.AddWithValue("nokbday", nextofkinbdayDate.Text)
                        .Parameters.AddWithValue("statreason", statusreasonText.Text)
                        .Parameters.AddWithValue("statreasondate", statusdateDate.Text)
                        .Parameters.AddWithValue("eid", Employee)
                        .Parameters.AddWithValue("pic", picaddress)
                    End With

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
    End Sub

    Private Sub adddocumentsButton_Click(sender As Object, e As EventArgs) Handles adddocumentsButton.Click

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
End Class
