using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using DevExpress.Data;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Popup;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleAutoSuggestLookup : TutorialControl {
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "ModuleAutoSuggestLookup" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "autosuggestlookup"; }
        }
        protected override void CalcContentCore() {
            if(tablePanel1 != null)
                tablePanel1.Height = dataLayoutControl1.Root.MinSize.Height + dataLayoutControl1.Margin.Vertical;
            CalcTablePanelBounds(tablePanel1);
        }
        public ModuleAutoSuggestLookup() {
            InitializeComponent();
            contactInformationBindingSource.DataSource = new ContactInformation {
                FirstName = "Margaret",
                LastName = "Boxter",
                Email = "margaretb@dx-email.com",
                Phone = "7145550827"
            };
            orderInfoBindingSource.DataSource = new List<OrderInfo> {
                new OrderInfo { ProductName = "DX-H6000 27\" 4K MONITOR", Quantity = 3, Price = 425 },
                new OrderInfo { ProductName = "DX-H5000 24\" 4K MONITOR", Quantity = 2, Price = 327 },
            };
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            DeliveryAddressLookup.Focus();
        }
        // <DeliveryAddressLookup>
        void OnAutoSuggest(object sender, LookUpEditAutoSuggestEventArgs e) {
            // Set delay (if needed)
            e.SetMinimumAnimationDuration(TimeSpan.FromMilliseconds(1000));
            // Set Custom Highlight Strategy
            e.SetHighlightRanges(HighlightTags(e.Text));
            // Create a Task that return suggestions
            e.QuerySuggestions = WorldCities.QueryAsync(e.Text, e.CancellationToken);
        }
        // </DeliveryAddressLookup>
        void OnCustomDrawCell(object sender, LookUpCustomDrawCellArgs e) {
            e.DrawHtmlText(WorldCities.GetHtmlText(e.Row));
            e.Handled = true;
        }
        void OnEditValueChanged(object sender, EventArgs e) {
            var selectedEntry = ((LookUpEditBase)sender).EditValue;
            entryBindingSource.DataSource = selectedEntry ?? typeof(WorldCities.Entry);
            if(selectedEntry != null)
                validationHint1.Properties.State = null;
            else
                validationHint1.Properties.State = Utils.VisualEffects.ValidationHintState.Invalid;
        }
        decimal total;
        void OnCustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e) {
            switch(e.SummaryProcess) {
                case CustomSummaryProcess.Start:
                    total = 0;
                    break;
                case CustomSummaryProcess.Calculate:
                    var orderInfo = e.Row as OrderInfo;
                    total += (orderInfo.Quantity * orderInfo.Price);
                    break;
                case CustomSummaryProcess.Finalize:
                    e.TotalValue = total;
                    break;
            }
        }
        static Func<string, string, DisplayTextHighlightRange[]> HighlightTags(string pattern) {
            var indexOf = IgnoreCaseComparisonFunctions.GetIndexOf(CultureInfo.CurrentCulture.CompareInfo, CompareOptions.IgnoreCase);
            var parts = pattern.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return (displayText, fieldName) => {
                var tags = displayText.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                var ranges = new List<DisplayTextHighlightRange>();
                for(int i = 1/*skip country tag*/; i < tags.Length; i++) {
                    int tagStart = displayText.IndexOf(tags[i]);
                    for(int j = 0; j < parts.Length; j++) {
                        int index = indexOf(tags[i], parts[j]);
                        if(index != -1)
                            ranges.Add(new DisplayTextHighlightRange(tagStart + index, parts[j].Length));
                    }
                }
                return ranges.ToArray();
            };
        }
    }
    //
    public class ContactInformation {
        [EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, MinLength(3)]
        public string FirstName { get; set; }
        [Required, MinLength(3)]
        public string LastName { get; set; }
        public string DeliveryAddress { get; set; }
        [Phone, DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
    public class OrderInfo {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
