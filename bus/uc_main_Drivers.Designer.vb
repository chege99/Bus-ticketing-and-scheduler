﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_main_Drivers
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
        Me.ButtonNewDriver = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Uc_main_Drivers_Add1 = New bus.uc_main_Drivers_Add()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonNewDriver
        '
        Me.ButtonNewDriver.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonNewDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNewDriver.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNewDriver.ForeColor = System.Drawing.Color.White
        Me.ButtonNewDriver.Location = New System.Drawing.Point(773, 8)
        Me.ButtonNewDriver.Name = "ButtonNewDriver"
        Me.ButtonNewDriver.Size = New System.Drawing.Size(119, 33)
        Me.ButtonNewDriver.TabIndex = 0
        Me.ButtonNewDriver.Text = "NEW DRIVER"
        Me.ButtonNewDriver.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.Uc_main_Drivers_Add1)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(911, 462)
        Me.Panel3.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(59, 47)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(806, 415)
        Me.DataGridView1.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.ButtonNewDriver)
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
        Me.Label2.Size = New System.Drawing.Size(115, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DRIVERS"
        '
        'Uc_main_Drivers_Add1
        '
        Me.Uc_main_Drivers_Add1.Location = New System.Drawing.Point(134, 54)
        Me.Uc_main_Drivers_Add1.Name = "Uc_main_Drivers_Add1"
        Me.Uc_main_Drivers_Add1.Size = New System.Drawing.Size(603, 400)
        Me.Uc_main_Drivers_Add1.TabIndex = 1
        '
        'uc_main_Drivers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Name = "uc_main_Drivers"
        Me.Size = New System.Drawing.Size(911, 465)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonNewDriver As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Uc_main_Drivers_Add1 As uc_main_Drivers_Add
    Friend WithEvents DataGridView1 As DataGridView
End Class
