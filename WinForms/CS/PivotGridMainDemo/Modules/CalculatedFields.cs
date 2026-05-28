using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class CalculatedFields : DevExpress.XtraPivotGrid.Demos.TutorialControl {
        PivotGridField hoverField = null;

        public CalculatedFields() {
            // This call is required by the Windows Form Designer.
            CreateWaitDialog();
            InitializeComponent();

            pivotGridControl.BeginUpdate();

            fieldYear.FilterValues.SetValues(new object[] { 2015 }, PivotFilterType.Included, false);

            checkExpression.Checked = true;

            SetUpYearEndBonus();
            SetUpQuantityBonus();

            pivotGridControl.EndUpdate();
        }
        public override PivotGridControl ViewOptionsControl {
            get { return pivotGridControl; }
        }
        public override PivotGridControl ExportControl {
            get { return pivotGridControl; }
        }
        void CalculatedFields_Load(object sender, System.EventArgs e) {
            pivotGridControl.DataSource = GetData();
            pivotGridControl.HeaderImages = HeadersImageList;
            fieldSalesPerson.ImageIndex = 0;
        }
        List<SalesDataRow> GetData() {
            Dictionary<int, DataRowView> orders = GetNWindData("Orders").Cast<DataRowView>().ToDictionary(s => (int)s["OrderID"], s => s);
            Dictionary<int, DataRowView> employees = GetNWindData("Employees").Cast<DataRowView>().ToDictionary(s => (int)s["EmployeeID"], s => s);
            return GetNWindData("Order Details").Cast<DataRowView>().Select(s => CreateSalesDataRow(s, orders, employees)).ToList();
        }

        static SalesDataRow CreateSalesDataRow(DataRowView order, Dictionary<int, DataRowView> orders, Dictionary<int, DataRowView> employees) {
            int orderId = (int)order["OrderID"];
            int employeeID = (int)orders[orderId]["EmployeeID"];
            DataRowView employee = employees[employeeID];

            return new SalesDataRow {
                OrderID = (int)order["OrderID"],
                UnitPrice = (decimal)order["UnitPrice"],
                Quantity = (short)order["Quantity"],

                OrderDate = (DateTime)orders[orderId]["OrderDate"],

                LastName = (string)employee["LastName"],
                FirstName = (string)employee["FirstName"],
                EmployeeID = (int)employee["EmployeeID"],
            };
        }

        public class SalesDataRow {
            public int EmployeeID { get; set; }
            public int OrderID { get; set; }
            public decimal UnitPrice { get; set; }
            public short Quantity { get; set; }
            public DateTime OrderDate { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        //<checkDataSourceValue>
        void checkDataSourceValueOnCheckedChanged(object sender, EventArgs e) {
            if(!checkDataSourceValue.Checked)
                return;
            fieldSalesPerson.DataBinding = new DataSourceColumnBinding("EmployeeID");
            pivotGridControl.RefreshData();
        }
        //</checkDataSourceValue>
        //<checkDisplayText>
        void checkDisplayTextOnCheckedChanged(object sender, EventArgs e) {
            if(!checkDisplayText.Checked)
                return;
            fieldSalesPerson.DataBinding = new DataSourceColumnBinding("EmployeeID");
            pivotGridControl.RefreshData();
        }
        void pivotGridControlOnFieldValueDisplayText(object sender, PivotFieldDisplayTextEventArgs e) {
            if(!checkDisplayText.Checked)
                return;
            if(e.Field == fieldSalesPerson) {
                PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
                e.DisplayText = string.Format("{0} {1} ({2})", ds[0]["FirstName"], ds[0]["LastName"], e.Value.ToString());
            }
        }
        //</checkDisplayText>
        //<checkExpression>
        void checkExpressionOnCheckedChanged(object sender, EventArgs e) {
            if(!checkExpression.Checked)
                return;
            fieldSalesPerson.DataBinding = new ExpressionDataBinding(string.Format("Concat([{0}], ' ', [{1}], ' (', [{2}], ')')", fieldFirstName.Name, fieldLastName.Name, fieldEmployeeID.Name));
            fieldSalesPerson.Options.ShowExpressionEditorMenu = true;
            fieldSalesPerson.FieldName = "4";
            pivotGridControl.RefreshData();
        }
        //</checkExpression>
        //<checkYearEndBonus>
        void SetUpYearEndBonus() {
            fieldYearEndBonus.Options.ShowExpressionEditorMenu = true;
            checkYearEndBonus.Checked = true;
        }
        void checkYearEndBonusOnCheckedChanged(object sender, EventArgs e) {
            fieldYearEndBonus.Visible = checkYearEndBonus.Checked;
            if(fieldYearEndBonus.Visible)
                fieldYearEndBonus.DataBinding = new ExpressionDataBinding(string.Format("Iif( Max([{0}]) == 4 And Min([{0}]) == 4, Iif(Sum([{1}]) > 40000, 600, 400), 0)", fieldQuarter.Name, fieldExtendedPrice.Name));
            else
                fieldYearEndBonus.DataBinding = new ExpressionDataBinding("0");
        }
        //</checkYearEndBonus>
        //<checkQuantityBonus>
        void SetUpQuantityBonus() {
            fieldQuantityBonus.Options.ShowExpressionEditorMenu = true;
            checkQuantityBonus.Checked = true;
        }
        void checkQuantityBonusOnCheckedChanged(object sender, EventArgs e) {
            fieldQuantityBonus.Visible = checkQuantityBonus.Checked;
            if(fieldQuantityBonus.Visible)
                fieldQuantityBonus.DataBinding = new ExpressionDataBinding(string.Format("Iif([{0}] > 100, [{1}] * 0.1, 0)", fieldQuantity.Name, fieldExtendedPrice.Name));
            else
                fieldQuantityBonus.DataBinding = new ExpressionDataBinding("0");
        }
        //</checkQuantityBonus>
        //<pivotGridControl>
        void pivotGridControlOnCellDoubleClick(object sender, PivotCellEventArgs e) {
            try {
                using(DrillDownForm form = new DrillDownForm(e.CreateDrillDownDataSource())) {
                    form.ShowDialog();
                }
            }
            catch(Exception ex) {
                XtraMessageBox.Show(ex.Message);
            }
        }
        //</pivotGridControl>
        //<btnAddBonus>
        void buttonAddNewBonusOnClick(object sender, EventArgs e) {
            using(AddNewBonus addNewBonus = new AddNewBonus()) {
                addNewBonus.PivotGrid = pivotGridControl;
                addNewBonus.ShowDialog();
            }
        }
        //</btnAddBonus>

        bool NeedHighlightField(PivotGridField field) {
            if(field != null && field.DataBinding is ExpressionDataBinding && field.Options.ShowExpressionEditorMenu)
                return true;
            return false;
        }
        void pivotGridControlOnMouseMove(object sender, MouseEventArgs e) {
            PivotGridHitInfo info = pivotGridControl.CalcHitInfo(new Point(e.X, e.Y));
            if(info.ValueInfo != null && NeedHighlightField(info.ValueInfo.Field) && info.ValueInfo.Field.Area == PivotArea.DataArea) {
                hoverField = info.ValueInfo.Field;
                pivotGridControl.Cursor = Cursors.Hand;
            }
            else if(info.HitTest == PivotGridHitTest.HeadersArea && NeedHighlightField(info.HeaderField)) {
                hoverField = info.HeaderField;
                pivotGridControl.Cursor = Cursors.Hand;
            }
            else {
                hoverField = null;
                pivotGridControl.Cursor = Cursors.Default;
            }
            pivotGridControl.Invalidate();
        }
        void pivotGridControlOnCustomDrawFieldValue(object sender, PivotCustomDrawFieldValueEventArgs e) {
            if(NeedHighlightField(e.Field) && e.Field.Area == PivotArea.DataArea) {
                if(e.Field == hoverField)
                    e.Appearance.FontStyleDelta = FontStyle.Underline | FontStyle.Bold;
                else
                    e.Appearance.FontStyleDelta = FontStyle.Bold;
            }
            else e.DefaultDraw();
        }
        void pivotGridControlOnCustomDrawFieldHeader(object sender, PivotCustomDrawFieldHeaderEventArgs e) {
            if(NeedHighlightField(e.Field)) {
                if(e.Field == hoverField)
                    e.Appearance.FontStyleDelta = FontStyle.Underline | FontStyle.Bold;
                else
                    e.Appearance.FontStyleDelta = FontStyle.Bold;
            }
            else e.DefaultDraw();
        }
        void pivotGridControlOnMouseClick(object sender, MouseEventArgs e) {
            if(e.Button != MouseButtons.Left)
                return;
            PivotGridHitInfo info = pivotGridControl.CalcHitInfo(new Point(e.X, e.Y));
            if(info.ValueInfo != null && NeedHighlightField(info.ValueInfo.Field) && info.ValueInfo.Field.Area == PivotArea.DataArea)
                pivotGridControl.ShowExpressionEditor(info.ValueInfo.Field);
            else if(NeedHighlightField(info.HeaderField))
                pivotGridControl.ShowExpressionEditor(info.HeaderField);
        }
        void pivotGridControlOnPopupMenuShowing(object sender, PopupMenuShowingEventArgs args) {
            if(args.HitInfo.ValueInfo != null) {
                PivotGridField removedField = args.HitInfo.ValueInfo.Field;
                if(removedField != null && Equals(removedField.Tag, "removable")) {
                    DXMenuItem item = new DXMenuItem("Remove this bonus");
                    item.Click += (s, e) => {
                        pivotGridControl.Fields.Remove(removedField);
                    };
                    item.BeginGroup = true;
                    args.Menu.Items.Add(item);
                }
            }
        }
    }
}
