Imports System
Imports System.Drawing

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class ScaleBreaksDemo
        Inherits ChartDemoModuleWithOptions

        Private ReadOnly Property Axis As Axis
            Get
                Dim diagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
                Return If(diagram IsNot Nothing, diagram.AxisY, Nothing)
            End Get
        End Property

        Private ReadOnly Property AutoScaleBreaks As AutoScaleBreaks
            Get
                Return If(Axis IsNot Nothing, Axis.AutoScaleBreaks, Nothing)
            End Get
        End Property

        Private ReadOnly Property Options As ScaleBreakOptions
            Get
                Return If(Axis IsNot Nothing, Axis.ScaleBreakOptions, Nothing)
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            If AutoScaleBreaks IsNot Nothing Then
                checkEditShowScaleBreaks.Checked = AutoScaleBreaks.Enabled
                spinEditMaxCount.EditValue = AutoScaleBreaks.MaxCount
            End If

            If Options IsNot Nothing Then
                spinEditSize.EditValue = Options.SizeInPixels
                colorEditScaleBreakColor.EditValue = Options.Color
            End If

            UpdateControlsState()
        End Sub

        Private Sub UpdateControlsState()
            If Options Is Nothing OrElse AutoScaleBreaks Is Nothing Then Return
            spinEditMaxCount.Enabled = AutoScaleBreaks.Enabled
            spinEditSize.Enabled = AutoScaleBreaks.Enabled
            colorEditScaleBreakColor.Enabled = AutoScaleBreaks.Enabled
            simpleButtonRestoreColor.Enabled = AutoScaleBreaks.Enabled AndAlso Options.Color <> Color.Empty
        End Sub

        Private Sub checkEditShowScaleBreaks_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If AutoScaleBreaks IsNot Nothing Then AutoScaleBreaks.Enabled = checkEditShowScaleBreaks.Checked
            UpdateControlsState()
        End Sub

        Private Sub spinEditSize_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Options IsNot Nothing Then Options.SizeInPixels = Convert.ToInt32(spinEditSize.EditValue)
        End Sub

        Private Sub colorEditScaleBreakColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Options IsNot Nothing Then Options.Color = CType(colorEditScaleBreakColor.EditValue, Color)
            UpdateControlsState()
        End Sub

        Private Sub simpleButtonRestoreColor_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Options IsNot Nothing Then
                Options.Color = Color.Empty
                colorEditScaleBreakColor.EditValue = Options.Color
            End If
        End Sub

        Private Sub spinEditMaxCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If AutoScaleBreaks IsNot Nothing Then AutoScaleBreaks.MaxCount = Convert.ToInt32(spinEditMaxCount.EditValue)
        End Sub
    End Class
End Namespace
