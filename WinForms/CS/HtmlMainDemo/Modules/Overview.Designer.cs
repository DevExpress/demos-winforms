
namespace DevExpress.HTML.Demos {
    partial class Overview {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            this.htmlContentControl = new DevExpress.XtraEditors.HtmlContentControl();
            this.textEditPhone = new DevExpress.XtraEditors.TextEdit();
            this.textEditEmail = new DevExpress.XtraEditors.TextEdit();
            this.textEditFullName = new DevExpress.XtraEditors.TextEdit();
            this.textEditDisplayName = new DevExpress.XtraEditors.TextEdit();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.htmlOverviewDescription = new DevExpress.XtraEditors.HtmlContentControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl)).BeginInit();
            this.htmlContentControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDisplayName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlOverviewDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // htmlContentControl
            // 
            this.htmlContentControl.Controls.Add(this.textEditPhone);
            this.htmlContentControl.Controls.Add(this.textEditEmail);
            this.htmlContentControl.Controls.Add(this.textEditFullName);
            this.htmlContentControl.Controls.Add(this.textEditDisplayName);
            this.htmlContentControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlContentControl.HtmlImages = this.svgImageCollection1;
            this.htmlContentControl.HtmlTemplate.Styles = resources.GetString("htmlContentControl.HtmlTemplate.Styles");
            this.htmlContentControl.HtmlTemplate.Template = resources.GetString("htmlContentControl.HtmlTemplate.Template");
            this.htmlContentControl.Location = new System.Drawing.Point(17, 11);
            this.htmlContentControl.Margin = new System.Windows.Forms.Padding(0);
            this.htmlContentControl.MinimumSize = new System.Drawing.Size(0, 630);
            this.htmlContentControl.Name = "htmlContentControl";
            this.htmlContentControl.Size = new System.Drawing.Size(620, 630);
            this.htmlContentControl.TabIndex = 0;
            this.htmlContentControl.ElementMouseClick += new DevExpress.Utils.Html.DxHtmlElementMouseEventHandler(this.htmlContentControl_ElementMouseClick);
            // 
            // textEditPhone
            // 
            this.textEditPhone.EditValue = "(562) 559-5830";
            this.textEditPhone.Location = new System.Drawing.Point(331, 277);
            this.textEditPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEditPhone.Name = "textEditPhone";
            this.textEditPhone.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditPhone.Properties.Appearance.Options.UseFont = true;
            this.textEditPhone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEditPhone.Size = new System.Drawing.Size(242, 18);
            this.textEditPhone.TabIndex = 3;
            // 
            // textEditEmail
            // 
            this.textEditEmail.EditValue = "leahs@dx-email.com";
            this.textEditEmail.Location = new System.Drawing.Point(47, 277);
            this.textEditEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEditEmail.Name = "textEditEmail";
            this.textEditEmail.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditEmail.Properties.Appearance.Options.UseFont = true;
            this.textEditEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEditEmail.Size = new System.Drawing.Size(242, 18);
            this.textEditEmail.TabIndex = 2;
            // 
            // textEditFullName
            // 
            this.textEditFullName.EditValue = "Leah Simpson";
            this.textEditFullName.Location = new System.Drawing.Point(331, 181);
            this.textEditFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEditFullName.Name = "textEditFullName";
            this.textEditFullName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditFullName.Properties.Appearance.Options.UseFont = true;
            this.textEditFullName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEditFullName.Size = new System.Drawing.Size(242, 18);
            this.textEditFullName.TabIndex = 1;
            // 
            // textEditDisplayName
            // 
            this.textEditDisplayName.EditValue = "Leah Test Coordinator";
            this.textEditDisplayName.Location = new System.Drawing.Point(47, 181);
            this.textEditDisplayName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEditDisplayName.Name = "textEditDisplayName";
            this.textEditDisplayName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditDisplayName.Properties.Appearance.Options.UseFont = true;
            this.textEditDisplayName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEditDisplayName.Size = new System.Drawing.Size(242, 18);
            this.textEditDisplayName.TabIndex = 0;
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("employee", "image://svgimages/business objects/bo_lead.svg");
            this.svgImageCollection1.Add("phone", "image://svgimages/outlook inspired/glyph_phone.svg");
            this.svgImageCollection1.Add("contact", "image://svgimages/business objects/bo_contact.svg");
            this.svgImageCollection1.Add("message", "image://svgimages/outlook inspired/glyph_message.svg");
            this.svgImageCollection1.Add("signin", "image://svgimages/scheduling/timezones.svg");
            // 
            // htmlOverviewDescription
            // 
            this.htmlOverviewDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlOverviewDescription.HtmlImages = this.svgImageCollection1;
            this.htmlOverviewDescription.HtmlTemplate.Styles = ".container{\r\ndisplay:flex;\r\nflex-direction: column;\r\njustify-content: space-betwe" +
    "en;\r\npadding:20px;\r\ncolor:@ControlText;\r\n}\r\n.text{\r\n\tword-wrap: normal;\r\n\tfont-s" +
    "ize:10pt;\r\n}";
            this.htmlOverviewDescription.HtmlTemplate.Template = resources.GetString("htmlOverviewDescription.HtmlTemplate.Template");
            this.htmlOverviewDescription.Location = new System.Drawing.Point(652, 11);
            this.htmlOverviewDescription.Margin = new System.Windows.Forms.Padding(0);
            this.htmlOverviewDescription.Name = "htmlOverviewDescription";
            this.htmlOverviewDescription.Size = new System.Drawing.Size(382, 630);
            this.htmlOverviewDescription.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.AutoScroll = false;
            this.layoutControl1.Controls.Add(this.htmlOverviewDescription);
            this.layoutControl1.Controls.Add(this.htmlContentControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(5, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1822, 1242, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1051, 651);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 100D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 620D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 397D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition4.Width = 100D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4});
            rowDefinition1.Height = 100D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition2.Height = 630D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 100D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3});
            this.Root.Size = new System.Drawing.Size(1051, 652);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.htmlOverviewDescription;
            this.layoutControlItem2.Location = new System.Drawing.Point(627, 1);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0);
            this.layoutControlItem2.Size = new System.Drawing.Size(397, 630);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.htmlContentControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(7, 1);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 670);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(24, 670);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(620, 630);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextVisible = false;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Overview";
            this.Size = new System.Drawing.Size(1056, 656);
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl)).EndInit();
            this.htmlContentControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDisplayName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlOverviewDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.HtmlContentControl htmlContentControl;
        private Utils.SvgImageCollection svgImageCollection1;
        private XtraEditors.TextEdit textEditPhone;
        private XtraEditors.TextEdit textEditEmail;
        private XtraEditors.TextEdit textEditFullName;
        private XtraEditors.TextEdit textEditDisplayName;
        private XtraEditors.HtmlContentControl htmlOverviewDescription;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
