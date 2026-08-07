using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DevExpress.Data.Utils;
using DevExpress.DevAV.Common.DataModel;
using DevExpress.Mvvm.POCO;

namespace DevExpress.DevAV.ViewModels {
    public partial class QuoteCollectionViewModel {

        const int NumberOfAverageQuotes = 300;

        protected override void OnInitializeInRuntime() {
            base.OnInitializeInRuntime();
            MapViewModel = MapViewModel.Create().SetParentViewModel(this);
            UpdateAverageQuotes();
        }
        private IList<QuoteSummaryItem> GetOpportunitiesInfo(DateTime start, DateTime end) {
            return QueriesHelper.GetSummaryOpportunities(CreateReadOnlyRepository().GetFilteredEntities(null).Where(x => x.Date >= start && x.Date <= end)).ToList();
        }
        public IList<QuoteSummaryItem> OpportunitiesInfo { get { return GetOpportunitiesInfo(Range.Minimum, Range.Maximum); } }

        public virtual DateRange Range { get; set; }

        protected void OnRangeChanged() {
            this.RaisePropertyChanged(x => x.OpportunitiesInfo);
            this.FilterExpression = CriteriaOperatorToExpressionConverter.GetGenericWhere<Quote>(ConverterExtensions.ConvertEditRangeToFilterCriteria(Range, "Date"));
        }

        public virtual List<Quote> AverageQuotes { get; protected set; }

        void UpdateAverageQuotes() {
            AverageQuotes = QueriesHelper.GetAverageQuotes(CreateReadOnlyRepository().GetFilteredEntities(null), NumberOfAverageQuotes);
        }

        public MapViewModel MapViewModel { get; private set; }

        protected override void OnIsLoadingChanged() {
            base.OnIsLoadingChanged();
            if(!IsLoading) {
                MapViewModel.Update(GetMapItems());
            }
        }

        public List<MapItemModel> GetMapItems() {
            IEnumerable<MapItemModel> mapItems;
            var items = GetOpportunities(Stage.Summary, x => x.Date > Range.Minimum && x.Date < Range.Maximum).GroupBy(item => item.Address, new AddressComparer());

            if(items.Count() > 0) {
                mapItems = items.Select(group => new MapItemModel {
                    City = group.Key.City,
                    Latitude = group.Key.Latitude,
                    Longitude = group.Key.Longitude,
                    TotalSales = group.CustomSum(item => item.Value),
                });
            }
            else
                mapItems = Enumerable.Empty<MapItemModel>();
            return mapItems.ToList();
        }

        IList<QuoteMapItem> GetOpportunities(Stage stage, Expression<Func<Quote, bool>> filterExpression = null) {
            var unitOfWork = unitOfWorkFactory.CreateUnitOfWork();
            var quotes = unitOfWork.Quotes.GetFilteredEntities(filterExpression).ActualQuotes();
            return QueriesHelper.GetOpportunities(quotes, unitOfWork.Customers, stage).ToList();
        }
    }

    class AddressComparer : IEqualityComparer<Address> {
        public bool Equals(Address x, Address y) {
            return x.State.Equals(y.State) && x.City.Equals(y.City);
        }
        public int GetHashCode(Address obj) {
            return obj.State.GetHashCode() ^ obj.City.GetHashCode();
        }
    }
}
