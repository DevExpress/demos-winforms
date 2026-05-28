namespace DevExpress.DevAV.Modules {
    using System;
    using DevExpress.DevAV;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraRichEdit;
    using DevExpress.XtraBars;
    using DevExpress.XtraRichEdit.API.Native;
    using System.ComponentModel;
    using DevExpress.DevAV.Common.Utils;

    public partial class OrderView : BaseModuleControl {
        public OrderView()
            : base(typeof(SynchronizedOrderViewModel)) {
            InitializeComponent();
            TitleLabel.Appearance.ForeColor = ColorHelper.DisabledTextColor;
            ItemForTitleLabel.AppearanceItemCaption.ForeColor = ColorHelper.DisabledTextColor;
            ItemForTitleLabel.AppearanceItemCaption.Options.UseForeColor = true;
            modueLayout.Visible = false;
            richEditControl.BackColor = ColorHelper.GetControlColor(LookAndFeel);
            LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
            ViewModel.EntityChanged += ViewModel_EntityChanged;
            richEditControl.ZoomChanged += richEditControl_ZoomChanged;
            richEditControl.CalculateDocumentVariable += documentServer_CalculateDocumentVariable;
            FluentIconHelper.SwapFluentIcons(this);
        }
        protected override void OnMVVMContextReleasing() {
            ViewModel.EntityChanged -= ViewModel_EntityChanged;
        }
        protected override void OnDisposing() {
            LookAndFeel.StyleChanged -= LookAndFeel_StyleChanged;
            richEditControl.ZoomChanged -= richEditControl_ZoomChanged;
            base.OnDisposing();
        }
        public OrderViewModel ViewModel {
            get { return GetViewModel<OrderViewModel>(); }
        }
        void BindCommands() {
            var fluentAPI = mvvmContext.OfType<OrderViewModel>();
            fluentAPI.SetBinding(paidBBI, x => x.Caption, x => x.MarkPaidToolTip);
            fluentAPI.SetBinding(refundBBI, x => x.Caption, x => x.IssueFullRefundToolTip);
            editBBI.BindCommand(() => ViewModel.Edit(), ViewModel);
            deleteBBI.BindCommand(() => ViewModel.Delete(), ViewModel);
            emailBBI.BindCommand(() => ViewModel.MailTo(), ViewModel);
            printBBI.BindCommand(() => ViewModel.Print(), ViewModel);
            paidBBI.BindCommand(() => ViewModel.MarkPaid(), ViewModel);
            refundBBI.BindCommand(() => ViewModel.IssueFullRefund(), ViewModel);
        }
        void ViewModel_EntityChanged(object sender, System.EventArgs e) {
            QueueUIUpdate();
        }
        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            richEditControl.BackColor = ColorHelper.GetControlColor(LookAndFeel);
        }
        protected override int GetUIUpdateDelay() {
            return 500;
        }
        protected override void OnDelayedUIUpdate() {
            base.OnDelayedUIUpdate();
            UpdateUI(ViewModel.Entity);
        }
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            BindCommands();
            LoadOrderTemplate();
            UpdateUI(ViewModel.Entity);
        }
        void LoadOrderTemplate() {
            if(!richEditControl.Document.IsEmpty)
                return;
            using(var stream = MailMergeTemplatesHelper.GetTemplateStream("Order.docx"))
                richEditControl.LoadDocumentTemplate(stream, DocumentFormat.OpenXml);
            richEditControl.DocumentLayout.DocumentFormatted += DocumentLayout_DocumentFormatted;
            richEditControl.Options.MailMerge.DataSource = bindingSource;
            richEditControl.Options.MailMerge.ViewMergedData = true;
            richEditControl.ActiveView.ZoomFactor -= richEditControl.ActiveView.ZoomFactor / 4f;
        }
        void documentServer_CalculateDocumentVariable(object sender, CalculateDocumentVariableEventArgs e) {
            Order order = bindingSource.DataSource as Order;
            if(order == null)
                return;

            switch(e.VariableName) {
                case "OrderItems":
                    var targetDocumentServer = richEditControl.CreateDocumentServer();
                    using(var sourceDocumentServer = richEditControl.CreateDocumentServer()) {
                        using(var stream = MailMergeTemplatesHelper.GetTemplateStream("OrderItemsTemplate.docx"))
                            sourceDocumentServer.LoadDocumentTemplate(stream, DocumentFormat.OpenXml);
                        sourceDocumentServer.Options.MailMerge.DataSource = order.OrderItems;

                        MailMergeOptions options = sourceDocumentServer.Document.CreateMailMergeOptions();
                        options.MergeMode = MergeMode.JoinTables;
                        sourceDocumentServer.MailMerge(options, targetDocumentServer.Document);
                    }
                    e.PreserveInsertedContentFormatting = true;
                    e.KeepLastParagraph = false;
                    e.Value = targetDocumentServer;
                    e.Handled = true;
                    break;
                case "Total":
                    e.Value = order.OrderItems.CustomSum(x => x.Total);
                    e.Handled = true;
                    break;
                case "TotalDue":
                    e.Value = order.OrderItems.CustomSum(x => x.Total) + order.ShippingAmount;
                    e.Handled = true;
                    break;
            }
        }
        void DocumentLayout_DocumentFormatted(object sender, EventArgs e) {
            PrintLayoutView view = richEditControl.ActiveView as PrintLayoutView;
            if(view != null)
                richEditControl.BeginInvoke(new Action(view.FitToPage));
        }
        void richEditControl_ZoomChanged(object sender, EventArgs e) {
            RaiseZoomLevelChanged();
        }
        void UpdateUI(Order order) {
            if(order != null) {
                if(!object.Equals(bindingSource.DataSource, order))
                    bindingSource.DataSource = order;
                else
                    bindingSource.ResetBindings(false);
                richEditControl.Document.Fields.Update();
            }
            modueLayout.Visible = (order != null);
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ZoomLevel {
            get { return (int)System.Math.Ceiling(richEditControl.ActiveView.ZoomFactor * 100.0f); }
            set {
                if(ZoomLevel == value) return;
                richEditControl.ActiveView.ZoomFactor = ((float)value) / 100.0f;
            }
        }
        public BarButtonItem MovePrevButton {
            get {
                return previousBBI;
            }
        }
        public BarButtonItem MoveNextButton {
            get {
                return nextBBI;
            }
        }
        public event EventHandler ZoomLevelChanged;
        void RaiseZoomLevelChanged() {
            EventHandler handler = ZoomLevelChanged;
            if(handler != null) handler(this, EventArgs.Empty);
        }
    }
}
