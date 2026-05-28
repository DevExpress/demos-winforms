Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.DXperience.Demos
Imports DevExpress.DXperience.Demos.CodeDemo

Namespace DevExpress.HTML.Demos.CodeExamples

    Public Class HtmlFile
        Inherits DevExpress.DXperience.Demos.CodeDemo.CodeExampleResourceFile

        Private ReadOnly allowModifyField As Boolean

        Public Sub New(ByVal fileName As String, ByVal Optional allowModify As Boolean = True)
            MyBase.New(GetType(DevExpress.HTML.Demos.CodeExamples.HtmlFile).Assembly.FullName, DevExpress.HTML.Demos.CodeExamples.HtmlFile.GetResourceName(fileName))
            Me.allowModifyField = allowModify
            Me.Name = "[HTML]"
        End Sub

        Public Sub New(ParamArray fileNames As String())
            MyBase.New(GetType(DevExpress.HTML.Demos.CodeExamples.HtmlFile).Assembly.FullName, String.Empty)
            Dim res As System.Collections.Generic.List(Of String) = New System.Collections.Generic.List(Of String)()
            For Each item In fileNames
                res.Add(DevExpress.HTML.Demos.CodeExamples.HtmlFile.GetResourceName(item))
            Next

            Me.allowModifyField = False
            Me.ResourceNames = res.ToArray()
        End Sub

        Protected Overrides ReadOnly Property AllowModify As Boolean
            Get
                Return Me.allowModifyField
            End Get
        End Property

        Private Shared Function GetResourceName(ByVal fileName As String) As String
            Const resourcePath As String = "DevExpress.HTML.Demos.CodeExamples.html."
            If DevExpress.DXperience.Demos.DemoHelper.IsCSharp Then
                Return resourcePath & fileName & ".html"
            Else
                Return fileName.Split("."c).Last() & ".html"
            End If
        End Function
    End Class
End Namespace
