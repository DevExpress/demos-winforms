using System;
using System.Collections.Generic;
using DevExpress.StockMarketTrader.Model.BusinessObjects;
using DevExpress.StockMarketTrader.Model.Offline;
using DevExpress.StockMarketTrader.StockDataServiceReference;

namespace DevExpress.StockMarketTrader.Model {
    public class PriceAscendingComparer : IComparer<TransactionData> {
        public static readonly IComparer<TransactionData> Instance = new PriceAscendingComparer();
        PriceAscendingComparer() { }
        //
        public int Compare(TransactionData x, TransactionData y) {
            if(x == null || y == null)
                return 0;
            if(x.Price == y.Price) {
                if(y.Bid == 0 && x.Ask == 0)
                    return -1;
                else
                    return 1;
            }
            return x.Price.CompareTo(y.Price);
        }
    }

    public class RealTimeDataEventArgs : EventArgs {
        public bool CanNewUpdate { get; set; }
        public string Key { get; set; }
        public string ExceptionMessage { get; set; }
        public object Data { get; set; }

        public RealTimeDataEventArgs(object data, string key, bool canNewUpdate) {
            Data = data;
            Key = key;
            CanNewUpdate = canNewUpdate;
        }
        public RealTimeDataEventArgs(string message) {
            ExceptionMessage = message;
        }
    }

    public class RealTimeDataModel {
        const string RemoteServerUnavailableMessage = "The remote server is not responding. Check your internet connection.";

        readonly NetworkMonitor networkMonitor;
        readonly DevExpress.Data.Utils.NonCryptographicRandom rand;
        readonly List<TransactionData> transactions;
        bool isInitialized = false;
        StockDataOfflineService offlineService;

        public event EventHandler<RealTimeDataEventArgs> UpdateFailed;
        public event EventHandler<EventArgs> Initialized;

        public IStockDataService Service {
            get;
            private set;
        }
        public bool IsOnline {
            get { return networkMonitor.IsInternetAvailable; }
        }
        public int CurrentPriceIndex {
            get;
            private set;
        }
        public string NetworkState {
            get { return IsOnline ? "Connected" : "Offline"; }
        }
        public RealTimeDataModel() {
            rand = DevExpress.Data.Utils.NonCryptographicRandom.Default;
            Service = CreateOfflineService();
            networkMonitor = new NetworkMonitor();
            networkMonitor.InternetAvailableChanged += OnInternetAvaliableChanged;
            transactions = new List<TransactionData>();
        }
        void OnInternetAvaliableChanged(object sender, EventArgs e) {
            if(!isInitialized)
                InitServer();
            else
                UpdateService();
        }
        void RaiseInitialized() {
            if(Initialized != null) Initialized(this, EventArgs.Empty);
        }
        void RaiseUpdateFailed() {
            Service = CreateOfflineService();
            if(UpdateFailed != null) UpdateFailed(this, new RealTimeDataEventArgs(RemoteServerUnavailableMessage));
        }
        void OnExecuteFailed(object sender, EventArgs e) {
            RaiseUpdateFailed();
        }
        public void InitServer() {
            try {
                isInitialized = true;
                UpdateService();
                RaiseInitialized();
            }
            catch { RaiseUpdateFailed(); }
        }
        public void UpdateService() {
            Service = CreateOfflineService();
        }
        void CorrectTransactionData() {
            if(transactions.Count > 30) {
                int transactionsCount = 0;
                if(CurrentPriceIndex > 0)
                    transactionsCount = transactions.Count - CurrentPriceIndex;
                bool isDominating = transactionsCount > (transactions.Count - transactionsCount);
                for(int i = 0; i < 4; i++) {
                    CurrentPriceIndex--;
                    if(isDominating)
                        transactions.RemoveAt(0);
                    else
                        transactions.RemoveAt(transactions.Count - 1);
                }
            }
        }
        void CorrectOnOneTransactionTypeExists() {
            if(CurrentPriceIndex == -1 && transactions.Count != 0) {
                int lastIndex = transactions.Count - 1;
                string transactionType = transactions[0].Bid == 0 ? "Bid" : "Ask";
                int volume = transactions[lastIndex].Volume + 5;
                double price = IsDownMoving(transactionType) ?
                    transactions[lastIndex].Price + 0.5 : transactions[0].Price - 0.5;
                TransactionData tdvm = new TransactionData(transactionType, volume, price);
                transactions.Add(tdvm);
                CurrentPriceIndex = transactions.IndexOf(tdvm);
            }
        }
        void CheckTransactions(int currentIndex, bool isDownMoving) {
            int index = isDownMoving ? 1 : -1;
            int i = currentIndex + index;
            while((i < transactions.Count && i > -1) && transactions[i].TransactionType != transactions[currentIndex].TransactionType) {
                int delta = transactions[currentIndex].Volume - transactions[i].Volume;
                if(delta == 0) {
                    if(isDownMoving) {
                        transactions.Remove(transactions[i]);
                        transactions.Remove(transactions[currentIndex]);
                    }
                    else {
                        transactions.Remove(transactions[currentIndex]);
                        transactions.Remove(transactions[i]);
                    }
                    break;
                }
                if(delta < 0) {
                    transactions[i].Volume = -delta;
                    transactions.Remove(transactions[currentIndex]);
                    break;
                }
                else {
                    transactions[currentIndex].Volume = delta;
                    transactions.Remove(transactions[i]);
                    if(!isDownMoving) { currentIndex--; i--; }
                }
            }
        }
        void AddNewTransaction(double currentPrice, string transactionType) {
            int maxVolumeValue = 100;
            double price = GetNewTransactionPrice(currentPrice);
            int volume = 1 + rand.Next(maxVolumeValue);
            TransactionData currentTransaction = new TransactionData(transactionType, volume, price);
            transactions.Add(currentTransaction);
            transactions.Sort(PriceAscendingComparer.Instance);
            CheckTransactions(transactions.IndexOf(currentTransaction), IsDownMoving(transactionType));
        }
        int FindNewCurrentPriceIndex() {
            for(int i = 0; i < transactions.Count; i++) {
                if(i < transactions.Count - 1 && transactions[i].TransactionType != transactions[i + 1].TransactionType)
                    return i;
            }
            return -1;
        }
        bool IsDownMoving(string trantctionType) {
            return trantctionType == "Bid";
        }
        double GetNewTransactionPrice(double currentPrice) {
            double factor = currentPrice * 0.1 * rand.NextDouble();
            factor = rand.NextDouble() > 0.5 ? factor : -factor;
            double price = currentPrice + factor;
            return Math.Round(price, 2);
        }
        IStockDataService CreateOfflineService() {
            return offlineService ?? (offlineService = new StockDataOfflineService());
        }
        public void ClearTransactions() {
            transactions.Clear();
        }
        public List<TransactionData> GetTransactions(double currentPrice) {
            int maxTransactionCount = 3;
            int numOfTransactions = 1 + rand.Next(maxTransactionCount);
            for(int i = 0; i < numOfTransactions; i++) {
                AddNewTransaction(currentPrice, "Bid");
                AddNewTransaction(currentPrice, "Ask");
            }
            CurrentPriceIndex = FindNewCurrentPriceIndex();
            CorrectTransactionData();
            CorrectOnOneTransactionTypeExists();
            return transactions;
        }
    }
}
