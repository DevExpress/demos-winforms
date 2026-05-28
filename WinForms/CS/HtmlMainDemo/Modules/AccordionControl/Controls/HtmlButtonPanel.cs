using System.ComponentModel;
using DevExpress.XtraEditors;

namespace DevExpress.HTML.Demos.Modules.AccordionControl.Controls {
    public partial class HtmlButtonPanel : XtraUserControl {
        public HtmlButtonPanel() {
            InitializeComponent();
            this.htmlContentControl1.ElementMouseClick += OnElementMouseClick;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected internal object HtmlImages {
            get { return this.htmlContentControl1.HtmlImages; }
            set { this.htmlContentControl1.HtmlImages = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected internal object DataSource {
            get { return this.htmlContentControl1.DataContext; }
            set { this.htmlContentControl1.DataContext = value; }
        }
        void OnElementMouseClick(object sender, Utils.Html.DxHtmlElementMouseEventArgs e) {
            var dataSource = DataSource as AccordionDataObject;
            if(dataSource == null)
                return;
            foreach(var paymentType in dataSource.PaymentTypes) {
                if(e.HasId(paymentType.Id)) {
                    dataSource.SelectedPaymentType = paymentType;
                    htmlContentControl1.RefreshDataContext();
                    return;
                }
            }
        }
    }
}
