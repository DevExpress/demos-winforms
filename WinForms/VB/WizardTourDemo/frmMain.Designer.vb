Namespace DevExpress.XtraWizard.Demos

    Partial Class frmMain

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraWizard.Demos.frmMain))
            Me.wizardControl1 = New DevExpress.XtraWizard.WizardControl()
            Me.welcomeWizardPage1 = New DevExpress.XtraWizard.WelcomeWizardPage()
            Me.pictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
            Me.wpPlayTune = New DevExpress.XtraWizard.WizardPage()
            Me.lbcPlay = New DevExpress.XtraEditors.ListBoxControl()
            Me.panelControl3 = New DevExpress.XtraEditors.PanelControl()
            Me.sbPlay = New DevExpress.XtraEditors.SimpleButton()
            Me.wpLongText = New DevExpress.XtraWizard.WizardPage()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.ceLongText = New DevExpress.XtraEditors.CheckEdit()
            Me.wpQuestion = New DevExpress.XtraWizard.WizardPage()
            Me.ceNoAnswer = New DevExpress.XtraEditors.CheckEdit()
            Me.ceYesAnswer = New DevExpress.XtraEditors.CheckEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.wpNoAnswer = New DevExpress.XtraWizard.WizardPage()
            Me.lbcCancel = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.pictureEdit3 = New DevExpress.XtraEditors.PictureEdit()
            Me.wpProgress = New DevExpress.XtraWizard.WizardPage()
            Me.progressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
            Me.lbProgress = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.wpRobotTest = New DevExpress.XtraWizard.WizardPage()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
            Me.teRobotTest = New DevExpress.XtraEditors.TextEdit()
            Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
            Me.completionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
            CType((Me.wizardControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.wizardControl1.SuspendLayout()
            Me.welcomeWizardPage1.SuspendLayout()
            CType((Me.pictureEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.wpPlayTune.SuspendLayout()
            CType((Me.lbcPlay), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl3.SuspendLayout()
            Me.wpLongText.SuspendLayout()
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.ceLongText.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.wpQuestion.SuspendLayout()
            CType((Me.ceNoAnswer.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceYesAnswer.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.wpNoAnswer.SuspendLayout()
            CType((Me.pictureEdit3.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.wpProgress.SuspendLayout()
            CType((Me.progressBarControl1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.wpRobotTest.SuspendLayout()
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.teRobotTest.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' wizardControl1
            ' 
            Me.wizardControl1.AllowPagePadding = False
            Me.wizardControl1.Controls.Add(Me.welcomeWizardPage1)
            Me.wizardControl1.Controls.Add(Me.wpPlayTune)
            Me.wizardControl1.Controls.Add(Me.wpLongText)
            Me.wizardControl1.Controls.Add(Me.wpQuestion)
            Me.wizardControl1.Controls.Add(Me.wpNoAnswer)
            Me.wizardControl1.Controls.Add(Me.wpProgress)
            Me.wizardControl1.Controls.Add(Me.wpRobotTest)
            Me.wizardControl1.Controls.Add(Me.completionWizardPage1)
            Me.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.wizardControl1.HeaderImageOptions.Image = Global.DevExpress.XtraWizard.Demos.Properties.Resources.image_61x61
            Me.wizardControl1.ImageOptions.Image = Global.DevExpress.XtraWizard.Demos.Properties.Resources.wizard_image
            Me.wizardControl1.ImageOptions.ImageWidth = 200
            Me.wizardControl1.Name = "wizardControl1"
            Me.wizardControl1.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() {Me.welcomeWizardPage1, Me.wpPlayTune, Me.wpLongText, Me.wpQuestion, Me.wpNoAnswer, Me.wpProgress, Me.wpRobotTest, Me.completionWizardPage1})
            Me.wizardControl1.Size = New System.Drawing.Size(677, 432)
            AddHandler Me.wizardControl1.SelectedPageChanged, New DevExpress.XtraWizard.WizardPageChangedEventHandler(AddressOf Me.wizardControl1_SelectedPageChanged)
            AddHandler Me.wizardControl1.SelectedPageChanging, New DevExpress.XtraWizard.WizardPageChangingEventHandler(AddressOf Me.wizardControl1_SelectedPageChanging)
            AddHandler Me.wizardControl1.CancelClick, New System.ComponentModel.CancelEventHandler(AddressOf Me.wizardControl1_CancelClick)
            AddHandler Me.wizardControl1.FinishClick, New System.ComponentModel.CancelEventHandler(AddressOf Me.wizardControl1_FinishClick)
            AddHandler Me.wizardControl1.NextClick, New DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(AddressOf Me.wizardControl1_NextClick)
            ' 
            ' welcomeWizardPage1
            ' 
            Me.welcomeWizardPage1.Controls.Add(Me.pictureEdit2)
            Me.welcomeWizardPage1.IntroductionText = "Thank you for your interest in the XtraWizard Suite. We hope you’ll have some fun" & " during the next few minutes and learn about our new product in the process."
            Me.welcomeWizardPage1.Name = "welcomeWizardPage1"
            Me.welcomeWizardPage1.ProceedText = "To proceed with the tour, click Next."
            Me.welcomeWizardPage1.Size = New System.Drawing.Size(477, 293)
            Me.welcomeWizardPage1.Text = "Welcome to the XtraWizard Product Features Tour"
            ' 
            ' pictureEdit2
            ' 
            Me.pictureEdit2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pictureEdit2.EditValue = Global.DevExpress.XtraWizard.Demos.Properties.Resources.Have_fun_
            Me.pictureEdit2.Location = New System.Drawing.Point(0, 0)
            Me.pictureEdit2.Name = "pictureEdit2"
            Me.pictureEdit2.Properties.AllowFocused = False
            Me.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.pictureEdit2.Properties.Appearance.Options.UseBackColor = True
            Me.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pictureEdit2.Properties.PictureAlignment = System.Drawing.ContentAlignment.BottomRight
            Me.pictureEdit2.Properties.ShowMenu = False
            Me.pictureEdit2.Size = New System.Drawing.Size(477, 293)
            Me.pictureEdit2.TabIndex = 0
            ' 
            ' wpPlayTune
            ' 
            Me.wpPlayTune.Controls.Add(Me.lbcPlay)
            Me.wpPlayTune.Controls.Add(Me.panelControl3)
            Me.wpPlayTune.DescriptionText = "To make this demo more entertaining, we would like to play a tune for you. Simply" & " choose your favorite track from the list below and click Play."
            Me.wpPlayTune.Name = "wpPlayTune"
            Me.wpPlayTune.Padding = New System.Windows.Forms.Padding(16, 16, 16, 8)
            Me.wpPlayTune.Size = New System.Drawing.Size(677, 321)
            Me.wpPlayTune.Text = "Step 2 - Play a tune"
            ' 
            ' lbcPlay
            ' 
            Me.lbcPlay.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbcPlay.Items.AddRange(New Object() {"Metallica - Enter Sandman", "Nirvana - Smells Like Teen Spirit", "Pet Shop Boys - West End Girls", "Run D.M.C. - Christmas in Hollis", "Spice Girls - Wannabe", "Backstreet Boys - Show Me the Meaning", "The Prodigy - Firestarter ", "The Beatles - Yellow Submarine", "The Rolling Stones - Angie", "Black Eyed Peas - Pump It", "Rihanna - Umbrella", "Linkin Park - From the Inside", "Madonna - Music", "Michael Jackson - Bad", "Kanye West - Stronger", "Gwen Stefani - 4 in the Morning"})
            Me.lbcPlay.Location = New System.Drawing.Point(16, 16)
            Me.lbcPlay.Name = "lbcPlay"
            Me.lbcPlay.Size = New System.Drawing.Size(645, 260)
            Me.lbcPlay.TabIndex = 0
            AddHandler Me.lbcPlay.SelectedIndexChanged, New System.EventHandler(AddressOf Me.lbcPlay_SelectedIndexChanged)
            ' 
            ' panelControl3
            ' 
            Me.panelControl3.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.panelControl3.Appearance.Options.UseBackColor = True
            Me.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl3.Controls.Add(Me.sbPlay)
            Me.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl3.Location = New System.Drawing.Point(16, 276)
            Me.panelControl3.Name = "panelControl3"
            Me.panelControl3.Size = New System.Drawing.Size(645, 37)
            Me.panelControl3.TabIndex = 1
            ' 
            ' sbPlay
            ' 
            Me.sbPlay.Enabled = False
            Me.sbPlay.Location = New System.Drawing.Point(271, 8)
            Me.sbPlay.Name = "sbPlay"
            Me.sbPlay.Size = New System.Drawing.Size(103, 24)
            Me.sbPlay.TabIndex = 0
            Me.sbPlay.Text = "Play"
            AddHandler Me.sbPlay.Click, New System.EventHandler(AddressOf Me.sbPlay_Click)
            ' 
            ' wpLongText
            ' 
            Me.wpLongText.Controls.Add(Me.memoEdit1)
            Me.wpLongText.Controls.Add(Me.panelControl1)
            Me.wpLongText.DescriptionText = "Before proceeding, we want you to read and understand the following text, which i" & "s very long."
            Me.wpLongText.Name = "wpLongText"
            Me.wpLongText.Padding = New System.Windows.Forms.Padding(16)
            Me.wpLongText.Size = New System.Drawing.Size(677, 321)
            Me.wpLongText.Text = "Step 3 – The Read Some Very Long Text step"
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.memoEdit1.EditValue = ""
            Me.memoEdit1.Location = New System.Drawing.Point(16, 16)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Properties.[ReadOnly] = True
            Me.memoEdit1.Size = New System.Drawing.Size(645, 258)
            Me.memoEdit1.TabIndex = 0
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.panelControl1.Appearance.Options.UseBackColor = True
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.ceLongText)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl1.Location = New System.Drawing.Point(16, 274)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(645, 31)
            Me.panelControl1.TabIndex = 1
            ' 
            ' ceLongText
            ' 
            Me.ceLongText.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.ceLongText.Location = New System.Drawing.Point(0, 11)
            Me.ceLongText.Name = "ceLongText"
            Me.ceLongText.Properties.Caption = "I have read and understand the very long text above. Maybe."
            Me.ceLongText.Size = New System.Drawing.Size(645, 20)
            Me.ceLongText.TabIndex = 0
            AddHandler Me.ceLongText.CheckedChanged, New System.EventHandler(AddressOf Me.ceLongText_CheckedChanged)
            ' 
            ' wpQuestion
            ' 
            Me.wpQuestion.Controls.Add(Me.ceNoAnswer)
            Me.wpQuestion.Controls.Add(Me.ceYesAnswer)
            Me.wpQuestion.Controls.Add(Me.labelControl1)
            Me.wpQuestion.DescriptionText = ""
            Me.wpQuestion.Name = "wpQuestion"
            Me.wpQuestion.Padding = New System.Windows.Forms.Padding(16)
            Me.wpQuestion.Size = New System.Drawing.Size(677, 321)
            Me.wpQuestion.Text = "Step 4 – Are  You Tired Yet?"
            ' 
            ' ceNoAnswer
            ' 
            Me.ceNoAnswer.EditValue = True
            Me.ceNoAnswer.Location = New System.Drawing.Point(58, 138)
            Me.ceNoAnswer.Name = "ceNoAnswer"
            Me.ceNoAnswer.Properties.Caption = "No, get me out of here."
            Me.ceNoAnswer.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
            Me.ceNoAnswer.Properties.RadioGroupIndex = 0
            Me.ceNoAnswer.Size = New System.Drawing.Size(208, 20)
            Me.ceNoAnswer.TabIndex = 2
            ' 
            ' ceYesAnswer
            ' 
            Me.ceYesAnswer.Location = New System.Drawing.Point(58, 100)
            Me.ceYesAnswer.Name = "ceYesAnswer"
            Me.ceYesAnswer.Properties.Caption = "Yes, sure."
            Me.ceYesAnswer.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
            Me.ceYesAnswer.Properties.RadioGroupIndex = 0
            Me.ceYesAnswer.Size = New System.Drawing.Size(159, 20)
            Me.ceYesAnswer.TabIndex = 1
            Me.ceYesAnswer.TabStop = False
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelControl1.Location = New System.Drawing.Point(16, 16)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(645, 13)
            Me.labelControl1.TabIndex = 0
            Me.labelControl1.Text = "Do you really want to proceed with the XtraWizard tour even after we made you rea" & "d that much text?"
            ' 
            ' wpNoAnswer
            ' 
            Me.wpNoAnswer.Controls.Add(Me.lbcCancel)
            Me.wpNoAnswer.Controls.Add(Me.labelControl2)
            Me.wpNoAnswer.Controls.Add(Me.pictureEdit3)
            Me.wpNoAnswer.DescriptionText = ""
            Me.wpNoAnswer.Name = "wpNoAnswer"
            Me.wpNoAnswer.Size = New System.Drawing.Size(677, 321)
            Me.wpNoAnswer.Text = "Not so Fast!"
            ' 
            ' lbcCancel
            ' 
            Me.lbcCancel.Location = New System.Drawing.Point(16, 290)
            Me.lbcCancel.Name = "lbcCancel"
            Me.lbcCancel.Size = New System.Drawing.Size(278, 13)
            Me.lbcCancel.TabIndex = 1
            Me.lbcCancel.Text = "If you really, really, really want to quit, just press Cancel."
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl2.Location = New System.Drawing.Point(16, 16)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(613, 26)
            Me.labelControl2.TabIndex = 0
            Me.labelControl2.Text = "Ha! Did you really think we would let you out so easy? No way! Please press Next " & "to continue. You will navigate through just a few more frames, we promise…"
            ' 
            ' pictureEdit3
            ' 
            Me.pictureEdit3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pictureEdit3.EditValue = Global.DevExpress.XtraWizard.Demos.Properties.Resources.Not_so_fast_
            Me.pictureEdit3.Location = New System.Drawing.Point(0, 0)
            Me.pictureEdit3.Name = "pictureEdit3"
            Me.pictureEdit3.Properties.AllowFocused = False
            Me.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.pictureEdit3.Properties.Appearance.Options.UseBackColor = True
            Me.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pictureEdit3.Properties.PictureAlignment = System.Drawing.ContentAlignment.BottomRight
            Me.pictureEdit3.Properties.ShowMenu = False
            Me.pictureEdit3.Size = New System.Drawing.Size(677, 321)
            Me.pictureEdit3.TabIndex = 2
            ' 
            ' wpProgress
            ' 
            Me.wpProgress.Controls.Add(Me.progressBarControl1)
            Me.wpProgress.Controls.Add(Me.lbProgress)
            Me.wpProgress.Controls.Add(Me.labelControl4)
            Me.wpProgress.DescriptionText = ""
            Me.wpProgress.Name = "wpProgress"
            Me.wpProgress.Padding = New System.Windows.Forms.Padding(16)
            Me.wpProgress.Size = New System.Drawing.Size(677, 321)
            Me.wpProgress.Text = "Step 5 – Time-consuming Operation"
            ' 
            ' progressBarControl1
            ' 
            Me.progressBarControl1.Location = New System.Drawing.Point(81, 137)
            Me.progressBarControl1.Name = "progressBarControl1"
            Me.progressBarControl1.Size = New System.Drawing.Size(515, 18)
            Me.progressBarControl1.TabIndex = 2
            ' 
            ' lbProgress
            ' 
            Me.lbProgress.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.lbProgress.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lbProgress.Location = New System.Drawing.Point(16, 292)
            Me.lbProgress.Name = "lbProgress"
            Me.lbProgress.Size = New System.Drawing.Size(645, 13)
            Me.lbProgress.TabIndex = 1
            Me.lbProgress.Text = "Thanks for your patience. To proceed, click Next."
            Me.lbProgress.Visible = False
            ' 
            ' labelControl4
            ' 
            Me.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl4.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelControl4.Location = New System.Drawing.Point(16, 16)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Size = New System.Drawing.Size(645, 26)
            Me.labelControl4.TabIndex = 0
            Me.labelControl4.Text = "To keep you with us just for a little bit longer, we are performing an important " & "time-consuming operation. See – you can't proceed until it's completed!"
            ' 
            ' wpRobotTest
            ' 
            Me.wpRobotTest.AllowBack = False
            Me.wpRobotTest.Controls.Add(Me.panelControl2)
            Me.wpRobotTest.Controls.Add(Me.labelControl6)
            Me.wpRobotTest.DescriptionText = ""
            Me.wpRobotTest.Name = "wpRobotTest"
            Me.wpRobotTest.Padding = New System.Windows.Forms.Padding(16)
            Me.wpRobotTest.Size = New System.Drawing.Size(677, 321)
            Me.wpRobotTest.Text = "Step 6 - Are You a Robot?"
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.panelControl2.Appearance.Options.UseBackColor = True
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Controls.Add(Me.pictureEdit1)
            Me.panelControl2.Controls.Add(Me.teRobotTest)
            Me.panelControl2.Location = New System.Drawing.Point(130, 78)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(416, 167)
            Me.panelControl2.TabIndex = 2
            ' 
            ' pictureEdit1
            ' 
            Me.pictureEdit1.EditValue = Global.DevExpress.XtraWizard.Demos.Properties.Resources.devexpress123
            Me.pictureEdit1.Location = New System.Drawing.Point(65, 23)
            Me.pictureEdit1.Name = "pictureEdit1"
            Me.pictureEdit1.Properties.AllowFocused = False
            Me.pictureEdit1.Properties.ShowMenu = False
            Me.pictureEdit1.Size = New System.Drawing.Size(287, 83)
            Me.pictureEdit1.TabIndex = 2
            ' 
            ' teRobotTest
            ' 
            Me.teRobotTest.Location = New System.Drawing.Point(65, 119)
            Me.teRobotTest.Name = "teRobotTest"
            Me.teRobotTest.Size = New System.Drawing.Size(287, 20)
            Me.teRobotTest.TabIndex = 1
            ' 
            ' labelControl6
            ' 
            Me.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl6.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelControl6.Location = New System.Drawing.Point(16, 16)
            Me.labelControl6.Name = "labelControl6"
            Me.labelControl6.Size = New System.Drawing.Size(645, 13)
            Me.labelControl6.TabIndex = 0
            Me.labelControl6.Text = "To prove that you are a human, and not a spam bot, please enter the characters th" & "at you see in the image and press Next."
            ' 
            ' completionWizardPage1
            ' 
            Me.completionWizardPage1.Name = "completionWizardPage1"
            Me.completionWizardPage1.Size = New System.Drawing.Size(477, 316)
            ' 
            ' frmMain
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(677, 432)
            Me.Controls.Add(Me.wizardControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.IconOptions.Icon = CType((resources.GetObject("frmMain.IconOptions.Icon")), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmMain"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "WinForms Wizard Control - Wizard 97 Style"
            AddHandler Me.FormClosing, New System.Windows.Forms.FormClosingEventHandler(AddressOf Me.frmMain_FormClosing)
            CType((Me.wizardControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.wizardControl1.ResumeLayout(False)
            Me.welcomeWizardPage1.ResumeLayout(False)
            CType((Me.pictureEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.wpPlayTune.ResumeLayout(False)
            CType((Me.lbcPlay), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl3.ResumeLayout(False)
            Me.wpLongText.ResumeLayout(False)
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.ceLongText.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.wpQuestion.ResumeLayout(False)
            CType((Me.ceNoAnswer.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceYesAnswer.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.wpNoAnswer.ResumeLayout(False)
            Me.wpNoAnswer.PerformLayout()
            CType((Me.pictureEdit3.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.wpProgress.ResumeLayout(False)
            CType((Me.progressBarControl1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.wpRobotTest.ResumeLayout(False)
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.teRobotTest.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private wizardControl1 As DevExpress.XtraWizard.WizardControl

        Private welcomeWizardPage1 As DevExpress.XtraWizard.WelcomeWizardPage

        Private wpLongText As DevExpress.XtraWizard.WizardPage

        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private completionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage

        Private wpQuestion As DevExpress.XtraWizard.WizardPage

        Private wpNoAnswer As DevExpress.XtraWizard.WizardPage

        Private wpProgress As DevExpress.XtraWizard.WizardPage

        Private wpRobotTest As DevExpress.XtraWizard.WizardPage

        Private ceLongText As DevExpress.XtraEditors.CheckEdit

        Private ceNoAnswer As DevExpress.XtraEditors.CheckEdit

        Private ceYesAnswer As DevExpress.XtraEditors.CheckEdit

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private lbcCancel As DevExpress.XtraEditors.LabelControl

        Private progressBarControl1 As DevExpress.XtraEditors.ProgressBarControl

        Private lbProgress As DevExpress.XtraEditors.LabelControl

        Private labelControl4 As DevExpress.XtraEditors.LabelControl

        Private teRobotTest As DevExpress.XtraEditors.TextEdit

        Private labelControl6 As DevExpress.XtraEditors.LabelControl

        Private panelControl2 As DevExpress.XtraEditors.PanelControl

        Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit

        Private wpPlayTune As DevExpress.XtraWizard.WizardPage

        Private lbcPlay As DevExpress.XtraEditors.ListBoxControl

        Private panelControl3 As DevExpress.XtraEditors.PanelControl

        Private sbPlay As DevExpress.XtraEditors.SimpleButton

        Private pictureEdit2 As DevExpress.XtraEditors.PictureEdit

        Private pictureEdit3 As DevExpress.XtraEditors.PictureEdit
    End Class
End Namespace
