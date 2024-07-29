Imports System.Data.SqlClient
Public Class purchaseControl1
    Public sid
    Private Sub Butsave_Click(sender As Object, e As EventArgs) Handles Butsave.Click
        Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")
        con.Open()
        Dim total = Val(Textquantity.Text) * Val(Textrate.Text)
        Texttotal.Text = total
        Dim unit = ComboBox1.SelectedItem.ToString
        Dim cmd As New SqlCommand("Insert into Purchase_table ([Purchase Id],[Material Name],[Supplier name],[Date of purchase],[Quantity],[Units],[Rate],[Total]) values('" & Textpid.Text & "','" & Textmname.Text & "','" & Textsname.Text & "','" & Dateofpurchase.Value & "','" & Textquantity.Text & "','" & unit & "','" & Textrate.Text & "','" & total & "')", con)

        Dim reuslt = cmd.ExecuteNonQuery()
        If reuslt = 1 Then
            MsgBox("successfully inserted")
        Else
            MsgBox("Data Not Inserted")
        End If
        Dim backobj As New Purchasecontrol
        Form2.Pannel_dashboard.Controls.Add(backobj)
        backobj.Show()
        backobj.BringToFront()
    End Sub

    Private Sub PurchaseControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")
        con.Open()
        Dim digit As Integer
        Dim result As String
        Dim cmd As New SqlCommand("select MAX([Purchase Id]) from [Purchase_table] ", con)
        result = cmd.ExecuteScalar().ToString()
        If String.IsNullOrEmpty(result) Then
            result = "PUR00001"
            Textpid.Text = result
            sid = Textpid.Text
        Else
            result = result.Substring(4)
            Int32.TryParse(result, digit)
            digit += 1
            result = "PUR" + digit.ToString("D5")
            Textpid.Text = result
            sid = Textpid.Text
        End If
        con.Close()
    End Sub

    Private Sub Textback_Click(sender As Object, e As EventArgs) Handles Textback.Click
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

    Private Sub Texttotal_TextChanged(sender As Object, e As EventArgs) Handles Texttotal.TextChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
