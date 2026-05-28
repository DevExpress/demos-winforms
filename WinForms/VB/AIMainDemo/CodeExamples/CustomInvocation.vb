Imports System
Imports System.Threading
Imports System.Windows.Forms
Imports Azure.AI.OpenAI
Imports DevExpress.AIIntegration
Imports DevExpress.AIIntegration.Extensions
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Utils
Imports Microsoft.Extensions.AI

Namespace DevExpress.AI.Demos

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Custom Invocations", "CustomInvocation.cs")>
    Public Module CustomInvocation

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim layoutControl As DevExpress.XtraLayout.LayoutControl = New DevExpress.XtraLayout.LayoutControl()
            layoutControl.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            Dim tableGroup = layoutControl.Root.AddGroup("")
            tableGroup.OptionsTableLayoutItem.ColumnSpan = 3
            tableGroup.OptionsTableLayoutItem.RowSpan = 3
            Dim button = New DevExpress.XtraEditors.SimpleButton() With {.Text = "Click me"}
            Dim item1 As DevExpress.XtraLayout.LayoutControlItem = tableGroup.AddItem("Button", button)
            item1.OptionsTableLayoutItem.RowIndex = 2
            item1.OptionsTableLayoutItem.ColumnIndex = 2
            layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            layoutControl.Parent = sampleHost
            Return New Object() {layoutControl, button}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next

            sampleHost.Controls.Clear()
        End Sub

        '
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Invoke extension")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("ChangeStyleExtension", "ChangeStyleRequest", "WritingStyle")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ChangeStyleAsync")>
        Public Sub Invoke(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl, ByVal button As DevExpress.XtraEditors.SimpleButton)
            ' setup container
            Dim defaultAIContainer As DevExpress.AIIntegration.AIExtensionsContainerDefault = New DevExpress.AIIntegration.AIExtensionsContainerDefault()
            Dim AzureOpenAIEndpoint As String = "https://public-api.devexpress.com/demo-openai"
            Dim AzureOpenAIKey As String = "DEMO"
            Dim DeploymentName As String = "gpt-4o-mini"
            Dim azureOpenAIClient As Microsoft.Extensions.AI.IChatClient = New Azure.AI.OpenAI.AzureOpenAIClient(CType((New System.Uri(CStr((AzureOpenAIEndpoint)))), System.Uri), CType((New System.ClientModel.ApiKeyCredential(CStr((AzureOpenAIKey)))), System.ClientModel.ApiKeyCredential)).GetChatClient(CStr((DeploymentName))).AsIChatClient()
            defaultAIContainer.RegisterChatClient(azureOpenAIClient)
            ' register extensions
            defaultAIContainer.Register(Of DevExpress.AIIntegration.Extensions.ChangeStyleExtension)(GetType(DevExpress.AIIntegration.Extensions.ChangeStyleRequest))
            AddHandler button.Click, Async Sub(s, e)
                ' have fun
                Dim request = New DevExpress.AIIntegration.Extensions.ChangeStyleRequest("Have fun experimenting with this code", DevExpress.AIIntegration.Extensions.WritingStyle.Academic)
                Dim response = Await defaultAIContainer.ChangeStyleAsync(request, System.Threading.CancellationToken.None)
                Await DevExpress.XtraEditors.XtraMessageBox.ShowAsync(response.Response)
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Custom processing")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("TranslateExtension", "TranslateRequest", "ResponseStatus")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("TranslateAsync", "ContinueAsync")>
        Public Sub InvokeWithProcessing(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl, ByVal button As DevExpress.XtraEditors.SimpleButton)
            ' setup container
            Dim defaultAIContainer As DevExpress.AIIntegration.AIExtensionsContainerDefault = New DevExpress.AIIntegration.AIExtensionsContainerDefault()
            Dim AzureOpenAIEndpoint As String = "https://public-api.devexpress.com/demo-openai"
            Dim AzureOpenAIKey As String = "DEMO"
            Dim DeploymentName As String = "gpt-4o-mini"
            Dim azureOpenAIClient As Microsoft.Extensions.AI.IChatClient = New Azure.AI.OpenAI.AzureOpenAIClient(CType((New System.Uri(CStr((AzureOpenAIEndpoint)))), System.Uri), CType((New System.ClientModel.ApiKeyCredential(CStr((AzureOpenAIKey)))), System.ClientModel.ApiKeyCredential)).GetChatClient(CStr((DeploymentName))).AsIChatClient()
            defaultAIContainer.RegisterChatClient(azureOpenAIClient)
            ' register extensions
            defaultAIContainer.Register(Of DevExpress.AIIntegration.Extensions.TranslateExtension)(GetType(DevExpress.AIIntegration.Extensions.TranslateRequest))
            AddHandler button.Click, Async Sub(s, e)
                ' have fun
                Dim request = New DevExpress.AIIntegration.Extensions.TranslateRequest("Have fun experimenting with this code", "Elvish")
                Dim response = Await defaultAIContainer.TranslateAsync(request, System.Threading.CancellationToken.None)
                Dim translatedText As String = response.Response
                ' OK
                If response.IsCompleted Then
                ElseIf Not response.IsRestrictedOrFailed Then
                    While response.IsContinuationRequired
                        Await response.ContinueAsync()
                        translatedText += response.Response
                    End While ' Something unexpected happens
                Else
                    Select Case response.Status
                        Case DevExpress.AIIntegration.Extensions.ResponseStatus.MaxTokenLimitExceeded, DevExpress.AIIntegration.Extensions.ResponseStatus.InputSizeLimitExceeded
                            translatedText = "The text you're trying to send within a request is too long and exceeds the limit."
                        Case DevExpress.AIIntegration.Extensions.ResponseStatus.ContentFiltered
                            translatedText = "Potentially harmful content was detected in your request."
                        Case DevExpress.AIIntegration.Extensions.ResponseStatus.[Error]
                            translatedText = "An error occurred while processing the request."
                    End Select
                End If

                Await DevExpress.XtraEditors.XtraMessageBox.ShowAsync(translatedText)
            End Sub
        End Sub
    End Module
End Namespace
