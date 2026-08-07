using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Extensions;

namespace DevExpress.WindowsMailClient.Win.Controls {
    public class VerticalTopFlyoutPanel : FlyoutPanel {
        protected override FlyoutPanelToolForm CreateToolFormCore(Control owner, FlyoutPanel content, FlyoutPanelOptions options) {
            return new VerticalTopFlyoutPanelToolForm(owner, content, options);
        }
    }
    public class VerticalTopFlyoutPanelToolForm : FlyoutPanelToolForm {
        public VerticalTopFlyoutPanelToolForm(Control owner, FlyoutPanel flyoutPanel, FlyoutPanelOptions options) : base(owner, flyoutPanel, options) {
        }
        protected override void CheckToolWindowLocation() {
            if(OwnerForm is MainForm) {
                if(((MainForm)OwnerForm).ExtendNavigationControlToFormTitleInternal) {
                    if(AnimationProvider == null || IsOwnerOrItselfDisposed)
                        return;
                    Point loc = AnimationProvider.CalcTargetFormLocation();
                    int borderSize = Owner.GetBorderSize();
                    loc.Y = Owner.Bounds.Y + borderSize;
                    if(Location != loc) {
                        Location = loc;
                    }
                    Size _size = AnimationProvider.CalcTargetFormSize();
                    _size.Height = Owner.Bounds.Height - 2 * borderSize;
                    if(Size != _size) {
                        Size = _size;
                    }
                }
                else {
                    base.CheckToolWindowLocation();
                }
            }
        }
    }
}
