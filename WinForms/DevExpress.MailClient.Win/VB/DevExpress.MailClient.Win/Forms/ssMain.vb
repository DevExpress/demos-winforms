Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.MailClient.Win.Forms
    Partial Public Class ssMain
        Inherits DemoSplashScreen

        Private dotCount As Integer = 0
        Public Sub New()
            InitializeComponent()
            labelControl1.Text = String.Format("{0}{1}", labelControl1.Text, GetYearString())
            pictureEdit2.Image = My.Resources.SplashScreen
            Dim tmr As New Timer()
            tmr.Interval = 400
            AddHandler tmr.Tick, AddressOf tmr_Tick
            tmr.Start()
        End Sub

        Private Sub tmr_Tick(ByVal sender As Object, ByVal e As EventArgs)
            dotCount += 1
            If dotCount > 3 Then
                dotCount = 0
            End If
            labelControl2.Text = String.Format("{1}{0}", GetDots(dotCount), My.Resources.Starting)
        End Sub

        Private Function GetDots(ByVal count As Integer) As String
            Dim ret As String = String.Empty
            For i As Integer = 0 To count - 1
                ret &= "."
            Next i
            Return ret
        End Function
        Private Function GetYearString() As Integer
            Dim ret As Integer = Date.Now.Year
            Return (If(ret < 2012, 2012, ret))
        End Function
    End Class
End Namespace
