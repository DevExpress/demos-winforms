Imports System
Imports System.ClientModel.Primitives
Imports System.ComponentModel.Design
Imports System.Linq
Imports System.Net.Http
Imports System.Threading
Imports System.Windows.Forms
Imports Azure.AI.OpenAI
Imports DevExpress.AIIntegration
Imports DevExpress.Data.Utils
Imports DevExpress.Internal
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports Microsoft.Extensions.AI

Namespace DevExpress.AI.ReportDesigner.Demo

    Friend Module Program

        Sub New()
            ' Third-party assemblies (.dll) required to run the demo are embedded inside the executable.
            ' This code loads these DLLs into the current AppDomain
            AddHandler AppDomain.CurrentDomain.AssemblyResolve, Function(s, e) OnAssemblyResolve(e)
        End Sub

        Private Function OnAssemblyResolve(ByVal e As ResolveEventArgs) As System.Reflection.Assembly
            Return DXperience.Demos.DemoHelper.DemoAssemblyResolve(e, GetType(Program).Assembly)
        End Function

        <STAThread>
        Sub Main()
            Dim enablePMv2 As Boolean = False
#If DEBUG
            enablePMv2 = True
#End If
            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 AndAlso enablePMv2 Then
                WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                WindowsFormsSettings.SetDPIAware()
            End If

            WindowsFormsSettings.TrackWindowsAppMode = DefaultBoolean.True
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXI)
            Dim path As String = DevAVDataDirectoryHelper.GetFile("NWind.db")
            Dim directory As String = IO.Path.GetDirectoryName(path)
            SetDataDirectory(directory)
            XtraReports.Configuration.Settings.Default.UserDesignerOptions.ConvertBindingsToExpressions = XtraReports.UI.PromptBoolean.False
            Dim azureOpenAIClient As AzureOpenAIClient = New AzureOpenAIClient(AzureOpenAIEndpointUri, AzureOpenAIKeyCredentials, New AzureOpenAIClientOptions() With {.Transport = New PromoteHttpStatusErrorsPipelineTransport()})
            Dim chatClient As IChatClient = azureOpenAIClient.GetChatClient("demo").AsIChatClient()
            '
            Dim container = AIExtensionsContainerDesktop.Default
            container.RegisterChatClient(chatClient)
            container.RegisterAIExceptionHandler(New Helpers.AIExceptionHandler())
            'var builder = Kernel.CreateBuilder();
            'builder.AddAzureOpenAIChatCompletion("demo",
            '    AzureOpenAIEndpoint,
            '    AzureOpenAIKey);
            '((IAIServiceContainer)container).RegisterService<Kernel>(builder.Build());
            Call Application.Run(New ReportDesignerForm())
        End Sub

        '
        Private ReadOnly Property AzureOpenAIEndpoint As String
            Get
                Dim lAzureOpenAIEndpoint As String = GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT", IsDeveloperMode)
                If String.IsNullOrEmpty(lAzureOpenAIEndpoint) Then lAzureOpenAIEndpoint = "https://public-api.devexpress.com/demo-openai" 'DevExpress proxy-server
                Return lAzureOpenAIEndpoint
            End Get
        End Property

        Private ReadOnly Property AzureOpenAIEndpointUri As Uri
            Get
                Return New Uri(AzureOpenAIEndpoint)
            End Get
        End Property

        Private ReadOnly Property AzureOpenAIKey As String
            Get
                Dim lAzureOpenAIKey As String = GetEnvironmentVariable("AZURE_OPENAI_API_KEY", IsDeveloperMode)
                If String.IsNullOrEmpty(lAzureOpenAIKey) Then lAzureOpenAIKey = "DEMO" 'Demo key
                Return lAzureOpenAIKey
            End Get
        End Property

        Private ReadOnly Property AzureOpenAIKeyCredentials As ClientModel.ApiKeyCredential
            Get
                Return New ClientModel.ApiKeyCredential(AzureOpenAIKey)
            End Get
        End Property

        Private ReadOnly Property IsDeveloperMode As Boolean
            Get
                Return String.Equals(AssemblyInfo.Version, $"{AssemblyInfo.VersionShort}.0.0", StringComparison.InvariantCultureIgnoreCase)
            End Get
        End Property

        Private Function GetEnvironmentVariable(ByVal variableName As String, ByVal Optional allowSetNewEnvironmentVariable As Boolean = False) As String
            Dim environmentVariable As String = SafeEnvironment.GetEnvironmentVariable(variableName, EnvironmentVariableTarget.User)
            If String.IsNullOrEmpty(environmentVariable) AndAlso allowSetNewEnvironmentVariable Then
                environmentVariable = XtraInputBox.Show($"Please enter {variableName} variable.", variableName, String.Empty)
                If String.IsNullOrEmpty(environmentVariable) Then Call Application.Exit()
                SafeEnvironment.SetEnvironmentVariable(variableName, environmentVariable, EnvironmentVariableTarget.User)
            End If

            Return environmentVariable
        End Function

#Region "inner classes"
        Private Class PromoteHttpStatusErrorsPipelineTransport
            Inherits HttpClientPipelineTransport

            Protected Overrides Function CreateMessageCore() As PipelineMessage
                Dim message = MyBase.CreateMessageCore()
                Return New DemoPipelineMessage(message.Request)
            End Function

            Protected Overrides Sub OnReceivedResponse(ByVal message As PipelineMessage, ByVal httpResponse As HttpResponseMessage)
                If Not httpResponse.IsSuccessStatusCode Then
                    If CInt(httpResponse.StatusCode) = 429 Then
                        Dim seconds As String = httpResponse.Headers.GetValues("Retry-After").FirstOrDefault()
                        Dim text As String = $"You have reached the demo request limit. Your request will be retried automatically in {seconds} seconds. Thank you for your patience and understanding."
                        Form.ActiveForm?.Invoke(New Action(Sub()
                            Dim result = XtraMessageBox.Show(Form.ActiveForm, text, "AI Service Request Limit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                            If result = DialogResult.Cancel Then TryCast(message, DemoPipelineMessage)?.Cancel()
                        End Sub))
                    Else
                        Throw New HttpRequestException("HTTP request failed with status code: " & httpResponse.StatusCode)
                    End If
                End If

                MyBase.OnReceivedResponse(message, httpResponse)
            End Sub

            Private Class DemoPipelineMessage
                Inherits PipelineMessage

                Private ReadOnly cts As CancellationTokenSource = New CancellationTokenSource()

                Public Sub New(ByVal request As PipelineRequest)
                    MyBase.New(request)
                    CancellationToken = cts.Token
                End Sub

                Public Sub Cancel()
                    cts.Cancel()
                End Sub
            End Class
        End Class
#End Region
    End Module
End Namespace
