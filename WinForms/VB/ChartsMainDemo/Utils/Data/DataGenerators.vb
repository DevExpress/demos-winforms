Imports System
Imports System.Collections.Generic
Imports System.Threading
Imports DevExpress.Data.Utils
Imports DevExpress.DXperience.Demos
Imports System.Runtime.InteropServices

Namespace DevExpress.XtraCharts.Demos

    Friend Class DataGenerator

        Const RndMax As Integer = 20

        Const RndMin As Integer = 10

        Private ReadOnly rnd As NonCryptographicRandom

        Private [integer] As Integer = 0

        Private value As Double

        Private value2 As Double = Double.NaN

        Private ReadOnly multiplier As Integer

        Private ReadOnly seriesIndex As Integer

        Friend Sub New(ByVal seriesIndex As Integer, ByVal startValue As Double)
            Me.seriesIndex = seriesIndex
            value = startValue
            multiplier = If(seriesIndex Mod 2 = 0, 1, -1)
            rnd = New NonCryptographicRandom(seriesIndex)
        End Sub

        Friend Sub New(ByVal rndSeek As Integer)
            Me.New(rndSeek, 0)
        End Sub

        Friend Sub New()
            Me.New(0, 0)
        End Sub

        Private Function GenerateDataPoint(ByVal seriesType As SeriesDataType, ByVal Optional negativeValues As Boolean = False) As DataPoint
            Dim dataPoint As DataPoint
            Select Case seriesType
                Case SeriesDataType.Financial
                    dataPoint = GenerateFinancialDataPoint()
                Case SeriesDataType.ArgumentValue
                    dataPoint = GenerateArgValueDataPoint(negativeValues)
                Case SeriesDataType.Bubble
                    dataPoint = GenerateBubblePoint()
                Case SeriesDataType.Range
                    dataPoint = GenerateRangeDataPoint()
                Case SeriesDataType.Funnel
                    dataPoint = GenerateFunnelPoint()
                Case SeriesDataType.BoxPlot
                    dataPoint = GenerateBoxPlotDataPoint()
                Case Else
                    Throw New NotImplementedException("Data generator for " & seriesType & "has not implemented")
            End Select

            Return dataPoint
        End Function

        Private Function GenerateFunnelPoint() As DataPoint
            Dim dataPoint As DataPoint = GenerateDataPointWithArgument()
            value -= rnd.Next(1, 7)
            dataPoint.Value = value
            Return dataPoint
        End Function

        Private Function GenerateBubblePoint() As DataPoint
            Dim dataPoint As DataPoint = GenerateDataPointWithArgument()
            dataPoint.Value = rnd.Next(RndMax)
            dataPoint.Weight = rnd.Next(RndMax)
            Return dataPoint
        End Function

        Private Function GenerateArgValueDataPoint(ByVal Optional negativeValues As Boolean = False) As DataPoint
            Dim dataPoint As DataPoint = GenerateDataPointWithArgument()
            Dim sign As Integer = If(negativeValues, -1, 1)
            value += multiplier * Math.Round(5 * rnd.NextDouble() * sign - 2.2)
            dataPoint.Value = value
            Return dataPoint
        End Function

        Private Function GenerateFinancialDataPoint() As DataPoint
            Dim dataPoint As DataPoint = GenerateDataPointWithArgument()
            value += rnd.Next(-6, 5)
            dataPoint.Low = value
            dataPoint.Open = value + rnd.Next(1, 5)
            Dim close As Double = value + rnd.Next(1, 5)
            If dataPoint.Open = close Then close += 1.5
            dataPoint.Close = close
            dataPoint.High = Math.Max(dataPoint.Close, dataPoint.Open) + rnd.Next(1, 4)
            Return dataPoint
        End Function

        Private Function GenerateBoxPlotDataPoint() As DataPoint
            Dim dataPoint As DataPoint = GenerateDataPointWithArgument()
            value += rnd.Next(-5, 6)
            dataPoint.Min = value
            dataPoint.Quartile1 = value + rnd.Next(1, 5)
            dataPoint.Median = dataPoint.Quartile1 + rnd.Next(4, 8)
            dataPoint.Mean = dataPoint.Median + rnd.Next(-3, 3)
            dataPoint.Quartile3 = dataPoint.Mean + rnd.Next(4, 9)
            dataPoint.Max = dataPoint.Quartile3 + rnd.Next(1, 5)
            dataPoint.Outliers = New Double(2) {}
            dataPoint.Outliers(0) = dataPoint.Min - rnd.Next(1, 3)
            dataPoint.Outliers(1) = dataPoint.Max + rnd.Next(1, 3)
            dataPoint.Outliers(2) = dataPoint.Max + rnd.Next(4, 10)
            Return dataPoint
        End Function

        Private Function GenerateRangeDataPoint() As DataPoint
            If Double.IsNaN(value2) Then value2 = value + 20
            Dim dataPoint As DataPoint = GenerateDataPointWithArgument()
            value += rnd.Next(-3, 3)
            value2 += rnd.Next(-9, 3)
            dataPoint.Value = value
            dataPoint.Value2 = value2
            Return dataPoint
        End Function

        Private Function GenerateDataPointWithArgument() As DataPoint
            [integer] += 1
            Dim point As DataPoint = CreateDataPoint()
            point.Argument = [integer]
            Return point
        End Function

        Protected Function CreateDataPoint() As DataPoint
            Return New DataPoint() With {.Series = String.Format("Series {0}", seriesIndex + 1)}
        End Function

        Friend Function GenerateData(ByVal seriesType As SeriesDataType, ByVal pointCount As Integer, ByVal Optional negativeValues As Boolean = False) As List(Of DataPoint)
            Dim data As List(Of DataPoint) = New List(Of DataPoint)()
            For i As Integer = 0 To pointCount - 1
                Dim point As DataPoint = GenerateDataPoint(seriesType, negativeValues)
                data.Add(point)
            Next

            Return data
        End Function

        Friend Function GeneratePolarData(ByVal seriesType As SeriesDataType, ByVal pointCount As Integer) As List(Of DataPoint)
            Dim [step] As Double = 360.0 / pointCount
            Dim argument As Double = -[step]
            Dim data As List(Of DataPoint) = New List(Of DataPoint)()
            For i As Integer = 0 To pointCount - 1
                Dim point As DataPoint = CreateDataPoint()
                argument += [step] + rnd.Next(-10, 10)
                point.Argument = argument
                point.Value = rnd.Next(RndMin, RndMax)
                If seriesType = SeriesDataType.Range Then point.Value2 = rnd.Next(RndMin + 10, RndMax + 7)
                data.Add(point)
            Next

            Return data
        End Function

        Friend Function GenerateXyScatterData() As List(Of DataPoint)
            Dim data As List(Of DataPoint) = New List(Of DataPoint)()
            For i As Integer = 0 To 720 - 1 Step 10
                Dim t As Double = CDbl(i) / 180 * Math.PI
                Dim x As Double = t * Math.Cos(t)
                Dim y As Double = t * Math.Sin(t)
                Dim dataPoint As DataPoint = CreateDataPoint()
                dataPoint.Argument = x
                dataPoint.Value = y
                data.Add(dataPoint)
            Next

            Return data
        End Function
    End Class

    Friend Enum SeriesDataType
        ArgumentValue
        Financial
        Bubble
        Range
        Funnel
        BoxPlot
    End Enum

    Friend Module LargeDataGenerator

        Private counter As Integer = 0

        Public Function GenerateSeriesDataSourceSine(ByVal pointsCount As Integer) As List(Of SimpleDataPoint)
            Dim points As List(Of SimpleDataPoint) = New List(Of SimpleDataPoint)()
            Dim value As Double = 0
            Dim argument As Double = 0
            counter += 1
            For i As Integer = 0 To pointsCount - 1
                argument = i
                value = CSng(Math.Sin(argument) + Math.Sin(argument / 100.0) + 30 * Math.Sin(argument / 1000.0) + 1000 * (1 + 0.1 * counter Mod 10) * Math.Sin(argument / 100000.0 + Math.PI / 6 * counter))
                points.Add(New SimpleDataPoint(argument, value))
            Next

            Return points
        End Function

        Friend Function GenerateSeriesDataSource(ByVal pointsCount As Integer) As List(Of SimpleDataPoint)
            Dim points As List(Of SimpleDataPoint) = New List(Of SimpleDataPoint)(pointsCount)
            Dim random As NonCryptographicRandom = TutorialConstants.Random
            Dim value As Double = 0
            Dim delta As Double =(random.NextDouble()) / 75
            For i As Integer = 0 To pointsCount - 1
                points.Add(New SimpleDataPoint(i, value))
                value = value + random.NextDouble() - 0.5 + delta
            Next

            Return points
        End Function
    End Module

    Friend Module PolarDiagramPointsGenerator

        Const DefaultPointsCount As Integer = 72

        Private Function GenerateSeriesPoint(ByVal m As Double, ByVal value As Double, ByVal pointsInSeries As Integer) As SeriesPoint
            Dim points As Double() = New Double(pointsInSeries - 1) {}
            For i As Integer = 0 To pointsInSeries - 1
                Dim factor As Double = If(i = 0, m, 0)
                points(i) = [Function](factor, value)
            Next

            Return New SeriesPoint(value, points)
        End Function

        Private Function [Function](ByVal m As Double, ByVal angle As Double) As Double
            Dim cos As Double = Math.Cos(m * ToRadian(90.0 + angle))
            Return Math.Pow(Math.Abs(cos), m)
        End Function

        Private Function ToRadian(ByVal angle As Double) As Double
            Return angle * Math.PI / 180.0
        End Function

        Private Function GenerateFunctionPoints(ByVal m As Double, ByVal pointCount As Integer, ByVal pointsInSeries As Integer) As SeriesPoint()
            Dim [step] As Integer = 360 \ pointCount
            Dim points As SeriesPoint() = New SeriesPoint(pointCount - 1) {}
            For i As Integer = 0 To pointCount - 1
                points(i) = GenerateSeriesPoint(m, i * [step], pointsInSeries)
            Next

            Return points
        End Function

        Private Function GetLineFactor(ByVal functionType As Integer) As Double
            Select Case functionType
                Case 0
                    Return 1
                Case 1
                    Return 0.5
                Case Else
                    Return 2
            End Select
        End Function

        Friend Function GenerateFunctionPoints(ByVal functionType As Integer, ByVal pointsInSeries As Integer) As SeriesPoint()
            Dim lineFactor As Double = GetLineFactor(functionType)
            Return GenerateFunctionPoints(lineFactor, DefaultPointsCount, pointsInSeries)
        End Function
    End Module

    Friend Class SensorDataGenerator

        Const InitialDataPointsCount As Integer = 10000

        Const DataGenerationIntervalMilliseconds As Integer = 15

        Private ReadOnly dataSourceField As DataCollection = New DataCollection()

        Private ReadOnly random As NonCryptographicRandom = New NonCryptographicRandom(1)

        Private ReadOnly buffer As List(Of SensorIndicationItem) = New List(Of SensorIndicationItem)()

        Private ReadOnly sync As Object = New Object()

        Private counter As Integer

        Private yAddition1 As Double = 0

        Private yAddition2 As Double = 0

        Private yAddition3 As Double = 0

        Private yAddition4 As Double = 0

        Private yAddition5 As Double = 0

        Private yAddition6 As Double = 0

        Private yAddition7 As Double = 0

        Private yAddition8 As Double = 0

        Private generatingEnabled As Boolean = False

        Private generatingThread As Thread

        Friend ReadOnly Property DataSource As DataCollection
            Get
                Return dataSourceField
            End Get
        End Property

        Private Function CreatePoint(ByVal timeStamp As Date) As SensorIndicationItem
            counter += 1
            Dim arg As Double = timeStamp.ToOADate()
            arg = arg * 250000R
            If counter Mod random.Next(300, 500) = 0 Then yAddition1 += random.Next(10, 20) * Math.Sign(random.NextDouble() - 0.5)
            If yAddition1 < -30 Then yAddition1 += 10
            If yAddition1 > 30 Then yAddition1 -= 10
            Dim indication1 As Double = 5 * Math.Sin(5R / 2R * Math.Cos(arg)) + 100 + (random.NextDouble() - 0.5) * 5 + yAddition1
            If counter Mod random.Next(100, 300) = 0 Then yAddition2 += random.Next(10, 20) * Math.Sign(random.NextDouble() - 0.5)
            If yAddition2 < -30 Then yAddition2 += 10
            If yAddition2 > 30 Then yAddition2 -= 10
            Dim indication2 As Double = 4 * Math.Sin(7 * Math.Cos(arg - 1.5)) + 90 + (random.NextDouble() - 0.5) * 7 + yAddition2
            If counter Mod random.Next(100, 500) = 0 Then yAddition3 += random.Next(10, 20) * Math.Sign(random.NextDouble() - 0.5)
            If yAddition3 < -30 Then yAddition3 += 10
            If yAddition3 > 30 Then yAddition3 -= 10
            Dim indication3 As Double = 10 * (Math.Sin(arg) + Math.Sin(arg / 1.2R) + Math.Sin(arg / 1.5R)) + 100 + random.NextDouble() * 12 + yAddition3
            If counter Mod random.Next(50, 100) = 0 Then yAddition4 += random.Next(10, 20) * Math.Sign(random.NextDouble() - 0.5)
            If yAddition4 < -30 Then yAddition4 += 10
            If yAddition4 > 30 Then yAddition4 -= 10
            Dim indication4 As Double = 10 * (Math.Cos(arg + 1.5) + Math.Sin(arg / 1.2R + 0.5) + Math.Cos(arg / 1.5R + 0.3)) + 120 + random.NextDouble() * 15 + yAddition4
            If counter Mod random.Next(300, 400) = 0 Then yAddition5 += random.Next(10, 20) * Math.Sign(random.NextDouble() - 0.5)
            If yAddition5 < -30 Then yAddition5 += 10
            If yAddition5 > 30 Then yAddition5 -= 10
            Dim indication5 As Double = 15 * Math.Cos(Math.Tan(arg + random.NextDouble() / 10)) + 500 + random.NextDouble() * 15 + yAddition5
            If counter Mod random.Next(400, 1000) = 0 Then yAddition6 += random.Next(10, 20) * Math.Sign(random.NextDouble() - 0.5)
            If yAddition6 < -30 Then yAddition6 += 10
            If yAddition6 > 30 Then yAddition6 -= 10
            Dim indication6 As Double = 20 * Math.Sin(Math.Tan(arg + 1)) + 450 + random.NextDouble() * 9 + yAddition6
            If counter Mod random.Next(200, 300) = 0 Then yAddition7 += random.Next(10, 20) * Math.Sign(random.NextDouble() - 0.5)
            If yAddition7 < -30 Then yAddition7 += 10
            If yAddition7 > 30 Then yAddition7 -= 10
            Dim indication7 As Double = 30 * Math.Abs(Math.Sin(Math.Tan(arg + 1))) + Math.Cos(arg) + Math.Sin(arg) + 750 + random.NextDouble() * 15 + yAddition7
            If counter Mod random.Next(300, 350) = 0 Then yAddition8 += random.Next(10, 20) * Math.Sign(random.NextDouble() - 0.5)
            If yAddition8 < -30 Then yAddition8 += 10
            If yAddition8 > 30 Then yAddition8 -= 10
            Dim indication8 As Double = 30 * (1 - Math.Cos(arg)) / random.Next(1, 5) + 700 + random.NextDouble() * 15 + yAddition8
            Return New SensorIndicationItem(timeStamp, indication1, indication2, indication3, indication4, indication5, indication6, indication7, indication8)
        End Function

        Private Sub AddPoint(ByVal timeStamp As Date)
            Dim point As SensorIndicationItem = CreatePoint(timeStamp)
            SyncLock sync
                buffer.Add(point)
            End SyncLock
        End Sub

        Private Sub GeneratingLoop()
            Dim timeStamp As Date = Date.Now
            While generatingEnabled
                Dim newTimeStamp As Date = timeStamp.AddMilliseconds(DataGenerationIntervalMilliseconds)
                Dim span As TimeSpan = newTimeStamp - Date.Now
                If span.Ticks > 0 Then Call Thread.Sleep(CInt(span.TotalMilliseconds))
                timeStamp = newTimeStamp
                AddPoint(timeStamp)
            End While
        End Sub

        Friend Sub GenerateInitialData()
            Dim baseTimeStamp As Date = TutorialConstants.Now.AddMilliseconds(-InitialDataPointsCount * DataGenerationIntervalMilliseconds)
            Dim argument As Date = baseTimeStamp
            For i As Integer = 0 To InitialDataPointsCount - 1 - 1
                argument = argument.AddMilliseconds(DataGenerationIntervalMilliseconds)
                Dim point As SensorIndicationItem = CreatePoint(argument)
                dataSourceField.Add(point)
            Next
        End Sub

        Friend Sub UpdateDataSource()
            SyncLock sync
                dataSourceField.AddRange(buffer)
                If dataSourceField.Count > InitialDataPointsCount Then dataSourceField.RemoveRangeAt(0, buffer.Count)
                buffer.Clear()
            End SyncLock
        End Sub

        Friend Sub Start()
            If generatingThread Is Nothing Then generatingThread = New Thread(New ThreadStart(AddressOf GeneratingLoop))
            generatingEnabled = True
            generatingThread.Start()
        End Sub

        Friend Sub [Stop]()
            generatingEnabled = False
            If generatingThread IsNot Nothing Then generatingThread.Join()
            generatingThread = Nothing
        End Sub
    End Class

    Friend Class RealTimeFinancialDataGenerator

        Const MinPrice As Double = 5.0

        Const StartPrice As Double = 24.0

        Const InitialDataPointsCount As Integer = 350000

        Const MaxPointsCount As Integer = 255000

        Const PeriodMilliseconds As Integer = 30

        Private ReadOnly dataSourceField As FinancialDataCollection = New FinancialDataCollection()

        Private ReadOnly random As NonCryptographicRandom = New NonCryptographicRandom(3)

        Private ReadOnly buffer As List(Of FinancialDataPoint) = New List(Of FinancialDataPoint)()

        Private ReadOnly bufferSync As Object = New Object()

        Private prevPoint As FinancialDataPoint

        Private generatingEnabled As Boolean = False

        Private generatingThread As Thread

        Public ReadOnly Property DataSource As FinancialDataCollection
            Get
                Return dataSourceField
            End Get
        End Property

        Public ReadOnly Property LastArgument As Date
            Get
                Return prevPoint.DateTimeStamp
            End Get
        End Property

        Private firstOnlinePoint As Boolean = True

        Private Function CreateOnlinePoint(ByVal argument As Date, ByVal locPrevPoint As FinancialDataPoint) As FinancialDataPoint
            Dim priceDelta As Double =(random.NextDouble() - 0.5) / 300R
            Dim close As Double = locPrevPoint.Close + priceDelta
            If close <= MinPrice Then close = 2 * MinPrice - close
            Dim open As Double = locPrevPoint.Close
            Dim high As Double = Math.Max(open, close) + random.NextDouble() / 100R
            Dim low As Double = Math.Min(open, close) - random.NextDouble() / 100R
            Dim volume As Double
            If Not firstOnlinePoint Then
                volume = locPrevPoint.Volume + random.Next(-5, 5)
            Else
                volume = 2
                firstOnlinePoint = False
            End If

            If volume < 2 Then volume = 4 - volume
            Return New FinancialDataPoint(argument, open, high, low, close, volume)
        End Function

        Private Function CreateHistoryPoint(ByVal argument As Date, ByVal locPrevPoint As FinancialDataPoint) As FinancialDataPoint
            Dim priceDelta As Double =(random.NextDouble() - 0.5) / 8R
            Dim close As Double = locPrevPoint.Close + priceDelta
            If close <= MinPrice Then close = 2 * MinPrice - close
            Dim open As Double = locPrevPoint.Close
            Dim high As Double = Math.Max(open, close) + (random.NextDouble()) / 25R
            Dim low As Double = Math.Min(open, close) - (random.NextDouble()) / 25R
            Dim volume As Double = locPrevPoint.Volume + random.Next(-50000, 50000)
            If volume < 10000 Then volume = 2 * 10000 - volume
            If volume > 200000 Then volume = 200000 - CInt(volume / 4)
            Return New FinancialDataPoint(argument, open, high, low, close, volume)
        End Function

        Private Sub GeneratingLoop()
            Dim timeStamp As Date = Date.Now
            While generatingEnabled
                Dim newTimeStamp As Date = timeStamp.AddMilliseconds(PeriodMilliseconds)
                Dim span As TimeSpan = newTimeStamp - Date.Now
                If span.Ticks > 0 Then Call Thread.Sleep(CInt(span.TotalMilliseconds))
                timeStamp = newTimeStamp
                AddPoint(timeStamp)
            End While
        End Sub

        Private currentAggregatingPoint As FinancialDataPoint

        Private Sub AddPoint(ByVal timeStamp As Date)
            Dim point As FinancialDataPoint = CreateOnlinePoint(timeStamp, prevPoint)
            If currentAggregatingPoint.DateTimeStamp.Minute = timeStamp.Minute Then
                currentAggregatingPoint.Close = point.Close
                currentAggregatingPoint.High = Math.Max(currentAggregatingPoint.High, point.High)
                currentAggregatingPoint.Low = Math.Min(currentAggregatingPoint.Low, point.Low)
                currentAggregatingPoint.Volume += point.Volume
                SyncLock bufferSync
                    If buffer.Count > 0 Then
                        buffer(buffer.Count - 1) = currentAggregatingPoint
                    Else
                        buffer.Add(currentAggregatingPoint)
                    End If

                End SyncLock
            Else
                SyncLock bufferSync
                    currentAggregatingPoint = point
                    buffer.Add(point)
                End SyncLock
            End If

            prevPoint = point
        End Sub

        Private Function TheSameMinute(ByVal dt1 As Date, ByVal dt2 As Date) As Boolean
            Return(dt1 - Date.MinValue).TotalMinutes = (dt2 - Date.MinValue).TotalMinutes
        End Function

        Friend Sub GenerateInitialData()
            Dim baseDate As Date = TutorialConstants.Now.AddMinutes(-InitialDataPointsCount).Date
            If baseDate.DayOfWeek = DayOfWeek.Saturday OrElse baseDate.DayOfWeek = DayOfWeek.Sunday Then baseDate = baseDate.AddDays(If(baseDate.DayOfWeek = DayOfWeek.Saturday, 2, 1))
            prevPoint = New FinancialDataPoint(baseDate, StartPrice, StartPrice + 0.002, StartPrice - 0.002, StartPrice + 0.001, 100000)
            dataSourceField.Add(prevPoint)
            Dim argument As Date = baseDate
            While argument < TutorialConstants.Now.AddMinutes(-1)
                argument = argument.AddMinutes(1)
                If argument.DayOfWeek = DayOfWeek.Saturday Then argument = argument.AddDays(2)
                Dim point As FinancialDataPoint = CreateHistoryPoint(argument, prevPoint)
                prevPoint = point
                dataSourceField.Add(point)
            End While

            currentAggregatingPoint = prevPoint
            currentAggregatingPoint.Volume = CInt(TutorialConstants.Now.Second / 60R * currentAggregatingPoint.Volume)
        End Sub

        Friend Sub UpdateDataSource()
            Dim tempBuffer As List(Of FinancialDataPoint)
            SyncLock bufferSync
                tempBuffer = New List(Of FinancialDataPoint)(buffer)
                buffer.Clear()
            End SyncLock

            If tempBuffer.Count = 0 Then Return
            If TheSameMinute(tempBuffer(0).DateTimeStamp, dataSourceField(dataSourceField.Count - 1).DateTimeStamp) Then
                dataSourceField(dataSourceField.Count - 1) = tempBuffer(0)
            Else
                dataSourceField.Add(tempBuffer(0))
            End If

            If tempBuffer.Count > 1 Then dataSourceField.AddRange(tempBuffer.GetRange(1, tempBuffer.Count - 1))
            Dim overflow As Integer = dataSourceField.Count - MaxPointsCount
            If overflow > 0 Then
                dataSourceField.RemoveRangeAt(0, overflow)
            End If
        End Sub

        Friend Sub Start()
            If generatingThread Is Nothing Then generatingThread = New Thread(New ThreadStart(AddressOf GeneratingLoop))
            generatingEnabled = True
            generatingThread.Start()
        End Sub

        Friend Sub [Stop]()
            generatingEnabled = False
            If generatingThread IsNot Nothing Then generatingThread.Join()
            generatingThread = Nothing
        End Sub
    End Class

    Friend Module FinancialDataGenerator

        Const StartPrice As Double = 26

        Const MaxPrice As Double = 100

        Const MinPrice As Double = 5

        Const StartWorkingHour As Integer = 8

        Const EndWorkingHour As Integer = 18

        Const Holiday1Day As Integer = 1

        Const Holiday1Month As Integer = 1

        Const Holiday2Day As Integer = 1

        Const Holiday2Month As Integer = 5

        Const Weekend1 As DayOfWeek = DayOfWeek.Saturday

        Const Weekend2 As DayOfWeek = DayOfWeek.Sunday

        Private Function GeneratePoint(ByVal dateTime As Date, ByVal previousClose As Double, ByVal random As NonCryptographicRandom, <Out> ByRef newPreviousClose As Double, <Out> ByRef point As FinancialDataPoint) As Boolean
            If dateTime.Hour < StartWorkingHour OrElse dateTime.Hour >= EndWorkingHour OrElse dateTime.DayOfWeek = Weekend1 OrElse dateTime.DayOfWeek = Weekend2 OrElse dateTime.Day = Holiday1Day AndAlso dateTime.Month = Holiday1Month OrElse dateTime.Day = Holiday2Day AndAlso dateTime.Month = Holiday2Month Then
                newPreviousClose = Double.NaN
                point = New FinancialDataPoint()
                Return False
            End If

            Dim open As Double
            If dateTime.Hour = StartWorkingHour Then
                open = previousClose + (random.NextDouble() - 0.5) / 2R
            Else
                open = previousClose
            End If

            Dim close As Double = open + (random.NextDouble() - 0.5) / 5R
            If close > MaxPrice Then close = 0.8 * close
            If close <= MinPrice Then close = 2 * MinPrice - close
            Dim high As Double = Math.Max(open, close) + random.NextDouble() / 5R
            Dim low As Double = Math.Min(open, close) - random.NextDouble() / 5R
            Dim volume As Double =(random.NextDouble() + 0.1) * 1000R
            newPreviousClose = close
            point = New FinancialDataPoint(dateTime, open, high, low, close, volume)
            Return True
        End Function

        Friend Function Generate() As List(Of FinancialDataPoint)
            Dim random As NonCryptographicRandom = New NonCryptographicRandom(28)
            Dim points As List(Of FinancialDataPoint) = New List(Of FinancialDataPoint)()
            Dim startYear As Integer = TutorialConstants.Now.Year - 3
            Dim currentDateTime As Date = New DateTime(startYear, 1, 2, 8, 0, 0)
            Dim endDateTime As Date = New DateTime(startYear + 3, 1, 1, 0, 0, 0)
            Dim previousClose As Double = StartPrice
            While currentDateTime < endDateTime
                Dim point As FinancialDataPoint = New FinancialDataPoint()
                Dim newPreviousClose As Double
                Dim generated As Boolean = GeneratePoint(currentDateTime, previousClose, random, newPreviousClose, point)
                If generated Then
                    previousClose = newPreviousClose
                    points.Add(point)
                End If

                currentDateTime = currentDateTime.AddHours(1)
            End While

            Return points
        End Function
    End Module

    Friend Module ScatterLineDataGenerator

        Const A As Integer = 10

        Private Sub FillSeriesPoints(ByVal visibleSeries As Series, ByVal visibleSeriesIndex As Integer)
            Select Case visibleSeriesIndex
                Case 0
                    FillArchimedeanSpiralSeries(visibleSeries)
                Case 1
                    FillCardioidSeries(visibleSeries)
                Case 2
                    FillCartesianFoliumPSeries(visibleSeries)
            End Select
        End Sub

        Private Sub FillArchimedeanSpiralSeries(ByVal series As Series)
            For i As Integer = 0 To 720 - 1 Step 10
                Dim t As Double = CDbl(i) / 180 * Math.PI
                Dim x As Double = t * Math.Cos(t)
                Dim y As Double = t * Math.Sin(t)
                series.Points.Add(New SeriesPoint(x, y))
            Next
        End Sub

        Private Sub FillCardioidSeries(ByVal series As Series)
            For i As Integer = 0 To 360 - 1 Step 10
                Dim t As Double = CDbl(i) / 180 * Math.PI
                Dim x As Double = A * (2 * Math.Cos(t) - Math.Cos(2 * t))
                Dim y As Double = A * (2 * Math.Sin(t) - Math.Sin(2 * t))
                series.Points.Add(New SeriesPoint(x, y))
            Next
        End Sub

        Private Sub FillCartesianFoliumPSeries(ByVal series As Series)
            For i As Integer = -30 To 125 - 1 Step 5
                Dim t As Double = Math.Tan(CDbl(i) / 180 * Math.PI)
                Dim x As Double = 3 * CDbl(A) * t / (t * t * t + 1)
                Dim y As Double = x * t
                series.Points.Add(New SeriesPoint(x, y))
            Next
        End Sub

        Friend Sub ShowSeries(ByVal visibleSeriesIndex As Integer, ByVal series As SeriesCollection)
            For i As Integer = 0 To series.Count - 1
                If i = visibleSeriesIndex Then
                    Dim visibleSeries As Series = series(i)
                    If visibleSeries.Points.Count = 0 Then FillSeriesPoints(visibleSeries, visibleSeriesIndex)
                    visibleSeries.Visible = True
                Else
                    series(i).Visible = False
                End If
            Next
        End Sub
    End Module

    Friend Class PointGenerator

        Const startValue As Double = 0

        Public Shared Function Generate() As List(Of SimpleDataPoint)
            Dim random1 As NonCryptographicRandom = New NonCryptographicRandom(2)
            Dim random2 As NonCryptographicRandom = New NonCryptographicRandom(3)
            Dim previousValue As Double = startValue
            Dim list As List(Of SimpleDataPoint) = New List(Of SimpleDataPoint)() From {New SimpleDataPoint(0, previousValue)}
            Dim x As Double = -2000
            While x < 2000
                Dim value As Double = previousValue + random1.Next(-98, 100)
                Dim pointValue As Double = value - 3000
                list.Add(New SimpleDataPoint(x, pointValue))
                previousValue = value
                x += random2.NextDouble() * 3
            End While

            Return list
        End Function

        Public Shared Function GenerateCluster(ByVal random As NonCryptographicRandom, ByVal xPlus As Integer, ByVal xMinus As Integer, ByVal yPlus As Integer, ByVal yMinus As Integer, ByVal count As Integer) As SimpleDataPoint()
            Dim seriesPoints As SimpleDataPoint() = New SimpleDataPoint(count - 1) {}
            Dim deltaX As Integer = xMinus - xPlus
            Dim deltaY As Integer = yMinus - yPlus
            Dim centerX As Integer = xMinus \ 2 + xPlus \ 2
            Dim centerY As Integer = yMinus \ 2 + yPlus \ 2
            For i As Integer = 0 To count - 1
                Dim half As Integer = i \ 2 + 1
                Dim ratio As Double = Math.Max(2.1, CDbl(count) / half)
                Dim xOffset As Integer = CInt(deltaX / ratio)
                Dim yOffset As Integer = CInt(deltaY / ratio)
                Dim delta As Integer = xMinus - xOffset - centerX
                Dim rx, ry As Integer
                Do
                    rx = random.Next(xPlus + xOffset, xMinus - xOffset)
                    ry = random.Next(yPlus + yOffset, yMinus - yOffset)
                Loop While delta * delta < Math.Pow(centerX - rx, 2) + Math.Pow(centerY - ry, 2)

                seriesPoints(i) = New SimpleDataPoint(rx, ry)
            Next

            Return seriesPoints
        End Function
    End Class
End Namespace
