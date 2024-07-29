Imports System.Data.SqlClient

Public Class EmpControl
    Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")
    Private Sub EmpControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim cmd As New SqlCommand("select * from Emp_table", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    Private Sub Butrefresh_Click(sender As Object, e As EventArgs) Handles Butrefresh.Click
        con.Open()
        Dim cmd As New SqlCommand("select * from Emp_table", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    Private Sub Butaddnew_Click(sender As Object, e As EventArgs) Handles Butaddnew.Click
        Dim empobj As New empcontrol1
        Form2.Pannel_dashboard.Controls.Add(empobj)
        empobj.Show()
        empobj.BringToFront()
    End Sub

    Private Sub Butsearch_Click(sender As Object, e As EventArgs) Handles Butsearch.Click
        con.Open()
        Dim cmd As New SqlCommand("select * from Emp_table where [Employee Id]='" & Textsearch.Text & "'", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        employee_report_viewer.Show()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex = 10 Then
            Dim rowindex = DataGridView1.CurrentCell.RowIndex
            Dim upobj As New Empcontrolup
            upobj.id = DataGridView1.Item(0, rowindex).Value
            upobj.fname = DataGridView1.Item(1, rowindex).Value
            upobj.lname = DataGridView1.Item(2, rowindex).Value
            upobj.dob = DataGridView1.Item(3, rowindex).Value
            upobj.empadd = DataGridView1.Item(4, rowindex).Value
            upobj.phoneno = DataGridView1.Item(5, rowindex).Value
            upobj.doj = DataGridView1.Item(6, rowindex).Value
            upobj.desig = DataGridView1.Item(7, rowindex).Value
            upobj.shift = DataGridView1.Item(8, rowindex).Value
            upobj.sal = DataGridView1.Item(9, rowindex).Value
            Form2.Pannel_dashboard.Controls.Add(upobj)
            upobj.Show()
            upobj.BringToFront()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
