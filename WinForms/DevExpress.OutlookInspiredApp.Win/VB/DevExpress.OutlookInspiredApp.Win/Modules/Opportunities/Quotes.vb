Imports System
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.DevAV.Common.Utils
Imports DevExpress.DevAV.Modules.Helpers
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.Utils.MVVM
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.DevAV.Modules

    Public Partial Class Quotes
        Inherits BaseModuleControl
        Implements IRibbonModule, ISupportFiltersVisibilityChangedEvent

#Region "ViewKind"
        Private _CollectionUIViewModel As CollectionUIViewModel

        Private entitiesBinding As IPropertyBinding

        Public Sub New()
            MyBase.New(GetType(QuoteCollectionViewModel))
            InitializeComponent()
            ConfigurePivot()
            CollectionUIViewModel = Mvvm.POCO.ViewModelSource.Create(Of CollectionUIViewModel)()
            entitiesBinding = mvvmContext.SetBinding(pivotGridControl, Function(p) p.DataSource, "Entities")
            OnReloadEntities()
            AddHandler ViewModel.Reload, AddressOf ViewModel_Reload
            AddHandler ViewModel.EntitiesCountChanged, AddressOf ViewModel_EntitiesCountChanged
            BindCommands()
            InitViewKind()
            InitViewLayout()
            InitEditors()
            SwapFluentIcons(Me)
        End Sub

        Private Sub ConfigurePivot()
            AddHandler pivotGridControl.GridLayout, Sub(s, e) pivotGridControl.Cells.MultiSelection.SetSelection(New Point(-1) {})
        End Sub

        Protected Overrides Sub OnMVVMContextReleasing()
            RemoveHandler ViewModel.EntitiesCountChanged, AddressOf ViewModel_EntitiesCountChanged
            RemoveHandler ViewModel.Reload, AddressOf ViewModel_Reload
        End Sub

        Protected Overrides Sub OnDisposing()
            entitiesBinding.Dispose()
            MyBase.OnDisposing()
        End Sub

        Private Sub ViewModel_Reload(ByVal sender As Object, ByVal e As EventArgs)
            OnReloadEntities()
        End Sub

        Private Sub ViewModel_EntitiesCountChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateEntitiesCountRelatedUI(ViewModel.Entities.Count)
        End Sub

        Private Sub OnReloadEntities()
            UpdateEntitiesCountRelatedUI(ViewModel.Entities.Count)
        End Sub

        Private Sub UpdateEntitiesCountRelatedUI(ByVal count As Integer)
            hiItemsCount.Caption = String.Format("RECORDS: {0}", count)
            UpdateAdditionalButtons(count > 0)
        End Sub

        Public ReadOnly Property ViewModel As QuoteCollectionViewModel
            Get
                Return GetViewModel(Of QuoteCollectionViewModel)()
            End Get
        End Property

        Public ReadOnly Property ParentViewModel As MainViewModel
            Get
                Return mvvmContext.GetParentViewModel(Of MainViewModel)()
            End Get
        End Property

        Protected Overrides Sub OnInitServices()
            mvvmContext.RegisterService("View Settings", New ViewSettingsDialogDocumentManagerService(Function() CollectionUIViewModel))
            mvvmContext.RegisterService(New NotImplementedDetailFormDocumentManagerService(ModuleType.QuoteEditView))
        End Sub

        Private Sub BindCommands()
            biNewQuote.BindCommand(Sub() ViewModel.[New](), ViewModel)
            biNewGroup.Enabled = False
            bmiNewQuote.BindCommand(Sub() ViewModel.[New](), ViewModel)
            bmiNewGroup.Enabled = False
            biEdit.BindCommand(Sub(e) ViewModel.Edit(e), ViewModel, Function() ViewModel.SelectedEntity)
            biDelete.BindCommand(Sub(e) ViewModel.Delete(e), ViewModel, Function() ViewModel.SelectedEntity)
            biMap.BindCommand(Sub() ViewModel.ShowMap(), ViewModel)
            biNewCustomFilter.BindCommand(Sub() ViewModel.NewCustomFilter(), ViewModel)
            bmiPrintInvoice.Enabled = False
            biViewSettings.BindCommand(Sub() ViewModel.ShowViewSettings(), ViewModel)
        End Sub

        Private quoteView As QuoteView

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Dim moduleLocator = GetService(Of Services.IModuleLocator)()
            If moduleLocator Is Nothing Then Return
            quoteView = TryCast(moduleLocator.GetModule(ModuleType.QuoteView), QuoteView)
            EnsureModuleViewModel(quoteView, ViewModel, ViewModel.SelectedEntityKey)
            quoteView.Dock = DockStyle.Fill
            quoteView.Parent = roundedSkinPanelPnlView
            quoteView.DataSource = ViewModel.GetOpportunities()
            Call FilterPaneHelper.SetupFiltersPane(ParentViewModel, ViewModel, ModuleType.QuotesFilterPane, ModuleType.QuotesFilterPaneCollapsed, navigationRoundedPanel, DefaultNavigationSize, New Action(Of Object, EventArgs)(AddressOf OnFiltersVisibilityChangedCore))
        End Sub

        Public Event FiltersVisibilityChanged As EventHandler Implements ISupportFiltersVisibilityChangedEvent.FiltersVisibilityChanged

        Private ReadOnly Property DefaultNavigationSize As Size
            Get
                Return ScaleDPI.ScaleSize(New Size(190, navigationRoundedPanel.Height))
            End Get
        End Property

        Private ReadOnly Property DefaultCollapsedNavigationSize As Size
            Get
                Return ScaleDPI.ScaleSize(New Size(66, navigationRoundedPanel.Height))
            End Get
        End Property

        Protected Overridable Sub OnFiltersVisibilityChangedCore(ByVal sender As Object, ByVal e As EventArgs)
            mainRoundPanel.SuspendLayout()
            Call FilterPaneHelper.SwitchFiltersVisibility(ParentViewModel, navigationRoundedPanel, DefaultNavigationSize, DefaultCollapsedNavigationSize)
            mainRoundPanel.ResumeLayout()
        End Sub

        Public Sub RaiseFiltersVisibilityChanged(ByVal sender As Object, ByVal e As EventArgs) Implements ISupportFiltersVisibilityChangedEvent.RaiseFiltersVisibilityChanged
            OnFiltersVisibilityChangedCore(sender, e)
            RaiseEvent FiltersVisibilityChanged(sender, e)
        End Sub

        Private Sub InitEditors()
            dateTimeChartRangeControlClient.DataProvider.DataSource = ViewModel.GetEntities().ToList()
            dateTimeChartRangeControlClient.DataProvider.ValueDataMember = "Total"
            dateTimeChartRangeControlClient.DataProvider.ArgumentDataMember = "Date"
            AddHandler rangeControl.RangeChanged, AddressOf rangeControl_RangeChanged
        End Sub

        Private Sub rangeControl_RangeChanged(ByVal sender As Object, ByVal range As RangeControlRangeEventArgs)
            Dim min As Date = CDate(range.Range.Minimum)
            Dim max As Date = CDate(range.Range.Maximum)
            ViewModel.FilterExpression = Function(e) e.Date > min AndAlso e.Date < max
            quoteView.DataSource = ViewModel.GetOpportunities()
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
            biShowList.BindCommand(Sub() CollectionUIViewModel.ShowList(), CollectionUIViewModel)
            bmiShowList.BindCommand(Sub() CollectionUIViewModel.ShowList(), CollectionUIViewModel)
            biResetView.BindCommand(Sub() CollectionUIViewModel.ResetView(), CollectionUIViewModel)
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
                    roundedSkinPanelPnlView.Width = ScaleDPI.ScaleHorizontal(400)
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
        Private allExpanded As Boolean = True

        Private Sub UpdateAdditionalButtons(ByVal hasRecords As Boolean)
            biReverseSort.Enabled = hasRecords
            biExpandCollapse.Enabled = hasRecords AndAlso CollectionUIViewModel.ViewKind = CollectionViewKind.ListView
            biAddColumns.Enabled = biExpandCollapse.Enabled
        End Sub

        Private Sub biExpandCollapse_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            If allExpanded Then
                pivotGridControl.CollapseAllRows()
            Else
                pivotGridControl.ExpandAllRows()
            End If

            allExpanded = Not allExpanded
        End Sub

        Private Sub biAddColumns_ItemCheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            If Not biAddColumns.Checked Then
                pivotGridControl.DestroyCustomization()
            Else
                pivotGridControl.FieldsCustomization()
                AddHandler pivotGridControl.HideCustomizationForm, AddressOf pivotGridControl_HideCustomizationForm
            End If
        End Sub

        Private Sub pivotGridControl_HideCustomizationForm(ByVal sender As Object, ByVal e As EventArgs)
            RemoveHandler pivotGridControl.HideCustomizationForm, AddressOf pivotGridControl_HideCustomizationForm
            biAddColumns.Checked = False
        End Sub

        Private Sub biReverseSort_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            pivotGridControl.ChangeFieldSortOrderAsync(fieldCity)
        End Sub

        Private Sub pivotGridControl_CustomCellValue(ByVal sender As Object, ByVal e As XtraPivotGrid.PivotCellValueEventArgs)
            If e.DataField Is fieldPercentage Then e.Value = Convert.ToDouble(e.Value) * 100
        End Sub
    End Class
End Namespace
