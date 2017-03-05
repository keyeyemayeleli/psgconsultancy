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

        If statusCombobox.Text = "Resigned" Then
            statusreasonText.Show()
            statusdateLabel.Show()
            statusdateDate.Show()
            statusreasonText.Watermark = "Reason for Resignation"
            statusdateLabel.Text = "Resignation Date:"
        ElseIf statusCombobox.Text = "Terminated" Then
            statusreasonText.Show()
            statusdateLabel.Show()
            statusdateDate.Show()
            statusreasonText.Watermark = "Reason for Termination"
            statusdateLabel.Text = "Termination Date:"
        ElseIf statusCombobox.Text = "End of Contract" Then
            statusreasonText.Hide()
            statusdateLabel.Show()
            statusdateDate.Show()
            statusdateLabel.Text = "End of Contract Date:"
        Else
            statusreasonText.Hide()
            statusdateLabel.Hide()
            statusdateDate.Hide()
        End If

    End Sub

    Private Sub statusCombobox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles statusCombobox.SelectedIndexChanged

        If statusCombobox.Text = "Resigned" Then
            statusreasonText.Show()
            statusdateLabel.Show()
            statusdateDate.Show()
            statusreasonText.Watermark = "Reason for Resignation"
            statusdateLabel.Text = "Resignation Date:"
        ElseIf statusCombobox.Text = "Terminated" Then
            statusreasonText.Show()
            statusdateLabel.Show()
            statusdateDate.Show()
            statusreasonText.Watermark = "Reason for Termination"
            statusdateLabel.Text = "Termination Date:"
        ElseIf statusCombobox.Text = "End of Contract" Then
            statusreasonText.Hide()
            statusdateLabel.Show()
            statusdateDate.Show()
            statusdateLabel.Text = "End of Contract Date:"
        Else
            statusreasonText.Hide()
            statusdateLabel.Hide()
            statusdateDate.Hide()
        End If

    End Sub
End Class
