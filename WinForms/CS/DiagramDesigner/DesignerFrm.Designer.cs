using DevExpress.DXperience.Demos;

namespace DevExpress.XtraDiagram.Demos {
    partial class DesignerFrm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonMainForm));
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.rpgAppearance = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pmAppearance = new DevExpress.XtraBars.PopupMenu(this.components);
            this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.bbiRoundedMode = new DevExpress.XtraBars.BarCheckItem();
            ((System.ComponentModel.ISupportInitialize)(this.pmAppearance)).BeginInit();
            this.SuspendLayout();
            //
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // skinPaletteRibbonGalleryBarItem1
            // 
            this.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
            //
            // bbiRoundedMode
            //
            resources.ApplyResources(this.bbiRoundedMode, "bbiRoundedMode");
            this.bbiRoundedMode.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiRoundedMode.ImageOptions.SvgImage")));
            this.bbiRoundedMode.Name = "bbiRoundedMode";
            this.bbiRoundedMode.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRoundedModeCheckedChanged);
            this.bbiRoundedMode.Visibility = DevExpress.Utils.WindowsVersionProvider.IsWindows11 ? XtraBars.BarItemVisibility.Always : XtraBars.BarItemVisibility.Never;

            this.Ribbon.Items.AddRange(new XtraBars.BarItem[] {
                this.skinDropDownButtonItem1,
                this.skinPaletteRibbonGalleryBarItem1,
                this.bbiRoundedMode
            });
            // 
            // rpgAppearance
            // 
            resources.ApplyResources(this.rpgAppearance, "rpgAppearance");
            this.rpgAppearance.ItemLinks.Add(this.skinDropDownButtonItem1);
            this.rpgAppearance.ItemLinks.Add(this.skinPaletteRibbonGalleryBarItem1);
            this.rpgAppearance.ItemLinks.Add(this.bbiRoundedMode);
            this.rpgAppearance.Name = "rpgAppearance";
            this.rpgAppearance.CaptionButtonClick += new DevExpress.XtraBars.Ribbon.RibbonPageGroupEventHandler(this.RpgAppearance_CaptionButtonClick);
            // 
            // pmAppearance
            // 
            this.pmAppearance.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.SmallImagesText;
            this.pmAppearance.Name = "pmAppearance";
            this.pmAppearance.Ribbon = this.Ribbon;
            this.pmAppearance.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
            // 
            // 
            // DesignerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 833);
            this.Name = "DesignerFrm";
            ((System.ComponentModel.ISupportInitialize)(this.pmAppearance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private XtraBars.Ribbon.RibbonPageGroup rpgAppearance;
        private XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
        private XtraBars.BarCheckItem bbiRoundedMode;
        private DevExpress.XtraBars.PopupMenu pmAppearance;
    }
}

