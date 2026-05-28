using System;
using System.Collections.Generic;
using DevExpress.Data.Filtering;
using DevExpress.DXperience.Demos;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.XtraGrid.Demos {
    public partial class ExcelFiltering : TutorialControl {
        public override BaseView ExportView {
            get { return bandedGridView1; }
        }
        protected override void InitXMLData(string dataFileName) {
            VehiclesData.InitOrdersData(dataFileName, gridControl1, 10000, 400);
            VehiclesData.InitColumnViewEditors(bandedGridView1);
        }
        public override bool ShowViewOptions { get { return true; } }
        public ExcelFiltering() {
            CreateWaitDialog();
            InitializeComponent();
            InitVehiclesData();
            LicenseInfo.SetToolTipController(this, gridControl1);
            bandedGridView1.HtmlImages = DemoHelper.GetTransmissionGlyphs();
            if(!MainFormHelper.TakeScreens) {
                bandedGridView1.ActiveFilterString = "InRange([ModelPrice], 25000, 80000) And (IsOutlookIntervalToday([SalesDate]) Or IsOutlookIntervalYesterday([SalesDate]))";
                bandedGridView1.MRUFiltersInfo.Add(new ViewFilter(bandedGridView1, CriteriaOperator.Parse("InRange([ModelPrice], 50000, 150000)")));
                bandedGridView1.MRUFiltersInfo.Add(new ViewFilter(bandedGridView1, CriteriaOperator.Parse("IsOutlookIntervalToday([SalesDate]) Or IsOutlookIntervalYesterday([SalesDate])")));
                bandedGridView1.MRUFiltersInfo.Add(new ViewFilter(bandedGridView1, CriteriaOperator.Parse("[SalesDate] > AddDays(LocalDateTimeToday(),-25)")));
            }
            else bandedGridView1.ActiveFilterString = "([ModelPrice] >= 25000 And [ModelPrice] <= 80000)";
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "ExcelFiltering" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "ExcelFiltering"; }
        }
        // Addding custom Filters and Data Items customization
        //<gridControl1>
        void gridView_FilterPopupExcelData(object sender, FilterPopupExcelDataEventArgs e) {
            string fieldName = e.Column.FieldName;
            if(e.Column == bcModification) {
                // Filter Items
                e.AddFilter("<image=A><nbsp>Automatic Transmission (6-speed)", "Contains([" + fieldName + "], '6A')", true);
                e.AddFilter("<image=A><nbsp>Automatic Transmission (8-speed)", "Contains([" + fieldName + "], '8A')", true);
                e.AddFilter("<image=M><nbsp>Manual Transmission (6-speed)", "Contains([" + fieldName + "], '6M')", true);
                e.AddFilter("<image=M><nbsp>Manual Transmission (7-speed)", "Contains([" + fieldName + "], '7M')", true);
                e.AddFilter("<image=V><nbsp>Variomatic Transmission", "Contains([" + fieldName + "], 'VA')", true);
                e.AddFilter("<b>Limited Edition</b>", "Contains([" + fieldName + "], 'Limited')", true);
                // Data Items
                foreach(var item in e.DataItems) {
                    if(item.Text.Contains("V6"))
                        item.HtmlText = item.Text.Replace("V6", "<b>V6</b>");
                    if(item.Text.Contains("V8"))
                        item.HtmlText = item.Text.Replace("V8", "<b>V8</b>");
                    if(item.Text.Contains("Limited"))
                        item.HtmlText = "<image=Ltd><nbsp>" + item.Text;
                }
            }
            if(e.Column == bcMPGCity) { // 12-28
                e.AddFilter("Fuel Economy (<color=@Information>High</color>)", "[" + fieldName + "]>25", true);
                e.AddFilter("Fuel Economy (<color=@Warning>Medium</color>)", "[" + fieldName + "]>=15 AND [" + fieldName + "]<=25", true);
                e.AddFilter("Fuel Economy (<color=@Critical>Low</color>)", "[" + fieldName + "]<15", true);
            }
            if(e.Column == bcMPGHighway) { // 15-36
                e.AddFilter("Fuel Economy (<color=@Information>High</color>)", "[" + fieldName + "]>20", true);
                e.AddFilter("Fuel Economy (<color=@Warning>Medium</color>)", "[" + fieldName + "]>=20 AND [" + fieldName + "]<=30", true);
                e.AddFilter("Fuel Economy (<color=@Critical>Low</color>)", "[" + fieldName + "]>20", true);
            }
            // sales from newer to older by years
            if(e.Column == bcSalesDate) {
                // using low-level API for inplace values and texts reordering
                Array.Sort(e.Values, e.DisplayTexts, YearsFromNewerToOlder.Comparer);
            }
        }
        //</gridControl1>
        #region GenerateReport
        public override bool AllowGenerateReport {
            get { return false; }
        }
        #endregion
        sealed class YearsFromNewerToOlder : IComparer<object> {
            public static IComparer<object> Comparer = new YearsFromNewerToOlder();
            YearsFromNewerToOlder() { }
            //
            int IComparer<object>.Compare(object x, object y) {
                var dateX = (DateTime)x;
                var dateY = (DateTime)y;
                var yearsResultFromNewerToOlder = dateY.Year.CompareTo(dateX.Year);
                if(yearsResultFromNewerToOlder == 0) 
                    return dateX.CompareTo(dateY);
                return yearsResultFromNewerToOlder;
            }
        }
    }
}
