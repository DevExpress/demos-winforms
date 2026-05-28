using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.Utils.Menu;
using DevExpress.XtraRichEdit;
using DevExpress.Utils.Design;
using DevExpress.XtraGrid.Demos.Properties;

namespace DevExpress.XtraGrid.Demos {
    public partial class ucMailViewer : XtraUserControl {
        public ucMailViewer() {
            InitializeComponent();
            pePhoto.Properties.OptionsMask.MaskType = XtraEditors.Controls.PictureEditMaskType.Circle;
            pePhoto.BackColor = Color.Transparent;
            lcTitle.Text = string.Empty;
            recMessage.Text = string.Empty;
            LookAndFeel.ActiveLookAndFeel.StyleChanged += new EventHandler(ActiveLookAndFeel_StyleChanged);
        }
        public void SetMenuManager(IDXMenuManager manager) {
            recMessage.MenuManager = manager;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(!DesignTimeTools.IsDesignMode) {
                LookAndFeelStyleChanged();
            }
        }
        protected override void Dispose(bool disposing) {
            if(disposing && !DesignTimeTools.IsDesignMode)
                LookAndFeel.ActiveLookAndFeel.StyleChanged -= new EventHandler(ActiveLookAndFeel_StyleChanged);
            base.Dispose(disposing);
        }
        void ActiveLookAndFeel_StyleChanged(object sender, EventArgs e) {
            LookAndFeelStyleChanged();
        }
        protected virtual void LookAndFeelStyleChanged() {
            recMessage.Appearance.Text.ForeColor = ForeColor;
            recMessage.Document.SetPageBackground(BackColor);
        }
        void ShowMessageAdditions(bool visible) {
            lcPhoto.Visibility =
                layoutControlItem5.Visibility = visible ? XtraLayout.Utils.LayoutVisibility.Always : XtraLayout.Utils.LayoutVisibility.Never;
        }
        protected internal virtual void ShowMessage(DevExpress.XtraGrid.Demos.Message message) {
            if(message == null) return;
            lcTitle.Text = string.Format("<size=+3><b>{0}<br><br><br></b><size=-4>{3}: <size=+2>{1}<br><size=-2>{4}: <size=+2>{2:g}<br> ", message.Subject, message.FullName, message.Date, GetFromString(message.MailType), Date);
            pePhoto.Image = DataHelper.GetPhotoByEmail(message.Email);
            pePhoto.Properties.OptionsMask.MaskLayoutMode = pePhoto.Image == null ?
                XtraEditors.Controls.PictureEditMaskLayoutMode.Default : XtraEditors.Controls.PictureEditMaskLayoutMode.Stretch;
            if(pePhoto.Image == null)
                pePhoto.Image = ImageHelper.CreateSenderImage(message.From, pePhoto.Size, pePhoto.LookAndFeel.ActiveLookAndFeel);
            recMessage.MhtText = message.Text;
            ShowMessageAdditions(true);
            LookAndFeelStyleChanged();
        }
        private string GetFromString(MailType mailType) {
            return DevExpress.XtraGrid.Demos.Properties.Resources.FromString;
        }
        internal void ShowMessagesInfo(List<DevExpress.XtraGrid.Demos.Message> messages) {
            ShowMessageAdditions(false);
            lcTitle.Text = string.Format("<size=+7> <size=-3><b>{0}</b> <size=-3>{1}", messages.Count, MessageFromCount);
            string _text = Resources.MessageTile;
            foreach(DevExpress.XtraGrid.Demos.Message message in messages) {
                _text += string.Format(Resources.MessageTileEx, message.From, message.Date, message.Subject);
            }
            _text += Resources.MessageTileEnd;
            recMessage.HtmlText = _text;
            LookAndFeelStyleChanged();
        }
        internal void ClearInfo() {
            lcTitle.Text = string.Empty;
            recMessage.Text = string.Empty;
            layoutControlItem2.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float ZoomFactor {
            get { return recMessage.Views.SimpleView.ZoomFactor; }
            set { recMessage.Views.SimpleView.ZoomFactor = value; }
        }
        public RichEditControl RichEdit { get { return recMessage; } }

        private void bbiReply_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
        }
        private void bbiReplyAll_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
        }
        private void bbiForward_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
        }

        const string MessageFromCount = "Message(s)";
        const string Date = "Date";
    }
}
