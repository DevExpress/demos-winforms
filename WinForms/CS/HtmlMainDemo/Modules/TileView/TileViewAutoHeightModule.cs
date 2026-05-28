using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.HTML.Demos.Helpers.Tasks;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Tile;

namespace DevExpress.HTML.Demos {
    public partial class TileViewAutoHeightModule : TutorialControlBase {
        public TileViewAutoHeightModule() {
            InitializeComponent();
            if(MainFormHelper.TakeScreens)
                tileView1.AnimateArrival = false;
            tileViewTemplateCodeViewer1.Fill(tileView1);
            gridControl1.DataSource = TaskGenerator.Default.GenerateSource(37);
            tileView1.FocusedRowHandle = 2;

            alertControl1.BeforeFormShow += (s, e) => { e.Location = gridControl1.PointToScreen(Point.Empty); };
            alertControl1.GetDesiredAlertFormWidth += (s, e) => { e.Width = gridControl1.Width; };
            tileView1.KeyDown += TileView1_KeyDown;

            copyMenu = new DXPopupMenu();
            copyMenu.Items.Add(new DXMenuItem("Copy", CopySelected, svgImageCollection1[0], DXMenuItemPriority.Normal));
            tileView1.HtmlElementMouseClick += TileView1_HtmlElementMouseClick;
        }
        DXPopupMenu copyMenu;

        void TileView1_KeyDown(object sender, KeyEventArgs e) {
            if(Control.ModifierKeys.HasFlag(Keys.Control) && e.KeyCode == Keys.C)
                CopySelected(sender, e);
        }
        void TileView1_HtmlElementMouseClick(object sender, TileViewHtmlElementMouseEventArgs e) {
            if(e.MouseArgs.Button == MouseButtons.Right && e.HitInfo.InSelection)
                MenuManagerHelper.ShowMenu(copyMenu, LookAndFeel, MenuManagerHelper.GetMenuManager(LookAndFeel, Parent), this, e.MouseArgs.Location);
        }
        void CopySelected(object sender, System.EventArgs e) {
            var text = tileView1.SelectedHtmlText;
            if(!string.IsNullOrEmpty(text)) {
                DevExpress.Data.Utils.SafeClipboardWin.Instance.SetText(text);
                alertControl1.Show(FindForm(), string.Empty, "Selected text copied to clipboard");
            }
        }
    }
}
