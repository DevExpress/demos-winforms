using System;
using System.ComponentModel;

namespace DevExpress.StockMarketTrader.StockDataServiceReference {
    public class StockData {
        decimal ClosePField;
        int CompanyIDField;
        DateTime DateField;
        decimal HighPField;
        decimal LowPField;
        decimal OpenPField;
        decimal PriceField;
        int VolumneField;
        public decimal CloseP {
            get { return this.ClosePField; }
            set {
                if(this.ClosePField.Equals(value) != true) {
                    this.ClosePField = value;
                    this.RaisePropertyChanged("CloseP");
                }
            }
        }
        public int CompanyID {
            get { return this.CompanyIDField; }
            set {
                if(this.CompanyIDField.Equals(value) != true) {
                    this.CompanyIDField = value;
                    this.RaisePropertyChanged("CompanyID");
                }
            }
        }
        public DateTime Date {
            get { return this.DateField; }
            set {
                if(this.DateField.Equals(value) != true) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        public decimal HighP {
            get { return this.HighPField; }
            set {
                if(this.HighPField.Equals(value) != true) {
                    this.HighPField = value;
                    this.RaisePropertyChanged("HighP");
                }
            }
        }
        public decimal LowP {
            get { return this.LowPField; }
            set {
                if(this.LowPField.Equals(value) != true) {
                    this.LowPField = value;
                    this.RaisePropertyChanged("LowP");
                }
            }
        }
        public decimal OpenP {
            get { return this.OpenPField; }
            set {
                if(this.OpenPField.Equals(value) != true) {
                    this.OpenPField = value;
                    this.RaisePropertyChanged("OpenP");
                }
            }
        }
        public decimal Price {
            get { return this.PriceField; }
            set {
                if(this.PriceField.Equals(value) != true) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        public int Volumne {
            get { return this.VolumneField; }
            set {
                if(this.VolumneField.Equals(value) != true) {
                    this.VolumneField = value;
                    this.RaisePropertyChanged("Volumne");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class TopRatedCompanyData : INotifyPropertyChanged {
        string CompanyNameField;
        double NewPriceField;
        double OldPriceField;
        public string CompanyName {
            get { return this.CompanyNameField; }
            set {
                if(object.ReferenceEquals(this.CompanyNameField, value) != true) {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
                }
            }
        }
        public double NewPrice {
            get { return this.NewPriceField; }
            set {
                if(this.NewPriceField.Equals(value) != true) {
                    this.NewPriceField = value;
                    this.RaisePropertyChanged("NewPrice");
                }
            }
        }
        public double OldPrice {
            get { return this.OldPriceField; }
            set {
                if(this.OldPriceField.Equals(value) != true) {
                    this.OldPriceField = value;
                    this.RaisePropertyChanged("OldPrice");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class CompaniesVolumeData : INotifyPropertyChanged {
        string CompanyNameField;
        int VolumeField;
        public string CompanyName {
            get { return this.CompanyNameField; }
            set {
                if(object.ReferenceEquals(this.CompanyNameField, value) != true) {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
                }
            }
        }
        public int Volume {
            get { return this.VolumeField; }
            set {
                if(this.VolumeField.Equals(value) != true) {
                    this.VolumeField = value;
                    this.RaisePropertyChanged("Volume");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class CompanyData : INotifyPropertyChanged {
        double ClosePriceField;
        StockData DataField;
        double HighPriceField;
        double LowPriceField;
        public double ClosePrice {
            get { return this.ClosePriceField; }
            set {
                if(this.ClosePriceField.Equals(value) != true) {
                    this.ClosePriceField = value;
                    this.RaisePropertyChanged("ClosePrice");
                }
            }
        }
        public StockData Data {
            get { return this.DataField; }
            set {
                if(object.ReferenceEquals(this.DataField, value) != true) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        public double HighPrice {
            get { return this.HighPriceField; }
            set {
                if(this.HighPriceField.Equals(value) != true) {
                    this.HighPriceField = value;
                    this.RaisePropertyChanged("HighPrice");
                }
            }
        }
        public double LowPrice {
            get { return this.LowPriceField; }
            set {
                if(this.LowPriceField.Equals(value) != true) {
                    this.LowPriceField = value;
                    this.RaisePropertyChanged("LowPrice");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class CompanyStockData : INotifyPropertyChanged {
        string CompanyNameField;
        StockData[] DataField;
        public string CompanyName {
            get { return this.CompanyNameField; }
            set {
                if(object.ReferenceEquals(this.CompanyNameField, value) != true) {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
                }
            }
        }
        public StockData[] Data {
            get { return this.DataField; }
            set {
                if(object.ReferenceEquals(this.DataField, value) != true) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    //
    public interface IStockDataService {
        DateTime[] GetDates();
        StockData[] GetStockDataByDate(DateTime currentDate);
        string[] GetCompaniesName();
        StockData[] GetCompanyStockData(DateTime date, string companyName);
        CompaniesVolumeData[] GetCompaniesVolumeFromPeriod(DateTime start, DateTime end);
        CompanyData[] GetCompanyMultipleDataFromPeriod(int currentDate, int count, int periodSize, string companyName);
        CompanyStockData[] GetStockDataFromPeriodByCompanyList(
            int currentDate,
            int count,
            int periodSize,
            string[] companies);
        CompanyStockData[] GetStockDataFromDateByCompanyList(DateTime date, string[] companies);
    }
}
