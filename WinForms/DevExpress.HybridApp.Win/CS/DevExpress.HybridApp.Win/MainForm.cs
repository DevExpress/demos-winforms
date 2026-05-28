using System;
using System.Drawing;
using System.Linq;
using DevExpress.DevAV.ViewModels;
using DevExpress.DevAV.Views;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.Taskbar;
using DevExpress.Utils.Taskbar.Core;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace DevExpress.DevAV {
    public partial class MainForm : XtraForm {
        static MainForm() {
            MVVMContext.RegisterFlyoutDialogService();
        }
        public MainForm() {
            TaskbarHelper.InitDemoJumpList(TaskbarAssistant.Default, this);
            SplashScreenManager.ShowSkinSplashScreen(Properties.Resources.DevExpress_Logo, title: "When Only the Best Will Do", subtitle: "DevExpress WinForms Controls");
            InitializeComponent();
            
            navButtonHome.Glyph = WindowExtensions.GetImage("navButtonHome");
            navButtonInfo.Glyph = WindowExtensions.GetImage("navButtonInfo");
            navButtonHelp.Glyph = WindowExtensions.GetImage("navButtonHelp");
            navButtonClose.Glyph = WindowExtensions.GetImage("navButtonClose");
            
            if(!mvvmContext.IsDesignMode)
                InitializeNavigation();
            DevExpress.Utils.About.UAlgo.Default.DoEventObject(DevExpress.Utils.About.UAlgo.kDemo, DevExpress.Utils.About.UAlgo.pWinForms, new HybridAppWin()); 
        }
        protected override FormShowMode ShowMode {
            get { return FormShowMode.AfterInitialization; }
        }
        protected override void OnShown(EventArgs e) {
            SplashScreenManager.CloseForm(false);
            base.OnShown(e);
        }
        void InitializeNavigation() {
            mvvmContext.RegisterService(DevExpress.Utils.MVVM.Services.DocumentManagerService.Create(navigationFrame));
            mvvmContext.RegisterService("FilterDialogService", DevExpress.Utils.MVVM.Services.DialogService.CreateFlyoutDialogService(this));
            
            var fluentAPI = mvvmContext.OfType<DevAVDbViewModel>();
            fluentAPI.SetItemsSourceBinding(tileBar,
                tb => tb.Groups, x => x.ModuleGroups,
                (group, moduleGroup) => object.Equals(group.Tag, moduleGroup),
                moduleGroup => CreateGroup(fluentAPI, moduleGroup)
            );
            fluentAPI.WithEvent(this, "Load")
                .EventToCommand(x => x.OnLoaded(null), x => x.DefaultModule);
            fluentAPI.WithEvent(this, "Closing")
                .EventToCommand(x => x.OnClosing(null));
            
            fluentAPI.BindCommand(navButtonInfo, x => x.Info());
            fluentAPI.BindCommand(navButtonHelp, x => x.About());
            fluentAPI.BindCommand(navButtonClose, x => x.Exit());
            
            tileBar.SelectedItem = GetItem(fluentAPI.ViewModel.DefaultModule);
        }
        public void ShowTileNavPane() {
            tileNavPane.Visible = true;
        }
        TileBarItem GetItem(DevAVDbModuleDescription defaultModule) {
            foreach(TileBarGroup gr in tileBar.Groups) {
                var item = gr.Items.FirstOrDefault(x => x.Tag == defaultModule) as TileBarItem;
                if(item != null) return item;
            }
            return null;
        }
        TileBarGroup CreateGroup(MVVMContextFluentAPI<DevAVDbViewModel> fluentAPI, IGrouping<string, DevAVDbModuleDescription> moduleGroup) {
            TileBarGroup group = new TileBarGroup() { Tag = moduleGroup };
            group.Text = moduleGroup.Key.ToUpper();
            foreach(DevAVDbModuleDescription module in moduleGroup)
                group.Items.Add(RegisterModuleItem(fluentAPI, module));
            return group;
        }
        TileBarItem RegisterModuleItem(MVVMContextFluentAPI<DevAVDbViewModel> fluentAPI, DevAVDbModuleDescription module) {
            TileBarItem item = new TileBarItem() { Tag = module };
            item.Text = module.ModuleTitle;
            item.Elements[0].ImageUri = MenuExtensions.GetImageUri(module.ModuleTitle);
            item.AppearanceItem.Normal.BackColor = TileColorConverter.GetBackColor(module);
            item.ItemSize = TileBarItemSize.Wide;
            if(module.FilterViewModel != null) {
                item.ShowDropDownButton = (module.FilterViewModel.CustomFilters.Count() > 0) ? Utils.DefaultBoolean.True : Utils.DefaultBoolean.False;
                item.DropDownControl = CreateFiltersContainer(module.FilterViewModel);
                item.DropDownOptions.BackColorMode = BackColorMode.UseTileBackColor;
            }
            fluentAPI.BindCommand(item, x => x.Show(null), x => module);
            return item;
        }
        TileBarDropDownContainer CreateFiltersContainer(FilterViewModelBase filterViewModel) {
            var filtersContainer = new TileBarDropDownContainer();
            BaseCustomFilterView filterBarView = new BaseCustomFilterView();
            filterBarView.SetViewModel(filterViewModel);
            filtersContainer.Controls.Add(filterBarView);
            return filtersContainer;
        }
        #region TileColorConverter
        static class TileColorConverter {
            public static Color GetBackColor(DevAVDbModuleDescription module) {
                switch(module.DocumentType) {
                    case DevAVDbViewModel.DashboardViewDocumentType:
                        return Color.FromArgb(0x00, 0x87, 0x9C);
                    case DevAVDbViewModel.EmployeeCollectionViewDocumentType:
                        return Color.FromArgb(0xCC, 0x6D, 0x00);
                    case DevAVDbViewModel.EmployeeTaskCollectionViewDocumentType:
                        return Color.FromArgb(0x40, 0x40, 0x40);
                    case DevAVDbViewModel.ProductCollectionViewDocumentType:
                        return Color.FromArgb(0x00, 0x73, 0xC4);
                    case DevAVDbViewModel.CustomerCollectionViewDocumentType:
                        return Color.FromArgb(0x40, 0x40, 0x40);
                    case DevAVDbViewModel.OrderCollectionViewDocumentType:
                        return Color.FromArgb(0x3E, 0x70, 0x38);
                    case DevAVDbViewModel.QuoteCollectionViewDocumentType:
                        return Color.FromArgb(0x40, 0x40, 0x40);
                }
                return Color.FromArgb(0x40, 0x40, 0x40);
            }
        }
        #endregion
    }
    public class HybridAppWin { }
}
