Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.HTML.Demos

    Public Partial Class ToolTipViewModule
        Inherits TutorialControlBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Friend Module ToolTipPresentationHelper

        Public Sub CenterParent(ByVal host As ContainerControl, ByVal view As HtmlToolTipWindowBase)
            AddHandler host.Resize, Sub() UpdateViewBounds(host, view)
            AddHandler view.Shown, Sub() UpdateViewBounds(host, view)
            AddHandler view.FormClosing, Sub(ByVal s, ByVal e)
                If e.CloseReason = CloseReason.UserClosing Then
                    e.Cancel = True
                End If
            End Sub
            view.TopLevel = False
            view.Parent = host
            view.Show()
        End Sub

        Public Sub UpdateViewBounds(ByVal host As ContainerControl, ByVal view As HtmlToolTipWindowBase)
            Dim targetRect As Rectangle = host.ClientRectangle
            If view.FormPainter IsNot Nothing Then view.Bounds = PlacementHelper.Arrange(view.FormPainter.CalcToolTipSize(), targetRect, ContentAlignment.MiddleCenter)
        End Sub
    End Module
End Namespace
