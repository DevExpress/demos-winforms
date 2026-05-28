using DevExpress.Data.Filtering;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid.Rows;
using System.Windows.Forms;
using DevExpress.XtraVerticalGrid;
using SampleDataSourceFile = DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS;
using ImageHelperSourceFile = DevExpress.XtraVerticalGrid.Demos.CodeExamples.ImageHelperCS;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils;

namespace DevExpress.XtraVerticalGrid.Demos.CodeExamples {
    [CodeExampleClass("HTML Text Formatting", "HtmlText.cs")]
    public static class Html {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            VGridControl vGridControl = new VGridControl();
            vGridControl.Dock = DockStyle.Fill;
            vGridControl.Parent = sampleHost;
            vGridControl.RowHeaderWidth = ScaleUtils.ScaleValue(120);
            vGridControl.RecordWidth = ScaleUtils.ScaleValue(140);
            vGridControl.DataSource = SampleData.LoadData();
            return new object[] { vGridControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as VGridControl).Dispose();
        }

        #region Selection
        [CodeExampleCase("Cells"), ImageHelperSourceFile]
        [CodeExampleUnderlineTokens("OptionsView", "AllowHtmlText", "HtmlImages")]
        public static void HtmlInCell(VGridControl vGridControl) {
            // Enable HTML Text Formatting and populate the image collection with glyphs.
            vGridControl.OptionsView.AllowHtmlText = true;
            vGridControl.HtmlImages = ImageHelper.GetGlyphs();

            // Assign the HypertextLabel editor to the Name row.
            BaseRow row = vGridControl.GetRowByFieldName("Name");
            row.Properties.RowEdit = new RepositoryItemHypertextLabel();

            //Enumerate records in the row, and update cell values.
            for(int i = 0; i < vGridControl.RecordCount; i++) {
                string value = (string)vGridControl.GetCellValue(row, i);
                vGridControl.SetCellValue(row, i, "<Image=" + value[0] + ">" + value);
            }
        }

        [CodeExampleCase("Headers"), ImageHelperSourceFile]
        [CodeExampleUnderlineTokens("OptionsView", "AllowHtmlText", "HtmlImages")]
        public static void HtmlInHeader(VGridControl vGridControl) {
            // Enable HTML Text Formatting and populate the image collection with glyphs.
            vGridControl.OptionsView.AllowHtmlText = true;
            vGridControl.HtmlImages = ImageHelper.GetGlyphs();

            // Enumerate rows and update header captions.
            foreach(BaseRow row in vGridControl.Rows) {
                string caption = row.Properties.GetTextCaption();
                // To specify the glyph in the Image tag, use the glyph name in the ImageCollection.
                row.Properties.Caption = "<Image=" + caption[0] + "> " + caption;
            }
        }

        #endregion
    }
}
