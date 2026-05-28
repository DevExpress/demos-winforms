using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace DevExpress.StockMarketTrader.Model {
    public class NetworkMonitor {
        const string serverName = "google.com";
        readonly Timer timer;
        readonly Ping ping;
        public bool IsInternetAvailable {
            get;
            private set;
        }
        public NetworkMonitor() {
            ping = new Ping();
            ping.PingCompleted += PingCompleted;
            timer = new Timer() {
                Interval = 50
            };
            timer.Tick += OnTimerTick;
            timer.Start();
        }
        void OnTimerTick(object sender, EventArgs e) {
            timer.Stop();
            ping.SendAsync(serverName, null);
        }
        bool isInitializing = false;
        void PingCompleted(object sender, PingCompletedEventArgs e) {
            bool isAvaliable = (e.Reply != null) && (e.Reply.Status == IPStatus.Success);
            if(isAvaliable != IsInternetAvailable) {
                isInitializing = true;
                IsInternetAvailable = isAvaliable;
                RaiseInternetAvaliableChanged();
            }
            else if(!isInitializing) {
                isInitializing = true;
                RaiseInternetAvaliableChanged();
            }
        }
        public event EventHandler<EventArgs> InternetAvailableChanged;
        void RaiseInternetAvaliableChanged() {
            InternetAvailableChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
