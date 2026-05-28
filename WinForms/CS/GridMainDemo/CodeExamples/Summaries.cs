using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data;
using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("Summaries", "Summaries.cs")]
    public static class Summaries {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GridControl gridControl = new GridControl();
            GridView gridView = new GridView();
            gridControl.MainView = gridView;
            gridControl.Dock = DockStyle.Fill;
            gridControl.Parent = sampleHost;
            gridControl.DataSource = SampleData.GetData(10);
            return new object[] { gridControl, gridView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as GridControl).Dispose();
        }
        
        #region Summaries
        [CodeExampleCase("Create total and group summaries"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("SummaryItem", "SummaryType", "DisplayFormat", "GroupSummary")]
        public static void CreatingTotalAndGroupSummaries(GridControl gridControl, GridView gridView) {            
            gridView.OptionsView.ShowFooter = true;
            gridView.Columns["Mark"].Group();

            // Creating total and group summaries
            GridColumn column = gridView.Columns["Length"];
            column.SummaryItem.SummaryType = SummaryItemType.Sum;
            // format the total summary
            column.SummaryItem.DisplayFormat = "Total: {0:n3}";
            // group summary
            gridView.GroupSummary.Add(SummaryItemType.Count, "Mark");

            gridView.GroupSummary.Add(new GridGroupSummaryItem() {
                FieldName = "Length",
                SummaryType = SummaryItemType.Sum,
                DisplayFormat = "Sum: {0:n5}",
                ShowInGroupColumnFooter = gridView.Columns["Length"]
            });
        }

        [CodeExampleCase("Manual total summary"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomSummaryCalculate", "SummaryProcess", "TotalValue", "UpdateTotalSummary")]
        public static void CreatingCustomSummary(GridControl gridControl, GridView gridView) {
            // Handle this event to calculate summary values manually
            double sum = 0;
            gridView.CustomSummaryCalculate += (sender, e) => {
                GridView view = sender as GridView;
                if (e.IsTotalSummary) {
                    GridSummaryItem item = e.Item as GridSummaryItem;
                    if (item.FieldName == "Length") {
                        switch (e.SummaryProcess) {
                            case CustomSummaryProcess.Start:
                                sum = 0;
                                break;
                            case CustomSummaryProcess.Calculate:
                                bool shouldSum = (bool)view.GetRowCellValue(e.RowHandle, "Mark");
                                if (shouldSum) {
                                    sum += (double)e.FieldValue;
                                }
                                break;
                            case CustomSummaryProcess.Finalize:
                                e.TotalValue = sum;
                                break;
                        }
                    }
                }
            };

            gridView.OptionsView.ShowFooter = true;
            GridColumn column = gridView.Columns["Length"];
            column.SummaryItem.SummaryType = SummaryItemType.Custom;

            RepositoryItemCheckEdit edit = gridView.Columns["Mark"].RealColumnEdit as RepositoryItemCheckEdit;
            edit.EditValueChanged += (sender, e) => {
                //Post an editor's value to a data source
                gridView.PostEditor();
                //Force calculation of the total summary
                gridView.UpdateTotalSummary();
            };
        }

        [CodeExampleCase("Hide certain summaries"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomSummaryExists", "Exists")]
        public static void CustomSummaryExists(GridControl gridControl, GridView gridView) {            
            gridView.OptionsView.ShowFooter = true;
            gridView.Columns["Mark"].Group();

            // Handle this event to calculate summary values manually
            int sum = 0;
            gridView.CustomSummaryCalculate += (s, e) => {
                GridSummaryItem item = e.Item as GridSummaryItem;
                if (item.FieldName == "ID" || item.FieldName == "Length") {
                    switch (e.SummaryProcess) {
                        case CustomSummaryProcess.Start:
                            sum = 0;
                            break;
                        case CustomSummaryProcess.Calculate:
                            sum += Convert.ToInt32(e.FieldValue);
                            break;
                        case CustomSummaryProcess.Finalize:
                            e.TotalValue = sum;
                            break;
                    }
                }
            };

            // Handle this event to specify which summaries should be calculated and displayed
            gridView.CustomSummaryExists += (s, e) => {
                e.Exists = (e.Item as GridSummaryItem).Tag.ToString() == "VisibleSummary";
            };

            // Creating total and group summaries
            GridColumn column = gridView.Columns["Length"];
            column.Summary.Add(new GridColumnSummaryItem(SummaryItemType.Custom, "Length", "Custom Sum: {0:n}", "VisibleSummary"));
            column.Summary.Add(new GridColumnSummaryItem(SummaryItemType.Custom, "Length", "Custom Sum: {0:n}", "HiddenSummary"));

            gridView.GroupSummary.Add(new GridGroupSummaryItem() {
                FieldName = "ID",
                SummaryType = SummaryItemType.Custom,
                DisplayFormat = "Custom Total: {0:n}",
                ShowInGroupColumnFooter = gridView.Columns["ID"],
                Tag = "VisibleSummary"
            });

            gridView.GroupSummary.Add(new GridGroupSummaryItem() {
                FieldName = "ID",
                SummaryType = SummaryItemType.Custom,
                DisplayFormat = "Custom Total: {0:n}",
                ShowInGroupColumnFooter = gridView.Columns["Length"],
                Tag = "HiddenSummary"
            });
        }

        [CodeExampleCase("Align group summaries in group rows"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("AlignGroupSummaryInGroupRow", "ShowInGroupColumnFooter")]
        public static void AlignGroupSummaryInGroupRow(GridControl gridControl, GridView gridView) {            
            gridView.Columns["Mark"].Group();
            //Enable this option to move group footer summaries to group rows under corresponding column headers
            gridView.OptionsBehavior.AlignGroupSummaryInGroupRow = DefaultBoolean.True;

            //Create group summary
            gridView.GroupSummary.Add(new GridGroupSummaryItem() {
                FieldName = "Length",
                SummaryType = SummaryItemType.Sum,
                ShowInGroupColumnFooter = gridView.Columns["Length"]
            });
        }
        #endregion
    }
}
