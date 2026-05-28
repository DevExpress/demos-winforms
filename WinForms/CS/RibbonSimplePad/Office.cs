using System.Drawing;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Utils;

namespace DevExpress.XtraBars.Demos.RibbonSimplePad {
    public class Office2007PopupControlContainer : PopupControlContainer, ITransparentBackgroundManager {
        Color ITransparentBackgroundManager.GetForeColor(object childObject) {
            return GetForeColorCore();
        }
        Color ITransparentBackgroundManager.GetForeColor(Control childControl) {
            return GetForeColorCore();
        }
        protected Color GetForeColorCore() {
            return BarUtilites.GetAppMenuLabelForeColor(LookAndFeel.ActiveLookAndFeel);
        }
    }
}
