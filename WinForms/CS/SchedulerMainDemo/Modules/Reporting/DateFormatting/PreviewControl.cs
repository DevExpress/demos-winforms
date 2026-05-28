using System;
using DevExpress.XtraScheduler.Reporting;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler.Services;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.XtraScheduler.Services.Implementation;
using System.Globalization;

namespace DevExpress.XtraScheduler.Demos.Reporting.DateFormatting {

	public class PreviewControl : SingleReportPreviewControl {
        private System.ComponentModel.IContainer components = null;
        private ComboBoxEdit cmbVertAptEnd;
        private ComboBoxEdit cmbVertAptStart;
        private ComboBoxEdit cmbHorzAptEnd;
        private ComboBoxEdit cmbHorzAptStart;
        private ComboBoxEdit cmbHeaderCaptions;
        private XtraBars.Navigation.NavigationPane navigationPaneSettings;
        private XtraBars.Navigation.NavigationPage navigationPageSettings;
        private XtraLayout.LayoutControl layoutControlSettings;
        private XtraLayout.LayoutControlGroup layoutControlGroupSettings;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem7;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private XtraLayout.EmptySpaceItem emptySpaceItem3;
        private XtraLayout.EmptySpaceItem emptySpaceItem4;
        private XtraLayout.LayoutControlItem layoutControlItem3;


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
            StoragePrintAdapter.TimeInterval = new TimeInterval(BaseDate, TimeSpan.FromDays(21));
        }
		void InitializeControlValues() {
            PopulateFormatCombo(cmbHorzAptStart);
            PopulateFormatCombo(cmbHorzAptEnd);
            PopulateFormatCombo(cmbVertAptStart);
            PopulateFormatCombo(cmbVertAptEnd);

            PopulateFormatCombo(cmbHeaderCaptions);

		}
        void PopulateFormatCombo(ComboBoxEdit comboBox) {
            comboBox.Properties.Items.Clear();
            comboBox.Properties.Items.Add("Default");
            comboBox.Properties.Items.AddRange(DateTimeFormatInfo.CurrentInfo.GetAllDateTimePatterns());
            comboBox.SelectedIndex = 0;
        }
        protected override void UpdateReportProperties(XtraSchedulerReport otherReport) {
			base.UpdateReportProperties(otherReport);
            UpdateFormatServices();
		}
        public void UpdateFormatServices() {
            StoragePrintAdapter.RemoveService(typeof(IHeaderCaptionService));
            IHeaderCaptionService customHeaderCaptionService = new CustomHeaderCaptionService(cmbHeaderCaptions.Text);
            StoragePrintAdapter.AddService(typeof(IHeaderCaptionService), customHeaderCaptionService);
            
            StoragePrintAdapter.RemoveService(typeof(IAppointmentFormatStringService));
            CustomAppointmentFormatStringService customAptFormatService = new CustomAppointmentFormatStringService();
            customAptFormatService.HorizontalAppointmentStart = cmbHorzAptStart.Text;
            customAptFormatService.HorizontalAppointmentEnd = cmbHorzAptEnd.Text;
            customAptFormatService.VerticalAppointmentStart = cmbVertAptStart.Text;
            customAptFormatService.VerticalAppointmentEnd = cmbVertAptEnd.Text;
            StoragePrintAdapter.AddService(typeof(IAppointmentFormatStringService), customAptFormatService);
        }


		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPreviewControlBase));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmbHorzAptEnd = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbHorzAptStart = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbVertAptEnd = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbVertAptStart = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbHeaderCaptions = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlSettings = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroupSettings = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.navigationPaneSettings = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPageSettings = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbHorzAptEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHorzAptStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVertAptEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVertAptStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHeaderCaptions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // printControl
            // 
            this.printControl.Size = new System.Drawing.Size(416, 396);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(7, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.StyleController = this.layoutControlSettings;
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Size = new System.Drawing.Size(240, 22);
            // 
            // navigationPaneSettings
            // 
            this.navigationPaneSettings.Controls.Add(this.navigationPageSettings);
            this.navigationPaneSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.navigationPaneSettings.ItemOrientation = System.Windows.Forms.Orientation.Vertical;
            this.navigationPaneSettings.Location = new System.Drawing.Point(416, 0);
            this.navigationPaneSettings.Name = "navigationPaneSettings";
            this.navigationPaneSettings.PageProperties.ShowExpandButton = false;
            this.navigationPaneSettings.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPageSettings});
            this.navigationPaneSettings.SelectedPage = this.navigationPageSettings;
            this.navigationPaneSettings.TabIndex = 11;
            this.navigationPaneSettings.Text = "navigationPane1";
            this.navigationPaneSettings.RegularSize = new System.Drawing.Size(284, 396);
            this.navigationPaneSettings.Size = new System.Drawing.Size(284, 396);
            // 
            // navigationPageSettings
            // 
            this.navigationPageSettings.BackgroundPadding = new System.Windows.Forms.Padding(0);
            this.navigationPageSettings.Caption = "Options";
            this.navigationPageSettings.Controls.Add(this.layoutControlSettings);
            this.navigationPageSettings.Image = ((System.Drawing.Image)(resources.GetObject("navigationPageSettings.Image")));
            this.navigationPageSettings.Name = "navigationPageSettings";
            this.navigationPageSettings.Size = new System.Drawing.Size(254, 352);
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
            this.layoutControlSettings.Controls.Add(this.cmbHeaderCaptions);
            this.layoutControlSettings.Controls.Add(this.cmbHorzAptEnd);
            this.layoutControlSettings.Controls.Add(this.cmbVertAptEnd);
            this.layoutControlSettings.Controls.Add(this.cmbVertAptStart);
            this.layoutControlSettings.Controls.Add(this.cmbHorzAptStart);
            this.layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1031, 142, 650, 400);
            this.layoutControlSettings.Size = new System.Drawing.Size(254, 352);
            this.layoutControlSettings.Controls.SetChildIndex(this.btnEdit, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.cmbHorzAptStart, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.cmbVertAptStart, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.cmbVertAptEnd, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.cmbHorzAptEnd, 0);
            this.layoutControlSettings.Controls.SetChildIndex(this.cmbHeaderCaptions, 0);
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
            this.layoutControlGroup3,
            this.emptySpaceItem3,
            this.emptySpaceItem4});
            this.layoutControlGroupSettings.Name = "Root";
            this.layoutControlGroupSettings.Size = new System.Drawing.Size(254, 352);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            this.layoutControlItem1.Size = new System.Drawing.Size(244, 26);
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
            this.emptySpaceItem1.Size = new System.Drawing.Size(244, 10);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 266);
            this.emptySpaceItem2.Size = new System.Drawing.Size(244, 76);
            // 
            // cmbHorzAptEnd
            // 
            this.cmbHorzAptEnd.Location = new System.Drawing.Point(108, 91);
            this.cmbHorzAptEnd.Name = "cmbHorzAptEnd";
            this.cmbHorzAptEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.cmbHorzAptEnd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbHorzAptEnd.Size = new System.Drawing.Size(133, 20);
            this.cmbHorzAptEnd.StyleController = this.layoutControlSettings;
            this.cmbHorzAptEnd.TabIndex = 53;
            this.cmbHorzAptEnd.SelectedIndexChanged += new System.EventHandler(this.cmbHorzAptStart_SelectedIndexChanged);
            // 
            // cmbHorzAptStart
            // 
            this.cmbHorzAptStart.Location = new System.Drawing.Point(108, 67);
            this.cmbHorzAptStart.Name = "cmbHorzAptStart";
            this.cmbHorzAptStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.cmbHorzAptStart.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbHorzAptStart.Size = new System.Drawing.Size(133, 20);
            this.cmbHorzAptStart.StyleController = this.layoutControlSettings;
            this.cmbHorzAptStart.TabIndex = 51;
            this.cmbHorzAptStart.SelectedIndexChanged += new System.EventHandler(this.cmbHorzAptStart_SelectedIndexChanged);
            // 
            // cmbVertAptEnd
            // 
            this.cmbVertAptEnd.Location = new System.Drawing.Point(108, 179);
            this.cmbVertAptEnd.Name = "cmbVertAptEnd";
            this.cmbVertAptEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.cmbVertAptEnd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbVertAptEnd.Size = new System.Drawing.Size(133, 20);
            this.cmbVertAptEnd.StyleController = this.layoutControlSettings;
            this.cmbVertAptEnd.TabIndex = 53;
            this.cmbVertAptEnd.SelectedIndexChanged += new System.EventHandler(this.cmbHorzAptStart_SelectedIndexChanged);
            // 
            // cmbVertAptStart
            // 
            this.cmbVertAptStart.Location = new System.Drawing.Point(108, 155);
            this.cmbVertAptStart.Name = "cmbVertAptStart";
            this.cmbVertAptStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.cmbVertAptStart.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbVertAptStart.Size = new System.Drawing.Size(133, 20);
            this.cmbVertAptStart.StyleController = this.layoutControlSettings;
            this.cmbVertAptStart.TabIndex = 51;
            this.cmbVertAptStart.SelectedIndexChanged += new System.EventHandler(this.cmbHorzAptStart_SelectedIndexChanged);
            // 
            // cmbHeaderCaptions
            // 
            this.cmbHeaderCaptions.Location = new System.Drawing.Point(108, 243);
            this.cmbHeaderCaptions.Name = "cmbHeaderCaptions";
            this.cmbHeaderCaptions.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.cmbHeaderCaptions.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbHeaderCaptions.Size = new System.Drawing.Size(133, 20);
            this.cmbHeaderCaptions.StyleController = this.layoutControlSettings;
            this.cmbHeaderCaptions.TabIndex = 53;
            this.cmbHeaderCaptions.SelectedIndexChanged += new System.EventHandler(this.cmbHorzAptStart_SelectedIndexChanged);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cmbHorzAptStart;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(232, 24);
            this.layoutControlItem6.Text = "Start Date Format:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(91, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cmbHorzAptEnd;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(232, 24);
            this.layoutControlItem5.Text = "End Date Format:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(91, 13);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 36);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup1.Size = new System.Drawing.Size(244, 78);
            this.layoutControlGroup1.Text = "Horizontal Appointment";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cmbVertAptStart;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(232, 24);
            this.layoutControlItem2.Text = "Start Date Format:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(91, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cmbVertAptEnd;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(232, 24);
            this.layoutControlItem7.Text = "End Date Format:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(91, 13);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem7});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 124);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup2.Size = new System.Drawing.Size(244, 78);
            this.layoutControlGroup2.Text = "Vertical Appointment";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cmbHeaderCaptions;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(232, 24);
            this.layoutControlItem3.Text = "Format:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(91, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 212);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup3.Size = new System.Drawing.Size(244, 54);
            this.layoutControlGroup3.Text = "Day Headers";
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 114);
            this.emptySpaceItem3.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(244, 10);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 202);
            this.emptySpaceItem4.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem4.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(244, 10);
            this.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // PreviewControl
            // 
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbHorzAptEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHorzAptStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVertAptEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVertAptStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHeaderCaptions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private void cmbHorzAptStart_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateActiveReport();
        }

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

    }

   public class CustomHeaderCaptionService : HeaderCaptionServiceWrapper {
       string format;
        public CustomHeaderCaptionService(string format) : base(new HeaderCaptionService()) {
            this.format = format;
        }
       protected virtual string CreateFormat(string format) {
           if (format == "Default")
               return string.Empty;
           return String.Format("{{0:{0}}}", format);
       }
       public override string GetDayColumnHeaderCaption(DayHeader header) {
            return CreateFormat(format);
        }
    }
    public class CustomAppointmentFormatStringService : AppointmentFormatStringServiceWrapper {
        string _horizontalAppointmentStart;
        string _horizontalAppointmentEnd;
        string _verticalAppointmentStart;
        string _verticalAppointmentEnd;
        
        public CustomAppointmentFormatStringService(): base(new AppointmentFormatStringService()) { 
        }
        public string HorizontalAppointmentStart { get { return _horizontalAppointmentStart; } set { _horizontalAppointmentStart = value; } }
        public string HorizontalAppointmentEnd { get { return _horizontalAppointmentEnd; } set { _horizontalAppointmentEnd = value; } }
        public string VerticalAppointmentStart { get { return _verticalAppointmentStart; } set { _verticalAppointmentStart = value; } }
        public string VerticalAppointmentEnd { get { return _verticalAppointmentEnd; } set { _verticalAppointmentEnd = value; } }

        protected virtual string CreateFormat(string format) {
            if (format == "Default")
                return string.Empty;
            return String.Format("{{0:{0}}} ", format);
        }
        public override string GetHorizontalAppointmentStartFormat(IAppointmentViewInfo aptViewInfo) {
            return CreateFormat(_horizontalAppointmentStart);
        }
        public override string GetHorizontalAppointmentEndFormat(IAppointmentViewInfo aptViewInfo) {
            return CreateFormat(_horizontalAppointmentEnd);
        }
        public override string GetVerticalAppointmentStartFormat(IAppointmentViewInfo aptViewInfo) {
            return CreateFormat(_verticalAppointmentStart);
        }
        public override string GetVerticalAppointmentEndFormat(IAppointmentViewInfo aptViewInfo) {
            return CreateFormat(_verticalAppointmentEnd);
        }
        public override string GetContinueItemStartFormat(IAppointmentViewInfo aptViewInfo) {
            return base.GetContinueItemStartFormat(aptViewInfo);
        }
        public override string GetContinueItemEndFormat(IAppointmentViewInfo aptViewInfo) {
            return base.GetContinueItemEndFormat(aptViewInfo);
        }
    }
}

