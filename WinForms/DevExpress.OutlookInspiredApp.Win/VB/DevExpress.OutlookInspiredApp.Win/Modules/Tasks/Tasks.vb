Imports System
Imports System.Windows.Forms
Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraBars
Imports DevExpress.XtraGantt
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.DevAV.Modules

    Public Partial Class Tasks
        Inherits BaseModuleControl
        Implements IRibbonModule

        Private _CollectionUIViewModel As CollectionUIViewModel, _CollectionPresenter As TasksCollectionPresenterType

        Public Sub New()
            MyBase.New(GetType(TaskCollectionViewModel))
            InitializeComponent()
            ganttControl.EnableDynamicLoading = False
            ganttControl.TreeListMappings.KeyFieldName = "Id"
            ganttControl.TreeListMappings.ParentFieldName = "ParentId"
            ganttControl.ChartMappings.StartDateFieldName = "StartDate"
            ganttControl.ChartMappings.FinishDateFieldName = "DueDate"
            ganttControl.ChartMappings.ProgressFieldName = "Completion"
            ganttControl.ChartMappings.PredecessorsFieldName = "Predecessors"
            CollectionUIViewModel = Mvvm.POCO.ViewModelSource.Create(Of CollectionUIViewModel)()
            CollectionPresenter = CreateCollectionPresenter()
            CollectionPresenter.ReloadEntities(mvvmContext)
            BindCommands()
            InitViewKind()
            InitViewLayout()
        End Sub

        Protected Overrides Sub OnDisposing()
            CollectionPresenter.Dispose()
            MyBase.OnDisposing()
        End Sub

#Region "ViewKind"
        Private Sub InitViewKind()
            biResetView.BindCommand(Sub() CollectionUIViewModel.ResetView(), CollectionUIViewModel)
        End Sub

#End Region
        Private Sub InitViewLayout()
            AddHandler CollectionUIViewModel.ViewLayoutChanged, AddressOf Me.ViewModel_ViewLayoutChanged
            bmiHorizontalLayout.BindCommand(Sub() CollectionUIViewModel.ShowHorizontalLayout(), CollectionUIViewModel)
            bmiVerticalLayout.BindCommand(Sub() CollectionUIViewModel.ShowVerticalLayout(), CollectionUIViewModel)
            bmiHideDetail.BindCommand(Sub() CollectionUIViewModel.HideDetail(), CollectionUIViewModel)
            InitViewMenuItems()
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

        Public ReadOnly Property ViewModel As TaskCollectionViewModel
            Get
                Return GetViewModel(Of TaskCollectionViewModel)()
            End Get
        End Property

        Protected Property CollectionUIViewModel As CollectionUIViewModel
            Get
                Return _CollectionUIViewModel
            End Get

            Private Set(ByVal value As CollectionUIViewModel)
                _CollectionUIViewModel = value
            End Set
        End Property

        Protected Property CollectionPresenter As TasksCollectionPresenterType
            Get
                Return _CollectionPresenter
            End Get

            Private Set(ByVal value As TasksCollectionPresenterType)
                _CollectionPresenter = value
            End Set
        End Property

        Private ReadOnly Property OptionsSplitter As GanttControlOptionsSplitter
            Get
                If ganttControl IsNot Nothing Then Return ganttControl.OptionsSplitter
                Return Nothing
            End Get
        End Property

        Protected Overridable Function CreateCollectionPresenter() As TasksCollectionPresenterType
            Return New TasksCollectionPresenterType(ganttControl, ViewModel, AddressOf UpdateEntitiesCountRelatedUI)
        End Function

        Protected Overrides Sub OnInitServices()
            mvvmContext.RegisterService("View Settings", New ViewSettingsDialogDocumentManagerService(Function() CollectionUIViewModel))
            mvvmContext.RegisterService(New DetailFormDocumentManagerService(ModuleType.TaskEditView))
        End Sub

        Private Sub UpdateEntitiesCountRelatedUI(ByVal count As Integer)
            hiItemsCount.Caption = String.Format("Records: {0}", count)
        End Sub

        Private ReadOnly Property Ribbon As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                Return ribbonControl
            End Get
        End Property

        Private taskView As TaskView

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Dim moduleLocator = GetService(Of Services.IModuleLocator)()
            taskView = TryCast(moduleLocator.GetModule(ModuleType.TaskView), TaskView)
            EnsureModuleViewModel(taskView, ViewModel, ViewModel.SelectedEntityKey)
            taskView.Dock = DockStyle.Fill
            taskView.Parent = roundedSkinPanelPnlView
        End Sub

        Private Sub OnAllowResizeDownChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim checkItem = TryCast(e.Item, BarButtonItem)
            If OptionsSplitter IsNot Nothing AndAlso checkItem IsNot Nothing Then OptionsSplitter.AllowResize = checkItem.Down
        End Sub

        Private Sub bciPanelVisibilityDefault_PanelVisibilityItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            ApplyPanelVisibility(e.Item.ToString())
        End Sub

        Private Sub bciPanelVisibilityChart_PanelVisibilityItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            ApplyPanelVisibility(e.Item.ToString())
        End Sub

        Private Sub bciPanelVisibilityTree_PanelVisibilityItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            ApplyPanelVisibility(e.Item.ToString())
        End Sub

        Private Sub bciPanelVisibilityBoth_PanelVisibilityItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            ApplyPanelVisibility(e.Item.ToString())
        End Sub

        Private Sub bciFixedPanelDefault_FixedPanelItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            ApplyFixedPanel(e.Item.ToString())
        End Sub

        Private Sub bciFixedPanelChart_FixedPanelItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            ApplyFixedPanel(e.Item.ToString())
        End Sub

        Private Sub bciFixedPanelNone_FixedPanelItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            ApplyFixedPanel(e.Item.ToString())
        End Sub

        Private Sub bciFixedPanelTree_FixedPanelItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            ApplyFixedPanel(e.Item.ToString())
        End Sub

        Private Sub ApplyPanelVisibility(ByVal name As String)
            If OptionsSplitter IsNot Nothing Then OptionsSplitter.PanelVisibility = CType([Enum].Parse(GetType(GanttPanelVisibility), name), GanttPanelVisibility)
        End Sub

        Private Sub ApplyFixedPanel(ByVal name As String)
            If OptionsSplitter IsNot Nothing Then OptionsSplitter.FixedPanel = CType([Enum].Parse(GetType(GanttFixedPanel), name), GanttFixedPanel)
        End Sub

        Private Sub InitViewMenuItems()
            biAllowResize.Down = OptionsSplitter.AllowResize
            Select Case OptionsSplitter.FixedPanel
                Case GanttFixedPanel.Default
                    bciFixedPanelDefault.Checked = True
                Case GanttFixedPanel.Tree
                    bciFixedPanelTree.Checked = True
                Case GanttFixedPanel.Chart
                    bciFixedPanelChart.Checked = True
                Case GanttFixedPanel.None
                    bciFixedPanelNone.Checked = True
            End Select

            Select Case OptionsSplitter.PanelVisibility
                Case GanttPanelVisibility.Default
                    bciPanelVisibilityDefault.Checked = True
                Case GanttPanelVisibility.Tree
                    bciPanelVisibilityTree.Checked = True
                Case GanttPanelVisibility.Chart
                    bciPanelVisibilityChart.Checked = True
                Case GanttPanelVisibility.Both
                    bciPanelVisibilityBoth.Checked = True
            End Select
        End Sub

        Private Sub BindCommands()
            biNewTask.BindCommand(Sub() ViewModel.[New](), ViewModel)
            biEdit.BindCommand(Sub(e) ViewModel.Edit(e), ViewModel, Function() ViewModel.SelectedEntity)
            biDelete.BindCommand(Sub(e) ViewModel.Delete(e), ViewModel, Function() ViewModel.SelectedEntity)
            biViewSettings.BindCommand(Sub() ViewModel.ShowViewSettings(), ViewModel)
        End Sub
    End Class
End Namespace
