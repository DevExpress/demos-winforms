Namespace DevExpress.ApplicationUI.Demos.VisualEffects

    Partial Class ModuleGuides

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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.ApplicationUI.Demos.VisualEffects.ModuleGuides))
            Me.normalBackColorRepositoryItem = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit()
            Me.adornerUIManager = New DevExpress.Utils.VisualEffects.AdornerUIManager(Me.components)
            Me.guide1 = New DevExpress.Utils.VisualEffects.Guide()
            Me.badge1 = New DevExpress.Utils.VisualEffects.Badge()
            Me.sample = New DevExpress.XtraEditors.GroupControl()
            Me.label = New DevExpress.XtraEditors.LabelControl()
            Me.tabNavigation = New DevExpress.XtraBars.Navigation.TabPane()
            Me.styleNavigationPage = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.appearanceAccordionControl = New DevExpress.XtraBars.Navigation.AccordionControl()
            Me.accordionContentContainer1 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.lbBackColor = New DevExpress.XtraEditors.LabelControl()
            Me.lbForeColor = New DevExpress.XtraEditors.LabelControl()
            Me.cbBackColor = New DevExpress.XtraEditors.ColorEdit()
            Me.cbForeColor = New DevExpress.XtraEditors.ColorEdit()
            Me.appearanceItem = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.settingsNavigationPage = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.textAccordionControl = New DevExpress.XtraBars.Navigation.AccordionControl()
            Me.accordionContentContainer2 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.lbText = New DevExpress.XtraEditors.LabelControl()
            Me.lbFontSizeDelta = New DevExpress.XtraEditors.LabelControl()
            Me.teText = New DevExpress.XtraEditors.TextEdit()
            Me.seFontSizeDelta = New DevExpress.XtraEditors.SpinEdit()
            Me.textItem = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            CType((Me.normalBackColorRepositoryItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.adornerUIManager), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.sample), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sample.SuspendLayout()
            CType((Me.tabNavigation), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabNavigation.SuspendLayout()
            Me.styleNavigationPage.SuspendLayout()
            CType((Me.appearanceAccordionControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.appearanceAccordionControl.SuspendLayout()
            Me.accordionContentContainer1.SuspendLayout()
            CType((Me.cbBackColor.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbForeColor.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsNavigationPage.SuspendLayout()
            CType((Me.textAccordionControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.textAccordionControl.SuspendLayout()
            Me.accordionContentContainer2.SuspendLayout()
            CType((Me.teText.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seFontSizeDelta.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' normalBackColorRepositoryItem
            ' 
            Me.normalBackColorRepositoryItem.AutoHeight = False
            Me.normalBackColorRepositoryItem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.normalBackColorRepositoryItem.Name = "normalBackColorRepositoryItem"
            ' 
            ' adornerUIManager
            ' 
            Me.adornerUIManager.Elements.Add(Me.guide1)
            Me.adornerUIManager.Elements.Add(Me.badge1)
            Me.adornerUIManager.GuideProperties.ShowGuidesShortcut = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F2)
            Me.adornerUIManager.Owner = Me
            ' 
            ' guide1
            ' 
            Me.guide1.Tag = ""
            ' 
            ' badge1
            ' 
            Me.badge1.Properties.Location = System.Drawing.ContentAlignment.TopRight
            Me.badge1.Properties.Offset = New System.Drawing.Point(-60, 14)
            Me.badge1.Properties.Text = "Start Tutorial"
            Me.badge1.Properties.TextMargin = New System.Windows.Forms.Padding(5)
            Me.badge1.TargetElement = Me.sample
            AddHandler Me.badge1.Click, New System.EventHandler(AddressOf Me.OnBadgeClick)
            ' 
            ' sample
            ' 
            Me.sample.Controls.Add(Me.label)
            Me.sample.Location = New System.Drawing.Point(24, 93)
            Me.sample.Name = "sample"
            Me.sample.Size = New System.Drawing.Size(271, 171)
            Me.sample.TabIndex = 9
            Me.sample.Text = "Sample"
            ' 
            ' label
            ' 
            Me.label.Appearance.Options.UseTextOptions = True
            Me.label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.label.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.label.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label.Location = New System.Drawing.Point(2, 23)
            Me.label.Name = "label"
            Me.label.Size = New System.Drawing.Size(267, 146)
            Me.label.TabIndex = 3
            Me.label.Text = "Label1"
            ' 
            ' tabNavigation
            ' 
            Me.tabNavigation.Controls.Add(Me.styleNavigationPage)
            Me.tabNavigation.Controls.Add(Me.settingsNavigationPage)
            Me.tabNavigation.Location = New System.Drawing.Point(361, 93)
            Me.tabNavigation.Name = "tabNavigation"
            Me.tabNavigation.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.styleNavigationPage, Me.settingsNavigationPage})
            Me.tabNavigation.RegularSize = New System.Drawing.Size(259, 169)
            Me.tabNavigation.SelectedPage = Me.settingsNavigationPage
            Me.tabNavigation.Size = New System.Drawing.Size(259, 169)
            Me.tabNavigation.TabIndex = 0
            ' 
            ' styleNavigationPage
            ' 
            Me.styleNavigationPage.Caption = "Style changed"
            Me.styleNavigationPage.Controls.Add(Me.appearanceAccordionControl)
            Me.styleNavigationPage.ImageOptions.SvgImage = CType((resources.GetObject("styleNavigationPage.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.styleNavigationPage.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.styleNavigationPage.Name = "styleNavigationPage"
            Me.styleNavigationPage.Size = New System.Drawing.Size(241, 121)
            ' 
            ' appearanceAccordionControl
            ' 
            Me.appearanceAccordionControl.Controls.Add(Me.accordionContentContainer1)
            Me.appearanceAccordionControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.appearanceAccordionControl.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.appearanceItem})
            Me.appearanceAccordionControl.Location = New System.Drawing.Point(0, 0)
            Me.appearanceAccordionControl.Name = "appearanceAccordionControl"
            Me.appearanceAccordionControl.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden
            Me.appearanceAccordionControl.Size = New System.Drawing.Size(241, 121)
            Me.appearanceAccordionControl.TabIndex = 18
            ' 
            ' accordionContentContainer1
            ' 
            Me.accordionContentContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.accordionContentContainer1.Appearance.Options.UseBackColor = True
            Me.accordionContentContainer1.Controls.Add(Me.lbBackColor)
            Me.accordionContentContainer1.Controls.Add(Me.lbForeColor)
            Me.accordionContentContainer1.Controls.Add(Me.cbBackColor)
            Me.accordionContentContainer1.Controls.Add(Me.cbForeColor)
            Me.accordionContentContainer1.Name = "accordionContentContainer1"
            Me.accordionContentContainer1.Size = New System.Drawing.Size(222, 76)
            Me.accordionContentContainer1.TabIndex = 1
            ' 
            ' lbBackColor
            ' 
            Me.lbBackColor.Location = New System.Drawing.Point(3, 17)
            Me.lbBackColor.Name = "lbBackColor"
            Me.lbBackColor.Size = New System.Drawing.Size(51, 13)
            Me.lbBackColor.TabIndex = 14
            Me.lbBackColor.Text = "BackColor:"
            ' 
            ' lbForeColor
            ' 
            Me.lbForeColor.Location = New System.Drawing.Point(3, 47)
            Me.lbForeColor.Name = "lbForeColor"
            Me.lbForeColor.Size = New System.Drawing.Size(51, 13)
            Me.lbForeColor.TabIndex = 15
            Me.lbForeColor.Text = "ForeColor:"
            ' 
            ' cbBackColor
            ' 
            Me.cbBackColor.EditValue = System.Drawing.Color.Empty
            Me.cbBackColor.Location = New System.Drawing.Point(86, 14)
            Me.cbBackColor.Name = "cbBackColor"
            Me.cbBackColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbBackColor.Size = New System.Drawing.Size(125, 20)
            Me.cbBackColor.TabIndex = 17
            AddHandler Me.cbBackColor.ColorChanged, New System.EventHandler(AddressOf Me.OnBackColorChanged)
            ' 
            ' cbForeColor
            ' 
            Me.cbForeColor.EditValue = System.Drawing.Color.Empty
            Me.cbForeColor.Location = New System.Drawing.Point(86, 44)
            Me.cbForeColor.Name = "cbForeColor"
            Me.cbForeColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbForeColor.Size = New System.Drawing.Size(125, 20)
            Me.cbForeColor.TabIndex = 16
            AddHandler Me.cbForeColor.ColorChanged, New System.EventHandler(AddressOf Me.OnForeColorChanged)
            ' 
            ' appearanceItem
            ' 
            Me.appearanceItem.ContentContainer = Me.accordionContentContainer1
            Me.appearanceItem.Name = "appearanceItem"
            Me.appearanceItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.appearanceItem.Text = "Appearance"
            ' 
            ' settingsNavigationPage
            ' 
            Me.settingsNavigationPage.Caption = "Text changed"
            Me.settingsNavigationPage.Controls.Add(Me.textAccordionControl)
            Me.settingsNavigationPage.ImageOptions.SvgImage = CType((resources.GetObject("settingsNavigationPage.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.settingsNavigationPage.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.settingsNavigationPage.Name = "settingsNavigationPage"
            Me.settingsNavigationPage.Size = New System.Drawing.Size(259, 134)
            ' 
            ' textAccordionControl
            ' 
            Me.textAccordionControl.Controls.Add(Me.accordionContentContainer2)
            Me.textAccordionControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textAccordionControl.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.textItem})
            Me.textAccordionControl.Location = New System.Drawing.Point(0, 0)
            Me.textAccordionControl.Name = "textAccordionControl"
            Me.textAccordionControl.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden
            Me.textAccordionControl.Size = New System.Drawing.Size(259, 134)
            Me.textAccordionControl.TabIndex = 19
            ' 
            ' accordionContentContainer2
            ' 
            Me.accordionContentContainer2.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.accordionContentContainer2.Appearance.Options.UseBackColor = True
            Me.accordionContentContainer2.Controls.Add(Me.lbText)
            Me.accordionContentContainer2.Controls.Add(Me.lbFontSizeDelta)
            Me.accordionContentContainer2.Controls.Add(Me.teText)
            Me.accordionContentContainer2.Controls.Add(Me.seFontSizeDelta)
            Me.accordionContentContainer2.Name = "accordionContentContainer2"
            Me.accordionContentContainer2.Size = New System.Drawing.Size(240, 76)
            Me.accordionContentContainer2.TabIndex = 1
            ' 
            ' lbText
            ' 
            Me.lbText.Location = New System.Drawing.Point(3, 16)
            Me.lbText.Name = "lbText"
            Me.lbText.Size = New System.Drawing.Size(26, 13)
            Me.lbText.TabIndex = 14
            Me.lbText.Text = "Text:"
            ' 
            ' lbFontSizeDelta
            ' 
            Me.lbFontSizeDelta.Location = New System.Drawing.Point(3, 46)
            Me.lbFontSizeDelta.Name = "lbFontSizeDelta"
            Me.lbFontSizeDelta.Size = New System.Drawing.Size(70, 13)
            Me.lbFontSizeDelta.TabIndex = 15
            Me.lbFontSizeDelta.Text = "FontSizeDelta:"
            ' 
            ' teText
            ' 
            Me.teText.EditValue = "label1"
            Me.teText.Location = New System.Drawing.Point(93, 13)
            Me.teText.Name = "teText"
            Me.teText.Size = New System.Drawing.Size(125, 20)
            Me.teText.TabIndex = 17
            AddHandler Me.teText.EditValueChanged, New System.EventHandler(AddressOf Me.OnTextChanged)
            ' 
            ' seFontSizeDelta
            ' 
            Me.seFontSizeDelta.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seFontSizeDelta.Location = New System.Drawing.Point(93, 43)
            Me.seFontSizeDelta.Name = "seFontSizeDelta"
            Me.seFontSizeDelta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seFontSizeDelta.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.seFontSizeDelta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.seFontSizeDelta.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
            Me.seFontSizeDelta.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.seFontSizeDelta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.seFontSizeDelta.Size = New System.Drawing.Size(125, 20)
            Me.seFontSizeDelta.TabIndex = 16
            AddHandler Me.seFontSizeDelta.ValueChanged, New System.EventHandler(AddressOf Me.OnFontSizeDeltaChanged)
            ' 
            ' textItem
            ' 
            Me.textItem.ContentContainer = Me.accordionContentContainer2
            Me.textItem.Name = "textItem"
            Me.textItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.textItem.Text = "Text"
            ' 
            ' ModuleGuides
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sample)
            Me.Controls.Add(Me.tabNavigation)
            Me.Name = "ModuleGuides"
            Me.Size = New System.Drawing.Size(659, 383)
            CType((Me.normalBackColorRepositoryItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.adornerUIManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.sample), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sample.ResumeLayout(False)
            CType((Me.tabNavigation), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabNavigation.ResumeLayout(False)
            Me.styleNavigationPage.ResumeLayout(False)
            CType((Me.appearanceAccordionControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.appearanceAccordionControl.ResumeLayout(False)
            Me.accordionContentContainer1.ResumeLayout(False)
            Me.accordionContentContainer1.PerformLayout()
            CType((Me.cbBackColor.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbForeColor.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsNavigationPage.ResumeLayout(False)
            CType((Me.textAccordionControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.textAccordionControl.ResumeLayout(False)
            Me.accordionContentContainer2.ResumeLayout(False)
            Me.accordionContentContainer2.PerformLayout()
            CType((Me.teText.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seFontSizeDelta.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private adornerUIManager As DevExpress.Utils.VisualEffects.AdornerUIManager

        Private guide1 As DevExpress.Utils.VisualEffects.Guide

        Private normalBackColorRepositoryItem As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit

        Private tabNavigation As DevExpress.XtraBars.Navigation.TabPane

        Private styleNavigationPage As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private settingsNavigationPage As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private appearanceAccordionControl As DevExpress.XtraBars.Navigation.AccordionControl

        Private accordionContentContainer1 As DevExpress.XtraBars.Navigation.AccordionContentContainer

        Private lbBackColor As DevExpress.XtraEditors.LabelControl

        Private lbForeColor As DevExpress.XtraEditors.LabelControl

        Private appearanceItem As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private cbBackColor As DevExpress.XtraEditors.ColorEdit

        Private cbForeColor As DevExpress.XtraEditors.ColorEdit

        Private textAccordionControl As DevExpress.XtraBars.Navigation.AccordionControl

        Private accordionContentContainer2 As DevExpress.XtraBars.Navigation.AccordionContentContainer

        Private lbText As DevExpress.XtraEditors.LabelControl

        Private lbFontSizeDelta As DevExpress.XtraEditors.LabelControl

        Private textItem As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private teText As DevExpress.XtraEditors.TextEdit

        Private seFontSizeDelta As DevExpress.XtraEditors.SpinEdit

        Private sample As DevExpress.XtraEditors.GroupControl

        Private label As DevExpress.XtraEditors.LabelControl

        Private badge1 As DevExpress.Utils.VisualEffects.Badge
    End Class
End Namespace
