using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using DevExpress.DXperience.Demos;
using DevExpress.XtraSplashScreen;

namespace DevExpress.XtraScheduler.Demos {
    public partial class PerformanceTestModule : TutorialControl {
        const int DAY_COUNT = 100;
        const int MAX_APPOINTMENTS_PER_DAY = 1000;
        BindingList<Record> data50 = null;
        BindingList<Record> data100 = null;
        BindingList<Record> data500 = null;
        BindingList<Record> data1000 = null;

        string[] subjects = {
            "Peter Dolan's meeting",
            "Peter Dolan's phone call",
            "Peter Dolan's travel",
            "Ryan Fischer's meeting",
            "Ryan Fischer's phone call",
            "Ryan Fischer's travel"
        };

        public PerformanceTestModule() {
            InitializeComponent();
            PrepareViews();
            DemoUtils.FillResources(schedulerDataStorage, 2);
        }

        public override SchedulerControl PrintingSchedulerControl {
            get { return schedulerControl; }
        }

        double GetRandomDouble(DevExpress.Data.Utils.NonCryptographicRandom rnd, double min, double max) {
            return min + (max - min) * rnd.NextDouble();
        }

        void PrepareViews() {
            this.schedulerControl.MonthView.Enabled = true;
            this.schedulerControl.TimelineView.Enabled = true;
            this.schedulerControl.GanttView.Enabled = false;
            this.schedulerControl.DayView.Enabled = true;
            this.schedulerControl.WorkWeekView.Enabled = true;
            this.schedulerControl.FullWeekView.Enabled = true;
            this.schedulerControl.AgendaView.Enabled = false;
        }

        void PerformanceTestModule_Load(object sender, EventArgs e) {
            grSwitch.SelectedIndex = 0;
        }

        void UpdateAppointmentStorage() {
            int aptsPerDay = Convert.ToInt32(grSwitch.EditValue);
            switch (aptsPerDay) {
                case 50:
                    if (this.data50 == null)
                        GenerateAppointments(aptsPerDay, out this.data50);
                    schedulerDataStorage.Appointments.DataSource = this.data50;
                    break;
                case 100:
                    if (this.data100 == null)
                        GenerateAppointments(aptsPerDay, out this.data100);
                    schedulerDataStorage.Appointments.DataSource = this.data100;
                    break;
                case 500:
                    if (this.data500 == null)
                        GenerateAppointments(aptsPerDay, out this.data500);
                    schedulerDataStorage.Appointments.DataSource = this.data500;
                    break;
                case 1000:
                    if (this.data1000 == null)
                        GenerateAppointments(aptsPerDay, out this.data1000);
                    schedulerDataStorage.Appointments.DataSource = this.data1000;
                    break;
            }
        }

        void GenerateAppointments(int aptsPerDay, out BindingList<Record> list) {
            DateTime start = TutorialConstants.Today.AddDays(-DAY_COUNT / 2);

            List<Record> appointments = Enumerable.Range(0, DAY_COUNT * aptsPerDay).Select(i => CreateNewRecord(i, aptsPerDay, TutorialConstants.Random, start)).ToList();
            list = new BindingList<Record>(appointments);
        }

        Record CreateNewRecord(int index, int aptsPerDay, DevExpress.Data.Utils.NonCryptographicRandom rnd, DateTime start) {
            int day = index / aptsPerDay;

            Record rec = new Record();
            rec.Id = index + 1;
            rec.StartTime = start.AddDays(day).AddHours(this.GetRandomDouble(rnd, 0, 18));
            rec.EndTime = rec.StartTime.AddHours(this.GetRandomDouble(rnd, 0.5, 6.0));
            int subjectIndex = rnd.Next(0, subjects.Length);
            rec.Subject = this.subjects[subjectIndex];
            rec.Label = rnd.Next(0, 11);
            rec.ResourceId = subjectIndex < 3 ? 1 : 2;
            return rec;
        }

        void PerformanceTestModule_VisibleChanged(object sender, EventArgs e) {
            schedulerControl.ActiveViewType = SchedulerViewType.Day;
            schedulerControl.DayView.DayCount = 1;
            schedulerControl.GroupType = SchedulerGroupType.Resource;
            this.schedulerControl.Start = TutorialConstants.Today;
        }

        void grSwitch_SelectedIndexChanged(object sender, EventArgs e) {
            BeginInvoke(new Action(() => {
                SplashScreenManager.ShowDefaultWaitForm();
                UpdateAppointmentStorage();
                SplashScreenManager.CloseDefaultWaitForm();
            }));
        }
    }

    public class Record {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Label { get; set; }
        public int ResourceId { get; set; }
    }
}

