<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lstTask2 = New System.Windows.Forms.ListBox()
        Me.btnCompress = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.saveFD = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'lstTask2
        '
        Me.lstTask2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstTask2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTask2.FormattingEnabled = True
        Me.lstTask2.HorizontalScrollbar = True
        Me.lstTask2.IntegralHeight = False
        Me.lstTask2.ItemHeight = 16
        Me.lstTask2.Location = New System.Drawing.Point(8, 31)
        Me.lstTask2.Name = "lstTask2"
        Me.lstTask2.Size = New System.Drawing.Size(265, 251)
        Me.lstTask2.TabIndex = 0
        '
        'btnCompress
        '
        Me.btnCompress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCompress.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCompress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompress.Location = New System.Drawing.Point(8, 288)
        Me.btnCompress.Name = "btnCompress"
        Me.btnCompress.Size = New System.Drawing.Size(265, 42)
        Me.btnCompress.TabIndex = 2
        Me.btnCompress.Text = "&Compress a sentence:"
        Me.btnCompress.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(4, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(276, 24)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Task 2 Test - Text Compression"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCompress
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(283, 338)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnCompress)
        Me.Controls.Add(Me.lstTask2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Task 2 Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstTask2 As ListBox
    Friend WithEvents btnCompress As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents saveFD As SaveFileDialog
End Class
