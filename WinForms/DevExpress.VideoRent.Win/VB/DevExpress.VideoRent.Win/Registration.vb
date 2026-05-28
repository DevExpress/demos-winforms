Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.VideoRent.Reports

Namespace DevExpress.VideoRent.Win
	<Flags> _
	Public Enum DemoProducts
		None = 0
		Grid = 1
		Reports = 2
		Charts = 4
		Pivot = 8
		Scheduler = 16
	End Enum
	Public Class RegisterTutorials
		Public Shared Sub Register()
			DemosInfo.Add(ConstStrings.AboutGroup, GetType(DevExpress.VideoRent.Win.Modules.About), "", Nothing, ConstStrings.AboutGroup)
			DemosInfo.Add(ConstStrings.RentModule, GetType(DevExpress.VideoRent.Win.Modules.Rent), "", "Sale", ConstStrings.RentalGroup, DemoProducts.Grid)
			DemosInfo.Add(ConstStrings.CustomersModule, GetType(DevExpress.VideoRent.Win.Modules.Customers), "", "Person", ConstStrings.RentalGroup, DemoProducts.Grid)
			DemosInfo.Add(ConstStrings.MoviesModule, GetType(DevExpress.VideoRent.Win.Modules.Movies), "", "Movie", ConstStrings.CatalogGroup, DemoProducts.Grid)
			DemosInfo.Add(ConstStrings.ActorsModule, GetType(DevExpress.VideoRent.Win.Modules.Artists), "", "Actor", ConstStrings.CatalogGroup, DemoProducts.Grid)
			DemosInfo.Add(ConstStrings.CompaniesModule, GetType(DevExpress.VideoRent.Win.Modules.Companies), "", "Company", ConstStrings.CatalogGroup, DemoProducts.Grid)
			DemosInfo.Add(ConstStrings.MoviesKPIModule, GetType(DevExpress.VideoRent.Win.ModulesKPI.MoviesKPI), "", "MoviesKPI", ConstStrings.KPIGroup, DemoProducts.Pivot)
			DemosInfo.Add(ConstStrings.CustomersKPIModule, GetType(DevExpress.VideoRent.Win.ModulesKPI.CustomersKPI), "", "CustomersKPI", ConstStrings.KPIGroup, DemoProducts.Pivot)
			DemosInfo.Add(ConstStrings.CustomersDatesModule, GetType(DevExpress.VideoRent.Win.ModulesKPI.CustomersByDatesKPI), "", "CustomersByDate", ConstStrings.KPIGroup, DemoProducts.Pivot)
			DemosInfo.Add(ConstStrings.Revenue12MonthsModule, GetType(DevExpress.VideoRent.Win.ModulesStatistics.NetIncomeStatistics), "", "Revenue", ConstStrings.StatisticsGroup)
			DemosInfo.Add(ConstStrings.RevenueSplitModule, GetType(DevExpress.VideoRent.Win.ModulesStatistics.RevenueSplitStatistics), "", "RevenueSplit", ConstStrings.StatisticsGroup)
			DemosInfo.Add(ConstStrings.TopCustomersModule, GetType(DevExpress.VideoRent.Win.ModulesStatistics.TopCustomersStatistics), "", "TopCustomers", ConstStrings.StatisticsGroup, DemoProducts.Charts)
			DemosInfo.Add(ConstStrings.CustomerRevenueModule, GetType(DevExpress.VideoRent.Win.ModulesStatistics.CustomerRevenueStatistics), "", "CustomerRevenue", ConstStrings.StatisticsGroup, DemoProducts.Charts)
			DemosInfo.Add(ConstStrings.MediaPerformanceModule, GetType(DevExpress.VideoRent.Win.ModulesStatistics.MediaPerformanceStatistics), "", "MediaPerformance", ConstStrings.StatisticsGroup, DemoProducts.Charts)
			DemosInfo.Add(ConstStrings.RentScheduleModule, GetType(DevExpress.VideoRent.Win.ModulesScheduler.RentalCalendar), "", "Scheduler", ConstStrings.RentalGroup, DemoProducts.Scheduler)
			DemosInfo.Add(ReportConstStrings.TopFilmsReport, GetType(DevExpress.VideoRent.Win.ModulesReports.TopNFilms), "", "TopFilmList", ConstStrings.ReportsGroup, DemoProducts.Reports)
			DemosInfo.Add(ReportConstStrings.ActiveCustomersReport, GetType(DevExpress.VideoRent.Win.ModulesReports.ActiveCustomersList), "", "ActiveCustomersList", ConstStrings.ReportsGroup, DemoProducts.Reports)
			DemosInfo.Add(ReportConstStrings.FilmRentsReport, GetType(DevExpress.VideoRent.Win.ModulesReports.CustomerFilmRentsList), "", "CustomerFilmRentsList", ConstStrings.ReportsGroup, DemoProducts.Reports)
			DemosInfo.Add(ReportConstStrings.GenresReport, GetType(DevExpress.VideoRent.Win.ModulesReports.TheMostProfitableGenresList), "", "TheMostProfitableGenresList", ConstStrings.ReportsGroup)
			DemosInfo.Add(ReportConstStrings.CustomerCardsReport, GetType(DevExpress.VideoRent.Win.ModulesReports.CustomerInfoCard), "", "CustomerInfoCards", ConstStrings.ReportsGroup, DemoProducts.Reports)
			DemosInfo.Add(ReportConstStrings.FilmCardsReport, GetType(DevExpress.VideoRent.Win.ModulesReports.FilmInfoCard), "", "FilmItemInfoCards", ConstStrings.ReportsGroup)

			'TODO DemosInfo.Add(ConstStrings.EmployeesModule, typeof(DevExpress.VideoRent.Win.Modules.Employee), "", "Employee", ConstStrings.AdminGroup);
		End Sub
	End Class
End Namespace
