Imports System.Collections.Generic
Imports DevExpress.Data.Internal
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraPrinting

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class CodeExamples
        Inherits CodeTutorialControlBase

        Public Sub New()
            InitializeComponent()
            Dim assemblyNames As String() = New String() {GetType(PrintingSystemBase).Assembly.FullName, GetType(XtraCharts.ChartControl).Assembly.FullName}
            For Each aName In assemblyNames
                SafeTypeResolver.GetOrLoadAssembly(aName, throwOnError:=True)
            Next
        End Sub

        Protected Overrides ReadOnly Property CurrentExampleLanguage As ExampleLanguage
            Get
                If TutorialControl.GetIsCSCode(GetType(ExcelStyleFilter).Name) Then
                    Return ExampleLanguage.Csharp
                Else
                    Return ExampleLanguage.VB
                End If
            End Get
        End Property

        Protected Overrides Function InitializeHighlightTokens() As List(Of String)
            Dim tokens As List(Of String) = MyBase.InitializeHighlightTokens()
            tokens.AddRange(New String() {"PivotGroupInterval", "PivotArea", "PivotGridField", "DateTime", "DockStyle", "List", "EventHandler", "Dictionary", "Convert", "Size", "Point", "Rectangle", "UserLookAndFeel", "Cursor", "DefaultBoolean", "RectangleF", "SizeF", "FormStartPosition", "XtraForm"})
            Return tokens
        End Function

        Protected Overrides Function InitializeReferences() As List(Of String)
            Dim referenceList As List(Of String) = MyBase.InitializeReferences()
            referenceList.AddRange(New String() {"DevExpress.DemoData" & AssemblyInfo.VSuffix, "DevExpress.BonusSkins" & AssemblyInfo.VSuffix, "DevExpress.XtraBars" & AssemblyInfo.VSuffix, "DevExpress.XtraEditors" & AssemblyInfo.VSuffix, "DevExpress.XtraPivotGrid" & AssemblyInfo.VSuffix, "DevExpress.XtraLayout" & AssemblyInfo.VSuffix, "DevExpress.XtraPrinting" & AssemblyInfo.VSuffix, "DevExpress.Printing" & AssemblyInfo.VSuffix & ".Core", "DevExpress.PivotGrid" & AssemblyInfo.VSuffix & ".Core"})
            Return referenceList
        End Function

        Protected Overrides Sub DoHide()
            MyBase.DoHide()
            TutorialControl.FindPivotGridAndHideCustForm(Me)
        End Sub
    End Class
End Namespace
