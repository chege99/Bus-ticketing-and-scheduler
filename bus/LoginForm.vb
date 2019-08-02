Imports MySql.Data.MySqlClient
Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        PromptLogin1.BringToFront()

        Try
            Dim connectionString As String = "server=127.0.0.1; port=3306; user=root; password=; database=db_bus; charset=utf8; SslMode=none"
            Dim con As New MySqlConnection(connectionString)
            con.Open()
            If (con.State = ConnectionState.Closed) Then
                Label_login_response.Text = con.State.ToString
            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            Label_login_response.Text = ex.Message.ToString()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        dashboard.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        'Try
        '    conn.Open()
        '    If conn.State = ConnectionState.Open Then
        '        connectionstatus.Text = "Connected to Database"
        '        conn.Close()
        '    End If
        'Catch myerror As SqlException
        '    connectionstatus.Text = "Unable to Connect to Database"
        'Finally
        '    conn.Dispose()

        'End Try
    End Sub


    Private Sub PictureBox_Exit_Click(sender As Object, e As EventArgs) Handles PictureBox_Exit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) 
        dashboard.Show()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        dashboard.Show()

    End Sub
End Class
