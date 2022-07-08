<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.create_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.label1.Location = New System.Drawing.Point(27, 40)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(281, 26)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Generate your resume now!"
        '
        'create_button
        '
        Me.create_button.Location = New System.Drawing.Point(111, 122)
        Me.create_button.Name = "create_button"
        Me.create_button.Size = New System.Drawing.Size(114, 43)
        Me.create_button.TabIndex = 2
        Me.create_button.Text = "Create File"
        Me.create_button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 212)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.create_button)
        Me.Name = "Form1"
        Me.Text = "Resume Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label1 As Label
    Private WithEvents create_button As Button
End Class
