Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGauges.Core.Model

Namespace DevExpress.XtraGauges.Demos

    Public Partial Class LinearGaugeFeatures
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub InitControls()
            InitScaleFeaturesPage()
            InitRangeBarFeaturesPage()
            InitStateIndicatorFeaturesPage()
            InitOtherFeaturesPage()
        End Sub

        Private Sub LinearGaugeFeatures_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitControls()
        End Sub

        Private Sub UpdateOtherFeaturesPage(ByVal sender As Object, ByVal e As EventArgs)
            linearScaleComponent6.Value = linearScaleComponent6.MinValue + linearScaleComponent6.ScaleLength * (CSng(trackBarControl1.Value) / CSng(trackBarControl1.Properties.Maximum))
            linearScaleComponent6.Labels(0).TextOrientation = CType([Enum].Parse(GetType(LabelOrientation), CStr(lblOrientation.EditValue)), LabelOrientation)
            linearScaleComponent6.Labels(0).Position = New Core.Base.PointF2D(CSng(horzLblPos.Value), CSng(vertLblPos.Value))
        End Sub

        Private Sub UpdateStateIndicatorFeaturesPage(ByVal sender As Object, ByVal e As EventArgs)
            linearScaleComponent5.Value = stateValTrack.Value
        End Sub

        Private Sub UpdateRangeBarFeaturesPage(ByVal sender As Object, ByVal e As EventArgs)
            linearScaleComponent4.Value = rbValue.Value
            linearScaleRangeBarComponent1.BeginUpdate()
            linearScaleRangeBarComponent1.AnchorValue = rbStartValue.Value
            linearScaleRangeBarComponent1.StartOffset = rbStartExtent.Value
            linearScaleRangeBarComponent1.EndOffset = rbEndExtent.Value
            linearScaleRangeBarComponent1.EndUpdate()
            linearScaleMarkerComponent1.BeginUpdate()
            linearScaleMarkerComponent1.ShapeOffset = markerOffset.Value
            linearScaleMarkerComponent1.ShapeType = CType([Enum].Parse(GetType(MarkerPointerShapeType), CStr(markerShape.EditValue)), MarkerPointerShapeType)
            linearScaleMarkerComponent1.EndUpdate()
        End Sub

        Private Sub UpdateScaleFeaturesPage(ByVal sender As Object, ByVal e As EventArgs)
            linearScaleComponent1.BeginUpdate()
            linearScaleComponent1.MinValue = rangeTrackLinear.Value.Minimum
            linearScaleComponent1.MaxValue = rangeTrackLinear.Value.Maximum
            linearScaleComponent1.Value = linearScaleComponent1.MinValue + linearScaleComponent1.ScaleLength * (CSng(valueTrack.Value) / CSng(valueTrack.Properties.Maximum))
            linearScaleComponent1.MinorTickCount = tickmarksCountTrack.Value
            linearScaleComponent1.MajorTickCount = labelsCountTrack.Value
            linearScaleComponent1.MajorTickmark.TextOffset = textExtentTrack.Value
            linearScaleComponent1.MajorTickmark.TextOrientation = CType([Enum].Parse(GetType(LabelOrientation), CStr(labelsOrientation.EditValue)), LabelOrientation)
            linearScaleComponent1.MinorTickmark.ShapeOffset = tickOffset.Value
            linearScaleComponent1.MajorTickmark.ShapeOffset = lblTickOffset.Value
            linearScaleComponent1.EndUpdate()
        End Sub

        Protected Sub SubscribeChanged(ByVal trackBar As TrackBarControl, ByVal handler As EventHandler)
            AddHandler trackBar.EditValueChanged, handler
        End Sub

        Protected Sub SubscribeChanged(ByVal combo As ComboBoxEdit, ByVal handler As EventHandler)
            AddHandler combo.SelectedIndexChanged, handler
        End Sub

        Protected Sub FillCombo(ByVal cbe As ComboBoxEdit, ByVal enumType As Type)
            Dim names As String() = [Enum].GetNames(enumType)
            For Each _name As String In names
                cbe.Properties.Items.Add(_name)
            Next
        End Sub

        Protected Sub FillCombo(ByVal cbe As ComboBoxEdit, ByVal enumType As Type, ByVal filter As String)
            Dim names As String() = [Enum].GetNames(enumType)
            For Each _name As String In names
                If _name.StartsWith(filter) Then cbe.Properties.Items.Add(_name)
            Next
        End Sub

        Protected Sub InitStateIndicatorFeaturesPage()
            stateValTrack.Value = CInt(linearScaleComponent5.Value)
            SubscribeChanged(stateValTrack, New EventHandler(AddressOf UpdateStateIndicatorFeaturesPage))
        End Sub

        Protected Sub InitRangeBarFeaturesPage()
            rbValue.Value = CInt(linearScaleComponent4.Value)
            rbStartValue.Value = CInt(linearScaleRangeBarComponent1.AnchorValue)
            rbStartExtent.Value = CInt(linearScaleRangeBarComponent1.StartOffset)
            rbEndExtent.Value = CInt(linearScaleRangeBarComponent1.EndOffset)
            FillCombo(markerShape, GetType(MarkerPointerShapeType))
            markerShape.EditValue = linearScaleMarkerComponent1.ShapeType.ToString()
            markerOffset.Value = CInt(linearScaleMarkerComponent1.ShapeOffset)
            SubscribeChanged(rbValue, New EventHandler(AddressOf UpdateRangeBarFeaturesPage))
            SubscribeChanged(rbStartValue, New EventHandler(AddressOf UpdateRangeBarFeaturesPage))
            SubscribeChanged(rbStartExtent, New EventHandler(AddressOf UpdateRangeBarFeaturesPage))
            SubscribeChanged(rbEndExtent, New EventHandler(AddressOf UpdateRangeBarFeaturesPage))
            AddHandler markerOffset.EditValueChanged, AddressOf UpdateRangeBarFeaturesPage
            AddHandler markerShape.EditValueChanged, AddressOf UpdateRangeBarFeaturesPage
        End Sub

        Protected Sub InitScaleFeaturesPage()
            rangeTrackLinear.Value = New Repository.TrackBarRange(CInt(linearScaleComponent1.MinValue), CInt(linearScaleComponent1.MaxValue))
            valueTrack.Value = CInt(linearScaleComponent1.Value)
            tickmarksCountTrack.Value = linearScaleComponent1.MinorTickCount
            labelsCountTrack.Value = linearScaleComponent1.MajorTickCount
            textExtentTrack.Value = CInt(linearScaleComponent1.MajorTickmark.TextOffset)
            tickOffset.Value = CInt(linearScaleComponent1.MinorTickmark.ShapeOffset)
            lblTickOffset.Value = CInt(linearScaleComponent1.MajorTickmark.ShapeOffset)
            SubscribeChanged(rangeTrackLinear, New EventHandler(AddressOf UpdateScaleFeaturesPage))
            SubscribeChanged(valueTrack, New EventHandler(AddressOf UpdateScaleFeaturesPage))
            SubscribeChanged(tickmarksCountTrack, New EventHandler(AddressOf UpdateScaleFeaturesPage))
            SubscribeChanged(labelsCountTrack, New EventHandler(AddressOf UpdateScaleFeaturesPage))
            SubscribeChanged(textExtentTrack, New EventHandler(AddressOf UpdateScaleFeaturesPage))
            SubscribeChanged(tickOffset, New EventHandler(AddressOf UpdateScaleFeaturesPage))
            SubscribeChanged(lblTickOffset, New EventHandler(AddressOf UpdateScaleFeaturesPage))
            FillCombo(labelsOrientation, GetType(LabelOrientation))
            labelsOrientation.Properties.Items.Remove(LabelOrientation.Radial.ToString())
            labelsOrientation.Properties.Items.Remove(LabelOrientation.Tangent.ToString())
            labelsOrientation.EditValue = linearScaleComponent1.MajorTickmark.TextOrientation.ToString()
            SubscribeChanged(labelsOrientation, New EventHandler(AddressOf UpdateScaleFeaturesPage))
            UpdateScaleFeaturesPage(Nothing, Nothing)
        End Sub

        Protected Sub InitOtherFeaturesPage()
            horzLblPos.EditValue = linearScaleComponent6.Labels(0).Position.X
            vertLblPos.EditValue = linearScaleComponent6.Labels(0).Position.Y
            FillCombo(lblOrientation, GetType(LabelOrientation))
            lblOrientation.Properties.Items.Remove(LabelOrientation.Radial.ToString())
            lblOrientation.Properties.Items.Remove(LabelOrientation.Tangent.ToString())
            lblOrientation.EditValue = linearScaleComponent6.Labels(0).TextOrientation.ToString()
            AddHandler horzLblPos.EditValueChanged, AddressOf UpdateOtherFeaturesPage
            AddHandler vertLblPos.EditValueChanged, AddressOf UpdateOtherFeaturesPage
            AddHandler trackBarControl1.EditValueChanged, AddressOf UpdateOtherFeaturesPage
            AddHandler lblOrientation.EditValueChanged, AddressOf UpdateOtherFeaturesPage
        End Sub
    End Class
End Namespace
