Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraRichEdit.Services

Namespace DevExpress.XtraRichEdit.Demos

    Public Class TutorialControl
        Inherits TutorialControlBase
        Implements IDXMenuManager

        Public Sub New()
            AutoMergeRibbon = True
            Dim exceptionHandler As RichEditDemoExceptionsHandler = New RichEditDemoExceptionsHandler(RichEdit)
            exceptionHandler.Install()
        End Sub

        Public Overridable ReadOnly Property RichEdit As RichEditControl
            Get
                Return Nothing
            End Get
        End Property

        Protected Sub LoadDocument(ByVal fileName As String)
            Dim path As String = DemoUtils.GetRelativePath(fileName)
            If Not String.IsNullOrEmpty(path) Then RichEdit.LoadDocument(path)
        End Sub

        Private Sub ShowPopupMenu(ByVal menu As DXPopupMenu, ByVal control As Control, ByVal pos As Point) Implements IDXMenuManager.ShowPopupMenu
            MenuManagerHelper.ShowMenu(menu, LookAndFeel, Me, control, pos)
        End Sub

        Private Function Clone(ByVal newForm As Form) As IDXMenuManager Implements IDXMenuManager.Clone
            Return Me
        End Function

        Private Sub DisposeManager() Implements IDXMenuManager.DisposeManager
        End Sub

        Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As BarManager)
            Dim control As RichEditControl = TryCast(ctrl, RichEditControl)
            If control IsNot Nothing Then control.MenuManager = manager
            Dim be As BaseEdit = TryCast(ctrl, BaseEdit)
            If be IsNot Nothing Then be.MenuManager = manager
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            If RichEdit IsNot Nothing Then
                RichEdit.ReplaceService(Of IUserAccountService)(New UserAccountService())
                RichEdit.Select()
            End If
        End Sub

        '
        Private NotInheritable Class UserAccountService
            Implements IUserAccountService

            Private Shared userName As String

            Private Function GetUserName() As String Implements IUserAccountService.GetUserName
                Return If(userName, Function()
                    userName = GetCurrentUserName()
                    Return userName
                End Function())
            End Function

            Private Function GetCurrentUserName() As String
                Try
                    Return SystemInformation.UserName
                Catch
                    Return Nothing
                End Try
            End Function
        End Class
    End Class
End Namespace
