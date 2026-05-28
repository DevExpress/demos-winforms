Namespace DevExpress.MailClient.Win.Forms
    Partial Public Class frmEditTask
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmEditTask))
            Dim borderInfo1 As New DevExpress.XtraRichEdit.Model.BorderInfo()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.lcMain = New DevExpress.XtraLayout.LayoutControl()
            Me.sePercentComplete = New DevExpress.XtraEditors.SpinEdit()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
            Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
            Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
            Me.pasteSpecialItem1 = New DevExpress.XtraRichEdit.UI.PasteSpecialItem()
            Me.barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
            Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
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
            Me.changeFontBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem()
            Me.changeTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ChangeTextCaseItem()
            Me.makeTextUpperCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem()
            Me.makeTextLowerCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem()
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
            Me.changeStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeStyleItem()
            Me.repositoryItemRichEditStyleEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit()
            Me.findItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
            Me.replaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem()
            Me.insertPageBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem()
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
            Me.changeTableCellsShadingItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem()
            Me.changeTableBordersItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBordersItem()
            Me.toggleTableCellsBottomBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem()
            Me.toggleTableCellsTopBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem()
            Me.toggleTableCellsLeftBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem()
            Me.toggleTableCellsRightBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem()
            Me.resetTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem()
            Me.toggleTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem()
            Me.toggleTableCellsOutsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem()
            Me.toggleTableCellsInsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem()
            Me.toggleTableCellsInsideHorizontalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem()
            Me.toggleTableCellsInsideVerticalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem()
            Me.toggleShowTableGridLinesItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem()
            Me.changeTableBorderLineStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem()
            Me.repositoryItemBorderLineStyle1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle()
            Me.changeTableBorderLineWeightItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem()
            Me.repositoryItemBorderLineWeight1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight()
            Me.changeTableBorderColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem()
            Me.selectTableElementsItem1 = New DevExpress.XtraRichEdit.UI.SelectTableElementsItem()
            Me.selectTableCellItem1 = New DevExpress.XtraRichEdit.UI.SelectTableCellItem()
            Me.selectTableColumnItem1 = New DevExpress.XtraRichEdit.UI.SelectTableColumnItem()
            Me.selectTableRowItem1 = New DevExpress.XtraRichEdit.UI.SelectTableRowItem()
            Me.selectTableItem1 = New DevExpress.XtraRichEdit.UI.SelectTableItem()
            Me.showTablePropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem()
            Me.deleteTableElementsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableElementsItem()
            Me.showDeleteTableCellsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem()
            Me.deleteTableColumnsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem()
            Me.deleteTableRowsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableRowsItem()
            Me.deleteTableItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableItem()
            Me.insertTableRowAboveItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem()
            Me.insertTableRowBelowItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem()
            Me.insertTableColumnToLeftItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem()
            Me.insertTableColumnToRightItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem()
            Me.mergeTableCellsItem1 = New DevExpress.XtraRichEdit.UI.MergeTableCellsItem()
            Me.showSplitTableCellsForm1 = New DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm()
            Me.splitTableItem1 = New DevExpress.XtraRichEdit.UI.SplitTableItem()
            Me.toggleTableAutoFitItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem()
            Me.toggleTableAutoFitContentsItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem()
            Me.toggleTableAutoFitWindowItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem()
            Me.toggleTableFixedColumnWidthItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem()
            Me.toggleTableCellsTopLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem()
            Me.toggleTableCellsMiddleLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem()
            Me.toggleTableCellsBottomLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem()
            Me.toggleTableCellsTopCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem()
            Me.toggleTableCellsMiddleCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem()
            Me.toggleTableCellsBottomCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem()
            Me.toggleTableCellsTopRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem()
            Me.toggleTableCellsMiddleRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem()
            Me.toggleTableCellsBottomRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem()
            Me.changeFloatingObjectFillColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectFillColorItem()
            Me.changeFloatingObjectOutlineColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineColorItem()
            Me.changeFloatingObjectOutlineWeightItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineWeightItem()
            Me.repositoryItemFloatingObjectOutlineWeight1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight()
            Me.changeFloatingObjectTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectTextWrapTypeItem()
            Me.setFloatingObjectSquareTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectSquareTextWrapTypeItem()
            Me.setFloatingObjectTightTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTightTextWrapTypeItem()
            Me.setFloatingObjectThroughTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectThroughTextWrapTypeItem()
            Me.setFloatingObjectTopAndBottomTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopAndBottomTextWrapTypeItem()
            Me.setFloatingObjectBehindTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBehindTextWrapTypeItem()
            Me.setFloatingObjectInFrontOfTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectInFrontOfTextWrapTypeItem()
            Me.changeFloatingObjectAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectAlignmentItem()
            Me.setFloatingObjectTopLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopLeftAlignmentItem()
            Me.setFloatingObjectTopCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopCenterAlignmentItem()
            Me.setFloatingObjectTopRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopRightAlignmentItem()
            Me.setFloatingObjectMiddleLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleLeftAlignmentItem()
            Me.setFloatingObjectMiddleCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleCenterAlignmentItem()
            Me.setFloatingObjectMiddleRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleRightAlignmentItem()
            Me.setFloatingObjectBottomLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomLeftAlignmentItem()
            Me.setFloatingObjectBottomCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomCenterAlignmentItem()
            Me.setFloatingObjectBottomRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomRightAlignmentItem()
            Me.floatingObjectBringForwardSubItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardSubItem()
            Me.floatingObjectBringForwardItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardItem()
            Me.floatingObjectBringToFrontItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringToFrontItem()
            Me.floatingObjectBringInFrontOfTextItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringInFrontOfTextItem()
            Me.floatingObjectSendBackwardSubItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardSubItem()
            Me.floatingObjectSendBackwardItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardItem()
            Me.floatingObjectSendToBackItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendToBackItem()
            Me.floatingObjectSendBehindTextItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendBehindTextItem()
            Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
            Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
            Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
            Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
            Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
            Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
            Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
            Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
            Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
            Me.tableToolsRibbonPageCategory1 = New DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory()
            Me.tableDesignRibbonPage1 = New DevExpress.XtraRichEdit.UI.TableDesignRibbonPage()
            Me.tableStylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup()
            Me.tableDrawBordersRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup()
            Me.tableLayoutRibbonPage1 = New DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage()
            Me.tableTableRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup()
            Me.tableRowsAndColumnsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup()
            Me.tableMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup()
            Me.tableCellSizeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup()
            Me.tableAlignmentRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup()
            Me.floatingPictureToolsRibbonPageCategory1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsRibbonPageCategory()
            Me.floatingPictureToolsFormatPage1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsFormatPage()
            Me.floatingPictureToolsShapeStylesPageGroup1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsShapeStylesPageGroup()
            Me.floatingPictureToolsArrangePageGroup1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsArrangePageGroup()
            Me.homeRibbonPage1 = New DevExpress.XtraRichEdit.UI.HomeRibbonPage()
            Me.clipboardRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup()
            Me.fontRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.FontRibbonPageGroup()
            Me.paragraphRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup()
            Me.stylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup()
            Me.editingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup()
            Me.insertRibbonPage1 = New DevExpress.XtraRichEdit.UI.InsertRibbonPage()
            Me.pagesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup()
            Me.tablesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup()
            Me.illustrationsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup()
            Me.linksRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup()
            Me.headerFooterRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup()
            Me.textRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TextRibbonPageGroup()
            Me.symbolsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup()
            Me.icbPriority = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icEditors = New DevExpress.Utils.ImageCollection(Me.components)
            Me.icbStatus = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.deStartDate = New DevExpress.XtraEditors.DateEdit()
            Me.icbCategory = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icCategory = New DevExpress.Utils.ImageCollection(Me.components)
            Me.sbCancel = New DevExpress.XtraEditors.SimpleButton()
            Me.deDueDate = New DevExpress.XtraEditors.DateEdit()
            Me.sbOK = New DevExpress.XtraEditors.SimpleButton()
            Me.teSubject = New DevExpress.XtraEditors.TextEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciSubject = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciDescription = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciCategory = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciStartDate = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciDueDate = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciStatus = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciPriority = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciPercentComplete = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.ucContactInfo1 = New DevExpress.MailClient.Win.Controls.ucContactInfo()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
            Me.showFontFormItem1 = New DevExpress.XtraRichEdit.UI.ShowFontFormItem()
            Me.showParagraphFormItem1 = New DevExpress.XtraRichEdit.UI.ShowParagraphFormItem()
            Me.showEditStyleFormItem1 = New DevExpress.XtraRichEdit.UI.ShowEditStyleFormItem()
            Me.showInsertTableCellsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowInsertTableCellsFormItem()
            Me.dxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
            DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            DirectCast(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.lcMain.SuspendLayout()
            DirectCast(Me.sePercentComplete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemFloatingObjectOutlineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.icbPriority.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.icEditors, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.icbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.deStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.deStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.icbCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.icCategory, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.deDueDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.deDueDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.teSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciSubject, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciDescription, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciCategory, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciDueDate, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciStatus, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciPriority, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciPercentComplete, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' splitContainerControl1
            ' 
            resources.ApplyResources(Me.splitContainerControl1, "splitContainerControl1")
            Me.splitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2
            Me.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
            Me.splitContainerControl1.Name = "splitContainerControl1"
            resources.ApplyResources(Me.splitContainerControl1.Panel1, "splitContainerControl1.Panel1")
            Me.splitContainerControl1.Panel1.Controls.Add(Me.lcMain)
            resources.ApplyResources(Me.splitContainerControl1.Panel2, "splitContainerControl1.Panel2")
            Me.splitContainerControl1.Panel2.Controls.Add(Me.ucContactInfo1)
            Me.splitContainerControl1.SplitterPosition = 225
            ' 
            ' lcMain
            ' 
            resources.ApplyResources(Me.lcMain, "lcMain")
            Me.lcMain.AllowCustomization = False
            Me.lcMain.Appearance.DisabledLayoutGroupCaption.FontSizeDelta = (DirectCast(resources.GetObject("lcMain.Appearance.DisabledLayoutGroupCaption.FontSizeDelta"), Integer))
            Me.lcMain.Appearance.DisabledLayoutGroupCaption.FontStyleDelta = (DirectCast(resources.GetObject("lcMain.Appearance.DisabledLayoutGroupCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.lcMain.Appearance.DisabledLayoutGroupCaption.GradientMode = (DirectCast(resources.GetObject("lcMain.Appearance.DisabledLayoutGroupCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.lcMain.Appearance.DisabledLayoutGroupCaption.Image = (DirectCast(resources.GetObject("lcMain.Appearance.DisabledLayoutGroupCaption.Image"), System.Drawing.Image))
            Me.lcMain.Appearance.DisabledLayoutItem.FontSizeDelta = (DirectCast(resources.GetObject("lcMain.Appearance.DisabledLayoutItem.FontSizeDelta"), Integer))
            Me.lcMain.Appearance.DisabledLayoutItem.FontStyleDelta = (DirectCast(resources.GetObject("lcMain.Appearance.DisabledLayoutItem.FontStyleDelta"), System.Drawing.FontStyle))
            Me.lcMain.Appearance.DisabledLayoutItem.GradientMode = (DirectCast(resources.GetObject("lcMain.Appearance.DisabledLayoutItem.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.lcMain.Appearance.DisabledLayoutItem.Image = (DirectCast(resources.GetObject("lcMain.Appearance.DisabledLayoutItem.Image"), System.Drawing.Image))
            Me.lcMain.Controls.Add(Me.sePercentComplete)
            Me.lcMain.Controls.Add(Me.icbPriority)
            Me.lcMain.Controls.Add(Me.icbStatus)
            Me.lcMain.Controls.Add(Me.deStartDate)
            Me.lcMain.Controls.Add(Me.icbCategory)
            Me.lcMain.Controls.Add(Me.richEditControl1)
            Me.lcMain.Controls.Add(Me.sbCancel)
            Me.lcMain.Controls.Add(Me.deDueDate)
            Me.lcMain.Controls.Add(Me.sbOK)
            Me.lcMain.Controls.Add(Me.teSubject)
            Me.lcMain.Name = "lcMain"
            Me.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(811, 311, 450, 350)
            Me.lcMain.OptionsPrint.AppearanceGroupCaption.FontSizeDelta = (DirectCast(resources.GetObject("lcMain.OptionsPrint.AppearanceGroupCaption.FontSizeDelta"), Integer))
            Me.lcMain.OptionsPrint.AppearanceGroupCaption.FontStyleDelta = (DirectCast(resources.GetObject("lcMain.OptionsPrint.AppearanceGroupCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.lcMain.OptionsPrint.AppearanceGroupCaption.GradientMode = (DirectCast(resources.GetObject("lcMain.OptionsPrint.AppearanceGroupCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.lcMain.OptionsPrint.AppearanceGroupCaption.Image = (DirectCast(resources.GetObject("lcMain.OptionsPrint.AppearanceGroupCaption.Image"), System.Drawing.Image))
            Me.lcMain.OptionsPrint.AppearanceItemCaption.FontSizeDelta = (DirectCast(resources.GetObject("lcMain.OptionsPrint.AppearanceItemCaption.FontSizeDelta"), Integer))
            Me.lcMain.OptionsPrint.AppearanceItemCaption.FontStyleDelta = (DirectCast(resources.GetObject("lcMain.OptionsPrint.AppearanceItemCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.lcMain.OptionsPrint.AppearanceItemCaption.GradientMode = (DirectCast(resources.GetObject("lcMain.OptionsPrint.AppearanceItemCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.lcMain.OptionsPrint.AppearanceItemCaption.Image = (DirectCast(resources.GetObject("lcMain.OptionsPrint.AppearanceItemCaption.Image"), System.Drawing.Image))
            'this.lcMain.OptionsView.RightToLeftMirroringApplied = true;
            Me.lcMain.Root = Me.layoutControlGroup1
            ' 
            ' sePercentComplete
            ' 
            Me.sePercentComplete.AllowDrop = True
            resources.ApplyResources(Me.sePercentComplete, "sePercentComplete")
            Me.sePercentComplete.MenuManager = Me.ribbonControl1
            Me.sePercentComplete.Name = "sePercentComplete"
            Me.sePercentComplete.Properties.AccessibleDescription = resources.GetString("sePercentComplete.Properties.AccessibleDescription")
            Me.sePercentComplete.Properties.AccessibleName = resources.GetString("sePercentComplete.Properties.AccessibleName")
            Me.sePercentComplete.Properties.AutoHeight = (DirectCast(resources.GetObject("sePercentComplete.Properties.AutoHeight"), Boolean))
            Me.sePercentComplete.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.sePercentComplete.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.sePercentComplete.Properties.Increment = New Decimal(New Integer() { 25, 0, 0, 0})
            Me.sePercentComplete.Properties.IsFloatValue = False
            Me.sePercentComplete.Properties.Mask.AutoComplete = (DirectCast(resources.GetObject("sePercentComplete.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
            Me.sePercentComplete.Properties.Mask.BeepOnError = (DirectCast(resources.GetObject("sePercentComplete.Properties.Mask.BeepOnError"), Boolean))
            Me.sePercentComplete.Properties.Mask.EditMask = resources.GetString("sePercentComplete.Properties.Mask.EditMask")
            Me.sePercentComplete.Properties.Mask.IgnoreMaskBlank = (DirectCast(resources.GetObject("sePercentComplete.Properties.Mask.IgnoreMaskBlank"), Boolean))
            Me.sePercentComplete.Properties.Mask.MaskType = (DirectCast(resources.GetObject("sePercentComplete.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.sePercentComplete.Properties.Mask.PlaceHolder = (DirectCast(resources.GetObject("sePercentComplete.Properties.Mask.PlaceHolder"), Char))
            Me.sePercentComplete.Properties.Mask.SaveLiteral = (DirectCast(resources.GetObject("sePercentComplete.Properties.Mask.SaveLiteral"), Boolean))
            Me.sePercentComplete.Properties.Mask.ShowPlaceHolders = (DirectCast(resources.GetObject("sePercentComplete.Properties.Mask.ShowPlaceHolders"), Boolean))
            Me.sePercentComplete.Properties.Mask.UseMaskAsDisplayFormat = (DirectCast(resources.GetObject("sePercentComplete.Properties.Mask.UseMaskAsDisplayFormat"), Boolean))
            Me.sePercentComplete.Properties.MaxValue = New Decimal(New Integer() { 100, 0, 0, 0})
            Me.sePercentComplete.Properties.NullValuePrompt = resources.GetString("sePercentComplete.Properties.NullValuePrompt")
            Me.sePercentComplete.Properties.NullValuePromptShowForEmptyValue = (DirectCast(resources.GetObject("sePercentComplete.Properties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.sePercentComplete.StyleController = Me.lcMain
            ' 
            ' ribbonControl1
            ' 
            resources.ApplyResources(Me.ribbonControl1, "ribbonControl1")
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.pasteItem1, Me.cutItem1, Me.copyItem1, Me.pasteSpecialItem1, Me.barButtonGroup1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.barButtonGroup2, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.toggleFontUnderlineItem1, Me.toggleFontDoubleUnderlineItem1, Me.toggleFontStrikeoutItem1, Me.toggleFontDoubleStrikeoutItem1, Me.toggleFontSuperscriptItem1, Me.toggleFontSubscriptItem1, Me.barButtonGroup3, Me.changeFontColorItem1, Me.changeFontBackColorItem1, Me.changeTextCaseItem1, Me.makeTextUpperCaseItem1, Me.makeTextLowerCaseItem1, Me.toggleTextCaseItem1, Me.clearFormattingItem1, Me.barButtonGroup4, Me.toggleBulletedListItem1, Me.toggleNumberingListItem1, Me.toggleMultiLevelListItem1, Me.barButtonGroup5, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.barButtonGroup6, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.toggleParagraphAlignmentJustifyItem1, Me.toggleShowWhitespaceItem1, Me.barButtonGroup7, Me.changeParagraphLineSpacingItem1, Me.setSingleParagraphSpacingItem1, Me.setSesquialteralParagraphSpacingItem1, Me.setDoubleParagraphSpacingItem1, Me.showLineSpacingFormItem1, Me.addSpacingBeforeParagraphItem1, Me.removeSpacingBeforeParagraphItem1, Me.addSpacingAfterParagraphItem1, Me.removeSpacingAfterParagraphItem1, Me.changeParagraphBackColorItem1, Me.changeStyleItem1, Me.findItem1, Me.replaceItem1, Me.insertPageBreakItem1, Me.insertTableItem1, Me.insertPictureItem1, Me.insertFloatingPictureItem1, Me.insertBookmarkItem1, Me.insertHyperlinkItem1, Me.editPageHeaderItem1, Me.editPageFooterItem1, Me.insertPageNumberItem1, Me.insertPageCountItem1, Me.insertTextBoxItem1, Me.insertSymbolItem1, Me.changeTableCellsShadingItem1, Me.changeTableBordersItem1, Me.toggleTableCellsBottomBorderItem1, Me.toggleTableCellsTopBorderItem1, Me.toggleTableCellsLeftBorderItem1, Me.toggleTableCellsRightBorderItem1, Me.resetTableCellsAllBordersItem1, Me.toggleTableCellsAllBordersItem1, Me.toggleTableCellsOutsideBorderItem1, Me.toggleTableCellsInsideBorderItem1, Me.toggleTableCellsInsideHorizontalBorderItem1, Me.toggleTableCellsInsideVerticalBorderItem1, Me.toggleShowTableGridLinesItem1, Me.changeTableBorderLineStyleItem1, Me.changeTableBorderLineWeightItem1, Me.changeTableBorderColorItem1, Me.selectTableElementsItem1, Me.selectTableCellItem1, Me.selectTableColumnItem1, Me.selectTableRowItem1, Me.selectTableItem1, Me.showTablePropertiesFormItem1, Me.deleteTableElementsItem1, Me.showDeleteTableCellsFormItem1, Me.deleteTableColumnsItem1, Me.deleteTableRowsItem1, Me.deleteTableItem1, Me.insertTableRowAboveItem1, Me.insertTableRowBelowItem1, Me.insertTableColumnToLeftItem1, Me.insertTableColumnToRightItem1, Me.mergeTableCellsItem1, Me.showSplitTableCellsForm1, Me.splitTableItem1, Me.toggleTableAutoFitItem1, Me.toggleTableAutoFitContentsItem1, Me.toggleTableAutoFitWindowItem1, Me.toggleTableFixedColumnWidthItem1, Me.toggleTableCellsTopLeftAlignmentItem1, Me.toggleTableCellsMiddleLeftAlignmentItem1, Me.toggleTableCellsBottomLeftAlignmentItem1, Me.toggleTableCellsTopCenterAlignmentItem1, Me.toggleTableCellsMiddleCenterAlignmentItem1, Me.toggleTableCellsBottomCenterAlignmentItem1, Me.toggleTableCellsTopRightAlignmentItem1, Me.toggleTableCellsMiddleRightAlignmentItem1, Me.toggleTableCellsBottomRightAlignmentItem1, Me.changeFloatingObjectFillColorItem1, Me.changeFloatingObjectOutlineColorItem1, Me.changeFloatingObjectOutlineWeightItem1, Me.changeFloatingObjectTextWrapTypeItem1, Me.setFloatingObjectSquareTextWrapTypeItem1, Me.setFloatingObjectTightTextWrapTypeItem1, Me.setFloatingObjectThroughTextWrapTypeItem1, Me.setFloatingObjectTopAndBottomTextWrapTypeItem1, Me.setFloatingObjectBehindTextWrapTypeItem1, Me.setFloatingObjectInFrontOfTextWrapTypeItem1, Me.changeFloatingObjectAlignmentItem1, Me.setFloatingObjectTopLeftAlignmentItem1, Me.setFloatingObjectTopCenterAlignmentItem1, Me.setFloatingObjectTopRightAlignmentItem1, Me.setFloatingObjectMiddleLeftAlignmentItem1, Me.setFloatingObjectMiddleCenterAlignmentItem1, Me.setFloatingObjectMiddleRightAlignmentItem1, Me.setFloatingObjectBottomLeftAlignmentItem1, Me.setFloatingObjectBottomCenterAlignmentItem1, Me.setFloatingObjectBottomRightAlignmentItem1, Me.floatingObjectBringForwardSubItem1, Me.floatingObjectBringForwardItem1, Me.floatingObjectBringToFrontItem1, Me.floatingObjectBringInFrontOfTextItem1, Me.floatingObjectSendBackwardSubItem1, Me.floatingObjectSendBackwardItem1, Me.floatingObjectSendToBackItem1, Me.floatingObjectSendBehindTextItem1, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.undoItem1, Me.redoItem1})
            Me.ribbonControl1.MaxItemId = 150
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() { Me.tableToolsRibbonPageCategory1, Me.floatingPictureToolsRibbonPageCategory1})
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.homeRibbonPage1, Me.insertRibbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1, Me.repositoryItemRichEditStyleEdit1, Me.repositoryItemBorderLineStyle1, Me.repositoryItemBorderLineWeight1, Me.repositoryItemFloatingObjectOutlineWeight1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
            Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False
            Me.ribbonControl1.Toolbar.ItemLinks.Add(Me.findItem1)
            Me.ribbonControl1.Toolbar.ItemLinks.Add(Me.undoItem1)
            Me.ribbonControl1.Toolbar.ItemLinks.Add(Me.redoItem1)
            ' 
            ' pasteItem1
            ' 
            resources.ApplyResources(Me.pasteItem1, "pasteItem1")
            Me.pasteItem1.Id = 8
            Me.pasteItem1.Name = "pasteItem1"
            ' 
            ' cutItem1
            ' 
            resources.ApplyResources(Me.cutItem1, "cutItem1")
            Me.cutItem1.Id = 9
            Me.cutItem1.Name = "cutItem1"
            ' 
            ' copyItem1
            ' 
            resources.ApplyResources(Me.copyItem1, "copyItem1")
            Me.copyItem1.Id = 10
            Me.copyItem1.Name = "copyItem1"
            ' 
            ' pasteSpecialItem1
            ' 
            resources.ApplyResources(Me.pasteSpecialItem1, "pasteSpecialItem1")
            Me.pasteSpecialItem1.Id = 11
            Me.pasteSpecialItem1.Name = "pasteSpecialItem1"
            ' 
            ' barButtonGroup1
            ' 
            resources.ApplyResources(Me.barButtonGroup1, "barButtonGroup1")
            Me.barButtonGroup1.Id = 1
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontNameItem1)
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontSizeItem1)
            Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeIncreaseItem1)
            Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeDecreaseItem1)
            Me.barButtonGroup1.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (DirectCast(resources.GetObject("barButtonGroup1.MenuAppearance.HeaderItemAppearance.FontSizeDelta"), Integer))
            Me.barButtonGroup1.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (DirectCast(resources.GetObject("barButtonGroup1.MenuAppearance.HeaderItemAppearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.barButtonGroup1.MenuAppearance.HeaderItemAppearance.GradientMode = (DirectCast(resources.GetObject("barButtonGroup1.MenuAppearance.HeaderItemAppearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.barButtonGroup1.MenuAppearance.HeaderItemAppearance.Image = (DirectCast(resources.GetObject("barButtonGroup1.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.barButtonGroup1.Name = "barButtonGroup1"
            Me.barButtonGroup1.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}"
            ' 
            ' changeFontNameItem1
            ' 
            resources.ApplyResources(Me.changeFontNameItem1, "changeFontNameItem1")
            Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
            Me.changeFontNameItem1.Id = 12
            Me.changeFontNameItem1.Name = "changeFontNameItem1"
            ' 
            ' repositoryItemFontEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemFontEdit1, "repositoryItemFontEdit1")
            Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemFontEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
            ' 
            ' changeFontSizeItem1
            ' 
            resources.ApplyResources(Me.changeFontSizeItem1, "changeFontSizeItem1")
            Me.changeFontSizeItem1.Edit = Me.repositoryItemRichEditFontSizeEdit1
            Me.changeFontSizeItem1.Id = 13
            Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
            ' 
            ' repositoryItemRichEditFontSizeEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemRichEditFontSizeEdit1, "repositoryItemRichEditFontSizeEdit1")
            Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemRichEditFontSizeEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemRichEditFontSizeEdit1.Control = Me.richEditControl1
            Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
            ' 
            ' richEditControl1
            ' 
            resources.ApplyResources(Me.richEditControl1, "richEditControl1")
            Me.richEditControl1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple
            Me.richEditControl1.EnableToolTips = True
            Me.richEditControl1.MenuManager = Me.ribbonControl1
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Options.Export.PlainText.ExportFinalParagraphMark = DevExpress.XtraRichEdit.Export.PlainText.ExportFinalParagraphMark.Never
            ' 
            ' fontSizeIncreaseItem1
            ' 
            resources.ApplyResources(Me.fontSizeIncreaseItem1, "fontSizeIncreaseItem1")
            Me.fontSizeIncreaseItem1.Id = 14
            Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
            ' 
            ' fontSizeDecreaseItem1
            ' 
            resources.ApplyResources(Me.fontSizeDecreaseItem1, "fontSizeDecreaseItem1")
            Me.fontSizeDecreaseItem1.Id = 15
            Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
            ' 
            ' barButtonGroup2
            ' 
            resources.ApplyResources(Me.barButtonGroup2, "barButtonGroup2")
            Me.barButtonGroup2.Id = 2
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontBoldItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontItalicItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontUnderlineItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontDoubleUnderlineItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontStrikeoutItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontDoubleStrikeoutItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontSuperscriptItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontSubscriptItem1)
            Me.barButtonGroup2.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (DirectCast(resources.GetObject("barButtonGroup2.MenuAppearance.HeaderItemAppearance.FontSizeDelta"), Integer))
            Me.barButtonGroup2.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (DirectCast(resources.GetObject("barButtonGroup2.MenuAppearance.HeaderItemAppearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.barButtonGroup2.MenuAppearance.HeaderItemAppearance.GradientMode = (DirectCast(resources.GetObject("barButtonGroup2.MenuAppearance.HeaderItemAppearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.barButtonGroup2.MenuAppearance.HeaderItemAppearance.Image = (DirectCast(resources.GetObject("barButtonGroup2.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.barButtonGroup2.Name = "barButtonGroup2"
            Me.barButtonGroup2.Tag = "{433DA7F0-03E2-4650-9DB5-66DD92D16E39}"
            ' 
            ' toggleFontBoldItem1
            ' 
            resources.ApplyResources(Me.toggleFontBoldItem1, "toggleFontBoldItem1")
            Me.toggleFontBoldItem1.Id = 16
            Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
            ' 
            ' toggleFontItalicItem1
            ' 
            resources.ApplyResources(Me.toggleFontItalicItem1, "toggleFontItalicItem1")
            Me.toggleFontItalicItem1.Id = 17
            Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
            ' 
            ' toggleFontUnderlineItem1
            ' 
            resources.ApplyResources(Me.toggleFontUnderlineItem1, "toggleFontUnderlineItem1")
            Me.toggleFontUnderlineItem1.Id = 18
            Me.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
            ' 
            ' toggleFontDoubleUnderlineItem1
            ' 
            resources.ApplyResources(Me.toggleFontDoubleUnderlineItem1, "toggleFontDoubleUnderlineItem1")
            Me.toggleFontDoubleUnderlineItem1.Id = 19
            Me.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
            ' 
            ' toggleFontStrikeoutItem1
            ' 
            resources.ApplyResources(Me.toggleFontStrikeoutItem1, "toggleFontStrikeoutItem1")
            Me.toggleFontStrikeoutItem1.Id = 20
            Me.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
            ' 
            ' toggleFontDoubleStrikeoutItem1
            ' 
            resources.ApplyResources(Me.toggleFontDoubleStrikeoutItem1, "toggleFontDoubleStrikeoutItem1")
            Me.toggleFontDoubleStrikeoutItem1.Id = 21
            Me.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
            ' 
            ' toggleFontSuperscriptItem1
            ' 
            resources.ApplyResources(Me.toggleFontSuperscriptItem1, "toggleFontSuperscriptItem1")
            Me.toggleFontSuperscriptItem1.Id = 22
            Me.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
            ' 
            ' toggleFontSubscriptItem1
            ' 
            resources.ApplyResources(Me.toggleFontSubscriptItem1, "toggleFontSubscriptItem1")
            Me.toggleFontSubscriptItem1.Id = 23
            Me.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
            ' 
            ' barButtonGroup3
            ' 
            resources.ApplyResources(Me.barButtonGroup3, "barButtonGroup3")
            Me.barButtonGroup3.Id = 3
            Me.barButtonGroup3.ItemLinks.Add(Me.changeFontColorItem1)
            Me.barButtonGroup3.ItemLinks.Add(Me.changeFontBackColorItem1)
            Me.barButtonGroup3.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (DirectCast(resources.GetObject("barButtonGroup3.MenuAppearance.HeaderItemAppearance.FontSizeDelta"), Integer))
            Me.barButtonGroup3.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (DirectCast(resources.GetObject("barButtonGroup3.MenuAppearance.HeaderItemAppearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.barButtonGroup3.MenuAppearance.HeaderItemAppearance.GradientMode = (DirectCast(resources.GetObject("barButtonGroup3.MenuAppearance.HeaderItemAppearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.barButtonGroup3.MenuAppearance.HeaderItemAppearance.Image = (DirectCast(resources.GetObject("barButtonGroup3.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.barButtonGroup3.Name = "barButtonGroup3"
            Me.barButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}"
            ' 
            ' changeFontColorItem1
            ' 
            resources.ApplyResources(Me.changeFontColorItem1, "changeFontColorItem1")
            Me.changeFontColorItem1.Id = 24
            Me.changeFontColorItem1.Name = "changeFontColorItem1"
            ' 
            ' changeFontBackColorItem1
            ' 
            resources.ApplyResources(Me.changeFontBackColorItem1, "changeFontBackColorItem1")
            Me.changeFontBackColorItem1.Id = 25
            Me.changeFontBackColorItem1.Name = "changeFontBackColorItem1"
            ' 
            ' changeTextCaseItem1
            ' 
            resources.ApplyResources(Me.changeTextCaseItem1, "changeTextCaseItem1")
            Me.changeTextCaseItem1.Id = 26
            Me.changeTextCaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextUpperCaseItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextLowerCaseItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTextCaseItem1)
            })
            Me.changeTextCaseItem1.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (DirectCast(resources.GetObject("changeTextCaseItem1.MenuAppearance.HeaderItemAppearance.FontSizeDelta"), Integer))
            Me.changeTextCaseItem1.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (DirectCast(resources.GetObject("changeTextCaseItem1.MenuAppearance.HeaderItemAppearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.changeTextCaseItem1.MenuAppearance.HeaderItemAppearance.GradientMode = (DirectCast(resources.GetObject("changeTextCaseItem1.MenuAppearance.HeaderItemAppearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.changeTextCaseItem1.MenuAppearance.HeaderItemAppearance.Image = (DirectCast(resources.GetObject("changeTextCaseItem1.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.changeTextCaseItem1.Name = "changeTextCaseItem1"
            ' 
            ' makeTextUpperCaseItem1
            ' 
            resources.ApplyResources(Me.makeTextUpperCaseItem1, "makeTextUpperCaseItem1")
            Me.makeTextUpperCaseItem1.Id = 27
            Me.makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1"
            ' 
            ' makeTextLowerCaseItem1
            ' 
            resources.ApplyResources(Me.makeTextLowerCaseItem1, "makeTextLowerCaseItem1")
            Me.makeTextLowerCaseItem1.Id = 28
            Me.makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1"
            ' 
            ' toggleTextCaseItem1
            ' 
            resources.ApplyResources(Me.toggleTextCaseItem1, "toggleTextCaseItem1")
            Me.toggleTextCaseItem1.Id = 29
            Me.toggleTextCaseItem1.Name = "toggleTextCaseItem1"
            ' 
            ' clearFormattingItem1
            ' 
            resources.ApplyResources(Me.clearFormattingItem1, "clearFormattingItem1")
            Me.clearFormattingItem1.Id = 30
            Me.clearFormattingItem1.Name = "clearFormattingItem1"
            ' 
            ' barButtonGroup4
            ' 
            resources.ApplyResources(Me.barButtonGroup4, "barButtonGroup4")
            Me.barButtonGroup4.Id = 4
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleBulletedListItem1)
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleNumberingListItem1)
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleMultiLevelListItem1)
            Me.barButtonGroup4.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (DirectCast(resources.GetObject("barButtonGroup4.MenuAppearance.HeaderItemAppearance.FontSizeDelta"), Integer))
            Me.barButtonGroup4.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (DirectCast(resources.GetObject("barButtonGroup4.MenuAppearance.HeaderItemAppearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.barButtonGroup4.MenuAppearance.HeaderItemAppearance.GradientMode = (DirectCast(resources.GetObject("barButtonGroup4.MenuAppearance.HeaderItemAppearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.barButtonGroup4.MenuAppearance.HeaderItemAppearance.Image = (DirectCast(resources.GetObject("barButtonGroup4.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.barButtonGroup4.Name = "barButtonGroup4"
            Me.barButtonGroup4.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
            ' 
            ' toggleBulletedListItem1
            ' 
            resources.ApplyResources(Me.toggleBulletedListItem1, "toggleBulletedListItem1")
            Me.toggleBulletedListItem1.Id = 31
            Me.toggleBulletedListItem1.Name = "toggleBulletedListItem1"
            ' 
            ' toggleNumberingListItem1
            ' 
            resources.ApplyResources(Me.toggleNumberingListItem1, "toggleNumberingListItem1")
            Me.toggleNumberingListItem1.Id = 32
            Me.toggleNumberingListItem1.Name = "toggleNumberingListItem1"
            ' 
            ' toggleMultiLevelListItem1
            ' 
            resources.ApplyResources(Me.toggleMultiLevelListItem1, "toggleMultiLevelListItem1")
            Me.toggleMultiLevelListItem1.Id = 33
            Me.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
            ' 
            ' barButtonGroup5
            ' 
            resources.ApplyResources(Me.barButtonGroup5, "barButtonGroup5")
            Me.barButtonGroup5.Id = 5
            Me.barButtonGroup5.ItemLinks.Add(Me.decreaseIndentItem1)
            Me.barButtonGroup5.ItemLinks.Add(Me.increaseIndentItem1)
            Me.barButtonGroup5.ItemLinks.Add(Me.toggleShowWhitespaceItem1)
            Me.barButtonGroup5.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (DirectCast(resources.GetObject("barButtonGroup5.MenuAppearance.HeaderItemAppearance.FontSizeDelta"), Integer))
            Me.barButtonGroup5.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (DirectCast(resources.GetObject("barButtonGroup5.MenuAppearance.HeaderItemAppearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.barButtonGroup5.MenuAppearance.HeaderItemAppearance.GradientMode = (DirectCast(resources.GetObject("barButtonGroup5.MenuAppearance.HeaderItemAppearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.barButtonGroup5.MenuAppearance.HeaderItemAppearance.Image = (DirectCast(resources.GetObject("barButtonGroup5.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.barButtonGroup5.Name = "barButtonGroup5"
            Me.barButtonGroup5.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}"
            ' 
            ' decreaseIndentItem1
            ' 
            resources.ApplyResources(Me.decreaseIndentItem1, "decreaseIndentItem1")
            Me.decreaseIndentItem1.Id = 34
            Me.decreaseIndentItem1.Name = "decreaseIndentItem1"
            ' 
            ' increaseIndentItem1
            ' 
            resources.ApplyResources(Me.increaseIndentItem1, "increaseIndentItem1")
            Me.increaseIndentItem1.Id = 35
            Me.increaseIndentItem1.Name = "increaseIndentItem1"
            ' 
            ' toggleShowWhitespaceItem1
            ' 
            resources.ApplyResources(Me.toggleShowWhitespaceItem1, "toggleShowWhitespaceItem1")
            Me.toggleShowWhitespaceItem1.Id = 36
            Me.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
            ' 
            ' barButtonGroup6
            ' 
            resources.ApplyResources(Me.barButtonGroup6, "barButtonGroup6")
            Me.barButtonGroup6.Id = 6
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentLeftItem1)
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentCenterItem1)
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentRightItem1)
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentJustifyItem1)
            Me.barButtonGroup6.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (DirectCast(resources.GetObject("barButtonGroup6.MenuAppearance.HeaderItemAppearance.FontSizeDelta"), Integer))
            Me.barButtonGroup6.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (DirectCast(resources.GetObject("barButtonGroup6.MenuAppearance.HeaderItemAppearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.barButtonGroup6.MenuAppearance.HeaderItemAppearance.GradientMode = (DirectCast(resources.GetObject("barButtonGroup6.MenuAppearance.HeaderItemAppearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.barButtonGroup6.MenuAppearance.HeaderItemAppearance.Image = (DirectCast(resources.GetObject("barButtonGroup6.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.barButtonGroup6.Name = "barButtonGroup6"
            Me.barButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}"
            ' 
            ' toggleParagraphAlignmentLeftItem1
            ' 
            resources.ApplyResources(Me.toggleParagraphAlignmentLeftItem1, "toggleParagraphAlignmentLeftItem1")
            Me.toggleParagraphAlignmentLeftItem1.Id = 37
            Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
            ' 
            ' toggleParagraphAlignmentCenterItem1
            ' 
            resources.ApplyResources(Me.toggleParagraphAlignmentCenterItem1, "toggleParagraphAlignmentCenterItem1")
            Me.toggleParagraphAlignmentCenterItem1.Id = 38
            Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
            ' 
            ' toggleParagraphAlignmentRightItem1
            ' 
            resources.ApplyResources(Me.toggleParagraphAlignmentRightItem1, "toggleParagraphAlignmentRightItem1")
            Me.toggleParagraphAlignmentRightItem1.Id = 39
            Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
            ' 
            ' toggleParagraphAlignmentJustifyItem1
            ' 
            resources.ApplyResources(Me.toggleParagraphAlignmentJustifyItem1, "toggleParagraphAlignmentJustifyItem1")
            Me.toggleParagraphAlignmentJustifyItem1.Id = 40
            Me.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
            ' 
            ' barButtonGroup7
            ' 
            resources.ApplyResources(Me.barButtonGroup7, "barButtonGroup7")
            Me.barButtonGroup7.Id = 7
            Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphLineSpacingItem1)
            Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphBackColorItem1)
            Me.barButtonGroup7.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (DirectCast(resources.GetObject("barButtonGroup7.MenuAppearance.HeaderItemAppearance.FontSizeDelta"), Integer))
            Me.barButtonGroup7.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (DirectCast(resources.GetObject("barButtonGroup7.MenuAppearance.HeaderItemAppearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.barButtonGroup7.MenuAppearance.HeaderItemAppearance.GradientMode = (DirectCast(resources.GetObject("barButtonGroup7.MenuAppearance.HeaderItemAppearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.barButtonGroup7.MenuAppearance.HeaderItemAppearance.Image = (DirectCast(resources.GetObject("barButtonGroup7.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.barButtonGroup7.Name = "barButtonGroup7"
            Me.barButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}"
            ' 
            ' changeParagraphLineSpacingItem1
            ' 
            resources.ApplyResources(Me.changeParagraphLineSpacingItem1, "changeParagraphLineSpacingItem1")
            Me.changeParagraphLineSpacingItem1.Id = 41
            Me.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSingleParagraphSpacingItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSesquialteralParagraphSpacingItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setDoubleParagraphSpacingItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.showLineSpacingFormItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingBeforeParagraphItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingBeforeParagraphItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingAfterParagraphItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingAfterParagraphItem1)
            })
            Me.changeParagraphLineSpacingItem1.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (DirectCast(resources.GetObject("changeParagraphLineSpacingItem1.MenuAppearance.HeaderItemAppearance.FontSizeDelta" & ""), Integer))
            Me.changeParagraphLineSpacingItem1.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (DirectCast(resources.GetObject("changeParagraphLineSpacingItem1.MenuAppearance.HeaderItemAppearance.FontStyleDelt" & "a"), System.Drawing.FontStyle))
            Me.changeParagraphLineSpacingItem1.MenuAppearance.HeaderItemAppearance.GradientMode = (DirectCast(resources.GetObject("changeParagraphLineSpacingItem1.MenuAppearance.HeaderItemAppearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.changeParagraphLineSpacingItem1.MenuAppearance.HeaderItemAppearance.Image = (DirectCast(resources.GetObject("changeParagraphLineSpacingItem1.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1"
            ' 
            ' setSingleParagraphSpacingItem1
            ' 
            resources.ApplyResources(Me.setSingleParagraphSpacingItem1, "setSingleParagraphSpacingItem1")
            Me.setSingleParagraphSpacingItem1.Id = 42
            Me.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1"
            ' 
            ' setSesquialteralParagraphSpacingItem1
            ' 
            resources.ApplyResources(Me.setSesquialteralParagraphSpacingItem1, "setSesquialteralParagraphSpacingItem1")
            Me.setSesquialteralParagraphSpacingItem1.Id = 43
            Me.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1"
            ' 
            ' setDoubleParagraphSpacingItem1
            ' 
            resources.ApplyResources(Me.setDoubleParagraphSpacingItem1, "setDoubleParagraphSpacingItem1")
            Me.setDoubleParagraphSpacingItem1.Id = 44
            Me.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1"
            ' 
            ' showLineSpacingFormItem1
            ' 
            resources.ApplyResources(Me.showLineSpacingFormItem1, "showLineSpacingFormItem1")
            Me.showLineSpacingFormItem1.Id = 45
            Me.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1"
            ' 
            ' addSpacingBeforeParagraphItem1
            ' 
            resources.ApplyResources(Me.addSpacingBeforeParagraphItem1, "addSpacingBeforeParagraphItem1")
            Me.addSpacingBeforeParagraphItem1.Id = 46
            Me.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1"
            ' 
            ' removeSpacingBeforeParagraphItem1
            ' 
            resources.ApplyResources(Me.removeSpacingBeforeParagraphItem1, "removeSpacingBeforeParagraphItem1")
            Me.removeSpacingBeforeParagraphItem1.Id = 47
            Me.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1"
            ' 
            ' addSpacingAfterParagraphItem1
            ' 
            resources.ApplyResources(Me.addSpacingAfterParagraphItem1, "addSpacingAfterParagraphItem1")
            Me.addSpacingAfterParagraphItem1.Id = 48
            Me.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1"
            ' 
            ' removeSpacingAfterParagraphItem1
            ' 
            resources.ApplyResources(Me.removeSpacingAfterParagraphItem1, "removeSpacingAfterParagraphItem1")
            Me.removeSpacingAfterParagraphItem1.Id = 49
            Me.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1"
            ' 
            ' changeParagraphBackColorItem1
            ' 
            resources.ApplyResources(Me.changeParagraphBackColorItem1, "changeParagraphBackColorItem1")
            Me.changeParagraphBackColorItem1.Id = 50
            Me.changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1"
            ' 
            ' changeStyleItem1
            ' 
            resources.ApplyResources(Me.changeStyleItem1, "changeStyleItem1")
            Me.changeStyleItem1.Edit = Me.repositoryItemRichEditStyleEdit1
            Me.changeStyleItem1.Id = 51
            Me.changeStyleItem1.Name = "changeStyleItem1"
            ' 
            ' repositoryItemRichEditStyleEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemRichEditStyleEdit1, "repositoryItemRichEditStyleEdit1")
            Me.repositoryItemRichEditStyleEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemRichEditStyleEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemRichEditStyleEdit1.Control = Me.richEditControl1
            Me.repositoryItemRichEditStyleEdit1.Name = "repositoryItemRichEditStyleEdit1"
            ' 
            ' findItem1
            ' 
            resources.ApplyResources(Me.findItem1, "findItem1")
            Me.findItem1.Id = 52
            Me.findItem1.Name = "findItem1"
            ' 
            ' replaceItem1
            ' 
            resources.ApplyResources(Me.replaceItem1, "replaceItem1")
            Me.replaceItem1.Id = 53
            Me.replaceItem1.Name = "replaceItem1"
            ' 
            ' insertPageBreakItem1
            ' 
            resources.ApplyResources(Me.insertPageBreakItem1, "insertPageBreakItem1")
            Me.insertPageBreakItem1.Id = 54
            Me.insertPageBreakItem1.Name = "insertPageBreakItem1"
            ' 
            ' insertTableItem1
            ' 
            resources.ApplyResources(Me.insertTableItem1, "insertTableItem1")
            Me.insertTableItem1.Id = 55
            Me.insertTableItem1.Name = "insertTableItem1"
            ' 
            ' insertPictureItem1
            ' 
            resources.ApplyResources(Me.insertPictureItem1, "insertPictureItem1")
            Me.insertPictureItem1.Id = 56
            Me.insertPictureItem1.Name = "insertPictureItem1"
            ' 
            ' insertFloatingPictureItem1
            ' 
            resources.ApplyResources(Me.insertFloatingPictureItem1, "insertFloatingPictureItem1")
            Me.insertFloatingPictureItem1.Id = 57
            Me.insertFloatingPictureItem1.Name = "insertFloatingPictureItem1"
            ' 
            ' insertBookmarkItem1
            ' 
            resources.ApplyResources(Me.insertBookmarkItem1, "insertBookmarkItem1")
            Me.insertBookmarkItem1.Id = 58
            Me.insertBookmarkItem1.Name = "insertBookmarkItem1"
            ' 
            ' insertHyperlinkItem1
            ' 
            resources.ApplyResources(Me.insertHyperlinkItem1, "insertHyperlinkItem1")
            Me.insertHyperlinkItem1.Id = 59
            Me.insertHyperlinkItem1.Name = "insertHyperlinkItem1"
            ' 
            ' editPageHeaderItem1
            ' 
            resources.ApplyResources(Me.editPageHeaderItem1, "editPageHeaderItem1")
            Me.editPageHeaderItem1.Id = 60
            Me.editPageHeaderItem1.Name = "editPageHeaderItem1"
            ' 
            ' editPageFooterItem1
            ' 
            resources.ApplyResources(Me.editPageFooterItem1, "editPageFooterItem1")
            Me.editPageFooterItem1.Id = 61
            Me.editPageFooterItem1.Name = "editPageFooterItem1"
            ' 
            ' insertPageNumberItem1
            ' 
            resources.ApplyResources(Me.insertPageNumberItem1, "insertPageNumberItem1")
            Me.insertPageNumberItem1.Id = 62
            Me.insertPageNumberItem1.Name = "insertPageNumberItem1"
            ' 
            ' insertPageCountItem1
            ' 
            resources.ApplyResources(Me.insertPageCountItem1, "insertPageCountItem1")
            Me.insertPageCountItem1.Id = 63
            Me.insertPageCountItem1.Name = "insertPageCountItem1"
            ' 
            ' insertTextBoxItem1
            ' 
            resources.ApplyResources(Me.insertTextBoxItem1, "insertTextBoxItem1")
            Me.insertTextBoxItem1.Id = 64
            Me.insertTextBoxItem1.Name = "insertTextBoxItem1"
            ' 
            ' insertSymbolItem1
            ' 
            resources.ApplyResources(Me.insertSymbolItem1, "insertSymbolItem1")
            Me.insertSymbolItem1.Id = 65
            Me.insertSymbolItem1.Name = "insertSymbolItem1"
            ' 
            ' changeTableCellsShadingItem1
            ' 
            resources.ApplyResources(Me.changeTableCellsShadingItem1, "changeTableCellsShadingItem1")
            Me.changeTableCellsShadingItem1.Id = 66
            Me.changeTableCellsShadingItem1.Name = "changeTableCellsShadingItem1"
            ' 
            ' changeTableBordersItem1
            ' 
            resources.ApplyResources(Me.changeTableBordersItem1, "changeTableBordersItem1")
            Me.changeTableBordersItem1.Id = 67
            Me.changeTableBordersItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsBottomBorderItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsTopBorderItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsLeftBorderItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsRightBorderItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.resetTableCellsAllBordersItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsAllBordersItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsOutsideBorderItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideBorderItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideHorizontalBorderItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideVerticalBorderItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleShowTableGridLinesItem1)
            })
            Me.changeTableBordersItem1.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (DirectCast(resources.GetObject("changeTableBordersItem1.MenuAppearance.HeaderItemAppearance.FontSizeDelta"), Integer))
            Me.changeTableBordersItem1.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (DirectCast(resources.GetObject("changeTableBordersItem1.MenuAppearance.HeaderItemAppearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.changeTableBordersItem1.MenuAppearance.HeaderItemAppearance.GradientMode = (DirectCast(resources.GetObject("changeTableBordersItem1.MenuAppearance.HeaderItemAppearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.changeTableBordersItem1.MenuAppearance.HeaderItemAppearance.Image = (DirectCast(resources.GetObject("changeTableBordersItem1.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.changeTableBordersItem1.Name = "changeTableBordersItem1"
            ' 
            ' toggleTableCellsBottomBorderItem1
            ' 
            resources.ApplyResources(Me.toggleTableCellsBottomBorderItem1, "toggleTableCellsBottomBorderItem1")
            Me.toggleTableCellsBottomBorderItem1.Id = 68
            Me.toggleTableCellsBottomBorderItem1.Name = "toggleTableCellsBottomBorderItem1"
            ' 
            ' toggleTableCellsTopBorderItem1
            ' 
            resources.ApplyResources(Me.toggleTableCellsTopBorderItem1, "toggleTableCellsTopBorderItem1")
            Me.toggleTableCellsTopBorderItem1.Id = 69
            Me.toggleTableCellsTopBorderItem1.Name = "toggleTableCellsTopBorderItem1"
            ' 
            ' toggleTableCellsLeftBorderItem1
            ' 
            resources.ApplyResources(Me.toggleTableCellsLeftBorderItem1, "toggleTableCellsLeftBorderItem1")
            Me.toggleTableCellsLeftBorderItem1.Id = 70
            Me.toggleTableCellsLeftBorderItem1.Name = "toggleTableCellsLeftBorderItem1"
            ' 
            ' toggleTableCellsRightBorderItem1
            ' 
            resources.ApplyResources(Me.toggleTableCellsRightBorderItem1, "toggleTableCellsRightBorderItem1")
            Me.toggleTableCellsRightBorderItem1.Id = 71
            Me.toggleTableCellsRightBorderItem1.Name = "toggleTableCellsRightBorderItem1"
            ' 
            ' resetTableCellsAllBordersItem1
            ' 
            resources.ApplyResources(Me.resetTableCellsAllBordersItem1, "resetTableCellsAllBordersItem1")
            Me.resetTableCellsAllBordersItem1.Id = 72
            Me.resetTableCellsAllBordersItem1.Name = "resetTableCellsAllBordersItem1"
            ' 
            ' toggleTableCellsAllBordersItem1
            ' 
            resources.ApplyResources(Me.toggleTableCellsAllBordersItem1, "toggleTableCellsAllBordersItem1")
            Me.toggleTableCellsAllBordersItem1.Id = 73
            Me.toggleTableCellsAllBordersItem1.Name = "toggleTableCellsAllBordersItem1"
            ' 
            ' toggleTableCellsOutsideBorderItem1
            ' 
            resources.ApplyResources(Me.toggleTableCellsOutsideBorderItem1, "toggleTableCellsOutsideBorderItem1")
            Me.toggleTableCellsOutsideBorderItem1.Id = 74
            Me.toggleTableCellsOutsideBorderItem1.Name = "toggleTableCellsOutsideBorderItem1"
            ' 
            ' toggleTableCellsInsideBorderItem1
            ' 
            resources.ApplyResources(Me.toggleTableCellsInsideBorderItem1, "toggleTableCellsInsideBorderItem1")
            Me.toggleTableCellsInsideBorderItem1.Id = 75
            Me.toggleTableCellsInsideBorderItem1.Name = "toggleTableCellsInsideBorderItem1"
            ' 
            ' toggleTableCellsInsideHorizontalBorderItem1
            ' 
            resources.ApplyResources(Me.toggleTableCellsInsideHorizontalBorderItem1, "toggleTableCellsInsideHorizontalBorderItem1")
            Me.toggleTableCellsInsideHorizontalBorderItem1.Id = 76
            Me.toggleTableCellsInsideHorizontalBorderItem1.Name = "toggleTableCellsInsideHorizontalBorderItem1"
            ' 
            ' toggleTableCellsInsideVerticalBorderItem1
            ' 
            resources.ApplyResources(Me.toggleTableCellsInsideVerticalBorderItem1, "toggleTableCellsInsideVerticalBorderItem1")
            Me.toggleTableCellsInsideVerticalBorderItem1.Id = 77
            Me.toggleTableCellsInsideVerticalBorderItem1.Name = "toggleTableCellsInsideVerticalBorderItem1"
            ' 
            ' toggleShowTableGridLinesItem1
            ' 
            resources.ApplyResources(Me.toggleShowTableGridLinesItem1, "toggleShowTableGridLinesItem1")
            Me.toggleShowTableGridLinesItem1.Id = 78
            Me.toggleShowTableGridLinesItem1.Name = "toggleShowTableGridLinesItem1"
            ' 
            ' changeTableBorderLineStyleItem1
            ' 
            resources.ApplyResources(Me.changeTableBorderLineStyleItem1, "changeTableBorderLineStyleItem1")
            Me.changeTableBorderLineStyleItem1.Edit = Me.repositoryItemBorderLineStyle1
            borderInfo1.Frame = False
            borderInfo1.Offset = 0
            borderInfo1.Shadow = False
            borderInfo1.Style = DevExpress.XtraRichEdit.Model.BorderLineStyle.Single
            borderInfo1.Width = 10
            Me.changeTableBorderLineStyleItem1.EditValue = borderInfo1
            Me.changeTableBorderLineStyleItem1.Id = 79
            Me.changeTableBorderLineStyleItem1.Name = "changeTableBorderLineStyleItem1"
            ' 
            ' repositoryItemBorderLineStyle1
            ' 
            resources.ApplyResources(Me.repositoryItemBorderLineStyle1, "repositoryItemBorderLineStyle1")
            Me.repositoryItemBorderLineStyle1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemBorderLineStyle1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemBorderLineStyle1.Control = Me.richEditControl1
            Me.repositoryItemBorderLineStyle1.Name = "repositoryItemBorderLineStyle1"
            ' 
            ' changeTableBorderLineWeightItem1
            ' 
            resources.ApplyResources(Me.changeTableBorderLineWeightItem1, "changeTableBorderLineWeightItem1")
            Me.changeTableBorderLineWeightItem1.Edit = Me.repositoryItemBorderLineWeight1
            Me.changeTableBorderLineWeightItem1.EditValue = 20
            Me.changeTableBorderLineWeightItem1.Id = 80
            Me.changeTableBorderLineWeightItem1.Name = "changeTableBorderLineWeightItem1"
            ' 
            ' repositoryItemBorderLineWeight1
            ' 
            resources.ApplyResources(Me.repositoryItemBorderLineWeight1, "repositoryItemBorderLineWeight1")
            Me.repositoryItemBorderLineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemBorderLineWeight1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemBorderLineWeight1.Control = Me.richEditControl1
            Me.repositoryItemBorderLineWeight1.Name = "repositoryItemBorderLineWeight1"
            ' 
            ' changeTableBorderColorItem1
            ' 
            resources.ApplyResources(Me.changeTableBorderColorItem1, "changeTableBorderColorItem1")
            Me.changeTableBorderColorItem1.Id = 81
            Me.changeTableBorderColorItem1.Name = "changeTableBorderColorItem1"
            ' 
            ' selectTableElementsItem1
            ' 
            resources.ApplyResources(Me.selectTableElementsItem1, "selectTableElementsItem1")
            Me.selectTableElementsItem1.Id = 82
            Me.selectTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableCellItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableColumnItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableRowItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableItem1)
            })
            Me.selectTableElementsItem1.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (DirectCast(resources.GetObject("selectTableElementsItem1.MenuAppearance.HeaderItemAppearance.FontSizeDelta"), Integer))
            Me.selectTableElementsItem1.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (DirectCast(resources.GetObject("selectTableElementsItem1.MenuAppearance.HeaderItemAppearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.selectTableElementsItem1.MenuAppearance.HeaderItemAppearance.GradientMode = (DirectCast(resources.GetObject("selectTableElementsItem1.MenuAppearance.HeaderItemAppearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.selectTableElementsItem1.MenuAppearance.HeaderItemAppearance.Image = (DirectCast(resources.GetObject("selectTableElementsItem1.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.selectTableElementsItem1.Name = "selectTableElementsItem1"
            ' 
            ' selectTableCellItem1
            ' 
            resources.ApplyResources(Me.selectTableCellItem1, "selectTableCellItem1")
            Me.selectTableCellItem1.Id = 83
            Me.selectTableCellItem1.Name = "selectTableCellItem1"
            ' 
            ' selectTableColumnItem1
            ' 
            resources.ApplyResources(Me.selectTableColumnItem1, "selectTableColumnItem1")
            Me.selectTableColumnItem1.Id = 84
            Me.selectTableColumnItem1.Name = "selectTableColumnItem1"
            ' 
            ' selectTableRowItem1
            ' 
            resources.ApplyResources(Me.selectTableRowItem1, "selectTableRowItem1")
            Me.selectTableRowItem1.Id = 85
            Me.selectTableRowItem1.Name = "selectTableRowItem1"
            ' 
            ' selectTableItem1
            ' 
            resources.ApplyResources(Me.selectTableItem1, "selectTableItem1")
            Me.selectTableItem1.Id = 86
            Me.selectTableItem1.Name = "selectTableItem1"
            ' 
            ' showTablePropertiesFormItem1
            ' 
            resources.ApplyResources(Me.showTablePropertiesFormItem1, "showTablePropertiesFormItem1")
            Me.showTablePropertiesFormItem1.Id = 87
            Me.showTablePropertiesFormItem1.Name = "showTablePropertiesFormItem1"
            ' 
            ' deleteTableElementsItem1
            ' 
            resources.ApplyResources(Me.deleteTableElementsItem1, "deleteTableElementsItem1")
            Me.deleteTableElementsItem1.Id = 88
            Me.deleteTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.showDeleteTableCellsFormItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableColumnsItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableRowsItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableItem1)
            })
            Me.deleteTableElementsItem1.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (DirectCast(resources.GetObject("deleteTableElementsItem1.MenuAppearance.HeaderItemAppearance.FontSizeDelta"), Integer))
            Me.deleteTableElementsItem1.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (DirectCast(resources.GetObject("deleteTableElementsItem1.MenuAppearance.HeaderItemAppearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.deleteTableElementsItem1.MenuAppearance.HeaderItemAppearance.GradientMode = (DirectCast(resources.GetObject("deleteTableElementsItem1.MenuAppearance.HeaderItemAppearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.deleteTableElementsItem1.MenuAppearance.HeaderItemAppearance.Image = (DirectCast(resources.GetObject("deleteTableElementsItem1.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.deleteTableElementsItem1.Name = "deleteTableElementsItem1"
            ' 
            ' showDeleteTableCellsFormItem1
            ' 
            resources.ApplyResources(Me.showDeleteTableCellsFormItem1, "showDeleteTableCellsFormItem1")
            Me.showDeleteTableCellsFormItem1.Id = 89
            Me.showDeleteTableCellsFormItem1.Name = "showDeleteTableCellsFormItem1"
            ' 
            ' deleteTableColumnsItem1
            ' 
            resources.ApplyResources(Me.deleteTableColumnsItem1, "deleteTableColumnsItem1")
            Me.deleteTableColumnsItem1.Id = 90
            Me.deleteTableColumnsItem1.Name = "deleteTableColumnsItem1"
            ' 
            ' deleteTableRowsItem1
            ' 
            resources.ApplyResources(Me.deleteTableRowsItem1, "deleteTableRowsItem1")
            Me.deleteTableRowsItem1.Id = 91
            Me.deleteTableRowsItem1.Name = "deleteTableRowsItem1"
            ' 
            ' deleteTableItem1
            ' 
            resources.ApplyResources(Me.deleteTableItem1, "deleteTableItem1")
            Me.deleteTableItem1.Id = 92
            Me.deleteTableItem1.Name = "deleteTableItem1"
            ' 
            ' insertTableRowAboveItem1
            ' 
            resources.ApplyResources(Me.insertTableRowAboveItem1, "insertTableRowAboveItem1")
            Me.insertTableRowAboveItem1.Id = 93
            Me.insertTableRowAboveItem1.Name = "insertTableRowAboveItem1"
            ' 
            ' insertTableRowBelowItem1
            ' 
            resources.ApplyResources(Me.insertTableRowBelowItem1, "insertTableRowBelowItem1")
            Me.insertTableRowBelowItem1.Id = 94
            Me.insertTableRowBelowItem1.Name = "insertTableRowBelowItem1"
            ' 
            ' insertTableColumnToLeftItem1
            ' 
            resources.ApplyResources(Me.insertTableColumnToLeftItem1, "insertTableColumnToLeftItem1")
            Me.insertTableColumnToLeftItem1.Id = 95
            Me.insertTableColumnToLeftItem1.Name = "insertTableColumnToLeftItem1"
            ' 
            ' insertTableColumnToRightItem1
            ' 
            resources.ApplyResources(Me.insertTableColumnToRightItem1, "insertTableColumnToRightItem1")
            Me.insertTableColumnToRightItem1.Id = 96
            Me.insertTableColumnToRightItem1.Name = "insertTableColumnToRightItem1"
            ' 
            ' mergeTableCellsItem1
            ' 
            resources.ApplyResources(Me.mergeTableCellsItem1, "mergeTableCellsItem1")
            Me.mergeTableCellsItem1.Id = 97
            Me.mergeTableCellsItem1.Name = "mergeTableCellsItem1"
            ' 
            ' showSplitTableCellsForm1
            ' 
            resources.ApplyResources(Me.showSplitTableCellsForm1, "showSplitTableCellsForm1")
            Me.showSplitTableCellsForm1.Id = 98
            Me.showSplitTableCellsForm1.Name = "showSplitTableCellsForm1"
            ' 
            ' splitTableItem1
            ' 
            resources.ApplyResources(Me.splitTableItem1, "splitTableItem1")
            Me.splitTableItem1.Id = 99
            Me.splitTableItem1.Name = "splitTableItem1"
            ' 
            ' toggleTableAutoFitItem1
            ' 
            resources.ApplyResources(Me.toggleTableAutoFitItem1, "toggleTableAutoFitItem1")
            Me.toggleTableAutoFitItem1.Id = 100
            Me.toggleTableAutoFitItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableAutoFitContentsItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableAutoFitWindowItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableFixedColumnWidthItem1)
            })
            Me.toggleTableAutoFitItem1.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (DirectCast(resources.GetObject("toggleTableAutoFitItem1.MenuAppearance.HeaderItemAppearance.FontSizeDelta"), Integer))
            Me.toggleTableAutoFitItem1.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (DirectCast(resources.GetObject("toggleTableAutoFitItem1.MenuAppearance.HeaderItemAppearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.toggleTableAutoFitItem1.MenuAppearance.HeaderItemAppearance.GradientMode = (DirectCast(resources.GetObject("toggleTableAutoFitItem1.MenuAppearance.HeaderItemAppearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.toggleTableAutoFitItem1.MenuAppearance.HeaderItemAppearance.Image = (DirectCast(resources.GetObject("toggleTableAutoFitItem1.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.toggleTableAutoFitItem1.Name = "toggleTableAutoFitItem1"
            ' 
            ' toggleTableAutoFitContentsItem1
            ' 
            resources.ApplyResources(Me.toggleTableAutoFitContentsItem1, "toggleTableAutoFitContentsItem1")
            Me.toggleTableAutoFitContentsItem1.Id = 101
            Me.toggleTableAutoFitContentsItem1.Name = "toggleTableAutoFitContentsItem1"
            ' 
            ' toggleTableAutoFitWindowItem1
            ' 
            resources.ApplyResources(Me.toggleTableAutoFitWindowItem1, "toggleTableAutoFitWindowItem1")
            Me.toggleTableAutoFitWindowItem1.Id = 102
            Me.toggleTableAutoFitWindowItem1.Name = "toggleTableAutoFitWindowItem1"
            ' 
            ' toggleTableFixedColumnWidthItem1
            ' 
            resources.ApplyResources(Me.toggleTableFixedColumnWidthItem1, "toggleTableFixedColumnWidthItem1")
            Me.toggleTableFixedColumnWidthItem1.Id = 103
            Me.toggleTableFixedColumnWidthItem1.Name = "toggleTableFixedColumnWidthItem1"
            ' 
            ' toggleTableCellsTopLeftAlignmentItem1
            ' 
            resources.ApplyResources(Me.toggleTableCellsTopLeftAlignmentItem1, "toggleTableCellsTopLeftAlignmentItem1")
            Me.toggleTableCellsTopLeftAlignmentItem1.Id = 104
            Me.toggleTableCellsTopLeftAlignmentItem1.Name = "toggleTableCellsTopLeftAlignmentItem1"
            ' 
            ' toggleTableCellsMiddleLeftAlignmentItem1
            ' 
            resources.ApplyResources(Me.toggleTableCellsMiddleLeftAlignmentItem1, "toggleTableCellsMiddleLeftAlignmentItem1")
            Me.toggleTableCellsMiddleLeftAlignmentItem1.Id = 105
            Me.toggleTableCellsMiddleLeftAlignmentItem1.Name = "toggleTableCellsMiddleLeftAlignmentItem1"
            ' 
            ' toggleTableCellsBottomLeftAlignmentItem1
            ' 
            resources.ApplyResources(Me.toggleTableCellsBottomLeftAlignmentItem1, "toggleTableCellsBottomLeftAlignmentItem1")
            Me.toggleTableCellsBottomLeftAlignmentItem1.Id = 106
            Me.toggleTableCellsBottomLeftAlignmentItem1.Name = "toggleTableCellsBottomLeftAlignmentItem1"
            ' 
            ' toggleTableCellsTopCenterAlignmentItem1
            ' 
            resources.ApplyResources(Me.toggleTableCellsTopCenterAlignmentItem1, "toggleTableCellsTopCenterAlignmentItem1")
            Me.toggleTableCellsTopCenterAlignmentItem1.Id = 107
            Me.toggleTableCellsTopCenterAlignmentItem1.Name = "toggleTableCellsTopCenterAlignmentItem1"
            ' 
            ' toggleTableCellsMiddleCenterAlignmentItem1
            ' 
            resources.ApplyResources(Me.toggleTableCellsMiddleCenterAlignmentItem1, "toggleTableCellsMiddleCenterAlignmentItem1")
            Me.toggleTableCellsMiddleCenterAlignmentItem1.Id = 108
            Me.toggleTableCellsMiddleCenterAlignmentItem1.Name = "toggleTableCellsMiddleCenterAlignmentItem1"
            ' 
            ' toggleTableCellsBottomCenterAlignmentItem1
            ' 
            resources.ApplyResources(Me.toggleTableCellsBottomCenterAlignmentItem1, "toggleTableCellsBottomCenterAlignmentItem1")
            Me.toggleTableCellsBottomCenterAlignmentItem1.Id = 109
            Me.toggleTableCellsBottomCenterAlignmentItem1.Name = "toggleTableCellsBottomCenterAlignmentItem1"
            ' 
            ' toggleTableCellsTopRightAlignmentItem1
            ' 
            resources.ApplyResources(Me.toggleTableCellsTopRightAlignmentItem1, "toggleTableCellsTopRightAlignmentItem1")
            Me.toggleTableCellsTopRightAlignmentItem1.Id = 110
            Me.toggleTableCellsTopRightAlignmentItem1.Name = "toggleTableCellsTopRightAlignmentItem1"
            ' 
            ' toggleTableCellsMiddleRightAlignmentItem1
            ' 
            resources.ApplyResources(Me.toggleTableCellsMiddleRightAlignmentItem1, "toggleTableCellsMiddleRightAlignmentItem1")
            Me.toggleTableCellsMiddleRightAlignmentItem1.Id = 111
            Me.toggleTableCellsMiddleRightAlignmentItem1.Name = "toggleTableCellsMiddleRightAlignmentItem1"
            ' 
            ' toggleTableCellsBottomRightAlignmentItem1
            ' 
            resources.ApplyResources(Me.toggleTableCellsBottomRightAlignmentItem1, "toggleTableCellsBottomRightAlignmentItem1")
            Me.toggleTableCellsBottomRightAlignmentItem1.Id = 112
            Me.toggleTableCellsBottomRightAlignmentItem1.Name = "toggleTableCellsBottomRightAlignmentItem1"
            ' 
            ' changeFloatingObjectFillColorItem1
            ' 
            resources.ApplyResources(Me.changeFloatingObjectFillColorItem1, "changeFloatingObjectFillColorItem1")
            Me.changeFloatingObjectFillColorItem1.Id = 113
            Me.changeFloatingObjectFillColorItem1.Name = "changeFloatingObjectFillColorItem1"
            ' 
            ' changeFloatingObjectOutlineColorItem1
            ' 
            resources.ApplyResources(Me.changeFloatingObjectOutlineColorItem1, "changeFloatingObjectOutlineColorItem1")
            Me.changeFloatingObjectOutlineColorItem1.Id = 114
            Me.changeFloatingObjectOutlineColorItem1.Name = "changeFloatingObjectOutlineColorItem1"
            ' 
            ' changeFloatingObjectOutlineWeightItem1
            ' 
            resources.ApplyResources(Me.changeFloatingObjectOutlineWeightItem1, "changeFloatingObjectOutlineWeightItem1")
            Me.changeFloatingObjectOutlineWeightItem1.Edit = Me.repositoryItemFloatingObjectOutlineWeight1
            Me.changeFloatingObjectOutlineWeightItem1.EditValue = 20
            Me.changeFloatingObjectOutlineWeightItem1.Id = 115
            Me.changeFloatingObjectOutlineWeightItem1.Name = "changeFloatingObjectOutlineWeightItem1"
            ' 
            ' repositoryItemFloatingObjectOutlineWeight1
            ' 
            resources.ApplyResources(Me.repositoryItemFloatingObjectOutlineWeight1, "repositoryItemFloatingObjectOutlineWeight1")
            Me.repositoryItemFloatingObjectOutlineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemFloatingObjectOutlineWeight1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemFloatingObjectOutlineWeight1.Control = Me.richEditControl1
            Me.repositoryItemFloatingObjectOutlineWeight1.Name = "repositoryItemFloatingObjectOutlineWeight1"
            ' 
            ' changeFloatingObjectTextWrapTypeItem1
            ' 
            resources.ApplyResources(Me.changeFloatingObjectTextWrapTypeItem1, "changeFloatingObjectTextWrapTypeItem1")
            Me.changeFloatingObjectTextWrapTypeItem1.Id = 116
            Me.changeFloatingObjectTextWrapTypeItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectSquareTextWrapTypeItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTightTextWrapTypeItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectThroughTextWrapTypeItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopAndBottomTextWrapTypeItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBehindTextWrapTypeItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectInFrontOfTextWrapTypeItem1)
            })
            Me.changeFloatingObjectTextWrapTypeItem1.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (DirectCast(resources.GetObject("changeFloatingObjectTextWrapTypeItem1.MenuAppearance.HeaderItemAppearance.FontSiz" & "eDelta"), Integer))
            Me.changeFloatingObjectTextWrapTypeItem1.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (DirectCast(resources.GetObject("changeFloatingObjectTextWrapTypeItem1.MenuAppearance.HeaderItemAppearance.FontSty" & "leDelta"), System.Drawing.FontStyle))
            Me.changeFloatingObjectTextWrapTypeItem1.MenuAppearance.HeaderItemAppearance.GradientMode = (DirectCast(resources.GetObject("changeFloatingObjectTextWrapTypeItem1.MenuAppearance.HeaderItemAppearance.Gradien" & "tMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.changeFloatingObjectTextWrapTypeItem1.MenuAppearance.HeaderItemAppearance.Image = (DirectCast(resources.GetObject("changeFloatingObjectTextWrapTypeItem1.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.changeFloatingObjectTextWrapTypeItem1.Name = "changeFloatingObjectTextWrapTypeItem1"
            ' 
            ' setFloatingObjectSquareTextWrapTypeItem1
            ' 
            resources.ApplyResources(Me.setFloatingObjectSquareTextWrapTypeItem1, "setFloatingObjectSquareTextWrapTypeItem1")
            Me.setFloatingObjectSquareTextWrapTypeItem1.Id = 117
            Me.setFloatingObjectSquareTextWrapTypeItem1.Name = "setFloatingObjectSquareTextWrapTypeItem1"
            ' 
            ' setFloatingObjectTightTextWrapTypeItem1
            ' 
            resources.ApplyResources(Me.setFloatingObjectTightTextWrapTypeItem1, "setFloatingObjectTightTextWrapTypeItem1")
            Me.setFloatingObjectTightTextWrapTypeItem1.Id = 118
            Me.setFloatingObjectTightTextWrapTypeItem1.Name = "setFloatingObjectTightTextWrapTypeItem1"
            ' 
            ' setFloatingObjectThroughTextWrapTypeItem1
            ' 
            resources.ApplyResources(Me.setFloatingObjectThroughTextWrapTypeItem1, "setFloatingObjectThroughTextWrapTypeItem1")
            Me.setFloatingObjectThroughTextWrapTypeItem1.Id = 119
            Me.setFloatingObjectThroughTextWrapTypeItem1.Name = "setFloatingObjectThroughTextWrapTypeItem1"
            ' 
            ' setFloatingObjectTopAndBottomTextWrapTypeItem1
            ' 
            resources.ApplyResources(Me.setFloatingObjectTopAndBottomTextWrapTypeItem1, "setFloatingObjectTopAndBottomTextWrapTypeItem1")
            Me.setFloatingObjectTopAndBottomTextWrapTypeItem1.Id = 120
            Me.setFloatingObjectTopAndBottomTextWrapTypeItem1.Name = "setFloatingObjectTopAndBottomTextWrapTypeItem1"
            ' 
            ' setFloatingObjectBehindTextWrapTypeItem1
            ' 
            resources.ApplyResources(Me.setFloatingObjectBehindTextWrapTypeItem1, "setFloatingObjectBehindTextWrapTypeItem1")
            Me.setFloatingObjectBehindTextWrapTypeItem1.Id = 121
            Me.setFloatingObjectBehindTextWrapTypeItem1.Name = "setFloatingObjectBehindTextWrapTypeItem1"
            ' 
            ' setFloatingObjectInFrontOfTextWrapTypeItem1
            ' 
            resources.ApplyResources(Me.setFloatingObjectInFrontOfTextWrapTypeItem1, "setFloatingObjectInFrontOfTextWrapTypeItem1")
            Me.setFloatingObjectInFrontOfTextWrapTypeItem1.Id = 122
            Me.setFloatingObjectInFrontOfTextWrapTypeItem1.Name = "setFloatingObjectInFrontOfTextWrapTypeItem1"
            ' 
            ' changeFloatingObjectAlignmentItem1
            ' 
            resources.ApplyResources(Me.changeFloatingObjectAlignmentItem1, "changeFloatingObjectAlignmentItem1")
            Me.changeFloatingObjectAlignmentItem1.Id = 123
            Me.changeFloatingObjectAlignmentItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopLeftAlignmentItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopCenterAlignmentItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopRightAlignmentItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectMiddleLeftAlignmentItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectMiddleCenterAlignmentItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectMiddleRightAlignmentItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBottomLeftAlignmentItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBottomCenterAlignmentItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBottomRightAlignmentItem1)
            })
            Me.changeFloatingObjectAlignmentItem1.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (DirectCast(resources.GetObject("changeFloatingObjectAlignmentItem1.MenuAppearance.HeaderItemAppearance.FontSizeDe" & "lta"), Integer))
            Me.changeFloatingObjectAlignmentItem1.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (DirectCast(resources.GetObject("changeFloatingObjectAlignmentItem1.MenuAppearance.HeaderItemAppearance.FontStyleD" & "elta"), System.Drawing.FontStyle))
            Me.changeFloatingObjectAlignmentItem1.MenuAppearance.HeaderItemAppearance.GradientMode = (DirectCast(resources.GetObject("changeFloatingObjectAlignmentItem1.MenuAppearance.HeaderItemAppearance.GradientMo" & "de"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.changeFloatingObjectAlignmentItem1.MenuAppearance.HeaderItemAppearance.Image = (DirectCast(resources.GetObject("changeFloatingObjectAlignmentItem1.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.changeFloatingObjectAlignmentItem1.Name = "changeFloatingObjectAlignmentItem1"
            ' 
            ' setFloatingObjectTopLeftAlignmentItem1
            ' 
            resources.ApplyResources(Me.setFloatingObjectTopLeftAlignmentItem1, "setFloatingObjectTopLeftAlignmentItem1")
            Me.setFloatingObjectTopLeftAlignmentItem1.Id = 124
            Me.setFloatingObjectTopLeftAlignmentItem1.Name = "setFloatingObjectTopLeftAlignmentItem1"
            ' 
            ' setFloatingObjectTopCenterAlignmentItem1
            ' 
            resources.ApplyResources(Me.setFloatingObjectTopCenterAlignmentItem1, "setFloatingObjectTopCenterAlignmentItem1")
            Me.setFloatingObjectTopCenterAlignmentItem1.Id = 125
            Me.setFloatingObjectTopCenterAlignmentItem1.Name = "setFloatingObjectTopCenterAlignmentItem1"
            ' 
            ' setFloatingObjectTopRightAlignmentItem1
            ' 
            resources.ApplyResources(Me.setFloatingObjectTopRightAlignmentItem1, "setFloatingObjectTopRightAlignmentItem1")
            Me.setFloatingObjectTopRightAlignmentItem1.Id = 126
            Me.setFloatingObjectTopRightAlignmentItem1.Name = "setFloatingObjectTopRightAlignmentItem1"
            ' 
            ' setFloatingObjectMiddleLeftAlignmentItem1
            ' 
            resources.ApplyResources(Me.setFloatingObjectMiddleLeftAlignmentItem1, "setFloatingObjectMiddleLeftAlignmentItem1")
            Me.setFloatingObjectMiddleLeftAlignmentItem1.Id = 127
            Me.setFloatingObjectMiddleLeftAlignmentItem1.Name = "setFloatingObjectMiddleLeftAlignmentItem1"
            ' 
            ' setFloatingObjectMiddleCenterAlignmentItem1
            ' 
            resources.ApplyResources(Me.setFloatingObjectMiddleCenterAlignmentItem1, "setFloatingObjectMiddleCenterAlignmentItem1")
            Me.setFloatingObjectMiddleCenterAlignmentItem1.Id = 128
            Me.setFloatingObjectMiddleCenterAlignmentItem1.Name = "setFloatingObjectMiddleCenterAlignmentItem1"
            ' 
            ' setFloatingObjectMiddleRightAlignmentItem1
            ' 
            resources.ApplyResources(Me.setFloatingObjectMiddleRightAlignmentItem1, "setFloatingObjectMiddleRightAlignmentItem1")
            Me.setFloatingObjectMiddleRightAlignmentItem1.Id = 129
            Me.setFloatingObjectMiddleRightAlignmentItem1.Name = "setFloatingObjectMiddleRightAlignmentItem1"
            ' 
            ' setFloatingObjectBottomLeftAlignmentItem1
            ' 
            resources.ApplyResources(Me.setFloatingObjectBottomLeftAlignmentItem1, "setFloatingObjectBottomLeftAlignmentItem1")
            Me.setFloatingObjectBottomLeftAlignmentItem1.Id = 130
            Me.setFloatingObjectBottomLeftAlignmentItem1.Name = "setFloatingObjectBottomLeftAlignmentItem1"
            ' 
            ' setFloatingObjectBottomCenterAlignmentItem1
            ' 
            resources.ApplyResources(Me.setFloatingObjectBottomCenterAlignmentItem1, "setFloatingObjectBottomCenterAlignmentItem1")
            Me.setFloatingObjectBottomCenterAlignmentItem1.Id = 131
            Me.setFloatingObjectBottomCenterAlignmentItem1.Name = "setFloatingObjectBottomCenterAlignmentItem1"
            ' 
            ' setFloatingObjectBottomRightAlignmentItem1
            ' 
            resources.ApplyResources(Me.setFloatingObjectBottomRightAlignmentItem1, "setFloatingObjectBottomRightAlignmentItem1")
            Me.setFloatingObjectBottomRightAlignmentItem1.Id = 132
            Me.setFloatingObjectBottomRightAlignmentItem1.Name = "setFloatingObjectBottomRightAlignmentItem1"
            ' 
            ' floatingObjectBringForwardSubItem1
            ' 
            resources.ApplyResources(Me.floatingObjectBringForwardSubItem1, "floatingObjectBringForwardSubItem1")
            Me.floatingObjectBringForwardSubItem1.Id = 133
            Me.floatingObjectBringForwardSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectBringForwardItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectBringToFrontItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectBringInFrontOfTextItem1)
            })
            Me.floatingObjectBringForwardSubItem1.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (DirectCast(resources.GetObject("floatingObjectBringForwardSubItem1.MenuAppearance.HeaderItemAppearance.FontSizeDe" & "lta"), Integer))
            Me.floatingObjectBringForwardSubItem1.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (DirectCast(resources.GetObject("floatingObjectBringForwardSubItem1.MenuAppearance.HeaderItemAppearance.FontStyleD" & "elta"), System.Drawing.FontStyle))
            Me.floatingObjectBringForwardSubItem1.MenuAppearance.HeaderItemAppearance.GradientMode = (DirectCast(resources.GetObject("floatingObjectBringForwardSubItem1.MenuAppearance.HeaderItemAppearance.GradientMo" & "de"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.floatingObjectBringForwardSubItem1.MenuAppearance.HeaderItemAppearance.Image = (DirectCast(resources.GetObject("floatingObjectBringForwardSubItem1.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.floatingObjectBringForwardSubItem1.Name = "floatingObjectBringForwardSubItem1"
            ' 
            ' floatingObjectBringForwardItem1
            ' 
            resources.ApplyResources(Me.floatingObjectBringForwardItem1, "floatingObjectBringForwardItem1")
            Me.floatingObjectBringForwardItem1.Id = 134
            Me.floatingObjectBringForwardItem1.Name = "floatingObjectBringForwardItem1"
            ' 
            ' floatingObjectBringToFrontItem1
            ' 
            resources.ApplyResources(Me.floatingObjectBringToFrontItem1, "floatingObjectBringToFrontItem1")
            Me.floatingObjectBringToFrontItem1.Id = 135
            Me.floatingObjectBringToFrontItem1.Name = "floatingObjectBringToFrontItem1"
            ' 
            ' floatingObjectBringInFrontOfTextItem1
            ' 
            resources.ApplyResources(Me.floatingObjectBringInFrontOfTextItem1, "floatingObjectBringInFrontOfTextItem1")
            Me.floatingObjectBringInFrontOfTextItem1.Id = 136
            Me.floatingObjectBringInFrontOfTextItem1.Name = "floatingObjectBringInFrontOfTextItem1"
            ' 
            ' floatingObjectSendBackwardSubItem1
            ' 
            resources.ApplyResources(Me.floatingObjectSendBackwardSubItem1, "floatingObjectSendBackwardSubItem1")
            Me.floatingObjectSendBackwardSubItem1.Id = 137
            Me.floatingObjectSendBackwardSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectSendBackwardItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectSendToBackItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectSendBehindTextItem1)
            })
            Me.floatingObjectSendBackwardSubItem1.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (DirectCast(resources.GetObject("floatingObjectSendBackwardSubItem1.MenuAppearance.HeaderItemAppearance.FontSizeDe" & "lta"), Integer))
            Me.floatingObjectSendBackwardSubItem1.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (DirectCast(resources.GetObject("floatingObjectSendBackwardSubItem1.MenuAppearance.HeaderItemAppearance.FontStyleD" & "elta"), System.Drawing.FontStyle))
            Me.floatingObjectSendBackwardSubItem1.MenuAppearance.HeaderItemAppearance.GradientMode = (DirectCast(resources.GetObject("floatingObjectSendBackwardSubItem1.MenuAppearance.HeaderItemAppearance.GradientMo" & "de"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.floatingObjectSendBackwardSubItem1.MenuAppearance.HeaderItemAppearance.Image = (DirectCast(resources.GetObject("floatingObjectSendBackwardSubItem1.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.floatingObjectSendBackwardSubItem1.Name = "floatingObjectSendBackwardSubItem1"
            ' 
            ' floatingObjectSendBackwardItem1
            ' 
            resources.ApplyResources(Me.floatingObjectSendBackwardItem1, "floatingObjectSendBackwardItem1")
            Me.floatingObjectSendBackwardItem1.Id = 138
            Me.floatingObjectSendBackwardItem1.Name = "floatingObjectSendBackwardItem1"
            ' 
            ' floatingObjectSendToBackItem1
            ' 
            resources.ApplyResources(Me.floatingObjectSendToBackItem1, "floatingObjectSendToBackItem1")
            Me.floatingObjectSendToBackItem1.Id = 139
            Me.floatingObjectSendToBackItem1.Name = "floatingObjectSendToBackItem1"
            ' 
            ' floatingObjectSendBehindTextItem1
            ' 
            resources.ApplyResources(Me.floatingObjectSendBehindTextItem1, "floatingObjectSendBehindTextItem1")
            Me.floatingObjectSendBehindTextItem1.Id = 140
            Me.floatingObjectSendBehindTextItem1.Name = "floatingObjectSendBehindTextItem1"
            ' 
            ' fileNewItem1
            ' 
            resources.ApplyResources(Me.fileNewItem1, "fileNewItem1")
            Me.fileNewItem1.Id = 141
            Me.fileNewItem1.Name = "fileNewItem1"
            ' 
            ' fileOpenItem1
            ' 
            resources.ApplyResources(Me.fileOpenItem1, "fileOpenItem1")
            Me.fileOpenItem1.Id = 142
            Me.fileOpenItem1.Name = "fileOpenItem1"
            ' 
            ' fileSaveItem1
            ' 
            resources.ApplyResources(Me.fileSaveItem1, "fileSaveItem1")
            Me.fileSaveItem1.Id = 143
            Me.fileSaveItem1.Name = "fileSaveItem1"
            ' 
            ' fileSaveAsItem1
            ' 
            resources.ApplyResources(Me.fileSaveAsItem1, "fileSaveAsItem1")
            Me.fileSaveAsItem1.Id = 144
            Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
            ' 
            ' quickPrintItem1
            ' 
            resources.ApplyResources(Me.quickPrintItem1, "quickPrintItem1")
            Me.quickPrintItem1.Id = 145
            Me.quickPrintItem1.Name = "quickPrintItem1"
            ' 
            ' printItem1
            ' 
            resources.ApplyResources(Me.printItem1, "printItem1")
            Me.printItem1.Id = 146
            Me.printItem1.Name = "printItem1"
            ' 
            ' printPreviewItem1
            ' 
            resources.ApplyResources(Me.printPreviewItem1, "printPreviewItem1")
            Me.printPreviewItem1.Id = 147
            Me.printPreviewItem1.Name = "printPreviewItem1"
            ' 
            ' undoItem1
            ' 
            resources.ApplyResources(Me.undoItem1, "undoItem1")
            Me.undoItem1.Id = 148
            Me.undoItem1.Name = "undoItem1"
            ' 
            ' redoItem1
            ' 
            resources.ApplyResources(Me.redoItem1, "redoItem1")
            Me.redoItem1.Id = 149
            Me.redoItem1.Name = "redoItem1"
            ' 
            ' tableToolsRibbonPageCategory1
            ' 
            resources.ApplyResources(Me.tableToolsRibbonPageCategory1, "tableToolsRibbonPageCategory1")
            Me.tableToolsRibbonPageCategory1.Control = Me.richEditControl1
            Me.tableToolsRibbonPageCategory1.Name = "tableToolsRibbonPageCategory1"
            Me.tableToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.tableDesignRibbonPage1, Me.tableLayoutRibbonPage1})
            ' 
            ' tableDesignRibbonPage1
            ' 
            Me.tableDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.tableStylesRibbonPageGroup1, Me.tableDrawBordersRibbonPageGroup1})
            Me.tableDesignRibbonPage1.Name = "tableDesignRibbonPage1"
            resources.ApplyResources(Me.tableDesignRibbonPage1, "tableDesignRibbonPage1")
            ' 
            ' tableStylesRibbonPageGroup1
            ' 
            Me.tableStylesRibbonPageGroup1.ItemLinks.Add(Me.changeTableCellsShadingItem1)
            Me.tableStylesRibbonPageGroup1.ItemLinks.Add(Me.changeTableBordersItem1)
            Me.tableStylesRibbonPageGroup1.Name = "tableStylesRibbonPageGroup1"
            ' 
            ' tableDrawBordersRibbonPageGroup1
            ' 
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderLineStyleItem1)
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderLineWeightItem1)
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderColorItem1)
            Me.tableDrawBordersRibbonPageGroup1.Name = "tableDrawBordersRibbonPageGroup1"
            ' 
            ' tableLayoutRibbonPage1
            ' 
            Me.tableLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.tableTableRibbonPageGroup1, Me.tableRowsAndColumnsRibbonPageGroup1, Me.tableMergeRibbonPageGroup1, Me.tableCellSizeRibbonPageGroup1, Me.tableAlignmentRibbonPageGroup1})
            Me.tableLayoutRibbonPage1.Name = "tableLayoutRibbonPage1"
            resources.ApplyResources(Me.tableLayoutRibbonPage1, "tableLayoutRibbonPage1")
            ' 
            ' tableTableRibbonPageGroup1
            ' 
            Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.selectTableElementsItem1)
            Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.toggleShowTableGridLinesItem1)
            Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.showTablePropertiesFormItem1)
            Me.tableTableRibbonPageGroup1.Name = "tableTableRibbonPageGroup1"
            ' 
            ' tableRowsAndColumnsRibbonPageGroup1
            ' 
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.deleteTableElementsItem1)
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableRowAboveItem1)
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableRowBelowItem1)
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableColumnToLeftItem1)
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableColumnToRightItem1)
            Me.tableRowsAndColumnsRibbonPageGroup1.Name = "tableRowsAndColumnsRibbonPageGroup1"
            ' 
            ' tableMergeRibbonPageGroup1
            ' 
            Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.mergeTableCellsItem1)
            Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.showSplitTableCellsForm1)
            Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.splitTableItem1)
            Me.tableMergeRibbonPageGroup1.Name = "tableMergeRibbonPageGroup1"
            ' 
            ' tableCellSizeRibbonPageGroup1
            ' 
            Me.tableCellSizeRibbonPageGroup1.AllowTextClipping = False
            Me.tableCellSizeRibbonPageGroup1.ItemLinks.Add(Me.toggleTableAutoFitItem1)
            Me.tableCellSizeRibbonPageGroup1.Name = "tableCellSizeRibbonPageGroup1"
            ' 
            ' tableAlignmentRibbonPageGroup1
            ' 
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopLeftAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleLeftAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomLeftAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopCenterAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleCenterAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomCenterAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopRightAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleRightAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomRightAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.Name = "tableAlignmentRibbonPageGroup1"
            ' 
            ' floatingPictureToolsRibbonPageCategory1
            ' 
            resources.ApplyResources(Me.floatingPictureToolsRibbonPageCategory1, "floatingPictureToolsRibbonPageCategory1")
            Me.floatingPictureToolsRibbonPageCategory1.Control = Me.richEditControl1
            Me.floatingPictureToolsRibbonPageCategory1.Name = "floatingPictureToolsRibbonPageCategory1"
            Me.floatingPictureToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.floatingPictureToolsFormatPage1})
            ' 
            ' floatingPictureToolsFormatPage1
            ' 
            Me.floatingPictureToolsFormatPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.floatingPictureToolsShapeStylesPageGroup1, Me.floatingPictureToolsArrangePageGroup1})
            Me.floatingPictureToolsFormatPage1.Name = "floatingPictureToolsFormatPage1"
            resources.ApplyResources(Me.floatingPictureToolsFormatPage1, "floatingPictureToolsFormatPage1")
            ' 
            ' floatingPictureToolsShapeStylesPageGroup1
            ' 
            Me.floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(Me.changeFloatingObjectFillColorItem1)
            Me.floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(Me.changeFloatingObjectOutlineColorItem1)
            Me.floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(Me.changeFloatingObjectOutlineWeightItem1)
            Me.floatingPictureToolsShapeStylesPageGroup1.Name = "floatingPictureToolsShapeStylesPageGroup1"
            ' 
            ' floatingPictureToolsArrangePageGroup1
            ' 
            Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.changeFloatingObjectTextWrapTypeItem1)
            Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.changeFloatingObjectAlignmentItem1)
            Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.floatingObjectBringForwardSubItem1)
            Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.floatingObjectSendBackwardSubItem1)
            Me.floatingPictureToolsArrangePageGroup1.Name = "floatingPictureToolsArrangePageGroup1"
            ' 
            ' homeRibbonPage1
            ' 
            Me.homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.clipboardRibbonPageGroup1, Me.fontRibbonPageGroup1, Me.paragraphRibbonPageGroup1, Me.stylesRibbonPageGroup1, Me.editingRibbonPageGroup1})
            Me.homeRibbonPage1.Name = "homeRibbonPage1"
            resources.ApplyResources(Me.homeRibbonPage1, "homeRibbonPage1")
            ' 
            ' clipboardRibbonPageGroup1
            ' 
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteItem1)
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.cutItem1)
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.copyItem1)
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteSpecialItem1)
            Me.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1"
            ' 
            ' fontRibbonPageGroup1
            ' 
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup2)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup3)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.changeTextCaseItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.clearFormattingItem1)
            Me.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1"
            ' 
            ' paragraphRibbonPageGroup1
            ' 
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup4)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup5)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup6)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup7)
            Me.paragraphRibbonPageGroup1.Name = "paragraphRibbonPageGroup1"
            ' 
            ' stylesRibbonPageGroup1
            ' 
            Me.stylesRibbonPageGroup1.ItemLinks.Add(Me.changeStyleItem1)
            Me.stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1"
            ' 
            ' editingRibbonPageGroup1
            ' 
            Me.editingRibbonPageGroup1.AllowTextClipping = False
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.findItem1)
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.replaceItem1)
            Me.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1"
            ' 
            ' insertRibbonPage1
            ' 
            Me.insertRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.pagesRibbonPageGroup1, Me.tablesRibbonPageGroup1, Me.illustrationsRibbonPageGroup1, Me.linksRibbonPageGroup1, Me.headerFooterRibbonPageGroup1, Me.textRibbonPageGroup1, Me.symbolsRibbonPageGroup1})
            Me.insertRibbonPage1.Name = "insertRibbonPage1"
            resources.ApplyResources(Me.insertRibbonPage1, "insertRibbonPage1")
            ' 
            ' pagesRibbonPageGroup1
            ' 
            Me.pagesRibbonPageGroup1.AllowTextClipping = False
            Me.pagesRibbonPageGroup1.ItemLinks.Add(Me.insertPageBreakItem1)
            Me.pagesRibbonPageGroup1.Name = "pagesRibbonPageGroup1"
            ' 
            ' tablesRibbonPageGroup1
            ' 
            Me.tablesRibbonPageGroup1.AllowTextClipping = False
            Me.tablesRibbonPageGroup1.ItemLinks.Add(Me.insertTableItem1)
            Me.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1"
            ' 
            ' illustrationsRibbonPageGroup1
            ' 
            Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.insertPictureItem1)
            Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.insertFloatingPictureItem1)
            Me.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1"
            ' 
            ' linksRibbonPageGroup1
            ' 
            Me.linksRibbonPageGroup1.ItemLinks.Add(Me.insertBookmarkItem1)
            Me.linksRibbonPageGroup1.ItemLinks.Add(Me.insertHyperlinkItem1)
            Me.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1"
            ' 
            ' headerFooterRibbonPageGroup1
            ' 
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.editPageHeaderItem1)
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.editPageFooterItem1)
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.insertPageNumberItem1)
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.insertPageCountItem1)
            Me.headerFooterRibbonPageGroup1.Name = "headerFooterRibbonPageGroup1"
            ' 
            ' textRibbonPageGroup1
            ' 
            Me.textRibbonPageGroup1.AllowTextClipping = False
            Me.textRibbonPageGroup1.ItemLinks.Add(Me.insertTextBoxItem1)
            Me.textRibbonPageGroup1.Name = "textRibbonPageGroup1"
            ' 
            ' symbolsRibbonPageGroup1
            ' 
            Me.symbolsRibbonPageGroup1.AllowTextClipping = False
            Me.symbolsRibbonPageGroup1.ItemLinks.Add(Me.insertSymbolItem1)
            Me.symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1"
            ' 
            ' icbPriority
            ' 
            resources.ApplyResources(Me.icbPriority, "icbPriority")
            Me.icbPriority.MenuManager = Me.ribbonControl1
            Me.icbPriority.Name = "icbPriority"
            Me.icbPriority.Properties.AccessibleDescription = resources.GetString("icbPriority.Properties.AccessibleDescription")
            Me.icbPriority.Properties.AccessibleName = resources.GetString("icbPriority.Properties.AccessibleName")
            Me.icbPriority.Properties.AutoHeight = (DirectCast(resources.GetObject("icbPriority.Properties.AutoHeight"), Boolean))
            Me.icbPriority.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("icbPriority.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.icbPriority.Properties.GlyphAlignment = (DirectCast(resources.GetObject("icbPriority.Properties.GlyphAlignment"), DevExpress.Utils.HorzAlignment))
            Me.icbPriority.Properties.NullValuePrompt = resources.GetString("icbPriority.Properties.NullValuePrompt")
            Me.icbPriority.Properties.NullValuePromptShowForEmptyValue = (DirectCast(resources.GetObject("icbPriority.Properties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.icbPriority.Properties.SmallImages = Me.icEditors
            Me.icbPriority.StyleController = Me.lcMain
            ' 
            ' icEditors
            ' 
            Me.icEditors.ImageStream = (DirectCast(resources.GetObject("icEditors.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.icEditors.Images.SetKeyName(0, "Low16x16.png")
            Me.icEditors.Images.SetKeyName(1, "High16x16.png")
            ' 
            ' icbStatus
            ' 
            resources.ApplyResources(Me.icbStatus, "icbStatus")
            Me.icbStatus.MenuManager = Me.ribbonControl1
            Me.icbStatus.Name = "icbStatus"
            Me.icbStatus.Properties.AccessibleDescription = resources.GetString("icbStatus.Properties.AccessibleDescription")
            Me.icbStatus.Properties.AccessibleName = resources.GetString("icbStatus.Properties.AccessibleName")
            Me.icbStatus.Properties.AutoHeight = (DirectCast(resources.GetObject("icbStatus.Properties.AutoHeight"), Boolean))
            Me.icbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("icbStatus.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.icbStatus.Properties.GlyphAlignment = (DirectCast(resources.GetObject("icbStatus.Properties.GlyphAlignment"), DevExpress.Utils.HorzAlignment))
            Me.icbStatus.Properties.NullValuePrompt = resources.GetString("icbStatus.Properties.NullValuePrompt")
            Me.icbStatus.Properties.NullValuePromptShowForEmptyValue = (DirectCast(resources.GetObject("icbStatus.Properties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.icbStatus.StyleController = Me.lcMain
            ' 
            ' deStartDate
            ' 
            resources.ApplyResources(Me.deStartDate, "deStartDate")
            Me.deStartDate.MenuManager = Me.ribbonControl1
            Me.deStartDate.Name = "deStartDate"
            Me.deStartDate.Properties.AccessibleDescription = resources.GetString("deStartDate.Properties.AccessibleDescription")
            Me.deStartDate.Properties.AccessibleName = resources.GetString("deStartDate.Properties.AccessibleName")
            Me.deStartDate.Properties.AutoHeight = (DirectCast(resources.GetObject("deStartDate.Properties.AutoHeight"), Boolean))
            Me.deStartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("deStartDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.deStartDate.Properties.CalendarTimeProperties.AccessibleDescription = resources.GetString("deStartDate.Properties.CalendarTimeProperties.AccessibleDescription")
            Me.deStartDate.Properties.CalendarTimeProperties.AccessibleName = resources.GetString("deStartDate.Properties.CalendarTimeProperties.AccessibleName")
            Me.deStartDate.Properties.CalendarTimeProperties.AutoHeight = (DirectCast(resources.GetObject("deStartDate.Properties.CalendarTimeProperties.AutoHeight"), Boolean))
            Me.deStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.deStartDate.Properties.CalendarTimeProperties.Mask.AutoComplete = (DirectCast(resources.GetObject("deStartDate.Properties.CalendarTimeProperties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
            Me.deStartDate.Properties.CalendarTimeProperties.Mask.BeepOnError = (DirectCast(resources.GetObject("deStartDate.Properties.CalendarTimeProperties.Mask.BeepOnError"), Boolean))
            Me.deStartDate.Properties.CalendarTimeProperties.Mask.EditMask = resources.GetString("deStartDate.Properties.CalendarTimeProperties.Mask.EditMask")
            Me.deStartDate.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank = (DirectCast(resources.GetObject("deStartDate.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank"), Boolean))
            Me.deStartDate.Properties.CalendarTimeProperties.Mask.MaskType = (DirectCast(resources.GetObject("deStartDate.Properties.CalendarTimeProperties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.deStartDate.Properties.CalendarTimeProperties.Mask.PlaceHolder = (DirectCast(resources.GetObject("deStartDate.Properties.CalendarTimeProperties.Mask.PlaceHolder"), Char))
            Me.deStartDate.Properties.CalendarTimeProperties.Mask.SaveLiteral = (DirectCast(resources.GetObject("deStartDate.Properties.CalendarTimeProperties.Mask.SaveLiteral"), Boolean))
            Me.deStartDate.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders = (DirectCast(resources.GetObject("deStartDate.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders"), Boolean))
            Me.deStartDate.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = (DirectCast(resources.GetObject("deStartDate.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat"), Boolean))
            Me.deStartDate.Properties.CalendarTimeProperties.NullValuePrompt = resources.GetString("deStartDate.Properties.CalendarTimeProperties.NullValuePrompt")
            Me.deStartDate.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue = (DirectCast(resources.GetObject("deStartDate.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.deStartDate.Properties.Mask.AutoComplete = (DirectCast(resources.GetObject("deStartDate.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
            Me.deStartDate.Properties.Mask.BeepOnError = (DirectCast(resources.GetObject("deStartDate.Properties.Mask.BeepOnError"), Boolean))
            Me.deStartDate.Properties.Mask.EditMask = resources.GetString("deStartDate.Properties.Mask.EditMask")
            Me.deStartDate.Properties.Mask.IgnoreMaskBlank = (DirectCast(resources.GetObject("deStartDate.Properties.Mask.IgnoreMaskBlank"), Boolean))
            Me.deStartDate.Properties.Mask.MaskType = (DirectCast(resources.GetObject("deStartDate.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.deStartDate.Properties.Mask.PlaceHolder = (DirectCast(resources.GetObject("deStartDate.Properties.Mask.PlaceHolder"), Char))
            Me.deStartDate.Properties.Mask.SaveLiteral = (DirectCast(resources.GetObject("deStartDate.Properties.Mask.SaveLiteral"), Boolean))
            Me.deStartDate.Properties.Mask.ShowPlaceHolders = (DirectCast(resources.GetObject("deStartDate.Properties.Mask.ShowPlaceHolders"), Boolean))
            Me.deStartDate.Properties.Mask.UseMaskAsDisplayFormat = (DirectCast(resources.GetObject("deStartDate.Properties.Mask.UseMaskAsDisplayFormat"), Boolean))
            Me.deStartDate.Properties.NullValuePrompt = resources.GetString("deStartDate.Properties.NullValuePrompt")
            Me.deStartDate.Properties.NullValuePromptShowForEmptyValue = (DirectCast(resources.GetObject("deStartDate.Properties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.deStartDate.StyleController = Me.lcMain
            ' 
            ' icbCategory
            ' 
            resources.ApplyResources(Me.icbCategory, "icbCategory")
            Me.icbCategory.MenuManager = Me.ribbonControl1
            Me.icbCategory.Name = "icbCategory"
            Me.icbCategory.Properties.AccessibleDescription = resources.GetString("icbCategory.Properties.AccessibleDescription")
            Me.icbCategory.Properties.AccessibleName = resources.GetString("icbCategory.Properties.AccessibleName")
            Me.icbCategory.Properties.AutoHeight = (DirectCast(resources.GetObject("icbCategory.Properties.AutoHeight"), Boolean))
            Me.icbCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("icbCategory.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.icbCategory.Properties.GlyphAlignment = (DirectCast(resources.GetObject("icbCategory.Properties.GlyphAlignment"), DevExpress.Utils.HorzAlignment))
            Me.icbCategory.Properties.NullValuePrompt = resources.GetString("icbCategory.Properties.NullValuePrompt")
            Me.icbCategory.Properties.NullValuePromptShowForEmptyValue = (DirectCast(resources.GetObject("icbCategory.Properties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.icbCategory.Properties.SmallImages = Me.icCategory
            Me.icbCategory.StyleController = Me.lcMain
            ' 
            ' icCategory
            ' 
            Me.icCategory.ImageStream = (DirectCast(resources.GetObject("icCategory.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.icCategory.Images.SetKeyName(0, "HouseChores_16x16.png")
            Me.icCategory.Images.SetKeyName(1, "BO_Cart.png")
            Me.icCategory.Images.SetKeyName(2, "BO_Organization.png")
            ' 
            ' sbCancel
            ' 
            resources.ApplyResources(Me.sbCancel, "sbCancel")
            Me.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.sbCancel.Name = "sbCancel"
            Me.sbCancel.StyleController = Me.lcMain
            ' 
            ' deDueDate
            ' 
            resources.ApplyResources(Me.deDueDate, "deDueDate")
            Me.deDueDate.MenuManager = Me.ribbonControl1
            Me.deDueDate.Name = "deDueDate"
            Me.deDueDate.Properties.AccessibleDescription = resources.GetString("deDueDate.Properties.AccessibleDescription")
            Me.deDueDate.Properties.AccessibleName = resources.GetString("deDueDate.Properties.AccessibleName")
            Me.deDueDate.Properties.AutoHeight = (DirectCast(resources.GetObject("deDueDate.Properties.AutoHeight"), Boolean))
            Me.deDueDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("deDueDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.deDueDate.Properties.CalendarTimeProperties.AccessibleDescription = resources.GetString("deDueDate.Properties.CalendarTimeProperties.AccessibleDescription")
            Me.deDueDate.Properties.CalendarTimeProperties.AccessibleName = resources.GetString("deDueDate.Properties.CalendarTimeProperties.AccessibleName")
            Me.deDueDate.Properties.CalendarTimeProperties.AutoHeight = (DirectCast(resources.GetObject("deDueDate.Properties.CalendarTimeProperties.AutoHeight"), Boolean))
            Me.deDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.deDueDate.Properties.CalendarTimeProperties.Mask.AutoComplete = (DirectCast(resources.GetObject("deDueDate.Properties.CalendarTimeProperties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
            Me.deDueDate.Properties.CalendarTimeProperties.Mask.BeepOnError = (DirectCast(resources.GetObject("deDueDate.Properties.CalendarTimeProperties.Mask.BeepOnError"), Boolean))
            Me.deDueDate.Properties.CalendarTimeProperties.Mask.EditMask = resources.GetString("deDueDate.Properties.CalendarTimeProperties.Mask.EditMask")
            Me.deDueDate.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank = (DirectCast(resources.GetObject("deDueDate.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank"), Boolean))
            Me.deDueDate.Properties.CalendarTimeProperties.Mask.MaskType = (DirectCast(resources.GetObject("deDueDate.Properties.CalendarTimeProperties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.deDueDate.Properties.CalendarTimeProperties.Mask.PlaceHolder = (DirectCast(resources.GetObject("deDueDate.Properties.CalendarTimeProperties.Mask.PlaceHolder"), Char))
            Me.deDueDate.Properties.CalendarTimeProperties.Mask.SaveLiteral = (DirectCast(resources.GetObject("deDueDate.Properties.CalendarTimeProperties.Mask.SaveLiteral"), Boolean))
            Me.deDueDate.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders = (DirectCast(resources.GetObject("deDueDate.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders"), Boolean))
            Me.deDueDate.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = (DirectCast(resources.GetObject("deDueDate.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat"), Boolean))
            Me.deDueDate.Properties.CalendarTimeProperties.NullValuePrompt = resources.GetString("deDueDate.Properties.CalendarTimeProperties.NullValuePrompt")
            Me.deDueDate.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue = (DirectCast(resources.GetObject("deDueDate.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.deDueDate.Properties.Mask.AutoComplete = (DirectCast(resources.GetObject("deDueDate.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
            Me.deDueDate.Properties.Mask.BeepOnError = (DirectCast(resources.GetObject("deDueDate.Properties.Mask.BeepOnError"), Boolean))
            Me.deDueDate.Properties.Mask.EditMask = resources.GetString("deDueDate.Properties.Mask.EditMask")
            Me.deDueDate.Properties.Mask.IgnoreMaskBlank = (DirectCast(resources.GetObject("deDueDate.Properties.Mask.IgnoreMaskBlank"), Boolean))
            Me.deDueDate.Properties.Mask.MaskType = (DirectCast(resources.GetObject("deDueDate.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.deDueDate.Properties.Mask.PlaceHolder = (DirectCast(resources.GetObject("deDueDate.Properties.Mask.PlaceHolder"), Char))
            Me.deDueDate.Properties.Mask.SaveLiteral = (DirectCast(resources.GetObject("deDueDate.Properties.Mask.SaveLiteral"), Boolean))
            Me.deDueDate.Properties.Mask.ShowPlaceHolders = (DirectCast(resources.GetObject("deDueDate.Properties.Mask.ShowPlaceHolders"), Boolean))
            Me.deDueDate.Properties.Mask.UseMaskAsDisplayFormat = (DirectCast(resources.GetObject("deDueDate.Properties.Mask.UseMaskAsDisplayFormat"), Boolean))
            Me.deDueDate.Properties.NullValuePrompt = resources.GetString("deDueDate.Properties.NullValuePrompt")
            Me.deDueDate.Properties.NullValuePromptShowForEmptyValue = (DirectCast(resources.GetObject("deDueDate.Properties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.deDueDate.StyleController = Me.lcMain
            ' 
            ' sbOK
            ' 
            resources.ApplyResources(Me.sbOK, "sbOK")
            Me.sbOK.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.sbOK.Name = "sbOK"
            Me.sbOK.StyleController = Me.lcMain
            ' 
            ' teSubject
            ' 
            resources.ApplyResources(Me.teSubject, "teSubject")
            Me.teSubject.Name = "teSubject"
            Me.teSubject.Properties.AccessibleDescription = resources.GetString("teSubject.Properties.AccessibleDescription")
            Me.teSubject.Properties.AccessibleName = resources.GetString("teSubject.Properties.AccessibleName")
            Me.teSubject.Properties.AutoHeight = (DirectCast(resources.GetObject("teSubject.Properties.AutoHeight"), Boolean))
            Me.teSubject.Properties.Mask.AutoComplete = (DirectCast(resources.GetObject("teSubject.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
            Me.teSubject.Properties.Mask.BeepOnError = (DirectCast(resources.GetObject("teSubject.Properties.Mask.BeepOnError"), Boolean))
            Me.teSubject.Properties.Mask.EditMask = resources.GetString("teSubject.Properties.Mask.EditMask")
            Me.teSubject.Properties.Mask.IgnoreMaskBlank = (DirectCast(resources.GetObject("teSubject.Properties.Mask.IgnoreMaskBlank"), Boolean))
            Me.teSubject.Properties.Mask.MaskType = (DirectCast(resources.GetObject("teSubject.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.teSubject.Properties.Mask.PlaceHolder = (DirectCast(resources.GetObject("teSubject.Properties.Mask.PlaceHolder"), Char))
            Me.teSubject.Properties.Mask.SaveLiteral = (DirectCast(resources.GetObject("teSubject.Properties.Mask.SaveLiteral"), Boolean))
            Me.teSubject.Properties.Mask.ShowPlaceHolders = (DirectCast(resources.GetObject("teSubject.Properties.Mask.ShowPlaceHolders"), Boolean))
            Me.teSubject.Properties.Mask.UseMaskAsDisplayFormat = (DirectCast(resources.GetObject("teSubject.Properties.Mask.UseMaskAsDisplayFormat"), Boolean))
            Me.teSubject.Properties.NullValuePrompt = resources.GetString("teSubject.Properties.NullValuePrompt")
            Me.teSubject.Properties.NullValuePromptShowForEmptyValue = (DirectCast(resources.GetObject("teSubject.Properties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.teSubject.StyleController = Me.lcMain
            ' 
            ' layoutControlGroup1
            ' 
            resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciSubject, Me.lciDescription, Me.emptySpaceItem3, Me.emptySpaceItem2, Me.layoutControlItem2, Me.layoutControlItem1, Me.lciCategory, Me.lciStartDate, Me.lciDueDate, Me.lciStatus, Me.lciPriority, Me.lciPercentComplete, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(671, 481)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' lciSubject
            ' 
            Me.lciSubject.Control = Me.teSubject
            resources.ApplyResources(Me.lciSubject, "lciSubject")
            Me.lciSubject.Location = New System.Drawing.Point(0, 0)
            Me.lciSubject.Name = "lciSubject"
            Me.lciSubject.Size = New System.Drawing.Size(467, 24)
            Me.lciSubject.TextSize = New System.Drawing.Size(63, 13)
            ' 
            ' lciDescription
            ' 
            Me.lciDescription.Control = Me.richEditControl1
            resources.ApplyResources(Me.lciDescription, "lciDescription")
            Me.lciDescription.Location = New System.Drawing.Point(0, 72)
            Me.lciDescription.Name = "lciDescription"
            Me.lciDescription.Size = New System.Drawing.Size(651, 357)
            Me.lciDescription.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciDescription.TextSize = New System.Drawing.Size(63, 13)
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem3, "emptySpaceItem3")
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 429)
            Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 6)
            Me.emptySpaceItem3.MinSize = New System.Drawing.Size(10, 6)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.emptySpaceItem3.Size = New System.Drawing.Size(651, 6)
            Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem2, "emptySpaceItem2")
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 435)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(466, 26)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.sbCancel
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.Location = New System.Drawing.Point(554, 435)
            Me.layoutControlItem2.MaxSize = New System.Drawing.Size(97, 26)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(97, 26)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(97, 26)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.sbOK
            resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
            Me.layoutControlItem1.Location = New System.Drawing.Point(466, 435)
            Me.layoutControlItem1.MaxSize = New System.Drawing.Size(88, 26)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(88, 26)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(88, 26)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' lciCategory
            ' 
            Me.lciCategory.Control = Me.icbCategory
            resources.ApplyResources(Me.lciCategory, "lciCategory")
            Me.lciCategory.Location = New System.Drawing.Point(467, 0)
            Me.lciCategory.Name = "lciCategory"
            Me.lciCategory.Size = New System.Drawing.Size(184, 24)
            Me.lciCategory.TextSize = New System.Drawing.Size(63, 13)
            ' 
            ' lciStartDate
            ' 
            Me.lciStartDate.Control = Me.deStartDate
            resources.ApplyResources(Me.lciStartDate, "lciStartDate")
            Me.lciStartDate.Location = New System.Drawing.Point(0, 24)
            Me.lciStartDate.Name = "lciStartDate"
            Me.lciStartDate.Size = New System.Drawing.Size(210, 24)
            Me.lciStartDate.TextSize = New System.Drawing.Size(63, 13)
            ' 
            ' lciDueDate
            ' 
            Me.lciDueDate.Control = Me.deDueDate
            resources.ApplyResources(Me.lciDueDate, "lciDueDate")
            Me.lciDueDate.Location = New System.Drawing.Point(0, 48)
            Me.lciDueDate.Name = "lciDueDate"
            Me.lciDueDate.Size = New System.Drawing.Size(210, 24)
            Me.lciDueDate.TextSize = New System.Drawing.Size(63, 13)
            ' 
            ' lciStatus
            ' 
            Me.lciStatus.Control = Me.icbStatus
            resources.ApplyResources(Me.lciStatus, "lciStatus")
            Me.lciStatus.Location = New System.Drawing.Point(210, 24)
            Me.lciStatus.Name = "lciStatus"
            Me.lciStatus.Size = New System.Drawing.Size(257, 24)
            Me.lciStatus.TextSize = New System.Drawing.Size(63, 13)
            ' 
            ' lciPriority
            ' 
            Me.lciPriority.Control = Me.icbPriority
            resources.ApplyResources(Me.lciPriority, "lciPriority")
            Me.lciPriority.Location = New System.Drawing.Point(210, 48)
            Me.lciPriority.Name = "lciPriority"
            Me.lciPriority.Size = New System.Drawing.Size(257, 24)
            Me.lciPriority.TextSize = New System.Drawing.Size(63, 13)
            ' 
            ' lciPercentComplete
            ' 
            Me.lciPercentComplete.Control = Me.sePercentComplete
            resources.ApplyResources(Me.lciPercentComplete, "lciPercentComplete")
            Me.lciPercentComplete.Location = New System.Drawing.Point(467, 48)
            Me.lciPercentComplete.Name = "lciPercentComplete"
            Me.lciPercentComplete.Size = New System.Drawing.Size(184, 24)
            Me.lciPercentComplete.TextSize = New System.Drawing.Size(63, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem1, "emptySpaceItem1")
            Me.emptySpaceItem1.Location = New System.Drawing.Point(467, 24)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(184, 24)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' ucContactInfo1
            ' 
            resources.ApplyResources(Me.ucContactInfo1, "ucContactInfo1")
            Me.ucContactInfo1.Name = "ucContactInfo1"
            Me.ucContactInfo1.ZoomFactor = 1F
            ' 
            ' richEditBarController1
            ' 
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
            Me.richEditBarController1.BarItems.Add(Me.changeFontBackColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTextCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.makeTextUpperCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.makeTextLowerCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTextCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.clearFormattingItem1)
            Me.richEditBarController1.BarItems.Add(Me.showFontFormItem1)
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
            Me.richEditBarController1.BarItems.Add(Me.showParagraphFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeStyleItem1)
            Me.richEditBarController1.BarItems.Add(Me.showEditStyleFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.findItem1)
            Me.richEditBarController1.BarItems.Add(Me.replaceItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageBreakItem1)
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
            Me.richEditBarController1.BarItems.Add(Me.changeTableCellsShadingItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTableBordersItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsBottomBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsTopBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsLeftBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsRightBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.resetTableCellsAllBordersItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsAllBordersItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsOutsideBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsInsideBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsInsideHorizontalBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsInsideVerticalBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleShowTableGridLinesItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTableBorderLineStyleItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTableBorderLineWeightItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTableBorderColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.selectTableElementsItem1)
            Me.richEditBarController1.BarItems.Add(Me.selectTableCellItem1)
            Me.richEditBarController1.BarItems.Add(Me.selectTableColumnItem1)
            Me.richEditBarController1.BarItems.Add(Me.selectTableRowItem1)
            Me.richEditBarController1.BarItems.Add(Me.selectTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.showTablePropertiesFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.deleteTableElementsItem1)
            Me.richEditBarController1.BarItems.Add(Me.showDeleteTableCellsFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.deleteTableColumnsItem1)
            Me.richEditBarController1.BarItems.Add(Me.deleteTableRowsItem1)
            Me.richEditBarController1.BarItems.Add(Me.deleteTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableRowAboveItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableRowBelowItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableColumnToLeftItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableColumnToRightItem1)
            Me.richEditBarController1.BarItems.Add(Me.showInsertTableCellsFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.mergeTableCellsItem1)
            Me.richEditBarController1.BarItems.Add(Me.showSplitTableCellsForm1)
            Me.richEditBarController1.BarItems.Add(Me.splitTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableAutoFitItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableAutoFitContentsItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableAutoFitWindowItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableFixedColumnWidthItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsTopLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsMiddleLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsBottomLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsTopCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsMiddleCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsBottomCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsTopRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsMiddleRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsBottomRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFloatingObjectFillColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFloatingObjectOutlineColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFloatingObjectOutlineWeightItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFloatingObjectTextWrapTypeItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectSquareTextWrapTypeItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectTightTextWrapTypeItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectThroughTextWrapTypeItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectTopAndBottomTextWrapTypeItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectBehindTextWrapTypeItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectInFrontOfTextWrapTypeItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFloatingObjectAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectTopLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectTopCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectTopRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectMiddleLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectMiddleCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectMiddleRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectBottomLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectBottomCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectBottomRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.floatingObjectBringForwardSubItem1)
            Me.richEditBarController1.BarItems.Add(Me.floatingObjectBringForwardItem1)
            Me.richEditBarController1.BarItems.Add(Me.floatingObjectBringToFrontItem1)
            Me.richEditBarController1.BarItems.Add(Me.floatingObjectBringInFrontOfTextItem1)
            Me.richEditBarController1.BarItems.Add(Me.floatingObjectSendBackwardSubItem1)
            Me.richEditBarController1.BarItems.Add(Me.floatingObjectSendBackwardItem1)
            Me.richEditBarController1.BarItems.Add(Me.floatingObjectSendToBackItem1)
            Me.richEditBarController1.BarItems.Add(Me.floatingObjectSendBehindTextItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileNewItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileOpenItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileSaveItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileSaveAsItem1)
            Me.richEditBarController1.BarItems.Add(Me.quickPrintItem1)
            Me.richEditBarController1.BarItems.Add(Me.printItem1)
            Me.richEditBarController1.BarItems.Add(Me.printPreviewItem1)
            Me.richEditBarController1.BarItems.Add(Me.undoItem1)
            Me.richEditBarController1.BarItems.Add(Me.redoItem1)
            Me.richEditBarController1.Control = Me.richEditControl1
            ' 
            ' showFontFormItem1
            ' 
            resources.ApplyResources(Me.showFontFormItem1, "showFontFormItem1")
            Me.showFontFormItem1.Id = -1
            Me.showFontFormItem1.Name = "showFontFormItem1"
            ' 
            ' showParagraphFormItem1
            ' 
            resources.ApplyResources(Me.showParagraphFormItem1, "showParagraphFormItem1")
            Me.showParagraphFormItem1.Id = -1
            Me.showParagraphFormItem1.Name = "showParagraphFormItem1"
            ' 
            ' showEditStyleFormItem1
            ' 
            resources.ApplyResources(Me.showEditStyleFormItem1, "showEditStyleFormItem1")
            Me.showEditStyleFormItem1.Id = -1
            Me.showEditStyleFormItem1.Name = "showEditStyleFormItem1"
            ' 
            ' showInsertTableCellsFormItem1
            ' 
            resources.ApplyResources(Me.showInsertTableCellsFormItem1, "showInsertTableCellsFormItem1")
            Me.showInsertTableCellsFormItem1.Id = -1
            Me.showInsertTableCellsFormItem1.Name = "showInsertTableCellsFormItem1"
            ' 
            ' dxValidationProvider1
            ' 
            Me.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto
            ' 
            ' frmEditTask
            '
            Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
            Me.Name = "frmEditTask"
            Me.Ribbon = Me.ribbonControl1
            DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            DirectCast(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
            Me.lcMain.ResumeLayout(False)
            DirectCast(Me.sePercentComplete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemFloatingObjectOutlineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.icbPriority.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.icEditors, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.icbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.deStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.deStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.icbCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.icCategory, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.deDueDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.deDueDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.teSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciSubject, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciDescription, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciCategory, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciStartDate, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciDueDate, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciStatus, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciPriority, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciPercentComplete, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private lcMain As DevExpress.XtraLayout.LayoutControl
        Private teSubject As DevExpress.XtraEditors.TextEdit
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private lciSubject As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents sbOK As DevExpress.XtraEditors.SimpleButton
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
        Private sbCancel As DevExpress.XtraEditors.SimpleButton
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
        Private WithEvents richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
        Private lciDescription As DevExpress.XtraLayout.LayoutControlItem
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
        Private cutItem1 As DevExpress.XtraRichEdit.UI.CutItem
        Private copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
        Private pasteSpecialItem1 As DevExpress.XtraRichEdit.UI.PasteSpecialItem
        Private barButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
        Private changeFontNameItem1 As DevExpress.XtraRichEdit.UI.ChangeFontNameItem
        Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
        Private changeFontSizeItem1 As DevExpress.XtraRichEdit.UI.ChangeFontSizeItem
        Private repositoryItemRichEditFontSizeEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
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
        Private changeFontBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem
        Private changeTextCaseItem1 As DevExpress.XtraRichEdit.UI.ChangeTextCaseItem
        Private makeTextUpperCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem
        Private makeTextLowerCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem
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
        Private changeStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeStyleItem
        Private repositoryItemRichEditStyleEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit
        Private findItem1 As DevExpress.XtraRichEdit.UI.FindItem
        Private replaceItem1 As DevExpress.XtraRichEdit.UI.ReplaceItem
        Private insertPageBreakItem1 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem
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
        Private homeRibbonPage1 As DevExpress.XtraRichEdit.UI.HomeRibbonPage
        Private clipboardRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup
        Private fontRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.FontRibbonPageGroup
        Private paragraphRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup
        Private stylesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup
        Private editingRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup
        Private insertRibbonPage1 As DevExpress.XtraRichEdit.UI.InsertRibbonPage
        Private pagesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup
        Private tablesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup
        Private illustrationsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup
        Private linksRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup
        Private headerFooterRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup
        Private textRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TextRibbonPageGroup
        Private symbolsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup
        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
        Private showFontFormItem1 As DevExpress.XtraRichEdit.UI.ShowFontFormItem
        Private showParagraphFormItem1 As DevExpress.XtraRichEdit.UI.ShowParagraphFormItem
        Private showEditStyleFormItem1 As DevExpress.XtraRichEdit.UI.ShowEditStyleFormItem
        Private changeTableCellsShadingItem1 As DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem
        Private changeTableBordersItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBordersItem
        Private toggleTableCellsBottomBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem
        Private toggleTableCellsTopBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem
        Private toggleTableCellsLeftBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem
        Private toggleTableCellsRightBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem
        Private resetTableCellsAllBordersItem1 As DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem
        Private toggleTableCellsAllBordersItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem
        Private toggleTableCellsOutsideBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem
        Private toggleTableCellsInsideBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem
        Private toggleTableCellsInsideHorizontalBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem
        Private toggleTableCellsInsideVerticalBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem
        Private toggleShowTableGridLinesItem1 As DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem
        Private changeTableBorderLineStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem
        Private repositoryItemBorderLineStyle1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle
        Private changeTableBorderLineWeightItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem
        Private repositoryItemBorderLineWeight1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight
        Private changeTableBorderColorItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem
        Private selectTableElementsItem1 As DevExpress.XtraRichEdit.UI.SelectTableElementsItem
        Private selectTableCellItem1 As DevExpress.XtraRichEdit.UI.SelectTableCellItem
        Private selectTableColumnItem1 As DevExpress.XtraRichEdit.UI.SelectTableColumnItem
        Private selectTableRowItem1 As DevExpress.XtraRichEdit.UI.SelectTableRowItem
        Private selectTableItem1 As DevExpress.XtraRichEdit.UI.SelectTableItem
        Private showTablePropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem
        Private deleteTableElementsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableElementsItem
        Private showDeleteTableCellsFormItem1 As DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem
        Private deleteTableColumnsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem
        Private deleteTableRowsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableRowsItem
        Private deleteTableItem1 As DevExpress.XtraRichEdit.UI.DeleteTableItem
        Private insertTableRowAboveItem1 As DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem
        Private insertTableRowBelowItem1 As DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem
        Private insertTableColumnToLeftItem1 As DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem
        Private insertTableColumnToRightItem1 As DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem
        Private mergeTableCellsItem1 As DevExpress.XtraRichEdit.UI.MergeTableCellsItem
        Private showSplitTableCellsForm1 As DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm
        Private splitTableItem1 As DevExpress.XtraRichEdit.UI.SplitTableItem
        Private toggleTableAutoFitItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem
        Private toggleTableAutoFitContentsItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem
        Private toggleTableAutoFitWindowItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem
        Private toggleTableFixedColumnWidthItem1 As DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem
        Private toggleTableCellsTopLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem
        Private toggleTableCellsMiddleLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem
        Private toggleTableCellsBottomLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem
        Private toggleTableCellsTopCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem
        Private toggleTableCellsMiddleCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem
        Private toggleTableCellsBottomCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem
        Private toggleTableCellsTopRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem
        Private toggleTableCellsMiddleRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem
        Private toggleTableCellsBottomRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem
        Private tableToolsRibbonPageCategory1 As DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory
        Private tableDesignRibbonPage1 As DevExpress.XtraRichEdit.UI.TableDesignRibbonPage
        Private tableStylesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup
        Private tableDrawBordersRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup
        Private tableLayoutRibbonPage1 As DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage
        Private tableTableRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup
        Private tableRowsAndColumnsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup
        Private tableMergeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup
        Private tableCellSizeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup
        Private tableAlignmentRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup
        Private showInsertTableCellsFormItem1 As DevExpress.XtraRichEdit.UI.ShowInsertTableCellsFormItem
        Private changeFloatingObjectFillColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectFillColorItem
        Private changeFloatingObjectOutlineColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineColorItem
        Private changeFloatingObjectOutlineWeightItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineWeightItem
        Private repositoryItemFloatingObjectOutlineWeight1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight
        Private changeFloatingObjectTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectTextWrapTypeItem
        Private setFloatingObjectSquareTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectSquareTextWrapTypeItem
        Private setFloatingObjectTightTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTightTextWrapTypeItem
        Private setFloatingObjectThroughTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectThroughTextWrapTypeItem
        Private setFloatingObjectTopAndBottomTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopAndBottomTextWrapTypeItem
        Private setFloatingObjectBehindTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBehindTextWrapTypeItem
        Private setFloatingObjectInFrontOfTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectInFrontOfTextWrapTypeItem
        Private changeFloatingObjectAlignmentItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectAlignmentItem
        Private setFloatingObjectTopLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopLeftAlignmentItem
        Private setFloatingObjectTopCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopCenterAlignmentItem
        Private setFloatingObjectTopRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopRightAlignmentItem
        Private setFloatingObjectMiddleLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleLeftAlignmentItem
        Private setFloatingObjectMiddleCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleCenterAlignmentItem
        Private setFloatingObjectMiddleRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleRightAlignmentItem
        Private setFloatingObjectBottomLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomLeftAlignmentItem
        Private setFloatingObjectBottomCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomCenterAlignmentItem
        Private setFloatingObjectBottomRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomRightAlignmentItem
        Private floatingObjectBringForwardSubItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardSubItem
        Private floatingObjectBringForwardItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardItem
        Private floatingObjectBringToFrontItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringToFrontItem
        Private floatingObjectBringInFrontOfTextItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringInFrontOfTextItem
        Private floatingObjectSendBackwardSubItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardSubItem
        Private floatingObjectSendBackwardItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardItem
        Private floatingObjectSendToBackItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendToBackItem
        Private floatingObjectSendBehindTextItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendBehindTextItem
        Private floatingPictureToolsRibbonPageCategory1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsRibbonPageCategory
        Private floatingPictureToolsFormatPage1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsFormatPage
        Private floatingPictureToolsShapeStylesPageGroup1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsShapeStylesPageGroup
        Private floatingPictureToolsArrangePageGroup1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsArrangePageGroup
        Private fileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem
        Private fileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
        Private fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
        Private fileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
        Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
        Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem
        Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
        Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
        Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
        Private dxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
        Private icbPriority As DevExpress.XtraEditors.ImageComboBoxEdit
        Private WithEvents icbStatus As DevExpress.XtraEditors.ImageComboBoxEdit
        Private deDueDate As DevExpress.XtraEditors.DateEdit
        Private deStartDate As DevExpress.XtraEditors.DateEdit
        Private icbCategory As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lciCategory As DevExpress.XtraLayout.LayoutControlItem
        Private lciStartDate As DevExpress.XtraLayout.LayoutControlItem
        Private lciDueDate As DevExpress.XtraLayout.LayoutControlItem
        Private lciStatus As DevExpress.XtraLayout.LayoutControlItem
        Private lciPriority As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents sePercentComplete As DevExpress.XtraEditors.SpinEdit
        Private lciPercentComplete As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Private icCategory As DevExpress.Utils.ImageCollection
        Private icEditors As DevExpress.Utils.ImageCollection
        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private ucContactInfo1 As DevExpress.MailClient.Win.Controls.ucContactInfo
    End Class
End Namespace
