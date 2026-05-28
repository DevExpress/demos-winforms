using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("Preview (read-only row section)", "Preview.cs")]
    public static class Preview {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GridControl gridControl = new GridControl();
            GridView gridView = new GridView();
            gridControl.MainView = gridView;
            gridControl.Dock = DockStyle.Fill;
            gridControl.Parent = sampleHost;
            gridControl.DataSource = SampleData.GetData(5);
            return new object[] { gridControl, gridView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as GridControl).Dispose();
        }

       
        #region Preview
        [CodeExampleCase("Show preview sections"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("PreviewFieldName", "ShowPreview", "AutoCalcPreviewLineCount")]
        public static void ShowPreview(GridControl gridControl, GridView gridView) {            
            gridView.Columns["Notes"].Visible = false;
            // Specify the field name whose values are displayed in preview sections.
            gridView.PreviewFieldName = "Notes";
            // Preview sections are enabled by setting the GridOptionsView.ShowPreview option to true.
            gridView.OptionsView.ShowPreview = true;
            // The GridView.OptionsView.AutoCalcPreviewLineCount property gets or sets if the number of text lines are calculated automatically
            gridView.OptionsView.AutoCalcPreviewLineCount = true;
        }

        [CodeExampleCase("Custom preview text (using an event)"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CalcPreviewText", "PreviewText")]
        public static void DynamicPreviewText(GridControl gridControl, GridView gridView) {            
            gridView.Columns["Notes"].Visible = false;
            gridView.PreviewFieldName = "Notes";
            gridView.OptionsView.ShowPreview = true;
            gridView.OptionsView.AutoCalcPreviewLineCount = true;

            // Handle this event to supply custom text to preview sections 
            // or to modify the text provided by the PreviewFieldName field.
            gridView.CalcPreviewText += (s, e) => {
                if (e.RowHandle % 2 == 0)
                    e.PreviewText = string.Format("Dynamic preview text {0}", e.RowHandle);
            };
        }

        [CodeExampleCase("Custom preview height"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("PreviewLineCount")]
        public static void PreviewLineCount(GridControl gridControl, GridView gridView) {            
            gridView.Columns["Notes"].Visible = false;
            gridView.PreviewFieldName = "Notes";
            gridView.OptionsView.ShowPreview = true;
            // This property controls the height of a preview section (in text lines)
            gridView.PreviewLineCount = 3;
        }

        [CodeExampleCase("Dynamic Preview height (using an event)"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("MeasurePreviewHeight", "RowHeight")]
        public static void DynamicPreviewLineCount(GridControl gridControl, GridView gridView) {            
            gridView.Columns["Notes"].Visible = false;
            gridView.PreviewFieldName = "Notes";
            gridView.OptionsView.ShowPreview = true;

            // Handle this event to specify a custom height for individual preview sections
            gridView.MeasurePreviewHeight += (s, e) => {
                if(e.RowHandle % 2 == 0)
                    e.RowHeight = DevExpress.Utils.ScaleUtils.ScaleValue(50);
                else
                    e.RowHeight = 0;
            };
        }
        #endregion
    }
}
