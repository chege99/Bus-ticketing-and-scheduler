Imports MySql.Data.MySqlClient
Public Class uc_main_Users
    Dim objGlobal As clsGlobal = New clsGlobal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Uc_custom_AddUser1.Visible = True
        Uc_custom_AddUser1.BringToFront()
    End Sub

    Private Sub uc_main_Users_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            ' Dim query As String = "SELECT username, reset_token FROM tbl_users"
            Dim query As String = "Select tbl_users.user_id, tbl_users.username, tbl_people.fname, tbl_people.lname, tbl_people.email, tbl_people.phone, tbl_people.national_id from tbl_users JOIN tbl_people ON tbl_users.person_id= tbl_people.person_id"
            Dim connection As New MySqlConnection(objGlobal.connectionString)
            Dim da As New MySqlDataAdapter(query, connection)
            Dim ds As New DataSet()

            If da.Fill(ds) Then
                DataGridViewUsers.DataSource = ds.Tables(0)
            End If

            connection.Close()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub


End Class
