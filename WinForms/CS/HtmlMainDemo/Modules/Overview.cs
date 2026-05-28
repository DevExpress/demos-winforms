using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace DevExpress.HTML.Demos {
    public partial class Overview : TutorialControl {
        public Overview() {
            InitializeComponent();
        }
        protected override void OnLayoutCalculated() {
            BeginInvoke(new MethodInvoker(UpdateTableLayoutRowHeight));
        }
        protected override void OnStyleChanged() {
            base.OnStyleChanged();
            UpdateTableLayoutRowHeight();
        }
        void UpdateTableLayoutRowHeight() {
            Root.OptionsTableLayoutGroup.RowDefinitions[1].Height = htmlContentControl.GetContentSize().Height;
        }
        void htmlContentControl_ElementMouseClick(object sender, Utils.Html.DxHtmlElementMouseEventArgs e) {
            if(string.IsNullOrEmpty(e.ElementId))
                return;
            XtraMessageBox.Show($"Html Element ({e.ElementId}) clicked!");
        }
    }
}
