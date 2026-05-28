using DevExpress.Utils;
using DevExpress.Utils.Html;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace DevExpress.HTML.Demos {
    public class DialogBoxTemplateViewer : TemplateCodeViewer {
        HtmlDialogForm form;
        Timer previewTimer = new Timer();
        public event EventHandler ActiveTemplateChanged;
        public DialogBoxTemplateViewer() {
            this.lciTemplate.Text = "Choose the Template:";
            this.iceTemplates.EditValueChanged += OnActiveTemplateChanged;
            previewTimer.Interval = 500;
            previewTimer.Tick += OnUpdatePreview;
            previewTimer.Start();
        }
        public HtmlTemplate ActiveTemplate {
            get { return (HtmlTemplate)iceTemplates.EditValue; }
        }
        void OnUpdatePreview(object sender, EventArgs e) {
            if(form == null || ActiveTemplate == null)
                return;
            if(ActiveTemplate.Styles != form.HtmlTemplate.Styles || ActiveTemplate.Template != form.HtmlTemplate.Template)
                form.HtmlTemplate.Assign(ActiveTemplate);
        }
        void OnActiveTemplateChanged(object sender, EventArgs e) {
            OnUpdatePreview(sender, e);
            ActiveTemplateChanged?.Invoke(sender, e);
        }
        protected override void Dispose(bool disposing) {
            iceTemplates.EditValueChanged -= OnActiveTemplateChanged;
            if(previewTimer != null)
                previewTimer.Tick -= OnUpdatePreview;
            DisposeHelper.Dispose(ref previewTimer);
            base.Dispose(disposing);
        }
        protected override void LayoutChanged() {
            this.form.Update();
        }
        public void Init(HtmlDialogForm form, HtmlTemplateCollection templates) {
            UpdateForm(form);
            FillTemplates(templates);
        }
        public void UpdateForm(HtmlDialogForm form) {
            this.form = form;
        }
    }
}
