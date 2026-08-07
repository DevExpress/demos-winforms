namespace DevExpress.ChatClient.Views {
    using DevExpress.ChatClient.ViewModels;
    using DevExpress.Utils.MVVM.UI;
    using DevExpress.XtraEditors;

    [ViewType(typeof(SignInViewModel))]
    public partial class SignInView : XtraUserControl {
        public SignInView() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode) {
                InitializeStyles();
                InitializeBindings();
            }
        }
        void InitializeStyles() {
            Styles.SignIn.Apply(signInView);
        }
        void InitializeBindings() {
            var fluent = mvvmContext.OfType<SignInViewModel>();
            fluent.SetObjectDataSourceBinding(signInBindingSource);
            
            fluent.BindCommandToElement(signInView, "btnFacebook", x => x.SignInViaSocialNetwork);
            fluent.BindCommandToElement(signInView, "btnGoogle", x => x.SignInViaSocialNetwork);
            fluent.BindCommandToElement(signInView, "btnLinkedIn", x => x.SignInViaSocialNetwork);
            fluent.BindCommandToElement(signInView, "btnSignIn", x => x.SignIn);
        }
        sealed class Styles {
            public static Style SignIn = new SignInStyle();
            
            sealed class SignInStyle : Style { }
        }
    }
}
