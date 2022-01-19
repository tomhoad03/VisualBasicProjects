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
        Me.lstTask3 = New System.Windows.Forms.ListBox()
        Me.btnCompress = New System.Windows.Forms.Button()
        Me.btnDecompress = New System.Windows.Forms.Button()
        Me.openFD = New System.Windows.Forms.OpenFileDialog()
        Me.saveFD = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'lstTask3
        '
        Me.lstTask3.FormattingEnabled = True
        Me.lstTask3.Location = New System.Drawing.Point(12, 12)
        Me.lstTask3.Name = "lstTask3"
        Me.lstTask3.Size = New System.Drawing.Size(486, 264)
        Me.lstTask3.TabIndex = 0
        '
        'btnCompress
        '
        Me.btnCompress.Location = New System.Drawing.Point(12, 282)
        Me.btnCompress.Name = "btnCompress"
        Me.btnCompress.Size = New System.Drawing.Size(240, 46)
        Me.btnCompress.TabIndex = 1
        Me.btnCompress.Text = "Compress a text file:"
        Me.btnCompress.UseVisualStyleBackColor = True
        '
        'btnDecompress
        '
        Me.btnDecompress.Location = New System.Drawing.Point(258, 282)
        Me.btnDecompress.Name = "btnDecompress"
        Me.btnDecompress.Size = New System.Drawing.Size(240, 46)
        Me.btnDecompress.TabIndex = 2
        Me.btnDecompress.Text = "Decompress a text file:"
        Me.btnDecompress.UseVisualStyleBackColor = True
        '
        'openFD
        '
        Me.openFD.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 335)
        Me.Controls.Add(Me.btnDecompress)
        Me.Controls.Add(Me.btnCompress)
        Me.Controls.Add(Me.lstTask3)
        Me.Name = "Form1"
        Me.Text = "Task 3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstTask3 As ListBox
    Friend WithEvents btnCompress As Button
    Friend WithEvents btnDecompress As Button
    Friend WithEvents openFD As OpenFileDialog
    Friend WithEvents saveFD As SaveFileDialog
End Class
