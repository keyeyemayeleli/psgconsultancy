Imports System.Data.SqlClient
Imports System.Data

Public Class CreateEmployee201

    Private Sub CreateEmployee201_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

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

        statusreasonText.Hide()
        statusdateLabel.Hide()
        statusdateDate.Hide()

    End Sub

    Private Sub backButton_Click(sender As System.Object, e As System.EventArgs) Handles backButton.Click
        Close()
        ManageEmployees.Show()

    End Sub


    Private Sub statusCombobox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles statusCombobox.SelectedIndexChanged
        statusreasonText.Watermark = "Reason for " & statusCombobox.GetItemText(statusCombobox.SelectedItem) & "  Status"
        statusdateLabel.Text = "" & statusCombobox.GetItemText(statusCombobox.SelectedItem) & " Date:"

    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click



<<<<<<< HEAD
        Dim connectionString As String = "Data Source=DESKTOP-2J5TEUE\SQLEXPRESS;Database=201File;Integrated Security=True"
        Dim sql As String = "SET IDENTITY_INSERT employee201files ON; INSERT INTO employee201files (employee_id, last_name, first_name, middle_name, status, tin_number, sss_number, philhealth_number, pagibig_number, RTN, HDMF_MID_number, date_hired, company_group, department, position, rank, birthday, birth_place, civil_status, present_address, permanent_address, email, contact_number, telephone_number, fathers_name, mothers_name, spouse_name, spouse_birthday, nextofkin_name, nextofkin_birthday, status_reason, statusreason_date) VALUES (@employeeid, @lastname, @firstname, @middlename, @status, @tin, @sss, @philhealth, @pagibig, @rtn, @hdmf, @hiredate, @grp, @dept, @pos, @rank, @bday, @bplace, @civil, @presentadd, @permanentadd, @emailadd, @contactnum, @telnum, @father, @mother, @spouse, @spousebday, @nokname, @nokbday, @statreason, @statreasondate); SET IDENTITY_INSERT employee201files OFF"
        Dim sql2 As String = "INSERT INTO children (employee_id, child_name, child_birthday) VALUES (@empid, @cname, @cbday)"
        Dim sql3 As String = "INSERT INTO beneficiaries (employee_id, ben_name, ben_birthday, ben_relation) VALUES (@empid, @bname, @bbday, @brel)"
=======
       

>>>>>>> 6f1d5a1553f2bdeb21b271e4b4e2f3d252f5ae54

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
                End With

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()

                    MessageBox.Show("Employee 201 file of " & givennameText.Text & " " & lastnameText.Text & " successfully added!", "Create 201 file", MessageBoxButtons.OK, MessageBoxIcon.Information)


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





    End Sub
End Class
