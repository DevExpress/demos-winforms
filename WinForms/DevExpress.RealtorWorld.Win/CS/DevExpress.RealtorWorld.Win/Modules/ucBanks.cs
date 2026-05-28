using System.Collections.Generic;
using DevExpress.XtraCharts;
using System.Windows.Forms;
using DevExpress.Utils.Menu;

namespace DevExpress.RealtorWorld.Win {
    public partial class ucBanks : BaseModule {
        Series FRM30 { get { return ccBank.Series[0]; } }
        Series FRM15 { get { return ccBank.Series[1]; } }
        Series ARM1 { get { return ccBank.Series[2]; } }
        VisualRange VisualRangeX { get { return ((XYDiagram)ccBank.Diagram).AxisX.VisualRange; } }
        WholeRange WholeRangeX { get { return ((XYDiagram)ccBank.Diagram).AxisX.WholeRange; } }
        AxisX AxisX { get { return ((XYDiagram)ccBank.Diagram).AxisX; } }
        public override string ModuleCaption { get { return "Mortgage rates"; } }
        public ucBanks() {
            InitializeComponent();
        }
        internal override void InitModule(IDXMenuManager manager, object data) {
            base.InitModule(manager, data);
            InitData(DataHelper.MortgageRates);
            gridControl1.DataSource = DataHelper.MortgageRates;
        }
        internal override void ShowModule(object item) {
            base.ShowModule(item);
            gridView1.ExpandAllGroups();
        }
        internal override void HideModule() {
            base.HideModule();
            gridView1.HideCustomization();
        }
        void InitData(List<MortgageRate> mortgageRates) {
            ccBank.BeginInit();
            try {
                foreach (MortgageRate mortgageRate in mortgageRates) {
                    FRM30.Points.Add(new SeriesPoint(mortgageRate.Date, mortgageRate.FRM30));
                    FRM15.Points.Add(new SeriesPoint(mortgageRate.Date, mortgageRate.FRM15));
                    ARM1.Points.Add(new SeriesPoint(mortgageRate.Date, mortgageRate.ARM1));
                }
            }
            finally {
                ccBank.EndInit();
            }
            object min = AxisX.GetScaleValueFromInternal(WholeRangeX.MaxValueInternal - 80);
            VisualRangeX.SetMinMaxValues(min, WholeRangeX.MaxValue);
        }
    }
}
