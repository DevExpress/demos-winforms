using System;
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace DevExpress.HTML.Demos.Modules.AccordionControl.Controls {
    public partial class HtmlCheckBoxControl : XtraUserControl {
        public HtmlCheckBoxControl() {
            InitializeComponent();
            dataObject = new HtmlCheckBoxSource();
            this.htmlContentControl1.DataContext = dataObject;
            this.htmlContentControl1.ElementMouseDown += OnElementClick;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected internal object HtmlImages {
            get { return this.htmlContentControl1.HtmlImages; }
            set { this.htmlContentControl1.HtmlImages = value; }
        }
        void OnElementClick(object sender, Utils.Html.DxHtmlElementMouseEventArgs e) {
            dataObject.Checked = !dataObject.Checked;
            RaiseCheckedChanged();
            this.htmlContentControl1.Invalidate();
        }
        static readonly object checkedChanged = new object();
        public event EventHandler CheckedChanged {
            add { Events.AddHandler(checkedChanged, value); }
            remove { Events.RemoveHandler(checkedChanged, value); }
        }
        protected virtual void RaiseCheckedChanged() {
            EventHandler handler = (EventHandler)Events[checkedChanged];
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        protected internal bool Checked {
            get { return dataObject.Checked; }
        }

        HtmlCheckBoxSource dataObject;
        
        class HtmlCheckBoxSource {
            public bool Checked { get; set; }
        }
    }
}
