Namespace DevExpress.XtraRichEdit.Demos

    Partial Class SyntaxHighlightingModule

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
            Dim optionsSpelling1 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.spellChecker1 = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
            Me.standaloneBarDockControl2 = New DevExpress.XtraBars.StandaloneBarDockControl()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.clipboardBar1 = New DevExpress.XtraRichEdit.UI.ClipboardBar()
            Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
            Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
            Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
            Me.zoomBar1 = New DevExpress.XtraRichEdit.UI.ZoomBar()
            Me.zoomOutItem1 = New DevExpress.XtraRichEdit.UI.ZoomOutItem()
            Me.zoomInItem1 = New DevExpress.XtraRichEdit.UI.ZoomInItem()
            Me.commonBar2 = New DevExpress.XtraRichEdit.UI.CommonBar()
            Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
            Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
            Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
            Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
            Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
            Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
            Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
            Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
            Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
            Me.fileInfoBar1 = New DevExpress.XtraRichEdit.UI.FileInfoBar()
            Me.showDocumentPropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.findItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
            Me.replaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem()
            Me.changeStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeStyleItem()
            Me.repositoryItemRichEditStyleEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController(Me.components)
            Me.sharedDictionaryStorage1 = New DevExpress.XtraSpellChecker.SharedDictionaryStorage(Me.components)
            Me.separatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemRichEditStyleEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.separatorControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Controls.Add(Me.separatorControl1)
            Me.panelControl2.Controls.Add(Me.richEditControl)
            Me.panelControl2.Controls.Add(Me.standaloneBarDockControl2)
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl2.Location = New System.Drawing.Point(0, 0)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(691, 429)
            Me.panelControl2.TabIndex = 1
            ' 
            ' richEditControl
            ' 
            Me.richEditControl.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
            Me.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel
            Me.richEditControl.Location = New System.Drawing.Point(0, 24)
            Me.richEditControl.MenuManager = Me
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Options.AutoCorrect.DetectUrls = False
            Me.richEditControl.Options.AutoCorrect.ReplaceTextAsYouType = False
            Me.richEditControl.Options.Behavior.PasteLineBreakSubstitution = DevExpress.XtraRichEdit.LineBreakSubstitute.Paragraph
            Me.richEditControl.Options.DocumentCapabilities.Bookmarks = DevExpress.XtraRichEdit.DocumentCapability.Disabled
            Me.richEditControl.Options.DocumentCapabilities.CharacterStyle = DevExpress.XtraRichEdit.DocumentCapability.Disabled
            Me.richEditControl.Options.DocumentCapabilities.HeadersFooters = DevExpress.XtraRichEdit.DocumentCapability.Disabled
            Me.richEditControl.Options.DocumentCapabilities.Hyperlinks = DevExpress.XtraRichEdit.DocumentCapability.Disabled
            Me.richEditControl.Options.DocumentCapabilities.InlinePictures = DevExpress.XtraRichEdit.DocumentCapability.Disabled
            Me.richEditControl.Options.DocumentCapabilities.Numbering.Bulleted = DevExpress.XtraRichEdit.DocumentCapability.Disabled
            Me.richEditControl.Options.DocumentCapabilities.Numbering.MultiLevel = DevExpress.XtraRichEdit.DocumentCapability.Disabled
            Me.richEditControl.Options.DocumentCapabilities.Numbering.Simple = DevExpress.XtraRichEdit.DocumentCapability.Disabled
            Me.richEditControl.Options.DocumentCapabilities.ParagraphFormatting = DevExpress.XtraRichEdit.DocumentCapability.Disabled
            Me.richEditControl.Options.DocumentCapabilities.Paragraphs = DevExpress.XtraRichEdit.DocumentCapability.Enabled
            Me.richEditControl.Options.DocumentCapabilities.ParagraphStyle = DevExpress.XtraRichEdit.DocumentCapability.Disabled
            Me.richEditControl.Options.DocumentCapabilities.Sections = DevExpress.XtraRichEdit.DocumentCapability.Disabled
            Me.richEditControl.Options.DocumentCapabilities.Tables = DevExpress.XtraRichEdit.DocumentCapability.Disabled
            Me.richEditControl.Options.DocumentCapabilities.TableStyle = DevExpress.XtraRichEdit.DocumentCapability.Disabled
            Me.richEditControl.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEditControl.Size = New System.Drawing.Size(691, 405)
            Me.richEditControl.SpellChecker = Me.spellChecker1
            Me.spellChecker1.SetSpellCheckerOptions(Me.richEditControl, optionsSpelling1)
            Me.richEditControl.TabIndex = 1
            Me.richEditControl.Text = "richEditControl1"
            Me.richEditControl.Views.DraftView.AllowDisplayLineNumbers = True
            Me.richEditControl.Views.DraftView.Padding = New DevExpress.Portable.PortablePadding(80, 4, 0, 0)
            Me.richEditControl.Views.SimpleView.Padding = New DevExpress.Portable.PortablePadding(50, 4, 4, 0)
            AddHandler Me.richEditControl.InitializeDocument, New System.EventHandler(AddressOf Me.richEditControl_InitializeDocument)
            ' 
            ' spellChecker1
            ' 
            Me.spellChecker1.Culture = New System.Globalization.CultureInfo("en-US")
            Me.spellChecker1.ParentContainer = Nothing
            ' 
            ' standaloneBarDockControl2
            ' 
            Me.standaloneBarDockControl2.AutoSize = True
            Me.standaloneBarDockControl2.CausesValidation = False
            Me.standaloneBarDockControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.standaloneBarDockControl2.Location = New System.Drawing.Point(0, 0)
            Me.standaloneBarDockControl2.Manager = Me.barManager1
            Me.standaloneBarDockControl2.Name = "standaloneBarDockControl2"
            Me.standaloneBarDockControl2.Size = New System.Drawing.Size(691, 24)
            Me.standaloneBarDockControl2.Text = "standaloneBarDockControl2"
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.clipboardBar1, Me.zoomBar1, Me.commonBar2, Me.fileInfoBar1})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.DockControls.Add(Me.standaloneBarDockControl2)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cutItem1, Me.copyItem1, Me.pasteItem1, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.undoItem1, Me.redoItem1, Me.findItem1, Me.replaceItem1, Me.changeStyleItem1, Me.zoomOutItem1, Me.zoomInItem1, Me.showDocumentPropertiesFormItem1})
            Me.barManager1.MaxItemId = 35
            Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemRichEditStyleEdit1})
            ' 
            ' clipboardBar1
            ' 
            Me.clipboardBar1.Control = Me.richEditControl
            Me.clipboardBar1.DockCol = 2
            Me.clipboardBar1.DockRow = 0
            Me.clipboardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.clipboardBar1.FloatLocation = New System.Drawing.Point(41, 296)
            Me.clipboardBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.copyItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pasteItem1)})
            Me.clipboardBar1.StandaloneBarDockControl = Me.standaloneBarDockControl2
            ' 
            ' cutItem1
            ' 
            Me.cutItem1.Id = 0
            Me.cutItem1.Name = "cutItem1"
            ' 
            ' copyItem1
            ' 
            Me.copyItem1.Id = 1
            Me.copyItem1.Name = "copyItem1"
            ' 
            ' pasteItem1
            ' 
            Me.pasteItem1.Id = 2
            Me.pasteItem1.Name = "pasteItem1"
            ' 
            ' zoomBar1
            ' 
            Me.zoomBar1.Control = Me.richEditControl
            Me.zoomBar1.DockCol = 3
            Me.zoomBar1.DockRow = 0
            Me.zoomBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.zoomBar1.FloatLocation = New System.Drawing.Point(147, 240)
            Me.zoomBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.zoomOutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.zoomInItem1)})
            Me.zoomBar1.Offset = 332
            Me.zoomBar1.StandaloneBarDockControl = Me.standaloneBarDockControl2
            ' 
            ' zoomOutItem1
            ' 
            Me.zoomOutItem1.Id = 9
            Me.zoomOutItem1.Name = "zoomOutItem1"
            ' 
            ' zoomInItem1
            ' 
            Me.zoomInItem1.Id = 10
            Me.zoomInItem1.Name = "zoomInItem1"
            ' 
            ' commonBar2
            ' 
            Me.commonBar2.Control = Me.richEditControl
            Me.commonBar2.DockCol = 0
            Me.commonBar2.DockRow = 0
            Me.commonBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.commonBar2.FloatLocation = New System.Drawing.Point(46, 275)
            Me.commonBar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.fileNewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fileOpenItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fileSaveItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fileSaveAsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.quickPrintItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.undoItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.redoItem1)})
            Me.commonBar2.StandaloneBarDockControl = Me.standaloneBarDockControl2
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
            Me.quickPrintItem1.Id = 11
            Me.quickPrintItem1.Name = "quickPrintItem1"
            ' 
            ' printItem1
            ' 
            Me.printItem1.Id = 12
            Me.printItem1.Name = "printItem1"
            ' 
            ' printPreviewItem1
            ' 
            Me.printPreviewItem1.Id = 13
            Me.printPreviewItem1.Name = "printPreviewItem1"
            ' 
            ' undoItem1
            ' 
            Me.undoItem1.Id = 7
            Me.undoItem1.Name = "undoItem1"
            ' 
            ' redoItem1
            ' 
            Me.redoItem1.Id = 8
            Me.redoItem1.Name = "redoItem1"
            ' 
            ' fileInfoBar1
            ' 
            Me.fileInfoBar1.Control = Me.richEditControl
            Me.fileInfoBar1.DockCol = 1
            Me.fileInfoBar1.DockRow = 0
            Me.fileInfoBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.fileInfoBar1.FloatLocation = New System.Drawing.Point(317, 143)
            Me.fileInfoBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.showDocumentPropertiesFormItem1)})
            Me.fileInfoBar1.StandaloneBarDockControl = Me.standaloneBarDockControl2
            ' 
            ' showDocumentPropertiesFormItem1
            ' 
            Me.showDocumentPropertiesFormItem1.Id = 34
            Me.showDocumentPropertiesFormItem1.Name = "showDocumentPropertiesFormItem1"
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager1
            Me.barDockControlTop.Size = New System.Drawing.Size(691, 0)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 429)
            Me.barDockControlBottom.Manager = Me.barManager1
            Me.barDockControlBottom.Size = New System.Drawing.Size(691, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Me.barManager1
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 429)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(691, 0)
            Me.barDockControlRight.Manager = Me.barManager1
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 429)
            ' 
            ' findItem1
            ' 
            Me.findItem1.Id = 14
            Me.findItem1.Name = "findItem1"
            ' 
            ' replaceItem1
            ' 
            Me.replaceItem1.Id = 15
            Me.replaceItem1.Name = "replaceItem1"
            ' 
            ' changeStyleItem1
            ' 
            Me.changeStyleItem1.Edit = Me.repositoryItemRichEditStyleEdit1
            Me.changeStyleItem1.Id = 16
            Me.changeStyleItem1.Name = "changeStyleItem1"
            ' 
            ' repositoryItemRichEditStyleEdit1
            ' 
            Me.repositoryItemRichEditStyleEdit1.AutoHeight = False
            Me.repositoryItemRichEditStyleEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditStyleEdit1.Control = Me.richEditControl
            Me.repositoryItemRichEditStyleEdit1.Name = "repositoryItemRichEditStyleEdit1"
            ' 
            ' richEditBarController1
            ' 
            Me.richEditBarController1.BarItems.Add(Me.cutItem1)
            Me.richEditBarController1.BarItems.Add(Me.copyItem1)
            Me.richEditBarController1.BarItems.Add(Me.pasteItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileNewItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileOpenItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileSaveItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileSaveAsItem1)
            Me.richEditBarController1.BarItems.Add(Me.quickPrintItem1)
            Me.richEditBarController1.BarItems.Add(Me.printItem1)
            Me.richEditBarController1.BarItems.Add(Me.printPreviewItem1)
            Me.richEditBarController1.BarItems.Add(Me.undoItem1)
            Me.richEditBarController1.BarItems.Add(Me.redoItem1)
            Me.richEditBarController1.BarItems.Add(Me.findItem1)
            Me.richEditBarController1.BarItems.Add(Me.replaceItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeStyleItem1)
            Me.richEditBarController1.BarItems.Add(Me.zoomOutItem1)
            Me.richEditBarController1.BarItems.Add(Me.zoomInItem1)
            Me.richEditBarController1.BarItems.Add(Me.showDocumentPropertiesFormItem1)
            Me.richEditBarController1.Control = Me.richEditControl
            ' 
            ' separatorControl1
            ' 
            Me.separatorControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.separatorControl1.Location = New System.Drawing.Point(0, 24)
            Me.separatorControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.separatorControl1.Name = "separatorControl1"
            Me.separatorControl1.Padding = New System.Windows.Forms.Padding(0)
            Me.separatorControl1.Size = New System.Drawing.Size(691, 1)
            Me.separatorControl1.TabIndex = 3
            ' 
            ' SyntaxHighlightingModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "SyntaxHighlightingModule"
            Me.Size = New System.Drawing.Size(691, 429)
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            Me.panelControl2.PerformLayout()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemRichEditStyleEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.separatorControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private panelControl2 As DevExpress.XtraEditors.PanelControl

        Private richEditControl As DevExpress.XtraRichEdit.RichEditControl

        Private standaloneBarDockControl2 As DevExpress.XtraBars.StandaloneBarDockControl

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl

        Private barManager1 As DevExpress.XtraBars.BarManager

        Private clipboardBar1 As DevExpress.XtraRichEdit.UI.ClipboardBar

        Private cutItem1 As DevExpress.XtraRichEdit.UI.CutItem

        Private copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem

        Private pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem

        Private fileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem

        Private fileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem

        Private fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem

        Private fileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem

        Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem

        Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem

        Private zoomBar1 As DevExpress.XtraRichEdit.UI.ZoomBar

        Private zoomOutItem1 As DevExpress.XtraRichEdit.UI.ZoomOutItem

        Private zoomInItem1 As DevExpress.XtraRichEdit.UI.ZoomInItem

        Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem

        Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem

        Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem

        Private findItem1 As DevExpress.XtraRichEdit.UI.FindItem

        Private replaceItem1 As DevExpress.XtraRichEdit.UI.ReplaceItem

        Private changeStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeStyleItem

        Private repositoryItemRichEditStyleEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit

        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController

        Private commonBar2 As DevExpress.XtraRichEdit.UI.CommonBar

        Private sharedDictionaryStorage1 As DevExpress.XtraSpellChecker.SharedDictionaryStorage

        Private spellChecker1 As DevExpress.XtraSpellChecker.SpellChecker

        Private fileInfoBar1 As DevExpress.XtraRichEdit.UI.FileInfoBar

        Private showDocumentPropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem

        Private separatorControl1 As DevExpress.XtraEditors.SeparatorControl
    End Class
End Namespace
