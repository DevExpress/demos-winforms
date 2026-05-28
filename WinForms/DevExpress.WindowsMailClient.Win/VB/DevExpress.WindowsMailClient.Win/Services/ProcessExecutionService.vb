Imports System.Diagnostics
Imports System.Linq
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.Customization
Imports DevExpress.Utils.Commands
Imports DevExpress.WindowsMailClient.Win.Forms
Imports DevExpress.WindowsMailClient.Win.Utils
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Commands
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.WindowsMailClient.Win.Services

    Public Interface IProcessExecutionService

        Sub ExecuteProcess(ByVal name As String)

        Sub ShowWN()

        Sub ShowDocumentation()

        Sub ShowAppointmentForm(ByVal scheduler As SchedulerControl)

        Sub ShowSignatureForm()

        Sub ShowPaletteSelector()

    End Interface

    Friend Class ProcessExecutionService
        Implements IProcessExecutionService

        Public Sub ExecuteProcess(ByVal name As String) Implements IProcessExecutionService.ExecuteProcess
            ExecuteCore(name)
        End Sub

        Private progressPanelHandle As IOverlaySplashScreenHandle = Nothing

        Public Sub ShowSignatureForm() Implements IProcessExecutionService.ShowSignatureForm
            Cursor.Current = Cursors.WaitCursor
            Try
                progressPanelHandle = ShowProgressPanel(AppProvider.MainForm)
                Dim form = New EmailSignatureEditForm()
                form.Show()
            Finally
                CloseProgressPanel(progressPanelHandle)
            End Try

            Cursor.Current = Cursors.Default
        End Sub

        Public Sub ShowPaletteSelector() Implements IProcessExecutionService.ShowPaletteSelector
            Using svgSkinPaletteSelector As SvgSkinPaletteSelector = New SvgSkinPaletteSelector(AppProvider.MainForm)
                svgSkinPaletteSelector.ShowDialog()
            End Using
        End Sub

        Public Sub ShowAppointmentForm(ByVal scheduler As SchedulerControl) Implements IProcessExecutionService.ShowAppointmentForm
            Dim command As NewAppointmentCommandBase = New NewAppointmentCommand(scheduler)
            command.CommandSourceType = CommandSourceType.Mouse
            command.Execute()
        End Sub

        Public Sub ShowWN() Implements IProcessExecutionService.ShowWN
            Dim assemblies = Assembly.GetExecutingAssembly().GetReferencedAssemblies()
            Dim assemblyForCheck As AssemblyName = assemblies.FirstOrDefault(Function(x) x.Name.Contains("DevExpress"))
            If assemblyForCheck IsNot Nothing Then
                Dim minorVersion As String = assemblyForCheck.Version.Minor.ToString()
                Dim majorVersion As String = assemblyForCheck.Version.Major.ToString()
                ExecuteCore(String.Format("https://www.devexpress.com/Subscriptions/New-20{0}-{1}.xml", majorVersion, minorVersion))
            Else
                ExecuteCore("https://www.devexpress.com/Subscriptions/New-2018-1.xml")
            End If
        End Sub

        Public Sub ShowDocumentation() Implements IProcessExecutionService.ShowDocumentation
            ExecuteCore("https://www.devexpress.com/Support/Documentation/")
        End Sub

        Private Sub ExecuteCore(ByVal procName As String)
            Try
                DevExpress.Data.Utils.SafeProcess.Start(procName)
            Catch
            End Try
        End Sub
    End Class
End Namespace
