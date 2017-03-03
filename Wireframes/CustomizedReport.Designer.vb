<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomizedReport
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomizedReport))
        Me.activityDGV = New System.Windows.Forms.DataGridView()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GivenName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.createButton = New System.Windows.Forms.Button()
        Me.cancelButton2 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.positionRadio = New System.Windows.Forms.RadioButton()
        Me.presentaddressLabel = New System.Windows.Forms.Label()
        Me.departmentRadio = New System.Windows.Forms.RadioButton()
        Me.positionText = New System.Windows.Forms.TextBox()
        Me.departmentText = New System.Windows.Forms.TextBox()
        Me.groupText = New System.Windows.Forms.TextBox()
        Me.rankText = New System.Windows.Forms.TextBox()
        Me.groupRadio = New System.Windows.Forms.RadioButton()
        Me.rankRadio = New System.Windows.Forms.RadioButton()
        Me.civilstatusRadio = New System.Windows.Forms.RadioButton()
        Me.civilstatusCombobox = New System.Windows.Forms.ComboBox()
        Me.evalscoreText = New System.Windows.Forms.TextBox()
        Me.evalscoreRadio = New System.Windows.Forms.RadioButton()
        Me.datehiredRadio = New System.Windows.Forms.RadioButton()
        Me.birthdayDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.previewButton = New System.Windows.Forms.Button()
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
        Me.activityDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LastName, Me.GivenName, Me.MiddleName})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.activityDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.activityDGV.Location = New System.Drawing.Point(38, 312)
        Me.activityDGV.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.activityDGV.Name = "activityDGV"
        Me.activityDGV.ReadOnly = True
        Me.activityDGV.Size = New System.Drawing.Size(1094, 224)
        Me.activityDGV.TabIndex = 9
        Me.activityDGV.TabStop = False
        '
        'LastName
        '
        Me.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        '
        'GivenName
        '
        Me.GivenName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GivenName.HeaderText = "Given Name"
        Me.GivenName.Name = "GivenName"
        Me.GivenName.ReadOnly = True
        '
        'MiddleName
        '
        Me.MiddleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MiddleName.HeaderText = "Middle Name"
        Me.MiddleName.Name = "MiddleName"
        Me.MiddleName.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(31, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(381, 31)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Preview of Customized Report"
        '
        'createButton
        '
        Me.createButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.createButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.createButton.Location = New System.Drawing.Point(685, 553)
        Me.createButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.createButton.Name = "createButton"
        Me.createButton.Size = New System.Drawing.Size(210, 45)
        Me.createButton.TabIndex = 20
        Me.createButton.Text = "Create"
        Me.createButton.UseVisualStyleBackColor = False
        '
        'cancelButton2
        '
        Me.cancelButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelButton2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cancelButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cancelButton2.Location = New System.Drawing.Point(922, 553)
        Me.cancelButton2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cancelButton2.Name = "cancelButton2"
        Me.cancelButton2.Size = New System.Drawing.Size(210, 45)
        Me.cancelButton2.TabIndex = 21
        Me.cancelButton2.Text = "Cancel"
        Me.cancelButton2.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = Global.Wireframes.My.Resources.Resources.line_left
        Me.PictureBox3.Location = New System.Drawing.Point(372, 13)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(800, 21)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Wireframes.My.Resources.Resources.line_horizontal
        Me.PictureBox2.Location = New System.Drawing.Point(0, 606)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1172, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'positionRadio
        '
        Me.positionRadio.AutoSize = True
        Me.positionRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.positionRadio.Location = New System.Drawing.Point(38, 128)
        Me.positionRadio.Name = "positionRadio"
        Me.positionRadio.Size = New System.Drawing.Size(113, 29)
        Me.positionRadio.TabIndex = 28
        Me.positionRadio.TabStop = True
        Me.positionRadio.Text = "Position:"
        Me.positionRadio.UseVisualStyleBackColor = True
        '
        'presentaddressLabel
        '
        Me.presentaddressLabel.AutoSize = True
        Me.presentaddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.presentaddressLabel.Location = New System.Drawing.Point(34, 51)
        Me.presentaddressLabel.Name = "presentaddressLabel"
        Me.presentaddressLabel.Size = New System.Drawing.Size(117, 20)
        Me.presentaddressLabel.TabIndex = 29
        Me.presentaddressLabel.Text = "*Choose Filters"
        '
        'departmentRadio
        '
        Me.departmentRadio.AutoSize = True
        Me.departmentRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentRadio.Location = New System.Drawing.Point(38, 181)
        Me.departmentRadio.Name = "departmentRadio"
        Me.departmentRadio.Size = New System.Drawing.Size(147, 29)
        Me.departmentRadio.TabIndex = 30
        Me.departmentRadio.TabStop = True
        Me.departmentRadio.Text = "Department:"
        Me.departmentRadio.UseVisualStyleBackColor = True
        '
        'positionText
        '
        Me.positionText.BackColor = System.Drawing.SystemColors.Window
        Me.positionText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.positionText.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.positionText.Location = New System.Drawing.Point(197, 125)
        Me.positionText.Name = "positionText"
        Me.positionText.Size = New System.Drawing.Size(516, 31)
        Me.positionText.TabIndex = 31
        Me.positionText.TabStop = False
        Me.positionText.Text = "Position"
        '
        'departmentText
        '
        Me.departmentText.BackColor = System.Drawing.SystemColors.Window
        Me.departmentText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentText.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.departmentText.Location = New System.Drawing.Point(197, 180)
        Me.departmentText.Name = "departmentText"
        Me.departmentText.Size = New System.Drawing.Size(516, 31)
        Me.departmentText.TabIndex = 32
        Me.departmentText.TabStop = False
        Me.departmentText.Text = "Department"
        '
        'groupText
        '
        Me.groupText.BackColor = System.Drawing.SystemColors.Window
        Me.groupText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupText.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.groupText.Location = New System.Drawing.Point(197, 241)
        Me.groupText.Name = "groupText"
        Me.groupText.Size = New System.Drawing.Size(516, 31)
        Me.groupText.TabIndex = 36
        Me.groupText.TabStop = False
        Me.groupText.Text = "Group"
        '
        'rankText
        '
        Me.rankText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rankText.BackColor = System.Drawing.SystemColors.Window
        Me.rankText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rankText.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.rankText.Location = New System.Drawing.Point(899, 141)
        Me.rankText.Name = "rankText"
        Me.rankText.Size = New System.Drawing.Size(233, 31)
        Me.rankText.TabIndex = 35
        Me.rankText.TabStop = False
        Me.rankText.Text = "Rank"
        '
        'groupRadio
        '
        Me.groupRadio.AutoSize = True
        Me.groupRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupRadio.Location = New System.Drawing.Point(38, 242)
        Me.groupRadio.Name = "groupRadio"
        Me.groupRadio.Size = New System.Drawing.Size(95, 29)
        Me.groupRadio.TabIndex = 34
        Me.groupRadio.TabStop = True
        Me.groupRadio.Text = "Group:"
        Me.groupRadio.UseVisualStyleBackColor = True
        '
        'rankRadio
        '
        Me.rankRadio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rankRadio.AutoSize = True
        Me.rankRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rankRadio.Location = New System.Drawing.Point(758, 142)
        Me.rankRadio.Name = "rankRadio"
        Me.rankRadio.Size = New System.Drawing.Size(86, 29)
        Me.rankRadio.TabIndex = 33
        Me.rankRadio.TabStop = True
        Me.rankRadio.Text = "Rank:"
        Me.rankRadio.UseVisualStyleBackColor = True
        '
        'civilstatusRadio
        '
        Me.civilstatusRadio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.civilstatusRadio.AutoSize = True
        Me.civilstatusRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.civilstatusRadio.Location = New System.Drawing.Point(758, 76)
        Me.civilstatusRadio.Name = "civilstatusRadio"
        Me.civilstatusRadio.Size = New System.Drawing.Size(144, 29)
        Me.civilstatusRadio.TabIndex = 37
        Me.civilstatusRadio.TabStop = True
        Me.civilstatusRadio.Text = "Civil Status:"
        Me.civilstatusRadio.UseVisualStyleBackColor = True
        '
        'civilstatusCombobox
        '
        Me.civilstatusCombobox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.civilstatusCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.civilstatusCombobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.civilstatusCombobox.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.civilstatusCombobox.FormattingEnabled = True
        Me.civilstatusCombobox.Items.AddRange(New Object() {"Single", "Married", "Widowed"})
        Me.civilstatusCombobox.Location = New System.Drawing.Point(899, 75)
        Me.civilstatusCombobox.Name = "civilstatusCombobox"
        Me.civilstatusCombobox.Size = New System.Drawing.Size(233, 33)
        Me.civilstatusCombobox.TabIndex = 57
        Me.civilstatusCombobox.Text = "Civil Status"
        '
        'evalscoreText
        '
        Me.evalscoreText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.evalscoreText.BackColor = System.Drawing.SystemColors.Window
        Me.evalscoreText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.evalscoreText.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.evalscoreText.Location = New System.Drawing.Point(899, 216)
        Me.evalscoreText.Name = "evalscoreText"
        Me.evalscoreText.Size = New System.Drawing.Size(233, 31)
        Me.evalscoreText.TabIndex = 63
        Me.evalscoreText.TabStop = False
        Me.evalscoreText.Text = "Average Evaluation Score"
        '
        'evalscoreRadio
        '
        Me.evalscoreRadio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.evalscoreRadio.AutoSize = True
        Me.evalscoreRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.evalscoreRadio.Location = New System.Drawing.Point(758, 189)
        Me.evalscoreRadio.Name = "evalscoreRadio"
        Me.evalscoreRadio.Size = New System.Drawing.Size(131, 79)
        Me.evalscoreRadio.TabIndex = 60
        Me.evalscoreRadio.TabStop = True
        Me.evalscoreRadio.Text = "Average" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Evaluation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Score:"
        Me.evalscoreRadio.UseVisualStyleBackColor = True
        '
        'datehiredRadio
        '
        Me.datehiredRadio.AutoSize = True
        Me.datehiredRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datehiredRadio.Location = New System.Drawing.Point(38, 75)
        Me.datehiredRadio.Name = "datehiredRadio"
        Me.datehiredRadio.Size = New System.Drawing.Size(138, 29)
        Me.datehiredRadio.TabIndex = 58
        Me.datehiredRadio.TabStop = True
        Me.datehiredRadio.Text = "Date Hired:"
        Me.datehiredRadio.UseVisualStyleBackColor = True
        '
        'birthdayDate
        '
        Me.birthdayDate.Location = New System.Drawing.Point(263, 78)
        Me.birthdayDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.birthdayDate.Name = "birthdayDate"
        Me.birthdayDate.Size = New System.Drawing.Size(201, 26)
        Me.birthdayDate.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(193, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 25)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(470, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 25)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "To:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(512, 78)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(201, 26)
        Me.DateTimePicker1.TabIndex = 66
        '
        'previewButton
        '
        Me.previewButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.previewButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.previewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.previewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previewButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.previewButton.Location = New System.Drawing.Point(974, 269)
        Me.previewButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.previewButton.Name = "previewButton"
        Me.previewButton.Size = New System.Drawing.Size(158, 35)
        Me.previewButton.TabIndex = 68
        Me.previewButton.Text = "Preview"
        Me.previewButton.UseVisualStyleBackColor = False
        '
        'CustomizedReport
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1170, 650)
        Me.Controls.Add(Me.previewButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.birthdayDate)
        Me.Controls.Add(Me.evalscoreText)
        Me.Controls.Add(Me.evalscoreRadio)
        Me.Controls.Add(Me.datehiredRadio)
        Me.Controls.Add(Me.civilstatusCombobox)
        Me.Controls.Add(Me.civilstatusRadio)
        Me.Controls.Add(Me.groupText)
        Me.Controls.Add(Me.rankText)
        Me.Controls.Add(Me.groupRadio)
        Me.Controls.Add(Me.rankRadio)
        Me.Controls.Add(Me.departmentText)
        Me.Controls.Add(Me.positionText)
        Me.Controls.Add(Me.departmentRadio)
        Me.Controls.Add(Me.presentaddressLabel)
        Me.Controls.Add(Me.positionRadio)
        Me.Controls.Add(Me.cancelButton2)
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
        Me.Name = "CustomizedReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create Customizable Report"
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
    Friend WithEvents cancelButton2 As System.Windows.Forms.Button
    Friend WithEvents LastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GivenName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiddleName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents positionRadio As System.Windows.Forms.RadioButton
    Friend WithEvents presentaddressLabel As System.Windows.Forms.Label
    Friend WithEvents departmentRadio As System.Windows.Forms.RadioButton
    Friend WithEvents positionText As System.Windows.Forms.TextBox
    Friend WithEvents departmentText As System.Windows.Forms.TextBox
    Friend WithEvents groupText As System.Windows.Forms.TextBox
    Friend WithEvents rankText As System.Windows.Forms.TextBox
    Friend WithEvents groupRadio As System.Windows.Forms.RadioButton
    Friend WithEvents rankRadio As System.Windows.Forms.RadioButton
    Friend WithEvents civilstatusRadio As System.Windows.Forms.RadioButton
    Friend WithEvents civilstatusCombobox As System.Windows.Forms.ComboBox
    Friend WithEvents evalscoreText As System.Windows.Forms.TextBox
    Friend WithEvents evalscoreRadio As System.Windows.Forms.RadioButton
    Friend WithEvents datehiredRadio As System.Windows.Forms.RadioButton
    Friend WithEvents birthdayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents previewButton As System.Windows.Forms.Button

End Class
