Imports System.Data.SqlClient

Public Class Stockcontrol_1
    Private Sub Stockcontrol_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")
        con.Open()
        Dim digit As Integer
        Dim result As String
        Dim cmd As New SqlCommand("select MAX([Product Id]) from [Stock_table] ", con)
        result = cmd.ExecuteScalar().ToString()
        If String.IsNullOrEmpty(result) Then
            result = "P00001"
            Textpid.Text = result

        Else
            result = result.Substring(4)
            Int32.TryParse(result, digit)
            digit += 1
            result = "P" + digit.ToString("D5")
            Textpid.Text = result

        End If
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")
        con.Open()

        Dim cmd As New SqlCommand("Insert into Stock_table ([Product Id],[Product name],[Available stock],[Units],[Rate]) values('" & Textpid.Text & "','" & Textpname.Text & "','" & Textquantitys.Text & "','" & Combounits.SelectedItem.ToString & "','" & Textrates.Text & "')", con)
        Dim reuslt = cmd.ExecuteNonQuery()
        If reuslt = 1 Then
            MsgBox("successfully inserted")
        Else
            MsgBox("Data Not Inserted")
            con.Close()
        End If
        Dim backobj As New StockControl
        Form2.Pannel_dashboard.Controls.Add(backobj)
        backobj.Show()
        backobj.BringToFront()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim backobj As New StockControl
        Form2.Pannel_dashboard.Controls.Add(backobj)
        backobj.Show()
        backobj.BringToFront()
    End Sub
End Class
