<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class promptLogin
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label_Response_Login = New System.Windows.Forms.Label()
        Me.TextBox_Login_Password = New System.Windows.Forms.TextBox()
        Me.TextBox_Login_Username = New System.Windows.Forms.TextBox()
        Me.Button_Login = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(243, 49)
        Me.Panel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(92, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGIN"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label_Response_Login)
        Me.Panel2.Controls.Add(Me.TextBox_Login_Password)
        Me.Panel2.Controls.Add(Me.TextBox_Login_Username)
        Me.Panel2.Controls.Add(Me.Button_Login)
        Me.Panel2.Location = New System.Drawing.Point(0, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(243, 272)
        Me.Panel2.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 7.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(43, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "USERNAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 7.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(43, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "PASSWORD"
        '
        'Label_Response_Login
        '
        Me.Label_Response_Login.AutoSize = True
        Me.Label_Response_Login.Font = New System.Drawing.Font("Nirmala UI", 7.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label_Response_Login.Location = New System.Drawing.Point(3, 52)
        Me.Label_Response_Login.Name = "Label_Response_Login"
        Me.Label_Response_Login.Size = New System.Drawing.Size(57, 13)
        Me.Label_Response_Login.TabIndex = 7
        Me.Label_Response_Login.Text = "Response"
        Me.Label_Response_Login.Visible = False
        '
        'TextBox_Login_Password
        '
        Me.TextBox_Login_Password.Location = New System.Drawing.Point(46, 156)
        Me.TextBox_Login_Password.Name = "TextBox_Login_Password"
        Me.TextBox_Login_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.TextBox_Login_Password.Size = New System.Drawing.Size(154, 20)
        Me.TextBox_Login_Password.TabIndex = 5
        '
        'TextBox_Login_Username
        '
        Me.TextBox_Login_Username.Location = New System.Drawing.Point(46, 103)
        Me.TextBox_Login_Username.Name = "TextBox_Login_Username"
        Me.TextBox_Login_Username.Size = New System.Drawing.Size(154, 20)
        Me.TextBox_Login_Username.TabIndex = 4
        '
        'Button_Login
        '
        Me.Button_Login.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Login.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Login.ForeColor = System.Drawing.Color.White
        Me.Button_Login.Location = New System.Drawing.Point(82, 186)
        Me.Button_Login.Name = "Button_Login"
        Me.Button_Login.Size = New System.Drawing.Size(89, 30)
        Me.Button_Login.TabIndex = 2
        Me.Button_Login.Text = "&Login"
        Me.Button_Login.UseVisualStyleBackColor = False
        '
        'promptLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Name = "promptLogin"
        Me.Size = New System.Drawing.Size(243, 272)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label_Response_Login As Label
    Friend WithEvents TextBox_Login_Password As TextBox
    Friend WithEvents TextBox_Login_Username As TextBox
    Friend WithEvents Button_Login As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
