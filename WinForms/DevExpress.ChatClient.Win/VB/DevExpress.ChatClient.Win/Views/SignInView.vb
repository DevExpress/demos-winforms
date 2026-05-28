Imports DevExpress.Utils.MVVM.UI
Imports DevExpress.XtraEditors
Imports DevExpress.ChatClient.ViewModels

Namespace DevExpress.ChatClient.Views

    <ViewType(GetType(SignInViewModel))>
    Public Partial Class SignInView
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            If Not mvvmContext.IsDesignMode Then
                InitializeStyles()
                InitializeBindings()
            End If
        End Sub

        Private Sub InitializeStyles()
            Styles.SignIn.Apply(signInView)
        End Sub

        Private Sub InitializeBindings()
            Dim fluent = mvvmContext.OfType(Of SignInViewModel)()
            fluent.SetObjectDataSourceBinding(signInBindingSource)
            fluent.BindCommandToElement(signInView, "btnFacebook", Function(x) AddressOf x.SignInViaSocialNetwork)
            fluent.BindCommandToElement(signInView, "btnGoogle", Function(x) AddressOf x.SignInViaSocialNetwork)
            fluent.BindCommandToElement(signInView, "btnLinkedIn", Function(x) AddressOf x.SignInViaSocialNetwork)
            fluent.BindCommandToElement(signInView, "btnSignIn", Function(x) AddressOf x.SignIn)
        End Sub

        Private NotInheritable Class Styles

            Public Shared SignIn As Style = New SignInStyle()

            Private NotInheritable Class SignInStyle
                Inherits Style

            End Class
        End Class
    End Class
End Namespace
