using System;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM.UI;
using DevExpress.DevAV.ViewModels;
using DevExpress.Data.Filtering;

namespace DevExpress.DevAV.Views {
    [ViewType(DevAVDbViewModel.CustomFilterViewDocumentType)]
    public partial class CustomFilterView : XtraUserControl {
        public CustomFilterView() {
            InitializeComponent();
            FilterControlWithoutLike.Apply(filterControl);
        }
        void CustomFilterView_Load(object sender, EventArgs e) {
            if(!mvvmContext.IsDesignMode)
                InitBinding();
        }
        void InitBinding() {
            var fluentAPI = mvvmContext.OfType<CustomFilterViewModel>();
            fluentAPI.SetBinding(checkEdit, ce => ce.Checked, x => x.Save);
            fluentAPI.SetBinding(textEdit, te => te.Text, x => x.FilterName);
            if(fluentAPI.ViewModel.EntityType == typeof(Customer))
                BuildFilterColumnsForCustomer();
            if(fluentAPI.ViewModel.EntityType == typeof(Product))
                BuildFilterColumnsForProduct();
            fluentAPI.SetBinding(filterControl, fc => fc.FilterString, x => x.FilterCriteria,
                criteria => CriteriaOperator.ToString(criteria), filter => CriteriaOperator.Parse(filter));
        }
        void BuildFilterColumnsForProduct() {
            var builder = new FilterColumnCollectionBuilder<Product>(filterControl.FilterColumns);
            builder
                .AddColumn(e => e.Name)
                .AddColumn(e => e.Available)
                .AddColumn(e => e.Cost)
                .AddColumn(e => e.CurrentInventory)
                .AddColumn(e => e.RetailPrice)
                .AddColumn(e => e.SalePrice)
                .AddDateTimeColumn(e => e.ProductionStart)
                .AddLookupColumn(e => e.Category);
        }
        void BuildFilterColumnsForCustomer() {
            var builder = new FilterColumnCollectionBuilder<Customer>(filterControl.FilterColumns);
            builder
                .AddColumn(c => c.Name)
                .AddColumn(c => c.HomeOffice.Line)
                .AddColumn(c => c.Phone)
                .AddColumn(c => c.Fax)
                .AddColumn(c => c.Website)
                .AddColumn(c => c.TotalEmployees)
                .AddColumn(c => c.TotalStores)
                .AddLookupColumn(c => c.Status)
                .AddLookupColumn(c => c.HomeOffice.State);
        }
    }
}
