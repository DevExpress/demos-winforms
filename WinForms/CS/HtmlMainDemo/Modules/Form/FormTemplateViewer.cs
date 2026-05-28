using System;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.Utils.Html;

namespace DevExpress.HTML.Demos {
    public class FormTemplateViewer : TemplateCodeViewer {
        DirectXForm form;
        Timer previewTimer = new Timer();
        public FormTemplateViewer() {
            this.lciTemplate.Text = "Choose the Template:";
            this.iceTemplates.EditValueChanged += OnActiveTemplateChanged;
            previewTimer.Interval = 500;
            previewTimer.Tick += OnUpdatePreview;
            previewTimer.Start();
        }
        void OnUpdatePreview(object sender, EventArgs e) {
            if(form == null || ActiveTemplate == null)
                return;
            if(ActiveTemplate.Styles != form.HtmlTemplate.Styles || ActiveTemplate.Template != form.HtmlTemplate.Template)
                form.HtmlTemplate.Assign(ActiveTemplate);
        }
        void OnActiveTemplateChanged(object sender, EventArgs e) {
            form.HtmlTemplate.Assign(ActiveTemplate);
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
        public HtmlTemplate ActiveTemplate {
            get { return (HtmlTemplate)iceTemplates.EditValue; }
        }
        public void Init(DirectXForm form, HtmlTemplateCollection templates) {
            this.form = form;
            FillTemplates(templates);
        }
    }
}
