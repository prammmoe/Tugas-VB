<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container
        Me.Lbl12jam = New System.Windows.Forms.Label
        Me.Lbl24jam = New System.Windows.Forms.Label
        Me.Dtanggal = New System.Windows.Forms.DateTimePicker
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Lbl12jam
        '
        Me.Lbl12jam.AutoSize = True
        Me.Lbl12jam.Location = New System.Drawing.Point(34, 40)
        Me.Lbl12jam.Name = "Lbl12jam"
        Me.Lbl12jam.Size = New System.Drawing.Size(39, 13)
        Me.Lbl12jam.TabIndex = 0
        Me.Lbl12jam.Text = "Label1"
        '
        'Lbl24jam
        '
        Me.Lbl24jam.AutoSize = True
        Me.Lbl24jam.Location = New System.Drawing.Point(34, 77)
        Me.Lbl24jam.Name = "Lbl24jam"
        Me.Lbl24jam.Size = New System.Drawing.Size(39, 13)
        Me.Lbl24jam.TabIndex = 1
        Me.Lbl24jam.Text = "Label2"
        '
        'Dtanggal
        '
        Me.Dtanggal.Location = New System.Drawing.Point(37, 127)
        Me.Dtanggal.Name = "Dtanggal"
        Me.Dtanggal.Size = New System.Drawing.Size(200, 20)
        Me.Dtanggal.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Dtanggal)
        Me.Controls.Add(Me.Lbl24jam)
        Me.Controls.Add(Me.Lbl12jam)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl12jam As System.Windows.Forms.Label
    Friend WithEvents Lbl24jam As System.Windows.Forms.Label
    Friend WithEvents Dtanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
