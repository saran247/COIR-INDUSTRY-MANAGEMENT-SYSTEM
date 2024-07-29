<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Skscoirs = New System.Windows.Forms.Label()
        Me.Butclose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Butlogin = New Guna.UI2.WinForms.Guna2Button()
        Me.Buttpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Buttuser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Skscoirs)
        Me.Guna2Panel1.Controls.Add(Me.Butclose)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(419, 113)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Skscoirs
        '
        Me.Skscoirs.AutoSize = True
        Me.Skscoirs.BackColor = System.Drawing.Color.Transparent
        Me.Skscoirs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Skscoirs.Font = New System.Drawing.Font("Voice In My Head", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Skscoirs.ForeColor = System.Drawing.Color.Snow
        Me.Skscoirs.Location = New System.Drawing.Point(26, 42)
        Me.Skscoirs.Name = "Skscoirs"
        Me.Skscoirs.Size = New System.Drawing.Size(381, 50)
        Me.Skscoirs.TabIndex = 7
        Me.Skscoirs.Text = "Sri Vari Fibres"
        '
        'Butclose
        '
        Me.Butclose.BackColor = System.Drawing.Color.Transparent
        Me.Butclose.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Butclose.HoverState.ImageSize = New System.Drawing.Size(34, 34)
        Me.Butclose.Image = CType(resources.GetObject("Butclose.Image"), System.Drawing.Image)
        Me.Butclose.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Butclose.ImageRotate = 0!
        Me.Butclose.ImageSize = New System.Drawing.Size(24, 24)
        Me.Butclose.IndicateFocus = True
        Me.Butclose.Location = New System.Drawing.Point(362, -9)
        Me.Butclose.Name = "Butclose"
        Me.Butclose.PressedState.ImageSize = New System.Drawing.Size(44, 44)
        Me.Butclose.Size = New System.Drawing.Size(62, 67)
        Me.Butclose.TabIndex = 0
        Me.Butclose.UseTransparentBackground = True
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel2.Controls.Add(Me.Guna2CheckBox1)
        Me.Guna2Panel2.Controls.Add(Me.Butlogin)
        Me.Guna2Panel2.Controls.Add(Me.Buttpass)
        Me.Guna2Panel2.Controls.Add(Me.Buttuser)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 113)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(419, 256)
        Me.Guna2Panel2.TabIndex = 1
        '
        'Guna2CheckBox1
        '
        Me.Guna2CheckBox1.AutoSize = True
        Me.Guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox1.CheckedState.BorderRadius = 0
        Me.Guna2CheckBox1.CheckedState.BorderThickness = 0
        Me.Guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.Lime
        Me.Guna2CheckBox1.CheckMarkColor = System.Drawing.Color.Snow
        Me.Guna2CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Guna2CheckBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2CheckBox1.Location = New System.Drawing.Point(213, 164)
        Me.Guna2CheckBox1.Name = "Guna2CheckBox1"
        Me.Guna2CheckBox1.Size = New System.Drawing.Size(102, 17)
        Me.Guna2CheckBox1.TabIndex = 5
        Me.Guna2CheckBox1.Text = "Show Password"
        Me.Guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CheckBox1.UncheckedState.BorderRadius = 0
        Me.Guna2CheckBox1.UncheckedState.BorderThickness = 0
        Me.Guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.Silver
        '
        'Butlogin
        '
        Me.Butlogin.Animated = True
        Me.Butlogin.AutoRoundedCorners = True
        Me.Butlogin.BackColor = System.Drawing.Color.Transparent
        Me.Butlogin.BorderRadius = 15
        Me.Butlogin.BorderThickness = 1
        Me.Butlogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Butlogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Butlogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Butlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Butlogin.FillColor = System.Drawing.Color.Transparent
        Me.Butlogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Butlogin.ForeColor = System.Drawing.Color.Black
        Me.Butlogin.Location = New System.Drawing.Point(140, 202)
        Me.Butlogin.Name = "Butlogin"
        Me.Butlogin.Size = New System.Drawing.Size(122, 32)
        Me.Butlogin.TabIndex = 4
        Me.Butlogin.Text = "Login"
        Me.Butlogin.UseTransparentBackground = True
        '
        'Buttpass
        '
        Me.Buttpass.Animated = True
        Me.Buttpass.AutoRoundedCorners = True
        Me.Buttpass.BorderRadius = 17
        Me.Buttpass.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Buttpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Buttpass.DefaultText = ""
        Me.Buttpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Buttpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Buttpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Buttpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Buttpass.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.Buttpass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Buttpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Buttpass.Location = New System.Drawing.Point(105, 101)
        Me.Buttpass.Name = "Buttpass"
        Me.Buttpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Buttpass.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Buttpass.PlaceholderText = "Password"
        Me.Buttpass.SelectedText = ""
        Me.Buttpass.Size = New System.Drawing.Size(200, 36)
        Me.Buttpass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Buttpass.TabIndex = 3
        Me.Buttpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Buttuser
        '
        Me.Buttuser.Animated = True
        Me.Buttuser.AutoRoundedCorners = True
        Me.Buttuser.BorderRadius = 17
        Me.Buttuser.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Buttuser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Buttuser.DefaultText = ""
        Me.Buttuser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Buttuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Buttuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Buttuser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Buttuser.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.Buttuser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Buttuser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Buttuser.Location = New System.Drawing.Point(105, 36)
        Me.Buttuser.Name = "Buttuser"
        Me.Buttuser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Buttuser.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Buttuser.PlaceholderText = "User name"
        Me.Buttuser.SelectedText = ""
        Me.Buttuser.Size = New System.Drawing.Size(200, 36)
        Me.Buttuser.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Buttuser.TabIndex = 0
        Me.Buttuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 369)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Butlogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Buttpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Buttuser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Butclose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Skscoirs As Label
End Class
