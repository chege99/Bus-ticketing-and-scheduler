<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_custom_AddUser
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
        Me.ButtonSaveUser = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_response = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_usename = New System.Windows.Forms.TextBox()
        Me.TB_password = New System.Windows.Forms.TextBox()
        Me.TB_passwordcheck = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TB_fname = New System.Windows.Forms.TextBox()
        Me.TB_lname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_email = New System.Windows.Forms.TextBox()
        Me.TB_idnumber = New System.Windows.Forms.TextBox()
        Me.TB_phone = New System.Windows.Forms.TextBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonSaveUser
        '
        Me.ButtonSaveUser.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSaveUser.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveUser.ForeColor = System.Drawing.Color.Black
        Me.ButtonSaveUser.Location = New System.Drawing.Point(454, 302)
        Me.ButtonSaveUser.Name = "ButtonSaveUser"
        Me.ButtonSaveUser.Size = New System.Drawing.Size(119, 33)
        Me.ButtonSaveUser.TabIndex = 0
        Me.ButtonSaveUser.Text = "NEW USER"
        Me.ButtonSaveUser.UseVisualStyleBackColor = True
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
        Me.Label1.Size = New System.Drawing.Size(124, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "New User"
        '
        'Label_response
        '
        Me.Label_response.AutoSize = True
        Me.Label_response.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_response.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label_response.Location = New System.Drawing.Point(533, 51)
        Me.Label_response.Name = "Label_response"
        Me.Label_response.Size = New System.Drawing.Size(54, 13)
        Me.Label_response.TabIndex = 14
        Me.Label_response.Text = "response"
        Me.Label_response.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TB_passwordcheck)
        Me.GroupBox2.Controls.Add(Me.TB_password)
        Me.GroupBox2.Controls.Add(Me.TB_usename)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(308, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(284, 198)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LOGIN  CREDENTIALS "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(28, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(28, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Confirm Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(28, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Username"
        '
        'TB_usename
        '
        Me.TB_usename.Location = New System.Drawing.Point(43, 45)
        Me.TB_usename.Name = "TB_usename"
        Me.TB_usename.Size = New System.Drawing.Size(214, 25)
        Me.TB_usename.TabIndex = 21
        '
        'TB_password
        '
        Me.TB_password.Location = New System.Drawing.Point(43, 97)
        Me.TB_password.Name = "TB_password"
        Me.TB_password.Size = New System.Drawing.Size(214, 25)
        Me.TB_password.TabIndex = 4
        '
        'TB_passwordcheck
        '
        Me.TB_passwordcheck.Location = New System.Drawing.Point(43, 149)
        Me.TB_passwordcheck.Name = "TB_passwordcheck"
        Me.TB_passwordcheck.Size = New System.Drawing.Size(214, 25)
        Me.TB_passwordcheck.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TB_phone)
        Me.GroupBox1.Controls.Add(Me.TB_idnumber)
        Me.GroupBox1.Controls.Add(Me.TB_email)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TB_lname)
        Me.GroupBox1.Controls.Add(Me.TB_fname)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 296)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PERSONAL INFORMATION "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(28, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Last Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(28, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Phone Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(28, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Email"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(28, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "National ID Number"
        '
        'TB_fname
        '
        Me.TB_fname.Location = New System.Drawing.Point(47, 43)
        Me.TB_fname.Name = "TB_fname"
        Me.TB_fname.Size = New System.Drawing.Size(214, 25)
        Me.TB_fname.TabIndex = 7
        '
        'TB_lname
        '
        Me.TB_lname.Location = New System.Drawing.Point(47, 93)
        Me.TB_lname.Name = "TB_lname"
        Me.TB_lname.Size = New System.Drawing.Size(214, 25)
        Me.TB_lname.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(28, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "First Name"
        '
        'TB_email
        '
        Me.TB_email.Location = New System.Drawing.Point(47, 143)
        Me.TB_email.Name = "TB_email"
        Me.TB_email.Size = New System.Drawing.Size(214, 25)
        Me.TB_email.TabIndex = 8
        '
        'TB_idnumber
        '
        Me.TB_idnumber.Location = New System.Drawing.Point(47, 243)
        Me.TB_idnumber.Name = "TB_idnumber"
        Me.TB_idnumber.Size = New System.Drawing.Size(214, 25)
        Me.TB_idnumber.TabIndex = 3
        '
        'TB_phone
        '
        Me.TB_phone.Location = New System.Drawing.Point(47, 193)
        Me.TB_phone.Name = "TB_phone"
        Me.TB_phone.Size = New System.Drawing.Size(214, 25)
        Me.TB_phone.TabIndex = 5
        '
        'ButtonCancel
        '
        Me.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.Color.Black
        Me.ButtonCancel.Location = New System.Drawing.Point(329, 302)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(119, 33)
        Me.ButtonCancel.TabIndex = 23
        Me.ButtonCancel.Text = "CANCEL "
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.ButtonCancel)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Label_response)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.ButtonSaveUser)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(603, 358)
        Me.Panel1.TabIndex = 6
        '
        'uc_custom_AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_custom_AddUser"
        Me.Size = New System.Drawing.Size(603, 364)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonSaveUser As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_response As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TB_passwordcheck As TextBox
    Friend WithEvents TB_password As TextBox
    Friend WithEvents TB_usename As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TB_phone As TextBox
    Friend WithEvents TB_idnumber As TextBox
    Friend WithEvents TB_email As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_lname As TextBox
    Friend WithEvents TB_fname As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents Panel1 As Panel
End Class
