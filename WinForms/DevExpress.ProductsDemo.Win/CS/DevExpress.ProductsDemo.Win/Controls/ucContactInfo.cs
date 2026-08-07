using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace DevExpress.MailClient.Win.Controls {
    public partial class ucContactInfo : XtraUserControl {
        Timer tmr;
        Contact _contact;

        public ucContactInfo() {
            InitializeComponent();
            pePhoto.Properties.AllowAnimationOnValueChanged = Utils.DefaultBoolean.True;
        }
        public Contact Contact { get { return _contact; } }
        Timer PictureTimer {
            get {
                if(tmr == null) {
                    tmr = new Timer();
                    tmr.Interval = 100;
                    tmr.Enabled = false;
                    tmr.Tick += new EventHandler(tmr_Tick);
                }
                return tmr;
            }
        }
        void tmr_Tick(object sender, EventArgs e) {
            SizePhoto();
            PictureTimer.Stop();
        }
        public void Init(Contact contact, string toolTip) {
            if(contact != null) {
                pePhoto.Image = contact.Photo == null ? null : pePhoto.Image = contact.Photo;
                lbName.Text = contact.FullName.ToString();
                teEmail.Text = contact.Email;
                teBirthDate.Text = contact.BindingBirthDate.ToShortDateString();
                teAddress.Text = contact.Address.ToString();//.AddressLine;
                tePhone.Text = contact.Phone;
                teNotes.Text = contact.Note;
            }
            else {
                pePhoto.Image = null;
                teNotes.Text = tePhone.Text = teAddress.Text = teBirthDate.Text = teEmail.Text = lbName.Text = string.Empty;
            }

            //lciInfo.Visibility = contact == null ? LayoutVisibility.Never : LayoutVisibility.Always;
            //lcInfo.Text = GetContactInfo(contact);
            SizePhoto();
            if(!string.IsNullOrEmpty(toolTip)) {
                pePhoto.ToolTip = toolTip;
                pePhoto.Cursor = Cursors.Hand;
            }
            else pePhoto.Cursor = Cursors.Default;
            this._contact = contact;
            this.Refresh();
        }
        bool lockResize = false;
        void SizePhoto() {
            if(lockResize || (lcMain as ILayoutControl).IsUpdateLocked) return;
            lockResize = true;
            Image img = pePhoto.Image;
            try {
                if(img == null) {
                    lciPhoto.Visibility = LayoutVisibility.Never;
                    return;
                }
                else lciPhoto.Visibility = LayoutVisibility.Always;
                int resultHeight = (int)((double)img.Height * pePhoto.Properties.ZoomPercent / 100.0) + 4;
                if(pePhoto.Properties.ZoomPercent == 100)
                    lciPhoto.Height = Math.Min(lciPhoto.Width * img.Height / img.Width, resultHeight);
                else lciPhoto.Height = resultHeight;
            }
            finally {
                lockResize = false;
            }
        }
        private void pePhoto_Resize(object sender, EventArgs e) {
            PictureTimer.Start();
        }
        void ucContactInfo_SizeChanged(object sender, EventArgs e) {
            PictureTimer.Start();
        }
        string GetContactInfo(Contact contact) {
            if(contact == null) return string.Empty;
            return contact.GetContactInfoHtml();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float ZoomFactor {
            get { return (float)(pePhoto.Properties.ZoomPercent / 100); }
            set {
                if(value == 1) {
                    pePhoto.Properties.ZoomPercent = 100;
                    pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
                    pePhoto.Properties.ShowScrollBars = false;
                }
                else {
                    pePhoto.Properties.ZoomPercent = (int)(value * 100);
                    pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Clip;
                    pePhoto.Properties.ShowScrollBars = true;
                }
                SizePhoto();
            }
        }

        private void teEmail_OpenLink(object sender, XtraEditors.Controls.OpenLinkEventArgs e) {
            if(e.EditValue != null) e.EditValue = "mailto:" + e.EditValue.ToString();

        }
    }
}
