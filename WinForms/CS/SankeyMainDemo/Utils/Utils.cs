using DevExpress.XtraCharts.Sankey;
using DevExpress.XtraMap;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace DevExpress.XtraSankey.Demos {
    public static class Utils {
        public static string GetRelativePath(string name) {
            name = "Data\\" + name;
            DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);
            for(int i = 0; i <= 10; i++) {
                string filePath = Path.Combine(dir.FullName, name);
                if(File.Exists(filePath))
                    return filePath;
                dir = Directory.GetParent(dir.FullName);
            }
            return string.Empty;
        }
        public static string GetRelativeDirectoryPath(string name) {
            name = "Data\\" + name;
            DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);
            while(dir != null) {
                string directoryPath = Path.Combine(dir.FullName, name);
                if(Directory.Exists(directoryPath))
                    return directoryPath;
                dir = Directory.GetParent(dir.FullName);
            }
            return string.Empty;
        }
        public static DataTable CreateDataSet(string xmlFileName) {
            string filePath = Utils.GetRelativePath(xmlFileName);
            if(!string.IsNullOrWhiteSpace(filePath)) {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(filePath);
                if(dataSet.Tables.Count > 0)
                    return dataSet.Tables[0];
            }
            return null;
        }
        public static Uri GetFileUri(string fileName) {
            return new Uri("file:\\\\" + GetRelativePath(fileName), UriKind.RelativeOrAbsolute);
        }
        public static void SetDatabasePath() {
            const string dbName = "nwind.mdb";
            const string pathToDbTag = "|pathToDb|";
            string path = GetRelativePath(dbName);
            if(String.IsNullOrEmpty(path))
                return;
            string connectionString = Properties.Settings.Default["nwindConnectionString"] as string;
            if(String.IsNullOrEmpty(connectionString))
                return;
            connectionString = connectionString.Replace(pathToDbTag, path);
            Properties.Settings.Default["nwindConnectionString"] = connectionString;
        }
    }

    public class Export {
        public string Exporter { get; set; }
        public string Importer { get; set; }
        public double Sum { get; set; }

        public Export(string from, string to, double weight) {
            this.Exporter = from;
            this.Importer = to;
            this.Sum = weight;
        }
    }

    public class PolarPoint {
        public double Radius { get; set; }
        public double Angle { get; set; }
        public double AngleDegree {
            get { return (this.Angle * 360) / (Math.PI * 2); }
            set { this.Angle = (value * 2 * Math.PI) / 360; }
        }

        public PolarPoint(double x, double y) {
            this.Radius = Math.Sqrt(x * x + y * y);
            this.Angle = Math.Atan2(y, x);
        }

        public CartesianPoint ToCartesianPoint() {
            CartesianPoint c = new CartesianPoint();
            c.X = this.Radius * Math.Cos(Angle);
            c.Y = this.Radius * Math.Sin(Angle);
            return c;
        }
    }

    public class SankeyNodeComparerItem {
        IComparer<SankeyNode> ascendingComparer;
        IComparer<SankeyNode> descendingComparer;

        public SankeyNodeComparerItem(IComparer<SankeyNode> ascendingComparer, IComparer<SankeyNode> descendingComparer) {
            this.ascendingComparer = ascendingComparer;
            this.descendingComparer = descendingComparer;
        }

        public IComparer<SankeyNode> GetComparer(bool ascending) {
            if(ascending)
                return ascendingComparer;
            return descendingComparer;
        }
    }

    public class BoolItem {
        string text;

        public bool Value { get; private set; }

        public BoolItem(string text, bool value) {
            this.text = text;
            this.Value = value;
        }
        public override string ToString() {
            return text;
        }
    }
}
