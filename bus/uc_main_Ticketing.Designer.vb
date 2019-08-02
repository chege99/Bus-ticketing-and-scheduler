<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_main_Ticketing
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ButtonPrintTicket = New System.Windows.Forms.Button()
        Me.Uc_main_Customers_Add1 = New bus.uc_main_Customers_Add()
        Me.Panelreceipt = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonCustomerAdd = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonSellTicket = New System.Windows.Forms.Button()
        Me.TextBoxChange = New System.Windows.Forms.TextBox()
        Me.TextBoxAmountGiven = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxCustomer = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxSchedule = New System.Windows.Forms.ComboBox()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panelreceipt.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(911, 48)
        Me.Panel6.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(32, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SELL TICKETS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.ButtonPrintTicket)
        Me.Panel3.Controls.Add(Me.Uc_main_Customers_Add1)
        Me.Panel3.Controls.Add(Me.Panelreceipt)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(911, 424)
        Me.Panel3.TabIndex = 8
        '
        'ButtonPrintTicket
        '
        Me.ButtonPrintTicket.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ButtonPrintTicket.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonPrintTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPrintTicket.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrintTicket.ForeColor = System.Drawing.Color.White
        Me.ButtonPrintTicket.Location = New System.Drawing.Point(741, 359)
        Me.ButtonPrintTicket.Name = "ButtonPrintTicket"
        Me.ButtonPrintTicket.Size = New System.Drawing.Size(120, 37)
        Me.ButtonPrintTicket.TabIndex = 4
        Me.ButtonPrintTicket.Text = "PRINT TICKET "
        Me.ButtonPrintTicket.UseVisualStyleBackColor = False
        '
        'Uc_main_Customers_Add1
        '
        Me.Uc_main_Customers_Add1.Location = New System.Drawing.Point(160, 22)
        Me.Uc_main_Customers_Add1.Name = "Uc_main_Customers_Add1"
        Me.Uc_main_Customers_Add1.Size = New System.Drawing.Size(560, 390)
        Me.Uc_main_Customers_Add1.TabIndex = 2
        '
        'Panelreceipt
        '
        Me.Panelreceipt.BackColor = System.Drawing.Color.White
        Me.Panelreceipt.Controls.Add(Me.Label9)
        Me.Panelreceipt.Controls.Add(Me.Label10)
        Me.Panelreceipt.Controls.Add(Me.Label11)
        Me.Panelreceipt.Controls.Add(Me.Label8)
        Me.Panelreceipt.Controls.Add(Me.Label7)
        Me.Panelreceipt.Controls.Add(Me.Label6)
        Me.Panelreceipt.Controls.Add(Me.Panel1)
        Me.Panelreceipt.Location = New System.Drawing.Point(591, 71)
        Me.Panelreceipt.Name = "Panelreceipt"
        Me.Panelreceipt.Size = New System.Drawing.Size(270, 282)
        Me.Panelreceipt.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(68, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "CHANGE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(60, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = " CUSTOMER"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(60, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "TIME OF DEPARTURE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(12, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "CHANGE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(12, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = " CUSTOMER"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(12, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "TIME OF DEPARTURE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(270, 41)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonCustomerAdd)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ButtonSellTicket)
        Me.GroupBox1.Controls.Add(Me.TextBoxChange)
        Me.GroupBox1.Controls.Add(Me.TextBoxAmountGiven)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBoxCustomer)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxSchedule)
        Me.GroupBox1.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 329)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELL TICKET"
        '
        'ButtonCustomerAdd
        '
        Me.ButtonCustomerAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ButtonCustomerAdd.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonCustomerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCustomerAdd.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCustomerAdd.ForeColor = System.Drawing.Color.White
        Me.ButtonCustomerAdd.Location = New System.Drawing.Point(236, 110)
        Me.ButtonCustomerAdd.Name = "ButtonCustomerAdd"
        Me.ButtonCustomerAdd.Size = New System.Drawing.Size(120, 26)
        Me.ButtonCustomerAdd.TabIndex = 2
        Me.ButtonCustomerAdd.Text = "NEW CUSTOMER"
        Me.ButtonCustomerAdd.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(46, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 33)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonSellTicket
        '
        Me.ButtonSellTicket.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonSellTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSellTicket.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSellTicket.ForeColor = System.Drawing.Color.Black
        Me.ButtonSellTicket.Location = New System.Drawing.Point(236, 266)
        Me.ButtonSellTicket.Name = "ButtonSellTicket"
        Me.ButtonSellTicket.Size = New System.Drawing.Size(119, 33)
        Me.ButtonSellTicket.TabIndex = 26
        Me.ButtonSellTicket.Text = "SELL"
        Me.ButtonSellTicket.UseVisualStyleBackColor = True
        '
        'TextBoxChange
        '
        Me.TextBoxChange.Location = New System.Drawing.Point(46, 223)
        Me.TextBoxChange.Name = "TextBoxChange"
        Me.TextBoxChange.Size = New System.Drawing.Size(310, 25)
        Me.TextBoxChange.TabIndex = 24
        '
        'TextBoxAmountGiven
        '
        Me.TextBoxAmountGiven.Location = New System.Drawing.Point(46, 164)
        Me.TextBoxAmountGiven.Name = "TextBoxAmountGiven"
        Me.TextBoxAmountGiven.Size = New System.Drawing.Size(310, 25)
        Me.TextBoxAmountGiven.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(19, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "ENTER AMOUNT GIVEN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(19, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "CHANGE DUE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(19, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "CHOOSE CUSTOMER"
        '
        'ComboBoxCustomer
        '
        Me.ComboBoxCustomer.FormattingEnabled = True
        Me.ComboBoxCustomer.Location = New System.Drawing.Point(46, 111)
        Me.ComboBoxCustomer.Name = "ComboBoxCustomer"
        Me.ComboBoxCustomer.Size = New System.Drawing.Size(174, 25)
        Me.ComboBoxCustomer.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(19, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "CHOOSE SCHEDULE"
        '
        'ComboBoxSchedule
        '
        Me.ComboBoxSchedule.FormattingEnabled = True
        Me.ComboBoxSchedule.Location = New System.Drawing.Point(46, 51)
        Me.ComboBoxSchedule.Name = "ComboBoxSchedule"
        Me.ComboBoxSchedule.Size = New System.Drawing.Size(310, 25)
        Me.ComboBoxSchedule.TabIndex = 0
        '
        'uc_main_Ticketing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Name = "uc_main_Ticketing"
        Me.Size = New System.Drawing.Size(911, 424)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panelreceipt.ResumeLayout(False)
        Me.Panelreceipt.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBoxSchedule As ComboBox
    Friend WithEvents TextBoxChange As TextBox
    Friend WithEvents TextBoxAmountGiven As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxCustomer As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonSellTicket As Button
    Friend WithEvents ButtonCustomerAdd As Button
    Friend WithEvents Uc_main_Customers_Add1 As uc_main_Customers_Add
    Friend WithEvents Panelreceipt As Panel
    Friend WithEvents ButtonPrintTicket As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
