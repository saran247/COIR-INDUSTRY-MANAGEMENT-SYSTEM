Imports System.Data.SqlClient

Public Class Purchasecontrol
    Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")
    Private Sub Purchasecontrol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim cmd As New SqlCommand("select * from Purchase_table", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    Private Sub Butsearch_Click(sender As Object, e As EventArgs) Handles Butsearch.Click
        con.Open()
        Dim cmd As New SqlCommand("select * from Purchase_table where [Purchase Id]='" & Textsearch.Text & "'", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub


    Private Sub Butrefresh_Click(sender As Object, e As EventArgs) Handles Butrefresh.Click
        con.Open()
        Dim cmd As New SqlCommand("select * from Purchase_table", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    Private Sub Butaddnew_Click(sender As Object, e As EventArgs) Handles Butaddnew.Click
        Dim purchaseobj As New purchaseControl1
        Form2.Pannel_dashboard.Controls.Add(purchaseobj)
        purchaseobj.Show()
        purchaseobj.BringToFront()
    End Sub

    Private Sub Butreport_Click(sender As Object, e As EventArgs) Handles Butreport.Click
        Form3.Show()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex = 8 Then
            Dim rowindex = DataGridView1.CurrentCell.RowIndex
            Dim upobj As New purchaseup
            upobj.pid = DataGridView1.Item(0, rowindex).Value
            upobj.mname = DataGridView1.Item(1, rowindex).Value
            upobj.sname = DataGridView1.Item(2, rowindex).Value
            upobj.dop = DataGridView1.Item(3, rowindex).Value
            upobj.quantity = DataGridView1.Item(4, rowindex).Value
            upobj.unit = DataGridView1.Item(5, rowindex).Value
            upobj.rate = DataGridView1.Item(6, rowindex).Value
            upobj.total = DataGridView1.Item(7, rowindex).Value
            Form2.Pannel_dashboard.Controls.Add(upobj)
            upobj.Show()
            upobj.BringToFront()
        End If
    End Sub
End Class
