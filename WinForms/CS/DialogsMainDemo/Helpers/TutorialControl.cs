namespace DevExpress.XtraDialogs.Demos {
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using DevExpress.DXperience.Demos;
    using DevExpress.Utils.Drawing;
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.ViewInfo;

    public class TutorialControl : TutorialControlBase {
        protected override string ModulesFolder { 
            get { return "DialogsMainDemo\\Modules\\"; } 
        }
        protected override string CodeInfoFolder { 
            get { return "DevExpress.XtraDialogs.Demos.CodeInfo"; }
        }
    }
    public partial class MainModule : XtraUserControl {
        public MainModule() {
            InitializeComponent();
            this.memoEdit1.LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
            LookAndFeel_StyleChanged(this.memoEdit1, EventArgs.Empty);
        }
        System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) {
            this.memoEdit1.LookAndFeel.StyleChanged -= LookAndFeel_StyleChanged;
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Component Designer generated code
        void InitializeComponent() {
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // memoEdit1
            // 
            this.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit1.EditValue = "Text";
            this.memoEdit1.Location = new System.Drawing.Point(0, 0);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.memoEdit1.Properties.Appearance.Options.UseFont = true;
            this.memoEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.memoEdit1.Size = new System.Drawing.Size(547, 300);
            this.memoEdit1.TabIndex = 2;
            this.memoEdit1.TextChanged += new System.EventHandler(this.MemoEdit_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(547, 300);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Click buttons on the right panel to start";
            // 
            // MainModule
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.memoEdit1);
            this.Name = "MainModule";
            this.Size = new System.Drawing.Size(547, 300);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        DevExpress.XtraEditors.MemoEdit memoEdit1;
        XtraEditors.LabelControl labelControl1;
        public event EventHandler DocumentLoaded;
        protected void RaiseDocumentLoaded() {
            var handler = this.DocumentLoaded;
            if(handler != null) handler(this, EventArgs.Empty);
        }
        public void LoadDocument(string documentPath) {
            if(File.Exists(documentPath)) {
                this.memoEdit1.Text = System.IO.File.ReadAllText(documentPath);
                this.labelControl1.Visible = false;
                RaiseDocumentLoaded();
            }
        }
        public void SaveDocument(string documentPath) {
            File.WriteAllText(documentPath, this.memoEdit1.Text);
        }
        void LookAndFeel_StyleChanged(object sender, System.EventArgs e) {
            this.labelControl1.BackColor = this.memoEdit1.BackColor;
        }
        void MemoEdit_TextChanged(object sender, EventArgs e) {
            MemoEditViewInfo vi = this.memoEdit1.GetViewInfo() as MemoEditViewInfo;
            using(var graphics = memoEdit1.CreateGraphics()) {
                using(var cache = new GraphicsCache(graphics, ScaleDPI)) {
                    int h = (vi as DevExpress.XtraEditors.ViewInfo.IHeightAdaptable).CalcHeight(cache, vi.MaskBoxRect.Width);
                    ObjectInfoArgs args = new ObjectInfoArgs();
                    args.Bounds = new Rectangle(0, 0, vi.ClientRect.Width, h);
                    Rectangle rect = vi.BorderPainter.CalcBoundsByClientRectangle(args);
                    memoEdit1.Properties.ScrollBars = rect.Height > memoEdit1.Height ? ScrollBars.Vertical : ScrollBars.None;
                }
            }
        }
    }
}
