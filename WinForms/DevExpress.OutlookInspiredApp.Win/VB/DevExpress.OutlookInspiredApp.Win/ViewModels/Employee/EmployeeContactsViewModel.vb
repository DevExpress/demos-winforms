Imports DevExpress.DevAV.Common.ViewModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.ViewModels

    Public Class EmployeeContactsViewModel
        Inherits SingleObjectChildViewModel(Of Employee)

        Protected Sub New()
        End Sub

        Public Overloads Shared Function Create() As EmployeeContactsViewModel
            Return ViewModelSource.Create(Function() New EmployeeContactsViewModel())
        End Function

        Protected ReadOnly Property MessageBoxService As IMessageBoxService
            Get
                Return GetRequiredService(Of IMessageBoxService)()
            End Get
        End Property

        <Command>
        Public Sub Message()
            MessageBoxService.ShowMessage("Send an IM to: " & Entity.Skype)
        End Sub

        Public Function CanMessage() As Boolean
            Return Entity IsNot Nothing AndAlso Not String.IsNullOrEmpty(Entity.Skype)
        End Function

        <Command>
        Public Sub Phone()
            MessageBoxService.ShowMessage("Phone Call: " & Entity.MobilePhone)
        End Sub

        Public Function CanPhone() As Boolean
            Return Entity IsNot Nothing AndAlso Not String.IsNullOrEmpty(Entity.MobilePhone)
        End Function

        <Command>
        Public Sub HomeCall()
            MessageBoxService.ShowMessage("Home Call: " & Entity.HomePhone)
        End Sub

        Public Function CanHomeCall() As Boolean
            Return Entity IsNot Nothing AndAlso Not String.IsNullOrEmpty(Entity.HomePhone)
        End Function

        <Command>
        Public Sub MobileCall()
            MessageBoxService.ShowMessage("Mobile Call: " & Entity.MobilePhone)
        End Sub

        Public Function CanMobileCall() As Boolean
            Return Entity IsNot Nothing AndAlso Not String.IsNullOrEmpty(Entity.MobilePhone)
        End Function

        <Command>
        Public Sub [Call]()
            MessageBoxService.ShowMessage("Call: " & Entity.Skype)
        End Sub

        Public Function CanCall() As Boolean
            Return Entity IsNot Nothing AndAlso Not String.IsNullOrEmpty(Entity.Skype)
        End Function

        <Command>
        Public Sub VideoCall()
            MessageBoxService.ShowMessage("Video Call: " & Entity.Skype)
        End Sub

        Public Function CanVideoCall() As Boolean
            Return Entity IsNot Nothing AndAlso Not String.IsNullOrEmpty(Entity.Skype)
        End Function

        <Command>
        Public Sub MailTo()
            ExecuteMailTo(MessageBoxService, Entity.Email)
        End Sub

        Public Function CanMailTo() As Boolean
            Return Entity IsNot Nothing AndAlso Not String.IsNullOrEmpty(Entity.Email)
        End Function

        Protected Overrides Sub OnEntityChanged()
            MyBase.OnEntityChanged()
            RaiseCanExecuteChanged(Sub(x) x.Message())
            RaiseCanExecuteChanged(Sub(x) x.Phone())
            RaiseCanExecuteChanged(Sub(x) x.MobileCall())
            RaiseCanExecuteChanged(Sub(x) x.HomeCall())
            RaiseCanExecuteChanged(Sub(x) x.Call())
            RaiseCanExecuteChanged(Sub(x) x.VideoCall())
            RaiseCanExecuteChanged(Sub(x) x.MailTo())
        End Sub

        Public Shared Sub ExecuteMailTo(ByVal messageBoxService As IMessageBoxService, ByVal email As String)
            Dim mailToLink As String = "mailto://" & email
            If Not Data.Utils.SafeProcess.TryOpenHyperlink(mailToLink) AndAlso messageBoxService IsNot Nothing Then messageBoxService.ShowMessage("Mail To: " & email)
        End Sub
    End Class
End Namespace
