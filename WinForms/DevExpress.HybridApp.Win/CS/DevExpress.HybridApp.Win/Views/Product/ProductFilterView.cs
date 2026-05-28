using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.DevAV.ViewModels;
using DevExpress.XtraEditors;

namespace DevExpress.DevAV.Views {
    public partial class ProductFilterView : BaseFilterView {
        IDisposable itemsSourceBinding;
        IDisposable selectedItemBinding;

        public ProductFilterView() {
            InitializeComponent();
        }
        private void InitBindings() {
            var fluent = mvvmContext.OfType<ProductFilterViewModel>();
            itemsSourceBinding = fluent.SetItemsSourceBinding(tileGroup2,
                tg => tg.Items, x => x.StaticFilters,
                (item, filter) => object.Equals(item.Tag, filter),
                (filter) => CreateTileForFilter(filter),
                null,
                (item, filter) => UpdateTileItem(item, filter));
            selectedItemBinding = fluent.SetBinding(filterTileControl,
                x => x.SelectedItem, x => x.SelectedItem,
                filter => (TileItem)tileGroup2.Items.FirstOrDefault(item => Equals(item.Tag, filter)),
                item => item == null ? null : (FilterViewModelBase.FilterItem)item.Tag);
        }
        protected override void Init() {
            if(itemsSourceBinding != null) 
                itemsSourceBinding.Dispose();
            if(selectedItemBinding != null)
                selectedItemBinding.Dispose();
            InitBindings();
        }
    }
}
