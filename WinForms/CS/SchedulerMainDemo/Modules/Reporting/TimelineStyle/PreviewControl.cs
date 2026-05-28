using System;
using DevExpress.XtraScheduler.Reporting;

namespace DevExpress.XtraScheduler.Demos.Reporting.TimelineStyle {

	public class PreviewControl : SingleReportPreviewControl {
		private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraEditors.ComboBoxEdit cmbFirstTimeScale;
        private DevExpress.XtraEditors.SpinEdit spinResourceCount;
        protected DevExpress.XtraEditors.DateEdit edtEnd;
        protected DevExpress.XtraEditors.DateEdit edtStart;
        private DevExpress.XtraEditors.SpinEdit spinIntervalCount;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSecondTimeScale;

        TimeInterval printInterval = TimeInterval.Empty;
        int visibleResourceCount;
        int visibleIntevalCount;
        string firstLevelTimeScale;
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
        string secondLevelTimeScale;        

		public new Report Report { get { return (Report)base.Report; } }

		public PreviewControl()
		{
			// This call is required by the Windows Form Designer. 
			InitializeComponent();
            PopulateFirstLevelScaleCombo();
            PopulateSecondLevelScaleCombo();
			InitializeControlValues();
            SubscribeEvents();
		}
        private DateTime EndDate { get { return edtEnd.DateTime.AddDays(1); } set { edtEnd.DateTime = value.AddDays(-1); } }
        private DateTime StartDate { get { return edtStart.DateTime; } set { edtStart.DateTime = value; } }

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
			visibleIntevalCount = Report.VisibleIntervalCount;
            visibleResourceCount = Report.VisibleResourceCount;

            firstLevelTimeScale = Report.FirstLevelTimeScale;
            secondLevelTimeScale = Report.SecondLevelTimeScale;
            cmbFirstTimeScale.EditValue = firstLevelTimeScale;
            cmbSecondTimeScale.EditValue = secondLevelTimeScale;

            spinIntervalCount.EditValue = visibleIntevalCount;
            spinResourceCount.EditValue = visibleResourceCount;

            printInterval = new TimeInterval(BaseDate.AddDays(-30), BaseDate.AddDays(30));
            StartDate = printInterval.Start;
            EndDate = printInterval.End;
		}
		protected override void UpdateReportProperties(XtraSchedulerReport otherReport) {
            StoragePrintAdapter.TimeInterval = printInterval;

            base.UpdateReportProperties(otherReport);
            Report.VisibleResourceCount = visibleResourceCount;
            Report.VisibleIntervalCount = visibleIntevalCount;
            Report.FirstLevelTimeScale = firstLevelTimeScale;
            Report.SecondLevelTimeScale = secondLevelTimeScale;
		}
        private void PopulateFirstLevelScaleCombo() {
            cmbFirstTimeScale.Properties.Items.Clear();
            int scaleCount = Report.Scales.Count;
            for (int i = 0; i < scaleCount - 1; i++) {
                cmbFirstTimeScale.Properties.Items.Add(Report.Scales[i].DisplayName);
            }
            cmbFirstTimeScale.SelectedIndex = 0;
            firstLevelTimeScale = (string)cmbFirstTimeScale.SelectedItem;
        }
        void PopulateSecondLevelScaleCombo() {
            int index = cmbFirstTimeScale.SelectedIndex;

            cmbSecondTimeScale.Properties.Items.Clear();
            for (int i = index + 1; i < Report.Scales.Count; i++) {
                cmbSecondTimeScale.Properties.Items.Add(Report.Scales[i].DisplayName);
            }
            cmbSecondTimeScale.SelectedIndex = 0;
            secondLevelTimeScale = (string)cmbSecondTimeScale.SelectedItem;
        }

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPreviewControlBase));
            this.cmbFirstTimeScale = new DevExpress.XtraEditors.ComboBoxEdit();
            this.spinResourceCount = new DevExpress.XtraEditors.SpinEdit();
            this.edtEnd = new DevExpress.XtraEditors.DateEdit();
            this.edtStart = new DevExpress.XtraEditors.DateEdit();
            this.spinIntervalCount = new DevExpress.XtraEditors.SpinEdit();
            this.cmbSecondTimeScale = new DevExpress.XtraEditors.ComboBoxEdit();
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
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbFirstTimeScale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinResourceCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinIntervalCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSecondTimeScale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
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
            this.layoutControlSettings.Controls.Add(this.cmbSecondTimeScale);
            this.layoutControlSettings.Controls.Add(this.spinIntervalCount);
            this.layoutControlSettings.Controls.Add(this.edtEnd);
            this.layoutControlSettings.Controls.Add(this.edtStart);
            this.layoutControlSettings.Controls.Add(this.cmbFirstTimeScale);
            this.layoutControlSettings.Controls.Add(this.spinResourceCount);
            this.layoutControlSettings.Controls.SetChildIndex(this.spinResourceCount, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.btnEdit, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.cmbFirstTimeScale, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.edtStart, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.edtEnd, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.spinIntervalCount, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.cmbSecondTimeScale, 0);
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
            this.layoutControlGroupSettings.Size = new System.Drawing.Size(215, 352);
            this.layoutControlGroupSettings.TextVisible = false;
            this.layoutControlGroupSettings.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
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
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 180);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(205, 162);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // cmbFirstTimeScale
            // 
            this.cmbFirstTimeScale.EditValue = "";
            this.cmbFirstTimeScale.Location = new System.Drawing.Point(106, 139);
            this.cmbFirstTimeScale.Name = "cmbFirstTimeScale";
            this.cmbFirstTimeScale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFirstTimeScale.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbFirstTimeScale.Size = new System.Drawing.Size(102, 20);
            this.cmbFirstTimeScale.StyleController = this.layoutControlSettings;
            this.cmbFirstTimeScale.TabIndex = 5;
            // 
            // spinResourceCount
            // 
            this.spinResourceCount.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinResourceCount.Location = new System.Drawing.Point(106, 43);
            this.spinResourceCount.Name = "spinResourceCount";
            this.spinResourceCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinResourceCount.Properties.IsFloatValue = false;
            this.spinResourceCount.Properties.Mask.EditMask = "N00";
            this.spinResourceCount.Properties.MaxValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.spinResourceCount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinResourceCount.Size = new System.Drawing.Size(102, 20);
            this.spinResourceCount.StyleController = this.layoutControlSettings;
            this.spinResourceCount.TabIndex = 46;
            this.spinResourceCount.EditValueChanged += new System.EventHandler(this.spinResourceCount_EditValueChanged);
            // 
            // edtEnd
            // 
            this.edtEnd.EditValue = new System.DateTime(2005, 9, 5, 0, 0, 0, 0);
            this.edtEnd.Location = new System.Drawing.Point(106, 115);
            this.edtEnd.Name = "edtEnd";
            this.edtEnd.Properties.AccessibleName = "End date:";
            this.edtEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtEnd.Size = new System.Drawing.Size(102, 20);
            this.edtEnd.StyleController = this.layoutControlSettings;
            this.edtEnd.TabIndex = 43;
            // 
            // edtStart
            // 
            this.edtStart.EditValue = new System.DateTime(2005, 9, 5, 0, 0, 0, 0);
            this.edtStart.Location = new System.Drawing.Point(106, 91);
            this.edtStart.Name = "edtStart";
            this.edtStart.Properties.AccessibleName = "Start date:";
            this.edtStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtStart.Size = new System.Drawing.Size(102, 20);
            this.edtStart.StyleController = this.layoutControlSettings;
            this.edtStart.TabIndex = 42;
            // 
            // spinIntervalCount
            // 
            this.spinIntervalCount.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinIntervalCount.Location = new System.Drawing.Point(106, 67);
            this.spinIntervalCount.Name = "spinIntervalCount";
            this.spinIntervalCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinIntervalCount.Properties.IsFloatValue = false;
            this.spinIntervalCount.Properties.Mask.EditMask = "N00";
            this.spinIntervalCount.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinIntervalCount.Size = new System.Drawing.Size(102, 20);
            this.spinIntervalCount.StyleController = this.layoutControlSettings;
            this.spinIntervalCount.TabIndex = 48;
            this.spinIntervalCount.EditValueChanged += new System.EventHandler(this.spinIntervalCount_EditValueChanged);
            // 
            // cmbSecondTimeScale
            // 
            this.cmbSecondTimeScale.EditValue = "";
            this.cmbSecondTimeScale.Location = new System.Drawing.Point(106, 163);
            this.cmbSecondTimeScale.Name = "cmbSecondTimeScale";
            this.cmbSecondTimeScale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSecondTimeScale.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbSecondTimeScale.Size = new System.Drawing.Size(102, 20);
            this.cmbSecondTimeScale.StyleController = this.layoutControlSettings;
            this.cmbSecondTimeScale.TabIndex = 51;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.spinResourceCount;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(205, 24);
            this.layoutControlItem2.Text = "Resource Count:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.spinIntervalCount;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(205, 24);
            this.layoutControlItem3.Text = "Interval Count:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.edtStart;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(205, 24);
            this.layoutControlItem4.Text = "Start Date:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.edtEnd;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 108);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(205, 24);
            this.layoutControlItem5.Text = "End Date:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cmbFirstTimeScale;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 132);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(205, 24);
            this.layoutControlItem6.Text = "First Level Scale:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cmbSecondTimeScale;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 156);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(205, 24);
            this.layoutControlItem7.Text = "Second Level Scale:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(95, 13);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbFirstTimeScale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinResourceCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinIntervalCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSecondTimeScale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
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
        private void cmbFirstTimeScale_SelectedIndexChanged(object sender, EventArgs e) {
            firstLevelTimeScale = cmbFirstTimeScale.EditValue.ToString();

            PopulateSecondLevelScaleCombo();
			UpdateActiveReport();
		}
        private void cmbSecondTimeScale_SelectedIndexChanged(object sender, EventArgs e) {
            secondLevelTimeScale = cmbSecondTimeScale.EditValue.ToString();
            UpdateActiveReport();
        }
        private void spinResourceCount_EditValueChanged(object sender, EventArgs e) {
            visibleResourceCount = Convert.ToInt32(spinResourceCount.EditValue);
            UpdateActiveReport();
        }

        private void spinIntervalCount_EditValueChanged(object sender, EventArgs e) {
            visibleIntevalCount = Convert.ToInt32(spinIntervalCount.EditValue);
            UpdateActiveReport();
        }
        protected internal virtual void UnsubscribeEvents() {
            edtStart.EditValueChanged -= new EventHandler(StartEditValueChanged);
            edtEnd.EditValueChanged -= new EventHandler(EndEditValueChanged);
            this.cmbFirstTimeScale.SelectedIndexChanged -= new System.EventHandler(this.cmbFirstTimeScale_SelectedIndexChanged);
            this.cmbSecondTimeScale.SelectedIndexChanged -= new System.EventHandler(this.cmbSecondTimeScale_SelectedIndexChanged);

        }
        protected internal virtual void SubscribeEvents() {
            edtStart.EditValueChanged += new EventHandler(StartEditValueChanged);
            edtEnd.EditValueChanged += new EventHandler(EndEditValueChanged);
            this.cmbFirstTimeScale.SelectedIndexChanged += new System.EventHandler(this.cmbFirstTimeScale_SelectedIndexChanged);
            this.cmbSecondTimeScale.SelectedIndexChanged += new System.EventHandler(this.cmbSecondTimeScale_SelectedIndexChanged);
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

        private void EndEditValueChanged(object sender, EventArgs e) {
            UnsubscribeEvents();
            if (!IsValidInterval(StartDate, EndDate))
                edtStart.EditValue = EndDate.AddDays(-1);

            this.printInterval = new TimeInterval(StartDate, EndDate);
            SubscribeEvents();
            UpdateActiveReport();
        }

	}
}

