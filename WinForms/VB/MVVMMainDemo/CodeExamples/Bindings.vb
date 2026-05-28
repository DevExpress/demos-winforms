Imports System
Imports System.Linq
Imports System.Collections.ObjectModel
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.MVVM
Imports DevExpress.MVVM.DataAnnotations
Imports DevExpress.MVVM.POCO
Imports DevExpress.Utils.MVVM
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports System.Linq.Expressions
Imports System.Collections.Generic

Namespace DevExpress.MVVM.Demos.CodeExamples
    <CodeExampleClass("POCO Bindable Properties", "Bindings.vb"), CodeExampleHighlightTokens("MVVMContext", "DataSourceUpdateMode"), CodeExampleUnderlineTokens("SetBinding", "DataBindings")>
    Public NotInheritable Class BindindableProperties
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim editor As New TextEdit()
            editor.Dock = DockStyle.Top
            editor.Properties.NullValuePrompt = "Please, enter the Title here..."
            editor.Properties.NullValuePromptShowForEmptyValue = True

            Dim commandButton As New SimpleButton()
            commandButton.Dock = DockStyle.Top
            commandButton.Text = "Report the Title property value"

            commandButton.Parent = sampleHost
            editor.Parent = sampleHost
            Return New Object() {mvvmContext, editor, commandButton}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Standard Data-Binding", New Type() {GetType(ViewModel)})>
        Public Shared Sub StandardDataBinding(ByVal mvvmContext As MVVMContext, ByVal editor As TextEdit, ByVal commandButton As SimpleButton)
            ' Set type of POCO-ViewModel
            mvvmContext.ViewModelType = GetType(ViewModel)
            Dim viewModel As ViewModel = mvvmContext.GetViewModel(Of ViewModel)()
            ' Data binding for the Title property (via the DataBindings collection)
            editor.DataBindings.Add("EditValue", viewModel, "Title", True, DataSourceUpdateMode.OnPropertyChanged)
            ' UI binding for the Report command
            AddHandler commandButton.Click, Sub(s, e) XtraMessageBox.Show(viewModel.GetTitleAsHumanReadableString())
        End Sub
        <CodeExampleCase("Data-Binding via MVVMContext", New Type() {GetType(ViewModel)})>
        Public Shared Sub SimpleBinding(ByVal mvvmContext As MVVMContext, ByVal editor As TextEdit, ByVal commandButton As SimpleButton)
            ' Set type of POCO-ViewModel
            mvvmContext.ViewModelType = GetType(ViewModel)
            ' Data binding for the Title property (via MVVMContext API)
            mvvmContext.SetBinding(editor, Function(e) e.EditValue, "Title")
            ' UI binding for the Report command
            Dim viewModel As ViewModel = mvvmContext.GetViewModel(Of ViewModel)()
            AddHandler commandButton.Click, Sub(s, e) XtraMessageBox.Show(viewModel.GetTitleAsHumanReadableString())
        End Sub
        <CodeExampleCase("Data-Binding via MVVMContext (Fluent API)", New Type() {GetType(ViewModel)})>
        Public Shared Sub SimpleBindingFluentAPI(ByVal mvvmContext As MVVMContext, ByVal editor As TextEdit, ByVal commandButton As SimpleButton)
            ' Set type of POCO-ViewModel
            mvvmContext.ViewModelType = GetType(ViewModel)
            Dim fluent = mvvmContext.OfType(Of ViewModel)()
            ' Data binding for the Title property
            fluent.SetBinding(editor, Function(e) e.EditValue, Function(x) x.Title)
            ' UI binding for the Report command
            AddHandler commandButton.Click, Sub(s, e) XtraMessageBox.Show(fluent.ViewModel.GetTitleAsHumanReadableString())
        End Sub
        <CodeExampleNestedClass("POCO View Model provides out-of-the-box support of the INotifyPropertyChanged.")>
        Public Class ViewModel
            ' Bindable property will be created from this property.
            Public Overridable Property Title() As String
            ' Just a method for readability
            Public Function GetTitleAsHumanReadableString() As String
                If Title Is Nothing Then
                    Return "(Null)"
                End If
                If Title.Length = 0 Then
                    Return "(Empty)"
                End If
                If String.IsNullOrWhiteSpace(Title) Then
                    Return "(WhiteSpace)"
                End If
                Return Title
            End Function
        End Class
    End Class
    <CodeExampleClass("POCO Dependencies", "Bindings.vb"), CodeExampleHighlightTokens("BindableProperty"), CodeExampleUnderlineTokens("SetBinding", "RaisePropertyChanged")>
    Public NotInheritable Class DependencyProperties
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim editor1 As New TextEdit()
            editor1.Dock = DockStyle.Top
            editor1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            editor1.Properties.Mask.EditMask = "n0"
            editor1.Properties.Mask.UseMaskAsDisplayFormat = True

            Dim editor2 As New TextEdit()
            editor2.Dock = DockStyle.Top
            editor2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            editor2.Properties.Mask.EditMask = "n0"
            editor2.Properties.Mask.UseMaskAsDisplayFormat = True

            Dim resultLabel As New LabelControl()
            resultLabel.Dock = DockStyle.Top
            resultLabel.AutoSizeMode = LabelAutoSizeMode.Vertical

            resultLabel.Parent = sampleHost
            editor1.Parent = sampleHost
            editor2.Parent = sampleHost
            Return New Object() {mvvmContext, editor1, editor2, resultLabel}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Simple dependencies", New Type() {GetType(MultViewModel)})>
        Public Shared Sub SimpleDependencies(ByVal mvvmContext As MVVMContext, ByVal editor1 As TextEdit, ByVal editor2 As TextEdit, ByVal resultLabel As LabelControl)
            ' Set type of POCO-ViewModel
            mvvmContext.ViewModelType = GetType(MultViewModel)
            ' Data binding for the operands
            mvvmContext.SetBinding(editor1, Function(e) e.EditValue, "Operand1")
            mvvmContext.SetBinding(editor2, Function(e) e.EditValue, "Operand2")
            ' Data binding for the result
            mvvmContext.SetBinding(resultLabel, Function(l) l.Text, "ResultText")
        End Sub
        <CodeExampleCase("PropertyChanged notifications", New Type() {GetType(SumViewModel)})>
        Public Shared Sub PropertyChangedNotifications(ByVal mvvmContext As MVVMContext, ByVal editor1 As TextEdit, ByVal editor2 As TextEdit, ByVal resultLabel As LabelControl)
            ' Set type of POCO-ViewModel
            mvvmContext.ViewModelType = GetType(SumViewModel)
            ' Data binding for the operands
            mvvmContext.SetBinding(editor1, Function(e) e.EditValue, "Operand1")
            mvvmContext.SetBinding(editor2, Function(e) e.EditValue, "Operand2")
            ' Data binding for the result
            mvvmContext.SetBinding(resultLabel, Function(l) l.Text, "ResultText")
        End Sub
        <CodeExampleNestedClass("POCO View Model provides out-of-the-box support of the OnXXXChanging/OnXXXChanged callbacks.")>
        Public Class MultViewModel
            Public Sub New()
                Operand1 = 2
                Operand2 = 3
            End Sub
            Public Overridable Property Operand1() As Integer
            Public Overridable Property Operand2() As Integer
            Public Overridable Property Result() As Integer
            Public Overridable Property ResultText() As String
            ' OnChanged callback will be created for the Operand1 property from this method.
            Protected Sub OnOperand1Changed()
                ' Result depends on Operand1
                UpdateResult()
            End Sub
            ' OnChanged callback will be created for the Operand2 property from this method.
            Protected Sub OnOperand2Changed()
                ' Result depends on Operand2
                UpdateResult()
            End Sub
            ' OnChanged callback will be created for the Result property from this method.
            Protected Sub OnResultChanged()
                ' ResultText depends on Result
                UpdateResultText()
            End Sub
            Private Sub UpdateResult()
                Result = Operand1 * Operand2
            End Sub
            Private Sub UpdateResultText()
                ResultText = String.Format("The result of operands multiplication is: {0:n0}", Result)
            End Sub
        End Class
        <CodeExampleNestedClass("POCO View Model supports attributes and extension-methods for different purposes.")>
        Public Class SumViewModel
            Public Sub New()
                Operand1 = 2
                Operand2 = 2
            End Sub
            ' using the BindableProperty attribute
            <BindableProperty(OnPropertyChangedMethodName:="NotifyResultAndResultTextChanged")>
            Public Overridable Property Operand1() As Integer
            ' using the BindableProperty attribute
            <BindableProperty(OnPropertyChangedMethodName:="NotifyResultAndResultTextChanged")>
            Public Overridable Property Operand2() As Integer
            ' We will raise change-notification for this property manually
            Public ReadOnly Property Result() As Integer
                Get
                    Return Operand1 + Operand2
                End Get
            End Property
            ' We will raise change-notification for this property manually
            Public ReadOnly Property ResultText() As String
                Get
                    Return String.Format("The result of operands summarization is: {0:n0}", Result)
                End Get
            End Property
            Protected Sub NotifyResultAndResultTextChanged()
                Me.RaisePropertyChanged(Function(x) x.Result) ' change-notification for the Result
                Me.RaisePropertyChanged(Function(x) x.ResultText) ' change-notification for the ResultText
            End Sub
        End Class
    End Class
    <CodeExampleClass("POCO Meta-Declarations", "Bindings.vb"), CodeExampleHighlightTokens("MetadataType", "Metadata"), CodeExampleUnderlineTokens("SetBinding", "Property")>
    Public NotInheritable Class POCO_MetaDeclarations
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim editor1 As New TextEdit()
            editor1.Dock = DockStyle.Top
            editor1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            editor1.Properties.Mask.EditMask = "n0"
            editor1.Properties.Mask.UseMaskAsDisplayFormat = True

            Dim editor2 As New TextEdit()
            editor2.Dock = DockStyle.Top
            editor2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            editor2.Properties.Mask.EditMask = "n0"
            editor2.Properties.Mask.UseMaskAsDisplayFormat = True

            Dim resultLabel As New LabelControl()
            resultLabel.Dock = DockStyle.Top
            resultLabel.AutoSizeMode = LabelAutoSizeMode.Vertical

            resultLabel.Parent = sampleHost
            editor1.Parent = sampleHost
            editor2.Parent = sampleHost
            Return New Object() {mvvmContext, editor1, editor2, resultLabel}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Bindable Properties and Dependencies", New Type() {GetType(SumViewModel_MetaPOCO)})>
        Public Shared Sub BindableProperties(mvvmContext As MVVMContext, editor1 As TextEdit, editor2 As TextEdit, resultLabel As LabelControl)
            ' Set type of POCO-ViewModel
            mvvmContext.ViewModelType = GetType(SumViewModel_MetaPOCO)
            ' Data binding for the operands
            mvvmContext.SetBinding(editor1, Function(e) e.EditValue, "Operand1")
            mvvmContext.SetBinding(editor2, Function(e) e.EditValue, "Operand2")
            ' Data binding for the result
            mvvmContext.SetBinding(resultLabel, Function(l) l.Text, "ResultText")
        End Sub
        <CodeExampleNestedClass("POCO View Model properties supports Fluent Meta-declarations via Metadata-types.")>
        <System.ComponentModel.DataAnnotations.MetadataType(GetType(SumViewModel_MetaPOCO.Metadata))>
        Public Class SumViewModel_MetaPOCO
            Public Sub New()
                Operand1 = 2
                Operand2 = 2
                Result = 4
            End Sub
            ' This property will be declared as Non-Bindable property via Fluent API
            Public Overridable Property Result() As Integer
            ' This property will be declared as Bindable property via Fluent API
            Public Overridable Property Operand1() As Integer
            ' This property will be declared as Bindable property via Fluent API
            Public Overridable Property Operand2() As Integer
            ' We will raise change-notification for this property manually
            Public ReadOnly Property ResultText() As String
                Get
                    Return String.Format("The result of operands summarization is: {0:n0}", Result)
                End Get
            End Property
            ' We will declare this method as OnChanged callback for the Operand1 and the Operand2 properties
            Protected Sub NotifyResultAndResultTextChanged()
                Result = Operand1 + Operand2
                Me.RaisePropertyChanged(Function(x) x.Result)
                ' change-notification for the Result
                Me.RaisePropertyChanged(Function(x) x.ResultText)
                ' change-notification for the ResultText
            End Sub
            ' Metadata class for the SumViewModel_MetaPOCO
            Public Class Metadata
                Implements IMetadataProvider(Of SumViewModel_MetaPOCO)
                Private Sub IMetadataProvider_BuildMetadata(builder As MetadataBuilder(Of SumViewModel_MetaPOCO)) Implements IMetadataProvider(Of SumViewModel_MetaPOCO).BuildMetadata
                    builder.[Property](Function(x) x.Result).DoNotMakeBindable()
                    builder.[Property](Function(x) x.Operand1).OnPropertyChangedCall(Sub(x) x.NotifyResultAndResultTextChanged())
                    builder.[Property](Function(x) x.Operand2).OnPropertyChangedCall(Sub(x) x.NotifyResultAndResultTextChanged())
                End Sub
            End Class
        End Class
    End Class
    <CodeExampleClass("Collection Bindings", "Bindings.vb"), CodeExampleHighlightTokens("Entity"), CodeExampleUnderlineTokens("SetItemsSourceBinding")>
    Public NotInheritable Class CollectionBindings
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim itemsListBox As New ImageListBoxControl()
            itemsListBox.Dock = DockStyle.Top
            itemsListBox.Parent = sampleHost

            Dim removeButton As New SimpleButton()
            removeButton.Dock = DockStyle.Top
            removeButton.Text = "Remove"
            removeButton.Parent = sampleHost

            Dim addButton As New SimpleButton()
            addButton.Dock = DockStyle.Top
            addButton.Text = "Add"
            addButton.Parent = sampleHost

            Return New Object() {mvvmContext, addButton, removeButton, itemsListBox}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Data-Binding of Items collection", New Type() {GetType(ViewModel), GetType(Entity)})>
        Public Shared Sub CollectionDataBinding(ByVal mvvmContext As MVVMContext, ByVal addButton As SimpleButton, ByVal removeButton As SimpleButton, ByVal listBox As ImageListBoxControl)
            ' Seting the POCO-ViewModel type
            mvvmContext.ViewModelType = GetType(ViewModel)
            Dim fluent = mvvmContext.OfType(Of ViewModel)()
            ' Populating the ListBox with items, generated from the Entites collection
            ' Fluent API:
            'fluent.SetItemsSourceBinding(listBox, Function(lb) lb.Items, Function(x) x.Entities, Function(item, entity) Object.Equals(item.Value, entity), Function(entity) New ImageListBoxItem(entity), Nothing, Sub(item, entity) CType(item, ImageListBoxItem).Description = entity.Text)
            ' Stub for Demo
            fluent.SetItemsSourceBinding(listBox, CType(Function(lb) lb.Items, Expression(Of Func(Of ImageListBoxControl, IEnumerable(Of ImageListBoxItem)))), CType(Function(x) x.Entities, Expression(Of Func(Of ViewModel, IEnumerable(Of Entity)))), CType(Function(item, entity) Object.Equals(item.Value, entity), Func(Of ImageListBoxItem, Entity, Boolean)), CType(Function(entity) New ImageListBoxItem(entity), Func(Of Entity, ImageListBoxItem)), Nothing, CType(Sub(item, entity) CType(item, ImageListBoxItem).Description = entity.Text, Action(Of ImageListBoxItem, Entity)))
            ' Binding the SelectedValue property to the currently selected entity
            fluent.SetBinding(listBox, Function(lb) lb.SelectedValue, Function(x) x.SelectedEntity)
            ' Command bindings
            ' Fluent API:
            fluent.BindCommand(addButton, Sub(x) x.Add())
            fluent.BindCommand(removeButton, Sub(x) x.Remove())
        End Sub
        <CodeExampleNestedClass>
        Public Class ViewModel
            Public Sub New()
                Entities = New ObservableCollection(Of Entity)()
                Entities.Add(New Entity(0))
                Entities.Add(New Entity(1))
            End Sub
            Public Overridable Property SelectedEntity() As Entity
            Public Overridable Property Entities() As ObservableCollection(Of Entity)
            Protected Sub OnSelectedEntityChanged()
                Me.RaiseCanExecuteChanged(Sub(x) x.Remove())
            End Sub
            Protected Sub OnEntitiesChanged()
                SelectedEntity = Entities.FirstOrDefault()
            End Sub
            ' Add a new item
            Public Sub Add()
                Entities.Add(New Entity(Entities.Count))
            End Sub
            ' Remove the selected item
            Public Sub Remove()
                Entities.Remove(SelectedEntity)
            End Sub
            Public Function CanRemove() As Boolean
                Return SelectedEntity IsNot Nothing
            End Function
        End Class
        <CodeExampleNestedClass>
        Public Class Entity
            Public Sub New(ByVal id As Integer)
                Me.ID = id
                Me.Text = "Entity " & id.ToString()
            End Sub
            Public Property ID() As Integer
            Public Property Text() As String
        End Class
    End Class
    <CodeExampleClass("UI Triggers", "Bindings.vb"), CodeExampleUnderlineTokens("SetTrigger")>
    Public NotInheritable Class UITriggers
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim checkEdit As New CheckEdit()
            checkEdit.Dock = DockStyle.Top
            checkEdit.Text = "IsActive"

            Dim label As New LabelControl()
            label.Dock = DockStyle.Top
            label.AutoSizeMode = LabelAutoSizeMode.Vertical
            label.Text = "Inactive"

            label.Parent = sampleHost
            checkEdit.Parent = sampleHost
            Return New Object() {mvvmContext, checkEdit, label}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Simple UI Trigger", New Type() {GetType(UIViewModel)})>
        Public Shared Sub SimpleTrigger(ByVal mvvmContext As MVVMContext, ByVal checkEdit As CheckEdit, ByVal label As LabelControl)
            ' Set type of POCO-ViewModel
            mvvmContext.ViewModelType = GetType(UIViewModel)
            ' Data binding for the IsActive property
            mvvmContext.SetBinding(Of CheckEdit, UIViewModel, Boolean)(checkEdit, Function(c) c.Checked, Function(x) x.IsActive)
            ' Property-change Trigger for the IsActive property
            mvvmContext.SetTrigger(Of UIViewModel, Boolean)(Function(x) x.IsActive, Sub(active) label.Text = If(active, "Active", "Inactive"))
        End Sub
        <CodeExampleCase("Simple UI Trigger (Fluent API)", New Type() {GetType(UIViewModel)})>
        Public Shared Sub SimpleTriggerFluentAPI(ByVal mvvmContext As MVVMContext, ByVal checkEdit As CheckEdit, ByVal label As LabelControl)
            ' Set type of POCO-ViewModel
            mvvmContext.ViewModelType = GetType(UIViewModel)
            Dim fluent = mvvmContext.OfType(Of UIViewModel)()
            ' Data binding for the IsActive property
            fluent.SetBinding(checkEdit, Function(c) c.Checked, Function(x) x.IsActive)
            ' Property-change Trigger for the IsActive property
            ' Fluent API: fluent.SetTrigger(Function(x) x.IsActive, Sub(active) label.Text = If(active, "Active", "Inactive"))
            ' Stub for Demo
            fluent.SetTrigger(CType(Function(x) x.IsActive, Expression(Of Func(Of UIViewModel, Boolean))), CType(Sub(active) label.Text = If(active, "Active", "Inactive"), Action(Of Boolean)))
        End Sub
        <CodeExampleNestedClass("We will track the IsActive property changing in UI")>
        Public Class UIViewModel
            Public Overridable Property IsActive() As Boolean
        End Class
    End Class
    <CodeExampleClass("Binding to Legacy ViewModels", "Bindings.vb"), CodeExampleUnderlineTokens("SetViewModel")>
    Public NotInheritable Class LegacyViewModels
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim editor As New TextEdit()
            editor.Dock = DockStyle.Top
            editor.Properties.NullValuePrompt = "Please, enter the Title here..."
            editor.Properties.NullValuePromptShowForEmptyValue = True

            Dim commandButton As New SimpleButton()
            commandButton.Dock = DockStyle.Top
            commandButton.Text = "Report the Title property value"

            commandButton.Parent = sampleHost
            editor.Parent = sampleHost
            Return New Object() {mvvmContext, editor, commandButton}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Data-Binding via MVVMContext", New Type() {GetType(LegacyViewModel)})>
        Public Shared Sub SimpleBinding(ByVal mvvmContext As MVVMContext, ByVal editor As TextEdit, ByVal commandButton As SimpleButton)
            Dim legacyViewModel = New LegacyViewModel("Legacy ViewModel")
            ' initialize the MVVMContext with the specific ViewModel's instance
            mvvmContext.SetViewModel(GetType(LegacyViewModel), legacyViewModel)
            ' Data binding for the Title property (via MVVMContext API)
            mvvmContext.SetBinding(editor, Function(e) e.EditValue, "Title")
            ' UI binding for the Report command
            AddHandler commandButton.Click, Sub(s, e) XtraMessageBox.Show(legacyViewModel.Title)
        End Sub
        <CodeExampleCase("Data-Binding via MVVMContext (Fluent API)", New Type() {GetType(LegacyViewModel)})>
        Public Shared Sub SimpleBindingFluentAPI(ByVal mvvmContext As MVVMContext, ByVal editor As TextEdit, ByVal commandButton As SimpleButton)
            Dim legacyViewModel = New LegacyViewModel("Legacy ViewModel")
            ' initialize the MVVMContext with the specific ViewModel's instance
            mvvmContext.SetViewModel(GetType(LegacyViewModel), legacyViewModel)
            Dim fluent = mvvmContext.OfType(Of LegacyViewModel)()
            ' Data binding for the Title property
            fluent.SetBinding(editor, Function(e) e.EditValue, Function(x) x.Title)
            ' UI binding for the Report command
            AddHandler commandButton.Click, Sub(s, e) XtraMessageBox.Show(legacyViewModel.Title)
        End Sub
        <CodeExampleNestedClass>
        Public Class LegacyViewModel
            Private titleCore As String
            Public Sub New(ByVal title As String)
                Me.titleCore = title
            End Sub
            Public Overridable Property Title() As String
                Get
                    Return titleCore
                End Get
                Set(ByVal value As String)
                    If titleCore = value Then
                        Return
                    End If
                    titleCore = value
                    OnTitleChanged()
                End Set
            End Property
            Private Sub OnTitleChanged()
                Dim h As EventHandler = TitleChangedEvent
                If h IsNot Nothing Then
                    h(Me, EventArgs.Empty)
                End If
            End Sub
            Public Event TitleChanged As EventHandler
        End Class
    End Class
    <CodeExampleClass("Data-Binding Capabilities (Binding Path)", "Bindings.vb"), CodeExampleHighlightTokens("ViewModelSource"), CodeExampleUnderlineTokens("SetBinding")>
    Public NotInheritable Class BindingFeatures_Path
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim editor As New TextEdit()
            editor.Dock = DockStyle.Top
            editor.Properties.NullValuePrompt = "Please, enter the Title here..."
            editor.Properties.NullValuePromptShowForEmptyValue = True

            Dim commandButton As New SimpleButton()
            commandButton.Dock = DockStyle.Top
            commandButton.Text = "Report the Title property value"

            commandButton.Parent = sampleHost
            editor.Parent = sampleHost
            Return New Object() {mvvmContext, editor, commandButton}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Data-Binding to Nested Properties", New Type() {GetType(ViewModel), GetType(NestedViewModel)})>
        Public Shared Sub NestedBinding(ByVal mvvmContext As MVVMContext, ByVal editor As TextEdit, ByVal commandButton As SimpleButton)
            ' Set type of POCO-ViewModel
            mvvmContext.ViewModelType = GetType(ViewModel)
            ' Data binding for the Title property of nested ViewModel  (via MVVMContext API)
            mvvmContext.SetBinding(editor, Function(e) e.EditValue, "Child.Title")
            ' UI binding for the Report command
            Dim viewModel As ViewModel = mvvmContext.GetViewModel(Of ViewModel)()
            AddHandler commandButton.Click, Sub(s, e) XtraMessageBox.Show(viewModel.GetChildTitleAsHumanReadableString())
        End Sub
        <CodeExampleCase("Data-Binding to Nested Properties (Fluent API)", New Type() {GetType(ViewModel), GetType(NestedViewModel)})>
        Public Shared Sub NestedBindingFluentAPI(ByVal mvvmContext As MVVMContext, ByVal editor As TextEdit, ByVal commandButton As SimpleButton)
            ' Set type of POCO-ViewModel
            mvvmContext.ViewModelType = GetType(ViewModel)
            Dim fluent = mvvmContext.OfType(Of ViewModel)()
            ' Data binding for the Title property of nested ViewModel
            fluent.SetBinding(editor, Function(e) e.EditValue, Function(x) x.Child.Title)
            ' UI binding for the Report command
            Dim viewModel As ViewModel = mvvmContext.GetViewModel(Of ViewModel)()
            AddHandler commandButton.Click, Sub(s, e) XtraMessageBox.Show(viewModel.GetChildTitleAsHumanReadableString())
        End Sub
        <CodeExampleNestedClass>
        Public Class ViewModel
            Public Sub New()
                ' Create Nested ViewModel as POCO-ViewModel
                Child = ViewModelSource.Create(Of NestedViewModel)()
            End Sub
            ' Nested ViewModel
            Public Overridable Property Child() As NestedViewModel
            ' Just a method for readability
            Public Function GetChildTitleAsHumanReadableString() As String
                If Child.Title Is Nothing Then
                    Return "Child.Title is (Null)"
                End If
                If Child.Title.Length = 0 Then
                    Return "Child.Title is (Empty)"
                End If
                If String.IsNullOrWhiteSpace(Child.Title) Then
                    Return "Child.Title is (WhiteSpace)"
                End If
                Return "Child.Title = " & Child.Title
            End Function
        End Class
        <CodeExampleNestedClass>
        Public Class NestedViewModel
            Public Overridable Property Title() As String
        End Class
    End Class
    <CodeExampleClass("Data-Binding Capabilities (Converters)", "Bindings.vb"), CodeExampleUnderlineTokens("SetBinding")>
    Public NotInheritable Class BindingFeatures_Converters
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim trackBar As New TrackBarControl()
            trackBar.Dock = DockStyle.Top
            trackBar.Properties.Minimum = 0
            trackBar.Properties.Maximum = 100

            Dim editor As New TextEdit()
            editor.Dock = DockStyle.Top
            editor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            editor.Properties.Mask.EditMask = "N0"
            editor.Properties.Mask.UseMaskAsDisplayFormat = True

            editor.Parent = sampleHost
            trackBar.Parent = sampleHost
            Return New Object() {mvvmContext, trackBar, editor}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Data-Binding via Default Converters (Fluent API)", New Type() {GetType(ViewModel)})>
        Public Shared Sub ConvertBindingFluentAPI_DefaultConverter(ByVal mvvmContext As MVVMContext, ByVal trackBar As TrackBarControl, ByVal editor As TextEdit)
            ' Set type of POCO-ViewModel
            mvvmContext.ViewModelType = GetType(ViewModel)
            ' Data binding for the Progress property (via MVVMContext fluent)
            Dim fluent = mvvmContext.OfType(Of ViewModel)()
            ' Binding two integer properties - 'Value' and 'Progress'. No conversion needed
            fluent.SetBinding(trackBar, Function(t) t.Value, Function(x) x.Progress)
            ' Binding the string 'Text' property to the integer 'Progress'. Values are automatically converted to/from an appropriate type.
            fluent.SetBinding(editor, Function(e) e.Text, Function(x) x.Progress)
        End Sub
        <CodeExampleNestedClass>
        Public Class ViewModel
            Public Overridable Property Progress() As Integer
        End Class
    End Class
    <CodeExampleClass("Data-Binding Capabilities (Converters)", "Bindings.vb"), CodeExampleHighlightTokens("State", "CheckState"), CodeExampleUnderlineTokens("SetBinding")>
    Public NotInheritable Class BindingFeatures_BackConverter
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim check As New CheckEdit()
            check.Dock = DockStyle.Top
            check.Properties.AllowGrayed = True

            Dim commandButton As New SimpleButton()
            commandButton.Dock = DockStyle.Top
            commandButton.Text = "Report the ModelState property value"

            check.Parent = sampleHost
            commandButton.Parent = sampleHost
            Return New Object() {mvvmContext, check, commandButton}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Data-Binding with Custom Converters (Fluent API)", New Type() {GetType(ViewModel)})>
        Public Shared Sub ConvertBindingFluentAPIOneWay(ByVal mvvmContext As MVVMContext, ByVal check As CheckEdit, ByVal commandButton As SimpleButton)
            ' Set type of POCO-ViewModel
            mvvmContext.ViewModelType = GetType(ViewModel)
            Dim fluent = mvvmContext.OfType(Of ViewModel)()
            ' Data binding for the ModelState property
            ' Fluent API: 
            ' fluent.SetBinding(check, Function(e) e.CheckState, Function(x) x.ModelState,
            '                  Function(modelState)
            '                       Select Case modelState
            '                           Case ViewModel.State.Active
            '                               Return CheckState.Checked
            '                           Case ViewModel.State.Inactive
            '                               Return CheckState.Unchecked
            '                           Case Else
            '                               Return CheckState.Indeterminate
            '                       End Select
            '                   End Function,
            '                 Function(checkState)
            '                      Select Case checkState
            '                          Case checkState.Checked
            '                              Return ViewModel.State.Active
            '                          Case checkState.Unchecked
            '                              Return ViewModel.State.Inactive
            '                          Case Else
            '                              Return ViewModel.State.Suspended
            '                      End Select
            '                  End Function)
            ' Stub for Demo
            fluent.SetBinding(check, CType(Function(e) e.CheckState, Expression(Of Func(Of CheckEdit, CheckState))), CType(Function(x) x.ModelState, Expression(Of Func(Of ViewModel, ViewModel.State))),
                              CType(Function(modelState)
                                        Select Case modelState
                                            Case ViewModel.State.Active
                                                Return CheckState.Checked
                                            Case ViewModel.State.Inactive
                                                Return CheckState.Unchecked
                                            Case Else
                                                Return CheckState.Indeterminate
                                        End Select
                                    End Function, Func(Of ViewModel.State, CheckState)),
                                CType(Function(checkState)
                                          Select Case checkState
                                              Case checkState.Checked
                                                  Return ViewModel.State.Active
                                              Case checkState.Unchecked
                                                  Return ViewModel.State.Inactive
                                              Case Else
                                                  Return ViewModel.State.Suspended
                                          End Select
                                      End Function, Func(Of CheckState, ViewModel.State)))
            ' Fluent API: 
            ' fluent.SetBinding(check, Function(e) e.Text, Function(x) x.ModelState, Function(modelState) String.Format("Click to change the current ViewModel state from {0} to {1}", modelState, CType((1 + CInt((modelState))) Mod 3, ViewModel.State)))
            ' Stub for Demo
            fluent.SetBinding(check, CType(Function(e) e.Text, Expression(Of Func(Of CheckEdit, String))), CType(Function(x) x.ModelState, Expression(Of Func(Of ViewModel, ViewModel.State))), CType(Function(modelState) String.Format("Click to change the current ViewModel state from {0} to {1}", modelState, CType((1 + CInt((modelState))) Mod 3, ViewModel.State)), Func(Of ViewModel.State, String)))
            ' UI binding for the Report command
            fluent.BindCommand(commandButton, CType(Sub(x) x.ReportState(), Expression(Of Action(Of ViewModel))))
        End Sub
        <CodeExampleNestedClass>
        Public Class ViewModel
            Public Overridable Property ModelState() As State
            Public Enum State
                Suspended = 0
                Inactive = 1
                Active = 2
            End Enum
            Public Sub ReportState()
                Me.GetService(Of IMessageBoxService)().ShowMessage(ModelState.ToString())
            End Sub
        End Class
    End Class
    <CodeExampleClass("Data-Binding Capabilities (Formatting)", "Bindings.vb"), CodeExampleVersionID(162), CodeExampleUnderlineTokens("SetBinding")>
    Public NotInheritable Class BindingFeatures_Formatting

        Private Sub New()
        End Sub

        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim label As New LabelControl()
            label.Dock = DockStyle.Top

            Dim editor As New SpinEdit()
            editor.Properties.IsFloatValue = False
            editor.Dock = DockStyle.Top

            Dim commandButton As New SimpleButton()
            commandButton.Dock = DockStyle.Top
            commandButton.Text = "Reset Price"

            commandButton.Parent = sampleHost
            editor.Parent = sampleHost
            label.Parent = sampleHost
            Return New Object() {mvvmContext, label, editor, commandButton}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Data-Binding with Formatting", New Type() {GetType(ViewModel)})>
        Public Shared Sub FormatBinding(ByVal mvvmContext As MVVMContext, ByVal label As LabelControl, ByVal editor As SpinEdit, ByVal commandButton As SimpleButton)
            ' Set type of POCO-ViewModel
            mvvmContext.ViewModelType = GetType(ViewModel)
            ' One-way Data binding for the Price property (display as currency)
            mvvmContext.SetBinding(label, Function(l) l.Text, "Price", "Price: {0:C}")
            ' Data binding for the Price property editing
            mvvmContext.SetBinding(editor, Function(e) e.EditValue, "Price")
            ' UI binding for the Reset command
            mvvmContext.BindCommand(Of ViewModel)(commandButton, Sub(x) x.Reset())
        End Sub
        <CodeExampleNestedClass>
        Public Class ViewModel
            Public Sub New()
                Reset()
            End Sub
            Public Overridable Property Price() As Integer
            Public Sub Reset()
                Price = 175
            End Sub
        End Class
    End Class
    <CodeExampleClass("Data-Binding Capabilities (Events)", "Bindings.vb"), CodeExampleVersionID(162), CodeExampleUnderlineTokens("SetBinding")>
    Public NotInheritable Class BindingFeatures_Events

        Private Sub New()
        End Sub

        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim editor As New TextEdit()
            editor.Dock = DockStyle.Top

            Dim commandButton As New SimpleButton()
            commandButton.Dock = DockStyle.Top

            commandButton.Parent = sampleHost
            editor.Parent = sampleHost
            Return New Object() {mvvmContext, editor, commandButton}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Data-Binding with custom conversion handling", New Type() {GetType(ViewModel)})>
        Public Shared Sub BindingConvert(ByVal mvvmContext As MVVMContext, ByVal editor As TextEdit, ByVal commandButton As SimpleButton)
            ' Set type of POCO-ViewModel
            mvvmContext.ViewModelType = GetType(ViewModel)
            ' Binding Convert handling
            AddHandler mvvmContext.BindingConvert, Sub(s, e)
                                                       Dim strValue As String = TryCast(e.Value, String)
                                                       If strValue IsNot Nothing Then
                                                           Dim intValue As Integer
                                                           If Integer.TryParse(strValue, intValue) Then
                                                               e.Value = intValue
                                                           Else
                                                               e.Value = Nothing
                                                           End If
                                                       End If
                                                       If e.Value Is Nothing Then
                                                           e.Value = 0
                                                       End If
                                                   End Sub
            ' Data binding for the Value property
            mvvmContext.SetBinding(editor, Function(e) e.EditValue, "Value")
            ' UI binding for the Reset command
            mvvmContext.BindCommand(Of ViewModel)(commandButton, Sub(x) x.Reset())
            mvvmContext.SetBinding(commandButton, Function(b) b.Text, "Value", "Reset Value ({0})")
        End Sub
        <CodeExampleCase("Data-Binding with custom error handling", New Type() {GetType(ViewModel)})>
        Public Shared Sub BindingError(ByVal mvvmContext As MVVMContext, ByVal editor As TextEdit, ByVal commandButton As SimpleButton)
            ' Set type of POCO-ViewModel
            mvvmContext.ViewModelType = GetType(ViewModel)
            ' Binding Error handling
            AddHandler mvvmContext.BindingError, Sub(s, e) editor.ErrorText = e.Error.Message
            ' When Errors changed
            AddHandler mvvmContext.BindingBehavior.Errors.PropertyChanged, Sub(s, e)
                                                                               Dim errors = (DirectCast(s, System.ComponentModel.IDataErrorInfo))
                                                                               If errors.Error Is Nothing Then
                                                                                   editor.ErrorText = Nothing
                                                                               End If
                                                                           End Sub
            ' Data binding for the Value property
            mvvmContext.SetBinding(editor, Function(e) e.EditValue, "Value")
            ' UI binding for the Reset command
            mvvmContext.BindCommand(Of ViewModel)(commandButton, Sub(x) x.Reset())
            mvvmContext.SetBinding(commandButton, Function(b) b.Text, "Value", "Reset Value ({0})")
        End Sub
        <CodeExampleNestedClass>
        Public Class ViewModel
            Public Sub New()
                Reset()
            End Sub
            Public Overridable Property Value() As Integer
            Protected Sub OnValueChanged()
                Me.RaiseCanExecuteChanged(Sub(x) x.Reset())
            End Sub
            Public Function CanReset() As Boolean
                Return Value <> 42
            End Function
            Public Sub Reset()
                Value = 42
            End Sub
        End Class
    End Class
    <CodeExampleClass("Data-Binding Capabilities (MultiBinding)", "Bindings.vb"), CodeExampleVersionID(162), CodeExampleUnderlineTokens("SetMultiBinding")>
    Public NotInheritable Class BindingFeatures_MultiBinding

        Private Sub New()
        End Sub

        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim editForFirstName As New TextEdit()
            editForFirstName.Dock = DockStyle.Top
            Dim editForLastName As New TextEdit()
            editForLastName.Dock = DockStyle.Top
            Dim editForFullName As New TextEdit()
            editForFullName.Dock = DockStyle.Top

            editForFullName.Parent = sampleHost
            editForLastName.Parent = sampleHost
            editForFirstName.Parent = sampleHost
            Return New Object() {mvvmContext, editForFirstName, editForLastName, editForFullName}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Data-Binding for Multiple properties at once(via formatting)", New Type() {GetType(ViewModel)})>
        Public Shared Sub FormatBinding(ByVal mvvmContext As MVVMContext, ByVal editForFirstName As TextEdit, ByVal editForLastName As TextEdit, ByVal editForFullName As TextEdit)
            editForFullName.ReadOnly = True
            ' Set type of POCO-ViewModel
            mvvmContext.ViewModelType = GetType(ViewModel)
            ' Data binding for the FirstName and Last Name properties
            mvvmContext.SetBinding(editForFirstName, Function(e) e.EditValue, "FirstName")
            mvvmContext.SetBinding(editForLastName, Function(e) e.EditValue, "LastName")
            ' Multi binding for the dispaying FullName (one-way)
            mvvmContext.SetMultiBinding(editForFullName, Function(e) e.Text, New String() {"FirstName", "LastName"}, "{1}, {0}")
        End Sub
        <CodeExampleCase("Data-Binding for Multiple properties at once(via converters)", New Type() {GetType(ViewModel)})>
        Public Shared Sub ConvertBinding(ByVal mvvmContext As MVVMContext, ByVal editForFirstName As TextEdit, ByVal editForLastName As TextEdit, ByVal editForFullName As TextEdit)
            ' Set type of POCO-ViewModel
            mvvmContext.ViewModelType = GetType(ViewModel)
            ' Data binding for the FirstName and Last Name properties editing
            mvvmContext.SetBinding(editForFirstName, Function(e) e.EditValue, "FirstName")
            mvvmContext.SetBinding(editForLastName, Function(e) e.EditValue, "LastName")
            ' Multi binding for the editing FullName (two-way)
            mvvmContext.SetMultiBinding(editForFullName, Function(e) e.EditValue, New String() {"FirstName", "LastName"}, Function(values) String.Join(",", values), Function(value) CStr(value).Split(","c))
        End Sub
        <CodeExampleNestedClass>
        Public Class ViewModel
            Public Sub New()
                FirstName = "John"
                LastName = "Smith"
            End Sub
            Public Overridable Property FirstName() As String
            Public Overridable Property LastName() As String
        End Class
    End Class
End Namespace
