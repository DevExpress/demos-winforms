Namespace DevExpress.XtraScheduler.Demos

    Partial Class ReportPreviewControl

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraScheduler.Demos.ReportPreviewControl))
            Me.documentViewerCore = New DevExpress.XtraPrinting.Preview.DocumentViewer()
            Me.documentViewerBarManager1 = New DevExpress.XtraPrinting.Preview.DocumentViewerBarManager(Me.components)
            Me.previewBar1 = New DevExpress.XtraPrinting.Preview.PreviewBar()
            Me.printPreviewBarItem18 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewStaticItem1 = New DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem()
            Me.printPreviewBarItem19 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.progressBarEditItem1 = New DevExpress.XtraPrinting.Preview.ProgressBarEditItem()
            Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
            Me.printPreviewBarItem1 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewStaticItem2 = New DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem()
            Me.zoomTrackBarEditItem1 = New DevExpress.XtraPrinting.Preview.ZoomTrackBarEditItem()
            Me.repositoryItemZoomTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar()
            Me.printPreviewBarItemWholePage = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItemMultiplePages = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItemScale = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.printPreviewRepositoryItemComboBox1 = New DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox()
            CType((Me.documentViewerBarManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemZoomTrackBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.printPreviewRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' documentViewerCore
            ' 
            Me.documentViewerCore.Dock = System.Windows.Forms.DockStyle.Fill
            Me.documentViewerCore.IsMetric = False
            Me.documentViewerCore.Location = New System.Drawing.Point(0, 0)
            Me.documentViewerCore.Name = "documentViewerCore"
            Me.documentViewerCore.Size = New System.Drawing.Size(1045, 560)
            Me.documentViewerCore.TabIndex = 0
            ' 
            ' documentViewerBarManager1
            ' 
            Me.documentViewerBarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.previewBar1})
            Me.documentViewerBarManager1.DockControls.Add(Me.barDockControlTop)
            Me.documentViewerBarManager1.DockControls.Add(Me.barDockControlBottom)
            Me.documentViewerBarManager1.DockControls.Add(Me.barDockControlLeft)
            Me.documentViewerBarManager1.DockControls.Add(Me.barDockControlRight)
            Me.documentViewerBarManager1.DocumentViewer = Me.documentViewerCore
            Me.documentViewerBarManager1.Form = Me
            Me.documentViewerBarManager1.ImageStream = CType((resources.GetObject("documentViewerBarManager1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.documentViewerBarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.printPreviewStaticItem1, Me.progressBarEditItem1, Me.printPreviewBarItem1, Me.printPreviewStaticItem2, Me.zoomTrackBarEditItem1, Me.printPreviewBarItemScale, Me.printPreviewBarItem18, Me.printPreviewBarItem19, Me.printPreviewBarItemMultiplePages, Me.printPreviewBarItemWholePage})
            Me.documentViewerBarManager1.MaxItemId = 57
            Me.documentViewerBarManager1.PreviewBar = Me.previewBar1
            Me.documentViewerBarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemProgressBar1, Me.repositoryItemZoomTrackBar1, Me.printPreviewRepositoryItemComboBox1})
            Me.documentViewerBarManager1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' previewBar1
            ' 
            Me.previewBar1.BarName = "Toolbar"
            Me.previewBar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.previewBar1.DockCol = 0
            Me.previewBar1.DockRow = 0
            Me.previewBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.previewBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem18), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem19), New DevExpress.XtraBars.LinkPersistInfo(Me.progressBarEditItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewStaticItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.zoomTrackBarEditItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItemWholePage, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItemMultiplePages), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItemScale)})
            Me.previewBar1.OptionsBar.AllowQuickCustomization = False
            Me.previewBar1.OptionsBar.DrawBorder = False
            Me.previewBar1.OptionsBar.DrawDragBorder = False
            Me.previewBar1.OptionsBar.UseWholeRow = True
            Me.previewBar1.Text = "Toolbar"
            ' 
            ' printPreviewBarItem18
            ' 
            Me.printPreviewBarItem18.Caption = "Previous Page"
            Me.printPreviewBarItem18.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowPrevPage
            Me.printPreviewBarItem18.Enabled = False
            Me.printPreviewBarItem18.Hint = "Previous Page"
            Me.printPreviewBarItem18.Id = 24
            Me.printPreviewBarItem18.ImageOptions.Image = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.icon_page_prev_16
            Me.printPreviewBarItem18.Name = "printPreviewBarItem18"
            ' 
            ' printPreviewStaticItem1
            ' 
            Me.printPreviewStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.printPreviewStaticItem1.Caption = "Nothing"
            Me.printPreviewStaticItem1.Id = 0
            Me.printPreviewStaticItem1.LeftIndent = 1
            Me.printPreviewStaticItem1.Name = "printPreviewStaticItem1"
            Me.printPreviewStaticItem1.RightIndent = 1
            Me.printPreviewStaticItem1.Type = "PageOfPages"
            ' 
            ' printPreviewBarItem19
            ' 
            Me.printPreviewBarItem19.Caption = "Next Page"
            Me.printPreviewBarItem19.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowNextPage
            Me.printPreviewBarItem19.Enabled = False
            Me.printPreviewBarItem19.Hint = "Next Page"
            Me.printPreviewBarItem19.Id = 25
            Me.printPreviewBarItem19.ImageOptions.Image = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.icon_page_next_16
            Me.printPreviewBarItem19.Name = "printPreviewBarItem19"
            ' 
            ' progressBarEditItem1
            ' 
            Me.progressBarEditItem1.Edit = Me.repositoryItemProgressBar1
            Me.progressBarEditItem1.EditHeight = 12
            Me.progressBarEditItem1.EditWidth = 150
            Me.progressBarEditItem1.Id = 2
            Me.progressBarEditItem1.Name = "progressBarEditItem1"
            Me.progressBarEditItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            ' 
            ' repositoryItemProgressBar1
            ' 
            Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
            ' 
            ' printPreviewBarItem1
            ' 
            Me.printPreviewBarItem1.Caption = "Stop"
            Me.printPreviewBarItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.StopPageBuilding
            Me.printPreviewBarItem1.Enabled = False
            Me.printPreviewBarItem1.Hint = "Stop"
            Me.printPreviewBarItem1.Id = 3
            Me.printPreviewBarItem1.Name = "printPreviewBarItem1"
            Me.printPreviewBarItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            ' 
            ' printPreviewStaticItem2
            ' 
            Me.printPreviewStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.printPreviewStaticItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.printPreviewStaticItem2.Caption = "100%"
            Me.printPreviewStaticItem2.Id = 5
            Me.printPreviewStaticItem2.Name = "printPreviewStaticItem2"
            Me.printPreviewStaticItem2.Size = New System.Drawing.Size(40, 0)
            Me.printPreviewStaticItem2.TextAlignment = System.Drawing.StringAlignment.Far
            Me.printPreviewStaticItem2.Type = "ZoomFactor"
            Me.printPreviewStaticItem2.Width = 40
            ' 
            ' zoomTrackBarEditItem1
            ' 
            Me.zoomTrackBarEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.zoomTrackBarEditItem1.Edit = Me.repositoryItemZoomTrackBar1
            Me.zoomTrackBarEditItem1.EditValue = 90
            Me.zoomTrackBarEditItem1.EditWidth = 140
            Me.zoomTrackBarEditItem1.Enabled = False
            Me.zoomTrackBarEditItem1.Id = 6
            Me.zoomTrackBarEditItem1.Name = "zoomTrackBarEditItem1"
            Me.zoomTrackBarEditItem1.Range = New Integer() {10, 500}
            ' 
            ' repositoryItemZoomTrackBar1
            ' 
            Me.repositoryItemZoomTrackBar1.Alignment = DevExpress.Utils.VertAlignment.Center
            Me.repositoryItemZoomTrackBar1.AllowFocused = False
            Me.repositoryItemZoomTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemZoomTrackBar1.Maximum = 180
            Me.repositoryItemZoomTrackBar1.Middle = 90
            Me.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1"
            ' 
            ' printPreviewBarItemWholePage
            ' 
            Me.printPreviewBarItemWholePage.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.printPreviewBarItemWholePage.Caption = "Fit To Page"
            Me.printPreviewBarItemWholePage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToWholePage
            Me.printPreviewBarItemWholePage.Enabled = False
            Me.printPreviewBarItemWholePage.Hint = "Fit to Page"
            Me.printPreviewBarItemWholePage.Id = 27
            Me.printPreviewBarItemWholePage.ImageOptions.Image = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.icon_fittopage_16
            Me.printPreviewBarItemWholePage.Name = "printPreviewBarItemWholePage"
            ' 
            ' printPreviewBarItemMultiplePages
            ' 
            Me.printPreviewBarItemMultiplePages.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.printPreviewBarItemMultiplePages.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.printPreviewBarItemMultiplePages.Caption = "Multiple Pages"
            Me.printPreviewBarItemMultiplePages.Command = DevExpress.XtraPrinting.PrintingSystemCommand.MultiplePages
            Me.printPreviewBarItemMultiplePages.Enabled = False
            Me.printPreviewBarItemMultiplePages.Hint = "Multiple Pages"
            Me.printPreviewBarItemMultiplePages.Id = 27
            Me.printPreviewBarItemMultiplePages.ImageOptions.Image = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.icon_pages_16
            Me.printPreviewBarItemMultiplePages.Name = "printPreviewBarItemMultiplePages"
            ' 
            ' printPreviewBarItemScale
            ' 
            Me.printPreviewBarItemScale.ActAsDropDown = True
            Me.printPreviewBarItemScale.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.printPreviewBarItemScale.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.printPreviewBarItemScale.Caption = "Scale"
            Me.printPreviewBarItemScale.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Scale
            Me.printPreviewBarItemScale.Enabled = False
            Me.printPreviewBarItemScale.Hint = "Scale"
            Me.printPreviewBarItemScale.Id = 17
            Me.printPreviewBarItemScale.ImageOptions.ImageIndex = 25
            Me.printPreviewBarItemScale.Name = "printPreviewBarItemScale"
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.documentViewerBarManager1
            Me.barDockControlTop.Size = New System.Drawing.Size(1045, 0)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 560)
            Me.barDockControlBottom.Manager = Me.documentViewerBarManager1
            Me.barDockControlBottom.Size = New System.Drawing.Size(1045, 24)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Me.documentViewerBarManager1
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 560)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(1045, 0)
            Me.barDockControlRight.Manager = Me.documentViewerBarManager1
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 560)
            ' 
            ' printPreviewRepositoryItemComboBox1
            ' 
            Me.printPreviewRepositoryItemComboBox1.AutoComplete = False
            Me.printPreviewRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.printPreviewRepositoryItemComboBox1.DropDownRows = 11
            Me.printPreviewRepositoryItemComboBox1.Name = "printPreviewRepositoryItemComboBox1"
            ' 
            ' ReportPreviewControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.documentViewerCore)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "ReportPreviewControl"
            Me.Size = New System.Drawing.Size(1045, 584)
            CType((Me.documentViewerBarManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemZoomTrackBar1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.printPreviewRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private documentViewerCore As DevExpress.XtraPrinting.Preview.DocumentViewer

        Private documentViewerBarManager1 As DevExpress.XtraPrinting.Preview.DocumentViewerBarManager

        Private previewBar1 As DevExpress.XtraPrinting.Preview.PreviewBar

        Private printPreviewBarItem18 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewStaticItem1 As DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem

        Private printPreviewBarItem19 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private progressBarEditItem1 As DevExpress.XtraPrinting.Preview.ProgressBarEditItem

        Private repositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar

        Private printPreviewBarItem1 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewStaticItem2 As DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem

        Private zoomTrackBarEditItem1 As DevExpress.XtraPrinting.Preview.ZoomTrackBarEditItem

        Private repositoryItemZoomTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar

        Private printPreviewBarItemWholePage As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItemScale As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItemMultiplePages As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

        Private printPreviewRepositoryItemComboBox1 As DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox
    End Class
End Namespace
