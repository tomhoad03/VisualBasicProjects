<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hangman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hangman))
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuMainFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileStrip = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuMainExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainCategories = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCategoriesFood = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCategoriesSport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCategoriesCountries = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpCenter = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlBackground = New System.Windows.Forms.Panel()
        Me.picHangman = New System.Windows.Forms.PictureBox()
        Me.pnlUnderscores = New System.Windows.Forms.Panel()
        Me.lblUnderscores = New System.Windows.Forms.Label()
        Me.pnlAlphabet = New System.Windows.Forms.Panel()
        Me.lblz = New System.Windows.Forms.Label()
        Me.lbly = New System.Windows.Forms.Label()
        Me.lblx = New System.Windows.Forms.Label()
        Me.lblw = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblv = New System.Windows.Forms.Label()
        Me.lblu = New System.Windows.Forms.Label()
        Me.lblt = New System.Windows.Forms.Label()
        Me.lbls = New System.Windows.Forms.Label()
        Me.lblr = New System.Windows.Forms.Label()
        Me.lblq = New System.Windows.Forms.Label()
        Me.lblp = New System.Windows.Forms.Label()
        Me.lblo = New System.Windows.Forms.Label()
        Me.lbln = New System.Windows.Forms.Label()
        Me.lblm = New System.Windows.Forms.Label()
        Me.lbll = New System.Windows.Forms.Label()
        Me.lblk = New System.Windows.Forms.Label()
        Me.lblj = New System.Windows.Forms.Label()
        Me.lbli = New System.Windows.Forms.Label()
        Me.lblh = New System.Windows.Forms.Label()
        Me.lblg = New System.Windows.Forms.Label()
        Me.lblf = New System.Windows.Forms.Label()
        Me.lble = New System.Windows.Forms.Label()
        Me.lbld = New System.Windows.Forms.Label()
        Me.lblc = New System.Windows.Forms.Label()
        Me.lblb = New System.Windows.Forms.Label()
        Me.lbla = New System.Windows.Forms.Label()
        Me.pnlStatus = New System.Windows.Forms.Panel()
        Me.comboCategories = New System.Windows.Forms.ComboBox()
        Me.lblLivesCount = New System.Windows.Forms.Label()
        Me.lblLettersCount = New System.Windows.Forms.Label()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblLettersLeft = New System.Windows.Forms.Label()
        Me.txtLetter = New System.Windows.Forms.TextBox()
        Me.pnlEnter = New System.Windows.Forms.Panel()
        Me.lblEnterLetter = New System.Windows.Forms.Label()
        Me.pnlGuess = New System.Windows.Forms.Panel()
        Me.btnGuessWord = New System.Windows.Forms.Button()
        Me.btnGuessLetter = New System.Windows.Forms.Button()
        Me.mnuStrip.SuspendLayout()
        Me.pnlBackground.SuspendLayout()
        CType(Me.picHangman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUnderscores.SuspendLayout()
        Me.pnlAlphabet.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.pnlEnter.SuspendLayout()
        Me.pnlGuess.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMainFile, Me.mnuMainCategories, Me.mnuMainHelp})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(525, 24)
        Me.mnuStrip.TabIndex = 0
        '
        'mnuMainFile
        '
        Me.mnuMainFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileDetails, Me.mnuFileReset, Me.mnuFileStrip, Me.mnuMainExit})
        Me.mnuMainFile.Name = "mnuMainFile"
        Me.mnuMainFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuMainFile.Text = "&File"
        '
        'mnuFileDetails
        '
        Me.mnuFileDetails.Name = "mnuFileDetails"
        Me.mnuFileDetails.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuFileDetails.Size = New System.Drawing.Size(151, 22)
        Me.mnuFileDetails.Text = "Details"
        '
        'mnuFileReset
        '
        Me.mnuFileReset.Name = "mnuFileReset"
        Me.mnuFileReset.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuFileReset.Size = New System.Drawing.Size(151, 22)
        Me.mnuFileReset.Text = "Reset"
        '
        'mnuFileStrip
        '
        Me.mnuFileStrip.Name = "mnuFileStrip"
        Me.mnuFileStrip.Size = New System.Drawing.Size(148, 6)
        '
        'mnuMainExit
        '
        Me.mnuMainExit.Name = "mnuMainExit"
        Me.mnuMainExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuMainExit.Size = New System.Drawing.Size(151, 22)
        Me.mnuMainExit.Text = "Exit"
        '
        'mnuMainCategories
        '
        Me.mnuMainCategories.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCategoriesFood, Me.mnuCategoriesSport, Me.mnuCategoriesCountries})
        Me.mnuMainCategories.Name = "mnuMainCategories"
        Me.mnuMainCategories.Size = New System.Drawing.Size(75, 20)
        Me.mnuMainCategories.Text = "&Categories"
        '
        'mnuCategoriesFood
        '
        Me.mnuCategoriesFood.CheckOnClick = True
        Me.mnuCategoriesFood.Name = "mnuCategoriesFood"
        Me.mnuCategoriesFood.Size = New System.Drawing.Size(125, 22)
        Me.mnuCategoriesFood.Text = "Food"
        '
        'mnuCategoriesSport
        '
        Me.mnuCategoriesSport.CheckOnClick = True
        Me.mnuCategoriesSport.Name = "mnuCategoriesSport"
        Me.mnuCategoriesSport.Size = New System.Drawing.Size(125, 22)
        Me.mnuCategoriesSport.Text = "Sport"
        '
        'mnuCategoriesCountries
        '
        Me.mnuCategoriesCountries.CheckOnClick = True
        Me.mnuCategoriesCountries.Name = "mnuCategoriesCountries"
        Me.mnuCategoriesCountries.Size = New System.Drawing.Size(125, 22)
        Me.mnuCategoriesCountries.Text = "Countries"
        '
        'mnuMainHelp
        '
        Me.mnuMainHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpCenter})
        Me.mnuMainHelp.Name = "mnuMainHelp"
        Me.mnuMainHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuMainHelp.Text = "&Help"
        '
        'mnuHelpCenter
        '
        Me.mnuHelpCenter.Name = "mnuHelpCenter"
        Me.mnuHelpCenter.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.mnuHelpCenter.Size = New System.Drawing.Size(180, 22)
        Me.mnuHelpCenter.Text = "Help Center"
        '
        'pnlBackground
        '
        Me.pnlBackground.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBackground.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBackground.Controls.Add(Me.picHangman)
        Me.pnlBackground.Controls.Add(Me.pnlUnderscores)
        Me.pnlBackground.Controls.Add(Me.pnlAlphabet)
        Me.pnlBackground.Controls.Add(Me.pnlStatus)
        Me.pnlBackground.Controls.Add(Me.txtLetter)
        Me.pnlBackground.Controls.Add(Me.pnlEnter)
        Me.pnlBackground.Controls.Add(Me.pnlGuess)
        Me.pnlBackground.Location = New System.Drawing.Point(5, 25)
        Me.pnlBackground.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlBackground.Name = "pnlBackground"
        Me.pnlBackground.Size = New System.Drawing.Size(515, 320)
        Me.pnlBackground.TabIndex = 1
        '
        'picHangman
        '
        Me.picHangman.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picHangman.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picHangman.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picHangman.Image = Global.Hangman.My.Resources.Resources._6_lives
        Me.picHangman.InitialImage = Nothing
        Me.picHangman.Location = New System.Drawing.Point(109, 132)
        Me.picHangman.Name = "picHangman"
        Me.picHangman.Size = New System.Drawing.Size(400, 181)
        Me.picHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHangman.TabIndex = 37
        Me.picHangman.TabStop = False
        '
        'pnlUnderscores
        '
        Me.pnlUnderscores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUnderscores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlUnderscores.Controls.Add(Me.lblUnderscores)
        Me.pnlUnderscores.Location = New System.Drawing.Point(107, 83)
        Me.pnlUnderscores.Name = "pnlUnderscores"
        Me.pnlUnderscores.Size = New System.Drawing.Size(400, 43)
        Me.pnlUnderscores.TabIndex = 36
        '
        'lblUnderscores
        '
        Me.lblUnderscores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUnderscores.AutoSize = True
        Me.lblUnderscores.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnderscores.Location = New System.Drawing.Point(4, 4)
        Me.lblUnderscores.Name = "lblUnderscores"
        Me.lblUnderscores.Size = New System.Drawing.Size(25, 32)
        Me.lblUnderscores.TabIndex = 4
        Me.lblUnderscores.Text = "_"
        Me.lblUnderscores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblUnderscores.Visible = False
        '
        'pnlAlphabet
        '
        Me.pnlAlphabet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlAlphabet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlAlphabet.Controls.Add(Me.lblz)
        Me.pnlAlphabet.Controls.Add(Me.lbly)
        Me.pnlAlphabet.Controls.Add(Me.lblx)
        Me.pnlAlphabet.Controls.Add(Me.lblw)
        Me.pnlAlphabet.Controls.Add(Me.Label23)
        Me.pnlAlphabet.Controls.Add(Me.Label22)
        Me.pnlAlphabet.Controls.Add(Me.lblv)
        Me.pnlAlphabet.Controls.Add(Me.lblu)
        Me.pnlAlphabet.Controls.Add(Me.lblt)
        Me.pnlAlphabet.Controls.Add(Me.lbls)
        Me.pnlAlphabet.Controls.Add(Me.lblr)
        Me.pnlAlphabet.Controls.Add(Me.lblq)
        Me.pnlAlphabet.Controls.Add(Me.lblp)
        Me.pnlAlphabet.Controls.Add(Me.lblo)
        Me.pnlAlphabet.Controls.Add(Me.lbln)
        Me.pnlAlphabet.Controls.Add(Me.lblm)
        Me.pnlAlphabet.Controls.Add(Me.lbll)
        Me.pnlAlphabet.Controls.Add(Me.lblk)
        Me.pnlAlphabet.Controls.Add(Me.lblj)
        Me.pnlAlphabet.Controls.Add(Me.lbli)
        Me.pnlAlphabet.Controls.Add(Me.lblh)
        Me.pnlAlphabet.Controls.Add(Me.lblg)
        Me.pnlAlphabet.Controls.Add(Me.lblf)
        Me.pnlAlphabet.Controls.Add(Me.lble)
        Me.pnlAlphabet.Controls.Add(Me.lbld)
        Me.pnlAlphabet.Controls.Add(Me.lblc)
        Me.pnlAlphabet.Controls.Add(Me.lblb)
        Me.pnlAlphabet.Controls.Add(Me.lbla)
        Me.pnlAlphabet.Location = New System.Drawing.Point(4, 83)
        Me.pnlAlphabet.Name = "pnlAlphabet"
        Me.pnlAlphabet.Size = New System.Drawing.Size(97, 230)
        Me.pnlAlphabet.TabIndex = 7
        '
        'lblz
        '
        Me.lblz.AutoSize = True
        Me.lblz.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblz.Location = New System.Drawing.Point(66, 179)
        Me.lblz.Name = "lblz"
        Me.lblz.Size = New System.Drawing.Size(23, 25)
        Me.lblz.TabIndex = 35
        Me.lblz.Text = "Z"
        '
        'lbly
        '
        Me.lbly.AutoSize = True
        Me.lbly.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbly.Location = New System.Drawing.Point(66, 154)
        Me.lbly.Name = "lbly"
        Me.lbly.Size = New System.Drawing.Size(24, 25)
        Me.lbly.TabIndex = 34
        Me.lbly.Text = "Y"
        '
        'lblx
        '
        Me.lblx.AutoSize = True
        Me.lblx.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblx.Location = New System.Drawing.Point(66, 129)
        Me.lblx.Name = "lblx"
        Me.lblx.Size = New System.Drawing.Size(24, 25)
        Me.lblx.TabIndex = 33
        Me.lblx.Text = "X"
        '
        'lblw
        '
        Me.lblw.AutoSize = True
        Me.lblw.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblw.Location = New System.Drawing.Point(63, 104)
        Me.lblw.Name = "lblw"
        Me.lblw.Size = New System.Drawing.Size(31, 25)
        Me.lblw.TabIndex = 32
        Me.lblw.Text = "W"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(66, 104)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(25, 25)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "A"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(66, 104)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(25, 25)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "A"
        '
        'lblv
        '
        Me.lblv.AutoSize = True
        Me.lblv.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblv.Location = New System.Drawing.Point(66, 79)
        Me.lblv.Name = "lblv"
        Me.lblv.Size = New System.Drawing.Size(25, 25)
        Me.lblv.TabIndex = 29
        Me.lblv.Text = "V"
        '
        'lblu
        '
        Me.lblu.AutoSize = True
        Me.lblu.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblu.Location = New System.Drawing.Point(66, 54)
        Me.lblu.Name = "lblu"
        Me.lblu.Size = New System.Drawing.Size(26, 25)
        Me.lblu.TabIndex = 28
        Me.lblu.Text = "U"
        '
        'lblt
        '
        Me.lblt.AutoSize = True
        Me.lblt.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblt.Location = New System.Drawing.Point(66, 29)
        Me.lblt.Name = "lblt"
        Me.lblt.Size = New System.Drawing.Size(24, 25)
        Me.lblt.TabIndex = 27
        Me.lblt.Text = "T"
        '
        'lbls
        '
        Me.lbls.AutoSize = True
        Me.lbls.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbls.Location = New System.Drawing.Point(66, 4)
        Me.lbls.Name = "lbls"
        Me.lbls.Size = New System.Drawing.Size(22, 25)
        Me.lbls.TabIndex = 26
        Me.lbls.Text = "S"
        '
        'lblr
        '
        Me.lblr.AutoSize = True
        Me.lblr.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblr.Location = New System.Drawing.Point(35, 201)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(25, 25)
        Me.lblr.TabIndex = 25
        Me.lblr.Text = "R"
        '
        'lblq
        '
        Me.lblq.AutoSize = True
        Me.lblq.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblq.Location = New System.Drawing.Point(35, 179)
        Me.lblq.Name = "lblq"
        Me.lblq.Size = New System.Drawing.Size(26, 25)
        Me.lblq.TabIndex = 24
        Me.lblq.Text = "Q"
        '
        'lblp
        '
        Me.lblp.AutoSize = True
        Me.lblp.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp.Location = New System.Drawing.Point(35, 154)
        Me.lblp.Name = "lblp"
        Me.lblp.Size = New System.Drawing.Size(24, 25)
        Me.lblp.TabIndex = 23
        Me.lblp.Text = "P"
        '
        'lblo
        '
        Me.lblo.AutoSize = True
        Me.lblo.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblo.Location = New System.Drawing.Point(35, 129)
        Me.lblo.Name = "lblo"
        Me.lblo.Size = New System.Drawing.Size(26, 25)
        Me.lblo.TabIndex = 22
        Me.lblo.Text = "O"
        '
        'lbln
        '
        Me.lbln.AutoSize = True
        Me.lbln.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbln.Location = New System.Drawing.Point(35, 104)
        Me.lbln.Name = "lbln"
        Me.lbln.Size = New System.Drawing.Size(26, 25)
        Me.lbln.TabIndex = 21
        Me.lbln.Text = "N"
        '
        'lblm
        '
        Me.lblm.AutoSize = True
        Me.lblm.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblm.Location = New System.Drawing.Point(35, 79)
        Me.lblm.Name = "lblm"
        Me.lblm.Size = New System.Drawing.Size(29, 25)
        Me.lblm.TabIndex = 20
        Me.lblm.Text = "M"
        '
        'lbll
        '
        Me.lbll.AutoSize = True
        Me.lbll.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbll.Location = New System.Drawing.Point(35, 54)
        Me.lbll.Name = "lbll"
        Me.lbll.Size = New System.Drawing.Size(23, 25)
        Me.lbll.TabIndex = 19
        Me.lbll.Text = "L"
        '
        'lblk
        '
        Me.lblk.AutoSize = True
        Me.lblk.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblk.Location = New System.Drawing.Point(35, 29)
        Me.lblk.Name = "lblk"
        Me.lblk.Size = New System.Drawing.Size(25, 25)
        Me.lblk.TabIndex = 18
        Me.lblk.Text = "K"
        '
        'lblj
        '
        Me.lblj.AutoSize = True
        Me.lblj.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblj.Location = New System.Drawing.Point(38, 4)
        Me.lblj.Name = "lblj"
        Me.lblj.Size = New System.Drawing.Size(18, 25)
        Me.lblj.TabIndex = 17
        Me.lblj.Text = "J"
        '
        'lbli
        '
        Me.lbli.AutoSize = True
        Me.lbli.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbli.Location = New System.Drawing.Point(7, 201)
        Me.lbli.Name = "lbli"
        Me.lbli.Size = New System.Drawing.Size(19, 25)
        Me.lbli.TabIndex = 16
        Me.lbli.Text = "I"
        '
        'lblh
        '
        Me.lblh.AutoSize = True
        Me.lblh.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblh.Location = New System.Drawing.Point(4, 179)
        Me.lblh.Name = "lblh"
        Me.lblh.Size = New System.Drawing.Size(26, 25)
        Me.lblh.TabIndex = 15
        Me.lblh.Text = "H"
        '
        'lblg
        '
        Me.lblg.AutoSize = True
        Me.lblg.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblg.Location = New System.Drawing.Point(4, 154)
        Me.lblg.Name = "lblg"
        Me.lblg.Size = New System.Drawing.Size(25, 25)
        Me.lblg.TabIndex = 14
        Me.lblg.Text = "G"
        '
        'lblf
        '
        Me.lblf.AutoSize = True
        Me.lblf.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblf.Location = New System.Drawing.Point(4, 129)
        Me.lblf.Name = "lblf"
        Me.lblf.Size = New System.Drawing.Size(23, 25)
        Me.lblf.TabIndex = 13
        Me.lblf.Text = "F"
        '
        'lble
        '
        Me.lble.AutoSize = True
        Me.lble.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lble.Location = New System.Drawing.Point(4, 104)
        Me.lble.Name = "lble"
        Me.lble.Size = New System.Drawing.Size(24, 25)
        Me.lble.TabIndex = 12
        Me.lble.Text = "E"
        '
        'lbld
        '
        Me.lbld.AutoSize = True
        Me.lbld.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbld.Location = New System.Drawing.Point(4, 79)
        Me.lbld.Name = "lbld"
        Me.lbld.Size = New System.Drawing.Size(26, 25)
        Me.lbld.TabIndex = 11
        Me.lbld.Text = "D"
        '
        'lblc
        '
        Me.lblc.AutoSize = True
        Me.lblc.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblc.Location = New System.Drawing.Point(4, 54)
        Me.lblc.Name = "lblc"
        Me.lblc.Size = New System.Drawing.Size(24, 25)
        Me.lblc.TabIndex = 10
        Me.lblc.Text = "C"
        '
        'lblb
        '
        Me.lblb.AutoSize = True
        Me.lblb.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblb.Location = New System.Drawing.Point(4, 29)
        Me.lblb.Name = "lblb"
        Me.lblb.Size = New System.Drawing.Size(25, 25)
        Me.lblb.TabIndex = 9
        Me.lblb.Text = "B"
        '
        'lbla
        '
        Me.lbla.AutoSize = True
        Me.lbla.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbla.Location = New System.Drawing.Point(4, 4)
        Me.lbla.Name = "lbla"
        Me.lbla.Size = New System.Drawing.Size(25, 25)
        Me.lbla.TabIndex = 8
        Me.lbla.Text = "A"
        '
        'pnlStatus
        '
        Me.pnlStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlStatus.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlStatus.Controls.Add(Me.comboCategories)
        Me.pnlStatus.Controls.Add(Me.lblLivesCount)
        Me.pnlStatus.Controls.Add(Me.lblLettersCount)
        Me.pnlStatus.Controls.Add(Me.lblLives)
        Me.pnlStatus.Controls.Add(Me.lblCategory)
        Me.pnlStatus.Controls.Add(Me.lblLettersLeft)
        Me.pnlStatus.Location = New System.Drawing.Point(300, 3)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(207, 76)
        Me.pnlStatus.TabIndex = 6
        '
        'comboCategories
        '
        Me.comboCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboCategories.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboCategories.FormattingEnabled = True
        Me.comboCategories.Items.AddRange(New Object() {"Food", "Sport", "Countries"})
        Me.comboCategories.Location = New System.Drawing.Point(79, 46)
        Me.comboCategories.Name = "comboCategories"
        Me.comboCategories.Size = New System.Drawing.Size(121, 23)
        Me.comboCategories.TabIndex = 9
        '
        'lblLivesCount
        '
        Me.lblLivesCount.AutoSize = True
        Me.lblLivesCount.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLivesCount.Location = New System.Drawing.Point(135, 4)
        Me.lblLivesCount.Name = "lblLivesCount"
        Me.lblLivesCount.Size = New System.Drawing.Size(18, 19)
        Me.lblLivesCount.TabIndex = 7
        Me.lblLivesCount.Text = "6"
        '
        'lblLettersCount
        '
        Me.lblLettersCount.AutoSize = True
        Me.lblLettersCount.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLettersCount.Location = New System.Drawing.Point(135, 24)
        Me.lblLettersCount.Name = "lblLettersCount"
        Me.lblLettersCount.Size = New System.Drawing.Size(18, 19)
        Me.lblLettersCount.TabIndex = 8
        Me.lblLettersCount.Text = "0"
        '
        'lblLives
        '
        Me.lblLives.AutoSize = True
        Me.lblLives.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLives.Location = New System.Drawing.Point(3, 3)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(49, 19)
        Me.lblLives.TabIndex = 2
        Me.lblLives.Text = "Lives:"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(3, 45)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(75, 19)
        Me.lblCategory.TabIndex = 3
        Me.lblCategory.Text = "Category:"
        '
        'lblLettersLeft
        '
        Me.lblLettersLeft.AutoSize = True
        Me.lblLettersLeft.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLettersLeft.Location = New System.Drawing.Point(3, 24)
        Me.lblLettersLeft.Name = "lblLettersLeft"
        Me.lblLettersLeft.Size = New System.Drawing.Size(93, 19)
        Me.lblLettersLeft.TabIndex = 4
        Me.lblLettersLeft.Text = "Letters Left:"
        '
        'txtLetter
        '
        Me.txtLetter.Font = New System.Drawing.Font("Cambria", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLetter.Location = New System.Drawing.Point(56, 30)
        Me.txtLetter.Multiline = True
        Me.txtLetter.Name = "txtLetter"
        Me.txtLetter.Size = New System.Drawing.Size(73, 43)
        Me.txtLetter.TabIndex = 3
        Me.txtLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlEnter
        '
        Me.pnlEnter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlEnter.Controls.Add(Me.lblEnterLetter)
        Me.pnlEnter.Location = New System.Drawing.Point(3, 4)
        Me.pnlEnter.Name = "pnlEnter"
        Me.pnlEnter.Size = New System.Drawing.Size(135, 75)
        Me.pnlEnter.TabIndex = 4
        '
        'lblEnterLetter
        '
        Me.lblEnterLetter.AutoSize = True
        Me.lblEnterLetter.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterLetter.Location = New System.Drawing.Point(3, 3)
        Me.lblEnterLetter.Name = "lblEnterLetter"
        Me.lblEnterLetter.Size = New System.Drawing.Size(125, 38)
        Me.lblEnterLetter.TabIndex = 2
        Me.lblEnterLetter.Text = "Enter your letter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "here:"
        '
        'pnlGuess
        '
        Me.pnlGuess.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGuess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGuess.Controls.Add(Me.btnGuessWord)
        Me.pnlGuess.Controls.Add(Me.btnGuessLetter)
        Me.pnlGuess.Location = New System.Drawing.Point(141, 4)
        Me.pnlGuess.Name = "pnlGuess"
        Me.pnlGuess.Size = New System.Drawing.Size(156, 75)
        Me.pnlGuess.TabIndex = 5
        '
        'btnGuessWord
        '
        Me.btnGuessWord.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuessWord.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuessWord.Location = New System.Drawing.Point(3, 37)
        Me.btnGuessWord.Name = "btnGuessWord"
        Me.btnGuessWord.Size = New System.Drawing.Size(146, 30)
        Me.btnGuessWord.TabIndex = 6
        Me.btnGuessWord.Text = "Guess a word!"
        Me.btnGuessWord.UseVisualStyleBackColor = True
        '
        'btnGuessLetter
        '
        Me.btnGuessLetter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuessLetter.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuessLetter.Location = New System.Drawing.Point(3, 3)
        Me.btnGuessLetter.Name = "btnGuessLetter"
        Me.btnGuessLetter.Size = New System.Drawing.Size(146, 30)
        Me.btnGuessLetter.TabIndex = 5
        Me.btnGuessLetter.Text = "Guess a letter!"
        Me.btnGuessLetter.UseVisualStyleBackColor = True
        '
        'Hangman
        '
        Me.AcceptButton = Me.btnGuessLetter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(525, 349)
        Me.Controls.Add(Me.mnuStrip)
        Me.Controls.Add(Me.pnlBackground)
        Me.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuStrip
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Hangman"
        Me.Text = "Hangman"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.pnlBackground.ResumeLayout(False)
        Me.pnlBackground.PerformLayout()
        CType(Me.picHangman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUnderscores.ResumeLayout(False)
        Me.pnlUnderscores.PerformLayout()
        Me.pnlAlphabet.ResumeLayout(False)
        Me.pnlAlphabet.PerformLayout()
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.pnlEnter.ResumeLayout(False)
        Me.pnlEnter.PerformLayout()
        Me.pnlGuess.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents mnuMainFile As ToolStripMenuItem
    Friend WithEvents mnuFileDetails As ToolStripMenuItem
    Friend WithEvents mnuFileReset As ToolStripMenuItem
    Friend WithEvents mnuFileStrip As ToolStripSeparator
    Friend WithEvents mnuMainExit As ToolStripMenuItem
    Friend WithEvents mnuMainCategories As ToolStripMenuItem
    Friend WithEvents mnuMainHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpCenter As ToolStripMenuItem
    Friend WithEvents pnlBackground As Panel
    Friend WithEvents txtLetter As TextBox
    Friend WithEvents pnlEnter As Panel
    Friend WithEvents lblEnterLetter As Label
    Friend WithEvents pnlGuess As Panel
    Friend WithEvents pnlStatus As Panel
    Friend WithEvents lblLives As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblLettersLeft As Label
    Friend WithEvents lblLivesCount As Label
    Friend WithEvents lblLettersCount As Label
    Friend WithEvents pnlAlphabet As Panel
    Friend WithEvents lbla As Label
    Friend WithEvents lblr As Label
    Friend WithEvents lblq As Label
    Friend WithEvents lblp As Label
    Friend WithEvents lblo As Label
    Friend WithEvents lbln As Label
    Friend WithEvents lblm As Label
    Friend WithEvents lbll As Label
    Friend WithEvents lblk As Label
    Friend WithEvents lblj As Label
    Friend WithEvents lbli As Label
    Friend WithEvents lblh As Label
    Friend WithEvents lblg As Label
    Friend WithEvents lblf As Label
    Friend WithEvents lble As Label
    Friend WithEvents lbld As Label
    Friend WithEvents lblc As Label
    Friend WithEvents lblb As Label
    Friend WithEvents lbls As Label
    Friend WithEvents lblz As Label
    Friend WithEvents lbly As Label
    Friend WithEvents lblx As Label
    Friend WithEvents lblw As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblv As Label
    Friend WithEvents lblu As Label
    Friend WithEvents lblt As Label
    Friend WithEvents pnlUnderscores As Panel
    Friend WithEvents picHangman As PictureBox
    Private WithEvents lblUnderscores As Label
    Friend WithEvents btnGuessWord As Button
    Friend WithEvents btnGuessLetter As Button
    Public WithEvents comboCategories As ComboBox
    Friend WithEvents mnuCategoriesFood As ToolStripMenuItem
    Friend WithEvents mnuCategoriesSport As ToolStripMenuItem
    Friend WithEvents mnuCategoriesCountries As ToolStripMenuItem
End Class
