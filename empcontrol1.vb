Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class empcontrol1
    Private Sub Butsave_Click(sender As Object, e As EventArgs) Handles Butsave.Click
        If Textph.TextLength > 10 And Textph.TextLength < 10 Then

            Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")
            con.Open()

            Dim cmd As New SqlCommand("Insert into Emp_table ([Employee ID],[First Name],[Last Name],[Date of birth],[Permenent Address],[Phone number],[Date of joining],[Job Designation],[Shift],[Salary per month]) values('" & Texteid.Text & "','" & Textfname.Text & "','" & Textlname.Text & "','" & Dateofbirth.Value & "','" & Textaddress.Text & "','" & Textph.Text & "','" & Dateofjoining.Value & "','" & Combodesig.SelectedItem & "','" & Comboshift.SelectedItem & "','" & Textsalary.Text & "')", con)
            Dim reuslt = cmd.ExecuteNonQuery()
            If Textph.TextLength > 10 And Textph.TextLength < 10 Then
                MsgBox("Enter a Valid Phone Number ")
            End If
            If reuslt = 1 Then
                MsgBox("successfully inserted")
            Else
                MsgBox("Data Not Inserted")
            End If
        Else
            MsgBox("Enter a Valid Phone Number ")
        End If

        Dim backobj As New EmpControl
        Form2.Pannel_dashboard.Controls.Add(backobj)
        backobj.Show()
        backobj.BringToFront()
    End Sub

    Private Sub Dateofbirth_ValueChanged(sender As Object, e As EventArgs) Handles Dateofbirth.ValueChanged

    End Sub

    Private Sub empcontrol1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")
        con.Open()
        Dim digit As Integer
        Dim result As String
        Dim cmd As New SqlCommand("select MAX([Employee Id]) from [Emp_table] ", con)
        result = cmd.ExecuteScalar().ToString()
        If String.IsNullOrEmpty(result) Then
            result = "EMP00001"
            Texteid.Text = result

        Else
            result = result.Substring(4)
            Int32.TryParse(result, digit)
            digit += 1
            result = "EMP" + digit.ToString("D5")
            Texteid.Text = result
        End If
        con.Close()
    End Sub

    Private Sub Textfname_TextChanged(sender As Object, e As EventArgs) Handles Textfname.TextChanged

    End Sub

    Private Sub Butback_Click(sender As Object, e As EventArgs) Handles Butback.Click
        Dim backobj As New EmpControl
        Form2.Pannel_dashboard.Controls.Add(backobj)
        backobj.Show()
        backobj.BringToFront()
    End Sub

    Private Sub Textsalary_TextChanged(sender As Object, e As EventArgs) Handles Textsalary.TextChanged

    End Sub
End Class
