Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls
Imports System.Windows.Forms
Imports DevExpress.Tutorials

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleRangeTrackBar
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            AddHandler Load, AddressOf ModuleRangeTrackBar_Load1
        End Sub

        Private Sub ModuleRangeTrackBar_Load1(ByVal sender As Object, ByVal e As EventArgs)
            CalcContentCore()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleRangeTrackBar"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "rangetrackbar"
            End Get
        End Property

        Private updateValues As Boolean = False

        Private Sub ModuleRangeTrackBar_Load(ByVal sender As Object, ByVal e As EventArgs)
            SetDefaultProgressBarPosition()
            InitComboBoxes()
            InitValues()
        End Sub

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Protected Overrides Sub UnsubscribeOnEvents()
            MyBase.UnsubscribeOnEvents()
        End Sub

        Private Sub SetDefaultProgressBarPosition()
            UpdateTrackBarBounds(rangeTrackBarControl1)
        End Sub

        Private Sub UpdateTrackBarBounds(ByVal trackBar As TrackBarControl)
            If trackBar.Properties.Orientation = Orientation.Horizontal Then
                ControlUtils.HorzAlignControlInParent(trackBar, 16)
            Else
                ControlUtils.VertAlignControlInParent(trackBar, 32)
            End If

            ControlUtils.CenterControlInParent(trackBar)
        End Sub

        Private Sub InitComboBoxes()
            icbTickStyle.Properties.Items.AddEnum(GetType(TickStyle))
        End Sub

        Private Sub InitValues()
            updateValues = True
            checkEditVertical.Checked = rangeTrackBarControl1.Properties.Orientation = Orientation.Vertical
            icbTickStyle.EditValue = rangeTrackBarControl1.Properties.TickStyle
            seMinimum.Value = rangeTrackBarControl1.Properties.Minimum
            seMaximum.Value = rangeTrackBarControl1.Properties.Maximum
            seSmallChange.Value = rangeTrackBarControl1.Properties.SmallChange
            seLargeChange.Value = rangeTrackBarControl1.Properties.LargeChange
            seTickFrequency.Value = rangeTrackBarControl1.Properties.TickFrequency
            ceShowValue.Checked = rangeTrackBarControl1.Properties.ShowValueToolTip
            ceShowCustomValue.Enabled = rangeTrackBarControl1.Properties.ShowValueToolTip
            updateValues = False
            ShowValue()
        End Sub

        '<checkEditVertical>
        Private Sub checkEditVertical_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            rangeTrackBarControl1.Properties.Orientation = If(checkEditVertical.Checked, Orientation.Vertical, Orientation.Horizontal)
            UpdateTrackBarBounds(rangeTrackBarControl1)
        End Sub

        '</checkEditVertical>
        '<icbTickStyle>
        Private Sub icbTickStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            rangeTrackBarControl1.Properties.TickStyle = CType(icbTickStyle.EditValue, TickStyle)
        End Sub

        '</icbTickStyle>
        '<seMinimum>
        Private Sub seMinimum_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            rangeTrackBarControl1.Properties.Minimum = TutorialHelper.ConvertToInt(seMinimum.Value)
            seMinimum.Value = rangeTrackBarControl1.Properties.Minimum
        End Sub

        '</seMinimum>
        '<seMaximum>
        Private Sub seMaximum_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            rangeTrackBarControl1.Properties.Maximum = TutorialHelper.ConvertToInt(seMaximum.Value)
            seMaximum.Value = rangeTrackBarControl1.Properties.Maximum
        End Sub

        '</seMaximum>
        '<seSmallChange>
        Private Sub seSmallChange_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            rangeTrackBarControl1.Properties.SmallChange = TutorialHelper.ConvertToInt(seSmallChange.Value)
            seSmallChange.Value = rangeTrackBarControl1.Properties.SmallChange
        End Sub

        '</seSmallChange>
        '<seLargeChange>
        Private Sub seLargeChange_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            rangeTrackBarControl1.Properties.LargeChange = TutorialHelper.ConvertToInt(seLargeChange.Value)
            seLargeChange.Value = rangeTrackBarControl1.Properties.LargeChange
        End Sub

        '</seLargeChange>
        '<seTickFrequency>
        Private Sub seTickFrequency_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            rangeTrackBarControl1.Properties.TickFrequency = TutorialHelper.ConvertToInt(seTickFrequency.Value)
            seTickFrequency.Value = rangeTrackBarControl1.Properties.TickFrequency
        End Sub

        '</seTickFrequency>
        Private Sub rangeTrackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ShowValue()
        End Sub

        Private Sub ShowValue()
            lbValue.Text = rangeTrackBarControl1.Value.ToString()
        End Sub

        '<ceShowValue>
        Private Sub ceShowValue_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            rangeTrackBarControl1.Properties.ShowValueToolTip = ceShowValue.Checked
            ceShowCustomValue.Enabled = rangeTrackBarControl1.Properties.ShowValueToolTip
        End Sub

        '</ceShowValue>
        '<ceShowCustomValue>
        Private Sub rangeTrackBarControl1_BeforeShowValueToolTip(ByVal sender As Object, ByVal e As TrackBarValueToolTipEventArgs)
            If Not ceShowCustomValue.Checked Then Return
            e.ShowArgs.ToolTip = String.Format("Interval = [{0}; {1}]", rangeTrackBarControl1.Value.Minimum, rangeTrackBarControl1.Value.Maximum)
        End Sub
    '</ceShowCustomValue>
    End Class
End Namespace
