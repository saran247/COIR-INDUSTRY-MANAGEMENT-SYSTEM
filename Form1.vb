Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports Guna.UI2.WinForms

Public Class Form1
    Public userID As String
    Public password As String

    'Butlogin
    Private Sub Butlogin_Click(sender As Object, e As EventArgs) Handles Butlogin.Click
        userID = Buttuser.Text
        password = Buttpass.Text
        Try

            Dim con As SqlConnection = constring.Connections.Getconnection(userID, password)
            If con.State = ConnectionState.Closed Then
                con.Open()
                Me.Hide()
                Buttuser.Clear()
                Buttpass.Clear()
                Form2.Show()
                con.Close()
            End If
        Catch ex As Exception
            MsgBox("Wrong userID or password")
        End Try
    End Sub
    'close
    Private Sub Butclose_Click(sender As Object, e As EventArgs) Handles Butclose.Click
        If MsgBox("Are you sure you want to close?", vbYesNo + vbQuestion, Title:="confirmation?") = vbYes Then
            Application.Exit()
        End If
    End Sub
    'showpassword
    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If Guna2CheckBox1.Checked Then Buttpass.PasswordChar = Convert.ToChar(0) Else Buttpass.PasswordChar = Convert.ToChar("*")
        Buttpass.UseSystemPasswordChar = Not Guna2CheckBox1.Checked
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
