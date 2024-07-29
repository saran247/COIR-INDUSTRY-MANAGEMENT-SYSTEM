Public Class Form2
    Private Sub Butpurchase_Click(sender As Object, e As EventArgs) Handles Butpurchase.Click
        Dim purobj As New Purchasecontrol
        Pannel_dashboard.Controls.Add(purobj)
        purobj.Show()
        purobj.BringToFront()
    End Sub

    Private Sub Butstock_Click(sender As Object, e As EventArgs) Handles Butstock.Click
        Dim stockobj As New StockControl
        Pannel_dashboard.Controls.Add(stockobj)
        stockobj.Show()
        stockobj.BringToFront()
    End Sub

    Private Sub Butlog_Click(sender As Object, e As EventArgs) Handles Butlog.Click
        If MsgBox("Are you sure you want to Logout?", vbYesNo + vbQuestion, Title:="confirmation?") = vbYes Then
            Me.Hide()
            Form1.Buttuser.Clear()
            Form1.Buttpass.Clear()
            Form1.Show()

        End If
    End Sub

    Private Sub Butcust_Click(sender As Object, e As EventArgs) Handles Butcust.Click
        Dim custobj As New CustControl
        Pannel_dashboard.Controls.Add(custobj)
        custobj.Show()
        custobj.BringToFront()
    End Sub

    Private Sub Butemp_Click(sender As Object, e As EventArgs) Handles Butemp.Click
        Dim empobj As New EmpControl
        Pannel_dashboard.Controls.Add(empobj)
        empobj.Show()
        empobj.BringToFront()
    End Sub

    Private Sub Butsales_Click(sender As Object, e As EventArgs) Handles Butsales.Click
        Dim salesobj As New SalesControl
        Pannel_dashboard.Controls.Add(salesobj)
        salesobj.Show()
        salesobj.BringToFront()
    End Sub

    Private Sub Butclose2_Click(sender As Object, e As EventArgs) Handles Butclose2.Click
        If MsgBox("Are you sure you want to close?", vbYesNo + vbQuestion, Title:="confirmation?") = vbYes Then
            Application.Exit()
        End If
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Butsal.Click
        Dim salobj As New SalaryControl
        Pannel_dashboard.Controls.Add(salobj)
        salobj.Show()
        salobj.BringToFront()
    End Sub
End Class

