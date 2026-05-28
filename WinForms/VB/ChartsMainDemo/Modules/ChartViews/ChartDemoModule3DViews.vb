Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos

    Public Class ChartDemoModule3DViews
        Inherits ChartDemoModuleLabelViews

        Const DefaultPerspectiveText As String = "Default"

        Private ReadOnly Property Diagram3D As Diagram3D
            Get
                Return TryCast(ChartControl.Diagram, Diagram3D)
            End Get
        End Property

        Protected Overridable ReadOnly Property DefaultAnglesButton As SimpleButton
            Get
                Return Nothing
            End Get
        End Property

        Protected Overridable ReadOnly Property PerspectiveAngleComboBoxEdit As ComboBoxEdit
            Get
                Return Nothing
            End Get
        End Property

        Protected Overridable ReadOnly Property DefaultPerspective As Integer
            Get
                Return 50
            End Get
        End Property

        Private Sub OnDefaultAnglesButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            If Diagram3D Is Nothing Then Return
            Diagram3D.RotationType = RotationType.UseAngles
            UpdateRotationAngles(Diagram3D)
            Diagram3D.RotationType = RotationType.UseMouseAdvanced
        End Sub

        Private Sub OnPerspectiveAngleComboBoxEditSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Diagram3D Is Nothing OrElse PerspectiveAngleComboBoxEdit.SelectedIndex = -1 Then Return
            Dim perspectiveText As String = PerspectiveAngleComboBoxEdit.Text
            Diagram3D.PerspectiveAngle = If(Equals(perspectiveText, DefaultPerspectiveText), DefaultPerspective, Integer.Parse(perspectiveText))
        End Sub

        Protected Overridable Sub UpdateRotationAngles(ByVal diagram As Diagram3D)
        End Sub

        Protected Overrides Sub InitControls()
            MyBase.InitControls()
            PerspectiveAngleComboBoxEdit.Properties.Items.AddRange(New Object() {DefaultPerspectiveText, 0, 30, 45, 60, 90, 120, 135, 150})
            PerspectiveAngleComboBoxEdit.SelectedIndex = 0
            AddHandler PerspectiveAngleComboBoxEdit.SelectedIndexChanged, AddressOf OnPerspectiveAngleComboBoxEditSelectedIndexChanged
            AddHandler DefaultAnglesButton.Click, AddressOf OnDefaultAnglesButtonClick
        End Sub

        Protected Overrides Sub UpdateControlsCore()
            MyBase.UpdateControlsCore()
            If Diagram3D Is Nothing Then Return
            If Diagram3D.PerspectiveAngle = DefaultPerspective Then
                PerspectiveAngleComboBoxEdit.SelectedItem = DefaultPerspectiveText
            Else
                PerspectiveAngleComboBoxEdit.SelectedItem = Diagram3D.PerspectiveAngle
            End If
        End Sub
    End Class
End Namespace
