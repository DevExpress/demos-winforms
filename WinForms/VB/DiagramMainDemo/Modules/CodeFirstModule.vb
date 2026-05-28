Imports DevExpress.DXperience.Demos
Imports DevExpress.DXperience.Demos.CodeDemo

Namespace DevExpress.XtraDiagram.Demos

    Public Class CodeFirstModule
        Inherits CodeTutorialControlBase

        Shared Sub New()
            Using New DiagramControl()
            End Using
        End Sub

        Protected Overrides ReadOnly Property CurrentExampleLanguage As ExampleLanguage
            Get
                Return If(Equals(DemoHelper.GetLanguageString(GetType(CodeFirstModule).Assembly), "CS"), ExampleLanguage.Csharp, ExampleLanguage.VB)
            End Get
        End Property

        Protected Overrides ReadOnly Property FileNamesForModule As String()
            Get
                Return {"GenericExamples.cs"}
            End Get
        End Property
    End Class
End Namespace
