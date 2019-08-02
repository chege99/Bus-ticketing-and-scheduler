Imports MySql.Data.MySqlClient
Public Class uc_main_Routes_Add
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Visible = False  'Hide on clicking cancel
    End Sub

    Private Sub ButtonSaveRoute_Click(sender As Object, e As EventArgs) Handles ButtonSaveRoute.Click
        '1. Declare Variables
        Dim routename, pickuppoint, destination, description As String
        Dim charge, hoursoftravel As Integer
        '2. Fetch Variables From Text Boxes
        routename = TB_Routename_generated.Text
        pickuppoint = TB_pickuppoint.Text
        destination = TB_destination.Text
        charge = TB_charge.Text
        description = TB_description.Text
        hoursoftravel = TB_estimated_time.Text
        '4. Pass inputs to save person Function (go to SavePerson function for step 5)
        Dim status As Boolean = SaveRoute(routename, pickuppoint, destination, charge, description, hoursoftravel)
        If status = True Then
            'If save was successfu, hide this addUserControl
            Me.Visible = False
            'Clear Textboxes
            clearEntries()
        End If
    End Sub

    Private Function SaveRoute(ByVal routename As String, ByVal pickuppoint As String, ByVal destination As String, ByVal charge As Integer, ByVal description As String, ByVal hoursoftravel As Integer) As Boolean
        'Declare object for clsGlobal class
        Dim objGlobal As clsGlobal = New clsGlobal

        'Declare variable to be returned by function
        Dim ireturn As Boolean

        'sql to insert person
        Dim sql As String = "INSERT INTO tbl_routes(routename, pickuppoint, destination, charge,description,estimated_time) VALUES (@routename,@pickuppoint,@destination,@charge,@description,@estimated_time)"

        Dim cmd = New MySqlCommand(sql, objGlobal.con)
        cmd.Parameters.AddWithValue("@routename", routename)
        cmd.Parameters.AddWithValue("@pickuppoint", pickuppoint)
        cmd.Parameters.AddWithValue("@destination", destination)
        cmd.Parameters.AddWithValue("@charge", charge)
        cmd.Parameters.AddWithValue("@description", description)
        cmd.Parameters.AddWithValue("@estimated_time", hoursoftravel)

        Try
            objGlobal.con.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                ireturn = True
                '5. Since the person has been saved, we need to feth their person_id that will be used as fk in the tbl_users


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
        TB_pickuppoint.Clear()
        TB_destination.Clear()
        TB_charge.Clear()
        TB_description.Clear()
        TB_estimated_time.Clear()
        Return 0
    End Function


End Class
