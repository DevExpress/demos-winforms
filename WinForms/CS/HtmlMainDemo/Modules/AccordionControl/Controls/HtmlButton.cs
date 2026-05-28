using System;
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace DevExpress.HTML.Demos.Modules.AccordionControl.Controls {
    public partial class HtmlButton : XtraUserControl {
        public HtmlButton() {
            InitializeComponent();
            context = new HtmlDataContext();
            this.htmlContentControl1.DataContext = context;
        }
        HtmlDataContext context;
        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text {
            get { return context.Text; }
            set { context.Text = value; }
        }
        class HtmlDataContext {
            public string Text { get; set; }
        }
    }
}
