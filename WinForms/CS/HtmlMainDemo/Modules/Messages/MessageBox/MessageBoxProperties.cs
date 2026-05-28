using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.Utils.Svg;
using DevExpress.XtraLayout.Utils;
using System;

namespace DevExpress.HTML.Demos {
    public partial class MessageBoxProperties : XtraUserControl {
        public MessageBoxProperties() {
            InitializeComponent();
        }
        
        public void Init(string caption, string text, bool showIcon) {
            txtCaption.Text = caption;
            txtText.Text = text;
            imageItem.Visibility = showIcon ? LayoutVisibility.Always : LayoutVisibility.Never;
        }
        public event EventHandler Changed;
        private void OnEditValueChanged(object sender, EventArgs e) {
            Changed?.Invoke(sender, e);
        }
        public string Caption {
            get { return txtCaption.Text; }
        }
        public string MessageText {
            get { return txtText.Text; }
        }
        public SvgImage SvgImage {
            get {
                if(icbImage.SelectedIndex >= svgImageCollection1.Count) return null;
                return svgImageCollection1[icbImage.SelectedIndex];
            }
        }

        public XtraMessageBoxArgs GetMessageArgs() {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Caption = txtCaption.Text;
            args.Text = txtText.Text;
            args.ImageOptions.SvgImage = SvgImage;
            return args;
        }

    }
}
