Public Class dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginForm.Hide()
    End Sub

    Private Sub Button_Nav_ticketing_Click(sender As Object, e As EventArgs) Handles Button_Nav_ticketing.Click
        ActiveIndicator()
        Uc_main_Ticketing1.BringToFront()
        Nav_active_indicator1.Visible = True
    End Sub

    Private Sub Button_Nav_Schedules_Click(sender As Object, e As EventArgs) Handles Button_Nav_Schedules.Click
        ActiveIndicator()
        Uc_main_Schedules1.BringToFront()
        Nav_active_indicator2.Visible = True
    End Sub

    Private Sub Button_Nav_buses_Click(sender As Object, e As EventArgs) Handles Button_Nav_buses.Click
        ActiveIndicator()
        Uc_main_Buses1.BringToFront()
        Nav_active_indicator3.Visible = True
    End Sub

    Private Sub Button_Nav_routing_Click(sender As Object, e As EventArgs) Handles Button_Nav_routing.Click
        ActiveIndicator()
        Uc_main_Routes1.BringToFront()
        Nav_active_indicator4.Visible = True
    End Sub

    Private Sub Button_Nav_drivers_Click(sender As Object, e As EventArgs) Handles Button_Nav_drivers.Click
        ActiveIndicator()
        Uc_main_Drivers1.BringToFront()
        Nav_active_indicator5.Visible = True
    End Sub

    Private Sub Button_Nav_customers_Click(sender As Object, e As EventArgs) Handles Button_Nav_customers.Click
        ActiveIndicator()
        Uc_main_Customers1.BringToFront()
        Nav_active_indicator6.Visible = True
    End Sub

    Private Sub Button_Nav_users_Click(sender As Object, e As EventArgs) Handles Button_Nav_users.Click
        ActiveIndicator()
        Uc_main_Users1.BringToFront()
        Nav_active_indicator7.Visible = True
    End Sub
    Private Function ActiveIndicator() As Integer
        Nav_active_indicator1.Visible = False
        Nav_active_indicator2.Visible = False
        Nav_active_indicator3.Visible = False
        Nav_active_indicator4.Visible = False
        Nav_active_indicator5.Visible = False
        Nav_active_indicator6.Visible = False
        Nav_active_indicator7.Visible = False
        Uc_main_Users1.SendToBack()
        Uc_main_Customers1.SendToBack()
        Uc_main_Drivers1.SendToBack()
        Uc_main_Routes1.SendToBack()
        Uc_main_Buses1.SendToBack()
        Uc_main_Ticketing1.SendToBack()
        Uc_main_Schedules1.SendToBack()
        Return 0
    End Function

    Private Sub PictureBox_Exit_Click(sender As Object, e As EventArgs) Handles PictureBox_Exit.Click
        Me.Close()
        LoginForm.Close()
    End Sub

    Private Sub ButtonLogout_Click_1(sender As Object, e As EventArgs) Handles ButtonLogout.Click
        Me.Close()
        LoginForm.Show()
    End Sub


End Class