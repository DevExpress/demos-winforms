
namespace DevExpress.HTML.Demos {
    partial class DemoDirectXForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoDirectXForm));
            this.directXFormContainerControl1 = new DevExpress.XtraEditors.DirectXFormContainerControl();
            this.svgImages = new DevExpress.Utils.SvgImageCollection(this.components);
            this.searchEdit = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.svgImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // directXFormContainerControl1
            // 
            this.directXFormContainerControl1.Location = new System.Drawing.Point(31, 93);
            this.directXFormContainerControl1.Name = "directXFormContainerControl1";
            this.directXFormContainerControl1.Size = new System.Drawing.Size(638, 224);
            this.directXFormContainerControl1.TabIndex = 0;
            // 
            // svgImages
            // 
            this.svgImages.Add("Back", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.Back"))));
            this.svgImages.Add("Close", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.Close"))));
            this.svgImages.Add("Forward", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.Forward"))));
            this.svgImages.Add("Info", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.Info"))));
            this.svgImages.Add("Search", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.Search"))));
            this.svgImages.Add("User", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.User"))));
            this.svgImages.Add("Add", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.Add"))));
            this.svgImages.Add("Logo", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.Logo"))));
            // 
            // searchEdit
            // 
            this.searchEdit.Location = new System.Drawing.Point(234, 43);
            this.searchEdit.Name = "searchEdit";
            this.searchEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.searchEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEdit.Properties.Appearance.Options.UseBackColor = true;
            this.searchEdit.Properties.Appearance.Options.UseFont = true;
            this.searchEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.searchEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.searchEdit.Properties.AutoHeight = false;
            this.searchEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.searchEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton()});
            this.searchEdit.Properties.ShowSearchButton = false;
            this.searchEdit.Size = new System.Drawing.Size(125, 40);
            this.searchEdit.TabIndex = 1;
            // 
            // DemoDirectXForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ChildControls.Add(this.directXFormContainerControl1);
            this.ChildControls.Add(this.searchEdit);
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.HtmlImages = this.svgImages;
            this.HtmlTemplate.Styles = resources.GetString("DemoDirectXForm.HtmlTemplate.Styles");
            this.HtmlTemplate.Template = resources.GetString("DemoDirectXForm.HtmlTemplate.Template");
            this.MinimumSize = new System.Drawing.Size(660, 400);
            this.Name = "DemoDirectXForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.svgImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        private Utils.SvgImageCollection svgImages;
        private XtraEditors.SearchControl searchEdit;
    }
}
