using System;
using System.Collections.Generic;

namespace DevExpress.XtraCharts.Demos {
    static class SeriesGenerator {
        static List<Series> GenerateSeries(int count, ViewType viewType) {
            List<Series> seriesList = new List<Series>();
            for(int i = 0; i < count; i++) {
                Series series = new Series(string.Format("Series {0}", i + 1), viewType);
                seriesList.Add(series);
            }
            return seriesList;
        }
        static void SetUpXySeriesData(List<Series> result, int pointsCount, bool negativeValues = false) {
            for(int i = 0; i < result.Count; i++) {
                DataGenerator generator = new DataGenerator(i, 5 + 3 * i);
                result[i].DataSource = generator.GenerateData(SeriesDataType.ArgumentValue, pointsCount, negativeValues);
                result[i].ArgumentDataMember = "Argument";
                result[i].ValueDataMembers.AddRange("Value");
            }
        }
        static void SetUpXyScatterSeriesData(List<Series> result) {
            for(int i = 0; i < result.Count; i++) {
                DataGenerator generator = new DataGenerator();
                result[i].DataSource = generator.GenerateXyScatterData();
                result[i].ArgumentDataMember = "Argument";
                result[i].ValueDataMembers.AddRange("Value");
            }
        }
        static void SetUpPolarScatterSeriesData(List<Series> result) {
            for(int i = 0; i < result.Count; i++) {
                DegreeScatterFunctionCalculator functionCalculator = new DegreeScatterFunctionCalculator();
                SeriesPoint[] points = functionCalculator.GenerateScatterFunctionPoints(1);
                result[i].Points.AddRange(points);
            }
        }
        static void SetUpRadarScatterSeriesData(List<Series> result) {
            for(int i = 0; i < result.Count; i++) {
                DegreeScatterFunctionCalculator functionCalculator = new DegreeScatterFunctionCalculator();
                SeriesPoint[] points = functionCalculator.GenerateScatterFunctionPoints(0);
                result[i].Points.AddRange(points);
            }
        }
        static void SetUpRangeSeriesData(List<Series> result, int pointsCount) {
            for(int i = 0; i < result.Count; i++) {
                DataGenerator generator = new DataGenerator(i, 25);
                result[i].DataSource = generator.GenerateData(SeriesDataType.Range, pointsCount);
                result[i].ArgumentDataMember = "Argument";
                result[i].ValueDataMembers.AddRange("Value", "Value2");
            }
        }
        static void SetUpPolarSeriesData(List<Series> result, int pointsCount) {
            for(int i = 0; i < result.Count; i++) {
                DataGenerator generator = new DataGenerator(i);
                result[i].DataSource = generator.GeneratePolarData(SeriesDataType.ArgumentValue, pointsCount);
                result[i].ArgumentDataMember = "Argument";
                result[i].ValueDataMembers.AddRange("Value");
            }
        }
        static void SetUpPolarRangeSeriesData(List<Series> result, int pointsCount) {
            for(int i = 0; i < result.Count; i++) {
                DataGenerator generator = new DataGenerator(i);
                result[i].DataSource = generator.GeneratePolarData(SeriesDataType.Range, pointsCount);
                result[i].ArgumentDataMember = "Argument";
                result[i].ValueDataMembers.AddRange("Value", "Value2");
            }
        }
        static void SetUpFunnelSeriesData(List<Series> result, int pointsCount) {
            for(int i = 0; i < result.Count; i++) {
                DataGenerator generator = new DataGenerator(i, 35);
                result[i].DataSource = generator.GenerateData(SeriesDataType.Funnel, pointsCount);
                result[i].ArgumentDataMember = "Argument";
                result[i].ValueDataMembers.AddRange("Value");
            }
        }
        static void SetUpBubbleSeriesData(List<Series> result, int pointsCount) {
            for(int i = 0; i < result.Count; i++) {
                DataGenerator generator = new DataGenerator(i, 5 + 3 * i);
                result[i].DataSource = generator.GenerateData(SeriesDataType.Bubble, pointsCount);
                result[i].ArgumentDataMember = "Argument";
                result[i].ValueDataMembers.AddRange("Value", "Weight");
            }
        }
        static void SetUpFinancialSeriesData(List<Series> result, int pointsCount) {
            for(int i = 0; i < result.Count; i++) {
                DataGenerator generator = new DataGenerator(i, 60);
                result[i].DataSource = generator.GenerateData(SeriesDataType.Financial, pointsCount);
                result[i].ArgumentDataMember = "Argument";
                result[i].ValueDataMembers.AddRange("Low", "High", "Open", "Close");
            }
        }
        static void SetUpBoxPlotSeriesData(List<Series> result, int pointsCount) {
            for(int i = 0; i < result.Count; i++) {
                DataGenerator generator = new DataGenerator(i, 20);
                result[i].DataSource = generator.GenerateData(SeriesDataType.BoxPlot, pointsCount);
                result[i].ArgumentDataMember = "Argument";
                result[i].ValueDataMembers.AddRange("Min", "Quartile1", "Median", "Quartile3", "Max", "Mean", "Outliers");
            }
        }

        static List<Series> CreateOverlappedGanttSeries(ViewType overlappedOrSbSGantt) {
            Series series1 = new Series("Planned", overlappedOrSbSGantt);
            Series series2 = new Series("Completed", overlappedOrSbSGantt);
            series1.ValueScaleType = ScaleType.DateTime;
            series2.ValueScaleType = ScaleType.DateTime;
            series1.Points.Add(new SeriesPoint("Market analysis", new DateTime[] { new DateTime(2006, 8, 16), new DateTime(2006, 8, 23) }));
            series1.Points.Add(new SeriesPoint("Feature planning", new DateTime[] { new DateTime(2006, 8, 23), new DateTime(2006, 8, 26) }));
            series1.Points.Add(new SeriesPoint("Implementation", new DateTime[] { new DateTime(2006, 8, 26), new DateTime(2006, 9, 26) }));
            series1.Points.Add(new SeriesPoint("Testing & bug fixing", new DateTime[] { new DateTime(2006, 9, 26), new DateTime(2006, 10, 10) }));
            series2.Points.Add(new SeriesPoint("Market analysis", new DateTime[] { new DateTime(2006, 8, 16), new DateTime(2006, 8, 23) }));
            series2.Points.Add(new SeriesPoint("Feature planning", new DateTime[] { new DateTime(2006, 8, 23), new DateTime(2006, 8, 26) }));
            series2.Points.Add(new SeriesPoint("Implementation", new DateTime[] { new DateTime(2006, 8, 26), new DateTime(2006, 9, 10) }));
            List<Series> result = new List<Series>();
            result.Add(series1);
            result.Add(series2);
            ((GanttSeriesView)series1.View).BarWidth = 0.6;
            ((GanttSeriesView)series2.View).BarWidth = 0.3;
            ((GanttSeriesView)series1.View).LinkOptions.ArrowHeight = 7;
            ((GanttSeriesView)series1.View).LinkOptions.ArrowWidth = 11;
            for(int i = 1; i < series1.Points.Count; i++) {
                series1.Points[i].Relations.Add(series1.Points[i - 1]);
            }
            return result;
        }

        internal static Series[] GenerateSeries(ViewType viewType) {
            List<Series> result = null;
            switch(viewType) {
                case ViewType.Area:
                    result = GenerateSeries(2, viewType);
                    SetUpXySeriesData(result, 15);
                    break;
                case ViewType.Bar:
                    result = GenerateSeries(2, viewType);
                    SetUpXySeriesData(result, 7);
                    break;
                case ViewType.Bubble:
                    result = GenerateSeries(1, viewType);
                    SetUpBubbleSeriesData(result, 10);
                    break;
                case ViewType.CandleStick:
                    result = GenerateSeries(1, viewType);
                    SetUpFinancialSeriesData(result, 80);
                    break;
                case ViewType.Doughnut:
                    result = GenerateSeries(1, viewType);
                    SetUpXySeriesData(result, 7);
                    break;
                case ViewType.FullStackedArea:
                    result = GenerateSeries(3, viewType);
                    SetUpXySeriesData(result, 15);
                    break;
                case ViewType.FullStackedStepArea:
                    result = GenerateSeries(3, viewType);
                    SetUpXySeriesData(result, 15);
                    break;
                case ViewType.FullStackedBar:
                    result = GenerateSeries(3, viewType);
                    SetUpXySeriesData(result, 7);
                    break;
                case ViewType.FullStackedLine:
                    result = GenerateSeries(3, viewType);
                    SetUpXySeriesData(result, 15);
                    break;
                case ViewType.FullStackedSplineArea:
                    result = GenerateSeries(3, viewType);
                    SetUpXySeriesData(result, 15);
                    break;
                case ViewType.Funnel:
                    result = GenerateSeries(1, viewType);
                    SetUpFunnelSeriesData(result, 7);
                    break;
                case ViewType.Gantt:
                    result = CreateOverlappedGanttSeries(ViewType.Gantt);
                    break;
                case ViewType.Line:
                    result = GenerateSeries(2, viewType);
                    SetUpXySeriesData(result, 15);
                    break;
                case ViewType.NestedDoughnut:
                    result = GenerateSeries(2, viewType);
                    SetUpXySeriesData(result, 7);
                    break;
                case ViewType.Pie:
                    result = GenerateSeries(1, viewType);
                    SetUpXySeriesData(result, 7);
                    break;
                case ViewType.Point:
                    result = GenerateSeries(1, viewType);
                    SetUpXySeriesData(result, 30);
                    break;
                case ViewType.PolarArea:
                    result = GenerateSeries(2, viewType);
                    SetUpPolarSeriesData(result, 7);
                    break;
                case ViewType.PolarLine:
                    result = GenerateSeries(2, viewType);
                    SetUpPolarSeriesData(result, 7);
                    break;
                case ViewType.PolarPoint:
                    result = GenerateSeries(1, viewType);
                    SetUpPolarSeriesData(result, 20);
                    break;
                case ViewType.PolarRangeArea:
                    result = GenerateSeries(1, viewType);
                    SetUpPolarRangeSeriesData(result, 20);
                    break;
                case ViewType.RadarArea:
                    result = GenerateSeries(2, viewType);
                    SetUpPolarSeriesData(result, 7);
                    break;
                case ViewType.RadarLine:
                    result = GenerateSeries(2, viewType);
                    SetUpPolarSeriesData(result, 7);
                    break;
                case ViewType.RadarPoint:
                    result = GenerateSeries(1, viewType);
                    SetUpPolarSeriesData(result, 20);
                    break;
                case ViewType.RadarRangeArea:
                    result = GenerateSeries(1, viewType);
                    SetUpPolarRangeSeriesData(result, 20);
                    break;
                case ViewType.RangeArea:
                    result = GenerateSeries(1, viewType);
                    SetUpRangeSeriesData(result, 20);
                    break;
                case ViewType.RangeBar:
                    result = GenerateSeries(1, viewType);
                    SetUpRangeSeriesData(result, 15);
                    break;
                case ViewType.ScatterLine:
                    result = GenerateSeries(1, viewType);
                    SetUpXyScatterSeriesData(result);
                    break;
                case ViewType.ScatterPolarLine:
                    result = GenerateSeries(1, viewType);
                    SetUpPolarScatterSeriesData(result);
                    break;
                case ViewType.ScatterRadarLine:
                    result = GenerateSeries(1, viewType);
                    SetUpRadarScatterSeriesData(result);
                    break;
                case ViewType.SideBySideFullStackedBar:
                    result = GenerateSeries(6, viewType);
                    SetUpXySeriesData(result, 7);
                    for(int i = 0; i < 3; i++) {
                        ((SideBySideFullStackedBarSeriesView)result[i].View).StackedGroup = "Group 1";
                    }
                    for(int i = 2; i < 6; i++) {
                        ((SideBySideFullStackedBarSeriesView)result[i].View).StackedGroup = "Group 2";
                    }
                    break;
                case ViewType.SideBySideGantt:
                    result = CreateOverlappedGanttSeries(ViewType.SideBySideGantt);
                    break;
                case ViewType.SideBySideRangeBar:
                    result = GenerateSeries(2, viewType);
                    SetUpRangeSeriesData(result, 15);
                    break;
                case ViewType.SideBySideStackedBar:
                    result = GenerateSeries(5, viewType);
                    SetUpRangeSeriesData(result, 15);
                    for(int i = 0; i < 3; i++) {
                        ((SideBySideStackedBarSeriesView)result[i].View).StackedGroup = "Group 1";
                    }
                    for(int i = 2; i < 5; i++) {
                        ((SideBySideStackedBarSeriesView)result[i].View).StackedGroup = "Group 2";
                    }
                    break;
                case ViewType.Spline:
                    result = GenerateSeries(2, viewType);
                    SetUpXySeriesData(result, 15);
                    break;
                case ViewType.SplineArea:
                    result = GenerateSeries(2, viewType);
                    SetUpXySeriesData(result, 15);
                    break;
                case ViewType.StackedArea:
                    result = GenerateSeries(2, viewType);
                    SetUpXySeriesData(result, 15);
                    break;
                case ViewType.StackedStepArea:
                    result = GenerateSeries(2, viewType);
                    SetUpXySeriesData(result, 15);
                    break;
                case ViewType.StackedBar:
                    result = GenerateSeries(2, viewType);
                    SetUpXySeriesData(result, 15);
                    break;
                case ViewType.Waterfall:
                    result = GenerateSeries(3, viewType);
                    SetUpXySeriesData(result, 15, true);
                    break;
                case ViewType.StackedLine:
                    result = GenerateSeries(2, viewType);
                    SetUpXySeriesData(result, 15);
                    break;
                case ViewType.StackedSplineArea:
                    result = GenerateSeries(2, viewType);
                    SetUpXySeriesData(result, 15);
                    break;
                case ViewType.StepArea:
                    result = GenerateSeries(2, viewType);
                    SetUpXySeriesData(result, 15);
                    break;
                case ViewType.StepLine:
                    result = GenerateSeries(2, viewType);
                    SetUpXySeriesData(result, 15);
                    break;
                case ViewType.Stock:
                    result = GenerateSeries(1, viewType);
                    SetUpFinancialSeriesData(result, 80);
                    break;
                case ViewType.BoxPlot:
                    result = GenerateSeries(1, viewType);
                    SetUpBoxPlotSeriesData(result, 10);
                    foreach(Series series in result)
                        ((BoxPlotSeriesView)series.View).MeanLineVisible = true;
                    break;
                case ViewType.SwiftPlot:
                    break;
            }
            return result == null ? null : result.ToArray();
        }
    }

    class ComboBoxSeriesViewItem {
        readonly ViewType viewType;
        readonly string viewName;

        public ViewType ViewType { get { return viewType; } }

        internal ComboBoxSeriesViewItem(ViewType viewType) : this(viewType, string.Empty) {
        }
        internal ComboBoxSeriesViewItem(ViewType viewType, string viewName) {
            this.viewType = viewType;
            this.viewName = viewName;
        }
        public override string ToString() {
            return viewName;
        }
        public override bool Equals(object obj) {
            ComboBoxSeriesViewItem item = obj as ComboBoxSeriesViewItem;
            return item != null && item.viewType.Equals(viewType);
        }
        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }

    static class ViewTypesItemsGenerator {
        internal static List<ViewType> CreateViewTypes() {
            return new List<ViewType>() {
                ViewType.Bar,
                ViewType.StackedBar,
                ViewType.Waterfall,
                ViewType.FullStackedBar,
                ViewType.SideBySideStackedBar,
                ViewType.SideBySideFullStackedBar,
                ViewType.Point,
                ViewType.Bubble,
                ViewType.Line,
                ViewType.StackedLine,
                ViewType.FullStackedLine,
                ViewType.StepLine,
                ViewType.Spline,
                ViewType.ScatterLine,
                ViewType.Area,
                ViewType.StackedArea,
                ViewType.FullStackedArea,
                ViewType.StackedStepArea,
                ViewType.FullStackedStepArea,
                ViewType.StepArea,
                ViewType.SplineArea,
                ViewType.StackedSplineArea,
                ViewType.FullStackedSplineArea,
                ViewType.RangeBar,
                ViewType.SideBySideRangeBar,
                ViewType.RangeArea,
                ViewType.Pie,
                ViewType.Doughnut,
                ViewType.NestedDoughnut,
                ViewType.Funnel,
                ViewType.RadarPoint,
                ViewType.RadarLine,
                ViewType.ScatterRadarLine,
                ViewType.RadarArea,
                ViewType.RadarRangeArea,
                ViewType.PolarPoint,
                ViewType.PolarLine,
                ViewType.ScatterPolarLine,
                ViewType.PolarArea,
                ViewType.PolarRangeArea,
                ViewType.Stock,
                ViewType.CandleStick,
                ViewType.Gantt,
                ViewType.SideBySideGantt,
                ViewType.BoxPlot,
            };
        }
        internal static List<ComboBoxSeriesViewItem> CreateItems() {
            List<ViewType> viewTypes = CreateViewTypes();
            List<ComboBoxSeriesViewItem> viewItems = new List<ComboBoxSeriesViewItem>();
            foreach(ViewType viewType in viewTypes) {
                viewItems.Add(new ComboBoxSeriesViewItem(viewType, DevExpress.XtraCharts.Native.SeriesViewFactory.GetStringID(viewType)));
            }
            return viewItems;
        }
    }
}
