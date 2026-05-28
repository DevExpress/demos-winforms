using System;
using DevExpress.XtraScheduler.Reporting;
using DevExpress.XtraScheduler.Native;

namespace DevExpress.XtraScheduler.Demos.Reporting.DailyStyle {

	public class PreviewControl : SingleReportPreviewControl {
        private System.ComponentModel.IContainer components = null;
        protected DevExpress.XtraEditors.CheckEdit chkPrintAllAppointments;
        protected DevExpress.XtraScheduler.UI.DurationEdit cbTimeScale;
        protected DevExpress.XtraScheduler.UI.SchedulerTimeEdit steToTime;
        protected DevExpress.XtraScheduler.UI.SchedulerTimeEdit steFromTime;
        protected DevExpress.XtraEditors.DateEdit edtEnd;
        protected DevExpress.XtraEditors.DateEdit edtStart;
        DevExpress.XtraEditors.SpinEdit spinResourceCount;

        int visibleResourceCount = 0;
        int visibleDayCount = 1;
        bool printAllAppointments = false;
        TimeSpan timeScale = TimeSpan.Zero;
        TimeInterval printInterval = TimeInterval.Empty;
        DevExpress.XtraEditors.SpinEdit spinDayCount;
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
        private XtraLayout.LayoutControlItem layoutControlItem9;
        TimeOfDayInterval visibleTime = TimeOfDayInterval.Day;
        
        //SchedulerGroupType groupType = SchedulerGroupType.None;

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
		void InitializeControlValues() {
            this.visibleResourceCount = Report.VisibleResourceCount;
            this.spinResourceCount.EditValue = visibleResourceCount;
            this.spinResourceCount.Properties.MaxValue = StoragePrintAdapter.ResourceCount;

            this.visibleDayCount = Report.VisibleDayCount;
            this.spinDayCount.EditValue = this.visibleDayCount;
            this.spinDayCount.Properties.MinValue = 1;
            this.spinDayCount.Properties.MaxValue = 7;

            visibleTime = Report.VisibleTime;
            steFromTime.Time = new DateTime(visibleTime.Start.Ticks);
            steToTime.Time = new DateTime(visibleTime.End.Ticks);

            printInterval = new TimeInterval(BaseDate, BaseDate.AddDays(6));
            StartDate = printInterval.Start;
            EndDate = printInterval.End;

            timeScale = Report.TimeScale;
            cbTimeScale.EditValue = timeScale;

            printAllAppointments = Report.PrintAllAppointments;
            chkPrintAllAppointments.Checked = printAllAppointments;

		}
		protected override void UpdateReportProperties(XtraSchedulerReport otherReport) {
            StoragePrintAdapter.TimeInterval = printInterval;
            base.UpdateReportProperties(otherReport);

			Report.VisibleResourceCount = this.visibleResourceCount;
            Report.VisibleTime = this.visibleTime;
            Report.TimeScale = this.timeScale;
            Report.VisibleDayCount = this.visibleDayCount;

            Report.PrintAllAppointments = printAllAppointments;
		}
		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPreviewControlBase));
            this.chkPrintAllAppointments = new DevExpress.XtraEditors.CheckEdit();
            this.edtEnd = new DevExpress.XtraEditors.DateEdit();
            this.edtStart = new DevExpress.XtraEditors.DateEdit();
            this.cbTimeScale = new DevExpress.XtraScheduler.UI.DurationEdit();
            this.steToTime = new DevExpress.XtraScheduler.UI.SchedulerTimeEdit();
            this.steFromTime = new DevExpress.XtraScheduler.UI.SchedulerTimeEdit();
            this.spinResourceCount = new DevExpress.XtraEditors.SpinEdit();
            this.spinDayCount = new DevExpress.XtraEditors.SpinEdit();
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
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.chkPrintAllAppointments.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimeScale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.steToTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.steFromTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinResourceCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDayCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // printControl
            // 
            this.printControl.Size = new System.Drawing.Size(484, 396);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(7, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(172, 22);
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
            this.navigationPaneSettings.Location = new System.Drawing.Point(484, 0);
            this.navigationPaneSettings.Name = "navigationPaneSettings";
            this.navigationPaneSettings.PageProperties.ShowExpandButton = false;
            this.navigationPaneSettings.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPageSettings});
            this.navigationPaneSettings.RegularSize = new System.Drawing.Size(216, 396);
            this.navigationPaneSettings.SelectedPage = this.navigationPageSettings;
            this.navigationPaneSettings.Size = new System.Drawing.Size(216, 396);
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
            this.navigationPageSettings.Size = new System.Drawing.Size(186, 352);
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
            this.layoutControlSettings.Controls.Add(this.steToTime);
            this.layoutControlSettings.Controls.Add(this.chkPrintAllAppointments);
            this.layoutControlSettings.Controls.Add(this.steFromTime);
            this.layoutControlSettings.Controls.Add(this.cbTimeScale);
            this.layoutControlSettings.Controls.Add(this.spinDayCount);
            this.layoutControlSettings.Controls.Add(this.edtEnd);
            this.layoutControlSettings.Controls.Add(this.spinResourceCount);
            this.layoutControlSettings.Controls.Add(this.edtStart);
            this.layoutControlSettings.Size = new System.Drawing.Size(186, 352);
            this.layoutControlSettings.Controls.SetChildIndex(this.btnEdit, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.edtStart, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.spinResourceCount, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.edtEnd, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.spinDayCount, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.cbTimeScale, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.steFromTime, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.chkPrintAllAppointments, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.steToTime, 0);
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
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.layoutControlGroupSettings.Size = new System.Drawing.Size(186, 352);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(176, 26);
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
            this.emptySpaceItem1.Size = new System.Drawing.Size(176, 10);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);

            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 227);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(176, 115);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // chkPrintAllAppointments
            // 
            this.chkPrintAllAppointments.Location = new System.Drawing.Point(7, 211);
            this.chkPrintAllAppointments.Name = "chkPrintAllAppointments";
            this.chkPrintAllAppointments.Properties.AccessibleName = "Print all appointments";
            this.chkPrintAllAppointments.Properties.AutoWidth = true;
            this.chkPrintAllAppointments.Properties.Caption = "Print All Appointments";
            this.chkPrintAllAppointments.Size = new System.Drawing.Size(127, 19);
            this.chkPrintAllAppointments.StyleController = this.layoutControlSettings;
            this.chkPrintAllAppointments.TabIndex = 8;
            this.chkPrintAllAppointments.CheckedChanged += new System.EventHandler(this.chkPrintAllAppointments_CheckedChanged);
            // 
            // edtEnd
            // 
            this.edtEnd.EditValue = new System.DateTime(2005, 9, 5, 0, 0, 0, 0);
            this.edtEnd.Location = new System.Drawing.Point(92, 139);
            this.edtEnd.Name = "edtEnd";
            this.edtEnd.Properties.AccessibleName = "End date:";
            this.edtEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtEnd.Size = new System.Drawing.Size(87, 20);
            this.edtEnd.StyleController = this.layoutControlSettings;
            this.edtEnd.TabIndex = 16;
            // 
            // edtStart
            // 
            this.edtStart.EditValue = new System.DateTime(2005, 9, 5, 0, 0, 0, 0);
            this.edtStart.Location = new System.Drawing.Point(92, 115);
            this.edtStart.Name = "edtStart";
            this.edtStart.Properties.AccessibleName = "Start date:";
            this.edtStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtStart.Size = new System.Drawing.Size(87, 20);
            this.edtStart.StyleController = this.layoutControlSettings;
            this.edtStart.TabIndex = 15;
            // 
            // cbTimeScale
            // 
            this.cbTimeScale.EditValue = "";
            this.cbTimeScale.Location = new System.Drawing.Point(92, 91);
            this.cbTimeScale.Name = "cbTimeScale";
            this.cbTimeScale.Properties.AccessibleName = "Duration:";
            this.cbTimeScale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTimeScale.Properties.DisabledStateText = null;
            this.cbTimeScale.Properties.Items.AddRange(new object[] {
            System.TimeSpan.Parse("00:05:00"),
            System.TimeSpan.Parse("00:10:00"),
            System.TimeSpan.Parse("00:15:00"),
            System.TimeSpan.Parse("00:30:00"),
            System.TimeSpan.Parse("01:00:00"),
            System.TimeSpan.Parse("02:00:00"),
            System.TimeSpan.Parse("03:00:00"),
            System.TimeSpan.Parse("04:00:00"),
            System.TimeSpan.Parse("05:00:00"),
            System.TimeSpan.Parse("06:00:00"),
            System.TimeSpan.Parse("07:00:00"),
            System.TimeSpan.Parse("08:00:00"),
            System.TimeSpan.Parse("09:00:00"),
            System.TimeSpan.Parse("10:00:00"),
            System.TimeSpan.Parse("11:00:00"),
            System.TimeSpan.Parse("12:00:00")});
            this.cbTimeScale.Properties.ShowEmptyItem = false;
            this.cbTimeScale.Size = new System.Drawing.Size(87, 20);
            this.cbTimeScale.StyleController = this.layoutControlSettings;
            this.cbTimeScale.TabIndex = 22;
            this.cbTimeScale.SelectedIndexChanged += new System.EventHandler(this.cbDuration_SelectedIndexChanged);
            // 
            // steToTime
            // 
            this.steToTime.EditValue = new System.DateTime(2005, 8, 24, 0, 0, 0, 0);
            this.steToTime.Location = new System.Drawing.Point(92, 187);
            this.steToTime.Name = "steToTime";
            this.steToTime.Properties.AccessibleName = "Print to:";
            this.steToTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.steToTime.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.steToTime.Size = new System.Drawing.Size(87, 20);
            this.steToTime.StyleController = this.layoutControlSettings;
            this.steToTime.TabIndex = 20;
            // 
            // steFromTime
            // 
            this.steFromTime.EditValue = new System.DateTime(2005, 8, 24, 0, 0, 0, 0);
            this.steFromTime.Location = new System.Drawing.Point(92, 163);
            this.steFromTime.Name = "steFromTime";
            this.steFromTime.Properties.AccessibleName = "Print from:";
            this.steFromTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.steFromTime.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.steFromTime.Size = new System.Drawing.Size(87, 20);
            this.steFromTime.StyleController = this.layoutControlSettings;
            this.steFromTime.TabIndex = 18;
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
            this.spinResourceCount.Size = new System.Drawing.Size(87, 20);
            this.spinResourceCount.StyleController = this.layoutControlSettings;
            this.spinResourceCount.TabIndex = 38;
            // 
            // spinDayCount
            // 
            this.spinDayCount.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinDayCount.Location = new System.Drawing.Point(92, 67);
            this.spinDayCount.Name = "spinDayCount";
            this.spinDayCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinDayCount.Properties.IsFloatValue = false;
            this.spinDayCount.Properties.Mask.EditMask = "N00";
            this.spinDayCount.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinDayCount.Size = new System.Drawing.Size(87, 20);
            this.spinDayCount.StyleController = this.layoutControlSettings;
            this.spinDayCount.TabIndex = 38;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.spinResourceCount;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(176, 24);
            this.layoutControlItem2.Text = "Resource Count:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.spinDayCount;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(176, 24);
            this.layoutControlItem3.Text = "Day Count:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbTimeScale;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(176, 24);
            this.layoutControlItem4.Text = "Time S&cale:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.edtStart;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 108);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(176, 24);
            this.layoutControlItem5.Text = "Start Date:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.edtEnd;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 132);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(176, 24);
            this.layoutControlItem6.Text = "End Date:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.steFromTime;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 156);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(176, 24);
            this.layoutControlItem7.Text = "Print From:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.steToTime;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 180);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(176, 24);
            this.layoutControlItem8.Text = "Print &To:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.chkPrintAllAppointments;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 204);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(176, 23);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.chkPrintAllAppointments.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimeScale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.steToTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.steFromTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinResourceCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDayCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
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
            this.spinDayCount.EditValueChanged -= new EventHandler(spinDayCount_EditValueChanged);
            this.spinResourceCount.EditValueChanged -= new EventHandler(spinResourceCount_EditValueChanged);
            this.edtStart.EditValueChanged -= new EventHandler(StartEditValueChanged);
            this.edtEnd.EditValueChanged -= new EventHandler(EndEditValueChanged);
            this.steFromTime.EditValueChanged -= new System.EventHandler(steFromTime_EditValueChanged);
            this.steToTime.EditValueChanged -= new System.EventHandler(steToTime_EditValueChanged);
        }
        
        protected internal virtual void SubscribeEvents() {
            this.spinDayCount.EditValueChanged += new EventHandler(spinDayCount_EditValueChanged);
            this.spinResourceCount.EditValueChanged += new EventHandler(spinResourceCount_EditValueChanged);
            this.edtStart.EditValueChanged += new EventHandler(StartEditValueChanged);
            this.edtEnd.EditValueChanged += new EventHandler(EndEditValueChanged);
            this.steFromTime.EditValueChanged += new System.EventHandler(steFromTime_EditValueChanged);
            this.steToTime.EditValueChanged += new System.EventHandler(steToTime_EditValueChanged);
        }

        void spinResourceCount_EditValueChanged(object sender, EventArgs e) {
            this.visibleResourceCount = Convert.ToInt32(spinResourceCount.EditValue);
            UpdateActiveReport();
        }
        void spinDayCount_EditValueChanged(object sender, EventArgs e) {
            this.visibleDayCount = Convert.ToInt32(spinDayCount.EditValue);
            UpdateActiveReport();
        }
        void cbDuration_SelectedIndexChanged(object sender, EventArgs e) {
            this.timeScale = cbTimeScale.Duration;
            UpdateActiveReport();
        }
        void StartEditValueChanged(object sender, EventArgs e) {
            UnsubscribeEvents();
            if (!IsValidInterval(StartDate, EndDate))
                edtEnd.EditValue = StartDate;

            this.printInterval = new TimeInterval(StartDate, EndDate);
            SubscribeEvents();
            UpdateActiveReport();
        }
        protected internal virtual bool IsValidInterval(DateTime start, DateTime end) {
            return start <= end;
        }
        void EndEditValueChanged(object sender, EventArgs e) {
            UnsubscribeEvents();
            if (!IsValidInterval(StartDate, EndDate))
                edtStart.EditValue = EndDate.AddDays(-1);

            this.printInterval = new TimeInterval(StartDate, EndDate);
            SubscribeEvents();
            UpdateActiveReport();
        }

        void steFromTime_EditValueChanged(object sender, EventArgs e) {
            UpdateVisibleTime();
        }
        void steToTime_EditValueChanged(object sender, EventArgs e) {
            UpdateVisibleTime();
        }
        protected internal virtual void UpdateVisibleTime() {
            //Debug.Assert(edtStart.Time.Ticks < DateTimeHelper.DaySpan.Ticks);
            //Debug.Assert(edtEnd.Time.Ticks < DateTimeHelper.DaySpan.Ticks);
            TimeSpan start = steFromTime.Time.TimeOfDay;
            TimeSpan end = steToTime.Time.TimeOfDay;
            TimeSpan duration = end - start;
            if (duration.Ticks <= 0)
                end += DateTimeHelper.DaySpan;
            
            this.visibleTime = new TimeOfDayInterval(start, end);
            UpdateActiveReport();
        }

        private void chkPrintAllAppointments_CheckedChanged(object sender, EventArgs e) {
            printAllAppointments = chkPrintAllAppointments.Checked;
            UpdateActiveReport();
        }
    }
}

