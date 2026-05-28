Imports System.Collections.Generic
Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess.Sql.DataApi

Namespace XtraReportsDemos.CachedDocumentSourceReport

    Public Class Customer

        Private Shared ReadOnly currentCustomers As List(Of Customer) = New List(Of Customer)()

        Public Shared ReadOnly Property Customers As List(Of Customer)
            Get
                Return currentCustomers
            End Get
        End Property

        Shared Sub New()
            Try
                Dim ds As SqlDataSource = New SqlDataSource("NWindConnectionString")
                Dim query As SelectQuery = SelectQueryFluentBuilder.AddTable("Customers").SelectAllColumns().Build("Customers")
                ds.Queries.Add(query)
                ds.RebuildResultSchema()
                ds.Fill()
                Dim src As ITable = ds.Result("Customers")
                For Each row As IRow In src
                    Call currentCustomers.Add(New Customer() With {.CustomerID = row.GetValue(Of String)("CustomerID"), .Address = row.GetValue(Of String)("Address"), .CompanyName = row.GetValue(Of String)("CompanyName"), .ContactName = row.GetValue(Of String)("ContactName"), .ContactTitle = row.GetValue(Of String)("ContactTitle"), .Country = row.GetValue(Of String)("Country"), .City = row.GetValue(Of String)("City"), .Fax = row.GetValue(Of String)("Fax"), .Phone = row.GetValue(Of String)("Phone"), .PostalCode = row.GetValue(Of String)("PostalCode"), .Region = row.GetValue(Of String)("Region")})
                Next
            Catch
                Call currentCustomers.Add(New Customer() With {.Address = "Obere Str. 57", .City = "Berlin", .CompanyName = "Alfreds Futterkiste", .ContactName = "Maria Anders", .ContactTitle = "Sales Representative", .Country = "Germany", .CustomerID = "ALFKI", .Fax = "030-0076545", .Phone = "030-0074321", .PostalCode = "12209"})
            End Try
        End Sub

        Public Property CustomerID As String

        Public Property CompanyName As String

        Public Property ContactName As String

        Public Property ContactTitle As String

        Public Property Address As String

        Public Property City As String

        Public Property PostalCode As String

        Public Property Region As String

        Public Property Country As String

        Public Property Phone As String

        Public Property Fax As String
    End Class
End Namespace
