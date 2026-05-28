Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports DevExpress.XtraMap

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class ucChoroplethMapItem
        Inherits XtraEditors.XtraUserControl

        Public Sub New()
            InitializeComponent()
            Dim baseLayer As VectorItemsLayer = New VectorItemsLayer()
            Dim dataAdapter = CreateShapefileDataAdapter()
            baseLayer.Data = dataAdapter
            baseLayer.EnableHighlighting = False
            baseLayer.SelectedItemStyle.StrokeWidth = 0
            mapControl1.Layers.Add(baseLayer)
            Dim fileLayer As VectorItemsLayer = New VectorItemsLayer()
            dataAdapter = CreateShapefileDataAdapter()
            AddHandler dataAdapter.ItemsLoaded, AddressOf OnFileLoaded
            fileLayer.Data = dataAdapter
            fileLayer.Colorizer = CreateGDPColorizer()
            fileLayer.ToolTipPattern = "{NAME}"
            mapControl1.Layers.Add(fileLayer)
        End Sub

        Private Function CreateShapefileDataAdapter() As ShapefileDataAdapter
            Dim adapter As ShapefileDataAdapter = New ShapefileDataAdapter()
            Dim path As String = GetRelativePath("USA.shp")
            If Not String.IsNullOrEmpty(path) Then adapter.FileUri = New Uri(path, UriKind.Absolute)
            Return adapter
        End Function

        Private Sub OnFileLoaded(ByVal sender As Object, ByVal e As ItemsLoadedEventArgs)
            For Each _item In e.Items
                Dim attr As MapItemAttribute = New MapItemAttribute()
                attr.Name = "RevenueYTD"
                Dim value = SalesPerformanceDataGenerator.Current.TotalSales.Where(Function(d) String.Equals(d.State, _item.Attributes("NAME").Value.ToString())).Sum(Function(d) d.RevenueYTD)
                attr.Value = value
                If value = 0 Then _item.Visible = False
                _item.Attributes.Add(attr)
            Next
        End Sub

        Private Function GetColorItems(ByVal colors As List(Of Color)) As GenericColorizerItemCollection(Of ColorizerColorItem)
            Dim result As GenericColorizerItemCollection(Of ColorizerColorItem) = New GenericColorizerItemCollection(Of ColorizerColorItem)()
            result.BeginUpdate()
            Try
                For Each color As Color In colors
                    result.Add(New ColorizerColorItem(color))
                Next
            Finally
                result.EndUpdate()
            End Try

            Return result
        End Function

        Private Function CreateGDPColorizer() As ChoroplethColorizer
            Dim colorizer As ChoroplethColorizer = New ChoroplethColorizer()
            colorizer.ValueProvider = New ShapeAttributeValueProvider() With {.AttributeName = "RevenueYTD"}
            colorizer.RangeStops.AddRange(New List(Of Double) From {0, 1000000, 2000000, 3000000, 4000000, 5000000, 6000000, 7000000, 8000000, 9000000, 10000000})
            Dim colors As List(Of Color) = New List(Of Color) From {Color.FromArgb(&H5F, &H8B, &H95), Color.FromArgb(&H79, &H96, &H89), Color.FromArgb(&HA2, &HA8, &H75), Color.FromArgb(&HCE, &HBB, &H5F), Color.FromArgb(&HF2, &HCB, &H4E), Color.FromArgb(&HF1, &HC1, &H49), Color.FromArgb(&HE5, &HA8, &H4D), Color.FromArgb(&HD6, &H86, &H4E), Color.FromArgb(&HC5, &H64, &H50), Color.FromArgb(&HBA, &H4D, &H51)}
            colorizer.ColorItems.AddRange(GetColorItems(colors))
            Return colorizer
        End Function

        Private item As MapItem

        Private Sub OnMapItemClick(ByVal sender As Object, ByVal e As MapItemClickEventArgs)
            Dim attr = e.Item.Attributes("RevenueYTD")
            If attr Is Nothing Then
                TryCast(mapControl1.Layers(1), VectorItemsLayer).SelectedItem = item
                Return
            End If

            item = e.Item
            SalesPerformanceDataGenerator.Current.Filter = e.Item.Attributes("NAME").Value.ToString()
        End Sub
    End Class
End Namespace
