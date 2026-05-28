using System;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors;

namespace DevExpress.HTML.Demos.Modules.AccordionControl.Controls {
    public partial class ShippingControl : AccordionHtmlContainerBase, IHtmlContentControlProvider {
        public ShippingControl() {
            InitializeComponent();
            this.htmlContentControl1.ElementMouseClick += OnHtmlElementClick;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected internal object DataSource {
            get { return this.htmlContentControl1.DataContext; }
            set { this.htmlContentControl1.DataContext = value; }
        }
        Size IHtmlContentControlProvider.CalcBestSize(int width) {
            return ((IHtmlContentControlInternal)htmlContentControl1).CalcBestSize(width);
        }
        static readonly object saveButtonClick = new object();
        public event EventHandler SaveButtonClick {
            add { Events.AddHandler(saveButtonClick, value); }
            remove { Events.RemoveHandler(saveButtonClick, value); }
        }
        protected virtual void RaiseSaveButtonClick() {
            EventHandler handler = (EventHandler)Events[saveButtonClick];
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        private void OnHtmlElementClick(object sender, Utils.Html.DxHtmlElementMouseEventArgs e) {
            if(e.HasId("nextbutton")) {
                RaiseNextButtonClick();
            }
            if(e.HasId("savebutton")) {
                RaiseSaveButtonClick();
            }
        }
    }
}
