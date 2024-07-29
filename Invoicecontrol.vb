Imports System.Data.SqlClient
Imports System.Web.UI.WebControls

Public Class Invoicecontrol
    Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")
    Dim sdr As SqlDataReader
    Dim Empname
    Private Sub Butadd_Click(sender As Object, e As EventArgs) Handles Butadd.Click
        con.Open()
        Dim cmd As New SqlCommand("INSERT INTO [dbo].[bill_items]([item name],[quantity],[unit],[Rate],[total],[Product Id],[invoice No]) VALUES('" & Textiname.Text & "','" & Textqty.Text & "','" & Textunit.Text & "','" & Textrate.Text & "','" & Texttotal.Text & "','" & Comboitid.SelectedItem.ToString & "','" & Textbid.Text & "')", con)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("Insert into Sales_table ([Bill No],[Customer Name],[Employee id],[Date],[Item name],[Quantity],[Unit],[Rate],[Total]) values('" & Textbid.Text & "','" & Textcustname.Text & "','" & Comboempid.SelectedItem.ToString & "','" & Dateofpurchase.Value & "','" & Textiname.Text & "','" & Textqty.Text & "','" & Textunit.Text & "','" & Textrate.Text & "','" & Texttotal.Text & "')", con)
        cmd.ExecuteNonQuery()

        cmd = New SqlCommand("select * from bill_items", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
        Dim colsum As Decimal
        For Each row As DataGridViewRow In DataGridView1.Rows
            colsum += row.Cells(5).Value
        Next
        Textgrand.Text = colsum
    End Sub

    Private Sub Invoicecontrol_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sqlcmd = "Delete From bill_items"
        con.Open()
        Dim cmd As New SqlCommand With {
                .Connection = con,
                .CommandText = sqlcmd
            }
        cmd.ExecuteNonQuery()
        Dim digit As Integer
        Dim result As String
        cmd = New SqlCommand("select MAX([Invoice Number]) from [bill_table] ", con)
        result = cmd.ExecuteScalar().ToString()
        If String.IsNullOrEmpty(result) Then
            result = "INV00001"
            Textbid.Text = result

        Else
            result = result.Substring(4)
            Int32.TryParse(result, digit)
            digit += 1
            result = "INV" + digit.ToString("D5")
            Textbid.Text = result
        End If
        sqlcmd = "select *from Stock_table"
        cmd = New SqlCommand(sqlcmd, con)
        Using sdr = cmd.ExecuteReader
            While sdr.Read
                Dim pname = sdr.GetValue(0)
                Comboitid.Items.Add(pname)
            End While
        End Using
        sqlcmd = "select *from Cust_table"
        cmd = New SqlCommand(sqlcmd, con)
        Using sdr = cmd.ExecuteReader
            While sdr.Read
                Dim cname = sdr.GetValue(0)
                Combocustid.Items.Add(cname)
            End While
        End Using
        sqlcmd = "select *from Emp_table"
        cmd = New SqlCommand(sqlcmd, con)
        Using sdr = cmd.ExecuteReader
            While sdr.Read
                Dim ename = sdr.GetValue(0)
                Comboempid.Items.Add(ename)
            End While
        End Using
        con.Close()
    End Sub

    Private Sub Comboitid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Comboitid.SelectedIndexChanged
        Try
            con.Open()
            Dim cmd As New SqlCommand("select * from Stock_table where [Product Id]='" & Comboitid.SelectedItem.ToString & "'", con)
            sdr = cmd.ExecuteReader
            sdr.Read()
            Textiname.Text = sdr.GetValue(1)
            Textrate.Text = sdr.GetValue(4)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Textqty_TextChanged(sender As Object, e As EventArgs) Handles Textqty.TextChanged
        Texttotal.Text = Val(Textqty.Text) * Val(Textrate.Text)
    End Sub

    Private Sub Textrate_TextChanged(sender As Object, e As EventArgs) Handles Textrate.TextChanged
        Texttotal.Text = Val(Textqty.Text) * Val(Textrate.Text)
    End Sub

    Private Sub Combocustid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combocustid.SelectedIndexChanged
        Try
            con.Open()
            Dim cmd As New SqlCommand("select * from Cust_table where [Customer Id]='" & Combocustid.SelectedItem.ToString & "'", con)
            sdr = cmd.ExecuteReader
            sdr.Read()
            Textcustname.Text = sdr.GetValue(1)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Comboempid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Comboempid.SelectedIndexChanged
        Try
            con.Open()
            Dim cmd As New SqlCommand("select * from Emp_table where [Employee Id]='" & Comboempid.SelectedItem.ToString & "'", con)
            sdr = cmd.ExecuteReader
            sdr.Read()
            Empname = sdr.GetValue(1)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        billviewer.inNO = Textbid.Text
        con.Open()
        Dim cmd As New SqlCommand("INSERT INTO [dbo].[bill_table]([Invoice Number],[Customer Name],[Employee Name],[Date],[Grand total],[Customer Id],[Employee Id]) VALUES('" & Textbid.Text & "','" & Textcustname.Text & "','" & Empname & "','" & Dateofpurchase.Value & "','" & Textgrand.Text & "','" & Combocustid.SelectedItem.ToString & "','" & Comboempid.SelectedItem.ToString & "')", con)
        Dim reuslt = cmd.ExecuteNonQuery()
        If reuslt = 1 Then
            MsgBox("successfully inserted")
        Else
            MsgBox("Data Not Inserted")
        End If
        Dim salesobj1 As New SalesControl
        Form2.Pannel_dashboard.Controls.Add(salesobj1)
        salesobj1.Show()
        salesobj1.BringToFront()
        billviewer.Show()

    End Sub
End Class
