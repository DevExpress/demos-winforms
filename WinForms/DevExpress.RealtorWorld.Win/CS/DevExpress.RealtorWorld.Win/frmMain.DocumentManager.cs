using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Data.Internal;
using DevExpress.Utils.About;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;

namespace DevExpress.RealtorWorld.Win {
    public partial class frmMain : XtraForm, IMainForm {
        public frmMain() {
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Location = System.Windows.Forms.Screen.GetBounds(MousePosition).Location;
            InitializeComponent();
            InitTitleImages();
            windowsUIView.ContentContainerActions.Add(new SetSkinAction("Metropolis", "White Theme"));
            windowsUIView.ContentContainerActions.Add(new SetSkinAction("MetroBlack", "Black Theme"));
            InitTiles();
        }
        protected override void OnResize(EventArgs e) {
            base.OnResize(e);
            windowsUIButtonPanel1.BringToFront();
            windowsUIButtonPanel1.Location = new Point(Width - 40, 8);
        }
        void InitTitleImages() {
            ucDraftTile.Elements[0].Image = global::DevExpress.RealtorWorld.Win.Properties.Resources.UserManagment;
            ucSettingsTile.Elements[0].Image = global::DevExpress.RealtorWorld.Win.Properties.Resources.System;
            ucResearchTile.Elements[0].Image = global::DevExpress.RealtorWorld.Win.Properties.Resources.Research;
            ucStatsTile.Elements[0].Image = global::DevExpress.RealtorWorld.Win.Properties.Resources.Statistics;
            ucBrowserTile.Elements[0].Image = global::DevExpress.RealtorWorld.Win.Properties.Resources.Home;
            ucBanksTile.Elements[0].Image = global::DevExpress.RealtorWorld.Win.Properties.Resources.Rates;
            ucLoanCalculatorTile.Elements[0].Image = global::DevExpress.RealtorWorld.Win.Properties.Resources.Calc;
            this.browserPage.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Home", global::DevExpress.RealtorWorld.Win.Properties.Resources.SmallHome, -1, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, null, true, false, true, null, "Home", -1, false, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Refresh", global::DevExpress.RealtorWorld.Win.Properties.Resources.Rotate, -1, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, null, true, false, true, null, "Refresh", -1, false, false)});
        }
        void InitTiles() {
            DataHelper.InitListingsTile(ucListingTile);
            DataHelper.InitAgentsTile(ucAgentsTile, AppConst.TileSize);
        }
        object current;
        void IMainForm.ShowHome(Home home) {
            current = home;
            BaseModule module = ucListingDocument.Control as BaseModule;
            if(module != null)
                module.ShowModule(home);
            windowsUIView.Controller.Activate(ucListingDocument);
            current = null;
        }
        void IMainForm.ShowAgent(Agent agent) {
            current = agent;
            BaseModule module = ucAgentsDocument.Control as BaseModule;
            if(module != null)
                module.ShowModule(agent);
            windowsUIView.Controller.Activate(ucAgentsDocument);
            current = null;
        }
        void windowsUIView_QueryControl(object sender, QueryControlEventArgs e) {
            BaseModule module = e.Document.Tag is BaseModule ? (BaseModule)e.Document.Tag :
                CreateModuleByName(e.Document.ControlTypeName);
            module.InitModule(barManager1, windowsUIView);
            BaseTile tile = null;
            if(windowsUIView.Tiles.TryGetValue(e.Document, out tile)) {
                TileItemFrame frame = tile.CurrentFrame;
                object data = current ?? ((frame != null) ? frame.Tag : null);
                module.ShowModule(data);
            }
            e.Document.Tag = module;
            e.Control = module;
        }
        BaseModule CreateModuleByName(string typeName) {
            var moduleType = SafeTypeResolver.GetKnownType(typeof(frmMain).Assembly, typeName);
            return Activator.CreateInstance(moduleType) as BaseModule;
        }
        void windowsUIView_TileClick(object sender, TileClickEventArgs e) {
            Tile tile = e.Tile as Tile;
            if(tile != null && tile.Document != null) {
                BaseModule module = tile.Document.Control as BaseModule;
                if(module != null) {
                    TileItemFrame frame = tile.CurrentFrame;
                    object data = (frame != null) ? frame.Tag : null;
                    module.ShowModule(data);
                }
                if(tile.ActivationTarget == page) {
                    page.Document = tile.Document;
                    if(tile.Elements.Count > 0)
                        page.Caption = tile.Elements[0].Text;
                }
            }
        }
        void browserPage_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e) {
            Page page = sender as Page;
            if(page != null) {
                BaseModule module = page.Document.Control as BaseModule;
                if(module != null && module is ucBrowser) {
                    if(string.Equals("Refresh", e.Button.Properties.Tag))
                        ((ucBrowser)module).RefreshBrowser();
                    if(string.Equals("Home", e.Button.Properties.Tag))
                        ((ucBrowser)module).Navigate();
                }
            }
        }
        void windowsUIButtonPanel1_ButtonClick(object sender, XtraBars.Docking2010.ButtonEventArgs e) {
            Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);
            bool restoreTimerState = false;
            ucSettings ucSettingsControl = null;
            if(page.Document != null && page.Document.Control is ucSettings) {
                ucSettingsControl = page.Document.Control as ucSettings;
                restoreTimerState = ucSettingsControl.ActivationTimer.Enabled;
            }
            FlyoutAction closeAction = CreateCloseAction();
            flyout.Action = closeAction;
            if(restoreTimerState)
                ucSettingsControl.ActivationTimer.Enabled = false;
            if(windowsUIView.ShowFlyoutDialog(flyout) != System.Windows.Forms.DialogResult.Yes) {
                e.Cancel = true;
                if(restoreTimerState)
                    ucSettingsControl.ActivationTimer.Enabled = true;
            }
        }
        FlyoutAction CreateCloseAction() {
            FlyoutAction closeAction = new FlyoutAction();
            closeAction.Caption = Text;
            closeAction.Description = "Do you really want to close the demo?";
            closeAction.Commands.Add(FlyoutCommand.Yes);
            closeAction.Commands.Add(FlyoutCommand.No);
            return closeAction;
        }
    }
}
