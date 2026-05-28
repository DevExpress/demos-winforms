using DevExpress.XtraScheduler.Reporting;
namespace DevExpress.XtraScheduler.Demos.Reporting {

	partial class SingleReportPreviewControl {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;              
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing) {
                if (components != null)
				    components.Dispose();
                if (Report != null) {
                    Report.Dispose();
                    _report = null;
                }
			}            
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleReportPreviewControl));
			DevExpress.XtraScheduler.TimeInterval timeInterval1 = new DevExpress.XtraScheduler.TimeInterval();
			((System.ComponentModel.ISupportInitialize)(this.fPrintBarManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fSchedulerStorage)).BeginInit();
			this.SuspendLayout();			
			// 
			// fPrintBarManager
			// 
			this.fPrintBarManager.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("fPrintBarManager.ImageStream")));
			// 
			// storagePrintAdapter
			// 
			this.fStoragePrintAdapter.SchedulerStorage = this.fSchedulerStorage;
			timeInterval1.Duration = System.TimeSpan.Parse("00:00:00");
			this.fStoragePrintAdapter.TimeInterval = timeInterval1;
			// 
			// StoragePreviewControl
			// 
			this.Name = "StoragePreviewControl";
			((System.ComponentModel.ISupportInitialize)(this.fPrintBarManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fSchedulerStorage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion		       
        

	}
}
