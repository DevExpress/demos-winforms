namespace Examples {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DevExpress.DXperience.Demos.CodeDemo.Data;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.XtraEditors;
    using System.Windows.Forms;
    using DevExpress.XtraTreeList;

    [CodeExampleClass("Preview - read-only row section", "Preview.cs")]
    public static class Preview {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            TreeList treeList = new TreeList();
            treeList.OptionsBehavior.Editable = false;
            treeList.Dock = DockStyle.Fill;
            treeList.Parent = sampleHost;
            treeList.DataSource = SpaceObject.LoadData();
            treeList.ExpandToLevel(0);
            return new object[] { treeList };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }

        [CodeExampleCase("Show preview sections")]
        [CodeExampleUnderlineTokens("PreviewFieldName", "ShowPreview", "AutoCalcPreviewLineCount")]
        public static void ShowPreview(TreeList treeList) {
            treeList.Columns["Notes"].Visible = false;
            // Specify the field name whose values are displayed in preview sections.
            treeList.PreviewFieldName = "Notes";
            // Preview sections are enabled by setting the TreeListOptionsView.ShowPreview option to true.
            treeList.OptionsView.ShowPreview = true;
            // The TreeList.OptionsView.AutoCalcPreviewLineCount property gets or sets if the number of text lines are calculated automatically
            treeList.OptionsView.AutoCalcPreviewLineCount = true;
        }
        
        [CodeExampleCase("Custom preview text using an event")]
        [CodeExampleUnderlineTokens("GetPreviewText", "PreviewText")]
        public static void DynamicPreviewText(TreeList treeList) {
            treeList.Columns["Notes"].Visible = false;
            treeList.PreviewFieldName = "Notes";
            treeList.OptionsView.ShowPreview = true;
            treeList.OptionsView.AutoCalcPreviewLineCount = true;

            // Handle this event to supply custom text to preview sections 
            // or to modify the text provided by the PreviewFieldName field.
            treeList.GetPreviewText += (s, e) => {
                double radius = (double)e.Node["MeanRadiusByEarth"];
                string type = (string)e.Node["TypeOfObject"];
                string size = radius < 1 ? "Small" : "Big";

                e.PreviewText = String.Format("{0} {1}. {2}", size, type, e.PreviewText);
            };
        }

        [CodeExampleCase("Custom preview height")]
        [CodeExampleUnderlineTokens("PreviewLineCount")]
        public static void PreviewLineCount(TreeList treeList) {
            treeList.Columns["Notes"].Visible = false;
            treeList.PreviewFieldName = "Notes";
            treeList.OptionsView.ShowPreview = true;
            // This property controls the height of a preview section (in text lines)
            treeList.PreviewLineCount = 3;
        }

        [CodeExampleCase("Dynamic Preview height using an event")]
        [CodeExampleUnderlineTokens("MeasurePreviewHeight", "PreviewHeight")]
        public static void DynamicPreviewLineCount(TreeList treeList) {
            treeList.Columns["Notes"].Visible = false;
            treeList.PreviewFieldName = "Notes";
            treeList.OptionsView.ShowPreview = true;

            // Handle this event to specify a custom height for individual preview sections
            treeList.MeasurePreviewHeight += (s, e) => {
                double radius = (double)e.Node["MeanRadiusByEarth"];
                if(radius > 1)
                    e.PreviewHeight = DevExpress.Utils.ScaleUtils.ScaleValue(50);
                else
                    e.PreviewHeight = 0;
            };
        }
    }
}
