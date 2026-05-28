namespace DevExpress.XtraGrid.Demos {
    partial class ContextButtons {
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
            DevExpress.Utils.ContextButton contextButton1 = new DevExpress.Utils.ContextButton();
            DevExpress.Utils.ContextButton contextButton2 = new DevExpress.Utils.ContextButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContextButtons));
            DevExpress.Utils.ContextButton contextButton3 = new DevExpress.Utils.ContextButton();
            DevExpress.Utils.ContextButton contextButton4 = new DevExpress.Utils.ContextButton();
            DevExpress.Utils.CheckContextButton checkContextButton1 = new DevExpress.Utils.CheckContextButton();
            DevExpress.Utils.RatingContextButton ratingContextButton1 = new DevExpress.Utils.RatingContextButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.winExplorerView1 = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.zoomTrackBarControl1 = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.winExplorerView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(461, 458);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.winExplorerView1});
            // 
            // winExplorerView1
            // 
            this.winExplorerView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.winExplorerView1.ContextButtonOptions.BottomPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.winExplorerView1.ContextButtonOptions.Indent = 3;
            this.winExplorerView1.ContextButtonOptions.TopPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            contextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Center;
            contextButton1.AppearanceHover.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            contextButton1.AppearanceHover.Options.UseFont = true;
            contextButton1.AppearanceNormal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            contextButton1.AppearanceNormal.Options.UseFont = true;
            contextButton1.Id = new System.Guid("62095aba-f30f-4377-b233-14b1eab8c0db");
            contextButton1.Name = "itemText";
            contextButton2.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            contextButton2.AppearanceHover.ForeColor = System.Drawing.Color.White;
            contextButton2.AppearanceHover.Options.UseForeColor = true;
            contextButton2.AppearanceNormal.ForeColor = System.Drawing.Color.White;
            contextButton2.AppearanceNormal.Options.UseForeColor = true;
            contextButton2.Id = new System.Guid("aff114b4-1a64-4e9b-ae04-098d9ddc4ec4");
            contextButton2.ImageOptionsCollection.ItemNormal.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            contextButton2.ImageOptionsCollection.ItemNormal.SvgImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.close;
            contextButton2.ImageOptionsCollection.ItemNormal.SvgImageSize = new System.Drawing.Size(16, 16);
            contextButton2.Name = "itemRemove";
            contextButton3.AppearanceHover.ForeColor = System.Drawing.Color.White;
            contextButton3.AppearanceHover.Options.UseForeColor = true;
            contextButton3.AppearanceNormal.ForeColor = System.Drawing.Color.White;
            contextButton3.AppearanceNormal.Options.UseForeColor = true;
            contextButton3.Id = new System.Guid("8919a814-c5ac-42a5-96fe-71a6f31d1f7e");
            contextButton3.ImageOptionsCollection.ItemNormal.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            contextButton3.ImageOptionsCollection.ItemNormal.SvgImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.download;
            contextButton3.ImageOptionsCollection.ItemNormal.SvgImageSize = new System.Drawing.Size(16, 16);
            contextButton3.Name = "itemDownload";
            contextButton4.AppearanceHover.ForeColor = System.Drawing.Color.White;
            contextButton4.AppearanceHover.Options.UseForeColor = true;
            contextButton4.AppearanceNormal.ForeColor = System.Drawing.Color.White;
            contextButton4.AppearanceNormal.Options.UseForeColor = true;
            contextButton4.Id = new System.Guid("52064e3b-1c98-4a1f-9296-07465624a0d5");
            contextButton4.ImageOptionsCollection.ItemNormal.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            contextButton4.ImageOptionsCollection.ItemNormal.SvgImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.about;
            contextButton4.ImageOptionsCollection.ItemNormal.SvgImageSize = new System.Drawing.Size(16, 16);
            contextButton4.Name = "itemInfo";
            checkContextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom;
            checkContextButton1.Id = new System.Guid("d5e27663-722f-40c8-8363-cc4eded0e782");
            checkContextButton1.ImageOptionsCollection.ItemChecked.SvgImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.check;
            checkContextButton1.ImageOptionsCollection.ItemNormal.SvgImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.uncheck;
            checkContextButton1.Name = "itemCheck";
            ratingContextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom;
            ratingContextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Center;
            ratingContextButton1.Id = new System.Guid("93da3997-ef55-4c87-8eef-d2881dc0e6dd");
            ratingContextButton1.ImageOptionsCollection.ItemChecked.SvgImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.starCheck;
            ratingContextButton1.ImageOptionsCollection.ItemHovered.SvgImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.starCheck;
            ratingContextButton1.ImageOptionsCollection.ItemNormal.SvgImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.starUncheck;
            ratingContextButton1.Name = "itemRating";
            ratingContextButton1.Rating = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.winExplorerView1.ContextButtons.Add(contextButton1);
            this.winExplorerView1.ContextButtons.Add(contextButton2);
            this.winExplorerView1.ContextButtons.Add(contextButton3);
            this.winExplorerView1.ContextButtons.Add(contextButton4);
            this.winExplorerView1.ContextButtons.Add(checkContextButton1);
            this.winExplorerView1.ContextButtons.Add(ratingContextButton1);
            this.winExplorerView1.GridControl = this.gridControl1;
            this.winExplorerView1.Name = "winExplorerView1";
            this.winExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.ExtraLarge;
            this.winExplorerView1.ContextButtonCustomize += new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewContextButtonCustomizeEventHandler(this.winExplorerView1_ContextButtonCustomize);
            this.winExplorerView1.ContextButtonClick += new DevExpress.Utils.ContextItemClickEventHandler(this.winExplorerView1_ContextButtonClick);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tabPane1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(461, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(250, 458);
            this.sidePanel1.TabIndex = 10;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(1, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(249, 458);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(249, 458);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Options";
            this.tabNavigationPage1.Controls.Add(this.layoutControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(249, 425);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.zoomTrackBarControl1);
            this.layoutControl1.Controls.Add(this.radioGroup1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(749, 172, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(249, 425);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // zoomTrackBarControl1
            // 
            this.zoomTrackBarControl1.EditValue = 292;
            this.zoomTrackBarControl1.Location = new System.Drawing.Point(12, 208);
            this.zoomTrackBarControl1.Name = "zoomTrackBarControl1";
            this.zoomTrackBarControl1.Properties.Maximum = 392;
            this.zoomTrackBarControl1.Properties.Middle = 292;
            this.zoomTrackBarControl1.Properties.Minimum = 192;
            this.zoomTrackBarControl1.Size = new System.Drawing.Size(225, 16);
            this.zoomTrackBarControl1.StyleController = this.layoutControl1;
            this.zoomTrackBarControl1.TabIndex = 6;
            this.zoomTrackBarControl1.Value = 292;
            this.zoomTrackBarControl1.EditValueChanged += new System.EventHandler(this.OnZoomTrackBarEditValueChanged);
            // 
            // radioGroup1
            // 
            this.radioGroup1.AutoSizeInLayoutControl = true;
            this.radioGroup1.EditValue = 0;
            this.radioGroup1.Location = new System.Drawing.Point(12, 34);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup1.Properties.Columns = 1;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Default"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "None"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Opacity Animation"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Out Animation"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Sequence Animation")});
            this.radioGroup1.Size = new System.Drawing.Size(225, 128);
            this.radioGroup1.StyleController = this.layoutControl1;
            this.radioGroup1.TabIndex = 4;
            this.radioGroup1.EditValueChanged += new System.EventHandler(this.OnAnimationTypeEditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(249, 425);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 233);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(249, 192);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(249, 174);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "Animation Type";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.radioGroup1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(229, 132);
            this.layoutControlItem1.Text = "Animation Type";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 174);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(249, 59);
            this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup3.Text = "Thumbnails";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.zoomTrackBarControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(229, 17);
            this.layoutControlItem3.Text = "Thumbnails";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextVisible = false;
            // 
            // ContextButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "ContextButtons";
            this.Size = new System.Drawing.Size(711, 458);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GridControl gridControl1;
        private Views.WinExplorer.WinExplorerView winExplorerView1;
        private XtraEditors.SidePanel sidePanel1;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraEditors.RadioGroup radioGroup1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraEditors.ZoomTrackBarControl zoomTrackBarControl1;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
    }
}
