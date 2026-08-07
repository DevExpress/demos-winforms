namespace DevExpress.DevAV.ViewModels {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DevExpress.DevAV.DevAVDbDataModel;
    using DevExpress.DXperience.Demos;

    public static class AnalysisPeriod {
        public static DatePeriod CalculateAnalysisPeriod(DateTime maxDate) {
            int versionYear = maxDate.Year;
            return new DatePeriod {
                Start = new DateTime(versionYear - 3, maxDate.Month, 1),
                End = new DateTime(versionYear, maxDate.Month, 1)
            };
        }
        public static DatePeriod CalculateReportPeriod(DateTime maxDate) {
            int currentYear = DateTime.Now.Year;
            int versionYear = maxDate.Year;
            int reportEndYear = versionYear - (versionYear < currentYear ? 0 : 1);

            return new DatePeriod {
                Start = new DateTime(reportEndYear - 2, 1, 1),
                End = new DateTime(reportEndYear, 12, 30)
            };
        }
        public static int MonthOffset(DateTime startDateTime, DateTime dateTime) {
            return (dateTime.Year - startDateTime.Year) * 12 + dateTime.Month - startDateTime.Month;
        }
        public class Item {
            public decimal Total { get; set; }
            public int Year { get; set; }
            public int Month { get; set; }
            public DateTime Date {
                get { return new DateTime(Year, Month, 1); }
            }
        }
        public class DatePeriod {
            public DateTime Start { get; set; }
            public DateTime End { get; set; }
        }
    }
    
    public static class AnalysisPeriodHelper {
        public static DateTime GetMaxOrdersDate(this IDevAVDbUnitOfWork UnitOfWork) {
            var orders = UnitOfWork.Orders;
            var dateRange =
                (from o in orders
                 group o by 1 into g
                 select new {
                     MaxDate = g.Max(x => x.OrderDate)
                 }).FirstOrDefault();
            return dateRange.MaxDate;
        }
    }
    
    public static class ProductsAnalysis {
#if NET
        public static IEnumerable<Item> GetFinancialReport(this IDevAVDbUnitOfWork UnitOfWork, DateTime startDate, DateTime endDate) {
            var orders = UnitOfWork.Orders;
            var orderItems =
                from oi in UnitOfWork.OrderItems
                join o in orders on oi.OrderId equals o.Id
                where (o.OrderDate >= startDate && o.OrderDate < endDate)
                select new {
                    Product = oi.Product,
                    Total = oi.Total,
                    FY = ((o.OrderDate.Year - startDate.Year) * 12 + (o.OrderDate.Month - startDate.Month)) / 12
                };
            return
                from oi in orderItems
                group oi by new { oi.Product.Id, oi.Product.Name, oi.FY } into g
                select new Item {
                    ProductName = g.Key.Name,
                    Year = startDate.Year + g.Key.FY,
                    Month = startDate.Month,
                    Total = g.Sum(o => o.Total)
                };
        }
        public static IEnumerable<Item> GetFinancialData(this IDevAVDbUnitOfWork UnitOfWork, DateTime startDate, DateTime endDate) {
            var orders = UnitOfWork.Orders;
            var orderItems =
                from oi in UnitOfWork.OrderItems
                join o in orders on oi.OrderId equals o.Id
                where (o.OrderDate >= startDate && o.OrderDate < endDate)
                select new {
                    Product = oi.Product,
                    Date = o.OrderDate,
                    Total = oi.Total
                };
            return
                from oi in orderItems
                group oi by new { oi.Product.Category, oi.Date.Year, oi.Date.Month } into g
                select new Item {
                    ProductCategory = g.Key.Category,
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    Total = g.Sum(o => o.Total)
                };
        }
#else
        public static IEnumerable<Item> GetFinancialReport(this IDevAVDbUnitOfWork UnitOfWork, DateTime startDate, DateTime endDate) {
            var orders = UnitOfWork.Orders;
            var orderItems =
                from oi in UnitOfWork.OrderItems
                join o in orders on oi.OrderId equals o.Id
                where (o.OrderDate >= startDate && o.OrderDate < endDate)
                select new {
                    Product = oi.Product,
                    Total = oi.Total,
                    FY = ((o.OrderDate.Year - startDate.Year) * 12 + (o.OrderDate.Month - startDate.Month)) / 12
                };
            return
                from oi in orderItems
                group oi by new { oi.Product, oi.FY } into g
                select new Item {
                    ProductName = g.Key.Product.Name,
                    Year = startDate.Year + g.Key.FY,
                    Month = startDate.Month,
                    Total = g.Select(o => (decimal?)o.Total).Sum() ?? 0
                };
        }
        public static IEnumerable<Item> GetFinancialData(this IDevAVDbUnitOfWork UnitOfWork, DateTime startDate, DateTime endDate) {
            var orders = UnitOfWork.Orders;
            var orderItems =
                from oi in UnitOfWork.OrderItems
                join o in orders on oi.OrderId equals o.Id
                where (o.OrderDate >= startDate && o.OrderDate < endDate)
                select new {
                    Product = oi.Product,
                    Date = o.OrderDate,
                    Total = oi.Total
                };
            return
                from oi in orderItems
                group oi by new { oi.Product.Category, oi.Date.Year, oi.Date.Month } into g
                select new Item {
                    ProductCategory = g.Key.Category,
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    Total = g.Select(o => (decimal?)o.Total).Sum() ?? 0
                };
        }
#endif
        public class Item : AnalysisPeriod.Item {
            public string ProductName { get; set; }
            public ProductCategory ProductCategory { get; set; }
        }
    }
    
    public static class CustomersAnalysis {
#if NET
        public static IEnumerable<Item> GetSalesReport(this IDevAVDbUnitOfWork UnitOfWork, DateTime startDate, DateTime endDate) {
            var orders = UnitOfWork.Orders;
            var orderItems =
                from oi in UnitOfWork.OrderItems
                join o in orders on oi.OrderId equals o.Id
                where (o.OrderDate >= startDate && o.OrderDate < endDate)
                select new {
                    Customer = o.Customer,
                    Total = oi.Total,
                    FY = ((o.OrderDate.Year - startDate.Year) * 12 + (o.OrderDate.Month - startDate.Month)) / 12
                };
            return
                from oi in orderItems
                group oi by new { oi.Customer.Id, oi.Customer.Name, oi.FY } into g
                select new Item {
                    CustomerName = g.Key.Name,
                    Year = startDate.Year + g.Key.FY,
                    Month = startDate.Month,
                    Total = g.Sum(o => o.Total)
                };
        }
        public static IEnumerable<Item> GetSalesData(this IDevAVDbUnitOfWork UnitOfWork, DateTime startDate, DateTime endDate) {
            var orders = UnitOfWork.Orders;
            var orderItems =
                from oi in UnitOfWork.OrderItems
                join o in orders on oi.OrderId equals o.Id
                where (o.OrderDate >= startDate && o.OrderDate < endDate)
                select new {
                    State = o.Store.Address.State,
                    OrderDate = o.OrderDate,
                    Total = oi.Total
                };
            return
                from oi in orderItems.AsEnumerable()
                group oi by new { oi.State, oi.OrderDate.Year, oi.OrderDate.Month } into g
                select new Item {
                    State = g.Key.State,
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    Total = g.Sum(o => o.Total)
                };
        }
#else
        public static IEnumerable<Item> GetSalesReport(this IDevAVDbUnitOfWork UnitOfWork, DateTime startDate, DateTime endDate) {
            var orders = UnitOfWork.Orders;
            var orderItems =
                from oi in UnitOfWork.OrderItems
                join o in orders on oi.OrderId equals o.Id
                where (o.OrderDate >= startDate && o.OrderDate < endDate)
                select new {
                    Customer = o.Customer,
                    Total = oi.Total,
                    FY = ((o.OrderDate.Year - startDate.Year) * 12 + (o.OrderDate.Month - startDate.Month)) / 12
                };
            return
                from oi in orderItems
                group oi by new { oi.Customer, oi.FY } into g
                select new Item {
                    CustomerName = g.Key.Customer.Name,
                    Year = startDate.Year + g.Key.FY,
                    Month = startDate.Month,
                    Total = g.Select(o => (decimal?)o.Total).Sum() ?? 0
                };
        }
        public static IEnumerable<Item> GetSalesData(this IDevAVDbUnitOfWork UnitOfWork, DateTime startDate, DateTime endDate) {
            var orders = UnitOfWork.Orders;
            var orderItems =
                from oi in UnitOfWork.OrderItems
                join o in orders on oi.OrderId equals o.Id
                where (o.OrderDate >= startDate && o.OrderDate < endDate)
                select new {
                    State = o.Store.Address.State,
                    Date = o.OrderDate,
                    Total = oi.Total
                };
            return
                from oi in orderItems
                group oi by new { oi.State, oi.Date.Year, oi.Date.Month } into g
                select new Item {
                    State = g.Key.State,
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    Total = g.Select(o => (decimal?)o.Total).Sum() ?? 0
                };
        }
#endif
        public class Item : AnalysisPeriod.Item {
            public string CustomerName { get; set; }
            public StateEnum State { get; set; }
        }
    }
}
