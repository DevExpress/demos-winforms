Imports System
Imports System.ComponentModel
Imports System.Drawing
' <comboBoxProgressStyle> <checkEditVertical>
Imports DevExpress.XtraEditors.Controls
Imports System.Windows.Forms
Imports System.Threading
Imports DevExpress.Utils.Drawing
Imports DevExpress.Tutorials
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraLayout
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars.Navigation

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleProgressBar
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            If tabPane1 IsNot Nothing Then
                AddHandler tabPane1.SelectedPageChanged, AddressOf OnSelectedPageChanged
                AddHandler tabPane1.VisibleChanged, AddressOf OnTabControlVisibleChanged
            End If

            UpdateVisualSettings()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleProgressBar"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "progressBar"
            End Get
        End Property

        Private Sub UpdateVisualSettings()
            comboBoxProgressStyle.Enabled = UserLookAndFeel.Default.ActiveStyle <> ActiveLookAndFeelStyle.Skin
            Dim colorPanelVisibility As Boolean = UserLookAndFeel.Default.ActiveStyle <> ActiveLookAndFeelStyle.Skin
            layoutControlGroup7.Visibility = If(colorPanelVisibility, DevExpress.XtraLayout.Utils.LayoutVisibility.Always, DevExpress.XtraLayout.Utils.LayoutVisibility.Never)
        End Sub

        Protected Overrides Sub OnLookAndFeelChanged(ByVal sender As Object, ByVal e As EventArgs)
            MyBase.OnLookAndFeelChanged(sender, e)
            UpdateVisualSettings()
        End Sub

        Protected Overrides Sub UnsubscribeOnEvents()
            MyBase.UnsubscribeOnEvents()
            If tabPane1 IsNot Nothing Then
                RemoveHandler tabPane1.SelectedPageChanged, AddressOf OnSelectedPageChanged
                RemoveHandler tabPane1.VisibleChanged, AddressOf OnTabControlVisibleChanged
            End If
        End Sub

        Private Sub OnSelectedPageChanged(ByVal sender As Object, ByVal e As SelectedPageChangedEventArgs)
            CalcContentCore()
        End Sub

        Private Sub OnTabControlVisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
            CalcContentCore()
        End Sub

        Protected Overrides Sub CalcContentCore()
            If Not Visible OrElse Not IsHandleCreated Then Return
            CalcLayoutControlBounds(layoutControl1)
            CalcLayoutControlBounds(layoutControl2)
        End Sub

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
            tabControl.LayoutChanged()
        End Sub

        Private increment As Boolean = True

        Private updateValues As Boolean = False

        Private incrementInternal As Boolean = True

        ' <btnApplyColors>
        Private Sub btnApplyColors_Click(ByVal sender As Object, ByVal e As EventArgs)
            progressBarSample.Properties.StartColor = colorEditStartColor.Color
            progressBarSample.Properties.EndColor = colorEditEndColor.Color
        End Sub

        ' </btnApplyColors>
        ' <comboBoxProgressStyle>
        Private Sub comboBoxProgressStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            Dim styles As ProgressViewStyle() = New ProgressViewStyle() {ProgressViewStyle.Solid, ProgressViewStyle.Broken}
            progressBarSample.Properties.ProgressViewStyle = styles(comboBoxProgressStyle.SelectedIndex)
        End Sub

        ' </comboBoxProgressStyle>
        ' <checkEditVertical>
        Private Sub checkEditVertical_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim kind As ProgressKind = ProgressKind.Horizontal
            If checkEditVertical.Checked Then kind = ProgressKind.Vertical
            progressBarSample.Properties.ProgressKind = kind
            UpdateProgressBarBounds(progressBarSample)
        End Sub

        ' </checkEditVertical>
        ' <checkEditVertical>
        Private Sub UpdateProgressBarBounds(ByVal progressBar As ProgressBarControl)
            If progressBar.Properties.ProgressKind = ProgressKind.Horizontal Then
                progressBar.Height = GetProgressBarSize(progressBar)
                ControlUtils.HorzAlignControlInParent(progressBar, 16)
            Else
                progressBar.Width = GetProgressBarSize(progressBar)
                ControlUtils.VertAlignControlInParent(progressBar, 32)
            End If

            ControlUtils.CenterControlInParent(progressBar)
        End Sub

        ' </checkEditVertical>
        Private Function GetProgressBarSize(ByVal progressBar As ProgressBarControl) As Integer
            Return If(progressBar.Properties.ProgressKind = ProgressKind.Vertical AndAlso progressBar.Properties.TextOrientation = TextOrientation.Horizontal, 30, 20)
        End Function

        ' <checkEditShowText>
        Private Sub checkEditShowText_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            progressBarSample.Properties.ShowTitle = checkEditShowText.Checked
            checkEditShowPercent.Enabled = checkEditShowText.Checked
        End Sub

        ' </checkEditShowText>
        ' <checkEditShowPercent>
        Private Sub checkEditShowPercent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            progressBarSample.Properties.PercentView = checkEditShowPercent.Checked
        End Sub

        ' </checkEditShowPercent>
        ' <colorEditTextColor>
        Private Sub colorEditTextColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            progressBarSample.Properties.Appearance.ForeColor = colorEditTextColor.Color
        End Sub

        ' </colorEditTextColor>
        ' <spinEditStep>
        Private Sub spinEditStep_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            progressBarSample2.Properties.Step = CInt(spinEditStep.Value)
        End Sub

        ' </spinEditStep>
        ' <btnSetMinimum>
        Private Sub btnSetMinimum_Click(ByVal sender As Object, ByVal e As EventArgs)
            progressBarSample2.Position = progressBarSample2.Properties.Minimum
        End Sub

        ' </btnSetMinimum>
        ' <btnSetMaximum>
        Private Sub btnSetMaximum_Click(ByVal sender As Object, ByVal e As EventArgs)
            progressBarSample2.Position = progressBarSample2.Properties.Maximum
        End Sub

        ' </btnSetMaximum>
        ' <textEditCurrentValue>
        Private Sub progressBarSample2_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            textEditCurrentValue.Text = progressBarSample2.Position.ToString()
        End Sub

        ' </textEditCurrentValue>
        ' <buttonsUpDown>
        Private Sub buttonsUpDown_ButtonClick(ByVal sender As Object, ByVal e As XtraEditors.Controls.ButtonPressedEventArgs)
            checkEditAnimation.Checked = False
            checkEditAnimation.Update()
            If Equals(e.Button.Caption, "Up") Then RunVariableIncrement()
            If Equals(e.Button.Caption, "Down") Then RunVariableDecrement()
        End Sub

        ' </buttonsUpDown>
        ' <buttonsUpDown>
        Private Sub RunVariableIncrement()
            progressBarSample2.Position = progressBarSample2.Properties.Minimum
            Dim currentStep As Double =(progressBarSample2.Properties.Maximum - progressBarSample2.Properties.Minimum) \ 4
            While progressBarSample2.Position + currentStep < progressBarSample2.Properties.Maximum
                progressBarSample2.Increment(CInt(Math.Ceiling(currentStep)))
                progressBarSample2.Update()
                textEditCurrentValue.Update()
                Thread.Sleep(100)
                currentStep /= 1.5
            End While
        End Sub

        Private Sub RunVariableDecrement()
            progressBarSample2.Position = progressBarSample2.Properties.Maximum
            Dim currentStep As Double =(progressBarSample2.Properties.Maximum - progressBarSample2.Properties.Minimum) \ 4
            While progressBarSample2.Position - currentStep > progressBarSample2.Properties.Minimum
                progressBarSample2.Decrement(CInt(Math.Ceiling(currentStep)))
                progressBarSample2.Update()
                textEditCurrentValue.Update()
                Thread.Sleep(100)
                currentStep /= 1.5
            End While
        End Sub

        ' </buttonsUpDown>
        ' <comboBoxMaxMin>
        Private Sub comboBoxMaxMin_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim minValues As Integer() = New Integer() {0, 100, -100}
            Dim maxValues As Integer() = New Integer() {100, 200, 100}
            progressBarSample2.Properties.Minimum = minValues(comboBoxMaxMin.SelectedIndex)
            progressBarSample2.Properties.Maximum = maxValues(comboBoxMaxMin.SelectedIndex)
            progressBarSample2.Position = progressBarSample2.Properties.Minimum
        End Sub

        ' </comboBoxMaxMin>
        ' <checkEditAnimation>
        Private Sub checkEditAnimation_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            timer.Enabled = checkEditAnimation.Checked
        End Sub

        Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            progressBarSample2.Position += If(increment, 1, -1)
            If progressBarSample2.Position = progressBarSample2.Properties.Maximum Then increment = False
            If progressBarSample2.Position = progressBarSample2.Properties.Minimum Then increment = True
        End Sub

        ' </checkEditAnimation>
        Private Sub TutorialModuleProgressBar_Load(ByVal sender As Object, ByVal e As EventArgs)
            SetDefaultProgressBarPosition()
            InitValues()
        End Sub

        Private Sub SetDefaultProgressBarPosition()
            UpdateProgressBarBounds(progressBarSample)
            UpdateProgressBarBounds(progressBarSample2)
        End Sub

        Private Sub InitValues()
            updateValues = True
            comboBoxProgressStyle.EditValue = progressBarSample.Properties.ProgressViewStyle.ToString()
            checkEditShowText.Checked = progressBarSample.Properties.ShowTitle
            checkEditShowPercent.Checked = progressBarSample.Properties.PercentView
            updateValues = False
            checkEditShowPercent.Enabled = checkEditShowText.Checked
        End Sub

        Private Sub timerInternal_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If MainFormHelper.TakeScreens Then Return
            progressBarSample.Position += If(incrementInternal, 1, -1)
            If progressBarSample.Position = progressBarSample.Properties.Maximum Then incrementInternal = False
            If progressBarSample.Position = progressBarSample.Properties.Minimum Then incrementInternal = True
        End Sub

        ' <buttonsMaxMin>
        Private Sub buttonsMaxMin_ButtonClick(ByVal sender As Object, ByVal e As XtraEditors.Controls.ButtonPressedEventArgs)
            If Equals(e.Button.Caption, "Max") Then progressBarSample2.Position = progressBarSample2.Properties.Maximum
            If Equals(e.Button.Caption, "Min") Then progressBarSample2.Position = progressBarSample2.Properties.Minimum
        End Sub

        ' </buttonsMaxMin>
        ' <spinEditStep>
        Private Sub spinEditStep_ButtonClick(ByVal sender As Object, ByVal e As XtraEditors.Controls.ButtonPressedEventArgs)
            progressBarSample2.PerformStep()
        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            progressBarSample.Properties.FlowAnimationEnabled = checkEdit1.Checked
            spinDelay.Enabled = checkEdit1.Checked
            spinSpeed.Enabled = checkEdit1.Checked
        End Sub

        Private Sub spinSpeed_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim value = spinSpeed.Value
            If value > 0 AndAlso value < Integer.MaxValue Then progressBarSample.Properties.FlowAnimationDuration = CInt(value)
        End Sub

        Private Sub spinDelay_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim value = spinDelay.Value
            If value > 0 AndAlso value < Integer.MaxValue Then progressBarSample.Properties.FlowAnimationDelay = CInt(value)
        End Sub
    ' </spinEditStep>
    End Class
End Namespace
