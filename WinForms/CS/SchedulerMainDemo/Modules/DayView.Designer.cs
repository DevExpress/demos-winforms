using System;
using System.Windows.Forms;

namespace DevExpress.XtraScheduler.Demos {
	partial class DayViewModule {
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
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
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DayViewModule));
            this.schedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerDataStorage = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.openScheduleItem1 = new DevExpress.XtraScheduler.UI.OpenScheduleItem();
            this.saveScheduleItem1 = new DevExpress.XtraScheduler.UI.SaveScheduleItem();
            this.printPreviewItem1 = new DevExpress.XtraScheduler.UI.PrintPreviewItem();
            this.printItem1 = new DevExpress.XtraScheduler.UI.PrintItem();
            this.printPageSetupItem1 = new DevExpress.XtraScheduler.UI.PrintPageSetupItem();
            this.newAppointmentItem1 = new DevExpress.XtraScheduler.UI.NewAppointmentItem();
            this.newRecurringAppointmentItem1 = new DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem();
            this.navigateViewBackwardItem1 = new DevExpress.XtraScheduler.UI.NavigateViewBackwardItem();
            this.navigateViewForwardItem1 = new DevExpress.XtraScheduler.UI.NavigateViewForwardItem();
            this.gotoTodayItem1 = new DevExpress.XtraScheduler.UI.GotoTodayItem();
            this.viewZoomInItem1 = new DevExpress.XtraScheduler.UI.ViewZoomInItem();
            this.viewZoomOutItem1 = new DevExpress.XtraScheduler.UI.ViewZoomOutItem();
            this.switchToDayViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToDayViewItem();
            this.switchToWorkWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem();
            this.switchToWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToWeekViewItem();
            this.switchToFullWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem();
            this.switchToMonthViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToMonthViewItem();
            this.switchToTimelineViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem();
            this.switchToGanttViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToGanttViewItem();
            this.groupByNoneItem1 = new DevExpress.XtraScheduler.UI.GroupByNoneItem();
            this.groupByDateItem1 = new DevExpress.XtraScheduler.UI.GroupByDateItem();
            this.groupByResourceItem1 = new DevExpress.XtraScheduler.UI.GroupByResourceItem();
            this.switchTimeScalesItem1 = new DevExpress.XtraScheduler.UI.SwitchTimeScalesItem();
            this.changeScaleWidthItem1 = new DevExpress.XtraScheduler.UI.ChangeScaleWidthItem();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.switchTimeScalesCaptionItem1 = new DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem();
            this.switchCompressWeekendItem1 = new DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem();
            this.switchShowWorkTimeOnlyItem1 = new DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem();
            this.switchCellsAutoHeightItem1 = new DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem();
            this.changeSnapToCellsUIItem1 = new DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem();
            this.editAppointmentQueryItem1 = new DevExpress.XtraScheduler.UI.EditAppointmentQueryItem();
            this.editOccurrenceUICommandItem1 = new DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem();
            this.editSeriesUICommandItem1 = new DevExpress.XtraScheduler.UI.EditSeriesUICommandItem();
            this.deleteAppointmentsItem1 = new DevExpress.XtraScheduler.UI.DeleteAppointmentsItem();
            this.deleteOccurrenceItem1 = new DevExpress.XtraScheduler.UI.DeleteOccurrenceItem();
            this.deleteSeriesItem1 = new DevExpress.XtraScheduler.UI.DeleteSeriesItem();
            this.splitAppointmentItem1 = new DevExpress.XtraScheduler.UI.SplitAppointmentItem();
            this.changeAppointmentStatusItem1 = new DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem();
            this.changeAppointmentLabelItem1 = new DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem();
            this.toggleRecurrenceItem1 = new DevExpress.XtraScheduler.UI.ToggleRecurrenceItem();
            this.changeAppointmentReminderItem1 = new DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem();
            this.repositoryItemDuration1 = new DevExpress.XtraScheduler.UI.RepositoryItemDuration();
            this.switchToAgendaViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToAgendaViewItem();
            this.calendarToolsRibbonPageCategory1 = new DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory();
            this.appointmentRibbonPage1 = new DevExpress.XtraScheduler.UI.AppointmentRibbonPage();
            this.actionsRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.ActionsRibbonPageGroup();
            this.optionsRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.OptionsRibbonPageGroup();
            this.fileRibbonPage1 = new DevExpress.XtraScheduler.UI.FileRibbonPage();
            this.commonRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.CommonRibbonPageGroup();
            this.printRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.PrintRibbonPageGroup();
            this.homeRibbonPage1 = new DevExpress.XtraScheduler.UI.HomeRibbonPage();
            this.appointmentRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup();
            this.navigatorRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup();
            this.arrangeRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup();
            this.viewRibbonPage1 = new DevExpress.XtraScheduler.UI.ViewRibbonPage();
            this.activeViewRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup();
            this.timeScaleRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup();
            this.layoutRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup();
            this.schedulerBarController1 = new DevExpress.XtraScheduler.UI.SchedulerBarController(this.components);
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chkStatusOrientation = new DevExpress.XtraEditors.CheckEdit();
            this.chkShowOverAppointment = new DevExpress.XtraEditors.CheckEdit();
            this.cbTimeMarkerVisibility = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbTimeIndicatorVisibility = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chkAppointmentShadows = new DevExpress.XtraEditors.CheckEdit();
            this.spinDaysCount = new DevExpress.XtraEditors.SpinEdit();
            this.cbStatus = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cbSnapToCellsMode = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cbAllDayStatus = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.chkShowRightTimeRuler = new DevExpress.XtraEditors.CheckEdit();
            this.chkShowWorkTimeOnly = new DevExpress.XtraEditors.CheckEdit();
            this.chkShowAllDayArea = new DevExpress.XtraEditors.CheckEdit();
            this.chkShowDayHeaders = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupCurrentTimeVisualization = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.schedulerPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDuration1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).BeginInit();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkStatusOrientation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowOverAppointment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimeMarkerVisibility.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimeIndicatorVisibility.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAppointmentShadows.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDaysCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSnapToCellsMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAllDayStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowRightTimeRuler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowWorkTimeOnly.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowAllDayArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowDayHeaders.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCurrentTimeVisualization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.schedulerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // schedulerControl
            // 
            this.schedulerControl.DataStorage = this.schedulerDataStorage;
            this.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl.OptionsBehavior.UseAsyncMode = Program.OptUseAsyncMode;
            this.schedulerControl.OptionsView.EnableAnimation = false;
            this.schedulerControl.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl.MenuManager = this.ribbonControl1;
            this.schedulerControl.Name = "schedulerControl";
            this.schedulerControl.Size = new System.Drawing.Size(765, 512);
            this.schedulerControl.Start = new System.DateTime(2010, 7, 5, 0, 0, 0, 0);
            this.schedulerControl.TabIndex = 0;
            this.schedulerControl.Text = "schedulerControl1";
            this.schedulerControl.OptionsView.EnableAnimation = false;
            this.schedulerControl.Views.DayView.DayCount = 3;
            timeRuler2.HorizontalAlignment = DevExpress.XtraScheduler.TimeRulerHorizontalAlignment.Far;
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler2);
            this.schedulerControl.Views.GanttView.Enabled = false;
            this.schedulerControl.Views.MonthView.Enabled = false;
            this.schedulerControl.Views.TimelineView.Enabled = false;
            this.schedulerControl.Views.WeekView.Enabled = false;
            this.schedulerControl.Views.WorkWeekView.Enabled = false;
            this.schedulerControl.PopupMenuShowing += new DevExpress.XtraScheduler.PopupMenuShowingEventHandler(this.schedulerControl_PopupMenuShowing);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.openScheduleItem1,
            this.saveScheduleItem1,
            this.printPreviewItem1,
            this.printItem1,
            this.printPageSetupItem1,
            this.newAppointmentItem1,
            this.newRecurringAppointmentItem1,
            this.navigateViewBackwardItem1,
            this.navigateViewForwardItem1,
            this.gotoTodayItem1,
            this.viewZoomInItem1,
            this.viewZoomOutItem1,
            this.switchToDayViewItem1,
            this.switchToWorkWeekViewItem1,
            this.switchToWeekViewItem1,
            this.switchToFullWeekViewItem1,
            this.switchToMonthViewItem1,
            this.switchToTimelineViewItem1,
            this.switchToGanttViewItem1,
            this.groupByNoneItem1,
            this.groupByDateItem1,
            this.groupByResourceItem1,
            this.switchTimeScalesItem1,
            this.changeScaleWidthItem1,
            this.switchTimeScalesCaptionItem1,
            this.switchCompressWeekendItem1,
            this.switchShowWorkTimeOnlyItem1,
            this.switchCellsAutoHeightItem1,
            this.changeSnapToCellsUIItem1,
            this.editAppointmentQueryItem1,
            this.editOccurrenceUICommandItem1,
            this.editSeriesUICommandItem1,
            this.deleteAppointmentsItem1,
            this.deleteOccurrenceItem1,
            this.deleteSeriesItem1,
            this.splitAppointmentItem1,
            this.changeAppointmentStatusItem1,
            this.changeAppointmentLabelItem1,
            this.toggleRecurrenceItem1,
            this.changeAppointmentReminderItem1,
            this.switchToAgendaViewItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 42;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.calendarToolsRibbonPageCategory1});
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.fileRibbonPage1,
            this.homeRibbonPage1,
            this.viewRibbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemDuration1});
            this.ribbonControl1.Size = new System.Drawing.Size(1065, 141);
            // 
            // openScheduleItem1
            // 
            this.openScheduleItem1.Id = 1;
            this.openScheduleItem1.Name = "openScheduleItem1";
            // 
            // saveScheduleItem1
            // 
            this.saveScheduleItem1.Id = 2;
            this.saveScheduleItem1.Name = "saveScheduleItem1";
            // 
            // printPreviewItem1
            // 
            this.printPreviewItem1.Id = 3;
            this.printPreviewItem1.Name = "printPreviewItem1";
            // 
            // printItem1
            // 
            this.printItem1.Id = 4;
            this.printItem1.Name = "printItem1";
            // 
            // printPageSetupItem1
            // 
            this.printPageSetupItem1.Id = 5;
            this.printPageSetupItem1.Name = "printPageSetupItem1";
            // 
            // newAppointmentItem1
            // 
            this.newAppointmentItem1.Id = 6;
            this.newAppointmentItem1.Name = "newAppointmentItem1";
            // 
            // newRecurringAppointmentItem1
            // 
            this.newRecurringAppointmentItem1.Id = 7;
            this.newRecurringAppointmentItem1.Name = "newRecurringAppointmentItem1";
            // 
            // navigateViewBackwardItem1
            // 
            this.navigateViewBackwardItem1.Id = 8;
            this.navigateViewBackwardItem1.Name = "navigateViewBackwardItem1";
            // 
            // navigateViewForwardItem1
            // 
            this.navigateViewForwardItem1.Id = 9;
            this.navigateViewForwardItem1.Name = "navigateViewForwardItem1";
            // 
            // gotoTodayItem1
            // 
            this.gotoTodayItem1.Id = 10;
            this.gotoTodayItem1.Name = "gotoTodayItem1";
            // 
            // viewZoomInItem1
            // 
            this.viewZoomInItem1.Id = 11;
            this.viewZoomInItem1.Name = "viewZoomInItem1";
            // 
            // viewZoomOutItem1
            // 
            this.viewZoomOutItem1.Id = 12;
            this.viewZoomOutItem1.Name = "viewZoomOutItem1";
            // 
            // switchToDayViewItem1
            // 
            this.switchToDayViewItem1.Id = 13;
            this.switchToDayViewItem1.Name = "switchToDayViewItem1";
            // 
            // switchToWorkWeekViewItem1
            // 
            this.switchToWorkWeekViewItem1.Id = 14;
            this.switchToWorkWeekViewItem1.Name = "switchToWorkWeekViewItem1";
            // 
            // switchToWeekViewItem1
            // 
            this.switchToWeekViewItem1.Id = 15;
            this.switchToWeekViewItem1.Name = "switchToWeekViewItem1";
            // 
            // switchToFullWeekViewItem1
            // 
            this.switchToFullWeekViewItem1.Id = 16;
            this.switchToFullWeekViewItem1.Name = "switchToFullWeekViewItem1";
            // 
            // switchToMonthViewItem1
            // 
            this.switchToMonthViewItem1.Id = 17;
            this.switchToMonthViewItem1.Name = "switchToMonthViewItem1";
            // 
            // switchToTimelineViewItem1
            // 
            this.switchToTimelineViewItem1.Id = 18;
            this.switchToTimelineViewItem1.Name = "switchToTimelineViewItem1";
            // 
            // switchToGanttViewItem1
            // 
            this.switchToGanttViewItem1.Id = 19;
            this.switchToGanttViewItem1.Name = "switchToGanttViewItem1";
            // 
            // groupByNoneItem1
            // 
            this.groupByNoneItem1.Id = 20;
            this.groupByNoneItem1.Name = "groupByNoneItem1";
            // 
            // groupByDateItem1
            // 
            this.groupByDateItem1.Id = 21;
            this.groupByDateItem1.Name = "groupByDateItem1";
            // 
            // groupByResourceItem1
            // 
            this.groupByResourceItem1.Id = 22;
            this.groupByResourceItem1.Name = "groupByResourceItem1";
            // 
            // switchTimeScalesItem1
            // 
            this.switchTimeScalesItem1.Id = 23;
            this.switchTimeScalesItem1.Name = "switchTimeScalesItem1";
            // 
            // changeScaleWidthItem1
            // 
            this.changeScaleWidthItem1.Edit = this.repositoryItemSpinEdit1;
            this.changeScaleWidthItem1.Id = 24;
            this.changeScaleWidthItem1.Name = "changeScaleWidthItem1";
            this.changeScaleWidthItem1.UseCommandCaption = true;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // switchTimeScalesCaptionItem1
            // 
            this.switchTimeScalesCaptionItem1.Id = 25;
            this.switchTimeScalesCaptionItem1.Name = "switchTimeScalesCaptionItem1";
            // 
            // switchCompressWeekendItem1
            // 
            this.switchCompressWeekendItem1.Id = 26;
            this.switchCompressWeekendItem1.Name = "switchCompressWeekendItem1";
            // 
            // switchShowWorkTimeOnlyItem1
            // 
            this.switchShowWorkTimeOnlyItem1.Id = 27;
            this.switchShowWorkTimeOnlyItem1.Name = "switchShowWorkTimeOnlyItem1";
            // 
            // switchCellsAutoHeightItem1
            // 
            this.switchCellsAutoHeightItem1.Id = 28;
            this.switchCellsAutoHeightItem1.Name = "switchCellsAutoHeightItem1";
            // 
            // changeSnapToCellsUIItem1
            // 
            this.changeSnapToCellsUIItem1.Id = 29;
            this.changeSnapToCellsUIItem1.Name = "changeSnapToCellsUIItem1";
            // 
            // editAppointmentQueryItem1
            // 
            this.editAppointmentQueryItem1.Id = 30;
            this.editAppointmentQueryItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.editOccurrenceUICommandItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.editSeriesUICommandItem1)});
            this.editAppointmentQueryItem1.Name = "editAppointmentQueryItem1";
            this.editAppointmentQueryItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // editOccurrenceUICommandItem1
            // 
            this.editOccurrenceUICommandItem1.Id = 31;
            this.editOccurrenceUICommandItem1.Name = "editOccurrenceUICommandItem1";
            // 
            // editSeriesUICommandItem1
            // 
            this.editSeriesUICommandItem1.Id = 32;
            this.editSeriesUICommandItem1.Name = "editSeriesUICommandItem1";
            // 
            // deleteAppointmentsItem1
            // 
            this.deleteAppointmentsItem1.Id = 33;
            this.deleteAppointmentsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteOccurrenceItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteSeriesItem1)});
            this.deleteAppointmentsItem1.Name = "deleteAppointmentsItem1";
            this.deleteAppointmentsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // deleteOccurrenceItem1
            // 
            this.deleteOccurrenceItem1.Id = 34;
            this.deleteOccurrenceItem1.Name = "deleteOccurrenceItem1";
            // 
            // deleteSeriesItem1
            // 
            this.deleteSeriesItem1.Id = 35;
            this.deleteSeriesItem1.Name = "deleteSeriesItem1";
            // 
            // splitAppointmentItem1
            // 
            this.splitAppointmentItem1.Id = 36;
            this.splitAppointmentItem1.Name = "splitAppointmentItem1";
            // 
            // changeAppointmentStatusItem1
            // 
            this.changeAppointmentStatusItem1.Id = 37;
            this.changeAppointmentStatusItem1.Name = "changeAppointmentStatusItem1";
            // 
            // changeAppointmentLabelItem1
            // 
            this.changeAppointmentLabelItem1.Id = 38;
            this.changeAppointmentLabelItem1.Name = "changeAppointmentLabelItem1";
            // 
            // toggleRecurrenceItem1
            // 
            this.toggleRecurrenceItem1.Id = 39;
            this.toggleRecurrenceItem1.Name = "toggleRecurrenceItem1";
            // 
            // changeAppointmentReminderItem1
            // 
            this.changeAppointmentReminderItem1.Edit = this.repositoryItemDuration1;
            this.changeAppointmentReminderItem1.Id = 40;
            this.changeAppointmentReminderItem1.Name = "changeAppointmentReminderItem1";
            // 
            // repositoryItemDuration1
            // 
            this.repositoryItemDuration1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemDuration1.AutoHeight = false;
            this.repositoryItemDuration1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDuration1.DisabledStateText = null;
            this.repositoryItemDuration1.Name = "repositoryItemDuration1";
            this.repositoryItemDuration1.NullValuePromptShowForEmptyValue = true;
            this.repositoryItemDuration1.ShowEmptyItem = true;
            this.repositoryItemDuration1.ValidateOnEnterKey = true;
            // 
            // switchToAgendaViewItem1
            // 
            this.switchToAgendaViewItem1.Id = 41;
            this.switchToAgendaViewItem1.Name = "switchToAgendaViewItem1";
            // 
            // calendarToolsRibbonPageCategory1
            // 
            this.calendarToolsRibbonPageCategory1.Control = this.schedulerControl;
            this.calendarToolsRibbonPageCategory1.Name = "calendarToolsRibbonPageCategory1";
            this.calendarToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.appointmentRibbonPage1});
            this.calendarToolsRibbonPageCategory1.Visible = false;
            // 
            // appointmentRibbonPage1
            // 
            this.appointmentRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.actionsRibbonPageGroup1,
            this.optionsRibbonPageGroup1});
            this.appointmentRibbonPage1.Name = "appointmentRibbonPage1";
            this.appointmentRibbonPage1.Visible = false;
            // 
            // actionsRibbonPageGroup1
            // 
            this.actionsRibbonPageGroup1.ItemLinks.Add(this.editAppointmentQueryItem1);
            this.actionsRibbonPageGroup1.ItemLinks.Add(this.deleteAppointmentsItem1);
            this.actionsRibbonPageGroup1.ItemLinks.Add(this.splitAppointmentItem1);
            this.actionsRibbonPageGroup1.Name = "actionsRibbonPageGroup1";
            // 
            // optionsRibbonPageGroup1
            // 
            this.optionsRibbonPageGroup1.ItemLinks.Add(this.changeAppointmentStatusItem1);
            this.optionsRibbonPageGroup1.ItemLinks.Add(this.changeAppointmentLabelItem1);
            this.optionsRibbonPageGroup1.ItemLinks.Add(this.toggleRecurrenceItem1);
            this.optionsRibbonPageGroup1.ItemLinks.Add(this.changeAppointmentReminderItem1);
            this.optionsRibbonPageGroup1.Name = "optionsRibbonPageGroup1";
            // 
            // fileRibbonPage1
            // 
            this.fileRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.commonRibbonPageGroup1,
            this.printRibbonPageGroup1});
            this.fileRibbonPage1.Name = "fileRibbonPage1";
            // 
            // commonRibbonPageGroup1
            // 
            this.commonRibbonPageGroup1.ItemLinks.Add(this.openScheduleItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.saveScheduleItem1);
            this.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1";
            // 
            // printRibbonPageGroup1
            // 
            this.printRibbonPageGroup1.ItemLinks.Add(this.printPreviewItem1);
            this.printRibbonPageGroup1.ItemLinks.Add(this.printItem1);
            this.printRibbonPageGroup1.ItemLinks.Add(this.printPageSetupItem1);
            this.printRibbonPageGroup1.Name = "printRibbonPageGroup1";
            // 
            // homeRibbonPage1
            // 
            this.homeRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.appointmentRibbonPageGroup1,
            this.navigatorRibbonPageGroup1,
            this.arrangeRibbonPageGroup1});
            this.homeRibbonPage1.Name = "homeRibbonPage1";
            // 
            // appointmentRibbonPageGroup1
            // 
            this.appointmentRibbonPageGroup1.ItemLinks.Add(this.newAppointmentItem1);
            this.appointmentRibbonPageGroup1.ItemLinks.Add(this.newRecurringAppointmentItem1);
            this.appointmentRibbonPageGroup1.Name = "appointmentRibbonPageGroup1";
            // 
            // navigatorRibbonPageGroup1
            // 
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.navigateViewBackwardItem1);
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.navigateViewForwardItem1);
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.gotoTodayItem1);
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.viewZoomInItem1);
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.viewZoomOutItem1);
            this.navigatorRibbonPageGroup1.Name = "navigatorRibbonPageGroup1";
            // 
            // arrangeRibbonPageGroup1
            // 
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToDayViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToWorkWeekViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToWeekViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToFullWeekViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToMonthViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToTimelineViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToGanttViewItem1);
            this.arrangeRibbonPageGroup1.Name = "arrangeRibbonPageGroup1";
            // 
            // viewRibbonPage1
            // 
            this.viewRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.activeViewRibbonPageGroup1,
            this.timeScaleRibbonPageGroup1,
            this.layoutRibbonPageGroup1});
            this.viewRibbonPage1.Name = "viewRibbonPage1";
            // 
            // activeViewRibbonPageGroup1
            // 
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToDayViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToWorkWeekViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToWeekViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToMonthViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToTimelineViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToGanttViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToAgendaViewItem1);
            this.activeViewRibbonPageGroup1.Name = "activeViewRibbonPageGroup1";
            // 
            // timeScaleRibbonPageGroup1
            // 
            this.timeScaleRibbonPageGroup1.ItemLinks.Add(this.switchTimeScalesItem1);
            this.timeScaleRibbonPageGroup1.ItemLinks.Add(this.changeScaleWidthItem1);
            this.timeScaleRibbonPageGroup1.ItemLinks.Add(this.switchTimeScalesCaptionItem1);
            this.timeScaleRibbonPageGroup1.Name = "timeScaleRibbonPageGroup1";
            // 
            // layoutRibbonPageGroup1
            // 
            this.layoutRibbonPageGroup1.ItemLinks.Add(this.switchCompressWeekendItem1);
            this.layoutRibbonPageGroup1.ItemLinks.Add(this.switchShowWorkTimeOnlyItem1);
            this.layoutRibbonPageGroup1.ItemLinks.Add(this.switchCellsAutoHeightItem1);
            this.layoutRibbonPageGroup1.ItemLinks.Add(this.changeSnapToCellsUIItem1);
            this.layoutRibbonPageGroup1.Name = "layoutRibbonPageGroup1";
            // 
            // schedulerBarController1
            // 
            this.schedulerBarController1.BarItems.Add(this.openScheduleItem1);
            this.schedulerBarController1.BarItems.Add(this.saveScheduleItem1);
            this.schedulerBarController1.BarItems.Add(this.printPreviewItem1);
            this.schedulerBarController1.BarItems.Add(this.printItem1);
            this.schedulerBarController1.BarItems.Add(this.printPageSetupItem1);
            this.schedulerBarController1.BarItems.Add(this.newAppointmentItem1);
            this.schedulerBarController1.BarItems.Add(this.newRecurringAppointmentItem1);
            this.schedulerBarController1.BarItems.Add(this.navigateViewBackwardItem1);
            this.schedulerBarController1.BarItems.Add(this.navigateViewForwardItem1);
            this.schedulerBarController1.BarItems.Add(this.gotoTodayItem1);
            this.schedulerBarController1.BarItems.Add(this.viewZoomInItem1);
            this.schedulerBarController1.BarItems.Add(this.viewZoomOutItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToDayViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToWorkWeekViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToWeekViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToFullWeekViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToMonthViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToTimelineViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToGanttViewItem1);
            this.schedulerBarController1.BarItems.Add(this.groupByNoneItem1);
            this.schedulerBarController1.BarItems.Add(this.groupByDateItem1);
            this.schedulerBarController1.BarItems.Add(this.groupByResourceItem1);
            this.schedulerBarController1.BarItems.Add(this.switchTimeScalesItem1);
            this.schedulerBarController1.BarItems.Add(this.changeScaleWidthItem1);
            this.schedulerBarController1.BarItems.Add(this.switchTimeScalesCaptionItem1);
            this.schedulerBarController1.BarItems.Add(this.switchCompressWeekendItem1);
            this.schedulerBarController1.BarItems.Add(this.switchShowWorkTimeOnlyItem1);
            this.schedulerBarController1.BarItems.Add(this.switchCellsAutoHeightItem1);
            this.schedulerBarController1.BarItems.Add(this.changeSnapToCellsUIItem1);
            this.schedulerBarController1.BarItems.Add(this.editAppointmentQueryItem1);
            this.schedulerBarController1.BarItems.Add(this.editOccurrenceUICommandItem1);
            this.schedulerBarController1.BarItems.Add(this.editSeriesUICommandItem1);
            this.schedulerBarController1.BarItems.Add(this.deleteAppointmentsItem1);
            this.schedulerBarController1.BarItems.Add(this.deleteOccurrenceItem1);
            this.schedulerBarController1.BarItems.Add(this.deleteSeriesItem1);
            this.schedulerBarController1.BarItems.Add(this.splitAppointmentItem1);
            this.schedulerBarController1.BarItems.Add(this.changeAppointmentStatusItem1);
            this.schedulerBarController1.BarItems.Add(this.changeAppointmentLabelItem1);
            this.schedulerBarController1.BarItems.Add(this.toggleRecurrenceItem1);
            this.schedulerBarController1.BarItems.Add(this.changeAppointmentReminderItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToAgendaViewItem1);
            this.schedulerBarController1.Control = this.schedulerControl;
            // 
            // navigationPage1
            // 
            this.navigationPage1.BackgroundPadding = new System.Windows.Forms.Padding(0);
            this.navigationPage1.Caption = "Options";
            this.navigationPage1.Controls.Add(this.layoutControl1);
            this.navigationPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage1.ImageOptions.Image")));
            this.navigationPage1.Margin = new System.Windows.Forms.Padding(0);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(260, 468);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chkStatusOrientation);
            this.layoutControl1.Controls.Add(this.chkShowOverAppointment);
            this.layoutControl1.Controls.Add(this.cbTimeMarkerVisibility);
            this.layoutControl1.Controls.Add(this.cbTimeIndicatorVisibility);
            this.layoutControl1.Controls.Add(this.chkAppointmentShadows);
            this.layoutControl1.Controls.Add(this.spinDaysCount);
            this.layoutControl1.Controls.Add(this.cbStatus);
            this.layoutControl1.Controls.Add(this.cbSnapToCellsMode);
            this.layoutControl1.Controls.Add(this.cbAllDayStatus);
            this.layoutControl1.Controls.Add(this.chkShowRightTimeRuler);
            this.layoutControl1.Controls.Add(this.chkShowWorkTimeOnly);
            this.layoutControl1.Controls.Add(this.chkShowAllDayArea);
            this.layoutControl1.Controls.Add(this.chkShowDayHeaders);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(532, 347, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(260, 468);
            this.layoutControl1.TabIndex = 92;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chkStatusOrientation
            // 
            this.chkStatusOrientation.EditValue = true;
            this.chkStatusOrientation.Location = new System.Drawing.Point(13, 259);
            this.chkStatusOrientation.MenuManager = this;
            this.chkStatusOrientation.Name = "chkStatusOrientation";
            this.chkStatusOrientation.Properties.Caption = "Show All-Day Appointment Status Vertically";
            this.chkStatusOrientation.Size = new System.Drawing.Size(234, 19);
            this.chkStatusOrientation.StyleController = this.layoutControl1;
            this.chkStatusOrientation.TabIndex = 92;
            this.chkStatusOrientation.CheckedChanged += new System.EventHandler(this.chkStatusOrientation_CheckedChanged);
            // 
            // chkShowOverAppointment
            // 
            this.chkShowOverAppointment.Location = new System.Drawing.Point(13, 393);
            this.chkShowOverAppointment.MenuManager = this;
            this.chkShowOverAppointment.Name = "chkShowOverAppointment";
            this.chkShowOverAppointment.Properties.Caption = "Show TimeIndicator Over Appointment";
            this.chkShowOverAppointment.Size = new System.Drawing.Size(234, 19);
            this.chkShowOverAppointment.StyleController = this.layoutControl1;
            this.chkShowOverAppointment.TabIndex = 91;
            this.chkShowOverAppointment.CheckedChanged += new System.EventHandler(this.chkShowOverAppointment_CheckedChanged);
            // 
            // cbTimeMarkerVisibility
            // 
            this.cbTimeMarkerVisibility.Location = new System.Drawing.Point(152, 345);
            this.cbTimeMarkerVisibility.MenuManager = this;
            this.cbTimeMarkerVisibility.Name = "cbTimeMarkerVisibility";
            this.cbTimeMarkerVisibility.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTimeMarkerVisibility.Properties.Items.AddRange(new object[] {
            DevExpress.XtraScheduler.TimeMarkerVisibility.Always,
            DevExpress.XtraScheduler.TimeMarkerVisibility.Never,
            DevExpress.XtraScheduler.TimeMarkerVisibility.TodayView});
            this.cbTimeMarkerVisibility.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTimeMarkerVisibility.Size = new System.Drawing.Size(95, 20);
            this.cbTimeMarkerVisibility.StyleController = this.layoutControl1;
            this.cbTimeMarkerVisibility.TabIndex = 4;
            this.cbTimeMarkerVisibility.SelectedIndexChanged += new System.EventHandler(this.cbTimeMarkerVisibility_SelectedIndexChanged);
            // 
            // cbTimeIndicatorVisibility
            // 
            this.cbTimeIndicatorVisibility.Location = new System.Drawing.Point(152, 369);
            this.cbTimeIndicatorVisibility.MenuManager = this;
            this.cbTimeIndicatorVisibility.Name = "cbTimeIndicatorVisibility";
            this.cbTimeIndicatorVisibility.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTimeIndicatorVisibility.Properties.Items.AddRange(new object[] {
            DevExpress.XtraScheduler.TimeIndicatorVisibility.Always,
            DevExpress.XtraScheduler.TimeIndicatorVisibility.Never,
            DevExpress.XtraScheduler.TimeIndicatorVisibility.TodayView,
            DevExpress.XtraScheduler.TimeIndicatorVisibility.CurrentDate});
            this.cbTimeIndicatorVisibility.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTimeIndicatorVisibility.Size = new System.Drawing.Size(95, 20);
            this.cbTimeIndicatorVisibility.StyleController = this.layoutControl1;
            this.cbTimeIndicatorVisibility.TabIndex = 1;
            this.cbTimeIndicatorVisibility.SelectedIndexChanged += new System.EventHandler(this.cbTimeIndicatorVisibility_SelectedIndexChanged);
            // 
            // chkAppointmentShadows
            // 
            this.chkAppointmentShadows.Location = new System.Drawing.Point(13, 282);
            this.chkAppointmentShadows.Name = "chkAppointmentShadows";
            this.chkAppointmentShadows.Properties.Caption = "Appointment Shadows";
            this.chkAppointmentShadows.Size = new System.Drawing.Size(234, 19);
            this.chkAppointmentShadows.StyleController = this.layoutControl1;
            this.chkAppointmentShadows.TabIndex = 2;
            this.chkAppointmentShadows.CheckedChanged += new System.EventHandler(this.chkAppointmentShadows_CheckedChanged);
            // 
            // spinDaysCount
            // 
            this.spinDaysCount.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinDaysCount.Location = new System.Drawing.Point(152, 31);
            this.spinDaysCount.Name = "spinDaysCount";
            this.spinDaysCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinDaysCount.Properties.IsFloatValue = false;
            this.spinDaysCount.Properties.Mask.EditMask = "N00";
            this.spinDaysCount.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinDaysCount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinDaysCount.Size = new System.Drawing.Size(95, 20);
            this.spinDaysCount.StyleController = this.layoutControl1;
            this.spinDaysCount.TabIndex = 1;
            // 
            // cbStatus
            // 
            this.cbStatus.EditValue = "";
            this.cbStatus.Location = new System.Drawing.Point(152, 235);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bounds", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds, -1)});
            this.cbStatus.Size = new System.Drawing.Size(95, 20);
            this.cbStatus.StyleController = this.layoutControl1;
            this.cbStatus.TabIndex = 89;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // cbSnapToCellsMode
            // 
            this.cbSnapToCellsMode.Location = new System.Drawing.Point(152, 187);
            this.cbSnapToCellsMode.Name = "cbSnapToCellsMode";
            this.cbSnapToCellsMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSnapToCellsMode.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Auto", DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Auto, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Always", DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Always, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Never, -1)});
            this.cbSnapToCellsMode.Size = new System.Drawing.Size(95, 20);
            this.cbSnapToCellsMode.StyleController = this.layoutControl1;
            this.cbSnapToCellsMode.TabIndex = 90;
            this.cbSnapToCellsMode.SelectedIndexChanged += new System.EventHandler(this.cbSnapToCellsMode_SelectedIndexChanged);
            // 
            // cbAllDayStatus
            // 
            this.cbAllDayStatus.EditValue = "";
            this.cbAllDayStatus.Location = new System.Drawing.Point(152, 211);
            this.cbAllDayStatus.Name = "cbAllDayStatus";
            this.cbAllDayStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAllDayStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bounds", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds, -1)});
            this.cbAllDayStatus.Size = new System.Drawing.Size(95, 20);
            this.cbAllDayStatus.StyleController = this.layoutControl1;
            this.cbAllDayStatus.TabIndex = 87;
            this.cbAllDayStatus.SelectedIndexChanged += new System.EventHandler(this.cbAllDayStatus_SelectedIndexChanged);
            // 
            // chkShowRightTimeRuler
            // 
            this.chkShowRightTimeRuler.Location = new System.Drawing.Point(13, 124);
            this.chkShowRightTimeRuler.MenuManager = this;
            this.chkShowRightTimeRuler.Name = "chkShowRightTimeRuler";
            this.chkShowRightTimeRuler.Properties.Caption = "TimeRuler On The Right";
            this.chkShowRightTimeRuler.Size = new System.Drawing.Size(234, 19);
            this.chkShowRightTimeRuler.StyleController = this.layoutControl1;
            this.chkShowRightTimeRuler.TabIndex = 5;
            this.chkShowRightTimeRuler.CheckedChanged += new System.EventHandler(this.chkShowRightTimeRuler_CheckedChanged);
            // 
            // chkShowWorkTimeOnly
            // 
            this.chkShowWorkTimeOnly.Location = new System.Drawing.Point(13, 101);
            this.chkShowWorkTimeOnly.Name = "chkShowWorkTimeOnly";
            this.chkShowWorkTimeOnly.Properties.Caption = "Show Work Time Only";
            this.chkShowWorkTimeOnly.Size = new System.Drawing.Size(234, 19);
            this.chkShowWorkTimeOnly.StyleController = this.layoutControl1;
            this.chkShowWorkTimeOnly.TabIndex = 0;
            this.chkShowWorkTimeOnly.CheckedChanged += new System.EventHandler(this.chkShowWorkTimeOnly_CheckedChanged);
            // 
            // chkShowAllDayArea
            // 
            this.chkShowAllDayArea.Location = new System.Drawing.Point(13, 78);
            this.chkShowAllDayArea.Name = "chkShowAllDayArea";
            this.chkShowAllDayArea.Properties.Caption = "Show All Day Area";
            this.chkShowAllDayArea.Size = new System.Drawing.Size(234, 19);
            this.chkShowAllDayArea.StyleController = this.layoutControl1;
            this.chkShowAllDayArea.TabIndex = 1;
            this.chkShowAllDayArea.CheckedChanged += new System.EventHandler(this.chkShowAllDayArea_CheckedChanged);
            // 
            // chkShowDayHeaders
            // 
            this.chkShowDayHeaders.Location = new System.Drawing.Point(13, 55);
            this.chkShowDayHeaders.Name = "chkShowDayHeaders";
            this.chkShowDayHeaders.Properties.Caption = "Show Day Headers";
            this.chkShowDayHeaders.Size = new System.Drawing.Size(234, 19);
            this.chkShowDayHeaders.StyleController = this.layoutControl1;
            this.chkShowDayHeaders.TabIndex = 3;
            this.chkShowDayHeaders.CheckedChanged += new System.EventHandler(this.chkShowDayHeaders_CheckedChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup2,
            this.layoutControlGroup4,
            this.groupCurrentTimeVisualization,
            this.emptySpaceItem5,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(260, 468);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 146);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(250, 10);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup2.Size = new System.Drawing.Size(250, 146);
            this.layoutControlGroup2.Text = "View";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.spinDaysCount;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(238, 24);
            this.layoutControlItem2.Text = "Day Count:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(136, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.chkShowDayHeaders;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(238, 23);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chkShowAllDayArea;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 47);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(238, 23);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chkShowWorkTimeOnly;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 70);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(238, 23);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chkShowRightTimeRuler;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 93);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(238, 23);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem13,
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.layoutControlItem7,
            this.layoutControlItem10});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 156);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup4.Size = new System.Drawing.Size(250, 148);
            this.layoutControlGroup4.Text = "Appointment";
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.cbAllDayStatus;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(238, 24);
            this.layoutControlItem13.Text = "All-Day Appointment Status:";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(136, 13);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.cbSnapToCellsMode;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(238, 24);
            this.layoutControlItem11.Text = "Snap To Cells Mode:";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(136, 13);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.cbStatus;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(238, 24);
            this.layoutControlItem12.Text = "Appointment Status:";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(136, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.chkAppointmentShadows;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 95);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(238, 23);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.chkStatusOrientation;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(238, 23);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // groupCurrentTimeVisualization
            // 
            this.groupCurrentTimeVisualization.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.groupCurrentTimeVisualization.Location = new System.Drawing.Point(0, 314);
            this.groupCurrentTimeVisualization.Name = "groupCurrentTimeVisualization";
            this.groupCurrentTimeVisualization.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.groupCurrentTimeVisualization.Size = new System.Drawing.Size(250, 101);
            this.groupCurrentTimeVisualization.Text = "Current Time Visualization";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbTimeMarkerVisibility;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(238, 24);
            this.layoutControlItem1.Text = "TimeMarker Visibility:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(136, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.cbTimeIndicatorVisibility;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(238, 24);
            this.layoutControlItem8.Text = "TimeIndicator Visibility:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(136, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.chkShowOverAppointment;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(238, 23);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 304);
            this.emptySpaceItem5.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem5.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(250, 10);
            this.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 415);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(250, 43);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right;
            this.navigationPane1.ItemOrientation = System.Windows.Forms.Orientation.Vertical;
            this.navigationPane1.Location = new System.Drawing.Point(775, 141);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.ShowExpandButton = false;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1});
            this.navigationPane1.RegularSize = new System.Drawing.Size(290, 512);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(290, 512);
            this.navigationPane1.TabIndex = 11;
            // 
            // schedulerPanel
            // 
            this.schedulerPanel.Controls.Add(this.schedulerControl);
            this.schedulerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerPanel.Location = new System.Drawing.Point(0, 141);
            this.schedulerPanel.Name = "schedulerPanel";
            this.schedulerPanel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.schedulerPanel.Size = new System.Drawing.Size(775, 512);
            this.schedulerPanel.TabIndex = 13;
            // 
            // DayViewModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.schedulerPanel);
            this.Controls.Add(this.navigationPane1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "DayViewModule";
            this.Size = new System.Drawing.Size(1065, 653);
            this.Load += new System.EventHandler(this.DayViewModule_Load);
            this.VisibleChanged += new System.EventHandler(this.DayViewModule_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDuration1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).EndInit();
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkStatusOrientation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowOverAppointment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimeMarkerVisibility.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimeIndicatorVisibility.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAppointmentShadows.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDaysCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSnapToCellsMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAllDayStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowRightTimeRuler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowWorkTimeOnly.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowAllDayArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowDayHeaders.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCurrentTimeVisualization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.schedulerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraScheduler.SchedulerControl schedulerControl;
		private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage;
		private System.ComponentModel.IContainer components = null;
        private UI.SchedulerBarController schedulerBarController1;
        private XtraBars.Ribbon.RibbonControl ribbonControl1;
        private UI.OpenScheduleItem openScheduleItem1;
        private UI.SaveScheduleItem saveScheduleItem1;
        private UI.PrintPreviewItem printPreviewItem1;
        private UI.PrintItem printItem1;
        private UI.PrintPageSetupItem printPageSetupItem1;
        private UI.NewAppointmentItem newAppointmentItem1;
        private UI.NewRecurringAppointmentItem newRecurringAppointmentItem1;
        private UI.NavigateViewBackwardItem navigateViewBackwardItem1;
        private UI.NavigateViewForwardItem navigateViewForwardItem1;
        private UI.GotoTodayItem gotoTodayItem1;
        private UI.ViewZoomInItem viewZoomInItem1;
        private UI.ViewZoomOutItem viewZoomOutItem1;
        private UI.SwitchToDayViewItem switchToDayViewItem1;
        private UI.SwitchToWorkWeekViewItem switchToWorkWeekViewItem1;
        private UI.SwitchToWeekViewItem switchToWeekViewItem1;
        private UI.SwitchToFullWeekViewItem switchToFullWeekViewItem1;
        private UI.SwitchToMonthViewItem switchToMonthViewItem1;
        private UI.SwitchToTimelineViewItem switchToTimelineViewItem1;
        private UI.SwitchToGanttViewItem switchToGanttViewItem1;
        private UI.GroupByNoneItem groupByNoneItem1;
        private UI.GroupByDateItem groupByDateItem1;
        private UI.GroupByResourceItem groupByResourceItem1;
        private UI.SwitchTimeScalesItem switchTimeScalesItem1;
        private UI.ChangeScaleWidthItem changeScaleWidthItem1;
        private XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private UI.SwitchTimeScalesCaptionItem switchTimeScalesCaptionItem1;
        private UI.SwitchCompressWeekendItem switchCompressWeekendItem1;
        private UI.SwitchShowWorkTimeOnlyItem switchShowWorkTimeOnlyItem1;
        private UI.SwitchCellsAutoHeightItem switchCellsAutoHeightItem1;
        private UI.ChangeSnapToCellsUIItem changeSnapToCellsUIItem1;
        private UI.EditAppointmentQueryItem editAppointmentQueryItem1;
        private UI.EditOccurrenceUICommandItem editOccurrenceUICommandItem1;
        private UI.EditSeriesUICommandItem editSeriesUICommandItem1;
        private UI.DeleteAppointmentsItem deleteAppointmentsItem1;
        private UI.DeleteOccurrenceItem deleteOccurrenceItem1;
        private UI.DeleteSeriesItem deleteSeriesItem1;
        private UI.SplitAppointmentItem splitAppointmentItem1;
        private UI.ChangeAppointmentStatusItem changeAppointmentStatusItem1;
        private UI.ChangeAppointmentLabelItem changeAppointmentLabelItem1;
        private UI.ToggleRecurrenceItem toggleRecurrenceItem1;
        private UI.ChangeAppointmentReminderItem changeAppointmentReminderItem1;
        private UI.RepositoryItemDuration repositoryItemDuration1;
        private UI.CalendarToolsRibbonPageCategory calendarToolsRibbonPageCategory1;
        private UI.AppointmentRibbonPage appointmentRibbonPage1;
        private UI.ActionsRibbonPageGroup actionsRibbonPageGroup1;
        private UI.OptionsRibbonPageGroup optionsRibbonPageGroup1;
        private UI.FileRibbonPage fileRibbonPage1;
        private UI.CommonRibbonPageGroup commonRibbonPageGroup1;
        private UI.PrintRibbonPageGroup printRibbonPageGroup1;
        private UI.HomeRibbonPage homeRibbonPage1;
        private UI.AppointmentRibbonPageGroup appointmentRibbonPageGroup1;
        private UI.NavigatorRibbonPageGroup navigatorRibbonPageGroup1;
        private UI.ArrangeRibbonPageGroup arrangeRibbonPageGroup1;
        private UI.ViewRibbonPage viewRibbonPage1;
        private UI.ActiveViewRibbonPageGroup activeViewRibbonPageGroup1;
        private UI.TimeScaleRibbonPageGroup timeScaleRibbonPageGroup1;
        private UI.LayoutRibbonPageGroup layoutRibbonPageGroup1;
        private UI.SwitchToAgendaViewItem switchToAgendaViewItem1;
        private XtraBars.Navigation.NavigationPage navigationPage1;
        private XtraEditors.CheckEdit chkAppointmentShadows;
        private XtraEditors.SpinEdit spinDaysCount;
        private XtraEditors.ImageComboBoxEdit cbAllDayStatus;
        private XtraEditors.ImageComboBoxEdit cbSnapToCellsMode;
        private XtraEditors.CheckEdit chkShowWorkTimeOnly;
        private XtraEditors.CheckEdit chkShowRightTimeRuler;
        private XtraBars.Navigation.NavigationPane navigationPane1;
        private XtraEditors.CheckEdit chkShowAllDayArea;
        private XtraEditors.CheckEdit chkShowDayHeaders;
        private XtraEditors.ImageComboBoxEdit cbStatus;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraEditors.ComboBoxEdit cbTimeMarkerVisibility;
        private XtraEditors.ComboBoxEdit cbTimeIndicatorVisibility;
        private XtraEditors.CheckEdit chkShowOverAppointment;
        private Panel schedulerPanel;
        private XtraLayout.EmptySpaceItem emptySpaceItem5;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlGroup layoutControlGroup4;
        private XtraLayout.LayoutControlItem layoutControlItem13;
        private XtraLayout.LayoutControlItem layoutControlItem11;
        private XtraLayout.LayoutControlItem layoutControlItem12;
        private XtraLayout.LayoutControlItem layoutControlItem7;
        private XtraLayout.LayoutControlGroup groupCurrentTimeVisualization;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem8;
        private XtraLayout.LayoutControlItem layoutControlItem9;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private XtraEditors.CheckEdit chkStatusOrientation;
        private XtraLayout.LayoutControlItem layoutControlItem10;
    }
}
