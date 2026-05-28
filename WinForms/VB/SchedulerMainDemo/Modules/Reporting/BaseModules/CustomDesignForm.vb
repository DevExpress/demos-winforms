Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UserDesigner
Imports DevExpress.XtraScheduler.Reporting.Design

Namespace DevExpress.XtraScheduler.Demos.Reporting

    Public Class CustomDesignForm
        Inherits XtraForm

        Private xrDesignBarManager1 As XRDesignBarManager

        Private bar2 As Bar

        Private designBar1 As DesignBar

        Private barSubItem1 As BarSubItem

        Private commandBarItem31 As CommandBarItem

        Private commandBarItem39 As CommandBarItem

        Private commandBarItem32 As CommandBarItem

        Private commandBarItem33 As CommandBarItem

        Private commandBarItem40 As CommandBarItem

        Private commandBarItem41 As CommandBarItem

        Private barSubItem2 As BarSubItem

        Private commandBarItem37 As CommandBarItem

        Private commandBarItem38 As CommandBarItem

        Private commandBarItem34 As CommandBarItem

        Private commandBarItem35 As CommandBarItem

        Private commandBarItem36 As CommandBarItem

        Private commandBarItem42 As CommandBarItem

        Private commandBarItem43 As CommandBarItem

        Private barSubItem3 As BarSubItem

        Private barReportTabButtonsListItem1 As BarReportTabButtonsListItem

        Private barSubItem4 As BarSubItem

        Private xrBarToolbarsListItem1 As XRBarToolbarsListItem

        Private barSubItem5 As BarSubItem

        Private barDockPanelsListItem1 As BarDockPanelsListItem

        Private barSubItem6 As BarSubItem

        Private commandColorBarItem1 As CommandColorBarItem

        Private commandColorBarItem2 As CommandColorBarItem

        Private barSubItem7 As BarSubItem

        Private commandBarItem1 As CommandBarItem

        Private commandBarItem2 As CommandBarItem

        Private commandBarItem3 As CommandBarItem

        Private barSubItem8 As BarSubItem

        Private commandBarItem4 As CommandBarItem

        Private commandBarItem5 As CommandBarItem

        Private commandBarItem6 As CommandBarItem

        Private commandBarItem7 As CommandBarItem

        Private barSubItem9 As BarSubItem

        Private commandBarItem9 As CommandBarItem

        Private commandBarItem10 As CommandBarItem

        Private commandBarItem11 As CommandBarItem

        Private commandBarItem12 As CommandBarItem

        Private commandBarItem13 As CommandBarItem

        Private commandBarItem14 As CommandBarItem

        Private commandBarItem8 As CommandBarItem

        Private barSubItem10 As BarSubItem

        Private commandBarItem15 As CommandBarItem

        Private commandBarItem16 As CommandBarItem

        Private commandBarItem17 As CommandBarItem

        Private commandBarItem18 As CommandBarItem

        Private barSubItem11 As BarSubItem

        Private commandBarItem19 As CommandBarItem

        Private commandBarItem20 As CommandBarItem

        Private commandBarItem21 As CommandBarItem

        Private commandBarItem22 As CommandBarItem

        Private barSubItem12 As BarSubItem

        Private commandBarItem23 As CommandBarItem

        Private commandBarItem24 As CommandBarItem

        Private commandBarItem25 As CommandBarItem

        Private commandBarItem26 As CommandBarItem

        Private barSubItem13 As BarSubItem

        Private commandBarItem27 As CommandBarItem

        Private commandBarItem28 As CommandBarItem

        Private barSubItem14 As BarSubItem

        Private commandBarItem29 As CommandBarItem

        Private commandBarItem30 As CommandBarItem

        Private barSubItem15 As BarSubItem

        Private commandBarCheckItem1 As CommandBarCheckItem

        Private commandBarItem44 As CommandBarItem

        Private commandBarItem45 As CommandBarItem

        Private commandBarItem46 As CommandBarItem

        Private barMdiChildrenListItem1 As BarMdiChildrenListItem

        Private bsiLookAndFeel As BarSubItem

        Private designBar2 As DesignBar

        Private designBar3 As DesignBar

        Private barEditItem1 As BarEditItem

        Private recentlyUsedItemsComboBox1 As XtraReports.UserDesigner.RecentlyUsedItemsComboBox

        Private barEditItem2 As BarEditItem

        Private designRepositoryItemComboBox1 As DesignRepositoryItemComboBox

        Private designBar4 As DesignBar

        Private designBar5 As DesignBar

        Private barStaticItem1 As BarStaticItem

        Private bar1 As Bar

        Private commandBarItem47 As CommandBarItem

        Private xrZoomBarEditItem1 As XRZoomBarEditItem

        Private designRepositoryItemComboBox2 As DesignRepositoryItemComboBox

        Private commandBarItem48 As CommandBarItem

        Private barDockControlTop As BarDockControl

        Private barDockControlBottom As BarDockControl

        Private barDockControlLeft As BarDockControl

        Private barDockControlRight As BarDockControl

        Private xrDesignDockManager1 As XRDesignDockManager

        Private errorListDockPanel1 As ErrorListDockPanel

        Private errorListDockPanel1_Container As DesignControlContainer

        Private panelContainer1 As Docking.DockPanel

        Private reportExplorerDockPanel1 As ReportExplorerDockPanel

        Private reportExplorerDockPanel1_Container As DesignControlContainer

        Private propertyGridDockPanel1 As PropertyGridDockPanel

        Private propertyGridDockPanel1_Container As DesignControlContainer

        Private xrDesignMdiController1 As XRDesignMdiController

        Private xtraTabbedMdiManager1 As XRTabbedMdiManager

        Private commandBarItem49 As CommandBarItem

        Private bar3 As Bar

        Private components As IContainer

        Public Sub New()
            InitializeComponent()
            Dim item As BarItem = New BarLookAndFeelListItem(DevExpress.LookAndFeel.UserLookAndFeel.Default)
            xrDesignBarManager1.Items.Add(item)
            bsiLookAndFeel.AddItem(item)
            xrDesignMdiController1.AddService(GetType(ReportTypeService), New SchedulerReportTypeService())
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        Private Sub InitializeComponent()
            components = New System.ComponentModel.Container()
            Dim barInfo1 As BarInfo = New BarInfo()
            Dim barInfo2 As BarInfo = New BarInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomDesignForm))
            Dim xrDesignPanelListener1 As XRDesignPanelListener = New XRDesignPanelListener()
            Dim xrDesignPanelListener2 As XRDesignPanelListener = New XRDesignPanelListener()
            Dim xrDesignPanelListener3 As XRDesignPanelListener = New XRDesignPanelListener()
            Dim xrDesignPanelListener4 As XRDesignPanelListener = New XRDesignPanelListener()
            Dim xrDesignPanelListener5 As XRDesignPanelListener = New XRDesignPanelListener()
            bar2 = New Bar()
            bar3 = New Bar()
            xrDesignBarManager1 = New XRDesignBarManager()
            designBar1 = New DesignBar()
            barSubItem1 = New BarSubItem()
            commandBarItem31 = New CommandBarItem()
            commandBarItem39 = New CommandBarItem()
            commandBarItem32 = New CommandBarItem()
            commandBarItem33 = New CommandBarItem()
            commandBarItem40 = New CommandBarItem()
            commandBarItem49 = New CommandBarItem()
            commandBarItem41 = New CommandBarItem()
            barSubItem2 = New BarSubItem()
            commandBarItem37 = New CommandBarItem()
            commandBarItem38 = New CommandBarItem()
            commandBarItem34 = New CommandBarItem()
            commandBarItem35 = New CommandBarItem()
            commandBarItem36 = New CommandBarItem()
            commandBarItem42 = New CommandBarItem()
            commandBarItem43 = New CommandBarItem()
            barSubItem3 = New BarSubItem()
            barReportTabButtonsListItem1 = New BarReportTabButtonsListItem()
            barSubItem4 = New BarSubItem()
            xrBarToolbarsListItem1 = New XRBarToolbarsListItem()
            barSubItem5 = New BarSubItem()
            barDockPanelsListItem1 = New BarDockPanelsListItem()
            barSubItem6 = New BarSubItem()
            commandColorBarItem1 = New CommandColorBarItem()
            commandColorBarItem2 = New CommandColorBarItem()
            barSubItem7 = New BarSubItem()
            commandBarItem1 = New CommandBarItem()
            commandBarItem2 = New CommandBarItem()
            commandBarItem3 = New CommandBarItem()
            barSubItem8 = New BarSubItem()
            commandBarItem4 = New CommandBarItem()
            commandBarItem5 = New CommandBarItem()
            commandBarItem6 = New CommandBarItem()
            commandBarItem7 = New CommandBarItem()
            barSubItem9 = New BarSubItem()
            commandBarItem9 = New CommandBarItem()
            commandBarItem10 = New CommandBarItem()
            commandBarItem11 = New CommandBarItem()
            commandBarItem12 = New CommandBarItem()
            commandBarItem13 = New CommandBarItem()
            commandBarItem14 = New CommandBarItem()
            commandBarItem8 = New CommandBarItem()
            barSubItem10 = New BarSubItem()
            commandBarItem15 = New CommandBarItem()
            commandBarItem16 = New CommandBarItem()
            commandBarItem17 = New CommandBarItem()
            commandBarItem18 = New CommandBarItem()
            barSubItem11 = New BarSubItem()
            commandBarItem19 = New CommandBarItem()
            commandBarItem20 = New CommandBarItem()
            commandBarItem21 = New CommandBarItem()
            commandBarItem22 = New CommandBarItem()
            barSubItem12 = New BarSubItem()
            commandBarItem23 = New CommandBarItem()
            commandBarItem24 = New CommandBarItem()
            commandBarItem25 = New CommandBarItem()
            commandBarItem26 = New CommandBarItem()
            barSubItem13 = New BarSubItem()
            commandBarItem27 = New CommandBarItem()
            commandBarItem28 = New CommandBarItem()
            barSubItem14 = New BarSubItem()
            commandBarItem29 = New CommandBarItem()
            commandBarItem30 = New CommandBarItem()
            barSubItem15 = New BarSubItem()
            commandBarCheckItem1 = New CommandBarCheckItem()
            commandBarItem44 = New CommandBarItem()
            commandBarItem45 = New CommandBarItem()
            commandBarItem46 = New CommandBarItem()
            barMdiChildrenListItem1 = New BarMdiChildrenListItem()
            bsiLookAndFeel = New BarSubItem()
            designBar2 = New DesignBar()
            designBar3 = New DesignBar()
            barEditItem1 = New BarEditItem()
            recentlyUsedItemsComboBox1 = New XtraReports.UserDesigner.RecentlyUsedItemsComboBox()
            barEditItem2 = New BarEditItem()
            designRepositoryItemComboBox1 = New DesignRepositoryItemComboBox()
            designBar4 = New DesignBar()
            designBar5 = New DesignBar()
            barStaticItem1 = New BarStaticItem()
            bar1 = New Bar()
            commandBarItem47 = New CommandBarItem()
            xrZoomBarEditItem1 = New XRZoomBarEditItem()
            designRepositoryItemComboBox2 = New DesignRepositoryItemComboBox()
            commandBarItem48 = New CommandBarItem()
            barDockControlTop = New BarDockControl()
            barDockControlBottom = New BarDockControl()
            barDockControlLeft = New BarDockControl()
            barDockControlRight = New BarDockControl()
            xrDesignDockManager1 = New XRDesignDockManager()
            panelContainer1 = New Docking.DockPanel()
            reportExplorerDockPanel1 = New ReportExplorerDockPanel()
            reportExplorerDockPanel1_Container = New DesignControlContainer()
            propertyGridDockPanel1 = New PropertyGridDockPanel()
            propertyGridDockPanel1_Container = New DesignControlContainer()
            errorListDockPanel1 = New ErrorListDockPanel()
            errorListDockPanel1_Container = New DesignControlContainer()
            xrDesignMdiController1 = New XRDesignMdiController()
            xtraTabbedMdiManager1 = New XRTabbedMdiManager(components)
            CType(xrDesignBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(recentlyUsedItemsComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(designRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(designRepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xrDesignDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            panelContainer1.SuspendLayout()
            reportExplorerDockPanel1.SuspendLayout()
            propertyGridDockPanel1.SuspendLayout()
            errorListDockPanel1.SuspendLayout()
            CType(xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' bar2
            ' 
            bar2.BarName = "Toolbox"
            bar2.DockCol = 0
            bar2.DockRow = 0
            bar2.DockStyle = BarDockStyle.Left
            bar2.OptionsBar.AllowQuickCustomization = False
            bar2.Text = "Standard Controls"
            ' 
            ' bar3
            ' 
            bar3.BarName = "Scheduler Controls"
            bar3.DockCol = 0
            bar3.DockRow = 1
            bar3.DockStyle = BarDockStyle.Left
            bar3.OptionsBar.AllowQuickCustomization = False
            bar3.Text = Localization.SchedulerLocalizer.GetString(Localization.SchedulerStringId.UD_SchedulerReportsToolboxCategoryName)
            ' 
            ' xrDesignBarManager1
            ' 
            barInfo1.Bar = bar2
            barInfo1.ToolboxType = ToolboxType.Standard
            barInfo2.Bar = bar3
            barInfo2.ToolboxType = ToolboxType.Custom
            xrDesignBarManager1.BarInfos.AddRange(New BarInfo() {barInfo1, barInfo2})
            xrDesignBarManager1.Bars.AddRange(New Bar() {designBar1, designBar2, designBar3, designBar4, designBar5, bar1, bar2, bar3})
            xrDesignBarManager1.DockControls.Add(barDockControlTop)
            xrDesignBarManager1.DockControls.Add(barDockControlBottom)
            xrDesignBarManager1.DockControls.Add(barDockControlLeft)
            xrDesignBarManager1.DockControls.Add(barDockControlRight)
            xrDesignBarManager1.DockManager = xrDesignDockManager1
            xrDesignBarManager1.FontNameBox = recentlyUsedItemsComboBox1
            xrDesignBarManager1.FontNameEdit = barEditItem1
            xrDesignBarManager1.FontSizeBox = designRepositoryItemComboBox1
            xrDesignBarManager1.FontSizeEdit = barEditItem2
            xrDesignBarManager1.Form = Me
            xrDesignBarManager1.FormattingToolbar = designBar3
            xrDesignBarManager1.HintStaticItem = barStaticItem1
            xrDesignBarManager1.ImageStream = CType(resources.GetObject("xrDesignBarManager1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            xrDesignBarManager1.Items.AddRange(New BarItem() {barEditItem1, barEditItem2, commandBarItem1, commandBarItem2, commandBarItem3, commandColorBarItem1, commandColorBarItem2, commandBarItem4, commandBarItem5, commandBarItem6, commandBarItem7, commandBarItem8, commandBarItem9, commandBarItem10, commandBarItem11, commandBarItem12, commandBarItem13, commandBarItem14, commandBarItem15, commandBarItem16, commandBarItem17, commandBarItem18, commandBarItem19, commandBarItem20, commandBarItem21, commandBarItem22, commandBarItem23, commandBarItem24, commandBarItem25, commandBarItem26, commandBarItem27, commandBarItem28, commandBarItem29, commandBarItem30, commandBarItem31, commandBarItem32, commandBarItem33, commandBarItem34, commandBarItem35, commandBarItem36, commandBarItem37, commandBarItem38, barStaticItem1, barSubItem1, barSubItem2, barSubItem3, barReportTabButtonsListItem1, barSubItem4, xrBarToolbarsListItem1, barSubItem5, barDockPanelsListItem1, barSubItem6, barSubItem7, barSubItem8, barSubItem9, barSubItem10, barSubItem11, barSubItem12, barSubItem13, barSubItem14, commandBarItem39, commandBarItem40, commandBarItem41, commandBarItem42, commandBarItem43, barSubItem15, commandBarCheckItem1, commandBarItem44, commandBarItem45, commandBarItem46, barMdiChildrenListItem1, commandBarItem47, xrZoomBarEditItem1, commandBarItem48, bsiLookAndFeel, commandBarItem49})
            xrDesignBarManager1.LayoutToolbar = designBar4
            xrDesignBarManager1.MainMenu = designBar1
            xrDesignBarManager1.MaxItemId = 79
            xrDesignBarManager1.RepositoryItems.AddRange(New Repository.RepositoryItem() {recentlyUsedItemsComboBox1, designRepositoryItemComboBox1, designRepositoryItemComboBox2})
            xrDesignBarManager1.StatusBar = designBar5
            xrDesignBarManager1.Toolbar = designBar2
            xrDesignBarManager1.Updates.AddRange(New String() {"Toolbox"})
            xrDesignBarManager1.ZoomItem = xrZoomBarEditItem1
            ' 
            ' designBar1
            ' 
            designBar1.BarName = "Main Menu"
            designBar1.DockCol = 0
            designBar1.DockRow = 0
            designBar1.DockStyle = BarDockStyle.Top
            designBar1.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(barSubItem1), New LinkPersistInfo(barSubItem2), New LinkPersistInfo(barSubItem3), New LinkPersistInfo(barSubItem6), New LinkPersistInfo(barSubItem15), New LinkPersistInfo(bsiLookAndFeel)})
            designBar1.OptionsBar.MultiLine = True
            designBar1.OptionsBar.UseWholeRow = True
            designBar1.Text = "Main Menu"
            ' 
            ' barSubItem1
            ' 
            barSubItem1.Caption = "&File"
            barSubItem1.Id = 43
            barSubItem1.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(commandBarItem31), New LinkPersistInfo(commandBarItem39), New LinkPersistInfo(commandBarItem32), New LinkPersistInfo(commandBarItem33, True), New LinkPersistInfo(commandBarItem40), New LinkPersistInfo(commandBarItem49), New LinkPersistInfo(commandBarItem41, True)})
            barSubItem1.Name = "barSubItem1"
            ' 
            ' commandBarItem31
            ' 
            commandBarItem31.Caption = "&New"
            commandBarItem31.Command = ReportCommand.NewReport
            commandBarItem31.Enabled = False
            commandBarItem31.Hint = "Create a new blank report"
            commandBarItem31.Id = 34
            commandBarItem31.ImageIndex = 9
            commandBarItem31.ItemShortcut = New BarShortcut(Keys.Control Or Keys.N)
            commandBarItem31.Name = "commandBarItem31"
            ' 
            ' commandBarItem39
            ' 
            commandBarItem39.Caption = "New with &Wizard..."
            commandBarItem39.Command = ReportCommand.NewReportWizard
            commandBarItem39.Enabled = False
            commandBarItem39.Hint = "Create a new report using the Wizard"
            commandBarItem39.Id = 60
            commandBarItem39.ItemShortcut = New BarShortcut(Keys.Control Or Keys.W)
            commandBarItem39.Name = "commandBarItem39"
            ' 
            ' commandBarItem32
            ' 
            commandBarItem32.Caption = "&Open..."
            commandBarItem32.Command = ReportCommand.OpenFile
            commandBarItem32.Enabled = False
            commandBarItem32.Hint = "Open a report"
            commandBarItem32.Id = 35
            commandBarItem32.ImageIndex = 10
            commandBarItem32.ItemShortcut = New BarShortcut(Keys.Control Or Keys.O)
            commandBarItem32.Name = "commandBarItem32"
            ' 
            ' commandBarItem33
            ' 
            commandBarItem33.Caption = "&Save"
            commandBarItem33.Command = ReportCommand.SaveFile
            commandBarItem33.Enabled = False
            commandBarItem33.Hint = "Save a report"
            commandBarItem33.Id = 36
            commandBarItem33.ImageIndex = 11
            commandBarItem33.ItemShortcut = New BarShortcut(Keys.Control Or Keys.S)
            commandBarItem33.Name = "commandBarItem33"
            ' 
            ' commandBarItem40
            ' 
            commandBarItem40.Caption = "Save &As..."
            commandBarItem40.Command = ReportCommand.SaveFileAs
            commandBarItem40.Enabled = False
            commandBarItem40.Hint = "Save a report with a new name"
            commandBarItem40.Id = 61
            commandBarItem40.Name = "commandBarItem40"
            ' 
            ' commandBarItem49
            ' 
            commandBarItem49.Caption = "&Close"
            commandBarItem49.Command = ReportCommand.Close
            commandBarItem49.Enabled = False
            commandBarItem49.Hint = "Close the report"
            commandBarItem49.Id = 78
            commandBarItem49.Name = "commandBarItem49"
            ' 
            ' commandBarItem41
            ' 
            commandBarItem41.Caption = "E&xit"
            commandBarItem41.Command = ReportCommand.Exit
            commandBarItem41.Enabled = False
            commandBarItem41.Hint = "Close the designer"
            commandBarItem41.Id = 62
            commandBarItem41.Name = "commandBarItem41"
            ' 
            ' barSubItem2
            ' 
            barSubItem2.Caption = "&Edit"
            barSubItem2.Id = 44
            barSubItem2.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(commandBarItem37, True), New LinkPersistInfo(commandBarItem38), New LinkPersistInfo(commandBarItem34, True), New LinkPersistInfo(commandBarItem35), New LinkPersistInfo(commandBarItem36), New LinkPersistInfo(commandBarItem42), New LinkPersistInfo(commandBarItem43, True)})
            barSubItem2.Name = "barSubItem2"
            ' 
            ' commandBarItem37
            ' 
            commandBarItem37.Caption = "&Undo"
            commandBarItem37.Command = ReportCommand.Undo
            commandBarItem37.Enabled = False
            commandBarItem37.Hint = "Undo the last operation"
            commandBarItem37.Id = 40
            commandBarItem37.ImageIndex = 15
            commandBarItem37.ItemShortcut = New BarShortcut(Keys.Control Or Keys.Z)
            commandBarItem37.Name = "commandBarItem37"
            ' 
            ' commandBarItem38
            ' 
            commandBarItem38.Caption = "&Redo"
            commandBarItem38.Command = ReportCommand.Redo
            commandBarItem38.Enabled = False
            commandBarItem38.Hint = "Redo the last operation"
            commandBarItem38.Id = 41
            commandBarItem38.ImageIndex = 16
            commandBarItem38.ItemShortcut = New BarShortcut(Keys.Control Or Keys.Y)
            commandBarItem38.Name = "commandBarItem38"
            ' 
            ' commandBarItem34
            ' 
            commandBarItem34.Caption = "Cu&t"
            commandBarItem34.Command = ReportCommand.Cut
            commandBarItem34.Enabled = False
            commandBarItem34.Hint = "Delete the control and copy it to the clipboard"
            commandBarItem34.Id = 37
            commandBarItem34.ImageIndex = 12
            commandBarItem34.ItemShortcut = New BarShortcut(Keys.Control Or Keys.X)
            commandBarItem34.Name = "commandBarItem34"
            ' 
            ' commandBarItem35
            ' 
            commandBarItem35.Caption = "&Copy"
            commandBarItem35.Command = ReportCommand.Copy
            commandBarItem35.Enabled = False
            commandBarItem35.Hint = "Copy the control to the clipboard"
            commandBarItem35.Id = 38
            commandBarItem35.ImageIndex = 13
            commandBarItem35.ItemShortcut = New BarShortcut(Keys.Control Or Keys.C)
            commandBarItem35.Name = "commandBarItem35"
            ' 
            ' commandBarItem36
            ' 
            commandBarItem36.Caption = "&Paste"
            commandBarItem36.Command = ReportCommand.Paste
            commandBarItem36.Enabled = False
            commandBarItem36.Hint = "Add the control from the clipboard"
            commandBarItem36.Id = 39
            commandBarItem36.ImageIndex = 14
            commandBarItem36.ItemShortcut = New BarShortcut(Keys.Control Or Keys.V)
            commandBarItem36.Name = "commandBarItem36"
            ' 
            ' commandBarItem42
            ' 
            commandBarItem42.Caption = "&Delete"
            commandBarItem42.Command = ReportCommand.Delete
            commandBarItem42.Enabled = False
            commandBarItem42.Hint = "Delete the control"
            commandBarItem42.Id = 63
            commandBarItem42.Name = "commandBarItem42"
            ' 
            ' commandBarItem43
            ' 
            commandBarItem43.Caption = "Select &All"
            commandBarItem43.Command = ReportCommand.SelectAll
            commandBarItem43.Enabled = False
            commandBarItem43.Hint = "Select all the controls in the document"
            commandBarItem43.Id = 64
            commandBarItem43.ItemShortcut = New BarShortcut(Keys.Control Or Keys.A)
            commandBarItem43.Name = "commandBarItem43"
            ' 
            ' barSubItem3
            ' 
            barSubItem3.Caption = "&View"
            barSubItem3.Id = 45
            barSubItem3.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(barReportTabButtonsListItem1), New LinkPersistInfo(barSubItem4, True), New LinkPersistInfo(barSubItem5, True)})
            barSubItem3.Name = "barSubItem3"
            ' 
            ' barReportTabButtonsListItem1
            ' 
            barReportTabButtonsListItem1.Caption = "Tab Buttons"
            barReportTabButtonsListItem1.Id = 46
            barReportTabButtonsListItem1.Name = "barReportTabButtonsListItem1"
            ' 
            ' barSubItem4
            ' 
            barSubItem4.Caption = "&Toolbars"
            barSubItem4.Id = 47
            barSubItem4.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(xrBarToolbarsListItem1)})
            barSubItem4.Name = "barSubItem4"
            ' 
            ' xrBarToolbarsListItem1
            ' 
            xrBarToolbarsListItem1.Caption = "&Toolbars"
            xrBarToolbarsListItem1.Id = 48
            xrBarToolbarsListItem1.Name = "xrBarToolbarsListItem1"
            ' 
            ' barSubItem5
            ' 
            barSubItem5.Caption = "&Windows"
            barSubItem5.Id = 49
            barSubItem5.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(barDockPanelsListItem1)})
            barSubItem5.Name = "barSubItem5"
            ' 
            ' barDockPanelsListItem1
            ' 
            barDockPanelsListItem1.Caption = "&Windows"
            barDockPanelsListItem1.Id = 50
            barDockPanelsListItem1.Name = "barDockPanelsListItem1"
            barDockPanelsListItem1.ShowCustomizationItem = False
            barDockPanelsListItem1.ShowDockPanels = True
            barDockPanelsListItem1.ShowToolbars = False
            ' 
            ' barSubItem6
            ' 
            barSubItem6.Caption = "Fo&rmat"
            barSubItem6.Id = 51
            barSubItem6.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(commandColorBarItem1), New LinkPersistInfo(commandColorBarItem2), New LinkPersistInfo(barSubItem7, True), New LinkPersistInfo(barSubItem8), New LinkPersistInfo(barSubItem9, True), New LinkPersistInfo(barSubItem10), New LinkPersistInfo(barSubItem11, True), New LinkPersistInfo(barSubItem12), New LinkPersistInfo(barSubItem13, True), New LinkPersistInfo(barSubItem14, True)})
            barSubItem6.Name = "barSubItem6"
            ' 
            ' commandColorBarItem1
            ' 
            commandColorBarItem1.ButtonStyle = BarButtonStyle.DropDown
            commandColorBarItem1.Caption = "For&eground Color"
            commandColorBarItem1.Command = ReportCommand.ForeColor
            commandColorBarItem1.Enabled = False
            commandColorBarItem1.Glyph = CType(resources.GetObject("commandColorBarItem1.Glyph"), System.Drawing.Image)
            commandColorBarItem1.Hint = "Set the foreground color of the control"
            commandColorBarItem1.Id = 5
            commandColorBarItem1.Name = "commandColorBarItem1"
            ' 
            ' commandColorBarItem2
            ' 
            commandColorBarItem2.ButtonStyle = BarButtonStyle.DropDown
            commandColorBarItem2.Caption = "Bac&kground Color"
            commandColorBarItem2.Command = ReportCommand.BackColor
            commandColorBarItem2.Enabled = False
            commandColorBarItem2.Glyph = CType(resources.GetObject("commandColorBarItem2.Glyph"), System.Drawing.Image)
            commandColorBarItem2.Hint = "Set the background color of the control"
            commandColorBarItem2.Id = 6
            commandColorBarItem2.Name = "commandColorBarItem2"
            ' 
            ' barSubItem7
            ' 
            barSubItem7.Caption = "&Font"
            barSubItem7.Id = 52
            barSubItem7.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(commandBarItem1, True), New LinkPersistInfo(commandBarItem2), New LinkPersistInfo(commandBarItem3)})
            barSubItem7.Name = "barSubItem7"
            ' 
            ' commandBarItem1
            ' 
            commandBarItem1.Caption = "&Bold"
            commandBarItem1.Command = ReportCommand.FontBold
            commandBarItem1.Enabled = False
            commandBarItem1.Hint = "Make the font bold"
            commandBarItem1.Id = 2
            commandBarItem1.ImageIndex = 0
            commandBarItem1.ItemShortcut = New BarShortcut(Keys.Control Or Keys.B)
            commandBarItem1.Name = "commandBarItem1"
            ' 
            ' commandBarItem2
            ' 
            commandBarItem2.Caption = "&Italic"
            commandBarItem2.Command = ReportCommand.FontItalic
            commandBarItem2.Enabled = False
            commandBarItem2.Hint = "Make the font italic"
            commandBarItem2.Id = 3
            commandBarItem2.ImageIndex = 1
            commandBarItem2.ItemShortcut = New BarShortcut(Keys.Control Or Keys.I)
            commandBarItem2.Name = "commandBarItem2"
            ' 
            ' commandBarItem3
            ' 
            commandBarItem3.Caption = "&Underline"
            commandBarItem3.Command = ReportCommand.FontUnderline
            commandBarItem3.Enabled = False
            commandBarItem3.Hint = "Underline the font"
            commandBarItem3.Id = 4
            commandBarItem3.ImageIndex = 2
            commandBarItem3.ItemShortcut = New BarShortcut(Keys.Control Or Keys.U)
            commandBarItem3.Name = "commandBarItem3"
            ' 
            ' barSubItem8
            ' 
            barSubItem8.Caption = "&Justify"
            barSubItem8.Id = 53
            barSubItem8.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(commandBarItem4, True), New LinkPersistInfo(commandBarItem5), New LinkPersistInfo(commandBarItem6), New LinkPersistInfo(commandBarItem7)})
            barSubItem8.Name = "barSubItem8"
            ' 
            ' commandBarItem4
            ' 
            commandBarItem4.Caption = "&Left"
            commandBarItem4.Command = ReportCommand.JustifyLeft
            commandBarItem4.Enabled = False
            commandBarItem4.Hint = "Align the control's text to the left"
            commandBarItem4.Id = 7
            commandBarItem4.ImageIndex = 5
            commandBarItem4.Name = "commandBarItem4"
            ' 
            ' commandBarItem5
            ' 
            commandBarItem5.Caption = "&Center"
            commandBarItem5.Command = ReportCommand.JustifyCenter
            commandBarItem5.Enabled = False
            commandBarItem5.Hint = "Align the control's text to the center"
            commandBarItem5.Id = 8
            commandBarItem5.ImageIndex = 6
            commandBarItem5.Name = "commandBarItem5"
            ' 
            ' commandBarItem6
            ' 
            commandBarItem6.Caption = "&Rights"
            commandBarItem6.Command = ReportCommand.JustifyRight
            commandBarItem6.Enabled = False
            commandBarItem6.Hint = "Align the control's text to the right"
            commandBarItem6.Id = 9
            commandBarItem6.ImageIndex = 7
            commandBarItem6.Name = "commandBarItem6"
            ' 
            ' commandBarItem7
            ' 
            commandBarItem7.Caption = "&Justify"
            commandBarItem7.Command = ReportCommand.JustifyJustify
            commandBarItem7.Enabled = False
            commandBarItem7.Hint = "Justify the control's text"
            commandBarItem7.Id = 10
            commandBarItem7.ImageIndex = 8
            commandBarItem7.Name = "commandBarItem7"
            ' 
            ' barSubItem9
            ' 
            barSubItem9.Caption = "&Align"
            barSubItem9.Id = 54
            barSubItem9.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(commandBarItem9, True), New LinkPersistInfo(commandBarItem10), New LinkPersistInfo(commandBarItem11), New LinkPersistInfo(commandBarItem12, True), New LinkPersistInfo(commandBarItem13), New LinkPersistInfo(commandBarItem14), New LinkPersistInfo(commandBarItem8, True)})
            barSubItem9.Name = "barSubItem9"
            ' 
            ' commandBarItem9
            ' 
            commandBarItem9.Caption = "&Lefts"
            commandBarItem9.Command = ReportCommand.AlignLeft
            commandBarItem9.Enabled = False
            commandBarItem9.Hint = "Left align the selected controls"
            commandBarItem9.Id = 12
            commandBarItem9.ImageIndex = 18
            commandBarItem9.Name = "commandBarItem9"
            ' 
            ' commandBarItem10
            ' 
            commandBarItem10.Caption = "&Centers"
            commandBarItem10.Command = ReportCommand.AlignVerticalCenters
            commandBarItem10.Enabled = False
            commandBarItem10.Hint = "Align the centers of the selected controls vertically"
            commandBarItem10.Id = 13
            commandBarItem10.ImageIndex = 19
            commandBarItem10.Name = "commandBarItem10"
            ' 
            ' commandBarItem11
            ' 
            commandBarItem11.Caption = "&Rights"
            commandBarItem11.Command = ReportCommand.AlignRight
            commandBarItem11.Enabled = False
            commandBarItem11.Hint = "Right align the selected controls"
            commandBarItem11.Id = 14
            commandBarItem11.ImageIndex = 20
            commandBarItem11.Name = "commandBarItem11"
            ' 
            ' commandBarItem12
            ' 
            commandBarItem12.Caption = "&Tops"
            commandBarItem12.Command = ReportCommand.AlignTop
            commandBarItem12.Enabled = False
            commandBarItem12.Hint = "Align the tops of the selected controls"
            commandBarItem12.Id = 15
            commandBarItem12.ImageIndex = 21
            commandBarItem12.Name = "commandBarItem12"
            ' 
            ' commandBarItem13
            ' 
            commandBarItem13.Caption = "&Middles"
            commandBarItem13.Command = ReportCommand.AlignHorizontalCenters
            commandBarItem13.Enabled = False
            commandBarItem13.Hint = "Align the centers of the selected controls horizontally"
            commandBarItem13.Id = 16
            commandBarItem13.ImageIndex = 22
            commandBarItem13.Name = "commandBarItem13"
            ' 
            ' commandBarItem14
            ' 
            commandBarItem14.Caption = "&Bottoms"
            commandBarItem14.Command = ReportCommand.AlignBottom
            commandBarItem14.Enabled = False
            commandBarItem14.Hint = "Align the bottoms of the selected controls"
            commandBarItem14.Id = 17
            commandBarItem14.ImageIndex = 23
            commandBarItem14.Name = "commandBarItem14"
            ' 
            ' commandBarItem8
            ' 
            commandBarItem8.Caption = "to &Grid"
            commandBarItem8.Command = ReportCommand.AlignToGrid
            commandBarItem8.Enabled = False
            commandBarItem8.Hint = "Align the positions of the selected controls to the grid"
            commandBarItem8.Id = 11
            commandBarItem8.ImageIndex = 17
            commandBarItem8.Name = "commandBarItem8"
            ' 
            ' barSubItem10
            ' 
            barSubItem10.Caption = "&Make Same Size"
            barSubItem10.Id = 55
            barSubItem10.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(commandBarItem15, True), New LinkPersistInfo(commandBarItem16), New LinkPersistInfo(commandBarItem17), New LinkPersistInfo(commandBarItem18)})
            barSubItem10.Name = "barSubItem10"
            ' 
            ' commandBarItem15
            ' 
            commandBarItem15.Caption = "&Width"
            commandBarItem15.Command = ReportCommand.SizeToControlWidth
            commandBarItem15.Enabled = False
            commandBarItem15.Hint = "Make the selected controls have the same width"
            commandBarItem15.Id = 18
            commandBarItem15.ImageIndex = 24
            commandBarItem15.Name = "commandBarItem15"
            ' 
            ' commandBarItem16
            ' 
            commandBarItem16.Caption = "Size to Gri&d"
            commandBarItem16.Command = ReportCommand.SizeToGrid
            commandBarItem16.Enabled = False
            commandBarItem16.Hint = "Size the selected controls to the grid"
            commandBarItem16.Id = 19
            commandBarItem16.ImageIndex = 25
            commandBarItem16.Name = "commandBarItem16"
            ' 
            ' commandBarItem17
            ' 
            commandBarItem17.Caption = "&Height"
            commandBarItem17.Command = ReportCommand.SizeToControlHeight
            commandBarItem17.Enabled = False
            commandBarItem17.Hint = "Make the selected controls have the same height"
            commandBarItem17.Id = 20
            commandBarItem17.ImageIndex = 26
            commandBarItem17.Name = "commandBarItem17"
            ' 
            ' commandBarItem18
            ' 
            commandBarItem18.Caption = "&Both"
            commandBarItem18.Command = ReportCommand.SizeToControl
            commandBarItem18.Enabled = False
            commandBarItem18.Hint = "Make the selected controls the same size"
            commandBarItem18.Id = 21
            commandBarItem18.ImageIndex = 27
            commandBarItem18.Name = "commandBarItem18"
            ' 
            ' barSubItem11
            ' 
            barSubItem11.Caption = "&Horizontal Spacing"
            barSubItem11.Id = 56
            barSubItem11.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(commandBarItem19, True), New LinkPersistInfo(commandBarItem20), New LinkPersistInfo(commandBarItem21), New LinkPersistInfo(commandBarItem22)})
            barSubItem11.Name = "barSubItem11"
            ' 
            ' commandBarItem19
            ' 
            commandBarItem19.Caption = "Make &Equal"
            commandBarItem19.Command = ReportCommand.HorizSpaceMakeEqual
            commandBarItem19.Enabled = False
            commandBarItem19.Hint = "Make the spacing between the selected controls equal"
            commandBarItem19.Id = 22
            commandBarItem19.ImageIndex = 28
            commandBarItem19.Name = "commandBarItem19"
            ' 
            ' commandBarItem20
            ' 
            commandBarItem20.Caption = "&Increase"
            commandBarItem20.Command = ReportCommand.HorizSpaceIncrease
            commandBarItem20.Enabled = False
            commandBarItem20.Hint = "Increase the spacing between the selected controls"
            commandBarItem20.Id = 23
            commandBarItem20.ImageIndex = 29
            commandBarItem20.Name = "commandBarItem20"
            ' 
            ' commandBarItem21
            ' 
            commandBarItem21.Caption = "&Decrease"
            commandBarItem21.Command = ReportCommand.HorizSpaceDecrease
            commandBarItem21.Enabled = False
            commandBarItem21.Hint = "Decrease the spacing between the selected controls"
            commandBarItem21.Id = 24
            commandBarItem21.ImageIndex = 30
            commandBarItem21.Name = "commandBarItem21"
            ' 
            ' commandBarItem22
            ' 
            commandBarItem22.Caption = "&Remove"
            commandBarItem22.Command = ReportCommand.HorizSpaceConcatenate
            commandBarItem22.Enabled = False
            commandBarItem22.Hint = "Remove the spacing between the selected controls"
            commandBarItem22.Id = 25
            commandBarItem22.ImageIndex = 31
            commandBarItem22.Name = "commandBarItem22"
            ' 
            ' barSubItem12
            ' 
            barSubItem12.Caption = "&Vertical Spacing"
            barSubItem12.Id = 57
            barSubItem12.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(commandBarItem23, True), New LinkPersistInfo(commandBarItem24), New LinkPersistInfo(commandBarItem25), New LinkPersistInfo(commandBarItem26)})
            barSubItem12.Name = "barSubItem12"
            ' 
            ' commandBarItem23
            ' 
            commandBarItem23.Caption = "Make &Equal"
            commandBarItem23.Command = ReportCommand.VertSpaceMakeEqual
            commandBarItem23.Enabled = False
            commandBarItem23.Hint = "Make the spacing between the selected controls equal"
            commandBarItem23.Id = 26
            commandBarItem23.ImageIndex = 32
            commandBarItem23.Name = "commandBarItem23"
            ' 
            ' commandBarItem24
            ' 
            commandBarItem24.Caption = "&Increase"
            commandBarItem24.Command = ReportCommand.VertSpaceIncrease
            commandBarItem24.Enabled = False
            commandBarItem24.Hint = "Increase the spacing between the selected controls"
            commandBarItem24.Id = 27
            commandBarItem24.ImageIndex = 33
            commandBarItem24.Name = "commandBarItem24"
            ' 
            ' commandBarItem25
            ' 
            commandBarItem25.Caption = "&Decrease"
            commandBarItem25.Command = ReportCommand.VertSpaceDecrease
            commandBarItem25.Enabled = False
            commandBarItem25.Hint = "Decrease the spacing between the selected controls"
            commandBarItem25.Id = 28
            commandBarItem25.ImageIndex = 34
            commandBarItem25.Name = "commandBarItem25"
            ' 
            ' commandBarItem26
            ' 
            commandBarItem26.Caption = "&Remove"
            commandBarItem26.Command = ReportCommand.VertSpaceConcatenate
            commandBarItem26.Enabled = False
            commandBarItem26.Hint = "Remove the spacing between the selected controls"
            commandBarItem26.Id = 29
            commandBarItem26.ImageIndex = 35
            commandBarItem26.Name = "commandBarItem26"
            ' 
            ' barSubItem13
            ' 
            barSubItem13.Caption = "&Center in Form"
            barSubItem13.Id = 58
            barSubItem13.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(commandBarItem27, True), New LinkPersistInfo(commandBarItem28)})
            barSubItem13.Name = "barSubItem13"
            ' 
            ' commandBarItem27
            ' 
            commandBarItem27.Caption = "&Horizontally"
            commandBarItem27.Command = ReportCommand.CenterHorizontally
            commandBarItem27.Enabled = False
            commandBarItem27.Hint = "Horizontally center the selected controls within a band"
            commandBarItem27.Id = 30
            commandBarItem27.ImageIndex = 36
            commandBarItem27.Name = "commandBarItem27"
            ' 
            ' commandBarItem28
            ' 
            commandBarItem28.Caption = "&Vertically"
            commandBarItem28.Command = ReportCommand.CenterVertically
            commandBarItem28.Enabled = False
            commandBarItem28.Hint = "Vertically center the selected controls within a band"
            commandBarItem28.Id = 31
            commandBarItem28.ImageIndex = 37
            commandBarItem28.Name = "commandBarItem28"
            ' 
            ' barSubItem14
            ' 
            barSubItem14.Caption = "&Order"
            barSubItem14.Id = 59
            barSubItem14.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(commandBarItem29, True), New LinkPersistInfo(commandBarItem30)})
            barSubItem14.Name = "barSubItem14"
            ' 
            ' commandBarItem29
            ' 
            commandBarItem29.Caption = "&Bring to Front"
            commandBarItem29.Command = ReportCommand.BringToFront
            commandBarItem29.Enabled = False
            commandBarItem29.Hint = "Bring the selected controls to the front"
            commandBarItem29.Id = 32
            commandBarItem29.ImageIndex = 38
            commandBarItem29.Name = "commandBarItem29"
            ' 
            ' commandBarItem30
            ' 
            commandBarItem30.Caption = "&Send to Back"
            commandBarItem30.Command = ReportCommand.SendToBack
            commandBarItem30.Enabled = False
            commandBarItem30.Hint = "Move the selected controls to the back"
            commandBarItem30.Id = 33
            commandBarItem30.ImageIndex = 39
            commandBarItem30.Name = "commandBarItem30"
            ' 
            ' barSubItem15
            ' 
            barSubItem15.Caption = "&Window"
            barSubItem15.Id = 65
            barSubItem15.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(commandBarCheckItem1, True), New LinkPersistInfo(commandBarItem44), New LinkPersistInfo(commandBarItem45), New LinkPersistInfo(commandBarItem46), New LinkPersistInfo(barMdiChildrenListItem1, True)})
            barSubItem15.Name = "barSubItem15"
            ' 
            ' commandBarCheckItem1
            ' 
            commandBarCheckItem1.Caption = "&Tabbed Interface"
            commandBarCheckItem1.Checked = True
            commandBarCheckItem1.CheckedCommand = ReportCommand.ShowTabbedInterface
            commandBarCheckItem1.Enabled = False
            commandBarCheckItem1.Hint = "Switch between tabbed and window MDI layout modes"
            commandBarCheckItem1.Id = 66
            commandBarCheckItem1.Name = "commandBarCheckItem1"
            commandBarCheckItem1.UncheckedCommand = ReportCommand.ShowWindowInterface
            ' 
            ' commandBarItem44
            ' 
            commandBarItem44.Caption = "&Cascade"
            commandBarItem44.Command = ReportCommand.MdiCascade
            commandBarItem44.Enabled = False
            commandBarItem44.Hint = "Arrange all open documents cascaded, so that they overlap each other"
            commandBarItem44.Id = 67
            commandBarItem44.ImageIndex = 40
            commandBarItem44.Name = "commandBarItem44"
            ' 
            ' commandBarItem45
            ' 
            commandBarItem45.Caption = "Tile &Horizontal"
            commandBarItem45.Command = ReportCommand.MdiTileHorizontal
            commandBarItem45.Enabled = False
            commandBarItem45.Hint = "Arrange all open documents from top to bottom"
            commandBarItem45.Id = 68
            commandBarItem45.ImageIndex = 41
            commandBarItem45.Name = "commandBarItem45"
            ' 
            ' commandBarItem46
            ' 
            commandBarItem46.Caption = "Tile &Vertical"
            commandBarItem46.Command = ReportCommand.MdiTileVertical
            commandBarItem46.Enabled = False
            commandBarItem46.Hint = "Arrange all open documents from left to right"
            commandBarItem46.Id = 69
            commandBarItem46.ImageIndex = 42
            commandBarItem46.Name = "commandBarItem46"
            ' 
            ' barMdiChildrenListItem1
            ' 
            barMdiChildrenListItem1.Caption = "Windows"
            barMdiChildrenListItem1.Id = 70
            barMdiChildrenListItem1.Name = "barMdiChildrenListItem1"
            ' 
            ' bsiLookAndFeel
            ' 
            bsiLookAndFeel.Caption = "&Look and Feel"
            bsiLookAndFeel.Id = 74
            bsiLookAndFeel.Name = "bsiLookAndFeel"
            ' 
            ' designBar2
            ' 
            designBar2.BarName = "Toolbar"
            designBar2.DockCol = 0
            designBar2.DockRow = 1
            designBar2.DockStyle = BarDockStyle.Top
            designBar2.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(commandBarItem31), New LinkPersistInfo(commandBarItem32), New LinkPersistInfo(commandBarItem33), New LinkPersistInfo(commandBarItem34, True), New LinkPersistInfo(commandBarItem35), New LinkPersistInfo(commandBarItem36), New LinkPersistInfo(commandBarItem37, True), New LinkPersistInfo(commandBarItem38)})
            designBar2.Text = "Toolbar"
            ' 
            ' designBar3
            ' 
            designBar3.BarName = "Formatting Toolbar"
            designBar3.DockCol = 1
            designBar3.DockRow = 1
            designBar3.DockStyle = BarDockStyle.Top
            designBar3.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(barEditItem1), New LinkPersistInfo(barEditItem2), New LinkPersistInfo(commandBarItem1), New LinkPersistInfo(commandBarItem2), New LinkPersistInfo(commandBarItem3), New LinkPersistInfo(commandColorBarItem1, True), New LinkPersistInfo(commandColorBarItem2), New LinkPersistInfo(commandBarItem4, True), New LinkPersistInfo(commandBarItem5), New LinkPersistInfo(commandBarItem6), New LinkPersistInfo(commandBarItem7)})
            designBar3.Text = "Formatting Toolbar"
            ' 
            ' barEditItem1
            ' 
            barEditItem1.Caption = "Font Name"
            barEditItem1.Edit = recentlyUsedItemsComboBox1
            barEditItem1.Hint = "Font Name"
            barEditItem1.Id = 0
            barEditItem1.Name = "barEditItem1"
            barEditItem1.Width = 120
            ' 
            ' recentlyUsedItemsComboBox1
            ' 
            recentlyUsedItemsComboBox1.AutoHeight = False
            recentlyUsedItemsComboBox1.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            recentlyUsedItemsComboBox1.DropDownRows = 12
            recentlyUsedItemsComboBox1.Name = "recentlyUsedItemsComboBox1"
            ' 
            ' barEditItem2
            ' 
            barEditItem2.Caption = "Font Size"
            barEditItem2.Edit = designRepositoryItemComboBox1
            barEditItem2.Hint = "Font Size"
            barEditItem2.Id = 1
            barEditItem2.Name = "barEditItem2"
            barEditItem2.Width = 55
            ' 
            ' designRepositoryItemComboBox1
            ' 
            designRepositoryItemComboBox1.AutoHeight = False
            designRepositoryItemComboBox1.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            designRepositoryItemComboBox1.Name = "designRepositoryItemComboBox1"
            ' 
            ' designBar4
            ' 
            designBar4.BarName = "Layout Toolbar"
            designBar4.DockCol = 0
            designBar4.DockRow = 2
            designBar4.DockStyle = BarDockStyle.Top
            designBar4.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(commandBarItem8), New LinkPersistInfo(commandBarItem9, True), New LinkPersistInfo(commandBarItem10), New LinkPersistInfo(commandBarItem11), New LinkPersistInfo(commandBarItem12, True), New LinkPersistInfo(commandBarItem13), New LinkPersistInfo(commandBarItem14), New LinkPersistInfo(commandBarItem15, True), New LinkPersistInfo(commandBarItem16), New LinkPersistInfo(commandBarItem17), New LinkPersistInfo(commandBarItem18), New LinkPersistInfo(commandBarItem19, True), New LinkPersistInfo(commandBarItem20), New LinkPersistInfo(commandBarItem21), New LinkPersistInfo(commandBarItem22), New LinkPersistInfo(commandBarItem23, True), New LinkPersistInfo(commandBarItem24), New LinkPersistInfo(commandBarItem25), New LinkPersistInfo(commandBarItem26), New LinkPersistInfo(commandBarItem27, True), New LinkPersistInfo(commandBarItem28), New LinkPersistInfo(commandBarItem29, True), New LinkPersistInfo(commandBarItem30)})
            designBar4.Text = "Layout Toolbar"
            ' 
            ' designBar5
            ' 
            designBar5.BarName = "Status Bar"
            designBar5.CanDockStyle = BarCanDockStyle.Bottom
            designBar5.DockCol = 0
            designBar5.DockRow = 0
            designBar5.DockStyle = BarDockStyle.Bottom
            designBar5.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(barStaticItem1)})
            designBar5.OptionsBar.AllowQuickCustomization = False
            designBar5.OptionsBar.DrawDragBorder = False
            designBar5.OptionsBar.UseWholeRow = True
            designBar5.Text = "Status Bar"
            ' 
            ' barStaticItem1
            ' 
            barStaticItem1.AutoSize = BarStaticItemSize.Spring
            barStaticItem1.Id = 42
            barStaticItem1.Name = "barStaticItem1"
            barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
            barStaticItem1.Width = 32
            ' 
            ' bar1
            ' 
            bar1.BarName = "Zoom Toolbar"
            bar1.DockCol = 1
            bar1.DockRow = 2
            bar1.DockStyle = BarDockStyle.Top
            bar1.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(commandBarItem47), New LinkPersistInfo(xrZoomBarEditItem1), New LinkPersistInfo(commandBarItem48)})
            bar1.Text = "Zoom Toolbar"
            ' 
            ' commandBarItem47
            ' 
            commandBarItem47.Caption = "Zoom Out"
            commandBarItem47.Command = ReportCommand.ZoomOut
            commandBarItem47.Enabled = False
            commandBarItem47.Hint = "Zoom out the design surface"
            commandBarItem47.Id = 71
            commandBarItem47.ImageIndex = 43
            commandBarItem47.ItemShortcut = New BarShortcut(Keys.Control Or Keys.Subtract)
            commandBarItem47.Name = "commandBarItem47"
            ' 
            ' xrZoomBarEditItem1
            ' 
            xrZoomBarEditItem1.Caption = "Zoom"
            xrZoomBarEditItem1.Edit = designRepositoryItemComboBox2
            xrZoomBarEditItem1.Enabled = False
            xrZoomBarEditItem1.Hint = "Select or input the zoom factor"
            xrZoomBarEditItem1.Id = 72
            xrZoomBarEditItem1.Name = "xrZoomBarEditItem1"
            xrZoomBarEditItem1.Width = 70
            ' 
            ' designRepositoryItemComboBox2
            ' 
            designRepositoryItemComboBox2.AutoComplete = False
            designRepositoryItemComboBox2.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            designRepositoryItemComboBox2.Name = "designRepositoryItemComboBox2"
            ' 
            ' commandBarItem48
            ' 
            commandBarItem48.Caption = "Zoom In"
            commandBarItem48.Command = ReportCommand.ZoomIn
            commandBarItem48.Enabled = False
            commandBarItem48.Hint = "Zoom in the design surface"
            commandBarItem48.Id = 73
            commandBarItem48.ImageIndex = 44
            commandBarItem48.ItemShortcut = New BarShortcut(Keys.Control Or Keys.Add)
            commandBarItem48.Name = "commandBarItem48"
            ' 
            ' barDockControlTop
            ' 
            barDockControlTop.Dock = DockStyle.Top
            barDockControlTop.Location = New System.Drawing.Point(0, 0)
            barDockControlTop.Size = New System.Drawing.Size(901, 79)
            ' 
            ' barDockControlBottom
            ' 
            barDockControlBottom.Dock = DockStyle.Bottom
            barDockControlBottom.Location = New System.Drawing.Point(0, 453)
            barDockControlBottom.Size = New System.Drawing.Size(901, 29)
            ' 
            ' barDockControlLeft
            ' 
            barDockControlLeft.Dock = DockStyle.Left
            barDockControlLeft.Location = New System.Drawing.Point(0, 79)
            barDockControlLeft.Size = New System.Drawing.Size(50, 374)
            ' 
            ' barDockControlRight
            ' 
            barDockControlRight.Dock = DockStyle.Right
            barDockControlRight.Location = New System.Drawing.Point(901, 79)
            barDockControlRight.Size = New System.Drawing.Size(0, 374)
            ' 
            ' xrDesignDockManager1
            ' 
            xrDesignDockManager1.Form = Me
            xrDesignDockManager1.ImageStream = CType(resources.GetObject("xrDesignDockManager1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            xrDesignDockManager1.RootPanels.AddRange(New Docking.DockPanel() {panelContainer1, errorListDockPanel1})
            xrDesignDockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
            ' 
            ' panelContainer1
            ' 
            panelContainer1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte(230))))), (CInt(((CByte(230))))), (CInt(((CByte(230))))))
            panelContainer1.Appearance.Options.UseBackColor = True
            panelContainer1.Controls.Add(reportExplorerDockPanel1)
            panelContainer1.Controls.Add(propertyGridDockPanel1)
            panelContainer1.Dock = Docking.DockingStyle.Right
            panelContainer1.ID = New Guid("b0bf6427-9bac-435c-b0ef-ad6e25bd3c19")
            panelContainer1.Location = New System.Drawing.Point(651, 79)
            panelContainer1.Name = "panelContainer1"
            panelContainer1.OriginalSize = New System.Drawing.Size(250, 200)
            panelContainer1.Size = New System.Drawing.Size(250, 374)
            panelContainer1.Text = "panelContainer1"
            ' 
            ' reportExplorerDockPanel1
            ' 
            reportExplorerDockPanel1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte(230))))), (CInt(((CByte(230))))), (CInt(((CByte(230))))))
            reportExplorerDockPanel1.Appearance.Options.UseBackColor = True
            reportExplorerDockPanel1.Controls.Add(reportExplorerDockPanel1_Container)
            reportExplorerDockPanel1.Dock = Docking.DockingStyle.Fill
            reportExplorerDockPanel1.ID = New Guid("fb3ec6cc-3b9b-4b9c-91cf-cff78c1edbf1")
            reportExplorerDockPanel1.ImageIndex = 3
            reportExplorerDockPanel1.Location = New System.Drawing.Point(0, 0)
            reportExplorerDockPanel1.Name = "reportExplorerDockPanel1"
            reportExplorerDockPanel1.OriginalSize = New System.Drawing.Size(250, 186)
            reportExplorerDockPanel1.Size = New System.Drawing.Size(250, 199)
            reportExplorerDockPanel1.Text = "Report Explorer"
            reportExplorerDockPanel1.XRDesignPanel = Nothing
            ' 
            ' reportExplorerDockPanel1_Container
            ' 
            reportExplorerDockPanel1_Container.Location = New System.Drawing.Point(3, 29)
            reportExplorerDockPanel1_Container.Name = "reportExplorerDockPanel1_Container"
            reportExplorerDockPanel1_Container.Size = New System.Drawing.Size(244, 167)
            reportExplorerDockPanel1_Container.TabIndex = 0
            ' 
            ' propertyGridDockPanel1
            ' 
            propertyGridDockPanel1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte(230))))), (CInt(((CByte(230))))), (CInt(((CByte(230))))))
            propertyGridDockPanel1.Appearance.Options.UseBackColor = True
            propertyGridDockPanel1.Controls.Add(propertyGridDockPanel1_Container)
            propertyGridDockPanel1.Dock = Docking.DockingStyle.Fill
            propertyGridDockPanel1.ID = New Guid("b38d12c3-cd06-4dec-b93d-63a0088e495a")
            propertyGridDockPanel1.ImageIndex = 2
            propertyGridDockPanel1.Location = New System.Drawing.Point(0, 199)
            propertyGridDockPanel1.Name = "propertyGridDockPanel1"
            propertyGridDockPanel1.OriginalSize = New System.Drawing.Size(250, 163)
            propertyGridDockPanel1.Size = New System.Drawing.Size(250, 175)
            propertyGridDockPanel1.Text = "Property Grid"
            propertyGridDockPanel1.XRDesignPanel = Nothing
            ' 
            ' propertyGridDockPanel1_Container
            ' 
            propertyGridDockPanel1_Container.Location = New System.Drawing.Point(3, 29)
            propertyGridDockPanel1_Container.Name = "propertyGridDockPanel1_Container"
            propertyGridDockPanel1_Container.Size = New System.Drawing.Size(244, 143)
            propertyGridDockPanel1_Container.TabIndex = 0
            ' 
            ' errorListDockPanel1
            ' 
            errorListDockPanel1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte(230))))), (CInt(((CByte(230))))), (CInt(((CByte(230))))))
            errorListDockPanel1.Appearance.Options.UseBackColor = True
            errorListDockPanel1.Controls.Add(errorListDockPanel1_Container)
            errorListDockPanel1.Dock = Docking.DockingStyle.Bottom
            errorListDockPanel1.ID = New Guid("5a9a01fd-6e95-4e81-a8c4-ac63153d7488")
            errorListDockPanel1.ImageIndex = 5
            errorListDockPanel1.Location = New System.Drawing.Point(50, 293)
            errorListDockPanel1.Name = "errorListDockPanel1"
            errorListDockPanel1.OriginalSize = New System.Drawing.Size(200, 160)
            errorListDockPanel1.Size = New System.Drawing.Size(601, 160)
            errorListDockPanel1.Text = "Scripts Errors"
            errorListDockPanel1.XRDesignPanel = Nothing
            ' 
            ' errorListDockPanel1_Container
            ' 
            errorListDockPanel1_Container.Location = New System.Drawing.Point(3, 29)
            errorListDockPanel1_Container.Name = "errorListDockPanel1_Container"
            errorListDockPanel1_Container.Size = New System.Drawing.Size(595, 128)
            errorListDockPanel1_Container.TabIndex = 0
            ' 
            ' xrDesignMdiController1
            ' 
            xrDesignPanelListener1.DesignControl = xrDesignBarManager1
            xrDesignPanelListener2.DesignControl = xrDesignDockManager1
            xrDesignPanelListener3.DesignControl = errorListDockPanel1
            xrDesignPanelListener4.DesignControl = propertyGridDockPanel1
            xrDesignPanelListener5.DesignControl = reportExplorerDockPanel1
            xrDesignMdiController1.DesignPanelListeners.AddRange(New XRDesignPanelListener() {xrDesignPanelListener1, xrDesignPanelListener2, xrDesignPanelListener3, xrDesignPanelListener4, xrDesignPanelListener5})
            xrDesignMdiController1.Form = Me
            xrDesignMdiController1.XtraTabbedMdiManager = xtraTabbedMdiManager1
            ' 
            ' xtraTabbedMdiManager1
            ' 
            xtraTabbedMdiManager1.MdiParent = Me
            ' 
            ' CustomReportDesignForm
            ' 
            ClientSize = New System.Drawing.Size(901, 482)
            Me.Controls.Add(errorListDockPanel1)
            Me.Controls.Add(panelContainer1)
            Me.Controls.Add(barDockControlLeft)
            Me.Controls.Add(barDockControlRight)
            Me.Controls.Add(barDockControlBottom)
            Me.Controls.Add(barDockControlTop)
            Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            IsMdiContainer = True
            Name = "CustomReportDesignForm"
            Text = "Report Designer"
            CType(xrDesignBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(recentlyUsedItemsComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(designRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(designRepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(xrDesignDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
            panelContainer1.ResumeLayout(False)
            reportExplorerDockPanel1.ResumeLayout(False)
            propertyGridDockPanel1.ResumeLayout(False)
            errorListDockPanel1.ResumeLayout(False)
            CType(xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Public Sub OpenReport(ByVal newReport As XtraReports.UI.XtraReport)
            xrDesignMdiController1.OpenReport(newReport)
        End Sub

        Public Sub CreateNewReport()
            xrDesignMdiController1.CreateNewReport()
        End Sub

        Public ReadOnly Property ActiveXRDesignPanel As XRDesignPanel
            Get
                Return xrDesignMdiController1.ActiveDesignPanel
            End Get
        End Property
    End Class
End Namespace
