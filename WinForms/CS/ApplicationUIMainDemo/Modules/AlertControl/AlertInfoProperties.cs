using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils;

namespace DevExpress.ApplicationUI.Demos {
    public partial class AlertInfoProperties : XtraUserControl {
        public AlertInfoProperties() {
            InitializeComponent();
        }
        string _caption, _text, _captionHtml, _textHtml, _hotTrackedTextHtml;
        public void InitValues(string caption, string text, string captionHtml, string textHtml, string hotTrackedTextHtml) {
            this._caption = caption;
            this._captionHtml = captionHtml;
            this._text = text;
            this._textHtml = textHtml;
            this._hotTrackedTextHtml = hotTrackedTextHtml;
        }
        
        public string Caption { get { return txtCaption.Text; } }
        public string TextInfo { get { return txtText.Text; } }
        public string HotTrackedText { get { return txtHotTrackedText.Text; } }
        public Image Image { 
            get {
                if(ceShowAnimatedImage.Checked)
                    return ResourceImageHelper.CreateImageFromResources("DevExpress.ApplicationUI.Demos.Images.Alarm-Clock.gif", typeof(AlertInfoProperties).Assembly);
                if(icbImage.SelectedIndex > 4) return null;
                return svgImageCollection1.GetImage(icbImage.SelectedIndex); 
            } 
        }

        bool allowHtml = false;
        bool _initValues = false;
        internal void UpdateInfo(bool allowHtml) {
            _initValues = true;
            this.allowHtml = allowHtml;
            if(allowHtml) {
                txtCaption.Text = _captionHtml;
                txtText.Text = _textHtml;
                txtHotTrackedText.Text = _hotTrackedTextHtml;
                txtHotTrackedTextitem.Visibility = XtraLayout.Utils.LayoutVisibility.Always;
            }
            else {
                txtCaption.Text = _caption;
                txtText.Text = _text;
                txtHotTrackedText.Text = "";
                txtHotTrackedTextitem.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
            }
            _initValues = false;
        }

        private void txtCaption_EditValueChanged(object sender, EventArgs e) {
            if(_initValues) return;
            if(allowHtml)
                _captionHtml = txtCaption.Text;
            else _caption = txtCaption.Text;
        }

        private void txtText_EditValueChanged(object sender, EventArgs e) {
            if(_initValues) return;
            if(allowHtml)
                _textHtml = txtText.Text;
            else _text = txtText.Text;
        }

        private void txtSelectedText_EditValueChanged(object sender, EventArgs e) {
            if(_initValues) return;
            if(allowHtml)
                _hotTrackedTextHtml = txtHotTrackedText.Text;
        }

        private void ceShowAnimatedImage_CheckedChanged(object sender, EventArgs e) {
            icbImage.Enabled = !ceShowAnimatedImage.Checked;
        }
    }
}
