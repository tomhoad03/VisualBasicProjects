<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Excercises
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
        Me.pnlBackground = New System.Windows.Forms.Panel()
        Me.lblCMajor = New System.Windows.Forms.Label()
        Me.btnCMajor = New System.Windows.Forms.Button()
        Me.lblVocalist = New System.Windows.Forms.Label()
        Me.btnVocalist = New System.Windows.Forms.Button()
        Me.lblVowels = New System.Windows.Forms.Label()
        Me.btnVowel = New System.Windows.Forms.Button()
        Me.lstExercises = New System.Windows.Forms.ListBox()
        Me.lblConsecutive = New System.Windows.Forms.Label()
        Me.btnConsecutive = New System.Windows.Forms.Button()
        Me.lblManU = New System.Windows.Forms.Label()
        Me.btnManU = New System.Windows.Forms.Button()
        Me.pnlBackground.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBackground
        '
        Me.pnlBackground.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBackground.Controls.Add(Me.btnManU)
        Me.pnlBackground.Controls.Add(Me.lblManU)
        Me.pnlBackground.Controls.Add(Me.btnConsecutive)
        Me.pnlBackground.Controls.Add(Me.lblConsecutive)
        Me.pnlBackground.Controls.Add(Me.lstExercises)
        Me.pnlBackground.Controls.Add(Me.btnVowel)
        Me.pnlBackground.Controls.Add(Me.lblVowels)
        Me.pnlBackground.Controls.Add(Me.btnVocalist)
        Me.pnlBackground.Controls.Add(Me.lblVocalist)
        Me.pnlBackground.Controls.Add(Me.btnCMajor)
        Me.pnlBackground.Controls.Add(Me.lblCMajor)
        Me.pnlBackground.Location = New System.Drawing.Point(3, 3)
        Me.pnlBackground.Name = "pnlBackground"
        Me.pnlBackground.Size = New System.Drawing.Size(487, 247)
        Me.pnlBackground.TabIndex = 0
        '
        'lblCMajor
        '
        Me.lblCMajor.AutoSize = True
        Me.lblCMajor.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCMajor.Location = New System.Drawing.Point(3, 5)
        Me.lblCMajor.Name = "lblCMajor"
        Me.lblCMajor.Size = New System.Drawing.Size(78, 22)
        Me.lblCMajor.TabIndex = 0
        Me.lblCMajor.Text = "C Major:"
        '
        'btnCMajor
        '
        Me.btnCMajor.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCMajor.Location = New System.Drawing.Point(3, 30)
        Me.btnCMajor.Name = "btnCMajor"
        Me.btnCMajor.Size = New System.Drawing.Size(129, 34)
        Me.btnCMajor.TabIndex = 1
        Me.btnCMajor.Text = "Go!"
        Me.btnCMajor.UseVisualStyleBackColor = True
        '
        'lblVocalist
        '
        Me.lblVocalist.AutoSize = True
        Me.lblVocalist.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVocalist.Location = New System.Drawing.Point(147, 5)
        Me.lblVocalist.Name = "lblVocalist"
        Me.lblVocalist.Size = New System.Drawing.Size(153, 22)
        Me.lblVocalist.TabIndex = 2
        Me.lblVocalist.Text = "Vocalist's Gender:"
        '
        'btnVocalist
        '
        Me.btnVocalist.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVocalist.Location = New System.Drawing.Point(151, 30)
        Me.btnVocalist.Name = "btnVocalist"
        Me.btnVocalist.Size = New System.Drawing.Size(129, 34)
        Me.btnVocalist.TabIndex = 3
        Me.btnVocalist.Text = "Go!"
        Me.btnVocalist.UseVisualStyleBackColor = True
        '
        'lblVowels
        '
        Me.lblVowels.AutoSize = True
        Me.lblVowels.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVowels.Location = New System.Drawing.Point(3, 67)
        Me.lblVowels.Name = "lblVowels"
        Me.lblVowels.Size = New System.Drawing.Size(139, 22)
        Me.lblVowels.TabIndex = 4
        Me.lblVowels.Text = "Vowel Removal:"
        '
        'btnVowel
        '
        Me.btnVowel.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVowel.Location = New System.Drawing.Point(3, 92)
        Me.btnVowel.Name = "btnVowel"
        Me.btnVowel.Size = New System.Drawing.Size(129, 34)
        Me.btnVowel.TabIndex = 5
        Me.btnVowel.Text = "Go!"
        Me.btnVowel.UseVisualStyleBackColor = True
        '
        'lstExercises
        '
        Me.lstExercises.FormattingEnabled = True
        Me.lstExercises.ItemHeight = 15
        Me.lstExercises.Location = New System.Drawing.Point(305, 8)
        Me.lstExercises.Name = "lstExercises"
        Me.lstExercises.Size = New System.Drawing.Size(171, 229)
        Me.lstExercises.TabIndex = 1
        '
        'lblConsecutive
        '
        Me.lblConsecutive.AutoSize = True
        Me.lblConsecutive.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsecutive.Location = New System.Drawing.Point(147, 67)
        Me.lblConsecutive.Name = "lblConsecutive"
        Me.lblConsecutive.Size = New System.Drawing.Size(113, 22)
        Me.lblConsecutive.TabIndex = 6
        Me.lblConsecutive.Text = "Consecutive:"
        '
        'btnConsecutive
        '
        Me.btnConsecutive.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsecutive.Location = New System.Drawing.Point(151, 92)
        Me.btnConsecutive.Name = "btnConsecutive"
        Me.btnConsecutive.Size = New System.Drawing.Size(129, 34)
        Me.btnConsecutive.TabIndex = 7
        Me.btnConsecutive.Text = "Go!"
        Me.btnConsecutive.UseVisualStyleBackColor = True
        '
        'lblManU
        '
        Me.lblManU.AutoSize = True
        Me.lblManU.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManU.Location = New System.Drawing.Point(3, 129)
        Me.lblManU.Name = "lblManU"
        Me.lblManU.Size = New System.Drawing.Size(113, 22)
        Me.lblManU.TabIndex = 8
        Me.lblManU.Text = "Man. United:"
        '
        'btnManU
        '
        Me.btnManU.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManU.Location = New System.Drawing.Point(3, 154)
        Me.btnManU.Name = "btnManU"
        Me.btnManU.Size = New System.Drawing.Size(129, 34)
        Me.btnManU.TabIndex = 9
        Me.btnManU.Text = "Go!"
        Me.btnManU.UseVisualStyleBackColor = True
        '
        'Excercises
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 253)
        Me.Controls.Add(Me.pnlBackground)
        Me.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Excercises"
        Me.Text = "Excercises"
        Me.pnlBackground.ResumeLayout(False)
        Me.pnlBackground.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBackground As Panel
    Friend WithEvents btnCMajor As Button
    Friend WithEvents lblCMajor As Label
    Friend WithEvents lblVocalist As Label
    Friend WithEvents btnVocalist As Button
    Friend WithEvents lblVowels As Label
    Friend WithEvents btnVowel As Button
    Friend WithEvents lstExercises As ListBox
    Friend WithEvents lblConsecutive As Label
    Friend WithEvents btnConsecutive As Button
    Friend WithEvents lblManU As Label
    Friend WithEvents btnManU As Button
End Class
