Imports MySql.Data.MySqlClient
Public Class uc_main_Drivers_Add
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Visible = False  'Hide on clicking cancel
    End Sub

    Private Sub ButtonSavedDriver_Click(sender As Object, e As EventArgs) Handles ButtonSavedDriver.Click
        '1. Declare Variables
        Dim fname, lname, email, phone, nat_idNum As String
        '2. Fetch Variables From Text Boxes
        fname = TB_fname.Text
        lname = TB_lname.Text
        phone = TB_phone.Text
        email = TB_email.Text
        nat_idNum = TB_idnumber.Text
        '4. Pass inputs to save person Function (go to SavePerson function for step 5)
        Dim status As Boolean = SavePerson(fname, lname, phone, email, nat_idNum)
        If status = True Then
            'If save was successfu, hide this addUserControl
            Me.Visible = False
            'Clear Textboxes
            clearEntries()
        End If
    End Sub
    Private Function SavePerson(ByVal fname As String, ByVal lname As String, ByVal phone As String, ByVal email As String, ByVal nat_idNum As String) As Boolean
        'Declare object for clsGlobal class
        Dim objGlobal As clsGlobal = New clsGlobal

        'Declare variable to be returned by function
        Dim ireturn As Boolean

        'sql to insert person
        Dim sql As String = "INSERT INTO tbl_people(fname, lname, email, phone,national_id) VALUES (@fname,@lname,@email,@phone,@national_id)"

        Dim cmd = New MySqlCommand(sql, objGlobal.con)

        cmd.Parameters.AddWithValue("@fname", fname)
        cmd.Parameters.AddWithValue("@lname", lname)
        cmd.Parameters.AddWithValue("@email", email)
        cmd.Parameters.AddWithValue("@phone", phone)
        cmd.Parameters.AddWithValue("@national_id", nat_idNum)

        Try
            objGlobal.con.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                ireturn = True
                '5. Since the person has been saved, we need to feth their person_id that will be used as fk in the tbl_users
                Dim person_id As Integer = FetchPesonId(email)
                '6. Now pass the person id, username and password and save them in the tbl_users
                SaveDriver(person_id)

            End If
            objGlobal.con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
            ireturn = False
            objGlobal.con.Close()
        End Try

        Return ireturn

    End Function
    Private Function FetchPesonId(ByVal email As String) As Integer
        Dim reader As MySqlDataReader
        Dim objGlobal As clsGlobal = New clsGlobal
        Dim pid As Integer
        Try
            objGlobal.con.Open()
            Dim query As String
            query = "Select person_id from tbl_people where email ='" & email & "'"
            objGlobal.COMMAND = New MySqlCommand(query, objGlobal.con)
            reader = objGlobal.COMMAND.ExecuteReader
            While reader.Read
                pid = reader.GetString("person_id")
            End While
            objGlobal.con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            objGlobal.con.Dispose()
        End Try


        Return pid
    End Function

    Private Function SaveDriver(ByVal person_id As Integer) As Boolean
        Dim objGlobal As clsGlobal = New clsGlobal
        Dim ireturn As Boolean

        Dim sql As String = "INSERT INTO tbl_drivers(person_id) VALUES (@person_id)"
        Dim cmd = New MySqlCommand(sql, objGlobal.con)

        cmd.Parameters.AddWithValue("@person_id", person_id)

        Try
            objGlobal.con.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                ireturn = True
            End If
            objGlobal.con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
            ireturn = False
            objGlobal.con.Close()
        End Try

        Return ireturn

    End Function
    Private Function clearEntries() As Integer
        TB_fname.Clear()
        TB_lname.Clear()
        TB_phone.Clear()
        TB_email.Clear()
        TB_idnumber.Clear()

        Return 0
    End Function
End Class
