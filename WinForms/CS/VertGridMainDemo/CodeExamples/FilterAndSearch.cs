using DevExpress.Data.Filtering;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid.Rows;
using System.Windows.Forms;
using DevExpress.XtraVerticalGrid;
using SampleDataSourceFile = DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS;
using DevExpress.Utils;

namespace DevExpress.XtraVerticalGrid.Demos.CodeExamples {
    [CodeExampleClass("Filter and search", "FilterAndSearch.cs")]
    public static class FilterAndSearch {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            VGridControl vGridControl = new VGridControl();
            vGridControl.Dock = DockStyle.Fill;
            vGridControl.Parent = sampleHost;
            vGridControl.RowHeaderWidth = ScaleUtils.ScaleValue(120);
            vGridControl.RecordWidth = ScaleUtils.ScaleValue(140);
            vGridControl.DataSource = SampleData.GetData(6);
            return new object[] { vGridControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as VGridControl).Dispose();
        }

        #region Filtering and Searching
        [CodeExampleCase("Filter data using ActiveFilterString"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ActiveFilterString")]
        public static void FilterGridViewInCodeUsingActiveFilterString(VGridControl vGridControl) {
            vGridControl.ActiveFilterString = "Contains([Name], 'Blue')";
        }
        [CodeExampleCase("Filter data using ActiveFilter"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ActiveFilterCriteria", "ActiveFilter")]
        public static void FilterGridViewInCode(VGridControl vGridControl) {
            SimpleButton btnAddFilter = new SimpleButton { Parent = vGridControl.Parent, Text = "Apply the ActiveFilter-based filtering", Dock = DockStyle.Top };
            btnAddFilter.Click += (s, e) => {
                // The ActiveFilter property allows you to build filter expressions manually
                vGridControl.ActiveFilter.Add(vGridControl.GetRowByFieldName("ID").Properties, new VGridRowFilterInfo(string.Format("[{0}] > '3'", "ID"), ""));
            };

            SimpleButton bthApplyFilter = new SimpleButton { Parent = vGridControl.Parent, Text = "Apply the ActiveFilterCriteria-based filtering", Dock = DockStyle.Top };
            bthApplyFilter.Click += (s, e) => {
                CriteriaOperator expr1 = new BinaryOperator("ID", 2, BinaryOperatorType.GreaterOrEqual);
                CriteriaOperator expr2 = new BinaryOperator("Length", 25, BinaryOperatorType.Greater);

                //The ActiveFilterCriteria property accepts one or multiple DevExpress.Data.Filtering.CriteriaOperator
                //type objects, each representing a single filtering expression
                vGridControl.ActiveFilterCriteria = GroupOperator.Or(new CriteriaOperator[] { expr1, expr2 });
            };
            CheckEdit chkFilterEnabled = new CheckEdit { Parent = vGridControl.Parent, Text = "ActiveFilterEnabled ", Dock = DockStyle.Top };

            // Disable the ActiveFilterEnabled property to temporarily deactivate all filters
            chkFilterEnabled.DataBindings.Add(new Binding("EditValue", vGridControl, "ActiveFilterEnabled", false, DataSourceUpdateMode.OnPropertyChanged));
        }
        [CodeExampleCase("Search using the Find Panel"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("OptionsFind", "FindFilterText")]
        public static void SetFindPanelTextInCode(VGridControl vGridControl) {
            // The find panel visibility.
            vGridControl.OptionsFind.Visibility = FindPanelVisibility.Always;
            // Call this method in code to invoke the Find Panel and manually search for the required string
            vGridControl.FindFilterText = "Blue";
        }
        [CodeExampleCase("Show the Filter Editor"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ShowFilterEditor")]
        public static void ShowFilterEditor(VGridControl vGridControl) {
            SimpleButton b = new SimpleButton { Parent = vGridControl.Parent, Text = "Show Filter Editor", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                // Invoke the Filter Editor
                vGridControl.ShowFilterEditor(vGridControl.FocusedRow.Properties);
            };
        }
        #endregion

    }

    [CodeExampleClass("Comparison", "FilterAndSearch.cs")]
    public static class Comparison {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            VGridControl vGridControl = new VGridControl();
            vGridControl.Dock = DockStyle.Fill;
            vGridControl.Parent = sampleHost;
            vGridControl.RowHeaderWidth = ScaleUtils.ScaleValue(120);
            vGridControl.RecordWidth = ScaleUtils.ScaleValue(140);
            vGridControl.DataSource = SampleData.GetData(15);
            vGridControl.OptionsView.ShowRecordHeaders = true;
            vGridControl.RecordHeaderFormat = "{Name}";
            return new object[] { vGridControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as VGridControl).Dispose();
        }

        [CodeExampleCase("Add and remove records to/from comparison"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("AddToComparison", "RemoveFromComparison", "ShowComparison", "IsInComparison", "HideComparison", "ClearComparison")]
        public static void AddingRecordsToComparison(VGridControl vGridControl) {
            // Add the specific record/records to comparison
            vGridControl.AddToComparison(13);
            vGridControl.AddToComparison(new int[] { 1, 5, 11, 7, 8 });
            // Remove the specific record/records from comparison
            vGridControl.RemoveFromComparison(5);
            vGridControl.RemoveFromComparison(new int[] { 7, 8 });
            // Show only records added to comparison
            vGridControl.ShowComparison();
            // Whether or not record added to comparison
            if(vGridControl.IsInComparison(5)) {
                // To clear the comparison and show all records use the ClearComparison method
                vGridControl.ClearComparison();
                // To show all records use the HideComparison method
                vGridControl.HideComparison();
            }
        }
    }
}
