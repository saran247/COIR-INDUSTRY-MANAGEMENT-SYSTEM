Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class custControl1

    Private Sub Butsave_Click(sender As Object, e As EventArgs) Handles Butsave.Click

        If Textph.TextLength > 10 And Textph.TextLength < 10 Then
            If Textpincode.TextLength > 6 And Textpincode.TextLength < 6 Then
                Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")
                con.Open()

                Dim cmd As New SqlCommand("Insert into Cust_table ([Customer Id],[First Name],[Last Name],[Phone Number],[Customer Age],[Customer Address],[Pin code],[Email ID]) values('" & Textcid.Text & "','" & Textfname.Text & "','" & Textlname.Text & "','" & Textph.Text & "','" & Textage.Text & "','" & Textaddress.Text & "','" & Textpincode.Text & "','" & Textmail.Text & "')", con)
                Dim reuslt = cmd.ExecuteNonQuery()

                If reuslt = 1 Then
                    MsgBox("successfully inserted")
                Else
                    MsgBox("Data Not Inserted")
                    con.Close()
                End If
            Else
                MsgBox("Enter a Valid Pin Code ")
            End If
        Else
            MsgBox("Enter a Valid Phone Number ")
        End If

        Dim backobj As New CustControl
        Form2.Pannel_dashboard.Controls.Add(backobj)
        backobj.Show()
        backobj.BringToFront()
    End Sub

    Private Sub Butback_Click(sender As Object, e As EventArgs) Handles Butback.Click
        Dim backobj As New CustControl
        Form2.Pannel_dashboard.Controls.Add(backobj)
        backobj.Show()
        backobj.BringToFront()
    End Sub

    Private Sub custControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")
        con.Open()
        Dim digit As Integer
        Dim result As String
        Dim cmd As New SqlCommand("select MAX([Customer Id]) from [cust_table] ", con)
        result = cmd.ExecuteScalar().ToString()
        If String.IsNullOrEmpty(result) Then
            result = "CUST00001"
            Textcid.Text = result

        Else
            result = result.Substring(4)
            Int32.TryParse(result, digit)
            digit += 1
            result = "CUST" + digit.ToString("D5")
            Textcid.Text = result

        End If
        con.Close()
    End Sub

    Private Sub Textage_TextChanged(sender As Object, e As EventArgs) Handles Textage.TextChanged

    End Sub
End Class


