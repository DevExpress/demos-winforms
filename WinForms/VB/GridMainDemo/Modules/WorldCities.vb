Imports DevExpress.Internal
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Drawing
Imports System.Linq
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils.Drawing

Namespace DevExpress.XtraGrid.Demos

    Public Module WorldCities

        Private ReadOnly CITIES_CSV_PATH As String = DataDirectoryHelper.GetDataFile("cities.csv")

        Private ReadOnly allEntries As List(Of Entry) = New List(Of Entry)(13000)

        Public ReadOnly Property All As IReadOnlyList(Of Entry)
            Get
                If allEntries.Count = 0 AndAlso IO.File.Exists(CITIES_CSV_PATH) Then
                    Dim lines = IO.File.ReadLines(CITIES_CSV_PATH).Skip(1)
                    Dim entries = lines.[Select](Function(x) New Entry(x)).OrderBy(Function(e) e.Country).ThenBy(Function(e) e.City)
                    For Each entry As Entry In entries
                        allEntries.Add(entry)
                    Next
                End If

                Return allEntries
            End Get
        End Property

        Public NotInheritable Class Entry

            Private _Country As String, _City As String, _City_Unicode As String, _Region As String, _Country_UN As String, _Title As String, _Subtitle As String, _Text As String, _Image As Image

            Private ReadOnly Shared csvseparators As Char() = New Char() {";"c, ","c}

            Private ReadOnly Shared trimCharacters As Char() = New Char() {" "c, Microsoft.VisualBasic.Strings.ChrW(9), """"c}

            Friend Sub New(ByVal csv As String)
                ' Country, Country_UN, Admin_Name_Unicode, City, City_Unicode
                Dim parts = csv.Split(csvseparators, StringSplitOptions.None)
                Country = parts(0).Trim(trimCharacters)
                Country_UN = parts(1).Trim()
                Region = parts(2).Trim()
                City = parts(3).Trim()
                City_Unicode = parts(4).Trim()
                Text = Country & ", " & String.Join(", ", GetTags())
                '
                Image = GetCountryStubGlyph()
                Title = If(Equals(City, City_Unicode), City, City & "(" & City_Unicode & ")")
                Subtitle = Country & ", " & Region
            End Sub

            Public Property Country As String
                Get
                    Return _Country
                End Get

                Private Set(ByVal value As String)
                    _Country = value
                End Set
            End Property

            Public Property City As String
                Get
                    Return _City
                End Get

                Private Set(ByVal value As String)
                    _City = value
                End Set
            End Property

            <Display(Order:=-1)>
            Public Property City_Unicode As String
                Get
                    Return _City_Unicode
                End Get

                Private Set(ByVal value As String)
                    _City_Unicode = value
                End Set
            End Property

            Public Property Region As String
                Get
                    Return _Region
                End Get

                Private Set(ByVal value As String)
                    _Region = value
                End Set
            End Property

            <Display(Order:=-1)>
            Public Property Country_UN As String
                Get
                    Return _Country_UN
                End Get

                Private Set(ByVal value As String)
                    _Country_UN = value
                End Set
            End Property

            <Display(Order:=-1)>
            Public Property Title As String
                Get
                    Return _Title
                End Get

                Private Set(ByVal value As String)
                    _Title = value
                End Set
            End Property

            <Display(Order:=-1)>
            Public Property Subtitle As String
                Get
                    Return _Subtitle
                End Get

                Private Set(ByVal value As String)
                    _Subtitle = value
                End Set
            End Property

            <Display(Order:=-1)>
            Public Property Text As String
                Get
                    Return _Text
                End Get

                Private Set(ByVal value As String)
                    _Text = value
                End Set
            End Property

            Public Property Image As Image
                Get
                    Return _Image
                End Get

                Private Set(ByVal value As Image)
                    _Image = value
                End Set
            End Property

            Private Function GetTags() As String()
                If Equals(City, City_Unicode) Then
                    If Equals(City, Region) Then Return New String() {City}
                    Return New String() {City, Region}
                End If

                Return New String() {City, City_Unicode, Region}
            End Function

            Private Function GetCountryStubGlyph() As Image
                Return StubCache.GetImage(Country_UN)
            End Function
        End Class

        Private NotInheritable Class StubCache

            Private ReadOnly Shared cache As Dictionary(Of String, Image) = New Dictionary(Of String, Image)(256)

            Public Shared Function GetImage(ByVal text As String) As Image
                Dim img As Image = Nothing
                If Not cache.TryGetValue(text, img) Then
                    img = CreateGlyph(text)
                    cache.Add(text, img)
                End If

                Return img
            End Function

            Private ReadOnly Shared options As StubGlyphOptions = New StubGlyphOptions() With {.RandomizeColors = True, .Type = GlyphBackgroundType.Ellipse, .LetterCount = GlyphTextSymbolCount.Two}

            Private Shared Function CreateGlyph(ByVal text As String) As Image
                Dim glyphSize = Utils.ScaleUtils.ScaleValue(New Size(32, 32))
                Dim size = Utils.ScaleUtils.ScaleValue(New Size(28, 28))
                Dim skinProvider = UserLookAndFeel.Default
                Dim location = New Point((glyphSize.Width - size.Width) \ 2, (glyphSize.Height - size.Height) \ 2)
                Dim img = New Bitmap(glyphSize.Width, glyphSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
                Using g As Graphics = Graphics.FromImage(img)
                    Using cache As GraphicsCache = New GraphicsCache(g)
                        Call GlyphPainter.Default.DrawGlyph(cache, options, text, New Rectangle(location, size), skinProvider, ObjectState.Normal)
                    End Using
                End Using

                Return img
            End Function
        End Class
    End Module
End Namespace
