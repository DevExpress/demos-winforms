Imports System
Imports System.Linq
Imports System.Data
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.Internal
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.AI.Demos.Modules.SemanticSearch

    Public Class Movie

        Public Property Id As Guid

        Public Property Title As String

        Public Property Plot As String

        Public Property Genre As String

        Public Property Photo As Image

        Public Property Release As Date

        Public Property Directors As String
    End Class

    Public Class SemanticSearchDataHelper

        Private Shared _Movies As IList(Of DevExpress.AI.Demos.Modules.SemanticSearch.Movie)

        <Flags>
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

        Public Shared Property Movies As IList(Of Movie)
            Get
                Return _Movies
            End Get

            Private Set(ByVal value As IList(Of Movie))
                _Movies = value
            End Set
        End Property

        Public Shared Sub Load()
            If Movies IsNot Nothing Then Return
            Dim dataSet = New DataSet()
            dataSet.ReadXml(DataDirectoryHelper.GetDataFile("VideoRent.xml"))
            Dim directorLineId = dataSet.Tables("MovieArtistLine").Rows.OfType(Of DataRow)().FirstOrDefault(Function(r) Equals(r.Field(Of String)("Name"), "Director"))?.Field(Of Guid)("Oid")
            If directorLineId Is Nothing Then Return
            Dim directors = From movieArtistRow In dataSet.Tables("MovieArtist").AsEnumerable() Where movieArtistRow.Field(Of Guid)("Line") = directorLineId From personRow In dataSet.Tables("Person").AsEnumerable() Where personRow.Field(Of Guid)("Oid") = movieArtistRow.Field(Of Guid)("Artist") Select New With {.MovieId = movieArtistRow.Field(Of Guid)("Movie"), .Name = String.Join(" ", personRow.Field(Of String)("FirstName"), personRow.Field(Of String)("LastName"))}
            Movies = dataSet.Tables("Movie").AsEnumerable().[Select](Function(row)
                Dim movieId = row.Field(Of Guid)("Oid")
                Return New Movie With {.Id = movieId, .Title = row.Field(Of String)("Title"), .Release = row.Field(Of Date)("ReleaseDate"), .Genre = GetGenre(row), .Plot = row.Field(Of String)("Plot"), .Photo = GetPhoto(row), .Directors = String.Join(", ", directors.Where(Function(d) d.MovieId = movieId).[Select](Function(d) d.Name))}
            End Function).ToList()
        End Sub

        Private Shared Function GetGenre(ByVal row As DataRow) As String
            Dim genres = CType(row.Field(Of Integer)("Genre"), MovieGenre)
            Return genres.ToString("G")
        End Function

        Private Shared Function GetPhoto(ByVal row As DataRow) As Image
            Dim photoBytes = row.Field(Of Byte())("Photo")
            If photoBytes IsNot Nothing AndAlso photoBytes.Length > 0 Then Return ByteImageConverter.FromByteArray(photoBytes)
            Return Nothing
        End Function
    End Class
End Namespace
