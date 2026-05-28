Imports System
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.WindowsMailClient.Win.Utils

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

    Friend NotInheritable Class DemoStartUp
        Implements IObserver(Of String)

        Private options As FluentSplashScreenOptions = Nothing

        Public Sub New()
            options = New FluentSplashScreenOptions() With {.Title = "When Only The Best Will Do", .Subtitle = "DevExpress WinForms Controls", .RightFooter = "Starting...", .LeftFooter = AssemblyInfo.AssemblyCopyright & Environment.NewLine & "All Rights reserved.", .LoadingIndicatorType = FluentLoadingIndicatorType.Dots, .OpacityColor = System.Drawing.Color.FromArgb(16, 110, 190), .Opacity = 130}
            options.AppearanceLeftFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            options.LogoImageOptions.SvgImage = Properties.Resources.DevExpress_Logo_Mono
        End Sub

        Private Sub OnCompleted() Implements IObserver(Of String).OnCompleted
            SplashScreenManager.CloseForm(False, 300, AppProvider.MainForm)
        End Sub

        Private Sub OnNext(ByVal status As String) Implements IObserver(Of String).OnNext
            If SplashScreenManager.Default Is Nothing Then
                SplashScreenManager.ShowFluentSplashScreen(options, Nothing, AppProvider.MainForm)
            Else
                options.RightFooter = status
                SplashScreenManager.Default.SendCommand(FluentSplashScreenCommand.UpdateOptions, options)
            End If
        End Sub

        Private Sub OnError(ByVal [error] As Exception) Implements IObserver(Of String).OnError
            Throw [error]
        End Sub
    End Class
End Namespace
