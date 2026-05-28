Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleToolTipController

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me._timerControl IsNot Nothing Then
                    Me._timerControl.Dispose()
                    Me._timerControl = Nothing
                End If

                If Me._clockLabelControl IsNot Nothing Then
                    Me._clockLabelControl.Dispose()
                    Me._clockLabelControl = Nothing
                End If

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
        Private resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraEditors.Demos.ModuleToolTipController))

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim columnDefinition1 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition2 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition3 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim rowDefinition1 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition2 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition3 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Me.toolTipControllerContentProperties1 = New EditorsTutorials.Modules.ToolTipControllerContentProperties()
            Me.pceToolTipLocation = New DevExpress.XtraEditors.PopupContainerEdit()
            Me.popupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
            Me.toolTipLocationControl = New EditorsTutorials.Modules.ToolTipLocationControl()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceShowShadow = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowBeak = New DevExpress.XtraEditors.CheckEdit()
            Me.label7 = New DevExpress.XtraEditors.LabelControl()
            Me.ceRounded = New DevExpress.XtraEditors.CheckEdit()
            Me.seAutoPopDelay = New DevExpress.XtraEditors.SpinEdit()
            Me.seRoundRadius = New DevExpress.XtraEditors.SpinEdit()
            Me.seInitialDelay = New DevExpress.XtraEditors.SpinEdit()
            Me.lbSample = New System.Windows.Forms.Label()
            Me.xtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            Me.propertyGrid1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
            Me.xtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
            Me.propertyGrid2 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.toolTipControllerContentProperties2 = New EditorsTutorials.Modules.ToolTipControllerContentProperties()
            Me.lbSampleManual = New System.Windows.Forms.Label()
            Me.lbStyleSample = New System.Windows.Forms.Label()
            Me.icbType = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.chAllowHTML = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControl4 = New DevExpress.XtraLayout.LayoutControl()
            Me.checkEditShowBeak = New DevExpress.XtraEditors.CheckEdit()
            Me.flyoutLabel = New DevExpress.XtraEditors.LabelControl()
            Me.flyoutToolTipController = New DevExpress.Utils.ToolTipController(Me.components)
            Me.radioGroupExamples = New DevExpress.XtraEditors.RadioGroup()
            Me.layoutControlGroup11 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup12 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup13 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup14 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControl3 = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup9 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup10 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.toolTipStyleController = New DevExpress.Utils.ToolTipController(Me.components)
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.tabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.tabNavigationPage3 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.tabNavigationPage4 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            CType((Me.pceToolTipLocation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.popupContainerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupContainerControl1.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ceShowShadow.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowBeak.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceRounded.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seAutoPopDelay.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seRoundRadius.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seInitialDelay.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xtraTabControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl2.SuspendLayout()
            Me.xtraTabPage2.SuspendLayout()
            CType((Me.propertyGrid1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage3.SuspendLayout()
            CType((Me.propertyGrid2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbType.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            CType((Me.chAllowHTML.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl4.SuspendLayout()
            CType((Me.checkEditShowBeak.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radioGroupExamples.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem18), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem19), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl3.SuspendLayout()
            CType((Me.layoutControlGroup8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.tabNavigationPage2.SuspendLayout()
            Me.tabNavigationPage3.SuspendLayout()
            Me.tabNavigationPage4.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' toolTipControllerContentProperties1
            ' 
            Me.toolTipControllerContentProperties1.Location = New System.Drawing.Point(24, 156)
            Me.toolTipControllerContentProperties1.Name = "toolTipControllerContentProperties1"
            Me.toolTipControllerContentProperties1.Size = New System.Drawing.Size(306, 216)
            Me.toolTipControllerContentProperties1.TabIndex = 0
            ' 
            ' pceToolTipLocation
            ' 
            Me.pceToolTipLocation.EditValue = ""
            Me.pceToolTipLocation.Location = New System.Drawing.Point(570, 571)
            Me.pceToolTipLocation.Name = "pceToolTipLocation"
            Me.pceToolTipLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.pceToolTipLocation.Properties.PopupControl = Me.popupContainerControl1
            Me.pceToolTipLocation.Properties.ShowPopupCloseButton = False
            Me.pceToolTipLocation.Size = New System.Drawing.Size(542, 20)
            Me.pceToolTipLocation.StyleController = Me.layoutControl1
            Me.pceToolTipLocation.TabIndex = 16
            AddHandler Me.pceToolTipLocation.QueryDisplayText, New DevExpress.XtraEditors.Controls.QueryDisplayTextEventHandler(AddressOf Me.pceToolTipLocation_QueryDisplayText)
            AddHandler Me.pceToolTipLocation.QueryPopUp, New System.ComponentModel.CancelEventHandler(AddressOf Me.pceToolTipLocation_QueryPopUp)
            ' 
            ' popupContainerControl1
            ' 
            Me.popupContainerControl1.Controls.Add(Me.toolTipLocationControl)
            Me.popupContainerControl1.Location = New System.Drawing.Point(1280, 21)
            Me.popupContainerControl1.Name = "popupContainerControl1"
            Me.popupContainerControl1.Size = New System.Drawing.Size(228, 156)
            Me.popupContainerControl1.TabIndex = 5
            ' 
            ' toolTipLocationControl
            ' 
            Me.toolTipLocationControl.Controller = Me.toolTipController1
            Me.toolTipLocationControl.Location = New System.Drawing.Point(0, 0)
            Me.toolTipLocationControl.Name = "toolTipLocationControl"
            Me.toolTipLocationControl.Size = New System.Drawing.Size(152, 104)
            Me.toolTipLocationControl.TabIndex = 0
            AddHandler Me.toolTipLocationControl.ToolTipLocationChanged, New System.EventHandler(AddressOf Me.toolTipLocationControl_ToolTipLocationChanged)
            ' 
            ' toolTipController1
            ' 
            Me.toolTipController1.Rounded = True
            Me.toolTipController1.ShowBeak = True
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ceShowShadow)
            Me.layoutControl1.Controls.Add(Me.ceShowBeak)
            Me.layoutControl1.Controls.Add(Me.label7)
            Me.layoutControl1.Controls.Add(Me.ceRounded)
            Me.layoutControl1.Controls.Add(Me.seAutoPopDelay)
            Me.layoutControl1.Controls.Add(Me.pceToolTipLocation)
            Me.layoutControl1.Controls.Add(Me.seRoundRadius)
            Me.layoutControl1.Controls.Add(Me.toolTipControllerContentProperties1)
            Me.layoutControl1.Controls.Add(Me.seInitialDelay)
            Me.layoutControl1.Controls.Add(Me.lbSample)
            Me.layoutControl1.Controls.Add(Me.xtraTabControl2)
            Me.layoutControl1.Location = New System.Drawing.Point(42, 22)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(1136, 744)
            Me.layoutControl1.TabIndex = 6
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' ceShowShadow
            ' 
            Me.ceShowShadow.EditValue = Nothing
            Me.ceShowShadow.Location = New System.Drawing.Point(352, 665)
            Me.ceShowShadow.Name = "ceShowShadow"
            Me.ceShowShadow.Properties.Caption = "Show shadow"
            Me.ceShowShadow.Size = New System.Drawing.Size(214, 20)
            Me.ceShowShadow.StyleController = Me.layoutControl1
            Me.ceShowShadow.TabIndex = 14
            AddHandler Me.ceShowShadow.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowShadow_CheckedChanged)
            ' 
            ' ceShowBeak
            ' 
            Me.ceShowBeak.EditValue = Nothing
            Me.ceShowBeak.Location = New System.Drawing.Point(352, 571)
            Me.ceShowBeak.Name = "ceShowBeak"
            Me.ceShowBeak.Properties.Caption = "Show beak"
            Me.ceShowBeak.Size = New System.Drawing.Size(214, 20)
            Me.ceShowBeak.StyleController = Me.layoutControl1
            Me.ceShowBeak.TabIndex = 13
            AddHandler Me.ceShowBeak.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowBeak_CheckedChanged)
            ' 
            ' label7
            ' 
            Me.label7.Location = New System.Drawing.Point(570, 479)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(78, 13)
            Me.label7.StyleController = Me.layoutControl1
            Me.label7.TabIndex = 15
            Me.label7.Text = "ToolTip location:"
            ' 
            ' ceRounded
            ' 
            Me.ceRounded.EditValue = Nothing
            Me.ceRounded.Location = New System.Drawing.Point(352, 475)
            Me.ceRounded.Name = "ceRounded"
            Me.ceRounded.Properties.Caption = "Rounded"
            Me.ceRounded.Size = New System.Drawing.Size(214, 20)
            Me.ceRounded.StyleController = Me.layoutControl1
            Me.ceRounded.TabIndex = 12
            AddHandler Me.ceRounded.CheckedChanged, New System.EventHandler(AddressOf Me.ceRounded_CheckedChanged)
            ' 
            ' seAutoPopDelay
            ' 
            Me.seAutoPopDelay.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.seAutoPopDelay.Location = New System.Drawing.Point(110, 475)
            Me.seAutoPopDelay.Name = "seAutoPopDelay"
            Me.seAutoPopDelay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seAutoPopDelay.Properties.Increment = New Decimal(New Integer() {100, 0, 0, 0})
            Me.seAutoPopDelay.Properties.IsFloatValue = False
            Me.seAutoPopDelay.Properties.Mask.EditMask = "N00"
            Me.seAutoPopDelay.Properties.MaxValue = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.seAutoPopDelay.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.seAutoPopDelay.Size = New System.Drawing.Size(238, 20)
            Me.seAutoPopDelay.StyleController = Me.layoutControl1
            Me.seAutoPopDelay.TabIndex = 9
            AddHandler Me.seAutoPopDelay.EditValueChanged, New System.EventHandler(AddressOf Me.seAutoPopDelay_EditValueChanged)
            ' 
            ' seRoundRadius
            ' 
            Me.seRoundRadius.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.seRoundRadius.Location = New System.Drawing.Point(110, 665)
            Me.seRoundRadius.Name = "seRoundRadius"
            Me.seRoundRadius.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seRoundRadius.Properties.IsFloatValue = False
            Me.seRoundRadius.Properties.Mask.EditMask = "N00"
            Me.seRoundRadius.Properties.MaxValue = New Decimal(New Integer() {15, 0, 0, 0})
            Me.seRoundRadius.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.seRoundRadius.Size = New System.Drawing.Size(238, 20)
            Me.seRoundRadius.StyleController = Me.layoutControl1
            Me.seRoundRadius.TabIndex = 11
            AddHandler Me.seRoundRadius.EditValueChanged, New System.EventHandler(AddressOf Me.seRoundRadius_EditValueChanged)
            ' 
            ' seInitialDelay
            ' 
            Me.seInitialDelay.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.seInitialDelay.Location = New System.Drawing.Point(110, 571)
            Me.seInitialDelay.Name = "seInitialDelay"
            Me.seInitialDelay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seInitialDelay.Properties.Increment = New Decimal(New Integer() {10, 0, 0, 0})
            Me.seInitialDelay.Properties.IsFloatValue = False
            Me.seInitialDelay.Properties.Mask.EditMask = "N00"
            Me.seInitialDelay.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.seInitialDelay.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.seInitialDelay.Size = New System.Drawing.Size(238, 20)
            Me.seInitialDelay.StyleController = Me.layoutControl1
            Me.seInitialDelay.TabIndex = 10
            AddHandler Me.seInitialDelay.EditValueChanged, New System.EventHandler(AddressOf Me.seInitialDelay_EditValueChanged)
            ' 
            ' lbSample
            ' 
            Me.lbSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lbSample.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.lbSample.Location = New System.Drawing.Point(448, 45)
            Me.lbSample.Name = "lbSample"
            Me.lbSample.Size = New System.Drawing.Size(240, 44)
            Me.lbSample.TabIndex = 0
            Me.lbSample.Text = "Hover the mouse cursor over this box to automatically display a tooltip."
            Me.lbSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ' 
            ' xtraTabControl2
            ' 
            Me.xtraTabControl2.Location = New System.Drawing.Point(374, 123)
            Me.xtraTabControl2.Name = "xtraTabControl2"
            Me.xtraTabControl2.SelectedTabPage = Me.xtraTabPage2
            Me.xtraTabControl2.Size = New System.Drawing.Size(750, 261)
            Me.xtraTabControl2.TabIndex = 4
            Me.xtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage2, Me.xtraTabPage3})
            ' 
            ' xtraTabPage2
            ' 
            Me.xtraTabPage2.Controls.Add(Me.propertyGrid1)
            Me.xtraTabPage2.Name = "xtraTabPage2"
            Me.xtraTabPage2.Padding = New System.Windows.Forms.Padding(4)
            Me.xtraTabPage2.Size = New System.Drawing.Size(748, 236)
            Me.xtraTabPage2.Text = "Appearance"
            ' 
            ' propertyGrid1
            ' 
            Me.propertyGrid1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertyGrid1.Location = New System.Drawing.Point(4, 4)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.[True]
            Me.propertyGrid1.Size = New System.Drawing.Size(740, 228)
            Me.propertyGrid1.TabIndex = 0
            ' 
            ' xtraTabPage3
            ' 
            Me.xtraTabPage3.Controls.Add(Me.propertyGrid2)
            Me.xtraTabPage3.Name = "xtraTabPage3"
            Me.xtraTabPage3.Padding = New System.Windows.Forms.Padding(4)
            Me.xtraTabPage3.Size = New System.Drawing.Size(748, 236)
            Me.xtraTabPage3.Text = "AppearanceTitle"
            ' 
            ' propertyGrid2
            ' 
            Me.propertyGrid2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertyGrid2.Location = New System.Drawing.Point(4, 4)
            Me.propertyGrid2.Name = "propertyGrid2"
            Me.propertyGrid2.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.[True]
            Me.propertyGrid2.Size = New System.Drawing.Size(740, 228)
            Me.propertyGrid2.TabIndex = 1
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlItem2, Me.layoutControlGroup3, Me.layoutControlGroup4})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1136, 744)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(1116, 111)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20)
            Me.layoutControlGroup2.Text = "Sample"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.lbSample
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem1.FillControlToClientArea = False
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MaxSize = New System.Drawing.Size(244, 48)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(244, 48)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(1092, 48)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem1.TrimClientAreaToControl = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.xtraTabControl2
            Me.layoutControlItem2.Location = New System.Drawing.Point(347, 111)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(320, 48)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(769, 265)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 111)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(347, 265)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 15, 2, 2)
            Me.layoutControlGroup3.Text = "Content"
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.toolTipControllerContentProperties1
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.MaxSize = New System.Drawing.Size(310, 220)
            Me.layoutControlItem3.MinSize = New System.Drawing.Size(310, 220)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(310, 220)
            Me.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem7, Me.layoutControlItem8, Me.layoutControlItem9, Me.layoutControlItem10, Me.layoutControlItem11, Me.layoutControlItem6})
            Me.layoutControlGroup4.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 376)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition1.Width = 30R
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition2.Width = 20R
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition3.Width = 50R
            Me.layoutControlGroup4.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(New DevExpress.XtraLayout.ColumnDefinition() {columnDefinition1, columnDefinition2, columnDefinition3})
            rowDefinition1.Height = 34R
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent
            rowDefinition2.Height = 33R
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent
            rowDefinition3.Height = 33R
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent
            Me.layoutControlGroup4.OptionsTableLayoutGroup.RowDefinitions.AddRange(New DevExpress.XtraLayout.RowDefinition() {rowDefinition1, rowDefinition2, rowDefinition3})
            Me.layoutControlGroup4.Size = New System.Drawing.Size(1116, 348)
            Me.layoutControlGroup4.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 20, 2)
            Me.layoutControlGroup4.Text = "Options"
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.pceToolTipLocation
            Me.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.layoutControlItem4.Location = New System.Drawing.Point(546, 97)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 2
            Me.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 1
            Me.layoutControlItem4.Size = New System.Drawing.Size(546, 94)
            Me.layoutControlItem4.TextVisible = False
            Me.layoutControlItem4.TrimClientAreaToControl = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.label7
            Me.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.layoutControlItem5.Location = New System.Drawing.Point(546, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 2
            Me.layoutControlItem5.Size = New System.Drawing.Size(546, 97)
            Me.layoutControlItem5.TextVisible = False
            Me.layoutControlItem5.TrimClientAreaToControl = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.seInitialDelay
            Me.layoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 97)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.OptionsTableLayoutItem.RowIndex = 1
            Me.layoutControlItem7.Size = New System.Drawing.Size(328, 94)
            Me.layoutControlItem7.Text = "Initial delay:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(74, 13)
            Me.layoutControlItem7.TrimClientAreaToControl = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.seRoundRadius
            Me.layoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 191)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.OptionsTableLayoutItem.RowIndex = 2
            Me.layoutControlItem8.Size = New System.Drawing.Size(328, 94)
            Me.layoutControlItem8.Text = "Round radius:"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(74, 13)
            Me.layoutControlItem8.TrimClientAreaToControl = False
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.ceRounded
            Me.layoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.layoutControlItem9.Location = New System.Drawing.Point(328, 0)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.OptionsTableLayoutItem.ColumnIndex = 1
            Me.layoutControlItem9.Size = New System.Drawing.Size(218, 97)
            Me.layoutControlItem9.TextVisible = False
            Me.layoutControlItem9.TrimClientAreaToControl = False
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.ceShowBeak
            Me.layoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.layoutControlItem10.Location = New System.Drawing.Point(328, 97)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.OptionsTableLayoutItem.ColumnIndex = 1
            Me.layoutControlItem10.OptionsTableLayoutItem.RowIndex = 1
            Me.layoutControlItem10.Size = New System.Drawing.Size(218, 94)
            Me.layoutControlItem10.TextVisible = False
            Me.layoutControlItem10.TrimClientAreaToControl = False
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.ceShowShadow
            Me.layoutControlItem11.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.layoutControlItem11.Location = New System.Drawing.Point(328, 191)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.OptionsTableLayoutItem.ColumnIndex = 1
            Me.layoutControlItem11.OptionsTableLayoutItem.RowIndex = 2
            Me.layoutControlItem11.Size = New System.Drawing.Size(218, 94)
            Me.layoutControlItem11.TextVisible = False
            Me.layoutControlItem11.TrimClientAreaToControl = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.seAutoPopDelay
            Me.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(328, 97)
            Me.layoutControlItem6.Text = "AutoPop delay:"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(74, 13)
            Me.layoutControlItem6.TrimClientAreaToControl = False
            ' 
            ' toolTipControllerContentProperties2
            ' 
            Me.toolTipControllerContentProperties2.Location = New System.Drawing.Point(24, 156)
            Me.toolTipControllerContentProperties2.Name = "toolTipControllerContentProperties2"
            Me.toolTipControllerContentProperties2.Size = New System.Drawing.Size(306, 216)
            Me.toolTipControllerContentProperties2.TabIndex = 0
            ' 
            ' lbSampleManual
            ' 
            Me.lbSampleManual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lbSampleManual.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.lbSampleManual.Location = New System.Drawing.Point(143, 45)
            Me.lbSampleManual.Name = "lbSampleManual"
            Me.lbSampleManual.Size = New System.Drawing.Size(240, 44)
            Me.lbSampleManual.TabIndex = 0
            Me.lbSampleManual.Text = "Click this box to manually activate a tooltip."
            Me.lbSampleManual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            AddHandler Me.lbSampleManual.MouseDown, New System.Windows.Forms.MouseEventHandler(AddressOf Me.lbSampleManual_MouseDown)
            ' 
            ' lbStyleSample
            ' 
            Me.lbStyleSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lbStyleSample.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.lbStyleSample.Location = New System.Drawing.Point(169, 45)
            Me.lbStyleSample.Name = "lbStyleSample"
            Me.lbStyleSample.Size = New System.Drawing.Size(240, 44)
            Me.lbStyleSample.TabIndex = 0
            Me.lbStyleSample.Text = "Hover the mouse cursor over this box to automatically display a tooltip."
            Me.lbStyleSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ' 
            ' icbType
            ' 
            Me.icbType.Location = New System.Drawing.Point(97, 157)
            Me.icbType.Name = "icbType"
            Me.icbType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbType.Size = New System.Drawing.Size(457, 20)
            Me.icbType.StyleController = Me.layoutControl2
            Me.icbType.TabIndex = 14
            AddHandler Me.icbType.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbType_SelectedIndexChanged)
            ' 
            ' layoutControl2
            ' 
            Me.layoutControl2.AllowCustomization = False
            Me.layoutControl2.Controls.Add(Me.chAllowHTML)
            Me.layoutControl2.Controls.Add(Me.icbType)
            Me.layoutControl2.Controls.Add(Me.lbStyleSample)
            Me.layoutControl2.Location = New System.Drawing.Point(52, 46)
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl2.Root = Me.layoutControlGroup5
            Me.layoutControl2.Size = New System.Drawing.Size(578, 534)
            Me.layoutControl2.TabIndex = 5
            Me.layoutControl2.Text = "layoutControl2"
            ' 
            ' chAllowHTML
            ' 
            Me.chAllowHTML.EditValue = True
            Me.chAllowHTML.Location = New System.Drawing.Point(24, 185)
            Me.chAllowHTML.Name = "chAllowHTML"
            Me.chAllowHTML.Properties.Caption = "Allow HTML text"
            Me.chAllowHTML.Size = New System.Drawing.Size(530, 20)
            Me.chAllowHTML.StyleController = Me.layoutControl2
            Me.chAllowHTML.TabIndex = 13
            AddHandler Me.chAllowHTML.CheckedChanged, New System.EventHandler(AddressOf Me.chAllowHTML_CheckedChanged)
            ' 
            ' layoutControlGroup5
            ' 
            Me.layoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup5.GroupBordersVisible = False
            Me.layoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup6, Me.layoutControlGroup7})
            Me.layoutControlGroup5.Name = "layoutControlGroup5"
            Me.layoutControlGroup5.Size = New System.Drawing.Size(578, 534)
            Me.layoutControlGroup5.TextVisible = False
            ' 
            ' layoutControlGroup6
            ' 
            Me.layoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem13, Me.layoutControlItem14})
            Me.layoutControlGroup6.Location = New System.Drawing.Point(0, 112)
            Me.layoutControlGroup6.Name = "layoutControlGroup6"
            Me.layoutControlGroup6.Size = New System.Drawing.Size(558, 402)
            Me.layoutControlGroup6.Text = "Properties"
            ' 
            ' layoutControlItem13
            ' 
            Me.layoutControlItem13.Control = Me.icbType
            Me.layoutControlItem13.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem13.Name = "layoutControlItem13"
            Me.layoutControlItem13.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem13.Size = New System.Drawing.Size(534, 26)
            Me.layoutControlItem13.Text = "Tooltip type:"
            Me.layoutControlItem13.TextSize = New System.Drawing.Size(61, 13)
            ' 
            ' layoutControlItem14
            ' 
            Me.layoutControlItem14.Control = Me.chAllowHTML
            Me.layoutControlItem14.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem14.Name = "layoutControlItem14"
            Me.layoutControlItem14.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2)
            Me.layoutControlItem14.Size = New System.Drawing.Size(534, 331)
            Me.layoutControlItem14.TextVisible = False
            ' 
            ' layoutControlGroup7
            ' 
            Me.layoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem12, Me.emptySpaceItem1})
            Me.layoutControlGroup7.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup7.Name = "layoutControlGroup7"
            Me.layoutControlGroup7.Size = New System.Drawing.Size(558, 112)
            Me.layoutControlGroup7.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20)
            Me.layoutControlGroup7.Text = "Sample"
            ' 
            ' layoutControlItem12
            ' 
            Me.layoutControlItem12.Control = Me.lbStyleSample
            Me.layoutControlItem12.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem12.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem12.MaxSize = New System.Drawing.Size(244, 48)
            Me.layoutControlItem12.MinSize = New System.Drawing.Size(244, 48)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Size = New System.Drawing.Size(534, 48)
            Me.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem12.TextVisible = False
            Me.layoutControlItem12.TrimClientAreaToControl = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 48)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 1)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(350, 1)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(534, 1)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' layoutControl4
            ' 
            Me.layoutControl4.AllowCustomization = False
            Me.layoutControl4.Controls.Add(Me.checkEditShowBeak)
            Me.layoutControl4.Controls.Add(Me.flyoutLabel)
            Me.layoutControl4.Controls.Add(Me.radioGroupExamples)
            Me.layoutControl4.Location = New System.Drawing.Point(52, 45)
            Me.layoutControl4.Name = "layoutControl4"
            Me.layoutControl4.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl4.Root = Me.layoutControlGroup11
            Me.layoutControl4.Size = New System.Drawing.Size(578, 534)
            Me.layoutControl4.TabIndex = 6
            Me.layoutControl4.Text = "layoutControl4"
            ' 
            ' checkEditShowBeak
            ' 
            Me.checkEditShowBeak.EditValue = True
            Me.checkEditShowBeak.Location = New System.Drawing.Point(24, 159)
            Me.checkEditShowBeak.Name = "checkEditShowBeak"
            Me.checkEditShowBeak.Properties.Caption = "Show beak"
            Me.checkEditShowBeak.Size = New System.Drawing.Size(530, 20)
            Me.checkEditShowBeak.StyleController = Me.layoutControl4
            Me.checkEditShowBeak.TabIndex = 13
            AddHandler Me.checkEditShowBeak.CheckedChanged, New System.EventHandler(AddressOf Me.OnShowBeakChanged)
            ' 
            ' flyoutLabel
            ' 
            Me.flyoutLabel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.flyoutLabel.Appearance.Options.UseFont = True
            Me.flyoutLabel.Appearance.Options.UseTextOptions = True
            Me.flyoutLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.flyoutLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.flyoutLabel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.flyoutLabel.Location = New System.Drawing.Point(169, 45)
            Me.flyoutLabel.Name = "flyoutLabel"
            Me.flyoutLabel.Size = New System.Drawing.Size(240, 44)
            Me.flyoutLabel.StyleController = Me.layoutControl4
            Me.flyoutLabel.TabIndex = 0
            Me.flyoutLabel.Text = "Hover the mouse cursor over this box to automatically display a tooltip."
            Me.flyoutLabel.ToolTipController = Me.flyoutToolTipController
            ' 
            ' flyoutToolTipController
            ' 
            Me.flyoutToolTipController.CloseOnClick = DevExpress.Utils.DefaultBoolean.[False]
            Me.flyoutToolTipController.KeepWhileHovered = True
            Me.flyoutToolTipController.ShowBeak = True
            Me.flyoutToolTipController.ToolTipType = DevExpress.Utils.ToolTipType.Flyout
            AddHandler Me.flyoutToolTipController.GetActiveObjectInfo, New DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(AddressOf Me.OnGetActiveObjectInfo)
            ' 
            ' radioGroupExamples
            ' 
            Me.radioGroupExamples.EditValue = 0
            Me.radioGroupExamples.Location = New System.Drawing.Point(24, 228)
            Me.radioGroupExamples.Name = "radioGroupExamples"
            Me.radioGroupExamples.Properties.Columns = 1
            Me.radioGroupExamples.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Dynamic contents"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Interactive contents")})
            Me.radioGroupExamples.Size = New System.Drawing.Size(530, 282)
            Me.radioGroupExamples.StyleController = Me.layoutControl4
            Me.radioGroupExamples.TabIndex = 14
            ' 
            ' layoutControlGroup11
            ' 
            Me.layoutControlGroup11.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup11.GroupBordersVisible = False
            Me.layoutControlGroup11.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup12, Me.layoutControlGroup13, Me.layoutControlGroup14})
            Me.layoutControlGroup11.Name = "layoutControlGroup5"
            Me.layoutControlGroup11.Size = New System.Drawing.Size(578, 534)
            Me.layoutControlGroup11.TextVisible = False
            ' 
            ' layoutControlGroup12
            ' 
            Me.layoutControlGroup12.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem18})
            Me.layoutControlGroup12.Location = New System.Drawing.Point(0, 112)
            Me.layoutControlGroup12.Name = "layoutControlGroup6"
            Me.layoutControlGroup12.Size = New System.Drawing.Size(558, 71)
            Me.layoutControlGroup12.Text = "Properties"
            ' 
            ' layoutControlItem18
            ' 
            Me.layoutControlItem18.Control = Me.checkEditShowBeak
            Me.layoutControlItem18.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem18.Name = "layoutControlItem18"
            Me.layoutControlItem18.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2)
            Me.layoutControlItem18.Size = New System.Drawing.Size(534, 26)
            Me.layoutControlItem18.TextVisible = False
            ' 
            ' layoutControlGroup13
            ' 
            Me.layoutControlGroup13.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem19, Me.emptySpaceItem2})
            Me.layoutControlGroup13.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup13.Name = "layoutControlGroup7"
            Me.layoutControlGroup13.Size = New System.Drawing.Size(558, 112)
            Me.layoutControlGroup13.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20)
            Me.layoutControlGroup13.Text = "Sample"
            ' 
            ' layoutControlItem19
            ' 
            Me.layoutControlItem19.Control = Me.flyoutLabel
            Me.layoutControlItem19.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem19.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem19.MaxSize = New System.Drawing.Size(244, 48)
            Me.layoutControlItem19.MinSize = New System.Drawing.Size(244, 48)
            Me.layoutControlItem19.Name = "layoutControlItem12"
            Me.layoutControlItem19.Size = New System.Drawing.Size(534, 48)
            Me.layoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem19.TextVisible = False
            Me.layoutControlItem19.TrimClientAreaToControl = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 48)
            Me.emptySpaceItem2.MaxSize = New System.Drawing.Size(0, 1)
            Me.emptySpaceItem2.MinSize = New System.Drawing.Size(350, 1)
            Me.emptySpaceItem2.Name = "emptySpaceItem1"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(534, 1)
            Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' layoutControlGroup14
            ' 
            Me.layoutControlGroup14.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem17})
            Me.layoutControlGroup14.Location = New System.Drawing.Point(0, 183)
            Me.layoutControlGroup14.Name = "layoutControlGroup14"
            Me.layoutControlGroup14.Size = New System.Drawing.Size(558, 331)
            Me.layoutControlGroup14.Text = "Examples"
            ' 
            ' layoutControlItem17
            ' 
            Me.layoutControlItem17.Control = Me.radioGroupExamples
            Me.layoutControlItem17.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem17.Name = "layoutControlItem17"
            Me.layoutControlItem17.Size = New System.Drawing.Size(534, 286)
            Me.layoutControlItem17.TextVisible = False
            ' 
            ' layoutControl3
            ' 
            Me.layoutControl3.AllowCustomization = False
            Me.layoutControl3.Controls.Add(Me.toolTipControllerContentProperties2)
            Me.layoutControl3.Controls.Add(Me.lbSampleManual)
            Me.layoutControl3.Location = New System.Drawing.Point(25, 12)
            Me.layoutControl3.Name = "layoutControl3"
            Me.layoutControl3.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl3.Root = Me.layoutControlGroup8
            Me.layoutControl3.Size = New System.Drawing.Size(527, 599)
            Me.layoutControl3.TabIndex = 3
            Me.layoutControl3.Text = "layoutControl3"
            ' 
            ' layoutControlGroup8
            ' 
            Me.layoutControlGroup8.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup8.GroupBordersVisible = False
            Me.layoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup9, Me.layoutControlGroup10})
            Me.layoutControlGroup8.Name = "layoutControlGroup8"
            Me.layoutControlGroup8.Size = New System.Drawing.Size(527, 599)
            Me.layoutControlGroup8.TextVisible = False
            ' 
            ' layoutControlGroup9
            ' 
            Me.layoutControlGroup9.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem15})
            Me.layoutControlGroup9.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup9.Name = "layoutControlGroup9"
            Me.layoutControlGroup9.Size = New System.Drawing.Size(507, 111)
            Me.layoutControlGroup9.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20)
            Me.layoutControlGroup9.Text = "Sample"
            ' 
            ' layoutControlItem15
            ' 
            Me.layoutControlItem15.Control = Me.lbSampleManual
            Me.layoutControlItem15.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem15.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem15.MaxSize = New System.Drawing.Size(244, 48)
            Me.layoutControlItem15.MinSize = New System.Drawing.Size(244, 48)
            Me.layoutControlItem15.Name = "layoutControlItem15"
            Me.layoutControlItem15.Size = New System.Drawing.Size(483, 48)
            Me.layoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem15.TextVisible = False
            Me.layoutControlItem15.TrimClientAreaToControl = False
            ' 
            ' layoutControlGroup10
            ' 
            Me.layoutControlGroup10.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem16})
            Me.layoutControlGroup10.Location = New System.Drawing.Point(0, 111)
            Me.layoutControlGroup10.Name = "layoutControlGroup10"
            Me.layoutControlGroup10.Size = New System.Drawing.Size(507, 468)
            Me.layoutControlGroup10.Text = "Content"
            ' 
            ' layoutControlItem16
            ' 
            Me.layoutControlItem16.Control = Me.toolTipControllerContentProperties2
            Me.layoutControlItem16.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem16.MaxSize = New System.Drawing.Size(310, 220)
            Me.layoutControlItem16.MinSize = New System.Drawing.Size(310, 220)
            Me.layoutControlItem16.Name = "layoutControlItem16"
            Me.layoutControlItem16.Size = New System.Drawing.Size(483, 423)
            Me.layoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem16.TextVisible = False
            ' 
            ' toolTipStyleController
            ' 
            Me.toolTipStyleController.AllowHtmlText = True
            Me.toolTipStyleController.AutoPopDelay = 8000
            Me.toolTipStyleController.Rounded = True
            Me.toolTipStyleController.ShowBeak = True
            Me.toolTipStyleController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("task", "image://svgimages/outlook inspired/task.svg")
            Me.svgImageCollection1.Add("shipmentawaiting", "image://svgimages/outlook inspired/shipmentawaiting.svg")
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Controls.Add(Me.tabNavigationPage2)
            Me.tabPane1.Controls.Add(Me.tabNavigationPage3)
            Me.tabPane1.Controls.Add(Me.tabNavigationPage4)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(0, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1, Me.tabNavigationPage2, Me.tabNavigationPage3, Me.tabNavigationPage4})
            Me.tabPane1.RegularSize = New System.Drawing.Size(875, 599)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(875, 599)
            Me.tabPane1.TabIndex = 6
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Flyout tooltip"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl4)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(875, 566)
            ' 
            ' tabNavigationPage2
            ' 
            Me.tabNavigationPage2.Caption = "Auto-popup tooltip"
            Me.tabNavigationPage2.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage2.Controls.Add(Me.popupContainerControl1)
            Me.tabNavigationPage2.Name = "tabNavigationPage2"
            Me.tabNavigationPage2.Size = New System.Drawing.Size(829, 554)
            ' 
            ' tabNavigationPage3
            ' 
            Me.tabNavigationPage3.Caption = "ShowHint method"
            Me.tabNavigationPage3.Controls.Add(Me.layoutControl3)
            Me.tabNavigationPage3.Name = "tabNavigationPage3"
            Me.tabNavigationPage3.Size = New System.Drawing.Size(829, 554)
            ' 
            ' tabNavigationPage4
            ' 
            Me.tabNavigationPage4.Caption = "Tooltip Types and Styles"
            Me.tabNavigationPage4.Controls.Add(Me.layoutControl2)
            Me.tabNavigationPage4.Name = "tabNavigationPage4"
            Me.tabNavigationPage4.Size = New System.Drawing.Size(829, 554)
            ' 
            ' ModuleToolTipController
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tabPane1)
            Me.Name = "ModuleToolTipController"
            Me.Size = New System.Drawing.Size(875, 599)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ModuleToolTipController_Load)
            CType((Me.pceToolTipLocation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.popupContainerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupContainerControl1.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ceShowShadow.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowBeak.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceRounded.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seAutoPopDelay.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seRoundRadius.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seInitialDelay.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xtraTabControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl2.ResumeLayout(False)
            Me.xtraTabPage2.ResumeLayout(False)
            CType((Me.propertyGrid1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage3.ResumeLayout(False)
            CType((Me.propertyGrid2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbType.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            CType((Me.chAllowHTML.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl4), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl4.ResumeLayout(False)
            CType((Me.checkEditShowBeak.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radioGroupExamples.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem18), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem19), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl3.ResumeLayout(False)
            CType((Me.layoutControlGroup8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.tabNavigationPage2.ResumeLayout(False)
            Me.tabNavigationPage3.ResumeLayout(False)
            Me.tabNavigationPage4.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private toolTipController1 As DevExpress.Utils.ToolTipController

        Private xtraTabControl2 As DevExpress.XtraTab.XtraTabControl

        Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage

        Private xtraTabPage3 As DevExpress.XtraTab.XtraTabPage

        Private lbSample As System.Windows.Forms.Label

        Private seAutoPopDelay As DevExpress.XtraEditors.SpinEdit

        Private seInitialDelay As DevExpress.XtraEditors.SpinEdit

        Private seRoundRadius As DevExpress.XtraEditors.SpinEdit

        Private ceRounded As DevExpress.XtraEditors.CheckEdit

        Private ceShowBeak As DevExpress.XtraEditors.CheckEdit

        Private ceShowShadow As DevExpress.XtraEditors.CheckEdit

        Private label7 As DevExpress.XtraEditors.LabelControl

        Private pceToolTipLocation As DevExpress.XtraEditors.PopupContainerEdit

        Private popupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl

        Private toolTipLocationControl As EditorsTutorials.Modules.ToolTipLocationControl

        Private propertyGrid1 As DevExpress.XtraVerticalGrid.PropertyGridControl

        Private propertyGrid2 As DevExpress.XtraVerticalGrid.PropertyGridControl

        Private toolTipControllerContentProperties1 As EditorsTutorials.Modules.ToolTipControllerContentProperties

        Private lbSampleManual As System.Windows.Forms.Label

        Private toolTipControllerContentProperties2 As EditorsTutorials.Modules.ToolTipControllerContentProperties

        Private components As System.ComponentModel.IContainer = Nothing

        Private icbType As DevExpress.XtraEditors.ImageComboBoxEdit

        Private chAllowHTML As DevExpress.XtraEditors.CheckEdit

        Private lbStyleSample As System.Windows.Forms.Label

        Private toolTipStyleController As DevExpress.Utils.ToolTipController

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControl2 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControl3 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup9 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup10 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection

        Private layoutControl4 As DevExpress.XtraLayout.LayoutControl

        Private checkEditShowBeak As DevExpress.XtraEditors.CheckEdit

        Private flyoutLabel As DevExpress.XtraEditors.LabelControl

        Private layoutControlGroup11 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup12 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup13 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private radioGroupExamples As DevExpress.XtraEditors.RadioGroup

        Private layoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup14 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem

        Private flyoutToolTipController As DevExpress.Utils.ToolTipController

        Private behaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private tabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private tabNavigationPage3 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private tabNavigationPage4 As DevExpress.XtraBars.Navigation.TabNavigationPage
    End Class
End Namespace
