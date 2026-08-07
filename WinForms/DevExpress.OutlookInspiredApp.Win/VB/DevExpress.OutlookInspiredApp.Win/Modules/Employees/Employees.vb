Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DevAV.Common.Utils
Imports DevExpress.DevAV.Modules.Helpers
Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV.ViewModels

Namespace DevExpress.DevAV.Modules

#If NET
    using DevExpress.AIIntegration.Tools;
    using DevExpress.DevAV.AITools;
#End If
    Public Partial Class Employees
        Inherits BaseModuleControl
        Implements IRibbonModule, ISupportFiltersVisibilityChangedEvent

#Region "ViewKind"
        Private _CollectionPresenter As EmployeeCollectionPresenter, _CollectionUIViewModel As CollectionUIViewModel

        Public Sub New()
            MyBase.New(GetType(EmployeeCollectionViewModel))
            InitializeComponent()
            GalleryItemAppearances.Apply(galleryQuickLetters)
            layoutView.Appearance.FieldCaption.ForeColor = DisabledTextColor
            layoutView.Appearance.FieldCaption.Options.UseForeColor = True
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
            MyBase.OnDisposing()
        End Sub

        Public ReadOnly Property ViewModel As EmployeeCollectionViewModel
            Get
                Return GetViewModel(Of EmployeeCollectionViewModel)()
            End Get
        End Property

        Public ReadOnly Property ParentViewModel As MainViewModel
            Get
                Return mvvmContext.GetParentViewModel(Of MainViewModel)()
            End Get
        End Property

        Protected Property CollectionPresenter As EmployeeCollectionPresenter
            Get
                Return _CollectionPresenter
            End Get

            Private Set(ByVal value As EmployeeCollectionPresenter)
                _CollectionPresenter = value
            End Set
        End Property

        Protected Overridable Function CreateCollectionPresenter() As EmployeeCollectionPresenter
            Return New EmployeeCollectionPresenter(gridControl, ViewModel, AddressOf UpdateEntitiesCountRelatedUI)
        End Function

        Protected Overrides Sub OnInitServices()
            mvvmContext.RegisterService("View Settings", New ViewSettingsDialogDocumentManagerService(Function() CollectionUIViewModel))
            mvvmContext.RegisterService(New DetailFormDocumentManagerService(ModuleType.EmployeeEditView))
        End Sub

        Private Sub BindCommands()
            biNewEmployee.BindCommand(Sub() ViewModel.[New](), ViewModel)
            biNewGroup.BindCommand(Sub() ViewModel.GroupSelection(), ViewModel)
            bmiNewEmployee.BindCommand(Sub() ViewModel.[New](), ViewModel)
            bmiNewGroup.BindCommand(Sub() ViewModel.GroupSelection(), ViewModel)
            biEdit.BindCommand(Sub(e) ViewModel.Edit(e), ViewModel, Function() ViewModel.SelectedEntity)
            biDelete.BindCommand(Sub(e) ViewModel.Delete(e), ViewModel, Function() ViewModel.SelectedEntity)
            biMap.BindCommand(Sub() ViewModel.ShowMap(), ViewModel)
            biNewCustomFilter.BindCommand(Sub() ViewModel.NewCustomFilter(), ViewModel)
            bmiPrintProfile.BindCommand(Sub() ViewModel.PrintProfile(), ViewModel)
            bmiPrintSummary.BindCommand(Sub() ViewModel.PrintSummary(), ViewModel)
            bmiPrintDirectory.BindCommand(Sub() ViewModel.PrintDirectory(), ViewModel)
            bmiPrintTaskList.BindCommand(Sub() ViewModel.PrintTaskList(), ViewModel)
            biMailMerge.BindCommand(Sub() ViewModel.MailMerge(), ViewModel)
            BindGalleryQuickLettersItem(0, EmployeeMailTemplate.ThankYouNote)
            BindGalleryQuickLettersItem(1, EmployeeMailTemplate.EmployeeOfTheMonth)
            BindGalleryQuickLettersItem(2, EmployeeMailTemplate.ServiceExcellence)
            BindGalleryQuickLettersItem(3, EmployeeMailTemplate.ProbationNotice)
            BindGalleryQuickLettersItem(4, EmployeeMailTemplate.WelcomeToDevAV)
            biMeeting.BindCommand(Sub() ViewModel.ShowMeeting(), ViewModel)
            biTask.BindCommand(Sub() ViewModel.ShowTask(), ViewModel)
            biViewSettings.BindCommand(Sub() ViewModel.ShowViewSettings(), ViewModel)
        End Sub

        Private Sub BindGalleryQuickLettersItem(ByVal index As Integer, ByVal parameter As EmployeeMailTemplate)
            galleryQuickLetters.Gallery.Groups(0).Items(index).BindCommand(Sub() ViewModel.QuickLetter(parameter), ViewModel, Function() parameter)
        End Sub

        Private Sub UpdateEntitiesCountRelatedUI(ByVal count As Integer)
            hiItemsCount.Caption = String.Format("Records: {0}", count)
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
            CollectionPresenter.ReverseSort(colDepartment, colFullName1)
        End Sub

        Private employeeView As EmployeeView

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Dim moduleLocator = GetService(Of Services.IModuleLocator)()
            If moduleLocator Is Nothing Then Return
            employeeView = TryCast(moduleLocator.GetModule(ModuleType.EmployeeView), EmployeeView)
            EnsureModuleViewModel(employeeView, ViewModel, ViewModel.SelectedEntityKey)
            employeeView.Dock = DockStyle.Fill
            employeeView.Parent = roundedSkinPanelPnlView
            Call FilterPaneHelper.SetupFiltersPane(ParentViewModel, ViewModel, ModuleType.EmployeesFilterPane, ModuleType.EmployeesFilterPaneCollapsed, navigationRoundedPanel, DefaultNavigationSize, New Action(Of Object, EventArgs)(AddressOf OnFiltersVisibilityChangedCore))
            initWidth = Width
            initPnlWidth = roundedSkinPanelPnlView.Width
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
            mainRoundedPanel.SuspendLayout()
            Call FilterPaneHelper.SwitchFiltersVisibility(ParentViewModel, navigationRoundedPanel, DefaultNavigationSize, DefaultCollapsedNavigationSize)
            mainRoundedPanel.ResumeLayout()
        End Sub

        Public Sub RaiseFiltersVisibilityChanged(ByVal sender As Object, ByVal e As EventArgs) Implements ISupportFiltersVisibilityChangedEvent.RaiseFiltersVisibilityChanged
            OnFiltersVisibilityChangedCore(sender, e)
            RaiseEvent FiltersVisibilityChanged(sender, e)
        End Sub

#If NET
        protected override AIToolsContext CreateAIToolsContext() {
            return new AIToolsContextBuilder()
                .WithToolTarget(gridControl, "Employees Grid Control")
                .WithToolsFromTypes(typeof(GridControlAITools))
                .Build();
        }
#End If
        Private Sub InitEditors()
            colPrefix.ImageOptions.ImageUri.ResourceType = GetType(DevAV.MainForm)
            colPrefix.ImageOptions.ImageUri.Uri = GetFluentIconName("resource://DevExpress.DevAV.Resources.icon-prefix-16.png")
            colPrefix.ColumnEdit = EditorHelpers.CreatePersonPrefixImageComboBox(Nothing, gridControl.RepositoryItems)
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
        Private initPnlWidth, initWidth As Integer

        Protected Overrides Sub OnLayout(ByVal e As LayoutEventArgs)
            MyBase.OnLayout(e)
            If initWidth > 0 Then roundedSkinPanelPnlView.Width = initPnlWidth * Width \ initWidth
        End Sub
    End Class
End Namespace
