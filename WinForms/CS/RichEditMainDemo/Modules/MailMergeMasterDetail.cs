using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.API.Layout;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Demos.Modules.CustomDraw;
using DevExpress.XtraRichEdit.Demos.Modules.MailMerge;
using DevExpress.XtraRichEdit.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class MailMergeMasterDetailModule : MailMergeModuleBase {
        public bool HighlightRegions { get; set; }
        public override RichEditControl RichEdit {
            get { return templateRichEditControl; }
        }
        protected override GridView TopLevelRecordSelector {
            get {
                return recordSelectorCustomerView;
            }
        }
        bool HighlightingEnabled {
            get {
                return highlightingEnabled;
            }
            set {
                if(highlightingEnabled != value) {
                    highlightingEnabled = value;
                    templateRichEditControl.Refresh();
                }
            }
        }

        static readonly CustomDrawHighlightType regionHighlightType = CustomDrawHighlightType.Fill;
        MailMergeRegionInfo rootRegionInfo;
        MailMergeOptions mailMergeOptions;
        List<CustomDrawHighlightInfo> regionHighlights = new List<CustomDrawHighlightInfo>();
        bool highlightingEnabled;
        bool hasValidResult;
        RichEditDemoExceptionsHandler resultRichEditExceptionHandler;

        public MailMergeMasterDetailModule() {
            InitializeComponent();
            resultRichEditExceptionHandler = new RichEditDemoExceptionsHandler(templateRichEditControl);
            resultRichEditExceptionHandler.Install();

            templateRichEditControl.Options.MailMerge.ViewMergedData = false;
            resultRichEditControl.Options.Fields.HighlightMode = FieldsHighlightMode.Never;
            ribbonControl1.SelectedPage = ribbonControl1.Pages["Mail Merge"];
            LoadDocument("MailMergeMasterDetail.docx");

            mailMergeOptions = templateRichEditControl.Document.CreateMailMergeOptions();
            tabControl.SelectedPageChanging += TabControl_SelectedPageChanging;
            tabControl.SelectedPageChanged += TabControl_SelectedPageChanged;
            templateRichEditControl.Document.ContentChanged += TemplateDocument_ContentChanged;
            recordSelectorCustomerView.SelectionChanged += RecordSelectorCustomerView_SelectionChanged;

            UpdateRegionHierarchy();
        }

        protected override void FillDataSource(OleDbConnection connection) {
            LoadDb(connection);
            templateRichEditControl.Options.MailMerge.DataSource = nwindDataSetInstance;
            templateRichEditControl.Options.MailMerge.DataMember = nwindDataSetInstance.Customers.TableName;
            recordSelectorGridControl.DataSource = nwindDataSetInstance;
            recordSelectorGridControl.DataMember = nwindDataSetInstance.Customers.TableName;
        }
        void LoadDb(OleDbConnection connection) {
            customersTableAdapter.Connection = connection;
            customersTableAdapter.Fill(nwindDataSetInstance.Customers);

            ordersTableAdapter.Connection = connection;
            ordersTableAdapter.Fill(nwindDataSetInstance.Orders);

            order_DetailsTableAdapter.Connection = connection;
            order_DetailsTableAdapter.Fill(nwindDataSetInstance.Order_Details);

            productsTableAdapter.Connection = connection;
            productsTableAdapter.Fill(nwindDataSetInstance.Products);

            var orderDetailsTable = nwindDataSetInstance.Order_Details;
            var productNameCol = orderDetailsTable.Columns.Add(nwindDataSetInstance.Products.ProductNameColumn.ColumnName);
            foreach(nwindDataSet.Order_DetailsRow row in orderDetailsTable.Rows) {
                row[productNameCol] = nwindDataSetInstance.Products.FindByProductID(row.ProductID).ProductName;
            }
        }
        bool RunMailMerge() {
            if(hasValidResult)
                return true;

            UpdateMailMergeOptions(Forms.MergeRecords.Selected, mailMergeOptions);
            try {
                templateRichEditControl.Document.MailMerge(mailMergeOptions, resultRichEditControl.Document);
                hasValidResult = true;
                return true;
            }
            catch(Exception ex) {
                tabControl.SelectedTabPage = templateTabPage;
                hasValidResult = false;
                XtraMessageBox.Show($"Mail Merge failed:{Environment.NewLine}{ex.Message}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        void RecordSelectorCustomerView_SelectionChanged(object sender, Data.SelectionChangedEventArgs e) {
            hasValidResult = false;
            if(resultRichEditControl.Visible && !RunMailMerge())
                tabControl.SelectedTabPage = templateTabPage;
        }
        void TemplateDocument_ContentChanged(object sender, EventArgs e) {
            UpdateRegionHierarchy();
            hasValidResult = false;
        }
        void UpdateRegionHierarchy() {
            try {
                rootRegionInfo = RichEdit.Document.GetRegionHierarchy(mailMergeOptions.RegionStartTag, mailMergeOptions.RegionEndTag);
            } catch {
                rootRegionInfo = null;
            }
            regionHighlights.Clear();
            AddRegionHighlights(rootRegionInfo);
        }
        void AddRegionHighlights(MailMergeRegionInfo mailMergeRegionInfo) {
            if(mailMergeRegionInfo is null)
                return;
            if(mailMergeRegionInfo.ParentRegion != null) {
                FixedRange regionRange = GetRegionRange(mailMergeRegionInfo);
                Color highlightColor = GetHighlightColor(mailMergeRegionInfo);
                regionHighlights.Add(new CustomDrawHighlightInfo(regionRange, regionHighlightType, highlightColor));
            }

            foreach(var childRegion in mailMergeRegionInfo.Regions) {
                AddRegionHighlights(childRegion);
            }
        }
        FixedRange GetRegionRange(MailMergeRegionInfo mailMergeRegionInfo) {
            DocumentRange regionStartFieldRange = mailMergeRegionInfo.StartField.Range.GetAsFrozen();
            DocumentRange regionEndFieldRange = mailMergeRegionInfo.EndField.Range.GetAsFrozen();
            int regionLength = regionEndFieldRange.End.ToInt() - regionStartFieldRange.Start.ToInt();

            return new FixedRange(regionStartFieldRange.Start.ToInt(), regionLength);
        }
        static Color GetHighlightColor(MailMergeRegionInfo region) {
            if(region.ParentRegion is null)
                return Color.Transparent;
            switch(region.Name) {
                case "Orders": return Color.FromArgb((byte)(0.4 * 255), 129, 212, 250);
                case "Order Details": return Color.FromArgb((byte)(1 * 255), 255, 106, 0);
                default: return Color.Brown;
            }
        }
        void templateRichEditControl_BeforePagePaint(object sender, BeforePagePaintEventArgs e) {
            if(!HighlightingEnabled || e.CanvasOwnerType == CanvasOwnerType.Printer || regionHighlights.Count == 0)
                return;

            var visibleRegionHighlights = regionHighlights.Where(rh => e.Page.IsRangeVisible(rh.HighlightRange)).ToList();     
            var highlightPainter = new CustomDrawPagePainter(resultRichEditControl) {
                LayoutRowHighlights = visibleRegionHighlights
            };
            e.Painter = highlightPainter;        
        }
        void highlightingEnabledBarItem_CheckedChanged(object sender, ItemClickEventArgs e) {
            var barItem = (sender as BarCheckItem);
            HighlightingEnabled = barItem.Checked;
            if(HighlightingEnabled && rootRegionInfo is null) {
                try {
                    rootRegionInfo = templateRichEditControl.Document.GetRegionHierarchy(mailMergeOptions.RegionStartTag, mailMergeOptions.RegionEndTag);
                }
                catch(Exception ex) {
                    HighlightingEnabled = false;
                    barItem.Checked = false;
                    XtraMessageBox.Show($"Regions are invalid:{Environment.NewLine}{ex.Message}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void TabControl_SelectedPageChanging(object sender, XtraTab.TabPageChangingEventArgs e) {
            if(e.Page == resultTabPage && !RunMailMerge()) {
                e.Cancel = true;
            }
        }
        void TabControl_SelectedPageChanged(object sender, XtraTab.TabPageChangedEventArgs e) {
            if(e.Page == templateTabPage) {
                richEditBarController1.RichEditControl = templateRichEditControl;
                highlightRegionsBarItem.Enabled = true;
            } else if(e.Page == resultTabPage) {
                richEditBarController1.RichEditControl = resultRichEditControl;
                highlightRegionsBarItem.Enabled = false;
            }
        }
        void mergeToNewDocumentItem_ItemClick(object sender, ItemClickEventArgs e) {
            MergeToNewDocumentClick(sender, e);
        }
    }
}
