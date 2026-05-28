Imports DevExpress.XtraEditors
Imports DevExpress.XtraGauges.Win

Namespace DevExpress.XtraGauges.Demos

    Public Partial Class ColorSchemeGauges
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            gaugesDashboard1.ColorPicker = colorPickControl1
            AddHandler colorPickControl1.ResultColorChanged, AddressOf ColorPickControlResultColorChanged
        End Sub

        Private Sub ColorPickControlResultColorChanged(ByVal sender As Object, ByVal e As InnerColorPickControlSelectedColorChangedEventArgs)
            Dim activeGauge = GetActiveGauge()
            If activeGauge IsNot Nothing Then
                activeGauge.ColorScheme.Color = e.NewColor
                gaugesDashboard1.UpdateColor(e.NewColor)
            End If
        End Sub

        Private Function GetActiveGauge() As GaugeControl
            Dim dashboard = TryCast(ActiveControl, GaugesDashboard)
            If dashboard IsNot Nothing Then Return dashboard.ActiveGauge
            Return Nothing
        End Function
    End Class
End Namespace
