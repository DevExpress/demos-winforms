Imports System
Imports DevExpress.XtraCharts
Imports DevExpress.Utils

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class CustomChartData
        Inherits TutorialControl

        Friend Enum RowFieldValueExportRule
            ProductName = 0
            CategoryAndProduct = 1
            CategoryEncoded = 2
        End Enum

        Private Shared categories As String() = New String() {"Beverages", "Condiments", "Confections", "Dairy Products", "Grains/Cereals", "Meat/Poultry", "Produce", "Seafood"}

        Private exportRule As RowFieldValueExportRule

        Private Property RowExportRule As RowFieldValueExportRule
            Get
                Return exportRule
            End Get

            Set(ByVal value As RowFieldValueExportRule)
                exportRule = value
            End Set
        End Property

        Public Overrides ReadOnly Property ViewOptionsControl As PivotGridControl
            Get
                Return pivotGridControl
            End Get
        End Property

        Public Overrides ReadOnly Property ExportControl As PivotGridControl
            Get
                Return pivotGridControl
            End Get
        End Property

        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
            chartControl.CrosshairOptions.ShowArgumentLine = False
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            comboChartType.Properties.Items.AddRange(New ViewType() {ViewType.Bar, ViewType.StackedBar, ViewType.FullStackedBar, ViewType.Point, ViewType.Line, ViewType.StepLine, ViewType.Spline, ViewType.Area, ViewType.SplineArea, ViewType.StackedArea, ViewType.StackedSplineArea, ViewType.FullStackedArea, ViewType.FullStackedSplineArea})
            comboChartType.SelectedItem = ViewType.Line
            RowExportRule = RowFieldValueExportRule.ProductName
            cbRowFieldValuesExportRule.Properties.Items.AddRange(New String() {"ProductName", "Category/ProductName", "Encoded Product Category"})
            cbRowFieldValuesExportRule.SelectedIndex = 0
            pivotGridControl.DataSource = GetNWindData("SalesPerson")
            CollapseValues()
            SetSelection()
            chartControl.DataSource = pivotGridControl
        End Sub

        Private Sub CollapseValues()
            fieldCategoryName.CollapseAll()
            fieldCategoryName.ExpandValue("Condiments")
            fieldYear.CollapseAll()
            fieldYear.ExpandValue(2014)
            fieldQuarter.CollapseAll()
            fieldQuarter.ExpandValue(3)
        End Sub

        Private Sub SetSelection()
            pivotGridControl.Cells.SetSelectionByFieldValues(False, New Object() {"Condiments", "Aniseed Syrup"})
            pivotGridControl.Cells.SetSelectionByFieldValues(False, New Object() {"Condiments", "Chef Anton's Cajun Seasoning"})
            pivotGridControl.Cells.SetSelectionByFieldValues(False, New Object() {"Condiments", "Chef Anton's Gumbo Mix"})
        End Sub

        '<comboChartType>
        Private Sub comboBoxEdit2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            chartControl.SeriesTemplate.ChangeView(CType(comboChartType.SelectedItem, ViewType))
        End Sub

        '</comboChartType>
        '<checkShowPointLabels>
        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            chartControl.SeriesTemplate.LabelsVisibility = If(checkShowPointLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        '</checkShowPointLabels>
        '<seCellZeroValueThreshold>
        Private Sub pivotGridControl1_CustomChartDataSourceData(ByVal sender As Object, ByVal e As PivotCustomChartDataSourceDataEventArgs)
            If e.ItemType = PivotChartItemType.CellItem Then
                If e.Value Is DBNull.Value OrElse CDec(e.Value) < Convert.ToDecimal(seCellZeroValueThreshold.Value) Then e.Value = 0
            End If

            '</seCellZeroValueThreshold>
            If e.ItemType = PivotChartItemType.RowItem Then
                Dim isCategoryNameField As Boolean = Equals(e.FieldValueInfo.Field, fieldCategoryName)
                Select Case RowExportRule
                    Case RowFieldValueExportRule.ProductName
                        If isCategoryNameField Then
                            e.Value = String.Format("{0} Category", e.FieldValueInfo.Value)
                        Else
                            e.Value = e.FieldValueInfo.Value
                        End If

                    Case RowFieldValueExportRule.CategoryAndProduct
                        If isCategoryNameField Then
                            e.Value = String.Format("{0}/Total", e.FieldValueInfo.Value)
                        Else
                            e.Value = String.Format("{0}/{1}", e.FieldValueInfo.GetHigherLevelFieldValue(fieldCategoryName), e.FieldValueInfo.Value)
                        End If

                    Case RowFieldValueExportRule.CategoryEncoded
                        Dim categoryName As String = String.Format("{0}", If(isCategoryNameField, e.FieldValueInfo.Value, e.FieldValueInfo.GetHigherLevelFieldValue(fieldCategoryName)))
                        e.Value = EncodeCategoryName(categoryName)
                End Select
            End If
        End Sub

        '<cbRowFieldValuesExportRule>
        Private Sub cbRowFieldValuesExportRule_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            RowExportRule = CType(cbRowFieldValuesExportRule.SelectedIndex, RowFieldValueExportRule)
            If RowExportRule = RowFieldValueExportRule.CategoryEncoded Then
                pivotGridControl.OptionsChartDataSource.ProvideRowFieldValuesAsType = GetType(Char)
            Else
                pivotGridControl.OptionsChartDataSource.ProvideRowFieldValuesAsType = GetType(String)
            End If
        End Sub

        '</cbRowFieldValuesExportRule>
        '<seCellZeroValueThreshold>
        Private Sub seCellZeroValueThreshold_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl.RefreshData()
        End Sub

        '</seCellZeroValueThreshold>
        Private Function EncodeCategoryName(ByVal categoryName As String) As Char
            For i As Integer = 0 To categories.Length - 1
                If Equals(categories(i), categoryName) Then Return Convert.ToChar(Convert.ToInt32("A"c) + i)
            Next

            Return "Z"c
        End Function
    End Class
End Namespace
