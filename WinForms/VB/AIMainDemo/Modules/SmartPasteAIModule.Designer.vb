Namespace DevExpress.AI.Demos

    Partial Class SmartPasteAIModule

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
            Dim timeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim columnDefinition1 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition2 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition3 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim rowDefinition1 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition2 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition3 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Me.roundedSkinPanel1 = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.gridTabNavigationPage = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.layoutTabNavigationPage = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.textEdit111 = New DevExpress.XtraEditors.TextEdit()
            Me.textEdit112 = New DevExpress.XtraEditors.TextEdit()
            Me.textEdit1121 = New DevExpress.XtraEditors.TextEdit()
            Me.textEdit11 = New DevExpress.XtraEditors.TextEdit()
            Me.textEdit21 = New DevExpress.XtraEditors.TextEdit()
            Me.textEdit41 = New DevExpress.XtraEditors.TextEdit()
            Me.textEdit31 = New DevExpress.XtraEditors.TextEdit()
            Me.textEdit5 = New DevExpress.XtraEditors.TextEdit()
            Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
            Me.radioGroup1 = New DevExpress.XtraEditors.TextEdit()
            Me.emailEdit1 = New DevExpress.XtraEditors.TextEdit()
            Me.simpleButtonPaste = New DevExpress.XtraEditors.SimpleButton()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.pasteButtonGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.topLayoutGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.schedulerControlTabNavigationPage = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerDataStorage1 = New DevExpress.XtraScheduler.SchedulerDataStorage(Me.components)
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.sidePanel2 = New DevExpress.XtraEditors.SidePanel()
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.simpleButtonCopyGrid = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
            Me.layoutControl3 = New DevExpress.XtraLayout.LayoutControl()
            Me.ucDisclaimerPanel1 = New DevExpress.AI.Demos.ucDisclaimerPanel()
            Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciRoundedSkinPanel1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciUcDisclaimerPanel1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.roundedSkinPanel1.SuspendLayout()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.gridTabNavigationPage.SuspendLayout()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutTabNavigationPage.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.textEdit111.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit112.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit1121.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit11.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit21.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit41.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit31.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit5.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emailEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pasteButtonGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.topLayoutGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.schedulerControlTabNavigationPage.SuspendLayout()
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerDataStorage1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel2.SuspendLayout()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl3.SuspendLayout()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciRoundedSkinPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciUcDisclaimerPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateEdit1.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' roundedSkinPanel1
            ' 
            Me.roundedSkinPanel1.Controls.Add(Me.panelControl1)
            Me.roundedSkinPanel1.Location = New System.Drawing.Point(0, 103)
            Me.roundedSkinPanel1.Name = "roundedSkinPanel1"
            Me.roundedSkinPanel1.Size = New System.Drawing.Size(992, 418)
            Me.roundedSkinPanel1.TabIndex = 3
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.tabPane1)
            Me.panelControl1.Controls.Add(Me.sidePanel1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(17, 17)
            Me.panelControl1.MinimumSize = New System.Drawing.Size(32, 32)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(958, 384)
            Me.panelControl1.TabIndex = 3
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.gridTabNavigationPage)
            Me.tabPane1.Controls.Add(Me.layoutTabNavigationPage)
            Me.tabPane1.Controls.Add(Me.schedulerControlTabNavigationPage)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(300, 0)
            Me.tabPane1.MinimumSize = New System.Drawing.Size(32, 32)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.layoutTabNavigationPage, Me.gridTabNavigationPage, Me.schedulerControlTabNavigationPage})
            Me.tabPane1.RegularSize = New System.Drawing.Size(658, 384)
            Me.tabPane1.SelectedPage = Me.layoutTabNavigationPage
            Me.tabPane1.Size = New System.Drawing.Size(658, 384)
            Me.tabPane1.TabIndex = 2
            Me.tabPane1.Text = "SchedulerControl"
            AddHandler Me.tabPane1.SelectedPageIndexChanged, New System.EventHandler(AddressOf Me.tabPane1_SelectedPageIndexChanged)
            ' 
            ' gridTabNavigationPage
            ' 
            Me.gridTabNavigationPage.Caption = "XtraGrid"
            Me.gridTabNavigationPage.Controls.Add(Me.gridControl1)
            Me.gridTabNavigationPage.Name = "gridTabNavigationPage"
            Me.gridTabNavigationPage.Size = New System.Drawing.Size(658, 343)
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(658, 343)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.behaviorManager1.SetBehaviors(Me.gridView1, New DevExpress.Utils.Behaviors.Behavior() {CType((DevExpress.AIIntegration.WinForms.SmartPasteBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.SmartPasteGridBehaviorSource), Nothing, DevExpress.Utils.DefaultBoolean.[True], "")), DevExpress.Utils.Behaviors.Behavior)})
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            Me.gridView1.OptionsView.ShowGroupPanel = False
            ' 
            ' layoutTabNavigationPage
            ' 
            Me.layoutTabNavigationPage.Caption = "LayoutControl"
            Me.layoutTabNavigationPage.Controls.Add(Me.layoutControl1)
            Me.layoutTabNavigationPage.Name = "layoutTabNavigationPage"
            Me.layoutTabNavigationPage.Size = New System.Drawing.Size(658, 343)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.behaviorManager1.SetBehaviors(Me.layoutControl1, New DevExpress.Utils.Behaviors.Behavior() {CType((DevExpress.AIIntegration.WinForms.SmartPasteBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.SmartPasteLayoutBehaviorSource), Nothing, DevExpress.Utils.DefaultBoolean.[True], "")), DevExpress.Utils.Behaviors.Behavior)})
            Me.layoutControl1.Controls.Add(Me.labelControl2)
            Me.layoutControl1.Controls.Add(Me.textEdit111)
            Me.layoutControl1.Controls.Add(Me.textEdit112)
            Me.layoutControl1.Controls.Add(Me.textEdit1121)
            Me.layoutControl1.Controls.Add(Me.textEdit11)
            Me.layoutControl1.Controls.Add(Me.textEdit21)
            Me.layoutControl1.Controls.Add(Me.textEdit41)
            Me.layoutControl1.Controls.Add(Me.textEdit31)
            Me.layoutControl1.Controls.Add(Me.textEdit5)
            Me.layoutControl1.Controls.Add(Me.textEdit1)
            Me.layoutControl1.Controls.Add(Me.radioGroup1)
            Me.layoutControl1.Controls.Add(Me.emailEdit1)
            Me.layoutControl1.Controls.Add(Me.simpleButtonPaste)
            Me.layoutControl1.Controls.Add(Me.dateEdit1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(909, 302, 922, 730)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(658, 343)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Appearance.Options.UseTextOptions = True
            Me.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl2.Location = New System.Drawing.Point(92, 16)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(221, 26)
            Me.labelControl2.StyleController = Me.layoutControl1
            Me.labelControl2.TabIndex = 19
            Me.labelControl2.Text = "Step 2: Use clipboard text (copied in step 1) to populate the edit form. "
            ' 
            ' textEdit111
            ' 
            Me.textEdit111.Location = New System.Drawing.Point(238, 155)
            Me.textEdit111.Name = "textEdit111"
            Me.textEdit111.Size = New System.Drawing.Size(64, 28)
            Me.textEdit111.StyleController = Me.layoutControl1
            Me.textEdit111.TabIndex = 4
            ' 
            ' textEdit112
            ' 
            Me.textEdit112.Location = New System.Drawing.Point(438, 155)
            Me.textEdit112.Name = "textEdit112"
            Me.textEdit112.Size = New System.Drawing.Size(95, 28)
            Me.textEdit112.StyleController = Me.layoutControl1
            Me.textEdit112.TabIndex = 5
            ' 
            ' textEdit1121
            ' 
            Me.textEdit1121.Location = New System.Drawing.Point(238, 189)
            Me.textEdit1121.Name = "textEdit1121"
            Me.textEdit1121.Size = New System.Drawing.Size(295, 28)
            Me.textEdit1121.StyleController = Me.layoutControl1
            Me.textEdit1121.TabIndex = 6
            ' 
            ' textEdit11
            ' 
            Me.textEdit11.Location = New System.Drawing.Point(238, 310)
            Me.textEdit11.Name = "textEdit11"
            Me.textEdit11.Size = New System.Drawing.Size(295, 28)
            Me.textEdit11.StyleController = Me.layoutControl1
            Me.textEdit11.TabIndex = 10
            ' 
            ' textEdit21
            ' 
            Me.textEdit21.Location = New System.Drawing.Point(238, 344)
            Me.textEdit21.Name = "textEdit21"
            Me.textEdit21.Size = New System.Drawing.Size(295, 28)
            Me.textEdit21.StyleController = Me.layoutControl1
            Me.textEdit21.TabIndex = 11
            ' 
            ' textEdit41
            ' 
            Me.textEdit41.Location = New System.Drawing.Point(238, 412)
            Me.textEdit41.Name = "textEdit41"
            Me.textEdit41.Size = New System.Drawing.Size(64, 28)
            Me.textEdit41.StyleController = Me.layoutControl1
            Me.textEdit41.TabIndex = 12
            ' 
            ' textEdit31
            ' 
            Me.textEdit31.Location = New System.Drawing.Point(238, 378)
            Me.textEdit31.Name = "textEdit31"
            Me.textEdit31.Size = New System.Drawing.Size(295, 28)
            Me.textEdit31.StyleController = Me.layoutControl1
            Me.textEdit31.TabIndex = 13
            ' 
            ' textEdit5
            ' 
            Me.textEdit5.Location = New System.Drawing.Point(438, 412)
            Me.textEdit5.Name = "textEdit5"
            Me.textEdit5.Size = New System.Drawing.Size(95, 28)
            Me.textEdit5.StyleController = Me.layoutControl1
            Me.textEdit5.TabIndex = 14
            ' 
            ' textEdit1
            ' 
            Me.textEdit1.Location = New System.Drawing.Point(469, 16)
            Me.textEdit1.Name = "textEdit1"
            Me.textEdit1.Size = New System.Drawing.Size(80, 28)
            Me.textEdit1.StyleController = Me.layoutControl1
            Me.textEdit1.TabIndex = 15
            ' 
            ' radioGroup1
            ' 
            Me.radioGroup1.Location = New System.Drawing.Point(469, 84)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Size = New System.Drawing.Size(80, 28)
            Me.radioGroup1.StyleController = Me.layoutControl1
            Me.radioGroup1.TabIndex = 16
            ' 
            ' emailEdit1
            ' 
            Me.emailEdit1.EditValue = ""
            Me.emailEdit1.Location = New System.Drawing.Point(238, 223)
            Me.emailEdit1.MaximumSize = New System.Drawing.Size(400, 0)
            Me.emailEdit1.MinimumSize = New System.Drawing.Size(250, 0)
            Me.emailEdit1.Name = "emailEdit1"
            Me.emailEdit1.Size = New System.Drawing.Size(295, 28)
            Me.emailEdit1.StyleController = Me.layoutControl1
            Me.emailEdit1.TabIndex = 7
            ' 
            ' simpleButtonPaste
            ' 
            Me.simpleButtonPaste.AutoWidthInLayoutControl = True
            Me.simpleButtonPaste.Location = New System.Drawing.Point(92, 48)
            Me.simpleButtonPaste.Name = "simpleButtonPaste"
            Me.simpleButtonPaste.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.simpleButtonPaste.Size = New System.Drawing.Size(171, 28)
            Me.simpleButtonPaste.StyleController = Me.layoutControl1
            Me.simpleButtonPaste.TabIndex = 18
            Me.simpleButtonPaste.Text = "AI-powered Smart Paste"
            AddHandler Me.simpleButtonPaste.Click, New System.EventHandler(AddressOf Me.simpleButtonPaste_Click)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup3, Me.emptySpaceItem5, Me.emptySpaceItem6})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(641, 482)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupBordersVisible = False
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.pasteButtonGroup, Me.topLayoutGroup, Me.layoutControlGroup1, Me.layoutControlGroup2, Me.emptySpaceItem2})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(76, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(463, 456)
            ' 
            ' pasteButtonGroup
            ' 
            Me.pasteButtonGroup.GroupBordersVisible = False
            Me.pasteButtonGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem11, Me.layoutControlItem9, Me.emptySpaceItem3})
            Me.pasteButtonGroup.Location = New System.Drawing.Point(0, 0)
            Me.pasteButtonGroup.Name = "pasteButtonGroup"
            Me.pasteButtonGroup.Size = New System.Drawing.Size(227, 102)
            Me.pasteButtonGroup.TextVisible = False
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.labelControl2
            Me.layoutControlItem11.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Size = New System.Drawing.Size(227, 32)
            Me.layoutControlItem11.TextVisible = False
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.simpleButtonPaste
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 32)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(227, 34)
            Me.layoutControlItem9.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 50, 0, 0)
            Me.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem9.TextVisible = False
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 66)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(227, 36)
            ' 
            ' topLayoutGroup
            ' 
            Me.topLayoutGroup.GroupBordersVisible = False
            Me.topLayoutGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem12, Me.layoutControlItem14, Me.layoutControlItem13, Me.emptySpaceItem1})
            Me.topLayoutGroup.Location = New System.Drawing.Point(227, 0)
            Me.topLayoutGroup.Name = "topLayoutGroup"
            Me.topLayoutGroup.Size = New System.Drawing.Size(236, 102)
            Me.topLayoutGroup.TextVisible = False
            ' 
            ' layoutControlItem12
            ' 
            Me.layoutControlItem12.Control = Me.textEdit1
            Me.layoutControlItem12.Location = New System.Drawing.Point(20, 0)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Size = New System.Drawing.Size(216, 34)
            Me.layoutControlItem12.Text = "Amount Due"
            Me.layoutControlItem12.TextSize = New System.Drawing.Size(114, 13)
            ' 
            ' layoutControlItem14
            ' 
            Me.layoutControlItem14.Control = Me.dateEdit1
            Me.layoutControlItem14.Location = New System.Drawing.Point(20, 34)
            Me.layoutControlItem14.Name = "layoutControlItem14"
            Me.layoutControlItem14.Size = New System.Drawing.Size(216, 34)
            Me.layoutControlItem14.Text = "Statement Date"
            Me.layoutControlItem14.TextSize = New System.Drawing.Size(114, 13)
            ' 
            ' layoutControlItem13
            ' 
            Me.layoutControlItem13.Control = Me.radioGroup1
            Me.layoutControlItem13.Location = New System.Drawing.Point(20, 68)
            Me.layoutControlItem13.Name = "layoutControlItem13"
            Me.layoutControlItem13.Size = New System.Drawing.Size(216, 34)
            Me.layoutControlItem13.Text = "Account Number"
            Me.layoutControlItem13.TextSize = New System.Drawing.Size(114, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 0)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(20, 0)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(20, 10)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(20, 102)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.AllowHtmlStringInCaption = True
            Me.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Light
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem6, Me.layoutControlItem8, Me.layoutControlItem10, Me.layoutControlItem7})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 102)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(463, 155)
            Me.layoutControlGroup1.Text = "<b>Billing Information</b>"
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem6.Control = Me.textEdit111
            Me.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.layoutControlItem6.CustomizationFormText = "First Name:"
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(200, 34)
            Me.layoutControlItem6.Text = "First Name"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(114, 13)
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem8.Control = Me.textEdit1121
            Me.layoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.layoutControlItem8.CustomizationFormText = "Phone Number"
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 34)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(431, 34)
            Me.layoutControlItem8.Text = "Phone Number"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(114, 13)
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.emailEdit1
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 68)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(431, 34)
            Me.layoutControlItem10.Text = "Email"
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(114, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem7.Control = Me.textEdit112
            Me.layoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.layoutControlItem7.CustomizationFormText = "Last Name:"
            Me.layoutControlItem7.Location = New System.Drawing.Point(200, 0)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(231, 34)
            Me.layoutControlItem7.Text = "Last Name"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(114, 13)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.AllowHtmlStringInCaption = True
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem5, Me.layoutControlItem4})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 257)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(463, 189)
            Me.layoutControlGroup2.Text = "<b>Billing Address</b>"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem1.Control = Me.textEdit11
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.layoutControlItem1.CustomizationFormText = "Address line 1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(431, 34)
            Me.layoutControlItem1.Text = "Line 1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(114, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem2.Control = Me.textEdit21
            Me.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.layoutControlItem2.CustomizationFormText = "Address line 2:"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 34)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(431, 34)
            Me.layoutControlItem2.Text = "Line 2"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(114, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem3.Control = Me.textEdit31
            Me.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.layoutControlItem3.CustomizationFormText = "City:"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 68)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(431, 34)
            Me.layoutControlItem3.Text = "City"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(114, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem5.Control = Me.textEdit5
            Me.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.layoutControlItem5.CustomizationFormText = "ZIP"
            Me.layoutControlItem5.Location = New System.Drawing.Point(200, 102)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(231, 34)
            Me.layoutControlItem5.Text = "ZIP"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(114, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem4.Control = Me.textEdit41
            Me.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.layoutControlItem4.CustomizationFormText = "State/Province/Region"
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 102)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(200, 34)
            Me.layoutControlItem4.Text = "State/Province/Region"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(114, 13)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 446)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(463, 10)
            ' 
            ' emptySpaceItem5
            ' 
            Me.emptySpaceItem5.Location = New System.Drawing.Point(0, 0)
            Me.emptySpaceItem5.Name = "emptySpaceItem5"
            Me.emptySpaceItem5.Size = New System.Drawing.Size(76, 456)
            ' 
            ' emptySpaceItem6
            ' 
            Me.emptySpaceItem6.Location = New System.Drawing.Point(539, 0)
            Me.emptySpaceItem6.Name = "emptySpaceItem6"
            Me.emptySpaceItem6.Size = New System.Drawing.Size(76, 456)
            ' 
            ' schedulerControlTabNavigationPage
            ' 
            Me.schedulerControlTabNavigationPage.Caption = "SchedulerControl"
            Me.schedulerControlTabNavigationPage.Controls.Add(Me.schedulerControl1)
            Me.schedulerControlTabNavigationPage.Name = "schedulerControlTabNavigationPage"
            Me.schedulerControlTabNavigationPage.Size = New System.Drawing.Size(658, 343)
            ' 
            ' schedulerControl1
            ' 
            Me.behaviorManager1.SetBehaviors(Me.schedulerControl1, New DevExpress.Utils.Behaviors.Behavior() {CType((DevExpress.AIIntegration.WinForms.SmartPasteSchedulerBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.SmartPasteSchedulerBehaviorSource), Nothing, DevExpress.Utils.DefaultBoolean.[True], "")), DevExpress.Utils.Behaviors.Behavior)})
            Me.schedulerControl1.DataStorage = Me.schedulerDataStorage1
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(658, 343)
            Me.schedulerControl1.Start = New System.DateTime(2025, 9, 16, 0, 0, 0, 0)
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.FullWeekView.Enabled = True
            Me.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2)
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3)
            Me.schedulerControl1.Views.YearView.UseOptimizedScrolling = False
            ' 
            ' schedulerDataStorage1
            ' 
            ' 
            ' 
            ' 
            Me.schedulerDataStorage1.AppointmentDependencies.AutoReload = False
            ' 
            ' 
            ' 
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window)
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((194)))))), (CInt(((CByte((190))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", System.Drawing.Color.FromArgb((CInt(((CByte((168)))))), (CInt(((CByte((213)))))), (CInt(((CByte((255))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", System.Drawing.Color.FromArgb((CInt(((CByte((193)))))), (CInt(((CByte((244)))))), (CInt(((CByte((156))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((228)))))), (CInt(((CByte((199))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", System.Drawing.Color.FromArgb((CInt(((CByte((244)))))), (CInt(((CByte((206)))))), (CInt(((CByte((147))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", System.Drawing.Color.FromArgb((CInt(((CByte((199)))))), (CInt(((CByte((244)))))), (CInt(((CByte((255))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", System.Drawing.Color.FromArgb((CInt(((CByte((207)))))), (CInt(((CByte((219)))))), (CInt(((CByte((152))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", System.Drawing.Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((207)))))), (CInt(((CByte((233))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", System.Drawing.Color.FromArgb((CInt(((CByte((141)))))), (CInt(((CByte((233)))))), (CInt(((CByte((223))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((247)))))), (CInt(((CByte((165))))))))
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.memoEdit1)
            Me.sidePanel1.Controls.Add(Me.sidePanel2)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.sidePanel1.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel1.MaximumSize = New System.Drawing.Size(500, 0)
            Me.sidePanel1.MinimumSize = New System.Drawing.Size(300, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(300, 384)
            Me.sidePanel1.TabIndex = 0
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.memoEdit1.Location = New System.Drawing.Point(0, 106)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.memoEdit1.Properties.[ReadOnly] = True
            Me.memoEdit1.Properties.UseReadOnlyAppearance = False
            Me.memoEdit1.Size = New System.Drawing.Size(299, 278)
            Me.memoEdit1.TabIndex = 0
            ' 
            ' sidePanel2
            ' 
            Me.sidePanel2.Controls.Add(Me.layoutControl2)
            Me.sidePanel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.sidePanel2.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel2.Name = "sidePanel2"
            Me.sidePanel2.Size = New System.Drawing.Size(299, 106)
            Me.sidePanel2.TabIndex = 5
            Me.sidePanel2.Text = "sidePanel2"
            ' 
            ' layoutControl2
            ' 
            Me.layoutControl2.AllowCustomization = False
            Me.layoutControl2.Controls.Add(Me.labelControl3)
            Me.layoutControl2.Controls.Add(Me.simpleButtonCopyGrid)
            Me.layoutControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.layoutControl2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(639, 0, 807, 791)
            Me.layoutControl2.Root = Me.layoutControlGroup4
            Me.layoutControl2.Size = New System.Drawing.Size(299, 98)
            Me.layoutControl2.TabIndex = 4
            Me.layoutControl2.Text = "layoutControl2"
            ' 
            ' labelControl3
            ' 
            Me.labelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.labelControl3.Appearance.Options.UseTextOptions = True
            Me.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Center
            Me.labelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
            Me.labelControl3.Location = New System.Drawing.Point(16, 16)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(267, 26)
            Me.labelControl3.StyleController = Me.layoutControl2
            Me.labelControl3.TabIndex = 0
            Me.labelControl3.Text = "Step 1: Copy Memo Editor text (you can modify memo text as desired)."
            ' 
            ' simpleButtonCopyGrid
            ' 
            Me.simpleButtonCopyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.simpleButtonCopyGrid.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question
            Me.simpleButtonCopyGrid.Appearance.Options.UseBackColor = True
            Me.simpleButtonCopyGrid.AutoWidthInLayoutControl = True
            Me.simpleButtonCopyGrid.Location = New System.Drawing.Point(100, 54)
            Me.simpleButtonCopyGrid.Name = "simpleButtonCopyGrid"
            Me.simpleButtonCopyGrid.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.simpleButtonCopyGrid.Size = New System.Drawing.Size(98, 28)
            Me.simpleButtonCopyGrid.StyleController = Me.layoutControl2
            Me.simpleButtonCopyGrid.TabIndex = 1
            Me.simpleButtonCopyGrid.Text = "Copy Text"
            AddHandler Me.simpleButtonCopyGrid.Click, New System.EventHandler(AddressOf Me.simpleButtonCopy_Click)
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup4.GroupBordersVisible = False
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem15, Me.layoutControlItem16})
            Me.layoutControlGroup4.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            Me.layoutControlGroup4.Name = "Root"
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition1.Width = 50R
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize
            columnDefinition2.Width = 104R
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition3.Width = 50R
            Me.layoutControlGroup4.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(New DevExpress.XtraLayout.ColumnDefinition() {columnDefinition1, columnDefinition2, columnDefinition3})
            rowDefinition1.Height = 32R
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition2.Height = 100R
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent
            rowDefinition3.Height = 34R
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.AutoSize
            Me.layoutControlGroup4.OptionsTableLayoutGroup.RowDefinitions.AddRange(New DevExpress.XtraLayout.RowDefinition() {rowDefinition1, rowDefinition2, rowDefinition3})
            Me.layoutControlGroup4.Size = New System.Drawing.Size(299, 98)
            Me.layoutControlGroup4.TextVisible = False
            ' 
            ' layoutControlItem15
            ' 
            Me.layoutControlItem15.Control = Me.labelControl3
            Me.layoutControlItem15.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem15.Name = "layoutControlItem15"
            Me.layoutControlItem15.OptionsTableLayoutItem.ColumnSpan = 3
            Me.layoutControlItem15.Size = New System.Drawing.Size(273, 32)
            Me.layoutControlItem15.TextVisible = False
            ' 
            ' layoutControlItem16
            ' 
            Me.layoutControlItem16.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.layoutControlItem16.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControlItem16.Control = Me.simpleButtonCopyGrid
            Me.layoutControlItem16.Location = New System.Drawing.Point(84, 38)
            Me.layoutControlItem16.Name = "layoutControlItem16"
            Me.layoutControlItem16.OptionsTableLayoutItem.ColumnIndex = 1
            Me.layoutControlItem16.OptionsTableLayoutItem.RowIndex = 2
            Me.layoutControlItem16.Size = New System.Drawing.Size(104, 34)
            Me.layoutControlItem16.TextVisible = False
            ' 
            ' layoutControl3
            ' 
            Me.layoutControl3.AllowCustomization = False
            Me.layoutControl3.Controls.Add(Me.ucDisclaimerPanel1)
            Me.layoutControl3.Controls.Add(Me.roundedSkinPanel1)
            Me.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl3.Name = "layoutControl3"
            Me.layoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1039, 230, 650, 596)
            Me.layoutControl3.Root = Me.layoutControlGroup5
            Me.layoutControl3.Size = New System.Drawing.Size(992, 521)
            Me.layoutControl3.TabIndex = 4
            Me.layoutControl3.Text = "layoutControl3"
            ' 
            ' ucDisclaimerPanel1
            ' 
            Me.ucDisclaimerPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.ucDisclaimerPanel1.Location = New System.Drawing.Point(0, 0)
            Me.ucDisclaimerPanel1.Name = "ucDisclaimerPanel1"
            Me.ucDisclaimerPanel1.Size = New System.Drawing.Size(992, 103)
            Me.ucDisclaimerPanel1.TabIndex = 7
            ' 
            ' layoutControlGroup5
            ' 
            Me.layoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup5.GroupBordersVisible = False
            Me.layoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciRoundedSkinPanel1, Me.lciUcDisclaimerPanel1})
            Me.layoutControlGroup5.Name = "Root"
            Me.layoutControlGroup5.Size = New System.Drawing.Size(992, 521)
            Me.layoutControlGroup5.TextVisible = False
            ' 
            ' lciRoundedSkinPanel1
            ' 
            Me.lciRoundedSkinPanel1.Control = Me.roundedSkinPanel1
            Me.lciRoundedSkinPanel1.Location = New System.Drawing.Point(0, 103)
            Me.lciRoundedSkinPanel1.Name = "lciRoundedSkinPanel1"
            Me.lciRoundedSkinPanel1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lciRoundedSkinPanel1.Size = New System.Drawing.Size(992, 418)
            Me.lciRoundedSkinPanel1.TextVisible = False
            ' 
            ' lciUcDisclaimerPanel1
            ' 
            Me.lciUcDisclaimerPanel1.Control = Me.ucDisclaimerPanel1
            Me.lciUcDisclaimerPanel1.Location = New System.Drawing.Point(0, 0)
            Me.lciUcDisclaimerPanel1.Name = "lciUcDisclaimerPanel1"
            Me.lciUcDisclaimerPanel1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lciUcDisclaimerPanel1.Size = New System.Drawing.Size(992, 103)
            Me.lciUcDisclaimerPanel1.TextVisible = False
            ' 
            ' dateEdit1
            ' 
            Me.dateEdit1.EditValue = Nothing
            Me.dateEdit1.Location = New System.Drawing.Point(469, 50)
            Me.dateEdit1.Name = "dateEdit1"
            Me.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit1.Properties.DisplayFormat.FormatString = ""
            Me.dateEdit1.Properties.EditFormat.FormatString = ""
            Me.dateEdit1.Properties.MaskSettings.[Set]("mask", "d")
            Me.dateEdit1.Properties.MaskSettings.[Set]("MaskManagerType", GetType(DevExpress.Data.Mask.DateOnlyMaskManager))
            Me.dateEdit1.Properties.MaskSettings.[Set]("MaskManagerSignature", "allowNull=False")
            Me.dateEdit1.Size = New System.Drawing.Size(80, 28)
            Me.dateEdit1.StyleController = Me.layoutControl1
            Me.dateEdit1.TabIndex = 17
            ' 
            ' SmartPasteAIModule
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl3)
            Me.Name = "SmartPasteAIModule"
            Me.Size = New System.Drawing.Size(992, 521)
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.roundedSkinPanel1.ResumeLayout(False)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.gridTabNavigationPage.ResumeLayout(False)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutTabNavigationPage.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.textEdit111.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit112.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit1121.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit11.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit21.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit41.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit31.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit5.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emailEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pasteButtonGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.topLayoutGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem6), System.ComponentModel.ISupportInitialize).EndInit()
            Me.schedulerControlTabNavigationPage.ResumeLayout(False)
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerDataStorage1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel2.ResumeLayout(False)
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl3.ResumeLayout(False)
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciRoundedSkinPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciUcDisclaimerPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateEdit1.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private behaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private textEdit11 As DevExpress.XtraEditors.TextEdit

        Private textEdit21 As DevExpress.XtraEditors.TextEdit

        Private textEdit31 As DevExpress.XtraEditors.TextEdit

        Private textEdit41 As DevExpress.XtraEditors.TextEdit

        Private textEdit5 As DevExpress.XtraEditors.TextEdit

        Private textEdit111 As DevExpress.XtraEditors.TextEdit

        Private textEdit112 As DevExpress.XtraEditors.TextEdit

        Private textEdit1121 As DevExpress.XtraEditors.TextEdit

        Private textEdit1 As DevExpress.XtraEditors.TextEdit

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private gridTabNavigationPage As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutTabNavigationPage As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private radioGroup1 As DevExpress.XtraEditors.TextEdit

        Private emailEdit1 As DevExpress.XtraEditors.TextEdit

        Private layoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

        Private pasteButtonGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private topLayoutGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private labelControl3 As DevExpress.XtraEditors.LabelControl

        Private simpleButtonCopyGrid As DevExpress.XtraEditors.SimpleButton

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControl2 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem

        Private sidePanel2 As DevExpress.XtraEditors.SidePanel

        Private simpleButtonPaste As DevExpress.XtraEditors.SimpleButton

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private roundedSkinPanel1 As DevExpress.XtraEditors.RoundedSkinPanel

        Private layoutControl3 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup

        Private lciRoundedSkinPanel1 As DevExpress.XtraLayout.LayoutControlItem

        Private ucDisclaimerPanel1 As DevExpress.AI.Demos.ucDisclaimerPanel

        Private lciUcDisclaimerPanel1 As DevExpress.XtraLayout.LayoutControlItem

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private schedulerControlTabNavigationPage As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl

        Private schedulerDataStorage1 As DevExpress.XtraScheduler.SchedulerDataStorage

        Private dateEdit1 As DevExpress.XtraEditors.DateEdit
    End Class
End Namespace
