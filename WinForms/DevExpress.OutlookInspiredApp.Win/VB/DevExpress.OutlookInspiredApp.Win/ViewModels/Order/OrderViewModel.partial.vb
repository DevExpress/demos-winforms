Imports System
Imports System.Collections.Generic
Imports DevExpress.DevAV.Reports.Spreadsheet
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.ViewModels

    Partial Class OrderViewModel

        Public Event CustomizeFilter As EventHandler

        Public Event EntityChanged As EventHandler

        Private Sub RaiseCustomizeFilter()
            Dim handler As EventHandler = CustomizeFilterEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

        Protected Overrides Function GetTitle() As String
            Return String.Format("Invoice# {0}", Entity.InvoiceNumber)
        End Function

        Private Sub RaiseEntityChanged()
            Dim handler As EventHandler = EntityChangedEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

        Public ReadOnly Property OrderCollectionViewModel As OrderCollectionViewModel
            Get
                Return GetParentViewModel(Of OrderCollectionViewModel)()
            End Get
        End Property

        Public ReadOnly Property MasterEntity As Order
            Get
                Return If(OrderCollectionViewModel IsNot Nothing, OrderCollectionViewModel.SelectedEntity, Nothing)
            End Get
        End Property

        Protected Function CanEdit() As Boolean
            Return MasterEntity IsNot Nothing
        End Function

        Public Sub Edit()
            OrderCollectionViewModel.Edit(MasterEntity)
            RaiseCustomizeFilter()
        End Sub

        Public Overrides Function CanDelete() As Boolean
            Return MasterEntity IsNot Nothing
        End Function

        Public Overrides Sub Delete()
            OrderCollectionViewModel.Delete(MasterEntity)
        End Sub

        Protected Function CanIssueFullRefund() As Boolean
            Return MasterEntity IsNot Nothing AndAlso MasterEntity.RefundTotal < MasterEntity.PaymentTotal
        End Function

        Public Sub IssueFullRefund()
            MasterEntity.RefundTotal = MasterEntity.PaymentTotal
            OrderCollectionViewModel.Save(MasterEntity)
        End Sub

        Public Overridable Property IssueFullRefundToolTip As String

        Protected Function CanMarkPaid() As Boolean
            Return MasterEntity IsNot Nothing AndAlso MasterEntity.PaymentTotal < MasterEntity.TotalAmount
        End Function

        Public Sub MarkPaid()
            MasterEntity.PaymentTotal = MasterEntity.TotalAmount
            OrderCollectionViewModel.Save(MasterEntity)
        End Sub

        Public Overridable Property MarkPaidToolTip As String

        Protected Function CanMailTo() As Boolean
            Return Entity IsNot Nothing
        End Function

        Public Sub MailTo()
            EmployeeContactsViewModel.ExecuteMailTo(MessageBoxService, Entity.Employee.Email)
        End Sub

        Protected Function CanPrint() As Boolean
            Return OrderCollectionViewModel IsNot Nothing
        End Function

        Public Sub Print()
            OrderCollectionViewModel.PrintInvoice()
        End Sub

        Protected Overrides Sub OnEntityChanged()
            MyBase.OnEntityChanged()
            RaiseEntityChanged()
        End Sub

        Protected Overrides Sub UpdateCommands()
            MyBase.UpdateCommands()
            RaiseCanExecuteChanged(Sub(x) x.Edit())
            RaiseCanExecuteChanged(Sub(x) x.MailTo())
            RaiseCanExecuteChanged(Sub(x) x.Print())
            RaiseCanExecuteChanged(Sub(x) x.MarkPaid())
            RaiseCanExecuteChanged(Sub(x) x.IssueFullRefund())
            MarkPaidToolTip = If(CanMarkPaid(), "Mark as Paid", "Paid")
            IssueFullRefundToolTip = If(CanIssueFullRefund(), "Issue Full Refund", "Refund Issued")
        End Sub

        <Command(False)>
        Public Function CreateOrderItem() As OrderItem
            Return UnitOfWork.OrderItems.Create()
        End Function

        <Command(False)>
        Public Sub AddOrderItem(ByVal orderItem As OrderItem)
            UnitOfWork.OrderItems.Add(orderItem)
        End Sub

        <Command(False)>
        Public Sub RemoveOrderItem(ByVal orderItem As OrderItem)
            UnitOfWork.OrderItems.Remove(orderItem)
        End Sub

        <Command(False)>
        Public Function GetCustomerStores(ByVal customerId As Long?) As IEnumerable(Of CustomerStore)
            Return UnitOfWork.CustomerStores.Where(Function(x) Nullable.Equals(x.CustomerId, customerId))
        End Function

        <Command(False)>
        Public Function CreateInvoiceDataSource() As Tuple(Of OrderCollections, Order)
            Dim collections = New OrderCollections()
            collections.Customers = UnitOfWork.Customers
            collections.Products = UnitOfWork.Products
            collections.Employees = UnitOfWork.Employees
            collections.CustomerStores = GetCustomerStores(Entity.CustomerId)
            Return New Tuple(Of OrderCollections, Order)(collections, Entity)
        End Function

        Public Overrides Function CanSave() As Boolean
            Return MyBase.CanSave() AndAlso Entity.OrderItems.Count > 0
        End Function
    End Class

    Public Partial Class SynchronizedOrderViewModel
        Inherits OrderViewModel

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
