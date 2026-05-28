Imports Microsoft.VisualBasic
Imports DevExpress.Xpo
Imports System.Drawing
Imports System
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo.DB
Imports System.Collections
Namespace DevExpress.VideoRent
	Public Class Movie
		Inherits VideoRentBaseObject
		Implements IRentItem, IComparable
        Private fcategory As MovieCategory
        Private ftitle As String
        Private fgenre As MovieGenre
        Private frating As MovieRating
        Private freleaseDate As Nullable(Of DateTime)
        Private frunTime As Nullable(Of TimeSpan)
        Private fisColor As Boolean
        Private fphoto As Image
        Private ftagline As String
        Private fplot As String
        Private fawards As String
        Private fwebSite As String
        Private faspectRatio As String
        Private flanguage As Language

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal selfId As Integer)
            Me.New(session)
            Me.SelfId = selfId
        End Sub
        Public Sub New(ByVal session As Session, ByVal selfId As Integer, ByVal title As String)
            Me.New(session, selfId)
            Me.Title = title
        End Sub
        Public Sub New(ByVal session As Session, ByVal title As String)
            Me.New(session)
            Me.Title = title
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
            IsColor = True
            Category = MovieCategory.GetDefaultCategory(Session)
        End Sub
        Protected Overrides Sub OnSaving()
            MyBase.OnSaving()
            If (Not IsDeleted) Then
                If Object.Equals(Category, Nothing) Then
                    Category = MovieCategory.GetDefaultCategory(Session)
                End If
                If String.IsNullOrEmpty(Title) Then
                    Throw New Exception("Title can't be null")
                End If
            End If
        End Sub
        <Persistent(), Indexed(Unique:=True)> _
        Public Property MovieId() As Integer
            Get
                Return GetPropertyValue(Of Integer)("MovieId")
            End Get
            Protected Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("MovieId", value)
            End Set
        End Property
        Protected Overrides ReadOnly Property GeneratedIdType() As String
            Get
                Return "Movie"
            End Get
        End Property
        Public ReadOnly Property RentItem() As MovieItem Implements IRentItem.RentItem
            Get
                Dim items As XPCollection(Of MovieItem) = GetActiveItems()
                If items.Count = 0 Then
                    Return Nothing
                End If
                Return items(0)
            End Get
        End Property
        Public ReadOnly Property SellItem() As MovieItem Implements IRentItem.SellItem
            Get
                Dim items As XPCollection(Of MovieItem) = GetActiveAvailableForSellItems()
                If items.Count = 0 Then
                    Return Nothing
                End If
                Return items(0)
            End Get
        End Property
        <Association("Movie-Items"), Aggregated()> _
        Public ReadOnly Property Items() As XPCollection(Of MovieItem)
            Get
                Return GetCollection(Of MovieItem)("Items")
            End Get
        End Property
        <Association("Category-Movies")> _
        Public Property Category() As MovieCategory
            Get
                Return fcategory
            End Get
            Set(ByVal value As MovieCategory)
                SetPropertyValue(Of MovieCategory)("Category", fcategory, value)
            End Set
        End Property
        <Size(SizeAttribute.Unlimited)> _
        Public Property Title() As String
            Get
                Return ftitle
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Title", ftitle, value)
            End Set
        End Property
        Public ReadOnly Property MovieTitle() As String
            Get
                If ReleaseDate.HasValue Then
                    Return String.Format("{0} ({1})", Title, ReleaseDate.Value.Year.ToString())
                Else
                    Return String.Format("{0} ({1})", Title, "?")
                End If
            End Get
        End Property
        <Size(SizeAttribute.Unlimited)> _
        Public Property Tagline() As String
            Get
                Return ftagline
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Tagline", ftagline, value)
            End Set
        End Property
        <Size(SizeAttribute.Unlimited)> _
        Public Property Plot() As String
            Get
                Return fplot
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Plot", fplot, value)
            End Set
        End Property
        Public Property Awards() As String
            Get
                Return fawards
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Awards", fawards, value)
            End Set
        End Property
        <Association("Movie-MovieArtist"), Aggregated()> _
        Public ReadOnly Property Artists() As XPCollection(Of MovieArtist)
            Get
                Return GetCollection(Of MovieArtist)("Artists")
            End Get
        End Property
        Public Property Rating() As MovieRating
            Get
                Return frating
            End Get
            Set(ByVal value As MovieRating)
                SetPropertyValue(Of MovieRating)("Rating", frating, value)
            End Set
        End Property
        Public Property Genre() As MovieGenre
            Get
                Return fgenre
            End Get
            Set(ByVal value As MovieGenre)
                SetPropertyValue(Of MovieGenre)("Genre", fgenre, value)
            End Set
        End Property
        Public Property ReleaseDate() As Nullable(Of DateTime)
            Get
                Return freleaseDate
            End Get
            Set(ByVal value As Nullable(Of DateTime))
                SetPropertyValue(Of Nullable(Of DateTime))("ReleaseDate", freleaseDate, value)
            End Set
        End Property
        Public Property RunTime() As Nullable(Of TimeSpan)
            Get
                Return frunTime
            End Get
            Set(ByVal value As Nullable(Of TimeSpan))
                SetPropertyValue(Of Nullable(Of TimeSpan))("RunTime", frunTime, value)
            End Set
        End Property
        Public Property IsColor() As Boolean
            Get
                Return fisColor
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("IsColor", fisColor, value)
            End Set
        End Property
        <DevExpress.Xpo.ValueConverter(GetType(DevExpress.Xpo.Metadata.ImageValueConverter))> _
        Public Property Photo() As Image
            Get
                Return fphoto
            End Get
            Set(ByVal value As Image)
                SetPropertyValue(Of Image)("Photo", fphoto, value)
            End Set
        End Property
        Public ReadOnly Property PhotoExist() As Image
            Get
                If Object.Equals(Photo, Nothing) Then
                    Return ReferenceImages.UnknownMovie
                End If
                Return Photo
            End Get
        End Property
        Public Property WebSite() As String
            Get
                Return fwebSite
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("WebSite", fwebSite, value)
            End Set
        End Property
        Public Property AspectRatio() As String
            Get
                Return faspectRatio
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("AspectRatio", faspectRatio, value)
            End Set
        End Property
        <Association("Movies-Language")> _
        Public Property Language() As Language
            Get
                Return flanguage
            End Get
            Set(ByVal value As Language)
                SetPropertyValue(Of Language)("Language", flanguage, value)
            End Set
        End Property
        <Association("Movie-MovieCompany"), Aggregated()> _
        Public ReadOnly Property Companies() As XPCollection(Of MovieCompany)
            Get
                Return GetCollection(Of MovieCompany)("Companies")
            End Get
        End Property
        <Association("Movie-MoviePictures"), Aggregated()> _
        Public ReadOnly Property Pictures() As XPCollection(Of MoviePicture)
            Get
                Return GetCollection(Of MoviePicture)("Pictures")
            End Get
        End Property
        Public ReadOnly Property Director() As MovieArtist
            Get
                Dim directorLine As MovieArtistLine = MovieArtistLine.GetDirector(Session)
                If Object.Equals(directorLine, Nothing) Then
                    Return Nothing
                End If
                Dim movieDirector As MovieArtist = Session.FindObject(Of MovieArtist)(CriteriaOperator.Parse("Movie = ? and Line = ?", Me, directorLine))
                If Object.Equals(movieDirector, Nothing) Then
                    Return Nothing
                End If
                Return movieDirector
            End Get
        End Property
        Public ReadOnly Property Directors() As String
            Get
                Dim ret As New ArrayList()
                For Each director As MovieArtist In Artists
                    If (Not Object.Equals(director.Artist, Nothing)) AndAlso ((Not Object.Equals(director.Line, Nothing))) AndAlso director.Line.Name = ReferenceData.DirectorString Then
                        ret.Add(director.Artist.FullName)
                    End If
                Next director
                Return StringHelper.GetStringByArrayList(ret)
            End Get
        End Property
        Public ReadOnly Property PicturesCount() As Integer
            Get
                Return Pictures.Count
            End Get
        End Property
        <Association("Movies-Countries")> _
        Public ReadOnly Property Countries() As XPCollection(Of Country)
            Get
                Return GetCollection(Of Country)("Countries")
            End Get
        End Property
        <NonPersistent()> _
        Public Property CountriesAsString() As String
            Get
                Dim countries As New XPCollection(Of Country)(Me.Countries)
                countries.Sorting.Add(New SortProperty("[Acronym]", SortingDirection.Ascending))
                Dim ret As String = String.Empty
                For Each country As Country In countries
                    ret &= ", " & country.Acronym
                Next country
                If ret.Length <> 0 Then
                    ret = ret.Substring(2, ret.Length - 2)
                End If
                Return ret
            End Get
            Set(ByVal value As String)
                Do While Countries.Count > 0
                    Countries.Remove(Countries(0))
                Loop
                Dim acronyms() As String = value.Split(New Char() {","c, " "c})
                For Each acronym As String In acronyms
                    If acronym.Length = 0 Then
                        Continue For
                    End If
                    Dim country As Country = Session.FindObject(Of Country)(CriteriaOperator.Parse("Acronym = ?", acronym))
                    If Object.Equals(country, Nothing) Then
                        Throw New ArgumentException()
                    End If
                    Countries.Add(country)
                Next acronym
            End Set
        End Property
        Public ReadOnly Property Rents() As XPCollection(Of Rent)
            Get
                Dim ret As New XPCollection(Of Rent)(Session, False)
                For Each item As MovieItem In Items
                    For Each rent As Rent In item.Rents
                        ret.Add(rent)
                    Next rent
                Next item
                Return ret
            End Get
        End Property
        Public Function AddPicture(ByVal picture As Image) As MoviePicture
            Return New MoviePicture(Me, picture)
        End Function
        Public Function AddPicture(ByVal picture As Image, ByVal description As String) As MoviePicture
            Return New MoviePicture(Me, picture, description)
        End Function
        Public Function GetActiveItems() As XPCollection(Of MovieItem)
            Return New XPCollection(Of MovieItem)(Items, CriteriaOperator.Parse("Status = ?", MovieItemStatus.Active))
        End Function
        Public Function GetActiveAvailableForSellItems() As XPCollection(Of MovieItem)
            Return New XPCollection(Of MovieItem)(Items, CriteriaOperator.Parse("Status = ? and AvailableForSell = ?", MovieItemStatus.Active, True))
        End Function
        Public Function AddItem() As MovieItem
            Return New MovieItem(Me)
        End Function
        Friend Function AddItem(ByVal format As MovieItemFormat, ByVal sellPrice As Decimal) As MovieItem
            Return New MovieItem(Me, format, sellPrice, String.Format("Shelf #{0}", Me.MovieId Mod ReferenceData.ShelvesCount + 1))
        End Function
        Public ReadOnly Property IsAvailableForRent() As Boolean
            Get
                Return GetActiveItems().Count > 0
            End Get
        End Property
        Public Sub AddArtist(ByVal artist As Artist, ByVal line As MovieArtistLine)
            AddArtist(artist, line, String.Empty)
        End Sub
        Public Sub AddArtist(ByVal artist As Artist, ByVal line As MovieArtistLine, ByVal description As String)
            Dim TempMovieArtist As MovieArtist = New MovieArtist(Me, artist, line, description)
        End Sub
        Public Sub AddCompany(ByVal company As Company)
            AddCompany(company, String.Empty)
        End Sub
        Public Sub AddCompany(ByVal company As Company, ByVal description As String)
            Dim TempMovieCompany As MovieCompany = New MovieCompany(Me, company, description)
        End Sub
        Public Overrides ReadOnly Property AllowDelete() As Boolean
            Get
                Return Object.Equals(Session.FindObject(Of MovieItem)(CriteriaOperator.Parse("Movie = ? and AllowDelete = ?", Me, False)), Nothing)
            End Get
        End Property
        Public Overrides Function ToString() As String
            Return MovieTitle
        End Function
        Public Function GetMovieInfoHtml() As String
            Return String.Format("<b>{0}</b>" & Constants.vbCrLf & "<i>{2:D}</i>" & Constants.vbCr & Constants.vbCrLf & "{1}", Title, Plot, ReleaseDate)
        End Function
        Public Function GetFullMovieInfoHtml() As String
            Dim ret As String
            If ReleaseDate.HasValue Then
                ret = String.Format("<Size=+1><b>{0}</b> ({1})<Size=-1>", Title, ReleaseDate.Value.Year.ToString())
            Else
                ret = String.Format("<Size=+1><b>{0}</b> ({1})<Size=-1>", Title, "?")
            End If
            ret &= String.Format(Constants.vbCrLf & "Genre: <b>{0}</b>", Genre)
            If (Not String.IsNullOrEmpty(Directors)) Then
                ret &= String.Format(Constants.vbCrLf & "Directors: <b>{0}</b>", Directors)
            End If
            If (Not Object.Equals(Language, Nothing)) Then
                ret &= String.Format(Constants.vbCrLf & "Language: <b>{0}</b>", Language.Name)
            End If
            If (Not Object.Equals(RunTime, Nothing)) Then
                ret &= String.Format(Constants.vbCrLf & "Run Time: <b>{0}</b>", RunTime)
            End If
            If (Not String.IsNullOrEmpty(AspectRatio)) Then
                ret &= String.Format(Constants.vbCrLf & "Aspect Ratio: <b>{0}</b>", AspectRatio)
            End If
            Return ret
        End Function
#Region "IComparable Members"
        Private Function CompareTo(ByVal obj As Object) As Integer
            Return String.Compare(MovieTitle, String.Format("{0}", obj))
        End Function
#End Region
    End Class
    Public Class Company
        Inherits VideoRentBaseObject
        Private fname As String
        Private ftype As CompanyType
        Private fwebSite As String
        Private fcountry As Country

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal selfId As Integer)
            Me.New(session)
            Me.SelfId = selfId
        End Sub
        Public Sub New(ByVal session As Session, ByVal name As String)
            Me.New(session)
            Me.Name = name
        End Sub
        Public Sub New(ByVal session As Session, ByVal selfId As Integer, ByVal name As String)
            Me.New(session, selfId)
            Me.Name = name
        End Sub
        Public Sub New(ByVal session As Session, ByVal name As String, ByVal country As Country, ByVal type As CompanyType, ByVal webSite As String)
            Me.New(session, name)
            Country = country
            Me.Type = type
            Me.WebSite = webSite
        End Sub
        Public Sub New(ByVal session As Session, ByVal selfId As Integer, ByVal name As String, ByVal country As Country, ByVal type As CompanyType, ByVal webSite As String)
            Me.New(session, selfId, name)
            Country = country
            Me.Type = type
            Me.WebSite = webSite
        End Sub
        <Persistent(), Indexed(Unique:=True)> _
        Public Property CompanyId() As Integer
            Get
                Return GetPropertyValue(Of Integer)("CompanyId")
            End Get
            Protected Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("CompanyId", value)
            End Set
        End Property
        Protected Overrides ReadOnly Property GeneratedIdType() As String
            Get
                Return "Company"
            End Get
        End Property
        Public Property Name() As String
            Get
                Return fname
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Name", fname, value)
            End Set
        End Property
        Public Property Type() As CompanyType
            Get
                Return ftype
            End Get
            Set(ByVal value As CompanyType)
                SetPropertyValue(Of CompanyType)("Type", ftype, value)
            End Set
        End Property
        Public Property WebSite() As String
            Get
                Return fwebSite
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("WebSite", fwebSite, value)
            End Set
        End Property
        <Association("Companies-Country")> _
        Public Property Country() As Country
            Get
                Return fcountry
            End Get
            Set(ByVal value As Country)
                SetPropertyValue(Of Country)("Country", fcountry, value)
            End Set
        End Property
        <Association("Company-MovieCompany"), Aggregated()> _
        Public ReadOnly Property Movies() As XPCollection(Of MovieCompany)
            Get
                Return GetCollection(Of MovieCompany)("Movies")
            End Get
        End Property
        Public ReadOnly Property MoviesCount() As Integer
            Get
                Return Movies.Count
            End Get
        End Property
        Public ReadOnly Property TypeName() As String
            Get
                If (Not Object.Equals(Type, Nothing)) Then
                    Return Type.Name
                End If
                Return String.Empty
            End Get
        End Property
    End Class
    Public Class MovieCompany
        Inherits VideoRentBaseObject
        Private fcompany As Company
        Private fmovie As Movie
        Private fdescription As String

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal movie As Movie, ByVal company As Company, ByVal description As String)
            Me.New(movie.Session)
            If Object.Equals(company, Nothing) Then
                Throw New ArgumentNullException("company")
            End If
            Movie = movie
            Company = company
            Me.Description = description
        End Sub
        <Association("Movie-MovieCompany")> _
        Public Property Movie() As Movie
            Get
                Return fmovie
            End Get
            Set(ByVal value As Movie)
                SetPropertyValue(Of Movie)("Movie", fmovie, value)
            End Set
        End Property
        <Association("Company-MovieCompany")> _
        Public Property Company() As Company
            Get
                Return fcompany
            End Get
            Set(ByVal value As Company)
                SetPropertyValue(Of Company)("Company", fcompany, value)
            End Set
        End Property
        <Size(SizeAttribute.Unlimited)> _
        Public Property Description() As String
            Get
                Return fdescription
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Description", fdescription, value)
            End Set
        End Property
    End Class
    Public Class MovieArtistLine
        Inherits VideoRentBaseObject
        Private fname As String

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal name As String)
            Me.New(session)
            Me.Name = name
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
        Public Shared Function GetDirector(ByVal session As Session) As MovieArtistLine
            Return FromName(session, ReferenceData.DirectorString)
        End Function
        Public Shared Function FromName(ByVal session As Session, ByVal name As String) As MovieArtistLine
            Return session.FindObject(Of MovieArtistLine)(CriteriaOperator.Parse("Name = ?", name))
        End Function
    End Class
    Public Class CompanyType
        Inherits VideoRentBaseObject
        Private fname As String

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal name As String)
            Me.New(session)
            Me.Name = name
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
        Public Overrides Function ToString() As String
            Return String.Format("{0}", Name)
        End Function
    End Class
    Public Class Artist
        Inherits Person
        Private fbirthName As String
        Private fbirthCountry As Country
        Private fbirthLocation As String
        Private fbiography As String
        Private fnickName As String
        Private flink As String

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal selfId As Integer)
            Me.New(session)
            Me.SelfId = selfId
        End Sub
        Public Sub New(ByVal session As Session, ByVal firstName As String, ByVal lastName As String)
            Me.New(session)
            Me.FirstName = firstName
            Me.LastName = lastName
        End Sub
        Public Sub New(ByVal session As Session, ByVal selfId As Integer, ByVal firstName As String, ByVal lastName As String)
            Me.New(session, selfId)
            Me.FirstName = firstName
            Me.LastName = lastName
        End Sub
        <Persistent(), Indexed(Unique:=True)> _
        Public Property ArtistId() As Integer
            Get
                Return GetPropertyValue(Of Integer)("ArtistId")
            End Get
            Protected Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ArtistId", value)
            End Set
        End Property
        Protected Overrides ReadOnly Property GeneratedIdType() As String
            Get
                Return "Artist"
            End Get
        End Property
        <Association("Artist-MovieArtist"), Aggregated()> _
        Public ReadOnly Property Movies() As XPCollection(Of MovieArtist)
            Get
                Return GetCollection(Of MovieArtist)("Movies")
            End Get
        End Property
        Public Property BirthName() As String
            Get
                Return fbirthName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("BirthName", fbirthName, value)
            End Set
        End Property
        Public Property BirthCountry() As Country
            Get
                Return fbirthCountry
            End Get
            Set(ByVal value As Country)
                SetPropertyValue(Of Country)("BirthCountry", fbirthCountry, value)
            End Set
        End Property
        Public Property BirthLocation() As String
            Get
                Return fbirthLocation
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("BirthLocation", fbirthLocation, value)
            End Set
        End Property
        <Size(SizeAttribute.Unlimited)> _
        Public Property Biography() As String
            Get
                Return fbiography
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Biography", fbiography, value)
            End Set
        End Property
        Public Property NickName() As String
            Get
                Return fnickName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("NickName", fnickName, value)
            End Set
        End Property
        Public Property Link() As String
            Get
                Return flink
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Link", flink, value)
            End Set
        End Property
        <Association("Artist-ArtistPictures"), Aggregated()> _
        Public ReadOnly Property Pictures() As XPCollection(Of ArtistPicture)
            Get
                Return GetCollection(Of ArtistPicture)("Pictures")
            End Get
        End Property
        Public Overrides ReadOnly Property FullName() As String
            Get
                Dim ret As String
                If Object.Equals(FirstName, Nothing) Then
                    ret = String.Empty
                Else
                    ret = FirstName.Trim()
                End If
                Dim nickNameTrim As String
                If Object.Equals(NickName, Nothing) Then
                    nickNameTrim = String.Empty
                Else
                    nickNameTrim = NickName.Trim()
                End If
                Dim lastNameTrim As String
                If Object.Equals(LastName, Nothing) Then
                    lastNameTrim = String.Empty
                Else
                    lastNameTrim = LastName.Trim()
                End If
                If nickNameTrim.Length <> 0 Then
                    If ret.Length = 0 Then
                        ret &= (String.Empty) & """" & nickNameTrim & """"
                    Else
                        ret &= (" ") & """" & nickNameTrim & """"
                    End If
                End If
                If lastNameTrim.Length <> 0 Then
                    If ret.Length = 0 Then
                        ret &= (String.Empty) & lastNameTrim
                    Else
                        ret &= (" ") & lastNameTrim
                    End If
                End If
                Return ret
            End Get
        End Property
        Public Function AddPicture(ByVal picture As Image) As ArtistPicture
            Return New ArtistPicture(Me, picture)
        End Function
        Public Function AddPicture(ByVal picture As Image, ByVal description As String) As ArtistPicture
            Return New ArtistPicture(Me, picture, description)
        End Function
    End Class
    Public Class Country
        Inherits VideoRentBaseObject
        Private fname As String
        Private facronym As String
        Private fflag As Image

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal acronym As String, ByVal name As String, ByVal flag As Image)
            Me.New(session)
            Me.Acronym = acronym
            Me.Name = name
            Me.Flag = flag
        End Sub
        Public Property Name() As String
            Get
                Return fname
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Name", fname, value)
            End Set
        End Property
        <Indexed(Unique:=True)> _
        Public Property Acronym() As String
            Get
                Return facronym
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Acronym", facronym, value)
            End Set
        End Property
        <DevExpress.Xpo.ValueConverter(GetType(DevExpress.Xpo.Metadata.ImageValueConverter))> _
        Public Property Flag() As Image
            Get
                Return fflag
            End Get
            Set(ByVal value As Image)
                SetPropertyValue(Of Image)("Flag", fflag, value)
            End Set
        End Property
        <Association("Companies-Country")> _
        Public ReadOnly Property Companies() As XPCollection(Of Company)
            Get
                Return GetCollection(Of Company)("Companies")
            End Get
        End Property
        <Association("Movies-Countries")> _
        Public ReadOnly Property Movies() As XPCollection(Of Movie)
            Get
                Return GetCollection(Of Movie)("Movies")
            End Get
        End Property
        Public Overrides Function ToString() As String
            Dim ret As String = String.Format("{0}", Name)
            Return ret
        End Function
    End Class
    Public Class MovieArtist
        Inherits VideoRentBaseObject
        Private fartist As Artist
        Private fmovie As Movie
        Private fline As MovieArtistLine
        Private fdescription As String

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal movie As Movie, ByVal artist As Artist, ByVal line As MovieArtistLine, ByVal description As String)
            Me.New(movie.Session)
            If Object.Equals(artist, Nothing) Then
                Throw New ArgumentNullException("artist")
            End If
            Movie = movie
            Artist = artist
            Me.Line = line
            Me.Description = description
        End Sub
        <Association("Movie-MovieArtist")> _
        Public Property Movie() As Movie
            Get
                Return fmovie
            End Get
            Set(ByVal value As Movie)
                SetPropertyValue(Of Movie)("Movie", fmovie, value)
            End Set
        End Property
        <Association("Artist-MovieArtist")> _
        Public Property Artist() As Artist
            Get
                Return fartist
            End Get
            Set(ByVal value As Artist)
                SetPropertyValue(Of Artist)("Artist", fartist, value)
            End Set
        End Property
        <Size(SizeAttribute.Unlimited)> _
        Public Property Description() As String
            Get
                Return fdescription
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Description", fdescription, value)
            End Set
        End Property
        Public Property Line() As MovieArtistLine
            Get
                Return fline
            End Get
            Set(ByVal value As MovieArtistLine)
                SetPropertyValue(Of MovieArtistLine)("Line", fline, value)
            End Set
        End Property
    End Class
    Public Class Picture
        Inherits VideoRentBaseObject
        Private fimage As Image
        Private fdescription As String

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        <DevExpress.Xpo.ValueConverter(GetType(DevExpress.Xpo.Metadata.ImageValueConverter))> _
        Public Property Image() As Image
            Get
                Return fimage
            End Get
            Set(ByVal value As Image)
                SetPropertyValue(Of Image)("Image", fimage, value)
            End Set
        End Property
        <Size(200)> _
        Public Property Description() As String
            Get
                Return fdescription
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Description", fdescription, value)
            End Set
        End Property
    End Class
    Public Class ArtistPicture
        Inherits Picture
        Private fartist As Artist

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal artist As Artist, ByVal picture As Image)
            Me.New(artist.Session)
            Artist = artist
            Image = picture
        End Sub
        Public Sub New(ByVal artist As Artist, ByVal picture As Image, ByVal description As String)
            Me.New(artist, picture)
            Me.Description = description
        End Sub
        <Association("Artist-ArtistPictures")> _
        Public Property Artist() As Artist
            Get
                Return fartist
            End Get
            Set(ByVal value As Artist)
                SetPropertyValue(Of Artist)("Artist", fartist, value)
            End Set
        End Property
    End Class
    Public Class MoviePicture
        Inherits Picture
        Private fmovie As Movie

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal movie As Movie, ByVal picture As Image)
            Me.New(movie.Session)
            Movie = movie
            Image = picture
        End Sub
        Public Sub New(ByVal movie As Movie, ByVal picture As Image, ByVal description As String)
            Me.New(movie, picture)
            Me.Description = description
        End Sub
        <Association("Movie-MoviePictures")> _
        Public Property Movie() As Movie
            Get
                Return fmovie
            End Get
            Set(ByVal value As Movie)
                SetPropertyValue(Of Movie)("Movie", fmovie, value)
            End Set
        End Property
    End Class
    Public Class Language
        Inherits VideoRentBaseObject
        Private fname As String
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal name As String)
            Me.New(session)
            Me.Name = name
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
        <Association("Movies-Language")> _
        Public ReadOnly Property Movies() As XPCollection(Of Movie)
            Get
                Return GetCollection(Of Movie)("Movies")
            End Get
        End Property
    End Class
End Namespace
