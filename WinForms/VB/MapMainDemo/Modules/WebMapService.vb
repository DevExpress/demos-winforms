Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraMap.Demos

    Public Partial Class WebMapService
        Inherits FooteredMapTutorialControl

        Private Shared ReadOnly SelectionColor As Color = Color.FromArgb(128, 135, 135, 135)

        Private Shared ReadOnly HotTrackedColor As Color = Color.FromArgb(62, Color.Gray)

        Private Shared ReadOnly ItemMargin As Padding = New Padding(2)

        Private selectionLocked As Boolean = False

        Private ReadOnly menuField As MapOverlay = New MapOverlay() With {.Alignment = ContentAlignment.TopRight, .Margin = New Padding(10)}

        Private ReadOnly Property Menu As MapOverlay
            Get
                Return menuField
            End Get
        End Property

        Protected Overrides ReadOnly Property Overlays As MapOverlay()
            Get
                Return New MapOverlay() {Menu}
            End Get
        End Property

        Public Overrides ReadOnly Property MapControl As MapControl
            Get
                Return mapControl1
            End Get
        End Property

        Protected Overrides ReadOnly Property CopyrightText As String
            Get
                Return DemoUtils.OsmCopyright
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Function CreateMenuItem(ByVal layer As WmsLayer) As LayerOverlayMenuItem
            Dim layerItem As LayerOverlayMenuItem = New LayerOverlayMenuItem(layer.Name) With {.Padding = New Padding(10), .Margin = ItemMargin, .Text = layer.Name, .JoiningOrientation = Orientation.Vertical}
            CType(editWebMapSevice.Edit, RepositoryItemComboBox).Items.Add(layerItem)
            layerItem.HotTrackedStyle.Fill = HotTrackedColor
            Return layerItem
        End Function

        Private Function CreateHeader() As MapOverlayTextItem
            Dim header As MapOverlayTextItem = New MapOverlayTextItem() With {.Padding = New Padding(10, 10, 10, 20), .Text = "Available layers", .JoiningOrientation = Orientation.Vertical}
            header.TextStyle.Font = New Font("Arial", 14)
            Return header
        End Function

        Private Sub OnOverlaysArranged(ByVal sender As Object, ByVal e As OverlaysArrangedEventArgs)
            Dim overlays As OverlayArrangement() = e.OverlayArrangements
            Dim menu As OverlayArrangement = overlays(0)
            For i As Integer = 1 To menu.ItemLayouts.Length - 1
                Dim itemRect As Rectangle = menu.ItemLayouts(i)
                menu.ItemLayouts(i) = New Rectangle(itemRect.Location, New Size(menu.OverlayLayout.Width - ItemMargin.Size.Width, itemRect.Height))
            Next
        End Sub

        Private Sub OnResponseCapabilities(ByVal sender As Object, ByVal e As CapabilitiesRespondedEventArgs)
            GenerateMenu(e.Layers)
            SetOverlayMenuSelection(TryCast(Menu.Items(1), LayerOverlayMenuItem))
        End Sub

        Private Sub OnMapControlMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim hitInfo As MapHitInfo = MapControl.CalcHitInfo(e.Location)
            Dim clickedItem As LayerOverlayMenuItem = TryCast(GetClickedOverlayItem(hitInfo), LayerOverlayMenuItem)
            If clickedItem Is Nothing Then Return
            ResetMenuItemsBackground()
            SetOverlayMenuSelection(clickedItem)
        End Sub

        Private Sub SetOverlayMenuSelection(ByVal clickedItem As LayerOverlayMenuItem)
            selectionLocked = True
            clickedItem.BackgroundStyle.Fill = SelectionColor
            Provider.ActiveLayerName = clickedItem.LayerName
            editWebMapSevice.EditValue = clickedItem
            selectionLocked = False
        End Sub

        Private Sub GenerateMenu(ByVal layers As WmsLayerCollection)
            Menu.Items.Clear()
            Menu.Items.Add(CreateHeader())
            For Each layer As WmsLayer In layers
                Menu.Items.Add(CreateMenuItem(layer))
            Next
        End Sub

        Private Sub ResetMenuItemsBackground()
            For Each item As MapOverlayItemBase In Menu.Items
                Dim layerItem As LayerOverlayMenuItem = TryCast(item, LayerOverlayMenuItem)
                If layerItem IsNot Nothing Then layerItem.BackgroundStyle.Fill = Color.Transparent
            Next
        End Sub

        Private Sub editWebMapSevice_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            If Not selectionLocked Then
                ResetMenuItemsBackground()
                SetOverlayMenuSelection(TryCast(CType(sender, BarEditItem).EditValue, LayerOverlayMenuItem))
            End If
        End Sub
    End Class

    Public Class LayerOverlayMenuItem
        Inherits MapOverlayTextItem

        Private ReadOnly layerNameField As String

        Public ReadOnly Property LayerName As String
            Get
                Return layerNameField
            End Get
        End Property

        Public Sub New(ByVal name As String)
            layerNameField = name
        End Sub

        Public Overrides Function ToString() As String
            Return layerNameField
        End Function
    End Class
End Namespace
