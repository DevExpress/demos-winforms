using System.Windows.Forms;


namespace XtraReportsDemos {
    public class MainFeaturesControl : XtraReportsDemos.ModuleControl {
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private RichTextBox rtbFeatures;
        private readonly System.ComponentModel.IContainer components = null;

        public MainFeaturesControl() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            rtbFeatures = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(xtraTabControl1)).BeginInit();
            xtraTabControl1.SuspendLayout();
            xtraTabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // xtraTabControl1
            // 
            xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            xtraTabControl1.Name = "xtraTabControl1";
            xtraTabControl1.SelectedTabPage = xtraTabPage1;
            xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            xtraTabControl1.Size = new System.Drawing.Size(184, 124);
            xtraTabControl1.TabIndex = 0;
            xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            xtraTabPage1});
            xtraTabControl1.Text = "xtraTabControl1";
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(rtbFeatures);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new System.Drawing.Size(175, 115);
            xtraTabPage1.Text = "xtraTabPage1";
            // 
            // rtbFeatures
            // 
            rtbFeatures.BackColor = System.Drawing.Color.White;
            rtbFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            rtbFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
            rtbFeatures.ForeColor = System.Drawing.Color.Black;
            rtbFeatures.Location = new System.Drawing.Point(0, 0);
            rtbFeatures.Name = "rtbFeatures";
            rtbFeatures.ReadOnly = true;
            rtbFeatures.Size = new System.Drawing.Size(175, 115);
            rtbFeatures.TabIndex = 1;
            rtbFeatures.Text = "";
            // 
            // MainFeaturesControl
            // 
            Controls.Add(xtraTabControl1);
            Name = "MainFeaturesControl";
            Size = new System.Drawing.Size(184, 124);
            ((System.ComponentModel.ISupportInitialize)(xtraTabControl1)).EndInit();
            xtraTabControl1.ResumeLayout(false);
            xtraTabPage1.ResumeLayout(false);
            ResumeLayout(false);

        }
        #endregion
        public override void Activate() {
            if(DesignMode) return;
            rtbFeatures.Rtf = XtraReportsDemos.Properties.Resources.ReportsAbout;
        }
    }
}

