namespace DevExpress.DevAV.Modules {
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using DevExpress.DevAV;
    using DevExpress.DevAV.Common.Utils;
    using DevExpress.DevAV.Modules.Helpers;
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraGrid.Columns;
    using DevExpress.XtraGrid.Views.Base;
#if NET
    using DevExpress.AIIntegration.Tools;
    using DevExpress.DevAV.AITools;
#endif

    public partial class Customers : BaseModuleControl, IRibbonModule, ISupportFiltersVisibilityChangedEvent {
        List<GridColumn> initialColumns;
        public Customers()
            : base(typeof(CustomerCollectionViewModel)) {
            InitializeComponent();
            GalleryItemAppearances.Apply(galleryQuickReports);
            layoutView.Appearance.FieldCaption.ForeColor = ColorHelper.DisabledTextColor;
            layoutView.Appearance.FieldCaption.Options.UseForeColor = true;
            lvEmployees.Appearance.FieldCaption.ForeColor = ColorHelper.DisabledTextColor;
            lvEmployees.Appearance.FieldCaption.Options.UseForeColor = true;
            
            CollectionUIViewModel = DevExpress.Mvvm.POCO.ViewModelSource.Create<CollectionUIViewModel>();
            CollectionPresenter = CreateCollectionPresenter();
            CollectionPresenter.ReloadEntities(mvvmContext);
            
            BindCommands();
            
            InitViewKind();
            InitViewLayout();
            initialColumns = gridView.Columns.ToList();
            colLogo.ImageOptions.ImageUri.Uri = FluentIconHelper.GetFluentIconName("resource://DevExpress.DevAV.Resources.icon-brand-16.png");
            FluentIconHelper.SwapFluentIcons(this);
        }
        protected override void OnDisposing() {
            CollectionPresenter.Dispose();
            base.OnDisposing();
        }
        public CustomerCollectionViewModel ViewModel {
            get { return GetViewModel<CustomerCollectionViewModel>(); }
        }
        public MainViewModel ParentViewModel {
            get { return mvvmContext.GetParentViewModel<MainViewModel>(); }
        }
        protected CustomerCollectionPresenter CollectionPresenter {
            get;
            private set;
        }
        protected virtual CustomerCollectionPresenter CreateCollectionPresenter() {
            return new CustomerCollectionPresenter(gridControl, ViewModel, UpdateEntitiesCountRelatedUI);
        }
        protected override void OnInitServices() {
            mvvmContext.RegisterService("View Settings", new ViewSettingsDialogDocumentManagerService(() => CollectionUIViewModel));
            mvvmContext.RegisterService(new NotImplementedDetailFormDocumentManagerService(ModuleType.CustomerEditView));
        }
        void BindCommands() {
            
            biNewCustomer.BindCommand(() => ViewModel.New(), ViewModel);
            biNewGroup.BindCommand(() => ViewModel.GroupSelection(), ViewModel);
            bmiNewCustomer.BindCommand(() => ViewModel.New(), ViewModel);
            bmiNewGroup.BindCommand(() => ViewModel.GroupSelection(), ViewModel);
            
            biEdit.BindCommand((e) => ViewModel.Edit(e), ViewModel, () => ViewModel.SelectedEntity);
            biDelete.BindCommand((e) => ViewModel.Delete(e), ViewModel, () => ViewModel.SelectedEntity);
            
            biMap.BindCommand(() => ViewModel.ShowMap(), ViewModel);
            
            biNewCustomFilter.BindCommand(() => ViewModel.NewCustomFilter(), ViewModel);
            
            bmiPrintProfile.BindCommand(() => ViewModel.PrintProfile(), ViewModel);
            bmiPrintContactDirectory.BindCommand(() => ViewModel.PrintContactDirectory(), ViewModel);
            bmiPrintSalesSummary.BindCommand(() => ViewModel.PrintSalesSummary(), ViewModel);
            bmiPrintSalesDetail.BindCommand(() => ViewModel.PrintSalesDetail(), ViewModel);
            
            BindGalleryQuickReportsItem(0, CustomerReportType.SalesSummary);
            BindGalleryQuickReportsItem(1, CustomerReportType.LocationsDirectory);
            BindGalleryQuickReportsItem(2, CustomerReportType.SelectedContactDirectory);
            
            biSalesAnalysis.BindCommand(() => ViewModel.ShowAnalysis(), ViewModel);
            
            biViewSettings.BindCommand(() => ViewModel.ShowViewSettings(), ViewModel);
        }
        void BindGalleryQuickReportsItem(int index, CustomerReportType parameter) {
            galleryQuickReports.Gallery.Groups[0].Items[index].BindCommand(() => ViewModel.QuickReport(parameter), ViewModel, () => parameter);
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
            CollectionPresenter.ExpandCollapseMasterRows();
        }
        void biAddColumns_ItemCheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            CollectionPresenter.AddColumns(biAddColumns);
        }
        void biReverseSort_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            CollectionPresenter.ReverseSort(colName, colName1);
        }
        CustomerView customerView;

        public event EventHandler FiltersVisibilityChanged;

        Size DefaultNavigationSize {
            get { return ScaleDPI.ScaleSize(new Size(220, navigationRoundedPanel.Height)); }
        }
        Size DefaultCollapsedNavigationSize {
            get { return ScaleDPI.ScaleSize(new Size(66, navigationRoundedPanel.Height)); }
        }

        protected virtual void OnFiltersVisibilityChangedCore(object sender, EventArgs e) {
            roundedSkinPanel1.SuspendLayout();
            FilterPaneHelper.SwitchFiltersVisibility(ParentViewModel, navigationRoundedPanel, DefaultNavigationSize, DefaultCollapsedNavigationSize);
            roundedSkinPanel1.ResumeLayout();
        }
        public void RaiseFiltersVisibilityChanged(object sender, EventArgs e) {
            OnFiltersVisibilityChangedCore(sender, e);
            if(FiltersVisibilityChanged != null)
                FiltersVisibilityChanged.Invoke(sender, e);
        }

        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            var moduleLocator = GetService<Services.IModuleLocator>();
            if(moduleLocator == null)
                return;
            customerView = moduleLocator.GetModule(ModuleType.CustomerView) as CustomerView;
            ViewModelHelper.EnsureModuleViewModel(customerView, ViewModel, ViewModel.SelectedEntityKey);
            customerView.Dock = DockStyle.Fill;
            customerView.Parent = roundedSkinPanelPnlView;
            gridView.ExpandMasterRow(0);

            FilterPaneHelper.SetupFiltersPane(
                ParentViewModel,
                ViewModel,
                ModuleType.CustomersFilterPane,
                ModuleType.CustomersFilterPaneCollapsed,
                navigationRoundedPanel,
                DefaultNavigationSize,
                OnFiltersVisibilityChangedCore
            );
        }
#if NET
        protected override AIToolsContext CreateAIToolsContext() {
            return new AIToolsContextBuilder()
                .WithToolTarget(gridControl, "Customers Grid Control")
                .WithToolsFromTypes(typeof(GridControlAITools))
                .Build();
        }
#endif
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
            else {
                gridControl.MainView = gridView;
                gridView.ExpandMasterRow(0);
            }
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
        void lvEmployees_CustomDrawCardFieldValue(object sender, RowCellCustomDrawEventArgs e) {
            if(e.Column.FieldName != colPhoto.FieldName) return;
            e.DefaultDraw();
            e.Cache.DrawRectangle(e.Cache.GetPen(lvEmployees.Appearance.FieldCaption.ForeColor, ScaleDPI.ScaleHLine(1)), e.Bounds);
            e.Handled = true;
        }
    }
}
