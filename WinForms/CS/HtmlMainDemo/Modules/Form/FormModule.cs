using System.Collections.Generic;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.Utils.Html;
using DevExpress.Utils.DirectXForm.Painter;
using DevExpress.LookAndFeel;
using System.Windows.Forms;
using System;
using DevExpress.Skins.XtraForm;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.Utils.DPI;
using DevExpress.Utils.Drawing.Helpers;

namespace DevExpress.HTML.Demos {
    public partial class FormModule : TutorialControlBase {
        PreviewDirectXForm previewForm = new PreviewDirectXForm();

        public FormModule() {
            InitializeComponent();
            var customTemplate = new HtmlTemplate(previewForm.HtmlTemplate);
            customTemplate.Tag = "Custom HTML-CSS Template";

            previewForm.Text = "DirectX Form - Default HTML-CSS Template";
            previewForm.Size = new Size(800, 600);
            previewForm.Clear();
            previewForm.HtmlElementMouseClick += Form_HtmlElementMouseClick;
            DevExpress.Tutorials.TodoApp.PresentationHelper.CenterParent(hostPanel, previewForm);

            templateViewer.Init(previewForm, new HtmlTemplateCollection(new List<HtmlTemplate> {
                customTemplate,
                defaultTemplate,
            }));

            var previewContent = new HtmlContentControl();
            previewContent.Parent = previewForm;
            previewContent.Dock = DockStyle.Fill;
            previewContent.HtmlTemplate.Assign(contentTemplate);
            previewContent.ElementMouseClick += (s, e) => { 
                if(e.ElementId == "showform") ShowForm(); 
            };
        }

        void ShowForm() {
            using(var form = new DemoDirectXForm()) {
                form.HtmlTemplate.Assign(previewForm.HtmlTemplate);
                form.Size = ScaleDPI.ScaleSize(new Size(1000, 600));
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowDialog(this);
            }
        }

        void Form_HtmlElementMouseClick(object sender, DxHtmlElementMouseEventArgs e) {
            if(e.ElementId == "infobutton") {
                BeginInvoke(new Action(() => {
                    using(var aboutForm = new AboutDirectXForm(aboutFormTemplate, svgImages, ScaleDPI)) {
                        aboutForm.ShowDialog(this);
                    }
                }));
            }
        }

        #region Utils
        protected override void DoShow() {
            base.DoShow();
            if(previewForm != null && !previewForm.Visible)
                previewForm.Show();
        }
        protected override void DoHide() {
            if(previewForm != null && previewForm.Visible)
                previewForm.Hide();
            base.DoHide();
        }

        void OnPanelSizeChanged(object sender, EventArgs e) {
            if(previewForm == null)
                return;
            var size = ((Control)sender).Size;
            int padding = ScaleDPI.ScaleHorizontal(20);
            int minWidth = ScaleDPI.ScaleHorizontal(600);
            int minHeight = ScaleDPI.ScaleHorizontal(800);
            Size maxSize = ScaleDPI.ScaleSize(new Size(1000, 750));
            int height = Math.Min(size.Height - padding * 2, maxSize.Height);
            int width = Math.Min(size.Width - padding * 2, maxSize.Width);
            if(height > width * 3 / 4)
                height = width * 3 / 4;
            else width = height * 4 / 3;
            if(width < minWidth)
                width = minWidth;
            if(height < minHeight)
                height = minHeight;
            if(height > width * 3 / 4)
                height = width * 3 / 4;
            else width = height * 4 / 3;
            previewForm.SetBounds((size.Width - width) / 2, (size.Height - height) / 2, width, height);
        }
        #endregion Utils
    }

    #region PreviewForm
    class PreviewDirectXForm : DemoDirectXForm {
        protected override FormPainter CreateFormBorderPainter() {
            return new PreviewDirectXFormPainter(this, LookAndFeel);
        }
        internal void Clear() {
            foreach(Control control in Controls) {
                if(control != ContainerControl)
                    control.Dispose();
            }
        }
    }
    class PreviewDirectXFormPainter : DirectXFormPainter {
        public PreviewDirectXFormPainter(DirectXForm owner, UserLookAndFeel lf) : base(owner, lf) { }
        protected override void WMNCHitTest(ref Message msg) {
            base.WMNCHitTest(ref msg);
            if(msg.Result != IntPtr.Zero)
                msg.Result = new IntPtr(Utils.Drawing.Helpers.NativeMethods.HT.HTCLIENT);
        }
        protected override void OnClick(MouseEventArgs e, FormCaptionButtonAction kind) { }
    }
    #endregion PreviewForm

    public class AboutDirectXForm : DirectXForm {
        public AboutDirectXForm(HtmlTemplate template, object htmlImages, ScaleHelper scaleDpi) : base() {
            HtmlImages = htmlImages;
            HtmlTemplate.Assign(template);
            StartPosition = FormStartPosition.CenterParent;
            Size = scaleDpi.ScaleSize(FormDefaultSize);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HtmlElementMouseClick += OnHtmlElementMouseClick;
        }
        static readonly Size FormDefaultSize = new Size(660, 460);
        protected override void WndProc(ref Message m) {
            base.WndProc(ref m);
            if(m.Msg == MSG.WM_DPICHANGED)
                Size = ScaleDPI.ScaleSize(FormDefaultSize);
        }
        void OnHtmlElementMouseClick(object sender, DxHtmlElementMouseEventArgs e) {
            if(e.Element == null)
                return;
            var id = e.Element.Id;
            var parentId = e.Element.ParentElement?.Id;
            if(id == "contentbutton" || parentId == "contentbutton") {
                Close();
            }
        }
    }
}
