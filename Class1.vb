Imports System.Data.SqlClient
Namespace constring
    Public NotInheritable Class Connections
        Private Sub New()
        End Sub
        Public Shared Function Getconnection(ByVal userID_ As String, ByVal Password_ As String) As SqlConnection
            Dim builder As New SqlConnectionStringBuilder With {
               .DataSource = "KIRITHIK\SQLEXPRESS01",
               .InitialCatalog = "coirDB",
               .UserID = userID_,
               .Password = Password_
               }
            Dim ConnectionStringr As String = builder.ConnectionString
            Dim con As New SqlConnection(ConnectionStringr)
            Return con
        End Function
        Public Shared Sub Sqlclean(cn As SqlConnection, cmd As SqlCommand)
            cmd.Dispose()
            cn.Close()
        End Sub
    End Class
End Namespace

