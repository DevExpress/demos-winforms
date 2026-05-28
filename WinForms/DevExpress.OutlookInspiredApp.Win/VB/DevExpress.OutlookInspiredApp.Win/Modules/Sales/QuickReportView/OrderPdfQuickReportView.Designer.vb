Namespace DevExpress.DevAV.Modules

    Partial Class OrderPdfQuickReportView

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
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.pdfFileOpenBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem()
            Me.pdfFileSaveAsBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem()
            Me.pdfFilePrintBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem()
            Me.pdfFindTextBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem()
            Me.pdfPreviousPageBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem()
            Me.pdfNextPageBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem()
            Me.pdfSetPageNumberBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem()
            Me.repositoryItemPageNumberEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit()
            Me.pdfZoomOutBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem()
            Me.pdfZoomInBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem()
            Me.pdfExactZoomListBarSubItem1 = New DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem()
            Me.pdfZoom10CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem()
            Me.pdfZoom25CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem()
            Me.pdfZoom50CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem()
            Me.pdfZoom75CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem()
            Me.pdfZoom100CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem()
            Me.pdfZoom125CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem()
            Me.pdfZoom150CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem()
            Me.pdfZoom200CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem()
            Me.pdfZoom400CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem()
            Me.pdfZoom500CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem()
            Me.pdfSetActualSizeZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem()
            Me.pdfSetPageLevelZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem()
            Me.pdfSetFitWidthZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem()
            Me.pdfSetFitVisibleZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem()
            Me.pdfExportFormDataBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem()
            Me.pdfImportFormDataBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem()
            Me.pdfRibbonPage1 = New DevExpress.XtraPdfViewer.Bars.PdfRibbonPage()
            Me.pdfFileRibbonPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfFileRibbonPageGroup()
            Me.pdfFindRibbonPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfFindRibbonPageGroup()
            Me.pdfNavigationRibbonPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfNavigationRibbonPageGroup()
            Me.pdfZoomRibbonPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomRibbonPageGroup()
            Me.pdfFormDataRibbonPage1 = New DevExpress.XtraPdfViewer.Bars.PdfFormDataRibbonPage()
            Me.pdfFormDataBarPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfFormDataBarPageGroup()
            Me.pdfViewer1 = New DevExpress.XtraPdfViewer.PdfViewer()
            Me.pdfBarController1 = New DevExpress.XtraPdfViewer.Bars.PdfBarController(Me.components)
            Me.roundedSkinPanel1 = New DevExpress.XtraEditors.RoundedSkinPanel()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemPageNumberEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pdfBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.roundedSkinPanel1.SuspendLayout()
            Me.SuspendLayout()
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.pdfFileOpenBarItem1, Me.pdfFileSaveAsBarItem1, Me.pdfFilePrintBarItem1, Me.pdfFindTextBarItem1, Me.pdfPreviousPageBarItem1, Me.pdfNextPageBarItem1, Me.pdfSetPageNumberBarItem1, Me.pdfZoomOutBarItem1, Me.pdfZoomInBarItem1, Me.pdfExactZoomListBarSubItem1, Me.pdfZoom10CheckItem1, Me.pdfZoom25CheckItem1, Me.pdfZoom50CheckItem1, Me.pdfZoom75CheckItem1, Me.pdfZoom100CheckItem1, Me.pdfZoom125CheckItem1, Me.pdfZoom150CheckItem1, Me.pdfZoom200CheckItem1, Me.pdfZoom400CheckItem1, Me.pdfZoom500CheckItem1, Me.pdfSetActualSizeZoomModeCheckItem1, Me.pdfSetPageLevelZoomModeCheckItem1, Me.pdfSetFitWidthZoomModeCheckItem1, Me.pdfSetFitVisibleZoomModeCheckItem1, Me.pdfExportFormDataBarItem1, Me.pdfImportFormDataBarItem1})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 27
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.pdfRibbonPage1, Me.pdfFormDataRibbonPage1})
            Me.ribbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemPageNumberEdit1})
            Me.ribbonControl.Size = New System.Drawing.Size(1000, 200)
            Me.pdfFileOpenBarItem1.Id = 1
            Me.pdfFileOpenBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O))
            Me.pdfFileOpenBarItem1.Name = "pdfFileOpenBarItem1"
            Me.pdfFileSaveAsBarItem1.Id = 2
            Me.pdfFileSaveAsBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
            Me.pdfFileSaveAsBarItem1.Name = "pdfFileSaveAsBarItem1"
            Me.pdfFilePrintBarItem1.Id = 3
            Me.pdfFilePrintBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
            Me.pdfFilePrintBarItem1.Name = "pdfFilePrintBarItem1"
            Me.pdfFindTextBarItem1.Id = 4
            Me.pdfFindTextBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
            Me.pdfFindTextBarItem1.Name = "pdfFindTextBarItem1"
            Me.pdfPreviousPageBarItem1.Id = 5
            Me.pdfPreviousPageBarItem1.Name = "pdfPreviousPageBarItem1"
            Me.pdfNextPageBarItem1.Id = 6
            Me.pdfNextPageBarItem1.Name = "pdfNextPageBarItem1"
            Me.pdfSetPageNumberBarItem1.Edit = Me.repositoryItemPageNumberEdit1
            Me.pdfSetPageNumberBarItem1.Id = 7
            Me.pdfSetPageNumberBarItem1.Name = "pdfSetPageNumberBarItem1"
            Me.repositoryItemPageNumberEdit1.AutoHeight = False
            Me.repositoryItemPageNumberEdit1.Mask.EditMask = "########;"
            Me.repositoryItemPageNumberEdit1.Name = "repositoryItemPageNumberEdit1"
            Me.pdfZoomOutBarItem1.Id = 8
            Me.pdfZoomOutBarItem1.Name = "pdfZoomOutBarItem1"
            Me.pdfZoomInBarItem1.Id = 9
            Me.pdfZoomInBarItem1.Name = "pdfZoomInBarItem1"
            Me.pdfExactZoomListBarSubItem1.Id = 10
            Me.pdfExactZoomListBarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom10CheckItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom25CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom50CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom75CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom100CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom125CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom150CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom200CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom400CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom500CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfSetActualSizeZoomModeCheckItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfSetPageLevelZoomModeCheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfSetFitWidthZoomModeCheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfSetFitVisibleZoomModeCheckItem1)})
            Me.pdfExactZoomListBarSubItem1.Name = "pdfExactZoomListBarSubItem1"
            Me.pdfExactZoomListBarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            Me.pdfZoom10CheckItem1.Id = 11
            Me.pdfZoom10CheckItem1.Name = "pdfZoom10CheckItem1"
            Me.pdfZoom25CheckItem1.Id = 12
            Me.pdfZoom25CheckItem1.Name = "pdfZoom25CheckItem1"
            Me.pdfZoom50CheckItem1.Id = 13
            Me.pdfZoom50CheckItem1.Name = "pdfZoom50CheckItem1"
            Me.pdfZoom75CheckItem1.Id = 14
            Me.pdfZoom75CheckItem1.Name = "pdfZoom75CheckItem1"
            Me.pdfZoom100CheckItem1.Id = 15
            Me.pdfZoom100CheckItem1.Name = "pdfZoom100CheckItem1"
            Me.pdfZoom125CheckItem1.Id = 16
            Me.pdfZoom125CheckItem1.Name = "pdfZoom125CheckItem1"
            Me.pdfZoom150CheckItem1.Id = 17
            Me.pdfZoom150CheckItem1.Name = "pdfZoom150CheckItem1"
            Me.pdfZoom200CheckItem1.Id = 18
            Me.pdfZoom200CheckItem1.Name = "pdfZoom200CheckItem1"
            Me.pdfZoom400CheckItem1.Id = 19
            Me.pdfZoom400CheckItem1.Name = "pdfZoom400CheckItem1"
            Me.pdfZoom500CheckItem1.Id = 20
            Me.pdfZoom500CheckItem1.Name = "pdfZoom500CheckItem1"
            Me.pdfSetActualSizeZoomModeCheckItem1.Id = 21
            Me.pdfSetActualSizeZoomModeCheckItem1.Name = "pdfSetActualSizeZoomModeCheckItem1"
            Me.pdfSetPageLevelZoomModeCheckItem1.Id = 22
            Me.pdfSetPageLevelZoomModeCheckItem1.Name = "pdfSetPageLevelZoomModeCheckItem1"
            Me.pdfSetFitWidthZoomModeCheckItem1.Id = 23
            Me.pdfSetFitWidthZoomModeCheckItem1.Name = "pdfSetFitWidthZoomModeCheckItem1"
            Me.pdfSetFitVisibleZoomModeCheckItem1.Id = 24
            Me.pdfSetFitVisibleZoomModeCheckItem1.Name = "pdfSetFitVisibleZoomModeCheckItem1"
            Me.pdfExportFormDataBarItem1.Id = 25
            Me.pdfExportFormDataBarItem1.Name = "pdfExportFormDataBarItem1"
            Me.pdfImportFormDataBarItem1.Id = 26
            Me.pdfImportFormDataBarItem1.Name = "pdfImportFormDataBarItem1"
            Me.pdfRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.pdfFileRibbonPageGroup1, Me.pdfFindRibbonPageGroup1, Me.pdfNavigationRibbonPageGroup1, Me.pdfZoomRibbonPageGroup1})
            Me.pdfRibbonPage1.Name = "pdfRibbonPage1"
            Me.pdfFileRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.pdfFileRibbonPageGroup1.ItemLinks.Add(Me.pdfFileOpenBarItem1)
            Me.pdfFileRibbonPageGroup1.ItemLinks.Add(Me.pdfFileSaveAsBarItem1)
            Me.pdfFileRibbonPageGroup1.ItemLinks.Add(Me.pdfFilePrintBarItem1)
            Me.pdfFileRibbonPageGroup1.Name = "pdfFileRibbonPageGroup1"
            Me.pdfFindRibbonPageGroup1.AllowTextClipping = False
            Me.pdfFindRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.pdfFindRibbonPageGroup1.ItemLinks.Add(Me.pdfFindTextBarItem1)
            Me.pdfFindRibbonPageGroup1.Name = "pdfFindRibbonPageGroup1"
            Me.pdfNavigationRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.pdfNavigationRibbonPageGroup1.ItemLinks.Add(Me.pdfPreviousPageBarItem1)
            Me.pdfNavigationRibbonPageGroup1.ItemLinks.Add(Me.pdfNextPageBarItem1)
            Me.pdfNavigationRibbonPageGroup1.ItemLinks.Add(Me.pdfSetPageNumberBarItem1)
            Me.pdfNavigationRibbonPageGroup1.Name = "pdfNavigationRibbonPageGroup1"
            Me.pdfZoomRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.pdfZoomRibbonPageGroup1.ItemLinks.Add(Me.pdfZoomOutBarItem1)
            Me.pdfZoomRibbonPageGroup1.ItemLinks.Add(Me.pdfZoomInBarItem1)
            Me.pdfZoomRibbonPageGroup1.ItemLinks.Add(Me.pdfExactZoomListBarSubItem1)
            Me.pdfZoomRibbonPageGroup1.Name = "pdfZoomRibbonPageGroup1"
            Me.pdfFormDataRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.pdfFormDataBarPageGroup1})
            Me.pdfFormDataRibbonPage1.Name = "pdfFormDataRibbonPage1"
            Me.pdfFormDataBarPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.pdfFormDataBarPageGroup1.ItemLinks.Add(Me.pdfExportFormDataBarItem1)
            Me.pdfFormDataBarPageGroup1.ItemLinks.Add(Me.pdfImportFormDataBarItem1)
            Me.pdfFormDataBarPageGroup1.Name = "pdfFormDataBarPageGroup1"
            Me.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pdfViewer1.Location = New System.Drawing.Point(17, 17)
            Me.pdfViewer1.MenuManager = Me.ribbonControl
            Me.pdfViewer1.MinimumSize = New System.Drawing.Size(32, 32)
            Me.pdfViewer1.Name = "pdfViewer1"
            Me.pdfViewer1.Size = New System.Drawing.Size(966, 566)
            Me.pdfViewer1.TabIndex = 1
            Me.pdfBarController1.BarItems.Add(Me.pdfFileOpenBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfFileSaveAsBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfFilePrintBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfFindTextBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfPreviousPageBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfNextPageBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfSetPageNumberBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoomOutBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoomInBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfExactZoomListBarSubItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom10CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom25CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom50CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom75CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom100CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom125CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom150CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom200CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom400CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom500CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfSetActualSizeZoomModeCheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfSetPageLevelZoomModeCheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfSetFitWidthZoomModeCheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfSetFitVisibleZoomModeCheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfExportFormDataBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfImportFormDataBarItem1)
            Me.pdfBarController1.Control = Me.pdfViewer1
            Me.roundedSkinPanel1.Controls.Add(Me.pdfViewer1)
            Me.roundedSkinPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.roundedSkinPanel1.Location = New System.Drawing.Point(0, 200)
            Me.roundedSkinPanel1.Name = "roundedSkinPanel1"
            Me.roundedSkinPanel1.Size = New System.Drawing.Size(1000, 600)
            Me.roundedSkinPanel1.TabIndex = 3
            Me.roundedSkinPanel1.Text = "roundedSkinPanel1"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.roundedSkinPanel1)
            Me.Controls.Add(Me.ribbonControl)
            Me.Name = "OrderPdfQuickReportView"
            Me.Size = New System.Drawing.Size(1000, 800)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemPageNumberEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pdfBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.roundedSkinPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl

        Private pdfViewer1 As DevExpress.XtraPdfViewer.PdfViewer

        Private pdfFileOpenBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem

        Private pdfFileSaveAsBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem

        Private pdfFilePrintBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem

        Private pdfFindTextBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem

        Private pdfPreviousPageBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem

        Private pdfNextPageBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem

        Private pdfSetPageNumberBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem

        Private repositoryItemPageNumberEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit

        Private pdfZoomOutBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem

        Private pdfZoomInBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem

        Private pdfExactZoomListBarSubItem1 As DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem

        Private pdfZoom10CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem

        Private pdfZoom25CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem

        Private pdfZoom50CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem

        Private pdfZoom75CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem

        Private pdfZoom100CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem

        Private pdfZoom125CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem

        Private pdfZoom150CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem

        Private pdfZoom200CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem

        Private pdfZoom400CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem

        Private pdfZoom500CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem

        Private pdfSetActualSizeZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem

        Private pdfSetPageLevelZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem

        Private pdfSetFitWidthZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem

        Private pdfSetFitVisibleZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem

        Private pdfExportFormDataBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem

        Private pdfImportFormDataBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem

        Private pdfRibbonPage1 As DevExpress.XtraPdfViewer.Bars.PdfRibbonPage

        Private pdfFileRibbonPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfFileRibbonPageGroup

        Private pdfFindRibbonPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfFindRibbonPageGroup

        Private pdfNavigationRibbonPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfNavigationRibbonPageGroup

        Private pdfZoomRibbonPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfZoomRibbonPageGroup

        Private pdfFormDataRibbonPage1 As DevExpress.XtraPdfViewer.Bars.PdfFormDataRibbonPage

        Private pdfFormDataBarPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfFormDataBarPageGroup

        Private pdfBarController1 As DevExpress.XtraPdfViewer.Bars.PdfBarController

        Private roundedSkinPanel1 As DevExpress.XtraEditors.RoundedSkinPanel
    End Class
End Namespace
