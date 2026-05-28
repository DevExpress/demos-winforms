Namespace DevExpress.DevAV.Services

    Public Interface IPeekModulesHostingService

        Function IsDocked(ByVal moduleType As ModuleType) As Boolean

        Sub DockModule(ByVal moduleType As ModuleType)

        Sub UndockModule(ByVal moduleType As ModuleType)

        Sub ShowModule(ByVal moduleType As ModuleType)

    End Interface

    Friend Class PeekModulesHostingService
        Implements IPeekModulesHostingService

        Private peekModulesHost As IPeekModulesHost

        Public Sub New(ByVal peekModulesHost As IPeekModulesHost)
            Me.peekModulesHost = peekModulesHost
        End Sub

        Private Function IsDocked(ByVal moduleType As ModuleType) As Boolean Implements IPeekModulesHostingService.IsDocked
            Return peekModulesHost.IsDocked(moduleType)
        End Function

        Private Sub DockModule(ByVal moduleType As ModuleType) Implements IPeekModulesHostingService.DockModule
            peekModulesHost.DockModule(moduleType)
        End Sub

        Private Sub UndockModule(ByVal moduleType As ModuleType) Implements IPeekModulesHostingService.UndockModule
            peekModulesHost.UndockModule(moduleType)
        End Sub

        Private Sub ShowModule(ByVal moduleType As ModuleType) Implements IPeekModulesHostingService.ShowModule
            peekModulesHost.ShowPeek(moduleType)
        End Sub
    End Class
End Namespace
