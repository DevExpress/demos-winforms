Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Utils.Extensions

Namespace DevExpress.WindowsMailClient.Win.Controls

    Public Class VerticalTopFlyoutPanel
        Inherits FlyoutPanel

        Protected Overrides Function CreateToolFormCore(ByVal owner As Control, ByVal content As FlyoutPanel, ByVal options As FlyoutPanelOptions) As FlyoutPanelToolForm
            Return New VerticalTopFlyoutPanelToolForm(owner, content, options)
        End Function
    End Class

    Public Class VerticalTopFlyoutPanelToolForm
        Inherits FlyoutPanelToolForm

        Public Sub New(ByVal owner As Control, ByVal flyoutPanel As FlyoutPanel, ByVal options As FlyoutPanelOptions)
            MyBase.New(owner, flyoutPanel, options)
        End Sub

        Protected Overrides Sub CheckToolWindowLocation()
            If TypeOf OwnerForm Is MainForm Then
                If CType(OwnerForm, MainForm).ExtendNavigationControlToFormTitleInternal Then
                    If AnimationProvider Is Nothing OrElse IsOwnerOrItselfDisposed Then Return
                    Dim loc As Point = AnimationProvider.CalcTargetFormLocation()
                    Dim borderSize As Integer = Owner.GetBorderSize()
                    loc.Y = Owner.Bounds.Y + borderSize
                    If Location <> loc Then
                        Location = loc
                    End If

                    Dim _size As Size = AnimationProvider.CalcTargetFormSize()
                    _size.Height = Owner.Bounds.Height - 2 * borderSize
                    If Size <> _size Then
                        Size = _size
                    End If
                Else
                    MyBase.CheckToolWindowLocation()
                End If
            End If
        End Sub
    End Class
End Namespace
