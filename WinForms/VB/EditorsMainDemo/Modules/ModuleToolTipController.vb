Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Utils.Behaviors.Common
Imports DevExpress.Utils.Text
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Demos.Modules

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleToolTipController
        Inherits TutorialControl

        Private _clockLabelControl As LabelControl

        Private _timerControl As TimerControl

        Public Sub New()
            InitializeComponent()
            If tabPane1 IsNot Nothing Then AddHandler tabPane1.SelectedPageChanged, AddressOf OnSelectedPageChanged
        End Sub

        Private Sub OnSelectedPageChanged(ByVal sender As Object, ByVal e As SelectedPageChangedEventArgs)
            CalcContentCore()
        End Sub

        Protected Overrides Sub UnsubscribeOnEvents()
            MyBase.UnsubscribeOnEvents()
            If tabPane1 IsNot Nothing Then RemoveHandler tabPane1.SelectedPageChanged, AddressOf OnSelectedPageChanged
        End Sub

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
            CalcLayoutControlBounds(layoutControl2)
            CalcLayoutControlBounds(layoutControl3)
            CalcLayoutControlBounds(layoutControl4)
        End Sub

        Private updateValues As Boolean = False

        Private titleStyleToolTip As String() = New String() {"ToolTip Controller component", "<b>ToolTip <i>Controller  </i>component"}

        Private textStyleToolTip As String() = New String() {"Enables you to customize the appearance and behavior of hints displayed for controls or their elements.", "Enables<size=8> you to <size=14>customize <size=8>the appearance and behavior of <u>hints</u> displayed for controls or their elements."}

        Private footerStyleToolTip As String() = New String() {"To learn more, see the help documentation", "<color=Blue>To learn more, see the <u>help documentation"}

        Private Sub ModuleToolTipController_Load(ByVal sender As Object, ByVal e As EventArgs)
            Tutorials.ControlUtils.CenterControlInParent(lbSample)
            lbSample.Top += 5
            Tutorials.ControlUtils.CenterControlInParent(lbSampleManual)
            lbSampleManual.Top += 5
            Tutorials.ControlUtils.CenterControlInParent(lbStyleSample)
            lbStyleSample.Top += 5
            InitValues()
            InitToolTips()
        End Sub

        Private Sub InitToolTips()
        End Sub

        Private Sub InitValues()
            updateValues = True
            toolTipControllerContentProperties1.Init(toolTipController1, lbSample, "This tooltip is automatically displayed" & Microsoft.VisualBasic.Constants.vbCrLf & "when the mouse hovers over the control.", "Auto-popup tooltip.", False)
            toolTipControllerContentProperties2.Init(toolTipController1, lbSampleManual, "This tooltip is displayed using the ShowHint method.", "Manually-popup tooltip.", True)
            seAutoPopDelay.Value = toolTipController1.AutoPopDelay
            seInitialDelay.Value = toolTipController1.InitialDelay
            seRoundRadius.Value = toolTipController1.RoundRadius
            ceRounded.Checked = toolTipController1.Rounded
            ceShowBeak.Checked = toolTipController1.ShowBeak
            ceShowShadow.Checked = toolTipController1.ShowShadow
            propertyGrid1.SelectedObject = New Utils.Design.FilterObject(toolTipController1.Appearance, New String() {"BackColor", "BackColor2", "BorderColor", "GradientMode", "Font", "ForeColor", "TextOptions"})
            propertyGrid2.SelectedObject = New Utils.Design.FilterObject(toolTipController1.AppearanceTitle, New String() {"Font", "ForeColor", "TextOptions"})
            Dim arr As Array = [Enum].GetValues(GetType(ToolTipType))
            For Each type As ToolTipType In arr
                If type = ToolTipType.Default Then Continue For
                icbType.Properties.Items.Add(New ImageComboBoxItem(type.ToString(), type, -1))
            Next

            icbType.EditValue = toolTipStyleController.ToolTipType
            chAllowHTML.Checked = toolTipStyleController.AllowHtmlText
            SetStyleTooltip()
            updateValues = False
        End Sub

        Private Sub seAutoPopDelay_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            toolTipController1.AutoPopDelay = Convert.ToInt32(seAutoPopDelay.Value)
        End Sub

        Private Sub seInitialDelay_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            toolTipController1.InitialDelay = Convert.ToInt32(seInitialDelay.Value)
        End Sub

        Private Sub seRoundRadius_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            toolTipController1.RoundRadius = Convert.ToInt32(seRoundRadius.Value)
        End Sub

        Private Sub ceRounded_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            toolTipController1.Rounded = ceRounded.Checked
        End Sub

        Private Sub ceShowBeak_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            toolTipController1.ShowBeak = ceShowBeak.Checked
        End Sub

        Private Sub ceShowShadow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            toolTipController1.ShowShadow = ceShowShadow.Checked
        End Sub

        Private Sub pceToolTipLocation_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            pceToolTipLocation.Properties.PopupFormMinSize = toolTipLocationControl.Size
            pceToolTipLocation.Properties.PopupSizeable = False
        End Sub

        Private Sub pceToolTipLocation_QueryDisplayText(ByVal sender As Object, ByVal e As XtraEditors.Controls.QueryDisplayTextEventArgs)
            e.DisplayText = toolTipLocationControl.ToolTipLocationName
        End Sub

        Private Sub toolTipLocationControl_ToolTipLocationChanged(ByVal sender As Object, ByVal e As EventArgs)
            pceToolTipLocation.Refresh()
            Dim args As ToolTipControllerShowEventArgs = toolTipController1.CreateShowArgs()
            args.ToolTip = "Test"
            args.IconType = ToolTipIconType.Information
            args.ImageIndex = -1
            args.IconSize = ToolTipIconSize.Small
            toolTipController1.ShowHint(args, lbSample)
        End Sub

        Private Sub lbSampleManual_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim args As ToolTipControllerShowEventArgs = toolTipControllerContentProperties2.CreateShowArgs()
            toolTipController1.ShowHint(args, lbSampleManual.PointToScreen(New Point(e.X, e.Y)))
        End Sub

        Private Sub xtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As XtraTab.TabPageChangedEventArgs)
            toolTipController1.HideHint()
        End Sub

        Protected Overrides Sub DoHide()
            toolTipController1.HideHint()
        End Sub

        Private Sub icbType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            toolTipStyleController.ToolTipType = CType(icbType.EditValue, ToolTipType)
            SetStyleTooltip()
        End Sub

        Private Sub chAllowHTML_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            toolTipStyleController.AllowHtmlText = chAllowHTML.Checked
            SetStyleTooltip()
        End Sub

        Private Sub SetStyleTooltip()
            Dim index As Integer = If(toolTipStyleController.AllowHtmlText, 1, 0)
            Dim canRemoveFormating As Boolean = toolTipStyleController.ToolTipType = ToolTipType.Flyout OrElse toolTipStyleController.ToolTipType = ToolTipType.Html
            If toolTipStyleController.ToolTipType = ToolTipType.SuperTip OrElse canRemoveFormating Then
                Dim superToolTip As SuperToolTip = New SuperToolTip()
                Dim toolTipItem As ToolTipItem = New ToolTipItem()
                toolTipItem.Text = If(canRemoveFormating, StringPainter.Default.RemoveFormat(textStyleToolTip(index)), textStyleToolTip(index))
                toolTipItem.ImageOptions.SvgImage = svgImageCollection1(0)
                superToolTip.Items.AddTitle(If(canRemoveFormating, StringPainter.Default.RemoveFormat(titleStyleToolTip(index)), titleStyleToolTip(index)))
                superToolTip.Items.Add(toolTipItem)
                superToolTip.Items.AddSeparator()
                superToolTip.Items.AddTitle(If(canRemoveFormating, StringPainter.Default.RemoveFormat(footerStyleToolTip(index)), footerStyleToolTip(index)))
                toolTipStyleController.SetSuperTip(lbStyleSample, superToolTip)
            Else
                toolTipStyleController.SetToolTip(lbStyleSample, textStyleToolTip(index))
                toolTipStyleController.SetTitle(lbStyleSample, titleStyleToolTip(index))
                toolTipStyleController.SetToolTipIconType(lbStyleSample, ToolTipIconType.Information)
            End If
        End Sub

        Private ReadOnly Property ClockLabelControl As LabelControl
            Get
                If _clockLabelControl Is Nothing Then
                    _clockLabelControl = New LabelControl()
                    _clockLabelControl.AllowHtmlString = True
                    _clockLabelControl.Text = "<b><size=+5>12:00:00 AM</b><br>Wednesday, September 30, 2110"
                    _clockLabelControl.Padding = New Padding(10)
                    _clockLabelControl.AutoSizeMode = LabelAutoSizeMode.Vertical
                    _clockLabelControl.ImageOptions.SvgImage = svgImageCollection1(1)
                    behaviorManager1.Attach(Of ClockBehavior)(_clockLabelControl, Sub(behavior)
                        behavior.Properties.TimeOptions.Color = Color.CornflowerBlue
                        behavior.Properties.TimeOptions.FontStyle = FontStyle.Bold
                        behavior.Properties.TimeOptions.FontSizeDelta = 5
                    End Sub)
                    _clockLabelControl.ImageAlignToText = ImageAlignToText.LeftCenter
                    _clockLabelControl.IndentBetweenImageAndText = 10
                    _clockLabelControl.Size = _clockLabelControl.CalcBestSize()
                    AddHandler _clockLabelControl.SizeChanged, AddressOf ClockLabelControl_SizeChanged
                End If

                Return _clockLabelControl
            End Get
        End Property

        Private clockLabelControlSizeChanging As Boolean = False

        Private Sub ClockLabelControl_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            If clockLabelControlSizeChanging Then Return
            clockLabelControlSizeChanging = True
            Dim bestSize As Size = ClockLabelControl.CalcBestSize()
            If ClockLabelControl.Size <> bestSize Then ClockLabelControl.Size = bestSize
            clockLabelControlSizeChanging = False
        End Sub

        Private ReadOnly Property TimerControl As TimerControl
            Get
                If _timerControl Is Nothing Then _timerControl = New TimerControl()
                Return _timerControl
            End Get
        End Property

        Private Sub OnShowBeakChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As CheckEdit = TryCast(sender, CheckEdit)
            flyoutToolTipController.ShowBeak = edit.Checked
        End Sub

        Private Sub OnGetActiveObjectInfo(ByVal sender As Object, ByVal e As ToolTipControllerGetActiveObjectInfoEventArgs)
            If e.Info Is Nothing Then
                e.Info = New ToolTipControlInfo() With {.[Object] = e.SelectedControl}
                If radioGroupExamples.SelectedIndex = 0 Then
                    e.Info.FlyoutControl = ClockLabelControl
                Else
                    e.Info.FlyoutControl = TimerControl
                End If
            End If
        End Sub
    End Class
End Namespace
