namespace DevExpress.ApplicationUI.Demos {
    partial class BaseControl {
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
            this.components = new System.ComponentModel.Container();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.Images = svgImageCollection1;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar"});
            this.dockManager1.RegisterDockPanel += new DevExpress.XtraBars.Docking.DockPanelEventHandler(this.dockManager1_RegisterDockPanel);
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("insertimage", "image://svgimages/richedit/insertimage.svg");
            this.svgImageCollection1.Add("private", "image://svgimages/scheduling/private.svg");
            this.svgImageCollection1.Add("glyph_mail", "image://svgimages/outlook inspired/glyph_mail.svg");
            this.svgImageCollection1.Add("pie", "image://svgimages/spreadsheet/pie.svg");
            this.svgImageCollection1.Add("task", "image://svgimages/outlook inspired/task.svg");
            this.svgImageCollection1.Add("editquery", "image://svgimages/dashboards/editquery.svg");
            // 
            // BaseControl
            // 
            this.Name = "BaseControl";
            this.Size = new System.Drawing.Size(276, 156);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected DevExpress.XtraBars.Docking.DockManager dockManager1;
        private System.ComponentModel.IContainer components;
        private Utils.SvgImageCollection svgImageCollection1;
    }
}
