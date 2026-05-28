using System;
using System.Collections.Generic;
using System.Threading;
using DevExpress.Data.Utils;

namespace DevExpress.XtraCharts.Demos {

    class DataGenerator {
        const int RndMax = 20;
        const int RndMin = 10;

        readonly NonCryptographicRandom rnd;
        int integer = 0;
        double value;
        double value2 = double.NaN;
        readonly int multiplier;
        readonly int seriesIndex;

        internal DataGenerator(int seriesIndex, double startValue) {
            this.seriesIndex = seriesIndex;
            value = startValue;
            multiplier = seriesIndex % 2 == 0 ? 1 : -1;
            rnd = new NonCryptographicRandom(seriesIndex);
        }
        internal DataGenerator(int rndSeek)
            : this(rndSeek, 0) { }
        internal DataGenerator()
            : this(0, 0) { }

        DataPoint GenerateDataPoint(SeriesDataType seriesType, bool negativeValues = false) {
            DataPoint dataPoint;
            switch(seriesType) {
                case SeriesDataType.Financial:
                    dataPoint = GenerateFinancialDataPoint();
                    break;
                case SeriesDataType.ArgumentValue:
                    dataPoint = GenerateArgValueDataPoint(negativeValues);
                    break;
                case SeriesDataType.Bubble:
                    dataPoint = GenerateBubblePoint();
                    break;
                case SeriesDataType.Range:
                    dataPoint = GenerateRangeDataPoint();
                    break;
                case SeriesDataType.Funnel:
                    dataPoint = GenerateFunnelPoint();
                    break;
                case SeriesDataType.BoxPlot:
                    dataPoint = GenerateBoxPlotDataPoint();
                    break;
                default:
                    throw new NotImplementedException("Data generator for " + seriesType + "has not implemented");
            }
            return dataPoint;
        }

        DataPoint GenerateFunnelPoint() {
            DataPoint dataPoint = GenerateDataPointWithArgument();
            value -= rnd.Next(1, 7);
            dataPoint.Value = value;
            return dataPoint;
        }
        DataPoint GenerateBubblePoint() {
            DataPoint dataPoint = GenerateDataPointWithArgument();
            dataPoint.Value = rnd.Next(RndMax);
            dataPoint.Weight = rnd.Next(RndMax);
            return dataPoint;
        }
        DataPoint GenerateArgValueDataPoint(bool negativeValues = false) {
            DataPoint dataPoint = GenerateDataPointWithArgument();
            int sign = negativeValues ? -1 : 1;
            value += multiplier * Math.Round(5 * rnd.NextDouble() * sign - 2.2);
            dataPoint.Value = value;
            return dataPoint;
        }
        DataPoint GenerateFinancialDataPoint() {
            DataPoint dataPoint = GenerateDataPointWithArgument();
            value += rnd.Next(-6, 5);
            dataPoint.Low = value;
            dataPoint.Open = value + rnd.Next(1, 5);
            double close = value + rnd.Next(1, 5);
            if(dataPoint.Open == close)
                close += 1.5;
            dataPoint.Close = close;
            dataPoint.High = Math.Max(dataPoint.Close, dataPoint.Open) + rnd.Next(1, 4);
            return dataPoint;
        }
        DataPoint GenerateBoxPlotDataPoint() {
            DataPoint dataPoint = GenerateDataPointWithArgument();
            value += rnd.Next(-5, 6);
            dataPoint.Min = value;
            dataPoint.Quartile1 = value + rnd.Next(1, 5);
            dataPoint.Median = dataPoint.Quartile1 + rnd.Next(4, 8);
            dataPoint.Mean = dataPoint.Median + rnd.Next(-3, 3);
            dataPoint.Quartile3 = dataPoint.Mean + rnd.Next(4, 9);
            dataPoint.Max = dataPoint.Quartile3 + rnd.Next(1, 5);
            dataPoint.Outliers = new double[3];
            dataPoint.Outliers[0] = dataPoint.Min - rnd.Next(1, 3);
            dataPoint.Outliers[1] = dataPoint.Max + rnd.Next(1, 3);
            dataPoint.Outliers[2] = dataPoint.Max + rnd.Next(4, 10);
            return dataPoint;
        }
        DataPoint GenerateRangeDataPoint() {
            if(double.IsNaN(value2))
                value2 = value + 20;
            DataPoint dataPoint = GenerateDataPointWithArgument();
            value += rnd.Next(-3, 3);
            value2 += rnd.Next(-9, 3);
            dataPoint.Value = value;
            dataPoint.Value2 = value2;
            return dataPoint;
        }
        DataPoint GenerateDataPointWithArgument() {
            integer++;
            DataPoint point = CreateDataPoint();
            point.Argument = integer;
            return point;
        }
        protected DataPoint CreateDataPoint() {
            return new DataPoint() { Series = String.Format("Series {0}", seriesIndex + 1) };
        }

        internal List<DataPoint> GenerateData(SeriesDataType seriesType, int pointCount, bool negativeValues = false) {
            List<DataPoint> data = new List<DataPoint>();
            for(int i = 0; i < pointCount; i++) {
                DataPoint point = GenerateDataPoint(seriesType, negativeValues);
                data.Add(point);
            }
            return data;
        }
        internal List<DataPoint> GeneratePolarData(SeriesDataType seriesType, int pointCount) {
            double step = 360.0 / pointCount;
            double argument = -step;
            List<DataPoint> data = new List<DataPoint>();
            for(int i = 0; i < pointCount; i++) {
                DataPoint point = CreateDataPoint();
                argument += step + rnd.Next(-10, 10);
                point.Argument = argument;
                point.Value = rnd.Next(RndMin, RndMax);
                if(seriesType == SeriesDataType.Range)
                    point.Value2 = rnd.Next(RndMin + 10, RndMax + 7);
                data.Add(point);
            }
            return data;
        }
        internal List<DataPoint> GenerateXyScatterData() {
            List<DataPoint> data = new List<DataPoint>();
            for(int i = 0; i < 720; i += 10) {
                double t = (double)i / 180 * Math.PI;
                double x = t * Math.Cos(t);
                double y = t * Math.Sin(t);
                DataPoint dataPoint = CreateDataPoint();
                dataPoint.Argument = x;
                dataPoint.Value = y;
                data.Add(dataPoint);
            }
            return data;
        }
    }


    enum SeriesDataType {
        ArgumentValue,
        Financial,
        Bubble,
        Range,
        Funnel,
        BoxPlot,
    }


    static class LargeDataGenerator {
        static int counter = 0;
        public static List<SimpleDataPoint> GenerateSeriesDataSourceSine(int pointsCount) {
            List<SimpleDataPoint> points = new List<SimpleDataPoint>();
            double value = 0;
            double argument = 0;
            counter++;
            for(int i = 0; i < pointsCount; i++) {
                argument = i;
                value = (float)(Math.Sin(argument) +
                                                                                                                 Math.Sin(argument / 100.0) +
                                                                                                            30 * Math.Sin(argument / 1000.0) +
                                                                               1000 * (1 + 0.1 * counter % 10) * Math.Sin(argument / 100000.0 + Math.PI / 6 * counter));
                points.Add(new SimpleDataPoint(argument, value));
            }
            return points;
        }
        internal static List<SimpleDataPoint> GenerateSeriesDataSource(int pointsCount) {
            List<SimpleDataPoint> points = new List<SimpleDataPoint>(pointsCount);
            NonCryptographicRandom random = new NonCryptographicRandom(DateTime.Now.Millisecond);
            double value = 0;
            double delta = (random.NextDouble()) / 75;
            for(int i = 0; i < pointsCount; i++) {
                points.Add(new SimpleDataPoint(i, value));
                value = value + random.NextDouble() - 0.5 + delta;
            }
            return points;
        }
    }


    static class PolarDiagramPointsGenerator {
        const int DefaultPointsCount = 72;

        static SeriesPoint GenerateSeriesPoint(double m, double value, int pointsInSeries) {
            double[] points = new double[pointsInSeries];
            for(int i = 0; i < pointsInSeries; i++) {
                double factor = (i == 0) ? m : 0;
                points[i] = Function(factor, value);
            }
            return new SeriesPoint(value, points);
        }
        static double Function(double m, double angle) {
            double cos = Math.Cos(m * ToRadian(90.0 + angle));
            return Math.Pow(Math.Abs(cos), m);
        }
        static double ToRadian(double angle) {
            return angle * Math.PI / 180.0;
        }
        static SeriesPoint[] GenerateFunctionPoints(double m, int pointCount, int pointsInSeries) {
            int step = 360 / pointCount;
            SeriesPoint[] points = new SeriesPoint[pointCount];
            for(int i = 0; i < pointCount; i++)
                points[i] = GenerateSeriesPoint(m, i * step, pointsInSeries);
            return points;
        }
        static double GetLineFactor(int functionType) {
            switch(functionType) {
                case 0:
                    return 1;
                case 1:
                    return 0.5;
                default:
                    return 2;
            }
        }

        internal static SeriesPoint[] GenerateFunctionPoints(int functionType, int pointsInSeries) {
            double lineFactor = GetLineFactor(functionType);
            return GenerateFunctionPoints(lineFactor, DefaultPointsCount, pointsInSeries);
        }
    }


    class SensorDataGenerator {
        const int InitialDataPointsCount = 10000;
        const int DataGenerationIntervalMilliseconds = 15;

        readonly DataCollection dataSource = new DataCollection();
        readonly NonCryptographicRandom random = new NonCryptographicRandom(1);
        readonly List<SensorIndicationItem> buffer = new List<SensorIndicationItem>();
        readonly object sync = new object();
        int counter;
        double yAddition1 = 0;
        double yAddition2 = 0;
        double yAddition3 = 0;
        double yAddition4 = 0;
        double yAddition5 = 0;
        double yAddition6 = 0;
        double yAddition7 = 0;
        double yAddition8 = 0;
        bool generatingEnabled = false;
        Thread generatingThread;

        internal DataCollection DataSource {
            get { return dataSource; }
        }

        SensorIndicationItem CreatePoint(DateTime timeStamp) {
            counter++;
            double arg = timeStamp.ToOADate();
            arg = arg * 250000d;
            if(counter % random.Next(300, 500) == 0)
                yAddition1 += random.Next(10, 20) * Math.Sign(random.NextDouble() - 0.5);
            if(yAddition1 < -30)
                yAddition1 += 10;
            if(yAddition1 > 30)
                yAddition1 -= 10;
            double indication1 = 5 * Math.Sin(5d / 2d * Math.Cos(arg)) + 100 + (random.NextDouble() - 0.5) * 5 + yAddition1;
            if(counter % random.Next(100, 300) == 0)
                yAddition2 += random.Next(10, 20) * Math.Sign(random.NextDouble() - 0.5);
            if(yAddition2 < -30)
                yAddition2 += 10;
            if(yAddition2 > 30)
                yAddition2 -= 10;
            double indication2 = 4 * Math.Sin(7 * Math.Cos(arg - 1.5)) + 90 + (random.NextDouble() - 0.5) * 7 + yAddition2;

            if(counter % random.Next(100, 500) == 0)
                yAddition3 += random.Next(10, 20) * Math.Sign(random.NextDouble() - 0.5);
            if(yAddition3 < -30)
                yAddition3 += 10;
            if(yAddition3 > 30)
                yAddition3 -= 10;
            double indication3 = 10 * (Math.Sin(arg) + Math.Sin(arg / 1.2d) + Math.Sin(arg / 1.5d)) + 100 + random.NextDouble() * 12 + yAddition3;
            if(counter % random.Next(50, 100) == 0)
                yAddition4 += random.Next(10, 20) * Math.Sign(random.NextDouble() - 0.5);
            if(yAddition4 < -30)
                yAddition4 += 10;
            if(yAddition4 > 30)
                yAddition4 -= 10;
            double indication4 = 10 * (Math.Cos(arg + 1.5) + Math.Sin(arg / 1.2d + 0.5) + Math.Cos(arg / 1.5d + 0.3)) + 120 + random.NextDouble() * 15 + yAddition4;

            if(counter % random.Next(300, 400) == 0)
                yAddition5 += random.Next(10, 20) * Math.Sign(random.NextDouble() - 0.5);
            if(yAddition5 < -30)
                yAddition5 += 10;
            if(yAddition5 > 30)
                yAddition5 -= 10;
            double indication5 = 15 * Math.Cos(Math.Tan(arg + random.NextDouble() / 10)) + 500 + random.NextDouble() * 15 + yAddition5;
            if(counter % random.Next(400, 1000) == 0)
                yAddition6 += random.Next(10, 20) * Math.Sign(random.NextDouble() - 0.5);
            if(yAddition6 < -30)
                yAddition6 += 10;
            if(yAddition6 > 30)
                yAddition6 -= 10;
            double indication6 = 20 * Math.Sin(Math.Tan(arg + 1)) + 450 + random.NextDouble() * 9 + yAddition6;

            if(counter % random.Next(200, 300) == 0)
                yAddition7 += random.Next(10, 20) * Math.Sign(random.NextDouble() - 0.5);
            if(yAddition7 < -30)
                yAddition7 += 10;
            if(yAddition7 > 30)
                yAddition7 -= 10;
            double indication7 = 30 * Math.Abs(Math.Sin(Math.Tan(arg + 1))) + Math.Cos(arg) + Math.Sin(arg) + 750 + random.NextDouble() * 15 + yAddition7;
            if(counter % random.Next(300, 350) == 0)
                yAddition8 += random.Next(10, 20) * Math.Sign(random.NextDouble() - 0.5);
            if(yAddition8 < -30)
                yAddition8 += 10;
            if(yAddition8 > 30)
                yAddition8 -= 10;
            double indication8 = 30 * (1 - Math.Cos(arg)) / random.Next(1, 5) + 700 + random.NextDouble() * 15 + yAddition8;

            return new SensorIndicationItem(timeStamp, indication1, indication2, indication3, indication4, indication5, indication6, indication7, indication8);
        }
        void AddPoint(DateTime timeStamp) {
            SensorIndicationItem point = CreatePoint(timeStamp);
            lock(sync) {
                buffer.Add(point);
            }
        }
        void GeneratingLoop() {
            DateTime timeStamp = DateTime.Now;
            while(generatingEnabled) {
                DateTime newTimeStamp = timeStamp.AddMilliseconds(DataGenerationIntervalMilliseconds);
                TimeSpan span = newTimeStamp - DateTime.Now;
                if(span.Ticks > 0)
                    Thread.Sleep((int)span.TotalMilliseconds);
                timeStamp = newTimeStamp;
                AddPoint(timeStamp);
            }
        }

        internal void GenerateInitialData() {
            DateTime baseTimeStamp = DateTime.Now.AddMilliseconds(-InitialDataPointsCount * DataGenerationIntervalMilliseconds);
            DateTime argument = baseTimeStamp;
            for(int i = 0; i < InitialDataPointsCount - 1; i++) {
                argument = argument.AddMilliseconds(DataGenerationIntervalMilliseconds);
                SensorIndicationItem point = CreatePoint(argument);
                dataSource.Add(point);
            }
        }
        internal void UpdateDataSource() {
            lock(sync) {
                dataSource.AddRange(buffer);
                if(dataSource.Count > InitialDataPointsCount)
                    dataSource.RemoveRangeAt(0, buffer.Count);
                buffer.Clear();
            }
        }
        internal void Start() {
            if(generatingThread == null)
                generatingThread = new Thread(new ThreadStart(GeneratingLoop));
            generatingEnabled = true;
            generatingThread.Start();
        }
        internal void Stop() {
            generatingEnabled = false;
            if(generatingThread != null)
                generatingThread.Join();
            generatingThread = null;
        }
    }


    class RealTimeFinancialDataGenerator {
        const double MinPrice = 5.0;
        const double StartPrice = 24.0;
        const int InitialDataPointsCount = 350000;
        const int MaxPointsCount = 255000;
        const int PeriodMilliseconds = 30;

        readonly FinancialDataCollection dataSource = new FinancialDataCollection();
        readonly NonCryptographicRandom random = new NonCryptographicRandom(3);
        readonly List<FinancialDataPoint> buffer = new List<FinancialDataPoint>();
        readonly object bufferSync = new object();
        FinancialDataPoint prevPoint;
        bool generatingEnabled = false;
        Thread generatingThread;

        public FinancialDataCollection DataSource {
            get { return dataSource; }
        }
        public DateTime LastArgument {
            get { return prevPoint.DateTimeStamp; }
        }

        bool firstOnlinePoint = true;
        FinancialDataPoint CreateOnlinePoint(DateTime argument, FinancialDataPoint locPrevPoint) {
            double priceDelta = (random.NextDouble() - 0.5) / 300d;
            double close = locPrevPoint.Close + priceDelta;
            if(close <= MinPrice)
                close = 2 * MinPrice - close;
            double open = locPrevPoint.Close;
            double high = Math.Max(open, close) + random.NextDouble() / 100d;
            double low = Math.Min(open, close) - random.NextDouble() / 100d;
            double volume;
            if(!firstOnlinePoint) {
                volume = locPrevPoint.Volume + random.Next(-5, 5);
            }
            else {
                volume = 2;
                firstOnlinePoint = false;
            }
            if(volume < 2)
                volume = 4 - volume;
            return new FinancialDataPoint(argument, open, high, low, close, volume);
        }
        FinancialDataPoint CreateHistoryPoint(DateTime argument, FinancialDataPoint locPrevPoint) {
            double priceDelta = (random.NextDouble() - 0.5) / 8d;
            double close = locPrevPoint.Close + priceDelta;
            if(close <= MinPrice)
                close = 2 * MinPrice - close;
            double open = locPrevPoint.Close;
            double high = Math.Max(open, close) + (random.NextDouble()) / 25d;
            double low = Math.Min(open, close) - (random.NextDouble()) / 25d;
            double volume = locPrevPoint.Volume + random.Next(-50000, 50000);
            if(volume < 10000)
                volume = 2 * 10000 - volume;
            if(volume > 200000)
                volume = 200000 - (int)(volume / 4);
            return new FinancialDataPoint(argument, open, high, low, close, volume);
        }
        void GeneratingLoop() {
            DateTime timeStamp = DateTime.Now;
            while(generatingEnabled) {
                DateTime newTimeStamp = timeStamp.AddMilliseconds(PeriodMilliseconds);
                TimeSpan span = newTimeStamp - DateTime.Now;
                if(span.Ticks > 0)
                    Thread.Sleep((int)span.TotalMilliseconds);
                timeStamp = newTimeStamp;
                AddPoint(timeStamp);
            }
        }
        FinancialDataPoint currentAggregatingPoint;
        void AddPoint(DateTime timeStamp) {
            FinancialDataPoint point = CreateOnlinePoint(timeStamp, prevPoint);
            if(currentAggregatingPoint.DateTimeStamp.Minute == timeStamp.Minute) {
                currentAggregatingPoint.Close = point.Close;
                currentAggregatingPoint.High = Math.Max(currentAggregatingPoint.High, point.High);
                currentAggregatingPoint.Low = Math.Min(currentAggregatingPoint.Low, point.Low);
                currentAggregatingPoint.Volume += point.Volume;
                lock(bufferSync) {
                    if(buffer.Count > 0)
                        buffer[buffer.Count - 1] = currentAggregatingPoint;
                    else
                        buffer.Add(currentAggregatingPoint);
                }
            }
            else {
                lock(bufferSync) {
                    currentAggregatingPoint = point;
                    buffer.Add(point);
                }
            }
            prevPoint = point;
        }
        bool TheSameMinute(DateTime dt1, DateTime dt2) {
            return (dt1 - DateTime.MinValue).TotalMinutes == (dt2 - DateTime.MinValue).TotalMinutes;
        }

        internal void GenerateInitialData() {
            DateTime baseDate = DateTime.Now.AddMinutes(-InitialDataPointsCount).Date;
            if(baseDate.DayOfWeek == DayOfWeek.Saturday || baseDate.DayOfWeek == DayOfWeek.Sunday)
                baseDate = baseDate.AddDays(baseDate.DayOfWeek == DayOfWeek.Saturday ? 2 : 1);
            prevPoint = new FinancialDataPoint(baseDate, StartPrice, StartPrice + 0.002, StartPrice - 0.002, StartPrice + 0.001, 100000);
            dataSource.Add(prevPoint);
            DateTime argument = baseDate;
            while(argument < DateTime.Now.AddMinutes(-1)) {
                argument = argument.AddMinutes(1);
                if(argument.DayOfWeek == DayOfWeek.Saturday)
                    argument = argument.AddDays(2);
                FinancialDataPoint point = CreateHistoryPoint(argument, prevPoint);
                prevPoint = point;
                dataSource.Add(point);
            }
            currentAggregatingPoint = prevPoint;
            currentAggregatingPoint.Volume = (int)(DateTime.Now.Second / 60d * currentAggregatingPoint.Volume);
        }
        internal void UpdateDataSource() {
            List<FinancialDataPoint> tempBuffer;
            lock(bufferSync) {
                tempBuffer = new List<FinancialDataPoint>(buffer);
                buffer.Clear();
            }
            if(tempBuffer.Count == 0)
                return;
            if(TheSameMinute(tempBuffer[0].DateTimeStamp, dataSource[dataSource.Count - 1].DateTimeStamp)) {
                dataSource[dataSource.Count - 1] = tempBuffer[0];
            }
            else {
                dataSource.Add(tempBuffer[0]);
            }
            if(tempBuffer.Count > 1)
                dataSource.AddRange(tempBuffer.GetRange(1, tempBuffer.Count - 1));
            int overflow = dataSource.Count - MaxPointsCount;
            if(overflow > 0) {
                dataSource.RemoveRangeAt(0, overflow);
            }
        }
        internal void Start() {
            if(generatingThread == null)
                generatingThread = new Thread(new ThreadStart(GeneratingLoop));
            generatingEnabled = true;
            generatingThread.Start();
        }
        internal void Stop() {
            generatingEnabled = false;
            if(generatingThread != null)
                generatingThread.Join();
            generatingThread = null;
        }
    }


    static class FinancialDataGenerator {
        const double StartPrice = 26;
        const double MaxPrice = 100;
        const double MinPrice = 5;
        const int StartWorkingHour = 8;
        const int EndWorkingHour = 18;
        const int Holiday1Day = 1;
        const int Holiday1Month = 1;
        const int Holiday2Day = 1;
        const int Holiday2Month = 5;
        const DayOfWeek Weekend1 = DayOfWeek.Saturday;
        const DayOfWeek Weekend2 = DayOfWeek.Sunday;

        static bool GeneratePoint(DateTime dateTime, double previousClose, NonCryptographicRandom random, out double newPreviousClose, out FinancialDataPoint point) {
            if(dateTime.Hour < StartWorkingHour
                || dateTime.Hour >= EndWorkingHour
                || dateTime.DayOfWeek == Weekend1
                || dateTime.DayOfWeek == Weekend2
                || (dateTime.Day == Holiday1Day && dateTime.Month == Holiday1Month)
                || (dateTime.Day == Holiday2Day && dateTime.Month == Holiday2Month)) {
                newPreviousClose = double.NaN;
                point = new FinancialDataPoint();
                return false;
            }
            double open;
            if(dateTime.Hour == StartWorkingHour)
                open = previousClose + (random.NextDouble() - 0.5) / 2d;
            else
                open = previousClose;
            double close = open + (random.NextDouble() - 0.5) / 5d;
            if(close > MaxPrice)
                close = 0.8 * close;
            if(close <= MinPrice)
                close = 2 * MinPrice - close;
            double high = Math.Max(open, close) + random.NextDouble() / 5d;
            double low = Math.Min(open, close) - random.NextDouble() / 5d;
            double volume = (random.NextDouble() + 0.1) * 1000d;
            newPreviousClose = close;
            point = new FinancialDataPoint(dateTime, open, high, low, close, volume);
            return true;
        }

        static internal List<FinancialDataPoint> Generate() {
            NonCryptographicRandom random = new NonCryptographicRandom(28);
            List<FinancialDataPoint> points = new List<FinancialDataPoint>();
            int startYear = DateTime.Now.Year - 3;
            DateTime currentDateTime = new DateTime(startYear, 1, 2, 8, 0, 0);
            DateTime endDateTime = new DateTime(startYear + 3, 1, 1, 0, 0, 0);
            double previousClose = StartPrice;
            while(currentDateTime < endDateTime) {
                FinancialDataPoint point = new FinancialDataPoint();
                double newPreviousClose;
                bool generated = GeneratePoint(currentDateTime, previousClose, random, out newPreviousClose, out point);
                if(generated) {
                    previousClose = newPreviousClose;
                    points.Add(point);
                }
                currentDateTime = currentDateTime.AddHours(1);
            }
            return points;
        }
    }


    static class ScatterLineDataGenerator {
        const int A = 10;

        static void FillSeriesPoints(Series visibleSeries, int visibleSeriesIndex) {
            switch(visibleSeriesIndex) {
                case 0:
                    FillArchimedeanSpiralSeries(visibleSeries);
                    break;
                case 1:
                    FillCardioidSeries(visibleSeries);
                    break;
                case 2:
                    FillCartesianFoliumPSeries(visibleSeries);
                    break;
            }
        }
        static void FillArchimedeanSpiralSeries(Series series) {
            for(int i = 0; i < 720; i += 10) {
                double t = (double)i / 180 * Math.PI;
                double x = t * Math.Cos(t);
                double y = t * Math.Sin(t);
                series.Points.Add(new SeriesPoint(x, y));
            }
        }
        static void FillCardioidSeries(Series series) {
            for(int i = 0; i < 360; i += 10) {
                double t = (double)i / 180 * Math.PI;
                double x = A * (2 * Math.Cos(t) - Math.Cos(2 * t));
                double y = A * (2 * Math.Sin(t) - Math.Sin(2 * t));
                series.Points.Add(new SeriesPoint(x, y));
            }
        }
        static void FillCartesianFoliumPSeries(Series series) {
            for(int i = -30; i < 125; i += 5) {
                double t = Math.Tan((double)i / 180 * Math.PI);
                double x = 3 * (double)A * t / (t * t * t + 1);
                double y = x * t;
                series.Points.Add(new SeriesPoint(x, y));
            }
        }

        internal static void ShowSeries(int visibleSeriesIndex, SeriesCollection series) {
            for(int i = 0; i < series.Count; i++) {
                if(i == visibleSeriesIndex) {
                    Series visibleSeries = series[i];
                    if(visibleSeries.Points.Count == 0)
                        FillSeriesPoints(visibleSeries, visibleSeriesIndex);
                    visibleSeries.Visible = true;
                }
                else
                    series[i].Visible = false;
            }
        }
    }


    class PointGenerator {
        const double startValue = 0;

        public static List<SimpleDataPoint> Generate() {
            NonCryptographicRandom random1 = new NonCryptographicRandom(2);
            NonCryptographicRandom random2 = new NonCryptographicRandom(3);
            double previousValue = startValue;
            List<SimpleDataPoint> list = new List<SimpleDataPoint>() { new SimpleDataPoint(0, previousValue) };
            for(double x = -2000; x < 2000; x += random2.NextDouble() * 3) {
                double value = previousValue + random1.Next(-98, 100);
                double pointValue = value - 3000;
                list.Add(new SimpleDataPoint(x, pointValue));
                previousValue = value;
            }
            return list;
        }

        public static SimpleDataPoint[] GenerateCluster(NonCryptographicRandom random, int xPlus, int xMinus, int yPlus, int yMinus, int count) {
            SimpleDataPoint[] seriesPoints = new SimpleDataPoint[count];
            int deltaX = xMinus - xPlus;
            int deltaY = yMinus - yPlus;
            int centerX = xMinus / 2 + xPlus / 2;
            int centerY = yMinus / 2 + yPlus / 2;
            for(int i = 0; i < count; i++) {
                int half = i / 2 + 1;
                double ratio = Math.Max(2.1, (double)count / half);
                int xOffset = (int)(deltaX / ratio);
                int yOffset = (int)(deltaY / ratio);
                int delta = xMinus - xOffset - centerX;
                int rx, ry;
                do {
                    rx = random.Next(xPlus + xOffset, xMinus - xOffset);
                    ry = random.Next(yPlus + yOffset, yMinus - yOffset);
                }
                while(delta * delta < Math.Pow((centerX - rx), 2) + Math.Pow((centerY - ry), 2));
                seriesPoints[i] = new SimpleDataPoint(rx, ry);
            }
            return seriesPoints;
        }
    }
}
