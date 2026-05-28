using System.Collections.Generic;
using System.Data;
using System.Linq;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;

namespace DevExpress.MailClient.Win.Controls {
    public partial class ucMessageInfo : XtraUserControl {
        public ucMessageInfo() {
            InitializeComponent();
            if(RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                tabbedControlGroup1.TextLocation = Utils.Locations.Right;
        }
        public void Init(Message message, IDXMenuManager menuManager) {
            gridControl1.MenuManager = menuManager;
            lcName.Text = message.From;
            var userImg = DataHelper.GetPhotoByEmail(message.Email) ?? Properties.Resources.Unknown_user;
            pictureEdit1.Image = userImg;
            gridControl1.DataSource = GetMailByContactData(message);
            lcgContact.Text = Properties.Resources.Contact;
            lcgMail.Text = string.Format("{0} ({1})", Properties.Resources.Mail1, gridView1.DataRowCount);
        }
        static List<Message> GetMailByContactData(Message messageMain) {
            var results = from message in DataHelper.Messages
                          where message.From == messageMain.From && message.MailType == MailType.Inbox
                          select message;
            return results.ToList();
        }
    }
}
