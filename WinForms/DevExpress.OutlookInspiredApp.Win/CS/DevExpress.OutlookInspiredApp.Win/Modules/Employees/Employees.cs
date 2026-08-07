namespace DevExpress.DevAV.Modules {
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using DevExpress.DevAV;
    using DevExpress.DevAV.Common.Utils;
    using DevExpress.DevAV.Modules.Helpers;
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.ViewModels;
#if NET
    using DevExpress.AIIntegration.Tools;
    using DevExpress.DevAV.AITools;
#endif

    public partial class Employees : BaseModuleControl, IRibbonModule, ISupportFiltersVisibilityChangedEvent {
        public Employees()
            : base(typeof(EmployeeCollectionViewModel)) {
            InitializeComponent();
            GalleryItemAppearances.Apply(galleryQuickLetters);
            layoutView.Appearance.FieldCaption.ForeColor = ColorHelper.DisabledTextColor;
            layoutView.Appearance.FieldCaption.Options.UseForeColor = true;
            
            CollectionUIViewModel = DevExpress.Mvvm.POCO.ViewModelSource.Create<CollectionUIViewModel>();
            CollectionPresenter = CreateCollectionPresenter();
            CollectionPresenter.ReloadEntities(mvvmContext);
            
            BindCommands();
            
            InitViewKind();
            InitViewLayout();
            InitEditors();
            FluentIconHelper.SwapFluentIcons(this);
        }
        protected override void OnDisposing() {
            CollectionPresenter.Dispose();
            base.OnDisposing();
        }
        public EmployeeCollectionViewModel ViewModel {
            get { return GetViewModel<EmployeeCollectionViewModel>(); }
        }
        public MainViewModel ParentViewModel {
            get { return mvvmContext.GetParentViewModel<MainViewModel>(); }
        }
        protected EmployeeCollectionPresenter CollectionPresenter {
            get;
            private set;
        }
        protected virtual EmployeeCollectionPresenter CreateCollectionPresenter() {
            return new EmployeeCollectionPresenter(gridControl, ViewModel, UpdateEntitiesCountRelatedUI);
        }
        protected override void OnInitServices() {
            mvvmContext.RegisterService("View Settings", new ViewSettingsDialogDocumentManagerService(() => CollectionUIViewModel));
            mvvmContext.RegisterService(new DetailFormDocumentManagerService(ModuleType.EmployeeEditView));
        }
        void BindCommands() {
            
            biNewEmployee.BindCommand(() => ViewModel.New(), ViewModel);
            biNewGroup.BindCommand(() => ViewModel.GroupSelection(), ViewModel);
            bmiNewEmployee.BindCommand(() => ViewModel.New(), ViewModel);
            bmiNewGroup.BindCommand(() => ViewModel.GroupSelection(), ViewModel);
            
            biEdit.BindCommand((e) => ViewModel.Edit(e), ViewModel, () => ViewModel.SelectedEntity);
            biDelete.BindCommand((e) => ViewModel.Delete(e), ViewModel, () => ViewModel.SelectedEntity);
            
            biMap.BindCommand(() => ViewModel.ShowMap(), ViewModel);
            
            biNewCustomFilter.BindCommand(() => ViewModel.NewCustomFilter(), ViewModel);
            
            bmiPrintProfile.BindCommand(() => ViewModel.PrintProfile(), ViewModel);
            bmiPrintSummary.BindCommand(() => ViewModel.PrintSummary(), ViewModel);
            bmiPrintDirectory.BindCommand(() => ViewModel.PrintDirectory(), ViewModel);
            bmiPrintTaskList.BindCommand(() => ViewModel.PrintTaskList(), ViewModel);
            
            biMailMerge.BindCommand(() => ViewModel.MailMerge(), ViewModel);
            
            BindGalleryQuickLettersItem(0, EmployeeMailTemplate.ThankYouNote);
            BindGalleryQuickLettersItem(1, EmployeeMailTemplate.EmployeeOfTheMonth);
            BindGalleryQuickLettersItem(2, EmployeeMailTemplate.ServiceExcellence);
            BindGalleryQuickLettersItem(3, EmployeeMailTemplate.ProbationNotice);
            BindGalleryQuickLettersItem(4, EmployeeMailTemplate.WelcomeToDevAV);
            
            biMeeting.BindCommand(() => ViewModel.ShowMeeting(), ViewModel);
            biTask.BindCommand(() => ViewModel.ShowTask(), ViewModel);
            
            biViewSettings.BindCommand(() => ViewModel.ShowViewSettings(), ViewModel);
        }
        void BindGalleryQuickLettersItem(int index, EmployeeMailTemplate parameter) {
            galleryQuickLetters.Gallery.Groups[0].Items[index].BindCommand(() => ViewModel.QuickLetter(parameter), ViewModel, () => parameter);
        }
        void UpdateEntitiesCountRelatedUI(int count) {
            hiItemsCount.Caption = string.Format("Records: {0}", count);
            UpdateAdditionalButtons(count > 0);
        }
        void UpdateAdditionalButtons(bool hasRecords) {
            biReverseSort.Enabled = hasRecords;
            biAddColumns.Enabled = biExpandCollapse.Enabled = hasRecords && (CollectionUIViewModel.ViewKind == CollectionViewKind.ListView);
        }
        void biExpandCollapse_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            CollectionPresenter.ExpandCollapseGroups();
        }
        void biAddColumns_ItemCheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            CollectionPresenter.AddColumns(biAddColumns);
        }
        void biReverseSort_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            CollectionPresenter.ReverseSort(colDepartment, colFullName1);
        }
        EmployeeView employeeView;
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            var moduleLocator = GetService<Services.IModuleLocator>();
            if(moduleLocator == null)
                return;
            employeeView = moduleLocator.GetModule(ModuleType.EmployeeView) as EmployeeView;
            ViewModelHelper.EnsureModuleViewModel(employeeView, ViewModel, ViewModel.SelectedEntityKey);
            employeeView.Dock = DockStyle.Fill;
            employeeView.Parent = roundedSkinPanelPnlView;

            FilterPaneHelper.SetupFiltersPane(
                ParentViewModel,
                ViewModel,
                ModuleType.EmployeesFilterPane,
                ModuleType.EmployeesFilterPaneCollapsed,
                navigationRoundedPanel,
                DefaultNavigationSize,
                OnFiltersVisibilityChangedCore
            );
            initWidth = Width;
            initPnlWidth = roundedSkinPanelPnlView.Width;
        }

        public event EventHandler FiltersVisibilityChanged;

        Size DefaultNavigationSize {
            get { return ScaleDPI.ScaleSize(new Size(190, navigationRoundedPanel.Height)); }
        }
        Size DefaultCollapsedNavigationSize {
            get { return ScaleDPI.ScaleSize(new Size(66, navigationRoundedPanel.Height)); }
        }

        protected virtual void OnFiltersVisibilityChangedCore(object sender, EventArgs e) {
            mainRoundedPanel.SuspendLayout();
            FilterPaneHelper.SwitchFiltersVisibility(ParentViewModel, navigationRoundedPanel, DefaultNavigationSize, DefaultCollapsedNavigationSize);
            mainRoundedPanel.ResumeLayout();
        }
        public void RaiseFiltersVisibilityChanged(object sender, EventArgs e) {
            OnFiltersVisibilityChangedCore(sender, e);
            if(FiltersVisibilityChanged != null)
                FiltersVisibilityChanged.Invoke(sender, e);
        }
#if NET
        protected override AIToolsContext CreateAIToolsContext() {
            return new AIToolsContextBuilder()
                .WithToolTarget(gridControl, "Employees Grid Control")
                .WithToolsFromTypes(typeof(GridControlAITools))
                .Build();
        }
#endif
        void InitEditors() {
            colPrefix.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            colPrefix.ImageOptions.ImageUri.Uri = FluentIconHelper.GetFluentIconName("resource://DevExpress.DevAV.Resources.icon-prefix-16.png");
            colPrefix.ColumnEdit = EditorHelpers.CreatePersonPrefixImageComboBox(null, gridControl.RepositoryItems);
        }
        #region ViewKind
        protected CollectionUIViewModel CollectionUIViewModel { get; private set; }
        void InitViewKind() {
            CollectionUIViewModel.ViewKindChanged += ViewModel_ViewKindChanged;
            biShowCard.BindCommand(() => CollectionUIViewModel.ShowCard(), CollectionUIViewModel);
            biShowList.BindCommand(() => CollectionUIViewModel.ShowList(), CollectionUIViewModel);
            bmiShowCard.BindCommand(() => CollectionUIViewModel.ShowCard(), CollectionUIViewModel);
            bmiShowList.BindCommand(() => CollectionUIViewModel.ShowList(), CollectionUIViewModel);
            biResetView.BindCommand(() => CollectionUIViewModel.ResetView(), CollectionUIViewModel);
        }
        void ViewModel_ViewKindChanged(object sender, System.EventArgs e) {
            if(CollectionUIViewModel.ViewKind == CollectionViewKind.CardView)
                gridControl.MainView = layoutView;
            else
                gridControl.MainView = gridView;
            UpdateAdditionalButtons(ViewModel.Entities.Count > 0);
            GridHelper.SetFindControlImages(gridControl);
        }
        #endregion
        #region ViewLayout
        void InitViewLayout() {
            CollectionUIViewModel.ViewLayoutChanged += ViewModel_ViewLayoutChanged;
            bmiHorizontalLayout.BindCommand(() => CollectionUIViewModel.ShowHorizontalLayout(), CollectionUIViewModel);
            bmiVerticalLayout.BindCommand(() => CollectionUIViewModel.ShowVerticalLayout(), CollectionUIViewModel);
            bmiHideDetail.BindCommand(() => CollectionUIViewModel.HideDetail(), CollectionUIViewModel);
        }
        void ViewModel_ViewLayoutChanged(object sender, System.EventArgs e) {
            bool detailHidden = CollectionUIViewModel.IsDetailHidden;
            roundedSkinPanelPnlView.Visible = !detailHidden;
            if(!detailHidden) {
                roundedSkinPanelPnlView.Dock = CollectionUIViewModel.IsHorizontalLayout ? DockStyle.Right : DockStyle.Bottom;
                if(CollectionUIViewModel.IsHorizontalLayout) {
                    roundedSkinPanelPnlView.Width = ScaleDPI.ScaleHorizontal(500);
                }
                else {
                    roundedSkinPanelPnlView.Height = ScaleDPI.ScaleHorizontal(400);
                }
            }
        }
        #endregion
        #region
        XtraBars.Ribbon.RibbonControl IRibbonModule.Ribbon { get { return ribbonControl; } }
        #endregion

        int initPnlWidth, initWidth;
        protected override void OnLayout(LayoutEventArgs e) {
            base.OnLayout(e);
            if(initWidth > 0)
                roundedSkinPanelPnlView.Width = initPnlWidth * Width / initWidth;
        }
    }
}
