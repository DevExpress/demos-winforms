using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using DevExpress.Utils;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("Validation", "Validation.cs")]
    public static class Validation {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GridControl gridControl = new GridControl();
            GridView gridView = new GridView();
            gridControl.MainView = gridView;
            gridControl.Dock = DockStyle.Fill;
            gridControl.Parent = sampleHost;
            gridControl.DataSource = SampleData.GetData(5);
            return new object[] { gridControl, gridView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as GridControl).Dispose();
        }

        #region Helpers
        [CodeExampleNestedClass("")]
        public static class DemoHelper {
            public static Icon GetIcon() {
                return ResourceImageHelper.CreateIconFromResources("DevExpress.XtraGrid.Demos.AppIcon.ico", typeof(DevExpress.XtraGrid.Demos.frmMain).Assembly);
            }
        }
        #endregion


        #region Validation
        [CodeExampleCase("Validate the active editor’s value"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ValidatingEditor", "ErrorText", "Valid", "InvalidValueException", "ErrorText")]
        public static void ValidatingEditor(GridControl gridControl, GridView gridView) {
            // Handle this event to perform manual validation of an in-place active editor or the EditForm's active editor 
            gridView.ValidatingEditor += (s, e) => {
                string fieldName = string.Empty;
                GridView view = s as GridView;
                EditFormValidateEditorEventArgs ea = e as EditFormValidateEditorEventArgs;
                if (ea == null)
                    fieldName = view.FocusedColumn.FieldName;
                else
                    fieldName = ea.Column.FieldName;

                if (fieldName == "ID")
                    e.Valid = !(Convert.ToInt32(e.Value) < 0);
                else if (fieldName == "Notes")
                    e.Valid = !(string.IsNullOrEmpty(Convert.ToString(e.Value)));

                e.ErrorText = "The entered value is invalid (ValidatingEditor)";
            };

            // Provide a custom response when an invalid cell value is entered
            gridView.InvalidValueException += (s, e) => {
                // The ExceptionMode parameter controls the actual response to the error
                e.ExceptionMode = ExceptionMode.DisplayError;
            };

            ComboBoxEdit editingModesComboBox = new ComboBoxEdit { Parent = gridControl.Parent, Dock = DockStyle.Top };
            editingModesComboBox.Properties.Items.AddRange(Enum.GetValues(typeof(GridEditingMode)));
            //Use the GridOptionsBehavior.EditingMode property to switch from the default in-place edit mode to the Edit Form
            editingModesComboBox.DataBindings.Add(new Binding("EditValue", gridView.OptionsBehavior, "EditingMode", false, DataSourceUpdateMode.OnPropertyChanged));
            editingModesComboBox.EditValue = GridEditingMode.EditForm;
            LabelControl editingModesComboBoxLabel = new LabelControl { Text = "EditingMode", Dock = DockStyle.Top, Parent = gridControl.Parent };
        }

        [CodeExampleCase("Validate row data on losing focus"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ValidateRow", "ErrorText", "InvalidRowException", "ExceptionMode", "Valid")]
        public static void ValidateRow(GridControl gridControl, GridView gridView) {            
            // You can handle the event to specify whether row data is valid. 
            // The event fires if a row was modified and is about to lose focus.
            gridView.ValidateRow += (s, e) => {
                SampleData obj = e.Row as SampleData;
                if (obj.Length <= 0) {
                    e.Valid = false;
                    e.ErrorText = string.Format("Length cannot be less than or equal to zero. Please input a correct value.");
                }
            };

            // This event is raised if the row fails validation or cannot be saved to the data source due to database restrictions
            gridView.InvalidRowException += (s, e) => {
                //The ExceptionMode parameter controls the actual response to the error
                e.ExceptionMode = ExceptionMode.DisplayError;
            };
        }

        [CodeExampleCase("Customize the error message box", new Type[] { typeof(DemoHelper) }), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ValidateRow", "ErrorText", "InvalidRowException", "ExceptionMode", "Valid")]
        public static void CustomizeTheErrorMessageBox(GridControl gridControl, GridView gridView) {
            gridView.ValidateRow += (s, e) => {
                SampleData obj = e.Row as SampleData;
                e.Valid = obj.Length > 0;
            };

            gridView.InvalidRowException += (s, e) => {
                // Create a custom error message box
                XtraMessageBoxArgs args = new XtraMessageBoxArgs();
                args.Caption = "Length validation failed";
                args.Icon = DemoHelper.GetIcon();
                args.Text = "Length cannot be less than or equal to zero. Please input a correct value.";
                args.Buttons = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };
                if (XtraMessageBox.Show(args) == DialogResult.OK)
                    // The ExceptionMode parameter controls the actual response to the error
                    e.ExceptionMode = ExceptionMode.NoAction;
                else e.ExceptionMode = ExceptionMode.Ignore;
            };
        }
        [CodeExampleCase("Prevent entering duplicate values"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ValidatingEditor", "ErrorText", "Valid", "InvalidValueException", "ErrorText")]
        public static void PreventEnteringDuplicateValues(GridControl gridControl, GridView gridView) {
            // Handle this event to perform manual validation of an in-place active editor or the EditForm's active editor 
            gridView.ValidatingEditor += (s, e) => {
                string fieldName = string.Empty;
                GridView view = s as GridView;
                EditFormValidateEditorEventArgs ea = e as EditFormValidateEditorEventArgs;
                if(ea == null)
                    fieldName = view.FocusedColumn.FieldName;
                else
                    fieldName = ea.Column.FieldName;
                int rowCellValue;
                int validatingCellValue = Convert.ToInt32(e.Value);
                if(fieldName == "ID")
                    for(int rowHandle = 0; rowHandle < view.DataRowCount; rowHandle++) { // iterate through all data rows within GridView
                        rowCellValue = Convert.ToInt32(view.GetRowCellValue(rowHandle, fieldName));  // obtain the ID cell value of the processed row
                        if(rowCellValue == validatingCellValue) {
                            e.Valid = false;
                            e.ErrorText = "ID should be unique (ValidatingEditor)";
                            return;
                        }
                    }
            };

            // Provide a custom response when an invalid cell value is entered
            gridView.InvalidValueException += (s, e) => {
                // The ExceptionMode parameter controls the actual response to the error
                e.ExceptionMode = ExceptionMode.DisplayError;
            };

            ComboBoxEdit editingModesComboBox = new ComboBoxEdit { Parent = gridControl.Parent, Dock = DockStyle.Top };
            editingModesComboBox.Properties.Items.AddRange(Enum.GetValues(typeof(GridEditingMode)));
            // Use the GridOptionsBehavior.EditingMode property to switch from the default in-place edit mode to the Edit Form
            editingModesComboBox.DataBindings.Add(new Binding("EditValue", gridView.OptionsBehavior, "EditingMode", false, DataSourceUpdateMode.OnPropertyChanged));
            editingModesComboBox.EditValue = GridEditingMode.EditForm;
            LabelControl editingModesComboBoxLabel = new LabelControl { Text = "EditingMode", Dock = DockStyle.Top, Parent = gridControl.Parent };
        }
        #endregion
    }
}
