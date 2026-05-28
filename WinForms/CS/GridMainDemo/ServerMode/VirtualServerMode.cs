using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DevExpress.Data;
using DevExpress.Data.Linq;
using DevExpress.Data.Linq.Helpers;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos {
    public partial class VirtualServerMode : TutorialControl {
        //<sbRefresh>
        static int RowCount = 1000000;
        static int BatchCount = 250;
        //</sbRefresh>

        static List<VehiclesData.Model> models = null;
        protected override void InitXMLData(string dataFileName) {
            models = VehiclesData.InitOrdersVirtualData(dataFileName, gridControl1);
            VehiclesData.InitColumnViewEditors(bandedGridView1);
        }
        public VirtualServerMode() {
            InitializeComponent();
            InitVehiclesData();
            seRowCount.Value = RowCount;
            seBatchCount.Value = BatchCount;
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "VirtualServerMode" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "VirtualServerMode"; }
        }
        //<gridControl1>
        static IEnumerable<VehiclesData.OrderItem> GetItems(VirtualServerModeConfigurationInfo configuration) {
            var allOrderItems = Enumerable.Range(0, RowCount).Select(i =>
                    new VehiclesData.OrderItem(RowCount, models, i + 1)
                ).AsQueryable();
            var converter = new CriteriaToExpressionConverterForObjects();
            // Applying Filter
            var items = allOrderItems.
                AppendWhere(converter, configuration.Filter);
            // Applying Sorting
            if(configuration.SortInfo != null && configuration.SortInfo.Length > 0)
                items = items.MakeOrderBy(converter, configuration.SortInfo);
            return items.Cast<VehiclesData.OrderItem>();
        }

        void virtualServerModeSource1_ConfigurationChanged(object sender, Data.VirtualServerModeRowsEventArgs e) {
            var enumerator = GetItems(e.ConfigurationInfo).GetEnumerator();
            e.UserData = enumerator;
        }

        void virtualServerModeSource1_MoreRows(object sender, Data.VirtualServerModeRowsEventArgs e) {
            e.RowsTask = System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                var enumerator = e.UserData as IEnumerator<VehiclesData.OrderItem>;
                var nextBatch = new List<VehiclesData.OrderItem>();
                bool moreRows = true;
                while(nextBatch.Count < BatchCount) {
                    if(nextBatch.Count % 10 == 0) {
                        Thread.Sleep(4);
                        //uncomment the following code to process cancellation requests
                        //e.CancellationToken.ThrowIfCancellationRequested();
                    }
                    if(enumerator.MoveNext())
                        nextBatch.Add(enumerator.Current);
                    else {
                        enumerator = null;
                        moreRows = false;
                        break;
                    }
                }
                return new VirtualServerModeRowsTaskResult(nextBatch, moreRows, enumerator);
            }, e.CancellationToken);
        }
        void virtualServerModeSource1_GetUniqueValues(object sender, VirtualServerModeGetUniqueValuesEventArgs e) {
            e.UniqueValuesTask = new System.Threading.Tasks.Task<object[]>(() =>
            {
                switch(e.ValuesPropertyName) {
                    case "ModelPrice":
                        return new object[] { 15000m, 150000m };
                    case "Discount":
                        return new object[] { 0.00, 0.05, 0.10, 0.15 };
                    case "SalesDate":
                        DateTime today = TutorialConstants.Today;
                        DateTime sevenYearsAgo = new DateTime(today.Year - 7, 1, 1);
                        int totalDays = (int)Math.Ceiling(today.Subtract(sevenYearsAgo).TotalDays);
                        object[] days = new object[totalDays];
                        for(int i = 0; i < days.Length; i++) 
                            days[i] = sevenYearsAgo.AddDays(i);
                        return days;
                    case "Trademark":
                        return models.Select(m => m.Trademark).Distinct().Cast<object>().ToArray();
                    case "Name":
                        return models.Select(m => m.Name).Distinct().Cast<object>().ToArray();
                    case "Modification":
                        return models.Select(m => m.Modification).Distinct().Cast<object>().ToArray();
                    default:
                        return null;
                }
            }, e.CancellationToken);
        }
        //</gridControl1>

        //<sbRefresh>
        void sbRefresh_Click(object sender, EventArgs e) {
            RowCount = (int)seRowCount.Value;
            BatchCount = (int)seBatchCount.Value;
            gridControl1.RefreshDataSource();
        }
        //</sbRefresh>
    }
}
