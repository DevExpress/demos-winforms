Imports System
Imports System.Globalization
Imports System.Windows.Forms
Imports DevExpress.Data.Filtering
Imports DevExpress.Tutorials
Imports DevExpress.Utils.DirectXPaint
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraGrid.Demos

    Friend Module Program

        <STAThread>
        Sub Main(ByVal arguments As String())
            Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory)
            Runtime.ProfileOptimization.StartProfile("Startup.Profile")
            Call FilePathUtils.ResolveAssembliesFromSpecificFolderIfRequired()
            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 Then
                XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                XtraEditors.WindowsFormsSettings.SetDPIAware()
            End If

            XtraEditors.WindowsFormsSettings.UseUIAutomation = Utils.DefaultBoolean.True
            XtraEditors.WindowsFormsSettings.InvertHorizontalScrolling = Utils.DefaultBoolean.True
            XtraEditors.WindowsFormsSettings.KeyboardNavigationExtensions = XtraEditors.KeyboardNavigationExtensions.ColumnHeaders
            Call RegisterCustomFunctions()
            RepositoryItemTextEdit.MaxToolTipTextLength = 1000
            DirectXDeviceManager.Default.DeviceLimit = 10
            Dim demoCI As CultureInfo = CType(Application.CurrentCulture.Clone(), CultureInfo)
            demoCI.NumberFormat.CurrencySymbol = "$"
            demoCI.NumberFormat.CurrencyDecimalDigits = 2
            Application.CurrentCulture = demoCI
            UserSkins.BonusSkins.Register()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New frmMain(arguments))
        End Sub

        ' Custom Functions
        Private Sub RegisterCustomFunctions()
            Call NotBeginsWithFunction.Register()
            Call IsBlackFridayDiscountFunction.Register()
            Call DaysBeforeOrAfterTodayFunction.Register()
            Call IsWeekendFunction.Register()
            AddHandler CriteriaOperator.QueryCustomFunctions, AddressOf OnQueryCustomUIFunctions
        End Sub

        Private Sub OnQueryCustomUIFunctions(ByVal sender As Object, ByVal e As CustomFunctionEventArgs)
            If e.PropertyType Is GetType(String) Then e.Add(NotBeginsWithFunction.FunctionName)
        End Sub
    End Module
End Namespace
