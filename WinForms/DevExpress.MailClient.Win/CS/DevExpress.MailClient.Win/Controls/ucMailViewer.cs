using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.Utils.Menu;
using DevExpress.XtraRichEdit;

namespace DevExpress.MailClient.Win {
    public partial class ucMailViewer : BaseControl {
        BaseModule parent = null;
        public ucMailViewer() {
            InitializeComponent();
            pePhoto.Properties.OptionsMask.MaskType = XtraEditors.Controls.PictureEditMaskType.Circle;
            recMessage.Text = string.Empty;
            bbiReply.Hint = Properties.Resources.ReplyDescription;
            bbiReplyAll.Hint = Properties.Resources.ReplyAllDescription;
            bbiForward.Hint = Properties.Resources.ForwardDescription;
        }
        internal void SetParentModule(BaseModule module) {
            parent = module;
        }
        public void SetMenuManager(IDXMenuManager manager) {
            recMessage.MenuManager = manager;
        }
        protected override void LookAndFeelStyleChanged() {
            base.LookAndFeelStyleChanged();
            Color windowColor = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("Window");
            Color windowTextColor = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("WindowText");
            lgMessageInfo.AppearanceGroup.ForeColor = windowTextColor;
            lgMessageInfo.AppearanceGroup.BackColor = windowColor;
            lbDate.ForeColor = lbFrom.ForeColor = lbSubject.ForeColor = windowTextColor;
        }
        void ShowMessageInfo(bool visible) {
            lgMessageInfo.Visibility = visible ? XtraLayout.Utils.LayoutVisibility.Always : XtraLayout.Utils.LayoutVisibility.Never;
        }
        internal void ShowMessage(Message message) {
            if(message == null) return;
            ShowMessageInfo(true);
            lbSubject.Text = message.Subject;
            lbFrom.Text = message.FullName;
            lbDate.Text = message.Date.ToString();
            pePhoto.Image = DataHelper.GetPhotoByEmail(message.Email);
            lcPicture.Padding = new XtraLayout.Utils.Padding(pePhoto.Image == null ? 10 : 0);
            pePhoto.Properties.OptionsMask.MaskLayoutMode = pePhoto.Image == null ? 
                XtraEditors.Controls.PictureEditMaskLayoutMode.Default : XtraEditors.Controls.PictureEditMaskLayoutMode.Stretch;
            if(pePhoto.Image == null) 
                pePhoto.Image = ImageHelper.CreateSenderImage(message.From, pePhoto.Size, pePhoto.LookAndFeel.ActiveLookAndFeel);
            recMessage.MhtText = message.Text;
        }
        private string GetFromString(MailType mailType) {
            if(mailType == MailType.Inbox) return Properties.Resources.FromInbox;
            if(mailType == MailType.Deleted) return Properties.Resources.FromDeleted;
            return Properties.Resources.FromOutbox;
        }
        internal void ShowMessagesInfo(List<Message> messages) {
            ShowMessageInfo(false);
            string text =  StringResources.Get("MessageTile");
            foreach(Message message in messages) {
                text += string.Format(StringResources.Get("MessageTileEx"), message.FullName, message.Date, message.Subject);
            }
            text += StringResources.Get("MessageTileEnd");
            recMessage.HtmlText = text;
        }
        internal void ShowFeed(FeedItem feed, bool showUrl) {
            ShowMessageInfo(false);
            if(showUrl) layoutControlItem2.Visibility = XtraLayout.Utils.LayoutVisibility.Always;
            else layoutControlItem2.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
            linkView.Text = feed.Url;
            recMessage.HtmlText = feed.Description;
        }
        internal void ClearInfo() {
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
            parent.ButtonClick(TagResources.Reply);
        }
        private void bbiReplyAll_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            parent.ButtonClick(TagResources.ReplyAll);
        }
        private void bbiForward_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            parent.ButtonClick(TagResources.Forward);
        }
    }
}
