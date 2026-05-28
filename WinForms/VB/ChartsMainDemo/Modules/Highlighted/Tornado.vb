Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class TornadoDemo
        Inherits ChartDemoModuleLabelViews

        Private Class StackedBarLabelPositionItem

            Private ReadOnly text As String

            Private ReadOnly positionField As BarSeriesLabelPosition

            Public ReadOnly Property Position As BarSeriesLabelPosition
                Get
                    Return positionField
                End Get
            End Property

            Public Sub New(ByVal text As String, ByVal position As BarSeriesLabelPosition)
                Me.text = text
                positionField = position
            End Sub

            Public Overrides Function ToString() As String
                Return text
            End Function
        End Class

        Public Class TwoKeyColorizer
            Inherits SeriesColorizerBase

            Private ReadOnly separator As Char

            Private ReadOnly firstKeys As Dictionary(Of String, Integer)

            Private ReadOnly secondaryKeys As Dictionary(Of String, Integer)

            Private ReadOnly chart As ChartControl

            Public Sub New(ByVal chart As ChartControl, ByVal separator As Char, ByVal firstKeys As Dictionary(Of String, Integer), ByVal secondaryKeys As Dictionary(Of String, Integer))
                Me.chart = chart
                Me.separator = separator
                Me.firstKeys = firstKeys
                Me.secondaryKeys = secondaryKeys
            End Sub

            Public Overrides Function GetSeriesColor(ByVal seriesKey As Object, ByVal palette As Palette) As Color
                Dim name As String = seriesKey.ToString()
                Dim keys As String() = name.Split(separator)
                If keys.Length = 2 Then
                    keys(1) = keys(1).TrimStart()
                    Dim index1, index2 As Integer
                    If firstKeys.TryGetValue(keys(0), index1) AndAlso secondaryKeys.TryGetValue(keys(1), index2) Then
                        Dim entries As PaletteEntry() = chart.GetPaletteEntries(palette.Count * secondaryKeys.Count)
                        Return entries(index1 + index2 * palette.Count).Color
                    End If
                End If

                Return Color.Empty
            End Function

            Protected Overrides Function CreateObjectForClone() As ChartElement
                Return New TwoKeyColorizer(chart, separator, firstKeys, secondaryKeys)
            End Function
        End Class

        Friend Overrides ReadOnly Property ChartDesignerEnabled As Boolean
            Get
                Return False
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Protected Overrides ReadOnly Property OptionsLayoutControl As LayoutControl
            Get
                Return layoutControl1
            End Get
        End Property

        Protected Overrides ReadOnly Property LabelVisibleCheckEdit As CheckEdit
            Get
                Return checkEditLabelVisible
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControls As List(Of ChartControl)
            Get
                Return New List(Of ChartControl)() From {chart}
            End Get
        End Property

        Protected Overrides ReadOnly Property ToolTipEnabled As DefaultBoolean
            Get
                Return If(LabelVisibleCheckEdit.Checked, DefaultBoolean.False, DefaultBoolean.True)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            InitializePositionComboBox()
            InitializeCalculatedFields()
            ChartControl.SeriesTemplate.SeriesColorizer = ConstructGenderColorizer()
            ChartControl.DataSource = AgeStructureDataReader.GetGenderAgeItemsWithPopulation()
        End Sub

        Private Sub InitializeCalculatedFields()
            ChartControl.CalculatedFields.Add(New ChartCalculatedField() With {.DisplayName = "Calculated Population", .Expression = "IIF ([GenderAge.Gender] == 'Male', [Population] * -1, [Population])", .FieldType = ChartCalculatedFieldType.Double, .Name = "CalculatedPopulation"})
        End Sub

        Private Sub InitializePositionComboBox()
            Dim center As StackedBarLabelPositionItem = New StackedBarLabelPositionItem("Center", BarSeriesLabelPosition.Center)
            Dim topInside As StackedBarLabelPositionItem = New StackedBarLabelPositionItem("Top Inside", BarSeriesLabelPosition.TopInside)
            Dim bottomInside As StackedBarLabelPositionItem = New StackedBarLabelPositionItem("Bottom Inside", BarSeriesLabelPosition.BottomInside)
            comboBoxEditRangeBarLabelPosition.Properties.Items.Add(center)
            comboBoxEditRangeBarLabelPosition.Properties.Items.Add(topInside)
            comboBoxEditRangeBarLabelPosition.Properties.Items.Add(bottomInside)
            comboBoxEditRangeBarLabelPosition.SelectedItem = center
        End Sub

        Private Function ConstructGenderColorizer() As SeriesColorizerBase
            Dim firstKeys As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)()
            firstKeys.Add("Male", 0)
            firstKeys.Add("Female", 1)
            Dim secondaryKeys As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)()
            secondaryKeys.Add("0-14 years", 0)
            secondaryKeys.Add("15-64 years", 1)
            secondaryKeys.Add("65 years and older", 2)
            Return New TwoKeyColorizer(ChartControl, ":"c, firstKeys, secondaryKeys)
        End Function

        Private Sub Chart_CustomDrawAxisLabel(ByVal sender As Object, ByVal e As CustomDrawAxisLabelEventArgs)
            Dim axisValue As Double
            If Double.TryParse(e.Item.AxisValue.ToString(), axisValue) AndAlso axisValue < 0 Then e.Item.Text =(-axisValue).ToString("0,,")
        End Sub

        Private Sub checkEditLabelVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetLabelVisibility(layoutControlItemIndent, layoutControlItemOrientation, layoutControlItemRangeBarLabelPosition)
            UpdateStackedBarLabelIndent(CType(chart.SeriesTemplate.Label, StackedBarSeriesLabel))
        End Sub

        Private Sub comboBoxEditRangeBarLabelPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim position As BarSeriesLabelPosition = CType(comboBoxEditRangeBarLabelPosition.SelectedItem, StackedBarLabelPositionItem).Position
            Dim label As StackedBarSeriesLabel = CType(chart.SeriesTemplate.Label, StackedBarSeriesLabel)
            label.Position = position
            UpdateStackedBarLabelIndent(label)
        End Sub

        Private Sub comboBoxEditLabelOrientation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ChartControl.SeriesTemplate.Label.TextOrientation = CType(comboBoxEditLabelOrientation.SelectedIndex, TextOrientation)
        End Sub

        Private Sub spinEditLabelIndent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim label As BarSeriesLabel = TryCast(ChartControl.SeriesTemplate.Label, BarSeriesLabel)
            If label IsNot Nothing Then label.Indent = CInt(spinEditLabelIndent.Value)
        End Sub

        Private Sub comboBoxEditTotalLabelVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim xyDiagram As XYDiagram = TryCast(ChartControl.Diagram, XYDiagram)
            If xyDiagram IsNot Nothing Then
                Dim label As StackedBarTotalLabel = xyDiagram.DefaultPane.StackedBarTotalLabel
                label.Visible = comboBoxEditTotalLabelVisible.Checked
            End If
        End Sub

        Private Sub UpdateStackedBarLabelIndent(ByVal stackedBarSeriesLabel As StackedBarSeriesLabel)
            Dim isCenterPosition As Boolean = stackedBarSeriesLabel.Position.Equals(BarSeriesLabelPosition.Center)
            layoutControlItemIndent.Enabled = Not isCenterPosition AndAlso checkEditLabelVisible.Checked
            If Not isCenterPosition Then spinEditLabelIndent.Value = stackedBarSeriesLabel.Indent
        End Sub

        Private Sub Chart_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
            Dim number As Double
            If Double.TryParse(e.LabelText, number) AndAlso number < 0 Then e.LabelText =(-number).ToString()
        End Sub

        Private Sub Chart_CustomizeStackedBarTotalLabel(ByVal sender As Object, ByVal e As CustomizeStackedBarTotalLabelEventArgs)
            Dim number As Double
            If Double.TryParse(e.Text, number) AndAlso number < 0 Then e.Text =(-number).ToString() & " M"
            If number >= 0 Then e.Text += " M"
        End Sub

        Protected Overrides Sub OnPaletteChanged()
            MyBase.OnPaletteChanged()
            chart.RefreshData()
        End Sub

        Private Sub Chart_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
            If chart.Series.Count > 0 Then
                For Each series As Series In chart.Series
                    If Equals(CType(series.Tag, GenderAgeInfo).Gender, "Male") Then series.Legend = chart.Legends(0)
                Next
            End If
        End Sub
    End Class
End Namespace
