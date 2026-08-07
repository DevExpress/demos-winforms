using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.DevAV.DevAVDbDataModel1;

namespace DevExpress.DevAV.ViewModels {
    public class DashboardViewModel {
        IDevAVDbUnitOfWork unitOfWork = UnitOfWorkSource.GetUnitOfWorkFactory().CreateUnitOfWork();
        public DashboardViewModel() {
            DashboardInitialization();
        }
        public virtual IList<OrderInfo> DashboardOrders { get; set; }
        public virtual IList<QuoteSummaryItem> SummaryOpportunities { get; set; }

        public virtual IList<CostAverageItem> CostSelectedItem { get; set; }
        public virtual IList<SalesSummaryItem> SalesSummarySelectedItem { get; set; }

        public virtual GoodSoldPeriod SelectedGoodSoldPeriod { get; set; }
        public virtual GoodSoldPeriod SelectedRevenuePeriod { get; set; }

        Dictionary<GoodSoldPeriod, IEnumerable<SalesSummaryItem>> salesSummaryItems;
        Dictionary<GoodSoldPeriod, IEnumerable<CostAverageItem>> costAverageItems;

        protected void OnSelectedGoodSoldPeriodChanged() {
            CostSelectedItem = costAverageItems[SelectedGoodSoldPeriod].ToList();
        }

        protected void OnSelectedRevenuePeriodChanged() {
            SalesSummarySelectedItem = salesSummaryItems[SelectedRevenuePeriod].ToList();
        }

        private void DashboardInitialization() {
            SummaryOpportunities = QueriesHelper.GetSummaryOpportunities(unitOfWork.Quotes).ToList();
            DashboardOrders = QueriesHelper.GetOrderInfo(unitOfWork.Orders);
            salesSummaryItems = GetSalesSummaryItems();
            costAverageItems = GetCostAverageItems();
            SalesSummarySelectedItem = salesSummaryItems[0].ToList();
            CostSelectedItem = costAverageItems[0].ToList();
        }

        Dictionary<GoodSoldPeriod, IEnumerable<CostAverageItem>> GetCostAverageItems() {
            return new Dictionary<GoodSoldPeriod, IEnumerable<CostAverageItem>>() {
                {GoodSoldPeriod.YTD, QueriesHelper.GetCostAverageItems(unitOfWork.OrderItems, Period.ThisYear)},
                {GoodSoldPeriod.ThisMonth, QueriesHelper.GetCostAverageItems(unitOfWork.OrderItems, Period.ThisMonth) },
                {GoodSoldPeriod.Today, QueriesHelper.GetCostAverageItems(unitOfWork.OrderItems, Period.FixedDate, LastOrderDate(unitOfWork))}
            };
        }
        static DateTime LastOrderDate(IDevAVDbUnitOfWork unitOfWork) {
            return unitOfWork.OrderItems.Where(x => x.Order.OrderDate <= DateTime.Today).Max(x => x.Order.OrderDate);
        }

        Dictionary<GoodSoldPeriod, IEnumerable<SalesSummaryItem>> GetSalesSummaryItems() {
            return new Dictionary<GoodSoldPeriod, IEnumerable<SalesSummaryItem>>() {
            { GoodSoldPeriod.YTD, QueriesHelper.GetSalesSummaryItems(unitOfWork.OrderItems, Period.ThisYear) },
            { GoodSoldPeriod.ThisMonth, QueriesHelper.GetSalesSummaryItems(unitOfWork.OrderItems, Period.ThisMonth) },
            { GoodSoldPeriod.Today, QueriesHelper.GetSalesSummaryItems(unitOfWork.OrderItems, Period.FixedDate, LastOrderDate(unitOfWork)) }
            };
        }
    }

    public enum GoodSoldPeriod {
        Today,
        ThisMonth,
        YTD,
    }
}
