using DevExpress.AIIntegration.WinForms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;

namespace DevExpress.AI.Demos {
    public partial class AITutorialControl : TutorialControlBase {
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdatePaddings();
        }
        protected override void DoDpiChangeAfterParent() {
            base.DoDpiChangeAfterParent();
            UpdatePaddings();
        }
        protected override void DoShow() {
            base.DoShow();
            UpdatePaddings();
        }
        protected virtual void UpdatePaddings() { }

        protected void UpdateBottomSpacings(XtraLayout.LayoutControlItem layoutControlItem, int roundedPanelOffset) {
            layoutControlItem.Spacing = new XtraLayout.Utils.Padding(
                            layoutControlItem.Spacing.Left,
                            layoutControlItem.Spacing.Right,
                            layoutControlItem.Spacing.Top,
                            -roundedPanelOffset
                            );
        }

        protected void UpdateTopSpacings(XtraLayout.LayoutControlItem layoutControlItem, int roundedPanelOffset) {
            layoutControlItem.Spacing = new XtraLayout.Utils.Padding(
                            layoutControlItem.Spacing.Left,
                            layoutControlItem.Spacing.Right,
                            -roundedPanelOffset,
                            layoutControlItem.Spacing.Bottom
                            );
        }

        protected override bool? UseRoundedPanel => false;

        protected void OnOperationFailed(object sender, AIOperationFailedEventArgs e) {
            var options = new XtraMessageBoxArgs(
                null,
                e.Exception.Message,
                "AI Service Error",
                new System.Windows.Forms.DialogResult[] { System.Windows.Forms.DialogResult.OK },
                null,
                0);
            options.Showing += Options_Showing;
            options.Appearance.TextOptions.HAlignment = Utils.HorzAlignment.Center;
            XtraMessageBox.Show(options);
        }

        private void Options_Showing(object sender, XtraMessageShowingArgs e) {
            e.MessageBoxForm.MaximumSize = new System.Drawing.Size(600, 600);
        }
    }
}
