using System;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.Utils.Controls;
using DevExpress.XtraScheduler.Drawing;

namespace DevExpress.XtraScheduler.Demos {
    public partial class AppointmentFilteringModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        ImageCollection sportsImages;
        ImageCollection channelsImages;

        public AppointmentFilteringModule() {
            this.sportsImages = ImageHelper.CreateImageCollectionFromResources(DemoUtils.FindResourceName("Images.sports.png"), System.Reflection.Assembly.GetExecutingAssembly(), new Size(16, 16));
            this.channelsImages = ImageHelper.CreateImageCollectionFromResources(DemoUtils.FindResourceName("Images.channels.png"), System.Reflection.Assembly.GetExecutingAssembly(), new Size(60, 40));
            InitializeComponent();
        }
        public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }

        private void ResourceSharingModule_Load(object sender, System.EventArgs e) {
            schedulerControl.GroupType = SchedulerGroupType.Resource;
            FillFilterComboBox();
            AddSportChanels();
            FillData();
        }
        void AddAppointmentLabel(object id, string displayName, string menuCaption, Color color) {
            IAppointmentLabel label = this.schedulerStorage.Appointments.Labels.CreateNewLabel(id, displayName, menuCaption);
            label.SetColor(color);
            this.schedulerStorage.Appointments.Labels.Add(label);
        }
        void FillData() {
            schedulerStorage.EnableReminders = false;
            this.schedulerStorage.Appointments.Mappings.End = "Finish";
            this.schedulerStorage.Appointments.Mappings.Label = "SportID";
            this.schedulerStorage.Appointments.Mappings.ResourceId = "ResourceID";
            this.schedulerStorage.Appointments.Mappings.Start = "Start";
            this.schedulerStorage.Appointments.Mappings.Subject = "Caption";
            this.schedulerStorage.Appointments.Mappings.AllDay = "AllDay";

            schedulerStorage.Appointments.DataSource = DemoUtils.GetSportEventsData();
            schedulerControl.Start = new DateTime(2016, 09, 15, 9, 0, 0);
        }
        void AddSportChanels() {
            schedulerStorage.BeginUpdate();
            AddResource(0, "SPORT TV 1");
            AddResource(1, "SPORT TV 2");
            AddResource(2, "SPORT TV 3");
            AddResource(3, "SPORT TV 4");
            AddResource(4, "TV 5");
            AddResource(5, "TV 6");
            AddResource(6, "TV 7");
            AddResource(7, "TV 8");
            schedulerStorage.EndUpdate();
        }
        void AddResource(int index, string caption) {
            Resource r = schedulerStorage.CreateResource(index.ToString());
            r.Caption = caption;
            r.SetImage(this.channelsImages.Images[index]);
            r.SetColor(schedulerControl.ResourceColorSchemas.GetSchema(index).CellLight);
            schedulerStorage.Resources.Add(r);
        }
        void FillFilterComboBox() {
            this.imcbSports.Properties.SmallImages = this.sportsImages;
            this.imcbSports.Properties.LargeImages = this.sportsImages;
            this.imcbSports.Properties.Items.Clear();
            this.imcbSports.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("All sports", -1, -1));
            for (int i = 0; i < schedulerStorage.Appointments.Labels.Count; i++) {
                IAppointmentLabel lab = schedulerStorage.Appointments.Labels.GetByIndex(i);
                this.imcbSports.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(lab.DisplayName, i, i));
            }
            this.imcbSports.SelectedIndex = 0;
        }
        void cbView_SelectedIndexChanged(object sender, System.EventArgs e) {
            schedulerControl.BeginUpdate();
            try {
                AdjustResourceHeaders();
            }
            finally {
                schedulerControl.EndUpdate();
            }
        }
        void schedulerControl_ActiveViewChanged(object sender, System.EventArgs e) {
        }
        void cbGrouping_SelectedIndexChanged(object sender, EventArgs e) {
            schedulerControl.BeginUpdate();
            try {
                AdjustResourceHeaders();
            }
            finally {
                schedulerControl.EndUpdate();
            }
        }
        void AdjustResourceHeaders() {
            int headerHeight = 0;
            SchedulerGroupType groupType = schedulerControl.GroupType;
            if ((schedulerControl.ActiveView is WeekView && groupType.Equals(SchedulerGroupType.Date)) || (schedulerControl.ActiveView is TimelineView && !groupType.Equals(SchedulerGroupType.None)))
                headerHeight = 90;

            schedulerControl.OptionsView.ResourceHeaders.Height = headerHeight;
        }
        void schedulerStorage_FilterAppointment(object sender, PersistentObjectCancelEventArgs e) {
            int sportId = Convert.ToInt32(this.imcbSports.EditValue);
            if (sportId < 0)
                return;

            Appointment apt = (Appointment)e.Object;
            e.Cancel = Convert.ToInt32(apt.LabelKey) != sportId;
        }

        void imcbSports_SelectedIndexChanged(object sender, EventArgs e) {
            schedulerStorage.RefreshData();
        }

        void schedulerControl_InitAppointmentImages(object sender, AppointmentImagesEventArgs e) {
            AppointmentImageInfo info = new AppointmentImageInfo();
            info.Image = this.sportsImages.Images[Convert.ToInt32(e.Appointment.LabelKey)];
            e.ImageInfoList.Add(info);
        }
    }
}
