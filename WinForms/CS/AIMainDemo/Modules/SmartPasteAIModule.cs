using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevExpress.AIIntegration.WinForms;
using DevExpress.Data.Utils;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;

namespace DevExpress.AI.Demos {
    public partial class SmartPasteAIModule : AITutorialControl {
        private const string LayoutCopyText = @"Payment: Amount - $123.00
Statement Date: 10/15/2024
Account Number: 133244556
Name: John Smith
Contact: (123) 456-7890
Email: john@myemail.com
Address:
- 123 Elm St Apt 4B
- New York, NY 10001";
        private const string GridCopyText = @"Transactions 
- Hanari Carnes - Invoice amount due: $123.00, due by 10/30/2024. Status: Processed ✅
- Que Delicia - Amount: $231.00 | Due date: 10/29/2024 | Not processed yet 
- Romero y tomillo - $369.00 required by 10/28/2024, Processed ✅ 
- Mere Paillard - Payment: $158.00, due: 10/31/2024, unprocessed 
- Eastern Delights has an outstanding balance of $97.00, which was due on 10/27/2024. Status: Processed ✅ ";
        private const string SchedulerCopyText = @"Weekly Meeting with Mike F. from the Marketing Department
Date & Time: Tomorrow at 3:30 PM (New York time)
Duration: 45 minutes
Location: Conference room, 33rd floor, HQ office
Topic: Finalizing the marketing budget for the new promo campaign

Agenda: 

- Share what was completed
- Discuss issues
- Review incomplete tasks/requirements 

Reminder: 1 hour before the meeting.";
        GridColumn colCompany;
        GridColumn colID;
        GridColumn colDate;
        GridColumn colPayment;
        GridColumn colProcessed;

        public SmartPasteAIModule() {
            InitializeComponent();
            InitLayoutControl();
            tabPane1_SelectedPageIndexChanged(tabPane1, EventArgs.Empty);
            UpdatePaddings();
            schedulerDataStorage1.Resources.Add(1, "Meeting Room \"Falcon\"");
            schedulerDataStorage1.Resources.Add(2, "Conference room");
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            gridControl1.ForceInitialize();
            InitGridControl();
        }

        protected override void DoHide() {
            behaviorManager1.GetBehavior<SmartPasteBehavior>(layoutControl1)?.CloseOverlayForm();
            behaviorManager1.GetBehavior<SmartPasteBehavior>(gridView1)?.CloseOverlayForm();
            behaviorManager1.GetBehavior<SmartPasteSchedulerBehavior>(schedulerControl1)?.CloseOverlayForm();
            base.DoHide();
        }

        protected override void UpdatePaddings() {
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset);
        }

        void InitLayoutControl() {
            foreach(BaseLayoutItem item in layoutControl1.Items)
                if(item is LayoutControlItem lci && lci.Control is TextEdit control)
                    control.KeyDown += LayoutControlProcessKeyDown;
            //
            var itemsDescriptions = new List<AIItemDescription>() {
                new AIItemDescription(layoutControlItem1, "The primary address line, which usually includes the street number and name (e.g., 123 Main St). Can include alphabetic and numeric characters."),
                new AIItemDescription(layoutControlItem2, "The secondary address line, which can include apartment or suite number (e.g., Apt 4B). This field is optional. Can include alphabetic and numeric characters."),
                new AIItemDescription(layoutControlItem3, "The city name. Only alphabetic characters are expected."),
                new AIItemDescription(layoutControlItem4, "The state, province, or region name or abbreviation. Only alphabetic characters are expected."),
                new AIItemDescription(layoutControlItem5, "The ZIP or postal code. Numeric characters and sometimes alphabetic characters (e.g., for Canadian postal codes) are expected."),
                new AIItemDescription(layoutControlItem6, "The first name of the recipient. Only alphabetic characters are expected."),
                new AIItemDescription(layoutControlItem7, "The last name of the recipient. Only alphabetic characters are expected."),
                new AIItemDescription(layoutControlItem8, "The phone number of the recipient in the format of (XXX) XXX-XXXX or similar. Only numeric characters and standard phone number formatting characters (e.g., parentheses, dashes, spaces) are expected."),
                new AIItemDescription(layoutControlItem10, "The email of the recipient.")
            };
            //
            var smartPasteBehavior = behaviorManager1.GetBehavior<SmartPasteBehavior>(layoutControl1);
            smartPasteBehavior.Properties.ItemDescriptions.AddRange(itemsDescriptions);
            layoutControl1.AllowCustomization = false;
        }

        void InitGridControl() {
            gridControl1.DataSource = SmartPasteDataHelper.GetData(10);
            // Obtain created columns.
            colCompany = gridView1.Columns["CompanyName"];
            colCompany.Caption = "Company Name";
            colID = gridView1.Columns["ID"];
            colDate = gridView1.Columns["DueDate"];
            colDate.Caption = "Due Date";
            colPayment = gridView1.Columns["Amount"];
            colPayment.Caption = "Amount";
            colProcessed = gridView1.Columns["Processed"];
            colProcessed.Caption = "Processed";

            // The Company column uses a ComboBox in-place editor that shows a list of available companies.
            RepositoryItemComboBox riComboBox = new RepositoryItemComboBox();
            riComboBox.Items.AddRange(SmartPasteDataHelper.companies);
            gridControl1.RepositoryItems.Add(riComboBox);
            colCompany.ColumnEdit = riComboBox;

            // Hide a column.
            colID.Visible = false;

            gridControl1.MainView.InvalidValueException += ViewInvalidValueException;
            gridControl1.ProcessGridKey += GridControlProcessKeyDown;
            (gridControl1.MainView as GridView).FocusedRowHandle = 0;

            var itemsDescriptions = new List<AIItemDescription>() {
                new AIItemDescription(colPayment, "The total monetary value of the order, typically in USD."),
                new AIItemDescription(colDate, "The date by which the company expects the order to be fulfilled."),
                new AIItemDescription(colProcessed, "A Boolean value indicating whether the order has been processed.")
            };
            var smartPasteBehavior = behaviorManager1.GetBehavior<SmartPasteBehavior>(gridControl1.MainView);
            smartPasteBehavior.Properties.ItemDescriptions.AddRange(itemsDescriptions);
        }
        void ViewInvalidValueException(object sender, InvalidValueExceptionEventArgs e) {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore;
        }
        async void GridControlProcessKeyDown(object sender, KeyEventArgs e) {
            if(e.KeyData == (Keys.Control | Keys.Shift | Keys.V)) {
                e.Handled = true;
                var smartPasteBehavior = behaviorManager1.GetBehavior<SmartPasteBehavior>(gridControl1.MainView);
                await smartPasteBehavior.SmartPasteAsync();
            }
        }
        async void LayoutControlProcessKeyDown(object sender, KeyEventArgs e) {
            if(e.KeyData == (Keys.Control | Keys.Shift | Keys.V)) {
                e.Handled = true;
                var smartPasteBehavior = behaviorManager1.GetBehavior<SmartPasteBehavior>(layoutControl1);
                await smartPasteBehavior.SmartPasteAsync();
            }
        }
        void simpleButtonCopy_Click(object sender, EventArgs e) {
            SafeClipboardWin.Instance.SetText(memoEdit1.Text);
        }
        async void simpleButtonPaste_Click(object sender, EventArgs e) {
            var smartPasteBehavior = behaviorManager1.GetBehavior<SmartPasteBehavior>(layoutControl1);
            await smartPasteBehavior.SmartPasteAsync();
        }
        void tabPane1_SelectedPageIndexChanged(object sender, EventArgs e) {
            if(tabPane1.SelectedPage == layoutTabNavigationPage) {
                memoEdit1.Text = LayoutCopyText;
            }
            else if(tabPane1.SelectedPage == gridTabNavigationPage) {
                memoEdit1.Text = GridCopyText;
            }
            else {
                memoEdit1.Text = SchedulerCopyText;
            }            
        }
    }

    public class Record : INotifyPropertyChanged {
        public Record() { }
        int id;
        public int ID {
            get { return id; }
            set {
                if(id != value) {
                    id = value;
                    OnPropertyChanged();
                }
            }
        }
        string text;
        [DisplayName("Company")]
        public string CompanyName {
            get { return text; }
            set {
                if(text != value) {
                    if(string.IsNullOrEmpty(value))
                        throw new Exception();
                    text = value;
                    OnPropertyChanged();
                }
            }
        }
        decimal? val;
        [DataType(System.ComponentModel.DataAnnotations.DataType.Currency)]
        [DisplayName("Payment")]
        public decimal? Amount {
            get { return val; }
            set {
                if(val != value) {
                    val = value;
                    OnPropertyChanged();
                }
            }
        }
        DateTime dt;
        [DisplayFormat(DataFormatString = "d")]
        public DateTime DueDate {
            get { return dt; }
            set {
                if(dt != value) {
                    dt = value;
                    OnPropertyChanged();
                }
            }
        }
        bool state;
        public bool Processed {
            get { return state; }
            set {
                if(state != value) {
                    state = value;
                    OnPropertyChanged();
                }
            }
        }
        public override string ToString() {
            return string.Format("ID = {0}, Text = {1}", ID, CompanyName);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class SmartPasteDataHelper {
        public static string[] companies = new string[] { "Hanari Carnes", "Que Delicia", "Romero y tomillo", "Mere Paillarde",
            "Comércio Mineiro", "Reggiani Caseifici", "Maison Dewey", "Eastern Delights" };
        public static string[] items = new string[] { "Office Chairs", "Laptops", "Printer Ink", "Tables",
            "Paper" };
        public static BindingList<Record> GetData(int count) {
            BindingList<Record> records = new BindingList<Record>();
            var rnd = DevExpress.Data.Utils.NonCryptographicRandom.Default;
            for(int i = 0; i < count; i++) {
                int n = rnd.Next(10);
                var record = new Record() {
                    ID = i + 100,
                    CompanyName = companies[i % companies.Length],
                    DueDate = DateTime.Today.AddDays(n - 5),
                    Amount = i % 2 == 0 ? (i + 1) * 123 : i * 231,
                    Processed = i % 2 == 0,
                };
                records.Add(record);
            };
            return records;
        }
    }
}
