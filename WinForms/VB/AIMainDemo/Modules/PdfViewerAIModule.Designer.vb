Namespace DevExpress.AI.Demos

    Partial Class PdfViewerAIModule

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
            Me.ucDisclaimerPanel1 = New DevExpress.AI.Demos.ucDisclaimerPanel()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.roundedSkinPanel1 = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.pdfViewer1 = New DevExpress.XtraPdfViewer.PdfViewer()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciUcDisclaimerPanel1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.roundedSkinPanel1.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciUcDisclaimerPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ucDisclaimerPanel1
            ' 
            Me.ucDisclaimerPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.ucDisclaimerPanel1.Location = New System.Drawing.Point(0, 0)
            Me.ucDisclaimerPanel1.Name = "ucDisclaimerPanel1"
            Me.ucDisclaimerPanel1.Size = New System.Drawing.Size(784, 103)
            Me.ucDisclaimerPanel1.TabIndex = 5
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.roundedSkinPanel1)
            Me.layoutControl1.Controls.Add(Me.ucDisclaimerPanel1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2862, 52, 835, 582)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(784, 432)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' roundedSkinPanel1
            ' 
            Me.roundedSkinPanel1.Controls.Add(Me.pdfViewer1)
            Me.roundedSkinPanel1.Location = New System.Drawing.Point(0, 103)
            Me.roundedSkinPanel1.Name = "roundedSkinPanel1"
            Me.roundedSkinPanel1.Size = New System.Drawing.Size(784, 329)
            Me.roundedSkinPanel1.TabIndex = 1
            Me.roundedSkinPanel1.Text = "roundedSkinPanel1"
            ' 
            ' pdfViewer1
            ' 
            languageInfo1.Culture = New System.Globalization.CultureInfo("en")
            languageInfo1.LanguageName = "English"
            languageInfo2.Culture = New System.Globalization.CultureInfo("es")
            languageInfo2.LanguageName = "Spanish"
            languageInfo3.Culture = New System.Globalization.CultureInfo("de")
            languageInfo3.LanguageName = "German"
            Me.behaviorManager1.SetBehaviors(Me.pdfViewer1, New DevExpress.Utils.Behaviors.Behavior() {CType((DevExpress.AIIntegration.WinForms.SummarizeBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.PdfSummarizeBehaviorSource), DevExpress.AIIntegration.SummarizationMode.Abstractive)), DevExpress.Utils.Behaviors.Behavior), CType((DevExpress.AIIntegration.WinForms.TranslateBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.PdfTranslateBehaviorSource), New DevExpress.AIIntegration.WinForms.LanguageInfo() {languageInfo1, languageInfo2, languageInfo3})), DevExpress.Utils.Behaviors.Behavior), CType((DevExpress.AIIntegration.WinForms.CustomRequestBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.PdfCustomRequestBehaviorSource))), DevExpress.Utils.Behaviors.Behavior)})
            Me.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pdfViewer1.Location = New System.Drawing.Point(17, 17)
            Me.pdfViewer1.MinimumSize = New System.Drawing.Size(32, 32)
            Me.pdfViewer1.Name = "pdfViewer1"
            Me.pdfViewer1.Size = New System.Drawing.Size(750, 295)
            Me.pdfViewer1.TabIndex = 4
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciUcDisclaimerPanel1, Me.layoutControlItem1})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(784, 432)
            Me.Root.TextVisible = False
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
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.roundedSkinPanel1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 103)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(784, 329)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' PdfViewerAIModule
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "PdfViewerAIModule"
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.roundedSkinPanel1.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciUcDisclaimerPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pdfViewer1 As DevExpress.XtraPdfViewer.PdfViewer

        Private behaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager

        Private ucDisclaimerPanel1 As DevExpress.AI.Demos.ucDisclaimerPanel

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private lciUcDisclaimerPanel1 As DevExpress.XtraLayout.LayoutControlItem

        Private roundedSkinPanel1 As DevExpress.XtraEditors.RoundedSkinPanel

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
