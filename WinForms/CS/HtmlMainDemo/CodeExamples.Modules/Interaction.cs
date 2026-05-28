using System.Collections.Generic;
using DevExpress.DXperience.Demos.CodeDemo;

namespace DevExpress.HTML.Demos {
    public partial class Interaction : CodeTutorialControl {
        public Interaction() {
            InitializeComponent();
        }
        protected override List<string> InitializeHighlightTokens() {
            var list = base.InitializeHighlightTokens();
            list.Add("Assets");
            list.Add("MVVMContext");
            list.Add("ISupportParameter");
            list.Add("IDocumentContent");
            list.Add("IMessageBoxService");
            list.Add("IWindowService");
            list.Add("IWindow");
            list.Add("IPopupWindow");
            list.Add("WindowShowMode");
            return list;
        }
        protected override string PreprocessCodeBeforeLoading(string moduleName, string code, ExampleLanguage language) {
            if(language == ExampleLanguage.VB) {
                code = code.Replace("Function(x) AddressOf x.Phone", "Sub(x) x.Phone()");
                code = code.Replace("Function(x) AddressOf x.Video", "Sub(x) x.Video()");
                code = code.Replace("Function(x) AddressOf x.TextMessage", "Sub(x) x.TextMessage()");
                code = code.Replace("Function(x) AddressOf x.ShowPopup", "Sub(x) x.ShowPopup()");
                code = code.Replace("Function(x) AddressOf x.ShowDialog", "Sub(x) x.ShowDialog()");
                code = code.Replace("Function(x) AddressOf x.Close", "Sub(x) x.Close()");
                code = code.Replace("Function(x) AddressOf x.Accept", "Sub(x) x.Accept()");
            }
            return code;
        }
        protected override string PreprocessCodeBeforeCompilation(string code, ExampleLanguage language) {
            if(language == ExampleLanguage.Csharp)
                code = ReplaceCS(code);
            else {
                code = ReplaceVB(code);
                // MVVM ViewModels
                code = code.Replace("DevExpress.HTML.Demos.CodeExamples.Interaction_ElementMouseClick.ViewModel", "DXSample.SampleClass.ViewModel");
                code = code.Replace("DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.MainViewModel", "DXSample.SampleClass.MainViewModel");
                code = code.Replace("DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.PopupViewModel", "DXSample.SampleClass.PopupViewModel");
                code = code.Replace("DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.DialogViewModel", "DXSample.SampleClass.DialogViewModel");
            }
            return base.PreprocessCodeBeforeCompilation(code, language);
        }
        protected override string PreprocessCodeBeforeOpen(string code, ExampleLanguage language) {
            if(language == ExampleLanguage.Csharp)
                code = ReplaceCS(code);
            else {
                code = ReplaceVB(code);
                // MVVM ViewModels
                code = code.Replace("DevExpress.HTML.Demos.CodeExamples.Interaction_ElementMouseClick.ViewModel", "ViewModel");
                code = code.Replace("DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.MainViewModel", "MainViewModel");
                code = code.Replace("DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.PopupViewModel", "PopupViewModel");
                code = code.Replace("DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.DialogViewModel", "DialogViewModel");
            }
            return base.PreprocessCodeBeforeOpen(code, language);
        }
        string ReplaceCS(string code) {
            if(code.Contains("MainView"))
                code = code.Replace("XtraUserControl mainView = null", "MainView mainView = new MainView()");
            if(code.Contains("MainMenuView"))
                code = code.Replace("XtraUserControl mainMenuView = null", "MainMenuView mainMenuView = new MainMenuView()");
            if(code.Contains("TooltipView"))
                code = code.Replace("XtraUserControl tooltipView = null", "TooltipView tooltipView = new TooltipView()");
            if(code.Contains("DialogView"))
                code = code.Replace("XtraUserControl dialogView = null", "DialogView dialogView = new DialogView()");
            if(code.Contains("PopupView"))
                code = code.Replace("XtraUserControl popupView = null", "PopupView popupView = new PopupView()");
            return code;
        }
        string ReplaceVB(string code) {
            if(code.Contains("MainView"))
                code = code.Replace("Dim mainView As DevExpress.XtraEditors.XtraUserControl = Nothing", "Dim mainView = new MainView()");
            if(code.Contains("MainMenuView"))
                code = code.Replace("Dim mainMenuView As DevExpress.XtraEditors.XtraUserControl = Nothing", "Dim mainMenuView = new MainMenuView()");
            if(code.Contains("TooltipView"))
                code = code.Replace("Dim tooltipView As DevExpress.XtraEditors.XtraUserControl = Nothing", "Dim tooltipView = new TooltipView()");
            if(code.Contains("DialogView"))
                code = code.Replace("Dim dialogView As DevExpress.XtraEditors.XtraUserControl = Nothing", "Dim dialogView = new DialogView()");
            if(code.Contains("PopupView"))
                code = code.Replace("Dim popupView As DevExpress.XtraEditors.XtraUserControl = Nothing", "Dim popupView = new PopupView()");
            // Namespaces
            code = code.Replace(" Utils.DefaultBoolean.", " DevExpress.Utils.DefaultBoolean.");
            code = code.Replace(" Utils.PlacementHelper.", " DevExpress.Utils.PlacementHelper.");
            // MVVM Bindings
            code = PatchBindCommandToElementActionVB(code, "htmlContentControl", "btnPhone", "Phone", "ViewModel");
            code = PatchBindCommandToElementActionVB(code, "htmlContentControl", "btnVideo", "Video", "ViewModel");
            code = PatchBindCommandToElementActionVB(code, "htmlContentControl", "btnText", "TextMessage", "ViewModel");
            code = PatchBindCommandToElementActionVB(code, "menuBar", "miPopup", "ShowPopup", "MainViewModel");
            code = PatchBindCommandToElementActionVB(code, "menuBar", "miDialog", "ShowDialog", "MainViewModel");
            code = PatchBindCommandActionVB(code, "btnClose", "Close", "DialogViewModel", "dlgFluent");
            code = PatchBindCommandActionVB(code, "btnAccept", "Accept", "DialogViewModel", "dlgFluent");
            return code;
        }
    }
}
