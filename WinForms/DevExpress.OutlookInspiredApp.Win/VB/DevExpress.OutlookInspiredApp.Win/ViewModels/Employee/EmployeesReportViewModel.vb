Imports System.Linq
Imports System.Collections.Generic
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.ViewModels

    Public Class EmployeesReportViewModel
        Inherits ReportViewModelBaseType1(Of EmployeeReportType, Employee, Long, IDevAVDbUnitOfWork)

        Private unitOfWork As IDevAVDbUnitOfWork

        Public Shared Function Create() As EmployeesReportViewModel
            Return ViewModelSource.Create(Function() New EmployeesReportViewModel())
        End Function

        Protected Sub New()
            unitOfWork = GetUnitOfWorkFactory().CreateUnitOfWork()
        End Sub

        Public ReadOnly Property Tasks As IList(Of EmployeeTask)
            Get
                Return unitOfWork.Tasks.ToList()
            End Get
        End Property
    End Class
End Namespace
