Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports System
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.Internal
Imports DevExpress.XtraGantt.Printing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraGantt.TimeLine

Namespace DevExpress.XtraGantt.Demos

    Public Class GanttRibbonMenuManager
        Inherits RibbonMenuManager

        Const AllowResizeImageName As String = "AllowResize"

        Const FixedPanelImageName As String = "FixedPanel"

        Const PanelVisibilityImageName As String = "PanelVisibility"

        Const ShowCriticalPathImageName As String = "ShowCriticalPath"

        Const TimelinePositionImageName As String = "TimelinePosition"

        Private bsiFixedPanel As BarSubItem

        Private bsiPanelVisibility As BarSubItem

        Private bsiTimelinePosition As BarSubItem

        Private bbiAllowResize As BarButtonItem

        Private bciFixedPanelChart As BarCheckItem

        Private bciFixedPanelDefault As BarCheckItem

        Private bciFixedPanelNone As BarCheckItem

        Private bciFixedPanelTree As BarCheckItem

        Private bciPanelVisibilityBoth As BarCheckItem

        Private bciPanelVisibilityChart As BarCheckItem

        Private bciPanelVisibilityDefault As BarCheckItem

        Private bciPanelVisibilityTree As BarCheckItem

        Private bciTimelinePositionTop As BarCheckItem

        Private bciTimelinePositionBottom As BarCheckItem

        Private bciTimelinePositionNone As BarCheckItem

        Private bbiShowCriticalPath As BarButtonItem

        Private ganttControl As GanttControl

        Private svgImagesCore As SvgImageCollection

        Public Sub New(ByVal form As RibbonMainForm)
            MyBase.New(form)
            CreateViewMenu(form.ReservGroup1, form.Ribbon)
            ShowReservGroup1(True)
        End Sub

        Public Sub AllowShowCriticalPath(ByVal obj As Object)
            bbiShowCriticalPath.Visibility = If(obj IsNot Nothing, BarItemVisibility.Always, BarItemVisibility.Never)
        End Sub

        Private Sub CreateAllowResizeItem(ByVal pageGroup As RibbonPageGroup, ByVal ribbonControl As RibbonControl)
            bbiAllowResize = New BarButtonItem() With {.Caption = "Allow Resize", .ButtonStyle = BarButtonStyle.Check}
            AddHandler bbiAllowResize.DownChanged, AddressOf OnAllowResizeDownChanged
            ribbonControl.Items.Add(bbiAllowResize)
            pageGroup.ItemLinks.Add(bbiAllowResize)
            bbiAllowResize.Down = True
            bbiAllowResize.ImageOptions.SvgImage = SvgImages(AllowResizeImageName)
        End Sub

        Private Function CreateBarCheckItem(ByVal parentItem As BarSubItem, ByVal name As Object, ByVal groupIndex As Integer, ByVal handler As ItemClickEventHandler, ByVal Optional checked As Boolean = False, ByVal Optional image As SvgImage = Nothing) As BarCheckItem
            Dim checkItem As BarCheckItem = CreateCheckItem(groupIndex, name, checked, image)
            AddHandler checkItem.CheckedChanged, handler
            checkItem.Tag = name
            parentItem.AddItem(checkItem)
            Return checkItem
        End Function

        Private Function CreateCheckItem(ByVal groupIndex As Integer, ByVal name As Object, ByVal checked As Boolean, ByVal image As SvgImage) As BarCheckItem
            Dim newItem As BarCheckItem = New BarCheckItem(Manager) With {.Caption = name.ToString()}
            newItem.Name = "bci" & name.ToString()
            newItem.GroupIndex = groupIndex
            newItem.Checked = checked
            newItem.ImageOptions.SvgImage = image
            Return newItem
        End Function

        Private Sub CreateFixedPanelCheckItem(ByVal group As RibbonPageGroup, ByVal ribbonControl As RibbonControl)
            bsiFixedPanel = New BarSubItem(Manager, "Fixed Panel")
            bsiFixedPanel.ImageOptions.SvgImage = SvgImages(FixedPanelImageName)
            ribbonControl.Items.Add(bsiFixedPanel)
            group.ItemLinks.Add(bsiFixedPanel)
            bciFixedPanelDefault = CreateBarCheckItem(bsiFixedPanel, GanttFixedPanel.Default, 2, New ItemClickEventHandler(AddressOf OnFixedPanelItemClick))
            ribbonControl.Items.Add(bciFixedPanelDefault)
            bciFixedPanelChart = CreateBarCheckItem(bsiFixedPanel, GanttFixedPanel.Chart, 2, New ItemClickEventHandler(AddressOf OnFixedPanelItemClick))
            ribbonControl.Items.Add(bciFixedPanelChart)
            bciFixedPanelNone = CreateBarCheckItem(bsiFixedPanel, GanttFixedPanel.None, 2, New ItemClickEventHandler(AddressOf OnFixedPanelItemClick))
            ribbonControl.Items.Add(bciFixedPanelNone)
            bciFixedPanelTree = CreateBarCheckItem(bsiFixedPanel, GanttFixedPanel.Tree, 2, New ItemClickEventHandler(AddressOf OnFixedPanelItemClick))
            ribbonControl.Items.Add(bciFixedPanelTree)
        End Sub

        Private Sub CreatePanelVisibilityItem(ByVal pageGroup As RibbonPageGroup, ByVal ribbonControl As RibbonControl)
            bsiPanelVisibility = New BarSubItem(Manager, "Panel Visibility")
            bsiPanelVisibility.ImageOptions.SvgImage = SvgImages(PanelVisibilityImageName)
            ribbonControl.Items.Add(bsiPanelVisibility)
            pageGroup.ItemLinks.Add(bsiPanelVisibility)
            bciPanelVisibilityDefault = CreateBarCheckItem(bsiPanelVisibility, GanttPanelVisibility.Default, 1, New ItemClickEventHandler(AddressOf OnPanelVisibilityItemClick))
            ribbonControl.Items.Add(bciPanelVisibilityDefault)
            bciPanelVisibilityBoth = CreateBarCheckItem(bsiPanelVisibility, GanttPanelVisibility.Both, 1, New ItemClickEventHandler(AddressOf OnPanelVisibilityItemClick))
            ribbonControl.Items.Add(bciPanelVisibilityBoth)
            bciPanelVisibilityChart = CreateBarCheckItem(bsiPanelVisibility, GanttPanelVisibility.Chart, 1, New ItemClickEventHandler(AddressOf OnPanelVisibilityItemClick))
            ribbonControl.Items.Add(bciPanelVisibilityChart)
            bciPanelVisibilityTree = CreateBarCheckItem(bsiPanelVisibility, GanttPanelVisibility.Tree, 1, New ItemClickEventHandler(AddressOf OnPanelVisibilityItemClick))
            ribbonControl.Items.Add(bciPanelVisibilityTree)
        End Sub

        Private Sub CreateTimelinePositionItem(ByVal pageGroup As RibbonPageGroup, ByVal ribbonControl As RibbonControl)
            bsiTimelinePosition = New BarSubItem(Manager, "Timeline Position")
            bsiTimelinePosition.ImageOptions.SvgImage = SvgImages(TimelinePositionImageName)
            ribbonControl.Items.Add(bsiTimelinePosition)
            pageGroup.ItemLinks.Add(bsiTimelinePosition)
            bciTimelinePositionTop = CreateBarCheckItem(bsiTimelinePosition, TimelinePosition.Top, 1, New ItemClickEventHandler(AddressOf OnTimelinePositionClick))
            ribbonControl.Items.Add(bciTimelinePositionTop)
            bciTimelinePositionBottom = CreateBarCheckItem(bsiTimelinePosition, TimelinePosition.Bottom, 1, New ItemClickEventHandler(AddressOf OnTimelinePositionClick), True)
            ribbonControl.Items.Add(bciTimelinePositionBottom)
            bciTimelinePositionNone = CreateBarCheckItem(bsiTimelinePosition, TimelinePosition.None, 1, New ItemClickEventHandler(AddressOf OnTimelinePositionClick))
            ribbonControl.Items.Add(bciTimelinePositionNone)
        End Sub

        Private Sub CreateViewMenu(ByVal pageGroup As RibbonPageGroup, ByVal ribbonControl As RibbonControl)
            pageGroup.Text = "View"
            CreateAllowResizeItem(pageGroup, ribbonControl)
            CreatePanelVisibilityItem(pageGroup, ribbonControl)
            CreateFixedPanelCheckItem(pageGroup, ribbonControl)
            CreateTimelinePositionItem(pageGroup, ribbonControl)
            CreateShowCriticalPathCheckItem(pageGroup, ribbonControl)
        End Sub

        Private Sub CreateShowCriticalPathCheckItem(ByVal pageGroup As RibbonPageGroup, ByVal ribbonControl As RibbonControl)
            bbiShowCriticalPath = New BarButtonItem() With {.Caption = "Critical Path", .ButtonStyle = BarButtonStyle.Check}
            AddHandler bbiShowCriticalPath.DownChanged, AddressOf OnShowCriticalPathChanged
            ribbonControl.Items.Add(bbiShowCriticalPath)
            pageGroup.ItemLinks.Add(bbiShowCriticalPath)
            bbiShowCriticalPath.Down = True
            bbiShowCriticalPath.ImageOptions.SvgImage = SvgImages(ShowCriticalPathImageName)
        End Sub

        Private Sub RefreshViewMenuItems()
            bbiAllowResize.Down = OptionsSplitter.AllowResize
            Select Case OptionsSplitter.FixedPanel
                Case GanttFixedPanel.Tree
                    bciFixedPanelTree.Checked = True
                Case GanttFixedPanel.Chart
                    bciFixedPanelChart.Checked = True
                Case GanttFixedPanel.None
                    bciFixedPanelNone.Checked = True
                Case GanttFixedPanel.Default
                    bciFixedPanelDefault.Checked = True
            End Select

            Select Case OptionsSplitter.PanelVisibility
                Case GanttPanelVisibility.Tree
                    bciPanelVisibilityTree.Checked = True
                Case GanttPanelVisibility.Chart
                    bciPanelVisibilityChart.Checked = True
                Case GanttPanelVisibility.Both
                    bciPanelVisibilityBoth.Checked = True
                Case GanttPanelVisibility.Default
                    bciPanelVisibilityDefault.Checked = True
            End Select
        End Sub

        Private ReadOnly Property OptionsTimeline As GanttControlTimelineOptions
            Get
                If ganttControl IsNot Nothing Then Return ganttControl.OptionsTimeline
                Return Nothing
            End Get
        End Property

        Private ReadOnly Property OptionsSplitter As GanttControlOptionsSplitter
            Get
                If ganttControl IsNot Nothing Then Return ganttControl.OptionsSplitter
                Return Nothing
            End Get
        End Property

        Private ReadOnly Property OptionsView As GanttControlOptionsView
            Get
                If ganttControl IsNot Nothing Then Return ganttControl.OptionsView
                Return Nothing
            End Get
        End Property

        Private ReadOnly Property SvgImages As SvgImageCollection
            Get
                If svgImagesCore Is Nothing Then
                    svgImagesCore = New SvgImageCollection()
                    Dim assembly As Assembly = GetType(GanttRibbonMenuManager).Assembly
                    svgImagesCore.Add(PanelVisibilityImageName, SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraGantt.Demos.Resources.PanelVisibility.svg", assembly)))
                    svgImagesCore.Add(FixedPanelImageName, SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraGantt.Demos.Resources.FixedPanel.svg", assembly)))
                    svgImagesCore.Add(AllowResizeImageName, SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraGantt.Demos.Resources.AllowResize.svg", assembly)))
                    svgImagesCore.Add(ShowCriticalPathImageName, SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraGantt.Demos.Resources.CriticalPath.svg", assembly)))
                    svgImagesCore.Add(TimelinePositionImageName, SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraGantt.Demos.Resources.TimelinePosition.svg", assembly)))
                End If

                Return svgImagesCore
            End Get
        End Property

        Public Sub RefreshViewMenu(ByVal ganttControl As GanttControl)
            ShowReservGroup1(ganttControl IsNot Nothing)
            Me.ganttControl = ganttControl
            If ganttControl IsNot Nothing Then RefreshViewMenuItems()
        End Sub

        Private Sub OnTimelinePositionClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If OptionsTimeline IsNot Nothing Then OptionsTimeline.TimelinePosition = CType([Enum].Parse(GetType(TimelinePosition), e.Item.Tag.ToString()), TimelinePosition)
        End Sub

        Private Sub OnPanelVisibilityItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If OptionsSplitter IsNot Nothing Then OptionsSplitter.PanelVisibility = CType([Enum].Parse(GetType(GanttPanelVisibility), e.Item.Tag.ToString()), GanttPanelVisibility)
        End Sub

        Private Sub OnFixedPanelItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If OptionsSplitter IsNot Nothing Then OptionsSplitter.FixedPanel = CType([Enum].Parse(GetType(GanttFixedPanel), e.Item.Tag.ToString()), GanttFixedPanel)
        End Sub

        Private Sub OnAllowResizeDownChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim checkItem As BarButtonItem = TryCast(e.Item, BarButtonItem)
            If OptionsSplitter IsNot Nothing AndAlso checkItem IsNot Nothing Then OptionsSplitter.AllowResize = checkItem.Down
        End Sub

        Private Sub OnShowCriticalPathChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim checkItem As BarButtonItem = TryCast(e.Item, BarButtonItem)
            If OptionsView IsNot Nothing AndAlso checkItem IsNot Nothing Then OptionsView.CriticalPathHighlightMode = If(checkItem.Down, CriticalPathHighlightMode.Single, CriticalPathHighlightMode.None)
        End Sub
    End Class

    Public Class TutorialControl
        Inherits TutorialControlBase

        Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As BarManager)
            Dim gantt As GanttControl = TryCast(ctrl, GanttControl)
            If gantt IsNot Nothing Then gantt.MenuManager = manager
            Dim scrollBar As ScrollBarBase = TryCast(ctrl, ScrollBarBase)
            If scrollBar IsNot Nothing AndAlso FluentScrollBars Then ScrollBarBase.ApplyUIMode(scrollBar, ScrollUIMode.Fluent)
            Dim be As BaseEdit = TryCast(ctrl, BaseEdit)
            If be IsNot Nothing Then be.MenuManager = manager
        End Sub

        Protected Overridable ReadOnly Property FluentScrollBars As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides Sub AllowExport()
            EnabledPrintExportActions(True, ExportFormats.PDF Or ExportFormats.HTML Or ExportFormats.MHT Or ExportFormats.XLS Or ExportFormats.RTF Or ExportFormats.DOCX Or ExportFormats.Text Or ExportFormats.XLSX, False)
        End Sub

        Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
            If MainControl Is Nothing Then Return
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            If Equals(ext, "rtf") Then MainControl.ExportToRtf(filename)
            If Equals(ext, "docx") Then MainControl.ExportToDocx(filename)
            If Equals(ext, "pdf") Then
                Dim options As PdfExportOptions = New PdfExportOptions()
                options.ConvertImagesToJpeg = False
                MainControl.ExportToPdf(filename, options)
            End If

            If Equals(ext, "mht") Then MainControl.ExportToMht(filename, New MhtExportOptions())
            If Equals(ext, "html") Then MainControl.ExportToHtml(filename)
            If Equals(ext, "txt") Then MainControl.ExportToText(filename)
            If Equals(ext, "xls") Then MainControl.ExportToXls(filename)
            If Equals(ext, "xlsx") Then MainControl.ExportToXlsx(filename)
            Cursor.Current = currentCursor
        End Sub

        Protected Overrides Sub ExportToPDF()
            ExportTo("pdf", "PDF document (*.pdf)|*.pdf")
        End Sub

        Protected Overrides Sub ExportToHTML()
            ExportTo("html", "HTML document (*.html)|*.html")
        End Sub

        Protected Overrides Sub ExportToMHT()
            ExportTo("mht", "MHT document (*.mht)|*.mht")
        End Sub

        Protected Overrides Sub ExportToXLS()
            ExportTo("xls", "XLS document (*.xls)|*.xls")
        End Sub

        Protected Overrides Sub ExportToXLSX()
            ExportTo("xlsx", "XLSX document (*.xlsx)|*.xlsx")
        End Sub

        Protected Overrides Sub ExportToRTF()
            ExportTo("rtf", "RTF document (*.rtf)|*.rtf")
        End Sub

        Protected Overrides Sub ExportToDOCX()
            ExportTo("docx", "DOCX document (*.docx)|*.docx")
        End Sub

        Protected Overrides Sub ExportToText()
            ExportTo("txt", "Text document (*.txt)|*.txt")
        End Sub

        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overridable ReadOnly Property AllowShowCriticalPath As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides ReadOnly Property ModulesFolder As String
            Get
                Return "GanttMainDemo\Modules"
            End Get
        End Property

        Protected Overrides ReadOnly Property CodeInfoFolder As String
            Get
                Return "DevExpress.XtraGantt.Demos.CodeInfo"
            End Get
        End Property

        Public ReadOnly Property IsActiveDemo As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Shared Function LoadXml(ByVal name As String) As Stream
            Dim fileName As String = DataDirectoryHelper.GetDataFile(name)
            If Not String.IsNullOrEmpty(fileName) Then Return New FileStream(fileName, FileMode.Open, FileAccess.Read)
            Return Nothing
        End Function

        Public Overridable ReadOnly Property MainControl As GanttControl
            Get
                Return Nothing
            End Get
        End Property

        Protected Overrides Sub PrintPreview()
            Try
                If Me.MainControl IsNot Nothing Then
                    If RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm Then
                        Me.MainControl.ShowRibbonPrintPreview()
                    Else
                        Me.MainControl.ShowPrintPreview()
                    End If
                End If
            Catch ex As Exception
                Call NotificationService.ShowException(Of XtraGanttPrintingSystemBase)(LookAndFeel, FindForm(), ex)
            End Try
        End Sub
    End Class
End Namespace
