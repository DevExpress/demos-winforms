using DevExpress.MVVM.Demos.ViewModels;
using DevExpress.Utils.MVVM;

namespace DevExpress.MVVM.Demos.Views {
    public partial class DataLayoutViewModule : TutorialControl {
        public DataLayoutViewModule() {
            InitializeComponent();
            if(!DesignMode) {
                InitBindings();
                //Here we will force first entity loading by its primary key
                MVVMContext.SetParameter(this, (long)1);
            }
            LoadSourceCode(sourceCode, "InitBindings");
        }
        void InitBindings() {
            var fluent = mvvmContext.OfType<TransactionViewModel>();
            // We want all changes in editors to be synchronized with ViewModel state
            fluent.SetObjectDataSourceBinding(
                transactionBindingSource, x => x.Entity, x => x.Update);
            // We want user can select specific Account from LookUp
            fluent.SetBinding(accountBindingSource,
                abs => abs.DataSource, x => x.LookUpAccounts.Entities);
            // We want user can select specific Category from LookUp
            fluent.SetBinding(categoryBindingSource,
                cbs => cbs.DataSource, x => x.LookUpCategories.Entities);
        }
    }
}
