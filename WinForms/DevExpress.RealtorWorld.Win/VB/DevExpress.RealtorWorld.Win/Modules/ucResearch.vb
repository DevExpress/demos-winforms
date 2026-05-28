Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPivotGrid

Namespace DevExpress.RealtorWorld.Win

    Public Partial Class ucResearch
        Inherits BaseModule

        Private seasonallyAdjustedField As PivotGridField

        Private yearField As PivotGridField

        Private ReadOnly Property Diagram As XYDiagram
            Get
                Return CType(ccHousesSales.Diagram, XYDiagram)
            End Get
        End Property

        Public Overrides ReadOnly Property ModuleCaption As String
            Get
                Return "US Houses Market Research"
            End Get
        End Property

        Public Overrides ReadOnly Property ModuleName As String
            Get
                Return "Research"
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            Dim monthField As PivotGridField
            Dim regionField As PivotGridField
            pgcHousesSales.BeginUpdate()
            Try
                pgcHousesSales.DataSource = DataHelper.GetHousesSalesTable()
                yearField = New PivotGridField("Date", PivotArea.RowArea)
                yearField.Caption = "Year"
                yearField.Options.AllowExpand = DefaultBoolean.False
                yearField.Options.AllowFilter = DefaultBoolean.False
                yearField.GroupInterval = PivotGroupInterval.DateYear
                pgcHousesSales.Fields.Add(yearField)
                monthField = New PivotGridField("Date", PivotArea.RowArea)
                monthField.Caption = "Month"
                monthField.GroupInterval = PivotGroupInterval.DateMonth
                pgcHousesSales.Fields.Add(monthField)
                Dim dateGroup As PivotGridGroup = New PivotGridGroup("Date")
                dateGroup.Fields.Add(yearField)
                dateGroup.Fields.Add(monthField)
                pgcHousesSales.Groups.Add(dateGroup)
                Dim typeField As PivotGridField = New PivotGridField("Type", PivotArea.ColumnArea)
                typeField.Caption = "Status"
                typeField.Options.AllowExpand = DefaultBoolean.False
                typeField.SortOrder = PivotSortOrder.Descending
                typeField.TotalsVisibility = PivotTotalsVisibility.None
                pgcHousesSales.Fields.Add(typeField)
                seasonallyAdjustedField = New PivotGridField("SeasonallyAdjusted", PivotArea.ColumnArea)
                seasonallyAdjustedField.Caption = "Seasonally Adjusted"
                seasonallyAdjustedField.Width = 60
                pgcHousesSales.Fields.Add(seasonallyAdjustedField)
                regionField = New PivotGridField("Region", PivotArea.ColumnArea)
                pgcHousesSales.Fields.Add(regionField)
                Dim typeGroup As PivotGridGroup = New PivotGridGroup("Type")
                typeGroup.Fields.Add(seasonallyAdjustedField)
                typeGroup.Fields.Add(regionField)
                pgcHousesSales.Groups.Add(typeGroup)
                pgcHousesSales.Fields.Add(New PivotGridField("Count", PivotArea.DataArea))
            Finally
                pgcHousesSales.EndUpdate()
            End Try

            yearField.BestFit()
            monthField.BestFit()
            regionField.BestFit()
        End Sub

        Private Sub ccHousesSales_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
            If ccHousesSales.Series.Count = 0 Then Return
            ccHousesSales.BeginInit()
            Try
                Dim seriesNames As List(Of String) = New List(Of String)()
                Dim colors As PaletteEntry() = ccHousesSales.GetPaletteEntries(10)
                Dim panes As Dictionary(Of String, XYDiagramPaneBase) = New Dictionary(Of String, XYDiagramPaneBase)()
                For Each pane As XYDiagramPane In Diagram.Panes
                    pane.Visibility = ChartElementVisibility.Hidden
                Next

                For Each axisY As SecondaryAxisY In Diagram.SecondaryAxesY
                    axisY.Visibility = DefaultBoolean.False
                    axisY.GridLines.Visible = False
                    axisY.GridLines.MinorVisible = False
                Next

                For Each series As Series In ccHousesSales.Series
                    Dim splittedName As String() = series.Name.TrimEnd().Split(New Char() {"|"c}, StringSplitOptions.RemoveEmptyEntries)
                    Dim name As String = If(splittedName.Length = 3, splittedName(2), "All Regions")
                    Dim key As String = splittedName(0).Trim() & " (" & splittedName(1).Trim() & ")"
                    If seriesNames.Contains(name) Then
                        CType(series.View, LineSeriesView).Color = colors(seriesNames.IndexOf(name)).Color
                        series.ShowInLegend = False
                    Else
                        seriesNames.Add(name)
                        CType(series.View, LineSeriesView).Color = colors(seriesNames.Count - 1).Color
                    End If

                    series.Name = name
                    Dim currentPane As XYDiagramPaneBase = Nothing
                    If panes.Keys.Count = 0 Then
                        panes.Add(key, Diagram.DefaultPane)
                        CType(ccHousesSales.Annotations(0), TextAnnotation).Text = key
                    ElseIf panes.TryGetValue(key, currentPane) Then
                        UptadeSeries(series, currentPane, GetAxisY(currentPane))
                    Else
                        Dim paneIndex As Integer
                        For paneIndex = 0 To Diagram.Panes.Count - 1
                            If Not panes.ContainsValue(Diagram.Panes(paneIndex)) Then Exit For
                        Next

                        Dim pane As XYDiagramPane = Diagram.Panes(paneIndex)
                        pane.Visibility = ChartElementVisibility.Hidden
                        panes.Add(key, pane)
                        Dim axis As SecondaryAxisY = Diagram.SecondaryAxesY(paneIndex)
                        axis.GridLines.Visible = True
                        axis.GridLines.MinorVisible = True
                        axis.Visibility = DefaultBoolean.True
                        UptadeSeries(series, pane, axis)
                        CType(ccHousesSales.Annotations(paneIndex + 1), TextAnnotation).Text = key
                    End If
                Next
            Finally
                ccHousesSales.EndInit()
            End Try
        End Sub

        Private Sub ccHousesSales_CustomizeAutoBindingSettings(ByVal sender As Object, ByVal e As EventArgs)
            If yearField Is Nothing Then Return
            Diagram.AxisX.DateTimeScaleOptions.MeasureUnit = If(yearField.ExpandedInFieldsGroup, DateTimeMeasureUnit.Month, DateTimeMeasureUnit.Year)
            Diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Year
            Diagram.AxisX.Label.TextPattern = "{A:yyyy}"
        End Sub

        Private Sub pgcHousesSales_FieldValueDisplayText(ByVal sender As Object, ByVal e As PivotFieldDisplayTextEventArgs)
            If e.ValueType = PivotGridValueType.Total AndAlso e.Field.Equals(seasonallyAdjustedField) Then e.DisplayText = "Total"
        End Sub

        Private Sub pgcHousesSales_GridLayout(ByVal sender As Object, ByVal e As EventArgs)
            Cursor.Current = Cursors.WaitCursor
        End Sub

        Private Sub UptadeSeries(ByVal series As Series, ByVal pane As XYDiagramPaneBase, ByVal axis As AxisYBase)
            Dim view As XYDiagramSeriesViewBase = CType(series.View, XYDiagramSeriesViewBase)
            view.AxisY = axis
            view.Pane = pane
        End Sub

        Private Function GetAxisY(ByVal currentPane As XYDiagramPaneBase) As AxisYBase
            For i As Integer = 0 To Diagram.Panes.Count - 1
                If Diagram.Panes(i) Is currentPane Then Return Diagram.SecondaryAxesY(i)
            Next

            Return Diagram.AxisY
        End Function
    End Class
End Namespace
