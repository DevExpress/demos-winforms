using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;
using DevExpress.XtraScheduler.Design;
using DevExpress.XtraScheduler.Localization;
using DevExpress.XtraScheduler.Reporting;
using DevExpress.XtraScheduler.Reporting.UI;

namespace DevExpress.XtraScheduler.Demos.Reporting {
    public class ReportTemplateForm : XtraForm {
        #region inner classes
        public class DirectionModeItem {
            string _text;
            DirectionMode _directionMode;

            public DirectionMode DirectionMode {
                get { return _directionMode; }
            }
            public string Text {
                get { return _text; }
            }
            public DirectionModeItem(DirectionMode directionMode, string text) {
                this._directionMode = directionMode;
                this._text = text;
            }
        }
        public class ViewModeItem {
            ImageViewMode _viewMode;
            string _text;

            public ImageViewMode ViewMode {
                get { return _viewMode; }
            }
            public string Text {
                get { return _text; }
            }
            public ViewModeItem(ImageViewMode viewMode, string text) {
                this._viewMode = viewMode;
                this._text = text;
            }
        }
        public class ImageAlignItem {
            string _text;
            string _alignment;

            public string Alignment {
                get { return _alignment; }
            }
            public string Text {
                get { return _text; }
            }
            public ImageAlignItem(string alignment, string text) {
                this._alignment = alignment;
                this._text = text;
            }
        }
        class MyPrintControl : PrintControl {
            DevExpress.XtraPrinting.PrintingSystem ps;
            public MyPrintControl() {
                SetControlVisibility(new Control[] { hScrollBar, sidePanel }, false);
                ps = new DevExpress.XtraPrinting.PrintingSystem();
                PrintingSystem = ps;
                fMinZoom = 0.00001f;
            }
            void SetControlVisibility(Control[] controls, bool visible) {
                foreach(Control control in controls)
                    control.Visible = visible;
            }
            protected override void OnHandleCreated(EventArgs e) {
                base.OnHandleCreated(e);
                CreateDocument();
                ViewWholePage();
            }
            void CreateDocument() {
                ps.Begin();
                ps.Graph.Modifier = BrickModifier.Detail;
                EmptyBrick brick = new EmptyBrick();
                brick.Rect = new RectangleF(0, 0, 100, 100);
                ps.Graph.DrawBrick(brick);
                ps.End();
            }
            public void UpdateWatermark(Watermark watermark) {
                ps.Watermark.CopyFrom(watermark);
                ps.Watermark.PageRange = "";
                Invalidate(true);
            }
            protected override void Dispose(bool disposing) {
                if(disposing) {
                    ps.Dispose();
                }
                base.Dispose(disposing);
            }
        }
        #endregion

        #region Fields
        DevExpress.XtraTab.XtraTabControl xtraTabControl;
        DevExpress.XtraTab.XtraTabPage tpFormat;
        DevExpress.XtraTab.XtraTabPage tpResources;
        LabelControl labelControl1;
        protected ImageComboBoxEdit cbResourcesKind;
        protected LabelControl lblResourcesKind;
        protected CheckEdit chkPrintCustomCollection;
        protected GroupControl grpCustomCollection;
        protected LabelControl lblAvailableResource;
        protected LabelControl lblCustomResources;
        protected ListBoxControl lbResources;
        protected SimpleButton btnToCustomCollection;
        protected SimpleButton btnAllToCustomCollection;
        protected SimpleButton btnAllFromCustomCollection;
        protected SimpleButton btnFromCustomCollection;
        protected SimpleButton btnMoveUp;
        protected SimpleButton btnMoveDown;
        protected ListBoxControl lbCustomResources;
        PanelControl panelControl1;
        ReportTemplateForm.MyPrintControl pc;

        System.ComponentModel.IContainer components = null;
        DevExpress.XtraEditors.SimpleButton btnClose;
        DevExpress.XtraEditors.LabelControl lbPageRangeComment;
        LabelControl labelControl2;
        ComboBoxEdit cbReportFile;
        protected DateEdit edtEnd;
        protected DateEdit edtStart;
        protected LabelControl lblEnd;
        protected LabelControl lblStart;
        DevExpress.XtraEditors.SimpleButton btnPreview;

        XtraSchedulerReport report;
        XtraSchedulerReport previewReport;
        SchedulerControlPrintAdapter _printAdapter;
        string reportFileName = string.Empty;
        SimpleButton btnEdit;
        ResourceBaseCollection _printResources = new ResourceBaseCollection();
        #endregion

        #region Properties
        public SchedulerControlPrintAdapter PrintAdapter { get { return _printAdapter; } }
        public ResourceBaseCollection PrintResources { get { return _printResources; } }
        DateTime EndDate { get { return edtEnd.DateTime.AddDays(1); } set { edtEnd.DateTime = value.AddDays(-1); } }
        DateTime StartDate { get { return edtStart.DateTime; } set { edtStart.DateTime = value; } }
        DirectoryInfo ReportTemplateDirectoryInfo  { get { return new DirectoryInfo(DemoUtils.GetFolderRelativePath("SchedulerReportTemplates")); } }
        #endregion

        public ReportTemplateForm(SchedulerControlPrintAdapter printAdapter) {
            this._printAdapter = printAdapter;

            InitializeComponent();

            this.edtStart.DateTime = TutorialConstants.Today.AddDays(-2);
            this.edtEnd.DateTime = TutorialConstants.Today.AddDays(7);
            btnPreview.Enabled = false;
            btnEdit.Enabled = false;

            SubscribeIntervalControlsEvents();
            PopulateResourceKindItems();
            PopulateReportTemplates();
            PopulateAvailableResources();
            UpdateControlsVisibility();
        }

        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null)
                    components.Dispose();

                if(_printAdapter != null)
                    UnsubscribePrintAdapterEvents(_printAdapter);

                if(report != null) {
                    DisposeReport(report);
                    report = null;
                }
                if(this.pc != null) {
                    this.pc.Dispose();
                    this.pc = null;
                }
                if(previewReport != null) {
                    DisposeReport(previewReport);
                    previewReport = null;
                }

            }
            base.Dispose(disposing);
        }
        void DisposeReport(XtraSchedulerReport report) {
            UnsubscribePrintAdapterEvents(report.SchedulerAdapter);
            report.Dispose();
        }

        #region Windows Form Designer generated code
        void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportTemplateForm));
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.lbPageRangeComment = new DevExpress.XtraEditors.LabelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tpFormat = new DevExpress.XtraTab.XtraTabPage();
            this.edtEnd = new DevExpress.XtraEditors.DateEdit();
            this.edtStart = new DevExpress.XtraEditors.DateEdit();
            this.lblEnd = new DevExpress.XtraEditors.LabelControl();
            this.lblStart = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pc = new DevExpress.XtraScheduler.Demos.Reporting.ReportTemplateForm.MyPrintControl();
            this.tpResources = new DevExpress.XtraTab.XtraTabPage();
            this.cbResourcesKind = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.lblResourcesKind = new DevExpress.XtraEditors.LabelControl();
            this.chkPrintCustomCollection = new DevExpress.XtraEditors.CheckEdit();
            this.grpCustomCollection = new DevExpress.XtraEditors.GroupControl();
            this.lblAvailableResource = new DevExpress.XtraEditors.LabelControl();
            this.lblCustomResources = new DevExpress.XtraEditors.LabelControl();
            this.lbResources = new DevExpress.XtraEditors.ListBoxControl();
            this.btnToCustomCollection = new DevExpress.XtraEditors.SimpleButton();
            this.btnAllToCustomCollection = new DevExpress.XtraEditors.SimpleButton();
            this.btnAllFromCustomCollection = new DevExpress.XtraEditors.SimpleButton();
            this.btnFromCustomCollection = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveUp = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveDown = new DevExpress.XtraEditors.SimpleButton();
            this.lbCustomResources = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbReportFile = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.tpFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tpResources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbResourcesKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPrintCustomCollection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomCollection)).BeginInit();
            this.grpCustomCollection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCustomResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReportFile.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPreview
            // 
            resources.ApplyResources(this.btnPreview, "btnPreview");
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // lbPageRangeComment
            // 
            resources.ApplyResources(this.lbPageRangeComment, "lbPageRangeComment");
            this.lbPageRangeComment.Name = "lbPageRangeComment";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            // 
            // xtraTabControl
            // 
            resources.ApplyResources(this.xtraTabControl, "xtraTabControl");
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.tpFormat;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpFormat,
            this.tpResources});
            // 
            // tpFormat
            // 
            this.tpFormat.Controls.Add(this.edtEnd);
            this.tpFormat.Controls.Add(this.edtStart);
            this.tpFormat.Controls.Add(this.lblEnd);
            this.tpFormat.Controls.Add(this.lblStart);
            this.tpFormat.Controls.Add(this.panelControl1);
            this.tpFormat.Name = "tpFormat";
            resources.ApplyResources(this.tpFormat, "tpFormat");
            // 
            // edtEnd
            // 
            resources.ApplyResources(this.edtEnd, "edtEnd");
            this.edtEnd.Name = "edtEnd";
            this.edtEnd.Properties.AccessibleName = resources.GetString("edtEnd.Properties.AccessibleName");
            this.edtEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edtEnd.Properties.Buttons"))))});
            this.edtEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // edtStart
            // 
            resources.ApplyResources(this.edtStart, "edtStart");
            this.edtStart.Name = "edtStart";
            this.edtStart.Properties.AccessibleName = resources.GetString("edtStart.Properties.AccessibleName");
            this.edtStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edtStart.Properties.Buttons"))))});
            this.edtStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // lblEnd
            // 
            resources.ApplyResources(this.lblEnd, "lblEnd");
            this.lblEnd.Name = "lblEnd";
            // 
            // lblStart
            // 
            resources.ApplyResources(this.lblStart, "lblStart");
            this.lblStart.Name = "lblStart";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.pc);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // pc
            // 
            resources.ApplyResources(this.pc, "pc");
            this.pc.HorizontalScrollBarVisibility = DevExpress.XtraEditors.ViewInfo.ScrollBarVisibility.Hidden;
            this.pc.Name = "pc";
            this.pc.ShowPageMargins = false;
            this.pc.TabStop = false;
            this.pc.VerticalScrollBarVisibility = DevExpress.XtraEditors.ViewInfo.ScrollBarVisibility.Hidden;
            this.pc.Zoom = 0.2310606F;
            // 
            // tpResources
            // 
            this.tpResources.Controls.Add(this.cbResourcesKind);
            this.tpResources.Controls.Add(this.lblResourcesKind);
            this.tpResources.Controls.Add(this.chkPrintCustomCollection);
            this.tpResources.Controls.Add(this.grpCustomCollection);
            this.tpResources.Name = "tpResources";
            resources.ApplyResources(this.tpResources, "tpResources");
            // 
            // cbResourcesKind
            // 
            resources.ApplyResources(this.cbResourcesKind, "cbResourcesKind");
            this.cbResourcesKind.Name = "cbResourcesKind";
            this.cbResourcesKind.Properties.AccessibleName = resources.GetString("cbResourcesKind.Properties.AccessibleName");
            this.cbResourcesKind.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.cbResourcesKind.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("cbResourcesKind.Properties.Buttons"))))});
            // 
            // lblResourcesKind
            // 
            resources.ApplyResources(this.lblResourcesKind, "lblResourcesKind");
            this.lblResourcesKind.Name = "lblResourcesKind";
            // 
            // chkPrintCustomCollection
            // 
            resources.ApplyResources(this.chkPrintCustomCollection, "chkPrintCustomCollection");
            this.chkPrintCustomCollection.Name = "chkPrintCustomCollection";
            this.chkPrintCustomCollection.Properties.AutoWidth = true;
            this.chkPrintCustomCollection.Properties.Caption = resources.GetString("chkPrintCustomCollection.Properties.Caption");
            this.chkPrintCustomCollection.CheckedChanged += new System.EventHandler(this.chkPrintCustomCollection_CheckedChanged);
            // 
            // grpCustomCollection
            // 
            this.grpCustomCollection.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.grpCustomCollection.Controls.Add(this.lblAvailableResource);
            this.grpCustomCollection.Controls.Add(this.lblCustomResources);
            this.grpCustomCollection.Controls.Add(this.lbResources);
            this.grpCustomCollection.Controls.Add(this.btnToCustomCollection);
            this.grpCustomCollection.Controls.Add(this.btnAllToCustomCollection);
            this.grpCustomCollection.Controls.Add(this.btnAllFromCustomCollection);
            this.grpCustomCollection.Controls.Add(this.btnFromCustomCollection);
            this.grpCustomCollection.Controls.Add(this.btnMoveUp);
            this.grpCustomCollection.Controls.Add(this.btnMoveDown);
            this.grpCustomCollection.Controls.Add(this.lbCustomResources);
            resources.ApplyResources(this.grpCustomCollection, "grpCustomCollection");
            this.grpCustomCollection.Name = "grpCustomCollection";
            // 
            // lblAvailableResource
            // 
            resources.ApplyResources(this.lblAvailableResource, "lblAvailableResource");
            this.lblAvailableResource.Name = "lblAvailableResource";
            // 
            // lblCustomResources
            // 
            resources.ApplyResources(this.lblCustomResources, "lblCustomResources");
            this.lblCustomResources.Name = "lblCustomResources";
            // 
            // lbResources
            // 
            resources.ApplyResources(this.lbResources, "lbResources");
            this.lbResources.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.lbResources.Name = "lbResources";
            this.lbResources.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            // 
            // btnToCustomCollection
            // 
            resources.ApplyResources(this.btnToCustomCollection, "btnToCustomCollection");
            this.btnToCustomCollection.Name = "btnToCustomCollection";
            this.btnToCustomCollection.Click += new System.EventHandler(this.btnToCustomCollection_Click);
            // 
            // btnAllToCustomCollection
            // 
            resources.ApplyResources(this.btnAllToCustomCollection, "btnAllToCustomCollection");
            this.btnAllToCustomCollection.Name = "btnAllToCustomCollection";
            this.btnAllToCustomCollection.Click += new System.EventHandler(this.btnAllToCustomCollection_Click);
            // 
            // btnAllFromCustomCollection
            // 
            resources.ApplyResources(this.btnAllFromCustomCollection, "btnAllFromCustomCollection");
            this.btnAllFromCustomCollection.Name = "btnAllFromCustomCollection";
            this.btnAllFromCustomCollection.Click += new System.EventHandler(this.btnAllFromCustomCollection_Click);
            // 
            // btnFromCustomCollection
            // 
            resources.ApplyResources(this.btnFromCustomCollection, "btnFromCustomCollection");
            this.btnFromCustomCollection.Name = "btnFromCustomCollection";
            this.btnFromCustomCollection.Click += new System.EventHandler(this.btnFromCustomCollection_Click);
            // 
            // btnMoveUp
            // 
            resources.ApplyResources(this.btnMoveUp, "btnMoveUp");
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            resources.ApplyResources(this.btnMoveDown, "btnMoveDown");
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // lbCustomResources
            // 
            resources.ApplyResources(this.lbCustomResources, "lbCustomResources");
            this.lbCustomResources.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.lbCustomResources.Name = "lbCustomResources";
            this.lbCustomResources.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.LineVisible = true;
            this.labelControl1.Name = "labelControl1";
            // 
            // labelControl2
            // 
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // cbReportFile
            // 
            resources.ApplyResources(this.cbReportFile, "cbReportFile");
            this.cbReportFile.Name = "cbReportFile";
            this.cbReportFile.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("cbReportFile.Properties.Buttons")))),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbReportFile.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbReportFile.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_Properties_ButtonClick);
            this.cbReportFile.SelectedIndexChanged += new System.EventHandler(this.cbReportFile_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ReportTemplateForm
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cbReportFile);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.xtraTabControl);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportTemplateForm";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tpFormat.ResumeLayout(false);
            this.tpFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tpResources.ResumeLayout(false);
            this.tpResources.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbResourcesKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPrintCustomCollection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomCollection)).EndInit();
            this.grpCustomCollection.ResumeLayout(false);
            this.grpCustomCollection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCustomResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReportFile.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        void SubscribePrintAdapterEvents(SchedulerPrintAdapter adapter) {
            if(adapter != null)
                adapter.ValidateResources += new ResourcesValidationEventHandler(PrintAdapter_ValidateResources);
        }
        void UnsubscribePrintAdapterEvents(SchedulerPrintAdapter adapter) {
            if(adapter != null)
                adapter.ValidateResources -= new ResourcesValidationEventHandler(PrintAdapter_ValidateResources);
        }
        void SubscribeIntervalControlsEvents() {
            this.edtStart.EditValueChanged += new EventHandler(StartEditValueChanged);
            this.edtEnd.EditValueChanged += new EventHandler(EndEditValueChanged);
        }
        void UnsubscribeIntervalControlsEvents() {
            this.edtStart.EditValueChanged -= new EventHandler(StartEditValueChanged);
            this.edtEnd.EditValueChanged -= new EventHandler(EndEditValueChanged);
        }

        void StartEditValueChanged(object sender, EventArgs e) {
            UnsubscribeIntervalControlsEvents();
            if(!IsValidInterval(StartDate, EndDate))
                edtEnd.EditValue = StartDate;
            SubscribeIntervalControlsEvents();
        }
        protected internal virtual bool IsValidInterval(DateTime start, DateTime end) {
            return start <= end;
        }
        void EndEditValueChanged(object sender, EventArgs e) {
            UnsubscribeIntervalControlsEvents();
            if(!IsValidInterval(StartDate, EndDate))
                edtStart.EditValue = EndDate.AddDays(-1);
            SubscribeIntervalControlsEvents();
        }

        void PrintAdapter_ValidateResources(object sender, ResourcesValidationEventArgs e) {
            e.Resources.Clear();
            e.Resources.AddRange(PrintResources);
        }

        void PopulateResourceKindItems() {
            cbResourcesKind.Properties.Items.Add(new ImageComboBoxItem() { Description = SchedulerLocalizer.GetString(SchedulerStringId.Caption_AllResources), Value = ResourcesKind.All });
            cbResourcesKind.Properties.Items.Add(new ImageComboBoxItem() { Description = SchedulerLocalizer.GetString(SchedulerStringId.Caption_OnScreenResources), Value = ResourcesKind.OnScreen });
            cbResourcesKind.SelectedIndex = 0;
        }

        void PopulateReportTemplates() {
            FileInfo[] reportTemplates = ReportTemplateDirectoryInfo.GetFiles("*.schrepx");
            cbReportFile.Properties.Buttons[0].Visible = reportTemplates.Length != 0;
            foreach(FileInfo reportFile in reportTemplates)
                cbReportFile.Properties.Items.Add(new ReportTemplateInfo(reportFile.FullName));
            cbReportFile.SelectedIndex = 0;
        }

        void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            if(e.Button.Kind == ButtonPredefines.Ellipsis) {
                OpenFileDialog dlg = new OpenFileDialog();
                try {
                    dlg.CheckPathExists = true;
                    dlg.Filter = "Report template files (*.schrepx)|*.schrepx|All files (*.*)|*.*";
                    dlg.InitialDirectory = ReportTemplateDirectoryInfo.FullName;
                    DialogResult result = dlg.ShowDialog();
                    if(result != DialogResult.OK)
                        return;
                    UpdateReport(new ReportTemplateInfo(dlg.FileName));
                } catch(Exception ex) {
                    XtraMessageBox.Show(ex.Message, Application.ProductName);
                } finally {
                    dlg.Dispose();
                }
            }
        }

        void UpdatePreview() {
            if(previewReport == null)
                return;
            pc.PrintingSystem = previewReport.PrintingSystem;
            previewReport.ReportPrintOptions.DetailCount = 1;
            UpdateReport(previewReport);
        }

        void btnPreview_Click(object sender, EventArgs e) {
            UpdateReport(report);
            if(report != null)
                report.ShowPreview();
        }
        void btnEdit_Click(object sender, EventArgs e) {
            UpdateReport(report);
            if(report != null) {
                new SchedulerReportDesignTool(report).ShowRibbonDesignerDialog();
            }
        }
        void UpdateReport(XtraSchedulerReport report) {
            if (report == null)
                return;
            report.SchedulerAdapter.TimeInterval = new TimeInterval(StartDate, EndDate);
            UpdatePrintResources();
            report.PrintingSystem.ClearContent();
            report.CreateDocument(true);
        }

        void UpdatePrintResources() {
            PrintResources.Clear();
            ResourceBaseCollection resources = GetPrintResources();
            PrintResources.AddRange(resources);
        }
        ResourceBaseCollection GetPrintResources() {
            if(chkPrintCustomCollection.Checked)
                return GetCustomResources();

            ResourcesKind resourcesKind = (ResourcesKind)cbResourcesKind.EditValue;
            switch(resourcesKind) {
                case ResourcesKind.All:
                    return GetAvailableResources();
                case ResourcesKind.OnScreen:
                    return GetOnScreenResources();
                default:
                    return new ResourceBaseCollection();
            }
        }
        ResourceBaseCollection GetAvailableResources() {
            return PrintAdapter.SchedulerControl.DataStorage.Resources.Items;
        }
        ResourceBaseCollection GetOnScreenResources() {
            return PrintAdapter.SchedulerControl.ActiveView.GetResources();
        }
        ResourceBaseCollection GetCustomResources() {
            ResourceBaseCollection result = new ResourceBaseCollection();
            int count = lbCustomResources.ItemCount;
            for(int i = 0; i < count; i++) {
                ObjectWrapper objectWrapper = (ObjectWrapper)lbCustomResources.Items[i];
                result.Add((Resource)objectWrapper.Object);
            }
            return result;
        }

        void CreateReports() {
            CreateReport();
            CreatePreviewReport();
        }

        void CreateReport() {
            if(report != null) {
                DisposeReport(report);
            }
            this.report = CreateReportCore();
        }
        void CreatePreviewReport() {
            if(previewReport != null) {
                DisposeReport(previewReport);
            }
            this.previewReport = CreateReportCore();
        }
        XtraSchedulerReport CreateReportCore() {
            XtraSchedulerReport report = new XtraSchedulerReport();
            report.LoadLayout(reportFileName);


            if(report.SchedulerAdapter != null)
                report.SchedulerAdapter.SetSourceObject(PrintAdapter.SchedulerControl);
            else
                report.SchedulerAdapter = PrintAdapter;

            report.SchedulerAdapter.EnableSmartSync = reportFileName.ToLower().Contains("trifold");
            SubscribePrintAdapterEvents(report.SchedulerAdapter);

            report.PrintColorSchema = DemoUtils.ReportPrintColorSchema;
            return report;
        }

        void chkPrintCustomCollection_CheckedChanged(object sender, EventArgs e) {
            UpdateControlsVisibility();
        }
        void UpdateControlsVisibility() {
            bool isCustomResources = chkPrintCustomCollection.Checked;

            this.lbCustomResources.Enabled = isCustomResources;
            this.lbResources.Enabled = isCustomResources;
            this.cbResourcesKind.Enabled = !isCustomResources;

            UpdateResourceButtonsVisibility(isCustomResources);
        }
        void UpdateResourceButtonsVisibility(bool isCustomResources) {
            this.btnAllToCustomCollection.Enabled = isCustomResources && lbResources.ItemCount > 0;
            this.btnToCustomCollection.Enabled = isCustomResources && lbResources.ItemCount > 0;
            this.btnAllFromCustomCollection.Enabled = isCustomResources && lbCustomResources.ItemCount > 0;
            this.btnFromCustomCollection.Enabled = isCustomResources && lbCustomResources.ItemCount > 0;
            this.btnMoveDown.Enabled = isCustomResources;
            this.btnMoveUp.Enabled = isCustomResources;
        }
        void PopulateAvailableResources() {
            lbResources.Items.Clear();
            ResourceBaseCollection resources = GetAvailableResources();
            int count = resources.Count;
            for(int i = 0; i < count; i++)
                lbResources.Items.Add(new ObjectWrapper(resources[i], resources[i].Caption));

        }

        void btnAllToCustomCollection_Click(object sender, EventArgs e) {
            MoveAllItems(lbResources, lbCustomResources);

        }
        void btnAllFromCustomCollection_Click(object sender, EventArgs e) {
            MoveAllItems(lbCustomResources, lbResources);
        }
        void btnToCustomCollection_Click(object sender, EventArgs e) {
            MoveSelectedItems(lbResources, lbCustomResources);
        }
        void btnFromCustomCollection_Click(object sender, EventArgs e) {
            MoveSelectedItems(lbCustomResources, lbResources);
        }
        void btnMoveUp_Click(object sender, EventArgs e) {
            MoveSelectedItems(lbCustomResources, true);
        }
        void btnMoveDown_Click(object sender, EventArgs e) {
            MoveSelectedItems(lbCustomResources, false);
        }
        void MoveAllItems(ListBoxControl source, ListBoxControl target) {
            int count = source.ItemCount;
            for(int i = 0; i < count; i++)
                target.Items.Add(source.Items[i]);
            source.Items.Clear();
            UpdateResourceButtonsVisibility(true);
        }
        void MoveSelectedItems(ListBoxControl source, ListBoxControl target) {
            List<object> selectedItems = new List<object>();
            int count = source.SelectedItems.Count;
            for(int i = 0; i < count; i++) {
                object item = source.SelectedItems[i];
                target.Items.Add(item);
                selectedItems.Add(item);
            }

            for(int i = 0; i < count; i++)
                source.Items.Remove(selectedItems[i]);
            UpdateResourceButtonsVisibility(true);
        }

        void MoveSelectedItems(ListBoxControl listBox, bool moveUp) {
            if(!CanMoveItems(listBox, moveUp))
                return;
            List<int> selectedIndices = GetSelectedIndixes(listBox);
            List<object> selectedItems = GetSelectedItems(listBox);

            if(moveUp)
                MoveSelectedItemsUp(listBox, selectedIndices);
            else
                MoveSelectedItemsDown(listBox, selectedIndices);

            UpdateSelection(listBox, selectedItems);
            UpdateResourceButtonsVisibility(true);
        }
        void MoveSelectedItemsUp(ListBoxControl listBox, List<int> selectedIndices) {
            int count = selectedIndices.Count;
            for(int i = 0; i < count; i++) {
                int index = selectedIndices[i];
                object item = listBox.Items[index];
                listBox.Items.RemoveAt(index);
                listBox.Items.Insert(index - 1, item);
            }
        }

        void MoveSelectedItemsDown(ListBoxControl listBox, List<int> selectedIndices) {
            int count = selectedIndices.Count;
            for(int i = count - 1; i >= 0; i--) {
                int index = selectedIndices[i];
                object item = listBox.Items[index];
                listBox.Items.RemoveAt(index);
                listBox.Items.Insert(index + 1, item);
            }
        }
        void UpdateSelection(ListBoxControl listBox, List<object> selectedItems) {
            int count = listBox.Items.Count;
            for(int i = 0; i < count; i++) {
                bool selected = selectedItems.Contains(listBox.Items[i]);
                listBox.SetSelected(i, selected);
            }
        }
        List<int> GetSelectedIndixes(ListBoxControl listBox) {
            List<int> result = new List<int>();
            int count = listBox.SelectedIndices.Count;
            for(int i = 0; i < count; i++)
                result.Add(listBox.SelectedIndices[i]);
            return result;
        }
        List<object> GetSelectedItems(ListBoxControl listBox) {
            List<object> result = new List<object>();
            int count = listBox.SelectedItems.Count;
            for(int i = 0; i < count; i++)
                result.Add(listBox.SelectedItems[i]);
            return result;
        }
        bool CanMoveItems(ListBoxControl listBox, bool moveUp) {
            BaseListBoxControl.SelectedIndexCollection indices = listBox.SelectedIndices;
            int selectedIndexesCount = indices.Count;
            if(selectedIndexesCount == 0)
                return false;
            return moveUp ? indices[0] > 0 : indices[selectedIndexesCount - 1] < listBox.ItemCount - 1;
        }

        void cbReportFile_SelectedIndexChanged(Object sender, EventArgs e) {
            try {
                ReportTemplateInfo templateInfo = cbReportFile.SelectedItem as ReportTemplateInfo;
                if (templateInfo == null)
                    return;
                UpdateReport(templateInfo);

            } catch(Exception ex) {
                XtraMessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        void UpdateReport(ReportTemplateInfo templateInfo) {
            reportFileName = templateInfo.FullName;
            cbReportFile.Text = templateInfo.Name;
            cbReportFile.ToolTip = reportFileName;

            CreateReports();
            UpdatePreview();

            btnPreview.Enabled = reportFileName != string.Empty;
            btnEdit.Enabled = reportFileName != string.Empty;
        }
    }
    public enum ResourcesKind { All, OnScreen }

    public class ReportTemplateInfo {
        readonly string _name;
        readonly string _fullName; 

        public string Name { get { return _name; } }
        public string FullName { get { return _fullName; } }

        public ReportTemplateInfo(string fullName) {
            this._fullName = fullName;
            _name = Path.GetFileNameWithoutExtension(fullName);
        }
        public override String ToString() {
            return _name;
        }
    }
}
