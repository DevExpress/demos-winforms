using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.WinExplorer;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils;
using System.Diagnostics;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos {
    public partial class WinExplorerViewDatabaseBinding : TutorialControl {
        public WinExplorerViewDatabaseBinding() {
            AutoMergeRibbon = true;
            InitializeComponent();
            if(MainFormHelper.TakeScreens) {
                this.winExplorerView1.OptionsView.AnimationType = Views.Base.GridAnimationType.NeverAnimate;
                winExplorerView1.OptionsImageLoad.AsyncLoad = false;
            }
            LicenseInfo.SetToolTipController(this, gridControl1);
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            InitVehiclesData();
            InitGrid();
        }

        protected override void InitXMLData(string dataFileName) {
            VehiclesData.InitXMLData(dataFileName, gridControl1);
        }
        private void InitGrid() {
            this.winExplorerView1.Columns.Clear();
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "ID" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "Name" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "Description" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "Photo" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "InStock" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "CategoryName" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "TrademarkName" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "TransmissionType" });

            RepositoryItemTextEdit item = new RepositoryItemTextEdit();
            this.winExplorerView1.Columns["Name"].ColumnEdit = item;
            this.gridControl1.RepositoryItems.Add(item);

            this.winExplorerView1.ColumnSet.TextColumn = this.winExplorerView1.Columns["Name"];
            this.winExplorerView1.ColumnSet.DescriptionColumn = this.winExplorerView1.Columns["Description"];
            this.winExplorerView1.ColumnSet.ExtraLargeImageColumn = this.winExplorerView1.Columns["Photo"];
            this.winExplorerView1.ColumnSet.MediumImageColumn = this.winExplorerView1.Columns["Photo"];
            this.winExplorerView1.ColumnSet.CheckBoxColumn = this.winExplorerView1.Columns["InStock"];
            this.winExplorerView1.ColumnSet.GroupColumn = this.winExplorerView1.Columns["CategoryName"];
        }

        private void ribbonGalleryBarItem1_Gallery_ItemCheckedChanged(object sender, XtraBars.Ribbon.GalleryItemEventArgs e) {
            bool allowAsyncLoad = false;
            if(!e.Item.Checked)
                return;
            switch(e.Item.Caption) {
                case "Extra large icons":
                    allowAsyncLoad = true;
                    this.winExplorerView1.OptionsView.Style = WinExplorerViewStyle.ExtraLarge;
                    break;
                case "Large icons":
                    allowAsyncLoad = true;
                    this.winExplorerView1.OptionsView.Style = WinExplorerViewStyle.Large;
                    break;
                case "Medium icons":
                    allowAsyncLoad = true;
                    this.winExplorerView1.OptionsView.Style = WinExplorerViewStyle.Medium;
                    break;
                case "Small icons":
                    this.winExplorerView1.OptionsView.Style = WinExplorerViewStyle.Small;
                    break;
                case "List":
                    this.winExplorerView1.OptionsView.Style = WinExplorerViewStyle.List;
                    break;
                case "Tiles":
                    this.winExplorerView1.OptionsView.Style = WinExplorerViewStyle.Tiles;
                    break;
                case "Content":
                    this.winExplorerView1.OptionsView.Style = WinExplorerViewStyle.Content;
                    break;
            }
            UpdateGridOptionsImageLoad(allowAsyncLoad);
        }

        private void UpdateGridOptionsImageLoad(bool allowAsyncLoad) {
            if(MainFormHelper.TakeScreens) allowAsyncLoad = false;
            if(winExplorerView1.OptionsImageLoad.AsyncLoad == allowAsyncLoad) return;
            winExplorerView1.OptionsImageLoad.AsyncLoad = allowAsyncLoad;
            winExplorerView1.RefreshData();
        }

        private void bcItemCheckBoxes_CheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            this.winExplorerView1.OptionsView.ShowCheckBoxes = this.bcItemCheckBoxes.Checked;
        }

        private void bcGroupCaptionButton_CheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            this.winExplorerView1.OptionsView.ShowExpandCollapseButtons = this.bcGroupCaptionButton.Checked;
        }
        
        private void bcGroupCheckBoxes_CheckedChanged(object sender, ItemClickEventArgs e) {
            this.winExplorerView1.OptionsView.ShowCheckBoxInGroupCaption = this.bcGroupCheckBoxes.Checked;
        }

        private void OnSortingCheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            if(!((BarCheckItem)e.Item).Checked)
                return;
            if(e.Item == bcAscending) {
                this.winExplorerView1.ColumnSet.GroupColumn.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                this.winExplorerView1.ColumnSet.TextColumn.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            }
            if(e.Item == bcDescending) {
                this.winExplorerView1.ColumnSet.GroupColumn.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
                this.winExplorerView1.ColumnSet.TextColumn.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            }
            if(e.Item == bcSortNone) {
                this.winExplorerView1.ColumnSet.GroupColumn.SortOrder = DevExpress.Data.ColumnSortOrder.None;
                this.winExplorerView1.ColumnSet.TextColumn.SortOrder = DevExpress.Data.ColumnSortOrder.None;
            }
        }

        private void OnGroupByCheckedChanged(object sender, ItemClickEventArgs e) {
            this.winExplorerView1.GroupCount = e.Item == this.bcGroupNone ? 0 : 1;
            if(e.Item == this.bcTrademark)
                this.winExplorerView1.ColumnSet.GroupColumn = this.winExplorerView1.Columns["TrademarkName"];
            else if(e.Item == this.bcTransmissionType)
                this.winExplorerView1.ColumnSet.GroupColumn = this.winExplorerView1.Columns["TransmissionType"];
            else if(e.Item == this.bcCategory)
                this.winExplorerView1.ColumnSet.GroupColumn = this.winExplorerView1.Columns["CategoryName"];
        }
        private void OnAnimationTypeChanged(object sender, ItemClickEventArgs e) {
            if(e.Item == this.bcAnimationNone)
                this.winExplorerView1.OptionsImageLoad.AnimationType = ImageContentAnimationType.None;
            else if(e.Item == this.bcExpandAnimation)
                this.winExplorerView1.OptionsImageLoad.AnimationType = ImageContentAnimationType.Expand;
            else if(e.Item == this.bcPushAnimation)
                this.winExplorerView1.OptionsImageLoad.AnimationType = ImageContentAnimationType.Push;
            else if(e.Item == this.bcSlideAnimation)
                this.winExplorerView1.OptionsImageLoad.AnimationType = ImageContentAnimationType.Slide;
            else if(e.Item == this.bcSegmentedAnimation)
                this.winExplorerView1.OptionsImageLoad.AnimationType = ImageContentAnimationType.SegmentedFade;
            var dataSource = this.gridControl1.DataSource;
            this.gridControl1.DataSource = null;
            this.gridControl1.DataSource = dataSource;
        }

        private void barCheckItem1_ItemClick(object sender, ItemClickEventArgs e) {
            this.winExplorerView1.OptionsImageLoad.RandomShow = barCheckItem1.Checked;
        }

        private void winExplorerView1_GetThumbnailImage(object sender, ThumbnailImageEventArgs e) {
            Stopwatch w = new Stopwatch();
            w.Start();
            while(w.ElapsedMilliseconds < 20) { }
            w.Stop();
        }
    }
}
