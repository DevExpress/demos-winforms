using System;
using DevExpress.XtraScheduler.Reporting;

namespace DevExpress.XtraScheduler.Demos.Reporting.MonthlyStyle {

	
	public class PreviewControl : SingleReportPreviewControl {
        System.ComponentModel.IContainer components = null;
        DevExpress.XtraEditors.SpinEdit spinResourceCount;
        protected DevExpress.XtraEditors.CheckEdit chkCompressWeekend;
        protected DevExpress.XtraEditors.CheckEdit chkPrintExactlyOneMonth;
        protected DevExpress.XtraEditors.CheckEdit chkDontPrintWeekends;
        DevExpress.XtraEditors.ComboBoxEdit cmbLayout;

		bool initialized;
        bool dontPrintWeekends;
        bool compressWeekend;
        bool printExactlyOneMonth;
        int visibleResourceCount = 0;
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
        int pageLayout = 1;

		public PreviewControl()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();			
			InitializeControlValues();			
            SubscribeEvents();
		}

        public new Report Report { get { return (Report)base.Report; } }

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPreviewControlBase));
            this.spinResourceCount = new DevExpress.XtraEditors.SpinEdit();
            this.cmbLayout = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chkCompressWeekend = new DevExpress.XtraEditors.CheckEdit();
            this.chkPrintExactlyOneMonth = new DevExpress.XtraEditors.CheckEdit();
            this.chkDontPrintWeekends = new DevExpress.XtraEditors.CheckEdit();
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
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.spinResourceCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLayout.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCompressWeekend.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPrintExactlyOneMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDontPrintWeekends.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(7, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(201, 22);
            this.btnEdit.StyleController = this.layoutControlSettings;
            this.btnEdit.TabIndex = 5;
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
            this.layoutControlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlSettings.Location = new System.Drawing.Point(0, 0);
            this.layoutControlSettings.Name = "layoutControlSettings";
            this.layoutControlSettings.Root = this.layoutControlGroupSettings;
            this.layoutControlSettings.Size = new System.Drawing.Size(215, 352);
            this.layoutControlSettings.TabIndex = 0;
            this.layoutControlSettings.Text = "layoutControl1";
            this.layoutControlSettings.Controls.Add(this.btnEdit);
            this.layoutControlSettings.Controls.Add(this.chkPrintExactlyOneMonth);
            this.layoutControlSettings.Controls.Add(this.chkCompressWeekend);
            this.layoutControlSettings.Controls.Add(this.chkDontPrintWeekends);
            this.layoutControlSettings.Controls.Add(this.cmbLayout);
            this.layoutControlSettings.Controls.Add(this.spinResourceCount);
            this.layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1031, 142, 650, 400);
            this.layoutControlSettings.Controls.SetChildIndex(this.spinResourceCount, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.btnEdit, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.cmbLayout, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.chkDontPrintWeekends, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.chkCompressWeekend, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.chkPrintExactlyOneMonth, 0);
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
            this.layoutControlGroupSettings.Name = "Root";
            this.layoutControlGroupSettings.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroupSettings.Size = new System.Drawing.Size(215, 352);
            this.layoutControlGroupSettings.TextVisible = false;
            this.layoutControlGroupSettings.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem5});
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
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 153);
            this.emptySpaceItem2.Size = new System.Drawing.Size(205, 189);
            // 
            // spinResourceCount
            // 
            this.spinResourceCount.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinResourceCount.Location = new System.Drawing.Point(92, 43);
            this.spinResourceCount.Name = "spinResourceCount";
            this.spinResourceCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinResourceCount.Properties.IsFloatValue = false;
            this.spinResourceCount.Properties.Mask.EditMask = "N00";
            this.spinResourceCount.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinResourceCount.Size = new System.Drawing.Size(116, 20);
            this.spinResourceCount.StyleController = this.layoutControlSettings;
            this.spinResourceCount.TabIndex = 42;
            // 
            // cmbLayout
            // 
            this.cmbLayout.EditValue = "1 page/week";
            this.cmbLayout.Location = new System.Drawing.Point(92, 67);
            this.cmbLayout.Name = "cmbLayout";
            this.cmbLayout.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbLayout.Properties.Items.AddRange(new object[] {
            "1 page/week",
            "2 pages/week"});
            this.cmbLayout.Size = new System.Drawing.Size(116, 20);
            this.cmbLayout.StyleController = this.layoutControlSettings;
            this.cmbLayout.TabIndex = 45;
            // 
            // chkCompressWeekend
            // 
            this.chkCompressWeekend.Location = new System.Drawing.Point(7, 91);
            this.chkCompressWeekend.Name = "chkCompressWeekend";
            this.chkCompressWeekend.Properties.AutoWidth = true;
            this.chkCompressWeekend.Properties.Caption = "Compress Weekend";
            this.chkCompressWeekend.Size = new System.Drawing.Size(117, 19);
            this.chkCompressWeekend.StyleController = this.layoutControlSettings;
            this.chkCompressWeekend.TabIndex = 48;
            // 
            // chkPrintExactlyOneMonth
            // 
            this.chkPrintExactlyOneMonth.Location = new System.Drawing.Point(7, 137);
            this.chkPrintExactlyOneMonth.Name = "chkPrintExactlyOneMonth";
            this.chkPrintExactlyOneMonth.Properties.AutoWidth = true;
            this.chkPrintExactlyOneMonth.Properties.Caption = "Print Exactly One Month Per Page";
            this.chkPrintExactlyOneMonth.Size = new System.Drawing.Size(184, 19);
            this.chkPrintExactlyOneMonth.StyleController = this.layoutControlSettings;
            this.chkPrintExactlyOneMonth.TabIndex = 47;
            // 
            // chkDontPrintWeekends
            // 
            this.chkDontPrintWeekends.Location = new System.Drawing.Point(7, 114);
            this.chkDontPrintWeekends.Name = "chkDontPrintWeekends";
            this.chkDontPrintWeekends.Properties.AutoWidth = true;
            this.chkDontPrintWeekends.Properties.Caption = "Don\'t Print &Weekends";
            this.chkDontPrintWeekends.Size = new System.Drawing.Size(125, 19);
            this.chkDontPrintWeekends.StyleController = this.layoutControlSettings;
            this.chkDontPrintWeekends.TabIndex = 46;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.spinResourceCount;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(205, 24);
            this.layoutControlItem2.Text = "Resource Count:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cmbLayout;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(205, 24);
            this.layoutControlItem3.Text = "Layout:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chkDontPrintWeekends;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 107);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(205, 23);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chkCompressWeekend;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(205, 23);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.chkPrintExactlyOneMonth;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 130);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(205, 23);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
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
            this.layoutControlSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fStoragePrintAdapter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinResourceCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLayout.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCompressWeekend.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPrintExactlyOneMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDontPrintWeekends.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

		}
        #endregion

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// 
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
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        void SubscribeEvents() {
            this.spinResourceCount.EditValueChanged += new EventHandler(spinResourceCount_EditValueChanged);
            this.chkPrintExactlyOneMonth.CheckedChanged += new EventHandler(chkPrintExactlyOneMonth_CheckedChanged);
            this.chkDontPrintWeekends.CheckedChanged += new EventHandler(chkDontPrintWeekends_CheckedChanged);
            this.chkCompressWeekend.CheckedChanged += new EventHandler(chkCompressWeekend_CheckedChanged);
            this.cmbLayout.SelectedIndexChanged += new EventHandler(cmbLayout_SelectedIndexChanged);
        }
        protected override XtraSchedulerReport CreateReportInstance() {
            return new Report();
        }
        void InitializeControlValues() {
            this.dontPrintWeekends = Report.DontPrintWeekends;
            this.compressWeekend = Report.CompressWeekend;
            this.visibleResourceCount = Report.VisibleResourceCount;
            this.printExactlyOneMonth = Report.PrintExactlyOneMonth;
            this.pageLayout = Report.ColumnCount - 1;
            this.cmbLayout.SelectedIndex = this.pageLayout;
            this.spinResourceCount.Value = this.visibleResourceCount;
            this.spinResourceCount.Properties.MinValue = 1;
            this.spinResourceCount.Properties.MaxValue = StoragePrintAdapter.ResourceCount;
            this.chkCompressWeekend.Checked = this.compressWeekend;
            this.chkDontPrintWeekends.Checked = this.dontPrintWeekends;
            this.chkPrintExactlyOneMonth.Checked = this.printExactlyOneMonth;
            this.initialized = true;
        }
        protected override void UpdateReportProperties(XtraSchedulerReport otherReport) {
            base.UpdateReportProperties(otherReport);
            Report.DontPrintWeekends = this.dontPrintWeekends;
            Report.VisibleResourceCount = this.visibleResourceCount;
            Report.ColumnCount = this.cmbLayout.SelectedIndex + 1;
            Report.CompressWeekend = this.compressWeekend;
            Report.DontPrintWeekends = this.dontPrintWeekends;
            Report.PrintExactlyOneMonth = this.printExactlyOneMonth;
        }	
        void cmbLayout_SelectedIndexChanged(object sender, EventArgs e) {
            this.pageLayout = this.cmbLayout.SelectedIndex + 1;
            UpdateActiveReport();
        }
		void spinResourceCount_EditValueChanged(object sender, EventArgs e) {
			if (!this.initialized)
				return;
			this.visibleResourceCount = Convert.ToInt32(spinResourceCount.Value);
			UpdateActiveReport();
		}
        void chkCompressWeekend_CheckedChanged(object sender, EventArgs e) {
            if (!initialized)
                return;
            this.compressWeekend = this.chkCompressWeekend.Checked;
            UpdateActiveReport();
        }
        void chkDontPrintWeekends_CheckedChanged(object sender, EventArgs e) {
            if (!initialized)
                return;
            this.dontPrintWeekends = this.chkDontPrintWeekends.Checked;
            UpdateActiveReport();
        }
        void chkPrintExactlyOneMonth_CheckedChanged(object sender, EventArgs e) {
            if (!initialized)
                return;
            this.printExactlyOneMonth = this.chkPrintExactlyOneMonth.Checked;
            UpdateActiveReport();
        }
	}	
}

