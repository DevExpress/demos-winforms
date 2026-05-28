Imports System
Imports System.Drawing
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class TitlesDemo
        Inherits ChartDemoModuleWithOptions

        Private selectedTitle As Title = Nothing

        Private ReadOnly Property TemplatePieView As PieSeriesView
            Get
                Return TryCast(ChartControl.SeriesTemplate.View, PieSeriesView)
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
            ChartControl.DataSource = DevAV.GetSalesMixByRegion()
            comboBoxEditSeriesView.SelectedIndex = 0
            ChartControl.SetObjectSelection(ChartControl.Titles(0))
            SetSeriesTitles()
            ChartControl.EndInit()
        End Sub

        Private Sub UpdateChartControl()
            If ChartControl.Series.Count > 0 AndAlso TypeOf ChartControl.Series(0).View Is PieSeriesView Then
                For i As Integer = 1 To ChartControl.Series.Count - 1
                    ChartControl.Series(i).ShowInLegend = False
                Next
            End If

            If ChartControl.Series.Count > 0 AndAlso TypeOf ChartControl.Series(0).View Is BarSeriesView Then
                For i As Integer = 1 To ChartControl.Series.Count - 1
                    ChartControl.Series(i).ShowInLegend = True
                Next

                Dim diagram As XYDiagram = CType(ChartControl.Diagram, XYDiagram)
                diagram.AxisX.Title.Text = "Products"
                diagram.AxisX.Title.Visibility = DefaultBoolean.True
                diagram.AxisY.Title.Text = "Sales, <i>thousands of USD</i>"
                diagram.AxisY.Title.Visibility = DefaultBoolean.True
            End If
        End Sub

        Private Sub SetSeriesTitles()
            If TemplatePieView IsNot Nothing Then
                Dim seriesTitle As SeriesTitle = New SeriesTitle() With {.Visibility = DefaultBoolean.True}
                TemplatePieView.Titles.Clear()
                TemplatePieView.Titles.Add(seriesTitle)
            End If
        End Sub

        Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateChartControl()
        End Sub

        Private Sub chart_ObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs)
            If TypeOf e.Object Is Title Then
                selectedTitle = CType(e.Object, Title)
            ElseIf TypeOf e.AdditionalObject Is AxisTitle Then
                selectedTitle = CType(e.AdditionalObject, AxisTitle)
            Else
                e.Cancel = True
            End If

            textEditTitleText.Text = selectedTitle.Text
            Dim dockableTitle As DockableTitle = TryCast(selectedTitle, DockableTitle)
            If dockableTitle IsNot Nothing Then
                checkEditWordWrap.Checked = dockableTitle.WordWrap
                comboBoxEditDock.Enabled = True
                comboBoxEditDock.SelectedIndex = CInt(dockableTitle.Dock)
                comboBoxEditAlignment.SelectedIndex = CInt(dockableTitle.Alignment)
            End If

            Dim axisTitle As AxisTitle = TryCast(selectedTitle, AxisTitle)
            If axisTitle IsNot Nothing Then
                checkEditWordWrap.Checked = axisTitle.WordWrap
                comboBoxEditDock.Enabled = False
                comboBoxEditDock.Text = String.Empty
                comboBoxEditAlignment.SelectedIndex = CInt(axisTitle.Alignment)
            End If
        End Sub

        Private Sub chart_ObjectHotTracked(ByVal sender As Object, ByVal e As HotTrackEventArgs)
            If Not(TypeOf e.Object Is Title) Then e.Cancel = True
        End Sub

        Private Sub comboBoxEditSeriesView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            chart.BeginInit()
            If Equals(CStr(comboBoxEditSeriesView.SelectedItem), "Pie") Then
                ChartControl.SeriesTemplate.ChangeView(ViewType.Pie)
                If TypeOf selectedTitle Is AxisTitle AndAlso ChartControl.Titles.Count > 0 Then ChartControl.SetObjectSelection(ChartControl.Titles(0))
                ChartControl.Legend.Title.Text = "Products"
            ElseIf Equals(CStr(comboBoxEditSeriesView.SelectedItem), "Bar") Then
                ChartControl.SeriesTemplate.ChangeView(ViewType.Bar)
                If TypeOf selectedTitle Is SeriesTitle AndAlso ChartControl.Titles.Count > 0 Then ChartControl.SetObjectSelection(ChartControl.Titles(0))
                ChartControl.Legend.Title.Text = "Regions"
            End If

            UpdateChartControl()
            SetSeriesTitles()
            chart.EndInit()
            ChartControl.Animate()
        End Sub

        Private Sub textEditTitleText_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            If selectedTitle IsNot Nothing Then selectedTitle.Text = textEditTitleText.Text
        End Sub

        Private Sub checkEditWordWrap_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dockableTitle As DockableTitle = TryCast(selectedTitle, DockableTitle)
            If dockableTitle IsNot Nothing Then dockableTitle.WordWrap = checkEditWordWrap.Checked
            Dim axisTitle As AxisTitle = TryCast(selectedTitle, AxisTitle)
            If axisTitle IsNot Nothing Then axisTitle.WordWrap = checkEditWordWrap.Checked
        End Sub

        Private Sub comboBoxEditDock_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dockableTitle As DockableTitle = TryCast(selectedTitle, DockableTitle)
            If dockableTitle IsNot Nothing Then dockableTitle.Dock = CType(comboBoxEditDock.SelectedIndex, ChartTitleDockStyle)
        End Sub

        Private Sub comboBoxEditAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dockableTitle As DockableTitle = TryCast(selectedTitle, DockableTitle)
            If dockableTitle IsNot Nothing Then dockableTitle.Alignment = CType(comboBoxEditAlignment.SelectedIndex, StringAlignment)
            Dim axisTitle As AxisTitle = TryCast(selectedTitle, AxisTitle)
            If axisTitle IsNot Nothing Then axisTitle.Alignment = CType(comboBoxEditAlignment.SelectedIndex, StringAlignment)
        End Sub
    End Class
End Namespace
