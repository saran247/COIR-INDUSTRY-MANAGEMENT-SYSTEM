Imports CrystalDecisions
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Public Class Form3
    Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")
    Dim cmd As New SqlCommand("select * from Purchase_table", con)
    Dim sda As New SqlDataAdapter(cmd)
    Dim dt As New DataTable

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sda.Fill(dt)
        Dim myrpt As New CrystalReport1
        myrpt.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = myrpt
        CrystalReportViewer1.Refresh()
    End Sub
End Class