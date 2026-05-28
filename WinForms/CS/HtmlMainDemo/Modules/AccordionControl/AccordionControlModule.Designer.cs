
using DevExpress.XtraEditors;

namespace DevExpress.HTML.Demos {
    partial class AccordionControlModule {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccordionControlModule));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionContentContainer2 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.shippingControl1 = new DevExpress.HTML.Demos.Modules.AccordionControl.Controls.ShippingControl();
            this.accordionContentContainer3 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.paymentControl1 = new DevExpress.HTML.Demos.Modules.AccordionControl.Controls.PaymentControl();
            this.accordionContentContainer4 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.billingControl1 = new DevExpress.HTML.Demos.Modules.AccordionControl.Controls.ShippingControl();
            this.accordionContentContainer5 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.deliveryControl2 = new DevExpress.HTML.Demos.Modules.AccordionControl.Controls.DeliveryControl();
            this.accordionContentContainer6 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.orderSummaryControl1 = new DevExpress.HTML.Demos.Modules.AccordionControl.Controls.OrderSummaryControl();
            this.comboBoxEdit1 = new DevExpress.HTML.Demos.Modules.AccordionControl.HtmlComboBoxEdit();
            this.htmlButtonPanel1 = new DevExpress.HTML.Demos.Modules.AccordionControl.Controls.HtmlButtonPanel();
            this.htmlCheckBox = new DevExpress.HTML.Demos.Modules.AccordionControl.Controls.HtmlCheckBoxControl();
            this.htmlButton1 = new DevExpress.HTML.Demos.Modules.AccordionControl.Controls.HtmlButton();
            this.accordionContentContainer1 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.informationControl1 = new DevExpress.HTML.Demos.Modules.AccordionControl.Controls.InformationControl();
            this.informationElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.shippingElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.paymentElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.billingElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.deliveryElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.summaryElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlHolder = new DevExpress.XtraEditors.XtraUserControl();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.accordionControlTemplateCodeViewer1 = new DevExpress.HTML.Demos.AccordionControlTemplateCodeViewer();
            this.htmlTemplateCollection1 = new DevExpress.Utils.Html.HtmlTemplateCollection();
            this.htmlTemplate1 = new DevExpress.Utils.Html.HtmlTemplate();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.accordionControl1.SuspendLayout();
            this.accordionContentContainer2.SuspendLayout();
            this.accordionContentContainer3.SuspendLayout();
            this.accordionContentContainer4.SuspendLayout();
            this.accordionContentContainer5.SuspendLayout();
            this.accordionContentContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.accordionContentContainer1.SuspendLayout();
            this.accordionControlHolder.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Controls.Add(this.accordionContentContainer2);
            this.accordionControl1.Controls.Add(this.accordionContentContainer3);
            this.accordionControl1.Controls.Add(this.accordionContentContainer4);
            this.accordionControl1.Controls.Add(this.accordionContentContainer5);
            this.accordionControl1.Controls.Add(this.accordionContentContainer6);
            this.accordionControl1.Controls.Add(this.comboBoxEdit1);
            this.accordionControl1.Controls.Add(this.htmlButtonPanel1);
            this.accordionControl1.Controls.Add(this.htmlCheckBox);
            this.accordionControl1.Controls.Add(this.htmlButton1);
            this.accordionControl1.Controls.Add(this.accordionContentContainer1);
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.informationElement,
            this.shippingElement,
            this.paymentElement,
            this.billingElement,
            this.deliveryElement,
            this.summaryElement});
            this.accordionControl1.HtmlTemplates.Item.Styles = resources.GetString("accordionControl1.HtmlTemplates.Item.Styles");
            this.accordionControl1.HtmlTemplates.Item.Template = resources.GetString("accordionControl1.HtmlTemplates.Item.Template");
            this.accordionControl1.HtmlTemplates.ItemContent.Styles = resources.GetString("accordionControl1.HtmlTemplates.ItemContent.Styles");
            this.accordionControl1.HtmlTemplates.ItemContent.Template = "<div class=\"item\">\r\n\t<div class=\"item_layout\"></div>\r\n</div>";
            this.accordionControl1.Location = new System.Drawing.Point(32, 32);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(2);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.Size = new System.Drawing.Size(501, 580);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.QueryHtmlElementData += new DevExpress.XtraBars.Navigation.QueryAccordionHtmlElementDataEventHandler(this.accordionControl1_QueryHtmlElementData);
            this.accordionControl1.ExpandStateChanging += new DevExpress.XtraBars.Navigation.ExpandStateChangingEventHandler(this.accordionControl1_ExpandStateChanging);
            // 
            // accordionContentContainer2
            // 
            this.accordionContentContainer2.Controls.Add(this.shippingControl1);
            this.accordionContentContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.accordionContentContainer2.Name = "accordionContentContainer2";
            this.accordionContentContainer2.Padding = new System.Windows.Forms.Padding(72, 30, 80, 18);
            this.accordionContentContainer2.Size = new System.Drawing.Size(482, 355);
            this.accordionContentContainer2.TabIndex = 3;
            // 
            // shippingControl1
            // 
            this.shippingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shippingControl1.Location = new System.Drawing.Point(72, 30);
            this.shippingControl1.Name = "shippingControl1";
            this.shippingControl1.Size = new System.Drawing.Size(330, 307);
            this.shippingControl1.TabIndex = 0;
            // 
            // accordionContentContainer3
            // 
            this.accordionContentContainer3.Controls.Add(this.paymentControl1);
            this.accordionContentContainer3.Margin = new System.Windows.Forms.Padding(2);
            this.accordionContentContainer3.Name = "accordionContentContainer3";
            this.accordionContentContainer3.Padding = new System.Windows.Forms.Padding(72, 30, 80, 18);
            this.accordionContentContainer3.Size = new System.Drawing.Size(482, 245);
            this.accordionContentContainer3.TabIndex = 4;
            // 
            // paymentControl1
            // 
            this.paymentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentControl1.Location = new System.Drawing.Point(72, 30);
            this.paymentControl1.Name = "paymentControl1";
            this.paymentControl1.Size = new System.Drawing.Size(330, 197);
            this.paymentControl1.TabIndex = 0;
            // 
            // accordionContentContainer4
            // 
            this.accordionContentContainer4.Controls.Add(this.billingControl1);
            this.accordionContentContainer4.Margin = new System.Windows.Forms.Padding(2);
            this.accordionContentContainer4.Name = "accordionContentContainer4";
            this.accordionContentContainer4.Padding = new System.Windows.Forms.Padding(72, 30, 80, 18);
            this.accordionContentContainer4.Size = new System.Drawing.Size(482, 349);
            this.accordionContentContainer4.TabIndex = 5;
            // 
            // billingControl1
            // 
            this.billingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billingControl1.Location = new System.Drawing.Point(72, 30);
            this.billingControl1.Name = "billingControl1";
            this.billingControl1.Size = new System.Drawing.Size(330, 301);
            this.billingControl1.TabIndex = 0;
            // 
            // accordionContentContainer5
            // 
            this.accordionContentContainer5.Controls.Add(this.deliveryControl2);
            this.accordionContentContainer5.Margin = new System.Windows.Forms.Padding(2);
            this.accordionContentContainer5.Name = "accordionContentContainer5";
            this.accordionContentContainer5.Padding = new System.Windows.Forms.Padding(72, 30, 80, 18);
            this.accordionContentContainer5.Size = new System.Drawing.Size(482, 252);
            this.accordionContentContainer5.TabIndex = 6;
            // 
            // deliveryControl2
            // 
            this.deliveryControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deliveryControl2.Location = new System.Drawing.Point(72, 30);
            this.deliveryControl2.Name = "deliveryControl2";
            this.deliveryControl2.Size = new System.Drawing.Size(330, 204);
            this.deliveryControl2.TabIndex = 0;
            // 
            // accordionContentContainer6
            // 
            this.accordionContentContainer6.Controls.Add(this.orderSummaryControl1);
            this.accordionContentContainer6.Margin = new System.Windows.Forms.Padding(2);
            this.accordionContentContainer6.Name = "accordionContentContainer6";
            this.accordionContentContainer6.Padding = new System.Windows.Forms.Padding(72, 30, 80, 18);
            this.accordionContentContainer6.Size = new System.Drawing.Size(482, 233);
            this.accordionContentContainer6.TabIndex = 7;
            // 
            // orderSummaryControl1
            // 
            this.orderSummaryControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderSummaryControl1.Location = new System.Drawing.Point(72, 30);
            this.orderSummaryControl1.Name = "orderSummaryControl1";
            this.orderSummaryControl1.Size = new System.Drawing.Size(330, 185);
            this.orderSummaryControl1.TabIndex = 0;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "";
            this.comboBoxEdit1.Location = new System.Drawing.Point(286, 332);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.comboBoxEdit1.Properties.AutoHeight = false;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.NullValuePrompt = "Select Address...";
            this.comboBoxEdit1.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)((DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.comboBoxEdit1.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.comboBoxEdit1.Size = new System.Drawing.Size(191, 42);
            this.comboBoxEdit1.TabIndex = 3;
            // 
            // htmlButtonPanel1
            // 
            this.htmlButtonPanel1.Location = new System.Drawing.Point(318, 752);
            this.htmlButtonPanel1.Name = "htmlButtonPanel1";
            this.htmlButtonPanel1.Size = new System.Drawing.Size(176, 47);
            this.htmlButtonPanel1.TabIndex = 1;
            // 
            // htmlCheckBox
            // 
            this.htmlCheckBox.Location = new System.Drawing.Point(278, 1055);
            this.htmlCheckBox.Name = "htmlCheckBox";
            this.htmlCheckBox.Size = new System.Drawing.Size(215, 42);
            this.htmlCheckBox.TabIndex = 3;
            // 
            // htmlButton1
            // 
            this.htmlButton1.Location = new System.Drawing.Point(325, 596);
            this.htmlButton1.Name = "htmlButton1";
            this.htmlButton1.Size = new System.Drawing.Size(129, 56);
            this.htmlButton1.TabIndex = 1;
            this.htmlButton1.Text = "Place Order";
            // 
            // accordionContentContainer1
            // 
            this.accordionContentContainer1.Controls.Add(this.informationControl1);
            this.accordionContentContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.accordionContentContainer1.Name = "accordionContentContainer1";
            this.accordionContentContainer1.Padding = new System.Windows.Forms.Padding(72, 30, 80, 18);
            this.accordionContentContainer1.Size = new System.Drawing.Size(482, 240);
            this.accordionContentContainer1.TabIndex = 1;
            // 
            // informationControl1
            // 
            this.informationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informationControl1.Location = new System.Drawing.Point(72, 30);
            this.informationControl1.Name = "informationControl1";
            this.informationControl1.Size = new System.Drawing.Size(330, 192);
            this.informationControl1.TabIndex = 0;
            // 
            // informationElement
            // 
            this.informationElement.ContentContainer = this.accordionContentContainer1;
            this.informationElement.Expanded = true;
            this.informationElement.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("informationElement.ImageOptions.SvgImage")));
            this.informationElement.Name = "informationElement";
            this.informationElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.informationElement.Text = "Personal Information";
            // 
            // shippingElement
            // 
            this.shippingElement.ContentContainer = this.accordionContentContainer2;
            this.shippingElement.Expanded = true;
            this.shippingElement.HeaderControl = this.comboBoxEdit1;
            this.shippingElement.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("shippingElement.ImageOptions.SvgImage")));
            this.shippingElement.Name = "shippingElement";
            this.shippingElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.shippingElement.Text = "Shipping Address";
            // 
            // paymentElement
            // 
            this.paymentElement.ContentContainer = this.accordionContentContainer3;
            this.paymentElement.Expanded = true;
            this.paymentElement.HeaderControl = this.htmlButtonPanel1;
            this.paymentElement.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("paymentElement.ImageOptions.SvgImage")));
            this.paymentElement.Name = "paymentElement";
            this.paymentElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.paymentElement.Text = "Payment Method";
            // 
            // billingElement
            // 
            this.billingElement.ContentContainer = this.accordionContentContainer4;
            this.billingElement.Expanded = true;
            this.billingElement.HeaderControl = this.htmlCheckBox;
            this.billingElement.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("billingElement.ImageOptions.SvgImage")));
            this.billingElement.Name = "billingElement";
            this.billingElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.billingElement.Text = "Billing Address";
            // 
            // deliveryElement
            // 
            this.deliveryElement.ContentContainer = this.accordionContentContainer5;
            this.deliveryElement.Expanded = true;
            this.deliveryElement.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("deliveryElement.ImageOptions.SvgImage")));
            this.deliveryElement.Name = "deliveryElement";
            this.deliveryElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.deliveryElement.Text = "Delivery";
            // 
            // summaryElement
            // 
            this.summaryElement.ContentContainer = this.accordionContentContainer6;
            this.summaryElement.Expanded = true;
            this.summaryElement.HeaderControl = this.htmlButton1;
            this.summaryElement.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("summaryElement.ImageOptions.SvgImage")));
            this.summaryElement.Name = "summaryElement";
            this.summaryElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.summaryElement.Text = "Checkout";
            // 
            // accordionControlHolder
            // 
            this.accordionControlHolder.Controls.Add(this.accordionControl1);
            this.accordionControlHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControlHolder.Location = new System.Drawing.Point(0, 0);
            this.accordionControlHolder.Margin = new System.Windows.Forms.Padding(2);
            this.accordionControlHolder.MinimumSize = new System.Drawing.Size(75, 0);
            this.accordionControlHolder.Name = "accordionControlHolder";
            this.accordionControlHolder.Padding = new System.Windows.Forms.Padding(32);
            this.accordionControlHolder.Size = new System.Drawing.Size(565, 644);
            this.accordionControlHolder.TabIndex = 1;
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.accordionControlTemplateCodeViewer1);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel2.Location = new System.Drawing.Point(565, 0);
            this.sidePanel2.Margin = new System.Windows.Forms.Padding(2);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(250, 644);
            this.sidePanel2.TabIndex = 2;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // accordionControlTemplateCodeViewer1
            // 
            this.accordionControlTemplateCodeViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControlTemplateCodeViewer1.Location = new System.Drawing.Point(1, 0);
            this.accordionControlTemplateCodeViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.accordionControlTemplateCodeViewer1.Name = "accordionControlTemplateCodeViewer1";
            this.accordionControlTemplateCodeViewer1.Size = new System.Drawing.Size(249, 644);
            this.accordionControlTemplateCodeViewer1.TabIndex = 0;
            // 
            // htmlTemplateCollection1
            // 
            this.htmlTemplateCollection1.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            this.htmlTemplate1});
            // 
            // htmlTemplate1
            // 
            this.htmlTemplate1.Name = "htmlTemplate1";
            this.htmlTemplate1.Styles = resources.GetString("htmlTemplate1.Styles");
            this.htmlTemplate1.Template = resources.GetString("htmlTemplate1.Template");
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("dropdown", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.dropdown"))));
            this.svgImageCollection1.Add("checkmark", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.checkmark"))));
            this.svgImageCollection1.Add("paypal", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.paypal"))));
            this.svgImageCollection1.Add("cash", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.cash"))));
            this.svgImageCollection1.Add("card", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.card"))));
            // 
            // AccordionControlModule
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.accordionControlHolder);
            this.Controls.Add(this.sidePanel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AccordionControlModule";
            this.Size = new System.Drawing.Size(815, 644);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.accordionControl1.ResumeLayout(false);
            this.accordionContentContainer2.ResumeLayout(false);
            this.accordionContentContainer3.ResumeLayout(false);
            this.accordionContentContainer4.ResumeLayout(false);
            this.accordionContentContainer5.ResumeLayout(false);
            this.accordionContentContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.accordionContentContainer1.ResumeLayout(false);
            this.accordionControlHolder.ResumeLayout(false);
            this.sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraBars.Navigation.AccordionControl accordionControl1;
        private XtraBars.Navigation.AccordionControlElement informationElement;
        private XtraUserControl accordionControlHolder;
        private SidePanel sidePanel2;
        private AccordionControlTemplateCodeViewer accordionControlTemplateCodeViewer1;
        private XtraBars.Navigation.AccordionControlElement shippingElement;
        private XtraBars.Navigation.AccordionControlElement paymentElement;
        private XtraBars.Navigation.AccordionContentContainer accordionContentContainer1;
        private XtraBars.Navigation.AccordionControlElement billingElement;
        private XtraBars.Navigation.AccordionControlElement deliveryElement;
        private XtraBars.Navigation.AccordionControlElement summaryElement;
        private XtraBars.Navigation.AccordionContentContainer accordionContentContainer2;
        private XtraBars.Navigation.AccordionContentContainer accordionContentContainer3;
        private XtraBars.Navigation.AccordionContentContainer accordionContentContainer4;
        private XtraBars.Navigation.AccordionContentContainer accordionContentContainer5;
        private XtraBars.Navigation.AccordionContentContainer accordionContentContainer6;
        private Modules.AccordionControl.HtmlComboBoxEdit comboBoxEdit1;
        private Utils.Html.HtmlTemplateCollection htmlTemplateCollection1;
        private Utils.Html.HtmlTemplate htmlTemplate1;
        private Modules.AccordionControl.Controls.InformationControl informationControl1;
        private Modules.AccordionControl.Controls.ShippingControl shippingControl1;
        private Utils.SvgImageCollection svgImageCollection1;
        private Modules.AccordionControl.Controls.PaymentControl paymentControl1;
        private Modules.AccordionControl.Controls.ShippingControl billingControl1;
        private Modules.AccordionControl.Controls.HtmlButtonPanel htmlButtonPanel1;
        private Modules.AccordionControl.Controls.HtmlCheckBoxControl htmlCheckBox;
        private Modules.AccordionControl.Controls.DeliveryControl deliveryControl2;
        private Modules.AccordionControl.Controls.OrderSummaryControl orderSummaryControl1;
        private Modules.AccordionControl.Controls.HtmlButton htmlButton1;
    }
}
