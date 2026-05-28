using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors;

namespace DevExpress.HTML.Demos.Modules.AccordionControl.Controls {
    public partial class OrderSummaryControl : AccordionHtmlContainerBase, IHtmlContentControlProvider {
        public OrderSummaryControl() {
            InitializeComponent();
            this.htmlContentControl1.ElementMouseClick += OnHtmlElementClick;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected internal object DataSource {
            get { return this.htmlContentControl1.DataContext; }
            set { this.htmlContentControl1.DataContext = value; }
        }
        Size IHtmlContentControlProvider.CalcBestSize(int width) {
            htmlContentControl1.RefreshDataContext();
            return ((IHtmlContentControlInternal)htmlContentControl1).CalcBestSize(width);
        }
        private void OnHtmlElementClick(object sender, Utils.Html.DxHtmlElementMouseEventArgs e) {
            if(e.HasId("nextbutton"))
                RaiseNextButtonClick();
        }
    }
}
