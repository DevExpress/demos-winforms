Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.IO
Imports System.Linq
Imports DevExpress.Data.Utils
Imports DevExpress.DXperience.Demos

Namespace DevExpress.ApplicationUI.Demos

    Public Class SalesPerformanceDataGenerator
        Inherits DevExpress.ApplicationUI.Demos.SalesDataGenerator

        Public Class TotalSalesItem

            Private uSoldYTDTarget As Integer

            Private uSoldYTD As Integer

            Private revQTDTarget As Decimal

            Private revQTD As Decimal

            Private revYTDTarget As Decimal

            Private revYTD As Decimal

            Private prod As String

            Private cat As String

            Private st As String

            Public Property State As String
                Get
                    Return Me.st
                End Get

                Set(ByVal value As String)
                    Me.st = value
                End Set
            End Property

            Public Property Category As String
                Get
                    Return Me.cat
                End Get

                Set(ByVal value As String)
                    Me.cat = value
                End Set
            End Property

            Public Property Product As String
                Get
                    Return Me.prod
                End Get

                Set(ByVal value As String)
                    Me.prod = value
                End Set
            End Property

            Public Property RevenueYTD As Decimal
                Get
                    Return Me.revYTD
                End Get

                Set(ByVal value As Decimal)
                    Me.revYTD = value
                End Set
            End Property

            Public Property RevenueYTDTarget As Decimal
                Get
                    Return Me.revYTDTarget
                End Get

                Set(ByVal value As Decimal)
                    Me.revYTDTarget = value
                End Set
            End Property

            Public Property RevenueQTD As Decimal
                Get
                    Return Me.revQTD
                End Get

                Set(ByVal value As Decimal)
                    Me.revQTD = value
                End Set
            End Property

            Public Property RevenueQTDTarget As Decimal
                Get
                    Return Me.revQTDTarget
                End Get

                Set(ByVal value As Decimal)
                    Me.revQTDTarget = value
                End Set
            End Property

            Public Property UnitsSoldYTD As Integer
                Get
                    Return Me.uSoldYTD
                End Get

                Set(ByVal value As Integer)
                    Me.uSoldYTD = value
                End Set
            End Property

            Public Property UnitsSoldYTDTarget As Integer
                Get
                    Return Me.uSoldYTDTarget
                End Get

                Set(ByVal value As Integer)
                    Me.uSoldYTDTarget = value
                End Set
            End Property
        End Class

        Public Class MonthlySalesItem

            Private uSoldTarget As Integer

            Private uSold As Integer

            Private revTarget As Decimal

            Private rev As Decimal

            Private curtDate As System.DateTime

            Private cat As String

            Private prod As String

            Private st As String

            Public Property State As String
                Get
                    Return Me.st
                End Get

                Set(ByVal value As String)
                    Me.st = value
                End Set
            End Property

            Public Property Product As String
                Get
                    Return Me.prod
                End Get

                Set(ByVal value As String)
                    Me.prod = value
                End Set
            End Property

            Public Property Category As String
                Get
                    Return Me.cat
                End Get

                Set(ByVal value As String)
                    Me.cat = value
                End Set
            End Property

            Public Property CurrentDate As DateTime
                Get
                    Return Me.curtDate
                End Get

                Set(ByVal value As DateTime)
                    Me.curtDate = value
                End Set
            End Property

            Public Property Revenue As Decimal
                Get
                    Return Me.rev
                End Get

                Set(ByVal value As Decimal)
                    Me.rev = value
                End Set
            End Property

            Public Property RevenueTarget As Decimal
                Get
                    Return Me.revTarget
                End Get

                Set(ByVal value As Decimal)
                    Me.revTarget = value
                End Set
            End Property

            Public Property UnitsSold As Integer
                Get
                    Return Me.uSold
                End Get

                Set(ByVal value As Integer)
                    Me.uSold = value
                End Set
            End Property

            Public Property UnitsSoldTarget As Integer
                Get
                    Return Me.uSoldTarget
                End Get

                Set(ByVal value As Integer)
                    Me.uSoldTarget = value
                End Set
            End Property
        End Class

        '
        Private ReadOnly monthlySalesCore As System.Collections.Generic.List(Of DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.MonthlySalesItem) = New System.Collections.Generic.List(Of DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.MonthlySalesItem)()

        Private ReadOnly totalSalesCore As System.Collections.Generic.List(Of DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.TotalSalesItem) = New System.Collections.Generic.List(Of DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.TotalSalesItem)()

        Public Event UpdateDataSource As System.EventHandler

        Private filterCore As String

        Public Property Filter As String
            Get
                Return Me.filterCore
            End Get

            Set(ByVal value As String)
                If Equals(Me.filterCore, value) Then Return
                Me.filterCore = value
                RaiseEvent UpdateDataSource(Me, System.EventArgs.Empty)
            End Set
        End Property

        Public ReadOnly Property MonthlySales As IEnumerable(Of DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.MonthlySalesItem)
            Get
                Dim categories = From p In Me.monthlySalesCore Where Equals(p.State, Me.Filter) Group p By __groupByKey1__ = p.Product Into g = Group Select New With {.Category = __groupByKey1__, .Item = g, .TotalRevenue = g.Sum(Function(p) p.Revenue)}
                categories.OrderByDescending(Function(d) d.TotalRevenue)
                Dim result As System.Collections.Generic.List(Of DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.MonthlySalesItem) = New System.Collections.Generic.List(Of DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.MonthlySalesItem)()
                Dim xc = categories.Take(5).[Select]((Function(s) s.Item)).ToArray()
                For Each item In xc
                    result.AddRange(item.ToArray())
                Next

                Return result
            End Get
        End Property

        Public ReadOnly Property TotalSales As IEnumerable(Of DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.TotalSalesItem)
            Get
                Return Me.totalSalesCore
            End Get
        End Property

        Public ReadOnly Property FilterTotalSales As IEnumerable(Of DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.TotalSalesItem)
            Get
                Return Me.totalSalesCore.Where(Function(d) Equals(d.State, Me.Filter))
            End Get
        End Property

        Public ReadOnly Property TotalSalesTop5 As IEnumerable(Of DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.TotalSalesItem)
            Get
                Dim categories = From p In Me.totalSalesCore Where Equals(p.State, Me.Filter) Group p By __groupByKey2__ = p.Product Into g = Group Select New With {.Category = __groupByKey2__, .Item = g, .TotalRevenue = g.Sum(Function(p) p.RevenueYTD)}
                categories.OrderByDescending(Function(d) d.TotalRevenue)
                Dim result As System.Collections.Generic.List(Of DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.TotalSalesItem) = New System.Collections.Generic.List(Of DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.TotalSalesItem)()
                Dim groupingData = categories.Take(5).[Select]((Function(s) s.Item)).ToArray()
                For Each item In groupingData
                    result.AddRange(item.ToArray())
                Next

                Return result
            End Get
        End Property

        Private Shared currentCore As DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator

        Public Shared ReadOnly Property IsCurrentDataGeneratorExist As Boolean
            Get
                Return DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.currentCore IsNot Nothing
            End Get
        End Property

        Public Shared ReadOnly Property Current As SalesPerformanceDataGenerator
            Get
                If DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.currentCore Is Nothing Then
                    DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.currentCore = New DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator(DevExpress.ApplicationUI.Demos.DataLoader.LoadSales())
                    DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.currentCore.Filter = "Montana"
                    Call DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.currentCore.Generate()
                End If

                Return DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.currentCore
            End Get
        End Property

        '
        Shared Sub New()
        End Sub

        Public Sub New(ByVal dataSet As System.Data.DataSet)
            MyBase.New(dataSet)
        End Sub

        Protected Overrides Sub Generate(ByVal context As DevExpress.ApplicationUI.Demos.SalesDataGenerator.Context)
            Dim tsItem As DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.TotalSalesItem = New DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.TotalSalesItem With {.State = context.State, .Category = context.CategoryName, .Product = context.ProductName}
            Dim y As Integer = DevExpress.DXperience.Demos.TutorialConstants.Today.Year - 1
            For month As Integer = 1 To 12
                Dim dt As System.DateTime = New System.DateTime(y, month, 1)
                context.UnitsSoldGenerator.[Next]()
                Dim uSold As Integer = context.UnitsSoldGenerator.UnitsSold
                Dim uSoldTarget As Integer = context.UnitsSoldGenerator.UnitsSoldTarget
                Dim rev As Decimal = uSold * context.ListPrice
                Dim revTarget As Decimal = uSoldTarget * context.ListPrice
                Me.monthlySalesCore.Add(New DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.MonthlySalesItem With {.State = context.State, .Product = context.ProductName, .Category = context.CategoryName, .CurrentDate = dt, .UnitsSold = uSold, .UnitsSoldTarget = uSoldTarget, .Revenue = rev, .RevenueTarget = revTarget})
                tsItem.RevenueYTD += rev
                tsItem.RevenueYTDTarget += revTarget
                tsItem.UnitsSoldYTD += uSold
                tsItem.UnitsSoldYTDTarget += uSoldTarget
                If month >= 10 AndAlso month <= 12 Then
                    tsItem.RevenueQTD += rev
                    tsItem.RevenueQTDTarget += revTarget
                End If
            Next

            Me.totalSalesCore.Add(tsItem)
        End Sub
    End Class

    Public Module DataHelper

        Public Function Random(ByVal _random As DevExpress.Data.Utils.NonCryptographicRandom, ByVal deviation As Double, ByVal positive As Boolean) As Double
            Dim rand As Integer = _random.[Next](If(positive, 0, -1000000), 1000000)
            Return CDbl(rand) / 1000000 * deviation
        End Function

        Public Function Random(ByVal _random As DevExpress.Data.Utils.NonCryptographicRandom, ByVal deviation As Double) As Double
            Return DevExpress.ApplicationUI.Demos.DataHelper.Random(_random, deviation, False)
        End Function
    End Module

    Public MustInherit Class SalesDataGenerator

        Public Class Context

            Private ReadOnly st As String

            Private ReadOnly prodName As String

            Private ReadOnly catName As String

            Private ReadOnly lPrice As Decimal

            Private ReadOnly uSoldGeneratorCore As DevExpress.ApplicationUI.Demos.UnitsSoldRandomGenerator

            '
            Public ReadOnly Property State As String
                Get
                    Return Me.st
                End Get
            End Property

            Public ReadOnly Property ProductName As String
                Get
                    Return Me.prodName
                End Get
            End Property

            Public ReadOnly Property CategoryName As String
                Get
                    Return Me.catName
                End Get
            End Property

            Public ReadOnly Property ListPrice As Decimal
                Get
                    Return Me.lPrice
                End Get
            End Property

            Public ReadOnly Property UnitsSoldGenerator As UnitsSoldRandomGenerator
                Get
                    Return Me.uSoldGeneratorCore
                End Get
            End Property

            Public Sub New(ByVal st As String, ByVal prodName As String, ByVal catName As String, ByVal lPrice As Decimal, ByVal uSoldGenerator As DevExpress.ApplicationUI.Demos.UnitsSoldRandomGenerator)
                Me.st = st
                Me.prodName = prodName
                Me.catName = catName
                Me.lPrice = lPrice
                Me.uSoldGeneratorCore = uSoldGenerator
            End Sub
        End Class

        '
        Protected Shared Function GetState(ByVal region As System.Data.DataRow) As String
            Return region.Field(Of String)("Region")
        End Function

        Protected Shared Function GetProductName(ByVal product As System.Data.DataRow) As String
            Return product.Field(Of String)("Name")
        End Function

        Protected Shared Function GetListPrice(ByVal product As System.Data.DataRow) As Decimal
            Return product.Field(Of Decimal)("ListPrice")
        End Function

        '
        Private ReadOnly categoriesTable As System.Data.DataTable

        Private ReadOnly productsTable As System.Data.DataTable

        Private ReadOnly regionsTable As System.Data.DataTable

        Private ReadOnly prodClassesCore As DevExpress.ApplicationUI.Demos.ProductClasses

        Private ReadOnly regClassesCore As DevExpress.ApplicationUI.Demos.RegionClasses

        Protected ReadOnly Property Regions As DataRowCollection
            Get
                Return Me.regionsTable.Rows
            End Get
        End Property

        Protected ReadOnly Property Products As DataRowCollection
            Get
                Return Me.productsTable.Rows
            End Get
        End Property

        Protected ReadOnly Property ProdClasses As ProductClasses
            Get
                Return Me.prodClassesCore
            End Get
        End Property

        Protected ReadOnly Property RegClasses As RegionClasses
            Get
                Return Me.regClassesCore
            End Get
        End Property

        Protected Sub New(ByVal ds As System.Data.DataSet)
            If ds.Tables.Count > 0 Then
                Me.categoriesTable = ds.Tables("Categories")
                Me.productsTable = ds.Tables("Products")
                Me.regionsTable = ds.Tables("Regions")
            Else
                Me.categoriesTable = New System.Data.DataTable()
                Me.productsTable = New System.Data.DataTable()
                Me.regionsTable = New System.Data.DataTable()
            End If

            Me.prodClassesCore = New DevExpress.ApplicationUI.Demos.ProductClasses(Me.productsTable.Rows)
            Me.regClassesCore = New DevExpress.ApplicationUI.Demos.RegionClasses(Me.regionsTable.Rows)
        End Sub

        Protected Function GetRegionWeigtht(ByVal region As System.Data.DataRow) As Double
            Dim regionId As Integer = region.Field(Of Integer)("RegionID")
            Return Me.regClassesCore(regionId)
        End Function

        Protected Function GetProductClass(ByVal product As System.Data.DataRow) As ProductClass
            Dim productId As Integer = product.Field(Of Integer)("ProductID")
            Return Me.prodClassesCore(productId)
        End Function

        Protected Function GetCategoryName(ByVal product As System.Data.DataRow) As String
            Dim categoryId As Integer = product.Field(Of Integer)("CategoryID")
            Dim categoryRow As System.Data.DataRow = Me.categoriesTable.AsEnumerable().FirstOrDefault(Function(row) row.Field(Of Integer)("CategoryID") = categoryId)
            Return categoryRow.Field(Of String)("CategoryName")
        End Function

        Protected Function CreateUnitsSoldGenerator(ByVal regionWeight As Double, ByVal productClass As DevExpress.ApplicationUI.Demos.ProductClass) As UnitsSoldRandomGenerator
            Return New DevExpress.ApplicationUI.Demos.UnitsSoldRandomGenerator(DevExpress.DXperience.Demos.TutorialConstants.Random, CInt(System.Math.Ceiling(productClass.SaleProbability * regionWeight)))
        End Function

        Protected MustOverride Sub Generate(ByVal context As DevExpress.ApplicationUI.Demos.SalesDataGenerator.Context)

        Protected Overridable Sub EndGenerate()
        End Sub

        Public Sub Generate()
            For Each region As System.Data.DataRow In Me.Regions
                Dim state As String = DevExpress.ApplicationUI.Demos.SalesDataGenerator.GetState(region)
                Dim regionWeight As Double = Me.GetRegionWeigtht(region)
                For Each product As System.Data.DataRow In Me.Products
                    Dim unitsSoldgenerator As DevExpress.ApplicationUI.Demos.UnitsSoldRandomGenerator = Me.CreateUnitsSoldGenerator(regionWeight, Me.GetProductClass(product))
                    Me.Generate(New DevExpress.ApplicationUI.Demos.SalesDataGenerator.Context(state, DevExpress.ApplicationUI.Demos.SalesDataGenerator.GetProductName(product), Me.GetCategoryName(product), DevExpress.ApplicationUI.Demos.SalesDataGenerator.GetListPrice(product), unitsSoldgenerator))
                Next
            Next

            Me.EndGenerate()
        End Sub
    End Class

    Public Class UnitsSoldRandomGenerator

        Const MinUnitsSold As Integer = 5

        Private ReadOnly rand As DevExpress.Data.Utils.NonCryptographicRandom

        Private ReadOnly startUnitsSold As Integer

        Private prevUnitsSold As Integer?

        Private prevPrevUnitsSold As Integer?

        Private unitsSoldCore As Integer

        Private unitsSoldTargetCore As Integer

        Private isFirst As Boolean = True

        Public ReadOnly Property UnitsSold As Integer
            Get
                Return Me.unitsSoldCore
            End Get
        End Property

        Public ReadOnly Property UnitsSoldTarget As Integer
            Get
                Return Me.unitsSoldTargetCore
            End Get
        End Property

        Public Sub New(ByVal rand As DevExpress.Data.Utils.NonCryptographicRandom, ByVal startUnitsSold As Integer)
            Me.rand = rand
            Me.startUnitsSold = System.Math.Max(startUnitsSold, DevExpress.ApplicationUI.Demos.UnitsSoldRandomGenerator.MinUnitsSold)
        End Sub

        Public Sub [Next]()
            If Me.isFirst Then
                Me.unitsSoldCore = Me.startUnitsSold
                Me.isFirst = False
            Else
                Me.unitsSoldCore = Me.unitsSoldCore + CInt(System.Math.Round(DevExpress.ApplicationUI.Demos.DataHelper.Random(Me.rand, Me.unitsSoldCore * 0.5)))
                Me.unitsSoldCore = System.Math.Max(Me.unitsSoldCore, DevExpress.ApplicationUI.Demos.UnitsSoldRandomGenerator.MinUnitsSold)
            End If

            Dim unitsSoldSum As Integer = Me.unitsSoldCore
            Dim count As Integer = 1
            If Me.prevUnitsSold.HasValue Then
                unitsSoldSum += Me.prevUnitsSold.Value
                count += 1
            End If

            If Me.prevPrevUnitsSold.HasValue Then
                unitsSoldSum += Me.prevPrevUnitsSold.Value
                count += 1
            End If

            Me.unitsSoldTargetCore = CInt(System.Math.Round(CDbl(unitsSoldSum) / count))
            Me.unitsSoldTargetCore = Me.unitsSoldTargetCore + CInt(System.Math.Round(DevExpress.ApplicationUI.Demos.DataHelper.Random(Me.rand, Me.unitsSoldTargetCore)))
            Me.prevPrevUnitsSold = Me.prevUnitsSold
            Me.prevUnitsSold = Me.unitsSoldCore
        End Sub
    End Class

    '
    Public Class ProductClass

        Private ReadOnly productIDs As System.Collections.Generic.List(Of Integer) = New System.Collections.Generic.List(Of Integer)()

        Private ReadOnly minPrice As Decimal?

        Private ReadOnly maxPrice As Decimal?

        Private ReadOnly saleProbabilityCore As Double

        Public ReadOnly Property SaleProbability As Double
            Get
                Return Me.saleProbabilityCore
            End Get
        End Property

        Public Sub New(ByVal minPrice As Decimal?, ByVal maxPrice As Decimal?, ByVal saleProbability As Double)
            Me.minPrice = minPrice
            Me.maxPrice = maxPrice
            Me.saleProbabilityCore = saleProbability
        End Sub

        Public Function AddProduct(ByVal productID As Integer, ByVal price As Decimal) As Boolean
            Dim satisfyMinPrice As Boolean = Not Me.minPrice.HasValue OrElse price >= Me.minPrice.Value
            Dim satisfyMaxPrice As Boolean = Not Me.maxPrice.HasValue OrElse price < Me.maxPrice.Value
            If satisfyMinPrice AndAlso satisfyMaxPrice Then
                Me.productIDs.Add(productID)
                Return True
            End If

            Return False
        End Function

        Public Function ContainsProduct(ByVal productID As Integer) As Boolean
            Return Me.productIDs.Contains(productID)
        End Function
    End Class

    Public Class ProductClasses
        Inherits System.Collections.Generic.List(Of DevExpress.ApplicationUI.Demos.ProductClass)

        Default Public Overloads ReadOnly Property Item(ByVal productID As Integer) As ProductClass
            Get
                For Each productClass As DevExpress.ApplicationUI.Demos.ProductClass In Me
                    If productClass.ContainsProduct(productID) Then Return productClass
                Next

                Throw New System.ArgumentException("procutID")
            End Get
        End Property

        Public Sub New(ByVal products As System.Collections.ICollection)
            Me.Add(New DevExpress.ApplicationUI.Demos.ProductClass(Nothing, 100D, 0.5))
            Me.Add(New DevExpress.ApplicationUI.Demos.ProductClass(100D, 500D, 0.4))
            Me.Add(New DevExpress.ApplicationUI.Demos.ProductClass(500D, 1500D, 0.3))
            Me.Add(New DevExpress.ApplicationUI.Demos.ProductClass(1500D, Nothing, 0.2))
            For Each product As System.Data.DataRow In products
                Dim productID As Integer = CInt(product("ProductID"))
                Dim listPrice As Decimal = CDec(product("ListPrice"))
                For Each productClass As DevExpress.ApplicationUI.Demos.ProductClass In Me
                    If productClass.AddProduct(productID, listPrice) Then Exit For
                Next
            Next
        End Sub
    End Class

    Public Class RegionClasses
        Inherits System.Collections.Generic.Dictionary(Of Integer, Double)

        Public Sub New(ByVal regions As System.Collections.ICollection)
            Dim numberEmployeesMin As Integer? = Nothing
            For Each region As System.Data.DataRow In regions
                Dim numberEmployees As Short = CShort(region("NumberEmployees"))
                numberEmployeesMin = If(numberEmployeesMin.HasValue, System.Math.Min(numberEmployeesMin.Value, numberEmployees), numberEmployees)
            Next

            For Each region As System.Data.DataRow In regions
                Dim numberEmployees As Short = CShort(region("NumberEmployees"))
                Me.Add(CInt(region("RegionID")), numberEmployees / CDbl(numberEmployeesMin.Value))
            Next
        End Sub
    End Class

    '
    Public Module DataLoader

        Private ReadOnly splitChars As Char() = New Char() {","c}

        '
        Public Sub AllowDataDirectoryAccess()
            Dim dataDirectory As String = System.IO.Path.GetDirectoryName(System.IO.Path.GetFullPath(DevExpress.ApplicationUI.Demos.DataLoader.GetRelativePath("DashboardSales.xml")))
            DevExpress.Security.Resources.AccessSettings.StaticResources.SetRules(DevExpress.Security.Resources.DirectoryAccessRule.Allow(dataDirectory))
        End Sub

        Public Function NormalizePath(ByVal path As String) As String
            Return System.IO.Path.GetFullPath(New System.Uri(CStr((path))).LocalPath)
        End Function

        Public Function GetRelativePath(ByVal name As String) As String
            name = "Data\" & name
            Dim path As String = System.Windows.Forms.Application.StartupPath
            Dim s As String = "\"
            For i As Integer = 0 To 10
                Dim candidatePath As String = DevExpress.ApplicationUI.Demos.DataLoader.NormalizePath(path & s & name)
                If System.IO.File.Exists(candidatePath) Then
                    Return candidatePath
                Else
                    s += "..\"
                End If
            Next

            path = DevExpress.Data.Utils.SafeEnvironment.CurrentDirectory
            s = "\"
            For i As Integer = 0 To 10
                Dim candidatePath As String = DevExpress.ApplicationUI.Demos.DataLoader.NormalizePath(path & s & name)
                If System.IO.File.Exists(candidatePath) Then
                    Return candidatePath
                Else
                    s += "..\"
                End If
            Next

            Return String.Empty
        End Function

        Private Function LoadData(ByVal fileName As String) As DataSet
            Dim absPath As String = System.IO.Path.GetFullPath(DevExpress.ApplicationUI.Demos.DataLoader.GetRelativePath(fileName))
            Dim ds As System.Data.DataSet = New System.Data.DataSet()
            If Not String.IsNullOrEmpty(absPath) AndAlso System.IO.File.Exists(absPath) Then ds.ReadXml(absPath, System.Data.XmlReadMode.ReadSchema)
            Return ds
        End Function

        Private Function LoadDataFromCSVFile(ByVal fileName As String) As DataTable
            Dim absPath As String = System.IO.Path.GetFullPath(DevExpress.ApplicationUI.Demos.DataLoader.GetRelativePath(fileName))
            Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
            If String.IsNullOrEmpty(absPath) OrElse Not System.IO.File.Exists(absPath) Then Return dataTable
            Dim lines As String() = System.IO.File.ReadAllLines(absPath)
            Dim fields As String() = lines(CInt((0))).Split(DevExpress.ApplicationUI.Demos.DataLoader.splitChars)
            For i As Integer = 0 To fields.Length - 1
                dataTable.Columns.Add(fields(i), GetType(String))
            Next

            Dim row As System.Data.DataRow
            For i As Integer = 1 To lines.Length - 1
                fields = lines(CInt((i))).Split(DevExpress.ApplicationUI.Demos.DataLoader.splitChars)
                row = dataTable.NewRow()
                For f As Integer = 0 To dataTable.Columns.Count - 1
                    row(f) = fields(f)
                Next

                dataTable.Rows.Add(row)
            Next

            Return dataTable
        End Function

        '
        Public Function LoadSales() As DataSet
            Return DevExpress.ApplicationUI.Demos.DataLoader.LoadData("DashboardSales.xml")
        End Function

        Public Function LoadEmployees() As DataSet
            Return DevExpress.ApplicationUI.Demos.DataLoader.LoadData("DashboardEmployeesAndDepartments.xml")
        End Function

        Public Function LoadCustomerSupport() As DataSet
            Return DevExpress.ApplicationUI.Demos.DataLoader.LoadData("DashboardCustomerSupport.xml")
        End Function

        Public Function LoadPerformanceReport() As DataTable
            Return DevExpress.ApplicationUI.Demos.DataLoader.LoadDataFromCSVFile("PerformanceReport.csv")
        End Function
    End Module
End Namespace
