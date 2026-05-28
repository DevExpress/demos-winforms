using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.HTML.Demos.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;

namespace DevExpress.HTML.Demos {
    public partial class TileViewModule : TutorialControlBase {
        public TileViewModule() {
            InitializeComponent();
            tileViewTemplateCodeViewer1.Fill(tileView1);
            gridControl1.DataSource = DataHelper.Messages;
            this.colDate.SortOrder = Data.ColumnSortOrder.Descending;

            if(MainFormHelper.TakeScreens) tileView1.AnimateArrival = false;
            tileView1.FocusedRowHandle = 2;
        }

        void OnReply(object sender, TileViewHtmlElementMouseEventArgs e) {
            ShowPopup(popupReply, e.Row);
        }
        void OnDelete(object sender, TileViewHtmlElementMouseEventArgs e) {
            ShowPopup(popupDelete, e.Row);
        }
        void OnFlag(object sender, TileViewHtmlElementMouseEventArgs e) {
            var msg = e.Row as EmailMessage;
            if(msg != null)
                msg.Flagged = !msg.Flagged;
        }

        void ShowPopup(HtmlContentPopup popup, object msg) {
            popup.DataContext = msg;
            var size = popup.CalcBestSize(gridControl1, 1000);
            var rect = gridControl1.RectangleToScreen(gridControl1.ClientRectangle);
            var pt = new Point(rect.X + (rect.Width - size.Width) / 2, rect.Y + (rect.Height - size.Height) / 2);
            popup.Show(gridControl1, new Rectangle(pt, size));
        }
    }
}
