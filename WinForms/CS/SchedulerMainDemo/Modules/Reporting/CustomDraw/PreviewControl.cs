using System;
using DevExpress.XtraScheduler.Reporting;
using DevExpress.XtraEditors;

namespace DevExpress.XtraScheduler.Demos.Reporting.CustomDraw {

	public class PreviewControl : SingleReportPreviewControl {
        private System.ComponentModel.IContainer components = null;

        bool allowCustomDrawDayHeader;
        bool allowCustomDrawResourceHeader;
        bool allowCustomDrawAllDayArea;
        bool allowCustomDrawTimeCell;
        bool allowCustomDrawTimeRuler;
        bool allowCustomDrawAppointment;
        private CheckEdit chkTimeRuler;
        private CheckEdit chkAppointmentBackground;
        private CheckEdit chkAppointment;
        private CheckEdit chkDayViewAllDayArea;
        private CheckEdit chkTimeCell;
        private CheckEdit chkDayHeader;
        private CheckEdit chkResourceHeader;
        private XtraBars.Navigation.NavigationPane navigationPaneSettings;
        private XtraBars.Navigation.NavigationPage navigationPageSettings;
        private XtraLayout.LayoutControl layoutControlSettings;
        private XtraLayout.LayoutControlGroup layoutControlGroupSettings;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraLayout.LayoutControlItem layoutControlItem7;
        private XtraLayout.LayoutControlItem layoutControlItem8;
        bool allowCustomDrawAppointmentBackground;


		public PreviewControl()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();			
			InitializeControlValues();            
		}

		public new Report Report { get { return (Report)base.Report; } }

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
            StoragePrintAdapter.TimeInterval = new TimeInterval(BaseDate, TimeSpan.FromDays(7));
        }
		void InitializeControlValues() {
            allowCustomDrawDayHeader = chkDayHeader.Checked;
            allowCustomDrawResourceHeader = chkResourceHeader.Checked;
            allowCustomDrawAllDayArea = chkDayViewAllDayArea.Checked;
            allowCustomDrawTimeCell = chkTimeCell.Checked;
            allowCustomDrawTimeRuler = chkTimeRuler.Checked;
            allowCustomDrawAppointment = chkAppointment.Checked;
            allowCustomDrawAppointmentBackground = chkAppointmentBackground.Checked;
		}
		protected override void UpdateReportProperties(XtraSchedulerReport otherReport) {
			base.UpdateReportProperties(otherReport);
            Report.AllowCustomDrawAllDayArea = allowCustomDrawAllDayArea;
            Report.AllowCustomDrawAppointment = allowCustomDrawAppointment;
            Report.AllowCustomDrawAppointmentBackground = allowCustomDrawAppointmentBackground;
            Report.AllowCustomDrawDayHeader = allowCustomDrawDayHeader;
            Report.AllowCustomDrawResourceHeader = allowCustomDrawResourceHeader;
            Report.AllowCustomDrawTimeCell = allowCustomDrawTimeCell;
            Report.AllowCustomDrawTimeRuler = allowCustomDrawTimeRuler;
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.chkTimeRuler = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlSettings = new DevExpress.XtraLayout.LayoutControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroupSettings = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.chkDayViewAllDayArea = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.chkDayHeader = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.chkResourceHeader = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.chkTimeCell = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.chkAppointment = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.chkAppointmentBackground = new DevExpress.XtraEditors.CheckEdit();
            this.navigationPaneSettings = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPageSettings = new DevExpress.XtraBars.Navigation.NavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.fSchedulerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fStoragePrintAdapter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTimeRuler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSettings)).BeginInit();
            this.layoutControlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDayViewAllDayArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDayHeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkResourceHeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTimeCell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAppointment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAppointmentBackground.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPaneSettings)).BeginInit();
            this.navigationPaneSettings.SuspendLayout();
            this.navigationPageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // printControl
            // 
            this.printControl.Size = new System.Drawing.Size(496, 396);
            // 
            // chkTimeRuler
            // 
            this.chkTimeRuler.EditValue = true;
            this.chkTimeRuler.Location = new System.Drawing.Point(7, 43);
            this.chkTimeRuler.Name = "chkTimeRuler";
            this.chkTimeRuler.Properties.Caption = "Time Ruler";
            this.chkTimeRuler.Size = new System.Drawing.Size(163, 19);
            this.chkTimeRuler.StyleController = this.layoutControlSettings;
            this.chkTimeRuler.TabIndex = 101;
            this.chkTimeRuler.CheckedChanged += new System.EventHandler(this.chkTimeRuler_CheckedChanged);
            // 
            // layoutControlSettings
            // 
            this.layoutControlSettings.Controls.Add(this.chkAppointmentBackground);
            this.layoutControlSettings.Controls.Add(this.chkTimeRuler);
            this.layoutControlSettings.Controls.Add(this.chkAppointment);
            this.layoutControlSettings.Controls.Add(this.chkTimeCell);
            this.layoutControlSettings.Controls.Add(this.chkDayViewAllDayArea);
            this.layoutControlSettings.Controls.Add(this.chkResourceHeader);
            this.layoutControlSettings.Controls.Add(this.chkDayHeader);
            this.layoutControlSettings.Controls.Add(this.btnEdit);
            this.layoutControlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlSettings.Location = new System.Drawing.Point(0, 0);
            this.layoutControlSettings.Name = "layoutControlSettings";
            this.layoutControlSettings.Root = this.layoutControlGroupSettings;
            this.layoutControlSettings.Size = new System.Drawing.Size(177, 352);
            this.layoutControlSettings.TabIndex = 0;
            this.layoutControlSettings.Text = "layoutControl1";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(7, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(163, 22);
            this.btnEdit.StyleController = this.layoutControlSettings;
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // layoutControlGroupSettings
            // 
            this.layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupSettings.GroupBordersVisible = false;
            this.layoutControlGroupSettings.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem1});
            this.layoutControlGroupSettings.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupSettings.Name = "layoutControlGroup1";
            this.layoutControlGroupSettings.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroupSettings.Size = new System.Drawing.Size(177, 352);
            this.layoutControlGroupSettings.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(167, 26);
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
            this.emptySpaceItem1.Size = new System.Drawing.Size(167, 10);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 197);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(167, 145);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.chkTimeRuler;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(167, 23);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chkDayViewAllDayArea;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 59);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(167, 23);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // chkDayViewAllDayArea
            // 
            this.chkDayViewAllDayArea.EditValue = true;
            this.chkDayViewAllDayArea.Location = new System.Drawing.Point(7, 66);
            this.chkDayViewAllDayArea.Name = "chkDayViewAllDayArea";
            this.chkDayViewAllDayArea.Properties.Caption = "All-Day Area";
            this.chkDayViewAllDayArea.Size = new System.Drawing.Size(163, 19);
            this.chkDayViewAllDayArea.StyleController = this.layoutControlSettings;
            this.chkDayViewAllDayArea.TabIndex = 98;
            this.chkDayViewAllDayArea.CheckedChanged += new System.EventHandler(this.chkDayViewAllDayArea_CheckedChanged);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chkDayHeader;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 82);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(167, 23);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // chkDayHeader
            // 
            this.chkDayHeader.EditValue = true;
            this.chkDayHeader.Location = new System.Drawing.Point(7, 89);
            this.chkDayHeader.Name = "chkDayHeader";
            this.chkDayHeader.Properties.Caption = "Day Header";
            this.chkDayHeader.Size = new System.Drawing.Size(163, 19);
            this.chkDayHeader.StyleController = this.layoutControlSettings;
            this.chkDayHeader.TabIndex = 96;
            this.chkDayHeader.CheckedChanged += new System.EventHandler(this.chkDayHeader_CheckedChanged);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chkResourceHeader;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 105);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(167, 23);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // chkResourceHeader
            // 
            this.chkResourceHeader.EditValue = true;
            this.chkResourceHeader.Location = new System.Drawing.Point(7, 112);
            this.chkResourceHeader.Name = "chkResourceHeader";
            this.chkResourceHeader.Properties.Caption = "Resource Header";
            this.chkResourceHeader.Size = new System.Drawing.Size(163, 19);
            this.chkResourceHeader.StyleController = this.layoutControlSettings;
            this.chkResourceHeader.TabIndex = 95;
            this.chkResourceHeader.CheckedChanged += new System.EventHandler(this.chkResourceHeader_CheckedChanged);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.chkTimeCell;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 128);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(167, 23);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // chkTimeCell
            // 
            this.chkTimeCell.EditValue = true;
            this.chkTimeCell.Location = new System.Drawing.Point(7, 135);
            this.chkTimeCell.Name = "chkTimeCell";
            this.chkTimeCell.Properties.Caption = "Time Cell";
            this.chkTimeCell.Size = new System.Drawing.Size(163, 19);
            this.chkTimeCell.StyleController = this.layoutControlSettings;
            this.chkTimeCell.TabIndex = 97;
            this.chkTimeCell.CheckedChanged += new System.EventHandler(this.chkTimeCell_CheckedChanged);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.chkAppointment;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 151);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(167, 23);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // chkAppointment
            // 
            this.chkAppointment.EditValue = true;
            this.chkAppointment.Location = new System.Drawing.Point(7, 158);
            this.chkAppointment.Name = "chkAppointment";
            this.chkAppointment.Properties.Caption = "Appointment";
            this.chkAppointment.Size = new System.Drawing.Size(163, 19);
            this.chkAppointment.StyleController = this.layoutControlSettings;
            this.chkAppointment.TabIndex = 99;
            this.chkAppointment.CheckedChanged += new System.EventHandler(this.chkAppointment_CheckedChanged);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.chkAppointmentBackground;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 174);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(167, 23);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // chkAppointmentBackground
            // 
            this.chkAppointmentBackground.EditValue = true;
            this.chkAppointmentBackground.Location = new System.Drawing.Point(7, 181);
            this.chkAppointmentBackground.Name = "chkAppointmentBackground";
            this.chkAppointmentBackground.Properties.Caption = "Appointment Background";
            this.chkAppointmentBackground.Size = new System.Drawing.Size(163, 19);
            this.chkAppointmentBackground.StyleController = this.layoutControlSettings;
            this.chkAppointmentBackground.TabIndex = 100;
            this.chkAppointmentBackground.CheckedChanged += new System.EventHandler(this.chkAppointmentBackground_CheckedChanged);
            // 
            // navigationPaneSettings
            // 
            this.navigationPaneSettings.Controls.Add(this.navigationPageSettings);
            this.navigationPaneSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.navigationPaneSettings.ItemOrientation = System.Windows.Forms.Orientation.Vertical;
            this.navigationPaneSettings.Location = new System.Drawing.Point(496, 0);
            this.navigationPaneSettings.Name = "navigationPaneSettings";
            this.navigationPaneSettings.PageProperties.ShowExpandButton = false;
            this.navigationPaneSettings.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPageSettings});
            this.navigationPaneSettings.RegularSize = new System.Drawing.Size(204, 396);
            this.navigationPaneSettings.SelectedPage = this.navigationPageSettings;
            this.navigationPaneSettings.Size = new System.Drawing.Size(204, 396);
            this.navigationPaneSettings.TabIndex = 11;
            this.navigationPaneSettings.Text = "navigationPane1";
            // 
            // navigationPageSettings
            // 
            this.navigationPageSettings.BackgroundPadding = new System.Windows.Forms.Padding(0);
            this.navigationPageSettings.Caption = "Options";
            this.navigationPageSettings.Controls.Add(this.layoutControlSettings);
            this.navigationPageSettings.Name = "navigationPageSettings";
            this.navigationPageSettings.Size = new System.Drawing.Size(177, 352);
            // 
            // PreviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navigationPaneSettings);
            this.Name = "PreviewControl";
            this.Controls.SetChildIndex(this.navigationPaneSettings, 0);
            this.Controls.SetChildIndex(this.printControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fSchedulerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fStoragePrintAdapter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTimeRuler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSettings)).EndInit();
            this.layoutControlSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDayViewAllDayArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDayHeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkResourceHeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTimeCell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAppointment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAppointmentBackground.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPaneSettings)).EndInit();
            this.navigationPaneSettings.ResumeLayout(false);
            this.navigationPageSettings.ResumeLayout(false);
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

        private void chkDayHeader_CheckedChanged(object sender, EventArgs e) {
            this.allowCustomDrawDayHeader = ((CheckEdit)sender).Checked;
            UpdateActiveReport();
        }

        private void chkResourceHeader_CheckedChanged(object sender, EventArgs e) {
            this.allowCustomDrawResourceHeader = ((CheckEdit)sender).Checked;
            UpdateActiveReport();
        }

        private void chkTimeCell_CheckedChanged(object sender, EventArgs e) {
            this.allowCustomDrawTimeCell = ((CheckEdit)sender).Checked;
            UpdateActiveReport();

        }

        private void chkDayViewAllDayArea_CheckedChanged(object sender, EventArgs e) {
            this.allowCustomDrawAllDayArea = ((CheckEdit)sender).Checked;
            UpdateActiveReport();
        }

        private void chkAppointment_CheckedChanged(object sender, EventArgs e) {
            this.allowCustomDrawAppointment = ((CheckEdit)sender).Checked;
            UpdateActiveReport();

        }

        private void chkAppointmentBackground_CheckedChanged(object sender, EventArgs e) {
            this.allowCustomDrawAppointmentBackground = ((CheckEdit)sender).Checked;
            UpdateActiveReport();
        }

        private void chkTimeRuler_CheckedChanged(object sender, EventArgs e) {
            this.allowCustomDrawTimeRuler = ((CheckEdit)sender).Checked;
            UpdateActiveReport();
        }
	}

}

