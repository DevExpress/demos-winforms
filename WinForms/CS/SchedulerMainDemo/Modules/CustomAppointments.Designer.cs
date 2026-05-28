using System;
using System.Windows.Forms;

namespace DevExpress.XtraScheduler.Demos {
	partial class CustomAppointmentsModule {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomAppointmentsModule));
            this.schedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            this.imcAppointmentIcons = new DevExpress.Utils.ImageCollection(this.components);
            this.schedulerStorage = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
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
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.fileRibbonPage1 = new DevExpress.XtraScheduler.UI.FileRibbonPage();
            this.commonRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.CommonRibbonPageGroup();
            this.printRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.PrintRibbonPageGroup();
            this.homeRibbonPage1 = new DevExpress.XtraScheduler.UI.HomeRibbonPage();
            this.appointmentRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup();
            this.navigatorRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup();
            this.arrangeRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup();
            this.groupByRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup();
            this.viewRibbonPage1 = new DevExpress.XtraScheduler.UI.ViewRibbonPage();
            this.activeViewRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup();
            this.timeScaleRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup();
            this.layoutRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.rgrpAptImages = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chkToolTip = new DevExpress.XtraEditors.CheckEdit();
            this.chkText = new DevExpress.XtraEditors.CheckEdit();
            this.chkShowRecurrence = new DevExpress.XtraEditors.CheckEdit();
            this.chkShowReminder = new DevExpress.XtraEditors.CheckEdit();
            this.cbStatus = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cbTimeDisplayType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.chkEndTimeVisibility = new DevExpress.XtraEditors.CheckEdit();
            this.chkStartTimeVisibility = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.groupDisplayOptions = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupAppointmentImages = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupCustomization = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.schedulerBarController1 = new DevExpress.XtraScheduler.UI.SchedulerBarController(this.components);
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.schedulerPanel = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imcAppointmentIcons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDuration1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgrpAptImages.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkToolTip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowRecurrence.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowReminder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimeDisplayType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEndTimeVisibility.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStartTimeVisibility.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDisplayOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAppointmentImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCustomization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
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
            this.schedulerControl.AppointmentImages = this.imcAppointmentIcons;
            this.schedulerControl.DataStorage = this.schedulerStorage;
            this.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl.MenuManager = this.ribbonControl1;
            this.schedulerControl.Name = "schedulerControl";
            this.schedulerControl.OptionsCustomization.AllowDisplayAppointmentFlyout = false;
            this.schedulerControl.OptionsView.EnableAnimation = false;
            this.schedulerControl.OptionsView.ToolTipVisibility = DevExpress.XtraScheduler.ToolTipVisibility.Always;
            this.schedulerControl.Size = new System.Drawing.Size(510, 402);
            this.schedulerControl.Start = new System.DateTime(2010, 7, 5, 0, 0, 0, 0);
            this.schedulerControl.TabIndex = 0;
            this.schedulerControl.Text = "schedulerControl1";
            this.schedulerControl.ToolTipController = this.toolTipController1;
            this.schedulerControl.Views.DayView.DayCount = 5;
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl.Views.FullWeekView.Enabled = true;
            this.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl.Views.GanttView.Enabled = false;
            this.schedulerControl.Views.WeekView.Enabled = false;
            this.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schedulerControl.Views.YearView.UseOptimizedScrolling = false;
            this.schedulerControl.ActiveViewChanged += new System.EventHandler(this.schedulerControl_ActiveViewChanged);
            this.schedulerControl.InitAppointmentImages += new DevExpress.XtraScheduler.AppointmentImagesEventHandler(this.schedulerControl_InitAppointmentImages);
            this.schedulerControl.InitAppointmentDisplayText += new DevExpress.XtraScheduler.AppointmentDisplayTextEventHandler(this.schedulerControl_InitAppointmentDisplayText);
            // 
            // imcAppointmentIcons
            // 
            this.imcAppointmentIcons.ImageSize = new System.Drawing.Size(15, 15);
            this.imcAppointmentIcons.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imcAppointmentIcons.ImageStream")));
            this.imcAppointmentIcons.Images.SetKeyName(0, "clock-light.png");
            this.imcAppointmentIcons.Images.SetKeyName(1, "clock-dark.png");
            this.imcAppointmentIcons.Images.SetKeyName(2, "refresh1.png");
            this.imcAppointmentIcons.Images.SetKeyName(3, "refresh2.png");
            this.imcAppointmentIcons.Images.SetKeyName(4, "reminder.png");
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
            this.calendarToolsRibbonPageCategory1,
            this.ribbonPageCategory1});
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.fileRibbonPage1,
            this.homeRibbonPage1,
            this.viewRibbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemDuration1});
            this.ribbonControl1.Size = new System.Drawing.Size(704, 150);
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
            this.actionsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.actionsRibbonPageGroup1.ItemLinks.Add(this.editAppointmentQueryItem1);
            this.actionsRibbonPageGroup1.ItemLinks.Add(this.deleteAppointmentsItem1);
            this.actionsRibbonPageGroup1.ItemLinks.Add(this.splitAppointmentItem1);
            this.actionsRibbonPageGroup1.Name = "actionsRibbonPageGroup1";
            // 
            // optionsRibbonPageGroup1
            // 
            this.optionsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.optionsRibbonPageGroup1.ItemLinks.Add(this.changeAppointmentStatusItem1);
            this.optionsRibbonPageGroup1.ItemLinks.Add(this.changeAppointmentLabelItem1);
            this.optionsRibbonPageGroup1.ItemLinks.Add(this.toggleRecurrenceItem1);
            this.optionsRibbonPageGroup1.ItemLinks.Add(this.changeAppointmentReminderItem1);
            this.optionsRibbonPageGroup1.Name = "optionsRibbonPageGroup1";
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
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
            this.commonRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.commonRibbonPageGroup1.ItemLinks.Add(this.openScheduleItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.saveScheduleItem1);
            this.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1";
            // 
            // printRibbonPageGroup1
            // 
            this.printRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
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
            this.arrangeRibbonPageGroup1,
            this.groupByRibbonPageGroup1});
            this.homeRibbonPage1.Name = "homeRibbonPage1";
            // 
            // appointmentRibbonPageGroup1
            // 
            this.appointmentRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.appointmentRibbonPageGroup1.ItemLinks.Add(this.newAppointmentItem1);
            this.appointmentRibbonPageGroup1.ItemLinks.Add(this.newRecurringAppointmentItem1);
            this.appointmentRibbonPageGroup1.Name = "appointmentRibbonPageGroup1";
            // 
            // navigatorRibbonPageGroup1
            // 
            this.navigatorRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.navigateViewBackwardItem1);
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.navigateViewForwardItem1);
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.gotoTodayItem1);
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.viewZoomInItem1);
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.viewZoomOutItem1);
            this.navigatorRibbonPageGroup1.Name = "navigatorRibbonPageGroup1";
            // 
            // arrangeRibbonPageGroup1
            // 
            this.arrangeRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToDayViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToWorkWeekViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToWeekViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToFullWeekViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToMonthViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToTimelineViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToGanttViewItem1);
            this.arrangeRibbonPageGroup1.Name = "arrangeRibbonPageGroup1";
            // 
            // groupByRibbonPageGroup1
            // 
            this.groupByRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.groupByRibbonPageGroup1.ItemLinks.Add(this.groupByNoneItem1);
            this.groupByRibbonPageGroup1.ItemLinks.Add(this.groupByDateItem1);
            this.groupByRibbonPageGroup1.ItemLinks.Add(this.groupByResourceItem1);
            this.groupByRibbonPageGroup1.Name = "groupByRibbonPageGroup1";
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
            this.activeViewRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToDayViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToWorkWeekViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToWeekViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToFullWeekViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToMonthViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToTimelineViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToGanttViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToAgendaViewItem1);
            this.activeViewRibbonPageGroup1.Name = "activeViewRibbonPageGroup1";
            // 
            // timeScaleRibbonPageGroup1
            // 
            this.timeScaleRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.timeScaleRibbonPageGroup1.ItemLinks.Add(this.switchTimeScalesItem1);
            this.timeScaleRibbonPageGroup1.ItemLinks.Add(this.changeScaleWidthItem1);
            this.timeScaleRibbonPageGroup1.ItemLinks.Add(this.switchTimeScalesCaptionItem1);
            this.timeScaleRibbonPageGroup1.Name = "timeScaleRibbonPageGroup1";
            // 
            // layoutRibbonPageGroup1
            // 
            this.layoutRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.layoutRibbonPageGroup1.ItemLinks.Add(this.switchCompressWeekendItem1);
            this.layoutRibbonPageGroup1.ItemLinks.Add(this.switchShowWorkTimeOnlyItem1);
            this.layoutRibbonPageGroup1.ItemLinks.Add(this.switchCellsAutoHeightItem1);
            this.layoutRibbonPageGroup1.ItemLinks.Add(this.changeSnapToCellsUIItem1);
            this.layoutRibbonPageGroup1.Name = "layoutRibbonPageGroup1";
            // 
            // toolTipController1
            // 
            this.toolTipController1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(232)))), ((int)(((byte)(93)))));
            this.toolTipController1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(159)))), ((int)(((byte)(4)))));
            this.toolTipController1.Appearance.Font = new System.Drawing.Font("Verdana", 7.25F);
            this.toolTipController1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.toolTipController1.Appearance.Options.UseBackColor = true;
            this.toolTipController1.Appearance.Options.UseBorderColor = true;
            this.toolTipController1.Appearance.Options.UseFont = true;
            this.toolTipController1.Appearance.Options.UseForeColor = true;
            this.toolTipController1.AppearanceTitle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolTipController1.AppearanceTitle.Options.UseFont = true;
            this.toolTipController1.Rounded = true;
            this.toolTipController1.ShowBeak = true;
            this.toolTipController1.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.toolTipController1_BeforeShow);
            // 
            // rgrpAptImages
            // 
            this.rgrpAptImages.EditValue = 0;
            this.rgrpAptImages.Location = new System.Drawing.Point(13, 211);
            this.rgrpAptImages.MaximumSize = new System.Drawing.Size(0, 90);
            this.rgrpAptImages.Name = "rgrpAptImages";
            this.rgrpAptImages.Properties.Columns = 1;
            this.rgrpAptImages.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Default"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "External"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Custom")});
            this.rgrpAptImages.Size = new System.Drawing.Size(110, 82);
            this.rgrpAptImages.StyleController = this.layoutControl1;
            this.rgrpAptImages.TabIndex = 82;
            this.rgrpAptImages.SelectedIndexChanged += new System.EventHandler(this.rgrpAptImages_SelectedIndexChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chkToolTip);
            this.layoutControl1.Controls.Add(this.chkText);
            this.layoutControl1.Controls.Add(this.rgrpAptImages);
            this.layoutControl1.Controls.Add(this.chkShowRecurrence);
            this.layoutControl1.Controls.Add(this.chkShowReminder);
            this.layoutControl1.Controls.Add(this.cbStatus);
            this.layoutControl1.Controls.Add(this.cbTimeDisplayType);
            this.layoutControl1.Controls.Add(this.chkEndTimeVisibility);
            this.layoutControl1.Controls.Add(this.chkStartTimeVisibility);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(153, 361);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chkToolTip
            // 
            this.chkToolTip.EditValue = true;
            this.chkToolTip.Location = new System.Drawing.Point(19, 336);
            this.chkToolTip.Name = "chkToolTip";
            this.chkToolTip.Properties.Caption = "Custom tooltip";
            this.chkToolTip.Size = new System.Drawing.Size(98, 20);
            this.chkToolTip.StyleController = this.layoutControl1;
            this.chkToolTip.TabIndex = 3;
            this.chkToolTip.CheckedChanged += new System.EventHandler(this.chkToolTip_CheckedChanged);
            // 
            // chkText
            // 
            this.chkText.EditValue = true;
            this.chkText.Location = new System.Drawing.Point(19, 360);
            this.chkText.Name = "chkText";
            this.chkText.Properties.Caption = "Custom text";
            this.chkText.Size = new System.Drawing.Size(98, 20);
            this.chkText.StyleController = this.layoutControl1;
            this.chkText.TabIndex = 2;
            this.chkText.CheckedChanged += new System.EventHandler(this.chkCustomDisplayText_CheckedChanged);
            // 
            // chkShowRecurrence
            // 
            this.chkShowRecurrence.Location = new System.Drawing.Point(13, 130);
            this.chkShowRecurrence.Name = "chkShowRecurrence";
            this.chkShowRecurrence.Properties.Caption = "Recurrence";
            this.chkShowRecurrence.Size = new System.Drawing.Size(110, 20);
            this.chkShowRecurrence.StyleController = this.layoutControl1;
            this.chkShowRecurrence.TabIndex = 74;
            this.chkShowRecurrence.CheckedChanged += new System.EventHandler(this.chkShowRecurrence_CheckedChanged);
            // 
            // chkShowReminder
            // 
            this.chkShowReminder.Location = new System.Drawing.Point(13, 154);
            this.chkShowReminder.Name = "chkShowReminder";
            this.chkShowReminder.Properties.Caption = "Reminder";
            this.chkShowReminder.Size = new System.Drawing.Size(110, 20);
            this.chkShowReminder.StyleController = this.layoutControl1;
            this.chkShowReminder.TabIndex = 13;
            this.chkShowReminder.CheckedChanged += new System.EventHandler(this.chkShowReminder_CheckedChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.EditValue = "";
            this.cbStatus.Location = new System.Drawing.Point(60, 34);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bounds", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds, -1)});
            this.cbStatus.Size = new System.Drawing.Size(63, 20);
            this.cbStatus.StyleController = this.layoutControl1;
            this.cbStatus.TabIndex = 73;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // cbTimeDisplayType
            // 
            this.cbTimeDisplayType.EditValue = "";
            this.cbTimeDisplayType.Location = new System.Drawing.Point(60, 58);
            this.cbTimeDisplayType.Name = "cbTimeDisplayType";
            this.cbTimeDisplayType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTimeDisplayType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Auto", DevExpress.XtraScheduler.AppointmentTimeDisplayType.Auto, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Clock", DevExpress.XtraScheduler.AppointmentTimeDisplayType.Clock, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Text", DevExpress.XtraScheduler.AppointmentTimeDisplayType.Text, -1)});
            this.cbTimeDisplayType.Size = new System.Drawing.Size(63, 20);
            this.cbTimeDisplayType.StyleController = this.layoutControl1;
            this.cbTimeDisplayType.TabIndex = 22;
            this.cbTimeDisplayType.SelectedIndexChanged += new System.EventHandler(this.cbTimeDisplayType_SelectedIndexChanged);
            // 
            // chkEndTimeVisibility
            // 
            this.chkEndTimeVisibility.Location = new System.Drawing.Point(13, 106);
            this.chkEndTimeVisibility.Name = "chkEndTimeVisibility";
            this.chkEndTimeVisibility.Properties.AllowGrayed = true;
            this.chkEndTimeVisibility.Properties.Caption = "End Time";
            this.chkEndTimeVisibility.Size = new System.Drawing.Size(110, 20);
            this.chkEndTimeVisibility.StyleController = this.layoutControl1;
            this.chkEndTimeVisibility.TabIndex = 10;
            this.chkEndTimeVisibility.CheckStateChanged += new System.EventHandler(this.chkEndTimeVisibility_CheckStateChanged);
            // 
            // chkStartTimeVisibility
            // 
            this.chkStartTimeVisibility.Location = new System.Drawing.Point(13, 82);
            this.chkStartTimeVisibility.Name = "chkStartTimeVisibility";
            this.chkStartTimeVisibility.Properties.AllowGrayed = true;
            this.chkStartTimeVisibility.Properties.Caption = "Start Time";
            this.chkStartTimeVisibility.Size = new System.Drawing.Size(110, 20);
            this.chkStartTimeVisibility.StyleController = this.layoutControl1;
            this.chkStartTimeVisibility.TabIndex = 11;
            this.chkStartTimeVisibility.CheckStateChanged += new System.EventHandler(this.chkStartTimeVisibility_CheckStateChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.groupDisplayOptions,
            this.groupAppointmentImages,
            this.groupCustomization});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(136, 409);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 389);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(126, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // groupDisplayOptions
            // 
            this.groupDisplayOptions.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.groupDisplayOptions.Location = new System.Drawing.Point(0, 0);
            this.groupDisplayOptions.Name = "groupDisplayOptions";
            this.groupDisplayOptions.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.groupDisplayOptions.Size = new System.Drawing.Size(126, 177);
            this.groupDisplayOptions.Text = "Display Options";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbTimeDisplayType;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(114, 24);
            this.layoutControlItem2.Text = "Time:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(35, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbStatus;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(114, 24);
            this.layoutControlItem1.Text = "Status:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(35, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chkStartTimeVisibility;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(114, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chkEndTimeVisibility;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(114, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chkShowRecurrence;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(114, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.chkShowReminder;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(114, 24);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // groupAppointmentImages
            // 
            this.groupAppointmentImages.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7});
            this.groupAppointmentImages.Location = new System.Drawing.Point(0, 177);
            this.groupAppointmentImages.Name = "groupAppointmentImages";
            this.groupAppointmentImages.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.groupAppointmentImages.Size = new System.Drawing.Size(126, 119);
            this.groupAppointmentImages.Text = "Appointment images:";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.rgrpAptImages;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(114, 86);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // groupCustomization
            // 
            this.groupCustomization.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.groupCustomization.Location = new System.Drawing.Point(0, 296);
            this.groupCustomization.Name = "groupCustomization";
            this.groupCustomization.Size = new System.Drawing.Size(126, 93);
            this.groupCustomization.Text = "Customization";
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.chkText;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(102, 24);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.chkToolTip;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(102, 24);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
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
            this.navigationPane1.Location = new System.Drawing.Point(520, 150);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.ShowExpandButton = false;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1});
            this.navigationPane1.RegularSize = new System.Drawing.Size(184, 402);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(184, 402);
            this.navigationPane1.TabIndex = 11;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.BackgroundPadding = new System.Windows.Forms.Padding(0);
            this.navigationPage1.Caption = "Options";
            this.navigationPage1.Controls.Add(this.layoutControl1);
            this.navigationPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage1.ImageOptions.Image")));
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(153, 361);
            // 
            // schedulerPanel
            // 
            this.schedulerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.schedulerPanel.Controls.Add(this.schedulerControl);
            this.schedulerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerPanel.Location = new System.Drawing.Point(0, 150);
            this.schedulerPanel.Name = "schedulerPanel";
            this.schedulerPanel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.schedulerPanel.Size = new System.Drawing.Size(520, 402);
            this.schedulerPanel.TabIndex = 13;
            // 
            // CustomAppointmentsModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.schedulerPanel);
            this.Controls.Add(this.navigationPane1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "CustomAppointmentsModule";
            this.Size = new System.Drawing.Size(704, 552);
            this.Load += new System.EventHandler(this.CustomAppointmentsModule_Load);
            this.VisibleChanged += new System.EventHandler(this.CustomAppointmentsModule_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imcAppointmentIcons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDuration1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgrpAptImages.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkToolTip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowRecurrence.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowReminder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimeDisplayType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEndTimeVisibility.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStartTimeVisibility.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDisplayOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAppointmentImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCustomization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
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
		private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage;
		private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraEditors.CheckEdit chkText;
		private DevExpress.XtraEditors.CheckEdit chkToolTip;
		private DevExpress.Utils.ToolTipController toolTipController1;
		private DevExpress.XtraEditors.CheckEdit chkStartTimeVisibility;
		private DevExpress.XtraEditors.CheckEdit chkEndTimeVisibility;
		private DevExpress.XtraEditors.CheckEdit chkShowReminder;
		private DevExpress.XtraEditors.ImageComboBoxEdit cbTimeDisplayType;
		private DevExpress.XtraEditors.ImageComboBoxEdit cbStatus;
		private DevExpress.XtraEditors.CheckEdit chkShowRecurrence;
		private DevExpress.XtraEditors.RadioGroup rgrpAptImages;
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
        private UI.GroupByRibbonPageGroup groupByRibbonPageGroup1;
        private UI.ViewRibbonPage viewRibbonPage1;
        private UI.ActiveViewRibbonPageGroup activeViewRibbonPageGroup1;
        private UI.TimeScaleRibbonPageGroup timeScaleRibbonPageGroup1;
        private UI.LayoutRibbonPageGroup layoutRibbonPageGroup1;
        private UI.SwitchToAgendaViewItem switchToAgendaViewItem1;
        private XtraBars.Navigation.NavigationPane navigationPane1;
        private XtraBars.Navigation.NavigationPage navigationPage1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlGroup groupDisplayOptions;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraLayout.LayoutControlGroup groupAppointmentImages;
        private XtraLayout.LayoutControlItem layoutControlItem7;
        private XtraLayout.LayoutControlItem layoutControlItem8;
        private XtraLayout.LayoutControlItem layoutControlItem9;
        private XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private XtraLayout.LayoutControlGroup groupCustomization;
        private XtraEditors.PanelControl schedulerPanel;
        private DevExpress.Utils.ImageCollection imcAppointmentIcons;
    }
}
