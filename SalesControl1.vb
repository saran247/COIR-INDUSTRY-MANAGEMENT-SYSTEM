Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Reflection
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SalesControl1
    Dim sdr As SqlDataReader
    Public bid, cname, pname, quant, rate, units, tot, pid
    Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")
    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Textquantity.TextChanged
        Texttotal.Text = Val(Textquantity.Text) * Val(Textrate.Text)
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combounit.SelectedIndexChanged

    End Sub

    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs) Handles Textrate.TextChanged
        Texttotal.Text = Val(Textquantity.Text) * Val(Textrate.Text)
    End Sub

    Private Sub comboitemid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboitemid.SelectedIndexChanged
        Try
            con.Open()
            Dim cmd As New SqlCommand("select * from Stock_Table where [Product Id]='" & comboitemid.Text & "'", con)
            sdr = cmd.ExecuteReader
            sdr.Read()
            Textitem.text = sdr.GetValue(1)
            Textrate.Text = sdr.GetValue(4)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Butgoback.Click
        Dim backobj As New SalesControl
        Form2.Pannel_dashboard.Controls.Add(backobj)
        backobj.Show()
        backobj.BringToFront()
    End Sub

    Private Sub Butprint_Click(sender As Object, e As EventArgs) Handles Butprint.Click

        con.Open()
        Dim total = Val(Textquantity.Text) * Val(Textrate.Text)
        Texttotal.Text = total
        Dim unit = Combounit.SelectedItem.ToString
        Dim item = Textitem.Text
        Dim id = comboitemid.SelectedItem.ToString
        Dim quantity = ""
        Dim cmd As New SqlCommand("select * from Stock_table where [Product Id]='" & comboitemid.SelectedItem.ToString & "'", con)
        sdr = cmd.ExecuteReader
        Try
            sdr.Read()
            quantity = sdr.GetValue(2)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Dim squantity = Textquantity.Text
        quantity -= squantity
        If (quantity < 0) Then
            MsgBox("The Value of quntity Exceeds the available stock")
        Else
            Dim sqlcmd = "UPDATE [Stock_table] SET [Available stock] ='" & quantity & "'  WHERE [Product id]='" & id & "'"
            con.Open()
            cmd = New SqlCommand With {
                .Connection = con,
                .CommandText = sqlcmd
                }
            Dim result = cmd.ExecuteNonQuery
            If result = 1 Then
                MsgBox("DATA UPDATED", Title:="Success")
            Else
                MsgBox("DATA IS NOT UPDATED", Title:="Failed")
            End If
            cmd = New SqlCommand("Insert into Sales_table ([Bill Number],[Customer Name],[Item name],[Quantity],[Unit],[Rate],[Total],[Product Id]) values('" & Textbid.Text & "','" & Textcustname.Text & "','" & item & "','" & Textquantity.Text & "','" & unit & "','" & Textrate.Text & "','" & total & "','" & comboitemid.SelectedItem.ToString & "')", con)
            Dim reuslt = cmd.ExecuteNonQuery()
            If reuslt = 1 Then
                MsgBox("successfully saved")
            Else
                MsgBox("Data Not saved")
            End If
            bid = Textbid.Text
            cname = Textcustname.Text
            pname = Textitem.Text
            quant = Textquantity.Text
            rate = Textrate.Text
            units = Combounit.SelectedItem.ToString
            tot = Texttotal.Text
            pid = comboitemid.SelectedItem.ToString
            Dim myrpt As New Invoicereport
            myrpt.SetParameterValue(0, bid)
            myrpt.SetParameterValue(1, cname)
            myrpt.SetParameterValue(2, pname)
            myrpt.SetParameterValue(3, quant)
            myrpt.SetParameterValue(4, rate)
            myrpt.SetParameterValue(5, units)
            myrpt.SetParameterValue(6, tot)
            myrpt.SetParameterValue(7, pid)
            Form4.CrystalReportViewer1.ReportSource = myrpt
            Form4.CrystalReportViewer1.Refresh()
            Form4.ShowDialog()
        End If
        Dim backobj As New SalesControl
        Form2.Pannel_dashboard.Controls.Add(backobj)
        backobj.Show()
        backobj.BringToFront()
    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint


    End Sub

    Private Sub Texttotal_TextChanged(sender As Object, e As EventArgs) Handles Texttotal.TextChanged

    End Sub

    Private Sub SalesControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")
        con.Open()
        Dim digit As Integer
        Dim result As String
        Dim cmd As New SqlCommand("select MAX([Bill Number]) from [Sales_table] ", con)
        result = cmd.ExecuteScalar().ToString()
        If String.IsNullOrEmpty(result) Then
            result = "CPS00001"
            Textbid.Text = result
            bid = Textbid.Text
        Else
            result = result.Substring(4)
            Int32.TryParse(result, digit)
            digit += 1
            result = "CPS" + digit.ToString("D5")
            Textbid.Text = result
            bid = Textbid.Text
        End If
        Dim sqlcmd = "select *from Stock_Table"
        cmd = New SqlCommand(sqlcmd, con)
        sdr = cmd.ExecuteReader
        While sdr.Read
            Dim pname = sdr.GetValue(0)
            comboitemid.Items.Add(pname)
        End While
    End Sub
End Class
