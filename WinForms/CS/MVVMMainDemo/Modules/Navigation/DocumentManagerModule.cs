using System;
using DevExpress.MVVM.Demos.ViewModels;
using DevExpress.Utils.MVVM.Services;

namespace DevExpress.MVVM.Demos.Navigation {
    public partial class DocumentManagerModule : TutorialControl {
        public DocumentManagerModule() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode)
                InitializeNavigation();
            ribbonControl.Merge += ribbonControl_Merge;
            LoadSourceCode(sourceCode, "InitializeNavigation");
        }
        void ribbonControl_Merge(object sender, XtraBars.Ribbon.RibbonMergeEventArgs e) {
            e.MergedChild.Visible = false;
            ribbonControl.SelectedPage = e.MergedChild.SelectedPage;
        }
        void InitializeNavigation() {
            // We want the DocmentManager's TabbedView to be a navigation provider
            mvvmContext.RegisterService(DocumentManagerService.Create(tabbedView));
            // We want to use buttons in Ribbon to show the specific modules
            var fluent = mvvmContext.OfType<ExpensesDbContextViewModel>();
            fluent.BindCommand(biAccounts, x => x.Show, x => x.Modules[0]);
            fluent.BindCommand(biCategories, x => x.Show, x => x.Modules[1]);
            fluent.BindCommand(biTransactions, x => x.Show, x => x.Modules[2]);
            // We want show the default module when our UserControl is loaded
            fluent.WithEvent<EventArgs>(this, "Load")
                .EventToCommand(x => x.OnLoaded, x => x.DefaultModule);
        }
    }
}
