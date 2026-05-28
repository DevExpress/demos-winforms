Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.HTML.Demos

    Public Class CodeTutorialControl
        Inherits DevExpress.DXperience.Demos.CodeDemo.CodeTutorialControlBase

        Protected Overrides ReadOnly Property CurrentExampleLanguage As ExampleLanguage
            Get
                Return DevExpress.DXperience.Demos.DemoHelper.GetExampleLanguage()
            End Get
        End Property

        Protected Overrides ReadOnly Property UseSameTutorialControlNameForGenerateExample As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides Function InitializeHighlightTokens() As List(Of String)
            Dim list = MyBase.InitializeHighlightTokens()
            list.Add("XtraForm")
            list.Add("XtraUserControl")
            list.Add("Loader")
            list.Add("DxHtmlElementMouseEventArgs")
            Return list
        End Function
    End Class
End Namespace
