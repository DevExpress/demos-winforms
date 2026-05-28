Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGauges.Core.Model

Namespace DevExpress.XtraGauges.Demos

    Public Partial Class CircularGaugeFeatures
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub UpdateOtherFeaturesPage(ByVal sender As Object, ByVal e As EventArgs)
            arcScaleComponent2.Value = arcScaleComponent2.MinValue + arcScaleComponent2.ScaleLength * (CSng(trackBarControl1.Value) / CSng(trackBarControl1.Properties.Maximum))
            arcScaleComponent2.Labels(0).TextOrientation = CType([Enum].Parse(GetType(LabelOrientation), CStr(lblOrientation.EditValue)), LabelOrientation)
            arcScaleComponent2.Labels(0).Position = New Core.Base.PointF2D(CSng(horzLblPos.Value), CSng(vertLblPos.Value))
        End Sub

        Private Sub UpdateRangeBarFeaturesPage(ByVal sender As Object, ByVal e As EventArgs)
            arcScaleComponent5.Value = arcScaleComponent5.MinValue + arcScaleComponent5.ScaleLength * (CSng(trackBarControl32.Value) / CSng(trackBarControl32.Properties.Maximum))
            arcScaleRangeBarComponent1.BeginUpdate()
            arcScaleRangeBarComponent1.StartOffset = trackBarControl29.Value
            arcScaleRangeBarComponent1.EndOffset = trackBarControl30.Value
            arcScaleRangeBarComponent1.AnchorValue = arcScaleComponent5.MinValue + arcScaleComponent5.ScaleLength * (CSng(trackBarControl31.Value) / CSng(trackBarControl31.Properties.Maximum))
            arcScaleRangeBarComponent1.EndUpdate()
            arcScaleMarkerComponent1.BeginUpdate()
            arcScaleMarkerComponent1.ShapeOffset = markerOffset.Value
            arcScaleMarkerComponent1.ShapeType = CType([Enum].Parse(GetType(MarkerPointerShapeType), CStr(markerShape.EditValue)), MarkerPointerShapeType)
            arcScaleMarkerComponent1.EndUpdate()
        End Sub

        Private Sub CircularGaugeFeatures_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitControls()
        End Sub

        Private Sub UpdateScaleFeaturesPage(ByVal sender As Object, ByVal e As EventArgs)
            arcScaleComponent1.BeginUpdate()
            arcScaleComponent1.RadiusX = scaleRTrack.Value
            arcScaleComponent1.RadiusY = scaleRTrack.Value
            arcScaleComponent1.MaxValue = rangeTrack.Value.Maximum
            arcScaleComponent1.MinValue = rangeTrack.Value.Minimum
            arcScaleComponent1.Value = arcScaleComponent1.MinValue + arcScaleComponent1.ScaleLength * (CSng(scaleValueTrack.Value) / CSng(scaleValueTrack.Properties.Maximum))
            arcScaleComponent1.StartAngle = scaleStartAngleTrack.Value - 240
            arcScaleComponent1.EndAngle = scaleEndAngleTrack.Value
            arcScaleComponent1.MinorTickCount = scaleTicksCount.Value
            arcScaleComponent1.MajorTickCount = scaleLabelsCount.Value
            arcScaleComponent1.MajorTickmark.TextOffset = scaleTextExtentTrack.Value
            arcScaleComponent1.MajorTickmark.ShapeOffset = majorTickOffset.Value
            arcScaleComponent1.MinorTickmark.ShapeOffset = minorTickOffset.Value
            arcScaleComponent1.MajorTickmark.TextOrientation = CType([Enum].Parse(GetType(LabelOrientation), CStr(scaleTextOrientation.EditValue)), LabelOrientation)
            arcScaleComponent1.EndUpdate()
        End Sub

        Private Sub UpdateNeedleFeaturesPage(ByVal sender As Object, ByVal e As EventArgs)
            arcScaleNeedleComponent6.StartOffset = trackBarControl25.Value
            arcScaleNeedleComponent6.EndOffset = trackBarControl26.Value
            arcScaleComponent6.Value = arcScaleComponent6.MinValue + arcScaleComponent6.ScaleLength * (CSng(trackBarControl28.Value) / CSng(trackBarControl28.Properties.Maximum))
        End Sub

        Private Sub UpdateStateIndicatorFeaturesPage(ByVal sender As Object, ByVal e As EventArgs)
            arcScaleComponent7.Value = arcScaleComponent7.MinValue + arcScaleComponent7.ScaleLength * (CSng(statePageVal.Value) / CSng(statePageVal.Properties.Maximum))
        End Sub

        Protected Overridable Sub InitControls()
            InitScaleFeaturesPage()
            InitRangeBarFeaturesPage()
            InitNeedleFeaturesPage()
            InitStateIndicatorFeaturesPage()
            InitOtherFeaturesPage()
        End Sub

        Protected Sub SubscribeChanged(ByVal trackBar As TrackBarControl)
            AddHandler trackBar.EditValueChanged, New EventHandler(AddressOf UpdateScaleFeaturesPage)
        End Sub

        Protected Sub SubscribeChanged(ByVal combo As ComboBoxEdit)
            AddHandler combo.SelectedIndexChanged, New EventHandler(AddressOf UpdateScaleFeaturesPage)
        End Sub

        Protected Sub FillCombo(ByVal cbe As ComboBoxEdit, ByVal enumType As Type)
            Dim _names As String() = [Enum].GetNames(enumType)
            For Each _name As String In _names
                cbe.Properties.Items.Add(_name)
            Next
        End Sub

        Protected Sub FillCombo(ByVal cbe As ComboBoxEdit, ByVal enumType As Type, ByVal filter As String)
            Dim _names As String() = [Enum].GetNames(enumType)
            For Each _name As String In _names
                If _name.StartsWith(filter) Then cbe.Properties.Items.Add(_name)
            Next
        End Sub

        Protected Sub InitScaleFeaturesPage()
            scaleRTrack.Value = CInt(arcScaleComponent1.RadiusX)
            rangeTrack.Value = New Repository.TrackBarRange(CInt(arcScaleComponent1.MinValue), CInt(arcScaleComponent1.MaxValue))
            scaleValueTrack.Value = CInt(arcScaleComponent1.Value)
            scaleStartAngleTrack.Value = CInt(arcScaleComponent1.StartAngle)
            scaleEndAngleTrack.Value = CInt(arcScaleComponent1.EndAngle)
            scaleTicksCount.Value = arcScaleComponent1.MinorTickCount
            scaleLabelsCount.Value = arcScaleComponent1.MajorTickCount
            scaleTextExtentTrack.Value = CInt(arcScaleComponent1.MajorTickmark.TextOffset)
            majorTickOffset.Value = CInt(arcScaleComponent1.MajorTickmark.ShapeOffset)
            minorTickOffset.Value = CInt(arcScaleComponent1.MinorTickmark.ShapeOffset)
            SubscribeChanged(scaleRTrack)
            SubscribeChanged(rangeTrack)
            SubscribeChanged(scaleTicksCount)
            SubscribeChanged(scaleLabelsCount)
            SubscribeChanged(scaleStartAngleTrack)
            SubscribeChanged(scaleEndAngleTrack)
            SubscribeChanged(scaleValueTrack)
            SubscribeChanged(scaleTextExtentTrack)
            SubscribeChanged(minorTickOffset)
            SubscribeChanged(majorTickOffset)
            FillCombo(scaleTextOrientation, GetType(LabelOrientation))
            scaleTextOrientation.EditValue = arcScaleComponent1.MajorTickmark.TextOrientation.ToString()
            SubscribeChanged(scaleTextOrientation)
            UpdateScaleFeaturesPage(Nothing, Nothing)
        End Sub

        Protected Sub InitRangeBarFeaturesPage()
            trackBarControl29.Value = CInt(arcScaleRangeBarComponent1.StartOffset)
            trackBarControl30.Value = CInt(arcScaleRangeBarComponent1.EndOffset)
            trackBarControl31.Value = CInt(arcScaleRangeBarComponent1.AnchorValue)
            FillCombo(markerShape, GetType(MarkerPointerShapeType))
            markerShape.EditValue = arcScaleMarkerComponent1.ShapeType.ToString()
            markerOffset.Value = CInt(arcScaleMarkerComponent1.ShapeOffset)
            AddHandler trackBarControl29.EditValueChanged, AddressOf UpdateRangeBarFeaturesPage
            AddHandler trackBarControl30.EditValueChanged, AddressOf UpdateRangeBarFeaturesPage
            AddHandler trackBarControl31.EditValueChanged, AddressOf UpdateRangeBarFeaturesPage
            AddHandler trackBarControl32.EditValueChanged, AddressOf UpdateRangeBarFeaturesPage
            AddHandler markerOffset.EditValueChanged, AddressOf UpdateRangeBarFeaturesPage
            AddHandler markerShape.EditValueChanged, AddressOf UpdateRangeBarFeaturesPage
        End Sub

        Protected Sub InitOtherFeaturesPage()
            horzLblPos.EditValue = arcScaleComponent2.Labels(0).Position.X
            vertLblPos.EditValue = arcScaleComponent2.Labels(0).Position.Y
            FillCombo(lblOrientation, GetType(LabelOrientation))
            lblOrientation.EditValue = arcScaleComponent2.Labels(0).TextOrientation.ToString()
            AddHandler horzLblPos.EditValueChanged, AddressOf UpdateOtherFeaturesPage
            AddHandler vertLblPos.EditValueChanged, AddressOf UpdateOtherFeaturesPage
            AddHandler trackBarControl1.EditValueChanged, AddressOf UpdateOtherFeaturesPage
            AddHandler lblOrientation.EditValueChanged, AddressOf UpdateOtherFeaturesPage
        End Sub

        Protected Sub InitNeedleFeaturesPage()
            trackBarControl25.Value = CInt(arcScaleNeedleComponent6.StartOffset)
            AddHandler trackBarControl25.EditValueChanged, New EventHandler(AddressOf UpdateNeedleFeaturesPage)
            trackBarControl26.Value = CInt(arcScaleNeedleComponent6.EndOffset)
            AddHandler trackBarControl26.EditValueChanged, New EventHandler(AddressOf UpdateNeedleFeaturesPage)
            trackBarControl28.Value = CInt(10 * arcScaleComponent6.Value)
            AddHandler trackBarControl28.EditValueChanged, New EventHandler(AddressOf UpdateNeedleFeaturesPage)
        End Sub

        Protected Sub InitStateIndicatorFeaturesPage()
            statePageVal.Value = CInt(arcScaleComponent7.Value * 50F)
            AddHandler statePageVal.ValueChanged, New EventHandler(AddressOf UpdateStateIndicatorFeaturesPage)
        End Sub
    End Class
End Namespace
