Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DXperience.Demos
Imports System.Runtime.CompilerServices

Namespace DevExpress.DevAV.ViewModels

    Public Module AnalysisPeriod

        Public Function CalculateAnalysisPeriod(ByVal maxDate As System.DateTime) As DatePeriod
            Dim versionYear As Integer = maxDate.Year
            Return New DevExpress.DevAV.ViewModels.AnalysisPeriod.DatePeriod With {.Start = New System.DateTime(versionYear - 3, maxDate.Month, 1), .[End] = New System.DateTime(versionYear, maxDate.Month, 1)}
        End Function

        Public Function CalculateReportPeriod(ByVal maxDate As System.DateTime) As DatePeriod
            Dim currentYear As Integer = System.DateTime.Now.Year
            Dim versionYear As Integer = maxDate.Year
            Dim reportEndYear As Integer = versionYear - (If(versionYear < currentYear, 0, 1))
            Return New DevExpress.DevAV.ViewModels.AnalysisPeriod.DatePeriod With {.Start = New System.DateTime(reportEndYear - 2, 1, 1), .[End] = New System.DateTime(reportEndYear, 12, 30)}
        End Function

        Public Function MonthOffset(ByVal startDateTime As System.DateTime, ByVal dateTime As System.DateTime) As Integer
            Return(dateTime.Year - startDateTime.Year) * 12 + dateTime.Month - startDateTime.Month
        End Function

        Public Class Item

            Public Property Total As Decimal

            Public Property Year As Integer

            Public Property Month As Integer

            Public ReadOnly Property [Date] As DateTime
                Get
                    Return New System.DateTime(Me.Year, Me.Month, 1)
                End Get
            End Property
        End Class

        Public Class DatePeriod

            Public Property Start As DateTime

            Public Property [End] As DateTime
        End Class
    End Module

    Public Module AnalysisPeriodHelper

        <Extension()>
        Public Function GetMaxOrdersDate(ByVal UnitOfWork As DevExpress.DevAV.DevAVDbDataModel.IDevAVDbUnitOfWork) As DateTime
            Dim orders = UnitOfWork.Orders
            Dim dateRange =(From o In orders Group o By __groupByKey1__ = 1 Into g = Group Select New With {.MaxDate = g.Max(Function(x) x.OrderDate)}).FirstOrDefault()
            Return dateRange.MaxDate
        End Function
    End Module

    Public Module ProductsAnalysis

#If NET
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
#Else
        <Extension()>
        Public Function GetFinancialReport(ByVal UnitOfWork As DevExpress.DevAV.DevAVDbDataModel.IDevAVDbUnitOfWork, ByVal startDate As System.DateTime, ByVal endDate As System.DateTime) As IEnumerable(Of DevExpress.DevAV.ViewModels.ProductsAnalysis.Item)
            Dim orders = UnitOfWork.Orders
            Dim orderItems = From oi In UnitOfWork.OrderItems Join o In orders On oi.OrderId Equals o.Id Where(o.OrderDate >= startDate AndAlso o.OrderDate < endDate) Select New With {.Product = oi.Product, .Total = oi.Total, .FY =((o.OrderDate.Year - startDate.Year) * 12 + (o.OrderDate.Month - startDate.Month)) \ 12}
            Return From oi In orderItems Group oi By __groupByKey2__ = New With {oi.Product, oi.FY} Into g = Group Select New DevExpress.DevAV.ViewModels.ProductsAnalysis.Item With {.ProductName = __groupByKey2__.Product.Name, .Year = startDate.Year + __groupByKey2__.FY, .Month = startDate.Month, .Total = If(System.Linq.Enumerable.[Select](g, Function(o) CType(CType(o.Total, Decimal?), System.[Decimal]?)).Sum(), 0)}
        End Function

        <Extension()>
        Public Function GetFinancialData(ByVal UnitOfWork As DevExpress.DevAV.DevAVDbDataModel.IDevAVDbUnitOfWork, ByVal startDate As System.DateTime, ByVal endDate As System.DateTime) As IEnumerable(Of DevExpress.DevAV.ViewModels.ProductsAnalysis.Item)
            Dim orders = UnitOfWork.Orders
            Dim orderItems = From oi In UnitOfWork.OrderItems Join o In orders On oi.OrderId Equals o.Id Where(o.OrderDate >= startDate AndAlso o.OrderDate < endDate) Select New With {.Product = oi.Product, .[Date] = o.OrderDate, .Total = oi.Total}
            Return From oi In orderItems Group oi By __groupByKey3__ = New With {oi.Product.Category, oi.[Date].Year, oi.[Date].Month} Into g = Group Select New DevExpress.DevAV.ViewModels.ProductsAnalysis.Item With {.ProductCategory = __groupByKey3__.Category, .Year = __groupByKey3__.Year, .Month = __groupByKey3__.Month, .Total = If(System.Linq.Enumerable.[Select](g, Function(o) CType(CType(o.Total, Decimal?), System.[Decimal]?)).Sum(), 0)}
        End Function

#End If
        Public Class Item
            Inherits DevExpress.DevAV.ViewModels.AnalysisPeriod.Item

            Public Property ProductName As String

            Public Property ProductCategory As ProductCategory
        End Class
    End Module

    Public Module CustomersAnalysis

#If NET
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
#Else
        <Extension()>
        Public Function GetSalesReport(ByVal UnitOfWork As DevExpress.DevAV.DevAVDbDataModel.IDevAVDbUnitOfWork, ByVal startDate As System.DateTime, ByVal endDate As System.DateTime) As IEnumerable(Of DevExpress.DevAV.ViewModels.CustomersAnalysis.Item)
            Dim orders = UnitOfWork.Orders
            Dim orderItems = From oi In UnitOfWork.OrderItems Join o In orders On oi.OrderId Equals o.Id Where(o.OrderDate >= startDate AndAlso o.OrderDate < endDate) Select New With {.Customer = o.Customer, .Total = oi.Total, .FY =((o.OrderDate.Year - startDate.Year) * 12 + (o.OrderDate.Month - startDate.Month)) \ 12}
            Return From oi In orderItems Group oi By __groupByKey4__ = New With {oi.Customer, oi.FY} Into g = Group Select New DevExpress.DevAV.ViewModels.CustomersAnalysis.Item With {.CustomerName = __groupByKey4__.Customer.Name, .Year = startDate.Year + __groupByKey4__.FY, .Month = startDate.Month, .Total = If(System.Linq.Enumerable.[Select](g, Function(o) CType(CType(o.Total, Decimal?), System.[Decimal]?)).Sum(), 0)}
        End Function

        <Extension()>
        Public Function GetSalesData(ByVal UnitOfWork As DevExpress.DevAV.DevAVDbDataModel.IDevAVDbUnitOfWork, ByVal startDate As System.DateTime, ByVal endDate As System.DateTime) As IEnumerable(Of DevExpress.DevAV.ViewModels.CustomersAnalysis.Item)
            Dim orders = UnitOfWork.Orders
            Dim orderItems = From oi In UnitOfWork.OrderItems Join o In orders On oi.OrderId Equals o.Id Where(o.OrderDate >= startDate AndAlso o.OrderDate < endDate) Select New With {.State = o.Store.Address.State, .[Date] = o.OrderDate, .Total = oi.Total}
            Return From oi In orderItems Group oi By __groupByKey5__ = New With {oi.State, oi.[Date].Year, oi.[Date].Month} Into g = Group Select New DevExpress.DevAV.ViewModels.CustomersAnalysis.Item With {.State = __groupByKey5__.State, .Year = __groupByKey5__.Year, .Month = __groupByKey5__.Month, .Total = If(System.Linq.Enumerable.[Select](g, Function(o) CType(CType(o.Total, Decimal?), System.[Decimal]?)).Sum(), 0)}
        End Function

#End If
        Public Class Item
            Inherits DevExpress.DevAV.ViewModels.AnalysisPeriod.Item

            Public Property CustomerName As String

            Public Property State As StateEnum
        End Class
    End Module
End Namespace
