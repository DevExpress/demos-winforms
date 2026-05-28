using System;
using System.IO;
using DevExpress.Internal;
using DevExpress.XtraReports.UI;

namespace DevExpress.ProductsDemo.Win.Modules {
    public partial class ReportsModule : BaseModule {
        static ReportsModule() {
            string dbPath = DataDirectoryHelper.GetDataFile("nwind.db");
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetDirectoryName(dbPath));
        }
        public ReportsModule() {
            InitializeComponent();
        }
        internal override void ShowModule(bool firstShow) {
            base.ShowModule(firstShow);
            if(firstShow) {
                reportDesigner1.ContainerControl = this;
                XtraReport report = new DevExpress.ProductsDemo.Win.MasterDetailReport.Report();
                report.ReportPrintOptions.DetailCountAtDesignTime = 0;
                foreach(XtraReportBase item in report.AllControls<XtraReportBase>()) {
                    item.ReportPrintOptions.DetailCountAtDesignTime = 0;
                }
                reportDesigner1.OpenReport(report);
                MainRibbon.AutoHideEmptyItems = true;
                MainRibbon.SelectedPage = MainRibbon.MergedPages.GetPageByText("VIEW");
                MainRibbon.SelectedPage = MainRibbon.MergedPages.GetPageByName(ribbonPagePreview.Name);
                var reportControl = reportDesigner1.ActiveDesignPanel.GetService(typeof(DevExpress.XtraReports.Design.ReportTabControl)) as DevExpress.XtraReports.Design.ReportTabControl;
                if(reportControl == null || reportControl.PreviewControl == null) return;
                DevExpress.XtraBars.Docking.DockPanel documentMapDockPanel = reportControl.PreviewControl.GetDockPanel(XtraPrinting.Preview.PreviewDockPanelKind.DocumentMap);
                if(documentMapDockPanel != null) {
                    documentMapDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right;
                }
                return;
            }
            MainRibbon.SelectedPage = MainRibbon.MergedPages.GetPageByName(ribbonPagePreview.Name);
        }

        protected override bool AutoMergeRibbon { get { return true; } }
    }
}
