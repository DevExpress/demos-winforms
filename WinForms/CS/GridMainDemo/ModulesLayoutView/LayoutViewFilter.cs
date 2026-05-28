using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DevExpress.Utils.Filtering;

namespace DevExpress.XtraGrid.Demos {
    public partial class LayoutViewFilter : BaseLayoutModule {
        public LayoutViewFilter() {
            CreateWaitDialog();
            InitializeComponent();
            InitVehiclesData();
            LicenseInfo.SetToolTipController(this, gridControl);
        }
        #region Demo Settings
        protected override bool FluentScrollBars {
            get { return true; }
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "LayoutViewFilter" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "FilteringUI"; }
        }
        #endregion Demo Settings
        List<VehiclesData.Model> models;
        List<VehiclesData.Trademark> trademarks;
        protected override void InitXMLData(string dataFileName) {
            VehiclesData.InitXMLDataAndCreateEditors(dataFileName, gridControl, out models, out trademarks);
            // Bind grid to data
            modelBindingSource.DataSource = models;

            //<accordionControl>
            // Bind the LayoutView.ActiveFilterCriteria to FilteringUIContext.FilterCriteria (two-way)
            filteringUIContext.SetFilterCriteriaBinding(layoutView);
            // Retrieving the Filtering UI editors into the AccordionControl
            filteringUIContext.RetrieveFields();
            //</accordionControl>

            //<filterPanel>
            // Bind the LayoutView.ActiveFilterCriteria to FilterPanelControl.FilterCriteria (two-way)
            filterPanel.SetFilterCriteriaBinding(layoutView);
            // Setup initial filter
            layoutView.ActiveFilterString = "InRange([Price], 40000, 100000) And [Category] In (1,2)";
            //</filterPanel>
            accordionControl.ExpandAll();
        }
        #region Obtaining required additional data for Filtering UI editors
        //<accordionControl>
        void filteringUIContext_QueryRangeData(object sender, QueryRangeDataEventArgs e) {
            if(e.PropertyPath == "Price") {
                e.Result.Minimum = models.Min(m => m.Price);
                e.Result.Maximum = models.Max(m => m.Price);
            }
        }
        void filteringUIContext_QueryLookupData(object sender, QueryLookupDataEventArgs e) {
            if(e.PropertyPath == "Trademark")
                e.Result.DataSource = trademarks;
        }
        //</accordionControl>
        #endregion
    }
    #region Metadata For Filtering Model
    //<accordionControl>
    public class FilteringModel {
        const string Main = "Main Parameters";
        [Display(GroupName = Main)]
        [FilterLookup(10, ValueMember = "ID", DisplayMember = "Name")]
        public int Trademark { get; set; }
        [Display(Name = "Model Available", GroupName = Main)]
        [FilterBooleanChoice(false)]
        public bool InStock { get; set; }
        [Display(GroupName = Main)]
        [FilterRange(0, 170000), DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Display(GroupName = Main)]
        [EnumDataType(typeof(VehiclesData.Category))]
        public int Category { get; set; }
    }
    //</accordionControl>
    #endregion
}
