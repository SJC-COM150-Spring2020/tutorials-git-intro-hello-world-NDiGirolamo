<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HelloWorld
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
        Me.btnpress = New System.Windows.Forms.Button()
        Me.lsthello = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnpress
        '
        Me.btnpress.BackColor = System.Drawing.Color.Navy
        Me.btnpress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpress.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpress.ForeColor = System.Drawing.Color.Gold
        Me.btnpress.Location = New System.Drawing.Point(134, 76)
        Me.btnpress.Name = "btnpress"
        Me.btnpress.Size = New System.Drawing.Size(165, 134)
        Me.btnpress.TabIndex = 0
        Me.btnpress.Text = "Press Me!"
        Me.btnpress.UseVisualStyleBackColor = False
        '
        'lsthello
        '
        Me.lsthello.BackColor = System.Drawing.Color.Cornsilk
        Me.lsthello.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsthello.Font = New System.Drawing.Font("Forte", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsthello.FormattingEnabled = True
        Me.lsthello.ItemHeight = 21
        Me.lsthello.Location = New System.Drawing.Point(134, 245)
        Me.lsthello.Name = "lsthello"
        Me.lsthello.Size = New System.Drawing.Size(165, 84)
        Me.lsthello.TabIndex = 1
        '
        'HelloWorld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(434, 411)
        Me.Controls.Add(Me.lsthello)
        Me.Controls.Add(Me.btnpress)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "HelloWorld"
        Me.Text = "Hello"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnpress As Button
    Friend WithEvents lsthello As ListBox
End Class
