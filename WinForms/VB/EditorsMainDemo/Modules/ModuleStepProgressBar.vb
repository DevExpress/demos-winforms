'<ceShowIndicatorIcons>
'<ceShowStepIcons>
Imports DevExpress.Utils.Svg
'</ceShowStepIcons>
'</ceShowIndicatorIcons>
Imports System
'<icbOrientation>
Imports System.Windows.Forms

'</ceFillIndicators>
Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleStepProgressBar
        Inherits TutorialControl

        Private inInitialization As Boolean = False

        Private incrementAnimation As Boolean = True

        Const timerSleepInterval As Integer = 1000

        Const itemInterval As Integer = 4

        Private timer As Timer

        '<ceShowStepIcons>
        '<ceShowIndicatorIcons>
        Private resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModuleStepProgressBar))

        '</ceShowStepIcons>
        '</ceShowIndicatorIcons>
        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleStepProgressBar"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "stepProgressBar"
            End Get
        End Property

        Private Sub ModuleStepProgressBar_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitComboBoxes()
            InitValues()
            InitTimer()
        End Sub

        Private Sub InitComboBoxes()
            icbOrientation.Properties.Items.AddEnum(GetType(Orientation))
        End Sub

        Private Sub InitValues()
            inInitialization = True
            tbcSelectStep.Value = stepProgressBarSample.SelectedItemIndex
            icbOrientation.EditValue = stepProgressBarSample.Orientation
            ceInversedProgressDirection.Checked = stepProgressBarSample.InversedProgressDirection
            ceDrawConnectors.Checked = stepProgressBarSample.DrawConnectors
            ceFillIndicators.Checked = stepProgressBarSample.ItemOptions.Indicator.InactiveStateDrawMode = IndicatorDrawMode.Full
            ceDrawShadows.Checked = True
            ceAllowUserInteraction.Checked = stepProgressBarSample.AllowUserInteraction = Utils.DefaultBoolean.True
            inInitialization = False
        End Sub

        Private Sub InitTimer()
            timer = New Timer() With {.Interval = itemInterval}
            Dim item As StepProgressBarItem = stepProgressBarSample.SelectedItem
            AddHandler timer.Tick, Sub(ss, ee)
                timer.Interval = itemInterval
                item.Progress += If(incrementAnimation, 1, -1)
                If item.IsActive Then
                    If item.IsLastItem Then
                        timer.Interval = timerSleepInterval
                        incrementAnimation = False
                        Return
                    End If

                    item = item.GetNextItem()
                End If

                If item.Progress = 0 AndAlso Not incrementAnimation Then
                    If item Is itemShippingOptions Then
                        timer.Interval = timerSleepInterval
                        incrementAnimation = True
                        Return
                    End If

                    item = item.GetPreviousItem()
                End If
            End Sub
            timer.Enabled = ceAllowAnimation.Checked
        End Sub

        '<tbcSelectStep>
        Private Sub tbcSelectStep_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            stepProgressBarSample.SelectedItemIndex = tbcSelectStep.Value
        End Sub

        '</tbcSelectStep>
        '<icbOrientation>
        Private Sub icbOrientation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            '<skip>
            If inInitialization Then Return
            '</skip>
            stepProgressBarSample.Orientation = CType(icbOrientation.EditValue, Orientation)
        End Sub

        '</icbOrientation>
        '<ceInversedProgressDirection>
        Private Sub ceInversedProgressDirection_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            '<skip>
            If inInitialization Then Return
            '</skip>
            stepProgressBarSample.InversedProgressDirection = ceInversedProgressDirection.Checked
        End Sub

        '</ceInversedProgressDirection>
        '<ceDrawConnectors>
        Private Sub ceDrawConnectors_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            '<skip>
            If inInitialization Then Return
            '</skip>
            stepProgressBarSample.DrawConnectors = ceDrawConnectors.Checked
        End Sub

        '</ceDrawConnectors>
        '<ceFillIndicators>
        Private Sub ceFillIndicators_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            '<skip>
            If inInitialization Then Return
            '</skip>
            stepProgressBarSample.ItemOptions.Indicator.InactiveStateDrawMode = If(ceFillIndicators.Checked, IndicatorDrawMode.Full, IndicatorDrawMode.Outline)
        End Sub

        '</ceFillIndicators>
        '<ceShowStepIcons>
        Private Sub ceShowStepIcons_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            itemPaymentDetails.ContentBlock1.ActiveStateImageOptions.SvgImage = If(ceShowStepIcons.Checked, CType(resources.GetObject("itemPaymentDetails.ContentBlock1.ActiveStateImageOptions.SvgImage"), SvgImage), Nothing)
            itemPaymentDetails.ContentBlock1.InactiveStateImageOptions.SvgImage = If(ceShowStepIcons.Checked, CType(resources.GetObject("itemPaymentDetails.ContentBlock1.InactiveStateImageOptions.SvgImage"), SvgImage), Nothing)
            itemShippingOptions.ContentBlock1.ActiveStateImageOptions.SvgImage = If(ceShowStepIcons.Checked, CType(resources.GetObject("itemShippingOptions.ContentBlock1.ActiveStateImageOptions.SvgImage"), SvgImage), Nothing)
            itemShippingOptions.ContentBlock1.InactiveStateImageOptions.SvgImage = If(ceShowStepIcons.Checked, CType(resources.GetObject("itemShippingOptions.ContentBlock1.InactiveStateImageOptions.SvgImage"), SvgImage), Nothing)
            itemConfirmation.ContentBlock1.ActiveStateImageOptions.SvgImage = If(ceShowStepIcons.Checked, CType(resources.GetObject("itemConfirmation.ContentBlock1.ActiveStateImageOptions.SvgImage"), SvgImage), Nothing)
            itemConfirmation.ContentBlock1.InactiveStateImageOptions.SvgImage = If(ceShowStepIcons.Checked, CType(resources.GetObject("itemConfirmation.ContentBlock1.InactiveStateImageOptions.SvgImage"), SvgImage), Nothing)
            itemPersonalInfo.ContentBlock1.ActiveStateImageOptions.SvgImage = If(ceShowStepIcons.Checked, CType(resources.GetObject("itemPersonalInfo.ContentBlock1.ActiveStateImageOptions.SvgImage"), SvgImage), Nothing)
            itemPersonalInfo.ContentBlock1.InactiveStateImageOptions.SvgImage = If(ceShowStepIcons.Checked, CType(resources.GetObject("itemPersonalInfo.ContentBlock1.InactiveStateImageOptions.SvgImage"), SvgImage), Nothing)
        End Sub

        '</ceShowStepIcons>
        '<ceShowIndicatorIcons>
        Private Sub ceShowIndicatorIcons_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            stepProgressBarSample.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = If(ceShowIndicatorIcons.Checked, CType(resources.GetObject("stepProgressBarSample.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage"), SvgImage), Nothing)
        End Sub

        '</ceShowIndicatorIcons>
        '<ceAllowAnimation>
        Private Sub ceAllowAnimation_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            timer.Enabled = ceAllowAnimation.Checked
            tbcSelectStep.Enabled = Not ceAllowAnimation.Checked
            tbcSelectStep.Value = stepProgressBarSample.SelectedItemIndex
        End Sub

        '</ceAllowAnimation>
        '<ceDrawShadows>
        Private Sub ceDrawShadows_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            '<skip>
            If inInitialization Then Return
            '</skip>
            stepProgressBarSample.ShadowDrawMode = If(ceDrawShadows.Checked, StepProgressBarShadowDrawMode.ActiveElements, StepProgressBarShadowDrawMode.None)
        End Sub

        '</ceDrawShadows>
        '<ceAllowUserInteraction>
        Private Sub ceAllowUserInteraction_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            '<skip>
            If inInitialization Then Return
            '</skip>
            stepProgressBarSample.AllowUserInteraction = If(ceAllowUserInteraction.Checked, Utils.DefaultBoolean.True, Utils.DefaultBoolean.False)
        End Sub

        '</ceAllowUserInteraction>
        Private Sub stepProgressBarSample_ItemClick(ByVal sender As Object, ByVal e As StepProgressBarItemClickEventArgs)
            tbcSelectStep.Value = stepProgressBarSample.Items.IndexOf(e.Item)
        End Sub
    End Class
End Namespace
