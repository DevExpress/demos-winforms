using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.Data.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class SwiftPointDemo : ChartDemoModule {
        const int PointsCount = 100000;

        readonly IList<Point> data;

        internal override ChartControl ChartControl { get { return chart; } }

        public SwiftPointDemo() {
            InitializeComponent();
            data = GenerateData();
            chart.Series[0].BindToData(data, "X", "Y");
            chart.Series[0].View.Color = Color.FromArgb(100, chart.GetPaletteEntries(1)[0].Color);
        }
        List<Point> GenerateData() {
            List<Point> data = new List<Point>(PointsCount);
            NonCryptographicRandom random = new NonCryptographicRandom(0);
            double value;
            int square, price, maxValue, minValue;
            for(int i = 0; i < PointsCount; i++) {
                value = random.NextDouble();
                value = (Math.Pow(value, 15) + 1.2) * Math.Pow(value, 0.2) / 2.2;
                maxValue = random.Next(10) == 1 ? (int)(random.NextDouble() * 2000 + 4000) : random.Next(1000) + 4500;
                minValue = random.Next(11) == 10 ? 400 : 600;
                square = (int)(value * maxValue + minValue);
                if(random.Next(800 - square / 10) == 1)
                    maxValue = (int)(3000000 * (random.NextDouble() + 1));
                else
                    maxValue = 3 * (int)((Math.Pow(value, 2) + 0.5) * Math.Pow(value, 0.2) * 670000);
                value = random.NextDouble();
                minValue = random.Next(11) == 10 ? 400000 : 200000;
                price = (int)(value * maxValue + minValue);
                if(price > 2000000 * (0.2 * random.NextDouble() + 1) && square < random.Next(1000) + 3500)
                    square += random.Next(2000);
                if(price > 3000000 * (0.2 * random.NextDouble() + 1))
                    square += random.Next(2000);
                data.Add(new Point(square, price));
            }
            return data;
        }
    }
}
