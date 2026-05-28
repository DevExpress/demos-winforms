using System;
using System.Collections.Generic;

namespace DevExpress.XtraCharts.Demos {
    public partial class QualitativeDataAggregationDemo : ChartDemoModuleWithOptions {
        QualitativeScaleOptions QualitativeScaleOption {
            get {
                XYDiagram diagram = chart.Diagram as XYDiagram;
                if(diagram != null)
                    return diagram.AxisX.QualitativeScaleOptions;
                return null;
            }
        }
        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public QualitativeDataAggregationDemo() {
            InitializeComponent();
            List<SaleItem> items = SaleItem.GetProductsIncome();
            ChartControl.BeginInit();
            chart.Series[0].DataSource = items;
            gridControl1.DataSource = items;
            ChartControl.EndInit();
            radioGroupAggregationFunction.SelectedIndex = 4;
        }

        void radioGroupAggregationFunction_SelectedIndexChanged(object sender, EventArgs e) {
            if(QualitativeScaleOption == null)
                return;
            int functionIndex = radioGroupAggregationFunction.SelectedIndex;
            QualitativeScaleOption.AggregateFunction = (AggregateFunction)functionIndex;
            switch(functionIndex) {
                case 0:
                    SetTitles("Sales Volume", "Volume (USD)");
                    break;
                case 1:
                    SetTitles("Average Order Amount", "Volume (USD)");
                    break;
                case 2:
                    SetTitles("Minimal Order Amount", "Volume (USD)");
                    break;
                case 3:
                    SetTitles("Maximal Order Amount", "Volume (USD)");
                    break;
                case 4:
                    SetTitles("Sales Volume", "Volume (USD)");
                    break;
                case 5:
                    SetTitles("Overall Orders Count", "Count");
                    break;
            }
            ChartControl.Animate();
        }
        void SetTitles(string axisTitle, string chartTitle) {
            ((XYDiagram)chart.Diagram).AxisY.Title.Text = axisTitle;
            if(chart.Titles.Count > 0)
                chart.Titles[0].Text = chartTitle;
        }
    }
}
