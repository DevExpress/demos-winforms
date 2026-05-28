Imports System
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Xpo
Imports DevExpress.XtraScheduler.Exchange
Imports DevExpress.XtraScheduler.Outlook

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class OutlookSynchronizationModule
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
        ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
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

        Protected ReadOnly Property CalendarName As String
            Get
                Return cbCalendarFolderPaths.Text
            End Get
        End Property

        Private Sub OutlookSynchronizationModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.Start = TutorialConstants.Today
            UpdateControls()
        End Sub

        Private Sub OutlookSynchronizationModule_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Visible Then
                xpCollectionEvents.Session.DropIdentityMap()
                xpCollectionEvents.Reload()
            End If
        End Sub

        Private Sub UpdateControls()
            cbCancelingTypes.EditValue = UsedAppointmentType.None
            FillCalendarNamesCombo()
        End Sub

        Private Sub FillCalendarNamesCombo()
            cbCalendarFolderPaths.Properties.BeginUpdate()
            Try
                cbCalendarFolderPaths.Properties.Items.Clear()
                cbCalendarFolderPaths.Properties.Items.AddRange(DemoUtils.OutlookCalendarPaths)
            Finally
                cbCalendarFolderPaths.Properties.EndUpdate()
                cbCalendarFolderPaths.SelectedIndex = 0
            End Try
        End Sub

        Private Sub schedulerStorage_AppointmentsChanged(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
            session1.BeginTransaction()
            Try
                For Each apt As Appointment In e.Objects
                    Dim o As XPBaseObject = TryCast(apt.GetSourceObject(schedulerStorage), XPBaseObject)
                    If o IsNot Nothing Then o.Save()
                Next

                session1.CommitTransaction()
            Catch
                session1.RollbackTransaction()
            End Try
        End Sub

#Region "supplementary functionality"
        Private Sub AddToLog(ByVal s As String)
            lbcLog.Items.Add(s)
        End Sub

        Private Sub SuspendLog()
            lbcLog.Items.BeginUpdate()
        End Sub

        Private Sub ResumeLog()
            lbcLog.SelectedIndex = lbcLog.Items.Count - 1
            lbcLog.Items.EndUpdate()
        End Sub

        Private Sub ClearLog()
            lbcLog.Items.Clear()
        End Sub

        Private Sub BeforeSynchronization(ByVal objectCount As Integer)
            AddToLog(String.Format("{0} - Start synchronization with '{1}' calendar...", TutorialConstants.Now.ToLongTimeString(), CalendarName))
            Call Application.DoEvents()
            SuspendLog()
            ProgressBarControl1.Position = 0
            ProgressBarControl1.Properties.Maximum = objectCount
        End Sub

        Private Sub AfterSynchronization()
            AddToLog(String.Format("{0} - Synchronization complete!", TutorialConstants.Now.ToLongTimeString()))
            AddToLog(New String("-"c, 60))
            ResumeLog()
            ProgressBarControl1.Properties.Maximum = 100
            ProgressBarControl1.Position = 0
        End Sub

        Private Function CreateSyncronizationLogString(ByVal e As AppointmentSynchronizingEventArgs) As String
            Dim args As OutlookAppointmentSynchronizingEventArgs = CType(e, OutlookAppointmentSynchronizingEventArgs)
            Return String.Format("Trying to {0}: apt={1}, olApt={2} ...", args.Operation.ToString(), DemoUtils.FormatAppointmentString(args.Appointment), DemoUtils.FormatOutlookAppointmentString(args.OutlookAppointment))
        End Function

#End Region
        Private Sub btnClearLog_Click(ByVal sender As Object, ByVal e As EventArgs)
            ClearLog()
        End Sub

        Private Sub btnSynchronize_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                Synchronize()
            Catch ex As Exception
                DemoUtils.ReportOutlookError("synchronize XtraScheduler with Microsoft Outlook", ex.Message)
            End Try
        End Sub

        Private Sub Synchronize()
            Dim synchronizer As AppointmentImportSynchronizer = schedulerStorage.CreateOutlookImportSynchronizer()
            CType(synchronizer, ISupportCalendarFolders).CalendarFolderName = CalendarName
            synchronizer.ForeignIdFieldName = "EntryID"
            AddHandler synchronizer.AppointmentSynchronizing, New AppointmentSynchronizingEventHandler(AddressOf synchronizer_AppointmentSynchronizing)
            AddHandler synchronizer.AppointmentSynchronized, New AppointmentSynchronizedEventHandler(AddressOf synchronizer_AppointmentSynchronized)
            AddHandler synchronizer.OnException, New ExchangeExceptionEventHandler(AddressOf synchronizer_OnException)
            Dim oldCur As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            BeforeSynchronization(synchronizer.SourceObjectCount)
            Try
                synchronizer.Synchronize()
            Finally
                AfterSynchronization()
                Cursor.Current = oldCur
            End Try
        End Sub

        Private Sub synchronizer_OnException(ByVal sender As Object, ByVal e As ExchangeExceptionEventArgs)
            Dim errText As String = e.OriginalException.Message
            Dim args As OutlookExchangeExceptionEventArgs = TryCast(e, OutlookExchangeExceptionEventArgs)
            If args IsNot Nothing Then
                If args.OutlookAppointment IsNot Nothing Then
                    errText += String.Format(Microsoft.VisualBasic.Constants.vbCrLf & "Event '{0}' started on {1:D} at {2}" & Microsoft.VisualBasic.Constants.vbLf, args.OutlookAppointment.Subject, args.OutlookAppointment.Start, args.OutlookAppointment.Start.TimeOfDay)
                End If
            End If

            AddToLog(errText)
            Dim synchronizer As AppointmentImportSynchronizer = CType(sender, AppointmentImportSynchronizer)
            synchronizer.Terminate()
            e.Handled = True
            Throw e.OriginalException
        End Sub

        Private Sub synchronizer_AppointmentSynchronizing(ByVal sender As Object, ByVal e As AppointmentSynchronizingEventArgs)
            Dim args As OutlookAppointmentSynchronizingEventArgs = CType(e, OutlookAppointmentSynchronizingEventArgs)
            AddToLog(CreateSyncronizationLogString(args))
            ProgressBarControl1.Position += 1
            ProgressBarControl1.Update()
            Dim apt As Appointment = e.Appointment
            Dim cancel As Boolean = False
            If apt IsNot Nothing Then
                cancel = If(apt.IsRecurring, IsCancelForRecurring, IsCancelForNonRecurring)
            End If

            If cancel Then
                e.Cancel = True
                AddToLog("Cancelled because of the appointment type")
                Return
            End If

            Select Case e.Operation
                Case SynchronizeOperation.Create
                    If chkDontCreateNew.Checked Then
                        AddToLog("Cancelled because of the 'DontCreateNew' rule")
                        e.Cancel = True
                    End If

                Case SynchronizeOperation.Delete
                    If chkDontDeleteExisting.Checked Then
                        AddToLog("Cancelled because of the 'DontDeleteExisting' rule")
                        e.Cancel = True
                    End If

                Case SynchronizeOperation.Replace
                    If chkDeleteInsteadReplace.Checked Then
                        e.Operation = SynchronizeOperation.Delete
                        AddToLog("Synchronization operation has been changed from 'Replace' to 'Delete' because of the DeleteInsteadReplace rule")
                    End If

            End Select
        End Sub

        Private Sub synchronizer_AppointmentSynchronized(ByVal sender As Object, ByVal e As AppointmentSynchronizedEventArgs)
            AddToLog(String.Format("Successfully synchronized: {0}", DemoUtils.FormatAppointmentString(e.Appointment)))
        End Sub
    End Class
End Namespace
