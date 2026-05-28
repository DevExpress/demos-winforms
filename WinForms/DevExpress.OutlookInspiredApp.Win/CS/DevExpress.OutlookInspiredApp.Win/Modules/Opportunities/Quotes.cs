namespace DevExpress.DevAV.Modules {
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using DevExpress.DevAV.Common.Utils;
    using DevExpress.DevAV.Modules.Helpers;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Utils.MVVM;
    using DevExpress.XtraEditors;
    using DevExpress.XtraLayout.Utils;

    public partial class Quotes : BaseModuleControl, IRibbonModule, ISupportFiltersVisibilityChangedEvent {
        IPropertyBinding entitiesBinding;
        public Quotes()
            : base(typeof(QuoteCollectionViewModel)) {
            InitializeComponent();
            ConfigurePivot();
            CollectionUIViewModel = DevExpress.Mvvm.POCO.ViewModelSource.Create<CollectionUIViewModel>();
            
            entitiesBinding = mvvmContext.SetBinding(pivotGridControl, p => p.DataSource, "Entities");
            OnReloadEntities();
            ViewModel.Reload += ViewModel_Reload;
            ViewModel.EntitiesCountChanged += ViewModel_EntitiesCountChanged;
            
            BindCommands();
            
            InitViewKind();
            InitViewLayout();
            InitEditors();
            FluentIconHelper.SwapFluentIcons(this);
        }
        void ConfigurePivot() {
            pivotGridControl.GridLayout += (s, e) => {
                pivotGridControl.Cells.MultiSelection.SetSelection(new Point[0]);
            };
        }
        protected override void OnMVVMContextReleasing() {
            ViewModel.EntitiesCountChanged -= ViewModel_EntitiesCountChanged;
            ViewModel.Reload -= ViewModel_Reload;
        }
        protected override void OnDisposing() {
            entitiesBinding.Dispose();
            base.OnDisposing();
        }
        void ViewModel_Reload(object sender, System.EventArgs e) {
            OnReloadEntities();
        }
        void ViewModel_EntitiesCountChanged(object sender, System.EventArgs e) {
            UpdateEntitiesCountRelatedUI(ViewModel.Entities.Count);
        }
        void OnReloadEntities() {
            UpdateEntitiesCountRelatedUI(ViewModel.Entities.Count);
        }
        void UpdateEntitiesCountRelatedUI(int count) {
            hiItemsCount.Caption = string.Format("RECORDS: {0}", count);
            UpdateAdditionalButtons(count > 0);
        }
        public QuoteCollectionViewModel ViewModel {
            get { return GetViewModel<QuoteCollectionViewModel>(); }
        }
        public MainViewModel ParentViewModel {
            get { return mvvmContext.GetParentViewModel<MainViewModel>(); }
        }
        protected override void OnInitServices() {
            mvvmContext.RegisterService("View Settings", new ViewSettingsDialogDocumentManagerService(() => CollectionUIViewModel));
            mvvmContext.RegisterService(new NotImplementedDetailFormDocumentManagerService(ModuleType.QuoteEditView));
        }
        void BindCommands() {
            
            biNewQuote.BindCommand(() => ViewModel.New(), ViewModel);
            biNewGroup.Enabled = false;
            bmiNewQuote.BindCommand(() => ViewModel.New(), ViewModel);
            bmiNewGroup.Enabled = false;
            
            biEdit.BindCommand((e) => ViewModel.Edit(e), ViewModel, () => ViewModel.SelectedEntity);
            biDelete.BindCommand((e) => ViewModel.Delete(e), ViewModel, () => ViewModel.SelectedEntity);
            
            biMap.BindCommand(() => ViewModel.ShowMap(), ViewModel);
            
            biNewCustomFilter.BindCommand(() => ViewModel.NewCustomFilter(), ViewModel);
            
            bmiPrintInvoice.Enabled = false;
            
            biViewSettings.BindCommand(() => ViewModel.ShowViewSettings(), ViewModel);
        }
        QuoteView quoteView;
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            var moduleLocator = GetService<Services.IModuleLocator>();
            if(moduleLocator == null)
                return;
            quoteView = moduleLocator.GetModule(ModuleType.QuoteView) as QuoteView;
            ViewModelHelper.EnsureModuleViewModel(quoteView, ViewModel, ViewModel.SelectedEntityKey);
            quoteView.Dock = DockStyle.Fill;
            quoteView.Parent = roundedSkinPanelPnlView;
            quoteView.DataSource = ViewModel.GetOpportunities();

            FilterPaneHelper.SetupFiltersPane(
                ParentViewModel,
                ViewModel,
                ModuleType.QuotesFilterPane,
                ModuleType.QuotesFilterPaneCollapsed,
                navigationRoundedPanel,
                DefaultNavigationSize,
                OnFiltersVisibilityChangedCore
            );
        }

        public event EventHandler FiltersVisibilityChanged;

        Size DefaultNavigationSize {
            get { return ScaleDPI.ScaleSize(new Size(190, navigationRoundedPanel.Height)); }
        }
        Size DefaultCollapsedNavigationSize {
            get { return ScaleDPI.ScaleSize(new Size(66, navigationRoundedPanel.Height)); }
        }

        protected virtual void OnFiltersVisibilityChangedCore(object sender, EventArgs e) {
            mainRoundPanel.SuspendLayout();
            FilterPaneHelper.SwitchFiltersVisibility(ParentViewModel, navigationRoundedPanel, DefaultNavigationSize, DefaultCollapsedNavigationSize);
            mainRoundPanel.ResumeLayout();
        }
        public void RaiseFiltersVisibilityChanged(object sender, EventArgs e) {
            OnFiltersVisibilityChangedCore(sender, e);
            if(FiltersVisibilityChanged != null)
                FiltersVisibilityChanged.Invoke(sender, e);
        }
        void InitEditors() {
            dateTimeChartRangeControlClient.DataProvider.DataSource = ViewModel.GetEntities().ToList();
            dateTimeChartRangeControlClient.DataProvider.ValueDataMember = "Total";
            dateTimeChartRangeControlClient.DataProvider.ArgumentDataMember = "Date";
            
            rangeControl.RangeChanged += rangeControl_RangeChanged;
        }
        void rangeControl_RangeChanged(object sender, RangeControlRangeEventArgs range) {
            DateTime min = (DateTime)range.Range.Minimum;
            DateTime max = (DateTime)range.Range.Maximum;
            ViewModel.FilterExpression = e => (e.Date > min) && (e.Date < max);
            quoteView.DataSource = ViewModel.GetOpportunities();
        }
        #region ViewKind
        protected CollectionUIViewModel CollectionUIViewModel { get; private set; }
        void InitViewKind() {
            biShowList.BindCommand(() => CollectionUIViewModel.ShowList(), CollectionUIViewModel);
            bmiShowList.BindCommand(() => CollectionUIViewModel.ShowList(), CollectionUIViewModel);
            biResetView.BindCommand(() => CollectionUIViewModel.ResetView(), CollectionUIViewModel);
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
                    roundedSkinPanelPnlView.Width = ScaleDPI.ScaleHorizontal(400);
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
        bool allExpanded = true;
        void UpdateAdditionalButtons(bool hasRecords) {
            biReverseSort.Enabled = hasRecords;
            biAddColumns.Enabled = biExpandCollapse.Enabled = hasRecords && (CollectionUIViewModel.ViewKind == CollectionViewKind.ListView);
        }
        void biExpandCollapse_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            if(allExpanded)
                pivotGridControl.CollapseAllRows();
            else
                pivotGridControl.ExpandAllRows();
            allExpanded = !allExpanded;
        }
        void biAddColumns_ItemCheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            if(!biAddColumns.Checked)
                pivotGridControl.DestroyCustomization();
            else {
                pivotGridControl.FieldsCustomization();
                pivotGridControl.HideCustomizationForm += pivotGridControl_HideCustomizationForm;
            }
        }
        void pivotGridControl_HideCustomizationForm(object sender, System.EventArgs e) {
            pivotGridControl.HideCustomizationForm -= pivotGridControl_HideCustomizationForm;
            biAddColumns.Checked = false;
        }
        void biReverseSort_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            pivotGridControl.ChangeFieldSortOrderAsync(fieldCity);
        }
        void pivotGridControl_CustomCellValue(object sender, XtraPivotGrid.PivotCellValueEventArgs e) {
            if(e.DataField == fieldPercentage)
                e.Value = Convert.ToDouble(e.Value) * 100;
        }
    }
}
