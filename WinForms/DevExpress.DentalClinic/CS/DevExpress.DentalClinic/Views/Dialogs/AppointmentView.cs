using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.DentalClinic.Model;
using DevExpress.DentalClinic.ViewModel;
using DevExpress.Mvvm;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Calendar;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;

namespace DevExpress.DentalClinic.View {
    public partial class AppointmentView : XtraUserControl, IFreeDateTimeService {
        public AppointmentView() {
            InitializeComponent();
            rgStatus.Properties.Items.AddEnum(typeof(AppointmentStatus));
            if(!mvvmContext1.IsDesignMode)
                InitializeBindings();
            DateDateEdit.DisableCalendarDate += DateDateEdit_DisableCalendarDate;
            ToolTipController.DefaultController.GetActiveObjectInfo += OnGetActiveObjectInfo;
            mvvmContext1.RegisterService((IFreeDateTimeService)this);
        }
        void OnGetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e) {
            if(Appointment.Duration.TotalMinutes <= 2) return;
            if(e.SelectedControl is CalendarControl) {
                CalendarControl c = e.SelectedControl as CalendarControl;
                var hi = c.GetHitInfo(e.ControlMousePosition);
                if(hi.HitTest == CalendarHitInfoType.MonthNumber && !hi.Cell.IsDisabled) {
                    ToolTipControlInfo info = new ToolTipControlInfo(hi.HitDate, "Date");
                    IEnumerable<DateTimeRange> times = Dates.FirstOrDefault(x => x.Key.Date == hi.HitDate.Date);
                    info.SuperTip = new SuperToolTip();
                    if(times == null)
                        times = ScheduleHelper.GetEmptyIntervals(hi.HitDate.Date, Appointment.Duration);
                    foreach(var item in times) {
                        var toolitem = new ToolTipItem();
                        toolitem.Text = string.Format("{0} - {1}", item.Start.ToString("HH:mmm"), item.End.ToString("HH:mmm"));
                        info.SuperTip.Items.Add(toolitem);
                    }
                    e.Info = info;
                }
            }
        }
        void DateDateEdit_DisableCalendarDate(object sender, XtraEditors.Calendar.DisableCalendarDateEventArgs e) {
            if(FreeDays.FirstOrDefault(x => x == e.Date.Date) != DateTime.MinValue || LastAppointmentDay < e.Date.Date)
                e.IsDisabled = false;
            else
                e.IsDisabled = true;
        }
        public Appointment Appointment { get; set; }
        void InitializeBindings() {
            var fluentAPI = mvvmContext1.OfType<AppointmentViewModel>();
            // Data Sources
            fluentAPI.SetBinding(DateDateEdit, x => x.Enabled, x => x.Doctor, x => x != null);
            fluentAPI.SetBinding(teTime, x => x.Enabled, x => x.Doctor, x => x != null);
            fluentAPI.SetBinding(xpBindingSource1, x => x.DataSource, x => x.Appointment);
            fluentAPI.SetBinding(patientInfoBindingSource, x => x.DataSource, x => x.Patients);
            fluentAPI.SetBinding(doctorInfoBindingSource, x => x.DataSource, x => x.Doctors);
            fluentAPI.SetBinding(xpBindingSource2, x => x.DataSource, x => x.Procedures);
            fluentAPI.SetBinding(this, x => x.Appointment, x => x.Appointment);
            // UI elements
            fluentAPI.SetBinding(patientGridLookUpEdit, x => x.EditValue, x => x.PatientInfo);
            fluentAPI.SetBinding(doctorGridLookUpEdit, x => x.EditValue, x => x.DoctorInfo);
            fluentAPI.SetBinding(sbCreate, x => x.Text, x => x.ButtonText);
            fluentAPI.SetBinding(patientGridLookUpEdit, x => x.ReadOnly, x => x.LockChangePatient);
            fluentAPI.SetBinding(headerTextLabel, x => x.Text, x => x.AppointmentHeader);
            fluentAPI.SetBinding(sbCreateInvoice, x => x.Text, x => x.InvoiceText);
            fluentAPI.SetBinding(bindingSource1, x => x.DataSource, x => x.FreeTimes);
            fluentAPI.SetBinding(DateDateEdit, x => x.EditValue, x => x.Date);
            fluentAPI.SetBinding(teTime, x => x.SelectedIndex, x => x.TimeIndex);
            fluentAPI.SetBinding(teTime, x => x.EditValue, x => x.TimeValue);
            // Commands
            fluentAPI.BindCommand(sbCreate, x => x.Save);
            fluentAPI.BindCommand(sbCreateInvoice, x => x.CreateInvoice);

            fluentAPI.SetItemsSourceBinding(teTime.Properties, x => x.Items, x => x.FreeTimes,
                (item, entity) => object.Equals(item.Value, entity.Start),
                entity => new ImageComboBoxItem(entity.Start), null,
                (item, entity) => {
                    ((ImageComboBoxItem)item).Description = string.Format("{0} - {1}", entity.Start.ToString("HH:mmm"), entity.End.ToString("HH:mmm"));
                });

            fluentAPI.WithEvent(this, nameof(this.Load)).EventToCommand(x => x.LoadFreeDays());

            if(fluentAPI.ViewModel.Patient != null) {
                lcgNewPatient.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
                tabbedControlGroup1.Ungroup();
            }
            else {
                fluentAPI.WithEvent<LayoutTabPageChangingEventArgs>(tabbedControlGroup1, nameof(tabbedControlGroup1.SelectedPageChanging))
                    .SetBinding(x => x.ShouldCreateNewPatient, e => e.Page == lcgNewPatient);
                fluentAPI.SetBinding(teNewPatientFirstName, x => x.EditValue, x => x.NewPatientFirstName);
                fluentAPI.SetBinding(teNewPatientLastName, x => x.EditValue, x => x.NewPatientLastName);
                fluentAPI.SetBinding(teNewPatientPhone, x => x.EditValue, x => x.NewPatientPhone);
            }
        }
        void tlProcedures_GetCustomSummaryValue(object sender, XtraTreeList.GetCustomSummaryValueEventArgs e) {
            if(e.Column == colPrice) {
                e.CustomValue = e.Nodes.Sum(n => n.Checked ? (decimal)n.GetValue(1) : 0);
            }
            if(e.Column == colDuration) {
                long ticks = e.Nodes.Sum(n => n.Checked ? ((TimeSpan)n.GetValue(2)).Ticks : 0);
                e.CustomValue = new TimeSpan(ticks);
            }
        }
        void tlProcedures_RowClick(object sender, XtraTreeList.RowClickEventArgs e) {
            if(!e.HitInfo.HitTest.InRowCheckBox) 
                e.Node.Checked = !e.Node.Checked;
        }
        public HashSet<DateTime> FreeDays { get; set; }
        public DateTime LastAppointmentDay { get; set; }
        public HashSet<DateTimeRange> FreeTimes { get; set; }
        public List<IGrouping<DateTime, DateTimeRange>> Dates { get; set; }
    }
}
