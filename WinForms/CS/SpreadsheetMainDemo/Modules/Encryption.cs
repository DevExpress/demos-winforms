using System;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Spreadsheet;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class EncryptionModule : SpreadsheetRibbonTutorialControlBase {
        IWorkbook workbook;

        public EncryptionModule() {
            InitializeComponent();
            InitializeWorkbook();
            InitializeEncryptionOptions();
            workbook.History.Clear();
        }

        protected internal override RibbonPage SelectedRibbonPage {
            get {
                return fileRibbonPage1;
            }
        }

        private void InitializeWorkbook() {
            workbook = spreadsheetControl1.Document;
            workbook.LoadDocument(DemoUtils.GetRelativePath("ProfitAndLoss.xlsx"));
        }

        private void InitializeEncryptionOptions() {
            passwordEdit.Text = "test";
            foreach(EncryptionType currentValue in EnumHelper.GetValues<EncryptionType>())
                typeEdit.Properties.Items.Add(currentValue.ToString());
            typeEdit.SelectedItem = EncryptionType.Strong.ToString();
        }

        private void TypeEdit_TextChanged(object sender, EventArgs e) {
            workbook.DocumentSettings.Encryption.Type = (EncryptionType)Enum.Parse(typeof(EncryptionType), typeEdit.Text);
        }

        private void PasswordEdit_TextChanged(object sender, EventArgs e) {
            workbook.DocumentSettings.Encryption.Password = passwordEdit.Text;
        }

        private void BtnExport_Click(object sender, EventArgs e) {
            SaveFileDialog dialog = new SaveFileDialog {
                Filter = "Excel Workbook (*.xlsx)|*.xlsx|Excel Binary Workbook (*.xlsb)|*.xlsb|Excel 97-2003 Workbook (*.xls)|*.xls",
                FileName = "Document.xlsx"
            };

            if(dialog.ShowDialog() == DialogResult.OK) {
                string fileName = dialog.FileName;
                workbook.SaveDocument(fileName);
                if(chbOpenResultingFile.Checked)
                    Data.Utils.SafeProcess.Start(fileName);
            }
        }

        protected override void DoShow() {
            base.DoShow();
            spreadsheetControl1.Focus();
        }
    }
}
