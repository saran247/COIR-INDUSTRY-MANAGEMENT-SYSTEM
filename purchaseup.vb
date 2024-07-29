Imports System.Data.SqlClient

Public Class purchaseup
    Public pid, mname, sname, dop, quantity, unit, rate, total

    Private Sub purchaseup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Textpid.Text = pid
        Textmname.Text = mname
        Textsname.Text = sname
        Dateofpurchase.Text = dop
        Textquantity.Text = quantity
        Combounits.Text = unit
        Textrate.Text = rate
        Texttotal.Text = total
    End Sub

    Private Sub Textback_Click(sender As Object, e As EventArgs) Handles Textback.Click
        Dim sqlcmd = "UPDATE [dbo].[Purchase_table] SET [Purchase Id] = '" & Textpid.Text & "',[Material Name] = '" & Textmname.Text & "',[Supplier Name] = '" & Textsname.Text & "',[Date of purchase] = '" & Dateofpurchase.Value & "',[Quantity] = '" & Textquantity.Text & "',[Units] = '" & Combounits.SelectedValue & "',[Rate] = '" & Textrate.Text & "',[Email ID] = '" & Texttotal.Text & "' WHERE [Purchase Id]='" & pid & "'"
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
        Dim backobj As New Purchasecontrol
        Form2.Pannel_dashboard.Controls.Add(backobj)
        backobj.Show()
        backobj.BringToFront()
    End Sub

    Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim sqlcmd = "Delete Purchase_table where [Purchase Id]='" & pid & "'"
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
        Dim backobj As New Purchasecontrol
        Form2.Pannel_dashboard.Controls.Add(backobj)
        backobj.Show()
        backobj.BringToFront()
    End Sub

    Private Sub Textquantity_TextChanged(sender As Object, e As EventArgs) Handles Textquantity.TextChanged
        Texttotal.Text = Val(Textquantity.Text) * Val(Textrate.Text)
    End Sub

    Private Sub Textrate_TextChanged(sender As Object, e As EventArgs) Handles Textrate.TextChanged
        Texttotal.Text = Val(Textquantity.Text) * Val(Textrate.Text)
    End Sub
End Class
