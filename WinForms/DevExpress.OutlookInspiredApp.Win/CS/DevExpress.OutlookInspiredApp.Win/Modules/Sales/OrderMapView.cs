namespace DevExpress.DevAV.Modules {
    using System;
    using System.Drawing;
    using System.IO;
    using DevExpress.DevAV;
    using DevExpress.DevAV.Common.Utils;
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.Reports;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Pdf;
    using DevExpress.Security;

    public partial class OrderMapView : BaseModuleControl, IRibbonModule {
        public OrderMapView()
            : base(typeof(OrderMapViewModel)) {
            InitializeComponent();
            
            Presenter = CreatePresenter();
            BindCommands();
            BindEditors();
            UpdateColors();
            FluentIconHelper.SwapFluentIcons(this);
        }
        protected override void OnDisposing() {
            biPrint.ItemClick -= OnPrint;
            barExportItem.ItemClick -= OnExport;
            
            Presenter.Dispose();
            base.OnDisposing();
        }
        public OrderMapViewModel ViewModel {
            get { return GetViewModel<OrderMapViewModel>(); }
        }
        protected OrderRouteMapPresenter Presenter {
            get;
            private set;
        }
        protected virtual OrderRouteMapPresenter CreatePresenter() {
            return new OrderRouteMapPresenter(mapControl, ViewModel, UpdateUI);
        }
        protected virtual void BindCommands() {
            biClose.BindCommand(() => ViewModel.Close(), ViewModel);
            biPrint.ItemClick += OnPrint;
            barExportItem.ItemClick += OnExport;
        }
        void OnPrint(object sender, XtraBars.ItemClickEventArgs e) {
            Viewer.Print();
        }
        void OnExport(object sender, XtraBars.ItemClickEventArgs e) {
            string shippingDocument = SafePath.AddFileNameSuffix(
                "Shipping_.pdf", ViewModel.Entity.InvoiceNumber);
            Viewer.SaveDocument(shippingDocument);
        }
        protected virtual void BindEditors() {
            bindingSource.DataSource = ViewModel;
        }
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdateColors();
        }
        void UpdateColors() {
            ItemForInvoice.AppearanceItemCaption.ForeColor = ColorHelper.DisabledTextColor;
            InvoiceLabel.Appearance.ForeColor = ColorHelper.DisabledTextColor;
        }
        void UpdateUI(Order order) {
            ribbonControl.ApplicationDocumentCaption = order.Customer.Name;
            using(PdfDocumentProcessor processor = new PdfDocumentProcessor()) {
                using(Stream template = GetShipmentTemplate(order)) {
                    processor.LoadDocument(template);
                    AddWatermark(processor, GetWatermarkText(order));
                    using(MemoryStream ms = new MemoryStream()) {
                        processor.SaveDocument(ms);
                        ms.Seek(0, SeekOrigin.Begin);
                        Viewer.LoadDocument(ms);
                    }
                }
            }
        }
        static Stream GetShipmentTemplate(Order order) {
            MemoryStream pdfStream = new MemoryStream();
            var report = ReportFactory.ShippingDetail(order);
            report.ExportToPdf(pdfStream);
            return pdfStream;
        }
        static string GetWatermarkText(Order order) {
            switch(order.ShipmentStatus) {
                case ShipmentStatus.Received:
                    return "Shipment Received";
                case ShipmentStatus.Transit:
                    return "Shipment in Transit";
                default:
                    return "Awaiting shipment";
            }
        }
        static void AddWatermark(PdfDocumentProcessor processor, string watermark) {
            var pages = processor.Document.Pages;
            for(int i = 0; i < pages.Count; i++) {
                using(var graphics = processor.CreateGraphics()) {
                    using(Font font = new Font("Segoe UI", 48, FontStyle.Regular)) {
                        RectangleF pageLayout = new RectangleF(
                            -(float)pages[i].CropBox.Width * 0.35f,
                             (float)pages[i].CropBox.Height * 0.1f,
                             (float)pages[i].CropBox.Width * 1.25f,
                             (float)pages[i].CropBox.Height);
                        
                        var angle = Math.Asin((double)pageLayout.Width / (double)pageLayout.Height) * 180.0 / Math.PI;
                        graphics.TranslateTransform(-pageLayout.X, -pageLayout.Y);
                        graphics.RotateTransform((float)angle);
                        using(SolidBrush textBrush = new SolidBrush(Color.FromArgb(100, Color.Red)))
                            graphics.DrawString(watermark, font, textBrush, new PointF(50, 50));
                    }
                    graphics.AddToPageForeground(pages[i]);
                }
            }
        }
        #region IRibbonModule
        XtraBars.Ribbon.RibbonControl IRibbonModule.Ribbon {
            get { return ribbonControl; }
        }
        #endregion
    }
}
