using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.TableLayout;
using DevExpress.DXperience.Demos;
using DevExpress.Internal;

namespace DevExpress.XtraGrid.Demos {
    public partial class TileView : TutorialControl {
        public TileView() {
            InitializeComponent();
            InitData();
            SetupView();
            rgViewType.SelectedIndexChanged += RgViewType_SelectedIndexChanged;
            toggleSwitch1.EditValueChanged += ToggleSwitch1_EditValueChanged;
            zoomTrackBarControl1.EditValueChanged += repositoryItemZoomTrackBar1_EditValueChanged;
            tileView1.OptionsBehavior.AllowSmoothScrolling = true;
            if(MainFormHelper.TakeScreens) tileView1.AnimateArrival = false;

        }

        private void RgViewType_SelectedIndexChanged(object sender, EventArgs e) {
            tileView1.OptionsTiles.Orientation = (Orientation)rgViewType.SelectedIndex;
        }

        private void ToggleSwitch1_EditValueChanged(object sender, EventArgs e) {
            if(object.Equals(toggleSwitch1.EditValue,true))
                tileView1.ColumnSet.GroupColumn = tileView1.Columns["YearBuilt"];
            else
                tileView1.ColumnSet.GroupColumn = null;
        }

        void repositoryItemZoomTrackBar1_EditValueChanged(object sender, EventArgs e) {
            int h = (int)(sender as BaseEdit).EditValue;
            int w = (int)(h * 1.78);
            tileView1.OptionsTiles.ItemSize = new Size(w, h);
        }

        void SetupView() {
            try {
                // Setup tiles options
                tileView1.BeginUpdate();
                tileView1.OptionsTiles.RowCount = 3;
                tileView1.OptionsTiles.Padding = new Padding(20);
                tileView1.OptionsTiles.ItemPadding = new Padding(0);
                tileView1.OptionsTiles.IndentBetweenItems = 20;
                tileView1.OptionsTiles.ItemSize = new Size(340, 190);
                tileView1.Appearance.ItemNormal.ForeColor = Color.White;
                tileView1.Appearance.ItemNormal.BorderColor = Color.Transparent;


                //Setup tiles template
                tileView1.TileColumns.Add(new TableColumnDefinition());
                tileView1.TileColumns.Add(new TableColumnDefinition());
                tileView1.TileColumns[0].Length.Value = 0.4;
                tileView1.TileColumns[1].Length.Value = 0.6;

                TileViewItemElement splitLine = new TileViewItemElement();
                TileViewItemElement addressCaption = new TileViewItemElement();
                TileViewItemElement addressValue = new TileViewItemElement();
                TileViewItemElement yearBuiltCaption = new TileViewItemElement();
                TileViewItemElement yearBuiltValue = new TileViewItemElement();
                TileViewItemElement price = new TileViewItemElement();
                TileViewItemElement image = new TileViewItemElement();
                tileView1.TileTemplate.Add(splitLine);
                tileView1.TileTemplate.Add(addressCaption);
                tileView1.TileTemplate.Add(addressValue);
                tileView1.TileTemplate.Add(yearBuiltCaption);
                tileView1.TileTemplate.Add(yearBuiltValue);
                tileView1.TileTemplate.Add(price);
                tileView1.TileTemplate.Add(image);
                //
                splitLine.StretchVertical = true;
                splitLine.Width = 3;
                splitLine.TextAlignment = TileItemContentAlignment.MiddleRight;
                splitLine.Appearance.Normal.BackColor = Color.White;
                //
                addressCaption.Name = "AddressCaption";
                addressCaption.Text = "ADDRESS";
                addressCaption.TextAlignment = TileItemContentAlignment.TopLeft;
                addressCaption.TextLocation = new Point(10, 10);
                addressCaption.Appearance.Normal.FontSizeDelta = -1;
                //
                addressValue.Column = tileView1.Columns["Address"];
                addressValue.AnchorElement = addressCaption;
                addressValue.AnchorIndent = 2;
                addressValue.MaxWidth = 100;
                addressValue.Appearance.Normal.FontStyleDelta = FontStyle.Bold;
                //
                yearBuiltCaption.Name = "YearCaption";
                yearBuiltCaption.Text = "YEAR BUILT";
                yearBuiltCaption.AnchorElement = addressValue;
                yearBuiltCaption.AnchorIndent = 14;
                yearBuiltCaption.Appearance.Normal.FontSizeDelta = -1;
                //
                yearBuiltValue.Column = tileView1.Columns["YearBuilt"];
                yearBuiltValue.AnchorElement = yearBuiltCaption;
                yearBuiltValue.AnchorIndent = 2;
                yearBuiltValue.Appearance.Normal.FontStyleDelta = FontStyle.Bold;
                //
                price.Name = "Price";
                price.Column = tileView1.Columns["PriceShort"];
                price.TextAlignment = TileItemContentAlignment.BottomLeft;
                price.TextLocation = new Point(10, -10);
                price.Appearance.Normal.Font = new Font("Segoe UI Semilight", 25.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //
                image.Column = tileView1.Columns["Image"];
                image.ColumnIndex = 1;
                image.ImageSize = new Size(280, 220);
                image.ImageAlignment = TileItemContentAlignment.MiddleRight;
                image.ImageScaleMode = TileItemImageScaleMode.ZoomOutside;
                image.ImageLocation = new Point(10, 0);
            }
            finally {
                tileView1.EndUpdate();
            }
        }

        protected virtual void InitData() {
            try {
                var homesTable = VideoCatalogDataSet().Tables["Homes"];
                homesTable.Columns.Add("Image", typeof(Image));
                homesTable.Columns.Add("PriceShort", typeof(String));
                foreach(DataRow row in homesTable.Rows) {
                    var img = DevExpress.XtraEditors.Controls.ByteImageConverter.FromByteArray(row["Photo"] as byte[]);
                    row["Image"] = new Bitmap(img, new Size(351, 234));
                    Decimal price = (Decimal)row["Price"];
                    row["PriceShort"] = String.Format("${0}M", (price / 1000000).ToString("0.0"));
                }
                gridControl1.DataSource = homesTable;
            }
            catch { }
        }
        DataSet VideoCatalogDataSet() {
            DataSet ds = new DataSet();
            string DBFileName = DevAVDataDirectoryHelper.GetFile("Homes.xml");
            if(DBFileName != string.Empty) {
                SetWaitDialogCaption(Properties.Resources.LoadingTables);
                ds.ReadXml(DBFileName);
            }
            return ds;
        }

        Color colorPanelReady = Color.FromArgb(58, 166, 101);
        Color colorPanelSold = Color.FromArgb(158, 158, 158);
        Color colorCaptionReady = Color.FromArgb(193, 222, 204);
        Color colorCaptionSold = Color.FromArgb(219, 219, 219);


        void tileView1_ItemCustomize(object sender, TileViewItemCustomizeEventArgs e) {
            if(e.Item == null || e.Item.Elements.Count == 0)
                return;
            bool sold = (int)tileView1.GetRowCellValue(e.RowHandle, tileView1.Columns["Status"]) == 1;

            var addressCaption = e.Item.GetElementByName("AddressCaption");
            var yearCaption = e.Item.GetElementByName("YearCaption");
            var price = e.Item.GetElementByName("Price");

            e.Item.AppearanceItem.Normal.BackColor = sold ? colorPanelSold : colorPanelReady;
            addressCaption.Appearance.Normal.ForeColor = sold ? colorCaptionSold : colorCaptionReady;
            yearCaption.Appearance.Normal.ForeColor = sold ? colorCaptionSold : colorCaptionReady;
            if(sold) price.Text = "Sold";
        }
    }
}
