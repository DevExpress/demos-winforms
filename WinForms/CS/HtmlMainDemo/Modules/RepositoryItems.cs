using System.Drawing;
using DevExpress.Data.Utils.Security;
using DevExpress.Utils.Html;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.HTML.Demos {
    public partial class RepositoryItems : TutorialControl {
        string loginTemplate, signupTemplate;
        public RepositoryItems() {
            InitializeComponent();
            InitTemplates();
            InitCodeViewer();
            InitDataContext();
            EnsureSkinColors();
        }
        void InitTemplates() {
            loginTemplate = htmlContentControl.HtmlTemplate.Template;
            signupTemplate = Properties.Resources.SignUpTemplate;
        }
        void InitCodeViewer() {
            templateCodeViewer.Fill(htmlContentControl);
        }
        void InitDataContext() {
            var defaultPhoto = svgImageCollection1["default_photo"];
            bindingSource.DataSource = new UserInfo(defaultPhoto);
            htmlContentControl.DataContext = bindingSource;
        }
        void OnHtmlElementMouseDown(object sender, DxHtmlElementMouseEventArgs e) {
            if(e.ElementId == "signup") {
                loginTemplate = htmlContentControl.HtmlTemplate.Template;
                htmlContentControl.HtmlTemplate.Template = signupTemplate;
                templateCodeViewer.UpdateHtmlTemplate();
            }
            if(e.ElementId == "login") {
                signupTemplate = htmlContentControl.HtmlTemplate.Template;
                htmlContentControl.HtmlTemplate.Template = loginTemplate;
                templateCodeViewer.UpdateHtmlTemplate();
            }
            if(e.ElementId == "choose_Photo") {
                htmlContentControl.ShowEditor("Photo");
                if(htmlContentControl.ActiveEditor != null)
                    ((PictureEdit)htmlContentControl.ActiveEditor).LoadImage();
            }
        }
        void OnPictureEditImageChanged(object sender, System.EventArgs e) {
            pictureEdit.OptionsMask.MaskType = htmlContentControl.ActiveEditor.EditValue != null
                ? PictureEditMaskType.Circle : PictureEditMaskType.None;
        }
        protected override void OnLookAndFeelChanged() {
            EnsureSkinColors();
        }
        void EnsureSkinColors() {
            var checkedImage = checkEdit.ImageOptions.SvgImageChecked;
            checkEdit.ImageOptions.SvgImageChecked = null;
            if(checkedImage.DefaultStyle == null)
                checkedImage.DefaultStyle = new SvgStyle();
            checkedImage.DefaultStyle.SetValue("fill", GetSkinColor("@HighlightAlternate"));
            checkEdit.ImageOptions.SvgImageChecked = checkedImage;
        }
        string GetSkinColor(string skinColorName) {
            return ColorTranslator.ToHtml(DevExpress.Utils.Colors.DXSkinColorHelper.GetDXSkinColor(Skins.ColorCreator.Create(skinColorName), LookAndFeel));
        }
    }
    public class UserInfo {
        byte[] photo;
        readonly SvgImage defaultPhoto;
        public UserInfo(SvgImage defaultPhoto) {
            this.defaultPhoto = defaultPhoto;
        }
        public string Email { get; set; }
        readonly SensitiveData passwordData = SensitiveData.CreateForCurrentUser();
        public string Password {
            get { return passwordData.Text; }
            set { passwordData.Text = value; }
        }
        readonly SensitiveData confirmData = SensitiveData.CreateForCurrentUser();
        public string Confirm {
            get { return confirmData.Text; }
            set { confirmData.Text = value; }
        }
        public bool Agreement { get; set; }
        public bool IsDefaultPhoto => photo == null;
        public bool HasPhoto => !IsDefaultPhoto;
        public object Photo {
            get { return (object)photo ?? defaultPhoto; }
            set {
                if(photo == value)
                    return;
                photo = value as byte[];
            }
        }
    }
}
