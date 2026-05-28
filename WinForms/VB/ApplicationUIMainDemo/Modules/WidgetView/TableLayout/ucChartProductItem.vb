Imports System
Imports System.ComponentModel
Imports System.Drawing

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class ucChartProductItem
        Inherits XtraEditors.XtraUserControl

        Public Sub New()
            InitializeComponent()
            AddHandler SalesPerformanceDataGenerator.Current.UpdateDataSource, AddressOf OnUpdateDataSource
            monthlySalesItemBindingSource.DataSource = SalesPerformanceDataGenerator.Current.MonthlySales
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
                If SalesPerformanceDataGenerator.IsCurrentDataGeneratorExist Then RemoveHandler SalesPerformanceDataGenerator.Current.UpdateDataSource, AddressOf OnUpdateDataSource
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub OnUpdateDataSource(ByVal sender As Object, ByVal e As EventArgs)
            monthlySalesItemBindingSource.DataSource = SalesPerformanceDataGenerator.Current.MonthlySales
        End Sub
    End Class
End Namespace
