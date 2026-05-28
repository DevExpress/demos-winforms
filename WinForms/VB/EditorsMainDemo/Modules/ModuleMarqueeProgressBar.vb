Imports System
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Tutorials
Imports DevExpress.LookAndFeel

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleMarqueeProgressBar
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            AddHandler UserLookAndFeel.Default.StyleChanged, New EventHandler(AddressOf Default_StyleChanged)
            UpdateSkinInfo()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleMarqueeProgressBar"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "marqueeProgressBar"
            End Get
        End Property

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Private Sub UpdateSkinInfo()
            icbProgressViewStyle.Enabled = UserLookAndFeel.Default.ActiveStyle <> ActiveLookAndFeelStyle.Skin
        End Sub

        Private Sub Default_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateSkinInfo()
        End Sub

        Private updateValues As Boolean = False

        Private Sub ModuleMarqueeProgressBar_Load(ByVal sender As Object, ByVal e As EventArgs)
            SetDefaultProgressBarPosition()
            InitComboBoxes()
            InitValues()
        End Sub

        Private Sub SetDefaultProgressBarPosition()
            UpdateProgressBarBounds(marqueeProgressBarControl1)
        End Sub

        Private Sub UpdateProgressBarBounds(ByVal progressBar As MarqueeProgressBarControl)
            If progressBar.Properties.ProgressKind = ProgressKind.Horizontal Then
                progressBar.Height = 20
                ControlUtils.HorzAlignControlInParent(progressBar, 16)
            Else
                progressBar.Width = 20
                ControlUtils.VertAlignControlInParent(progressBar, 32)
            End If

            ControlUtils.CenterControlInParent(progressBar)
        End Sub

        Private Sub InitComboBoxes()
            icbProgressViewStyle.Properties.Items.AddEnum(GetType(ProgressViewStyle))
        End Sub

        Private Sub InitValues()
            updateValues = True
            icbProgressViewStyle.EditValue = marqueeProgressBarControl1.Properties.ProgressViewStyle
            spinEditAnimationSpeed.EditValue = marqueeProgressBarControl1.Properties.MarqueeAnimationSpeed
            checkEditVertical.Checked = marqueeProgressBarControl1.Properties.ProgressKind = ProgressKind.Vertical
            checkEditShowTitle.Checked = marqueeProgressBarControl1.Properties.ShowTitle
            checkEditPause.Checked = marqueeProgressBarControl1.Properties.Paused
            teTitle.Text = marqueeProgressBarControl1.Text
            teTitle.Enabled = checkEditShowTitle.Checked
            updateValues = False
        End Sub

        '<checkEditVertical>
        Private Sub checkEditVertical_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            marqueeProgressBarControl1.Properties.ProgressKind = If(checkEditVertical.Checked, ProgressKind.Vertical, ProgressKind.Horizontal)
            UpdateProgressBarBounds(marqueeProgressBarControl1)
        End Sub

        '</checkEditVertical>
        '<checkEditShowTitle>
        Private Sub checkEditShowTitle_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            marqueeProgressBarControl1.Properties.ShowTitle = checkEditShowTitle.Checked
            teTitle.Enabled = checkEditShowTitle.Checked
        End Sub

        '</checkEditShowTitle>
        '<checkEditPause>
        Private Sub checkEditPause_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            marqueeProgressBarControl1.Properties.Paused = checkEditPause.Checked
        End Sub

        '</checkEditPause>
        '<spinEditAnimationSpeed>
        Private Sub spinEditAnimationSpeed_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            marqueeProgressBarControl1.Properties.MarqueeAnimationSpeed = CInt(spinEditAnimationSpeed.Value)
        End Sub

        '</spinEditAnimationSpeed>
        '<icbProgressViewStyle>
        Private Sub icbProgressViewStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            marqueeProgressBarControl1.Properties.ProgressViewStyle = CType(icbProgressViewStyle.EditValue, ProgressViewStyle)
        End Sub

        '</icbProgressViewStyle>
        '<teTitle>
        Private Sub teTitle_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            marqueeProgressBarControl1.Text = teTitle.Text
        End Sub
    '</teTitle>
    End Class
End Namespace
