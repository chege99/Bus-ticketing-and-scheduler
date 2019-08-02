<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_main_Routes_Add
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
        Me.Label_response = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonSaveRoute = New System.Windows.Forms.Button()
        Me.TB_description = New System.Windows.Forms.TextBox()
        Me.TB_estimated_time = New System.Windows.Forms.TextBox()
        Me.TB_charge = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_destination = New System.Windows.Forms.TextBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.TB_pickuppoint = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_Routename_generated = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_response
        '
        Me.Label_response.AutoSize = True
        Me.Label_response.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_response.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label_response.Location = New System.Drawing.Point(20, 51)
        Me.Label_response.Name = "Label_response"
        Me.Label_response.Size = New System.Drawing.Size(54, 13)
        Me.Label_response.TabIndex = 14
        Me.Label_response.Text = "response"
        Me.Label_response.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(603, 48)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ROUTES"
        '
        'ButtonSaveRoute
        '
        Me.ButtonSaveRoute.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonSaveRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSaveRoute.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveRoute.ForeColor = System.Drawing.Color.Black
        Me.ButtonSaveRoute.Location = New System.Drawing.Point(287, 394)
        Me.ButtonSaveRoute.Name = "ButtonSaveRoute"
        Me.ButtonSaveRoute.Size = New System.Drawing.Size(119, 33)
        Me.ButtonSaveRoute.TabIndex = 0
        Me.ButtonSaveRoute.Text = "SAVE ROUTE"
        Me.ButtonSaveRoute.UseVisualStyleBackColor = True
        '
        'TB_description
        '
        Me.TB_description.Location = New System.Drawing.Point(39, 241)
        Me.TB_description.Name = "TB_description"
        Me.TB_description.Size = New System.Drawing.Size(214, 25)
        Me.TB_description.TabIndex = 5
        '
        'TB_estimated_time
        '
        Me.TB_estimated_time.Location = New System.Drawing.Point(39, 291)
        Me.TB_estimated_time.Name = "TB_estimated_time"
        Me.TB_estimated_time.Size = New System.Drawing.Size(214, 25)
        Me.TB_estimated_time.TabIndex = 3
        '
        'TB_charge
        '
        Me.TB_charge.Location = New System.Drawing.Point(39, 191)
        Me.TB_charge.Name = "TB_charge"
        Me.TB_charge.Size = New System.Drawing.Size(214, 25)
        Me.TB_charge.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(20, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Pick up point"
        '
        'TB_destination
        '
        Me.TB_destination.Location = New System.Drawing.Point(39, 141)
        Me.TB_destination.Name = "TB_destination"
        Me.TB_destination.Size = New System.Drawing.Size(214, 25)
        Me.TB_destination.TabIndex = 6
        '
        'ButtonCancel
        '
        Me.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.Color.Black
        Me.ButtonCancel.Location = New System.Drawing.Point(162, 394)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(119, 33)
        Me.ButtonCancel.TabIndex = 23
        Me.ButtonCancel.Text = "CANCEL "
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'TB_pickuppoint
        '
        Me.TB_pickuppoint.Location = New System.Drawing.Point(39, 91)
        Me.TB_pickuppoint.Name = "TB_pickuppoint"
        Me.TB_pickuppoint.Size = New System.Drawing.Size(214, 25)
        Me.TB_pickuppoint.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(20, 272)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Estimated Hours of Travel"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(20, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Charge"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(20, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Description"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(20, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Destination"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.ButtonCancel)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label_response)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.ButtonSaveRoute)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(603, 439)
        Me.Panel1.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TB_description)
        Me.GroupBox1.Controls.Add(Me.TB_estimated_time)
        Me.GroupBox1.Controls.Add(Me.TB_charge)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TB_destination)
        Me.GroupBox1.Controls.Add(Me.TB_Routename_generated)
        Me.GroupBox1.Controls.Add(Me.TB_pickuppoint)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(140, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 325)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ROUTE INFORMATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(20, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Route Name"
        '
        'TB_Routename_generated
        '
        Me.TB_Routename_generated.Location = New System.Drawing.Point(39, 44)
        Me.TB_Routename_generated.Name = "TB_Routename_generated"
        Me.TB_Routename_generated.Size = New System.Drawing.Size(214, 25)
        Me.TB_Routename_generated.TabIndex = 7
        '
        'uc_main_Routes_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_main_Routes_Add"
        Me.Size = New System.Drawing.Size(603, 437)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label_response As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonSaveRoute As Button
    Friend WithEvents TB_description As TextBox
    Friend WithEvents TB_estimated_time As TextBox
    Friend WithEvents TB_charge As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_destination As TextBox
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents TB_pickuppoint As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_Routename_generated As TextBox
End Class
