Imports System
Imports System.Collections.Generic

Namespace DevExpress.WindowsMailClient.Win.Utils

    Friend MustInherit Class ProcessTracker
        Implements IObservable(Of String)

        Private observers As IList(Of IObserver(Of String))

        Protected Sub New()
            observers = New List(Of IObserver(Of String))()
        End Sub

        Public Function StartTracking(ByVal process As IProcess) As IDisposable
            Return New TrackingContext(process, Me)
        End Function

        Private Function Subscribe(ByVal observer As IObserver(Of String)) As IDisposable Implements IObservable(Of String).Subscribe
            Return New Subscription(Me, observer)
        End Function

        Private Sub process_Start(ByVal sender As Object, ByVal e As ProcessStatusEventArgs)
            For Each observer As IObserver(Of String) In observers
                observer.OnNext(e.Status)
            Next
        End Sub

        Private Sub process_Running(ByVal sender As Object, ByVal e As ProcessStatusEventArgs)
            For Each observer As IObserver(Of String) In observers
                observer.OnNext(e.Status)
            Next
        End Sub

        Private Sub process_Complete(ByVal sender As Object, ByVal e As EventArgs)
            For Each observer As IObserver(Of String) In observers
                observer.OnCompleted()
            Next
        End Sub

        Private Class TrackingContext
            Implements IDisposable

            Private process As IProcess

            Private tracker As ProcessTracker

            Public Sub New(ByVal process As IProcess, ByVal tracker As ProcessTracker)
                AddHandler process.Start, AddressOf tracker.process_Start
                AddHandler process.Running, AddressOf tracker.process_Running
                AddHandler process.Complete, AddressOf tracker.process_Complete
                Me.process = process
                Me.tracker = tracker
            End Sub

            Private Sub Dispose() Implements IDisposable.Dispose
                RemoveHandler process.Start, AddressOf tracker.process_Start
                RemoveHandler process.Running, AddressOf tracker.process_Running
                RemoveHandler process.Complete, AddressOf tracker.process_Complete
                tracker = Nothing
                process = Nothing
            End Sub
        End Class

        Private Class Subscription
            Implements IDisposable

            Private observer As IObserver(Of String)

            Private tracker As ProcessTracker

            Public Sub New(ByVal tracker As ProcessTracker, ByVal observer As IObserver(Of String))
                If Not tracker.observers.Contains(observer) Then tracker.observers.Add(observer)
                Me.tracker = tracker
                Me.observer = observer
            End Sub

            Private Sub Dispose() Implements IDisposable.Dispose
                tracker.observers.Remove(observer)
            End Sub
        End Class
    End Class

    Public Interface IProcess

        Event Start As ProcessStatusEventHandler

        Event Running As ProcessStatusEventHandler

        Event Complete As EventHandler

    End Interface

    Public Delegate Sub ProcessStatusEventHandler(ByVal sender As Object, ByVal e As ProcessStatusEventArgs)

    Public Class ProcessStatusEventArgs
        Inherits EventArgs

        Private _Status As String

        Public Sub New(ByVal status As String)
            Me.Status = status
        End Sub

        Public Property Status As String
            Get
                Return _Status
            End Get

            Private Set(ByVal value As String)
                _Status = value
            End Set
        End Property
    End Class
End Namespace
