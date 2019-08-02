Imports MySql.Data.MySqlClient
Public Class uc_main_Buses
    Dim objGlobal As clsGlobal = New clsGlobal
    Private Sub uc_main_Buses_Load(sender As Object, e As EventArgs) Handles Me.Load
        Uc_main_Buses_Add1.Visible = False
        DataGridView1.BringToFront()

        Try
            ' Dim query As String = "SELECT username, reset_token FROM tbl_users"
            Dim query As String = "SELECT * FROM tbl_buses"
            Dim connection As New MySqlConnection(objGlobal.connectionString)
            Dim da As New MySqlDataAdapter(query, connection)
            Dim ds As New DataSet()

            If da.Fill(ds) Then
                DataGridView1.DataSource = ds.Tables(0)
            End If

            connection.Close()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try


    End Sub

    Private Sub ButtonNewBus_Click(sender As Object, e As EventArgs) Handles ButtonNewBus.Click
        Uc_main_Buses_Add1.Visible = True
        Uc_main_Buses_Add1.BringToFront()
    End Sub



End Class