namespace DevExpress.XtraScheduler.Demos {
    partial class OverviewModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.Skins.SkinPaddingEdges skinPaddingEdges1 = new DevExpress.Skins.SkinPaddingEdges();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.schedulerBarController1 = new DevExpress.XtraScheduler.UI.SchedulerBarController(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionContentContainer1 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.accordionContentContainer3 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Patient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Birthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accordionContentContainer2 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.galleryControl1 = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.accordionControl1.SuspendLayout();
            this.accordionContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1.CalendarTimeProperties)).BeginInit();
            this.accordionContentContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.accordionContentContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).BeginInit();
            this.galleryControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.Appearance.ResourceHeaderCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.schedulerControl1.Appearance.ResourceHeaderCaption.Options.UseFont = true;
            this.schedulerControl1.DataStorage = this.schedulerDataStorage1;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.MenuManager = this;
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.OptionsCustomization.AllowAppointmentConflicts = DevExpress.XtraScheduler.AppointmentConflictsMode.Custom;
            this.schedulerControl1.OptionsView.NavigationButtons.Visibility = DevExpress.XtraScheduler.NavigationButtonVisibility.Never;
            this.schedulerControl1.OptionsView.ResourceHeaders.ImageAlign = DevExpress.XtraScheduler.HeaderImageAlign.Top;
            this.schedulerControl1.OptionsView.ResourceHeaders.ImageSize = new System.Drawing.Size(120, 120);            
            this.schedulerControl1.Size = new System.Drawing.Size(809, 707);
            this.schedulerControl1.Start = new System.DateTime(2012, 12, 3, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.AgendaView.AppointmentDisplayOptions.ShowResource = true;
            this.schedulerControl1.Views.DayView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Always;
            this.schedulerControl1.Views.DayView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Always;
            this.schedulerControl1.Views.DayView.ShowWorkTimeOnly = true;
            this.schedulerControl1.Views.DayView.TimeMarkerVisibility = DevExpress.XtraScheduler.TimeMarkerVisibility.Always;
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.DayView.TimeScale = System.TimeSpan.Parse("00:10:00");
            this.schedulerControl1.Views.FullWeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.ShowWorkTimeOnly = true;
            this.schedulerControl1.Views.FullWeekView.TimeMarkerVisibility = DevExpress.XtraScheduler.TimeMarkerVisibility.Always;
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.Views.FullWeekView.TimeScale = System.TimeSpan.Parse("00:10:00");
            this.schedulerControl1.Views.GanttView.Enabled = false;
            this.schedulerControl1.Views.MonthView.Enabled = false;
            this.schedulerControl1.Views.TimelineView.Enabled = false;
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.ShowWorkTimeOnly = true;
            this.schedulerControl1.Views.WorkWeekView.TimeMarkerVisibility = DevExpress.XtraScheduler.TimeMarkerVisibility.Always;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schedulerControl1.Views.WorkWeekView.TimeScale = System.TimeSpan.Parse("00:10:00");
            this.schedulerControl1.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.schedulerControl1_EditAppointmentFormShowing);
            // 
            // schedulerBarController1
            // 
            this.schedulerBarController1.Control = this.schedulerControl1;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.schedulerControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.accordionControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1076, 707);
            this.splitContainerControl1.SplitterPosition = 809;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Controls.Add(this.accordionContentContainer1);
            this.accordionControl1.Controls.Add(this.accordionContentContainer3);
            this.accordionControl1.Controls.Add(this.accordionContentContainer2);
            this.accordionControl1.DistanceBetweenRootGroups = 0;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlElement3});
            this.accordionControl1.ExpandElementMode = DevExpress.XtraBars.Navigation.ExpandElementMode.Multiple;
            this.accordionControl1.ExpandItemOnHeaderClick = false;
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.ShowItemExpandButtons = false;
            this.accordionControl1.Size = new System.Drawing.Size(262, 707);
            this.accordionControl1.TabIndex = 2;
            this.accordionControl1.Text = "accordionControl1";
            // 
            // accordionContentContainer1
            // 
            this.accordionContentContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.accordionContentContainer1.Appearance.Options.UseBackColor = true;
            this.accordionContentContainer1.Controls.Add(this.dateNavigator1);
            this.accordionContentContainer1.Name = "accordionContentContainer1";
            this.accordionContentContainer1.Size = new System.Drawing.Size(262, 180);
            this.accordionContentContainer1.TabIndex = 1;
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.AllowDrop = false;
            this.dateNavigator1.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dateNavigator1.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dateNavigator1.CalendarHorizontalIndent = 0;
            this.dateNavigator1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNavigator1.CalendarVerticalIndent = 0;
            this.dateNavigator1.CellPadding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dateNavigator1.ColumnCount = 1;
            this.dateNavigator1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateNavigator1.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateNavigator1.Location = new System.Drawing.Point(0, 0);
            this.dateNavigator1.MonthHeaderPadding = new System.Windows.Forms.Padding(0);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.Padding = new System.Windows.Forms.Padding(10);
            this.dateNavigator1.RowCount = 1;
            this.dateNavigator1.SchedulerControl = this.schedulerControl1;
            this.dateNavigator1.Size = new System.Drawing.Size(262, 180);
            this.dateNavigator1.TabIndex = 0;
            // 
            // accordionContentContainer3
            // 
            this.accordionContentContainer3.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.accordionContentContainer3.Appearance.Options.UseBackColor = true;
            this.accordionContentContainer3.Controls.Add(this.gridControl1);
            this.accordionContentContainer3.Name = "accordionContentContainer3";
            this.accordionContentContainer3.Size = new System.Drawing.Size(262, 76);
            this.accordionContentContainer3.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(262, 76);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Patient,
            this.Birthday,
            this.Phone});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseDown);
            this.gridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseMove);
            // 
            // Patient
            // 
            this.Patient.Caption = "Patient";
            this.Patient.FieldName = "Name";
            this.Patient.Name = "Patient";
            this.Patient.OptionsColumn.AllowEdit = false;
            this.Patient.Visible = true;
            this.Patient.VisibleIndex = 0;
            this.Patient.Width = 82;
            // 
            // Birthday
            // 
            this.Birthday.Caption = "Birthday";
            this.Birthday.FieldName = "Birthday";
            this.Birthday.Name = "Birthday";
            this.Birthday.OptionsColumn.AllowEdit = false;
            this.Birthday.Visible = true;
            this.Birthday.VisibleIndex = 1;
            this.Birthday.Width = 55;
            // 
            // Phone
            // 
            this.Phone.Caption = "Phone";
            this.Phone.FieldName = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.OptionsColumn.AllowEdit = false;
            this.Phone.Visible = true;
            this.Phone.VisibleIndex = 2;
            this.Phone.Width = 63;
            // 
            // accordionContentContainer2
            // 
            this.accordionContentContainer2.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.accordionContentContainer2.Appearance.Options.UseBackColor = true;
            this.accordionContentContainer2.Controls.Add(this.galleryControl1);
            this.accordionContentContainer2.Name = "accordionContentContainer2";
            this.accordionContentContainer2.Size = new System.Drawing.Size(262, 219);
            this.accordionContentContainer2.TabIndex = 4;
            // 
            // galleryControl1
            // 
            this.galleryControl1.Controls.Add(this.galleryControlClient1);
            this.galleryControl1.DesignGalleryGroupIndex = 0;
            this.galleryControl1.DesignGalleryItemIndex = 0;
            this.galleryControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.galleryControl1.Gallery.AllowAllUp = false;
            this.galleryControl1.Gallery.AllowFilter = false;
            this.galleryControl1.Gallery.AllowMarqueeSelection = true;
            this.galleryControl1.Gallery.ColumnCount = 1;
            this.galleryControl1.Gallery.ImageSize = new System.Drawing.Size(40, 50);
            this.galleryControl1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.Multiple;
            this.galleryControl1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside;
            this.galleryControl1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            skinPaddingEdges1.Bottom = -10;
            skinPaddingEdges1.Top = -10;
            this.galleryControl1.Gallery.ItemImagePadding = skinPaddingEdges1;
            this.galleryControl1.Gallery.ShowItemText = true;
            this.galleryControl1.Gallery.StretchItems = true;
            this.galleryControl1.Location = new System.Drawing.Point(0, 0);
            this.galleryControl1.Name = "galleryControl1";
            this.galleryControl1.Size = new System.Drawing.Size(262, 219);
            this.galleryControl1.TabIndex = 0;
            this.galleryControl1.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControl1;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(241, 215);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.ContentContainer = this.accordionContentContainer1;
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement1.Text = "Calendar";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.ContentContainer = this.accordionContentContainer2;
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement2.Text = "Doctors";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.ContentContainer = this.accordionContentContainer3;
            this.accordionControlElement3.Expanded = true;
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Patients";
            // 
            // OverviewModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "OverviewModule";
            this.Size = new System.Drawing.Size(1076, 707);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.accordionControl1.ResumeLayout(false);
            this.accordionContentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            this.accordionContentContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.accordionContentContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).EndInit();
            this.galleryControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SchedulerControl schedulerControl1;
        private SchedulerDataStorage schedulerDataStorage1;
        private UI.SchedulerBarController schedulerBarController1;
        private XtraEditors.SplitContainerControl splitContainerControl1;
        private DateNavigator dateNavigator1;
        private XtraGrid.GridControl gridControl1;
        private XtraGrid.Views.Grid.GridView gridView1;
        private XtraGrid.Columns.GridColumn Patient;
        private XtraGrid.Columns.GridColumn Birthday;
        private XtraGrid.Columns.GridColumn Phone;
        private XtraBars.Navigation.AccordionControl accordionControl1;
        private XtraBars.Navigation.AccordionContentContainer accordionContentContainer1;
        private XtraBars.Navigation.AccordionContentContainer accordionContentContainer3;
        private XtraBars.Navigation.AccordionContentContainer accordionContentContainer2;
        private XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private XtraBars.Ribbon.GalleryControl galleryControl1;
        private XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
    }
}
