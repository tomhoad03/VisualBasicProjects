<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Task3
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
        Me.mnuTask3 = New System.Windows.Forms.MenuStrip()
        Me.mnuMainFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlTask3 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlCompress = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCompress = New System.Windows.Forms.Button()
        Me.pnlText = New System.Windows.Forms.Panel()
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.txtRead = New System.Windows.Forms.TextBox()
        Me.lstTask3 = New System.Windows.Forms.ListBox()
        Me.pnlDecompress = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnDecompress = New System.Windows.Forms.Button()
        Me.saveFD = New System.Windows.Forms.SaveFileDialog()
        Me.openFD = New System.Windows.Forms.OpenFileDialog()
        Me.mnuTask3.SuspendLayout()
        Me.pnlTask3.SuspendLayout()
        Me.pnlCompress.SuspendLayout()
        Me.pnlText.SuspendLayout()
        Me.pnlDecompress.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuTask3
        '
        Me.mnuTask3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMainFile})
        Me.mnuTask3.Location = New System.Drawing.Point(0, 0)
        Me.mnuTask3.Name = "mnuTask3"
        Me.mnuTask3.Size = New System.Drawing.Size(554, 24)
        Me.mnuTask3.TabIndex = 0
        '
        'mnuMainFile
        '
        Me.mnuMainFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileClear, Me.ToolStripMenuItem1, Me.mnuFileExit})
        Me.mnuMainFile.Name = "mnuMainFile"
        Me.mnuMainFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuMainFile.Text = "&File"
        '
        'mnuFileClear
        '
        Me.mnuFileClear.Name = "mnuFileClear"
        Me.mnuFileClear.Size = New System.Drawing.Size(101, 22)
        Me.mnuFileClear.Text = "&Clear"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(98, 6)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(101, 22)
        Me.mnuFileExit.Text = "&Exit"
        '
        'pnlTask3
        '
        Me.pnlTask3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTask3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTask3.Controls.Add(Me.lblTitle)
        Me.pnlTask3.Controls.Add(Me.pnlCompress)
        Me.pnlTask3.Controls.Add(Me.pnlText)
        Me.pnlTask3.Controls.Add(Me.lstTask3)
        Me.pnlTask3.Controls.Add(Me.pnlDecompress)
        Me.pnlTask3.Location = New System.Drawing.Point(2, 27)
        Me.pnlTask3.Name = "pnlTask3"
        Me.pnlTask3.Size = New System.Drawing.Size(550, 562)
        Me.pnlTask3.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(3, 2)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(302, 29)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Task 3 - Text Compression"
        '
        'pnlCompress
        '
        Me.pnlCompress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCompress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCompress.Controls.Add(Me.btnSave)
        Me.pnlCompress.Controls.Add(Me.btnCompress)
        Me.pnlCompress.Location = New System.Drawing.Point(3, 440)
        Me.pnlCompress.Name = "pnlCompress"
        Me.pnlCompress.Size = New System.Drawing.Size(268, 115)
        Me.pnlCompress.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(3, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(258, 51)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save a text file:"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCompress
        '
        Me.btnCompress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCompress.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCompress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompress.Location = New System.Drawing.Point(3, 57)
        Me.btnCompress.Name = "btnCompress"
        Me.btnCompress.Size = New System.Drawing.Size(258, 51)
        Me.btnCompress.TabIndex = 5
        Me.btnCompress.Text = "Compress the file:"
        Me.btnCompress.UseVisualStyleBackColor = False
        '
        'pnlText
        '
        Me.pnlText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlText.Controls.Add(Me.lblEnter)
        Me.pnlText.Controls.Add(Me.txtRead)
        Me.pnlText.Location = New System.Drawing.Point(3, 334)
        Me.pnlText.Name = "pnlText"
        Me.pnlText.Size = New System.Drawing.Size(540, 103)
        Me.pnlText.TabIndex = 4
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnter.Location = New System.Drawing.Point(3, 0)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(264, 18)
        Me.lblEnter.TabIndex = 5
        Me.lblEnter.Text = "Enter your text here to be compressed:"
        '
        'txtRead
        '
        Me.txtRead.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRead.Location = New System.Drawing.Point(3, 21)
        Me.txtRead.Multiline = True
        Me.txtRead.Name = "txtRead"
        Me.txtRead.Size = New System.Drawing.Size(530, 75)
        Me.txtRead.TabIndex = 2
        '
        'lstTask3
        '
        Me.lstTask3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstTask3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTask3.FormattingEnabled = True
        Me.lstTask3.HorizontalScrollbar = True
        Me.lstTask3.IntegralHeight = False
        Me.lstTask3.ItemHeight = 18
        Me.lstTask3.Location = New System.Drawing.Point(3, 33)
        Me.lstTask3.Name = "lstTask3"
        Me.lstTask3.Size = New System.Drawing.Size(540, 299)
        Me.lstTask3.TabIndex = 3
        '
        'pnlDecompress
        '
        Me.pnlDecompress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDecompress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDecompress.Controls.Add(Me.Panel1)
        Me.pnlDecompress.Controls.Add(Me.btnSelect)
        Me.pnlDecompress.Controls.Add(Me.btnDecompress)
        Me.pnlDecompress.Location = New System.Drawing.Point(277, 440)
        Me.pnlDecompress.Name = "pnlDecompress"
        Me.pnlDecompress.Size = New System.Drawing.Size(268, 115)
        Me.pnlDecompress.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(-2, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(268, 115)
        Me.Panel1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(258, 51)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Select a compressed file:"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(3, 57)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(258, 51)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Decompress the file:"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnSelect
        '
        Me.btnSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelect.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(3, 3)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(258, 51)
        Me.btnSelect.TabIndex = 6
        Me.btnSelect.Text = "Select a compressed file:"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'btnDecompress
        '
        Me.btnDecompress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDecompress.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDecompress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecompress.Location = New System.Drawing.Point(3, 57)
        Me.btnDecompress.Name = "btnDecompress"
        Me.btnDecompress.Size = New System.Drawing.Size(258, 51)
        Me.btnDecompress.TabIndex = 6
        Me.btnDecompress.Text = "Decompress the file:"
        Me.btnDecompress.UseVisualStyleBackColor = False
        '
        'openFD
        '
        Me.openFD.FileName = "OpenFileDialog1"
        '
        'Task3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(554, 591)
        Me.Controls.Add(Me.mnuTask3)
        Me.Controls.Add(Me.pnlTask3)
        Me.MainMenuStrip = Me.mnuTask3
        Me.Name = "Task3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Task 3"
        Me.mnuTask3.ResumeLayout(False)
        Me.mnuTask3.PerformLayout()
        Me.pnlTask3.ResumeLayout(False)
        Me.pnlTask3.PerformLayout()
        Me.pnlCompress.ResumeLayout(False)
        Me.pnlText.ResumeLayout(False)
        Me.pnlText.PerformLayout()
        Me.pnlDecompress.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuTask3 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMainFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlTask3 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lstTask3 As System.Windows.Forms.ListBox
    Friend WithEvents btnCompress As System.Windows.Forms.Button
    Friend WithEvents btnDecompress As System.Windows.Forms.Button
    Friend WithEvents pnlDecompress As System.Windows.Forms.Panel
    Friend WithEvents pnlCompress As System.Windows.Forms.Panel
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents saveFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents openFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pnlText As Panel
    Friend WithEvents txtRead As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents lblEnter As Label
End Class
