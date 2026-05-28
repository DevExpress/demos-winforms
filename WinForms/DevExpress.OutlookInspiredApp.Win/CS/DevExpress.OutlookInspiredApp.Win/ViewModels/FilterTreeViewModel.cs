namespace DevExpress.DevAV.ViewModels {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;
    using DevExpress.Data.Filtering;
    using DevExpress.Data.Filtering.Helpers;
    using DevExpress.Data.Utils;
    using DevExpress.DevAV.Common.ViewModel;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.DataAnnotations;
    using DevExpress.Mvvm.DataModel;
    using DevExpress.Mvvm.POCO;

    public class FilterTreeViewModel<TEntity, TPrimaryKey, TUnitOfWork> : FilterTreeViewModelBase
        where TEntity : class
        where TUnitOfWork : class, IUnitOfWork {
        public const string StaticFiltersName = "Favorites";
        public const string CustomFiltersName = "Custom Filters";
        public const string GroupFiltersName = "Groups";

        public FilterTreeViewModel(
            CollectionViewModel<TEntity, TPrimaryKey, TUnitOfWork> colViewModel,
            IFilterTreeModelPageSpecificSettings settings) :
            base(settings) {
            SetViewModel(colViewModel);
            ViewModelHelper.EnsureViewModel(this, colViewModel);
            Init();
            ISupportCustomFilters scf = colViewModel as ISupportCustomFilters;
            if(scf != null)
                scf.CustomFiltersReset += scf_CustomFiltersReset;
        }
        void scf_CustomFiltersReset(object sender, EventArgs e) {
            ResetCustomFilters();
        }
        protected internal CollectionViewModel<TEntity, TPrimaryKey, TUnitOfWork> CollectionViewModel {
            get { return (CollectionViewModel<TEntity, TPrimaryKey, TUnitOfWork>)ViewModel; }
        }
        protected virtual void OnSelectedItemChanged() {
            this.RaiseCanExecuteChanged(x => x.Select(null));
            RaiseSelectedItemChanged();
            ApplyFilter(SelectedItem);
        }
        public bool CanSelectModule(FilterItem item) {
            return SelectedItem != item;
        }
        [Command]
        public void Select(FilterItem item) {
            SelectedItem = item;
        }
        public event EventHandler SelectedItemChanged;
        void RaiseSelectedItemChanged() {
            if(SelectedItemChanged != null)
                SelectedItemChanged(this, EventArgs.Empty);
        }
        void ApplyFilter(FilterItemBase fItem) {
            if(fItem != null && !object.ReferenceEquals(fItem.FilterCriteria, null))
                CollectionViewModel.FilterExpression = GetFilterExpression(fItem);
            else
                CollectionViewModel.FilterExpression = null;
        }
        public event EventHandler FilterAccordionChanged;
        void RaiseFilterAccordionChanged() {
            if(FilterAccordionChanged != null)
                FilterAccordionChanged(this, EventArgs.Empty);
        }
        protected override FilterItemBase CreateFilterItem(string name, CriteriaOperator filterCriteria, string imageUri) {
            return FilterItem.Create(name, filterCriteria);
        }
        
        [Command]
        public void New() {
            var newFilterItem = CreateFilterItem(null, null, null);
            CustomFilterViewModel customViewModel = CreateCustomFilterViewModel<CustomFilterViewModel>(newFilterItem);
            if(ShowFilterDialog(customViewModel, "Custom Filter")) {
                if(customViewModel.Save) {
                    AddNewCustomFilter(newFilterItem);
                    RaiseFilterAccordionChanged();
                }
                SelectedItem = newFilterItem;
            }
        }
        [Command]
        public void Modify(FilterItem item) {
            CustomFilterViewModel customViewModel = CreateCustomFilterViewModel<CustomFilterViewModel>(item);
            if(ShowFilterDialog(customViewModel, "Custom Filter")) {
                if(customViewModel.Save) {
                    SaveCustomFilters();
                    RaiseFilterAccordionChanged();
                }
                ApplyFilter(item);
            }
        }
        [Command]
        public void Delete(FilterItem item) {
            DeleteCustomFilter(item);
            RaiseFilterAccordionChanged();
            if(SelectedItem == item)
                SelectedItem = null;
        }
        [Command]
        public void NewGroup() {
            NewGroupCore(CreateFilterItem(null, null, null));
        }
        [Command]
        public void NewGroupFromSelection(IEnumerable<TEntity> selection) {
            NewGroupCore(CreateFilterItem(null, CollectionViewModel.GetInOperator(selection), null));
        }
        public virtual ObservableCollection<FilterItemBase> Groups {
            get;
            protected set;
        }
        public virtual void AddNewGroupFilter(FilterItemBase fItem) {
            Groups.Add(fItem);
            SaveGroupFilters();
        }
        public virtual void DeleteGroupFilter(FilterItemBase fItem) {
            Groups.Remove(fItem);
            SaveGroupFilters();
        }
        public virtual void ModifyGroupFilter(FilterItemBase fItem) {
            SaveGroupFilters();
        }
        void SaveGroupFilters() {
            settingsCore.GroupFilters = SaveToSettings(Groups);
            settingsCore.Settings.Save();
        }
        public override void Init() {
            Groups = CreateFilterItems(settingsCore.GroupFilters);
            base.Init();
        }
        void NewGroupCore(FilterItemBase newFilterItem) {
            GroupFilterViewModel gViewModel = CreateCustomFilterViewModel<GroupFilterViewModel>(newFilterItem);
            if(ShowFilterDialog(gViewModel, "Group Filter")) {
                if(gViewModel.Save) {
                    AddNewGroupFilter(newFilterItem);
                    RaiseFilterAccordionChanged();
                }
                SelectedItem = newFilterItem;
            }
        }
        [Command]
        public void ModifyGroup(FilterItem item) {
            GroupFilterViewModel gViewModel = CreateCustomFilterViewModel<GroupFilterViewModel>(item);
            if(ShowFilterDialog(gViewModel, "Group Filter")) {
                if(gViewModel.Save) {
                    ModifyGroupFilter(item);
                    RaiseFilterAccordionChanged();
                }
                ApplyFilter(item);
            }
        }
        [Command]
        public void DeleteGroup(FilterItem item) {
            DeleteGroupFilter(item);
            RaiseFilterAccordionChanged();
            if(SelectedItem == item)
                SelectedItem = null;
        }
        public override void ResetCustomFilters() {
            base.ResetCustomFilters();
            RaiseFilterAccordionChanged();
        }
        protected virtual T CreateCustomFilterViewModel<T>(FilterItemBase fItem) where T : FilterViewModelBase, new() {
            T filterViewModel = ViewModelSource.Create<T>();
            ViewModelHelper.EnsureViewModel(filterViewModel, CollectionViewModel, fItem);
            return filterViewModel;
        }
        bool ShowFilterDialog(FilterViewModelBase filterViewModel, string key) {
            var service = this.GetService<IDocumentManagerService>(key);
            if(service != null) {
                var document = service.CreateDocument(key, filterViewModel, null, CollectionViewModel);
                filterViewModel.Document = document;
                document.Show();
                return filterViewModel.Result.GetValueOrDefault();
            }
            return false;
        }
        protected virtual bool EnableGroups {
            get { return true; }
        }
        public string GetFilterName(object filtersCollection, FilterItemBase filter) {
            if(filter != null) {
                var count = CollectionViewModel.GetEntitiesCount(GetFilterExpression(filter));
                if(count > 0)
                    return filter.Name + " (" + count + ")";
                else
                    return filter.Name;
            }
            else {
                if(object.Equals(filtersCollection, StaticFilters))
                    return StaticFiltersName;
                if(object.Equals(filtersCollection, CustomFilters))
                    return CustomFiltersName;
                if(object.Equals(filtersCollection, Groups))
                    return GroupFiltersName;
            }
            return null;
        }
        public IList GetChildren(object dataItem) {
            if(dataItem == this) {
                if(EnableGroups)
                    return (IList)(new List<object> { StaticFilters, CustomFilters, Groups });
                else
                    return (IList)(new List<object> { StaticFilters, CustomFilters });
            }
            if(dataItem is System.Collections.ObjectModel.ObservableCollection<FilterItemBase>)
                return (IList)dataItem;
            return null;
        }
        internal static Expression<Func<TEntity, bool>> GetFilterExpression(CriteriaOperator criteria) {
            return FilterExpressionFactory<TEntity>.CreateFilterExpression(criteria);
        }
        static Expression<Func<TEntity, bool>> GetFilterExpression(FilterItemBase filter) {
            return FilterExpressionFactory<TEntity>.CreateFilterExpression(filter.FilterCriteria);
        }
        #region Filter Item ViewModels
        public class FilterItem : FilterItemBase {
            public static FilterItem Create(string filterName, CriteriaOperator filterCriteria) {
                return ViewModelSource.Create(() => new FilterItem(filterName, filterCriteria));
            }
            protected FilterItem(string name, CriteriaOperator filterCriteria) {
                this.Name = name;
                this.FilterCriteria = filterCriteria;
            }
        }
        #endregion Items
    }
    #region Custom Filter ViewModel
    [POCOViewModel(ImplementIDataErrorInfo = true)]
    public abstract class FilterViewModelBase : ISupportParameter {
        public FilterViewModelBase() {
            Save = true;
        }
        FilterItemBase filterItem;
        public IDocument Document {
            get;
            set;
        }
        public bool? Result {
            get;
            private set;
        }
        public virtual bool Save {
            get;
            set;
        }
        [Required]
        public virtual string Name {
            get;
            set;
        }
        public CriteriaOperator FilterCriteria {
            get { return filterItem.FilterCriteria; }
        }
        public event EventHandler<QueryFilterCriteriaEventArgs> QueryFilterCriteria;
        void RaiseQueryFilterCriteria() {
            EventHandler<QueryFilterCriteriaEventArgs> handler = QueryFilterCriteria;
            if(handler != null)
                handler(this, new QueryFilterCriteriaEventArgs(filterItem));
        }
        protected IMessageBoxService MessageBoxService {
            get { return this.GetService<IMessageBoxService>(); }
        }
        protected abstract string GetDefaultName();
        
        [Command]
        public void OK() {
            Result = true;
            if(string.IsNullOrEmpty(Name))
                Name = GetDefaultName();
            if(Save)
                filterItem.Name = Name;
            RaiseQueryFilterCriteria();
            Document.Close();
        }
        [Command]
        public void Cancel() {
            Result = false;
            Document.Close();
        }
        object ISupportParameter.Parameter {
            get { return filterItem; }
            set {
                filterItem = (FilterItemBase)value;
                Name = filterItem.Name;
            }
        }
    }
    public class QueryFilterCriteriaEventArgs : EventArgs {
        FilterItemBase item;
        public QueryFilterCriteriaEventArgs(FilterItemBase item) {
            this.item = item;
        }
        public CriteriaOperator FilterCriteria {
            get { return item.FilterCriteria; }
            set { item.FilterCriteria = value; }
        }
    }
    public class CustomFilterViewModel : FilterViewModelBase {
        static int id = 0;
        protected override string GetDefaultName() {
            return "Custom Filter " + (id++).ToString();
        }
    }
    public class GroupFilterViewModel : FilterViewModelBase {
        static int id = 0;
        protected override string GetDefaultName() {
            return "Group " + (id++).ToString();
        }
    }
    #endregion
    
    static class FilterExpressionFactory<TEntity> {
        public static Expression<Func<TEntity, bool>> CreateFilterExpression(CriteriaOperator criteria) {
            try {
                var nullValueSafeCriteria = criteria.ReferenceEqualsNull() ?
                    criteria : criteria.Accept(new NullValueToNullString());
                var caseInsensitiveCriteria = Data.Helpers.StringsTolowerCloningHelper.Process(nullValueSafeCriteria);
                return CriteriaOperatorToExpressionConverter.GetGenericWhere<TEntity>(caseInsensitiveCriteria);
            }
            catch(Exception e) {
                throw new NotSupportedException("Error in Filter:" + CriteriaOperator.ToString(criteria), e);
            }
        }
        sealed class NullString : ICustomFunctionOperator, ICustomFunctionOperatorConvertibleToExpression {
            internal static readonly NullString Instance = new NullString();
            public string Name { get { return "NullString"; } }
            public Expression Convert(Data.Linq.ICriteriaToExpressionConverter converter, params Expression[] operands) {
                return Expression.Constant(null, typeof(string));
            }
            public object Evaluate(params object[] operands) {
                return null;
            }
            public Type ResultType(params Type[] operands) {
                return typeof(string);
            }
        }
        sealed class NullValueToNullString : Data.Filtering.Helpers.ClientCriteriaClonerBase.DeepValuesCloneBase {
            static NullValueToNullString() {
                CriteriaOperator.RegisterCustomFunction(NullString.Instance);
            }
            public override CriteriaOperator Visit(FunctionOperator theOperator) {
                if(theOperator.OperatorType >= FunctionOperatorType.StartsWith && theOperator.OperatorType <= FunctionOperatorType.EndsWith) {
                    OperandValue value = null;
                    if(theOperator.Operands[1].Is(out value) && value.XmlValue is NullValue)
                        theOperator.Operands[1] = new FunctionOperator(FunctionOperatorType.Custom, "NullString");
                }
                return base.Visit(theOperator);
            }
        }
    }
}
