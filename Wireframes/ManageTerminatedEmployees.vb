﻿Public Class ManageTerminatedEmployees

    Private Sub ManageTerminatedEmployees_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MMMM d, yyyy"
    End Sub

End Class
