using DevExpress.Internal;
using System.Data;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using DevExpress.Utils;
using System.Linq;

namespace DevExpress.XtraPivotGrid.Demos.CodeExamples {
    [CodeExampleClass("Editing", "Editing.cs")]
    public static class Editing {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            PivotGridControl pivotGridControl = new PivotGridControl();

            pivotGridControl.BeginInit();
            pivotGridControl.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized;
            PivotGridField fieldCategory = new PivotGridField();
            fieldCategory.Area = PivotArea.RowArea;
            fieldCategory.DataBinding = new DataSourceColumnBinding("CategoryName");
            fieldCategory.Name = "fieldCategory";

            PivotGridField fieldProductName = new PivotGridField();
            fieldProductName.Area = PivotArea.RowArea;
            fieldProductName.DataBinding = new DataSourceColumnBinding("ProductName");
            fieldProductName.Name = "fieldProductName";


            PivotGridField fieldSalesPerson = new PivotGridField();
            fieldSalesPerson.Area = PivotArea.ColumnArea;
            fieldSalesPerson.DataBinding = new DataSourceColumnBinding("Sales Person");
            fieldSalesPerson.Name = "fieldSalePerson";

            PivotGridField fieldQuantity = new PivotGridField();
            fieldQuantity.Area = PivotArea.DataArea;
            fieldQuantity.DataBinding = new DataSourceColumnBinding("Quantity");
            fieldQuantity.Name = "fieldQuantity";
            fieldQuantity.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Sum;

            pivotGridControl.Fields.AddRange(new PivotGridField[] {
                fieldQuantity,
                fieldCategory,
                fieldProductName,
                fieldSalesPerson
            });
            pivotGridControl.Dock = DockStyle.Fill;
            pivotGridControl.OptionsView.ShowRowTotals = false;
            pivotGridControl.OptionsView.ShowRowGrandTotals = false;

            string tableName = "SalesPerson";
            string dbFileName = DataDirectoryHelper.GetDataFile("nwind.xml");
            if(!string.IsNullOrEmpty(dbFileName)) {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(dbFileName);
                pivotGridControl.DataSource = dataSet.Tables[tableName].DefaultView;
            }
            pivotGridControl.EndInit();
            pivotGridControl.Parent = sampleHost;
            return new object[] { pivotGridControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as PivotGridControl).Dispose();
        }

        [CodeExampleCase("Validation")]
        [CodeExampleUnderlineTokens("EditValueChanged", "ValidatingEditor", "FieldEdit")]
        [CodeExampleDataFile("nwind.xml")]
        public static void Validation(PivotGridControl pivotGridControl) {
            int minValue = 0; int maxValue = 100;
            var dataField = pivotGridControl.Fields["Quantity"];
            pivotGridControl.CustomAppearance += (s, e) => {
                if(!ReferenceEquals(e.DataField, dataField)) return;
                int val = System.Convert.ToInt32(e.Value);
                if(ReferenceEquals(e.DataField, dataField) && (val < minValue || val > maxValue))
                    e.Appearance.BackColor = System.Drawing.Color.Red;
            };
            dataField.FieldEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            pivotGridControl.ValidatingEditor += (s, e) => {
                int val = System.Convert.ToInt32(e.Value);
                if(val < minValue || val > maxValue) {
                    e.ErrorText = "Value must be greater than " + minValue.ToString() + " and less than " + maxValue.ToString();
                    e.Valid = false;
                }
            };

            pivotGridControl.EditValueChanged += (s, e) => {
                PivotDrillDownDataSource drillDown = e.CreateDrillDownDataSource();
                decimal newValue = (decimal)e.Editor.EditValue;
                if(drillDown.RowCount > 0) {
                    int newCellValue = (int)System.Math.Floor(newValue / drillDown.RowCount), extra = (int)newValue % drillDown.RowCount;
                    for(int i = 0; i < drillDown.RowCount; i++)
                        drillDown[i][dataField] = (short)((i == drillDown.RowCount - 1) ? (newCellValue + extra) : newCellValue);
                } else {
                    DataTable table = (pivotGridControl.DataSource as DataView).Table;
                    object[] row = new object[table.Columns.Count];
                    var fields = pivotGridControl.Fields.Cast<PivotGridField>().Where(f => f.Area == PivotArea.ColumnArea || f.Area == PivotArea.RowArea).ToArray();
                    for(int i = 0; i < fields.Length; i++) {
                        object fieldValue = e.GetFieldValue(fields[i]);
                        row[table.Columns.IndexOf(((DataSourceColumnBinding)fields[i].DataBinding).ColumnName)] = fieldValue;
                    }
                    row[table.Columns.IndexOf(((DataSourceColumnBinding)dataField.DataBinding).ColumnName)] = newValue;
                    table.Rows.Add(row);
                    table.AcceptChanges();
                    pivotGridControl.RefreshData();
                }
            };
            pivotGridControl.BestFit();
        }
    }
}
