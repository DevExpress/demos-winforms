Imports DevExpress.DXperience.Demos
Imports System
Imports System.Windows.Forms

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class Clock
        Inherits XtraEditors.XtraUserControl

        Private timer As Timer = New Timer()

        Public Sub New()
            InitializeComponent()
            timer.Interval = 1000
            AddHandler timer.Tick, AddressOf OnTick
            timer.Start()
            OnTick(Nothing, Nothing)
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
                DisableTimer()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub DisableTimer()
            If timer IsNot Nothing Then
                RemoveHandler timer.Tick, AddressOf OnTick
                timer.Stop()
                timer.Dispose()
            End If

            timer = Nothing
        End Sub

        Private Sub OnTick(ByVal sender As Object, ByVal e As EventArgs)
            If IsDisposed Then
                DisableTimer()
                Return
            End If

            Dim currentDate = If(MainFormHelper.TakeScreens, TutorialConstants.Now, Date.Now)
            labelControl1.Text = "<b>" & currentDate.ToLongTimeString() & "</b><br><size=10>" & currentDate.ToLongDateString()
        End Sub
    End Class
End Namespace
