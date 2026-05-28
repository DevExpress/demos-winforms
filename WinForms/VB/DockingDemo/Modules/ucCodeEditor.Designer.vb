Namespace DevExpress.XtraBars.Demos.DockingDemo

    Partial Class ucCodeEditor

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraBars.Demos.DockingDemo.ucCodeEditor))
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.editBar = New DevExpress.XtraRichEdit.UI.CommonBar()
            Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
            Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
            Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
            Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
            Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
            Me.findItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
            Me.repositoryItemRichEditStyleEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController(Me.components)
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemFontEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemRichEditFontSizeEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemRichEditStyleEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
            Me.richEditControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl1.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel
            Me.richEditControl1.Location = New System.Drawing.Point(0, 28)
            Me.richEditControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.richEditControl1.MenuManager = Me.barManager1
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEditControl1.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEditControl1.Size = New System.Drawing.Size(820, 463)
            Me.richEditControl1.TabIndex = 0
            Me.richEditControl1.Views.DraftView.AdjustColorsToSkins = True
            ' 
            ' barManager1
            ' 
            Me.barManager1.AllowGlyphSkinning = True
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.editBar})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.fileSaveItem1, Me.undoItem1, Me.redoItem1, Me.pasteItem1, Me.cutItem1, Me.copyItem1, Me.findItem1})
            Me.barManager1.MaxItemId = 58
            Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1, Me.repositoryItemRichEditStyleEdit1})
            Me.barManager1.UseAltKeyForMenu = False
            ' 
            ' editBar
            ' 
            Me.editBar.BarName = "Edit"
            Me.editBar.Control = Me.richEditControl1
            Me.editBar.DockCol = 0
            Me.editBar.DockRow = 0
            Me.editBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.editBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.fileSaveItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.copyItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pasteItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.undoItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.redoItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.findItem1)})
            ' 
            ' fileSaveItem1
            ' 
            Me.fileSaveItem1.Id = 2
            Me.fileSaveItem1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.fileSaveItem1.ImageOptions.SvgImage = CType((resources.GetObject("fileSaveItem1.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.fileSaveItem1.Name = "fileSaveItem1"
            ' 
            ' copyItem1
            ' 
            Me.copyItem1.Id = 11
            Me.copyItem1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.copyItem1.ImageOptions.SvgImage = CType((resources.GetObject("copyItem1.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.copyItem1.Name = "copyItem1"
            ' 
            ' pasteItem1
            ' 
            Me.pasteItem1.Id = 9
            Me.pasteItem1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.pasteItem1.ImageOptions.SvgImage = CType((resources.GetObject("pasteItem1.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.pasteItem1.Name = "pasteItem1"
            ' 
            ' undoItem1
            ' 
            Me.undoItem1.Id = 7
            Me.undoItem1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.undoItem1.ImageOptions.SvgImage = CType((resources.GetObject("undoItem1.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.undoItem1.Name = "undoItem1"
            ' 
            ' redoItem1
            ' 
            Me.redoItem1.Id = 8
            Me.redoItem1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.redoItem1.ImageOptions.SvgImage = CType((resources.GetObject("redoItem1.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.redoItem1.Name = "redoItem1"
            ' 
            ' findItem1
            ' 
            Me.findItem1.Id = 56
            Me.findItem1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.findItem1.ImageOptions.SvgImage = CType((resources.GetObject("findItem1.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.findItem1.Name = "findItem1"
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager1
            Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(2)
            Me.barDockControlTop.Size = New System.Drawing.Size(820, 28)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 491)
            Me.barDockControlBottom.Manager = Me.barManager1
            Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(2)
            Me.barDockControlBottom.Size = New System.Drawing.Size(820, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 28)
            Me.barDockControlLeft.Manager = Me.barManager1
            Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(2)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 463)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(820, 28)
            Me.barDockControlRight.Manager = Me.barManager1
            Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(2)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 463)
            ' 
            ' cutItem1
            ' 
            Me.cutItem1.Id = 10
            Me.cutItem1.ImageOptions.SvgImage = CType((resources.GetObject("cutItem1.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.cutItem1.Name = "cutItem1"
            ' 
            ' repositoryItemFontEdit1
            ' 
            Me.repositoryItemFontEdit1.AutoHeight = False
            Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
            ' 
            ' repositoryItemRichEditFontSizeEdit1
            ' 
            Me.repositoryItemRichEditFontSizeEdit1.AutoHeight = False
            Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditFontSizeEdit1.Control = Me.richEditControl1
            Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
            ' 
            ' repositoryItemRichEditStyleEdit1
            ' 
            Me.repositoryItemRichEditStyleEdit1.AutoHeight = False
            Me.repositoryItemRichEditStyleEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditStyleEdit1.Control = Me.richEditControl1
            Me.repositoryItemRichEditStyleEdit1.Name = "repositoryItemRichEditStyleEdit1"
            ' 
            ' richEditBarController1
            ' 
            Me.richEditBarController1.BarItems.Add(Me.fileSaveItem1)
            Me.richEditBarController1.BarItems.Add(Me.undoItem1)
            Me.richEditBarController1.BarItems.Add(Me.redoItem1)
            Me.richEditBarController1.BarItems.Add(Me.pasteItem1)
            Me.richEditBarController1.BarItems.Add(Me.cutItem1)
            Me.richEditBarController1.BarItems.Add(Me.copyItem1)
            Me.richEditBarController1.BarItems.Add(Me.findItem1)
            Me.richEditBarController1.Control = Me.richEditControl1
            ' 
            ' ucCodeEditor
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.richEditControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "ucCodeEditor"
            Me.Size = New System.Drawing.Size(820, 491)
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemFontEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemRichEditFontSizeEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemRichEditStyleEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl

        Private barManager1 As DevExpress.XtraBars.BarManager

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

        Private editBar As DevExpress.XtraRichEdit.UI.CommonBar

        Private fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem

        Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem

        Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem

        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController

        Private pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem

        Private cutItem1 As DevExpress.XtraRichEdit.UI.CutItem

        Private copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem

        Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit

        Private repositoryItemRichEditFontSizeEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit

        Private repositoryItemRichEditStyleEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit

        Private findItem1 As DevExpress.XtraRichEdit.UI.FindItem
    End Class
End Namespace
