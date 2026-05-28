using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraScheduler.Reporting;
using DevExpress.XtraLayout;
using DevExpress.XtraBars.Navigation;

namespace DevExpress.XtraScheduler.Demos.Reporting {
    
    /// <summary>
	/// Summary description for ModuleControl.
	/// </summary>
    /// 
    public class ReportPreviewControlBase : TutorialControl, IDemoSchedulerReport {

        DateTime _baseDate;
		public class DesignForm : DevExpress.XtraReports.UserDesigner.XRDesignFormEx {
			protected override void SaveLayout() { }
			protected override void RestoreLayout() { }
        }
        #region Fields
        private System.ComponentModel.IContainer components;
        private bool _preventUpdate;
		protected PrintBarManager fPrintBarManager;
        protected PrintControl printControl;
        
        protected SchedulerStorage fSchedulerStorage;
        protected SchedulerStoragePrintAdapter fStoragePrintAdapter;
        #endregion		
		
        public ReportPreviewControlBase() {
			InitializeComponent();
			this.fPrintBarManager = CreatePrintBarManager(printControl);
            this._baseDate = CarsDataHelper.GetStartDate();
            FillReportSourceData();
            InitAdapterTimeInterval();
            CreateReports();
        }
        #region Properties
        protected bool PreventUpdate { get { return _preventUpdate; } set { _preventUpdate = value; } }
        public SchedulerStoragePrintAdapter StoragePrintAdapter { get { return this.fStoragePrintAdapter; } }
        public SchedulerStorage SchedulerStorage { get { return this.fSchedulerStorage; } }
        public DateTime BaseDate { get { return this._baseDate; } }
        #endregion
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPreviewControlBase));
            this.printControl = new DevExpress.XtraPrinting.Control.PrintControl();
            this.fStoragePrintAdapter = new DevExpress.XtraScheduler.Reporting.SchedulerStoragePrintAdapter();
            this.fSchedulerStorage = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fStoragePrintAdapter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSchedulerStorage)).BeginInit();
            this.SuspendLayout();
            // 
            // printControl
            // 
            this.printControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printControl.IsMetric = false;
            this.printControl.Location = new System.Drawing.Point(0, 0);
            this.printControl.Name = "printControl";
            this.printControl.Size = new System.Drawing.Size(455, 396);
            this.printControl.TabIndex = 1;
            this.printControl.TabStop = false;
            this.printControl.VisibleChanged += new System.EventHandler(this.printControl_VisibleChanged);
            // 
            // fStoragePrintAdapter
            // 
            this.fStoragePrintAdapter.SchedulerStorage = this.fSchedulerStorage;
            this.fStoragePrintAdapter.TimeInterval.Duration = System.TimeSpan.Parse("1.00:00:00");
            this.fStoragePrintAdapter.TimeInterval.Start = new System.DateTime(2016, 5, 6, 0, 0, 0, 0);
            this.fStoragePrintAdapter.ValidateAppointments += new DevExpress.XtraScheduler.Reporting.AppointmentsValidationEventHandler(this.fStoragePrintAdapter_ValidateAppointments);
            // 
            // ReportPreviewControlBase
            // 
            this.Controls.Add(this.printControl);
            this.Name = "ReportPreviewControlBase";
            this.Size = new System.Drawing.Size(700, 396);
            ((System.ComponentModel.ISupportInitialize)(this.fStoragePrintAdapter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSchedulerStorage)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion        
        
        void InitializePrintingSystem(PrintingSystemBase printingSystem) {
            printingSystem.SetCommandVisibility(PrintingSystemCommand.ClosePreview, DevExpress.XtraPrinting.CommandVisibility.None);            
        }
        protected virtual void InitAdapterTimeInterval() {
            StoragePrintAdapter.TimeInterval = new TimeInterval(BaseDate, TimeSpan.FromDays(60));
        }               
		
		protected virtual void FillReportSourceData() {
            CarsDataHelper.FillStorageData(SchedulerStorage, BaseDate);
		}        
		protected virtual void UpdateReportProperties(XtraSchedulerReport otherReport) {
            otherReport.PrintColorSchema = DemoUtils.ReportPrintColorSchema;
            otherReport.SchedulerAdapter = StoragePrintAdapter;
		}        
		protected PrintBarManager CreatePrintBarManager(PrintControl pc) {
			PrintBarManager printBarManager = new PrintBarManager();
			printBarManager.Form = printControl;
			printBarManager.Initialize(pc);
			printBarManager.MainMenu.Visible = false;
			printBarManager.AllowCustomization = false;
			return printBarManager;
		}
		protected void ShowDesignerForm(Form designForm, Form parentForm) {
            designForm.MinimumSize = parentForm.MinimumSize;
            if(parentForm.WindowState == FormWindowState.Normal)
			    designForm.Bounds = parentForm.Bounds;
            designForm.WindowState = parentForm.WindowState;
			parentForm.Visible = false;
			designForm.ShowDialog();
            parentForm.Visible = true;
		}		
        private void printControl_VisibleChanged(object sender, EventArgs e) {
            if (Visible && !_preventUpdate) {
                UpdateActiveReport();                
            }
        }

        void UpdatePrintingSystemDocument(XtraSchedulerReport report) {
            if (report == null || report.PrintingSystem.Document.IsCreating == true)
                return;
            Invalidate();
            Update();
            InitializePrintingSystem(report.PrintingSystem);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument(true);
        }	
        #region IDemoSchedulerReport Members
        public  void UpdateActiveReport() {
            XtraSchedulerReport localReport = GetActiveReport();
            if (localReport == null)
                return;
            UpdateReportProperties(localReport);
            UpdatePrintingSystemDocument(localReport);
        }    
        
        #endregion
        protected virtual void CreateReports() {
        }
        protected virtual XtraSchedulerReport GetActiveReport() {
            return null;
        }

        private void fStoragePrintAdapter_ValidateAppointments(object sender, AppointmentsValidationEventArgs e) {
            DoValidateAppointments(e);
        }

        protected virtual void DoValidateAppointments(AppointmentsValidationEventArgs e) {            
        }
    }
}
