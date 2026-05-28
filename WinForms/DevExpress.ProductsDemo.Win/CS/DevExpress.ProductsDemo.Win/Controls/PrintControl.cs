using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.Drawing;
using DevExpress.Drawing.Printing;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using System.Drawing.Printing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace DevExpress.ProductsDemo.Win.Controls {
    public partial class PrintControl : RibbonApplicationUserControl {
        GalleryItem memoStyle, tableStyle;
        public PrintControl() {
            InitializeComponent();
            splitContainer1.Panel1MinSize = layoutControlGroup1.MinSize.Width + 6;
            this.ddbOrientation.DropDownControl = CreateOrientationGallery();
            this.ddbMargins.DropDownControl = CreateMarginsGallery();
            this.ddbPaperSize.DropDownControl = CreatePageSizeGallery();
            this.ddbCollate.DropDownControl = CreateCollateGallery();
            this.ddbPrinter.DropDownControl = CreatePrintersGallery();
            this.ddbDuplex.DropDownControl = CreateDuplexGallery();
            this.ddbPrintStyle.DropDownControl = CreatePrintStyleGallery();
            updatedZoom = true;
            zoomTextEdit.EditValue = 70;
            updatedZoom = false;
        }
        int GetZoomValue() {
            if(zoomTrackBarControl1.Value <= 40)
                return 10 + 90 * (zoomTrackBarControl1.Value - 0) / 40;
            else
                return 100 + 400 * (zoomTrackBarControl1.Value - 40) / 40;
        }
        int ZoomValueToValue(int zoomValue) {
            if(zoomValue < 100)
                return Math.Min(80, Math.Max(0, (zoomValue - 10) * 40 / 90));
            return Math.Min(80, Math.Max(0, (zoomValue - 100) * 40 / 400 + 40));
        }
        bool updatedZoom = false;
        private void zoomTrackBarControl1_EditValueChanged(object sender, EventArgs e) {
            if(updatedZoom) return;
            updatedZoom = true;
            try {
                zoomTextEdit.EditValue = GetZoomValue();
            }
            finally {
                updatedZoom = false;
            }
        }
        public void InitPrintingSystem() {
            frmMain frm = BackstageView.Ribbon.FindForm() as frmMain;
            BarManager manager = frm == null || frm.Ribbon == null? null: frm.Ribbon.Manager;
            ((GalleryDropDown)this.ddbOrientation.DropDownControl).Manager = manager;
            ((GalleryDropDown)this.ddbMargins.DropDownControl).Manager = manager;
            ((GalleryDropDown)this.ddbPaperSize.DropDownControl).Manager = manager;
            ((GalleryDropDown)this.ddbCollate.DropDownControl).Manager = manager;
            ((GalleryDropDown)this.ddbPrinter.DropDownControl).Manager = manager;
            ((GalleryDropDown)this.ddbDuplex.DropDownControl).Manager = manager;
            ((GalleryDropDown)this.ddbPrintStyle.DropDownControl).Manager = manager;
            lciPrintStyle.Visibility = frm.CurrentRichEdit == null ? DevExpress.XtraLayout.Utils.LayoutVisibility.Never : 
                DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            CreateDocument();
        }
        void CreateDocument() {
            PrintingSystem ps = new PrintingSystem();
            if(true.Equals(printControl1.Tag))
                ps.StartPrint -= new PrintDocumentEventHandler(OnStartPrint);
            printControl1.PrintingSystem = ps;
            ps.StartPrint += new PrintDocumentEventHandler(OnStartPrint);
            printControl1.Tag = true;
            CreateLink(ps);
            this.pageButtonEdit.EditValue = 1;
            UpdatePagesInfo();
        }
        void CreateLink(PrintingSystem ps) {
            frmMain frm = BackstageView.Ribbon.FindForm() as frmMain;
            bool showMemo = memoStyle.Checked && frm.CurrentRichEdit != null;
            if(showMemo) {
                Link link = new Link(ps);
                link.RtfReportHeader = frm.CurrentRichEdit.RtfText;
                link.PaperKind = GetPaperKind();
                link.Landscape = GetLandscape();
                link.Margins = GetMargins();
                link.CreateDocument();
            } else {
                PrintableComponentLink link = new PrintableComponentLink(ps);
                link.Component = frm.CurrentPrintableComponent;
                link.PaperKind = GetPaperKind();
                link.Landscape = GetLandscape();
                link.Margins = GetMargins();
                link.CreateDocument();
            }
        }
        void OnStartPrint(object sender, PrintDocumentEventArgs e) {
            e.PrintDocument.PrinterSettings.Copies = (short)this.copySpinEdit.Value;
            GetMargins();
            e.PrintDocument.PrinterSettings.Collate = (bool)this.ddbCollate.Tag;
            e.PrintDocument.PrinterSettings.Duplex = ((bool)this.ddbDuplex.Tag)? Duplex.Horizontal: Duplex.Simplex;
        }
        private void zoomTextEdit_EditValueChanged(object sender, EventArgs e) {
            try {
                int zoomValue = Int32.Parse((string)zoomTextEdit.EditValue.ToString());
                this.zoomTrackBarControl1.Value = ZoomValueToValue(zoomValue);
                this.printControl1.Zoom = 0.01f * (int)zoomValue;
            }
            catch(Exception) { }
        }
        GalleryDropDown CreateListBoxGallery() {
            GalleryDropDown res = new GalleryDropDown();
            res.Gallery.FixedImageSize = false;
            res.Gallery.ShowItemText = true;
            res.Gallery.ColumnCount = 1;
            res.Gallery.CheckDrawMode = CheckDrawMode.OnlyImage;
            res.Gallery.ShowGroupCaption = false;
            res.Gallery.AutoSize = GallerySizeMode.Vertical;
            res.Gallery.SizeMode = GallerySizeMode.None;
            res.Gallery.ShowScrollBar = ShowScrollBar.Hide;
            res.Gallery.ItemCheckMode = ItemCheckMode.SingleRadio;
            res.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            res.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            res.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            res.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
            res.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            res.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            res.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
            res.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            res.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;

            res.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            res.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            res.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = true;
            res.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            res.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = true;
            res.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            res.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = true;
            res.Gallery.Groups.Add(new GalleryItemGroup());
            res.Gallery.StretchItems = true;

            return res;
        }
        GalleryDropDown CreateOrientationGallery() {
            GalleryDropDown res = CreateListBoxGallery();
            GalleryItem portraitItem = new GalleryItem();
            portraitItem.Image = Properties.Resources.PageOrientationPortrait;
            portraitItem.ImageOptions.SvgImage = Properties.Resources.PageOrientationPortrait1;
            portraitItem.Caption = Properties.Resources.PortraitOrientation;
            GalleryItem landscapeItem = new GalleryItem();
            landscapeItem.Image = Properties.Resources.PageOrientationLandscape;
            landscapeItem.ImageOptions.SvgImage = Properties.Resources.PageOrientationLandscape1;
            landscapeItem.Caption = Properties.Resources.LandscapeOrientation;
            res.Gallery.Groups[0].Items.Add(portraitItem);
            res.Gallery.Groups[0].Items.Add(landscapeItem);
            res.Gallery.ItemCheckedChanged += new GalleryItemEventHandler(OnOrientationGalleryItemCheckedChanged);
            portraitItem.Checked = true;
            return res;
        }
        GalleryDropDown CreateMarginsGallery() {
            GalleryDropDown res = CreateListBoxGallery();
            GalleryItem normal = new GalleryItem();
            normal.Image = Properties.Resources.PageMarginsNormal;
            normal.ImageOptions.SvgImage = Properties.Resources.PageMarginsNormal1;
            normal.Caption = Properties.Resources.MarginsNormal;
            normal.Description = Properties.Resources.MarginsNormalDescription;
            normal.Tag = new Padding(25, 25, 25, 25);
            GalleryItem narrow = new GalleryItem();
            narrow.Image = Properties.Resources.PageMarginsNarrow;
            narrow.ImageOptions.SvgImage = Properties.Resources.PageMarginsNarrow1;
            narrow.Caption = Properties.Resources.MarginsNarrow;
            narrow.Description = Properties.Resources.MarginsNarrowDescription;
            narrow.Tag = new Padding(12, 12, 12, 12);
            GalleryItem moderate = new GalleryItem();
            moderate.Image = Properties.Resources.PageMarginsModerate;
            moderate.ImageOptions.SvgImage = Properties.Resources.PageMarginsModerate1;
            moderate.Caption = Properties.Resources.MarginsModerate;
            moderate.Description = Properties.Resources.MarginsModerateDescription;
            moderate.Tag = new Padding(19, 25, 19, 25);
            GalleryItem wide = new GalleryItem();
            wide.Image = Properties.Resources.PageMarginsWide;
            wide.ImageOptions.SvgImage = Properties.Resources.PageMarginsWide1;
            wide.Caption = Properties.Resources.MarginsWide;
            wide.Description = Properties.Resources.MarginsWideDescription;
            wide.Tag = new Padding(50, 25, 50, 25);
            res.Gallery.Groups[0].Items.Add(normal);
            res.Gallery.Groups[0].Items.Add(narrow);
            res.Gallery.Groups[0].Items.Add(moderate);
            res.Gallery.Groups[0].Items.Add(wide);
            res.Gallery.ItemCheckedChanged += new GalleryItemEventHandler(OnMarginsGalleryItemCheckedChanged);
            normal.Checked = true;
            return res;
        }
        GalleryDropDown CreatePageSizeGallery() {
            GalleryDropDown res = CreateListBoxGallery();
            GalleryItem letter = new GalleryItem();
            letter.Image = Properties.Resources.PaperKind_Letter;
            letter.ImageOptions.SvgImage = Properties.Resources.PaperKind_Letter1;
            letter.Caption = Properties.Resources.PaperKindLetter;
            letter.Description = Properties.Resources.PaperKindLetterDescription;
            letter.Tag = DXPaperKind.Letter;
            GalleryItem tabloid = new GalleryItem();
            tabloid.Image = Properties.Resources.PaperKind_Tabloid;
            tabloid.ImageOptions.SvgImage = Properties.Resources.PaperKind_Tabloid1;
            tabloid.Caption = Properties.Resources.PaperKindTabloid;
            tabloid.Description = Properties.Resources.PaperKindTabloidDescription;
            tabloid.Tag = DXPaperKind.Tabloid;
            GalleryItem legal = new GalleryItem();
            legal.Image = Properties.Resources.PaperKind_Legal;
            legal.ImageOptions.SvgImage = Properties.Resources.PaperKind_Legal1;
            legal.Caption = Properties.Resources.PaperKindLegal;
            legal.Description = Properties.Resources.PaperKindLegalDescription;
            legal.Tag = DXPaperKind.Legal;
            GalleryItem executive = new GalleryItem();
            executive.Image = Properties.Resources.PaperKind_Executive;
            executive.ImageOptions.SvgImage = Properties.Resources.PaperKind_Executive1;
            executive.Caption = Properties.Resources.PaperKindExecutive;
            executive.Description = Properties.Resources.PaperKindExecutiveDescription;
            executive.Tag = DXPaperKind.Executive;
            GalleryItem a3 = new GalleryItem();
            a3.Image = Properties.Resources.PaperKind_A3;
            a3.ImageOptions.SvgImage = Properties.Resources.PaperKind_A31;
            a3.Caption = Properties.Resources.PaperKindA3;
            a3.Description = Properties.Resources.PaperKindA3Description;
            a3.Tag = DXPaperKind.A3;
            GalleryItem a4 = new GalleryItem();
            a4.Image = Properties.Resources.PaperKind_A4;
            a4.ImageOptions.SvgImage = Properties.Resources.PaperKind_A41;
            a4.Caption = Properties.Resources.PaperKindA4;
            a4.Description = Properties.Resources.PaperKindA4Description;
            a4.Tag = DXPaperKind.A4;
            GalleryItem a5 = new GalleryItem();
            a5.Image = Properties.Resources.PaperKind_A5;
            a5.ImageOptions.SvgImage = Properties.Resources.PaperKind_A51;
            a5.Caption = Properties.Resources.PaperKindA5;
            a5.Description = Properties.Resources.PaperKindA5Description;
            a5.Tag = DXPaperKind.A5;
            GalleryItem a6 = new GalleryItem();
            a6.Image = Properties.Resources.PaperKind_A6;
            a6.ImageOptions.SvgImage = Properties.Resources.PaperKind_A61;
            a6.Caption = Properties.Resources.PaperKindA6;
            a6.Description = Properties.Resources.PaperKindA6Description;
            a6.Tag = DXPaperKind.A6;
            res.Gallery.Groups[0].Items.Add(letter);
            res.Gallery.Groups[0].Items.Add(tabloid);
            res.Gallery.Groups[0].Items.Add(legal);
            res.Gallery.Groups[0].Items.Add(executive);
            res.Gallery.Groups[0].Items.Add(a3);
            res.Gallery.Groups[0].Items.Add(a4);
            res.Gallery.Groups[0].Items.Add(a5);
            res.Gallery.Groups[0].Items.Add(a6);
            res.Gallery.ItemCheckedChanged += new GalleryItemEventHandler(OnPaperSizeGalleryItemCheckedChanged);
            a4.Checked = true;
            return res;
        }
        GalleryDropDown CreateCollateGallery() {
            GalleryDropDown res = CreateListBoxGallery();
            GalleryItem collated = new GalleryItem();
            collated.Image = Properties.Resources.MultiplePagesLarge;
            collated.ImageOptions.SvgImage = Properties.Resources.MultiplePagesLarge1;
            collated.Caption = Properties.Resources.Collated;
            collated.Description = Properties.Resources.CollatedDescription;
            collated.Tag = true;
            GalleryItem uncollated = new GalleryItem();
            uncollated.Image = Properties.Resources.MultiplePagesLarge;
            uncollated.ImageOptions.SvgImage = Properties.Resources.MultiplePagesLarge1;
            uncollated.Caption = Properties.Resources.Uncollated;
            uncollated.Description = Properties.Resources.UncollatedDescription;
            uncollated.Tag = false;
            res.Gallery.Groups[0].Items.Add(collated);
            res.Gallery.Groups[0].Items.Add(uncollated);
            res.Gallery.ItemCheckedChanged += new GalleryItemEventHandler(OnCollateGalleryItemCheckedChanged);
            collated.Checked = true;
            return res;
        }
        GalleryDropDown CreateDuplexGallery() {
            GalleryDropDown res = CreateListBoxGallery();
            GalleryItem oneSided = new GalleryItem();
            oneSided.Image = Properties.Resources.MultiplePagesLarge;
            oneSided.ImageOptions.SvgImage = Properties.Resources.MultiplePagesLarge1;
            oneSided.Caption = Properties.Resources.OneSide;
            oneSided.Description = Properties.Resources.OneSideDescription;
            oneSided.Tag = false;
            GalleryItem twoSided = new GalleryItem();
            twoSided.Image = Properties.Resources.MultiplePagesLarge;
            twoSided.ImageOptions.SvgImage = Properties.Resources.MultiplePagesLarge1;
            twoSided.Caption = Properties.Resources.TwoSide;
            twoSided.Description = Properties.Resources.TwoSideDescription;
            twoSided.Tag = false;
            res.Gallery.Groups[0].Items.Add(oneSided);
            res.Gallery.Groups[0].Items.Add(twoSided);
            res.Gallery.ItemCheckedChanged += new GalleryItemEventHandler(OnDuplexGalleryItemCheckedChanged);
            oneSided.Checked = true;
            return res;
        }
        GalleryDropDown CreatePrintStyleGallery() {
            GalleryDropDown res = CreateListBoxGallery();
            res.Gallery.ItemCheckMode = ItemCheckMode.SingleRadio;
            memoStyle = new GalleryItem();
            memoStyle.Image = Properties.Resources.MemoStyle;
            memoStyle.ImageOptions.SvgImage = Properties.Resources.MemoStyle1;
            memoStyle.Caption = Properties.Resources.MemoStyleString;
            tableStyle = new GalleryItem();
            tableStyle.Image = Properties.Resources.TableStyle;
            tableStyle.ImageOptions.SvgImage = Properties.Resources.TableStyle1;
            tableStyle.Caption = Properties.Resources.TableStyleString;
            res.Gallery.Groups[0].Items.Add(memoStyle);
            res.Gallery.Groups[0].Items.Add(tableStyle);
            res.Gallery.ItemCheckedChanged += new GalleryItemEventHandler(OnPrintStyleGalleryItemCheckedChanged);
            memoStyle.Checked = true;
            return res;
        }
        void OnPrintStyleGalleryItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            this.ddbPrintStyle.Text = e.Item.Caption;
            this.ddbPrintStyle.Image = e.Item.Image;
            this.ddbPrintStyle.ImageOptions.SvgImage = e.Item.ImageOptions.SvgImage;
            if(printControl1.PrintingSystem != null)
                CreateDocument();
        }
        void OnDuplexGalleryItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            this.ddbDuplex.Text = e.Item.Caption;
            this.ddbDuplex.Image = e.Item.Image;
            this.ddbDuplex.ImageOptions.SvgImage = e.Item.ImageOptions.SvgImage;
            this.ddbDuplex.Tag = e.Item.Tag;
        }
        GalleryDropDown CreatePrintersGallery() {
            GalleryDropDown res = CreateListBoxGallery();
            PrinterSettings ps = new PrinterSettings();
            GalleryItem defaultPrinter = null;
            try {
                foreach(string str in PrinterSettings.InstalledPrinters) {
                    GalleryItem item = new GalleryItem();
                    item.Image = Properties.Resources.PrintDirectLarge;
                    item.ImageOptions.SvgImage = Properties.Resources.Print1;
                    item.Caption = str;
                    res.Gallery.Groups[0].Items.Add(item);
                    ps.PrinterName = str;
                    if(ps.IsDefaultPrinter)
                        defaultPrinter = item;
                }
            } catch { }
            res.Gallery.ItemCheckedChanged += new GalleryItemEventHandler(OnPrinterGalleryItemCheckedChanged);
            if(defaultPrinter != null)
                defaultPrinter.Checked = true;
            return res;
        }
        void OnMarginsGalleryItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            this.ddbMargins.Image = e.Item.Image;
            this.ddbMargins.ImageOptions.SvgImage = e.Item.ImageOptions.SvgImage;
            this.ddbMargins.Text = e.Item.Caption;
            this.ddbMargins.Tag = e.Item.Tag;
            if(this.printControl1.PrintingSystem != null) {
                DXMargins margins = GetMargins();
                this.printControl1.PrintingSystem.PageSettings.LeftMargin = (int)margins.Left;
                this.printControl1.PrintingSystem.PageSettings.RightMargin = (int)margins.Right;
                this.printControl1.PrintingSystem.PageSettings.TopMargin = (int)margins.Top;
                this.printControl1.PrintingSystem.PageSettings.BottomMargin = (int)margins.Bottom;
            }
            UpdatePageButtonsEnabledState();
        }
        DXMargins GetMargins() {
            Padding p = (Padding)this.ddbMargins.Tag;
            return new DXMargins((float)(p.Left * 3.9), (float)(p.Right * 3.9), (float)(p.Top * 3.9), (float)(p.Bottom * 3.9));
        }
        void OnPrinterGalleryItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            this.ddbPrinter.Text = e.Item.Caption;
            this.ddbPrinter.Image = e.Item.Image;
            this.ddbPrinter.ImageOptions.SvgImage = e.Item.ImageOptions.SvgImage;
        }
        void OnCollateGalleryItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            this.ddbCollate.Image = e.Item.Image;
            this.ddbCollate.ImageOptions.SvgImage = e.Item.ImageOptions.SvgImage;
            this.ddbCollate.Text = e.Item.Caption;
            this.ddbCollate.Tag = e.Item.Tag;
        }
        void OnPaperSizeGalleryItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            this.ddbPaperSize.Image = e.Item.Image;
            this.ddbPaperSize.ImageOptions.SvgImage = e.Item.ImageOptions.SvgImage;
            this.ddbPaperSize.Text = e.Item.Caption;
            this.ddbPaperSize.Tag = e.Item.Tag;
            if(this.printControl1.PrintingSystem != null) 
                this.printControl1.PrintingSystem.PageSettings.PaperKind = GetPaperKind();
            UpdatePageButtonsEnabledState();
        }
        DXPaperKind GetPaperKind() {
            return (DXPaperKind)this.ddbPaperSize.Tag;
        }
        void OnOrientationGalleryItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            ddbOrientation.Text = e.Item.Caption;
            ddbOrientation.Image = e.Item.Image;
            ddbOrientation.ImageOptions.SvgImage = e.Item.ImageOptions.SvgImage;
            if(printControl1.PrintingSystem != null)
                this.printControl1.PrintingSystem.PageSettings.Landscape = GetLandscape();
            UpdatePageButtonsEnabledState();
        }
        bool GetLandscape() {
            if(ddbOrientation.DropDownControl != null)
                return ((GalleryDropDown)ddbOrientation.DropDownControl).Gallery.Groups[0].Items[1].Checked;
            return false;
        }
        private void printButton_Click(object sender, EventArgs e) {
            ((PrintingSystem)this.printControl1.PrintingSystem).Print(this.ddbPrinter.Text);
        }

        private void pageButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            int pageIndex = (int)this.pageButtonEdit.EditValue;
            if(e.Button.Kind == ButtonPredefines.Left) {
                if(pageIndex > 1)
                    pageIndex--;
            }
            else if(e.Button.Kind == ButtonPredefines.Right) {
                if(pageIndex < this.printControl1.PrintingSystem.Pages.Count)
                    pageIndex ++;
            }
            this.pageButtonEdit.EditValue = pageIndex;
        }

        private void pageButtonEdit_EditValueChanging(object sender, ChangingEventArgs e) {
            try {
                int pageIndex = Int32.Parse(e.NewValue.ToString());
                if(pageIndex < 1)
                    pageIndex = 1;
                else if(pageIndex > this.printControl1.PrintingSystem.Pages.Count)
                    pageIndex = this.printControl1.PrintingSystem.Pages.Count;
                e.NewValue = pageIndex;
            }
            catch(Exception) {
                e.NewValue = 1;
            }
        }
        void UpdatePagesInfo() {
            if(printControl1.PrintingSystem != null) {
                this.pageButtonEdit.Properties.DisplayFormat.FormatString = Properties.Resources.PageInfo + printControl1.PrintingSystem.Pages.Count;
                this.printButton.Enabled = printControl1.PrintingSystem.Pages.Count > 0;
                this.pageButtonEdit.Enabled = printControl1.PrintingSystem.Pages.Count > 0;
            }
        }
        void UpdatePageButtonsEnabledState(int pageIndex) {
            if(printControl1.PrintingSystem == null) return;
            this.pageButtonEdit.Properties.Buttons[0].Enabled = pageIndex != 1;
            this.pageButtonEdit.Properties.Buttons[1].Enabled = pageIndex != printControl1.PrintingSystem.Pages.Count;
            UpdatePagesInfo();
        }
        void UpdatePageButtonsEnabledState() {
            UpdatePageButtonsEnabledState(this.printControl1.SelectedPageIndex + 1);
        }
        private void pageButtonEdit_EditValueChanged(object sender, EventArgs e) {
            int pageIndex = Convert.ToInt32(this.pageButtonEdit.EditValue);
            this.printControl1.SelectedPageIndex = pageIndex - 1;
            UpdatePageButtonsEnabledState(pageIndex);
        }

        private void printControl1_SelectedPageChanged(object sender, EventArgs e) {
            this.pageButtonEdit.EditValue = this.printControl1.SelectedPageIndex + 1;
        }
    }
}
