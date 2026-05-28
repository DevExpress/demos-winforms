Imports DevExpress.DXperience.Demos
Imports DevExpress.DXperience.Demos.CodeDemo

Namespace DevExpress.ApplicationUI.Demos

    Public Class DocumentManagerModule
        Inherits DevExpress.DXperience.Demos.CodeDemo.CodeTutorialControlBase

        Public Sub New()
            MyBase.New()
        End Sub

        Protected Overrides ReadOnly Property FileNamesForModule As String()
            Get
                Return New String() {"CommonConcepts.cs", "TabbedView.cs", "WindowsUIView.cs", "WidgetView.cs"}
            End Get
        End Property

        Protected Overrides ReadOnly Property CurrentExampleLanguage As ExampleLanguage
            Get
                Return DevExpress.DXperience.Demos.DemoHelper.GetExampleLanguage()
            End Get
        End Property

        Protected Overrides ReadOnly Property AllowBorderRounding As Boolean?
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
