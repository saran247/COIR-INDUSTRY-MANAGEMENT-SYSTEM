Imports System.Data.SqlClient
Public Class billviewer
    Public inNO
    Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")
    'Dim cmd As New SqlCommand("SELECT bill_table.[Invoice Number],bill_table.[Customer Name],bill_table.[Employee Name],bill_table.[Date],bill_table.[Grand Total],bill_items.[Product Id],bill_items.[item name],bill_items.[quantity],bill_items.[unit],bill_items.[rate],bill_items.[total] FROM bill_table JOIN bill_items  ON bill_table.[Invoice Number] = bill_items.[Invoice No] where bill_table.[Invoice Number]='" & inNo & "'", where [Invoice Number]='" & inNO & "'con)
    Private Sub billviewer_Load(sender As Object, e As EventArgs) Handles Me.Load
        con.Open()
        Dim cmd As New SqlCommand("Select * from bill_table where [Invoice Number]='" & inNO & "' ", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        Dim dt1 As New DataTable
        sda.Fill(dt)
        Dim cmd1 As New SqlCommand("Select * from bill_items", con)
        sda = New SqlDataAdapter(cmd1)
        sda.Fill(dt1)
        Dim myrpt As New BILL
        myrpt.Database.Tables("bill_table").SetDataSource(dt)
        myrpt.Database.Tables("bill_items").SetDataSource(dt1)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt
        CrystalReportViewer1.Refresh()
        con.Close()
    End Sub
End Class