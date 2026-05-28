using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.MVVM.Demos.ViewModels;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;

namespace DevExpress.MVVM.Demos.Navigation {
    public partial class TabControlModule : TutorialControl {
        public TabControlModule() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode)
                InitializeNavigation();
            xtraTabControl.SelectedPageChanged += xtraTabControl_SelectedPageChanged;
            ribbonControl.Merge += ribbonControl_Merge;
            LoadSourceCode(sourceCode, "InitializeNavigation");
        }
        void xtraTabControl_SelectedPageChanged(object sender, TabPageChangedEventArgs e) {
            if(e.Page == null)
                ribbonControl.UnMergeRibbon();
            else {
                var view = ((XtraTabPage)e.Page).Controls[0] as UserControl;
                var childRibbon = view.Controls.OfType<Control>()
                    .FirstOrDefault(c => c is RibbonControl) as RibbonControl;
                ribbonControl.MergeRibbon(childRibbon);
            }
        }
        void ribbonControl_Merge(object sender, XtraBars.Ribbon.RibbonMergeEventArgs e) {
            ribbonControl.SelectedPage = e.MergedChild.SelectedPage;
        }
        void InitializeNavigation() {
            // We want the XtraTabControl to be a navigation provider
            mvvmContext.RegisterService(DocumentManagerService.Create(xtraTabControl));
            // We want to use buttons in Ribbon to show the specific modules
            var fluent = mvvmContext.OfType<ExpensesDbContextViewModel>();
            fluent.BindCommand(biAccounts, x => x.Show, x => x.Modules[0]);
            fluent.BindCommand(biCategories, x => x.Show, x => x.Modules[1]);
            fluent.BindCommand(biTransactions, x => x.Show, x => x.Modules[2]);
            // We want show the default module when our UserControl is loaded
            fluent.WithEvent<EventArgs>(this, "Load")
                .EventToCommand(x => x.OnLoaded, x => x.DefaultModule);
        }
        void xtraTabControl1_CloseButtonClick(object sender, System.EventArgs e) {
            PageEventArgs ea = e as PageEventArgs;
            if(ea != null) {
                XtraTabPage page = ea.Page as XtraTabPage;
                if(page != null) page.Dispose();
            }
        }
    }
}
