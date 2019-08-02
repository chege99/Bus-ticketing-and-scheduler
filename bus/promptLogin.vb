Imports MySql.Data.MySqlClient
Public Class promptLogin
    'Dim connectionString As String = "server=127.0.0.1; port=3306; user=root; password=; database=db_bus; charset=utf8; SslMode=none"
    'Dim con As New MySqlConnection(connectionString)
    'Dim COMMAND As MySqlCommand
    Private Sub Label_Forgot_Password_Click(sender As Object, e As EventArgs) 
        Me.SendToBack()

    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        Dim username As String = TextBox_Login_Username.Text.ToString
        Dim password As String = TextBox_Login_Password.Text.ToString
        LoginExec(username, password)
    End Sub

    Private Function LoginExec(ByVal username As String, ByVal password As String) As Integer
        Dim objGlobal As clsGlobal = New clsGlobal

        Dim READER As MySqlDataReader

        Try
            objGlobal.con.Open()
            Dim Query As String
            Query = "select user_id from tbl_users where username='" & username & "' and password='" & password & "' "
            objGlobal.COMMAND = New MySqlCommand(Query, objGlobal.con)
            READER = objGlobal.COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While

            If count = 0 Then
                Label_Response_Login.Text = "No such records exist"
                Label_Response_Login.Visible = True
            ElseIf count = 1 Then
                Label_Response_Login.Text = "Success"
                Label_Response_Login.Visible = True

                clearEntries()
                dashboard.Show()

            Else
                Label_Response_Login.Text = count & " Incorrect Username or password "
                Label_Response_Login.Visible = True
            End If

            objGlobal.con.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            objGlobal.con.Dispose()

        End Try
        Return 0
    End Function
    Private Function clearEntries() As Integer

        TextBox_Login_Username.Clear()
        TextBox_Login_Password.Clear()
        Return 0
    End Function

End Class
