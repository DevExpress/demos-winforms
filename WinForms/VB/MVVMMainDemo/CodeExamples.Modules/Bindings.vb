Imports DevExpress.DXperience.Demos.CodeDemo

Namespace DevExpress.MVVM.Demos.CodeExamples
    Public Class BindingsModule
        Inherits CodeTutorialControl
        Protected Overrides Function PreprocessCodeBeforeCompilation(code As String, language As ExampleLanguage) As String
            If language = ExampleLanguage.VB Then
                If code.IndexOf("Class ViewModel") > 0 Then
                    code = PatchSetBindingVB(code, "TextEdit, Object, String", "editor", "Function(e) e.EditValue", "TextEdit, Object", "Function(x) x.Title", "ViewModel, String")
                    code = PatchSetBindingVB(code, "trackBar", "Function(t) t.Value", "TrackBarControl, Integer", "Function(x) x.Progress", "ViewModel, Integer")
                    code = PatchSetBindingVB(code, "TextEdit, String, Object", "editor", "Function(e) e.Text", "TextEdit, String", "Function(x) x.Progress", "ViewModel, Object")
                End If
                If code.IndexOf("Class Entity") > 0 Then
                    code = PatchSetBindingVB(code, "ImageListBoxControl, Object, Entity", "listBox", "Function(lb) lb.SelectedValue", "ImageListBoxControl, Object", "Function(x) x.SelectedEntity", "ViewModel, Entity")
                    code = PatchBindCommandActionVB(code, "addButton", "Add", "ViewModel")
                    code = PatchBindCommandActionVB(code, "removeButton", "Remove", "ViewModel")
                End If
                If code.IndexOf("Class LegacyViewModel") > 0 Then
                    code = PatchSetBindingVB(code, "TextEdit, Object, String", "editor", "Function(e) e.EditValue", "TextEdit, Object", "Function(x) x.Title", "LegacyViewModel, String")
                End If
                If code.IndexOf("Class UIViewModel") > 0 Then
                    code = PatchSetBindingVB(code, "checkEdit", "Function(c) c.Checked", "CheckEdit, Boolean", "Function(x) x.IsActive", "UIViewModel, Boolean")
                End If
                If code.IndexOf("Class NestedViewModel") > 0 Then
                    code = PatchSetBindingVB(code, "editor", "Function(e) e.EditValue", "TextEdit, Object", "Function(x) x.Child.Title", "ViewModel, Object")
                End If
            End If
            Return code
        End Function
    End Class
End Namespace
