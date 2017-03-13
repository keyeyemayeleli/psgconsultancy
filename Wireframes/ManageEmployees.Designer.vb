<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageEmployees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageEmployees))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.statusCombobox = New System.Windows.Forms.ComboBox()
        Me.createButton = New System.Windows.Forms.Button()
        Me.filterCombobox = New System.Windows.Forms.ComboBox()
        Me.backButton = New System.Windows.Forms.Button()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.viewEmployee = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.manageemployeesDGV = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.searchText = New Wireframes.WatermarkTextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.manageemployeesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'statusCombobox
        '
        Me.statusCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.statusCombobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusCombobox.ForeColor = System.Drawing.Color.Gray
        Me.statusCombobox.FormattingEnabled = True
        Me.statusCombobox.Items.AddRange(New Object() {"Probationary", "Part-Time", "OJT", "Regular", "Resigned", "Terminated", "End of Contract"})
        Me.statusCombobox.Location = New System.Drawing.Point(40, 53)
        Me.statusCombobox.Name = "statusCombobox"
        Me.statusCombobox.Size = New System.Drawing.Size(235, 37)
        Me.statusCombobox.TabIndex = 51
        Me.statusCombobox.TabStop = False
        Me.statusCombobox.Text = "Choose Status"
        '
        'createButton
        '
        Me.createButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.createButton.BackColor = System.Drawing.Color.SteelBlue
        Me.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.createButton.Location = New System.Drawing.Point(258, 580)
        Me.createButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.createButton.Name = "createButton"
        Me.createButton.Size = New System.Drawing.Size(318, 45)
        Me.createButton.TabIndex = 50
        Me.createButton.Text = "Create Employee 201 File"
        Me.createButton.UseVisualStyleBackColor = False
        '
        'filterCombobox
        '
        Me.filterCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.filterCombobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filterCombobox.ForeColor = System.Drawing.Color.Gray
        Me.filterCombobox.FormattingEnabled = True
        Me.filterCombobox.Items.AddRange(New Object() {"Name", "Position", "Date Hired", "Birthday", "Group", "Department/Unit"})
        Me.filterCombobox.Location = New System.Drawing.Point(291, 53)
        Me.filterCombobox.Name = "filterCombobox"
        Me.filterCombobox.Size = New System.Drawing.Size(264, 37)
        Me.filterCombobox.TabIndex = 49
        Me.filterCombobox.TabStop = False
        Me.filterCombobox.Text = "c"
        '
        'backButton
        '
        Me.backButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.backButton.BackColor = System.Drawing.Color.SteelBlue
        Me.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.backButton.Location = New System.Drawing.Point(929, 580)
        Me.backButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(210, 45)
        Me.backButton.TabIndex = 48
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = False
        '
        'searchButton
        '
        Me.searchButton.BackColor = System.Drawing.Color.SteelBlue
        Me.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.searchButton.Location = New System.Drawing.Point(971, 54)
        Me.searchButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(168, 40)
        Me.searchButton.TabIndex = 47
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(35, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 25)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Filters"
        '
        'viewEmployee
        '
        Me.viewEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewEmployee.BackColor = System.Drawing.Color.SteelBlue
        Me.viewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.viewEmployee.Location = New System.Drawing.Point(595, 580)
        Me.viewEmployee.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.viewEmployee.Name = "viewEmployee"
        Me.viewEmployee.Size = New System.Drawing.Size(317, 45)
        Me.viewEmployee.TabIndex = 45
        Me.viewEmployee.Text = "View Employee 201 File"
        Me.viewEmployee.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(258, 643)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(912, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'manageemployeesDGV
        '
        Me.manageemployeesDGV.AllowUserToAddRows = False
        Me.manageemployeesDGV.AllowUserToDeleteRows = False
        Me.manageemployeesDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.manageemployeesDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.manageemployeesDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.manageemployeesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.manageemployeesDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.manageemployeesDGV.Location = New System.Drawing.Point(40, 115)
        Me.manageemployeesDGV.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.manageemployeesDGV.MultiSelect = False
        Me.manageemployeesDGV.Name = "manageemployeesDGV"
        Me.manageemployeesDGV.ReadOnly = True
        Me.manageemployeesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.manageemployeesDGV.Size = New System.Drawing.Size(1099, 440)
        Me.manageemployeesDGV.TabIndex = 43
        Me.manageemployeesDGV.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(621, 56)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(291, 29)
        Me.DateTimePicker1.TabIndex = 42
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(109, 19)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1061, 21)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 41
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Wireframes.My.Resources.Resources.Logo_3
        Me.PictureBox1.Location = New System.Drawing.Point(40, 619)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'searchText
        '
        Me.searchText.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchText.ForeColor = System.Drawing.Color.Gray
        Me.searchText.Location = New System.Drawing.Point(578, 54)
        Me.searchText.Name = "searchText"
        Me.searchText.Size = New System.Drawing.Size(366, 35)
        Me.searchText.TabIndex = 52
        Me.searchText.Watermark = "Search"
        '
        'ManageEmployees
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1170, 680)
        Me.Controls.Add(Me.searchText)
        Me.Controls.Add(Me.statusCombobox)
        Me.Controls.Add(Me.createButton)
        Me.Controls.Add(Me.filterCombobox)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.viewEmployee)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.manageemployeesDGV)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "ManageEmployees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manage Employee 201 Files"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.manageemployeesDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents searchText As Wireframes.WatermarkTextBox
    Friend WithEvents statusCombobox As System.Windows.Forms.ComboBox
    Friend WithEvents createButton As System.Windows.Forms.Button
    Friend WithEvents filterCombobox As System.Windows.Forms.ComboBox
    Friend WithEvents backButton As System.Windows.Forms.Button
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents viewEmployee As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents manageemployeesDGV As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
