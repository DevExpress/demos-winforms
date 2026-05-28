using DevExpress.StockMarketTrader.StockDataServiceReference;
using System;

namespace DevExpress.StockMarketTrader.Model.BusinessObjects {
    public class TradingData {
        public DateTime Date {
            get;
            set;
        }
        public double Price {
            get;
            set;
        }
        public double Open {
            get;
            set;
        }
        public double Close {
            get;
            set;
        }
        public double High {
            get;
            set;
        }
        public double Low {
            get;
            set;
        }
        public double Volume {
            get;
            set;
        }
        public TradingData() { }
        public TradingData(TradingData data) {
            Assign(data);
        }
        public void Assign(TradingData data) {
            Date = data.Date;
            Price = data.Price;
            Open = data.Open;
            Close = data.Close;
            High = data.High;
            Low = data.Low;
            Volume = data.Volume;
        }
    }

    public class CompanyTradingData : TradingData {
        public string CompanyName {
            get;
            set;
        }
        public CompanyTradingData(TradingData data, string companyName)
            : base(data) {
            CompanyName = companyName;
        }
        public CompanyTradingData(StockData data, string companyName) {
            Date = data.Date;
            Close = (double)data.CloseP;
            Open = (double)data.OpenP;
            Price = (double)data.Price;
            High = (double)data.HighP;
            Low = (double)data.LowP;
            Volume = data.Volumne;
            CompanyName = companyName;
        }
    }

    public class TransactionData {
        public int Ask {
            get { return TransactionType == "Ask" ? Volume : 0; }
        }
        public int Bid {
            get { return TransactionType == "Bid" ? Volume : 0; }
        }
        public int Volume {
            get;
            set;
        }
        public double Price {
            get;
            set;
        }
        public string TransactionType {
            get;
            private set;
        }
        public TransactionData(string transactionType, int volume, double price) {
            this.Volume = volume;
            this.Price = price;
            this.TransactionType = transactionType;
        }
    }
}
