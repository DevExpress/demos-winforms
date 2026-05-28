using System;
using System.Text;
using DevExpress.DentalClinic.ViewModel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DevExpress.DentalClinic.View {
    public partial class ProcedureHistoryView : XtraUserControl {
        public ProcedureHistoryView() {
            InitializeComponent();
            repositoryItemImageComboBox1.Items.AddEnum(typeof(InvoiceInfoStatus), true);
            if(!DesignMode)
                InitializeBinding();
        }
        void InitializeBinding() {
            var fluentApi = mvvmContext1.OfType<ProcedureHistoryViewModel>();
            fluentApi.SetBinding(invoiceInfoBindingSource, x => x.DataSource, x => x.Invoices);
            fluentApi.WithEvent(this, nameof(Load))
                .EventToCommand(x => x.Load);
            fluentApi.SetTrigger(x => x.LoadComplete, v => {
                if(v) {
                    pivotGridControl1.OptionsBehavior.BestFitMode = XtraPivotGrid.PivotGridBestFitMode.FieldValue;
                    pivotGridControl1.BestFitRowArea();
                }
            });
        }
    }
}
