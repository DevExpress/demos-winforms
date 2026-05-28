Imports System
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler.iCalendar

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class iCalendarExchangeModule
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
        ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        Protected Overrides ReadOnly Property TakeScreenDelay As Integer
            Get
                Return 300
            End Get
        End Property

        Protected ReadOnly Property IsCancelForRecurring As Boolean
            Get
                Return CType(cbCancelingTypes.EditValue, UsedAppointmentType).Equals(UsedAppointmentType.Recurring)
            End Get
        End Property

        Protected ReadOnly Property IsCancelForNonRecurring As Boolean
            Get
                Return CType(cbCancelingTypes.EditValue, UsedAppointmentType).Equals(UsedAppointmentType.NonRecurring)
            End Get
        End Property

        Private Sub iCalendarExchangeModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            FillData(schedulerControl, schedulerStorage)
            cbCancelingTypes.EditValue = UsedAppointmentType.None
            schedulerControl.DataStorage.EnableReminders = True
        End Sub

        Private Sub btnImport_Click(ByVal sender As Object, ByVal e As EventArgs)
            BeforeImportActions()
            Using stream As Stream = CreateInputStream(txtICalendar.Text)
                ImportAppointments(stream)
            End Using

            AfterImportActions()
            AfterExchangeActions()
        End Sub

        Private Sub ImportAppointments(ByVal stream As Stream)
            If stream Is Nothing Then Return
            Dim importer As iCalendarImporter = New iCalendarImporter(schedulerStorage)
            AddHandler importer.CalendarStructureCreated, New iCalendarStructureCreatedEventHandler(AddressOf importer_CalendarStructureCreated)
            AddHandler importer.AppointmentImporting, New AppointmentImportingEventHandler(AddressOf importer_AppointmentImporting)
            AddHandler importer.OnException, New ExchangeExceptionEventHandler(AddressOf importer_OnException)
            importer.Import(stream)
        End Sub

        Private Sub importer_OnException(ByVal sender As Object, ByVal e As ExchangeExceptionEventArgs)
            Dim args As iCalendarParseExceptionEventArgs = TryCast(e, iCalendarParseExceptionEventArgs)
            If args IsNot Nothing Then
                XtraMessageBox.Show(String.Format("Can't parse line '{1}' at {0} index", args.LineIndex, args.LineText))
                Dim importer As iCalendarImporter = CType(sender, iCalendarImporter)
                importer.Terminate()
            End If

            e.Handled = True
        End Sub

        Private Sub importer_AppointmentImporting(ByVal sender As Object, ByVal e As AppointmentImportingEventArgs)
            ProgressBarControl1.Position += 1
            ProgressBarControl1.Update()
            Dim cancel As Boolean = If(e.Appointment.IsRecurring, IsCancelForRecurring, IsCancelForNonRecurring)
            If cancel Then
                e.Cancel = True
            End If
        End Sub

        Private Sub importer_CalendarStructureCreated(ByVal sender As Object, ByVal e As iCalendarStructureCreatedEventArgs)
            Dim importer As iCalendarImporter = CType(sender, iCalendarImporter)
            ProgressBarControl1.Position = 0
            ProgressBarControl1.Properties.Maximum = importer.SourceObjectCount
        End Sub

        Private Sub BeforeImportActions()
            If chkClearBeforImport.Checked Then schedulerStorage.Appointments.Clear()
            RemoveHandler txtICalendar.TextChanged, New EventHandler(AddressOf txtICalendar_TextChanged)
        End Sub

        Private Sub AfterImportActions()
            AddHandler txtICalendar.TextChanged, New EventHandler(AddressOf txtICalendar_TextChanged)
        End Sub

        Private Sub txtICalendar_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            btnImport.Enabled = If(txtICalendar.Text.Length <> 0, True, False)
        End Sub

        Public Shared Function CreateInputStream(ByVal text As String) As Stream
            Dim buf As Byte() = Encoding.Unicode.GetBytes(text)
            Return New MemoryStream(buf, 0, buf.Length)
        End Function

        Private Sub AfterExchangeActions()
            ProgressBarControl1.Properties.Maximum = 100
            ProgressBarControl1.Position = 0
        End Sub

        Private Sub btnExport_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                Using ms As MemoryStream = New MemoryStream()
                    Using sr As StreamReader = New StreamReader(ms)
                        ExportAppointments(ms)
                        ms.Seek(0, SeekOrigin.Begin)
                        txtICalendar.Text = sr.ReadToEnd()
                    End Using
                End Using
            Catch
                MessageBox.Show("Error: could not export appointments")
            Finally
                AfterExchangeActions()
            End Try
        End Sub

        Private Sub ExportAppointments(ByVal stream As Stream)
            If stream Is Nothing Then Return
            Dim exporter As iCalendarExporter = New iCalendarExporter(schedulerStorage)
            ProgressBarControl1.Properties.Maximum = exporter.SourceObjectCount
            ProgressBarControl1.Position = 0
            exporter.ProductIdentifier = "-//Developer Express Inc.//XtraScheduler iCalendarExchangeDemo//EN"
            AddHandler exporter.AppointmentExporting, New AppointmentExportingEventHandler(AddressOf exporter_AppointmentExporting)
            exporter.Export(stream)
        End Sub

        Private Sub exporter_AppointmentExporting(ByVal sender As Object, ByVal e As AppointmentExportingEventArgs)
            ProgressBarControl1.Position += 1
            ProgressBarControl1.Update()
            Dim cancel As Boolean = If(e.Appointment.IsRecurring, IsCancelForRecurring, IsCancelForNonRecurring)
            If cancel Then
                e.Cancel = True
            End If
        End Sub
    End Class
End Namespace
