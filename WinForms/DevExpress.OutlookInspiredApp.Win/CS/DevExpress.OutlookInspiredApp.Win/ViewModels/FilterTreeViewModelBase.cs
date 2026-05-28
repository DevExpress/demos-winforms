using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using DevExpress.Data.Filtering;

namespace DevExpress.DevAV.ViewModels {
    public abstract class FilterItemBase {
        protected FilterItemBase() { }
        public virtual string Name { get; set; }
        public virtual CriteriaOperator FilterCriteria { get; set; }
    }
    public interface IFilterTreeModelPageSpecificSettings {
        string StaticFiltersTitle { get; }
        FilterInfoList StaticFilters { get; set; }
        FilterInfoList CustomFilters { get; set; }
        FilterInfoList GroupFilters { get; set; }
        ApplicationSettingsBase Settings { get; }
        IEnumerable<string> HiddenFilterProperties { get; }
        IEnumerable<string> AdditionalFilterProperties { get; }
    }
    
    public class FilterTreeModelPageSpecificSettings<TSettings> : IFilterTreeModelPageSpecificSettings
        where TSettings : ApplicationSettingsBase {
        readonly string staticFiltersTitleCore;
        readonly TSettings settingsCore;
        readonly PropertyDescriptor customFiltersProperty;
        readonly PropertyDescriptor staticFiltersProperty;
        readonly PropertyDescriptor groupFiltersProperty;
        readonly IEnumerable<string> hiddenFilterPropertiesCore;
        readonly IEnumerable<string> additionalFilterPropertiesCore;
        public FilterTreeModelPageSpecificSettings(TSettings settings, string staticFiltersTitle,
            Expression<Func<TSettings, FilterInfoList>> getStaticFiltersExpression,
            Expression<Func<TSettings, FilterInfoList>> getCustomFiltersExpression,
            Expression<Func<TSettings, FilterInfoList>> getGroupFiltersExpression,
            IEnumerable<string> hiddenFilterProperties = null,
            IEnumerable<string> additionalFilterProperties = null) {
            this.settingsCore = settings;
            this.staticFiltersTitleCore = staticFiltersTitle;
            staticFiltersProperty = GetProperty(getStaticFiltersExpression);
            customFiltersProperty = GetProperty(getCustomFiltersExpression);
            groupFiltersProperty = GetProperty(getGroupFiltersExpression);
            this.hiddenFilterPropertiesCore = hiddenFilterProperties;
            this.additionalFilterPropertiesCore = additionalFilterProperties;
        }
        FilterInfoList IFilterTreeModelPageSpecificSettings.CustomFilters {
            get { return GetFilters(customFiltersProperty); }
            set { SetFilters(customFiltersProperty, value); }
        }
        FilterInfoList IFilterTreeModelPageSpecificSettings.StaticFilters {
            get { return GetFilters(staticFiltersProperty); }
            set { SetFilters(staticFiltersProperty, value); }
        }
        FilterInfoList IFilterTreeModelPageSpecificSettings.GroupFilters {
            get { return GetFilters(groupFiltersProperty); }
            set { SetFilters(groupFiltersProperty, value); }
        }
        ApplicationSettingsBase IFilterTreeModelPageSpecificSettings.Settings {
            get { return settingsCore; }
        }
        string IFilterTreeModelPageSpecificSettings.StaticFiltersTitle {
            get { return staticFiltersTitleCore; }
        }
        IEnumerable<string> IFilterTreeModelPageSpecificSettings.HiddenFilterProperties {
            get { return hiddenFilterPropertiesCore; }
        }
        IEnumerable<string> IFilterTreeModelPageSpecificSettings.AdditionalFilterProperties {
            get { return additionalFilterPropertiesCore; }
        }
        PropertyDescriptor GetProperty(Expression<Func<TSettings, FilterInfoList>> expression) {
            if(expression != null)
                return TypeDescriptor.GetProperties(settingsCore)[GetPropertyName(expression)];
            return null;
        }
        FilterInfoList GetFilters(PropertyDescriptor property) {
            return property != null ? (FilterInfoList)property.GetValue(settingsCore) : null;
        }
        void SetFilters(PropertyDescriptor property, FilterInfoList value) {
            if(property != null)
                property.SetValue(settingsCore, value);
        }
        static string GetPropertyName(Expression<Func<TSettings, FilterInfoList>> expression) {
            MemberExpression memberExpression = expression.Body as MemberExpression;
            if(memberExpression == null) {
                throw new ArgumentException("expression");
            }
            return memberExpression.Member.Name;
        }
    }
    
    public class FilterInfo {
        public string Name { get; set; }
        public string FilterCriteria { get; set; }
        public string ImageUri { get; set; }
    }
    public class FilterInfoList : List<FilterInfo> {
        public FilterInfoList() { }
        public FilterInfoList(IEnumerable<FilterInfo> filters)
            : base(filters) {
        }
    }
    public abstract class FilterTreeViewModelBase {
        static FilterTreeViewModelBase() {
            var enums = typeof(EmployeeStatus).Assembly.GetTypes().Where(t => t.IsEnum);
            foreach(Type e in enums)
                EnumProcessingHelper.RegisterEnum(e);
        }
        protected readonly IFilterTreeModelPageSpecificSettings settingsCore;
        public FilterTreeViewModelBase(IFilterTreeModelPageSpecificSettings settings) {
            this.settingsCore = settings;
        }
        public virtual void Init() {
            StaticFilters = CreateFilterItems(settingsCore.StaticFilters);
            CustomFilters = CreateFilterItems(settingsCore.CustomFilters);
            SelectedItem = StaticFilters.FirstOrDefault();
        }
        public virtual ObservableCollection<FilterItemBase> StaticFilters {
            get;
            protected set;
        }
        public virtual ObservableCollection<FilterItemBase> CustomFilters {
            get;
            protected set;
        }
        public virtual FilterItemBase SelectedItem {
            get;
            set;
        }
        protected void AddNewCustomFilter(FilterItemBase filterItem) {
            var existing = CustomFilters.FirstOrDefault(fi => fi.Name == filterItem.Name);
            if(existing != null)
                CustomFilters.Remove(existing);
            CustomFilters.Add(filterItem);
            SaveCustomFilters();
        }
        public virtual void DeleteCustomFilter(FilterItemBase filterItem) {
            CustomFilters.Remove(filterItem);
            SaveCustomFilters();
        }
        public virtual void DuplicateFilter(FilterItemBase filterItem) {
            var newItem = CreateFilterItem("Copy of " + filterItem.Name, filterItem.FilterCriteria, null);
            CustomFilters.Add(newItem);
            SaveCustomFilters();
        }
        public virtual void ResetCustomFilters() {
            if(CustomFilters.Contains(SelectedItem))
                SelectedItem = null;
            settingsCore.CustomFilters = new FilterInfoList();
            CustomFilters.Clear();
            settingsCore.Settings.Save();
        }
        protected ObservableCollection<FilterItemBase> CreateFilterItems(IEnumerable<FilterInfo> filters) {
            if(filters == null)
                return new ObservableCollection<FilterItemBase>();
            var filtered = filters.Select(x => CreateFilterItem(x.Name, CriteriaOperator.Parse(x.FilterCriteria), x.ImageUri));
            return new ObservableCollection<FilterItemBase>(filtered);
        }
        protected abstract FilterItemBase CreateFilterItem(string name, CriteriaOperator filterCriteria, string imageUri);
        protected void SaveCustomFilters() {
            settingsCore.CustomFilters = SaveToSettings(CustomFilters);
            settingsCore.Settings.Save();
        }
        protected FilterInfoList SaveToSettings(ObservableCollection<FilterItemBase> filters) {
            return new FilterInfoList(filters.Select(fi => new FilterInfo {
                Name = fi.Name,
                FilterCriteria = CriteriaOperator.ToString(fi.FilterCriteria)
            }));
        }
        protected object ViewModel {
            get;
            private set;
        }
        public virtual void SetViewModel(object value) {
            ViewModel = value;
        }
    }
}
