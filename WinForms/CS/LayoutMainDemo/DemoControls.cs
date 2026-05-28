using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Internal;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace DevExpress.XtraLayout.Demos {
    public class TutorialControl : TutorialControlBase {
        protected override string ModulesFolder {
            get { return "LayoutMainDemo\\Modules"; }
        }
        protected override string CodeInfoFolder {
            get { return "DevExpress.XtraLayout.Demos.CodeInfo"; }
        }
        protected override void SetControlManager(Control ctrl, BarManager manager) {
            var layout = ctrl as DevExpress.XtraLayout.LayoutControl;
            if(layout != null)
                layout.MenuManager = manager;
            BaseEdit be = ctrl as BaseEdit;
            if(be != null) be.MenuManager = manager;
        }
        DataSet nwindDS;
        protected DataView GetNWindData(DataSet data, string tableName) {
            if(nwindDS == null) {
                string dbFileName = DataDirectoryHelper.GetDataFile("nwind.xml");
                if(!string.IsNullOrEmpty(dbFileName)) {
                    SetWaitDialogCaption(string.Format("Loading {0}...", tableName));
                    nwindDS = new DataSet();
                    nwindDS.ReadXml(dbFileName);
                }
                else return null;
            }
            FillTable(tableName, data, nwindDS);
            return nwindDS.Tables[tableName].DefaultView;
        }
        DataSet vehiclesDS;
        protected virtual void InitVehiclesData(VehiclesDataSet vehiclesData) {
            if(vehiclesDS == null) {
                string dbFileName = DataDirectoryHelper.GetDataFile("Vehicles.xml");
                if(!string.IsNullOrEmpty(dbFileName)) {
                    vehiclesDS = new DataSet();
                    vehiclesDS.ReadXml(dbFileName);
                }
                else return;
            }
            SetWaitDialogCaption("Loading Cars...");
            FillTable("Model", vehiclesData, vehiclesDS);
            FillTable("Trademark", vehiclesData, vehiclesDS);
            FillTable("Category", vehiclesData, vehiclesDS);
            FillTable("BodyStyle", vehiclesData, vehiclesDS);
            FillTable("TransmissionType", vehiclesData, vehiclesDS);
            UpdateModelTable(vehiclesData);
        }
        void UpdateModelTable(VehiclesDataSet vehiclesData) {
            vehiclesData.Model.BeginLoadData();
            foreach(VehiclesDataSet.ModelRow modelRow in vehiclesData.Model.Rows) {
                modelRow.Delivery_Date = TutorialConstants.Now.AddDays(TutorialConstants.Random.Next(30));
                modelRow.InStock = TutorialConstants.Random.Next(100) < 95;
            }
            vehiclesData.Model.EndLoadData();
        }
        protected void FillTable(string tableName, DataSet data, DataSet source) {
            var targetTable = data.Tables[tableName];
            var sourceTable = source.Tables[tableName];
            foreach(DataColumn sourceColumn in sourceTable.Columns) {
                var colTarget = targetTable.Columns[sourceColumn.ColumnName];
                if(colTarget != null) {
                    if(colTarget.Ordinal != sourceColumn.Ordinal)
                        colTarget.SetOrdinal(sourceColumn.Ordinal);
                    if(colTarget.DataType != sourceColumn.DataType) {
                    } /* TODO */
                }
                else { /* TODO */ }
            }
            targetTable.BeginLoadData();
            foreach(DataRow row in sourceTable.Rows) {
                var targetRow = targetTable.NewRow();
                targetRow.ItemArray = row.ItemArray;
                targetTable.Rows.Add(targetRow);
            }
            targetTable.EndLoadData();
        }
        #region Print and Export
        public virtual LayoutControl ExportControl {
            get { return null; }
        }
        protected override void AllowExport() {
            EnabledPrintExportActions(true, ExportFormats.PDF | ExportFormats.HTML | ExportFormats.MHT | ExportFormats.XLS |
                ExportFormats.RTF | ExportFormats.Text | ExportFormats.XLSX, false);
        }
        public override bool AllowPrintOptions {
            get { return ExportControl != null; }
        }
        protected override void ExportToCore(String filename, string ext) {
            if(ExportControl == null)
                return;
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if(ext == "rtf") ExportControl.ExportToRtf(filename);
            if(ext == "pdf") ExportControl.ExportToPdf(filename);
            if(ext == "mht") ExportControl.ExportToMht(filename);
            if(ext == "html") ExportControl.ExportToHtml(filename);
            if(ext == "txt") ExportControl.ExportToText(filename);
            if(ext == "xls") ExportControl.ExportToXls(filename);
            if(ext == "xlsx") ExportControl.ExportToXlsx(filename);
            Cursor.Current = currentCursor;
        }
        protected override void ExportToPDF() {
            ExportTo("pdf", "PDF document (*.pdf)|*.pdf");
        }
        protected override void ExportToHTML() {
            ExportTo("html", "HTML document (*.html)|*.html");
        }
        protected override void ExportToMHT() {
            ExportTo("mht", "MHT document (*.mht)|*.mht");
        }
        protected override void ExportToXLS() {
            ExportTo("xls", "XLS document (*.xls)|*.xls");
        }
        protected override void ExportToXLSX() {
            ExportTo("xlsx", "XLSX document (*.xlsx)|*.xlsx");
        }
        protected override void ExportToRTF() {
            ExportTo("rtf", "RTF document (*.rtf)|*.rtf");
        }
        protected override void ExportToText() {
            ExportTo("txt", "Text document (*.txt)|*.txt");
        }
        protected override void PrintPreview() {
            if(this.ExportControl != null) {
                if(RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm)
                    this.ExportControl.ShowRibbonPrintPreview();
                else this.ExportControl.ShowPrintPreview();
            }
        }
        #endregion
    }
}
