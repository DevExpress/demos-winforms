using DevExpress.Utils;
using DevExpress.Utils.Html;
using System;
using System.Windows.Forms;

namespace DevExpress.HTML.Demos {
    public class ToolTipTemplateViewer : TemplateCodeViewer {
        HtmlToolTipWindowBase form;
        Timer previewTimer = new Timer();
        public event EventHandler ActiveTemplateChanged;
        public ToolTipTemplateViewer() {
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
        public void Init(HtmlToolTipWindowBase form, HtmlTemplateCollection templates) {
            this.form = form;
            FillTemplates(templates);
        }

        private void InitializeComponent() {
            ((System.ComponentModel.ISupportInitialize)(this.iceTemplates.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // iceTemplates
            // 
            this.iceTemplates.Size = new System.Drawing.Size(417, 20);
            // 
            // lciTemplate
            // 
            this.lciTemplate.Size = new System.Drawing.Size(421, 47);
            // 
            // ToolTipTemplateViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "ToolTipTemplateViewer";
            this.Size = new System.Drawing.Size(441, 504);
            ((System.ComponentModel.ISupportInitialize)(this.iceTemplates.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTemplate)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
