using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Navigation;
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
    public partial class HamburgerMenuModule : TutorialControlBase {
        public HamburgerMenuModule() {
            InitializeComponent();
            this.accordionControlTemplateCodeViewer1.Fill(this.accordionControl1, null);
            UpdateBackground();
            InitCategories();
        }
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdateBackground();
        }
        void UpdateBackground() {
            Color bg = LookAndFeelHelper.GetSystemColor(LookAndFeel.ActiveLookAndFeel, SystemColors.Control);
            this.accordionControl1.Appearance.AccordionControl.BackColor = bg;
            BackColor = bg;
        }
        void InitCategories() {
            this.acEmployees.Tag = new HamburgerElementDataSource(
                new HamburgerMenuCategory[] { new HamburgerMenuCategory("Salaried"), new HamburgerMenuCategory("Commission"), new HamburgerMenuCategory("Contract") },
                new HamburgerMenuCategory[] { new HamburgerMenuCategory("Terminated"), new HamburgerMenuCategory("On Leave") }
                );
            this.acCustomers.Tag = new HamburgerElementDataSource(
                new HamburgerMenuCategory[] { new HamburgerMenuCategory("Stores > 10"), new HamburgerMenuCategory("Revenue > 100 Billion") },
                new HamburgerMenuCategory[] { new HamburgerMenuCategory("Employees > 10000") }
                );
            this.acVendors.Tag = new HamburgerElementDataSource(
                new HamburgerMenuCategory[] { new HamburgerMenuCategory("Active"), new HamburgerMenuCategory("Suspended") },
                null
                );
            this.acMonitors.Tag = new HamburgerElementDataSource(
               new HamburgerMenuCategory[] { new HamburgerMenuCategory("Available") },
               new HamburgerMenuCategory[] { new HamburgerMenuCategory("Discounted") }
               );
            this.acProjectors.Tag = new HamburgerElementDataSource(
               new HamburgerMenuCategory[] { new HamburgerMenuCategory("Available") },
               new HamburgerMenuCategory[] { new HamburgerMenuCategory("Discounted") }
               );
            this.acTelevisions.Tag = new HamburgerElementDataSource(
               new HamburgerMenuCategory[] { new HamburgerMenuCategory("Available") },
               new HamburgerMenuCategory[] { new HamburgerMenuCategory("Discounted") }
               );
            this.acVideoPlayers.Tag = new HamburgerElementDataSource(
                new HamburgerMenuCategory[] { new HamburgerMenuCategory("Available") },
                new HamburgerMenuCategory[] { new HamburgerMenuCategory("Discounted") }
                );
            this.acMonitors2.Tag = new HamburgerElementDataSource(
                new HamburgerMenuCategory[] { new HamburgerMenuCategory("Today"), new HamburgerMenuCategory("Yesterday"), new HamburgerMenuCategory("This Month") },
                new HamburgerMenuCategory[] { new HamburgerMenuCategory("This Year"), new HamburgerMenuCategory("Unpaid Orders") }
                );
            this.acProjectors2.Tag = new HamburgerElementDataSource(
               new HamburgerMenuCategory[] { new HamburgerMenuCategory("Today"), new HamburgerMenuCategory("Yesterday"), new HamburgerMenuCategory("This Month") },
               new HamburgerMenuCategory[] { new HamburgerMenuCategory("This Year"), new HamburgerMenuCategory("Unpaid Orders") }
               );
            this.acTelevisions2.Tag = new HamburgerElementDataSource(
               new HamburgerMenuCategory[] { new HamburgerMenuCategory("Today"), new HamburgerMenuCategory("Yesterday"), new HamburgerMenuCategory("This Month") },
               new HamburgerMenuCategory[] { new HamburgerMenuCategory("This Year"), new HamburgerMenuCategory("Unpaid Orders") }
               );
            this.acVideoPlayers2.Tag = new HamburgerElementDataSource(
               new HamburgerMenuCategory[] { new HamburgerMenuCategory("Today"), new HamburgerMenuCategory("Yesterday"), new HamburgerMenuCategory("This Month") },
               new HamburgerMenuCategory[] { new HamburgerMenuCategory("This Year"), new HamburgerMenuCategory("Unpaid Orders") }
               );
        }

        private void accordionControl1_QueryHtmlElementData(object sender, XtraBars.Navigation.QueryAccordionHtmlElementDataEventArgs e) {
            if(e.FieldName == "IsControlExpanded") {
                e.Value = ((AccordionControl)sender).OptionsMinimizing.State == AccordionControlState.Normal;
                return;
            }
            if(e.Element == null)
                return;
            if(e.FieldName == "Categories1") {
                var data = e.Element.Tag as HamburgerElementDataSource;
                e.Value = data?.Categories1;
                return;
            }
            if(e.FieldName == "Categories2") {
                var data = e.Element.Tag as HamburgerElementDataSource;
                e.Value = data?.Categories2;
                return;
            }
            if(e.FieldName == "IsFirst") {
                var elements = e.Element.OwnerElement?.Elements;
                e.Value = elements != null && elements.IndexOf(e.Element) == 0;
            }
            if(e.FieldName == "IsLast") {
                var elements = e.Element.OwnerElement?.Elements;
                e.Value = elements != null && elements.IndexOf(e.Element) == elements.Count - 1;
            }
        }

        private void accordionControl1_HtmlElementMouseClick(object sender, AccordionHtmlElementEventArgs e) {
            if(e.HasId("searchbutton")) {
                var accordion = (AccordionControl)sender;
                if(accordion.ShowFilterControl == ShowFilterControl.Never)
                    accordion.ShowFilterControl = ShowFilterControl.Always;
                else
                    accordion.ShowFilterControl = ShowFilterControl.Never;
            }
        }
    }
    class HamburgerElementDataSource {
        public HamburgerElementDataSource(HamburgerMenuCategory[] categories1, HamburgerMenuCategory[] categories2) {
            Categories1 = categories1;
            Categories2 = categories2;
        }
        public HamburgerMenuCategory[] Categories1 { get; set; }
        public HamburgerMenuCategory[] Categories2 { get; set; }
    }
    class HamburgerMenuCategory {
        public HamburgerMenuCategory(string name) {
            Name = name;
        }
        public string Name { get; set; }
    }
}
