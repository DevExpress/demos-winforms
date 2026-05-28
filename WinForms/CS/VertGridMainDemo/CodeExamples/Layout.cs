using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;
using SampleDataSourceFile = DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS;

namespace DevExpress.XtraVerticalGrid.Demos.CodeExamples {
    [CodeExampleClass("Layout", "Layout.cs")]
    public static class Layout {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            VGridControl vGridControl = new VGridControl();
            vGridControl.Dock = DockStyle.Fill;
            vGridControl.Parent = sampleHost;
            vGridControl.RowHeaderWidth = ScaleUtils.ScaleValue(120);
            vGridControl.RecordWidth = ScaleUtils.ScaleValue(140);
            vGridControl.DataSource = SampleData.GetData(10);
            return new object[] { vGridControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as VGridControl).Dispose();
        }

        [CodeExampleCase("Caption height"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ShowCaption", "Caption", "CaptionHeight")]
        public static void CaptionHeight(VGridControl vGridControl) {
            // Enable this option to show the VGridControl's caption
            vGridControl.OptionsView.ShowCaption = true;
            vGridControl.Caption = "Fish database";
            // This property controls the VGridControl's caption height
            vGridControl.CaptionHeight = 40;
        }

        [CodeExampleCase("Formatting record headers"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ShowRecordHeaders", "RecordHeaderFormat")]
        public static void FormattingRecordHeaders(VGridControl vGridControl) {
            // Hide unecessary row from layout
            vGridControl.Rows["Name"].Visible = false;
            // Enable this option to show the VGridControl's record headers
            vGridControl.OptionsView.ShowRecordHeaders = true;
            // This property controls the VGridControl's record headers formatting
            vGridControl.RecordHeaderFormat = "[{Name}]";
        }
    }
}
