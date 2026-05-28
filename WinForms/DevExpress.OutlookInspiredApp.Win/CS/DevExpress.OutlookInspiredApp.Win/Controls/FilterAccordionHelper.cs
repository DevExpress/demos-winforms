using System.Collections.ObjectModel;

namespace DevExpress.DevAV.Modules {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DevExpress.Data.Helpers;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Mvvm.DataModel;
    using DevExpress.Utils.Menu;
    using DevExpress.XtraBars.Navigation;

    class FilterAccordionHelper<TEntity, TID, TUnitOfWork>
        where TEntity : class
        where TUnitOfWork : class, IUnitOfWork {
        AccordionControl accordion;
        public FilterAccordionHelper(AccordionControl accordion) {
            this.accordion = accordion;
        }

        public DXPopupMenu PopulateMenu(AccordionControlElement element, FilterTreeViewModel<TEntity, TID, TUnitOfWork> viewModel) {
            var menu = new DXPopupMenu();
            if(element.Style == ElementStyle.Group) {
                if(element.Text == FilterTreeViewModel<TEntity, TID, TUnitOfWork>.StaticFiltersName)
                    return null;
                if(element.Text == FilterTreeViewModel<TEntity, TID, TUnitOfWork>.GroupFiltersName) {
                    var newItem = new DXMenuItem();
                    newItem.Caption = "New Group...";
                    newItem.BindCommand(() => viewModel.NewGroup(), viewModel);
                    menu.Items.Add(newItem);
                }
                else {
                    var newItem = new DXMenuItem();
                    newItem.Caption = "New...";
                    newItem.BindCommand(() => viewModel.New(), viewModel);
                    menu.Items.Add(newItem);
                }
            }
            if(element.Style == ElementStyle.Item) {
                if(Match(element, viewModel.Groups)) {
                    var filterItemBase = element.Tag as FilterTreeViewModel<TEntity, TID, TUnitOfWork>.FilterItem;
                    var editItem = new DXMenuItem();
                    editItem.Caption = "Modify Group...";
                    var filterItem = FilterTreeViewModel<TEntity, TID, TUnitOfWork>.FilterItem.Create(filterItemBase.Name, filterItemBase.FilterCriteria);
                    editItem.BindCommand((f) => viewModel.ModifyGroup(f), viewModel, () => filterItemBase);
                    menu.Items.Add(editItem);
                    var deleteItem = new DXMenuItem();
                    deleteItem.Caption = "Delete Group";
                    deleteItem.BindCommand((f) => viewModel.DeleteGroup(f), viewModel, () => filterItemBase);
                    menu.Items.Add(deleteItem);
                }
                else {
                    if(Match(element, viewModel.StaticFilters))
                        return null;
                    var newItem = new DXMenuItem();
                    newItem.Caption = "New...";
                    newItem.BindCommand(() => viewModel.New(), viewModel);
                    menu.Items.Add(newItem);
                    if(element.Style == ElementStyle.Item) {
                        var filterItemBase = element.Tag as FilterItemBase;
                        var editItem = new DXMenuItem();
                        editItem.Caption = "Modify...";
                        var filterItem = viewModel.CustomFilters.FirstOrDefault(fi => fi.Name.Equals(filterItemBase.Name) && object.Equals(fi.FilterCriteria, filterItemBase.FilterCriteria));
                        editItem.BindCommand((f) => viewModel.Modify(f), viewModel, () => (FilterTreeViewModel<TEntity, TID, TUnitOfWork>.FilterItem)filterItem);
                        menu.Items.Add(editItem);
                        var deleteItem = new DXMenuItem();
                        deleteItem.Caption = "Delete";
                        deleteItem.BindCommand((f) => viewModel.Delete(f), viewModel, () => (FilterTreeViewModel<TEntity, TID, TUnitOfWork>.FilterItem)filterItem);
                        menu.Items.Add(deleteItem);
                    }
                }
            }
            return menu;
        }
        bool Match(AccordionControlElement element, object dataItem) {
            return (dataItem as ObservableCollection<FilterItemBase>).Any(fi => fi == (element.Tag as FilterItemBase));
        }
        public AccordionControlElement FindElementByTag(object dataItem) {
            if(dataItem == null)
                return accordion.Elements[0].Elements[0];
            foreach(var element in accordion.Elements) {
                var found = FindElementByTagRecursive(element, dataItem);
                if(found != null)
                    return found;
            }
            return accordion.Elements[0].Elements[0];
        }

        AccordionControlElement FindElementByTagRecursive(AccordionControlElement element, object dataItem) {
            if(object.Equals(element.Tag, dataItem))
                return element;
            foreach(var child in element.Elements) {
                var found = FindElementByTagRecursive(child, dataItem);
                if(found != null)
                    return found;
            }
            return null;
        }
    }
}
