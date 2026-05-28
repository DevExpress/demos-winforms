using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.HTML.Demos {
    public partial class ToolTipViewModule : TutorialControlBase {
        public ToolTipViewModule() {
            InitializeComponent();
        }
    }

    static class ToolTipPresentationHelper {
        public static void CenterParent(ContainerControl host, HtmlToolTipWindowBase view) {
            host.Resize += delegate { UpdateViewBounds(host, view); };
            view.Shown += delegate { UpdateViewBounds(host, view); };
            view.FormClosing += delegate (object s, FormClosingEventArgs e) { 
                if(e.CloseReason == CloseReason.UserClosing) { e.Cancel = true; }
            };
            view.TopLevel = false;
            view.Parent = host;
            view.Show();
        }

        public static void UpdateViewBounds(ContainerControl host, HtmlToolTipWindowBase view) {
            Rectangle targetRect = host.ClientRectangle;
            if(view.FormPainter != null)
                view.Bounds = PlacementHelper.Arrange(view.FormPainter.CalcToolTipSize(), targetRect, ContentAlignment.MiddleCenter);
        }
    }
}
