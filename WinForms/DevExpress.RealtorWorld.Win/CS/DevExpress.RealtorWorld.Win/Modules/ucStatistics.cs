using System;
using DevExpress.XtraCharts;

namespace DevExpress.RealtorWorld.Win {
    public partial class ucStatistics : BaseModule {
        static string[] Regions = new string[] { "Middle West", "Mountain", "Pacific", "South", "North East" };
        public override bool AllowWaitDialog { get { return false; } }
        Series PopularitySeries { get { return ccPopularity.Series[0]; } }
        Series PriceSeries { get { return ccPrice.Series[0]; } }
        Series SimilarHousesSoldSeries { get { return ccSimilarHouses.Series["Sold"]; } }
        Series SimilarHousesProposalsSeries { get { return ccSimilarHouses.Series["Proposals"]; } }
        XYDiagram PriceDiagram { get { return (XYDiagram)ccPrice.Diagram; } }
        XYDiagram SimilarHousesDiagram { get { return (XYDiagram)ccSimilarHouses.Diagram; } }

        public ucStatistics() {
            InitializeComponent();
        }
        void FillPricesChart(Home home, DevExpress.Data.Utils.NonCryptographicRandom random) {
            PriceSeries.Points.Clear();
            DateTime date = DateTime.Now;
            DateTime startDate = date - new TimeSpan(500, 0, 0, 0, 0);
            ccPrice.BeginInit();
            try {
                PriceSeries.Points.Add(new SeriesPoint(date, home.Price / 1000));
                while (date > startDate) {
                    date = date - new TimeSpan(1, 0, 0, 0, 0);
                    PriceSeries.Points.Insert(0,
                        new SeriesPoint(date, PriceSeries.Points[0].Values[0] * (1 + (random.NextDouble() - 0.5) / 1000)));
                }
            }
            finally {
                ccPrice.EndInit();
            }
            PriceDiagram.AxisX.VisualRange.SetMinMaxValues((DateTime)PriceDiagram.AxisX.WholeRange.MaxValue - new TimeSpan(100, 0, 0, 0),
                PriceDiagram.AxisX.WholeRange.MaxValue);
        }
        void FillPopularityRatingChart(DevExpress.Data.Utils.NonCryptographicRandom random) {
            ccPopularity.BeginInit();
            try {
                PopularitySeries.Points.Clear();
                for (int i = 0; i < Regions.Length; i++)
                    PopularitySeries.Points.Add(new SeriesPoint(Regions[i], random.Next(80)));
            }
            finally {
                ccPopularity.EndInit();
            }
        }
        void FillSimilarHousesChart(DevExpress.Data.Utils.NonCryptographicRandom random) {
            int year = DateTime.Now.Year;
            ccSimilarHouses.BeginInit();
            try {
                SimilarHousesProposalsSeries.Points.Clear();
                SimilarHousesSoldSeries.Points.Clear();
                for (int i = 0; i < 10; i++) {
                    int proposalCount = random.Next(50, 250);
                    SimilarHousesProposalsSeries.Points.Insert(0, new SeriesPoint(year - i, proposalCount));
                    SimilarHousesSoldSeries.Points.Insert(0,
                        new SeriesPoint(year - i, Math.Round(proposalCount * (random.Next(10, 80) / 100.0))));
                }                
            }
            finally {
                ccSimilarHouses.EndInit();
            }
            SimilarHousesDiagram.AxisX.VisualRange.MinValue = year - 5;
        }
        public void InitData(Home home) {
            var random = new DevExpress.Data.Utils.NonCryptographicRandom(home.ID);
            FillPopularityRatingChart(random);
            FillPricesChart(home, random);
            FillSimilarHousesChart(random);
        }
    }
}
