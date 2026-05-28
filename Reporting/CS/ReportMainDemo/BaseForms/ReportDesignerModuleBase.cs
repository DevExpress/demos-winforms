using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using RibbonReportDesigner;

namespace XtraReportsDemos {
    public class ReportDesignerModuleBase : ReportModuleBase {
        #region inner classes
        class DemoRoundedPanel : RoundedSkinPanel {
            class DemoRoundedPanelViewInfo : RoundedSkinPanelViewInfo {
                Lazy<SkinElement> skinElement;
                public DemoRoundedPanelViewInfo(RoundedSkinPanel owner) : base(owner) {
                    ResetSkinElement();
                }
                protected override SkinElement GetSkinElement() => skinElement.Value;

                SkinElement GetPrintingSkinElement(Skin skin) {
                    return skin[PrintingSkins.SkinBackgroundPreview];
                }

                public void ResetSkinElement() {
                    skinElement = new Lazy<SkinElement>(CreateSkinElement);
                }

                SkinElement CreateSkinElement() {
                    var skin = SkinManager.Default.GetSkin(SkinProductId.Printing, Owner.LookAndFeel);
                    var printingSkinElement = GetPrintingSkinElement(skin);
                    var skinElement = base.GetSkinElement()?.Copy(skin, "DemoRoundedPanel");
                    if(skinElement != null) {
                        skinElement.Info.Color.BackColor = printingSkinElement.Info.Color.BackColor;
                        skinElement.Info.Image = printingSkinElement.Image;
                    }
                    return skinElement;
                }
            }

            new DemoRoundedPanelViewInfo ViewInfo => (DemoRoundedPanelViewInfo)base.ViewInfo;
            protected override void OnLookAndFeelStyleChangedCore(object sender) {
                ViewInfo.ResetSkinElement();
                base.OnLookAndFeelStyleChangedCore(sender);
            }

            protected override RoundedSkinPanelViewInfo CreateViewInfo() {
                return new DemoRoundedPanelViewInfo(this);
            }
        }
        #endregion

        #region fields

        private FeatureGalleryControl gallery;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.SimpleButton btnRunDesigner;
        private Panel galleryContainerPanel;
        private DemoRoundedPanel roundedPanel;
        protected DevExpress.XtraLayout.LayoutControl lcc;
        protected DevExpress.XtraLayout.LayoutControlGroup lcgRoot;
        private DevExpress.XtraLayout.LayoutControlItem lciContent;
        protected DevExpress.XtraLayout.LayoutControlItem lciHeader;
        private TableLayoutPanel tableLayoutPanel;

        #endregion

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.btnRunDesigner = new DevExpress.XtraEditors.SimpleButton();
            this.gallery = new FeatureGalleryControl();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.galleryContainerPanel = new System.Windows.Forms.Panel();
            this.roundedPanel = new XtraReportsDemos.ReportDesignerModuleBase.DemoRoundedPanel();
            this.lcc = new DevExpress.XtraLayout.LayoutControl();
            this.lcgRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciHeader = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciContent = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel.SuspendLayout();
            this.galleryContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPanel)).BeginInit();
            this.roundedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcc)).BeginInit();
            this.lcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciContent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Appearance.Options.UseTextOptions = true;
            this.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblTitle.Location = new System.Drawing.Point(600, 116);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 54, 0, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(127, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "lblTitle";
            // 
            // btnRunDesigner
            // 
            this.btnRunDesigner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRunDesigner.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnRunDesigner.Appearance.Options.UseBackColor = true;
            this.btnRunDesigner.AutoSize = true;
            this.btnRunDesigner.Location = new System.Drawing.Point(577, 221);
            this.btnRunDesigner.Margin = new System.Windows.Forms.Padding(0, 27, 0, 54);
            this.btnRunDesigner.Name = "btnRunDesigner";
            this.btnRunDesigner.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnRunDesigner.Size = new System.Drawing.Size(174, 56);
            this.btnRunDesigner.TabIndex = 2;
            this.btnRunDesigner.Text = "Run Designer";
            this.btnRunDesigner.Click += new System.EventHandler(this.runDesignerBtn_Click);
            // 
            // gallery
            // 
            this.gallery.AutoSize = true;
            this.gallery.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gallery.Dock = System.Windows.Forms.DockStyle.Top;
            this.gallery.Location = new System.Drawing.Point(0, 0);
            this.gallery.Margin = new System.Windows.Forms.Padding(0);
            this.gallery.Name = "gallery";
            this.gallery.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.gallery.Size = new System.Drawing.Size(1322, 0);
            this.gallery.TabIndex = 3;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.btnRunDesigner, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.lblTitle, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.galleryContainerPanel, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(34, 34);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.MinimumSize = new System.Drawing.Size(64, 64);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1328, 393);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // galleryContainerPanel
            // 
            this.galleryContainerPanel.AutoScroll = true;
            this.galleryContainerPanel.AutoSize = true;
            this.galleryContainerPanel.Controls.Add(this.gallery);
            this.galleryContainerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.galleryContainerPanel.Location = new System.Drawing.Point(3, 191);
            this.galleryContainerPanel.Name = "galleryContainerPanel";
            this.galleryContainerPanel.Size = new System.Drawing.Size(1322, 0);
            this.galleryContainerPanel.TabIndex = 4;
            // 
            // roundedPanel
            // 
            this.roundedPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel.Appearance.Options.UseBackColor = true;
            this.roundedPanel.Controls.Add(this.tableLayoutPanel);
            this.roundedPanel.Location = new System.Drawing.Point(0, 220);
            this.roundedPanel.Margin = new System.Windows.Forms.Padding(0);
            this.roundedPanel.Name = "roundedPanel";
            this.roundedPanel.Size = new System.Drawing.Size(1396, 461);
            this.roundedPanel.TabIndex = 3;
            this.roundedPanel.Text = "roundedSkinPanel1";
            // 
            // lcc
            // 
            this.lcc.AllowCustomization = false;
            this.lcc.Controls.Add(this.roundedPanel);
            this.lcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcc.Location = new System.Drawing.Point(0, 0);
            this.lcc.Margin = new System.Windows.Forms.Padding(0);
            this.lcc.Name = "lcc";
            this.lcc.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1698, 338, 1687, 1183);
            this.lcc.Root = this.lcgRoot;
            this.lcc.Size = new System.Drawing.Size(1396, 681);
            this.lcc.TabIndex = 8;
            this.lcc.Text = "layoutControl1";
            // 
            // lcgRoot
            // 
            this.lcgRoot.GroupBordersVisible = false;
            this.lcgRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciHeader,
            this.lciContent});
            this.lcgRoot.Name = "Root";
            this.lcgRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgRoot.Size = new System.Drawing.Size(1396, 681);
            this.lcgRoot.TextVisible = false;
            // 
            // lciHeader
            // 
            this.lciHeader.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lciHeader.AppearanceItemCaption.Options.UseBackColor = true;
            this.lciHeader.Location = new System.Drawing.Point(0, 0);
            this.lciHeader.Name = "lciUcDisclaimerPanel1";
            this.lciHeader.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciHeader.Size = new System.Drawing.Size(1396, 220);
            this.lciHeader.TextVisible = false;
            // 
            // lciContent
            // 
            this.lciContent.Control = this.roundedPanel;
            this.lciContent.Location = new System.Drawing.Point(0, 220);
            this.lciContent.Name = "lciContent";
            this.lciContent.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciContent.Size = new System.Drawing.Size(1396, 461);
            this.lciContent.TextVisible = false;
            // 
            // ReportDesignerModuleBase
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.lcc);
            this.Name = "ReportDesignerModuleBase";
            this.Size = new System.Drawing.Size(1396, 681);
            this.Resize += new System.EventHandler(this.OnResize);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.galleryContainerPanel.ResumeLayout(false);
            this.galleryContainerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPanel)).EndInit();
            this.roundedPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcc)).EndInit();
            this.lcc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciContent)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        public ReportDesignerModuleBase() {
            InitializeComponent();
            lblTitle.Text = Title;
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(!DesignMode) {
                this.SuspendLayout();
                lciHeader.Visibility = lciHeader.Control == null
                    ? DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    : DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                this.ResumeLayout();
            }
        }

        protected override void OnFirstLoad() {
            base.OnFirstLoad();
            gallery.InitializeGallery(GetFeatureInfos());
        }
        protected virtual string Title { get; } = "";
        protected virtual IEnumerable<FeatureTileInfo> GetFeatureInfos() => Enumerable.Empty<FeatureTileInfo>();

        void runDesignerBtn_Click(object sender, EventArgs e) {
            var size = new Size();
            using(var form = new DemoWaitForm()) {
                size = form.Size;
            }
            Point waitFormLocation = tableLayoutPanel.PointToScreen(new Point((this.Width - size.Width) / 2, (this.Height - size.Height) / 2));
            SplashScreenManager.ShowForm(this, typeof(DemoWaitForm), true, false, SplashFormStartPosition.Manual, waitFormLocation);
            using(XtraReport report = CreateReport())
            using(MainFormBase form = CreateDesignerForm()) {
                form.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                form.OpenReport(report);
                form.Load += (s, args) => SplashScreenManager.CloseForm(false);
                form.ShowDialog();
            }
        }

        protected virtual MainFormBase CreateDesignerForm() {
            return new OfficeInspiredMainForm();
        }

        protected virtual XtraReport CreateReport() {
            return new XtraReportsDemos.NorthwindTraders.InvoiceReport();
        }

        protected override bool IsActive => true;

        public override Task Deactivate() {
            SplashScreenManager.CloseForm(false);
            return base.Deactivate();
        }

        public override bool IsExternalPreviewApplicable() => false;

        void OnResize(object sender, EventArgs e) {
            int availableHeight = tableLayoutPanel.ClientSize.Height;
            int reservedHeight = lblTitle.Height + btnRunDesigner.Height + lblTitle.Margin.Vertical + btnRunDesigner.Margin.Vertical;
            int maxGalleryHeight = availableHeight - reservedHeight;
            galleryContainerPanel.MaximumSize = new Size(tableLayoutPanel.ClientSize.Width, maxGalleryHeight);
            galleryContainerPanel.MinimumSize = new Size(0, 0);
        }
    }
}
