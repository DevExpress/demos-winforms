using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Internal;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace DevExpress.XtraPivotGrid.Demos {
    public class ViewOptionsChangedEventArgs : EventArgs {
        public ViewOptionsChangedEventArgs(string name, bool value) {
            this.Name = name;
            this.Value = value;
        }
        public string Name { get; set; }
        public bool Value { get; set; }
    }
    public class PivotGridRibbonMenuManager : RibbonMenuManager {
        PivotGridControl currentPivot = null;
        BarSubItem bsiViewOptions;

        public PivotGridControl CurrentPivotGrid { get { return currentPivot; } }

        public event EventHandler<ViewOptionsChangedEventArgs> ViewOptionsChanged;
        public PivotGridRibbonMenuManager(RibbonMainForm form)
            : base(form) {
            CreateOptionsMenu(form.ReservGroup1, form.Ribbon);
        }
        void CreateOptionsMenu(RibbonPageGroup ribbonPageGroup, RibbonControl ribbonControl) {
            ribbonPageGroup.Text = "Options";
            bsiViewOptions = new BarSubItem();
            bsiViewOptions.Caption = "View\n Options";
            MainFormHelper.SetBarButtonImage(bsiViewOptions, "View");
            ribbonControl.Items.Add(bsiViewOptions);
            ribbonPageGroup.ItemLinks.Add(bsiViewOptions);
        }
        public void RefreshOptionsMenu(PivotGridControl pivotGrid) {
            currentPivot = pivotGrid;
            ShowReservGroup1(pivotGrid != null);
            DXperience.Demos.LookAndFeelMenu.ClearOptionItems(Manager);
            DXperience.Demos.LookAndFeelMenu.AddOptionsMenu(bsiViewOptions, ViewOptions, new ItemClickEventHandler(miViewOptions_Click), Manager);
        }
        private object ViewOptions {
            get {
                if(currentPivot == null) return null;
                return currentPivot.OptionsView;
            }
        }
        void miViewOptions_Click(object sender, ItemClickEventArgs e) {
            OptionBarItem item = e.Item as OptionBarItem;
            if(currentPivot != null && item != null) {
                if(currentPivot.OptionsView.RowTotalsLocation == PivotRowTotalsLocation.Tree && item.Caption.Equals("ShowRowTotals"))
                    XtraMessageBox.Show("The ShowRowTotals option must be enabled when the 'Tree' row area mode is used.");
                else {
                    DevExpress.Utils.SetOptions.SetOptionValueByString(item.Caption, ViewOptions, item.Checked);
                    RaiseViewOptionsChanged(item.Caption, item.Checked);
                }
                DXperience.Demos.LookAndFeelMenu.InitOptionsMenu(bsiViewOptions, ViewOptions);
            }
        }
        void RaiseViewOptionsChanged(string name, bool value) {
            if(ViewOptionsChanged != null)
                ViewOptionsChanged(this, new ViewOptionsChangedEventArgs(name, value));
        }
    }
    public class TutorialControl : TutorialControlBase {
        public static bool GetIsCSCode(string moduleName) {
            try {
                return DemoHelper.IsCSharp;
            }
            catch { return true; }
        }
        Color redColor, greenColor, blueColor;
        Color DefaultBlue = Color.FromArgb(39, 63, 133),
            DefaultRed = Color.FromArgb(169, 7, 7),
            DefaultGreen = Color.FromArgb(42, 93, 1);
        static object imlCategory = null;
        static object imlHeaders = null;

        static string[] CategoryNames = new string[] { "Beverages", "Condiments", "Confections", "Dairy Products", "Grains/Cereals", "Meat/Poultry", "Produce", "Seafood" };
        public static int GetCategoryIndexByName(object name) {
            if(name != null)
                for(int i = 0; i < CategoryNames.Length; i++)
                    if(CategoryNames[i] == name.ToString()) return i;
            return -1;
        }
        public static object CategoryImageList {
            get {
                if(imlCategory == null) {
                    DevExpress.Utils.SvgImageCollection _svgImageCollection = new DevExpress.Utils.SvgImageCollection();
                    var @assembly = typeof(TutorialControl).Assembly;
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelper.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.beverages.svg", @assembly)));
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelper.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.condiments.svg", @assembly)));
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelper.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.confections.svg", @assembly)));
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelper.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.dairyProduct.svg", @assembly)));
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelper.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.grainsCereals.svg", @assembly)));
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelper.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.meatPoultry.svg", @assembly)));
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelper.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.produce.svg", @assembly)));
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelper.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.seafood.svg", @assembly)));
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelper.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.sum.svg", @assembly)));
                    imlCategory = _svgImageCollection;
                }
                return imlCategory;
            }
        }
        public static object HeadersImageList {
            get {
                if(imlHeaders == null) {
                    var @assembly = typeof(TutorialControl).Assembly;
                    DevExpress.Utils.SvgImageCollection _svgImageCollection = new DevExpress.Utils.SvgImageCollection();
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelper.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.user.svg", @assembly)));
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelper.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.order_id.svg", @assembly)));
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelper.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.personalID.svg", @assembly)));
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelper.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.productSales.svg", @assembly)));
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelper.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.sum.svg", @assembly)));
                    imlHeaders = _svgImageCollection;
                }
                return imlHeaders;
            }
        }

        public TutorialControl() {
            string module = GetType().Name;
            if(GetIsCSCode(module)) {
                TutorialInfo.WhatsThisCodeFile = GetCSCodePath(module);
                TutorialInfo.WhatsThisXMLFile = GetCSXmlPath(module);
            }
            else {
                TutorialInfo.WhatsThisCodeFile = GetVBCodePath(module);
                TutorialInfo.WhatsThisXMLFile = GetVBXmlPath(module);
            }
        }
#pragma warning disable DX0025 // no path traversal (predefined module name)
        static string GetCSXmlPath(string module) {
            return string.Format("DevExpress.XtraPivotGrid.Demos.CodeInfo.{0}.xml", module);
        }
        static string GetCSCodePath(string module) {
            return string.Format("CS\\PivotGridMainDemo\\Modules\\{0}.cs", module);
        }
        static string GetVBXmlPath(string module) {
            return string.Format("{0}.xml", module);
        }
        static string GetVBCodePath(string module) {
            return string.Format("VB\\PivotGridMainDemo\\Modules\\{0}.vb", module);
        }
#pragma warning restore DX0025
        protected override void SetControlManager(Control ctrl, BarManager manager) {
            PivotGridControl grid = ctrl as PivotGridControl;
            if(grid != null)
                grid.MenuManager = manager;
            BaseEdit be = ctrl as BaseEdit;
            if(be != null)
                be.MenuManager = manager;
        }
        public virtual PivotGridControl ViewOptionsControl {
            get { return null; }
        }
        public virtual bool ShowLookAndFeelMenu {
            get { return true; }
        }
        public Color Red {
            get {
                if(redColor.IsEmpty) {
                    if(LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.Skin)
                        redColor = EditorsSkins.GetSkin(LookAndFeel).Colors.GetColor(EditorsSkins.SkinFilterControlGroupOperatorTextColor);
                    if(redColor.IsEmpty || redColor == Color.Black)
                        redColor = DefaultRed;
                }
                return redColor;
            }
        }
        public Color Blue {
            get {
                if(blueColor.IsEmpty) {
                    if(LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.Skin)
                        blueColor = EditorsSkins.GetSkin(LookAndFeel).Colors.GetColor(EditorsSkins.SkinFilterControlFieldNameTextColor);
                    if(blueColor.IsEmpty || blueColor == Color.Black)
                        blueColor = DefaultBlue;
                }
                return blueColor;
            }
        }
        public Color Green {
            get {
                if(greenColor.IsEmpty) {
                    if(LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.Skin)
                        greenColor = EditorsSkins.GetSkin(LookAndFeel).Colors.GetColor(EditorsSkins.SkinFilterControlOperatorTextColor);
                    if(greenColor.IsEmpty || greenColor == Color.Black)
                        greenColor = DefaultGreen;
                }
                return greenColor;
            }
        }
        protected override void OnStyleChanged() {
            base.OnStyleChanged();
            redColor = Color.Empty;
            blueColor = Color.Empty;
            greenColor = Color.Empty;
        }
        protected virtual bool HideCustFormWhenSwitchDemo {
            get { return true; }
        }
        protected override void DoHide() {
            if(HideCustFormWhenSwitchDemo)
                FindPivotGridAndHideCustForm(this);
        }
        public static void FindPivotGridAndHideCustForm(Control control) {
            if(control.Controls == null)
                return;
            foreach(Control ctrl in control.Controls) {
                FindPivotGridAndHideCustForm(ctrl);
                PivotGridControl pivot = ctrl as PivotGridControl;
                if(pivot == null)
                    continue;
                pivot.DestroyCustomization();
            }
        }
        static DataSet nwindDS;
        protected DataView GetNWindData(string tableName) {
            if(nwindDS == null) {
                string dbFileName = DevAVDataDirectoryHelper.GetFile("nwind.xml");
                if(!string.IsNullOrEmpty(dbFileName)) {
                    SetWaitDialogCaption(string.Format("Loading {0}...", tableName));
                    nwindDS = new DataSet();
                    nwindDS.ReadXml(dbFileName);
                }
                else return null;
            }
            return nwindDS.Tables[tableName].DefaultView;
        }
        protected void UpdateListBoxColor(BaseListBoxControl listBox) {
            if(listBox.Parent.BackColor != Color.Transparent)
                listBox.BackColor = listBox.Parent.BackColor;
            else
                listBox.Appearance.Options.UseBackColor = false;
        }
        #region Print and Export
        protected override void AllowExport() {
            EnabledPrintExportActions(true, ExportFormats.PDF | ExportFormats.HTML | ExportFormats.MHT | ExportFormats.XLS |
                        ExportFormats.RTF | ExportFormats.DOCX | ExportFormats.Text | ExportFormats.XLSX, false);
        }
        public override bool AllowPrintOptions {
            get { return ExportControl != null; }
        }
        public virtual PivotGridControl ExportControl {
            get { return null; }
        }
        Thread thread;
        bool stop;
        protected override void ExportToCore(String filename, string ext) {
            if(ExportControl == null)
                return;
            stop = false;
            thread = new Thread(new ThreadStart(StartExport));
            thread.Start();
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                if(ext == "rtf") ExportControl.ExportToRtf(filename);
                if(ext == "docx") ExportControl.ExportToDocx(filename);
                if(ext == "pdf") ExportControl.ExportToPdf(filename);
                if(ext == "mht") ExportControl.ExportToMht(filename);
                if(ext == "html") ExportControl.ExportToHtml(filename);
                if(ext == "txt") ExportControl.ExportToText(filename);
                if(ext == "xls") ExportControl.ExportToXls(filename);
                if(ext == "xlsx") ExportControl.ExportToXlsx(filename);
            }
            finally {
                EndExport();
                Cursor.Current = currentCursor;
            }
        }
        protected override void ExportToPDF() {
            ExportTo("pdf", "PDF document (*.pdf)|*.pdf");
        }
        protected override void ExportToHTML() {
            ExportTo("html", "HTML document (*.html)|*.html");
        }
        protected override void ExportToMHT() {
            ExportTo("mht", "MHT document (*.mht)|*.mht");
        }
        protected override void ExportToXLS() {
            ExportTo("xls", "XLS document (*.xls)|*.xls");
        }
        protected override void ExportToXLSX() {
            ExportTo("xlsx", "XLSX document (*.xlsx)|*.xlsx");
        }
        protected override void ExportToRTF() {
            ExportTo("rtf", "RTF document (*.rtf)|*.rtf");
        }
        protected override void ExportToDOCX() {
            ExportTo("docx", "DOCX document (*.docx)|*.docx");
        }
        protected override void ExportToText() {
            ExportTo("txt", "Text document (*.txt)|*.txt");
        }
        protected override void PrintPreview() {
            if(ExportControl != null) {
                if(RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm)
                    ExportControl.ShowRibbonPrintPreview();
                else
                    ExportControl.ShowPrintPreview();
            }
        }
        void StartExport() {
            Thread.Sleep(400);
            if(stop)
                return;
            ExportForm progressForm = new ExportForm(this.FindForm());
            progressForm.Show();
            try {
                while(!stop) {
                    Application.DoEvents();
                    Thread.Sleep(100);
                }
            }
            catch {
            }
            progressForm.Dispose();
        }
        void EndExport() {
            stop = true;
            thread.Join();
        }
        #endregion
    }

    public class DemoFormatCondition {
        readonly PivotGridStyleFormatCondition fCondition = null;
        public DemoFormatCondition(PivotGridStyleFormatCondition fCondition) {
            this.fCondition = fCondition;
        }
        public PivotGridStyleFormatCondition StyleCondition {
            get { return fCondition; }
        }
        public override string ToString() {
            if(StyleCondition == null)
                return "Empty condition";
            if(StyleCondition.Condition != FormatConditionEnum.None) {
                if(StyleCondition.Condition == FormatConditionEnum.Between || StyleCondition.Condition == FormatConditionEnum.NotBetween) {
                    return string.Format("{0} {1:c}, {2:c}", StyleCondition.Condition, StyleCondition.Value1, StyleCondition.Value2);
                }
                else return string.Format("{0} {1:c}", StyleCondition.Condition, StyleCondition.Value1);
            }
            return string.Format("Condition Item - Index {0}", Index);
        }
        public int Index {
            get { return StyleCondition.PivotGrid.FormatConditions.IndexOf(StyleCondition); }
        }
    }
}
