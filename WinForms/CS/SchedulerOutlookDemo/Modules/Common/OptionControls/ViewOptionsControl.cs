using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevExpress.XtraScheduler.Demos {
    public partial class ViewOptionsControl : UserControl {
        public ViewOptionsControl() {
            InitializeComponent();
            this.cbTimeMarkerVisibility.Properties.Items.Add(TimeMarkerVisibility.Always);
            this.cbTimeMarkerVisibility.Properties.Items.Add(TimeMarkerVisibility.Never);
            this.cbTimeMarkerVisibility.Properties.Items.Add(TimeMarkerVisibility.TodayView);
        }
        public void LoadOptions(CommonOptions options) {
            this.chkShowDayHeaders.Checked = options.ShowDayHeaders;
            this.chkShowAllDayArea.Checked = options.ShowAllDayArea;
            this.cbTimeMarkerVisibility.EditValue = options.TimeMarkerVisibility;
            this.chkShowAllDayAppointmentStatusVertically.Checked = options.ShowAllDayAppointmentStatusVertically;
            this.chkShowRightTimeRuler.Checked = options.ShowRightTimeRuler;
            this.chkShowWeekend.Checked = options.ShowWeekEnd;
            this.chkCompressWeekEnd.Checked = options.CompressWeekEnd;
            this.chkShowAppointmentStatusVertically.Checked = options.ShowAppointmentStatusVertically;
            this.chkEndTimeVisibility.Checked = options.ShowEndTime;
            this.chkStartTimeVisibility.Checked = options.ShowStartTime;
            this.chkShowTimeIndicatorOverAppointment.Checked = options.ShowTimeIndicatorOverAppointment;
            this.chkShowTimeForDayViewAppointment.Checked = options.ShowTimeForDayView;
        }
        public void SaveOptions(CommonOptions options) {
            options.ShowDayHeaders = this.chkShowDayHeaders.Checked;
            options.ShowAllDayArea = this.chkShowAllDayArea.Checked;
            options.TimeMarkerVisibility = (TimeMarkerVisibility)this.cbTimeMarkerVisibility.EditValue;
            options.ShowAllDayAppointmentStatusVertically = this.chkShowAllDayAppointmentStatusVertically.Checked;
            options.ShowRightTimeRuler = this.chkShowRightTimeRuler.Checked;
            options.ShowWeekEnd = this.chkShowWeekend.Checked;
            options.CompressWeekEnd = this.chkCompressWeekEnd.Checked;
            options.ShowAppointmentStatusVertically = this.chkShowAppointmentStatusVertically.Checked;
            options.ShowEndTime = this.chkEndTimeVisibility.Checked;
            options.ShowStartTime = this.chkStartTimeVisibility.Checked;
            options.ShowTimeIndicatorOverAppointment = this.chkShowTimeIndicatorOverAppointment.Checked;
            options.ShowTimeForDayView = this.chkShowTimeForDayViewAppointment.Checked;
        }
    }
}
