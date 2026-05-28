using System.Windows.Forms;
using DevExpress.DentalClinic.ViewModel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.DentalClinic.View {
    public partial class InvoiceCollectionView : XtraUserControl {
        public InvoiceCollectionView() {
            InitializeComponent();
            repositoryItemImageComboBox1.Items.AddEnum(typeof(InvoiceInfoStatus), true);
            if(!mvvmContext.IsDesignMode)
                InitializeBindings();
        }
        void InitializeBindings() {
            var fluentAPI = mvvmContext.OfType<InvoiceCollectionViewModel>();
            fluentAPI.SetBinding(invoicesBindingSource, x => x.DataSource, x => x.Invoices);
            fluentAPI.WithEvent<RowClickEventArgs>(gvInvoices, "RowClick")
               .EventToCommand(x => x.Edit, args => GetInvoiceId(args));
        }
        int GetInvoiceId(RowClickEventArgs args) {
            if(args.Clicks == 2 && args.Button == MouseButtons.Left)
                return (gvInvoices.GetRow(args.RowHandle) as InvoiceInfo).InvoiceId;
            return -1;
        }
    }
}
