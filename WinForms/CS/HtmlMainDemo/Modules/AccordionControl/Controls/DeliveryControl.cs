using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors;

namespace DevExpress.HTML.Demos.Modules.AccordionControl.Controls {
    public partial class DeliveryControl : AccordionHtmlContainerBase, IHtmlContentControlProvider {
        public DeliveryControl() {
            InitializeComponent();
            this.htmlContentControl1.ElementMouseDown += OnHtmlElementMouseDown;
            this.htmlContentControl1.ElementMouseClick += OnHtmlElementClick;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected internal object DataSource {
            get { return this.htmlContentControl1.DataContext; }
            set { this.htmlContentControl1.DataContext = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected internal object HtmlImages {
            get { return this.htmlContentControl1.HtmlImages; }
            set { this.htmlContentControl1.HtmlImages = value; }
        }
        Size IHtmlContentControlProvider.CalcBestSize(int width) {
            return ((IHtmlContentControlInternal)htmlContentControl1).CalcBestSize(width);
        }

        void OnHtmlElementMouseDown(object sender, Utils.Html.DxHtmlElementMouseEventArgs e) {
            var dataSource = DataSource as AccordionDataObject;
            if(dataSource == null)
                return;
            foreach(var deliveryType in dataSource.DeliveryTypes) {
                if(e.ElementId == deliveryType.Id || e.ParentHasId(deliveryType.Id)) {
                    dataSource.SelectedDelivery = deliveryType;
                    htmlContentControl1.RefreshDataContext();
                    return;
                }
            }
        }
        void OnHtmlElementClick(object sender, Utils.Html.DxHtmlElementMouseEventArgs e) {
            if(e.HasId("nextbutton"))
                RaiseNextButtonClick();
        }
    }
}
