<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Task1
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
        Me.mnuTask1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMainFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileLine = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlTask1 = New System.Windows.Forms.Panel()
        Me.lstTask1 = New System.Windows.Forms.ListBox()
        Me.btnSentence = New System.Windows.Forms.Button()
        Me.btnWord = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.mnuTask1.SuspendLayout()
        Me.pnlTask1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuTask1
        '
        Me.mnuTask1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.mnuTask1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMainFile})
        Me.mnuTask1.Location = New System.Drawing.Point(0, 0)
        Me.mnuTask1.Name = "mnuTask1"
        Me.mnuTask1.Size = New System.Drawing.Size(349, 24)
        Me.mnuTask1.TabIndex = 0
        Me.mnuTask1.Text = "mnuStripTask1"
        '
        'mnuMainFile
        '
        Me.mnuMainFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileReset, Me.mnuFileClear, Me.mnuFileLine, Me.mnuFileExit})
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
        'mnuFileClear
        '
        Me.mnuFileClear.Name = "mnuFileClear"
        Me.mnuFileClear.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuFileClear.Size = New System.Drawing.Size(175, 22)
        Me.mnuFileClear.Text = "&Clear"
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
        'pnlTask1
        '
        Me.pnlTask1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTask1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTask1.Controls.Add(Me.lstTask1)
        Me.pnlTask1.Controls.Add(Me.btnSentence)
        Me.pnlTask1.Controls.Add(Me.btnWord)
        Me.pnlTask1.Controls.Add(Me.lblTitle)
        Me.pnlTask1.Location = New System.Drawing.Point(2, 27)
        Me.pnlTask1.Name = "pnlTask1"
        Me.pnlTask1.Size = New System.Drawing.Size(346, 151)
        Me.pnlTask1.TabIndex = 1
        '
        'lstTask1
        '
        Me.lstTask1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstTask1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lstTask1.FormattingEnabled = True
        Me.lstTask1.HorizontalScrollbar = True
        Me.lstTask1.Location = New System.Drawing.Point(154, 32)
        Me.lstTask1.Name = "lstTask1"
        Me.lstTask1.Size = New System.Drawing.Size(184, 108)
        Me.lstTask1.TabIndex = 4
        '
        'btnSentence
        '
        Me.btnSentence.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSentence.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSentence.Location = New System.Drawing.Point(8, 30)
        Me.btnSentence.Name = "btnSentence"
        Me.btnSentence.Size = New System.Drawing.Size(142, 53)
        Me.btnSentence.TabIndex = 3
        Me.btnSentence.Text = "Enter a Sentence:"
        Me.btnSentence.UseVisualStyleBackColor = False
        '
        'btnWord
        '
        Me.btnWord.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnWord.Enabled = False
        Me.btnWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWord.Location = New System.Drawing.Point(8, 89)
        Me.btnWord.Name = "btnWord"
        Me.btnWord.Size = New System.Drawing.Size(142, 53)
        Me.btnWord.TabIndex = 2
        Me.btnWord.Text = "Check a Word:"
        Me.btnWord.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(1, 2)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(341, 25)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Task 1 - Word Positioning - Tom H"
        '
        'Task1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(349, 179)
        Me.Controls.Add(Me.pnlTask1)
        Me.Controls.Add(Me.mnuTask1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainMenuStrip = Me.mnuTask1
        Me.Name = "Task1"
        Me.Text = "Task 1 - Program"
        Me.mnuTask1.ResumeLayout(False)
        Me.mnuTask1.PerformLayout()
        Me.pnlTask1.ResumeLayout(False)
        Me.pnlTask1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuTask1 As MenuStrip
    Friend WithEvents mnuMainFile As ToolStripMenuItem
    Friend WithEvents mnuFileReset As ToolStripMenuItem
    Friend WithEvents mnuFileClear As ToolStripMenuItem
    Friend WithEvents mnuFileLine As ToolStripSeparator
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents pnlTask1 As Panel
    Friend WithEvents btnSentence As Button
    Friend WithEvents btnWord As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lstTask1 As ListBox
End Class
