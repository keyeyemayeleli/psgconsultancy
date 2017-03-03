<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditPassword))
        Me.currentText = New System.Windows.Forms.TextBox()
        Me.newText = New System.Windows.Forms.TextBox()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.confirmText = New System.Windows.Forms.TextBox()
        Me.cancelButton3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'currentText
        '
        Me.currentText.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.currentText.BackColor = System.Drawing.SystemColors.Window
        Me.currentText.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentText.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.currentText.Location = New System.Drawing.Point(35, 27)
        Me.currentText.Name = "currentText"
        Me.currentText.Size = New System.Drawing.Size(335, 35)
        Me.currentText.TabIndex = 2
        Me.currentText.TabStop = False
        Me.currentText.Text = "Enter Current Password"
        '
        'newText
        '
        Me.newText.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.newText.BackColor = System.Drawing.SystemColors.Window
        Me.newText.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newText.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.newText.Location = New System.Drawing.Point(35, 94)
        Me.newText.Name = "newText"
        Me.newText.Size = New System.Drawing.Size(335, 35)
        Me.newText.TabIndex = 3
        Me.newText.TabStop = False
        Me.newText.Text = " Enter New Password"
        '
        'saveButton
        '
        Me.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.saveButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.saveButton.Location = New System.Drawing.Point(35, 230)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(208, 46)
        Me.saveButton.TabIndex = 4
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Wireframes.My.Resources.Resources.line_horizontal
        Me.PictureBox2.Location = New System.Drawing.Point(0, 374)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(454, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = Global.Wireframes.My.Resources.Resources.Logo_3
        Me.PictureBox1.Location = New System.Drawing.Point(0, 418)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'confirmText
        '
        Me.confirmText.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.confirmText.BackColor = System.Drawing.SystemColors.Window
        Me.confirmText.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmText.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.confirmText.Location = New System.Drawing.Point(35, 166)
        Me.confirmText.Name = "confirmText"
        Me.confirmText.Size = New System.Drawing.Size(335, 35)
        Me.confirmText.TabIndex = 8
        Me.confirmText.TabStop = False
        Me.confirmText.Text = " Confirm New Password"
        '
        'cancelButton3
        '
        Me.cancelButton3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cancelButton3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cancelButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cancelButton3.Location = New System.Drawing.Point(35, 301)
        Me.cancelButton3.Name = "cancelButton3"
        Me.cancelButton3.Size = New System.Drawing.Size(208, 46)
        Me.cancelButton3.TabIndex = 9
        Me.cancelButton3.Text = "Cancel"
        Me.cancelButton3.UseVisualStyleBackColor = False
        '
        'EditPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(452, 474)
        Me.Controls.Add(Me.cancelButton3)
        Me.Controls.Add(Me.confirmText)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.newText)
        Me.Controls.Add(Me.currentText)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EditPassword"
        Me.Text = "Edit Password"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents currentText As System.Windows.Forms.TextBox
    Friend WithEvents newText As System.Windows.Forms.TextBox
    Friend WithEvents saveButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents confirmText As System.Windows.Forms.TextBox
    Friend WithEvents cancelButton3 As System.Windows.Forms.Button

End Class
