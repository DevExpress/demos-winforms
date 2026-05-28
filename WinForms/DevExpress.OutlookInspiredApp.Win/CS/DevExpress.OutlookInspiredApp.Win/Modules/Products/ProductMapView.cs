namespace DevExpress.DevAV.Modules {
    using System;
    using System.Linq;
    using DevExpress.DevAV;
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraBars.Docking2010;
    using System.Drawing;
    using DevExpress.DevAV.Common.Utils;

    public partial class ProductMapView : BaseModuleControl, IRibbonModule {
        public ProductMapView()
            : base(typeof(ProductMapViewModel)) {
            InitializeComponent();
            
            Presenter = CreatePresenter();
            
            BindCommands();
            BindEditors();
            UpdateColors();
            LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
            FluentIconHelper.SwapFluentIcons(this);
        }
        protected override void OnDisposing() {
            Presenter.Dispose();
            LookAndFeel.StyleChanged -= LookAndFeel_StyleChanged;
            base.OnDisposing();
        }
        public ProductMapViewModel ViewModel {
            get { return GetViewModel<ProductMapViewModel>(); }
        }
        protected ProductSalesMapPresenter Presenter { get; private set; }
        protected virtual ProductSalesMapPresenter CreatePresenter() {
            return new ProductSalesMapPresenter(mapControl, ViewModel, UpdateUI, UpdateChart);
        }
        protected virtual void BindCommands() {
            
            biSave.BindCommand(() => ViewModel.Save(), ViewModel);
            biClose.BindCommand(() => ViewModel.Close(), ViewModel);
            biSaveAndClose.BindCommand(() => ViewModel.SaveAndClose(), ViewModel);
            
            biDelete.BindCommand(() => ViewModel.Delete(), ViewModel);
            
            biLifetime.BindCommand(() => ViewModel.SetLifetimePeriod(), ViewModel);
            biThisYear.BindCommand(() => ViewModel.SetThisYearPeriod(), ViewModel);
            biThisMonth.BindCommand(() => ViewModel.SetThisMonthPeriod(), ViewModel);
            ((WindowsUIButton)periodButtons.Buttons[0]).BindCommand(() => ViewModel.SetThisMonthPeriod(), ViewModel);
            ((WindowsUIButton)periodButtons.Buttons[1]).BindCommand(() => ViewModel.SetThisYearPeriod(), ViewModel);
            ((WindowsUIButton)periodButtons.Buttons[2]).BindCommand(() => ViewModel.SetLifetimePeriod(), ViewModel);
            
            biPrint.ItemClick += (s, e) => mapControl.Print();
            biPrintPreview.ItemClick += (s, e) => mapControl.ShowRibbonPrintPreview();
            barExportItem.ItemClick += (s, e) => mapControl.Export("Products.Map.png");
        }
        protected virtual void BindEditors() {
            bindingSource.DataSource = ViewModel;
        }
        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            UpdateColors();
        }
        void UpdateUI(Product product) {
            ribbonControl.ApplicationDocumentCaption = product.Name;
        }
        void UpdateChart(DevAV.MapItem salesItem) {
            chart.Series[0].View.Colorizer = colorizer1 as DevExpress.XtraCharts.IColorizer;
            chart.DataSource = ViewModel.GetSalesByCity(salesItem.City, ViewModel.Period).ToList();
        }
        void UpdateColors() {
            periodButtons.BackColor = ChartHelper.GetBackColor(chart);
            var paletteEntries = chart.GetPaletteEntries(20);
            var colorItems = Presenter.PieChartColorizer.Colors;
            colorItems.Clear();
            colorItems.BeginUpdate();
            foreach(var entry in paletteEntries)
                colorItems.Add(entry.Color);
            colorItems.EndUpdate();
        }
        #region IRibbonModule
        XtraBars.Ribbon.RibbonControl IRibbonModule.Ribbon { get { return ribbonControl; } }
        #endregion
    }

    public class Colorizer : DevExpress.XtraMap.KeyColorColorizer, DevExpress.XtraCharts.IColorizer {
        Color XtraCharts.IColorizer.GetPointColor(object argument, object[] values, object colorKey, XtraCharts.Palette palette) {
            if(colorKey != null)
                return this.GetColor(colorKey);
            return Color.Empty;
        }
        Color XtraCharts.IColorizer.GetPointColor(object argument, object[] values, object[] colorKeys, XtraCharts.Palette palette) {
            if(colorKeys != null && colorKeys.Length > 0)
                return this.GetColor(colorKeys[0]);
            return Color.Empty;
        }
        Color XtraCharts.IColorizer.GetAggregatedPointColor(object argument, object[] values, XtraCharts.SeriesPoint[] points, XtraCharts.Palette palette) {
            return Color.Empty;
        }
        event System.ComponentModel.PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged {
            add { }
            remove { }
        }
    }
}
