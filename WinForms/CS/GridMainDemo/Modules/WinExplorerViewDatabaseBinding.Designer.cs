namespace DevExpress.XtraGrid.Demos {
    partial class WinExplorerViewDatabaseBinding {
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
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinExplorerViewDatabaseBinding));
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem4 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem5 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem6 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem7 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.Skins.SkinPaddingEdges skinPaddingEdges1 = new DevExpress.Skins.SkinPaddingEdges();
            DevExpress.Skins.SkinPaddingEdges skinPaddingEdges2 = new DevExpress.Skins.SkinPaddingEdges();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.winExplorerView1 = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.rgbiViewStyles = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.bsSortBy = new DevExpress.XtraBars.BarSubItem();
            this.bcAscending = new DevExpress.XtraBars.BarCheckItem();
            this.bcDescending = new DevExpress.XtraBars.BarCheckItem();
            this.bcSortNone = new DevExpress.XtraBars.BarCheckItem();
            this.bsGroupBy = new DevExpress.XtraBars.BarSubItem();
            this.bcTrademark = new DevExpress.XtraBars.BarCheckItem();
            this.bcCategory = new DevExpress.XtraBars.BarCheckItem();
            this.bcTransmissionType = new DevExpress.XtraBars.BarCheckItem();
            this.bcGroupNone = new DevExpress.XtraBars.BarCheckItem();
            this.bcItemCheckBoxes = new DevExpress.XtraBars.BarCheckItem();
            this.bcGroupCaptionButton = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem5 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem6 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem7 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem8 = new DevExpress.XtraBars.BarCheckItem();
            this.bcGroupCheckBoxes = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.bsAnimationType = new DevExpress.XtraBars.BarSubItem();
            this.bcAnimationNone = new DevExpress.XtraBars.BarCheckItem();
            this.bcExpandAnimation = new DevExpress.XtraBars.BarCheckItem();
            this.bcPushAnimation = new DevExpress.XtraBars.BarCheckItem();
            this.bcSegmentedAnimation = new DevExpress.XtraBars.BarCheckItem();
            this.bcSlideAnimation = new DevExpress.XtraBars.BarCheckItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 150);
            this.gridControl1.MainView = this.winExplorerView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(784, 282);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.winExplorerView1});
            // 
            // winExplorerView1
            // 
            this.winExplorerView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.winExplorerView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName});
            this.winExplorerView1.GridControl = this.gridControl1;
            this.winExplorerView1.Name = "winExplorerView1";
            this.winExplorerView1.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.Slide;
            this.winExplorerView1.OptionsImageLoad.AsyncLoad = true;
            this.winExplorerView1.OptionsImageLoad.CacheThumbnails = false;
            this.winExplorerView1.OptionsImageLoad.LoadThumbnailImagesFromDataSource = false;
            this.winExplorerView1.OptionsSelection.AllowMarqueeSelection = true;
            this.winExplorerView1.OptionsSelection.ItemSelectionMode = DevExpress.XtraGrid.Views.WinExplorer.IconItemSelectionMode.Click;
            this.winExplorerView1.OptionsSelection.MultiSelect = true;
            this.winExplorerView1.OptionsView.ShowExpandCollapseButtons = true;
            this.winExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.ExtraLarge;
            this.winExplorerView1.OptionsViewStyles.ExtraLarge.ImageSize = new System.Drawing.Size(220, 129);
            this.winExplorerView1.OptionsViewStyles.Large.ImageSize = new System.Drawing.Size(96, 56);
            this.winExplorerView1.GetThumbnailImage += new DevExpress.Utils.ThumbnailImageEventHandler(this.winExplorerView1_GetThumbnailImage);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.rgbiViewStyles,
            this.bsSortBy,
            this.bcAscending,
            this.bcDescending,
            this.bcSortNone,
            this.bsGroupBy,
            this.bcItemCheckBoxes,
            this.bcGroupCaptionButton,
            this.bcTrademark,
            this.bcCategory,
            this.bcTransmissionType,
            this.bcGroupNone,
            this.barCheckItem5,
            this.barCheckItem6,
            this.barCheckItem7,
            this.barCheckItem8,
            this.bcGroupCheckBoxes,
            this.barCheckItem1,
            this.bsAnimationType,
            this.bcAnimationNone,
            this.bcExpandAnimation,
            this.bcPushAnimation,
            this.bcSlideAnimation,
            this.bcSegmentedAnimation});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 24;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(784, 150);
            // 
            // rgbiViewStyles
            // 
            this.rgbiViewStyles.Caption = "ribbonGalleryBarItem1";
            // 
            // 
            // 
            this.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = true;
            this.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
            this.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = true;
            this.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
            this.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.rgbiViewStyles.Gallery.ColumnCount = 3;
            this.rgbiViewStyles.Gallery.DrawImageBackground = false;
            galleryItemGroup1.Caption = "Group1";
            galleryItem1.Caption = "Extra large icons";
            galleryItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            galleryItem2.Caption = "Large icons";
            galleryItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
            galleryItem3.Caption = "Medium icons";
            galleryItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage2")));
            galleryItem4.Caption = "Small icons";
            galleryItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage3")));
            galleryItem5.Caption = "List";
            galleryItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage4")));
            galleryItem6.Caption = "Tiles";
            galleryItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage5")));
            galleryItem7.Caption = "Content";
            galleryItem7.Checked = true;
            galleryItem7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage6")));
            galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2,
            galleryItem3,
            galleryItem4,
            galleryItem5,
            galleryItem6,
            galleryItem7});
            this.rgbiViewStyles.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.rgbiViewStyles.Gallery.ImageSize = new System.Drawing.Size(18, 18);
            this.rgbiViewStyles.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio;
            this.rgbiViewStyles.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            skinPaddingEdges1.Bottom = -3;
            skinPaddingEdges1.Top = -3;
            this.rgbiViewStyles.Gallery.ItemImagePadding = skinPaddingEdges1;
            skinPaddingEdges2.Bottom = -1;
            skinPaddingEdges2.Top = -1;
            this.rgbiViewStyles.Gallery.ItemTextPadding = skinPaddingEdges2;
            this.rgbiViewStyles.Gallery.ShowItemText = true;
            this.rgbiViewStyles.Gallery.ItemCheckedChanged += new DevExpress.XtraBars.Ribbon.GalleryItemEventHandler(this.ribbonGalleryBarItem1_Gallery_ItemCheckedChanged);
            this.rgbiViewStyles.Id = 1;
            this.rgbiViewStyles.Name = "rgbiViewStyles";
            // 
            // bsSortBy
            // 
            this.bsSortBy.Caption = "Sort";
            this.bsSortBy.Id = 2;
            this.bsSortBy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bsSortBy.ImageOptions.SvgImage")));
            this.bsSortBy.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bcAscending),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcDescending),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcSortNone)});
            this.bsSortBy.Name = "bsSortBy";
            // 
            // bcAscending
            // 
            this.bcAscending.Caption = "Ascending";
            this.bcAscending.GroupIndex = 2;
            this.bcAscending.Id = 3;
            this.bcAscending.Name = "bcAscending";
            this.bcAscending.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnSortingCheckedChanged);
            // 
            // bcDescending
            // 
            this.bcDescending.Caption = "Descending";
            this.bcDescending.GroupIndex = 2;
            this.bcDescending.Id = 4;
            this.bcDescending.Name = "bcDescending";
            this.bcDescending.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnSortingCheckedChanged);
            // 
            // bcSortNone
            // 
            this.bcSortNone.Caption = "None";
            this.bcSortNone.GroupIndex = 2;
            this.bcSortNone.Id = 5;
            this.bcSortNone.Name = "bcSortNone";
            this.bcSortNone.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnSortingCheckedChanged);
            // 
            // bsGroupBy
            // 
            this.bsGroupBy.Caption = "Group by";
            this.bsGroupBy.Id = 6;
            this.bsGroupBy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bsGroupBy.ImageOptions.SvgImage")));
            this.bsGroupBy.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bcTrademark),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcCategory),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcTransmissionType),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcGroupNone)});
            this.bsGroupBy.Name = "bsGroupBy";
            // 
            // bcTrademark
            // 
            this.bcTrademark.Caption = "Trademark";
            this.bcTrademark.GroupIndex = 1;
            this.bcTrademark.Id = 9;
            this.bcTrademark.Name = "bcTrademark";
            this.bcTrademark.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnGroupByCheckedChanged);
            // 
            // bcCategory
            // 
            this.bcCategory.BindableChecked = true;
            this.bcCategory.Caption = "Category";
            this.bcCategory.Checked = true;
            this.bcCategory.GroupIndex = 1;
            this.bcCategory.Id = 10;
            this.bcCategory.Name = "bcCategory";
            this.bcCategory.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnGroupByCheckedChanged);
            // 
            // bcTransmissionType
            // 
            this.bcTransmissionType.Caption = "Transmission type";
            this.bcTransmissionType.GroupIndex = 1;
            this.bcTransmissionType.Id = 11;
            this.bcTransmissionType.Name = "bcTransmissionType";
            this.bcTransmissionType.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnGroupByCheckedChanged);
            // 
            // bcGroupNone
            // 
            this.bcGroupNone.Caption = "None";
            this.bcGroupNone.GroupIndex = 1;
            this.bcGroupNone.Id = 12;
            this.bcGroupNone.Name = "bcGroupNone";
            this.bcGroupNone.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnGroupByCheckedChanged);
            // 
            // bcItemCheckBoxes
            // 
            this.bcItemCheckBoxes.Caption = "Item check boxes";
            this.bcItemCheckBoxes.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.bcItemCheckBoxes.Id = 7;
            this.bcItemCheckBoxes.Name = "bcItemCheckBoxes";
            this.bcItemCheckBoxes.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bcItemCheckBoxes_CheckedChanged);
            // 
            // bcGroupCaptionButton
            // 
            this.bcGroupCaptionButton.BindableChecked = true;
            this.bcGroupCaptionButton.Caption = "Group caption buttons";
            this.bcGroupCaptionButton.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.bcGroupCaptionButton.Checked = true;
            this.bcGroupCaptionButton.Id = 8;
            this.bcGroupCaptionButton.Name = "bcGroupCaptionButton";
            this.bcGroupCaptionButton.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bcGroupCaptionButton_CheckedChanged);
            // 
            // barCheckItem5
            // 
            this.barCheckItem5.Caption = "barCheckItem5";
            this.barCheckItem5.Id = 13;
            this.barCheckItem5.Name = "barCheckItem5";
            // 
            // barCheckItem6
            // 
            this.barCheckItem6.Caption = "barCheckItem6";
            this.barCheckItem6.Id = 14;
            this.barCheckItem6.Name = "barCheckItem6";
            // 
            // barCheckItem7
            // 
            this.barCheckItem7.Caption = "barCheckItem7";
            this.barCheckItem7.Id = 15;
            this.barCheckItem7.Name = "barCheckItem7";
            // 
            // barCheckItem8
            // 
            this.barCheckItem8.Caption = "barCheckItem8";
            this.barCheckItem8.Id = 16;
            this.barCheckItem8.Name = "barCheckItem8";
            // 
            // bcGroupCheckBoxes
            // 
            this.bcGroupCheckBoxes.Caption = "Group check boxes";
            this.bcGroupCheckBoxes.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.bcGroupCheckBoxes.Id = 19;
            this.bcGroupCheckBoxes.Name = "bcGroupCheckBoxes";
            this.bcGroupCheckBoxes.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bcGroupCheckBoxes_CheckedChanged);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.BindableChecked = true;
            this.barCheckItem1.Caption = "Random show";
            this.barCheckItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.barCheckItem1.Checked = true;
            this.barCheckItem1.Id = 21;
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem1_ItemClick);
            // 
            // bsAnimationType
            // 
            this.bsAnimationType.Caption = "Animation type";
            this.bsAnimationType.Id = 23;
            this.bsAnimationType.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bcAnimationNone),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcExpandAnimation),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcPushAnimation),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcSegmentedAnimation),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcSlideAnimation)});
            this.bsAnimationType.Name = "bsAnimationType";
            // 
            // bcAnimationNone
            // 
            this.bcAnimationNone.Caption = "None";
            this.bcAnimationNone.GroupIndex = 4;
            this.bcAnimationNone.Id = 24;
            this.bcAnimationNone.Name = "bcAnimationNone";
            this.bcAnimationNone.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAnimationTypeChanged);
            // 
            // bcExpandAnimation
            // 
            this.bcExpandAnimation.Caption = "Expand";
            this.bcExpandAnimation.GroupIndex = 4;
            this.bcExpandAnimation.Id = 25;
            this.bcExpandAnimation.Name = "bcExpandAnimation";
            this.bcExpandAnimation.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAnimationTypeChanged);
            // 
            // bcPushAnimation
            // 
            this.bcPushAnimation.Caption = "Push";
            this.bcPushAnimation.GroupIndex = 4;
            this.bcPushAnimation.Id = 26;
            this.bcPushAnimation.Name = "bcPushAnimation";
            this.bcPushAnimation.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAnimationTypeChanged);
            // 
            // bcSegmentedAnimation
            // 
            this.bcSegmentedAnimation.Caption = "Segmented fade";
            this.bcSegmentedAnimation.GroupIndex = 4;
            this.bcSegmentedAnimation.Id = 28;
            this.bcSegmentedAnimation.Name = "bcSegmentedAnimation";
            this.bcSegmentedAnimation.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAnimationTypeChanged);
            // 
            // bcSlideAnimation
            // 
            this.bcSlideAnimation.BindableChecked = true;
            this.bcSlideAnimation.Caption = "Slide";
            this.bcSlideAnimation.Checked = true;
            this.bcSlideAnimation.GroupIndex = 4;
            this.bcSlideAnimation.Id = 27;
            this.bcSlideAnimation.Name = "bcSlideAnimation";
            this.bcSlideAnimation.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAnimationTypeChanged);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "WinExplorer View";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.rgbiViewStyles);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Layout";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup2.ItemLinks.Add(this.bsSortBy);
            this.ribbonPageGroup2.ItemLinks.Add(this.bsGroupBy);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Current view";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup3.ItemLinks.Add(this.bcItemCheckBoxes);
            this.ribbonPageGroup3.ItemLinks.Add(this.bcGroupCaptionButton);
            this.ribbonPageGroup3.ItemLinks.Add(this.bcGroupCheckBoxes);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Show&&Hide";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup4.ItemLinks.Add(this.bsAnimationType);
            this.ribbonPageGroup4.ItemLinks.Add(this.barCheckItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Image Load Options";
            // 
            // WinExplorerViewDatabaseBinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "WinExplorerViewDatabaseBinding";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GridControl gridControl1;
        private XtraBars.Ribbon.RibbonControl ribbonControl1;
        private XtraBars.Ribbon.RibbonPage ribbonPage1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private XtraBars.RibbonGalleryBarItem rgbiViewStyles;
        private XtraBars.BarSubItem bsSortBy;
        private XtraBars.BarCheckItem bcAscending;
        private XtraBars.BarCheckItem bcDescending;
        private XtraBars.BarCheckItem bcSortNone;
        private XtraBars.BarSubItem bsGroupBy;
        private XtraBars.BarCheckItem bcItemCheckBoxes;
        private XtraBars.BarCheckItem bcGroupCaptionButton;
        private Views.WinExplorer.WinExplorerView winExplorerView1;
        private XtraBars.BarCheckItem bcTrademark;
        private XtraBars.BarCheckItem bcCategory;
        private XtraBars.BarCheckItem bcTransmissionType;
        private XtraBars.BarCheckItem bcGroupNone;
        private XtraBars.BarCheckItem barCheckItem5;
        private XtraBars.BarCheckItem barCheckItem6;
        private XtraBars.BarCheckItem barCheckItem7;
        private XtraBars.BarCheckItem barCheckItem8;
        private XtraBars.BarSubItem bsAnimationType;
        private XtraBars.BarCheckItem bcAnimationNone;
        private XtraBars.BarCheckItem bcSlideAnimation;
        private XtraBars.BarCheckItem bcExpandAnimation;
        private XtraBars.BarCheckItem bcPushAnimation;
        private XtraBars.BarCheckItem bcSegmentedAnimation;
        private Columns.GridColumn colID;
        private Columns.GridColumn colName;
        private XtraBars.BarCheckItem bcGroupCheckBoxes;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private XtraBars.BarCheckItem barCheckItem1;
    }
}
