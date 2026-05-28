Imports System
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.XtraBars

Namespace DevExpress.XtraMap.Demos

    Public Partial Class frmMain
        Inherits RibbonMainForm

#Region "Properties"
        Overloads Friend ReadOnly Property ExportToImageExButton As BarSubItem
            Get
                Return MyBase.ExportToImageExButton
            End Get
        End Property

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return "WinForms Map Control"
            End Get
        End Property

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "XtraMap"
            End Get
        End Property

#End Region
        Protected Overrides Sub WndProc(ByRef msg As Message)
            If ShouldDoWndProc(msg) Then MyBase.WndProc(msg)
        End Sub

        Protected Overrides Sub ShowAbout()
            Call MapControl.About()
        End Sub

        Protected Overrides Sub SetFormParam()
            Icon = ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.XtraMap.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Protected Overrides Function CreateRibbonMenuManager() As RibbonMenuManager
            Return New RibbonMenuManager(Me)
        End Function

        Protected Overrides Sub ShowModule(ByVal name As String, ByVal groupControl As XtraEditors.GroupControl, ByVal lookAndFeel As LookAndFeel.DefaultLookAndFeel)
            DemosInfo.DoShowModule(name, groupControl, RibbonMenuManager)
        End Sub

        Protected Overrides ReadOnly Property SupportAdvancedTitlePainting As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides ReadOnly Property TestTimerInterval As Integer
            Get
                Return 4500
            End Get
        End Property

        Protected Overrides Function CanUseEmptyRootPadding(ByVal name As String) As Boolean
            Dim info As ModuleInfo = ModulesInfo.GetItem(name)
            If info IsNot Nothing AndAlso TypeOf info.TModule Is MapTutorialControl Then Return CType(info.TModule, MapTutorialControl).UseEmptyRootPadding
            Return MyBase.CanUseEmptyRootPadding(name)
        End Function
    End Class

    Friend Module OverlapFlickeringSolver

        Private ReadOnly isWin7 As Boolean = Environment.OSVersion.Version.Major = 6 AndAlso Environment.OSVersion.Version.Minor = 1

        Private isFilteringEnabled As Boolean = False

        '
        <System.Security.SecurityCritical>
        Public Function ShouldDoWndProc(ByVal message As Message) As Boolean
            Return Not isWin7 OrElse Not isFilteringEnabled OrElse message.Msg <> &H3 AndAlso message.Msg <> &H47
        End Function

        Public Sub Refresh(ByVal backgroundForm As Form)
            If Not isWin7 Then Return
            Try
                isFilteringEnabled = True
                Dim safeNativeMethodsType As Type = Data.Internal.SafeTypeResolver.GetKnownType(GetType(Form).Assembly, "System.Windows.Forms.SafeNativeMethods", False)
                If safeNativeMethodsType IsNot Nothing Then
                    Dim parentNativeWindow As Object = Utils.Helpers.NativeField(Of Control).Ensure("window").GetValue(backgroundForm)
                    Dim parent As HandleRef = New HandleRef(parentNativeWindow, backgroundForm.Handle)
                    Dim zero As HandleRef = New HandleRef(Nothing, IntPtr.Zero)
                    Dim setWindowPos As Reflection.MethodInfo = safeNativeMethodsType.GetMethod("SetWindowPos")
                    setWindowPos.Invoke(Nothing, New Object() {parent, zero, backgroundForm.Left + 1, backgroundForm.Top, 0, 0, &H441})
                    setWindowPos.Invoke(Nothing, New Object() {parent, zero, backgroundForm.Left, backgroundForm.Top, 0, 0, &H441})
                End If

                Call Application.DoEvents()
            Catch
            Finally
                isFilteringEnabled = False
            End Try
        End Sub
    End Module
End Namespace
