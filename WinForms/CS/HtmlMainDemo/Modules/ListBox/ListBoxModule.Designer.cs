namespace DevExpress.HTML.Demos {
    partial class ListBoxModule {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBoxModule));
            this.listBoxControl = new DevExpress.XtraEditors.ListBoxControl();
            this.svgImageCollection = new DevExpress.Utils.SvgImageCollection(this.components);
            this.htmlTemplate1 = new DevExpress.Utils.Html.HtmlTemplate();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.listBoxTemplateCodeViewer1 = new DevExpress.HTML.Demos.ListBoxTemplateCodeViewer();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.htmlContentPopup = new DevExpress.XtraEditors.HtmlContentPopup(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentPopup)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxControl
            // 
            this.listBoxControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.listBoxControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl.HtmlImages = this.svgImageCollection;
            this.listBoxControl.HtmlTemplates.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            this.htmlTemplate1});
            this.listBoxControl.ItemHeight = 72;
            this.listBoxControl.Location = new System.Drawing.Point(2, 23);
            this.listBoxControl.Name = "listBoxControl";
            this.listBoxControl.Size = new System.Drawing.Size(290, 469);
            this.listBoxControl.TabIndex = 0;
            // 
            // svgImageCollection
            // 
            this.svgImageCollection.Add("about", "image://svgimages/outlook inspired/about.svg");
            this.svgImageCollection.Add("Beak.Left", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection.Beak.Left"))));
            this.svgImageCollection.Add("Message", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection.Message"))));
            this.svgImageCollection.Add("PhoneCall", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection.PhoneCall"))));
            this.svgImageCollection.Add("VideoCall", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection.VideoCall"))));
            this.svgImageCollection.Add("Contact", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection.Contact"))));
            // 
            // htmlTemplate1
            // 
            this.htmlTemplate1.Name = "htmlTemplate1";
            this.htmlTemplate1.Styles = resources.GetString("htmlTemplate1.Styles");
            this.htmlTemplate1.Tag = "Item Template";
            this.htmlTemplate1.Template = resources.GetString("htmlTemplate1.Template");
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.listBoxTemplateCodeViewer1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(228, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(642, 467);
            this.sidePanel1.TabIndex = 1;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // listBoxTemplateCodeViewer1
            // 
            this.listBoxTemplateCodeViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTemplateCodeViewer1.Location = new System.Drawing.Point(1, 0);
            this.listBoxTemplateCodeViewer1.Name = "listBoxTemplateCodeViewer1";
            this.listBoxTemplateCodeViewer1.Size = new System.Drawing.Size(641, 467);
            this.listBoxTemplateCodeViewer1.TabIndex = 0;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 300F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)});
            this.tablePanel1.Controls.Add(this.groupControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 500F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F)});
            this.tablePanel1.Size = new System.Drawing.Size(228, 467);
            this.tablePanel1.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.tablePanel1.SetColumn(this.groupControl1, 1);
            this.groupControl1.Controls.Add(this.listBoxControl);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.tablePanel1.SetRow(this.groupControl1, 1);
            this.groupControl1.Size = new System.Drawing.Size(294, 494);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Contacts";
            // 
            // htmlContentPopup
            // 
            this.htmlContentPopup.HideOnElementClick = DevExpress.Utils.DefaultBoolean.True;
            this.htmlContentPopup.HtmlImages = this.svgImageCollection;
            this.htmlContentPopup.HtmlTemplate.Styles = resources.GetString("htmlContentPopup.HtmlTemplate.Styles");
            this.htmlContentPopup.HtmlTemplate.Tag = "Popup Template";
            this.htmlContentPopup.HtmlTemplate.Template = resources.GetString("htmlContentPopup.HtmlTemplate.Template");
            // 
            // ListBoxModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "ListBoxModule";
            this.Size = new System.Drawing.Size(870, 467);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentPopup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.ListBoxControl listBoxControl;
        private Utils.SvgImageCollection svgImageCollection;
        private Utils.Html.HtmlTemplate htmlTemplate1;
        private XtraEditors.SidePanel sidePanel1;
        private ListBoxTemplateCodeViewer listBoxTemplateCodeViewer1;
        private Utils.Layout.TablePanel tablePanel1;
        private XtraEditors.GroupControl groupControl1;
        private XtraEditors.HtmlContentPopup htmlContentPopup;
    }
}
