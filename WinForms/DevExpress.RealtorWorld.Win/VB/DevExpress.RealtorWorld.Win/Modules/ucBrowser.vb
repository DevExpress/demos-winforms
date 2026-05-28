Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.RealtorWorld.Win

    Public Partial Class ucBrowser
        Inherits BaseModule

        Private url_string As String = "http://www.zillow.com/"

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Overrides ReadOnly Property ModuleCaption As String
            Get
                Return "zillow.com"
            End Get
        End Property

        Public Overrides ReadOnly Property AllowWaitDialog As Boolean
            Get
                Return False
            End Get
        End Property

        Friend Overrides Sub ShowModule(ByVal item As Object)
            If webBrowser1.Url Is Nothing OrElse Not Equals(webBrowser1.Url.AbsoluteUri, url_string) Then
                Call SplashScreenManager.ShowDefaultWaitForm(FindForm(), False, True, False, 0)
                Navigate()
            End If

            MyBase.ShowModule(item)
        End Sub

        Friend Sub Navigate()
            webBrowser1.Navigate(url_string)
        End Sub

        Friend Sub RefreshBrowser()
            webBrowser1.Refresh()
        End Sub

        Private Sub webBrowser1_Navigated(ByVal sender As Object, ByVal e As WebBrowserNavigatedEventArgs)
            SplashScreenManager.CloseForm(False)
        End Sub
    End Class
End Namespace
