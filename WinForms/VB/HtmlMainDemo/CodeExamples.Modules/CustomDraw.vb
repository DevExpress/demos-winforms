Imports System.Collections.Generic
Imports System.Reflection
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data

Namespace DevExpress.HTML.Demos

    Public Partial Class CustomDraw
        Inherits DevExpress.HTML.Demos.CodeTutorialControl

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Protected Overrides Function InitializeHighlightTokens() As List(Of String)
            Dim list = MyBase.InitializeHighlightTokens()
            list.Add("Assets")
            Return list
        End Function
    End Class
End Namespace

Namespace DevExpress.HTML.Demos.CodeExamples

    Public Class SampleDataCS
        Inherits DevExpress.HTML.Demos.CodeExamples.HtmlExampleResourceFile

        Public Sub New()
            MyBase.New(GetType(DevExpress.DXperience.Demos.CodeDemo.Data.SampleData))
        End Sub
    End Class

    Public Class SpaceObjectCS
        Inherits DevExpress.HTML.Demos.CodeExamples.HtmlExampleResourceFile

        Public Sub New()
            MyBase.New(GetType(DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject))
        End Sub
    End Class

    Public MustInherit Class HtmlExampleResourceFile
        Inherits DevExpress.DXperience.Demos.CodeDemo.CodeExampleResourceFile

        Private Shared assemblyName As String = GetType(DevExpress.HTML.Demos.CodeExamples.HtmlExampleResourceFile).Assembly.FullName

        Const resourcePath As String = "DevExpress.HTML.Demos.CodeExamples.Resources."

        Private ReadOnly replacementsCore As System.Collections.Generic.IDictionary(Of String, String)

        Public Overrides ReadOnly Property Replacements As IDictionary(Of String, String)
            Get
                Return Me.replacementsCore
            End Get
        End Property

        Public Sub New(ByVal resourceType As System.Type)
            MyBase.New(DevExpress.HTML.Demos.CodeExamples.HtmlExampleResourceFile.assemblyName, If(DevExpress.DXperience.Demos.DemoHelper.IsCSharp, DevExpress.HTML.Demos.CodeExamples.HtmlExampleResourceFile.resourcePath & resourceType.Name & ".cs", resourceType.Name & ".vb"))
            Me.replacementsCore = New System.Collections.Generic.Dictionary(Of String, String) From {{"{TutorialsAssembly}", resourceType.Assembly.FullName}}
        End Sub
    End Class
End Namespace
