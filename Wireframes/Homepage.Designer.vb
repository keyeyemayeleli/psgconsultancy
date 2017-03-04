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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.activityDGV = New System.Windows.Forms.DataGridView()
        Me.masterlistButton = New System.Windows.Forms.Button()
        Me.accountingButton = New System.Windows.Forms.Button()
        Me.customizableButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.editpasswordButton = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.retrieveButton = New System.Windows.Forms.Button()
        Me.logoutButton = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.currentuser_label = New System.Windows.Forms.Label()
        CType(Me.activityDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'manageButton
        '
        Me.manageButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.manageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.manageButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.manageButton.Location = New System.Drawing.Point(38, 135)
        Me.manageButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.manageButton.Name = "manageButton"
        Me.manageButton.Size = New System.Drawing.Size(360, 48)
        Me.manageButton.TabIndex = 4
        Me.manageButton.Text = "Manage Employee 201 Files"
        Me.manageButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(64, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Employee 201 File System"
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
        'masterlistButton
        '
        Me.masterlistButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.masterlistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.masterlistButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.masterlistButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.masterlistButton.Location = New System.Drawing.Point(38, 309)
        Me.masterlistButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.masterlistButton.Name = "masterlistButton"
        Me.masterlistButton.Size = New System.Drawing.Size(360, 48)
        Me.masterlistButton.TabIndex = 10
        Me.masterlistButton.Text = "Create Masterlist Report"
        Me.masterlistButton.UseVisualStyleBackColor = False
        '
        'accountingButton
        '
        Me.accountingButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.accountingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.accountingButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountingButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.accountingButton.Location = New System.Drawing.Point(38, 384)
        Me.accountingButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.accountingButton.Name = "accountingButton"
        Me.accountingButton.Size = New System.Drawing.Size(360, 48)
        Me.accountingButton.TabIndex = 11
        Me.accountingButton.Text = "Create Accounting Report"
        Me.accountingButton.UseVisualStyleBackColor = False
        '
        'customizableButton
        '
        Me.customizableButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.customizableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.customizableButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customizableButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.customizableButton.Location = New System.Drawing.Point(38, 460)
        Me.customizableButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.customizableButton.Name = "customizableButton"
        Me.customizableButton.Size = New System.Drawing.Size(360, 48)
        Me.customizableButton.TabIndex = 12
        Me.customizableButton.Text = "Create Customizable Report"
        Me.customizableButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(449, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Activity Log"
        '
        'editpasswordButton
        '
        Me.editpasswordButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.editpasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editpasswordButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editpasswordButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.editpasswordButton.Location = New System.Drawing.Point(38, 531)
        Me.editpasswordButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.editpasswordButton.Name = "editpasswordButton"
        Me.editpasswordButton.Size = New System.Drawing.Size(360, 48)
        Me.editpasswordButton.TabIndex = 15
        Me.editpasswordButton.Text = "Edit Password"
        Me.editpasswordButton.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.Location = New System.Drawing.Point(769, 106)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(201, 26)
        Me.DateTimePicker1.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Location = New System.Drawing.Point(783, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Search Activity Log by Date"
        '
        'searchButton
        '
        Me.searchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.retrieveButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.retrieveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.retrieveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.logoutButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.PictureBox2.Location = New System.Drawing.Point(1, 597)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1179, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Wireframes.My.Resources.Resources.Logo_3
        Me.PictureBox1.Location = New System.Drawing.Point(1, 52)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(344, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(38, 210)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(360, 75)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Manage Terminated Employee 201 Files"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(449, 79)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Logged in as"
        '
        'currentuser_label
        '
        Me.currentuser_label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.currentuser_label.AutoSize = True
        Me.currentuser_label.BackColor = System.Drawing.Color.Transparent
        Me.currentuser_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentuser_label.ForeColor = System.Drawing.Color.RoyalBlue
        Me.currentuser_label.Location = New System.Drawing.Point(582, 80)
        Me.currentuser_label.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.currentuser_label.Name = "currentuser_label"
        Me.currentuser_label.Size = New System.Drawing.Size(121, 25)
        Me.currentuser_label.TabIndex = 14
        Me.currentuser_label.Text = "currentuser"
        '
        'Homepage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1170, 680)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.logoutButton)
        Me.Controls.Add(Me.retrieveButton)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.editpasswordButton)
        Me.Controls.Add(Me.currentuser_label)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.customizableButton)
        Me.Controls.Add(Me.accountingButton)
        Me.Controls.Add(Me.masterlistButton)
        Me.Controls.Add(Me.activityDGV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents activityDGV As System.Windows.Forms.DataGridView
    Friend WithEvents masterlistButton As System.Windows.Forms.Button
    Friend WithEvents accountingButton As System.Windows.Forms.Button
    Friend WithEvents customizableButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents editpasswordButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents retrieveButton As System.Windows.Forms.Button
    Friend WithEvents logoutButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As Label
    Friend WithEvents currentuser_label As Label
End Class
