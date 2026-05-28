using System.Drawing;
using System.Windows.Forms;
using DevExpress.Data.Mask;
using DevExpress.Data.Utils.Security;
using DevExpress.Utils.Html;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.HTML.Demos {
    public class DialogLoginControl : HtmlContentControl {
        readonly BindingSource source = new BindingSource();
        public DialogLoginControl(HtmlTemplate html) {
            source.DataSource = new UserInfo();
            DataContext = source;
            HtmlTemplate.Assign(html);
            RepositoryItems.AddRange(new RepositoryItem[] { EmailEdit, PassEdit });
            MinimumSize = Size = new Size(350, 140);
        }
        RepositoryItem emailEdit;
        public RepositoryItem EmailEdit {
            get { return emailEdit ?? (emailEdit = CreateEmailEdit()); }
        }
        RepositoryItem CreateEmailEdit() {
            var editor = new RepositoryItemTextEdit();
            editor.BorderStyle = BorderStyles.NoBorder;
            editor.MaskSettings.Set("MaskManagerType", typeof(RegExpMaskManager));
            editor.MaskSettings.Set("allowBlankInput", true);
            editor.MaskSettings.Set("mask", "\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");
            editor.Name = "emailEdit";
            editor.NullValuePrompt = "Email Address";
            return editor;
        }
        RepositoryItem passEdit;
        public RepositoryItem PassEdit {
            get { return passEdit ?? (passEdit = CreatePassEdit()); }
        }
        RepositoryItem CreatePassEdit() {
            var editor = new RepositoryItemTextEdit();
            editor.BorderStyle = BorderStyles.NoBorder;
            editor.Name = "passEdit";
            editor.NullValuePrompt = "Password";
            editor.PasswordChar = '*';
            return editor;
        }
        //
        class UserInfo {
            public string Email { get; set; }
            readonly SensitiveData passwordData = SensitiveData.CreateForCurrentUser();
            public string Password {
                get { return passwordData.Text; }
                set { passwordData.Text = value; }
            }
        }
    }

    public class DialogFeedbackControl : HtmlContentControl {
        readonly BindingSource source = new BindingSource();
        public DialogFeedbackControl(HtmlTemplate html) {
            source.DataSource = new FeedbackInfo();
            DataContext = source;
            HtmlTemplate.Assign(html);
            RepositoryItems.AddRange(new RepositoryItem[] { RatingEdit, FeedbackEdit });
            MinimumSize = Size = new Size(350, 275);
        }
        RepositoryItem ratingEdit;
        public RepositoryItem RatingEdit {
            get { return ratingEdit ?? (ratingEdit = CreateRatingEdit()); }
        }
        RepositoryItem CreateRatingEdit() {
            var editor = new RepositoryItemRatingControl();
            editor.AutoHeight = false;
            editor.ItemIndent = 20;
            editor.Name = "ratingEdit";
            return editor;
        }
        RepositoryItem feedbackEdit;
        public RepositoryItem FeedbackEdit {
            get { return feedbackEdit ?? (feedbackEdit = CreateFeedbackEdit()); }
        }
        RepositoryItem CreateFeedbackEdit() {
            var editor = new RepositoryItemMemoEdit();
            editor.BorderStyle = BorderStyles.NoBorder;
            editor.ScrollBars = ScrollBars.None;
            editor.NullValuePrompt = "Tell us what you think";
            editor.Name = "feedbackEdit";
            return editor;
        }
        //
        public class FeedbackInfo {
            public float Rating { get; set; }
            public string Feedback { get; set; }
        }
    }
}
