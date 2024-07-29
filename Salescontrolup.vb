Imports System.Data.SqlClient
Public Class Salescontrolup
    Public bid, cname, itname, quant, rate, units, tot, pid

    Private Sub Butgoback_Click(sender As Object, e As EventArgs) Handles Butdel.Click
        Dim sqlcmd = "Delete Sales_table where [Bill Number]='" & Textbid.Text & "'"
        con.Open()
        Dim cmd As New SqlCommand With {
                .Connection = con,
                .CommandText = sqlcmd
            }
        Dim result = cmd.ExecuteNonQuery
        If result = 1 Then
            MsgBox("DATA DELETED", Title:="Success")
        Else
            MsgBox("DATA IS NOT DELETED", Title:="Failed")
        End If
        con.Close()
        Dim backobj As New SalesControl
        Form2.Pannel_dashboard.Controls.Add(backobj)
        backobj.Show()
        backobj.BringToFront()
    End Sub

    Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")
    Dim sdr As SqlDataReader
    Private Sub Butprint_Click(sender As Object, e As EventArgs) Handles Butprint.Click
        con.Open()
        Dim total = Val(Textquantity.Text) * Val(Textrate.Text)
        Texttotal.Text = total
        Dim unit = Textunit.Text
        Dim item = Textitem.Text
        Dim id = pid
        Dim cmd As New SqlCommand("UPDATE Sales_Table SET [Customer Name]='" & Textcustname.Text & "',[Item name]='" & Textcustname.Text & "',[Quantity]='" & Textquantity.Text & "',[Unit]='" & Textunit.Text & "',[Rate]='" & Textrate.Text & "',[Total]='" & Texttotal.Text & "',[Product Id]='" & comboitemid.SelectedItem.ToString & "'", con)
        Dim reuslt = cmd.ExecuteNonQuery()
            If reuslt = 1 Then
                MsgBox("successfully updated")
            Else
                MsgBox("Data Not updated")
            End If
            bid = Textbid.Text
            cname = Textcustname.Text
            itname = Textitem.Text
            quant = Textquantity.Text
            rate = Textrate.Text
            units = Textunit.Text
            tot = Texttotal.Text
            pid = comboitemid.Text
            Dim myrpt As New Invoicereport
            myrpt.SetParameterValue(0, bid)
            myrpt.SetParameterValue(1, cname)
            myrpt.SetParameterValue(2, itname)
            myrpt.SetParameterValue(3, quant)
            myrpt.SetParameterValue(4, rate)
            myrpt.SetParameterValue(5, units)
            myrpt.SetParameterValue(6, tot)
            myrpt.SetParameterValue(7, pid)
            Form4.CrystalReportViewer1.ReportSource = myrpt
            Form4.CrystalReportViewer1.Refresh()
        Form4.ShowDialog()
        con.Close()
        Dim backobj As New SalesControl
        Form2.Pannel_dashboard.Controls.Add(backobj)
        backobj.Show()
        backobj.BringToFront()
    End Sub

    Private Sub Textrate_TextChanged(sender As Object, e As EventArgs) Handles Textrate.TextChanged
        Texttotal.Text = Val(Textquantity.Text) * Val(Textrate.Text)
    End Sub

    Private Sub Textquantity_TextChanged(sender As Object, e As EventArgs) Handles Textquantity.TextChanged
        Texttotal.Text = Val(Textquantity.Text) * Val(Textrate.Text)
    End Sub

    Private Sub Salescontrolup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlcmd = "select *from Stock_Table"
        con.Open()
        Dim cmd As New SqlCommand(sqlcmd, con)
        sdr = cmd.ExecuteReader
        While sdr.Read
            Dim pname = sdr.GetValue(0)
            comboitemid.Items.Add(pname)
        End While
        con.Close()
        Textbid.Text = bid
        Textcustname.Text = cname
        Textitem.Text = itname
        Textquantity.Text = quant
        Textrate.Text = rate
        Textunit.Text = units
        Texttotal.Text = tot
        comboitemid.Text = pid
    End Sub
End Class
