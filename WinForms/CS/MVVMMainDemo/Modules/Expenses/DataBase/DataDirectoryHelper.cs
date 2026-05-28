namespace DevExpress.Internal {
    using System.IO;
    using DevExpress.Data.Utils;
    //
    public class DataDirectoryHelper {
        const string DataFolderName = "Data";
        //
        public static string GetFile(string fileName) {
            if(DataPath != null)
                return Path.Combine(DataPath, fileName);
            string dataDirectory = Path.GetDirectoryName(SafeEnvironment.ProcessPath);
            if(dataDirectory == null)
                return null;
            string dataDirectoryRootPath = Path.GetFullPath(dataDirectory);
            string relativePath = Path.Combine(DataFolderName, fileName);
            for(int n = 0; n < 9; n++) {
                string candidate = Path.Combine(dataDirectoryRootPath, relativePath);
                try {
                    if(File.Exists(candidate) || Directory.Exists(candidate))
                        return candidate;
                }
                catch { }
                dataDirectoryRootPath += @"\..";
            }
            throw new FileNotFoundException(string.Format("{0} not found. ({1})", fileName, dataDirectoryRootPath));
        }
        //
        public static string DataPath { get; set; }
    }
}
