Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports DevExpress.Utils.Svg

Namespace DevExpress.XtraMap.Demos

    Public Partial Class ClusterCustomization
        Inherits DevExpress.XtraMap.Demos.MapTutorialControl

        Public Overrides ReadOnly Property MapControl As MapControl
            Get
                Return Me.mapControl1
            End Get
        End Property

        Protected Overrides ReadOnly Property Overlays As DevExpress.XtraMap.MapOverlay()
            Get
                Return Me.MapControl.Overlays.ToArray()
            End Get
        End Property

        Public Sub New()
            Me.InitializeComponent()
            Me.ShapefileAdapter.FileUri = DevExpress.XtraMap.Demos.DemoUtils.GetFileUri("Countries.shp")
            Me.ItemsClusterer.SetClusterItemFactory(New DevExpress.XtraMap.Demos.ClusterFactory(Me.svgImageCollection1))
            Me.ItemsDataAdapter.SetMapItemFactory(New DevExpress.XtraMap.Demos.ItemFactory(Me.svgImageCollection1))
            Me.ItemsDataAdapter.DataSource = Me.LoadData()
        End Sub

        Private Function LoadData() As List(Of DevExpress.XtraMap.Demos.EducationItem)
            Dim items As System.Collections.Generic.List(Of DevExpress.XtraMap.Demos.EducationItem) = New System.Collections.Generic.List(Of DevExpress.XtraMap.Demos.EducationItem)()
            Dim lines As String() = System.IO.File.ReadAllLines(DevExpress.XtraMap.Demos.DemoUtils.GetRelativePath("UniData.csv"))
            For i As Integer = 1 To lines.Length - 1
                items.Add(DevExpress.XtraMap.Demos.EducationItem.FromCsvLine(lines(i), ";"c))
            Next

            Return items
        End Function

        Protected Overrides Sub InitRibbon()
            MyBase.InitRibbon()
            Me.DisableZoomOptions()
            Me.ChkShowMinimap.Enabled = False
        End Sub
    End Class

    Public Class ClusterFactory
        Inherits DevExpress.XtraMap.DefaultClusterItemFactory

        Private ReadOnly image As DevExpress.Utils.Svg.SvgImage

        Public Sub New(ByVal svgImageCollection1 As DevExpress.Utils.SvgImageCollection)
            Me.image = svgImageCollection1(0)
        End Sub

        Protected Overrides Function CreateItemInstance(ByVal objects As System.Collections.Generic.IList(Of DevExpress.XtraMap.MapItem)) As MapItem
            Dim dX As Integer = DevExpress.XtraMap.Demos.DemoUtils.DipToPixels(15)
            Dim dY As Integer = DevExpress.XtraMap.Demos.DemoUtils.DipToPixels(20)
            Return New DevExpress.XtraMap.MapPushpin() With {.SvgImage = Me.image, .SvgImageSize = New System.Drawing.Size(32, 32), .TextOrigin =(New System.Drawing.Point(dX, dY))}
        End Function
    End Class

    Public Class ItemFactory
        Inherits DevExpress.XtraMap.DefaultMapItemFactory

        Private ReadOnly image As DevExpress.Utils.Svg.SvgImage

        Public Sub New(ByVal svgImageCollection1 As DevExpress.Utils.SvgImageCollection)
            Me.image = svgImageCollection1(0)
        End Sub

        Protected Overrides Sub InitializeItem(ByVal item As DevExpress.XtraMap.MapItem, ByVal obj As Object)
            MyBase.InitializeItem(item, obj)
            Dim pin As DevExpress.XtraMap.MapPushpin = TryCast(item, DevExpress.XtraMap.MapPushpin)
            If pin IsNot Nothing Then
                pin.SvgImage = Me.image
                pin.SvgImageSize = New System.Drawing.Size(20, 20)
            End If

            item.ToolTipPattern = "{Name}" & System.Environment.NewLine & System.Environment.NewLine & "State: {State}" & System.Environment.NewLine & "City: {City}" & System.Environment.NewLine & "Web site: {Site}"
        End Sub
    End Class

    Public Structure EducationItem

        Public Property Name As String

        Public Property State As String

        Public Property City As String

        Public Property InfoUri As String

        Public Property SiteUri As String

        Public Property Lat As Double

        Public Property Lon As Double

        Public Shared Function FromCsvLine(ByVal sourceStr As String, ByVal separator As Char) As EducationItem
            Dim columns As String() = sourceStr.Split(separator)
            If columns.Length < 7 Then Throw New System.Exception("Line format error")
            Dim lat As Double = System.Convert.ToDouble(columns(3), System.Globalization.CultureInfo.InvariantCulture)
            Dim lon As Double = System.Convert.ToDouble(columns(4), System.Globalization.CultureInfo.InvariantCulture)
            Return New DevExpress.XtraMap.Demos.EducationItem() With {.Name = columns(0), .State = columns(1), .City = columns(2), .Lat = lat, .Lon = lon, .InfoUri = columns(5), .SiteUri = columns(6)}
        End Function
    End Structure
End Namespace
