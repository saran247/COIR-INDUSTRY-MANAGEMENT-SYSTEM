Imports System.Data.SqlClient
Imports CrystalDecisions
Imports CrystalDecisions.CrystalReports.Engine

Public Class stock_report_viewer
    Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")
    Dim cmd As New SqlCommand("select * from Stock_table", con)
    Dim sda As New SqlDataAdapter(cmd)
    Dim dt As New DataTable
    Private Sub stock_report_viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sda.Fill(dt)
        Dim myrpt As New stock_report
        myrpt.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = myrpt
        CrystalReportViewer1.Refresh()

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class