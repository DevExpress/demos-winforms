Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports DevExpress.Data.Utils
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos

    Friend Class TemperatureData

        Const PointsCount As Integer = 250

        Private ReadOnly maxTemperaturePointField As TemperaturePoint = New TemperaturePoint(TimeSpan.Zero, Double.MinValue)

        Private ReadOnly minTemperaturePointField As TemperaturePoint = New TemperaturePoint(TimeSpan.MaxValue, Double.MaxValue)

        Private ReadOnly dataField As List(Of TemperaturePoint) = New List(Of TemperaturePoint)(PointsCount)

        Friend ReadOnly Property MaxTemperaturePoint As TemperaturePoint
            Get
                Return maxTemperaturePointField
            End Get
        End Property

        Friend ReadOnly Property MinTemperaturePoint As TemperaturePoint
            Get
                Return minTemperaturePointField
            End Get
        End Property

        Friend ReadOnly Property OptimalTemperature As Double
            Get
                Return 53
            End Get
        End Property

        Friend ReadOnly Property Data As List(Of TemperaturePoint)
            Get
                Return dataField
            End Get
        End Property

        Friend Sub New()
            Dim random As NonCryptographicRandom = New NonCryptographicRandom(9)
            Dim preTemperature As Double = 50
            For i As Integer = 0 To PointsCount - 1
                Dim time As TimeSpan = TimeSpan.FromSeconds(i)
                Dim temperature As Double = preTemperature + (random.NextDouble() - 0.5) * 10
                If temperature > 90 Then temperature -= 20
                If temperature < 20 Then temperature += 10
                Dim temperaturePoint As TemperaturePoint = New TemperaturePoint(time, temperature)
                If temperature < minTemperaturePointField.Temperature Then minTemperaturePointField = temperaturePoint
                If temperature > maxTemperaturePointField.Temperature Then maxTemperaturePointField = temperaturePoint
                dataField.Add(temperaturePoint)
                preTemperature = temperature
            Next
        End Sub
    End Class

    Friend Module MovieData

        Public Function GetData() As List(Of BubbleDataItem)
            Return New List(Of BubbleDataItem)() From {New BubbleDataItem(New DateTime(2007, 1, 1), 300, 0.963, "Pirates of the Caribbean: At World's End"), New BubbleDataItem(New DateTime(2008, 1, 1), 185, 1.004, "The Dark Knight"), New BubbleDataItem(New DateTime(2009, 1, 1), 237, 2.788, "Avatar"), New BubbleDataItem(New DateTime(2010, 1, 1), 200, 1.067, "Toy Story 3"), New BubbleDataItem(New DateTime(2011, 1, 1), 250, 1.341, "Harry Potter and the Deathly Hallows Part 2"), New BubbleDataItem(New DateTime(2012, 1, 1), 220, 1.519, "Marvel's The Avengers"), New BubbleDataItem(New DateTime(2013, 1, 1), 150, 1.276, "Frozen"), New BubbleDataItem(New DateTime(2014, 1, 1), 210, 1.104, "Transformers: Age of Extinction"), New BubbleDataItem(New DateTime(2015, 1, 1), 245, 2.068, "Star Wars: The Force Awakens"), New BubbleDataItem(New DateTime(2016, 1, 1), 250, 1.153, "Captain America: Civil War")}
        End Function
    End Module

    Friend Class DevAV

        Friend Shared Function GetLastYear() As Integer
            Return TutorialConstants.Now.Year - 1
        End Function

        Friend Shared Function GetSales() As DataTable
            Dim prevYear As Integer = TutorialConstants.Now.Year - 1
            Dim table As DataTable = New DataTable()
            table.Columns.AddRange(New DataColumn() {New DataColumn("Year", GetType(Integer)), New DataColumn("Region", GetType(String)), New DataColumn("Sales", GetType(Decimal))})
            table.Rows.Add(prevYear - 2, "Asia", 4.2372R)
            table.Rows.Add(prevYear - 2, "Australia", 1.7871R)
            table.Rows.Add(prevYear - 2, "Europe", 3.0884R)
            table.Rows.Add(prevYear - 2, "North America", 3.4855R)
            table.Rows.Add(prevYear - 2, "South America", 1.6027R)
            table.Rows.Add(prevYear - 1, "Asia", 4.7685R)
            table.Rows.Add(prevYear - 1, "Australia", 1.9576R)
            table.Rows.Add(prevYear - 1, "Europe", 3.3579R)
            table.Rows.Add(prevYear - 1, "North America", 3.7477R)
            table.Rows.Add(prevYear - 1, "South America", 1.8237R)
            table.Rows.Add(prevYear, "Asia", 5.2890R)
            table.Rows.Add(prevYear, "Australia", 2.2727R)
            table.Rows.Add(prevYear, "Europe", 3.7257R)
            table.Rows.Add(prevYear, "North America", 4.1825R)
            table.Rows.Add(prevYear, "South America", 2.1172R)
            Return table
        End Function

        Friend Shared Function GetSalesMixByRegion() As DataTable
            Dim table As DataTable = New DataTable()
            table.Columns.AddRange(New DataColumn() {New DataColumn("ProductCategory", GetType(String)), New DataColumn("Region", GetType(String)), New DataColumn("Sales", GetType(Decimal))})
            table.Rows.Add("Video players", "Asia", 853R)
            table.Rows.Add("Video players", "Australia", 321R)
            table.Rows.Add("Video players", "Europe", 655R)
            table.Rows.Add("Video players", "North America", 1325R)
            table.Rows.Add("Video players", "South America", 653R)
            table.Rows.Add("Automation", "Asia", 172R)
            table.Rows.Add("Automation", "Australia", 255R)
            table.Rows.Add("Automation", "Europe", 981R)
            table.Rows.Add("Automation", "North America", 963R)
            table.Rows.Add("Automation", "South America", 123R)
            table.Rows.Add("Monitors", "Asia", 1011R)
            table.Rows.Add("Monitors", "Australia", 359R)
            table.Rows.Add("Monitors", "Europe", 721R)
            table.Rows.Add("Monitors", "North America", 565R)
            table.Rows.Add("Monitors", "South America", 532R)
            table.Rows.Add("Projectors", "Asia", 998R)
            table.Rows.Add("Projectors", "Australia", 222R)
            table.Rows.Add("Projectors", "Europe", 865R)
            table.Rows.Add("Projectors", "North America", 787R)
            table.Rows.Add("Projectors", "South America", 332R)
            table.Rows.Add("Televisions", "Asia", 1356R)
            table.Rows.Add("Televisions", "Australia", 232R)
            table.Rows.Add("Televisions", "Europe", 1323R)
            table.Rows.Add("Televisions", "North America", 1125R)
            table.Rows.Add("Televisions", "South America", 865R)
            Return table
        End Function

        Friend Shared Function GetBranchesSales() As DataTable
            Dim lastYear As Integer = TutorialConstants.Now.Year - 1
            Dim table As DataTable = New DataTable()
            table.Columns.AddRange(New DataColumn() {New DataColumn("Year", GetType(Date)), New DataColumn("Company", GetType(String)), New DataColumn("Sales", GetType(Decimal)), New DataColumn("Charges", GetType(Decimal)), New DataColumn("Penalties", GetType(Decimal))})
            table.Rows.Add(New DateTime(lastYear - 10, 12, 31), "DevAV North", 1.010, 0.430, 0)
            table.Rows.Add(New DateTime(lastYear - 10, 12, 31), "DevAV Central", 3.032, 0.412, 0)
            table.Rows.Add(New DateTime(lastYear - 10, 12, 31), "DevAV South", 1.31, 0.312, 0)
            table.Rows.Add(New DateTime(lastYear - 9, 12, 31), "DevAV North", 1.512, 0.351, 0.0012)
            table.Rows.Add(New DateTime(lastYear - 9, 12, 31), "DevAV Central", 3.050, 0.411, 0)
            table.Rows.Add(New DateTime(lastYear - 9, 12, 31), "DevAV South", 1.34, 0.333, 0)
            table.Rows.Add(New DateTime(lastYear - 8, 12, 31), "DevAV North", 1.723, 0.431, 0.0027)
            table.Rows.Add(New DateTime(lastYear - 8, 12, 31), "DevAV West", 0.005, 0.215, 0.00021)
            table.Rows.Add(New DateTime(lastYear - 8, 12, 31), "DevAV Central", 3.054, 0.315, 0.001)
            table.Rows.Add(New DateTime(lastYear - 8, 12, 31), "DevAV South", 1.30, 0.410, 0)
            table.Rows.Add(New DateTime(lastYear - 7, 12, 31), "DevAV West", 0.31, 0.412, 0)
            table.Rows.Add(New DateTime(lastYear - 7, 12, 31), "DevAV North", 2.001, 0.321, 0)
            table.Rows.Add(New DateTime(lastYear - 7, 12, 31), "DevAV Central", 2.975, 0.327, 0)
            table.Rows.Add(New DateTime(lastYear - 7, 12, 31), "DevAV South", 1.283, 0.412, 0)
            table.Rows.Add(New DateTime(lastYear - 6, 12, 31), "DevAV West", 0.41, 0.323, 0)
            table.Rows.Add(New DateTime(lastYear - 6, 12, 31), "DevAV North", 2.612, 0.411, 0)
            table.Rows.Add(New DateTime(lastYear - 6, 12, 31), "DevAV Central", 2.066, 0.442, 0)
            table.Rows.Add(New DateTime(lastYear - 6, 12, 31), "DevAV South", 0.88, 0.398, 0)
            table.Rows.Add(New DateTime(lastYear - 5, 12, 31), "DevAV West", 0.95, 0398, 0)
            table.Rows.Add(New DateTime(lastYear - 5, 12, 31), "DevAV North", 2.666, 0.389, 0.012)
            table.Rows.Add(New DateTime(lastYear - 5, 12, 31), "DevAV Central", 2.078, 0.421, 0.124)
            table.Rows.Add(New DateTime(lastYear - 5, 12, 31), "DevAV South", 1.09, 0.401, 0)
            table.Rows.Add(New DateTime(lastYear - 4, 12, 31), "DevAV West", 1.53, 0.435, 0)
            table.Rows.Add(New DateTime(lastYear - 4, 12, 31), "DevAV North", 3.665, 0.444, 0)
            table.Rows.Add(New DateTime(lastYear - 4, 12, 31), "DevAV Central", 3.888, 0.381, 0)
            table.Rows.Add(New DateTime(lastYear - 4, 12, 31), "DevAV South", 1.01, 0.412, 0)
            table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "DevAV East", 0.003, 0.332, 0)
            table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "DevAV West", 1.75, 0.412, 0)
            table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "DevAV North", 3.555, 0.229, 0.0012)
            table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "DevAV Central", 3.008, 0.431, 0)
            table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "DevAV South", 1.11, 0.223, 0.0012)
            table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "DevAV East", 0.32, 0.450, 0)
            table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "DevAV West", 1.31, 0.413, 0)
            table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "DevAV North", 3.485, 0.426, 0)
            table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "DevAV Central", 3.088, 0.385, 0)
            table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "DevAV South", 1.12, 0.338, 0)
            table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "DevAV East", 0.51, 0.325, 0)
            table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "DevAV West", 1.31, 0.421, 0)
            table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "DevAV North", 3.747, 0.324, 0)
            table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "DevAV Central", 3.357, 0.441, 0)
            table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "DevAV South", 1.12, 0.524, 0)
            table.Rows.Add(New DateTime(lastYear, 12, 31), "DevAV East", 1.71, 0.998, 0)
            table.Rows.Add(New DateTime(lastYear, 12, 31), "DevAV West", 1.22, 0.324, 0)
            table.Rows.Add(New DateTime(lastYear, 12, 31), "DevAV North", 4.182, 0.325, 0)
            table.Rows.Add(New DateTime(lastYear, 12, 31), "DevAV Central", 3.725, 0.341, 0)
            table.Rows.Add(New DateTime(lastYear, 12, 31), "DevAV South", 1.111, 0.439, 0)
            Return table
        End Function

        Friend Shared Function GetSalesByLast10Years() As DataTable
            Dim lastYear As Integer = TutorialConstants.Now.Year - 1
            Dim table As DataTable = New DataTable()
            table.Columns.AddRange(New DataColumn() {New DataColumn("Year", GetType(Date)), New DataColumn("Region", GetType(String)), New DataColumn("Sales", GetType(Decimal))})
            table.Rows.Add(New DateTime(lastYear - 10, 12, 31), "North America", 3.010D)
            table.Rows.Add(New DateTime(lastYear - 10, 12, 31), "Europe", 3.032D)
            table.Rows.Add(New DateTime(lastYear - 10, 12, 31), "Australia", 1.31D)
            table.Rows.Add(New DateTime(lastYear - 9, 12, 31), "North America", 3.212D)
            table.Rows.Add(New DateTime(lastYear - 9, 12, 31), "Europe", 3.050D)
            table.Rows.Add(New DateTime(lastYear - 9, 12, 31), "Australia", 1.64D)
            table.Rows.Add(New DateTime(lastYear - 8, 12, 31), "North America", 3.223D)
            table.Rows.Add(New DateTime(lastYear - 8, 12, 31), "Europe", 3.054D)
            table.Rows.Add(New DateTime(lastYear - 8, 12, 31), "Australia", 1.70D)
            table.Rows.Add(New DateTime(lastYear - 7, 12, 31), "North America", 3.001D)
            table.Rows.Add(New DateTime(lastYear - 7, 12, 31), "Europe", 2.775D)
            table.Rows.Add(New DateTime(lastYear - 7, 12, 31), "Australia", 1.083D)
            table.Rows.Add(New DateTime(lastYear - 6, 12, 31), "North America", 2.612D)
            table.Rows.Add(New DateTime(lastYear - 6, 12, 31), "Europe", 2.066D)
            table.Rows.Add(New DateTime(lastYear - 6, 12, 31), "Australia", 0.88D)
            table.Rows.Add(New DateTime(lastYear - 5, 12, 31), "North America", 2.666D)
            table.Rows.Add(New DateTime(lastYear - 5, 12, 31), "Europe", 2.078D)
            table.Rows.Add(New DateTime(lastYear - 5, 12, 31), "Australia", 1.09D)
            table.Rows.Add(New DateTime(lastYear - 4, 12, 31), "North America", 3.665D)
            table.Rows.Add(New DateTime(lastYear - 4, 12, 31), "Europe", 3.888D)
            table.Rows.Add(New DateTime(lastYear - 4, 12, 31), "Australia", 2.01D)
            table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "North America", 3.555D)
            table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "Europe", 3.008D)
            table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "Australia", 1.85D)
            table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "North America", 3.485D)
            table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "Europe", 3.088D)
            table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "Australia", 1.78D)
            table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "North America", 3.747D)
            table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "Europe", 3.357D)
            table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "Australia", 1.957D)
            table.Rows.Add(New DateTime(lastYear, 12, 31), "North America", 4.182D)
            table.Rows.Add(New DateTime(lastYear, 12, 31), "Europe", 3.725D)
            table.Rows.Add(New DateTime(lastYear, 12, 31), "Australia", 2.272D)
            Return table
        End Function

        Friend Shared Function GetOutsideVendorCosts() As DataTable
            Dim lastYear As Integer = TutorialConstants.Now.Year - 1
            Dim table As DataTable = New DataTable()
            table.Columns.AddRange(New DataColumn() {New DataColumn("Year", GetType(Date)), New DataColumn("Company", GetType(String)), New DataColumn("Costs", GetType(Decimal))})
            table.Rows.Add(New DateTime(lastYear - 6, 1, 1), "DevAV North", 362.5D)
            table.Rows.Add(New DateTime(lastYear - 5, 1, 1), "DevAV North", 348.4D)
            table.Rows.Add(New DateTime(lastYear - 4, 1, 1), "DevAV North", 279.0D)
            table.Rows.Add(New DateTime(lastYear - 3, 1, 1), "DevAV North", 230.9D)
            table.Rows.Add(New DateTime(lastYear - 2, 1, 1), "DevAV North", 203.5D)
            table.Rows.Add(New DateTime(lastYear - 1, 1, 1), "DevAV North", 197.1D)
            table.Rows.Add(New DateTime(lastYear - 6, 1, 1), "DevAV South", 277.0D)
            table.Rows.Add(New DateTime(lastYear - 5, 1, 1), "DevAV South", 328.5D)
            table.Rows.Add(New DateTime(lastYear - 4, 1, 1), "DevAV South", 297.0D)
            table.Rows.Add(New DateTime(lastYear - 3, 1, 1), "DevAV South", 255.3D)
            table.Rows.Add(New DateTime(lastYear - 2, 1, 1), "DevAV South", 173.5D)
            table.Rows.Add(New DateTime(lastYear - 1, 1, 1), "DevAV South", 131.8D)
            Return table
        End Function

        Friend Shared Function GetBranchesSalesList() As List(Of DevAVDataItem)
            Dim lastYear As Integer = GetLastYear()
            Dim list As List(Of DevAVDataItem) = New List(Of DevAVDataItem)(46)
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 10, 12, 31), "DevAV North", 1.010D, 0.430D, 0.0112D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 10, 12, 31), "DevAV Central", 3.032D, 0.412D, 0.0012D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 10, 12, 31), "DevAV South", 1.31D, 0.312D, 0.301D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 9, 12, 31), "DevAV North", 1.512D, 0.351D, 0.0012D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 9, 12, 31), "DevAV Central", 3.050D, 0.411D, 0.286D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 9, 12, 31), "DevAV South", 1.34D, 0.333D, 0.11D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 8, 12, 31), "DevAV North", 1.723D, 0.431D, 0.27D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 8, 12, 31), "DevAV West", 0.005D, 0.215D, 0.0021D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 8, 12, 31), "DevAV Central", 3.054D, 0.315D, 0.101D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 8, 12, 31), "DevAV South", 1.30D, 0.410D, 0.075D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 7, 12, 31), "DevAV West", 0.31D, 0.412D, 0.03D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 7, 12, 31), "DevAV North", 2.001D, 0.321D, 0D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 7, 12, 31), "DevAV Central", 2.975D, 0.327D, 0.0045D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 7, 12, 31), "DevAV South", 1.283D, 0.412D, 0.205D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 6, 12, 31), "DevAV West", 0.41D, 0.323D, 0.001D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 6, 12, 31), "DevAV North", 2.612D, 0.411D, 0D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 6, 12, 31), "DevAV Central", 2.066D, 0.442D, 0.34D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 6, 12, 31), "DevAV South", 0.88D, 0.398D, 0.206D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 5, 12, 31), "DevAV West", 0.95D, 0.398D, 0D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 5, 12, 31), "DevAV North", 2.666D, 0.389D, 0.012D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 5, 12, 31), "DevAV Central", 2.078D, 0.421D, 0.124D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 5, 12, 31), "DevAV South", 1.09D, 0.401D, 0D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 4, 12, 31), "DevAV West", 1.53D, 0.435D, 0D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 4, 12, 31), "DevAV North", 3.665D, 0.444D, 0D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 4, 12, 31), "DevAV Central", 3.888D, 0.381D, 0D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 4, 12, 31), "DevAV South", 1.01D, 0.412D, 0D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 3, 12, 31), "DevAV East", 0.003D, 0.332D, 0D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 3, 12, 31), "DevAV West", 1.75D, 0.412D, 0D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 3, 12, 31), "DevAV North", 3.555D, 0.229D, 0.0012D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 3, 12, 31), "DevAV Central", 3.008D, 0.431D, 0D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 3, 12, 31), "DevAV South", 1.11D, 0.223D, 0.0012D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 2, 12, 31), "DevAV East", 0.32D, 0.450D, 0.25D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 2, 12, 31), "DevAV West", 1.31D, 0.413D, 0.01D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 2, 12, 31), "DevAV North", 3.485D, 0.426D, 0.056D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 2, 12, 31), "DevAV Central", 3.088D, 0.385D, 0.113D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 2, 12, 31), "DevAV South", 1.12D, 0.338D, 0.36D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 1, 12, 31), "DevAV East", 0.51D, 0.325D, 0.055D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 1, 12, 31), "DevAV West", 1.31D, 0.421D, 0.3205D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 1, 12, 31), "DevAV North", 3.747D, 0.324D, 0.148D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 1, 12, 31), "DevAV Central", 3.357D, 0.441D, 0.086D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear - 1, 12, 31), "DevAV South", 1.12D, 0.524D, 0.201D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear, 12, 31), "DevAV East", 1.71D, 0.298D, 0.105D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear, 12, 31), "DevAV West", 1.22D, 0.324D, 0.0356D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear, 12, 31), "DevAV North", 4.182D, 0.325D, 0.217D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear, 12, 31), "DevAV Central", 3.725D, 0.341D, 0.118D))
            list.Add(CreateByDateCompanySales(New DateTime(lastYear, 12, 31), "DevAV South", 1.111D, 0.439D, 0.0397D))
            Return list
        End Function

        Private Shared Function CreateByDateCompanySales(ByVal [date] As Date, ByVal company As String, ByVal sales As Decimal, ByVal charges As Decimal, ByVal penalties As Decimal) As DevAVDataItem
            Dim item As DevAVDataItem = New DevAVDataItem()
            item.Company = company
            item.SaleDate = [date]
            item.Sales = sales
            item.Year = [date].Year
            item.Charges = charges
            item.Penalties = penalties
            Return item
        End Function

        Private Shared Function GetCompainyNames() As String()
            Return New String() {"DevAV East", "DevAV West", "DevAV North", "DevAV Central", "DevAV South"}
        End Function

        Friend Shared Sub InitializeCompanyImages(ByVal images As ImageCollection, ByVal getColor As Func(Of String, Color))
            Dim companyNames As String() = GetCompainyNames()
            For i As Integer = 0 To companyNames.Length - 1
                images.AddImage(GetCompanyImage(getColor(companyNames(i)), images.ImageSize), companyNames(i))
            Next
        End Sub

        Friend Shared Sub UpdateCompanyImages(ByVal images As ImageCollection, ByVal getColor As Func(Of String, Color))
            Dim companyNames As String() = GetCompainyNames()
            For i As Integer = 0 To companyNames.Length - 1
                images.Images(companyNames(i)) = GetCompanyImage(getColor(companyNames(i)), images.ImageSize)
            Next
        End Sub

        Private Shared Function GetCompanyImage(ByVal color As Color, ByVal imageSize As Size) As Image
            Dim img As Bitmap = New Bitmap(imageSize.Width, imageSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            Using g As Graphics = Graphics.FromImage(img)
                g.Clear(color)
            End Using

            Return img
        End Function
    End Class

    Friend Class SourceOfEnergy

        Friend Shared Function GetEuropeBrentPrices() As DataTable
            Dim table As DataTable = New DataTable("Europe Brent")
            table.Columns.AddRange(New DataColumn() {New DataColumn("Date", GetType(Date)), New DataColumn("Min", GetType(Single)), New DataColumn("Max", GetType(Single))})
            table.Rows.Add(New DateTime(2015, 01, 1), 45.13, 55.38)
            table.Rows.Add(New DateTime(2015, 02, 1), 51.74, 61.89)
            table.Rows.Add(New DateTime(2015, 03, 1), 52.00, 61.18)
            table.Rows.Add(New DateTime(2015, 04, 1), 55.73, 63.97)
            table.Rows.Add(New DateTime(2015, 05, 1), 60.12, 66.33)
            table.Rows.Add(New DateTime(2015, 06, 1), 59.03, 64.68)
            table.Rows.Add(New DateTime(2015, 07, 1), 53.29, 61.73)
            table.Rows.Add(New DateTime(2015, 08, 1), 41.59, 49.49)
            table.Rows.Add(New DateTime(2015, 09, 1), 45.87, 50.41)
            table.Rows.Add(New DateTime(2015, 10, 1), 45.54, 52.13)
            table.Rows.Add(New DateTime(2015, 11, 1), 40.28, 48.00)
            table.Rows.Add(New DateTime(2015, 12, 1), 35.26, 42.97)
            Return table
        End Function

        Friend Shared Function GetOkWtiPrices() As DataTable
            Dim table As DataTable = New DataTable("OK WTI")
            table.Columns.AddRange(New DataColumn() {New DataColumn("Date", GetType(Date)), New DataColumn("Min", GetType(Single)), New DataColumn("Max", GetType(Single))})
            table.Rows.Add(New DateTime(2015, 01, 1), 44.08, 52.72)
            table.Rows.Add(New DateTime(2015, 02, 1), 47.65, 49.84)
            table.Rows.Add(New DateTime(2015, 03, 1), 43.39, 51.53)
            table.Rows.Add(New DateTime(2015, 04, 1), 49.13, 59.62)
            table.Rows.Add(New DateTime(2015, 05, 1), 57.29, 60.93)
            table.Rows.Add(New DateTime(2015, 06, 1), 58.00, 61.36)
            table.Rows.Add(New DateTime(2015, 07, 1), 47.11, 56.94)
            table.Rows.Add(New DateTime(2015, 08, 1), 38.22, 49.20)
            table.Rows.Add(New DateTime(2015, 09, 1), 44.07, 47.12)
            table.Rows.Add(New DateTime(2015, 10, 1), 43.19, 49.67)
            table.Rows.Add(New DateTime(2015, 11, 1), 39.27, 47.88)
            table.Rows.Add(New DateTime(2015, 12, 1), 34.55, 41.08)
            Return table
        End Function

        Friend Shared Function GetGasolinePrices() As DataTable
            Dim table As DataTable = New DataTable("Gasoline")
            table.Columns.AddRange(New DataColumn() {New DataColumn("Date", GetType(Date)), New DataColumn("Price", GetType(Single))})
            table.Rows.Add(New DateTime(2015, 01, 1), 2.208)
            table.Rows.Add(New DateTime(2015, 02, 1), 2.301)
            table.Rows.Add(New DateTime(2015, 03, 1), 2.546)
            table.Rows.Add(New DateTime(2015, 04, 1), 2.555)
            table.Rows.Add(New DateTime(2015, 05, 1), 2.802)
            table.Rows.Add(New DateTime(2015, 06, 1), 2.885)
            table.Rows.Add(New DateTime(2015, 07, 1), 2.880)
            table.Rows.Add(New DateTime(2015, 08, 1), 2.726)
            table.Rows.Add(New DateTime(2015, 09, 1), 2.462)
            table.Rows.Add(New DateTime(2015, 10, 1), 2.387)
            table.Rows.Add(New DateTime(2015, 11, 1), 2.260)
            table.Rows.Add(New DateTime(2015, 12, 1), 2.144)
            Return table
        End Function

        Friend Shared Function GetFuelPrices() As DataTable
            Dim table As DataTable = New DataTable()
            table.Columns.AddRange(New DataColumn() {New DataColumn("Date", GetType(Date)), New DataColumn("Price", GetType(Decimal))})
            table.Rows.Add(New DateTime(2016, 1, 1, 0, 0, 0), 2.143D)
            table.Rows.Add(New DateTime(2016, 2, 1, 0, 0, 0), 1.998D)
            table.Rows.Add(New DateTime(2016, 3, 1, 0, 0, 0), 2.090D)
            table.Rows.Add(New DateTime(2016, 4, 1, 0, 0, 0), 2.152D)
            table.Rows.Add(New DateTime(2016, 5, 1, 0, 0, 0), 2.315D)
            table.Rows.Add(New DateTime(2016, 6, 1, 0, 0, 0), 2.423D)
            table.Rows.Add(New DateTime(2016, 7, 1, 0, 0, 0), 2.405D)
            table.Rows.Add(New DateTime(2016, 8, 1, 0, 0, 0), 2.351D)
            table.Rows.Add(New DateTime(2016, 9, 1, 0, 0, 0), 2.394D)
            table.Rows.Add(New DateTime(2016, 10, 1, 0, 0, 0), 2.454D)
            table.Rows.Add(New DateTime(2016, 11, 1, 0, 0, 0), 2.439D)
            table.Rows.Add(New DateTime(2016, 12, 1, 0, 0, 0), 2.510D)
            Return table
        End Function

        Friend Shared Function GetCoalProduction() As DataTable
            Dim table As DataTable = New DataTable()
            table.Columns.AddRange(New DataColumn() {New DataColumn("Date", GetType(Date)), New DataColumn("South Africa", GetType(Decimal)), New DataColumn("Poland", GetType(Decimal))})
            table.Rows.Add(New DateTime(2015, 12, 31, 0, 0, 0), 252.099, 135.523)
            table.Rows.Add(New DateTime(2014, 12, 31, 0, 0, 0), 261.523, 137.148)
            table.Rows.Add(New DateTime(2013, 12, 31, 0, 0, 0), 256.562, 142.906)
            table.Rows.Add(New DateTime(2012, 12, 31, 0, 0, 0), 258.575, 144.093)
            table.Rows.Add(New DateTime(2011, 12, 31, 0, 0, 0), 252.756, 139.289)
            table.Rows.Add(New DateTime(2010, 12, 31, 0, 0, 0), 254.521, 133.238)
            table.Rows.Add(New DateTime(2009, 12, 31, 0, 0, 0), 247.820, 135.172)
            table.Rows.Add(New DateTime(2008, 12, 31, 0, 0, 0), 252.213, 144.013)
            table.Rows.Add(New DateTime(2007, 12, 31, 0, 0, 0), 247.666, 145.850)
            table.Rows.Add(New DateTime(2006, 12, 31, 0, 0, 0), 244.774, 156.065)
            table.Rows.Add(New DateTime(2005, 12, 31, 0, 0, 0), 244.985, 159.540)
            table.Rows.Add(New DateTime(2004, 12, 31, 0, 0, 0), 242.821, 161.284)
            table.Rows.Add(New DateTime(2003, 12, 31, 0, 0, 0), 238.751, 163.790)
            table.Rows.Add(New DateTime(2002, 12, 31, 0, 0, 0), 220.212, 161.920)
            table.Rows.Add(New DateTime(2001, 12, 31, 0, 0, 0), 223.560, 163.540)
            table.Rows.Add(New DateTime(2000, 12, 31, 0, 0, 0), 224.199, 162.820)
            table.Rows.Add(New DateTime(1999, 12, 31, 0, 0, 0), 223.514, 172.730)
            table.Rows.Add(New DateTime(1998, 12, 31, 0, 0, 0), 222.976, 178.550)
            table.Rows.Add(New DateTime(1997, 12, 31, 0, 0, 0), 220.072, 200.930)
            table.Rows.Add(New DateTime(1996, 12, 31, 0, 0, 0), 206.362, 201.720)
            table.Rows.Add(New DateTime(1995, 12, 31, 0, 0, 0), 206.210, 200.720)
            table.Rows.Add(New DateTime(1994, 12, 31, 0, 0, 0), 195.805, 200.700)
            table.Rows.Add(New DateTime(1993, 12, 31, 0, 0, 0), 188.214, 198.580)
            table.Rows.Add(New DateTime(1992, 12, 31, 0, 0, 0), 184.045, 198.380)
            table.Rows.Add(New DateTime(1991, 12, 31, 0, 0, 0), 178.390, 209.790)
            table.Rows.Add(New DateTime(1990, 12, 31, 0, 0, 0), 174.780, 215.320)
            Return table
        End Function
    End Class

    Friend Class PowerConsumption

        Friend Shared Function GetData() As DataTable
            Dim table As DataTable = New DataTable()
            table.Columns.AddRange(New DataColumn() {New DataColumn("Branch", GetType(String)), New DataColumn("Time", GetType(Date)), New DataColumn("Power", GetType(Double))})
            table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 7, 0, 0), 429)
            table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 8, 0, 0), 432)
            table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 9, 0, 0), 301)
            table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 10, 0, 0), 307)
            table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 11, 0, 0), 310)
            table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 12, 0, 0), 380)
            table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 13, 0, 0), 384)
            table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 14, 0, 0), 398)
            table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 15, 0, 0), 379)
            table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 16, 0, 0), 220)
            table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 17, 0, 0), 321)
            table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 18, 0, 0), 341)
            table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 19, 0, 0), 368)
            table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 20, 0, 0), 557)
            table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 21, 0, 0), 523)
            table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 22, 0, 0), 501)
            table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 23, 0, 0), 443)
            table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 7, 0, 0), 260)
            table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 8, 0, 0), 287)
            table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 9, 0, 0), 285)
            table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 10, 0, 0), 281)
            table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 11, 0, 0), 294)
            table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 12, 0, 0), 303)
            table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 13, 0, 0), 325)
            table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 14, 0, 0), 336)
            table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 15, 0, 0), 325)
            table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 16, 0, 0), 186)
            table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 17, 0, 0), 420)
            table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 18, 0, 0), 455)
            table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 19, 0, 0), 481)
            table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 20, 0, 0), 487)
            table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 21, 0, 0), 490)
            table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 22, 0, 0), 467)
            table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 23, 0, 0), 409)
            Return table
        End Function
    End Class

    Friend Class PerformanceDataSource
        Inherits List(Of PerformanceDataItem)

        Public Sub New()
            Add(New PerformanceDataItem(1, 0.21, 0.22, 0.21, 5, 5, 5))
            Add(New PerformanceDataItem(2, 0.31, 0.11, 0.02, 7, 7, 20))
            Add(New PerformanceDataItem(3, 0.11, 0.21, 0.35, 2, 12, 18))
            Add(New PerformanceDataItem(4, 0.13, 0.25, 0.29, 7, 25, 21))
            Add(New PerformanceDataItem(5, 0.02, 0.10, 0.15, 25, 25, 19))
            Add(New PerformanceDataItem(6, 0.05, 0.11, 0.21, 27, 20, 10))
            Add(New PerformanceDataItem(7, 0.11, 0.15, 0.23, 44, 17, 8))
            Add(New PerformanceDataItem(8, 0.15, 0.20, 0.30, 45, 24, 15))
            Add(New PerformanceDataItem(9, 0.18, 0.25, 0.36, 50, 29, 17))
            Add(New PerformanceDataItem(10, 0.23, 0.12, 0.38, 52, 25, 12))
            Add(New PerformanceDataItem(11, 0.21, 0.08, 0.36, 52, 28, 40))
            Add(New PerformanceDataItem(12, 0.16, 0.08, 0.37, 55, 29, 47))
            Add(New PerformanceDataItem(13, 0.22, 0.27, 0.33, 53, 25, 50))
            Add(New PerformanceDataItem(14, 0.25, 0.29, 0.22, 51, 28, 45))
            Add(New PerformanceDataItem(15, 0.22, 0.31, 0.19, 49, 30, 50))
            Add(New PerformanceDataItem(16, 0.23, 0.34, 0.15, 45, 42, 51))
            Add(New PerformanceDataItem(17, 0.25, 0.40, 0.03, 46, 45, 48))
            Add(New PerformanceDataItem(18, 0.32, 0.54, 0.04, 42, 40, 43))
            Add(New PerformanceDataItem(19, 0.30, 0.51, 0.03, 45, 20, 15))
            Add(New PerformanceDataItem(20, 0.31, 0.45, 0.07, 48, 21, 19))
            Add(New PerformanceDataItem(21, 0.25, 0.40, 0.05, 48, 35, 25))
            Add(New PerformanceDataItem(22, 0.10, 0.43, 0.07, 49, 33, 27))
            Add(New PerformanceDataItem(23, 0.05, 0.45, 0.15, 49, 35, 30))
            Add(New PerformanceDataItem(24, 0.03, 0.44, 0.21, 51, 37, 32))
            Add(New PerformanceDataItem(25, 0.01, 0.42, 0.23, 55, 40, 37))
            Add(New PerformanceDataItem(26, 0.01, 0.45, 0.21, 57, 43, 39))
            Add(New PerformanceDataItem(27, 0.01, 0.43, 0.22, 59, 50, 43))
            Add(New PerformanceDataItem(28, 0.01, 0.39, 0.25, 62, 51, 42))
            Add(New PerformanceDataItem(29, 0.03, 0.27, 0.20, 42, 31, 23))
            Add(New PerformanceDataItem(30, 0.07, 0.25, 0.14, 25, 20, 17))
            Add(New PerformanceDataItem(31, 0.05, 0.12, 0.09, 35, 25, 20))
            Add(New PerformanceDataItem(32, 0.03, 0.10, 0.05, 41, 29, 24))
            Add(New PerformanceDataItem(33, 0.05, 0.08, 0.06, 48, 32, 26))
            Add(New PerformanceDataItem(34, 0.02, 0.09, 0.06, 55, 37, 28))
            Add(New PerformanceDataItem(35, 0.05, 0.11, 0.07, 59, 38, 28))
            Add(New PerformanceDataItem(36, 0.03, 0.13, 0.05, 63, 39, 30))
            Add(New PerformanceDataItem(37, 0.02, 0.15, 0.03, 67, 43, 31))
            Add(New PerformanceDataItem(38, 0.05, 0.12, 0.07, 71, 50, 32))
            Add(New PerformanceDataItem(39, 0.07, 0.16, 0.12, 65, 43, 31))
            Add(New PerformanceDataItem(40, 0.09, 0.25, 0.18, 61, 39, 30))
            Add(New PerformanceDataItem(41, 0.09, 0.23, 0.19, 60, 38, 30))
            Add(New PerformanceDataItem(42, 0.10, 0.25, 0.20, 63, 37, 31))
            Add(New PerformanceDataItem(43, 0.11, 0.22, 0.18, 64, 35, 32))
            Add(New PerformanceDataItem(44, 0.13, 0.31, 0.19, 60, 36, 30))
            Add(New PerformanceDataItem(45, 0.17, 0.33, 0.22, 58, 35, 31))
            Add(New PerformanceDataItem(46, 0.23, 0.30, 0.27, 63, 32, 33))
            Add(New PerformanceDataItem(47, 0.20, 0.25, 0.30, 58, 29, 31))
            Add(New PerformanceDataItem(48, 0.17, 0.23, 0.35, 62, 28, 32))
            Add(New PerformanceDataItem(49, 0.15, 0.25, 0.37, 60, 26, 30))
            Add(New PerformanceDataItem(50, 0.12, 0.22, 0.40, 55, 23, 27))
            Add(New PerformanceDataItem(51, 0.11, 0.20, 0.42, 57, 21, 31))
            Add(New PerformanceDataItem(52, 0.09, 0.18, 0.45, 60, 20, 35))
            Add(New PerformanceDataItem(53, 0.08, 0.17, 0.46, 65, 19, 45))
            Add(New PerformanceDataItem(54, 0.05, 0.10, 0.52, 77, 17, 43))
            Add(New PerformanceDataItem(55, 0.03, 0.12, 0.55, 81, 18, 40))
            Add(New PerformanceDataItem(56, 0.05, 0.09, 0.53, 75, 17, 15))
            Add(New PerformanceDataItem(57, 0.07, 0.12, 0.47, 67, 18, 16))
            Add(New PerformanceDataItem(58, 0.03, 0.09, 0.35, 60, 19, 12))
            Add(New PerformanceDataItem(59, 0.05, 0.12, 0.23, 41, 10, 5))
            Add(New PerformanceDataItem(60, 0.03, 0.07, 0.10, 33, 5, 3))
        End Sub
    End Class
End Namespace
