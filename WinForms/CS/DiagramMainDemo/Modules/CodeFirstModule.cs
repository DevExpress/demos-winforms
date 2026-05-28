using System;
using System.Linq;
using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;

namespace DevExpress.XtraDiagram.Demos {
    public class CodeFirstModule : CodeTutorialControlBase {
        static CodeFirstModule() {
            using(new DiagramControl()) { }
        }
        protected override ExampleLanguage CurrentExampleLanguage { get { return DemoHelper.GetLanguageString(typeof(CodeFirstModule).Assembly) == "CS" ? ExampleLanguage.Csharp : ExampleLanguage.VB; } }
        protected override string[] FileNamesForModule { get { return new[] { "GenericExamples.cs" }; } }
    }
}
