<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empcontrol1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Textfname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Textlname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Textph = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Textsalary = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Dateofbirth = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Dateofjoining = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Butsave = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Butback = New Guna.UI2.WinForms.Guna2Button()
        Me.Texteid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Textaddress = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Combodesig = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Comboshift = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(160, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(160, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date Of Birth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(160, 451)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(659, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Phone Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(658, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Date of joining "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(658, 412)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Salary per month"
        '
        'Textfname
        '
        Me.Textfname.Animated = True
        Me.Textfname.AutoRoundedCorners = True
        Me.Textfname.BorderRadius = 17
        Me.Textfname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textfname.DefaultText = ""
        Me.Textfname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textfname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textfname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textfname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textfname.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.Textfname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Textfname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textfname.Location = New System.Drawing.Point(304, 166)
        Me.Textfname.Name = "Textfname"
        Me.Textfname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textfname.PlaceholderText = ""
        Me.Textfname.SelectedText = ""
        Me.Textfname.Size = New System.Drawing.Size(200, 36)
        Me.Textfname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Textfname.TabIndex = 7
        '
        'Textlname
        '
        Me.Textlname.Animated = True
        Me.Textlname.AutoRoundedCorners = True
        Me.Textlname.BorderRadius = 17
        Me.Textlname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textlname.DefaultText = ""
        Me.Textlname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textlname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textlname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textlname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textlname.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.Textlname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Textlname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textlname.Location = New System.Drawing.Point(304, 246)
        Me.Textlname.Name = "Textlname"
        Me.Textlname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textlname.PlaceholderText = ""
        Me.Textlname.SelectedText = ""
        Me.Textlname.Size = New System.Drawing.Size(200, 36)
        Me.Textlname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Textlname.TabIndex = 8
        '
        'Textph
        '
        Me.Textph.Animated = True
        Me.Textph.AutoRoundedCorners = True
        Me.Textph.BorderRadius = 17
        Me.Textph.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textph.DefaultText = ""
        Me.Textph.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textph.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textph.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textph.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textph.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.Textph.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Textph.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textph.Location = New System.Drawing.Point(803, 94)
        Me.Textph.MaxLength = 10
        Me.Textph.Name = "Textph"
        Me.Textph.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textph.PlaceholderText = ""
        Me.Textph.SelectedText = ""
        Me.Textph.Size = New System.Drawing.Size(200, 36)
        Me.Textph.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Textph.TabIndex = 10
        '
        'Textsalary
        '
        Me.Textsalary.Animated = True
        Me.Textsalary.AutoRoundedCorners = True
        Me.Textsalary.BorderRadius = 17
        Me.Textsalary.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textsalary.DefaultText = ""
        Me.Textsalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textsalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textsalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textsalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textsalary.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.Textsalary.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Textsalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textsalary.Location = New System.Drawing.Point(802, 403)
        Me.Textsalary.Name = "Textsalary"
        Me.Textsalary.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textsalary.PlaceholderText = ""
        Me.Textsalary.SelectedText = ""
        Me.Textsalary.Size = New System.Drawing.Size(200, 36)
        Me.Textsalary.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Textsalary.TabIndex = 11
        '
        'Dateofbirth
        '
        Me.Dateofbirth.Animated = True
        Me.Dateofbirth.BackColor = System.Drawing.Color.Transparent
        Me.Dateofbirth.Checked = True
        Me.Dateofbirth.FillColor = System.Drawing.Color.White
        Me.Dateofbirth.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Dateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Dateofbirth.IndicateFocus = True
        Me.Dateofbirth.Location = New System.Drawing.Point(304, 329)
        Me.Dateofbirth.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Dateofbirth.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Dateofbirth.Name = "Dateofbirth"
        Me.Dateofbirth.Size = New System.Drawing.Size(200, 36)
        Me.Dateofbirth.TabIndex = 12
        Me.Dateofbirth.Value = New Date(2022, 10, 27, 18, 55, 3, 767)
        '
        'Dateofjoining
        '
        Me.Dateofjoining.Animated = True
        Me.Dateofjoining.BackColor = System.Drawing.Color.Transparent
        Me.Dateofjoining.Checked = True
        Me.Dateofjoining.FillColor = System.Drawing.Color.White
        Me.Dateofjoining.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Dateofjoining.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Dateofjoining.IndicateFocus = True
        Me.Dateofjoining.Location = New System.Drawing.Point(802, 167)
        Me.Dateofjoining.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Dateofjoining.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Dateofjoining.Name = "Dateofjoining"
        Me.Dateofjoining.Size = New System.Drawing.Size(200, 36)
        Me.Dateofjoining.TabIndex = 13
        Me.Dateofjoining.Value = New Date(2022, 10, 27, 18, 55, 3, 767)
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
        Me.Butsave.Location = New System.Drawing.Point(1041, 478)
        Me.Butsave.Name = "Butsave"
        Me.Butsave.Size = New System.Drawing.Size(113, 41)
        Me.Butsave.TabIndex = 16
        Me.Butsave.Text = "Save"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.Label8)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1426, 64)
        Me.Guna2Panel1.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Snow
        Me.Label8.Location = New System.Drawing.Point(631, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(268, 24)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "New Employee Registration"
        '
        'Butback
        '
        Me.Butback.Animated = True
        Me.Butback.AutoRoundedCorners = True
        Me.Butback.BorderRadius = 19
        Me.Butback.BorderThickness = 2
        Me.Butback.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Butback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Butback.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Butback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Butback.FillColor = System.Drawing.Color.Transparent
        Me.Butback.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Butback.ForeColor = System.Drawing.Color.Black
        Me.Butback.IndicateFocus = True
        Me.Butback.Location = New System.Drawing.Point(897, 478)
        Me.Butback.Name = "Butback"
        Me.Butback.Size = New System.Drawing.Size(113, 41)
        Me.Butback.TabIndex = 18
        Me.Butback.Text = "Go Back"
        '
        'Texteid
        '
        Me.Texteid.Animated = True
        Me.Texteid.AutoRoundedCorners = True
        Me.Texteid.BorderRadius = 17
        Me.Texteid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Texteid.DefaultText = ""
        Me.Texteid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Texteid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Texteid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Texteid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Texteid.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.Texteid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Texteid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Texteid.Location = New System.Drawing.Point(304, 88)
        Me.Texteid.Name = "Texteid"
        Me.Texteid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Texteid.PlaceholderText = ""
        Me.Texteid.ReadOnly = True
        Me.Texteid.SelectedText = ""
        Me.Texteid.Size = New System.Drawing.Size(200, 36)
        Me.Texteid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Texteid.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(160, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 17)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Employee Id"
        '
        'Textaddress
        '
        Me.Textaddress.Location = New System.Drawing.Point(304, 412)
        Me.Textaddress.Name = "Textaddress"
        Me.Textaddress.Size = New System.Drawing.Size(211, 96)
        Me.Textaddress.TabIndex = 21
        Me.Textaddress.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(659, 255)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Designation"
        '
        'Combodesig
        '
        Me.Combodesig.BackColor = System.Drawing.Color.Transparent
        Me.Combodesig.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Combodesig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combodesig.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Combodesig.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Combodesig.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Combodesig.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Combodesig.ItemHeight = 30
        Me.Combodesig.Items.AddRange(New Object() {"Manager", "Superviser", "Labour", "Driver"})
        Me.Combodesig.Location = New System.Drawing.Point(803, 249)
        Me.Combodesig.Name = "Combodesig"
        Me.Combodesig.Size = New System.Drawing.Size(200, 36)
        Me.Combodesig.TabIndex = 23
        '
        'Comboshift
        '
        Me.Comboshift.BackColor = System.Drawing.Color.Transparent
        Me.Comboshift.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Comboshift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Comboshift.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Comboshift.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Comboshift.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Comboshift.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Comboshift.ItemHeight = 30
        Me.Comboshift.Items.AddRange(New Object() {"Day", "Night"})
        Me.Comboshift.Location = New System.Drawing.Point(802, 332)
        Me.Comboshift.Name = "Comboshift"
        Me.Comboshift.Size = New System.Drawing.Size(200, 36)
        Me.Comboshift.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(658, 338)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 17)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Shift "
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.Label12)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1426, 64)
        Me.Guna2Panel2.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Snow
        Me.Label12.Location = New System.Drawing.Point(631, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 24)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Employee"
        '
        'empcontrol1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Comboshift)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Combodesig)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Textaddress)
        Me.Controls.Add(Me.Texteid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Butback)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Butsave)
        Me.Controls.Add(Me.Dateofjoining)
        Me.Controls.Add(Me.Dateofbirth)
        Me.Controls.Add(Me.Textsalary)
        Me.Controls.Add(Me.Textph)
        Me.Controls.Add(Me.Textlname)
        Me.Controls.Add(Me.Textfname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "empcontrol1"
        Me.Size = New System.Drawing.Size(1426, 530)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Textfname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Textlname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Textph As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Textsalary As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Dateofbirth As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Dateofjoining As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Butsave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Butback As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Texteid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Textaddress As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Combodesig As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Comboshift As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label12 As Label
End Class
