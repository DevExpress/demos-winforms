using DevExpress.DevAV;
using DevExpress.DXperience.Demos;
using DevExpress.HTML.Demos.Helpers;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.HTML.Demos {
    public partial class SchedulerControlModule : TutorialControlBase {
        public SchedulerControlModule() {
            InitializeComponent();
            this.schedulerControl1.Start = TutorialConstants.Today;
            SchedulerData schedulerData = new SchedulerData();
            schedulerData.AttachToScheduler(this.schedulerControl1);
            LoadImages(schedulerData.Employees);
            this.schedulerTemplateCodeViewer1.Fill(this.schedulerControl1);
            this.schedulerControl1.GroupType = SchedulerGroupType.Resource;
        }
        void LoadImages(Dictionary<string, Employee> employees) {
            SvgImageCollection imageCollection = new SvgImageCollection();
            imageCollection.ImageSize = new Size(32, 32);
            imageCollection.Add("location", global::DevExpress.HTML.Demos.Properties.Resources.customerquicklocations);
            imageCollection.Add("meeting", global::DevExpress.HTML.Demos.Properties.Resources.meeting);
            this.schedulerControl1.HtmlImages = imageCollection;
        }
        private void schedulerControl1_AppointmentHtmlElementMouseClick(object sender, AppointmentHtmlElementMouseEventArgs e) {
            if(e.Element.ClassName.Contains("btn")) {
                if(e.Appointment.CustomFields["Employee"] != null)
                    XtraMessageBox.Show(e.Appointment.CustomFields["Employee"].ToString(), "Employee info");
            }
        }
    }
}
