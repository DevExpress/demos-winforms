using System;
using System.Linq;
using DevExpress.MVVM.Demos.ViewModels;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraEditors;

namespace DevExpress.MVVM.Demos.Views {
    public partial class TileCollectionViewModule : TutorialControl {
        public TileCollectionViewModule() {
            InitializeComponent();
            if(!DesignMode)
                InitBindings();
            LoadSourceCode(sourceCode, "InitBindings");
        }
        void InitBindings() {
            // All child Views, opened from this View, will be hosted within a Ribbon Form (double click rows to try this feature)
            mvvmContext.RegisterService(WindowedDocumentManagerService.CreateRibbonFormService(this));

            var fluent = mvvmContext.OfType<AccountCollectionViewModel>();
            TileGroup group = tileControl1.Groups[0];
            // Populating the current TileGroup with tiles, generated from the Entities collection.
            // Using the Clear and Prepare expressions allows these generated items to dynamically respond to modifying or removing records within the source
            fluent.SetItemsSourceBinding(
                group, // Target 
                g => g.Items, // Items Selector 
                x => x.Entities, // Source Selector  
                // Match Expression - checks whether or not this tile's tag matches the current entity
                (tileItem, entity) => object.Equals(tileItem.Tag, entity),
                // Create Expression - creates a new tile based on the current entity
                entity =>                                                  
                {
                    TileItem item = new TileItem();
                    item.Tag = entity;
                    item.ItemSize = TileItemSize.Wide;
                    var account = new TileItemElement();
                    account.Appearance.Normal.FontSizeDelta = 12;
                    item.Elements.Add(account);
                    var amount = new TileItemElement();
                    amount.TextAlignment = TileItemContentAlignment.BottomRight;
                    item.Elements.Add(amount);
                    return item;
                },
                // Clear Expression - removes a target tiles when its related source collection record is deleted 
                null,
                // Prepare Expression - modifies existing tiles
                (tileItem, entity) =>   
                {
                    tileItem.Elements[0].Text = entity.Name;
                    tileItem.Elements[1].Text = String.Format("{0:C}", entity.Amount);
                });
            // A two-way synchronization of the ViewModel.SelectedEntity and the TileControl.SelectedItem properties
            fluent.SetBinding(tileControl1, tc => tc.SelectedItem, x => x.SelectedEntity,
                (entity) => (TileItem)group.Items.FirstOrDefault(i => object.ReferenceEquals(i.Tag, entity)),
                item => (item != null) ? (Model.Account)item.Tag : null);
            // A double-click on a tile should invoke the Edit command for the related entity
            fluent.WithEvent<TileItemEventArgs>(tileControl1, "ItemDoubleClick")
                .EventToCommand(x => x.Edit, x => x.SelectedEntity);
        }
    }
}
