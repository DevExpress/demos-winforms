Namespace DevExpress.MVVM.Demos.TodoApp
    Public Class TodoAppModule
        Inherits TutorialControl
        Private todoAppForm As Form
        Public Sub New()
            todoAppForm = New Global.TodoApp.MainView()
            Tutorials.TodoApp.PresentationHelper.CenterParent(Me, todoAppForm, True)
        End Sub
        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            If todoAppForm IsNot Nothing AndAlso Not todoAppForm.Visible Then todoAppForm.Show()
        End Sub
        Protected Overrides Sub DoHide()
            If todoAppForm IsNot Nothing AndAlso todoAppForm.Visible Then todoAppForm.Hide()
            MyBase.DoHide()
        End Sub
    End Class
End Namespace
