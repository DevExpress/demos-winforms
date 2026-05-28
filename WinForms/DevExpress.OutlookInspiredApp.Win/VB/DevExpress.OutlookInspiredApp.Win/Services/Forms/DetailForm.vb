Imports DevExpress.DevAV.Common.Utils
Imports DevExpress.DevAV.Modules
Imports DevExpress.DevAV.ViewModels

Namespace DevExpress.DevAV

    Public Partial Class DetailForm
        Inherits XtraBars.Ribbon.RibbonForm
        Implements IRibbonModule

        Public Sub New()
            InitializeComponent()
            IconOptions.SvgImage = AppIcon
            If mainViewModel Is Nothing Then
                mainViewModel = TryCast(CType(AppHelper.MainForm, ISupportViewModel).ViewModel, MainViewModel)
                If mainViewModel IsNot Nothing Then BindCommands(mainViewModel)
            End If

            SwapFluentIcons(Me)
        End Sub

        Private mainViewModel As MainViewModel

        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            Bounds = Utils.PlacementHelper.Arrange(Size, Owner.Bounds, System.Drawing.ContentAlignment.MiddleCenter)
        End Sub

        Protected Overrides Sub OnShown(ByVal e As System.EventArgs)
            MyBase.OnShown(e)
            If ActiveForm IsNot Me Then Activate()
        End Sub

        Private Sub BindCommands(ByVal viewModel As MainViewModel)
            biGetStarted.BindCommand(Sub() viewModel.GetStarted(), viewModel)
            biGetSupport.BindCommand(Sub() viewModel.GetSupport(), viewModel)
            biBuyNow.BindCommand(Sub() viewModel.BuyNow(), viewModel)
            biAbout.BindCommand(Sub() viewModel.About(), viewModel)
        End Sub

        Protected Overrides Sub OnControlAdded(ByVal e As System.Windows.Forms.ControlEventArgs)
            MyBase.OnControlAdded(e)
            EnsureRibbonModule(e.Control)
        End Sub

        Private Sub EnsureRibbonModule(ByVal view As Object)
            Dim ribbonModule As IRibbonModule = TryCast(view, IRibbonModule)
            If ribbonModule IsNot Nothing Then
                Ribbon.Pages(0).Text = ribbonModule.Ribbon.Pages(0).Text
                Ribbon.MergeRibbon(ribbonModule.Ribbon)
                Ribbon.StatusBar.MergeStatusBar(ribbonModule.Ribbon.StatusBar)
                Text = String.Format("{1} - {0}", ribbonModule.Ribbon.ApplicationDocumentCaption, "DevAV")
            End If
        End Sub

#Region "IRibbonModule"
        Private ReadOnly Property IRibbonModule_Ribbon As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                Return ribbonControl
            End Get
        End Property
#End Region
    End Class
End Namespace
