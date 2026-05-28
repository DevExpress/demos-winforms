Imports System
Imports System.Windows.Forms
Imports DevExpress.Data.Filtering
Imports DevExpress.Utils.DirectXPaint
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraPivotGrid.Demos

    Friend Module Program

        <STAThread>
        Sub Main()
            Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory)
            Runtime.ProfileOptimization.StartProfile("Startup.Profile")
            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 Then
                WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                WindowsFormsSettings.SetDPIAware()
            End If

            WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True
            WindowsFormsSettings.InvertHorizontalScrolling = DevExpress.Utils.DefaultBoolean.True
            Call RegisterCustomFunctions()
            DirectXDeviceManager.Default.DeviceLimit = 10
            WindowsFormsSettings.CustomizationFormSnapMode = DevExpress.Utils.Controls.SnapMode.All
            WindowsFormsSettings.ScrollUIMode = ScrollUIMode.Fluent
            UserSkins.BonusSkins.Register()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New frmMain())
        End Sub

        Private Sub RegisterCustomFunctions()
            Call NotBeginsWithFunction.Register()
            Call IsBlackFridayFunction.Register()
            Call IsWeekendFunction.Register()
            AddHandler CriteriaOperator.QueryCustomFunctions, AddressOf OnQueryCustomUiFunction
        End Sub

        Private Sub OnQueryCustomUiFunction(ByVal sender As Object, ByVal e As DevExpress.Data.Filtering.CustomFunctionEventArgs)
            If e.PropertyType Is GetType(String) Then e.Add(NotBeginsWithFunction.FunctionName)
        End Sub
    End Module
End Namespace
