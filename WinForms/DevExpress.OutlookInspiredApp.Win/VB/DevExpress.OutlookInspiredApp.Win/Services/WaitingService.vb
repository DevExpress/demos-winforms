Imports System
Imports DevExpress.XtraSplashScreen
Imports System.Runtime.CompilerServices

Namespace DevExpress.DevAV.Services

    Public Interface IWaitingService

        Sub BeginWaiting(ByVal parameter As Object)

        Sub EndWaiting()

    End Interface

    Friend Class WaitingService
        Implements IWaitingService

        Private Sub BeginWaiting(ByVal parameter As Object) Implements IWaitingService.BeginWaiting
            ShowWaitForm(XtraEditors.EnumDisplayTextHelper.GetDisplayText(parameter))
        End Sub

        Private Sub EndWaiting() Implements IWaitingService.EndWaiting
            Call CloseWaitForm()
        End Sub

        Private Shared Sub ShowWaitForm(ByVal caption As String)
            If SplashScreenManager.Default Is Nothing Then Call SplashScreenManager.ShowDefaultWaitForm(AppHelper.MainForm, False, False, False, 250, caption)
        End Sub

        Private Shared Sub CloseWaitForm()
            Dim ssm = SplashScreenManager.Default
            If ssm IsNot Nothing AndAlso ssm.ActiveSplashFormTypeInfo IsNot Nothing AndAlso ssm.ActiveSplashFormTypeInfo.Mode = Mode.WaitForm Then Call SplashScreenManager.CloseForm(False, 750, AppHelper.MainForm)
        End Sub
    End Class

    Friend Class LoadingService
        Implements IWaitingService

        Private owner As Windows.Forms.UserControl

        Public Sub New(ByVal owner As Windows.Forms.UserControl)
            Me.owner = owner
        End Sub

        Private Sub BeginWaiting(ByVal parameter As Object) Implements IWaitingService.BeginWaiting
            Call ShowWaitForm(owner, parameter.ToString())
        End Sub

        Private Sub EndWaiting() Implements IWaitingService.EndWaiting
            Call CloseWaitForm()
        End Sub

        Private Shared Sub ShowWaitForm(ByVal owner As Windows.Forms.UserControl, ByVal caption As String)
            If SplashScreenManager.Default Is Nothing Then Call SplashScreenManager.ShowDefaultWaitForm(If(owner IsNot Nothing, owner.FindForm(), Nothing), False, False, caption)
        End Sub

        Private Shared Sub CloseWaitForm()
            Dim ssm = SplashScreenManager.Default
            If ssm IsNot Nothing AndAlso ssm.ActiveSplashFormTypeInfo IsNot Nothing AndAlso ssm.ActiveSplashFormTypeInfo.Mode = Mode.WaitForm Then Call SplashScreenManager.CloseForm(False, 250, AppHelper.MainForm)
        End Sub
    End Class

    Public Module WaitingServiceExtension

        Sub New()
            SplashScreenManager.ActivateParentOnWaitFormClosing = False
        End Sub

        <Extension()>
        Public Function Enter(ByVal service As IWaitingService, ByVal parameter As Object, ByVal Optional effective As Boolean = True) As IDisposable
            Return New WaitingBatch(If(effective, service, Nothing), parameter)
        End Function

        Private Class WaitingBatch
            Implements IDisposable

            Private service As IWaitingService

            Public Sub New(ByVal service As IWaitingService, ByVal parameter As Object)
                Me.service = service
                If service IsNot Nothing Then service.BeginWaiting(parameter)
            End Sub

            Public Sub Dispose() Implements IDisposable.Dispose
                If service IsNot Nothing Then service.EndWaiting()
            End Sub
        End Class
    End Module
End Namespace
