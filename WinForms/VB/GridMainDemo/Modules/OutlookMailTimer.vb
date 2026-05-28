Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraGrid.Demos.Properties
Imports DevExpress.Utils.Svg
Imports DevExpress.Skins
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos

    Public Class MailTimer

        Private list As IList(Of Message)

        Private control As AlertControl

        Private form As Form

        Private delay As Integer = 30000

        Private timer As Timer

        Private ReadOnly rnd As Data.Utils.NonCryptographicRandom

        Public Sub New(ByVal list As IList(Of Message), ByVal control As AlertControl, ByVal form As Form)
            Me.list = list
            Me.control = control
            Me.form = form
            timer = New Timer()
            timer.Interval = 10000
            If MainFormHelper.TakeScreens Then
                rnd = New Data.Utils.NonCryptographicRandom(1)
            Else
                AddHandler timer.Tick, New EventHandler(AddressOf timer_Tick)
                rnd = Data.Utils.NonCryptographicRandom.Default
            End If
        End Sub

        Private svgMailWithAttach As SvgBitmap = New SvgBitmap(Resources.MailWithAttach)

        Private svgMail As SvgBitmap = New SvgBitmap(Resources.Mail)

        Private Function GetMailImage(ByVal data As Integer, ByVal skinProvider As ISkinProvider) As Image
            If 0.Equals(data) Then Return svgMail.Render(SvgPaletteHelper.GetElementSvgPalette(skinProvider, "Normal", SkinProductId.Bars, BarSkins.SkinAlertWindow))
            Return svgMailWithAttach.Render(SvgPaletteHelper.GetElementSvgPalette(skinProvider, "Normal", SkinProductId.Bars, BarSkins.SkinAlertWindow))
        End Function

        Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Dim timer As Timer = TryCast(sender, Timer)
            If list.Count > 0 Then
                Dim message As Message = list(rnd.Next(list.Count - 1))
                ShowAlert(message)
            End If

            If timer.Interval < delay Then timer.Interval = delay
        End Sub

        Public Sub ShowAlert(ByVal message As Message)
            InitButtonsStyle(message)
            control.Show(form, message.From, message.Subject, Nothing, GetMailImage(message.Attachment, control.LookAndFeel), message)
        End Sub

        Private Sub InitButtonsStyle(ByVal message As Message)
            control.Buttons("Read").Down = 1.Equals(message.Read)
            control.Buttons("Attachment").Visible = 1.Equals(message.Attachment)
        End Sub

        Friend Sub Start()
            timer.Start()
        End Sub

        Friend Sub [Stop]()
            timer.Stop()
        End Sub
    End Class
End Namespace
