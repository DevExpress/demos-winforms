using System;
using System.Management;
using System.Threading;
using DevExpress.XtraGauges.Win.Gauges.Circular;

namespace DevExpress.RealtorWorld.Win {
    public partial class ucSysInfo : BaseModule {
        PerfomanceInfo_CPU[] buffer;
        System.Threading.Timer pollingTimer;
        public ucSysInfo() {
            buffer = new PerfomanceInfo_CPU[3];
            InitializeComponent();
            if(DataHelper.WmiService.Connected) {
                string[] processors = GetProcessorNames(DataHelper.WmiService);
                DashboardGauge.Labels["processorName"].Text = processors[0];
                DashboardGauge.Labels["osName"].Text = GetOSName(DataHelper.WmiService);
                DashboardGauge.Scales["memoryTotal"].MaxValue = GetTotalMemorySizeMB(DataHelper.WmiService);
                DashboardGauge.Scales["hddTotal"].MaxValue = GetTotalHDDSizeGB(DataHelper.WmiService);
                this.pollingTimer = new System.Threading.Timer(OnTimerCallback, null, 1000, 300);
                OnTimerCallback(null);
            }
        }
        protected override void Dispose(bool disposing) {
            if(disposing && pollingTimer != null) {
                AutoResetEvent pollingStopped = new AutoResetEvent(false);
                pollingTimer.Dispose(pollingStopped);
                pollingStopped.WaitOne();
            }
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public override string ModuleCaption { get { return "System Information"; } }
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
            UInt64 size = 0;
            for(int i = 0; i < collection.Length; i++) {
                PropertyData pData = collection[i].Properties["Size"];
                size += ((pData != null && pData.Value != null) ? (UInt64)pData.Value : 0u);
            }
            return (int)(size >> 30);
        }
        static int GetFreeHDDSizeGB(WMIService wmiService) {
            ManagementObject[] collection = wmiService.GetObjects("Select FreeSpace From Win32_LogicalDisk ", false);
            UInt64 size = 0;
            for(int i = 0; i < collection.Length; i++) {
                PropertyData pData = collection[i].Properties["FreeSpace"];
                size += ((pData != null && pData.Value != null) ? (UInt64)pData.Value : 0u);
            }
            return (int)(size >> 30);
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
        static PerfomanceInfo_CPU[] GetPerfomanceInfo_CPU(WMIService wmiService) {
            ManagementObject[] collection = wmiService.GetObjects(
                    "SELECT Name,PercentProcessorTime,PercentPrivilegedTime,PercentUserTime " +
                    "FROM Win32_PerfFormattedData_PerfOS_Processor " +
                    "WHERE Name=\'_Total\'",
                    false
                );
            PerfomanceInfo_CPU[] result = new PerfomanceInfo_CPU[collection.Length];
            for(int i = 0; i < collection.Length; i++) {
                result[i] = new PerfomanceInfo_CPU(
                        (string)collection[i].Properties["Name"].Value,
                        (float)(UInt64)collection[i].Properties["PercentProcessorTime"].Value,
                        (float)(UInt64)collection[i].Properties["PercentPrivilegedTime"].Value,
                        (float)(UInt64)collection[i].Properties["PercentUserTime"].Value
                    );
            }
            return result;
        }
        static PerfomanceInfo_OS[] GetPerfomanceInfo_OS(WMIService wmiService) {
            ManagementObject[] collection = wmiService.GetObjects(
                    "SELECT Name,Processes,Threads " +
                    "FROM Win32_PerfFormattedData_PerfOS_System",
                    false
                );
            PerfomanceInfo_OS[] result = new PerfomanceInfo_OS[collection.Length];
            for(int i = 0; i < collection.Length; i++) {
                result[i] = new PerfomanceInfo_OS(
                        (string)collection[i].Properties["Name"].Value,
                        (int)(UInt32)collection[i].Properties["Processes"].Value,
                        (int)(UInt32)collection[i].Properties["Threads"].Value
                    );
            }
            return result;
        }

        void OnTimerCallback(object state) {
            if(System.Threading.Interlocked.CompareExchange(ref lockTimerCounter, 1, 0) == 0) {
                if(DataHelper.WmiService != null && DashboardGauge != null && !DashboardGauge.IsDisposing) {
                    UpdatePerfomanceData_CPU();
                    if(stateCounter % 5 == 0) UpdatePerfomanceData_OS();
                    if(stateCounter % 10 == 0) UpdatePerfomanceData_Memory();
                    if(stateCounter % 20 == 0) UpdatePerfomanceData_HDD();
                }
                stateCounter++;
                System.Threading.Interlocked.Add(ref lockTimerCounter, -1);
            }
        }
        void UpdatePerfomanceData_CPU() {
            PerfomanceInfo_CPU[] infos = GetPerfomanceInfo_CPU(DataHelper.WmiService);
            if(infos.Length == 1) {
                PerfomanceInfo_CPU info = GetBufferedPerfomanceInfo(infos[0]);
                DashboardGauge.Scales["cpuTotal"].Value = info.Total;
                DashboardGauge.Scales["cpuUser"].Value = info.Kernel + info.User;
                DashboardGauge.Scales["cpuKernel"].Value = info.Kernel;
            }
        }
        void UpdatePerfomanceData_OS() {
            PerfomanceInfo_OS[] infos = GetPerfomanceInfo_OS(DataHelper.WmiService);
            if(infos.Length == 1) {
                DashboardGauge.Scales["osThreads"].Value = infos[0].Threads;
                DashboardGauge.Scales["osProcesses"].Value = infos[0].Processes;
            }
        }
        void UpdatePerfomanceData_Memory() {
            DashboardGauge.Scales["memoryTotal"].Value = GetFreeMemorySizeMB(DataHelper.WmiService);
        }
        void UpdatePerfomanceData_HDD() {
            DashboardGauge.Scales["hddTotal"].Value = GetFreeHDDSizeGB(DataHelper.WmiService);
        }
        PerfomanceInfo_CPU GetBufferedPerfomanceInfo(PerfomanceInfo_CPU currentValue) {
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
            return new PerfomanceInfo_CPU(currentValue.Name, total / (float)n, kernel / (float)n, user / (float)n);
        }
        protected CircularGauge DashboardGauge {
            get {
                if(gaugeControl1.Gauges == null) return null;
                return gaugeControl1.Gauges[0] as CircularGauge; 
            }
        }
    }
    class PerfomanceInfo_CPU {
        string nameCore;
        float totalCore;
        float kernelCore;
        float userCore;
        
        public string Name { get { return nameCore; } }
        public float Total { get { return totalCore; } }
        public float Kernel { get { return kernelCore; } }
        public float User { get { return userCore; } }
        
        public PerfomanceInfo_CPU(string name, float total, float kernel, float user) {
            nameCore = name;
            totalCore = total;
            kernelCore = kernel;
            userCore = user;
        }
    }
    class PerfomanceInfo_OS {
        string nameCore;
        int processesCore;
        int threadsCore;

        public string Name { get { return nameCore; } }
        public int Processes { get { return processesCore; } }
        public int Threads { get { return threadsCore; } }
        
        public PerfomanceInfo_OS(string name, int processes, int threads) {
            nameCore = name;
            processesCore = processes;
            threadsCore = threads;
        }
    }
    class MemoryPerfomanceInfo {
        string nameCore;
        int totalCore;
        int freeCore;
        
        public string Name { get { return nameCore; } }
        public int Total { get { return totalCore; } }
        public int Free { get { return freeCore; } }
        public MemoryPerfomanceInfo(string name, int total, int free) {
            nameCore = name;
            totalCore = total;
            freeCore = free;
        }
    }
}
