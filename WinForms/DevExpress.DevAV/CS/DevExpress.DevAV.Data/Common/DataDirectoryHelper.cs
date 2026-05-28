using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using DevExpress.Data.Utils;

namespace DevExpress.Internal {
    public class DevAVDataDirectoryHelper {
        const string DataFolderName = "Data";
        
        public static string GetFile(string fileName) {
            if(DataPath != null)
                return Path.Combine(DataPath, fileName);
            string dataDirectory = GetDataDirectory();
            if(dataDirectory == null)
                return null;
            string dataDirectoryRootPath = Path.GetFullPath(dataDirectory);
            string relativePath = Path.Combine(DataFolderName, fileName);
            for(int n = 0; n < 9; n++) {
                string path = Path.Combine(dataDirectoryRootPath, relativePath);
                try {
                    if(File.Exists(path) || Directory.Exists(path))
                        return path;
                }
                catch { }
                dataDirectoryRootPath += @"\..";
            }
            throw new FileNotFoundException(string.Format("{0} not found. ({1})", fileName, dataDirectoryRootPath));
        }
        static string GetDataDirectory() {
            return Path.GetDirectoryName(SafeEnvironment.ProcessPath);
        }
        
        public static string LocalPrefix { get; set; }
        public static string DataPath { get; set; }
        
        public static IDisposable SingleInstanceApplicationGuard(string applicationName, out bool exit) {
            Mutex mutex = new Mutex(true, applicationName + AssemblyInfo.VersionShort);
            if(mutex.WaitOne(0, false)) {
                exit = false;
            }
            else {
                foreach(Process process in Process.GetProcessesByName(SafeEnvironment.ProcessName)) {
                    if(process.Id != SafeEnvironment.ProcessId) {
                        IntPtr mainHWnd = process.MainWindowHandle;
                        if(mainHWnd != IntPtr.Zero) {
                            WinApiHelper.SetForegroundWindow(mainHWnd);
                            WinApiHelper.RestoreWindowAsync(mainHWnd);
                            break;
                        }
                    }
                }
                exit = true;
            }
            return mutex;
        }
        static class WinApiHelper {
            [SecuritySafeCritical]
            public static bool SetForegroundWindow(IntPtr hwnd) {
                return Import.SetForegroundWindow(hwnd);
            }
            [SecuritySafeCritical]
            public static bool RestoreWindowAsync(IntPtr hwnd) {
                int showFlags = IsMaximized(hwnd) ?
                    (int)Import.ShowWindowCommands.ShowMaximized : (int)Import.ShowWindowCommands.Restore;
                return Import.ShowWindowAsync(hwnd, showFlags);
            }
            [SecuritySafeCritical]
            public static bool IsMaximized(IntPtr hwnd) {
                Import.WINDOWPLACEMENT placement = new Import.WINDOWPLACEMENT();
                placement.length = Marshal.SizeOf(placement);
                if(!Import.GetWindowPlacement(hwnd, ref placement))
                    return false;
                return placement.showCmd == Import.ShowWindowCommands.ShowMaximized;
            }
            [SecuritySafeCritical]
            static class Import {
                [DllImport("user32.dll")]
                [return: MarshalAs(UnmanagedType.Bool)]
                public static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);
                [DllImport("user32.dll")]
                [return: MarshalAs(UnmanagedType.Bool)]
                public static extern bool SetForegroundWindow(IntPtr hWnd);
                [DllImport("user32.dll")]
                public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
                [StructLayout(LayoutKind.Sequential)]
                public struct WINDOWPLACEMENT {
                    public int length;
                    public int flags;
                    public ShowWindowCommands showCmd;
                    public System.Drawing.Point ptMinPosition;
                    public System.Drawing.Point ptMaxPosition;
                    public System.Drawing.Rectangle rcNormalPosition;
                }
                public enum ShowWindowCommands : int {
                    Hide = 0,
                    Normal = 1,
                    ShowMinimized = 2,
                    ShowMaximized = 3,
                    ShowNoActivate = 4,
                    Show = 5,
                    Minimize = 6,
                    ShowMinNoActive = 7,
                    ShowNA = 8,
                    Restore = 9,
                    ShowDefault = 10,
                    ForceMinimize = 11
                }
            }
        }
    }
}
