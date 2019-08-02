Imports MySql.Data.MySqlClient
Public Class uc_main_Ticketing
    Dim objGlobal As clsGlobal = New clsGlobal
    Private Sub uc_main_Ticketing_Load(sender As Object, e As EventArgs) Handles Me.Load
        Uc_main_Customers_Add1.Visible = False
        Panelreceipt.Visible = False
        ButtonPrintTicket.Visible = False
        'Populate combo customer 
        Try
            Dim adapter As New MySqlDataAdapter("Select tbl_customer.customer_id, tbl_people.fname from tbl_customer JOIN tbl_people ON tbl_customer.person_id= tbl_people.person_id", objGlobal.con)
            Dim table As New DataTable()
            adapter.Fill(table)
            ComboBoxCustomer.DataSource = table
            ComboBoxCustomer.ValueMember = "customer_id"
            ComboBoxCustomer.DisplayMember = "fname"
            objGlobal.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Populate combo schedule
        Try
            Dim adapter As New MySqlDataAdapter("SELECT entry_id, time_depart  FROM tbl_schedules", objGlobal.con)
            Dim table As New DataTable()
            adapter.Fill(table)
            ComboBoxSchedule.DataSource = table
            ComboBoxSchedule.ValueMember = "entry_id"
            ComboBoxSchedule.DisplayMember = "time_depart"
            objGlobal.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonSellTicket_Click(sender As Object, e As EventArgs) Handles ButtonSellTicket.Click
        Dim schedule As String = ComboBoxSchedule.SelectedValue
        Dim customerid As String = ComboBoxCustomer.SelectedValue
        Dim amountgiven As String = Double.Parse(TextBoxAmountGiven.Text)
        Dim priceofticket As Double = 1000.0
        Dim change As Double = priceofticket - amountgiven
        Dim net_amountPaid As Double = priceofticket

        Dim status As Boolean = SellTicket(schedule, customerid, net_amountPaid)
        If status = True Then
            'If save was successfu, hide this addUserControl
            'Clear Textboxes
            'clearEntries()
        End If
    End Sub

    Private Function SellTicket(ByVal schedule As Integer, ByVal customerid As Integer, ByVal amount_paid As Double) As Boolean
        'Declare object for clsGlobal class
        Dim objGlobal As clsGlobal = New clsGlobal
        'Declare variable to be returned by function
        Dim ireturn As Boolean
        'sql to insert person
        Dim sql As String = "INSERT INTO tbl_tickets(voyage_id, customer_id, amount_paid) VALUES (@schedule,@customerid,@amount_paid)"

        Dim cmd = New MySqlCommand(sql, objGlobal.con)

        cmd.Parameters.AddWithValue("@schedule", schedule)
        cmd.Parameters.AddWithValue("@customerid", customerid)
        cmd.Parameters.AddWithValue("@amount_paid", amount_paid)

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
        Panelreceipt.Visible = False
        ButtonPrintTicket.Visible = False
        Return 0
    End Function
    Private Function ShowReceipt() As Integer
        Panelreceipt.Visible = True
        ButtonPrintTicket.Visible = True
        Return 0
    End Function
    Private Sub ButtonCustomerAdd_Click(sender As Object, e As EventArgs) Handles ButtonCustomerAdd.Click
        Uc_main_Customers_Add1.Visible = True
        Uc_main_Customers_Add1.BringToFront()
    End Sub

    Private Sub ButtonPrintTicket_Click(sender As Object, e As EventArgs) Handles ButtonPrintTicket.Click
        clearEntries()
    End Sub


End Class
