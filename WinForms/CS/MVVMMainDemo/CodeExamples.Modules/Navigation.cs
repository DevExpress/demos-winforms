using DevExpress.DXperience.Demos.CodeDemo;

namespace DevExpress.MVVM.Demos.CodeExamples {
    public class NavigationModule : CodeTutorialControl {
        public NavigationModule()
            : base() {
        }
        protected override string PreprocessCodeBeforeCompilation(string code, ExampleLanguage language) {
            if(language == ExampleLanguage.Csharp) {
                code = code.Replace("typeof(MainViewModel)", "typeof(DXSample.SampleClass.MainViewModel)");
                code = code.Replace("typeof(AcceptFormViewModel)", "typeof(DXSample.SampleClass.AcceptFormViewModel)");
            }
            return code;
        }
        protected override string PreprocessCodeBeforeOpen(string code, ExampleLanguage language) {
            if(language == ExampleLanguage.Csharp)
                code = code.Replace("mainView.Parent = sampleHost", "mainView.Parent = this");
            return code;
        }
    }
}
