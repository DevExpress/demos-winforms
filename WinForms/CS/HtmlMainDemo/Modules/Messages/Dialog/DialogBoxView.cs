using DevExpress.Skins;
using DevExpress.Tutorials.TodoApp;
using DevExpress.Utils.Html;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Internal;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DevExpress.HTML.Demos {
    public partial class DialogBoxView : XtraUserControl {
        HtmlDialogForm preview;

        public DialogBoxView() {
            InitializeComponent();
            svgImages.Add("logo", DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages["logo"]);
            dialogTemplateViewer.Init(preview, htmlDialogTemplateCollection);
        }
        protected override void OnFirstLoad() {
            base.OnFirstLoad();
            hostDialog.SizeChanged += (s, e) => CenterPreview();
        }
        XtraDialogArgs CreateLoginArgs() {
            return CreateDialogArgs(new DialogLoginControl(loginTemplate) { HtmlImages = svgImages });
        }
        XtraDialogArgs CreateFeedbackArgs() {
            return CreateDialogArgs(new DialogFeedbackControl(feedbackTemplate) { HtmlImages = svgImages }, "Feedback");
        }
        XtraDialogArgs CreateDialogArgs(Control content, string caption = "") {
            var args = new XtraDialogArgs();
            args.HtmlImages = svgImages;
            args.Caption = caption;
            args.Content = content;
            return args;
        }

        void OnShowDialogBoxButtonClick(object sender, EventArgs e) {
            XtraDialogArgs args = dialogTemplateViewer.ActiveTemplate.Name == loginFormTemplate.Name ? CreateLoginArgs() : CreateFeedbackArgs();
            args.HtmlTemplate.Assign(dialogTemplateViewer.ActiveTemplate);
            XtraDialog.Show(args);
        }
        void OnActiveTemplateChanged(object sender, EventArgs e) {
            UpdatePreview();
            PresentationHelper.CenterParent(hostDialog, preview);
            dialogTemplateViewer.UpdateForm(preview);
        }
        void UpdatePreview() {
            preview?.Dispose();
            preview = new HtmlDialogForm() { FormBorderStyle = FormBorderStyle.FixedDialog, MinimizeBox = false, MaximizeBox = false };
            preview.SizeChanged += (s, e) => CenterPreview();
            var args = dialogTemplateViewer.ActiveTemplate.Name == loginFormTemplate.Name ? CreateLoginArgs() : CreateFeedbackArgs();
            (preview as IMessageForm<XtraDialogArgs>).Message = args;
            preview.HtmlTemplate.Assign(dialogTemplateViewer.ActiveTemplate);
        }
        void CenterPreview() {
            preview.Bounds = RectangleHelper.GetCenterBounds(hostDialog.ClientRectangle, preview.Size);
        }
    }
}
