using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Internal;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Html;

namespace DevExpress.XtraVerticalGrid.Demos {
    public partial class PCMarket : TutorialControl {
        public PCMarket() {
            InitializeComponent();
            InitComputersData();
            SetUpMRUFilters();
            SetUpRecordHeaderPanel();
        }
        List<ComputersData.PCConfiguration> configurations;
        void InitComputersData() {
            var dbFileName = DataDirectoryHelper.GetDataFile("Computers.xml");
            if(!string.IsNullOrEmpty(dbFileName)) {
                configurations = ComputersData.InitOrdersData(dbFileName, vGridControl1, 147000);
                ComputersData.InitEditors(vGridControl1);
            }
        }
        void SetUpMRUFilters() {
            vGridControl1.ActiveFilterString = "([ModelPrice] >= 1250 And [ModelPrice] <= 2000) And [AverageRating] >= 6 And [ProcReleaseYear] >= 2020 and [Discount] >= 0.1";
            vGridControl1.ActiveFilterString = "([ModelPrice] >= 1250 And [ModelPrice] <= 2000) And [AverageRating] >= 6";
            vGridControl1.ActiveFilterString = "[AverageRating] >= 6 And [ProcReleaseYear] >= 2020 and [Discount] >= 0.1";
        }
        void SetUpRecordHeaderPanel() {
            vGridControl1.OptionsHint.ShowRecordHeaderHints = false;
            vGridControl1.OptionsBehavior.HyperlinkClickMode = HyperlinkClickMode.Click;
            htmlCtx = new DxHtmlPainterContext();
            vGridControl1.CustomDrawRecordHeader += OnCustomDrawRecordHeader;
            vGridControl1.MouseDown += VGridControl1_MouseDown;
            vGridControl1.MouseMove += VGridControl1_MouseMove;
        }
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            vGridControl1.RecordCountChanged += OnRecordCountChanged;
            vGridControl1.FocusedRecord = 0;
            UpdateCaption(vGridControl1.RecordCount, configurations.Count);
        }
        HashSet<int> orders = new HashSet<int>();
        DxHtmlPainterContext htmlCtx;
        void VGridControl1_MouseMove(object sender, MouseEventArgs e) {
            var hitInfo = vGridControl1.CalcHitInfo(e.Location);
            int dataSourceRowIndex = vGridControl1.GetDataSourceRecordIndex(hitInfo.RecordIndex);
            vGridControl1.Cursor = htmlCtx.GetCursor(e.Location, dataSourceRowIndex);
        }
        void VGridControl1_MouseDown(object sender, MouseEventArgs e) {
            var hitInfo = vGridControl1.CalcHitInfo(e.Location);
            if(hitInfo.HitInfoType == HitInfoTypeEnum.RecordHeader) {
                int dataSourceRowIndex = vGridControl1.GetDataSourceRecordIndex(hitInfo.RecordIndex);
                var htmlHitInfo = htmlCtx.CalcHitInfo(e.Location, dataSourceRowIndex);
                if(htmlHitInfo != null && htmlHitInfo.HasId("btn-add")) {
                    if(!orders.Remove(dataSourceRowIndex))
                        orders.Add(dataSourceRowIndex);
                    vGridControl1.InvalidateRecordHeader(hitInfo.RecordIndex);
                }
            }
        }
        void OnCustomDrawRecordHeader(object sender, Events.CustomDrawRecordHeaderEventArgs e) {
            if(e.Record < 0)
                return;
            e.DefaultDraw();
            int dataSourceRowIndex = vGridControl1.GetDataSourceRecordIndex(e.Record);
            e.DrawHtml(headerTemplate, htmlCtx, (args) => {
                args.InteractivityKey = dataSourceRowIndex;
                bool isAddedToCart = orders.Contains(dataSourceRowIndex);
                args.SetFieldValue("Added", isAddedToCart);
                args.SetFieldValue("AddButtonCaption", isAddedToCart ? "ADDED TO CART" : "ADD TO CART");
            });
        }
        void OnRecordCountChanged(object sender, System.EventArgs e) {
            UpdateCaption(vGridControl1.RecordCount, configurations.Count);
        }
        void UpdateCaption(int visible, int total) {
            this.vGridControl1.Caption = string.Format("Showing {0:n0} out of {1:n0} configurations", visible, total);
        }
    }
}
