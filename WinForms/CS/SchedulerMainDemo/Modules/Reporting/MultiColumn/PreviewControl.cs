using System;
using DevExpress.XtraScheduler.Reporting;

namespace DevExpress.XtraScheduler.Demos.Reporting.MultiColumn {

	public class PreviewControl : SingleReportPreviewControl {
		private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraEditors.SpinEdit spinColumnCount;
        private DevExpress.XtraEditors.RadioGroup rgrpColumnArrangement;

        int visibleWeekDayColumnCount = 0;
        private XtraBars.Navigation.NavigationPane navigationPaneSettings;
        private XtraBars.Navigation.NavigationPage navigationPageSettings;
        private XtraLayout.LayoutControl layoutControlSettings;
        private XtraLayout.LayoutControlGroup layoutControlGroupSettings;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.EmptySpaceItem emptySpaceItem3;
        ColumnArrangementMode columnArrangement = ColumnArrangementMode.Ascending;
        
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
		void InitializeControlValues() {
            visibleWeekDayColumnCount = Report.VisibleWeekDayColumnCount;
            columnArrangement = Report.ColumnArrangement;

            spinColumnCount.Value = visibleWeekDayColumnCount;
            rgrpColumnArrangement.EditValue = columnArrangement;
		}
		protected override void UpdateReportProperties(XtraSchedulerReport otherReport) {
			base.UpdateReportProperties(otherReport);
            Report.VisibleWeekDayColumnCount = visibleWeekDayColumnCount;
            Report.ColumnArrangement = columnArrangement;
		}
		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPreviewControlBase));
            this.spinColumnCount = new DevExpress.XtraEditors.SpinEdit();
            this.rgrpColumnArrangement = new DevExpress.XtraEditors.RadioGroup();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlSettings = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroupSettings = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.navigationPaneSettings = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPageSettings = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.spinColumnCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgrpColumnArrangement.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
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
            this.navigationPaneSettings.RegularSize = new System.Drawing.Size(245, 396);
            this.navigationPaneSettings.SelectedPage = this.navigationPageSettings;
            this.navigationPaneSettings.Size = new System.Drawing.Size(245, 396);
            this.navigationPaneSettings.TabIndex = 11;
            this.navigationPaneSettings.Text = "navigationPane1";
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
            this.layoutControlSettings.Controls.Add(this.rgrpColumnArrangement);
            this.layoutControlSettings.Controls.Add(this.spinColumnCount);
            this.layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1031, 142, 650, 400);
            this.layoutControlSettings.Controls.SetChildIndex(this.btnEdit, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.spinColumnCount, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.rgrpColumnArrangement, 0);
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
            this.layoutControlGroupSettings.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlGroup1,
            this.emptySpaceItem3});
            this.layoutControlGroupSettings.Name = "Root";
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
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 154);
            this.emptySpaceItem2.Size = new System.Drawing.Size(205, 188);
            // 
            // spinColumnCount
            // 
            this.spinColumnCount.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinColumnCount.Location = new System.Drawing.Point(136, 43);
            this.spinColumnCount.Name = "spinColumnCount";
            this.spinColumnCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinColumnCount.Properties.IsFloatValue = false;
            this.spinColumnCount.Properties.Mask.EditMask = "N00";
            this.spinColumnCount.Properties.MaxValue = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.spinColumnCount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinColumnCount.Size = new System.Drawing.Size(72, 20);
            this.spinColumnCount.StyleController = this.layoutControlSettings;
            this.spinColumnCount.TabIndex = 3;
            this.spinColumnCount.EditValueChanged += new System.EventHandler(this.spinColumnPerPage_EditValueChanged);
            // 
            // rgrpColumnArrangement
            // 
            this.rgrpColumnArrangement.Location = new System.Drawing.Point(13, 101);
            this.rgrpColumnArrangement.MaximumSize = new System.Drawing.Size(0, 50);
            this.rgrpColumnArrangement.MinimumSize = new System.Drawing.Size(0, 50);
            this.rgrpColumnArrangement.Name = "rgrpColumnArrangement";
            this.rgrpColumnArrangement.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgrpColumnArrangement.Properties.Appearance.Options.UseBackColor = true;
            this.rgrpColumnArrangement.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgrpColumnArrangement.Properties.Columns = 1;
            this.rgrpColumnArrangement.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.Reporting.ColumnArrangementMode.Ascending, "Ascending"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.Reporting.ColumnArrangementMode.Descending, "Descending")});
            this.rgrpColumnArrangement.Size = new System.Drawing.Size(189, 50);
            this.rgrpColumnArrangement.StyleController = this.layoutControlSettings;
            this.rgrpColumnArrangement.TabIndex = 7;
            this.rgrpColumnArrangement.SelectedIndexChanged += new System.EventHandler(this.rgrpColumnMode_SelectedIndexChanged);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.spinColumnCount;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(205, 24);
            this.layoutControlItem2.Text = "WeekDays Column Count:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(125, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.rgrpColumnArrangement;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(193, 54);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 70);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup1.Size = new System.Drawing.Size(205, 84);
            this.layoutControlGroup1.Text = "Column Arrangement";
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 60);
            this.emptySpaceItem3.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(205, 10);
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
            ((System.ComponentModel.ISupportInitialize)(this.spinColumnCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgrpColumnArrangement.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
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
        void spinColumnPerPage_EditValueChanged(object sender, EventArgs e) {
            this.visibleWeekDayColumnCount = Convert.ToInt32(spinColumnCount.Value);
			UpdateActiveReport();
		}
        void rgrpColumnMode_SelectedIndexChanged(object sender, EventArgs e) {
            this.columnArrangement = (ColumnArrangementMode)rgrpColumnArrangement.EditValue;
            UpdateActiveReport();
        }

        private void lbResourceCount_Click(object sender, EventArgs e) {

        }

        private void labelControl1_Click(object sender, EventArgs e) {

        }
	}
}

