Imports System
Imports System.Linq
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraMap
Imports DevExpress.Map.Dashboard

Namespace DevExpress.DevAV.Presenters

    Public MustInherit Class SalesMapPresenter(Of TEntity As Class, TViewModel As {Class, ISalesMapViewModel})
        Inherits BasePresenter(Of TViewModel)

        Private mapControlCore As MapControl

        Private updateUIActionCore As Action(Of TEntity)

        Private updateChartActionCore As Action(Of MapItem)

        Public Sub New(ByVal mapControl As MapControl, ByVal viewModel As TViewModel, ByVal updateUIAction As Action(Of TEntity), ByVal updateChartAction As Action(Of MapItem))
            MyBase.New(viewModel)
            mapControlCore = mapControl
            updateUIActionCore = updateUIAction
            updateChartActionCore = updateChartAction
            If Me.MapControl IsNot Nothing Then
                BindMap()
                SubscribeMapEvents()
            End If

            SubscribeViewModelEvents()
        End Sub

        Protected Overrides Sub OnDisposing()
            If MapControl IsNot Nothing Then UnsubscribeMapEvents()
            UnsubscribeViewModelEvents()
            updateUIActionCore = Nothing
            mapControlCore = Nothing
            MyBase.OnDisposing()
        End Sub

        Public ReadOnly Property MapControl As MapControl
            Get
                Return mapControlCore
            End Get
        End Property

        Protected ReadOnly Property TilesLayer As ImageLayer
            Get
                Return CType(MapControl.Layers(0), ImageLayer)
            End Get
        End Property

        Protected ReadOnly Property ItemsLayer As VectorItemsLayer
            Get
                Return CType(MapControl.Layers(1), VectorItemsLayer)
            End Get
        End Property

        Protected ReadOnly Property TilesProvider As AzureMapDataProvider
            Get
                Return CType(TilesLayer.DataProvider, AzureMapDataProvider)
            End Get
        End Property

        Protected ReadOnly Property PieChartDataAdapter As PieChartDataAdapter
            Get
                Return CType(ItemsLayer.Data, PieChartDataAdapter)
            End Get
        End Property

        Public ReadOnly Property PieChartColorizer As KeyColorColorizer
            Get
                Return CType(ItemsLayer.Colorizer, KeyColorColorizer)
            End Get
        End Property

        Private zoomServiceCore As IZoomToRegionService

        Protected ReadOnly Property ZoomService As IZoomToRegionService
            Get
                Return zoomServiceCore
            End Get
        End Property

        Private Sub BindMap()
            TilesProvider.AzureKey = MapViewModelBase.AzureKey
            zoomServiceCore = TryCast(CType(MapControl, IServiceProvider).GetService(GetType(IZoomToRegionService)), IZoomToRegionService)
        End Sub

        Protected Overridable Sub SubscribeMapEvents()
            AddHandler MapControl.SelectionChanged, AddressOf MapControl_SelectionChanged
            AddHandler ItemsLayer.DataLoaded, AddressOf ItemsLayer_DataLoaded
        End Sub

        Protected Overridable Sub UnsubscribeMapEvents()
            RemoveHandler MapControl.SelectionChanged, AddressOf MapControl_SelectionChanged
            RemoveHandler ItemsLayer.DataLoaded, AddressOf ItemsLayer_DataLoaded
        End Sub

        Protected Overridable Sub SubscribeViewModelEvents()
            AddHandler ViewModel.PeriodChanged, AddressOf ViewModel_PeriodChanged
        End Sub

        Protected Overridable Sub UnsubscribeViewModelEvents()
            RemoveHandler ViewModel.PeriodChanged, AddressOf ViewModel_PeriodChanged
        End Sub

        Private Sub MapControl_SelectionChanged(ByVal sender As Object, ByVal e As MapSelectionChangedEventArgs)
            Dim salesItem As MapItem = TryCast(ItemsLayer.SelectedItem, MapItem)
            If salesItem Is Nothing Then Return
            If updateChartActionCore IsNot Nothing Then updateChartActionCore(salesItem)
        End Sub

        Private Sub ItemsLayer_DataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs)
            Dim mapItem = ItemsLayer.Data.Items.FirstOrDefault()
            ItemsLayer.SelectedItem = If(mapItem IsNot Nothing, ItemsLayer.Data.GetItemSourceObject(mapItem), Nothing)
        End Sub

        Protected Sub ViewModel_EntityChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateUI(GetViewModelEntity())
        End Sub

        Private Sub ViewModel_PeriodChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateSales()
        End Sub

        Private Sub UpdateUI(ByVal entity As TEntity)
            If updateUIActionCore IsNot Nothing Then updateUIActionCore(entity)
            UpdateSales()
        End Sub

        Protected MustOverride Function GetViewModelEntity() As TEntity

        Protected MustOverride Sub UpdateSales()
    End Class
End Namespace
