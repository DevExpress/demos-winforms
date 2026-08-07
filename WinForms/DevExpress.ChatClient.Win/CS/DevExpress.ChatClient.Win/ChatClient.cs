namespace DevExpress.ChatClient {
    using System;
    using System.Drawing;
    using DevExpress.ChatClient.ViewModels;
    using DevExpress.ChatClient.Views;
    using DevExpress.DXperience.Demos;
    using DevExpress.Utils.MVVM.Services;
    using DevExpress.XtraBars.Docking2010.Customization;
    using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
    using DevExpress.XtraBars.ToolbarForm;

    public partial class Messenger : ToolbarForm {
        public Messenger() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode) {
                darkThemeBBI.ImageOptions.SvgImage = ChatClient.SvgImages["DarkTheme"];
                Styles.ContactInfo.Apply(contactInfoPopup);
                Styles.UserInfo.Apply(userInfoPopup);
                InitializeNavigation();
                InitializeBindings();
            }
        }
        void InitializeNavigation() {
            
            var flyoutService = WindowedDocumentManagerService.CreateFlyoutFormService();
            flyoutService.FormStyle = (form) => {
                var flyout = form as FlyoutDialog;
                flyout.CornerRadius = new DevExpress.Utils.Drawing.CornerRadius(8);
                flyout.Properties.Style = FlyoutStyle.Popup;
                flyout.Properties.Appearance.BorderColor = Color.FromArgb(0x66, Color.Black);
            };
            mvvmContext.RegisterDefaultService("Flyout", flyoutService);
            
            var userInfoDialog = userInfoPopup.CreateWindowService();
            userInfoDialog.ShowMode = WindowService.WindowShowMode.Modal;
            userInfoDialog.WindowStyle = (window) => {
                var popup = window as IPopupWindow;
                popup.PopupSize = new Size(516, 306);
                popup.DestroyOnHide = false;
            };
            mvvmContext.RegisterDefaultService("UserInfoDialog", userInfoDialog);
            
            var contactInfoFlyout = contactInfoPopup.CreateWindowService();
            contactInfoFlyout.WindowStyle = (window) => {
                var popup = window as IPopupWindow;
                popup.PopupSize = new Size(368, 374);
            };
            mvvmContext.RegisterDefaultService("ContactInfoFlyout", contactInfoFlyout);
        }
        void InitializeBindings() {
            var fluent = mvvmContext.OfType<MessengerViewModel>();
            
            fluent.WithEvent(this, nameof(Load))
                .EventToCommand(x => x.OnLoad);
            fluent.WithEvent(this, nameof(FormClosed))
                .EventToCommand(x => x.OnClosed);
            
            fluent.SetBinding(this, x => x.Text, x => x.Title);
        }
        bool isDarkTheme;
        void OnDarkThemeClick(object sender, XtraBars.ItemClickEventArgs e) {
            isDarkTheme = !isDarkTheme;
            var palette = (isDarkTheme) ?
                DevExpress.LookAndFeel.SkinSvgPalette.Bezier.ArtHouse :
                DevExpress.LookAndFeel.SkinSvgPalette.Bezier.Default;
            XtraEditors.WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Bezier, palette);
        }
        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            var fluent = mvvmContext.OfType<MessengerViewModel>();
            
            var viewModel = fluent.ViewModel;
            DevExpress.Utils.MVVM.MVVMContext.SetParentViewModel(contactsView, viewModel);
            DevExpress.Utils.MVVM.MVVMContext.SetParentViewModel(messagesView, viewModel);
        }
        void userInfoPopup_ViewModelSet(object sender, DevExpress.Utils.MVVM.ViewModelSetEventArgs e) {
            var fluent = userInfoPopup.OfType<UserViewModel>();
            fluent.BindCommand("lnkLogOff", x => x.LogOff);
            fluent.BindCommand("btnClose", x => x.Close);
        }
        void contactInfoPopup_ViewModelSet(object sender, DevExpress.Utils.MVVM.ViewModelSetEventArgs e) {
            var fluent = contactInfoPopup.OfType<ContactViewModel>();
            fluent.BindCommand("lnkEmail", x => x.MailTo);
            fluent.BindCommand("btnPhoneCall", x => x.PhoneCall);
            fluent.BindCommand("btnVideoCall", x => x.VideoCall);
            fluent.BindCommand("btnMessage", x => x.TextMessage);
        }
        protected override void OnShown(EventArgs e) {
            base.OnShown(e);
            if(MainFormHelper.TakeScreens)
                MainFormHelper.TakeAllScreens(TakeModule, this,
                    new System.Windows.Forms.Control[] { messagesView, contactsView }, TakeModuleInterval, demoName: typeof(Messenger).Assembly.GetName().Name);
        }
        readonly string[] takeModuleNames = new string[] { nameof(MessagesView), nameof(ContactsView) };
        string TakeModule(int num) {
            messagesView.Focus();
            return takeModuleNames[num];
        }
        int TakeModuleInterval(int num) => 1500;
        sealed class Styles {
            public static Style ContactInfo = new ContactInfoStyle();
            public static Style UserInfo = new UserInfoStyle();
            
            sealed class ContactInfoStyle : Style { }
            sealed class UserInfoStyle : Style { }
        }
    }
}
