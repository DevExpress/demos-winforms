
namespace DevExpress.HTML.Demos
{
    partial class SchedulerControlModule
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulerControlModule));
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.schedulerTemplateCodeViewer1 = new DevExpress.HTML.Demos.SchedulerTemplateCodeViewer();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.Appearance.Appointment.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulerControl1.Appearance.Appointment.Options.UseFont = true;
            this.schedulerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.schedulerControl1.DataStorage = this.schedulerDataStorage1;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.OptionsCustomization.AllowDisplayAppointmentFlyout = false;
            this.schedulerControl1.OptionsCustomization.AllowDisplayAppointmentForm = DevExpress.XtraScheduler.AllowDisplayAppointmentForm.Never;
            this.schedulerControl1.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsView.ResourceHeaders.ResourceHeaderHtmlTemplate.Styles = resources.GetString("schedulerControl1.OptionsView.ResourceHeaders.ResourceHeaderHtmlTemplate.Styles");
            this.schedulerControl1.OptionsView.ResourceHeaders.ResourceHeaderHtmlTemplate.Tag = "Resource header template";
            this.schedulerControl1.OptionsView.ResourceHeaders.ResourceHeaderHtmlTemplate.Template = "<div class=\"root\">\r\n\t<img class=\"image\" src=\'meeting\' />\r\n\t<div class=\"resourceHe" +
    "ader\">${Caption}</div>\r\n\t<div class=\"description\">Meetings for workgroup</div>\r\n" +
    "</div>";
            this.schedulerControl1.Size = new System.Drawing.Size(581, 432);
            this.schedulerControl1.Start = new System.DateTime(2021, 10, 4, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.AgendaView.Enabled = false;
            this.schedulerControl1.Views.DayView.AppointmentDisplayOptions.StatusDisplayType = DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never;
            this.schedulerControl1.Views.DayView.HtmlTemplates.Appointment.Styles = resources.GetString("schedulerControl1.Views.DayView.HtmlTemplates.Appointment.Styles");
            this.schedulerControl1.Views.DayView.HtmlTemplates.Appointment.Tag = "Appointment Template";
            this.schedulerControl1.Views.DayView.HtmlTemplates.Appointment.Template = resources.GetString("schedulerControl1.Views.DayView.HtmlTemplates.Appointment.Template");
            this.schedulerControl1.Views.DayView.ShowWorkTimeOnly = true;
            this.schedulerControl1.Views.DayView.TimeIndicatorDisplayOptions.Visibility = DevExpress.XtraScheduler.TimeIndicatorVisibility.Never;
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.DayView.WorkTime = new DevExpress.XtraScheduler.WorkTimeInterval(System.TimeSpan.Parse("08:00:00"), System.TimeSpan.Parse("18:00:00"));
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.Views.GanttView.Enabled = false;
            this.schedulerControl1.Views.MonthView.Enabled = false;
            this.schedulerControl1.Views.TimelineView.Enabled = false;
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schedulerControl1.Views.YearView.UseOptimizedScrolling = false;
            this.schedulerControl1.AppointmentHtmlElementMouseClick += new DevExpress.XtraScheduler.AppointmentHtmlElementMouseClickHandler(this.schedulerControl1_AppointmentHtmlElementMouseClick);
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
            this.schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            // 
            // 
            // 
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))));
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.schedulerTemplateCodeViewer1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(581, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(400, 432);
            this.sidePanel1.TabIndex = 2;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // schedulerTemplateCodeViewer1
            // 
            this.schedulerTemplateCodeViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerTemplateCodeViewer1.Location = new System.Drawing.Point(1, 0);
            this.schedulerTemplateCodeViewer1.Margin = new System.Windows.Forms.Padding(6);
            this.schedulerTemplateCodeViewer1.Name = "schedulerTemplateCodeViewer1";
            this.schedulerTemplateCodeViewer1.Size = new System.Drawing.Size(399, 432);
            this.schedulerTemplateCodeViewer1.TabIndex = 1;
            // 
            // SchedulerControlModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.schedulerControl1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "SchedulerControlModule";
            this.Size = new System.Drawing.Size(981, 432);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XtraScheduler.SchedulerControl schedulerControl1;
        private XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private SchedulerTemplateCodeViewer schedulerTemplateCodeViewer1;
        private XtraEditors.SidePanel sidePanel1;
    }
}
