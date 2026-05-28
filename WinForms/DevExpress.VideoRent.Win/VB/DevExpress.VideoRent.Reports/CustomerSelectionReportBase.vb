Imports DevExpress.XtraReports.Parameters
Imports System.Collections.Generic

Namespace DevExpress.VideoRent.Reports
    Partial Public Class CustomerSelectionReportBase
        Inherits ReportBase
        Private isParameterInitialized As Boolean = False
        Private Const customerListParameterName As String = "customerListParameter"
        Private Const customerLimit As Integer = 5

        Public Sub New()
            InitializeComponent()
            Dim customerListParameter As New Parameter()
            customerListParameter.Name = customerListParameterName
            customerListParameter.Type = GetType(String)
            customerListParameter.Description = "Customers:"
            customerListParameter.MultiValue = True
            Dim settings As New DynamicListLookUpSettings() With {
                .DataSource = xpCollectionCustomers,
                .DisplayMember = "FullNameLastSorting",
                .ValueMember = "FullNameLastSorting"}
            customerListParameter.LookUpSettings = settings

            Parameters.Add(customerListParameter)
            FilterString = "[FullNameLastSorting] In (?" & customerListParameterName & ")"
        End Sub

        Protected Overrides Sub OnParametersRequestBeforeShow(ByVal e As ParametersRequestEventArgs)
            MyBase.OnParametersRequestBeforeShow(e)

            If (Not isParameterInitialized) AndAlso xpCollectionCustomers.Session IsNot Nothing Then
                Dim customerCount As Integer = 0
                Dim customers As New List(Of String)()

                For Each customer As Customer In xpCollectionCustomers
                    customers.Add(customer.FullNameLastSorting)
                    customerCount = customerCount + 1
                    If customerCount = customerLimit Then
                        Exit For
                    End If
                Next customer

                Parameters(customerListParameterName).Value = customers.ToArray()
                isParameterInitialized = True
            End If
        End Sub

        Private Sub xpCollectionCustomers_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpCollectionCustomers.ResolveSession
            e.Session = Session
        End Sub
    End Class
End Namespace
