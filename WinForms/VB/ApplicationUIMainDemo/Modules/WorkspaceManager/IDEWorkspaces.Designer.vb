Namespace DevExpress.ApplicationUI.Demos

    Partial Class IDEWorkspaces

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
            Dim combTransition1 As DevExpress.Utils.Animation.CombTransition = New DevExpress.Utils.Animation.CombTransition()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.ApplicationUI.Demos.IDEWorkspaces))
            Dim dockingContainer1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
            Me.documentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
            Me.document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.document2 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.document3 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
            Me.barWorkspaceMenuItem1 = New DevExpress.XtraBars.BarWorkspaceMenuItem()
            Me.workspaceManager1 = New DevExpress.Utils.WorkspaceManager(Me.components)
            Me.barToggleSwitchItem1 = New DevExpress.XtraBars.BarToggleSwitchItem()
            Me.bar3 = New DevExpress.XtraBars.Bar()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
            Me.toolboxSvgImages = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.ucSolutionExplorer1 = New DevExpress.ApplicationUI.Demos.ucSolutionExplorer()
            Me.dockPanel4 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel4_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.ucOutput1 = New DevExpress.ApplicationUI.Demos.ucOutput()
            Me.tabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            CType((Me.documentGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.document1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.document2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.document3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel1_Container.SuspendLayout()
            CType((Me.navBarControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.toolboxSvgImages), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelContainer1.SuspendLayout()
            Me.dockPanel3.SuspendLayout()
            Me.dockPanel2.SuspendLayout()
            Me.dockPanel2_Container.SuspendLayout()
            Me.dockPanel4.SuspendLayout()
            Me.dockPanel4_Container.SuspendLayout()
            CType((Me.tabbedView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' documentGroup1
            ' 
            Me.documentGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.document1, Me.document2, Me.document3})
            ' 
            ' document1
            ' 
            Me.document1.Caption = "File.cs"
            Me.document1.ControlName = "document1"
            Me.document1.ControlTypeName = Nothing
            ' 
            ' document2
            ' 
            Me.document2.Caption = "ucToolBox.cs"
            Me.document2.ControlName = "document2"
            Me.document2.ControlTypeName = Nothing
            ' 
            ' document3
            ' 
            Me.document3.Caption = "ucMain.cs"
            Me.document3.ControlName = "document3"
            Me.document3.ControlTypeName = Nothing
            ' 
            ' documentManager1
            ' 
            Me.documentManager1.ContainerControl = Me
            Me.documentManager1.MenuManager = Me.barManager1
            Me.documentManager1.View = Me.tabbedView1
            Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.tabbedView1})
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.bar3})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.DockManager = Me.dockManager1
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barButtonItem4, Me.barButtonItem5, Me.barButtonItem6, Me.barButtonItem7, Me.barButtonItem8, Me.barButtonItem9, Me.barButtonItem10, Me.barButtonItem11, Me.barButtonItem12, Me.barButtonItem13, Me.barWorkspaceMenuItem1, Me.barToggleSwitchItem1})
            Me.barManager1.MainMenu = Me.bar2
            Me.barManager1.MaxItemId = 16
            Me.barManager1.StatusBar = Me.bar3
            ' 
            ' bar1
            ' 
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 1
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem12, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem13)})
            Me.bar1.Text = "Tools"
            ' 
            ' barButtonItem5
            ' 
            Me.barButtonItem5.Caption = "New File"
            Me.barButtonItem5.Id = 4
            Me.barButtonItem5.ImageOptions.Image = CType((resources.GetObject("barButtonItem5.ImageOptions.Image")), System.Drawing.Image)
            Me.barButtonItem5.ImageOptions.LargeImage = CType((resources.GetObject("barButtonItem5.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.barButtonItem5.ImageOptions.SvgImage = Global.DevExpress.ApplicationUI.Demos.Properties.Resources._new
            Me.barButtonItem5.Name = "barButtonItem5"
            ' 
            ' barButtonItem6
            ' 
            Me.barButtonItem6.Caption = "Open"
            Me.barButtonItem6.Id = 5
            Me.barButtonItem6.ImageOptions.Image = CType((resources.GetObject("barButtonItem6.ImageOptions.Image")), System.Drawing.Image)
            Me.barButtonItem6.ImageOptions.LargeImage = CType((resources.GetObject("barButtonItem6.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.barButtonItem6.ImageOptions.SvgImage = Global.DevExpress.ApplicationUI.Demos.Properties.Resources.open
            Me.barButtonItem6.Name = "barButtonItem6"
            ' 
            ' barButtonItem7
            ' 
            Me.barButtonItem7.Caption = "Save"
            Me.barButtonItem7.Id = 6
            Me.barButtonItem7.ImageOptions.Image = CType((resources.GetObject("barButtonItem7.ImageOptions.Image")), System.Drawing.Image)
            Me.barButtonItem7.ImageOptions.LargeImage = CType((resources.GetObject("barButtonItem7.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.barButtonItem7.ImageOptions.SvgImage = Global.DevExpress.ApplicationUI.Demos.Properties.Resources.save
            Me.barButtonItem7.Name = "barButtonItem7"
            ' 
            ' barButtonItem8
            ' 
            Me.barButtonItem8.Caption = "Print"
            Me.barButtonItem8.Id = 7
            Me.barButtonItem8.ImageOptions.Image = CType((resources.GetObject("barButtonItem8.ImageOptions.Image")), System.Drawing.Image)
            Me.barButtonItem8.ImageOptions.LargeImage = CType((resources.GetObject("barButtonItem8.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.barButtonItem8.ImageOptions.SvgImage = Global.DevExpress.ApplicationUI.Demos.Properties.Resources.print
            Me.barButtonItem8.Name = "barButtonItem8"
            ' 
            ' barButtonItem9
            ' 
            Me.barButtonItem9.Caption = "Cut"
            Me.barButtonItem9.Id = 8
            Me.barButtonItem9.ImageOptions.Image = CType((resources.GetObject("barButtonItem9.ImageOptions.Image")), System.Drawing.Image)
            Me.barButtonItem9.ImageOptions.LargeImage = CType((resources.GetObject("barButtonItem9.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.barButtonItem9.ImageOptions.SvgImage = Global.DevExpress.ApplicationUI.Demos.Properties.Resources.cut
            Me.barButtonItem9.Name = "barButtonItem9"
            ' 
            ' barButtonItem10
            ' 
            Me.barButtonItem10.Caption = "Copy"
            Me.barButtonItem10.Id = 9
            Me.barButtonItem10.ImageOptions.Image = CType((resources.GetObject("barButtonItem10.ImageOptions.Image")), System.Drawing.Image)
            Me.barButtonItem10.ImageOptions.LargeImage = CType((resources.GetObject("barButtonItem10.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.barButtonItem10.ImageOptions.SvgImage = Global.DevExpress.ApplicationUI.Demos.Properties.Resources.copy
            Me.barButtonItem10.Name = "barButtonItem10"
            ' 
            ' barButtonItem11
            ' 
            Me.barButtonItem11.Caption = "Paste"
            Me.barButtonItem11.Id = 10
            Me.barButtonItem11.ImageOptions.Image = CType((resources.GetObject("barButtonItem11.ImageOptions.Image")), System.Drawing.Image)
            Me.barButtonItem11.ImageOptions.LargeImage = CType((resources.GetObject("barButtonItem11.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.barButtonItem11.ImageOptions.SvgImage = Global.DevExpress.ApplicationUI.Demos.Properties.Resources.pastespecial
            Me.barButtonItem11.Name = "barButtonItem11"
            ' 
            ' barButtonItem12
            ' 
            Me.barButtonItem12.Caption = "Undo"
            Me.barButtonItem12.Id = 11
            Me.barButtonItem12.ImageOptions.Image = CType((resources.GetObject("barButtonItem12.ImageOptions.Image")), System.Drawing.Image)
            Me.barButtonItem12.ImageOptions.LargeImage = CType((resources.GetObject("barButtonItem12.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.barButtonItem12.ImageOptions.SvgImage = Global.DevExpress.ApplicationUI.Demos.Properties.Resources.undo
            Me.barButtonItem12.Name = "barButtonItem12"
            ' 
            ' barButtonItem13
            ' 
            Me.barButtonItem13.Caption = "Redo"
            Me.barButtonItem13.Id = 12
            Me.barButtonItem13.ImageOptions.Image = CType((resources.GetObject("barButtonItem13.ImageOptions.Image")), System.Drawing.Image)
            Me.barButtonItem13.ImageOptions.LargeImage = CType((resources.GetObject("barButtonItem13.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.barButtonItem13.ImageOptions.SvgImage = Global.DevExpress.ApplicationUI.Demos.Properties.Resources.redo
            Me.barButtonItem13.Name = "barButtonItem13"
            ' 
            ' bar2
            ' 
            Me.bar2.BarName = "Main menu"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.barWorkspaceMenuItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barToggleSwitchItem1)})
            Me.bar2.OptionsBar.MultiLine = True
            Me.bar2.OptionsBar.UseWholeRow = True
            Me.bar2.Text = "Main menu"
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "File"
            Me.barButtonItem1.Id = 0
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Caption = "Edit"
            Me.barButtonItem2.Id = 1
            Me.barButtonItem2.Name = "barButtonItem2"
            ' 
            ' barButtonItem3
            ' 
            Me.barButtonItem3.Caption = "Toolbars"
            Me.barButtonItem3.Id = 2
            Me.barButtonItem3.Name = "barButtonItem3"
            ' 
            ' barButtonItem4
            ' 
            Me.barButtonItem4.Caption = "Help"
            Me.barButtonItem4.Id = 3
            Me.barButtonItem4.Name = "barButtonItem4"
            ' 
            ' barWorkspaceMenuItem1
            ' 
            Me.barWorkspaceMenuItem1.Caption = "Workspaces"
            Me.barWorkspaceMenuItem1.Id = 14
            Me.barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1"
            Me.barWorkspaceMenuItem1.ShowSaveLoadCommands = True
            Me.barWorkspaceMenuItem1.WorkspaceManager = Me.workspaceManager1
            ' 
            ' workspaceManager1
            ' 
            Me.workspaceManager1.TargetControl = Me
            Me.workspaceManager1.TransitionType = combTransition1
            ' 
            ' barToggleSwitchItem1
            ' 
            Me.barToggleSwitchItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.barToggleSwitchItem1.BindableChecked = True
            Me.barToggleSwitchItem1.Caption = "Light View"
            Me.barToggleSwitchItem1.Checked = True
            Me.barToggleSwitchItem1.Id = 15
            Me.barToggleSwitchItem1.Name = "barToggleSwitchItem1"
            AddHandler Me.barToggleSwitchItem1.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.barToggleSwitchItem1_CheckedChanged)
            ' 
            ' bar3
            ' 
            Me.bar3.BarName = "Status bar"
            Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.bar3.DockCol = 0
            Me.bar3.DockRow = 0
            Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.bar3.OptionsBar.AllowQuickCustomization = False
            Me.bar3.OptionsBar.DrawDragBorder = False
            Me.bar3.OptionsBar.UseWholeRow = True
            Me.bar3.Text = "Status bar"
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager1
            Me.barDockControlTop.Size = New System.Drawing.Size(914, 46)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 508)
            Me.barDockControlBottom.Manager = Me.barManager1
            Me.barDockControlBottom.Size = New System.Drawing.Size(914, 20)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 46)
            Me.barDockControlLeft.Manager = Me.barManager1
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 462)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(914, 46)
            Me.barDockControlRight.Manager = Me.barManager1
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 462)
            ' 
            ' dockManager1
            ' 
            Me.dockManager1.Form = Me
            Me.dockManager1.MenuManager = Me.barManager1
            Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel1, Me.panelContainer1, Me.dockPanel4})
            Me.dockManager1.Style = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Light
            Me.dockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
            ' 
            ' dockPanel1
            ' 
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel1.ID = New System.Guid("1c0462cd-5b46-461e-80af-99fd4075d170")
            Me.dockPanel1.Location = New System.Drawing.Point(0, 46)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel1.Size = New System.Drawing.Size(200, 462)
            Me.dockPanel1.Text = "Toolbox"
            ' 
            ' dockPanel1_Container
            ' 
            Me.dockPanel1_Container.Controls.Add(Me.navBarControl1)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(0, 23)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(199, 439)
            Me.dockPanel1_Container.TabIndex = 0
            ' 
            ' navBarControl1
            ' 
            Me.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navBarControl1.Location = New System.Drawing.Point(0, 0)
            Me.navBarControl1.Name = "navBarControl1"
            Me.navBarControl1.OptionsNavPane.ExpandedWidth = 199
            Me.navBarControl1.Size = New System.Drawing.Size(199, 439)
            Me.navBarControl1.SmallImages = Me.toolboxSvgImages
            Me.navBarControl1.TabIndex = 0
            Me.navBarControl1.Text = "navBarControl1"
            ' 
            ' toolboxSvgImages
            ' 
            Me.toolboxSvgImages.Add("Label", CType((resources.GetObject("toolboxSvgImages.Label")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("Button", CType((resources.GetObject("toolboxSvgImages.Button")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("CheckBox", CType((resources.GetObject("toolboxSvgImages.CheckBox")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("RadioButton", CType((resources.GetObject("toolboxSvgImages.RadioButton")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("CheckedComboBox", CType((resources.GetObject("toolboxSvgImages.CheckedComboBox")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("ListBox", CType((resources.GetObject("toolboxSvgImages.ListBox")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("CheckBoxList", CType((resources.GetObject("toolboxSvgImages.CheckBoxList")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("DataGrid", CType((resources.GetObject("toolboxSvgImages.DataGrid")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("ListView", CType((resources.GetObject("toolboxSvgImages.ListView")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("SpliterControl", CType((resources.GetObject("toolboxSvgImages.SpliterControl")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("SplitContainerControl", CType((resources.GetObject("toolboxSvgImages.SplitContainerControl")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("Panel", CType((resources.GetObject("toolboxSvgImages.Panel")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("TableLayoutPanel", CType((resources.GetObject("toolboxSvgImages.TableLayoutPanel")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("GroupBox", CType((resources.GetObject("toolboxSvgImages.GroupBox")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("TabControl", CType((resources.GetObject("toolboxSvgImages.TabControl")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("LabelControl_DX", CType((resources.GetObject("toolboxSvgImages.LabelControl_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("SimpleButton_DX", CType((resources.GetObject("toolboxSvgImages.SimpleButton_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("CheckButton_DX", CType((resources.GetObject("toolboxSvgImages.CheckButton_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("ToggleSwitch_DX", CType((resources.GetObject("toolboxSvgImages.ToggleSwitch_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("CheckEdit_DX", CType((resources.GetObject("toolboxSvgImages.CheckEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("RadioGroup_DX", CType((resources.GetObject("toolboxSvgImages.RadioGroup_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("TextEdit_DX", CType((resources.GetObject("toolboxSvgImages.TextEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("MemoEdit_DX", CType((resources.GetObject("toolboxSvgImages.MemoEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("ButtonEdit_DX", CType((resources.GetObject("toolboxSvgImages.ButtonEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("SpinEdit_DX", CType((resources.GetObject("toolboxSvgImages.SpinEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("CalcEdit_DX", CType((resources.GetObject("toolboxSvgImages.CalcEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("ColorEdit_DX", CType((resources.GetObject("toolboxSvgImages.ColorEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("DateControl_DX", CType((resources.GetObject("toolboxSvgImages.DateControl_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("DateEdit_DX", CType((resources.GetObject("toolboxSvgImages.DateEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("TimeEdit_DX", CType((resources.GetObject("toolboxSvgImages.TimeEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("LookUpEdit_DX", CType((resources.GetObject("toolboxSvgImages.LookUpEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("ListBoxControl_DX", CType((resources.GetObject("toolboxSvgImages.ListBoxControl_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("PictureEdit_DX", CType((resources.GetObject("toolboxSvgImages.PictureEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("RangeControl_DX", CType((resources.GetObject("toolboxSvgImages.RangeControl_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("XrtaTabControl_DX", CType((resources.GetObject("toolboxSvgImages.XrtaTabControl_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("BarManager_DX", CType((resources.GetObject("toolboxSvgImages.BarManager_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("DocumentManager_DX", CType((resources.GetObject("toolboxSvgImages.DocumentManager_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("PopupMenu_DX", CType((resources.GetObject("toolboxSvgImages.PopupMenu_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("RadialMenu_DX", CType((resources.GetObject("toolboxSvgImages.RadialMenu_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("TileControl_DX", CType((resources.GetObject("toolboxSvgImages.TileControl_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("GridControl_DX", CType((resources.GetObject("toolboxSvgImages.GridControl_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("GridLookUpEdit_DX", CType((resources.GetObject("toolboxSvgImages.GridLookUpEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("PDFViewer_DX", CType((resources.GetObject("toolboxSvgImages.PDFViewer_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("ChartControl_DX", CType((resources.GetObject("toolboxSvgImages.ChartControl_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("SpreadsheetControl_DX", CType((resources.GetObject("toolboxSvgImages.SpreadsheetControl_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("SchedulerControl_DX", CType((resources.GetObject("toolboxSvgImages.SchedulerControl_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("PivotGridControl_DX", CType((resources.GetObject("toolboxSvgImages.PivotGridControl_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("Map_DX", CType((resources.GetObject("toolboxSvgImages.Map_DX")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' panelContainer1
            ' 
            Me.panelContainer1.ActiveChild = Me.dockPanel3
            Me.panelContainer1.Controls.Add(Me.dockPanel2)
            Me.panelContainer1.Controls.Add(Me.dockPanel3)
            Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.panelContainer1.FloatVertical = True
            Me.panelContainer1.ID = New System.Guid("8ab18f1a-d5df-4d58-9923-6f9814a9b400")
            Me.panelContainer1.Location = New System.Drawing.Point(639, 46)
            Me.panelContainer1.Name = "panelContainer1"
            Me.panelContainer1.OriginalSize = New System.Drawing.Size(275, 200)
            Me.panelContainer1.Size = New System.Drawing.Size(275, 462)
            Me.panelContainer1.Tabbed = True
            Me.panelContainer1.Text = "panelContainer1"
            ' 
            ' dockPanel3
            ' 
            Me.dockPanel3.Controls.Add(Me.dockPanel3_Container)
            Me.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel3.FloatVertical = True
            Me.dockPanel3.ID = New System.Guid("04633bdd-57dd-45b5-9dc8-8bf3ff5d3b72")
            Me.dockPanel3.Location = New System.Drawing.Point(1, 23)
            Me.dockPanel3.Name = "dockPanel3"
            Me.dockPanel3.OriginalSize = New System.Drawing.Size(164, 413)
            Me.dockPanel3.Size = New System.Drawing.Size(274, 413)
            Me.dockPanel3.Text = "Properties"
            ' 
            ' dockPanel3_Container
            ' 
            Me.dockPanel3_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel3_Container.Name = "dockPanel3_Container"
            Me.dockPanel3_Container.Size = New System.Drawing.Size(274, 413)
            Me.dockPanel3_Container.TabIndex = 0
            ' 
            ' dockPanel2
            ' 
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel2.ID = New System.Guid("3eee2e6e-9350-48cb-83a6-d2e00e875502")
            Me.dockPanel2.Location = New System.Drawing.Point(1, 23)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(164, 413)
            Me.dockPanel2.Size = New System.Drawing.Size(274, 413)
            Me.dockPanel2.Text = "Solution Explorer"
            ' 
            ' dockPanel2_Container
            ' 
            Me.dockPanel2_Container.Controls.Add(Me.ucSolutionExplorer1)
            Me.dockPanel2_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(274, 413)
            Me.dockPanel2_Container.TabIndex = 0
            ' 
            ' ucSolutionExplorer1
            ' 
            Me.ucSolutionExplorer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ucSolutionExplorer1.Location = New System.Drawing.Point(0, 0)
            Me.ucSolutionExplorer1.Name = "ucSolutionExplorer1"
            Me.ucSolutionExplorer1.Size = New System.Drawing.Size(274, 413)
            Me.ucSolutionExplorer1.TabIndex = 0
            ' 
            ' dockPanel4
            ' 
            Me.dockPanel4.Controls.Add(Me.dockPanel4_Container)
            Me.dockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
            Me.dockPanel4.ID = New System.Guid("9feb35bb-87cd-424f-81bc-9a242d36eb90")
            Me.dockPanel4.Location = New System.Drawing.Point(200, 308)
            Me.dockPanel4.Name = "dockPanel4"
            Me.dockPanel4.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel4.Size = New System.Drawing.Size(439, 200)
            Me.dockPanel4.Text = "Output"
            ' 
            ' dockPanel4_Container
            ' 
            Me.dockPanel4_Container.Controls.Add(Me.ucOutput1)
            Me.dockPanel4_Container.Location = New System.Drawing.Point(0, 24)
            Me.dockPanel4_Container.Name = "dockPanel4_Container"
            Me.dockPanel4_Container.Size = New System.Drawing.Size(439, 176)
            Me.dockPanel4_Container.TabIndex = 0
            ' 
            ' ucOutput1
            ' 
            Me.ucOutput1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ucOutput1.Location = New System.Drawing.Point(0, 0)
            Me.ucOutput1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.ucOutput1.Name = "ucOutput1"
            Me.ucOutput1.Size = New System.Drawing.Size(439, 176)
            Me.ucOutput1.TabIndex = 0
            ' 
            ' tabbedView1
            ' 
            Me.tabbedView1.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() {Me.documentGroup1})
            Me.tabbedView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.document1, Me.document2, Me.document3})
            dockingContainer1.Element = Me.documentGroup1
            Me.tabbedView1.RootContainer.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {dockingContainer1})
            Me.tabbedView1.Style = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Light
            ' 
            ' IDEWorkspaces
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dockPanel4)
            Me.Controls.Add(Me.panelContainer1)
            Me.Controls.Add(Me.dockPanel1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "IDEWorkspaces"
            Me.Size = New System.Drawing.Size(914, 528)
            CType((Me.documentGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.document1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.document2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.document3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel1_Container.ResumeLayout(False)
            CType((Me.navBarControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.toolboxSvgImages), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelContainer1.ResumeLayout(False)
            Me.dockPanel3.ResumeLayout(False)
            Me.dockPanel2.ResumeLayout(False)
            Me.dockPanel2_Container.ResumeLayout(False)
            Me.dockPanel4.ResumeLayout(False)
            Me.dockPanel4_Container.ResumeLayout(False)
            CType((Me.tabbedView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager

        Private panelContainer1 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel2 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanel3 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl

        Private barManager1 As DevExpress.XtraBars.BarManager

        Private bar1 As DevExpress.XtraBars.Bar

        Private barButtonItem5 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem6 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem7 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem8 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem9 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem10 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem11 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem12 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem13 As DevExpress.XtraBars.BarButtonItem

        Private bar2 As DevExpress.XtraBars.Bar

        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem4 As DevExpress.XtraBars.BarButtonItem

        Private bar3 As DevExpress.XtraBars.Bar

        Private dockManager1 As DevExpress.XtraBars.Docking.DockManager

        Private tabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView

        Private workspaceManager1 As DevExpress.Utils.WorkspaceManager

        Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl

        Private ucSolutionExplorer1 As DevExpress.ApplicationUI.Demos.ucSolutionExplorer

        Private documentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup

        Private document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private document2 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private document3 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private barWorkspaceMenuItem1 As DevExpress.XtraBars.BarWorkspaceMenuItem

        Private dockPanel4 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel4_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private ucOutput1 As DevExpress.ApplicationUI.Demos.ucOutput

        Private barToggleSwitchItem1 As DevExpress.XtraBars.BarToggleSwitchItem

        Private toolboxSvgImages As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
