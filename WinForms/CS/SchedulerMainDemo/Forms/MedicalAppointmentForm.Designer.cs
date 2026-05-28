using DevExpress.XtraScheduler.UI;
namespace Modules {
    partial class MedicalAppointmentForm {
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

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalAppointmentForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.bvPrint = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.dvInfo = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.bvtPrint = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.bvbSave = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.bvbSaveAs = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.bvbClose = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.btnSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barLabel = new DevExpress.XtraBars.BarEditItem();
            this.riAppointmentLabel = new DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel();
            this.barStatus = new DevExpress.XtraBars.BarEditItem();
            this.riAppointmentStatus = new DevExpress.XtraScheduler.UI.RepositoryItemAppointmentStatus();
            this.barReminder = new DevExpress.XtraBars.BarEditItem();
            this.riDuration = new DevExpress.XtraScheduler.UI.RepositoryItemDuration();
            this.btnRecurrence = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnNext = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrevious = new DevExpress.XtraBars.BarButtonItem();
            this.btnTimeZones = new DevExpress.XtraBars.BarButtonItem();
            this.rpAppointment = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgActions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgOptions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.riAppointmentResource = new DevExpress.XtraScheduler.UI.RepositoryItemAppointmentResource();
            this.lblStartTime = new DevExpress.XtraEditors.LabelControl();
            this.edtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.tbLocation = new DevExpress.XtraEditors.TextEdit();
            this.edtStartTime = new DevExpress.XtraScheduler.UI.SchedulerTimeEdit();
            this.lblEndTime = new DevExpress.XtraEditors.LabelControl();
            this.edtEndDate = new DevExpress.XtraEditors.DateEdit();
            this.edtEndTime = new DevExpress.XtraScheduler.UI.SchedulerTimeEdit();
            this.lblLocation = new DevExpress.XtraEditors.LabelControl();
            this.edtResource = new DevExpress.XtraScheduler.UI.AppointmentResourceEdit();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tbDescription = new DevExpress.XtraEditors.MemoEdit();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMedic = new DevExpress.XtraEditors.LabelControl();
            this.lbDepartment = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbMedicName = new DevExpress.XtraEditors.LabelControl();
            this.edtBirthday = new DevExpress.XtraEditors.DateEdit();
            this.lbBirthday = new DevExpress.XtraEditors.LabelControl();
            this.lbPhone = new DevExpress.XtraEditors.LabelControl();
            this.tbPhone = new DevExpress.XtraEditors.TextEdit();
            this.edtPhoneMedic = new DevExpress.XtraEditors.TextEdit();
            this.cmbPatient = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.lbPhoneMedic = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbAdditionalInformation = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            this.backstageViewControl1.SuspendLayout();
            this.bvPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riAppointmentLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riAppointmentStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riAppointmentResource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBirthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBirthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPhoneMedic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPatient.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.ribbonControl1.AutoSizeItems = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnSaveAndClose,
            this.btnDelete,
            this.barLabel,
            this.barStatus,
            this.barReminder,
            this.btnRecurrence,
            this.btnSave,
            this.btnNext,
            this.btnPrevious,
            this.btnTimeZones});
            resources.ApplyResources(this.ribbonControl1, "ribbonControl1");
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpAppointment});
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.btnSave);
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.btnPrevious);
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.btnNext);
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.btnDelete);
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riAppointmentLabel,
            this.riAppointmentResource,
            this.riAppointmentStatus,
            this.riDuration});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ApplicationButtonClick += new System.EventHandler(this.ribbonControl1_ApplicationButtonClick);
            // 
            // backstageViewControl1
            // 
            resources.ApplyResources(this.backstageViewControl1, "backstageViewControl1");
            this.backstageViewControl1.Controls.Add(this.bvPrint);
            this.backstageViewControl1.Items.Add(this.bvtPrint);
            this.backstageViewControl1.Items.Add(this.bvbSave);
            this.backstageViewControl1.Items.Add(this.bvbSaveAs);
            this.backstageViewControl1.Items.Add(this.bvbClose);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.OwnerControl = this.ribbonControl1;
            this.backstageViewControl1.SelectedTab = this.bvtPrint;
            this.backstageViewControl1.SelectedTabIndex = 0;
            this.backstageViewControl1.Style = DevExpress.XtraBars.Ribbon.BackstageViewStyle.Office2013;
            // 
            // bvPrint
            // 
            resources.ApplyResources(this.bvPrint, "bvPrint");
            this.bvPrint.Controls.Add(this.btnPrint);
            this.bvPrint.Controls.Add(this.dvInfo);
            this.bvPrint.Name = "bvPrint";
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Name = "btnPrint";
            // 
            // dvInfo
            // 
            resources.ApplyResources(this.dvInfo, "dvInfo");
            this.dvInfo.AutoZoom = true;
            this.dvInfo.Name = "dvInfo";
            // 
            // bvtPrint
            // 
            resources.ApplyResources(this.bvtPrint, "bvtPrint");
            this.bvtPrint.ContentControl = this.bvPrint;
            this.bvtPrint.Name = "bvtPrint";
            this.bvtPrint.Selected = true;
            // 
            // bvbSave
            // 
            resources.ApplyResources(this.bvbSave, "bvbSave");
            this.bvbSave.Name = "bvbSave";
            this.bvbSave.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.bvbSave_ItemClick);
            // 
            // bvbSaveAs
            // 
            resources.ApplyResources(this.bvbSaveAs, "bvbSaveAs");
            this.bvbSaveAs.Name = "bvbSaveAs";
            this.bvbSaveAs.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.bvbSaveAs_ItemClick);
            // 
            // bvbClose
            // 
            resources.ApplyResources(this.bvbClose, "bvbClose");
            this.bvbClose.Name = "bvbClose";
            this.bvbClose.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.bvbClose_ItemClick);
            // 
            // btnSaveAndClose
            // 
            resources.ApplyResources(this.btnSaveAndClose, "btnSaveAndClose");
            this.btnSaveAndClose.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnSaveAndClose.Id = 3;
            this.btnSaveAndClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAndClose.ImageOptions.Image")));
            this.btnSaveAndClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaveAndClose.ImageOptions.LargeImage")));
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveAndClose_ItemClick);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnDelete.Id = 4;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDelete_ItemClick);
            // 
            // barLabel
            // 
            resources.ApplyResources(this.barLabel, "barLabel");
            this.barLabel.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barLabel.Edit = this.riAppointmentLabel;
            this.barLabel.Id = 8;
            this.barLabel.Name = "barLabel";
            // 
            // riAppointmentLabel
            // 
            resources.ApplyResources(this.riAppointmentLabel, "riAppointmentLabel");
            this.riAppointmentLabel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("riAppointmentLabel.Buttons"))))});
            this.riAppointmentLabel.Name = "riAppointmentLabel";
            // 
            // barStatus
            // 
            resources.ApplyResources(this.barStatus, "barStatus");
            this.barStatus.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barStatus.Edit = this.riAppointmentStatus;
            this.barStatus.Id = 11;
            this.barStatus.Name = "barStatus";
            // 
            // riAppointmentStatus
            // 
            resources.ApplyResources(this.riAppointmentStatus, "riAppointmentStatus");
            this.riAppointmentStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("riAppointmentStatus.Buttons"))))});
            this.riAppointmentStatus.Name = "riAppointmentStatus";
            // 
            // barReminder
            // 
            resources.ApplyResources(this.barReminder, "barReminder");
            this.barReminder.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barReminder.Edit = this.riDuration;
            this.barReminder.Id = 12;
            this.barReminder.Name = "barReminder";
            // 
            // riDuration
            // 
            resources.ApplyResources(this.riDuration, "riDuration");
            this.riDuration.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("riDuration.Buttons"))))});
            this.riDuration.DisabledStateText = null;
            this.riDuration.Name = "riDuration";
            this.riDuration.ShowEmptyItem = true;
            // 
            // btnRecurrence
            // 
            this.btnRecurrence.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            resources.ApplyResources(this.btnRecurrence, "btnRecurrence");
            this.btnRecurrence.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnRecurrence.Id = 17;
            this.btnRecurrence.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRecurrence.ImageOptions.Image")));
            this.btnRecurrence.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRecurrence.ImageOptions.LargeImage")));
            this.btnRecurrence.Name = "btnRecurrence";
            this.btnRecurrence.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barRecurrence_ItemClick);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnSave.Id = 1;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnNext.Id = 3;
            this.btnNext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.ImageOptions.Image")));
            this.btnNext.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNext.ImageOptions.LargeImage")));
            this.btnNext.Name = "btnNext";
            this.btnNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNext_ItemClick);
            // 
            // btnPrevious
            // 
            resources.ApplyResources(this.btnPrevious, "btnPrevious");
            this.btnPrevious.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnPrevious.Id = 4;
            this.btnPrevious.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.ImageOptions.Image")));
            this.btnPrevious.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPrevious.ImageOptions.LargeImage")));
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrevious_ItemClick);
            // 
            // btnTimeZones
            // 
            this.btnTimeZones.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            resources.ApplyResources(this.btnTimeZones, "btnTimeZones");
            this.btnTimeZones.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnTimeZones.Id = 1;
            this.btnTimeZones.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimeZones.ImageOptions.Image")));
            this.btnTimeZones.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTimeZones.ImageOptions.LargeImage")));
            this.btnTimeZones.Name = "btnTimeZones";
            this.btnTimeZones.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTimeZones_ItemClick);
            // 
            // rpAppointment
            // 
            this.rpAppointment.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgActions,
            this.rpgOptions});
            this.rpAppointment.Name = "rpAppointment";
            resources.ApplyResources(this.rpAppointment, "rpAppointment");
            // 
            // rpgActions
            // 
            this.rpgActions.AllowTextClipping = false;
            this.rpgActions.ItemLinks.Add(this.btnSaveAndClose);
            this.rpgActions.ItemLinks.Add(this.btnDelete);
            this.rpgActions.Name = "rpgActions";
            this.rpgActions.ShowCaptionButton = false;
            // 
            // rpgOptions
            // 
            this.rpgOptions.AllowTextClipping = false;
            this.rpgOptions.ItemLinks.Add(this.barLabel);
            this.rpgOptions.ItemLinks.Add(this.barStatus);
            this.rpgOptions.ItemLinks.Add(this.barReminder);
            this.rpgOptions.ItemLinks.Add(this.btnRecurrence, "C");
            this.rpgOptions.Name = "rpgOptions";
            this.rpgOptions.ShowCaptionButton = false;
            // 
            // riAppointmentResource
            // 
            resources.ApplyResources(this.riAppointmentResource, "riAppointmentResource");
            this.riAppointmentResource.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("riAppointmentResource.Buttons"))))});
            this.riAppointmentResource.Name = "riAppointmentResource";
            // 
            // lblStartTime
            // 
            resources.ApplyResources(this.lblStartTime, "lblStartTime");
            this.lblStartTime.Name = "lblStartTime";
            // 
            // edtStartDate
            // 
            resources.ApplyResources(this.edtStartDate, "edtStartDate");
            this.edtStartDate.Name = "edtStartDate";
            this.edtStartDate.Properties.AccessibleName = resources.GetString("edtStartDate.Properties.AccessibleName");
            this.edtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edtStartDate.Properties.Buttons"))))});
            this.edtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtStartDate.Properties.MaxValue = new System.DateTime(4000, 1, 1, 0, 0, 0, 0);
            // 
            // tbLocation
            // 
            resources.ApplyResources(this.tbLocation, "tbLocation");
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Properties.AccessibleName = resources.GetString("tbLocation.Properties.AccessibleName");
            // 
            // edtStartTime
            // 
            resources.ApplyResources(this.edtStartTime, "edtStartTime");
            this.edtStartTime.Name = "edtStartTime";
            this.edtStartTime.Properties.AccessibleName = resources.GetString("edtStartTime.Properties.AccessibleName");
            this.edtStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtStartTime.Properties.Mask.EditMask = resources.GetString("edtStartTime.Properties.Mask.EditMask");
            // 
            // lblEndTime
            // 
            resources.ApplyResources(this.lblEndTime, "lblEndTime");
            this.lblEndTime.Name = "lblEndTime";
            // 
            // edtEndDate
            // 
            resources.ApplyResources(this.edtEndDate, "edtEndDate");
            this.edtEndDate.Name = "edtEndDate";
            this.edtEndDate.Properties.AccessibleName = resources.GetString("edtEndDate.Properties.AccessibleName");
            this.edtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edtEndDate.Properties.Buttons"))))});
            this.edtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtEndDate.Properties.MaxValue = new System.DateTime(4000, 1, 1, 0, 0, 0, 0);
            // 
            // edtEndTime
            // 
            resources.ApplyResources(this.edtEndTime, "edtEndTime");
            this.edtEndTime.Name = "edtEndTime";
            this.edtEndTime.Properties.AccessibleName = resources.GetString("edtEndTime.Properties.AccessibleName");
            this.edtEndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtEndTime.Properties.Mask.EditMask = resources.GetString("edtEndTime.Properties.Mask.EditMask");
            // 
            // lblLocation
            // 
            resources.ApplyResources(this.lblLocation, "lblLocation");
            this.lblLocation.Name = "lblLocation";
            // 
            // edtResource
            // 
            resources.ApplyResources(this.edtResource, "edtResource");
            this.edtResource.Name = "edtResource";
            this.edtResource.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.edtResource.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edtResource.Properties.Buttons"))))});
            this.edtResource.Properties.ShowEmptyResource = false;
            // 
            // panelMain
            // 
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // tbDescription
            // 
            resources.ApplyResources(this.tbDescription, "tbDescription");
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Properties.AccessibleName = resources.GetString("tbDescription.Properties.AccessibleName");
            this.tbDescription.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            // 
            // panelDescription
            // 
            resources.ApplyResources(this.panelDescription, "panelDescription");
            this.panelDescription.Name = "panelDescription";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.lbMedicName);
            this.panel2.Controls.Add(this.edtBirthday);
            this.panel2.Controls.Add(this.lbBirthday);
            this.panel2.Controls.Add(this.lbPhone);
            this.panel2.Controls.Add(this.tbPhone);
            this.panel2.Controls.Add(this.edtPhoneMedic);
            this.panel2.Controls.Add(this.tbLocation);
            this.panel2.Controls.Add(this.backstageViewControl1);
            this.panel2.Controls.Add(this.cmbPatient);
            this.panel2.Controls.Add(this.lblLocation);
            this.panel2.Controls.Add(this.lbPhoneMedic);
            this.panel2.Controls.Add(this.edtResource);
            this.panel2.Controls.Add(this.edtEndTime);
            this.panel2.Controls.Add(this.edtEndDate);
            this.panel2.Controls.Add(this.lblEndTime);
            this.panel2.Controls.Add(this.lblStartTime);
            this.panel2.Controls.Add(this.edtStartTime);
            this.panel2.Controls.Add(this.edtStartDate);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbMedic);
            this.panel1.Controls.Add(this.lbDepartment);
            this.panel1.Controls.Add(this.pictureEdit1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lbMedic
            // 
            this.lbMedic.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lbMedic.Appearance.Font")));
            this.lbMedic.Appearance.Options.UseFont = true;
            this.lbMedic.Appearance.Options.UseTextOptions = true;
            this.lbMedic.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.lbMedic, "lbMedic");
            this.lbMedic.Name = "lbMedic";
            // 
            // lbDepartment
            // 
            this.lbDepartment.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lbDepartment.Appearance.Font")));
            this.lbDepartment.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("lbDepartment.Appearance.ForeColor")));
            this.lbDepartment.Appearance.Options.UseFont = true;
            this.lbDepartment.Appearance.Options.UseForeColor = true;
            this.lbDepartment.Appearance.Options.UseTextOptions = true;
            this.lbDepartment.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.lbDepartment, "lbDepartment");
            this.lbDepartment.Name = "lbDepartment";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.pictureEdit1, "pictureEdit1");
            this.pictureEdit1.MenuManager = this.ribbonControl1;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ShowMenu = false;
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // lbMedicName
            // 
            resources.ApplyResources(this.lbMedicName, "lbMedicName");
            this.lbMedicName.Name = "lbMedicName";
            // 
            // edtBirthday
            // 
            resources.ApplyResources(this.edtBirthday, "edtBirthday");
            this.edtBirthday.MenuManager = this.ribbonControl1;
            this.edtBirthday.Name = "edtBirthday";
            this.edtBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edtBirthday.Properties.CalendarTimeProperties.Buttons"))))});
            this.edtBirthday.Properties.ReadOnly = true;
            // 
            // lbBirthday
            // 
            resources.ApplyResources(this.lbBirthday, "lbBirthday");
            this.lbBirthday.Name = "lbBirthday";
            // 
            // lbPhone
            // 
            resources.ApplyResources(this.lbPhone, "lbPhone");
            this.lbPhone.Name = "lbPhone";
            // 
            // tbPhone
            // 
            resources.ApplyResources(this.tbPhone, "tbPhone");
            this.tbPhone.MenuManager = this.ribbonControl1;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Properties.ReadOnly = true;
            // 
            // edtPhoneMedic
            // 
            resources.ApplyResources(this.edtPhoneMedic, "edtPhoneMedic");
            this.edtPhoneMedic.MenuManager = this.ribbonControl1;
            this.edtPhoneMedic.Name = "edtPhoneMedic";
            this.edtPhoneMedic.Properties.ReadOnly = true;
            // 
            // cmbPatient
            // 
            resources.ApplyResources(this.cmbPatient, "cmbPatient");
            this.cmbPatient.MenuManager = this.ribbonControl1;
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("cmbPatient.Properties.Buttons"))))});
            this.cmbPatient.Properties.Sorted = true;
            // 
            // lbPhoneMedic
            // 
            resources.ApplyResources(this.lbPhoneMedic, "lbPhoneMedic");
            this.lbPhoneMedic.Name = "lbPhoneMedic";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbAdditionalInformation);
            this.panel3.Controls.Add(this.tbDescription);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // lbAdditionalInformation
            // 
            resources.ApplyResources(this.lbAdditionalInformation, "lbAdditionalInformation");
            this.lbAdditionalInformation.Name = "lbAdditionalInformation";
            // 
            // MedicalAppointmentForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MedicalAppointmentForm";
            this.Ribbon = this.ribbonControl1;
            this.ShowInTaskbar = false;
            this.Activated += new System.EventHandler(this.OnAppointmentFormActivated);
            this.Load += new System.EventHandler(this.OutlookAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            this.backstageViewControl1.ResumeLayout(false);
            this.bvPrint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.riAppointmentLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riAppointmentStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riAppointmentResource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBirthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBirthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPhoneMedic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPatient.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpAppointment;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgActions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgOptions;
        private DevExpress.XtraBars.BarButtonItem btnSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarEditItem barLabel;
        private RepositoryItemAppointmentLabel riAppointmentLabel;
        private RepositoryItemAppointmentResource riAppointmentResource;
        private DevExpress.XtraBars.BarEditItem barStatus;
        private RepositoryItemAppointmentStatus riAppointmentStatus;
        private DevExpress.XtraBars.BarEditItem barReminder;
        private RepositoryItemDuration riDuration;
        private DevExpress.XtraBars.BarButtonItem btnRecurrence;
        protected DevExpress.XtraEditors.LabelControl lblStartTime;
        protected DevExpress.XtraEditors.DateEdit edtStartDate;
        protected DevExpress.XtraEditors.TextEdit tbLocation;
        protected SchedulerTimeEdit edtStartTime;
        protected DevExpress.XtraEditors.LabelControl lblEndTime;
        protected DevExpress.XtraEditors.DateEdit edtEndDate;
        protected SchedulerTimeEdit edtEndTime;
        protected DevExpress.XtraEditors.LabelControl lblLocation;
        protected AppointmentResourceEdit edtResource;
        private System.Windows.Forms.Panel panelMain;
        protected DevExpress.XtraEditors.MemoEdit tbDescription;
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem bvbSave;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem bvbSaveAs;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem bvbClose;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnNext;
        private DevExpress.XtraBars.BarButtonItem btnPrevious;
        private DevExpress.XtraBars.BarButtonItem btnTimeZones;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl bvPrint;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem bvtPrint;
        private DevExpress.XtraPrinting.Preview.DocumentViewer dvInfo;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.DateEdit edtBirthday;
        private DevExpress.XtraEditors.TextEdit tbPhone;
        private DevExpress.XtraEditors.ImageComboBoxEdit cmbPatient;
        private DevExpress.XtraEditors.LabelControl lbPhone;
        private DevExpress.XtraEditors.LabelControl lbBirthday;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit edtPhoneMedic;
        private DevExpress.XtraEditors.LabelControl lbPhoneMedic;
        private DevExpress.XtraEditors.LabelControl lbMedicName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbAdditionalInformation;
        private DevExpress.XtraEditors.LabelControl lbMedic;
        private DevExpress.XtraEditors.LabelControl lbDepartment;
        private System.Windows.Forms.Panel panel1;
    }
}
