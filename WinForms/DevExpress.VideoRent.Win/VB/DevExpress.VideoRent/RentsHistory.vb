Imports Microsoft.VisualBasic
Imports DevExpress.Xpo
Imports DevExpress.VideoRent.Helpers
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports DevExpress.Data.Filtering
Imports System.ComponentModel

Namespace DevExpress.VideoRent
	Public Class RentsHistory
		Private random As New Random()
		Private MustInherit Class RandomGenerator
            Private Shared frandom As New Random()
            Public Sub New()
                MyBase.New()
            End Sub
            Protected ReadOnly Property Random() As Random
                Get
                    Return frandom
                End Get
            End Property
            Public MustOverride Function [Next]() As Integer
            Public MustOverride Function GetMax() As Integer
            Public MustOverride Function GetMin() As Integer
        End Class
        Private MustInherit Class RandomGeneratorNoRepetitions
            Inherits RandomGenerator
            Public MustOverride Sub ClearRepetitions()
        End Class
        Private Class RandomGeneratorFiveState
            Inherits RandomGenerator
            Private zero, one, two, three, four, min, max As Integer
            Public Sub New(ByVal min As Integer, ByVal zero As Integer, ByVal one As Integer, ByVal two As Integer, ByVal three As Integer, ByVal four As Integer)
                MyBase.New()
                If four <> 0 Then
                    max = min + (4)
                Else
                    If three <> 0 Then
                        max = min + (3)
                    Else
                        If two <> 0 Then
                            max = min + (2)
                        Else
                            If one <> 0 Then
                                max = min + (1)
                            Else
                                max = min + (0)
                            End If
                        End If
                    End If
                End If
                Me.min = min
                Me.zero = zero
                Me.one = Me.zero + one
                Me.two = Me.one + two
                Me.three = Me.two + three
                Me.four = Me.three + four
            End Sub
            Public Overrides Function [Next]() As Integer
                Dim n As Integer = Random.Next(four)
                If n < zero Then
                    Return min
                End If
                If n < one Then
                    Return min + 1
                End If
                If n < two Then
                    Return min + 2
                End If
                If n < three Then
                    Return min + 3
                End If
                Return min + 4
            End Function
            Public Overrides Function GetMax() As Integer
                Return max
            End Function
            Public Overrides Function GetMin() As Integer
                Return min
            End Function
        End Class
        Private Class RandomGeneratorFlat
            Inherits RandomGenerator
            Private min As Integer
            Private max As Integer
            Public Shared Function MinMax(ByVal min As Integer, ByVal max As Integer) As RandomGeneratorFlat
                Dim ret As New RandomGeneratorFlat()
                ret.min = min
                ret.max = max
                Return ret
            End Function
            Private Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal aver As Integer, ByVal delta As Integer)
                MyBase.New()
                min = aver - delta
                max = aver + delta
            End Sub
            Public Overrides Function [Next]() As Integer
                Return Random.Next(min, max)
            End Function
            Public Overrides Function GetMax() As Integer
                Return max
            End Function
            Public Overrides Function GetMin() As Integer
                Return min
            End Function
        End Class
        Private Class RandomGeneratorGauss
            Inherits RandomGenerator
            Private aver As Double
            Private delta As Double
            Private min As Integer
            Private max As Integer
            Public Sub New(ByVal min As Integer, ByVal max As Integer)
                MyBase.New()
                Me.min = min
                Me.max = max
                Me.aver = CDbl(min + max) / 2.0
                Me.delta = CDbl(max - min) / 2.0
            End Sub
            Public Overrides Function [Next]() As Integer
                Dim ret As Integer = CInt(Fix(aver + delta * RandomNormal()))
                If ret < min Then
                    Return min
                End If
                If ret > max Then
                    Return max
                End If
                Return ret
            End Function
            Private Function RandomNormal() As Double
                Const s As Double = 0.449871
                Const t As Double = -0.386595
                Const a As Double = 0.196
                Const b As Double = 0.25472
                Const r1 As Double = 0.27597
                Const r2 As Double = 0.27846
                Dim u As Double
                Dim v As Double
                Do
                    u = Random.NextDouble()
                    v = 1.7156 * (Random.NextDouble() - 0.5)
                    Dim x As Double = u - s
                    Dim y As Double = Math.Abs(v) - t
                    Dim q As Double = Math.Sqrt(x) + y * (a * y - b * x)
                    If q < r1 Then
                        Exit Do
                    End If
                    If q <= r2 AndAlso Math.Sqrt(v) < -4.0 * Math.Log(u) * Math.Sqrt(u) Then
                        Exit Do
                    End If
                Loop
                Return v / u
            End Function
            Public Overrides Function GetMax() As Integer
                Return max
            End Function
            Public Overrides Function GetMin() As Integer
                Return min
            End Function
        End Class
        Private MustInherit Class RandomGeneratorSimpleNoRepetitions
            Inherits RandomGeneratorNoRepetitions
            Private repetitions As New Dictionary(Of Integer, Boolean)()
            Private fgenerator As RandomGenerator

            Public Sub New(ByVal generator As RandomGenerator)
                Me.fgenerator = generator
            End Sub
            Public Overrides Sub ClearRepetitions()
                repetitions.Clear()
            End Sub
            Public Overrides Function [Next]() As Integer
                Dim nextValue As Integer = fgenerator.Next()
                Dim ret As Integer = nextValue
                Dim begin As Integer = ret
                Dim cycle As Boolean = False
                Do While repetitions.ContainsKey(ret)
                    If ret > fgenerator.GetMax() - 1 Then
                        ret = fgenerator.GetMin()
                    Else
                        ret = ret + 1
                    End If
                    If ret = begin Then
                        cycle = True
                        Exit Do
                    End If
                Loop
                If (Not cycle) Then
                    repetitions.Add(ret, True)
                End If
                Return ret
            End Function
            Public Overrides Function GetMax() As Integer
                Return fgenerator.GetMax()
            End Function
            Public Overrides Function GetMin() As Integer
                Return fgenerator.GetMin()
            End Function
            Protected ReadOnly Property Generator() As RandomGenerator
                Get
                    Return fgenerator
				End Get
			End Property
		End Class
		Private Class RandomGeneratorFlatNoRepetitions
			Inherits RandomGeneratorSimpleNoRepetitions
			Public Sub New(ByVal aver As Integer, ByVal delta As Integer)
				MyBase.New(New RandomGeneratorFlat(aver, delta))
			End Sub
			Private Sub New(ByVal minMax As Boolean, ByVal min As Integer, ByVal max As Integer)
				MyBase.New(RandomGeneratorFlat.MinMax(min, max))
			End Sub
			Public Shared Function MinMax(ByVal min As Integer, ByVal max As Integer) As RandomGeneratorFlatNoRepetitions
				Return New RandomGeneratorFlatNoRepetitions(True, min, max)
			End Function
		End Class
		Private Class RandomGeneratorGaussNoRepetitions
			Inherits RandomGeneratorSimpleNoRepetitions
			Public Sub New(ByVal min As Integer, ByVal max As Integer)
				MyBase.New(New RandomGeneratorGauss(min, max))
			End Sub
		End Class
		Private Class MovieItemData
			Public Sub New(ByVal movieParam As MovieData, ByVal formatParam As MovieItemFormat)
				Me.Movie = movieParam
				Me.Format = formatParam
			End Sub
			Public DBItem As MovieItem
			Public Format As MovieItemFormat
			Public Movie As MovieData
			Public Sub ReturnMovieItem()
				Movie.ReturnItem(Me)
			End Sub
		End Class
		Private Class MovieData
			Private random As New Random()

			Public Sub New(ByVal dbMovie As Movie)
				MyBase.New()
				Me.DBMovie = dbMovie
				For formatIndex As Integer = 0 To formats.Length - 1
					ItemsWithFormat(formatIndex) = New LinkedList(Of MovieItemData)()
				Next formatIndex
				For statusIndex As Integer = 0 To statuses.Length - 1
					ItemsWithStatus(statusIndex) = New LinkedList(Of MovieItemData)()
					For formatIndex As Integer = 0 To formats.Length - 1
						ItemsWithStatusAndFormat(statusIndex, formatIndex) = New LinkedList(Of MovieItemData)()
					Next formatIndex
				Next statusIndex
			End Sub
			Public DBMovie As Movie
			Public LostItemsCountGenerator As RandomGenerator
			Public DamageItemsCountGenerator As RandomGenerator
			Public Items As New LinkedList(Of MovieItemData)()
			Public ItemsWithFormat(formats.Length - 1) As LinkedList(Of MovieItemData)
			Public ItemsWithStatus(statuses.Length - 1) As LinkedList(Of MovieItemData)
			Public ItemsWithStatusAndFormat(statuses.Length - 1, formats.Length - 1) As LinkedList(Of MovieItemData)
			Public Function RentItem(ByVal format As MovieItemFormat, ByVal isSell As Boolean) As MovieItemData
				Dim status As MovieItemStatus
				If isSell Then
					status = MovieItemStatus.Sold
				Else
					status = MovieItemStatus.Rented
				End If
				Dim item As MovieItemData = GetActiveItem(format)
				ChangeItemStatus(item, MovieItemStatus.Active, status)
				Return item
			End Function
			Public Sub ReturnItem(ByVal item As MovieItemData)
				ChangeItemStatus(item, MovieItemStatus.Rented, MovieItemStatus.Active)
			End Sub
			Public Function LostItem() As MovieItemData
				Dim format As MovieItemFormat = formats(random.Next(formats.Length))
				Dim item As MovieItemData = GetActiveItem(format)
				ChangeItemStatus(item, MovieItemStatus.Active, MovieItemStatus.Lost)
				Return item
			End Function
			Public Function DamageItem() As MovieItemData
				Dim format As MovieItemFormat = formats(random.Next(formats.Length))
				Dim item As MovieItemData = GetActiveItem(format)
				ChangeItemStatus(item, MovieItemStatus.Active, MovieItemStatus.Damaged)
				Return item
			End Function
			Private Function GetActiveItem(ByVal format As MovieItemFormat) As MovieItemData
				Dim activeItemsWithFormat As LinkedList(Of MovieItemData) = ItemsWithStatusAndFormat(statusesIndexes(MovieItemStatus.Active), formatsIndexes(format))
				Dim item As MovieItemData
				If activeItemsWithFormat.Count <> 0 Then
					Return activeItemsWithFormat.First.Value
				End If
				item = New MovieItemData(Me, format)
				Items.AddLast(item)
				ItemsWithFormat(formatsIndexes(format)).AddLast(item)
				ItemsWithStatus(statusesIndexes(MovieItemStatus.Active)).AddLast(item)
				activeItemsWithFormat.AddLast(item)
				Return item
			End Function
			Private Sub ChangeItemStatus(ByVal item As MovieItemData, ByVal oldStatus As MovieItemStatus, ByVal newStatus As MovieItemStatus)
				ItemsWithStatus(statusesIndexes(oldStatus)).Remove(item)
				ItemsWithStatusAndFormat(statusesIndexes(oldStatus), formatsIndexes(item.Format)).Remove(item)
				ItemsWithStatus(statusesIndexes(newStatus)).AddLast(item)
				ItemsWithStatusAndFormat(statusesIndexes(newStatus), formatsIndexes(item.Format)).AddLast(item)
			End Sub
		End Class
		Private Class RentData
			Public DBRent As Rent
			Public Movie As MovieData
			Public Format As MovieItemFormat
			Public Item As MovieItemData
			Public Days As Integer
		End Class
		Private Class Point
			Public Sub New(ByVal day As Integer, ByVal time As Integer)
				MyBase.New()
				Me.Day = day
				Me.Time = time
			End Sub
			Public Day As Integer
			Public Time As Integer
			Public Rents As New List(Of RentData)()
			Public Returns As New List(Of RentData)()
			Public Sells As New List(Of RentData)()
		End Class
		Private Class LostDamageItemAction
			Public Sub New(ByVal day As Integer, ByVal time As Integer, ByVal movieParam As MovieData, ByVal damage As Boolean)
				MyBase.New()
				Me.Day = day
				Me.Time = time
                Me.Movie = movieParam
				Me.Damage = damage
			End Sub
			Public Day As Integer
			Public Time As Integer
			Public Damage As Boolean = False
			Public Movie As MovieData
			Public Item As MovieItemData
		End Class
		Private Class CustomerData
			Public DBCustomer As Customer
			Public InterPointsTermGenerator As RandomGenerator
			Public MoviesForRentCountGenerator As RandomGenerator
			Public OverdueDaysCountGenerator As RandomGenerator
			Public OverdueDaysCountLastDayGenerator As RandomGenerator
			Public MovieFormatGenerator As RandomGenerator
			Public SellsCountGenerator As RandomGenerator
			Public SellsInReceiptCountGenerator As RandomGenerator
			Public ReceiptTimeGenerator As RandomGenerator
			Public LastDayRentsCount As Integer = 2
			Public Points As New List(Of Point)()
			Public Sub New(ByVal dbCustomer As Customer)
				MyBase.New()
				Me.DBCustomer = dbCustomer
			End Sub
			Public Function GetPoint(ByVal day As Integer) As Point
				For Each point As Point In Points
					If point.Day = day Then
						Return point
					End If
				Next point
				Return Nothing
			End Function
		End Class
		Private sellingPrices As New Dictionary(Of MovieItemFormat, Decimal)()
		Private session As UnitOfWork
		Private customers() As CustomerData
		Private movies() As MovieData
		Private daysCount As Integer
		Private movieGenerator As RandomGeneratorNoRepetitions
		Private lostDamageTimeGenerator As RandomGenerator
		Private lostDamageItemActions As New List(Of LostDamageItemAction)()
		Private moviesMap As New Dictionary(Of Integer, Integer)()
		Private Shared formats() As MovieItemFormat = CType(System.Enum.GetValues(GetType(MovieItemFormat)), MovieItemFormat())
		Private Shared statuses() As MovieItemStatus = CType(System.Enum.GetValues(GetType(MovieItemStatus)), MovieItemStatus())
		Private Shared formatsIndexes As Dictionary(Of MovieItemFormat, Integer)
		Private Shared statusesIndexes As Dictionary(Of MovieItemStatus, Integer)
		Private addedItemsCountGenerators() As RandomGenerator
		Private backgroundWorker As IBackgroundWorker
		Private exceptionProcesser As IExceptionProcesser

		Public Sub New(ByVal daysCount As Integer, ByVal session As UnitOfWork, ByVal backgroundWorker As IBackgroundWorker, ByVal exceptionProcesser As IExceptionProcesser)
			If Object.Equals(formatsIndexes, Nothing) Then
				formatsIndexes = New Dictionary(Of MovieItemFormat, Integer)()
				For i As Integer = 0 To formats.Length - 1
					formatsIndexes.Add(formats(i), i)
				Next i
			End If
			If Object.Equals(statusesIndexes, Nothing) Then
				statusesIndexes = New Dictionary(Of MovieItemStatus, Integer)()
				For i As Integer = 0 To statuses.Length - 1
					statusesIndexes.Add(statuses(i), i)
				Next i
			End If
			addedItemsCountGenerators = New RandomGenerator(formats.Length - 1){}
			Me.exceptionProcesser = exceptionProcesser
			Me.session = session
			Me.daysCount = daysCount
			Me.backgroundWorker = backgroundWorker
			AddHandler backgroundWorker.DoWork, AddressOf Generate
			Me.backgroundWorker.RunWorkerAsync()
		End Sub
		Private Sub Generate(ByVal sender As Object, ByVal e As DoWorkEventArgs)
			SetPrices()
			GenerateAddedItemsCounts()
			IDGenerator.EnableFastGeneration(Me.session)
			GenerateMoviesData()
			GenerateCustomersData()
			GeneratePoints()
			GenerateRentsAndSells()
			GenerateReturns()
			GenerateLostDamageItemActions()
			GenerateItems()
			WriteHistoryToDB()
			IDGenerator.DisableFastGeneration()
			SessionHelper.CommitSession(Me.session, exceptionProcesser)
		End Sub
		Private Sub SetPrices()
			Dim category As MovieCategory = MovieCategory.GetDefaultCategory(session)
			category.GetPrice(MovieItemFormat.DVD).LateRentPrice = 1.5D
			category.GetPrice(MovieItemFormat.BlueRay).LateRentPrice = 3
			category.GetPrice(MovieItemFormat.VideoCD).LateRentPrice = 1.0D
			sellingPrices.Add(MovieItemFormat.DVD, 12.5D)
			sellingPrices.Add(MovieItemFormat.BlueRay, 22.5D)
			sellingPrices.Add(MovieItemFormat.VideoCD, 7.5D)
		End Sub
		Private Sub GenerateAddedItemsCounts()
			addedItemsCountGenerators(formatsIndexes(MovieItemFormat.DVD)) = RandomGeneratorFlat.MinMax(2, 4)
			addedItemsCountGenerators(formatsIndexes(MovieItemFormat.BlueRay)) = RandomGeneratorFlat.MinMax(2, 4)
			addedItemsCountGenerators(formatsIndexes(MovieItemFormat.VideoCD)) = RandomGeneratorFlat.MinMax(1, 2)
		End Sub
        Private Sub GenerateMoviesData()
            Dim dbMovies As New XPCollection(Of Movie)(session)
            movies = New MovieData(dbMovies.Count - 1) {}
            Dim mappedMovieGenerator As RandomGeneratorNoRepetitions = RandomGeneratorFlatNoRepetitions.MinMax(0, movies.Length - 1)
            For i As Integer = 0 To movies.Length - 1
                movies(i) = New MovieData(dbMovies(i))
                movies(i).LostItemsCountGenerator = RandomGeneratorFlat.MinMax(0, 5)
                movies(i).DamageItemsCountGenerator = RandomGeneratorFlat.MinMax(0, 5)
                Dim nextValue As Integer = mappedMovieGenerator.Next()
                moviesMap.Add(i, nextValue)
            Next i
            movieGenerator = New RandomGeneratorGaussNoRepetitions(0, movies.Length - 1)
            lostDamageTimeGenerator = RandomGeneratorFlat.MinMax(9 * 3600 + 1800, 18 * 3600 + 1800)
        End Sub
		Private Sub GenerateCustomersData()
			Dim dbCustomers As New XPCollection(Of Customer)(session)
			customers = New CustomerData(dbCustomers.Count - 1){}
			For i As Integer = 0 To customers.Length - 1
				customers(i) = New CustomerData(dbCustomers(i))
			Next i
			Dim averInterPointsTermGenerator As RandomGenerator = New RandomGeneratorFlat(4, 0)
			For Each customer As CustomerData In customers
				If customer.DBCustomer.FirstName = "Essie" Then
					customer.LastDayRentsCount = 4
					customer.OverdueDaysCountLastDayGenerator = New RandomGeneratorFiveState(-1, 4, 3, 2, 2, 1)
				Else
					customer.OverdueDaysCountLastDayGenerator = New RandomGeneratorFiveState(-1, 2, 6, 4, 3, 0)
				End If
				If Object.Equals(customer.DBCustomer.Photo, Nothing) Then
					customer.SellsCountGenerator = RandomGeneratorFlat.MinMax(3, 7)
					customer.MovieFormatGenerator = New RandomGeneratorFiveState(0, 50, 10, 40, 0, 0)
				Else
					customer.SellsCountGenerator = RandomGeneratorFlat.MinMax(10, 15)
					customer.MovieFormatGenerator = New RandomGeneratorFiveState(0, 60, 30, 10, 0, 0)
				End If
				customer.InterPointsTermGenerator = New RandomGeneratorFlat(averInterPointsTermGenerator.Next(), 3)
				customer.MoviesForRentCountGenerator = New RandomGeneratorFiveState(0, 70, 5, 20, 5, 0)
				customer.OverdueDaysCountGenerator = New RandomGeneratorFiveState(-2, 1, 2, 18, 2, 0)

				customer.SellsInReceiptCountGenerator = RandomGeneratorFlat.MinMax(1, 2)
				customer.ReceiptTimeGenerator = RandomGeneratorFlat.MinMax(9 * 3600 + 1800, 18 * 3600 + 1800)
			Next customer
		End Sub
		Private Sub GeneratePoints()
			For Each customer As CustomerData In customers
				Dim lastDay As Integer
				Dim day As Integer = 0
				Do
					lastDay = day
					day += customer.InterPointsTermGenerator.Next()
					If day >= daysCount Then
						Exit Do
					End If
					customer.Points.Add(New Point(day, customer.ReceiptTimeGenerator.Next()))
				Loop
				If daysCount - lastDay > customer.InterPointsTermGenerator.GetMax() Then
					lastDay += customer.InterPointsTermGenerator.Next() Mod (daysCount - lastDay)
					customer.Points.Add(New Point(lastDay, customer.ReceiptTimeGenerator.Next()))
				End If
			Next customer
		End Sub
		Private Sub GenerateLostDamageItemActions()
			For Each movie As MovieData In movies
				Dim lostItemsCount As Integer = movie.LostItemsCountGenerator.Next()
				For i As Integer = 0 To lostItemsCount - 1
					Dim day As Integer = random.Next(daysCount)
					lostDamageItemActions.Add(New LostDamageItemAction(day, lostDamageTimeGenerator.Next(), movie, False))
				Next i
				Dim damageItemsCount As Integer = movie.DamageItemsCountGenerator.Next()
				For i As Integer = 0 To damageItemsCount - 1
					Dim day As Integer = random.Next(daysCount)
					lostDamageItemActions.Add(New LostDamageItemAction(day, lostDamageTimeGenerator.Next(), movie, True))
				Next i
			Next movie
		End Sub
		Private Sub GenerateSell(ByVal customer As CustomerData, ByVal point As Point)
			Dim sellsInReceiptCount As Integer = customer.SellsInReceiptCountGenerator.Next()
			For k As Integer = 0 To sellsInReceiptCount - 1
				Dim sell As New RentData()
				sell.Movie = movies(moviesMap(movieGenerator.Next()))
				sell.Format = formats(customer.MovieFormatGenerator.Next())
				point.Sells.Add(sell)
			Next k
		End Sub
        Private Sub GenerateRentsAndSells()
            For Each customer As CustomerData In customers
                Dim sellsCount As Integer = customer.SellsCountGenerator.Next()
                Dim sellPoints As New Dictionary(Of Point, Boolean)()
                For i As Integer = 0 To sellsCount - 1
                    Dim point As Point = customer.Points(random.Next(customer.Points.Count - 1))
                    If (Not sellPoints.ContainsKey(point)) Then
                        sellPoints.Add(point, True)
                    End If
                Next i
                For pointIndex As Integer = 0 To customer.Points.Count - 2
                    movieGenerator.ClearRepetitions()
                    Dim point As Point = customer.Points(pointIndex)
                    Dim nextPoint As Point = customer.Points(pointIndex + 1)
                    Dim rentsCount As Integer = customer.MoviesForRentCountGenerator.Next()
                    For i As Integer = 0 To rentsCount - 1
                        Dim rent As New RentData()
                        Dim nextMovie As Integer = movieGenerator.Next()
                        Dim nextMovieMap As Integer = moviesMap(nextMovie)
                        rent.Movie = movies(nextMovieMap)
                        rent.Format = formats(customer.MovieFormatGenerator.Next())
                        rent.Days = nextPoint.Day - point.Day - customer.OverdueDaysCountGenerator.Next()
                        point.Rents.Add(rent)
                    Next i
                    If sellPoints.ContainsKey(point) Then
                        GenerateSell(customer, point)
                    End If
                Next pointIndex
                Dim lastPoint As Point = customer.Points(customer.Points.Count - 1)
                movieGenerator.ClearRepetitions()
                Dim lastDayRentsCount As Integer = customer.LastDayRentsCount + customer.MoviesForRentCountGenerator.Next()
                For i As Integer = 0 To lastDayRentsCount - 1
                    Dim rent As New RentData()
                    rent.Days = daysCount - lastPoint.Day - customer.OverdueDaysCountLastDayGenerator.Next()
                    If rent.Days < 1 Then
                        rent.Days = 1
                    End If
                    rent.Movie = movies(moviesMap(movieGenerator.Next()))
                    rent.Format = formats(customer.MovieFormatGenerator.Next())
                    lastPoint.Rents.Add(rent)
                Next i
                If sellPoints.ContainsKey(lastPoint) Then
                    GenerateSell(customer, lastPoint)
                End If
            Next customer
        End Sub
		Private Sub GenerateReturns()
			For Each customer As CustomerData In customers
				For pointIndex As Integer = 1 To customer.Points.Count - 1
					Dim point As Point = customer.Points(pointIndex)
					Dim prevPoint As Point = customer.Points(pointIndex - 1)
					For Each rent As RentData In prevPoint.Rents
						point.Returns.Add(rent)
					Next rent
				Next pointIndex
			Next customer
		End Sub
		Private Sub GenerateItems()
			For day As Integer = 0 To daysCount - 1
				For Each customer As CustomerData In customers
					For Each point As Point In customer.Points
						If point.Day <> day Then
							Continue For
						End If
						For Each rent As RentData In point.Rents
							rent.Item = rent.Movie.RentItem(rent.Format, False)
						Next rent
						For Each rent As RentData In point.Returns
							rent.Item.ReturnMovieItem()
						Next rent
						For Each sell As RentData In point.Sells
							sell.Item = sell.Movie.RentItem(sell.Format, True)
						Next sell
					Next point
				Next customer
				For Each action As LostDamageItemAction In lostDamageItemActions
					If action.Day <> day Then
						Continue For
					End If
					If action.Damage Then
						action.Item = action.Movie.DamageItem()
					Else
						action.Item = action.Movie.LostItem()
					End If
				Next action
			Next day
		End Sub
		Private Sub WriteHistoryToDB()
			Dim realTime As Boolean = VideoRentDateTime.RealTime
			VideoRentDateTime.RealTime = False
			backgroundWorker.ReportProgress(10)
			WriteItemsToDB()
			Dim percentProgress As Double = backgroundWorker.ReportedProgress
			Dim percentPerDay As Double = (70.0 - percentProgress) / daysCount
			VideoRentDateTime.AddDays(-daysCount - 1)
			For day As Integer = 0 To daysCount - 1
				VideoRentDateTime.AddDays(1)
				For Each customer As CustomerData In customers
					Dim point As Point = customer.GetPoint(day)
					If Object.Equals(point, Nothing) Then
						Continue For
					End If
					VideoRentDateTime.SetTimeOfDay(point.Time)
					Dim rentsInfo As New List(Of RentInfo)()
					For Each rent As RentData In point.Rents
						rentsInfo.Add(New RentInfo(rent.Item.DBItem, rent.Days))
					Next rent
					Dim receipt As Receipt = customer.DBCustomer.DoRent(rentsInfo)
					For Each rent As RentData In point.Rents
						For Each dbRent As Rent In receipt.Rents
							If dbRent.Item IsNot rent.Item.DBItem Then
								Continue For
							End If
							rent.DBRent = dbRent
							Exit For
						Next dbRent
					Next rent
					Dim returns As New List(Of Rent)()
					For Each rent As RentData In point.Returns
						returns.Add(rent.DBRent)
					Next rent
					customer.DBCustomer.ReturnRents(returns)
					Dim sellsInfo As New List(Of RentInfo)()
					For Each sell As RentData In point.Sells
						sellsInfo.Add(New RentInfo(sell.Item.DBItem))
					Next sell
					customer.DBCustomer.Buy(sellsInfo)
				Next customer
				For Each action As LostDamageItemAction In lostDamageItemActions
					If action.Day <> day Then
						Continue For
					End If
					VideoRentDateTime.SetTimeOfDay(action.Time)
					If action.Damage Then
						action.Item.DBItem.Status = MovieItemStatus.Damaged
					Else
						action.Item.DBItem.Status = MovieItemStatus.Lost
					End If
				Next action
				percentProgress += percentPerDay
				backgroundWorker.ReportProgress(CInt(Fix(percentProgress)))
			Next day
			backgroundWorker.ReportProgress(70)
            WriteAddedItems()
            'Dim movieItems As IList = New XPCollection(Of DevExpress.VideoRent.MovieItem)(PersistentCriteriaEvaluationBehavior.InTransaction, session, CriteriaOperator.Parse("MovieItemId = 0"))
            'Dim cnt As Integer = movieItems.Count

			SessionHelper.CommitInBackground(session, exceptionProcesser, backgroundWorker, 100)
			VideoRentDateTime.RealTime = realTime
		End Sub
		Private Sub WriteItemsToDB()
			Dim percentProgress As Double = backgroundWorker.ReportedProgress
			Dim percentPerMovie As Double = (20.0 - percentProgress) / movies.Length
			For i As Integer = 0 To movies.Length - 1
				Dim movie As MovieData = movies(i)
				For Each item As MovieItemData In movie.Items
					item.DBItem = movie.DBMovie.AddItem(item.Format, sellingPrices(item.Format))
				Next item
				percentProgress += percentPerMovie
				backgroundWorker.ReportProgress(CInt(Fix(percentProgress)))
			Next i
			backgroundWorker.ReportProgress(20)
		End Sub
		Private Sub WriteAddedItems()
			Dim dbMovies As New XPCollection(Of Movie)(session)
			Dim percentProgress As Double = backgroundWorker.ReportedProgress
			Dim percentPerMovie As Double = (75.0 - percentProgress) / dbMovies.Count
			For Each dbMovie As Movie In dbMovies
				For formatIndex As Integer = 0 To formats.Length - 1
					If Object.Equals(addedItemsCountGenerators(formatIndex), Nothing) Then
						Continue For
					End If
					Dim addedItemsCount As Integer = addedItemsCountGenerators(formatIndex).Next()
					For i As Integer = 0 To addedItemsCount - 1
						dbMovie.AddItem(formats(formatIndex), sellingPrices(formats(formatIndex)))
					Next i
				Next formatIndex
				percentProgress += percentPerMovie
				backgroundWorker.ReportProgress(CInt(Fix(percentProgress)))
			Next dbMovie
			backgroundWorker.ReportProgress(75)
		End Sub
	End Class
End Namespace
