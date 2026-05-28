Imports System.Collections.Generic

Namespace DevExpress.DevAV.Services

    Public Interface IWorkspaceService

        Sub SetupDefaultWorkspace()

        Sub SaveWorkspace(ByVal workspaceName As String)

        Sub RestoreWorkspace(ByVal workspaceName As String)

        Sub ResetWorkspace(ByVal workspaceName As String)

    End Interface

    Friend NotInheritable Class WorkspaceService
        Implements IWorkspaceService

        Private ReadOnly supportModuleLayout As ISupportModuleLayout

        Private Shared DefaultWorkspaceLayout As String

        Private Shared layouts As IDictionary(Of String, String)

        Public Sub New(ByVal supportModuleLayout As ISupportModuleLayout)
            Me.supportModuleLayout = supportModuleLayout
        End Sub

        Public Sub SetupDefaultWorkspace() Implements IWorkspaceService.SetupDefaultWorkspace
            If layouts Is Nothing Then layouts = New Dictionary(Of String, String)()
            DefaultWorkspaceLayout = StoreCore()
        End Sub

        Public Sub SaveWorkspace(ByVal workspaceName As String) Implements IWorkspaceService.SaveWorkspace
            layouts(workspaceName) = StoreCore()
        End Sub

        Public Sub RestoreWorkspace(ByVal workspaceName As String) Implements IWorkspaceService.RestoreWorkspace
            Dim layoutStr As String = Nothing
            If Not layouts.TryGetValue(workspaceName, layoutStr) Then layoutStr = DefaultWorkspaceLayout
            RestoreCore(layoutStr)
        End Sub

        Public Sub ResetWorkspace(ByVal workspaceName As String) Implements IWorkspaceService.ResetWorkspace
            layouts.Remove(workspaceName)
            RestoreCore(DefaultWorkspaceLayout)
        End Sub

        Private Function StoreCore() As String
            Using ms = New System.IO.MemoryStream()
                supportModuleLayout.SaveLayoutToStream(ms)
                Return System.Convert.ToBase64String(ms.ToArray())
            End Using
        End Function

        Private Sub RestoreCore(ByVal layoutStr As String)
            If String.IsNullOrEmpty(layoutStr) Then Return
            Dim bytes = System.Convert.FromBase64String(layoutStr)
            Using ms = New System.IO.MemoryStream(bytes)
                supportModuleLayout.RestoreLayoutFromStream(ms)
            End Using
        End Sub
    End Class
End Namespace
