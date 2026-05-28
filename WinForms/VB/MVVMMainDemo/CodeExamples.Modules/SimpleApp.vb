Imports DevExpress.DXperience.Demos.CodeDemo

Namespace DevExpress.MVVM.Demos.CodeExamples
    Public Class SimpleAppModule
        Inherits CodeTutorialControl
        Protected Overrides Function PreprocessCodeBeforeCompilation(code As String, language As ExampleLanguage) As String
            If language = ExampleLanguage.VB Then
                If code.IndexOf("AppViewModel") > 0 Then
                    code = PatchSetBindingVB(code, "Me", "Function(view) view.Text", "MainView, String", "Function(x) x.Title", "AppViewModel, String")
                End If
                If code.IndexOf("AppLogoViewModel") > 0 Then
                    code = PatchSetBindingVB(code, "greetLabel", "Function(lbl) lbl.Text", "LabelControl, String", "Function(x) x.Greeting", "AppLogoViewModel, String")
                End If
                If code.IndexOf("AppViewModel") > 0 And code.IndexOf("AppLogoViewModel") > 0 Then
                    code = PatchEventToCommandAsyncActionVB(code, "OnShown", "AppViewModel")
                End If
                If code.IndexOf("ItemsViewModel") > 0 Then
                    code = PatchSetBindingVB(code, "titleLabel", "Function(lbl) lbl.Text", "LabelControl, String", "Function(x) x.Title", "ItemsViewModel, String")
                    code = PatchSetBindingVB(code, "ToggleSwitch, Object, Boolean", "toggleShowAll", "Function(tgl) tgl.EditValue", "ToggleSwitch, Object", "Function(x) x.ShowAllItems", "ItemsViewModel, Boolean")
                    code = PatchSetBindingVB(code, "BindingSource, Object, IList(Of TodoItem)", "todoItemBindingSource", "Function(bs) bs.DataSource", "BindingSource, Object", "Function(x) x.Items", "ItemsViewModel, IList(Of TodoItem)")
                    code = PatchSetBindingVB(code, "ListBoxControl, Object, TodoItem", "listBoxControl", "Function(lb) lb.SelectedValue", "ListBoxControl, Object", "Function(x) x.SelectedItem", "ItemsViewModel, TodoItem")
                End If
                If code.IndexOf("ItemViewModel") > 0 Then
                    code = PatchSetBindingVB(code, "titleLabel", "Function(lbl) lbl.Text", "LabelControl, String", "Function(x) x.Title", "ItemViewModel, String")
                    code = PatchBindCommandActionVB(code, "btnBack", "Close", "ItemViewModel")
                    code = PatchBindCommandActionVB(code, "btnSave", "Save", "ItemViewModel")
                    code = PatchBindCommandActionVB(code, "btnDelete", "Delete", "ItemViewModel")
                    code = PatchSetObjectDataSourceBindingVB(code, "todoItemBindingSource", "Function(x) x.Item", "ItemViewModel, TodoItem", "Sub(x) x.Update()", "ItemViewModel")
                End If
            End If
            Return code
        End Function
    End Class
End Namespace
