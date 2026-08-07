using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.MailClient.Win {
    public class PictureEditSimpleZoom : PictureEdit {
        protected override void OnMouseWheelCore(MouseEventArgs e) {
            if(Control.ModifierKeys != Keys.None) return;
            base.OnMouseWheelCore(e);
        }
    }
}
