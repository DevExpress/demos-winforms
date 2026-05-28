using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Utils.VisualEffects;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.AnchorVertical {
    class PreviewControl : ReportModule {
        protected override XtraReport CreateReport() {
            return new Report();
        }
        protected override void OnSetViewer() {
            Viewer.SetPageView(DevExpress.XtraPrinting.PageViewModes.PageWidth);
        }
        public override void AddElements(AdornerUIManager adorner, IDictionary<string, object> targets) {
            object element = null;
            if(targets.TryGetValue("PageSetup", out element)) {
                adorner.QueryGuideFlyoutControl += Adorner_QueryGuideFlyoutControl;
                Guide guide = new Guide() { TargetElement = element };
                adorner.Elements.Add(guide);
            }
        }
        void Adorner_QueryGuideFlyoutControl(object sender, QueryGuideFlyoutControlEventArgs e) {
            e.Control = new LabelControl() {
                AllowHtmlString = true,
                Width = 250,
                AutoSizeMode = LabelAutoSizeMode.Vertical,
                Padding = new Padding(20),
                Text = "Change Margins, Orientation or Size to see how horizontal anchoring works."
            };
        }
    }
}
