Imports System
Imports System.Collections.Generic
Imports System.Drawing.Printing
Imports DevExpress.Tutorials
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGantt.Printing
Imports DevExpress.Drawing
Imports DevExpress.Drawing.Printing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Native

Namespace DevExpress.XtraGantt.Demos

    Public Partial Class MarketResearchSchedule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            ' <ganttControl1>
            ganttControl1.TreeListMappings.ParentFieldName = "ParentUID"
            ganttControl1.TreeListMappings.KeyFieldName = "UID"
            ganttControl1.ChartMappings.TextFieldName = "Name"
            ganttControl1.ChartMappings.InteractionTooltipTextFieldName = "Name"
            ganttControl1.ChartMappings.DurationFieldName = "Duration"
            AddHandler ganttControl1.Load, AddressOf GanttControl1_Load
            LoadDataSource()
            Init()
            ganttControl1.ExpandAll()
        '</ganttControl1>
        End Sub

        Private Sub GanttControl1_Load(ByVal sender As Object, ByVal e As EventArgs)
            deChartStartDate.EditValue = ganttControl1.GetChartActualStartDate()
            deChartFinishDate.EditValue = ganttControl1.GetChartActualFinishDate()
        End Sub

        Private Sub Init()
            cePrintLegend.Checked = ganttControl1.OptionsPrint.PrintLegend = DefaultBoolean.True
            cePrintPageInfo.Checked = ganttControl1.OptionsPrint.PrintPageInfo = DefaultBoolean.True
            cePrintAllNodes.Checked = ganttControl1.OptionsPrint.PrintAllNodes
            tePageCaption.EditValue = DemoLinkHelper.GetModuleDisplayName(Me)
            Dim pageInfoTypes As Array = [Enum].GetValues(GetType(PageInfo))
            For Each value As PageInfo In pageInfoTypes
                icePageInfoType.Properties.Items.Add(New ImageComboBoxItem([Enum].GetName(GetType(PageInfo), value), value, -1))
            Next

            icePageInfoType.EditValue = ganttControl1.OptionsPrint.PageInfoType
            iceOrientation.Properties.Items.Add(New ImageComboBoxItem([Enum].GetName(GetType(PageOrientation), PageOrientation.Portrait), PageOrientation.Portrait, -1))
            iceOrientation.Properties.Items.Add(New ImageComboBoxItem([Enum].GetName(GetType(PageOrientation), PageOrientation.Landscape), PageOrientation.Landscape, -1))
            iceOrientation.EditValue = PageOrientation.Portrait
            Dim values = [Enum].GetValues(GetType(DXPaperKind))
            For Each value As DXPaperKind In values
                icePaperKind.Properties.Items.Add(New ImageComboBoxItem([Enum].GetName(GetType(DXPaperKind), value), value, -1))
            Next

            icePaperKind.EditValue = DXPaperKind.Letter
        End Sub

        Public Overrides ReadOnly Property AllowPrintOptions As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overrides ReadOnly Property MainControl As GanttControl
            Get
                Return ganttControl1
            End Get
        End Property

        Protected Overrides Sub PrintPreview()
            If Me.MainControl IsNot Nothing Then
                Try
                    Using ps As XtraGanttPrintingSystemBase = New XtraGanttPrintingSystemBase()
                        Using link As PrintableComponentLink = New PrintableComponentLink()
                            link.PrintingSystemBase = ps
                            link.Component = ganttControl1
                            link.Landscape = CType(iceOrientation.EditValue, PageOrientation) = PageOrientation.Landscape
                            link.PaperKind = CType(icePaperKind.EditValue, DXPaperKind)
                            CreateDocument(link)
                            If RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm Then
                                link.ShowRibbonPreviewDialog(LookAndFeel)
                            Else
                                link.ShowPreviewDialog()
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    Call NotificationService.ShowException(Of XtraGanttPrintingSystemBase)(LookAndFeel, FindForm(), ex)
                End Try
            End If
        End Sub

        Private wnd As ProgressWindow

        Private Sub CreateDocument(ByVal link As PrintableComponentLink)
            wnd = New ProgressWindow()
            Using wnd
                wnd.SetCaption(PrintingSystemActivity.Preparing)
                wnd.LookAndFeel.Assign(LookAndFeel)
                wnd.ShowCenter(FindForm())
                Dim reflector As ProgressReflector = New ProgressReflector()
                AddHandler reflector.PositionChanged, AddressOf ProcessReflectorPositionChanged
                Try
                    link.PrintingSystemBase.ProgressReflector = reflector
                    link.CreateDocument()
                Finally
                    RemoveHandler reflector.PositionChanged, AddressOf ProcessReflectorPositionChanged
                    link.PrintingSystemBase.ResetProgressReflector()
                End Try
            End Using
        End Sub

        Private Sub ProcessReflectorPositionChanged(ByVal sender As Object, ByVal e As EventArgs)
            If wnd Is Nothing Then Return
            wnd.SetProgress(CType(sender, ProgressReflector).Position)
        End Sub

        Private Sub LoadDataSource()
            Using stream = LoadXml("MarketResearchSchedule.xml")
                Dim tasks As IList(Of TaskDataItem) = LoadModel(stream)
                If tasks IsNot Nothing AndAlso tasks.Count > 0 Then
                    TryUpdateDates(tasks)
                    ganttControl1.DataSource = tasks
                    ganttControl1.ScheduleFromStartDate(tasks(0).StartDate)
                End If
            End Using
        End Sub

        Private Sub cePrintLegend_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ganttControl1.OptionsPrint.PrintLegend = If(cePrintLegend.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        Private Sub cePrintPageInfo_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ganttControl1.OptionsPrint.PrintPageInfo = If(cePrintPageInfo.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        Private Sub icePageInfoType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ganttControl1.OptionsPrint.PageInfoType = CType(icePageInfoType.EditValue, PageInfo)
        End Sub

        Private Sub deChartStartDate_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ganttControl1.OptionsPrint.ChartStartDate = deChartStartDate.DateTime
        End Sub

        Private Sub deChartFinishDate_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ganttControl1.OptionsPrint.ChartFinishDate = deChartFinishDate.DateTime
        End Sub

        Private Sub cePrintAllNodes_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ganttControl1.OptionsPrint.PrintAllNodes = cePrintAllNodes.Checked
        End Sub

        Private Sub tePageCaption_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ganttControl1.OptionsPrint.PageInfoCaption = tePageCaption.Text
        End Sub
    End Class
End Namespace
