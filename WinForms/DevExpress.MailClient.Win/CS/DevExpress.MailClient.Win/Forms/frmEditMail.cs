using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace DevExpress.MailClient.Win {
    public partial class frmEditMail : RibbonForm {
        bool isMessageModified;
        bool newMessage = true;
        string messageFrom = string.Empty;
        readonly Message sourceMessage;

        public frmEditMail() {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }
        public frmEditMail(Message message, bool newMessage, string caption) {
            InitializeComponent();
            this.newMessage = newMessage;
            DialogResult = DialogResult.Cancel;
            this.sourceMessage = message;
            edtSubject.Text = message.Subject;
            TokenEditHelper.Initialize(edtTo);
            edtTo.EditValue = TokenEditHelper.ParseFromField(message.From);
            richEditControl.MhtText = message.Text;
            this.isMessageModified = newMessage;
            if(string.IsNullOrEmpty(message.From))
                splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1;
            splitContainerControl1.Collapsed = newMessage;
            ucMessageInfo1.Init(message, ribbonControl.Manager);
            //this.sendToEditSize = edtTo.Size;
            this.messageFrom = message.From;
            if(!newMessage) {
                splitContainerControl1.Collapsed = LayoutOption.MailCollapsed;
                edtToitem.Text = string.Format("{0}:", caption);
                edtTo.Properties.ReadOnly = true;
                edtSubject.Properties.ReadOnly = true;
                richEditControl.ReadOnly = true;
            }
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);
            if(!newMessage)
                LayoutOption.MailCollapsed = splitContainerControl1.Collapsed;
        }
        public Message SourceMessage { get { return sourceMessage; } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMessageModified {
            get { return isMessageModified || richEditControl.Modified; }
            set {
                isMessageModified = value;
                richEditControl.Modified = value;
            }
        }
        #region SaveMessage event
        EventHandler onSaveMessage;
        public event EventHandler SaveMessage { add { onSaveMessage += value; } remove { onSaveMessage -= value; } }
        protected internal virtual void RaiseSaveMessage() {
            if(onSaveMessage != null)
                onSaveMessage(this, EventArgs.Empty);
        }
        #endregion

        void richEditControl_SelectionChanged(object sender, EventArgs e) {
            tableToolsRibbonPageCategory1.Visible = richEditControl.IsSelectionInTable();
            floatingPictureToolsRibbonPageCategory1.Visible = richEditControl.IsFloatingObjectSelected;
        }
        void edtTo_EditValueChanged(object sender, EventArgs e) {
            isMessageModified = true;
        }
        void edtTo_ValidateToken(object sender, TokenEditValidateTokenEventArgs e) {
            string email = e.Description;
            if(!string.IsNullOrEmpty(this.messageFrom) && string.Equals(this.messageFrom, email, StringComparison.OrdinalIgnoreCase)) {
                e.IsValid = true;
                return;
            }
            if(TokenEditHelper.ValidateEmail(email)) {
                e.IsValid = true;
                e.Value = new UnknownContact(email);
            }
        }
        void edtTo_BeforeShowPopupPanel(object sender, TokenEditBeforeShowPopupPanelEventArgs e) {
            Contact contact = e.Value as Contact;
            this.lblDescription.Text = (contact != null) ? contact.Email : e.Description;
            this.lblMail.Text = e.Description;
            this.picContact.Image = (contact != null && contact.Photo != null) ? contact.Photo : Properties.Resources.Unknown_user;
        }
        void edtTo_CustomDrawGlyph(object sender, TokenEditCustomDrawTokenGlyphEventArgs e) {
            var image = GetTagGlyphImage(e.Value);
            if(image != null) {
                var paletteProvider = SvgPaletteHelper.GetSvgPalette(GetActiveLookAndFeel(), e.Info.GlyphState);
                using(var cache = new Utils.Drawing.GraphicsCache(e.Graphics))
                    e.Cache.Paint.DrawSvgImage(cache, image, e.GlyphBounds, paletteProvider);
            }
            e.Handled = true;
        }
        SvgImage GetTagGlyphImage(object tag) {
            Contact contact = tag as Contact;
            if(contact == null) return Properties.Resources.Owner;
            return contact.Icon;
        }
        //Size sendToEditSize = Size.Empty;
        //void edtTo_SizeChanged(object sender, EventArgs e) {
        //    Size newSize = ((TokenEdit)sender).Size;
        //    panelControl.Height += (newSize.Height - sendToEditSize.Height);
        //    this.sendToEditSize = newSize;
        //}
        void edtSubject_EditValueChanged(object sender, EventArgs e) {
            isMessageModified = true;
        }
        void fileSaveItem1_ItemClick(object sender, ItemClickEventArgs e) {
            ApplyChanges();
        }
        //void frmEditMail_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
        //    if (e.KeyCode == Keys.Escape) {
        //        if (QueryClose() != DialogResult.Cancel)
        //            Close();
        //    }
        //}
        void richEditControl_KeyDown(object sender, KeyEventArgs e) {
            if((e.Modifiers & Keys.Control) != 0 && e.KeyCode == Keys.S) {
                ApplyChanges();
                e.Handled = true;
            }
        }

        void frmEditMail_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult result = QueryClose();
            e.Cancel = result == DialogResult.Cancel;
        }
        DialogResult QueryClose() {
            if(!IsMessageModified)
                return DialogResult.Yes;

            DialogResult result = XtraMessageBox.Show(this, Properties.Resources.SaveQuestion, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            switch(result) {
                case DialogResult.Cancel:
                    return DialogResult.Cancel;
                case DialogResult.No:
                    return DialogResult.No;
                default:
                case DialogResult.Yes:
                    ApplyChanges();
                    return DialogResult.Yes;
            }
        }
        void ApplyChanges() {
            if(sourceMessage != null) {
                sourceMessage.Date = TutorialConstants.Now;
                sourceMessage.Text = richEditControl.MhtText;
                sourceMessage.SetPlainText(ObjectHelper.GetPlainTextFromMHT(richEditControl.MhtText));
                sourceMessage.Subject = edtSubject.Text;
                sourceMessage.From = TokenEditHelper.FormatContactList((IList<Contact>)edtTo.EditValue);
                if(((IList<Contact>)edtTo.EditValue).Count == 1)
                    sourceMessage.Email = ((IList<Contact>)edtTo.EditValue).FirstOrDefault<Contact>().Email;
            }
            IsMessageModified = false;
            RaiseSaveMessage();
        }
    }
}
