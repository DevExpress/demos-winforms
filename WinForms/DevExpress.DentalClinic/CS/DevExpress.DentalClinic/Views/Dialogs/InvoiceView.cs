using DevExpress.DentalClinic.Model;
using DevExpress.DentalClinic.ViewModel;
using DevExpress.XtraEditors;

namespace DevExpress.DentalClinic.View {
    public partial class InvoiceView : XtraUserControl {
        public InvoiceView() {
            InitializeComponent();
            rgPaymentMethod.Properties.Items.AddEnum(typeof(PaymentMethod));
            rgStatus.Properties.Items.AddEnum(typeof(PaymentStatus));
            if(!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }
        void InitializeBindings() {
            var fluentAPI = mvvmContext1.OfType<InvoiceViewModel>();
            fluentAPI.BindCommand(sbCreate, x => x.Save);
            fluentAPI.BindCommand(sbPrint, x => x.Print);
            fluentAPI.SetBinding(sbCreate, x => x.Text, x => x.ButtonText);
            fluentAPI.SetBinding(xpBindingSourceInvoice, x => x.DataSource, x => x.Invoice);
            fluentAPI.SetBinding(xpBindingSourceProcedureItem, x => x.DataSource, x => x.Procedures);
            fluentAPI.SetBinding(DiscountTextEdit, x => x.EditValue, x => x.Discount);
            fluentAPI.SetBinding(headerTextLabel, x => x.Text, x => x.InvoiceHeader);
        }
    }
}
