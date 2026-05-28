Imports System
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.WindowsMailClient.Win.Utils

    Friend Module AppProvider

        Public Sub ProcessStart(ByVal name As String)
            ProcessStart(name, String.Empty)
        End Sub

        Public Sub ProcessStart(ByVal name As String, ByVal arguments As String)
            Try
                DevExpress.Data.Utils.SafeProcess.Start(name, setup:=Sub(x)
                    x.Arguments = arguments
                    x.Verb = "Open"
                    x.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
                End Sub)
            Catch __unusedWin32Exception1__ As System.ComponentModel.Win32Exception
            End Try
        End Sub

        Public ReadOnly Property ApplicationID As String
            Get
                Return String.Format("Components_{0}_Demo_Center_{0}", AssemblyInfo.VersionShort.Replace(".", "_"))
            End Get
        End Property

        Public ReadOnly Property AppIcon As Icon
            Get
                Return ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.WindowsMailClient.Win.AppIcon.ico", Assembly.GetExecutingAssembly())
            End Get
        End Property

        Private img As Image

        Public ReadOnly Property AppImage As Image
            Get
                If img Is Nothing Then img = AppIcon.ToBitmap()
                Return img
            End Get
        End Property

        Private wRef As WeakReference

        Public Property MainForm As MainForm
            Get
                Return If(wRef IsNot Nothing, TryCast(wRef.Target, MainForm), Nothing)
            End Get

            Set(ByVal value As MainForm)
                wRef = New WeakReference(value)
            End Set
        End Property

        Public Function GetDefaultSize() As Single
            Return 8.25F
        End Function

        Friend Function ShowProgressPanel(ByVal owner As Control, ByVal Optional windowOptions As OverlayWindowOptions = Nothing) As IOverlaySplashScreenHandle
            Dim handle As IOverlaySplashScreenHandle = Nothing
            Try
                handle = SplashScreenManager.ShowOverlayForm(If(owner, MainForm), If(windowOptions, OverlayWindowOptions.Default))
            Catch
            End Try

            Return handle
        End Function

        Friend Sub CloseProgressPanel(ByVal handle As IOverlaySplashScreenHandle)
            Try
                SplashScreenManager.CloseOverlayForm(handle)
            Catch
            End Try
        End Sub
    End Module
End Namespace
