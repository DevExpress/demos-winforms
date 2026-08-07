using System;
using System.Linq;
using DevExpress.DevAV.ViewModels;
using DevExpress.XtraEditors;

namespace DevExpress.DevAV.Views {
    public partial class EmployeesFilterView : BaseFilterView {
        public EmployeesFilterView() {
            InitializeComponent();
        }
        void InitBindings() {
            var fluent = mvvmContext.OfType<EmployeesFilterViewModel>();
            itemsSourceBinding = fluent.SetItemsSourceBinding(tileGroup2,
                tg => tg.Items, x => x.StaticFilters,
                (item, filter) => object.Equals(item.Tag, filter),
                (filter) => CreateTileForFilter(filter),
                null,
                (item, filter) => UpdateTileItem(item, filter));
            selectedItemBinding = fluent.SetBinding(filterTileControl,
                x => x.SelectedItem, x => x.SelectedItem,
                filter => (TileItem)tileGroup2.Items.FirstOrDefault(item => Equals(item.Tag, filter)),
                item => (FilterViewModelBase.FilterItem)item.Tag);
        }
        IDisposable itemsSourceBinding;
        IDisposable selectedItemBinding;
        protected override void Init() {
            if(selectedItemBinding != null)
                selectedItemBinding.Dispose();
            if(itemsSourceBinding != null)
                itemsSourceBinding.Dispose();
            InitBindings();
        }
    }
}
