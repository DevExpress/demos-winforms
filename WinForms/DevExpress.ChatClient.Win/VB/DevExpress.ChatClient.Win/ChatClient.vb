Imports System
Imports System.Drawing
Imports DevExpress.ChatClient.ViewModels
Imports DevExpress.ChatClient.Views
Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraBars.ToolbarForm

Namespace DevExpress.ChatClient

    Public Partial Class Messenger
        Inherits ToolbarForm

        Public Sub New()
            InitializeComponent()
            If Not mvvmContext.IsDesignMode Then
                darkThemeBBI.ImageOptions.SvgImage = SvgImages("DarkTheme")
                Styles.ContactInfo.Apply(contactInfoPopup)
                Styles.UserInfo.Apply(userInfoPopup)
                InitializeNavigation()
                InitializeBindings()
            End If
        End Sub

        Private Sub InitializeNavigation()
            Dim flyoutService = WindowedDocumentManagerService.CreateFlyoutFormService()
            flyoutService.FormStyle = Sub(form)
                Dim flyout = TryCast(form, FlyoutDialog)
                flyout.CornerRadius = New Utils.Drawing.CornerRadius(8)
                flyout.Properties.Style = FlyoutStyle.Popup
                flyout.Properties.Appearance.BorderColor = Color.FromArgb(&H66, Color.Black)
            End Sub
            mvvmContext.RegisterDefaultService("Flyout", flyoutService)
            Dim userInfoDialog = userInfoPopup.CreateWindowService()
            userInfoDialog.ShowMode = WindowService.WindowShowMode.Modal
            userInfoDialog.WindowStyle = Sub(window)
                Dim popup = TryCast(window, IPopupWindow)
                popup.PopupSize = New Size(516, 306)
                popup.DestroyOnHide = False
            End Sub
            mvvmContext.RegisterDefaultService("UserInfoDialog", userInfoDialog)
            Dim contactInfoFlyout = contactInfoPopup.CreateWindowService()
            contactInfoFlyout.WindowStyle = Sub(window)
                Dim popup = TryCast(window, IPopupWindow)
                popup.PopupSize = New Size(368, 374)
            End Sub
            mvvmContext.RegisterDefaultService("ContactInfoFlyout", contactInfoFlyout)
        End Sub

        Private Sub InitializeBindings()
            Dim fluent = mvvmContext.OfType(Of MessengerViewModel)()
            fluent.WithEvent(Me, "Load").EventToCommand(Sub(x) x.OnLoad())
            fluent.WithEvent(Me, "FormClosed").EventToCommand(Sub(x) x.OnClosed())
            fluent.SetBinding(Me, Function(x) x.Text, Function(x) x.Title)
        End Sub

        Private isDarkTheme As Boolean

        Private Sub OnDarkThemeClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            isDarkTheme = Not isDarkTheme
            Dim palette = If(isDarkTheme, DevExpress.LookAndFeel.SkinSvgPalette.Bezier.ArtHouse, DevExpress.LookAndFeel.SkinSvgPalette.Bezier.Default)
            XtraEditors.WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Bezier, palette)
        End Sub

        Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
            MyBase.OnHandleCreated(e)
            Dim fluent = mvvmContext.OfType(Of MessengerViewModel)()
            Dim viewModel = fluent.ViewModel
            Utils.MVVM.MVVMContext.SetParentViewModel(contactsView, viewModel)
            Utils.MVVM.MVVMContext.SetParentViewModel(messagesView, viewModel)
        End Sub

        Private Sub userInfoPopup_ViewModelSet(ByVal sender As Object, ByVal e As Utils.MVVM.ViewModelSetEventArgs)
            Dim fluent = userInfoPopup.OfType(Of UserViewModel)()
            fluent.BindCommand("lnkLogOff", Sub(x) x.LogOff())
            fluent.BindCommand("btnClose", Sub(x) x.Close())
        End Sub

        Private Sub contactInfoPopup_ViewModelSet(ByVal sender As Object, ByVal e As Utils.MVVM.ViewModelSetEventArgs)
            Dim fluent = contactInfoPopup.OfType(Of ContactViewModel)()
            fluent.BindCommand("lnkEmail", Sub(x) x.MailTo())
            fluent.BindCommand("btnPhoneCall", Sub(x) x.PhoneCall())
            fluent.BindCommand("btnVideoCall", Sub(x) x.VideoCall())
            fluent.BindCommand("btnMessage", Sub(x) x.TextMessage())
        End Sub

        Private NotInheritable Class Styles

            Public Shared ContactInfo As Style = New ContactInfoStyle()

            Public Shared UserInfo As Style = New UserInfoStyle()

            Private NotInheritable Class ContactInfoStyle
                Inherits Style

            End Class

            Private NotInheritable Class UserInfoStyle
                Inherits Style

            End Class
        End Class
    End Class
End Namespace
