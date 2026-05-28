using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraLayout;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.UI;

namespace DevExpress.WindowsMailClient.Win.Modules {
    partial class MailModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation1 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailModule));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            this.richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController(this.components);
            this.pasteItem1 = new DevExpress.XtraRichEdit.UI.PasteItem();
            this.cutItem1 = new DevExpress.XtraRichEdit.UI.CutItem();
            this.copyItem1 = new DevExpress.XtraRichEdit.UI.CopyItem();
            this.pasteSpecialItem1 = new DevExpress.XtraRichEdit.UI.PasteSpecialItem();
            this.changeFontNameItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontNameItem();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.changeFontSizeItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontSizeItem();
            this.repositoryItemRichEditFontSizeEdit1 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit();
            this.editMail = new DevExpress.XtraRichEdit.RichEditControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.fontSizeIncreaseItem1 = new DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem();
            this.fontSizeDecreaseItem1 = new DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem();
            this.barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            this.toggleFontBoldItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontBoldItem();
            this.toggleFontItalicItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontItalicItem();
            this.toggleFontUnderlineItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem();
            this.toggleFontDoubleUnderlineItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem();
            this.toggleFontStrikeoutItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem();
            this.toggleFontDoubleStrikeoutItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem();
            this.toggleFontSuperscriptItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem();
            this.toggleFontSubscriptItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem();
            this.barButtonGroup3 = new DevExpress.XtraBars.BarButtonGroup();
            this.changeFontColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontColorItem();
            this.changeFontHighlightColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontHighlightColorItem();
            this.changeTextCaseItem1 = new DevExpress.XtraRichEdit.UI.ChangeTextCaseItem();
            this.makeTextUpperCaseItem1 = new DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem();
            this.makeTextLowerCaseItem1 = new DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem();
            this.capitalizeEachWordCaseItem1 = new DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem();
            this.toggleTextCaseItem1 = new DevExpress.XtraRichEdit.UI.ToggleTextCaseItem();
            this.clearFormattingItem1 = new DevExpress.XtraRichEdit.UI.ClearFormattingItem();
            this.barButtonGroup4 = new DevExpress.XtraBars.BarButtonGroup();
            this.toggleBulletedListItem1 = new DevExpress.XtraRichEdit.UI.ToggleBulletedListItem();
            this.toggleNumberingListItem1 = new DevExpress.XtraRichEdit.UI.ToggleNumberingListItem();
            this.toggleMultiLevelListItem1 = new DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem();
            this.barButtonGroup5 = new DevExpress.XtraBars.BarButtonGroup();
            this.decreaseIndentItem1 = new DevExpress.XtraRichEdit.UI.DecreaseIndentItem();
            this.increaseIndentItem1 = new DevExpress.XtraRichEdit.UI.IncreaseIndentItem();
            this.toggleShowWhitespaceItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem();
            this.barButtonGroup6 = new DevExpress.XtraBars.BarButtonGroup();
            this.toggleParagraphAlignmentLeftItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem();
            this.toggleParagraphAlignmentCenterItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem();
            this.toggleParagraphAlignmentRightItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem();
            this.toggleParagraphAlignmentJustifyItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem();
            this.barButtonGroup7 = new DevExpress.XtraBars.BarButtonGroup();
            this.changeParagraphLineSpacingItem1 = new DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem();
            this.setSingleParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem();
            this.setSesquialteralParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem();
            this.setDoubleParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem();
            this.showLineSpacingFormItem1 = new DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem();
            this.addSpacingBeforeParagraphItem1 = new DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem();
            this.removeSpacingBeforeParagraphItem1 = new DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem();
            this.addSpacingAfterParagraphItem1 = new DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem();
            this.removeSpacingAfterParagraphItem1 = new DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem();
            this.changeParagraphBackColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem();
            this.galleryChangeStyleItem1 = new DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem();
            this.findItem1 = new DevExpress.XtraRichEdit.UI.FindItem();
            this.replaceItem1 = new DevExpress.XtraRichEdit.UI.ReplaceItem();
            this.insertPageBreakItem21 = new DevExpress.XtraRichEdit.UI.InsertPageBreakItem2();
            this.insertTableItem1 = new DevExpress.XtraRichEdit.UI.InsertTableItem();
            this.insertPictureItem1 = new DevExpress.XtraRichEdit.UI.InsertPictureItem();
            this.insertFloatingPictureItem1 = new DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem();
            this.insertBookmarkItem1 = new DevExpress.XtraRichEdit.UI.InsertBookmarkItem();
            this.insertHyperlinkItem1 = new DevExpress.XtraRichEdit.UI.InsertHyperlinkItem();
            this.editPageHeaderItem1 = new DevExpress.XtraRichEdit.UI.EditPageHeaderItem();
            this.editPageFooterItem1 = new DevExpress.XtraRichEdit.UI.EditPageFooterItem();
            this.insertPageNumberItem1 = new DevExpress.XtraRichEdit.UI.InsertPageNumberItem();
            this.insertPageCountItem1 = new DevExpress.XtraRichEdit.UI.InsertPageCountItem();
            this.insertTextBoxItem1 = new DevExpress.XtraRichEdit.UI.InsertTextBoxItem();
            this.insertSymbolItem1 = new DevExpress.XtraRichEdit.UI.InsertSymbolItem();
            this.homeRibbonPage1 = new DevExpress.XtraRichEdit.UI.HomeRibbonPage();
            this.fontRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.FontRibbonPageGroup();
            this.paragraphRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup();
            this.insertRibbonPage1 = new DevExpress.XtraRichEdit.UI.InsertRibbonPage();
            this.tablesRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup();
            this.illustrationsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup();
            this.linksRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup();
            this.textRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TextRibbonPageGroup();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tEditSubject = new DevExpress.XtraEditors.TextEdit();
            this.tEditTo = new DevExpress.XtraEditors.TokenEdit();
            this.teFrom = new DevExpress.XtraEditors.TokenEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tEditSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEditTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            
            
            
            this.richEditBarController1.BarItems.Add(this.pasteItem1);
            this.richEditBarController1.BarItems.Add(this.cutItem1);
            this.richEditBarController1.BarItems.Add(this.copyItem1);
            this.richEditBarController1.BarItems.Add(this.pasteSpecialItem1);
            this.richEditBarController1.BarItems.Add(this.changeFontNameItem1);
            this.richEditBarController1.BarItems.Add(this.changeFontSizeItem1);
            this.richEditBarController1.BarItems.Add(this.fontSizeIncreaseItem1);
            this.richEditBarController1.BarItems.Add(this.fontSizeDecreaseItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontBoldItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontItalicItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontUnderlineItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontDoubleUnderlineItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontStrikeoutItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontDoubleStrikeoutItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontSuperscriptItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontSubscriptItem1);
            this.richEditBarController1.BarItems.Add(this.changeFontColorItem1);
            this.richEditBarController1.BarItems.Add(this.changeFontHighlightColorItem1);
            this.richEditBarController1.BarItems.Add(this.changeTextCaseItem1);
            this.richEditBarController1.BarItems.Add(this.makeTextUpperCaseItem1);
            this.richEditBarController1.BarItems.Add(this.makeTextLowerCaseItem1);
            this.richEditBarController1.BarItems.Add(this.capitalizeEachWordCaseItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTextCaseItem1);
            this.richEditBarController1.BarItems.Add(this.clearFormattingItem1);
            this.richEditBarController1.BarItems.Add(this.toggleBulletedListItem1);
            this.richEditBarController1.BarItems.Add(this.toggleNumberingListItem1);
            this.richEditBarController1.BarItems.Add(this.toggleMultiLevelListItem1);
            this.richEditBarController1.BarItems.Add(this.decreaseIndentItem1);
            this.richEditBarController1.BarItems.Add(this.increaseIndentItem1);
            this.richEditBarController1.BarItems.Add(this.toggleParagraphAlignmentLeftItem1);
            this.richEditBarController1.BarItems.Add(this.toggleParagraphAlignmentCenterItem1);
            this.richEditBarController1.BarItems.Add(this.toggleParagraphAlignmentRightItem1);
            this.richEditBarController1.BarItems.Add(this.toggleParagraphAlignmentJustifyItem1);
            this.richEditBarController1.BarItems.Add(this.toggleShowWhitespaceItem1);
            this.richEditBarController1.BarItems.Add(this.changeParagraphLineSpacingItem1);
            this.richEditBarController1.BarItems.Add(this.setSingleParagraphSpacingItem1);
            this.richEditBarController1.BarItems.Add(this.setSesquialteralParagraphSpacingItem1);
            this.richEditBarController1.BarItems.Add(this.setDoubleParagraphSpacingItem1);
            this.richEditBarController1.BarItems.Add(this.showLineSpacingFormItem1);
            this.richEditBarController1.BarItems.Add(this.addSpacingBeforeParagraphItem1);
            this.richEditBarController1.BarItems.Add(this.removeSpacingBeforeParagraphItem1);
            this.richEditBarController1.BarItems.Add(this.addSpacingAfterParagraphItem1);
            this.richEditBarController1.BarItems.Add(this.removeSpacingAfterParagraphItem1);
            this.richEditBarController1.BarItems.Add(this.changeParagraphBackColorItem1);
            this.richEditBarController1.BarItems.Add(this.galleryChangeStyleItem1);
            this.richEditBarController1.BarItems.Add(this.findItem1);
            this.richEditBarController1.BarItems.Add(this.replaceItem1);
            this.richEditBarController1.BarItems.Add(this.insertPageBreakItem21);
            this.richEditBarController1.BarItems.Add(this.insertTableItem1);
            this.richEditBarController1.BarItems.Add(this.insertPictureItem1);
            this.richEditBarController1.BarItems.Add(this.insertFloatingPictureItem1);
            this.richEditBarController1.BarItems.Add(this.insertBookmarkItem1);
            this.richEditBarController1.BarItems.Add(this.insertHyperlinkItem1);
            this.richEditBarController1.BarItems.Add(this.editPageHeaderItem1);
            this.richEditBarController1.BarItems.Add(this.editPageFooterItem1);
            this.richEditBarController1.BarItems.Add(this.insertPageNumberItem1);
            this.richEditBarController1.BarItems.Add(this.insertPageCountItem1);
            this.richEditBarController1.BarItems.Add(this.insertTextBoxItem1);
            this.richEditBarController1.BarItems.Add(this.insertSymbolItem1);
            this.richEditBarController1.Control = this.editMail;
            
            
            
            this.pasteItem1.Id = 8;
            this.pasteItem1.Name = "pasteItem1";
            
            
            
            this.cutItem1.Id = 9;
            this.cutItem1.Name = "cutItem1";
            
            
            
            this.copyItem1.Id = 10;
            this.copyItem1.Name = "copyItem1";
            
            
            
            this.pasteSpecialItem1.Id = 11;
            this.pasteSpecialItem1.Name = "pasteSpecialItem1";
            
            
            
            this.changeFontNameItem1.Edit = this.repositoryItemFontEdit1;
            this.changeFontNameItem1.Id = 12;
            this.changeFontNameItem1.Name = "changeFontNameItem1";
            
            
            
            this.repositoryItemFontEdit1.AutoHeight = false;
            this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            
            
            
            this.changeFontSizeItem1.Edit = this.repositoryItemRichEditFontSizeEdit1;
            this.changeFontSizeItem1.Id = 13;
            this.changeFontSizeItem1.Name = "changeFontSizeItem1";
            
            
            
            this.repositoryItemRichEditFontSizeEdit1.AutoHeight = false;
            this.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemRichEditFontSizeEdit1.Control = this.editMail;
            this.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1";
            
            
            
            this.editMail.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            this.editMail.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.editMail.Location = new System.Drawing.Point(8, 102);
            this.editMail.Margin = new System.Windows.Forms.Padding(2);
            this.editMail.MenuManager = this.ribbonControl1;
            this.editMail.Name = "editMail";
            this.editMail.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.editMail.Options.HorizontalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            this.editMail.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.editMail.Options.VerticalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            this.editMail.Size = new System.Drawing.Size(559, 577);
            this.editMail.TabIndex = 4;
            this.editMail.Views.DraftView.Padding = new DevExpress.Portable.PortablePadding(4, 4, 0, 0);
            
            
            
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.pasteItem1,
            this.cutItem1,
            this.copyItem1,
            this.pasteSpecialItem1,
            this.barButtonGroup1,
            this.changeFontNameItem1,
            this.changeFontSizeItem1,
            this.fontSizeIncreaseItem1,
            this.fontSizeDecreaseItem1,
            this.barButtonGroup2,
            this.toggleFontBoldItem1,
            this.toggleFontItalicItem1,
            this.toggleFontUnderlineItem1,
            this.toggleFontDoubleUnderlineItem1,
            this.toggleFontStrikeoutItem1,
            this.toggleFontDoubleStrikeoutItem1,
            this.toggleFontSuperscriptItem1,
            this.toggleFontSubscriptItem1,
            this.barButtonGroup3,
            this.changeFontColorItem1,
            this.changeFontHighlightColorItem1,
            this.changeTextCaseItem1,
            this.makeTextUpperCaseItem1,
            this.makeTextLowerCaseItem1,
            this.capitalizeEachWordCaseItem1,
            this.toggleTextCaseItem1,
            this.clearFormattingItem1,
            this.barButtonGroup4,
            this.toggleBulletedListItem1,
            this.toggleNumberingListItem1,
            this.toggleMultiLevelListItem1,
            this.barButtonGroup5,
            this.decreaseIndentItem1,
            this.increaseIndentItem1,
            this.barButtonGroup6,
            this.toggleParagraphAlignmentLeftItem1,
            this.toggleParagraphAlignmentCenterItem1,
            this.toggleParagraphAlignmentRightItem1,
            this.toggleParagraphAlignmentJustifyItem1,
            this.toggleShowWhitespaceItem1,
            this.barButtonGroup7,
            this.changeParagraphLineSpacingItem1,
            this.setSingleParagraphSpacingItem1,
            this.setSesquialteralParagraphSpacingItem1,
            this.setDoubleParagraphSpacingItem1,
            this.showLineSpacingFormItem1,
            this.addSpacingBeforeParagraphItem1,
            this.removeSpacingBeforeParagraphItem1,
            this.addSpacingAfterParagraphItem1,
            this.removeSpacingAfterParagraphItem1,
            this.changeParagraphBackColorItem1,
            this.galleryChangeStyleItem1,
            this.findItem1,
            this.replaceItem1,
            this.insertPageBreakItem21,
            this.insertTableItem1,
            this.insertPictureItem1,
            this.insertFloatingPictureItem1,
            this.insertBookmarkItem1,
            this.insertHyperlinkItem1,
            this.editPageHeaderItem1,
            this.editPageFooterItem1,
            this.insertPageNumberItem1,
            this.insertPageCountItem1,
            this.insertTextBoxItem1,
            this.insertSymbolItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonControl1.MaxItemId = 93;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.homeRibbonPage1,
            this.insertRibbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemFontEdit1,
            this.repositoryItemRichEditFontSizeEdit1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(575, 57);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            
            
            
            this.barButtonGroup1.Id = 1;
            this.barButtonGroup1.ItemLinks.Add(this.changeFontNameItem1, "FF");
            this.barButtonGroup1.ItemLinks.Add(this.changeFontSizeItem1);
            this.barButtonGroup1.ItemLinks.Add(this.fontSizeIncreaseItem1, "FG");
            this.barButtonGroup1.ItemLinks.Add(this.fontSizeDecreaseItem1, "FK");
            this.barButtonGroup1.Name = "barButtonGroup1";
            this.barButtonGroup1.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}";
            
            
            
            this.fontSizeIncreaseItem1.Id = 14;
            this.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1";
            
            
            
            this.fontSizeDecreaseItem1.Id = 15;
            this.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1";
            
            
            
            this.barButtonGroup2.Id = 2;
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontBoldItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontItalicItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontUnderlineItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontDoubleUnderlineItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontStrikeoutItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontDoubleStrikeoutItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontSuperscriptItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontSubscriptItem1);
            this.barButtonGroup2.Name = "barButtonGroup2";
            this.barButtonGroup2.Tag = "{433DA7F0-03E2-4650-9DB5-66DD92D16E39}";
            
            
            
            this.toggleFontBoldItem1.Id = 16;
            this.toggleFontBoldItem1.Name = "toggleFontBoldItem1";
            
            
            
            this.toggleFontItalicItem1.Id = 17;
            this.toggleFontItalicItem1.Name = "toggleFontItalicItem1";
            
            
            
            this.toggleFontUnderlineItem1.Id = 18;
            this.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1";
            
            
            
            this.toggleFontDoubleUnderlineItem1.Id = 19;
            this.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1";
            
            
            
            this.toggleFontStrikeoutItem1.Id = 20;
            this.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1";
            
            
            
            this.toggleFontDoubleStrikeoutItem1.Id = 21;
            this.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1";
            
            
            
            this.toggleFontSuperscriptItem1.Id = 22;
            this.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1";
            
            
            
            this.toggleFontSubscriptItem1.Id = 23;
            this.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1";
            
            
            
            this.barButtonGroup3.Id = 3;
            this.barButtonGroup3.ItemLinks.Add(this.changeFontColorItem1, "FC");
            this.barButtonGroup3.ItemLinks.Add(this.changeFontHighlightColorItem1, "I");
            this.barButtonGroup3.Name = "barButtonGroup3";
            this.barButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}";
            
            
            
            this.changeFontColorItem1.Id = 24;
            this.changeFontColorItem1.Name = "changeFontColorItem1";
            
            
            
            this.changeFontHighlightColorItem1.Id = 25;
            this.changeFontHighlightColorItem1.Name = "changeFontHighlightColorItem1";
            
            
            
            this.changeTextCaseItem1.Id = 26;
            this.changeTextCaseItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.makeTextUpperCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.makeTextLowerCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.capitalizeEachWordCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTextCaseItem1)});
            this.changeTextCaseItem1.Name = "changeTextCaseItem1";
            
            
            
            this.makeTextUpperCaseItem1.Id = 27;
            this.makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1";
            
            
            
            this.makeTextLowerCaseItem1.Id = 28;
            this.makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1";
            
            
            
            this.capitalizeEachWordCaseItem1.Id = 29;
            this.capitalizeEachWordCaseItem1.Name = "capitalizeEachWordCaseItem1";
            
            
            
            this.toggleTextCaseItem1.Id = 30;
            this.toggleTextCaseItem1.Name = "toggleTextCaseItem1";
            
            
            
            this.clearFormattingItem1.Id = 31;
            this.clearFormattingItem1.Name = "clearFormattingItem1";
            
            
            
            this.barButtonGroup4.Id = 4;
            this.barButtonGroup4.ItemLinks.Add(this.toggleBulletedListItem1, "U");
            this.barButtonGroup4.ItemLinks.Add(this.toggleNumberingListItem1, "N");
            this.barButtonGroup4.ItemLinks.Add(this.toggleMultiLevelListItem1, "M");
            this.barButtonGroup4.Name = "barButtonGroup4";
            this.barButtonGroup4.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}";
            
            
            
            this.toggleBulletedListItem1.Id = 32;
            this.toggleBulletedListItem1.Name = "toggleBulletedListItem1";
            
            
            
            this.toggleNumberingListItem1.Id = 33;
            this.toggleNumberingListItem1.Name = "toggleNumberingListItem1";
            
            
            
            this.toggleMultiLevelListItem1.Id = 34;
            this.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1";
            
            
            
            this.barButtonGroup5.Id = 5;
            this.barButtonGroup5.ItemLinks.Add(this.decreaseIndentItem1, "AO");
            this.barButtonGroup5.ItemLinks.Add(this.increaseIndentItem1, "AI");
            this.barButtonGroup5.ItemLinks.Add(this.toggleShowWhitespaceItem1);
            this.barButtonGroup5.Name = "barButtonGroup5";
            this.barButtonGroup5.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}";
            
            
            
            this.decreaseIndentItem1.Id = 35;
            this.decreaseIndentItem1.Name = "decreaseIndentItem1";
            
            
            
            this.increaseIndentItem1.Id = 36;
            this.increaseIndentItem1.Name = "increaseIndentItem1";
            
            
            
            this.toggleShowWhitespaceItem1.Id = 41;
            this.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1";
            
            
            
            this.barButtonGroup6.Id = 6;
            this.barButtonGroup6.ItemLinks.Add(this.toggleParagraphAlignmentLeftItem1, "AL");
            this.barButtonGroup6.ItemLinks.Add(this.toggleParagraphAlignmentCenterItem1, "AC");
            this.barButtonGroup6.ItemLinks.Add(this.toggleParagraphAlignmentRightItem1, "AR");
            this.barButtonGroup6.ItemLinks.Add(this.toggleParagraphAlignmentJustifyItem1, "AJ");
            this.barButtonGroup6.Name = "barButtonGroup6";
            this.barButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}";
            
            
            
            this.toggleParagraphAlignmentLeftItem1.Id = 37;
            this.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1";
            
            
            
            this.toggleParagraphAlignmentCenterItem1.Id = 38;
            this.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1";
            
            
            
            this.toggleParagraphAlignmentRightItem1.Id = 39;
            this.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1";
            
            
            
            this.toggleParagraphAlignmentJustifyItem1.Id = 40;
            this.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1";
            
            
            
            this.barButtonGroup7.Id = 7;
            this.barButtonGroup7.ItemLinks.Add(this.changeParagraphLineSpacingItem1, "K");
            this.barButtonGroup7.ItemLinks.Add(this.changeParagraphBackColorItem1, "H");
            this.barButtonGroup7.Name = "barButtonGroup7";
            this.barButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}";
            
            
            
            this.changeParagraphLineSpacingItem1.Id = 42;
            this.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setSingleParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSesquialteralParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setDoubleParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.showLineSpacingFormItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.addSpacingBeforeParagraphItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "B", ""),
            new DevExpress.XtraBars.LinkPersistInfo(this.removeSpacingBeforeParagraphItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.addSpacingAfterParagraphItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.removeSpacingAfterParagraphItem1)});
            this.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1";
            
            
            
            this.setSingleParagraphSpacingItem1.Id = 43;
            this.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1";
            
            
            
            this.setSesquialteralParagraphSpacingItem1.Id = 44;
            this.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1";
            
            
            
            this.setDoubleParagraphSpacingItem1.Id = 45;
            this.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1";
            
            
            
            this.showLineSpacingFormItem1.Id = 46;
            this.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1";
            
            
            
            this.addSpacingBeforeParagraphItem1.Id = 47;
            this.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1";
            
            
            
            this.removeSpacingBeforeParagraphItem1.Id = 48;
            this.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1";
            
            
            
            this.addSpacingAfterParagraphItem1.Id = 49;
            this.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1";
            
            
            
            this.removeSpacingAfterParagraphItem1.Id = 50;
            this.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1";
            
            
            
            this.changeParagraphBackColorItem1.Id = 51;
            this.changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1";
            
            
            
            
            
            
            this.galleryChangeStyleItem1.Gallery.ColumnCount = 10;
            this.galleryChangeStyleItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.galleryChangeStyleItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.galleryChangeStyleItem1.Id = 52;
            this.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1";
            
            
            
            this.findItem1.Id = 53;
            this.findItem1.Name = "findItem1";
            
            
            
            this.replaceItem1.Id = 54;
            this.replaceItem1.Name = "replaceItem1";
            
            
            
            this.insertPageBreakItem21.Id = 55;
            this.insertPageBreakItem21.Name = "insertPageBreakItem21";
            
            
            
            this.insertTableItem1.Id = 56;
            this.insertTableItem1.Name = "insertTableItem1";
            
            
            
            this.insertPictureItem1.Id = 57;
            this.insertPictureItem1.Name = "insertPictureItem1";
            
            
            
            this.insertFloatingPictureItem1.Id = 58;
            this.insertFloatingPictureItem1.Name = "insertFloatingPictureItem1";
            
            
            
            this.insertBookmarkItem1.Id = 59;
            this.insertBookmarkItem1.Name = "insertBookmarkItem1";
            
            
            
            this.insertHyperlinkItem1.Id = 60;
            this.insertHyperlinkItem1.Name = "insertHyperlinkItem1";
            
            
            
            this.editPageHeaderItem1.Id = 61;
            this.editPageHeaderItem1.Name = "editPageHeaderItem1";
            
            
            
            this.editPageFooterItem1.Id = 62;
            this.editPageFooterItem1.Name = "editPageFooterItem1";
            
            
            
            this.insertPageNumberItem1.Id = 63;
            this.insertPageNumberItem1.Name = "insertPageNumberItem1";
            
            
            
            this.insertPageCountItem1.Id = 64;
            this.insertPageCountItem1.Name = "insertPageCountItem1";
            
            
            
            this.insertTextBoxItem1.Id = 65;
            this.insertTextBoxItem1.Name = "insertTextBoxItem1";
            
            
            
            this.insertSymbolItem1.Id = 66;
            this.insertSymbolItem1.Name = "insertSymbolItem1";
            
            
            
            this.homeRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.fontRibbonPageGroup1,
            this.paragraphRibbonPageGroup1});
            this.homeRibbonPage1.Name = "homeRibbonPage1";
            reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable;
            reduceOperation1.GroupName = null;
            reduceOperation1.ItemLinkIndex = 0;
            reduceOperation1.ItemLinksCount = 0;
            reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery;
            this.homeRibbonPage1.ReduceOperations.Add(reduceOperation1);
            this.homeRibbonPage1.Text = "Format";
            
            
            
            this.fontRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup1);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup2);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup3);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.changeTextCaseItem1);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.clearFormattingItem1, "E");
            this.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1";
            
            
            
            this.paragraphRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.paragraphRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup4);
            this.paragraphRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup5);
            this.paragraphRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup6);
            this.paragraphRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup7);
            this.paragraphRibbonPageGroup1.Name = "paragraphRibbonPageGroup1";
            
            
            
            this.insertRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.tablesRibbonPageGroup1,
            this.illustrationsRibbonPageGroup1,
            this.linksRibbonPageGroup1,
            this.textRibbonPageGroup1});
            this.insertRibbonPage1.Name = "insertRibbonPage1";
            
            
            
            this.tablesRibbonPageGroup1.AllowTextClipping = false;
            this.tablesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.tablesRibbonPageGroup1.ItemLinks.Add(this.insertTableItem1, "T");
            this.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1";
            
            
            
            this.illustrationsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.illustrationsRibbonPageGroup1.ItemLinks.Add(this.insertPictureItem1, "P");
            this.illustrationsRibbonPageGroup1.ItemLinks.Add(this.insertFloatingPictureItem1);
            this.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1";
            
            
            
            this.linksRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.linksRibbonPageGroup1.ItemLinks.Add(this.insertHyperlinkItem1, "I");
            this.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1";
            
            
            
            this.textRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.textRibbonPageGroup1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("textRibbonPageGroup1.ImageOptions.Image")));
            this.textRibbonPageGroup1.ItemLinks.Add(this.insertTextBoxItem1, "X");
            this.textRibbonPageGroup1.Name = "textRibbonPageGroup1";
            
            
            
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            
            
            
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.AutoScroll = false;
            this.layoutControl1.Controls.Add(this.tEditSubject);
            this.layoutControl1.Controls.Add(this.editMail);
            this.layoutControl1.Controls.Add(this.tEditTo);
            this.layoutControl1.Controls.Add(this.teFrom);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 57);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(434, 235, 1017, 597);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(575, 687);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            
            
            
            this.tEditSubject.Location = new System.Drawing.Point(8, 70);
            this.tEditSubject.Margin = new System.Windows.Forms.Padding(2);
            this.tEditSubject.Name = "tEditSubject";
            this.tEditSubject.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tEditSubject.Properties.Appearance.Options.UseFont = true;
            this.tEditSubject.Properties.AutoHeight = false;
            this.tEditSubject.Properties.NullText = " Subject:";
            this.tEditSubject.Properties.NullValuePrompt = " Subject:";
            this.tEditSubject.Size = new System.Drawing.Size(559, 24);
            this.tEditSubject.StyleController = this.layoutControl1;
            this.tEditSubject.TabIndex = 3;
            
            
            
            this.tEditTo.Location = new System.Drawing.Point(8, 40);
            this.tEditTo.Margin = new System.Windows.Forms.Padding(2);
            this.tEditTo.Name = "tEditTo";
            this.tEditTo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tEditTo.Properties.Appearance.Options.UseFont = true;
            this.tEditTo.Properties.DropDownShowMode = DevExpress.XtraEditors.TokenEditDropDownShowMode.Outlook;
            this.tEditTo.Properties.EditMode = DevExpress.XtraEditors.TokenEditMode.Manual;
            this.tEditTo.Properties.EditValueType = DevExpress.XtraEditors.TokenEditValueType.List;
            this.tEditTo.Properties.NullText = " To:";
            this.tEditTo.Properties.Separators.AddRange(new string[] {
            ","});
            this.tEditTo.Size = new System.Drawing.Size(559, 22);
            this.tEditTo.StyleController = this.layoutControl1;
            this.tEditTo.TabIndex = 2;
            this.tEditTo.ValidateToken += new DevExpress.XtraEditors.TokenEditValidateTokenEventHandler(this.tEditTo_ValidateToken);
            this.tEditTo.BeforeShowPopupPanel += new DevExpress.XtraEditors.TokenEditBeforeShowPopupPanelEventHandler(this.tEditTo_BeforeShowPopupPanel);
            this.tEditTo.CustomDrawTokenGlyph += new DevExpress.XtraEditors.TokenEditCustomDrawTokenGlyphEventHandler(this.tEditTo_CustomDrawTokenGlyph);
            
            
            
            this.teFrom.Location = new System.Drawing.Point(8, 10);
            this.teFrom.MenuManager = this.ribbonControl1;
            this.teFrom.Name = "teFrom";
            this.teFrom.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.teFrom.Properties.Appearance.Options.UseFont = true;
            this.teFrom.Properties.DropDownShowMode = DevExpress.XtraEditors.TokenEditDropDownShowMode.Outlook;
            this.teFrom.Properties.EditMode = DevExpress.XtraEditors.TokenEditMode.Manual;
            this.teFrom.Properties.EditValueType = DevExpress.XtraEditors.TokenEditValueType.List;
            this.teFrom.Properties.NullText = " From:";
            this.teFrom.Properties.Separators.AddRange(new string[] {
            ","});
            this.teFrom.Size = new System.Drawing.Size(559, 22);
            this.teFrom.StyleController = this.layoutControl1;
            this.teFrom.TabIndex = 5;
            this.teFrom.ValidateToken += new DevExpress.XtraEditors.TokenEditValidateTokenEventHandler(this.tEditTo_ValidateToken);
            this.teFrom.CustomDrawTokenGlyph += new DevExpress.XtraEditors.TokenEditCustomDrawTokenGlyphEventHandler(this.tEditTo_CustomDrawTokenGlyph);
            
            
            
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem1});
            this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup1.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 100D;
            this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1});
            rowDefinition1.Height = 5D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition2.Height = 5D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition3.Height = 5D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition4.Height = 85D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4});
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(575, 687);
            this.layoutControlGroup1.TextVisible = false;
            
            
            
            this.layoutControlItem2.Control = this.editMail;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 102);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 0, 8);
            this.layoutControlItem2.Size = new System.Drawing.Size(575, 585);
            this.layoutControlItem2.TextVisible = false;
            
            
            
            this.layoutControlItem3.Control = this.tEditSubject;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(66, 30);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 2, 8);
            this.layoutControlItem3.Size = new System.Drawing.Size(575, 34);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextVisible = false;
            
            
            
            this.layoutControlItem4.Control = this.tEditTo;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(24, 32);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 6, 4);
            this.layoutControlItem4.Size = new System.Drawing.Size(575, 34);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextVisible = false;
            
            
            
            this.layoutControlItem1.Control = this.teFrom;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(24, 32);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 10, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(575, 34);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextVisible = false;
            
            
            
            this.flyoutPanel1.Controls.Add(this.lblDescription);
            this.flyoutPanel1.Controls.Add(this.lblEmail);
            this.flyoutPanel1.Controls.Add(this.pictureEdit1);
            this.flyoutPanel1.Location = new System.Drawing.Point(324, 42);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Bottom;
            this.flyoutPanel1.OptionsButtonPanel.ShowButtonPanel = true;
            this.flyoutPanel1.OwnerControl = this.tEditTo;
            this.flyoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.flyoutPanel1.Size = new System.Drawing.Size(215, 97);
            this.flyoutPanel1.TabIndex = 9;
            
            
            
            this.lblDescription.Location = new System.Drawing.Point(60, 31);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(64, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "(description)";
            
            
            
            this.lblEmail.Location = new System.Drawing.Point(60, 4);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(33, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "(Email)";
            
            
            
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(2, 4);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureEdit1.MenuManager = this.ribbonControl1;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Circle;
            this.pictureEdit1.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(53, 53);
            this.pictureEdit1.TabIndex = 1;
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flyoutPanel1);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MailModule";
            this.Size = new System.Drawing.Size(575, 744);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tEditSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEditTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            this.flyoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private RichEditControl editMail;
        private LayoutControl layoutControl1;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit tEditSubject;
        private LayoutControlItem layoutControlItem3;
        private LayoutControlItem layoutControlItem4;
        private PasteItem pasteItem1;
        private CutItem cutItem1;
        private CopyItem copyItem1;
        private PasteSpecialItem pasteSpecialItem1;
        private ChangeFontNameItem changeFontNameItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private ChangeFontSizeItem changeFontSizeItem1;
        private DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit repositoryItemRichEditFontSizeEdit1;
        private RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private FontSizeIncreaseItem fontSizeIncreaseItem1;
        private FontSizeDecreaseItem fontSizeDecreaseItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup2;
        private ToggleFontBoldItem toggleFontBoldItem1;
        private ToggleFontItalicItem toggleFontItalicItem1;
        private ToggleFontUnderlineItem toggleFontUnderlineItem1;
        private ToggleFontDoubleUnderlineItem toggleFontDoubleUnderlineItem1;
        private ToggleFontStrikeoutItem toggleFontStrikeoutItem1;
        private ToggleFontDoubleStrikeoutItem toggleFontDoubleStrikeoutItem1;
        private ToggleFontSuperscriptItem toggleFontSuperscriptItem1;
        private ToggleFontSubscriptItem toggleFontSubscriptItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup3;
        private ChangeFontColorItem changeFontColorItem1;
        private ChangeFontHighlightColorItem changeFontHighlightColorItem1;
        private ChangeTextCaseItem changeTextCaseItem1;
        private MakeTextUpperCaseItem makeTextUpperCaseItem1;
        private MakeTextLowerCaseItem makeTextLowerCaseItem1;
        private CapitalizeEachWordCaseItem capitalizeEachWordCaseItem1;
        private ToggleTextCaseItem toggleTextCaseItem1;
        private ClearFormattingItem clearFormattingItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup4;
        private ToggleBulletedListItem toggleBulletedListItem1;
        private ToggleNumberingListItem toggleNumberingListItem1;
        private ToggleMultiLevelListItem toggleMultiLevelListItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup5;
        private DecreaseIndentItem decreaseIndentItem1;
        private IncreaseIndentItem increaseIndentItem1;
        private ToggleShowWhitespaceItem toggleShowWhitespaceItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup6;
        private ToggleParagraphAlignmentLeftItem toggleParagraphAlignmentLeftItem1;
        private ToggleParagraphAlignmentCenterItem toggleParagraphAlignmentCenterItem1;
        private ToggleParagraphAlignmentRightItem toggleParagraphAlignmentRightItem1;
        private ToggleParagraphAlignmentJustifyItem toggleParagraphAlignmentJustifyItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup7;
        private ChangeParagraphLineSpacingItem changeParagraphLineSpacingItem1;
        private SetSingleParagraphSpacingItem setSingleParagraphSpacingItem1;
        private SetSesquialteralParagraphSpacingItem setSesquialteralParagraphSpacingItem1;
        private SetDoubleParagraphSpacingItem setDoubleParagraphSpacingItem1;
        private ShowLineSpacingFormItem showLineSpacingFormItem1;
        private AddSpacingBeforeParagraphItem addSpacingBeforeParagraphItem1;
        private RemoveSpacingBeforeParagraphItem removeSpacingBeforeParagraphItem1;
        private AddSpacingAfterParagraphItem addSpacingAfterParagraphItem1;
        private RemoveSpacingAfterParagraphItem removeSpacingAfterParagraphItem1;
        private ChangeParagraphBackColorItem changeParagraphBackColorItem1;
        private GalleryChangeStyleItem galleryChangeStyleItem1;
        private FindItem findItem1;
        private ReplaceItem replaceItem1;
        private HomeRibbonPage homeRibbonPage1;
        private FontRibbonPageGroup fontRibbonPageGroup1;
        private ParagraphRibbonPageGroup paragraphRibbonPageGroup1;
        private InsertPageBreakItem2 insertPageBreakItem21;
        private InsertTableItem insertTableItem1;
        private InsertPictureItem insertPictureItem1;
        private InsertFloatingPictureItem insertFloatingPictureItem1;
        private InsertBookmarkItem insertBookmarkItem1;
        private InsertHyperlinkItem insertHyperlinkItem1;
        private EditPageHeaderItem editPageHeaderItem1;
        private EditPageFooterItem editPageFooterItem1;
        private InsertPageNumberItem insertPageNumberItem1;
        private InsertPageCountItem insertPageCountItem1;
        private InsertTextBoxItem insertTextBoxItem1;
        private InsertSymbolItem insertSymbolItem1;
        private InsertRibbonPage insertRibbonPage1;
        private TablesRibbonPageGroup tablesRibbonPageGroup1;
        private IllustrationsRibbonPageGroup illustrationsRibbonPageGroup1;
        private LinksRibbonPageGroup linksRibbonPageGroup1;
        private TextRibbonPageGroup textRibbonPageGroup1;
        private DevExpress.XtraEditors.TokenEdit tEditTo;
        private LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TokenEdit teFrom;
        private XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private XtraEditors.LabelControl lblDescription;
        private XtraEditors.LabelControl lblEmail;
    }
}
