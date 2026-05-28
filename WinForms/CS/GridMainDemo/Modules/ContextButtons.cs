using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;

namespace DevExpress.XtraGrid.Demos {
    public partial class ContextButtons : TutorialControl {
        public ContextButtons() {
            InitializeComponent();
            SetGalleryImageSize(300);
            LicenseInfo.SetToolTipController(this, gridControl1);
        }
        void item_CheckedChanged(object sender, ItemClickEventArgs e) {
            BarCheckItem item = (BarCheckItem)e.Item;
            if(item.Checked)
                this.winExplorerView1.ContextButtonOptions.AnimationType = (ContextAnimationType)item.Tag;
        }
        void SetGalleryImageSize(int width) {
            this.winExplorerView1.OptionsViewStyles.ExtraLarge.ImageSize = new Size(width, (int)(width * 0.6));
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            InitVehiclesData();
            InitGrid();
            UpdateContextButtonsPanelsColors();
        }
        protected override void InitXMLData(string dataFileName) {
            VehiclesData.InitXMLData(dataFileName, gridControl1);
        }
        void InitGrid() {
            this.winExplorerView1.Columns.Clear();
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "ID" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "Name" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "Description" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "Photo" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "InStock" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "CategoryName" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "TrademarkName" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "Transmission" });

            this.winExplorerView1.ColumnSet.DescriptionColumn = this.winExplorerView1.Columns["Description"];
            this.winExplorerView1.ColumnSet.ExtraLargeImageColumn = this.winExplorerView1.Columns["Photo"];
            this.winExplorerView1.ColumnSet.MediumImageColumn = this.winExplorerView1.Columns["Photo"];
            this.winExplorerView1.ColumnSet.CheckBoxColumn = this.winExplorerView1.Columns["InStock"];
            this.winExplorerView1.ColumnSet.GroupColumn = this.winExplorerView1.Columns["CategoryName"];
        }
        Dictionary<int, bool> checkedValuesCore;
        protected Dictionary<int, bool> CheckedValues {
            get {
                if(checkedValuesCore == null)
                    checkedValuesCore = new Dictionary<int, bool>();
                return checkedValuesCore;
            }
        }
        Dictionary<int, int> ratingValuesCore;
        protected Dictionary<int, int> RatingValues {
            get {
                if(ratingValuesCore == null)
                    ratingValuesCore = new Dictionary<int, int>();
                return ratingValuesCore;
            }
        }
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdateContextButtonsPanelsColors();
        }
        void UpdateContextButtonsPanelsColors() {
            winExplorerView1.ContextButtonOptions.BottomPanelColor = winExplorerView1.ContextButtonOptions.TopPanelColor = Color.FromArgb(160, LookAndFeelHelper.GetSystemColor(LookAndFeel, SystemColors.Control));
            
        }
        void winExplorerView1_ContextButtonCustomize(object sender, Views.WinExplorer.WinExplorerViewContextButtonCustomizeEventArgs e) {
            if(e.Item.Name == "itemText") {
                ((ContextButton)e.Item).Caption = GetContextButtonCaption(e.RowHandle, this.winExplorerView1.Columns["Name"], this.winExplorerView1.Columns["TrademarkName"]);
            }
            else if(e.Item.Name == "itemCheck") {
                if(!CheckedValues.ContainsKey(e.RowHandle))
                    CheckedValues.Add(e.RowHandle, e.RowHandle % 2 == 0);
                ((CheckContextButton)e.Item).Checked = CheckedValues[e.RowHandle];
            }
            else if(e.Item.Name == "itemRating") {
                if(!RatingValues.ContainsKey(e.RowHandle))
                    RatingValues.Add(e.RowHandle, e.RowHandle % 6);
                ((RatingContextButton)e.Item).Rating = RatingValues[e.RowHandle];
            }
        }
        string GetContextButtonCaption(int rowHandle, GridColumn model, GridColumn trademark) {
            string _caption = string.Empty;
            if(model != null) 
                _caption = (string)this.winExplorerView1.GetRowCellValue(rowHandle, model);
            if(_caption != null && trademark != null && _caption.Length < 20)
                _caption = string.Format("{0} {1}", this.winExplorerView1.GetRowCellValue(rowHandle, trademark), _caption); ;
            return _caption;
        }
        void winExplorerView1_ContextButtonClick(object sender, ContextItemClickEventArgs e) {
            if(e.Item.Name == "itemCheck") {
                CheckedValues[(int)e.DataItem] = ((CheckContextButton)e.Item).Checked;
            }
            else if(e.Item.Name == "itemRating") {
                RatingValues[(int)e.DataItem] = (int)((RatingContextButton)e.Item).Rating;
            }
            else if(e.Item.Name == "itemDownload"){
                DevExpress.XtraEditors.XtraMessageBox.Show("'Download' item clicked");
            }
            else if(e.Item.Name == "itemRemove") {
                DevExpress.XtraEditors.XtraMessageBox.Show("'Remove' item clicked");
            }
            else if(e.Item.Name == "itemInfo") {
                DevExpress.XtraEditors.XtraMessageBox.Show("'Info' item clicked");
            }
        }
        void OnAnimationTypeEditValueChanged(object sender, EventArgs e) {
            var value = (ContextAnimationType)radioGroup1.EditValue;
            this.winExplorerView1.ContextButtonOptions.AnimationType = value;
        }
        void OnZoomTrackBarEditValueChanged(object sender, EventArgs e) {
            int value = ((ZoomTrackBarControl)sender).Value;
            SetGalleryImageSize(value);
        }
    }
}
