Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DevAV.Common.Utils
Imports DevExpress.DevAV.Modules.Helpers
Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Layout

Namespace DevExpress.DevAV.Modules

#If NET
    using DevExpress.AIIntegration.Tools;
    using System.ComponentModel;
    using DevExpress.DevAV.AITools;
#End If
    Public Partial Class Products
        Inherits BaseModuleControl
        Implements IRibbonModule, ISupportZoom, ISupportFiltersVisibilityChangedEvent

#Region "ViewKind"
        Private _CollectionPresenter As ProductCollectionPresenter, _CollectionUIViewModel As CollectionUIViewModel

        Public Sub New()
            MyBase.New(GetType(ProductCollectionViewModel))
            InitializeComponent()
            GalleryItemAppearances.Apply(galleryQuickReports)
            layoutView.Appearance.FieldCaption.ForeColor = DisabledTextColor
            layoutView.Appearance.FieldCaption.Options.UseForeColor = True
            colDescription.AppearanceCell.ForeColor = DisabledTextColor
            colDescription.AppearanceCell.Options.UseForeColor = True
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
            UnsubscribeProductView()
            MyBase.OnDisposing()
        End Sub

        Public ReadOnly Property ViewModel As ProductCollectionViewModel
            Get
                Return GetViewModel(Of ProductCollectionViewModel)()
            End Get
        End Property

        Public ReadOnly Property ParentViewModel As MainViewModel
            Get
                Return mvvmContext.GetParentViewModel(Of MainViewModel)()
            End Get
        End Property

        Protected Property CollectionPresenter As ProductCollectionPresenter
            Get
                Return _CollectionPresenter
            End Get

            Private Set(ByVal value As ProductCollectionPresenter)
                _CollectionPresenter = value
            End Set
        End Property

        Protected Overridable Function CreateCollectionPresenter() As ProductCollectionPresenter
            Return New ProductCollectionPresenter(gridControl, ViewModel, AddressOf UpdateEntitiesCountRelatedUI)
        End Function

        Protected Overrides Sub OnInitServices()
            mvvmContext.RegisterService("View Settings", New ViewSettingsDialogDocumentManagerService(Function() CollectionUIViewModel))
            mvvmContext.RegisterService(New NotImplementedDetailFormDocumentManagerService(ModuleType.ProductEditView))
        End Sub

        Private Sub BindCommands()
            biNewProduct.BindCommand(Sub() ViewModel.[New](), ViewModel)
            biNewGroup.BindCommand(Sub() ViewModel.GroupSelection(), ViewModel)
            bmiNewProduct.BindCommand(Sub() ViewModel.[New](), ViewModel)
            bmiNewGroup.BindCommand(Sub() ViewModel.GroupSelection(), ViewModel)
            biEdit.BindCommand(Sub(e) ViewModel.Edit(e), ViewModel, Function() ViewModel.SelectedEntity)
            biDelete.BindCommand(Sub(e) ViewModel.Delete(e), ViewModel, Function() ViewModel.SelectedEntity)
            biMap.BindCommand(Sub() ViewModel.ShowMap(), ViewModel)
            biNewCustomFilter.BindCommand(Sub() ViewModel.NewCustomFilter(), ViewModel)
            bmiPrintOrderDetail.BindCommand(Sub() ViewModel.PrintOrderDetail(), ViewModel)
            bmiPrintSalesSummary.BindCommand(Sub() ViewModel.PrintSalesSummary(), ViewModel)
            bmiPrintSpecificationSummary.BindCommand(Sub() ViewModel.PrintSpecificationSummary(), ViewModel)
            BindGalleryQuickReportsItem(0, ProductReportType.OrderDetail)
            BindGalleryQuickReportsItem(1, ProductReportType.SalesSummary)
            BindGalleryQuickReportsItem(2, ProductReportType.SpecificationSummary)
            BindGalleryQuickReportsItem(3, ProductReportType.TopSalesperson)
            biSalesAnalysis.BindCommand(Sub() ViewModel.ShowAnalysis(), ViewModel)
            biViewSettings.BindCommand(Sub() ViewModel.ShowViewSettings(), ViewModel)
        End Sub

        Private Sub BindGalleryQuickReportsItem(ByVal index As Integer, ByVal parameter As ProductReportType)
            galleryQuickReports.Gallery.Groups(0).Items(index).BindCommand(Sub() ViewModel.QuickReport(parameter), ViewModel, Function() parameter)
        End Sub

        Private Sub UpdateEntitiesCountRelatedUI(ByVal count As Integer)
            hiItemsCount.Caption = String.Format("RECORDS: {0}", count)
            UpdateAdditionalButtons(count > 0)
        End Sub

        Private Sub UpdateAdditionalButtons(ByVal hasRecords As Boolean)
            biReverseSort.Enabled = hasRecords
            biExpandCollapse.Enabled = hasRecords AndAlso CollectionUIViewModel.ViewKind = CollectionViewKind.ListView
            biAddColumns.Enabled = biExpandCollapse.Enabled
        End Sub

        Private Sub biExpandCollapse_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            CollectionPresenter.ExpandCollapseGroups()
        End Sub

        Private Sub biAddColumns_ItemCheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            CollectionPresenter.AddColumns(biAddColumns)
        End Sub

        Private Sub biReverseSort_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            CollectionPresenter.ReverseSort(colCategory, colName1)
        End Sub

        Private productView As ProductView

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            UnsubscribeProductView()
            Dim moduleLocator = GetService(Of Services.IModuleLocator)()
            If moduleLocator Is Nothing Then Return
            productView = TryCast(moduleLocator.GetModule(ModuleType.ProductView), ProductView)
            SubscribeProductView()
            EnsureModuleViewModel(productView, ViewModel, ViewModel.SelectedEntityKey)
            productView.Dock = DockStyle.Fill
            productView.Parent = roundedSkinPanelPnlView
            Call FilterPaneHelper.SetupFiltersPane(ParentViewModel, ViewModel, ModuleType.ProductsFilterPane, ModuleType.ProductsFilterPaneCollapsed, navigationRoundedPanel, DefaultNavigationSize, New Action(Of Object, EventArgs)(AddressOf OnFiltersVisibilityChangedCore))
        End Sub

        Public Event FiltersVisibilityChanged As EventHandler Implements ISupportFiltersVisibilityChangedEvent.FiltersVisibilityChanged

        Private ReadOnly Property DefaultNavigationSize As Size
            Get
                Return ScaleDPI.ScaleSize(New Size(180, navigationRoundedPanel.Height))
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

        Private Sub SubscribeProductView()
            If productView IsNot Nothing Then AddHandler productView.ZoomLevelChanged, AddressOf productView_ZoomLevelChanged
        End Sub

        Private Sub UnsubscribeProductView()
            If productView IsNot Nothing Then RemoveHandler productView.ZoomLevelChanged, AddressOf productView_ZoomLevelChanged
        End Sub

        Private Sub InitEditors()
            colCategory.ColumnEdit = EditorHelpers.CreateEnumImageComboBox(Of ProductCategory)(gridControl)
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
            AddHandler CollectionUIViewModel.ViewKindChanged, AddressOf ViewModel_ViewKindChanged
            biShowCard.BindCommand(Sub() CollectionUIViewModel.ShowCard(), CollectionUIViewModel)
            biShowList.BindCommand(Sub() CollectionUIViewModel.ShowList(), CollectionUIViewModel)
            biShowCarousel.BindCommand(Sub() CollectionUIViewModel.ShowCarousel(), CollectionUIViewModel)
            bmiShowCard.BindCommand(Sub() CollectionUIViewModel.ShowCard(), CollectionUIViewModel)
            bmiShowList.BindCommand(Sub() CollectionUIViewModel.ShowList(), CollectionUIViewModel)
            bmiShowCarousel.BindCommand(Sub() CollectionUIViewModel.ShowCarousel(), CollectionUIViewModel)
            biResetView.BindCommand(Sub() CollectionUIViewModel.ResetView(), CollectionUIViewModel)
        End Sub

        Private Sub ViewModel_ViewKindChanged(ByVal sender As Object, ByVal e As EventArgs)
            Select Case CollectionUIViewModel.ViewKind
                Case CollectionViewKind.ListView
                    gridControl.MainView = gridView
                Case CollectionViewKind.CardView
                    layoutView.OptionsView.ViewMode = LayoutViewMode.MultiRow
                    gridControl.MainView = layoutView
                Case CollectionViewKind.Carousel
                    layoutView.OptionsView.ViewMode = LayoutViewMode.Carousel
                    gridControl.MainView = layoutView
            End Select

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
#Region ""
        Private ReadOnly Property Ribbon As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                Return ribbonControl
            End Get
        End Property

#End Region
#Region "ISupportZoom Members"
        Private Property ZoomLevel As Integer Implements ISupportZoom.ZoomLevel
            Get
                Return If(productView IsNot Nothing, productView.ZoomLevel, 100)
            End Get

            Set(ByVal value As Integer)
                If productView IsNot Nothing Then productView.ZoomLevel = value
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

        Private Sub productView_ZoomLevelChanged(ByVal sender As Object, ByVal e As EventArgs)
            RaiseZoomLevelChanged()
        End Sub

        Private Sub RaiseZoomLevelChanged()
            Dim handler = TryCast(Events(zoomLevelChanged), EventHandler)
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

#End Region
        Private Sub gridView_RowStyle(ByVal sender As Object, ByVal e As XtraGrid.Views.Grid.RowStyleEventArgs)
            Dim product As Product = TryCast(gridView.GetRow(e.RowHandle), Product)
            If product IsNot Nothing AndAlso Not product.Available Then e.Appearance.ForeColor = DisabledTextColor
        End Sub

        Private Sub layoutView_CustomDrawCardFieldValue(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs)
            If Not Equals(e.Column.FieldName, colImage.FieldName) Then Return
            e.DefaultDraw()
            e.Cache.DrawRectangle(e.Cache.GetPen(layoutView.Appearance.FieldCaption.ForeColor, ScaleDPI.ScaleHLine(1)), e.Bounds)
            e.Handled = True
        End Sub
#If NET
        protected override AIToolsContext CreateAIToolsContext() {
            return new AIToolsContextBuilder()
                .WithToolTarget(this, "Products module")
                .WithToolTarget(gridControl, "Products Grid Control")
                .WithToolsFromTypes(typeof(GridControlAITools))
                .WithToolMethods(AddProduct)
                .Build();
        }

        [Description("Adds a new product.")]
        public string AddProduct(
            [Description("The product name to be added.")]
            string productName,
            [Description("The product category to be added. Possible values: Automation, Monitors, Projectors, Televisions, VideoPlayers.")]
            string category,
            [Description("The cost of the product.")]
            decimal cost,
            [Description("The sale price of the product.")]
            decimal salePrice,
            [Description("The retail price of the product.")]
            decimal retailPrice) {
            if(category == null)
                throw new Exception("The category is null.");
            if(productName == null)
                throw new Exception("The product name is null.");

            var viewModel = ViewModel;
            var unit = viewModel.UnitOfWorkFactory.CreateUnitOfWork();

            ProductCategory categoryValue;
            if(!Enum.TryParse(category, out categoryValue))
                throw new Exception("Invalid category.");
            var product = new Product() {
                Name = productName,
                Category = categoryValue,
                Available = true,
                ProductionStart = DateTime.Now,
                Cost = cost,
                SalePrice = salePrice,
                RetailPrice = retailPrice,
            };

            unit.Products.Add(product);
            unit.SaveChanges();
            viewModel.Refresh();
            return "Product added successfully.";
        }
#End If
    End Class
End Namespace
