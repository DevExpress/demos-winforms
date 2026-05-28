namespace DevExpress.XtraPivotGrid.Demos.CodeExamples {
    using System.Data;
    using System.Windows.Forms;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.XtraEditors;
    using DevExpress.XtraPivotGrid;
    using DevExpress.Utils;
    using DevExpress.XtraPivotGrid.Demos.Helpers;
    using DevExpress.XtraPivotGrid.Demos.Modules;
    using System;
    using System.IO;
    using DevExpress.Data.PivotGrid;
    using System.Threading;
    using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

    [CodeExampleClass("OLAP", "OLAPIntegration.cs")]
    public static class OLAPIntegration {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            PivotGridControl pivotGridControl = new PivotGridControl();

            pivotGridControl.BeginInit();
            pivotGridControl.Dock = DockStyle.Fill;
            pivotGridControl.OptionsBehavior.UseAsyncMode = true;
            pivotGridControl.OptionsView.ShowColumnTotals = false;
            pivotGridControl.OptionsCustomization.AllowFilterBySummary = false;
            pivotGridControl.EndInit();

            pivotGridControl.Parent = sampleHost;
            return new object[] { pivotGridControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as PivotGridControl).Dispose();
        }
#if !NET
        [CodeExampleCase("OLAP Drill Down")]
        [CodeExampleUnderlineTokens("CreateDrillDownDataSource", "DrillDownForm")]
        public static void OLAPDrillDown(PivotGridControl pivotGridControl) {
            // To run this example, you should have Microsoft SQL Server Analysis Services OLE DB 8.0 (or later) 
            // installed on your system. You can get the latest version of this provider here: 
            // http://www.microsoft.com/en-us/download/details.aspx?id=16978#ASOLEDB
            pivotGridControl.CellDoubleClick += async (s, e) => {
                try {
                    pivotGridControl.LoadingPanelVisible = true;
                    PivotDrillDownDataSource ds = await e.CreateDrillDownDataSourceAsync();
                    pivotGridControl.LoadingPanelVisible = false;
                    using(DrillDownForm form = new DrillDownForm(ds))
                        form.ShowDialog();
                } catch(Exception ex) {
                    pivotGridControl.LoadingPanelVisible = false;
                    XtraMessageBox.Show(ex.Message);
                }
            };
            OLAPConfigurator.ConnectToAdventureWorks(pivotGridControl, true);
        }
#endif
        [CodeExampleCase("OLAP KPI")]
        [CodeExampleUnderlineTokens("KPIGraphic")]
        public static void OLAPKPI(PivotGridControl pivotGridControl) {
            // To run this example, you should have Microsoft SQL Server Analysis Services OLE DB 8.0 (or later) 
            // installed on your system. You can get the latest version of this provider here: 
            // http://www.microsoft.com/en-us/download/details.aspx?id=16978#ASOLEDB
            PivotGridField statusField = new PivotGridField() { DataBinding = new DataSourceColumnBinding("[Measures].[Internet Revenue Status]"), Area = PivotArea.DataArea, AreaIndex = 2, Caption = "Status", Name = "fieldStatus" };
            PivotGridField quarterField = new PivotGridField() { DataBinding = new DataSourceColumnBinding("[Date].[Fiscal].[Fiscal Quarter]"), Area = PivotArea.RowArea, AreaIndex = 2, Caption = "Fiscal Quarter", Name = "pivotGridField" };
            pivotGridControl.Fields.AddRange(new[] { quarterField, statusField });

            OLAPConfigurator.ConnectToAdventureWorks(pivotGridControl, false);

            ComboBoxEdit ddlStatusGraphics = new ComboBoxEdit() { Parent = pivotGridControl.Parent, Dock = DockStyle.Top };
            ddlStatusGraphics.Properties.Items.AddRange(new[] { PivotKPIGraphic.None, PivotKPIGraphic.Cylinder, PivotKPIGraphic.ReversedGauge, PivotKPIGraphic.Faces });
            ddlStatusGraphics.SelectedIndex = 1;

            ddlStatusGraphics.SelectedIndexChanged += (s, e) => {
                PivotGridField field = pivotGridControl.Fields["[Measures].[Internet Revenue Status]"];
                if(field != null)
                    field.KPIGraphic = (PivotKPIGraphic)ddlStatusGraphics.SelectedItem;
            };
        }
        [CodeExampleCase("OLAP Custom Totals")]
        [CodeExampleUnderlineTokens("CustomTotals", "PivotSummaryType")]
        public static void OlapCustomTotals(PivotGridControl pivotGridControl) {
            // To run this example, you should have Microsoft SQL Server Analysis Services OLE DB 8.0 (or later) 
            // installed on your system. You can get the latest version of this provider here: 
            // http://www.microsoft.com/en-us/download/details.aspx?id=16978#ASOLEDB
            if(OLAPConfigurator.ConnectToAdventureWorks(pivotGridControl, true)) {
                var categoriesField = pivotGridControl.Fields[OLAPConfigurator.CategoriesFieldName];
                categoriesField.TotalsVisibility = PivotTotalsVisibility.CustomTotals;
                categoriesField.CustomTotals.Add(PivotSummaryType.Max);
                categoriesField.CustomTotals.Add(PivotSummaryType.Min);
                categoriesField.CustomTotals.Add(PivotSummaryType.Count);
                categoriesField.ExpandValueAsync("Beverages");
            }
        }
    }
}
