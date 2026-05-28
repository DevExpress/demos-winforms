Imports System.Collections.Generic
Imports DevExpress.DXperience.Demos
Imports DevExpress.DXperience.Demos.CodeDemo

Namespace DevExpress.AI.Demos

    Public Partial Class CodeExamples
        Inherits DevExpress.DXperience.Demos.CodeDemo.CodeTutorialControlBase

        Private Shared Sub CodeExample()
            DevExpress.AIIntegration.WinForms.BehaviorInitializer.Initialize() 'Force initialize Behavior in a case of starting code-example without running the demo
        End Sub

        Public Sub New()
            Me.InitializeComponent()
#Region "Load External Assemblies"
            Dim externalAssemblies As String() = New String() {GetType(DevExpress.Mvvm.ViewModelBase).Assembly.FullName, GetType(Microsoft.Extensions.DependencyInjection.ServiceCollection).Assembly.FullName, GetType(Microsoft.Extensions.DependencyInjection.ServiceCollectionContainerBuilderExtensions).Assembly.FullName, GetType(DevExpress.AIIntegration.WinForms.BehaviorInitializer).Assembly.FullName}
            For Each asmName As String In externalAssemblies
                DevExpress.Data.Internal.SafeTypeResolver.GetOrLoadAssembly(asmName)
            Next
#End Region  ' Load External Assemblies
        End Sub

        Protected Overrides ReadOnly Property XtraItemGroupData As String
            Get
                Return $"<PackageReference Include=""DevExpress.AIIntegration.WinForms"" Version=""//Version"" />"
            End Get
        End Property

#Region "HighlightTokens"
        Protected Overrides Function InitializeHighlightTokens() As List(Of String)
            Dim tokens = MyBase.InitializeHighlightTokens()
            tokens.AddRange(DevExpress.AI.Demos.CodeExamples.DefaultTokens)
            Return tokens
        End Function

        Private ReadOnly Shared DefaultTokens As String() = New String() {"IChatClient", "AzureOpenAIClient", "ApiKeyCredential", "IAIExtensionsContainer", "AIExtensionsContainerDefault", "AIExtensionsContainerLocal", "AIExtensionsContainerDesktop", "AIExceptionHandler", "IAIExceptionHandler"}

#End Region  ' HighlightTokens
        Protected Overrides Function InitializeReferences() As List(Of String)
            Dim _references As System.Collections.Generic.List(Of String) = MyBase.InitializeReferences()
            _references.AddRange(New String() {})
            Return _references
        End Function

        Protected Overrides ReadOnly Property CurrentExampleLanguage As ExampleLanguage
            Get
                Return DevExpress.DXperience.Demos.DemoHelper.GetExampleLanguage()
            End Get
        End Property

        Protected Overrides Sub DoHide()
            MyBase.DoHide()
            Me.DestroyCurrentExample()
        End Sub
    End Class
End Namespace
