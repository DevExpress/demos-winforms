Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class OverviewControl
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            descriptionLabel.AutoSizeInLayoutControl = False
            descriptionLabel.Text = "<image=#UISuperHero><br>" & String.Format("<color=#{0:x6}><size=+24>Become a UI Superhero<br>", ColorHelper.TextColor.ToArgb()) & String.Format("<color=#{0:x6}><size=-18>And deliver compelling user-experiences on the WinForms platform<br>", ColorHelper.DisabledTextColor.ToArgb()) & "with award-winning DevExpress Controls and Libraries."
            AddHandler descriptionLabel.HyperlinkClick, AddressOf descriptionLabel_HyperlinkClick
            AddHandler CType(buttonsPanel.Buttons(0), WindowsUIButton).Click, AddressOf OnOverviewControlGetStartedClick
            AddHandler CType(buttonsPanel.Buttons(1), WindowsUIButton).Click, AddressOf OnOverviewControlGetSupportClick
            AddHandler CType(buttonsPanel.Buttons(2), WindowsUIButton).Click, AddressOf OnOverviewControlByNowClick
        End Sub

        Private Sub OnOverviewControlGetStartedClick(ByVal sender As Object, ByVal e As System.EventArgs)
            Call OutlookFormHelper.DoGettingStarted(TryCast(ModulesInfo.CurrentModule, TutorialControl))
        End Sub

        Private Sub OnOverviewControlGetSupportClick(ByVal sender As Object, ByVal e As System.EventArgs)
            Call OutlookFormHelper.DoGetFreeSupport(TryCast(ModulesInfo.CurrentModule, TutorialControl))
        End Sub

        Private Sub OnOverviewControlByNowClick(ByVal sender As Object, ByVal e As System.EventArgs)
            Call OutlookFormHelper.DoByNow(TryCast(ModulesInfo.CurrentModule, TutorialControl))
        End Sub

        Private Sub descriptionLabel_HyperlinkClick(ByVal sender As Object, ByVal e As HyperlinkClickEventArgs)
            Dim form = FindForm()
            If form IsNot Nothing Then form.Close()
        End Sub

        Friend Sub SetDescription(ByVal description As String)
            descriptionLabel.Appearance.Image = Nothing
            descriptionLabel.Text = "<image=#UISuperHero><br>" & String.Format("<color=#{0:x6}><size=+24>Become a UI Superhero<br>", ColorHelper.TextColor.ToArgb()) & String.Format("<color=#{0:x6}><size=-18>{1}", ColorHelper.DisabledTextColor.ToArgb(), description)
        End Sub
    End Class
End Namespace
