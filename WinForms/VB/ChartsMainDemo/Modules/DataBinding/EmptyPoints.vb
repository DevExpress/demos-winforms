Imports System
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class EmptyPointsDemo
        Inherits ChartDemoModuleWithOptions

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            chart.DataSource = Data
            PaletteName = Palettes.BlueGreen.Name
            InitRadioGroup()
            UpdateEmptyPointOptions()
        End Sub

        Private Sub InitRadioGroup()
            radioGroupSeriesView.Properties.Items.AddRange(New RadioGroupItem() {New RadioGroupItem(New ViewType() {ViewType.Point, ViewType.StepLine, ViewType.Area}, "Point, Step Line and Area"), New RadioGroupItem(New ViewType() {ViewType.Line, ViewType.Bar, ViewType.RangeBar}, "Line, Bar and Range Bar"), New RadioGroupItem(New ViewType() {ViewType.Spline, ViewType.StepArea, ViewType.RangeArea}, "Spline, Step Area and Range Area")})
            radioGroupSeriesView.SelectedIndex = 0
        End Sub

        Private Sub radioGroup_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim viewTypes As ViewType() = CType(radioGroupSeriesView.EditValue, ViewType())
            If viewTypes Is Nothing OrElse viewTypes.Length <> chart.Series.Count Then Return
            For i As Integer = 0 To chart.Series.Count - 1
                Dim series As Series = chart.Series(i)
                Dim viewType As ViewType = viewTypes(i)
                series.ChangeView(viewType)
                If i = chart.Series.Count - 1 Then
                    If viewType = ViewType.RangeArea OrElse viewType = ViewType.RangeBar Then
                        series.ValueDataMembers.Clear()
                        series.ValueDataMembers.AddRange("DayTemperature", "NightTemperature")
                        series.CrosshairLabelPattern = "{S}: Day {V1}°C, Night {V2}°C"
                    Else
                        series.CrosshairLabelPattern = "{S}: {V}°C"
                    End If
                End If
            Next

            UpdateEmptyPointOptions()
            ChartControl.Animate()
        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateEmptyPointOptions()
        End Sub

        Private Sub UpdateEmptyPointOptions()
            Dim styleEnabled As Boolean = checkEdit1.Checked
            Dim palette As Palette = chart.PaletteRepository(chart.PaletteName)
            For i As Integer = 0 To chart.Series.Count - 1
                Dim paletteEntry As PaletteEntry = palette(i)
                Dim series As Series = chart.Series(i)
                Dim view As XYDiagramSeriesViewBase = CType(series.View, XYDiagramSeriesViewBase)
                Dim emptyPointOptions As EmptyPointOptions = view.EmptyPointOptions
                emptyPointOptions.ProcessPoints = ProcessEmptyPointsMode.Interpolate
                If styleEnabled Then
                    emptyPointOptions.Color = Color.FromArgb(100, paletteEntry.Color)
                    If TypeOf emptyPointOptions Is LineEmptyPointOptions Then
                        Dim lineOptions As LineEmptyPointOptions = CType(emptyPointOptions, LineEmptyPointOptions)
                        lineOptions.LineStyle.DashStyle = DashStyle.Dash
                        lineOptions.LineStyle.Thickness = CType(view, LineSeriesView).LineStyle.Thickness
                    ElseIf TypeOf emptyPointOptions Is AreaEmptyPointOptions Then
                        Dim areaOptions As AreaEmptyPointOptions = CType(emptyPointOptions, AreaEmptyPointOptions)
                        areaOptions.Border.Color = paletteEntry.Color
                    End If
                Else
                    emptyPointOptions.Color = Color.Empty
                End If
            Next
        End Sub
    End Class
End Namespace
