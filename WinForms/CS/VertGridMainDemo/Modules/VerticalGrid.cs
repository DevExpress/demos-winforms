using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Internal;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid.StyleFormatConditions;

namespace DevExpress.XtraVerticalGrid.Demos {
    public partial class VerticalGrid : TutorialControl {
        public VerticalGrid() {
            InitializeComponent();
            InitVehiclesData();
            vGridControl.ActiveFilterString = DemoFilterString;
            vGridControl.MRUFilters.Add(new VGridFilterInfo("([ModelPrice] >= 50000 And [ModelPrice] <= 150000)"));
            vGridControl.MRUFilters.Add(new VGridFilterInfo("IsOutlookIntervalToday([SalesDate]) Or IsOutlookIntervalYesterday([SalesDate])"));
            vGridControl.MRUFilters.Add(new VGridFilterInfo("([ModelPrice] >= 40000 And [ModelPrice] <= 100000)"));
            vGridControl.MRUFilters.Add(new VGridFilterInfo("[SalesDate] > AddDays(LocalDateTimeToday(), -25)"));
            CreateFormatConditionRule();
            LicenseInfo.SetToolTipController(this, vGridControl);
        }
        string DemoFilterString {
            get {
                string extFilter = MainFormHelper.TakeScreens ? ")" : " And (IsOutlookIntervalToday([SalesDate]) Or IsOutlookIntervalYesterday([SalesDate]))";
                return $"([ModelPrice] >= 40000 And [ModelPrice] <= 100000){extFilter}";
            }
        }
        void CreateFormatConditionRule() {
            var iconRuleForMPGCity = new VGridFormatRule();
            iconRuleForMPGCity.Rule = CreateFormatConditionRuleIconSet();
            iconRuleForMPGCity.RowProperties = merpMPGCity;

            var iconRuleForMPGHighway = new VGridFormatRule();
            iconRuleForMPGHighway.Rule = CreateFormatConditionRuleIconSet();
            iconRuleForMPGHighway.RowProperties = merpMPGHighway;

            var dataBarRule = new VGridFormatRule();
            dataBarRule.Rule = CreateFormatConditionRuleDataBar();
            dataBarRule.RowProperties = erModelPrice.Properties;

            var iconRuleForDiscount = new VGridFormatRule();
            iconRuleForDiscount.Rule = CreateFormatConditionRuleStarsSet();
            iconRuleForDiscount.RowProperties = erDiscount.Properties;

            vGridControl.FormatRules.BeginUpdate();
            vGridControl.FormatRules.Add(iconRuleForMPGCity);
            vGridControl.FormatRules.Add(iconRuleForMPGHighway);
            vGridControl.FormatRules.Add(dataBarRule);
            vGridControl.FormatRules.Add(iconRuleForDiscount);
            vGridControl.FormatRules.EndUpdate();
        }
        FormatConditionRuleIconSet CreateFormatConditionRuleIconSet() {
            var ruleIconSet = new FormatConditionRuleIconSet();
            ruleIconSet.IconSet = new FormatConditionIconSet();
			var iconSet = ruleIconSet.IconSet;
            var icon1 = new FormatConditionIconSetIcon();
            var icon2 = new FormatConditionIconSetIcon();
            var icon3 = new FormatConditionIconSetIcon();
            icon1.PredefinedName = "Arrows3_3.png";
            icon2.PredefinedName = "Arrows3_2.png";
            icon3.PredefinedName = "Arrows3_1.png";
            iconSet.ValueType = FormatConditionValueType.Number;

            icon1.Value = 0;
            icon1.ValueComparison = FormatConditionComparisonType.Greater;
            icon2.Value = 15;
            icon2.ValueComparison = FormatConditionComparisonType.Greater;
            icon3.Value = 20;
            icon3.ValueComparison = FormatConditionComparisonType.Greater;

            iconSet.Icons.Add(icon1);
            iconSet.Icons.Add(icon2);
            iconSet.Icons.Add(icon3);
            return ruleIconSet;
        }
        FormatConditionRuleIconSet CreateFormatConditionRuleStarsSet() {
            var ruleIconSet = new FormatConditionRuleIconSet();
			ruleIconSet.IconSet = new FormatConditionIconSet();
            var iconSet = ruleIconSet.IconSet;
            var icon1 = new FormatConditionIconSetIcon();
            var icon2 = new FormatConditionIconSetIcon();
            var icon3 = new FormatConditionIconSetIcon();
            icon1.PredefinedName = "Stars3_3.png";
            icon2.PredefinedName = "Stars3_2.png";
            icon3.PredefinedName = "Stars3_1.png";

            iconSet.ValueType = FormatConditionValueType.Number;

            icon1.Value = 0;
            icon1.ValueComparison = FormatConditionComparisonType.GreaterOrEqual;
            icon2.Value = 0.05m;
            icon2.ValueComparison = FormatConditionComparisonType.GreaterOrEqual;
            icon3.Value = 0.15m;
            icon3.ValueComparison = FormatConditionComparisonType.GreaterOrEqual;

            iconSet.Icons.Add(icon1);
            iconSet.Icons.Add(icon2);
            iconSet.Icons.Add(icon3);
            return ruleIconSet;
        }
        FormatConditionRuleDataBar CreateFormatConditionRuleDataBar() {
            var formatConditionRuleDataBar = new FormatConditionRuleDataBar();
            formatConditionRuleDataBar.PredefinedName = "Green";
            formatConditionRuleDataBar.AutomaticType = FormatConditionAutomaticType.ZeroBased;
            return formatConditionRuleDataBar;
        }
        void InitVehiclesData() {
            string dbFileName = DataDirectoryHelper.GetDataFile("Vehicles.xml");
            if(!string.IsNullOrEmpty(dbFileName))
                InitXMLData(dbFileName);
        }
        protected override void InitXMLData(string xmlFileName) {
            VehiclesData.InitOrdersData(xmlFileName, vGridControl, 1000, 40);
            VehiclesData.InitEditors(vGridControl);
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            vGridControl.FocusedRecord = 0;
        }
        // Addding custom Filters and Data Items customization
        void vGridControl_FilterPopupExcelData(object sender, FilterPopupExcelDataEventArgs e) {
            // Adding custom Filters
            string fieldName = e.Column.FieldName;
            if(e.Column == erModification.Properties) {
                // Filter Items
                e.AddFilter("Automatic Transmission (6-speed)", "Contains([" + fieldName + "], '6A')", true);
                e.AddFilter("Automatic Transmission (8-speed)", "Contains([" + fieldName + "], '8A')", true);
                e.AddFilter("Manual Transmission (6-speed)", "Contains([" + fieldName + "], '6M')", true);
                e.AddFilter("Manual Transmission (7-speed)", "Contains([" + fieldName + "], '7M')", true);
                e.AddFilter("Variomatic Transmission", "Contains([" + fieldName + "], 'VA')", true);
                e.AddFilter("<b>Limited Edition</b>", "Contains([" + fieldName + "], 'Limited')", true);
                // Data Items
                foreach(var item in e.DataItems) {
                    if(item.Text.Contains("V6"))
                        item.HtmlText = item.Text.Replace("V6", "<b>V6</b>");
                    if(item.Text.Contains("V8"))
                        item.HtmlText = item.Text.Replace("V8", "<b>V8</b>");
                    if(item.Text.Contains("Limited"))
                        item.HtmlText = "<nbsp>" + item.Text;
                }
            }
            if(e.Column == merpMPGCity) { // 12-28
                e.AddFilter("Fuel Economy (<color=green>High</color>)", "[" + fieldName + "]>25", true);
                e.AddFilter("Fuel Economy (<color=orange>Medium</color>)", "[" + fieldName + "]>=15 AND [" + fieldName + "]<=25", true);
                e.AddFilter("Fuel Economy (<color=red>Low</color>)", "[" + fieldName + "]<15", true);
            }
            if(e.Column == merpMPGHighway) { // 15-36
                e.AddFilter("Fuel Economy (<color=green>High</color>)", "[" + fieldName + "]>30", true);
                e.AddFilter("Fuel Economy (<color=orange>Medium</color>)", "[" + fieldName + "]>=20 AND [" + fieldName + "]<=30", true);
                e.AddFilter("Fuel Economy (<color=red>Low</color>)", "[" + fieldName + "]<20", true);
            }
        }
        protected VGridControl Grid {
            get { return vGridControl; }
        }
        void OnGridCellValueChanged(object sender, Events.CellValueChangedEventArgs e) {
            if(e.Row == erModelPrice)
                maxPriceCore = null;
            if(e.Row == erDiscount)
                maxDiscountCore = null;
        }
        decimal? maxPriceCore;
        protected decimal MaxPrice {
            get {
                if(!maxPriceCore.HasValue) {
                    var orderItems = ((List<VehiclesData.OrderItem>)vGridControl.DataSource);
                    maxPriceCore = orderItems.Max(x => x.ModelPrice);
                }
                return maxPriceCore.Value;
            }
        }
        double? maxDiscountCore;
        protected double MaxDiscount {
            get {
                if(!maxDiscountCore.HasValue) {
                    var orderItems = ((List<VehiclesData.OrderItem>)vGridControl.DataSource);
                    maxDiscountCore = orderItems.Max(x => x.Discount);
                }
                return maxDiscountCore.Value;
            }
        }
    }
}
