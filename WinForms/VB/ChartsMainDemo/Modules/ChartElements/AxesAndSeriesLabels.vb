Imports System

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class AxesAndSeriesLabelsDemo
        Inherits ChartDemoModuleWithOptions

        Private ReadOnly Property AxisResolveOverlappingOptions As AxisLabelResolveOverlappingOptions
            Get
                Dim diagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
                Return If(diagram IsNot Nothing, diagram.AxisX.Label.ResolveOverlappingOptions, Nothing)
            End Get
        End Property

        Private ReadOnly Property SeriesLabel As PointSeriesLabel
            Get
                If chart.Series.Count = 0 Then Return Nothing
                Return TryCast(chart.Series(0).Label, PointSeriesLabel)
            End Get
        End Property

        Private ReadOnly Property AxisX As AxisX
            Get
                Dim diagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
                Return If(diagram IsNot Nothing, diagram.AxisX, Nothing)
            End Get
        End Property

        Private ReadOnly Property AxisY As AxisY
            Get
                Dim diagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
                Return If(diagram IsNot Nothing, diagram.AxisY, Nothing)
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            InitControls()
        End Sub

        Private Sub InitControls()
            spinEditAxisLabelsMinIndent.Value = AxisResolveOverlappingOptions.MinIndent
            checkEditAllowStaggerAxisLabels.Checked = AxisResolveOverlappingOptions.AllowStagger
            checkEditAllowRotateAxisLabels.Checked = AxisResolveOverlappingOptions.AllowRotate
            checkEditAllowHideAxisLabels.Checked = AxisResolveOverlappingOptions.AllowHide
            spinEditSeriesLabelsMinIndent.Value = SeriesLabel.ResolveOverlappingMinIndent
            comboBoxEditSeriesLabelsResolveOverlappingMode.SelectedIndex = CInt(SeriesLabel.ResolveOverlappingMode)
            comboBoxEditAxisXLabelsPattern.SelectedIndex = 0
            comboBoxEditSeriesLabelsPattern.SelectedIndex = 0
            checkEditShowCustomLabels.Checked = True
            comboBoxEditCustomLabelsMode.SelectedIndex = 1
        End Sub

        Private Sub spinEditAxisLabelsMinIndent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If AxisResolveOverlappingOptions IsNot Nothing Then AxisResolveOverlappingOptions.MinIndent = CInt(spinEditAxisLabelsMinIndent.Value)
        End Sub

        Private Sub checkEditAllowStaggerAxisLabels_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If AxisResolveOverlappingOptions IsNot Nothing Then AxisResolveOverlappingOptions.AllowStagger = checkEditAllowStaggerAxisLabels.Checked
        End Sub

        Private Sub checkEditAllowRotateAxisLabels_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If AxisResolveOverlappingOptions IsNot Nothing Then AxisResolveOverlappingOptions.AllowRotate = checkEditAllowRotateAxisLabels.Checked
        End Sub

        Private Sub checkEditAllowHideAxisLabels_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If AxisResolveOverlappingOptions IsNot Nothing Then AxisResolveOverlappingOptions.AllowHide = checkEditAllowHideAxisLabels.Checked
        End Sub

        Private Sub spinEditSeriesLabelsMinIndent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If SeriesLabel IsNot Nothing Then SeriesLabel.ResolveOverlappingMinIndent = CInt(spinEditSeriesLabelsMinIndent.Value)
        End Sub

        Private Sub comboBoxEditSeriesLabelsResolveOverlappingMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If SeriesLabel IsNot Nothing AndAlso SeriesLabel.Position = PointLabelPosition.Outside Then SeriesLabel.ResolveOverlappingMode = CType(comboBoxEditSeriesLabelsResolveOverlappingMode.SelectedIndex, ResolveOverlappingMode)
        End Sub

        Private Sub comboBoxEditAxisXLabelsPattern_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            If AxisX IsNot Nothing Then AxisX.Label.TextPattern = comboBoxEditAxisXLabelsPattern.Text
        End Sub

        Private Sub comboBoxEditSeriesLabelsPattern_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            If SeriesLabel IsNot Nothing Then SeriesLabel.TextPattern = comboBoxEditSeriesLabelsPattern.Text
        End Sub

        Private Sub checkEditShowCustomLabels_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            comboBoxEditCustomLabelsMode.Enabled = checkEditShowCustomLabels.Checked
            If AxisY IsNot Nothing Then
                For Each label As CustomAxisLabel In AxisY.CustomLabels
                    label.Visible = checkEditShowCustomLabels.Checked
                Next
            End If
        End Sub

        Private Sub comboBoxEditCustomLabelsMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If AxisY IsNot Nothing Then AxisY.LabelVisibilityMode = CType(comboBoxEditCustomLabelsMode.SelectedIndex, AxisLabelVisibilityMode)
        End Sub
    End Class
End Namespace
