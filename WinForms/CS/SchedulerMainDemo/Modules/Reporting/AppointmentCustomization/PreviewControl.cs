using System;
using DevExpress.XtraScheduler.Reporting;
using DevExpress.XtraEditors;

namespace DevExpress.XtraScheduler.Demos.Reporting.AppointmentCustomization {

	public class PreviewControl : SingleReportPreviewControl {
        private System.ComponentModel.IContainer components = null;

        //bool showReminder;
        //bool showReccurence;
        
        bool allowInitAptText;
        bool allowInitAptImages;
        private CheckEdit chkAptImages;
        private CheckEdit chkAptText;
        private CheckEdit chkShowRecurrence;
        private ImageComboBoxEdit cbStatus;
        private ImageComboBoxEdit cbTimeDisplayType;
        private CheckEdit chkShowReminder;
        private CheckEdit chkStartTimeVisibility;
        private CheckEdit chkEndTimeVisibility;

        bool showStartTime;
        bool showEndTime;
        AppointmentStatusDisplayType statusDisplayType;
        AppointmentTimeDisplayType timeDisplayType;

        bool showBell;
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
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem layoutControlItem8;
        private XtraLayout.LayoutControlItem layoutControlItem9;
        private XtraLayout.EmptySpaceItem emptySpaceItem3;
        bool showRecurrence;

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
            allowInitAptText = chkAptText.Checked;
            allowInitAptImages = chkAptImages.Checked;
            
            cbTimeDisplayType.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
            showStartTime = chkStartTimeVisibility.Checked;
            showEndTime = chkEndTimeVisibility.Checked;
            showRecurrence = chkShowRecurrence.Checked;
            showBell = chkShowReminder.Checked;
		}
		protected override void UpdateReportProperties(XtraSchedulerReport otherReport) {
			base.UpdateReportProperties(otherReport);
            Report.AllowInitAppointmentText = allowInitAptText;
            Report.AllowInitAppointmentImages = allowInitAptImages;

            Report.ShowStartTime = showStartTime;
            Report.ShowEndTime = showEndTime;
            Report.StatusDisplayType = statusDisplayType;
            Report.TimeDisplayType = timeDisplayType;
            Report.ShowBell = showBell;
            Report.ShowRecurrence = showRecurrence;
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPreviewControlBase));
            this.chkAptImages = new DevExpress.XtraEditors.CheckEdit();
            this.chkAptText = new DevExpress.XtraEditors.CheckEdit();
            this.chkShowRecurrence = new DevExpress.XtraEditors.CheckEdit();
            this.cbStatus = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cbTimeDisplayType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.chkShowReminder = new DevExpress.XtraEditors.CheckEdit();
            this.chkStartTimeVisibility = new DevExpress.XtraEditors.CheckEdit();
            this.chkEndTimeVisibility = new DevExpress.XtraEditors.CheckEdit();
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.chkAptImages.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAptText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowRecurrence.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimeDisplayType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowReminder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStartTimeVisibility.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEndTimeVisibility.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // printControl
            // 
            this.printControl.Location = new System.Drawing.Point(0, 27);
            this.printControl.Size = new System.Drawing.Size(487, 384);
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
            this.btnEdit.Size = new System.Drawing.Size(169, 22);
            // 
            // navigationPaneSettings
            // 
            this.navigationPaneSettings.Controls.Add(this.navigationPageSettings);
            this.navigationPaneSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.navigationPaneSettings.ItemOrientation = System.Windows.Forms.Orientation.Vertical;
            this.navigationPaneSettings.Location = new System.Drawing.Point(487, 27);
            this.navigationPaneSettings.Name = "navigationPaneSettings";
            this.navigationPaneSettings.PageProperties.ShowExpandButton = false;
            this.navigationPaneSettings.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPageSettings});
            this.navigationPaneSettings.SelectedPage = this.navigationPageSettings;
            this.navigationPaneSettings.TabIndex = 11;
            this.navigationPaneSettings.Text = "navigationPane1";
            this.navigationPaneSettings.RegularSize = new System.Drawing.Size(213, 384);
            this.navigationPaneSettings.Size = new System.Drawing.Size(213, 384);
            // 
            // navigationPageSettings
            // 
            this.navigationPageSettings.BackgroundPadding = new System.Windows.Forms.Padding(0);
            this.navigationPageSettings.Caption = "Options";
            this.navigationPageSettings.Controls.Add(this.layoutControlSettings);
            this.navigationPageSettings.Image = ((System.Drawing.Image)(resources.GetObject("navigationPageSettings.Image")));
            this.navigationPageSettings.Name = "navigationPageSettings";
            this.navigationPageSettings.Size = new System.Drawing.Size(183, 340);
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
            this.layoutControlSettings.Controls.Add(this.chkAptImages);
            this.layoutControlSettings.Controls.Add(this.chkAptText);
            this.layoutControlSettings.Controls.Add(this.chkShowRecurrence);
            this.layoutControlSettings.Controls.Add(this.chkShowReminder);
            this.layoutControlSettings.Controls.Add(this.cbStatus);
            this.layoutControlSettings.Controls.Add(this.cbTimeDisplayType);
            this.layoutControlSettings.Controls.Add(this.chkEndTimeVisibility);
            this.layoutControlSettings.Controls.Add(this.chkStartTimeVisibility);
            this.layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1031, 142, 650, 400);
            this.layoutControlSettings.Size = new System.Drawing.Size(183, 340);
            this.layoutControlSettings.Controls.SetChildIndex(this.chkStartTimeVisibility, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.chkEndTimeVisibility, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.cbTimeDisplayType, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.cbStatus, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.chkShowReminder, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.btnEdit, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.chkShowRecurrence, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.chkAptText, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.chkAptImages, 0);
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
            this.layoutControlGroup2,
            this.layoutControlGroup1,
            this.emptySpaceItem3});
            this.layoutControlGroupSettings.Name = "Root";
            this.layoutControlGroupSettings.Size = new System.Drawing.Size(183, 340);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            this.layoutControlItem1.Size = new System.Drawing.Size(173, 26);
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
            this.emptySpaceItem1.Size = new System.Drawing.Size(173, 10);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 292);
            this.emptySpaceItem2.Size = new System.Drawing.Size(173, 38);
            // 
            // chkAptImages
            // 
            this.chkAptImages.EditValue = true;
            this.chkAptImages.Location = new System.Drawing.Point(13, 270);
            this.chkAptImages.Name = "chkAptImages";
            this.chkAptImages.Properties.Caption = "Custom Images";
            this.chkAptImages.Size = new System.Drawing.Size(157, 19);
            this.chkAptImages.StyleController = this.layoutControlSettings;
            this.chkAptImages.TabIndex = 49;
            this.chkAptImages.CheckedChanged += new System.EventHandler(this.chkAptImages_CheckedChanged);
            // 
            // chkAptText
            // 
            this.chkAptText.EditValue = true;
            this.chkAptText.Location = new System.Drawing.Point(13, 247);
            this.chkAptText.Name = "chkAptText";
            this.chkAptText.Properties.Caption = "Custom Text";
            this.chkAptText.Size = new System.Drawing.Size(157, 19);
            this.chkAptText.StyleController = this.layoutControlSettings;
            this.chkAptText.TabIndex = 48;
            this.chkAptText.CheckedChanged += new System.EventHandler(this.chkAptText_CheckedChanged);
            // 
            // chkShowRecurrence
            // 
            this.chkShowRecurrence.EditValue = true;
            this.chkShowRecurrence.Location = new System.Drawing.Point(13, 161);
            this.chkShowRecurrence.Name = "chkShowRecurrence";
            this.chkShowRecurrence.Properties.Caption = "Recurrence";
            this.chkShowRecurrence.Size = new System.Drawing.Size(157, 19);
            this.chkShowRecurrence.StyleController = this.layoutControlSettings;
            this.chkShowRecurrence.TabIndex = 74;
            this.chkShowRecurrence.CheckedChanged += new System.EventHandler(this.chkShowRecurrence_CheckedChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.EditValue = "";
            this.cbStatus.Location = new System.Drawing.Point(52, 67);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bounds", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds, -1)});
            this.cbStatus.Size = new System.Drawing.Size(118, 20);
            this.cbStatus.StyleController = this.layoutControlSettings;
            this.cbStatus.TabIndex = 73;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // cbTimeDisplayType
            // 
            this.cbTimeDisplayType.EditValue = "";
            this.cbTimeDisplayType.Location = new System.Drawing.Point(52, 91);
            this.cbTimeDisplayType.Name = "cbTimeDisplayType";
            this.cbTimeDisplayType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTimeDisplayType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Auto", DevExpress.XtraScheduler.AppointmentTimeDisplayType.Auto, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Clock", DevExpress.XtraScheduler.AppointmentTimeDisplayType.Clock, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Text", DevExpress.XtraScheduler.AppointmentTimeDisplayType.Text, -1)});
            this.cbTimeDisplayType.Size = new System.Drawing.Size(118, 20);
            this.cbTimeDisplayType.StyleController = this.layoutControlSettings;
            this.cbTimeDisplayType.TabIndex = 22;
            this.cbTimeDisplayType.SelectedIndexChanged += new System.EventHandler(this.cbTimeDisplayType_SelectedIndexChanged);
            // 
            // chkShowReminder
            // 
            this.chkShowReminder.EditValue = true;
            this.chkShowReminder.Location = new System.Drawing.Point(13, 184);
            this.chkShowReminder.Name = "chkShowReminder";
            this.chkShowReminder.Properties.Caption = "Reminder";
            this.chkShowReminder.Size = new System.Drawing.Size(157, 19);
            this.chkShowReminder.StyleController = this.layoutControlSettings;
            this.chkShowReminder.TabIndex = 13;
            this.chkShowReminder.CheckedChanged += new System.EventHandler(this.chkShowReminder_CheckedChanged);
            // 
            // chkStartTimeVisibility
            // 
            this.chkStartTimeVisibility.EditValue = true;
            this.chkStartTimeVisibility.Location = new System.Drawing.Point(13, 115);
            this.chkStartTimeVisibility.Name = "chkStartTimeVisibility";
            this.chkStartTimeVisibility.Properties.Caption = "Start Time";
            this.chkStartTimeVisibility.Size = new System.Drawing.Size(157, 19);
            this.chkStartTimeVisibility.StyleController = this.layoutControlSettings;
            this.chkStartTimeVisibility.TabIndex = 11;
            this.chkStartTimeVisibility.CheckedChanged += new System.EventHandler(this.chkStartTimeVisibility_CheckedChanged);
            // 
            // chkEndTimeVisibility
            // 
            this.chkEndTimeVisibility.EditValue = true;
            this.chkEndTimeVisibility.Location = new System.Drawing.Point(13, 138);
            this.chkEndTimeVisibility.Name = "chkEndTimeVisibility";
            this.chkEndTimeVisibility.Properties.Caption = "End Time";
            this.chkEndTimeVisibility.Size = new System.Drawing.Size(157, 19);
            this.chkEndTimeVisibility.StyleController = this.layoutControlSettings;
            this.chkEndTimeVisibility.TabIndex = 10;
            this.chkEndTimeVisibility.CheckedChanged += new System.EventHandler(this.chkEndTimeVisibility_CheckedChanged);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbStatus;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(161, 24);
            this.layoutControlItem2.Text = "Status:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(35, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbTimeDisplayType;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(161, 24);
            this.layoutControlItem3.Text = "Time:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(35, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chkStartTimeVisibility;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(161, 23);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chkEndTimeVisibility;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 71);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(161, 23);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.chkShowRecurrence;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 94);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(161, 23);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.chkShowReminder;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 117);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(161, 23);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 36);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup1.Size = new System.Drawing.Size(173, 170);
            this.layoutControlGroup1.Text = "Appointment Display Options";
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.chkAptText;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(161, 23);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.chkAptImages;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(161, 23);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 216);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup2.Size = new System.Drawing.Size(173, 76);
            this.layoutControlGroup2.Text = "Customization";
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 206);
            this.emptySpaceItem3.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(173, 10);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // PreviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PreviewControl";
            this.Size = new System.Drawing.Size(700, 411);
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
            ((System.ComponentModel.ISupportInitialize)(this.chkAptImages.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAptText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowRecurrence.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimeDisplayType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowReminder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStartTimeVisibility.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEndTimeVisibility.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
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

        private void chkAptText_CheckedChanged(object sender, EventArgs e) {
            allowInitAptText = ((CheckEdit)sender).Checked;
            UpdateActiveReport();
        }

        private void chkAptImages_CheckedChanged(object sender, EventArgs e) {
            allowInitAptImages = ((CheckEdit)sender).Checked;
            UpdateActiveReport();
        }

        private void chkStartTimeVisibility_CheckedChanged(object sender, EventArgs e) {
            showStartTime = ((CheckEdit)sender).Checked;
            UpdateActiveReport();
        }

        private void chkEndTimeVisibility_CheckedChanged(object sender, EventArgs e) {
            showEndTime = ((CheckEdit)sender).Checked;
            UpdateActiveReport();

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e) {
            statusDisplayType = (AppointmentStatusDisplayType)cbStatus.EditValue;
            UpdateActiveReport();
        }

        private void cbTimeDisplayType_SelectedIndexChanged(object sender, EventArgs e) {
            timeDisplayType = (AppointmentTimeDisplayType)cbTimeDisplayType.EditValue;
            UpdateActiveReport();
        }

        private void chkShowRecurrence_CheckedChanged(object sender, EventArgs e) {
            showRecurrence = ((CheckEdit)sender).Checked;
            UpdateActiveReport();
        }

        private void chkShowReminder_CheckedChanged(object sender, EventArgs e) {
            showBell = ((CheckEdit)sender).Checked;
            UpdateActiveReport();
        }
	}
}

