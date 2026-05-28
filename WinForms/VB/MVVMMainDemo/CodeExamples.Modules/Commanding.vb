Imports DevExpress.DXperience.Demos.CodeDemo

Namespace DevExpress.MVVM.Demos.CodeExamples
    Public Class CommandingModule
        Inherits CodeTutorialControl
        Protected Overrides Function PreprocessCodeBeforeCompilation(code As String, language As ExampleLanguage) As String
            If language = ExampleLanguage.VB Then
                If code.IndexOf("Class ViewModelWithAsyncCommandAndCancellation") > 0 Then
                    code = PatchBindCommandActionVB(code, "commandButton", "DoSomethingAsynchronously", "ViewModelWithAsyncCommandAndCancellation")
                    code = PatchSetBindingVB(code, "progressBar", "Function(p) p.EditValue", "ProgressBarControl, Object", "Function(x) x.Progress", "ViewModelWithAsyncCommandAndCancellation, Object")
                End If
            End If
            Return code
        End Function
    End Class
End Namespace
