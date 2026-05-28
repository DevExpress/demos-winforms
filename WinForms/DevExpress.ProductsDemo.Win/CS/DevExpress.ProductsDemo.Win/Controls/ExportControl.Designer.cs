namespace DevExpress.ProductsDemo.Win.Controls {
    partial class ExportControl {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportControl));
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem4 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem5 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem6 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem7 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem8 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem9 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.exportGallery = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.backstageViewLabel1 = new DevExpress.ProductsDemo.Win.BackstageViewLabel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportGallery)).BeginInit();
            this.exportGallery.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.exportGallery);
            this.splitContainer1.Panel1.Controls.Add(this.backstageViewLabel1);
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelControl4);
            // 
            // exportGallery
            // 
            this.exportGallery.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.exportGallery.Controls.Add(this.galleryControlClient1);
            resources.ApplyResources(this.exportGallery, "exportGallery");
            // 
            // 
            // 
            this.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
            this.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
            this.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = true;
            this.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = true;
            this.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = true;
            this.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.exportGallery.Gallery.AutoFitColumns = false;
            this.exportGallery.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.None;
            this.exportGallery.Gallery.BackColor = System.Drawing.Color.Transparent;
            this.exportGallery.Gallery.CheckDrawMode = DevExpress.XtraBars.Ribbon.Gallery.CheckDrawMode.OnlyImage;
            this.exportGallery.Gallery.ColumnCount = 1;
            this.exportGallery.Gallery.FixedImageSize = false;
            resources.ApplyResources(galleryItemGroup1, "galleryItemGroup1");
            resources.ApplyResources(galleryItem1, "galleryItem1");
            galleryItem1.ImageOptions.SvgImage = global::DevExpress.ProductsDemo.Win.Properties.Resources.Action_Export_ToPDF;
            galleryItem1.Tag = "PDF";
            resources.ApplyResources(galleryItem2, "galleryItem2");
            galleryItem2.ImageOptions.SvgImage = global::DevExpress.ProductsDemo.Win.Properties.Resources.Action_Export_ToHTML;
            galleryItem2.Tag = "HTML";
            resources.ApplyResources(galleryItem3, "galleryItem3");
            galleryItem3.ImageOptions.SvgImage = global::DevExpress.ProductsDemo.Win.Properties.Resources.Action_Export_ToMHT;
            galleryItem3.Tag = "MHT";
            resources.ApplyResources(galleryItem4, "galleryItem4");
            galleryItem4.ImageOptions.SvgImage = global::DevExpress.ProductsDemo.Win.Properties.Resources.Action_Export_ToRTF;
            galleryItem4.Tag = "RTF";
            resources.ApplyResources(galleryItem5, "galleryItem5");
            galleryItem5.ImageOptions.SvgImage = global::DevExpress.ProductsDemo.Win.Properties.Resources.Action_Export_ToXls;
            galleryItem5.Tag = "XLS";
            resources.ApplyResources(galleryItem6, "galleryItem6");
            galleryItem6.ImageOptions.SvgImage = global::DevExpress.ProductsDemo.Win.Properties.Resources.Action_Export_ToXLSX;
            galleryItem6.Tag = "XLSX";
            resources.ApplyResources(galleryItem7, "galleryItem7");
            galleryItem7.ImageOptions.SvgImage = global::DevExpress.ProductsDemo.Win.Properties.Resources.Action_Export_ToCSV;
            galleryItem7.Tag = "CSV";
            resources.ApplyResources(galleryItem8, "galleryItem8");
            galleryItem8.ImageOptions.SvgImage = global::DevExpress.ProductsDemo.Win.Properties.Resources.Action_Export_ToText;
            galleryItem8.Tag = "Text";
            resources.ApplyResources(galleryItem9, "galleryItem9");
            galleryItem9.ImageOptions.SvgImage = global::DevExpress.ProductsDemo.Win.Properties.Resources.Action_Export_ToImage;
            galleryItem9.Tag = "Image";
            galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2,
            galleryItem3,
            galleryItem4,
            galleryItem5,
            galleryItem6,
            galleryItem7,
            galleryItem8,
            galleryItem9});
            this.exportGallery.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.exportGallery.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.exportGallery.Gallery.ShowGroupCaption = false;
            this.exportGallery.Gallery.ShowItemText = true;
            this.exportGallery.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.exportGallery.Gallery.StretchItems = true;
            this.exportGallery.Gallery.ItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.galleryControlGallery1_ItemClick);
            this.exportGallery.Name = "exportGallery";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.exportGallery;
            resources.ApplyResources(this.galleryControlClient1, "galleryControlClient1");
            // 
            // backstageViewLabel1
            // 
            this.backstageViewLabel1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("backstageViewLabel1.Appearance.Font")));
            this.backstageViewLabel1.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.backstageViewLabel1, "backstageViewLabel1");
            this.backstageViewLabel1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.backstageViewLabel1.LineVisible = true;
            this.backstageViewLabel1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.backstageViewLabel1.Name = "backstageViewLabel1";
            this.backstageViewLabel1.ShowLineShadow = false;
            // 
            // labelControl4
            // 
            resources.ApplyResources(this.labelControl4, "labelControl4");
            this.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl4.LineVisible = true;
            this.labelControl4.Name = "labelControl4";
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // ExportControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ExportControl";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exportGallery)).EndInit();
            this.exportGallery.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private BackstageViewLabel backstageViewLabel1;
        private DevExpress.XtraBars.Ribbon.GalleryControl exportGallery;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}
