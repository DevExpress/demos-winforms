using System;
using DevExpress.XtraScheduler.Reporting;
using DevExpress.Utils;

namespace DevExpress.XtraScheduler.Demos.Reporting.Appearance {

	public class PreviewControl : SingleReportPreviewControl {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.SimpleButton btnViewAppearance;
        private DevExpress.XtraEditors.SimpleButton btnResourceColorSchemas;
        private DevExpress.XtraEditors.ImageComboBoxEdit cmbAppointmentSchema;
        private DevExpress.XtraEditors.ImageComboBoxEdit cmbReportSchema;
        private XtraBars.Navigation.NavigationPane navigationPaneSettings;
        private XtraBars.Navigation.NavigationPage navigationPageSettings;
        private XtraLayout.LayoutControl layoutControlSettings;
        private XtraLayout.LayoutControlGroup layoutControlGroupSettings;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.EmptySpaceItem emptySpaceItem3;
        private XtraLayout.LayoutControlItem layoutControlItem3;

		public new Report Report { get { return (Report)base.Report; } }

		public PreviewControl()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();			
            InitializeControlValues();            
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
        protected override void InitAdapterTimeInterval() {
            StoragePrintAdapter.TimeInterval = new TimeInterval(BaseDate, TimeSpan.FromDays(2));
        }
        private void InitializeControlValues() {
            cmbReportSchema.EditValue = Report.ReportColorSchema;
            cmbAppointmentSchema.EditValue = Report.AppointmentsColorSchema;
        }
        protected override void UpdateReportProperties(XtraSchedulerReport otherReport) {
            base.UpdateReportProperties(otherReport);
            Report.ReportColorSchema = (PrintColorSchema)cmbReportSchema.EditValue;
            Report.AppointmentsColorSchema = (PrintColorSchema)cmbAppointmentSchema.EditValue;
        }

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPreviewControlBase));
            this.btnViewAppearance = new DevExpress.XtraEditors.SimpleButton();
            this.btnResourceColorSchemas = new DevExpress.XtraEditors.SimpleButton();
            this.cmbAppointmentSchema = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cmbReportSchema = new DevExpress.XtraEditors.ImageComboBoxEdit();
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
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbAppointmentSchema.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbReportSchema.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // printControl
            // 
            this.printControl.Location = new System.Drawing.Point(0, 34);
            this.printControl.Size = new System.Drawing.Size(453, 362);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(7, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(203, 22);
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
            this.navigationPaneSettings.Location = new System.Drawing.Point(453, 34);
            this.navigationPaneSettings.Name = "navigationPaneSettings";
            this.navigationPaneSettings.PageProperties.ShowExpandButton = false;
            this.navigationPaneSettings.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPageSettings});
            this.navigationPaneSettings.SelectedPage = this.navigationPageSettings;
            this.navigationPaneSettings.TabIndex = 11;
            this.navigationPaneSettings.Text = "navigationPane1";
            this.navigationPaneSettings.RegularSize = new System.Drawing.Size(247, 362);
            this.navigationPaneSettings.Size = new System.Drawing.Size(247, 362);
            // 
            // navigationPageSettings
            // 
            this.navigationPageSettings.BackgroundPadding = new System.Windows.Forms.Padding(0);
            this.navigationPageSettings.Caption = "Options";
            this.navigationPageSettings.Controls.Add(this.layoutControlSettings);
            this.navigationPageSettings.Image = ((System.Drawing.Image)(resources.GetObject("navigationPageSettings.Image")));
            this.navigationPageSettings.Name = "navigationPageSettings";
            this.navigationPageSettings.Size = new System.Drawing.Size(217, 318);
            // 
            // layoutControlSettings
            // 
            this.layoutControlSettings.Controls.Add(this.btnEdit);
            this.layoutControlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlSettings.Location = new System.Drawing.Point(0, 0);
            this.layoutControlSettings.Name = "layoutControlSettings";
            this.layoutControlSettings.Root = this.layoutControlGroupSettings;
            this.layoutControlSettings.TabIndex = 0;
            this.layoutControlSettings.Text = "layoutControl1";
            this.layoutControlSettings.Controls.Add(this.cmbAppointmentSchema);
            this.layoutControlSettings.Controls.Add(this.btnResourceColorSchemas);
            this.layoutControlSettings.Controls.Add(this.cmbReportSchema);
            this.layoutControlSettings.Controls.Add(this.btnViewAppearance);
            this.layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1031, 142, 650, 400);
            this.layoutControlSettings.Size = new System.Drawing.Size(217, 318);
            this.layoutControlSettings.Controls.SetChildIndex(this.btnViewAppearance, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.cmbReportSchema, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.btnResourceColorSchemas, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.btnEdit, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.cmbAppointmentSchema, 0);
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
            this.layoutControlGroupSettings.TextVisible = false;
            this.layoutControlGroupSettings.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.emptySpaceItem3});
            this.layoutControlGroupSettings.Name = "Root";
            this.layoutControlGroupSettings.Size = new System.Drawing.Size(217, 318);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            this.layoutControlItem1.Size = new System.Drawing.Size(207, 26);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 26);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            this.emptySpaceItem1.Size = new System.Drawing.Size(207, 10);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 176);
            this.emptySpaceItem2.Size = new System.Drawing.Size(207, 132);
            // 
            // btnViewAppearance
            // 
            this.btnViewAppearance.ImageIndex = 2;
            this.btnViewAppearance.Location = new System.Drawing.Point(7, 69);
            this.btnViewAppearance.Name = "btnViewAppearance";
            this.btnViewAppearance.Size = new System.Drawing.Size(203, 22);
            this.btnViewAppearance.StyleController = this.layoutControlSettings;
            this.btnViewAppearance.TabIndex = 0;
            this.btnViewAppearance.Text = "&Edit View Appearance...";
            this.btnViewAppearance.Click += new System.EventHandler(this.btnEditAppearance_Click);
            // 
            // btnResourceColorSchemas
            // 
            this.btnResourceColorSchemas.ImageIndex = 2;
            this.btnResourceColorSchemas.Location = new System.Drawing.Point(7, 43);
            this.btnResourceColorSchemas.Name = "btnResourceColorSchemas";
            this.btnResourceColorSchemas.Size = new System.Drawing.Size(203, 22);
            this.btnResourceColorSchemas.StyleController = this.layoutControlSettings;
            this.btnResourceColorSchemas.TabIndex = 1;
            this.btnResourceColorSchemas.Text = "&Edit Resource Color Schemas...";
            this.btnResourceColorSchemas.Click += new System.EventHandler(this.btnResourceColorSchemas_Click);
            // 
            // cmbAppointmentSchema
            // 
            this.cmbAppointmentSchema.EditValue = DevExpress.XtraScheduler.Reporting.PrintColorSchema.Default;
            this.cmbAppointmentSchema.Location = new System.Drawing.Point(83, 153);
            this.cmbAppointmentSchema.Name = "cmbAppointmentSchema";
            this.cmbAppointmentSchema.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAppointmentSchema.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Default", DevExpress.XtraScheduler.Reporting.PrintColorSchema.Default, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("FullColor", DevExpress.XtraScheduler.Reporting.PrintColorSchema.FullColor, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("GrayScale", DevExpress.XtraScheduler.Reporting.PrintColorSchema.GrayScale, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("BlackAndWhite", DevExpress.XtraScheduler.Reporting.PrintColorSchema.BlackAndWhite, -1)});
            this.cmbAppointmentSchema.Size = new System.Drawing.Size(121, 20);
            this.cmbAppointmentSchema.StyleController = this.layoutControlSettings;
            this.cmbAppointmentSchema.TabIndex = 1;
            this.cmbAppointmentSchema.SelectedIndexChanged += new System.EventHandler(this.cmbAppointmentSchema_SelectedIndexChanged);
            // 
            // cmbReportSchema
            // 
            this.cmbReportSchema.EditValue = DevExpress.XtraScheduler.Reporting.PrintColorSchema.Default;
            this.cmbReportSchema.Location = new System.Drawing.Point(83, 129);
            this.cmbReportSchema.Name = "cmbReportSchema";
            this.cmbReportSchema.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbReportSchema.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Default", DevExpress.XtraScheduler.Reporting.PrintColorSchema.Default, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("FullColor", DevExpress.XtraScheduler.Reporting.PrintColorSchema.FullColor, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("GrayScale", DevExpress.XtraScheduler.Reporting.PrintColorSchema.GrayScale, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("BlackAndWhite", DevExpress.XtraScheduler.Reporting.PrintColorSchema.BlackAndWhite, -1)});
            this.cmbReportSchema.Size = new System.Drawing.Size(121, 20);
            this.cmbReportSchema.StyleController = this.layoutControlSettings;
            this.cmbReportSchema.TabIndex = 0;
            this.cmbReportSchema.SelectedIndexChanged += new System.EventHandler(this.cmbReportSchema_SelectedIndexChanged);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnViewAppearance;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 62);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(207, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnResourceColorSchemas;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(207, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cmbReportSchema;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(195, 24);
            this.layoutControlItem4.Text = "Report";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cmbAppointmentSchema;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(195, 24);
            this.layoutControlItem5.Text = "Appointments";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 98);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup1.Size = new System.Drawing.Size(207, 78);
            this.layoutControlGroup1.Text = "Print Color Schema";
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 88);
            this.emptySpaceItem3.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(207, 10);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbAppointmentSchema.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbReportSchema.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
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

        private void btnEditAppearance_Click(object sender, EventArgs e) {
           Report.Appearances.Changed += new EventHandler(Appearances_Changed);
           try {
               AppearancesEditForm frm = new AppearancesEditForm(Report.Appearances, this.FindForm());
               frm.ShowDialog();
           } finally {
               Report.Appearances.Changed -= new EventHandler(Appearances_Changed);
           }
        }
        void Appearances_Changed(object sender, EventArgs e) {
            UpdateActiveReport();
        }

        private void btnResourceColorSchemas_Click(object sender, EventArgs e) {
            StoragePrintAdapter.ResourceColorsChanged += new EventHandler(StoragePrintAdapter_ResourceColorsChanged);
            try {
                ColorSchemasEditForm frm = new ColorSchemasEditForm(StoragePrintAdapter.ResourceColorSchemas, this.FindForm());
                frm.ShowDialog();
            }
            finally {
                StoragePrintAdapter.ResourceColorsChanged -= new EventHandler(StoragePrintAdapter_ResourceColorsChanged);
            }
        }

        void StoragePrintAdapter_ResourceColorsChanged(object sender, EventArgs e) {
            UpdateActiveReport();
        }
        public void ResourceColorSchemasChanged(object sender, CollectionChangedEventArgs<SchedulerColorSchema> e) {
            UpdateActiveReport();
        }

        private void cmbAppointmentSchema_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateActiveReport();
        }

        private void cmbReportSchema_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateActiveReport();
        }
	}
}

