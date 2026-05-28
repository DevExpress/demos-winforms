Namespace DevExpress.XtraLayout.Demos

    Partial Class BaseTutorialControl

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.lcTitle = New DevExpress.XtraLayout.LayoutControl()
            Me.highlightTabHeadersCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.highlightGroupBordersCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.snapModeCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.showPropertyGridCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.showAdornerLayerCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.quickCustomizationCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.highlightFocusedItemCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.sbCustomize = New DevExpress.XtraEditors.SimpleButton()
            Me.allowExpandAnimationCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.tabTransitionAnimationCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.cbFiles = New DevExpress.XtraEditors.RadioGroup()
            Me.lcMainGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.quickCustomizationLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.showPropertyGridLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.snapModeLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lcCustomizeButton = New DevExpress.XtraLayout.LayoutControlItem()
            Me.showAdornerLayerLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.highlightFocusedItemCheckEditLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.allowExpandAnimationLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.allowExpandAnimationLCI1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lcItemCombo = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            CType((Me.lcTitle), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.lcTitle.SuspendLayout()
            CType((Me.highlightTabHeadersCheckEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.highlightGroupBordersCheckEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.snapModeCheckEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.showPropertyGridCheckEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.showAdornerLayerCheckEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.quickCustomizationCheckEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.highlightFocusedItemCheckEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.allowExpandAnimationCheckEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabTransitionAnimationCheckEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbFiles.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcMainGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.quickCustomizationLCI), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.showPropertyGridLCI), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.snapModeLCI), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcCustomizeButton), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.showAdornerLayerLCI), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.highlightFocusedItemCheckEditLCI), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.allowExpandAnimationLCI), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.allowExpandAnimationLCI1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcItemCombo), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.AllowResize = False
            Me.navigationPane1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.[False]
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            Me.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navigationPane1.Location = New System.Drawing.Point(1, 0)
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(249, 482)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.Size = New System.Drawing.Size(249, 482)
            Me.navigationPane1.TabIndex = 2
            Me.navigationPane1.Text = "navigationPane1"
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Options"
            Me.navigationPage1.Controls.Add(Me.lcTitle)
            Me.navigationPage1.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text
            Me.navigationPage1.Name = "navigationPage1"
            Me.navigationPage1.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text
            Me.navigationPage1.Size = New System.Drawing.Size(249, 449)
            ' 
            ' lcTitle
            ' 
            Me.lcTitle.AllowCustomization = False
            Me.lcTitle.Controls.Add(Me.highlightTabHeadersCheckEdit)
            Me.lcTitle.Controls.Add(Me.highlightGroupBordersCheckEdit)
            Me.lcTitle.Controls.Add(Me.snapModeCheckEdit)
            Me.lcTitle.Controls.Add(Me.showPropertyGridCheckEdit)
            Me.lcTitle.Controls.Add(Me.showAdornerLayerCheckEdit)
            Me.lcTitle.Controls.Add(Me.quickCustomizationCheckEdit)
            Me.lcTitle.Controls.Add(Me.highlightFocusedItemCheckEdit)
            Me.lcTitle.Controls.Add(Me.sbCustomize)
            Me.lcTitle.Controls.Add(Me.allowExpandAnimationCheckEdit)
            Me.lcTitle.Controls.Add(Me.tabTransitionAnimationCheckEdit)
            Me.lcTitle.Controls.Add(Me.cbFiles)
            Me.lcTitle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lcTitle.Location = New System.Drawing.Point(0, 0)
            Me.lcTitle.Name = "lcTitle"
            Me.lcTitle.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(623, 480, 785, 589)
            Me.lcTitle.OptionsView.UseParentAutoScaleFactor = True
            Me.lcTitle.Root = Me.lcMainGroup
            Me.lcTitle.Size = New System.Drawing.Size(249, 449)
            Me.lcTitle.TabIndex = 1
            ' 
            ' highlightTabHeadersCheckEdit
            ' 
            Me.highlightTabHeadersCheckEdit.Location = New System.Drawing.Point(12, 138)
            Me.highlightTabHeadersCheckEdit.Name = "highlightTabHeadersCheckEdit"
            Me.highlightTabHeadersCheckEdit.Properties.Caption = "Highlight Tabs"
            Me.highlightTabHeadersCheckEdit.Size = New System.Drawing.Size(225, 20)
            Me.highlightTabHeadersCheckEdit.StyleController = Me.lcTitle
            Me.highlightTabHeadersCheckEdit.TabIndex = 16
            AddHandler Me.highlightTabHeadersCheckEdit.CheckedChanged, New System.EventHandler(AddressOf Me.highlightTabHeadersCheckEdit_CheckedChanged)
            ' 
            ' highlightGroupBordersCheckEdit
            ' 
            Me.highlightGroupBordersCheckEdit.Location = New System.Drawing.Point(12, 114)
            Me.highlightGroupBordersCheckEdit.Name = "highlightGroupBordersCheckEdit"
            Me.highlightGroupBordersCheckEdit.Properties.Caption = "Highlight Group Borders"
            Me.highlightGroupBordersCheckEdit.Size = New System.Drawing.Size(225, 20)
            Me.highlightGroupBordersCheckEdit.StyleController = Me.lcTitle
            Me.highlightGroupBordersCheckEdit.TabIndex = 15
            AddHandler Me.highlightGroupBordersCheckEdit.CheckedChanged, New System.EventHandler(AddressOf Me.highlightGroupBordersCheckEdit_CheckedChanged)
            ' 
            ' snapModeCheckEdit
            ' 
            Me.snapModeCheckEdit.EditValue = True
            Me.snapModeCheckEdit.Location = New System.Drawing.Point(12, 366)
            Me.snapModeCheckEdit.Name = "snapModeCheckEdit"
            Me.snapModeCheckEdit.Properties.Caption = "Snap Customization Form"
            Me.snapModeCheckEdit.Size = New System.Drawing.Size(225, 20)
            Me.snapModeCheckEdit.StyleController = Me.lcTitle
            Me.snapModeCheckEdit.TabIndex = 14
            AddHandler Me.snapModeCheckEdit.CheckedChanged, New System.EventHandler(AddressOf Me.snapModeCheckEdit_CheckedChanged)
            ' 
            ' showPropertyGridCheckEdit
            ' 
            Me.showPropertyGridCheckEdit.EditValue = True
            Me.showPropertyGridCheckEdit.Location = New System.Drawing.Point(12, 342)
            Me.showPropertyGridCheckEdit.Name = "showPropertyGridCheckEdit"
            Me.showPropertyGridCheckEdit.Properties.Caption = "Show PropertyGrid"
            Me.showPropertyGridCheckEdit.Size = New System.Drawing.Size(225, 20)
            Me.showPropertyGridCheckEdit.StyleController = Me.lcTitle
            Me.showPropertyGridCheckEdit.TabIndex = 13
            AddHandler Me.showPropertyGridCheckEdit.CheckedChanged, New System.EventHandler(AddressOf Me.showPropertyGridCheckEdit_CheckedChanged)
            ' 
            ' showAdornerLayerCheckEdit
            ' 
            Me.showAdornerLayerCheckEdit.Location = New System.Drawing.Point(12, 318)
            Me.showAdornerLayerCheckEdit.Name = "showAdornerLayerCheckEdit"
            Me.showAdornerLayerCheckEdit.Properties.Caption = "Enable Customization Guides"
            Me.showAdornerLayerCheckEdit.Size = New System.Drawing.Size(225, 20)
            Me.showAdornerLayerCheckEdit.StyleController = Me.lcTitle
            Me.showAdornerLayerCheckEdit.TabIndex = 12
            AddHandler Me.showAdornerLayerCheckEdit.CheckedChanged, New System.EventHandler(AddressOf Me.showAdornerLayerCheckEdit_CheckedChanged)
            ' 
            ' quickCustomizationCheckEdit
            ' 
            Me.quickCustomizationCheckEdit.Location = New System.Drawing.Point(12, 294)
            Me.quickCustomizationCheckEdit.Name = "quickCustomizationCheckEdit"
            Me.quickCustomizationCheckEdit.Properties.Caption = "Quick Customization Mode"
            Me.quickCustomizationCheckEdit.Size = New System.Drawing.Size(225, 20)
            Me.quickCustomizationCheckEdit.StyleController = Me.lcTitle
            Me.quickCustomizationCheckEdit.TabIndex = 11
            AddHandler Me.quickCustomizationCheckEdit.CheckedChanged, New System.EventHandler(AddressOf Me.quickCustomizationCheckEdit_CheckedChanged)
            ' 
            ' highlightFocusedItemCheckEdit
            ' 
            Me.highlightFocusedItemCheckEdit.Location = New System.Drawing.Point(12, 90)
            Me.highlightFocusedItemCheckEdit.Name = "highlightFocusedItemCheckEdit"
            Me.highlightFocusedItemCheckEdit.Properties.Caption = "Highlight Focused Item"
            Me.highlightFocusedItemCheckEdit.Size = New System.Drawing.Size(225, 20)
            Me.highlightFocusedItemCheckEdit.StyleController = Me.lcTitle
            Me.highlightFocusedItemCheckEdit.TabIndex = 8
            AddHandler Me.highlightFocusedItemCheckEdit.CheckedChanged, New System.EventHandler(AddressOf Me.highlightFocusedItemCheckEdit_CheckedChanged)
            ' 
            ' sbCustomize
            ' 
            Me.sbCustomize.Location = New System.Drawing.Point(12, 390)
            Me.sbCustomize.Name = "sbCustomize"
            Me.sbCustomize.Size = New System.Drawing.Size(225, 22)
            Me.sbCustomize.StyleController = Me.lcTitle
            Me.sbCustomize.TabIndex = 6
            Me.sbCustomize.Text = "Customize Layout"
            AddHandler Me.sbCustomize.Click, New System.EventHandler(AddressOf Me.sbCustomize_Click)
            ' 
            ' allowExpandAnimationCheckEdit
            ' 
            Me.allowExpandAnimationCheckEdit.EditValue = True
            Me.allowExpandAnimationCheckEdit.Location = New System.Drawing.Point(12, 204)
            Me.allowExpandAnimationCheckEdit.Name = "allowExpandAnimationCheckEdit"
            Me.allowExpandAnimationCheckEdit.Properties.Caption = "Allow Group Expand Animation"
            Me.allowExpandAnimationCheckEdit.Size = New System.Drawing.Size(225, 20)
            Me.allowExpandAnimationCheckEdit.StyleController = Me.lcTitle
            Me.allowExpandAnimationCheckEdit.TabIndex = 12
            AddHandler Me.allowExpandAnimationCheckEdit.CheckedChanged, New System.EventHandler(AddressOf Me.allowExpandAnimationCheckEdit_CheckedChanged)
            ' 
            ' tabTransitionAnimationCheckEdit
            ' 
            Me.tabTransitionAnimationCheckEdit.EditValue = True
            Me.tabTransitionAnimationCheckEdit.Location = New System.Drawing.Point(12, 228)
            Me.tabTransitionAnimationCheckEdit.Name = "tabTransitionAnimationCheckEdit"
            Me.tabTransitionAnimationCheckEdit.Properties.Caption = "Allow Tab Transition Animation"
            Me.tabTransitionAnimationCheckEdit.Size = New System.Drawing.Size(225, 20)
            Me.tabTransitionAnimationCheckEdit.StyleController = Me.lcTitle
            Me.tabTransitionAnimationCheckEdit.TabIndex = 12
            AddHandler Me.tabTransitionAnimationCheckEdit.CheckedChanged, New System.EventHandler(AddressOf Me.tabTransitionAnimation_CheckedChanged)
            ' 
            ' cbFiles
            ' 
            Me.cbFiles.AutoSizeInLayoutControl = True
            Me.cbFiles.EditValue = ""
            Me.cbFiles.Location = New System.Drawing.Point(12, 34)
            Me.cbFiles.Name = "cbFiles"
            Me.cbFiles.Properties.Columns = 1
            Me.cbFiles.Size = New System.Drawing.Size(225, 10)
            Me.cbFiles.StyleController = Me.lcTitle
            Me.cbFiles.TabIndex = 3
            AddHandler Me.cbFiles.EditValueChanged, New System.EventHandler(AddressOf Me.cbFiles_EditValueChanged)
            ' 
            ' lcMainGroup
            ' 
            Me.lcMainGroup.CustomizationFormText = "Select json file and restore layout"
            Me.lcMainGroup.GroupBordersVisible = False
            Me.lcMainGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup1, Me.layoutControlGroup2, Me.layoutControlGroup3, Me.layoutControlGroup4})
            Me.lcMainGroup.Name = "Root"
            Me.lcMainGroup.OptionsItemText.TextToControlDistance = 5
            Me.lcMainGroup.Size = New System.Drawing.Size(249, 449)
            Me.lcMainGroup.Text = "Select json file and restore layout"
            Me.lcMainGroup.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 424)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(249, 25)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.quickCustomizationLCI, Me.showPropertyGridLCI, Me.snapModeLCI, Me.lcCustomizeButton, Me.showAdornerLayerLCI})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 260)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 164)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "Customization Mode"
            ' 
            ' quickCustomizationLCI
            ' 
            Me.quickCustomizationLCI.Control = Me.quickCustomizationCheckEdit
            Me.quickCustomizationLCI.CustomizationFormText = "quickCustomizationLCI"
            Me.quickCustomizationLCI.Location = New System.Drawing.Point(0, 0)
            Me.quickCustomizationLCI.Name = "quickCustomizationLCI"
            Me.quickCustomizationLCI.Size = New System.Drawing.Size(229, 24)
            Me.quickCustomizationLCI.TextVisible = False
            ' 
            ' showPropertyGridLCI
            ' 
            Me.showPropertyGridLCI.Control = Me.showPropertyGridCheckEdit
            Me.showPropertyGridLCI.Location = New System.Drawing.Point(0, 48)
            Me.showPropertyGridLCI.Name = "showPropertyGridLCI"
            Me.showPropertyGridLCI.Size = New System.Drawing.Size(229, 24)
            Me.showPropertyGridLCI.TextVisible = False
            ' 
            ' snapModeLCI
            ' 
            Me.snapModeLCI.Control = Me.snapModeCheckEdit
            Me.snapModeLCI.Location = New System.Drawing.Point(0, 72)
            Me.snapModeLCI.Name = "snapModeLCI"
            Me.snapModeLCI.Size = New System.Drawing.Size(229, 24)
            Me.snapModeLCI.TextVisible = False
            ' 
            ' lcCustomizeButton
            ' 
            Me.lcCustomizeButton.Control = Me.sbCustomize
            Me.lcCustomizeButton.CustomizationFormText = "lcCustomizeButton"
            Me.lcCustomizeButton.Location = New System.Drawing.Point(0, 96)
            Me.lcCustomizeButton.Name = "lcCustomizeButton"
            Me.lcCustomizeButton.Size = New System.Drawing.Size(229, 26)
            Me.lcCustomizeButton.TextVisible = False
            ' 
            ' showAdornerLayerLCI
            ' 
            Me.showAdornerLayerLCI.Control = Me.showAdornerLayerCheckEdit
            Me.showAdornerLayerLCI.Location = New System.Drawing.Point(0, 24)
            Me.showAdornerLayerLCI.Name = "showAdornerLayerLCI"
            Me.showAdornerLayerLCI.Size = New System.Drawing.Size(229, 24)
            Me.showAdornerLayerLCI.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.highlightFocusedItemCheckEditLCI, Me.layoutControlItem1, Me.layoutControlItem2})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 56)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.OptionsItemText.TextToControlDistance = 5
            Me.layoutControlGroup2.Size = New System.Drawing.Size(249, 114)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Appearance"
            ' 
            ' highlightFocusedItemCheckEditLCI
            ' 
            Me.highlightFocusedItemCheckEditLCI.Control = Me.highlightFocusedItemCheckEdit
            Me.highlightFocusedItemCheckEditLCI.CustomizationFormText = "highlightFocusedItemCheckEditLCI"
            Me.highlightFocusedItemCheckEditLCI.Location = New System.Drawing.Point(0, 0)
            Me.highlightFocusedItemCheckEditLCI.Name = "highlightFocusedItemCheckEditLCI"
            Me.highlightFocusedItemCheckEditLCI.Size = New System.Drawing.Size(229, 24)
            Me.highlightFocusedItemCheckEditLCI.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.highlightGroupBordersCheckEdit
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.highlightTabHeadersCheckEdit
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.allowExpandAnimationLCI, Me.allowExpandAnimationLCI1})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 170)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.OptionsItemText.TextToControlDistance = 5
            Me.layoutControlGroup3.Size = New System.Drawing.Size(249, 90)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup3.Text = "Animation"
            ' 
            ' allowExpandAnimationLCI
            ' 
            Me.allowExpandAnimationLCI.Control = Me.allowExpandAnimationCheckEdit
            Me.allowExpandAnimationLCI.Location = New System.Drawing.Point(0, 0)
            Me.allowExpandAnimationLCI.Name = "allowExpandAnimationLCI"
            Me.allowExpandAnimationLCI.Size = New System.Drawing.Size(229, 24)
            Me.allowExpandAnimationLCI.TextVisible = False
            ' 
            ' allowExpandAnimationLCI1
            ' 
            Me.allowExpandAnimationLCI1.Control = Me.tabTransitionAnimationCheckEdit
            Me.allowExpandAnimationLCI1.Location = New System.Drawing.Point(0, 24)
            Me.allowExpandAnimationLCI1.Name = "allowExpandAnimationLCI1"
            Me.allowExpandAnimationLCI1.Size = New System.Drawing.Size(229, 24)
            Me.allowExpandAnimationLCI1.Text = "allowTabTransitionAnimationLCI"
            Me.allowExpandAnimationLCI1.TextVisible = False
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcItemCombo})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.OptionsItemText.TextToControlDistance = 5
            Me.layoutControlGroup4.Size = New System.Drawing.Size(249, 56)
            Me.layoutControlGroup4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup4.Text = "JSON Files"
            ' 
            ' lcItemCombo
            ' 
            Me.lcItemCombo.Control = Me.cbFiles
            Me.lcItemCombo.CustomizationFormText = "Json files:"
            Me.lcItemCombo.Location = New System.Drawing.Point(0, 0)
            Me.lcItemCombo.Name = "lcItemCombo"
            Me.lcItemCombo.Size = New System.Drawing.Size(229, 14)
            Me.lcItemCombo.Text = "Json files:"
            Me.lcItemCombo.TextLocation = DevExpress.Utils.Locations.Top
            Me.lcItemCombo.TextVisible = False
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.navigationPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(464, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(250, 482)
            Me.sidePanel1.TabIndex = 2
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' BaseTutorialControl
            ' 
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "BaseTutorialControl"
            Me.Size = New System.Drawing.Size(714, 482)
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            CType((Me.lcTitle), System.ComponentModel.ISupportInitialize).EndInit()
            Me.lcTitle.ResumeLayout(False)
            CType((Me.highlightTabHeadersCheckEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.highlightGroupBordersCheckEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.snapModeCheckEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.showPropertyGridCheckEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.showAdornerLayerCheckEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.quickCustomizationCheckEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.highlightFocusedItemCheckEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.allowExpandAnimationCheckEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabTransitionAnimationCheckEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbFiles.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcMainGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.quickCustomizationLCI), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.showPropertyGridLCI), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.snapModeLCI), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcCustomizeButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.showAdornerLayerLCI), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.highlightFocusedItemCheckEditLCI), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.allowExpandAnimationLCI), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.allowExpandAnimationLCI1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcItemCombo), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private lcMainGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private lcTitle As DevExpress.XtraLayout.LayoutControl

        Private sbCustomize As DevExpress.XtraEditors.SimpleButton

        Private highlightFocusedItemCheckEdit As DevExpress.XtraEditors.CheckEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private quickCustomizationCheckEdit As DevExpress.XtraEditors.CheckEdit

        Private showAdornerLayerCheckEdit As DevExpress.XtraEditors.CheckEdit

        Private lcItemCombo As DevExpress.XtraLayout.LayoutControlItem

        Private navigationPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private navigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private allowExpandAnimationCheckEdit As DevExpress.XtraEditors.CheckEdit

        Private showPropertyGridCheckEdit As DevExpress.XtraEditors.CheckEdit

        Private snapModeCheckEdit As DevExpress.XtraEditors.CheckEdit

        Private tabTransitionAnimationCheckEdit As DevExpress.XtraEditors.CheckEdit

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private quickCustomizationLCI As DevExpress.XtraLayout.LayoutControlItem

        Private showPropertyGridLCI As DevExpress.XtraLayout.LayoutControlItem

        Private snapModeLCI As DevExpress.XtraLayout.LayoutControlItem

        Private lcCustomizeButton As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private highlightFocusedItemCheckEditLCI As DevExpress.XtraLayout.LayoutControlItem

        Private showAdornerLayerLCI As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private allowExpandAnimationLCI As DevExpress.XtraLayout.LayoutControlItem

        Private allowExpandAnimationLCI1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private cbFiles As DevExpress.XtraEditors.RadioGroup

        Private highlightGroupBordersCheckEdit As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private highlightTabHeadersCheckEdit As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
