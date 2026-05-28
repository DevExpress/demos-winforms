using System;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.XtraCharts.Demos {
    public partial class DataGridChartingDemo : ChartDemoModule {
        ChartControl focusedChart;

        internal override ChartControl ChartControl {
            get { return focusedChart; }
        }
        internal override List<ChartControl> ChartControls {
            get {
                return new List<ChartControl>() {
                    chartTotalUnitsSold,
                    chartMonthlyRevenue
                };
            }
        }

        public DataGridChartingDemo() {
            InitializeComponent();
            gridControl.Load += OnGridDataLoad;
            gridControl.DataSource = SalesProductDataGenerator.ExtractData();
            focusedChart = chartTotalUnitsSold;
        }

        void OnGridDataLoad(object sender, EventArgs e) {
            gridView.SelectGroup(gridView.GetVisibleRowHandle(0));
            gridView.SelectGroup(gridView.GetVisibleRowHandle(2));
            gridView.SelectGroup(gridView.GetVisibleRowHandle(5));
            FillColorizerKeys(((SeriesKeyColorColorizer)chartTotalUnitsSold.SeriesTemplate.SeriesColorizer).Keys);
        }
        void FillColorizerKeys(KeyCollection keys) {
            int rHandle = -1;
            while(gridView.IsValidRowHandle(rHandle)) {
                keys.Add(gridView.GetGroupRowValue(rHandle, gridColumn1));
                rHandle--;
            }
        }

        void OnChartControlClick(object sender, EventArgs e) {
            focusedChart = (ChartControl)sender;
        }
    }

    public class SalesGridView : GridView {
        public void SelectGroup(int rowHandle) {
            SelectAllGroupRows(rowHandle);
        }
    }
}
