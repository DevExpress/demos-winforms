Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Linq
Imports DevExpress.Data.Utils
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraCharts.Demos

    Friend Class SaleItem

        Private ReadOnly Shared companies As String() = New String() {"DevAV North", "DevAV South", "DevAV West", "DevAV East", "DevAV Central"}

        Private Shared categorizedProductsField As System.Collections.Generic.Dictionary(Of String, System.Collections.Generic.List(Of String))

        Friend Shared ReadOnly Property CategorizedProducts As Dictionary(Of String, System.Collections.Generic.List(Of String))
            Get
                If DevExpress.XtraCharts.Demos.SaleItem.categorizedProductsField Is Nothing Then
                    DevExpress.XtraCharts.Demos.SaleItem.categorizedProductsField = New System.Collections.Generic.Dictionary(Of String, System.Collections.Generic.List(Of String))()
                    DevExpress.XtraCharts.Demos.SaleItem.categorizedProductsField("Cameras") = New System.Collections.Generic.List(Of String)() From {"Camera", "Camcorder", "Binoculars", "Flash", "Tripod"}
                    DevExpress.XtraCharts.Demos.SaleItem.categorizedProductsField("Cell Phones") = New System.Collections.Generic.List(Of String)() From {"Smartphone", "Mobile Phone", "Smart Watch", "Sim Card"}
                    DevExpress.XtraCharts.Demos.SaleItem.categorizedProductsField("Computers") = New System.Collections.Generic.List(Of String)() From {"Desktop", "Laptop", "Tablet", "Printer"}
                    DevExpress.XtraCharts.Demos.SaleItem.categorizedProductsField("TV, Audio") = New System.Collections.Generic.List(Of String)() From {"Television", "Home Audio", "Headphone", "DVD Player"}
                    DevExpress.XtraCharts.Demos.SaleItem.categorizedProductsField("Vehicle Electronics") = New System.Collections.Generic.List(Of String)() From {"GPS Unit", "Radar", "Car Alarm", "Car Accessories"}
                    DevExpress.XtraCharts.Demos.SaleItem.categorizedProductsField("Multipurpose Batteries") = New System.Collections.Generic.List(Of String)() From {"Battery", "Charger", "Converter", "Tester", "AC/DC Adapter"}
                End If

                Return DevExpress.XtraCharts.Demos.SaleItem.categorizedProductsField
            End Get
        End Property

        Friend Shared Function GetProductsByMonths() As List(Of DevExpress.XtraCharts.Demos.SaleItem)
            Dim items As System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.SaleItem) = New System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.SaleItem)()
            For Each company As String In DevExpress.XtraCharts.Demos.SaleItem.companies
                For Each product As String In DevExpress.XtraCharts.Demos.SaleItem.CategorizedProducts("Cameras")
                    Dim dateTime As System.DateTime = New System.DateTime(2017, 12, 01)
                    For i As Integer = 0 To 12 - 1
                        Dim income As Integer = DevExpress.DXperience.Demos.TutorialConstants.Random.[Next](20, 100)
                        Dim revenue As Integer = income + DevExpress.DXperience.Demos.TutorialConstants.Random.[Next](20, 50)
                        items.Add(New DevExpress.XtraCharts.Demos.SaleItem() With {.Company = company, .Product = product, .Month = dateTime.AddMonths(CInt((1))).ToString("MMMM", System.Globalization.CultureInfo.InvariantCulture), .Income = income, .Revenue = revenue})
                        dateTime = dateTime.AddMonths(1)
                    Next
                Next
            Next

            Return items
        End Function

        Friend Shared Function GetProductsByCompany(ByVal companyIndex As Integer) As List(Of DevExpress.XtraCharts.Demos.SaleItem)
            Dim rnd As DevExpress.Data.Utils.NonCryptographicRandom = New DevExpress.Data.Utils.NonCryptographicRandom(companyIndex)
            Dim items As System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.SaleItem) = New System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.SaleItem)()
            For Each category As String In DevExpress.XtraCharts.Demos.SaleItem.CategorizedProducts.Keys
                For Each product As String In DevExpress.XtraCharts.Demos.SaleItem.CategorizedProducts(category)
                    Dim income As Integer = rnd.[Next](20, 100)
                    Dim revenue As Integer = income + rnd.[Next](20, 50)
                    items.Add(New DevExpress.XtraCharts.Demos.SaleItem() With {.Company = DevExpress.XtraCharts.Demos.SaleItem.companies(companyIndex), .Product = product, .Income = income, .Revenue = revenue, .Category = category})
                Next
            Next

            Return items
        End Function

        Friend Shared Function GetProductsCategoriesByMonth() As List(Of DevExpress.XtraCharts.Demos.CategorySaleItem)
            Dim rnd As DevExpress.Data.Utils.NonCryptographicRandom = New DevExpress.Data.Utils.NonCryptographicRandom(DevExpress.DXperience.Demos.TutorialConstants.Now.Millisecond)
            Dim categoryItems As System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.CategorySaleItem) = New System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.CategorySaleItem)()
            Dim productIndex As Integer = 0
            For Each category As String In DevExpress.XtraCharts.Demos.SaleItem.CategorizedProducts.Keys
                Dim categoryItem As DevExpress.XtraCharts.Demos.CategorySaleItem = New DevExpress.XtraCharts.Demos.CategorySaleItem() With {.Category = category}
                For Each product As String In DevExpress.XtraCharts.Demos.SaleItem.CategorizedProducts(category)
                    Dim dateTime As System.DateTime = New System.DateTime(2017, 12, 01)
                    Dim generator As DevExpress.XtraCharts.Demos.DataGenerator = New DevExpress.XtraCharts.Demos.DataGenerator(System.Math.Min(System.Threading.Interlocked.Increment(productIndex), productIndex - 1), rnd.[Next](20, 30))
                    Dim incomes As System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.DataPoint) = generator.GenerateData(DevExpress.XtraCharts.Demos.SeriesDataType.ArgumentValue, 12)
                    For i As Integer = 0 To 12 - 1
                        categoryItem.SaleItems.Add(New DevExpress.XtraCharts.Demos.SaleItem() With {.Category = category, .Product = product, .OrderDate = dateTime.AddMonths(1), .Income = incomes(CInt((i))).Value})
                        dateTime = dateTime.AddMonths(1)
                    Next
                Next

                categoryItems.Add(categoryItem)
            Next

            Dim sortedCategory As System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.CategorySaleItem) = categoryItems.OrderBy(Function(c) c.TotalIncome).ToList()
            For i As Integer = 0 To sortedCategory.Count - 1
                sortedCategory(CInt((i))).OrderIndex = i
            Next

            Return sortedCategory
        End Function

        Friend Shared Function GetProductsIncome() As List(Of DevExpress.XtraCharts.Demos.SaleItem)
            Dim rnd As DevExpress.Data.Utils.NonCryptographicRandom = New DevExpress.Data.Utils.NonCryptographicRandom(DevExpress.DXperience.Demos.TutorialConstants.Now.Millisecond)
            Dim items As System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.SaleItem) = New System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.SaleItem)()
            For i As Integer = 0 To 50 - 1
                For Each product As String In DevExpress.XtraCharts.Demos.SaleItem.CategorizedProducts("Cameras")
                    items.Add(New DevExpress.XtraCharts.Demos.SaleItem() With {.Product = product, .Income = rnd.[Next](20, 100)})
                Next
            Next

            Return items
        End Function

        Friend Shared Function GetTotalIncome() As List(Of DevExpress.XtraCharts.Demos.SaleItem)
            Dim rnd As DevExpress.Data.Utils.NonCryptographicRandom = New DevExpress.Data.Utils.NonCryptographicRandom(DevExpress.DXperience.Demos.TutorialConstants.Now.Millisecond)
            Dim now As System.DateTime = DevExpress.DXperience.Demos.TutorialConstants.Now
            Dim endDate As System.DateTime = New System.DateTime(now.Year, now.Month, 1)
            Dim items As System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.SaleItem) = New System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.SaleItem)()
            For Each company As String In DevExpress.XtraCharts.Demos.SaleItem.companies
                Dim companyFactor As Double = rnd.NextDouble() * 0.6 + 1
                For Each category As String In DevExpress.XtraCharts.Demos.SaleItem.CategorizedProducts.Keys
                    Dim categoryFactor As Double = rnd.NextDouble() * 0.6 + 1
                    For Each product As String In DevExpress.XtraCharts.Demos.SaleItem.CategorizedProducts(category)
                        Dim maxIncome As Integer = rnd.[Next](60, 140)
                        For i As Integer = 0 To 1000 - 1
                            If i Mod 100 = 0 Then maxIncome = System.Math.Max(40, rnd.[Next](maxIncome - 20, maxIncome + 20))
                            Dim [date] As System.DateTime = endDate.AddDays(-i - 1)
                            Dim income As Double = rnd.[Next](20, maxIncome) * companyFactor * categoryFactor
                            items.Add(New DevExpress.XtraCharts.Demos.SaleItem() With {.Category = category, .Company = company, .Product = product, .OrderDate = [date], .Income = income})
                        Next
                    Next
                Next
            Next

            Return items
        End Function

        Public Property Product As String

        Public Property Company As String

        Public Property OrderDate As DateTime

        Public Property Month As String

        Public Property Income As Double

        Public Property Revenue As Double

        Public Property Category As String
    End Class

    Friend Class CategorySaleItem

        Private ReadOnly saleItemsField As System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.SaleItem) = New System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.SaleItem)()

        Private productIncomeField As System.Collections.Generic.Dictionary(Of String, Double)

        Public Property OrderIndex As Integer

        Public Property Category As String

        Public ReadOnly Property SaleItems As List(Of DevExpress.XtraCharts.Demos.SaleItem)
            Get
                Return Me.saleItemsField
            End Get
        End Property

        Public ReadOnly Property TotalIncome As Double
            Get
                Return Me.saleItemsField.Sum(Function(x) x.Income)
            End Get
        End Property

        Public ReadOnly Property ProductIncome As Dictionary(Of String, Double)
            Get
                If Me.productIncomeField Is Nothing Then
                    Me.productIncomeField = New System.Collections.Generic.Dictionary(Of String, Double)()
                    For Each item As DevExpress.XtraCharts.Demos.SaleItem In Me.SaleItems
                        If Me.productIncomeField.Keys.Contains(item.Product) Then
                            Me.productIncomeField(item.Product) += item.Income
                        Else
                            Me.productIncomeField(item.Product) = item.Income
                        End If
                    Next
                End If

                Return Me.productIncomeField
            End Get
        End Property
    End Class
End Namespace
