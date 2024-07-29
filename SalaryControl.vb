Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class SalaryControl
    Dim sdr As SqlDataReader
    Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")
    Private Sub SalaryControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim digit As Integer
        Dim result As String
        Dim cmd As New SqlCommand("select MAX([Salary Id]) from [Salary_table] ", con)
        result = cmd.ExecuteScalar().ToString()
        If String.IsNullOrEmpty(result) Then
            result = "SAL00001"
            Textsid.Text = result

        Else
            result = result.Substring(4)
            Int32.TryParse(result, digit)
            digit += 1
            result = "SAL" + digit.ToString("D5")
            Textsid.Text = result

        End If
        con.Close()
        con.Open()
        cmd = New SqlCommand("select * from Salary_table", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
        con.Open()
        Dim sqlcmd = "select *from Emp_table"
        cmd = New SqlCommand(sqlcmd, con)
        sdr = cmd.ExecuteReader
        While sdr.Read
                Dim ename = sdr.GetValue(0)
                Comboempid.Items.Add(ename)
            End While

        con.Close()
    End Sub

    Private Sub Butsave_Click(sender As Object, e As EventArgs) Handles Butsave.Click
        con.Open()

        Dim cmd As New SqlCommand("Insert into Salary_table ([Salary Id],[Employee Name],[Date of Issue],[Monthly Salary],[Remarks],[Salary Issued]) values('" & Textsid.Text & "','" & Textename.Text & "','" & Dateofissue.Value & "','" & Textmsalary.Text & "','" & Textremarks.Text & "','" & Texttotal.Text & "')", con)
        Dim reuslt = cmd.ExecuteNonQuery()

        If reuslt = 1 Then
            MsgBox("successfully inserted")
        Else
            MsgBox("Data Not Inserted")
        End If
        con.Close()
    End Sub

    Private Sub Textremarks_TextChanged(sender As Object, e As EventArgs) Handles Textremarks.TextChanged
        Texttotal.Text = Val(Textmsalary.Text) + Val(Textremarks.Text)
    End Sub

    Private Sub Textmsalary_TextChanged(sender As Object, e As EventArgs) Handles Textmsalary.TextChanged
        Texttotal.Text = Val(Textmsalary.Text) + Val(Textremarks.Text)
    End Sub

    Private Sub Comboempid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Comboempid.SelectedIndexChanged
        Try
            con.Open()
            Dim cmd As New SqlCommand("select * from Emp_table where [Employee Id]='" & Comboempid.SelectedItem.ToString & "'", con)
            sdr = cmd.ExecuteReader
            sdr.Read()
            Textename.Text = sdr.GetValue(1)
            Textmsalary.Text = sdr.getvalue(9)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Butrefresh_Click(sender As Object, e As EventArgs) Handles Butrefresh.Click
        con.Open()
        Dim cmd As New SqlCommand("select * from Salary_table", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    Private Sub Salreport_Click(sender As Object, e As EventArgs) Handles Salreport.Click
        Salary_report_viewer.show()
    End Sub
End Class
