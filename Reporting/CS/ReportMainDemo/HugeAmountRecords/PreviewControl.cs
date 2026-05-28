using System;
using System.Data.SQLite;
using System.IO;
using System.Threading.Tasks;
using DevExpress.XtraPrinting.Caching;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.HugeAmountRecords {
    public class PreviewControl : ReportModule {
        #region inner classes
        class StorageHelper : IDisposable {
            const string dbFileName = "ReportCache";
            const string dbFileExtension = ".db";

            readonly string path;
            public StorageHelper(string path) {
                this.path = path;
            }
            public DocumentStorage CreateStorage() {
                Clear();
                CreateDirectory();

                string dbFileName = GetDbFileName();
                SQLiteConnection.CreateFile(dbFileName);
                return new DbDocumentStorage("XpoProvider=SQLite;Data Source=" + dbFileName + ";Version=3;");
            }
            public void Clear() {
                SQLiteConnection.ClearAllPools();

                if(Directory.Exists(path))
                    ClearFiles(path);
            }
            static void ClearFiles(string path) {
                foreach(string file in Directory.GetFiles(path, dbFileName + "*"))
                    try {
                        File.Delete(file);
                    }
                    catch { }
            }
            string GetDbFileName() {
                string dbFile;
                int i = 0;
                do {
                    dbFile = Path.Combine(path, dbFileName + i++ + dbFileExtension);
                } while(File.Exists(dbFile));
                return dbFile;
            }
            void CreateDirectory() {
                if(!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            }
            void IDisposable.Dispose() {
                Clear();
            }
        }
        #endregion
        CachedReportSource source;

        string FolderPath {
            get {
                return Path.Combine(DevExpress.Data.Utils.SafeEnvironment.LocalApplicationData, "DevExpress\\ReportCache");
            }
        }
        protected override XtraReport CreateReport() {
            DocumentStorage storage = new StorageHelper(FolderPath).CreateStorage();
            XtraReport _report = new XtraReportsDemos.CachedDocumentSourceReport.Report();
            source = new CachedReportSource(_report, storage);
            return _report;
        }
        protected override object DocumentSource { get { return source; } }
        protected override Task StopWorkingAsync() {
            if(source != null)
                return source.CompleteWorkingAsync(true);
            return Task.FromResult<object>(null);
        }
        protected override void DisposeReport() {
            if(source != null) {
                source.Dispose();
                source = null;
            }
            new StorageHelper(FolderPath).Clear();
            base.DisposeReport();
        }
    }
}
