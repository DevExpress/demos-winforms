Imports System.Collections.Generic
Imports DevExpress.DXperience.Demos
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data

Namespace DevExpress.XtraVerticalGrid.Demos

    Public Partial Class CodeExample
        Inherits CodeTutorialControlBase

        Public Sub New()
            InitializeComponent()
#Region "Load External Assemblies"
            Dim externalAssemblies As String() = New String() {GetType(XtraPrinting.PrintTool).Assembly.FullName, GetType(XtraPrinting.TextBrick).Assembly.FullName, GetType(DevExpress.Drawing.DXFont).Assembly.FullName} ' XtraPrinting
            ' Printing.Core
            ' Drawing
            For Each asmName As String In externalAssemblies
                DevExpress.Data.Internal.SafeTypeResolver.GetOrLoadAssembly(asmName)
            Next
#End Region  ' Load External Assemblies
        End Sub

        Protected Overrides ReadOnly Property CurrentExampleLanguage As ExampleLanguage
            Get
                Return DemoHelper.GetExampleLanguage()
            End Get
        End Property

#Region "HighlightTokens"
        Protected Overrides Function InitializeHighlightTokens() As List(Of String)
            Dim tokens = MyBase.InitializeHighlightTokens()
            tokens.AddRange(DefaultTokens)
            Return tokens
        End Function

        Private ReadOnly Shared DefaultTokens As String() = New String() {}

#End Region  ' HighlightTokens
        Protected Overrides Function InitializeReferences() As List(Of String)
            Dim _references As List(Of String) = MyBase.InitializeReferences()
            _references.AddRange(New String() {"DevExpress.Drawing" & AssemblyInfo.VSuffix, "DevExpress.BonusSkins" & AssemblyInfo.VSuffix, "DevExpress.XtraBars" & AssemblyInfo.VSuffix, "DevExpress.XtraEditors" & AssemblyInfo.VSuffix, "DevExpress.XtraVerticalGrid" & AssemblyInfo.VSuffix, "DevExpress.XtraLayout" & AssemblyInfo.VSuffix, "DevExpress.XtraPrinting" & AssemblyInfo.VSuffix, "DevExpress.Printing" & AssemblyInfo.VSuffix & ".Core", "DevExpress.Sparkline" & AssemblyInfo.VSuffix & ".Core"})
            Return _references
        End Function
    End Class
End Namespace

Namespace DevExpress.XtraVerticalGrid.Demos.CodeExamples

    Public Class SampleDataCS
        Inherits CodeExampleResourceFile

        Const resourcePath As String = "DevExpress.XtraVerticalGrid.Demos.CodeExamples.Resources."

        Public Sub New()
            MyBase.New(GetType(SampleDataCS).Assembly.FullName, resourcePath & "SampleData.cs")
        End Sub

        Private Shared ReadOnly replacementsCore As IDictionary(Of String, String) = New Dictionary(Of String, String) From {{"{TutorialsAssembly}", GetType(SampleData).Assembly.FullName}}

        Public Overrides ReadOnly Property Replacements As IDictionary(Of String, String)
            Get
                Return replacementsCore
            End Get
        End Property
    End Class

    Public Class ImageHelperCS
        Inherits CodeExampleResourceFile

        Const resourcePath As String = "DevExpress.XtraVerticalGrid.Demos.CodeExamples.Resources."

        Public Sub New()
            MyBase.New(GetType(ImageHelperCS).Assembly.FullName, resourcePath & "ImageHelper.cs")
        End Sub

        Private Shared ReadOnly replacementsCore As IDictionary(Of String, String) = New Dictionary(Of String, String) From {{"{TutorialsAssembly}", GetType(SampleData).Assembly.FullName}}

        Public Overrides ReadOnly Property Replacements As IDictionary(Of String, String)
            Get
                Return replacementsCore
            End Get
        End Property
    End Class
End Namespace
