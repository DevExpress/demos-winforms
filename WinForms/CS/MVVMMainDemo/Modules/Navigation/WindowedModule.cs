using System;
using DevExpress.MVVM.Demos.ViewModels;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.MVVM.Demos.Navigation {
    public partial class WindowedModule : TutorialControl {
        public WindowedModule() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode)
                InitializeNavigation();
            LoadSourceCode(sourceCode, "InitializeNavigation");
        }
        void InitializeNavigation() {
            // We want the default WindowedDocumentManagerService based on RibbonForm to be a navigation provider
            mvvmContext.RegisterService(WindowedDocumentManagerService.CreateRibbonFormService(this));
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
