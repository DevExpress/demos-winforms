Imports System
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.DevAV.Common.ViewModel
Imports DevExpress.Mvvm

Namespace DevExpress.DevAV.ViewModels

    Public MustInherit Class ReportViewModelBase

        Protected Friend MustOverride ReadOnly Property IsLoaded As Boolean

        Protected Friend MustOverride Sub OnReload()
    End Class

    Public MustInherit Class ReportViewModelBaseType(Of TReportType As Structure)
        Inherits ReportViewModelBase
        Implements ISupportParameter

        Public Overridable Property ReportType As TReportType

        Protected Overridable Sub OnReportTypeChanged()
            If IsLoaded Then RaiseReportTypeChanged()
        End Sub

        Public Event ReportTypeChanged As EventHandler

        Private Sub RaiseReportTypeChanged()
            Dim handler As EventHandler = ReportTypeChangedEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

#Region "ISupportParameter"
        Private Property Parameter As Object Implements ISupportParameter.Parameter
            Get
                Return ReportType
            End Get

            Set(ByVal value As Object)
                ReportType = CType(value, TReportType)
                OnParameterChanged()
            End Set
        End Property

        Protected Overridable Sub OnParameterChanged()
        End Sub
#End Region
    End Class

    Public Class ReportViewModelBaseType1(Of TReportType As Structure, TEntity As Class, TPrimaryKey, TUnitOfWork As {Class, IUnitOfWork})
        Inherits ReportViewModelBaseType(Of TReportType)

        Protected Overrides Sub OnParameterChanged()
            MyBase.OnParameterChanged()
            CheckReportEntityKey()
        End Sub

        Public Overridable Property ReportEntityKey As Object

        Protected Overridable Sub OnReportEntityKeyChanged()
            RaiseReportEntityKeyChanged()
        End Sub

        Public Event ReportEntityKeyChanged As EventHandler

        Protected Friend Overrides Sub OnReload()
            If Not IsLoaded Then Return
            CheckReportEntityKey()
            RaiseReload()
        End Sub

        Public Event Reload As EventHandler

        Private isLoadedCore As Boolean

        Protected Friend Overrides ReadOnly Property IsLoaded As Boolean
            Get
                Return isLoadedCore
            End Get
        End Property

        Public Sub OnLoad()
            CheckReportEntityKey()
            isLoadedCore = True
        End Sub

        Private Sub CheckReportEntityKey()
            Dim cViewModel = GetCollectionViewModel()
            If cViewModel IsNot Nothing Then ReportEntityKey = cViewModel.SelectedEntityKey
        End Sub

        Protected Function GetCollectionViewModel() As CollectionViewModel(Of TEntity, TPrimaryKey, TUnitOfWork)
            Dim supportParent As ISupportParentViewModel = TryCast(Me, ISupportParentViewModel)
            If supportParent IsNot Nothing Then Return TryCast(supportParent.ParentViewModel, CollectionViewModel(Of TEntity, TPrimaryKey, TUnitOfWork))
            Return Nothing
        End Function

        Private Sub RaiseReportEntityKeyChanged()
            Dim handler As EventHandler = ReportEntityKeyChangedEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

        Private Sub RaiseReload()
            Dim handler As EventHandler = ReloadEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub
    End Class
End Namespace
