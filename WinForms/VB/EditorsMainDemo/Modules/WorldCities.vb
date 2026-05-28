Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks
Imports DevExpress.Tutorials
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraEditors.Demos

    Public Module WorldCities

        Public Function QueryAsync(ByVal text As String, ByVal cancellation As CancellationToken) As Task(Of ICollection)
            Dim contains = IgnoreCaseComparisonFunctions.GetContains(CultureInfo.CurrentCulture.CompareInfo, CompareOptions.IgnoreCase)
            Return Task.Run(New Func(Of ICollection)(Function()
                Dim entries = CsvDataHelper.EnsureAllEntries()
                Dim parts = text.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
                If parts.Length = 0 Then
                    Return TryCast(entries, ICollection)
                Else
                    Return entries.Where(Function(e)
                        ' stop task if needed
                        cancellation.ThrowIfCancellationRequested()
                        Return parts.All(Function(x) e.Tags.Any(Function(tag) contains(tag, x)))
                    End Function).ToList()
                End If
            End Function))
        End Function

        Public Function GetHtmlText(ByVal entry As Object) As String
            Return If(TypeOf entry Is Entry, CType(entry, Entry).HtmlText, String.Empty)
        End Function

        '
        Public NotInheritable Class Entry

            '
            Private _Country As String, _City As String, _City_Unicode As String, _Admin_Name_Unicode As String, _Country_UN As String, _Tags As String(), _Text As String, _HtmlText As String

            Private ReadOnly Shared csvseparators As Char() = New Char() {";"c, ","c}

            Private ReadOnly Shared trimCharacters As Char() = New Char() {" "c, Microsoft.VisualBasic.Strings.ChrW(9), """"c}

            Friend Sub New(ByVal csv As String)
                ' Country, Country_UN, Admin_Name_Unicode, City, City_Unicode
                Dim parts = csv.Split(csvseparators, StringSplitOptions.None)
                Country = parts(0).Trim(trimCharacters)
                Country_UN = parts(1).Trim()
                Admin_Name_Unicode = parts(2).Trim()
                City = parts(3).Trim()
                City_Unicode = parts(4).Trim()
                Tags = GetTags()
                Text = Country & ", " & String.Join(", ", Tags)
                HtmlText = Ignore(Country & ", ") & String.Join(", ", Tags)
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

            Public Property City_Unicode As String
                Get
                    Return _City_Unicode
                End Get

                Private Set(ByVal value As String)
                    _City_Unicode = value
                End Set
            End Property

            Public Property Admin_Name_Unicode As String
                Get
                    Return _Admin_Name_Unicode
                End Get

                Private Set(ByVal value As String)
                    _Admin_Name_Unicode = value
                End Set
            End Property

            Public Property Country_UN As String
                Get
                    Return _Country_UN
                End Get

                Private Set(ByVal value As String)
                    _Country_UN = value
                End Set
            End Property

            Public Property Tags As String()
                Get
                    Return _Tags
                End Get

                Private Set(ByVal value As String())
                    _Tags = value
                End Set
            End Property

            Public Property Text As String
                Get
                    Return _Text
                End Get

                Private Set(ByVal value As String)
                    _Text = value
                End Set
            End Property

            Public Property HtmlText As String
                Get
                    Return _HtmlText
                End Get

                Private Set(ByVal value As String)
                    _HtmlText = value
                End Set
            End Property

            '
            Private Function GetTags() As String()
                If Equals(City, City_Unicode) Then
                    If Equals(City, Admin_Name_Unicode) Then Return New String() {City}
                    Return New String() {City, Admin_Name_Unicode}
                End If

                Return New String() {City, City_Unicode, Admin_Name_Unicode}
            End Function

            Private Shared Function Ignore(ByVal text As String) As String
                Return "<color=@disabledtext>" & text & "</color>"
            End Function
        End Class

#Region "CsvDataHelper"
        Private NotInheritable Class CsvDataHelper

            Private ReadOnly Shared CITIES_CSV_PATH As String = FilePathUtils.FindFilePath(Path.Combine("Data", "cities.csv"))

            Private ReadOnly Shared allEntries As List(Of Entry) = New List(Of Entry)()

            Public Shared Function EnsureAllEntries() As IEnumerable(Of Entry)
                SyncLock allEntries
                    If allEntries.Count = 0 AndAlso File.Exists(CITIES_CSV_PATH) Then
                        Dim lines = File.ReadLines(CITIES_CSV_PATH).Skip(1)
                        Dim entries = lines.[Select](Function(x) New Entry(x)).OrderBy(Function(e) e.Country).ThenBy(Function(e) e.City)
                        For Each entry As Entry In entries
                            allEntries.Add(entry)
                        Next
                    End If

                    Return allEntries
                End SyncLock
            End Function
        End Class
#End Region  ' CsvDataHelper
    End Module
End Namespace
