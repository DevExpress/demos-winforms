using System.Drawing;
using DevExpress.Data.Filtering;
using DevExpress.Utils;
using DevExpress.XtraEditors.Filtering;

namespace DevExpress.XtraCharts.Demos {
    public partial class DataFilteringDemo : ChartDemoModule {
        internal override ChartControl ChartControl { get { return chart; } }

        readonly ImageCollection images = new ImageCollection();
        public DataFilteringDemo() {
            InitializeComponent();
            images.ImageSize = ScaleUtils.ScaleValue(new Size(12, 12));
            chart.DataSource = DevAV.GetBranchesSalesList();
            int lastYear = DevAV.GetLastYear();
            ((SeriesTemplateAdapter)chart.SeriesTemplate.DataAdapter).FilterCriteria = new GroupOperator(
                new BinaryOperator("Year", lastYear - 2, BinaryOperatorType.GreaterOrEqual),
                new BinaryOperator("Year", lastYear, BinaryOperatorType.LessOrEqual));
            DevAV.InitializeCompanyImages(images, GetColorByCompanyName);
            filteringUIContext.RetrieveFields();
        }
        protected override void OnPaletteChanged() {
            DevAV.UpdateCompanyImages(images, GetColorByCompanyName);
            filteringUIContext.UpdateMemberBindings();
        }
        Color GetColorByCompanyName(string name) {
            SeriesKeyColorColorizer seriesColorizer = chart.SeriesTemplate.SeriesColorizer as SeriesKeyColorColorizer;
            if(seriesColorizer == null)
                return Color.Empty;
            Palette palette = chart.PaletteRepository[chart.PaletteName];
            return seriesColorizer.GetSeriesColor(name, palette);
        }
        // Filtering UI Customization
        void filteringUIContext_QueryLookupData(object sender, DevExpress.Utils.Filtering.QueryLookupDataEventArgs e) {
            if(e.PropertyPath == "Company")
                e.WithDataItems(PrepareHtmlText);
        }
        void PrepareHtmlText(DataItemsExtension.DataItems dataItems) {
            foreach(ExcelFilterDataItem item in dataItems) {
                string companyName = (string)item.Value;
                item.HtmlText = "<image=" + companyName + "><nbsp>" + item.Text;
            }
            dataItems.HtmlImages = images;
        }
    }
}
