<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmpControl))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.EmptableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoirDBDataSet = New COIR_INDUSTRY_MANAGEMENT_SYSTEM.coirDBDataSet1()
        Me.Butrefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.Butaddnew = New Guna.UI2.WinForms.Guna2Button()
        Me.Textsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Butsearch = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermenentAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfJoiningDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryPerMonthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.EmployeeIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermenentAddressDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfJoiningDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobDesignationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShiftDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryPerMonthDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.EmptableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Emp_tableTableAdapter = New COIR_INDUSTRY_MANAGEMENT_SYSTEM.coirDBDataSet1TableAdapters.Emp_tableTableAdapter()
        CType(Me.EmptableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoirDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmptableBindingSource
        '
        Me.EmptableBindingSource.DataMember = "Emp_table"
        Me.EmptableBindingSource.DataSource = Me.CoirDBDataSet
        '
        'CoirDBDataSet
        '
        Me.CoirDBDataSet.DataSetName = "coirDBDataSet"
        Me.CoirDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Butrefresh
        '
        Me.Butrefresh.Animated = True
        Me.Butrefresh.AutoRoundedCorners = True
        Me.Butrefresh.BackColor = System.Drawing.Color.Transparent
        Me.Butrefresh.BorderRadius = 17
        Me.Butrefresh.BorderThickness = 2
        Me.Butrefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Butrefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Butrefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Butrefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Butrefresh.FillColor = System.Drawing.Color.Transparent
        Me.Butrefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Butrefresh.ForeColor = System.Drawing.Color.Black
        Me.Butrefresh.IndicateFocus = True
        Me.Butrefresh.Location = New System.Drawing.Point(1088, 95)
        Me.Butrefresh.Name = "Butrefresh"
        Me.Butrefresh.Size = New System.Drawing.Size(180, 45)
        Me.Butrefresh.TabIndex = 9
        Me.Butrefresh.Text = "Refresh"
        Me.Butrefresh.UseTransparentBackground = True
        '
        'Butaddnew
        '
        Me.Butaddnew.Animated = True
        Me.Butaddnew.AutoRoundedCorners = True
        Me.Butaddnew.BackColor = System.Drawing.Color.Transparent
        Me.Butaddnew.BorderRadius = 17
        Me.Butaddnew.BorderThickness = 2
        Me.Butaddnew.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Butaddnew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Butaddnew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Butaddnew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Butaddnew.FillColor = System.Drawing.Color.Transparent
        Me.Butaddnew.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Butaddnew.ForeColor = System.Drawing.Color.Black
        Me.Butaddnew.IndicateFocus = True
        Me.Butaddnew.Location = New System.Drawing.Point(686, 95)
        Me.Butaddnew.Name = "Butaddnew"
        Me.Butaddnew.Size = New System.Drawing.Size(180, 45)
        Me.Butaddnew.TabIndex = 8
        Me.Butaddnew.Text = "Add New Employee"
        Me.Butaddnew.UseTransparentBackground = True
        '
        'Textsearch
        '
        Me.Textsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textsearch.DefaultText = ""
        Me.Textsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Textsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textsearch.Location = New System.Drawing.Point(69, 95)
        Me.Textsearch.Name = "Textsearch"
        Me.Textsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textsearch.PlaceholderText = "search (Ex 1001)"
        Me.Textsearch.SelectedText = ""
        Me.Textsearch.Size = New System.Drawing.Size(243, 36)
        Me.Textsearch.TabIndex = 7
        '
        'Butsearch
        '
        Me.Butsearch.BackColor = System.Drawing.Color.Transparent
        Me.Butsearch.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Butsearch.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.Butsearch.Image = CType(resources.GetObject("Butsearch.Image"), System.Drawing.Image)
        Me.Butsearch.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Butsearch.ImageRotate = 0!
        Me.Butsearch.ImageSize = New System.Drawing.Size(20, 20)
        Me.Butsearch.IndicateFocus = True
        Me.Butsearch.Location = New System.Drawing.Point(318, 86)
        Me.Butsearch.Name = "Butsearch"
        Me.Butsearch.PressedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.Butsearch.Size = New System.Drawing.Size(64, 54)
        Me.Butsearch.TabIndex = 6
        Me.Butsearch.UseTransparentBackground = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Label8)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1426, 64)
        Me.Guna2Panel1.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Snow
        Me.Label8.Location = New System.Drawing.Point(631, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 24)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Employee"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 17
        Me.Guna2Button1.BorderThickness = 2
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.IndicateFocus = True
        Me.Guna2Button1.Location = New System.Drawing.Point(895, 95)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button1.TabIndex = 14
        Me.Guna2Button1.Text = "Report"
        Me.Guna2Button1.UseTransparentBackground = True
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "Employee ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        Me.EmployeeIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeeIDDataGridViewTextBoxColumn.Width = 143
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.Width = 143
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.Width = 143
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date of birth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date of birth"
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        Me.DateOfBirthDataGridViewTextBoxColumn.Width = 143
        '
        'PermenentAddressDataGridViewTextBoxColumn
        '
        Me.PermenentAddressDataGridViewTextBoxColumn.DataPropertyName = "Permenent Address"
        Me.PermenentAddressDataGridViewTextBoxColumn.HeaderText = "Permenent Address"
        Me.PermenentAddressDataGridViewTextBoxColumn.Name = "PermenentAddressDataGridViewTextBoxColumn"
        Me.PermenentAddressDataGridViewTextBoxColumn.Width = 143
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone number"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone number"
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        Me.PhoneNumberDataGridViewTextBoxColumn.Width = 143
        '
        'DateOfJoiningDataGridViewTextBoxColumn
        '
        Me.DateOfJoiningDataGridViewTextBoxColumn.DataPropertyName = "Date of joining"
        Me.DateOfJoiningDataGridViewTextBoxColumn.HeaderText = "Date of joining"
        Me.DateOfJoiningDataGridViewTextBoxColumn.Name = "DateOfJoiningDataGridViewTextBoxColumn"
        Me.DateOfJoiningDataGridViewTextBoxColumn.Width = 143
        '
        'SalaryPerMonthDataGridViewTextBoxColumn
        '
        Me.SalaryPerMonthDataGridViewTextBoxColumn.DataPropertyName = "Salary per month"
        Me.SalaryPerMonthDataGridViewTextBoxColumn.HeaderText = "Salary per month"
        Me.SalaryPerMonthDataGridViewTextBoxColumn.Name = "SalaryPerMonthDataGridViewTextBoxColumn"
        Me.SalaryPerMonthDataGridViewTextBoxColumn.Width = 143
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 28
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeIDDataGridViewTextBoxColumn1, Me.FirstNameDataGridViewTextBoxColumn1, Me.LastNameDataGridViewTextBoxColumn1, Me.DateOfBirthDataGridViewTextBoxColumn1, Me.PermenentAddressDataGridViewTextBoxColumn1, Me.PhoneNumberDataGridViewTextBoxColumn1, Me.DateOfJoiningDataGridViewTextBoxColumn1, Me.JobDesignationDataGridViewTextBoxColumn, Me.ShiftDataGridViewTextBoxColumn, Me.SalaryPerMonthDataGridViewTextBoxColumn1, Me.Edit})
        Me.DataGridView1.DataSource = Me.EmptableBindingSource1
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(62, 185)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1280, 268)
        Me.DataGridView1.TabIndex = 15
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ThemeStyle.HeaderStyle.Height = 28
        Me.DataGridView1.ThemeStyle.ReadOnly = False
        Me.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'EmployeeIDDataGridViewTextBoxColumn1
        '
        Me.EmployeeIDDataGridViewTextBoxColumn1.DataPropertyName = "Employee ID"
        Me.EmployeeIDDataGridViewTextBoxColumn1.HeaderText = "Employee ID"
        Me.EmployeeIDDataGridViewTextBoxColumn1.Name = "EmployeeIDDataGridViewTextBoxColumn1"
        '
        'FirstNameDataGridViewTextBoxColumn1
        '
        Me.FirstNameDataGridViewTextBoxColumn1.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn1.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn1.Name = "FirstNameDataGridViewTextBoxColumn1"
        '
        'LastNameDataGridViewTextBoxColumn1
        '
        Me.LastNameDataGridViewTextBoxColumn1.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn1.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn1.Name = "LastNameDataGridViewTextBoxColumn1"
        '
        'DateOfBirthDataGridViewTextBoxColumn1
        '
        Me.DateOfBirthDataGridViewTextBoxColumn1.DataPropertyName = "Date of birth"
        Me.DateOfBirthDataGridViewTextBoxColumn1.HeaderText = "Date of birth"
        Me.DateOfBirthDataGridViewTextBoxColumn1.Name = "DateOfBirthDataGridViewTextBoxColumn1"
        '
        'PermenentAddressDataGridViewTextBoxColumn1
        '
        Me.PermenentAddressDataGridViewTextBoxColumn1.DataPropertyName = "Permenent Address"
        Me.PermenentAddressDataGridViewTextBoxColumn1.HeaderText = "Permenent Address"
        Me.PermenentAddressDataGridViewTextBoxColumn1.Name = "PermenentAddressDataGridViewTextBoxColumn1"
        '
        'PhoneNumberDataGridViewTextBoxColumn1
        '
        Me.PhoneNumberDataGridViewTextBoxColumn1.DataPropertyName = "Phone number"
        Me.PhoneNumberDataGridViewTextBoxColumn1.HeaderText = "Phone number"
        Me.PhoneNumberDataGridViewTextBoxColumn1.Name = "PhoneNumberDataGridViewTextBoxColumn1"
        '
        'DateOfJoiningDataGridViewTextBoxColumn1
        '
        Me.DateOfJoiningDataGridViewTextBoxColumn1.DataPropertyName = "Date of joining"
        Me.DateOfJoiningDataGridViewTextBoxColumn1.HeaderText = "Date of joining"
        Me.DateOfJoiningDataGridViewTextBoxColumn1.Name = "DateOfJoiningDataGridViewTextBoxColumn1"
        '
        'JobDesignationDataGridViewTextBoxColumn
        '
        Me.JobDesignationDataGridViewTextBoxColumn.DataPropertyName = "Job Designation"
        Me.JobDesignationDataGridViewTextBoxColumn.HeaderText = "Job Designation"
        Me.JobDesignationDataGridViewTextBoxColumn.Name = "JobDesignationDataGridViewTextBoxColumn"
        '
        'ShiftDataGridViewTextBoxColumn
        '
        Me.ShiftDataGridViewTextBoxColumn.DataPropertyName = "Shift"
        Me.ShiftDataGridViewTextBoxColumn.HeaderText = "Shift"
        Me.ShiftDataGridViewTextBoxColumn.Name = "ShiftDataGridViewTextBoxColumn"
        '
        'SalaryPerMonthDataGridViewTextBoxColumn1
        '
        Me.SalaryPerMonthDataGridViewTextBoxColumn1.DataPropertyName = "Salary per month"
        Me.SalaryPerMonthDataGridViewTextBoxColumn1.HeaderText = "Salary per month"
        Me.SalaryPerMonthDataGridViewTextBoxColumn1.Name = "SalaryPerMonthDataGridViewTextBoxColumn1"
        '
        'Edit
        '
        Me.Edit.HeaderText = "Edit"
        Me.Edit.Name = "Edit"
        Me.Edit.Text = "Edit"
        Me.Edit.UseColumnTextForButtonValue = True
        '
        'EmptableBindingSource1
        '
        Me.EmptableBindingSource1.DataMember = "Emp_table"
        Me.EmptableBindingSource1.DataSource = Me.CoirDBDataSet
        '
        'Emp_tableTableAdapter
        '
        Me.Emp_tableTableAdapter.ClearBeforeFill = True
        '
        'EmpControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Butrefresh)
        Me.Controls.Add(Me.Butaddnew)
        Me.Controls.Add(Me.Textsearch)
        Me.Controls.Add(Me.Butsearch)
        Me.Name = "EmpControl"
        Me.Size = New System.Drawing.Size(1426, 530)
        CType(Me.EmptableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoirDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EmptableBindingSource As BindingSource
    Friend WithEvents CoirDBDataSet As coirDBDataSet1
    Friend WithEvents Butrefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Butaddnew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Textsearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Butsearch As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PermenentAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfJoiningDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalaryPerMonthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents EmptableBindingSource1 As BindingSource
    Friend WithEvents Emp_tableTableAdapter As coirDBDataSet1TableAdapters.Emp_tableTableAdapter
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PermenentAddressDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DateOfJoiningDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents JobDesignationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShiftDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalaryPerMonthDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
End Class
