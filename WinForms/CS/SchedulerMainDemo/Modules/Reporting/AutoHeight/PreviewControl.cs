using System;
using DevExpress.XtraScheduler.Reporting;
using System.Windows.Forms;
using System.IO;

namespace DevExpress.XtraScheduler.Demos.Reporting.AutoHeight {

    public class PreviewControl : ReportPreviewControlBase {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.RadioGroup rgrpView;
        private MonthReport _monthReport;
        private DevExpress.XtraEditors.SpinEdit spinHeight;
        protected DevExpress.XtraEditors.CheckEdit chkCanGrow;
        protected DevExpress.XtraEditors.CheckEdit chkCanShrink;
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
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.EmptySpaceItem emptySpaceItem3;
        private TimelineReport _timelineReport;


		public PreviewControl()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
            printControl.Zoom = 0.6f;
            InitializeControlValues();
		}

        MonthReport MonthReport { get { return _monthReport; } }
        TimelineReport TimelineReport { get { return _timelineReport; } }        
        SchedulerViewType ViewType { get { return (SchedulerViewType)rgrpView.EditValue; } }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        protected override void CreateReports() {
            if (_monthReport != null)
                _monthReport.Dispose();
            this._monthReport = new MonthReport();
            if (_timelineReport != null)
                _timelineReport.Dispose();
            this._timelineReport = new TimelineReport();
        }
        protected override XtraSchedulerReport GetActiveReport() {
            if (ViewType.Equals(SchedulerViewType.Month))
                return MonthReport;
            else
                return TimelineReport;            
        }
        protected override void FillReportSourceData() {
            DemoUtils.FillReportsStorageData(SchedulerStorage);
        }
        protected override void InitAdapterTimeInterval() {
            StoragePrintAdapter.TimeInterval = new TimeInterval(DemoUtils.Date.AddDays(17), TimeSpan.FromDays(14));
        }
        void InitializeControlValues() {
            IAutoHeightReport report = (IAutoHeightReport)GetActiveReport();
            chkCanShrink.Checked = report.CellsCanShrink;
            chkCanGrow.Checked = report.CellsCanGrow;
            spinHeight.Value = (decimal)report.CellsHeight;
        }

		protected override void UpdateReportProperties(XtraSchedulerReport otherReport) {
            base.UpdateReportProperties(otherReport);
            IAutoHeightReport autoHeightReport = (IAutoHeightReport)otherReport;            
            autoHeightReport.CellsHeight =  (float)spinHeight.Value;
            autoHeightReport.CellsCanGrow = chkCanGrow.Checked;
            autoHeightReport.CellsCanShrink = chkCanShrink.Checked;            
		}
                
        
		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPreviewControlBase));
            this.rgrpView = new DevExpress.XtraEditors.RadioGroup();
            this.spinHeight = new DevExpress.XtraEditors.SpinEdit();
            this.chkCanShrink = new DevExpress.XtraEditors.CheckEdit();
            this.chkCanGrow = new DevExpress.XtraEditors.CheckEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlSettings = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroupSettings = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.navigationPaneSettings = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPageSettings = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
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
            ((System.ComponentModel.ISupportInitialize)(this.rgrpView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCanShrink.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCanGrow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // printControl
            // 
            this.printControl.Size = new System.Drawing.Size(485, 396);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(7, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(171, 22);
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
            this.navigationPaneSettings.Location = new System.Drawing.Point(485, 0);
            this.navigationPaneSettings.Name = "navigationPaneSettings";
            this.navigationPaneSettings.PageProperties.ShowExpandButton = false;
            this.navigationPaneSettings.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPageSettings});
            this.navigationPaneSettings.RegularSize = new System.Drawing.Size(215, 396);
            this.navigationPaneSettings.SelectedPage = this.navigationPageSettings;
            this.navigationPaneSettings.Size = new System.Drawing.Size(215, 396);
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
            this.navigationPageSettings.Size = new System.Drawing.Size(185, 352);
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
            this.layoutControlSettings.Controls.Add(this.spinHeight);
            this.layoutControlSettings.Controls.Add(this.chkCanGrow);
            this.layoutControlSettings.Controls.Add(this.rgrpView);
            this.layoutControlSettings.Controls.Add(this.chkCanShrink);
            this.layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1031, 142, 650, 400);
            this.layoutControlSettings.Size = new System.Drawing.Size(185, 352);
            this.layoutControlSettings.Controls.SetChildIndex(this.btnEdit, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.chkCanShrink, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.rgrpView, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.chkCanGrow, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.spinHeight, 0);
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
            this.layoutControlGroup2,
            this.emptySpaceItem3});
            this.layoutControlGroupSettings.Name = "Root";
            this.layoutControlGroupSettings.Size = new System.Drawing.Size(185, 352);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            this.layoutControlItem1.Size = new System.Drawing.Size(175, 26);
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
            this.emptySpaceItem1.Size = new System.Drawing.Size(175, 10);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 225);
            this.emptySpaceItem2.Size = new System.Drawing.Size(175, 117);
            // 
            // rgrpView
            // 
            this.rgrpView.EditValue = DevExpress.XtraScheduler.SchedulerViewType.Month;
            this.rgrpView.Location = new System.Drawing.Point(13, 67);
            this.rgrpView.MaximumSize = new System.Drawing.Size(0, 45);
            this.rgrpView.MinimumSize = new System.Drawing.Size(0, 45);
            this.rgrpView.Name = "rgrpView";
            this.rgrpView.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgrpView.Properties.Appearance.Options.UseBackColor = true;
            this.rgrpView.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgrpView.Properties.Columns = 1;
            this.rgrpView.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.SchedulerViewType.Month, "Month"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.SchedulerViewType.Timeline, "Timeline")});
            this.rgrpView.Size = new System.Drawing.Size(159, 45);
            this.rgrpView.StyleController = this.layoutControlSettings;
            this.rgrpView.TabIndex = 5;
            this.rgrpView.SelectedIndexChanged += new System.EventHandler(this.rgrpView_SelectedIndexChanged);
            // 
            // spinHeight
            // 
            this.spinHeight.EditValue = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.spinHeight.Location = new System.Drawing.Point(52, 156);
            this.spinHeight.Name = "spinHeight";
            this.spinHeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinHeight.Properties.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinHeight.Properties.IsFloatValue = false;
            this.spinHeight.Properties.Mask.EditMask = "N00";
            this.spinHeight.Properties.MaxValue = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.spinHeight.Properties.MinValue = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.spinHeight.Size = new System.Drawing.Size(120, 20);
            this.spinHeight.StyleController = this.layoutControlSettings;
            this.spinHeight.TabIndex = 39;
            this.spinHeight.EditValueChanged += new System.EventHandler(this.spinHeight_EditValueChanged);
            // 
            // chkCanShrink
            // 
            this.chkCanShrink.Location = new System.Drawing.Point(13, 180);
            this.chkCanShrink.Name = "chkCanShrink";
            this.chkCanShrink.Properties.AutoWidth = true;
            this.chkCanShrink.Properties.Caption = "Can Shrink";
            this.chkCanShrink.Size = new System.Drawing.Size(73, 19);
            this.chkCanShrink.StyleController = this.layoutControlSettings;
            this.chkCanShrink.TabIndex = 50;
            this.chkCanShrink.CheckedChanged += new System.EventHandler(this.chkCanShrink_CheckedChanged);
            // 
            // chkCanGrow
            // 
            this.chkCanGrow.Location = new System.Drawing.Point(13, 203);
            this.chkCanGrow.Name = "chkCanGrow";
            this.chkCanGrow.Properties.AutoWidth = true;
            this.chkCanGrow.Properties.Caption = "Can Grow";
            this.chkCanGrow.Size = new System.Drawing.Size(69, 19);
            this.chkCanGrow.StyleController = this.layoutControlSettings;
            this.chkCanGrow.TabIndex = 51;
            this.chkCanGrow.CheckedChanged += new System.EventHandler(this.chkCanGrow_CheckedChanged);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.rgrpView;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(163, 49);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 36);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup1.Size = new System.Drawing.Size(175, 79);
            this.layoutControlGroup1.Text = "Report Type";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.spinHeight;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(163, 24);
            this.layoutControlItem3.Text = "Height:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(35, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chkCanShrink;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(163, 23);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chkCanGrow;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 47);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(163, 23);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 125);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup2.Size = new System.Drawing.Size(175, 100);
            this.layoutControlGroup2.Text = "Cells Options";
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 115);
            this.emptySpaceItem3.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(175, 10);
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
            ((System.ComponentModel.ISupportInitialize)(this.rgrpView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCanShrink.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCanGrow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
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

        private void rgrpView_SelectedIndexChanged(object sender, EventArgs e) {           
			UpdateActiveReport();
		}        

        private void spinHeight_EditValueChanged(object sender, EventArgs e) {
            UpdateActiveReport();
        }       
        private void chkCanShrink_CheckedChanged(object sender, EventArgs e) {
            UpdateActiveReport();
        }

        private void chkCanGrow_CheckedChanged(object sender, EventArgs e) {
            UpdateActiveReport();
        }

        private void chkCompressWeekend_CheckedChanged(object sender, EventArgs e) {
            UpdateActiveReport();
        }       

	}

    public interface IAutoHeightReport {        
        bool CellsCanShrink { get; set;}
        bool CellsCanGrow { get; set;}        
        float CellsHeight { get; set;}

    }
}

