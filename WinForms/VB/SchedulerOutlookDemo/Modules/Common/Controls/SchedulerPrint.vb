Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class SchedulerPrint
        Inherits XtraUserControl

        Private report As XtraReport

        Public Sub New()
            InitializeComponent()
            printSettingsControl.SelectedPrinterName = PageSettingsHelper.DefaultPageSettings.PrinterSettings.PrinterName
        End Sub

        Protected Overrides Sub OnVisibleChanged(ByVal e As EventArgs)
            MyBase.OnVisibleChanged(e)
            If Not Visible Then
                controlPrintAdapter1.SchedulerControl = Nothing
                reportPreviewControl1.Visible = False
                Return
            End If

            If controlPrintAdapter1.SchedulerControl Is DemosInfo.CurrentScheduler Then Return
            controlPrintAdapter1.SchedulerControl = DemosInfo.CurrentScheduler
            UpdateReport(ReportType.DailyStyle)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            printSettingsControl.SetSettings(New PrintStylesControl(AddressOf UpdateReport, ReportType.DailyStyle))
        End Sub

        Private Sub UpdateReport(ByVal reportType As ReportType)
            If report IsNot Nothing Then
                reportPreviewControl1.DocumentSource = Nothing
                RemoveHandler report.PrintingSystem.AfterBuildPages, AddressOf OnPrintingSystemAfterBuildPages
                report.Dispose()
            End If

            Dim newReport As XtraSchedulerReport = Create(reportType)
            newReport.SchedulerAdapter = controlPrintAdapter1
            newReport.SchedulerAdapter.EnableSmartSync = reportType = ReportType.TriFoldStyle
            newReport.PrintColorSchema = DemoUtils.ReportPrintColorSchema
            report = newReport
            reportPreviewControl1.DocumentSource = newReport
            newReport.PrintingSystem.ClearContent()
            newReport.CreateDocument(True)
            RemoveHandler newReport.PrintingSystem.AfterBuildPages, AddressOf OnPrintingSystemAfterBuildPages
            AddHandler newReport.PrintingSystem.AfterBuildPages, AddressOf OnPrintingSystemAfterBuildPages
        End Sub

        Private Sub OnPrintingSystemAfterBuildPages(ByVal sender As Object, ByVal e As EventArgs)
            If printSettingsControl.IsHandleCreated Then printSettingsControl.BeginInvoke(New Action(Of Boolean)(AddressOf OnPrintingSystemAfterBuildPagesInUIThread), CType(sender, PrintingSystemBase).PageCount > 0)
        End Sub

        Private Sub OnPrintingSystemAfterBuildPagesInUIThread(ByVal isEnabled As Boolean)
            printSettingsControl.PrintEnabled = isEnabled
            reportPreviewControl1.Visible = True
        End Sub

        Private Sub OnSettingsControlPrintClick(ByVal sender As Object, ByVal e As EventArgs)
            Using tool As ReportPrintTool = New ReportPrintTool(report)
                tool.Print(printSettingsControl.SelectedPrinterName)
            End Using
        End Sub

        Private Sub OnSettingsControlPrintOptionsClick(ByVal sender As Object, ByVal e As EventArgs)
            Using tool As ReportPrintTool = New ReportPrintTool(report)
                tool.PrintDialog(FindForm(), LookAndFeel)
            End Using
        End Sub
    End Class

    Public Module SchedulerReportFactory

        Sub New()
            Dim directoryInfo As DirectoryInfo = New DirectoryInfo(DemoUtils.GetFolderRelativePath("SchedulerReportTemplates"))
            ReportPathDictionary = New Dictionary(Of ReportType, String)()
            Dim reportTemplates As FileInfo() = directoryInfo.GetFiles("*.schrepx")
            RegisterReport("DailyStyleFitToPage", ReportType.DailyStyle, reportTemplates)
            RegisterReport("WeeklyStyle", ReportType.WeeklyAgendaStyle, reportTemplates)
            RegisterReport("TrifoldStandard", ReportType.TriFoldStyle, reportTemplates)
            'RegisterReport("", ReportType.CalendarDetailsStyle, reportTemplates);
            RegisterReport("MonthlyStyle", ReportType.MonthlyCalendarStyle, reportTemplates)
            RegisterReport("DailyStyleFitToPage", ReportType.WeeklyCalendarStyle, reportTemplates)
        End Sub

        Private Property ReportPathDictionary As Dictionary(Of ReportType, String)

        Public Function Create(ByVal type As ReportType) As XtraSchedulerReport
            Dim reportPath As String = String.Empty
            If Not ReportPathDictionary.TryGetValue(type, reportPath) Then Return Nothing
            Dim report As XtraSchedulerReport = New XtraSchedulerReport()
            report.LoadLayout(reportPath)
            Return report
        End Function

        Private Sub RegisterReport(ByVal name As String, ByVal reportType As ReportType, ByVal fileInfos As IEnumerable(Of FileInfo))
            Dim fileInfo As FileInfo = fileInfos.FirstOrDefault(Function(x) Equals(Path.GetFileNameWithoutExtension(x.Name), name))
            If fileInfo Is Nothing Then Return
            ReportPathDictionary.Add(reportType, fileInfo.FullName)
        End Sub
    End Module
End Namespace
