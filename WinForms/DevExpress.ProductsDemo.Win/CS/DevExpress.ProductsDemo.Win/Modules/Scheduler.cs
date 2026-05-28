using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraBars.Ribbon;
using DevExpress.MailClient.Win;

namespace DevExpress.ProductsDemo.Win.Modules {
    public partial class SchedulerModule : BaseModule {
        RibbonPageCategory appointmentCategory = null;
        RibbonPage lastSelectedPage = null;
        public SchedulerModule() {
            InitializeComponent();
            DatabindScheduler();
            SetTopRowTime();
        }
        
        protected override bool AutoMergeRibbon { get { return true; } }

        void DatabindScheduler() {
            schedulerStorage1.Resources.DataSource = DataHelper.CalendarResources;
            schedulerStorage1.Appointments.DataSource = DataHelper.CalendarAppointments;
        }
        internal override void InitModule(Utils.Menu.IDXMenuManager manager, object data) {
            base.InitModule(manager, data);
            this.calendarControls.InitDateNavigator(this.schedulerControl1);
            this.calendarControls.InitResourcesTree(this.schedulerStorage1);
        }
        RibbonPageCategory FindAppointmentPage(RibbonControl ribbonControl) {
            foreach (RibbonPageCategory category in ribbonControl.PageCategories)
                if (category.Name == "calendarToolsRibbonPageCategory1")
                    return category;
            return null;
        }
        internal override void ShowModule(bool firstShow) {
            base.ShowModule(firstShow);
            this.appointmentCategory = FindAppointmentPage(this.ribbonControl1);
            SubscribeSchedulerEvents();
            UpdateAppointmentCategory();
            MainRibbon.SelectedPage = MainRibbon.MergedPages.GetPageByName(homeRibbonPage1.Name);
        }
        internal override void HideModule() {
            UnsubscribeSchedulerEvents();
            HideAppointmentCategory();
            base.HideModule();
        }
        private void SubscribeSchedulerEvents() {
            this.schedulerStorage1.FilterAppointment += new PersistentObjectCancelEventHandler(this.schedulerStorage1_FilterAppointment);
            this.schedulerStorage1.AppointmentsDeleted += new PersistentObjectsEventHandler(schedulerStorage1_AppointmentsDeleted);
            this.schedulerStorage1.AppointmentDeleting += new PersistentObjectCancelEventHandler(schedulerStorage1_AppointmentDeleting);
            this.schedulerControl1.SelectionChanged += new EventHandler(schedulerControl1_SelectionChanged);
        }

        void schedulerStorage1_AppointmentDeleting(object sender, PersistentObjectCancelEventArgs e) {
            HideAppointmentCategory();
        }
        private void UnsubscribeSchedulerEvents() {
            this.schedulerStorage1.FilterAppointment -= new PersistentObjectCancelEventHandler(this.schedulerStorage1_FilterAppointment);
            this.schedulerControl1.SelectionChanged -= new EventHandler(schedulerControl1_SelectionChanged);
            this.schedulerStorage1.AppointmentsDeleted -= new PersistentObjectsEventHandler(schedulerStorage1_AppointmentsDeleted);
            this.schedulerControl1.SelectionChanged -= new EventHandler(schedulerControl1_SelectionChanged);
        }
        void schedulerControl1_SelectionChanged(object sender, EventArgs e) {
            if (OwnerForm == null)
                return;
            UpdateAppointmentCategory();
        }
        void UpdateAppointmentCategory() {
            if (this.schedulerControl1.SelectedAppointments.Count > 0)
                ShowAppointmentCategory();
            else
                HideAppointmentCategory();
        }
        private void schedulerStorage1_FilterAppointment(object sender, PersistentObjectCancelEventArgs e) {
            Appointment apt = (Appointment)e.Object;
            if (EmptyResourceId.Id.Equals(apt.ResourceId))
                return;
            List<int> selectedIds = this.calendarControls.GetSelectedResourceIds();
            int resourceId = Convert.ToInt32(apt.ResourceId);
            e.Cancel = !selectedIds.Contains(resourceId);
        }
        void schedulerStorage1_AppointmentsDeleted(object sender, PersistentObjectsEventArgs e) {
            HideAppointmentCategory();
        }
        private void schedulerControl1_InitNewAppointment(object sender, AppointmentEventArgs e) {
            List<int> selectedIds = this.calendarControls.GetSelectedResourceIds();
            if (selectedIds.Count > 0)
                e.Appointment.ResourceId = selectedIds[0];
        }
        void ShowAppointmentCategory() {
            if (this.appointmentCategory == null)
                return;
            if (this.lastSelectedPage == null)
                this.lastSelectedPage = MainRibbon.SelectedPage;
            this.appointmentCategory.Visible = true;
            MainRibbon.SelectedPage = GetFirstVisiblePage(this.appointmentCategory);
        }
        void HideAppointmentCategory() {
            if (this.appointmentCategory == null)
                return;
            this.appointmentCategory.Visible = false;
            if (this.lastSelectedPage != null) {
                MainRibbon.SelectedPage = this.lastSelectedPage;
                this.lastSelectedPage = null;
            }
        }
        RibbonPage GetFirstVisiblePage(RibbonPageCategory ribbonPageCategory) {
            foreach (RibbonPage page in ribbonPageCategory.Pages)
                if (page.Visible)
                    return page;
            return null;
        }
        void SetTopRowTime() {
            this.schedulerControl1.DayView.TopRowTime = TimeSpan.FromHours(8);
        }
    }
}
