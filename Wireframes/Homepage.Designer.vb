<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Homepage))
        Me.manageButton = New System.Windows.Forms.Button()
        Me.activityDGV = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.retrieveButton = New System.Windows.Forms.Button()
        Me.logoutButton = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.currentuser_label = New System.Windows.Forms.Label()
        Me.reportsButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.activityDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'manageButton
        '
        Me.manageButton.BackColor = System.Drawing.Color.SteelBlue
        Me.manageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.manageButton.Font = New System.Drawing.Font("WeblySleek UI Semilight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.manageButton.Location = New System.Drawing.Point(38, 288)
        Me.manageButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.manageButton.Name = "manageButton"
        Me.manageButton.Size = New System.Drawing.Size(383, 92)
        Me.manageButton.TabIndex = 4
        Me.manageButton.Text = "Manage Employee 201 Files"
        Me.manageButton.UseVisualStyleBackColor = False
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.activityDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.activityDGV.Location = New System.Drawing.Point(455, 146)
        Me.activityDGV.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.activityDGV.Name = "activityDGV"
        Me.activityDGV.ReadOnly = True
        Me.activityDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.activityDGV.Size = New System.Drawing.Size(668, 369)
        Me.activityDGV.TabIndex = 9
        Me.activityDGV.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Oswald", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(449, 107)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 31)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Activity Log"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(769, 106)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(201, 29)
        Me.DateTimePicker1.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(777, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 21)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Search Activity Log by Date"
        '
        'searchButton
        '
        Me.searchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchButton.BackColor = System.Drawing.Color.SteelBlue
        Me.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchButton.Font = New System.Drawing.Font("WeblySleek UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.searchButton.Location = New System.Drawing.Point(977, 103)
        Me.searchButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(144, 35)
        Me.searchButton.TabIndex = 19
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = False
        '
        'retrieveButton
        '
        Me.retrieveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.retrieveButton.BackColor = System.Drawing.Color.SteelBlue
        Me.retrieveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.retrieveButton.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retrieveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.retrieveButton.Location = New System.Drawing.Point(911, 534)
        Me.retrieveButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.retrieveButton.Name = "retrieveButton"
        Me.retrieveButton.Size = New System.Drawing.Size(210, 45)
        Me.retrieveButton.TabIndex = 20
        Me.retrieveButton.Text = "Retrieve Activity Log"
        Me.retrieveButton.UseVisualStyleBackColor = False
        '
        'logoutButton
        '
        Me.logoutButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.logoutButton.BackColor = System.Drawing.Color.SteelBlue
        Me.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutButton.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.logoutButton.Location = New System.Drawing.Point(911, 622)
        Me.logoutButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.logoutButton.Name = "logoutButton"
        Me.logoutButton.Size = New System.Drawing.Size(210, 45)
        Me.logoutButton.TabIndex = 21
        Me.logoutButton.Text = "Log-Out"
        Me.logoutButton.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = Global.Wireframes.My.Resources.Resources.line_left
        Me.PictureBox3.Location = New System.Drawing.Point(1, 40)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1169, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Wireframes.My.Resources.Resources.line_horizontal
        Me.PictureBox2.Location = New System.Drawing.Point(1, 597)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1179, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("WeblySleek UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(878, 8)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 28)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Logged in as:"
        '
        'currentuser_label
        '
        Me.currentuser_label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.currentuser_label.AutoSize = True
        Me.currentuser_label.BackColor = System.Drawing.Color.Transparent
        Me.currentuser_label.Font = New System.Drawing.Font("WeblySleek UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentuser_label.ForeColor = System.Drawing.Color.SteelBlue
        Me.currentuser_label.Location = New System.Drawing.Point(1006, 8)
        Me.currentuser_label.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.currentuser_label.Name = "currentuser_label"
        Me.currentuser_label.Size = New System.Drawing.Size(117, 28)
        Me.currentuser_label.TabIndex = 14
        Me.currentuser_label.Text = "currentuser"
        '
        'reportsButton
        '
        Me.reportsButton.BackColor = System.Drawing.Color.SteelBlue
        Me.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reportsButton.Font = New System.Drawing.Font("WeblySleek UI Semilight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.reportsButton.Location = New System.Drawing.Point(38, 423)
        Me.reportsButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.reportsButton.Name = "reportsButton"
        Me.reportsButton.Size = New System.Drawing.Size(383, 92)
        Me.reportsButton.TabIndex = 25
        Me.reportsButton.Text = "Create Reports"
        Me.reportsButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Oswald", 20.25!, System.Drawing.FontStyle.Italic)
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(129, 134)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 40)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Employee 201 File System"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Wireframes.My.Resources.Resources.Logo_3
        Me.PictureBox1.Location = New System.Drawing.Point(38, 160)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(383, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Homepage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1170, 680)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.reportsButton)
        Me.Controls.Add(Me.logoutButton)
        Me.Controls.Add(Me.retrieveButton)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.currentuser_label)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.activityDGV)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.manageButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Homepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Homepage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.activityDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents manageButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents activityDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents retrieveButton As System.Windows.Forms.Button
    Friend WithEvents logoutButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As Label
    Friend WithEvents currentuser_label As Label
    Friend WithEvents reportsButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
