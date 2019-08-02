Imports MySql.Data.MySqlClient
Public Class uc_main_Schedules
    Dim objGlobal As clsGlobal = New clsGlobal
    Private Sub uc_main_Schedules_Load(sender As Object, e As EventArgs) Handles Me.Load
        Uc_main_Schedules_SetSchedule1.Visible = False
        Uc_main_Schedules_SetSchedule1.Visible = True

        Dim thedate As Date = Date.Today
        '+;where Date ='" & thedate & "'
        Try
            ' Dim query As String = "SELECT username, reset_token FROM tbl_users"
            Dim query As String = "SELECT entry_id,bus_name,driver_name,route_name,time_depart,date FROM tbl_schedules"
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

    Private Sub ButtonMakeSchedule_Click(sender As Object, e As EventArgs) Handles ButtonMakeSchedule.Click
        Uc_main_Schedules_SetSchedule1.BringToFront()
        Uc_main_Schedules_SetSchedule1.Visible = True
    End Sub
End Class
