Imports System.Data.SqlClient
Public Class SalesControl
    Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")
    Private Sub Butsearch_Click(sender As Object, e As EventArgs) Handles Butsearch.Click
        con.Open()
        Dim cmd As New SqlCommand("select * from Sales_table where [Bill No]='" & Textsearch.Text & "'", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    Private Sub Butrefresh_Click(sender As Object, e As EventArgs) Handles Butrefresh.Click
        con.Open()
        Dim cmd As New SqlCommand("select * from Sales_table", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    Private Sub Butreport_Click(sender As Object, e As EventArgs) Handles Butreport.Click
        sales_report_viewer.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim salesobj As New Invcontrol
        Form2.Pannel_dashboard.Controls.Add(salesobj)
        salesobj.Show()
        salesobj.BringToFront()
    End Sub

    Private Sub SalesControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim cmd As New SqlCommand("select * from Sales_table", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    'Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
    'ife.ColumnIndex = 8 Then
    'Dim rowindex = DataGridView1.CurrentCell.RowIndex
    'Dim upobj As New Salescontrolup
    ' upobj.bid = DataGridView1.Item(0, rowindex).Value
    'upobj.cname = DataGridView1.Item(1, rowindex).Value
    ' upobj.itname = DataGridView1.Item(2, rowindex).Value
    'upobj.quant = DataGridView1.Item(3, rowindex).Value
    'upobj.rate = DataGridView1.Item(4, rowindex).Value
    'upobj.units = DataGridView1.Item(5, rowindex).Value
    'upobj.tot = DataGridView1.Item(6, rowindex).Value
    'upobj.pid = DataGridView1.Item(7, rowindex).Value
    ' Form2.Pannel_dashboard.Controls.Add(upobj)
    'upobj.Show()
    ' upobj.BringToFront()
    'If
    'End Sub
End Class
