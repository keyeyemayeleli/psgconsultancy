Public Class ManageEmployees
    Private Sub ManageEmployees_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MMMM d, yyyy"
    End Sub

    Private Sub backButton_Click(sender As System.Object, e As System.EventArgs) Handles backButton.Click

        Close()
        Homepage.Show()

    End Sub

    Private Sub createButton_Click(sender As System.Object, e As System.EventArgs) Handles createButton.Click

        Dim NewForm As CreateEmployee201
        NewForm = New CreateEmployee201()
        NewForm.Show()
        NewForm = Nothing
        Me.Hide()

    End Sub
End Class
