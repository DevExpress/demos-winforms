using System.Data;
using System.IO;

namespace DevExpress.XtraRichEdit.Demos {
    public class DBUriStreamProvider : DevExpress.Office.Services.IUriStreamProvider {
        readonly DataTable table;
        readonly string columnName;
        public DBUriStreamProvider(DataTable table, string columnName) {
            this.table = table;
            this.columnName = columnName;
        }
        Stream DevExpress.Office.Services.IUriStreamProvider.GetStream(string uri) {
            const string prefix = "dbimg://";
            uri = uri.Trim();
            if(!uri.StartsWith(prefix, System.StringComparison.OrdinalIgnoreCase))
                return null;
            string strId = uri.Substring(prefix.Length).Trim();
            int id;
            if(!int.TryParse(strId, out id))
                return null;
            DataRow row = table.Rows.Find(id);
            if(row == null)
                return null;
            byte[] bytes = row[columnName] as byte[];
            if(bytes == null)
                return null;
            return new MemoryStream(bytes);
        }
    }
}
