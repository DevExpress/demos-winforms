Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel.DataAnnotations
Imports System.Linq.Expressions
Imports DevExpress.Data.Filtering
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.Data.Utils
Imports DevExpress.DevAV.Common.ViewModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.ViewModels

    Public Class FilterTreeViewModel(Of TEntity As Class, TPrimaryKey, TUnitOfWork As {Class, IUnitOfWork})
        Inherits FilterTreeViewModelBase

        Public Const StaticFiltersName As String = "Favorites"

        Public Const CustomFiltersName As String = "Custom Filters"

        Public Const GroupFiltersName As String = "Groups"

        Public Sub New(ByVal colViewModel As CollectionViewModel(Of TEntity, TPrimaryKey, TUnitOfWork), ByVal settings As IFilterTreeModelPageSpecificSettings)
            MyBase.New(settings)
            SetViewModel(colViewModel)
            EnsureViewModel(Me, colViewModel)
            Init()
            Dim scf As ISupportCustomFilters = TryCast(colViewModel, ISupportCustomFilters)
            If scf IsNot Nothing Then AddHandler scf.CustomFiltersReset, AddressOf scf_CustomFiltersReset
        End Sub

        Private Sub scf_CustomFiltersReset(ByVal sender As Object, ByVal e As EventArgs)
            ResetCustomFilters()
        End Sub

        Protected Friend ReadOnly Property CollectionViewModel As CollectionViewModel(Of TEntity, TPrimaryKey, TUnitOfWork)
            Get
                Return CType(ViewModel, CollectionViewModel(Of TEntity, TPrimaryKey, TUnitOfWork))
            End Get
        End Property

        Protected Overridable Sub OnSelectedItemChanged()
            RaiseCanExecuteChanged(Sub(x) x.Select(Nothing))
            RaiseSelectedItemChanged()
            ApplyFilter(SelectedItem)
        End Sub

        Public Function CanSelectModule(ByVal item As FilterItem) As Boolean
            Return SelectedItem IsNot item
        End Function

        <Command>
        Public Sub [Select](ByVal item As FilterItem)
            SelectedItem = item
        End Sub

        Public Event SelectedItemChanged As EventHandler

        Private Sub RaiseSelectedItemChanged()
            RaiseEvent SelectedItemChanged(Me, EventArgs.Empty)
        End Sub

        Private Sub ApplyFilter(ByVal fItem As FilterItemBase)
            If fItem IsNot Nothing AndAlso Not ReferenceEquals(fItem.FilterCriteria, Nothing) Then
                CollectionViewModel.FilterExpression = GetFilterExpression(fItem)
            Else
                CollectionViewModel.FilterExpression = Nothing
            End If
        End Sub

        Public Event FilterAccordionChanged As EventHandler

        Private Sub RaiseFilterAccordionChanged()
            RaiseEvent FilterAccordionChanged(Me, EventArgs.Empty)
        End Sub

        Protected Overrides Function CreateFilterItem(ByVal name As String, ByVal filterCriteria As CriteriaOperator, ByVal imageUri As String) As FilterItemBase
            Return FilterItem.Create(name, filterCriteria)
        End Function

        <Command>
        Public Sub [New]()
            Dim newFilterItem = CreateFilterItem(Nothing, Nothing, Nothing)
            Dim customViewModel As CustomFilterViewModel = CreateCustomFilterViewModel(Of CustomFilterViewModel)(newFilterItem)
            If ShowFilterDialog(customViewModel, "Custom Filter") Then
                If customViewModel.Save Then
                    AddNewCustomFilter(newFilterItem)
                    RaiseFilterAccordionChanged()
                End If

                SelectedItem = newFilterItem
            End If
        End Sub

        <Command>
        Public Sub Modify(ByVal item As FilterItem)
            Dim customViewModel As CustomFilterViewModel = CreateCustomFilterViewModel(Of CustomFilterViewModel)(item)
            If ShowFilterDialog(customViewModel, "Custom Filter") Then
                If customViewModel.Save Then
                    SaveCustomFilters()
                    RaiseFilterAccordionChanged()
                End If

                ApplyFilter(item)
            End If
        End Sub

        <Command>
        Public Sub Delete(ByVal item As FilterItem)
            DeleteCustomFilter(item)
            RaiseFilterAccordionChanged()
            If SelectedItem Is item Then SelectedItem = Nothing
        End Sub

        <Command>
        Public Sub NewGroup()
            NewGroupCore(CreateFilterItem(Nothing, Nothing, Nothing))
        End Sub

        <Command>
        Public Sub NewGroupFromSelection(ByVal selection As IEnumerable(Of TEntity))
            NewGroupCore(CreateFilterItem(Nothing, CollectionViewModel.GetInOperator(selection), Nothing))
        End Sub

        Public Overridable Property Groups As ObservableCollection(Of FilterItemBase)

        Public Overridable Sub AddNewGroupFilter(ByVal fItem As FilterItemBase)
            Groups.Add(fItem)
            SaveGroupFilters()
        End Sub

        Public Overridable Sub DeleteGroupFilter(ByVal fItem As FilterItemBase)
            Groups.Remove(fItem)
            SaveGroupFilters()
        End Sub

        Public Overridable Sub ModifyGroupFilter(ByVal fItem As FilterItemBase)
            SaveGroupFilters()
        End Sub

        Private Sub SaveGroupFilters()
            settingsCore.GroupFilters = SaveToSettings(Groups)
            settingsCore.Settings.Save()
        End Sub

        Public Overrides Sub Init()
            Groups = CreateFilterItems(settingsCore.GroupFilters)
            MyBase.Init()
        End Sub

        Private Sub NewGroupCore(ByVal newFilterItem As FilterItemBase)
            Dim gViewModel As GroupFilterViewModel = CreateCustomFilterViewModel(Of GroupFilterViewModel)(newFilterItem)
            If ShowFilterDialog(gViewModel, "Group Filter") Then
                If gViewModel.Save Then
                    AddNewGroupFilter(newFilterItem)
                    RaiseFilterAccordionChanged()
                End If

                SelectedItem = newFilterItem
            End If
        End Sub

        <Command>
        Public Sub ModifyGroup(ByVal item As FilterItem)
            Dim gViewModel As GroupFilterViewModel = CreateCustomFilterViewModel(Of GroupFilterViewModel)(item)
            If ShowFilterDialog(gViewModel, "Group Filter") Then
                If gViewModel.Save Then
                    ModifyGroupFilter(item)
                    RaiseFilterAccordionChanged()
                End If

                ApplyFilter(item)
            End If
        End Sub

        <Command>
        Public Sub DeleteGroup(ByVal item As FilterItem)
            DeleteGroupFilter(item)
            RaiseFilterAccordionChanged()
            If SelectedItem Is item Then SelectedItem = Nothing
        End Sub

        Public Overrides Sub ResetCustomFilters()
            MyBase.ResetCustomFilters()
            RaiseFilterAccordionChanged()
        End Sub

        Protected Overridable Function CreateCustomFilterViewModel(Of T As {FilterViewModelBase, New})(ByVal fItem As FilterItemBase) As T
            Dim filterViewModel As T = ViewModelSource.Create(Of T)()
            EnsureViewModel(filterViewModel, CollectionViewModel, fItem)
            Return filterViewModel
        End Function

        Private Function ShowFilterDialog(ByVal filterViewModel As FilterViewModelBase, ByVal key As String) As Boolean
            Dim service = GetService(Of IDocumentManagerService)(key)
            If service IsNot Nothing Then
                Dim document = service.CreateDocument(key, filterViewModel, Nothing, CollectionViewModel)
                filterViewModel.Document = document
                document.Show()
                Return filterViewModel.Result.GetValueOrDefault()
            End If

            Return False
        End Function

        Protected Overridable ReadOnly Property EnableGroups As Boolean
            Get
                Return True
            End Get
        End Property

        Public Function GetFilterName(ByVal filtersCollection As Object, ByVal filter As FilterItemBase) As String
            If filter IsNot Nothing Then
                Dim count = CollectionViewModel.GetEntitiesCount(GetFilterExpression(filter))
                If count > 0 Then
                    Return filter.Name & " (" & count & ")"
                Else
                    Return filter.Name
                End If
            Else
                If Equals(filtersCollection, StaticFilters) Then Return StaticFiltersName
                If Equals(filtersCollection, CustomFilters) Then Return CustomFiltersName
                If Equals(filtersCollection, Groups) Then Return GroupFiltersName
            End If

            Return Nothing
        End Function

        Public Function GetChildren(ByVal dataItem As Object) As IList
            If dataItem Is Me Then
                If EnableGroups Then
                    Return CType((New List(Of Object) From {StaticFilters, CustomFilters, Groups}), IList)
                Else
                    Return CType((New List(Of Object) From {StaticFilters, CustomFilters}), IList)
                End If
            End If

            If TypeOf dataItem Is ObservableCollection(Of FilterItemBase) Then Return CType(dataItem, IList)
            Return Nothing
        End Function

        Friend Shared Function GetFilterExpression(ByVal criteria As CriteriaOperator) As Expression(Of Func(Of TEntity, Boolean))
            Return FilterExpressionFactory(Of TEntity).CreateFilterExpression(criteria)
        End Function

        Private Shared Function GetFilterExpression(ByVal filter As FilterItemBase) As Expression(Of Func(Of TEntity, Boolean))
            Return FilterExpressionFactory(Of TEntity).CreateFilterExpression(filter.FilterCriteria)
        End Function

#Region "Filter Item ViewModels"
        Public Class FilterItem
            Inherits FilterItemBase

            Public Shared Function Create(ByVal filterName As String, ByVal filterCriteria As CriteriaOperator) As FilterItem
                Return ViewModelSource.Create(Function() New FilterItem(filterName, filterCriteria))
            End Function

            Protected Sub New(ByVal name As String, ByVal filterCriteria As CriteriaOperator)
                Me.Name = name
                Me.FilterCriteria = filterCriteria
            End Sub
        End Class
#End Region  ' Items
    End Class

#Region "Custom Filter ViewModel"
    <POCOViewModel(ImplementIDataErrorInfo:=True)>
    Public MustInherit Class FilterViewModelBase
        Implements ISupportParameter

        Private _Result As Boolean?

        Public Sub New()
            Save = True
        End Sub

        Private filterItem As FilterItemBase

        Public Property Document As IDocument

        Public Property Result As Boolean?
            Get
                Return _Result
            End Get

            Private Set(ByVal value As Boolean?)
                _Result = value
            End Set
        End Property

        Public Overridable Property Save As Boolean

        <Required>
        Public Overridable Property Name As String

        Public ReadOnly Property FilterCriteria As CriteriaOperator
            Get
                Return filterItem.FilterCriteria
            End Get
        End Property

        Public Event QueryFilterCriteria As EventHandler(Of QueryFilterCriteriaEventArgs)

        Private Sub RaiseQueryFilterCriteria()
            Dim handler As EventHandler(Of QueryFilterCriteriaEventArgs) = QueryFilterCriteriaEvent
            If handler IsNot Nothing Then handler(Me, New QueryFilterCriteriaEventArgs(filterItem))
        End Sub

        Protected ReadOnly Property MessageBoxService As IMessageBoxService
            Get
                Return GetService(Of IMessageBoxService)()
            End Get
        End Property

        Protected MustOverride Function GetDefaultName() As String

        <Command>
        Public Sub OK()
            Result = True
            If String.IsNullOrEmpty(Name) Then Name = GetDefaultName()
            If Save Then filterItem.Name = Name
            RaiseQueryFilterCriteria()
            Document.Close()
        End Sub

        <Command>
        Public Sub Cancel()
            Result = False
            Document.Close()
        End Sub

        Private Property Parameter As Object Implements ISupportParameter.Parameter
            Get
                Return filterItem
            End Get

            Set(ByVal value As Object)
                filterItem = CType(value, FilterItemBase)
                Name = filterItem.Name
            End Set
        End Property
    End Class

    Public Class QueryFilterCriteriaEventArgs
        Inherits EventArgs

        Private item As FilterItemBase

        Public Sub New(ByVal item As FilterItemBase)
            Me.item = item
        End Sub

        Public Property FilterCriteria As CriteriaOperator
            Get
                Return item.FilterCriteria
            End Get

            Set(ByVal value As CriteriaOperator)
                item.FilterCriteria = value
            End Set
        End Property
    End Class

    Public Class CustomFilterViewModel
        Inherits FilterViewModelBase

        Private Shared id As Integer = 0

        Protected Overrides Function GetDefaultName() As String
            Return "Custom Filter " & Math.Min(Threading.Interlocked.Increment(id), id - 1).ToString()
        End Function
    End Class

    Public Class GroupFilterViewModel
        Inherits FilterViewModelBase

        Private Shared id As Integer = 0

        Protected Overrides Function GetDefaultName() As String
            Return "Group " & Math.Min(Threading.Interlocked.Increment(id), id - 1).ToString()
        End Function
    End Class

#End Region
    Friend NotInheritable Class FilterExpressionFactory(Of TEntity)

        Public Shared Function CreateFilterExpression(ByVal criteria As CriteriaOperator) As Expression(Of Func(Of TEntity, Boolean))
            Try
                Dim nullValueSafeCriteria = If(criteria.ReferenceEqualsNull(), criteria, criteria.Accept(New NullValueToNullString()))
                Dim caseInsensitiveCriteria = Data.Helpers.StringsTolowerCloningHelper.Process(nullValueSafeCriteria)
                Return CriteriaOperatorToExpressionConverter.GetGenericWhere(Of TEntity)(caseInsensitiveCriteria)
            Catch e As Exception
                Throw New NotSupportedException("Error in Filter:" & CriteriaOperator.ToString(criteria), e)
            End Try
        End Function

        Private NotInheritable Class NullString
            Implements ICustomFunctionOperator, ICustomFunctionOperatorConvertibleToExpression

            Friend Shared ReadOnly Instance As NullString = New NullString()

            Public ReadOnly Property Name As String Implements ICustomFunctionOperator.Name
                Get
                    Return "NullString"
                End Get
            End Property

            Public Function Convert(ByVal converter As Data.Linq.ICriteriaToExpressionConverter, ParamArray operands As Expression()) As Expression Implements ICustomFunctionOperatorConvertibleToExpression.Convert
                Return Expression.Constant(Nothing, GetType(String))
            End Function

            Public Function Evaluate(ParamArray operands As Object()) As Object Implements ICustomFunctionOperator.Evaluate
                Return Nothing
            End Function

            Public Function ResultType(ParamArray operands As Type()) As Type Implements ICustomFunctionOperator.ResultType
                Return GetType(String)
            End Function
        End Class

        Private NotInheritable Class NullValueToNullString
            Inherits Data.Filtering.Helpers.ClientCriteriaClonerBase.DeepValuesCloneBase

            Shared Sub New()
                CriteriaOperator.RegisterCustomFunction(NullString.Instance)
            End Sub

            Public Overrides Function Visit(ByVal theOperator As FunctionOperator) As CriteriaOperator
                If theOperator.OperatorType >= FunctionOperatorType.StartsWith AndAlso theOperator.OperatorType <= FunctionOperatorType.EndsWith Then
                    Dim value As OperandValue = Nothing
                    If theOperator.Operands(1).[Is](value) AndAlso TypeOf value.XmlValue Is NullValue Then theOperator.Operands(1) = New FunctionOperator(FunctionOperatorType.Custom, "NullString")
                End If

                Return MyBase.Visit(theOperator)
            End Function
        End Class
    End Class
End Namespace
