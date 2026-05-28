Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.DXperience.Demos.CodeDemo

Namespace DevExpress.MVVM.Demos
    Public Class DemosInfo
        Inherits ModulesInfo
        Public Shared Sub ShowDemoModule(ByVal name As String, ByVal group As DevExpress.XtraEditors.GroupControl, ByVal manager As RibbonMenuManager)
            Dim item As ModuleInfo = DemosInfo.GetItem(name)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            Try
                Dim oldTutorial As Control = Nothing
                If Instance.CurrentModuleBase IsNot Nothing Then
                    If Instance.CurrentModuleBase.Name = name Then
                        Return
                    End If
                    oldTutorial = Instance.CurrentModuleBase.TModule
                End If
                Dim ctc As CodeTutorialControlBase = TryCast(item.TModule, CodeTutorialControlBase)
                If (ctc IsNot Nothing) Then
                    ctc.SelectExampleByName(item.CodeExampleName)
                End If
                Dim tutorial As TutorialControlBase = TryCast(item.TModule, TutorialControlBase)
                tutorial.Bounds = group.DisplayRectangle
                Instance.CurrentModuleBase = item
                tutorial.Visible = False
                group.Controls.Add(tutorial)
                tutorial.Dock = DockStyle.Fill
                tutorial.RibbonMenuManager = manager
                tutorial.TutorialName = name
                tutorial.Visible = True
                item.WasShown = True
                If oldTutorial IsNot Nothing Then
                    oldTutorial.Visible = False
                End If
            Finally
                Cursor.Current = currentCursor
            End Try
            RaiseModuleChanged()
        End Sub
        Public Shared Function GetLoremIpsumText(ByVal seed As Integer) As String
            Return String.Format("{0} {1}", texts(seed Mod texts.Length), texts((seed + 2) Mod texts.Length))
        End Function
        Private Shared texts() As String = {"Vestibulum sem nunc, cursus sit amet placerat id, scelerisque at tortor. Nullam sit amet felis eros, ac imperdiet quam. Aliquam eu ipsum dui.", "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Curabitur sit amet sapien metus, eget pharetra velit.", "Duis sagittis iaculis nisl, sit amet ultricies lectus porttitor nec. Suspendisse id venenatis sem. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.", "Aliquam erat volutpat. Ut sit amet purus. Nullam a lectus. Duis in elit. Ut nonummy est pellentesque eros. Sed ultrices convallis nulla. Phasellus urna lorem, mattis a, luctus congue, dictum in, nunc."}
    End Class
    '
    Public Class TutorialControl
        Inherits TutorialControlBase

        Public Sub New()
            Me.Padding = New Padding(5, 0, 0, 5)
        End Sub
        Protected Sub LoadSourceCode(ByVal sourceCode As DevExpress.DXperience.Demos.CodeDemo.RichEditUserControl, ByVal methodName As String, Optional ByVal moduleType As System.Type = Nothing, Optional ByVal append As Boolean = False)
            AddHandler sourceCode.richEditControl.InitializeDocument, Sub(s, e) sourceCode.InitializeSyntaxHighlight(DXperience.Demos.CodeDemo.ExampleLanguage.VB)
            Dim code As String = DevExpress.DXperience.Demos.CodeDemo.CodeTutorialControlBase.GetModuleMethodCode(If(moduleType, Me.GetType()), methodName)
            sourceCode.RichText = If(append, sourceCode.RichText & System.Environment.NewLine & code, code)
            sourceCode.richEditControl.ReadOnly = True
        End Sub
    End Class
    Public Class CodeTutorialControl
        Inherits CodeTutorialControlBase
        Protected Overrides ReadOnly Property CurrentExampleLanguage As ExampleLanguage
            Get
                Return DemoHelper.GetExampleLanguage()
            End Get
        End Property
        Protected Overrides Function InitializeHighlightTokens() As List(Of String)
            Return New List(Of String)() From {
                "ISupportInitialize",
                "Environment",
                "XtraForm",
                "XtraUserControl",
                "FormShowMode",
                "Container",
                "IContainer",
                "ComponentResourceManager",
                "Padding",
                "AutoScaleMode",
                "FormBorderStyle",
                "FormStartPosition",
                "Point",
                "Size",
                "SizeF",
                "BindingSource",
                "Binding",
                "DataSourceUpdateMode",
                "IDataErrorInfo",
                "FormatException",
                "IList",
                "Assets",
                "MVVMContext",
                "ViewModelSource",
                "IDispatcherService",
                "IMessageBoxService",
                "IDialogService",
                "IDocumentManagerService",
                "INavigationService",
                "IDocument",
                "TablePanelColumn",
                "TablePanelRow",
                "TableColumnDefinition",
                "TableRowDefinition",
                "TableSpan",
                "ItemTemplateBase",
                "SimpleContextButton",
                "ListBoxControl",
                "SearchControl",
                "ToggleSwitch",
                "TablePanel",
                "ContextItemPanel",
                "ContextItemPosition",
                "DockStyle",
                "TablePanelEntityStyle",
                "TableDefinitionLengthType",
                "TileItemContentAlignment",
                "DXSkinColors",
                "TileItemImageScaleMode",
                "ListBoxControlContextButtonCustomizeEventHandler",
                "ListBoxControlContextButtonCustomizeEventArgs",
                "CustomizeTemplatedItemEventHandler",
                "CustomizeTemplatedItemEventArgs",
                "EditorButton",
                "ClearButton",
                "SearchButton",
                "VertAlignment",
                "LabelAutoSizeMode",
                "PaintStyles",
                "TemplatedItemElement",
                "ISupportParameter",
                "ServiceContainer"
            }
        End Function
        Protected Overrides ReadOnly Property UseSameTutorialControlNameForGenerateExample As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace

Namespace DevExpress.MVVM.Demos.CodeExamples
    Public Class TodoAppDescription
        Inherits CodeExampleResourceFile
        Public Sub New(ByVal fileName As String)
            MyBase.New(GetType(TodoAppDescription).Assembly.FullName, GetResourceName(fileName))
            MyBase.Name = "[Description]"
        End Sub
        Const resourcePath As String = "DevExpress.MVVM.Demos.Resources.TodoApp.Descriptions."
        Shared Function GetResourceName(ByVal fileName As String) As String
            Return (If(DemoHelper.IsCSharp, resourcePath, String.Empty)) & fileName & ".md"
        End Function
        Private f_Replacements As Dictionary(Of String, String)
        Public Overrides ReadOnly Property Replacements As IDictionary(Of String, String)
            Get
                If MyBase.CodeExample Is Nothing Then Return Nothing
                If Me.f_Replacements Is Nothing Then
                    Me.f_Replacements = New Dictionary(Of String, String) From {
                        {"$CodeExampleName$", MyBase.CodeExample.Name},
                        {"$CodeExampleGroupName$", MyBase.CodeExample.GroupName}
                    }
                End If
                Return Me.f_Replacements
            End Get
        End Property
    End Class
End Namespace
