Imports MySql.Data.MySqlClient
Public Class uc_main_Schedules_SetSchedule
    Dim objGlobal As clsGlobal = New clsGlobal
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Visible = False
    End Sub

    Private Sub ButtonSetSchedule_Click(sender As Object, e As EventArgs) Handles ButtonSetSchedule.Click
        Dim bus_name As String = ComboBoxBus.SelectedValue
        Dim fname As String = ComboBoxDriver.SelectedValue
        Dim routename As String = ComboBoxRoute.SelectedValue
        Dim Time As String = DateTimePicker_depart_time.Value.ToShortTimeString

        Dim status As Boolean = SaveSchedule(bus_name, fname, routename, Time)
        If status = True Then
            'If save was successfu, hide this addUserControl
            Me.Visible = False
            'Clear Textboxes
            clearEntries()
        End If

        Me.Visible = False
    End Sub

    Private Sub uc_main_Schedules_SetSchedule_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Set Time picker

        'Populate combo Bus
        Try
            Dim adapter As New MySqlDataAdapter("SELECT bus_id, bus_name, plate_number, capacity FROM tbl_buses", objGlobal.con)
            Dim table As New DataTable()
            adapter.Fill(table)
            ComboBoxBus.DataSource = table
            ComboBoxBus.ValueMember = "bus_name"
            'ComboBoxBus.DisplayMember = "bus_id"
            objGlobal.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Populate combo Driver
        'Select	tbl_drivers.driver_id, tbl_people.fname, tbl_people.lname from	tbl_drivers JOIN	tbl_people ON	tbl_drivers.person_id = tbl_people.person_id"
        Try
            Dim query As String = "Select tbl_drivers.driver_id, tbl_people.fname, tbl_people.lname, tbl_people.email, tbl_people.phone, tbl_people.national_id from tbl_drivers JOIN tbl_people ON tbl_drivers.person_id= tbl_people.person_id"
            Dim adapter As New MySqlDataAdapter(query, objGlobal.con)
            Dim table As New DataTable()
            adapter.Fill(table)
            ComboBoxDriver.DataSource = table
            ComboBoxDriver.ValueMember = "fname"
            'ComboBoxDriver.DisplayMember = "driver_id"
            objGlobal.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Populate combo Route
        'tbl_routes(routename, pickuppoint, destination, charge, description, estimated_time)

        Try
            Dim adapter As New MySqlDataAdapter("SELECT route_id, routename, pickuppoint, destination, charge, description, estimated_time FROM tbl_routes", objGlobal.con)
            Dim table As New DataTable()
            adapter.Fill(table)
            ComboBoxRoute.DataSource = table
            ComboBoxRoute.ValueMember = "routename"
            'ComboBoxRoute.DisplayMember = "route_id"
            objGlobal.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Function SaveSchedule(ByVal bus_name As String, ByVal driver_fname As String, ByVal route_name As String, ByVal time_depart As String) As Boolean
        'Declare object for clsGlobal class
        Dim objGlobal As clsGlobal = New clsGlobal

        'Declare variable to be returned by function
        Dim ireturn As Boolean


        Dim thedate As Date = Date.Today
        ' Dim thedate As String = xdate.ToString

        'sql to insert person
        Dim sql As String = "INSERT INTO tbl_schedules(bus_name, driver_name, route_name,time_depart,date) VALUES (@bus_name,@driver_fname,@route_name,@time_depart,@thedate)"

        Dim cmd = New MySqlCommand(sql, objGlobal.con)

        cmd.Parameters.AddWithValue("@bus_name", bus_name)
        cmd.Parameters.AddWithValue("@driver_fname", driver_fname)
        cmd.Parameters.AddWithValue("@route_name", route_name)
        cmd.Parameters.AddWithValue("@time_depart", time_depart)
        cmd.Parameters.AddWithValue("@thedate", thedate)
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
        'ComboBoxBus.Clear()
        'ComboBoxDriver.Clear()
        'ComboBoxRoute.Clear()
        'DateTimePicker_depart_time

        Return 0
    End Function
End Class

