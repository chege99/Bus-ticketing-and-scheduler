<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_login_response = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox_Exit = New System.Windows.Forms.PictureBox()
        Me.PromptLogin1 = New bus.promptLogin()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox_Exit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label_login_response)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox_Exit)
        Me.Panel1.Controls.Add(Me.PromptLogin1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(494, 446)
        Me.Panel1.TabIndex = 0
        '
        'Label_login_response
        '
        Me.Label_login_response.AutoSize = True
        Me.Label_login_response.Location = New System.Drawing.Point(23, 397)
        Me.Label_login_response.Name = "Label_login_response"
        Me.Label_login_response.Size = New System.Drawing.Size(0, 13)
        Me.Label_login_response.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("PMingLiU-ExtB", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(119, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 27)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "TAHMEED BUS SACCO"
        '
        'PictureBox_Exit
        '
        Me.PictureBox_Exit.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox_Exit.Image = CType(resources.GetObject("PictureBox_Exit.Image"), System.Drawing.Image)
        Me.PictureBox_Exit.Location = New System.Drawing.Point(455, 12)
        Me.PictureBox_Exit.Name = "PictureBox_Exit"
        Me.PictureBox_Exit.Size = New System.Drawing.Size(27, 27)
        Me.PictureBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Exit.TabIndex = 12
        Me.PictureBox_Exit.TabStop = False
        '
        'PromptLogin1
        '
        Me.PromptLogin1.Location = New System.Drawing.Point(135, 94)
        Me.PromptLogin1.Name = "PromptLogin1"
        Me.PromptLogin1.Size = New System.Drawing.Size(243, 272)
        Me.PromptLogin1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(292, 386)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 446)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(494, 446)
        Me.MinimumSize = New System.Drawing.Size(494, 446)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox_Exit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PromptLogin1 As promptLogin
    Friend WithEvents PictureBox_Exit As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_login_response As Label
    Friend WithEvents Button1 As Button
End Class
