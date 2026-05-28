Imports System
Imports DevExpress.Utils.Animation

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleProgressPanel
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleProgressPanel"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "progressPanel"
            End Get
        End Property

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        ' <comboBoxAnimationType>
        Private Sub comboBoxAnimationType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Select Case CStr(comboBoxAnimationType.SelectedItem)
                Case "Default"
                    progressPanelSample.WaitAnimationType = WaitingAnimatorType.Default
                Case "Line"
                    progressPanelSample.WaitAnimationType = WaitingAnimatorType.Line
                Case "Ring"
                    progressPanelSample.WaitAnimationType = WaitingAnimatorType.Ring
                Case "Bar"
                    progressPanelSample.WaitAnimationType = WaitingAnimatorType.Bar
            End Select

            ' <skip>
            spinFrameCount.Enabled = progressPanelSample.WaitAnimationType <> WaitingAnimatorType.Default
            spinFrameInterval.Enabled = progressPanelSample.WaitAnimationType <> WaitingAnimatorType.Default
            spinElementCount.Enabled = progressPanelSample.WaitAnimationType <> WaitingAnimatorType.Default
            spinAcceleration.Enabled = progressPanelSample.WaitAnimationType <> WaitingAnimatorType.Default
            spinSpeed.Enabled = progressPanelSample.WaitAnimationType <> WaitingAnimatorType.Default
            colorEditElementColor.Enabled = progressPanelSample.WaitAnimationType <> WaitingAnimatorType.Default
            spinLineHeight.Enabled = progressPanelSample.WaitAnimationType = WaitingAnimatorType.Line
            comboBoxLineElementType.Enabled = progressPanelSample.WaitAnimationType = WaitingAnimatorType.Line
            spinRingDiameter.Enabled = progressPanelSample.WaitAnimationType = WaitingAnimatorType.Ring
        ' </skip>
        End Sub

        ' </comboBoxAnimationType>
        ' <spinElementCount>
        Private Sub spinElementCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            progressPanelSample.AnimationElementCount = CInt(spinElementCount.Value)
        End Sub

        ' </spinElementCount>
        ' <spinAcceleration>
        Private Sub spinAcceleration_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            progressPanelSample.AnimationAcceleration = CSng(spinAcceleration.Value)
        End Sub

        ' </spinAcceleration>
        ' <spinSpeed>
        Private Sub spinSpeed_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            progressPanelSample.AnimationSpeed = CSng(spinSpeed.Value)
        End Sub

        ' </spinSpeed>
        ' <spinLineHeight>
        Private Sub spinLineHeight_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            progressPanelSample.LineAnimationElementHeight = CInt(spinLineHeight.Value)
        End Sub

        ' </spinLineHeight>
        ' <comboBoxLineElementType>
        Private Sub comboBoxLineElementType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Select Case CStr(comboBoxLineElementType.SelectedItem)
                Case "Circle"
                    progressPanelSample.LineAnimationElementType = LineAnimationElementType.Circle
                Case "Rectangle"
                    progressPanelSample.LineAnimationElementType = LineAnimationElementType.Rectangle
                Case "Triangle"
                    progressPanelSample.LineAnimationElementType = LineAnimationElementType.Triangle
            End Select
        End Sub

        ' </comboBoxLineElementType>
        ' <spinRingDiameter>
        Private Sub spinRingDiameter_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            progressPanelSample.RingAnimationDiameter = CInt(spinRingDiameter.Value)
        End Sub

        ' </spinRingDiameter>
        ' <colorEditElementColor>
        Private Sub colorEditElementColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            progressPanelSample.Appearance.ForeColor = colorEditElementColor.Color
        End Sub

        ' </colorEditElementColor>
        ' <spinFrameCount>
        Private Sub spinFrameCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            progressPanelSample.FrameCount = CInt(spinFrameCount.Value)
        End Sub

        ' </spinFrameCount>
        ' <spinFrameInterval>
        Private Sub spinFrameInterval_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            progressPanelSample.FrameInterval = CInt(spinFrameInterval.Value)
        End Sub
    ' </spinFrameInterval>
    End Class
End Namespace
