using DevExpress.DXperience.Demos;
using DevExpress.HTML.Demos.Modules.AccordionControl;
using DevExpress.HTML.Demos.Modules.AccordionControl.Controls;
using DevExpress.LookAndFeel;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.Utils.Html;
using DevExpress.Utils.Html.Base;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress.HTML.Demos {
    public partial class AccordionControlModule : TutorialControlBase {
        public AccordionControlModule() {
            InitializeComponent();
            this.accordionControlTemplateCodeViewer1.Fill(this.accordionControl1, null);
            this.comboBoxEdit1.HtmlTemplate = this.htmlTemplate1;
            this.comboBoxEdit1.Properties.HtmlImages = this.svgImageCollection1;
            this.htmlButtonPanel1.HtmlImages = this.svgImageCollection1;
            this.htmlCheckBox.HtmlImages = this.svgImageCollection1;
            this.deliveryControl2.HtmlImages = this.svgImageCollection1;
            SubscribeOnEvents();
            CreateDataSource();
            UpdateBackground();
            SetDataSource();
            InitModules();
            InitDefaultAddresses();
        }
        void InitDefaultAddresses() {
            var item1 = new AddressDataObject();
            item1.City = "Tacoma";
            item1.Address1 = "908 W. Capital Way";
            item1.Address2 = "-";
            item1.Code = "98401";
            item1.State = "WA";
            item1.Phone = "(206) 555-9482";
            item1.SetName("Home");
            var item2 = new AddressDataObject();
            item2.City = "Seattle";
            item2.Address1 = "507 - 20th Ave. E.";
            item2.Address2 = "Apt. 2A";
            item2.Code = "98122";
            item2.State = "WA";
            item2.Phone = "(206) 555-9857";
            item2.SetName("Work");
            this.comboBoxEdit1.Properties.Items.Add(item1);
            this.comboBoxEdit1.Properties.Items.Add(item2);
        }

        void SetDataSource() {
            this.informationControl1.DataSource = dataSource;
            this.shippingControl1.DataSource = dataSource.GetShippingData();
            this.billingControl1.DataSource = dataSource.GetBillingData();
            this.paymentControl1.DataSource = dataSource;
            this.deliveryControl2.DataSource = dataSource;
            this.orderSummaryControl1.DataSource = dataSource;
            this.htmlButtonPanel1.DataSource = dataSource;
        }
        void InitModules() {
            for(int i = 0; i < accordionControl1.Elements.Count; i++) {
                var element = accordionControl1.Elements[i];
                var info = new AccordionElementData();
                if(i == 0)
                    info.IsActive = true;
                element.Tag = info;
            }
            SetDescription(informationElement, "Fill out this form to enter your personal data.");
            SetDescription(shippingElement, "Tell us where we need to ship your order.");
            SetDescription(paymentElement, "You can pay with credit or debit card, cash, or a PayPal account.");
            SetDescription(billingElement, "Choose a delivery option.");
            SetDescription(deliveryElement, "Select a way you want we send your order.");
            SetDescription(summaryElement, "Review your order summary and click \"Place Order\" to complete your purchase.");
            informationElement.Expanded = true;
        }
        void SetDescription(AccordionControlElement element, string description) {
            ((AccordionElementData)element.Tag).Description = description;
        }
        AccordionDataObject dataSource;
        void CreateDataSource() {
            var images = svgImageCollection1;
            dataSource = new AccordionDataObject();
            dataSource.Price = 119.99;

            dataSource.DeliveryTypes.Add(new DeliveryType() { Id = "fedex", Text = "FedEx", Price = 15.50, Time = "3 weeks" });
            dataSource.DeliveryTypes.Add(new DeliveryType() { Id = "dhl", Text = "DHL", Price = 28.35, Time = "2 weeks" });
            dataSource.DeliveryTypes.Add(new DeliveryType() { Id = "expost", Text = "Express Post", Price = 56.95d, Time = "3 days" });

            dataSource.PaymentTypes.Add(new PaymentInfo() { Id = "card", Type = PaymentType.CreditCard, Image = images["card"], IsChecked = true });
            dataSource.PaymentTypes.Add(new PaymentInfo() { Id = "cash", Type = PaymentType.Cash, Image = images["cash"] });
            dataSource.PaymentTypes.Add(new PaymentInfo() { Id = "paypal", Type = PaymentType.PayPal, Image = images["paypal"] });

            dataSource.SelectedDelivery = dataSource.DeliveryTypes[0];
        }
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdateBackground();
        }
        void UpdateBackground() {
            Color bg = LookAndFeelHelper.GetSystemColor(UserLookAndFeel.Default, SystemColors.Control);
            this.accordionControl1.Appearance.AccordionControl.BackColor = bg;
            BackColor = bg;
        }
        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            UpdateElementContainerHeight(informationElement);
        }
        protected override void WndProc(ref Message m) {
            base.WndProc(ref m);
            if(m.Msg == MSG.WM_DPICHANGED_AFTERPARENT) {
                var elements = accordionControl1.Elements;
                for(int i = 0; i < elements.Count; i++) {
                    var element = elements[i];
                    if(element.Expanded) {
                        UpdateElementContainerHeight(element);
                    }
                }
            }
        }
        private void accordionControl1_ExpandStateChanging(object sender, XtraBars.Navigation.ExpandStateChangingEventArgs e) {
            if(e.Element.Expanded)
                return;
            UpdateElementContainerHeight(e.Element);
        }
        void SubscribeOnEvents() {
            this.htmlCheckBox.CheckedChanged += HtmlCheckBox_CheckedChanged;
            this.billingControl1.SaveButtonClick += BillingControl1_SaveButtonClick;
            this.shippingControl1.SaveButtonClick += ShippingControl1_SaveButtonClick;
            this.comboBoxEdit1.EditValueChanged += ComboBoxEdit1_EditValueChanged;
            this.informationControl1.NextButtonClick += OnNextButtonClick;
            this.shippingControl1.NextButtonClick += OnNextButtonClick;
            this.paymentControl1.NextButtonClick += OnNextButtonClick;
            this.billingControl1.NextButtonClick += OnNextButtonClick;
            this.orderSummaryControl1.NextButtonClick += OnNextButtonClick;
            this.deliveryControl2.NextButtonClick += OnNextButtonClick;
        }

        void ComboBoxEdit1_EditValueChanged(object sender, EventArgs e) {
            var edit = (HtmlComboBoxEdit)sender;
            var value = edit.EditValue as AddressDataObject;
            if(value == null)
                return;
            dataSource.GetShippingData().Assign(value);
            shippingControl1.Refresh();
        }
        AddressDataObject cachedBillingData;
        void HtmlCheckBox_CheckedChanged(object sender, EventArgs e) {
            var checkBox = (HtmlCheckBoxControl)sender;
            if(checkBox.Checked) {
                var data = dataSource.GetBillingData();
                if(cachedBillingData == null)
                    cachedBillingData = new AddressDataObject();
                cachedBillingData.Assign(data);
                data.Assign(dataSource.GetShippingData());
                this.billingControl1.Enabled = false;
                this.billingControl1.Refresh();
            }
            else if(cachedBillingData != null) {
                var shippingData = dataSource.GetShippingData();
                var billingData = dataSource.GetBillingData();
                this.billingControl1.Enabled = true;
                if(object.Equals(shippingData, billingData)) {
                    billingData.Assign(cachedBillingData);
                    this.billingControl1.Refresh();
                }
            }
        }
        void ShippingControl1_SaveButtonClick(object sender, EventArgs e) {
            SaveAddressCore((ShippingControl)sender);
        }
        void BillingControl1_SaveButtonClick(object sender, EventArgs e) {
            SaveAddressCore((ShippingControl)sender);
        }
        void SaveAddressCore(ShippingControl sender) {
            var data = sender.DataSource as AddressDataObject;
            if(data == null)
                return;
            var item = data.Clone();
            var items = this.comboBoxEdit1.Properties.Items;
            var description = string.Format("Address{0}", items.Count + 1);
            item.SetName(description);
            this.comboBoxEdit1.Properties.Items.Add(item);
        }
        void UpdateElementContainerHeight(AccordionControlElement element) {
            var container = element?.ContentContainer;
            if(container == null || container.Controls.Count == 0)
                return;
            var provider = container.Controls[0] as IHtmlContentControlProvider;
            var controlInfo = element.AccordionControl?.GetViewInfo() as AccordionControlViewInfo;
            if(provider == null || controlInfo == null)
                return;
            var elementInfo = controlInfo.GetElementInfo(element);
            var elementWidth = elementInfo == null ? element.AccordionControl.Width : elementInfo.HeaderBounds.Width;
            var padding = container.Padding;
            if(!container.IsHandleCreated) {
                container.Location = new Point(-10000, -10000);
                container.Visible = true;
                ((Control)provider).CreateControl();
            }
            Size bestSize = provider.CalcBestSize(elementWidth - padding.Horizontal);
            container.Height = padding.Vertical + bestSize.Height;
        }
        void OnNextButtonClick(object sender, EventArgs e) {
            var activeElement = GetElementByContainer(((Control)sender).Parent);
            if(activeElement == null)
                return;
            var elements = accordionControl1.Elements;
            var activeIndex = elements.IndexOf(activeElement);
            if(activeIndex >= elements.Count - 1)
                return;
            var newActiveElement = accordionControl1.Elements[activeIndex + 1];
            var moduleInfo = newActiveElement.Tag as AccordionElementData;
            if(moduleInfo != null)
                moduleInfo.IsActive = true;
            accordionControl1.ExpandElement(newActiveElement, true);
        }
        AccordionControlElement GetElementByContainer(Control container) {
            if(container == null)
                return null;
            foreach(var element in accordionControl1.Elements) {
                if(object.Equals(element.ContentContainer, container))
                    return element;
            }
            return null;
        }
        private void accordionControl1_QueryHtmlElementData(object sender, QueryAccordionHtmlElementDataEventArgs e) {
            var info = e.Element?.Tag as AccordionElementData;
            if(info == null)
                return;
            switch(e.FieldName) {
                case "Description":
                    e.Value = info.Description;
                    return;
                case "IsActive":
                    e.Value = info.IsActive;
                    return;
                case "Expanded":
                    e.Value = e.Element.Expanded;
                    return;
            }
        }
    }
    public class AccordionElementData {
        public bool IsActive { get; set; }
        public string Description { get; set; }
    }
    public interface IHtmlContentControlProvider {
        Size CalcBestSize(int width);
    }
    public class AccordionDataObject {
        public AccordionDataObject() {
            shippingData = new AddressDataObject();
            billingData = new AddressDataObject();
            DeliveryTypes = new List<DeliveryType>();
            PaymentTypes = new List<PaymentInfo>();
        }
        AddressDataObject shippingData, billingData;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
        public string ShippingAddress1 {
            get { return this.shippingData.Address1; }
            set { this.shippingData.Address1 = value; }
        }
        public string ShippingAddress2 {
            get { return this.shippingData.Address2; }
            set { this.shippingData.Address2 = value; }
        }
        public string ShippingCity {
            get { return this.shippingData.City; }
            set { this.shippingData.City = value; }
        }
        public string ShippingState {
            get { return this.shippingData.State; }
            set { this.shippingData.State = value; }
        }
        public string ShippingCode {
            get { return this.shippingData.Code; }
            set { this.shippingData.Code = value; }
        }
        public string ShippingPhone {
            get { return this.shippingData.Phone; }
            set { this.shippingData.Phone = value; }
        }
        public string BillingAddress1 {
            get { return this.billingData.Address1; }
            set { this.billingData.Address1 = value; }
        }
        public string BillingAddress2 {
            get { return this.billingData.Address2; }
            set { this.billingData.Address2 = value; }
        }
        public string BillingCity {
            get { return this.billingData.City; }
            set { this.billingData.City = value; }
        }
        public string BillingState {
            get { return this.billingData.State; }
            set { this.billingData.State = value; }
        }
        public string BillingCode {
            get { return this.billingData.Code; }
            set { this.billingData.Code = value; }
        }
        public string BillingPhone {
            get { return this.billingData.Phone; }
            set { this.billingData.Phone = value; }
        }
        public object CardNumber { get; set; }
        public string CardHolder { get; set; }
        public string CardThru { get; set; }
        public string CardCVC { get; set; }
        public double Price { get; set; }
        public double TotalPrice {
            get {
                var price = Price;
                price += SelectedDelivery.Price;
                return price;
            }
        }
        public object CardLastNumbers {
            get {
                long value = 0;
                if(CardNumber is int) {
                    value = (int)CardNumber;
                }
                else if(CardNumber is string) {
                    var strValue = (string)CardNumber;
                    if(strValue.Length < 4)
                        return null;
                    long.TryParse(strValue.Substring(strValue.Length - 4, 4), out value);
                }
                if(value > 0)
                    return value % 10000;
                return null;
            }
        }
        DeliveryType selectedDelivery;
        public DeliveryType SelectedDelivery {
            get { return selectedDelivery; }
            set {
                selectedDelivery = value;
                DeliveryTypes.ForEach(x => x.IsChecked = x == selectedDelivery);
            }
        }
        public List<DeliveryType> DeliveryTypes { get; }
        PaymentInfo selectedPaymentType;
        public PaymentInfo SelectedPaymentType {
            get { return selectedPaymentType; }
            set {
                selectedPaymentType = value;
                PaymentTypes.ForEach(x => x.IsChecked = x == selectedPaymentType);
            }
        }
        public List<PaymentInfo> PaymentTypes { get; }
        public string DeliveryValue {
            get { return SelectedDelivery?.Text; }
        }

        public AddressDataObject GetBillingData() {
            return this.billingData;
        }
        public AddressDataObject GetShippingData() {
            return this.shippingData;
        }
        public PaymentInfo PaymentInfo { get; }
    }
    public class PaymentInfo {
        public bool IsChecked { get; set; }
        public PaymentType Type { get; set; }
        public string Id { get; set; }
        public object Image { get; set; }
    }
    public enum PaymentType { CreditCard, PayPal, Cash }
    public class DeliveryType {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Time { get; set; }
        public double Price { get; set; }
        public bool IsChecked { get; set; }
    }

    public class AddressDataObject {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Code { get; set; }
        public string Phone { get; set; }
        string name = string.Empty;
        public void SetName(string value) {
            name = value;
        }
        public void Assign(AddressDataObject obj) {
            Address1 = obj.Address1;
            Address2 = obj.Address2;
            City = obj.City;
            State = obj.State;
            Code = obj.Code;
            Phone = obj.Phone;
        }
        public AddressDataObject Clone() {
            var res = new AddressDataObject();
            res.Address1 = Address1;
            res.Address2 = Address2;
            res.City = City;
            res.State = State;
            res.Code = Code;
            res.Phone = Phone;
            return res;
        }
        public override string ToString() {
            return name;
        }
        public override bool Equals(object obj) {
            AddressDataObject src = obj as AddressDataObject;
            if(src == null)
                return false;
            return Address1 == src.Address1 && Address2 == src.Address2 && City == src.City && State == src.State && Code == src.Code && Phone == src.Phone;
        }
        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }
}
