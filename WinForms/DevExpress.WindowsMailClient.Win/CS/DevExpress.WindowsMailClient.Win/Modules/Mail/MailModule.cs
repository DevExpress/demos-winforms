using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.Utils.Svg;
using DevExpress.WindowsMailClient.Win.Data;
using DevExpress.WindowsMailClient.Win.Properties;
using DevExpress.WindowsMailClient.Win.ViewModels;

namespace DevExpress.WindowsMailClient.Win.Modules {
    public partial class MailModule : BaseModule {
        static Regex EmailRegex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.Compiled);
        public MailModule() : base(typeof(MailViewModel)) {
            InitializeComponent();
            LoadDefaultText();
            this.tEditTo.Properties.AutoHeight = false;
        }
        public MailViewModel ViewModel {
            get { return GetViewModel<MailViewModel>(); }
        }
        void LoadDefaultText() {
            if(Utils.Utils.UseAsEmailSignature)
                editMail.MhtText = Utils.Utils.StartMhtText;
        }
        public bool SaveMessageToDrafts() {
            if(teFrom.EditValue != null) {
                ViewModel.SaveMessageToDrafts(editMail.MhtText, tEditSubject.Text, tEditTo.EditValue, teFrom.EditValue);

                return true;
            }
            return false;
        }
        public void Init() {
            this.tEditSubject.Text = null;
            this.tEditTo.EditValue = null;
            this.teFrom.EditValue = null;
            LoadDefaultText();
        }

        void tEditTo_CustomDrawTokenGlyph(object sender, XtraEditors.TokenEditCustomDrawTokenGlyphEventArgs e) {
            SvgImage image = Resources.newemployee;
            SvgBitmap bm = new SvgBitmap(image);
            var palette = SvgPaletteHelper.GetSvgPalette(this.LookAndFeel, ObjectState.Normal);
            if(image != null) e.Cache.Paint.DrawImage(e.Graphics, bm.Render(palette), e.GlyphBounds, new Rectangle(Point.Empty, new Size((int)image.Width, (int)image.Height)), true);
            e.Handled = true;
        }

        void tEditTo_ValidateToken(object sender, XtraEditors.TokenEditValidateTokenEventArgs e) {
            string email = e.Description;
            if(!string.IsNullOrEmpty(Utils.Utils.MessageFrom) && string.Equals(Utils.Utils.MessageFrom, email, StringComparison.OrdinalIgnoreCase)) {
                e.IsValid = true;
                return;
            }
            if(EmailRegex.IsMatch(email)) {
                e.IsValid = true;
            }
        }
        protected override void WndProc(ref System.Windows.Forms.Message m) {
            if(m.Msg == 528 || m.Msg == MSG.WM_LBUTTONDBLCLK || m.Msg == MSG.WM_LBUTTONDOWN || m.Msg == MSG.WM_LBUTTONDOWN) { 
                this.GetParentViewModel<MainViewModel>().HideAllPanels();
            }
            base.WndProc(ref m);
        }
        public void ShowMessage(Message message) {
            this.tEditSubject.Text = message.Subject;
            if(!string.IsNullOrEmpty(message.Email))
                this.tEditTo.EditValue = new List<string>() { message.Email };
            if(!string.IsNullOrEmpty(message.From) && !EmailRegex.IsMatch(message.From))
                this.teFrom.EditValue = new List<string>() { Utils.Utils.MessageFrom };
            this.editMail.MhtText = message.Text;
        }

        void tEditTo_BeforeShowPopupPanel(object sender, XtraEditors.TokenEditBeforeShowPopupPanelEventArgs e) {
        }
    }
}
