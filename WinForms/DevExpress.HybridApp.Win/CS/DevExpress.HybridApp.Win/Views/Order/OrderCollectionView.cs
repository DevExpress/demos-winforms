using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM.UI;
using DevExpress.DevAV.ViewModels;
using DevExpress.XtraCharts;
using DevExpress.XtraBars.Docking2010;
using DevExpress.Utils.MVVM.Services;

namespace DevExpress.DevAV.Views {
    [ViewType(DevAVDbViewModel.OrderCollectionViewDocumentType)]
    public partial class OrdersView : BaseViewWithWinUIButtons {
        public OrdersView() {
            InitializeComponent();
            layoutControl.SetupLayoutControl();
            leftLayoutControl.SetupLayoutControl();
            rightLayoutControl.SetupLayoutControl();
            salesGridView.SetupCollectionGrid();
            salesGridView.OptionsView.ShowFooter = false;
            SetupChart();
            searchControl.SetupSearchControl(windowsUIButtonPanel);
            if (!mvvmContext.IsDesignMode) {
                InitBindings();
            }
           
        }
        void SetupChart() {
            chartControl.Series[0].ValueDataMembers.AddRange(new string[] { "Value" });
            chartControl.CustomDrawSeriesPoint += (s, e) => chartControl.DrawSeries(e);
        }
        void InitBindings() {
            mvvmContext.RegisterService(PrintableControlPreviewService.Create(salesGridControl));
            mvvmContext.BindCollectionGrid<OrderCollectionViewModel, Order>(salesGridView, salesBindingSource);
            var fluentAPI = mvvmContext.OfType<OrderCollectionViewModel>();
            fluentAPI.SetBinding(dateTimeChartRangeControlClient.DataProvider, d => d.DataSource, x => x.Entities);
            fluentAPI.SetBinding(salesLookUpEdit.Properties, r => r.DataSource, x => x.Sales);
            fluentAPI.SetBinding(salesLookUpEdit, r => r.EditValue, x => x.SelectedListProductInfo, x => fluentAPI.ViewModel.Sales.Where(s => s.ListProductInfo == x).FirstOrDefault(), val => (val as SalesInfo).ListProductInfo);
            fluentAPI.SetBinding(chartControl.Series[0], c => c.DataSource, x => x.SelectedListProductInfo);
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[0] as WindowsUIButton, (x, e) => x.Edit(e), x => x.SelectedEntity);
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[2] as WindowsUIButton, x => x.Print());
            fluentAPI.WithEvent<RangeControl, RangeControlRangeEventArgs>(rangeControl1, "RangeChanged")
               .SetBinding(x => x.DateRange,
                   args => new DateRange(Convert.ToDateTime(args.Range.Minimum), Convert.ToDateTime(args.Range.Maximum)),
                   (rangeControl, range) =>
                   {
                     rangeControl.SelectedRange = new RangeControlRange(range.Minimum, range.Maximum);
                   });
            fluentAPI.SetBinding(salesGridView, view => view.ActiveFilterCriteria, x => x.DateRange, range => ConverterExtensions.ConvertEditRangeToFilterCriteria(range, "OrderDate"));
        }
    }
}
