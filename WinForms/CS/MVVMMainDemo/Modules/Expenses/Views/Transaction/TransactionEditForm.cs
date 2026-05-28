using System.Windows.Forms;
using DevExpress.MVVM.Demos.ViewModels;

namespace DevExpress.MVVM.Demos.Views {
    [DevExpress.Utils.MVVM.UI.ViewType("TransactionView")]
    public partial class TransactionEditForm : UserControl {
        public TransactionEditForm() {
            InitializeComponent();
            if(!DesignMode)
                InitBindings();
        }
        void InitBindings() {
            var fluent = mvvmContext.OfType<TransactionViewModel>();
            fluent.WithEvent(this, "Load")
                .EventToCommand(x => x.OnLoaded);
            fluent.SetObjectDataSourceBinding(
                bindingSource, x => x.Entity, x => x.Update);
            //Populating lookup editor
            fluent.SetBinding(accountBindingSource, abs => abs.DataSource, x => x.LookUpAccounts.Entities);
            //Populating lookup editor
            fluent.SetBinding(categoryBindingSource, cbs => cbs.DataSource, x => x.LookUpCategories.Entities);

            bbiCustomize.ItemClick += (s, e) => dataLayout.ShowCustomizationForm();
        }
    }
}
