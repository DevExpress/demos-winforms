using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using DevExpress.Data.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class BoxPlotDemo : ChartDemoModuleWithOptions {
        const int InitialResultCount = 25;
        const int MeasurementsCount = 500;
        const int InitialArgumentCount = 7;
        const double SecondPointSeriesArgumentOffset = 2d;
        const double StripWidth = 0.5d;

        readonly NonCryptographicRandom random = new NonCryptographicRandom(3);
        readonly ObservableCollection<PointData> currentExperimentRandomPoints1 = new ObservableCollection<PointData>();
        readonly ObservableCollection<PointData> currentExperimentRandomPoints2 = new ObservableCollection<PointData>();
        readonly ObservableCollection<BoxPlotPoint> experimentResults1 = new ObservableCollection<BoxPlotPoint>();
        readonly ObservableCollection<BoxPlotPoint> experimentResults2 = new ObservableCollection<BoxPlotPoint>();
        List<double> randomValues1;
        List<double> randomValues2;
        int experimentNumber = 0;

        XYDiagram Diagram { get { return ChartControl.Diagram as XYDiagram; } }
        AxisX AxisX { get { return Diagram != null ? Diagram.AxisX : null; } }

        internal override ChartControl ChartControl {
            get { return boxPlotChart; }
        }

        public BoxPlotDemo() {
            InitializeComponent();
            Diagram.EnableAxisXScrolling = true;
            Diagram.EnableAxisXZooming = true;
            SetDataSource(ChartControl.Series[0], experimentResults1);
            SetDataSource(ChartControl.Series[1], experimentResults2);
            SetDataSource(ChartControl.Series[2], currentExperimentRandomPoints1);
            SetDataSource(ChartControl.Series[3], currentExperimentRandomPoints2);
            ColorizeSeries();
            GenerateInitialResults();
            AxisX.StickToEdge = true;
            AxisX.WholeRange.SideMarginsValue = 0.5;
            AxisX.VisualRange.SideMarginsValue = 0.5;
            long min = experimentNumber - InitialArgumentCount;
            AxisX.VisualRange.SetMinMaxValues(min, experimentNumber);
            ChartControl.CrosshairOptions.GroupHeaderPattern = "Experiment {A}";
            boxPlotChart.Animate();
        }
        void SetDataSource(Series series, object dataSource) {
            ((DataSourceAdapter)series.DataAdapter).DataSource = dataSource;
        }
        void GenerateInitialResults() {
            for(int i = InitialResultCount - 1; i > 0; i--) {
                List<double> randomValues1 = RandomSequenceGenerator.GenerateRandomSequence(random, MeasurementsCount);
                List<double> randomValues2 = RandomSequenceGenerator.GenerateRandomSequence(random, MeasurementsCount);
                experimentNumber++;
                BoxPlotPoint point1 = new BoxPlotPoint(experimentNumber, randomValues1);
                BoxPlotPoint point2 = new BoxPlotPoint(experimentNumber, randomValues2);
                experimentResults1.Add(point1);
                experimentResults2.Add(point2);
            }
            randomValues1 = RandomSequenceGenerator.GenerateRandomSequence(random, MeasurementsCount);
            randomValues2 = RandomSequenceGenerator.GenerateRandomSequence(random, MeasurementsCount);
            for(int i = 0; i < MeasurementsCount; i++) {
                currentExperimentRandomPoints1.Add(new PointData(randomValues1[i], random));
                currentExperimentRandomPoints2.Add(new PointData(randomValues2[i], random, SecondPointSeriesArgumentOffset));
            }
            experimentNumber++;
            experimentResults1.Add(new BoxPlotPoint(experimentNumber, randomValues1));
            experimentResults2.Add(new BoxPlotPoint(experimentNumber, randomValues2));
            UpdateStripAndCustomLabel();
        }
        void BtnGenerate_Click(object sender, EventArgs e) {
            sbGenerate.Enabled = false;
            DisableBoxPlotAnimations();
            currentExperimentRandomPoints1.Clear();
            currentExperimentRandomPoints2.Clear();
            randomValues1 = RandomSequenceGenerator.GenerateRandomSequence(random, MeasurementsCount);
            randomValues2 = RandomSequenceGenerator.GenerateRandomSequence(random, MeasurementsCount);
            for(int i = 0; i < MeasurementsCount; i++) {
                currentExperimentRandomPoints1.Add(new PointData(randomValues1[i], random));
                currentExperimentRandomPoints2.Add(new PointData(randomValues2[i], random, SecondPointSeriesArgumentOffset));
            }
            experimentNumber++;
            UpdateStripAndCustomLabel();
            boxPlotChart.Animate();

        }
        void BoxPlotChart_AnimationEnded(object sender, EventArgs e) {
            if(randomValues1 == null || randomValues2 == null)
                return;
            experimentResults1.Add(new BoxPlotPoint(experimentNumber, randomValues1));
            experimentResults2.Add(new BoxPlotPoint(experimentNumber, randomValues2));
            sbGenerate.Enabled = true;
        }
        void cheShowMeanLine_CheckedChanged(object sender, EventArgs e) {
            foreach(Series series in ChartControl.Series) {
                BoxPlotSeriesView view = series.View as BoxPlotSeriesView;
                if(view != null)
                    view.MeanLineVisible = cheShowMeanLine.Checked;
            }
        }
        void UpdateStripAndCustomLabel() {
            if(AxisX == null)
                return;
            AxisX.Strips.Clear();
            Strip strip = new Strip() {
                ShowInLegend = false,
            };
            strip.MinLimit.AxisValue = experimentNumber - StripWidth;
            strip.MaxLimit.AxisValue = experimentNumber + StripWidth;
            AxisX.Strips.Add(strip);
            AxisX.CustomLabels.Clear();
            CustomAxisLabel label = new CustomAxisLabel() {
                Name = "Current Experiment",
                AxisValue = experimentNumber
            };
            AxisX.CustomLabels.Add(label);
        }
        void ColorizeSeries() {
            PaletteEntry[] paletteEntries = ChartControl.GetPaletteEntries(2);
            if(ChartControl.Series.Count < 4)
                return;
            ChartControl.Series[2].View.Color = Color.FromArgb(100, paletteEntries[0].Color);
            ChartControl.Series[3].View.Color = Color.FromArgb(100, paletteEntries[1].Color);
        }
        void DisableBoxPlotAnimations() {
            if(ChartControl.Series.Count > 1) {
                BoxPlotSeriesView boxPlot1 = ChartControl.Series[0].View as BoxPlotSeriesView;
                BoxPlotSeriesView boxPlot2 = ChartControl.Series[1].View as BoxPlotSeriesView;
                if(boxPlot1 != null && boxPlot2 != null) {
                    boxPlot1.Animation.Enabled = false;
                    boxPlot2.Animation.Enabled = false;
                }
            }
        }

        protected override void OnPaletteChanged() {
            ColorizeSeries();
        }
    }


    public class PointData {
        public double Argument { get; private set; }
        public double Value { get; private set; }

        public PointData(double val, NonCryptographicRandom rnd, double argumentOffset = 0) {
            Argument = rnd.NextDouble() + argumentOffset;
            Value = val;
        }
    }


    public class BoxPlotPoint {
        public int ExperimentNumber { get; private set; }
        public double Min { get; private set; }
        public double Quartile1 { get; private set; }
        public double Median { get; private set; }
        public double Quartile3 { get; private set; }
        public double Max { get; private set; }
        public double Mean { get; private set; }
        public List<double> Outliers { get; private set; }

        public BoxPlotPoint(int currentExperimentNumber, List<double> randomSequence) {
            ExperimentNumber = currentExperimentNumber;
            Tuple<double, double, double> quartiles = CalculateQuartiles(randomSequence);
            Quartile1 = quartiles.Item1;
            Quartile3 = quartiles.Item3;
            Median = quartiles.Item2;
            Tuple<double, double, double> averageAndMinMax = CalculateAverageAndMinMax(randomSequence);
            Mean = averageAndMinMax.Item1;
            Min = Math.Max(averageAndMinMax.Item2, Quartile1 - 1.5 * (Quartile3 - Quartile1));
            Max = Math.Min(averageAndMinMax.Item3, Quartile3 + 1.5 * (Quartile3 - Quartile1));
            Outliers = randomSequence.Where(d => d > Max || d < Min).ToList();
        }

        Tuple<double, double, double> CalculateAverageAndMinMax(List<double> randomSequence) {
            double average = 0;
            double min = double.MaxValue;
            double max = double.MinValue;
            foreach(double d in randomSequence) {
                average += d;
                if(d > max)
                    max = d;
                if(d < min)
                    min = d;
            }
            average = average / randomSequence.Count;
            return new Tuple<double, double, double>(average, min, max);
        }
        Tuple<double, double, double> CalculateQuartiles(List<double> randomSequence) {
            randomSequence.Sort();
            int middleIndex = randomSequence.Count / 2; //for correct vb conversion
            double quartile1 = 0;
            double quartile2;
            double quartile3 = 0;
            if(randomSequence.Count % 2 == 0) {
                quartile2 = (randomSequence[middleIndex - 1] + randomSequence[middleIndex]) / 2;
                int middleIndexOfHalf = middleIndex / 2;
                if(middleIndex % 2 == 0) {
                    quartile1 = (randomSequence[middleIndexOfHalf - 1] + randomSequence[middleIndexOfHalf]) / 2;
                    quartile3 = (randomSequence[middleIndex + middleIndexOfHalf - 1] + randomSequence[middleIndex + middleIndexOfHalf]) / 2;
                }
                else {
                    quartile1 = randomSequence[middleIndexOfHalf];
                    quartile3 = randomSequence[middleIndexOfHalf + middleIndex];
                }
            }
            else if(randomSequence.Count == 1) {
                quartile1 = randomSequence[0];
                quartile2 = randomSequence[0];
                quartile3 = randomSequence[0];
            }
            else {
                quartile2 = randomSequence[middleIndex];
                if((randomSequence.Count - 1) % 4 == 0) {
                    int quarterIndex = (randomSequence.Count - 1) / 4; //for correct vb conversion
                    quartile1 = (randomSequence[quarterIndex - 1] * .25) + (randomSequence[quarterIndex] * .75);
                    quartile3 = (randomSequence[3 * quarterIndex] * .75) + (randomSequence[3 * quarterIndex + 1] * .25);
                }
                else if((randomSequence.Count - 3) % 4 == 0) {
                    int quarterIndex = (randomSequence.Count - 3) / 4; //for correct vb conversion;
                    quartile1 = (randomSequence[quarterIndex] * .75) + (randomSequence[quarterIndex + 1] * .25);
                    quartile3 = (randomSequence[3 * quarterIndex + 1] * .25) + (randomSequence[3 * quarterIndex + 2] * .75);
                }
            }
            return new Tuple<double, double, double>(quartile1, quartile2, quartile3);
        }
    }


    static class RandomSequenceGenerator {
        public static List<double> GenerateRandomSequence(NonCryptographicRandom random, int length) {
            double selector = random.NextDouble();
            if(selector < 0.33)
                return GenerateExponentialDistribution(random, length);
            if(selector < 0.66)
                return GenerateSpecialDistribution(random, length);
            else
                return GenerateNormalDistribution(random, length);
        }

        static List<double> GenerateNormalDistribution(NonCryptographicRandom random, int length) {
            List<double> list = new List<double>(length);
            //Box-Muller transform
            double mean = random.Next(450, 550);
            double stdDev = random.Next(50, 70);
            for(int i = 0; i < length; i++) {
                double u1 = 1.0 - random.NextDouble();
                double u2 = 1.0 - random.NextDouble();
                double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
                list.Add(mean + stdDev * randStdNormal);
            }
            return list;
        }
        static List<double> GenerateExponentialDistribution(NonCryptographicRandom random, int length) {
            List<double> list = new List<double>(length);
            double minVal = random.Next(250, 300);
            double maxVal = minVal + 300;
            int generatedCount = 0;
            double lambda = random.NextDouble() * 2;
            while(generatedCount < length) {
                double u = random.NextDouble();
                double t = -Math.Log(u) / lambda;
                double increment = (maxVal - minVal) / 6.0;
                double result = minVal + (t * increment);
                if(result < maxVal) {
                    list.Add(result);
                    generatedCount++;
                }
            }
            return list;
        }
        static List<double> GenerateSpecialDistribution(NonCryptographicRandom random, int length) {
            List<double> list = new List<double>(length);
            int min = random.Next(100, 250);
            int step = random.Next(30, 70);
            for(int i = 0; i < (int)(length * 0.05); i++)
                list.Add(random.Next(min, min + step));
            for(int i = 0; i < (int)(length * 0.025); i++)
                list.Add(random.Next(min + step + 1, min + 2 * step));
            for(int i = 0; i < (int)(length * 0.075); i++)
                list.Add(random.Next(min + 2 * step + 1, min + 3 * step));
            for(int i = 0; i < (int)(length * 0.10); i++)
                list.Add(random.Next(min + 3 * step + 1, min + 4 * step));
            for(int i = 0; i < (int)(length * 0.20); i++)
                list.Add(random.Next(min + 4 * step + 1, min + 5 * step));
            for(int i = 0; i < (int)(length * 0.30); i++)
                list.Add(random.Next(min + 5 * step + 1, min + 6 * step));
            for(int i = 0; i < (int)(length * 0.20); i++)
                list.Add(random.Next(min + 6 * step + 1, min + 7 * step));
            for(int i = 0; i < (int)(length * 0.05) + 1; i++)
                list.Add(random.Next(min + 7 * step + 1, min + 8 * step));
            return list;
        }

    }

}
