namespace DevExpress.XtraBars.Demos.DockingDemo {
    partial class frmMain {
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.barManager = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.iNew = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.iProject = new DevExpress.XtraBars.BarButtonItem();
            this.iFile = new DevExpress.XtraBars.BarButtonItem();
            this.iBlankSolution = new DevExpress.XtraBars.BarButtonItem();
            this.iAddNewItem = new DevExpress.XtraBars.BarButtonItem();
            this.iOpenFile = new DevExpress.XtraBars.BarButtonItem();
            this.iSave = new DevExpress.XtraBars.BarButtonItem();
            this.iSaveAll = new DevExpress.XtraBars.BarButtonItem();
            this.iStart = new DevExpress.XtraBars.BarButtonItem();
            this.eConfiguration = new DevExpress.XtraBars.BarEditItem();
            this.repositoryImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.iFindinFiles = new DevExpress.XtraBars.BarButtonItem();
            this.eFind = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.iSolutionExplorer = new DevExpress.XtraBars.BarButtonItem();
            this.iProperties = new DevExpress.XtraBars.BarButtonItem();
            this.iToolbox = new DevExpress.XtraBars.BarButtonItem();
            this.iClassView = new DevExpress.XtraBars.BarButtonItem();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.treeView1 = new DevExpress.XtraTreeList.TreeList();
            this.classViewSvgImages = new DevExpress.Utils.SvgImageCollection(this.components);
            this.iTaskList = new DevExpress.XtraBars.BarButtonItem();
            this.iFindResults = new DevExpress.XtraBars.BarButtonItem();
            this.iOutput = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.iStatus1 = new DevExpress.XtraBars.BarStaticItem();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.iLoadLayout = new DevExpress.XtraBars.BarButtonItem();
            this.iSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.barAndDockingController = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerLeft = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.dockPanel6 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel6_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ucToolbox1 = new DevExpress.XtraBars.Demos.DockingDemo.ucToolbox();
            this.mainMenuSvgImages = new DevExpress.Utils.SvgImageCollection(this.components);
            this.panelContainer2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel5 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel5_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ucOutput1 = new DevExpress.XtraBars.Demos.DockingDemo.ucOutput();
            this.dockPanel3 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ucTaskList1 = new DevExpress.XtraBars.Demos.DockingDemo.ucTaskList();
            this.dockPanel4 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel4_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.textBox1 = new DevExpress.XtraEditors.MemoEdit();
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.solutionExplorer = new DevExpress.XtraBars.Demos.DockingDemo.ucSolutionExplorer();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ucProperties1 = new DevExpress.XtraBars.Demos.DockingDemo.ucProperties();
            this.siFile = new DevExpress.XtraBars.BarSubItem();
            this.siNew = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.iOpen = new DevExpress.XtraBars.BarButtonItem();
            this.iClose = new DevExpress.XtraBars.BarButtonItem();
            this.iAddExistingItem = new DevExpress.XtraBars.BarButtonItem();
            this.siAddProject = new DevExpress.XtraBars.BarSubItem();
            this.iNewProject = new DevExpress.XtraBars.BarButtonItem();
            this.iExistingProject = new DevExpress.XtraBars.BarButtonItem();
            this.iOpenSolution = new DevExpress.XtraBars.BarButtonItem();
            this.iCloseSolution = new DevExpress.XtraBars.BarButtonItem();
            this.iPageSetup = new DevExpress.XtraBars.BarButtonItem();
            this.iPrint = new DevExpress.XtraBars.BarButtonItem();
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.siEdit = new DevExpress.XtraBars.BarSubItem();
            this.siFind = new DevExpress.XtraBars.BarSubItem();
            this.iFind = new DevExpress.XtraBars.BarButtonItem();
            this.iReplace = new DevExpress.XtraBars.BarButtonItem();
            this.siWindow = new DevExpress.XtraBars.BarSubItem();
            this.barDockingMenuItem1 = new DevExpress.XtraBars.BarDockingMenuItem();
            this.siLayouts = new DevExpress.XtraBars.BarSubItem();
            this.bsiHelp = new DevExpress.XtraBars.BarSubItem();
            this.iAbout = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.fileTypeSvgImages = new DevExpress.Utils.SvgImageCollection(this.components);
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classViewSvgImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.hideContainerLeft.SuspendLayout();
            this.dockPanel6.SuspendLayout();
            this.dockPanel6_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuSvgImages)).BeginInit();
            this.panelContainer2.SuspendLayout();
            this.dockPanel5.SuspendLayout();
            this.dockPanel5_Container.SuspendLayout();
            this.dockPanel3.SuspendLayout();
            this.dockPanel3_Container.SuspendLayout();
            this.dockPanel4.SuspendLayout();
            this.dockPanel4_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1.Properties)).BeginInit();
            this.panelContainer1.SuspendLayout();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.dockPanel2.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileTypeSvgImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3,
            this.bar4,
            this.bar5,
            this.bar6});
            this.barManager.Categories.AddRange(new DevExpress.XtraBars.BarManagerCategory[] {
            new DevExpress.XtraBars.BarManagerCategory("Built-in Menus", new System.Guid("a984a9d9-f96f-425a-8857-fe4de6df48c2")),
            new DevExpress.XtraBars.BarManagerCategory("File", new System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")),
            new DevExpress.XtraBars.BarManagerCategory("Edit", new System.Guid("ac82dbe7-c530-4aa2-b6de-94a7777426fe")),
            new DevExpress.XtraBars.BarManagerCategory("Standard", new System.Guid("fbaaf85d-943d-4ccd-8517-fc398efe9c7b")),
            new DevExpress.XtraBars.BarManagerCategory("View", new System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4")),
            new DevExpress.XtraBars.BarManagerCategory("Window", new System.Guid("faa74de1-bd23-44b9-955d-6ba635fa0f01")),
            new DevExpress.XtraBars.BarManagerCategory("Status", new System.Guid("d3532f9f-c716-4c40-8731-d110e1a41e64")),
            new DevExpress.XtraBars.BarManagerCategory("Layouts", new System.Guid("f2b2eae8-5b98-43eb-81aa-d999b20fd3d3")),
            new DevExpress.XtraBars.BarManagerCategory("PaintStyles", new System.Guid("d0a113b2-425b-47f5-a6b5-0aefb1859507"))});
            this.barManager.Controller = this.barAndDockingController;
            this.barManager.DockControls.Add(this.barDockControl1);
            this.barManager.DockControls.Add(this.barDockControl2);
            this.barManager.DockControls.Add(this.barDockControl3);
            this.barManager.DockControls.Add(this.barDockControl4);
            this.barManager.DockManager = this.dockManager;
            this.barManager.Form = this;
            this.barManager.Images = this.mainMenuSvgImages;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.siFile,
            this.siEdit,
            this.siNew,
            this.iOpen,
            this.iClose,
            this.iProject,
            this.iFile,
            this.iBlankSolution,
            this.iAddNewItem,
            this.iAddExistingItem,
            this.siAddProject,
            this.iNewProject,
            this.iExistingProject,
            this.iSaveAll,
            this.iOpenSolution,
            this.iCloseSolution,
            this.iPageSetup,
            this.iPrint,
            this.iExit,
            this.siFind,
            this.iFind,
            this.iReplace,
            this.iFindinFiles,
            this.iNew,
            this.iOpenFile,
            this.iSave,
            this.iStart,
            this.eConfiguration,
            this.eFind,
            this.iSolutionExplorer,
            this.iProperties,
            this.iToolbox,
            this.iClassView,
            this.iTaskList,
            this.iFindResults,
            this.iOutput,
            this.siWindow,
            this.iStatus1,
            this.iLoadLayout,
            this.iSaveLayout,
            this.siLayouts,
            this.barDockingMenuItem1,
            this.bsiHelp,
            this.iAbout,
            this.barButtonItem1,
            this.barEditItem1,
            this.barHeaderItem1,
            this.barStaticItem1});
            this.barManager.MaxItemId = 79;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryImageComboBox1,
            this.repositoryItemComboBox1,
            this.repositoryItemImageComboBox1,
            this.repositoryItemSearchControl1});
            this.barManager.StatusBar = this.bar4;
            this.barManager.Merge += new DevExpress.XtraBars.BarManagerMergeEventHandler(this.barManager1_Merge);
            this.barManager.UnMerge += new DevExpress.XtraBars.BarManagerMergeEventHandler(this.barManager1_UnMerge);
            // 
            // bar2
            // 
            this.bar2.BarName = "Standard";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(38, 139);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.iAddNewItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.iOpenFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.iSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.iSaveAll),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.iStart, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.eConfiguration, "", false, true, true, 88),
            new DevExpress.XtraBars.LinkPersistInfo(this.iFindinFiles, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.eFind, "", false, true, true, 97)});
            this.bar2.Text = "Standard";
            // 
            // iNew
            // 
            this.iNew.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.iNew.Caption = "New Project";
            this.iNew.CategoryGuid = new System.Guid("fbaaf85d-943d-4ccd-8517-fc398efe9c7b");
            this.iNew.DropDownControl = this.popupMenu1;
            this.iNew.Hint = "New Project";
            this.iNew.Id = 31;
            this.iNew.ImageOptions.ImageIndex = 10;
            this.iNew.Name = "iNew";
            this.iNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iNewItemClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iProject),
            new DevExpress.XtraBars.LinkPersistInfo(this.iFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.iBlankSolution)});
            this.popupMenu1.Manager = this.barManager;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // iProject
            // 
            this.iProject.Caption = "Team &Project...";
            this.iProject.CategoryGuid = new System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52");
            this.iProject.Hint = "New Project";
            this.iProject.Id = 5;
            this.iProject.ImageOptions.ImageIndex = 0;
            this.iProject.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.N));
            this.iProject.Name = "iProject";
            this.iProject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iNewItemClick);
            // 
            // iFile
            // 
            this.iFile.Caption = "&File...";
            this.iFile.CategoryGuid = new System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52");
            this.iFile.Hint = "New File";
            this.iFile.Id = 6;
            this.iFile.ImageOptions.ImageIndex = 1;
            this.iFile.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.iFile.Name = "iFile";
            this.iFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iNewItemClick);
            // 
            // iBlankSolution
            // 
            this.iBlankSolution.Caption = "&Blank Solution...";
            this.iBlankSolution.CategoryGuid = new System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52");
            this.iBlankSolution.Hint = "Blank Solution";
            this.iBlankSolution.Id = 7;
            this.iBlankSolution.ImageOptions.ImageIndex = 2;
            this.iBlankSolution.Name = "iBlankSolution";
            this.iBlankSolution.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iNewItemClick);
            // 
            // iAddNewItem
            // 
            this.iAddNewItem.Caption = "Add Ne&w Item...";
            this.iAddNewItem.CategoryGuid = new System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52");
            this.iAddNewItem.Hint = "Add New Item";
            this.iAddNewItem.Id = 8;
            this.iAddNewItem.ImageOptions.ImageIndex = 3;
            this.iAddNewItem.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.A));
            this.iAddNewItem.Name = "iAddNewItem";
            // 
            // iOpenFile
            // 
            this.iOpenFile.Caption = "Open File";
            this.iOpenFile.CategoryGuid = new System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52");
            this.iOpenFile.Hint = "Open File";
            this.iOpenFile.Id = 32;
            this.iOpenFile.ImageOptions.ImageIndex = 5;
            this.iOpenFile.Name = "iOpenFile";
            // 
            // iSave
            // 
            this.iSave.Caption = "Save";
            this.iSave.CategoryGuid = new System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52");
            this.iSave.Enabled = false;
            this.iSave.Hint = "Save";
            this.iSave.Id = 33;
            this.iSave.ImageOptions.ImageIndex = 21;
            this.iSave.Name = "iSave";
            // 
            // iSaveAll
            // 
            this.iSaveAll.Caption = "Save A&ll";
            this.iSaveAll.CategoryGuid = new System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52");
            this.iSaveAll.Enabled = false;
            this.iSaveAll.Hint = "Save All";
            this.iSaveAll.Id = 13;
            this.iSaveAll.ImageOptions.ImageIndex = 7;
            this.iSaveAll.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.S));
            this.iSaveAll.Name = "iSaveAll";
            // 
            // iStart
            // 
            this.iStart.Caption = "Start";
            this.iStart.CategoryGuid = new System.Guid("fbaaf85d-943d-4ccd-8517-fc398efe9c7b");
            this.iStart.Hint = "Start";
            this.iStart.Id = 34;
            this.iStart.ImageOptions.ImageIndex = 22;
            this.iStart.Name = "iStart";
            // 
            // eConfiguration
            // 
            this.eConfiguration.Caption = "Solution Configuration";
            this.eConfiguration.CategoryGuid = new System.Guid("fbaaf85d-943d-4ccd-8517-fc398efe9c7b");
            this.eConfiguration.Edit = this.repositoryImageComboBox1;
            this.eConfiguration.EditHeight = 22;
            this.eConfiguration.EditValue = "Debug";
            this.eConfiguration.Hint = "Solution Configuration";
            this.eConfiguration.Id = 35;
            this.eConfiguration.Name = "eConfiguration";
            this.eConfiguration.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // repositoryImageComboBox1
            // 
            this.repositoryImageComboBox1.AllowFocused = false;
            this.repositoryImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryImageComboBox1.Name = "repositoryImageComboBox1";
            // 
            // iFindinFiles
            // 
            this.iFindinFiles.Caption = "F&ind in Files";
            this.iFindinFiles.CategoryGuid = new System.Guid("ac82dbe7-c530-4aa2-b6de-94a7777426fe");
            this.iFindinFiles.Hint = "Find in Files";
            this.iFindinFiles.Id = 30;
            this.iFindinFiles.ImageOptions.ImageIndex = 18;
            this.iFindinFiles.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.F));
            this.iFindinFiles.Name = "iFindinFiles";
            // 
            // eFind
            // 
            this.eFind.Caption = "Find";
            this.eFind.CategoryGuid = new System.Guid("fbaaf85d-943d-4ccd-8517-fc398efe9c7b");
            this.eFind.Edit = this.repositoryItemComboBox1;
            this.eFind.EditHeight = 22;
            this.eFind.Hint = "Find";
            this.eFind.Id = 36;
            this.eFind.Name = "eFind";
            this.eFind.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AllowFocused = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "barManager1"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repositoryItemComboBox1_KeyDown);
            // 
            // bar3
            // 
            this.bar3.BarName = "View";
            this.bar3.DockCol = 2;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.FloatLocation = new System.Drawing.Point(36, 181);
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iSolutionExplorer),
            new DevExpress.XtraBars.LinkPersistInfo(this.iProperties),
            new DevExpress.XtraBars.LinkPersistInfo(this.iToolbox),
            new DevExpress.XtraBars.LinkPersistInfo(this.iClassView),
            new DevExpress.XtraBars.LinkPersistInfo(this.iTaskList, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.iFindResults),
            new DevExpress.XtraBars.LinkPersistInfo(this.iOutput)});
            this.bar3.Offset = 400;
            this.bar3.Text = "View";
            // 
            // iSolutionExplorer
            // 
            this.iSolutionExplorer.Caption = "Solution Ex&plorer";
            this.iSolutionExplorer.CategoryGuid = new System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4");
            this.iSolutionExplorer.Hint = "Solution Explorer";
            this.iSolutionExplorer.Id = 37;
            this.iSolutionExplorer.ImageOptions.ImageIndex = 23;
            this.iSolutionExplorer.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.L));
            this.iSolutionExplorer.Name = "iSolutionExplorer";
            this.iSolutionExplorer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iSolutionExplorer_ItemClick);
            // 
            // iProperties
            // 
            this.iProperties.Caption = "Properties &Window";
            this.iProperties.CategoryGuid = new System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4");
            this.iProperties.Hint = "Properties Window";
            this.iProperties.Id = 38;
            this.iProperties.ImageOptions.ImageIndex = 24;
            this.iProperties.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4);
            this.iProperties.Name = "iProperties";
            this.iProperties.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iProperties_ItemClick);
            // 
            // iToolbox
            // 
            this.iToolbox.Caption = "Toolbo&x";
            this.iToolbox.CategoryGuid = new System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4");
            this.iToolbox.Hint = "Toolbox";
            this.iToolbox.Id = 39;
            this.iToolbox.ImageOptions.ImageIndex = 25;
            this.iToolbox.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.X));
            this.iToolbox.Name = "iToolbox";
            this.iToolbox.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iToolbox_ItemClick);
            // 
            // iClassView
            // 
            this.iClassView.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.iClassView.Caption = "Cl&ass View";
            this.iClassView.CategoryGuid = new System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4");
            this.iClassView.DropDownControl = this.popupControlContainer1;
            this.iClassView.Hint = "Class View";
            this.iClassView.Id = 40;
            this.iClassView.ImageOptions.ImageIndex = 26;
            this.iClassView.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.C));
            this.iClassView.Name = "iClassView";
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Controls.Add(this.treeView1);
            this.popupControlContainer1.Location = new System.Drawing.Point(52, 111);
            this.popupControlContainer1.Manager = this.barManager;
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.ShowSizeGrip = true;
            this.popupControlContainer1.Size = new System.Drawing.Size(408, 231);
            this.popupControlContainer1.TabIndex = 5;
            this.popupControlContainer1.Visible = false;
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(408, 231);
            this.treeView1.StateImageList = this.classViewSvgImages;
            this.treeView1.TabIndex = 0;
            // 
            // classViewSvgImages
            // 
            this.classViewSvgImages.Add("Solution_ClassView", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("classViewSvgImages.Solution_ClassView"))));
            this.classViewSvgImages.Add("ClassIcon_ClassView", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("classViewSvgImages.ClassIcon_ClassView"))));
            this.classViewSvgImages.Add("Field_ClassView", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("classViewSvgImages.Field_ClassView"))));
            this.classViewSvgImages.Add("Event_ClassView", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("classViewSvgImages.Event_ClassView"))));
            this.classViewSvgImages.Add("Method_ClassView", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("classViewSvgImages.Method_ClassView"))));
            this.classViewSvgImages.Add("Field-Private_ClassView", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("classViewSvgImages.Field-Private_ClassView"))));
            this.classViewSvgImages.Add("Event-Private_ClassView", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("classViewSvgImages.Event-Private_ClassView"))));
            this.classViewSvgImages.Add("Method-Private_ClassView", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("classViewSvgImages.Method-Private_ClassView"))));
            this.classViewSvgImages.Add("Field-Protected_ClassView", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("classViewSvgImages.Field-Protected_ClassView"))));
            this.classViewSvgImages.Add("Event-Protected_ClassView", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("classViewSvgImages.Event-Protected_ClassView"))));
            this.classViewSvgImages.Add("Method-Protected_ClassView", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("classViewSvgImages.Method-Protected_ClassView"))));
            // 
            // iTaskList
            // 
            this.iTaskList.Caption = "Task List";
            this.iTaskList.CategoryGuid = new System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4");
            this.iTaskList.Hint = "Task List";
            this.iTaskList.Id = 68;
            this.iTaskList.ImageOptions.ImageIndex = 27;
            this.iTaskList.Name = "iTaskList";
            this.iTaskList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iTaskList_ItemClick);
            // 
            // iFindResults
            // 
            this.iFindResults.Caption = "Find Results";
            this.iFindResults.CategoryGuid = new System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4");
            this.iFindResults.Hint = "Find Results";
            this.iFindResults.Id = 69;
            this.iFindResults.ImageOptions.ImageIndex = 28;
            this.iFindResults.Name = "iFindResults";
            this.iFindResults.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iFindResults_ItemClick);
            // 
            // iOutput
            // 
            this.iOutput.Caption = "Output";
            this.iOutput.CategoryGuid = new System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4");
            this.iOutput.Hint = "Output";
            this.iOutput.Id = 70;
            this.iOutput.ImageOptions.ImageIndex = 29;
            this.iOutput.Name = "iOutput";
            this.iOutput.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iOutput_ItemClick);
            // 
            // bar4
            // 
            this.bar4.BarName = "StatusBar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.FloatLocation = new System.Drawing.Point(25, 282);
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iStatus1)});
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.DrawSizeGrip = true;
            this.bar4.OptionsBar.RotateWhenVertical = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "StatusBar";
            // 
            // iStatus1
            // 
            this.iStatus1.AllowFocus = DevExpress.Utils.DefaultBoolean.False;
            this.iStatus1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.iStatus1.Caption = "Ready";
            this.iStatus1.CategoryGuid = new System.Guid("d3532f9f-c716-4c40-8731-d110e1a41e64");
            this.iStatus1.Id = 50;
            this.iStatus1.Name = "iStatus1";
            // 
            // bar5
            // 
            this.bar5.BarName = "Layouts";
            this.bar5.DockCol = 3;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.FloatLocation = new System.Drawing.Point(159, 118);
            this.bar5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iLoadLayout),
            new DevExpress.XtraBars.LinkPersistInfo(this.iSaveLayout)});
            this.bar5.Offset = 665;
            this.bar5.Text = "Layouts";
            // 
            // iLoadLayout
            // 
            this.iLoadLayout.Caption = "&Load Layout...";
            this.iLoadLayout.CategoryGuid = new System.Guid("f2b2eae8-5b98-43eb-81aa-d999b20fd3d3");
            this.iLoadLayout.Hint = "Load Layout";
            this.iLoadLayout.Id = 47;
            this.iLoadLayout.ImageOptions.ImageIndex = 35;
            this.iLoadLayout.Name = "iLoadLayout";
            this.iLoadLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iLoadLayout_ItemClick);
            // 
            // iSaveLayout
            // 
            this.iSaveLayout.Caption = "&Save Layout...";
            this.iSaveLayout.CategoryGuid = new System.Guid("f2b2eae8-5b98-43eb-81aa-d999b20fd3d3");
            this.iSaveLayout.Hint = "Save Layout";
            this.iSaveLayout.Id = 48;
            this.iSaveLayout.ImageOptions.ImageIndex = 34;
            this.iSaveLayout.Name = "iSaveLayout";
            this.iSaveLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iSaveLayout_ItemClick);
            // 
            // bar6
            // 
            this.bar6.BarName = "Edit";
            this.bar6.DockCol = 1;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar6.Offset = 391;
            this.bar6.OptionsBar.AllowRename = true;
            this.bar6.Text = "Common";
            // 
            // barAndDockingController
            // 
            this.barAndDockingController.PaintStyleName = "Skin";
            this.barAndDockingController.PropertiesBar.AllowLinkLighting = false;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 30);
            this.barDockControl1.Manager = this.barManager;
            this.barDockControl1.Size = new System.Drawing.Size(1133, 28);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 640);
            this.barDockControl2.Manager = this.barManager;
            this.barDockControl2.Size = new System.Drawing.Size(1133, 22);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 58);
            this.barDockControl3.Manager = this.barManager;
            this.barDockControl3.Size = new System.Drawing.Size(0, 582);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1133, 58);
            this.barDockControl4.Manager = this.barManager;
            this.barDockControl4.Size = new System.Drawing.Size(0, 582);
            // 
            // dockManager
            // 
            this.dockManager.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerLeft});
            this.dockManager.Controller = this.barAndDockingController;
            this.dockManager.Form = this;
            this.dockManager.Images = this.mainMenuSvgImages;
            this.dockManager.MenuManager = this.barManager;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer2,
            this.panelContainer1});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // hideContainerLeft
            // 
            this.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.hideContainerLeft.Controls.Add(this.dockPanel6);
            this.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.hideContainerLeft.Location = new System.Drawing.Point(0, 58);
            this.hideContainerLeft.Name = "hideContainerLeft";
            this.hideContainerLeft.Size = new System.Drawing.Size(25, 582);
            // 
            // dockPanel6
            // 
            this.dockPanel6.Controls.Add(this.dockPanel6_Container);
            this.dockPanel6.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel6.FloatSize = new System.Drawing.Size(146, 428);
            this.dockPanel6.ID = new System.Guid("24977e30-0ea6-44aa-8fa4-9abaeb178b5e");
            this.dockPanel6.Location = new System.Drawing.Point(0, 0);
            this.dockPanel6.Name = "dockPanel6";
            this.dockPanel6.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel6.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel6.SavedIndex = 2;
            this.dockPanel6.Size = new System.Drawing.Size(200, 584);
            this.dockPanel6.Text = "Toolbox";
            this.dockPanel6.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel6_Container
            // 
            this.dockPanel6_Container.Controls.Add(this.ucToolbox1);
            this.dockPanel6_Container.Location = new System.Drawing.Point(3, 30);
            this.dockPanel6_Container.Name = "dockPanel6_Container";
            this.dockPanel6_Container.Size = new System.Drawing.Size(193, 551);
            this.dockPanel6_Container.TabIndex = 0;
            // 
            // ucToolbox1
            // 
            this.ucToolbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucToolbox1.Location = new System.Drawing.Point(0, 0);
            this.ucToolbox1.Margin = new System.Windows.Forms.Padding(2);
            this.ucToolbox1.Name = "ucToolbox1";
            this.ucToolbox1.Size = new System.Drawing.Size(193, 551);
            this.ucToolbox1.TabIndex = 0;
            // 
            // mainMenuSvgImages
            // 
            this.mainMenuSvgImages.Add("0_NewTeamProject_7437", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.0_NewTeamProject_7437"))));
            this.mainMenuSvgImages.Add("1_NewFile_6276", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.1_NewFile_6276"))));
            this.mainMenuSvgImages.Add("2_BlankApp_CPP_16x", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.2_BlankApp_CPP_16x"))));
            this.mainMenuSvgImages.Add("3_AddNewItem_6273", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.3_AddNewItem_6273"))));
            this.mainMenuSvgImages.Add("4_AddExistingItem_6269", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.4_AddExistingItem_6269"))));
            this.mainMenuSvgImages.Add("5_OpenFile", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.5_OpenFile"))));
            this.mainMenuSvgImages.Add("6_Close_6519", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.6_Close_6519"))));
            this.mainMenuSvgImages.Add("7_Saveall_6518", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.7_Saveall_6518"))));
            this.mainMenuSvgImages.Add("8_PrintSetup_11011", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.8_PrintSetup_11011"))));
            this.mainMenuSvgImages.Add("9_Print_11009", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.9_Print_11009"))));
            this.mainMenuSvgImages.Add("10_NewTeamProject_7437", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.10_NewTeamProject_7437"))));
            this.mainMenuSvgImages.Add("11_Undo", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.11_Undo"))));
            this.mainMenuSvgImages.Add("12_Redo_16x16", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.12_Redo_16x16"))));
            this.mainMenuSvgImages.Add("13_Cut", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.13_Cut"))));
            this.mainMenuSvgImages.Add("14_Copy", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.14_Copy"))));
            this.mainMenuSvgImages.Add("15_Paste", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.15_Paste"))));
            this.mainMenuSvgImages.Add("16_Find_5650", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.16_Find_5650"))));
            this.mainMenuSvgImages.Add("17_17", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.17_17"))));
            this.mainMenuSvgImages.Add("18_FindinFiles_6299", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.18_FindinFiles_6299"))));
            this.mainMenuSvgImages.Add("19_19", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.19_19"))));
            this.mainMenuSvgImages.Add("20_Open_6529", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.20_Open_6529"))));
            this.mainMenuSvgImages.Add("21_Save_6530", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.21_Save_6530"))));
            this.mainMenuSvgImages.Add("22_StartDebugging_", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.22_StartDebugging_"))));
            this.mainMenuSvgImages.Add("23_Solution", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.23_Solution"))));
            this.mainMenuSvgImages.Add("24_properties", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.24_properties"))));
            this.mainMenuSvgImages.Add("25_toolbox_16xLG", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.25_toolbox_16xLG"))));
            this.mainMenuSvgImages.Add("26_class_16xLG", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.26_class_16xLG"))));
            this.mainMenuSvgImages.Add("27_Task_16xLG", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.27_Task_16xLG"))));
            this.mainMenuSvgImages.Add("28_FindInFiles", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.28_FindInFiles"))));
            this.mainMenuSvgImages.Add("29_Output", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.29_Output"))));
            this.mainMenuSvgImages.Add("30_30", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.30_30"))));
            this.mainMenuSvgImages.Add("31_31", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.31_31"))));
            this.mainMenuSvgImages.Add("32_32", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.32_32"))));
            this.mainMenuSvgImages.Add("33_33", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.33_33"))));
            this.mainMenuSvgImages.Add("34_SaveFileDialogControl_703", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.34_SaveFileDialogControl_703"))));
            this.mainMenuSvgImages.Add("35_OpenFileDialog_692", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.35_OpenFileDialog_692"))));
            this.mainMenuSvgImages.Add("36_Information_blue_6227", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.36_Information_blue_6227"))));
            this.mainMenuSvgImages.Add("37_NewWebSite_6288", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainMenuSvgImages.37_NewWebSite_6288"))));
            // 
            // panelContainer2
            // 
            this.panelContainer2.ActiveChild = this.dockPanel5;
            this.panelContainer2.Controls.Add(this.dockPanel3);
            this.panelContainer2.Controls.Add(this.dockPanel4);
            this.panelContainer2.Controls.Add(this.dockPanel5);
            this.panelContainer2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.panelContainer2.FloatSize = new System.Drawing.Size(304, 139);
            this.panelContainer2.ID = new System.Guid("ec7b92c0-cfe1-43c3-9ff0-c24e6320f016");
            this.panelContainer2.Location = new System.Drawing.Point(25, 440);
            this.panelContainer2.Name = "panelContainer2";
            this.panelContainer2.OriginalSize = new System.Drawing.Size(200, 200);
            this.panelContainer2.Size = new System.Drawing.Size(1108, 200);
            this.panelContainer2.Tabbed = true;
            this.panelContainer2.Text = "panelContainer2";
            // 
            // dockPanel5
            // 
            this.dockPanel5.Controls.Add(this.dockPanel5_Container);
            this.dockPanel5.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel5.FloatSize = new System.Drawing.Size(304, 139);
            this.dockPanel5.ID = new System.Guid("dbdb0ba9-5443-476b-93ad-ec35678d61ef");
            this.dockPanel5.Location = new System.Drawing.Point(3, 31);
            this.dockPanel5.Name = "dockPanel5";
            this.dockPanel5.OriginalSize = new System.Drawing.Size(1102, 137);
            this.dockPanel5.Size = new System.Drawing.Size(1102, 137);
            this.dockPanel5.Text = "Output";
            // 
            // dockPanel5_Container
            // 
            this.dockPanel5_Container.Controls.Add(this.ucOutput1);
            this.dockPanel5_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel5_Container.Name = "dockPanel5_Container";
            this.dockPanel5_Container.Size = new System.Drawing.Size(1102, 137);
            this.dockPanel5_Container.TabIndex = 0;
            // 
            // ucOutput1
            // 
            this.ucOutput1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOutput1.Location = new System.Drawing.Point(0, 0);
            this.ucOutput1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucOutput1.Name = "ucOutput1";
            this.ucOutput1.Size = new System.Drawing.Size(1102, 137);
            this.ucOutput1.TabIndex = 0;
            // 
            // dockPanel3
            // 
            this.dockPanel3.Controls.Add(this.dockPanel3_Container);
            this.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel3.FloatSize = new System.Drawing.Size(304, 139);
            this.dockPanel3.ID = new System.Guid("7351d5e2-6da1-45c0-a5b6-13e4e7d7a56e");
            this.dockPanel3.Location = new System.Drawing.Point(3, 31);
            this.dockPanel3.Name = "dockPanel3";
            this.dockPanel3.OriginalSize = new System.Drawing.Size(1102, 137);
            this.dockPanel3.Size = new System.Drawing.Size(1102, 137);
            this.dockPanel3.TabText = "Task List";
            this.dockPanel3.Text = "Task List - 0 Build Errors";
            // 
            // dockPanel3_Container
            // 
            this.dockPanel3_Container.Controls.Add(this.ucTaskList1);
            this.dockPanel3_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel3_Container.Name = "dockPanel3_Container";
            this.dockPanel3_Container.Size = new System.Drawing.Size(1102, 137);
            this.dockPanel3_Container.TabIndex = 0;
            // 
            // ucTaskList1
            // 
            this.ucTaskList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTaskList1.Location = new System.Drawing.Point(0, 0);
            this.ucTaskList1.Margin = new System.Windows.Forms.Padding(2);
            this.ucTaskList1.Name = "ucTaskList1";
            this.ucTaskList1.Size = new System.Drawing.Size(1102, 137);
            this.ucTaskList1.TabIndex = 0;
            // 
            // dockPanel4
            // 
            this.dockPanel4.Controls.Add(this.dockPanel4_Container);
            this.dockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel4.FloatSize = new System.Drawing.Size(304, 139);
            this.dockPanel4.ID = new System.Guid("47b3ea95-3900-46d6-b24c-5f3a779b1ae7");
            this.dockPanel4.Location = new System.Drawing.Point(3, 31);
            this.dockPanel4.Name = "dockPanel4";
            this.dockPanel4.OriginalSize = new System.Drawing.Size(1102, 137);
            this.dockPanel4.Size = new System.Drawing.Size(1102, 137);
            this.dockPanel4.Text = "Find Results";
            // 
            // dockPanel4_Container
            // 
            this.dockPanel4_Container.Controls.Add(this.textBox1);
            this.dockPanel4_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel4_Container.Name = "dockPanel4_Container";
            this.dockPanel4_Container.Size = new System.Drawing.Size(1102, 137);
            this.dockPanel4_Container.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.EditValue = "";
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.textBox1.Properties.Appearance.Options.UseFont = true;
            this.textBox1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textBox1.Size = new System.Drawing.Size(1102, 137);
            this.textBox1.TabIndex = 0;
            // 
            // panelContainer1
            // 
            this.panelContainer1.ActiveChild = this.dockPanel1;
            this.panelContainer1.Controls.Add(this.dockPanel1);
            this.panelContainer1.Controls.Add(this.dockPanel2);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.panelContainer1.FloatSize = new System.Drawing.Size(253, 266);
            this.panelContainer1.ID = new System.Guid("6c74c2c4-9754-4cea-b108-63e9e7e6c9a0");
            this.panelContainer1.Location = new System.Drawing.Point(891, 58);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(242, 200);
            this.panelContainer1.Size = new System.Drawing.Size(242, 382);
            this.panelContainer1.Tabbed = true;
            this.panelContainer1.Text = "panelContainer1";
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel1.FloatSize = new System.Drawing.Size(253, 266);
            this.dockPanel1.ID = new System.Guid("70a62a0b-1c55-4e72-bef0-661a97c3e934");
            this.dockPanel1.Location = new System.Drawing.Point(4, 30);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(235, 322);
            this.dockPanel1.Size = new System.Drawing.Size(235, 320);
            this.dockPanel1.TabText = "Solution Explorer";
            this.dockPanel1.Text = "Solution Explorer";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.solutionExplorer);
            this.dockPanel1_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(235, 320);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // solutionExplorer
            // 
            this.solutionExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutionExplorer.Location = new System.Drawing.Point(0, 0);
            this.solutionExplorer.Name = "solutionExplorer";
            this.solutionExplorer.Size = new System.Drawing.Size(235, 320);
            this.solutionExplorer.TabIndex = 0;
            this.solutionExplorer.PropertiesItemClick += new System.EventHandler(this.solutionExplorer_PropertiesItemClick);
            this.solutionExplorer.TreeViewItemClick += new System.EventHandler(this.solutionExplorer_TreeViewItemClick);
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel2.ID = new System.Guid("96144626-be47-440b-ae5f-2c5507db5076");
            this.dockPanel2.Location = new System.Drawing.Point(4, 30);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(235, 322);
            this.dockPanel2.Size = new System.Drawing.Size(235, 320);
            this.dockPanel2.Text = "Properties";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.ucProperties1);
            this.dockPanel2_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(235, 320);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // ucProperties1
            // 
            this.ucProperties1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProperties1.Location = new System.Drawing.Point(0, 0);
            this.ucProperties1.Margin = new System.Windows.Forms.Padding(2);
            this.ucProperties1.Name = "ucProperties1";
            this.ucProperties1.Padding = new System.Windows.Forms.Padding(3);
            this.ucProperties1.Size = new System.Drawing.Size(235, 320);
            this.ucProperties1.TabIndex = 0;
            // 
            // siFile
            // 
            this.siFile.Caption = "&File";
            this.siFile.CategoryGuid = new System.Guid("a984a9d9-f96f-425a-8857-fe4de6df48c2");
            this.siFile.Id = 0;
            this.siFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.siNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.iOpen),
            new DevExpress.XtraBars.LinkPersistInfo(this.iClose),
            new DevExpress.XtraBars.LinkPersistInfo(this.iAddNewItem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.iAddExistingItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.siAddProject),
            new DevExpress.XtraBars.LinkPersistInfo(this.iOpenSolution, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.iCloseSolution),
            new DevExpress.XtraBars.LinkPersistInfo(this.iSaveAll, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, this.iPageSetup, "", true, false, true, 0),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, this.iPrint, "", false, false, true, 0),
            new DevExpress.XtraBars.LinkPersistInfo(this.iExit, true)});
            this.siFile.Name = "siFile";
            // 
            // siNew
            // 
            this.siNew.Caption = "&New";
            this.siNew.CategoryGuid = new System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52");
            this.siNew.Id = 2;
            this.siNew.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.iProject),
            new DevExpress.XtraBars.LinkPersistInfo(this.iBlankSolution)});
            this.siNew.Name = "siNew";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Web Site...";
            this.barButtonItem1.Id = 75;
            this.barButtonItem1.ImageOptions.ImageIndex = 37;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // iOpen
            // 
            this.iOpen.Caption = "&Open";
            this.iOpen.CategoryGuid = new System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52");
            this.iOpen.Id = 3;
            this.iOpen.Name = "iOpen";
            // 
            // iClose
            // 
            this.iClose.Caption = "&Close";
            this.iClose.CategoryGuid = new System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52");
            this.iClose.Id = 4;
            this.iClose.Name = "iClose";
            // 
            // iAddExistingItem
            // 
            this.iAddExistingItem.Caption = "Add Existin&g Item...";
            this.iAddExistingItem.CategoryGuid = new System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52");
            this.iAddExistingItem.Id = 9;
            this.iAddExistingItem.ImageOptions.ImageIndex = 4;
            this.iAddExistingItem.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.B));
            this.iAddExistingItem.Name = "iAddExistingItem";
            // 
            // siAddProject
            // 
            this.siAddProject.Caption = "A&dd Project";
            this.siAddProject.CategoryGuid = new System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52");
            this.siAddProject.Id = 10;
            this.siAddProject.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iNewProject),
            new DevExpress.XtraBars.LinkPersistInfo(this.iExistingProject)});
            this.siAddProject.Name = "siAddProject";
            // 
            // iNewProject
            // 
            this.iNewProject.Caption = "&New Project...";
            this.iNewProject.CategoryGuid = new System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52");
            this.iNewProject.Hint = "New Project";
            this.iNewProject.Id = 11;
            this.iNewProject.Name = "iNewProject";
            this.iNewProject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iNewItemClick);
            // 
            // iExistingProject
            // 
            this.iExistingProject.Caption = "&Existing Project...";
            this.iExistingProject.CategoryGuid = new System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52");
            this.iExistingProject.Id = 12;
            this.iExistingProject.Name = "iExistingProject";
            // 
            // iOpenSolution
            // 
            this.iOpenSolution.Caption = "Op&en Solution...";
            this.iOpenSolution.CategoryGuid = new System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52");
            this.iOpenSolution.Id = 14;
            this.iOpenSolution.ImageOptions.ImageIndex = 5;
            this.iOpenSolution.Name = "iOpenSolution";
            // 
            // iCloseSolution
            // 
            this.iCloseSolution.Caption = "Close Solu&tion";
            this.iCloseSolution.CategoryGuid = new System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52");
            this.iCloseSolution.Id = 15;
            this.iCloseSolution.ImageOptions.ImageIndex = 6;
            this.iCloseSolution.Name = "iCloseSolution";
            // 
            // iPageSetup
            // 
            this.iPageSetup.Caption = "Page Set&up...";
            this.iPageSetup.CategoryGuid = new System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52");
            this.iPageSetup.Id = 16;
            this.iPageSetup.ImageOptions.ImageIndex = 8;
            this.iPageSetup.Name = "iPageSetup";
            // 
            // iPrint
            // 
            this.iPrint.Caption = "&Print...";
            this.iPrint.CategoryGuid = new System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52");
            this.iPrint.Id = 17;
            this.iPrint.ImageOptions.ImageIndex = 9;
            this.iPrint.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.iPrint.Name = "iPrint";
            // 
            // iExit
            // 
            this.iExit.Caption = "E&xit";
            this.iExit.CategoryGuid = new System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52");
            this.iExit.Id = 18;
            this.iExit.Name = "iExit";
            this.iExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iExit_ItemClick);
            // 
            // siEdit
            // 
            this.siEdit.Caption = "&Edit";
            this.siEdit.CategoryGuid = new System.Guid("a984a9d9-f96f-425a-8857-fe4de6df48c2");
            this.siEdit.Id = 1;
            this.siEdit.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.siFind, true)});
            this.siEdit.Name = "siEdit";
            // 
            // siFind
            // 
            this.siFind.Caption = "&Find and Replace";
            this.siFind.CategoryGuid = new System.Guid("ac82dbe7-c530-4aa2-b6de-94a7777426fe");
            this.siFind.Id = 27;
            this.siFind.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iFind),
            new DevExpress.XtraBars.LinkPersistInfo(this.iReplace),
            new DevExpress.XtraBars.LinkPersistInfo(this.iFindinFiles)});
            this.siFind.Name = "siFind";
            // 
            // iFind
            // 
            this.iFind.Caption = "&Find";
            this.iFind.CategoryGuid = new System.Guid("ac82dbe7-c530-4aa2-b6de-94a7777426fe");
            this.iFind.Id = 28;
            this.iFind.ImageOptions.ImageIndex = 16;
            this.iFind.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.iFind.Name = "iFind";
            // 
            // iReplace
            // 
            this.iReplace.Caption = "R&eplace";
            this.iReplace.CategoryGuid = new System.Guid("ac82dbe7-c530-4aa2-b6de-94a7777426fe");
            this.iReplace.Id = 29;
            this.iReplace.ImageOptions.ImageIndex = 17;
            this.iReplace.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H));
            this.iReplace.Name = "iReplace";
            // 
            // siWindow
            // 
            this.siWindow.Caption = "&Window";
            this.siWindow.CategoryGuid = new System.Guid("a984a9d9-f96f-425a-8857-fe4de6df48c2");
            this.siWindow.Id = 45;
            this.siWindow.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barDockingMenuItem1)});
            this.siWindow.Name = "siWindow";
            // 
            // barDockingMenuItem1
            // 
            this.barDockingMenuItem1.Caption = "Window";
            this.barDockingMenuItem1.Id = 72;
            this.barDockingMenuItem1.Name = "barDockingMenuItem1";
            // 
            // siLayouts
            // 
            this.siLayouts.Caption = "&Layouts";
            this.siLayouts.CategoryGuid = new System.Guid("a984a9d9-f96f-425a-8857-fe4de6df48c2");
            this.siLayouts.Id = 49;
            this.siLayouts.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iLoadLayout),
            new DevExpress.XtraBars.LinkPersistInfo(this.iSaveLayout)});
            this.siLayouts.Name = "siLayouts";
            // 
            // bsiHelp
            // 
            this.bsiHelp.Caption = "&Help";
            this.bsiHelp.Id = 73;
            this.bsiHelp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iAbout)});
            this.bsiHelp.Name = "bsiHelp";
            // 
            // iAbout
            // 
            this.iAbout.Caption = "&About";
            this.iAbout.Id = 74;
            this.iAbout.ImageOptions.ImageIndex = 36;
            this.iAbout.Name = "iAbout";
            this.iAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iAbout_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemSearchControl1;
            this.barEditItem1.EditWidth = 220;
            this.barEditItem1.Id = 76;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemSearchControl1
            // 
            this.repositoryItemSearchControl1.AutoHeight = false;
            this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            this.repositoryItemSearchControl1.NullValuePrompt = "Search Visual Studio";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "barHeaderItem1";
            this.barHeaderItem1.Id = 77;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.AllowFocus = DevExpress.Utils.DefaultBoolean.False;
            this.barStaticItem1.Caption = "Visual Studio Inspired UI Demo";
            this.barStaticItem1.Id = 78;
            this.barStaticItem1.LeftIndent = 21;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // documentManager
            // 
            this.documentManager.BarAndDockingController = this.barAndDockingController;
            this.documentManager.ContainerControl = this;
            this.documentManager.MenuManager = this.barManager;
            this.documentManager.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.documentManager.ShowToolTips = DevExpress.Utils.DefaultBoolean.True;
            this.documentManager.View = this.tabbedView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView});
            // 
            // tabbedView
            // 
            this.tabbedView.DocumentProperties.AllowPin = true;
            this.tabbedView.DocumentSelectorProperties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tabbedView.DocumentSelectorProperties.DocumentFooterFormat = "{0}\\{1}";
            this.tabbedView.DocumentSelectorProperties.DocumentHeaderFormat = "{0}<br>Source file";
            this.tabbedView.DocumentSelectorProperties.PanelFooterFormat = "";
            this.tabbedView.FloatingDocumentContainer = DevExpress.XtraBars.Docking2010.Views.FloatingDocumentContainer.DocumentsHost;
            // 
            // fileTypeSvgImages
            // 
            this.fileTypeSvgImages.Add("CSharpFile_SolutionExplorerNode", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("fileTypeSvgImages.CSharpFile_SolutionExplorerNode"))));
            // 
            // toolbarFormControl1
            // 
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.barManager;
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(1133, 30);
            this.toolbarFormControl1.TabIndex = 13;
            this.toolbarFormControl1.TabStop = false;
            this.toolbarFormControl1.TitleItemLinks.Add(this.siFile);
            this.toolbarFormControl1.TitleItemLinks.Add(this.siEdit);
            this.toolbarFormControl1.TitleItemLinks.Add(this.siLayouts);
            this.toolbarFormControl1.TitleItemLinks.Add(this.siWindow);
            this.toolbarFormControl1.TitleItemLinks.Add(this.bsiHelp);
            this.toolbarFormControl1.TitleItemLinks.Add(this.barEditItem1);
            this.toolbarFormControl1.TitleItemLinks.Add(this.barStaticItem1);
            this.toolbarFormControl1.ToolbarForm = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1133, 662);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.panelContainer1);
            this.Controls.Add(this.panelContainer2);
            this.Controls.Add(this.hideContainerLeft);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.toolbarFormControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmMain.IconOptions.Icon")));
            this.Name = "frmMain";
            this.ShowText = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visual Studio Inspired UI";
            this.ToolbarFormControl = this.toolbarFormControl1;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classViewSvgImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.hideContainerLeft.ResumeLayout(false);
            this.dockPanel6.ResumeLayout(false);
            this.dockPanel6_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuSvgImages)).EndInit();
            this.panelContainer2.ResumeLayout(false);
            this.dockPanel5.ResumeLayout(false);
            this.dockPanel5_Container.ResumeLayout(false);
            this.dockPanel3.ResumeLayout(false);
            this.dockPanel3_Container.ResumeLayout(false);
            this.dockPanel4.ResumeLayout(false);
            this.dockPanel4_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textBox1.Properties)).EndInit();
            this.panelContainer1.ResumeLayout(false);
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileTypeSvgImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarSubItem siFile;
        private DevExpress.XtraBars.BarSubItem siEdit;
        private DevExpress.XtraBars.BarSubItem siNew;
        private DevExpress.XtraBars.BarButtonItem iOpen;
        private DevExpress.XtraBars.BarButtonItem iClose;
        private DevExpress.XtraBars.BarButtonItem iProject;
        private DevExpress.XtraBars.BarButtonItem iFile;
        private DevExpress.XtraBars.BarButtonItem iBlankSolution;
        private DevExpress.XtraBars.BarButtonItem iAddNewItem;
        private DevExpress.XtraBars.BarButtonItem iAddExistingItem;
        private DevExpress.XtraBars.BarSubItem siAddProject;
        private DevExpress.XtraBars.BarButtonItem iNewProject;
        private DevExpress.XtraBars.BarButtonItem iExistingProject;
        private DevExpress.XtraBars.BarButtonItem iSaveAll;
        private DevExpress.XtraBars.BarButtonItem iOpenSolution;
        private DevExpress.XtraBars.BarButtonItem iCloseSolution;
        private DevExpress.XtraBars.BarButtonItem iPageSetup;
        private DevExpress.XtraBars.BarButtonItem iPrint;
        private DevExpress.XtraBars.BarButtonItem iExit;
        private DevExpress.XtraBars.BarSubItem siFind;
        private DevExpress.XtraBars.BarButtonItem iFind;
        private DevExpress.XtraBars.BarButtonItem iReplace;
        private DevExpress.XtraBars.BarButtonItem iFindinFiles;
        private DevExpress.XtraBars.BarButtonItem iNew;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem iOpenFile;
        private DevExpress.XtraBars.BarButtonItem iSave;
        private DevExpress.XtraBars.BarButtonItem iStart;
        private DevExpress.XtraBars.BarEditItem eConfiguration;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryImageComboBox1;
        private DevExpress.XtraBars.BarEditItem eFind;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarButtonItem iSolutionExplorer;
        private DevExpress.XtraBars.BarButtonItem iProperties;
        private DevExpress.XtraBars.BarButtonItem iToolbox;
        private DevExpress.XtraBars.BarButtonItem iClassView;
        private DevExpress.XtraEditors.MemoEdit textBox1;
        private DevExpress.XtraBars.Demos.DockingDemo.ucSolutionExplorer solutionExplorer;
        private DevExpress.XtraBars.BarButtonItem iTaskList;
        private DevExpress.XtraBars.BarButtonItem iFindResults;
        private DevExpress.XtraBars.BarButtonItem iOutput;
        private DevExpress.XtraBars.BarSubItem siWindow;
        private DevExpress.XtraBars.BarStaticItem iStatus1;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;
        private DevExpress.XtraTreeList.TreeList treeView1;
        private DevExpress.XtraBars.BarButtonItem iLoadLayout;
        private DevExpress.XtraBars.BarButtonItem iSaveLayout;
        private DevExpress.XtraBars.BarSubItem siLayouts;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel3;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel4;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel4_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel5;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel5_Container;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer2;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel6;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel6_Container;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerLeft;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private BarDockingMenuItem barDockingMenuItem1;
        private BarSubItem bsiHelp;
        private BarButtonItem iAbout;
        private Bar bar6;
        private DevExpress.XtraBars.Demos.DockingDemo.ucProperties ucProperties1;
        private ucTaskList ucTaskList1;
        private ucOutput ucOutput1;
        private ucToolbox ucToolbox1;
        private BarButtonItem barButtonItem1;
        private DevExpress.Utils.SvgImageCollection classViewSvgImages;
        private DevExpress.Utils.SvgImageCollection fileTypeSvgImages;
        private DevExpress.Utils.SvgImageCollection mainMenuSvgImages;
        private ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private BarEditItem barEditItem1;
        private XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private BarStaticItem barStaticItem1;
        private BarHeaderItem barHeaderItem1;
    }
}
