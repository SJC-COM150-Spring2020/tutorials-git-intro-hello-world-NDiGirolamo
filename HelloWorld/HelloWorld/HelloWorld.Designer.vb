﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelloWorld
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.btnpress = New System.Windows.Forms.Button()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnpress
        '
        Me.btnpress.BackColor = System.Drawing.Color.Navy
        Me.btnpress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpress.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpress.ForeColor = System.Drawing.Color.Gold
        Me.btnpress.Location = New System.Drawing.Point(103, 61)
        Me.btnpress.Name = "btnpress"
        Me.btnpress.Size = New System.Drawing.Size(165, 134)
        Me.btnpress.TabIndex = 0
        Me.btnpress.Text = "Press Me!"
        Me.btnpress.UseVisualStyleBackColor = False
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.White
        Me.txtname.Font = New System.Drawing.Font("Ravie", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(103, 222)
        Me.txtname.MaxLength = 256
        Me.txtname.Multiline = True
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(165, 71)
        Me.txtname.TabIndex = 1
        '
        'HelloWorld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.btnpress)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "HelloWorld"
        Me.Text = "Hello"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnpress As Button
    Friend WithEvents txtname As TextBox
End Class
