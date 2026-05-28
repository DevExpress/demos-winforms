Namespace DevExpress.AI.Demos

    Partial Class MemoEditAIModule

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

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim languageInfo1 As DevExpress.AIIntegration.WinForms.LanguageInfo = New DevExpress.AIIntegration.WinForms.LanguageInfo()
            Dim languageInfo2 As DevExpress.AIIntegration.WinForms.LanguageInfo = New DevExpress.AIIntegration.WinForms.LanguageInfo()
            Dim languageInfo3 As DevExpress.AIIntegration.WinForms.LanguageInfo = New DevExpress.AIIntegration.WinForms.LanguageInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.AI.Demos.MemoEditAIModule))
            Me.roundedSkinPanel1 = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.ucDisclaimerPanel1 = New DevExpress.AI.Demos.ucDisclaimerPanel()
            Me.pictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciRoundedSkinPanel1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciLabelControl1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciPictureEdit2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciUcDisclaimerPanel1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.roundedSkinPanel1.SuspendLayout()
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            CType((Me.pictureEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciRoundedSkinPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciLabelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciPictureEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciUcDisclaimerPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' roundedSkinPanel1
            ' 
            Me.roundedSkinPanel1.Controls.Add(Me.memoEdit1)
            Me.roundedSkinPanel1.Location = New System.Drawing.Point(0, 103)
            Me.roundedSkinPanel1.Name = "roundedSkinPanel1"
            Me.roundedSkinPanel1.Size = New System.Drawing.Size(468, 329)
            Me.roundedSkinPanel1.TabIndex = 0
            ' 
            ' memoEdit1
            ' 
            languageInfo1.Culture = New System.Globalization.CultureInfo("en")
            languageInfo1.LanguageName = "English"
            languageInfo2.Culture = New System.Globalization.CultureInfo("de")
            languageInfo2.LanguageName = "German"
            languageInfo3.Culture = New System.Globalization.CultureInfo("fr")
            languageInfo3.LanguageName = "French"
            Me.behaviorManager1.SetBehaviors(Me.memoEdit1, New DevExpress.Utils.Behaviors.Behavior() {CType((DevExpress.AIIntegration.WinForms.ExpandBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.MemoEditExpandBehaviorSource), Nothing, "", DevExpress.AIIntegration.Extensions.TextRetrievalMode.AllTextIfNoneSelected)), DevExpress.Utils.Behaviors.Behavior), CType((DevExpress.AIIntegration.WinForms.ShortenBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.MemoEditShortenBehaviorSource), Nothing, "", DevExpress.AIIntegration.Extensions.TextRetrievalMode.AllTextIfNoneSelected)), DevExpress.Utils.Behaviors.Behavior), CType((DevExpress.AIIntegration.WinForms.SummarizeBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.MemoEditSummarizeBehaviorSource), Nothing, "", DevExpress.AIIntegration.Extensions.TextRetrievalMode.AllTextIfNoneSelected, DevExpress.AIIntegration.SummarizationMode.Abstractive)), DevExpress.Utils.Behaviors.Behavior), CType((DevExpress.AIIntegration.WinForms.ExplainBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.MemoEditExplainBehaviorSource), Nothing, "", DevExpress.AIIntegration.Extensions.TextRetrievalMode.AllTextIfNoneSelected)), DevExpress.Utils.Behaviors.Behavior), CType((DevExpress.AIIntegration.WinForms.ChangeToneBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.MemoEditChangeToneBehaviorSource), Nothing, "", DevExpress.AIIntegration.Extensions.TextRetrievalMode.AllTextIfNoneSelected)), DevExpress.Utils.Behaviors.Behavior), CType((DevExpress.AIIntegration.WinForms.ProofreadBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.MemoEditProofreadBehaviorSource), Nothing, "", DevExpress.AIIntegration.Extensions.TextRetrievalMode.AllTextIfNoneSelected)), DevExpress.Utils.Behaviors.Behavior), CType((DevExpress.AIIntegration.WinForms.ChangeStyleBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.MemoEditChangeStyleBehaviorSource), Nothing, "", DevExpress.AIIntegration.Extensions.TextRetrievalMode.AllTextIfNoneSelected)), DevExpress.Utils.Behaviors.Behavior), CType((DevExpress.AIIntegration.WinForms.TranslateBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.MemoEditTranslateBehaviorSource), Nothing, "", DevExpress.AIIntegration.Extensions.TextRetrievalMode.AllTextIfNoneSelected, New DevExpress.AIIntegration.WinForms.LanguageInfo() {languageInfo1, languageInfo2, languageInfo3})), DevExpress.Utils.Behaviors.Behavior), CType((DevExpress.AIIntegration.WinForms.CustomRequestBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.MemoEditCustomRequestBehaviorSource), Nothing, "", DevExpress.AIIntegration.Extensions.TextRetrievalMode.AllTextIfNoneSelected)), DevExpress.Utils.Behaviors.Behavior)})
            Me.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.memoEdit1.EditValue = resources.GetString("memoEdit1.EditValue")
            Me.memoEdit1.Location = New System.Drawing.Point(17, 17)
            Me.memoEdit1.MinimumSize = New System.Drawing.Size(32, 32)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.memoEdit1.Size = New System.Drawing.Size(434, 295)
            Me.memoEdit1.StyleController = Me.layoutControl2
            Me.memoEdit1.TabIndex = 4
            ' 
            ' layoutControl2
            ' 
            Me.layoutControl2.AllowCustomization = False
            Me.layoutControl2.Controls.Add(Me.ucDisclaimerPanel1)
            Me.layoutControl2.Controls.Add(Me.pictureEdit2)
            Me.layoutControl2.Controls.Add(Me.labelControl1)
            Me.layoutControl2.Controls.Add(Me.roundedSkinPanel1)
            Me.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl2.MinimumSize = New System.Drawing.Size(400, 0)
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(758, 405, 934, 502)
            Me.layoutControl2.OptionsCustomizationForm.ShowPropertyGrid = True
            Me.layoutControl2.Root = Me.layoutControlGroup1
            Me.layoutControl2.Size = New System.Drawing.Size(784, 432)
            Me.layoutControl2.TabIndex = 3
            Me.layoutControl2.Text = "layoutControl2"
            ' 
            ' ucDisclaimerPanel1
            ' 
            Me.ucDisclaimerPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.ucDisclaimerPanel1.Location = New System.Drawing.Point(0, 0)
            Me.ucDisclaimerPanel1.Name = "ucDisclaimerPanel1"
            Me.ucDisclaimerPanel1.Size = New System.Drawing.Size(784, 103)
            Me.ucDisclaimerPanel1.TabIndex = 5
            ' 
            ' pictureEdit2
            ' 
            Me.pictureEdit2.EditValue = Global.DevExpress.AI.Demos.Properties.Resources.ai_assistant_menu
            Me.pictureEdit2.Location = New System.Drawing.Point(487, 320)
            Me.pictureEdit2.Name = "pictureEdit2"
            Me.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pictureEdit2.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopCenter
            Me.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
            Me.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            Me.pictureEdit2.Size = New System.Drawing.Size(278, 93)
            Me.pictureEdit2.StyleController = Me.layoutControl2
            Me.pictureEdit2.TabIndex = 4
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.AllowHtmlString = True
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl1.Location = New System.Drawing.Point(487, 132)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(278, 172)
            Me.labelControl1.StyleController = Me.layoutControl2
            Me.labelControl1.TabIndex = 1
            Me.labelControl1.Text = resources.GetString("labelControl1.Text")
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciRoundedSkinPanel1, Me.layoutControlGroup3, Me.lciUcDisclaimerPanel1})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(784, 432)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' lciRoundedSkinPanel1
            ' 
            Me.lciRoundedSkinPanel1.Control = Me.roundedSkinPanel1
            Me.lciRoundedSkinPanel1.Location = New System.Drawing.Point(0, 103)
            Me.lciRoundedSkinPanel1.Name = "lciRoundedSkinPanel1"
            Me.lciRoundedSkinPanel1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lciRoundedSkinPanel1.Size = New System.Drawing.Size(468, 329)
            Me.lciRoundedSkinPanel1.TextVisible = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup3.GroupBordersVisible = False
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciLabelControl1, Me.lciPictureEdit2})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(468, 103)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(316, 329)
            Me.layoutControlGroup3.TextVisible = False
            ' 
            ' lciLabelControl1
            ' 
            Me.lciLabelControl1.Control = Me.labelControl1
            Me.lciLabelControl1.Location = New System.Drawing.Point(0, 0)
            Me.lciLabelControl1.Name = "lciLabelControl1"
            Me.lciLabelControl1.Size = New System.Drawing.Size(284, 198)
            Me.lciLabelControl1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 10)
            Me.lciLabelControl1.TextVisible = False
            ' 
            ' lciPictureEdit2
            ' 
            Me.lciPictureEdit2.Control = Me.pictureEdit2
            Me.lciPictureEdit2.Location = New System.Drawing.Point(0, 198)
            Me.lciPictureEdit2.Name = "lciPictureEdit2"
            Me.lciPictureEdit2.Size = New System.Drawing.Size(284, 99)
            Me.lciPictureEdit2.TextVisible = False
            ' 
            ' lciUcDisclaimerPanel1
            ' 
            Me.lciUcDisclaimerPanel1.Control = Me.ucDisclaimerPanel1
            Me.lciUcDisclaimerPanel1.Location = New System.Drawing.Point(0, 0)
            Me.lciUcDisclaimerPanel1.Name = "lciUcDisclaimerPanel1"
            Me.lciUcDisclaimerPanel1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lciUcDisclaimerPanel1.Size = New System.Drawing.Size(784, 103)
            Me.lciUcDisclaimerPanel1.TextVisible = False
            ' 
            ' MemoEditAIModule
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl2)
            Me.Name = "MemoEditAIModule"
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.roundedSkinPanel1.ResumeLayout(False)
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            CType((Me.pictureEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciRoundedSkinPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciLabelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciPictureEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciUcDisclaimerPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit

        Private behaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager

        Private roundedSkinPanel1 As DevExpress.XtraEditors.RoundedSkinPanel

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private layoutControl2 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private pictureEdit2 As DevExpress.XtraEditors.PictureEdit

        Private lciPictureEdit2 As DevExpress.XtraLayout.LayoutControlItem

        Private lciLabelControl1 As DevExpress.XtraLayout.LayoutControlItem

        Private lciRoundedSkinPanel1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private ucDisclaimerPanel1 As DevExpress.AI.Demos.ucDisclaimerPanel

        Private lciUcDisclaimerPanel1 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
