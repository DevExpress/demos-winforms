Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.Utils.Layout
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Extensions
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.Utils.Drawing.Helpers
Imports DevExpress.XtraLayout.Demos.Controls

Namespace DevExpress.XtraLayout.Demos.Modules.XtraLayoutPanel

    Public Class XtraLayoutPanelDemoViewBase
        Inherits XtraForm

        Private Shared controlSelectRequestEventKey As Object = New Object()

        Private Shared controlDeleteRequestEventKey As Object = New Object()

        Public Sub New()
            TopLevel = False
            FormBorderStyle = FormBorderStyle.SizableToolWindow
        End Sub

        Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
            If e.CloseReason = CloseReason.UserClosing Then e.Cancel = True
            MyBase.OnFormClosing(e)
        End Sub

        Public Sub Initialize()
            InitializeControls()
            LayoutPanel.ForEachChildControlIncludeItself(Sub(x)
                If TypeOf x Is MaskBox Then Return
                AddHandler x.Click, AddressOf OnChildControlMouseClick
            End Sub)
            AddHandler LayoutPanel.ControlAdded, AddressOf OnChildControlAdded
            AddHandler LayoutPanel.ControlRemoved, AddressOf OnChildControlRemoved
        End Sub

        Public Overridable Sub ResetLayout()
            LayoutPanel.SuspendLayout()
            Try
                Dim controlsCollection As Control.ControlCollection = LayoutPanel.Controls
                For n As Integer = controlsCollection.Count - 1 To 0 Step -1
                    If TypeOf controlsCollection(n) Is ICustomControl Then controlsCollection(n).Dispose()
                Next
            Finally
                LayoutPanel.ResumeLayout()
            End Try
        End Sub

        Protected Overridable Sub InitializeControls()
        End Sub

        Protected Overrides ReadOnly Property ShouldCheckDpiScaleFactorBeforeFormShown As Boolean
            Get
                Return False
            End Get
        End Property

        Private Shared ReadOnly DeleteKeyWParam As IntPtr = New IntPtr(&H2E)

        Private Shared ReadOnly SysCommandMaximizeWParam As IntPtr = New IntPtr(&HF032)

        Protected Overrides Function ProcessKeyPreview(ByRef msg As Message) As Boolean
            Const WM_KEYUP As Integer = 257
            If msg.Msg = WM_KEYUP AndAlso msg.WParam = DeleteKeyWParam Then
                OnControlDeleteRequest(New ControlEventArgs(Nothing))
            End If

            Return MyBase.ProcessKeyPreview(msg)
        End Function

        Protected Overrides Sub WndProc(ByRef msg As Message)
            Const WM_SYSCOMMAND As Integer = 274
            If msg.Msg = WM_SYSCOMMAND Then
                If msg.WParam = SysCommandMaximizeWParam Then Return
            End If

            MyBase.WndProc(msg)
        End Sub

#Region "Event Handlers"
        Private Sub OnChildControlAdded(ByVal sender As Object, ByVal e As ControlEventArgs)
            AddHandler e.Control.Click, AddressOf OnChildControlMouseClick
        End Sub

        Private Sub OnChildControlRemoved(ByVal sender As Object, ByVal e As ControlEventArgs)
            RemoveHandler e.Control.Click, AddressOf OnChildControlMouseClick
        End Sub

#End Region
        Private Sub OnChildControlMouseClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim ee As MouseEventArgs = TryCast(e, MouseEventArgs)
            If ee IsNot Nothing AndAlso ee.Button <> MouseButtons.Left Then Return
            OnControlSelectRequest(New ControlEventArgs(CType(sender, Control)))
        End Sub

#Region "Events"
        Public Custom Event ControlSelectRequest As EventHandler(Of ControlEventArgs)
            AddHandler(ByVal value As EventHandler(Of ControlEventArgs))
                Events.AddHandler(controlSelectRequestEventKey, value)
            End AddHandler

            RemoveHandler(ByVal value As EventHandler(Of ControlEventArgs))
                Events.RemoveHandler(controlSelectRequestEventKey, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As ControlEventArgs)
            End RaiseEvent
        End Event

        Public Custom Event ControlDeleteRequest As EventHandler(Of ControlEventArgs)
            AddHandler(ByVal value As EventHandler(Of ControlEventArgs))
                Events.AddHandler(controlDeleteRequestEventKey, value)
            End AddHandler

            RemoveHandler(ByVal value As EventHandler(Of ControlEventArgs))
                Events.RemoveHandler(controlDeleteRequestEventKey, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As ControlEventArgs)
            End RaiseEvent
        End Event

        Private Sub OnControlSelectRequest(ByVal e As ControlEventArgs)
            Dim handler As EventHandler(Of ControlEventArgs) = CType(Events(controlSelectRequestEventKey), EventHandler(Of ControlEventArgs))
            If handler IsNot Nothing Then handler(Me, e)
        End Sub

        Private Sub OnControlDeleteRequest(ByVal e As ControlEventArgs)
            Dim handler As EventHandler(Of ControlEventArgs) = CType(Events(controlDeleteRequestEventKey), EventHandler(Of ControlEventArgs))
            If handler IsNot Nothing Then handler(Me, e)
        End Sub

#End Region
        Public Overridable ReadOnly Property LayoutPanel As XtraLayoutPanelBase
            Get
                Return Nothing
            End Get
        End Property
    End Class
End Namespace
