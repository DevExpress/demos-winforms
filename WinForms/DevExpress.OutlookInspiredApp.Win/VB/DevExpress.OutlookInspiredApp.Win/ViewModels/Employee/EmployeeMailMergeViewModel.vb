Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.ViewModels

    Public Class EmployeeMailMergeViewModel
        Inherits MailMergeViewModelBase(Of EmployeeMailTemplate)

        Public Shared Function Create() As EmployeeMailMergeViewModel
            Return ViewModelSource.Create(Function() New EmployeeMailMergeViewModel())
        End Function

        Protected Sub New()
        End Sub
    End Class
End Namespace
