Imports DevExpress.LookAndFeel

Namespace DevExpress.AI.Demos

    Public Partial Class MemoEditAIModule
        Inherits AITutorialControl

        Public Sub New()
            InitializeComponent()
            UpdatePicture()
            UpdatePaddings()
            layoutControlGroup3.Padding = New XtraLayout.Utils.Padding(0, layoutControlGroup3.Padding.Right, 0, layoutControlGroup3.Padding.Bottom)
        End Sub

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            UpdatePicture()
        End Sub

        Protected Overrides Sub UpdatePaddings()
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset)
        End Sub

        Private Sub UpdatePicture()
            pictureEdit2.BackColor = layoutControl2.BackColor
            If Utils.Frames.FrameHelper.IsDarkSkin(UserLookAndFeel.Default) Then
                pictureEdit2.EditValue = Properties.Resources.ai_assistant_menu_dark
            Else
                pictureEdit2.EditValue = Properties.Resources.ai_assistant_menu
            End If
        End Sub
    End Class
End Namespace
