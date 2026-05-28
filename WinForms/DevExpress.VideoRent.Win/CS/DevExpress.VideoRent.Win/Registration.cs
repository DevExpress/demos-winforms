using System;
using DevExpress.VideoRent.Reports;
using DevExpress.VideoRent.Resources;

namespace DevExpress.VideoRent.Win {
    [Flags]
    public enum DemoProducts { None = 0, Grid = 1, Reports = 2, Charts = 4, Pivot = 8, Scheduler = 16 }; 
    public class RegisterTutorials {
        public static void Register() {
            DemosInfo.Add(ConstStrings.Get("AboutGroup"), typeof(DevExpress.VideoRent.Win.Modules.About), "", null, ConstStrings.Get("AboutGroup"));
            DemosInfo.Add(ConstStrings.Get("RentModule"), typeof(DevExpress.VideoRent.Win.Modules.Rent), "", "Sale", ConstStrings.Get("RentalGroup"), DemoProducts.Grid);
            DemosInfo.Add(ConstStrings.Get("CustomersModule"), typeof(DevExpress.VideoRent.Win.Modules.Customers), "", "Person", ConstStrings.Get("RentalGroup"), DemoProducts.Grid);
            DemosInfo.Add(ConstStrings.Get("MoviesModule"), typeof(DevExpress.VideoRent.Win.Modules.Movies), "", "Movie", ConstStrings.Get("CatalogGroup"), DemoProducts.Grid);
            DemosInfo.Add(ConstStrings.Get("MovieCategories"), typeof(DevExpress.VideoRent.Win.Modules.Categories), "", "Categories", ConstStrings.Get("CatalogGroup"), DemoProducts.None);
            DemosInfo.Add(ConstStrings.Get("ActorsModule"), typeof(DevExpress.VideoRent.Win.Modules.Artists), "", "Actor", ConstStrings.Get("CatalogGroup"), DemoProducts.Grid);
            DemosInfo.Add(ConstStrings.Get("CompaniesModule"), typeof(DevExpress.VideoRent.Win.Modules.Companies), "", "Company", ConstStrings.Get("CatalogGroup"), DemoProducts.Grid);
            DemosInfo.Add(ConstStrings.Get("MoviesKPIModule"), typeof(DevExpress.VideoRent.Win.ModulesKPI.MoviesKPI), "", "MoviesKPI", ConstStrings.Get("KPIGroup"), DemoProducts.Pivot);
            DemosInfo.Add(ConstStrings.Get("CustomersKPIModule"), typeof(DevExpress.VideoRent.Win.ModulesKPI.CustomersKPI), "", "CustomersKPI", ConstStrings.Get("KPIGroup"), DemoProducts.Pivot);
            DemosInfo.Add(ConstStrings.Get("CustomersDatesModule"), typeof(DevExpress.VideoRent.Win.ModulesKPI.CustomersByDatesKPI), "", "CustomersByDate", ConstStrings.Get("KPIGroup"), DemoProducts.Pivot);
            DemosInfo.Add(ConstStrings.Get("Revenue12MonthsModule"), typeof(DevExpress.VideoRent.Win.ModulesStatistics.NetIncomeStatistics), "", "Revenue", ConstStrings.Get("StatisticsGroup"));
            DemosInfo.Add(ConstStrings.Get("RevenueSplitModule"), typeof(DevExpress.VideoRent.Win.ModulesStatistics.RevenueSplitStatistics), "", "RevenueSplit", ConstStrings.Get("StatisticsGroup"));
            DemosInfo.Add(ConstStrings.Get("TopCustomersModule"), typeof(DevExpress.VideoRent.Win.ModulesStatistics.TopCustomersStatistics), "", "TopCustomers", ConstStrings.Get("StatisticsGroup"), DemoProducts.Charts);
            DemosInfo.Add(ConstStrings.Get("CustomerRevenueModule"), typeof(DevExpress.VideoRent.Win.ModulesStatistics.CustomerRevenueStatistics), "", "CustomerRevenue", ConstStrings.Get("StatisticsGroup"), DemoProducts.Charts);
            DemosInfo.Add(ConstStrings.Get("MediaPerformanceModule"), typeof(DevExpress.VideoRent.Win.ModulesStatistics.MediaPerformanceStatistics), "", "MediaPerformance", ConstStrings.Get("StatisticsGroup"), DemoProducts.Charts);
            DemosInfo.Add(ConstStrings.Get("RentScheduleModule"), typeof(DevExpress.VideoRent.Win.ModulesScheduler.RentalCalendar), "", "Scheduler", ConstStrings.Get("RentalGroup"), DemoProducts.Scheduler);
            DemosInfo.Add(DevExpress.VideoRent.Reports.Properties.Resources.TopFilmsReport, typeof(DevExpress.VideoRent.Win.ModulesReports.TopNFilms), "", "TopFilmList", ConstStrings.Get("ReportsGroup"), DemoProducts.Reports);
            DemosInfo.Add(DevExpress.VideoRent.Reports.Properties.Resources.ActiveCustomerReport, typeof(DevExpress.VideoRent.Win.ModulesReports.ActiveCustomersList), "", "ActiveCustomersList", ConstStrings.Get("ReportsGroup"), DemoProducts.Reports);
            DemosInfo.Add(DevExpress.VideoRent.Reports.Properties.Resources.FilmRentsReport, typeof(DevExpress.VideoRent.Win.ModulesReports.CustomerFilmRentsList), "", "CustomerFilmRentsList", ConstStrings.Get("ReportsGroup"), DemoProducts.Reports);
            DemosInfo.Add(DevExpress.VideoRent.Reports.Properties.Resources.GenresReport, typeof(DevExpress.VideoRent.Win.ModulesReports.TheMostProfitableGenresList), "", "TheMostProfitableGenresList", ConstStrings.Get("ReportsGroup"));
            DemosInfo.Add(DevExpress.VideoRent.Reports.Properties.Resources.CustomerCardsReport, typeof(DevExpress.VideoRent.Win.ModulesReports.CustomerInfoCard), "", "CustomerInfoCards", ConstStrings.Get("ReportsGroup"), DemoProducts.Reports);
            DemosInfo.Add(DevExpress.VideoRent.Reports.Properties.Resources.FilmCardsReport, typeof(DevExpress.VideoRent.Win.ModulesReports.FilmInfoCard), "", "FilmItemInfoCards", ConstStrings.Get("ReportsGroup"));
            
            //TODO DemosInfo.Add(ConstStrings.EmployeesModule, typeof(DevExpress.VideoRent.Win.Modules.Employee), "", "Employee", ConstStrings.AdminGroup);
        }
    }
}
