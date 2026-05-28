Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Internal

Namespace DevExpress.XtraEditors.Demos.Data

    Public Module MoviesData

        <System.FlagsAttribute>
        Public Enum MovieGenre
            None = 0
            Action = &H1
            Adventure = &H2
            Animation = &H4
            Biography = &H8
            Comedy = &H10
            Crime = &H20
            Documentary = &H40
            Drama = &H80
            Family = &H100
            Fantasy = &H200
            History = &H400
            Horror = &H800
            Music = &H1000
            Musical = &H2000
            Mystery = &H4000
            Romance = &H8000
            SciFi = &H10000
            Sport = &H20000
            Thriller = &H40000
            War = &H80000
            Western = &H100000
        End Enum

        Private XmlDataSet As System.Data.DataSet

        Public Producers As System.Collections.Generic.IList(Of DevExpress.XtraEditors.Demos.Data.MoviesData.Producer)

        Public Movies As System.Collections.Generic.IList(Of DevExpress.XtraEditors.Demos.Data.MoviesData.Movie)

        Public Sub Load()
            Call DevExpress.XtraEditors.Demos.Data.MoviesData.InitDataSet()
            If DevExpress.XtraEditors.Demos.Data.MoviesData.Producers Is Nothing Then DevExpress.XtraEditors.Demos.Data.MoviesData.Producers = DevExpress.XtraEditors.Demos.Data.MoviesData.LoadProducers().ToList()
            If DevExpress.XtraEditors.Demos.Data.MoviesData.Movies Is Nothing Then DevExpress.XtraEditors.Demos.Data.MoviesData.Movies = DevExpress.XtraEditors.Demos.Data.MoviesData.LoadMovies().ToList()
        End Sub

        Private Sub InitDataSet()
            If DevExpress.XtraEditors.Demos.Data.MoviesData.XmlDataSet Is Nothing Then
                DevExpress.XtraEditors.Demos.Data.MoviesData.XmlDataSet = New System.Data.DataSet()
                Call DevExpress.XtraEditors.Demos.Data.MoviesData.XmlDataSet.ReadXml(DevExpress.Internal.DataDirectoryHelper.GetDataFile("VideoRent.xml"))
            End If
        End Sub

        Private Function LoadMovies() As IEnumerable(Of DevExpress.XtraEditors.Demos.Data.MoviesData.Movie)
            Dim tableMovie = TryCast(DevExpress.XtraEditors.Demos.Data.MoviesData.XmlDataSet.Tables("Movie"), System.Data.DataTable)
            Dim tableMovieArtist = TryCast(DevExpress.XtraEditors.Demos.Data.MoviesData.XmlDataSet.Tables("MovieArtist"), System.Data.DataTable)
            Dim tableMovieArtistLine = TryCast(DevExpress.XtraEditors.Demos.Data.MoviesData.XmlDataSet.Tables("MovieArtistLine"), System.Data.DataTable)
            Dim tablePerson = TryCast(DevExpress.XtraEditors.Demos.Data.MoviesData.XmlDataSet.Tables("Person"), System.Data.DataTable)
            Dim tableMovieCountry = TryCast(DevExpress.XtraEditors.Demos.Data.MoviesData.XmlDataSet.Tables("MovieMovies_CountryCountries"), System.Data.DataTable)
            Dim tableCountry = TryCast(DevExpress.XtraEditors.Demos.Data.MoviesData.XmlDataSet.Tables("Country"), System.Data.DataTable)
            Dim movie = From m In tableMovie.AsEnumerable() Join ma In tableMovieArtist.AsEnumerable() On m.Field(Of System.Guid)("Oid") Equals ma.Field(Of System.Guid)("Movie") Join mal In tableMovieArtistLine.AsEnumerable() On ma.Field(Of System.Guid)("Line") Equals mal.Field(Of System.Guid)("Oid") Join p In tablePerson.AsEnumerable() On ma.Field(Of System.Guid)("Artist") Equals p.Field(Of System.Guid)("Oid") Join mc In tableMovieCountry.AsEnumerable() On m.Field(Of System.Guid)("Oid") Equals mc.Field(Of System.Guid)("Movies") Join c In tableCountry.AsEnumerable() On mc.Field(Of System.Guid)("Countries") Equals c.Field(Of System.Guid)("Oid") Where System.Data.DataRowExtensions.Field(Of String)(mal, CStr(("Name"))).Equals("Director") Select New DevExpress.XtraEditors.Demos.Data.MoviesData.Movie() With {.MovieTitle = m.Field(Of String)("Title"), .Release = System.Data.DataRowExtensions.Field(Of System.DateTime)(m, CStr(("ReleaseDate"))).Year, .Genres = DevExpress.XtraEditors.Demos.Data.MoviesData.GetGenres(m.Field(Of Integer)("Genre")), .Producers = p.Field(Of String)("FirstName") & " " & p.Field(Of String)("LastName"), .Countries = c.Field(Of String)("Name")}
            Return From m In movie.AsEnumerable() Group m By __groupByKey1__ = New With {.MovieTitle = m.MovieTitle, .MovieRelease = m.Release, .MovieGenre = m.Genres} Into groupWithProducers = Group Select New DevExpress.XtraEditors.Demos.Data.MoviesData.Movie() With {.MovieTitle = __groupByKey1__.MovieTitle, .Release = __groupByKey1__.MovieRelease, .Genres = __groupByKey1__.MovieGenre, .Producers = String.Join(", ", groupWithProducers.[Select](Function(x) x.Producers).Distinct()), .Countries = String.Join(", ", groupWithProducers.[Select](Function(x) x.Countries).Distinct())}
        End Function

        Private Function LoadProducers() As IEnumerable(Of DevExpress.XtraEditors.Demos.Data.MoviesData.Producer)
            Dim tableMovieArtist = TryCast(DevExpress.XtraEditors.Demos.Data.MoviesData.XmlDataSet.Tables("MovieArtist"), System.Data.DataTable)
            Dim tableMovieArtistLine = TryCast(DevExpress.XtraEditors.Demos.Data.MoviesData.XmlDataSet.Tables("MovieArtistLine"), System.Data.DataTable)
            Dim tablePerson = TryCast(DevExpress.XtraEditors.Demos.Data.MoviesData.XmlDataSet.Tables("Person"), System.Data.DataTable)
            Return From ma In tableMovieArtist.AsEnumerable() Join mal In tableMovieArtistLine.AsEnumerable() On ma.Field(Of System.Guid)("Line") Equals mal.Field(Of System.Guid)("Oid") Join p In tablePerson.AsEnumerable() On ma.Field(Of System.Guid)("Artist") Equals p.Field(Of System.Guid)("Oid") Where System.Data.DataRowExtensions.Field(Of String)(mal, CStr(("Name"))).Equals("Director") Order By p.Field(Of String)("FirstName") & p.Field(Of String)("LastName") Select New DevExpress.XtraEditors.Demos.Data.MoviesData.Producer(p.Field(Of System.Guid)("Oid"), p.Field(Of String)("FirstName") & " " & p.Field(Of String)("LastName"))
        End Function

        Private Function GetGenres(ByVal value As Integer) As String
            Dim genres = CType(value, DevExpress.XtraEditors.Demos.Data.MoviesData.MovieGenre)
            Return genres.ToString("G")
        End Function

        Public Class Movie

            Public Property MovieTitle As String

            Public Property Release As Integer

            Public Property Genres As String

            Public Property Producers As String

            Public Property Countries As String
        End Class

        Public Class Producer

            Public Sub New(ByVal id As System.Guid, ByVal name As String)
                Me.Id = id
                Me.Name = name
            End Sub

            Public Property Id As Guid

            Public Property Name As String
        End Class
    End Module
End Namespace
