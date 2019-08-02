Imports MySql.Data.MySqlClient
Public Class uc_main_Buses_Add
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Visible = False  'Hide on clicking cancel
    End Sub

    Private Sub ButtonSaveBus_Click(sender As Object, e As EventArgs) Handles ButtonSaveBus.Click
        '1. Declare Variables
        Dim bus_name, bus_capacity, plate_number As String
        '2. Fetch Variables From Text Boxes
        bus_name = TB_busname.Text
        bus_capacity = TB_capacity.Text
        plate_number = TB_platenumber.Text
        '4. Pass inputs to save person Function (go to SavePerson function for step 5)
        Dim status As Boolean = SaveBus(bus_name, bus_capacity, plate_number)
        If status = True Then
            'If save was successfu, hide this addUserControl
            Me.Visible = False
            'Clear Textboxes
            clearEntries()
        End If
    End Sub

    Private Function SaveBus(ByVal bus_name As String, ByVal bus_capacity As Integer, ByVal plate_number As String) As Boolean
        'Declare object for clsGlobal class
        Dim objGlobal As clsGlobal = New clsGlobal

        'Declare variable to be returned by function
        Dim ireturn As Boolean

        'sql to insert person
        Dim sql As String = "INSERT INTO tbl_buses(bus_name, capacity, plate_number) VALUES (@bus_name,@bus_capacity,@plate_number)"

        Dim cmd = New MySqlCommand(sql, objGlobal.con)

        cmd.Parameters.AddWithValue("@bus_name", bus_name)
        cmd.Parameters.AddWithValue("@bus_capacity", bus_capacity)
        cmd.Parameters.AddWithValue("@plate_number", plate_number)

        Try
            objGlobal.con.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                ireturn = True
                'End 
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
        TB_busname.Clear()
        TB_capacity.Clear()
        TB_platenumber.Clear()

        Return 0
    End Function

End Class
