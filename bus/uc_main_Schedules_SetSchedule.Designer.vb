<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_main_Schedules_SetSchedule
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonSetSchedule = New System.Windows.Forms.Button()
        Me.DateTimePicker_depart_time = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxDriver = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxRoute = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxBus = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonCancel
        '
        Me.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.Color.Black
        Me.ButtonCancel.Location = New System.Drawing.Point(129, 318)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(119, 33)
        Me.ButtonCancel.TabIndex = 25
        Me.ButtonCancel.Text = "CANCEL "
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonSetSchedule
        '
        Me.ButtonSetSchedule.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonSetSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSetSchedule.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSetSchedule.ForeColor = System.Drawing.Color.Black
        Me.ButtonSetSchedule.Location = New System.Drawing.Point(276, 318)
        Me.ButtonSetSchedule.Name = "ButtonSetSchedule"
        Me.ButtonSetSchedule.Size = New System.Drawing.Size(119, 33)
        Me.ButtonSetSchedule.TabIndex = 24
        Me.ButtonSetSchedule.Text = "SET"
        Me.ButtonSetSchedule.UseVisualStyleBackColor = True
        '
        'DateTimePicker_depart_time
        '
        Me.DateTimePicker_depart_time.CustomFormat = "hh:mm:ss"
        Me.DateTimePicker_depart_time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker_depart_time.Location = New System.Drawing.Point(40, 186)
        Me.DateTimePicker_depart_time.Name = "DateTimePicker_depart_time"
        Me.DateTimePicker_depart_time.ShowUpDown = True
        Me.DateTimePicker_depart_time.Size = New System.Drawing.Size(266, 25)
        Me.DateTimePicker_depart_time.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(25, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "PICK DEPARTURE TIME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(25, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "CHOOSE DRIVER"
        '
        'ComboBoxDriver
        '
        Me.ComboBoxDriver.FormattingEnabled = True
        Me.ComboBoxDriver.Location = New System.Drawing.Point(40, 140)
        Me.ComboBoxDriver.Name = "ComboBoxDriver"
        Me.ComboBoxDriver.Size = New System.Drawing.Size(266, 25)
        Me.ComboBoxDriver.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(25, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "CHOOSE ROUTE"
        '
        'ComboBoxRoute
        '
        Me.ComboBoxRoute.FormattingEnabled = True
        Me.ComboBoxRoute.Location = New System.Drawing.Point(40, 94)
        Me.ComboBoxRoute.Name = "ComboBoxRoute"
        Me.ComboBoxRoute.Size = New System.Drawing.Size(266, 25)
        Me.ComboBoxRoute.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(25, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "CHOOSE BUS"
        '
        'ComboBoxBus
        '
        Me.ComboBoxBus.FormattingEnabled = True
        Me.ComboBoxBus.Location = New System.Drawing.Point(40, 48)
        Me.ComboBoxBus.Name = "ComboBoxBus"
        Me.ComboBoxBus.Size = New System.Drawing.Size(266, 25)
        Me.ComboBoxBus.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(526, 48)
        Me.Panel6.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(40, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SET BUS SCHEDULE"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.ButtonCancel)
        Me.Panel3.Controls.Add(Me.ButtonSetSchedule)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(526, 404)
        Me.Panel3.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBoxBus)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_depart_time)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ComboBoxRoute)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxDriver)
        Me.GroupBox1.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(86, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 238)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Schedule For Today"
        '
        'uc_main_Schedules_SetSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Name = "uc_main_Schedules_SetSchedule"
        Me.Size = New System.Drawing.Size(526, 407)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonSetSchedule As Button
    Friend WithEvents DateTimePicker_depart_time As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxDriver As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxRoute As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxBus As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
End Class
