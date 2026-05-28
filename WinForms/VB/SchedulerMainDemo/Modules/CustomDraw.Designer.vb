Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos

    Partial Class CustomDrawModule

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
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
            Dim timeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraScheduler.Demos.CustomDrawModule))
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.openScheduleItem1 = New DevExpress.XtraScheduler.UI.OpenScheduleItem()
            Me.saveScheduleItem1 = New DevExpress.XtraScheduler.UI.SaveScheduleItem()
            Me.printPreviewItem1 = New DevExpress.XtraScheduler.UI.PrintPreviewItem()
            Me.printItem1 = New DevExpress.XtraScheduler.UI.PrintItem()
            Me.printPageSetupItem1 = New DevExpress.XtraScheduler.UI.PrintPageSetupItem()
            Me.newAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewAppointmentItem()
            Me.newRecurringAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem()
            Me.navigateViewBackwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewBackwardItem()
            Me.navigateViewForwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewForwardItem()
            Me.gotoTodayItem1 = New DevExpress.XtraScheduler.UI.GotoTodayItem()
            Me.viewZoomInItem1 = New DevExpress.XtraScheduler.UI.ViewZoomInItem()
            Me.viewZoomOutItem1 = New DevExpress.XtraScheduler.UI.ViewZoomOutItem()
            Me.switchToDayViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToDayViewItem()
            Me.switchToWorkWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem()
            Me.switchToWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWeekViewItem()
            Me.switchToFullWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem()
            Me.switchToMonthViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToMonthViewItem()
            Me.switchToTimelineViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem()
            Me.switchToGanttViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToGanttViewItem()
            Me.groupByNoneItem1 = New DevExpress.XtraScheduler.UI.GroupByNoneItem()
            Me.groupByDateItem1 = New DevExpress.XtraScheduler.UI.GroupByDateItem()
            Me.groupByResourceItem1 = New DevExpress.XtraScheduler.UI.GroupByResourceItem()
            Me.switchTimeScalesItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesItem()
            Me.changeScaleWidthItem1 = New DevExpress.XtraScheduler.UI.ChangeScaleWidthItem()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.switchTimeScalesCaptionItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem()
            Me.switchCompressWeekendItem1 = New DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem()
            Me.switchShowWorkTimeOnlyItem1 = New DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem()
            Me.switchCellsAutoHeightItem1 = New DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem()
            Me.changeSnapToCellsUIItem1 = New DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem()
            Me.editAppointmentQueryItem1 = New DevExpress.XtraScheduler.UI.EditAppointmentQueryItem()
            Me.editOccurrenceUICommandItem1 = New DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem()
            Me.editSeriesUICommandItem1 = New DevExpress.XtraScheduler.UI.EditSeriesUICommandItem()
            Me.deleteAppointmentsItem1 = New DevExpress.XtraScheduler.UI.DeleteAppointmentsItem()
            Me.deleteOccurrenceItem1 = New DevExpress.XtraScheduler.UI.DeleteOccurrenceItem()
            Me.deleteSeriesItem1 = New DevExpress.XtraScheduler.UI.DeleteSeriesItem()
            Me.splitAppointmentItem1 = New DevExpress.XtraScheduler.UI.SplitAppointmentItem()
            Me.changeAppointmentStatusItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem()
            Me.changeAppointmentLabelItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem()
            Me.toggleRecurrenceItem1 = New DevExpress.XtraScheduler.UI.ToggleRecurrenceItem()
            Me.changeAppointmentReminderItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem()
            Me.repositoryItemDuration1 = New DevExpress.XtraScheduler.UI.RepositoryItemDuration()
            Me.switchToAgendaViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToAgendaViewItem()
            Me.calendarToolsRibbonPageCategory1 = New DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory()
            Me.appointmentRibbonPage1 = New DevExpress.XtraScheduler.UI.AppointmentRibbonPage()
            Me.actionsRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActionsRibbonPageGroup()
            Me.optionsRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.OptionsRibbonPageGroup()
            Me.fileRibbonPage1 = New DevExpress.XtraScheduler.UI.FileRibbonPage()
            Me.commonRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.CommonRibbonPageGroup()
            Me.printRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.PrintRibbonPageGroup()
            Me.homeRibbonPage1 = New DevExpress.XtraScheduler.UI.HomeRibbonPage()
            Me.appointmentRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup()
            Me.navigatorRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup()
            Me.arrangeRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup()
            Me.groupByRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup()
            Me.viewRibbonPage1 = New DevExpress.XtraScheduler.UI.ViewRibbonPage()
            Me.activeViewRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup()
            Me.timeScaleRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup()
            Me.layoutRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup()
            Me.chkNavigationButton = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.chkWeekViewTopLeftCorner = New DevExpress.XtraEditors.CheckEdit()
            Me.chkAppointmentBackground = New DevExpress.XtraEditors.CheckEdit()
            Me.chkDayViewAllDayArea = New DevExpress.XtraEditors.CheckEdit()
            Me.chkGroupSeparator = New DevExpress.XtraEditors.CheckEdit()
            Me.chkTimeCell = New DevExpress.XtraEditors.CheckEdit()
            Me.chkDayOfWeekHeader = New DevExpress.XtraEditors.CheckEdit()
            Me.chkAppointment = New DevExpress.XtraEditors.CheckEdit()
            Me.chkDayHeader = New DevExpress.XtraEditors.CheckEdit()
            Me.chkResourceHeader = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.groupCustomization = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.schedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.schedulerPanel = New DevExpress.XtraEditors.PanelControl()
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerStorage), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemDuration1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkNavigationButton.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.chkWeekViewTopLeftCorner.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkAppointmentBackground.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkDayViewAllDayArea.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkGroupSeparator.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkTimeCell.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkDayOfWeekHeader.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkAppointment.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkDayHeader.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkResourceHeader.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupCustomization), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            CType((Me.schedulerPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.schedulerPanel.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' schedulerControl
            ' 
            Me.schedulerControl.DataStorage = Me.schedulerStorage
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.OptionsBehavior.UseAsyncMode = DevExpress.XtraScheduler.Demos.Program.OptUseAsyncMode
            Me.schedulerControl.OptionsView.EnableAnimation = False
            Me.schedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.[Date]
            Me.schedulerControl.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.schedulerControl.MenuManager = Me.ribbonControl1
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.None
            Me.schedulerControl.OptionsView.EnableAnimation = False
            Me.schedulerControl.Size = New System.Drawing.Size(804, 590)
            Me.schedulerControl.Start = New System.DateTime(2010, 7, 5, 0, 0, 0, 0)
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.DayCount = 3
            Me.schedulerControl.Views.DayView.ResourcesPerPage = 2
            Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl.Views.DayView.TimeScale = System.TimeSpan.Parse("01:00:00")
            Me.schedulerControl.Views.FullWeekView.Enabled = True
            Me.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler2)
            Me.schedulerControl.Views.GanttView.Enabled = False
            Me.schedulerControl.Views.MonthView.ResourcesPerPage = 2
            Me.schedulerControl.Views.TimelineView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WeekView.Enabled = False
            Me.schedulerControl.Views.WeekView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler3)
            AddHandler Me.schedulerControl.GroupTypeChanged, New System.EventHandler(AddressOf Me.schedulerControl_GroupTypeChanged)
            AddHandler Me.schedulerControl.ActiveViewChanged, New System.EventHandler(AddressOf Me.schedulerControl_ActiveViewChanged)
            AddHandler Me.schedulerControl.InitNewAppointment, New DevExpress.XtraScheduler.AppointmentEventHandler(AddressOf Me.schedulerControl_InitNewAppointment)
            AddHandler Me.schedulerControl.CustomDrawAppointment, New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(AddressOf Me.schedulerControl_CustomDrawAppointment)
            AddHandler Me.schedulerControl.CustomDrawAppointmentBackground, New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(AddressOf Me.schedulerControl_CustomDrawAppointmentBackground)
            AddHandler Me.schedulerControl.CustomDrawTimeCell, New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(AddressOf Me.schedulerControl_CustomDrawTimeCell)
            AddHandler Me.schedulerControl.CustomDrawDayHeader, New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(AddressOf Me.schedulerControl_CustomDrawDayHeader)
            AddHandler Me.schedulerControl.CustomDrawDayOfWeekHeader, New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(AddressOf Me.schedulerControl_CustomDrawDayOfWeekHeader)
            AddHandler Me.schedulerControl.CustomDrawResourceHeader, New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(AddressOf Me.schedulerControl_CustomDrawResourceHeader)
            AddHandler Me.schedulerControl.CustomDrawGroupSeparator, New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(AddressOf Me.schedulerControl_CustomDrawGroupSeparator)
            AddHandler Me.schedulerControl.CustomDrawDayViewAllDayArea, New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(AddressOf Me.schedulerControl_CustomDrawDayViewAllDayArea)
            AddHandler Me.schedulerControl.CustomDrawWeekViewTopLeftCorner, New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(AddressOf Me.schedulerControl_CustomDrawWeekViewTopLeftCorner)
            AddHandler Me.schedulerControl.CustomDrawNavigationButton, New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(AddressOf Me.schedulerControl_CustomDrawNavigationButton)
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.openScheduleItem1, Me.saveScheduleItem1, Me.printPreviewItem1, Me.printItem1, Me.printPageSetupItem1, Me.newAppointmentItem1, Me.newRecurringAppointmentItem1, Me.navigateViewBackwardItem1, Me.navigateViewForwardItem1, Me.gotoTodayItem1, Me.viewZoomInItem1, Me.viewZoomOutItem1, Me.switchToDayViewItem1, Me.switchToWorkWeekViewItem1, Me.switchToWeekViewItem1, Me.switchToFullWeekViewItem1, Me.switchToMonthViewItem1, Me.switchToTimelineViewItem1, Me.switchToGanttViewItem1, Me.groupByNoneItem1, Me.groupByDateItem1, Me.groupByResourceItem1, Me.switchTimeScalesItem1, Me.changeScaleWidthItem1, Me.switchTimeScalesCaptionItem1, Me.switchCompressWeekendItem1, Me.switchShowWorkTimeOnlyItem1, Me.switchCellsAutoHeightItem1, Me.changeSnapToCellsUIItem1, Me.editAppointmentQueryItem1, Me.editOccurrenceUICommandItem1, Me.editSeriesUICommandItem1, Me.deleteAppointmentsItem1, Me.deleteOccurrenceItem1, Me.deleteSeriesItem1, Me.splitAppointmentItem1, Me.changeAppointmentStatusItem1, Me.changeAppointmentLabelItem1, Me.toggleRecurrenceItem1, Me.changeAppointmentReminderItem1, Me.switchToAgendaViewItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.ribbonControl1.MaxItemId = 42
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.calendarToolsRibbonPageCategory1})
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.fileRibbonPage1, Me.homeRibbonPage1, Me.viewRibbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.repositoryItemDuration1})
            Me.ribbonControl1.Size = New System.Drawing.Size(1173, 245)
            ' 
            ' openScheduleItem1
            ' 
            Me.openScheduleItem1.Id = 1
            Me.openScheduleItem1.Name = "openScheduleItem1"
            ' 
            ' saveScheduleItem1
            ' 
            Me.saveScheduleItem1.Id = 2
            Me.saveScheduleItem1.Name = "saveScheduleItem1"
            ' 
            ' printPreviewItem1
            ' 
            Me.printPreviewItem1.Id = 3
            Me.printPreviewItem1.Name = "printPreviewItem1"
            ' 
            ' printItem1
            ' 
            Me.printItem1.Id = 4
            Me.printItem1.Name = "printItem1"
            ' 
            ' printPageSetupItem1
            ' 
            Me.printPageSetupItem1.Id = 5
            Me.printPageSetupItem1.Name = "printPageSetupItem1"
            ' 
            ' newAppointmentItem1
            ' 
            Me.newAppointmentItem1.Id = 6
            Me.newAppointmentItem1.Name = "newAppointmentItem1"
            ' 
            ' newRecurringAppointmentItem1
            ' 
            Me.newRecurringAppointmentItem1.Id = 7
            Me.newRecurringAppointmentItem1.Name = "newRecurringAppointmentItem1"
            ' 
            ' navigateViewBackwardItem1
            ' 
            Me.navigateViewBackwardItem1.Id = 8
            Me.navigateViewBackwardItem1.Name = "navigateViewBackwardItem1"
            ' 
            ' navigateViewForwardItem1
            ' 
            Me.navigateViewForwardItem1.Id = 9
            Me.navigateViewForwardItem1.Name = "navigateViewForwardItem1"
            ' 
            ' gotoTodayItem1
            ' 
            Me.gotoTodayItem1.Id = 10
            Me.gotoTodayItem1.Name = "gotoTodayItem1"
            ' 
            ' viewZoomInItem1
            ' 
            Me.viewZoomInItem1.Id = 11
            Me.viewZoomInItem1.Name = "viewZoomInItem1"
            ' 
            ' viewZoomOutItem1
            ' 
            Me.viewZoomOutItem1.Id = 12
            Me.viewZoomOutItem1.Name = "viewZoomOutItem1"
            ' 
            ' switchToDayViewItem1
            ' 
            Me.switchToDayViewItem1.Id = 13
            Me.switchToDayViewItem1.Name = "switchToDayViewItem1"
            ' 
            ' switchToWorkWeekViewItem1
            ' 
            Me.switchToWorkWeekViewItem1.Id = 14
            Me.switchToWorkWeekViewItem1.Name = "switchToWorkWeekViewItem1"
            ' 
            ' switchToWeekViewItem1
            ' 
            Me.switchToWeekViewItem1.Id = 15
            Me.switchToWeekViewItem1.Name = "switchToWeekViewItem1"
            ' 
            ' switchToFullWeekViewItem1
            ' 
            Me.switchToFullWeekViewItem1.Id = 16
            Me.switchToFullWeekViewItem1.Name = "switchToFullWeekViewItem1"
            ' 
            ' switchToMonthViewItem1
            ' 
            Me.switchToMonthViewItem1.Id = 17
            Me.switchToMonthViewItem1.Name = "switchToMonthViewItem1"
            ' 
            ' switchToTimelineViewItem1
            ' 
            Me.switchToTimelineViewItem1.Id = 18
            Me.switchToTimelineViewItem1.Name = "switchToTimelineViewItem1"
            ' 
            ' switchToGanttViewItem1
            ' 
            Me.switchToGanttViewItem1.Id = 19
            Me.switchToGanttViewItem1.Name = "switchToGanttViewItem1"
            ' 
            ' groupByNoneItem1
            ' 
            Me.groupByNoneItem1.Id = 20
            Me.groupByNoneItem1.Name = "groupByNoneItem1"
            ' 
            ' groupByDateItem1
            ' 
            Me.groupByDateItem1.Id = 21
            Me.groupByDateItem1.Name = "groupByDateItem1"
            ' 
            ' groupByResourceItem1
            ' 
            Me.groupByResourceItem1.Id = 22
            Me.groupByResourceItem1.Name = "groupByResourceItem1"
            ' 
            ' switchTimeScalesItem1
            ' 
            Me.switchTimeScalesItem1.Id = 23
            Me.switchTimeScalesItem1.Name = "switchTimeScalesItem1"
            ' 
            ' changeScaleWidthItem1
            ' 
            Me.changeScaleWidthItem1.Edit = Me.repositoryItemSpinEdit1
            Me.changeScaleWidthItem1.Id = 24
            Me.changeScaleWidthItem1.Name = "changeScaleWidthItem1"
            Me.changeScaleWidthItem1.UseCommandCaption = True
            ' 
            ' repositoryItemSpinEdit1
            ' 
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {200, 0, 0, 0})
            Me.repositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' switchTimeScalesCaptionItem1
            ' 
            Me.switchTimeScalesCaptionItem1.Id = 25
            Me.switchTimeScalesCaptionItem1.Name = "switchTimeScalesCaptionItem1"
            ' 
            ' switchCompressWeekendItem1
            ' 
            Me.switchCompressWeekendItem1.Id = 26
            Me.switchCompressWeekendItem1.Name = "switchCompressWeekendItem1"
            ' 
            ' switchShowWorkTimeOnlyItem1
            ' 
            Me.switchShowWorkTimeOnlyItem1.Id = 27
            Me.switchShowWorkTimeOnlyItem1.Name = "switchShowWorkTimeOnlyItem1"
            ' 
            ' switchCellsAutoHeightItem1
            ' 
            Me.switchCellsAutoHeightItem1.Id = 28
            Me.switchCellsAutoHeightItem1.Name = "switchCellsAutoHeightItem1"
            ' 
            ' changeSnapToCellsUIItem1
            ' 
            Me.changeSnapToCellsUIItem1.Id = 29
            Me.changeSnapToCellsUIItem1.Name = "changeSnapToCellsUIItem1"
            ' 
            ' editAppointmentQueryItem1
            ' 
            Me.editAppointmentQueryItem1.Id = 30
            Me.editAppointmentQueryItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.editOccurrenceUICommandItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.editSeriesUICommandItem1)})
            Me.editAppointmentQueryItem1.Name = "editAppointmentQueryItem1"
            Me.editAppointmentQueryItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            ' 
            ' editOccurrenceUICommandItem1
            ' 
            Me.editOccurrenceUICommandItem1.Id = 31
            Me.editOccurrenceUICommandItem1.Name = "editOccurrenceUICommandItem1"
            ' 
            ' editSeriesUICommandItem1
            ' 
            Me.editSeriesUICommandItem1.Id = 32
            Me.editSeriesUICommandItem1.Name = "editSeriesUICommandItem1"
            ' 
            ' deleteAppointmentsItem1
            ' 
            Me.deleteAppointmentsItem1.Id = 33
            Me.deleteAppointmentsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.deleteOccurrenceItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteSeriesItem1)})
            Me.deleteAppointmentsItem1.Name = "deleteAppointmentsItem1"
            Me.deleteAppointmentsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            ' 
            ' deleteOccurrenceItem1
            ' 
            Me.deleteOccurrenceItem1.Id = 34
            Me.deleteOccurrenceItem1.Name = "deleteOccurrenceItem1"
            ' 
            ' deleteSeriesItem1
            ' 
            Me.deleteSeriesItem1.Id = 35
            Me.deleteSeriesItem1.Name = "deleteSeriesItem1"
            ' 
            ' splitAppointmentItem1
            ' 
            Me.splitAppointmentItem1.Id = 36
            Me.splitAppointmentItem1.Name = "splitAppointmentItem1"
            ' 
            ' changeAppointmentStatusItem1
            ' 
            Me.changeAppointmentStatusItem1.Id = 37
            Me.changeAppointmentStatusItem1.Name = "changeAppointmentStatusItem1"
            ' 
            ' changeAppointmentLabelItem1
            ' 
            Me.changeAppointmentLabelItem1.Id = 38
            Me.changeAppointmentLabelItem1.Name = "changeAppointmentLabelItem1"
            ' 
            ' toggleRecurrenceItem1
            ' 
            Me.toggleRecurrenceItem1.Id = 39
            Me.toggleRecurrenceItem1.Name = "toggleRecurrenceItem1"
            ' 
            ' changeAppointmentReminderItem1
            ' 
            Me.changeAppointmentReminderItem1.Edit = Me.repositoryItemDuration1
            Me.changeAppointmentReminderItem1.Id = 40
            Me.changeAppointmentReminderItem1.Name = "changeAppointmentReminderItem1"
            ' 
            ' repositoryItemDuration1
            ' 
            Me.repositoryItemDuration1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.repositoryItemDuration1.AutoHeight = False
            Me.repositoryItemDuration1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDuration1.DisabledStateText = Nothing
            Me.repositoryItemDuration1.Name = "repositoryItemDuration1"
            Me.repositoryItemDuration1.NullValuePromptShowForEmptyValue = True
            Me.repositoryItemDuration1.ShowEmptyItem = True
            Me.repositoryItemDuration1.ValidateOnEnterKey = True
            ' 
            ' switchToAgendaViewItem1
            ' 
            Me.switchToAgendaViewItem1.Id = 41
            Me.switchToAgendaViewItem1.Name = "switchToAgendaViewItem1"
            ' 
            ' calendarToolsRibbonPageCategory1
            ' 
            Me.calendarToolsRibbonPageCategory1.Control = Me.schedulerControl
            Me.calendarToolsRibbonPageCategory1.Name = "calendarToolsRibbonPageCategory1"
            Me.calendarToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.appointmentRibbonPage1})
            Me.calendarToolsRibbonPageCategory1.Visible = False
            ' 
            ' appointmentRibbonPage1
            ' 
            Me.appointmentRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.actionsRibbonPageGroup1, Me.optionsRibbonPageGroup1})
            Me.appointmentRibbonPage1.Name = "appointmentRibbonPage1"
            Me.appointmentRibbonPage1.Visible = False
            ' 
            ' actionsRibbonPageGroup1
            ' 
            Me.actionsRibbonPageGroup1.ItemLinks.Add(Me.editAppointmentQueryItem1)
            Me.actionsRibbonPageGroup1.ItemLinks.Add(Me.deleteAppointmentsItem1)
            Me.actionsRibbonPageGroup1.ItemLinks.Add(Me.splitAppointmentItem1)
            Me.actionsRibbonPageGroup1.Name = "actionsRibbonPageGroup1"
            ' 
            ' optionsRibbonPageGroup1
            ' 
            Me.optionsRibbonPageGroup1.ItemLinks.Add(Me.changeAppointmentStatusItem1)
            Me.optionsRibbonPageGroup1.ItemLinks.Add(Me.changeAppointmentLabelItem1)
            Me.optionsRibbonPageGroup1.ItemLinks.Add(Me.toggleRecurrenceItem1)
            Me.optionsRibbonPageGroup1.ItemLinks.Add(Me.changeAppointmentReminderItem1)
            Me.optionsRibbonPageGroup1.Name = "optionsRibbonPageGroup1"
            ' 
            ' fileRibbonPage1
            ' 
            Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.commonRibbonPageGroup1, Me.printRibbonPageGroup1})
            Me.fileRibbonPage1.Name = "fileRibbonPage1"
            ' 
            ' commonRibbonPageGroup1
            ' 
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.openScheduleItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.saveScheduleItem1)
            Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
            ' 
            ' printRibbonPageGroup1
            ' 
            Me.printRibbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
            Me.printRibbonPageGroup1.ItemLinks.Add(Me.printItem1)
            Me.printRibbonPageGroup1.ItemLinks.Add(Me.printPageSetupItem1)
            Me.printRibbonPageGroup1.Name = "printRibbonPageGroup1"
            ' 
            ' homeRibbonPage1
            ' 
            Me.homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.appointmentRibbonPageGroup1, Me.navigatorRibbonPageGroup1, Me.arrangeRibbonPageGroup1, Me.groupByRibbonPageGroup1})
            Me.homeRibbonPage1.Name = "homeRibbonPage1"
            ' 
            ' appointmentRibbonPageGroup1
            ' 
            Me.appointmentRibbonPageGroup1.ItemLinks.Add(Me.newAppointmentItem1)
            Me.appointmentRibbonPageGroup1.ItemLinks.Add(Me.newRecurringAppointmentItem1)
            Me.appointmentRibbonPageGroup1.Name = "appointmentRibbonPageGroup1"
            ' 
            ' navigatorRibbonPageGroup1
            ' 
            Me.navigatorRibbonPageGroup1.ItemLinks.Add(Me.navigateViewBackwardItem1)
            Me.navigatorRibbonPageGroup1.ItemLinks.Add(Me.navigateViewForwardItem1)
            Me.navigatorRibbonPageGroup1.ItemLinks.Add(Me.gotoTodayItem1)
            Me.navigatorRibbonPageGroup1.ItemLinks.Add(Me.viewZoomInItem1)
            Me.navigatorRibbonPageGroup1.ItemLinks.Add(Me.viewZoomOutItem1)
            Me.navigatorRibbonPageGroup1.Name = "navigatorRibbonPageGroup1"
            ' 
            ' arrangeRibbonPageGroup1
            ' 
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToDayViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToWorkWeekViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToWeekViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToFullWeekViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToMonthViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToTimelineViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToGanttViewItem1)
            Me.arrangeRibbonPageGroup1.Name = "arrangeRibbonPageGroup1"
            ' 
            ' groupByRibbonPageGroup1
            ' 
            Me.groupByRibbonPageGroup1.ItemLinks.Add(Me.groupByNoneItem1)
            Me.groupByRibbonPageGroup1.ItemLinks.Add(Me.groupByDateItem1)
            Me.groupByRibbonPageGroup1.ItemLinks.Add(Me.groupByResourceItem1)
            Me.groupByRibbonPageGroup1.Name = "groupByRibbonPageGroup1"
            ' 
            ' viewRibbonPage1
            ' 
            Me.viewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.activeViewRibbonPageGroup1, Me.timeScaleRibbonPageGroup1, Me.layoutRibbonPageGroup1})
            Me.viewRibbonPage1.Name = "viewRibbonPage1"
            ' 
            ' activeViewRibbonPageGroup1
            ' 
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToDayViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToWorkWeekViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToWeekViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToFullWeekViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToMonthViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToTimelineViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToGanttViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToAgendaViewItem1)
            Me.activeViewRibbonPageGroup1.Name = "activeViewRibbonPageGroup1"
            ' 
            ' timeScaleRibbonPageGroup1
            ' 
            Me.timeScaleRibbonPageGroup1.ItemLinks.Add(Me.switchTimeScalesItem1)
            Me.timeScaleRibbonPageGroup1.ItemLinks.Add(Me.changeScaleWidthItem1)
            Me.timeScaleRibbonPageGroup1.ItemLinks.Add(Me.switchTimeScalesCaptionItem1)
            Me.timeScaleRibbonPageGroup1.Name = "timeScaleRibbonPageGroup1"
            ' 
            ' layoutRibbonPageGroup1
            ' 
            Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.switchCompressWeekendItem1)
            Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.switchShowWorkTimeOnlyItem1)
            Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.switchCellsAutoHeightItem1)
            Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.changeSnapToCellsUIItem1)
            Me.layoutRibbonPageGroup1.Name = "layoutRibbonPageGroup1"
            ' 
            ' chkNavigationButton
            ' 
            Me.chkNavigationButton.EditValue = True
            Me.chkNavigationButton.Location = New System.Drawing.Point(18, 345)
            Me.chkNavigationButton.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.chkNavigationButton.Name = "chkNavigationButton"
            Me.chkNavigationButton.Properties.Caption = "Navigation Button"
            Me.chkNavigationButton.Size = New System.Drawing.Size(276, 34)
            Me.chkNavigationButton.StyleController = Me.layoutControl1
            Me.chkNavigationButton.TabIndex = 88
            AddHandler Me.chkNavigationButton.CheckedChanged, New System.EventHandler(AddressOf Me.OnCheckedChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.chkNavigationButton)
            Me.layoutControl1.Controls.Add(Me.chkWeekViewTopLeftCorner)
            Me.layoutControl1.Controls.Add(Me.chkAppointmentBackground)
            Me.layoutControl1.Controls.Add(Me.chkDayViewAllDayArea)
            Me.layoutControl1.Controls.Add(Me.chkGroupSeparator)
            Me.layoutControl1.Controls.Add(Me.chkTimeCell)
            Me.layoutControl1.Controls.Add(Me.chkDayOfWeekHeader)
            Me.layoutControl1.Controls.Add(Me.chkAppointment)
            Me.layoutControl1.Controls.Add(Me.chkDayHeader)
            Me.layoutControl1.Controls.Add(Me.chkResourceHeader)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(312, 527)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' chkWeekViewTopLeftCorner
            ' 
            Me.chkWeekViewTopLeftCorner.EditValue = True
            Me.chkWeekViewTopLeftCorner.Location = New System.Drawing.Point(18, 261)
            Me.chkWeekViewTopLeftCorner.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.chkWeekViewTopLeftCorner.Name = "chkWeekViewTopLeftCorner"
            Me.chkWeekViewTopLeftCorner.Properties.Caption = "Top-Left Corner"
            Me.chkWeekViewTopLeftCorner.Size = New System.Drawing.Size(276, 34)
            Me.chkWeekViewTopLeftCorner.StyleController = Me.layoutControl1
            Me.chkWeekViewTopLeftCorner.TabIndex = 85
            AddHandler Me.chkWeekViewTopLeftCorner.CheckedChanged, New System.EventHandler(AddressOf Me.OnCheckedChanged)
            ' 
            ' chkAppointmentBackground
            ' 
            Me.chkAppointmentBackground.EditValue = True
            Me.chkAppointmentBackground.Location = New System.Drawing.Point(18, 429)
            Me.chkAppointmentBackground.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.chkAppointmentBackground.Name = "chkAppointmentBackground"
            Me.chkAppointmentBackground.Properties.Caption = "Appointment Background"
            Me.chkAppointmentBackground.Size = New System.Drawing.Size(276, 34)
            Me.chkAppointmentBackground.StyleController = Me.layoutControl1
            Me.chkAppointmentBackground.TabIndex = 87
            AddHandler Me.chkAppointmentBackground.CheckedChanged, New System.EventHandler(AddressOf Me.OnCheckedChanged)
            ' 
            ' chkDayViewAllDayArea
            ' 
            Me.chkDayViewAllDayArea.EditValue = True
            Me.chkDayViewAllDayArea.Location = New System.Drawing.Point(18, 303)
            Me.chkDayViewAllDayArea.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.chkDayViewAllDayArea.Name = "chkDayViewAllDayArea"
            Me.chkDayViewAllDayArea.Properties.Caption = "All-Day Area"
            Me.chkDayViewAllDayArea.Size = New System.Drawing.Size(276, 34)
            Me.chkDayViewAllDayArea.StyleController = Me.layoutControl1
            Me.chkDayViewAllDayArea.TabIndex = 82
            AddHandler Me.chkDayViewAllDayArea.CheckedChanged, New System.EventHandler(AddressOf Me.OnCheckedChanged)
            ' 
            ' chkGroupSeparator
            ' 
            Me.chkGroupSeparator.EditValue = True
            Me.chkGroupSeparator.Location = New System.Drawing.Point(18, 177)
            Me.chkGroupSeparator.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.chkGroupSeparator.Name = "chkGroupSeparator"
            Me.chkGroupSeparator.Properties.Caption = "Group Separator"
            Me.chkGroupSeparator.Size = New System.Drawing.Size(276, 34)
            Me.chkGroupSeparator.StyleController = Me.layoutControl1
            Me.chkGroupSeparator.TabIndex = 84
            AddHandler Me.chkGroupSeparator.CheckedChanged, New System.EventHandler(AddressOf Me.OnCheckedChanged)
            ' 
            ' chkTimeCell
            ' 
            Me.chkTimeCell.EditValue = True
            Me.chkTimeCell.Location = New System.Drawing.Point(18, 219)
            Me.chkTimeCell.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.chkTimeCell.Name = "chkTimeCell"
            Me.chkTimeCell.Properties.Caption = "Time Cell"
            Me.chkTimeCell.Size = New System.Drawing.Size(276, 34)
            Me.chkTimeCell.StyleController = Me.layoutControl1
            Me.chkTimeCell.TabIndex = 81
            AddHandler Me.chkTimeCell.CheckedChanged, New System.EventHandler(AddressOf Me.OnCheckedChanged)
            ' 
            ' chkDayOfWeekHeader
            ' 
            Me.chkDayOfWeekHeader.EditValue = True
            Me.chkDayOfWeekHeader.Location = New System.Drawing.Point(18, 135)
            Me.chkDayOfWeekHeader.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.chkDayOfWeekHeader.Name = "chkDayOfWeekHeader"
            Me.chkDayOfWeekHeader.Properties.Caption = "Day-Of-Week Header"
            Me.chkDayOfWeekHeader.Size = New System.Drawing.Size(276, 34)
            Me.chkDayOfWeekHeader.StyleController = Me.layoutControl1
            Me.chkDayOfWeekHeader.TabIndex = 86
            AddHandler Me.chkDayOfWeekHeader.CheckedChanged, New System.EventHandler(AddressOf Me.OnCheckedChanged)
            ' 
            ' chkAppointment
            ' 
            Me.chkAppointment.EditValue = True
            Me.chkAppointment.Location = New System.Drawing.Point(18, 387)
            Me.chkAppointment.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.chkAppointment.Name = "chkAppointment"
            Me.chkAppointment.Properties.Caption = "Appointment"
            Me.chkAppointment.Size = New System.Drawing.Size(276, 34)
            Me.chkAppointment.StyleController = Me.layoutControl1
            Me.chkAppointment.TabIndex = 83
            AddHandler Me.chkAppointment.CheckedChanged, New System.EventHandler(AddressOf Me.OnCheckedChanged)
            ' 
            ' chkDayHeader
            ' 
            Me.chkDayHeader.EditValue = True
            Me.chkDayHeader.Location = New System.Drawing.Point(18, 51)
            Me.chkDayHeader.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.chkDayHeader.Name = "chkDayHeader"
            Me.chkDayHeader.Properties.Caption = "Day Header"
            Me.chkDayHeader.Size = New System.Drawing.Size(276, 34)
            Me.chkDayHeader.StyleController = Me.layoutControl1
            Me.chkDayHeader.TabIndex = 80
            AddHandler Me.chkDayHeader.CheckedChanged, New System.EventHandler(AddressOf Me.OnCheckedChanged)
            ' 
            ' chkResourceHeader
            ' 
            Me.chkResourceHeader.EditValue = True
            Me.chkResourceHeader.Location = New System.Drawing.Point(18, 93)
            Me.chkResourceHeader.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.chkResourceHeader.Name = "chkResourceHeader"
            Me.chkResourceHeader.Properties.Caption = "Resource Header"
            Me.chkResourceHeader.Size = New System.Drawing.Size(276, 34)
            Me.chkResourceHeader.StyleController = Me.layoutControl1
            Me.chkResourceHeader.TabIndex = 79
            AddHandler Me.chkResourceHeader.CheckedChanged, New System.EventHandler(AddressOf Me.OnCheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.groupCustomization})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(312, 527)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 471)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(302, 46)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' groupCustomization
            ' 
            Me.groupCustomization.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8, Me.layoutControlItem9, Me.layoutControlItem10, Me.layoutControlItem1, Me.layoutControlItem5})
            Me.groupCustomization.Location = New System.Drawing.Point(0, 0)
            Me.groupCustomization.Name = "groupCustomization"
            Me.groupCustomization.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            Me.groupCustomization.Size = New System.Drawing.Size(302, 471)
            Me.groupCustomization.Text = "Customization"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.chkDayHeader
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(284, 42)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.chkResourceHeader
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 42)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(284, 42)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.chkDayOfWeekHeader
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 84)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(284, 42)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.chkGroupSeparator
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 126)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(284, 42)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.chkTimeCell
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 168)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(284, 42)
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.chkDayViewAllDayArea
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 252)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(284, 42)
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.chkWeekViewTopLeftCorner
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 210)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(284, 42)
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem9.TextVisible = False
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.chkNavigationButton
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 294)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(284, 42)
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.chkAppointment
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 336)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(284, 42)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.chkAppointmentBackground
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 378)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(284, 42)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' schedulerBarController1
            ' 
            Me.schedulerBarController1.BarItems.Add(Me.openScheduleItem1)
            Me.schedulerBarController1.BarItems.Add(Me.saveScheduleItem1)
            Me.schedulerBarController1.BarItems.Add(Me.printPreviewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.printItem1)
            Me.schedulerBarController1.BarItems.Add(Me.printPageSetupItem1)
            Me.schedulerBarController1.BarItems.Add(Me.newAppointmentItem1)
            Me.schedulerBarController1.BarItems.Add(Me.newRecurringAppointmentItem1)
            Me.schedulerBarController1.BarItems.Add(Me.navigateViewBackwardItem1)
            Me.schedulerBarController1.BarItems.Add(Me.navigateViewForwardItem1)
            Me.schedulerBarController1.BarItems.Add(Me.gotoTodayItem1)
            Me.schedulerBarController1.BarItems.Add(Me.viewZoomInItem1)
            Me.schedulerBarController1.BarItems.Add(Me.viewZoomOutItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToDayViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToWorkWeekViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToWeekViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToFullWeekViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToMonthViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToTimelineViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToGanttViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.groupByNoneItem1)
            Me.schedulerBarController1.BarItems.Add(Me.groupByDateItem1)
            Me.schedulerBarController1.BarItems.Add(Me.groupByResourceItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchTimeScalesItem1)
            Me.schedulerBarController1.BarItems.Add(Me.changeScaleWidthItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchTimeScalesCaptionItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchCompressWeekendItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchShowWorkTimeOnlyItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchCellsAutoHeightItem1)
            Me.schedulerBarController1.BarItems.Add(Me.changeSnapToCellsUIItem1)
            Me.schedulerBarController1.BarItems.Add(Me.editAppointmentQueryItem1)
            Me.schedulerBarController1.BarItems.Add(Me.editOccurrenceUICommandItem1)
            Me.schedulerBarController1.BarItems.Add(Me.editSeriesUICommandItem1)
            Me.schedulerBarController1.BarItems.Add(Me.deleteAppointmentsItem1)
            Me.schedulerBarController1.BarItems.Add(Me.deleteOccurrenceItem1)
            Me.schedulerBarController1.BarItems.Add(Me.deleteSeriesItem1)
            Me.schedulerBarController1.BarItems.Add(Me.splitAppointmentItem1)
            Me.schedulerBarController1.BarItems.Add(Me.changeAppointmentStatusItem1)
            Me.schedulerBarController1.BarItems.Add(Me.changeAppointmentLabelItem1)
            Me.schedulerBarController1.BarItems.Add(Me.toggleRecurrenceItem1)
            Me.schedulerBarController1.BarItems.Add(Me.changeAppointmentReminderItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToAgendaViewItem1)
            Me.schedulerBarController1.Control = Me.schedulerControl
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            Me.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right
            Me.navigationPane1.ItemOrientation = System.Windows.Forms.Orientation.Vertical
            Me.navigationPane1.Location = New System.Drawing.Point(821, 245)
            Me.navigationPane1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.ShowExpandButton = False
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(352, 590)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.Size = New System.Drawing.Size(352, 590)
            Me.navigationPane1.TabIndex = 29
            Me.navigationPane1.Text = "navigationPane1"
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.BackgroundPadding = New System.Windows.Forms.Padding(0)
            Me.navigationPage1.Caption = "Options"
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.Image = CType((resources.GetObject("navigationPage1.Image")), System.Drawing.Image)
            Me.navigationPage1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.navigationPage1.Name = "navigationPage1"
            Me.navigationPage1.Size = New System.Drawing.Size(312, 527)
            ' 
            ' schedulerPanel
            ' 
            Me.schedulerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.schedulerPanel.Controls.Add(Me.schedulerControl)
            Me.schedulerPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerPanel.Location = New System.Drawing.Point(0, 245)
            Me.schedulerPanel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.schedulerPanel.Name = "schedulerPanel"
            Me.schedulerPanel.Padding = New System.Windows.Forms.Padding(0, 0, 17, 0)
            Me.schedulerPanel.Size = New System.Drawing.Size(821, 590)
            Me.schedulerPanel.TabIndex = 31
            ' 
            ' CustomDrawModule
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(10F, 23F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.schedulerPanel)
            Me.Controls.Add(Me.navigationPane1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.Name = "CustomDrawModule"
            Me.Size = New System.Drawing.Size(1173, 835)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.DayViewModule_Load)
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerStorage), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemDuration1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkNavigationButton.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.chkWeekViewTopLeftCorner.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkAppointmentBackground.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkDayViewAllDayArea.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkGroupSeparator.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkTimeCell.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkDayOfWeekHeader.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkAppointment.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkDayHeader.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkResourceHeader.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupCustomization), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            CType((Me.schedulerPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.schedulerPanel.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private schedulerControl As DevExpress.XtraScheduler.SchedulerControl

        Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage

        Private chkDayOfWeekHeader As DevExpress.XtraEditors.CheckEdit

        Private chkWeekViewTopLeftCorner As DevExpress.XtraEditors.CheckEdit

        Private chkGroupSeparator As DevExpress.XtraEditors.CheckEdit

        Private chkAppointment As DevExpress.XtraEditors.CheckEdit

        Private chkDayViewAllDayArea As DevExpress.XtraEditors.CheckEdit

        Private chkTimeCell As DevExpress.XtraEditors.CheckEdit

        Private chkDayHeader As DevExpress.XtraEditors.CheckEdit

        Private chkResourceHeader As DevExpress.XtraEditors.CheckEdit

        Private chkAppointmentBackground As DevExpress.XtraEditors.CheckEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private chkNavigationButton As DevExpress.XtraEditors.CheckEdit

        Private schedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl

        Private openScheduleItem1 As DevExpress.XtraScheduler.UI.OpenScheduleItem

        Private saveScheduleItem1 As DevExpress.XtraScheduler.UI.SaveScheduleItem

        Private printPreviewItem1 As DevExpress.XtraScheduler.UI.PrintPreviewItem

        Private printItem1 As DevExpress.XtraScheduler.UI.PrintItem

        Private printPageSetupItem1 As DevExpress.XtraScheduler.UI.PrintPageSetupItem

        Private newAppointmentItem1 As DevExpress.XtraScheduler.UI.NewAppointmentItem

        Private newRecurringAppointmentItem1 As DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem

        Private navigateViewBackwardItem1 As DevExpress.XtraScheduler.UI.NavigateViewBackwardItem

        Private navigateViewForwardItem1 As DevExpress.XtraScheduler.UI.NavigateViewForwardItem

        Private gotoTodayItem1 As DevExpress.XtraScheduler.UI.GotoTodayItem

        Private viewZoomInItem1 As DevExpress.XtraScheduler.UI.ViewZoomInItem

        Private viewZoomOutItem1 As DevExpress.XtraScheduler.UI.ViewZoomOutItem

        Private switchToDayViewItem1 As DevExpress.XtraScheduler.UI.SwitchToDayViewItem

        Private switchToWorkWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem

        Private switchToWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToWeekViewItem

        Private switchToFullWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem

        Private switchToMonthViewItem1 As DevExpress.XtraScheduler.UI.SwitchToMonthViewItem

        Private switchToTimelineViewItem1 As DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem

        Private switchToGanttViewItem1 As DevExpress.XtraScheduler.UI.SwitchToGanttViewItem

        Private groupByNoneItem1 As DevExpress.XtraScheduler.UI.GroupByNoneItem

        Private groupByDateItem1 As DevExpress.XtraScheduler.UI.GroupByDateItem

        Private groupByResourceItem1 As DevExpress.XtraScheduler.UI.GroupByResourceItem

        Private switchTimeScalesItem1 As DevExpress.XtraScheduler.UI.SwitchTimeScalesItem

        Private changeScaleWidthItem1 As DevExpress.XtraScheduler.UI.ChangeScaleWidthItem

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private switchTimeScalesCaptionItem1 As DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem

        Private switchCompressWeekendItem1 As DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem

        Private switchShowWorkTimeOnlyItem1 As DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem

        Private switchCellsAutoHeightItem1 As DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem

        Private changeSnapToCellsUIItem1 As DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem

        Private editAppointmentQueryItem1 As DevExpress.XtraScheduler.UI.EditAppointmentQueryItem

        Private editOccurrenceUICommandItem1 As DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem

        Private editSeriesUICommandItem1 As DevExpress.XtraScheduler.UI.EditSeriesUICommandItem

        Private deleteAppointmentsItem1 As DevExpress.XtraScheduler.UI.DeleteAppointmentsItem

        Private deleteOccurrenceItem1 As DevExpress.XtraScheduler.UI.DeleteOccurrenceItem

        Private deleteSeriesItem1 As DevExpress.XtraScheduler.UI.DeleteSeriesItem

        Private splitAppointmentItem1 As DevExpress.XtraScheduler.UI.SplitAppointmentItem

        Private changeAppointmentStatusItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem

        Private changeAppointmentLabelItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem

        Private toggleRecurrenceItem1 As DevExpress.XtraScheduler.UI.ToggleRecurrenceItem

        Private changeAppointmentReminderItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem

        Private repositoryItemDuration1 As DevExpress.XtraScheduler.UI.RepositoryItemDuration

        Private calendarToolsRibbonPageCategory1 As DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory

        Private appointmentRibbonPage1 As DevExpress.XtraScheduler.UI.AppointmentRibbonPage

        Private actionsRibbonPageGroup1 As DevExpress.XtraScheduler.UI.ActionsRibbonPageGroup

        Private optionsRibbonPageGroup1 As DevExpress.XtraScheduler.UI.OptionsRibbonPageGroup

        Private fileRibbonPage1 As DevExpress.XtraScheduler.UI.FileRibbonPage

        Private commonRibbonPageGroup1 As DevExpress.XtraScheduler.UI.CommonRibbonPageGroup

        Private printRibbonPageGroup1 As DevExpress.XtraScheduler.UI.PrintRibbonPageGroup

        Private homeRibbonPage1 As DevExpress.XtraScheduler.UI.HomeRibbonPage

        Private appointmentRibbonPageGroup1 As DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup

        Private navigatorRibbonPageGroup1 As DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup

        Private arrangeRibbonPageGroup1 As DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup

        Private groupByRibbonPageGroup1 As DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup

        Private viewRibbonPage1 As DevExpress.XtraScheduler.UI.ViewRibbonPage

        Private activeViewRibbonPageGroup1 As DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup

        Private timeScaleRibbonPageGroup1 As DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup

        Private layoutRibbonPageGroup1 As DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup

        Private switchToAgendaViewItem1 As DevExpress.XtraScheduler.UI.SwitchToAgendaViewItem

        Private navigationPane1 As DevExpress.XtraBars.Navigation.NavigationPane

        Private navigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private groupCustomization As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private schedulerPanel As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace
