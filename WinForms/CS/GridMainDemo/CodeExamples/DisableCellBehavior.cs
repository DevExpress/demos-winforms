using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using DevExpress.Utils.Behaviors;
using DevExpress.Utils.Behaviors.Common;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;
using System;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("Disabled grid cell behavior", "DisableCellBehavior.cs")]
    public class DisabledGridCellsBehavior {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GridControl gridControl = new GridControl();
            GridView gridView = new GridView();
            BehaviorManager behaviorManager = new BehaviorManager();
            SpinEdit spinEdit = new SpinEdit();
            LabelControl label = new LabelControl();
            label.Dock = DockStyle.Top;
            label.Text = "Disable only rows where Length is greater than:";
            label.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            label.Visible = false;          
            spinEdit.Visible = false;
            spinEdit.Dock = DockStyle.Top;      
            gridControl.Tag = behaviorManager;
            gridControl.MainView = gridView;
            gridControl.Dock = DockStyle.Fill;
            gridControl.DataSource = SampleData.GetData(10);
            gridView.PopulateColumns();
            gridControl.Parent = sampleHost;
            spinEdit.Parent = sampleHost;
            label.Parent = sampleHost;
            return new object[] { gridControl, gridView, spinEdit, label, behaviorManager };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            GridControl grid = sampleHost.Controls[0] as GridControl;
            if(grid != null) {
                var manager = grid.Tag as BehaviorManager;
                grid.Dispose();
                if(manager != null) manager.Dispose();
            }
        }
        [CodeExampleCase("Disable cells that meet a custom condition"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("Appearance", "ProcessingCell", "FieldName", "RecordId", "Disabled", "Source")]
        public static void DisableCellsUsingACustomCondition(GridControl gridControl, GridView gridView, SpinEdit spinEdit, LabelControl label, BehaviorManager behaviorManager) {
            behaviorManager.Attach<DisabledCellBehavior>(gridView, behavior => {
                //Uncomment this line to change the background color for disabled cells.
                //behavior.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
                behavior.Properties.Appearance.FontStyleDelta = System.Drawing.FontStyle.Strikeout;
                behavior.ProcessingCell += (s, e) => {
                    if(e.FieldName != "Name") {
                        GridView view = e.Source as GridView;
                        e.Disabled = (bool)view.GetListSourceRowCellValue(e.RecordId, "Mark");
                    }
                };
            });
        }
        [CodeExampleCase("Disable cells in rows that meet the specified criterion"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("Expression", "Appearance")]
        public static void DisableCellsUsingAnExpression(GridControl gridControl, GridView gridView, SpinEdit spinEdit, LabelControl label, BehaviorManager behaviorManager) {
            behaviorManager.Attach<DisabledCellBehavior>(gridView, behavior => {
                //Uncomment this line to change the background color for disabled cells.
                //behavior.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
                behavior.Properties.Appearance.FontStyleDelta = System.Drawing.FontStyle.Strikeout;
                behavior.Properties.Expression = "[Mark] == true";
            });
        }        
        [CodeExampleCase("Enable specific cells in disabled rows based on a custom condition"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("Appearance", "Expression", "ProcessingCell", "FieldName", "RecordId", "Disabled", "Source")]
        public static void OverrideExpressionResultUsingACustomCondition(GridControl gridControl, GridView gridView, SpinEdit spinEdit, LabelControl label, BehaviorManager behaviorManager) {
            spinEdit.Visible = true;
            spinEdit.EditValue = 30;
            spinEdit.EditValueChanged += (o, e) => { gridView.LayoutChanged(); };
            label.Visible = true;
            behaviorManager.Attach<DisabledCellBehavior>(gridView, behavior => {
                //Uncomment this line to change the background color for disabled cells.
                //behavior.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
                behavior.Properties.Appearance.FontStyleDelta = System.Drawing.FontStyle.Strikeout;
                behavior.Properties.Expression = "Abs(DateDiffDay([RecordDate], Today())) > 3";
                behavior.ProcessingCell += (s, e) => {
                    //The Name column is never disabled.
                    if(e.FieldName == "Name") {
                        e.Disabled = false;
                        return;
                    }
                    GridView view = e.Source as GridView;
                    double length = (double)(view.GetListSourceRowCellValue(e.RecordId, "Length"));
                    bool evaluationResult = e.Disabled;
                    e.Disabled = length > Convert.ToDouble((decimal)spinEdit.EditValue) ? evaluationResult : false;
                };
            });
        }
    }
}
