Imports DevExpress.XtraPivotGrid.Data

Namespace DevExpress.XtraPivotGrid.Demos.Helpers

    Public Class OLAPConfigurator

        Public Const CategoriesFieldName As String = "[Product].[Product Categories].[Category]"

        Public Const OrderQuantityFieldName As String = "[Measures].[Order Quantity]"

        Private connectionError As Boolean = False

        Public Shared Function ConnectToAdventureWorks(ByVal pivot As PivotGridControl, ByVal configureFields As Boolean) As Boolean
            If Not Connect(pivot) Then Return False
            If configureFields Then Call ConfigureSampleFields(pivot)
            Return True
        End Function

        Private Shared Function Connect(ByVal pivot As PivotGridControl) As Boolean
            Dim configurator As OLAPConfigurator = New OLAPConfigurator()
            Try
                AddHandler pivot.QueryException, AddressOf configurator.Pivot_QueryException
                Dim useXmla As Boolean = Not OLAPMetaGetter.IsProviderAvailable
                pivot.BeginUpdate()
                If useXmla Then
                    pivot.OLAPDataProvider = OLAPDataProvider.Xmla
                    pivot.OLAPConnectionString = OLAPConnectionDesigner.SampleXMLAConnectionString
                Else
                    pivot.OLAPDataProvider = OLAPDataProvider.OleDb
                    pivot.OLAPConnectionString = OLAPConnectionDesigner.SampleConnectionString
                End If

                pivot.EndUpdate()
            Finally
                RemoveHandler pivot.QueryException, AddressOf configurator.Pivot_QueryException
            End Try

            Dim connected As Boolean = Not configurator.connectionError
            If Not connected Then
                pivot.OLAPDataProvider = OLAPDataProvider.OleDb
                pivot.OLAPConnectionString = Nothing
                pivot.Enabled = False
            End If

            Return connected
        End Function

        Private Sub Pivot_QueryException(ByVal sender As Object, ByVal e As PivotQueryExceptionEventArgs)
            connectionError = connectionError OrElse TypeOf e.Exception Is OLAPConnectionException
        End Sub

        Public Shared Function CreateSampleAdoConfiguration(ByVal pivot As PivotGridControl) As Boolean
            If Not AdomdMetaGetter.IsProviderAvailable Then Return False
            Try
                Dim ds As PivotGridAdomdDataSource = New PivotGridAdomdDataSource()
                ds.ConnectionString = OLAPConnectionDesigner.SampleConnectionString
                pivot.DataSource = ds
            Catch __unusedOLAPConnectionException1__ As OLAPConnectionException
                pivot.DataSource = Nothing
                pivot.Enabled = False
                Return False
            End Try

            Call ConfigureSampleFields(pivot)
            Return True
        End Function

        Private Shared Sub ConfigureSampleFields(ByVal pivot As PivotGridControl)
            Call RetrieveFields(pivot)
            Dim fieldQuantity As PivotGridField = pivot.Fields(OrderQuantityFieldName)
            If fieldQuantity IsNot Nothing Then
                fieldQuantity.Visible = True
                fieldQuantity.Area = PivotArea.DataArea
            End If

            Dim fieldCategories As PivotGridField = pivot.Fields(CategoriesFieldName)
            If fieldCategories IsNot Nothing Then
                fieldCategories.Visible = True
                fieldCategories.Area = PivotArea.RowArea
            End If

            If fieldCategories IsNot Nothing AndAlso fieldQuantity IsNot Nothing Then fieldCategories.ExpandAll()
        End Sub

        Public Shared Sub RetrieveFields(ByVal pivot As PivotGridControl)
            pivot.BeginUpdate()
            pivot.RetrieveFields(PivotArea.FilterArea, False)
            For i As Integer = 0 To pivot.Fields.Count - 1
                pivot.Fields(i).SortMode = PivotSortMode.None
            Next

            pivot.EndUpdate()
        End Sub
    End Class
End Namespace
