Imports MySql.Data.MySqlClient
Public Class clsGlobal
    Public user_ld As Integer
    Public connectionString As String = "server=127.0.0.1; port=3306; user=root; password=; database=db_bus; charset=utf8; SslMode=none"
    Public con As New MySqlConnection(connectionString)
    Public COMMAND As MySqlCommand

End Class
