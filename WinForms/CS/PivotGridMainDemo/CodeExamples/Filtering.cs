using DevExpress.Internal;
using System.Data;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using DevExpress.Utils;
using System.Linq;

namespace DevExpress.XtraPivotGrid.Demos.CodeExamples {
    [CodeExampleClass("Classic Filter Popup", "Filtering.cs")]
    public static class Filtering {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            PivotGridControl pivotGridControl = new PivotGridControl();
            pivotGridControl.BeginInit();
            pivotGridControl.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized;

            pivotGridControl.Fields.Add(new PivotGridField() { Area = PivotArea.RowArea, DataBinding = new DataSourceColumnBinding("ProductName"), Name = "fieldProductName" });
            pivotGridControl.Fields.Add(new PivotGridField() { Area = PivotArea.FilterArea, DataBinding = new DataSourceColumnBinding("OrderDate", PivotGroupInterval.DateYear), Name = "fieldYear", Caption = "Year" });
            pivotGridControl.Fields.Add(new PivotGridField() { Area = PivotArea.DataArea, DataBinding = new DataSourceColumnBinding("Quantity"), Name = "fieldQuantity", SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Sum });
            pivotGridControl.Fields.Add(new PivotGridField() { Area = PivotArea.DataArea, DataBinding = new DataSourceColumnBinding("Extended Price"), Name = "fieldExtendedPrice", SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Sum });

            pivotGridControl.OptionsFilterPopup.FieldFilterPopupMode = FieldFilterPopupMode.Classic;
            pivotGridControl.Dock = DockStyle.Fill;
            pivotGridControl.OptionsView.ShowRowTotals = false;
            pivotGridControl.OptionsView.ShowRowGrandTotals = false;

            string dbFileName = DataDirectoryHelper.GetDataFile("nwind.xml");
            if(!string.IsNullOrEmpty(dbFileName)) {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(dbFileName);
                pivotGridControl.DataSource = dataSet.Tables["SalesPerson"].DefaultView;
            }
            pivotGridControl.EndInit();
            pivotGridControl.Parent = sampleHost;
            pivotGridControl.BestFitDataHeaders(true);

            Timer showPopupTimer = new Timer();
            showPopupTimer.Interval = 500;
            sampleHost.Tag = showPopupTimer;

            return new object[] { pivotGridControl, showPopupTimer };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            Timer timer = sampleHost.Tag as Timer;
            if(timer != null) timer.Dispose();
            (sampleHost.Controls[0] as PivotGridControl).Dispose();
        }

        [CodeExampleCase("Field Filter Popup")]
        [CodeExampleUnderlineTokens("ShowToolbar", "FieldFilterPopupMode", "Classic", "FilterPopupToolbarButtons")]
        [CodeExampleDataFile("nwind.xml")]
        public static void FieldFilterPopup(PivotGridControl pivotGridControl, Timer showPopupTimer) {
            pivotGridControl.OptionsFilterPopup.FieldFilterPopupMode = FieldFilterPopupMode.Classic;
            System.Action<PivotGridControl, FilterPopupToolbarButtons, bool> setToolbarButtonVisibility = (pivot, button, visibility) => {
                if(visibility)
                    pivot.OptionsFilterPopup.ToolbarButtons |= button;
                else
                    pivot.OptionsFilterPopup.ToolbarButtons &= ~button;
            };
            PivotGridField categoryField = new PivotGridField() {
                Area = PivotArea.FilterArea,
                DataBinding = new DataSourceColumnBinding("CategoryName"),
                Name = "fieldCategory"
            };
            pivotGridControl.Fields.Add(categoryField);
            pivotGridControl.OptionsFilterPopup.ShowToolbar = true;
            pivotGridControl.OptionsFilterPopup.ShowOnlyAvailableItems = true;

            setToolbarButtonVisibility(pivotGridControl, FilterPopupToolbarButtons.ShowOnlyAvailableItems, true);
            setToolbarButtonVisibility(pivotGridControl, FilterPopupToolbarButtons.IncrementalSearch, true);
            setToolbarButtonVisibility(pivotGridControl, FilterPopupToolbarButtons.InvertFilter, true);
            setToolbarButtonVisibility(pivotGridControl, FilterPopupToolbarButtons.MultiSelection, true);
            setToolbarButtonVisibility(pivotGridControl, FilterPopupToolbarButtons.RadioMode, true);
            setToolbarButtonVisibility(pivotGridControl, FilterPopupToolbarButtons.ShowNewValues, true);

            categoryField.FilterValues.ValuesIncluded = new object[] { "Beverages" };
            PivotGridField fieldProductName = pivotGridControl.Fields["ProductName"];
            PivotGridField fieldYear = pivotGridControl.Fields["fieldYear"];
            fieldProductName.FilterValues.ValuesIncluded = new object[] { "Chai", "Chang", "Vegie-spread" };
            fieldYear.FilterValues.ValuesIncluded = new object[] { 2015 };

            showPopupTimer.Tick += (s, e) => {
                fieldProductName.ShowFilterPopup();
                showPopupTimer.Stop();
            };
            showPopupTimer.Start();
        }
        [CodeExampleCase("Group Filter Popup")]
        [CodeExampleUnderlineTokens("ShowToolbar", "GroupFilterMode", "FieldFilterPopupMode", "Classic", "FilterPopupToolbarButtons")]
        [CodeExampleDataFile("nwind.xml")]
        public static void GroupFilterPopup(PivotGridControl pivotGridControl, Timer showPopupTimer) {
            pivotGridControl.OptionsFilterPopup.FieldFilterPopupMode = FieldFilterPopupMode.Classic;
            System.Action<PivotGridControl, FilterPopupToolbarButtons, bool> setToolbarButtonVisibility = (pivot, button, visibility) => {
                if(visibility)
                    pivot.OptionsFilterPopup.ToolbarButtons |= button;
                else
                    pivot.OptionsFilterPopup.ToolbarButtons &= ~button;
            };
            PivotGridField fieldYear = pivotGridControl.Fields["fieldYear"];
            fieldYear.Area = PivotArea.ColumnArea;

            PivotGridField fieldQuarter = pivotGridControl.Fields.Add();
            fieldQuarter.Area = PivotArea.ColumnArea;
            fieldQuarter.Caption = "Quarter";
            fieldQuarter.DataBinding = new DataSourceColumnBinding("OrderDate", PivotGroupInterval.DateQuarter);

            PivotGridField fieldMonth = pivotGridControl.Fields.Add();
            fieldMonth.Area = PivotArea.ColumnArea;
            fieldMonth.Caption = "Month";
            fieldMonth.DataBinding = new DataSourceColumnBinding("OrderDate", PivotGroupInterval.DateMonth);
            PivotGridGroup dateGroup = pivotGridControl.Groups.Add(fieldYear, fieldQuarter, fieldMonth);

            pivotGridControl.OptionsFilterPopup.AllowContextMenu = true;
            pivotGridControl.OptionsFilterPopup.ShowToolbar = true;
            pivotGridControl.OptionsFilterPopup.GroupFilterMode = PivotGroupFilterMode.Tree;

            setToolbarButtonVisibility(pivotGridControl, FilterPopupToolbarButtons.IncrementalSearch, true);
            setToolbarButtonVisibility(pivotGridControl, FilterPopupToolbarButtons.InvertFilter, true);
            setToolbarButtonVisibility(pivotGridControl, FilterPopupToolbarButtons.MultiSelection, true);
            setToolbarButtonVisibility(pivotGridControl, FilterPopupToolbarButtons.RadioMode, true);
            setToolbarButtonVisibility(pivotGridControl, FilterPopupToolbarButtons.ShowNewValues, true);

            dateGroup.FilterValues.BeginUpdate();
            dateGroup.FilterValues.FilterType = PivotFilterType.Included;
            dateGroup.FilterValues.Values.Add(2014).ChildValues.Add(3);
            dateGroup.FilterValues.Values[2014].ChildValues[3].ChildValues.Add(9);
            dateGroup.FilterValues.Values.Add(2015).ChildValues.Add(1);
            dateGroup.FilterValues.Values[2015].ChildValues.Add(4);
            dateGroup.FilterValues.EndUpdate();

            showPopupTimer.Tick += (s, e) => {
                fieldYear.ShowFilterPopup();
                showPopupTimer.Stop();
            };
            showPopupTimer.Start();
        }
    }
}
