Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class StockControl
    Dim sdr As SqlDataReader
    Dim con As New SqlConnection("Data Source=KIRITHIK\SQLEXPRESS01;Initial Catalog=coirDB;User ID=coir;Password=1234")
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim index = DataGridView1.CurrentCell.RowIndex
        Dim value = DataGridView1.Item(2, index).Value
        Dim add = value + Val(Textnewstock.Text)
        Dim sqlcmd = "UPDATE [dbo].[Stock_table] SET [Available stock] ='" & add & "',[Rate]='" & Textrate.Text & "' WHERE [Product Id]='" & Combosearch.SelectedItem.ToString & "'"
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
        Dim cmdautoref As New SqlCommand("select * from Stock_table ", con)
        Dim sda As New SqlDataAdapter(cmdautoref)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt


    End Sub

    Private Sub StockControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim cmd As New SqlCommand("select * from Stock_table", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
        Dim sqlcmd = "select *from Stock_table"
        con.Open()
        cmd = New SqlCommand(sqlcmd, con)
        sdr = cmd.ExecuteReader
        While sdr.Read
                Dim pid = sdr.GetValue(0)
                Combosearch.Items.Add(pid)
            End While
            con.Close()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        con.Open()
        Dim cmd = New SqlCommand("select * from stock_table ", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub



    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs)
        Dim sqlcmd = "Delete from [dbo].[Stock_table] where [Product Id]='" & Combosearch.SelectedItem.ToString & "'"
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

        Dim cmdautoref As New SqlCommand("select * from Stock_table ", con)
        Dim sda As New SqlDataAdapter(cmdautoref)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub


    Private Sub Guna2ImageButton1_Click_1(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        con.Open()
        Dim cmd As New SqlCommand("select * from Stock_table where [Product Id]='" & Combosearch.SelectedItem.ToString & "'", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub



    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        stock_report_viewer.Show()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim Stockobj As New Stockcontrol_1
        Form2.Pannel_dashboard.Controls.Add(Stockobj)
        Stockobj.Show()
        Stockobj.BringToFront()
    End Sub

    Private Sub Combosearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combosearch.SelectedIndexChanged
        Dim sqlcmd = "select * from Stock_table where [Product Id]='" & Combosearch.SelectedItem.ToString & "'"
        con.Open()
        Dim cmd As New SqlCommand(sqlcmd, con)
        sdr = cmd.ExecuteReader
        sdr.Read()
        Textrate.Text = sdr.GetValue(4)
        con.Close()
    End Sub

    Private Sub Combosearch_SelectedValueChanged(sender As Object, e As EventArgs) Handles Combosearch.SelectedValueChanged

    End Sub
End Class

