using System.Collections.Generic;
using System.Drawing;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class DrillDownDemo : ChartDemoModule {
        readonly List<string> categories;
        readonly Font linkFont;
        readonly Font regularFont;

        internal override ChartControl ChartControl { get { return chart; } }

        public DrillDownDemo() {
            InitializeComponent();
            Dictionary<string, List<string>>.KeyCollection keys = SaleItem.CategorizedProducts.Keys;
            categories = new List<string>(keys.Count);
            foreach(string category in SaleItem.CategorizedProducts.Keys)
                categories.Add(category);
            chart.SeriesTemplate.SeriesDataMember = "Category";
            chart.SeriesTemplate.ArgumentDataMember = "Company";
            chart.SeriesTemplate.QualitativeSummaryOptions.SummaryFunction = "SUM([Income])";
            chart.SeriesTemplate.ChangeView(ViewType.StackedBar);
            chart.SeriesTemplate.ToolTipPointPattern = "{S}: ${V:N2}";
            SeriesTemplate seriesPointLevel1Template = CreateTemplate("Product", "OrderDate", ViewType.StackedSplineArea, false);
            SeriesTemplate seriesPointLevel2Template = CreateTemplate("Product", "OrderDate", ViewType.SplineArea, true);
            seriesPointLevel1Template.SeriesDrillTemplate = seriesPointLevel2Template;
            chart.SeriesTemplate.SeriesPointDrillTemplate = seriesPointLevel1Template;
            SeriesTemplate argumentLevel1Template = CreateTemplate("Category", "OrderDate", ViewType.StackedSplineArea, false);
            SeriesTemplate argumentLevel2Template = CreateTemplate("Product", "OrderDate", ViewType.StackedSplineArea, false);
            SeriesTemplate argumentLevel3Template = CreateTemplate("Product", "OrderDate", ViewType.SplineArea, true);
            argumentLevel2Template.SeriesDrillTemplate = argumentLevel3Template;
            argumentLevel1Template.SeriesDrillTemplate = argumentLevel2Template;
            chart.SeriesTemplate.ArgumentDrillTemplate = argumentLevel1Template;
            SeriesTemplate seriesLevel1Template = CreateTemplate("Product", "Company", ViewType.StackedBar, false, true);
            SeriesTemplate seriesLevel2Template = CreateTemplate("Product", "OrderDate", ViewType.StackedSplineArea, false);
            seriesLevel2Template.SeriesDrillTemplate = CreateTemplate("Product", "OrderDate", ViewType.SplineArea, true);
            SeriesTemplate seriesLevel3Template = CreateTemplate("Company", "OrderDate", ViewType.StackedSplineArea, false);
            seriesLevel3Template.SeriesDrillTemplate = CreateTemplate("Product", "OrderDate", ViewType.SplineArea, true);
            SeriesTemplate seriesLevel4Template = CreateTemplate("Product", "OrderDate", ViewType.SplineArea, false);
            seriesLevel1Template.ArgumentDrillTemplate = seriesLevel2Template;
            seriesLevel1Template.SeriesDrillTemplate = seriesLevel3Template;
            seriesLevel1Template.SeriesPointDrillTemplate = seriesLevel4Template;
            chart.SeriesTemplate.SeriesDrillTemplate = seriesLevel1Template;
            chart.DataSource = SaleItem.GetTotalIncome();
            XYDiagram diagram = chart.Diagram as XYDiagram;
            if(diagram != null) {
                regularFont = diagram.AxisX.Label.Font;
                linkFont = new Font(regularFont, FontStyle.Underline);
                diagram.AxisX.Label.Font = linkFont;

                diagram.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Automatic;
                diagram.AxisX.DateTimeScaleOptions.AggregateFunction = AggregateFunction.Sum;
            }
        }
        SeriesTemplate CreateTemplate(string seriesDataMember, string argumentDataMember, ViewType viewType, bool crosshairByArgument, bool useSummary = false) {
            SeriesTemplate template = new SeriesTemplate();
            template.ChangeView(viewType);
            AreaSeriesViewBase view = template.View as AreaSeriesViewBase;
            if(view != null)
                view.Transparency = 100;
            template.SeriesDataMember = seriesDataMember;
            template.ArgumentDataMember = argumentDataMember;
            if(useSummary)
                template.QualitativeSummaryOptions.SummaryFunction = "SUM([Income])";
            else
                template.ValueDataMembers[0] = "Income";
            template.CrosshairLabelPattern = crosshairByArgument ? "{A:d}: ${V:N2}" : "{S}: ${V:N2}";
            return template;
        }
        void chart_DrillDownStateChanged(object sender, DrillDownStateChangedEventArgs e) {
            XYDiagram diagram = chart.Diagram as XYDiagram;
            if(diagram != null && e.Series.Length > 0) {
                if(e.Series[0].View is StackedBarSeriesView) {
                    chart.CrosshairEnabled = DefaultBoolean.False;
                    chart.ToolTipEnabled = DefaultBoolean.True;
                    diagram.Rotated = true;
                    diagram.AxisX.Label.Font = linkFont;
                    diagram.EnableAxisXScrolling = false;
                    diagram.EnableAxisXZooming = false;
                }
                else {
                    chart.CrosshairEnabled = DefaultBoolean.True;
                    chart.ToolTipEnabled = DefaultBoolean.False;
                    diagram.Rotated = false;
                    diagram.AxisX.Label.Font = regularFont;
                    diagram.EnableAxisXScrolling = true;
                    diagram.EnableAxisXZooming = true;
                }
            }
            foreach(DrillDownItem item in e.States) {
                object category = null;
                if(item.Parameters.TryGetValue("Category", out category)) {
                    chart.PaletteBaseColorNumber = categories.IndexOf(category.ToString()) + 1;
                    return;
                }
            }
            chart.PaletteBaseColorNumber = 0;
        }
    }
}
