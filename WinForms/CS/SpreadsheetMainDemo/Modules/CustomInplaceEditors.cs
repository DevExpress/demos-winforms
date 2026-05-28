using System;
using DevExpress.Spreadsheet;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class CustomInplaceEditors : SpreadSheetTutorialControlBase {
        public CustomInplaceEditors() {
            InitializeComponent();
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("CustomInplaceEditors_template.xlsx"));
            spreadsheetControl1.CustomCellEdit += SpreadsheetControl1_CustomCellEdit;
            BindCustomEditors();
        }

        private void BindCustomEditors() {
            Worksheet sheet = spreadsheetControl1.Document.Worksheets["Sales report"];

            CellRange dateEditRange = sheet["Table[Order Date]"];
            sheet.CustomCellInplaceEditors.Add(dateEditRange, CustomCellInplaceEditorType.DateEdit);

            CellRange comboBoxRange = sheet["Table[Category]"];
            sheet.CustomCellInplaceEditors.Add(comboBoxRange, CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(sheet["J3:J9"]));

            CellRange checkBoxRange = sheet["Table[Discount]"];
            sheet.CustomCellInplaceEditors.Add(checkBoxRange, CustomCellInplaceEditorType.CheckBox);

            CellRange customRange = sheet["Table[Qty]"];
            sheet.CustomCellInplaceEditors.Add(customRange, CustomCellInplaceEditorType.Custom, "MySpinEdit");
        }

        private void SpreadsheetControl1_CustomCellEdit(object sender, SpreadsheetCustomCellEditEventArgs e) {
            if(e.ValueObject.IsText && e.ValueObject.TextValue == "MySpinEdit") {
                RepositoryItemSpinEdit editor = new RepositoryItemSpinEdit {
                    AutoHeight = false,
                    BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder,
                    MinValue = 1,
                    MaxValue = 1000,
                    IsFloatValue = false
                };
                e.RepositoryItem = editor;
            }
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            ribbonControl1.SelectedPage = homeRibbonPage1;
        }
    }
}
