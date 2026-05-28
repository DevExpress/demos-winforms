Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class UsingSeriesTemplatesDemo
        Inherits ChartDemoModuleWithOptions

        Private Shared Function CalcStdDev(ByVal series As Series, ByVal argument As Object, ByVal functionArguments As String(), ByVal values As DataSourceValues(), ByVal colors As Object()) As SeriesPoint()
            Dim amount As Double() = New Double(values.Length - 1) {}
            Dim sum As Double = 0.0
            For i As Integer = 0 To values.Length - 1
                amount(i) = Convert.ToDouble(values(i)(functionArguments(0)))
                sum += amount(i)
            Next

            Dim averageAmount As Double = sum / values.Length
            Dim standardDeviationSquareSum As Double = 0.0
            For i As Integer = 0 To values.Length - 1
                Dim deviation As Double = amount(i) - averageAmount
                standardDeviationSquareSum += deviation * deviation
            Next

            Return New SeriesPoint() {New SeriesPoint(argument, Math.Sqrt(standardDeviationSquareSum / values.Length))}
        End Function

        Private ReadOnly dataMembers As String() = New String() {"Product", "Company", "Month"}

        Private ReadOnly Property SummaryDataAdapter As SeriesTemplateSummaryAdapter
            Get
                Return CType(chart.SeriesTemplate.DataAdapter, SeriesTemplateSummaryAdapter)
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            ChartControl.BeginInit()
            SummaryDataAdapter.QualitativeSummaryOptions.SummaryFunction = String.Format("SUM([{0}])", comboBoxEditValueDataMember.Text)
            Dim data As List(Of SaleItem) = SaleItem.GetProductsByMonths()
            ChartControl.DataSource = data
            gridControl.DataSource = data
            gridControl.ForceInitialize()
            gridView.BestFitColumns()
            Dim argumentDescription As SummaryFunctionArgumentDescription = New SummaryFunctionArgumentDescription("Month", ScaleType.Numerical)
            ChartControl.RegisterSummaryFunction("STDDEV", "STDDEV", 1, New SummaryFunctionArgumentDescription() {argumentDescription}, New SummaryFunction(AddressOf CalcStdDev))
            ChartControl.EndInit()
        End Sub

        Private Sub comboBoxEditSeriesDataMember_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If comboBoxEditSeriesDataMember.SelectedIndex = -1 Then Return
            Dim seriesDataMember As String = comboBoxEditSeriesDataMember.Text
            SummaryDataAdapter.DataMembers(ChartDataMemberType.Series) = seriesDataMember
            Dim needUpdateSelectedItem As Boolean = Equals(seriesDataMember, comboBoxEditArgumentDataMember.Text)
            comboBoxEditArgumentDataMember.Properties.Items.Clear()
            For Each member As String In dataMembers
                If Not Equals(member, seriesDataMember) Then comboBoxEditArgumentDataMember.Properties.Items.Add(member)
            Next

            If needUpdateSelectedItem Then comboBoxEditArgumentDataMember.SelectedIndex = 0
            chart.Legend.Title.Text = seriesDataMember
        End Sub

        Private Sub comboBoxEditArgumentDataMember_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            SummaryDataAdapter.DataMembers(ChartDataMemberType.Argument) = comboBoxEditArgumentDataMember.Text
        End Sub

        Private Sub comboBoxEditValueDataMember_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            SummaryDataAdapter.DataMembers(ChartDataMemberType.Value) = comboBoxEditValueDataMember.Text
            comboBoxEditSummaryFunction.SelectedIndex = 0
            SummaryDataAdapter.QualitativeSummaryOptions.SummaryFunction = String.Format("SUM([{0}])", comboBoxEditValueDataMember.Text)
        End Sub

        Private Sub comboBoxEditSummaryFunction_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim functionName As String = CStr(comboBoxEditSummaryFunction.EditValue)
            Dim suffixIndex As Integer = functionName.IndexOf(" (Custom)")
            If suffixIndex >= 0 Then functionName = functionName.Substring(0, suffixIndex)
            Dim isSTDDEVFunction As Boolean = False
            Select Case functionName
                Case "SUM"
                    SetTitleText("Sales Volume")
                    SetAxisYTitle("Volume (USD)")
                Case "MIN"
                    SetTitleText("Minimal Order Amount")
                    SetAxisYTitle("Amount (USD)")
                Case "MAX"
                    SetTitleText("Maximal Order Amount")
                    SetAxisYTitle("Amount (USD)")
                Case "AVERAGE"
                    SetTitleText("Average Order Amount")
                    SetAxisYTitle("Amount (USD)")
                Case "STDDEV"
                    SetTitleText("Standard Deviation from Average Order Amount")
                    SetAxisYTitle("Deviation (USD)")
                    isSTDDEVFunction = True
            End Select

            SummaryDataAdapter.QualitativeSummaryOptions.SummaryFunction = String.Format("{0}([{1}])", functionName, comboBoxEditValueDataMember.Text)
            chart.SeriesTemplate.CrosshairLabelPattern = If(isSTDDEVFunction, "{S:yyyy-MM-dd}: {V:F2}", "{S:yyyy-MM-dd}: {V:#.##}")
            ChartControl.Animate()
        End Sub

        Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
            If comboBoxEditSeriesDataMember.SelectedIndex = 2 Then
                For Each series As Series In chart.Series
                    Dim dt As Date
                    If Date.TryParse(series.Name, dt) Then series.Name = dt.ToString("yyyy-MM-dd")
                Next
            End If
        End Sub

        Private Sub gridView_SelectionChanged(ByVal sender As Object, ByVal e As Data.SelectionChangedEventArgs)
            Dim selectedObjects As Object() = gridView.GetSelectedRows().[Select](Function(row) gridView.GetRow(row)).ToArray()
            chart.ReplaceSelectedItems(selectedObjects)
        End Sub

        Private Sub SetTitleText(ByVal text As String)
            If chart.Titles.Count > 0 Then chart.Titles(0).Text = text
        End Sub

        Private Sub SetAxisYTitle(ByVal text As String)
            Dim diagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
            If diagram IsNot Nothing Then diagram.AxisY.Title.Text = text
        End Sub
    End Class
End Namespace
