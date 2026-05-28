Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Configuration
Imports System.Linq
Imports System.Linq.Expressions
Imports DevExpress.Data.Filtering

Namespace DevExpress.DevAV.ViewModels

    Public MustInherit Class FilterItemBase

        Protected Sub New()
        End Sub

        Public Overridable Property Name As String

        Public Overridable Property FilterCriteria As CriteriaOperator
    End Class

    Public Interface IFilterTreeModelPageSpecificSettings

        ReadOnly Property StaticFiltersTitle As String

        Property StaticFilters As FilterInfoList

        Property CustomFilters As FilterInfoList

        Property GroupFilters As FilterInfoList

        ReadOnly Property Settings As ApplicationSettingsBase

        ReadOnly Property HiddenFilterProperties As IEnumerable(Of String)

        ReadOnly Property AdditionalFilterProperties As IEnumerable(Of String)

    End Interface

    Public Class FilterTreeModelPageSpecificSettings(Of TSettings As System.Configuration.ApplicationSettingsBase)
        Implements DevExpress.DevAV.ViewModels.IFilterTreeModelPageSpecificSettings

        Private ReadOnly staticFiltersTitleCore As String

        Private ReadOnly settingsCore As TSettings

        Private ReadOnly customFiltersProperty As System.ComponentModel.PropertyDescriptor

        Private ReadOnly staticFiltersProperty As System.ComponentModel.PropertyDescriptor

        Private ReadOnly groupFiltersProperty As System.ComponentModel.PropertyDescriptor

        Private ReadOnly hiddenFilterPropertiesCore As System.Collections.Generic.IEnumerable(Of String)

        Private ReadOnly additionalFilterPropertiesCore As System.Collections.Generic.IEnumerable(Of String)

        Public Sub New(ByVal settings As TSettings, ByVal staticFiltersTitle As String, ByVal getStaticFiltersExpression As System.Linq.Expressions.Expression(Of System.Func(Of TSettings, DevExpress.DevAV.ViewModels.FilterInfoList)), ByVal getCustomFiltersExpression As System.Linq.Expressions.Expression(Of System.Func(Of TSettings, DevExpress.DevAV.ViewModels.FilterInfoList)), ByVal getGroupFiltersExpression As System.Linq.Expressions.Expression(Of System.Func(Of TSettings, DevExpress.DevAV.ViewModels.FilterInfoList)), ByVal Optional hiddenFilterProperties As System.Collections.Generic.IEnumerable(Of String) = Nothing, ByVal Optional additionalFilterProperties As System.Collections.Generic.IEnumerable(Of String) = Nothing)
            Me.settingsCore = settings
            Me.staticFiltersTitleCore = staticFiltersTitle
            Me.staticFiltersProperty = Me.GetProperty(getStaticFiltersExpression)
            Me.customFiltersProperty = Me.GetProperty(getCustomFiltersExpression)
            Me.groupFiltersProperty = Me.GetProperty(getGroupFiltersExpression)
            Me.hiddenFilterPropertiesCore = hiddenFilterProperties
            Me.additionalFilterPropertiesCore = additionalFilterProperties
        End Sub

        Private Property CustomFilters As FilterInfoList Implements Global.DevExpress.DevAV.ViewModels.IFilterTreeModelPageSpecificSettings.CustomFilters
            Get
                Return Me.GetFilters(Me.customFiltersProperty)
            End Get

            Set(ByVal value As FilterInfoList)
                Me.SetFilters(Me.customFiltersProperty, value)
            End Set
        End Property

        Private Property StaticFilters As FilterInfoList Implements Global.DevExpress.DevAV.ViewModels.IFilterTreeModelPageSpecificSettings.StaticFilters
            Get
                Return Me.GetFilters(Me.staticFiltersProperty)
            End Get

            Set(ByVal value As FilterInfoList)
                Me.SetFilters(Me.staticFiltersProperty, value)
            End Set
        End Property

        Private Property GroupFilters As FilterInfoList Implements Global.DevExpress.DevAV.ViewModels.IFilterTreeModelPageSpecificSettings.GroupFilters
            Get
                Return Me.GetFilters(Me.groupFiltersProperty)
            End Get

            Set(ByVal value As FilterInfoList)
                Me.SetFilters(Me.groupFiltersProperty, value)
            End Set
        End Property

        Private ReadOnly Property Settings As ApplicationSettingsBase Implements Global.DevExpress.DevAV.ViewModels.IFilterTreeModelPageSpecificSettings.Settings
            Get
                Return Me.settingsCore
            End Get
        End Property

        Private ReadOnly Property StaticFiltersTitle As String Implements Global.DevExpress.DevAV.ViewModels.IFilterTreeModelPageSpecificSettings.StaticFiltersTitle
            Get
                Return Me.staticFiltersTitleCore
            End Get
        End Property

        Private ReadOnly Property HiddenFilterProperties As IEnumerable(Of String) Implements Global.DevExpress.DevAV.ViewModels.IFilterTreeModelPageSpecificSettings.HiddenFilterProperties
            Get
                Return Me.hiddenFilterPropertiesCore
            End Get
        End Property

        Private ReadOnly Property AdditionalFilterProperties As IEnumerable(Of String) Implements Global.DevExpress.DevAV.ViewModels.IFilterTreeModelPageSpecificSettings.AdditionalFilterProperties
            Get
                Return Me.additionalFilterPropertiesCore
            End Get
        End Property

        Private Function GetProperty(ByVal expression As System.Linq.Expressions.Expression(Of System.Func(Of TSettings, DevExpress.DevAV.ViewModels.FilterInfoList))) As PropertyDescriptor
            If expression IsNot Nothing Then Return System.ComponentModel.TypeDescriptor.GetProperties(Me.settingsCore)(DevExpress.DevAV.ViewModels.FilterTreeModelPageSpecificSettings(Of TSettings).GetPropertyName(expression))
            Return Nothing
        End Function

        Private Function GetFilters(ByVal [property] As System.ComponentModel.PropertyDescriptor) As FilterInfoList
            Return If([property] IsNot Nothing, CType([property].GetValue(Me.settingsCore), DevExpress.DevAV.ViewModels.FilterInfoList), Nothing)
        End Function

        Private Sub SetFilters(ByVal [property] As System.ComponentModel.PropertyDescriptor, ByVal value As DevExpress.DevAV.ViewModels.FilterInfoList)
            If [property] IsNot Nothing Then [property].SetValue(Me.settingsCore, value)
        End Sub

        Private Shared Function GetPropertyName(ByVal expression As System.Linq.Expressions.Expression(Of System.Func(Of TSettings, DevExpress.DevAV.ViewModels.FilterInfoList))) As String
            Dim memberExpression As System.Linq.Expressions.MemberExpression = TryCast(expression.Body, System.Linq.Expressions.MemberExpression)
            If memberExpression Is Nothing Then
                Throw New System.ArgumentException("expression")
            End If

            Return memberExpression.Member.Name
        End Function
    End Class

    Public Class FilterInfo

        Public Property Name As String

        Public Property FilterCriteria As String

        Public Property ImageUri As String
    End Class

    Public Class FilterInfoList
        Inherits System.Collections.Generic.List(Of DevExpress.DevAV.ViewModels.FilterInfo)

        Public Sub New()
        End Sub

        Public Sub New(ByVal filters As System.Collections.Generic.IEnumerable(Of DevExpress.DevAV.ViewModels.FilterInfo))
            MyBase.New(filters)
        End Sub
    End Class

    Public MustInherit Class FilterTreeViewModelBase

        Private _ViewModel As Object

        Shared Sub New()
            Dim enums = GetType(DevExpress.DevAV.EmployeeStatus).Assembly.GetTypes().Where(Function(t) t.IsEnum)
            For Each e As System.Type In enums
                Call DevExpress.Data.Filtering.EnumProcessingHelper.RegisterEnum(e)
            Next
        End Sub

        Protected ReadOnly settingsCore As DevExpress.DevAV.ViewModels.IFilterTreeModelPageSpecificSettings

        Public Sub New(ByVal settings As DevExpress.DevAV.ViewModels.IFilterTreeModelPageSpecificSettings)
            Me.settingsCore = settings
        End Sub

        Public Overridable Sub Init()
            Me.StaticFilters = Me.CreateFilterItems(Me.settingsCore.StaticFilters)
            Me.CustomFilters = Me.CreateFilterItems(Me.settingsCore.CustomFilters)
            Me.SelectedItem = Me.StaticFilters.FirstOrDefault()
        End Sub

        Public Overridable Property StaticFilters As ObservableCollection(Of DevExpress.DevAV.ViewModels.FilterItemBase)

        Public Overridable Property CustomFilters As ObservableCollection(Of DevExpress.DevAV.ViewModels.FilterItemBase)

        Public Overridable Property SelectedItem As FilterItemBase

        Protected Sub AddNewCustomFilter(ByVal filterItem As DevExpress.DevAV.ViewModels.FilterItemBase)
            Dim existing = Me.CustomFilters.FirstOrDefault(Function(fi) Equals(fi.Name, filterItem.Name))
            If existing IsNot Nothing Then Me.CustomFilters.Remove(existing)
            Me.CustomFilters.Add(filterItem)
            Me.SaveCustomFilters()
        End Sub

        Public Overridable Sub DeleteCustomFilter(ByVal filterItem As DevExpress.DevAV.ViewModels.FilterItemBase)
            Me.CustomFilters.Remove(filterItem)
            Me.SaveCustomFilters()
        End Sub

        Public Overridable Sub DuplicateFilter(ByVal filterItem As DevExpress.DevAV.ViewModels.FilterItemBase)
            Dim newItem = Me.CreateFilterItem("Copy of " & filterItem.Name, filterItem.FilterCriteria, Nothing)
            Me.CustomFilters.Add(newItem)
            Me.SaveCustomFilters()
        End Sub

        Public Overridable Sub ResetCustomFilters()
            If Me.CustomFilters.Contains(Me.SelectedItem) Then Me.SelectedItem = Nothing
            Me.settingsCore.CustomFilters = New DevExpress.DevAV.ViewModels.FilterInfoList()
            Me.CustomFilters.Clear()
            Me.settingsCore.Settings.Save()
        End Sub

        Protected Function CreateFilterItems(ByVal filters As System.Collections.Generic.IEnumerable(Of DevExpress.DevAV.ViewModels.FilterInfo)) As ObservableCollection(Of DevExpress.DevAV.ViewModels.FilterItemBase)
            If filters Is Nothing Then Return New System.Collections.ObjectModel.ObservableCollection(Of DevExpress.DevAV.ViewModels.FilterItemBase)()
            Dim filtered = filters.[Select](Function(x) Me.CreateFilterItem(x.Name, DevExpress.Data.Filtering.CriteriaOperator.Parse(x.FilterCriteria), x.ImageUri))
            Return New System.Collections.ObjectModel.ObservableCollection(Of DevExpress.DevAV.ViewModels.FilterItemBase)(filtered)
        End Function

        Protected MustOverride Function CreateFilterItem(ByVal name As String, ByVal filterCriteria As DevExpress.Data.Filtering.CriteriaOperator, ByVal imageUri As String) As FilterItemBase

        Protected Sub SaveCustomFilters()
            Me.settingsCore.CustomFilters = Me.SaveToSettings(Me.CustomFilters)
            Me.settingsCore.Settings.Save()
        End Sub

        Protected Function SaveToSettings(ByVal filters As System.Collections.ObjectModel.ObservableCollection(Of DevExpress.DevAV.ViewModels.FilterItemBase)) As FilterInfoList
            Return New DevExpress.DevAV.ViewModels.FilterInfoList(filters.[Select](Function(fi) New DevExpress.DevAV.ViewModels.FilterInfo With {.Name = fi.Name, .FilterCriteria = DevExpress.Data.Filtering.CriteriaOperator.ToString(fi.FilterCriteria)}))
        End Function

        Protected Property ViewModel As Object
            Get
                Return _ViewModel
            End Get

            Private Set(ByVal value As Object)
                _ViewModel = value
            End Set
        End Property

        Public Overridable Sub SetViewModel(ByVal value As Object)
            Me.ViewModel = value
        End Sub
    End Class
End Namespace
