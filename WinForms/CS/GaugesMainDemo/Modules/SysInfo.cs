using System;
using System.Collections.Generic;
using System.Management;
using System.Threading;
using DevExpress.XtraGauges.Win;
using DevExpress.XtraGauges.Win.Gauges.Circular;

namespace DevExpress.XtraGauges.Demos {
    public partial class SysInfo : TutorialControl {
        static int stateCounter = 0;
        static int lockTimerCounter = 0;

        static int GetTotalMemorySizeMB(WMIService wmiService) {
            ManagementObject[] collection = wmiService.GetObjects("Select TotalVisibleMemorySize From Win32_OperatingSystem", true);
            return (collection.Length == 1) ? (int)((UInt64)collection[0].Properties["TotalVisibleMemorySize"].Value / 1024) : 4096;
        }
        static int GetFreeMemorySizeMB(WMIService wmiService) {
            ManagementObject[] collection = wmiService.GetObjects("Select FreePhysicalMemory From Win32_OperatingSystem", false);
            return (collection.Length == 1) ? (int)((UInt64)collection[0].Properties["FreePhysicalMemory"].Value / 1024) : 4096;
        }
        static int GetTotalHDDSizeGB(WMIService wmiService) {
            ManagementObject[] collection = wmiService.GetObjects("Select Size From Win32_LogicalDisk ", true);
            UInt64 _size = 0;
            for(int i = 0; i < collection.Length; i++) {
                PropertyData pData = collection[i].Properties["Size"];
                _size += ((pData != null && pData.Value != null) ? (UInt64)pData.Value : 0u);
            }
            return (int)(_size >> 30);
        }
        static int GetFreeHDDSizeGB(WMIService wmiService) {
            ManagementObject[] collection = wmiService.GetObjects("Select FreeSpace From Win32_LogicalDisk ", false);
            UInt64 _size = 0;
            for(int i = 0; i < collection.Length; i++) {
                PropertyData pData = collection[i].Properties["FreeSpace"];
                _size += ((pData != null && pData.Value != null) ? (UInt64)pData.Value : 0u);
            }
            return (int)(_size >> 30);
        }
        static string GetOSName(WMIService wmiService) {
            ManagementObject[] collection = wmiService.GetObjects("Select Caption From Win32_OperatingSystem", true);
            return (collection.Length == 1) ? (string)collection[0].Properties["Caption"].Value : string.Empty;
        }
        static string[] GetProcessorNames(WMIService wmiService) {
            ManagementObject[] collection = wmiService.GetObjects("Select Name From Win32_Processor", true);
            string[] result = new string[collection.Length];
            for(int i = 0; i < collection.Length; i++) {
                result[i] = (string)collection[i].Properties["Name"].Value;
            }
            return result;
        }
        static PerformanceInfo_CPU[] GetPerfomanceInfo_CPU(WMIService wmiService) {
            PerformanceInfo_CPU[] result = new PerformanceInfo_CPU[0];
            try {
                ManagementObject[] collection = wmiService.GetObjects(
                        "SELECT Name,PercentProcessorTime,PercentPrivilegedTime,PercentUserTime " +
                        "FROM Win32_PerfFormattedData_PerfOS_Processor " +
                        "WHERE Name=\'_Total\'",
                        false
                    );
                result = new PerformanceInfo_CPU[collection.Length];
                for(int i = 0; i < collection.Length; i++) {
                    result[i] = new PerformanceInfo_CPU(
                            (string)collection[i].Properties["Name"].Value,
                            (float)(UInt64)collection[i].Properties["PercentProcessorTime"].Value,
                            (float)(UInt64)collection[i].Properties["PercentPrivilegedTime"].Value,
                            (float)(UInt64)collection[i].Properties["PercentUserTime"].Value
                        );
                }
            }
            catch { }
            return result;
        }
        static PerformanceInfo_OS[] GetPerfomanceInfo_OS(WMIService wmiService) {
            PerformanceInfo_OS[] result = new PerformanceInfo_OS[0];
            try {
                ManagementObject[] collection = wmiService.GetObjects(
                        "SELECT Name,Processes,Threads " +
                        "FROM Win32_PerfFormattedData_PerfOS_System",
                        false
                    );
                result = new PerformanceInfo_OS[collection.Length];
                for(int i = 0; i < collection.Length; i++) {
                    result[i] = new PerformanceInfo_OS(
                            (string)collection[i].Properties["Name"].Value,
                            (int)(UInt32)collection[i].Properties["Processes"].Value,
                            (int)(UInt32)collection[i].Properties["Threads"].Value
                        );
                }
            }
            catch { }
            return result;
        }

        PerformanceInfo_CPU[] buffer;
        WMIService wmiService;
        Timer pollingTimer;

        public SysInfo() {
            buffer = new PerformanceInfo_CPU[3];
            wmiService = WMIService.GetInstance(null);
            InitializeComponent();
            updateSpeed.Value = 6;
            if(wmiService.Connected) {
                string[] processors = GetProcessorNames(wmiService);
                DashboardGauge.Labels["processorName"].Text = processors[0];
                DashboardGauge.Labels["osName"].Text = GetOSName(wmiService);
                DashboardGauge.Scales["memoryTotal"].MaxValue = GetTotalMemorySizeMB(wmiService);
                DashboardGauge.Scales["hddTotal"].MaxValue = GetTotalHDDSizeGB(wmiService);
                this.pollingTimer = new System.Threading.Timer(OnTimerCallback, null, 1000, 300);
                OnTimerCallback(null);
            }
        }
        void OnTimerCallback(object state) {
            if(Interlocked.CompareExchange(ref lockTimerCounter, 1, 0) == 0) {
                UpdateData();
                stateCounter++;
                Interlocked.Add(ref lockTimerCounter, -1);
            }
        }
        void InvokeUpdate(Action action) {
            if(IsHandleCreated && DashboardGauge != null)
                BeginInvoke(action);
        }
        void UpdateData() {
            if(wmiService != null) {
                UpdatePerfomanceData_CPU();
                if(stateCounter % 5 == 0) UpdatePerfomanceData_OS();
                if(stateCounter % 10 == 0) UpdatePerfomanceData_Memory();
                if(stateCounter % 20 == 0) UpdatePerfomanceData_HDD();
            }
        }
        void UpdatePerfomanceData_CPU() {
            PerformanceInfo_CPU[] infos = GetPerfomanceInfo_CPU(wmiService);
            if(infos.Length == 1) {
                PerformanceInfo_CPU info = GetBufferedPerfomanceInfo(infos[0]);
                InvokeUpdate(() => {
                    DashboardGauge.Scales["cpuTotal"].Value = info.Total;
                    DashboardGauge.Scales["cpuUser"].Value = info.Kernel + info.User;
                    DashboardGauge.Scales["cpuKernel"].Value = info.Kernel;
                });
            }
        }
        void UpdatePerfomanceData_OS() {
            PerformanceInfo_OS[] infos = GetPerfomanceInfo_OS(wmiService);
            if(infos.Length == 1) {
                InvokeUpdate(() => {
                    DashboardGauge.Scales["osThreads"].Value = infos[0].Threads;
                    DashboardGauge.Scales["osProcesses"].Value = infos[0].Processes;
                });
            }
        }
        void UpdatePerfomanceData_Memory() {
            InvokeUpdate(() => {
                DashboardGauge.Scales["memoryTotal"].Value = GetFreeMemorySizeMB(wmiService);
            });
        }
        void UpdatePerfomanceData_HDD() {
            InvokeUpdate(() => {
                DashboardGauge.Scales["hddTotal"].Value = GetFreeHDDSizeGB(wmiService);
            });
        }
        void OnUpdateSpeedChanged(object sender, EventArgs e) {
            int speed = 50 + (updateSpeed.Properties.Maximum - updateSpeed.Value) * 50;
            if(pollingTimer != null) pollingTimer.Change(0, speed);
        }
        PerformanceInfo_CPU GetBufferedPerfomanceInfo(PerformanceInfo_CPU currentValue) {
            for(int i = 1; i < buffer.Length; i++) buffer[i - 1] = buffer[i];
            buffer[buffer.Length - 1] = currentValue;

            float total = 0; float kernel = 0; float user = 0;
            int n = 0;
            for(int i = 0; i < buffer.Length; i++) {
                if(buffer[i] != null) {
                    total += buffer[i].Total;
                    kernel += buffer[i].Kernel;
                    user += buffer[i].User;
                    n++;
                }
            }
            return new PerformanceInfo_CPU(currentValue.Name, total / (float)n, kernel / (float)n, user / (float)n);
        }
        protected CircularGauge DashboardGauge {
            get { return gaugeControl1.Gauges[0] as CircularGauge; }
        }
        public override bool ShowExportMenu {
            get { return true; }
        }
        public override GaugeControl ExportControl {
            get { return gaugeControl1; }
        }
        protected override bool? AllowBorderRounding {
            get { return false; }
        }
    }
    class PerformanceInfo_CPU {
        string nameCore;
        float totalCore;
        float kernelCore;
        float userCore;

        public string Name { get { return nameCore; } }
        public float Total { get { return totalCore; } }
        public float Kernel { get { return kernelCore; } }
        public float User { get { return userCore; } }

        public PerformanceInfo_CPU(string name, float total, float kernel, float user) {
            nameCore = name;
            totalCore = total;
            kernelCore = kernel;
            userCore = user;
        }
    }
    class PerformanceInfo_OS {
        string nameCore;
        int processesCore;
        int threadsCore;

        public string Name { get { return nameCore; } }
        public int Processes { get { return processesCore; } }
        public int Threads { get { return threadsCore; } }

        public PerformanceInfo_OS(string name, int processes, int threads) {
            nameCore = name;
            processesCore = processes;
            threadsCore = threads;
        }
    }
    class MemoryPerformanceInfo {
        string nameCore;
        int totalCore;
        int freeCore;

        public string Name { get { return nameCore; } }
        public int Total { get { return totalCore; } }
        public int Free { get { return freeCore; } }
        public MemoryPerformanceInfo(string name, int total, int free) {
            nameCore = name;
            totalCore = total;
            freeCore = free;
        }
    }

    public sealed class WMIService : IDisposable {
        public static WMIService GetInstance(string path) {
            return new WMIService(string.IsNullOrEmpty(path) ? "//./root/cimv2" : path);
        }

        bool connectedCore = false;
        ManagementScope scopeCore;
        Dictionary<string, ManagementObjectCollection> queryCacheCore;

        Dictionary<string, ManagementObjectCollection> QueryCache { get { return queryCacheCore; } }
        public bool Connected { get { return connectedCore; } }
        public ManagementScope Scope { get { return scopeCore; } }

        WMIService(string path) {
            queryCacheCore = new Dictionary<string, ManagementObjectCollection>();
            ConnectionOptions options = new ConnectionOptions();
            options.Impersonation = ImpersonationLevel.Impersonate;
            options.Authentication = AuthenticationLevel.Packet;
            this.scopeCore = new ManagementScope(path, options);
            try {
                Scope.Connect();
                connectedCore = Scope.IsConnected;
            }
            catch { connectedCore = false; }
        }
        ManagementObjectCollection GetManagementObjectCollection(string queryString) {
            ManagementObjectCollection result = null;
            ObjectQuery query = new ObjectQuery(queryString);
            using(ManagementObjectSearcher searcher = new ManagementObjectSearcher(Scope, query)) {
                result = searcher.Get();
            }
            return result;
        }
        public void Dispose() {
            connectedCore = false;
            if(queryCacheCore != null) {
                foreach(KeyValuePair<string, ManagementObjectCollection> pair in queryCacheCore) {
                    if(pair.Value != null) pair.Value.Dispose();
                }
                queryCacheCore.Clear();
                queryCacheCore = null;
            }
            scopeCore = null;
        }
        public ManagementObjectCollection GetObjectCollection(string queryString, bool allowQueryCaching) {
            ManagementObjectCollection result = null;
            if(allowQueryCaching) QueryCache.TryGetValue(queryString, out result);
            if(result == null) {
                result = GetManagementObjectCollection(queryString);
                if(allowQueryCaching) {
#pragma warning disable CA1864 
                    if(QueryCache.ContainsKey(queryString)) QueryCache[queryString] = result;
                    else QueryCache.Add(queryString, result);
#pragma warning restore CA1864 
                }
            }
            return result;
        }
        public ManagementObject[] GetObjects(string queryString, bool allowQueryCaching) {
            ManagementObjectCollection collection = GetObjectCollection(queryString, allowQueryCaching);
            int count = collection?.Count ?? 0;
            ManagementObject[] result = new ManagementObject[count];
            if(collection != null && count > 0)
                collection.CopyTo(result, 0);
            return result;
        }
    }
}
