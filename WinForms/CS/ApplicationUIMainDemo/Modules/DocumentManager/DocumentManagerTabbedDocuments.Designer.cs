namespace DevExpress.ApplicationUI.Demos {
    partial class DocumentManagerTabbedDocuments {
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

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentManagerTabbedDocuments));
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bciColoredTabs = new DevExpress.XtraBars.BarCheckItem();
            this.biAddDocument = new DevExpress.XtraBars.BarButtonItem();
            this.beiHeadeLocation = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.beiHeaderOrientation = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.beiOrientation = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.beiClosePageButton = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemImageComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.beiShowPinTab = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemImageComboBox5 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.barDockingMenuItem1 = new DevExpress.XtraBars.BarDockingMenuItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bciDockGuides = new DevExpress.XtraBars.BarCheckItem();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager
            // 
            this.documentManager.BarAndDockingController = this.barAndDockingController1;
            this.documentManager.ContainerControl = this;
            this.documentManager.MenuManager = this.ribbonControl1;
            this.documentManager.ShowToolTips = DevExpress.Utils.DefaultBoolean.True;
            this.documentManager.View = this.tabbedView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView});
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bciColoredTabs,
            this.biAddDocument,
            this.beiHeadeLocation,
            this.beiHeaderOrientation,
            this.beiOrientation,
            this.beiClosePageButton,
            this.beiShowPinTab,
            this.barDockingMenuItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 18;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemImageComboBox3,
            this.repositoryItemImageComboBox4,
            this.repositoryItemImageComboBox5,
            this.repositoryItemCheckedComboBoxEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemSpinEdit2,
            this.repositoryItemTextEdit3});
            this.ribbonControl1.Size = new System.Drawing.Size(807, 150);
            // 
            // bciColoredTabs
            // 
            this.bciColoredTabs.Caption = "Colored Tabs";
            this.bciColoredTabs.Id = 4;
            this.bciColoredTabs.Name = "bciColoredTabs";
            this.bciColoredTabs.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bciColoredTabs_CheckedChanged);
            // 
            // biAddDocument
            // 
            this.biAddDocument.Caption = "Add New Document";
            this.biAddDocument.Id = 0;
            this.biAddDocument.Name = "biAddDocument";
            this.biAddDocument.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biAddDocumentClick);
            // 
            // beiHeadeLocation
            // 
            this.beiHeadeLocation.Caption = "  Location";
            this.beiHeadeLocation.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.beiHeadeLocation.Edit = this.repositoryItemImageComboBox1;
            this.beiHeadeLocation.EditWidth = 110;
            this.beiHeadeLocation.Id = 5;
            this.beiHeadeLocation.Name = "beiHeadeLocation";
            this.beiHeadeLocation.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.beiHeadeLocation.EditValueChanged += new System.EventHandler(this.headerLocationChanged);
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // beiHeaderOrientation
            // 
            this.beiHeaderOrientation.Caption = "  Orientation";
            this.beiHeaderOrientation.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.beiHeaderOrientation.Edit = this.repositoryItemImageComboBox2;
            this.beiHeaderOrientation.EditWidth = 110;
            this.beiHeaderOrientation.Id = 6;
            this.beiHeaderOrientation.Name = "beiHeaderOrientation";
            this.beiHeaderOrientation.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.beiHeaderOrientation.EditValueChanged += new System.EventHandler(this.headerOrientationChanged);
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            // 
            // beiOrientation
            // 
            this.beiOrientation.Caption = "  Orientation";
            this.beiOrientation.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.beiOrientation.Edit = this.repositoryItemImageComboBox3;
            this.beiOrientation.EditWidth = 100;
            this.beiOrientation.Id = 3;
            this.beiOrientation.Name = "beiOrientation";
            this.beiOrientation.EditValueChanged += new System.EventHandler(this.viewOrientationChanged);
            // 
            // repositoryItemImageComboBox3
            // 
            this.repositoryItemImageComboBox3.AutoHeight = false;
            this.repositoryItemImageComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3";
            // 
            // beiClosePageButton
            // 
            this.beiClosePageButton.Caption = "  Show Close Button";
            this.beiClosePageButton.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.beiClosePageButton.Edit = this.repositoryItemImageComboBox4;
            this.beiClosePageButton.EditWidth = 145;
            this.beiClosePageButton.Id = 4;
            this.beiClosePageButton.Name = "beiClosePageButton";
            this.beiClosePageButton.EditValueChanged += new System.EventHandler(this.closePageButtonModeChanged);
            // 
            // repositoryItemImageComboBox4
            // 
            this.repositoryItemImageComboBox4.AutoHeight = false;
            this.repositoryItemImageComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4";
            // 
            // beiShowPinTab
            // 
            this.beiShowPinTab.Caption = "  Show Pin Button";
            this.beiShowPinTab.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.beiShowPinTab.Edit = this.repositoryItemImageComboBox5;
            this.beiShowPinTab.EditWidth = 145;
            this.beiShowPinTab.Id = 5;
            this.beiShowPinTab.Name = "beiShowPinTab";
            this.beiShowPinTab.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.beiShowPinTab.EditValueChanged += new System.EventHandler(this.showPinTabChanged);
            // 
            // repositoryItemImageComboBox5
            // 
            this.repositoryItemImageComboBox5.AutoHeight = false;
            this.repositoryItemImageComboBox5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox5.Name = "repositoryItemImageComboBox5";
            // 
            // barDockingMenuItem1
            // 
            this.barDockingMenuItem1.Caption = "Manage Documents Layout";
            this.barDockingMenuItem1.Id = 13;
            this.barDockingMenuItem1.Name = "barDockingMenuItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Tabbed View Settings";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.biAddDocument, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.beiOrientation);
            this.ribbonPageGroup2.ItemLinks.Add(this.barDockingMenuItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Layout";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.beiHeadeLocation, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.beiHeaderOrientation);
            this.ribbonPageGroup3.ItemLinks.Add(this.beiClosePageButton, false, "", "", true);
            this.ribbonPageGroup3.ItemLinks.Add(this.beiShowPinTab, false, "", "", true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Tab Header Options";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.bciColoredTabs);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Appearance";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup5.ItemLinks.Add(this.bciDockGuides);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Behavior";
            // 
            // bciDockGuides
            // 
            this.bciDockGuides.Caption = "Show DockGuides On Pressing Shift";
            this.bciDockGuides.Id = 10;
            this.bciDockGuides.Name = "bciDockGuides";
            this.bciDockGuides.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bciDockGuides_CheckedChanged);
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.IsFloatValue = false;
            this.repositoryItemSpinEdit1.Mask.EditMask = "N00";
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            this.repositoryItemSpinEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // tabbedView
            // 
            this.tabbedView.DocumentProperties.AllowPin = true;
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("Document4", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Document4"))));
            this.svgImageCollection1.Add("Document", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Document"))));
            this.svgImageCollection1.Add("Document1", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Document1"))));
            this.svgImageCollection1.Add("Document2", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Document2"))));
            this.svgImageCollection1.Add("Document5", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Document5"))));
            // 
            // DocumentManagerTabbedDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DocumentManagerTabbedDocuments";
            this.Size = new System.Drawing.Size(807, 448);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;

        private DevExpress.XtraBars.BarEditItem beiHeadeLocation;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraBars.BarEditItem beiHeaderOrientation;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraBars.BarEditItem beiOrientation;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraBars.BarButtonItem biAddDocument;
        private DevExpress.XtraBars.BarCheckItem bciColoredTabs;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraBars.BarEditItem beiClosePageButton;
        private DevExpress.XtraBars.BarEditItem beiShowPinTab;
        private XtraBars.Ribbon.RibbonControl ribbonControl1;
        private XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox4;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox5;
        private XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private XtraBars.Ribbon.RibbonPage ribbonPage1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private XtraBars.BarCheckItem bciDockGuides;
        private XtraBars.BarDockingMenuItem barDockingMenuItem1;
        private Utils.SvgImageCollection svgImageCollection1;
    }
}
