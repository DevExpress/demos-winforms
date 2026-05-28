Imports System

Namespace DevExpress.DevAV

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

    Friend NotInheritable Class StartUpProcess
        Implements IProcess, IDisposable

        Private Shared process As StartUpProcess

        Private ReadOnly tracker As IDisposable

        Private ReadOnly Events As System.ComponentModel.EventHandlerList

        Public Sub New()
            Events = New System.ComponentModel.EventHandlerList()
            process = Me
            tracker = StartUpProcessTracker.Instance.StartTracking(Me)
        End Sub

        Private Sub Dispose() Implements IDisposable.Dispose
            Events.Dispose()
            tracker.Dispose()
            process = Nothing
            GC.SuppressFinalize(Me)
        End Sub

        Public Shared ReadOnly Property Status As IObservable(Of String)
            Get
                Return StartUpProcessTracker.Instance
            End Get
        End Property

        Public Shared Sub OnStart(ByVal status As String)
            If process IsNot Nothing Then process.RaiseStart(status)
        End Sub

        Public Shared Sub OnRunning(ByVal status As String)
            If process IsNot Nothing Then process.RaiseRunning(status)
        End Sub

        Public Shared Sub OnComplete()
            If process IsNot Nothing Then Call process.RaiseComplete()
        End Sub

#Region "ProcessTracker"
        Private NotInheritable Class StartUpProcessTracker
            Inherits ProcessTracker

            Friend Shared Instance As StartUpProcessTracker = New StartUpProcessTracker()
        End Class

#End Region  ' ProcessTracker
#Region "IProcess Members"
        Private ReadOnly Shared startCore As Object = New Object()

        Private ReadOnly Shared runningCore As Object = New Object()

        Private ReadOnly Shared completeCore As Object = New Object()

        Private Custom Event Start As ProcessStatusEventHandler Implements IProcess.Start
            AddHandler(ByVal value As ProcessStatusEventHandler)
                Events.AddHandler(startCore, value)
            End AddHandler

            RemoveHandler(ByVal value As ProcessStatusEventHandler)
                Events.RemoveHandler(startCore, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As ProcessStatusEventArgs)
            End RaiseEvent
        End Event

        Private Custom Event Running As ProcessStatusEventHandler Implements IProcess.Running
            AddHandler(ByVal value As ProcessStatusEventHandler)
                Events.AddHandler(runningCore, value)
            End AddHandler

            RemoveHandler(ByVal value As ProcessStatusEventHandler)
                Events.RemoveHandler(runningCore, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As ProcessStatusEventArgs)
            End RaiseEvent
        End Event

        Private Custom Event Complete As EventHandler Implements IProcess.Complete
            AddHandler(ByVal value As EventHandler)
                Events.AddHandler(completeCore, value)
            End AddHandler

            RemoveHandler(ByVal value As EventHandler)
                Events.RemoveHandler(completeCore, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
            End RaiseEvent
        End Event

        Private Sub RaiseStart(ByVal status As String)
            Dim handler = TryCast(Events(startCore), ProcessStatusEventHandler)
            If handler IsNot Nothing Then handler(Me, New ProcessStatusEventArgs(status))
        End Sub

        Private Sub RaiseRunning(ByVal status As String)
            Dim handler = TryCast(Events(runningCore), ProcessStatusEventHandler)
            If handler IsNot Nothing Then handler(Me, New ProcessStatusEventArgs(status))
        End Sub

        Private Sub RaiseComplete()
            Dim handler = TryCast(Events(completeCore), EventHandler)
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub
#End Region
    End Class
End Namespace
