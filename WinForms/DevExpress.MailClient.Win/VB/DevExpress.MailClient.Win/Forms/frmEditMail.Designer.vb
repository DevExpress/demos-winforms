Namespace DevExpress.MailClient.Win
    Partial Public Class frmEditMail
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmEditMail))
            Dim optionsSpelling1 As New DevExpress.XtraSpellChecker.OptionsSpelling()
            Dim optionsSpelling2 As New DevExpress.XtraSpellChecker.OptionsSpelling()
            Dim buttonImageOptions1 As New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
            Dim buttonImageOptions2 As New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
            Dim buttonImageOptions3 As New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
            Dim buttonImageOptions4 As New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.flyoutPanel1 = New DevExpress.Utils.FlyoutPanel()
            Me.lblDescription = New DevExpress.XtraEditors.LabelControl()
            Me.lblMail = New DevExpress.XtraEditors.LabelControl()
            Me.picContact = New DevExpress.XtraEditors.PictureEdit()
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.applicationMenu = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
            Me.fileSaveItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
            Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
            Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
            Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
            Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
            Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
            Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
            Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
            Me.pasteSpecialItem1 = New DevExpress.XtraRichEdit.UI.PasteSpecialItem()
            Me.barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
            Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.spellChecker1 = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
            Me.edtSubject = New DevExpress.XtraEditors.TextEdit()
            Me.fontSizeIncreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem()
            Me.fontSizeDecreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem()
            Me.barButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
            Me.toggleFontBoldItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontBoldItem()
            Me.toggleFontItalicItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontItalicItem()
            Me.toggleFontUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem()
            Me.barButtonGroup3 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeFontColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontColorItem()
            Me.changeFontBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem()
            Me.barButtonGroup4 = New DevExpress.XtraBars.BarButtonGroup()
            Me.toggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.ToggleBulletedListItem()
            Me.toggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.ToggleNumberingListItem()
            Me.barButtonGroup5 = New DevExpress.XtraBars.BarButtonGroup()
            Me.decreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.DecreaseIndentItem()
            Me.increaseIndentItem1 = New DevExpress.XtraRichEdit.UI.IncreaseIndentItem()
            Me.barButtonGroup6 = New DevExpress.XtraBars.BarButtonGroup()
            Me.toggleParagraphAlignmentLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem()
            Me.toggleParagraphAlignmentCenterItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem()
            Me.toggleParagraphAlignmentRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem()
            Me.barButtonGroup7 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeParagraphBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem()
            Me.findItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
            Me.replaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem()
            Me.insertTableItem1 = New DevExpress.XtraRichEdit.UI.InsertTableItem()
            Me.insertPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertPictureItem()
            Me.insertFloatingPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem()
            Me.insertHyperlinkItem1 = New DevExpress.XtraRichEdit.UI.InsertHyperlinkItem()
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
            Me.editingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup()
            Me.insertRibbonPage1 = New DevExpress.XtraRichEdit.UI.InsertRibbonPage()
            Me.tablesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup()
            Me.illustrationsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup()
            Me.linksRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup()
            Me.textRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TextRibbonPageGroup()
            Me.symbolsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup()
            Me.repositoryItemRichEditStyleEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit()
            Me.statusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.buttonPanel = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonPanelControl()
            Me.buttonPanelTooltipController = New DevExpress.Utils.ToolTipController(Me.components)
            Me.edtTo = New DevExpress.XtraEditors.TokenEdit()
            Me.panelControl = New DevExpress.XtraEditors.PanelControl()
            Me.lblTo = New DevExpress.XtraEditors.LabelControl()
            Me.lblSubject = New DevExpress.XtraEditors.LabelControl()
            Me.ucMessageInfo1 = New DevExpress.MailClient.Win.Controls.ucMessageInfo()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController(Me.components)
            Me.showFontFormItem1 = New DevExpress.XtraRichEdit.UI.ShowFontFormItem()
            Me.showParagraphFormItem1 = New DevExpress.XtraRichEdit.UI.ShowParagraphFormItem()
            Me.showEditStyleFormItem1 = New DevExpress.XtraRichEdit.UI.ShowEditStyleFormItem()
            Me.showInsertTableCellsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowInsertTableCellsFormItem()
            DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            DirectCast(Me.flyoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flyoutPanel1.SuspendLayout()
            DirectCast(Me.picContact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.applicationMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemFloatingObjectOutlineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            DirectCast(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2
            resources.ApplyResources(Me.splitContainerControl1, "splitContainerControl1")
            Me.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
            Me.splitContainerControl1.Horizontal = False
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.flyoutPanel1)
            Me.splitContainerControl1.Panel1.Controls.Add(Me.richEditControl)
            Me.splitContainerControl1.Panel1.Controls.Add(Me.panelControl)
            resources.ApplyResources(Me.splitContainerControl1.Panel1, "splitContainerControl1.Panel1")
            Me.splitContainerControl1.Panel2.Controls.Add(Me.ucMessageInfo1)
            resources.ApplyResources(Me.splitContainerControl1.Panel2, "splitContainerControl1.Panel2")
            Me.splitContainerControl1.SplitterPosition = 147
            ' 
            ' flyoutPanel1
            ' 
            Me.flyoutPanel1.Controls.Add(Me.lblDescription)
            Me.flyoutPanel1.Controls.Add(Me.lblMail)
            Me.flyoutPanel1.Controls.Add(Me.picContact)
            Me.flyoutPanel1.Controls.Add(Me.buttonPanel)
            resources.ApplyResources(Me.flyoutPanel1, "flyoutPanel1")
            Me.flyoutPanel1.Name = "flyoutPanel1"
            Me.flyoutPanel1.OwnerControl = Me.edtTo
            ' 
            ' lblDescription
            ' 
            resources.ApplyResources(Me.lblDescription, "lblDescription")
            Me.lblDescription.Name = "lblDescription"
            ' 
            ' lblMail
            ' 
            Me.lblMail.Appearance.Font = (DirectCast(resources.GetObject("lblMail.Appearance.Font"), System.Drawing.Font))
            Me.lblMail.Appearance.Options.UseFont = True
            resources.ApplyResources(Me.lblMail, "lblMail")
            Me.lblMail.Name = "lblMail"
            ' 
            ' picContact
            ' 
            Me.picContact.Cursor = System.Windows.Forms.Cursors.Default
            Me.picContact.EditValue = My.Resources.Unknown_user
            resources.ApplyResources(Me.picContact, "picContact")
            Me.picContact.MenuManager = Me.ribbonControl
            Me.picContact.Name = "picContact"
            Me.picContact.Properties.AllowFocused = False
            Me.picContact.Properties.Appearance.BackColor = (DirectCast(resources.GetObject("picContact.Properties.Appearance.BackColor"), System.Drawing.Color))
            Me.picContact.Properties.Appearance.Options.UseBackColor = True
            Me.picContact.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.picContact.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Circle
            Me.picContact.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            Me.picContact.Properties.ShowMenu = False
            Me.picContact.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
            ' 
            ' ribbonControl
            ' 
            Me.ribbonControl.ApplicationButtonDropDownControl = Me.applicationMenu
            resources.ApplyResources(Me.ribbonControl, "ribbonControl")
            Me.ribbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Teal
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl.ExpandCollapseItem, Me.fileSaveItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.undoItem1, Me.redoItem1, Me.pasteItem1, Me.cutItem1, Me.copyItem1, Me.pasteSpecialItem1, Me.barButtonGroup1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.barButtonGroup2, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.toggleFontUnderlineItem1, Me.barButtonGroup3, Me.changeFontColorItem1, Me.changeFontBackColorItem1, Me.barButtonGroup4, Me.toggleBulletedListItem1, Me.toggleNumberingListItem1, Me.barButtonGroup5, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.barButtonGroup6, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.barButtonGroup7, Me.changeParagraphBackColorItem1, Me.findItem1, Me.replaceItem1, Me.insertTableItem1, Me.insertPictureItem1, Me.insertFloatingPictureItem1, Me.insertHyperlinkItem1, Me.insertTextBoxItem1, Me.insertSymbolItem1, Me.changeTableCellsShadingItem1, Me.changeTableBordersItem1, Me.toggleTableCellsBottomBorderItem1, Me.toggleTableCellsTopBorderItem1, Me.toggleTableCellsLeftBorderItem1, Me.toggleTableCellsRightBorderItem1, Me.resetTableCellsAllBordersItem1, Me.toggleTableCellsAllBordersItem1, Me.toggleTableCellsOutsideBorderItem1, Me.toggleTableCellsInsideBorderItem1, Me.toggleTableCellsInsideHorizontalBorderItem1, Me.toggleTableCellsInsideVerticalBorderItem1, Me.toggleShowTableGridLinesItem1, Me.changeTableBorderLineStyleItem1, Me.changeTableBorderLineWeightItem1, Me.changeTableBorderColorItem1, Me.selectTableElementsItem1, Me.selectTableCellItem1, Me.selectTableColumnItem1, Me.selectTableRowItem1, Me.selectTableItem1, Me.showTablePropertiesFormItem1, Me.deleteTableElementsItem1, Me.showDeleteTableCellsFormItem1, Me.deleteTableColumnsItem1, Me.deleteTableRowsItem1, Me.deleteTableItem1, Me.insertTableRowAboveItem1, Me.insertTableRowBelowItem1, Me.insertTableColumnToLeftItem1, Me.insertTableColumnToRightItem1, Me.mergeTableCellsItem1, Me.showSplitTableCellsForm1, Me.splitTableItem1, Me.toggleTableAutoFitItem1, Me.toggleTableAutoFitContentsItem1, Me.toggleTableAutoFitWindowItem1, Me.toggleTableFixedColumnWidthItem1, Me.toggleTableCellsTopLeftAlignmentItem1, Me.toggleTableCellsMiddleLeftAlignmentItem1, Me.toggleTableCellsBottomLeftAlignmentItem1, Me.toggleTableCellsTopCenterAlignmentItem1, Me.toggleTableCellsMiddleCenterAlignmentItem1, Me.toggleTableCellsBottomCenterAlignmentItem1, Me.toggleTableCellsTopRightAlignmentItem1, Me.toggleTableCellsMiddleRightAlignmentItem1, Me.toggleTableCellsBottomRightAlignmentItem1, Me.changeFloatingObjectFillColorItem1, Me.changeFloatingObjectOutlineColorItem1, Me.changeFloatingObjectOutlineWeightItem1, Me.changeFloatingObjectTextWrapTypeItem1, Me.setFloatingObjectSquareTextWrapTypeItem1, Me.setFloatingObjectTightTextWrapTypeItem1, Me.setFloatingObjectThroughTextWrapTypeItem1, Me.setFloatingObjectTopAndBottomTextWrapTypeItem1, Me.setFloatingObjectBehindTextWrapTypeItem1, Me.setFloatingObjectInFrontOfTextWrapTypeItem1, Me.changeFloatingObjectAlignmentItem1, Me.setFloatingObjectTopLeftAlignmentItem1, Me.setFloatingObjectTopCenterAlignmentItem1, Me.setFloatingObjectTopRightAlignmentItem1, Me.setFloatingObjectMiddleLeftAlignmentItem1, Me.setFloatingObjectMiddleCenterAlignmentItem1, Me.setFloatingObjectMiddleRightAlignmentItem1, Me.setFloatingObjectBottomLeftAlignmentItem1, Me.setFloatingObjectBottomCenterAlignmentItem1, Me.setFloatingObjectBottomRightAlignmentItem1, Me.floatingObjectBringForwardSubItem1, Me.floatingObjectBringForwardItem1, Me.floatingObjectBringToFrontItem1, Me.floatingObjectBringInFrontOfTextItem1, Me.floatingObjectSendBackwardSubItem1, Me.floatingObjectSendBackwardItem1, Me.floatingObjectSendToBackItem1, Me.floatingObjectSendBehindTextItem1})
            Me.ribbonControl.MaxItemId = 150
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() { Me.tableToolsRibbonPageCategory1, Me.floatingPictureToolsRibbonPageCategory1})
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.homeRibbonPage1, Me.insertRibbonPage1})
            Me.ribbonControl.QuickToolbarItemLinks.Add(Me.fileSaveItem1)
            Me.ribbonControl.QuickToolbarItemLinks.Add(Me.undoItem1)
            Me.ribbonControl.QuickToolbarItemLinks.Add(Me.redoItem1)
            Me.ribbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1, Me.repositoryItemRichEditStyleEdit1, Me.repositoryItemBorderLineStyle1, Me.repositoryItemBorderLineWeight1, Me.repositoryItemFloatingObjectOutlineWeight1})
            Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
            Me.ribbonControl.StatusBar = Me.statusBar
            ' 
            ' applicationMenu
            ' 
            Me.applicationMenu.ItemLinks.Add(Me.fileSaveItem1)
            Me.applicationMenu.ItemLinks.Add(Me.quickPrintItem1)
            Me.applicationMenu.ItemLinks.Add(Me.printItem1, "P")
            Me.applicationMenu.ItemLinks.Add(Me.printPreviewItem1)
            Me.applicationMenu.Name = "applicationMenu"
            Me.applicationMenu.Ribbon = Me.ribbonControl
            ' 
            ' fileSaveItem1
            ' 
            resources.ApplyResources(Me.fileSaveItem1, "fileSaveItem1")
            Me.fileSaveItem1.Id = 3
            Me.fileSaveItem1.ImageOptions.Image = My.Resources.Save_16x16
            Me.fileSaveItem1.ImageOptions.LargeImage = My.Resources.Save_32x32
            Me.fileSaveItem1.Name = "fileSaveItem1"
            ' 
            ' quickPrintItem1
            ' 
            Me.quickPrintItem1.Id = 5
            Me.quickPrintItem1.Name = "quickPrintItem1"
            ' 
            ' printItem1
            ' 
            Me.printItem1.Id = 6
            Me.printItem1.Name = "printItem1"
            ' 
            ' printPreviewItem1
            ' 
            Me.printPreviewItem1.Id = 7
            Me.printPreviewItem1.Name = "printPreviewItem1"
            ' 
            ' undoItem1
            ' 
            Me.undoItem1.Id = 8
            Me.undoItem1.Name = "undoItem1"
            ' 
            ' redoItem1
            ' 
            Me.redoItem1.Id = 9
            Me.redoItem1.Name = "redoItem1"
            ' 
            ' pasteItem1
            ' 
            Me.pasteItem1.Id = 17
            Me.pasteItem1.Name = "pasteItem1"
            ' 
            ' cutItem1
            ' 
            Me.cutItem1.Id = 18
            Me.cutItem1.Name = "cutItem1"
            ' 
            ' copyItem1
            ' 
            Me.copyItem1.Id = 19
            Me.copyItem1.Name = "copyItem1"
            ' 
            ' pasteSpecialItem1
            ' 
            Me.pasteSpecialItem1.Id = 20
            Me.pasteSpecialItem1.Name = "pasteSpecialItem1"
            ' 
            ' barButtonGroup1
            ' 
            Me.barButtonGroup1.Id = 10
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontNameItem1, "FF")
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontSizeItem1)
            Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeIncreaseItem1, "FG")
            Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeDecreaseItem1, "FK")
            Me.barButtonGroup1.Name = "barButtonGroup1"
            Me.barButtonGroup1.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}"
            ' 
            ' changeFontNameItem1
            ' 
            Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
            Me.changeFontNameItem1.Id = 21
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
            Me.changeFontSizeItem1.Edit = Me.repositoryItemRichEditFontSizeEdit1
            Me.changeFontSizeItem1.Id = 22
            Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
            ' 
            ' repositoryItemRichEditFontSizeEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemRichEditFontSizeEdit1, "repositoryItemRichEditFontSizeEdit1")
            Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemRichEditFontSizeEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemRichEditFontSizeEdit1.Control = Me.richEditControl
            Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
            ' 
            ' richEditControl
            ' 
            Me.richEditControl.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
            resources.ApplyResources(Me.richEditControl, "richEditControl")
            Me.richEditControl.MenuManager = Me.ribbonControl
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Options.Bookmarks.ConflictNameResolution = DevExpress.XtraRichEdit.ConflictNameAction.Skip
            Me.richEditControl.Options.DocumentCapabilities.Bookmarks = DevExpress.XtraRichEdit.DocumentCapability.Disabled
            Me.richEditControl.Options.DocumentCapabilities.HeadersFooters = DevExpress.XtraRichEdit.DocumentCapability.Disabled
            Me.richEditControl.Options.DocumentCapabilities.Sections = DevExpress.XtraRichEdit.DocumentCapability.Disabled
            Me.richEditControl.Options.DocumentSaveOptions.DefaultFormat = DevExpress.XtraRichEdit.DocumentFormat.Html
            Me.richEditControl.Options.Export.Html.EmbedImages = True
            Me.richEditControl.Options.Export.Html.HtmlNumberingListExportFormat = DevExpress.XtraRichEdit.Export.Html.HtmlNumberingListExportFormat.PlainTextFormat
            Me.richEditControl.Options.Export.Mht.HtmlNumberingListExportFormat = DevExpress.XtraRichEdit.Export.Html.HtmlNumberingListExportFormat.PlainTextFormat
            Me.richEditControl.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEditControl.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEditControl.SpellChecker = Me.spellChecker1
            Me.spellChecker1.SetSpellCheckerOptions(Me.richEditControl, optionsSpelling1)
            ' 
            ' spellChecker1
            ' 
            Me.spellChecker1.Culture = New System.Globalization.CultureInfo("en-US")
            Me.spellChecker1.ParentContainer = Nothing
            Me.spellChecker1.SpellCheckMode = DevExpress.XtraSpellChecker.SpellCheckMode.AsYouType
            ' 
            ' edtSubject
            ' 
            resources.ApplyResources(Me.edtSubject, "edtSubject")
            Me.edtSubject.MenuManager = Me.ribbonControl
            Me.edtSubject.Name = "edtSubject"
            Me.spellChecker1.SetShowSpellCheckMenu(Me.edtSubject, True)
            Me.spellChecker1.SetSpellCheckerOptions(Me.edtSubject, optionsSpelling2)
            ' 
            ' fontSizeIncreaseItem1
            ' 
            Me.fontSizeIncreaseItem1.Id = 23
            Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
            ' 
            ' fontSizeDecreaseItem1
            ' 
            Me.fontSizeDecreaseItem1.Id = 24
            Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
            ' 
            ' barButtonGroup2
            ' 
            Me.barButtonGroup2.Id = 11
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontBoldItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontItalicItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontUnderlineItem1)
            Me.barButtonGroup2.Name = "barButtonGroup2"
            Me.barButtonGroup2.Tag = "{433DA7F0-03E2-4650-9DB5-66DD92D16E39}"
            ' 
            ' toggleFontBoldItem1
            ' 
            Me.toggleFontBoldItem1.Id = 25
            Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
            ' 
            ' toggleFontItalicItem1
            ' 
            Me.toggleFontItalicItem1.Id = 26
            Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
            ' 
            ' toggleFontUnderlineItem1
            ' 
            Me.toggleFontUnderlineItem1.Id = 27
            Me.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
            ' 
            ' barButtonGroup3
            ' 
            Me.barButtonGroup3.Id = 12
            Me.barButtonGroup3.ItemLinks.Add(Me.changeFontColorItem1, "FC")
            Me.barButtonGroup3.ItemLinks.Add(Me.changeFontBackColorItem1, "I")
            Me.barButtonGroup3.Name = "barButtonGroup3"
            Me.barButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}"
            ' 
            ' changeFontColorItem1
            ' 
            Me.changeFontColorItem1.Id = 33
            Me.changeFontColorItem1.Name = "changeFontColorItem1"
            ' 
            ' changeFontBackColorItem1
            ' 
            Me.changeFontBackColorItem1.Id = 34
            Me.changeFontBackColorItem1.Name = "changeFontBackColorItem1"
            ' 
            ' barButtonGroup4
            ' 
            Me.barButtonGroup4.Id = 13
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleBulletedListItem1, "U")
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleNumberingListItem1, "N")
            Me.barButtonGroup4.Name = "barButtonGroup4"
            Me.barButtonGroup4.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
            ' 
            ' toggleBulletedListItem1
            ' 
            Me.toggleBulletedListItem1.Id = 40
            Me.toggleBulletedListItem1.Name = "toggleBulletedListItem1"
            ' 
            ' toggleNumberingListItem1
            ' 
            Me.toggleNumberingListItem1.Id = 41
            Me.toggleNumberingListItem1.Name = "toggleNumberingListItem1"
            ' 
            ' barButtonGroup5
            ' 
            Me.barButtonGroup5.Id = 14
            Me.barButtonGroup5.ItemLinks.Add(Me.decreaseIndentItem1, "AO")
            Me.barButtonGroup5.ItemLinks.Add(Me.increaseIndentItem1, "AI")
            Me.barButtonGroup5.Name = "barButtonGroup5"
            Me.barButtonGroup5.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}"
            ' 
            ' decreaseIndentItem1
            ' 
            Me.decreaseIndentItem1.Id = 43
            Me.decreaseIndentItem1.Name = "decreaseIndentItem1"
            ' 
            ' increaseIndentItem1
            ' 
            Me.increaseIndentItem1.Id = 44
            Me.increaseIndentItem1.Name = "increaseIndentItem1"
            ' 
            ' barButtonGroup6
            ' 
            Me.barButtonGroup6.Id = 15
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentLeftItem1, "AL")
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentCenterItem1, "AC")
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentRightItem1, "AR")
            Me.barButtonGroup6.Name = "barButtonGroup6"
            Me.barButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}"
            ' 
            ' toggleParagraphAlignmentLeftItem1
            ' 
            Me.toggleParagraphAlignmentLeftItem1.Id = 46
            Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
            ' 
            ' toggleParagraphAlignmentCenterItem1
            ' 
            Me.toggleParagraphAlignmentCenterItem1.Id = 47
            Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
            ' 
            ' toggleParagraphAlignmentRightItem1
            ' 
            Me.toggleParagraphAlignmentRightItem1.Id = 48
            Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
            ' 
            ' barButtonGroup7
            ' 
            Me.barButtonGroup7.Id = 16
            Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphBackColorItem1, "H")
            Me.barButtonGroup7.Name = "barButtonGroup7"
            Me.barButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}"
            ' 
            ' changeParagraphBackColorItem1
            ' 
            Me.changeParagraphBackColorItem1.Id = 59
            Me.changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1"
            ' 
            ' findItem1
            ' 
            Me.findItem1.Id = 61
            Me.findItem1.Name = "findItem1"
            ' 
            ' replaceItem1
            ' 
            Me.replaceItem1.Id = 62
            Me.replaceItem1.Name = "replaceItem1"
            ' 
            ' insertTableItem1
            ' 
            Me.insertTableItem1.Id = 64
            Me.insertTableItem1.Name = "insertTableItem1"
            ' 
            ' insertPictureItem1
            ' 
            Me.insertPictureItem1.Id = 65
            Me.insertPictureItem1.Name = "insertPictureItem1"
            ' 
            ' insertFloatingPictureItem1
            ' 
            Me.insertFloatingPictureItem1.Id = 66
            Me.insertFloatingPictureItem1.Name = "insertFloatingPictureItem1"
            ' 
            ' insertHyperlinkItem1
            ' 
            Me.insertHyperlinkItem1.Id = 68
            Me.insertHyperlinkItem1.Name = "insertHyperlinkItem1"
            ' 
            ' insertTextBoxItem1
            ' 
            Me.insertTextBoxItem1.Id = 73
            Me.insertTextBoxItem1.Name = "insertTextBoxItem1"
            ' 
            ' insertSymbolItem1
            ' 
            Me.insertSymbolItem1.Id = 74
            Me.insertSymbolItem1.Name = "insertSymbolItem1"
            ' 
            ' changeTableCellsShadingItem1
            ' 
            Me.changeTableCellsShadingItem1.Id = 75
            Me.changeTableCellsShadingItem1.Name = "changeTableCellsShadingItem1"
            ' 
            ' changeTableBordersItem1
            ' 
            Me.changeTableBordersItem1.Id = 76
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
                New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, Me.toggleShowTableGridLinesItem1, "", False, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard, "TG", "")
            })
            Me.changeTableBordersItem1.Name = "changeTableBordersItem1"
            ' 
            ' toggleTableCellsBottomBorderItem1
            ' 
            Me.toggleTableCellsBottomBorderItem1.Id = 77
            Me.toggleTableCellsBottomBorderItem1.Name = "toggleTableCellsBottomBorderItem1"
            ' 
            ' toggleTableCellsTopBorderItem1
            ' 
            Me.toggleTableCellsTopBorderItem1.Id = 78
            Me.toggleTableCellsTopBorderItem1.Name = "toggleTableCellsTopBorderItem1"
            ' 
            ' toggleTableCellsLeftBorderItem1
            ' 
            Me.toggleTableCellsLeftBorderItem1.Id = 79
            Me.toggleTableCellsLeftBorderItem1.Name = "toggleTableCellsLeftBorderItem1"
            ' 
            ' toggleTableCellsRightBorderItem1
            ' 
            Me.toggleTableCellsRightBorderItem1.Id = 80
            Me.toggleTableCellsRightBorderItem1.Name = "toggleTableCellsRightBorderItem1"
            ' 
            ' resetTableCellsAllBordersItem1
            ' 
            Me.resetTableCellsAllBordersItem1.Id = 81
            Me.resetTableCellsAllBordersItem1.Name = "resetTableCellsAllBordersItem1"
            ' 
            ' toggleTableCellsAllBordersItem1
            ' 
            Me.toggleTableCellsAllBordersItem1.Id = 82
            Me.toggleTableCellsAllBordersItem1.Name = "toggleTableCellsAllBordersItem1"
            ' 
            ' toggleTableCellsOutsideBorderItem1
            ' 
            Me.toggleTableCellsOutsideBorderItem1.Id = 83
            Me.toggleTableCellsOutsideBorderItem1.Name = "toggleTableCellsOutsideBorderItem1"
            ' 
            ' toggleTableCellsInsideBorderItem1
            ' 
            Me.toggleTableCellsInsideBorderItem1.Id = 84
            Me.toggleTableCellsInsideBorderItem1.Name = "toggleTableCellsInsideBorderItem1"
            ' 
            ' toggleTableCellsInsideHorizontalBorderItem1
            ' 
            Me.toggleTableCellsInsideHorizontalBorderItem1.Id = 85
            Me.toggleTableCellsInsideHorizontalBorderItem1.Name = "toggleTableCellsInsideHorizontalBorderItem1"
            ' 
            ' toggleTableCellsInsideVerticalBorderItem1
            ' 
            Me.toggleTableCellsInsideVerticalBorderItem1.Id = 86
            Me.toggleTableCellsInsideVerticalBorderItem1.Name = "toggleTableCellsInsideVerticalBorderItem1"
            ' 
            ' toggleShowTableGridLinesItem1
            ' 
            Me.toggleShowTableGridLinesItem1.Id = 87
            Me.toggleShowTableGridLinesItem1.Name = "toggleShowTableGridLinesItem1"
            ' 
            ' changeTableBorderLineStyleItem1
            ' 
            Me.changeTableBorderLineStyleItem1.Edit = Me.repositoryItemBorderLineStyle1
            resources.ApplyResources(Me.changeTableBorderLineStyleItem1, "changeTableBorderLineStyleItem1")
            Me.changeTableBorderLineStyleItem1.Id = 88
            Me.changeTableBorderLineStyleItem1.Name = "changeTableBorderLineStyleItem1"
            ' 
            ' repositoryItemBorderLineStyle1
            ' 
            resources.ApplyResources(Me.repositoryItemBorderLineStyle1, "repositoryItemBorderLineStyle1")
            Me.repositoryItemBorderLineStyle1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemBorderLineStyle1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemBorderLineStyle1.Control = Me.richEditControl
            Me.repositoryItemBorderLineStyle1.Name = "repositoryItemBorderLineStyle1"
            ' 
            ' changeTableBorderLineWeightItem1
            ' 
            Me.changeTableBorderLineWeightItem1.Edit = Me.repositoryItemBorderLineWeight1
            Me.changeTableBorderLineWeightItem1.EditValue = 20
            resources.ApplyResources(Me.changeTableBorderLineWeightItem1, "changeTableBorderLineWeightItem1")
            Me.changeTableBorderLineWeightItem1.Id = 89
            Me.changeTableBorderLineWeightItem1.Name = "changeTableBorderLineWeightItem1"
            ' 
            ' repositoryItemBorderLineWeight1
            ' 
            resources.ApplyResources(Me.repositoryItemBorderLineWeight1, "repositoryItemBorderLineWeight1")
            Me.repositoryItemBorderLineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemBorderLineWeight1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemBorderLineWeight1.Control = Me.richEditControl
            Me.repositoryItemBorderLineWeight1.Name = "repositoryItemBorderLineWeight1"
            ' 
            ' changeTableBorderColorItem1
            ' 
            Me.changeTableBorderColorItem1.Id = 90
            Me.changeTableBorderColorItem1.Name = "changeTableBorderColorItem1"
            ' 
            ' selectTableElementsItem1
            ' 
            Me.selectTableElementsItem1.Id = 91
            Me.selectTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableCellItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableColumnItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableRowItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableItem1)
            })
            Me.selectTableElementsItem1.Name = "selectTableElementsItem1"
            ' 
            ' selectTableCellItem1
            ' 
            Me.selectTableCellItem1.Id = 92
            Me.selectTableCellItem1.Name = "selectTableCellItem1"
            ' 
            ' selectTableColumnItem1
            ' 
            Me.selectTableColumnItem1.Id = 93
            Me.selectTableColumnItem1.Name = "selectTableColumnItem1"
            ' 
            ' selectTableRowItem1
            ' 
            Me.selectTableRowItem1.Id = 94
            Me.selectTableRowItem1.Name = "selectTableRowItem1"
            ' 
            ' selectTableItem1
            ' 
            Me.selectTableItem1.Id = 95
            Me.selectTableItem1.Name = "selectTableItem1"
            ' 
            ' showTablePropertiesFormItem1
            ' 
            Me.showTablePropertiesFormItem1.Id = 96
            Me.showTablePropertiesFormItem1.Name = "showTablePropertiesFormItem1"
            ' 
            ' deleteTableElementsItem1
            ' 
            Me.deleteTableElementsItem1.Id = 97
            Me.deleteTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.showDeleteTableCellsFormItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableColumnsItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableRowsItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableItem1)
            })
            Me.deleteTableElementsItem1.Name = "deleteTableElementsItem1"
            ' 
            ' showDeleteTableCellsFormItem1
            ' 
            Me.showDeleteTableCellsFormItem1.Id = 98
            Me.showDeleteTableCellsFormItem1.Name = "showDeleteTableCellsFormItem1"
            ' 
            ' deleteTableColumnsItem1
            ' 
            Me.deleteTableColumnsItem1.Id = 99
            Me.deleteTableColumnsItem1.Name = "deleteTableColumnsItem1"
            ' 
            ' deleteTableRowsItem1
            ' 
            Me.deleteTableRowsItem1.Id = 100
            Me.deleteTableRowsItem1.Name = "deleteTableRowsItem1"
            ' 
            ' deleteTableItem1
            ' 
            Me.deleteTableItem1.Id = 101
            Me.deleteTableItem1.Name = "deleteTableItem1"
            ' 
            ' insertTableRowAboveItem1
            ' 
            Me.insertTableRowAboveItem1.Id = 102
            Me.insertTableRowAboveItem1.Name = "insertTableRowAboveItem1"
            ' 
            ' insertTableRowBelowItem1
            ' 
            Me.insertTableRowBelowItem1.Id = 103
            Me.insertTableRowBelowItem1.Name = "insertTableRowBelowItem1"
            ' 
            ' insertTableColumnToLeftItem1
            ' 
            Me.insertTableColumnToLeftItem1.Id = 104
            Me.insertTableColumnToLeftItem1.Name = "insertTableColumnToLeftItem1"
            ' 
            ' insertTableColumnToRightItem1
            ' 
            Me.insertTableColumnToRightItem1.Id = 105
            Me.insertTableColumnToRightItem1.Name = "insertTableColumnToRightItem1"
            ' 
            ' mergeTableCellsItem1
            ' 
            Me.mergeTableCellsItem1.Id = 106
            Me.mergeTableCellsItem1.Name = "mergeTableCellsItem1"
            ' 
            ' showSplitTableCellsForm1
            ' 
            Me.showSplitTableCellsForm1.Id = 107
            Me.showSplitTableCellsForm1.Name = "showSplitTableCellsForm1"
            ' 
            ' splitTableItem1
            ' 
            Me.splitTableItem1.Id = 108
            Me.splitTableItem1.Name = "splitTableItem1"
            ' 
            ' toggleTableAutoFitItem1
            ' 
            Me.toggleTableAutoFitItem1.Id = 109
            Me.toggleTableAutoFitItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableAutoFitContentsItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableAutoFitWindowItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableFixedColumnWidthItem1)
            })
            Me.toggleTableAutoFitItem1.Name = "toggleTableAutoFitItem1"
            ' 
            ' toggleTableAutoFitContentsItem1
            ' 
            Me.toggleTableAutoFitContentsItem1.Id = 110
            Me.toggleTableAutoFitContentsItem1.Name = "toggleTableAutoFitContentsItem1"
            ' 
            ' toggleTableAutoFitWindowItem1
            ' 
            Me.toggleTableAutoFitWindowItem1.Id = 111
            Me.toggleTableAutoFitWindowItem1.Name = "toggleTableAutoFitWindowItem1"
            ' 
            ' toggleTableFixedColumnWidthItem1
            ' 
            Me.toggleTableFixedColumnWidthItem1.Id = 112
            Me.toggleTableFixedColumnWidthItem1.Name = "toggleTableFixedColumnWidthItem1"
            ' 
            ' toggleTableCellsTopLeftAlignmentItem1
            ' 
            Me.toggleTableCellsTopLeftAlignmentItem1.Id = 113
            Me.toggleTableCellsTopLeftAlignmentItem1.Name = "toggleTableCellsTopLeftAlignmentItem1"
            ' 
            ' toggleTableCellsMiddleLeftAlignmentItem1
            ' 
            Me.toggleTableCellsMiddleLeftAlignmentItem1.Id = 114
            Me.toggleTableCellsMiddleLeftAlignmentItem1.Name = "toggleTableCellsMiddleLeftAlignmentItem1"
            ' 
            ' toggleTableCellsBottomLeftAlignmentItem1
            ' 
            Me.toggleTableCellsBottomLeftAlignmentItem1.Id = 115
            Me.toggleTableCellsBottomLeftAlignmentItem1.Name = "toggleTableCellsBottomLeftAlignmentItem1"
            ' 
            ' toggleTableCellsTopCenterAlignmentItem1
            ' 
            Me.toggleTableCellsTopCenterAlignmentItem1.Id = 116
            Me.toggleTableCellsTopCenterAlignmentItem1.Name = "toggleTableCellsTopCenterAlignmentItem1"
            ' 
            ' toggleTableCellsMiddleCenterAlignmentItem1
            ' 
            Me.toggleTableCellsMiddleCenterAlignmentItem1.Id = 117
            Me.toggleTableCellsMiddleCenterAlignmentItem1.Name = "toggleTableCellsMiddleCenterAlignmentItem1"
            ' 
            ' toggleTableCellsBottomCenterAlignmentItem1
            ' 
            Me.toggleTableCellsBottomCenterAlignmentItem1.Id = 118
            Me.toggleTableCellsBottomCenterAlignmentItem1.Name = "toggleTableCellsBottomCenterAlignmentItem1"
            ' 
            ' toggleTableCellsTopRightAlignmentItem1
            ' 
            Me.toggleTableCellsTopRightAlignmentItem1.Id = 119
            Me.toggleTableCellsTopRightAlignmentItem1.Name = "toggleTableCellsTopRightAlignmentItem1"
            ' 
            ' toggleTableCellsMiddleRightAlignmentItem1
            ' 
            Me.toggleTableCellsMiddleRightAlignmentItem1.Id = 120
            Me.toggleTableCellsMiddleRightAlignmentItem1.Name = "toggleTableCellsMiddleRightAlignmentItem1"
            ' 
            ' toggleTableCellsBottomRightAlignmentItem1
            ' 
            Me.toggleTableCellsBottomRightAlignmentItem1.Id = 121
            Me.toggleTableCellsBottomRightAlignmentItem1.Name = "toggleTableCellsBottomRightAlignmentItem1"
            ' 
            ' changeFloatingObjectFillColorItem1
            ' 
            Me.changeFloatingObjectFillColorItem1.Id = 122
            Me.changeFloatingObjectFillColorItem1.Name = "changeFloatingObjectFillColorItem1"
            ' 
            ' changeFloatingObjectOutlineColorItem1
            ' 
            Me.changeFloatingObjectOutlineColorItem1.Id = 123
            Me.changeFloatingObjectOutlineColorItem1.Name = "changeFloatingObjectOutlineColorItem1"
            ' 
            ' changeFloatingObjectOutlineWeightItem1
            ' 
            Me.changeFloatingObjectOutlineWeightItem1.Edit = Me.repositoryItemFloatingObjectOutlineWeight1
            Me.changeFloatingObjectOutlineWeightItem1.EditValue = 20
            Me.changeFloatingObjectOutlineWeightItem1.Id = 124
            Me.changeFloatingObjectOutlineWeightItem1.Name = "changeFloatingObjectOutlineWeightItem1"
            ' 
            ' repositoryItemFloatingObjectOutlineWeight1
            ' 
            resources.ApplyResources(Me.repositoryItemFloatingObjectOutlineWeight1, "repositoryItemFloatingObjectOutlineWeight1")
            Me.repositoryItemFloatingObjectOutlineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemFloatingObjectOutlineWeight1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemFloatingObjectOutlineWeight1.Control = Me.richEditControl
            Me.repositoryItemFloatingObjectOutlineWeight1.Name = "repositoryItemFloatingObjectOutlineWeight1"
            ' 
            ' changeFloatingObjectTextWrapTypeItem1
            ' 
            Me.changeFloatingObjectTextWrapTypeItem1.Id = 125
            Me.changeFloatingObjectTextWrapTypeItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectSquareTextWrapTypeItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTightTextWrapTypeItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectThroughTextWrapTypeItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopAndBottomTextWrapTypeItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBehindTextWrapTypeItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectInFrontOfTextWrapTypeItem1)
            })
            Me.changeFloatingObjectTextWrapTypeItem1.Name = "changeFloatingObjectTextWrapTypeItem1"
            ' 
            ' setFloatingObjectSquareTextWrapTypeItem1
            ' 
            Me.setFloatingObjectSquareTextWrapTypeItem1.Id = 126
            Me.setFloatingObjectSquareTextWrapTypeItem1.Name = "setFloatingObjectSquareTextWrapTypeItem1"
            ' 
            ' setFloatingObjectTightTextWrapTypeItem1
            ' 
            Me.setFloatingObjectTightTextWrapTypeItem1.Id = 127
            Me.setFloatingObjectTightTextWrapTypeItem1.Name = "setFloatingObjectTightTextWrapTypeItem1"
            ' 
            ' setFloatingObjectThroughTextWrapTypeItem1
            ' 
            Me.setFloatingObjectThroughTextWrapTypeItem1.Id = 128
            Me.setFloatingObjectThroughTextWrapTypeItem1.Name = "setFloatingObjectThroughTextWrapTypeItem1"
            ' 
            ' setFloatingObjectTopAndBottomTextWrapTypeItem1
            ' 
            Me.setFloatingObjectTopAndBottomTextWrapTypeItem1.Id = 129
            Me.setFloatingObjectTopAndBottomTextWrapTypeItem1.Name = "setFloatingObjectTopAndBottomTextWrapTypeItem1"
            ' 
            ' setFloatingObjectBehindTextWrapTypeItem1
            ' 
            Me.setFloatingObjectBehindTextWrapTypeItem1.Id = 130
            Me.setFloatingObjectBehindTextWrapTypeItem1.Name = "setFloatingObjectBehindTextWrapTypeItem1"
            ' 
            ' setFloatingObjectInFrontOfTextWrapTypeItem1
            ' 
            Me.setFloatingObjectInFrontOfTextWrapTypeItem1.Id = 131
            Me.setFloatingObjectInFrontOfTextWrapTypeItem1.Name = "setFloatingObjectInFrontOfTextWrapTypeItem1"
            ' 
            ' changeFloatingObjectAlignmentItem1
            ' 
            Me.changeFloatingObjectAlignmentItem1.Id = 132
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
            Me.changeFloatingObjectAlignmentItem1.Name = "changeFloatingObjectAlignmentItem1"
            ' 
            ' setFloatingObjectTopLeftAlignmentItem1
            ' 
            Me.setFloatingObjectTopLeftAlignmentItem1.Id = 133
            Me.setFloatingObjectTopLeftAlignmentItem1.Name = "setFloatingObjectTopLeftAlignmentItem1"
            ' 
            ' setFloatingObjectTopCenterAlignmentItem1
            ' 
            Me.setFloatingObjectTopCenterAlignmentItem1.Id = 134
            Me.setFloatingObjectTopCenterAlignmentItem1.Name = "setFloatingObjectTopCenterAlignmentItem1"
            ' 
            ' setFloatingObjectTopRightAlignmentItem1
            ' 
            Me.setFloatingObjectTopRightAlignmentItem1.Id = 135
            Me.setFloatingObjectTopRightAlignmentItem1.Name = "setFloatingObjectTopRightAlignmentItem1"
            ' 
            ' setFloatingObjectMiddleLeftAlignmentItem1
            ' 
            Me.setFloatingObjectMiddleLeftAlignmentItem1.Id = 136
            Me.setFloatingObjectMiddleLeftAlignmentItem1.Name = "setFloatingObjectMiddleLeftAlignmentItem1"
            ' 
            ' setFloatingObjectMiddleCenterAlignmentItem1
            ' 
            Me.setFloatingObjectMiddleCenterAlignmentItem1.Id = 137
            Me.setFloatingObjectMiddleCenterAlignmentItem1.Name = "setFloatingObjectMiddleCenterAlignmentItem1"
            ' 
            ' setFloatingObjectMiddleRightAlignmentItem1
            ' 
            Me.setFloatingObjectMiddleRightAlignmentItem1.Id = 138
            Me.setFloatingObjectMiddleRightAlignmentItem1.Name = "setFloatingObjectMiddleRightAlignmentItem1"
            ' 
            ' setFloatingObjectBottomLeftAlignmentItem1
            ' 
            Me.setFloatingObjectBottomLeftAlignmentItem1.Id = 139
            Me.setFloatingObjectBottomLeftAlignmentItem1.Name = "setFloatingObjectBottomLeftAlignmentItem1"
            ' 
            ' setFloatingObjectBottomCenterAlignmentItem1
            ' 
            Me.setFloatingObjectBottomCenterAlignmentItem1.Id = 140
            Me.setFloatingObjectBottomCenterAlignmentItem1.Name = "setFloatingObjectBottomCenterAlignmentItem1"
            ' 
            ' setFloatingObjectBottomRightAlignmentItem1
            ' 
            Me.setFloatingObjectBottomRightAlignmentItem1.Id = 141
            Me.setFloatingObjectBottomRightAlignmentItem1.Name = "setFloatingObjectBottomRightAlignmentItem1"
            ' 
            ' floatingObjectBringForwardSubItem1
            ' 
            Me.floatingObjectBringForwardSubItem1.Id = 142
            Me.floatingObjectBringForwardSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectBringForwardItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectBringToFrontItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectBringInFrontOfTextItem1)
            })
            Me.floatingObjectBringForwardSubItem1.Name = "floatingObjectBringForwardSubItem1"
            ' 
            ' floatingObjectBringForwardItem1
            ' 
            Me.floatingObjectBringForwardItem1.Id = 143
            Me.floatingObjectBringForwardItem1.Name = "floatingObjectBringForwardItem1"
            ' 
            ' floatingObjectBringToFrontItem1
            ' 
            Me.floatingObjectBringToFrontItem1.Id = 144
            Me.floatingObjectBringToFrontItem1.Name = "floatingObjectBringToFrontItem1"
            ' 
            ' floatingObjectBringInFrontOfTextItem1
            ' 
            Me.floatingObjectBringInFrontOfTextItem1.Id = 145
            Me.floatingObjectBringInFrontOfTextItem1.Name = "floatingObjectBringInFrontOfTextItem1"
            ' 
            ' floatingObjectSendBackwardSubItem1
            ' 
            Me.floatingObjectSendBackwardSubItem1.Id = 146
            Me.floatingObjectSendBackwardSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectSendBackwardItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectSendToBackItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectSendBehindTextItem1)
            })
            Me.floatingObjectSendBackwardSubItem1.Name = "floatingObjectSendBackwardSubItem1"
            ' 
            ' floatingObjectSendBackwardItem1
            ' 
            Me.floatingObjectSendBackwardItem1.Id = 147
            Me.floatingObjectSendBackwardItem1.Name = "floatingObjectSendBackwardItem1"
            ' 
            ' floatingObjectSendToBackItem1
            ' 
            Me.floatingObjectSendToBackItem1.Id = 148
            Me.floatingObjectSendToBackItem1.Name = "floatingObjectSendToBackItem1"
            ' 
            ' floatingObjectSendBehindTextItem1
            ' 
            Me.floatingObjectSendBehindTextItem1.Id = 149
            Me.floatingObjectSendBehindTextItem1.Name = "floatingObjectSendBehindTextItem1"
            ' 
            ' tableToolsRibbonPageCategory1
            ' 
            resources.ApplyResources(Me.tableToolsRibbonPageCategory1, "tableToolsRibbonPageCategory1")
            Me.tableToolsRibbonPageCategory1.Control = Me.richEditControl
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
            Me.tableStylesRibbonPageGroup1.ItemLinks.Add(Me.changeTableCellsShadingItem1, "H")
            Me.tableStylesRibbonPageGroup1.ItemLinks.Add(Me.changeTableBordersItem1, "B")
            Me.tableStylesRibbonPageGroup1.Name = "tableStylesRibbonPageGroup1"
            ' 
            ' tableDrawBordersRibbonPageGroup1
            ' 
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderLineStyleItem1)
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderLineWeightItem1)
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderColorItem1, "C")
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
            Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.selectTableElementsItem1, "K")
            Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.toggleShowTableGridLinesItem1, "TG")
            Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.showTablePropertiesFormItem1, "O")
            Me.tableTableRibbonPageGroup1.Name = "tableTableRibbonPageGroup1"
            ' 
            ' tableRowsAndColumnsRibbonPageGroup1
            ' 
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.deleteTableElementsItem1, "D")
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableRowAboveItem1, "A")
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableRowBelowItem1, "E")
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableColumnToLeftItem1, "L")
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableColumnToRightItem1, "R")
            Me.tableRowsAndColumnsRibbonPageGroup1.Name = "tableRowsAndColumnsRibbonPageGroup1"
            ' 
            ' tableMergeRibbonPageGroup1
            ' 
            Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.mergeTableCellsItem1, "M")
            Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.showSplitTableCellsForm1, "P")
            Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.splitTableItem1, "Q")
            Me.tableMergeRibbonPageGroup1.Name = "tableMergeRibbonPageGroup1"
            ' 
            ' tableCellSizeRibbonPageGroup1
            ' 
            Me.tableCellSizeRibbonPageGroup1.AllowTextClipping = False
            Me.tableCellSizeRibbonPageGroup1.ItemLinks.Add(Me.toggleTableAutoFitItem1, "F")
            Me.tableCellSizeRibbonPageGroup1.Name = "tableCellSizeRibbonPageGroup1"
            ' 
            ' tableAlignmentRibbonPageGroup1
            ' 
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopLeftAlignmentItem1, "TL")
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleLeftAlignmentItem1, "CL")
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomLeftAlignmentItem1, "BL")
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopCenterAlignmentItem1, "TC")
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleCenterAlignmentItem1, "CC")
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomCenterAlignmentItem1, "BC")
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopRightAlignmentItem1, "TR")
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleRightAlignmentItem1, "CR")
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomRightAlignmentItem1, "BR")
            Me.tableAlignmentRibbonPageGroup1.Name = "tableAlignmentRibbonPageGroup1"
            ' 
            ' floatingPictureToolsRibbonPageCategory1
            ' 
            resources.ApplyResources(Me.floatingPictureToolsRibbonPageCategory1, "floatingPictureToolsRibbonPageCategory1")
            Me.floatingPictureToolsRibbonPageCategory1.Control = Me.richEditControl
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
            Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.changeFloatingObjectTextWrapTypeItem1, "TW")
            Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.changeFloatingObjectAlignmentItem1, "PO")
            Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.floatingObjectBringForwardSubItem1, "AF")
            Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.floatingObjectSendBackwardSubItem1, "AE")
            Me.floatingPictureToolsArrangePageGroup1.Name = "floatingPictureToolsArrangePageGroup1"
            ' 
            ' homeRibbonPage1
            ' 
            Me.homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.clipboardRibbonPageGroup1, Me.fontRibbonPageGroup1, Me.paragraphRibbonPageGroup1, Me.editingRibbonPageGroup1})
            Me.homeRibbonPage1.Name = "homeRibbonPage1"
            resources.ApplyResources(Me.homeRibbonPage1, "homeRibbonPage1")
            ' 
            ' clipboardRibbonPageGroup1
            ' 
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteItem1, "V")
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.cutItem1, "X")
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.copyItem1, "C")
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteSpecialItem1)
            Me.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1"
            ' 
            ' fontRibbonPageGroup1
            ' 
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup2)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup3)
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
            ' editingRibbonPageGroup1
            ' 
            Me.editingRibbonPageGroup1.AllowTextClipping = False
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.findItem1, "FD")
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.replaceItem1, "R")
            Me.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1"
            ' 
            ' insertRibbonPage1
            ' 
            Me.insertRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.tablesRibbonPageGroup1, Me.illustrationsRibbonPageGroup1, Me.linksRibbonPageGroup1, Me.textRibbonPageGroup1, Me.symbolsRibbonPageGroup1})
            Me.insertRibbonPage1.Name = "insertRibbonPage1"
            resources.ApplyResources(Me.insertRibbonPage1, "insertRibbonPage1")
            ' 
            ' tablesRibbonPageGroup1
            ' 
            Me.tablesRibbonPageGroup1.AllowTextClipping = False
            Me.tablesRibbonPageGroup1.ItemLinks.Add(Me.insertTableItem1, "T")
            Me.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1"
            ' 
            ' illustrationsRibbonPageGroup1
            ' 
            Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.insertPictureItem1, "P")
            Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.insertFloatingPictureItem1)
            Me.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1"
            ' 
            ' linksRibbonPageGroup1
            ' 
            Me.linksRibbonPageGroup1.AllowTextClipping = False
            Me.linksRibbonPageGroup1.ItemLinks.Add(Me.insertHyperlinkItem1, "I")
            Me.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1"
            ' 
            ' textRibbonPageGroup1
            ' 
            Me.textRibbonPageGroup1.AllowTextClipping = False
            Me.textRibbonPageGroup1.ItemLinks.Add(Me.insertTextBoxItem1, "X")
            Me.textRibbonPageGroup1.Name = "textRibbonPageGroup1"
            ' 
            ' symbolsRibbonPageGroup1
            ' 
            Me.symbolsRibbonPageGroup1.AllowTextClipping = False
            Me.symbolsRibbonPageGroup1.ItemLinks.Add(Me.insertSymbolItem1, "U")
            Me.symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1"
            ' 
            ' repositoryItemRichEditStyleEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemRichEditStyleEdit1, "repositoryItemRichEditStyleEdit1")
            Me.repositoryItemRichEditStyleEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemRichEditStyleEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemRichEditStyleEdit1.Control = Me.richEditControl
            Me.repositoryItemRichEditStyleEdit1.Name = "repositoryItemRichEditStyleEdit1"
            ' 
            ' statusBar
            ' 
            resources.ApplyResources(Me.statusBar, "statusBar")
            Me.statusBar.Name = "statusBar"
            Me.statusBar.Ribbon = Me.ribbonControl
            ' 
            ' buttonPanel
            ' 
            Me.buttonPanel.ButtonInterval = 38
            buttonImageOptions1.Image = My.Resources.NewMail_16x16
            buttonImageOptions2.Image = My.Resources.Contact_16x16
            buttonImageOptions3.Image = My.Resources.Custom_Flag
            buttonImageOptions4.Image = My.Resources.reading
            Me.buttonPanel.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {
                New DevExpress.XtraEditors.ButtonsPanelControl.ButtonControl(resources.GetString("buttonPanel.Buttons"), (DirectCast(resources.GetObject("buttonPanel.Buttons1"), Boolean)), buttonImageOptions1, (DirectCast(resources.GetObject("buttonPanel.Buttons2"), DevExpress.XtraBars.Docking2010.ButtonStyle)), resources.GetString("buttonPanel.Buttons3"), (DirectCast(resources.GetObject("buttonPanel.Buttons4"), Integer)), (DirectCast(resources.GetObject("buttonPanel.Buttons5"), Boolean)), (DirectCast(resources.GetObject("buttonPanel.Buttons6"), DevExpress.Utils.SuperToolTip)), (DirectCast(resources.GetObject("buttonPanel.Buttons7"), Boolean)), (DirectCast(resources.GetObject("buttonPanel.Buttons8"), Boolean)), (DirectCast(resources.GetObject("buttonPanel.Buttons9"), Boolean)), (DirectCast(resources.GetObject("buttonPanel.Buttons10"), Object)), (DirectCast(resources.GetObject("buttonPanel.Buttons11"), Integer)), (DirectCast(resources.GetObject("buttonPanel.Buttons12"), Boolean))),
                New DevExpress.XtraEditors.ButtonsPanelControl.ButtonControl(resources.GetString("buttonPanel.Buttons13"), (DirectCast(resources.GetObject("buttonPanel.Buttons14"), Boolean)), buttonImageOptions2, (DirectCast(resources.GetObject("buttonPanel.Buttons15"), DevExpress.XtraBars.Docking2010.ButtonStyle)), resources.GetString("buttonPanel.Buttons16"), (DirectCast(resources.GetObject("buttonPanel.Buttons17"), Integer)), (DirectCast(resources.GetObject("buttonPanel.Buttons18"), Boolean)), (DirectCast(resources.GetObject("buttonPanel.Buttons19"), DevExpress.Utils.SuperToolTip)), (DirectCast(resources.GetObject("buttonPanel.Buttons20"), Boolean)), (DirectCast(resources.GetObject("buttonPanel.Buttons21"), Boolean)), (DirectCast(resources.GetObject("buttonPanel.Buttons22"), Boolean)), (DirectCast(resources.GetObject("buttonPanel.Buttons23"), Object)), (DirectCast(resources.GetObject("buttonPanel.Buttons24"), Integer)), (DirectCast(resources.GetObject("buttonPanel.Buttons25"), Boolean))),
                New DevExpress.XtraEditors.ButtonsPanelControl.ButtonControl(resources.GetString("buttonPanel.Buttons26"), (DirectCast(resources.GetObject("buttonPanel.Buttons27"), Boolean)), buttonImageOptions3, (DirectCast(resources.GetObject("buttonPanel.Buttons28"), DevExpress.XtraBars.Docking2010.ButtonStyle)), resources.GetString("buttonPanel.Buttons29"), (DirectCast(resources.GetObject("buttonPanel.Buttons30"), Integer)), (DirectCast(resources.GetObject("buttonPanel.Buttons31"), Boolean)), (DirectCast(resources.GetObject("buttonPanel.Buttons32"), DevExpress.Utils.SuperToolTip)), (DirectCast(resources.GetObject("buttonPanel.Buttons33"), Boolean)), (DirectCast(resources.GetObject("buttonPanel.Buttons34"), Boolean)), (DirectCast(resources.GetObject("buttonPanel.Buttons35"), Boolean)), (DirectCast(resources.GetObject("buttonPanel.Buttons36"), Object)), (DirectCast(resources.GetObject("buttonPanel.Buttons37"), Integer)), (DirectCast(resources.GetObject("buttonPanel.Buttons38"), Boolean))),
                New DevExpress.XtraEditors.ButtonsPanelControl.ButtonControl(resources.GetString("buttonPanel.Buttons39"), (DirectCast(resources.GetObject("buttonPanel.Buttons40"), Boolean)), buttonImageOptions4, (DirectCast(resources.GetObject("buttonPanel.Buttons41"), DevExpress.XtraBars.Docking2010.ButtonStyle)), resources.GetString("buttonPanel.Buttons42"), (DirectCast(resources.GetObject("buttonPanel.Buttons43"), Integer)), (DirectCast(resources.GetObject("buttonPanel.Buttons44"), Boolean)), (DirectCast(resources.GetObject("buttonPanel.Buttons45"), DevExpress.Utils.SuperToolTip)), (DirectCast(resources.GetObject("buttonPanel.Buttons46"), Boolean)), (DirectCast(resources.GetObject("buttonPanel.Buttons47"), Boolean)), (DirectCast(resources.GetObject("buttonPanel.Buttons48"), Boolean)), (DirectCast(resources.GetObject("buttonPanel.Buttons49"), Object)), (DirectCast(resources.GetObject("buttonPanel.Buttons50"), Integer)), (DirectCast(resources.GetObject("buttonPanel.Buttons51"), Boolean)))
            })
            Me.buttonPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft
            resources.ApplyResources(Me.buttonPanel, "buttonPanel")
            Me.buttonPanel.Name = "buttonPanel"
            Me.buttonPanel.ToolTipController = Me.buttonPanelTooltipController
            ' 
            ' buttonPanelTooltipController
            ' 
            Me.buttonPanelTooltipController.ToolTipLocation = DevExpress.Utils.ToolTipLocation.BottomLeft
            ' 
            ' edtTo
            ' 
            resources.ApplyResources(Me.edtTo, "edtTo")
            Me.edtTo.Name = "edtTo"
            Me.edtTo.Properties.Appearance.Options.UseFont = True
            Me.edtTo.Properties.DeleteTokenOnGlyphClick = DevExpress.Utils.DefaultBoolean.False
            Me.edtTo.Properties.DropDownShowMode = DevExpress.XtraEditors.TokenEditDropDownShowMode.Outlook
            Me.edtTo.Properties.EditMode = DevExpress.XtraEditors.TokenEditMode.Manual
            Me.edtTo.Properties.EditValueType = XtraEditors.TokenEditValueType.List
            Me.edtTo.Properties.PopupPanel = Me.flyoutPanel1
            Me.edtTo.Properties.Separators.AddRange(New String() { ";", ",", " "})
            ' 
            ' panelControl
            ' 
            Me.panelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl.Controls.Add(Me.lblTo)
            Me.panelControl.Controls.Add(Me.lblSubject)
            Me.panelControl.Controls.Add(Me.edtTo)
            Me.panelControl.Controls.Add(Me.edtSubject)
            resources.ApplyResources(Me.panelControl, "panelControl")
            Me.panelControl.Name = "panelControl"
            ' 
            ' lblTo
            ' 
            resources.ApplyResources(Me.lblTo, "lblTo")
            Me.lblTo.Name = "lblTo"
            ' 
            ' lblSubject
            ' 
            resources.ApplyResources(Me.lblSubject, "lblSubject")
            Me.lblSubject.Name = "lblSubject"
            ' 
            ' ucMessageInfo1
            ' 
            resources.ApplyResources(Me.ucMessageInfo1, "ucMessageInfo1")
            Me.ucMessageInfo1.Name = "ucMessageInfo1"
            ' 
            ' richEditBarController1
            ' 
            Me.richEditBarController1.BarItems.Add(Me.fileSaveItem1)
            Me.richEditBarController1.BarItems.Add(Me.quickPrintItem1)
            Me.richEditBarController1.BarItems.Add(Me.printItem1)
            Me.richEditBarController1.BarItems.Add(Me.printPreviewItem1)
            Me.richEditBarController1.BarItems.Add(Me.undoItem1)
            Me.richEditBarController1.BarItems.Add(Me.redoItem1)
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
            Me.richEditBarController1.BarItems.Add(Me.changeFontColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontBackColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.showFontFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleBulletedListItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleNumberingListItem1)
            Me.richEditBarController1.BarItems.Add(Me.decreaseIndentItem1)
            Me.richEditBarController1.BarItems.Add(Me.increaseIndentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentLeftItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentCenterItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentRightItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeParagraphBackColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.showParagraphFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.showEditStyleFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.findItem1)
            Me.richEditBarController1.BarItems.Add(Me.replaceItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPictureItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertFloatingPictureItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertHyperlinkItem1)
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
            Me.richEditBarController1.Control = Me.richEditControl
            ' 
            ' showFontFormItem1
            ' 
            Me.showFontFormItem1.Id = -1
            Me.showFontFormItem1.Name = "showFontFormItem1"
            ' 
            ' showParagraphFormItem1
            ' 
            Me.showParagraphFormItem1.Id = -1
            Me.showParagraphFormItem1.Name = "showParagraphFormItem1"
            ' 
            ' showEditStyleFormItem1
            ' 
            Me.showEditStyleFormItem1.Id = -1
            Me.showEditStyleFormItem1.Name = "showEditStyleFormItem1"
            ' 
            ' showInsertTableCellsFormItem1
            ' 
            Me.showInsertTableCellsFormItem1.Id = -1
            Me.showInsertTableCellsFormItem1.Name = "showInsertTableCellsFormItem1"
            ' 
            ' frmEditMail
            ' 
            Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Controls.Add(Me.statusBar)
            Me.Controls.Add(Me.ribbonControl)
            Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
            Me.KeyPreview = True
            Me.Name = "frmEditMail"
            Me.Ribbon = Me.ribbonControl
            Me.StatusBar = Me.statusBar
            DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            DirectCast(Me.flyoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.flyoutPanel1.ResumeLayout(False)
            Me.flyoutPanel1.PerformLayout()
            DirectCast(Me.picContact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.applicationMenu, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemFloatingObjectOutlineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            Me.panelControl.PerformLayout()
            DirectCast(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
        Private applicationMenu As DevExpress.XtraBars.Ribbon.ApplicationMenu
        Shadows statusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
        #End Region
        Private panelControl As DevExpress.XtraEditors.PanelControl
        Private WithEvents richEditControl As DevExpress.XtraRichEdit.RichEditControl
        Private lblSubject As DevExpress.XtraEditors.LabelControl
        Private WithEvents edtSubject As DevExpress.XtraEditors.TextEdit
        Private lblTo As DevExpress.XtraEditors.LabelControl
        Private WithEvents edtTo As DevExpress.XtraEditors.TokenEdit
        Private WithEvents fileSaveItem1 As DevExpress.XtraBars.BarButtonItem
        Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
        Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem
        Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
        Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
        Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
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
        Private barButtonGroup3 As DevExpress.XtraBars.BarButtonGroup
        Private changeFontColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontColorItem
        Private changeFontBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem
        Private barButtonGroup4 As DevExpress.XtraBars.BarButtonGroup
        Private toggleBulletedListItem1 As DevExpress.XtraRichEdit.UI.ToggleBulletedListItem
        Private toggleNumberingListItem1 As DevExpress.XtraRichEdit.UI.ToggleNumberingListItem
        Private barButtonGroup5 As DevExpress.XtraBars.BarButtonGroup
        Private decreaseIndentItem1 As DevExpress.XtraRichEdit.UI.DecreaseIndentItem
        Private increaseIndentItem1 As DevExpress.XtraRichEdit.UI.IncreaseIndentItem
        Private barButtonGroup6 As DevExpress.XtraBars.BarButtonGroup
        Private toggleParagraphAlignmentLeftItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem
        Private toggleParagraphAlignmentCenterItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem
        Private toggleParagraphAlignmentRightItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem
        Private barButtonGroup7 As DevExpress.XtraBars.BarButtonGroup
        Private changeParagraphBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem
        Private repositoryItemRichEditStyleEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit
        Private findItem1 As DevExpress.XtraRichEdit.UI.FindItem
        Private replaceItem1 As DevExpress.XtraRichEdit.UI.ReplaceItem
        Private insertTableItem1 As DevExpress.XtraRichEdit.UI.InsertTableItem
        Private insertPictureItem1 As DevExpress.XtraRichEdit.UI.InsertPictureItem
        Private insertFloatingPictureItem1 As DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem
        Private insertHyperlinkItem1 As DevExpress.XtraRichEdit.UI.InsertHyperlinkItem
        Private insertTextBoxItem1 As DevExpress.XtraRichEdit.UI.InsertTextBoxItem
        Private insertSymbolItem1 As DevExpress.XtraRichEdit.UI.InsertSymbolItem
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
        Private floatingPictureToolsRibbonPageCategory1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsRibbonPageCategory
        Private floatingPictureToolsFormatPage1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsFormatPage
        Private floatingPictureToolsShapeStylesPageGroup1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsShapeStylesPageGroup
        Private floatingPictureToolsArrangePageGroup1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsArrangePageGroup
        Private homeRibbonPage1 As DevExpress.XtraRichEdit.UI.HomeRibbonPage
        Private clipboardRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup
        Private fontRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.FontRibbonPageGroup
        Private paragraphRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup
        Private editingRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup
        Private insertRibbonPage1 As DevExpress.XtraRichEdit.UI.InsertRibbonPage
        Private tablesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup
        Private illustrationsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup
        Private linksRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup
        Private textRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TextRibbonPageGroup
        Private symbolsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup
        Private showFontFormItem1 As DevExpress.XtraRichEdit.UI.ShowFontFormItem
        Private showParagraphFormItem1 As DevExpress.XtraRichEdit.UI.ShowParagraphFormItem
        Private showEditStyleFormItem1 As DevExpress.XtraRichEdit.UI.ShowEditStyleFormItem
        Private showInsertTableCellsFormItem1 As DevExpress.XtraRichEdit.UI.ShowInsertTableCellsFormItem
        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private ucMessageInfo1 As DevExpress.MailClient.Win.Controls.ucMessageInfo
        Private spellChecker1 As DevExpress.XtraSpellChecker.SpellChecker
        Private flyoutPanel1 As Utils.FlyoutPanel
        Private lblDescription As XtraEditors.LabelControl
        Private lblMail As XtraEditors.LabelControl
        Private picContact As XtraEditors.PictureEdit
        Private buttonPanel As DevExpress.XtraEditors.ButtonsPanelControl.ButtonPanelControl
        Private buttonPanelTooltipController As Utils.ToolTipController
    End Class
End Namespace
