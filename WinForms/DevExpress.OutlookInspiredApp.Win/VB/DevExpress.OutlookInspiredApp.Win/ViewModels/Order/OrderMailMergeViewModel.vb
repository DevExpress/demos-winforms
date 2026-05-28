Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.ViewModels

    Public Class OrderMailMergeViewModel
        Inherits MailMergeViewModelBase(Of SalesReportType)

        Private unitOfWork As IDevAVDbUnitOfWork

        Public Shared Function Create() As OrderMailMergeViewModel
            Return ViewModelSource.Create(Function() New OrderMailMergeViewModel())
        End Function

        Protected Sub New()
            unitOfWork = GetUnitOfWorkFactory().CreateUnitOfWork()
        End Sub

        Public Overridable Property Period As OrderMailMergePeriod?

        <Command>
        Public Sub SetThisMonthPeriod()
            Period = OrderMailMergePeriod.ThisMonth
        End Sub

        Public Function CanSetThisMonthPeriod() As Boolean
            Return Period.HasValue AndAlso Period.Value <> OrderMailMergePeriod.ThisMonth
        End Function

        <Command>
        Public Sub SetLastMonthPeriod()
            Period = OrderMailMergePeriod.LastMonth
        End Sub

        Public Function CanSetLastMonthPeriod() As Boolean
            Return Period.HasValue AndAlso Period.Value <> OrderMailMergePeriod.LastMonth
        End Function

        Protected Overridable Sub OnPeriodChanged()
            RaiseCanExecuteChanged(Sub(x) x.SetThisMonthPeriod())
            RaiseCanExecuteChanged(Sub(x) x.SetLastMonthPeriod())
            RaisePeriodChanged()
        End Sub

        Public Function GetOrderItems() As IList(Of OrderItem)
            Return unitOfWork.OrderItems.ToList()
        End Function

        Public Event PeriodChanged As EventHandler

        Private Sub RaisePeriodChanged()
            Dim handler As EventHandler = PeriodChangedEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub
    End Class

    Public Enum OrderMailMergePeriod
        ThisMonth
        LastMonth
    End Enum
End Namespace
