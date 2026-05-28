Imports DevExpress.DXperience.Demos
Imports System

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class Calendar
        Inherits XtraEditors.XtraUserControl

        Public Sub New()
            InitializeComponent()
            dateNavigator1.DateTime = TutorialConstants.Now
            dateNavigator1.CalendarIndent = 10
        End Sub

        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            MyBase.OnResize(e)
            dateNavigator1.CalcBestSize()
        End Sub
    End Class
End Namespace
