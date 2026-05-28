using DevExpress.Skins;
using DevExpress.Tutorials.TodoApp;
using DevExpress.Utils.Html;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Internal;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DevExpress.HTML.Demos {
    public partial class MessageBoxView : XtraUserControl {
        HtmlMessageBoxForm preview = new HtmlMessageBoxForm() { FormBorderStyle = FormBorderStyle.FixedDialog, MinimizeBox = false, MaximizeBox = false };
        public MessageBoxView() {
            InitializeComponent();
            propertiesMessageBox.Changed += (s, e) => UpdatePreview();
            templateViewer.ActiveTemplateChanged += (s, e) => { InitMessageBox(templateViewer.ActiveTemplate); UpdatePreview(); };
            templateViewer.Init(preview, htmlMessageTemplateCollection);
        }
        protected override void OnFirstLoad() {
            base.OnFirstLoad();
            PresentationHelper.CenterParent(hostMessage, preview);
            hostMessage.SizeChanged += (s, e) => CenterPreview();
        }
        XtraMessageBoxArgs CreateMessageBoxArgs() {
            XtraMessageBoxArgs args = propertiesMessageBox.GetMessageArgs();
            args.HtmlImages = svgImages;
            args.HtmlTemplate.Assign(templateViewer.ActiveTemplate);
            args.Caption = propertiesMessageBox.Caption;
            args.Text = propertiesMessageBox.MessageText;
            args.ImageOptions.SvgImage = propertiesMessageBox.SvgImage;
            args.DefaultButtonIndex = 0;
            return args;
        }
        void OnShowMessageBoxButtonClick(object sender, EventArgs e) {
            var args = CreateMessageBoxArgs();
            var result = XtraMessageBox.Show(args);
            messageBoxResult.Output(result);
        }
        void InitMessageBox(HtmlTemplate currentTemplate) {
            if(currentTemplate == confirmMessageTemplate2)
                propertiesMessageBox.Init("Delete file permanently?", "If you delete this file you won't be able to recover it. Do you want to delete it?", false);
            else if(currentTemplate == notificationMessageTemplate1)
                propertiesMessageBox.Init("Successful", "Your changes have been successfully saved.", true);
            else if(currentTemplate == confirmMessageTemplate1)
                propertiesMessageBox.Init("Application", "Do you want to save changes to the file?", false);
        }
        void UpdatePreview() {
            (preview as IMessageForm<XtraMessageBoxArgs>).Message = CreateMessageBoxArgs();
            CenterPreview();
        }
        void CenterPreview() {
            preview.Bounds = RectangleHelper.GetCenterBounds(hostMessage.ClientRectangle, preview.Size);
        }
    }
}
