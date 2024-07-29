
Imports System.Data.SqlClient

Public Class Custcontrolup
    Public id, fname, lname, phoneno, age, address, pincode, emailid

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Butdel_Click(sender As Object, e As EventArgs) Handles Butdel.Click
        Dim sqlcmd = "Delete Cust_table where [Customer Id]='" & id & "'"
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
        Dim backobj As New CustControl
        Form2.Pannel_dashboard.Controls.Add(backobj)
        backobj.Show()
        backobj.BringToFront()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim backobj As New CustControl
        Form2.Pannel_dashboard.Controls.Add(backobj)
        backobj.Show()
        backobj.BringToFront()
    End Sub

    Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")
    Private Sub Butupdate_Click(sender As Object, e As EventArgs) Handles Butupdate.Click
        If Textph.TextLength > 10 And Textph.TextLength < 10 Then
            If Textpincode.TextLength > 6 And Textpincode.TextLength < 6 Then
                Dim sqlcmd = "UPDATE [dbo].[Cust_table] SET [Customer Id] = '" & Textcid.Text & "',[First Name] = '" & Textfname.Text & "',[Last Name] = '" & Textlname.Text & "',[Phone number] = '" & Textph.Text & "',[Customer Age] = '" & Textage.Text & "',[Customer Address] = '" & Textaddress.Text & "',[Pin code] = '" & Textpincode.Text & "',[Email ID] = '" & Textmail.Text & "' WHERE [Customer Id]='" & id & "'"
                con.Open()
                Dim cmd As New SqlCommand With {
                        .Connection = con,
                        .CommandText = sqlcmd
                    }
                Dim result = cmd.ExecuteNonQuery
                If result = 1 Then
                    MsgBox("DATA UPDATED", Title:="Success")
                Else
                    MsgBox("DATA IS NOT UPDATED", Title:="Failed")
                End If
                con.Close()
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
    Private Sub Custcontrolup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Textcid.Text = id
        Textfname.Text = fname
        Textlname.Text = lname
        Textph.Text = phoneno
        Textage.Text = age
        Textaddress.Text = address
        Textpincode.Text = pincode
        Textmail.Text = emailid
    End Sub


End Class
