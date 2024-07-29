<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalaryControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Butsave = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Butrefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.Salreport = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.SalaryIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfIssueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthlySalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryIssuedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalarytableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoirDBDataSet1 = New COIR_INDUSTRY_MANAGEMENT_SYSTEM.coirDBDataSet1()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Dateofissue = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Textename = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Comboempid = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Textsid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Texttotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Textremarks = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Textmsalary = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Salary_tableTableAdapter = New COIR_INDUSTRY_MANAGEMENT_SYSTEM.coirDBDataSet1TableAdapters.Salary_tableTableAdapter()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalarytableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoirDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Butsave
        '
        Me.Butsave.Animated = True
        Me.Butsave.AutoRoundedCorners = True
        Me.Butsave.BorderRadius = 19
        Me.Butsave.BorderThickness = 2
        Me.Butsave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Butsave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Butsave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Butsave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Butsave.FillColor = System.Drawing.Color.Transparent
        Me.Butsave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Butsave.ForeColor = System.Drawing.Color.Black
        Me.Butsave.IndicateFocus = True
        Me.Butsave.Location = New System.Drawing.Point(979, 24)
        Me.Butsave.Name = "Butsave"
        Me.Butsave.Size = New System.Drawing.Size(113, 41)
        Me.Butsave.TabIndex = 61
        Me.Butsave.Text = "Confirm"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel3.BorderRadius = 2
        Me.Guna2Panel3.BorderThickness = 2
        Me.Guna2Panel3.Controls.Add(Me.Butrefresh)
        Me.Guna2Panel3.Controls.Add(Me.Salreport)
        Me.Guna2Panel3.Controls.Add(Me.DataGridView1)
        Me.Guna2Panel3.Location = New System.Drawing.Point(31, 263)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(1283, 266)
        Me.Guna2Panel3.TabIndex = 66
        '
        'Butrefresh
        '
        Me.Butrefresh.Animated = True
        Me.Butrefresh.AutoRoundedCorners = True
        Me.Butrefresh.BorderRadius = 19
        Me.Butrefresh.BorderThickness = 2
        Me.Butrefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Butrefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Butrefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Butrefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Butrefresh.FillColor = System.Drawing.Color.Transparent
        Me.Butrefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Butrefresh.ForeColor = System.Drawing.Color.Black
        Me.Butrefresh.IndicateFocus = True
        Me.Butrefresh.Location = New System.Drawing.Point(957, 211)
        Me.Butrefresh.Name = "Butrefresh"
        Me.Butrefresh.Size = New System.Drawing.Size(113, 41)
        Me.Butrefresh.TabIndex = 62
        Me.Butrefresh.Text = "Refresh"
        '
        'Salreport
        '
        Me.Salreport.Animated = True
        Me.Salreport.AutoRoundedCorners = True
        Me.Salreport.BorderRadius = 19
        Me.Salreport.BorderThickness = 2
        Me.Salreport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Salreport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Salreport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Salreport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Salreport.FillColor = System.Drawing.Color.Transparent
        Me.Salreport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Salreport.ForeColor = System.Drawing.Color.Black
        Me.Salreport.IndicateFocus = True
        Me.Salreport.Location = New System.Drawing.Point(1122, 211)
        Me.Salreport.Name = "Salreport"
        Me.Salreport.Size = New System.Drawing.Size(113, 41)
        Me.Salreport.TabIndex = 62
        Me.Salreport.Text = "Report"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
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
        Me.DataGridView1.ColumnHeadersHeight = 15
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SalaryIdDataGridViewTextBoxColumn, Me.EmployeeNameDataGridViewTextBoxColumn, Me.DateOfIssueDataGridViewTextBoxColumn, Me.MonthlySalaryDataGridViewTextBoxColumn, Me.RemarksDataGridViewTextBoxColumn, Me.SalaryIssuedDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SalarytableBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(88, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1099, 173)
        Me.DataGridView1.TabIndex = 59
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
        Me.DataGridView1.ThemeStyle.HeaderStyle.Height = 15
        Me.DataGridView1.ThemeStyle.ReadOnly = False
        Me.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'SalaryIdDataGridViewTextBoxColumn
        '
        Me.SalaryIdDataGridViewTextBoxColumn.DataPropertyName = "Salary Id"
        Me.SalaryIdDataGridViewTextBoxColumn.HeaderText = "Salary Id"
        Me.SalaryIdDataGridViewTextBoxColumn.Name = "SalaryIdDataGridViewTextBoxColumn"
        '
        'EmployeeNameDataGridViewTextBoxColumn
        '
        Me.EmployeeNameDataGridViewTextBoxColumn.DataPropertyName = "Employee Name"
        Me.EmployeeNameDataGridViewTextBoxColumn.HeaderText = "Employee Name"
        Me.EmployeeNameDataGridViewTextBoxColumn.Name = "EmployeeNameDataGridViewTextBoxColumn"
        '
        'DateOfIssueDataGridViewTextBoxColumn
        '
        Me.DateOfIssueDataGridViewTextBoxColumn.DataPropertyName = "Date of Issue"
        Me.DateOfIssueDataGridViewTextBoxColumn.HeaderText = "Date of Issue"
        Me.DateOfIssueDataGridViewTextBoxColumn.Name = "DateOfIssueDataGridViewTextBoxColumn"
        '
        'MonthlySalaryDataGridViewTextBoxColumn
        '
        Me.MonthlySalaryDataGridViewTextBoxColumn.DataPropertyName = "Monthly Salary "
        Me.MonthlySalaryDataGridViewTextBoxColumn.HeaderText = "Monthly Salary "
        Me.MonthlySalaryDataGridViewTextBoxColumn.Name = "MonthlySalaryDataGridViewTextBoxColumn"
        '
        'RemarksDataGridViewTextBoxColumn
        '
        Me.RemarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks"
        Me.RemarksDataGridViewTextBoxColumn.HeaderText = "Remarks"
        Me.RemarksDataGridViewTextBoxColumn.Name = "RemarksDataGridViewTextBoxColumn"
        '
        'SalaryIssuedDataGridViewTextBoxColumn
        '
        Me.SalaryIssuedDataGridViewTextBoxColumn.DataPropertyName = "Salary Issued"
        Me.SalaryIssuedDataGridViewTextBoxColumn.HeaderText = "Salary Issued"
        Me.SalaryIssuedDataGridViewTextBoxColumn.Name = "SalaryIssuedDataGridViewTextBoxColumn"
        '
        'SalarytableBindingSource
        '
        Me.SalarytableBindingSource.DataMember = "Salary_table"
        Me.SalarytableBindingSource.DataSource = Me.CoirDBDataSet1
        '
        'CoirDBDataSet1
        '
        Me.CoirDBDataSet1.DataSetName = "coirDBDataSet1"
        Me.CoirDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel4.BorderRadius = 2
        Me.Guna2Panel4.BorderThickness = 2
        Me.Guna2Panel4.Controls.Add(Me.Label12)
        Me.Guna2Panel4.Controls.Add(Me.Dateofissue)
        Me.Guna2Panel4.Controls.Add(Me.Label2)
        Me.Guna2Panel4.Controls.Add(Me.Textename)
        Me.Guna2Panel4.Controls.Add(Me.Label1)
        Me.Guna2Panel4.Controls.Add(Me.Label3)
        Me.Guna2Panel4.Controls.Add(Me.Comboempid)
        Me.Guna2Panel4.Controls.Add(Me.Textsid)
        Me.Guna2Panel4.Controls.Add(Me.Label9)
        Me.Guna2Panel4.Location = New System.Drawing.Point(31, 64)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(1283, 98)
        Me.Guna2Panel4.TabIndex = 67
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(5, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 17)
        Me.Label12.TabIndex = 47
        '
        'Dateofissue
        '
        Me.Dateofissue.Animated = True
        Me.Dateofissue.BackColor = System.Drawing.Color.Transparent
        Me.Dateofissue.Checked = True
        Me.Dateofissue.CustomFormat = ""
        Me.Dateofissue.FillColor = System.Drawing.Color.White
        Me.Dateofissue.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Dateofissue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dateofissue.IndicateFocus = True
        Me.Dateofissue.Location = New System.Drawing.Point(1059, 31)
        Me.Dateofissue.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Dateofissue.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Dateofissue.Name = "Dateofissue"
        Me.Dateofissue.Size = New System.Drawing.Size(177, 36)
        Me.Dateofissue.TabIndex = 45
        Me.Dateofissue.Value = New Date(2022, 10, 27, 18, 55, 3, 767)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(996, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Date"
        '
        'Textename
        '
        Me.Textename.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textename.DefaultText = ""
        Me.Textename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textename.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textename.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Textename.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textename.Location = New System.Drawing.Point(784, 32)
        Me.Textename.Name = "Textename"
        Me.Textename.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textename.PlaceholderText = ""
        Me.Textename.SelectedText = ""
        Me.Textename.Size = New System.Drawing.Size(175, 36)
        Me.Textename.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(654, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Employee Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(314, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Employee ID"
        '
        'Comboempid
        '
        Me.Comboempid.BackColor = System.Drawing.Color.Transparent
        Me.Comboempid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Comboempid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Comboempid.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Comboempid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Comboempid.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Comboempid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Comboempid.ItemHeight = 30
        Me.Comboempid.Location = New System.Drawing.Point(433, 28)
        Me.Comboempid.Name = "Comboempid"
        Me.Comboempid.Size = New System.Drawing.Size(175, 36)
        Me.Comboempid.TabIndex = 46
        '
        'Textsid
        '
        Me.Textsid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textsid.DefaultText = ""
        Me.Textsid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textsid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textsid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textsid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textsid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textsid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Textsid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textsid.Location = New System.Drawing.Point(88, 28)
        Me.Textsid.Name = "Textsid"
        Me.Textsid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textsid.PlaceholderText = ""
        Me.Textsid.ReadOnly = True
        Me.Textsid.SelectedText = ""
        Me.Textsid.Size = New System.Drawing.Size(175, 36)
        Me.Textsid.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 17)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Salary Id"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Snow
        Me.Label8.Location = New System.Drawing.Point(624, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 24)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Salary"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Label8)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1426, 55)
        Me.Guna2Panel1.TabIndex = 64
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.BorderRadius = 2
        Me.Guna2Panel2.BorderThickness = 2
        Me.Guna2Panel2.Controls.Add(Me.Butsave)
        Me.Guna2Panel2.Controls.Add(Me.Texttotal)
        Me.Guna2Panel2.Controls.Add(Me.Label6)
        Me.Guna2Panel2.Controls.Add(Me.Textremarks)
        Me.Guna2Panel2.Controls.Add(Me.Label5)
        Me.Guna2Panel2.Controls.Add(Me.Textmsalary)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Location = New System.Drawing.Point(32, 166)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1283, 91)
        Me.Guna2Panel2.TabIndex = 68
        '
        'Texttotal
        '
        Me.Texttotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Texttotal.DefaultText = ""
        Me.Texttotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Texttotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Texttotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Texttotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Texttotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Texttotal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Texttotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Texttotal.Location = New System.Drawing.Point(736, 27)
        Me.Texttotal.Name = "Texttotal"
        Me.Texttotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Texttotal.PlaceholderText = ""
        Me.Texttotal.ReadOnly = True
        Me.Texttotal.SelectedText = ""
        Me.Texttotal.Size = New System.Drawing.Size(175, 36)
        Me.Texttotal.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(670, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Total"
        '
        'Textremarks
        '
        Me.Textremarks.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textremarks.DefaultText = ""
        Me.Textremarks.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textremarks.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textremarks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textremarks.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textremarks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textremarks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Textremarks.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textremarks.Location = New System.Drawing.Point(443, 27)
        Me.Textremarks.Name = "Textremarks"
        Me.Textremarks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textremarks.PlaceholderText = ""
        Me.Textremarks.SelectedText = ""
        Me.Textremarks.Size = New System.Drawing.Size(175, 36)
        Me.Textremarks.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(360, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Remarks"
        '
        'Textmsalary
        '
        Me.Textmsalary.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textmsalary.DefaultText = ""
        Me.Textmsalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textmsalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textmsalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textmsalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textmsalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textmsalary.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Textmsalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textmsalary.Location = New System.Drawing.Point(135, 29)
        Me.Textmsalary.Name = "Textmsalary"
        Me.Textmsalary.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textmsalary.PlaceholderText = ""
        Me.Textmsalary.ReadOnly = True
        Me.Textmsalary.SelectedText = ""
        Me.Textmsalary.Size = New System.Drawing.Size(175, 36)
        Me.Textmsalary.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 17)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Salary Per Month"
        '
        'Salary_tableTableAdapter
        '
        Me.Salary_tableTableAdapter.ClearBeforeFill = True
        '
        'SalaryControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "SalaryControl"
        Me.Size = New System.Drawing.Size(1426, 530)
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalarytableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoirDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Butsave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Dateofissue As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Textename As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Comboempid As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Textsid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Salreport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Texttotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Textremarks As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Textmsalary As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SalaryIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfIssueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonthlySalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemarksDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalaryIssuedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalarytableBindingSource As BindingSource
    Friend WithEvents CoirDBDataSet1 As coirDBDataSet1
    Friend WithEvents Salary_tableTableAdapter As coirDBDataSet1TableAdapters.Salary_tableTableAdapter
    Friend WithEvents Butrefresh As Guna.UI2.WinForms.Guna2Button
End Class
