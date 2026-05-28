
using DevExpress.XtraEditors;

namespace DevExpress.HTML.Demos {
    partial class HamburgerMenuModule {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HamburgerMenuModule));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.aceUsers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acEmployees = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acCustomers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acVendors = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceProducts = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acVideoPlayers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acMonitors = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acProjectors = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acTelevisions = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement13 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acVideoPlayers2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acMonitors2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acProjectors2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acTelevisions2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.accordionControlTemplateCodeViewer1 = new DevExpress.HTML.Demos.AccordionControlTemplateCodeViewer();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.sidePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceUsers,
            this.aceProducts,
            this.accordionControlElement13});
            this.accordionControl1.HtmlImages = this.svgImageCollection1;
            this.accordionControl1.HtmlTemplates.FooterElement.Styles = resources.GetString("accordionControl1.HtmlTemplates.FooterElement.Styles");
            this.accordionControl1.HtmlTemplates.FooterElement.Template = "<div class=\"item\">\r\n\t<div class=\"image-container\">\r\n\t\t<img class=\"item-image\" src" +
    "=\"${Image}\" width=\"24\" height=\"24\"/>\r\n\t</div>\r\n</div>\r\n";
            this.accordionControl1.HtmlTemplates.FooterPanel.Styles = resources.GetString("accordionControl1.HtmlTemplates.FooterPanel.Styles");
            this.accordionControl1.HtmlTemplates.FooterPanel.Template = "<div class=\"footer-panel\">\r\n\t<div id=\"content\" class=\"content\"></div>\r\n</div>\r\n";
            this.accordionControl1.HtmlTemplates.HamburgerHeaderPanel.Styles = resources.GetString("accordionControl1.HtmlTemplates.HamburgerHeaderPanel.Styles");
            this.accordionControl1.HtmlTemplates.HamburgerHeaderPanel.Template = resources.GetString("accordionControl1.HtmlTemplates.HamburgerHeaderPanel.Template");
            this.accordionControl1.HtmlTemplates.HamburgerMenuButton.Styles = resources.GetString("accordionControl1.HtmlTemplates.HamburgerMenuButton.Styles");
            this.accordionControl1.HtmlTemplates.HamburgerMenuButton.Template = resources.GetString("accordionControl1.HtmlTemplates.HamburgerMenuButton.Template");
            this.accordionControl1.HtmlTemplates.Item.Styles = resources.GetString("accordionControl1.HtmlTemplates.Item.Styles");
            this.accordionControl1.HtmlTemplates.Item.Template = resources.GetString("accordionControl1.HtmlTemplates.Item.Template");
            this.accordionControl1.HtmlTemplates.MinimizedElement.Styles = resources.GetString("accordionControl1.HtmlTemplates.MinimizedElement.Styles");
            this.accordionControl1.HtmlTemplates.MinimizedElement.Template = resources.GetString("accordionControl1.HtmlTemplates.MinimizedElement.Template");
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.PopupFormAutoHeightMode = DevExpress.XtraBars.Navigation.AccordionPopupFormAutoHeightMode.FitContent;
            this.accordionControl1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.accordionControl1.Size = new System.Drawing.Size(290, 559);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            this.accordionControl1.QueryHtmlElementData += new DevExpress.XtraBars.Navigation.QueryAccordionHtmlElementDataEventHandler(this.accordionControl1_QueryHtmlElementData);
            this.accordionControl1.HtmlElementMouseClick += new DevExpress.XtraBars.Navigation.AccordionHtmlElementEventHandler(this.accordionControl1_HtmlElementMouseClick);
            // 
            // aceUsers
            // 
            this.aceUsers.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acEmployees,
            this.acCustomers,
            this.acVendors});
            this.aceUsers.Expanded = true;
            this.aceUsers.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("aceUsers.ImageOptions.SvgImage")));
            this.aceUsers.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.aceUsers.Name = "aceUsers";
            this.aceUsers.Text = "MAIN";
            // 
            // acEmployees
            // 
            this.acEmployees.Appearance.Default.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.acEmployees.Appearance.Default.Options.UseForeColor = true;
            this.acEmployees.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("acEmployees.ImageOptions.SvgImage")));
            this.acEmployees.Name = "acEmployees";
            this.acEmployees.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acEmployees.Text = "Employees";
            // 
            // acCustomers
            // 
            this.acCustomers.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("acCustomers.ImageOptions.SvgImage")));
            this.acCustomers.Name = "acCustomers";
            this.acCustomers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acCustomers.Text = "Customers";
            // 
            // acVendors
            // 
            this.acVendors.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("acVendors.ImageOptions.SvgImage")));
            this.acVendors.Name = "acVendors";
            this.acVendors.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acVendors.Text = "Vendors";
            // 
            // aceProducts
            // 
            this.aceProducts.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acVideoPlayers,
            this.acMonitors,
            this.acProjectors,
            this.acTelevisions});
            this.aceProducts.Expanded = true;
            this.aceProducts.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("aceProducts.ImageOptions.SvgImage")));
            this.aceProducts.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.aceProducts.Name = "aceProducts";
            this.aceProducts.Text = "ADMIN";
            // 
            // acVideoPlayers
            // 
            this.acVideoPlayers.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("acVideoPlayers.ImageOptions.SvgImage")));
            this.acVideoPlayers.Name = "acVideoPlayers";
            this.acVideoPlayers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acVideoPlayers.Text = "Video Players";
            // 
            // acMonitors
            // 
            this.acMonitors.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("acMonitors.ImageOptions.SvgImage")));
            this.acMonitors.Name = "acMonitors";
            this.acMonitors.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acMonitors.Text = "Monitors";
            // 
            // acProjectors
            // 
            this.acProjectors.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("acProjectors.ImageOptions.SvgImage")));
            this.acProjectors.Name = "acProjectors";
            this.acProjectors.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acProjectors.Text = "Projectors";
            // 
            // acTelevisions
            // 
            this.acTelevisions.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("acTelevisions.ImageOptions.SvgImage")));
            this.acTelevisions.Name = "acTelevisions";
            this.acTelevisions.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acTelevisions.Text = "Televisions";
            // 
            // accordionControlElement13
            // 
            this.accordionControlElement13.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acVideoPlayers2,
            this.acMonitors2,
            this.acProjectors2,
            this.acTelevisions2});
            this.accordionControlElement13.Expanded = true;
            this.accordionControlElement13.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement13.ImageOptions.SvgImage")));
            this.accordionControlElement13.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.accordionControlElement13.Name = "accordionControlElement13";
            this.accordionControlElement13.Text = "CATEGORIES";
            // 
            // acVideoPlayers2
            // 
            this.acVideoPlayers2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("acVideoPlayers2.ImageOptions.SvgImage")));
            this.acVideoPlayers2.Name = "acVideoPlayers2";
            this.acVideoPlayers2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acVideoPlayers2.Text = "Video Players";
            // 
            // acMonitors2
            // 
            this.acMonitors2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("acMonitors2.ImageOptions.SvgImage")));
            this.acMonitors2.Name = "acMonitors2";
            this.acMonitors2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acMonitors2.Text = "Monitors";
            // 
            // acProjectors2
            // 
            this.acProjectors2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("acProjectors2.ImageOptions.SvgImage")));
            this.acProjectors2.Name = "acProjectors2";
            this.acProjectors2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acProjectors2.Text = "Projectors";
            // 
            // acTelevisions2
            // 
            this.acTelevisions2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("acTelevisions2.ImageOptions.SvgImage")));
            this.acTelevisions2.Name = "acTelevisions2";
            this.acTelevisions2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acTelevisions2.Text = "Televisions";
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.ImageSize = new System.Drawing.Size(20, 20);
            this.svgImageCollection1.Add("Category", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Category"))));
            this.svgImageCollection1.Add("Phone", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Phone"))));
            this.svgImageCollection1.Add("User", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.User"))));
            this.svgImageCollection1.Add("Collapse", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Collapse"))));
            this.svgImageCollection1.Add("Expand", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Expand"))));
            this.svgImageCollection1.Add("Search", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Search"))));
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.accordionControlTemplateCodeViewer1);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel2.Location = new System.Drawing.Point(482, 0);
            this.sidePanel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(332, 559);
            this.sidePanel2.TabIndex = 2;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // accordionControlTemplateCodeViewer1
            // 
            this.accordionControlTemplateCodeViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControlTemplateCodeViewer1.Location = new System.Drawing.Point(1, 0);
            this.accordionControlTemplateCodeViewer1.Name = "accordionControlTemplateCodeViewer1";
            this.accordionControlTemplateCodeViewer1.Size = new System.Drawing.Size(331, 559);
            this.accordionControlTemplateCodeViewer1.TabIndex = 0;
            // 
            // HamburgerMenuModule
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.accordionControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "HamburgerMenuModule";
            this.Size = new System.Drawing.Size(814, 559);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.sidePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XtraBars.Navigation.AccordionControl accordionControl1;
        private XtraBars.Navigation.AccordionControlElement aceUsers;
        private SidePanel sidePanel2;
        private AccordionControlTemplateCodeViewer accordionControlTemplateCodeViewer1;
        private XtraBars.Navigation.AccordionControlElement acEmployees;
        private XtraBars.Navigation.AccordionControlElement acCustomers;
        private XtraBars.Navigation.AccordionControlElement acVendors;
        private XtraBars.Navigation.AccordionControlElement aceProducts;
        private XtraBars.Navigation.AccordionControlElement acVideoPlayers;
        private XtraBars.Navigation.AccordionControlElement acMonitors;
        private XtraBars.Navigation.AccordionControlElement acProjectors;
        private XtraBars.Navigation.AccordionControlElement acTelevisions;
        private XtraBars.Navigation.AccordionControlElement accordionControlElement13;
        private Utils.SvgImageCollection svgImageCollection1;
        private XtraBars.Navigation.AccordionControlElement acVideoPlayers2;
        private XtraBars.Navigation.AccordionControlElement acMonitors2;
        private XtraBars.Navigation.AccordionControlElement acProjectors2;
        private XtraBars.Navigation.AccordionControlElement acTelevisions2;
    }
}
