using System;
using System.Globalization;
using DevExpress.Spreadsheet;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class MailMergeModuleBase : SpreadSheetTutorialControlBase {
        readonly IWorkbook book;
        readonly CultureInfo culture;
        XtraBars.Ribbon.RibbonPageGroup ribbonPageDemoGroup;
        XtraBars.BarCheckItem hideCommentsCheckItem;
        DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1;
        DevExpress.Utils.ToolTipItem toolTipItem1;
        DevExpress.Utils.SuperToolTip superToolTip1;

        protected MailMergeModuleBase() {
            culture = DefaultCulture;
            InitializeComponent();
            CreateDemoGroup();
            spreadsheetControl1.Options.Culture = culture;
            ribbonPageDemoGroup.Visible = ShowHideCommentsItem;
            spreadsheetDockManager1.ForceInitialize();
            filteringDockPanel.Visibility = ShowFilterPanel ? DockVisibility.Visible : DockVisibility.Hidden;
            mailMergeParametersDockPanel.Visibility = ShowParametersPanel ? DockVisibility.Visible : DockVisibility.Hidden;
            spreadsheetControl1.BeginUpdate();
            book = spreadsheetControl1.Document;
            LoadTemplate(spreadsheetControl1);
            LoadData(book);
            spreadsheetControl1.CreateCommand(Commands.SpreadsheetCommandId.MailMergeShowRanges).Execute();
            spreadsheetControl1.Document.History.Clear();
            spreadsheetControl1.EndUpdate();
        }
        void CreateDemoGroup() {
            ribbonPageDemoGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            hideCommentsCheckItem = new BarCheckItem();
            toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            superToolTip1 = new DevExpress.Utils.SuperToolTip();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailMergeModuleBase));
            mailMergeRibbonPage1.Groups.Add(ribbonPageDemoGroup);
            ribbonPageDemoGroup.ItemLinks.Add(hideCommentsCheckItem);
            ribbonPageDemoGroup.Name = "ribbonPageDemoGroup";
            ribbonPageDemoGroup.ShowCaptionButton = false;
            ribbonPageDemoGroup.Text = "Demo";
            ribbonControl1.Items.Add(hideCommentsCheckItem);
            hideCommentsCheckItem.Caption = "Hide Comments";
            hideCommentsCheckItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            hideCommentsCheckItem.Description = "Show or hide descriptive comments in the template.";
            hideCommentsCheckItem.Id = 230;
            hideCommentsCheckItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("hideCommentsCheckItem.ImageOptions.Image")));
            hideCommentsCheckItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("hideCommentsCheckItem.ImageOptions.LargeImage")));
            hideCommentsCheckItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("hideCommentsCheckItem.ImageOptions.SvgImage")));
            hideCommentsCheckItem.Name = "hideCommentsCheckItem";
            hideCommentsCheckItem.RibbonStyle = XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipTitleItem1.Text = "Hide Comments";
            toolTipItem1.Text = "Show or hide descriptive comments in the template.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            hideCommentsCheckItem.SuperTip = superToolTip1;
            hideCommentsCheckItem.CheckedChanged += hideCommentsCheckItem_ItemClick;
        }
        protected virtual bool ShowHideCommentsItem {
            get {
                return true;
            }
        }

        protected virtual bool ShowFilterPanel {
            get {
                return true;
            }
        }

        protected virtual bool ShowParametersPanel {
            get {
                return false;
            }
        }

        protected bool ShowSalesManagers {
            get {
                return checkEdit0.Checked;
            }
        }

        protected bool ShowInsideSalesCoordinators {
            get {
                return checkEdit1.Checked;
            }
        }

        protected bool ShowSalesRepresentatives {
            get {
                return checkEdit2.Checked;
            }
        }

        public override bool ShowWithPaddings {
            get {
                return true;
            }
        }

        protected override void DoShow() {
            ribbonControl1.SelectedPage = mailMergeRibbonPage1;
            spreadsheetBarController1.Control.Focus();

            base.DoShow();
        }
        private void hideCommentsCheckItem_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            HideComments(book, !hideCommentsCheckItem.Checked);
        }
        private void checkEdit_CheckedChanged(object sender, System.EventArgs e) {
            ChangeFilter(book);
        }

        protected virtual void LoadTemplate(SpreadsheetControl spreadsheetControl) {
        }
        protected virtual void LoadData(IWorkbook book) {
        }
        protected virtual void ChangeFilter(IWorkbook book) {
            throw new NotImplementedException();
        }
        protected virtual void HideComments(IWorkbook book, bool visible) {
            throw new NotImplementedException();
        }
    }
}
