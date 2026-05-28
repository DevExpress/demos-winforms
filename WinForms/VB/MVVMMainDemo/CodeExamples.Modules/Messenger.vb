Imports DevExpress.DXperience.Demos.CodeDemo

Namespace DevExpress.MVVM.Demos.CodeExamples
    Public Class MessengerModule
        Inherits CodeTutorialControl
        Protected Overrides Function PreprocessCodeBeforeCompilation(code As String, language As ExampleLanguage) As String
            If language = ExampleLanguage.VB Then
                If code.IndexOf("Class MessageAwareView") > 0 Then
                    code = PatchBindCommandActionVB(code, "sendMessageButton", "SendStringMessage", "ViewModel")
                End If
                If code.IndexOf("Class CustomMessageAwareView") > 0 Then
                    code = PatchBindCommandActionVB(code, "sendMessageButton", "SendCustomMessage", "ViewModelWithCustomMessage")
                End If
                If code.IndexOf("Class TokenizedMessagesAwareView") > 0 Then
                    code = PatchBindCommandActionVB(code, "sendMessageButton", "SendTokenizedMessage", "ViewModelWithTokenizedMessages")
                End If
            End If
            Return code
        End Function
    End Class
End Namespace
