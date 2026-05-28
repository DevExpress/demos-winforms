using System;
using DevExpress.Utils.Html;
using DevExpress.XtraBars.Alerter;

namespace DevExpress.HTML.Demos {
    public class AlertControlTemplateViewer : TemplateCodeViewer {
        AlertControl control;
        public AlertControlTemplateViewer() : base() {
            this.lciTemplate.Text = "Choose the Template:";
            this.iceTemplates.EditValueChanged += IceTemplates_EditValueChanged;
        }
        void IceTemplates_EditValueChanged(object sender, EventArgs e) {
            ActiveTemplateChanged?.Invoke(this, e);
        }
        public HtmlTemplate ActiveTemplate {
            get { return (HtmlTemplate)iceTemplates.EditValue; }
        }
        public event EventHandler ActiveTemplateChanged;
        public void Init(AlertControl control) {
            this.control = control;
            FillTemplates(control.HtmlTemplates);
        }

        private void InitializeComponent() {
            ((System.ComponentModel.ISupportInitialize)(this.iceTemplates.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // iceTemplates
            // 
            // 
            // AlertControlTemplateViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "AlertControlTemplateViewer";
            ((System.ComponentModel.ISupportInitialize)(this.iceTemplates.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTemplate)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
