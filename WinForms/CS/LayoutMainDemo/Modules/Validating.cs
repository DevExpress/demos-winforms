using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using DevExpress.Internal;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;


namespace DevExpress.XtraLayout.Demos {
    /// <summary>
    /// Summary description for Employees.
    /// </summary>
    public partial class Validating : DevExpress.XtraLayout.Demos.TutorialControl {
        public Validating() {
            // This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog();
            InitializeComponent();
            layoutControl1.SetDefaultLayout();
            InitData();
            // TODO: Add any initialization after the InitForm call
        }
        protected override string WhatsThisXMLFileName { get { return "Validating"; } }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "Validating" }; } }
        protected override void OnVisibleChanged(object sender, EventArgs e) {
            if(Visible) {
                InitFields();
                ValidateFields();
            }
            base.OnVisibleChanged(sender, e);
        }
        private void InitData() {
            string DBFileName = DataDirectoryHelper.GetDataFile("nwind.xml");
            if(DBFileName != "")
                dsCategories1.ReadXml(DBFileName, XmlReadMode.InferSchema);
        }
        private void InitFields() {
            productNameTextEdit.Text = "";
            unitsInStockSpinEdit.EditValue = -1;
            reorderLevelSpinEdit.EditValue = -1;
            discountSpinEdit.EditValue = 0.60m;
        }
        private void ValidateFields() {
            Validate_EmptyStringRule(productNameTextEdit);
            Validate_LessThanMinRule(productsUnitPriceCalcEdit, Decimal.Zero);
            Validate_LessThanMinRule(orderUnitPriceCalcEdit, Decimal.Zero);
            Validate_LessThanMinRule(quantitySpinEdit, Decimal.Zero);
            Validate_LessThanMinRule(unitsInStockSpinEdit, Decimal.Zero);
            Validate_LessThanMinRule(reorderLevelSpinEdit, Decimal.Zero);
            Validate_LessThanMinRule(unitsOnOrderSpinEdit, Decimal.Zero);
            Validate_BetweenMinAndMaxRule(discountSpinEdit, Decimal.Zero, 0.5m);
        }
        private void checkEdit1_CheckedChanged(object sender, System.EventArgs e) {
            layoutControl1.BeginUpdate();
            productNameTextEdit.Enabled = quantityPerUnitTextEdit.Enabled = supplierLookUpEdit.Enabled = productsUnitPriceCalcEdit.Enabled = unitsInStockSpinEdit.Enabled = reorderLevelSpinEdit.Enabled = unitsOnOrderSpinEdit.Enabled = !checkEdit1.Checked;
            layoutControl1.EndUpdate();
        }
        private void Detail_Validated(object sender, System.EventArgs e) {
            ((CurrencyManager)this.BindingContext[this.dataNavigator3.DataSource, this.dataNavigator3.DataMember]).EndCurrentEdit();
        }
        //<productNameTextEdit>
        private void productNameTextEdit_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            Validate_EmptyStringRule(sender as BaseEdit);
        }
        //</productNameTextEdit>
        private void unitPriceCalcEdit_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            Validate_LessThanMinRule(sender as BaseEdit, Decimal.Zero);
        }
        //<unitsInStockSpinEdit>
        private void unitsInStockSpinEdit_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            Validate_LessThanMinRule(sender as BaseEdit, Decimal.Zero);
        }
        //</unitsInStockSpinEdit>
        //<discountSpinEdit>
        private void discountSpinEdit_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            Validate_BetweenMinAndMaxRule(sender as BaseEdit, Decimal.Zero, 0.50m);
        }
        //</discountSpinEdit>
        private void dataNavigator3_PositionChanged(object sender, System.EventArgs e) {
            ValidateFields();
        }
        private void dataNavigator2_ButtonClick_1(object sender, NavigatorButtonClickEventArgs e) {
            e.Handled = dxErrorProvider1.HasErrors;
        }
        //<productNameTextEdit>
        private void Validate_EmptyStringRule(BaseEdit control) {
            if(control.Text == null || control.Text.Trim().Length == 0) dxErrorProvider1.SetError(control, "This field can't be empty", ErrorType.Critical);
            else dxErrorProvider1.SetError(control, "");
        }
        //</productNameTextEdit>
        //<unitsInStockSpinEdit>
        private void Validate_LessThanMinRule(BaseEdit control, Decimal min) {
            if(!(control.EditValue is Decimal)) return;
            if((Decimal)control.EditValue < min) dxErrorProvider1.SetError(control, "Please enter a greater value than " + min.ToString(), ErrorType.Warning);
            else dxErrorProvider1.SetError(control, "");
        }
        //</unitsInStockSpinEdit>
        //<discountSpinEdit>
        private void Validate_BetweenMinAndMaxRule(BaseEdit control, Decimal min, Decimal max) {
            if(!(control.EditValue is Decimal)) return;
            Decimal val = (Decimal)control.EditValue;
            if((val < min)) dxErrorProvider1.SetError(control, "Please enter a greater value than " + (min * 100).ToString(), ErrorType.Warning);
            else if(val > max) dxErrorProvider1.SetError(control, "Please enter a value less than " + (max * 100).ToString(), ErrorType.Information);
            else dxErrorProvider1.SetError(control, "");
        }
        //</discountSpinEdit>
        protected override bool? UseRoundedPanel {
            get { return false; }
        }
    }
}
