using System;
using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraLayout.Utils;

namespace DevExpress.HTML.Demos {
    public partial class AlertInfoProperties : XtraUserControl {
        public AlertInfoProperties() {
            InitializeComponent();
        }
        public void Init(string caption, string text, bool showImageComboBox) {
            captionItem.Visibility = string.IsNullOrEmpty(caption) ? LayoutVisibility.Never : LayoutVisibility.Always;
            textItem.Visibility = string.IsNullOrEmpty(text) ? LayoutVisibility.Never : LayoutVisibility.Always;
            imageItem.Visibility = showImageComboBox ? LayoutVisibility.Always : LayoutVisibility.Never;
            txtCaption.Text = caption;
            txtText.Text = text;
        }
        
        public string Caption { get { return txtCaption.Text; } }
        public string AlertText { get { return txtText.Text; } }
        public Image Image { 
            get {
                if(icbImage.SelectedIndex >= svgImageCollection1.Count) return null;
                return svgImageCollection1.GetImage(icbImage.SelectedIndex); 
            } 
        }
        public SvgImage SvgImage {
            get {
                if(icbImage.SelectedIndex >= svgImageCollection1.Count) return null;
                return svgImageCollection1[icbImage.SelectedIndex];
            }
        }

        public void UpdateAlertInfo(AlertInfo info) {
            info.Caption = Caption;
            info.Text = AlertText;
            info.ImageOptions.Image = Image;
            info.ImageOptions.SvgImage = SvgImage;
            info.AutoCloseFormOnClick = ceAutoCloseOnClick.Checked;
        }
    }
}
