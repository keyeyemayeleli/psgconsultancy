<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Masterlist
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Masterlist))
        Me.activityDGV = New System.Windows.Forms.DataGridView()
        Me.IDnumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TINNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSSNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Philhealth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagibigNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RTN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HDMFIDNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateHired = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LifelinkIDNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Group = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Position = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Birthplace = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CivilStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresentAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelephoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FathersName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MothersMaidenName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpouseName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpousesBirthday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChildrensName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChildrensBirthday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.createButton = New System.Windows.Forms.Button()
        Me.cancelButton4 = New System.Windows.Forms.Button()
        CType(Me.activityDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'activityDGV
        '
        Me.activityDGV.AllowUserToAddRows = False
        Me.activityDGV.AllowUserToDeleteRows = False
        Me.activityDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.activityDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.activityDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.activityDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.activityDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDnumber, Me.LastName, Me.FirstName, Me.MiddleName, Me.TINNumber, Me.SSSNumber, Me.Philhealth, Me.PagibigNumber, Me.RTN, Me.HDMFIDNumber, Me.DateHired, Me.LifelinkIDNumber, Me.Group, Me.Department, Me.Position, Me.Rank, Me.Bday, Me.Birthplace, Me.CivilStatus, Me.PresentAddress, Me.EmailAddress, Me.ContactNumber, Me.TelephoneNumber, Me.FathersName, Me.MothersMaidenName, Me.SpouseName, Me.SpousesBirthday, Me.ChildrensName, Me.ChildrensBirthday})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.activityDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.activityDGV.Location = New System.Drawing.Point(38, 85)
        Me.activityDGV.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.activityDGV.Name = "activityDGV"
        Me.activityDGV.ReadOnly = True
        Me.activityDGV.Size = New System.Drawing.Size(1094, 406)
        Me.activityDGV.TabIndex = 9
        Me.activityDGV.TabStop = False
        '
        'IDnumber
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDnumber.DefaultCellStyle = DataGridViewCellStyle2
        Me.IDnumber.HeaderText = "ID No."
        Me.IDnumber.Name = "IDnumber"
        Me.IDnumber.ReadOnly = True
        Me.IDnumber.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'LastName
        '
        Me.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        '
        'FirstName
        '
        Me.FirstName.HeaderText = "First Name"
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        '
        'MiddleName
        '
        Me.MiddleName.HeaderText = "Middle Name"
        Me.MiddleName.Name = "MiddleName"
        Me.MiddleName.ReadOnly = True
        '
        'TINNumber
        '
        Me.TINNumber.HeaderText = "TIN Number"
        Me.TINNumber.Name = "TINNumber"
        Me.TINNumber.ReadOnly = True
        '
        'SSSNumber
        '
        Me.SSSNumber.HeaderText = "SSS Number"
        Me.SSSNumber.Name = "SSSNumber"
        Me.SSSNumber.ReadOnly = True
        '
        'Philhealth
        '
        Me.Philhealth.HeaderText = "Philhealth"
        Me.Philhealth.Name = "Philhealth"
        Me.Philhealth.ReadOnly = True
        '
        'PagibigNumber
        '
        Me.PagibigNumber.HeaderText = "Pag-Ibig Number"
        Me.PagibigNumber.Name = "PagibigNumber"
        Me.PagibigNumber.ReadOnly = True
        '
        'RTN
        '
        Me.RTN.HeaderText = "RTN"
        Me.RTN.Name = "RTN"
        Me.RTN.ReadOnly = True
        '
        'HDMFIDNumber
        '
        Me.HDMFIDNumber.HeaderText = "HDMF ID Number"
        Me.HDMFIDNumber.Name = "HDMFIDNumber"
        Me.HDMFIDNumber.ReadOnly = True
        '
        'DateHired
        '
        Me.DateHired.HeaderText = "DateHired"
        Me.DateHired.Name = "DateHired"
        Me.DateHired.ReadOnly = True
        '
        'LifelinkIDNumber
        '
        Me.LifelinkIDNumber.HeaderText = "Lifelink ID No."
        Me.LifelinkIDNumber.Name = "LifelinkIDNumber"
        Me.LifelinkIDNumber.ReadOnly = True
        '
        'Group
        '
        Me.Group.HeaderText = "Group"
        Me.Group.Name = "Group"
        Me.Group.ReadOnly = True
        '
        'Department
        '
        Me.Department.HeaderText = "Department/Unit"
        Me.Department.Name = "Department"
        Me.Department.ReadOnly = True
        '
        'Position
        '
        Me.Position.HeaderText = "Position"
        Me.Position.Name = "Position"
        Me.Position.ReadOnly = True
        '
        'Rank
        '
        Me.Rank.HeaderText = "Rank"
        Me.Rank.Name = "Rank"
        Me.Rank.ReadOnly = True
        '
        'Bday
        '
        Me.Bday.HeaderText = "Birthday"
        Me.Bday.Name = "Bday"
        Me.Bday.ReadOnly = True
        '
        'Birthplace
        '
        Me.Birthplace.HeaderText = "Birthplace"
        Me.Birthplace.Name = "Birthplace"
        Me.Birthplace.ReadOnly = True
        '
        'CivilStatus
        '
        Me.CivilStatus.HeaderText = "Civil Status"
        Me.CivilStatus.Name = "CivilStatus"
        Me.CivilStatus.ReadOnly = True
        '
        'PresentAddress
        '
        Me.PresentAddress.HeaderText = "Present Address"
        Me.PresentAddress.Name = "PresentAddress"
        Me.PresentAddress.ReadOnly = True
        '
        'EmailAddress
        '
        Me.EmailAddress.HeaderText = "Email Address"
        Me.EmailAddress.Name = "EmailAddress"
        Me.EmailAddress.ReadOnly = True
        '
        'ContactNumber
        '
        Me.ContactNumber.HeaderText = "Contact Number"
        Me.ContactNumber.Name = "ContactNumber"
        Me.ContactNumber.ReadOnly = True
        '
        'TelephoneNumber
        '
        Me.TelephoneNumber.HeaderText = "Telephone Number"
        Me.TelephoneNumber.Name = "TelephoneNumber"
        Me.TelephoneNumber.ReadOnly = True
        '
        'FathersName
        '
        Me.FathersName.HeaderText = "Father's Name"
        Me.FathersName.Name = "FathersName"
        Me.FathersName.ReadOnly = True
        '
        'MothersMaidenName
        '
        Me.MothersMaidenName.HeaderText = "Mother's Maiden Name"
        Me.MothersMaidenName.Name = "MothersMaidenName"
        Me.MothersMaidenName.ReadOnly = True
        '
        'SpouseName
        '
        Me.SpouseName.HeaderText = "Spouse's Name"
        Me.SpouseName.Name = "SpouseName"
        Me.SpouseName.ReadOnly = True
        '
        'SpousesBirthday
        '
        Me.SpousesBirthday.HeaderText = "Spouse's Birthday"
        Me.SpousesBirthday.Name = "SpousesBirthday"
        Me.SpousesBirthday.ReadOnly = True
        '
        'ChildrensName
        '
        Me.ChildrensName.HeaderText = "Child/ren's Name"
        Me.ChildrensName.Name = "ChildrensName"
        Me.ChildrensName.ReadOnly = True
        '
        'ChildrensBirthday
        '
        Me.ChildrensBirthday.HeaderText = "Child/ren's  Birthday"
        Me.ChildrensBirthday.Name = "ChildrensBirthday"
        Me.ChildrensBirthday.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(31, 31)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 31)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Preview of Masterlist"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = Global.Wireframes.My.Resources.Resources.line_left
        Me.PictureBox3.Location = New System.Drawing.Point(290, 31)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(882, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Wireframes.My.Resources.Resources.line_horizontal
        Me.PictureBox2.Location = New System.Drawing.Point(0, 590)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1172, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'createButton
        '
        Me.createButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.createButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.createButton.Location = New System.Drawing.Point(673, 519)
        Me.createButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.createButton.Name = "createButton"
        Me.createButton.Size = New System.Drawing.Size(210, 45)
        Me.createButton.TabIndex = 20
        Me.createButton.Text = "Create"
        Me.createButton.UseVisualStyleBackColor = False
        '
        'cancelButton4
        '
        Me.cancelButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelButton4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cancelButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelButton4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cancelButton4.Location = New System.Drawing.Point(922, 519)
        Me.cancelButton4.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cancelButton4.Name = "cancelButton4"
        Me.cancelButton4.Size = New System.Drawing.Size(210, 45)
        Me.cancelButton4.TabIndex = 21
        Me.cancelButton4.Text = "Cancel"
        Me.cancelButton4.UseVisualStyleBackColor = False
        '
        'Masterlist
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1170, 650)
        Me.Controls.Add(Me.cancelButton4)
        Me.Controls.Add(Me.createButton)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.activityDGV)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Masterlist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create Masterlist Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.activityDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents activityDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents createButton As System.Windows.Forms.Button
    Friend WithEvents cancelButton4 As System.Windows.Forms.Button
    Friend WithEvents IDnumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiddleName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TINNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SSSNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Philhealth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PagibigNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RTN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HDMFIDNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateHired As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LifelinkIDNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Group As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Department As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Position As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Birthplace As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CivilStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PresentAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelephoneNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FathersName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MothersMaidenName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpouseName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpousesBirthday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChildrensName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChildrensBirthday As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
