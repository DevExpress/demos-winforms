Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Xml.Serialization
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos

    Friend Class HeadphoneComparisonDataReader

        Const FileName As String = "HeadphoneComparison.dat"

        Shared Friend Function ReadDataFromFile() As List(Of HeadphoneComparisonPoint)
            Dim dataSource As List(Of HeadphoneComparisonPoint) = New List(Of HeadphoneComparisonPoint)()
            Dim stream As Stream = AssemblyHelper.GetEmbeddedResourceStream(GetType(HeadphoneComparisonDataReader).Assembly, FileName, False)
            Dim reader As StreamReader
            Try
                reader = New StreamReader(stream)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    If line.Length = 0 OrElse line.StartsWith("//") Then Continue While
                    Dim cells As String() = line.Split(New String() {","}, StringSplitOptions.None)
                    Dim name As String = cells(0)
                    Dim frequency As Double = Double.Parse(cells(1), CultureInfo.InvariantCulture)
                    Dim spl90Db As Double = Double.Parse(cells(2), CultureInfo.InvariantCulture)
                    Dim spl100Db As Double = Double.Parse(cells(3), CultureInfo.InvariantCulture)
                    dataSource.Add(New HeadphoneComparisonPoint(name, frequency, spl90Db, spl100Db))
                End While
            Catch
                Throw New Exception("It's impossible to load " & FileName)
            End Try

            Return dataSource
        End Function
    End Class

    Friend Module SeaIceAreaDataReader

        Const FileName As String = "nsidc_global_nt_final_and_nrt.dat"

        Friend Function ReadDataFromFile() As List(Of SeaIceAreaDataPoint)
            Dim dataSource As List(Of SeaIceAreaDataPoint) = New List(Of SeaIceAreaDataPoint)()
            Dim stream As Stream = AssemblyHelper.GetEmbeddedResourceStream(GetType(SeaIceAreaDataReader).Assembly, FileName, False)
            Dim reader As StreamReader
            Try
                reader = New StreamReader(stream)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    If line(0) <> "1"c AndAlso line(0) <> "2"c Then Continue While
                    Dim cells As String() = line.Split(New String() {", "}, StringSplitOptions.None)
                    If Equals(cells(3).Trim(), "nan") Then Continue While
                    Dim year As String = cells(0).Split("-"c)(0)
                    Dim dayOfYear As Double = Double.Parse(cells(1), CultureInfo.InvariantCulture)
                    Dim area As Double = Double.Parse(cells(3), CultureInfo.InvariantCulture)
                    dataSource.Add(New SeaIceAreaDataPoint(Convert.ToDateTime(cells(0), CultureInfo.InvariantCulture), year, dayOfYear, area))
                End While
            Catch
                Throw New Exception("It's impossible to load " & FileName)
            End Try

            Return dataSource
        End Function
    End Module

    Friend Class HpiDataReader

        Friend Shared Function GetData() As DataTable
            Return LoadDataTableFromXml("HPI.xml", "CountryStatistics")
        End Function
    End Class

    Friend Class AgeStructureDataReader

        Private Shared ageStructureTableField As DataTable

        Private Shared ReadOnly Property AgeStructureTable As DataTable
            Get
                If ageStructureTableField Is Nothing Then ageStructureTableField = LoadPopulationAgeStructure()
                Return ageStructureTableField
            End Get
        End Property

        Private Shared Function LoadPopulationAgeStructure() As DataTable ' data for end of 2016
            Return LoadDataTableFromXml("Population.xml", "Population")
        End Function

        Friend Shared Function GetDataByAgeAndGender() As IList
            Return AgeStructureTable.AsEnumerable().[Select](Function(row) New With {.GenderAge = New GenderAgeInfo(row.Field(Of String)("Gender"), row.Field(Of String)("Age")), .Country = row.Field(Of String)("Country"), .Population = row.Field(Of Long)("Population")}).ToList()
        End Function

        Friend Shared Function GetDataByMaleAge() As IList
            Return AgeStructureTable.AsEnumerable().Where(Function(row) Equals(row.Field(Of String)("Gender"), "Male")).[Select](Function(row) New With {.Age = row.Field(Of String)("Age"), .Country = row.Field(Of String)("Country"), .Population = row.Field(Of Long)("Population")}).ToList()
        End Function

        Friend Shared Function GetDataByFemaleAge() As IList
            Return AgeStructureTable.AsEnumerable().Where(Function(row) Equals(row.Field(Of String)("Gender"), "Female")).[Select](Function(row) New With {.Age = row.Field(Of String)("Age"), .Country = row.Field(Of String)("Country"), .Population = row.Field(Of Long)("Population")}).ToList()
        End Function

        Friend Shared Function GetPopulationAgeStructure() As IList
            Return AgeStructureTable.AsEnumerable().[Select](Function(row) New AgePopulation(row.Field(Of String)("Country"), row.Field(Of String)("Age"), row.Field(Of String)("Gender"), row.Field(Of Long)("Population"))).ToList()
        End Function

        Friend Shared Function GetGenderAgeItemsWithPopulation() As IList
            Return AgeStructureTable.AsEnumerable().[Select](Function(row) New With {.GenderAge = New GenderAgeInfo(row.Field(Of String)("Gender"), row.Field(Of String)("Age")), .Country = row.Field(Of String)("Country"), .Population = row.Field(Of Long)("Population"), .PopulationString = row.Field(Of Long)("Population").ToString("0,,.00")}).ToList()
        End Function
    End Class

    Friend Class MarketPricesReader

        Public Shared Function GetGoogleStockPrices() As DataTable
            Return LoadDataTableFromXml("GoogleStock.xml", "StockPrice")
        End Function

        Public Shared Function GetAppleStockPrices() As DataTable
            Return LoadDataTableFromXml("AppleStock.xml", "StockPrice")
        End Function
    End Class

    Friend Module CsvReader

        Friend Function ReadFinancialData(ByVal fileName As String) As List(Of FinancialDataPoint)
            Dim longFileName As String = String.Empty
            Dim reader As StreamReader
            Dim dataSource As List(Of FinancialDataPoint) = New List(Of FinancialDataPoint)()
            Dim stream As Stream = AssemblyHelper.GetEmbeddedResourceStream(GetType(CsvReader).Assembly, fileName, False)
            Try
                reader = New StreamReader(stream)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim values As String() = line.Split(","c)
                    Dim point As FinancialDataPoint = New FinancialDataPoint()
                    point.DateTimeStamp = Date.ParseExact(values(0), "yyyy.MM.dd", Nothing)
                    point.Open = Double.Parse(values(1), CultureInfo.InvariantCulture)
                    point.High = Double.Parse(values(2), CultureInfo.InvariantCulture)
                    point.Low = Double.Parse(values(3), CultureInfo.InvariantCulture)
                    point.Close = Double.Parse(values(4), CultureInfo.InvariantCulture)
                    dataSource.Add(point)
                End While
            Catch
                Throw New Exception("It's impossible to load " & fileName)
            End Try

            Return dataSource
        End Function

        Friend Function ReadCarbonData(ByVal fileName As String) As List(Of CarbonContributionDataPoint)
            Dim longFileName As String = String.Empty
            Dim reader As StreamReader
            Dim dataSource As List(Of CarbonContributionDataPoint) = New List(Of CarbonContributionDataPoint)()
            Dim stream As Stream = AssemblyHelper.GetEmbeddedResourceStream(GetType(CsvReader).Assembly, fileName, False)
            Try
                reader = New StreamReader(stream)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim values As String() = line.Split(";"c)
                    Dim point As CarbonContributionDataPoint = New CarbonContributionDataPoint()
                    point.Year = values(0)
                    point.Contribution = Double.Parse(values(1), CultureInfo.InvariantCulture)
                    point.Factor = values(2)
                    dataSource.Add(point)
                End While
            Catch
                Throw New Exception("It's impossible to load " & fileName)
            End Try

            Return dataSource
        End Function
    End Module

    <XmlRoot("CountriesInfo")>
    Public Class CountriesInfo
        Inherits List(Of CountryStatisticInfo)

        Private Shared dataSourceField As List(Of CountryStatisticInfo) = Nothing

        Public Shared ReadOnly Property DataSource As List(Of CountryStatisticInfo)
            Get
                If dataSourceField Is Nothing Then
                    Using stream As Stream = AssemblyHelper.GetEmbeddedResourceStream(GetType(ChartDemoModule).Assembly, "Top10LargestCountriesInfo.xml", False)
                        dataSourceField = SafeXml.Deserialize(Of CountriesInfo)(stream)
                    End Using
                End If

                Return dataSourceField
            End Get
        End Property
    End Class
End Namespace
