using System.Collections.Generic;

namespace DevExpress.XtraDialogs.Demos {
    public partial class DialogAPIExamples : CodeTutorialControl {
        public DialogAPIExamples() {
            InitializeComponent();
        }
        protected override List<string> InitializeHighlightTokens() {
            var list = base.InitializeHighlightTokens();
            list.Add("XtraFolderBrowserDialog");
            list.Add("XtraOpenFileDialog");
            list.Add("XtraSaveFileDialog");
            return list;
        }
    }
}
