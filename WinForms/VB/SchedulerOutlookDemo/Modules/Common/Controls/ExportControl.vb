Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Drawing
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils.Menu
Imports DevExpress.Utils.Serializing.Helpers
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraScheduler.iCalendar
Imports DevExpress.XtraScheduler.iCalendar.Components
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class ExportControl
        Inherits XtraUserControl

        Private menuExport As DXPopupMenu

        Private mainForm As Form

        Private _selectedExport As ExportTarget

        Public Sub New(ByVal mainForm As Form)
            Me.New()
            Me.mainForm = mainForm
        End Sub

        Public Sub New()
            InitializeComponent()
            AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
            SelectedExport = ExportTarget.Pdf
            menuExport = New DXPopupMenu()
            AddExportTarget(ExportTarget.Pdf)
            AddExportTarget(ExportTarget.Html)
            AddExportTarget(ExportTarget.Image)
            btnExportViaReporting.DropDownControl = menuExport
            AddHandler menuExport.BeforePopup, AddressOf menuExport_BeforePopup
            UpdateBackColor()
        End Sub

        <System.ComponentModel.DefaultValue(CType(Nothing, Object))>
        Public Property SelectedExport As ExportTarget
            Get
                Return _selectedExport
            End Get

            Set(ByVal value As ExportTarget)
                Dim newValue As ExportTarget = value
                If _selectedExport.Equals(newValue) Then Return
                _selectedExport = newValue
                btnExportViaReporting.Text = String.Format("Export To {0}", SelectedExport)
            End Set
        End Property

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If mainForm IsNot Nothing Then btnExportViaReporting.MenuManager = MenuManagerHelper.FindMenuManager(mainForm)
        End Sub

        Private Sub AddExportTarget(ByVal target As ExportTarget)
            Dim exportItem As DXMenuCheckItem = New DXMenuCheckItem() With {.Caption = target.ToString(), .Tag = target}
            menuExport.Items.Add(exportItem)
            AddHandler exportItem.Click, AddressOf OnExportItemClick
        End Sub

        Private Sub OnExportItemClick(ByVal sender As Object, ByVal e As EventArgs)
            SelectedExport = CType(CType(sender, DXMenuItem).Tag, ExportTarget)
        End Sub

        Private Sub menuExport_BeforePopup(ByVal sender As Object, ByVal e As EventArgs)
            For Each item As DXMenuCheckItem In menuExport.Items
                item.Checked = Equals(item.Tag, SelectedExport)
            Next
        End Sub

        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateBackColor()
        End Sub

        Private Sub UpdateBackColor()
            layoutControl1.BackColor = ColorHelper.GetControlColor(LookAndFeel)
        End Sub

        Private Sub btnExportViaReporting_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim exporter As ReportExporter = ReportExporter.Create(SelectedExport, DemosInfo.CurrentScheduler)
            If exporter Is Nothing Then Return
            Dim dialog As SaveFileDialog = New SaveFileDialog()
            dialog.Filter = exporter.Filter
            dialog.AddExtension = True
            If dialog.ShowDialog(Me) <> DialogResult.OK Then Return
            exporter.Do(dialog.FileName)
        End Sub

        Private Sub OnBtnExportViaiCalendarClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim exporter As iCalendarExporter = New iCalendarExporter(DemosInfo.CurrentScheduler.DataStorage)
            AddHandler exporter.AppointmentExporting, AddressOf OnExporterAppointmentExporting
            Dim dialog As SaveFileDialog = New SaveFileDialog()
            dialog.Filter = "iCalendar files (*.ics)|*.ics"
            dialog.AddExtension = True
            If dialog.ShowDialog(Me) <> DialogResult.OK Then Return
            exporter.Export(dialog.FileName)
            RemoveHandler exporter.AppointmentExporting, AddressOf OnExporterAppointmentExporting
        End Sub

        Private Sub OnExporterAppointmentExporting(ByVal sender As Object, ByVal e As AppointmentExportingEventArgs)
            Dim args As iCalendarAppointmentExportingEventArgs = TryCast(e, iCalendarAppointmentExportingEventArgs)
            Dim customProperty As CustomProperty = TryCast(args.VEvent.CustomProperties("X-DEVEXPRESS-CUSTOMFIELD-PRIORITY"), CustomProperty)
            customProperty.Value = ObjectConverter.ObjectToString(CInt(e.Appointment.CustomFields("Priority")))
        End Sub
    End Class

    Public MustInherit Class ReportExporter

        Private _Scheduler As SchedulerControl

        Public Shared Function Create(ByVal target As ExportTarget, ByVal scheduler As SchedulerControl) As ReportExporter
            Select Case target
                Case ExportTarget.Pdf
                    Return New ReportToPdfExporter(scheduler)
                Case ExportTarget.Image
                    Return New ReportToImageExporter(scheduler)
                Case ExportTarget.Html
                    Return New ReportToHtmlExporter(scheduler)
            End Select

            Return Nothing
        End Function

        Public Sub New(ByVal scheduler As SchedulerControl)
            Me.Scheduler = scheduler
        End Sub

        Public Property Scheduler As SchedulerControl
            Get
                Return _Scheduler
            End Get

            Private Set(ByVal value As SchedulerControl)
                _Scheduler = value
            End Set
        End Property

        Public Overridable ReadOnly Property Filter As String
            Get
                Return "All files(*.*)| *.* "
            End Get
        End Property

        Public Sub [Do](ByVal fileName As String)
            Dim newReport As XtraSchedulerReport = SchedulerReportFactory.Create(ReportType.DailyStyle)
            Dim controlPrintAdapter As SchedulerControlPrintAdapter = New SchedulerControlPrintAdapter(DemosInfo.CurrentScheduler)
            newReport.SchedulerAdapter = controlPrintAdapter
            newReport.SchedulerAdapter.EnableSmartSync = False
            newReport.PrintColorSchema = DemoUtils.ReportPrintColorSchema
            newReport.PrintingSystem.ClearContent()
            newReport.CreateDocument(True)
            Export(newReport, fileName)
        End Sub

        Protected MustOverride Sub Export(ByVal report As XtraSchedulerReport, ByVal fileName As String)
    End Class

    Public Class ReportToPdfExporter
        Inherits ReportExporter

        Public Sub New(ByVal scheduler As SchedulerControl)
            MyBase.New(scheduler)
        End Sub

        Public Overrides ReadOnly Property Filter As String
            Get
                Return "Pdf files(*.pdf)| *.pdf"
            End Get
        End Property

        Protected Overrides Sub Export(ByVal report As XtraSchedulerReport, ByVal fileName As String)
            report.ExportToPdf(fileName)
        End Sub
    End Class

    Public Class ReportToHtmlExporter
        Inherits ReportExporter

        Public Sub New(ByVal scheduler As SchedulerControl)
            MyBase.New(scheduler)
        End Sub

        Public Overrides ReadOnly Property Filter As String
            Get
                Return "Html files(*.html)| *.html"
            End Get
        End Property

        Protected Overrides Sub Export(ByVal report As XtraSchedulerReport, ByVal fileName As String)
            report.ExportToHtml(fileName)
        End Sub
    End Class

    Public Class ReportToImageExporter
        Inherits ReportExporter

        Private imageFormatResolver As Dictionary(Of String, DXImageFormat)

        Public Sub New(ByVal scheduler As SchedulerControl)
            MyBase.New(scheduler)
            imageFormatResolver = New Dictionary(Of String, DXImageFormat)()
            imageFormatResolver.Add(".png", DXImageFormat.Png)
            imageFormatResolver.Add(".jpg", DXImageFormat.Jpeg)
            imageFormatResolver.Add(".bmp", DXImageFormat.Bmp)
            imageFormatResolver.Add(".gif", DXImageFormat.Gif)
        End Sub

        Public Overrides ReadOnly Property Filter As String
            Get
                Return GetFilter()
            End Get
        End Property

        Protected Overrides Sub Export(ByVal report As XtraSchedulerReport, ByVal fileName As String)
            Dim imageFormat As DXImageFormat = GetImageFormatFromFileName(fileName)
            report.ExportToImage(fileName, imageFormat)
        End Sub

        Private Function GetFilter() As String
            Dim filterStrings As List(Of String) = New List(Of String)()
            For Each item As KeyValuePair(Of String, DXImageFormat) In imageFormatResolver
                filterStrings.Add(String.Format("{0} (*{1}) | *{1}", item.Value.ToString().ToUpper(), item.Key))
            Next

            Return String.Join("|", filterStrings)
        End Function

        Private Function GetImageFormatFromFileName(ByVal fileName As String) As DXImageFormat
            Dim extension As String = Path.GetExtension(fileName)
            Dim result As DXImageFormat = DXImageFormat.Png
            If imageFormatResolver.TryGetValue(extension, result) Then Return result
            Return DXImageFormat.Png
        End Function
    End Class
End Namespace
