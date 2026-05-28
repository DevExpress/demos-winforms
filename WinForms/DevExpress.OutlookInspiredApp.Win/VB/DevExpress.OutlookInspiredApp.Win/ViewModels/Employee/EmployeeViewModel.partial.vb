Imports System
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.ViewModels

    Partial Class EmployeeViewModel
        Implements ISupportNewChid

        Public Overloads Function IsNew() As Boolean
            Return MyBase.IsNew()
        End Function

        Private contactsCore As EmployeeContactsViewModel

        Public ReadOnly Property Contacts As EmployeeContactsViewModel
            Get
                If contactsCore Is Nothing Then contactsCore = EmployeeContactsViewModel.Create().SetParentViewModel(Me)
                Return contactsCore
            End Get
        End Property

        Protected Overrides Function GetTitle() As String
            Return Entity.FullName
        End Function

        Protected Overrides Sub OnEntityChanged()
            MyBase.OnEntityChanged()
            Contacts.Entity = Entity
            RaiseCanExecuteChanged(Sub(x) x.ShowMap())
            RaiseCanExecuteChanged(Sub(x) x.MailMerge())
            RaiseCanExecuteChanged(Sub(x) x.Print(EmployeeReportType.Profile))
            RaiseCanExecuteChanged(Sub(x) x.QuickLetter(EmployeeMailTemplate.ThankYouNote))
            Dim handler As EventHandler = EntityChangedEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

        Public Event EntityChanged As EventHandler

        <Command>
        Public Sub QuickLetter(ByVal mailTemplate As EmployeeMailTemplate)
            Dim collectionViewModel As EmployeeCollectionViewModel = ViewModelHelper.GetParentViewModel(Of EmployeeCollectionViewModel)(Me)
            If collectionViewModel IsNot Nothing Then collectionViewModel.QuickLetterCore(Entity, mailTemplate)
        End Sub

        Public Function CanQuickLetter(ByVal mailTemplate As EmployeeMailTemplate) As Boolean
            If Entity Is Nothing OrElse IsNew() Then Return False
            Dim collectionViewModel As EmployeeCollectionViewModel = ViewModelHelper.GetParentViewModel(Of EmployeeCollectionViewModel)(Me)
            Return collectionViewModel IsNot Nothing AndAlso collectionViewModel.CanQuickLetterCore(Entity, mailTemplate)
        End Function

        <Command>
        Public Sub Print(ByVal reportType As EmployeeReportType)
            Dim collectionViewModel As EmployeeCollectionViewModel = ViewModelHelper.GetParentViewModel(Of EmployeeCollectionViewModel)(Me)
            If collectionViewModel IsNot Nothing Then collectionViewModel.PrintCore(Entity, reportType)
        End Sub

        Public Function CanPrint(ByVal reportType As EmployeeReportType) As Boolean
            If Entity Is Nothing OrElse IsNew() Then Return False
            Dim collectionViewModel As EmployeeCollectionViewModel = ViewModelHelper.GetParentViewModel(Of EmployeeCollectionViewModel)(Me)
            Return collectionViewModel IsNot Nothing AndAlso collectionViewModel.CanPrintProfileCore(Entity)
        End Function

        <Command>
        Public Sub MailMerge()
            Dim collectionViewModel As EmployeeCollectionViewModel = ViewModelHelper.GetParentViewModel(Of EmployeeCollectionViewModel)(Me)
            If collectionViewModel IsNot Nothing Then collectionViewModel.MailMerge()
        End Sub

        Public Function CanMailMerge() As Boolean
            Return Entity IsNot Nothing AndAlso Not IsNew()
        End Function

        <Command>
        Public Sub ShowMap()
            Dim collectionViewModel As EmployeeCollectionViewModel = ViewModelHelper.GetParentViewModel(Of EmployeeCollectionViewModel)(Me)
            If collectionViewModel IsNot Nothing Then collectionViewModel.ShowMapCore(Entity)
        End Sub

        Public Function CanShowMap() As Boolean
            If Entity Is Nothing OrElse IsNew() Then Return False
            Dim collectionViewModel As EmployeeCollectionViewModel = ViewModelHelper.GetParentViewModel(Of EmployeeCollectionViewModel)(Me)
            Return collectionViewModel IsNot Nothing AndAlso collectionViewModel.CanShowMapCore(Entity)
        End Function

        <Command>
        Public Sub ShowMeeting()
            Dim collectionViewModel As EmployeeCollectionViewModel = ViewModelHelper.GetParentViewModel(Of EmployeeCollectionViewModel)(Me)
            If collectionViewModel IsNot Nothing Then collectionViewModel.ShowMeeting()
        End Sub

        Public Function CanShowMeeting() As Boolean
            Return Entity IsNot Nothing AndAlso Not IsNew()
        End Function

        <Command>
        Public Sub ShowTask()
            Dim collectionViewModel As EmployeeCollectionViewModel = ViewModelHelper.GetParentViewModel(Of EmployeeCollectionViewModel)(Me)
            If collectionViewModel IsNot Nothing Then collectionViewModel.ShowTask()
        End Sub

        Public Function CanShowTask() As Boolean
            Return Entity IsNot Nothing AndAlso Not IsNew()
        End Function
    End Class

    Public Partial Class SynchronizedEmployeeViewModel
        Inherits EmployeeViewModel

        Protected Overrides ReadOnly Property EnableSelectedItemSynchronization As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides ReadOnly Property EnableEntityChangedSynchronization As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
