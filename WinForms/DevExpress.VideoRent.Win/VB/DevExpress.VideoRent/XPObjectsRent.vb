Imports Microsoft.VisualBasic
Imports DevExpress.Xpo
Imports System
Imports System.ComponentModel
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo.DB
Imports System.Collections.Generic
Imports System.Drawing
Namespace DevExpress.VideoRent
    Public Interface IRentItem
        ReadOnly Property RentItem() As MovieItem
        ReadOnly Property SellItem() As MovieItem
    End Interface
    Public Class MovieInFormat
        Implements IRentItem
        Private fmovie As Movie
        Private fformat As MovieItemFormat
        Public Sub New(ByVal movie As Movie, ByVal format As MovieItemFormat)
            MyBase.New()
            Me.fmovie = movie
            Me.fformat = format
        End Sub
        Public ReadOnly Property Movie() As Movie
            Get
                Return fmovie
            End Get
        End Property
        Public ReadOnly Property Format() As MovieItemFormat
            Get
                Return fformat
            End Get
        End Property
        Public ReadOnly Property RentItem() As MovieItem Implements IRentItem.RentItem
            Get
                Dim items As New XPCollection(Of MovieItem)(Movie.Items, CriteriaOperator.Parse("Status = ? and Format = ?", MovieItemStatus.Active, Format))
                If items.Count = 0 Then
                    Return Nothing
                End If
                Return items(0)
            End Get
        End Property
        Public ReadOnly Property SellItem() As MovieItem Implements IRentItem.SellItem
            Get
                Dim items As New XPCollection(Of MovieItem)(Movie.Items, CriteriaOperator.Parse("Status = ? and AvailableForSell = ? and Format = ?", MovieItemStatus.Active, True, Format))
                If items.Count = 0 Then
                    Return Nothing
                End If
                Return items(0)
            End Get
        End Property
    End Class
    Public Class RentInfo
        Private fitem As IRentItem
        Private fdays As Integer
        Public Sub New(ByVal item As IRentItem, ByVal days As Integer)
            MyBase.New()
            Me.fitem = item
            Me.fdays = days
        End Sub
        Public Sub New(ByVal item As IRentItem)
            Me.New(item, 0)
        End Sub
        Public Sub New(ByVal movie As Movie, ByVal format As MovieItemFormat, ByVal days As Integer)
            Me.New(New MovieInFormat(movie, format), days)
        End Sub
        Public Sub New(ByVal movie As Movie, ByVal format As MovieItemFormat)
            Me.New(New MovieInFormat(movie, format))
        End Sub
        Public ReadOnly Property Item() As IRentItem
            Get
                Return fitem
            End Get
        End Property
        Public ReadOnly Property Days() As Integer
            Get
                Return fdays
            End Get
        End Property
    End Class
    Public Class MovieItem
        Inherits VideoRentBaseObject
        Implements IRentItem
        Private fmovie As Movie
        Private fstatus As MovieItemStatus
        Private fformat As MovieItemFormat
        Private fsellingPrice As Decimal
        Private favailableForSellMark As Boolean
        Private flocation As String

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal selfId As Integer)
            Me.New(session)
            Me.SelfId = selfId
        End Sub
        Public Sub New(ByVal movieParam As Movie)
            Me.New(movieParam.Session)
            Me.Movie = movieParam
        End Sub
        Public Sub New(ByVal movie As Movie, ByVal format As MovieItemFormat)
            Me.New(movie)
            Me.Format = format
        End Sub
        Public Sub New(ByVal movie As Movie, ByVal format As MovieItemFormat, ByVal sellingPrice As Decimal)
            Me.New(movie, format)
            Me.AvailableForSell = True
            Me.SellingPrice = sellingPrice
        End Sub
        Friend Sub New(ByVal movie As Movie, ByVal format As MovieItemFormat, ByVal sellingPrice As Decimal, ByVal location As String)
            Me.New(movie, format, sellingPrice)
            Me.Location = location
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
            Status = MovieItemStatus.Active
            Format = MovieItemFormat.DVD
            AvailableForSell = False
        End Sub
        <Persistent(), Indexed(Unique:=True)> _
        Public Property MovieItemId() As Integer
            Get
                Return GetPropertyValue(Of Integer)("MovieItemId")
            End Get
            Protected Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("MovieItemId", value)
            End Set
        End Property
        Protected Overrides ReadOnly Property GeneratedIdType() As String
            Get
                Return "MovieItem"
            End Get
        End Property
        Public ReadOnly Property RentItem() As MovieItem Implements IRentItem.RentItem
            Get
                If Status = MovieItemStatus.Active Then
                    Return Me
                End If
                Return Nothing
            End Get
        End Property
        Public ReadOnly Property SellItem() As MovieItem Implements IRentItem.SellItem
            Get
                If AvailableForSell AndAlso Object.Equals(Status, MovieItemStatus.Active) Then
                    Return Me
                End If
                Return Nothing
            End Get
        End Property
        <Association("Movie-Items")> _
        Public Property Movie() As Movie
            Get
                Return fmovie
            End Get
            Set(ByVal value As Movie)
                SetPropertyValue(Of Movie)("Movie", fmovie, value)
            End Set
        End Property
        Public ReadOnly Property MovieTitle() As String
            Get
                Return Movie.MovieTitle
            End Get
        End Property
        Public ReadOnly Property MovieGenre() As MovieGenre
            Get
                Return Movie.Genre
            End Get
        End Property
        Public ReadOnly Property MovieLanguage() As String
            Get
                Return Movie.Language.Name
            End Get
        End Property
        Public ReadOnly Property MoviePhoto() As Image
            Get
                Return Movie.Photo
            End Get
        End Property
        Public ReadOnly Property MovieRating() As MovieRating
            Get
                Return Movie.Rating
            End Get
        End Property
        Public ReadOnly Property MoviePlot() As String
            Get
                Return Movie.Plot
            End Get
        End Property

        <Association("Item-Rents")> _
        Public ReadOnly Property Rents() As XPCollection(Of Rent)
            Get
                Return GetCollection(Of Rent)("Rents")
            End Get
        End Property
        Public Property Status() As MovieItemStatus
            Get
                Return fstatus
            End Get
            Set(ByVal value As MovieItemStatus)
                SetPropertyValue(Of MovieItemStatus)("Status", fstatus, value)
            End Set
        End Property
        Public Property Format() As MovieItemFormat
            Get
                Return fformat
            End Get
            Set(ByVal value As MovieItemFormat)
                SetPropertyValue(Of MovieItemFormat)("Format", fformat, value)
            End Set
        End Property
        Public Property SellingPrice() As Decimal
            Get
                Return fsellingPrice
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("SellingPrice", fsellingPrice, value)
            End Set
        End Property
        <Size(SizeAttribute.Unlimited)> _
        Public Property Location() As String
            Get
                Return flocation
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Location", flocation, value)
            End Set
        End Property
        <Persistent()> _
        Protected Property AvailableForSellMark() As Boolean
            Get
                Return favailableForSellMark
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("AvailableForSellMark", favailableForSellMark, value)
            End Set
        End Property
        <NonPersistent()> _
        Public Property AvailableForSell() As Boolean
            Get
                Return AvailableForSellMark AndAlso Not Object.Equals(Status, MovieItemStatus.Sold)
            End Get
            Set(ByVal value As Boolean)
                AvailableForSellMark = value
            End Set
        End Property
        Public ReadOnly Property LastRentedOn() As Nullable(Of DateTime)
            Get
                If Rents.Count = 0 Then
                    Return Nothing
                End If
                Dim sortedRents As New XPCollection(Of Rent)(Rents)
                sortedRents.Sorting.Clear()
                sortedRents.Sorting.Add(New SortProperty("RentedOn", SortingDirection.Descending))
                Return sortedRents(0).RentedOn
            End Get
        End Property
        Public ReadOnly Property WasInRent() As Boolean
            Get
                Return Rents.Count <> 0
            End Get
        End Property
        Private Function GetCategoryPrice() As MovieCategoryPrice
            Return Movie.Category.GetPrice(Format)
        End Function
        Public Function CalcRentMaxDaysCount() As Integer ' return value (-1) stand for infinity
            If (Not AvailableForSell) Then
                Return -1
            End If
            Return GetCategoryPrice().CalcRentDaysCountForLessPrice(SellingPrice)
        End Function
        Public Function CalcOnOrderPrice(ByVal days As Integer) As Decimal
            Return GetCategoryPrice().CalcOnOrderPrice(days)
        End Function
        Public Shared Function CreateFewItems(ByVal pattern As MovieItem, ByVal count As Integer) As XPCollection(Of MovieItem)
            Dim ret As New XPCollection(Of MovieItem)(pattern.Session, False)
            For i As Integer = 0 To count - 1
                Dim item As New MovieItem(pattern.Movie, pattern.Format)
                item.AvailableForSell = pattern.AvailableForSell
                item.SellingPrice = pattern.SellingPrice
                ret.Add(item)
            Next i
            Return ret
        End Function
        Public Class CountInfo
            Private formats() As MovieItemFormat
            Private fstatuses() As MovieItemStatus
            Private flastRentedOn As Nullable(Of DateTime)
            Private fwithFormatAndStatus(,) As Integer
            Private fwithFormatForSell() As Integer
            Private fwithStatus() As Integer
            Private fwithFormat() As Integer
            Private fforSell As Integer
            Private ftotal As Integer
            Public Sub New()
                MyBase.New()
                formats = CType(System.Enum.GetValues(GetType(MovieItemFormat)), MovieItemFormat())
                fstatuses = CType(System.Enum.GetValues(GetType(MovieItemStatus)), MovieItemStatus())
                flastRentedOn = Nothing
                fwithFormatAndStatus = New Integer(formats.Length - 1, fstatuses.Length - 1) {}
                fwithFormatForSell = New Integer(formats.Length - 1) {}
                fwithStatus = New Integer(fstatuses.Length - 1) {}
                fwithFormat = New Integer(formats.Length - 1) {}
            End Sub
            Public Sub New(ByVal items As XPCollection(Of MovieItem))
                Me.New()
                For Each item As MovieItem In items
                    If (Not Object.Equals(item.LastRentedOn, Nothing)) AndAlso (Object.Equals(Me.flastRentedOn, Nothing) OrElse Me.flastRentedOn.Value < Me.flastRentedOn.Value) Then
                        Me.flastRentedOn = item.LastRentedOn
                    End If
                    Dim formatIndex As Integer = Me.FormatIndex(item.Format)
                    Me.fwithFormatAndStatus(formatIndex, StatusIndex(item.Status)) += 1
                    If item.AvailableForSell Then
                        Me.fwithFormatForSell(formatIndex) += 1
                    End If
                Next item
                ftotal = 0
                For statusIndex As Integer = 0 To fstatuses.Length - 1
                    fwithStatus(statusIndex) = 0
                    For formatIndex As Integer = 0 To formats.Length - 1
                        fwithStatus(statusIndex) += fwithFormatAndStatus(formatIndex, statusIndex)
                    Next formatIndex
                    ftotal += fwithStatus(statusIndex)
                Next statusIndex
                fforSell = 0
                For formatIndex As Integer = 0 To formats.Length - 1
                    fforSell += fwithFormatForSell(formatIndex)
                    fwithFormat(formatIndex) = 0
                    For statusIndex As Integer = 0 To fstatuses.Length - 1
                        fwithFormat(formatIndex) += fwithFormatAndStatus(formatIndex, statusIndex)
                    Next statusIndex
                Next formatIndex
            End Sub
            Public ReadOnly Property Statuses() As MovieItemStatus()
                Get
                    Return fstatuses
                End Get
            End Property
            Public ReadOnly Property LastRentedOn() As Nullable(Of DateTime)
                Get
                    Return flastRentedOn
                End Get
            End Property
            Public ReadOnly Property WithFormatAndStatus() As Integer(,)
                Get
                    Return fwithFormatAndStatus
                End Get
            End Property
            Public ReadOnly Property WithFormatForSell() As Integer()
                Get
                    Return fwithFormatForSell
                End Get
            End Property
            Public ReadOnly Property WithStatus() As Integer()
                Get
                    Return fwithStatus
                End Get
            End Property
            Public ReadOnly Property WithFormat() As Integer()
                Get
                    Return fwithFormat
                End Get
            End Property
            Public ReadOnly Property ForSell() As Integer
                Get
                    Return fforSell
                End Get
            End Property
            Public ReadOnly Property Total() As Integer
                Get
                    Return ftotal
                End Get
            End Property
            Public Function FormatIndex(ByVal format As MovieItemFormat) As Integer
                Dim ret As Integer = -1
                For index As Integer = 0 To formats.Length - 1
                    If formats(index) <> format Then
                        Continue For
                    End If
                    ret = index
                    Exit For
                Next index
                Return ret
            End Function
            Public Function StatusIndex(ByVal status As MovieItemStatus) As Integer
                Dim ret As Integer = -1
                For index As Integer = 0 To fstatuses.Length - 1
                    If fstatuses(index) <> status Then
                        Continue For
                    End If
                    ret = index
                    Exit For
                Next index
                Return ret
            End Function
        End Class
        Public Overrides ReadOnly Property AllowDelete() As Boolean
            Get
                Return (Not Object.Equals(Status, MovieItemStatus.Rented)) AndAlso Not Object.Equals(Status, MovieItemStatus.Sold) AndAlso Not WasInRent()
            End Get
        End Property
    End Class
    Public Class MovieCategory
        Inherits VideoRentBaseObject
        Public Shared Function GetDefaultCategory(ByVal session As Session) As MovieCategory
            Return session.FindObject(Of MovieCategory)(CriteriaOperator.Parse("IsDefault = ?", True))
        End Function

        Private fname As String
        Private fisDefault As Boolean

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal name As String)
            MyBase.New(session)
            Me.Name = name
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
            IsDefault = False
            For Each format As MovieItemFormat In System.Enum.GetValues(GetType(MovieItemFormat))
                Dim TempMovieCategoryPrice As MovieCategoryPrice = New MovieCategoryPrice(Me, format)
            Next format
        End Sub
        Protected Overrides Sub OnDeleting()
            MyBase.OnDeleting()
            Dim movies As New List(Of Movie)(Me.Movies)
            For Each movie As Movie In movies
                movie.Category = MovieCategory.GetDefaultCategory(Session)
            Next movie
        End Sub
        <Indexed(Unique:=True)> _
        Public Property Name() As String
            Get
                Return fname
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Name", fname, value)
            End Set
        End Property
        <Association("Category-Movies")> _
        Public ReadOnly Property Movies() As XPCollection(Of Movie)
            Get
                Return GetCollection(Of Movie)("Movies")
            End Get
        End Property
        <Association("Category-Prices"), Aggregated()> _
        Public ReadOnly Property Prices() As XPCollection(Of MovieCategoryPrice)
            Get
                Return GetCollection(Of MovieCategoryPrice)("Prices")
            End Get
        End Property
        <Browsable(False)> _
        Public Property IsDefault() As Boolean
            Get
                Return fisDefault
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("IsDefault", fisDefault, value)
            End Set
        End Property
        Public Function GetPrice(ByVal format As MovieItemFormat) As MovieCategoryPrice
            Dim ret As MovieCategoryPrice = Nothing
            Prices.Filter = CriteriaOperator.Parse("Format = ?", format)
            If Prices.Count <> 0 Then
                ret = Prices(0)
            End If
            Prices.Filter = Nothing
            Return ret
        End Function
    End Class
    Public Class MovieCategoryPrice
        Inherits VideoRentBaseObject
        Public Shared TermsRentCount As Integer = 7
        Private fformat As MovieItemFormat
        Private fcategory As MovieCategory
        Private fdefaultRentDays As Integer
        Private daysRentPrice(TermsRentCount) As Decimal ' daysRentPrice[0] - Late fee per day


        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal category As MovieCategory, ByVal format As MovieItemFormat)
            Me.New(category.Session)
            Me.Category = category
            Me.Format = format
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
            Dim daysRentPrice(TermsRentCount) As Decimal
            Me.daysRentPrice = daysRentPrice
            Format = MovieItemFormat.DVD
            DefaultRentDays = 1
            LateRentPrice = 1
        End Sub
        Public Property DefaultRentDays() As Integer
            Get
                Return fdefaultRentDays
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("DefaultRentDays", fdefaultRentDays, value)
            End Set
        End Property
        Public ReadOnly Property DefaultPrice() As Decimal
            Get
                Return CalcOnOrderPrice(DefaultRentDays) / DefaultRentDays
            End Get
        End Property
        <Association("Category-Prices"), Indexed("Format", Unique:=True)> _
        Public Property Category() As MovieCategory
            Get
                Return fcategory
            End Get
            Set(ByVal value As MovieCategory)
                SetPropertyValue(Of MovieCategory)("Category", fcategory, value)
            End Set
        End Property
        Public Property Format() As MovieItemFormat
            Get
                Return fformat
            End Get
            Set(ByVal value As MovieItemFormat)
                SetPropertyValue(Of MovieItemFormat)("Format", fformat, value)
            End Set
        End Property
        Public Property LateRentPrice() As Decimal
            Get
                Return GetDaysRentPrice(0)
            End Get
            Set(ByVal value As Decimal)
                SetDaysRentPrice(0, value)
            End Set
        End Property
        Public Property Days1RentPrice() As Decimal
            Get
                Return GetDaysRentPrice(1)
            End Get
            Set(ByVal value As Decimal)
                SetDaysRentPrice(1, value)
            End Set
        End Property
        Public Property Days2RentPrice() As Decimal
            Get
                Return GetDaysRentPrice(2)
            End Get
            Set(ByVal value As Decimal)
                SetDaysRentPrice(2, value)
            End Set
        End Property
        Public Property Days3RentPrice() As Decimal
            Get
                Return GetDaysRentPrice(3)
            End Get
            Set(ByVal value As Decimal)
                SetDaysRentPrice(3, value)
            End Set
        End Property
        Public Property Days4RentPrice() As Decimal
            Get
                Return GetDaysRentPrice(4)
            End Get
            Set(ByVal value As Decimal)
                SetDaysRentPrice(4, value)
            End Set
        End Property
        Public Property Days5RentPrice() As Decimal
            Get
                Return GetDaysRentPrice(5)
            End Get
            Set(ByVal value As Decimal)
                SetDaysRentPrice(5, value)
            End Set
        End Property
        Public Property Days6RentPrice() As Decimal
            Get
                Return GetDaysRentPrice(6)
            End Get
            Set(ByVal value As Decimal)
                SetDaysRentPrice(6, value)
            End Set
        End Property
        Public Property Days7RentPrice() As Decimal
            Get
                Return GetDaysRentPrice(7)
            End Get
            Set(ByVal value As Decimal)
                SetDaysRentPrice(7, value)
            End Set
        End Property
        Public Function GetDaysRentPrice(ByVal index As Integer) As Decimal
            Return daysRentPrice(index)
        End Function
        Public Sub SetDaysRentPrice(ByVal index As Integer, ByVal value As Decimal)
            If index = 0 Then
                SetPropertyValue(Of Decimal)("LateRentPrice", daysRentPrice(0), value)
            Else
                SetPropertyValue(Of Decimal)(String.Format("Days{0}RentPrice", index), daysRentPrice(index), value)
            End If
        End Sub
        Public Function CalcOnOrderPrice(ByVal days As Integer) As Decimal
            If days < 1 Then
                Throw New ArgumentOutOfRangeException("days")
            End If
            Dim normalDays As Integer
            If days > TermsRentCount Then
                normalDays = TermsRentCount
            Else
                normalDays = days
            End If
            Dim priceDays As Integer = normalDays
            Do While GetDaysRentPrice(priceDays) = 0 AndAlso priceDays > 0
                priceDays -= 1
            Loop
            Dim onOrderPrice As Decimal = normalDays * GetDaysRentPrice(priceDays)
            If days > TermsRentCount Then
                onOrderPrice += (days - TermsRentCount) * LateRentPrice
            End If
            Return onOrderPrice
        End Function
        Public Function CalcRentDaysCountForLessPrice(ByVal price As Decimal) As Integer
            Dim priceNormalDays As Decimal = CalcOnOrderPrice(TermsRentCount)
            If price > priceNormalDays Then
                Return TermsRentCount + CInt(Fix(Math.Ceiling((price - priceNormalDays) / LateRentPrice))) - 1
            End If
            Dim daysCount As Integer = TermsRentCount
            Do While daysCount > 0 AndAlso CalcOnOrderPrice(daysCount) >= price
                daysCount -= 1
            Loop
            Return daysCount
        End Function
    End Class
    Public Class Rent
        Inherits VideoRentBaseObject
        Private fitem As MovieItem
        Private fdays As Integer
        Private freturnedOn As Nullable(Of DateTime)
        Private freceipt As Receipt
        Private freceiptOverdue As Receipt
        Private fpayment As Decimal
        Private foverduePayment As Decimal

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal selfId As Integer)
            Me.New(session)
            Me.SelfId = selfId
        End Sub
        Public Sub New(ByVal receipt As Receipt, ByVal item As MovieItem)
            Me.New(receipt, item, 0)
        End Sub
        Public Sub New(ByVal receiptParam As Receipt, ByVal item As MovieItem, ByVal days As Integer)
            Me.New(receiptParam.Session)
            If Object.Equals(receiptParam, Nothing) Then
                Throw New ArgumentNullException("Receipt")
            End If
            If Object.Equals(item, Nothing) Then
                Throw New ArgumentNullException("Item")
            End If
            If item.Status <> MovieItemStatus.Active Then
                Throw New ArgumentException("Item is not active")
            End If
            Me.Receipt = receiptParam
            Me.Item = item
            If receiptParam.Type = ReceiptType.Purchases Then
                Me.Item.Status = MovieItemStatus.Sold
                Me.Item.AvailableForSell = False
                Me.Days = 0
            Else
                Me.Item.Status = MovieItemStatus.Rented
                If days <> 0 Then
                    Me.Days = days
                Else
                    Me.Days = item.Movie.Category.GetPrice(item.Format).DefaultRentDays
                End If
            End If
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
            Days = 1
        End Sub
        <Persistent(), Indexed(Unique:=True)> _
        Public Property RentId() As Integer
            Get
                Return GetPropertyValue(Of Integer)("RentId")
            End Get
            Protected Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RentId", value)
            End Set
        End Property
        Protected Overrides ReadOnly Property GeneratedIdType() As String
            Get
                Return "Rent"
            End Get
        End Property
        <Persistent(), Association("Item-Rents")> _
        Public Property Item() As MovieItem
            Get
                Return fitem
            End Get
            Protected Set(ByVal value As MovieItem)
                SetPropertyValue(Of MovieItem)("Item", fitem, value)
            End Set
        End Property
        Public Property Days() As Integer
            Get
                Return fdays
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("Days", fdays, value)
            End Set
        End Property
        '[Indexed(Unique = false)]
        Public Property ReturnedOn() As Nullable(Of DateTime)
            Get
                Return freturnedOn
            End Get
            Set(ByVal value As Nullable(Of DateTime))
                SetPropertyValue(Of Nullable(Of DateTime))("ReturnedOn", freturnedOn, value)
            End Set
        End Property
        <Indexed(Unique:=False)> _
        Public ReadOnly Property ExpectedOn() As DateTime
            Get
                If ReturnedOn.HasValue Then
                    Return ReturnedOn.Value
                Else
                    Return ClearedReturnedOn
                End If
            End Get
        End Property
        Public ReadOnly Property ClearedReturnedOn() As DateTime
            Get
                Return RentedOn.AddDays(Days)
            End Get
        End Property
        Public ReadOnly Property ClearedReturnedOnDate() As DateTime
            Get
                Return ClearedReturnedOn.Date
            End Get
        End Property
        Public ReadOnly Property Overdue() As Integer
            Get
                Dim [date] As DateTime
                If ReturnedOn.HasValue Then
                    [date] = ReturnedOn.Value
                Else
                    [date] = DevExpress.VideoRent.Helpers.VideoRentDateTime.Now
                End If
                Return CInt(Fix((CDbl([date].Ticks) - RentedOn.Ticks) / TimeSpan.TicksPerDay - Days))
            End Get
        End Property
        Public ReadOnly Property ActiveType() As ActiveRentType
            Get
                If (Not Active) Then
                    Return ActiveRentType.None
                End If
                If Overdue > 0 Then
                    Return ActiveRentType.Overdue
                End If
                If Overdue = 0 Then
                    Return ActiveRentType.Today
                End If
                Return ActiveRentType.Active
            End Get
        End Property
        Public ReadOnly Property IsOverdue() As Boolean
            Get
                Return Overdue > 0
            End Get
        End Property
        Public ReadOnly Property Active() As Boolean
            Get
                Return Object.Equals(ReturnedOn, Nothing) AndAlso Object.Equals(Item.Status, MovieItemStatus.Rented)
            End Get
        End Property
        Public ReadOnly Property Customer() As Customer
            Get
                Return Receipt.Customer
            End Get
        End Property
        <Indexed(Unique:=False), PersistentAlias("Receipt.Date")> _
        Public ReadOnly Property RentedOn() As DateTime
            Get
                Return Receipt.Date
            End Get
        End Property
        Public Property Payment() As Decimal
            Get
                Return fpayment
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("Payment", fpayment, value)
            End Set
        End Property
        Public Property OverduePayment() As Decimal
            Get
                Return foverduePayment
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("OverduePayment", foverduePayment, value)
            End Set
        End Property
        Public ReadOnly Property MovieTitle() As String
            Get
                Return Item.MovieTitle
            End Get
        End Property
        Public ReadOnly Property MovieGenre() As MovieGenre
            Get
                Return Item.MovieGenre
            End Get
        End Property
        Public ReadOnly Property MovieLanguage() As String
            Get
                Return Item.MovieLanguage
            End Get
        End Property
        Public ReadOnly Property MoviePhoto() As Image
            Get
                Return Item.MoviePhoto
            End Get
        End Property
        Public ReadOnly Property MovieRating() As MovieRating
            Get
                Return Item.MovieRating
            End Get
        End Property
        Public ReadOnly Property MoviePlot() As String
            Get
                Return Item.MoviePlot
            End Get
        End Property
        Public ReadOnly Property Movie() As Movie
            Get
                Return Item.Movie
            End Get
        End Property

        Public ReadOnly Property ItemFormat() As MovieItemFormat
            Get
                If Object.Equals(Item, Nothing) Then
                    Return MovieItemFormat.DVD
                End If
                Return Item.Format
            End Get
        End Property
        Public ReadOnly Property MovieInfo() As String
            Get
                Return String.Format("{0} - {1}", MovieTitle, ItemFormat)
            End Get
        End Property
        <Persistent(), Association("Receipt-Rents")> _
        Public Property Receipt() As Receipt
            Get
                Return freceipt
            End Get
            Protected Set(ByVal value As Receipt)
                SetPropertyValue(Of Receipt)("Receipt", freceipt, value)
            End Set
        End Property
        Public ReadOnly Property ReceiptType() As ReceiptType
            Get
                Return Receipt.Type
            End Get
        End Property
        <Association("ReceiptOverdue-Rents")> _
        Public Property ReceiptOverdue() As Receipt
            Get
                Return freceiptOverdue
            End Get
            Set(ByVal value As Receipt)
                SetPropertyValue(Of Receipt)("ReceiptOverdue", freceiptOverdue, value)
            End Set
        End Property
        Public Sub [Return]()
            If Item.Status <> MovieItemStatus.Rented Then
                Throw New Exception("Item is not in rent")
            End If
            ReturnedOn = DevExpress.VideoRent.Helpers.VideoRentDateTime.Now
            Item.Status = MovieItemStatus.Active
        End Sub
        Public Function CalcPayment() As Decimal
            If Receipt.Type = ReceiptType.Purchases Then
                Payment = Item.SellingPrice
            Else
                Payment = Item.CalcOnOrderPrice(Days)
            End If
            Return Payment
        End Function
        Public Function CalcOverduePayment() As Decimal
            OverduePayment = Item.CalcOnOrderPrice(Days + Overdue) - Payment
            Return OverduePayment
        End Function
    End Class
    Public Class Receipt
        Inherits VideoRentBaseObject
        Private fcustomer As Customer
        Private fdate As DateTime
        Private ftype As ReceiptType
        Private fpayment As Decimal
        Private fdiscount As Decimal
        Private fclosed As Boolean

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal selfId As Integer)
            Me.New(session)
            Me.SelfId = selfId
        End Sub
        Public Sub New(ByVal customerParam As Customer, ByVal type As ReceiptType)
            MyBase.New(customerParam.Session)
            If Object.Equals(customerParam, Nothing) Then
                Throw New ArgumentNullException("Customer")
            End If
            Me.Customer = customerParam
            Me.Type = type
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
            [Date] = VideoRent.Helpers.VideoRentDateTime.Now
        End Sub
        <Persistent(), Indexed(Unique:=True)> _
        Public Property ReceiptId() As Integer
            Get
                Return GetPropertyValue(Of Integer)("ReceiptId")
            End Get
            Protected Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ReceiptId", value)
            End Set
        End Property
        Protected Overrides ReadOnly Property GeneratedIdType() As String
            Get
                Return "Receipt"
            End Get
        End Property
        <Persistent(), Association("Customer-Receipts")> _
        Public Property Customer() As Customer
            Get
                Return fcustomer
            End Get
            Protected Set(ByVal value As Customer)
                SetPropertyValue(Of Customer)("Customer", fcustomer, value)
            End Set
        End Property
        <Indexed(Unique:=False)> _
        Public Property [Date]() As DateTime
            Get
                Return fdate
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("Date", fdate, value)
            End Set
        End Property
        <Persistent()> _
        Public Property Type() As ReceiptType
            Get
                Return ftype
            End Get
            Protected Set(ByVal value As ReceiptType)
                SetPropertyValue(Of ReceiptType)("Type", ftype, value)
            End Set
        End Property
        Public Property Payment() As Decimal
            Get
                Return fpayment
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("Payment", fpayment, value)
            End Set
        End Property
        Public Property Discount() As Decimal
            Get
                Return fdiscount
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("Discount", fdiscount, value)
            End Set
        End Property
        <Persistent()> _
        Public Property Closed() As Boolean
            Get
                Return fclosed
            End Get
            Protected Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("Closed", fclosed, value)
            End Set
        End Property
        <Association("Receipt-Rents")> _
        Public ReadOnly Property Rents() As XPCollection(Of Rent) 'Type = Rent or Sale
            Get
                Return GetCollection(Of Rent)("Rents")
            End Get
        End Property
        <Association("ReceiptOverdue-Rents")> _
        Public ReadOnly Property OverdueRents() As XPCollection(Of Rent) 'Type = Overdue
            Get
                Return GetCollection(Of Rent)("OverdueRents")
            End Get
        End Property
        Public Sub CalcPayment()
            If Type = ReceiptType.LateFees Then
                CalcOverduePayment()
            Else
                CalcOrdinarPayment()
            End If
            Customer.CalcDiscount()
        End Sub
        Private Sub CalcOrdinarPayment()
            Dim payment As Decimal = 0
            For Each rent As Rent In Rents
                payment += rent.CalcPayment()
            Next rent
            CalcDiscount(payment)
        End Sub
        Private Sub CalcOverduePayment()
            Dim payment As Decimal = 0
            For Each rent As Rent In OverdueRents
                payment += rent.CalcOverduePayment()
            Next rent
            CalcDiscount(payment)
        End Sub
        Private Sub CalcDiscount(ByVal payment As Decimal)
            Discount = Math.Round(payment * Customer.Discount * 100) / 100
            Me.Payment = payment - Discount
        End Sub
    End Class
End Namespace
