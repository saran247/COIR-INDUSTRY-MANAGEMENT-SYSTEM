<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class purchaseControl1
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
        Me.Butsave = New Guna.UI2.WinForms.Guna2Button()
        Me.Dateofpurchase = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Texttotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Textquantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Textmname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Textsname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Textrate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Textback = New Guna.UI2.WinForms.Guna2Button()
        Me.Textpid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
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
        Me.Butsave.Location = New System.Drawing.Point(1052, 463)
        Me.Butsave.Name = "Butsave"
        Me.Butsave.Size = New System.Drawing.Size(113, 41)
        Me.Butsave.TabIndex = 32
        Me.Butsave.Text = "Save"
        '
        'Dateofpurchase
        '
        Me.Dateofpurchase.Animated = True
        Me.Dateofpurchase.BackColor = System.Drawing.Color.Transparent
        Me.Dateofpurchase.Checked = True
        Me.Dateofpurchase.CustomFormat = ""
        Me.Dateofpurchase.FillColor = System.Drawing.Color.White
        Me.Dateofpurchase.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Dateofpurchase.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dateofpurchase.IndicateFocus = True
        Me.Dateofpurchase.Location = New System.Drawing.Point(311, 405)
        Me.Dateofpurchase.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Dateofpurchase.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Dateofpurchase.Name = "Dateofpurchase"
        Me.Dateofpurchase.Size = New System.Drawing.Size(200, 36)
        Me.Dateofpurchase.TabIndex = 30
        Me.Dateofpurchase.Value = New Date(2022, 10, 27, 18, 55, 3, 767)
        '
        'Texttotal
        '
        Me.Texttotal.Animated = True
        Me.Texttotal.AutoRoundedCorners = True
        Me.Texttotal.BorderRadius = 17
        Me.Texttotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Texttotal.DefaultText = ""
        Me.Texttotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Texttotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Texttotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Texttotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Texttotal.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.Texttotal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Texttotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Texttotal.Location = New System.Drawing.Point(801, 405)
        Me.Texttotal.Name = "Texttotal"
        Me.Texttotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Texttotal.PlaceholderText = "0"
        Me.Texttotal.ReadOnly = True
        Me.Texttotal.SelectedText = ""
        Me.Texttotal.Size = New System.Drawing.Size(200, 36)
        Me.Texttotal.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Texttotal.TabIndex = 29
        '
        'Textquantity
        '
        Me.Textquantity.Animated = True
        Me.Textquantity.AutoRoundedCorners = True
        Me.Textquantity.BorderRadius = 17
        Me.Textquantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textquantity.DefaultText = ""
        Me.Textquantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textquantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textquantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textquantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textquantity.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.Textquantity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Textquantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textquantity.Location = New System.Drawing.Point(801, 131)
        Me.Textquantity.Name = "Textquantity"
        Me.Textquantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textquantity.PlaceholderText = ""
        Me.Textquantity.SelectedText = ""
        Me.Textquantity.Size = New System.Drawing.Size(200, 36)
        Me.Textquantity.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Textquantity.TabIndex = 27
        '
        'Textmname
        '
        Me.Textmname.Animated = True
        Me.Textmname.AutoRoundedCorners = True
        Me.Textmname.BorderRadius = 17
        Me.Textmname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textmname.DefaultText = "Coconut Husk"
        Me.Textmname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textmname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textmname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textmname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textmname.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.Textmname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Textmname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textmname.Location = New System.Drawing.Point(311, 311)
        Me.Textmname.Name = "Textmname"
        Me.Textmname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textmname.PlaceholderText = ""
        Me.Textmname.ReadOnly = True
        Me.Textmname.SelectedText = ""
        Me.Textmname.Size = New System.Drawing.Size(200, 36)
        Me.Textmname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Textmname.TabIndex = 26
        '
        'Textsname
        '
        Me.Textsname.Animated = True
        Me.Textsname.AutoRoundedCorners = True
        Me.Textsname.BorderRadius = 17
        Me.Textsname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textsname.DefaultText = ""
        Me.Textsname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textsname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textsname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textsname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textsname.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.Textsname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Textsname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textsname.Location = New System.Drawing.Point(311, 221)
        Me.Textsname.Name = "Textsname"
        Me.Textsname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textsname.PlaceholderText = ""
        Me.Textsname.SelectedText = ""
        Me.Textsname.Size = New System.Drawing.Size(200, 36)
        Me.Textsname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Textsname.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(692, 414)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(692, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Rate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(692, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Units"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(692, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(167, 414)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Date Of Purchase"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(167, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Material"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Supplier Name"
        '
        'Textrate
        '
        Me.Textrate.Animated = True
        Me.Textrate.AutoRoundedCorners = True
        Me.Textrate.BorderRadius = 17
        Me.Textrate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textrate.DefaultText = ""
        Me.Textrate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textrate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textrate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textrate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textrate.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.Textrate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Textrate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textrate.Location = New System.Drawing.Point(801, 315)
        Me.Textrate.Name = "Textrate"
        Me.Textrate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textrate.PlaceholderText = ""
        Me.Textrate.SelectedText = ""
        Me.Textrate.Size = New System.Drawing.Size(200, 36)
        Me.Textrate.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Textrate.TabIndex = 34
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ComboBox1.ItemHeight = 30
        Me.ComboBox1.Items.AddRange(New Object() {"Peice"})
        Me.ComboBox1.Location = New System.Drawing.Point(801, 221)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 36)
        Me.ComboBox1.TabIndex = 36
        '
        'Textback
        '
        Me.Textback.Animated = True
        Me.Textback.AutoRoundedCorners = True
        Me.Textback.BorderRadius = 19
        Me.Textback.BorderThickness = 2
        Me.Textback.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Textback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Textback.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Textback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Textback.FillColor = System.Drawing.Color.Transparent
        Me.Textback.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Textback.ForeColor = System.Drawing.Color.Black
        Me.Textback.IndicateFocus = True
        Me.Textback.Location = New System.Drawing.Point(898, 463)
        Me.Textback.Name = "Textback"
        Me.Textback.Size = New System.Drawing.Size(113, 41)
        Me.Textback.TabIndex = 37
        Me.Textback.Text = "Go Back"
        '
        'Textpid
        '
        Me.Textpid.Animated = True
        Me.Textpid.AutoRoundedCorners = True
        Me.Textpid.BorderRadius = 17
        Me.Textpid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textpid.DefaultText = ""
        Me.Textpid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textpid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textpid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textpid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textpid.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.Textpid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Textpid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textpid.Location = New System.Drawing.Point(311, 131)
        Me.Textpid.Name = "Textpid"
        Me.Textpid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textpid.PlaceholderText = ""
        Me.Textpid.ReadOnly = True
        Me.Textpid.SelectedText = ""
        Me.Textpid.Size = New System.Drawing.Size(200, 36)
        Me.Textpid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Textpid.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(167, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 17)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Purchase Id"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Label8)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1426, 64)
        Me.Guna2Panel1.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Snow
        Me.Label8.Location = New System.Drawing.Point(631, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 24)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Purchase"
        '
        'purchaseControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Textpid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Textback)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Textrate)
        Me.Controls.Add(Me.Butsave)
        Me.Controls.Add(Me.Dateofpurchase)
        Me.Controls.Add(Me.Texttotal)
        Me.Controls.Add(Me.Textquantity)
        Me.Controls.Add(Me.Textmname)
        Me.Controls.Add(Me.Textsname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "purchaseControl1"
        Me.Size = New System.Drawing.Size(1426, 530)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Butsave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Dateofpurchase As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Texttotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Textquantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Textmname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Textsname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Textrate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Textback As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Textpid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label8 As Label
End Class
