Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleTrackBar
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleTrackBar"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "TrackBar"
            End Get
        End Property

        Private updateValues As Boolean = False

        Private Sub ModuleTrackBar_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitComboBoxes()
            InitValues()
            CalcContentCore()
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Private Sub InitComboBoxes()
            icbTickStyle.Properties.Items.AddEnum(GetType(TickStyle))
        End Sub

        Private Sub InitValues()
            updateValues = True
            checkEditVertical.Checked = trackBarControl1.Properties.Orientation = Orientation.Vertical
            icbTickStyle.EditValue = trackBarControl1.Properties.TickStyle
            seMinimum.Value = trackBarControl1.Properties.Minimum
            seMaximum.Value = trackBarControl1.Properties.Maximum
            seLabelDistance.Value = trackBarControl1.Properties.DistanceFromTickToLabel
            seSmallChange.Value = trackBarControl1.Properties.SmallChange
            seLargeChange.Value = trackBarControl1.Properties.LargeChange
            seTickFrequency.Value = trackBarControl1.Properties.TickFrequency
            ceShowValue.Checked = trackBarControl1.Properties.ShowValueToolTip
            ceShowCustomValue.Enabled = trackBarControl1.Properties.ShowValueToolTip
            ceShowTickLabels.Checked = trackBarControl1.Properties.ShowLabels
            updateValues = False
        End Sub

        '<checkEditVertical>
        Private Sub checkEditVertical_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            trackBarControl1.Properties.Orientation = If(checkEditVertical.Checked, Orientation.Vertical, Orientation.Horizontal)
            CalcContentCore()
        End Sub

        '</checkEditVertical>
        '<icbTickStyle>
        Private Sub icbTickStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            trackBarControl1.Properties.TickStyle = CType(icbTickStyle.EditValue, TickStyle)
            CalcContentCore()
        End Sub

        '</icbTickStyle>
        '<seMinimum>
        Private Sub seMinimum_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            trackBarControl1.Properties.Minimum = TutorialHelper.ConvertToInt(seMinimum.Value)
            seMinimum.Value = trackBarControl1.Properties.Minimum
            If trackBarControl1.Properties.ShowLabels Then
                CreateNewLabelCollection()
                CalcContentCore()
            End If
        End Sub

        '</seMinimum>
        '<seMaximum>
        Private Sub seMaximum_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            trackBarControl1.Properties.Maximum = TutorialHelper.ConvertToInt(seMaximum.Value)
            seMaximum.Value = trackBarControl1.Properties.Maximum
            If trackBarControl1.Properties.ShowLabels Then
                CreateNewLabelCollection()
                CalcContentCore()
            End If
        End Sub

        '</seMaximum>
        '<seSmallChange>
        Private Sub seSmallChange_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            trackBarControl1.Properties.SmallChange = TutorialHelper.ConvertToInt(seSmallChange.Value)
            seSmallChange.Value = trackBarControl1.Properties.SmallChange
        End Sub

        '</seSmallChange>
        '<seLargeChange>
        Private Sub seLargeChange_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            trackBarControl1.Properties.LargeChange = TutorialHelper.ConvertToInt(seLargeChange.Value)
            seLargeChange.Value = trackBarControl1.Properties.LargeChange
        End Sub

        '</seLargeChange>
        '<seTickFrequency>
        Private Sub seTickFrequency_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            trackBarControl1.Properties.TickFrequency = TutorialHelper.ConvertToInt(seTickFrequency.Value)
            seTickFrequency.Value = trackBarControl1.Properties.TickFrequency
        End Sub

        '</seTickFrequency>
        '<ceShowValue>
        Private Sub ceShowValue_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            trackBarControl1.Properties.ShowValueToolTip = ceShowValue.Checked
            ceShowCustomValue.Enabled = trackBarControl1.Properties.ShowValueToolTip
        End Sub

        '</ceShowValue>
        '<ceShowCustomValue>
        Private Sub trackBarControl1_BeforeShowValueToolTip(ByVal sender As Object, ByVal e As TrackBarValueToolTipEventArgs)
            If Not ceShowCustomValue.Checked Then Return
            e.ShowArgs.ToolTip = String.Format("Value = {0}", trackBarControl1.Value)
        End Sub

        '</ceShowCustomValue>
        '<ceShowTickLabels>
        Private Sub ceShowTickLabels_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            trackBarControl1.Properties.ShowLabels = ceShowTickLabels.Checked
            If trackBarControl1.Properties.ShowLabels Then CreateNewLabelCollection()
            seLabelDistance.Enabled = trackBarControl1.Properties.ShowLabels
            CalcContentCore()
        End Sub

        '</ceShowTickLabels>
        '<seLabelDistance>
        Private Sub seLabelDistance_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            trackBarControl1.Properties.DistanceFromTickToLabel = TutorialHelper.ConvertToInt(seLabelDistance.Value)
            CalcContentCore()
        End Sub

        '</seLabelDistance>
        '<ceShowTickLabels>
        Private Sub CreateNewLabelCollection()
            Dim [step] As Integer = 1
            Dim itemsCount As Integer = trackBarControl1.Properties.Maximum - trackBarControl1.Properties.Minimum + 1
            trackBarControl1.Properties.Labels.Clear()
            If itemsCount > 5 Then
                [step] = itemsCount \ 5
            End If

            Dim i As Integer = trackBarControl1.Properties.Minimum
            While i <= trackBarControl1.Properties.Maximum
                Dim label As TrackBarLabel = New TrackBarLabel() With {.Value = i, .Label = i.ToString()}
                trackBarControl1.Properties.Labels.Add(label)
                i += [step]
            End While
        End Sub
    '</ceShowTickLabels>
    End Class
End Namespace
