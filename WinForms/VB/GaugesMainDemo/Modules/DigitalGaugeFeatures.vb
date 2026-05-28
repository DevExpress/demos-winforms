Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraGauges.Core.Model

Namespace DevExpress.XtraGauges.Demos

    Public Partial Class DigitalGaugeFeatures
        Inherits TutorialControl

        Private customMap As Dictionary(Of Char, Byte())

        Private emptyMap As Dictionary(Of Char, Byte())

        Public Sub New()
            emptyMap = New Dictionary(Of Char, Byte())()
            customMap = New Dictionary(Of Char, Byte())()
            CreateCustomCharacterMap()
            InitializeComponent()
            gaugeNumber.Properties.Mask.Culture = CType(Globalization.CultureInfo.InvariantCulture.Clone(), Globalization.CultureInfo)
            gaugeNumber.Properties.Mask.Culture.NumberFormat.NumberGroupSeparator = "`"
            gaugeTime.Properties.Mask.Culture = Globalization.CultureInfo.InvariantCulture
            InitGauge()
        End Sub

        Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateGauge()
        End Sub

        Private Sub textEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            radioGroup1.SelectedIndex = 0
            UpdateGauge()
        End Sub

        Private Sub textEdit3_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            radioGroup1.SelectedIndex = 1
            UpdateGauge()
        End Sub

        Private Sub textEdit2_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            radioGroup1.SelectedIndex = 2
            UpdateGauge()
        End Sub

        Private Sub trackBarControl1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateGauge()
        End Sub

        Private Sub comboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateGauge()
        End Sub

        Private Sub OnUseCustomCharacterMap(ByVal sender As Object, ByVal e As EventArgs)
            dGauge.BeginUpdate()
            UserCharacterMap.Load(If(useCustomCharacterMap.Checked, customMap, emptyMap))
            dGauge.Text = "AAAAAA"
            dGauge.EndUpdate()
            UpdateGauge()
        End Sub

        Private Sub CreateCustomCharacterMap()
            customMap.Add("G"c, New Byte() {&H1C, &H1C, &H1C, &H08, &H18, &H3C, &H5A, &H5A, &H18, &H18, &H18, &H24, &H44, &HC6})
            customMap.Add("a"c, New Byte() {&H1C, &H1C, &H1C, &H48, &H58, &H3C, &H1A, &H1A, &H18, &H18, &H18, &H24, &H42, &HC3})
            customMap.Add("u"c, New Byte() {&H1C, &H1C, &H1C, &H08, &H18, &H3C, &H5A, &H5A, &H18, &H18, &H18, &H24, &H44, &HC6})
            customMap.Add("g"c, New Byte() {&H1C, &H1C, &H1D, &H09, &H1e, &H3C, &H58, &H58, &H18, &H18, &H18, &H24, &H44, &HC6})
            customMap.Add("e"c, New Byte() {&H1C, &H1C, &H1C, &H08, &H18, &H3C, &H5A, &H5A, &H18, &H18, &H18, &H24, &H44, &HC6})
            customMap.Add("s"c, New Byte() {&H1C, &H1C, &H1C, &H48, &H58, &H3C, &H1A, &H1A, &H18, &H18, &H18, &H24, &H42, &HC3})
        End Sub

        Protected Sub UpdateGauge()
            dGauge.DisplayMode = CType([Enum].Parse(GetType(DigitalGaugeDisplayMode), CStr(gaugeMode.EditValue)), DigitalGaugeDisplayMode)
            useCustomCharacterMap.Enabled = dGauge.DisplayMode = DigitalGaugeDisplayMode.Matrix8x14
            If Not useCustomCharacterMap.Enabled Then useCustomCharacterMap.Checked = False
            Select Case radioGroup1.SelectedIndex
                Case 0
                    dGauge.Text = gaugeText.EditValue.ToString()
                Case 1
                    dGauge.Text = gaugeTime.Properties.GetDisplayText(gaugeTime.Properties.DisplayFormat, gaugeTime.EditValue)
                Case 2
                    Dim txt As String = gaugeNumber.Text
                    If txt.Replace("`", "").Replace(".", "").Length > 6 Then
                        dGauge.Text = "OVRFLW"
                    Else
                        dGauge.Text = gaugeNumber.Text
                    End If

            End Select

            dGauge.LetterSpacing = letterSpacing.Value
        End Sub

        Protected Sub InitGauge()
            useCustomCharacterMap.Enabled = False
            radioGroup1.SelectedIndex = 0
            gaugeMode.Properties.Items.Add(DigitalGaugeDisplayMode.FourteenSegment.ToString())
            gaugeMode.Properties.Items.Add(DigitalGaugeDisplayMode.SevenSegment.ToString())
            gaugeMode.Properties.Items.Add(DigitalGaugeDisplayMode.Matrix5x8.ToString())
            gaugeMode.Properties.Items.Add(DigitalGaugeDisplayMode.Matrix8x14.ToString())
        End Sub

        Protected Overrides ReadOnly Property AllowBorderRounding As Boolean?
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
