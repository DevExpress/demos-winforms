using System;
using System.Collections;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Reporting;
using System.Collections.Generic;

namespace DevExpress.XtraScheduler.Demos.Reporting.DataValidation {

	public class PreviewControl : SingleReportPreviewControl {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.ComboBoxEdit cmbResources;
        private DevExpress.XtraEditors.ImageComboBoxEdit cmbDays;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.ImageComboBoxEdit cmbAppointments;
        private XtraBars.Navigation.NavigationPane navigationPaneSettings;
        private XtraBars.Navigation.NavigationPage navigationPageSettings;
        private XtraLayout.LayoutControl layoutControlSettings;
        private XtraLayout.LayoutControlGroup layoutControlGroupSettings;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton btnEdit;

        public new Report Report { get { return (Report)base.Report; } }

		public PreviewControl()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
            UpdateActiveReport();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		protected override XtraSchedulerReport CreateReportInstance() {
			return new Report();
		}
		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPreviewControlBase));
            this.cmbResources = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbAppointments = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cmbDays = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlSettings = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroupSettings = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.navigationPaneSettings = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPageSettings = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.fSchedulerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPaneSettings)).BeginInit();
            this.navigationPaneSettings.SuspendLayout();
            this.navigationPageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSettings)).BeginInit();
            this.layoutControlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fStoragePrintAdapter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResources.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAppointments.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(7, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(201, 22);
            this.btnEdit.StyleController = this.layoutControlSettings;
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // navigationPaneSettings
            // 
            this.navigationPaneSettings.Controls.Add(this.navigationPageSettings);
            this.navigationPaneSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.navigationPaneSettings.ItemOrientation = System.Windows.Forms.Orientation.Vertical;
            this.navigationPaneSettings.Location = new System.Drawing.Point(455, 0);
            this.navigationPaneSettings.Name = "navigationPaneSettings";
            this.navigationPaneSettings.PageProperties.ShowExpandButton = false;
            this.navigationPaneSettings.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPageSettings});
            this.navigationPaneSettings.SelectedPage = this.navigationPageSettings;
            this.navigationPaneSettings.TabIndex = 11;
            this.navigationPaneSettings.Text = "navigationPane1";
            this.navigationPaneSettings.RegularSize = new System.Drawing.Size(245, 396);
            this.navigationPaneSettings.Size = new System.Drawing.Size(245, 396);
            // 
            // navigationPageSettings
            // 
            this.navigationPageSettings.BackgroundPadding = new System.Windows.Forms.Padding(0);
            this.navigationPageSettings.Caption = "Options";
            this.navigationPageSettings.Controls.Add(this.layoutControlSettings);
            this.navigationPageSettings.Image = ((System.Drawing.Image)(resources.GetObject("navigationPageSettings.Image")));
            this.navigationPageSettings.Name = "navigationPageSettings";
            this.navigationPageSettings.Size = new System.Drawing.Size(215, 352);
            // 
            // layoutControlSettings
            // 
            this.layoutControlSettings.Controls.Add(this.btnEdit);
            this.layoutControlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlSettings.Location = new System.Drawing.Point(0, 0);
            this.layoutControlSettings.Name = "layoutControlSettings";
            this.layoutControlSettings.Root = this.layoutControlGroupSettings;
            this.layoutControlSettings.Size = new System.Drawing.Size(215, 352);
            this.layoutControlSettings.TabIndex = 0;
            this.layoutControlSettings.Text = "layoutControl1";
            this.layoutControlSettings.Controls.Add(this.cmbDays);
            this.layoutControlSettings.Controls.Add(this.cmbAppointments);
            this.layoutControlSettings.Controls.Add(this.cmbResources);
            this.layoutControlSettings.Controls.SetChildIndex(this.cmbResources, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.btnEdit, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.cmbAppointments, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.cmbDays, 0);
            // 
            // layoutControlGroupSettings
            // 
            this.layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupSettings.GroupBordersVisible = false;
            this.layoutControlGroupSettings.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroupSettings.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupSettings.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroupSettings.Size = new System.Drawing.Size(215, 352);
            this.layoutControlGroupSettings.TextVisible = false;
            this.layoutControlGroupSettings.Name = "layoutControlGroup1";
            this.layoutControlGroupSettings.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(205, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 26);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(205, 10);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 108);
            this.emptySpaceItem2.Size = new System.Drawing.Size(205, 234);

            // 
            // fStoragePrintAdapter
            // 
            this.fStoragePrintAdapter.ValidateTimeIntervals += new DevExpress.XtraScheduler.Reporting.TimeIntervalsValidationEventHandler(this.storagePrintAdapter_ValidateTimeIntervals);
            this.fStoragePrintAdapter.ValidateResources += new DevExpress.XtraScheduler.Reporting.ResourcesValidationEventHandler(this.storagePrintAdapter_ValidateResources);
            // 
            // cmbResources
            // 
            this.cmbResources.EditValue = "All";
            this.cmbResources.Location = new System.Drawing.Point(81, 43);
            this.cmbResources.Name = "cmbResources";
            this.cmbResources.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbResources.Properties.Items.AddRange(new object[] {
            "All",
            "Top 3 ",
            "A-Z order",
            "Z-A order",
            ""});
            this.cmbResources.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbResources.Size = new System.Drawing.Size(127, 20);
            this.cmbResources.StyleController = this.layoutControlSettings;
            this.cmbResources.TabIndex = 13;
            this.cmbResources.SelectedIndexChanged += new System.EventHandler(this.cmbResources_SelectedIndexChanged);
            // 
            // cmbAppointments
            // 
            this.cmbAppointments.EditValue = DevExpress.XtraScheduler.UsedAppointmentType.All;
            this.cmbAppointments.Location = new System.Drawing.Point(81, 67);
            this.cmbAppointments.Name = "cmbAppointments";
            this.cmbAppointments.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAppointments.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("All", DevExpress.XtraScheduler.UsedAppointmentType.All, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Recurring", DevExpress.XtraScheduler.UsedAppointmentType.Recurring, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("NonRecurring", DevExpress.XtraScheduler.UsedAppointmentType.NonRecurring, -1)});
            this.cmbAppointments.Size = new System.Drawing.Size(127, 20);
            this.cmbAppointments.StyleController = this.layoutControlSettings;
            this.cmbAppointments.TabIndex = 38;
            this.cmbAppointments.SelectedIndexChanged += new System.EventHandler(this.cmbAppointments_SelectedIndexChanged);
            // 
            // cmbDays
            // 
            this.cmbDays.EditValue = ((DevExpress.XtraScheduler.WeekDays)(((((((DevExpress.XtraScheduler.WeekDays.Sunday | DevExpress.XtraScheduler.WeekDays.Monday) 
            | DevExpress.XtraScheduler.WeekDays.Tuesday) 
            | DevExpress.XtraScheduler.WeekDays.Wednesday) 
            | DevExpress.XtraScheduler.WeekDays.Thursday) 
            | DevExpress.XtraScheduler.WeekDays.Friday) 
            | DevExpress.XtraScheduler.WeekDays.Saturday)));
            this.cmbDays.Location = new System.Drawing.Point(81, 91);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDays.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Every Day", ((DevExpress.XtraScheduler.WeekDays)(((((((DevExpress.XtraScheduler.WeekDays.Sunday | DevExpress.XtraScheduler.WeekDays.Monday) 
                            | DevExpress.XtraScheduler.WeekDays.Tuesday) 
                            | DevExpress.XtraScheduler.WeekDays.Wednesday) 
                            | DevExpress.XtraScheduler.WeekDays.Thursday) 
                            | DevExpress.XtraScheduler.WeekDays.Friday) 
                            | DevExpress.XtraScheduler.WeekDays.Saturday))), -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Work Days", ((DevExpress.XtraScheduler.WeekDays)(((((DevExpress.XtraScheduler.WeekDays.Monday | DevExpress.XtraScheduler.WeekDays.Tuesday) 
                            | DevExpress.XtraScheduler.WeekDays.Wednesday) 
                            | DevExpress.XtraScheduler.WeekDays.Thursday) 
                            | DevExpress.XtraScheduler.WeekDays.Friday))), -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Weekend Days", ((DevExpress.XtraScheduler.WeekDays)((DevExpress.XtraScheduler.WeekDays.Sunday | DevExpress.XtraScheduler.WeekDays.Saturday))), -1)});
            this.cmbDays.Size = new System.Drawing.Size(127, 20);
            this.cmbDays.StyleController = this.layoutControlSettings;
            this.cmbDays.TabIndex = 40;
            this.cmbDays.SelectedIndexChanged += new System.EventHandler(this.cmbDays_SelectedIndexChanged);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cmbResources;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(205, 24);
            this.layoutControlItem2.Text = "Resources:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cmbAppointments;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(205, 24);
            this.layoutControlItem3.Text = "Appointments:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cmbDays;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(205, 24);
            this.layoutControlItem4.Text = "Days:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(70, 13);
            // 
            // PreviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PreviewControl";
            this.Controls.Add(this.navigationPaneSettings);
            ((System.ComponentModel.ISupportInitialize)(this.fSchedulerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPaneSettings)).EndInit();
            this.navigationPaneSettings.ResumeLayout(false);
            this.navigationPageSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSettings)).EndInit();
            this.layoutControlSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fStoragePrintAdapter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResources.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAppointments.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

		}
        #endregion
        void btnEdit_Click(object sender, EventArgs e) {
            CustomDesignForm designForm = new CustomDesignForm();
            XtraSchedulerReport activeReport = GetActiveReport();
            if (activeReport == null)
                return;

            designForm.OpenReport(activeReport);
            PreventUpdate = true;
            try {
                ShowDesignerForm(designForm, this.FindForm());
            } finally {
                PreventUpdate = false;
            }
            designForm.Dispose();

            CreateReports();
            UpdateActiveReport();
        }
        protected override void InitAdapterTimeInterval() {
            StoragePrintAdapter.TimeInterval = new TimeInterval(BaseDate, TimeSpan.FromDays(10));
        }

        protected override void DoValidateAppointments(AppointmentsValidationEventArgs e) {
            base.DoValidateAppointments(e);
            UsedAppointmentType aptType = (UsedAppointmentType)cmbAppointments.EditValue;
            if (aptType.Equals(UsedAppointmentType.All))
                return;

            if (aptType.Equals(UsedAppointmentType.None)) {
                e.Appointments.Clear();
                return;
            }
            int count = e.Appointments.Count;
            AppointmentBaseCollection result = new AppointmentBaseCollection();
            for (int i = 0; i < count; i++) {
                Appointment apt = e.Appointments[i];
                if (aptType.Equals(UsedAppointmentType.Recurring) && apt.IsRecurring)
                    result.Add(apt);
                if (aptType.Equals(UsedAppointmentType.NonRecurring) && !apt.IsRecurring)
                    result.Add(apt);
            }
            e.Appointments.Clear();
            e.Appointments.AddRange(result);
        }
        
        private void storagePrintAdapter_ValidateResources(object sender, ResourcesValidationEventArgs e) {
            int resourceMode = cmbResources.SelectedIndex;
            if (resourceMode == 1) {
                int count = e.Resources.Count;
                for (int i = count - 1; i >= 3; i--) {
                    e.Resources.RemoveAt(i);
                }
            }
            if (resourceMode == 2) {
                e.Resources.Sort(new ResourceCaptionComparer());
            }
            if (resourceMode == 3) {
                e.Resources.Sort(new ResourceCaptionReverseComparer());
            }
        }
        
		private void storagePrintAdapter_ValidateTimeIntervals(object sender, TimeIntervalsValidationEventArgs e) {
            WeekDays weekDays = (WeekDays)cmbDays.EditValue;
			if (weekDays.Equals(WeekDays.EveryDay))
				return;

			int count = e.Intervals.Count;

            DayIntervalCollection result = new DayIntervalCollection();
			for (int i = count - 1; i >= 0; i--) {
                DayIntervalCollection sourceDays = new DayIntervalCollection();
                sourceDays.Add(e.Intervals[i]);
                FilterDays(sourceDays, weekDays);
                result.AddRange(sourceDays);
			}

			e.Intervals.Clear();
            for (int i = 0; i < result.Count; i++) {
                e.Intervals.Add(result[i]);    
            }
            
		}
        void FilterDays(DayIntervalCollection dayIntervals, WeekDays validDays) {
            int count = dayIntervals.Count;
            for (int i = count - 1; i >= 0; i--) {
                DayOfWeek day = dayIntervals[i].Start.DayOfWeek;
                WeekDays weekDay = DevExpress.XtraScheduler.Native.DateTimeHelper.ToWeekDays(day);
                if (!(weekDay & validDays).Equals(weekDay))
                    dayIntervals.RemoveAt(i);
            }
        }
        private void cmbResources_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateActiveReport();
        }

        private void cmbAppointments_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateActiveReport();
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e) {
            CreateReports();
            UpdateActiveReport();
        }

	}
    public class ResourceCaptionComparer : IComparer<Resource>, IComparer {

        #region IComparer Members
        int IComparer.Compare(object x, object y) {
            return CompareCore(x, y);
        }
		public int Compare(Resource x, Resource y) {
			return CompareCore(x, y);
		}
        #endregion

        protected virtual int CompareCore(object x, object y) {
            Resource xRes = (Resource)x;
            Resource yRes = (Resource)y;
            if (xRes == null || yRes == null)
                return 0;
            if (EmptyResourceId.Id.Equals(xRes.Id) || EmptyResourceId.Id.Equals(yRes.Id))
                return 0;
            return CompareCaptions(xRes, yRes);
        }
        protected virtual int CompareCaptions(Resource xRes, Resource yRes) {
            return String.Compare(xRes.Caption, yRes.Caption);
        }

    }
    public class ResourceCaptionReverseComparer : ResourceCaptionComparer {
        protected override int CompareCaptions(Resource xRes, Resource yRes) {
            return String.Compare(yRes.Caption, xRes.Caption);
        }
    }
}

