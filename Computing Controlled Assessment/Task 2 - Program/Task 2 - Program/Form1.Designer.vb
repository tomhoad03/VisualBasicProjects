<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Task2
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
        Me.pnlTask2 = New System.Windows.Forms.Panel()
        Me.btnCompress = New System.Windows.Forms.Button()
        Me.lstTask2 = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.mnuStripTask2 = New System.Windows.Forms.MenuStrip()
        Me.mnuMainFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileLine = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveFD = New System.Windows.Forms.SaveFileDialog()
        Me.pnlTask2.SuspendLayout()
        Me.mnuStripTask2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTask2
        '
        Me.pnlTask2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTask2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTask2.Controls.Add(Me.btnCompress)
        Me.pnlTask2.Controls.Add(Me.lstTask2)
        Me.pnlTask2.Controls.Add(Me.lblTitle)
        Me.pnlTask2.Location = New System.Drawing.Point(3, 29)
        Me.pnlTask2.Name = "pnlTask2"
        Me.pnlTask2.Size = New System.Drawing.Size(349, 260)
        Me.pnlTask2.TabIndex = 0
        '
        'btnCompress
        '
        Me.btnCompress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCompress.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCompress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompress.Location = New System.Drawing.Point(4, 215)
        Me.btnCompress.Name = "btnCompress"
        Me.btnCompress.Size = New System.Drawing.Size(337, 38)
        Me.btnCompress.TabIndex = 5
        Me.btnCompress.Text = "&Compress the text:"
        Me.btnCompress.UseVisualStyleBackColor = False
        '
        'lstTask2
        '
        Me.lstTask2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstTask2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTask2.FormattingEnabled = True
        Me.lstTask2.HorizontalExtent = 999999
        Me.lstTask2.HorizontalScrollbar = True
        Me.lstTask2.ItemHeight = 15
        Me.lstTask2.Location = New System.Drawing.Point(4, 29)
        Me.lstTask2.MultiColumn = True
        Me.lstTask2.Name = "lstTask2"
        Me.lstTask2.Size = New System.Drawing.Size(337, 184)
        Me.lstTask2.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(-1, 1)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(346, 25)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Task 2 -Text Compression - Tom H"
        '
        'mnuStripTask2
        '
        Me.mnuStripTask2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMainFile})
        Me.mnuStripTask2.Location = New System.Drawing.Point(0, 0)
        Me.mnuStripTask2.Name = "mnuStripTask2"
        Me.mnuStripTask2.Size = New System.Drawing.Size(354, 24)
        Me.mnuStripTask2.TabIndex = 1
        Me.mnuStripTask2.Text = "MenuStrip1"
        '
        'mnuMainFile
        '
        Me.mnuMainFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileReset, Me.mnuFileLine, Me.mnuFileExit})
        Me.mnuMainFile.Name = "mnuMainFile"
        Me.mnuMainFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuMainFile.Text = "File"
        '
        'mnuFileReset
        '
        Me.mnuFileReset.Name = "mnuFileReset"
        Me.mnuFileReset.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuFileReset.Size = New System.Drawing.Size(175, 22)
        Me.mnuFileReset.Text = "&Reset"
        '
        'mnuFileLine
        '
        Me.mnuFileLine.Name = "mnuFileLine"
        Me.mnuFileLine.Size = New System.Drawing.Size(172, 6)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(175, 22)
        Me.mnuFileExit.Text = "&Exit"
        '
        'Task2
        '
        Me.AcceptButton = Me.btnCompress
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(354, 291)
        Me.Controls.Add(Me.pnlTask2)
        Me.Controls.Add(Me.mnuStripTask2)
        Me.Name = "Task2"
        Me.Text = "Task 2 - Program"
        Me.pnlTask2.ResumeLayout(False)
        Me.pnlTask2.PerformLayout()
        Me.mnuStripTask2.ResumeLayout(False)
        Me.mnuStripTask2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTask2 As System.Windows.Forms.Panel
    Friend WithEvents mnuStripTask2 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMainFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileReset As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileLine As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstTask2 As System.Windows.Forms.ListBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnCompress As System.Windows.Forms.Button
    Friend WithEvents saveFD As System.Windows.Forms.SaveFileDialog

End Class
