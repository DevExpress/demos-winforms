Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Reflection
Imports System.Text
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class AnimationDemo
        Inherits ChartDemoModuleWithOptions

        Private ReadOnly Property XYDiagram As XYDiagram
            Get
                Return TryCast(chart.Diagram, XYDiagram)
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            ChartControl.AnimationStartMode = ChartAnimationMode.OnDataChanged
            comboBoxEditSeriesView.Properties.Items.AddRange(CreateItems())
            comboBoxEditSeriesView.SelectedItem = New ComboBoxSeriesViewItem(ViewType.Area)
            UpdateControls(ViewType.Area)
        End Sub

        Private Sub comboBoxEditSeriesView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim selectedViewType As ViewType = CType(comboBoxEditSeriesView.SelectedItem, ComboBoxSeriesViewItem).ViewType
            UpdateControls(selectedViewType)
        End Sub

        Private Sub checkEditSeriesLabelsVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ChangeLabelsVisibility()
        End Sub

        Private Sub simpleButtonAnimate_Click(ByVal sender As Object, ByVal e As EventArgs)
            ChartControl.Animate()
        End Sub

        Private Sub comboBoxEditSeriesAnimation_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetAnimation(TryCast(comboBoxEditSeriesAnimation.EditValue, IAnimationComboBoxItem))
        End Sub

        Private Sub comboBoxEditPointAnimation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetAnimation(TryCast(comboBoxEditPointAnimation.EditValue, IAnimationComboBoxItem))
        End Sub

        Private Sub checkEditDiagramRotated_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If XYDiagram IsNot Nothing Then XYDiagram.Rotated = checkEditDiagramRotated.Checked
        End Sub

        Private Sub checkEditAxisXReversed_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If XYDiagram IsNot Nothing Then XYDiagram.AxisX.Reverse = checkEditAxisXReversed.Checked
        End Sub

        Private Sub checkEditAxisYReversed_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If XYDiagram IsNot Nothing Then XYDiagram.AxisY.Reverse = checkEditAxisYReversed.Checked
        End Sub

        Private Sub SetAnimation(ByVal comboBoxItem As IAnimationComboBoxItem)
            If comboBoxItem IsNot Nothing Then
                For Each series As Series In ChartControl.Series
                    comboBoxItem.ApplyAnimation(series.View)
                Next
            End If
        End Sub

        Private Sub FillPointAnimationComboBoxEdit(ByVal selectedViewType As ViewType)
            FillAnimationComboBox(comboBoxEditPointAnimation, GetPointAnimationTypes(selectedViewType))
        End Sub

        Private Sub FillSeriesAnimationComboBoxEdit(ByVal selectedViewType As ViewType)
            FillAnimationComboBox(comboBoxEditSeriesAnimation, GetSeriesAnimationTypes(selectedViewType))
        End Sub

        Private Sub FillAnimationComboBox(ByVal comboBox As ComboBoxEdit, ByVal animationTypes As List(Of Type))
            Dim comboBoxItems As ComboBoxItemCollection = comboBox.Properties.Items
            comboBoxItems.Clear()
            If animationTypes.Count = 0 Then
                comboBox.Enabled = False
            Else
                comboBox.Enabled = True
                For Each animationType As Type In animationTypes
                    comboBoxItems.AddRange(CreateAnimationItems(animationType))
                Next

                comboBoxItems.AddRange(CreateAnimationItems(animationTypes(0), True))
            End If
        End Sub

        Private Sub ChangeLabelsVisibility()
            For Each series As Series In ChartControl.Series
                series.LabelsVisibility = If(checkEditSeriesLabelsVisible.Checked, DefaultBoolean.True, DefaultBoolean.False)
            Next
        End Sub

        Private Sub ChangeMarkersVisibility()
            For Each series As Series In ChartControl.Series
                If TypeOf series.View Is RangeAreaSeriesView Then
                    Dim rangeAreaView As RangeAreaSeriesView = CType(series.View, RangeAreaSeriesView)
                    rangeAreaView.Marker1Visibility = DefaultBoolean.True
                    rangeAreaView.Marker2Visibility = DefaultBoolean.True
                ElseIf TypeOf series.View Is RadarRangeAreaSeriesView Then
                    Dim rangeAreaView As RadarRangeAreaSeriesView = CType(series.View, RadarRangeAreaSeriesView)
                    rangeAreaView.Marker1Visibility = DefaultBoolean.True
                    rangeAreaView.Marker2Visibility = DefaultBoolean.True
                ElseIf TypeOf series.View Is PolarRangeAreaSeriesView Then
                    Dim rangeAreaView As PolarRangeAreaSeriesView = CType(series.View, PolarRangeAreaSeriesView)
                    rangeAreaView.Marker1Visibility = DefaultBoolean.True
                    rangeAreaView.Marker2Visibility = DefaultBoolean.True
                ElseIf TypeOf series.View Is LineSeriesView Then
                    CType(series.View, LineSeriesView).MarkerVisibility = DefaultBoolean.True
                ElseIf TypeOf series.View Is RadarLineSeriesView Then
                    CType(series.View, RadarLineSeriesView).MarkerVisibility = DefaultBoolean.True
                End If
            Next
        End Sub

        Private Sub UpdateControls(ByVal selectedViewType As ViewType)
            UpdateChart(selectedViewType)
            If XYDiagram IsNot Nothing Then
                layoutControlGroupDiagramOptions.Enabled = True
                checkEditDiagramRotated.Checked = XYDiagram.Rotated
                checkEditAxisXReversed.Checked = XYDiagram.AxisX.Reverse
                checkEditAxisYReversed.Checked = XYDiagram.AxisY.Reverse
            Else
                layoutControlGroupDiagramOptions.Enabled = False
            End If

            FillSeriesAnimationComboBoxEdit(selectedViewType)
            FillPointAnimationComboBoxEdit(selectedViewType)
            If comboBoxEditPointAnimation.Enabled Then comboBoxEditPointAnimation.SelectedIndex = 0
            If comboBoxEditSeriesAnimation.Enabled Then comboBoxEditSeriesAnimation.SelectedIndex = 0
            ChangeMarkersVisibility()
            If selectedViewType.Equals(ViewType.BoxPlot) Then
                checkEditSeriesLabelsVisible.Enabled = False
            Else
                checkEditSeriesLabelsVisible.Enabled = True
                ChangeLabelsVisibility()
            End If
        End Sub

        Private Sub UpdateChart(ByVal selectedViewType As ViewType)
            ChartControl.Series.Clear()
            Dim generatedSeries As Series() = GenerateSeries(selectedViewType)
            If generatedSeries IsNot Nothing Then ChartControl.Series.AddRange(generatedSeries)
        End Sub

        Private Function CreateAnimationItems(ByVal type As Type, ByVal Optional isNoneItem As Boolean = False) As List(Of IAnimationComboBoxItem)
            Dim directionProperty As PropertyInfo = type.GetProperty("Direction")
            If directionProperty IsNot Nothing AndAlso Not isNoneItem Then
                Dim items As List(Of IAnimationComboBoxItem) = New List(Of IAnimationComboBoxItem)()
                Dim propertyType As Type = directionProperty.PropertyType
                For Each directionValue As Object In [Enum].GetValues(propertyType)
                    items.Add(CreateAnimationItem(type, directionValue, isNoneItem))
                Next

                Return items
            End If

            Return New List(Of IAnimationComboBoxItem)() From {CreateAnimationItem(type, Nothing, isNoneItem)}
        End Function

        Private Function CreateAnimationItem(ByVal type As Type, ByVal direction As Object, ByVal Optional isNoneItem As Boolean = False) As IAnimationComboBoxItem
            If type.IsSubclassOf(GetType(XYMarkerAnimationBase)) Then
                Return New ComboBoxXYMarkerAnimationItem(type, isNoneItem, direction)
            ElseIf type.IsSubclassOf(GetType(BarAnimationBase)) Then
                Return New ComboBoxBarAnimationItem(type, isNoneItem, direction)
            ElseIf type.IsSubclassOf(GetType(PieAnimationBase)) Then
                Return New ComboBoxPieAnimationItem(type, isNoneItem, direction)
            ElseIf type.IsSubclassOf(GetType(FunnelAnimationBase)) Then
                Return New ComboBoxFunnelAnimationItem(type, isNoneItem, direction)
            ElseIf type.IsSubclassOf(GetType(CircularMarkerAnimationBase)) Then
                Return New ComboBoxCircularMarkerAnimationItem(type, isNoneItem, direction)
            ElseIf type.IsSubclassOf(GetType(FinancialAnimationBase)) Then
                Return New ComboBoxFinancialPointAnimationItem(type, isNoneItem, direction)
            ElseIf type.IsSubclassOf(GetType(XYSeriesAnimationBase)) Then
                Return New ComboBoxXYSeriesAnimationItem(type, isNoneItem, direction)
            ElseIf type.IsSubclassOf(GetType(CircularSeriesAnimationBase)) Then
                Return New ComboBoxCircularSeriesAnimationItem(type, isNoneItem, direction)
            ElseIf type.IsSubclassOf(GetType(BoxPlotAnimationBase)) Then
                Return New ComboBoxBoxPlotAnimationItem(type, isNoneItem, direction)
            End If

            Throw New NotSupportedException(String.Format("Can't create ComboBoxItem. Unknown animation type: {0}", type.Name))
        End Function
    End Class

    Friend Interface IAnimationComboBoxItem

        Sub ApplyAnimation(ByVal seriesView As SeriesViewBase)

    End Interface

    Friend MustInherit Class AnimationComboBoxItem(Of TAnimation As AnimationBase, TSeriesView As SeriesViewBase)
        Implements IAnimationComboBoxItem

        Private ReadOnly type As Type

        Private ReadOnly caption As String

        Private ReadOnly isNoneItem As Boolean

        Private ReadOnly direction As Object

        Public Sub New(ByVal type As Type, ByVal isNoneItem As Boolean, ByVal direction As Object)
            Me.direction = direction
            caption = GetDisplayName(type, isNoneItem)
            Me.type = type
            Me.isNoneItem = isNoneItem
        End Sub

        Private Function GetDisplayName(ByVal type As Type, ByVal isNoneItem As Boolean) As String
            If isNoneItem Then Return "None"
            Dim attribute As DisplayNameAttribute = TryCast(type.GetCustomAttribute(GetType(DisplayNameAttribute)), DisplayNameAttribute)
            Return If(attribute IsNot Nothing, attribute.DisplayName, type.Name)
        End Function

        Private Function ParseStringByLargeTokens(ByVal sourceString As String) As String
            Dim result As StringBuilder = New StringBuilder()
            If sourceString.StartsWith("XY") Then
                result.Append("XY-")
                sourceString = sourceString.Substring(2, sourceString.Length - 2)
            End If

            For Each symbol As Char In sourceString
                If Char.IsUpper(symbol) Then result.Append(" "c)
                result.Append(symbol)
            Next

            Return result.ToString()
        End Function

        Public Sub ApplyAnimation(ByVal seriesView As SeriesViewBase) Implements IAnimationComboBoxItem.ApplyAnimation
            Dim animation As TAnimation = CType(Activator.CreateInstance(type), TAnimation)
            animation.Enabled = Not isNoneItem
            ApplyAnimationInternal(animation, CType(seriesView, TSeriesView))
            If direction IsNot Nothing Then
                Dim directionProperty As PropertyInfo = type.GetProperty("Direction")
                directionProperty.SetValue(animation, direction, Nothing)
            End If
        End Sub

        Public MustOverride Sub ApplyAnimationInternal(ByVal animation As TAnimation, ByVal seriesView As TSeriesView)

        Public Overrides Function ToString() As String
            If direction Is Nothing OrElse isNoneItem Then
                Return ParseStringByLargeTokens(caption)
            Else
                Return ParseStringByLargeTokens(caption) & ParseStringByLargeTokens(direction.ToString())
            End If
        End Function
    End Class

    Friend Class ComboBoxXYSeriesAnimationItem
        Inherits AnimationComboBoxItem(Of XYSeriesAnimationBase, XYDiagramSeriesViewBase)

        Public Sub New(ByVal type As Type, ByVal isNoneItem As Boolean, ByVal direction As Object)
            MyBase.New(type, isNoneItem, direction)
        End Sub

        Public Overrides Sub ApplyAnimationInternal(ByVal animation As XYSeriesAnimationBase, ByVal seriesView As XYDiagramSeriesViewBase)
            If TypeOf seriesView Is LineSeriesView Then CType(seriesView, LineSeriesView).SeriesAnimation = animation
            If TypeOf seriesView Is BoxPlotSeriesView Then CType(seriesView, BoxPlotSeriesView).MeanLineAnimation = animation
        End Sub
    End Class

    Friend Class ComboBoxXYMarkerAnimationItem
        Inherits AnimationComboBoxItem(Of XYMarkerAnimationBase, PointSeriesViewBase)

        Public Sub New(ByVal type As Type, ByVal isNoneItem As Boolean, ByVal direction As Object)
            MyBase.New(type, isNoneItem, direction)
        End Sub

        Public Overrides Sub ApplyAnimationInternal(ByVal animation As XYMarkerAnimationBase, ByVal seriesView As PointSeriesViewBase)
            seriesView.SeriesPointAnimation = animation
        End Sub
    End Class

    Friend Class ComboBoxBarAnimationItem
        Inherits AnimationComboBoxItem(Of BarAnimationBase, BarSeriesView)

        Public Sub New(ByVal type As Type, ByVal isNoneItem As Boolean, ByVal direction As Object)
            MyBase.New(type, isNoneItem, direction)
        End Sub

        Public Overrides Sub ApplyAnimationInternal(ByVal animation As BarAnimationBase, ByVal seriesView As BarSeriesView)
            seriesView.Animation = animation
        End Sub
    End Class

    Friend Class ComboBoxPieAnimationItem
        Inherits AnimationComboBoxItem(Of PieAnimationBase, PieSeriesView)

        Public Sub New(ByVal type As Type, ByVal isNoneItem As Boolean, ByVal direction As Object)
            MyBase.New(type, isNoneItem, direction)
        End Sub

        Public Overrides Sub ApplyAnimationInternal(ByVal animation As PieAnimationBase, ByVal seriesView As PieSeriesView)
            seriesView.Animation = animation
        End Sub
    End Class

    Friend Class ComboBoxFunnelAnimationItem
        Inherits AnimationComboBoxItem(Of FunnelAnimationBase, FunnelSeriesView)

        Public Sub New(ByVal type As Type, ByVal isNoneItem As Boolean, ByVal direction As Object)
            MyBase.New(type, isNoneItem, direction)
        End Sub

        Public Overrides Sub ApplyAnimationInternal(ByVal animation As FunnelAnimationBase, ByVal seriesView As FunnelSeriesView)
            seriesView.Animation = animation
        End Sub
    End Class

    Friend Class ComboBoxCircularMarkerAnimationItem
        Inherits AnimationComboBoxItem(Of CircularMarkerAnimationBase, RadarSeriesViewBase)

        Public Sub New(ByVal type As Type, ByVal isNoneItem As Boolean, ByVal direction As Object)
            MyBase.New(type, isNoneItem, direction)
        End Sub

        Public Overrides Sub ApplyAnimationInternal(ByVal animation As CircularMarkerAnimationBase, ByVal seriesView As RadarSeriesViewBase)
            seriesView.SeriesPointAnimation = animation
        End Sub
    End Class

    Friend Class ComboBoxFinancialPointAnimationItem
        Inherits AnimationComboBoxItem(Of FinancialAnimationBase, FinancialSeriesViewBase)

        Public Sub New(ByVal type As Type, ByVal isNoneItem As Boolean, ByVal direction As Object)
            MyBase.New(type, isNoneItem, direction)
        End Sub

        Public Overrides Sub ApplyAnimationInternal(ByVal animation As FinancialAnimationBase, ByVal seriesView As FinancialSeriesViewBase)
            seriesView.Animation = animation
        End Sub
    End Class

    Friend Class ComboBoxCircularSeriesAnimationItem
        Inherits AnimationComboBoxItem(Of CircularSeriesAnimationBase, RadarLineSeriesView)

        Public Sub New(ByVal type As Type, ByVal isNoneItem As Boolean, ByVal direction As Object)
            MyBase.New(type, isNoneItem, direction)
        End Sub

        Public Overrides Sub ApplyAnimationInternal(ByVal animation As CircularSeriesAnimationBase, ByVal seriesView As RadarLineSeriesView)
            seriesView.SeriesAnimation = animation
        End Sub
    End Class

    Friend Class ComboBoxBoxPlotAnimationItem
        Inherits AnimationComboBoxItem(Of BoxPlotAnimationBase, BoxPlotSeriesView)

        Public Sub New(ByVal type As Type, ByVal isNoneItem As Boolean, ByVal direction As Object)
            MyBase.New(type, isNoneItem, direction)
        End Sub

        Public Overrides Sub ApplyAnimationInternal(ByVal animation As BoxPlotAnimationBase, ByVal seriesView As BoxPlotSeriesView)
            seriesView.Animation = animation
        End Sub
    End Class
End Namespace
