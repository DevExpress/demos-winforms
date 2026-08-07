using System;
using System.Windows.Forms;
using DevExpress.DevAV.Presenters;
using DevExpress.DevAV.ViewModels;
using DevExpress.XtraBars;
using DevExpress.XtraGantt;
using DevExpress.XtraLayout.Utils;

namespace DevExpress.DevAV.Modules {
    public partial class Tasks : BaseModuleControl, IRibbonModule {
        public Tasks() : base(typeof(TaskCollectionViewModel)) {
            InitializeComponent();
            ganttControl.EnableDynamicLoading = false;
            ganttControl.TreeListMappings.KeyFieldName = "Id";
            ganttControl.TreeListMappings.ParentFieldName = "ParentId";
            ganttControl.ChartMappings.StartDateFieldName = "StartDate";
            ganttControl.ChartMappings.FinishDateFieldName = "DueDate";
            ganttControl.ChartMappings.ProgressFieldName = "Completion";
            ganttControl.ChartMappings.PredecessorsFieldName = "Predecessors";
            

            CollectionUIViewModel = Mvvm.POCO.ViewModelSource.Create<CollectionUIViewModel>();
            CollectionPresenter = CreateCollectionPresenter();
            CollectionPresenter.ReloadEntities(mvvmContext);
            BindCommands();

            InitViewKind();
            InitViewLayout();
        }
        protected override void OnDisposing() {
            CollectionPresenter.Dispose();
            base.OnDisposing();
        }
        #region ViewKind
        void InitViewKind() {
            biResetView.BindCommand(() => CollectionUIViewModel.ResetView(), CollectionUIViewModel);
        }
        #endregion

        void InitViewLayout() {
            CollectionUIViewModel.ViewLayoutChanged += ViewModel_ViewLayoutChanged;
            bmiHorizontalLayout.BindCommand(() => CollectionUIViewModel.ShowHorizontalLayout(), CollectionUIViewModel);
            bmiVerticalLayout.BindCommand(() => CollectionUIViewModel.ShowVerticalLayout(), CollectionUIViewModel);
            bmiHideDetail.BindCommand(() => CollectionUIViewModel.HideDetail(), CollectionUIViewModel);
            InitViewMenuItems();
        }
        void ViewModel_ViewLayoutChanged(object sender, EventArgs e) {
            bool detailHidden = CollectionUIViewModel.IsDetailHidden;
            roundedSkinPanelPnlView.Visible = !detailHidden;
            if(!detailHidden) {
                roundedSkinPanelPnlView.Dock = CollectionUIViewModel.IsHorizontalLayout ? DockStyle.Right : DockStyle.Bottom;
                if(CollectionUIViewModel.IsHorizontalLayout) {
                    roundedSkinPanelPnlView.Width = ScaleDPI.ScaleHorizontal(400);
                }
                else {
                    roundedSkinPanelPnlView.Height = ScaleDPI.ScaleHorizontal(400);
                }
            }
        }
        public TaskCollectionViewModel ViewModel {
            get { return GetViewModel<TaskCollectionViewModel>(); }
        }
        protected CollectionUIViewModel CollectionUIViewModel { get; private set; }
        protected TasksCollectionPresenter CollectionPresenter { get; private set; }
        GanttControlOptionsSplitter OptionsSplitter {
            get {
                if(ganttControl != null)
                    return ganttControl.OptionsSplitter;
                return null;
            }
        }
        protected virtual TasksCollectionPresenter CreateCollectionPresenter() {
            return new TasksCollectionPresenter(ganttControl, ViewModel, UpdateEntitiesCountRelatedUI);
        }
        protected override void OnInitServices() {
            mvvmContext.RegisterService("View Settings", new ViewSettingsDialogDocumentManagerService(() => CollectionUIViewModel));
            mvvmContext.RegisterService(new DetailFormDocumentManagerService(ModuleType.TaskEditView));
        }
        void UpdateEntitiesCountRelatedUI(int count) {
            hiItemsCount.Caption = string.Format("Records: {0}", count);
        }
        XtraBars.Ribbon.RibbonControl IRibbonModule.Ribbon {
            get { return ribbonControl; }
        }
        TaskView taskView;
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            var moduleLocator = GetService<Services.IModuleLocator>();
            taskView = moduleLocator.GetModule(ModuleType.TaskView) as TaskView;
            ViewModelHelper.EnsureModuleViewModel(taskView, ViewModel, ViewModel.SelectedEntityKey);
            taskView.Dock = DockStyle.Fill;
            taskView.Parent = roundedSkinPanelPnlView;
        }
        void OnAllowResizeDownChanged(object sender, ItemClickEventArgs e) {
            var checkItem = e.Item as BarButtonItem;
            if(OptionsSplitter != null && checkItem != null)
                OptionsSplitter.AllowResize = checkItem.Down;
        }
        void bciPanelVisibilityDefault_PanelVisibilityItemClick(object sender, ItemClickEventArgs e) {
            ApplyPanelVisibility(e.Item.ToString());
        }
        void bciPanelVisibilityChart_PanelVisibilityItemClick(object sender, ItemClickEventArgs e) {
            ApplyPanelVisibility(e.Item.ToString());
        }
        void bciPanelVisibilityTree_PanelVisibilityItemClick(object sender, ItemClickEventArgs e) {
            ApplyPanelVisibility(e.Item.ToString());
        }
        void bciPanelVisibilityBoth_PanelVisibilityItemClick(object sender, ItemClickEventArgs e) {
            ApplyPanelVisibility(e.Item.ToString());
        }
        void bciFixedPanelDefault_FixedPanelItemClick(object sender, ItemClickEventArgs e) {
            ApplyFixedPanel(e.Item.ToString());
        }
        void bciFixedPanelChart_FixedPanelItemClick(object sender, ItemClickEventArgs e) {
            ApplyFixedPanel(e.Item.ToString());
        }
        void bciFixedPanelNone_FixedPanelItemClick(object sender, ItemClickEventArgs e) {
            ApplyFixedPanel(e.Item.ToString());
        }
        void bciFixedPanelTree_FixedPanelItemClick(object sender, ItemClickEventArgs e) {
            ApplyFixedPanel(e.Item.ToString());
        }
        void ApplyPanelVisibility(string name) {
            if(OptionsSplitter != null)
                OptionsSplitter.PanelVisibility = (GanttPanelVisibility)Enum.Parse(typeof(GanttPanelVisibility), name);
        }
        void ApplyFixedPanel(string name) {
            if(OptionsSplitter != null)
                OptionsSplitter.FixedPanel = (GanttFixedPanel)Enum.Parse(typeof(GanttFixedPanel), name);
        }
        void InitViewMenuItems() {
            biAllowResize.Down = OptionsSplitter.AllowResize;
            switch(OptionsSplitter.FixedPanel) {
                case GanttFixedPanel.Default:
                    bciFixedPanelDefault.Checked = true;
                    break;
                case GanttFixedPanel.Tree:
                    bciFixedPanelTree.Checked = true;
                    break;
                case GanttFixedPanel.Chart:
                    bciFixedPanelChart.Checked = true;
                    break;
                case GanttFixedPanel.None:
                    bciFixedPanelNone.Checked = true;
                    break;
            }
            switch(OptionsSplitter.PanelVisibility) {
                case GanttPanelVisibility.Default:
                    bciPanelVisibilityDefault.Checked = true;
                    break;
                case GanttPanelVisibility.Tree:
                    bciPanelVisibilityTree.Checked = true;
                    break;
                case GanttPanelVisibility.Chart:
                    bciPanelVisibilityChart.Checked = true;
                    break;
                case GanttPanelVisibility.Both:
                    bciPanelVisibilityBoth.Checked = true;
                    break;
            }
        }
        void BindCommands() {
            biNewTask.BindCommand(() => ViewModel.New(), ViewModel);
            biEdit.BindCommand((e) => ViewModel.Edit(e), ViewModel, () => ViewModel.SelectedEntity);
            biDelete.BindCommand((e) => ViewModel.Delete(e), ViewModel, () => ViewModel.SelectedEntity);
            biViewSettings.BindCommand(() => ViewModel.ShowViewSettings(), ViewModel);
        }
    }
}
