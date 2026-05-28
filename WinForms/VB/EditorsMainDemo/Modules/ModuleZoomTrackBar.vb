Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Tutorials
Imports DevExpress.XtraLayout

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleZoomTrackBar
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            AddHandler Load, AddressOf ModuleZoomTrackBar_Load1
        End Sub

        Private Sub ModuleZoomTrackBar_Load1(ByVal sender As Object, ByVal e As EventArgs)
            CalcContentCore()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleZoomTrackBar"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "zoomTrackBar"
            End Get
        End Property

        Private updateValues As Boolean = False

        Private Sub ModuleZoomTrackBar_Load(ByVal sender As Object, ByVal e As EventArgs)
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
            UpdateTrackBarBounds(zoomTrackBarControl1)
        End Sub

        Private Sub UpdateTrackBarBounds(ByVal trackBar As ZoomTrackBarControl)
            If trackBar.Properties.Orientation = Orientation.Horizontal Then
                ControlUtils.HorzAlignControlInParent(trackBar, 16)
            Else
                ControlUtils.VertAlignControlInParent(trackBar, 32)
            End If

            ControlUtils.CenterControlInParent(trackBar)
        End Sub

        Private Sub InitComboBoxes()
            icbScrollThumbStyle.Properties.Items.AddEnum(GetType(ScrollThumbStyle))
        End Sub

        Private Sub InitValues()
            updateValues = True
            checkEditVertical.Checked = zoomTrackBarControl1.Properties.Orientation = Orientation.Vertical
            icbScrollThumbStyle.EditValue = zoomTrackBarControl1.Properties.ScrollThumbStyle
            seMinimum.Value = zoomTrackBarControl1.Properties.Minimum
            seMaximum.Value = zoomTrackBarControl1.Properties.Maximum
            seSmallChange.Value = zoomTrackBarControl1.Properties.SmallChange
            seLargeChange.Value = zoomTrackBarControl1.Properties.LargeChange
            seMiddle.Value = zoomTrackBarControl1.Properties.Middle
            checkEditUseMiddleValue.Checked = zoomTrackBarControl1.Properties.AllowUseMiddleValue
            updateValues = False
            ShowValue()
        End Sub

        '<checkEditVertical>
        Private Sub checkEditVertical_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            zoomTrackBarControl1.Properties.Orientation = If(checkEditVertical.Checked, Orientation.Vertical, Orientation.Horizontal)
            UpdateTrackBarBounds(zoomTrackBarControl1)
        End Sub

        '</checkEditVertical>
        '<icbScrollThumbStyle>
        Private Sub icbScrollThumbStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            zoomTrackBarControl1.Properties.ScrollThumbStyle = CType(icbScrollThumbStyle.EditValue, ScrollThumbStyle)
        End Sub

        '</icbScrollThumbStyle>
        Private Sub UpdateMiddleParameters()
            If Not checkEditUseMiddleValue.Checked Then Return
            seMiddle.Value = zoomTrackBarControl1.Properties.Middle
            checkEditUseMiddleValue.Checked = zoomTrackBarControl1.Properties.AllowUseMiddleValue
        End Sub

        '<seMinimum>
        Private Sub seMinimum_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            zoomTrackBarControl1.Properties.Minimum = TutorialHelper.ConvertToInt(seMinimum.Value)
            seMinimum.Value = zoomTrackBarControl1.Properties.Minimum
            UpdateMiddleParameters()
        End Sub

        '</seMinimum>
        '<seMaximum>
        Private Sub seMaximum_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            zoomTrackBarControl1.Properties.Maximum = TutorialHelper.ConvertToInt(seMaximum.Value)
            seMaximum.Value = zoomTrackBarControl1.Properties.Maximum
            UpdateMiddleParameters()
        End Sub

        '</seMaximum>
        '<seSmallChange>
        Private Sub seSmallChange_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            zoomTrackBarControl1.Properties.SmallChange = TutorialHelper.ConvertToInt(seSmallChange.Value)
            seSmallChange.Value = zoomTrackBarControl1.Properties.SmallChange
        End Sub

        '</seSmallChange>
        '<seLargeChange>
        Private Sub seLargeChange_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            zoomTrackBarControl1.Properties.LargeChange = TutorialHelper.ConvertToInt(seLargeChange.Value)
            seLargeChange.Value = zoomTrackBarControl1.Properties.LargeChange
        End Sub

        '</seLargeChange>
        Private Sub zoomTrackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ShowValue()
        End Sub

        Private Sub ShowValue()
            lbValue.Text = zoomTrackBarControl1.Value.ToString()
        End Sub

        '<checkEditUseMiddleValue>
        Private Sub checkEditUseMiddleValue_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            '<skip>
            If updateValues Then Return
            '</skip>
            If checkEditUseMiddleValue.Checked Then
                zoomTrackBarControl1.Properties.AllowUseMiddleValue = True
                seMiddle.Enabled = zoomTrackBarControl1.Properties.AllowUseMiddleValue
            Else
                zoomTrackBarControl1.Properties.AllowUseMiddleValue = False
                seMiddle.Enabled = zoomTrackBarControl1.Properties.AllowUseMiddleValue
            End If

            UpdateMiddleParameters()
            Try
                zoomTrackBarControl1.Properties.Middle = TutorialHelper.ConvertToInt(seMiddle.Value)
            Catch __unusedArgumentException1__ As ArgumentException
                seMiddle.Value = zoomTrackBarControl1.Properties.Middle
            End Try
        End Sub

        '</checkEditUseMiddleValue>
        '<seMiddle>
        Private Sub seMiddle_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            '<skip>
            If updateValues Then Return
            '</skip>
            Try
                zoomTrackBarControl1.Properties.Middle = TutorialHelper.ConvertToInt(seMiddle.Value)
                seMiddle.Value = zoomTrackBarControl1.Properties.Middle
            Catch __unusedArgumentException1__ As ArgumentException
                seMiddle.Value = zoomTrackBarControl1.Properties.Middle
            End Try
        End Sub
    '</seMiddle>
    End Class
End Namespace
