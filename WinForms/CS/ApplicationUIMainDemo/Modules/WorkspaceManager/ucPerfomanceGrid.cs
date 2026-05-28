namespace DevExpress.ApplicationUI.Demos {
    public partial class ucPerfomanceGrid : XtraEditors.XtraUserControl {
        public ucPerfomanceGrid() {
            InitializeComponent();
            gridControl1.DataSource = DataLoader.LoadPerformanceReport();
        }
    }
}
