using System.Drawing;
using DevExpress.LookAndFeel;
using DevExpress.Utils.Colors;
using DevExpress.XtraEditors;

namespace XtraReportsDemos.AIOperations {
    public partial class ucDisclaimerPanel : XtraUserControl {
        public ucDisclaimerPanel() {
            InitializeComponent();
            OnLookAndFeelChanged();
        }

        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            var color = DXSkinColorHelper.GetDXSkinColor(DXSkinColors.FillColors.Warning, 64, LookAndFeel);
            noteLayoutControl.BackColor = color;
            noteLabelControl.ForeColor = DXSkinColors.ForeColors.ControlText;
        }

        public int RoundedPanelOffset { get { return roundedSkinPanel.DisplayRectangle.Y; } }
    }
}
