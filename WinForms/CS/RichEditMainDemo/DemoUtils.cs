using System.IO;
using DevExpress.Tutorials;

namespace DevExpress.XtraRichEdit.Demos {
    public class DemoUtils {
        public static string GetRelativePath(string name) {
            string path = Path.Combine("Data", name);
            return FilePathUtils.FindFilePath(path, false);
        }
        public static void SetConnectionString(System.Data.OleDb.OleDbConnection oleDbConnection, string path) {
            oleDbConnection.ConnectionString = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source={0};Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False", path);
        }
    }
}
