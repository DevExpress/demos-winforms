Namespace DevExpress.XtraRichEdit.Demos

    Partial Class DocumentProtectionModule

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
            Dim galleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim superToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.checkSpellingItem1 = New DevExpress.XtraRichEdit.UI.CheckSpellingItem()
            Me.changeLanguageItem1 = New DevExpress.XtraRichEdit.UI.ChangeLanguageItem()
            Me.protectDocumentItem1 = New DevExpress.XtraRichEdit.UI.ProtectDocumentItem()
            Me.changeRangeEditingPermissionsItem1 = New DevExpress.XtraRichEdit.UI.ChangeRangeEditingPermissionsItem()
            Me.unprotectDocumentItem1 = New DevExpress.XtraRichEdit.UI.UnprotectDocumentItem()
            Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
            Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
            Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
            Me.pasteSpecialItem1 = New DevExpress.XtraRichEdit.UI.PasteSpecialItem()
            Me.barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
            Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
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
            Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.usersBarEditItem = New DevExpress.XtraBars.BarEditItem()
            Me.cbUsers = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.newCommentItem1 = New DevExpress.XtraRichEdit.UI.NewCommentItem()
            Me.deleteCommentsItem1 = New DevExpress.XtraRichEdit.UI.DeleteCommentsItem()
            Me.deleteOneCommentItem1 = New DevExpress.XtraRichEdit.UI.DeleteOneCommentItem()
            Me.deleteAllCommentsShownItem1 = New DevExpress.XtraRichEdit.UI.DeleteAllCommentsShownItem()
            Me.deleteAllCommentsItem1 = New DevExpress.XtraRichEdit.UI.DeleteAllCommentsItem()
            Me.previousCommentItem1 = New DevExpress.XtraRichEdit.UI.PreviousCommentItem()
            Me.nextCommentItem1 = New DevExpress.XtraRichEdit.UI.NextCommentItem()
            Me.changeCommentItem1 = New DevExpress.XtraRichEdit.UI.ChangeCommentItem()
            Me.reviewersItem1 = New DevExpress.XtraRichEdit.UI.ReviewersItem()
            Me.reviewingPaneItem1 = New DevExpress.XtraRichEdit.UI.ReviewingPaneItem()
            Me.toggleTrackChangesBarItem1 = New DevExpress.XtraRichEdit.UI.ToggleTrackChangesBarItem()
            Me.changeDisplayForReviewModeItem1 = New DevExpress.XtraRichEdit.UI.ChangeDisplayForReviewModeItem()
            Me.displayForReviewModeComboBox1 = New DevExpress.XtraRichEdit.UI.DisplayForReviewModeComboBox()
            Me.showMarkupSubItem1 = New DevExpress.XtraRichEdit.UI.ShowMarkupSubItem()
            Me.acceptAndMoveToNextSubItem1 = New DevExpress.XtraRichEdit.UI.AcceptAndMoveToNextSubItem()
            Me.rejectAndMoveToNextSubItem1 = New DevExpress.XtraRichEdit.UI.RejectAndMoveToNextSubItem()
            Me.previousChangeItem1 = New DevExpress.XtraRichEdit.UI.PreviousChangeItem()
            Me.nextChangeItem1 = New DevExpress.XtraRichEdit.UI.NextChangeItem()
            Me.reviewRibbonPage1 = New DevExpress.XtraRichEdit.UI.ReviewRibbonPage()
            Me.documentProtectionRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentProtectionRibbonPageGroup()
            Me.documentCommentRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentCommentRibbonPageGroup()
            Me.documentTrackingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentTrackingRibbonPageGroup()
            Me.documentChangesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentChangesRibbonPageGroup()
            Me.pnlAlert = New System.Windows.Forms.Panel()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController(Me.components)
            Me.separatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemFontEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemRichEditFontSizeEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbUsers), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.displayForReviewModeComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlAlert.SuspendLayout()
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.separatorControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' richEditControl
            ' 
            Me.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.Location = New System.Drawing.Point(0, 182)
            Me.richEditControl.MenuManager = Me.ribbonControl1
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Size = New System.Drawing.Size(738, 268)
            Me.richEditControl.TabIndex = 0
            AddHandler Me.richEditControl.DocumentLoaded, New System.EventHandler(AddressOf Me.OnRichEditControl1DocumentLoaded)
            AddHandler Me.richEditControl.DocumentProtectionChanged, New System.EventHandler(AddressOf Me.OnRichEditControlDocumentProtectionChanged)
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.checkSpellingItem1, Me.changeLanguageItem1, Me.protectDocumentItem1, Me.changeRangeEditingPermissionsItem1, Me.unprotectDocumentItem1, Me.pasteItem1, Me.cutItem1, Me.copyItem1, Me.pasteSpecialItem1, Me.barButtonGroup1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.barButtonGroup2, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.toggleFontUnderlineItem1, Me.toggleFontDoubleUnderlineItem1, Me.toggleFontStrikeoutItem1, Me.toggleFontDoubleStrikeoutItem1, Me.toggleFontSuperscriptItem1, Me.toggleFontSubscriptItem1, Me.barButtonGroup3, Me.changeFontColorItem1, Me.changeFontBackColorItem1, Me.changeTextCaseItem1, Me.makeTextUpperCaseItem1, Me.makeTextLowerCaseItem1, Me.capitalizeEachWordCaseItem1, Me.toggleTextCaseItem1, Me.clearFormattingItem1, Me.barButtonGroup4, Me.toggleBulletedListItem1, Me.toggleNumberingListItem1, Me.toggleMultiLevelListItem1, Me.barButtonGroup5, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.barButtonGroup6, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.toggleParagraphAlignmentJustifyItem1, Me.toggleShowWhitespaceItem1, Me.barButtonGroup7, Me.changeParagraphLineSpacingItem1, Me.setSingleParagraphSpacingItem1, Me.setSesquialteralParagraphSpacingItem1, Me.setDoubleParagraphSpacingItem1, Me.showLineSpacingFormItem1, Me.addSpacingBeforeParagraphItem1, Me.removeSpacingBeforeParagraphItem1, Me.addSpacingAfterParagraphItem1, Me.removeSpacingAfterParagraphItem1, Me.changeParagraphBackColorItem1, Me.galleryChangeStyleItem1, Me.findItem1, Me.replaceItem1, Me.barEditItem1, Me.usersBarEditItem, Me.newCommentItem1, Me.deleteCommentsItem1, Me.deleteOneCommentItem1, Me.deleteAllCommentsShownItem1, Me.deleteAllCommentsItem1, Me.previousCommentItem1, Me.nextCommentItem1, Me.changeCommentItem1, Me.reviewersItem1, Me.reviewingPaneItem1, Me.toggleTrackChangesBarItem1, Me.changeDisplayForReviewModeItem1, Me.showMarkupSubItem1, Me.acceptAndMoveToNextSubItem1, Me.rejectAndMoveToNextSubItem1, Me.previousChangeItem1, Me.nextChangeItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 82
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.reviewRibbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1, Me.repositoryItemComboBox1, Me.cbUsers, Me.displayForReviewModeComboBox1})
            Me.ribbonControl1.Size = New System.Drawing.Size(738, 150)
            ' 
            ' checkSpellingItem1
            ' 
            Me.checkSpellingItem1.Id = 1
            Me.checkSpellingItem1.Name = "checkSpellingItem1"
            ' 
            ' changeLanguageItem1
            ' 
            Me.changeLanguageItem1.Id = 2
            Me.changeLanguageItem1.Name = "changeLanguageItem1"
            ' 
            ' protectDocumentItem1
            ' 
            Me.protectDocumentItem1.Id = 3
            Me.protectDocumentItem1.Name = "protectDocumentItem1"
            ' 
            ' changeRangeEditingPermissionsItem1
            ' 
            Me.changeRangeEditingPermissionsItem1.Id = 4
            Me.changeRangeEditingPermissionsItem1.Name = "changeRangeEditingPermissionsItem1"
            ' 
            ' unprotectDocumentItem1
            ' 
            Me.unprotectDocumentItem1.Id = 5
            Me.unprotectDocumentItem1.Name = "unprotectDocumentItem1"
            ' 
            ' pasteItem1
            ' 
            Me.pasteItem1.Id = 15
            Me.pasteItem1.Name = "pasteItem1"
            ' 
            ' cutItem1
            ' 
            Me.cutItem1.Id = 16
            Me.cutItem1.Name = "cutItem1"
            ' 
            ' copyItem1
            ' 
            Me.copyItem1.Id = 17
            Me.copyItem1.Name = "copyItem1"
            ' 
            ' pasteSpecialItem1
            ' 
            Me.pasteSpecialItem1.Id = 18
            Me.pasteSpecialItem1.Name = "pasteSpecialItem1"
            ' 
            ' barButtonGroup1
            ' 
            Me.barButtonGroup1.Id = 8
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
            Me.changeFontNameItem1.Id = 19
            Me.changeFontNameItem1.Name = "changeFontNameItem1"
            ' 
            ' repositoryItemFontEdit1
            ' 
            Me.repositoryItemFontEdit1.AutoHeight = False
            Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
            ' 
            ' changeFontSizeItem1
            ' 
            Me.changeFontSizeItem1.Edit = Me.repositoryItemRichEditFontSizeEdit1
            Me.changeFontSizeItem1.Id = 20
            Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
            ' 
            ' repositoryItemRichEditFontSizeEdit1
            ' 
            Me.repositoryItemRichEditFontSizeEdit1.AutoHeight = False
            Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditFontSizeEdit1.Control = Me.richEditControl
            Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
            ' 
            ' fontSizeIncreaseItem1
            ' 
            Me.fontSizeIncreaseItem1.Id = 21
            Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
            ' 
            ' fontSizeDecreaseItem1
            ' 
            Me.fontSizeDecreaseItem1.Id = 22
            Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
            ' 
            ' barButtonGroup2
            ' 
            Me.barButtonGroup2.Id = 9
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
            ' 
            ' toggleFontBoldItem1
            ' 
            Me.toggleFontBoldItem1.Id = 23
            Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
            ' 
            ' toggleFontItalicItem1
            ' 
            Me.toggleFontItalicItem1.Id = 24
            Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
            ' 
            ' toggleFontUnderlineItem1
            ' 
            Me.toggleFontUnderlineItem1.Id = 25
            Me.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
            ' 
            ' toggleFontDoubleUnderlineItem1
            ' 
            Me.toggleFontDoubleUnderlineItem1.Id = 26
            Me.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
            ' 
            ' toggleFontStrikeoutItem1
            ' 
            Me.toggleFontStrikeoutItem1.Id = 27
            Me.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
            ' 
            ' toggleFontDoubleStrikeoutItem1
            ' 
            Me.toggleFontDoubleStrikeoutItem1.Id = 28
            Me.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
            ' 
            ' toggleFontSuperscriptItem1
            ' 
            Me.toggleFontSuperscriptItem1.Id = 29
            Me.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
            ' 
            ' toggleFontSubscriptItem1
            ' 
            Me.toggleFontSubscriptItem1.Id = 30
            Me.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
            ' 
            ' barButtonGroup3
            ' 
            Me.barButtonGroup3.Id = 10
            Me.barButtonGroup3.ItemLinks.Add(Me.changeFontColorItem1, "FC")
            Me.barButtonGroup3.ItemLinks.Add(Me.changeFontBackColorItem1, "I")
            Me.barButtonGroup3.Name = "barButtonGroup3"
            Me.barButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}"
            ' 
            ' changeFontColorItem1
            ' 
            Me.changeFontColorItem1.Id = 31
            Me.changeFontColorItem1.Name = "changeFontColorItem1"
            ' 
            ' changeFontBackColorItem1
            ' 
            Me.changeFontBackColorItem1.Id = 32
            Me.changeFontBackColorItem1.Name = "changeFontBackColorItem1"
            ' 
            ' changeTextCaseItem1
            ' 
            Me.changeTextCaseItem1.Id = 33
            Me.changeTextCaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextUpperCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextLowerCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.capitalizeEachWordCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTextCaseItem1)})
            Me.changeTextCaseItem1.Name = "changeTextCaseItem1"
            ' 
            ' makeTextUpperCaseItem1
            ' 
            Me.makeTextUpperCaseItem1.Id = 34
            Me.makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1"
            ' 
            ' makeTextLowerCaseItem1
            ' 
            Me.makeTextLowerCaseItem1.Id = 35
            Me.makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1"
            ' 
            ' capitalizeEachWordCaseItem1
            ' 
            Me.capitalizeEachWordCaseItem1.Id = 36
            Me.capitalizeEachWordCaseItem1.Name = "capitalizeEachWordCaseItem1"
            ' 
            ' toggleTextCaseItem1
            ' 
            Me.toggleTextCaseItem1.Id = 37
            Me.toggleTextCaseItem1.Name = "toggleTextCaseItem1"
            ' 
            ' clearFormattingItem1
            ' 
            Me.clearFormattingItem1.Id = 38
            Me.clearFormattingItem1.Name = "clearFormattingItem1"
            ' 
            ' barButtonGroup4
            ' 
            Me.barButtonGroup4.Id = 11
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleBulletedListItem1, "U")
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleNumberingListItem1, "N")
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleMultiLevelListItem1, "M")
            Me.barButtonGroup4.Name = "barButtonGroup4"
            Me.barButtonGroup4.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
            ' 
            ' toggleBulletedListItem1
            ' 
            Me.toggleBulletedListItem1.Id = 39
            Me.toggleBulletedListItem1.Name = "toggleBulletedListItem1"
            ' 
            ' toggleNumberingListItem1
            ' 
            Me.toggleNumberingListItem1.Id = 40
            Me.toggleNumberingListItem1.Name = "toggleNumberingListItem1"
            ' 
            ' toggleMultiLevelListItem1
            ' 
            Me.toggleMultiLevelListItem1.Id = 41
            Me.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
            ' 
            ' barButtonGroup5
            ' 
            Me.barButtonGroup5.Id = 12
            Me.barButtonGroup5.ItemLinks.Add(Me.decreaseIndentItem1, "AO")
            Me.barButtonGroup5.ItemLinks.Add(Me.increaseIndentItem1, "AI")
            Me.barButtonGroup5.ItemLinks.Add(Me.toggleShowWhitespaceItem1)
            Me.barButtonGroup5.Name = "barButtonGroup5"
            Me.barButtonGroup5.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}"
            ' 
            ' decreaseIndentItem1
            ' 
            Me.decreaseIndentItem1.Id = 42
            Me.decreaseIndentItem1.Name = "decreaseIndentItem1"
            ' 
            ' increaseIndentItem1
            ' 
            Me.increaseIndentItem1.Id = 43
            Me.increaseIndentItem1.Name = "increaseIndentItem1"
            ' 
            ' toggleShowWhitespaceItem1
            ' 
            Me.toggleShowWhitespaceItem1.Id = 48
            Me.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
            ' 
            ' barButtonGroup6
            ' 
            Me.barButtonGroup6.Id = 13
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentLeftItem1, "AL")
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentCenterItem1, "AC")
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentRightItem1, "AR")
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentJustifyItem1, "AJ")
            Me.barButtonGroup6.Name = "barButtonGroup6"
            Me.barButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}"
            ' 
            ' toggleParagraphAlignmentLeftItem1
            ' 
            Me.toggleParagraphAlignmentLeftItem1.Id = 44
            Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
            ' 
            ' toggleParagraphAlignmentCenterItem1
            ' 
            Me.toggleParagraphAlignmentCenterItem1.Id = 45
            Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
            ' 
            ' toggleParagraphAlignmentRightItem1
            ' 
            Me.toggleParagraphAlignmentRightItem1.Id = 46
            Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
            ' 
            ' toggleParagraphAlignmentJustifyItem1
            ' 
            Me.toggleParagraphAlignmentJustifyItem1.Id = 47
            Me.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
            ' 
            ' barButtonGroup7
            ' 
            Me.barButtonGroup7.Id = 14
            Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphLineSpacingItem1, "K")
            Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphBackColorItem1, "H")
            Me.barButtonGroup7.Name = "barButtonGroup7"
            Me.barButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}"
            ' 
            ' changeParagraphLineSpacingItem1
            ' 
            Me.changeParagraphLineSpacingItem1.Id = 49
            Me.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setSingleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSesquialteralParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setDoubleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showLineSpacingFormItem1), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, Me.addSpacingBeforeParagraphItem1, "", False, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard, "B", ""), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingAfterParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingAfterParagraphItem1)})
            Me.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1"
            ' 
            ' setSingleParagraphSpacingItem1
            ' 
            Me.setSingleParagraphSpacingItem1.Id = 50
            Me.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1"
            ' 
            ' setSesquialteralParagraphSpacingItem1
            ' 
            Me.setSesquialteralParagraphSpacingItem1.Id = 51
            Me.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1"
            ' 
            ' setDoubleParagraphSpacingItem1
            ' 
            Me.setDoubleParagraphSpacingItem1.Id = 52
            Me.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1"
            ' 
            ' showLineSpacingFormItem1
            ' 
            Me.showLineSpacingFormItem1.Id = 53
            Me.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1"
            ' 
            ' addSpacingBeforeParagraphItem1
            ' 
            Me.addSpacingBeforeParagraphItem1.Id = 54
            Me.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1"
            ' 
            ' removeSpacingBeforeParagraphItem1
            ' 
            Me.removeSpacingBeforeParagraphItem1.Id = 55
            Me.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1"
            ' 
            ' addSpacingAfterParagraphItem1
            ' 
            Me.addSpacingAfterParagraphItem1.Id = 56
            Me.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1"
            ' 
            ' removeSpacingAfterParagraphItem1
            ' 
            Me.removeSpacingAfterParagraphItem1.Id = 57
            Me.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1"
            ' 
            ' changeParagraphBackColorItem1
            ' 
            Me.changeParagraphBackColorItem1.Id = 58
            Me.changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1"
            ' 
            ' galleryChangeStyleItem1
            ' 
            ' 
            ' 
            ' 
            Me.galleryChangeStyleItem1.Gallery.ColumnCount = 10
            Me.galleryChangeStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {galleryItemGroup1})
            Me.galleryChangeStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.galleryChangeStyleItem1.Id = 59
            Me.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1"
            ' 
            ' findItem1
            ' 
            Me.findItem1.Id = 60
            Me.findItem1.Name = "findItem1"
            ' 
            ' replaceItem1
            ' 
            Me.replaceItem1.Id = 61
            Me.replaceItem1.Name = "replaceItem1"
            ' 
            ' barEditItem1
            ' 
            Me.barEditItem1.Caption = "barEditItem1"
            Me.barEditItem1.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.barEditItem1.Edit = Me.repositoryItemComboBox1
            Me.barEditItem1.Id = 63
            Me.barEditItem1.Name = "barEditItem1"
            ' 
            ' repositoryItemComboBox1
            ' 
            Me.repositoryItemComboBox1.AutoHeight = False
            Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            ' 
            ' usersBarEditItem
            ' 
            Me.usersBarEditItem.Caption = "User"
            Me.usersBarEditItem.Edit = Me.cbUsers
            Me.usersBarEditItem.EditWidth = 173
            Me.usersBarEditItem.Id = 64
            Me.usersBarEditItem.Name = "usersBarEditItem"
            AddHandler Me.usersBarEditItem.EditValueChanged, New System.EventHandler(AddressOf Me.usersBarEditItem_EditValueChanged)
            ' 
            ' cbUsers
            ' 
            Me.cbUsers.AutoHeight = False
            Me.cbUsers.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbUsers.Name = "cbUsers"
            ' 
            ' newCommentItem1
            ' 
            Me.newCommentItem1.Id = 65
            Me.newCommentItem1.Name = "newCommentItem1"
            ' 
            ' deleteCommentsItem1
            ' 
            Me.deleteCommentsItem1.Id = 66
            Me.deleteCommentsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.deleteOneCommentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteAllCommentsShownItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteAllCommentsItem1)})
            Me.deleteCommentsItem1.Name = "deleteCommentsItem1"
            ' 
            ' deleteOneCommentItem1
            ' 
            Me.deleteOneCommentItem1.Id = 67
            Me.deleteOneCommentItem1.Name = "deleteOneCommentItem1"
            ' 
            ' deleteAllCommentsShownItem1
            ' 
            Me.deleteAllCommentsShownItem1.Id = 68
            Me.deleteAllCommentsShownItem1.Name = "deleteAllCommentsShownItem1"
            ' 
            ' deleteAllCommentsItem1
            ' 
            Me.deleteAllCommentsItem1.Id = 69
            Me.deleteAllCommentsItem1.Name = "deleteAllCommentsItem1"
            ' 
            ' previousCommentItem1
            ' 
            Me.previousCommentItem1.Id = 70
            Me.previousCommentItem1.Name = "previousCommentItem1"
            ' 
            ' nextCommentItem1
            ' 
            Me.nextCommentItem1.Id = 71
            Me.nextCommentItem1.Name = "nextCommentItem1"
            ' 
            ' changeCommentItem1
            ' 
            Me.changeCommentItem1.Id = 72
            Me.changeCommentItem1.Name = "changeCommentItem1"
            ' 
            ' reviewersItem1
            ' 
            Me.reviewersItem1.Id = 73
            Me.reviewersItem1.Name = "reviewersItem1"
            ' 
            ' reviewingPaneItem1
            ' 
            Me.reviewingPaneItem1.Id = 74
            Me.reviewingPaneItem1.Name = "reviewingPaneItem1"
            ' 
            ' toggleTrackChangesBarItem1
            ' 
            toolTipTitleItem1.Text = "Track Changes"
            toolTipItem1.Text = "Keep track of changes made to this document."
            superToolTip1.Items.Add(toolTipTitleItem1)
            superToolTip1.Items.Add(toolTipItem1)
            Me.toggleTrackChangesBarItem1.DropDownSuperTip = superToolTip1
            Me.toggleTrackChangesBarItem1.Id = 75
            Me.toggleTrackChangesBarItem1.Name = "toggleTrackChangesBarItem1"
            ' 
            ' changeDisplayForReviewModeItem1
            ' 
            Me.changeDisplayForReviewModeItem1.Edit = Me.displayForReviewModeComboBox1
            Me.changeDisplayForReviewModeItem1.Id = 76
            Me.changeDisplayForReviewModeItem1.Name = "changeDisplayForReviewModeItem1"
            ' 
            ' displayForReviewModeComboBox1
            ' 
            Me.displayForReviewModeComboBox1.AutoHeight = False
            Me.displayForReviewModeComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.displayForReviewModeComboBox1.Name = "displayForReviewModeComboBox1"
            Me.displayForReviewModeComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            ' 
            ' showMarkupSubItem1
            ' 
            Me.showMarkupSubItem1.ActAsDropDown = True
            toolTipTitleItem2.Text = "Show Markup"
            toolTipItem2.Text = "Choose what types of markup to show in your document."
            superToolTip2.Items.Add(toolTipTitleItem2)
            superToolTip2.Items.Add(toolTipItem2)
            Me.showMarkupSubItem1.DropDownSuperTip = superToolTip2
            Me.showMarkupSubItem1.Id = 77
            Me.showMarkupSubItem1.Name = "showMarkupSubItem1"
            Me.showMarkupSubItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' acceptAndMoveToNextSubItem1
            ' 
            toolTipTitleItem3.Text = "Accept"
            toolTipItem3.Text = "Click for additional options, such as accepting all the changes at once."
            superToolTip3.Items.Add(toolTipTitleItem3)
            superToolTip3.Items.Add(toolTipItem3)
            Me.acceptAndMoveToNextSubItem1.DropDownSuperTip = superToolTip3
            Me.acceptAndMoveToNextSubItem1.Id = 78
            Me.acceptAndMoveToNextSubItem1.Name = "acceptAndMoveToNextSubItem1"
            ' 
            ' rejectAndMoveToNextSubItem1
            ' 
            toolTipTitleItem4.Text = "Reject"
            toolTipItem4.Text = "Click for additional options, such as rejecting all the changes at once."
            superToolTip4.Items.Add(toolTipTitleItem4)
            superToolTip4.Items.Add(toolTipItem4)
            Me.rejectAndMoveToNextSubItem1.DropDownSuperTip = superToolTip4
            Me.rejectAndMoveToNextSubItem1.Id = 79
            Me.rejectAndMoveToNextSubItem1.Name = "rejectAndMoveToNextSubItem1"
            ' 
            ' previousChangeItem1
            ' 
            Me.previousChangeItem1.Id = 80
            Me.previousChangeItem1.Name = "previousChangeItem1"
            ' 
            ' nextChangeItem1
            ' 
            Me.nextChangeItem1.Id = 81
            Me.nextChangeItem1.Name = "nextChangeItem1"
            ' 
            ' reviewRibbonPage1
            ' 
            Me.reviewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.documentProtectionRibbonPageGroup1, Me.documentCommentRibbonPageGroup1, Me.documentTrackingRibbonPageGroup1, Me.documentChangesRibbonPageGroup1})
            Me.reviewRibbonPage1.Name = "reviewRibbonPage1"
            ' 
            ' documentProtectionRibbonPageGroup1
            ' 
            Me.documentProtectionRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentProtectionRibbonPageGroup1.ItemLinks.Add(Me.protectDocumentItem1)
            Me.documentProtectionRibbonPageGroup1.ItemLinks.Add(Me.changeRangeEditingPermissionsItem1)
            Me.documentProtectionRibbonPageGroup1.ItemLinks.Add(Me.unprotectDocumentItem1)
            Me.documentProtectionRibbonPageGroup1.ItemLinks.Add(Me.usersBarEditItem)
            Me.documentProtectionRibbonPageGroup1.Name = "documentProtectionRibbonPageGroup1"
            ' 
            ' documentCommentRibbonPageGroup1
            ' 
            Me.documentCommentRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentCommentRibbonPageGroup1.ItemLinks.Add(Me.newCommentItem1, "C")
            Me.documentCommentRibbonPageGroup1.ItemLinks.Add(Me.deleteCommentsItem1, "D")
            Me.documentCommentRibbonPageGroup1.ItemLinks.Add(Me.previousCommentItem1, "V")
            Me.documentCommentRibbonPageGroup1.ItemLinks.Add(Me.nextCommentItem1, "N")
            Me.documentCommentRibbonPageGroup1.Name = "documentCommentRibbonPageGroup1"
            ' 
            ' documentTrackingRibbonPageGroup1
            ' 
            Me.documentTrackingRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentTrackingRibbonPageGroup1.ItemLinks.Add(Me.toggleTrackChangesBarItem1, "G")
            Me.documentTrackingRibbonPageGroup1.ItemLinks.Add(Me.changeDisplayForReviewModeItem1, "TD")
            Me.documentTrackingRibbonPageGroup1.ItemLinks.Add(Me.showMarkupSubItem1, "TM")
            Me.documentTrackingRibbonPageGroup1.ItemLinks.Add(Me.reviewingPaneItem1)
            Me.documentTrackingRibbonPageGroup1.Name = "documentTrackingRibbonPageGroup1"
            ' 
            ' documentChangesRibbonPageGroup1
            ' 
            Me.documentChangesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentChangesRibbonPageGroup1.ItemLinks.Add(Me.acceptAndMoveToNextSubItem1, "M")
            Me.documentChangesRibbonPageGroup1.ItemLinks.Add(Me.rejectAndMoveToNextSubItem1, "M")
            Me.documentChangesRibbonPageGroup1.ItemLinks.Add(Me.previousChangeItem1, "H")
            Me.documentChangesRibbonPageGroup1.ItemLinks.Add(Me.nextChangeItem1, "F")
            Me.documentChangesRibbonPageGroup1.Name = "documentChangesRibbonPageGroup1"
            ' 
            ' pnlAlert
            ' 
            Me.pnlAlert.BackColor = System.Drawing.Color.LemonChiffon
            Me.pnlAlert.Controls.Add(Me.label2)
            Me.pnlAlert.Controls.Add(Me.label1)
            Me.pnlAlert.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlAlert.Location = New System.Drawing.Point(0, 150)
            Me.pnlAlert.Name = "pnlAlert"
            Me.pnlAlert.Size = New System.Drawing.Size(738, 32)
            Me.pnlAlert.TabIndex = 4
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(120, 10)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(567, 13)
            Me.label2.TabIndex = 6
            Me.label2.Text = "Permission to this document is restricted. Only certain users are authorized to e" & "dit specific portions of this document."
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.label1.Location = New System.Drawing.Point(3, 10)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(111, 13)
            Me.label1.TabIndex = 6
            Me.label1.Text = "Restricted Access:"
            ' 
            ' richEditBarController1
            ' 
            Me.richEditBarController1.BarItems.Add(Me.checkSpellingItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeLanguageItem1)
            Me.richEditBarController1.BarItems.Add(Me.protectDocumentItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeRangeEditingPermissionsItem1)
            Me.richEditBarController1.BarItems.Add(Me.unprotectDocumentItem1)
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
            Me.richEditBarController1.BarItems.Add(Me.newCommentItem1)
            Me.richEditBarController1.BarItems.Add(Me.deleteCommentsItem1)
            Me.richEditBarController1.BarItems.Add(Me.deleteOneCommentItem1)
            Me.richEditBarController1.BarItems.Add(Me.deleteAllCommentsShownItem1)
            Me.richEditBarController1.BarItems.Add(Me.deleteAllCommentsItem1)
            Me.richEditBarController1.BarItems.Add(Me.previousCommentItem1)
            Me.richEditBarController1.BarItems.Add(Me.nextCommentItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeCommentItem1)
            Me.richEditBarController1.BarItems.Add(Me.reviewersItem1)
            Me.richEditBarController1.BarItems.Add(Me.reviewingPaneItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTrackChangesBarItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeDisplayForReviewModeItem1)
            Me.richEditBarController1.BarItems.Add(Me.showMarkupSubItem1)
            Me.richEditBarController1.BarItems.Add(Me.acceptAndMoveToNextSubItem1)
            Me.richEditBarController1.BarItems.Add(Me.rejectAndMoveToNextSubItem1)
            Me.richEditBarController1.BarItems.Add(Me.previousChangeItem1)
            Me.richEditBarController1.BarItems.Add(Me.nextChangeItem1)
            Me.richEditBarController1.Control = Me.richEditControl
            ' 
            ' separatorControl1
            ' 
            Me.separatorControl1.AutoSizeMode = True
            Me.separatorControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.separatorControl1.Location = New System.Drawing.Point(0, 182)
            Me.separatorControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.separatorControl1.Name = "separatorControl1"
            Me.separatorControl1.Padding = New System.Windows.Forms.Padding(0)
            Me.separatorControl1.Size = New System.Drawing.Size(738, 268)
            Me.separatorControl1.TabIndex = 7
            ' 
            ' DocumentProtectionModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.separatorControl1)
            Me.Controls.Add(Me.richEditControl)
            Me.Controls.Add(Me.pnlAlert)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "DocumentProtectionModule"
            Me.Size = New System.Drawing.Size(738, 450)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemFontEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemRichEditFontSizeEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbUsers), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.displayForReviewModeComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlAlert.ResumeLayout(False)
            Me.pnlAlert.PerformLayout()
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.separatorControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private richEditControl As DevExpress.XtraRichEdit.RichEditControl

        Private pnlAlert As System.Windows.Forms.Panel

        Private label2 As System.Windows.Forms.Label

        Private label1 As System.Windows.Forms.Label

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl

        Private checkSpellingItem1 As DevExpress.XtraRichEdit.UI.CheckSpellingItem

        Private changeLanguageItem1 As DevExpress.XtraRichEdit.UI.ChangeLanguageItem

        Private protectDocumentItem1 As DevExpress.XtraRichEdit.UI.ProtectDocumentItem

        Private changeRangeEditingPermissionsItem1 As DevExpress.XtraRichEdit.UI.ChangeRangeEditingPermissionsItem

        Private unprotectDocumentItem1 As DevExpress.XtraRichEdit.UI.UnprotectDocumentItem

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

        Private reviewRibbonPage1 As DevExpress.XtraRichEdit.UI.ReviewRibbonPage

        Private documentProtectionRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.DocumentProtectionRibbonPageGroup

        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController

        Private barEditItem1 As DevExpress.XtraBars.BarEditItem

        Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox

        Private usersBarEditItem As DevExpress.XtraBars.BarEditItem

        Private cbUsers As DevExpress.XtraEditors.Repository.RepositoryItemComboBox

        Private newCommentItem1 As DevExpress.XtraRichEdit.UI.NewCommentItem

        Private deleteCommentsItem1 As DevExpress.XtraRichEdit.UI.DeleteCommentsItem

        Private deleteOneCommentItem1 As DevExpress.XtraRichEdit.UI.DeleteOneCommentItem

        Private deleteAllCommentsShownItem1 As DevExpress.XtraRichEdit.UI.DeleteAllCommentsShownItem

        Private deleteAllCommentsItem1 As DevExpress.XtraRichEdit.UI.DeleteAllCommentsItem

        Private previousCommentItem1 As DevExpress.XtraRichEdit.UI.PreviousCommentItem

        Private nextCommentItem1 As DevExpress.XtraRichEdit.UI.NextCommentItem

        Private changeCommentItem1 As DevExpress.XtraRichEdit.UI.ChangeCommentItem

        Private reviewersItem1 As DevExpress.XtraRichEdit.UI.ReviewersItem

        Private reviewingPaneItem1 As DevExpress.XtraRichEdit.UI.ReviewingPaneItem

        Private documentCommentRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.DocumentCommentRibbonPageGroup

        Private toggleTrackChangesBarItem1 As DevExpress.XtraRichEdit.UI.ToggleTrackChangesBarItem

        Private changeDisplayForReviewModeItem1 As DevExpress.XtraRichEdit.UI.ChangeDisplayForReviewModeItem

        Private displayForReviewModeComboBox1 As DevExpress.XtraRichEdit.UI.DisplayForReviewModeComboBox

        Private showMarkupSubItem1 As DevExpress.XtraRichEdit.UI.ShowMarkupSubItem

        Private acceptAndMoveToNextSubItem1 As DevExpress.XtraRichEdit.UI.AcceptAndMoveToNextSubItem

        Private rejectAndMoveToNextSubItem1 As DevExpress.XtraRichEdit.UI.RejectAndMoveToNextSubItem

        Private previousChangeItem1 As DevExpress.XtraRichEdit.UI.PreviousChangeItem

        Private nextChangeItem1 As DevExpress.XtraRichEdit.UI.NextChangeItem

        Private documentTrackingRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.DocumentTrackingRibbonPageGroup

        Private documentChangesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.DocumentChangesRibbonPageGroup

        Private separatorControl1 As DevExpress.XtraEditors.SeparatorControl
    End Class
End Namespace
