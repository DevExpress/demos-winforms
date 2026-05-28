using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler.Demos.DemoData;
using DevExpress.XtraScheduler.Native;

namespace DevExpress.XtraScheduler.Demos
{

    public partial class DayViewModule : TutorialControl
    {
        const string AppointmentCss = @"
.subject {
    font-size: 1em;
    font-weight: bold;
}
.description {
    font-size: 1em;
}
.location {
    font-weight: bold;
}
";

        const string AppointmentTemplate = @"
            <div class=""subject"">${Appointment.Subject}</div>
            <p class=""description"">${Appointment.Description}</p>
            <p class=""location"">${Appointment.Location}</p >
";

        public DayViewModule()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            SvgImage svgImage = DemoUtils.GetResourceSvgImage("Images.Private.svg");
            SvgImageCollection svgImages = new SvgImageCollection();
            svgImages.Add("locked", svgImage);
            this.schedulerControl.HtmlImages = svgImages;
            //this.schedulerControl.CustomAppointmentHtmlText += OnSchedulerControlCustomAppointmentHtmlText;
        }


        public override SchedulerControl Scheduler { get { return this.schedulerControl; } }
        public override CommonRibbon CommonRibbonPanel { get { return this.commonRibbon1; } }
        protected override Control OptionsPane { get { return this.spOptionPane; } }

        public override void ResetOptions()
        {
            base.ResetOptions();
            Scheduler.BeginUpdate();
            try
            {
                this.chkShowRightTimeRuler.Checked = true;
                this.chkShowWorkTimeOnly.Checked = true;
                this.chkShowAllDayArea.Checked = true;
                this.chkShowDayHeaders.Checked = true;
                this.chkShowOverAppointment.Checked = true;
                this.chkStatusOrientation.Checked = true;
                this.chkAllowHtmlText.Checked = true;
                this.spinDaysCount.EditValue = 3;
                this.chkColorizeResources.Checked = true;

                this.cbAllDayStatus.EditValue = AppointmentStatusDisplayType.Bounds;
                this.cbStatus.EditValue = AppointmentStatusDisplayType.Bounds;
                this.cbSnapToCellsMode.EditValue = AppointmentSnapToCellsMode.Auto;
                this.cbColumnWidthMode.EditValue = ColumnWidthMode.Auto;
                this.chkCustomGroup.Checked = true;
                this.cbTimeIndicatorVisibility.EditValue = TimeIndicatorVisibility.DaysBeforeToday;
                this.cbTimeMarkerVisibility.EditValue = TimeMarkerVisibility.TodayView;
                this.cbTimeMarkerStyle.EditValue = TimeMarkerStyle.Default;
            }
            finally
            {
                Scheduler.EndUpdate();
            }
        }

        internal override void UpdateOptionsFromControl()
        {
            base.UpdateOptionsFromControl();
            Scheduler.BeginUpdate();
            try
            {
                this.spinDaysCount.EditValue = this.schedulerControl.DayView.DayCount;
                this.cbSnapToCellsMode.EditValue = Scheduler.DayView.AppointmentDisplayOptions.SnapToCellsMode;
                this.cbColumnWidthMode.EditValue = Scheduler.DayView.ColumnWidthMode;
                this.cbAllDayStatus.EditValue = Scheduler.DayView.AppointmentDisplayOptions.AllDayAppointmentsStatusDisplayType;
                this.cbStatus.EditValue = Scheduler.DayView.AppointmentDisplayOptions.AllDayAppointmentsStatusDisplayType;
                this.chkStatusOrientation.Checked = Scheduler.DayView.AppointmentDisplayOptions.ShowAllDayAppointmentStatusVertically;
                this.cbTimeMarkerVisibility.EditValue = Scheduler.DayView.TimeMarkerVisibility;
                this.cbTimeMarkerStyle.EditValue = Scheduler.DayView.TimeMarkerStyle;
                this.cbTimeIndicatorVisibility.EditValue = Scheduler.DayView.TimeIndicatorDisplayOptions.Visibility;
                this.chkShowOverAppointment.Checked = Scheduler.DayView.TimeIndicatorDisplayOptions.ShowOverAppointment;
                this.chkShowDayHeaders.Checked = Scheduler.DayView.ShowDayHeaders;
                this.chkShowAllDayArea.Checked = Scheduler.DayView.ShowAllDayArea;
                this.chkShowWorkTimeOnly.Checked = Scheduler.DayView.ShowWorkTimeOnly;
                this.chkAllowHtmlText.Checked = Scheduler.DayView.HtmlTemplates.Appointment.Template != null;
                int timeRulersCount = this.schedulerControl.DayView.TimeRulers.Count;
                bool shouldShowRightRuler = false;
                for (int i = 0; i < timeRulersCount; i++)
                {
                    TimeRuler timeRuler = this.schedulerControl.DayView.TimeRulers[i];
                    if (timeRuler.HorizontalAlignment == TimeRulerHorizontalAlignment.Far && timeRuler.Visible)
                    {
                        shouldShowRightRuler = true;
                        break;
                    }
                }
                this.chkShowRightTimeRuler.Checked = shouldShowRightRuler;
            }
            finally
            {
                Scheduler.EndUpdate();
            }
        }

        protected override IEnumerable<string> GetGlobalOptionIgnoreList()
        {
            return new string[] {
                "AppointmentStatusDisplayType",
                "AppointmentStatusDisplayType",
                "ShowAllDayAppointmentStatusVertically",
                "TimeMarkerVisibility",
                "ShowTimeIndicatorOverAppointment",
                "ShowDayHeaders",
                "ShowAllDayArea",
                "ShowRightTimeRuler",
            };
        }
        void OnDayViewModuleLoad(object sender, EventArgs e)
        {
            HideUnusedViews();
            UpdateRulers(true);
            Scheduler.Start = SchedulerDataHelper.Start.AddDays(-1);
            Scheduler.DayView.TopRowTime = TimeSpan.FromHours(8);
            SchedulerDataHelper.Attach(Scheduler);
            TimeRegionHelper.Attach(Scheduler);
            SetOfficeUI(this.schedulerControl);
            ResetOptions();
        }

        void SetOfficeUI(SchedulerControl scheduler)
        {
            scheduler.DayView.ShowMoreButtonsOnEachColumn = true;
            scheduler.DayView.ShowNumbersInMoreButtons = true;
            scheduler.DayView.ShowDayNumberInAllDayArea = DevExpress.Utils.DefaultBoolean.True;
        }

        void spinDaysCount_EditValueChanged(object sender, EventArgs e)
        {
            this.schedulerControl.DayView.DayCount = Convert.ToInt32(this.spinDaysCount.EditValue);
        }

        void cbSnapToCellsMode_EditValueChanged(object sender, EventArgs e)
        {
            Scheduler.DayView.AppointmentDisplayOptions.SnapToCellsMode = (AppointmentSnapToCellsMode)this.cbSnapToCellsMode.EditValue;
        }
        void cbColumnWidthMode_EditValueChanged(object sender, EventArgs e)
        {
            Scheduler.DayView.ColumnWidthMode = (ColumnWidthMode)this.cbColumnWidthMode.EditValue;
        }
        void cbAllDayStatus_EditValueChanged(object sender, EventArgs e)
        {
            Scheduler.DayView.AppointmentDisplayOptions.AllDayAppointmentsStatusDisplayType = (AppointmentStatusDisplayType)this.cbAllDayStatus.EditValue;
        }

        void cbStatus_EditValueChanged(object sender, EventArgs e)
        {
            Scheduler.DayView.AppointmentDisplayOptions.StatusDisplayType = (AppointmentStatusDisplayType)this.cbStatus.EditValue;
        }

        void chkStatusOrientation_CheckedChanged(object sender, EventArgs e)
        {
            Scheduler.DayView.AppointmentDisplayOptions.ShowAllDayAppointmentStatusVertically = this.chkStatusOrientation.Checked;
        }

        void cbTimeMarkerVisibility_EditValueChanged(object sender, EventArgs e)
        {
            Scheduler.DayView.TimeMarkerVisibility = (TimeMarkerVisibility)this.cbTimeMarkerVisibility.EditValue;
        }
        void cbTimeMarkerStyle_EditValueChanged(object sender, EventArgs e)
        {
            Scheduler.DayView.TimeMarkerStyle = (TimeMarkerStyle)this.cbTimeMarkerStyle.EditValue;
        }
        void cbTimeIndicatorVisibility_EditValueChanged(object sender, EventArgs e)
        {
            Scheduler.DayView.TimeIndicatorDisplayOptions.Visibility = (TimeIndicatorVisibility)this.cbTimeIndicatorVisibility.EditValue;
        }

        void chkShowOverAppointment_CheckedChanged(object sender, EventArgs e)
        {
            Scheduler.DayView.TimeIndicatorDisplayOptions.ShowOverAppointment = this.chkShowOverAppointment.Checked;
        }

        void chkShowDayHeaders_CheckedChanged(object sender, EventArgs e)
        {
            Scheduler.DayView.ShowDayHeaders = this.chkShowDayHeaders.Checked;
        }

        void chkShowAllDayArea_CheckedChanged(object sender, EventArgs e)
        {
            Scheduler.DayView.ShowAllDayArea = this.chkShowAllDayArea.Checked;
        }

        void chkShowWorkTimeOnly_CheckedChanged(object sender, EventArgs e)
        {
            Scheduler.DayView.ShowWorkTimeOnly = this.chkShowWorkTimeOnly.Checked;
        }

        void chkShowRightTimeRuler_CheckedChanged(object sender, EventArgs e)
        {
            bool shouldShowRightRuler = this.chkShowRightTimeRuler.Checked;
            UpdateRulers(shouldShowRightRuler);
        }

        void UpdateRulers(bool shouldShowRightRuler)
        {
            int timeRulersCount = this.schedulerControl.DayView.TimeRulers.Count;
            for (int i = 0; i < timeRulersCount; i++)
            {
                TimeRuler timeRuler = this.schedulerControl.DayView.TimeRulers[i];
                if (timeRuler.HorizontalAlignment == TimeRulerHorizontalAlignment.Far)
                    timeRuler.Visible = shouldShowRightRuler;
            }
        }

        void OnSchedulerControlPopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.Menu.Id == SchedulerMenuItemId.DefaultMenu || e.Menu.Id == SchedulerMenuItemId.RulerMenu)
            {
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu);
            }
        }

        void OnDayViewModuleVisibleChanged(object sender, EventArgs e)
        {
            this.schedulerControl.ActiveViewType = SchedulerViewType.Day;
        }

        void HideUnusedViews()
        {
            this.schedulerControl.WorkWeekView.Enabled = false;
            this.schedulerControl.WeekView.Enabled = false;
            this.schedulerControl.MonthView.Enabled = false;
            this.schedulerControl.TimelineView.Enabled = false;
            this.schedulerControl.AgendaView.Enabled = false;
            this.schedulerControl.YearView.Enabled = false;
        }

        void OnSchedulerControlVisibleIntervalChanged(object sender, EventArgs e)
        {
            this.spinDaysCount.EditValue = Scheduler.DayView.DayCount;
        }

        void OnChkCustomGroupCheckedChanged(object sender, EventArgs e)
        {
            if (this.chkCustomGroup.Checked)
                Scheduler.CustomAppointmentGroup += CustomAppointmentGroup;
            else
                Scheduler.CustomAppointmentGroup -= CustomAppointmentGroup;
            Scheduler.Refresh();
        }

        void CustomAppointmentGroup(object sender, CustomAppointmentGroupEventArgs e)
        {
            e.GroupKey = (int)e.AppointmentLayoutInfo.Appointment.LabelKey;
        }

        void OnChkAllowHtmlTextCheckedChanged(object sender, EventArgs e)
        {
            if (this.chkAllowHtmlText.Checked)
            {
                this.schedulerControl.DayView.HtmlTemplates.Appointment.Template = AppointmentTemplate;
                this.schedulerControl.DayView.HtmlTemplates.Appointment.Styles = AppointmentCss;
            }
            else
            {
                this.schedulerControl.DayView.HtmlTemplates.Appointment.Template = String.Empty;
                this.schedulerControl.DayView.HtmlTemplates.Appointment.Styles = String.Empty;
            }
        }

        void OnChkColorizeResourcesCheckedChanged(object sender, EventArgs e)
        {
            Scheduler.BeginUpdate();
            try
            {
                if (Scheduler.GroupType == SchedulerGroupType.None)
                    Scheduler.GroupType = SchedulerGroupType.Resource;
                Scheduler.OptionsView.ColorizeResources = this.chkColorizeResources.Checked;
            }
            finally
            {
                Scheduler.EndUpdate();
            }
        }
    }
}
