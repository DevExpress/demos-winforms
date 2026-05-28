using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Internal;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;

namespace DevExpress.XtraNavBar.Demos {
    public partial class AccordionControlBusinessModule : TutorialControl {
        public AccordionControlBusinessModule() {
            InitializeComponent();
            InitVehiclesData();
            InitGrid();
            InitAccordion();
            LicenseInfo.SetToolTipController(this, gridControl1);
        }
        List<VehiclesData.Model> models;
        protected virtual void InitVehiclesData() {
            string DBFileName = string.Empty;
            DBFileName = DataDirectoryHelper.GetDataFile("Vehicles.xml");
            if(DBFileName != string.Empty)
                InitXMLData(DBFileName);
        }
        protected void InitXMLData(string fileName) {
            models = VehiclesData.InitXMLDataCore(fileName);
            gridControl1.DataSource = models;
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
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "TransmissionTypeName" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "BodyStyleName" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "Price" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "Doors" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "MPGCity" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "MPGHighway" });

            RepositoryItemTextEdit item = new RepositoryItemTextEdit();
            this.winExplorerView1.Columns["Name"].ColumnEdit = item;
            this.gridControl1.RepositoryItems.Add(item);

            this.winExplorerView1.ColumnSet.TextColumn = this.winExplorerView1.Columns["Name"];
            this.winExplorerView1.ColumnSet.DescriptionColumn = this.winExplorerView1.Columns["Price"];
            this.winExplorerView1.Columns["Price"].DisplayFormat.FormatType = Utils.FormatType.Numeric;
            this.winExplorerView1.Columns["Price"].DisplayFormat.FormatString = "c";
            this.winExplorerView1.ColumnSet.ExtraLargeImageColumn = this.winExplorerView1.Columns["Photo"];
            this.winExplorerView1.ColumnSet.MediumImageColumn = this.winExplorerView1.Columns["Photo"];
            this.winExplorerView1.ColumnSet.CheckBoxColumn = this.winExplorerView1.Columns["InStock"];
        }
        void InitAccordion() {
            InitMain();
            InitBody();
            InitEngine();
        }
        void InitEngine() {
            InitMPGCity();
            InitMPGHighway();
        }
        void InitMPGHighway() {
            rtbMPGHighway.Properties.Minimum = Convert.ToInt32(FindMinMax(true, "MPGHighway"));
            rtbMPGHighway.Properties.Maximum = Convert.ToInt32(FindMinMax(false, "MPGHighway"));

            int c = ((rtbMPGHighway.Properties.Maximum - rtbMPGHighway.Properties.Minimum) / rtbMPGHighway.Properties.TickFrequency) * rtbMPGHighway.Properties.TickFrequency + rtbMPGHighway.Properties.Minimum;
            rtbMPGHighway.Properties.Labels[0].Value = rtbMPGHighway.Properties.Minimum;
            rtbMPGHighway.Properties.Labels[1].Value = c;

            rtbMPGHighway.Properties.Labels[1].Label = rtbMPGHighway.Properties.Maximum.ToString();
            rtbMPGHighway.Properties.Labels[0].Label = rtbMPGHighway.Properties.Minimum.ToString();
        }
        void InitMPGCity() {
            rtbMPGCity.Properties.Minimum = Convert.ToInt32(FindMinMax(true, "MPGCity"));
            rtbMPGCity.Properties.Maximum = Convert.ToInt32(FindMinMax(false, "MPGCity"));

            int c = ((rtbMPGCity.Properties.Maximum - rtbMPGCity.Properties.Minimum) / rtbMPGCity.Properties.TickFrequency) * rtbMPGCity.Properties.TickFrequency + rtbMPGCity.Properties.Minimum;
            rtbMPGCity.Properties.Labels[0].Value = rtbMPGCity.Properties.Minimum;
            rtbMPGCity.Properties.Labels[1].Value = c;

            rtbMPGCity.Properties.Labels[1].Label = rtbMPGCity.Properties.Maximum.ToString();
            rtbMPGCity.Properties.Labels[0].Label = rtbMPGCity.Properties.Minimum.ToString();
        }
        void InitBody() {
            InitBodyStyle();
            InitDoorsCount();
        }
        void InitDoorsCount() {
            rgDoorsCount.Properties.Items.Add(new RadioGroupItem("2", "2"));
            rgDoorsCount.Properties.Items.Add(new RadioGroupItem("3", "3"));
            rgDoorsCount.Properties.Items.Add(new RadioGroupItem("4", "4"));
            rgDoorsCount.Properties.Items.Add(new RadioGroupItem("All", "All"));
            rgDoorsCount.SelectedIndex = 3;
        }
        void InitBodyStyle() {
            List<string> bodyStyles = GetListFromDB("BodyStyleName");
            foreach(string str in bodyStyles)
                clbBodyStyle.Items.Add(str);
        }
        void InitMain() {
            InitPrice();
            InitTrademarks();
            InitTransmissionType();
        }
        void InitTransmissionType() {
            List<string> transmissions = GetListFromDB("TransmissionTypeName");
            foreach(string str in transmissions)
                rgTransmissionType.Properties.Items.Add(new RadioGroupItem(str, str));
            rgTransmissionType.Properties.Items.Add(new RadioGroupItem("All", "All"));
            rgTransmissionType.SelectedIndex = 2;
        }
        void InitPrice() {
            rTBPrice.Properties.Minimum = Convert.ToInt32(FindMinMax(true, "Price"));
            rTBPrice.Properties.Maximum = Convert.ToInt32(FindMinMax(false, "Price"));

            int c = ((rTBPrice.Properties.Maximum - rTBPrice.Properties.Minimum) / rTBPrice.Properties.TickFrequency) * rTBPrice.Properties.TickFrequency + rTBPrice.Properties.Minimum;
            rTBPrice.Properties.Labels[1].Value = rTBPrice.Properties.Minimum;
            rTBPrice.Properties.Labels[0].Value = c;

            rTBPrice.Properties.Labels[0].Label = string.Format("{0:N0}", rTBPrice.Properties.Maximum);
            rTBPrice.Properties.Labels[1].Label = string.Format("{0:N0}", rTBPrice.Properties.Minimum);
        }
        void InitTrademarks() {
            List<string> trademarks = GetListFromDB("TrademarkName");
            foreach(string str in trademarks)
                chLBMark.Items.Add(str);
        }
        object GetValueByName(VehiclesData.Model model, string name) {
            if(name == "MPGCity") return model.MPGCity;
            if(name == "MPGHighway") return model.MPGHighway;
            if(name == "Price") return model.Price;
            if(name == "TransmissionTypeName") return model.TransmissionTypeName;
            if(name == "BodyStyleName") return model.BodyStyleName;
            return model.TrademarkName;
        }
        int FindMinMax(bool isMin, string column) {
            int min = 0, max = 0;
            foreach(VehiclesData.Model model in models) {
                object value = GetValueByName(model, column);
                if(value == null)
                    continue;
                int cur;
                if(Int32.TryParse(value.ToString(), out cur)) {
                    min = (min == 0) ? cur : Math.Min(min, cur);
                    max = Math.Max(max, cur);
                }
            }
            if(isMin) return min;
            return max;
        }
        List<string> GetListFromDB(string column) {
            List<string> list = new List<string>();
            foreach(VehiclesData.Model model in models) {
                string str = GetValueByName(model, column).ToString();
                if(!list.Contains(str)) list.Add(str);
            }
            list.Sort();
            return list;
        }
        void rTBPrice_EditValueChanged(object sender, EventArgs e) {
            if(winExplorerView1.Columns["Price"] == null) return;
            string str = "[Price] >= " + rTBPrice.Value.Minimum.ToString() + " AND [Price] <= " + rTBPrice.Value.Maximum.ToString();
            winExplorerView1.Columns["Price"].FilterInfo = new ColumnFilterInfo(str);
        }
        string GetFilterString(string column, CheckedListBoxItemCollection checkedListBoxItemCollection) {
            string str = string.Empty;
            foreach(CheckedListBoxItem item in checkedListBoxItemCollection) {
                if(item.CheckState != CheckState.Checked)
                    continue;
                if(str != string.Empty) str = str + "OR";
                str = str + "[" + column + "] = '" + item.Value.ToString() + "' ";
            }
            return str;
        }
        void rgTransmissionType_SelectedIndexChanged(object sender, EventArgs e) {
            if(rgTransmissionType.SelectedIndex == 2) {
                winExplorerView1.Columns["TransmissionTypeName"].FilterInfo = ColumnFilterInfo.Empty;
                return;
            }
            string str = rgTransmissionType.Properties.Items[rgTransmissionType.SelectedIndex].Value.ToString();
            str = "[TransmissionTypeName] = '" + str + "'";
            winExplorerView1.Columns["TransmissionTypeName"].FilterInfo = new ColumnFilterInfo(str);
        }
        void rgDoorsCount_SelectedIndexChanged(object sender, EventArgs e) {
            if(rgDoorsCount.SelectedIndex == 3) {
                winExplorerView1.Columns["Doors"].FilterInfo = ColumnFilterInfo.Empty;
                return;
            }
            string str = rgDoorsCount.Properties.Items[rgDoorsCount.SelectedIndex].Value.ToString();
            str = "[Doors] = '" + str + "'";
            winExplorerView1.Columns["Doors"].FilterInfo = new ColumnFilterInfo(str);
        }
        void chLBMark_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e) {
            string str = GetFilterString("TrademarkName", chLBMark.Items);
            winExplorerView1.Columns["TrademarkName"].FilterInfo = new ColumnFilterInfo(str);
        }
        void clbBodyStyle_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e) {
            string str = GetFilterString("BodyStyleName", clbBodyStyle.Items);
            winExplorerView1.Columns["BodyStyleName"].FilterInfo = new ColumnFilterInfo(str);
        }
        void rtbMPGCity_EditValueChanged(object sender, EventArgs e) {
            if(winExplorerView1.Columns["MPGCity"] == null) return;
            string str = "[MPGCity] >= " + rtbMPGCity.Value.Minimum.ToString() + " AND [MPGCity] <= " + rtbMPGCity.Value.Maximum.ToString();
            winExplorerView1.Columns["MPGCity"].FilterInfo = new ColumnFilterInfo(str);
        }
        void rtbMPGHighway_EditValueChanged(object sender, EventArgs e) {
            if(winExplorerView1.Columns["MPGHighway"] == null) return;
            string str = "[MPGHighway] >= " + rtbMPGHighway.Value.Minimum.ToString() + " AND [MPGHighway] <= " + rtbMPGHighway.Value.Maximum.ToString();
            winExplorerView1.Columns["MPGHighway"].FilterInfo = new ColumnFilterInfo(str);
        }
        void rTBPrice_BeforeShowValueToolTip(object sender, XtraEditors.TrackBarValueToolTipEventArgs e) {
            e.ShowArgs.ToolTip = string.Format("{0:C} - {1:C}", rTBPrice.Value.Minimum, rTBPrice.Value.Maximum);
        }
        void rtbMPGCity_BeforeShowValueToolTip(object sender, XtraEditors.TrackBarValueToolTipEventArgs e) {
            e.ShowArgs.ToolTip = string.Format("{0} - {1}", rtbMPGCity.Value.Minimum, rtbMPGCity.Value.Maximum);
        }
        void rtbMPGHighway_BeforeShowValueToolTip(object sender, XtraEditors.TrackBarValueToolTipEventArgs e) {
            e.ShowArgs.ToolTip = string.Format("{0} - {1}", rtbMPGHighway.Value.Minimum, rtbMPGHighway.Value.Maximum);
        }
    }
}
