<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchasecontrol
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Purchasecontrol))
        Me.DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.PurchasetableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoirDBDataSet = New COIR_INDUSTRY_MANAGEMENT_SYSTEM.coirDBDataSet1()
        Me.Purchase_tableTableAdapter = New COIR_INDUSTRY_MANAGEMENT_SYSTEM.coirDBDataSet1TableAdapters.Purchase_tableTableAdapter()
        Me.Butrefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.Butaddnew = New Guna.UI2.WinForms.Guna2Button()
        Me.Textsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Butsearch = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Butreport = New Guna.UI2.WinForms.Guna2Button()
        Me.PurchaseIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfPurchaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasetableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoirDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DataGridView1.ColumnHeadersHeight = 15
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PurchaseIdDataGridViewTextBoxColumn, Me.MaterialNameDataGridViewTextBoxColumn, Me.SupplierNameDataGridViewTextBoxColumn, Me.DateOfPurchaseDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.UnitsDataGridViewTextBoxColumn, Me.RateDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.Edit})
        Me.DataGridView1.DataSource = Me.PurchasetableBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(40, 163)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1287, 237)
        Me.DataGridView1.TabIndex = 0
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
        'PurchasetableBindingSource
        '
        Me.PurchasetableBindingSource.DataMember = "Purchase_table"
        Me.PurchasetableBindingSource.DataSource = Me.CoirDBDataSet
        '
        'CoirDBDataSet
        '
        Me.CoirDBDataSet.DataSetName = "coirDBDataSet"
        Me.CoirDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Purchase_tableTableAdapter
        '
        Me.Purchase_tableTableAdapter.ClearBeforeFill = True
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
        Me.Butrefresh.Location = New System.Drawing.Point(1070, 84)
        Me.Butrefresh.Name = "Butrefresh"
        Me.Butrefresh.Size = New System.Drawing.Size(180, 45)
        Me.Butrefresh.TabIndex = 13
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
        Me.Butaddnew.Location = New System.Drawing.Point(635, 84)
        Me.Butaddnew.Name = "Butaddnew"
        Me.Butaddnew.Size = New System.Drawing.Size(180, 45)
        Me.Butaddnew.TabIndex = 12
        Me.Butaddnew.Text = "New Purchase"
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
        Me.Textsearch.Location = New System.Drawing.Point(51, 84)
        Me.Textsearch.Name = "Textsearch"
        Me.Textsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textsearch.PlaceholderText = "search (Ex 1001)"
        Me.Textsearch.SelectedText = ""
        Me.Textsearch.Size = New System.Drawing.Size(243, 36)
        Me.Textsearch.TabIndex = 11
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
        Me.Butsearch.Location = New System.Drawing.Point(300, 75)
        Me.Butsearch.Name = "Butsearch"
        Me.Butsearch.PressedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.Butsearch.Size = New System.Drawing.Size(64, 54)
        Me.Butsearch.TabIndex = 10
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
        Me.Guna2Panel1.TabIndex = 14
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
        'Butreport
        '
        Me.Butreport.Animated = True
        Me.Butreport.AutoRoundedCorners = True
        Me.Butreport.BorderRadius = 21
        Me.Butreport.BorderThickness = 2
        Me.Butreport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Butreport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Butreport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Butreport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Butreport.FillColor = System.Drawing.Color.Transparent
        Me.Butreport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Butreport.ForeColor = System.Drawing.Color.Black
        Me.Butreport.IndicateFocus = True
        Me.Butreport.Location = New System.Drawing.Point(861, 84)
        Me.Butreport.Name = "Butreport"
        Me.Butreport.Size = New System.Drawing.Size(180, 45)
        Me.Butreport.TabIndex = 39
        Me.Butreport.Text = "Report"
        '
        'PurchaseIdDataGridViewTextBoxColumn
        '
        Me.PurchaseIdDataGridViewTextBoxColumn.DataPropertyName = "Purchase Id"
        Me.PurchaseIdDataGridViewTextBoxColumn.HeaderText = "Purchase Id"
        Me.PurchaseIdDataGridViewTextBoxColumn.Name = "PurchaseIdDataGridViewTextBoxColumn"
        Me.PurchaseIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaterialNameDataGridViewTextBoxColumn
        '
        Me.MaterialNameDataGridViewTextBoxColumn.DataPropertyName = "Material Name"
        Me.MaterialNameDataGridViewTextBoxColumn.HeaderText = "Material Name"
        Me.MaterialNameDataGridViewTextBoxColumn.Name = "MaterialNameDataGridViewTextBoxColumn"
        '
        'SupplierNameDataGridViewTextBoxColumn
        '
        Me.SupplierNameDataGridViewTextBoxColumn.DataPropertyName = "Supplier name"
        Me.SupplierNameDataGridViewTextBoxColumn.HeaderText = "Supplier name"
        Me.SupplierNameDataGridViewTextBoxColumn.Name = "SupplierNameDataGridViewTextBoxColumn"
        '
        'DateOfPurchaseDataGridViewTextBoxColumn
        '
        Me.DateOfPurchaseDataGridViewTextBoxColumn.DataPropertyName = "Date of purchase"
        Me.DateOfPurchaseDataGridViewTextBoxColumn.HeaderText = "Date of purchase"
        Me.DateOfPurchaseDataGridViewTextBoxColumn.Name = "DateOfPurchaseDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'UnitsDataGridViewTextBoxColumn
        '
        Me.UnitsDataGridViewTextBoxColumn.DataPropertyName = "Units"
        Me.UnitsDataGridViewTextBoxColumn.HeaderText = "Units"
        Me.UnitsDataGridViewTextBoxColumn.Name = "UnitsDataGridViewTextBoxColumn"
        '
        'RateDataGridViewTextBoxColumn
        '
        Me.RateDataGridViewTextBoxColumn.DataPropertyName = "Rate"
        Me.RateDataGridViewTextBoxColumn.HeaderText = "Rate"
        Me.RateDataGridViewTextBoxColumn.Name = "RateDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'Edit
        '
        Me.Edit.HeaderText = "Edit"
        Me.Edit.Name = "Edit"
        Me.Edit.Text = "Edit"
        Me.Edit.UseColumnTextForButtonValue = True
        '
        'Purchasecontrol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Butreport)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Butrefresh)
        Me.Controls.Add(Me.Butaddnew)
        Me.Controls.Add(Me.Textsearch)
        Me.Controls.Add(Me.Butsearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Purchasecontrol"
        Me.Size = New System.Drawing.Size(1426, 530)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasetableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoirDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents PurchasetableBindingSource As BindingSource
    Friend WithEvents CoirDBDataSet As coirDBDataSet1
    Friend WithEvents Purchase_tableTableAdapter As coirDBDataSet1TableAdapters.Purchase_tableTableAdapter
    Friend WithEvents Butrefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Butaddnew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Textsearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Butsearch As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Butreport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PurchaseIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfPurchaseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
End Class
