using System;
using System.Windows.Forms;

namespace DevExpress.XtraScheduler.Demos {
	partial class TimelineViewModule {
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
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimelineViewModule));
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
            this.chkShowOverAppointment = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chkStatusOrientation = new DevExpress.XtraEditors.CheckEdit();
            this.cbTimeIndicatorVisibility = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnEditScales = new DevExpress.XtraEditors.SimpleButton();
            this.chkSelectionBarVisible = new DevExpress.XtraEditors.CheckEdit();
            this.spinSelectionBarHeight = new DevExpress.XtraEditors.SpinEdit();
            this.trckScaleWidth = new DevExpress.XtraEditors.TrackBarControl();
            this.cbSnapToCellsMode = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.chkAutoHeight = new DevExpress.XtraEditors.CheckEdit();
            this.spinHeight = new DevExpress.XtraEditors.SpinEdit();
            this.cbStatus = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.groupAppointment = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.groupSelectionBar = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.groupTimeScale = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.groupCurrentTimeVisualization = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.schedulerBarController1 = new DevExpress.XtraScheduler.UI.SchedulerBarController();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.schedulerPanel = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDuration1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowOverAppointment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkStatusOrientation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimeIndicatorVisibility.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelectionBarVisible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSelectionBarHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckScaleWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckScaleWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSnapToCellsMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSelectionBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTimeScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCurrentTimeVisualization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerPanel)).BeginInit();
            this.schedulerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // schedulerControl
            // 
            this.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline;
            this.schedulerControl.DataStorage = this.schedulerDataStorage;
            this.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl.OptionsBehavior.UseAsyncMode = Program.OptUseAsyncMode;
            this.schedulerControl.OptionsView.EnableAnimation = false;
            this.schedulerControl.Location = new System.Drawing.Point(2, 2);
            this.schedulerControl.MenuManager = this.ribbonControl1;
            this.schedulerControl.Name = "schedulerControl";
            this.schedulerControl.Size = new System.Drawing.Size(622, 448);
            this.schedulerControl.Start = new System.DateTime(2010, 7, 4, 0, 0, 0, 0);
            this.schedulerControl.TabIndex = 0;
            this.schedulerControl.Text = "schedulerControl1";
            this.schedulerControl.OptionsView.EnableAnimation = false;
            this.schedulerControl.Views.DayView.Enabled = false;
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl.Views.GanttView.Enabled = false;
            this.schedulerControl.Views.MonthView.Enabled = false;
            this.schedulerControl.Views.TimelineView.SelectionBar.Height = 30;
            this.schedulerControl.Views.WeekView.Enabled = false;
            this.schedulerControl.Views.WorkWeekView.Enabled = false;
            this.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
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
            this.ribbonControl1.Size = new System.Drawing.Size(932, 141);
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
            // chkShowOverAppointment
            // 
            this.chkShowOverAppointment.Location = new System.Drawing.Point(13, 415);
            this.chkShowOverAppointment.Name = "chkShowOverAppointment";
            this.chkShowOverAppointment.Properties.Caption = "Show TimeIndicator Over Appointment";
            this.chkShowOverAppointment.Size = new System.Drawing.Size(223, 19);
            this.chkShowOverAppointment.StyleController = this.layoutControl1;
            this.chkShowOverAppointment.TabIndex = 2;
            this.chkShowOverAppointment.CheckedChanged += new System.EventHandler(this.chkShowOverAppointment_CheckedChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chkStatusOrientation);
            this.layoutControl1.Controls.Add(this.chkShowOverAppointment);
            this.layoutControl1.Controls.Add(this.cbTimeIndicatorVisibility);
            this.layoutControl1.Controls.Add(this.btnEditScales);
            this.layoutControl1.Controls.Add(this.chkSelectionBarVisible);
            this.layoutControl1.Controls.Add(this.spinSelectionBarHeight);
            this.layoutControl1.Controls.Add(this.trckScaleWidth);
            this.layoutControl1.Controls.Add(this.cbSnapToCellsMode);
            this.layoutControl1.Controls.Add(this.chkAutoHeight);
            this.layoutControl1.Controls.Add(this.spinHeight);
            this.layoutControl1.Controls.Add(this.cbStatus);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(266, 408);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chkStatusOrientation
            // 
            this.chkStatusOrientation.EditValue = true;
            this.chkStatusOrientation.Location = new System.Drawing.Point(13, 103);
            this.chkStatusOrientation.MenuManager = this;
            this.chkStatusOrientation.Name = "chkStatusOrientation";
            this.chkStatusOrientation.Properties.Caption = "Show Appointment Status Vertically";
            this.chkStatusOrientation.Size = new System.Drawing.Size(223, 19);
            this.chkStatusOrientation.StyleController = this.layoutControl1;
            this.chkStatusOrientation.TabIndex = 83;
            this.chkStatusOrientation.CheckedChanged += new System.EventHandler(this.chkStatusOrientation_CheckedChanged);
            // 
            // cbTimeIndicatorVisibility
            // 
            this.cbTimeIndicatorVisibility.Location = new System.Drawing.Point(125, 391);
            this.cbTimeIndicatorVisibility.Name = "cbTimeIndicatorVisibility";
            this.cbTimeIndicatorVisibility.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTimeIndicatorVisibility.Properties.Items.AddRange(new object[] {
            DevExpress.XtraScheduler.TimeIndicatorVisibility.Always,
            DevExpress.XtraScheduler.TimeIndicatorVisibility.Never,
            DevExpress.XtraScheduler.TimeIndicatorVisibility.TodayView,
            DevExpress.XtraScheduler.TimeIndicatorVisibility.CurrentDate});
            this.cbTimeIndicatorVisibility.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTimeIndicatorVisibility.Size = new System.Drawing.Size(111, 20);
            this.cbTimeIndicatorVisibility.StyleController = this.layoutControl1;
            this.cbTimeIndicatorVisibility.TabIndex = 1;
            this.cbTimeIndicatorVisibility.SelectedIndexChanged += new System.EventHandler(this.cbTimeIndicatorVisibility_SelectedIndexChanged);
            // 
            // btnEditScales
            // 
            this.btnEditScales.ImageOptions.ImageIndex = 2;
            this.btnEditScales.Location = new System.Drawing.Point(13, 325);
            this.btnEditScales.Name = "btnEditScales";
            this.btnEditScales.Size = new System.Drawing.Size(223, 22);
            this.btnEditScales.StyleController = this.layoutControl1;
            this.btnEditScales.TabIndex = 28;
            this.btnEditScales.Text = "Edit Time&Scales...";
            this.btnEditScales.Click += new System.EventHandler(this.btnEditScales_Click);
            // 
            // chkSelectionBarVisible
            // 
            this.chkSelectionBarVisible.Location = new System.Drawing.Point(13, 213);
            this.chkSelectionBarVisible.Name = "chkSelectionBarVisible";
            this.chkSelectionBarVisible.Properties.Caption = "Visible";
            this.chkSelectionBarVisible.Size = new System.Drawing.Size(223, 19);
            this.chkSelectionBarVisible.StyleController = this.layoutControl1;
            this.chkSelectionBarVisible.TabIndex = 68;
            this.chkSelectionBarVisible.CheckedChanged += new System.EventHandler(this.chkSelectionBarVisible_CheckedChanged);
            // 
            // spinSelectionBarHeight
            // 
            this.spinSelectionBarHeight.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSelectionBarHeight.Location = new System.Drawing.Point(125, 189);
            this.spinSelectionBarHeight.Name = "spinSelectionBarHeight";
            this.spinSelectionBarHeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinSelectionBarHeight.Properties.IsFloatValue = false;
            this.spinSelectionBarHeight.Properties.Mask.EditMask = "N00";
            this.spinSelectionBarHeight.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinSelectionBarHeight.Size = new System.Drawing.Size(111, 20);
            this.spinSelectionBarHeight.StyleController = this.layoutControl1;
            this.spinSelectionBarHeight.TabIndex = 69;
            this.spinSelectionBarHeight.EditValueChanged += new System.EventHandler(this.spinSelectionBarHeight_EditValueChanged);
            // 
            // trckScaleWidth
            // 
            this.trckScaleWidth.EditValue = 80;
            this.trckScaleWidth.Location = new System.Drawing.Point(125, 276);
            this.trckScaleWidth.MenuManager = this;
            this.trckScaleWidth.Name = "trckScaleWidth";
            this.trckScaleWidth.Properties.LargeChange = 50;
            this.trckScaleWidth.Properties.Maximum = 200;
            this.trckScaleWidth.Properties.Minimum = 20;
            this.trckScaleWidth.Properties.ShowValueToolTip = true;
            this.trckScaleWidth.Properties.SmallChange = 20;
            this.trckScaleWidth.Properties.TickFrequency = 20;
            this.trckScaleWidth.Size = new System.Drawing.Size(111, 45);
            this.trckScaleWidth.StyleController = this.layoutControl1;
            this.trckScaleWidth.TabIndex = 29;
            this.trckScaleWidth.Value = 80;
            this.trckScaleWidth.EditValueChanged += new System.EventHandler(this.trckScaleWidth_EditValueChanged);
            // 
            // cbSnapToCellsMode
            // 
            this.cbSnapToCellsMode.Location = new System.Drawing.Point(125, 31);
            this.cbSnapToCellsMode.Name = "cbSnapToCellsMode";
            this.cbSnapToCellsMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSnapToCellsMode.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Auto", DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Auto, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Always", DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Always, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Never, -1)});
            this.cbSnapToCellsMode.Size = new System.Drawing.Size(111, 20);
            this.cbSnapToCellsMode.StyleController = this.layoutControl1;
            this.cbSnapToCellsMode.TabIndex = 82;
            this.cbSnapToCellsMode.EditValueChanged += new System.EventHandler(this.cbSnapToCellsMode_EditValueChanged);
            // 
            // chkAutoHeight
            // 
            this.chkAutoHeight.Location = new System.Drawing.Point(13, 126);
            this.chkAutoHeight.Name = "chkAutoHeight";
            this.chkAutoHeight.Properties.Caption = "AutoHeight";
            this.chkAutoHeight.Size = new System.Drawing.Size(223, 19);
            this.chkAutoHeight.StyleController = this.layoutControl1;
            this.chkAutoHeight.TabIndex = 76;
            this.chkAutoHeight.CheckedChanged += new System.EventHandler(this.chkAutoHeight_CheckedChanged);
            // 
            // spinHeight
            // 
            this.spinHeight.EditValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.spinHeight.Location = new System.Drawing.Point(125, 79);
            this.spinHeight.Name = "spinHeight";
            this.spinHeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinHeight.Properties.IsFloatValue = false;
            this.spinHeight.Properties.Mask.EditMask = "N00";
            this.spinHeight.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinHeight.Size = new System.Drawing.Size(111, 20);
            this.spinHeight.StyleController = this.layoutControl1;
            this.spinHeight.TabIndex = 77;
            this.spinHeight.EditValueChanged += new System.EventHandler(this.spinHeight_EditValueChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.EditValue = "";
            this.cbStatus.Location = new System.Drawing.Point(125, 55);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bounds", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds, -1)});
            this.cbStatus.Size = new System.Drawing.Size(111, 20);
            this.cbStatus.StyleController = this.layoutControl1;
            this.cbStatus.TabIndex = 80;
            this.cbStatus.EditValueChanged += new System.EventHandler(this.cbStatus_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.groupAppointment,
            this.emptySpaceItem2,
            this.groupSelectionBar,
            this.emptySpaceItem3,
            this.groupTimeScale,
            this.emptySpaceItem4,
            this.groupCurrentTimeVisualization});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(249, 457);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 148);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(239, 10);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // groupAppointment
            // 
            this.groupAppointment.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem11});
            this.groupAppointment.Location = new System.Drawing.Point(0, 0);
            this.groupAppointment.Name = "groupAppointment";
            this.groupAppointment.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.groupAppointment.Size = new System.Drawing.Size(239, 148);
            this.groupAppointment.Text = "Appointment";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbSnapToCellsMode;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(227, 24);
            this.layoutControlItem2.Text = "Snap To Cells Mode:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbStatus;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(227, 24);
            this.layoutControlItem1.Text = "Status:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.spinHeight;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(227, 24);
            this.layoutControlItem3.Text = "Height:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chkAutoHeight;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 95);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(227, 23);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.chkStatusOrientation;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(227, 23);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 235);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(239, 10);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // groupSelectionBar
            // 
            this.groupSelectionBar.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem5});
            this.groupSelectionBar.Location = new System.Drawing.Point(0, 158);
            this.groupSelectionBar.Name = "groupSelectionBar";
            this.groupSelectionBar.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.groupSelectionBar.Size = new System.Drawing.Size(239, 77);
            this.groupSelectionBar.Text = "Selection Bar";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.chkSelectionBarVisible;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(227, 23);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.spinSelectionBarHeight;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(227, 24);
            this.layoutControlItem5.Text = "Height:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(109, 13);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 350);
            this.emptySpaceItem3.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(239, 10);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // groupTimeScale
            // 
            this.groupTimeScale.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.groupTimeScale.Location = new System.Drawing.Point(0, 245);
            this.groupTimeScale.Name = "groupTimeScale";
            this.groupTimeScale.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.groupTimeScale.Size = new System.Drawing.Size(239, 105);
            this.groupTimeScale.Text = "Time Scale";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.trckScaleWidth;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(227, 49);
            this.layoutControlItem7.Text = "Scale Width:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnEditScales;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 49);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(227, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 437);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(239, 10);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // groupCurrentTimeVisualization
            // 
            this.groupCurrentTimeVisualization.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10,
            this.layoutControlItem9});
            this.groupCurrentTimeVisualization.Location = new System.Drawing.Point(0, 360);
            this.groupCurrentTimeVisualization.Name = "groupCurrentTimeVisualization";
            this.groupCurrentTimeVisualization.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.groupCurrentTimeVisualization.Size = new System.Drawing.Size(239, 77);
            this.groupCurrentTimeVisualization.Text = "Current Time Visualization";
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.chkShowOverAppointment;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(227, 23);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.cbTimeIndicatorVisibility;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(227, 24);
            this.layoutControlItem9.Text = "TimeIndicator Visibility:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(109, 13);
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
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right;
            this.navigationPane1.ItemOrientation = System.Windows.Forms.Orientation.Vertical;
            this.navigationPane1.Location = new System.Drawing.Point(636, 141);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.ShowExpandButton = false;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1});
            this.navigationPane1.RegularSize = new System.Drawing.Size(296, 452);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(296, 452);
            this.navigationPane1.TabIndex = 11;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.BackgroundPadding = new System.Windows.Forms.Padding(0);
            this.navigationPage1.Caption = "Options";
            this.navigationPage1.Controls.Add(this.layoutControl1);
            this.navigationPage1.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage1.Image")));
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(266, 408);
            // 
            // schedulerPanel
            // 
            this.schedulerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.schedulerPanel.Controls.Add(this.schedulerControl);
            this.schedulerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerPanel.Location = new System.Drawing.Point(0, 141);
            this.schedulerPanel.Name = "schedulerPanel";
            this.schedulerPanel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.schedulerPanel.Size = new System.Drawing.Size(636, 452);
            this.schedulerPanel.TabIndex = 12;
            // 
            // TimelineViewModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.schedulerPanel);
            this.Controls.Add(this.navigationPane1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "TimelineViewModule";
            this.Size = new System.Drawing.Size(932, 593);
            this.Load += new System.EventHandler(this.TimelineViewModule_Load);
            this.VisibleChanged += new System.EventHandler(this.TimelineViewModule_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDuration1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowOverAppointment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkStatusOrientation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimeIndicatorVisibility.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelectionBarVisible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSelectionBarHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckScaleWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckScaleWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSnapToCellsMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSelectionBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTimeScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCurrentTimeVisualization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerPanel)).EndInit();
            this.schedulerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraScheduler.SchedulerControl schedulerControl;
		private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage;
		private DevExpress.XtraEditors.SimpleButton btnEditScales;
		private DevExpress.XtraEditors.SpinEdit spinHeight;
		private DevExpress.XtraEditors.CheckEdit chkAutoHeight;
		private DevExpress.XtraEditors.SpinEdit spinSelectionBarHeight;
		private DevExpress.XtraEditors.CheckEdit chkSelectionBarVisible;
		private DevExpress.XtraEditors.ImageComboBoxEdit cbStatus;
		private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraEditors.ImageComboBoxEdit cbSnapToCellsMode;
        private DevExpress.XtraEditors.TrackBarControl trckScaleWidth;
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
        private XtraEditors.CheckEdit chkShowOverAppointment;
        private XtraEditors.ComboBoxEdit cbTimeIndicatorVisibility;
        private UI.SwitchToAgendaViewItem switchToAgendaViewItem1;
        private XtraBars.Navigation.NavigationPane navigationPane1;
        private XtraBars.Navigation.NavigationPage navigationPage1;
        private XtraEditors.PanelControl schedulerPanel;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlGroup groupAppointment;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private XtraLayout.LayoutControlGroup groupSelectionBar;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.EmptySpaceItem emptySpaceItem3;
        private XtraLayout.LayoutControlGroup groupTimeScale;
        private XtraLayout.LayoutControlItem layoutControlItem7;
        private XtraLayout.LayoutControlItem layoutControlItem8;
        private XtraLayout.EmptySpaceItem emptySpaceItem4;
        private XtraLayout.LayoutControlGroup groupCurrentTimeVisualization;
        private XtraLayout.LayoutControlItem layoutControlItem10;
        private XtraLayout.LayoutControlItem layoutControlItem9;
        private XtraEditors.CheckEdit chkStatusOrientation;
        private XtraLayout.LayoutControlItem layoutControlItem11;
    }
}
