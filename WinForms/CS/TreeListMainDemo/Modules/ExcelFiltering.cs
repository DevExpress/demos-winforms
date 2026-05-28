using System;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Internal;

namespace DevExpress.XtraTreeList.Demos {
    public partial class ExcelFiltering : TutorialControl {
        public ExcelFiltering() {
            InitializeComponent();
            InitVehiclesData();
            LicenseInfo.SetToolTipController(this, treeList1);
        }
        public override TreeList MainControl {
            get { return treeList1; }
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "TreeListMainDemo\\Modules\\ExcelFiltering" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "ExcelFiltering"; }
        }
        // Addding custom Filters and Data Items customization
        //<treeList1>
        void TreeList_FilterPopupExcelData(object sender, FilterPopupExcelDataEventArgs e) {
            // Removing unwanted data
            if(e.Column == bcName || e.Column == bcTrademark)
                e.RemoveData(0);
            if(e.Column == bcModification || e.Column == bcBodyStyle || e.Column == bcCategory)
                e.RemoveData(null);
            // Adding custom Filters
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
                foreach(var _item in e.DataItems) {
                    if(_item.Text.Contains("V6"))
                        _item.HtmlText = _item.Text.Replace("V6", "<b>V6</b>");
                    if(_item.Text.Contains("V8"))
                        _item.HtmlText = _item.Text.Replace("V8", "<b>V8</b>");
                    if(_item.Text.Contains("Limited"))
                        _item.HtmlText = "<image=Ltd><nbsp>" + _item.Text;
                }
            }
            if(e.Column == bcMPGCity) { // 12-28
                e.AddFilter("Fuel Economy (<color=green>High</color>)", "[" + fieldName + "]>25", true);
                e.AddFilter("Fuel Economy (<color=orange>Medium</color>)", "[" + fieldName + "]>=15 AND [" + fieldName + "]<=25", true);
                e.AddFilter("Fuel Economy (<color=red>Low</color>)", "[" + fieldName + "]<15", true);
            }
            if(e.Column == bcMPGHighway) { // 15-36
                e.AddFilter("Fuel Economy (<color=green>High</color>)", "[" + fieldName + "]>30", true);
                e.AddFilter("Fuel Economy (<color=orange>Medium</color>)", "[" + fieldName + "]>=20 AND [" + fieldName + "]<=30", true);
                e.AddFilter("Fuel Economy (<color=red>Low</color>)", "[" + fieldName + "]<20", true);
            }
        }
        //</treeList1>
        #region Init Data
        void InitVehiclesData() {
            string dbFileName = DataDirectoryHelper.GetDataFile("Vehicles.xml");
            if(!string.IsNullOrEmpty(dbFileName))
                InitMDBData(dbFileName);
        }
        void InitMDBData(string dbFileName) {
            treeList1.LoadingPanelVisible = true;
            VehiclesData.InitOrdersData(dbFileName, treeList1, 10000, 400, () => {
                VehiclesData.InitEditors(treeList1);
                treeList1.HtmlImages = VehiclesData.GetTransmissionGlyphs();
                treeList1.ExpandAll();
                if(!MainFormHelper.TakeScreens) {
                    treeList1.ActiveFilterString = "InRange([ModelPrice], 25000, 80000) And (IsOutlookIntervalToday([SalesDate]) Or IsOutlookIntervalYesterday([SalesDate]))";
                    treeList1.MRUFilters.Add(new TreeListFilterInfo("InRange([ModelPrice], 50000, 150000)"));
                    treeList1.MRUFilters.Add(new TreeListFilterInfo("IsOutlookIntervalToday([SalesDate]) Or IsOutlookIntervalYesterday([SalesDate])"));
                    treeList1.MRUFilters.Add(new TreeListFilterInfo("[SalesDate] > AddDays(LocalDateTimeToday(), -25)"));
                }
                else treeList1.ActiveFilterString = "InRange([ModelPrice], 25000, 80000)";
                SubscribeEvents();
                // Hide loading panel
                treeList1.LoadingPanelVisible = false;
            });
        }
        #endregion
        #region Events
        void SubscribeEvents() {
            treeList1.ShowingEditor += TreeList_ShowingEditor;
            treeList1.CustomNodeCellEdit += TreeList_CustomNodeCellEdit;
        }
        void TreeList_CustomNodeCellEdit(object sender, GetCustomNodeCellEditEventArgs e) {
            if(treeList1.IsRootNode(e.Node))
                e.RepositoryItem = textEditForRoots;
        }
        void TreeList_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e) {
            if(treeList1.IsRootNode(treeList1.FocusedNode))
                e.Cancel = true;
        }
        #endregion
        #region Export
        public override bool AllowPrintOptions {
            get { return true; }
        }
        public override bool AllowGenerateReport {
            get { return false; }
        }
        #endregion Export
    }
}
