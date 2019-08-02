<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_Nav_buses = New System.Windows.Forms.Button()
        Me.Button_Nav_Schedules = New System.Windows.Forms.Button()
        Me.Button_Nav_users = New System.Windows.Forms.Button()
        Me.Button_Nav_customers = New System.Windows.Forms.Button()
        Me.Button_Nav_drivers = New System.Windows.Forms.Button()
        Me.Button_Nav_routing = New System.Windows.Forms.Button()
        Me.Nav_active_indicator7 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Nav_active_indicator6 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Nav_active_indicator5 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Nav_active_indicator4 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Nav_active_indicator3 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Nav_active_indicator2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Nav_active_indicator1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button_Nav_ticketing = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox_Exit = New System.Windows.Forms.PictureBox()
        Me.ButtonLogout = New System.Windows.Forms.Button()
        Me.Uc_main_Ticketing1 = New bus.uc_main_Ticketing()
        Me.Uc_main_Schedules1 = New bus.uc_main_Schedules()
        Me.Uc_main_Routes1 = New bus.uc_main_Routes()
        Me.Uc_main_Drivers1 = New bus.uc_main_Drivers()
        Me.Uc_main_Customers1 = New bus.uc_main_Customers()
        Me.Uc_main_Buses1 = New bus.uc_main_Buses()
        Me.Uc_main_Users1 = New bus.uc_main_Users()
        Me.Panel1.SuspendLayout()
        Me.Nav_active_indicator7.SuspendLayout()
        Me.Nav_active_indicator6.SuspendLayout()
        Me.Nav_active_indicator5.SuspendLayout()
        Me.Nav_active_indicator4.SuspendLayout()
        Me.Nav_active_indicator3.SuspendLayout()
        Me.Nav_active_indicator2.SuspendLayout()
        Me.Nav_active_indicator1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Exit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button_Nav_buses)
        Me.Panel1.Controls.Add(Me.Button_Nav_Schedules)
        Me.Panel1.Controls.Add(Me.Button_Nav_users)
        Me.Panel1.Controls.Add(Me.Button_Nav_customers)
        Me.Panel1.Controls.Add(Me.Button_Nav_drivers)
        Me.Panel1.Controls.Add(Me.Button_Nav_routing)
        Me.Panel1.Controls.Add(Me.Nav_active_indicator7)
        Me.Panel1.Controls.Add(Me.Nav_active_indicator6)
        Me.Panel1.Controls.Add(Me.Nav_active_indicator5)
        Me.Panel1.Controls.Add(Me.Nav_active_indicator4)
        Me.Panel1.Controls.Add(Me.Nav_active_indicator3)
        Me.Panel1.Controls.Add(Me.Nav_active_indicator2)
        Me.Panel1.Controls.Add(Me.Nav_active_indicator1)
        Me.Panel1.Controls.Add(Me.Button_Nav_ticketing)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 697)
        Me.Panel1.TabIndex = 0
        '
        'Button_Nav_buses
        '
        Me.Button_Nav_buses.FlatAppearance.BorderSize = 0
        Me.Button_Nav_buses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Nav_buses.Font = New System.Drawing.Font("Leelawadee", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Nav_buses.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button_Nav_buses.Image = CType(resources.GetObject("Button_Nav_buses.Image"), System.Drawing.Image)
        Me.Button_Nav_buses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Nav_buses.Location = New System.Drawing.Point(15, 220)
        Me.Button_Nav_buses.Name = "Button_Nav_buses"
        Me.Button_Nav_buses.Size = New System.Drawing.Size(185, 55)
        Me.Button_Nav_buses.TabIndex = 7
        Me.Button_Nav_buses.Text = "BUS"
        Me.Button_Nav_buses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Nav_buses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Nav_buses.UseVisualStyleBackColor = True
        '
        'Button_Nav_Schedules
        '
        Me.Button_Nav_Schedules.FlatAppearance.BorderSize = 0
        Me.Button_Nav_Schedules.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Nav_Schedules.Font = New System.Drawing.Font("Leelawadee", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Nav_Schedules.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button_Nav_Schedules.Image = CType(resources.GetObject("Button_Nav_Schedules.Image"), System.Drawing.Image)
        Me.Button_Nav_Schedules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Nav_Schedules.Location = New System.Drawing.Point(12, 154)
        Me.Button_Nav_Schedules.Name = "Button_Nav_Schedules"
        Me.Button_Nav_Schedules.Size = New System.Drawing.Size(185, 55)
        Me.Button_Nav_Schedules.TabIndex = 6
        Me.Button_Nav_Schedules.Text = "SCHEDULES"
        Me.Button_Nav_Schedules.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Nav_Schedules.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Nav_Schedules.UseVisualStyleBackColor = True
        '
        'Button_Nav_users
        '
        Me.Button_Nav_users.FlatAppearance.BorderSize = 0
        Me.Button_Nav_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Nav_users.Font = New System.Drawing.Font("Leelawadee", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Nav_users.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button_Nav_users.Image = CType(resources.GetObject("Button_Nav_users.Image"), System.Drawing.Image)
        Me.Button_Nav_users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Nav_users.Location = New System.Drawing.Point(12, 484)
        Me.Button_Nav_users.Name = "Button_Nav_users"
        Me.Button_Nav_users.Size = New System.Drawing.Size(185, 55)
        Me.Button_Nav_users.TabIndex = 5
        Me.Button_Nav_users.Text = "USERS"
        Me.Button_Nav_users.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Nav_users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Nav_users.UseVisualStyleBackColor = True
        '
        'Button_Nav_customers
        '
        Me.Button_Nav_customers.FlatAppearance.BorderSize = 0
        Me.Button_Nav_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Nav_customers.Font = New System.Drawing.Font("Leelawadee", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Nav_customers.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button_Nav_customers.Image = CType(resources.GetObject("Button_Nav_customers.Image"), System.Drawing.Image)
        Me.Button_Nav_customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Nav_customers.Location = New System.Drawing.Point(12, 418)
        Me.Button_Nav_customers.Name = "Button_Nav_customers"
        Me.Button_Nav_customers.Size = New System.Drawing.Size(185, 55)
        Me.Button_Nav_customers.TabIndex = 4
        Me.Button_Nav_customers.Text = "CUSTOMERS"
        Me.Button_Nav_customers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Nav_customers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Nav_customers.UseVisualStyleBackColor = True
        '
        'Button_Nav_drivers
        '
        Me.Button_Nav_drivers.FlatAppearance.BorderSize = 0
        Me.Button_Nav_drivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Nav_drivers.Font = New System.Drawing.Font("Leelawadee", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Nav_drivers.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button_Nav_drivers.Image = CType(resources.GetObject("Button_Nav_drivers.Image"), System.Drawing.Image)
        Me.Button_Nav_drivers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Nav_drivers.Location = New System.Drawing.Point(12, 352)
        Me.Button_Nav_drivers.Name = "Button_Nav_drivers"
        Me.Button_Nav_drivers.Size = New System.Drawing.Size(185, 55)
        Me.Button_Nav_drivers.TabIndex = 3
        Me.Button_Nav_drivers.Text = "DRIVERS"
        Me.Button_Nav_drivers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Nav_drivers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Nav_drivers.UseVisualStyleBackColor = True
        '
        'Button_Nav_routing
        '
        Me.Button_Nav_routing.FlatAppearance.BorderSize = 0
        Me.Button_Nav_routing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Nav_routing.Font = New System.Drawing.Font("Leelawadee", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Nav_routing.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button_Nav_routing.Image = CType(resources.GetObject("Button_Nav_routing.Image"), System.Drawing.Image)
        Me.Button_Nav_routing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Nav_routing.Location = New System.Drawing.Point(15, 286)
        Me.Button_Nav_routing.Name = "Button_Nav_routing"
        Me.Button_Nav_routing.Size = New System.Drawing.Size(182, 55)
        Me.Button_Nav_routing.TabIndex = 2
        Me.Button_Nav_routing.Text = "ROUTING"
        Me.Button_Nav_routing.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Nav_routing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Nav_routing.UseVisualStyleBackColor = True
        '
        'Nav_active_indicator7
        '
        Me.Nav_active_indicator7.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Nav_active_indicator7.Controls.Add(Me.Panel16)
        Me.Nav_active_indicator7.Location = New System.Drawing.Point(1, 484)
        Me.Nav_active_indicator7.Name = "Nav_active_indicator7"
        Me.Nav_active_indicator7.Size = New System.Drawing.Size(8, 55)
        Me.Nav_active_indicator7.TabIndex = 1
        Me.Nav_active_indicator7.Visible = False
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel16.Location = New System.Drawing.Point(-96, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(8, 55)
        Me.Panel16.TabIndex = 3
        '
        'Nav_active_indicator6
        '
        Me.Nav_active_indicator6.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Nav_active_indicator6.Controls.Add(Me.Panel14)
        Me.Nav_active_indicator6.Location = New System.Drawing.Point(1, 418)
        Me.Nav_active_indicator6.Name = "Nav_active_indicator6"
        Me.Nav_active_indicator6.Size = New System.Drawing.Size(8, 55)
        Me.Nav_active_indicator6.TabIndex = 1
        Me.Nav_active_indicator6.Visible = False
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel14.Location = New System.Drawing.Point(-96, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(8, 55)
        Me.Panel14.TabIndex = 3
        '
        'Nav_active_indicator5
        '
        Me.Nav_active_indicator5.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Nav_active_indicator5.Controls.Add(Me.Panel12)
        Me.Nav_active_indicator5.Location = New System.Drawing.Point(1, 352)
        Me.Nav_active_indicator5.Name = "Nav_active_indicator5"
        Me.Nav_active_indicator5.Size = New System.Drawing.Size(8, 55)
        Me.Nav_active_indicator5.TabIndex = 1
        Me.Nav_active_indicator5.Visible = False
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel12.Location = New System.Drawing.Point(-96, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(8, 55)
        Me.Panel12.TabIndex = 3
        '
        'Nav_active_indicator4
        '
        Me.Nav_active_indicator4.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Nav_active_indicator4.Controls.Add(Me.Panel10)
        Me.Nav_active_indicator4.Location = New System.Drawing.Point(1, 286)
        Me.Nav_active_indicator4.Name = "Nav_active_indicator4"
        Me.Nav_active_indicator4.Size = New System.Drawing.Size(8, 55)
        Me.Nav_active_indicator4.TabIndex = 1
        Me.Nav_active_indicator4.Visible = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel10.Location = New System.Drawing.Point(-96, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(8, 55)
        Me.Panel10.TabIndex = 3
        '
        'Nav_active_indicator3
        '
        Me.Nav_active_indicator3.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Nav_active_indicator3.Controls.Add(Me.Panel8)
        Me.Nav_active_indicator3.Location = New System.Drawing.Point(1, 220)
        Me.Nav_active_indicator3.Name = "Nav_active_indicator3"
        Me.Nav_active_indicator3.Size = New System.Drawing.Size(8, 55)
        Me.Nav_active_indicator3.TabIndex = 1
        Me.Nav_active_indicator3.Visible = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(-96, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(8, 55)
        Me.Panel8.TabIndex = 3
        '
        'Nav_active_indicator2
        '
        Me.Nav_active_indicator2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Nav_active_indicator2.Controls.Add(Me.Panel6)
        Me.Nav_active_indicator2.Location = New System.Drawing.Point(1, 154)
        Me.Nav_active_indicator2.Name = "Nav_active_indicator2"
        Me.Nav_active_indicator2.Size = New System.Drawing.Size(8, 55)
        Me.Nav_active_indicator2.TabIndex = 1
        Me.Nav_active_indicator2.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(-96, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(8, 55)
        Me.Panel6.TabIndex = 3
        '
        'Nav_active_indicator1
        '
        Me.Nav_active_indicator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Nav_active_indicator1.Controls.Add(Me.Panel4)
        Me.Nav_active_indicator1.Location = New System.Drawing.Point(1, 88)
        Me.Nav_active_indicator1.Name = "Nav_active_indicator1"
        Me.Nav_active_indicator1.Size = New System.Drawing.Size(8, 55)
        Me.Nav_active_indicator1.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(-96, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(8, 55)
        Me.Panel4.TabIndex = 3
        '
        'Button_Nav_ticketing
        '
        Me.Button_Nav_ticketing.FlatAppearance.BorderSize = 0
        Me.Button_Nav_ticketing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Nav_ticketing.Font = New System.Drawing.Font("Leelawadee", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Nav_ticketing.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button_Nav_ticketing.Image = CType(resources.GetObject("Button_Nav_ticketing.Image"), System.Drawing.Image)
        Me.Button_Nav_ticketing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Nav_ticketing.Location = New System.Drawing.Point(12, 88)
        Me.Button_Nav_ticketing.Name = "Button_Nav_ticketing"
        Me.Button_Nav_ticketing.Size = New System.Drawing.Size(185, 55)
        Me.Button_Nav_ticketing.TabIndex = 0
        Me.Button_Nav_ticketing.Text = "TICKETING "
        Me.Button_Nav_ticketing.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Nav_ticketing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Nav_ticketing.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(999, 13)
        Me.Panel2.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Location = New System.Drawing.Point(252, 12)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(94, 93)
        Me.Panel5.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("PMingLiU-ExtB", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(576, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "TAHMEED BUS SACCO"
        '
        'PictureBox_Exit
        '
        Me.PictureBox_Exit.Image = CType(resources.GetObject("PictureBox_Exit.Image"), System.Drawing.Image)
        Me.PictureBox_Exit.Location = New System.Drawing.Point(1163, 19)
        Me.PictureBox_Exit.Name = "PictureBox_Exit"
        Me.PictureBox_Exit.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Exit.TabIndex = 11
        Me.PictureBox_Exit.TabStop = False
        '
        'ButtonLogout
        '
        Me.ButtonLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogout.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogout.ForeColor = System.Drawing.Color.Black
        Me.ButtonLogout.Location = New System.Drawing.Point(1060, 21)
        Me.ButtonLogout.Name = "ButtonLogout"
        Me.ButtonLogout.Size = New System.Drawing.Size(78, 33)
        Me.ButtonLogout.TabIndex = 13
        Me.ButtonLogout.Text = "LOGOUT"
        Me.ButtonLogout.UseVisualStyleBackColor = True
        '
        'Uc_main_Ticketing1
        '
        Me.Uc_main_Ticketing1.Location = New System.Drawing.Point(254, 133)
        Me.Uc_main_Ticketing1.Name = "Uc_main_Ticketing1"
        Me.Uc_main_Ticketing1.Size = New System.Drawing.Size(911, 508)
        Me.Uc_main_Ticketing1.TabIndex = 10
        '
        'Uc_main_Schedules1
        '
        Me.Uc_main_Schedules1.Location = New System.Drawing.Point(252, 133)
        Me.Uc_main_Schedules1.Name = "Uc_main_Schedules1"
        Me.Uc_main_Schedules1.Size = New System.Drawing.Size(911, 508)
        Me.Uc_main_Schedules1.TabIndex = 9
        '
        'Uc_main_Routes1
        '
        Me.Uc_main_Routes1.Location = New System.Drawing.Point(252, 133)
        Me.Uc_main_Routes1.Name = "Uc_main_Routes1"
        Me.Uc_main_Routes1.Size = New System.Drawing.Size(911, 508)
        Me.Uc_main_Routes1.TabIndex = 8
        '
        'Uc_main_Drivers1
        '
        Me.Uc_main_Drivers1.Location = New System.Drawing.Point(252, 133)
        Me.Uc_main_Drivers1.Name = "Uc_main_Drivers1"
        Me.Uc_main_Drivers1.Size = New System.Drawing.Size(911, 508)
        Me.Uc_main_Drivers1.TabIndex = 7
        '
        'Uc_main_Customers1
        '
        Me.Uc_main_Customers1.Location = New System.Drawing.Point(252, 133)
        Me.Uc_main_Customers1.Name = "Uc_main_Customers1"
        Me.Uc_main_Customers1.Size = New System.Drawing.Size(911, 508)
        Me.Uc_main_Customers1.TabIndex = 6
        '
        'Uc_main_Buses1
        '
        Me.Uc_main_Buses1.Location = New System.Drawing.Point(252, 133)
        Me.Uc_main_Buses1.Name = "Uc_main_Buses1"
        Me.Uc_main_Buses1.Size = New System.Drawing.Size(911, 508)
        Me.Uc_main_Buses1.TabIndex = 5
        '
        'Uc_main_Users1
        '
        Me.Uc_main_Users1.Location = New System.Drawing.Point(252, 133)
        Me.Uc_main_Users1.Name = "Uc_main_Users1"
        Me.Uc_main_Users1.Size = New System.Drawing.Size(911, 508)
        Me.Uc_main_Users1.TabIndex = 4
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1199, 697)
        Me.Controls.Add(Me.ButtonLogout)
        Me.Controls.Add(Me.PictureBox_Exit)
        Me.Controls.Add(Me.Uc_main_Ticketing1)
        Me.Controls.Add(Me.Uc_main_Schedules1)
        Me.Controls.Add(Me.Uc_main_Routes1)
        Me.Controls.Add(Me.Uc_main_Drivers1)
        Me.Controls.Add(Me.Uc_main_Customers1)
        Me.Controls.Add(Me.Uc_main_Buses1)
        Me.Controls.Add(Me.Uc_main_Users1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Nav_active_indicator7.ResumeLayout(False)
        Me.Nav_active_indicator6.ResumeLayout(False)
        Me.Nav_active_indicator5.ResumeLayout(False)
        Me.Nav_active_indicator4.ResumeLayout(False)
        Me.Nav_active_indicator3.ResumeLayout(False)
        Me.Nav_active_indicator2.ResumeLayout(False)
        Me.Nav_active_indicator1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Exit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button_Nav_ticketing As Button
    Friend WithEvents Nav_active_indicator1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_Nav_buses As Button
    Friend WithEvents Button_Nav_Schedules As Button
    Friend WithEvents Button_Nav_users As Button
    Friend WithEvents Button_Nav_customers As Button
    Friend WithEvents Button_Nav_drivers As Button
    Friend WithEvents Button_Nav_routing As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Nav_active_indicator7 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Nav_active_indicator6 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Nav_active_indicator5 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Nav_active_indicator4 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Nav_active_indicator3 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Nav_active_indicator2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Uc_main_Users1 As uc_main_Users
    Friend WithEvents Uc_main_Buses1 As uc_main_Buses
    Friend WithEvents Uc_main_Customers1 As uc_main_Customers
    Friend WithEvents Uc_main_Drivers1 As uc_main_Drivers
    Friend WithEvents Uc_main_Routes1 As uc_main_Routes
    Friend WithEvents Uc_main_Schedules1 As uc_main_Schedules
    Friend WithEvents Uc_main_Ticketing1 As uc_main_Ticketing
    Friend WithEvents PictureBox_Exit As PictureBox
    Friend WithEvents ButtonLogout As Button
End Class
