Imports System
Imports System.Linq
Imports DevExpress.Data.Filtering

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class BindingIndividualSeriesDemo
        Inherits ChartDemoModuleWithOptions

        Private chart As ChartControl

        Private ReadOnly Property DevAVNorthDataAdapter As SummaryDataAdapter
            Get
                Return CType(chart.Series(0).DataAdapter, SummaryDataAdapter)
            End Get
        End Property

        Private ReadOnly Property DevAVSouthDataAdapter As SummaryDataAdapter
            Get
                Return CType(chart.Series(1).DataAdapter, SummaryDataAdapter)
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            chart.BeginInit()
            DevAVNorthDataAdapter.DataSource = SaleItem.GetProductsByCompany(0)
            gridControl1.DataSource = DevAVNorthDataAdapter.DataSource
            gridControl1.ForceInitialize()
            DevAVSouthDataAdapter.DataSource = SaleItem.GetProductsByCompany(1)
            gridControl2.DataSource = DevAVSouthDataAdapter.DataSource
            gridControl2.ForceInitialize()
            chart.EndInit()
        End Sub

        Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
            ChartControl.Animate()
        End Sub

        Private Sub comboBoxEditFilterBy_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If comboBoxEditFilterBy.SelectedIndex = -1 Then Return
            Dim filterCriteria As BinaryOperator = If(comboBoxEditFilterBy.SelectedIndex <> 0, New BinaryOperator("Category", comboBoxEditFilterBy.Text, BinaryOperatorType.Equal), Nothing)
            DevAVNorthDataAdapter.FilterCriteria = filterCriteria
            DevAVSouthDataAdapter.FilterCriteria = filterCriteria
        End Sub

        Private Sub comboBoxEditSortOrdering_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If comboBoxEditSortOrdering.SelectedIndex = -1 Then Return
            Dim sortingMode As SortingMode = CType(comboBoxEditSortOrdering.SelectedIndex, SortingMode)
            For Each series As Series In chart.Series
                series.SeriesPointsSorting = sortingMode
            Next

            lciNorthSortingKey.Enabled = Not sortingMode.Equals(SortingMode.None)
        End Sub

        Private Sub comboBoxEditSortBy_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If chart.Series.Count < 2 Then Return
            Dim sortingMode As SortingMode = CType(comboBoxEditSortOrdering.SelectedIndex, SortingMode)
            Select Case comboBoxEditSortBy.SelectedIndex
                Case 0
                    UpdateSeriesSorting(sortingMode, SeriesPointKey.Argument, 0, 1)
                Case 1
                    UpdateSeriesSorting(sortingMode, SeriesPointKey.Value_1, 0, 1)
                Case 2
                    UpdateSeriesSorting(sortingMode, SeriesPointKey.Value_1, 1, 0)
                Case Else
            End Select
        End Sub

        Private Sub comboBoxEditArgumentDataMember_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If comboBoxEditArgumentDataMember.SelectedIndex = -1 Then Return
            DevAVNorthDataAdapter.DataMembers(ChartDataMemberType.Argument) = comboBoxEditArgumentDataMember.Text
            DevAVSouthDataAdapter.DataMembers(ChartDataMemberType.Argument) = comboBoxEditArgumentDataMember.Text
        End Sub

        Private Sub comboBoxEditValueDataMember_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If comboBoxEditValueDataMember.SelectedIndex = -1 Then Return
            UpdateValueDataMember(DevAVNorthDataAdapter)
            UpdateValueDataMember(DevAVSouthDataAdapter)
        End Sub

        Private Sub UpdateValueDataMember(ByVal adapter As SummaryDataAdapter)
            adapter.DataMembers(ChartDataMemberType.Value) = comboBoxEditValueDataMember.Text
            adapter.QualitativeSummaryOptions.SummaryFunction = String.Format("SUM([{0}])", comboBoxEditValueDataMember.Text)
        End Sub

        Private Sub OnGridViewSelectionChanged(ByVal sender As Object, ByVal e As Data.SelectionChangedEventArgs)
            Dim selectedObjects As Object() = gridView1.GetSelectedRows().[Select](Function(row) gridView1.GetRow(row)).Union(gridView2.GetSelectedRows().[Select](Function(row) gridView2.GetRow(row))).ToArray()
            chart.ReplaceSelectedItems(selectedObjects)
        End Sub

        Private Sub UpdateSeriesSorting(ByVal sortingMode As SortingMode, ByVal sortingKey As SeriesPointKey, ByVal applySeriesIndex As Integer, ByVal resetSeriesIndex As Integer)
            chart.Series(resetSeriesIndex).SeriesPointsSorting = SortingMode.None
            chart.Series(applySeriesIndex).SeriesPointsSorting = sortingMode
            chart.Series(applySeriesIndex).SeriesPointsSortingKey = sortingKey
        End Sub
    End Class
End Namespace
