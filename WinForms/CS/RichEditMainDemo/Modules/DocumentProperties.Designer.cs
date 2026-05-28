namespace DevExpress.XtraRichEdit.Demos {
    partial class DocumentPropertiesModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.richEditControl = new DevExpress.XtraRichEdit.RichEditControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.undoItem1 = new DevExpress.XtraRichEdit.UI.UndoItem();
            this.redoItem1 = new DevExpress.XtraRichEdit.UI.RedoItem();
            this.fileNewItem1 = new DevExpress.XtraRichEdit.UI.FileNewItem();
            this.fileOpenItem1 = new DevExpress.XtraRichEdit.UI.FileOpenItem();
            this.fileSaveItem1 = new DevExpress.XtraRichEdit.UI.FileSaveItem();
            this.fileSaveAsItem1 = new DevExpress.XtraRichEdit.UI.FileSaveAsItem();
            this.quickPrintItem1 = new DevExpress.XtraRichEdit.UI.QuickPrintItem();
            this.printItem1 = new DevExpress.XtraRichEdit.UI.PrintItem();
            this.printPreviewItem1 = new DevExpress.XtraRichEdit.UI.PrintPreviewItem();
            this.showDocumentPropertiesFormItem1 = new DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem();
            this.insertMergeFieldItem1 = new DevExpress.XtraRichEdit.UI.InsertMergeFieldItem();
            this.showAllFieldCodesItem1 = new DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem();
            this.showAllFieldResultsItem1 = new DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem();
            this.toggleViewMergedDataItem1 = new DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.insertCategoryItem = new DevExpress.XtraBars.BarButtonItem();
            this.insertCreatedItem = new DevExpress.XtraBars.BarButtonItem();
            this.insertCreatorItem = new DevExpress.XtraBars.BarButtonItem();
            this.insertDescriptionItem = new DevExpress.XtraBars.BarButtonItem();
            this.insertKeywordsItem = new DevExpress.XtraBars.BarButtonItem();
            this.insertLastModifiedByItem = new DevExpress.XtraBars.BarButtonItem();
            this.insertLastPrintedItem = new DevExpress.XtraBars.BarButtonItem();
            this.insertModifiedItem = new DevExpress.XtraBars.BarButtonItem();
            this.insertRevisionItem = new DevExpress.XtraBars.BarButtonItem();
            this.insertSubjectItem = new DevExpress.XtraBars.BarButtonItem();
            this.insertTitleItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            this.fileRibbonPage1 = new DevExpress.XtraRichEdit.UI.FileRibbonPage();
            this.commonRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup();
            this.infoRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup();
            this.mailingsRibbonPage1 = new DevExpress.XtraRichEdit.UI.MailingsRibbonPage();
            this.mailMergeRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // richEditControl
            // 
            this.richEditControl.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.richEditControl.Location = new System.Drawing.Point(0, 150);
            this.richEditControl.MenuManager = this.ribbonControl1;
            this.richEditControl.Name = "richEditControl";
            this.richEditControl.Options.Behavior.Printing = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
            this.richEditControl.Size = new System.Drawing.Size(1300, 458);
            this.richEditControl.TabIndex = 13;
            this.richEditControl.Text = "richEditControl1";
            this.richEditControl.CalculateDocumentVariable += new DevExpress.XtraRichEdit.CalculateDocumentVariableEventHandler(this.OnCalculateDocumentVariable);
            this.richEditControl.DocumentPropertiesChanged += new System.EventHandler(this.RichEditControl_DocumentPropertiesChanged);
            this.richEditControl.CustomPropertiesChanged += new System.EventHandler(this.RichEditControl_CustomPropertiesChanged);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.undoItem1,
            this.redoItem1,
            this.fileNewItem1,
            this.fileOpenItem1,
            this.fileSaveItem1,
            this.fileSaveAsItem1,
            this.quickPrintItem1,
            this.printItem1,
            this.printPreviewItem1,
            this.showDocumentPropertiesFormItem1,
            this.insertMergeFieldItem1,
            this.showAllFieldCodesItem1,
            this.showAllFieldResultsItem1,
            this.toggleViewMergedDataItem1,
            this.barSubItem1,
            this.insertCategoryItem,
            this.insertCreatedItem,
            this.insertCreatorItem,
            this.insertDescriptionItem,
            this.insertLastPrintedItem,
            this.insertKeywordsItem,
            this.insertRevisionItem,
            this.insertLastModifiedByItem,
            this.insertModifiedItem,
            this.insertSubjectItem,
            this.insertTitleItem,
            this.barButtonItem16,
            this.ribbonControl1.SearchEditItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 38;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.fileRibbonPage1,
            this.mailingsRibbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.ribbonControl1.Size = new System.Drawing.Size(1300, 150);
            // 
            // undoItem1
            // 
            this.undoItem1.Id = 1;
            this.undoItem1.Name = "undoItem1";
            // 
            // redoItem1
            // 
            this.redoItem1.Id = 2;
            this.redoItem1.Name = "redoItem1";
            // 
            // fileNewItem1
            // 
            this.fileNewItem1.Id = 3;
            this.fileNewItem1.Name = "fileNewItem1";
            // 
            // fileOpenItem1
            // 
            this.fileOpenItem1.Id = 4;
            this.fileOpenItem1.Name = "fileOpenItem1";
            // 
            // fileSaveItem1
            // 
            this.fileSaveItem1.Id = 5;
            this.fileSaveItem1.Name = "fileSaveItem1";
            // 
            // fileSaveAsItem1
            // 
            this.fileSaveAsItem1.Id = 6;
            this.fileSaveAsItem1.Name = "fileSaveAsItem1";
            // 
            // quickPrintItem1
            // 
            this.quickPrintItem1.Id = 7;
            this.quickPrintItem1.Name = "quickPrintItem1";
            // 
            // printItem1
            // 
            this.printItem1.Id = 8;
            this.printItem1.Name = "printItem1";
            // 
            // printPreviewItem1
            // 
            this.printPreviewItem1.Id = 9;
            this.printPreviewItem1.Name = "printPreviewItem1";
            // 
            // showDocumentPropertiesFormItem1
            // 
            this.showDocumentPropertiesFormItem1.Id = 10;
            this.showDocumentPropertiesFormItem1.Name = "showDocumentPropertiesFormItem1";
            // 
            // insertMergeFieldItem1
            // 
            this.insertMergeFieldItem1.Id = 11;
            this.insertMergeFieldItem1.Name = "insertMergeFieldItem1";
            // 
            // showAllFieldCodesItem1
            // 
            this.showAllFieldCodesItem1.Id = 12;
            this.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1";
            // 
            // showAllFieldResultsItem1
            // 
            this.showAllFieldResultsItem1.Id = 13;
            this.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1";
            // 
            // toggleViewMergedDataItem1
            // 
            this.toggleViewMergedDataItem1.Id = 14;
            this.toggleViewMergedDataItem1.Name = "toggleViewMergedDataItem1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Insert Document Property";
            this.barSubItem1.Id = 16;
            this.barSubItem1.ImageOptions.SvgImage = global::DevExpress.XtraRichEdit.Demos.Properties.Resources.InsertDocumentProperty;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.insertCategoryItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertCreatedItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertCreatorItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertDescriptionItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertKeywordsItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertLastModifiedByItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertLastPrintedItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertModifiedItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertRevisionItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertSubjectItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertTitleItem)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // insertCategoryItem
            // 
            this.insertCategoryItem.Caption = "Category";
            this.insertCategoryItem.Id = 17;
            this.insertCategoryItem.Name = "insertCategoryItem";
            this.insertCategoryItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnCategoryItemClick);
            // 
            // insertCreatedItem
            // 
            this.insertCreatedItem.Caption = "Created";
            this.insertCreatedItem.Id = 20;
            this.insertCreatedItem.Name = "insertCreatedItem";
            this.insertCreatedItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnCreatedItemClick);
            // 
            // insertCreatorItem
            // 
            this.insertCreatorItem.Caption = "Creator";
            this.insertCreatorItem.Id = 21;
            this.insertCreatorItem.Name = "insertCreatorItem";
            this.insertCreatorItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnCreatorItemClick);
            // 
            // insertDescriptionItem
            // 
            this.insertDescriptionItem.Caption = "Description";
            this.insertDescriptionItem.Id = 22;
            this.insertDescriptionItem.Name = "insertDescriptionItem";
            this.insertDescriptionItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnDescriptionItemClick);
            // 
            // insertKeywordsItem
            // 
            this.insertKeywordsItem.Caption = "Keywords";
            this.insertKeywordsItem.Id = 24;
            this.insertKeywordsItem.Name = "insertKeywordsItem";
            this.insertKeywordsItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnKeywordsItemClick);
            // 
            // insertLastModifiedByItem
            // 
            this.insertLastModifiedByItem.Caption = "LastModifiedBy";
            this.insertLastModifiedByItem.Id = 26;
            this.insertLastModifiedByItem.Name = "insertLastModifiedByItem";
            this.insertLastModifiedByItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnLastModifiedByItemClick);
            // 
            // insertLastPrintedItem
            // 
            this.insertLastPrintedItem.Caption = "LastPrinted";
            this.insertLastPrintedItem.Id = 27;
            this.insertLastPrintedItem.Name = "insertLastPrintedItem";
            this.insertLastPrintedItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnLastPrintedItemClick);
            // 
            // insertModifiedItem
            // 
            this.insertModifiedItem.Caption = "Modified";
            this.insertModifiedItem.Id = 28;
            this.insertModifiedItem.Name = "insertModifiedItem";
            this.insertModifiedItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnModifiedItemClick);
            // 
            // insertRevisionItem
            // 
            this.insertRevisionItem.Caption = "Revision";
            this.insertRevisionItem.Id = 29;
            this.insertRevisionItem.Name = "insertRevisionItem";
            this.insertRevisionItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRevisionItemClick);
            // 
            // insertSubjectItem
            // 
            this.insertSubjectItem.Caption = "Subject";
            this.insertSubjectItem.Id = 30;
            this.insertSubjectItem.Name = "insertSubjectItem";
            this.insertSubjectItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnSubjectItemClick);
            // 
            // insertTitleItem
            // 
            this.insertTitleItem.Caption = "Title";
            this.insertTitleItem.Id = 31;
            this.insertTitleItem.Name = "insertTitleItem";
            this.insertTitleItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnTitleItemClick);
            // 
            // barButtonItem16
            // 
            this.barButtonItem16.Id = 37;
            this.barButtonItem16.Name = "barButtonItem16";
            // 
            // fileRibbonPage1
            // 
            this.fileRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.commonRibbonPageGroup1,
            this.infoRibbonPageGroup1});
            this.fileRibbonPage1.Name = "fileRibbonPage1";
            // 
            // commonRibbonPageGroup1
            // 
            this.commonRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.commonRibbonPageGroup1.ItemLinks.Add(this.undoItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.redoItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.fileNewItem1, "N");
            this.commonRibbonPageGroup1.ItemLinks.Add(this.fileOpenItem1, "O");
            this.commonRibbonPageGroup1.ItemLinks.Add(this.fileSaveItem1, "S");
            this.commonRibbonPageGroup1.ItemLinks.Add(this.fileSaveAsItem1, "A");
            this.commonRibbonPageGroup1.ItemLinks.Add(this.quickPrintItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.printItem1, "P");
            this.commonRibbonPageGroup1.ItemLinks.Add(this.printPreviewItem1);
            this.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1";
            // 
            // infoRibbonPageGroup1
            // 
            this.infoRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.infoRibbonPageGroup1.ItemLinks.Add(this.showDocumentPropertiesFormItem1);
            this.infoRibbonPageGroup1.ItemLinks.Add(this.barSubItem1);
            this.infoRibbonPageGroup1.Name = "infoRibbonPageGroup1";
            // 
            // mailingsRibbonPage1
            // 
            this.mailingsRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mailMergeRibbonPageGroup1});
            this.mailingsRibbonPage1.Name = "mailingsRibbonPage1";
            // 
            // mailMergeRibbonPageGroup1
            // 
            this.mailMergeRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.insertMergeFieldItem1);
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.showAllFieldCodesItem1);
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.showAllFieldResultsItem1);
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.toggleViewMergedDataItem1, "P");
            this.mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // richEditBarController1
            // 
            this.richEditBarController1.BarItems.Add(this.undoItem1);
            this.richEditBarController1.BarItems.Add(this.redoItem1);
            this.richEditBarController1.BarItems.Add(this.fileNewItem1);
            this.richEditBarController1.BarItems.Add(this.fileOpenItem1);
            this.richEditBarController1.BarItems.Add(this.fileSaveItem1);
            this.richEditBarController1.BarItems.Add(this.fileSaveAsItem1);
            this.richEditBarController1.BarItems.Add(this.quickPrintItem1);
            this.richEditBarController1.BarItems.Add(this.printItem1);
            this.richEditBarController1.BarItems.Add(this.printPreviewItem1);
            this.richEditBarController1.BarItems.Add(this.showDocumentPropertiesFormItem1);
            this.richEditBarController1.BarItems.Add(this.insertMergeFieldItem1);
            this.richEditBarController1.BarItems.Add(this.showAllFieldCodesItem1);
            this.richEditBarController1.BarItems.Add(this.showAllFieldResultsItem1);
            this.richEditBarController1.BarItems.Add(this.toggleViewMergedDataItem1);
            this.richEditBarController1.Control = this.richEditControl;
            // 
            // DocumentPropertiesModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richEditControl);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "DocumentPropertiesModule";
            this.Size = new System.Drawing.Size(1300, 608);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichEditControl richEditControl;
        private UI.RichEditBarController richEditBarController1;
        private XtraBars.Ribbon.RibbonControl ribbonControl1;
        private UI.UndoItem undoItem1;
        private UI.RedoItem redoItem1;
        private UI.FileNewItem fileNewItem1;
        private UI.FileOpenItem fileOpenItem1;
        private UI.FileSaveItem fileSaveItem1;
        private UI.FileSaveAsItem fileSaveAsItem1;
        private UI.QuickPrintItem quickPrintItem1;
        private UI.PrintItem printItem1;
        private UI.PrintPreviewItem printPreviewItem1;
        private UI.ShowDocumentPropertiesFormItem showDocumentPropertiesFormItem1;
        private UI.FileRibbonPage fileRibbonPage1;
        private UI.CommonRibbonPageGroup commonRibbonPageGroup1;
        private UI.InfoRibbonPageGroup infoRibbonPageGroup1;
        private UI.InsertMergeFieldItem insertMergeFieldItem1;
        private UI.ShowAllFieldCodesItem showAllFieldCodesItem1;
        private UI.ShowAllFieldResultsItem showAllFieldResultsItem1;
        private UI.ToggleViewMergedDataItem toggleViewMergedDataItem1;
        private UI.MailingsRibbonPage mailingsRibbonPage1;
        private UI.MailMergeRibbonPageGroup mailMergeRibbonPageGroup1;
        private XtraBars.BarSubItem barSubItem1;
        private XtraBars.BarButtonItem insertCategoryItem;
        private XtraBars.BarButtonItem insertCreatedItem;
        private XtraBars.BarButtonItem insertCreatorItem;
        private XtraBars.BarButtonItem insertDescriptionItem;
        private XtraBars.BarButtonItem insertKeywordsItem;
        private XtraBars.BarButtonItem insertLastModifiedByItem;
        private XtraBars.BarButtonItem insertLastPrintedItem;
        private XtraBars.BarButtonItem insertModifiedItem;
        private XtraBars.BarButtonItem insertRevisionItem;
        private XtraBars.BarButtonItem insertSubjectItem;
        private XtraBars.BarButtonItem insertTitleItem;
        private XtraBars.BarButtonItem barButtonItem16;
        private XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
    }
}
