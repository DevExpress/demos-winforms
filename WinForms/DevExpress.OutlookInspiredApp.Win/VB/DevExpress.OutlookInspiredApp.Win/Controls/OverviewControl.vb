Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors

Namespace DevExpress.DevAV.Modules

    Public Partial Class OverviewControl
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            descriptionLabel.AutoSizeInLayoutControl = False
            descriptionLabel.Text = "<image=#UISuperHero><br>" & String.Format("<color=#{0:x6}><size=+24>Become a UI Superhero<br>", TextColor.ToArgb()) & String.Format("<color=#{0:x6}><size=-18>And deliver compelling user-experiences on the WinForms platform<br>", DisabledTextColor.ToArgb()) & "with award-winning DevExpress Controls and Libraries."
            AddHandler descriptionLabel.HyperlinkClick, AddressOf descriptionLabel_HyperlinkClick
        End Sub

        Private Sub descriptionLabel_HyperlinkClick(ByVal sender As Object, ByVal e As Utils.HyperlinkClickEventArgs)
            viewModel.SelectedModuleType = ModuleType.Employees
            Dim form = FindForm()
            If form IsNot Nothing Then form.Close()
        End Sub

        Private viewModel As MainViewModel

        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            If viewModel Is Nothing AndAlso AppHelper.MainForm IsNot Nothing Then
                viewModel = TryCast(TryCast(AppHelper.MainForm, ISupportViewModel).ViewModel, MainViewModel)
                If viewModel IsNot Nothing Then BindCommands()
            End If
        End Sub

        Private Sub BindCommands()
            CType(buttonsPanel.Buttons(0), WindowsUIButton).BindCommand(Sub() viewModel.GetStarted(), viewModel)
            CType(buttonsPanel.Buttons(1), WindowsUIButton).BindCommand(Sub() viewModel.GetSupport(), viewModel)
            CType(buttonsPanel.Buttons(2), WindowsUIButton).BindCommand(Sub() viewModel.BuyNow(), viewModel)
        End Sub

        Friend Sub SetDescription(ByVal description As String)
            descriptionLabel.Appearance.Image = Nothing
            descriptionLabel.Text = "<image=#UISuperHero><br>" & String.Format("<color=#{0:x6}><size=+24>Become a UI Superhero<br>", TextColor.ToArgb()) & String.Format("<color=#{0:x6}><size=-18>{1}", DisabledTextColor.ToArgb(), description)
        End Sub
    End Class
End Namespace
