using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;

namespace DevExpress.HTML.Demos.Modules.AccordionControl.Controls {
    public partial class InformationControl : AccordionHtmlContainerBase, IHtmlContentControlProvider {
        public InformationControl() {
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
        void OnHtmlElementClick(object sender, Utils.Html.DxHtmlElementMouseEventArgs e) {
            if(e.HasId("nextbutton"))
                RaiseNextButtonClick();
        }
    }
    public class AccordionHtmlContainerBase : XtraUserControl {
        static readonly object nextButtonClick = new object();
        public event EventHandler NextButtonClick {
            add { Events.AddHandler(nextButtonClick, value); }
            remove { Events.RemoveHandler(nextButtonClick, value); }
        }
        protected virtual void RaiseNextButtonClick() {
            EventHandler handler = (EventHandler)Events[nextButtonClick];
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
    }
}
