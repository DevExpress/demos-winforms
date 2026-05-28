Namespace DevExpress.XtraBars.Demos.DockingDemo

    Partial Class frmMain

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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraBars.Demos.DockingDemo.frmMain))
            Me.barManager = New DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(Me.components)
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.iNew = New DevExpress.XtraBars.BarButtonItem()
            Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.iProject = New DevExpress.XtraBars.BarButtonItem()
            Me.iFile = New DevExpress.XtraBars.BarButtonItem()
            Me.iBlankSolution = New DevExpress.XtraBars.BarButtonItem()
            Me.iAddNewItem = New DevExpress.XtraBars.BarButtonItem()
            Me.iOpenFile = New DevExpress.XtraBars.BarButtonItem()
            Me.iSave = New DevExpress.XtraBars.BarButtonItem()
            Me.iSaveAll = New DevExpress.XtraBars.BarButtonItem()
            Me.iStart = New DevExpress.XtraBars.BarButtonItem()
            Me.eConfiguration = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.iFindinFiles = New DevExpress.XtraBars.BarButtonItem()
            Me.eFind = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.bar3 = New DevExpress.XtraBars.Bar()
            Me.iSolutionExplorer = New DevExpress.XtraBars.BarButtonItem()
            Me.iProperties = New DevExpress.XtraBars.BarButtonItem()
            Me.iToolbox = New DevExpress.XtraBars.BarButtonItem()
            Me.iClassView = New DevExpress.XtraBars.BarButtonItem()
            Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
            Me.treeView1 = New DevExpress.XtraTreeList.TreeList()
            Me.classViewSvgImages = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.iTaskList = New DevExpress.XtraBars.BarButtonItem()
            Me.iFindResults = New DevExpress.XtraBars.BarButtonItem()
            Me.iOutput = New DevExpress.XtraBars.BarButtonItem()
            Me.bar4 = New DevExpress.XtraBars.Bar()
            Me.iStatus1 = New DevExpress.XtraBars.BarStaticItem()
            Me.bar5 = New DevExpress.XtraBars.Bar()
            Me.iLoadLayout = New DevExpress.XtraBars.BarButtonItem()
            Me.iSaveLayout = New DevExpress.XtraBars.BarButtonItem()
            Me.bar6 = New DevExpress.XtraBars.Bar()
            Me.barAndDockingController = New DevExpress.XtraBars.BarAndDockingController(Me.components)
            Me.barDockControl1 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl2 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl3 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl4 = New DevExpress.XtraBars.BarDockControl()
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.hideContainerLeft = New DevExpress.XtraBars.Docking.AutoHideContainer()
            Me.dockPanel6 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel6_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.ucToolbox1 = New DevExpress.XtraBars.Demos.DockingDemo.ucToolbox()
            Me.mainMenuSvgImages = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.panelContainer2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel5 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel5_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.ucOutput1 = New DevExpress.XtraBars.Demos.DockingDemo.ucOutput()
            Me.dockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.ucTaskList1 = New DevExpress.XtraBars.Demos.DockingDemo.ucTaskList()
            Me.dockPanel4 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel4_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.textBox1 = New DevExpress.XtraEditors.MemoEdit()
            Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.solutionExplorer = New DevExpress.XtraBars.Demos.DockingDemo.ucSolutionExplorer()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.ucProperties1 = New DevExpress.XtraBars.Demos.DockingDemo.ucProperties()
            Me.siFile = New DevExpress.XtraBars.BarSubItem()
            Me.siNew = New DevExpress.XtraBars.BarSubItem()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.iOpen = New DevExpress.XtraBars.BarButtonItem()
            Me.iClose = New DevExpress.XtraBars.BarButtonItem()
            Me.iAddExistingItem = New DevExpress.XtraBars.BarButtonItem()
            Me.siAddProject = New DevExpress.XtraBars.BarSubItem()
            Me.iNewProject = New DevExpress.XtraBars.BarButtonItem()
            Me.iExistingProject = New DevExpress.XtraBars.BarButtonItem()
            Me.iOpenSolution = New DevExpress.XtraBars.BarButtonItem()
            Me.iCloseSolution = New DevExpress.XtraBars.BarButtonItem()
            Me.iPageSetup = New DevExpress.XtraBars.BarButtonItem()
            Me.iPrint = New DevExpress.XtraBars.BarButtonItem()
            Me.iExit = New DevExpress.XtraBars.BarButtonItem()
            Me.siEdit = New DevExpress.XtraBars.BarSubItem()
            Me.siFind = New DevExpress.XtraBars.BarSubItem()
            Me.iFind = New DevExpress.XtraBars.BarButtonItem()
            Me.iReplace = New DevExpress.XtraBars.BarButtonItem()
            Me.siWindow = New DevExpress.XtraBars.BarSubItem()
            Me.barDockingMenuItem1 = New DevExpress.XtraBars.BarDockingMenuItem()
            Me.siLayouts = New DevExpress.XtraBars.BarSubItem()
            Me.bsiHelp = New DevExpress.XtraBars.BarSubItem()
            Me.iAbout = New DevExpress.XtraBars.BarButtonItem()
            Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemSearchControl1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.barHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
            Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.tabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            Me.fileTypeSvgImages = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.toolbarFormControl1 = New DevExpress.XtraBars.ToolbarForm.ToolbarFormControl()
            CType((Me.barManager), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.popupMenu1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryImageComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.popupControlContainer1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupControlContainer1.SuspendLayout()
            CType((Me.treeView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.classViewSvgImages), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.barAndDockingController), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.hideContainerLeft.SuspendLayout()
            Me.dockPanel6.SuspendLayout()
            Me.dockPanel6_Container.SuspendLayout()
            CType((Me.mainMenuSvgImages), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelContainer2.SuspendLayout()
            Me.dockPanel5.SuspendLayout()
            Me.dockPanel5_Container.SuspendLayout()
            Me.dockPanel3.SuspendLayout()
            Me.dockPanel3_Container.SuspendLayout()
            Me.dockPanel4.SuspendLayout()
            Me.dockPanel4_Container.SuspendLayout()
            CType((Me.textBox1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelContainer1.SuspendLayout()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel1_Container.SuspendLayout()
            Me.dockPanel2.SuspendLayout()
            Me.dockPanel2_Container.SuspendLayout()
            CType((Me.repositoryItemSearchControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabbedView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.fileTypeSvgImages), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.toolbarFormControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' barManager
            ' 
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar2, Me.bar3, Me.bar4, Me.bar5, Me.bar6})
            Me.barManager.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("Built-in Menus", New System.Guid("a984a9d9-f96f-425a-8857-fe4de6df48c2")), New DevExpress.XtraBars.BarManagerCategory("File", New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")), New DevExpress.XtraBars.BarManagerCategory("Edit", New System.Guid("ac82dbe7-c530-4aa2-b6de-94a7777426fe")), New DevExpress.XtraBars.BarManagerCategory("Standard", New System.Guid("fbaaf85d-943d-4ccd-8517-fc398efe9c7b")), New DevExpress.XtraBars.BarManagerCategory("View", New System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4")), New DevExpress.XtraBars.BarManagerCategory("Window", New System.Guid("faa74de1-bd23-44b9-955d-6ba635fa0f01")), New DevExpress.XtraBars.BarManagerCategory("Status", New System.Guid("d3532f9f-c716-4c40-8731-d110e1a41e64")), New DevExpress.XtraBars.BarManagerCategory("Layouts", New System.Guid("f2b2eae8-5b98-43eb-81aa-d999b20fd3d3")), New DevExpress.XtraBars.BarManagerCategory("PaintStyles", New System.Guid("d0a113b2-425b-47f5-a6b5-0aefb1859507"))})
            Me.barManager.Controller = Me.barAndDockingController
            Me.barManager.DockControls.Add(Me.barDockControl1)
            Me.barManager.DockControls.Add(Me.barDockControl2)
            Me.barManager.DockControls.Add(Me.barDockControl3)
            Me.barManager.DockControls.Add(Me.barDockControl4)
            Me.barManager.DockManager = Me.dockManager
            Me.barManager.Form = Me
            Me.barManager.Images = Me.mainMenuSvgImages
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.siFile, Me.siEdit, Me.siNew, Me.iOpen, Me.iClose, Me.iProject, Me.iFile, Me.iBlankSolution, Me.iAddNewItem, Me.iAddExistingItem, Me.siAddProject, Me.iNewProject, Me.iExistingProject, Me.iSaveAll, Me.iOpenSolution, Me.iCloseSolution, Me.iPageSetup, Me.iPrint, Me.iExit, Me.siFind, Me.iFind, Me.iReplace, Me.iFindinFiles, Me.iNew, Me.iOpenFile, Me.iSave, Me.iStart, Me.eConfiguration, Me.eFind, Me.iSolutionExplorer, Me.iProperties, Me.iToolbox, Me.iClassView, Me.iTaskList, Me.iFindResults, Me.iOutput, Me.siWindow, Me.iStatus1, Me.iLoadLayout, Me.iSaveLayout, Me.siLayouts, Me.barDockingMenuItem1, Me.bsiHelp, Me.iAbout, Me.barButtonItem1, Me.barEditItem1, Me.barHeaderItem1, Me.barStaticItem1})
            Me.barManager.MaxItemId = 79
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryImageComboBox1, Me.repositoryItemComboBox1, Me.repositoryItemImageComboBox1, Me.repositoryItemSearchControl1})
            Me.barManager.StatusBar = Me.bar4
            AddHandler Me.barManager.Merge, New DevExpress.XtraBars.BarManagerMergeEventHandler(AddressOf Me.barManager1_Merge)
            AddHandler Me.barManager.UnMerge, New DevExpress.XtraBars.BarManagerMergeEventHandler(AddressOf Me.barManager1_UnMerge)
            ' 
            ' bar2
            ' 
            Me.bar2.BarName = "Standard"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.FloatLocation = New System.Drawing.Point(38, 139)
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iNew), New DevExpress.XtraBars.LinkPersistInfo(Me.iAddNewItem), New DevExpress.XtraBars.LinkPersistInfo(Me.iOpenFile), New DevExpress.XtraBars.LinkPersistInfo(Me.iSave), New DevExpress.XtraBars.LinkPersistInfo(Me.iSaveAll), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.iStart, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.eConfiguration, "", False, True, True, 88), New DevExpress.XtraBars.LinkPersistInfo(Me.iFindinFiles, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.eFind, "", False, True, True, 97)})
            Me.bar2.Text = "Standard"
            ' 
            ' iNew
            ' 
            Me.iNew.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.iNew.Caption = "New Project"
            Me.iNew.CategoryGuid = New System.Guid("fbaaf85d-943d-4ccd-8517-fc398efe9c7b")
            Me.iNew.DropDownControl = Me.popupMenu1
            Me.iNew.Hint = "New Project"
            Me.iNew.Id = 31
            Me.iNew.ImageOptions.ImageIndex = 10
            Me.iNew.Name = "iNew"
            AddHandler Me.iNew.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.iNewItemClick)
            ' 
            ' popupMenu1
            ' 
            Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iProject), New DevExpress.XtraBars.LinkPersistInfo(Me.iFile), New DevExpress.XtraBars.LinkPersistInfo(Me.iBlankSolution)})
            Me.popupMenu1.Manager = Me.barManager
            Me.popupMenu1.Name = "popupMenu1"
            ' 
            ' iProject
            ' 
            Me.iProject.Caption = "Team &Project..."
            Me.iProject.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iProject.Hint = "New Project"
            Me.iProject.Id = 5
            Me.iProject.ImageOptions.ImageIndex = 0
            Me.iProject.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.N))
            Me.iProject.Name = "iProject"
            AddHandler Me.iProject.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.iNewItemClick)
            ' 
            ' iFile
            ' 
            Me.iFile.Caption = "&File..."
            Me.iFile.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iFile.Hint = "New File"
            Me.iFile.Id = 6
            Me.iFile.ImageOptions.ImageIndex = 1
            Me.iFile.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N))
            Me.iFile.Name = "iFile"
            AddHandler Me.iFile.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.iNewItemClick)
            ' 
            ' iBlankSolution
            ' 
            Me.iBlankSolution.Caption = "&Blank Solution..."
            Me.iBlankSolution.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iBlankSolution.Hint = "Blank Solution"
            Me.iBlankSolution.Id = 7
            Me.iBlankSolution.ImageOptions.ImageIndex = 2
            Me.iBlankSolution.Name = "iBlankSolution"
            AddHandler Me.iBlankSolution.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.iNewItemClick)
            ' 
            ' iAddNewItem
            ' 
            Me.iAddNewItem.Caption = "Add Ne&w Item..."
            Me.iAddNewItem.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iAddNewItem.Hint = "Add New Item"
            Me.iAddNewItem.Id = 8
            Me.iAddNewItem.ImageOptions.ImageIndex = 3
            Me.iAddNewItem.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.A))
            Me.iAddNewItem.Name = "iAddNewItem"
            ' 
            ' iOpenFile
            ' 
            Me.iOpenFile.Caption = "Open File"
            Me.iOpenFile.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iOpenFile.Hint = "Open File"
            Me.iOpenFile.Id = 32
            Me.iOpenFile.ImageOptions.ImageIndex = 5
            Me.iOpenFile.Name = "iOpenFile"
            ' 
            ' iSave
            ' 
            Me.iSave.Caption = "Save"
            Me.iSave.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iSave.Enabled = False
            Me.iSave.Hint = "Save"
            Me.iSave.Id = 33
            Me.iSave.ImageOptions.ImageIndex = 21
            Me.iSave.Name = "iSave"
            ' 
            ' iSaveAll
            ' 
            Me.iSaveAll.Caption = "Save A&ll"
            Me.iSaveAll.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iSaveAll.Enabled = False
            Me.iSaveAll.Hint = "Save All"
            Me.iSaveAll.Id = 13
            Me.iSaveAll.ImageOptions.ImageIndex = 7
            Me.iSaveAll.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.S))
            Me.iSaveAll.Name = "iSaveAll"
            ' 
            ' iStart
            ' 
            Me.iStart.Caption = "Start"
            Me.iStart.CategoryGuid = New System.Guid("fbaaf85d-943d-4ccd-8517-fc398efe9c7b")
            Me.iStart.Hint = "Start"
            Me.iStart.Id = 34
            Me.iStart.ImageOptions.ImageIndex = 22
            Me.iStart.Name = "iStart"
            ' 
            ' eConfiguration
            ' 
            Me.eConfiguration.Caption = "Solution Configuration"
            Me.eConfiguration.CategoryGuid = New System.Guid("fbaaf85d-943d-4ccd-8517-fc398efe9c7b")
            Me.eConfiguration.Edit = Me.repositoryImageComboBox1
            Me.eConfiguration.EditHeight = 22
            Me.eConfiguration.EditValue = "Debug"
            Me.eConfiguration.Hint = "Solution Configuration"
            Me.eConfiguration.Id = 35
            Me.eConfiguration.Name = "eConfiguration"
            Me.eConfiguration.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            ' 
            ' repositoryImageComboBox1
            ' 
            Me.repositoryImageComboBox1.AllowFocused = False
            Me.repositoryImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryImageComboBox1.Name = "repositoryImageComboBox1"
            ' 
            ' iFindinFiles
            ' 
            Me.iFindinFiles.Caption = "F&ind in Files"
            Me.iFindinFiles.CategoryGuid = New System.Guid("ac82dbe7-c530-4aa2-b6de-94a7777426fe")
            Me.iFindinFiles.Hint = "Find in Files"
            Me.iFindinFiles.Id = 30
            Me.iFindinFiles.ImageOptions.ImageIndex = 18
            Me.iFindinFiles.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.F))
            Me.iFindinFiles.Name = "iFindinFiles"
            ' 
            ' eFind
            ' 
            Me.eFind.Caption = "Find"
            Me.eFind.CategoryGuid = New System.Guid("fbaaf85d-943d-4ccd-8517-fc398efe9c7b")
            Me.eFind.Edit = Me.repositoryItemComboBox1
            Me.eFind.EditHeight = 22
            Me.eFind.Hint = "Find"
            Me.eFind.Id = 36
            Me.eFind.Name = "eFind"
            Me.eFind.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            ' 
            ' repositoryItemComboBox1
            ' 
            Me.repositoryItemComboBox1.AllowFocused = False
            Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox1.Items.AddRange(New Object() {"barManager1"})
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            AddHandler Me.repositoryItemComboBox1.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.repositoryItemComboBox1_KeyDown)
            ' 
            ' bar3
            ' 
            Me.bar3.BarName = "View"
            Me.bar3.DockCol = 2
            Me.bar3.DockRow = 0
            Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar3.FloatLocation = New System.Drawing.Point(36, 181)
            Me.bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iSolutionExplorer), New DevExpress.XtraBars.LinkPersistInfo(Me.iProperties), New DevExpress.XtraBars.LinkPersistInfo(Me.iToolbox), New DevExpress.XtraBars.LinkPersistInfo(Me.iClassView), New DevExpress.XtraBars.LinkPersistInfo(Me.iTaskList, True), New DevExpress.XtraBars.LinkPersistInfo(Me.iFindResults), New DevExpress.XtraBars.LinkPersistInfo(Me.iOutput)})
            Me.bar3.Offset = 400
            Me.bar3.Text = "View"
            ' 
            ' iSolutionExplorer
            ' 
            Me.iSolutionExplorer.Caption = "Solution Ex&plorer"
            Me.iSolutionExplorer.CategoryGuid = New System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4")
            Me.iSolutionExplorer.Hint = "Solution Explorer"
            Me.iSolutionExplorer.Id = 37
            Me.iSolutionExplorer.ImageOptions.ImageIndex = 23
            Me.iSolutionExplorer.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.L))
            Me.iSolutionExplorer.Name = "iSolutionExplorer"
            AddHandler Me.iSolutionExplorer.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.iSolutionExplorer_ItemClick)
            ' 
            ' iProperties
            ' 
            Me.iProperties.Caption = "Properties &Window"
            Me.iProperties.CategoryGuid = New System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4")
            Me.iProperties.Hint = "Properties Window"
            Me.iProperties.Id = 38
            Me.iProperties.ImageOptions.ImageIndex = 24
            Me.iProperties.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
            Me.iProperties.Name = "iProperties"
            AddHandler Me.iProperties.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.iProperties_ItemClick)
            ' 
            ' iToolbox
            ' 
            Me.iToolbox.Caption = "Toolbo&x"
            Me.iToolbox.CategoryGuid = New System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4")
            Me.iToolbox.Hint = "Toolbox"
            Me.iToolbox.Id = 39
            Me.iToolbox.ImageOptions.ImageIndex = 25
            Me.iToolbox.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.X))
            Me.iToolbox.Name = "iToolbox"
            AddHandler Me.iToolbox.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.iToolbox_ItemClick)
            ' 
            ' iClassView
            ' 
            Me.iClassView.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.iClassView.Caption = "Cl&ass View"
            Me.iClassView.CategoryGuid = New System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4")
            Me.iClassView.DropDownControl = Me.popupControlContainer1
            Me.iClassView.Hint = "Class View"
            Me.iClassView.Id = 40
            Me.iClassView.ImageOptions.ImageIndex = 26
            Me.iClassView.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.C))
            Me.iClassView.Name = "iClassView"
            ' 
            ' popupControlContainer1
            ' 
            Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.popupControlContainer1.Controls.Add(Me.treeView1)
            Me.popupControlContainer1.Location = New System.Drawing.Point(52, 111)
            Me.popupControlContainer1.Manager = Me.barManager
            Me.popupControlContainer1.Name = "popupControlContainer1"
            Me.popupControlContainer1.ShowSizeGrip = True
            Me.popupControlContainer1.Size = New System.Drawing.Size(408, 231)
            Me.popupControlContainer1.TabIndex = 5
            Me.popupControlContainer1.Visible = False
            ' 
            ' treeView1
            ' 
            Me.treeView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.treeView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeView1.Location = New System.Drawing.Point(0, 0)
            Me.treeView1.Name = "treeView1"
            Me.treeView1.Size = New System.Drawing.Size(408, 231)
            Me.treeView1.StateImageList = Me.classViewSvgImages
            Me.treeView1.TabIndex = 0
            ' 
            ' classViewSvgImages
            ' 
            Me.classViewSvgImages.Add("Solution_ClassView", CType((resources.GetObject("classViewSvgImages.Solution_ClassView")), DevExpress.Utils.Svg.SvgImage))
            Me.classViewSvgImages.Add("ClassIcon_ClassView", CType((resources.GetObject("classViewSvgImages.ClassIcon_ClassView")), DevExpress.Utils.Svg.SvgImage))
            Me.classViewSvgImages.Add("Field_ClassView", CType((resources.GetObject("classViewSvgImages.Field_ClassView")), DevExpress.Utils.Svg.SvgImage))
            Me.classViewSvgImages.Add("Event_ClassView", CType((resources.GetObject("classViewSvgImages.Event_ClassView")), DevExpress.Utils.Svg.SvgImage))
            Me.classViewSvgImages.Add("Method_ClassView", CType((resources.GetObject("classViewSvgImages.Method_ClassView")), DevExpress.Utils.Svg.SvgImage))
            Me.classViewSvgImages.Add("Field-Private_ClassView", CType((resources.GetObject("classViewSvgImages.Field-Private_ClassView")), DevExpress.Utils.Svg.SvgImage))
            Me.classViewSvgImages.Add("Event-Private_ClassView", CType((resources.GetObject("classViewSvgImages.Event-Private_ClassView")), DevExpress.Utils.Svg.SvgImage))
            Me.classViewSvgImages.Add("Method-Private_ClassView", CType((resources.GetObject("classViewSvgImages.Method-Private_ClassView")), DevExpress.Utils.Svg.SvgImage))
            Me.classViewSvgImages.Add("Field-Protected_ClassView", CType((resources.GetObject("classViewSvgImages.Field-Protected_ClassView")), DevExpress.Utils.Svg.SvgImage))
            Me.classViewSvgImages.Add("Event-Protected_ClassView", CType((resources.GetObject("classViewSvgImages.Event-Protected_ClassView")), DevExpress.Utils.Svg.SvgImage))
            Me.classViewSvgImages.Add("Method-Protected_ClassView", CType((resources.GetObject("classViewSvgImages.Method-Protected_ClassView")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' iTaskList
            ' 
            Me.iTaskList.Caption = "Task List"
            Me.iTaskList.CategoryGuid = New System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4")
            Me.iTaskList.Hint = "Task List"
            Me.iTaskList.Id = 68
            Me.iTaskList.ImageOptions.ImageIndex = 27
            Me.iTaskList.Name = "iTaskList"
            AddHandler Me.iTaskList.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.iTaskList_ItemClick)
            ' 
            ' iFindResults
            ' 
            Me.iFindResults.Caption = "Find Results"
            Me.iFindResults.CategoryGuid = New System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4")
            Me.iFindResults.Hint = "Find Results"
            Me.iFindResults.Id = 69
            Me.iFindResults.ImageOptions.ImageIndex = 28
            Me.iFindResults.Name = "iFindResults"
            AddHandler Me.iFindResults.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.iFindResults_ItemClick)
            ' 
            ' iOutput
            ' 
            Me.iOutput.Caption = "Output"
            Me.iOutput.CategoryGuid = New System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4")
            Me.iOutput.Hint = "Output"
            Me.iOutput.Id = 70
            Me.iOutput.ImageOptions.ImageIndex = 29
            Me.iOutput.Name = "iOutput"
            AddHandler Me.iOutput.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.iOutput_ItemClick)
            ' 
            ' bar4
            ' 
            Me.bar4.BarName = "StatusBar"
            Me.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.bar4.DockCol = 0
            Me.bar4.DockRow = 0
            Me.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.bar4.FloatLocation = New System.Drawing.Point(25, 282)
            Me.bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iStatus1)})
            Me.bar4.OptionsBar.AllowQuickCustomization = False
            Me.bar4.OptionsBar.DrawDragBorder = False
            Me.bar4.OptionsBar.DrawSizeGrip = True
            Me.bar4.OptionsBar.RotateWhenVertical = False
            Me.bar4.OptionsBar.UseWholeRow = True
            Me.bar4.Text = "StatusBar"
            ' 
            ' iStatus1
            ' 
            Me.iStatus1.AllowFocus = DevExpress.Utils.DefaultBoolean.[False]
            Me.iStatus1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.iStatus1.Caption = "Ready"
            Me.iStatus1.CategoryGuid = New System.Guid("d3532f9f-c716-4c40-8731-d110e1a41e64")
            Me.iStatus1.Id = 50
            Me.iStatus1.Name = "iStatus1"
            ' 
            ' bar5
            ' 
            Me.bar5.BarName = "Layouts"
            Me.bar5.DockCol = 3
            Me.bar5.DockRow = 0
            Me.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar5.FloatLocation = New System.Drawing.Point(159, 118)
            Me.bar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iLoadLayout), New DevExpress.XtraBars.LinkPersistInfo(Me.iSaveLayout)})
            Me.bar5.Offset = 665
            Me.bar5.Text = "Layouts"
            ' 
            ' iLoadLayout
            ' 
            Me.iLoadLayout.Caption = "&Load Layout..."
            Me.iLoadLayout.CategoryGuid = New System.Guid("f2b2eae8-5b98-43eb-81aa-d999b20fd3d3")
            Me.iLoadLayout.Hint = "Load Layout"
            Me.iLoadLayout.Id = 47
            Me.iLoadLayout.ImageOptions.ImageIndex = 35
            Me.iLoadLayout.Name = "iLoadLayout"
            AddHandler Me.iLoadLayout.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.iLoadLayout_ItemClick)
            ' 
            ' iSaveLayout
            ' 
            Me.iSaveLayout.Caption = "&Save Layout..."
            Me.iSaveLayout.CategoryGuid = New System.Guid("f2b2eae8-5b98-43eb-81aa-d999b20fd3d3")
            Me.iSaveLayout.Hint = "Save Layout"
            Me.iSaveLayout.Id = 48
            Me.iSaveLayout.ImageOptions.ImageIndex = 34
            Me.iSaveLayout.Name = "iSaveLayout"
            AddHandler Me.iSaveLayout.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.iSaveLayout_ItemClick)
            ' 
            ' bar6
            ' 
            Me.bar6.BarName = "Edit"
            Me.bar6.DockCol = 1
            Me.bar6.DockRow = 0
            Me.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar6.Offset = 391
            Me.bar6.OptionsBar.AllowRename = True
            Me.bar6.Text = "Common"
            ' 
            ' barAndDockingController
            ' 
            Me.barAndDockingController.PaintStyleName = "Skin"
            Me.barAndDockingController.PropertiesBar.AllowLinkLighting = False
            ' 
            ' barDockControl1
            ' 
            Me.barDockControl1.CausesValidation = False
            Me.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControl1.Location = New System.Drawing.Point(0, 30)
            Me.barDockControl1.Manager = Me.barManager
            Me.barDockControl1.Size = New System.Drawing.Size(1133, 28)
            ' 
            ' barDockControl2
            ' 
            Me.barDockControl2.CausesValidation = False
            Me.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControl2.Location = New System.Drawing.Point(0, 640)
            Me.barDockControl2.Manager = Me.barManager
            Me.barDockControl2.Size = New System.Drawing.Size(1133, 22)
            ' 
            ' barDockControl3
            ' 
            Me.barDockControl3.CausesValidation = False
            Me.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControl3.Location = New System.Drawing.Point(0, 58)
            Me.barDockControl3.Manager = Me.barManager
            Me.barDockControl3.Size = New System.Drawing.Size(0, 582)
            ' 
            ' barDockControl4
            ' 
            Me.barDockControl4.CausesValidation = False
            Me.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControl4.Location = New System.Drawing.Point(1133, 58)
            Me.barDockControl4.Manager = Me.barManager
            Me.barDockControl4.Size = New System.Drawing.Size(0, 582)
            ' 
            ' dockManager
            ' 
            Me.dockManager.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerLeft})
            Me.dockManager.Controller = Me.barAndDockingController
            Me.dockManager.Form = Me
            Me.dockManager.Images = Me.mainMenuSvgImages
            Me.dockManager.MenuManager = Me.barManager
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.panelContainer2, Me.panelContainer1})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
            ' 
            ' hideContainerLeft
            ' 
            Me.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((229)))))), (CInt(((CByte((235)))))), (CInt(((CByte((255)))))))
            Me.hideContainerLeft.Controls.Add(Me.dockPanel6)
            Me.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.hideContainerLeft.Location = New System.Drawing.Point(0, 58)
            Me.hideContainerLeft.Name = "hideContainerLeft"
            Me.hideContainerLeft.Size = New System.Drawing.Size(25, 582)
            ' 
            ' dockPanel6
            ' 
            Me.dockPanel6.Controls.Add(Me.dockPanel6_Container)
            Me.dockPanel6.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel6.FloatSize = New System.Drawing.Size(146, 428)
            Me.dockPanel6.ID = New System.Guid("24977e30-0ea6-44aa-8fa4-9abaeb178b5e")
            Me.dockPanel6.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel6.Name = "dockPanel6"
            Me.dockPanel6.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel6.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel6.SavedIndex = 2
            Me.dockPanel6.Size = New System.Drawing.Size(200, 584)
            Me.dockPanel6.Text = "Toolbox"
            Me.dockPanel6.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
            ' 
            ' dockPanel6_Container
            ' 
            Me.dockPanel6_Container.Controls.Add(Me.ucToolbox1)
            Me.dockPanel6_Container.Location = New System.Drawing.Point(3, 30)
            Me.dockPanel6_Container.Name = "dockPanel6_Container"
            Me.dockPanel6_Container.Size = New System.Drawing.Size(193, 551)
            Me.dockPanel6_Container.TabIndex = 0
            ' 
            ' ucToolbox1
            ' 
            Me.ucToolbox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ucToolbox1.Location = New System.Drawing.Point(0, 0)
            Me.ucToolbox1.Margin = New System.Windows.Forms.Padding(2)
            Me.ucToolbox1.Name = "ucToolbox1"
            Me.ucToolbox1.Size = New System.Drawing.Size(193, 551)
            Me.ucToolbox1.TabIndex = 0
            ' 
            ' mainMenuSvgImages
            ' 
            Me.mainMenuSvgImages.Add("0_NewTeamProject_7437", CType((resources.GetObject("mainMenuSvgImages.0_NewTeamProject_7437")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("1_NewFile_6276", CType((resources.GetObject("mainMenuSvgImages.1_NewFile_6276")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("2_BlankApp_CPP_16x", CType((resources.GetObject("mainMenuSvgImages.2_BlankApp_CPP_16x")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("3_AddNewItem_6273", CType((resources.GetObject("mainMenuSvgImages.3_AddNewItem_6273")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("4_AddExistingItem_6269", CType((resources.GetObject("mainMenuSvgImages.4_AddExistingItem_6269")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("5_OpenFile", CType((resources.GetObject("mainMenuSvgImages.5_OpenFile")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("6_Close_6519", CType((resources.GetObject("mainMenuSvgImages.6_Close_6519")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("7_Saveall_6518", CType((resources.GetObject("mainMenuSvgImages.7_Saveall_6518")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("8_PrintSetup_11011", CType((resources.GetObject("mainMenuSvgImages.8_PrintSetup_11011")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("9_Print_11009", CType((resources.GetObject("mainMenuSvgImages.9_Print_11009")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("10_NewTeamProject_7437", CType((resources.GetObject("mainMenuSvgImages.10_NewTeamProject_7437")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("11_Undo", CType((resources.GetObject("mainMenuSvgImages.11_Undo")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("12_Redo_16x16", CType((resources.GetObject("mainMenuSvgImages.12_Redo_16x16")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("13_Cut", CType((resources.GetObject("mainMenuSvgImages.13_Cut")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("14_Copy", CType((resources.GetObject("mainMenuSvgImages.14_Copy")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("15_Paste", CType((resources.GetObject("mainMenuSvgImages.15_Paste")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("16_Find_5650", CType((resources.GetObject("mainMenuSvgImages.16_Find_5650")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("17_17", CType((resources.GetObject("mainMenuSvgImages.17_17")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("18_FindinFiles_6299", CType((resources.GetObject("mainMenuSvgImages.18_FindinFiles_6299")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("19_19", CType((resources.GetObject("mainMenuSvgImages.19_19")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("20_Open_6529", CType((resources.GetObject("mainMenuSvgImages.20_Open_6529")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("21_Save_6530", CType((resources.GetObject("mainMenuSvgImages.21_Save_6530")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("22_StartDebugging_", CType((resources.GetObject("mainMenuSvgImages.22_StartDebugging_")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("23_Solution", CType((resources.GetObject("mainMenuSvgImages.23_Solution")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("24_properties", CType((resources.GetObject("mainMenuSvgImages.24_properties")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("25_toolbox_16xLG", CType((resources.GetObject("mainMenuSvgImages.25_toolbox_16xLG")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("26_class_16xLG", CType((resources.GetObject("mainMenuSvgImages.26_class_16xLG")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("27_Task_16xLG", CType((resources.GetObject("mainMenuSvgImages.27_Task_16xLG")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("28_FindInFiles", CType((resources.GetObject("mainMenuSvgImages.28_FindInFiles")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("29_Output", CType((resources.GetObject("mainMenuSvgImages.29_Output")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("30_30", CType((resources.GetObject("mainMenuSvgImages.30_30")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("31_31", CType((resources.GetObject("mainMenuSvgImages.31_31")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("32_32", CType((resources.GetObject("mainMenuSvgImages.32_32")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("33_33", CType((resources.GetObject("mainMenuSvgImages.33_33")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("34_SaveFileDialogControl_703", CType((resources.GetObject("mainMenuSvgImages.34_SaveFileDialogControl_703")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("35_OpenFileDialog_692", CType((resources.GetObject("mainMenuSvgImages.35_OpenFileDialog_692")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("36_Information_blue_6227", CType((resources.GetObject("mainMenuSvgImages.36_Information_blue_6227")), DevExpress.Utils.Svg.SvgImage))
            Me.mainMenuSvgImages.Add("37_NewWebSite_6288", CType((resources.GetObject("mainMenuSvgImages.37_NewWebSite_6288")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' panelContainer2
            ' 
            Me.panelContainer2.ActiveChild = Me.dockPanel5
            Me.panelContainer2.Controls.Add(Me.dockPanel3)
            Me.panelContainer2.Controls.Add(Me.dockPanel4)
            Me.panelContainer2.Controls.Add(Me.dockPanel5)
            Me.panelContainer2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
            Me.panelContainer2.FloatSize = New System.Drawing.Size(304, 139)
            Me.panelContainer2.ID = New System.Guid("ec7b92c0-cfe1-43c3-9ff0-c24e6320f016")
            Me.panelContainer2.Location = New System.Drawing.Point(25, 440)
            Me.panelContainer2.Name = "panelContainer2"
            Me.panelContainer2.OriginalSize = New System.Drawing.Size(200, 200)
            Me.panelContainer2.Size = New System.Drawing.Size(1108, 200)
            Me.panelContainer2.Tabbed = True
            Me.panelContainer2.Text = "panelContainer2"
            ' 
            ' dockPanel5
            ' 
            Me.dockPanel5.Controls.Add(Me.dockPanel5_Container)
            Me.dockPanel5.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel5.FloatSize = New System.Drawing.Size(304, 139)
            Me.dockPanel5.ID = New System.Guid("dbdb0ba9-5443-476b-93ad-ec35678d61ef")
            Me.dockPanel5.Location = New System.Drawing.Point(3, 31)
            Me.dockPanel5.Name = "dockPanel5"
            Me.dockPanel5.OriginalSize = New System.Drawing.Size(1102, 137)
            Me.dockPanel5.Size = New System.Drawing.Size(1102, 137)
            Me.dockPanel5.Text = "Output"
            ' 
            ' dockPanel5_Container
            ' 
            Me.dockPanel5_Container.Controls.Add(Me.ucOutput1)
            Me.dockPanel5_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel5_Container.Name = "dockPanel5_Container"
            Me.dockPanel5_Container.Size = New System.Drawing.Size(1102, 137)
            Me.dockPanel5_Container.TabIndex = 0
            ' 
            ' ucOutput1
            ' 
            Me.ucOutput1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ucOutput1.Location = New System.Drawing.Point(0, 0)
            Me.ucOutput1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.ucOutput1.Name = "ucOutput1"
            Me.ucOutput1.Size = New System.Drawing.Size(1102, 137)
            Me.ucOutput1.TabIndex = 0
            ' 
            ' dockPanel3
            ' 
            Me.dockPanel3.Controls.Add(Me.dockPanel3_Container)
            Me.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel3.FloatSize = New System.Drawing.Size(304, 139)
            Me.dockPanel3.ID = New System.Guid("7351d5e2-6da1-45c0-a5b6-13e4e7d7a56e")
            Me.dockPanel3.Location = New System.Drawing.Point(3, 31)
            Me.dockPanel3.Name = "dockPanel3"
            Me.dockPanel3.OriginalSize = New System.Drawing.Size(1102, 137)
            Me.dockPanel3.Size = New System.Drawing.Size(1102, 137)
            Me.dockPanel3.TabText = "Task List"
            Me.dockPanel3.Text = "Task List - 0 Build Errors"
            ' 
            ' dockPanel3_Container
            ' 
            Me.dockPanel3_Container.Controls.Add(Me.ucTaskList1)
            Me.dockPanel3_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel3_Container.Name = "dockPanel3_Container"
            Me.dockPanel3_Container.Size = New System.Drawing.Size(1102, 137)
            Me.dockPanel3_Container.TabIndex = 0
            ' 
            ' ucTaskList1
            ' 
            Me.ucTaskList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ucTaskList1.Location = New System.Drawing.Point(0, 0)
            Me.ucTaskList1.Margin = New System.Windows.Forms.Padding(2)
            Me.ucTaskList1.Name = "ucTaskList1"
            Me.ucTaskList1.Size = New System.Drawing.Size(1102, 137)
            Me.ucTaskList1.TabIndex = 0
            ' 
            ' dockPanel4
            ' 
            Me.dockPanel4.Controls.Add(Me.dockPanel4_Container)
            Me.dockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel4.FloatSize = New System.Drawing.Size(304, 139)
            Me.dockPanel4.ID = New System.Guid("47b3ea95-3900-46d6-b24c-5f3a779b1ae7")
            Me.dockPanel4.Location = New System.Drawing.Point(3, 31)
            Me.dockPanel4.Name = "dockPanel4"
            Me.dockPanel4.OriginalSize = New System.Drawing.Size(1102, 137)
            Me.dockPanel4.Size = New System.Drawing.Size(1102, 137)
            Me.dockPanel4.Text = "Find Results"
            ' 
            ' dockPanel4_Container
            ' 
            Me.dockPanel4_Container.Controls.Add(Me.textBox1)
            Me.dockPanel4_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel4_Container.Name = "dockPanel4_Container"
            Me.dockPanel4_Container.Size = New System.Drawing.Size(1102, 137)
            Me.dockPanel4_Container.TabIndex = 0
            ' 
            ' textBox1
            ' 
            Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox1.EditValue = ""
            Me.textBox1.Location = New System.Drawing.Point(0, 0)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Properties.Appearance.Font = New System.Drawing.Font("Courier New", 8.25F)
            Me.textBox1.Properties.Appearance.Options.UseFont = True
            Me.textBox1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.textBox1.Size = New System.Drawing.Size(1102, 137)
            Me.textBox1.TabIndex = 0
            ' 
            ' panelContainer1
            ' 
            Me.panelContainer1.ActiveChild = Me.dockPanel1
            Me.panelContainer1.Controls.Add(Me.dockPanel1)
            Me.panelContainer1.Controls.Add(Me.dockPanel2)
            Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.panelContainer1.FloatSize = New System.Drawing.Size(253, 266)
            Me.panelContainer1.ID = New System.Guid("6c74c2c4-9754-4cea-b108-63e9e7e6c9a0")
            Me.panelContainer1.Location = New System.Drawing.Point(891, 58)
            Me.panelContainer1.Name = "panelContainer1"
            Me.panelContainer1.OriginalSize = New System.Drawing.Size(242, 200)
            Me.panelContainer1.Size = New System.Drawing.Size(242, 382)
            Me.panelContainer1.Tabbed = True
            Me.panelContainer1.Text = "panelContainer1"
            ' 
            ' dockPanel1
            ' 
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel1.FloatSize = New System.Drawing.Size(253, 266)
            Me.dockPanel1.ID = New System.Guid("70a62a0b-1c55-4e72-bef0-661a97c3e934")
            Me.dockPanel1.Location = New System.Drawing.Point(4, 30)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(235, 322)
            Me.dockPanel1.Size = New System.Drawing.Size(235, 320)
            Me.dockPanel1.TabText = "Solution Explorer"
            Me.dockPanel1.Text = "Solution Explorer"
            ' 
            ' dockPanel1_Container
            ' 
            Me.dockPanel1_Container.Controls.Add(Me.solutionExplorer)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(235, 320)
            Me.dockPanel1_Container.TabIndex = 0
            ' 
            ' solutionExplorer
            ' 
            Me.solutionExplorer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.solutionExplorer.Location = New System.Drawing.Point(0, 0)
            Me.solutionExplorer.Name = "solutionExplorer"
            Me.solutionExplorer.Size = New System.Drawing.Size(235, 320)
            Me.solutionExplorer.TabIndex = 0
            AddHandler Me.solutionExplorer.PropertiesItemClick, New System.EventHandler(AddressOf Me.solutionExplorer_PropertiesItemClick)
            AddHandler Me.solutionExplorer.TreeViewItemClick, New System.EventHandler(AddressOf Me.solutionExplorer_TreeViewItemClick)
            ' 
            ' dockPanel2
            ' 
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel2.ID = New System.Guid("96144626-be47-440b-ae5f-2c5507db5076")
            Me.dockPanel2.Location = New System.Drawing.Point(4, 30)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(235, 322)
            Me.dockPanel2.Size = New System.Drawing.Size(235, 320)
            Me.dockPanel2.Text = "Properties"
            ' 
            ' dockPanel2_Container
            ' 
            Me.dockPanel2_Container.Controls.Add(Me.ucProperties1)
            Me.dockPanel2_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(235, 320)
            Me.dockPanel2_Container.TabIndex = 0
            ' 
            ' ucProperties1
            ' 
            Me.ucProperties1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ucProperties1.Location = New System.Drawing.Point(0, 0)
            Me.ucProperties1.Margin = New System.Windows.Forms.Padding(2)
            Me.ucProperties1.Name = "ucProperties1"
            Me.ucProperties1.Padding = New System.Windows.Forms.Padding(3)
            Me.ucProperties1.Size = New System.Drawing.Size(235, 320)
            Me.ucProperties1.TabIndex = 0
            ' 
            ' siFile
            ' 
            Me.siFile.Caption = "&File"
            Me.siFile.CategoryGuid = New System.Guid("a984a9d9-f96f-425a-8857-fe4de6df48c2")
            Me.siFile.Id = 0
            Me.siFile.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.siNew), New DevExpress.XtraBars.LinkPersistInfo(Me.iOpen), New DevExpress.XtraBars.LinkPersistInfo(Me.iClose), New DevExpress.XtraBars.LinkPersistInfo(Me.iAddNewItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.iAddExistingItem), New DevExpress.XtraBars.LinkPersistInfo(Me.siAddProject), New DevExpress.XtraBars.LinkPersistInfo(Me.iOpenSolution, True), New DevExpress.XtraBars.LinkPersistInfo(Me.iCloseSolution), New DevExpress.XtraBars.LinkPersistInfo(Me.iSaveAll, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, Me.iPageSetup, "", True, False, True, 0), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, Me.iPrint, "", False, False, True, 0), New DevExpress.XtraBars.LinkPersistInfo(Me.iExit, True)})
            Me.siFile.Name = "siFile"
            ' 
            ' siNew
            ' 
            Me.siNew.Caption = "&New"
            Me.siNew.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.siNew.Id = 2
            Me.siNew.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iFile), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.iProject), New DevExpress.XtraBars.LinkPersistInfo(Me.iBlankSolution)})
            Me.siNew.Name = "siNew"
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "Web Site..."
            Me.barButtonItem1.Id = 75
            Me.barButtonItem1.ImageOptions.ImageIndex = 37
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' iOpen
            ' 
            Me.iOpen.Caption = "&Open"
            Me.iOpen.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iOpen.Id = 3
            Me.iOpen.Name = "iOpen"
            ' 
            ' iClose
            ' 
            Me.iClose.Caption = "&Close"
            Me.iClose.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iClose.Id = 4
            Me.iClose.Name = "iClose"
            ' 
            ' iAddExistingItem
            ' 
            Me.iAddExistingItem.Caption = "Add Existin&g Item..."
            Me.iAddExistingItem.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iAddExistingItem.Id = 9
            Me.iAddExistingItem.ImageOptions.ImageIndex = 4
            Me.iAddExistingItem.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.B))
            Me.iAddExistingItem.Name = "iAddExistingItem"
            ' 
            ' siAddProject
            ' 
            Me.siAddProject.Caption = "A&dd Project"
            Me.siAddProject.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.siAddProject.Id = 10
            Me.siAddProject.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iNewProject), New DevExpress.XtraBars.LinkPersistInfo(Me.iExistingProject)})
            Me.siAddProject.Name = "siAddProject"
            ' 
            ' iNewProject
            ' 
            Me.iNewProject.Caption = "&New Project..."
            Me.iNewProject.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iNewProject.Hint = "New Project"
            Me.iNewProject.Id = 11
            Me.iNewProject.Name = "iNewProject"
            AddHandler Me.iNewProject.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.iNewItemClick)
            ' 
            ' iExistingProject
            ' 
            Me.iExistingProject.Caption = "&Existing Project..."
            Me.iExistingProject.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iExistingProject.Id = 12
            Me.iExistingProject.Name = "iExistingProject"
            ' 
            ' iOpenSolution
            ' 
            Me.iOpenSolution.Caption = "Op&en Solution..."
            Me.iOpenSolution.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iOpenSolution.Id = 14
            Me.iOpenSolution.ImageOptions.ImageIndex = 5
            Me.iOpenSolution.Name = "iOpenSolution"
            ' 
            ' iCloseSolution
            ' 
            Me.iCloseSolution.Caption = "Close Solu&tion"
            Me.iCloseSolution.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iCloseSolution.Id = 15
            Me.iCloseSolution.ImageOptions.ImageIndex = 6
            Me.iCloseSolution.Name = "iCloseSolution"
            ' 
            ' iPageSetup
            ' 
            Me.iPageSetup.Caption = "Page Set&up..."
            Me.iPageSetup.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iPageSetup.Id = 16
            Me.iPageSetup.ImageOptions.ImageIndex = 8
            Me.iPageSetup.Name = "iPageSetup"
            ' 
            ' iPrint
            ' 
            Me.iPrint.Caption = "&Print..."
            Me.iPrint.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iPrint.Id = 17
            Me.iPrint.ImageOptions.ImageIndex = 9
            Me.iPrint.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
            Me.iPrint.Name = "iPrint"
            ' 
            ' iExit
            ' 
            Me.iExit.Caption = "E&xit"
            Me.iExit.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iExit.Id = 18
            Me.iExit.Name = "iExit"
            AddHandler Me.iExit.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.iExit_ItemClick)
            ' 
            ' siEdit
            ' 
            Me.siEdit.Caption = "&Edit"
            Me.siEdit.CategoryGuid = New System.Guid("a984a9d9-f96f-425a-8857-fe4de6df48c2")
            Me.siEdit.Id = 1
            Me.siEdit.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.siFind, True)})
            Me.siEdit.Name = "siEdit"
            ' 
            ' siFind
            ' 
            Me.siFind.Caption = "&Find and Replace"
            Me.siFind.CategoryGuid = New System.Guid("ac82dbe7-c530-4aa2-b6de-94a7777426fe")
            Me.siFind.Id = 27
            Me.siFind.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iFind), New DevExpress.XtraBars.LinkPersistInfo(Me.iReplace), New DevExpress.XtraBars.LinkPersistInfo(Me.iFindinFiles)})
            Me.siFind.Name = "siFind"
            ' 
            ' iFind
            ' 
            Me.iFind.Caption = "&Find"
            Me.iFind.CategoryGuid = New System.Guid("ac82dbe7-c530-4aa2-b6de-94a7777426fe")
            Me.iFind.Id = 28
            Me.iFind.ImageOptions.ImageIndex = 16
            Me.iFind.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
            Me.iFind.Name = "iFind"
            ' 
            ' iReplace
            ' 
            Me.iReplace.Caption = "R&eplace"
            Me.iReplace.CategoryGuid = New System.Guid("ac82dbe7-c530-4aa2-b6de-94a7777426fe")
            Me.iReplace.Id = 29
            Me.iReplace.ImageOptions.ImageIndex = 17
            Me.iReplace.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H))
            Me.iReplace.Name = "iReplace"
            ' 
            ' siWindow
            ' 
            Me.siWindow.Caption = "&Window"
            Me.siWindow.CategoryGuid = New System.Guid("a984a9d9-f96f-425a-8857-fe4de6df48c2")
            Me.siWindow.Id = 45
            Me.siWindow.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barDockingMenuItem1)})
            Me.siWindow.Name = "siWindow"
            ' 
            ' barDockingMenuItem1
            ' 
            Me.barDockingMenuItem1.Caption = "Window"
            Me.barDockingMenuItem1.Id = 72
            Me.barDockingMenuItem1.Name = "barDockingMenuItem1"
            ' 
            ' siLayouts
            ' 
            Me.siLayouts.Caption = "&Layouts"
            Me.siLayouts.CategoryGuid = New System.Guid("a984a9d9-f96f-425a-8857-fe4de6df48c2")
            Me.siLayouts.Id = 49
            Me.siLayouts.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iLoadLayout), New DevExpress.XtraBars.LinkPersistInfo(Me.iSaveLayout)})
            Me.siLayouts.Name = "siLayouts"
            ' 
            ' bsiHelp
            ' 
            Me.bsiHelp.Caption = "&Help"
            Me.bsiHelp.Id = 73
            Me.bsiHelp.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iAbout)})
            Me.bsiHelp.Name = "bsiHelp"
            ' 
            ' iAbout
            ' 
            Me.iAbout.Caption = "&About"
            Me.iAbout.Id = 74
            Me.iAbout.ImageOptions.ImageIndex = 36
            Me.iAbout.Name = "iAbout"
            AddHandler Me.iAbout.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.iAbout_ItemClick)
            ' 
            ' barEditItem1
            ' 
            Me.barEditItem1.Caption = "barEditItem1"
            Me.barEditItem1.Edit = Me.repositoryItemSearchControl1
            Me.barEditItem1.EditWidth = 220
            Me.barEditItem1.Id = 76
            Me.barEditItem1.Name = "barEditItem1"
            ' 
            ' repositoryItemSearchControl1
            ' 
            Me.repositoryItemSearchControl1.AutoHeight = False
            Me.repositoryItemSearchControl1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1"
            Me.repositoryItemSearchControl1.NullValuePrompt = "Search Visual Studio"
            ' 
            ' barHeaderItem1
            ' 
            Me.barHeaderItem1.Caption = "barHeaderItem1"
            Me.barHeaderItem1.Id = 77
            Me.barHeaderItem1.Name = "barHeaderItem1"
            ' 
            ' barStaticItem1
            ' 
            Me.barStaticItem1.AllowFocus = DevExpress.Utils.DefaultBoolean.[False]
            Me.barStaticItem1.Caption = "Visual Studio Inspired UI Demo"
            Me.barStaticItem1.Id = 78
            Me.barStaticItem1.LeftIndent = 21
            Me.barStaticItem1.Name = "barStaticItem1"
            ' 
            ' repositoryItemImageComboBox1
            ' 
            Me.repositoryItemImageComboBox1.AutoHeight = False
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            ' 
            ' documentManager
            ' 
            Me.documentManager.BarAndDockingController = Me.barAndDockingController
            Me.documentManager.ContainerControl = Me
            Me.documentManager.MenuManager = Me.barManager
            Me.documentManager.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always
            Me.documentManager.ShowToolTips = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentManager.View = Me.tabbedView
            Me.documentManager.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.tabbedView})
            ' 
            ' tabbedView
            ' 
            Me.tabbedView.DocumentProperties.AllowPin = True
            Me.tabbedView.DocumentSelectorProperties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
            Me.tabbedView.DocumentSelectorProperties.DocumentFooterFormat = "{0}\{1}"
            Me.tabbedView.DocumentSelectorProperties.DocumentHeaderFormat = "{0}<br>Source file"
            Me.tabbedView.DocumentSelectorProperties.PanelFooterFormat = ""
            Me.tabbedView.FloatingDocumentContainer = DevExpress.XtraBars.Docking2010.Views.FloatingDocumentContainer.DocumentsHost
            ' 
            ' fileTypeSvgImages
            ' 
            Me.fileTypeSvgImages.Add("CSharpFile_SolutionExplorerNode", CType((resources.GetObject("fileTypeSvgImages.CSharpFile_SolutionExplorerNode")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' toolbarFormControl1
            ' 
            Me.toolbarFormControl1.Location = New System.Drawing.Point(0, 0)
            Me.toolbarFormControl1.Manager = Me.barManager
            Me.toolbarFormControl1.Name = "toolbarFormControl1"
            Me.toolbarFormControl1.Size = New System.Drawing.Size(1133, 30)
            Me.toolbarFormControl1.TabIndex = 13
            Me.toolbarFormControl1.TabStop = False
            Me.toolbarFormControl1.TitleItemLinks.Add(Me.siFile)
            Me.toolbarFormControl1.TitleItemLinks.Add(Me.siEdit)
            Me.toolbarFormControl1.TitleItemLinks.Add(Me.siLayouts)
            Me.toolbarFormControl1.TitleItemLinks.Add(Me.siWindow)
            Me.toolbarFormControl1.TitleItemLinks.Add(Me.bsiHelp)
            Me.toolbarFormControl1.TitleItemLinks.Add(Me.barEditItem1)
            Me.toolbarFormControl1.TitleItemLinks.Add(Me.barStaticItem1)
            Me.toolbarFormControl1.ToolbarForm = Me
            ' 
            ' frmMain
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(1133, 662)
            Me.Controls.Add(Me.popupControlContainer1)
            Me.Controls.Add(Me.panelContainer1)
            Me.Controls.Add(Me.panelContainer2)
            Me.Controls.Add(Me.hideContainerLeft)
            Me.Controls.Add(Me.barDockControl3)
            Me.Controls.Add(Me.barDockControl4)
            Me.Controls.Add(Me.barDockControl2)
            Me.Controls.Add(Me.barDockControl1)
            Me.Controls.Add(Me.toolbarFormControl1)
            Me.IconOptions.Icon = CType((resources.GetObject("frmMain.IconOptions.Icon")), System.Drawing.Icon)
            Me.Name = "frmMain"
            Me.ShowText = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Visual Studio Inspired UI"
            Me.ToolbarFormControl = Me.toolbarFormControl1
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.frmMain_Load)
            CType((Me.barManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.popupMenu1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryImageComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.popupControlContainer1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupControlContainer1.ResumeLayout(False)
            CType((Me.treeView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.classViewSvgImages), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.barAndDockingController), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).EndInit()
            Me.hideContainerLeft.ResumeLayout(False)
            Me.dockPanel6.ResumeLayout(False)
            Me.dockPanel6_Container.ResumeLayout(False)
            CType((Me.mainMenuSvgImages), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelContainer2.ResumeLayout(False)
            Me.dockPanel5.ResumeLayout(False)
            Me.dockPanel5_Container.ResumeLayout(False)
            Me.dockPanel3.ResumeLayout(False)
            Me.dockPanel3_Container.ResumeLayout(False)
            Me.dockPanel4.ResumeLayout(False)
            Me.dockPanel4_Container.ResumeLayout(False)
            CType((Me.textBox1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelContainer1.ResumeLayout(False)
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel1_Container.ResumeLayout(False)
            Me.dockPanel2.ResumeLayout(False)
            Me.dockPanel2_Container.ResumeLayout(False)
            CType((Me.repositoryItemSearchControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabbedView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.fileTypeSvgImages), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.toolbarFormControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private barManager As DevExpress.XtraBars.ToolbarForm.ToolbarFormManager

        Private barDockControl1 As DevExpress.XtraBars.BarDockControl

        Private barDockControl2 As DevExpress.XtraBars.BarDockControl

        Private barDockControl3 As DevExpress.XtraBars.BarDockControl

        Private barDockControl4 As DevExpress.XtraBars.BarDockControl

        Private siFile As DevExpress.XtraBars.BarSubItem

        Private siEdit As DevExpress.XtraBars.BarSubItem

        Private siNew As DevExpress.XtraBars.BarSubItem

        Private iOpen As DevExpress.XtraBars.BarButtonItem

        Private iClose As DevExpress.XtraBars.BarButtonItem

        Private iProject As DevExpress.XtraBars.BarButtonItem

        Private iFile As DevExpress.XtraBars.BarButtonItem

        Private iBlankSolution As DevExpress.XtraBars.BarButtonItem

        Private iAddNewItem As DevExpress.XtraBars.BarButtonItem

        Private iAddExistingItem As DevExpress.XtraBars.BarButtonItem

        Private siAddProject As DevExpress.XtraBars.BarSubItem

        Private iNewProject As DevExpress.XtraBars.BarButtonItem

        Private iExistingProject As DevExpress.XtraBars.BarButtonItem

        Private iSaveAll As DevExpress.XtraBars.BarButtonItem

        Private iOpenSolution As DevExpress.XtraBars.BarButtonItem

        Private iCloseSolution As DevExpress.XtraBars.BarButtonItem

        Private iPageSetup As DevExpress.XtraBars.BarButtonItem

        Private iPrint As DevExpress.XtraBars.BarButtonItem

        Private iExit As DevExpress.XtraBars.BarButtonItem

        Private siFind As DevExpress.XtraBars.BarSubItem

        Private iFind As DevExpress.XtraBars.BarButtonItem

        Private iReplace As DevExpress.XtraBars.BarButtonItem

        Private iFindinFiles As DevExpress.XtraBars.BarButtonItem

        Private iNew As DevExpress.XtraBars.BarButtonItem

        Private popupMenu1 As DevExpress.XtraBars.PopupMenu

        Private iOpenFile As DevExpress.XtraBars.BarButtonItem

        Private iSave As DevExpress.XtraBars.BarButtonItem

        Private iStart As DevExpress.XtraBars.BarButtonItem

        Private eConfiguration As DevExpress.XtraBars.BarEditItem

        Private repositoryImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private eFind As DevExpress.XtraBars.BarEditItem

        Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox

        Private iSolutionExplorer As DevExpress.XtraBars.BarButtonItem

        Private iProperties As DevExpress.XtraBars.BarButtonItem

        Private iToolbox As DevExpress.XtraBars.BarButtonItem

        Private iClassView As DevExpress.XtraBars.BarButtonItem

        Private textBox1 As DevExpress.XtraEditors.MemoEdit

        Private solutionExplorer As DevExpress.XtraBars.Demos.DockingDemo.ucSolutionExplorer

        Private iTaskList As DevExpress.XtraBars.BarButtonItem

        Private iFindResults As DevExpress.XtraBars.BarButtonItem

        Private iOutput As DevExpress.XtraBars.BarButtonItem

        Private siWindow As DevExpress.XtraBars.BarSubItem

        Private iStatus1 As DevExpress.XtraBars.BarStaticItem

        Private popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer

        Private treeView1 As DevExpress.XtraTreeList.TreeList

        Private iLoadLayout As DevExpress.XtraBars.BarButtonItem

        Private iSaveLayout As DevExpress.XtraBars.BarButtonItem

        Private siLayouts As DevExpress.XtraBars.BarSubItem

        Private bar2 As DevExpress.XtraBars.Bar

        Private bar3 As DevExpress.XtraBars.Bar

        Private bar4 As DevExpress.XtraBars.Bar

        Private bar5 As DevExpress.XtraBars.Bar

        Private dockManager As DevExpress.XtraBars.Docking.DockManager

        Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanel2 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanel3 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanel4 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel4_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanel5 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel5_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private panelContainer2 As DevExpress.XtraBars.Docking.DockPanel

        Private panelContainer1 As DevExpress.XtraBars.Docking.DockPanel

        Private barAndDockingController As DevExpress.XtraBars.BarAndDockingController

        Private dockPanel6 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel6_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private hideContainerLeft As DevExpress.XtraBars.Docking.AutoHideContainer

        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private components As System.ComponentModel.IContainer

        Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager

        Private tabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView

        Private barDockingMenuItem1 As DevExpress.XtraBars.BarDockingMenuItem

        Private bsiHelp As DevExpress.XtraBars.BarSubItem

        Private iAbout As DevExpress.XtraBars.BarButtonItem

        Private bar6 As DevExpress.XtraBars.Bar

        Private ucProperties1 As DevExpress.XtraBars.Demos.DockingDemo.ucProperties

        Private ucTaskList1 As DevExpress.XtraBars.Demos.DockingDemo.ucTaskList

        Private ucOutput1 As DevExpress.XtraBars.Demos.DockingDemo.ucOutput

        Private ucToolbox1 As DevExpress.XtraBars.Demos.DockingDemo.ucToolbox

        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem

        Private classViewSvgImages As DevExpress.Utils.SvgImageCollection

        Private fileTypeSvgImages As DevExpress.Utils.SvgImageCollection

        Private mainMenuSvgImages As DevExpress.Utils.SvgImageCollection

        Private toolbarFormControl1 As DevExpress.XtraBars.ToolbarForm.ToolbarFormControl

        Private barEditItem1 As DevExpress.XtraBars.BarEditItem

        Private repositoryItemSearchControl1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl

        Private barStaticItem1 As DevExpress.XtraBars.BarStaticItem

        Private barHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
    End Class
End Namespace
