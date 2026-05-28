Namespace DevExpress.XtraScheduler.Demos

    Partial Class SchedulerBarsModule

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
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.commonBar1 = New DevExpress.XtraScheduler.UI.CommonBar()
            Me.openScheduleItem1 = New DevExpress.XtraScheduler.UI.OpenScheduleItem()
            Me.saveScheduleItem1 = New DevExpress.XtraScheduler.UI.SaveScheduleItem()
            Me.printBar1 = New DevExpress.XtraScheduler.UI.PrintBar()
            Me.printPreviewItem1 = New DevExpress.XtraScheduler.UI.PrintPreviewItem()
            Me.printItem1 = New DevExpress.XtraScheduler.UI.PrintItem()
            Me.printPageSetupItem1 = New DevExpress.XtraScheduler.UI.PrintPageSetupItem()
            Me.appointmentBar1 = New DevExpress.XtraScheduler.UI.AppointmentBar()
            Me.newAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewAppointmentItem()
            Me.newRecurringAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem()
            Me.navigatorBar1 = New DevExpress.XtraScheduler.UI.NavigatorBar()
            Me.navigateViewBackwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewBackwardItem()
            Me.navigateViewForwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewForwardItem()
            Me.gotoTodayItem1 = New DevExpress.XtraScheduler.UI.GotoTodayItem()
            Me.viewZoomInItem1 = New DevExpress.XtraScheduler.UI.ViewZoomInItem()
            Me.viewZoomOutItem1 = New DevExpress.XtraScheduler.UI.ViewZoomOutItem()
            Me.arrangeBar1 = New DevExpress.XtraScheduler.UI.ArrangeBar()
            Me.switchToDayViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToDayViewItem()
            Me.switchToWorkWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem()
            Me.switchToWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWeekViewItem()
            Me.switchToMonthViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToMonthViewItem()
            Me.switchToTimelineViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem()
            Me.switchToGanttViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToGanttViewItem()
            Me.groupByBar1 = New DevExpress.XtraScheduler.UI.GroupByBar()
            Me.groupByNoneItem1 = New DevExpress.XtraScheduler.UI.GroupByNoneItem()
            Me.groupByDateItem1 = New DevExpress.XtraScheduler.UI.GroupByDateItem()
            Me.groupByResourceItem1 = New DevExpress.XtraScheduler.UI.GroupByResourceItem()
            Me.activeViewBar1 = New DevExpress.XtraScheduler.UI.ActiveViewBar()
            Me.timeScaleBar1 = New DevExpress.XtraScheduler.UI.TimeScaleBar()
            Me.switchTimeScalesItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesItem()
            Me.changeScaleWidthItem1 = New DevExpress.XtraScheduler.UI.ChangeScaleWidthItem()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.switchTimeScalesCaptionItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem()
            Me.layoutBar1 = New DevExpress.XtraScheduler.UI.LayoutBar()
            Me.switchCompressWeekendItem1 = New DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem()
            Me.switchShowWorkTimeOnlyItem1 = New DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem()
            Me.switchCellsAutoHeightItem1 = New DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem()
            Me.changeSnapToCellsUIItem1 = New DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem()
            Me.actionsBar1 = New DevExpress.XtraScheduler.UI.ActionsBar()
            Me.editAppointmentQueryItem1 = New DevExpress.XtraScheduler.UI.EditAppointmentQueryItem()
            Me.editOccurrenceUICommandItem1 = New DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem()
            Me.editSeriesUICommandItem1 = New DevExpress.XtraScheduler.UI.EditSeriesUICommandItem()
            Me.deleteAppointmentsItem1 = New DevExpress.XtraScheduler.UI.DeleteAppointmentsItem()
            Me.deleteOccurrenceItem1 = New DevExpress.XtraScheduler.UI.DeleteOccurrenceItem()
            Me.deleteSeriesItem1 = New DevExpress.XtraScheduler.UI.DeleteSeriesItem()
            Me.splitAppointmentItem1 = New DevExpress.XtraScheduler.UI.SplitAppointmentItem()
            Me.optionsBar1 = New DevExpress.XtraScheduler.UI.OptionsBar()
            Me.changeAppointmentStatusItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem()
            Me.changeAppointmentLabelItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem()
            Me.toggleRecurrenceItem1 = New DevExpress.XtraScheduler.UI.ToggleRecurrenceItem()
            Me.changeAppointmentReminderItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem()
            Me.repositoryItemDuration1 = New DevExpress.XtraScheduler.UI.RepositoryItemDuration()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.schedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController()
            Me.switchToAgendaViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToAgendaViewItem()
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemDuration1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerStorage), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerControl
            ' 
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.OptionsBehavior.UseAsyncMode = DevExpress.XtraScheduler.Demos.Program.OptUseAsyncMode
            Me.schedulerControl.OptionsView.EnableAnimation = False
            Me.schedulerControl.Location = New System.Drawing.Point(0, 93)
            Me.schedulerControl.MenuManager = Me.barManager1
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.Size = New System.Drawing.Size(704, 311)
            Me.schedulerControl.Start = New System.DateTime(2010, 7, 5, 0, 0, 0, 0)
            Me.schedulerControl.DataStorage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.OptionsView.EnableAnimation = False
            Me.schedulerControl.Views.DayView.ResourcesPerPage = 2
            Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl.Views.FullWeekView.Enabled = True
            Me.schedulerControl.Views.GanttView.Enabled = False
            Me.schedulerControl.Views.MonthView.ResourcesPerPage = 2
            Me.schedulerControl.Views.MonthView.WeekCount = 2
            Me.schedulerControl.Views.TimelineView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WeekView.Enabled = False
            Me.schedulerControl.Views.WeekView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
            Me.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler3)
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.commonBar1, Me.printBar1, Me.appointmentBar1, Me.navigatorBar1, Me.arrangeBar1, Me.groupByBar1, Me.activeViewBar1, Me.timeScaleBar1, Me.layoutBar1, Me.actionsBar1, Me.optionsBar1})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.openScheduleItem1, Me.saveScheduleItem1, Me.printPreviewItem1, Me.printItem1, Me.printPageSetupItem1, Me.newAppointmentItem1, Me.newRecurringAppointmentItem1, Me.navigateViewBackwardItem1, Me.navigateViewForwardItem1, Me.gotoTodayItem1, Me.viewZoomInItem1, Me.viewZoomOutItem1, Me.switchToDayViewItem1, Me.switchToWorkWeekViewItem1, Me.switchToWeekViewItem1, Me.switchToMonthViewItem1, Me.switchToTimelineViewItem1, Me.switchToGanttViewItem1, Me.groupByNoneItem1, Me.groupByDateItem1, Me.groupByResourceItem1, Me.switchTimeScalesItem1, Me.changeScaleWidthItem1, Me.switchTimeScalesCaptionItem1, Me.switchCompressWeekendItem1, Me.switchShowWorkTimeOnlyItem1, Me.switchCellsAutoHeightItem1, Me.changeSnapToCellsUIItem1, Me.editAppointmentQueryItem1, Me.editOccurrenceUICommandItem1, Me.editSeriesUICommandItem1, Me.deleteAppointmentsItem1, Me.deleteOccurrenceItem1, Me.deleteSeriesItem1, Me.splitAppointmentItem1, Me.changeAppointmentStatusItem1, Me.changeAppointmentLabelItem1, Me.toggleRecurrenceItem1, Me.changeAppointmentReminderItem1, Me.switchToAgendaViewItem1})
            Me.barManager1.MaxItemId = 40
            Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.repositoryItemDuration1})
            ' 
            ' commonBar1
            ' 
            Me.commonBar1.Control = Me.schedulerControl
            Me.commonBar1.DockCol = 0
            Me.commonBar1.DockRow = 0
            Me.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.commonBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.openScheduleItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.saveScheduleItem1)})
            ' 
            ' openScheduleItem1
            ' 
            Me.openScheduleItem1.Id = 0
            Me.openScheduleItem1.Name = "openScheduleItem1"
            ' 
            ' saveScheduleItem1
            ' 
            Me.saveScheduleItem1.Id = 1
            Me.saveScheduleItem1.Name = "saveScheduleItem1"
            ' 
            ' printBar1
            ' 
            Me.printBar1.Control = Me.schedulerControl
            Me.printBar1.DockCol = 1
            Me.printBar1.DockRow = 0
            Me.printBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.printBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printPageSetupItem1)})
            ' 
            ' printPreviewItem1
            ' 
            Me.printPreviewItem1.Id = 2
            Me.printPreviewItem1.Name = "printPreviewItem1"
            ' 
            ' printItem1
            ' 
            Me.printItem1.Id = 3
            Me.printItem1.Name = "printItem1"
            ' 
            ' printPageSetupItem1
            ' 
            Me.printPageSetupItem1.Id = 4
            Me.printPageSetupItem1.Name = "printPageSetupItem1"
            ' 
            ' appointmentBar1
            ' 
            Me.appointmentBar1.Control = Me.schedulerControl
            Me.appointmentBar1.DockCol = 2
            Me.appointmentBar1.DockRow = 0
            Me.appointmentBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.appointmentBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.newAppointmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.newRecurringAppointmentItem1)})
            ' 
            ' newAppointmentItem1
            ' 
            Me.newAppointmentItem1.Id = 5
            Me.newAppointmentItem1.Name = "newAppointmentItem1"
            ' 
            ' newRecurringAppointmentItem1
            ' 
            Me.newRecurringAppointmentItem1.Id = 6
            Me.newRecurringAppointmentItem1.Name = "newRecurringAppointmentItem1"
            ' 
            ' navigatorBar1
            ' 
            Me.navigatorBar1.Control = Me.schedulerControl
            Me.navigatorBar1.DockCol = 4
            Me.navigatorBar1.DockRow = 0
            Me.navigatorBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.navigatorBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.navigateViewBackwardItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.navigateViewForwardItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.gotoTodayItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.viewZoomInItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.viewZoomOutItem1)})
            ' 
            ' navigateViewBackwardItem1
            ' 
            Me.navigateViewBackwardItem1.Id = 7
            Me.navigateViewBackwardItem1.Name = "navigateViewBackwardItem1"
            ' 
            ' navigateViewForwardItem1
            ' 
            Me.navigateViewForwardItem1.Id = 8
            Me.navigateViewForwardItem1.Name = "navigateViewForwardItem1"
            ' 
            ' gotoTodayItem1
            ' 
            Me.gotoTodayItem1.Id = 9
            Me.gotoTodayItem1.Name = "gotoTodayItem1"
            ' 
            ' viewZoomInItem1
            ' 
            Me.viewZoomInItem1.Id = 10
            Me.viewZoomInItem1.Name = "viewZoomInItem1"
            ' 
            ' viewZoomOutItem1
            ' 
            Me.viewZoomOutItem1.Id = 11
            Me.viewZoomOutItem1.Name = "viewZoomOutItem1"
            ' 
            ' arrangeBar1
            ' 
            Me.arrangeBar1.Control = Me.schedulerControl
            Me.arrangeBar1.DockCol = 3
            Me.arrangeBar1.DockRow = 0
            Me.arrangeBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.arrangeBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.switchToDayViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.switchToWorkWeekViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.switchToWeekViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.switchToMonthViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.switchToTimelineViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.switchToGanttViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.switchToAgendaViewItem1)})
            ' 
            ' switchToDayViewItem1
            ' 
            Me.switchToDayViewItem1.Id = 12
            Me.switchToDayViewItem1.Name = "switchToDayViewItem1"
            ' 
            ' switchToWorkWeekViewItem1
            ' 
            Me.switchToWorkWeekViewItem1.Id = 13
            Me.switchToWorkWeekViewItem1.Name = "switchToWorkWeekViewItem1"
            ' 
            ' switchToWeekViewItem1
            ' 
            Me.switchToWeekViewItem1.Id = 14
            Me.switchToWeekViewItem1.Name = "switchToWeekViewItem1"
            ' 
            ' switchToMonthViewItem1
            ' 
            Me.switchToMonthViewItem1.Id = 15
            Me.switchToMonthViewItem1.Name = "switchToMonthViewItem1"
            ' 
            ' switchToTimelineViewItem1
            ' 
            Me.switchToTimelineViewItem1.Id = 16
            Me.switchToTimelineViewItem1.Name = "switchToTimelineViewItem1"
            ' 
            ' switchToGanttViewItem1
            ' 
            Me.switchToGanttViewItem1.Id = 17
            Me.switchToGanttViewItem1.Name = "switchToGanttViewItem1"
            ' 
            ' groupByBar1
            ' 
            Me.groupByBar1.Control = Me.schedulerControl
            Me.groupByBar1.DockCol = 5
            Me.groupByBar1.DockRow = 0
            Me.groupByBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.groupByBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.groupByNoneItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.groupByDateItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.groupByResourceItem1)})
            ' 
            ' groupByNoneItem1
            ' 
            Me.groupByNoneItem1.Id = 18
            Me.groupByNoneItem1.Name = "groupByNoneItem1"
            ' 
            ' groupByDateItem1
            ' 
            Me.groupByDateItem1.Id = 19
            Me.groupByDateItem1.Name = "groupByDateItem1"
            ' 
            ' groupByResourceItem1
            ' 
            Me.groupByResourceItem1.Id = 20
            Me.groupByResourceItem1.Name = "groupByResourceItem1"
            ' 
            ' activeViewBar1
            ' 
            Me.activeViewBar1.Control = Me.schedulerControl
            Me.activeViewBar1.DockCol = 2
            Me.activeViewBar1.DockRow = 1
            Me.activeViewBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.activeViewBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.switchToDayViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.switchToWorkWeekViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.switchToWeekViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.switchToMonthViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.switchToTimelineViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.switchToGanttViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.switchToAgendaViewItem1)})
            ' 
            ' timeScaleBar1
            ' 
            Me.timeScaleBar1.Control = Me.schedulerControl
            Me.timeScaleBar1.DockCol = 0
            Me.timeScaleBar1.DockRow = 1
            Me.timeScaleBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.timeScaleBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.switchTimeScalesItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeScaleWidthItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.switchTimeScalesCaptionItem1)})
            ' 
            ' switchTimeScalesItem1
            ' 
            Me.switchTimeScalesItem1.Id = 21
            Me.switchTimeScalesItem1.Name = "switchTimeScalesItem1"
            ' 
            ' changeScaleWidthItem1
            ' 
            Me.changeScaleWidthItem1.Edit = Me.repositoryItemSpinEdit1
            Me.changeScaleWidthItem1.Id = 22
            Me.changeScaleWidthItem1.Name = "changeScaleWidthItem1"
            Me.changeScaleWidthItem1.UseCommandCaption = True
            ' 
            ' repositoryItemSpinEdit1
            ' 
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {200, 0, 0, 0})
            Me.repositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' switchTimeScalesCaptionItem1
            ' 
            Me.switchTimeScalesCaptionItem1.Id = 23
            Me.switchTimeScalesCaptionItem1.Name = "switchTimeScalesCaptionItem1"
            ' 
            ' layoutBar1
            ' 
            Me.layoutBar1.Control = Me.schedulerControl
            Me.layoutBar1.DockCol = 1
            Me.layoutBar1.DockRow = 1
            Me.layoutBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.layoutBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.switchCompressWeekendItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.switchShowWorkTimeOnlyItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.switchCellsAutoHeightItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeSnapToCellsUIItem1)})
            ' 
            ' switchCompressWeekendItem1
            ' 
            Me.switchCompressWeekendItem1.Id = 24
            Me.switchCompressWeekendItem1.Name = "switchCompressWeekendItem1"
            ' 
            ' switchShowWorkTimeOnlyItem1
            ' 
            Me.switchShowWorkTimeOnlyItem1.Id = 25
            Me.switchShowWorkTimeOnlyItem1.Name = "switchShowWorkTimeOnlyItem1"
            ' 
            ' switchCellsAutoHeightItem1
            ' 
            Me.switchCellsAutoHeightItem1.Id = 26
            Me.switchCellsAutoHeightItem1.Name = "switchCellsAutoHeightItem1"
            ' 
            ' changeSnapToCellsUIItem1
            ' 
            Me.changeSnapToCellsUIItem1.Id = 27
            Me.changeSnapToCellsUIItem1.Name = "changeSnapToCellsUIItem1"
            ' 
            ' actionsBar1
            ' 
            Me.actionsBar1.Control = Me.schedulerControl
            Me.actionsBar1.DockCol = 0
            Me.actionsBar1.DockRow = 2
            Me.actionsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.actionsBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.editAppointmentQueryItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteAppointmentsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.splitAppointmentItem1)})
            ' 
            ' editAppointmentQueryItem1
            ' 
            Me.editAppointmentQueryItem1.Id = 28
            Me.editAppointmentQueryItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.editOccurrenceUICommandItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.editSeriesUICommandItem1)})
            Me.editAppointmentQueryItem1.Name = "editAppointmentQueryItem1"
            Me.editAppointmentQueryItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            ' 
            ' editOccurrenceUICommandItem1
            ' 
            Me.editOccurrenceUICommandItem1.Id = 29
            Me.editOccurrenceUICommandItem1.Name = "editOccurrenceUICommandItem1"
            ' 
            ' editSeriesUICommandItem1
            ' 
            Me.editSeriesUICommandItem1.Id = 30
            Me.editSeriesUICommandItem1.Name = "editSeriesUICommandItem1"
            ' 
            ' deleteAppointmentsItem1
            ' 
            Me.deleteAppointmentsItem1.Id = 31
            Me.deleteAppointmentsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.deleteOccurrenceItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteSeriesItem1)})
            Me.deleteAppointmentsItem1.Name = "deleteAppointmentsItem1"
            Me.deleteAppointmentsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            ' 
            ' deleteOccurrenceItem1
            ' 
            Me.deleteOccurrenceItem1.Id = 32
            Me.deleteOccurrenceItem1.Name = "deleteOccurrenceItem1"
            ' 
            ' deleteSeriesItem1
            ' 
            Me.deleteSeriesItem1.Id = 33
            Me.deleteSeriesItem1.Name = "deleteSeriesItem1"
            ' 
            ' splitAppointmentItem1
            ' 
            Me.splitAppointmentItem1.Id = 34
            Me.splitAppointmentItem1.Name = "splitAppointmentItem1"
            ' 
            ' optionsBar1
            ' 
            Me.optionsBar1.Control = Me.schedulerControl
            Me.optionsBar1.DockCol = 1
            Me.optionsBar1.DockRow = 2
            Me.optionsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.optionsBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.changeAppointmentStatusItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeAppointmentLabelItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleRecurrenceItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeAppointmentReminderItem1)})
            ' 
            ' changeAppointmentStatusItem1
            ' 
            Me.changeAppointmentStatusItem1.Id = 35
            Me.changeAppointmentStatusItem1.Name = "changeAppointmentStatusItem1"
            ' 
            ' changeAppointmentLabelItem1
            ' 
            Me.changeAppointmentLabelItem1.Id = 36
            Me.changeAppointmentLabelItem1.Name = "changeAppointmentLabelItem1"
            ' 
            ' toggleRecurrenceItem1
            ' 
            Me.toggleRecurrenceItem1.Id = 37
            Me.toggleRecurrenceItem1.Name = "toggleRecurrenceItem1"
            ' 
            ' changeAppointmentReminderItem1
            ' 
            Me.changeAppointmentReminderItem1.Edit = Me.repositoryItemDuration1
            Me.changeAppointmentReminderItem1.Id = 38
            Me.changeAppointmentReminderItem1.Name = "changeAppointmentReminderItem1"
            Me.changeAppointmentReminderItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
            ' 
            ' repositoryItemDuration1
            ' 
            Me.repositoryItemDuration1.AutoHeight = False
            Me.repositoryItemDuration1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDuration1.Name = "repositoryItemDuration1"
            Me.repositoryItemDuration1.ShowEmptyItem = True
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(704, 93)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 404)
            Me.barDockControlBottom.Size = New System.Drawing.Size(704, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 93)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 311)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(704, 93)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 311)
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
            ' switchToAgendaViewItem1
            ' 
            Me.switchToAgendaViewItem1.Id = 39
            Me.switchToAgendaViewItem1.Name = "switchToAgendaViewItem1"
            ' 
            ' SchedulerBarsModule
            ' 
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "SchedulerBarsModule"
            Me.Size = New System.Drawing.Size(704, 404)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.SchedulerBarsModule_Load)
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemDuration1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerStorage), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private schedulerControl As DevExpress.XtraScheduler.SchedulerControl

        Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage

        Private components As System.ComponentModel.IContainer = Nothing

        Private barManager1 As DevExpress.XtraBars.BarManager

        Private commonBar1 As DevExpress.XtraScheduler.UI.CommonBar

        Private openScheduleItem1 As DevExpress.XtraScheduler.UI.OpenScheduleItem

        Private saveScheduleItem1 As DevExpress.XtraScheduler.UI.SaveScheduleItem

        Private printBar1 As DevExpress.XtraScheduler.UI.PrintBar

        Private printPreviewItem1 As DevExpress.XtraScheduler.UI.PrintPreviewItem

        Private printItem1 As DevExpress.XtraScheduler.UI.PrintItem

        Private printPageSetupItem1 As DevExpress.XtraScheduler.UI.PrintPageSetupItem

        Private appointmentBar1 As DevExpress.XtraScheduler.UI.AppointmentBar

        Private newAppointmentItem1 As DevExpress.XtraScheduler.UI.NewAppointmentItem

        Private newRecurringAppointmentItem1 As DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem

        Private navigatorBar1 As DevExpress.XtraScheduler.UI.NavigatorBar

        Private navigateViewBackwardItem1 As DevExpress.XtraScheduler.UI.NavigateViewBackwardItem

        Private navigateViewForwardItem1 As DevExpress.XtraScheduler.UI.NavigateViewForwardItem

        Private gotoTodayItem1 As DevExpress.XtraScheduler.UI.GotoTodayItem

        Private viewZoomInItem1 As DevExpress.XtraScheduler.UI.ViewZoomInItem

        Private viewZoomOutItem1 As DevExpress.XtraScheduler.UI.ViewZoomOutItem

        Private arrangeBar1 As DevExpress.XtraScheduler.UI.ArrangeBar

        Private switchToDayViewItem1 As DevExpress.XtraScheduler.UI.SwitchToDayViewItem

        Private switchToWorkWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem

        Private switchToWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToWeekViewItem

        Private switchToMonthViewItem1 As DevExpress.XtraScheduler.UI.SwitchToMonthViewItem

        Private switchToTimelineViewItem1 As DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem

        Private switchToGanttViewItem1 As DevExpress.XtraScheduler.UI.SwitchToGanttViewItem

        Private groupByBar1 As DevExpress.XtraScheduler.UI.GroupByBar

        Private groupByNoneItem1 As DevExpress.XtraScheduler.UI.GroupByNoneItem

        Private groupByDateItem1 As DevExpress.XtraScheduler.UI.GroupByDateItem

        Private groupByResourceItem1 As DevExpress.XtraScheduler.UI.GroupByResourceItem

        Private activeViewBar1 As DevExpress.XtraScheduler.UI.ActiveViewBar

        Private timeScaleBar1 As DevExpress.XtraScheduler.UI.TimeScaleBar

        Private switchTimeScalesItem1 As DevExpress.XtraScheduler.UI.SwitchTimeScalesItem

        Private changeScaleWidthItem1 As DevExpress.XtraScheduler.UI.ChangeScaleWidthItem

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private switchTimeScalesCaptionItem1 As DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem

        Private layoutBar1 As DevExpress.XtraScheduler.UI.LayoutBar

        Private switchCompressWeekendItem1 As DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem

        Private switchShowWorkTimeOnlyItem1 As DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem

        Private switchCellsAutoHeightItem1 As DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem

        Private changeSnapToCellsUIItem1 As DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem

        Private actionsBar1 As DevExpress.XtraScheduler.UI.ActionsBar

        Private editAppointmentQueryItem1 As DevExpress.XtraScheduler.UI.EditAppointmentQueryItem

        Private editOccurrenceUICommandItem1 As DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem

        Private editSeriesUICommandItem1 As DevExpress.XtraScheduler.UI.EditSeriesUICommandItem

        Private deleteAppointmentsItem1 As DevExpress.XtraScheduler.UI.DeleteAppointmentsItem

        Private deleteOccurrenceItem1 As DevExpress.XtraScheduler.UI.DeleteOccurrenceItem

        Private deleteSeriesItem1 As DevExpress.XtraScheduler.UI.DeleteSeriesItem

        Private splitAppointmentItem1 As DevExpress.XtraScheduler.UI.SplitAppointmentItem

        Private optionsBar1 As DevExpress.XtraScheduler.UI.OptionsBar

        Private changeAppointmentStatusItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem

        Private changeAppointmentLabelItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem

        Private toggleRecurrenceItem1 As DevExpress.XtraScheduler.UI.ToggleRecurrenceItem

        Private changeAppointmentReminderItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem

        Private repositoryItemDuration1 As DevExpress.XtraScheduler.UI.RepositoryItemDuration

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

        Private schedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController

        Private switchToAgendaViewItem1 As DevExpress.XtraScheduler.UI.SwitchToAgendaViewItem
    End Class
End Namespace
