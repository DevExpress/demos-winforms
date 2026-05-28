Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGauges.Win

Namespace DevExpress.XtraGauges.Demos

    Public Partial Class GaugesDashboard
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
        End Sub

        <System.ComponentModel.DefaultValue(CType(Nothing, Object))>
        Public Property ColorPicker As ColorPickerControl

        Protected Friend Sub UpdateColor(ByVal color As Color)
            If ColorPicker IsNot Nothing Then ColorPicker.SetColor(color)
        End Sub

        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateColor()
        End Sub

        Private Sub UpdateColor()
            gasGauge.Color = CommonSkins.GetSkin(LookAndFeel).Colors.GetColor("Information")
            coldWGauge.Color = CommonSkins.GetSkin(LookAndFeel).Colors.GetColor("Question")
            hotWGauge.Color = CommonSkins.GetSkin(LookAndFeel).Colors.GetColor("Critical")
            electricityGauge.Color = CommonSkins.GetSkin(LookAndFeel).Colors.GetColor("Warning")
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            UpdateColor()
        End Sub

        Public ReadOnly Property ActiveGauge As GaugeControl
            Get
                If ActiveControl IsNot Nothing AndAlso TypeOf ActiveControl Is GaugeContent Then
                    Return TryCast(ActiveControl, GaugeContent).Gauge
                End If

                Return Nothing
            End Get
        End Property
    End Class
End Namespace
