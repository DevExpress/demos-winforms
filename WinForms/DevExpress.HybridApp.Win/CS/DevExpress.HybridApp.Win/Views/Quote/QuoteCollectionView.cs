using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.MVVM.UI;
using DevExpress.DevAV.ViewModels;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraEditors;
using DevExpress.Data.Filtering;
using DevExpress.Utils.MVVM;

namespace DevExpress.DevAV.Views.Quote {
    [ViewType(DevAVDbViewModel.QuoteCollectionViewDocumentType)]
    public partial class QuoteCollectionView : BaseViewWithWinUIButtons {
        public QuoteCollectionView() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode) {
                InitBinding();
            }            
        }

        private void InitBinding() {
            var fluentAPI = mvvmContext.OfType<QuoteCollectionViewModel>();

            mapView.SetViewModel(fluentAPI.ViewModel.MapViewModel);
            mapView.MapTemplate = MapExtension.CreateHomeOfficeItemForQuote;

            fluentAPI.SetObjectDataSourceBinding(quoteInfoBindingSource, x => x.Entities);
            fluentAPI.SetObjectDataSourceBinding(quoteSummaryItemBindingSource, x => x.OpportunitiesInfo);
            
            fluentAPI.WithEvent<RangeControl, RangeControlRangeEventArgs>(rangeControl, "RangeChanged")
                .SetBinding(x => x.Range, args => new DateRange((DateTime)args.Range.Minimum, (DateTime)args.Range.Maximum),
                (control, range) => control.SelectedRange = new RangeControlRange(range.Minimum, range.Maximum)
                );
            
            fluentAPI.SetBinding(dateTimeChartRangeControlClient1.DataProvider, dp => dp.DataSource, x => x.AverageQuotes);

            windowsUIButtonPanel.Buttons[0].Properties.ImageUri = ToolbarExtension.GetImageUri("PivotTable");
            windowsUIButtonPanel.Buttons[0].Properties.Tag = VisibleElement.PivotGrid;
            windowsUIButtonPanel.Buttons[1].Properties.ImageUri = ToolbarExtension.GetImageUri("MapView");
            windowsUIButtonPanel.Buttons[1].Properties.Tag = VisibleElement.MapControl;

            windowsUIButtonPanel.Buttons[0].Properties.Checked = true;
        }

        private void pivotGridControl_CustomSummary(object sender, PivotGridCustomSummaryEventArgs e) {
            switch(e.DataField.FieldName) {
                case "Percentage":
                    decimal quoteSummary = 0;
                    decimal opportunitySummary = 0;
                    foreach(PivotDrillDownDataRow row in e.CreateDrillDownDataSource()) {
                        quoteSummary += (decimal)row["Total"];
                        opportunitySummary += (decimal)row["MoneyOpportunity"];
                    }
                    if(quoteSummary != 0)
                        e.CustomValue = 100M * opportunitySummary / quoteSummary;
                    break;
            }
        }

        private void chartControl_CustomDrawSeriesPoint(object sender, XtraCharts.CustomDrawSeriesPointEventArgs e) {
            chartControl.DrawSeries(e);
        }

        private void windowsUIButtonPanel_ButtonChecked(object sender, XtraBars.Docking2010.ButtonEventArgs e) {
            VisibleElement visibleElement = (VisibleElement)e.Button.Properties.Tag;
            pivotGridControl.Visible = visibleElement == VisibleElement.PivotGrid;
            mapView.Visible = visibleElement == VisibleElement.MapControl;
        }

        public enum VisibleElement {
            PivotGrid,
            MapControl            
        }
    }
}
