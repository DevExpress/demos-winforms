using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.DevAV.Reports;
using DevExpress.DevAV.Services;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraReports;

namespace DevExpress.DevAV.ViewModels {
    public static class ReportInfoFactory {

        #region Employee

        public static IReportInfo EmployeeTaskList(IEnumerable<EmployeeTask> tasks) {
            return GetReportInfo(SortByDateViewModel.Create(), p => ReportFactory.EmployeeTaskList(tasks, p.SortDirection == SortByDatePrintMode.SortByDueDate));
        }

        public static IReportInfo EmployeeProfile(Employee employee, EmployeeEvaluationsPrintMode printMode) {
            return GetReportInfo(EmployeeEvaluationsPrintModeViewModel.Create(printMode), p => employee == null ? null : ReportFactory.EmployeeProfile(employee, p.EmployeeEvaluationsPrintMode != EmployeeEvaluationsPrintMode.ExcludeEvaluations));
        }

        public static IReportInfo EmployeeSummary(IEnumerable<Employee> employees) {
            return GetReportInfo(SortDirectionViewModel.Create(), p => ReportFactory.EmployeeSummary(employees, p.SortDirection == SortOrderPrintMode.AscendingOrder));
        }

        public static IReportInfo EmployeeDirectory(IEnumerable<Employee> employees) {
            return GetReportInfo(SortDirectionViewModel.Create(), p => ReportFactory.EmployeeDirectory(employees, p.SortDirection == SortOrderPrintMode.AscendingOrder));
        }

        #endregion

        #region Customer

        public static IReportInfo CustomerProfile(Customer customer) {
            return GetReportInfo(CustomerContactsPrintModeViewModel.Create(), p => customer == null ? null : ReportFactory.CustomerProfile(customer, p.CustomerContactsPrintMode != CustomerContactsPrintMode.ExcludeContacts));
        }

        public static IReportInfo CustomerContactsDirectory(Customer customer) {
            return GetReportInfo(SortDirectionViewModel.Create(), p => ReportFactory.CustomerContactsDirectory(customer.Employees, p.SortDirection == SortOrderPrintMode.AscendingOrder));
        }

        public static IReportInfo CustomerSalesDetail(IEnumerable<Order> orders) {
            return GetReportInfo(SortByAndDateRangeViewModel.Create(), p => ReportFactory.CustomerSalesDetail(orders, orders.SelectMany(x => x.OrderItems).ToArray(), p.SortDirection == SortByPrintMode.SortByOrderDate, p.FromDate, p.ToDate));
        }

        public static IReportInfo CustomerSalesDetailReport(IEnumerable<CustomerSaleDetailOrderInfo> orders) {
            var orderItems = orders.SelectMany(x => x.OrderItems).ToArray();
            return GetReportInfo(SortByAndDateRangeViewModel.Create(), p => ReportFactory.CustomerSalesDetailReport(orders, orderItems, p.SortDirection == SortByPrintMode.SortByOrderDate, p.FromDate, p.ToDate));
        }

        public static IReportInfo CustomerSalesSummary(IEnumerable<OrderItem> sales) {
            return GetReportInfo(SortByAndDateRangeViewModel.Create(), p => ReportFactory.CustomerSalesSummary(sales, p.SortDirection == SortByPrintMode.SortByOrderDate, p.FromDate, p.ToDate));
        }

        public static IReportInfo CustomerSalesSummaryReport(IEnumerable<CustomerSaleDetailOrderItemInfo> sales) {
            return GetReportInfo(SortByAndDateRangeViewModel.Create(), p => ReportFactory.CustomerSalesSummaryReport(sales, p.SortDirection == SortByPrintMode.SortByOrderDate, p.FromDate, p.ToDate));
        }

        public static IReportInfo CustomerLocationsDirectory(IEnumerable<Customer> customers) {
            return GetReportInfo(SortDirectionViewModel.Create(), p => ReportFactory.CustomerLocationsDirectory(customers, p.SortDirection == SortOrderPrintMode.AscendingOrder));
        }

        #endregion

        #region Order

        public static IReportInfo SalesInvoice(Order order) {
            return GetReportInfo(SortDirectionViewModel.Create(), p => ReportFactory.SalesInvoice(order, true, true, true, true));
        }

        public static IReportInfo SalesOrdersSummary(IEnumerable<OrderItem> sales) {
            return GetReportInfo(SortByAndDateRangeViewModel.Create(), p => ReportFactory.SalesOrdersSummary(sales, p.SortDirection == SortByPrintMode.SortByOrderDate, p.FromDate, p.ToDate));
        }

        public static IReportInfo SalesOrdersSummaryReport(IEnumerable<SaleSummaryInfo> sales) {
            return GetReportInfo(SortByAndDateRangeViewModel.Create(), p => ReportFactory.SalesOrdersSummaryReport(sales, p.SortDirection == SortByPrintMode.SortByOrderDate, p.FromDate, p.ToDate));
        }

        public static IReportInfo SalesAnalysis(IEnumerable<OrderItem> sales) {
            return GetReportInfo(SelectYearsViewModel.Create(), p => ReportFactory.SalesAnalysis(sales, p.Years));
        }

        public static IReportInfo SalesAnalysisReport(IEnumerable<SaleAnalysisInfo> sales) {
            return GetReportInfo(SelectYearsViewModel.Create(), p => ReportFactory.SalesAnalysisReport(sales, p.Years));
        }

        #endregion

        #region Product

        public static IReportInfo ProductProfile(Product product) {
            return GetReportInfo(ProductImagesPrintModeViewModel.Create(), p => ReportFactory.ProductProfile(product, p.ProductImagesPrintMode == ProductImagesPrintMode.DisplayProductImages));
        }

        public static IReportInfo ProductOrders(IEnumerable<OrderItem> sales, IList<State> states) {
            return GetReportInfo(SortByAndDateRangeViewModel.Create(), p => ReportFactory.ProductOrders(sales, states, p.SortDirection == SortByPrintMode.SortByOrderDate, p.FromDate, p.ToDate));
        }

        public static IReportInfo ProductSalesSummary(IEnumerable<OrderItem> sales) {
            return GetReportInfo(SelectYearsViewModel.Create(), p => ReportFactory.ProductSalesSummary(sales, p.Years));
        }

        public static IReportInfo ProductTopSalesPerson(IEnumerable<OrderItem> sales) {
            return GetReportInfo(SortDirectionViewModel.Create(), p => ReportFactory.ProductTopSalesPerson(sales, p.SortDirection == SortOrderPrintMode.AscendingOrder));
        }

        #endregion

        static IReportInfo GetReportInfo<TParametersViewModel>(TParametersViewModel parametersViewModel, Func<TParametersViewModel, IReport> reportFactory) {
            return new ReportInfo<TParametersViewModel>(parametersViewModel, reportFactory);
        }
    }

    public class SortByDateViewModel {
        public static SortByDateViewModel Create() {
            return ViewModelSource.Create(() => new SortByDateViewModel());
        }

        protected SortByDateViewModel() {
        }

        public virtual SortByDatePrintMode SortDirection { get; set; }
    }

    public class CustomerContactsPrintModeViewModel {
        public static CustomerContactsPrintModeViewModel Create() {
            return ViewModelSource.Create(() => new CustomerContactsPrintModeViewModel());
        }

        protected CustomerContactsPrintModeViewModel() {
        }

        public virtual CustomerContactsPrintMode CustomerContactsPrintMode { get; set; }
    }

    public class EmployeeEvaluationsPrintModeViewModel {
        public static EmployeeEvaluationsPrintModeViewModel Create(EmployeeEvaluationsPrintMode printMode) {
            EmployeeEvaluationsPrintModeViewModel viewModel = ViewModelSource.Create(() => new EmployeeEvaluationsPrintModeViewModel());
            viewModel.EmployeeEvaluationsPrintMode = printMode;
            return viewModel;
        }

        protected EmployeeEvaluationsPrintModeViewModel() {
        }

        public virtual EmployeeEvaluationsPrintMode EmployeeEvaluationsPrintMode { get; set; }
    }

    public class ProductImagesPrintModeViewModel {
        public static ProductImagesPrintModeViewModel Create() {
            return ViewModelSource.Create(() => new ProductImagesPrintModeViewModel());
        }

        protected ProductImagesPrintModeViewModel() {
        }

        public virtual ProductImagesPrintMode ProductImagesPrintMode { get; set; }
    }

    public class SelectYearsViewModel {
        public static SelectYearsViewModel Create() {
            return ViewModelSource.Create(() => new SelectYearsViewModel());
        }

        protected SelectYearsViewModel() {
            AvailableYears = new List<string>() { "2011", "2012", "2013", "2014", "2015" };
            Years = "2011,2012,2013";
        }

        public List<string> AvailableYears { get; set; }
        public virtual string Years { get; set; }
    }

    public class SortByViewModel {
        public static SortByViewModel Create() {
            return ViewModelSource.Create(() => new SortByViewModel());
        }

        protected SortByViewModel() {
        }

        public virtual SortByPrintMode SortDirection { get; set; }
    }

    public class SortByAndDateRangeViewModel : SortByViewModel {
        public new static SortByAndDateRangeViewModel Create() {
            return ViewModelSource.Create(() => new SortByAndDateRangeViewModel());
        }

        protected SortByAndDateRangeViewModel() {
            FromDate = new DateTime(2011, 1, 1);
            ToDate = new DateTime(2013, 1, 1);
        }

        public virtual DateTime ToDate { get; set; }
        public virtual DateTime FromDate { get; set; }
    }

    public class SortDirectionViewModel {
        public static SortDirectionViewModel Create() {
            return ViewModelSource.Create(() => new SortDirectionViewModel());
        }

        protected SortDirectionViewModel() {
        }

        public virtual SortOrderPrintMode SortDirection { get; set; }
    }

    public enum SortByDatePrintMode {
        [Description("Sort by Due Date")]
        SortByDueDate,
        [Description("Sort by Start Date")]
        SortByStartDate
    }

    public enum CustomerContactsPrintMode {
        IncludeContacts,
        ExcludeContacts,
    }

    public enum EmployeeEvaluationsPrintMode {
        ExcludeEvaluations,
        IncludeEvaluations,
    }

    public enum ProductImagesPrintMode {
        DisplayProductImages,
        HideProductImages,
    }

    public enum SortByPrintMode {
        [Description("Sort by Order Date")]
        SortByOrderDate,
        [Description("Sort by Invoice #")]
        SortByInvoice
    }

    public enum SortOrderPrintMode {
        AscendingOrder,
        DescendingOrder
    }
}
