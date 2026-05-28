using DevExpress.DXperience.Demos;
using System;

namespace DevExpress.ApplicationUI.Demos {
    public partial class StockData {
        public decimal ClosePrice { get; set; }
        public DateTime Date { get; set; }
        public decimal HighPrice { get; set; }
        public decimal LowPrice { get; set; }
        public decimal OpenPrice { get; set; }
        public int Volumne { get; set; }
    }
    public static class StockDataCreator {
        const int BeginDate = 40000;
        public static StockData GetData(int index) {
            int delta = TutorialConstants.Random.Next(-5, 5);
            StockData data = new StockData();
            data.Date = DateTime.FromOADate(BeginDate + index);
            data.HighPrice = TutorialConstants.Random.Next(20 + delta, 30 + delta) + (decimal)Math.Round(TutorialConstants.Random.NextDouble(), 2);
            data.LowPrice = TutorialConstants.Random.Next(10 + delta, 18 + delta) + (decimal)Math.Round(TutorialConstants.Random.NextDouble(), 2);
            data.OpenPrice = TutorialConstants.Random.Next(20 + delta, 25 + delta) + (decimal)Math.Round(TutorialConstants.Random.NextDouble(), 2);
            data.ClosePrice = TutorialConstants.Random.Next(15 + delta, 20 + delta) + (decimal)Math.Round(TutorialConstants.Random.NextDouble(), 2);
            data.Volumne = TutorialConstants.Random.Next(10000, 18000);
            return data;
        }
    }
}
