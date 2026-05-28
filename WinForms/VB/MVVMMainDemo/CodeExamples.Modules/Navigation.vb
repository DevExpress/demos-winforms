Imports DevExpress.DXperience.Demos.CodeDemo

Namespace DevExpress.MVVM.Demos.CodeExamples
    Public Class NavigationModule
        Inherits CodeTutorialControl
        Protected Overrides Function PreprocessCodeBeforeCompilation(code As String, language As ExampleLanguage) As String
            If language = ExampleLanguage.VB Then
                code = code.Replace("GetType(MainViewModel)", "GetType(DXSample.SampleClass.MainViewModel)")
                code = code.Replace("GetType(AcceptFormViewModel)", "GetType(DXSample.SampleClass.AcceptFormViewModel)")
                code = PatchBindCommandActionVB(code, "showBtn", "ShowAcceptDialog", "MainViewModel")
                code = PatchBindCommandActionVB(code, "acceptBtn", "Accept", "AcceptFormViewModel")
                code = PatchBindCommandActionVB(code, "showBtn", "ShowContact", "ContactsViewModel")
                code = PatchEventToCommandActionVB(code, "ShowModuleA", "NavigationViewModel")
                code = PatchEventToCommandActionVB(code, "ShowSomeModulesInDeferredManner", "NavigationViewModel")
                code = PatchEventToCommandActionVB(code, "OnLoad", "RootViewModel")
                If code.IndexOf("ContactsViewModel") > 0 Then
                    code = PatchSetBindingVB(code, "showBtn", "Function(btn) btn.Text", "SimpleButton, String", "Function(x) x.ShowContactTitle", "ContactsViewModel, String")
                End If
            End If
            Return code
        End Function
        Protected Overrides Function PreprocessCodeBeforeOpen(code As String, language As ExampleLanguage) As String
            If language = ExampleLanguage.VB Then
                code = code.Replace("mainView.Parent = sampleHost", "mainView.Parent = Me")
            End If
            Return code
        End Function
    End Class
End Namespace
