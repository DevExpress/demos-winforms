Imports System.Collections

Namespace DevExpress.XtraCharts.Demos

    Friend Structure MarkerKindStrings

        Public Const square As String = "Square"

        Public Const diamond As String = "Diamond"

        Public Const triangle As String = "Triangle"

        Public Const invertedTriangle As String = "Inverted Triangle"

        Public Const circle As String = "Circle"

        Public Const plus As String = "Plus"

        Public Const cross As String = "Cross"

        Public Const star3 As String = "Star 3-points"

        Public Const star4 As String = "Star 4-points"

        Public Const star5 As String = "Star 5-points"

        Public Const star6 As String = "Star 6-points"

        Public Const star10 As String = "Star 10-points"

        Public Const pentagon As String = "Pentagon"

        Public Const hexagon As String = "Hexagon"
    End Structure

    Friend Class MarkerKindItem

        Private _Text As String, _MarkerKind As MarkerKind

        Public Property Text As String
            Get
                Return _Text
            End Get

            Private Set(ByVal value As String)
                _Text = value
            End Set
        End Property

        Public Property MarkerKind As MarkerKind
            Get
                Return _MarkerKind
            End Get

            Private Set(ByVal value As MarkerKind)
                _MarkerKind = value
            End Set
        End Property

        Friend Sub New(ByVal text As String, ByVal markerKind As MarkerKind)
            Me.Text = text
            Me.MarkerKind = markerKind
        End Sub

        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    Friend Class StarMarkerKindItem
        Inherits MarkerKindItem

        Private _PointCount As Integer

        Friend Property PointCount As Integer
            Get
                Return _PointCount
            End Get

            Private Set(ByVal value As Integer)
                _PointCount = value
            End Set
        End Property

        Public Sub New(ByVal text As String, ByVal pointCount As Integer)
            MyBase.New(text, MarkerKind.Star)
            Me.PointCount = pointCount
        End Sub
    End Class

    Friend Class MarkerKindItemCollection
        Inherits CollectionBase

        Friend Shared Function CreateCollection() As MarkerKindItemCollection
            Dim itemCollection As MarkerKindItemCollection = New MarkerKindItemCollection()
            itemCollection.Add(New MarkerKindItem(MarkerKindStrings.square, MarkerKind.Square))
            itemCollection.Add(New MarkerKindItem(MarkerKindStrings.diamond, MarkerKind.Diamond))
            itemCollection.Add(New MarkerKindItem(MarkerKindStrings.triangle, MarkerKind.Triangle))
            itemCollection.Add(New MarkerKindItem(MarkerKindStrings.invertedTriangle, MarkerKind.InvertedTriangle))
            itemCollection.Add(New MarkerKindItem(MarkerKindStrings.circle, MarkerKind.Circle))
            itemCollection.Add(New MarkerKindItem(MarkerKindStrings.plus, MarkerKind.Plus))
            itemCollection.Add(New MarkerKindItem(MarkerKindStrings.cross, MarkerKind.Cross))
            itemCollection.Add(New StarMarkerKindItem(MarkerKindStrings.star3, 3))
            itemCollection.Add(New StarMarkerKindItem(MarkerKindStrings.star4, 4))
            itemCollection.Add(New StarMarkerKindItem(MarkerKindStrings.star5, 5))
            itemCollection.Add(New StarMarkerKindItem(MarkerKindStrings.star6, 6))
            itemCollection.Add(New StarMarkerKindItem(MarkerKindStrings.star10, 10))
            itemCollection.Add(New MarkerKindItem(MarkerKindStrings.pentagon, MarkerKind.Pentagon))
            itemCollection.Add(New MarkerKindItem(MarkerKindStrings.hexagon, MarkerKind.Hexagon))
            Return itemCollection
        End Function

        Friend Shared Function GetSizeArray() As String()
            Return New String() {"8", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "30"}
        End Function

        Friend Sub New()
        End Sub

        Friend Function Add(ByVal value As MarkerKindItem) As Integer
            Return List.Add(value)
        End Function

        Friend Sub CopyTo(ByVal objects As Object())
            List.CopyTo(objects, 0)
        End Sub

        Friend Function GetItemByKind(ByVal markerKind As MarkerKind) As MarkerKindItem
            For Each item As MarkerKindItem In List
                If item.MarkerKind.Equals(markerKind) Then Return item
            Next

            Return Nothing
        End Function

        Friend Function GetItemByStarPointCount(ByVal pointCount As Integer) As MarkerKindItem
            For Each item As MarkerKindItem In List
                If item.MarkerKind.Equals(MarkerKind.Star) AndAlso CType(item, StarMarkerKindItem).PointCount = pointCount Then Return item
            Next

            Return Nothing
        End Function
    End Class
End Namespace
