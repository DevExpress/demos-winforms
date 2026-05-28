Namespace DevExpress.XtraRichEdit.Demos

    Partial Class DocumentPropertiesModule

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
            Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
            Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
            Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
            Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
            Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
            Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
            Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
            Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
            Me.showDocumentPropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem()
            Me.insertMergeFieldItem1 = New DevExpress.XtraRichEdit.UI.InsertMergeFieldItem()
            Me.showAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
            Me.showAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
            Me.toggleViewMergedDataItem1 = New DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem()
            Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
            Me.insertCategoryItem = New DevExpress.XtraBars.BarButtonItem()
            Me.insertCreatedItem = New DevExpress.XtraBars.BarButtonItem()
            Me.insertCreatorItem = New DevExpress.XtraBars.BarButtonItem()
            Me.insertDescriptionItem = New DevExpress.XtraBars.BarButtonItem()
            Me.insertKeywordsItem = New DevExpress.XtraBars.BarButtonItem()
            Me.insertLastModifiedByItem = New DevExpress.XtraBars.BarButtonItem()
            Me.insertLastPrintedItem = New DevExpress.XtraBars.BarButtonItem()
            Me.insertModifiedItem = New DevExpress.XtraBars.BarButtonItem()
            Me.insertRevisionItem = New DevExpress.XtraBars.BarButtonItem()
            Me.insertSubjectItem = New DevExpress.XtraBars.BarButtonItem()
            Me.insertTitleItem = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
            Me.fileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
            Me.commonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
            Me.infoRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup()
            Me.mailingsRibbonPage1 = New DevExpress.XtraRichEdit.UI.MailingsRibbonPage()
            Me.mailMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup()
            Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController(Me.components)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' richEditControl
            ' 
            Me.richEditControl.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple
            Me.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel
            Me.richEditControl.Location = New System.Drawing.Point(0, 150)
            Me.richEditControl.MenuManager = Me.ribbonControl1
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Options.Behavior.Printing = DevExpress.XtraRichEdit.DocumentCapability.Hidden
            Me.richEditControl.Size = New System.Drawing.Size(1300, 458)
            Me.richEditControl.TabIndex = 13
            Me.richEditControl.Text = "richEditControl1"
            AddHandler Me.richEditControl.CalculateDocumentVariable, New DevExpress.XtraRichEdit.CalculateDocumentVariableEventHandler(AddressOf Me.OnCalculateDocumentVariable)
            AddHandler Me.richEditControl.DocumentPropertiesChanged, New System.EventHandler(AddressOf Me.RichEditControl_DocumentPropertiesChanged)
            AddHandler Me.richEditControl.CustomPropertiesChanged, New System.EventHandler(AddressOf Me.RichEditControl_CustomPropertiesChanged)
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.undoItem1, Me.redoItem1, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.showDocumentPropertiesFormItem1, Me.insertMergeFieldItem1, Me.showAllFieldCodesItem1, Me.showAllFieldResultsItem1, Me.toggleViewMergedDataItem1, Me.barSubItem1, Me.insertCategoryItem, Me.insertCreatedItem, Me.insertCreatorItem, Me.insertDescriptionItem, Me.insertLastPrintedItem, Me.insertKeywordsItem, Me.insertRevisionItem, Me.insertLastModifiedByItem, Me.insertModifiedItem, Me.insertSubjectItem, Me.insertTitleItem, Me.barButtonItem16, Me.ribbonControl1.SearchEditItem})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 38
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.fileRibbonPage1, Me.mailingsRibbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemComboBox1})
            Me.ribbonControl1.Size = New System.Drawing.Size(1300, 150)
            ' 
            ' undoItem1
            ' 
            Me.undoItem1.Id = 1
            Me.undoItem1.Name = "undoItem1"
            ' 
            ' redoItem1
            ' 
            Me.redoItem1.Id = 2
            Me.redoItem1.Name = "redoItem1"
            ' 
            ' fileNewItem1
            ' 
            Me.fileNewItem1.Id = 3
            Me.fileNewItem1.Name = "fileNewItem1"
            ' 
            ' fileOpenItem1
            ' 
            Me.fileOpenItem1.Id = 4
            Me.fileOpenItem1.Name = "fileOpenItem1"
            ' 
            ' fileSaveItem1
            ' 
            Me.fileSaveItem1.Id = 5
            Me.fileSaveItem1.Name = "fileSaveItem1"
            ' 
            ' fileSaveAsItem1
            ' 
            Me.fileSaveAsItem1.Id = 6
            Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
            ' 
            ' quickPrintItem1
            ' 
            Me.quickPrintItem1.Id = 7
            Me.quickPrintItem1.Name = "quickPrintItem1"
            ' 
            ' printItem1
            ' 
            Me.printItem1.Id = 8
            Me.printItem1.Name = "printItem1"
            ' 
            ' printPreviewItem1
            ' 
            Me.printPreviewItem1.Id = 9
            Me.printPreviewItem1.Name = "printPreviewItem1"
            ' 
            ' showDocumentPropertiesFormItem1
            ' 
            Me.showDocumentPropertiesFormItem1.Id = 10
            Me.showDocumentPropertiesFormItem1.Name = "showDocumentPropertiesFormItem1"
            ' 
            ' insertMergeFieldItem1
            ' 
            Me.insertMergeFieldItem1.Id = 11
            Me.insertMergeFieldItem1.Name = "insertMergeFieldItem1"
            ' 
            ' showAllFieldCodesItem1
            ' 
            Me.showAllFieldCodesItem1.Id = 12
            Me.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1"
            ' 
            ' showAllFieldResultsItem1
            ' 
            Me.showAllFieldResultsItem1.Id = 13
            Me.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1"
            ' 
            ' toggleViewMergedDataItem1
            ' 
            Me.toggleViewMergedDataItem1.Id = 14
            Me.toggleViewMergedDataItem1.Name = "toggleViewMergedDataItem1"
            ' 
            ' barSubItem1
            ' 
            Me.barSubItem1.Caption = "Insert Document Property"
            Me.barSubItem1.Id = 16
            Me.barSubItem1.ImageOptions.SvgImage = Global.DevExpress.XtraRichEdit.Demos.Properties.Resources.InsertDocumentProperty
            Me.barSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.insertCategoryItem), New DevExpress.XtraBars.LinkPersistInfo(Me.insertCreatedItem), New DevExpress.XtraBars.LinkPersistInfo(Me.insertCreatorItem), New DevExpress.XtraBars.LinkPersistInfo(Me.insertDescriptionItem), New DevExpress.XtraBars.LinkPersistInfo(Me.insertKeywordsItem), New DevExpress.XtraBars.LinkPersistInfo(Me.insertLastModifiedByItem), New DevExpress.XtraBars.LinkPersistInfo(Me.insertLastPrintedItem), New DevExpress.XtraBars.LinkPersistInfo(Me.insertModifiedItem), New DevExpress.XtraBars.LinkPersistInfo(Me.insertRevisionItem), New DevExpress.XtraBars.LinkPersistInfo(Me.insertSubjectItem), New DevExpress.XtraBars.LinkPersistInfo(Me.insertTitleItem)})
            Me.barSubItem1.Name = "barSubItem1"
            ' 
            ' insertCategoryItem
            ' 
            Me.insertCategoryItem.Caption = "Category"
            Me.insertCategoryItem.Id = 17
            Me.insertCategoryItem.Name = "insertCategoryItem"
            AddHandler Me.insertCategoryItem.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnCategoryItemClick)
            ' 
            ' insertCreatedItem
            ' 
            Me.insertCreatedItem.Caption = "Created"
            Me.insertCreatedItem.Id = 20
            Me.insertCreatedItem.Name = "insertCreatedItem"
            AddHandler Me.insertCreatedItem.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnCreatedItemClick)
            ' 
            ' insertCreatorItem
            ' 
            Me.insertCreatorItem.Caption = "Creator"
            Me.insertCreatorItem.Id = 21
            Me.insertCreatorItem.Name = "insertCreatorItem"
            AddHandler Me.insertCreatorItem.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnCreatorItemClick)
            ' 
            ' insertDescriptionItem
            ' 
            Me.insertDescriptionItem.Caption = "Description"
            Me.insertDescriptionItem.Id = 22
            Me.insertDescriptionItem.Name = "insertDescriptionItem"
            AddHandler Me.insertDescriptionItem.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnDescriptionItemClick)
            ' 
            ' insertKeywordsItem
            ' 
            Me.insertKeywordsItem.Caption = "Keywords"
            Me.insertKeywordsItem.Id = 24
            Me.insertKeywordsItem.Name = "insertKeywordsItem"
            AddHandler Me.insertKeywordsItem.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnKeywordsItemClick)
            ' 
            ' insertLastModifiedByItem
            ' 
            Me.insertLastModifiedByItem.Caption = "LastModifiedBy"
            Me.insertLastModifiedByItem.Id = 26
            Me.insertLastModifiedByItem.Name = "insertLastModifiedByItem"
            AddHandler Me.insertLastModifiedByItem.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnLastModifiedByItemClick)
            ' 
            ' insertLastPrintedItem
            ' 
            Me.insertLastPrintedItem.Caption = "LastPrinted"
            Me.insertLastPrintedItem.Id = 27
            Me.insertLastPrintedItem.Name = "insertLastPrintedItem"
            AddHandler Me.insertLastPrintedItem.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnLastPrintedItemClick)
            ' 
            ' insertModifiedItem
            ' 
            Me.insertModifiedItem.Caption = "Modified"
            Me.insertModifiedItem.Id = 28
            Me.insertModifiedItem.Name = "insertModifiedItem"
            AddHandler Me.insertModifiedItem.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnModifiedItemClick)
            ' 
            ' insertRevisionItem
            ' 
            Me.insertRevisionItem.Caption = "Revision"
            Me.insertRevisionItem.Id = 29
            Me.insertRevisionItem.Name = "insertRevisionItem"
            AddHandler Me.insertRevisionItem.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnRevisionItemClick)
            ' 
            ' insertSubjectItem
            ' 
            Me.insertSubjectItem.Caption = "Subject"
            Me.insertSubjectItem.Id = 30
            Me.insertSubjectItem.Name = "insertSubjectItem"
            AddHandler Me.insertSubjectItem.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnSubjectItemClick)
            ' 
            ' insertTitleItem
            ' 
            Me.insertTitleItem.Caption = "Title"
            Me.insertTitleItem.Id = 31
            Me.insertTitleItem.Name = "insertTitleItem"
            AddHandler Me.insertTitleItem.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnTitleItemClick)
            ' 
            ' barButtonItem16
            ' 
            Me.barButtonItem16.Id = 37
            Me.barButtonItem16.Name = "barButtonItem16"
            ' 
            ' fileRibbonPage1
            ' 
            Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.commonRibbonPageGroup1, Me.infoRibbonPageGroup1})
            Me.fileRibbonPage1.Name = "fileRibbonPage1"
            ' 
            ' commonRibbonPageGroup1
            ' 
            Me.commonRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.undoItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.redoItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileNewItem1, "N")
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileOpenItem1, "O")
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveItem1, "S")
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveAsItem1, "A")
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.quickPrintItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printItem1, "P")
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
            Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
            ' 
            ' infoRibbonPageGroup1
            ' 
            Me.infoRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.infoRibbonPageGroup1.ItemLinks.Add(Me.showDocumentPropertiesFormItem1)
            Me.infoRibbonPageGroup1.ItemLinks.Add(Me.barSubItem1)
            Me.infoRibbonPageGroup1.Name = "infoRibbonPageGroup1"
            ' 
            ' mailingsRibbonPage1
            ' 
            Me.mailingsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.mailMergeRibbonPageGroup1})
            Me.mailingsRibbonPage1.Name = "mailingsRibbonPage1"
            ' 
            ' mailMergeRibbonPageGroup1
            ' 
            Me.mailMergeRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.insertMergeFieldItem1)
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldCodesItem1)
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldResultsItem1)
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.toggleViewMergedDataItem1, "P")
            Me.mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1"
            ' 
            ' repositoryItemComboBox1
            ' 
            Me.repositoryItemComboBox1.AutoHeight = False
            Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            ' 
            ' richEditBarController1
            ' 
            Me.richEditBarController1.BarItems.Add(Me.undoItem1)
            Me.richEditBarController1.BarItems.Add(Me.redoItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileNewItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileOpenItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileSaveItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileSaveAsItem1)
            Me.richEditBarController1.BarItems.Add(Me.quickPrintItem1)
            Me.richEditBarController1.BarItems.Add(Me.printItem1)
            Me.richEditBarController1.BarItems.Add(Me.printPreviewItem1)
            Me.richEditBarController1.BarItems.Add(Me.showDocumentPropertiesFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertMergeFieldItem1)
            Me.richEditBarController1.BarItems.Add(Me.showAllFieldCodesItem1)
            Me.richEditBarController1.BarItems.Add(Me.showAllFieldResultsItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleViewMergedDataItem1)
            Me.richEditBarController1.Control = Me.richEditControl
            ' 
            ' DocumentPropertiesModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.richEditControl)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "DocumentPropertiesModule"
            Me.Size = New System.Drawing.Size(1300, 608)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private richEditControl As DevExpress.XtraRichEdit.RichEditControl

        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl

        Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem

        Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem

        Private fileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem

        Private fileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem

        Private fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem

        Private fileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem

        Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem

        Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem

        Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem

        Private showDocumentPropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem

        Private fileRibbonPage1 As DevExpress.XtraRichEdit.UI.FileRibbonPage

        Private commonRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup

        Private infoRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup

        Private insertMergeFieldItem1 As DevExpress.XtraRichEdit.UI.InsertMergeFieldItem

        Private showAllFieldCodesItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem

        Private showAllFieldResultsItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem

        Private toggleViewMergedDataItem1 As DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem

        Private mailingsRibbonPage1 As DevExpress.XtraRichEdit.UI.MailingsRibbonPage

        Private mailMergeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup

        Private barSubItem1 As DevExpress.XtraBars.BarSubItem

        Private insertCategoryItem As DevExpress.XtraBars.BarButtonItem

        Private insertCreatedItem As DevExpress.XtraBars.BarButtonItem

        Private insertCreatorItem As DevExpress.XtraBars.BarButtonItem

        Private insertDescriptionItem As DevExpress.XtraBars.BarButtonItem

        Private insertKeywordsItem As DevExpress.XtraBars.BarButtonItem

        Private insertLastModifiedByItem As DevExpress.XtraBars.BarButtonItem

        Private insertLastPrintedItem As DevExpress.XtraBars.BarButtonItem

        Private insertModifiedItem As DevExpress.XtraBars.BarButtonItem

        Private insertRevisionItem As DevExpress.XtraBars.BarButtonItem

        Private insertSubjectItem As DevExpress.XtraBars.BarButtonItem

        Private insertTitleItem As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem16 As DevExpress.XtraBars.BarButtonItem

        Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    End Class
End Namespace
