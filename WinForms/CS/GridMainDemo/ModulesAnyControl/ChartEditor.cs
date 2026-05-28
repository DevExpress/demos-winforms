using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraCharts;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.CustomEditor;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraGrid.Demos {
    public partial class ChartEditor : TutorialControl {
        string queryName = "SalesByCategory";
        DataSet ds = new DataSet();
        private GridControl CurrentGrid { get { return gridControl1; } }
        public ChartEditor() {
            InitializeComponent();
            InitNWindData();
            RepositoryItemPictureEdit photoEditor = new RepositoryItemPictureEdit();
            photoEditor.Caption.Appearance.BackColor = Color.FromArgb(200, Color.White);
            photoEditor.Caption.Appearance.ForeColor = Color.FromArgb(40,40,40);
            photoEditor.Caption.Text = "{FirstName} <b>{LastName}</b>";
            gridControl1.RepositoryItems.Add(photoEditor);
            colPhoto.ColumnEdit = photoEditor;
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "AnyChartEditor" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "ChartEditor"; }
        }
        protected override DataSet InitNWindXMLData(string dataFileName) {
            SetWaitDialogCaption(Properties.Resources.LoadingEmployees);
            ds.ReadXml(dataFileName);
            CurrentGrid.DataSource = ds;
            CurrentGrid.DataMember = "Employees";
            return ds;
        }
        SeriesBase ChartSeries { get { return chartControl1.Series[0]; } }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            InitChartTypeEdit();
            ChartSeries.ArgumentDataMember = "CategoryName";
            ChartSeries.ValueDataMembers.AddRange("Quantity");
            //<gridControl1>
            CreateChartEdit(colChart, chartControl1);
            //</gridControl1>
        }
        //<icbChartType>
        void InitChartTypeEdit() {
            icbChartType.Properties.Items.Add(new RadioGroupItem(typeof(DevExpress.XtraCharts.PieSeriesView), "Pie"));
            icbChartType.Properties.Items.Add(new RadioGroupItem(typeof(DevExpress.XtraCharts.DoughnutSeriesView), "Doughnut"));
            icbChartType.Properties.Items.Add(new RadioGroupItem(typeof(DevExpress.XtraCharts.StackedBarSeriesView), "Bar"));
            icbChartType.Properties.Items.Add(new RadioGroupItem(typeof(DevExpress.XtraCharts.LineSeriesView), "Line"));
            icbChartType.Properties.Items.Add(new RadioGroupItem(typeof(DevExpress.XtraCharts.FunnelSeriesView), "Funnel"));
            icbChartType.Properties.Items.Add(new RadioGroupItem(typeof(DevExpress.XtraCharts.StackedAreaSeriesView), "Area"));
            icbChartType.Properties.Items.Add(new RadioGroupItem(typeof(DevExpress.XtraCharts.StackedSplineAreaSeriesView), "Spline Area"));
            icbChartType.EditValue = ChartSeries.View.GetType();
        }
        //</icbChartType>
        //<gridControl1>
        static void CreateChartEdit(GridColumn column, ChartControl chartControl) {
            if(column.ColumnEdit != null) return;
            RepositoryItemAnyControl item = new RepositoryItemAnyControl();
            item.Control = chartControl;
            column.View.GridControl.RepositoryItems.Add(item);
            ((GridView)column.View).OptionsSelection.EnableAppearanceHideSelection = false;
            column.OptionsColumn.AllowEdit = false;
            column.OptionsFilter.AllowFilter = false;
            column.OptionsColumn.AllowGroup = Utils.DefaultBoolean.False;
            column.OptionsColumn.AllowSort = Utils.DefaultBoolean.False;
            column.ColumnEdit = item;
        }
        
        private void gridView1_CustomUnboundColumnData(object sender, Views.Base.CustomColumnDataEventArgs e) {
            if(e.IsGetData) e.Value = GetChartData(e.Row);
        }
        Dictionary<int, List<EmployeeSalesByCategoryChartData>> chartData = new Dictionary<int, List<EmployeeSalesByCategoryChartData>>();
        object GetChartData(object val) {
            DataRowView row = val as DataRowView;
            if(row == null) return null;
            int key = (int)row["EmployeeID"];
            if(!chartData.ContainsKey(key))
                chartData.Add(key, GetEmployeeSalesByCategoryChartData(key));
            return chartData[key];
        }
        List<EmployeeSalesByCategoryChartData> GetEmployeeSalesByCategoryChartData(int key) {
            List<EmployeeSalesByCategoryChartData> ret = new List<EmployeeSalesByCategoryChartData>();
            foreach(DataRow row in ds.Tables[queryName].Rows) {
                if(key.Equals(row["EmployeeID"]))
                    ret.Add(new EmployeeSalesByCategoryChartData() { CategoryName = row["CategoryName"].ToString(), Quantity = (double)row["SumOfQuantity"] });
            }
            return ret;
        }
        //</gridControl1>
        //<icbChartType>
        private void icbChartType_SelectedIndexChanged(object sender, EventArgs e) {
            Type viewType = icbChartType.EditValue as Type;
            //ChartSeries.View.Dispose();
            ChartSeries.View = Activator.CreateInstance(viewType) as SeriesViewBase;
            RepositoryItemAnyControl edit = colChart.ColumnEdit as RepositoryItemAnyControl;
            if(edit != null) edit.RefreshControl();

            
        }
        //</icbChartType>
        //<gridControl1>
        public class EmployeeSalesByCategoryChartData {
            public string CategoryName { get; set; }
            public double Quantity { get; set; }
        }
        //</gridControl1>
        private void advBandedGridView1_CustomColumnDisplayText(object sender, Views.Base.CustomColumnDisplayTextEventArgs e) {
            if(e.Column == colHireDate || e.Column == colHomePhone)
                e.DisplayText = string.Format("{0}: {1:d}", e.Column.GetCaption(), e.Value);
        }

        private void advBandedGridView1_CustomDrawCell(object sender, Views.Base.RowCellCustomDrawEventArgs e) {
            if(e.Column == colPhoto) {
                var cell = e.Cell as DevExpress.XtraGrid.Views.Grid.ViewInfo.GridCellInfo;
                PictureEditViewInfo pic = cell.ViewInfo as PictureEditViewInfo;
                //if(pic != null) pic.CaptionText = advBandedGridView1.GetRowCellDisplayText(e.RowHandle, colFirstName) + "  " + advBandedGridView1.GetRowCellDisplayText(e.RowHandle, colLastName);
            }
        }
    }
}
