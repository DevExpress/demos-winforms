Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DXperience.Demos
Imports System
Imports DevExpress.DevAV.Modules.Helpers
Imports DevExpress.DevAV.Common.Utils

Namespace DevExpress.DevAV.Modules

#If NET
    using DevExpress.AIIntegration.Tools;
    using DevExpress.DevAV.AITools;
#End If
    Public Partial Class Orders
        Inherits BaseModuleControl
        Implements IRibbonModule, ISupportZoom, ISupportFiltersVisibilityChangedEvent

#Region "ViewKind"
        Private _CollectionPresenter As OrderCollectionPresenter, _CollectionUIViewModel As CollectionUIViewModel

        Public Sub New()
            MyBase.New(GetType(OrderCollectionViewModel))
            InitializeComponent()
            GalleryItemAppearances.Apply(galleryQuickReports)
            CollectionUIViewModel = Mvvm.POCO.ViewModelSource.Create(Of CollectionUIViewModel)()
            CollectionPresenter = CreateCollectionPresenter()
            CollectionPresenter.ReloadEntities(mvvmContext)
            BindCommands()
            InitViewKind()
            InitViewLayout()
            InitEditors()
            SwapFluentIcons(Me)
        End Sub

        Protected Overrides Sub OnDisposing()
            CollectionPresenter.Dispose()
            UnsubscribeOrderViewEvents()
            MyBase.OnDisposing()
        End Sub

        Public ReadOnly Property ViewModel As OrderCollectionViewModel
            Get
                Return GetViewModel(Of OrderCollectionViewModel)()
            End Get
        End Property

        Public ReadOnly Property ParentViewModel As MainViewModel
            Get
                Return mvvmContext.GetParentViewModel(Of MainViewModel)()
            End Get
        End Property

        Protected Property CollectionPresenter As OrderCollectionPresenter
            Get
                Return _CollectionPresenter
            End Get

            Private Set(ByVal value As OrderCollectionPresenter)
                _CollectionPresenter = value
            End Set
        End Property

        Protected Overridable Function CreateCollectionPresenter() As OrderCollectionPresenter
            Return New OrderCollectionPresenter(gridControl, ViewModel, AddressOf UpdateEntitiesCountRelatedUI)
        End Function

        Protected Overrides Sub OnInitServices()
            mvvmContext.RegisterService("View Settings", New ViewSettingsDialogDocumentManagerService(Function() CollectionUIViewModel))
            mvvmContext.RegisterService(New DetailFormDocumentManagerService(ModuleType.OrderEditView))
        End Sub

        Private Sub BindCommands()
            biNewOrder.BindCommand(Sub() ViewModel.[New](), ViewModel)
            biMap.BindCommand(Sub() ViewModel.ShowMap(), ViewModel)
            biNewCustomFilter.BindCommand(Sub() ViewModel.NewCustomFilter(), ViewModel)
            bmiPrintInvoice.BindCommand(Sub() ViewModel.PrintInvoice(), ViewModel)
            bmiPrintSalesSummary.BindCommand(Sub() ViewModel.PrintSalesReport(), ViewModel)
            bmiPrintSalesAnalysis.BindCommand(Sub() ViewModel.PrintSalesByStore(), ViewModel)
            BindGalleryQuickReportsItem(1, SalesReportType.OrderFollowUp)
            BindGalleryQuickReportsFormatItem(3, ReportFormat.Doc)
            BindGalleryQuickReportsFormatItem(4, ReportFormat.Xls)
            BindGalleryQuickReportsFormatItem(5, ReportFormat.Pdf)
            galleryQuickReports.Gallery.Groups(0).Items(0).BindCommand(Sub() ViewModel.ShowRevenueReport(), ViewModel)
            galleryQuickReports.Gallery.Groups(0).Items(2).BindCommand(Sub() ViewModel.ShowRevenueAnalysisReport(), ViewModel)
            biViewSettings.BindCommand(Sub() ViewModel.ShowViewSettings(), ViewModel)
        End Sub

        Private Sub BindGalleryQuickReportsItem(ByVal index As Integer, ByVal parameter As SalesReportType)
            galleryQuickReports.Gallery.Groups(0).Items(index).BindCommand(Sub() ViewModel.QuickReport(parameter), ViewModel, Function() parameter)
        End Sub

        Private Sub BindGalleryQuickReportsFormatItem(ByVal index As Integer, ByVal parameter As ReportFormat)
            galleryQuickReports.Gallery.Groups(0).Items(index).BindCommand(Sub() ViewModel.QuickReportFormat(parameter), ViewModel, Function() parameter)
        End Sub

        Private Sub UpdateEntitiesCountRelatedUI(ByVal count As Integer)
            hiItemsCount.Caption = String.Format("RECORDS: {0}", count)
            UpdateAdditionalButtons(count > 0)
        End Sub

        Private Sub UpdateAdditionalButtons(ByVal hasRecords As Boolean)
            biReverseSort.Enabled = hasRecords
            biExpandCollapse.Enabled = hasRecords AndAlso CollectionUIViewModel.ViewKind = CollectionViewKind.MasterDetailView
            biAddColumns.Enabled = hasRecords AndAlso CollectionUIViewModel.ViewKind <> CollectionViewKind.CardView
        End Sub

        Private Sub biExpandCollapse_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            CollectionPresenter.ExpandCollapseMasterRows()
        End Sub

        Private Sub biAddColumns_ItemCheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            CollectionPresenter.AddColumns(biAddColumns)
        End Sub

        Private Sub biReverseSort_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            CollectionPresenter.ReverseSort(gridView, colOrderDate)
        End Sub

        Private orderView As OrderView

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            UnsubscribeOrderViewEvents()
            Dim moduleLocator = GetService(Of Services.IModuleLocator)()
            If moduleLocator Is Nothing Then Return
            orderView = TryCast(moduleLocator.GetModule(ModuleType.OrderView), OrderView)
            SubscribeOrderViewEvents()
            EnsureModuleViewModel(orderView, ViewModel, ViewModel.SelectedEntityKey)
            orderView.Dock = DockStyle.Fill
            orderView.Parent = roundedSkinPanelPnlView
            gridView.ExpandMasterRow(0)
            If Not MainFormHelper.TakeScreens Then
                gridView.ActiveFilterString = "IsOutlookIntervalYesterday([OrderDate]) Or IsOutlookIntervalToday([OrderDate])"
                gridView.ActiveFilterEnabled = False
            End If

            Call FilterPaneHelper.SetupFiltersPane(ParentViewModel, ViewModel, ModuleType.OrdersFilterPane, ModuleType.OrdersFilterPaneCollapsed, navigationRoundedPanel, DefaultNavigationSize, New Action(Of Object, EventArgs)(AddressOf OnFiltersVisibilityChangedCore))
        End Sub

        Public Event FiltersVisibilityChanged As EventHandler Implements ISupportFiltersVisibilityChangedEvent.FiltersVisibilityChanged

        Private ReadOnly Property DefaultNavigationSize As Size
            Get
                Return ScaleDPI.ScaleSize(New Size(230, navigationRoundedPanel.Height))
            End Get
        End Property

        Private ReadOnly Property DefaultCollapsedNavigationSize As Size
            Get
                Return ScaleDPI.ScaleSize(New Size(66, navigationRoundedPanel.Height))
            End Get
        End Property

        Protected Overridable Sub OnFiltersVisibilityChangedCore(ByVal sender As Object, ByVal e As EventArgs)
            roundedSkinPanel1.SuspendLayout()
            Call FilterPaneHelper.SwitchFiltersVisibility(ParentViewModel, navigationRoundedPanel, DefaultNavigationSize, DefaultCollapsedNavigationSize)
            roundedSkinPanel1.ResumeLayout()
        End Sub

        Public Sub RaiseFiltersVisibilityChanged(ByVal sender As Object, ByVal e As EventArgs) Implements ISupportFiltersVisibilityChangedEvent.RaiseFiltersVisibilityChanged
            OnFiltersVisibilityChangedCore(sender, e)
            RaiseEvent FiltersVisibilityChanged(sender, e)
        End Sub

#If NET
        protected override AIToolsContext CreateAIToolsContext() {
            return new AIToolsContextBuilder()
                .WithToolTarget(gridControl, "Orders Grid Control")
                .WithToolsFromTypes(typeof(GridControlAITools))
                .Build();
        }
#End If
        Const statusResourcePath As String = "DevExpress.DevAV.Resources.Orders."

        Private Sub InitEditors()
            colPaymentStatus.ImageOptions.ImageUri.ResourceType = GetType(MainForm)
            colPaymentStatus.ImageOptions.ImageUri.Uri = GetFluentIconName(statusResourcePath & "Payment.svg")
            colPaymentStatus.ColumnEdit = EditorHelpers.CreatePaymentStatusImageComboBox(LookAndFeel, Nothing, gridControl.RepositoryItems)
            colShipmentStatus.ImageOptions.ImageUri.ResourceType = GetType(MainForm)
            colShipmentStatus.ImageOptions.ImageUri.Uri = GetFluentIconName(statusResourcePath & "Shipment.svg")
            colShipmentStatus.ColumnEdit = EditorHelpers.CreateShipmentStatusImageComboBox(LookAndFeel, Nothing, gridControl.RepositoryItems)
        End Sub

        Private Sub UnsubscribeOrderViewEvents()
            If orderView IsNot Nothing Then
                RemoveHandler orderView.ZoomLevelChanged, AddressOf orderView_ZoomLevelChanged
                RemoveHandler orderView.MoveNextButton.ItemClick, AddressOf MoveNextButton_Click
                RemoveHandler orderView.MovePrevButton.ItemClick, AddressOf MovePrevButton_Click
            End If
        End Sub

        Private Sub SubscribeOrderViewEvents()
            If orderView IsNot Nothing Then
                AddHandler orderView.ZoomLevelChanged, AddressOf orderView_ZoomLevelChanged
                AddHandler orderView.MoveNextButton.ItemClick, AddressOf MoveNextButton_Click
                AddHandler orderView.MovePrevButton.ItemClick, AddressOf MovePrevButton_Click
                AddHandler gridView.FocusedRowChanged, AddressOf GridView_FocusedRowChanged
            End If
        End Sub

        Private Sub GridView_FocusedRowChanged(ByVal sender As Object, ByVal e As XtraGrid.Views.Base.FocusedRowChangedEventArgs)
            If orderView IsNot Nothing Then
                orderView.MoveNextButton.Enabled = Not gridView.IsLastRow
                orderView.MovePrevButton.Enabled = Not gridView.IsFirstRow
            End If
        End Sub

        Private Sub MovePrevButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            gridView.FocusedRowHandle -= 1
        End Sub

        Private Sub MoveNextButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            gridView.FocusedRowHandle += 1
        End Sub

        Protected Property CollectionUIViewModel As CollectionUIViewModel
            Get
                Return _CollectionUIViewModel
            End Get

            Private Set(ByVal value As CollectionUIViewModel)
                _CollectionUIViewModel = value
            End Set
        End Property

        Private Sub InitViewKind()
            CollectionUIViewModel.DefaultViewKind = CollectionViewKind.MasterDetailView
            CollectionUIViewModel.ViewKind = CollectionViewKind.MasterDetailView
            AddHandler CollectionUIViewModel.ViewKindChanged, AddressOf ViewModel_ViewKindChanged
            biShowMasterDetail.BindCommand(Sub() CollectionUIViewModel.ShowMasterDetail(), CollectionUIViewModel)
            biShowList.BindCommand(Sub() CollectionUIViewModel.ShowList(), CollectionUIViewModel)
            biShowCard.BindCommand(Sub() CollectionUIViewModel.ShowCard(), CollectionUIViewModel)
            bmiShowMasterDetail.BindCommand(Sub() CollectionUIViewModel.ShowMasterDetail(), CollectionUIViewModel)
            bmiShowList.BindCommand(Sub() CollectionUIViewModel.ShowList(), CollectionUIViewModel)
            bmiShowCard.BindCommand(Sub() CollectionUIViewModel.ShowCard(), CollectionUIViewModel)
            biResetView.BindCommand(Sub() CollectionUIViewModel.ResetView(), CollectionUIViewModel)
        End Sub

        Private Sub ViewModel_ViewKindChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim showDetails As Boolean = CollectionUIViewModel.ViewKind <> CollectionViewKind.ListView
            gridView.OptionsDetail.EnableMasterViewMode = showDetails
            If CollectionUIViewModel.ViewKind <> CollectionViewKind.CardView Then
                gridView.OptionsDetail.DetailMode = XtraGrid.Views.Grid.DetailMode.Embedded
                gridControl.LevelTree.Nodes(0).LevelTemplate = gridViewOrderItems
            Else
                gridView.OptionsDetail.DetailMode = XtraGrid.Views.Grid.DetailMode.Default
                gridControl.LevelTree.Nodes(0).LevelTemplate = tileViewOrderItems
            End If

            If showDetails Then gridView.ExpandMasterRow(0)
            UpdateAdditionalButtons(ViewModel.Entities.Count > 0)
            SetFindControlImages(gridControl)
        End Sub

#End Region
#Region "ViewLayout"
        Private Sub InitViewLayout()
            AddHandler CollectionUIViewModel.ViewLayoutChanged, AddressOf Me.ViewModel_ViewLayoutChanged
            bmiHorizontalLayout.BindCommand(Sub() CollectionUIViewModel.ShowHorizontalLayout(), CollectionUIViewModel)
            bmiVerticalLayout.BindCommand(Sub() CollectionUIViewModel.ShowVerticalLayout(), CollectionUIViewModel)
            bmiHideDetail.BindCommand(Sub() CollectionUIViewModel.HideDetail(), CollectionUIViewModel)
        End Sub

        Private Sub ViewModel_ViewLayoutChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim detailHidden As Boolean = CollectionUIViewModel.IsDetailHidden
            roundedSkinPanelPnlView.Visible = Not detailHidden
            If Not detailHidden Then
                roundedSkinPanelPnlView.Dock = If(CollectionUIViewModel.IsHorizontalLayout, DockStyle.Right, DockStyle.Bottom)
                If CollectionUIViewModel.IsHorizontalLayout Then
                    roundedSkinPanelPnlView.Width = ScaleDPI.ScaleHorizontal(500)
                Else
                    roundedSkinPanelPnlView.Height = ScaleDPI.ScaleHorizontal(400)
                End If
            End If
        End Sub

#End Region
#Region "ISupportZoom Members"
        Private Property ZoomLevel As Integer Implements ISupportZoom.ZoomLevel
            Get
                Return If(orderView IsNot Nothing, orderView.ZoomLevel, 100)
            End Get

            Set(ByVal value As Integer)
                If orderView IsNot Nothing Then orderView.ZoomLevel = value
            End Set
        End Property

        Private Shared ReadOnly zoomLevelChanged As Object = New Object()

        Private Custom Event ZoomChanged As EventHandler Implements ISupportZoom.ZoomChanged
            AddHandler(ByVal value As EventHandler)
                Events.AddHandler(zoomLevelChanged, value)
            End AddHandler

            RemoveHandler(ByVal value As EventHandler)
                Events.RemoveHandler(zoomLevelChanged, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
            End RaiseEvent
        End Event

        Private Sub orderView_ZoomLevelChanged(ByVal sender As Object, ByVal e As EventArgs)
            RaiseZoomLevelChanged()
        End Sub

        Private Sub RaiseZoomLevelChanged()
            Dim handler = TryCast(Events(zoomLevelChanged), EventHandler)
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

#End Region
#Region ""
        Private ReadOnly Property Ribbon As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                Return ribbonControl
            End Get
        End Property
#End Region
    End Class
End Namespace
