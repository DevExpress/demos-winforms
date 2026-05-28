using System;
using DevExpress.XtraScheduler.Reporting;

namespace DevExpress.XtraScheduler.Demos.Reporting.WeeklyStyle {

	public class PreviewControl : SingleReportPreviewControl {
		private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraEditors.ComboBoxEdit cmbLayout;
        private DevExpress.XtraEditors.SpinEdit spinResourceCount;
        protected DevExpress.XtraEditors.DateEdit edtEnd;
        protected DevExpress.XtraEditors.DateEdit edtStart;

        TimeInterval printInterval = TimeInterval.Empty;
		int pagesPerWeek;
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
        int resourceCount;

		public new Report Report { get { return (Report)base.Report; } }
        private DateTime EndDate { get { return edtEnd.DateTime.AddDays(1); } set { edtEnd.DateTime = value.AddDays(-1); } }
        private DateTime StartDate { get { return edtStart.DateTime; } set { edtStart.DateTime = value; } }

		public PreviewControl()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();			
			InitializeControlValues();
            SubscribeEvents();
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
			StoragePrintAdapter.TimeInterval = new TimeInterval(BaseDate, TimeSpan.FromDays(14));
		}
		void InitializeControlValues() {
            printInterval = new TimeInterval(BaseDate, BaseDate.AddDays(6));
            StartDate = printInterval.Start;
            EndDate = printInterval.End;

			this.pagesPerWeek = Report.ColumnCount;
            this.cmbLayout.SelectedIndex = pagesPerWeek - 1;
            InitializeResourceCount();
		}
        void InitializeResourceCount() {
            this.spinResourceCount.Properties.MinValue = 1;
            this.spinResourceCount.Properties.MaxValue = SchedulerStorage.Resources.Count;
            this.resourceCount = Report.ResourceCount;
            this.spinResourceCount.Value = this.resourceCount;
        }
		protected override void UpdateReportProperties(XtraSchedulerReport otherReport) {
            StoragePrintAdapter.TimeInterval = printInterval;
			base.UpdateReportProperties(otherReport);
			Report.ColumnCount = pagesPerWeek;
            Report.ResourceCount = resourceCount;
		}
		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPreviewControlBase));
            this.cmbLayout = new DevExpress.XtraEditors.ComboBoxEdit();
            this.spinResourceCount = new DevExpress.XtraEditors.SpinEdit();
            this.edtEnd = new DevExpress.XtraEditors.DateEdit();
            this.edtStart = new DevExpress.XtraEditors.DateEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbLayout.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinResourceCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // printControl
            // 
            this.printControl.Size = new System.Drawing.Size(461, 396);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(7, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.StyleController = this.layoutControlSettings;
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.Size = new System.Drawing.Size(195, 22);
            // 
            // navigationPaneSettings
            // 
            this.navigationPaneSettings.Controls.Add(this.navigationPageSettings);
            this.navigationPaneSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.navigationPaneSettings.ItemOrientation = System.Windows.Forms.Orientation.Vertical;
            this.navigationPaneSettings.Name = "navigationPaneSettings";
            this.navigationPaneSettings.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPageSettings});
            this.navigationPaneSettings.SelectedPage = this.navigationPageSettings;
            this.navigationPaneSettings.TabIndex = 11;
            this.navigationPaneSettings.Text = "navigationPane1";
            this.navigationPaneSettings.Location = new System.Drawing.Point(461, 0);
            this.navigationPaneSettings.PageProperties.ShowExpandButton = false;
            this.navigationPaneSettings.RegularSize = new System.Drawing.Size(239, 396);
            this.navigationPaneSettings.Size = new System.Drawing.Size(239, 396);
            // 
            // navigationPageSettings
            // 
            this.navigationPageSettings.BackgroundPadding = new System.Windows.Forms.Padding(0);
            this.navigationPageSettings.Caption = "Options";
            this.navigationPageSettings.Controls.Add(this.layoutControlSettings);
            this.navigationPageSettings.Image = ((System.Drawing.Image)(resources.GetObject("navigationPageSettings.Image")));
            this.navigationPageSettings.Name = "navigationPageSettings";
            this.navigationPageSettings.Size = new System.Drawing.Size(209, 352);
            // 
            // layoutControlSettings
            // 
            this.layoutControlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlSettings.Location = new System.Drawing.Point(0, 0);
            this.layoutControlSettings.Name = "layoutControlSettings";
            this.layoutControlSettings.Root = this.layoutControlGroupSettings;
            this.layoutControlSettings.TabIndex = 0;
            this.layoutControlSettings.Text = "layoutControl1";
            this.layoutControlSettings.Controls.Add(this.btnEdit);
            this.layoutControlSettings.Controls.Add(this.edtEnd);
            this.layoutControlSettings.Controls.Add(this.edtStart);
            this.layoutControlSettings.Controls.Add(this.cmbLayout);
            this.layoutControlSettings.Controls.Add(this.spinResourceCount);
            this.layoutControlSettings.Size = new System.Drawing.Size(209, 352);
            this.layoutControlSettings.Controls.SetChildIndex(this.spinResourceCount, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.cmbLayout, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.btnEdit, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.edtStart, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.edtEnd, 0);
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
            this.layoutControlGroupSettings.Name = "layoutControlGroup1";
            this.layoutControlGroupSettings.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroupSettings.TextVisible = false;
            this.layoutControlGroupSettings.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroupSettings.Size = new System.Drawing.Size(209, 352);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            this.layoutControlItem1.Size = new System.Drawing.Size(199, 26);
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
            this.emptySpaceItem1.Size = new System.Drawing.Size(199, 10);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 132);
            this.emptySpaceItem2.Size = new System.Drawing.Size(199, 210);
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
            this.cmbLayout.Size = new System.Drawing.Size(110, 20);
            this.cmbLayout.StyleController = this.layoutControlSettings;
            this.cmbLayout.TabIndex = 5;
            this.cmbLayout.SelectedIndexChanged += new System.EventHandler(this.cmbLayout_SelectedIndexChanged);
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
            this.spinResourceCount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinResourceCount.Properties.IsFloatValue = false;
            this.spinResourceCount.Properties.Mask.EditMask = "N00";
            this.spinResourceCount.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinResourceCount.Size = new System.Drawing.Size(110, 20);
            this.spinResourceCount.StyleController = this.layoutControlSettings;
            this.spinResourceCount.TabIndex = 42;
            // 
            // edtEnd
            // 
            this.edtEnd.EditValue = new System.DateTime(2005, 9, 5, 0, 0, 0, 0);
            this.edtEnd.Location = new System.Drawing.Point(92, 115);
            this.edtEnd.Name = "edtEnd";
            this.edtEnd.Properties.AccessibleName = "End date:";
            this.edtEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtEnd.Size = new System.Drawing.Size(110, 20);
            this.edtEnd.StyleController = this.layoutControlSettings;
            this.edtEnd.TabIndex = 47;
            // 
            // edtStart
            // 
            this.edtStart.EditValue = new System.DateTime(2005, 9, 5, 0, 0, 0, 0);
            this.edtStart.Location = new System.Drawing.Point(92, 91);
            this.edtStart.Name = "edtStart";
            this.edtStart.Properties.AccessibleName = "Start date:";
            this.edtStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtStart.Size = new System.Drawing.Size(110, 20);
            this.edtStart.StyleController = this.layoutControlSettings;
            this.edtStart.TabIndex = 46;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.spinResourceCount;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(199, 24);
            this.layoutControlItem2.Text = "Resource Count:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cmbLayout;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(199, 24);
            this.layoutControlItem3.Text = "Layout:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.edtStart;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(199, 24);
            this.layoutControlItem4.Text = "Start Date:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.edtEnd;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 108);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(199, 24);
            this.layoutControlItem5.Text = "End Date:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(81, 13);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbLayout.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinResourceCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
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
        protected internal virtual void UnsubscribeEvents() {
            this.edtStart.EditValueChanged -= new EventHandler(StartEditValueChanged);
            this.edtEnd.EditValueChanged -= new EventHandler(EndEditValueChanged);
            this.spinResourceCount.EditValueChanged -= new EventHandler(spinResourceCount_EditValueChanged);
        }
        protected internal virtual void SubscribeEvents() {
            this.edtStart.EditValueChanged += new EventHandler(StartEditValueChanged);
            this.edtEnd.EditValueChanged += new EventHandler(EndEditValueChanged);
            this.spinResourceCount.EditValueChanged += new EventHandler(spinResourceCount_EditValueChanged);
        }

        protected internal virtual bool IsValidInterval(DateTime start, DateTime end) {
            return start <= end;
        }
        private void StartEditValueChanged(object sender, EventArgs e) {
            UnsubscribeEvents();
            if (!IsValidInterval(StartDate, EndDate))
                edtEnd.EditValue = StartDate;

            this.printInterval = new TimeInterval(StartDate, EndDate);
            SubscribeEvents();
            UpdateActiveReport();
        }
        
        void spinResourceCount_EditValueChanged(object sender, EventArgs e) {
            this.resourceCount = (int)this.spinResourceCount.Value;
            UpdateActiveReport();
        }
        void EndEditValueChanged(object sender, EventArgs e) {
            UnsubscribeEvents();
            if (!IsValidInterval(StartDate, EndDate))
                edtStart.EditValue = EndDate.AddDays(-1);

            this.printInterval = new TimeInterval(StartDate, EndDate);
            SubscribeEvents();
            UpdateActiveReport();
        }
		void cmbLayout_SelectedIndexChanged(object sender, EventArgs e) {
			this.pagesPerWeek = cmbLayout.SelectedIndex + 1;
			UpdateActiveReport();
		}
    }
}

