Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.DevAV.Common.Utils
Imports DevExpress.DevAV.Modules.Helpers
Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Namespace DevExpress.DevAV.Modules

#If NET
    using DevExpress.AIIntegration.Tools;
    using DevExpress.DevAV.AITools;
#End If
    Public Partial Class Customers
        Inherits BaseModuleControl
        Implements IRibbonModule, ISupportFiltersVisibilityChangedEvent

#If NET
        protected override AIToolsContext CreateAIToolsContext() {
            return new AIToolsContextBuilder()
                .WithToolTarget(gridControl, "Customers Grid Control")
                .WithToolsFromTypes(typeof(GridControlAITools))
                .Build();
        }
#End If
#Region "ViewKind"
        Private _CollectionPresenter As CustomerCollectionPresenter, _CollectionUIViewModel As CollectionUIViewModel

        Private initialColumns As List(Of GridColumn)

        Public Sub New()
            MyBase.New(GetType(CustomerCollectionViewModel))
            InitializeComponent()
            GalleryItemAppearances.Apply(galleryQuickReports)
            layoutView.Appearance.FieldCaption.ForeColor = DisabledTextColor
            layoutView.Appearance.FieldCaption.Options.UseForeColor = True
            lvEmployees.Appearance.FieldCaption.ForeColor = DisabledTextColor
            lvEmployees.Appearance.FieldCaption.Options.UseForeColor = True
            CollectionUIViewModel = Mvvm.POCO.ViewModelSource.Create(Of CollectionUIViewModel)()
            CollectionPresenter = CreateCollectionPresenter()
            CollectionPresenter.ReloadEntities(mvvmContext)
            BindCommands()
            InitViewKind()
            InitViewLayout()
            initialColumns = gridView.Columns.ToList()
            colLogo.ImageOptions.ImageUri.Uri = GetFluentIconName("resource://DevExpress.DevAV.Resources.icon-brand-16.png")
            SwapFluentIcons(Me)
        End Sub

        Protected Overrides Sub OnDisposing()
            CollectionPresenter.Dispose()
            MyBase.OnDisposing()
        End Sub

        Public ReadOnly Property ViewModel As CustomerCollectionViewModel
            Get
                Return GetViewModel(Of CustomerCollectionViewModel)()
            End Get
        End Property

        Public ReadOnly Property ParentViewModel As MainViewModel
            Get
                Return mvvmContext.GetParentViewModel(Of MainViewModel)()
            End Get
        End Property

        Protected Property CollectionPresenter As CustomerCollectionPresenter
            Get
                Return _CollectionPresenter
            End Get

            Private Set(ByVal value As CustomerCollectionPresenter)
                _CollectionPresenter = value
            End Set
        End Property

        Protected Overridable Function CreateCollectionPresenter() As CustomerCollectionPresenter
            Return New CustomerCollectionPresenter(gridControl, ViewModel, AddressOf UpdateEntitiesCountRelatedUI)
        End Function

        Protected Overrides Sub OnInitServices()
            mvvmContext.RegisterService("View Settings", New ViewSettingsDialogDocumentManagerService(Function() CollectionUIViewModel))
            mvvmContext.RegisterService(New NotImplementedDetailFormDocumentManagerService(ModuleType.CustomerEditView))
        End Sub

        Private Sub BindCommands()
            biNewCustomer.BindCommand(Sub() ViewModel.[New](), ViewModel)
            biNewGroup.BindCommand(Sub() ViewModel.GroupSelection(), ViewModel)
            bmiNewCustomer.BindCommand(Sub() ViewModel.[New](), ViewModel)
            bmiNewGroup.BindCommand(Sub() ViewModel.GroupSelection(), ViewModel)
            biEdit.BindCommand(Sub(e) ViewModel.Edit(e), ViewModel, Function() ViewModel.SelectedEntity)
            biDelete.BindCommand(Sub(e) ViewModel.Delete(e), ViewModel, Function() ViewModel.SelectedEntity)
            biMap.BindCommand(Sub() ViewModel.ShowMap(), ViewModel)
            biNewCustomFilter.BindCommand(Sub() ViewModel.NewCustomFilter(), ViewModel)
            bmiPrintProfile.BindCommand(Sub() ViewModel.PrintProfile(), ViewModel)
            bmiPrintContactDirectory.BindCommand(Sub() ViewModel.PrintContactDirectory(), ViewModel)
            bmiPrintSalesSummary.BindCommand(Sub() ViewModel.PrintSalesSummary(), ViewModel)
            bmiPrintSalesDetail.BindCommand(Sub() ViewModel.PrintSalesDetail(), ViewModel)
            BindGalleryQuickReportsItem(0, CustomerReportType.SalesSummary)
            BindGalleryQuickReportsItem(1, CustomerReportType.LocationsDirectory)
            BindGalleryQuickReportsItem(2, CustomerReportType.SelectedContactDirectory)
            biSalesAnalysis.BindCommand(Sub() ViewModel.ShowAnalysis(), ViewModel)
            biViewSettings.BindCommand(Sub() ViewModel.ShowViewSettings(), ViewModel)
        End Sub

        Private Sub BindGalleryQuickReportsItem(ByVal index As Integer, ByVal parameter As CustomerReportType)
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
            CollectionPresenter.ExpandCollapseMasterRows()
        End Sub

        Private Sub biAddColumns_ItemCheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            CollectionPresenter.AddColumns(biAddColumns)
        End Sub

        Private Sub biReverseSort_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            CollectionPresenter.ReverseSort(colName, colName1)
        End Sub

        Private customerView As CustomerView

        Public Event FiltersVisibilityChanged As EventHandler Implements ISupportFiltersVisibilityChangedEvent.FiltersVisibilityChanged

        Private ReadOnly Property DefaultNavigationSize As Size
            Get
                Return ScaleDPI.ScaleSize(New Size(220, navigationRoundedPanel.Height))
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

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Dim moduleLocator = GetService(Of Services.IModuleLocator)()
            If moduleLocator Is Nothing Then Return
            customerView = TryCast(moduleLocator.GetModule(ModuleType.CustomerView), CustomerView)
            EnsureModuleViewModel(customerView, ViewModel, ViewModel.SelectedEntityKey)
            customerView.Dock = DockStyle.Fill
            customerView.Parent = roundedSkinPanelPnlView
            gridView.ExpandMasterRow(0)
            Call FilterPaneHelper.SetupFiltersPane(ParentViewModel, ViewModel, ModuleType.CustomersFilterPane, ModuleType.CustomersFilterPaneCollapsed, navigationRoundedPanel, DefaultNavigationSize, New Action(Of Object, EventArgs)(AddressOf OnFiltersVisibilityChangedCore))
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
            bmiShowCard.BindCommand(Sub() CollectionUIViewModel.ShowCard(), CollectionUIViewModel)
            bmiShowList.BindCommand(Sub() CollectionUIViewModel.ShowList(), CollectionUIViewModel)
            biResetView.BindCommand(Sub() CollectionUIViewModel.ResetView(), CollectionUIViewModel)
        End Sub

        Private Sub ViewModel_ViewKindChanged(ByVal sender As Object, ByVal e As EventArgs)
            If CollectionUIViewModel.ViewKind = CollectionViewKind.CardView Then
                gridControl.MainView = layoutView
            Else
                gridControl.MainView = gridView
                gridView.ExpandMasterRow(0)
            End If

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
        Private Sub lvEmployees_CustomDrawCardFieldValue(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs)
            If Not Equals(e.Column.FieldName, colPhoto.FieldName) Then Return
            e.DefaultDraw()
            e.Cache.DrawRectangle(e.Cache.GetPen(lvEmployees.Appearance.FieldCaption.ForeColor, ScaleDPI.ScaleHLine(1)), e.Bounds)
            e.Handled = True
        End Sub
    End Class
End Namespace
