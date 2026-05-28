Imports System.Collections.Generic
Imports DevExpress.DXperience.Demos
Imports DevExpress.DXperience.Demos.CodeDemo

Namespace DevExpress.XtraDialogs.Demos

    Public Class CodeTutorialControl
        Inherits DevExpress.DXperience.Demos.CodeDemo.CodeTutorialControlBase

        Public Sub New()
            'load assemblies
            Dim gridAssembly As String = GetType(DevExpress.XtraGrid.GridControl).Assembly.FullName
            Dim coreAssembly As String = GetType(DevExpress.Dialogs.Core.CustomLinkFilterEventArgs).Assembly.FullName
            DevExpress.Data.Internal.SafeTypeResolver.GetOrLoadAssembly(gridAssembly)
            DevExpress.Data.Internal.SafeTypeResolver.GetOrLoadAssembly(coreAssembly)
        End Sub

        '
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
            Return list
        End Function
    End Class
End Namespace
