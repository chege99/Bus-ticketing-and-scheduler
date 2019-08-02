Imports MySql.Data.MySqlClient
Public Class uc_main_Drivers

    Dim objGlobal As clsGlobal = New clsGlobal

    Private Sub ButtonNewDriver_Click(sender As Object, e As EventArgs) Handles ButtonNewDriver.Click
        Uc_main_Drivers_Add1.Visible = True
        Uc_main_Drivers_Add1.BringToFront()
    End Sub

    Private Sub uc_main_Drivers_Load(sender As Object, e As EventArgs) Handles Me.Load
        Uc_main_Drivers_Add1.Visible = False

        Try
            Dim query As String = "Select tbl_drivers.driver_id, tbl_people.fname, tbl_people.lname, tbl_people.email, tbl_people.phone, tbl_people.national_id from tbl_drivers JOIN tbl_people ON tbl_drivers.person_id= tbl_people.person_id"
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
End Class
