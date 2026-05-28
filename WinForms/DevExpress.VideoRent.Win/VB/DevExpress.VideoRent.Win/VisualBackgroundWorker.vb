Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.VideoRent.Helpers

Namespace DevExpress.VideoRent.Win
	Public Class VisualBackgroundWorker
		Inherits ProgressBarControl
		Implements IBackgroundWorker
		Private worker As New BackgroundWorker()
        Private freportedProgress As Integer
        Public Event DoWork As DoWorkEventHandler Implements IBackgroundWorker.DoWork
        Public Event RunWorkerCompleted As RunWorkerCompletedEventHandler Implements IBackgroundWorker.RunWorkerCompleted
        Public Event ProgressChanged As ProgressChangedEventHandler Implements IBackgroundWorker.ProgressChanged
        Public Sub New()
            MyBase.New()
            InitializeBackgroundWorker()
            freportedProgress = Me.Position
        End Sub
        Public ReadOnly Property CancellationPending() As Boolean Implements IBackgroundWorker.CancellationPending
            Get
                Return worker.CancellationPending
            End Get
        End Property
        Public ReadOnly Property IsBusy() As Boolean Implements IBackgroundWorker.IsBusy
            Get
                Return worker.IsBusy
            End Get
        End Property
        <DefaultValue(True)> _
        Public Property WorkerReportsProgress() As Boolean Implements IBackgroundWorker.WorkerReportsProgress
            Get
                Return worker.WorkerReportsProgress
            End Get
            Set(ByVal value As Boolean)
                worker.WorkerReportsProgress = value
            End Set
        End Property
        <DefaultValue(False)> _
        Public Property WorkerSupportsCancellation() As Boolean Implements IBackgroundWorker.WorkerSupportsCancellation
            Get
                Return worker.WorkerSupportsCancellation
            End Get
            Set(ByVal value As Boolean)
                worker.WorkerSupportsCancellation = value
            End Set
        End Property
        Public Sub CancelAsync() Implements IBackgroundWorker.CancelAsync
            worker.CancelAsync()
        End Sub
        Public Sub ReportProgress(ByVal percentProgress As Integer) Implements IBackgroundWorker.ReportProgress
            If percentProgress <= freportedProgress Then
                Return
            End If
            freportedProgress = percentProgress
            worker.ReportProgress(freportedProgress)
        End Sub
        Public Sub ReportProgress(ByVal percentProgress As Integer, ByVal userState As Object) Implements IBackgroundWorker.ReportProgress
            If percentProgress <= freportedProgress Then
                Return
            End If
            freportedProgress = percentProgress
            worker.ReportProgress(freportedProgress, userState)
        End Sub
        Public Sub RunWorkerAsync() Implements IBackgroundWorker.RunWorkerAsync
            freportedProgress = Me.Properties.Minimum
            Me.Position = freportedProgress
            worker.RunWorkerAsync()
        End Sub
        Public Sub RunWorkerAsync(ByVal argument As Object) Implements IBackgroundWorker.RunWorkerAsync
            freportedProgress = Me.Properties.Minimum
            Me.Position = freportedProgress
            worker.RunWorkerAsync(argument)
        End Sub
        Public ReadOnly Property ReportedProgress() As Integer Implements IBackgroundWorker.ReportedProgress
            Get
                Return freportedProgress
            End Get
        End Property
        Private Sub InitializeBackgroundWorker()
            worker.WorkerReportsProgress = True
            AddHandler worker.DoWork, AddressOf worker_DoWork
            AddHandler worker.RunWorkerCompleted, AddressOf worker_RunWorkerCompleted
            AddHandler worker.ProgressChanged, AddressOf worker_ProgressChanged
        End Sub
        Private Sub worker_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
            If (Not Object.Equals(DoWorkEvent, Nothing)) Then
                RaiseEvent DoWork(Me, e)
            End If
        End Sub
        Private Sub worker_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
            freportedProgress = Me.Properties.Maximum
            Me.Position = freportedProgress
            If (Not Object.Equals(RunWorkerCompletedEvent, Nothing)) Then
                RaiseEvent RunWorkerCompleted(Me, e)
            End If
        End Sub
		Private Sub worker_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
			Me.Position = e.ProgressPercentage
			If (Not Object.Equals(ProgressChangedEvent, Nothing)) Then
				RaiseEvent ProgressChanged(Me, e)
			End If
		End Sub
	End Class
End Namespace
