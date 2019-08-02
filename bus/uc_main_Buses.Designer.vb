<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_main_Buses
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonNewBus = New System.Windows.Forms.Button()
        Me.Uc_main_Buses_Add1 = New bus.uc_main_Buses_Add()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.Uc_main_Buses_Add1)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(911, 434)
        Me.Panel3.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(88, 47)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(766, 387)
        Me.DataGridView1.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.ButtonNewBus)
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
        Me.Label2.Location = New System.Drawing.Point(40, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BUSES"
        '
        'ButtonNewBus
        '
        Me.ButtonNewBus.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonNewBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNewBus.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNewBus.ForeColor = System.Drawing.Color.White
        Me.ButtonNewBus.Location = New System.Drawing.Point(773, 8)
        Me.ButtonNewBus.Name = "ButtonNewBus"
        Me.ButtonNewBus.Size = New System.Drawing.Size(119, 33)
        Me.ButtonNewBus.TabIndex = 0
        Me.ButtonNewBus.Text = "NEW BUS"
        Me.ButtonNewBus.UseVisualStyleBackColor = True
        '
        'Uc_main_Buses_Add1
        '
        Me.Uc_main_Buses_Add1.Location = New System.Drawing.Point(171, 54)
        Me.Uc_main_Buses_Add1.Name = "Uc_main_Buses_Add1"
        Me.Uc_main_Buses_Add1.Size = New System.Drawing.Size(603, 358)
        Me.Uc_main_Buses_Add1.TabIndex = 1
        '
        'uc_main_Buses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Name = "uc_main_Buses"
        Me.Size = New System.Drawing.Size(911, 434)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonNewBus As Button
    Friend WithEvents Uc_main_Buses_Add1 As uc_main_Buses_Add
    Friend WithEvents DataGridView1 As DataGridView
End Class
