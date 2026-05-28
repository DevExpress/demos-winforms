Imports System.Collections.Generic
Imports DevExpress.DXperience.Demos.CodeDemo

Namespace DevExpress.HTML.Demos

    Public Partial Class Interaction
        Inherits DevExpress.HTML.Demos.CodeTutorialControl

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Protected Overrides Function InitializeHighlightTokens() As List(Of String)
            Dim list = MyBase.InitializeHighlightTokens()
            list.Add("Assets")
            list.Add("MVVMContext")
            list.Add("ISupportParameter")
            list.Add("IDocumentContent")
            list.Add("IMessageBoxService")
            list.Add("IWindowService")
            list.Add("IWindow")
            list.Add("IPopupWindow")
            list.Add("WindowShowMode")
            Return list
        End Function

        Protected Overrides Function PreprocessCodeBeforeLoading(ByVal moduleName As String, ByVal code As String, ByVal language As DevExpress.DXperience.Demos.CodeDemo.ExampleLanguage) As String
            If language = DevExpress.DXperience.Demos.CodeDemo.ExampleLanguage.VB Then
                code = code.Replace("Function(x) AddressOf x.Phone", "Sub(x) x.Phone()")
                code = code.Replace("Function(x) AddressOf x.Video", "Sub(x) x.Video()")
                code = code.Replace("Function(x) AddressOf x.TextMessage", "Sub(x) x.TextMessage()")
                code = code.Replace("Function(x) AddressOf x.ShowPopup", "Sub(x) x.ShowPopup()")
                code = code.Replace("Function(x) AddressOf x.ShowDialog", "Sub(x) x.ShowDialog()")
                code = code.Replace("Function(x) AddressOf x.Close", "Sub(x) x.Close()")
                code = code.Replace("Function(x) AddressOf x.Accept", "Sub(x) x.Accept()")
            End If

            Return code
        End Function

        Protected Overrides Function PreprocessCodeBeforeCompilation(ByVal code As String, ByVal language As DevExpress.DXperience.Demos.CodeDemo.ExampleLanguage) As String
            If language = DevExpress.DXperience.Demos.CodeDemo.ExampleLanguage.Csharp Then
                code = Me.ReplaceCS(code)
            Else
                code = Me.ReplaceVB(code)
                ' MVVM ViewModels
                code = code.Replace("DevExpress.HTML.Demos.CodeExamples.Interaction_ElementMouseClick.ViewModel", "DXSample.SampleClass.ViewModel")
                code = code.Replace("DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.MainViewModel", "DXSample.SampleClass.MainViewModel")
                code = code.Replace("DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.PopupViewModel", "DXSample.SampleClass.PopupViewModel")
                code = code.Replace("DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.DialogViewModel", "DXSample.SampleClass.DialogViewModel")
            End If

            Return MyBase.PreprocessCodeBeforeCompilation(code, language)
        End Function

        Protected Overrides Function PreprocessCodeBeforeOpen(ByVal code As String, ByVal language As DevExpress.DXperience.Demos.CodeDemo.ExampleLanguage) As String
            If language = DevExpress.DXperience.Demos.CodeDemo.ExampleLanguage.Csharp Then
                code = Me.ReplaceCS(code)
            Else
                code = Me.ReplaceVB(code)
                ' MVVM ViewModels
                code = code.Replace("DevExpress.HTML.Demos.CodeExamples.Interaction_ElementMouseClick.ViewModel", "ViewModel")
                code = code.Replace("DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.MainViewModel", "MainViewModel")
                code = code.Replace("DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.PopupViewModel", "PopupViewModel")
                code = code.Replace("DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.DialogViewModel", "DialogViewModel")
            End If

            Return MyBase.PreprocessCodeBeforeOpen(code, language)
        End Function

        Private Function ReplaceCS(ByVal code As String) As String
            If code.Contains("MainView") Then code = code.Replace("XtraUserControl mainView = null", "MainView mainView = new MainView()")
            If code.Contains("MainMenuView") Then code = code.Replace("XtraUserControl mainMenuView = null", "MainMenuView mainMenuView = new MainMenuView()")
            If code.Contains("TooltipView") Then code = code.Replace("XtraUserControl tooltipView = null", "TooltipView tooltipView = new TooltipView()")
            If code.Contains("DialogView") Then code = code.Replace("XtraUserControl dialogView = null", "DialogView dialogView = new DialogView()")
            If code.Contains("PopupView") Then code = code.Replace("XtraUserControl popupView = null", "PopupView popupView = new PopupView()")
            Return code
        End Function

        Private Function ReplaceVB(ByVal code As String) As String
            If code.Contains("MainView") Then code = code.Replace("Dim mainView As DevExpress.XtraEditors.XtraUserControl = Nothing", "Dim mainView = new MainView()")
            If code.Contains("MainMenuView") Then code = code.Replace("Dim mainMenuView As DevExpress.XtraEditors.XtraUserControl = Nothing", "Dim mainMenuView = new MainMenuView()")
            If code.Contains("TooltipView") Then code = code.Replace("Dim tooltipView As DevExpress.XtraEditors.XtraUserControl = Nothing", "Dim tooltipView = new TooltipView()")
            If code.Contains("DialogView") Then code = code.Replace("Dim dialogView As DevExpress.XtraEditors.XtraUserControl = Nothing", "Dim dialogView = new DialogView()")
            If code.Contains("PopupView") Then code = code.Replace("Dim popupView As DevExpress.XtraEditors.XtraUserControl = Nothing", "Dim popupView = new PopupView()")
            ' Namespaces
            code = code.Replace(" Utils.DefaultBoolean.", " DevExpress.Utils.DefaultBoolean.")
            code = code.Replace(" Utils.PlacementHelper.", " DevExpress.Utils.PlacementHelper.")
            ' MVVM Bindings
            code = Me.PatchBindCommandToElementActionVB(code, "htmlContentControl", "btnPhone", "Phone", "ViewModel")
            code = Me.PatchBindCommandToElementActionVB(code, "htmlContentControl", "btnVideo", "Video", "ViewModel")
            code = Me.PatchBindCommandToElementActionVB(code, "htmlContentControl", "btnText", "TextMessage", "ViewModel")
            code = Me.PatchBindCommandToElementActionVB(code, "menuBar", "miPopup", "ShowPopup", "MainViewModel")
            code = Me.PatchBindCommandToElementActionVB(code, "menuBar", "miDialog", "ShowDialog", "MainViewModel")
            code = Me.PatchBindCommandActionVB(code, "btnClose", "Close", "DialogViewModel", "dlgFluent")
            code = Me.PatchBindCommandActionVB(code, "btnAccept", "Accept", "DialogViewModel", "dlgFluent")
            Return code
        End Function
    End Class
End Namespace
