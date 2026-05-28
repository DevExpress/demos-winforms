Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class SecondaryAxesDemo
        Inherits ChartDemoModuleWithOptions

        Private ReadOnly Property Diagram As XYDiagram
            Get
                Return TryCast(ChartControl.Diagram, XYDiagram)
            End Get
        End Property

        Private ReadOnly Property SecondaryAxisX As SecondaryAxisX
            Get
                Return If(Diagram IsNot Nothing AndAlso Diagram.SecondaryAxesX.Count > 0, Diagram.SecondaryAxesX(0), Nothing)
            End Get
        End Property

        Private ReadOnly Property SecondaryAxisY As SecondaryAxisY
            Get
                Return If(Diagram IsNot Nothing AndAlso Diagram.SecondaryAxesY.Count > 0, Diagram.SecondaryAxesY(0), Nothing)
            End Get
        End Property

        Private ReadOnly Property PrimaryAxisX As AxisX
            Get
                Return If(Diagram IsNot Nothing, Diagram.AxisX, Nothing)
            End Get
        End Property

        Private ReadOnly Property PrimaryAxisY As AxisY
            Get
                Return If(Diagram IsNot Nothing, Diagram.AxisY, Nothing)
            End Get
        End Property

        Private ReadOnly Property SecondSeriesView As XYDiagramSeriesViewBase
            Get
                Dim secondSeries As Series = If(ChartControl.Series.Count > 1, ChartControl.Series(1), Nothing)
                Return If(secondSeries IsNot Nothing, TryCast(secondSeries.View, XYDiagramSeriesViewBase), Nothing)
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            If Diagram Is Nothing Then Return
            ChartControl.BeginInit()
            Diagram.SecondaryAxesX.Add(New SecondaryAxisX("Secondary Axis X"))
            Diagram.SecondaryAxesY.Add(New SecondaryAxisY("Secondary Axis Y"))
            ChartControl.EndInit()
            Dim items As RadioGroupItemCollection = radioGroupChartType.Properties.Items
            items.Add(New RadioGroupItem(ViewType.Line, "Line"))
            items.Add(New RadioGroupItem(ViewType.Bar, "Bar"))
            radioGroupChartType.SelectedIndex = 0
            items = radioGroupSeries2AxisX.Properties.Items
            items.Add(New RadioGroupItem(Nothing, "Primary Axis X"))
            items.Add(New RadioGroupItem(Nothing, "Secondary Axis X"))
            radioGroupSeries2AxisX.SelectedIndex = 0
            items = radioGroupSeries2AxisY.Properties.Items
            items.Add(New RadioGroupItem(Nothing, "Primary Axis Y"))
            items.Add(New RadioGroupItem(Nothing, "Secondary Axis Y"))
            radioGroupSeries2AxisY.SelectedIndex = 1
        End Sub

        Private Sub AttachSecondaryAxisX()
            If PrimaryAxisX Is Nothing OrElse SecondSeriesView Is Nothing OrElse SecondaryAxisX Is Nothing Then Return
            SecondSeriesView.AxisX = SecondaryAxisX
            SecondaryAxisX.Visibility = DefaultBoolean.True
            PrimaryAxisX.Title.Text = "Series 1 Axis X (Primary)"
            SecondaryAxisX.Title.Visibility = DefaultBoolean.True
            SecondaryAxisX.Title.Text = "Series 2 Axis X (Secondary)"
        End Sub

        Private Sub AttachSecondaryAxisY()
            If PrimaryAxisY Is Nothing OrElse SecondSeriesView Is Nothing OrElse SecondaryAxisY Is Nothing Then Return
            SecondSeriesView.AxisY = SecondaryAxisY
            SecondaryAxisY.Visibility = DefaultBoolean.True
            Diagram.AxisY.Title.Text = "Series 1 Axis Y (Primary)"
            SecondaryAxisY.Title.Visibility = DefaultBoolean.True
            SecondaryAxisY.Title.Text = "Series 2 Axis Y (Secondary)"
        End Sub

        Private Sub DetachSecondaryAxisX()
            If SecondaryAxisX Is Nothing OrElse SecondSeriesView Is Nothing OrElse PrimaryAxisX Is Nothing Then Return
            SecondaryAxisX.Visibility = DefaultBoolean.False
            SecondSeriesView.AxisX = Diagram.AxisX
            PrimaryAxisX.Title.Text = "Series 1 and Series 2 Axis X (Primary)"
        End Sub

        Private Sub DetachSecondaryAxisY()
            If SecondaryAxisY Is Nothing OrElse SecondSeriesView Is Nothing OrElse PrimaryAxisY Is Nothing Then Return
            SecondaryAxisY.Visibility = DefaultBoolean.False
            SecondSeriesView.AxisY = Diagram.AxisY
            PrimaryAxisY.Title.Text = "Series 1 and Series 2 Axis Y (Primary)"
        End Sub

        Private Sub radioGroupChartType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            For Each series As Series In ChartControl.Series
                series.ChangeView(CType(radioGroupChartType.EditValue, ViewType))
            Next
        End Sub

        Private Sub radioGroupSeries2AxisX_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If radioGroupSeries2AxisX.SelectedIndex = 0 Then
                DetachSecondaryAxisX()
            Else
                AttachSecondaryAxisX()
            End If
        End Sub

        Private Sub radioGroupSeries2AxisY_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If radioGroupSeries2AxisY.SelectedIndex = 0 Then
                DetachSecondaryAxisY()
            Else
                AttachSecondaryAxisY()
            End If
        End Sub
    End Class
End Namespace
