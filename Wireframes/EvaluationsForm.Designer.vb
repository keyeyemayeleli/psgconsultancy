<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EvaluationsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.employeenamelabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.employeenumberlabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.evaluationtypelabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.evalremarkstext = New System.Windows.Forms.TextBox()
        Me.evalsavebutton = New System.Windows.Forms.Button()
        Me.evalcancelbutton = New System.Windows.Forms.Button()
        Me.evaldateText = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.acscoreText = New System.Windows.Forms.TextBox()
        Me.prscoreText = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fscoreText = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee:"
        '
        'employeenamelabel
        '
        Me.employeenamelabel.AutoSize = True
        Me.employeenamelabel.Location = New System.Drawing.Point(151, 20)
        Me.employeenamelabel.Name = "employeenamelabel"
        Me.employeenamelabel.Size = New System.Drawing.Size(78, 13)
        Me.employeenamelabel.TabIndex = 1
        Me.employeenamelabel.Text = "employeename"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Employee number:"
        '
        'employeenumberlabel
        '
        Me.employeenumberlabel.AutoSize = True
        Me.employeenumberlabel.Location = New System.Drawing.Point(151, 44)
        Me.employeenumberlabel.Name = "employeenumberlabel"
        Me.employeenumberlabel.Size = New System.Drawing.Size(87, 13)
        Me.employeenumberlabel.TabIndex = 3
        Me.employeenumberlabel.Text = "employeenumber"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Evaluation type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date:"
        '
        'evaluationtypelabel
        '
        Me.evaluationtypelabel.AutoSize = True
        Me.evaluationtypelabel.Location = New System.Drawing.Point(151, 72)
        Me.evaluationtypelabel.Name = "evaluationtypelabel"
        Me.evaluationtypelabel.Size = New System.Drawing.Size(76, 13)
        Me.evaluationtypelabel.TabIndex = 8
        Me.evaluationtypelabel.Text = "evaluationtype"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Remarks:"
        '
        'evalremarkstext
        '
        Me.evalremarkstext.Location = New System.Drawing.Point(154, 224)
        Me.evalremarkstext.Name = "evalremarkstext"
        Me.evalremarkstext.Size = New System.Drawing.Size(100, 20)
        Me.evalremarkstext.TabIndex = 20
        '
        'evalsavebutton
        '
        Me.evalsavebutton.Location = New System.Drawing.Point(52, 260)
        Me.evalsavebutton.Name = "evalsavebutton"
        Me.evalsavebutton.Size = New System.Drawing.Size(75, 23)
        Me.evalsavebutton.TabIndex = 21
        Me.evalsavebutton.Text = "Save"
        Me.evalsavebutton.UseVisualStyleBackColor = True
        '
        'evalcancelbutton
        '
        Me.evalcancelbutton.Location = New System.Drawing.Point(154, 260)
        Me.evalcancelbutton.Name = "evalcancelbutton"
        Me.evalcancelbutton.Size = New System.Drawing.Size(75, 23)
        Me.evalcancelbutton.TabIndex = 22
        Me.evalcancelbutton.Text = "Cancel"
        Me.evalcancelbutton.UseVisualStyleBackColor = True
        '
        'evaldateText
        '
        Me.evaldateText.FormattingEnabled = True
        Me.evaldateText.Location = New System.Drawing.Point(154, 111)
        Me.evaldateText.Name = "evaldateText"
        Me.evaldateText.Size = New System.Drawing.Size(100, 21)
        Me.evaldateText.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Admin Compliance"
        '
        'acscoreText
        '
        Me.acscoreText.Location = New System.Drawing.Point(154, 143)
        Me.acscoreText.Name = "acscoreText"
        Me.acscoreText.Size = New System.Drawing.Size(100, 20)
        Me.acscoreText.TabIndex = 11
        '
        'prscoreText
        '
        Me.prscoreText.Location = New System.Drawing.Point(155, 171)
        Me.prscoreText.Name = "prscoreText"
        Me.prscoreText.Size = New System.Drawing.Size(100, 20)
        Me.prscoreText.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Performance Rating"
        '
        'fscoreText
        '
        Me.fscoreText.Location = New System.Drawing.Point(154, 199)
        Me.fscoreText.Name = "fscoreText"
        Me.fscoreText.Size = New System.Drawing.Size(100, 20)
        Me.fscoreText.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Final score"
        '
        'EvaluationsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 340)
        Me.Controls.Add(Me.fscoreText)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.prscoreText)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.evaldateText)
        Me.Controls.Add(Me.evalcancelbutton)
        Me.Controls.Add(Me.evalsavebutton)
        Me.Controls.Add(Me.evalremarkstext)
        Me.Controls.Add(Me.acscoreText)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.evaluationtypelabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.employeenumberlabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.employeenamelabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EvaluationsForm"
        Me.Text = "Employee Evaluations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents employeenamelabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents employeenumberlabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents evaluationtypelabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents evalremarkstext As TextBox
    Friend WithEvents evalsavebutton As Button
    Friend WithEvents evalcancelbutton As Button
    Friend WithEvents evaldateText As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents acscoreText As TextBox
    Friend WithEvents prscoreText As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents fscoreText As TextBox
    Friend WithEvents Label8 As Label
End Class
