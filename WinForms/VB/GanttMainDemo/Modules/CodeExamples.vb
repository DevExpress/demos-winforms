Imports System.Collections.Generic
Imports DevExpress.DXperience.Demos
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data

Namespace DevExpress.XtraGantt.Demos

    Public Partial Class CodeExamples
        Inherits CodeTutorialControlBase

#Region "static"
        'typeof(IFormatRuleBase).Assembly.FullName 
        Private ReadOnly Shared externalAssemblies As String() = New String() {}

        Shared Sub New()
            For Each asmName In externalAssemblies
                DevExpress.Data.Internal.SafeTypeResolver.GetOrLoadAssembly(asmName)
            Next
        End Sub

#End Region  ' static
        Public Sub New()
            InitializeComponent()
        End Sub

#Region "HighlightTokens"
        Protected Overrides Function InitializeHighlightTokens() As List(Of String)
            Dim tokens = MyBase.InitializeHighlightTokens()
            tokens.AddRange(DefaultTokens)
            Return tokens
        End Function

        Private ReadOnly Shared DefaultTokens As String() = New String() {"Task", "HashSet", "TimeSpan", "RectangleF", "TreeList", "GanttControl", "TreeListColumn", "GanttTimescaleColumn", "TreeListNode", "GanttControlNode", "TreeListBand", "TreeListHitInfo", "TreeListLocalizer", "TreeListStringId", "TreeListMenuType", "TreeListMultiSelectMode", "Action", "StringFormat", "StringAlignment", "RepositoryItem", "RepositoryItemSpinEdit", "RepositoryItemProgressBar", "RepositoryItemCalcEdit"}

#End Region  ' HighlightTokens
        Protected Overrides Function InitializeReferences() As List(Of String)
            Dim _references As List(Of String) = MyBase.InitializeReferences()
            _references.AddRange(New String() {"DevExpress.BonusSkins" & AssemblyInfo.VSuffix, "DevExpress.XtraBars" & AssemblyInfo.VSuffix, "DevExpress.XtraGantt" & AssemblyInfo.VSuffix, "DevExpress.XtraEditors" & AssemblyInfo.VSuffix, "DevExpress.XtraTreeList" & AssemblyInfo.VSuffix, "DevExpress.XtraGrid" & AssemblyInfo.VSuffix, "DevExpress.XtraLayout" & AssemblyInfo.VSuffix, "DevExpress.XtraPrinting" & AssemblyInfo.VSuffix, "DevExpress.Printing" & AssemblyInfo.VSuffix & ".Core", "DevExpress.Sparkline" & AssemblyInfo.VSuffix & ".Core"})
            Return _references
        End Function

        Protected Overrides ReadOnly Property CurrentExampleLanguage As ExampleLanguage
            Get
                Return DemoHelper.GetExampleLanguage()
            End Get
        End Property
    End Class
End Namespace

Namespace Examples

    Public Class TaskCS
        Inherits CodeExampleResourceFile

        Const resourcePath As String = "DevExpress.XtraGantt.Demos.CodeExamples.Resources."

        Public Sub New()
            MyBase.New(GetType(TaskCS).Assembly.FullName, If(DemoHelper.IsCSharp, resourcePath & "Task.cs", "Task.vb"))
        End Sub

        Private Shared ReadOnly replacementsCore As IDictionary(Of String, String) = New Dictionary(Of String, String) From {{"{TutorialsAssembly}", GetType(Task).Assembly.FullName}}

        Public Overrides ReadOnly Property Replacements As IDictionary(Of String, String)
            Get
                Return replacementsCore
            End Get
        End Property
    End Class

    Public Class SplitInfoCS
        Inherits CodeExampleResourceFile

        Const resourcePath As String = "DevExpress.XtraGantt.Demos.CodeExamples.Resources."

        Public Sub New()
            MyBase.New(GetType(SplitInfoCS).Assembly.FullName, If(DemoHelper.IsCSharp, resourcePath & "SplitInfo.cs", "SplitInfo.vb"))
        End Sub

        Private Shared ReadOnly replacementsCore As IDictionary(Of String, String) = New Dictionary(Of String, String) From {{"{TutorialsAssembly}", GetType(SplitInfo).Assembly.FullName}}

        Public Overrides ReadOnly Property Replacements As IDictionary(Of String, String)
            Get
                Return replacementsCore
            End Get
        End Property
    End Class
End Namespace
