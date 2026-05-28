Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraLayout
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.UI

Namespace DevExpress.WindowsMailClient.Win.Modules

    Partial Class MailModule

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
        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim galleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim reduceOperation1 As DevExpress.XtraBars.Ribbon.ReduceOperation = New DevExpress.XtraBars.Ribbon.ReduceOperation()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.WindowsMailClient.Win.Modules.MailModule))
            Dim columnDefinition1 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim rowDefinition1 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition2 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition3 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition4 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController(Me.components)
            Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
            Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
            Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
            Me.pasteSpecialItem1 = New DevExpress.XtraRichEdit.UI.PasteSpecialItem()
            Me.changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
            Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
            Me.editMail = New DevExpress.XtraRichEdit.RichEditControl()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
            Me.fontSizeIncreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem()
            Me.fontSizeDecreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem()
            Me.barButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
            Me.toggleFontBoldItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontBoldItem()
            Me.toggleFontItalicItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontItalicItem()
            Me.toggleFontUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem()
            Me.toggleFontDoubleUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem()
            Me.toggleFontStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem()
            Me.toggleFontDoubleStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem()
            Me.toggleFontSuperscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem()
            Me.toggleFontSubscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem()
            Me.barButtonGroup3 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeFontColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontColorItem()
            Me.changeFontHighlightColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontHighlightColorItem()
            Me.changeTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ChangeTextCaseItem()
            Me.makeTextUpperCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem()
            Me.makeTextLowerCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem()
            Me.capitalizeEachWordCaseItem1 = New DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem()
            Me.toggleTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ToggleTextCaseItem()
            Me.clearFormattingItem1 = New DevExpress.XtraRichEdit.UI.ClearFormattingItem()
            Me.barButtonGroup4 = New DevExpress.XtraBars.BarButtonGroup()
            Me.toggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.ToggleBulletedListItem()
            Me.toggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.ToggleNumberingListItem()
            Me.toggleMultiLevelListItem1 = New DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem()
            Me.barButtonGroup5 = New DevExpress.XtraBars.BarButtonGroup()
            Me.decreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.DecreaseIndentItem()
            Me.increaseIndentItem1 = New DevExpress.XtraRichEdit.UI.IncreaseIndentItem()
            Me.toggleShowWhitespaceItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem()
            Me.barButtonGroup6 = New DevExpress.XtraBars.BarButtonGroup()
            Me.toggleParagraphAlignmentLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem()
            Me.toggleParagraphAlignmentCenterItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem()
            Me.toggleParagraphAlignmentRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem()
            Me.toggleParagraphAlignmentJustifyItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem()
            Me.barButtonGroup7 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeParagraphLineSpacingItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem()
            Me.setSingleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem()
            Me.setSesquialteralParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem()
            Me.setDoubleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem()
            Me.showLineSpacingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem()
            Me.addSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem()
            Me.removeSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem()
            Me.addSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem()
            Me.removeSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem()
            Me.changeParagraphBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem()
            Me.galleryChangeStyleItem1 = New DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem()
            Me.findItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
            Me.replaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem()
            Me.insertPageBreakItem21 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem2()
            Me.insertTableItem1 = New DevExpress.XtraRichEdit.UI.InsertTableItem()
            Me.insertPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertPictureItem()
            Me.insertFloatingPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem()
            Me.insertBookmarkItem1 = New DevExpress.XtraRichEdit.UI.InsertBookmarkItem()
            Me.insertHyperlinkItem1 = New DevExpress.XtraRichEdit.UI.InsertHyperlinkItem()
            Me.editPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.EditPageHeaderItem()
            Me.editPageFooterItem1 = New DevExpress.XtraRichEdit.UI.EditPageFooterItem()
            Me.insertPageNumberItem1 = New DevExpress.XtraRichEdit.UI.InsertPageNumberItem()
            Me.insertPageCountItem1 = New DevExpress.XtraRichEdit.UI.InsertPageCountItem()
            Me.insertTextBoxItem1 = New DevExpress.XtraRichEdit.UI.InsertTextBoxItem()
            Me.insertSymbolItem1 = New DevExpress.XtraRichEdit.UI.InsertSymbolItem()
            Me.homeRibbonPage1 = New DevExpress.XtraRichEdit.UI.HomeRibbonPage()
            Me.fontRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.FontRibbonPageGroup()
            Me.paragraphRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup()
            Me.insertRibbonPage1 = New DevExpress.XtraRichEdit.UI.InsertRibbonPage()
            Me.tablesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup()
            Me.illustrationsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup()
            Me.linksRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup()
            Me.textRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TextRibbonPageGroup()
            Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.tEditSubject = New DevExpress.XtraEditors.TextEdit()
            Me.tEditTo = New DevExpress.XtraEditors.TokenEdit()
            Me.teFrom = New DevExpress.XtraEditors.TokenEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.flyoutPanel1 = New DevExpress.Utils.FlyoutPanel()
            Me.lblDescription = New DevExpress.XtraEditors.LabelControl()
            Me.lblEmail = New DevExpress.XtraEditors.LabelControl()
            Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemFontEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemRichEditFontSizeEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.tEditSubject.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tEditTo.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.teFrom.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.flyoutPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flyoutPanel1.SuspendLayout()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.richEditBarController1.BarItems.Add(Me.pasteItem1)
            Me.richEditBarController1.BarItems.Add(Me.cutItem1)
            Me.richEditBarController1.BarItems.Add(Me.copyItem1)
            Me.richEditBarController1.BarItems.Add(Me.pasteSpecialItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontNameItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontSizeItem1)
            Me.richEditBarController1.BarItems.Add(Me.fontSizeIncreaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.fontSizeDecreaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontBoldItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontItalicItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontUnderlineItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontDoubleUnderlineItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontStrikeoutItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontDoubleStrikeoutItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontSuperscriptItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontSubscriptItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontHighlightColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTextCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.makeTextUpperCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.makeTextLowerCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.capitalizeEachWordCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTextCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.clearFormattingItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleBulletedListItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleNumberingListItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleMultiLevelListItem1)
            Me.richEditBarController1.BarItems.Add(Me.decreaseIndentItem1)
            Me.richEditBarController1.BarItems.Add(Me.increaseIndentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentLeftItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentCenterItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentRightItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentJustifyItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleShowWhitespaceItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeParagraphLineSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSingleParagraphSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSesquialteralParagraphSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.setDoubleParagraphSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.showLineSpacingFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.addSpacingBeforeParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.removeSpacingBeforeParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.addSpacingAfterParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.removeSpacingAfterParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeParagraphBackColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.galleryChangeStyleItem1)
            Me.richEditBarController1.BarItems.Add(Me.findItem1)
            Me.richEditBarController1.BarItems.Add(Me.replaceItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageBreakItem21)
            Me.richEditBarController1.BarItems.Add(Me.insertTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPictureItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertFloatingPictureItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertBookmarkItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertHyperlinkItem1)
            Me.richEditBarController1.BarItems.Add(Me.editPageHeaderItem1)
            Me.richEditBarController1.BarItems.Add(Me.editPageFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageNumberItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageCountItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTextBoxItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertSymbolItem1)
            Me.richEditBarController1.Control = Me.editMail
            Me.pasteItem1.Id = 8
            Me.pasteItem1.Name = "pasteItem1"
            Me.cutItem1.Id = 9
            Me.cutItem1.Name = "cutItem1"
            Me.copyItem1.Id = 10
            Me.copyItem1.Name = "copyItem1"
            Me.pasteSpecialItem1.Id = 11
            Me.pasteSpecialItem1.Name = "pasteSpecialItem1"
            Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
            Me.changeFontNameItem1.Id = 12
            Me.changeFontNameItem1.Name = "changeFontNameItem1"
            Me.repositoryItemFontEdit1.AutoHeight = False
            Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
            Me.changeFontSizeItem1.Edit = Me.repositoryItemRichEditFontSizeEdit1
            Me.changeFontSizeItem1.Id = 13
            Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
            Me.repositoryItemRichEditFontSizeEdit1.AutoHeight = False
            Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditFontSizeEdit1.Control = Me.editMail
            Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
            Me.editMail.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
            Me.editMail.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel
            Me.editMail.Location = New System.Drawing.Point(8, 102)
            Me.editMail.Margin = New System.Windows.Forms.Padding(2)
            Me.editMail.MenuManager = Me.ribbonControl1
            Me.editMail.Name = "editMail"
            Me.editMail.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.editMail.Options.HorizontalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden
            Me.editMail.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.editMail.Options.VerticalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden
            Me.editMail.Size = New System.Drawing.Size(559, 577)
            Me.editMail.TabIndex = 4
            Me.editMail.Views.DraftView.Padding = New DevExpress.Portable.PortablePadding(4, 4, 0, 0)
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.pasteItem1, Me.cutItem1, Me.copyItem1, Me.pasteSpecialItem1, Me.barButtonGroup1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.barButtonGroup2, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.toggleFontUnderlineItem1, Me.toggleFontDoubleUnderlineItem1, Me.toggleFontStrikeoutItem1, Me.toggleFontDoubleStrikeoutItem1, Me.toggleFontSuperscriptItem1, Me.toggleFontSubscriptItem1, Me.barButtonGroup3, Me.changeFontColorItem1, Me.changeFontHighlightColorItem1, Me.changeTextCaseItem1, Me.makeTextUpperCaseItem1, Me.makeTextLowerCaseItem1, Me.capitalizeEachWordCaseItem1, Me.toggleTextCaseItem1, Me.clearFormattingItem1, Me.barButtonGroup4, Me.toggleBulletedListItem1, Me.toggleNumberingListItem1, Me.toggleMultiLevelListItem1, Me.barButtonGroup5, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.barButtonGroup6, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.toggleParagraphAlignmentJustifyItem1, Me.toggleShowWhitespaceItem1, Me.barButtonGroup7, Me.changeParagraphLineSpacingItem1, Me.setSingleParagraphSpacingItem1, Me.setSesquialteralParagraphSpacingItem1, Me.setDoubleParagraphSpacingItem1, Me.showLineSpacingFormItem1, Me.addSpacingBeforeParagraphItem1, Me.removeSpacingBeforeParagraphItem1, Me.addSpacingAfterParagraphItem1, Me.removeSpacingAfterParagraphItem1, Me.changeParagraphBackColorItem1, Me.galleryChangeStyleItem1, Me.findItem1, Me.replaceItem1, Me.insertPageBreakItem21, Me.insertTableItem1, Me.insertPictureItem1, Me.insertFloatingPictureItem1, Me.insertBookmarkItem1, Me.insertHyperlinkItem1, Me.editPageHeaderItem1, Me.editPageFooterItem1, Me.insertPageNumberItem1, Me.insertPageCountItem1, Me.insertTextBoxItem1, Me.insertSymbolItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.ribbonControl1.MaxItemId = 93
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.homeRibbonPage1, Me.insertRibbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal
            Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonControl1.Size = New System.Drawing.Size(575, 57)
            Me.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
            Me.barButtonGroup1.Id = 1
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontNameItem1, "FF")
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontSizeItem1)
            Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeIncreaseItem1, "FG")
            Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeDecreaseItem1, "FK")
            Me.barButtonGroup1.Name = "barButtonGroup1"
            Me.barButtonGroup1.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}"
            Me.fontSizeIncreaseItem1.Id = 14
            Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
            Me.fontSizeDecreaseItem1.Id = 15
            Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
            Me.barButtonGroup2.Id = 2
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontBoldItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontItalicItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontUnderlineItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontDoubleUnderlineItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontStrikeoutItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontDoubleStrikeoutItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontSuperscriptItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontSubscriptItem1)
            Me.barButtonGroup2.Name = "barButtonGroup2"
            Me.barButtonGroup2.Tag = "{433DA7F0-03E2-4650-9DB5-66DD92D16E39}"
            Me.toggleFontBoldItem1.Id = 16
            Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
            Me.toggleFontItalicItem1.Id = 17
            Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
            Me.toggleFontUnderlineItem1.Id = 18
            Me.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
            Me.toggleFontDoubleUnderlineItem1.Id = 19
            Me.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
            Me.toggleFontStrikeoutItem1.Id = 20
            Me.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
            Me.toggleFontDoubleStrikeoutItem1.Id = 21
            Me.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
            Me.toggleFontSuperscriptItem1.Id = 22
            Me.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
            Me.toggleFontSubscriptItem1.Id = 23
            Me.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
            Me.barButtonGroup3.Id = 3
            Me.barButtonGroup3.ItemLinks.Add(Me.changeFontColorItem1, "FC")
            Me.barButtonGroup3.ItemLinks.Add(Me.changeFontHighlightColorItem1, "I")
            Me.barButtonGroup3.Name = "barButtonGroup3"
            Me.barButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}"
            Me.changeFontColorItem1.Id = 24
            Me.changeFontColorItem1.Name = "changeFontColorItem1"
            Me.changeFontHighlightColorItem1.Id = 25
            Me.changeFontHighlightColorItem1.Name = "changeFontHighlightColorItem1"
            Me.changeTextCaseItem1.Id = 26
            Me.changeTextCaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextUpperCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextLowerCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.capitalizeEachWordCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTextCaseItem1)})
            Me.changeTextCaseItem1.Name = "changeTextCaseItem1"
            Me.makeTextUpperCaseItem1.Id = 27
            Me.makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1"
            Me.makeTextLowerCaseItem1.Id = 28
            Me.makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1"
            Me.capitalizeEachWordCaseItem1.Id = 29
            Me.capitalizeEachWordCaseItem1.Name = "capitalizeEachWordCaseItem1"
            Me.toggleTextCaseItem1.Id = 30
            Me.toggleTextCaseItem1.Name = "toggleTextCaseItem1"
            Me.clearFormattingItem1.Id = 31
            Me.clearFormattingItem1.Name = "clearFormattingItem1"
            Me.barButtonGroup4.Id = 4
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleBulletedListItem1, "U")
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleNumberingListItem1, "N")
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleMultiLevelListItem1, "M")
            Me.barButtonGroup4.Name = "barButtonGroup4"
            Me.barButtonGroup4.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
            Me.toggleBulletedListItem1.Id = 32
            Me.toggleBulletedListItem1.Name = "toggleBulletedListItem1"
            Me.toggleNumberingListItem1.Id = 33
            Me.toggleNumberingListItem1.Name = "toggleNumberingListItem1"
            Me.toggleMultiLevelListItem1.Id = 34
            Me.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
            Me.barButtonGroup5.Id = 5
            Me.barButtonGroup5.ItemLinks.Add(Me.decreaseIndentItem1, "AO")
            Me.barButtonGroup5.ItemLinks.Add(Me.increaseIndentItem1, "AI")
            Me.barButtonGroup5.ItemLinks.Add(Me.toggleShowWhitespaceItem1)
            Me.barButtonGroup5.Name = "barButtonGroup5"
            Me.barButtonGroup5.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}"
            Me.decreaseIndentItem1.Id = 35
            Me.decreaseIndentItem1.Name = "decreaseIndentItem1"
            Me.increaseIndentItem1.Id = 36
            Me.increaseIndentItem1.Name = "increaseIndentItem1"
            Me.toggleShowWhitespaceItem1.Id = 41
            Me.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
            Me.barButtonGroup6.Id = 6
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentLeftItem1, "AL")
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentCenterItem1, "AC")
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentRightItem1, "AR")
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentJustifyItem1, "AJ")
            Me.barButtonGroup6.Name = "barButtonGroup6"
            Me.barButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}"
            Me.toggleParagraphAlignmentLeftItem1.Id = 37
            Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
            Me.toggleParagraphAlignmentCenterItem1.Id = 38
            Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
            Me.toggleParagraphAlignmentRightItem1.Id = 39
            Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
            Me.toggleParagraphAlignmentJustifyItem1.Id = 40
            Me.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
            Me.barButtonGroup7.Id = 7
            Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphLineSpacingItem1, "K")
            Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphBackColorItem1, "H")
            Me.barButtonGroup7.Name = "barButtonGroup7"
            Me.barButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}"
            Me.changeParagraphLineSpacingItem1.Id = 42
            Me.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setSingleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSesquialteralParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setDoubleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showLineSpacingFormItem1), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, Me.addSpacingBeforeParagraphItem1, "", False, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard, "B", ""), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingAfterParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingAfterParagraphItem1)})
            Me.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1"
            Me.setSingleParagraphSpacingItem1.Id = 43
            Me.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1"
            Me.setSesquialteralParagraphSpacingItem1.Id = 44
            Me.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1"
            Me.setDoubleParagraphSpacingItem1.Id = 45
            Me.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1"
            Me.showLineSpacingFormItem1.Id = 46
            Me.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1"
            Me.addSpacingBeforeParagraphItem1.Id = 47
            Me.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1"
            Me.removeSpacingBeforeParagraphItem1.Id = 48
            Me.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1"
            Me.addSpacingAfterParagraphItem1.Id = 49
            Me.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1"
            Me.removeSpacingAfterParagraphItem1.Id = 50
            Me.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1"
            Me.changeParagraphBackColorItem1.Id = 51
            Me.changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1"
            Me.galleryChangeStyleItem1.Gallery.ColumnCount = 10
            Me.galleryChangeStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {galleryItemGroup1})
            Me.galleryChangeStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.galleryChangeStyleItem1.Id = 52
            Me.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1"
            Me.findItem1.Id = 53
            Me.findItem1.Name = "findItem1"
            Me.replaceItem1.Id = 54
            Me.replaceItem1.Name = "replaceItem1"
            Me.insertPageBreakItem21.Id = 55
            Me.insertPageBreakItem21.Name = "insertPageBreakItem21"
            Me.insertTableItem1.Id = 56
            Me.insertTableItem1.Name = "insertTableItem1"
            Me.insertPictureItem1.Id = 57
            Me.insertPictureItem1.Name = "insertPictureItem1"
            Me.insertFloatingPictureItem1.Id = 58
            Me.insertFloatingPictureItem1.Name = "insertFloatingPictureItem1"
            Me.insertBookmarkItem1.Id = 59
            Me.insertBookmarkItem1.Name = "insertBookmarkItem1"
            Me.insertHyperlinkItem1.Id = 60
            Me.insertHyperlinkItem1.Name = "insertHyperlinkItem1"
            Me.editPageHeaderItem1.Id = 61
            Me.editPageHeaderItem1.Name = "editPageHeaderItem1"
            Me.editPageFooterItem1.Id = 62
            Me.editPageFooterItem1.Name = "editPageFooterItem1"
            Me.insertPageNumberItem1.Id = 63
            Me.insertPageNumberItem1.Name = "insertPageNumberItem1"
            Me.insertPageCountItem1.Id = 64
            Me.insertPageCountItem1.Name = "insertPageCountItem1"
            Me.insertTextBoxItem1.Id = 65
            Me.insertTextBoxItem1.Name = "insertTextBoxItem1"
            Me.insertSymbolItem1.Id = 66
            Me.insertSymbolItem1.Name = "insertSymbolItem1"
            Me.homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.fontRibbonPageGroup1, Me.paragraphRibbonPageGroup1})
            Me.homeRibbonPage1.Name = "homeRibbonPage1"
            reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable
            reduceOperation1.GroupName = Nothing
            reduceOperation1.ItemLinkIndex = 0
            reduceOperation1.ItemLinksCount = 0
            reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery
            Me.homeRibbonPage1.ReduceOperations.Add(reduceOperation1)
            Me.homeRibbonPage1.Text = "Format"
            Me.fontRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[True]
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup2)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup3)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.changeTextCaseItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.clearFormattingItem1, "E")
            Me.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1"
            Me.paragraphRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[True]
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup4)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup5)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup6)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup7)
            Me.paragraphRibbonPageGroup1.Name = "paragraphRibbonPageGroup1"
            Me.insertRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.tablesRibbonPageGroup1, Me.illustrationsRibbonPageGroup1, Me.linksRibbonPageGroup1, Me.textRibbonPageGroup1})
            Me.insertRibbonPage1.Name = "insertRibbonPage1"
            Me.tablesRibbonPageGroup1.AllowTextClipping = False
            Me.tablesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.tablesRibbonPageGroup1.ItemLinks.Add(Me.insertTableItem1, "T")
            Me.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1"
            Me.illustrationsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.insertPictureItem1, "P")
            Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.insertFloatingPictureItem1)
            Me.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1"
            Me.linksRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.linksRibbonPageGroup1.ItemLinks.Add(Me.insertHyperlinkItem1, "I")
            Me.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1"
            Me.textRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.textRibbonPageGroup1.ImageOptions.Image = CType((resources.GetObject("textRibbonPageGroup1.ImageOptions.Image")), System.Drawing.Image)
            Me.textRibbonPageGroup1.ItemLinks.Add(Me.insertTextBoxItem1, "X")
            Me.textRibbonPageGroup1.Name = "textRibbonPageGroup1"
            Me.dockManager1.Form = Me
            Me.dockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.AutoScroll = False
            Me.layoutControl1.Controls.Add(Me.tEditSubject)
            Me.layoutControl1.Controls.Add(Me.editMail)
            Me.layoutControl1.Controls.Add(Me.tEditTo)
            Me.layoutControl1.Controls.Add(Me.teFrom)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 57)
            Me.layoutControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(434, 235, 1017, 597)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(575, 687)
            Me.layoutControl1.TabIndex = 5
            Me.layoutControl1.Text = "layoutControl1"
            Me.tEditSubject.Location = New System.Drawing.Point(8, 70)
            Me.tEditSubject.Margin = New System.Windows.Forms.Padding(2)
            Me.tEditSubject.Name = "tEditSubject"
            Me.tEditSubject.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9F)
            Me.tEditSubject.Properties.Appearance.Options.UseFont = True
            Me.tEditSubject.Properties.AutoHeight = False
            Me.tEditSubject.Properties.NullText = " Subject:"
            Me.tEditSubject.Properties.NullValuePrompt = " Subject:"
            Me.tEditSubject.Size = New System.Drawing.Size(559, 24)
            Me.tEditSubject.StyleController = Me.layoutControl1
            Me.tEditSubject.TabIndex = 3
            Me.tEditTo.Location = New System.Drawing.Point(8, 40)
            Me.tEditTo.Margin = New System.Windows.Forms.Padding(2)
            Me.tEditTo.Name = "tEditTo"
            Me.tEditTo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9F)
            Me.tEditTo.Properties.Appearance.Options.UseFont = True
            Me.tEditTo.Properties.DropDownShowMode = DevExpress.XtraEditors.TokenEditDropDownShowMode.Outlook
            Me.tEditTo.Properties.EditMode = DevExpress.XtraEditors.TokenEditMode.Manual
            Me.tEditTo.Properties.EditValueType = DevExpress.XtraEditors.TokenEditValueType.List
            Me.tEditTo.Properties.NullText = " To:"
            Me.tEditTo.Properties.Separators.AddRange(New String() {","})
            Me.tEditTo.Size = New System.Drawing.Size(559, 22)
            Me.tEditTo.StyleController = Me.layoutControl1
            Me.tEditTo.TabIndex = 2
            AddHandler Me.tEditTo.ValidateToken, New DevExpress.XtraEditors.TokenEditValidateTokenEventHandler(AddressOf Me.tEditTo_ValidateToken)
            AddHandler Me.tEditTo.BeforeShowPopupPanel, New DevExpress.XtraEditors.TokenEditBeforeShowPopupPanelEventHandler(AddressOf Me.tEditTo_BeforeShowPopupPanel)
            AddHandler Me.tEditTo.CustomDrawTokenGlyph, New DevExpress.XtraEditors.TokenEditCustomDrawTokenGlyphEventHandler(AddressOf Me.tEditTo_CustomDrawTokenGlyph)
            Me.teFrom.Location = New System.Drawing.Point(8, 10)
            Me.teFrom.MenuManager = Me.ribbonControl1
            Me.teFrom.Name = "teFrom"
            Me.teFrom.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9F)
            Me.teFrom.Properties.Appearance.Options.UseFont = True
            Me.teFrom.Properties.DropDownShowMode = DevExpress.XtraEditors.TokenEditDropDownShowMode.Outlook
            Me.teFrom.Properties.EditMode = DevExpress.XtraEditors.TokenEditMode.Manual
            Me.teFrom.Properties.EditValueType = DevExpress.XtraEditors.TokenEditValueType.List
            Me.teFrom.Properties.NullText = " From:"
            Me.teFrom.Properties.Separators.AddRange(New String() {","})
            Me.teFrom.Size = New System.Drawing.Size(559, 22)
            Me.teFrom.StyleController = Me.layoutControl1
            Me.teFrom.TabIndex = 5
            AddHandler Me.teFrom.ValidateToken, New DevExpress.XtraEditors.TokenEditValidateTokenEventHandler(AddressOf Me.tEditTo_ValidateToken)
            AddHandler Me.teFrom.CustomDrawTokenGlyph, New DevExpress.XtraEditors.TokenEditCustomDrawTokenGlyphEventHandler(AddressOf Me.tEditTo_CustomDrawTokenGlyph)
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem1})
            Me.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            Me.layoutControlGroup1.Name = "Root"
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition1.Width = 100R
            Me.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(New DevExpress.XtraLayout.ColumnDefinition() {columnDefinition1})
            rowDefinition1.Height = 5R
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent
            rowDefinition2.Height = 5R
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent
            rowDefinition3.Height = 5R
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent
            rowDefinition4.Height = 85R
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Percent
            Me.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(New DevExpress.XtraLayout.RowDefinition() {rowDefinition1, rowDefinition2, rowDefinition3, rowDefinition4})
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(575, 687)
            Me.layoutControlGroup1.TextVisible = False
            Me.layoutControlItem2.Control = Me.editMail
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 102)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 3
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 8, 0, 8)
            Me.layoutControlItem2.Size = New System.Drawing.Size(575, 585)
            Me.layoutControlItem2.TextVisible = False
            Me.layoutControlItem3.Control = Me.tEditSubject
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 68)
            Me.layoutControlItem3.MinSize = New System.Drawing.Size(66, 30)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 8, 2, 8)
            Me.layoutControlItem3.Size = New System.Drawing.Size(575, 34)
            Me.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem3.TextVisible = False
            Me.layoutControlItem4.Control = Me.tEditTo
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 34)
            Me.layoutControlItem4.MinSize = New System.Drawing.Size(24, 32)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 1
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 8, 6, 4)
            Me.layoutControlItem4.Size = New System.Drawing.Size(575, 34)
            Me.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem4.TextVisible = False
            Me.layoutControlItem1.Control = Me.teFrom
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(24, 32)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 8, 10, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(575, 34)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextVisible = False
            Me.flyoutPanel1.Controls.Add(Me.lblDescription)
            Me.flyoutPanel1.Controls.Add(Me.lblEmail)
            Me.flyoutPanel1.Controls.Add(Me.pictureEdit1)
            Me.flyoutPanel1.Location = New System.Drawing.Point(324, 42)
            Me.flyoutPanel1.Name = "flyoutPanel1"
            Me.flyoutPanel1.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Bottom
            Me.flyoutPanel1.OptionsButtonPanel.ShowButtonPanel = True
            Me.flyoutPanel1.OwnerControl = Me.tEditTo
            Me.flyoutPanel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 30)
            Me.flyoutPanel1.Size = New System.Drawing.Size(215, 97)
            Me.flyoutPanel1.TabIndex = 9
            Me.lblDescription.Location = New System.Drawing.Point(60, 31)
            Me.lblDescription.Margin = New System.Windows.Forms.Padding(2)
            Me.lblDescription.Name = "lblDescription"
            Me.lblDescription.Size = New System.Drawing.Size(64, 13)
            Me.lblDescription.TabIndex = 3
            Me.lblDescription.Text = "(description)"
            Me.lblEmail.Location = New System.Drawing.Point(60, 4)
            Me.lblEmail.Margin = New System.Windows.Forms.Padding(2)
            Me.lblEmail.Name = "lblEmail"
            Me.lblEmail.Size = New System.Drawing.Size(33, 13)
            Me.lblEmail.TabIndex = 2
            Me.lblEmail.Text = "(Email)"
            Me.pictureEdit1.EditValue =(CObj((resources.GetObject("pictureEdit1.EditValue"))))
            Me.pictureEdit1.Location = New System.Drawing.Point(2, 4)
            Me.pictureEdit1.Margin = New System.Windows.Forms.Padding(2)
            Me.pictureEdit1.MenuManager = Me.ribbonControl1
            Me.pictureEdit1.Name = "pictureEdit1"
            Me.pictureEdit1.Properties.AllowFocused = False
            Me.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.pictureEdit1.Properties.Appearance.Options.UseBackColor = True
            Me.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pictureEdit1.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Circle
            Me.pictureEdit1.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            Me.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
            Me.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
            Me.pictureEdit1.Size = New System.Drawing.Size(53, 53)
            Me.pictureEdit1.TabIndex = 1
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.flyoutPanel1)
            Me.Controls.Add(Me.layoutControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "MailModule"
            Me.Size = New System.Drawing.Size(575, 744)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemFontEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemRichEditFontSizeEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.tEditSubject.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tEditTo.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.teFrom.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.flyoutPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.flyoutPanel1.ResumeLayout(False)
            Me.flyoutPanel1.PerformLayout()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController

        Private dockManager1 As DevExpress.XtraBars.Docking.DockManager

        Private editMail As DevExpress.XtraRichEdit.RichEditControl

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private tEditSubject As DevExpress.XtraEditors.TextEdit

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem

        Private cutItem1 As DevExpress.XtraRichEdit.UI.CutItem

        Private copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem

        Private pasteSpecialItem1 As DevExpress.XtraRichEdit.UI.PasteSpecialItem

        Private changeFontNameItem1 As DevExpress.XtraRichEdit.UI.ChangeFontNameItem

        Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit

        Private changeFontSizeItem1 As DevExpress.XtraRichEdit.UI.ChangeFontSizeItem

        Private repositoryItemRichEditFontSizeEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl

        Private barButtonGroup1 As DevExpress.XtraBars.BarButtonGroup

        Private fontSizeIncreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem

        Private fontSizeDecreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem

        Private barButtonGroup2 As DevExpress.XtraBars.BarButtonGroup

        Private toggleFontBoldItem1 As DevExpress.XtraRichEdit.UI.ToggleFontBoldItem

        Private toggleFontItalicItem1 As DevExpress.XtraRichEdit.UI.ToggleFontItalicItem

        Private toggleFontUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem

        Private toggleFontDoubleUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem

        Private toggleFontStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem

        Private toggleFontDoubleStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem

        Private toggleFontSuperscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem

        Private toggleFontSubscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem

        Private barButtonGroup3 As DevExpress.XtraBars.BarButtonGroup

        Private changeFontColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontColorItem

        Private changeFontHighlightColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontHighlightColorItem

        Private changeTextCaseItem1 As DevExpress.XtraRichEdit.UI.ChangeTextCaseItem

        Private makeTextUpperCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem

        Private makeTextLowerCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem

        Private capitalizeEachWordCaseItem1 As DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem

        Private toggleTextCaseItem1 As DevExpress.XtraRichEdit.UI.ToggleTextCaseItem

        Private clearFormattingItem1 As DevExpress.XtraRichEdit.UI.ClearFormattingItem

        Private barButtonGroup4 As DevExpress.XtraBars.BarButtonGroup

        Private toggleBulletedListItem1 As DevExpress.XtraRichEdit.UI.ToggleBulletedListItem

        Private toggleNumberingListItem1 As DevExpress.XtraRichEdit.UI.ToggleNumberingListItem

        Private toggleMultiLevelListItem1 As DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem

        Private barButtonGroup5 As DevExpress.XtraBars.BarButtonGroup

        Private decreaseIndentItem1 As DevExpress.XtraRichEdit.UI.DecreaseIndentItem

        Private increaseIndentItem1 As DevExpress.XtraRichEdit.UI.IncreaseIndentItem

        Private toggleShowWhitespaceItem1 As DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem

        Private barButtonGroup6 As DevExpress.XtraBars.BarButtonGroup

        Private toggleParagraphAlignmentLeftItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem

        Private toggleParagraphAlignmentCenterItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem

        Private toggleParagraphAlignmentRightItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem

        Private toggleParagraphAlignmentJustifyItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem

        Private barButtonGroup7 As DevExpress.XtraBars.BarButtonGroup

        Private changeParagraphLineSpacingItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem

        Private setSingleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem

        Private setSesquialteralParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem

        Private setDoubleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem

        Private showLineSpacingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem

        Private addSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem

        Private removeSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem

        Private addSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem

        Private removeSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem

        Private changeParagraphBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem

        Private galleryChangeStyleItem1 As DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem

        Private findItem1 As DevExpress.XtraRichEdit.UI.FindItem

        Private replaceItem1 As DevExpress.XtraRichEdit.UI.ReplaceItem

        Private homeRibbonPage1 As DevExpress.XtraRichEdit.UI.HomeRibbonPage

        Private fontRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.FontRibbonPageGroup

        Private paragraphRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup

        Private insertPageBreakItem21 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem2

        Private insertTableItem1 As DevExpress.XtraRichEdit.UI.InsertTableItem

        Private insertPictureItem1 As DevExpress.XtraRichEdit.UI.InsertPictureItem

        Private insertFloatingPictureItem1 As DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem

        Private insertBookmarkItem1 As DevExpress.XtraRichEdit.UI.InsertBookmarkItem

        Private insertHyperlinkItem1 As DevExpress.XtraRichEdit.UI.InsertHyperlinkItem

        Private editPageHeaderItem1 As DevExpress.XtraRichEdit.UI.EditPageHeaderItem

        Private editPageFooterItem1 As DevExpress.XtraRichEdit.UI.EditPageFooterItem

        Private insertPageNumberItem1 As DevExpress.XtraRichEdit.UI.InsertPageNumberItem

        Private insertPageCountItem1 As DevExpress.XtraRichEdit.UI.InsertPageCountItem

        Private insertTextBoxItem1 As DevExpress.XtraRichEdit.UI.InsertTextBoxItem

        Private insertSymbolItem1 As DevExpress.XtraRichEdit.UI.InsertSymbolItem

        Private insertRibbonPage1 As DevExpress.XtraRichEdit.UI.InsertRibbonPage

        Private tablesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup

        Private illustrationsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup

        Private linksRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup

        Private textRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TextRibbonPageGroup

        Private tEditTo As DevExpress.XtraEditors.TokenEdit

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private teFrom As DevExpress.XtraEditors.TokenEdit

        Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit

        Private flyoutPanel1 As DevExpress.Utils.FlyoutPanel

        Private lblDescription As DevExpress.XtraEditors.LabelControl

        Private lblEmail As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace
