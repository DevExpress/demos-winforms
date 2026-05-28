Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.Data.Utils
Imports DevExpress.DXperience.Demos
Imports DevExpress.Internal
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace XtraReportsDemos

    Public Class frmMain
        Inherits DevExpress.DXperience.Demos.RibbonMainForm

        Private ReadOnly objects As HashSet(Of IDisposable) = New HashSet(Of IDisposable)()

        Public Sub New()
            ObjectDataSourceTypesRegistrator.RegisterTrustedTypes()
            AddHandler gcDescription.HyperlinkClick, AddressOf GcDescription_HyperlinkClick
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                For Each obj As IDisposable In objects
                    obj.Dispose()
                Next

                objects.Clear()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub GcDescription_HyperlinkClick(ByVal sender As Object, ByVal e As HyperlinkClickEventArgs)
            SafeProcess.Start(e.Link)
        End Sub

        Protected Overrides Sub SetFormParam()
            ribbonControl1.AutoHideEmptyItems = True
            ribbonControl1.TransparentEditors = True
            Icon = Properties.Resources.AppIcon
        End Sub

        Protected Overrides ReadOnly Property SupportAdvancedTitlePainting As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overrides ReadOnly Property UseEmptyRootPadding As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "XtraReportsForWin"
            End Get
        End Property

        Protected Overrides ReadOnly Property IsAllowAboutModule As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides ReadOnly Property CustomWidth As Integer
            Get
                Return 1400
            End Get
        End Property

        Protected Overrides ReadOnly Property DefaultModuleIndex As Integer
            Get
                Dim item As ModuleInfo = ModulesInfo.GetItemByType(GetType(NorthwindTraders.InvoicePreviewControl).FullName)
                If item IsNot Nothing Then
                    Dim index As Integer = ModulesInfo.GetItemIndex(item)
                    If index >= 0 Then Return index
                End If

                Return Math.Max(0, ModulesInfo.Count - 1)
            End Get
        End Property

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return "WinForms Reports"
            End Get
        End Property

        Private ReadOnly semaphore As SemaphoreSlim = New SemaphoreSlim(1)

        Private moduleToActivate As ReportModuleBase

        Private activeModule As ReportModuleBase

        Protected Overrides Async Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal lookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel)
            Dim newModuleInfo = ModulesInfo.GetItem(name)
            If newModuleInfo Is Nothing OrElse Equals(ModulesInfo.Instance.CurrentModuleBase?.Name, newModuleInfo?.Name) Then Return
            Try
                Dim pc = GetPrintControl(group)
                moduleToActivate = DemosInfo.ShowModule(newModuleInfo, group, RibbonMenuManager)
                If moduleToActivate Is Nothing Then Return
                objects.Add(moduleToActivate)
                If ReferenceEquals(moduleToActivate, activeModule) Then Return
                If TypeOf moduleToActivate Is ReportModule Then
                    Await ActivatePreviewModule(CType(moduleToActivate, ReportModule), group).ConfigureAwait(False)
                Else
                    Await ActivateCommonModule(name, moduleToActivate, group).ConfigureAwait(False)
                End If
            Catch ex As Exception
                Throw New Exception("Module failed: " & name, ex)
            End Try
        End Sub

        Private Async Function ActivatePreviewModule(ByVal moduleToActivate As ReportModule, ByVal group As GroupControl) As Task
            Dim waitResult As Boolean = Await semaphore.WaitAsync(100).ConfigureAwait(True)
            If Not waitResult Then Return
            Try
                Dim pc = GetPrintControl(group)
                pc.Visible = True
                Dim prevModule As ReportModule = TryCast(activeModule, ReportModule)
                activeModule = moduleToActivate
                If Not pc.IsDisposed Then pc.Activate(TryCast(activeModule, ReportModule))
                If prevModule IsNot Nothing Then Await prevModule.Deactivate().ConfigureAwait(False)
            Finally
                semaphore.Release()
            End Try
        End Function

        Private Async Function ActivateCommonModule(ByVal name As String, ByVal moduleToActivate As ReportModuleBase, ByVal group As GroupControl) As Task
            Dim waitResult As Boolean = Await semaphore.WaitAsync(100).ConfigureAwait(True)
            If Not waitResult Then Return
            Try
                Dim pc = GetPrintControl(group)
                pc.Visible = False
                pc.Deactivate()
                Dim prevModule As ReportModuleBase = activeModule
                activeModule = moduleToActivate
                If prevModule IsNot Nothing Then Await prevModule.Deactivate().ConfigureAwait(False)
            Finally
                semaphore.Release()
            End Try
        End Function

        Private Function GetPrintControl(ByVal group As GroupControl) As PreviewControl
            Dim pc As PreviewControl = group.Controls.OfType(Of PreviewControl)().FirstOrDefault()
            If pc Is Nothing Then
                pc = New PreviewControl()
                pc.SuspendLayout()
                pc.Bounds = group.DisplayRectangle
                group.Controls.Add(pc)
                pc.Dock = DockStyle.Fill
                pc.Initialize(RibbonMenuManager)
                pc.ResumeLayout()
                pc.Focus()
            End If

            Return pc
        End Function

        Shared Sub New()
            ' Third-party assemblies (.dll) required to run the demo are embedded inside the executable.
            ' This code loads these DLLs into the current AppDomain
            AddHandler AppDomain.CurrentDomain.AssemblyResolve, Function(s, e) OnAssemblyResolve(e)
        End Sub

        Private Shared Function OnAssemblyResolve(ByVal e As ResolveEventArgs) As System.Reflection.Assembly
            Dim assembly = GetType(frmMain).Assembly
            Dim partialName As String = AssemblyHelper.GetPartialName(e.Name)
            Dim assemblyName As String = partialName & ".dll"
            Dim manifestResourceName As String = assembly.GetManifestResourceNames().FirstOrDefault(Function(x) x.Equals(assemblyName, StringComparison.InvariantCultureIgnoreCase))
            If String.IsNullOrEmpty(manifestResourceName) Then Return Nothing
            Using manifestResourceStream As Stream = assembly.GetManifestResourceStream(manifestResourceName)
                If manifestResourceStream Is Nothing Then Return Nothing
                Dim data As Byte() = New Byte(CInt(manifestResourceStream.Length) - 1) {}
                manifestResourceStream.Read(data, 0, data.Length)
                Try
                    Dim location As String = Path.GetDirectoryName(GetType(frmMain).Assembly.Location)
                    Dim fullAssemblyPath As String = Path.Combine(location, assemblyName)
                    If Not File.Exists(fullAssemblyPath) Then File.WriteAllBytes(fullAssemblyPath, data) 'CodeSamples
                    Return DevExpress.Data.Internal.SafeTypeResolver.GetOrLoadAssemblyFrom(fullAssemblyPath)
                Catch
                End Try

                Return DevExpress.Data.Internal.SafeTypeResolver.GetOrLoadAssemblyBytes(data)
            End Using
        End Function

        <STAThread>
        Shared Sub Main()
            Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory)
            Runtime.ProfileOptimization.StartProfile("Startup.Profile")
            Dim enablePMv2 As Boolean = False
#If DEBUG
            enablePMv2 = True
#End If
            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 AndAlso enablePMv2 Then
                WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                WindowsFormsSettings.SetDPIAware()
            End If

            WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.WXI)
            WindowsFormsSettings.TrackWindowsAppMode = DefaultBoolean.True
            Dim path As String = DataDirectoryHelper.GetDataFile("NWind.db")
            Dim directory As String = IO.Path.GetDirectoryName(path)
            ConnectionHelper.SetDataDirectory(directory)
            DevExpress.XtraReports.Configuration.Settings.Default.UserDesignerOptions.ConvertBindingsToExpressions = DevExpress.XtraReports.UI.PromptBoolean.False
            DevExpress.UserSkins.BonusSkins.Register()
            DevExpress.XtraReports.Configuration.Settings.Default.UserDesignerOptions.ShowFieldListDateTimeComponents = True
            Call Application.Run(New frmMain())
        End Sub

        Protected Overrides Sub ShowAbout()
            DevExpress.XtraReports.Extensions.ReportsAboutHelper.About()
        End Sub

        Protected Overrides ReadOnly Property TestTimerInterval As Integer
            Get
                Return 4500
            End Get
        End Property
    End Class

    Public Class DemosInfo
        Inherits ModulesInfo

        Public Shared Overloads Function ShowModule(ByVal moduleInfo As ModuleInfo, ByVal group As GroupControl, ByVal manager As RibbonMenuManager) As ReportModuleBase
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            Try
                Dim oldModule As ReportModuleBase = Nothing
                If Instance.CurrentModuleBase IsNot Nothing Then
                    If moduleInfo Is Nothing OrElse Equals(Instance.CurrentModuleBase.Name, moduleInfo?.Name) Then Return Nothing
                    oldModule = TryCast(Instance.CurrentModuleBase.TModule, ReportModuleBase)
                End If

                Dim [module] = TryCast(moduleInfo.TModule, ReportModuleBase)
                If [module] Is Nothing Then Return Nothing
                If Not [module].IsExternalPreviewApplicable() Then
                    [module].Visible = False
                    [module].Dock = DockStyle.Fill
                    [module].RibbonMenuManager = manager
                    [module].Bounds = group.DisplayRectangle
                    group.Controls.Add([module])
                    [module].Visible = True
                End If

                If oldModule IsNot Nothing AndAlso Not oldModule.IsExternalPreviewApplicable() Then
                    oldModule.Visible = False
                End If

                [module].TutorialName = moduleInfo.Name
                moduleInfo.WasShown = True
                Instance.CurrentModuleBase = moduleInfo
                Call RaiseModuleChanged()
                Return [module]
            Finally
                Cursor.Current = currentCursor
            End Try
        End Function

        Public Shared Function ActivateModule(ByVal name As String) As ReportModuleBase
            If Instance.CurrentModuleBase IsNot Nothing AndAlso Equals(Instance.CurrentModuleBase.Name, name) Then Return Nothing
            Dim moduleInfo As ModuleInfo = GetItem(name)
            Dim [module] As ReportModuleBase = If(moduleInfo IsNot Nothing, TryCast(moduleInfo.TModule, ReportModuleBase), Nothing)
            If [module] Is Nothing Then Return Nothing
            [module].TutorialName = name
            Instance.CurrentModuleBase = moduleInfo
            Call RaiseModuleChanged()
            Return [module]
        End Function
    End Class

    Public Class About
        Inherits DevExpress.Tutorials.ucOverviewPage

        Protected Overrides ReadOnly Property Awards As Image
            Get
                Return DevExpress.Tutorials.Properties.Resources.Awards_main
            End Get
        End Property

        Protected Overrides ReadOnly Property Line1Text As String
            Get
                Return "The XtraReports Suite"
            End Get
        End Property

        Protected Overrides ReadOnly Property Line2Text As String
            Get
                Return "A banded report designer and viewer for the WinForms platform."
            End Get
        End Property

        Protected Overrides ReadOnly Property Line3Text As String
            Get
                Return "DevExpress Desktop Controls"
            End Get
        End Property

        Protected Overrides ReadOnly Property Line4Text As String
            Get
                Return votedVSM
            End Get
        End Property

        Protected Overrides ReadOnly Property ProductKind As DevExpress.Utils.About.ProductKind
            Get
                Return DevExpress.Utils.About.ProductKind.XtraReports
            End Get
        End Property
    End Class
End Namespace
