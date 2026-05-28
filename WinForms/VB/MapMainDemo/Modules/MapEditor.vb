Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraMap.Demos

    Public Partial Class MapEditorDemo
        Inherits FooteredMapTutorialControl

        Private Shared ReadOnly TitleFont As Font = New Font(AppearanceObject.DefaultFont.FontFamily, 10, FontStyle.Regular)

        Private ReadOnly overlayManager As MapEditorOverlayManager = New MapEditorOverlayManager()

        Private ReadOnly itemIndexes As Dictionary(Of Type, Long) = New Dictionary(Of Type, Long)()

        Private ReadOnly Property Editor As MapEditor
            Get
                Return MapControl.MapEditor
            End Get
        End Property

        Protected Overrides ReadOnly Property Overlays As MapOverlay()
            Get
                Return MapControl.Overlays.ToArray()
            End Get
        End Property

        Protected Overrides ReadOnly Property CopyrightImage As Image
            Get
                Return DemoUtils.AzureLogo
            End Get
        End Property

        Protected Overrides ReadOnly Property CopyrightText As String
            Get
                Return DemoUtils.AzureCopyright
            End Get
        End Property

        Public Overrides ReadOnly Property MapControl As MapControl
            Get
                Return mapControl1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            DemoUtils.SetAzureMapDataProviderKey(AzureMapDataProvider)
            Editor.SetEditMode()
            AddHandler Editor.MapItemCreating, AddressOf OnMapItemCreating
            InitializePlanData()
        End Sub

        Protected Overrides Sub InitRibbon()
            MyBase.InitRibbon()
            ChkShowMinimap.Enabled = False
        End Sub

        Private Sub InitializePlanData()
            kmlFileDataAdapter1.FileUri = DemoUtils.GetFileUri("Hotels\hotelmap.kml")
            Editor.ActiveLayer = vectorItemsLayer1
        End Sub

        Private Sub OnOverlaysArranged(ByVal sender As Object, ByVal e As OverlaysArrangedEventArgs)
            overlayManager.ArrangeOverlays(ScaleDPI, e.OverlayArrangements, New Size(fillEdit.Width + fillEdit.Margin.Right, fillEdit.Height))
            mapControl1.BeginInvoke(New Action(Of Point, Point)(Sub(ByVal fillLocation As Point, ByVal strokeLocation As Point)
                fillEdit.Location = fillLocation
                strokeEdit.Location = strokeLocation
            End Sub), overlayManager.FillEditLocation, overlayManager.StrokeEditLocation)
        End Sub

        Private Sub OnMapItemCreating(ByVal sender As Object, ByVal e As MapItemCreatingEventArgs)
            e.Item.Attributes.Add(New MapItemAttribute() With {.Name = "name", .Value = GenerateName(e.Item)})
            ApplyColors(e.Item)
        End Sub

        Private Function GenerateName(ByVal item As MapItem) As String
            Dim itemType As Type = item.GetType()
            If Not itemIndexes.ContainsKey(itemType) Then itemIndexes(itemType) = 0
            Return String.Format("{0} {1}", itemType.Name, (Threading.Interlocked.Increment(itemIndexes(itemType))).ToString())
        End Function

        Private Sub ApplyColors(ByVal item As MapItem)
            item.Fill = fillEdit.Color
            item.Stroke = strokeEdit.Color
        End Sub

        Private Sub OnItemsLoaded(ByVal sender As Object, ByVal e As ItemsLoadedEventArgs)
            e.Items(0).IsHitTestVisible = False
            Editor.ActiveItems = New MapItem() {e.Items(50)}
            Editor.ClearSavedActions()
        End Sub

        Private Sub OnExportBarButtonItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            Export()
        End Sub

        Private Sub Export()
            Using dialog As XtraSaveFileDialog = New XtraSaveFileDialog()
                dialog.Filter = "KML files|*.kml"
                dialog.CreatePrompt = True
                dialog.OverwritePrompt = True
                If dialog.ShowDialog() = DialogResult.OK Then
                    Editor.ActiveLayer.ExportToKml(dialog.FileName)
                    XtraMessageBox.Show(ParentForm, String.Format("Items successfully exported to {0} file", dialog.FileName), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        End Sub

        Private Sub OnCustomDisplayText(ByVal sender As Object, ByVal e As CustomDisplayTextEventArgs)
            e.DisplayText = String.Empty
        End Sub

        Private Sub OnColorEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            For Each item As MapItem In Editor.ActiveItems
                ApplyColors(item)
            Next
        End Sub

        Private Sub BeforeShowToolTip(ByVal sender As Object, ByVal e As ToolTipControllerShowEventArgs)
            Dim mapShape As MapShape = TryCast(e.SelectedObject, MapShape)
            If mapShape IsNot Nothing Then e.SuperTip = ObtainShapeToolTip(e.ToolTip, mapShape)
        End Sub

        Private Function ObtainShapeToolTip(ByVal title As String, ByVal shape As MapShape) As SuperToolTip
            Return If(TypeOf shape Is MapDot, CreateDotToolTip(title, TryCast(shape, MapDot)), CreateShapeToolTip(title, shape))
        End Function

        Private Function CreateShapeToolTip(ByVal title As String, ByVal shape As MapShape) As SuperToolTip
            Dim toolTip As SuperToolTip = New SuperToolTip() With {.MaxWidth = 350}
            Dim titleItem As ToolTipTitleItem = New ToolTipTitleItem() With {.Text = title, .Font = TitleFont}
            titleItem.Appearance.ForeColor = shape.Fill
            Dim perimeter As Double = Math.Round(GeoUtils.CalculateStrokeLength(shape), 3)
            Dim area As Double = Math.Round(GeoUtils.CalculateArea(shape), 3)
            Dim perimeterItem As ToolTipItem = New ToolTipItem() With {.Text = perimeter.ToString() & " m"}
            perimeterItem.ImageOptions.ImageToTextDistance = 0
            perimeterItem.ImageOptions.Image = DemoUtils.GetPerimeterImage(perimeterItem.Font.Height)
            Dim areaItem As ToolTipItem = New ToolTipItem() With {.Text = area.ToString() & " m²"}
            areaItem.ImageOptions.ImageToTextDistance = 0
            areaItem.ImageOptions.Image = DemoUtils.GetAreaImage(areaItem.Font.Height)
            toolTip.Items.Add(titleItem)
            toolTip.Items.Add(perimeterItem)
            toolTip.Items.Add(areaItem)
            Return toolTip
        End Function

        Private Function CreateDotToolTip(ByVal title As String, ByVal item As MapDot) As SuperToolTip
            Dim toolTip As SuperToolTip = New SuperToolTip() With {.MaxWidth = 350}
            Dim titleItem As ToolTipTitleItem = New ToolTipTitleItem() With {.Text = title, .Font = TitleFont}
            titleItem.Appearance.ForeColor = item.Fill
            Dim diameterItem As ToolTipItem = New ToolTipItem() With {.Text = String.Format("{0} px", CInt(item.Size))}
            diameterItem.ImageOptions.ImageToTextDistance = 0
            diameterItem.ImageOptions.Image = DemoUtils.GetDiameterImage(diameterItem.Font.Height)
            toolTip.Items.Add(titleItem)
            toolTip.Items.Add(diameterItem)
            Return toolTip
        End Function
    End Class
End Namespace
