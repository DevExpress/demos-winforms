Imports System.Collections.Generic
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data

Namespace DevExpress.XtraGrid.Demos.Modules

    Public Partial Class CodeExample
        Inherits CodeTutorialControlBase

        Public Sub New()
            InitializeComponent()
#Region "Load External Assemblies"
            Dim externalAssemblies As String() = New String() {GetType(XtraPrinting.PrintTool).Assembly.FullName, GetType(XtraPrinting.TextBrick).Assembly.FullName, GetType(DevExpress.Drawing.DXFont).Assembly.FullName} ' XtraPrinting
            ' Printing.Core
            ' Drawing
            For Each asmName As String In externalAssemblies
                Data.Internal.SafeTypeResolver.GetOrLoadAssembly(asmName)
            Next
#End Region  ' Load External Assemblies
        End Sub

        Protected Overrides ReadOnly Property CurrentExampleLanguage As ExampleLanguage
            Get
                Return DXperience.Demos.DemoHelper.GetExampleLanguage()
            End Get
        End Property

        Protected Overrides Function InitializeHighlightTokens() As List(Of String)
            Dim _initializeHighlightTokens As List(Of String) = MyBase.InitializeHighlightTokens()
            _initializeHighlightTokens.AddRange(New String() {"Binding", "GridControl", "GridColumn", "TileViewColumn", "HorzAlignment", "NewItemRowPosition", "DockStyle", "ComboBoxEdit", "RepositoryItemSpinEdit", "RepositoryItemCalcEdit", "ShowButtonModeEnum", "RepositoryItemGridLookUpEdit", "RepositoryItemToggleSwitch", "RepositoryItemButtonEdit", "ButtonPredefines", "GridHitInfo", "DXMenuItem", "List", "EventHandler", "Dictionary", "ControlPaint", "DrawElementInfo", "ObjectPainter", "Brushes", "Brush", "SmoothingMode", "Convert", "Pen", "BinaryOperator", "Font", "Size", "Point", "XtraInputBox", "GridFilterPanelInfoArgs", "SkinGridFilterPanelPainter", "CheckState", "GridGroupSummaryItem", "ImageCollection", "GroupOperator", "CriteriaOperator", "OperandProperty", "OperandValue", "GridEditingMode", "MethodInvoker", "Environment", "ButtonPredefines", "ColumnFilterInfo", "RepositoryItemSpinEdit", "TextEdit", "GridGroupRowInfo", "SeekOrigin", "MemoryStream", "PaddingInfo", "FontStyle", "GridMultiSelectMode", "SummaryItemType", "GridGroupSummaryItem", "CustomSummaryProcess", "UnboundColumnType", "EditFormValidateEditorEventArgs", "ExceptionMode", "Keys", "FormatConditionRuleValue", "GridFormatRule", "FormatConditionRule2ColorScale", "FormatCondition", "Rectangle", "EditorsSkins", "UserLookAndFeel", "Cursor", "DefaultBoolean", "CustomEditForm", "DateEdit", "ImageLocation", "DemoHelper", "EditorButton", "DataSourceUpdateMode", "ShowValueEditorEventHandler", "BinaryOperatorType", "Comparer", "ColumnSortOrder", "ColumnSortMode", "SpinEdit", "RectangleF", "PrintingSystemBase", "TextBrick", "SizeF", "FormStartPosition", "XtraForm", "RepositoryItemCheckEdit"})
            Return _initializeHighlightTokens
        End Function

        Protected Overrides Function InitializeReferences() As List(Of String)
            Dim _references As List(Of String) = MyBase.InitializeReferences()
            _references.AddRange(New String() {"DevExpress.Drawing" & AssemblyInfo.VSuffix, "DevExpress.BonusSkins" & AssemblyInfo.VSuffix, "DevExpress.XtraBars" & AssemblyInfo.VSuffix, "DevExpress.XtraEditors" & AssemblyInfo.VSuffix, "DevExpress.XtraGrid" & AssemblyInfo.VSuffix, "DevExpress.XtraLayout" & AssemblyInfo.VSuffix, "DevExpress.XtraPrinting" & AssemblyInfo.VSuffix, "DevExpress.Printing" & AssemblyInfo.VSuffix & ".Core", "DevExpress.Sparkline" & AssemblyInfo.VSuffix & ".Core"})
            Return _references
        End Function
    End Class
End Namespace

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    Public Class SampleDataCS
        Inherits CodeExampleResourceFile

        Public Sub New()
            MyBase.New(GetType(SampleDataCS).Assembly.FullName, GetResourceName())
        End Sub

        Private Shared Function GetResourceName() As String
            Return If(DXperience.Demos.DemoHelper.IsCSharp, "DevExpress.XtraGrid.Demos.CodeExamples.Resources.SampleData.cs", "SampleData.vb")
        End Function

        Private Shared ReadOnly replacementsCore As IDictionary(Of String, String) = New Dictionary(Of String, String) From {{"{TutorialsAssembly}", GetType(SampleData).Assembly.FullName}}

        Public Overrides ReadOnly Property Replacements As IDictionary(Of String, String)
            Get
                Return replacementsCore
            End Get
        End Property
    End Class

    Public Class LipsumDataCS
        Inherits CodeExampleResourceFile

        Public Sub New()
            MyBase.New(GetType(LipsumDataCS).Assembly.FullName, GetResourceName())
        End Sub

        Private Shared Function GetResourceName() As String
            Return If(DXperience.Demos.DemoHelper.IsCSharp, "DevExpress.XtraGrid.Demos.CodeExamples.Resources.LipsumObject.cs", "LipsumObject.vb")
        End Function

        Private Shared ReadOnly replacementsCore As IDictionary(Of String, String) = New Dictionary(Of String, String) From {{"{TutorialsAssembly}", GetType(LipsumObject).Assembly.FullName}}

        Public Overrides ReadOnly Property Replacements As IDictionary(Of String, String)
            Get
                Return replacementsCore
            End Get
        End Property
    End Class
End Namespace
