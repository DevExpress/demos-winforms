using DevExpress.DXperience.Demos;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleHypertextLabel : TutorialControl {
        #region HTMLPatterns
        const string DefaultHtmlPattern =
@"
<size=+4><href={0}>R{0}</href> <image={1}></size>

<font='Times New Roman' color=green size=+2><b>{2}</b><sup><href=mailto:{4}>[1]</href></sup>
<i><color=@DisabledText>{3}</i></font>

<size=+3></size>
{6}
{7}
 ";
        const string CompactHTMLPattern =
@"
<size=+2><image={1}> <href={0}>R{0}</href> - <i><color=@DisabledText>{3}</i></color></size>

<b>{5}<sup><href=mailto:{4}>[1]</href></sup></b> - {7} , {6}
 ";
        const string LargeHTMLPattern =
@"
<size=+10>Invoice: <href={0}>R{0}</href> <image={1}></size>
<size=+5><i><color=@DisabledText>{3}</color></i></size>

<size=+6>{5} - {2}</size>
<size=+4><href={4}>{4}</href></size>
<size=+3><i><color=@DisabledText>{6}
{7}</color></i></size>
 ";
#endregion
        RepositoryItemHypertextLabel repositoryItemHypertextLabel;
        string CurrentDefaultHTMLPattern = DefaultHtmlPattern;
        public string HTMLPattern = DefaultHtmlPattern;
        public override BaseView ExportView { get { return gridView1; } }
        public ModuleHypertextLabel() {
            InitializeComponent();
            invoiceBindingSource.DataSource = GetData();

            repositoryItemHypertextLabel = new RepositoryItemHypertextLabel();
            repositoryItemHypertextLabel.Appearance.Options.UseTextOptions = true;
            repositoryItemHypertextLabel.HtmlImages = svgImageCollection1;
            repositoryItemHypertextLabel.OpenHyperlink += RepositoryItemHypertextLabel_OpenHyperlink;
            colHtmlText.ColumnEdit = repositoryItemHypertextLabel;
            gridControl1.RepositoryItems.Add(repositoryItemHypertextLabel);

            singleClickICB.Properties.Items.Add(new ImageComboBoxItem("True", true, -1));
            singleClickICB.Properties.Items.Add(new ImageComboBoxItem("False", false, -1));
            singleClickICB.DataBindings.Add("EditValue", repositoryItemHypertextLabel, "SingleClick", true, DataSourceUpdateMode.OnPropertyChanged);

            textAlignmentICB.Properties.Items.AddEnum<HorzAlignment>();
            textAlignmentICB.EditValue = repositoryItemHypertextLabel.Appearance.TextOptions.HAlignment;

            memoEdit1.EditValue = HTMLPattern;
        }

        void gridView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e) {
            if(e.Column == colHtmlText && e.IsGetData) {
                Invoice invoice = e.Row as Invoice;
                if(invoice == null) return;
                e.Value = string.Format(HTMLPattern,
                    invoice.ID,
                    invoice.Approve ? "Approve" : "Reject",
                    invoice.Manager,
                    invoice.OrderDate.ToShortDateString(),
                    invoice.Email,
                    invoice.Company,
                    invoice.AddressLine,
                    invoice.CityLine);
            }
        }
        void htmlPatternLCG_CustomButtonClick(object sender, BaseButtonEventArgs e) {
            memoEdit1.EditValue = CurrentDefaultHTMLPattern;
        }

        void memoEdit1_EditValueChanged(object sender, EventArgs e) {
            try {
                string.Format(memoEdit1.Text, "", "", "", "", "", "", "", "", "");
            }
            catch {
                return;
            }
            HTMLPattern = memoEdit1.Text;
                gridControl1.RefreshDataSource();
                htmlPatternLCG.CustomHeaderButtons["Reset"].Properties.Enabled = HTMLPattern != CurrentDefaultHTMLPattern;
            
        }

        void RepositoryItemHypertextLabel_OpenHyperlink(object sender, OpenHyperlinkEventArgs e) {
            if(e.Link.StartsWith("mailto")) return;
            e.Handled = true;
            XtraMessageBox.Show("Link ID - " + e.Link, "Invoice");
        }

        void textAlignmentICB_SelectedIndexChanged(object sender, EventArgs e) {
            repositoryItemHypertextLabel.Appearance.TextOptions.HAlignment = (HorzAlignment)textAlignmentICB.EditValue;
            colHtmlText.AppearanceCell.TextOptions.HAlignment = (HorzAlignment)textAlignmentICB.EditValue;
        }

        #region Data
        public static BindingList<Invoice> GetData() {
            BindingList<Invoice> bindingList = new BindingList<Invoice>();
            bindingList.Add(new Invoice() {
                ID = 238912,
                Manager = "John Smith",
                OrderDate = TutorialConstants.Now - new TimeSpan(15, 4, 0, 0),
                Company = "ElectrixMax",
                AddressLine = "Naperville, IL 60563",
                CityLine = "263 Shuman Blvd",
                Email = "electrixmax@devav.com",
                Approve = true
            });
            bindingList.Add(new Invoice() {
                ID = 240328,
                Manager = "John Smith",
                OrderDate = TutorialConstants.Now - new TimeSpan(10, 0, 0, 0),
                Company = "Screen Shop",
                AddressLine = "Mooresville, NC 28117",
                CityLine = "1000 Lowes Blvd",
                Email = "screenshop@devav.com",
                Approve = true
            });
            bindingList.Add(new Invoice() {
                ID = 250237,
                Manager = "Greta Sims",
                OrderDate = TutorialConstants.Now - new TimeSpan(8, 6, 0, 0),
                Company = "Zony Toys",
                AddressLine = "Los Angeles, CA 90034",
                CityLine = "1945 S Cienega Boulevard",
                Email = "zonytoys@devav.com",
                Approve = true
            });
            bindingList.Add(new Invoice() {
                ID = 240325,
                Manager = "Greta Sims",
                OrderDate = TutorialConstants.Now - new TimeSpan(4, 8, 0, 0),
                Company = "Store of America",
                AddressLine = "Seattle, WA 98134",
                CityLine = "2401 Utah Ave. South",
                Email = "storeofamerica@devav.com",
                Approve = false
            });
            bindingList.Add(new Invoice() {
                ID = 243157,
                Manager = "Greta Sims",
                OrderDate = TutorialConstants.Now - new TimeSpan(1, 0, 0, 0),
                Company = "Super Mart of the West",
                AddressLine = "Bentonville, AR 72716",
                CityLine = "702 SW 8th Street",
                Email = "supermart@devav.com",
                Approve = false
            });
            return bindingList;
        }
        public class Invoice {
            public string AddressLine { get; set; }
            public bool Approve { get; set; }
            public string CityLine { get; set; }
            public string Company { get; set; }
            public string Email { get; set; }
            public int ID { get; set; }
            public string Manager { get; set; }
            public DateTime OrderDate { get; set; }
        }
        #endregion

        void htmlPatternLCG_CustomButtonChecked(object sender, BaseButtonEventArgs e) {
            if(e.Button.Properties.Caption == "Compact")
                CurrentDefaultHTMLPattern = CompactHTMLPattern;
            if(e.Button.Properties.Caption == "Default")
                CurrentDefaultHTMLPattern = DefaultHtmlPattern;
            if(e.Button.Properties.Caption == "Large")
                CurrentDefaultHTMLPattern = LargeHTMLPattern;
            memoEdit1.EditValue = CurrentDefaultHTMLPattern;
        }
    }
}
