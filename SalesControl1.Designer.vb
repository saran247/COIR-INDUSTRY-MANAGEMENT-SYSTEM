<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesControl1
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Textcustname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Textquantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Textrate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Texttotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Combounit = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Butprint = New Guna.UI2.WinForms.Guna2Button()
        Me.Butgoback = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Textitem = New Guna.UI2.WinForms.Guna2TextBox()
        Me.comboitemid = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Textbid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Label8)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1426, 55)
        Me.Guna2Panel1.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Snow
        Me.Label8.Location = New System.Drawing.Point(624, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 24)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Sales Invoice "
        '
        'Textcustname
        '
        Me.Textcustname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textcustname.DefaultText = ""
        Me.Textcustname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textcustname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textcustname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textcustname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textcustname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textcustname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Textcustname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textcustname.Location = New System.Drawing.Point(149, 144)
        Me.Textcustname.Name = "Textcustname"
        Me.Textcustname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textcustname.PlaceholderText = ""
        Me.Textcustname.SelectedText = ""
        Me.Textcustname.Size = New System.Drawing.Size(200, 36)
        Me.Textcustname.TabIndex = 16
        '
        'Textquantity
        '
        Me.Textquantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textquantity.DefaultText = ""
        Me.Textquantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textquantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textquantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textquantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textquantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textquantity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Textquantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textquantity.Location = New System.Drawing.Point(514, 92)
        Me.Textquantity.Name = "Textquantity"
        Me.Textquantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textquantity.PlaceholderText = ""
        Me.Textquantity.SelectedText = ""
        Me.Textquantity.Size = New System.Drawing.Size(200, 36)
        Me.Textquantity.TabIndex = 18
        '
        'Textrate
        '
        Me.Textrate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textrate.DefaultText = ""
        Me.Textrate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textrate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textrate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textrate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textrate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textrate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Textrate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textrate.Location = New System.Drawing.Point(514, 144)
        Me.Textrate.Name = "Textrate"
        Me.Textrate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textrate.PlaceholderText = ""
        Me.Textrate.SelectedText = ""
        Me.Textrate.Size = New System.Drawing.Size(200, 36)
        Me.Textrate.TabIndex = 19
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
        Me.Texttotal.Location = New System.Drawing.Point(514, 253)
        Me.Texttotal.Name = "Texttotal"
        Me.Texttotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Texttotal.PlaceholderText = ""
        Me.Texttotal.ReadOnly = True
        Me.Texttotal.SelectedText = ""
        Me.Texttotal.Size = New System.Drawing.Size(200, 36)
        Me.Texttotal.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Item Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(381, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(381, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Rate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(381, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Unit"
        '
        'Combounit
        '
        Me.Combounit.BackColor = System.Drawing.Color.Transparent
        Me.Combounit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Combounit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combounit.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Combounit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Combounit.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Combounit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Combounit.ItemHeight = 30
        Me.Combounit.Items.AddRange(New Object() {"Kg"})
        Me.Combounit.Location = New System.Drawing.Point(514, 199)
        Me.Combounit.Name = "Combounit"
        Me.Combounit.Size = New System.Drawing.Size(200, 36)
        Me.Combounit.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(383, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Total"
        '
        'Butprint
        '
        Me.Butprint.Animated = True
        Me.Butprint.AutoRoundedCorners = True
        Me.Butprint.BorderRadius = 19
        Me.Butprint.BorderThickness = 2
        Me.Butprint.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Butprint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Butprint.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Butprint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Butprint.FillColor = System.Drawing.Color.Transparent
        Me.Butprint.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Butprint.ForeColor = System.Drawing.Color.Black
        Me.Butprint.IndicateFocus = True
        Me.Butprint.Location = New System.Drawing.Point(601, 357)
        Me.Butprint.Name = "Butprint"
        Me.Butprint.Size = New System.Drawing.Size(113, 41)
        Me.Butprint.TabIndex = 29
        Me.Butprint.Text = "Print"
        '
        'Butgoback
        '
        Me.Butgoback.Animated = True
        Me.Butgoback.AutoRoundedCorners = True
        Me.Butgoback.BorderRadius = 19
        Me.Butgoback.BorderThickness = 2
        Me.Butgoback.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Butgoback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Butgoback.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Butgoback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Butgoback.FillColor = System.Drawing.Color.Transparent
        Me.Butgoback.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Butgoback.ForeColor = System.Drawing.Color.Black
        Me.Butgoback.IndicateFocus = True
        Me.Butgoback.Location = New System.Drawing.Point(19, 360)
        Me.Butgoback.Name = "Butgoback"
        Me.Butgoback.Size = New System.Drawing.Size(113, 41)
        Me.Butgoback.TabIndex = 39
        Me.Butgoback.Text = "Go Back"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Textitem)
        Me.Guna2Panel2.Controls.Add(Me.comboitemid)
        Me.Guna2Panel2.Controls.Add(Me.Label10)
        Me.Guna2Panel2.Controls.Add(Me.Label9)
        Me.Guna2Panel2.Controls.Add(Me.Textbid)
        Me.Guna2Panel2.Controls.Add(Me.Label7)
        Me.Guna2Panel2.Controls.Add(Me.Textcustname)
        Me.Guna2Panel2.Controls.Add(Me.Butprint)
        Me.Guna2Panel2.Controls.Add(Me.Butgoback)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Controls.Add(Me.Label6)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Controls.Add(Me.Texttotal)
        Me.Guna2Panel2.Controls.Add(Me.Label5)
        Me.Guna2Panel2.Controls.Add(Me.Combounit)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.Textquantity)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.Textrate)
        Me.Guna2Panel2.Location = New System.Drawing.Point(289, 66)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(746, 439)
        Me.Guna2Panel2.TabIndex = 40
        '
        'Textitem
        '
        Me.Textitem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textitem.DefaultText = ""
        Me.Textitem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textitem.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textitem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textitem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textitem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textitem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Textitem.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textitem.Location = New System.Drawing.Point(149, 260)
        Me.Textitem.Name = "Textitem"
        Me.Textitem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textitem.PlaceholderText = ""
        Me.Textitem.SelectedText = ""
        Me.Textitem.Size = New System.Drawing.Size(200, 36)
        Me.Textitem.TabIndex = 45
        '
        'comboitemid
        '
        Me.comboitemid.BackColor = System.Drawing.Color.Transparent
        Me.comboitemid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboitemid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboitemid.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comboitemid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comboitemid.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboitemid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.comboitemid.ItemHeight = 30
        Me.comboitemid.Location = New System.Drawing.Point(149, 200)
        Me.comboitemid.Name = "comboitemid"
        Me.comboitemid.Size = New System.Drawing.Size(200, 36)
        Me.comboitemid.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 17)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Item Id"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 17)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Bill No"
        '
        'Textbid
        '
        Me.Textbid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbid.DefaultText = ""
        Me.Textbid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textbid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textbid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textbid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textbid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textbid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Textbid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textbid.Location = New System.Drawing.Point(149, 92)
        Me.Textbid.Name = "Textbid"
        Me.Textbid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textbid.PlaceholderText = ""
        Me.Textbid.ReadOnly = True
        Me.Textbid.SelectedText = ""
        Me.Textbid.Size = New System.Drawing.Size(200, 36)
        Me.Textbid.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(359, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 17)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "INVOICE"
        '
        'SalesControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "SalesControl1"
        Me.Size = New System.Drawing.Size(1426, 530)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Textcustname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Textquantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Textrate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Texttotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Combounit As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Butprint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Butgoback As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Textbid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents comboitemid As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Textitem As Guna.UI2.WinForms.Guna2TextBox
End Class
