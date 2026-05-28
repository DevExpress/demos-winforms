using System;
using System.Collections.Generic;
using DevExpress.XtraRichEdit.API.Native;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class DocumentProtectionModule : TutorialControl {
        readonly UserService _userService = new UserService();

        public DocumentProtectionModule() {
            InitializeComponent();
            richEditControl.ReplaceService(_userService);
            LoadDocument("DocumentProtection.docx");
        }

        public override RichEditControl RichEdit { get { return richEditControl; } }

        void OnRichEditControlDocumentProtectionChanged(object sender, EventArgs e) {
            pnlAlert.Visible = richEditControl.Document.IsDocumentProtected;
            richEditControl.ClearUndo();
        }
        void OnRichEditControl1DocumentLoaded(object sender, EventArgs e) {
            RangePermissionCollection rangePermissions = richEditControl.Document.BeginUpdateRangePermissions();
            cbUsers.Items.Clear();
            richEditControl.Document.CancelUpdateRangePermissions(rangePermissions);
            List<String> users = FetchUsers(rangePermissions);
            cbUsers.Items.AddRange(users);

            _userService.Update(users);
            if(users.Count > 0) {
                SetActiveUser(users[0]);
                usersBarEditItem.Visibility = XtraBars.BarItemVisibility.Always;
            }
            else {
                SetActiveUser("guest");
                cbUsers.Items.Add("guest");
                usersBarEditItem.Visibility = XtraBars.BarItemVisibility.Never;
            }
            usersBarEditItem.EditValue = cbUsers.Items[0];
        }
        List<String> FetchUsers(RangePermissionCollection rangePermissions) {
            List<String> users = new List<string>();
            foreach(RangePermission rangePermission in rangePermissions) {
                string userName = rangePermission.UserName;
                if(!String.IsNullOrEmpty(userName) && !users.Contains(userName))
                    users.Add(userName);
            }
            return users;
        }
        void SetActiveUser(string user) {
            richEditControl.Options.Authentication.EMail = user;
        }
        void usersBarEditItem_EditValueChanged(object sender, EventArgs e) {
            SetActiveUser(usersBarEditItem.EditValue.ToString());
        }
    }
}
