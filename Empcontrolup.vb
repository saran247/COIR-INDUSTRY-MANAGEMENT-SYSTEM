Imports System.Data.SqlClient
Imports System.Net

Public Class Empcontrolup
    Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")

    Public id, fname, lname, dob, empadd, phoneno, doj, desig, shift, sal

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim backobj As New EmpControl
        Form2.Pannel_dashboard.Controls.Add(backobj)
        backobj.Show()
        backobj.BringToFront()
    End Sub

    Private Sub Butdel_Click(sender As Object, e As EventArgs) Handles Butdel.Click
        Dim sqlcmd = "Delete Emp_table where [Employee ID]='" & id & "'"
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
        Dim backobj As New EmpControl
        Form2.Pannel_dashboard.Controls.Add(backobj)
        backobj.Show()
        backobj.BringToFront()
        con.Close()
    End Sub

    Private Sub Butupdate_Click(sender As Object, e As EventArgs) Handles Butupdate.Click
        Dim sqlcmd = "UPDATE [dbo].[Emp_table] SET [Employee ID] = '" & Texteid.Text & "',[First Name] = '" & Textfname.Text & "',[Last Name] = '" & Textlname.Text & "',[Date of birth] = '" & Dateofbirth.Value & "',[Permenent Address] = '" & Textaddress.Text & "',[Phone number] = '" & Textph.Text & "',[Date of joining] = '" & Dateofjoining.Value & "',[Job Designation] = '" & Combodesig.SelectedValue & "',[Shift] = '" & Textshift.Text & "',[Salary] = '" & Textsalary.Text & "' WHERE [Employee ID]='" & id & "'"
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
        Dim backobj As New EmpControl
        Form2.Pannel_dashboard.Controls.Add(backobj)
        backobj.Show()
        backobj.BringToFront()
    End Sub


    Private Sub Empcontrolup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Texteid.Text = id
        Textfname.Text = fname
        Textlname.Text = lname
        Dateofbirth.Value = dob
        Textaddress.Text = empadd
        Textph.Text = phoneno
        Dateofjoining.Text = doj
        Combodesig.Text = desig
        Textshift.Text = shift
        Textsalary.Text = sal
    End Sub
End Class
