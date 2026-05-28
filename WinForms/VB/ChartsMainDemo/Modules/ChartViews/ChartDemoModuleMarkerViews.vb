Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Utils
Imports System.Runtime.InteropServices

Namespace DevExpress.XtraCharts.Demos

    Public Class ChartDemoModuleMarkerViews
        Inherits ChartDemoModuleLabelViews

        Private ReadOnly markerKindItems As MarkerKindItemCollection

        Protected Overridable ReadOnly Property MarkerKindComboBox As ComboBoxEdit
            Get
                Return Nothing
            End Get
        End Property

        Protected Overridable ReadOnly Property MarkerSizeSpinEdit As SpinEdit
            Get
                Return Nothing
            End Get
        End Property

        Protected Overridable ReadOnly Property MarkerVisibleCheckEdit As CheckEdit
            Get
                Return Nothing
            End Get
        End Property

        Protected Overridable ReadOnly Property MarkerKindDefaultIndex As Integer
            Get
                Return 4
            End Get
        End Property

        Public Sub New()
            markerKindItems = MarkerKindItemCollection.CreateCollection()
        End Sub

        Private Sub SetMarkerKind(ByVal view As SeriesViewBase)
            Dim kind As MarkerKind
            Dim starCount As Integer
            ParseMarkerKind(MarkerKindComboBox.EditValue, kind, starCount)
            If SetRangeMarkerKind(view, kind, starCount) Then Return
            Dim pointView As PointSeriesView = TryCast(view, PointSeriesView)
            If pointView IsNot Nothing Then
                pointView.PointMarkerOptions.Kind = kind
                pointView.PointMarkerOptions.StarPointCount = starCount
                Return
            End If

            Dim bubbleView As BubbleSeriesView = TryCast(view, BubbleSeriesView)
            If bubbleView IsNot Nothing Then
                bubbleView.BubbleMarkerOptions.Kind = kind
                bubbleView.BubbleMarkerOptions.StarPointCount = starCount
                Return
            End If

            Dim radarPointView As RadarPointSeriesView = TryCast(view, RadarPointSeriesView)
            If radarPointView IsNot Nothing Then
                radarPointView.PointMarkerOptions.Kind = kind
                radarPointView.PointMarkerOptions.StarPointCount = starCount
            End If
        End Sub

        Private Sub ParseMarkerKind(ByVal editValue As Object, <Out> ByRef kind As MarkerKind, <Out> ByRef starCount As Integer)
            Dim markerKind As MarkerKindItem = CType(editValue, MarkerKindItem)
            kind = markerKind.MarkerKind
            starCount = 3
            Dim starKindItem As StarMarkerKindItem = TryCast(markerKind, StarMarkerKindItem)
            If starKindItem IsNot Nothing Then starCount = starKindItem.PointCount
        End Sub

        Private Sub MarkerSizeEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ApplySettingsToSeriesView(New Action(Of SeriesViewBase)(AddressOf SetMarkerSize))
        End Sub

        Private Sub MarkerKindSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ApplySettingsToSeriesView(New Action(Of SeriesViewBase)(AddressOf SetMarkerKind))
        End Sub

        Private Sub InitMarkerKindOptions(ByVal rgMarkerKind As ComboBoxEdit)
            For Each item As MarkerKindItem In markerKindItems
                rgMarkerKind.Properties.Items.Add(item)
            Next

            rgMarkerKind.SelectedIndex = MarkerKindDefaultIndex
            AddHandler rgMarkerKind.SelectedIndexChanged, AddressOf MarkerKindSelectedIndexChanged
        End Sub

        Private Sub UpdateMarkerControlCore(ByVal markerOptions As SimpleMarker)
            MarkerSizeSpinEdit.Value = markerOptions.Size
            If markerOptions.Kind <> MarkerKind.Star Then
                MarkerKindComboBox.SelectedItem = markerKindItems.GetItemByKind(markerOptions.Kind)
            Else
                MarkerKindComboBox.SelectedItem = markerKindItems.GetItemByStarPointCount(markerOptions.StarPointCount)
            End If
        End Sub

        Private Sub SetMarkerSize(ByVal view As SeriesViewBase)
            Dim size As Integer = CInt(MarkerSizeSpinEdit.Value)
            If SetRangeMarkerSize(view, size) Then Return
            Dim areaView As PointSeriesView = TryCast(view, PointSeriesView)
            If areaView IsNot Nothing Then
                areaView.PointMarkerOptions.Size = size
                Return
            End If

            Dim radarPointView As RadarPointSeriesView = TryCast(view, RadarPointSeriesView)
            If radarPointView IsNot Nothing Then radarPointView.PointMarkerOptions.Size = size
        End Sub

        Protected Overrides Sub InitControls()
            MyBase.InitControls()
            InitMarkerKindOptions(MarkerKindComboBox)
            AddHandler MarkerSizeSpinEdit.EditValueChanged, AddressOf MarkerSizeEditValueChanged
        End Sub

        Protected Overridable Function SetRangeMarkerVisibility(ByVal view As SeriesViewBase, ByVal visibility As DefaultBoolean) As Boolean
            Return False
        End Function

        Protected Overridable Function SetRangeMarkerSize(ByVal view As SeriesViewBase, ByVal size As Integer) As Boolean
            Return False
        End Function

        Protected Overridable Function SetRangeMarkerKind(ByVal view As SeriesViewBase, ByVal kind As MarkerKind, ByVal starCount As Integer) As Boolean
            Return False
        End Function

        Protected Sub SetMarkerVisibility(ParamArray items As LayoutControlItem())
            SetEnabledLayoutControlItems(MarkerVisibleCheckEdit.Checked, items)
            ApplySettingsToSeriesView(New Action(Of SeriesViewBase)(AddressOf SetMarkerVisibility))
        End Sub

        Protected Sub SetMarkerVisibility(ByVal view As SeriesViewBase)
            Dim visibility As DefaultBoolean = CovertBoolToDefaultBoolean(MarkerVisibleCheckEdit.Checked)
            If SetRangeMarkerVisibility(view, visibility) Then Return
            Dim lineView As LineSeriesView = TryCast(view, LineSeriesView)
            If lineView IsNot Nothing Then
                lineView.MarkerVisibility = CovertBoolToDefaultBoolean(MarkerVisibleCheckEdit.Checked)
                Return
            End If

            Dim radarLineView As RadarLineSeriesView = TryCast(view, RadarLineSeriesView)
            If radarLineView IsNot Nothing Then radarLineView.MarkerVisibility = visibility
        End Sub

        Protected Sub UpdateMarkerControls(ByVal markerOptions As SimpleMarker)
            UpdateMarkerControlCore(markerOptions)
        End Sub

        Protected Sub UpdateMarkerControls(ByVal markerOptions As SimpleMarker, ByVal visibility As DefaultBoolean)
            MarkerVisibleCheckEdit.Checked = visibility.Equals(DefaultBoolean.True)
            UpdateMarkerControlCore(markerOptions)
        End Sub

        Protected Function UpdateRadarMarkerOptions() As LayoutVisibility
            Dim radarRangeView As RadarRangeAreaSeriesView = TryCast(ActiveSeries.View, RadarRangeAreaSeriesView)
            If radarRangeView IsNot Nothing Then
                UpdateMarkerControls(radarRangeView.Marker1, radarRangeView.Marker1Visibility)
                Return LayoutVisibility.Always
            End If

            Dim radarLineView As RadarLineSeriesView = TryCast(ActiveSeries.View, RadarLineSeriesView)
            If radarLineView IsNot Nothing Then
                UpdateMarkerControls(radarLineView.LineMarkerOptions, radarLineView.MarkerVisibility)
                Return LayoutVisibility.Always
            End If

            Dim radarPointView As RadarPointSeriesView = TryCast(ActiveSeries.View, RadarPointSeriesView)
            If radarPointView IsNot Nothing Then UpdateMarkerControls(radarPointView.PointMarkerOptions)
            Return LayoutVisibility.Never
        End Function
    End Class
End Namespace
