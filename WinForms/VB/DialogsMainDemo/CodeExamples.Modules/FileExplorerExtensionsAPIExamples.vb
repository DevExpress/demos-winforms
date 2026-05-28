Imports System.Collections.Generic
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data

Namespace DevExpress.XtraDialogs.Demos

    Public Partial Class FileExplorerExtensionsAPIExamples
        Inherits DevExpress.XtraDialogs.Demos.CodeTutorialControl

        Shared Sub New()
            If DevExpress.XtraGrid.GridControl.AutoFilterRowHandle < 0 AndAlso DevExpress.XtraTreeList.TreeList.AutoFilterNodeId < 0 Then DevExpress.XtraEditors.Base.XtraCommonDialog.ForceInitialize()
        End Sub

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Protected Overrides Function InitializeHighlightTokens() As List(Of String)
            Dim list = MyBase.InitializeHighlightTokens()
            list.Add("GridControlExtension")
            list.Add("TreeListExtension")
            list.Add("BreadCrumbExtension")
            list.Add("Environment")
            list.Add("EnvironmentSpecialFolderNode")
            list.Add("VirtualFolderNode")
            list.Add("VirtualItemNode")
            list.Add("PathNode")
            list.Add(NameOf(DevExpress.XtraDialogs.NavigationBinding))
            list.Add(NameOf(DevExpress.DXperience.Demos.CodeDemo.Data.SvgPreviewHandler))
            list.Add(NameOf(DevExpress.XtraEditors.Base.Controls.Preview.WinPreviewHandlerBase))
            Return list
        End Function
    End Class
End Namespace

Namespace DevExpress.XtraDialogs.Demos.CodeExamples

    Public Class SvgPreviewHandlerCS
        Inherits DevExpress.DXperience.Demos.CodeDemo.CodeExampleResourceFile

        Public Sub New()
            MyBase.New(GetType(DevExpress.XtraDialogs.Demos.CodeExamples.SvgPreviewHandlerCS).Assembly.FullName, DevExpress.XtraDialogs.Demos.CodeExamples.SvgPreviewHandlerCS.GetResourceName())
        End Sub

        Private Shared Function GetResourceName() As String
            Return If(DevExpress.DXperience.Demos.DemoHelper.IsCSharp, "DevExpress.XtraDialogs.Demos.CodeExamples.SvgPreviewHandler.cs", "SvgPreviewHandler.vb")
        End Function

        Private Shared ReadOnly replacementsCore As System.Collections.Generic.IDictionary(Of String, String) = New System.Collections.Generic.Dictionary(Of String, String) From {{"{TutorialsAssembly}", GetType(DevExpress.DXperience.Demos.CodeDemo.Data.SampleData).Assembly.FullName}}

        Public Overrides ReadOnly Property Replacements As IDictionary(Of String, String)
            Get
                Return DevExpress.XtraDialogs.Demos.CodeExamples.SvgPreviewHandlerCS.replacementsCore
            End Get
        End Property
    End Class
End Namespace
